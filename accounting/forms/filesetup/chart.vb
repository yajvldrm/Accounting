Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class chart
    Dim dbTable As String = "lib_erp_chart" ' para sa table ng database
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00806"
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Dim MyLogID As String = main.log_id
    Private MyDT As DataTable = Nothing

    Private Sub init_load()
        txt_unit_applicable.Visible = My.Settings._enableUnitNo
        dgMain.AutoGenerateColumns = False
        dgGroup.AutoGenerateColumns = False
        Dim sql = "SELECT a.*,b.chart_class_name FROM lib_erp_chart a LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id ORDER BY a.account_code,a.account_name ASC "
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        MyDT = ds.Tables(dbTable).Clone
        MyDT.Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
            MyDT.ImportRow(row)
        Next
        dgMain.DataSource = MyDT
        disable_allsubcontrol(dgGroup)
    End Sub
    Private Sub chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
        ' disable_subcontrol(dgGroup, "")
        bind_form(Me)
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        clear_subcontrol(dgGroup)
        clear_control(Me)
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "account_id", dt, Me)
        Dim sql As String = String.Format("SELECT b.chart_group_id AS group_id,b.chart_group_code,b.chart_group_name,a.chart_group_id,a.account_id FROM lib_erp_chart_group a LEFT JOIN lib_acc_chart_group b ON b.chart_group_id = a.group_id WHERE a.account_id = '{0}'", primary_key.Text)
        Dim dt_ewt As DataTable = FsQuery(sql)
        ds.Tables("lib_acc_chart_group").Clear()
        For Each row As DataRow In dt_ewt.Rows
            ds.Tables("lib_acc_chart_group").ImportRow(row)
        Next
        dgGroup.DataSource = ds.Tables("lib_acc_chart_group")
    End Sub
    Private Sub txt_chart_group_code_Leave(sender As Object, e As EventArgs) Handles txt_chart_group_code.Leave
        Dim dt As DataTable = FsQuery("select a.chart_group_id as group_id,a.chart_group_code,a.chart_group_name FROM lib_acc_chart_group a")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("chart_group_code like '{0}'", txt_chart_group_code.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "chart_group_code,chart_group_name", "100,400")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_chart_group_code.RowData = dr
                txt_chart_group_code.Value = dr("group_id")
                txt_chart_group_code.Text = dr("chart_group_code")
                txt_chart_group_name.Text = dr("chart_group_name")
            End If
        End If
    End Sub
    Private Sub dgGroup_SelectionChanged(sender As Object, e As EventArgs) Handles dgGroup.SelectionChanged
        Dim dt = dgGroup.DataSource
        bind_control(dgGroup, "group_id", dt, panelGroup)
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        Dim ndt As DataTable = ds.Tables("lib_acc_chart_group")
        ndt.Rows.Clear()
        dgGroup.DataSource = ndt
        clear_subcontrol(dgGroup)
        disable_subcontrol(dgGroup)
        txt_validation.Enabled = True

        Rdo_button1.Checked = False
        Rdo_button2.Checked = False
        Rdo_button3.Checked = False
        Rdo_button4.Checked = False
        Rdo_button5.Checked = False
        Rdo_button6.Checked = False
        Rdo_button7.Checked = False
        Rdo_button8.Checked = False
        Rdo_button9.Checked = False
        Rdo_button10.Checked = False

        btnPrint.Visible = False
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgMain.SelectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
            disable_subcontrol(dgGroup)
            Dim sql As String = String.Format("SELECT a.jbooks_id " & _
                                              "FROM {0}.trans_jbooks a " & _
                                              "WHERE a.account_id = {1} " & _
                                              "", _serverDBMain, txt_account_id.Text)
            Dim dt As DataTable = FsQuery(sql)
            If dt.Rows.Count > 0 Then
                txt_account_code.Enabled = False
                txt_validation.Enabled = False
            Else
                txt_account_code.Enabled = True
                txt_validation.Enabled = True
            End If
            txt_validation.Enabled = True
        Else
            MsgBox("No Record Selected")
        End If

        btnPrint.Visible = False
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As Integer = 0
        Dim addSave As Boolean = False
        Dim dic = generateDictionary(Me, dt)

        If requiredChecker(Panel1) Or requiredChecker(panelGroup) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            dic.Remove("sel")
            dic.Remove("chart_class_name")
            If transmode = "insert" Then
                If DataExist(dgMain, {"account_id", txt_account_id.Value}, {"account_code", "account_name"}, {txt_account_code.Text, txt_account_name.Text}) Then
                    MsgBox("Chart already exist")
                    err = True
                Else
                    If dic.ContainsKey("sel") Then
                        dic.Remove("sel")
                    End If
                    Dim id As DataTable = FsQuery(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, MyLogID, txt_account_id.Value, "account_id"))
                    'Dim id As DataTable = FsQuery(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                    Dim ewt = dgProcess(dgGroup, "lib_erp_chart_group", "chart_group_id", {"account_id", id.Rows(0).Item("return_id")}, {"chart_group_code", "chart_group_name"}, , , , , main.log_id)
                    'Dim ewt = dgProcess(dgGroup, "lib_erp_chart_group", "chart_group_id", {"account_id", id.Rows(0).Item("id")}, {"chart_group_code", "chart_group_name"})
                    If ewt <> "" Then
                        FsQuery(ewt)
                    End If
                    pk = id.Rows(0).Item("return_id")
                    'pk = id.Rows(0).Item("id")
                    addSave = True
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"account_id", txt_account_id.Value}, {"account_code", "account_name"}, {txt_account_code.Text, txt_account_name.Text}, False) Then
                    MsgBox("Chart already exist")
                    err = True
                Else
                    'FsQuery(genUpdate(dbTable, dic))
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, MyLogID, txt_account_id.Value, "account_id"))
                    Dim ewt = dgProcess(dgGroup, "lib_erp_chart_group", "chart_group_id", {"account_id", primary_key.Value}, {"chart_group_code", "chart_group_name"}, , , , , main.log_id)
                    If ewt <> "" Then
                        FsQuery(ewt)
                    End If
                    pk = txt_account_id.Value
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
                    If row.Cells("account_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                If addSave Then
                    saveAddAnother(btnInsert, "Add New Chart of Account?")
                End If
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        clear_subcontrol(dgGroup)
        disable_control(Me, main.dicAction.Item(module_code))
        disable_allsubcontrol(dgGroup)
        transmode = ""
        Dim selectedRow = dgMain.SelectedRows
        selectedRow(0).Cells(0).Selected = False
        selectedRow(0).Cells(0).Selected = True
        btnPrint.Visible = True
    End Sub
    Private Sub txt_chart_class_id_Leave(sender As Object, e As EventArgs) Handles txt_chart_class_id.Leave
        Dim dt As DataTable = FsQuery("select * from lib_acc_chart_class")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("chart_class_name like '{0}'", txt_chart_class_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "chart_class_code,chart_class_name", "200,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_chart_class_id.RowData = dr
                txt_chart_class_id.Value = dr("chart_class_id")
                txt_chart_class_id.Text = dr("chart_class_name")
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        chart_report_filter.ShowDialog()
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim pk As String = "account_id"
        Dim colName As String = "account_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        Dim mainDB As String = _serverDBMain
        Dim tblTrans As String = "trans_jbooks"
        Dim pkTrans As String = "jbooks_id"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_erp_chart"
        Dim pk_delete As String = "account_id"

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
                ids &= arr_id(i).ToString & "|"
                'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            Next
            str = String.Format(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, MyLogID, ids, "account_id"))
            FsQuery(str)
            init_load()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        toggleDelete(dgGroup, "chart_group_id", "chart_group_name", "sel1", ds)
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
        Dim q As String = txtsearch.Text.ToString.Replace("'", "''")
        If txtsearch.TextSource <> "" Then
            Dim cols = txtsearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            Dim selectedRows = MyDT.[Select](selectQuery.Substring(4), txtsearch.TextSource & " ASC")
            If selectedRows.Length > 0 Then
                'If currentSearchIndex >= selectedRows.Length Then
                '    currentSearchIndex = 0
                'End If
                'Dim selectedID As String = selectedRows(currentSearchIndex).Item("account_id").ToString
                'dgMain.ClearSelection()
                'For Each row As DataGridViewRow In dgMain.Rows
                '    If row.Cells("account_id").Value.ToString = selectedID Then
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
        End If
    End Sub
    Private Sub txt_account_code_Leave(sender As Object, e As EventArgs) Handles txt_account_code.Leave
        If DataExist(dgMain, {"account_id", txt_account_id.Value}, {"account_code"}, {txt_account_code.Text}, transmode = "insert") Then
            MsgBox("Record Already Exist.")
            sender.Focus()
        End If
    End Sub
    Private Sub txt_account_name_Leave(sender As Object, e As EventArgs) Handles txt_account_name.Leave
        If DataExist(dgMain, {"account_id", txt_account_id.Value}, {"account_name"}, {txt_account_name.Text}, transmode = "insert") Then
            MsgBox("Record Already Exist.")
            sender.Focus()
        End If
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnInsert)
        dicShortCut.Add(114, btnUpdate)
        dicShortCut.Add(115, btnRemove)
        dicShortCut.Add(116, btnPrint)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub

    Private Sub chk_import_CheckedChanged(sender As Object, e As EventArgs) Handles txt_input_vat_importation.CheckedChanged
        validation()
    End Sub

    Private Sub Rdo_button6_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button6.CheckedChanged
        validation()

    End Sub
    Private Sub validation()
        Try
            Try
                If Rdo_button6.Enabled Then
                    If Rdo_button6.Checked Then
                        txt_input_vat_importation.Enabled = True
                    Else
                        txt_input_vat_importation.Checked = False
                        txt_input_vat_importation.Enabled = True
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class