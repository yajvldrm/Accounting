Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Imports System.Text.RegularExpressions
Imports DevExpress.XtraSplashScreen

Public Class apdetailedaging
    Private module_code As String = "ACC01001"
    Dim ds As New agingset
    Dim templates As String = Application.StartupPath & "\templates"
    Dim strChar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

    Private Sub account_filter_CheckChange(sender As Object, e As EventArgs) Handles rdo_account_1.CheckedChanged, rdo_account_3.CheckedChanged, rdo_account_2.CheckedChanged
        Dim account As String = getRdoValue(account_filter)
        txt_account_id.Text = ""
        txt_account_id.Value = ""
        lbl_account_name.Text = "Account Name"
        Select Case account
            Case "1"
                btnImportAccount.Enabled = False
                txt_account_id.Enabled = False
            Case "2"
                btnImportAccount.Enabled = True
                txt_account_id.Enabled = False
            Case "3"
                btnImportAccount.Enabled = False
                txt_account_id.Enabled = True
                txt_account_id.Focus()
        End Select
    End Sub
    Private Sub general_filter_CheckChange(sender As Object, e As EventArgs) Handles rdo_general_1.CheckedChanged, rdo_general_2.CheckedChanged, rdo_general_3.CheckedChanged
        Dim general As String = getRdoValue(general_filter)
        txt_general_id.Text = ""
        txt_general_id.Value = ""
        lbl_general_name.Text = "General Library Name"
        Select Case general
            Case "1"
                btnImportGeneral.Enabled = False
                txt_general_id.Enabled = False
            Case "2"
                btnImportGeneral.Enabled = True
                txt_general_id.Enabled = False
            Case "3"
                btnImportGeneral.Enabled = False
                txt_general_id.Enabled = True
                txt_general_id.Focus()
        End Select
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
    Private Sub rdo_currency_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_currency_1.CheckedChanged, rdo_currency_2.CheckedChanged
        Dim currency As String = getRdoValue(currency_filter)
        withComparison.Enabled = False
        If currency = "2" Then
            withComparison.Enabled = True
        End If
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
                    browse.format("Code,Name", "project_code,project_name", "200,400")
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
                    browse.format("Code,Name", "department_code,department_name", "200,400")
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
    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_chart WHERE validation = 3")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("account_code like '" & txt_account_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "account_code,account_name", "200,400")
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
                    browse.format("Code,Name", "general_code,general_name", "200,400")
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
    Private Sub btnImportAccount_Click(sender As Object, e As EventArgs) Handles btnImportAccount.Click
        multiplecodesetup.ModuleCode = module_code
        multiplecodesetup.validation = "3"
        multiplecodesetup.ShowDialog()
    End Sub
    Private Sub btnImportGeneral_Click(sender As Object, e As EventArgs) Handles btnImportGeneral.Click
        multiplegeneralsetup.ModuleCode = module_code
        multiplegeneralsetup.ShowDialog()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim account As String = getRdoValue(account_filter)
        Dim general As String = getRdoValue(general_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim date_to As String = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim account_id As String = txt_account_id.Value
        Dim general_id As String = txt_general_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value
        Dim wComparison As Boolean = withComparison.Checked
        Dim wProjDept As Boolean = withProjectDepartment.Checked

        Dim lst_book = getCheckedGrid("book_id", "book_name", "sel", dgBooks, , False, "No Book Selected", False)
        If lst_book Is Nothing Or lst_book.Length = 0 Then
            Exit Sub
        End If

        Dim bookIds = String.Join(",", lst_book)

        'validation
        Select Case account
            Case "1"
            Case "2"
                Dim sql_account_id As String = String.Format("SELECT a.account_id " &
                    "FROM lib_acc_chart_multiple a " &
                    "LEFT JOIN lib_erp_chart b ON b.account_id = a.account_id " &
                    "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " &
                    "WHERE b.validation = '3' AND a.user_id = '{0}' AND c.module_code = '{1}'", main.user_id, module_code)
                Dim dt_account_id As DataTable = FsQuery(sql_account_id)
                account_id = ""
                If dt_account_id.Rows.Count > 0 Then
                    For Each dr As DataRow In dt_account_id.Rows
                        account_id &= "," & dr.Item("account_id").ToString
                    Next
                End If
                If account_id = "" Then
                    MsgBox("Setup Multiple Account First.")
                    Exit Sub
                Else
                    account_id = account_id.Substring(1)
                End If
            Case "3"
                If account_id = "" Then
                    MsgBox("Select Account First.")
                    txt_account_id.Focus()
                    Exit Sub
                End If
        End Select

        Select Case general
            Case "1"
            Case "2"
                Dim sql_general_id As String = String.Format("SELECT a.general_id " &
                    "FROM lib_acc_general_multiple a " &
                    "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
                    "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
                Dim dt_general_id As DataTable = FsQuery(sql_general_id)
                general_id = ""
                If dt_general_id.Rows.Count > 0 Then
                    For Each dr As DataRow In dt_general_id.Rows
                        general_id &= "," & dr.Item("general_id").ToString
                    Next
                End If
                If general_id = "" Then
                    MsgBox("Setup Multiple General First.")
                    Exit Sub
                Else
                    general_id = general_id.Substring(1)
                End If
            Case "3"
                If general_id = "" Then
                    MsgBox("Select General First.")
                    txt_general_id.Focus()
                    Exit Sub
                End If
        End Select

        Dim sql_project As String = ",'' AS project_id,'' AS project_code,'' AS project_name"
        Dim sql_department As String = ",'' AS department_id,'' AS department_code,'' AS department_name"
        Dim sql_book As String = ",'' AS book_id,'' AS book_code,'' AS book_name"
        If withProjectDepartment.Checked Then
            sql_project = ",b.project_id,i.project_code,i.project_name "
            sql_department = ",b.department_id,j.department_code,j.department_name "
        End If
        If groupByBook.Checked Then
            sql_book = ",a.book_id,_book.book_code,_book.book_name"
        End If
        'query


        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
                                                  "FROM {1}.sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                  "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

        Dim sql_range As String = String.Format("SELECT aging_range_id,days_from,days_to " &
                                                "FROM {0}.sys_aging_range ", _serverDBMain)

        Dim col As New List(Of KeyValuePair(Of String, String))
        col.Add(New KeyValuePair(Of String, String)("@dbMain", _serverDBMain))
        col.Add(New KeyValuePair(Of String, String)("@dbFS", _serverDBFS))
        col.Add(New KeyValuePair(Of String, String)("@validation", "AP"))
        col.Add(New KeyValuePair(Of String, String)("@date_to", CDate(txt_date_to.Value).ToString("yyyy-MM-dd")))
        col.Add(New KeyValuePair(Of String, String)("@account_id", account_id))
        col.Add(New KeyValuePair(Of String, String)("@general_id", general_id))
        col.Add(New KeyValuePair(Of String, String)("@currency_id", currency_id))
        col.Add(New KeyValuePair(Of String, String)("@project_id", project_id))
        col.Add(New KeyValuePair(Of String, String)("@department_id", department_id))
        col.Add(New KeyValuePair(Of String, String)("@book_id", bookIds))
        col.Add(New KeyValuePair(Of String, String)("@group_by_book", If(groupByBook.Checked, "1", "0")))
        col.Add(New KeyValuePair(Of String, String)("@group_by_currency", If(withComparison.Checked, "1", "0")))
        col.Add(New KeyValuePair(Of String, String)("@detailed", "1"))
        Dim dt As DataTable = ExecuteWithParameter("get_aging", ConnectionStringFS, CommandType.StoredProcedure, col)
        'Dim dt As DataTable = Query(sql)
        Dim dt_range As DataTable = Query(sql_range)
        Dim dt_company As DataTable = Query(sql_company)
        If dt.Rows.Count = 0 Then
            MsgBox("No Records to Print")
            Exit Sub
        End If
        If dt_range.Rows.Count = 0 Then
            MsgBox("No Setup for Aging Range.")
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
            Dim trans_date As Date = CDate(dr_balance.Item("trans_date").ToString).AddDays(CType(If(dr_balance.Item("nodays").ToString = "", 0, dr_balance.Item("nodays")), Decimal))
            If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) < first_day Then
                If currency = "1" Then
                    dr_balance.Item(col_prefix & "current") = dr_balance.Item("credit_based")
                Else
                    dr_balance.Item(col_prefix & "current") = dr_balance.Item("credit")
                End If
                dr_balance.Item(col_prefix & "current_based") = dr_balance.Item("credit_based")
                Continue For
            End If
            If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) > last_day Then
                If currency = "1" Then
                    dr_balance.Item(col_prefix & last_day) = dr_balance.Item("credit_based")
                Else
                    dr_balance.Item(col_prefix & last_day) = dr_balance.Item("credit")
                End If
                dr_balance.Item(col_prefix & last_day & "_based") = dr_balance.Item("credit_based")
                Continue For
            End If
            For Each dr_range As DataRow In dt_range.Rows
                If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) >= dr_range.Item("days_from") And DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) <= dr_range.Item("days_to") Then
                    If currency = "1" Then
                        dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to")) = dr_balance.Item("credit_based")
                    Else
                        dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to")) = dr_balance.Item("credit")
                    End If
                    dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to") & "_based") = dr_balance.Item("credit_based")
                End If
            Next
        Next

        createDataset(dt, dt_company, dt_range)
        If (currency = "2" And Not wComparison) Then
            For Each row As DataRow In ds.Tables("Account").Rows
                row.Item("credit_based") = row.Item("credit")
            Next
        End If

        Dim _name As String = "DETAILED AGING OF ACCOUNTS PAYABLE"
        Dim _daterange As String = String.Format("As of {0}", txt_date_to.Value.ToString("MMMM dd, yyyy"))
        Dim _title As String = ""

        If account = 3 Then
            _title = txt_account_id.Text & " ** " & txt_account_id.RowData.Item("account_name")
        End If

        If sender.name = "btnPrint" Then
            Dim rep As New report_aging_detailed_print
            rep.DataSource = ds
            generateColumn(rep, dt_range, first_day, last_day, col_prefix)
            If currency_id <> "" Or currency = "2" Then
                rep.GroupHeader2.Visible = True
                rep.GroupFooter2.Visible = True
            End If
            If currency = "1" Or (currency = "2" And Not wComparison) Then
                rep.headerRow.Cells.Remove(rep.headerBased)
                rep.detailRow.Cells.Remove(rep.detailOriginal)
                rep.footer1Row.Cells.Remove(rep.footer1Original)
                rep.footer2Row.Cells.Remove(rep.footer2Original)
                rep.footer3Row.Cells.Remove(rep.footer3Original)
            End If
            If wProjDept Then
                rep.GroupHeader3.Visible = True
                rep.GroupFooter3.Visible = True
                rep.GroupHeader4.Visible = True
                rep.GroupFooter4.Visible = True
            End If
            rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
            rep.Parameters("name").Value = _name
            rep.Parameters("title").Value = _title
            rep.Parameters("daterange").Value = _daterange
            rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
            reportviewer.DocumentViewer1.DocumentSource = rep
            reportviewer.ShowDialog()
        Else
            Try
                lblLoad.Visible = True
                Dim dicHeader As New Dictionary(Of String, String)
                dicHeader.Add("templateName", "agingdetail.xlt")
                dicHeader.Add("companyName", "")
                dicHeader.Add("reportName", "Detailed Aging of Accounts Payable")
                dicHeader.Add("reportTitle", _title)
                dicHeader.Add("reportDateRange", String.Format("As of {0}", txt_date_to.Value.ToString("MMMM dd, yyyy")))
                dicHeader.Add("currency_name", "")
                dicHeader.Add("first_day", first_day)
                dicHeader.Add("last_day", last_day)
                dicHeader.Add("col_prefix", col_prefix)
                If dt_company.Rows.Count > 0 Then
                    dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
                    dicHeader.Item("currency_name") = dt_company.Rows(0).Item("currency_name").ToString
                End If
                Dim strGrouping As String = ""
                If groupByBook.Checked Then
                    strGrouping = "book_name,account_name"
                Else
                    strGrouping = "account_name"
                End If
                If wProjDept Then
                    strGrouping &= ",project_name,department_name"
                End If
                If currency_id <> "" Or currency = "2" Then
                    strGrouping &= ",currency_name"
                End If
                strGrouping &= ",general_name"
                Dim lstAccount = groupDataTableToList(ds.Tables("Account"), strGrouping)
                If groupByBook.Checked Then
                    'SplashScreenManager.ShowForm(GetType(SCLoad))
                    generateReportExcel(lstAccount, dicHeader, strGrouping, ds.Tables("Account"), ds.Tables("Aging"))
                    'SplashScreenManager.CloseForm()
                    'MsgBox("Report Done")
                Else
                    'SplashScreenManager.ShowForm(GetType(SCLoad))
                    generateExcelReport(lstAccount, dicHeader, strGrouping, ds.Tables("Account"), ds.Tables("Aging"))
                    'SplashScreenManager.CloseForm()
                    'MsgBox("Report Done")
                End If
                MsgBox("Report Done")
                lblLoad.Visible = False
            Catch ex As Exception
                lblLoad.Visible = False
                MsgBox(String.Format("Error Occured : {0}", ex.Message))
                MyDebugging.AddText(ex.Message)
            End Try
        End If
    End Sub
    'Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
    '    Dim account As String = getRdoValue(account_filter)
    '    Dim general As String = getRdoValue(general_filter)
    '    Dim currency As String = getRdoValue(currency_filter)
    '    Dim date_to As String = txt_date_to.Value.ToString("yyyy-MM-dd")
    '    Dim account_id As String = txt_account_id.Value
    '    Dim general_id As String = txt_general_id.Value
    '    Dim currency_id As String = txt_currency_id.Value
    '    Dim project_id As String = txt_project_id.Value
    '    Dim department_id As String = txt_department_id.Value
    '    Dim wComparison As Boolean = withComparison.Checked
    '    Dim wProjDept As Boolean = withProjectDepartment.Checked
    '    Dim str_account_id As String = ""
    '    Dim str_general_id As String = ""

    '    Dim lst_book = getCheckedGrid("book_id", "book_name", "sel", dgBooks, , False, "No Book Selected", False)
    '    If lst_book Is Nothing Or lst_book.Length = 0 Then
    '        Exit Sub
    '    End If

    '    Dim bookIds = String.Join(",", lst_book)

    '    'validation
    '    Select Case account
    '        Case "1"
    '        Case "2"
    '            Dim sql_account_id As String = String.Format("SELECT a.account_id " &
    '                "FROM lib_acc_chart_multiple a " &
    '                "LEFT JOIN lib_erp_chart b ON b.account_id = a.account_id " &
    '                "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " &
    '                "WHERE b.validation = '3' AND a.user_id = '{0}' AND c.module_code = '{1}'", main.user_id, module_code)
    '            Dim dt_account_id As DataTable = FsQuery(sql_account_id)
    '            str_account_id = ""
    '            If dt_account_id.Rows.Count > 0 Then
    '                For Each dr As DataRow In dt_account_id.Rows
    '                    str_account_id &= "," & dr.Item("account_id").ToString
    '                Next
    '            End If
    '            If str_account_id = "" Then
    '                MsgBox("Setup Multiple Account First.")
    '                Exit Sub
    '            Else
    '                str_account_id = str_account_id.Substring(1)
    '            End If
    '        Case "3"
    '            If account_id = "" Then
    '                MsgBox("Select Account First.")
    '                txt_account_id.Focus()
    '                Exit Sub
    '            End If
    '    End Select

    '    Select Case general
    '        Case "1"
    '        Case "2"
    '            Dim sql_general_id As String = String.Format("SELECT a.general_id " &
    '                "FROM lib_acc_general_multiple a " &
    '                "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
    '                "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
    '            Dim dt_general_id As DataTable = FsQuery(sql_general_id)
    '            str_general_id = ""
    '            If dt_general_id.Rows.Count > 0 Then
    '                For Each dr As DataRow In dt_general_id.Rows
    '                    str_general_id &= "," & dr.Item("general_id").ToString
    '                Next
    '            End If
    '            If str_general_id = "" Then
    '                MsgBox("Setup Multiple General First.")
    '                Exit Sub
    '            Else
    '                str_general_id = str_general_id.Substring(1)
    '            End If
    '        Case "3"
    '            If general_id = "" Then
    '                MsgBox("Select General First.")
    '                txt_general_id.Focus()
    '                Exit Sub
    '            End If
    '    End Select

    '    Dim sql_project As String = ",'' AS project_id,'' AS project_code,'' AS project_name"
    '    Dim sql_department As String = ",'' AS department_id,'' AS department_code,'' AS department_name"
    '    Dim sql_book As String = ",'' AS book_id,'' AS book_code,'' AS book_name"
    '    If withProjectDepartment.Checked Then
    '        sql_project = ",b.project_id,i.project_code,i.project_name "
    '        sql_department = ",b.department_id,j.department_code,j.department_name "
    '    End If
    '    If groupByBook.Checked Then
    '        sql_book = ",a.book_id,_book.book_code,_book.book_name"
    '    End If
    '    'query
    '    Dim sql As String = String.Format("SELECT b.jbooks_id,a.trans_id,a.trans_no,a.trans_date,a.description " &
    '        ",(b.debit - IFNULL(e.credit,0)) AS credit,(b.credit - IFNULL(e.debit,0)) AS debit " &
    '        ",(b.debit_based - IFNULL(e.credit_based,0)) AS credit_based,(b.credit_based - IFNULL(e.debit_based,0)) AS debit_based " &
    '        ",b.general_id,f.general_code,f.general_name " &
    '        ",c.terms_id,g.terms_code,g.terms_name,c.nodays " &
    '        ",a.journal_id,h.journal_code,h.journal_name " &
    '        sql_project &
    '        sql_department &
    '        ",b.account_id,d.account_code,d.account_name " &
    '        ",b.currency_id,k.currency_code,k.currency_name,b.exchange_rate " &
    '        sql_book &
    '        " FROM trans_header a " &
    '        "LEFT JOIN {0}.lib_erp_book _book ON _book.book_id = a.book_id " &
    '        "LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " &
    '        "LEFT JOIN trans_jbooks_ap c ON c.jbooks_id = b.jbooks_id " &
    '        "LEFT JOIN {0}.lib_erp_chart d ON d.account_id = b.account_id " &
    '        "LEFT JOIN ( " &
    '        "  SELECT a.ref_jbooks_id AS jbooks_id " &
    '        "  ,SUM(IFNULL(a.debit,0)) AS debit,SUM(IFNULL(a.credit,0)) AS credit " &
    '        "  ,SUM(IFNULL(a.debit_based,0)) AS debit_based,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
    '        "  FROM trans_jbooks a " &
    '        "  LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id " &
    '        "  WHERE b.validation = 3 AND a.ref_jbooks_id IS NOT NULL " &
    '        "  GROUP BY a.ref_jbooks_id " &
    '        ") e ON e.jbooks_id = b.jbooks_id " &
    '        "LEFT JOIN {0}.lib_erp_general f ON f.general_id = b.general_id " &
    '        "LEFT JOIN {0}.lib_erp_terms g ON g.terms_id = c.terms_id " &
    '        "LEFT JOIN {0}.lib_erp_journal h ON h.journal_id = a.journal_id " &
    '        "LEFT JOIN {0}.lib_erp_project i ON i.project_id = b.project_id " &
    '        "LEFT JOIN {0}.lib_erp_department j ON j.department_id = b.department_id " &
    '        "LEFT JOIN {0}.lib_erp_currency k ON k.currency_id = a.currency_id " &
    '        "WHERE a.trans_date <= '{1}' AND d.validation = 3 AND b.ref_jbooks_id IS NULL " &
    '        "AND ((b.debit - IFNULL(e.credit,0)) <> 0 OR (b.credit - IFNULL(e.debit,0)) <> 0) " &
    '        "AND _book.book_id IN ({2}) " &
    '        "", _serverDBFS, date_to, bookIds)

    '    Select Case account
    '        Case "1"
    '        Case "2"
    '            sql &= String.Format(" AND b.account_id IN ({0}) ", str_account_id)
    '        Case "3"
    '            sql &= String.Format(" AND b.account_id = {0} ", account_id)
    '    End Select

    '    Select Case general
    '        Case "1"
    '        Case "2"
    '            sql &= String.Format(" AND b.general_id IN ({0}) ", str_general_id)
    '        Case "3"
    '            sql &= String.Format(" AND b.general_id = {0} ", general_id)
    '    End Select

    '    If currency_id <> "" Then
    '        sql &= String.Format(" AND b.currency_id = {0} ", currency_id)
    '    End If

    '    If project_id <> "" Then
    '        sql &= String.Format(" AND b.project_id = {0} ", project_id)
    '    End If

    '    If department_id <> "" Then
    '        sql &= String.Format(" AND b.department_id = {0} ", department_id)
    '    End If

    '    sql &= String.Format(" GROUP BY b.jbooks_id ")
    '    If currency_id <> "" Or currency = "2" Then
    '        sql &= String.Format(" ,b.currency_id ")
    '    End If
    '    If groupByBook.Checked Then
    '        sql &= String.Format(",a.book_id ")
    '    End If

    '    sql &= "ORDER BY d.account_code,b.general_id,a.trans_date "
    '    '       sql &= String.Format("UNION " & _
    '    '" SELECT a.trans_id,l.ref_no AS trans_no,a.trans_date,f.general_name as description " & _
    '    '" ,(SUM(IFNULL(b.debit,0)) - SUM(IFNULL(e.credit,0))) AS debit,(SUM(IFNULL(b.credit,0)) - SUM(IFNULL(e.debit,0))) AS credit " & _
    '    '" ,(SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(e.credit_based,0))) AS debit_based,(SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(e.debit_based,0))) AS credit_based " & _
    '    '" ,0 AS general_id,a.trans_no AS general_code,'Beginning Balance' AS general_name " & _
    '    '" ,c.terms_id,g.terms_code,g.terms_name,c.nodays " & _
    '    '" ,a.journal_id,h.journal_code,h.journal_name " & _
    '    '" ,b.project_id,i.project_code,i.project_name " & _
    '    '" ,b.department_id,j.department_code,j.department_name " & _
    '    '" ,b.account_id,d.account_code,d.account_name " & _
    '    '" ,k.currency_id, k.currency_code, k.currency_name " & _
    '    '" FROM trans_header a " & _
    '    '" LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
    '    '" LEFT JOIN trans_jbooks_ap c ON c.jbooks_id = b.jbooks_id " & _
    '    '" LEFT JOIN {0}.lib_erp_chart d ON d.account_id = b.account_id " & _
    '    '" LEFT JOIN ( " & _
    '    '"   SELECT a.ref_jbooks_id AS jbooks_id " & _
    '    '"   ,SUM(IFNULL(a.debit,0)) AS debit,SUM(IFNULL(a.credit,0)) AS credit " & _
    '    '"   ,SUM(IFNULL(a.debit_based,0)) AS debit_based,SUM(IFNULL(a.credit_based,0)) AS credit_based " & _
    '    '"   FROM trans_jbooks a " & _
    '    '"   LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id " & _
    '    '"   WHERE b.validation = 3 AND a.ref_jbooks_id IS NOT NULL " & _
    '    '"   GROUP BY a.ref_jbooks_id " & _
    '    '" ) e ON e.jbooks_id = b.jbooks_id " & _
    '    '" LEFT JOIN {0}.lib_erp_general f ON f.general_id = b.general_id " & _
    '    '" LEFT JOIN {0}.lib_erp_terms g ON g.terms_id = c.terms_id " & _
    '    '" LEFT JOIN {0}.lib_erp_journal h ON h.journal_id = a.journal_id " & _
    '    '" LEFT JOIN {0}.lib_erp_project i ON i.project_id = b.project_id " & _
    '    '" LEFT JOIN {0}.lib_erp_department j ON j.department_id = b.department_id " & _
    '    '" LEFT JOIN {0}.lib_erp_currency k ON k.currency_id = b.currency_id " & _
    '    '" LEFT JOIN trans_jbooks_ref l ON l.jbooks_id = b.jbooks_id " & _
    '    '" WHERE d.validation = 3 AND b.ref_jbooks_id IS NULL AND a.journal_id = 8 " & _
    '    '" AND ((b.debit - IFNULL(e.credit,0)) <> 0 OR (b.credit - IFNULL(e.debit,0)) <> 0) " & _
    '    '" GROUP BY b.jbooks_id " & _
    '    '" ORDER BY trans_date", _serverDBFS)

    '    Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
    '                                              "FROM {1}.sys_default a " &
    '                                              "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
    '                                              "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

    '    Dim sql_range As String = String.Format("SELECT aging_range_id,days_from,days_to " &
    '                                            "FROM {0}.sys_aging_range ", _serverDBMain)

    '    Dim dt As DataTable = Query(sql)
    '    Dim dt_range As DataTable = Query(sql_range)
    '    Dim dt_company As DataTable = Query(sql_company)
    '    If dt.Rows.Count = 0 Then
    '        MsgBox("No Records to Print")
    '        Exit Sub
    '    End If
    '    If dt_range.Rows.Count = 0 Then
    '        MsgBox("No Setup for Aging Range.")
    '        Exit Sub
    '    End If

    '    Dim col_prefix As String = "col_"
    '    Dim first_day As Decimal = dt_range.Rows(0).Item("days_from")
    '    Dim last_day As Decimal = 0

    '    dt.Columns.Add(col_prefix & "current")
    '    dt.Columns.Add(col_prefix & "current_based")

    '    For Each row As DataRow In dt_range.Rows
    '        dt.Columns.Add(col_prefix & row.Item("days_from") & "_" & row.Item("days_to"))
    '        dt.Columns.Add(col_prefix & row.Item("days_from") & "_" & row.Item("days_to") & "_based")
    '        last_day = row.Item("days_to")
    '    Next

    '    dt.Columns.Add(col_prefix & last_day)
    '    dt.Columns.Add(col_prefix & last_day & "_based")

    '    For Each dr_balance As DataRow In dt.Rows
    '        Dim trans_date As Date = CType(dr_balance.Item("trans_date"), Date).AddDays(CType(If(dr_balance.Item("nodays").ToString = "", 0, dr_balance.Item("nodays")), Decimal))
    '        If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) < first_day Then
    '            If currency = "1" Then
    '                dr_balance.Item(col_prefix & "current") = dr_balance.Item("debit_based")
    '            Else
    '                dr_balance.Item(col_prefix & "current") = dr_balance.Item("debit")
    '            End If
    '            dr_balance.Item(col_prefix & "current_based") = dr_balance.Item("debit_based")
    '            Continue For
    '        End If
    '        If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) > last_day Then
    '            If currency = "1" Then
    '                dr_balance.Item(col_prefix & last_day) = dr_balance.Item("debit_based")
    '            Else
    '                dr_balance.Item(col_prefix & last_day) = dr_balance.Item("debit")
    '            End If
    '            dr_balance.Item(col_prefix & last_day & "_based") = dr_balance.Item("debit_based")
    '            Continue For
    '        End If
    '        For Each dr_range As DataRow In dt_range.Rows
    '            If DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) >= dr_range.Item("days_from") And DateDiff(DateInterval.Day, trans_date, CType(date_to, Date)) <= dr_range.Item("days_to") Then
    '                If currency = "1" Then
    '                    dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to")) = dr_balance.Item("debit_based")
    '                Else
    '                    dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to")) = dr_balance.Item("debit")
    '                End If
    '                dr_balance.Item(col_prefix & dr_range.Item("days_from") & "_" & dr_range.Item("days_to") & "_based") = dr_balance.Item("debit_based")
    '            End If
    '        Next
    '    Next

    '    createDataset(dt, dt_company, dt_range)
    '    If (currency = "2" And Not wComparison) Then
    '        For Each row As DataRow In ds.Tables("Account").Rows
    '            row.Item("debit_based") = row.Item("debit")
    '        Next
    '    End If

    '    Dim _name As String = "DETAILED AGING OF ACCOUNTS PAYABLE"
    '    Dim _daterange As String = String.Format("As of {0}", txt_date_to.Value.ToString("MMMM dd, yyyy"))
    '    Dim _title As String = ""

    '    If account = 3 Then
    '        _title = txt_account_id.Text & " ** " & txt_account_id.RowData.Item("account_name")
    '    End If

    '    If sender.name = "btnPrint" Then
    '        Dim rep As New report_aging_detailed_print
    '        rep.DataSource = ds
    '        generateColumn(rep, dt_range, first_day, last_day, col_prefix)
    '        If currency_id <> "" Or currency = "2" Then
    '            rep.GroupHeader2.Visible = True
    '            rep.GroupFooter2.Visible = True
    '        End If
    '        If currency = "1" Or (currency = "2" And Not wComparison) Then
    '            rep.headerRow.Cells.Remove(rep.headerBased)
    '            rep.detailRow.Cells.Remove(rep.detailOriginal)
    '            rep.footer1Row.Cells.Remove(rep.footer1Original)
    '            rep.footer2Row.Cells.Remove(rep.footer2Original)
    '            rep.footer3Row.Cells.Remove(rep.footer3Original)
    '        End If
    '        If wProjDept Then
    '            rep.GroupHeader3.Visible = True
    '            rep.GroupFooter3.Visible = True
    '            rep.GroupHeader4.Visible = True
    '            rep.GroupFooter4.Visible = True
    '        End If
    '        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
    '        rep.Parameters("name").Value = _name
    '        rep.Parameters("title").Value = _title
    '        rep.Parameters("daterange").Value = _daterange
    '        rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
    '        reportviewer.DocumentViewer1.DocumentSource = rep
    '        reportviewer.ShowDialog()
    '    Else
    '        Dim dicHeader As New Dictionary(Of String, String)
    '        dicHeader.Add("templateName", "agingdetail.xlt")
    '        dicHeader.Add("companyName", "")
    '        dicHeader.Add("reportName", "Detailed Aging of Accounts Payable")
    '        dicHeader.Add("reportTitle", _title)
    '        dicHeader.Add("reportDateRange", String.Format("As of {0}", txt_date_to.Value.ToString("MMMM dd, yyyy")))
    '        dicHeader.Add("currency_name", "")
    '        dicHeader.Add("first_day", first_day)
    '        dicHeader.Add("last_day", last_day)
    '        dicHeader.Add("col_prefix", col_prefix)
    '        If dt_company.Rows.Count > 0 Then
    '            dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
    '            dicHeader.Item("currency_name") = dt_company.Rows(0).Item("currency_name").ToString
    '        End If
    '        Dim strGrouping As String = ""
    '        If groupByBook.Checked Then
    '            strGrouping = "book_name,account_name"
    '        Else
    '            strGrouping = "account_name"
    '        End If
    '        If wProjDept Then
    '            strGrouping &= ",project_name,department_name"
    '        End If
    '        If currency_id <> "" Or currency = "2" Then
    '            strGrouping &= ",currency_name"
    '        End If
    '        strGrouping &= ",general_name"
    '        Dim lstAccount = groupDataTableToList(ds.Tables("Account"), strGrouping)
    '        If groupByBook.Checked Then
    '            generateReportExcel(lstAccount, dicHeader, strGrouping, ds.Tables("Account"), ds.Tables("Aging"))
    '        Else
    '            generateExcelReport(lstAccount, dicHeader, strGrouping, ds.Tables("Account"), ds.Tables("Aging"))
    '        End If
    '    End If
    'End Sub
    Private Sub generateReportExcel(ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByVal dtAging As DataTable)
        Dim ctrSheet As Integer = 0

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        If xlWorkBook.Worksheets.Count = 3 Then
            xlWorkBook.Worksheets(1).Delete()
            xlWorkBook.Worksheets(1).Delete()
        End If
        For Each g In listAccount
            If ctrSheet > 0 Then
                xlWorkBook.Worksheets().Add()
            End If
            ctrSheet += 1
            xlWorkSheet = xlWorkBook.Worksheets(1)
            xlWorkSheet.Visible = True
            Dim sheetName As String = Regex.Replace(g.Item("book_name").ToString.Trim, "[^A-Za-z0-9]", "")
            If sheetName.Length >= 30 Then
                sheetName = sheetName.Substring(0, 30)
            End If
            xlWorkSheet.Name = sheetName

            xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
            xlWorkSheet.Cells(2, 1) = dicHeader.Item("reportName")
            xlWorkSheet.Cells(3, 1) = g.Item("book_name").ToString
            xlWorkSheet.Cells(4, 1) = dicHeader.Item("reportDateRange")
            xlWorkSheet.Cells(5, 1) = "Bill No."
            xlWorkSheet.Cells(5, 2) = "Date"
            xlWorkSheet.Cells(5, 3) = "Particulars"
            xlWorkSheet.Cells(5, 4) = "Total in Original Amount"
            xlWorkSheet.Cells(5, 5) = "Total in " & dicHeader.Item("currency_name")
            xlWorkSheet.Cells(5, 6) = "Current"

            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(5, 1)).HorizontalAlignment = Excel.Constants.xlCenter

            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, 1)).Font.Bold = True

            Dim current_row As Integer = 5
            Dim current_column As Integer = 6
            Dim current_index As Integer = 1
            Dim grandTotalFirstRow As Integer = current_row
            Dim ctr As Integer = 0

            Dim lastColumn As Integer = 0

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
                End If
            Next


            lastColumn = current_column

            xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, lastColumn)).Interior.Color = System.Drawing.Color.FromArgb(215, 228, 242)
            xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Cells(1, 1).ColumnWidth = 30
            xlWorkSheet.Cells(1, 2).ColumnWidth = 15
            xlWorkSheet.Cells(1, 3).ColumnWidth = 40
            xlWorkSheet.Cells(1, 4).ColumnWidth = 15
            xlWorkSheet.Cells(1, 5).ColumnWidth = 15
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 6), xlWorkSheet.Cells(1, lastColumn)).ColumnWidth = 15
            xlWorkSheet.Cells(5, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Cells(5, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

            xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, lastColumn)).WrapText = True
            xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, lastColumn)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, lastColumn)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, current_column)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, current_column)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, current_column)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, current_column)).Merge()

            current_row += 1
            generateExcelGroup(xlWorkSheet, g.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row, dtAging, current_column)

            current_row += 1
            xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            For i As Integer = 4 To lastColumn
                xlWorkSheet.Cells(current_row, i).Value = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", grandTotalFirstRow, current_row - 1, ConvertToLetter(i))
            Next
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, lastColumn)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            'xlWorkSheet.Cells(current_row, 3).Value = String.Format("=SUBTOTAL(9,C{0}:C{1})", first_row, current_row - 1)
            'xlWorkSheet.Cells(current_row, 4).Value = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
            'xlWorkSheet.Cells(current_row, 5).Value = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
            'xlWorkSheet.Cells(current_row, 6).Value = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
            'xlWorkSheet.Cells(current_row, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
            'xlWorkSheet.Cells(current_row, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3

            current_row += 1
            xlWorkSheet.Cells(current_row, 1).Value = "PERCENTAGE : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            For i As Integer = 6 To lastColumn
                xlWorkSheet.Cells(current_row, i).Value = String.Format("=SUM({1}{0}/E{0})", current_row - 1, ConvertToLetter(i))
                xlWorkSheet.Cells(current_row, i).HorizontalAlignment = Excel.Constants.xlRight
                xlWorkSheet.Cells(current_row, i).NumberFormat = "##0.00%"
            Next
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        Next
    End Sub
    Private Sub generateExcelReport(ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByVal dtAging As DataTable)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHeader.Item("templateName"))
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = dicHeader.Item("reportName")
        xlWorkSheet.Cells(3, 1) = dicHeader.Item("reportTitle")
        xlWorkSheet.Cells(4, 1) = dicHeader.Item("reportDateRange")
        xlWorkSheet.Cells(5, 4) = "Total in " & dicHeader.Item("currency_name")
        xlWorkSheet.Cells(5, 6) = "Current"

        Dim current_row As Integer = 5
        Dim current_column As Integer = 6
        Dim current_index As Integer = 0
        Dim grandTotalFirstRow As Integer = current_row
        Dim ctr As Integer = 0

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
            End If
        Next
        Dim last_column As Integer = current_column
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, current_column)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, current_column)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, current_column)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, current_column)).Merge()

        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Interior.Color = System.Drawing.Color.FromArgb(215, 228, 242)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xlWorkSheet.Cells(current_row, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Cells(current_row, last_column).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

        current_row += 1
        generateExcelGroup(xlWorkSheet, listAccount, dicHeader, strCol, dtAccount, current_index, current_row, dtAging, current_column)

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        For i As Integer = 4 To last_column
            xlWorkSheet.Cells(current_row, i).Value = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", grandTotalFirstRow, current_row - 1, ConvertToLetter(i))
        Next
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "PERCENTAGE : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        For i As Integer = 6 To last_column - 1
            xlWorkSheet.Cells(current_row, i).Value = String.Format("=SUM({1}{0}/E{0})", current_row - 1, ConvertToLetter(i))
            xlWorkSheet.Cells(current_row, i).HorizontalAlignment = Excel.Constants.xlRight
            xlWorkSheet.Cells(current_row, i).NumberFormat = "##0.00%"
        Next
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub generateExcelGroup(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByRef current_index As Integer, ByRef current_row As Integer, ByVal dtAging As DataTable, ByVal last_column As Integer)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
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
                        current_row += 1
                        Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11))
                        xlWorkSheet.Cells(current_row, 1).Value = "******* " & dicItem(field) & " *******"
                        range.Merge()
                        range.Font.Bold = True
                        range.HorizontalAlignment = Excel.Constants.xlCenter
                        range.Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                        current_row += 1
                        current_index += 1
                        Dim first_row As Integer = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row, dtAging, last_column)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                        Dim current_column As Integer = 7
                        For Each dr As DataRow In dtAging.Rows
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", ConvertToLetter(current_column), first_row, current_row - 1)
                            current_column += 1
                        Next
                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", ConvertToLetter(current_column), first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        current_column += 1
                        current_row += 1
                    Case "currency_name"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        current_index += 1
                        Dim first_row As Integer = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row, dtAging, last_column)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDash
                        Dim current_column As Integer = 7
                        For Each dr As DataRow In dtAging.Rows
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", ConvertToLetter(current_column), first_row, current_row - 1)
                            current_column += 1
                        Next
                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", ConvertToLetter(current_column), first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        current_column += 1
                        current_row += 1
                    Case Else
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
                        current_row += 1
                        current_index += 1
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row, dtAging, last_column)
                        current_index -= 1
                        current_row += 1
                End Select
            Else
                If field = "account_name" Then
                    current_row += 1
                    Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11))
                    xlWorkSheet.Cells(current_row, 1).Value = "******* " & dicItem(field) & " *******"
                    range.Merge()
                    range.Font.Bold = True
                    range.HorizontalAlignment = Excel.Constants.xlCenter
                    range.Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                    current_row += 1
                ElseIf field = "general_name" Or field = "currency_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                    current_row += 1
                Else
                    xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
                    current_row += 1
                End If

                Dim first_row As Integer = current_row
                Dim currency As String = getRdoValue(currency_filter)
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, Object) Then
                        dic = CType(d, Dictionary(Of String, Object))
                    Else
                        dic = CType(d, Dictionary(Of String, String))
                    End If
                    xlWorkSheet.Cells(current_row, 1).Value = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 2).Value = CDate(dic.Item("trans_date").ToString)
                    xlWorkSheet.Cells(current_row, 2).NumberFormat = "MM/dd/yyyy"
                    xlWorkSheet.Cells(current_row, 3).Value = dic.Item("description")
                    xlWorkSheet.Cells(current_row, 3).WrapText = False
                    xlWorkSheet.Cells(current_row, 4).Value = dic.Item("credit_based")
                    xlWorkSheet.Cells(current_row, 5).Value = dic.Item("credit")
                    xlWorkSheet.Cells(current_row, 6).Value = dic.Item(dicHeader.Item("col_prefix") & "current")
                    Dim current_column As Integer = 7
                    For Each dr As DataRow In dtAging.Rows
                        xlWorkSheet.Cells(current_row, current_column).Value = dic.Item(dicHeader.Item("col_prefix") & dr.Item("days_from") & "_" & dr.Item("days_to"))
                        current_column += 1
                    Next
                    xlWorkSheet.Cells(current_row, current_column).Value = dic.Item(dicHeader.Item("col_prefix") & dicHeader.Item("last_day"))
                    current_column += 1
                    xlWorkSheet.Cells(current_row, current_column).Value = "'" & dic.Item("account_code")
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    current_row += 1
                Next
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                If currency = "1" Then
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                End If
                If currency = "2" Then
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDash
                End If
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                Dim current_column1 As Integer = 7
                For Each dr As DataRow In dtAging.Rows
                    xlWorkSheet.Cells(current_row, current_column1) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", ConvertToLetter(current_column1), first_row, current_row - 1)
                    current_column1 += 1
                Next
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Cells(current_row, current_column1) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", ConvertToLetter(current_column1), first_row, current_row - 1)
                current_column1 += 1
                current_row += 1
            End If
        Next
    End Sub
    Private Sub createDataset(ByVal dt_balance As DataTable, ByVal dt_company As DataTable, ByVal dt_aging As DataTable)
        ds.Tables("Account").Clear()
        ds.Tables("Company").Clear()
        ds.Tables("Aging").Clear()

        'Account
        For Each col As DataColumn In dt_balance.Columns
            If Not ds.Tables("Account").Columns.Contains(col.ColumnName) Then
                ds.Tables("Account").Columns.Add(col.ColumnName)
                ds.Tables("Account").Columns(col.ColumnName).DataType = System.Type.GetType("System.Decimal")
            End If
        Next

        'Account
        For Each row As DataRow In dt_balance.Rows
            ds.Tables("Account").ImportRow(row)
        Next

        'Company
        For Each row As DataRow In dt_company.Rows
            ds.Tables("Company").ImportRow(row)
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
    Public Sub generateColumn(ByVal rep As XtraReport, ByVal dt As DataTable, ByVal first_day As String, ByVal last_day As String, Optional col_prefix As String = "", Optional origCurrency As Boolean = False)
        Dim ds As DataSet = (CType(rep.DataSource, DataSet))
        Dim totalCreditBased As Decimal = 0
        Dim totalCredit As Decimal = 0

        If ds.Tables("Account").Select("credit > 0").Count > 0 Then
            totalCreditBased = ds.Tables("Account").Compute("SUM(credit)", "credit > 0")
        End If

        If ds.Tables("Account").Select("credit > 0").Count > 0 Then
            totalCredit = ds.Tables("Account").Compute("SUM(credit)", "credit > 0")
        End If

        If origCurrency Then
            totalCredit = totalCreditBased
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

        tblFooter1.HeightF = rep.FindControl("panel_footer_1", False).HeightF
        tblFooter1.WidthF = rep.FindControl("panel_footer_1", False).WidthF
        tblFooter1.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblFooter1.BeginInit()

        tblFooter2.HeightF = rep.FindControl("panel_footer_2", False).HeightF
        tblFooter2.WidthF = rep.FindControl("panel_footer_2", False).WidthF
        tblFooter2.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblFooter2.BeginInit()

        tblGrandTotal.HeightF = rep.FindControl("panel_grand_total", False).HeightF
        tblGrandTotal.WidthF = rep.FindControl("panel_grand_total", False).WidthF
        tblGrandTotal.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        tblGrandTotal.BeginInit()

        tblPercentage.HeightF = rep.FindControl("panelPercentage", False).HeightF
        tblPercentage.WidthF = rep.FindControl("panelPercentage", False).WidthF
        tblPercentage.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblPercentage.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        tblPercentage.BeginInit()

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

        Dim tmp_computed = If(totalCredit > 0, currTotal / totalCredit, 0)
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

            tmp_computed = If(totalCredit > 0, (tmp_var / totalCredit), 0)
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

        Dim overRows = ds.Tables("Account").Select(String.Format("{0} <> 0", col_prefix & last_day))
        Dim overValue As Decimal = 0

        If overRows.Length > 0 Then
            overValue = ds.Tables("Account").Compute(String.Format("SUM({0})", col_prefix & last_day), col_prefix & last_day & " <> 0")
        End If

        tmp_computed = If(totalCredit > 0, (overValue / totalCredit), 0)
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
        rep.FindControl("panel_footer_1", False).Controls.Add(tblFooter1)
        rep.FindControl("panel_footer_2", False).Controls.Add(tblFooter2)
        rep.FindControl("panel_grand_total", False).Controls.Add(tblGrandTotal)
        rep.FindControl("panelPercentage", False).Controls.Add(tblPercentage)
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
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub apdetailedaging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)

        Dim sql As String = String.Format("SELECT False AS sel,a.book_id,a.book_code,a.book_name " & vbNewLine &
            "FROM lib_erp_book a " & vbNewLine &
            "WHERE a.company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id").ToString)
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables("lib_erp_book").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("lib_erp_book").ImportRow(dr)
        Next
        dgBooks.AutoGenerateColumns = False
        dgBooks.DataSource = ds.Tables("lib_erp_book")
    End Sub

    Private Sub checkAllBook_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBook.CheckedChanged
        If dgBooks.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgBooks.Rows
                row.Cells("sel").Value = checkAllBook.Checked
            Next
        End If
    End Sub
End Class