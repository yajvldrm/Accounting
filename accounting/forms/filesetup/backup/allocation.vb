Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class allocation
    Dim dbTable As String = "lib_erp_allocation"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00801"

    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        dgSub.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM lib_erp_allocation ORDER BY allocation_code"
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
        Next
        dgMain.DataSource = ds.Tables(dbTable)
        disable_allsubcontrol(dgSub)
    End Sub

    Private Sub TransactionFormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If transmode <> "" Then
            Dim confirm = MsgBox("There are transactions that are not yet done. Are you sure to exit the form?", MsgBoxStyle.YesNo, "Transaction Undone.")
            If confirm = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub allocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
        'disable_subcontrol(dgSub, "")
        bind_form(Me)
    End Sub

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "allocation_id", dt, Me)
        Dim dt_sub As DataTable = FsQuery(String.Format("SELECT a.allocation_account_id,a.allocation_id,a.account_id,b.account_code,b.account_name FROM lib_erp_allocation_account a LEFT JOIN lib_erp_chart b ON b.account_id = a.account_id WHERE a.allocation_id = {0}", primary_key.Value))
        ds.Tables("lib_erp_allocation_account").Clear()
        For Each row As DataRow In dt_sub.Rows
            ds.Tables("lib_erp_allocation_account").ImportRow(row)
        Next
        dgSub.DataSource = ds.Tables("lib_erp_allocation_account")
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        Dim ndt As DataTable = ds.Tables("lib_erp_allocation_account")
        ndt.Rows.Clear()
        dgSub.DataSource = ndt
        clear_subcontrol(dgSub)
        disable_subcontrol(dgSub)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
            disable_subcontrol(dgSub)
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As Integer = 0
        Dim addSave As Boolean = False
        Dim dic = generateDictionary(Me, dt)
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            dic.Remove("sel")
            If transmode = "insert" Then
                If DataExist(dgMain, {"allocation_id", txt_allocation_id.Value}, {"allocation_code", "allocation_name"}, {txt_allocation_code.Text, txt_allocation_name.Text}) Then
                    MsgBox("Allocation already exist")
                    err = True
                Else
                    Dim id As DataTable = FsQuery(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                    Dim det = dgProcess(dgSub, "lib_erp_allocation_account", "allocation_account_id", {"allocation_id", id.Rows(0).Item("id")}, {"account_code", "account_name"})
                    If det <> "" Then
                        FsQuery(det)
                    End If
                    pk = id.Rows(0).Item("id")
                    addSave = True
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"allocation_id", txt_allocation_id.Value}, {"allocation_code", "allocation_name"}, {txt_allocation_code.Text, txt_allocation_name.Text}, False) Then
                    MsgBox("Allocation already exist")
                    err = True
                Else
                    FsQuery(genUpdate(dbTable, dic))
                    Dim det = dgProcess(dgSub, "lib_erp_allocation_account", "allocation_account_id", {"allocation_id", primary_key.Value}, {"account_code", "account_name"})
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
                    If row.Cells("allocation_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addSave Then
                    saveAddAnother(btnInsert, "Add New Allocation?")
                End If
            End If
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        disable_allsubcontrol(dgSub)
        transmode = ""
        Dim selectedRow = dgMain.SelectedRows
        If selectedRow.Count > 0 Then
            selectedRow(0).Cells(0).Selected = False
            selectedRow(0).Cells(0).Selected = True
        End If
    End Sub

    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_code.Leave
        Dim dt As DataTable = FsQuery("select * from lib_erp_chart")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("account_code like '{0}'", txt_account_code.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "account_code,account_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_account_code.RowData = dr
                txt_account_code.Value = dr("account_id")
                txt_account_code.Text = dr("account_code")
                txt_account_name.Text = dr("account_name")
            End If
        End If
    End Sub

    Private Sub dgSub_SelectionChanged(sender As Object, e As EventArgs) Handles dgSub.SelectionChanged
        Dim dt = dgSub.DataSource
        bind_control(dgSub, "account_id", dt, panelSub)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim pk As String = "allocation_id"
        Dim colName As String = "allocation_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        Dim mainDB As String = _serverDBMain
        Dim tblTrans As String = "trans_jbooks"
        Dim pkTrans As String = "jbooks_id"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_erp_allocation"
        Dim pk_delete As String = "allocation_id"
        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""
        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg)
        If arr_id.Length > 0 Then
            For i As Integer = 0 To arr_id.Length - 1
                If isExistInTransaction(mainDB, tblTrans, pkTrans, pk, arr_id(i)) Then
                    msg &= String.Format(Environment.NewLine & (i + 1) & ". {0}", getColumnValue(dgMain, pk, arr_id(i), colName))
                    ctr += 1
                End If
            Next
        End If
        If ctr > 0 Then
            MsgBox(String.Format("There are {0} transaction(s) where this record(s) are used." & Environment.NewLine & msg, ctr), MsgBoxStyle.Critical, "Unable to Delete")
        ElseIf arr_id.Length > 0 Then
            For i As Integer = 0 To arr_id.Length - 1
                str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            Next
            Query(str)
            init_load()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        toggleDelete(dgSub, "allocation_account_id", "account_name", "sel1", ds)
    End Sub

    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles txtsearch.TextChange
        searchGrid("allocation_name", dgMain, txtsearch.Text)
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
End Class