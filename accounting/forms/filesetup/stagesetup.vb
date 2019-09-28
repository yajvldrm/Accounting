Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class stagesetup
    Dim dbTable As String = "sys_erp_stage"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00819"
    Private MyDT As DataTable = Nothing

    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM sys_erp_stage"
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        MyDT = ds.Tables(dbTable).Clone
        MyDT.Clear()
        For Each row As DataRow In dt.Rows
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
        Dim addSave As Boolean = False

        Dim dic = generateDictionary(Me, dt)
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            If transmode = "insert" Then
                If DataExist(dgMain, {"stage_id", txt_stage_id.Value}, {"stage_code", "stage_name"}, {txt_stage_code.Text, txt_stage_name.Text}) Then
                    MsgBox("Stage already exist")
                    err = True
                Else
                    If dic.ContainsKey("sel") Then
                        dic.Remove("sel")
                    End If
                    Dim id As DataTable = FsQuery(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_stage_id.Value, "stage_id"))
                    'Dim id As DataTable = FsQuery(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                    pk = id.Rows(0).Item("return_id")
                    addSave = True
                End If
            ElseIf transmode = "update" Then
                dic.Remove("sel")
                If DataExist(dgMain, {"stage_id", txt_stage_id.Value}, {"stage_code", "stage_name"}, {txt_stage_code.Text, txt_stage_name.Text}, False) Then
                    MsgBox("Stage already exist")
                    err = True
                Else
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_stage_id.Value, "stage_id"))
                    'FsQuery(genUpdate(dbTable, dic))
                    pk = txt_stage_id.Value
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
                    If row.Cells("stage_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addSave Then
                    saveAddAnother(btnInsert, "Add New Stage?")
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

    Private Sub Stage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
    End Sub

    Private Sub dgBook_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "stage_id", dt, Me)
    End Sub

    Private Sub cboxAllHeader_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAllHeader.CheckedChanged
        For Each row As DataGridViewRow In dgMain.Rows
            row.Cells("sel").Value = cboxAllHeader.Checked
        Next
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim pk As String = "stage_id"
        Dim colName As String = "stage_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        Dim mainDB As String = _serverDBFS
        Dim tblTrans As String = "sys_erp_approval"
        Dim pkTrans As String = "approval_id"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "sys_erp_stage"
        Dim pk_delete As String = "stage_id"


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
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
                ids &= arr_id(i).ToString & "|"
            Next
            'Query(str)
            FsQuery(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "stage_id"))
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
        'searchGrid("stage_name", dgMain, txtsearch.Text)
        Dim q As String = txtsearch.Text
        If txtsearch.TextSource <> "" Then
            Dim cols = txtsearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            Dim selectedRows = MyDT.[Select](selectQuery.Substring(4), txtsearch.TextSource & " ASC")
            If selectedRows.Length > 0 Then
                Dim newDT = MyDT.Clone
                newDT.Clear()
                For Each dr In selectedRows
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
End Class