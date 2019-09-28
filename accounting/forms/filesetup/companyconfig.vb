Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms

Public Class companyconfig

    Dim ds As New sysdefaultset
    Dim default_id As Integer = 1
    Dim transmode As String = ""
    Private module_code As String = "ACC00908"
    Private Sub setValue(ByVal dr As DataRow, ByVal panel As Object)
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If ctr.ValueSource <> "" Then
                    If dr.Table.Columns.Contains(ctr.ValueSource) Then
                        ctr.Value = dr.Item(ctr.ValueSource).ToString
                    End If
                End If
                If ctr.TextSource <> "" Then
                    If dr.Table.Columns.Contains(ctr.TextSource) Then
                        ctr.Text = dr.Item(ctr.TextSource).ToString
                    End If
                End If
                If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                    If dr.Table.Columns.Contains(ctr.ValueSource) Then
                        ctr.DecimalValue = dr.Item(ctr.ValueSource).ToString
                    End If
                End If
            End If
            If TypeOf ctrl Is user_control.myMaskedTextBox Then
                Dim ctr = CType(ctrl, user_control.myMaskedTextBox)
                If ctr.ValueSource <> "" Then
                    If dr.Table.Columns.Contains(ctr.ValueSource) Then
                        ctr.Value = dr.Item(ctr.ValueSource)
                    End If
                End If
                If ctr.TextSource <> "" Then
                    If dr.Table.Columns.Contains(ctr.TextSource) Then
                        ctr.Text = dr.Item(ctr.TextSource)
                    End If
                End If
            End If
            If TypeOf ctrl Is DateTimePicker Then
                Dim ctr = CType(ctrl, DateTimePicker)
                If dr.Table.Columns.Contains(ctr.Name.ToString.Replace("txt_", "")) Then
                    ctr.Value = dr.Item(ctr.Name.ToString.Replace("txt_", ""))
                End If
            End If
            If TypeOf ctrl Is CheckBox Then
                Dim ctr = CType(ctrl, CheckBox)
                If dr.Table.Columns.Contains(ctr.Name) Then
                    ctr.Checked = dr.Item(ctr.Name)
                End If
            End If
            If TypeOf ctrl Is ComboBox Then
                Dim ctr As ComboBox = CType(ctrl, ComboBox)
                Dim name As String = ctr.Name.Replace("txt_", "")
                If dr.Table.Columns.Contains(name) Then
                    ctr.SelectedIndex = CInt(dr.Item(name)) - 1
                End If
            End If
            If TypeOf ctrl Is NumericUpDown Then
                Dim ctr As NumericUpDown = CType(ctrl, NumericUpDown)
                Dim name As String = ctr.Name.Replace("txt_", "")
                If dr.Table.Columns.Contains(name) Then
                    ctr.Value = CInt(dr.Item(name))
                End If
            End If
        Next
    End Sub

    Private Sub loadCompany()
        Dim sql_sys_config As String = String.Format("SELECT " &
        "a.default_id,a.used_in_report,a.sys_beg,a.company_id,a.w_proj,a.w_alloc,a.w_dept,a.line_remarks,a.line_currency,a.filter_id,a.monthly_currency,a.decimal_places,a.general_auto_number,a.retained_account_id,a.forex_account_id " &
        ",b.company_code,b.company_name,b.address1,b.address2,b.address3,b.address4,a.currency_id,b.tel_no,b.fax_no,b.email_add,b.tin,b.rdo_code " &
        ",c.filter_code,c.filter_name " &
        ",d.currency_code,d.currency_name " &
        ",e.account_code,e.account_name " &
        ",f.account_code AS forex_account_code,f.account_name AS forex_account_name " &
        ",a.isFiscal,a.fiscal_month,a.fiscal_year " &
        "FROM sys_default a " &
        "LEFT JOIN {1}.lib_erp_company b ON b.company_id = a.company_id " &
        "LEFT JOIN {1}.sys_acc_filter c ON c.filter_id = a.filter_id " &
        "LEFT JOIN {1}.lib_erp_currency d ON d.currency_id = a.currency_id " &
        "LEFT JOIN {1}.lib_erp_chart e ON e.account_id = a.retained_account_id " &
        "LEFT JOIN {1}.lib_erp_chart f ON f.account_id = a.forex_account_id " &
        "WHERE a.default_id = {0} ", default_id, _serverDBFS)

        Dim dt_sys_config As DataTable = Query(sql_sys_config)
        ds.Clear()

        For Each row As DataRow In dt_sys_config.Rows
            ds.Tables("sys_default").ImportRow(row)
        Next

        setValue(ds.Tables("sys_default").Rows(0), gboxContainer)

    End Sub

    Private Function toDictionary(ByVal panel As Object) As Dictionary(Of String, String)
        Dim dic As New Dictionary(Of String, String)

        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If ctr.ValueSource <> "" Then
                    If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                        dic.Add(ctr.ValueSource, ctr.DecimalValue)
                    Else
                        If ctr.Value = "" Then
                            dic.Add(ctr.ValueSource, Nothing)
                        Else
                            dic.Add(ctr.ValueSource, ctr.Value)
                        End If
                    End If
                ElseIf ctr.TextSource <> "" Then
                    If ctr.Text = "" Then
                        dic.Add(ctr.TextSource, Nothing)
                    Else
                        dic.Add(ctr.TextSource, ctr.Text)
                    End If
                End If
            End If
            If TypeOf ctrl Is user_control.myMaskedTextBox Then
                Dim ctr = CType(ctrl, user_control.myMaskedTextBox)
                If ctr.ValueSource <> "" Then
                    If dic.ContainsKey(ctr.ValueSource) Then
                        dic.Item(ctr.ValueSource) = ctr.Value
                    Else
                        dic.Add(ctr.ValueSource, ctr.Value)
                    End If
                End If
                If ctr.TextSource <> "" Then
                    If dic.ContainsKey(ctr.TextSource) Then
                        dic.Item(ctr.TextSource) = ctr.Text
                    Else
                        dic.Add(ctr.TextSource, ctr.Text)
                    End If
                End If
            End If
            If TypeOf ctrl Is DateTimePicker Then
                Dim ctr = CType(ctrl, DateTimePicker)
                dic.Add(ctr.Name.ToString.Replace("txt_", ""), ctr.Value.ToString("yyyy-MM-dd"))
            End If
            If TypeOf ctrl Is CheckBox Then
                Dim ctr = CType(ctrl, CheckBox)
                dic.Add(ctr.Name, If(ctr.Checked, 1, 0))
            End If
            If TypeOf ctrl Is ComboBox Then
                Dim ctr As ComboBox = CType(ctrl, ComboBox)
                Dim name As String = ctr.Name.ToString.Replace("txt_", "")
                dic.Add(name, ctr.SelectedIndex + 1)
            End If
            If TypeOf ctrl Is NumericUpDown Then
                Dim ctr As NumericUpDown = CType(ctrl, NumericUpDown)
                Dim name As String = ctr.Name.ToString.Replace("txt_", "")
                dic.Add(name, ctr.Value)
            End If
        Next
        Return dic
    End Function

    Private Sub companyconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCompany()
        disable_control(Me, main.dicAction.Item(module_code))
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        transmode = "update"
        enable_control(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim tin As String = txt_tin.Text.Replace("-", "")
        If tin = Nothing Then
            txt_tin.Text = "000-000-000-00000"
        End If

        Dim a = toDictionary(gboxContainer)
        Dim dic_sys_default As New Dictionary(Of String, String)
        Dim dic_company As New Dictionary(Of String, String)

        dic_sys_default.Add("default_id", a("default_id"))
        dic_sys_default.Add("used_in_report", a("used_in_report"))
        dic_sys_default.Add("sys_beg", a("sys_beg"))
        dic_sys_default.Add("company_id", a("company_id"))
        dic_sys_default.Add("w_proj", a("w_proj"))
        dic_sys_default.Add("w_alloc", a("w_alloc"))
        dic_sys_default.Add("w_dept", a("w_dept"))
        dic_sys_default.Add("general_auto_number", a("general_auto_number"))
        dic_sys_default.Add("line_remarks", a("line_remarks"))
        dic_sys_default.Add("line_currency", a("line_currency"))
        dic_sys_default.Add("filter_id", a("filter_id"))
        dic_sys_default.Add("monthly_currency", a("monthly_currency"))
        dic_sys_default.Add("decimal_places", a("decimal_places"))
        dic_sys_default.Add("retained_account_id", a("retained_account_id"))
        dic_sys_default.Add("forex_account_id", a("forex_account_id"))
        dic_sys_default.Add("currency_id", a("currency_id"))
        dic_sys_default.Add("isFiscal", a("isFiscal"))
        dic_sys_default.Add("fiscal_month", a("fiscal_month"))
        dic_sys_default.Add("fiscal_year", a("fiscal_year"))

        dic_company.Add("company_id", a("company_id"))
        dic_company.Add("company_code", a("company_code"))
        dic_company.Add("company_name", a("company_name"))
        dic_company.Add("address1", a("address1"))
        dic_company.Add("address2", a("address2"))
        dic_company.Add("address3", a("address3"))
        dic_company.Add("address4", a("address4"))
        dic_company.Add("tel_no", a("tel_no"))
        dic_company.Add("fax_no", a("fax_no"))
        dic_company.Add("email_add", a("email_add"))
        dic_company.Add("tin", a("tin"))
        dic_company.Add("rdo_code", a("rdo_code"))

        Dim sql_sys_default = ATGenerateQuery("Update", "sys_default", dic_sys_default, Environment.MachineName, Environment.UserName, main.log_id, a.Item("default_id"), "default_id")
        'Dim sql_sys_default = genUpdate("sys_default", dic_sys_default)
        'Dim sql_company = genUpdate("lib_erp_company", dic_company)
        Dim sql_company = ATGenerateQuery("Update", "lib_erp_company", dic_company, Environment.MachineName, Environment.UserName, main.log_id, a.Item("company_id"), "company_id")

        Query(sql_sys_default)
        FsQuery(sql_company)

        loadCompany()
        disable_control(Me, main.dicAction.Item(module_code))
        transmode = ""
        main.loadCompany()
    End Sub

    Private Sub txt_currency_code_Leave(sender As Object, e As EventArgs) Handles txt_currency_code.Leave
        Dim dt As DataTable = FsQuery("select * from lib_erp_currency")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("currency_code like '" & txt_currency_code.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "currency_code,currency_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_currency_code.RowData = dr
                txt_currency_code.Value = dr("currency_id")
                txt_currency_code.Text = dr("currency_code")
            End If
        End If
    End Sub

    Private Sub txt_filter_code_Leave(sender As Object, e As EventArgs) Handles txt_filter_code.Leave
        Dim dt As DataTable = FsQuery("select * from sys_acc_filter")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("filter_code like '" & txt_filter_code.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "filter_code,filter_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_filter_code.RowData = dr
                txt_filter_code.Value = dr("filter_id")
                txt_filter_code.Text = dr("filter_code")
            End If
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        transmode = ""
    End Sub
    Private Sub TransactionFormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If transmode <> "" Then
            Dim confirm = MsgBox("There are transactions that are not yet done. Are you sure to exit the form?", MsgBoxStyle.YesNo, "Transaction Undone.")
            If confirm = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(114, btnUpdate)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnAT_Click(sender As Object, e As EventArgs) Handles btnAT.Click
        showForm(ATFilter, main)
    End Sub

    Private Sub txt_retained_account_id_Leave(sender As Object, e As EventArgs) Handles txt_retained_account_id.Leave
        Dim dt As DataTable = FsQuery("select * from lib_erp_chart")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("account_code like '" & txt_retained_account_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "account_code,account_name", "100,300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_retained_account_id.RowData = dr
                txt_retained_account_id.Value = dr("account_id")
                txt_retained_account_id.Text = dr("account_code")
            End If
        End If
    End Sub

    Private Sub txt_forex_account_id_Leave(sender As Object, e As EventArgs) Handles txt_forex_account_id.Leave
        Dim dt As DataTable = FsQuery("SELECT a.account_id AS forex_account_id
            ,a.account_code AS forex_account_code,a.account_name AS forex_account_name
            FROM lib_erp_chart a
            WHERE a.validation = 10")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("forex_account_code like '" & txt_forex_account_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "forex_account_code,forex_account_name", "100,300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_forex_account_id.RowData = dr
                txt_forex_account_id.Value = dr("forex_account_id")
                txt_forex_account_id.Text = dr("forex_account_code")
            End If
        End If
    End Sub
End Class