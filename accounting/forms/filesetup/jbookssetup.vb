Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class jbookssetup
    Dim dbTable As String = "lib_erp_journal"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00911"
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Private MyDT As DataTable = Nothing

    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        dgSub.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM lib_erp_journal a WHERE journal_id <> '8' ORDER BY a.journal_code,a.journal_name ASC "
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

    Private Sub journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
        'disable_subcontrol(dgSub, "")
        bind_form(Me)
    End Sub

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "journal_id", dt, Me)
        Dim dt_sub As DataTable = FsQuery(String.Format("SELECT a.journal_book_det_id,a.journal_id,a.book_id,b.book_code,b.book_name,a.start_trans_no,a.format FROM sys_acc_journal_book a LEFT JOIN lib_erp_book b ON b.book_id = a.book_id WHERE a.journal_id = {0} AND b.company_id = '{1}'", primary_key.Value, main.Sys_Default.Rows(0).Item("company_id").ToString()))
        ds.Tables("sys_acc_journal_book").Clear()
        For Each row As DataRow In dt_sub.Rows
            ds.Tables("sys_acc_journal_book").ImportRow(row)
        Next
        dgSub.DataSource = ds.Tables("sys_acc_journal_book")
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs)
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        Dim ndt As DataTable = ds.Tables("sys_acc_journal_book")
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

        Dim dic = generateDictionary(Me, dt)
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            If transmode = "insert" Then
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"journal_id", txt_journal_id.Value}, {"journal_code", "journal_name"}, {txt_journal_code.Text, txt_journal_name.Text}, False) Then
                    MsgBox("Journal already exist")
                    err = True
                Else
                    dic.Remove("sel")
                    'Dim sql_head = genUpdate(dbTable, dic)
                    Dim sql_head = ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_journal_id.Text, "journal_id")
                    FsQuery(sql_head)
                    Dim det = dgProcess(dgSub, "sys_acc_journal_book", "journal_book_det_id", {"journal_id", primary_key.Value}, {"book_code", "book_name"}, , , , , main.log_id)
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
                    If row.Cells("journal_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
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
        Dim selectedId As String = ""
        Dim selectedDrs = dgSub.SelectedRows
        If selectedDrs.Count > 0 Then
            Dim selectedDr = selectedDrs(0)
            selectedId = selectedDr.Cells("journal_book_det_id").Value
        End If
        Dim ids As String = ""
        Dim _dt As DataTable = dgSub.DataSource
        For Each dr As DataRow In _dt.Rows
            If Not dr.Item("deleted") Then
                If txt_journal_book_det_id.Text <> "" Then
                    If dr.Item("journal_book_det_id").ToString <> selectedId Then
                        ids &= "," & dr.Item("book_id").ToString
                    End If
                Else
                    ids &= "," & dr.Item("book_id").ToString
                End If
            End If
        Next
        Dim sql = "select * from lib_erp_book WHERE company_id = '" & main.Sys_Default.Rows(0).Item("company_id").ToString & "'"
        If ids <> "" Then
            sql &= " AND book_id NOT IN (" & ids.Substring(1) & ")"
        End If
        Dim dt As DataTable = FsQuery(sql)
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
        bind_control(dgSub, "book_id", dt, panelSub)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        toggleDelete(dgSub, "journal_book_det_id", "book_name", "sel1", ds)
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
                'Dim selectedID As String = selectedRows(currentSearchIndex).Item("journal_id").ToString
                'dgMain.ClearSelection()
                'For Each row As DataGridViewRow In dgMain.Rows
                '    If row.Cells("journal_id").Value.ToString = selectedID Then
                '        row.Selected = True
                '        Dim tmp_index = dt.Rows.IndexOf(selectedRows(currentSearchIndex))
                '        dgMain.FirstDisplayedScrollingRowIndex = tmp_index
                '    End If
                'Next
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
        dicShortCut.Add(114, btnUpdate)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub
End Class