Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class usermanagement
    Dim dbTable As String = "sys_erp_user"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00903"
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Private MyDT As DataTable = Nothing

    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = String.Format("SELECT a.*,b.profile_name,c.department_name,'' AS retype_password " & _
                                "FROM {0}.sys_erp_user a " & _
                                "LEFT JOIN {0}.sys_erp_profile b ON b.profile_id = a.profile_id " & _
                                "LEFT JOIN {0}.lib_erp_department c ON c.department_id = a.department_id " & _
                                "ORDER BY a.username,a.user_fullname ASC " & _
                                "", _serverDBFS)
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        MyDT = ds.Tables(dbTable).Clone
        MyDT.Clear()
        MyDT.Columns.Remove("profile_id")
        'MyDT.Columns.Remove("profile_code")
        MyDT.Columns.Remove("profile_name")
        For Each row As DataRow In dt.Rows
            row.Item("password") = row.Item("password").ToString()
            row.Item("retype_password") = row.Item("password")
            ds.Tables(dbTable).ImportRow(row)
            MyDT.ImportRow(row)
        Next
        dgMain.DataSource = MyDT
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgMain.SelectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As Integer = 0
        Dim addsave As Boolean = False

        If txt_password.Text <> txt_retype_password.Text Then
            MsgBox("Password Mismatch.")
            Exit Sub
        End If
        Dim dicUser As New Dictionary(Of String, String)
        dicUser.Add("user_id", txt_user_id.Text)
        dicUser.Add("username", txt_username.Text)
        dicUser.Add("user_fullname", txt_user_fullname.Text)
        dicUser.Add("user_position", txt_user_position.Text)
        dicUser.Add("password", crypt(txt_password.Text))
        dicUser.Add("email", txt_email.Text)
        dicUser.Add("department_id", ifNull(txt_department_id.Value, "").ToString())
        dicUser.Add("checker", If(txt_checker.Checked, "1", "0"))
        dicUser.Add("approver", If(txt_approver.Checked, "1", "0"))
        Dim dicProfile As New Dictionary(Of String, String)
        dicProfile.Add("user_profile_id", txt_user_profile_id.Text)
        dicProfile.Add("user_id", txt_user_id.Text)
        dicProfile.Add("profile_id", ifNull(txt_profile_id.Value, "").ToString())
        dicProfile.Add("system_id", "2")
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            If transmode = "insert" Then
                If DataExist(dgMain, {"user_id", txt_user_id.Value}, {"username", "user_fullname"}, {txt_username.Text, txt_user_fullname.Text}) Then
                    MsgBox("User already exist")
                    err = True
                Else
                    Dim id As DataTable = FsQuery(ATGenerateQuery("Insert", dbTable, dicUser, Environment.MachineName, Environment.UserName, main.log_id, txt_user_id.Value, "user_id"))
                    'Dim id As DataTable = FsQuery(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                    pk = id.Rows(0).Item("return_id")
                    dicProfile.Item("user_id") = pk
                    addsave = True
                End If
            Else
                If DataExist(dgMain, {"user_id", txt_user_id.Value}, {"username", "user_fullname"}, {txt_username.Text, txt_user_fullname.Text}, False) Then
                    MsgBox("User already exist")
                    err = True
                Else
                    dicUser.Remove("password")
                    FsQuery(ATGenerateQuery("Update", dbTable, dicUser, Environment.MachineName, Environment.UserName, main.log_id, txt_user_id.Value, "user_id"))
                    'FsQuery(genUpdate(dbTable, dic))
                    pk = txt_user_id.Value
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            End If
            If Not err Then
                If dicProfile.Item("user_profile_id").ToString() <> "" And Not dicProfile.Item("user_profile_id").Contains("tmp_") Then
                    FsQuery(ATGenerateQuery("Update", "sys_erp_user_profile", dicProfile, Environment.MachineName, Environment.UserName, main.log_id, txt_user_profile_id.Value, "user_profile_id"))
                Else
                    FsQuery(ATGenerateQuery("Insert", "sys_erp_user_profile", dicProfile, Environment.MachineName, Environment.UserName, main.log_id, txt_user_profile_id.Value, "user_profile_id"))
                End If
                transmode = ""
                disable_control(Me, main.dicAction.Item(module_code))
                btnInsert.Focus()
                init_load()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("user_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addsave Then
                    saveAddAnother(btnInsert, "Add New User?")
                End If
            End If
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        transmode = ""
        Dim selectedRow = dgMain.SelectedRows
        selectedRow(0).Cells(0).Selected = False
        selectedRow(0).Cells(0).Selected = True
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
    End Sub

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "user_id", dt, Me)
        txt_user_id_TextChange(Nothing, Nothing)
    End Sub

    Private Sub cboxAllHeader_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAllHeader.CheckedChanged
        For Each row As DataGridViewRow In dgMain.Rows
            row.Cells("sel").Value = cboxAllHeader.Checked
        Next
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim pk As String = "user_id"
        Dim colName As String = "user_fullname"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "sys_erp_user"
        Dim pk_delete As String = "user_id"

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
            'MsgBox(str)
            FsQuery(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "user_id"))
            init_load()
        End If
    End Sub

    Private Sub txt_profile_id_Leave(sender As Object, e As EventArgs) Handles txt_profile_id.Leave

        Dim dt As DataTable = FsQuery("select * from sys_erp_profile")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("profile_name like '{0}'", txt_profile_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "profile_code,profile_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_profile_id.RowData = dr
                txt_profile_id.Value = dr("profile_id")
                txt_profile_id.Text = dr("profile_name")
            End If
        End If

    End Sub

    Private Sub txt_department_id_Leave(sender As Object, e As EventArgs) Handles txt_department_id.Leave

        Dim dt As DataTable = FsQuery("select * from lib_erp_department")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("department_name like '{0}'", txt_department_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
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
                txt_department_id.Text = dr("department_name")
            End If
        End If

    End Sub
    Private Sub TransactionFormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If transmode <> "" Then
            Dim confirm = MsgBox("There are transactions that are not yet done. Are you sure to exit the form?", MsgBoxStyle.YesNo, "Transaction Undone.")
            If confirm = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles txtsearch.TextChange
        Dim q As String = txtsearch.Text
        If txtsearch.TextSource <> "" Then
            Dim cols = txtsearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            'Dim dt As DataTable = dgMain.DataSource
            Dim selectedRows = MyDT.[Select](selectQuery.Substring(4), txtsearch.TextSource & " ASC")
            If selectedRows.Length > 0 Then
                'If currentSearchIndex >= selectedRows.Length Then
                '    currentSearchIndex = 0
                'End If
                'Dim selectedID As String = selectedRows(currentSearchIndex).Item("user_id").ToString
                'dgMain.ClearSelection()
                'For Each row As DataGridViewRow In dgMain.Rows
                '    If row.Cells("user_id").Value.ToString = selectedID Then
                '        row.Selected = True
                '        Dim tmp_index = dt.Rows.IndexOf(selectedRows(currentSearchIndex))
                '        dgMain.FirstDisplayedScrollingRowIndex = tmp_index
                '    End If
                'Next
                Dim newDT = MyDT.Clone
                newDT.Clear()
                For Each dr As DataRow In selectedRows
                    newDT.ImportRow(dr)
                Next
                dgMain.DataSource = newDT
            Else
                dgMain.DataSource = MyDT
            End If
        Else
            dgMain.DataSource = MyDT
        End If
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnInsert)
        dicShortCut.Add(114, btnUpdate)
        dicShortCut.Add(115, btnRemove)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnSignatory_Click(sender As Object, e As EventArgs) Handles btnSignatory.Click
        usersignatories.UserID = txt_user_id.Text
        usersignatories.ShowDialog()
    End Sub

    Private Sub txt_user_id_TextChange(sender As Object, e As EventArgs) Handles txt_user_id.TextChange
        Dim id As String = ifNull(txt_user_id.Text, "").ToString()
        Dim sql As String = String.Format("SELECT a.user_profile_id,a.user_id,a.system_id,a.profile_id
            ,b.profile_code,b.profile_name
            FROM sys_erp_user_profile a
            LEFT JOIN sys_erp_profile b ON b.profile_id = a.profile_id
            WHERE system_id = '{0}' AND user_id = '{1}'", "2", id)
        Dim dt As DataTable = FsQuery(sql)
        txt_user_profile_id.Text = ""
        txt_profile_id.Text = ""
        txt_profile_id.Value = ""
        txt_profile_id.RowData = Nothing
        If dt.Rows.Count > 0 Then
            txt_user_profile_id.Text = dt.Rows(0).Item("user_profile_id").ToString
            txt_profile_id.Text = dt.Rows(0).Item("profile_name").ToString
            txt_profile_id.Value = dt.Rows(0).Item("profile_id").ToString
        End If
    End Sub
End Class