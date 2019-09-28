Imports Microsoft.Office.Interop
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports libacctng.myFunctions

Public Class journals
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim grp As String = getRdoValue(filter)
        Dim datefrom = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim dateto = txt_date_to.Value.ToString("yyyy-MM-dd")

        Dim sql = String.Format("select a.trans_id, a.trans_no, a.trans_date, a.description, b.account_id, b.debit_based AS debit, b.credit_based AS credit, b.debit_based, b.credit_based, c.account_code, c.account_name" &
" ,c.validation" &
" from trans_header a" &
" left join trans_jbooks b on b.trans_id = a.trans_id" &
" left join {0}.lib_erp_chart c on c.account_id = b.account_id" &
" where a.trans_date between '{1}' and '{2}' AND UPPER(IFNULL(a.status,'')) <> 'C'", _serverDBFS, datefrom, dateto)

        Dim sql_sales = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,a.amount,a.amount_based,a.description ,(IFNULL(b.debit,0) - IFNULL(b.credit,0)) AS discount" & _
" ,(IFNULL(b.debit_based,0) - IFNULL(b.credit_based,0)) AS discount_based" & _
" ,(IFNULL(c.credit,0) - IFNULL(c.debit,0)) AS vat" & _
" ,(IFNULL(c.credit_based,0) - IFNULL(c.debit_based,0)) AS vat_based" & _
" ,d.general_code,d.general_name,d.address1,d.tin" & _
" FROM trans_header a" & _
" LEFT JOIN (" & _
" SELECT a.trans_id,SUM(IFNULL(a.debit,0)) AS debit" & _
" ,SUM(IFNULL(a.credit,0)) AS credit" & _
" ,SUM(IFNULL(a.debit_based,0)) AS debit_based" & _
" ,SUM(IFNULL(a.credit_based,0)) AS credit_based" & _
" FROM trans_jbooks a" & _
" LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id" & _
" WHERE b.validation = '11'" & _
" GROUP BY a.trans_id ) b ON b.trans_id = a.trans_id" & _
" LEFT JOIN (" & _
" SELECT a.trans_id,SUM(IFNULL(a.debit,0)) AS debit" & _
" ,SUM(IFNULL(a.credit,0)) AS credit" & _
" ,SUM(IFNULL(a.debit_based,0)) AS debit_based" & _
" ,SUM(IFNULL(a.credit_based,0)) AS credit_based" & _
" FROM trans_jbooks a" & _
" LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id" & _
" WHERE b.validation = '7'" & _
" GROUP BY a.trans_id ) c ON c.trans_id = a.trans_id" & _
" LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id" & _
" WHERE a.journal_id = '1'  and a.trans_date between '{1}' and '{2}'", _serverDBFS, datefrom, dateto)

        Dim sql_purchase = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,a.amount,a.amount_based,a.description" &
