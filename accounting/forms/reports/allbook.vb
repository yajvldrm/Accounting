Imports Microsoft.Office.Interop
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class allbook
    Private strChar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private strCharacter As String = ""
    Private Sub generateString()
        strCharacter = ""
        For i As Integer = 0 To strChar.Length - 1
            strCharacter &= strChar.Substring(i, 1)
        Next
        For i As Integer = 0 To strChar.Length - 1
            For j As Integer = i To strChar.Length - 1
                strCharacter &= strChar.Substring(i, 1) & strChar.Substring(j, 1)
            Next
        Next
    End Sub
    Private Function getColumnCharacter(ByVal i As Integer) As String
        'Dim returnStr As String = ""
        'If i <= 25 Then
        '    returnStr = strCharacter.Substring(i, 1)
        'Else
        '    returnStr = strCharacter.Substring(i, 2)
        'End If
        'Return returnStr
        Return ConvertToLetter(i)
    End Function
    Public Property journal_id As String = ""
    Public Property journal_name As String = ""
    Private Sub ChangeDateType(ByVal id As String)
        txt_date_from.Enabled = False
        txt_date_to.Enabled = False
        txt_month.Enabled = False
        txt_year.Enabled = False
        Select Case id
            Case "1"
                txt_date_from.Enabled = True
                txt_date_to.Enabled = True
            Case "2"
                txt_date_to.Enabled = True
            Case "3"
                txt_month.Enabled = True
                txt_year.Enabled = True
        End Select
    End Sub
    Private Sub init()
        originalCurrency.Checked = False
        date_type.Value = "1"
        txt_date_from.Value = Today.ToString("MM/01/yyyy")
        txt_date_to.Value = GetLastDayOfMonth(Today.Month, Today.Year)
        txt_month.SelectedIndex = Today.Month - 1
        txt_year.Value = Today.Year
        Me.Text = journal_name
        lblTitle.Text = journal_name
        generateString()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub date_type_ValueChange(sender As Object, e As EventArgs) Handles date_type.ValueChange
        ChangeDateType(date_type.Value)
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dicHead As New Dictionary(Of String, String)
        dicHead.Add("company_name", main.Sys_Default.Rows(0).Item("company_name").ToString)
        dicHead.Add("journal_name", journal_name)
        dicHead.Add("journal_id", journal_id)

        Dim str_date_filter As String = ""
        Dim str_condition As String = ""
        Select Case date_type.Value
            Case "1"
                If txt_date_from.Value > txt_date_to.Value Then
                    MsgBox("Invalid date range.")
                    Exit Sub
                Else
                    str_date_filter = String.Format("From {0} To {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
                    str_condition = String.Format("a.trans_date BETWEEN '{0}' AND '{1}'", _
                        txt_date_from.Value.ToString("yyyy-MM-dd"), txt_date_to.Value.ToString("yyyy-MM-dd"))
                End If
            Case "2"
                str_date_filter = String.Format("As Of {0}", txt_date_to.Value.ToString("MMMM dd, yyyy"))
                str_condition = String.Format("a.trans_date <= '{0}'", _
                        txt_date_to.Value.ToString("yyyy-MM-dd"))
            Case "3"
                str_date_filter = String.Format("For the month of {0} {1}", txt_month.Text, txt_year.Value)
                str_condition = String.Format("MONTH(a.trans_date) = '{0}' AND YEAR(a.trans_date) = '{1}'", _
                        txt_month.SelectedIndex + 1, txt_year.Value)
            Case Else
                MsgBox("No Date Selected.")
                Exit Sub
        End Select
        dicHead.Add("date_filter", str_date_filter)

        Dim strFields = "account_id,account_code,account_name".Split(",")

        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " &
            ",a.description,a.general_id,a.account_id,a.journal_id,a.amount,a.amount_based " &
            ",a.general_code,a.general_name,a.tin,a.check_no,a.account_code,a.account_name " &
            ",a.currency_id,a.currency_code,a.currency_name
            ,a.project_id,a.project_code,a.project_name
            ,a.department_id,a.department_code,a.department_name
            " &
            "FROM SelectTransactionBook a " &
            "LEFT JOIN {2}.lib_erp_book b ON b.book_id = a.book_id " &
            "WHERE {0} AND (a.journal_id = '{1}' OR a.journal_id = 8) " &
            "AND b.company_id = '{3}' " & vbNewLine &
            "", str_condition, journal_id, _serverDBFS, main.Sys_Default.Rows(0).Item("company_id").ToString)
        Dim dt As DataTable = Query(sql)

        Dim sql_col As String = String.Format("SELECT a.account_id,a.account_code,a.account_name " &
            "FROM SelectTransactionBook a " &
            "WHERE {0} AND a.journal_id = '{1}' " &
            "GROUP BY a.account_id " &
            "ORDER BY a.account_code ", str_condition, journal_id)
        'If withProject.Checked Then
        '    sql_col = String.Format("SELECT a.account_id,a.account_code,a.account_name " &
        '    "FROM SelectTransactionBook a " &
        '    "WHERE {0} AND a.journal_id = '{1}' " &
        '    "GROUP BY a.account_id,a.project_id " &
        '    "ORDER BY a.account_code ", str_condition, journal_id)
        'End If
        Dim dt_col As DataTable = Query(sql_col)

        Dim newDt As DataTable = dt.Clone
        newDt.Clear()
        newDt.TableName = "Book"
        'For Each dc As DataColumn In dt.Columns
        '    Dim newDc As New DataColumn
        '    newDc.ColumnName = dc.ColumnName
        '    newDc.DataType = dc.DataType
        '    newDt.Columns.Add(newDc)
        'Next
        If dt.Rows.Count = 0 Then
            MsgBox("No Records to Print.")
            Exit Sub
        End If
        For Each dr As DataRow In dt_col.Rows
            newDt.Columns.Add(CreateDataColumn("amount_" & dr.Item("account_id").ToString, "System.String", "amount_" & dr.Item("account_id").ToString))
            newDt.Columns.Add(CreateDataColumn("amount_based_" & dr.Item("account_id").ToString, "System.String", "amount_based_" & dr.Item("account_id").ToString))
        Next
        Dim lstID As New List(Of String)
        Dim dicID As New Dictionary(Of String, List(Of String))
        If withProject.Checked Then
            For Each dr As DataRow In dt.Rows
                Dim newDr As DataRow = newDt.NewRow
                For Each col As DataColumn In dt.Columns
                    Dim val = If(ifNull(dr.Item(col.ColumnName), "").ToString = "", DBNull.Value, dr.Item(col.ColumnName))
                    newDr.Item(col.ColumnName) = val
                Next
                Dim trans_id As String = dr.Item("trans_id").ToString
                Dim project_id As String = dr.Item("project_id").ToString
                If dicID.ContainsKey(trans_id) Then
                    If dicID(trans_id).Contains(dr.Item("project_id").ToString) Then
                        Dim selectedTransactions = newDt.Select(String.Format("trans_id = '{0}' AND project_id = '{1}'", trans_id, project_id))
                        If selectedTransactions.Length Then
                            Dim selectedTransaction = selectedTransactions(0)
                            If newDt.Columns.Contains("amount_" & dr.Item("account_id").ToString) Then
                                selectedTransaction.Item("amount_" & dr.Item("account_id").ToString) = CDec(ifNull(selectedTransaction.Item("amount_" & dr.Item("account_id").ToString), 0)) + CDec(ifNull(dr.Item("amount").ToString, 0))
                                selectedTransaction.Item("amount_based_" & dr.Item("account_id").ToString) = CDec(ifNull(selectedTransaction.Item("amount_based_" & dr.Item("account_id").ToString), 0)) + CDec(ifNull(dr.Item("amount_based").ToString, 0))
                            End If
                        End If
                    Else
                        dicID(trans_id).Add(project_id)
                        If newDt.Columns.Contains("amount_" & dr.Item("account_id").ToString) Then
                            newDr.Item("amount_" & dr.Item("account_id").ToString) = CDec(ifNull(dr.Item("amount").ToString, 0))
                            newDr.Item("amount_based_" & dr.Item("account_id").ToString) = CDec(ifNull(dr.Item("amount_based").ToString, 0))
                        End If
                        newDt.Rows.Add(newDr)
                    End If
                Else
                    dicID.Add(trans_id, New List(Of String))
                    dicID(trans_id).Add(project_id)
                    If newDt.Columns.Contains("amount_" & dr.Item("account_id").ToString) Then
                        newDr.Item("amount_" & dr.Item("account_id").ToString) = CDec(ifNull(dr.Item("amount").ToString, 0))
                        newDr.Item("amount_based_" & dr.Item("account_id").ToString) = CDec(ifNull(dr.Item("amount_based").ToString, 0))
                    End If
                    newDt.Rows.Add(newDr)
                End If
            Next
        Else
            For Each dr As DataRow In dt.Rows
                Dim newDr = newDt.NewRow
                For Each col As DataColumn In dt.Columns
                    Dim val = If(ifNull(dr.Item(col.ColumnName), "").ToString = "", DBNull.Value, dr.Item(col.ColumnName))
                    newDr.Item(col.ColumnName) = val
                Next
                If lstID.Contains(dr.Item("trans_id").ToString) Then
                    Dim selectedTransactions = newDt.Select("trans_id = " & dr.Item("trans_id"))
                    If selectedTransactions.Length Then
                        Dim selectedTransaction = selectedTransactions(0)
                        If newDt.Columns.Contains("amount_" & dr.Item("account_id").ToString) Then
                            selectedTransaction.Item("amount_" & dr.Item("account_id").ToString) = CDec(ifNull(selectedTransaction.Item("amount_" & dr.Item("account_id").ToString), 0)) + CDec(ifNull(dr.Item("amount").ToString, 0))
                            selectedTransaction.Item("amount_based_" & dr.Item("account_id").ToString) = CDec(ifNull(selectedTransaction.Item("amount_based_" & dr.Item("account_id").ToString), 0)) + CDec(ifNull(dr.Item("amount_based").ToString, 0))
                        End If
                    End If
                Else
                    lstID.Add(dr.Item("trans_id").ToString)
                    If newDt.Columns.Contains("amount_" & dr.Item("account_id").ToString) Then
                        newDr.Item("amount_" & dr.Item("account_id").ToString) = CDec(ifNull(dr.Item("amount").ToString, 0))
                        newDr.Item("amount_based_" & dr.Item("account_id").ToString) = CDec(ifNull(dr.Item("amount_based").ToString, 0))
                    End If
                    newDt.Rows.Add(newDr)
                End If
            Next
        End If
        'Dim lstID As New List(Of String)
        Try
            dicHead.Add("withProject", If(withProject.Checked, "1", "0"))
            lblLoad.Visible = True
            If originalCurrency.Checked Or withProject.Checked Then
                Dim strGroup As String = ""
                If originalCurrency.Checked Then
                    strGroup &= ",currency_name"
                End If
                If withProject.Checked Then
                    strGroup &= ",trans_no,project_name"
                End If
                Dim lstAccount = groupDataTableToList(newDt, strGroup.Substring(1))
                generateExcelReport(dicHead, newDt, dt_col, originalCurrency.Checked, lstAccount)
                'MsgBox("Data Succesfully Load")
            Else
                generateExcelReport(dicHead, newDt, dt_col, originalCurrency.Checked)
                'MsgBox("Data Succesfully Load")
            End If
            MsgBox("Report Done")
            lblLoad.Visible = False
        Catch ex As Exception
            lblLoad.Visible = False
            MsgBox(String.Format("Error Occured : {0}", ex.Message))
            MyDebugging.AddText(ex.Message)
        End Try
    End Sub
    Private Sub allbook_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        init()
    End Sub
    Private Sub generateExcelReport(ByVal dic As Dictionary(Of String, String), ByVal dt As DataTable, ByVal dt_account As DataTable, ByVal originalCurrency As Boolean, Optional lstAccount As List(Of Object) = Nothing)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dic.Item("company_name").ToString
        xlWorkSheet.Cells(2, 1) = dic.Item("journal_name").ToString.ToUpper
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 1)).Font.Bold = True
        xlWorkSheet.Cells(3, 1) = dic.Item("date_filter").ToString

        Dim currentColumn As Integer = 1

        xlWorkSheet.Cells(5, currentColumn) = "Date"
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 1)).ColumnWidth = 13
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 1)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 2), xlWorkSheet.Cells(1, 2)).ColumnWidth = 20
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 2), xlWorkSheet.Cells(5, 2)).Font.Bold = True
        currentColumn += 1
        Select Case dic.Item("journal_id").ToString
            Case "1"
                xlWorkSheet.Cells(5, currentColumn) = "Invoicing No"
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Client"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 50
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
            Case "2"
                xlWorkSheet.Cells(5, currentColumn) = "O.R. No"
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Check No"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 15
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Customer"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 50
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
            Case "3"
                xlWorkSheet.Cells(5, currentColumn) = "Purchase No"
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Supplier"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 50
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
            Case "4"
                xlWorkSheet.Cells(5, currentColumn) = "Disbursement No"
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Check No"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 15
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Payee"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 50
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
            Case "5"
                xlWorkSheet.Cells(5, currentColumn) = "Journal No"
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Client"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 50
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
            Case "6"
                xlWorkSheet.Cells(5, currentColumn) = "Petty Cash No"
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Customer"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 50
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
            Case "7"
                xlWorkSheet.Cells(5, currentColumn) = "Debit / Credit No"
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
                xlWorkSheet.Cells(5, currentColumn) = "Client"
                xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 50
                xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                currentColumn += 1
        End Select
        If withProject.Checked Then
            xlWorkSheet.Cells(5, currentColumn) = "Project"
            xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 50
            xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
            currentColumn += 1
        End If
        xlWorkSheet.Cells(5, currentColumn) = "TIN"
        xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 20
        xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
        currentColumn += 1
        xlWorkSheet.Cells(5, currentColumn) = "Particulars"
        xlWorkSheet.Range(xlWorkSheet.Cells(1, currentColumn), xlWorkSheet.Cells(1, currentColumn)).ColumnWidth = 70
        xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
        currentColumn += 1
        For Each col As DataColumn In dt.Columns
            If IsNumeric(col.ColumnName.ToString.Replace("amount_", "")) Then
                Dim id = col.ColumnName.ToString.Replace("amount_", "")
                Dim selectedAccounts = dt_account.Select("account_id = " & id)
                If selectedAccounts.Length > 0 Then
                    Dim selectedAccount = selectedAccounts(0)
                    xlWorkSheet.Cells(5, currentColumn) = selectedAccount.Item("account_name")
                    xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).ColumnWidth = 30
                    xlWorkSheet.Range(xlWorkSheet.Cells(5, currentColumn), xlWorkSheet.Cells(5, currentColumn)).Font.Bold = True
                    currentColumn += 1
                End If
            End If
        Next
        If lstAccount Is Nothing Then
            Dim currentRow As Integer = 7
            Dim rowStart As Integer = currentRow
            For Each dr As DataRow In dt.Rows
                currentColumn = 1
                xlWorkSheet.Cells(currentRow, currentColumn) = CDate(dr.Item("trans_date")).ToString("MM/dd/yyyy")
                currentColumn += 1
                xlWorkSheet.Cells(currentRow, currentColumn) = "'" & dr.Item("trans_no").ToString
                currentColumn += 1
                If journal_id = "2" Or journal_id = "4" Then
                    xlWorkSheet.Cells(currentRow, currentColumn) = "'" & dr.Item("check_no").ToString
                    currentColumn += 1
                End If
                xlWorkSheet.Cells(currentRow, currentColumn) = dr.Item("general_name").ToString
                currentColumn += 1
                xlWorkSheet.Cells(currentRow, currentColumn) = dr.Item("tin").ToString
                currentColumn += 1
                xlWorkSheet.Cells(currentRow, currentColumn) = dr.Item("description").ToString
                currentColumn += 1
                For Each col As DataColumn In dt.Columns
                    If originalCurrency Then
                        If IsNumeric(col.ColumnName.ToString.Replace("amount_", "")) Then
                            Dim r = xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn))
                            Dim num As Decimal = CDec(ifNull(r.Value, 0))
                            Dim value As Decimal = CDec(ifNull(dr.Item(col.ColumnName).ToString, 0))
                            r.Clear()
                            r.Value = num + value
                            r.NumberFormat = "#,##0.00_);(#,##0.00)"
                            currentColumn += 1
                        End If
                    Else
                        If IsNumeric(col.ColumnName.ToString.Replace("amount_based_", "")) Then
                            Dim r = xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn))
                            Dim num As Decimal = CDec(ifNull(r.Value, 0))
                            Dim value As Decimal = CDec(ifNull(dr.Item(col.ColumnName).ToString, 0))
                            r.Clear()
                            r.Value = num + value
                            r.NumberFormat = "#,##0.00_);(#,##0.00)"
                            currentColumn += 1
                        End If
                    End If
                Next
                currentRow += 1
            Next
            If journal_id = "2" Or journal_id = "4" Then
                currentColumn = 7
            Else
                currentColumn = 6
            End If
            If withProject.Checked Then
                currentColumn += 1
            End If
            Dim colStart As Integer = currentColumn
            For Each col As DataColumn In dt.Columns
                If IsNumeric(col.ColumnName.ToString.Replace("amount_", "")) Then
                    Try
                        xlWorkSheet.Cells(currentRow, currentColumn) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), rowStart, currentRow - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                    Catch ex As Exception
                        MyDebugging.AddText(String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), rowStart, currentRow - 1))
                    End Try
                    currentColumn += 1
                End If
            Next
            xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, colStart), xlWorkSheet.Cells(currentRow, currentColumn - 1)).Font.Bold = True
        Else
            Dim firstRow As Integer = 6
            Dim currentRow As Integer = 6
            For Each a In lstAccount
                If TypeOf a Is Dictionary(Of String, Object) Then
                    Dim b = CType(a, Dictionary(Of String, Object))
                    If b.ContainsKey("currency_name") Then
                        currentColumn = 1
                        xlWorkSheet.Cells(currentRow, currentColumn) = b.Item("currency_name").ToString
                        xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn)).Font.Bold = True
                        currentRow += 1
                        Dim rowStart As Integer = currentRow
                        If b.ContainsKey("datas") Then
                            For Each c In b.Item("datas")
                                currentColumn = 1
                                xlWorkSheet.Cells(currentRow, currentColumn) = CDate(c.Item("trans_date")).ToString("MM/dd/yyyy")
                                currentColumn += 1
                                xlWorkSheet.Cells(currentRow, currentColumn) = "'" & c.Item("trans_no").ToString
                                currentColumn += 1
                                If journal_id = "2" Or journal_id = "4" Then
                                    xlWorkSheet.Cells(currentRow, currentColumn) = "'" & c.Item("check_no").ToString
                                    currentColumn += 1
                                End If
                                xlWorkSheet.Cells(currentRow, currentColumn) = c.Item("general_name").ToString
                                currentColumn += 1
                                xlWorkSheet.Cells(currentRow, currentColumn) = c.Item("tin").ToString
                                currentColumn += 1
                                xlWorkSheet.Cells(currentRow, currentColumn) = c.Item("description").ToString
                                currentColumn += 1
                                For Each col As DataColumn In dt.Columns
                                    If originalCurrency Then
                                        If IsNumeric(col.ColumnName.ToString.Replace("amount_", "")) Then
                                            Dim r = xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn))
                                            Dim num As Decimal = CDec(ifNull(r.Value, 0))
                                            Dim value As Decimal = CDec(ifNull(c.Item(col.ColumnName).ToString, 0))
                                            r.Clear()
                                            r.Value = num + value
                                            r.NumberFormat = "#,##0.00_);(#,##0.00)"
                                            currentColumn += 1
                                        End If
                                    Else
                                        If IsNumeric(col.ColumnName.ToString.Replace("amount_based_", "")) Then
                                            Dim r = xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn))
                                            Dim num As Decimal = CDec(ifNull(r.Value, 0))
                                            Dim value As Decimal = CDec(ifNull(c.Item(col.ColumnName).ToString, 0))
                                            r.Clear()
                                            r.Value = num + value
                                            r.NumberFormat = "#,##0.00_);(#,##0.00)"
                                            currentColumn += 1
                                        End If
                                    End If
                                Next
                                currentRow += 1
                            Next
                            If journal_id = "2" Or journal_id = "4" Then
                                currentColumn = 7
                            Else
                                currentColumn = 6
                            End If
                            Dim colStart As Integer = currentColumn
                            For Each col As DataColumn In dt.Columns
                                If IsNumeric(col.ColumnName.ToString.Replace("amount_", "")) Then
                                    Try
                                        xlWorkSheet.Cells(currentRow, currentColumn) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), rowStart, currentRow - 1)
                                        xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                                    Catch ex As Exception
                                        MyDebugging.AddText(String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), rowStart, currentRow - 1))
                                    End Try
                                    currentColumn += 1
                                End If
                            Next
                            xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, colStart), xlWorkSheet.Cells(currentRow, currentColumn - 1)).Font.Bold = True
                            currentRow += 1
                        End If
                    Else
                        If b.ContainsKey("trans_no") Then
                            currentColumn = 1
                            'xlWorkSheet.Cells(currentRow, currentColumn) = b.Item("currency_name").ToString
                            'xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn)).Font.Bold = True
                            'currentRow += 1
                            Dim rowStart As Integer = currentRow
                            If b.ContainsKey("grouped") Then
                                For Each c In b.Item("grouped")
                                    For Each d In c.Item("datas")
                                        currentColumn = 1
                                        xlWorkSheet.Cells(currentRow, currentColumn) = CDate(d.Item("trans_date")).ToString("MM/dd/yyyy")
                                        currentColumn += 1
                                        xlWorkSheet.Cells(currentRow, currentColumn) = "'" & d.Item("trans_no").ToString
                                        currentColumn += 1
                                        If journal_id = "2" Or journal_id = "4" Then
                                            xlWorkSheet.Cells(currentRow, currentColumn) = "'" & d.Item("check_no").ToString
                                            currentColumn += 1
                                        End If
                                        xlWorkSheet.Cells(currentRow, currentColumn) = d.Item("general_name").ToString
                                        currentColumn += 1
                                        xlWorkSheet.Cells(currentRow, currentColumn) = d.Item("project_name").ToString
                                        currentColumn += 1
                                        xlWorkSheet.Cells(currentRow, currentColumn) = d.Item("tin").ToString
                                        currentColumn += 1
                                        xlWorkSheet.Cells(currentRow, currentColumn) = d.Item("description").ToString
                                        currentColumn += 1
                                        For Each col As DataColumn In dt.Columns
                                            If originalCurrency Then
                                                If IsNumeric(col.ColumnName.ToString.Replace("amount_", "")) Then
                                                    Dim r = xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn))
                                                    Dim num As Decimal = CDec(ifNull(r.Value, 0))
                                                    Dim value As Decimal = CDec(ifNull(d.Item(col.ColumnName).ToString, 0))
                                                    r.Clear()
                                                    r.Value = num + value
                                                    r.NumberFormat = "#,##0.00_);(#,##0.00)"
                                                    currentColumn += 1
                                                End If
                                            Else
                                                If IsNumeric(col.ColumnName.ToString.Replace("amount_based_", "")) Then
                                                    Dim r = xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn))
                                                    Dim num As Decimal = CDec(ifNull(r.Value, 0))
                                                    Dim value As Decimal = CDec(ifNull(d.Item(col.ColumnName).ToString, 0))
                                                    r.Clear()
                                                    r.Value = num + value
                                                    r.NumberFormat = "#,##0.00_);(#,##0.00)"
                                                    currentColumn += 1
                                                End If
                                            End If
                                        Next
                                        currentRow += 1
                                    Next
                                Next
                                If journal_id = "2" Or journal_id = "4" Then
                                    currentColumn = 7
                                Else
                                    currentColumn = 6
                                End If
                                If withProject.Checked Then
                                    currentColumn += 1
                                End If
                                'Dim colStart As Integer = currentColumn
                                'For Each col As DataColumn In dt.Columns
                                '    If IsNumeric(col.ColumnName.ToString.Replace("amount_", "")) Then
                                '        Try
                                '            xlWorkSheet.Cells(currentRow, currentColumn) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), rowStart, currentRow - 1)
                                '            xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                                '        Catch ex As Exception
                                '            MyDebugging.AddText(String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), rowStart, currentRow - 1))
                                '        End Try
                                '        currentColumn += 1
                                '    End If
                                'Next
                                'xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, colStart), xlWorkSheet.Cells(currentRow, currentColumn - 1)).Font.Bold = True
                                'currentRow += 1
                            End If
                        End If
                    End If
                End If
            Next
            If journal_id = "2" Or journal_id = "4" Then
                currentColumn = 7
            Else
                currentColumn = 6
            End If
            If withProject.Checked Then
                currentColumn += 1
            End If
            Dim firstCol As Integer = currentColumn
            For Each col As DataColumn In dt.Columns
                If IsNumeric(col.ColumnName.ToString.Replace("amount_", "")) Then
                    Try
                        xlWorkSheet.Cells(currentRow, currentColumn) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), firstRow, currentRow - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, currentColumn), xlWorkSheet.Cells(currentRow, currentColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                        xlWorkSheet.Cells(4, currentColumn) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), firstRow, currentRow - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(4, currentColumn), xlWorkSheet.Cells(4, currentColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                    Catch ex As Exception
                        MyDebugging.AddText(String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", getColumnCharacter(currentColumn), firstRow, currentRow - 1))
                    End Try
                    currentColumn += 1
                End If
            Next
            xlWorkSheet.Range(xlWorkSheet.Cells(currentRow, firstCol), xlWorkSheet.Cells(currentRow, currentColumn - 1)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(4, firstCol), xlWorkSheet.Cells(4, currentColumn - 1)).Font.Bold = True
        End If
    End Sub
End Class