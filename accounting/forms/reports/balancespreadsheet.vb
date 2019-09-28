Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class balancespreadsheet
    Dim ds As New balancesheet_set
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txt_year_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_year_from.ValueChanged
        txt_year_from.Value = txt_year_to.Value
    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim month_from = txt_month_from.Value
        Dim month_to = txt_month_to.Value
        Dim year_from = txt_year_from.Value
        Dim year_to = txt_year_to.Value
        Dim withZero = includeZero.Checked
        Dim perGroup = byGroup.Checked
        Dim date_from As New Date(year_from, month_from, DateSerial(year_from, month_from + 1, 0).ToString("dd"))
        Dim date_to As New Date(year_to, month_to, DateSerial(year_to, month_to + 1, 0).ToString("dd"))

        Dim sql As String = String.Format("SELECT a.account_code,a.account_name,a.chart_group_name,a.chart_class_name " & _
",b.debit,b.credit,b.cover_month " & _
" FROM selectincomestatement a " & _
" LEFT JOIN ( " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,1 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 1 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,2 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 2 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,3 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 3 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,4 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 4 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,5 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 5 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,6 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 6 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,7 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 7 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,8 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 8 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,9 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 9 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,10 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 10 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,11 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 11 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" 	UNION " & _
" 	SELECT a.account_id,a.account_code,a.account_name,a.debit,a.credit,a.chart_type,12 AS cover_month " & _
" 	FROM selectincomestatement a " & _
" 	WHERE MONTH(a.trans_date) = 12 AND YEAR(a.trans_date) = {0} " & _
" 	GROUP BY a.account_id " & _
" ) b ON b.account_id = a.account_id ", year_to)

        If Not withZero Then
            sql &= " where b.cover_month is not null "
        End If

        sql &= " GROUP BY a.account_id,b.cover_month " & _
               " ORDER BY a.account_code,b.cover_month "

        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin " & _
                                                  "FROM sys_default a " & _
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id", _serverDBFS)

        Dim dt As DataTable = Query(sql)
        Dim dt_company As DataTable = Query(sql_company)

        ds.Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("Balance").ImportRow(row)
        Next

        For Each row As DataRow In dt_company.Rows
            ds.Tables("Company").ImportRow(row)
        Next

        Dim dicHeader As New Dictionary(Of String, String)
        dicHeader.Add("templateName", "spreadsheet.xlt")
        dicHeader.Add("companyName", "")
        If dt_company.Rows.Count > 0 Then
            dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
        End If
        Dim strGrouping As String = "chart_class_name"
        If perGroup Then
            strGrouping &= ",chart_group_name"
        End If
        Dim listAccount = groupDataTableToList(ds.Tables("Balance"), strGrouping)
        Try
            lblLoad.Visible = True
            generateExcelReport(listAccount, strGrouping, dicHeader)
            MsgBox("Report Done")
            lblLoad.Visible = False
        Catch ex As Exception
            lblLoad.Visible = False
            MsgBox(String.Format("Error Occured : {0}", ex.Message))
            MyDebugging.AddText(ex.Message)
        End Try
    End Sub
    Private Sub generateExcelReport(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String))
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHeader.Item("templateName"))
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = "Balance Sheet Spreadsheet"
        xlWorkSheet.Cells(4, 2) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 3) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 4) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 5) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 6) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 7) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 8) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 9) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 10) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 11) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 12) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 13) = "'" & txt_year_to.Value
        xlWorkSheet.Cells(4, 14) = "'" & txt_year_to.Value

        Dim current_row As Integer = 5
        Dim current_index As Integer = 0
        generateExcelGroup(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)
    End Sub
    Private Sub generateExcelGroup(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        current_index += 1
        For Each item In listAccount
            Dim dicItem = Nothing
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field
                    Case "chart_type_code"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim first_row = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                        current_index -= 1
                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & dicItem.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        xlWorkSheet.Cells(current_row, 2) = String.Format("=SUBTOTAL(9,B{0}:B{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        current_row += 1
                        current_row += 1
                    Case "chart_class_name"
                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim first_row = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & dicItem.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        xlWorkSheet.Cells(current_row, 2) = String.Format("=SUBTOTAL(9,B{0}:B{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                        current_row += 1
                    Case "chart_group_name"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 1
                        current_row += 1
                        Dim first_row = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & dicItem.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 1
                        xlWorkSheet.Cells(current_row, 2) = String.Format("=SUBTOTAL(9,B{0}:B{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        current_row += 1
                End Select
            Else
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 1
                current_row += 1
                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If
                    xlWorkSheet.Cells(current_row, 1) = dic.Item("account_name")
                    If dic.item("cover_month") = 1 Then
                        xlWorkSheet.Cells(current_row, 2) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 2 Then
                        xlWorkSheet.Cells(current_row, 3) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 3 Then
                        xlWorkSheet.Cells(current_row, 4) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 4 Then
                        xlWorkSheet.Cells(current_row, 5) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 5 Then
                        xlWorkSheet.Cells(current_row, 6) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 6 Then
                        xlWorkSheet.Cells(current_row, 7) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 7 Then
                        xlWorkSheet.Cells(current_row, 8) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 8 Then
                        xlWorkSheet.Cells(current_row, 9) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 9 Then
                        xlWorkSheet.Cells(current_row, 10) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 10 Then
                        xlWorkSheet.Cells(current_row, 11) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 11 Then
                        xlWorkSheet.Cells(current_row, 12) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    ElseIf dic.item("cover_month") = 12 Then
                        xlWorkSheet.Cells(current_row, 13) = CType(dic.item("debit"), Decimal) + CType(dic.item("credit"), Decimal)
                    End If
                    xlWorkSheet.Cells(current_row, 14) = String.Format("=SUM(B{0}:M{0})", current_row)
                    current_row += 1
                Next
                xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & dicItem.Item(field) & " : "
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 1
                xlWorkSheet.Cells(current_row, 2) = String.Format("=SUBTOTAL(9,B{0}:B{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                current_row += 1
            End If
        Next
    End Sub
End Class