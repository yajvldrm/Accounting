Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class filtercodessetup
    Dim dbTable As String = "sys_acc_filter"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00910"
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Private MyDT As DataTable = Nothing

    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        dgSub.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM sys_acc_filter a ORDER BY a.filter_code,a.filter_name ASC "
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        MyDT = ds.Tables(dbTable).Clone
        MyDT.Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
            MyDT.ImportRow(row)
        Next
        dgMain.DataSource = MyDT
        disable_allsubcontrol(dgSub)
    End Sub

    Private Sub filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
        'disable_subcontrol(dgSub, "")
        bind_form(Me)
    End Sub

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "filter_id", dt, Me)
        Dim dt_sub As DataTable = FsQuery(String.Format("SELECT a.filter_det_id,a.filter_id,a.book_id,a.journal_id,b.book_code,b.book_name,c.journal_code,c.journal_name FROM sys_acc_filter_det a LEFT JOIN lib_erp_book b ON b.book_id = a.book_id LEFT JOIN lib_erp_journal c ON c.journal_id = a.journal_id WHERE a.filter_id = {0} ", primary_key.Value))
        ds.Tables("sys_acc_filter_det").Clear()
        For Each row As DataRow In dt_sub.Rows
            ds.Tables("sys_acc_filter_det").ImportRow(row)
        Next
        dgSub.DataSource = ds.Tables("sys_acc_filter_det")
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs)
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        Dim ndt As DataTable = ds.Tables("sys_acc_filter_det")
        ndt.Rows.Clear()
        dgSub.DataSource = ndt
        clear_subcontrol(dgSub)
        disable_subcontrol(dgSub)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgMain.SelectedRows.Count > 0 Then
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
            If transmode = "insert" Then
                If DataExist(dgMain, {"filter_id", txt_filter_id.Value}, {"filter_code", "filter_name"}, {txt_filter_code.Text, txt_filter_name.Text}, True) Then
                    MsgBox("Filter already exist")
                    err = True
                Else
                    dic.Remove("sel")
                    'Dim sql_head = genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;"
                    Dim sql_head = ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_filter_id.Value, "filter_id")
                    Dim dt_head As DataTable = FsQuery(sql_head)
                    Dim det = dgProcess(dgSub, "sys_acc_filter_det", "filter_det_id", {"filter_id", dt_head.Rows(0).Item("return_id").ToString}, {"book_code", "book_name", "journal_code", "journal_name"}, , , , , main.log_id)
                    FsQuery(det)
                    pk = dt_head.Rows(0).Item("return_id").ToString
                    addSave = True
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"filter_id", txt_filter_id.Value}, {"filter_code", "filter_name"}, {txt_filter_code.Text, txt_filter_name.Text}, False) Then
                    MsgBox("Filter already exist")
                    err = True
                Else
                    dic.Remove("sel")
                    'Dim sql_head = genUpdate(dbTable, dic)
                    Dim sql_head = ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_filter_id.Value, "filter_id")
                    FsQuery(sql_head)
                    Dim det = dgProcess(dgSub, "sys_acc_filter_det", "filter_det_id", {"filter_id", primary_key.Value}, {"book_code", "book_name", "journal_code", "journal_name"}, , , , , main.log_id)
                    FsQuery(det)
                    pk = primary_key.Value
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "remove" Then
            End If

            If Not err Then
                transmode = ""
                disable_control(Me, main.dicAction.Item(module_code))
                btnUpdate.Focus()
                init_load()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("filter_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addSave Then
                    saveAddAnother(btnInsert, "Add New Filter?")
                End If
            End If
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        disable_allsubcontrol(dgSub)
        transmode = ""
        Dim selectedRow = dgMain.SelectedRows
        selectedRow(0).Cells(0).Selected = False
        selectedRow(0).Cells(0).Selected = True
    End Sub

    Private Sub txt_book_code_Leave(sender As Object, e As EventArgs) Handles txt_book_code.Leave

        Dim dt As DataTable = FsQuery("select * from lib_erp_book")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("book_code like '{0}'", txt_book_code.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "book_code,book_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_book_code.RowData = dr
                txt_book_code.Value = dr("book_id")
                txt_book_code.Text = dr("book_code")
                txt_book_name.Text = dr("book_name")
            End If
        End If

    End Sub

    Private Sub dgSub_SelectionChanged(sender As Object, e As EventArgs) Handles dgSub.SelectionChanged
        Dim dt = dgSub.DataSource
        bind_control(dgSub, "filter_det_id", dt, panelSub)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        toggleDelete(dgSub, "filter_det_id", "book_name", "sel1", ds)
    End Sub

    Private Sub txt_journal_code_Leave(sender As Object, e As EventArgs) Handles txt_journal_code.Leave

        Dim dt As DataTable = FsQuery("select * from lib_erp_journal")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("journal_code like '{0}'", txt_journal_code.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "journal_code,journal_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_journal_code.RowData = dr
                txt_journal_code.Value = dr("journal_id")
                txt_journal_code.Text = dr("journal_code")
                txt_journal_name.Text = dr("journal_name")
            End If
        End If

    End Sub

    Private Sub btnInsert_Click_1(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        Dim ndt As DataTable = ds.Tables("sys_acc_filter_det")
        ndt.Rows.Clear()
        dgSub.DataSource = ndt
        clear_subcontrol(dgSub)
        disable_subcontrol(dgSub)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim pk As String = "filter_id"
        Dim colName As String = "filter_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        Dim mainDB As String = _serverDBMain
        Dim tblTrans As String = "sys_default"
        Dim pkTrans As String = "default_id"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "sys_acc_filter"
        Dim pk_delete As String = "filter_id"

        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""

        Dim arr_id = getCheckedGrid(pk, colName, sel, dgMain, "Are you sure to delete this record(s)?")
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
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
                ids &= arr_id(i).ToString & "|"
            Next
            FsQuery(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "filter_id"))
            'MsgBox(str)
            init_load()
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
                'Dim selectedID As String = selectedRows(currentSearchIndex).Item("filter_id").ToString
                'dgMain.ClearSelection()
                'For Each row As DataGridViewRow In dgMain.Rows
                '    If row.Cells("filter_id").Value.ToString = selectedID Then
                '        row.Selected = True
                '        Dim tmp_index = dt.Rows.IndexOf(selectedRows(currentSearchIndex))
                '        dgMain.FirstDisplayedScrollingRowIndex = tmp_index
                '    End If
                'Next
                Dim newDt = MyDT.Clone
                newDt.Clear()
                For Each dr As DataRow In selectedRows
                    newDt.ImportRow(dr)
                Next
                dgMain.DataSource = newDt
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
End Class