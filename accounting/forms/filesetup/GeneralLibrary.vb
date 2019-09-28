Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Text.RegularExpressions

Public Class GeneralLibrary
    Dim dbTable As String = "lib_erp_general" ' para sa table ng database
    'Dim dsTable As String = "tblGeneral" ' para naman sa table na gagamitin para sa datagrid
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00810"
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Private generalNameFocus As Boolean = False
    Private MyDT As DataTable = Nothing
    Private bs As New BindingSource
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txt_tax_rate.NumberFormat = strNumberFormat
        txt_final_tax_rate.NumberFormat = strNumberFormat
    End Sub
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        dgEwt.AutoGenerateColumns = False
        dgFTax.AutoGenerateColumns = False
        Dim sql = "SELECT a.*,ELT(a.general_type,'Supplier','Client','Both') AS general_type_name,b.category_name,c.terms_name,d.industry_name FROM lib_erp_general a LEFT JOIN lib_erp_category b ON b.category_id = a.category_id LEFT JOIN lib_erp_terms c ON c.terms_id = a.terms_id LEFT JOIN lib_erp_industry d ON d.industry_id = a.industry_id ORDER BY a.general_code,a.general_name ASC "
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables(dbTable).Clear()
        MyDT = ds.Tables(dbTable).Clone
        MyDT.Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
            MyDT.ImportRow(row)
        Next
        bs.DataSource = MyDT
        dgMain.DataSource = bs
        disable_allsubcontrol(dgEwt)
        disable_allsubcontrol(dgFTax)
        txt_general_code.AlwaysDisable = main.Sys_Default.Rows(0).Item("general_auto_number")
        txt_general_code.Required = If(main.Sys_Default.Rows(0).Item("general_auto_number"), 0, 1)
    End Sub
    Private Sub GeneralLibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
        'disable_subcontrol(dgEwt, "")
        'disable_subcontrol(dgFTax, "")
        bind_form(Me)
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        'txt_status.Checked = True
        Dim ndt As DataTable = ds.Tables("lib_acc_ewt")
        ndt.Rows.Clear()
        dgEwt.DataSource = ndt
        Dim ndt1 As DataTable = ds.Tables("lib_acc_final_tax")
        ndt1.Rows.Clear()
        dgFTax.DataSource = ndt1
        clear_subcontrol(dgEwt)
        clear_subcontrol(dgFTax)
        disable_subcontrol(dgEwt)
        disable_subcontrol(dgFTax)
        If main.Sys_Default.Rows(0).Item("general_auto_number") Then
            txt_general_name.Focus()
        Else
            txt_general_code.Focus()
        End If
        btnPrint.Visible = False
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        clear_subcontrol(dgEwt)
        clear_subcontrol(dgFTax)
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "general_id", dt, Me)
        Dim sql_ewt As String = String.Format("SELECT b.ewt_id,b.ewt_code,b.ewt_name,b.tax_rate,a.general_ewt_id,a.general_id FROM lib_erp_general_ewt a LEFT JOIN lib_acc_ewt b ON b.ewt_id = a.ewt_id WHERE a.general_id = '{0}'", primary_key.Text)
        Dim dt_ewt As DataTable = FsQuery(sql_ewt)
        ds.Tables("lib_acc_ewt").Clear()
        For Each row As DataRow In dt_ewt.Rows
            ds.Tables("lib_acc_ewt").ImportRow(row)
        Next
        dgEwt.DataSource = ds.Tables("lib_acc_ewt")

        Dim dt_ftax As DataTable = FsQuery("SELECT b.final_tax_id,b.final_tax_code,b.final_tax_name,b.final_tax_rate,a.general_final_tax_id,a.general_id FROM lib_erp_general_final_tax a LEFT JOIN lib_acc_final_tax b ON b.final_tax_id = a.final_tax_id WHERE a.general_id = " & primary_key.Text)
        ds.Tables("lib_acc_final_tax").Clear()
        For Each row As DataRow In dt_ftax.Rows
            ds.Tables("lib_acc_final_tax").ImportRow(row)
        Next
        dgFTax.DataSource = ds.Tables("lib_acc_final_tax")
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        disable_allsubcontrol(dgEwt)
        disable_allsubcontrol(dgFTax)
        transmode = ""
        Dim selectedRow = dgMain.SelectedRows
        If selectedRow.Count > 0 Then
            selectedRow(0).Cells(0).Selected = False
            selectedRow(0).Cells(0).Selected = True
        End If

        btnPrint.Visible = True
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgMain.SelectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
            disable_subcontrol(dgEwt)
            disable_subcontrol(dgFTax)
            If main.Sys_Default.Rows(0).Item("general_auto_number") Then
                txt_general_name.Focus()
            Else
                txt_general_code.Focus()
            End If
            btnPrint.Visible = False
            Dim sql As String = String.Format("SELECT general_id FROM trans_header WHERE general_id = '{0}'", txt_general_id.Text.ToString)
            Dim dt As DataTable = Query(sql)
            If dt.Rows.Count > 0 Then
                txt_general_code.Enabled = False
                txt_general_name.Focus()
            Else
                txt_general_code.Enabled = True
                txt_general_code.Focus()
            End If
        Else
            MsgBox("No Record Selected")
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        bs.EndEdit()
        Dim _id As String = "0"
        Dim err As Boolean = False

        Dim dt As DataTable = ds.Tables(dbTable)

        Dim dic = generateDictionary(Me, dt)
        Dim addsave As Boolean = False

        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else

            ' emon-2017-11-08
            Dim tin As String = txt_tin.Text.Replace("-", "").Trim()
            Dim _dr = txt_category_id.RowData
            If _dr IsNot Nothing Then
                If _dr.Item("require_tin") Then
                    If IsNumeric(tin) Then
                        If CDec(tin) <= 0 Then
                            MsgBox("TIN is required")
                            Exit Sub
                        End If
                    Else
                        MsgBox("TIN is required")
                        Exit Sub
                    End If
                End If
            End If
            ' emon-2017-11-08

            dic.Remove("sel")
            dic.Remove("category_name")
            dic.Remove("terms_name")
            dic.Remove("industry_name")
            If transmode = "insert" Then
                If DataExist(bs, {"general_id", txt_general_id.Value}, {"general_code"}, {txt_general_code.Text}) Then
                    MsgBox("General Library already exist")
                    err = True
                Else
                    If main.Sys_Default.Rows(0).Item("general_auto_number") Then
                        Dim sql_new_trans_no = String.Format("CALL get_general_no({0})", dic.Item("category_id"))
                        Dim dt_new_trans_no As DataTable = FsQuery(sql_new_trans_no)
                        If dt_new_trans_no.Rows.Count > 0 Then
                            dic.Item("general_code") = dt_new_trans_no.Rows(0).Item("trans_no_new").ToString
                        Else
                            MsgBox("Unable to generate auto Number.")
                            Exit Sub
                        End If
                    End If
                    'Dim tmp_str_query = genInsert(dbTable, dic)
                    'Dim id As DataTable = FsQuery(tmp_str_query & ";SELECT LAST_INSERT_ID() AS id;")
                    Dim id As DataTable = FsQuery(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_general_id.Value, "general_id"))
                    Dim ewt = dgProcess(dgEwt, "lib_erp_general_ewt", "general_ewt_id", {"general_id", id.Rows(0).Item("return_id")}, {"ewt_code", "ewt_name", "tax_rate"}, , , , , main.log_id)
                    If ewt <> "" Then
                        FsQuery(ewt)
                    End If
                    Dim ftax = dgProcess(dgFTax, "lib_erp_general_final_tax", "general_final_tax_id", {"general_id", id.Rows(0).Item("return_id")}, {"final_tax_code", "final_tax_name", "final_tax_rate"}, , , , , main.log_id)
                    If ftax <> "" Then
                        FsQuery(ftax)
                    End If
                    _id = id.Rows(0).Item("return_id")
                    addsave = True
                End If
            ElseIf transmode = "update" Then
                If DataExist(bs, {"general_id", txt_general_id.Value}, {"general_code"}, {txt_general_code.Text}, False) Then
                    MsgBox("General Library already exist")
                    err = True
                Else
                    'FsQuery(genUpdate(dbTable, dic))
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_general_id.Value, "general_id"))
                    Dim ewt = dgProcess(dgEwt, "lib_erp_general_ewt", "general_ewt_id", {"general_id", primary_key.Value}, {"ewt_code", "ewt_name", "tax_rate"}, , , , , main.log_id)
                    If ewt <> "" Then
                        FsQuery(ewt)
                    End If
                    Dim ftax = dgProcess(dgFTax, "lib_erp_general_final_tax", "general_final_tax_id", {"general_id", primary_key.Value}, {"final_tax_code", "final_tax_name", "final_tax_rate"}, , , , , main.log_id)
                    If ftax <> "" Then
                        FsQuery(ftax)
                    End If
                    _id = primary_key.Value
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "remove" Then
            End If
            If Not err Then
                transmode = ""
                disable_control(Me, main.dicAction.Item(module_code))
                btnInsert.Focus()
                init_load()

                For i As Integer = 0 To dgMain.Rows.Count - 1
                    If dgMain.Rows(i).Cells("general_id").Value = _id Then
                        dgMain.Rows(i).Cells(0).Selected = True
                        Exit For
                    End If
                Next
                If addsave Then
                    saveAddAnother(btnInsert, "Add New Record?")
                End If
            End If
        End If
    End Sub
    Private Sub txt_category_id_Leave(sender As Object, e As EventArgs) Handles txt_category_id.Leave
        Dim dt As DataTable = FsQuery("select * from lib_erp_category")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("category_name like '{0}'", txt_category_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "category_code,category_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_category_id.RowData = dr
                txt_category_id.Value = dr("category_id")
                txt_category_id.Text = dr("category_name")
            End If
        End If
    End Sub
    Private Sub txt_terms_Leave(sender As Object, e As EventArgs) Handles txt_terms_id.Leave
        Dim dt As DataTable = FsQuery("select * from lib_erp_terms")
        If txt_terms_id.Text = "" And Not txt_terms_id.Required Then
            txt_terms_id.Text = ""
            txt_terms_id.Value = ""
            Exit Sub
        End If
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                If txt_terms_id.Required Then
                    dr = dt.Rows(0)
                End If
            Else
                Dim dra() As DataRow = dt.Select(String.Format("terms_name like '{0}'", txt_terms_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "terms_code,terms_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_terms_id.RowData = dr
                txt_terms_id.Value = dr("terms_id")
                txt_terms_id.Text = dr("terms_name")
                txt_nodays.DecimalValue = dr("nodays")
                If dr("fixed_day") = "1" Then
                    txt_nodays.Enabled = False
                Else
                    txt_nodays.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub dgEwt_SelectionChanged(sender As Object, e As EventArgs) Handles dgEwt.SelectionChanged
        Dim dt = dgEwt.DataSource
        bind_control(dgEwt, "ewt_id", dt, panelEwt)
    End Sub
    Private Sub txt_ewt_code_Leave(sender As Object, e As EventArgs) Handles txt_ewt_code.Leave
        Dim dt As DataTable = FsQuery("select * from lib_acc_ewt")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("ewt_code like '{0}'", txt_ewt_code.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "ewt_code,ewt_name", "100,400")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_ewt_code.RowData = dr
                txt_ewt_code.Value = dr("ewt_id")
                txt_ewt_code.Text = dr("ewt_code")
                txt_ewt_name.Text = dr("ewt_name")
                txt_tax_rate.DecimalValue = dr("tax_rate")
            End If
        End If
    End Sub
    Private Sub dgFTax_SelectionChanged(sender As Object, e As EventArgs) Handles dgFTax.SelectionChanged
        Dim dt = dgFTax.DataSource
        bind_control(dgFTax, "final_tax_id", dt, panelFTax)
    End Sub
    Private Sub txt_final_tax_code_Leave(sender As Object, e As EventArgs) Handles txt_final_tax_code.Leave
        Dim dt As DataTable = FsQuery("select * from lib_acc_final_tax")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("final_tax_code like '{0}'", txt_final_tax_code.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "final_tax_code,final_tax_name", "100,400")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_final_tax_code.RowData = dr
                txt_final_tax_code.Value = dr("final_tax_id")
                txt_final_tax_code.Text = dr("final_tax_code")
                txt_final_tax_name.Text = dr("final_tax_name")
                txt_final_tax_rate.DecimalValue = dr("final_tax_rate")
            End If
        End If
    End Sub
    Private Sub txt_industry_id_Leave(sender As Object, e As EventArgs)
        Dim dt As DataTable = FsQuery("select * from lib_erp_industry")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("industry_name like '{0}'", txt_industry_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "industry_code,industry_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_industry_id.RowData = dr
                txt_industry_id.Value = dr("industry_id")
                txt_industry_id.Text = dr("industry_name")
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        general_library_report_filter.ShowDialog()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        toggleDelete(dgEwt, "general_ewt_id", "ewt_name", "sel1", ds)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        toggleDelete(dgFTax, "final_tax_id", "final_tax_name", "sel2", ds, "deleted1")
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim pk As String = "general_id"
        Dim colName As String = "general_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        Dim mainDB As String = _serverDBMain
        Dim tblTrans As String = "trans_header"
        Dim pkTrans As String = "trans_id"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_erp_general"
        Dim pk_delete As String = "general_id"

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
            str = ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "general_id")
            FsQuery(str)
            init_load()
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
            bs.Filter = selectQuery.Substring(4)
            'Dim dt As DataTable = dgMain.DataSource
            'Dim selectedRows = MyDT.[Select](selectQuery.Substring(4), txtsearch.TextSource & " ASC")
            'If selectedRows.Length > 0 Then
            '    'If currentSearchIndex >= selectedRows.Length Then
            '    '    currentSearchIndex = 0
            '    'End If
            '    'Dim selectedID As String = selectedRows(currentSearchIndex).Item("general_id").ToString
            '    'dgMain.ClearSelection()
            '    'For Each row As DataGridViewRow In dgMain.Rows
            '    '    If row.Cells("general_id").Value.ToString = selectedID Then
            '    '        row.Selected = True
            '    '        Dim tmp_index = dt.Rows.IndexOf(selectedRows(currentSearchIndex))
            '    '        dgMain.FirstDisplayedScrollingRowIndex = tmp_index
            '    '    End If
            '    'Next
            '    Dim newDT = MyDT.Clone
            '    newDT.Clear()
            '    For Each dr In selectedRows
            '        newDT.ImportRow(dr)
            '    Next
            '    dgMain.DataSource = newDT
            'Else
            '    dgMain.DataSource = MyDT
            'End If
            'Else
            '    dgMain.DataSource = MyDT
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
        If generalNameFocus Then
            Dim general_name = Regex.Replace(txt_general_name.Text.ToString.Trim, "[^A-Za-z0-9] ", "")
            txt_general_name_bir.Text = general_name
        End If
    End Sub
    Private Sub txt_email_add_Leave(sender As Object, e As EventArgs) Handles txt_email_add.Leave
        TabControl1.Focus()
    End Sub
    Private Sub txt_ewt_name_Leave(sender As Object, e As EventArgs) Handles txt_ewt_name.Leave
        TabControl1.Focus()
    End Sub


    Private Sub txt_general_name_bir_Leave(sender As Object, e As EventArgs) Handles txt_general_name_bir.Leave
        Dim general_name = Regex.Replace(txt_general_name_bir.Text.ToString.Trim, "[^A-Za-z0-9 ]", "")
        txt_general_name_bir.Text = general_name
    End Sub

    Private Sub txt_general_name_Enter(sender As Object, e As EventArgs) Handles txt_general_name.Enter
        generalNameFocus = True
    End Sub

    Private Sub txt_general_name_Leave(sender As Object, e As EventArgs) Handles txt_general_name.Leave
        generalNameFocus = False
    End Sub

    Private Sub txt_general_name_TextChange(sender As Object, e As EventArgs) Handles txt_general_name.TextChange
        If generalNameFocus Then
            Dim general_name = Regex.Replace(txt_general_name.Text.ToString.Trim, "[^A-Za-z0-9 ]", "")
            txt_general_name_bir.Text = general_name
        End If
    End Sub
End Class