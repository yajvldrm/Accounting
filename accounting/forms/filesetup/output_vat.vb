Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class output_vat
    Dim dbTable As String = "lib_acc_output_vat"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00817"
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txt_vat_rate.NumberFormat = strNumberFormat
    End Sub
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM lib_acc_output_vat ORDER BY effectivity_date DESC"
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
        Next
        dgMain.DataSource = ds.Tables(dbTable)
    End Sub

    Private Sub input_vat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
    End Sub

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "output_vat_id", dt, Me)
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
                If DataExist(dgMain, {"output_vat_id", txt_output_vat_id.Value}, {"effectivity_date"}, {txt_effectivity_date.Value & " 12:00:00 AM"}) Then
                    MsgBox("Output VAT already exist")
                    err = True
                Else
                    If dic.ContainsKey("sel") Then
                        dic.Remove("sel")
                    End If
                    Dim id As DataTable = FsQuery(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_output_vat_id.Value, "output_vat_id"))
                    'Dim id As DataTable = FsQuery(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                    pk = id.Rows(0).Item("return_id")
                    addsave = True
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"output_vat_id", txt_output_vat_id.Value}, {"effectivity_date"}, {txt_effectivity_date.Value & " 12:00:00 AM"}, False) Then
                    MsgBox("Output VAT already exist")
                    err = True
                Else
                    dic.Remove("sel")
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_output_vat_id.Text, "output_vat_id"))
                    'FsQuery(genUpdate(dbTable, dic))
                    pk = txt_output_vat_id.Value
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
                    If row.Cells("output_vat_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addsave Then
                    saveAddAnother(btnInsert, "Add New Output Vat?")
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

    Private Sub dgMain_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgMain.CellFormatting
        If e.ColumnIndex = 2 Then 'your column
            Dim d As Date
            If Date.TryParse(e.Value.ToString, d) Then
                e.Value = d.ToString("d")
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim pk As String = "output_vat_id"
        Dim colName As String = "vat_rate"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_acc_output_vat"
        Dim pk_delete As String = "output_vat_id"
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
            FsQuery(ATGenerateQuery("Remove", tbl_delete, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "output_vat_id"))
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