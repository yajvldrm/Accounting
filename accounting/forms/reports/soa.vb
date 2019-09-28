Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class soa
    Private module_code As String = "ACC01020"
    Dim ds As New agingset
    Dim strChar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
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
    Private Sub cbo_category_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_category.SelectedValueChanged
        txt_client.Enabled = False
        txt_account.Enabled = False
        If cbo_category.Text = "One Client, One Account" Then
            txt_client.Enabled = True
            txt_account.Enabled = True
            txt_currency.Enabled = True
            txt_proj.Enabled = True
            txt_dept.Enabled = True
            txt_client.Focus()
        ElseIf cbo_category.Text = "One Client, All Accounts" Then
            txt_client.Enabled = True
            txt_currency.Enabled = True
            txt_proj.Enabled = True
            txt_dept.Enabled = True
            txt_client.Focus()
        ElseIf cbo_category.Text = "All Clients, One Account" Then
            txt_account.Enabled = True
            txt_currency.Enabled = True
            txt_proj.Enabled = True
            txt_dept.Enabled = True
            txt_client.Focus()
        End If
    End Sub
    Private Sub soa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.Value = New Date(Today.Year, 1, 1)
        txt_date_to.Value = Today
        cbo_category.Items.Clear()
        cbo_category.Items.Add("One Client, One Account")
        cbo_category.Items.Add("One Client, All Accounts")
        cbo_category.Items.Add("All Clients, One Account")
        cbo_category.Items.Add("All Clients, All Accounts")
        cbo_category.Text = "All Clients, All Accounts"
    End Sub
    Private Sub btn_notes_Click(sender As Object, e As EventArgs) Handles btn_notes.Click
        Dim sql = String.Format("SELECT note_id, note_date, note_remarks FROM sys_note ORDER BY note_date DESC LIMIT 1")
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count > 0 Then
            fornotes.note_id = dt.Rows(0).Item("note_id")
            fornotes.note_date = dt.Rows(0).Item("note_date")
            fornotes.note_remarks = dt.Rows(0).Item("note_remarks")
        End If
        fornotes.ShowDialog()
        If fornotes.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim sql_insert = String.Format("insert into sys_note(note_date, note_remarks) values(now(), '{0}')", fornotes.note_remarks)
            Query(sql_insert)
        End If
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
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim date_to As String = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim client As String = txt_client.Value
        Dim account As String = txt_account.Value
        Dim currency As String = txt_currency.Value
        Dim project As String = txt_proj.Value
        Dim department As String = txt_dept.Value

        Dim sql = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " & _
