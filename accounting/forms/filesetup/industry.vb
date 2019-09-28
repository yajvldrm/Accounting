Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class industry
    Dim dbTable As String = "lib_erp_industry"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00812"
    Dim templates As String = Application.StartupPath & "\templates"
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Private MyDT As DataTable = Nothing

    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM lib_erp_industry a ORDER BY a.industry_code,a.industry_name ASC"
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
    Private Sub industry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "industry_id", dt, Me)
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
        Dim dic = generateDictionary(Me, dt)
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            If transmode = "insert" Then
                If DataExist(dgMain, {"industry_id", txt_industry_id.Value}, {"industry_code", "industry_name"}, {txt_industry_code.Text, txt_industry_name.Text}) Then
                    MsgBox("Industry already exist")
                    err = True
                Else
                    dic.Remove("sel")
                    Dim id = FsQuery(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_industry_id.Value, "industry_id"))
                    'Dim id As DataTable = FsQuery(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                    pk = id.Rows(0).Item("return_id")
                    addsave = True
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"industry_id", txt_industry_id.Value}, {"industry_code", "industry_name"}, {txt_industry_code.Text, txt_industry_name.Text}, False) Then
                    MsgBox("Industry already exist")
                    err = True
                Else
                    dic.Remove("sel")
                    'FsQuery(genUpdate(dbTable, dic))
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_industry_id.Value, "industry_id"))
                    pk = txt_industry_id.Value
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
                    If row.Cells("industry_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addsave Then
                    saveAddAnother(btnInsert, "Add New Industry?")
                End If
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        transmode = ""
        Dim selectedRow = dgMain.SelectedRows
        If selectedRow.Count > 0 Then
            selectedRow(0).Cells(0).Selected = False
            selectedRow(0).Cells(0).Selected = True
        End If

    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim pk As String = "industry_id"
        Dim colName As String = "industry_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        Dim mainDB As String = _serverDBFS
        Dim tblTrans As String = "lib_erp_general"
        Dim pkTrans As String = "general_id"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_erp_industry"
        Dim pk_delete As String = "industry_id"
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
                ids &= arr_id(i) & "|"
            Next
            'Query(str)
            FsQuery(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "industry_id"))
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
                'Dim selectedID As String = selectedRows(currentSearchIndex).Item("industry_id").ToString
                'dgMain.ClearSelection()
                'For Each row As DataGridViewRow In dgMain.Rows
                '    If row.Cells("industry_id").Value.ToString = selectedID Then
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
End Class