Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class checks
    Dim ds As New checks_set
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged
        Dim range As String = getRdoValue(range_filter)
        If range = "2" Then
            txt_date_from.Enabled = False
        Else
            txt_date_from.Enabled = True
        End If
    End Sub
    Private Sub checks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.Value = New Date(Today.Year, 1, 1)
        txt_date_to.Value = Today
    End Sub
    Private Sub rdo_per_bank_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_per_bank.CheckedChanged
        txt_bank.Enabled = True
        txt_bank.Focus()
    End Sub
    Private Sub rdo_per_payee_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_per_payee.CheckedChanged
        txt_payee.Enabled = True
        txt_payee.Focus()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim isrange As String = getRdoValue(range_filter)
        Dim datefrom As String = CDate(txt_date_from.Value).ToString("yyyy-MM-dd")
        Dim dateto As String = CDate(txt_date_to.Value).ToString("yyyy-MM-dd")

        If txt_date_to.Value < txt_date_from.Value Then
            MsgBox("Invalid Date Range.")
            Exit Sub
        End If

        Dim sql = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,a.description " &
" ,c.check_id,c.check_no,c.check_date,c.check_amount,c.check_amount_based,c.deposit_date,c.isPDC,c.isCash " &
" ,d.general_code,d.general_name " &
" ,c.bank_id,e.bank_code,e.bank_name " &
" FROM trans_header a " &
" LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " &
" LEFT JOIN trans_checks c ON c.jbooks_id = b.jbooks_id " &
" left join {0}.lib_erp_general d on d.general_id = c.general_id " &
" left join {0}.lib_erp_bank e on e.bank_id = c.bank_id " &
" WHERE a.journal_id = 4 AND c.check_id IS NOT NULL AND UPPER(TRIM(IFNULL(a.status,''))) <> 'C'", _serverDBFS)

        Dim strange As String = ""
        If isrange = "1" Then
            sql &= String.Format(" and a.trans_date between '{0}' and '{1}'", datefrom, dateto)
            strange = generateRange(CDate(txt_date_from.Value), CDate(txt_date_to.Value))
        Else
            sql &= String.Format(" and a.trans_date  <= '{0}' ", dateto)
            strange = "As of " & MonthName(txt_date_to.Value.Month) & " " & Year(txt_date_to.Value)
        End If

        If rdo_per_bank.Checked = True Then
            sql &= String.Format(" and e.bank_name = '{0}' ", txt_bank.Text)
        End If

        If rdo_per_payee.Checked = True Then
            sql &= String.Format(" and d.general_name = '{0}'", txt_payee.Text)
        End If

        Dim dt As DataTable = Query(sql)
        Dim sql_company As String = String.Format("SELECT a.* FROM lib_erp_company a WHERE a.company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id"))
        Dim dt_company As DataTable = FsQuery(sql_company)
        Dim company As String = ""

        If dt_company.Rows.Count > 0 Then
            company = dt_company.Rows(0).Item("company_name")
        End If

        ds.Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("ChecksTab").ImportRow(dr)
        Next

        If sender.name = "btnPrint" Then
            If dt.Rows.Count = 0 Then
                MsgBox("No records to Print.")
            Else
                Dim rep As New checks_report
                rep.DataSource = ds
                rep.company_name.Text = company
                rep.runtime.Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.range.Text = strange
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            End If
        Else
            If dt.Rows.Count = 0 Then
                MsgBox("No records to Print.")
            Else
                Try
                    lblLoad.Visible = True
                    Dim dicHeader As New Dictionary(Of String, String)
                    dicHeader.Add("templateName", "checks.xlt")
                    dicHeader.Add("companyName", "")
                    If dt_company.Rows.Count > 0 Then
                        dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
                    End If
                    Dim strGrouping As String = "bank_name"
                    Dim listAccount = groupDataTableToList(ds.Tables("ChecksTab"), strGrouping)
                    excelChecks(listAccount, strGrouping, dicHeader)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub excelChecks(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String))
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHeader.Item("templateName"))
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        If rdo1.Checked = True Then
            xlWorkSheet.Cells(3, 1) = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        Else
            xlWorkSheet.Cells(3, 1) = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        End If

        Dim current_row As Integer = 5
        Dim first_row As Integer = current_row
        Dim current_index As Integer = 0
        reportChecks(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub reportChecks(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer)
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
                    Case "bank_name"
                        xlWorkSheet.Cells(current_row, 1) = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.UnderLine = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim first_row As Integer = current_row
                        reportChecks(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
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

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("check_date")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("check_no")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("general_name")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("description")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("check_amount")
                    xlWorkSheet.Cells(current_row, 8) = dic.Item("deposit_date")
                    current_row += 1

                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                current_row += 1
                current_row += 1
            End If
        Next
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
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
End Class