" ,(b.debit - IFNULL(e.credit,0)) AS debit,(b.credit - IFNULL(e.debit,0)) AS credit " & _
" ,(b.debit_based - IFNULL(e.credit_based,0)) AS debit_based,(b.credit_based - IFNULL(e.debit_based,0)) AS credit_based " & _
" ,b.general_id,f.general_code,f.general_name " & _
" ,c.terms_id,g.terms_code,g.terms_name,c.nodays " & _
" ,a.journal_id,h.journal_code,h.journal_name " & _
" ,b.project_id,i.project_code,i.project_name " & _
" ,b.department_id,j.department_code,j.department_name " & _
" ,b.account_id,d.account_code,d.account_name " & _
" ,CONCAT(k.book_code,h.journal_code) AS ref_no" & _
" FROM trans_header a " & _
" LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
" LEFT JOIN trans_jbooks_ap c ON c.jbooks_id = b.jbooks_id " & _
" LEFT JOIN {0}.lib_erp_chart d ON d.account_id = b.account_id " & _
" LEFT JOIN ( " & _
"   SELECT a.ref_jbooks_id AS jbooks_id " & _
"   ,SUM(IFNULL(a.debit,0)) AS debit,SUM(IFNULL(a.credit,0)) AS credit " & _
"   ,SUM(IFNULL(a.debit_based,0)) AS debit_based,SUM(IFNULL(a.credit_based,0)) AS credit_based " & _
"   FROM trans_jbooks a " & _
"   LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id " & _
"   WHERE b.validation = 2 AND a.ref_jbooks_id IS NOT NULL " & _
"   GROUP BY a.ref_jbooks_id " & _
" ) e ON e.jbooks_id = b.jbooks_id " & _
" LEFT JOIN {0}.lib_erp_general f ON f.general_id = b.general_id " & _
" LEFT JOIN {0}.lib_erp_terms g ON g.terms_id = c.terms_id " & _
" LEFT JOIN {0}.lib_erp_journal h ON h.journal_id = a.journal_id " & _
" LEFT JOIN {0}.lib_erp_project i ON i.project_id = b.project_id " & _
" LEFT JOIN {0}.lib_erp_department j ON j.department_id = b.department_id " & _
" LEFT JOIN {0}.lib_erp_book k ON k.book_id = a.book_id " & _
" WHERE a.trans_date <= '{1}' AND d.validation = 2 AND b.ref_jbooks_id IS NULL " & _
" AND ((b.debit - IFNULL(e.credit,0)) <> 0 OR (b.credit - IFNULL(e.debit,0)) <> 0)", _serverDBFS, date_to)

        If cbo_category.Text = "One Client, One Account" Then
            sql &= String.Format(" AND b.general_id = {0} ", client)
            sql &= String.Format(" AND b.account_id = {0} ", account)
        ElseIf cbo_category.Text = "One Client, All Accounts" Then
            sql &= String.Format(" AND b.general_id = {0} ", client)
        ElseIf cbo_category.Text = "All Clients, One Account" Then
            sql &= String.Format(" AND b.account_id = {0} ", account)
        ElseIf cbo_category.Text = "All Clients, All Accounts" Then
        End If

        If txt_currency.Text = "" Then
        Else
            sql &= String.Format(" AND b.currency_id = {0} ", currency)
        End If

        If txt_proj.Text = "" Then
        Else
            sql &= String.Format(" AND b.project_id = {0} ", project)
        End If

        If txt_dept.Text = "" Then
        Else
            sql &= String.Format(" AND b.department_id = {0} ", department)
        End If

        sql &= String.Format(" GROUP BY a.trans_id ")
        sql &= String.Format(" ORDER BY a.trans_date ")

        Dim sql_range As String = String.Format("SELECT aging_range_id,days_from,days_to " & _
                                                "FROM {0}.sys_aging_range ", _serverDBMain)

        Dim dt_range As DataTable = Query(sql_range)

        If dt_range.Rows.Count <= 0 Then
            MsgBox("No Records to Print.")
            Exit Sub
        End If

        Dim dt As DataTable = Query(sql)
        Dim col_prefix As String = "col_"
        Dim first_day As Decimal = dt_range.Rows(0).Item("days_from")
        Dim last_day As Decimal = 0

        dt.Columns.Add(col_prefix & "current")
        dt.Columns.Add(col_prefix & "current_based")

        For Each row As DataRow In dt_range.Rows
            dt.Columns.Add(col_prefix & row.Item("days_from") & "_" & row.Item("days_to"))
            dt.Columns.Add(col_prefix & row.Item("days_from") & "_" & row.Item("days_to") & "_based")
            last_day = row.Item("days_to")
        Next

        dt.Columns.Add(col_prefix & last_day)
        dt.Columns.Add(col_prefix & last_day & "_based")

        For Each dr_balance As DataRow In dt.Rows
            Dim trans_date As Date = CType(dr_balance.Item("trans_date"), Date).AddDays(CType(If(dr_balance.Item("nodays").ToString = "", 0, dr_balance.Item("nodays")), Decimal))
            If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) < first_day Then
                If currency = "1" Then
                    dr_balance.Item(col_prefix & "current") = dr_balance.Item("debit_based")
                Else
                    dr_balance.Item(col_prefix & "current") = dr_balance.Item("debit")
                End If
                dr_balance.Item(col_prefix & "current_based") = dr_balance.Item("debit_based")
                Continue For
            End If
            If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) > last_day Then
                If currency = "1" Then
                    dr_balance.Item(col_prefix & last_day) = dr_balance.Item("debit_based")
                Else
                    dr_balance.Item(col_prefix & last_day) = dr_balance.Item("debit")
                End If
                dr_balance.Item(col_prefix & last_day & "_based") = dr_balance.Item("debit_based")
                Continue For
            End If
            For Each dr_range As DataRow In dt_range.Rows
                If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) >= dr_range.Item("days_from") And DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) <= dr_range.Item("days_to") Then
                    If currency = "1" Then
                        dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to")) = dr_balance.Item("debit_based")
                    Else
                        dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to")) = dr_balance.Item("debit")
                    End If
                    dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to") & "_based") = dr_balance.Item("debit_based")
                End If
            Next
        Next

        Dim sql_company As String = String.Format("SELECT a.* FROM lib_erp_company a WHERE a.company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id").ToString())
        Dim dt_company As DataTable = FsQuery(sql_company)
        Dim company As String = ""

        If dt_company.Rows.Count > 0 Then
            company = dt_company.Rows(0).Item("company_name")
        End If

        Dim sql_notes = String.Format("SELECT note_id, note_date, note_remarks FROM sys_note ORDER BY note_date DESC LIMIT 1")
        Dim dt_notes As DataTable = Query(sql_notes)

        If sender.name = "btnPrint" Then
            Dim rep As New sa_report
            If dt_notes.Rows.Count > 0 Then
                rep.notes.Text = dt_notes.Rows(0).Item("note_remarks")
            End If
            createDataset(dt, dt_range)
            rep.DataSource = ds
            generateColumn(rep, dt_range, first_day, last_day, col_prefix)
            rep.company_name.Text = company
            rep.runtime.Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
            rep.date_now.Text = System.DateTime.Now.ToString("MMMM dd, yyyy")
            rep.date_range.Text = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
            rep.category.Text = cbo_category.Text
            rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
            reportviewer.DocumentViewer1.DocumentSource = rep
            reportviewer.ShowDialog()
        Else
            Dim dicHeader As New Dictionary(Of String, String)
            dicHeader.Add("templateName", "soa.xlt")
            dicHeader.Add("companyName", "")
            dicHeader.Add("reportDateRange", String.Format("As of {0}", txt_date_to.Value.ToString("MMMM dd, yyyy")))
            dicHeader.Add("category", cbo_category.Text)
            If dt_company.Rows.Count > 0 Then
                dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
                dicHeader.Item("address") = dt_company.Rows(0).Item("address1").ToString
            End If
            createDataset(dt, dt_range)
            Dim strGrouping As String = "general_code"
            Dim listAccount = groupDataTableToList(ds.Tables("Account"), strGrouping)
            Try
                lblLoad.Visible = True
                generateExcelGeneral(listAccount, dicHeader, strGrouping, ds.Tables("Account"), ds.Tables("Aging"))
                MsgBox("Report Done")
                lblLoad.Visible = False
            Catch ex As Exception
                lblLoad.Visible = False
                MsgBox(String.Format("Error Occured : {0}", ex.Message))
                MyDebugging.AddText(ex.Message)
            End Try
        End If
    End Sub
    Private Sub generateExcelGeneral(ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByVal dtAging As DataTable)
        Dim ctr As Integer = 0

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        If xlWorkBook.Worksheets.Count = 3 Then
            xlWorkBook.Worksheets(1).Delete()
            xlWorkBook.Worksheets(1).Delete()
        End If
        For Each g In listAccount
            If ctr > 0 Then
                xlWorkBook.Worksheets().Add()
            End If
            ctr += 1
            xlWorkSheet = xlWorkBook.Worksheets(1)
            xlWorkSheet.Name = g.Item("general_code").ToString
            generateExcelReport(xlWorkSheet, g.Item("datas"), dicHeader, strCol, ds.Tables("Account"), ds.Tables("Aging"))
        Next
    End Sub
    Private Sub generateExcelReport(ByRef xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByVal dtAging As DataTable)
        'Dim xlApp As Excel.Application
        'Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet

        'xlApp = New Excel.Application
        ''xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHead.Item("templateName"))
        'xlWorkBook = xlApp.Workbooks.Add
        'xlApp.Visible = True
        'If xlWorkBook.Worksheets.Count = 0 Then
        '    xlWorkBook.Worksheets.Add()
        'End If
        'xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = "STATEMENT OF ACCOUNT"
        xlWorkSheet.Cells(3, 1) = dicHeader.Item("reportDateRange")
        xlWorkSheet.Cells(4, 1) = listAccount.Item(0).Item("general_name").ToString

        Dim current_row As Integer = 5
        Dim current_column As Integer = 5
        Dim grandTotalFirstRow As Integer = 5
        Dim ctr As Integer = 0

        xlWorkSheet.Cells(current_row, 1) = "SA No."
        xlWorkSheet.Cells(current_row, 1).ColumnWidth = 13
        xlWorkSheet.Cells(current_row, 2) = "Date"
        xlWorkSheet.Cells(current_row, 2).ColumnWidth = 9
        xlWorkSheet.Cells(current_row, 3) = "Particulars"
        xlWorkSheet.Cells(current_row, 3).ColumnWidth = 30
        xlWorkSheet.Cells(current_row, 4) = "Total"
        xlWorkSheet.Cells(current_row, 4).ColumnWidth = 15
        xlWorkSheet.Cells(current_row, current_column) = "Current"
        xlWorkSheet.Cells(current_row, current_column).ColumnWidth = 15

        For Each dr As DataRow In ds.Tables("Aging").Rows
            current_column += 1
            xlWorkSheet.Cells(current_row, current_column) = String.Format("{0} to {1} Days", dr.Item("days_from"), dr.Item("days_to"))
            xlWorkSheet.Cells(current_row, current_column).ColumnWidth = 15
            ctr += 1
            If ctr = ds.Tables("Aging").Rows.Count Then
                current_column += 1
                xlWorkSheet.Cells(current_row, current_column) = String.Format("Over {0} Days", dr.Item("days_to"))
                xlWorkSheet.Cells(current_row, current_column).ColumnWidth = 15
                current_column += 1
                xlWorkSheet.Cells(current_row, current_column) = String.Format("Code")
                xlWorkSheet.Cells(current_row, current_column).ColumnWidth = 8
                current_column += 1
                xlWorkSheet.Cells(current_row, current_column) = String.Format("Reference No.")
                xlWorkSheet.Cells(current_row, current_column).ColumnWidth = 13
            End If
        Next

        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, current_column)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, current_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, current_column)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, current_column)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, current_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, current_column)).Font.Size = 10
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, current_column)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, current_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, current_column)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, current_column)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, current_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, current_column)).Font.Size = 8

        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, current_column)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, current_column)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, current_column)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, current_column)).HorizontalAlignment = Excel.Constants.xlCenter

        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, current_column)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, current_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, current_column)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, current_column)).Interior.Color = System.Drawing.Color.FromArgb(215, 228, 242)
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, current_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, current_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, current_column)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, current_column)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        current_row += 1

        current_row += 1
        xlWorkSheet.Cells(current_row, 1) = "DATE"
        xlWorkSheet.Cells(current_row, 2) = ":  " & Today.ToString("MMMM dd, yyyy")
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Bold = True
        current_row += 1
        xlWorkSheet.Cells(current_row, 1) = "NAME"
        xlWorkSheet.Cells(current_row, 2) = ":  " & (listAccount(0).Item("general_code") & " - " & listAccount(0).Item("general_name")).ToString.ToUpper
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Bold = True
        current_row += 1
        xlWorkSheet.Cells(current_row, 1) = "ADDRESS"
        xlWorkSheet.Cells(current_row, 2) = ":  " & listAccount(0).Item("address").ToString.ToUpper
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Bold = True
        current_row += 1
        xlWorkSheet.Cells(current_row, 1) = "ATTENTION"
        xlWorkSheet.Cells(current_row, 2) = ":  " & listAccount(0).Item("attention").ToString.ToUpper
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Bold = True
        current_row += 1
        xlWorkSheet.Cells(current_row, 1) = "FAX NO."
        xlWorkSheet.Cells(current_row, 2) = ":  " & listAccount(0).Item("fax_no").ToString.ToUpper
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Bold = True
        current_row += 1

        Dim first_row = current_row
        Dim last_row = current_row

        Dim current_index As Integer = 0
        For Each general_item In listAccount
            xlWorkSheet.Cells(current_row, 1) = general_item.Item("trans_no")
            xlWorkSheet.Cells(current_row, 1).Font.Size = 8
            xlWorkSheet.Cells(current_row, 2) = CDate(general_item.Item("trans_date")).ToString("MM-dd-yyyy")
            xlWorkSheet.Cells(current_row, 2).Font.Size = 8
            xlWorkSheet.Cells(current_row, 2).HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Cells(current_row, 3) = general_item.Item("description")
            xlWorkSheet.Cells(current_row, 3).Font.Size = 8
            xlWorkSheet.Cells(current_row, 4) = general_item.Item("debit")
            xlWorkSheet.Cells(current_row, 4).Font.Size = 8
            xlWorkSheet.Cells(current_row, 4).NumberFormat = "#,##0.00"
            xlWorkSheet.Cells(current_row, 5) = general_item.Item("col_current")
            xlWorkSheet.Cells(current_row, 5).Font.Size = 8
            xlWorkSheet.Cells(current_row, 5).NumberFormat = "#,##0.00"
            current_column = 6

            For Each dr As DataRow In dtAging.Rows
                Dim val = general_item.Item("col_" & dr.Item("days_from") & "_" & dr.Item("days_to"))
                xlWorkSheet.Cells(current_row, current_column) = val
                xlWorkSheet.Cells(current_row, current_column).Font.Size = 8
                xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
                current_column += 1
                If general_item.ContainsKey("col_" & dr.Item("days_to")) Then
                    xlWorkSheet.Cells(current_row, current_column) = general_item.Item("col_" & dr.Item("days_to"))
                    xlWorkSheet.Cells(current_row, current_column).Font.Size = 8
                    xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
                End If
            Next

            current_column += 1
            xlWorkSheet.Cells(current_row, current_column) = "'" & general_item.Item("account_code")
            xlWorkSheet.Cells(current_row, current_column).Font.Size = 8
            xlWorkSheet.Cells(current_row, current_column).HorizontalAlignment = Excel.Constants.xlCenter
            current_column += 1
            xlWorkSheet.Cells(current_row, current_column) = general_item.Item("ref_no")
            xlWorkSheet.Cells(current_row, current_column).Font.Size = 8
            xlWorkSheet.Cells(current_row, current_column).HorizontalAlignment = Excel.Constants.xlCenter
            last_row = current_row
            current_row += 1
        Next
        xlWorkSheet.Cells(current_row, 1) = listAccount(0).Item("general_name").ToString.ToUpper & " : "
        xlWorkSheet.Cells(current_row, 1).Font.Size = 8
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
        current_column = 4
        xlWorkSheet.Cells(current_row, current_column).Value = String.Format("=SUBTOTAL(9,{1}{0}:{1}{2})", first_row, strChar.Substring(current_column - 1, 1), last_row)
        xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
        xlWorkSheet.Cells(current_row, current_column).Font.Size = 8
        current_column += 1
        xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{1}{0}:{1}{2})", first_row, strChar.Substring(current_column - 1, 1), last_row)
        xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
        xlWorkSheet.Cells(current_row, current_column).Font.Size = 8
        current_column += 1

        For Each dr As DataRow In dtAging.Rows
            xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{1}{0}:{1}{2})", first_row, strChar.Substring(current_column - 1, 1), last_row)
            xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
            xlWorkSheet.Cells(current_row, current_column).Font.Size = 8
            current_column += 1
        Next

        xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{1}{0}:{1}{2})", first_row, strChar.Substring(current_column - 1, 1), last_row)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, current_column)).Font.Bold = True
        xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
        xlWorkSheet.Cells(current_row, current_column).Font.Size = 8
        current_row += 1

        current_row += 1
        xlWorkSheet.Cells(current_row, 1) = "AMOUNT DUE : "
        xlWorkSheet.Cells(current_row, 1).Font.Size = 8
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,{1}{0}:{1}{2})", first_row, strChar.Substring(3, 1), last_row)
        xlWorkSheet.Cells(current_row, 4).NumberFormat = "#,##0.00"
        xlWorkSheet.Cells(current_row, 4).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        current_row += 1
        current_column += 1
    End Sub
    Private Sub createDataset(ByVal dt As DataTable, ByVal dt_aging As DataTable)
        ds.Clear()

        'Account
        For Each col As DataColumn In dt.Columns
            If Not ds.Tables("Account").Columns.Contains(col.ColumnName) Then
                ds.Tables("Account").Columns.Add(col.ColumnName)
                ds.Tables("Account").Columns(col.ColumnName).DataType = System.Type.GetType("System.Decimal")
            End If
        Next

        'Account
        For Each row As DataRow In dt.Rows
            ds.Tables("Account").ImportRow(row)
        Next

        'Aging
        For Each row As DataRow In dt_aging.Rows
            ds.Tables("Aging").ImportRow(row)
        Next
    End Sub
    Private Function _summary(Optional groupings As SummaryRunning = SummaryRunning.Group) As XRSummary
        Dim summary As New XRSummary
        summary.Func = SummaryFunc.Sum
        summary.Running = groupings
        summary.FormatString = "{0:#,##0.00}"
        Return summary
    End Function
    Public Sub generateColumn(ByVal rep As XtraReport, ByVal dt As DataTable, ByVal first_day As String, ByVal last_day As String, Optional col_prefix As String = "")
        Dim ds As DataSet = (CType(rep.DataSource, DataSet))
        Dim totalDebitBased As Decimal = 0

        If ds.Tables("Account").Select("debit > 0").Count > 0 Then
            totalDebitBased = ds.Tables("Account").Compute("SUM(debit)", "debit > 0")
        End If

        Dim tblHeader As New XRTable
        Dim tblDetail As New XRTable
        Dim tblFooter1 As New XRTable
        Dim tblFooter2 As New XRTable
        Dim tblGrandTotal As New XRTable
        Dim tblPercentage As New XRTable

        Dim rowHeader As New XRTableRow
        Dim rowDetail As New XRTableRow
        Dim rowFooter1 As New XRTableRow
        Dim rowFooter2 As New XRTableRow
        Dim rowGrandTotal As New XRTableRow
        Dim rowPercentage As New XRTableRow

        tblHeader.HeightF = rep.FindControl("panel_header", False).HeightF
        tblHeader.WidthF = rep.FindControl("panel_header", False).WidthF
        tblHeader.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblHeader.BeginInit()

        tblDetail.HeightF = rep.FindControl("panel_detail", False).HeightF
        tblDetail.WidthF = rep.FindControl("panel_detail", False).WidthF
        tblDetail.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblDetail.BeginInit()

        tblFooter2.HeightF = rep.FindControl("panel_footer_2", False).HeightF
        tblFooter2.WidthF = rep.FindControl("panel_footer_2", False).WidthF
        tblFooter2.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblFooter2.BeginInit()

        Dim cellHeaderCurrent As New XRTableCell
        Dim cellHeaderOver As New XRTableCell

        Dim cellDetailCurrent As New XRTableCell
        Dim cellDetailOver As New XRTableCell

        Dim cellFooter1Current As New XRTableCell
        Dim cellFooter1Over As New XRTableCell

        Dim cellFooter2Current As New XRTableCell
        Dim cellFooter2Over As New XRTableCell

        Dim cellGrandTotalCurrent As New XRTableCell
        Dim cellGrandTotalOver As New XRTableCell

        Dim cellPercentageCurrent As New XRTableCell
        Dim cellPercentageOver As New XRTableCell

        cellHeaderCurrent.Text = "Current"
        rowHeader.Cells.Add(cellHeaderCurrent)

        cellDetailCurrent.DataBindings.Add("Text", Nothing, col_prefix & "current", "{0:#,##0.00}")
        rowDetail.Cells.Add(cellDetailCurrent)

        cellFooter1Current.DataBindings.Add("Text", Nothing, col_prefix & "current")
        cellFooter1Current.Summary = _summary()
        rowFooter1.Cells.Add(cellFooter1Current)

        cellFooter2Current.DataBindings.Add("Text", Nothing, col_prefix & "current")
        cellFooter2Current.Summary = _summary()
        rowFooter2.Cells.Add(cellFooter2Current)

        cellGrandTotalCurrent.DataBindings.Add("Text", Nothing, col_prefix & "current")
        cellGrandTotalCurrent.Summary = _summary(SummaryRunning.Report)
        rowGrandTotal.Cells.Add(cellGrandTotalCurrent)

        Dim currTotal = ds.Tables("Account").Compute("SUM(" & col_prefix & "current)", col_prefix & "current > 0")
        If currTotal.ToString = "" Then
            currTotal = 0
        End If

        Dim tmp_computed = If(totalDebitBased > 0, currTotal / totalDebitBased, 0)
        cellPercentageCurrent.Text = String.Format("{0:##,##0.00}%", tmp_computed * 100)
        rowPercentage.Cells.Add(cellPercentageCurrent)

        For Each row As DataRow In dt.Rows
            Dim cellHeaderColumn As New XRTableCell
            cellHeaderColumn.Text = String.Format("{0} to {1} Days", row.Item("days_from"), row.Item("days_to"))
            rowHeader.Cells.Add(cellHeaderColumn)

            Dim cellDetailColumn As New XRTableCell
            cellDetailColumn.DataBindings.Add("Text", Nothing, col_prefix & row.Item("days_from") & "_" & row.Item("days_to"), "{0:#,##0.00}")
            rowDetail.Cells.Add(cellDetailColumn)

            Dim cellFooter1Column As New XRTableCell
            cellFooter1Column.DataBindings.Add("Text", Nothing, col_prefix & row.Item("days_from") & "_" & row.Item("days_to"))
            cellFooter1Column.Summary = _summary()
            rowFooter1.Cells.Add(cellFooter1Column)

            Dim cellFooter2Column As New XRTableCell
            cellFooter2Column.DataBindings.Add("Text", Nothing, col_prefix & row.Item("days_from") & "_" & row.Item("days_to"))
            cellFooter2Column.Summary = _summary()
            rowFooter2.Cells.Add(cellFooter2Column)

            Dim cellGrandTotalColumn As New XRTableCell
            cellGrandTotalColumn.DataBindings.Add("Text", Nothing, col_prefix & row.Item("days_from") & "_" & row.Item("days_to"))
            cellGrandTotalColumn.Summary = _summary(SummaryRunning.Report)
            rowGrandTotal.Cells.Add(cellGrandTotalColumn)

            Dim cellPercentageColumn As New XRTableCell
            Dim strCurrentColumn As String = col_prefix & row.Item("days_from") & "_" & row.Item("days_to")
            Dim withRows = ds.Tables("Account").Select(String.Format("{0} > 0", strCurrentColumn))
            Dim tmp_var As Decimal = 0

            If withRows.Length > 0 Then
                tmp_var = ds.Tables("Account").Compute("SUM(" & strCurrentColumn & ")", strCurrentColumn & " > 0")
            End If

            tmp_computed = If(totalDebitBased > 0, (tmp_var / totalDebitBased), 0)
            cellPercentageColumn.Text = String.Format("{0:##,##0.00}%", tmp_computed * 100)
            rowPercentage.Cells.Add(cellPercentageColumn)
        Next

        cellHeaderOver.Text = String.Format("Over {0} Days", last_day)
        rowHeader.Cells.Add(cellHeaderOver)

        cellDetailOver.DataBindings.Add("Text", Nothing, col_prefix & last_day, "{0:#,##0.00}")
        rowDetail.Cells.Add(cellDetailOver)

        cellFooter1Over.DataBindings.Add("Text", Nothing, col_prefix & last_day)
        cellFooter1Over.Summary = _summary()
        rowFooter1.Cells.Add(cellFooter1Over)

        cellFooter2Over.DataBindings.Add("Text", Nothing, col_prefix & last_day)
        cellFooter2Over.Summary = _summary()
        rowFooter2.Cells.Add(cellFooter2Over)

        cellGrandTotalOver.DataBindings.Add("Text", Nothing, col_prefix & last_day)
        cellGrandTotalOver.Summary = _summary(SummaryRunning.Report)
        rowGrandTotal.Cells.Add(cellGrandTotalOver)

        Dim overRows = ds.Tables("Account").Select(String.Format("{0} > 0", col_prefix & last_day))
        Dim overValue As Decimal = 0

        If overRows.Length > 0 Then
            overValue = ds.Tables("Account").Compute(String.Format("SUM({0})", col_prefix & last_day), col_prefix & last_day & " > 0")
        End If

        tmp_computed = If(totalDebitBased > 0, (overValue / totalDebitBased), 0)
        cellPercentageOver.Text = String.Format("{0:##,##0.00}%", tmp_computed * 100)
        rowPercentage.Cells.Add(cellPercentageOver)

        tblHeader.Rows.Add(rowHeader)
        tblDetail.Rows.Add(rowDetail)
        tblFooter1.Rows.Add(rowFooter1)
        tblFooter2.Rows.Add(rowFooter2)
        tblGrandTotal.Rows.Add(rowGrandTotal)
        tblPercentage.Rows.Add(rowPercentage)

        tblHeader.EndInit()
        tblDetail.EndInit()
        tblFooter1.EndInit()
        tblFooter2.EndInit()
        tblGrandTotal.EndInit()
        tblPercentage.EndInit()

        rep.FindControl("panel_header", False).Controls.Add(tblHeader)
        rep.FindControl("panel_detail", False).Controls.Add(tblDetail)
        rep.FindControl("panel_footer_2", False).Controls.Add(tblFooter2)
    End Sub
End Class