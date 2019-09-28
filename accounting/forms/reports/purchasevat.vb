Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class purchasevat
    Dim ds As New inputoutputvatset
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub toDate_CheckedChanged(sender As Object, e As EventArgs) Handles toDate.CheckedChanged
        Dim tDate As Boolean = toDate.Checked
        If tDate Then
            txt_date_from.Enabled = False
        Else
            txt_date_from.Enabled = True
        End If
    End Sub
    Private Sub purchasevat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_company.Text = main.Sys_Default.Rows(0).Item("company_name")
        txt_address.Text = main.Sys_Default.Rows(0).Item("address1")
        txt_address2.Text = main.Sys_Default.Rows(0).Item("address2")
        txt_tin.Text = main.Sys_Default.Rows(0).Item("tin")
        txt_rdo.Text = main.Sys_Default.Rows(0).Item("rdo_code")
    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim templateName As String = "purchase_vat.xlt"
        excelSalesVat(templateName)
    End Sub
    Private Sub excelSalesVat(ByVal templateName As String)
        Dim date_from As String = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to As String = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim vat As String = getRdoValue(vat_filter)
        Dim tDate As Boolean = toDate.Checked

        If Not tDate Then
            If txt_date_from.Value > txt_date_to.Value Then
                MsgBox("Invalid Date Range.")
                txt_date_from.Focus()
                Exit Sub
            End If
        End If

        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " & _
" ,b.jbooks_id " & _
" ,c.input_vat_id AS vat_id,c.gross_amount,c.vat_amount,c.net_amount,c.gross_amount_based,c.vat_amount_based,c.net_amount_based " & _
" ,d.vat_amount AS ref_vat_amount,d.vat_amount_based AS ref_vat_amount_based " & _
" ,c.offset_type,d.offset_type AS ref_offset_type " & _
" ,c.general_id,f.general_code,f.general_name,f.address1 AS address,f.tin " & _
" ,c.currency_id,h.currency_code,h.currency_name " & _
" ,b.project_id,i.project_code,i.project_name " & _
" ,b.department_id,j.department_code,j.department_name " & _
" FROM {1}.trans_header a " & _
" LEFT JOIN {1}.trans_jbooks b ON b.trans_id = a.trans_id " & _
" LEFT JOIN {1}.trans_input_vat c ON c.jbooks_id = b.jbooks_id " & _
" LEFT JOIN ( " & _
"   SELECT a.offset_type,a.ref_input_vat_id AS input_vat_id " & _
"   ,SUM(a.vat_amount) AS vat_amount " & _
"   ,SUM(a.vat_amount_based) AS vat_amount_based " & _
"   FROM {1}.trans_input_vat a " &
"   GROUP BY a.ref_input_vat_id,a.offset_type  ) d ON d.input_vat_id = c.input_vat_id " & _
" LEFT JOIN {0}.lib_erp_chart e ON e.account_id = b.account_id " & _
" LEFT JOIN {0}.lib_erp_general f ON f.general_id = c.general_id " & _
" LEFT JOIN {0}.lib_acc_general_multiple g ON g.general_id = f.general_id " & _
" LEFT JOIN {0}.lib_erp_currency h ON h.currency_id = c.currency_id " & _
" LEFT JOIN {0}.lib_erp_project i ON i.project_id = b.project_id " & _
" LEFT JOIN {0}.lib_erp_department j ON j.department_id = b.department_id ", _serverDBFS, _serverDBMain)

        If Not tDate Then
            sql &= String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)
        Else
            sql &= String.Format(" WHERE a.trans_date <= '{0}' ", date_to)
        End If

        sql &= String.Format(" AND e.validation = 6 AND c.offset_type = 0 ")
        sql &= String.Format(" GROUP BY c.input_vat_id ")

        Dim dt As DataTable = FsQuery(sql)

        ds.Tables("Accounts").Clear()

        For Each row As DataRow In dt.Rows
            ds.Tables("Accounts").ImportRow(row)
        Next

        Dim str_daterange As String = ""
        Dim str_title As String = ""

        Select Case vat
            Case "1"
                str_title = "Reconciliation of Listing for Enforcement"
            Case "2"
            Case "3"
            Case "4"
        End Select

        If tDate Then
            str_daterange = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        Else
            str_daterange = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        End If

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim current_row As Integer = 9
        Dim firstrow As Integer = current_row
        Dim current_index As Integer = 0

        xlWorkSheet.Cells(1, 1) = "PURCHASE TRANSACTION"
        xlWorkSheet.Cells(1, 1).Font.Bold = True
        xlWorkSheet.Cells(2, 1) = str_title
        xlWorkSheet.Cells(2, 1).Font.Bold = True
        xlWorkSheet.Cells(4, 1) = "TIN: " & txt_tin.Text
        xlWorkSheet.Cells(4, 1).Font.Bold = True
        xlWorkSheet.Cells(5, 1) = "OWNER'S NAME: " & txt_company.Text
        xlWorkSheet.Cells(5, 1).Font.Bold = True
        xlWorkSheet.Cells(6, 1) = "OWNER'S TRADE NAME: " & txt_company.Text
        xlWorkSheet.Cells(6, 1).Font.Bold = True
        xlWorkSheet.Cells(7, 1) = "OWNER'S ADDRESS: " & txt_address.Text
        xlWorkSheet.Cells(7, 1).Font.Bold = True

        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = row.Item("trans_date")
            xlWorkSheet.Cells(current_row, 2) = row.Item("tin")
            xlWorkSheet.Cells(current_row, 3) = row.Item("general_name")
            xlWorkSheet.Cells(current_row, 4) = ""
            xlWorkSheet.Cells(current_row, 5) = row.Item("address")
            xlWorkSheet.Cells(current_row, 6) = row.Item("net_amount")
            xlWorkSheet.Cells(current_row, 7) = ""
            xlWorkSheet.Cells(current_row, 8) = ""
            xlWorkSheet.Cells(current_row, 9) = row.Item("net_amount")
            xlWorkSheet.Cells(current_row, 10) = ""
            xlWorkSheet.Cells(current_row, 11) = ""
            xlWorkSheet.Cells(current_row, 12) = ""
            xlWorkSheet.Cells(current_row, 13) = row.Item("vat_amount")
            xlWorkSheet.Cells(current_row, 14) = row.Item("gross_amount")
            current_row += 1
        Next

        current_row += 1
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 14)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        Dim rnge = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5))
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        rnge.Font.Italic = True
        rnge.IndentLevel = 5
        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", firstrow, current_row - 1)
        current_row += 1
    End Sub
End Class