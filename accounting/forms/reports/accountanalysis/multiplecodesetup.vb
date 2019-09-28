Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class multiplecodesetup
    Dim dbTable As String = "lib_acc_chart_multiple"
    Dim ds As New FileSetupSet
    Dim _validation As String = "All"
    Private transmode As String = ""
    Public Property ModuleCode As String = ""

    Public Property validation() As String
        Get
            Return _validation
        End Get
        Set(ByVal value As String)
            _validation = value
        End Set
    End Property
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = "SELECT a.account_multiple_id,a.account_id,a.user_id,a.module_id " &
            ",b.account_code,b.account_name " &
            ",c.module_code,c.module_name " &
            "FROM lib_acc_chart_multiple a " &
            "LEFT JOIN lib_erp_chart b ON b.account_id = a.account_id " &
            "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " &
            ""
        If validation <> "All" Then
            sql &= String.Format(" WHERE b.validation = {0} AND a.user_id = '{1}' AND c.module_code = '{2}' ", validation, main.user_id, ModuleCode)
        Else
            sql &= String.Format(" WHERE a.user_id = '{0}' AND c.module_code = '{1}' ", main.user_id, ModuleCode)
        End If
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
        Next
        dgMain.DataSource = ds.Tables(dbTable)
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        transmode = "update"
        enable_control(Me)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As Integer = 0

        Dim dic = generateDictionary(Me, dt)
        If dic.ContainsKey("user_id") Then
            dic.Item("user_id") = main.user_id
        Else
            dic.Add("user_id", main.user_id)
        End If
        Dim module_id As String = ""
        Dim sql_module As String = String.Format("SELECT module_id FROM sys_erp_modules WHERE module_code = '{0}'", ModuleCode)
        Dim dt_module As DataTable = FsQuery(sql_module)
        If dt_module.Rows.Count > 0 Then
            module_id = dt_module.Rows(0).Item("module_id").ToString
        End If
        If dic.ContainsKey("module_id") Then
            dic.Item("module_id") = module_id
        Else
            dic.Add("module_id", module_id)
        End If
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            dic.Remove("account_code")
            dic.Remove("account_name")
            If transmode = "insert" Then
                If DataExist(dgMain, {"account_multiple_id", txt_account_multiple_id.Value}, {"account_id"}, {txt_account_id.Value}) Then
                    MsgBox("Account already exist")
                    err = True
                Else
                    If dic.ContainsKey("sel") Then
                        dic.Remove("sel")
                    End If
                    'Dim sql = genInsert(dbTable, dic)
                    Dim sql = ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_account_multiple_id.Value, "account_multiple_id")
                    Dim id As DataTable = FsQuery(sql)
                    pk = id.Rows(0).Item("return_id")
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "update" Then
                dic.Remove("sel")
                If DataExist(dgMain, {"account_multiple_id", txt_account_multiple_id.Value}, {"account_id"}, {txt_account_id.Value}, False) Then
                    MsgBox("Account already exist")
                    err = True
                Else
                    'FsQuery(genUpdate(dbTable, dic))
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_account_multiple_id.Value, "account_multiple_id"))
                    pk = txt_account_multiple_id.Value
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "remove" Then
            End If
            If Not err Then
                transmode = ""
                disable_control(Me)
                btnInsert.Focus()
                init_load()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("account_multiple_id").Value.ToString = pk Then
                        row.Selected = True
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)
        txt_account_id.Text = ""
        txt_account_name.Text = ""
        transmode = ""
    End Sub
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        txt_account_id.Text = ""
        txt_account_name.Text = ""
        disable_control(Me)
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "account_multiple_id", dt, Me)
    End Sub
    Private Sub cboxAllHeader_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAllHeader.CheckedChanged
        For Each row As DataGridViewRow In dgMain.Rows
            row.Cells("sel").Value = cboxAllHeader.Checked
        Next
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim pk As String = "account_multiple_id"
        Dim colName As String = "account_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete the selected record(s)?"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_acc_chart_multiple"
        Dim pk_delete As String = "account_multiple_id"

        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""

        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg, True, "Select Record First", False)
        If arr_id.Length > 0 Then
            'For i As Integer = 0 To arr_id.Length - 1
            '    str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            'Next
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                'ids &= "," & arr_id(i)
                ids &= arr_id(i).ToString & "|"
            Next
            'str = String.Format("DELETE FROM {0}.{1} WHERE {2} IN ({3});", db_delete, tbl_delete, pk_delete, ids.Substring(1))
            'Query(str)
            FsQuery(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "account_multiple_id"))
            init_load()
            txt_account_id.Text = ""
            txt_account_name.Text = ""
        End If
    End Sub
    Private Sub txt_account_code_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        Dim _sql As String = String.Format("SELECT * FROM lib_erp_chart ")
        If validation <> "All" Then
            _sql &= String.Format(" WHERE validation = {0} ", validation)
        End If
        Dim data As DataTable = FsQuery(_sql)
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
                txt_account_name.Text = dr("account_name")
            End If
        End If
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim chart_type As String = ""
        Dim chart_group_id As String = ""
        Dim withWhere As Boolean = False
        Me.Hide()
        importaccount.ShowDialog()
        If importaccount.DialogResult = Windows.Forms.DialogResult.OK Then
            With importaccount
                chart_type &= If(.WithAsset, ",'A'", "")
                chart_type &= If(.WithLiability, ",'L'", "")
                chart_type &= If(.WithCapital, ",'C'", "")
                chart_type &= If(.WithIncome, ",'I'", "")
                chart_type &= If(.WithExpense, ",'E'", "")
                If .WithGroup Then
                    chart_group_id = .GroupId
                End If
            End With
            Dim sql As String = String.Format("SELECT a.account_id FROM lib_erp_chart a ")
            If chart_type <> "" Then
                sql &= String.Format("LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id AND b.chart_type IN ({0}) ", chart_type.Substring(1))
            End If
            If chart_group_id <> "" Then
                sql &= String.Format("LEFT JOIN lib_erp_chart_group c ON c.account_id = a.account_id AND c.group_id = {0} ", chart_group_id)
            End If
            'sql &= String.Format("LEFT JOIN lib_acc_chart_multiple d ON d.account_id = a.account_id ")
            If validation <> "All" Then
                sql &= String.Format("WHERE a.validation = {0} ", validation)
                withWhere = True
            End If
            If chart_type <> "" Then
                If withWhere Then
                    sql &= "AND b.chart_class_id IS NOT NULL "
                Else
                    sql &= "WHERE b.chart_class_id IS NOT NULL "
                End If
                withWhere = True
            End If
            If chart_group_id <> "" Then
                If withWhere Then
                    sql &= "AND c.account_id IS NOT NULL "
                Else
                    sql &= "WHERE c.account_id IS NOT NULL "
                End If
                withWhere = True
            End If
            Dim module_id As String = ""
            Dim sql_module As String = String.Format("SELECT module_id FROM sys_erp_modules WHERE module_code = '{0}'", ModuleCode)
            Dim dt_module As DataTable = FsQuery(sql_module)
            If dt_module.Rows.Count > 0 Then
                module_id = dt_module.Rows(0).Item("module_id").ToString
            End If
            If withWhere Then
                'sql &= "AND d.account_id IS NULL "
                sql &= String.Format(" AND a.account_id NOT IN (SELECT account_id FROM lib_acc_chart_multiple WHERE user_id = '{0}' AND IFNULL(module_id,'') = '{1}')", main.user_id, module_id)
            Else
                'sql &= "WHERE d.account_id IS NULL "
                sql &= String.Format(" WHERE a.account_id NOT IN (SELECT account_id FROM lib_acc_chart_multiple WHERE user_id = '{0}' AND IFNULL(module_id,'') = '{1}')", main.user_id, module_id)
            End If
            If chart_type <> "" Or chart_group_id <> "" Then
                Dim sql_select As String = "SELECT account_id FROM lib_acc_chart_multiple"
                Dim sql_insert As String = "INSERT INTO lib_acc_chart_multiple(account_id,user_id,module_id) VALUES "
                Dim dt As DataTable = FsQuery(sql)
                Dim str As String = ""


                If dt.Rows.Count > 0 Then
                    For Each dr As DataRow In dt.Rows
                        str &= String.Format(",({0},{1},{2})", dr.Item("account_id"), main.user_id, module_id)
                    Next
                End If
                If str <> "" Then
                    sql_insert &= str.Substring(1) & ";"
                    FsQuery(sql_insert)
                End If
            End If
            init_load()
        End If
        Me.Show()
    End Sub

   
End Class