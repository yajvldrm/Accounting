Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Imports DevExpress.DataAccess.ConnectionParameters

Public Class soareport

    Dim ds As New agingset
    Dim strChar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim templates As String = Application.StartupPath & "\templates"
    Private module_code As String = "ACC01021"


    Public connectionParam As New MySqlConnectionParameters(My.Settings._serverIP, My.Settings._serverDBMain, My.Settings._serverUser, My.Settings._serverPass, "3306")

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub toDate_CheckedChanged(sender As Object, e As EventArgs) Handles toDate.CheckedChanged
        If toDate.Checked Then
            txt_date_from.Enabled = False
            txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        Else
            txt_date_from.Enabled = True
            txt_date_to.MinDate = txt_date_from.Value
        End If
    End Sub

    Private Sub soareport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        Dim sql_book As String = String.Format("SELECT book_id,book_code,book_name " & vbNewLine &
            "FROM lib_erp_book a " & vbNewLine &
            "WHERE a.company_id = '{0}' ", main.Sys_Default.Rows(0).Item("company_id").ToString())
        Dim dt_book As DataTable = FsQuery(sql_book)
        ds.Tables("lib_erp_book").Clear()
        For Each dr As DataRow In dt_book.Rows
            ds.Tables("lib_erp_book").ImportRow(dr)
        Next
        dgBooks.AutoGenerateColumns = False
        dgBooks.DataSource = ds.Tables("lib_erp_book")
    End Sub

    Private Sub AccountChange(sender As Object, e As EventArgs) Handles rdo_account_3.CheckedChanged, rdo_account_2.CheckedChanged, rdo_account_1.CheckedChanged
        Dim accountOption = getRdoValue(account_filter)
        btnImportAccount.Enabled = False
        txt_account_id.Enabled = False
        txt_account_id.Text = ""
        txt_account_id.Value = ""
        lbl_account_name.Text = "Account Name"
        Select Case accountOption
            Case "1"
            Case "2"
                btnImportAccount.Enabled = True
                btnImportAccount.Focus()
            Case "3"
                txt_account_id.Enabled = True
                'txt_account_id.Focus()
        End Select
    End Sub

    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_chart WHERE validation = 2")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("account_code = '" & txt_account_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "account_code,account_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_account_id.RowData = dr
                txt_account_id.Value = dr("account_id")
                txt_account_id.Text = dr("account_code")
                lbl_account_name.Text = dr("account_name")
            End If
        End If
    End Sub

    Private Sub GeneralChange(sender As Object, e As EventArgs) Handles rdo_general_3.CheckedChanged, rdo_general_2.CheckedChanged, rdo_general_1.CheckedChanged
        Dim generalOption = getRdoValue(general_filter)
        btnImportGeneral.Enabled = False
        txt_general_id.Enabled = False
        txt_general_id.Text = ""
        txt_general_id.Value = ""
        lbl_general_name.Text = "General Name"
        Select Case generalOption
            Case "1"
            Case "2"
                btnImportGeneral.Enabled = True
                btnImportGeneral.Focus()
            Case "3"
                txt_general_id.Enabled = True
                'txt_general_id.Focus()
        End Select
    End Sub

    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        Dim data_currency As DataTable = FsQuery("SELECT a.currency_name,a.currency_code,a.currency_id FROM lib_erp_currency a")
        If data_currency.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data_currency.Rows.Count = 1 Then
                dr = data_currency.Rows(0)
            Else
                Dim dra() As DataRow = data_currency.Select("currency_code like '" & txt_currency_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data_currency
                    browse.format("Code,Name", "currency_code,currency_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_currency_id.RowData = dr
                txt_currency_id.Value = dr("currency_id")
                txt_currency_id.Text = dr("currency_code")
                lbl_currency_name.Text = dr("currency_name")
            End If
        End If
    End Sub

    Private Sub CurrencyChange(sender As Object, e As EventArgs) Handles rdo_currency_2.CheckedChanged, rdo_currency_1.CheckedChanged
        Dim currencyOption = getRdoValue(currency_filter)
        withComparison.Enabled = False
        If currencyOption = "2" Then
            withComparison.Enabled = True
        End If
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

    Private Sub withProjectDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles withProjectDepartment.CheckedChanged
        Dim wProjDept As Boolean = withProjectDepartment.Checked
        txt_project_id.Enabled = True
        txt_department_id.Enabled = True
        If Not wProjDept Then
            txt_project_id.Value = ""
            txt_project_id.Text = ""
            txt_project_id.Enabled = False
            lbl_project_name.Text = "Project Name"
            txt_department_id.Value = ""
            txt_department_id.Text = ""
            txt_department_id.Enabled = False
            lbl_department_name.Text = "Department Name"
        End If
    End Sub

    Private Sub txt_project_id_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave
        Dim data As DataTable = FsQuery("SELECT a.project_name,a.project_code,a.project_id FROM lib_erp_project a")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("project_code like '" & txt_project_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "project_code,project_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_project_id.RowData = dr
                txt_project_id.Value = dr("project_id")
                txt_project_id.Text = dr("project_code")
                lbl_project_name.Text = dr("project_name")
            End If
        End If
    End Sub

    Private Sub txt_department_id_Leave(sender As Object, e As EventArgs) Handles txt_department_id.Leave
        Dim data As DataTable = FsQuery("SELECT a.department_name,a.department_code,a.department_id FROM lib_erp_department a")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("department_code like '" & txt_department_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "department_code,department_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_department_id.RowData = dr
                txt_department_id.Value = dr("department_id")
                txt_department_id.Text = dr("department_code")
                lbl_department_name.Text = dr("department_name")
            End If
        End If
    End Sub


    Private Sub btnImportAccount_Click(sender As Object, e As EventArgs) Handles btnImportAccount.Click
        multiplecodesetup.ModuleCode = module_code
        multiplecodesetup.validation = "2"
        multiplecodesetup.ShowDialog()
    End Sub

    Private Sub btnImportGeneral_Click(sender As Object, e As EventArgs) Handles btnImportGeneral.Click
        multiplegeneralsetup.ShowDialog()
    End Sub

    Private Sub txt_general_id_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_general ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("general_code like '" & txt_general_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "general_code,general_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_general_id.RowData = dr
                txt_general_id.Value = dr("general_id")
                txt_general_id.Text = dr("general_code")
                lbl_general_name.Text = dr("general_name")
            End If
        End If
    End Sub

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
    End Sub

    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        If txt_date_to.Value < txt_date_from.Value Then
            If toDate.Checked = False Then
                MsgBox("Invalid Date Range.")
                Exit Sub
            End If
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
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        Dim accountIds As String = ""
        Dim generalIds As String = ""

        Dim account = getRdoValue(account_filter)
        Dim general = getRdoValue(general_filter)
        Dim currency = getRdoValue(currency_filter)

        Dim date_from = txt_date_from.Value
        Dim date_to = txt_date_to.Value

        Dim account_id As String = txt_account_id.Value
        Dim general_id As String = txt_general_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value

        Dim arr_id = getCheckedGrid("book_id", "book_name", "sel", dgBooks, "", False, "Select Book First.")
        If arr_id.Length = 0 Then
            Exit Sub
        End If
        Dim bookIds = String.Join(",", arr_id)
        Dim sql_account As String = String.Format("SELECT account_id " & _
            "FROM lib_acc_chart_multiple a " & _
            "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " & _
            "WHERE a.user_id = '{0}' AND b.module_code = '{1}' ", main.user_id, module_code)
        Dim dt_account As DataTable = FsQuery(sql_account)
        If account = "2" Then
            If dt_account.Rows.Count = 0 Then
                MsgBox("No account setup.")
                Exit Sub
            Else
                For Each dr As DataRow In dt_account.Rows
                    accountIds &= "," & dr.Item("account_id").ToString
                Next
                accountIds = accountIds.Substring(1)
            End If
        End If
        If general = "2" Then
            Dim sql_general As String = String.Format("SELECT general_id " & _
                "FROM lib_acc_general_multiple a " & _
                "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " & _
                "WHERE a.user_id = '{0}' AND b.module_code = '{1}' ", main.user_id, module_code)
            Dim dt_general As DataTable = FsQuery(sql_general)
            If dt_general.Rows.Count = 0 Then
                MsgBox("No general setup.")
                Exit Sub
            Else
                For Each dr As DataRow In dt_general.Rows
                    generalIds &= "," & dr.Item("general_id").ToString
                Next
                generalIds = generalIds.Substring(1)
            End If
        End If
        'IN dbFS VARCHAR(255)
        'IN dbMain VARCHAR(255)
        'IN accountIDS VARCHAR(255)
        'IN generalIDS VARCHAR(255)
        'IN bookIDS VARCHAR(255)
        'IN account VARCHAR(1)
        'IN general VARCHAR(1)
        'IN currency VARCHAR(1)
        'IN date_from VARCHAR(20)
        'IN date_to VARCHAR(20)
        'IN account_id VARCHAR(20)
        'IN general_id VARCHAR(20)
        'IN currency_id VARCHAR(20)
        'IN project_id VARCHAR(20)
        'IN department_id VARCHAR(20)
        'IN toDate TINYINT(1)
        'IN withComparison TINYINT(1)
        'IN withProjectDepartment TINYINT(1)
        Dim sql_range As String = String.Format("SELECT aging_range_id,days_from,days_to " & _
                                                "FROM {0}.sys_aging_range ", _serverDBMain)
        Dim dt_range As DataTable = Query(sql_range)

        If dt_range.Rows.Count <= 0 Then
            MsgBox("No Records to Print.")
            Exit Sub
        End If

        Dim sql As String = String.Format("CALL report_soa_print('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}');", _
            _serverDBFS, _serverDBMain, accountIds, generalIds, bookIds, account, general, currency _
            , date_from.ToString("yyyy-MM-dd"), date_to.ToString("yyyy-MM-dd"), account_id, general_id, _
            currency_id, project_id, department_id, If(toDate.Checked, 1, 0), If(withComparison.Checked, 1, 0), If(withProjectDepartment.Checked, 1, 0))
        Dim dt As DataTable = Query(sql)

        If dt.Rows.Count = 0 Then
            MsgBox("No Records To Print.")
            Exit Sub
        End If

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


        Dim sql_notes = String.Format("SELECT note_id, note_date, note_remarks FROM sys_note ORDER BY note_date DESC LIMIT 1")
        Dim dt_notes As DataTable = Query(sql_notes)

        Dim sql_signatory As String = String.Format("SELECT * FROM selectUserSignatory WHERE module_code = '{0}' AND user_id = '{1}' ", _
                                                    module_code, main.user_id)
        Dim dt_signatory As DataTable = FsQuery(sql_signatory)
        If dt_signatory.Rows.Count > 0 Then
            ds.Tables("UserSignatory").Clear()
            ds.Tables("UserSignatory").ImportRow(dt_signatory.Rows(0))
        End If

        If sender.name = "btnPrint" Then
            Dim rep As New sa_report
            If dt_notes.Rows.Count > 0 Then
                rep.notes.Text = dt_notes.Rows(0).Item("note_remarks")
            End If
            createDataset(dt, dt_range)
            rep.DataSource = ds
            generateColumn(rep, dt_range, first_day, last_day, col_prefix)
            rep.company_name.Text = main.Sys_Default.Rows(0).Item("company_name")
            rep.runtime.Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
            rep.date_now.Text = System.DateTime.Now.ToString("MMMM dd, yyyy")
            rep.date_range.Text = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
            'rep.category.Text = cbo_category.Text
            rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
            reportviewer.DocumentViewer1.DocumentSource = rep
            reportviewer.ShowDialog()
        Else
            Dim dicHeader As New Dictionary(Of String, String)
            dicHeader.Add("templateName", "soa.xlt")
            dicHeader.Add("companyName", "")
            dicHeader.Add("reportDateRange", String.Format("As of {0}", txt_date_to.Value.ToString("MMMM dd, yyyy")))
            'dicHeader.Add("category", cbo_category.Text)
            dicHeader.Item("companyName") = main.Sys_Default.Rows(0).Item("company_name").ToString
            dicHeader.Item("address") = main.Sys_Default.Rows(0).Item("address1").ToString
            'If dt_company.Rows.Count > 0 Then
            'End If
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
    Private Sub createDataset(ByVal dt As DataTable, ByVal dt_aging As DataTable)
        'ds.Clear()
        ds.Tables("Account").Clear()
        ds.Tables("Company").Clear()
        ds.Tables("Aging").Clear()
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

        xlWorksheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorksheet.Cells(2, 1) = "STATEMENT OF ACCOUNT"
        xlWorksheet.Cells(3, 1) = dicHeader.Item("reportDateRange")
        xlWorkSheet.Cells(4, 1) = listAccount.Item(0).Item("general_name").ToString

        Dim current_row As Integer = 5
        Dim current_column As Integer = 5
        Dim grandTotalFirstRow As Integer = 5
        Dim ctr As Integer = 0

        xlWorksheet.Cells(current_row, 1) = "SA No."
        xlWorksheet.Cells(current_row, 1).ColumnWidth = 13
        xlWorksheet.Cells(current_row, 2) = "Date"
        xlWorksheet.Cells(current_row, 2).ColumnWidth = 9
        xlWorksheet.Cells(current_row, 3) = "Particulars"
        xlWorksheet.Cells(current_row, 3).ColumnWidth = 30
        xlWorksheet.Cells(current_row, 4) = "Total"
        xlWorksheet.Cells(current_row, 4).ColumnWidth = 15
        xlWorksheet.Cells(current_row, current_column) = "Current"
        xlWorksheet.Cells(current_row, current_column).ColumnWidth = 15

        For Each dr As DataRow In ds.Tables("Aging").Rows
            current_column += 1
            xlWorksheet.Cells(current_row, current_column) = String.Format("{0} to {1} Days", dr.Item("days_from"), dr.Item("days_to"))
            xlWorksheet.Cells(current_row, current_column).ColumnWidth = 15
            ctr += 1
            If ctr = ds.Tables("Aging").Rows.Count Then
                current_column += 1
                xlWorksheet.Cells(current_row, current_column) = String.Format("Over {0} Days", dr.Item("days_to"))
                xlWorksheet.Cells(current_row, current_column).ColumnWidth = 15
                current_column += 1
                xlWorksheet.Cells(current_row, current_column) = String.Format("Code")
                xlWorksheet.Cells(current_row, current_column).ColumnWidth = 8
                current_column += 1
                xlWorksheet.Cells(current_row, current_column) = String.Format("Reference No.")
                xlWorksheet.Cells(current_row, current_column).ColumnWidth = 13
            End If
        Next

        xlWorksheet.Range(xlWorksheet.Cells(1, 1), xlWorksheet.Cells(1, current_column)).Merge()
        xlWorksheet.Range(xlWorksheet.Cells(1, 1), xlWorksheet.Cells(1, current_column)).Font.Bold = True
        xlWorksheet.Range(xlWorksheet.Cells(1, 1), xlWorksheet.Cells(1, current_column)).Font.Size = 8
        xlWorksheet.Range(xlWorksheet.Cells(2, 1), xlWorksheet.Cells(2, current_column)).Merge()
        xlWorksheet.Range(xlWorksheet.Cells(2, 1), xlWorksheet.Cells(2, current_column)).Font.Bold = True
        xlWorksheet.Range(xlWorksheet.Cells(2, 1), xlWorksheet.Cells(2, current_column)).Font.Size = 10
        xlWorksheet.Range(xlWorksheet.Cells(3, 1), xlWorksheet.Cells(3, current_column)).Merge()
        xlWorksheet.Range(xlWorksheet.Cells(3, 1), xlWorksheet.Cells(3, current_column)).Font.Bold = True
        xlWorksheet.Range(xlWorksheet.Cells(3, 1), xlWorksheet.Cells(3, current_column)).Font.Size = 8
        xlWorksheet.Range(xlWorksheet.Cells(4, 1), xlWorksheet.Cells(4, current_column)).Merge()
        xlWorksheet.Range(xlWorksheet.Cells(4, 1), xlWorksheet.Cells(4, current_column)).Font.Bold = True
        xlWorksheet.Range(xlWorksheet.Cells(4, 1), xlWorksheet.Cells(4, current_column)).Font.Size = 8

        xlWorksheet.Range(xlWorksheet.Cells(1, 1), xlWorksheet.Cells(1, current_column)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorksheet.Range(xlWorksheet.Cells(2, 1), xlWorksheet.Cells(2, current_column)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorksheet.Range(xlWorksheet.Cells(3, 1), xlWorksheet.Cells(3, current_column)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorksheet.Range(xlWorksheet.Cells(4, 1), xlWorksheet.Cells(4, current_column)).HorizontalAlignment = Excel.Constants.xlCenter

        xlWorksheet.Range(xlWorksheet.Cells(5, 1), xlWorksheet.Cells(5, current_column)).Font.Size = 8
        xlWorksheet.Range(xlWorksheet.Cells(5, 1), xlWorksheet.Cells(5, current_column)).Font.Bold = True
        xlWorksheet.Range(xlWorksheet.Cells(5, 1), xlWorksheet.Cells(5, current_column)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorksheet.Range(xlWorksheet.Cells(5, 1), xlWorksheet.Cells(5, current_column)).Interior.Color = System.Drawing.Color.FromArgb(215, 228, 242)
        xlWorksheet.Range(xlWorksheet.Cells(5, 1), xlWorksheet.Cells(5, current_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorksheet.Range(xlWorksheet.Cells(5, 1), xlWorksheet.Cells(5, current_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorksheet.Range(xlWorksheet.Cells(5, 1), xlWorksheet.Cells(5, current_column)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorksheet.Range(xlWorksheet.Cells(5, 1), xlWorksheet.Cells(5, current_column)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
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
    Private Function _summary(Optional groupings As SummaryRunning = SummaryRunning.Group) As XRSummary
        Dim summary As New XRSummary
        summary.Func = SummaryFunc.Sum
        summary.Running = groupings
        summary.FormatString = "{0:#,##0.00}"
        Return summary
    End Function
    Private Sub checkAllBook_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBook.CheckedChanged
        For Each row As DataGridViewRow In dgBooks.Rows
            row.Cells("sel").Value = checkAllBook.Checked
        Next
    End Sub
End Class