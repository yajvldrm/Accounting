Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class fixedassetreport
    Private module_code As String = "ACC01009"
    Dim ds As New fixedassetset
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub setMaxDay(ByVal ctrl As Object, ByVal month As Integer, ByVal year As Integer)
        If year > 0 And month > 0 Then
            Dim currenctDate As New Date(year, month, 1)
            Dim lastDate = currenctDate.AddMonths(1).AddDays(-1)
            ctrl.Maximum = lastDate.ToString("dd")
            txt_day_from.Value = txt_day_from.Minimum
            txt_day_to.Value = txt_day_to.Maximum
        End If
    End Sub
    Private Sub PrintChange(sender As Object, e As EventArgs) Handles rdo_print_1.CheckedChanged, rdo_print_2.CheckedChanged
        Dim print As String = getRdoValue(print_filter)
        If print = "1" Then
            includeDepriciatedAsset.Enabled = False
            toDate.Enabled = True
            txt_day_from.Visible = True
            txt_day_to.Visible = True
            withComparison.Visible = True
            depriciated_filter.Visible = True
            txt_month_from.Enabled = True
            txt_year_to.Enabled = True
        Else
            includeDepriciatedAsset.Enabled = True
            toDate.Enabled = False
            txt_day_from.Visible = False
            txt_day_to.Visible = False
            withComparison.Visible = False
            depriciated_filter.Visible = False
            txt_month_from.Enabled = True
            txt_year_to.Enabled = True
        End If
        txt_year_to.Value = txt_year_from.Value
        txt_month_from.Value = 1
        txt_month_to.Value = 12
        txt_day_from.Value = 1
        txt_day_to.Value = 31
    End Sub
    Private Sub accountChange(sender As Object, e As EventArgs) Handles rdo_account_3.AppearanceChanged, rdo_account_2.AppearanceChanged, rdo_account_1.AppearanceChanged
        Dim account As String = getRdoValue(account_filter)
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
    Private Sub rdo_currency_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_currency_1.CheckedChanged, rdo_currency_2.CheckedChanged
        Dim currency As String = getRdoValue(currency_filter)
        withComparison.Enabled = False
        If currency = "2" Then
            withComparison.Enabled = True
        End If
    End Sub
    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_chart WHERE validation = 9")
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
    Private Sub btnImportAccount_Click(sender As Object, e As EventArgs) Handles btnImportAccount.Click
        multiplecodesetup.ModuleCode = module_code
        multiplecodesetup.validation = "9"
        multiplecodesetup.ShowDialog()
    End Sub
    Private Sub txt_year_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_year_from.ValueChanged
        txt_year_to.Value = txt_year_from.Value
        setMaxDay(txt_day_from, txt_month_from.Value, txt_year_from.Value)
    End Sub
    Private Sub txt_month_from_ValueChange(sender As Object) Handles txt_month_from.ValueChange
        setMaxDay(txt_day_from, txt_month_from.Value, txt_year_from.Value)
    End Sub
    Private Sub txt_month_to_ValueChange(sender As Object) Handles txt_month_to.ValueChange
        setMaxDay(txt_day_to, txt_month_to.Value, txt_year_to.Value)
    End Sub
    Private Sub txt_year_to_ValueChanged(sender As Object, e As EventArgs) Handles txt_year_to.ValueChanged
        setMaxDay(txt_day_to, txt_month_to.Value, txt_year_to.Value)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim print As String = getRdoValue(print_filter)
        Dim account As String = getRdoValue(account_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim depriciated As String = getRdoValue(depriciated_filter)
        Dim tDate As Boolean = toDate.Checked
        Dim includeAsset As Boolean = includeDepriciatedAsset.Checked
        Dim wComparison As Boolean = withComparison.Checked
        Dim wProjectDepartment As Boolean = withProjectDepartment.Checked
        Dim account_id As String = txt_account_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value
        Dim month_from As Integer = txt_month_from.Value
        Dim day_from As Integer = txt_day_from.Value
        Dim year_from As Integer = txt_year_from.Value
        Dim month_to As Integer = txt_month_to.Value
        Dim day_to As Integer = txt_day_to.Value
        Dim year_to As Integer = txt_year_to.Value
        Dim dFrom As New Date(year_from, month_from, day_from)
        Dim dTo As New Date(year_to, month_to, day_to)
        Dim date_from As String = dFrom.ToString("yyyy-MM-dd")
        Dim date_to As String = dTo.ToString("yyyy-MM-dd")
        Dim str_month_from As String = If(month_from < 10, "0" & month_from, month_from)
        Dim str_month_to As String = If(month_to < 10, "0" & month_to, month_to)
        Dim str_account_id As String = ""

        'validation
        Select Case account
            Case "1"
            Case "2"
                Dim sql_account_id As String = String.Format("SELECT GROUP_CONCAT(a.account_id) AS account_id " & _
                    "FROM lib_acc_chart_multiple a " & _
                    "LEFT JOIN lib_erp_chart b ON b.account_id = a.account_id " & _
                    "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " & _
                    "WHERE b.validation = '9' AND a.user_id = '{0}' AND c.module_code = '{1}'", main.user_id, module_code)
                Dim dt_account_id As DataTable = FsQuery(sql_account_id)
                str_account_id = dt_account_id.Rows(0).Item("account_id").ToString
                If str_account_id = "" Then
                    MsgBox("Setup Multiple Account First.")
                    Exit Sub
                End If
            Case "3"
                If account_id = "" Then
                    MsgBox("Select Account First.")
                    txt_account_id.Focus()
                    Exit Sub
                End If
        End Select

        If print = "1" Then
            If dTo < dFrom Then
                MsgBox("Invalid Date Range.")
                txt_day_from.Focus()
                Exit Sub
            End If
        Else
            If year_to < year_from Then
                MsgBox("Invalid Year.")
                txt_year_from.Focus()
                Exit Sub
            End If
        End If

        'query
        Dim sql_balance = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " &
            ",c.fixed_asset_id,c.quantity,c.asset_code,c.description,c.date_acquired,c.date_start " &
            ",CONCAT(e.journal_code,' ',d.book_code,' ',a.trans_no) AS reference " &
            ",IFNULL(k.useful_life,c.useful_life) AS useful_life,c.amount_based,c.amount,c.salvage_value,c.salvage_value_based " &
            ",f.account_code,f.account_name " &
            ",c.currency_id,g.currency_code,g.currency_name " &
            ",b.project_id,h.project_code,h.project_name " &
            ",b.department_id,i.department_code,i.department_name " &
            ",IFNULL(((c.amount - c.salvage_value)/IFNULL(k.useful_life,c.useful_life)),0) AS monthly_depreciation " &
            ",IFNULL(((c.amount_based - c.salvage_value_based)/IFNULL(k.useful_life,c.useful_life)),0) AS monthly_depreciation_based " &
            ",(c.exchange_rate / c.based_rate) AS exchange_rate " &
            "FROM {1}.trans_header a " &
            "LEFT JOIN {1}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "LEFT JOIN {1}.trans_fixed_asset c ON c.jbooks_id = b.jbooks_id " &
            "LEFT JOIN {0}.lib_erp_book d ON d.book_id = a.book_id " &
            "LEFT JOIN {0}.lib_erp_journal e ON e.journal_id = a.journal_id " &
            "LEFT JOIN {0}.lib_erp_chart f ON f.account_id = b.account_id " &
            "LEFT JOIN {0}.lib_erp_currency g ON g.currency_id = c.currency_id " &
            "LEFT JOIN {0}.lib_erp_project h ON h.project_id = b.project_id " &
            "LEFT JOIN {0}.lib_erp_department i ON i.department_id = b.department_id " &
            "LEFT JOIN {0}.lib_acc_chart_multiple j ON j.account_id = f.account_id " &
            "LEFT JOIN {1}.trans_fixed_asset k ON k.fixed_asset_id = c.fixed_asset_id " &
            "WHERE f.validation = 9 " &
            "", _serverDBFS, _serverDBMain)

        If print = "1" Then
            If tDate Then
                sql_balance &= String.Format(" AND a.trans_date <= '{0}' ", date_to)
            Else
                sql_balance &= String.Format(" AND a.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)
            End If
        End If

        If account = "2" Then
            sql_balance &= String.Format(" AND f.account_id IN ({0}) ", str_account_id)
        ElseIf account = "3" Then
            sql_balance &= String.Format(" AND f.account_id = {0} ", account_id)
        End If

        If currency_id <> "" Then
            sql_balance &= String.Format(" AND c.currency_id = {0} ", currency_id)
        End If

        If project_id <> "" Then
            sql_balance &= String.Format(" AND b.project_id = {0} ", project_id)
        End If

        If department_id <> "" Then
            sql_balance &= String.Format(" AND b.department_id = {0} ", department_id)
        End If

        Dim dt_balance As DataTable = Query(sql_balance)
        ds.Tables("Accounts").Clear()

        For Each row As DataRow In dt_balance.Rows
            ds.Tables("Accounts").ImportRow(row)
        Next
        '(ByVal dt_balance As DataTable, ByVal month_from As Integer, ByVal month_to As Integer, ByVal date_from As Date, ByVal year_from As Integer, ByVal year_to As Integer)
        setDataSet(ds.Tables("Accounts"), month_from, month_to, date_from, year_from, year_to)
        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
                                                  "FROM {1}.sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                  "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

        Dim dt_company As DataTable = Query(sql_company)
        ds.Tables("Company").Clear()

        For Each row As DataRow In dt_company.Rows
            ds.Tables("Company").ImportRow(row)
        Next

        'reporting
        Dim _name As String = "Fixed Asset"
        Dim _daterange As String = "From " & dFrom.ToString("MMMM dd, yyyy") & " To " & dTo.ToString("MMMM dd, yyyy")
        Dim _title As String = ""
        Dim _runtime As String = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
        Dim showFooter As Boolean = False

        If sender.name = "btnPrint" Then
            If print = "1" Then
                Dim tmp_str = ""
                If depriciated = "2" Then
                    tmp_str = "ending_book_value_based = '0'"
                ElseIf depriciated = "3" Then
                    tmp_str = "ending_book_value_based <> '0'"
                End If
                If depriciated <> "1" Then
                    Dim tmp_dt As New DataTable("Accounts")
                    For Each col As DataColumn In ds.Tables("Accounts").Columns
                        tmp_dt.Columns.Add(col.ColumnName)
                    Next
                    For Each row As DataRow In ds.Tables("Accounts").Select(tmp_str)
                        tmp_dt.ImportRow(row)
                    Next
                    ds.Tables("Accounts").Clear()
                    For Each row As DataRow In tmp_dt.Rows
                        ds.Tables("Accounts").ImportRow(row)
                    Next
                End If
                If ds.Tables("Accounts").Rows.Count = 0 Then
                    MsgBox("No Records to Print.")
                    Exit Sub
                End If
                _title = "Listing of Fixed Asset"
                If currency = "2" And wComparison Then
                    Dim rep As New report_fixedasset_print_3
                    rep.DataSource = ds
                    If Not wProjectDepartment Then
                        rep.GroupHeader2.Visible = False
                        rep.GroupFooter2.Visible = False
                        rep.GroupHeader3.Visible = False
                        rep.GroupFooter3.Visible = False
                    End If
                    rep.ReportFooter.Visible = showFooter
                    rep.Parameters("runtime").Value = _runtime
                    rep.Parameters("name").Value = _name
                    rep.Parameters("title").Value = _title
                    rep.Parameters("daterange").Value = _daterange
                    rep.Parameters("asOf").Value = dFrom.AddDays(-1).ToString("MM/dd/yyyy")
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                Else
                    Dim rep As New report_fixedasset_print_4
                    rep.DataSource = ds
                    If currency = "1" Then
                        rep.GroupHeader1.Visible = False
                        rep.GroupFooter1.Visible = False
                        showFooter = True
                        For Each row As DataRow In ds.Tables("Accounts").Rows
                            row.Item("amount") = row.Item("amount_based")
                            row.Item("salvage_value") = row.Item("salvage_value_based")
                            row.Item("monthly_depreciation") = row.Item("monthly_depreciation_based")
                            row.Item("beg_acc_depreciation") = row.Item("beg_acc_depreciation_based")
                            row.Item("beg_net_book_value") = row.Item("beg_net_book_value_based")
                            row.Item("total_depreciation") = row.Item("total_depreciation_based")
                            row.Item("end_accumulated_depreciation") = row.Item("end_accumulated_depreciation_based")
                            row.Item("ending_book_value") = row.Item("ending_book_value_based")
                        Next
                    End If
                    If currency_id <> "" Then
                        rep.GroupHeader1.Visible = True
                        rep.GroupFooter1.Visible = True
                        showFooter = False
                    End If
                    If Not wProjectDepartment Then
                        rep.GroupHeader2.Visible = False
                        rep.GroupFooter2.Visible = False
                        rep.GroupHeader3.Visible = False
                        rep.GroupFooter3.Visible = False
                        showFooter = True
                    Else
                        showFooter = False
                    End If
                    rep.ReportFooter.Visible = showFooter
                    rep.Parameters("runtime").Value = _runtime
                    rep.Parameters("name").Value = _name
                    rep.Parameters("title").Value = _title
                    rep.Parameters("daterange").Value = _daterange
                    rep.Parameters("asOf").Value = dFrom.AddDays(-1).ToString("MM/dd/yyyy")
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                End If
            Else
                If ds.Tables("Accounts").Rows.Count = 0 Then
                    MsgBox("No Records to Print.")
                    Exit Sub
                End If
                _title = "Lapsing of Fixed Asset"
                Dim rep As New report_fixedasset_print_1
                Dim rep2 As New report_fixedasset_print_2
                rep.DataSource = ds
                rep2.DataSource = ds
                If currency = "1" Then
                    rep.GroupHeader1.Visible = False
                    rep.GroupFooter1.Visible = False
                    rep2.GroupHeader1.Visible = False
                    rep2.GroupFooter1.Visible = False
                    showFooter = True
                    For Each row As DataRow In ds.Tables("Accounts").Rows
                        row.Item("amount") = row.Item("amount_based")
                        row.Item("salvage_value") = row.Item("salvage_value_based")
                        row.Item("monthly_depreciation") = row.Item("monthly_depreciation_based")
                        row.Item("beg_acc_depreciation") = row.Item("beg_acc_depreciation_based")
                        row.Item("beg_net_book_value") = row.Item("beg_net_book_value_based")
                        row.Item("total_depreciation") = row.Item("total_depreciation_based")
                        row.Item("end_accumulated_depreciation") = row.Item("end_accumulated_depreciation_based")
                        row.Item("ending_book_value") = row.Item("ending_book_value_based")
                    Next
                End If
                If currency_id <> "" Then
                    rep.GroupHeader1.Visible = True
                    rep.GroupFooter1.Visible = True
                    rep2.GroupHeader1.Visible = True
                    rep2.GroupFooter1.Visible = True
                    showFooter = False
                End If
                If Not wProjectDepartment Then
                    rep.GroupHeader2.Visible = False
                    rep.GroupFooter2.Visible = False
                    rep.GroupHeader3.Visible = False
                    rep.GroupFooter3.Visible = False
                    rep2.GroupHeader2.Visible = False
                    rep2.GroupFooter2.Visible = False
                    rep2.GroupHeader3.Visible = False
                    rep2.GroupFooter3.Visible = False
                    showFooter = True
                Else
                    showFooter = False
                End If
                rep.ReportFooter.Visible = showFooter
                rep2.ReportFooter.Visible = showFooter
                rep.Parameters("runtime").Value = _runtime
                rep.Parameters("name").Value = _name
                rep.Parameters("title").Value = _title
                rep.Parameters("daterange").Value = _daterange
                rep.Parameters("asOf").Value = dFrom.AddDays(-1).ToString("MM/dd/yyyy")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                rep2.Parameters("runtime").Value = _runtime
                rep2.Parameters("name").Value = _name
                rep2.Parameters("title").Value = _title
                rep2.Parameters("daterange").Value = _daterange
                rep2.Parameters("asOf").Value = dFrom.AddDays(-1).ToString("MM/dd/yyyy")
                rep2.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
                reportviewer.DocumentViewer1.DocumentSource = rep2
                reportviewer.ShowDialog()
            End If
        Else
            If ds.Tables("Accounts").Rows.Count = 0 Then
                MsgBox("No Records to Print.")
                Exit Sub
            End If
            Dim dicHeader As New Dictionary(Of String, String)
            dicHeader.Add("companyName", "")
            dicHeader.Add("reportDateRange", "From " & MonthName(month_from) & ", " & year_from & " to " & MonthName(month_to) & ", " & year_to)
            dicHeader.Add("asOf", date_to)
            Dim companyCurrency As String = "'"
            Dim reportTitle As String = ""
            Dim templateName As String = ""
            If dt_company.Rows.Count > 0 Then
                dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
            End If
            If dt_company.Rows.Count > 0 Then
                companyCurrency = dt_company.Rows(0).Item("currency_name").ToString
            End If
            Dim strGrouping As String = "currency_name,account_name"
            If wProjectDepartment Then
                strGrouping &= ",project_name,department_name"
            End If
            Dim listAccount = groupDataTableToList(ds.Tables("Accounts"), strGrouping)
            If currency = "2" And wComparison Then
                templateName = "fixedasset2.xlt"
                reportTitle = "Listing of Fixed Asset"
                Try
                    lblLoad.Visible = True
                    excelfixedasset2(listAccount, strGrouping, dicHeader, templateName, reportTitle, companyCurrency)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            ElseIf rdo_print_1.Checked = True Then
                templateName = "fixedasset3.xlt"
                reportTitle = "Listing of Listing Asset"
                Try
                    lblLoad.Visible = True
                    excelfixedasset3(listAccount, strGrouping, dicHeader, templateName, reportTitle)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            End If
            If rdo_print_2.Checked = True Then
                templateName = "fixedasset.xlt"
                reportTitle = "Lapsing of Fixed Asset"
                Try
                    lblLoad.Visible = True
                    excelfixedasset(listAccount, strGrouping, dicHeader, templateName, reportTitle)
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
    Private Sub excelfixedasset(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByVal templateName As String, ByVal reportTitle As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(3, 1) = reportTitle
        xlWorkSheet.Cells(4, 1) = dicHeader.Item("reportDateRange")
        xlWorkSheet.Cells(5, 8) = "Acquisition Cost Of " & dicHeader.Item("asOf")
        xlWorkSheet.Cells(5, 10) = "Beg. Acc. Dep'n As Of " & dicHeader.Item("asOf")
        xlWorkSheet.Cells(5, 11) = "Beg. Net Book Value Of " & dicHeader.Item("asOf")

        Dim firstrow As Integer = 6
        Dim current_row As Integer = 6
        Dim current_index As Integer = 0
        reportfixedasset(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 15) = String.Format("=SUBTOTAL(9,O{0}:O{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 16) = String.Format("=SUBTOTAL(9,P{0}:P{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 17) = String.Format("=SUBTOTAL(9,Q{0}:Q{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 18) = String.Format("=SUBTOTAL(9,R{0}:R{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 19) = String.Format("=SUBTOTAL(9,S{0}:S{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 20) = String.Format("=SUBTOTAL(9,T{0}:T{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 21) = String.Format("=SUBTOTAL(9,U{0}:U{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 22) = String.Format("=SUBTOTAL(9,V{0}:V{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 23) = String.Format("=SUBTOTAL(9,W{0}:W{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 24) = String.Format("=SUBTOTAL(9,X{0}:X{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 25) = String.Format("=SUBTOTAL(9,Y{0}:Y{1})", firstrow, current_row - 1)
        xlWorkSheet.Cells(current_row, 26) = String.Format("=SUBTOTAL(9,Z{0}:Z{1})", firstrow, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub reportfixedasset(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer)
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
                    Case "currency_name"
                        If rdo_currency_2.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "CURRENCY: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 15) = String.Format("=SUBTOTAL(9,O{0}:O{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 16) = String.Format("=SUBTOTAL(9,P{0}:P{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 17) = String.Format("=SUBTOTAL(9,Q{0}:Q{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 18) = String.Format("=SUBTOTAL(9,R{0}:R{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 19) = String.Format("=SUBTOTAL(9,S{0}:S{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 20) = String.Format("=SUBTOTAL(9,T{0}:T{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 21) = String.Format("=SUBTOTAL(9,U{0}:U{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 22) = String.Format("=SUBTOTAL(9,V{0}:V{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 23) = String.Format("=SUBTOTAL(9,W{0}:W{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 24) = String.Format("=SUBTOTAL(9,X{0}:X{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 25) = String.Format("=SUBTOTAL(9,Y{0}:Y{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 26) = String.Format("=SUBTOTAL(9,Z{0}:Z{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                            current_row += 1
                        Else
                            reportfixedasset(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "project_name"
                        If withProjectDepartment.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "PROJECT: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 15) = String.Format("=SUBTOTAL(9,O{0}:O{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 16) = String.Format("=SUBTOTAL(9,P{0}:P{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 17) = String.Format("=SUBTOTAL(9,Q{0}:Q{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 18) = String.Format("=SUBTOTAL(9,R{0}:R{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 19) = String.Format("=SUBTOTAL(9,S{0}:S{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 20) = String.Format("=SUBTOTAL(9,T{0}:T{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 21) = String.Format("=SUBTOTAL(9,U{0}:U{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 22) = String.Format("=SUBTOTAL(9,V{0}:V{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 23) = String.Format("=SUBTOTAL(9,W{0}:W{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 24) = String.Format("=SUBTOTAL(9,X{0}:X{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 25) = String.Format("=SUBTOTAL(9,Y{0}:Y{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 26) = String.Format("=SUBTOTAL(9,Z{0}:Z{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            current_row += 1
                        Else
                            reportfixedasset(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "department_name"
                        If withProjectDepartment.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 15) = String.Format("=SUBTOTAL(9,O{0}:O{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 16) = String.Format("=SUBTOTAL(9,P{0}:P{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 17) = String.Format("=SUBTOTAL(9,Q{0}:Q{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 18) = String.Format("=SUBTOTAL(9,R{0}:R{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 19) = String.Format("=SUBTOTAL(9,S{0}:S{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 20) = String.Format("=SUBTOTAL(9,T{0}:T{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 21) = String.Format("=SUBTOTAL(9,U{0}:U{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 22) = String.Format("=SUBTOTAL(9,V{0}:V{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 23) = String.Format("=SUBTOTAL(9,W{0}:W{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 24) = String.Format("=SUBTOTAL(9,X{0}:X{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 25) = String.Format("=SUBTOTAL(9,Y{0}:Y{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 26) = String.Format("=SUBTOTAL(9,Z{0}:Z{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            current_row += 1
                        Else
                            reportfixedasset(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "account_name"
                        xlWorkSheet.Cells(current_row, 1).Value = "ACCOUNT: " & dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim first_row As Integer = current_row
                        reportfixedasset(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 15) = String.Format("=SUBTOTAL(9,O{0}:O{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 16) = String.Format("=SUBTOTAL(9,P{0}:P{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 17) = String.Format("=SUBTOTAL(9,Q{0}:Q{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 18) = String.Format("=SUBTOTAL(9,R{0}:R{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 19) = String.Format("=SUBTOTAL(9,S{0}:S{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 20) = String.Format("=SUBTOTAL(9,T{0}:T{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 21) = String.Format("=SUBTOTAL(9,U{0}:U{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 22) = String.Format("=SUBTOTAL(9,V{0}:V{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 23) = String.Format("=SUBTOTAL(9,W{0}:W{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 24) = String.Format("=SUBTOTAL(9,X{0}:X{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 25) = String.Format("=SUBTOTAL(9,Y{0}:Y{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 26) = String.Format("=SUBTOTAL(9,Z{0}:Z{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDash
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        current_row += 1
                End Select
            Else
                If field = "currency_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "CURRENCY: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    current_row += 1
                ElseIf field = "account_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "ACCOUNT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                    current_row += 1
                ElseIf field = "project_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
                    current_row += 1
                ElseIf field = "department_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                    current_row += 1
                End If

                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("quantity")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("asset_code")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("description")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("date_acquired")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("date_start")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("reference")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("useful_life")
                    xlWorkSheet.Cells(current_row, 8) = dic.Item("amount")
                    xlWorkSheet.Cells(current_row, 9) = dic.Item("monthly_depreciation")
                    xlWorkSheet.Cells(current_row, 10) = dic.Item("beg_acc_depreciation")
                    xlWorkSheet.Cells(current_row, 11) = dic.Item("beg_net_book_value")
                    xlWorkSheet.Cells(current_row, 12) = dic.Item("January")
                    xlWorkSheet.Cells(current_row, 13) = dic.Item("February")
                    xlWorkSheet.Cells(current_row, 14) = dic.Item("March")
                    xlWorkSheet.Cells(current_row, 15) = dic.Item("April")
                    xlWorkSheet.Cells(current_row, 16) = dic.Item("May")
                    xlWorkSheet.Cells(current_row, 17) = dic.Item("June")
                    xlWorkSheet.Cells(current_row, 18) = dic.Item("July")
                    xlWorkSheet.Cells(current_row, 19) = dic.Item("August")
                    xlWorkSheet.Cells(current_row, 20) = dic.Item("September")
                    xlWorkSheet.Cells(current_row, 21) = dic.Item("October")
                    xlWorkSheet.Cells(current_row, 22) = dic.Item("November")
                    xlWorkSheet.Cells(current_row, 23) = dic.Item("December")
                    xlWorkSheet.Cells(current_row, 24) = dic.Item("total_depreciation")
                    xlWorkSheet.Cells(current_row, 25) = dic.Item("end_accumulated_depreciation")
                    xlWorkSheet.Cells(current_row, 26) = dic.Item("ending_book_value")
                    current_row += 1

                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 15) = String.Format("=SUBTOTAL(9,O{0}:O{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 16) = String.Format("=SUBTOTAL(9,P{0}:P{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 17) = String.Format("=SUBTOTAL(9,Q{0}:Q{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 18) = String.Format("=SUBTOTAL(9,R{0}:R{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 19) = String.Format("=SUBTOTAL(9,S{0}:S{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 20) = String.Format("=SUBTOTAL(9,T{0}:T{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 21) = String.Format("=SUBTOTAL(9,U{0}:U{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 22) = String.Format("=SUBTOTAL(9,V{0}:V{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 23) = String.Format("=SUBTOTAL(9,W{0}:W{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 24) = String.Format("=SUBTOTAL(9,X{0}:X{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 25) = String.Format("=SUBTOTAL(9,Y{0}:Y{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 26) = String.Format("=SUBTOTAL(9,Z{0}:Z{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDash
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 26)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                current_row += 1
            End If
        Next
    End Sub
    Private Sub excelfixedasset2(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByVal templateName As String, ByVal reportTitle As String, ByVal companyCurrency As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(3, 1) = reportTitle
        xlWorkSheet.Cells(4, 1) = dicHeader.Item("reportDateRange")
        xlWorkSheet.Cells(5, 9) = "Acc. Cost " & companyCurrency
        xlWorkSheet.Cells(5, 11) = "Net Book Value " & companyCurrency
        xlWorkSheet.Cells(5, 13) = "Monthly Dep'n " & companyCurrency

        Dim first_row As Integer = 6
        Dim current_row As Integer = 6
        Dim current_index As Integer = 0
        reportfixedasset2(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub reportfixedasset2(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer)
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
                    Case "currency_name"
                        If rdo_currency_2.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "CURRENCY: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset2(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                            current_row += 1
                        Else
                            reportfixedasset2(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "project_name"
                        If withProjectDepartment.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "PROJECT: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset2(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            current_row += 1
                        Else
                            reportfixedasset2(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "department_name"
                        If withProjectDepartment.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset2(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            current_row += 1
                        Else
                            reportfixedasset2(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "account_name"
                        xlWorkSheet.Cells(current_row, 1).Value = "ACCOUNT: " & dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim first_row As Integer = current_row
                        reportfixedasset2(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDash
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        current_row += 1
                End Select
            Else
                If field = "currency_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "CURRENCY: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    current_row += 1
                ElseIf field = "account_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "ACCOUNT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                    current_row += 1
                ElseIf field = "project_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
                    current_row += 1
                ElseIf field = "department_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                    current_row += 1
                End If

                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("asset_code")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("description")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("date_acquired")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("date_start")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("reference")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("useful_life")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("exchange_rate")
                    xlWorkSheet.Cells(current_row, 8) = dic.Item("amount")
                    xlWorkSheet.Cells(current_row, 9) = dic.Item("amount_based")
                    xlWorkSheet.Cells(current_row, 10) = dic.Item("beg_net_book_value")
                    xlWorkSheet.Cells(current_row, 11) = dic.Item("beg_net_book_value_based")
                    xlWorkSheet.Cells(current_row, 12) = dic.Item("monthly_depreciation")
                    xlWorkSheet.Cells(current_row, 13) = dic.Item("monthly_depreciation_based")
                    current_row += 1

                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDash
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                current_row += 1
            End If
        Next
    End Sub
    Private Sub excelfixedasset3(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByVal templateName As String, ByVal reportTitle As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(3, 1) = reportTitle
        xlWorkSheet.Cells(4, 1) = dicHeader.Item("reportDateRange")
        xlWorkSheet.Cells(5, 9) = "Net Book Value Of " & dicHeader.Item("asOf")
        xlWorkSheet.Cells(5, 10) = "Monthly Dep'n Of " & dicHeader.Item("asOf")

        Dim first_row As Integer = 6
        Dim current_row As Integer = 6
        Dim current_index As Integer = 0
        reportfixedasset3(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub reportfixedasset3(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer)
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
                    Case "currency_name"
                        If rdo_currency_2.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "CURRENCY: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset3(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                            current_row += 1
                        Else
                            reportfixedasset3(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "project_name"
                        If withProjectDepartment.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "PROJECT: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset3(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            current_row += 1
                        Else
                            reportfixedasset3(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "department_name"
                        If withProjectDepartment.Checked = True Then
                            xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                            xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                            current_row += 1
                            Dim first_row As Integer = current_row
                            reportfixedasset3(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_index -= 1
                            xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                            xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            current_row += 1
                        Else
                            reportfixedasset3(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                            current_row += 1
                        End If
                    Case "account_name"
                        xlWorkSheet.Cells(current_row, 1).Value = "ACCOUNT: " & dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim first_row As Integer = current_row
                        reportfixedasset3(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDash
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        current_row += 1
                End Select
            Else
                If field = "currency_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "CURRENCY: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    current_row += 1
                ElseIf field = "account_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "ACCOUNT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                    current_row += 1
                ElseIf field = "project_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
                    current_row += 1
                ElseIf field = "department_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "DEPARTMENT: " & dicItem(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                    current_row += 1
                End If

                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("asset_code")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("description")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("date_acquired")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("date_start")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("reference")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("useful_life")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("exchange_rate")
                    xlWorkSheet.Cells(current_row, 8) = dic.Item("amount")
                    xlWorkSheet.Cells(current_row, 9) = dic.Item("beg_net_book_value")
                    xlWorkSheet.Cells(current_row, 10) = dic.Item("monthly_depreciation")
                    current_row += 1

                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDash
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                current_row += 1
            End If
        Next
    End Sub
    Private Sub setDataSet(ByVal dt_balance As DataTable, ByVal month_from As Integer, ByVal month_to As Integer, ByVal date_from As Date, ByVal year_from As Integer, ByVal year_to As Integer)
        Dim asOfDate As Date = date_from.AddDays(-1)
        Dim asOfMonth As Integer = 0
        For Each row As DataRow In dt_balance.Rows
            If ifNull(row.Item("date_start"), "").ToString <> "" Then
                Dim month As Integer = CType(CType(row.Item("date_start"), Date).Month, Integer)
                asOfMonth = DateDiff(DateInterval.Month, row.Item("date_start"), asOfDate)
                row.Item("beg_acc_depreciation") = 0
                row.Item("beg_acc_depreciation_based") = 0
                row.Item("beg_net_book_value") = 0
                row.Item("beg_net_book_value_based") = 0
                row.Item("total_depreciation") = 0
                row.Item("total_depreciation_based") = 0
                row.Item("end_accumulated_depreciation") = 0
                row.Item("end_accumulated_depreciation_based") = 0
                row.Item("ending_book_value") = 0
                row.Item("ending_book_value_based") = 0
                If asOfMonth > 0 Then
                    row.Item("beg_acc_depreciation") = asOfMonth * ifNull(row.Item("monthly_depreciation"), 0)
                    row.Item("beg_acc_depreciation_based") = asOfMonth * ifNull(row.Item("monthly_depreciation_based"), 0)
                End If
                row.Item("beg_net_book_value") = row.Item("amount") - row.Item("beg_acc_depreciation")
                row.Item("beg_net_book_value_based") = row.Item("amount_based") - row.Item("beg_acc_depreciation_based")
                If month_from >= month_to Then
                    If year_to >= year_from Then
                        For i As Integer = month_from To 12
                            row.Item("total_depreciation") += ifNull(row.Item("monthly_depreciation"), 0)
                            row.Item("total_depreciation_based") += ifNull(row.Item("monthly_depreciation_based"), 0)
                            If i >= month Then
                                row.Item(MonthName(i)) = row.Item("monthly_depreciation")
                                row.Item(MonthName(i) & "_based") = row.Item("monthly_depreciation_based")
                            End If
                        Next
                        For i As Integer = 1 To month_from
                            row.Item("total_depreciation") += ifNull(row.Item("monthly_depreciation"), 0)
                            row.Item("total_depreciation_based") += ifNull(row.Item("monthly_depreciation_based"), 0)
                            If i >= month Then
                                row.Item(MonthName(i)) = row.Item("monthly_depreciation")
                                row.Item(MonthName(i) & "_based") = row.Item("monthly_depreciation_based")
                            End If
                        Next
                    End If
                Else
                    For i As Integer = month_from To month_to
                        row.Item("total_depreciation") += ifNull(row.Item("monthly_depreciation"), 0)
                        row.Item("total_depreciation_based") += ifNull(row.Item("monthly_depreciation_based"), 0)
                        If i >= month Then
                            row.Item(MonthName(i)) = row.Item("monthly_depreciation")
                            row.Item(MonthName(i) & "_based") = row.Item("monthly_depreciation_based")
                        End If
                    Next
                End If
                row.Item("total_depreciation") = ifNull(row.Item("January"), 0) + ifNull(row.Item("February"), 0) + ifNull(row.Item("March"), 0) + ifNull(row.Item("April"), 0) + ifNull(row.Item("May"), 0) + ifNull(row.Item("June"), 0) + ifNull(row.Item("July"), 0) + ifNull(row.Item("August"), 0) + ifNull(row.Item("September"), 0) + ifNull(row.Item("October"), 0) + ifNull(row.Item("November"), 0) + ifNull(row.Item("December"), 0)
                row.Item("total_depreciation_based") = ifNull(row.Item("January_based"), 0) + ifNull(row.Item("February_based"), 0) + ifNull(row.Item("March_based"), 0) + ifNull(row.Item("April_based"), 0) + ifNull(row.Item("May_based"), 0) + ifNull(row.Item("June_based"), 0) + ifNull(row.Item("July_based"), 0) + ifNull(row.Item("August_based"), 0) + ifNull(row.Item("September_based"), 0) + ifNull(row.Item("October_based"), 0) + ifNull(row.Item("November_based"), 0) + ifNull(row.Item("December_based"), 0)
                row.Item("end_accumulated_depreciation") = row.Item("beg_acc_depreciation") + row.Item("total_depreciation")
                row.Item("end_accumulated_depreciation_based") = row.Item("beg_acc_depreciation_based") + row.Item("total_depreciation_based")
                row.Item("ending_book_value") = row.Item("amount") - row.Item("end_accumulated_depreciation")
                row.Item("ending_book_value_based") = row.Item("amount_based") - row.Item("end_accumulated_depreciation_based")
            End If
        Next
    End Sub
    Private Sub fixedassetreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_month_from.Value = 1
        txt_month_to.Value = 12
        txt_year_from.Value = Today.ToString("yyyy")
        txt_year_to.Value = Today.ToString("yyyy")
        txt_day_from.Value = 1
        txt_day_to.Value = 31
    End Sub
    Private Sub toDate_CheckedChanged(sender As Object, e As EventArgs) Handles toDate.CheckedChanged
        If toDate.Checked Then
            txt_month_from.Enabled = False
            txt_day_from.Enabled = False
            txt_year_from.Enabled = False
        Else
            txt_month_from.Enabled = True
            txt_day_from.Enabled = True
            txt_year_from.Enabled = True
        End If
    End Sub
    Private Sub account_filter_CheckChange(sender As Object, e As EventArgs) Handles rdo_account_1.CheckedChanged, rdo_account_3.CheckedChanged, rdo_account_2.CheckedChanged
        Dim account As String = getRdoValue(account_filter)
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
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        Dim datefrom As Date = New Date(txt_year_from.Value, txt_month_from.Value, txt_day_from.Value)
        Dim dateto As Date = New Date(txt_year_to.Value, txt_month_to.Value, txt_day_to.Value)
        If dateto < datefrom Then
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
End Class