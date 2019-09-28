Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class SubContract_management
    Dim cls As New classCon
    Public Property current_index As Integer = 0
    Public sub_contract_ids As String
    Public Property Pa As subContract_multiple_viewer
    Dim trans_mode_det As String = ""
    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        If companyconfig.monthly_currency.Checked = True Then
        Else
            Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_currency")
            If dt.Rows.Count = 0 Then
                MsgBox("No record found.")
            Else
                Dim dr As DataRow = Nothing
                If dt.Rows.Count = 1 Then
                    dr = dt.Rows(0)
                Else
                    Dim dra() As DataRow = dt.Select("currency_code like '" & txt_general_id.Text.ToString.Replace("'", "''") & "'")
                    If dra.Count > 0 Then
                        dr = dra(0)
                    Else
                        browse.dt = dt
                        browse.format("Code,Name", "currency_code,currency_name", "140,240")
                        If browse.ShowDialog() = DialogResult.OK Then
                            If browse.dgview.SelectedRows.Count > 0 Then
                                dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                            End If
                        End If
                    End If
                End If
                If Not dr Is Nothing Then
                    txt_currency_id.RowData = dr
                    txt_currency_id.Value = dr("currency_id")
                    txt_currency_id.Text = dr("currency_code")
                    txt_exchange_rate.EditValue = 1
                    txt_based_rate.EditValue = 1
                End If
            End If
        End If
    End Sub
    Private Sub childLoader(ByVal id As String)
        If id = "" Then
            ds.Tables("trans_sub_contract_det").Clear()
        Else
            Dim sql As String = String.Format("SELECT a.sub_contract_det_id,a.sub_contract_id,a.subconid,a.sc_year,a.trans_date,a.description,a.amount,a.amount_based
                ,a.currency,a.currency_id,a.exchange_rate,a.based_rate,a.po_no,a.billed_amount,a.collected_amount,a.cons1,a.cons2,a.isPrior
                ,a.accomplishment,a.sub_contract_det_id_ref,a.department_id,a.general_id
                ,b.subconcode,b.subconname
                ,c.currency_code,c.currency_name
                ,d.department_code,d.department_name
                ,e.general_code,e.general_name
                FROM trans_sub_contract_det a
                LEFT JOIN {1}.lib_subcon b ON b.subConid = a.subconid
                LEFT JOIN {1}.lib_erp_currency c ON c.currency_id = a.currency_id
                LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id
                LEFT JOIN {1}.lib_erp_general e ON e.general_id = a.general_id
                WHERE a.sub_contract_id = '{2}'", _serverDBMain, _serverDBFS, id)
            'Dim sql As String = String.Format("SELECT * FROM {0}.trans_sub_contract_det where sub_contract_id={1}", _serverDBMain, id)
            Dim dt As DataTable = Query(sql)
            ds.Tables("trans_sub_contract_det").Clear()
            For Each dr As DataRow In dt.Rows
                ds.Tables("trans_sub_contract_det").ImportRow(dr)
            Next
            dgview.DataSource = ds.Tables("trans_sub_contract_det")
        End If
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If txt_project_id.Text = "" Or txt_general_id.Text = "" Then
            MsgBox("Incomplete details above!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        Else
            cls.cleaner(transpnl)
            txt_sub_contract_det_id.Text = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            trans_mode_det = "insert"
            btnremove.Hide()
            btninsert.Hide()
            btnupdate.Hide()
            btnOk.Show()
            btncancel.Show()
            transpnl.Enabled = True
            btnSave.Hide()
            btnNotSave.Hide()
            pnl_crud.Visible = False
        End If
    End Sub
    Private Sub toogle(ByVal bool As Boolean)
        If bool = False Then
            btnAdd.Hide()
            btnEdit.Hide()
            btnPrint.Hide()
            btnSearch.Hide()
            btnPrevious.Hide()
            btnNext.Hide()
            btnSave.Show()
            btnNotSave.Show()
            btnremove.Show()
            btninsert.Show()
            btnupdate.Show()
            btnOk.Hide()
            btncancel.Hide()
        Else
            btnAdd.Show()
            btnEdit.Show()
            btnPrint.Show()
            btnSearch.Show()
            btnPrevious.Show()
            btnNext.Show()
            btnSave.Hide()
            btnNotSave.Hide()
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txt_project_id.Text = "" Or txt_general_id.Text = "" Or txt_sub_contract_det_id.Text = "" Then
            MsgBox("Incomplete details above!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)

        Else
            If ifNull(dgview.SelectedRows(0).Cells("sub_contract_det_id").Value, "").ToString = "" Then
                MsgBox("Select  record First", MsgBoxStyle.OkOnly + vbInformation)
            Else
                btnremove.Hide()
                btninsert.Hide()
                btnupdate.Hide()
                btnOk.Show()
                btncancel.Show()
                transpnl.Enabled = True
                btnSave.Hide()
                btnNotSave.Hide()
                trans_mode_det = "update"
                pnl_crud.Visible = False
            End If
        End If
    End Sub
    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click

        dgview.DataSource = ds.Tables("trans_sub_contract_det")
        toggleDelete(dgview, "sub_contract_det_id", "general_name", "sel", ds)

    End Sub
    Private Shared Sub toggleDelete(ByVal dg As DataGridView, ByVal pk As String, ByVal name As String, ByVal sel As String, ByVal ds As DataSet, Optional deleted As String = "deleted")
        Dim dtOfdg As DataTable = dg.DataSource
        Dim dt_name As String = dtOfdg.TableName

        Dim dt As New DataTable
        dt.TableName = dt_name
        dt = dtOfdg.Copy

        Dim arr_id = getCheckedGrid(pk, name, sel, dg, "", False)
        If arr_id.Length > 0 Then
            For i As Integer = 0 To arr_id.Length - 1
                Dim dr As DataRow = dt.Select(pk & " = '" & arr_id(i) & "'")(0)
                dt.Rows.Remove(dr)
            Next
        End If
        ds.Tables(dt_name).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dt_name).ImportRow(row)
        Next
        dg.DataSource = ds.Tables(dt_name)
        loadDTToDG(dg, ds.Tables(dt_name))
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txt_project_id.Text = "" Or txt_general_id.Text = "" Or txt_sub_contract_det_id.Text = "" Then
            MsgBox("Incomplete details above!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            txt_sub_contract_det_id.Text = ""
        Else
            'If trans_mode_det = "update" Then
            '    Dim id_count As String = txt_subcon_management_id.Text
            '    sub_contract_ids = id_count
            'Else
            '    Dim sql As String = String.Format("select max(sub_contract_id)+1 from {0}.trans_sub_contract", _serverDBMain)
            '    Dim dt As DataTable = Query(sql)
            '    If dt.Rows.Count >= 0 Then
            '        sub_contract_ids = dt.Rows(0)(0).ToString
            '    End If
            'End If
            If trans_mode_det = "update" Then
                Dim drs = ds.Tables("trans_sub_contract_det").Select(String.Format("sub_contract_det_id = '{0}'", txt_sub_contract_det_id.Text))
                If drs.Length > 0 Then
                    Dim dr As DataRow = drs(0)
                    dr.Item("sub_contract_det_id") = txt_sub_contract_det_id.Text
                    dr.Item("sub_contract_id") = txt_subcon_management_id.Text
                    dr.Item("subconid") = txt_subconcodes.Value
                    dr.Item("general_id") = txt_general_id.Value
                    dr.Item("general_code") = txt_general_id.Text
                    dr.Item("general_name") = txt_general_name.Text
                    dr.Item("trans_date") = txt_contract_date.Value
                    dr.Item("description") = txt_project_name_det.Text
                    dr.Item("amount") = txt_contract_amount.EditValue
                    dr.Item("amount_based") = txt_contract_amount_based.EditValue
                    dr.Item("currency_id") = txt_currency_id.Value
                    dr.Item("exchange_rate") = txt_exchange_rate.EditValue
                    dr.Item("based_rate") = txt_based_rate.EditValue
                    dr.Item("po_no") = txt_po_no.Text
                    dr.Item("billed_amount") = txt_billed_amount.EditValue
                    dr.Item("collected_amount") = txt_collected_amount.EditValue
                    dr.Item("cons1") = txt_date_from.Value
                    dr.Item("cons2") = txt_date_to.Value
                    dr.Item("isPrior") = txt_ispriordate.Checked
                    dr.Item("accomplishment") = txt_accomplishment_amount.EditValue
                    dr.Item("department_id") = txt_department_id.Value
                    dr.Item("subconcode") = txt_subconcodes.Text
                    dr.Item("subconname") = txt_subconnames.Text
                    dr.Item("currency_code") = txt_currency_id.Text
                    dr.Item("department_code") = txt_department_id.Text
                End If
            Else
                Dim dr As DataRow = ds.Tables("trans_sub_contract_det").NewRow
                dr.Item("sub_contract_det_id") = txt_sub_contract_det_id.Text
                dr.Item("sub_contract_id") = txt_subcon_management_id.Text
                dr.Item("subconid") = txt_subconcodes.Value
                dr.Item("general_id") = txt_general_id.Value
                dr.Item("general_code") = txt_general_id.Text
                dr.Item("general_name") = txt_general_name.Text
                dr.Item("trans_date") = txt_contract_date.Value
                dr.Item("description") = txt_project_name_det.Text
                dr.Item("amount") = txt_contract_amount.EditValue
                dr.Item("amount_based") = txt_contract_amount_based.EditValue
                dr.Item("currency_id") = txt_currency_id.Value
                dr.Item("exchange_rate") = txt_exchange_rate.EditValue
                dr.Item("based_rate") = txt_based_rate.EditValue
                dr.Item("po_no") = txt_po_no.Text
                dr.Item("billed_amount") = txt_billed_amount.EditValue
                dr.Item("collected_amount") = txt_collected_amount.EditValue
                dr.Item("cons1") = txt_date_from.Value
                dr.Item("cons2") = txt_date_to.Value
                dr.Item("isPrior") = txt_ispriordate.Checked
                dr.Item("accomplishment") = txt_accomplishment_amount.EditValue
                dr.Item("department_id") = txt_department_id.Value
                dr.Item("subconcode") = txt_subconcodes.Text
                dr.Item("subconname") = txt_subconnames.Text
                dr.Item("currency_code") = txt_currency_id.Text
                dr.Item("department_code") = txt_department_id.Text
                ds.Tables("trans_sub_contract_det").Rows.Add(dr)
            End If
            toogle(False)
            cls.cleaner(transpnl)
            transpnl.Enabled = False
            txt_sub_contract_det_id.Text = ""
            pnl_crud.Visible = True
        End If
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        cls.cleaner(transpnl)
        txt_currency_id.Text = ""
        transpnl.Enabled = False
        btnremove.Show()
        btninsert.Show()
        btnupdate.Show()
        btnOk.Hide()
        btncancel.Hide()
        btnSave.Show()
        pnl_crud.Visible = True
        btnNotSave.Show()
        'trans_mode_det = ""
        gridRowFocus(dgview, {"sub_contract_det_id", ""})
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txt_project_id.Focus()

        Dim where As String = ""
        Dim currency As New DataTable
        Dim _tmp_sql As String = "select a.currency_id,a.currency_code,a.currency_name " &
            ",b.exchange_rate,b.based_rate " &
            "from lib_erp_currency a " &
            "inner join (select a.currency_id,a.exchange_rate,a.based_rate " &
                    "from lib_erp_currency_rate a " &
                    "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " &
                            "FROM lib_erp_currency_rate " & where &
                    "group by currency_id) b on a.currency_id = b.currency_id " &
                "and a.effectivitydate = b.effectivitydate) b on a.currency_id = b.currency_id"
        currency = FsQuery(_tmp_sql)
        If currency.Rows.Count = 0 Then
            MsgBox(String.Format("No Currency Rate Setup for the {0}.", If(main.Sys_Default.Rows(0)("monthly_currency"), "Month", "Day")))
        Else
            pnl_crud.Visible = True
            toogle(False)
            cls.cleaner(clientpnl)
            clientpnl.Enabled = True
            txt_subcon_management_id.Text = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            txt_pm_year.Value = Today.Year
            ds.Tables("trans_sub_contract_det").Clear()
        End If

    End Sub

    Private Sub txt_project_id_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_project")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("project_code like '" & txt_project_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "project_code,project_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_project_id.RowData = dr
                txt_project_id.Value = dr("project_id")
                txt_project_id.Text = dr("project_code")
                txt_project_name.Text = dr("project_name")
            End If
        End If
    End Sub
    Private Sub txt_general_id_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_general")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("general_code like '" & txt_general_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "general_code,general_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_general_id.RowData = dr
                txt_general_id.Value = dr("general_id")
                txt_general_id.Text = dr("general_code")
                txt_general_name.Text = dr("general_name")
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs)
        toogle(False)
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txt_project_id.Focus()
        toogle(False)
        clientpnl.Enabled = True
        pnl_crud.Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim dts As DataTable = ds.Tables("trans_sub_contract_det")
        If dts.Rows.Count > 0 Then
            Try
                If MsgBox("You want to save ?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
                    pnl_crud.Visible = False
                    If txt_project_id.Text = "" Or txt_general_id.Text = "" Then
                        MsgBox("Incomplete details above!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                    Else
                        clientpnl.Enabled = False
                        transpnl.Enabled = False
                        toogle(True)
                        btnremove.Show()
                        btninsert.Show()
                        btnupdate.Show()
                        btnOk.Hide()
                        btncancel.Hide()
                        Dim project_management_id As String = txt_subcon_management_id.Text
                        Dim sc_year As Integer = txt_pm_year.Value
                        Dim project_id As String = txt_project_id.Value

                        Dim dic As New Dictionary(Of String, String)
                        dic.Add("sub_contract_id", txt_subcon_management_id.Value)
                        dic.Add("sc_year", sc_year)
                        dic.Add("project_id", project_id)
                        Dim qry = ""
                        If project_management_id.Contains("tmp_") Then
                            qry = ATGenerateQuery("Insert", "trans_sub_contract", dic, Environment.MachineName,
                                          Environment.UserName, main.log_id, project_management_id, "sub_contract_id")
                        Else
                            qry = ATGenerateQuery("Update", "trans_sub_contract", dic, Environment.MachineName,
                                          Environment.UserName, main.log_id, project_management_id, "sub_contract_id")
                        End If
                        Dim dt As DataTable = Query(qry)
                        If dt.Rows.Count > 0 Then
                            project_management_id = dt.Rows(0).Item("return_id")
                            saveChild(project_management_id)

                            Dim sqls As String = String.Format(" Select max(sub_contract_id)from {0}.trans_sub_contract", _serverDBMain)
                            Dim dtss As DataTable = Query(sqls)
                            txt_subcon_management_id.Text = dtss.Rows(0)(0).ToString
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        Else
            MsgBox("Insert data below first")
        End If
    End Sub
    Public Sub saveChild(ByVal id As String)
        Dim pm_years = txt_pm_year.Text
        Try
            Dim strInsert As String = ""
            Dim strUpdate As String = ""
            Dim strRemove As String = ""
            Dim lstInsert As List(Of String) = New List(Of String)
            Dim lstUpdate As List(Of String) = New List(Of String)
            Dim lstRemove As List(Of String) = New List(Of String)

            For Each dr As DataRow In ds.Tables("trans_sub_contract_det").Rows
                Dim sub_contract_det_id As String = ifNull(dr("sub_contract_det_id"), "").ToString()
                Dim sub_contract_id As String = id
                Dim subconid As String = ifNull(dr("subconid"), "").ToString()
                Dim general_id As String = ifNull(dr("general_id"), "").ToString()
                Dim trans_date As String = CDate(If(ifNull(dr("trans_date"), "").ToString() = "", Today, dr("trans_date"))).ToString("yyyy-MM-dd")
                Dim description As String = ifNull(dr("description"), "").ToString()
                Dim amount As String = ifNull(dr("amount"), "").ToString()
                Dim amount_based As String = ifNull(dr("amount_based"), "").ToString()
                Dim currency_id As String = ifNull(dr("currency_id"), "").ToString()
                Dim exchange_rate As String = ifNull(dr("exchange_rate"), "").ToString()
                Dim based_rate As String = ifNull(dr("based_rate"), "").ToString()
                Dim po_no As String = ifNull(dr("po_no"), "").ToString()
                Dim billed_amount As String = ifNull(dr("billed_amount"), "").ToString()
                Dim collected_amount As String = ifNull(dr("collected_amount"), "").ToString()
                Dim cons1 As String = CDate(If(ifNull(dr("cons1"), "").ToString() = "", Today, dr("cons1"))).ToString("yyyy-MM-dd")
                Dim cons2 As String = CDate(If(ifNull(dr("cons2"), "").ToString() = "", Today, dr("cons2"))).ToString("yyyy-MM-dd")
                Dim isPrior As String = If(CBool(ifNull(dr("isPrior"), 0)), "1", "0")
                Dim accomplishment As String = ifNull(dr("accomplishment"), "").ToString()
                Dim department_id As String = ifNull(dr("department_id"), "").ToString()
                Dim deleted As Boolean = CBool(ifNull(dr("deleted"), 0))

                Dim project_id As String = txt_project_id.Value
                Dim sc_year As Integer = txt_pm_year.Value

                Dim dic As New Dictionary(Of String, String)
                dic.Add("sub_contract_det_id", sub_contract_det_id)
                dic.Add("sub_contract_id", sub_contract_id)
                dic.Add("subconid", subconid)
                dic.Add("general_id", general_id)
                dic.Add("trans_date", trans_date)
                dic.Add("description", description)
                dic.Add("amount", amount)
                dic.Add("amount_based", amount_based)
                dic.Add("currency_id", currency_id)
                dic.Add("exchange_rate", exchange_rate)
                dic.Add("based_rate", based_rate)
                dic.Add("po_no", po_no)
                dic.Add("billed_amount", billed_amount)
                dic.Add("collected_amount", collected_amount)
                dic.Add("cons1", cons1)
                dic.Add("cons2", cons2)
                dic.Add("isPrior", isPrior)
                dic.Add("accomplishment", accomplishment)
                dic.Add("department_id", department_id)
                dic.Add("project_id", project_id)
                dic.Add("sc_year", sc_year)


                If sub_contract_det_id.Contains("tmp_") Or sub_contract_det_id = "" Then
                    If Not deleted Then
                        strInsert &= ATGenerateQuery("Insert", "trans_sub_contract_det", dic, Environment.MachineName, Environment.UserName, main.log_id, sub_contract_det_id, "sub_contract_det_id")
                    End If
                Else
                    If deleted Then
                        lstRemove.Add(sub_contract_det_id)
                    Else
                        strUpdate &= ATGenerateQuery("Update", "trans_sub_contract_det", dic, Environment.MachineName, Environment.UserName, main.log_id, sub_contract_det_id, "sub_contract_det_id")
                    End If
                End If
            Next
            If strInsert <> "" Then
                Query(strInsert)
            End If
            If strUpdate <> "" Then
                Query(strUpdate)
            End If
            If lstRemove.Count > 0 Then
                strRemove = ATGenerateQuery("Remove", "trans_sub_contract_det", Nothing, Environment.MachineName, Environment.UserName, main.log_id, String.Join(",", lstRemove), "trans_sub_contract_det")
                Query(strRemove)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Friend Sub loader()
        If txt_subcon_management_id.Text.Length >= 5 Then
            Dim sql As String = String.Format("SELECT 
    a.sub_contract_det_id,
    a.sub_contract_id,
	a.trans_date,
	a.currency,
	b.general_id,
	b.general_name,
	d.project_name,
    d.project_id,
	a.department_id,
    a.description,
	a.po_no,
	a.amount,
	a.amount_based,
	a.cons1,
    a.sc_year,
	a.cons2,
	a.billed_amount,
	a.collected_amount,
    a.exchange_rate,
    a.based_rate,
    a.supcd,
    a.currency_id,
    a.sub_contract_id
    FROM {0}.trans_sub_contract_det a
    inner JOIN {1}.lib_erp_general b
    on a.general_id= b.general_id
   
    inner join {1}.lib_erp_project d
    on a.project_id=d.project_id  where a.sub_contract_id={2}", _serverDBMain, _serverDBFS, subContract_multiple_viewer.select_id)
            Dim dt As DataTable = Query(sql)
            ds.Tables("trans_sub_contract_det").Clear()
            For Each dr As DataRow In dt.Rows
                ds.Tables("trans_sub_contract_det").ImportRow(dr)
            Next

        Else
            ds.Tables("trans_sub_contract_det").Clear()
        End If

    End Sub
    Private Sub btnNotSave_Click_1(sender As Object, e As EventArgs) Handles btnNotSave.Click
        If MsgBox("Are you sure?, You want to Cancel ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            ' headerCleaner()
            clientpnl.Enabled = False
            transpnl.Enabled = False
            toogle(True)
            btnremove.Show()
            btninsert.Show()
            btnupdate.Show()
            btnOk.Hide()
            btncancel.Hide()
            pnl_crud.Visible = False
            refreshRecord()
            '   ' cls.cleaner(transpnl)
            '   Dim sql As String = String.Format(" Select  a.sub_contract_id,a.sc_year,b.project_code,b.project_name
            '   from {0}.trans_sub_contract a
            '   inner join {1}.lib_erp_project b
            '   On a.project_id= b.project_id
            '   INNER JOIN {0}.trans_sub_contract_det c
            '   On a.sub_contract_id=c.sub_contract_id
            '    ORDER BY a.sub_contract_id DESC 
            '", _serverDBMain, _serverDBFS)
            '   Try
            '       Dim dt As DataTable = Query(sql)
            '       If current_index >= dt.Rows.Count Then
            '           MsgBox("Last Record")
            '       Else
            '           current_index += 1
            '           If dt.Rows.Count >= current_index Then
            '               txt_subcon_management_id.Text = dt.Rows(current_index)(0).ToString
            '           End If
            '       End If
            '   Catch ex As Exception
            '       MsgBox(ex.Message.ToString)
            '   End Try
        End If
    End Sub
    Private Sub headerCleaner()
        Try
            txt_project_id.Text = ""
            txt_general_id.Text = ""
            txt_project_name.Text = ""
            txt_general_name.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim viewer As New subContract_multiple_viewer
        viewer.MyParent = Me
        viewer.ShowDialog()
    End Sub
    Private Sub txt_project_management_id_TextChange(sender As Object, e As EventArgs) Handles txt_subcon_management_id.TextChange
        Dim sql As String = String.Format("SELECT a.sub_contract_id,a.sc_year,a.project_id
                        ,b.project_code,b.project_name
                        FROM trans_sub_contract a
                        LEFT JOIN {1}.lib_erp_project b ON b.project_id = a.project_id
                        WHERE a.sub_contract_id='{2}' ", _serverDBMain, _serverDBFS, ifNull(txt_subcon_management_id.Text, 0))


        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count > 0 Then
            txt_pm_year.Value = dt.Rows(0)("sc_year").ToString
            txt_project_id.Value = dt.Rows(0)("project_id").ToString
            txt_project_id.Text = dt.Rows(0)("project_code").ToString
            txt_project_name.Text = dt.Rows(0)("project_name").ToString
        Else
            txt_pm_year.Value = Today.Year
            txt_project_id.Value = ""
            txt_project_id.Text = ""
            txt_project_id.RowData = Nothing
            txt_project_name.Text = ""
            txt_general_id.Value = ""
            txt_general_id.Text = ""
            txt_general_id.RowData = Nothing
            txt_general_name.Text = ""
            cls.cleaner(transpnl)
        End If
        Dim id As String = txt_subcon_management_id.Text
        childLoader(id)
    End Sub

    Friend Sub initialize_record(ByVal dr As DataRow)
        NewControls.bindControl(clientpnl, dr)
    End Sub
    Friend Sub setCurrentRecord(ByVal i As Integer)
        Dim dr As DataRow = ds.Tables("trans_sub_contract").Rows(i)
        initialize_record(dr)
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Try
            If current_index = 0 Then
                MsgBox("first record")
            Else
                Dim sql As String = String.Format(" Select  a.sub_contract_id,a.sc_year,b.project_code,b.project_name
            from {0}.trans_sub_contract a
            inner join {1}.lib_erp_project b
            On a.project_id= b.project_id
            INNER JOIN {0}.trans_sub_contract_det c
            On a.sub_contract_id=c.sub_contract_id
             GROUP BY sub_contract_id
         ", _serverDBMain, _serverDBFS)
                Dim dt As DataTable = Query(sql)
                current_index -= 1
                If dt.Rows.Count >= current_index Then
                    txt_subcon_management_id.Text = dt.Rows(current_index)(0).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Friend Sub loaders()
        Dim sql As String = String.Format(" Select  a.sub_contract_id,a.sc_year,b.project_code,b.project_name
    from {0}.trans_sub_contract a
    inner join {1}.lib_erp_project b
    On a.project_id= b.project_id
    INNER JOIN {0}.trans_sub_contract_det c
    On a.sub_contract_id=c.sub_contract_id
     GROUP BY sub_contract_id
         ", _serverDBMain, _serverDBFS)
        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_sub_contract").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_sub_contract").ImportRow(dr)
        Next
    End Sub
    Private Sub dgview_SelectionChanged(sender As Object, e As EventArgs) Handles dgview.SelectionChanged
        'txt_project_management_det_id.Text = "0"
        If dgview.RowCount = 0 Then
            NewControls.clearControl(transpnl)
            Exit Sub
        End If
        If dgview.SelectedRows.Count = 0 Then
            NewControls.clearControl(transpnl)
            Exit Sub
        End If
        Dim sel As String = ifNull(dgview.SelectedRows(0).Cells("sub_contract_det_id").Value, "").ToString
        txt_sub_contract_det_id.Text = ifNull(dgview.SelectedRows(0).Cells("sub_contract_det_id").Value, "").ToString
        Dim tmp_dr = ds.Tables("trans_sub_contract_det").Select("sub_contract_det_id= '" & sel & "'")
        Dim dr As DataRow = Nothing
        If tmp_dr.Count > 0 Then
            dr = tmp_dr(0)
            NewControls.bindControl(transpnl, dr)
            txt_general_id.Value = dr("general_id")
            txt_general_id.Text = dr("general_code")
            txt_general_name.Text = dr("general_name")
        End If
        sel = ""
        'If Not trans_mode_det = "" Then
        '    Exit Sub
        'End If
    End Sub

    Private Sub txt_contract_amount_EditValueChanged(sender As Object, e As EventArgs) Handles txt_contract_amount.EditValueChanged
        Dim exchange_rate As Decimal = ifNull(txt_exchange_rate.EditValue, 0)
        Dim base_rate As Decimal = ifNull(txt_based_rate.EditValue, 0)
        Dim contruct_amount As Decimal = ifNull(txt_contract_amount.EditValue, 0)
        '  Dim contruct_cost As Decimal = ifNull(txt_contract_cost.EditValue, 0)
        '  Dim profit As Decimal = ifNull(txt_profit_amount.EditValue, 0)
        Dim accomplishment As Decimal = ifNull(txt_accomplishment_amount.EditValue, 0)
        If exchange_rate <> 0 And base_rate <> 0 Then
            txt_contract_amount_based.EditValue = contruct_amount * (exchange_rate / base_rate)
            'profit = contruct_amount - contruct_cost

        End If
        'txt_profit_amount.EditValue = profit
        txt_accomplishment_amount.EditValue = accomplishment
        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txt_ispriordate_CheckedChanged(sender As Object, e As EventArgs) Handles txt_ispriordate.CheckedChanged
        If txt_ispriordate.Checked Then
            txt_billed_amount.Enabled = False
            txt_collected_amount.Enabled = False
            txt_contract_amount.Enabled = False
            txt_contract_amount_based.Enabled = False

            txt_billed_amount.Text = 0.00
            txt_collected_amount.Text = 0.00
            txt_contract_amount.Text = 0.00
            txt_contract_amount_based.Text = 0.00


        Else
            txt_billed_amount.Enabled = True
            txt_collected_amount.Enabled = True
            txt_contract_amount.Enabled = True
            txt_contract_amount_based.Enabled = True
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim sql As String = String.Format(" Select  a.sub_contract_id,a.sc_year,b.project_code,b.project_name
            from {0}.trans_sub_contract a
            inner join {1}.lib_erp_project b
            On a.project_id= b.project_id
            INNER JOIN {0}.trans_sub_contract_det c
            On a.sub_contract_id=c.sub_contract_id
             GROUP BY sub_contract_id
         ", _serverDBMain, _serverDBFS)
        Try
            Dim dt As DataTable = Query(sql)
            If current_index = dt.Rows.Count Then
                MsgBox("Last Record")
            Else
                current_index += 1
                If dt.Rows.Count >= current_index Then
                    txt_subcon_management_id.Text = dt.Rows(current_index)(0).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub 

    Private Sub SubContract_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshRecord()
    End Sub
    Public Sub refreshRecord()
        Dim sqls As String = String.Format(" Select max(sub_contract_id) AS sub_contract_id
            from {0}.trans_sub_contract", _serverDBMain)
        Dim dts As DataTable = Query(sqls)
        txt_subcon_management_id.Text = dts.Rows(0)("sub_contract_id").ToString

        Dim sql As String = String.Format("SELECT a.sub_contract_id,a.sc_year,a.project_id
                        ,b.project_code,b.project_name
                        FROM trans_sub_contract a
                        LEFT JOIN {1}.lib_erp_project b ON b.project_id = a.project_id
                        WHERE a.sub_contract_id='{2}' ", _serverDBMain, _serverDBFS, ifNull(txt_subcon_management_id.Text, 0))

        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count > 0 Then
            txt_pm_year.Value = dt.Rows(0)("sc_year").ToString
            txt_project_id.Value = dt.Rows(0)("project_id").ToString
            txt_project_id.Text = dt.Rows(0)("project_code").ToString
            txt_project_name.Text = dt.Rows(0)("project_name").ToString
        Else
            txt_pm_year.Value = Today.Year
            txt_project_id.Value = ""
            txt_project_id.Text = ""
            txt_project_id.RowData = Nothing
            txt_project_name.Text = ""
            txt_general_id.Value = ""
            txt_general_id.Text = ""
            txt_general_id.RowData = Nothing
            txt_general_name.Text = ""
            cls.cleaner(transpnl)
        End If
        Dim id As String = txt_subcon_management_id.Text
        childLoader(id)
    End Sub

    Private Sub SubContract_management_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnAdd)                'F2
        dicShortCut.Add(114, btnEdit)               'F3
        dicShortCut.Add(115, btnNotSave)             'F4
        dicShortCut.Add(116, btnPrint)             'F5
        dicShortCut.Add(117, btnSearch)              'F6
        dicShortCut.Add(118, btnPrevious)           'F7
        dicShortCut.Add(119, btnNext)               'F8

        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn As Button = dicShortCut.Item(e.KeyCode)
            If btn.Enabled And btn.Visible Then
                btn.PerformClick()
                Return
            End If
        End If
    End Sub

    Private Sub txt_subconcode_Leave(sender As Object, e As EventArgs) Handles txt_subconcodes.Leave
        If Me.txt_subconcodes.Text = String.Empty Then
        Else
            Dim dt As DataTable = FsQuery("SELECT * FROM lib_subCOn")
            If dt.Rows.Count = 0 Then
                MsgBox("No record found.")
            Else
                Dim dr As DataRow = Nothing
                If dt.Rows.Count = 1 Then
                    dr = dt.Rows(0)
                Else
                    Dim dra() As DataRow = dt.Select("subconcode like '" & txt_subconcodes.Text.ToString.Replace("'", "''") & "'")
                    If dra.Count > 0 Then
                        dr = dra(0)
                    Else
                        browse.dt = dt
                        browse.format("Code,Name", "subconcode,subconname", "140,240")
                        If browse.ShowDialog() = DialogResult.OK Then
                            If browse.dgview.SelectedRows.Count > 0 Then
                                dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                            End If
                        End If
                    End If
                End If
                If Not dr Is Nothing Then
                    txt_subconcodes.RowData = dr
                    txt_subconcodes.Value = dr("subconid")
                    txt_subconcodes.Text = dr("subconcode")
                    txt_subconnames.Text = dr("subconname")

                End If
            End If
        End If

    End Sub

    Private Sub txt_department_id_Leave(sender As Object, e As EventArgs) Handles txt_department_id.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_department")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("department_code like '" & txt_department_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "department_code,department_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_department_id.RowData = dr
                txt_department_id.Value = dr("department_id")
                txt_department_id.Text = dr("department_code")
            End If
        End If
    End Sub
End Class