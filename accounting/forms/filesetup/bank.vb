Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class bank
    Dim dbTable As String = "lib_erp_bank"
    Dim ds As New FileSetupSet
    Dim t As New ToolTip
    Private transmode As String = ""
    Private module_code As String = "ACC00802"
    Private currentSearchIndex As Integer = 0
    Private MyLogID = main.log_id
    Private MyDT As DataTable = Nothing
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM lib_erp_bank ORDER BY bank_code"
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
                'If DataExist(dgMain, {"bank_id", txt_bank_id.Value}, {"bank_code", "bank_name"}, {txt_bank_code.Text, txt_bank_name.Text}) Then
                '    MsgBox("Bank already exist")
                '    err = True
                'Else
                'Dim id As DataTable = FsQuery(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                'pk = id.Rows(0).Item("id")
                If dic.ContainsKey("sel") Then
                    dic.Remove("sel")
                End If
                Dim tmp_str = ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, MyLogID, "", "bank_id")
                Dim id As DataTable = FsQuery(tmp_str)
                pk = id.Rows(0).Item("return_id")
                addSave = True
                'End If
            ElseIf transmode = "update" Then
                dic.Remove("sel")
                'If DataExist(dgMain, {"bank_id", txt_bank_id.Value}, {"bank_code", "bank_name"}, {txt_bank_code.Text, txt_bank_name.Text}, False) Then
                '    MsgBox("Bank already exist")
                '    err = True
                'Else
                'FsQuery(genUpdate(dbTable, dic))
                'pk = txt_bank_id.Value
                Dim id As DataTable = FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, MyLogID, txt_bank_id.Value, "bank_id"))
                pk = id.Rows(0).Item("return_id")
                MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                'End If
            ElseIf transmode = "remove" Then
            End If
            If Not err Then
                transmode = ""
                disable_control(Me, main.dicAction.Item(module_code))
                btnInsert.Focus()
                init_load()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("bank_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addSave Then
                    saveAddAnother(btnInsert, "Add New Bank?")
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
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim pk As String = "bank_id"
        Dim colName As String = "bank_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        Dim mainDB As String = _serverDBMain
        Dim tblTrans As String = "trans_checks"
        Dim pkTrans As String = "check_id"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_erp_bank"
        Dim pk_delete As String = "bank_id"
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
                ids &= arr_id(i) & "|"
                'str &= ATGenerateQuery("Remove",tbl_delete,Nothing,Environment.MachineName,Environment.UserName,MyLogID,)
                'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            Next
            str = ATGenerateQuery("Remove", tbl_delete, Nothing, Environment.MachineName, Environment.UserName, MyLogID, ids, "bank_id")
            FsQuery(str)
            init_load()
        End If
    End Sub
    Private Sub bank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "bank_id", dt, Me)
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
            Dim selectedRows = MyDT.Select(selectQuery.Substring(4))
            If selectedRows.Length > 0 Then
                'If currentSearchIndex >= selectedRows.Length Then
                '    currentSearchIndex = 0
                'End If
                'Dim selectedID As String = selectedRows(currentSearchIndex).Item("bank_id").ToString
                'dgMain.ClearSelection()
                'For Each row As DataGridViewRow In dgMain.Rows
                '    If row.Cells("bank_id").Value.ToString = selectedID Then
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
    Private Sub txt_bank_code_Leave(sender As Object, e As EventArgs) Handles txt_bank_code.Leave
        Dim dt As DataTable = FsQuery("select * from lib_erp_chart WHERE validation = 1 ")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("account_code like '" & txt_bank_code.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "account_code,account_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_bank_code.RowData = dr
                txt_bank_code.Text = dr("account_code")
                txt_bank_name.Text = dr("account_name")
            End If
        End If
    End Sub
    Private Sub btnReportDesigner_Click(sender As Object, e As EventArgs) Handles btnReportDesigner.Click
        'Dim rep As New bank_report_print_1
        'reportviewer.DocumentViewer1.DocumentSource = rep
        If reportddesigner.Visible = False Then
            reportddesigner.ShowDialog()
        End If
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim path = txt_file_path.Text
        od.Filter = "Report Files (*.repx)|*.repx"
        If od.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If od.FileName.ToString <> "" Then
                txt_file_path.Text = od.FileName.Replace("\", "/")
            End If
        End If
    End Sub
    Private Sub txt_file_path_TextChange(sender As Object, e As EventArgs) Handles txt_file_path.TextChange
        t.SetToolTip(txt_file_path, txt_file_path.Text)
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
    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        'If e.KeyCode = Keys.Enter And e.Control Then
        '    currentSearchIndex += 1
        '    txtsearch_TextChange(Nothing, Nothing)
        '    e.SuppressKeyPress = True
        'End If
    End Sub
End Class