Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class userprofile
    Dim dbTable As String = "sys_erp_profile"
    Dim ds As New FileSetupSet
    Dim dgSub As DataGridView = userprofiledetail.dgMain
    Dim tmp_dt As DataTable = Nothing
    Private transmode As String = ""
    Private module_code As String = "ACC00901"
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Private MyDT As DataTable = Nothing
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        dgSub.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM sys_erp_profile order by profile_code,profile_name ASC "
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        MyDT = ds.Tables(dbTable).Clone
        MyDT.Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
            MyDT.ImportRow(row)
        Next
        dgMain.DataSource = MyDT
        ds.Tables(dbTable).Select(Nothing, "profile_code")
        enableDetailControl(False)
    End Sub

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
        enableDetailControl(False)
        bind_form(Me)
    End Sub
    Private Sub enableDetailControl(Optional isEnable As Boolean = True)
        With userprofiledetail
            .dgMain.Enabled = isEnable
            .allAccess.Enabled = isEnable
            .allAdd.Enabled = isEnable
            .allEdit.Enabled = isEnable
            .allDelete.Enabled = isEnable
            .allCancel.Enabled = isEnable
            .allPrint.Enabled = isEnable
        End With
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim _sql As String = String.Format("SELECT module_id,module_code,module_name,module_type FROM {0}.sys_erp_modules WHERE system_id = 2", _serverDBFS)
        Dim _dt As DataTable = Query(_sql)

        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "profile_id", dt, Me)
        Dim sql As String = String.Format("SELECT a.profile_id,b.profile_det_id,c.module_id,c.module_code,c.module_name,c.module_type " & _
            ",b.m_view,b.m_add,b.m_edit,b.m_delete,b.m_cancel,b.m_print " & _
            "FROM {0}.sys_erp_profile a " & _
            "LEFT JOIN {0}.sys_erp_profile_det b ON b.profile_id = a.profile_id " & _
            "LEFT JOIN {0}.sys_erp_modules c ON c.module_id = b.module_id " & _
            "WHERE a.profile_id = {1} AND c.system_id = 2 " & _
            "", _serverDBFS, primary_key.Value)

        Dim dt_sub As DataTable = FsQuery(sql)
        If dt_sub.Rows.Count = 0 Then
            sql = String.Format("SELECT {1} AS profile_id,'' AS profile_det_id,a.module_id,a.module_code,a.module_name,a.module_type " & _
            "FROM {0}.sys_erp_modules a " & _
            "WHERE a.system_id = 2 " & _
            "", _serverDBFS, primary_key.Value)
            dt_sub = FsQuery(sql)
        End If
        ds_det.Tables("dt").Clear()
        For Each row As DataRow In dt_sub.Rows
            ds_det.Tables("dt").ImportRow(row)
        Next
        dgSub.AutoGenerateColumns = False
        dgSub.DataSource = ds_det.Tables("dt")
        tmp_dt = ds_det.Tables("dt")

        For Each row As DataRow In _dt.Rows
            Dim tmpdr As DataRow() = tmp_dt.Select(String.Format("module_id = '{0}'", row.Item("module_id")))
            If tmpdr.Count = 0 Then
                Dim newdr As DataRow = tmp_dt.NewRow
                For Each col As DataColumn In _dt.Columns
                    If tmp_dt.Columns.Contains(col.ColumnName) Then
                        newdr.Item(col.ColumnName) = row.Item(col.ColumnName)
                    End If
                Next
                tmp_dt.Rows.Add(newdr)
            End If
        Next

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)

        Dim sql As String = String.Format("SELECT NULL AS profile_id,'' AS profile_det_id,a.module_id,a.module_code,a.module_name,a.module_type " & _
            "FROM {0}.sys_erp_modules a " & _
            "WHERE a.system_id = 2 " & _
            "", _serverDBFS)
        Dim dt_sub As DataTable = FsQuery(sql)

        ds_det.Tables("dt").Clear()
        For Each row As DataRow In dt_sub.Rows
            ds_det.Tables("dt").ImportRow(row)
        Next
        dgSub.AutoGenerateColumns = False
        dgSub.DataSource = ds_det.Tables("dt")

        enableDetailControl()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgMain.SelectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
            enableDetailControl(True)
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As Integer = 0
        Dim addsave As Boolean = False

        Dim dic = generateDictionary(Me, dt)
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            dic.Remove("sel")
            If transmode = "insert" Then
                If DataExist(dgMain, {"profile_id", txt_profile_id.Value}, {"profile_code", "profile_name"}, {txt_profile_code.Text, txt_profile_name.Text}) Then
                    MsgBox("Profile already exist")
                    err = True
                Else
                    Dim id As DataTable = FsQuery(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_profile_id.Value, "profile_id"))
                    'Dim id As DataTable = FsQuery(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                    Dim det = dgProcess(dgSub, "sys_erp_profile_det", "profile_det_id", {"profile_id", id.Rows(0).Item("return_id")}, {"module_code", "module_name", "module_type"}, , , , , main.log_id)
                    If det <> "" Then
                        FsQuery(det)
                    End If
                    pk = id.Rows(0).Item("return_id")
                    addsave = True
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"profile_id", txt_profile_id.Value}, {"profile_code", "profile_name"}, {txt_profile_code.Text, txt_profile_name.Text}, False) Then
                    MsgBox("Profile already exist")
                    err = True
                Else
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_profile_id.Value, "profile_id"))
                    'FsQuery(genUpdate(dbTable, dic))
                    Dim det = dgProcess(dgSub, "sys_erp_profile_det", "profile_det_id", {"profile_id", primary_key.Value}, {"module_code", "module_name", "module_type"}, , , , , main.log_id)
                    If det <> "" Then
                        FsQuery(det)
                    End If
                    pk = primary_key.Value
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "remove" Then
            End If

            If Not err Then
                transmode = ""
                disable_control(Me, main.dicAction.Item(module_code))
                btnInsert.Focus()
                init_load()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("profile_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addsave Then
                    saveAddAnother(btnInsert, "Add New Profile?")
                End If
            End If
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        enableDetailControl(False)
        transmode = ""
        Dim selectedRow = dgMain.SelectedRows
        selectedRow(0).Cells(0).Selected = False
        selectedRow(0).Cells(0).Selected = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim pk As String = "profile_id"
        Dim colName As String = "profile_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "sys_erp_profile"
        Dim pk_delete As String = "profile_id"

        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""

        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg)
        Dim ids As String = ""
        For i As Integer = 0 To arr_id.Length - 1
            'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            ids &= arr_id(i).ToString & "|"
        Next
        'Query(str)
        FsQuery(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "profile_id"))
        init_load()
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        userprofiledetail.ShowDialog()
        dgSub.DataSource = tmp_dt
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
        Dim cols = txtsearch.TextSource.Split(",")
        Dim selectQuery As String = ""
        For Each col In cols
            selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
        Next
        Dim dt As DataTable = dgMain.DataSource
        Dim selectedRows = dt.[Select](selectQuery.Substring(4), txtsearch.TextSource & " ASC")
        If selectedRows.Length > 0 Then
            If currentSearchIndex >= selectedRows.Length Then
                currentSearchIndex = 0
            End If
            Dim selectedID As String = selectedRows(currentSearchIndex).Item("profile_id").ToString
            dgMain.ClearSelection()

            For Each row As DataGridViewRow In dgMain.Rows
                If row.Cells("profile_id").Value.ToString = selectedID Then
                    row.Selected = True
                    Dim tmp_index = dt.Rows.IndexOf(selectedRows(currentSearchIndex))
                    dgMain.FirstDisplayedScrollingRowIndex = tmp_index
                End If
            Next
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
        If searchFocus Then
            If e.KeyCode = Keys.Enter And e.Control Then
                currentSearchIndex += 1
                txtsearch_TextChange(Nothing, Nothing)
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub txtsearch_Enter(sender As Object, e As EventArgs) Handles txtsearch.Enter
        searchFocus = True
    End Sub

    Private Sub txtsearch_Leave(sender As Object, e As EventArgs) Handles txtsearch.Leave
        searchFocus = False
    End Sub
End Class