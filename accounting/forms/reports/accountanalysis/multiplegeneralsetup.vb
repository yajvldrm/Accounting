Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class multiplegeneralsetup
    Dim dbTable As String = "lib_acc_general_multiple"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Public Property ModuleCode As String = ""
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = String.Format("SELECT a.general_multiple_id,a.general_id,a.user_id,b.general_code,b.general_name,c.module_code,c.module_name " & _
            "FROM lib_acc_general_multiple a " & _
            "LEFT JOIN lib_erp_general b ON b.general_id = a.general_id " & _
            "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " & _
            "WHERE a.user_id = '{0}' AND c.module_code = '{1}' ", main.user_id, ModuleCode)
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
            dic.Remove("general_code")
            dic.Remove("general_name")
            If transmode = "insert" Then
                If DataExist(dgMain, {"general_multiple_id", txt_general_multiple_id.Value}, {"general_id"}, {txt_general_id.Value}) Then
                    MsgBox("General Library already exist")
                    err = True
                Else
                    If dic.ContainsKey("sel") Then
                        dic.Remove("sel")
                    End If
                    'Dim sql = genInsert(dbTable, dic)
                    Dim sql = ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_general_multiple_id.Value, "general_multiple_id")
                    Dim id As DataTable = FsQuery(sql)
                    pk = id.Rows(0).Item("return_id")
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "update" Then
                dic.Remove("sel")
                If DataExist(dgMain, {"general_multiple_id", txt_general_multiple_id.Value}, {"general_id"}, {txt_general_id.Value}, False) Then
                    MsgBox("General already exist")
                    err = True
                Else
                    'FsQuery(genUpdate(dbTable, dic))
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_general_multiple_id.Value, "general_multiple_id"))
                    pk = txt_general_multiple_id.Value
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
                    If row.Cells("general_multiple_id").Value.ToString = pk Then
                        row.Selected = True
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)
        txt_general_id.Text = ""
        txt_general_name.Text = ""
        transmode = ""
    End Sub
    Private Sub General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        txt_general_id.Text = ""
        txt_general_name.Text = ""
        disable_control(Me)
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "general_multiple_id", dt, Me)
    End Sub
    Private Sub cboxAllHeader_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAllHeader.CheckedChanged
        For Each row As DataGridViewRow In dgMain.Rows
            row.Cells("sel").Value = cboxAllHeader.Checked
        Next
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim pk As String = "general_multiple_id"
        Dim colName As String = "general_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_acc_general_multiple"
        Dim pk_delete As String = "general_multiple_id"

        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""

        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg)
        If arr_id.Length > 0 Then
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
                ids &= arr_id(i).ToString & "|"
            Next
            'Query(str)
            FsQuery(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "general_multiple_id"))
            init_load()
            txt_general_id.Text = ""
            txt_general_name.Text = ""
        End If
    End Sub
    Private Sub txt_general_code_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
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
                txt_general_name.Text = dr("general_name")
            End If
        End If
    End Sub
End Class