" ,(IFNULL(b.debit,0) - IFNULL(b.credit,0)) AS discount,(IFNULL(b.debit_based,0) - IFNULL(b.credit_based,0)) AS discount_based" &
" ,(IFNULL(c.debit,0) - IFNULL(c.credit,0)) AS vat,(IFNULL(c.debit_based,0) - IFNULL(c.credit_based,0)) AS vat_based" &
" ,d.general_code,d.general_name,d.address1,d.tin" &
" FROM trans_header a" &
" LEFT JOIN (" &
"  SELECT a.trans_id,SUM(IFNULL(a.debit,0)) AS debit,SUM(IFNULL(a.credit,0)) AS credit" &
"  ,SUM(IFNULL(a.debit_based,0)) AS debit_based,SUM(IFNULL(a.credit_based,0)) AS credit_based" &
"  FROM trans_jbooks a" &
"  LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id" &
"  WHERE b.validation = '12'" &
"  GROUP BY a.trans_id" &
" ) b ON b.trans_id = a.trans_id" &
" LEFT JOIN (" &
"  SELECT a.trans_id,SUM(IFNULL(a.debit,0)) AS debit,SUM(IFNULL(a.credit,0)) AS credit" &
"  ,SUM(IFNULL(a.debit_based,0)) AS debit_based,SUM(IFNULL(a.credit_based,0)) AS credit_based" &
"  FROM trans_jbooks a" &
"  LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id" &
"  WHERE b.validation = '6'" &
"  GROUP BY a.trans_id" &
" ) c ON c.trans_id = a.trans_id" &
" LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id" &
" WHERE a.journal_id = '3' and a.trans_date between '{1}' and '{2}'", _serverDBFS, datefrom, dateto)

        Select Case grp
            Case "1"
                sql &= " order by a.trans_date,a.trans_no asc, c.account_code asc"
            Case "2"
                sql &= " order by a.trans_date,a.trans_no asc, b.debit desc"
            Case "3"
            Case "4"
        End Select

        Dim dt As DataTable = Query(sql)
        Dim dt_sales As DataTable = Query(sql_sales)
        Dim dt_purchase As DataTable = Query(sql_purchase)

        ds.Tables("general").Clear()
        ds.Tables("journal").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("general").ImportRow(dr)
        Next

        Dim sql_company As String = String.Format("SELECT a.* FROM lib_erp_company a WHERE company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id"))
        Dim dt_company As DataTable = FsQuery(sql_company)
        Dim company As String = ""
        Dim add_tin As String = ""

        If dt_company.Rows.Count > 0 Then
            company = dt_company.Rows(0).Item("company_name")
            add_tin = String.Format("{0}VAT REG TIN : {1}", dt_company.Rows(0).Item("address1") & vbNewLine, dt_company.Rows(0).Item("tin"))
        End If

        If sender.name = "btnPrint" Then
            If rdo1.Checked = True Then
                Dim rep As New general_ledger_print
                rep.DataSource = ds
                rep.DataMember = "general"
                rep.company_name.Text = company
                rep.Parameters("S001").Value = main.S001
                rep.Parameters("S002").Value = main.S002
                rep.add_tin.Text = add_tin
                rep.title.Text = "General Ledger"
                rep.runtime.Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.range.Text = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            ElseIf rdo2.Checked = True Then
                Dim rep As New general_journal_print
                rep.DataSource = ds
                rep.DataMember = "general"
                rep.company_name.Text = company
                rep.Parameters("S001").Value = main.S001
                rep.Parameters("S002").Value = main.S002
                rep.add_tin.Text = add_tin
                rep.title.Text = "General Journal"
                rep.runtime.Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.range.Text = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            ElseIf rdo3.Checked = True Then
                Dim rep As New sales_journal_print
                For Each dr2 As DataRow In dt_sales.Rows
                    ds.Tables("journal").ImportRow(dr2)
                Next
                rep.DataSource = ds
                rep.DataMember = "journal"
                rep.company_name.Text = company
                rep.Parameters("S001").Value = main.S001
                rep.Parameters("S002").Value = main.S002
                rep.add_tin.Text = add_tin
                rep.title.Text = "Sales Journal"
                rep.runtime.Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.range.Text = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            ElseIf rdo4.Checked = True Then
                Dim rep As New purchase_journal_print
                For Each dr3 As DataRow In dt_purchase.Rows
                    ds.Tables("journal").ImportRow(dr3)
                Next
                rep.DataSource = ds
                rep.DataMember = "journal"
                rep.company_name.Text = company
                rep.Parameters("S001").Value = main.S001
                rep.Parameters("S002").Value = main.S002
                rep.add_tin.Text = add_tin
                rep.title.Text = "Purchase Journal"
                rep.runtime.Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.range.Text = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            End If
        Else
            Dim dicHeader As New Dictionary(Of String, String)
            Dim companyName As String = ""
            Dim templateName As String = ""
            dicHeader.Add("companyName", "")
            If dt_company.Rows.Count > 0 Then
                companyName = dt_company.Rows(0).Item("company_name").ToString
            End If
            If dt_company.Rows.Count > 0 Then
                dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
            End If
            Dim strGrouping As String = "account_name"
            Dim listAccount = groupDataTableToList(ds.Tables("general"), strGrouping)
            If rdo1.Checked = True Then
                templateName = "generalLedger.xlt"
                Try
                    lblLoad.Visible = True
                    excelGeneralLedger(listAccount, strGrouping, dicHeader, templateName)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            ElseIf rdo2.Checked = True Then
                Try
                    lblLoad.Visible = True
                    excelGeneralJournal("generalJournal.xlt", companyName)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            ElseIf rdo3.Checked = True Then
                For Each dr2 As DataRow In dt_sales.Rows
                    ds.Tables("journal").ImportRow(dr2)
                Next
                Try
                    lblLoad.Visible = True
                    excelSalesJournal("salesJournal.xlt", companyName)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            ElseIf rdo4.Checked = True Then
                For Each dr3 As DataRow In dt_purchase.Rows
                    ds.Tables("journal").ImportRow(dr3)
                Next
                Try
                    lblLoad.Visible = True
                    excelPurchaseJournal("purchaseJournal.xlt", companyName)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            End If
        End If
    End Sub
    Private Sub excelGeneralLedger(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByVal templateName As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(3, 1) = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")

        Dim current_row As Integer = 5
        Dim first_row As Integer = current_row
        Dim current_index As Integer = 0
        reportGeneralLedger(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub reportGeneralLedger(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer)
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
                    Case "account_name"
                        xlWorkSheet.Cells(current_row, 1) = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.UnderLine = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim first_row As Integer = current_row
                        reportGeneralLedger(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                        current_row += 1
                End Select
            Else
                xlWorkSheet.Cells(current_row, 1) = dicItem(field)
                xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                xlWorkSheet.Cells(current_row, 1).Font.UnderLine = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
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

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("description")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("debit")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("credit")
                    current_row += 1

                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                current_row += 1
                current_row += 1
            End If
        Next
    End Sub
    Private Sub excelGeneralJournal(ByVal templateName As String, ByVal companyName As String)
        Dim datefrom = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim dateto = txt_date_to.Value.ToString("yyyy-MM-dd")

        Dim sql = String.Format("select a.trans_id, a.trans_no, a.trans_date, a.description, b.account_id, b.debit, b.credit, b.debit_based, b.credit_based, c.account_code, c.account_name" & _
" ,c.validation" & _
" from trans_header a" & _
" left join trans_jbooks b on b.trans_id = a.trans_id" & _
" left join {0}.lib_erp_chart c on c.account_id = b.account_id" & _
" where a.trans_date between '{1}' and '{2}' " & _
" order by a.trans_no asc, c.account_code asc", _serverDBFS, datefrom, dateto)

        Dim dt = Query(sql)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = companyName
        xlWorkSheet.Cells(3, 1) = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")

        Dim first_row As Integer = 5
        Dim current_row As Integer = 5

        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = row.Item("trans_date")
            xlWorkSheet.Cells(current_row, 2) = row.Item("trans_no")
            xlWorkSheet.Cells(current_row, 3) = row.Item("description")
            xlWorkSheet.Cells(current_row, 4) = row.Item("account_name")
            xlWorkSheet.Cells(current_row, 5) = row.Item("debit")
            xlWorkSheet.Cells(current_row, 6) = row.Item("credit")
            current_row += 1
        Next

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 6)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub excelSalesJournal(ByVal templateName As String, ByVal companyName As String)
        Dim datefrom = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim dateto = txt_date_to.Value.ToString("yyyy-MM-dd")

        Dim sql_sales = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,a.amount,a.amount_based,a.description ,(IFNULL(b.debit,0) - IFNULL(b.credit,0)) AS discount" & _
" ,(IFNULL(b.debit_based,0) - IFNULL(b.credit_based,0)) AS discount_based" & _
" ,(IFNULL(c.credit,0) - IFNULL(c.debit,0)) AS vat" & _
" ,(IFNULL(c.credit_based,0) - IFNULL(c.debit_based,0)) AS vat_based" & _
" ,d.general_code,d.general_name,d.address1,d.tin" & _
" FROM trans_header a" & _
" LEFT JOIN (" & _
" SELECT a.trans_id,SUM(IFNULL(a.debit,0)) AS debit" & _
" ,SUM(IFNULL(a.credit,0)) AS credit" & _
" ,SUM(IFNULL(a.debit_based,0)) AS debit_based" & _
" ,SUM(IFNULL(a.credit_based,0)) AS credit_based" & _
" FROM trans_jbooks a" & _
" LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id" & _
" WHERE b.validation = '11'" & _
" GROUP BY a.trans_id ) b ON b.trans_id = a.trans_id" & _
" LEFT JOIN (" & _
" SELECT a.trans_id,SUM(IFNULL(a.debit,0)) AS debit" & _
" ,SUM(IFNULL(a.credit,0)) AS credit" & _
" ,SUM(IFNULL(a.debit_based,0)) AS debit_based" & _
" ,SUM(IFNULL(a.credit_based,0)) AS credit_based" & _
" FROM trans_jbooks a" & _
" LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id" & _
" WHERE b.validation = '7'" & _
" GROUP BY a.trans_id ) c ON c.trans_id = a.trans_id" & _
" LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id" & _
" WHERE a.journal_id = '1'  and a.trans_date between '{1}' and '{2}'", _serverDBFS, datefrom, dateto)

        Dim dt = Query(sql_sales)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = companyName
        xlWorkSheet.Cells(3, 1) = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")

        Dim first_row As Integer = 5
        Dim current_row As Integer = 5

        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = row.Item("trans_date")
            xlWorkSheet.Cells(current_row, 2) = row.Item("tin")
            xlWorkSheet.Cells(current_row, 3) = row.Item("general_name")
            xlWorkSheet.Cells(current_row, 4) = row.Item("address1")
            xlWorkSheet.Cells(current_row, 5) = row.Item("description")
            xlWorkSheet.Cells(current_row, 6) = row.Item("trans_no")
            xlWorkSheet.Cells(current_row, 7) = row.Item("amount")
            xlWorkSheet.Cells(current_row, 8) = row.Item("discount")
            xlWorkSheet.Cells(current_row, 9) = row.Item("vat")
            xlWorkSheet.Cells(current_row, 10) = row.Item("amount") - row.Item("discount") - row.Item("vat")
            current_row += 1
        Next

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub excelPurchaseJournal(ByVal templateName As String, ByVal companyName As String)
        Dim datefrom = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim dateto = txt_date_to.Value.ToString("yyyy-MM-dd")

        Dim sql_purchase = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,a.amount,a.amount_based,a.description" & _
" ,(IFNULL(b.debit,0) - IFNULL(b.credit,0)) AS discount,(IFNULL(b.debit_based,0) - IFNULL(b.credit_based,0)) AS discount_based" & _
" ,(IFNULL(c.credit,0) - IFNULL(c.debit,0)) AS vat,(IFNULL(c.credit_based,0) - IFNULL(c.debit_based,0)) AS vat_based" & _
" ,d.general_code,d.general_name,d.address1,d.tin" & _
" FROM trans_header a" & _
" LEFT JOIN (" & _
"  SELECT a.trans_id,SUM(IFNULL(a.debit,0)) AS debit,SUM(IFNULL(a.credit,0)) AS credit" & _
"  ,SUM(IFNULL(a.debit_based,0)) AS debit_based,SUM(IFNULL(a.credit_based,0)) AS credit_based" & _
"  FROM trans_jbooks a" & _
"  LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id" & _
"  WHERE b.validation = '12'" & _
"  GROUP BY a.trans_id" & _
" ) b ON b.trans_id = a.trans_id" & _
" LEFT JOIN (" & _
"  SELECT a.trans_id,SUM(IFNULL(a.debit,0)) AS debit,SUM(IFNULL(a.credit,0)) AS credit" & _
"  ,SUM(IFNULL(a.debit_based,0)) AS debit_based,SUM(IFNULL(a.credit_based,0)) AS credit_based" & _
"  FROM trans_jbooks a" & _
"  LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id" & _
"  WHERE b.validation = '6'" & _
"  GROUP BY a.trans_id" & _
" ) c ON c.trans_id = a.trans_id" & _
" LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id" & _
" WHERE a.journal_id = '3' and a.trans_date between '{1}' and '{2}'", _serverDBFS, datefrom, dateto)

        Dim dt = Query(sql_purchase)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = companyName
        xlWorkSheet.Cells(3, 1) = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")

        Dim first_row As Integer = 5
        Dim current_row As Integer = 5

        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = row.Item("trans_date")
            xlWorkSheet.Cells(current_row, 2) = row.Item("tin")
            xlWorkSheet.Cells(current_row, 3) = row.Item("general_name")
            xlWorkSheet.Cells(current_row, 4) = row.Item("address1")
            xlWorkSheet.Cells(current_row, 5) = row.Item("description")
            xlWorkSheet.Cells(current_row, 6) = row.Item("trans_no")
            xlWorkSheet.Cells(current_row, 7) = row.Item("amount")
            xlWorkSheet.Cells(current_row, 8) = row.Item("discount")
            xlWorkSheet.Cells(current_row, 9) = row.Item("vat")
            xlWorkSheet.Cells(current_row, 10) = row.Item("amount") - row.Item("discount") - row.Item("vat")
            current_row += 1
        Next

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        If txt_date_to.Value < txt_date_from.Value Then
            MsgBox("Invalid Date Range.")
            Exit Sub
        End If
        Dim _printoption As New reportoption
        _printoption.targetForm = Me
        _printoption.Label1.Hide()
        _printoption.cbo_sort.Hide()
        _printoption.ShowDialog()
        If _printoption.DialogResult = Windows.Forms.DialogResult.OK Then
            If _printoption.PrintOption = "1" Then
                btnPrint_Click(btnExcel, Nothing)
            Else
                btnPrint_Click(btnPrint, Nothing)
            End If
        End If
    End Sub
    Private Sub journals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.Value = New Date(Today.Year, 1, 1)
        txt_date_to.Value = Today
    End Sub
End Class