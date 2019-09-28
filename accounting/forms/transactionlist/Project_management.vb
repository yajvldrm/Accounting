Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class Project_management
    Public Property CurrentRecord As DataRow
    Dim id As String
    Public Property current_index As Integer = 0
    Dim trans_mode_det As String = ""
    Dim cls As New classCon
    Private Sub childLoader(ByVal id As String)
        Dim sql As String = String.Format("SELECT a.project_management_det_id,a.project_management_id,a.isPriorDate,a.trans_date,a.contract_date
        ,a.currency_id,a.exchange_rate,a.based_rate,a.po_no,a.project_name,a.date_from,a.date_to,a.contract_amount,a.contract_amount_based
        ,a.contract_cost,a.contract_cost_based,a.profit_amount,a.profit_amount_based,a.accomplishment_amount,a.accomplishment_amount_based
        ,a.billed_amount,a.billed_amount_based,a.collected_amount,a.collected_amount_based,a.insured_with,b.currency_code,b.currency_name
        ,a.department_id,c.department_code,c.department_name
        FROM trans_project_management_det a
        LEFT JOIN {0}.lib_erp_currency b ON b.currency_id = a.currency_id
        LEFT JOIN {0}.lib_erp_department c ON c.department_id = a.department_id
        WHERE a.project_management_id = '{1}'", _serverDBFS, id)
        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_project_management_det").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_project_management_det").ImportRow(dr)
        Next
        dgview.DataSource = ds.Tables("trans_project_management_det")
    End Sub
    Friend Sub loader()
        ds.Tables("trans_project_management").Clear()
        Dim sql As String = String.Format("SELECT a.project_management_id,a.pm_year,a.general_id,a.project_id
        ,b.general_code,b.general_name,c.project_code,c.project_name
        FROM trans_project_management a
        LEFT JOIN {0}.lib_erp_general b ON b.general_id = a.general_id
        LEFT JOIN {0}.lib_erp_project c on c.project_id=a.project_id
         ", _serverDBFS)
        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_project_management").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_project_management").ImportRow(dr)
        Next
    End Sub
    Friend Sub initialize_record(ByVal dr As DataRow)
        NewControls.bindControl(clientpnl, dr)
    End Sub
    Friend Sub setCurrentRecord(ByVal i As Integer)
        Dim dr As DataRow = ds.Tables("trans_project_management").Rows(i)
        initialize_record(dr)
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
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If txt_project_id.Text = "" Or txt_general_id.Text = "" Then
            MsgBox("Incomplete details above!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        Else
            cls.cleaner(transpnl)
            txt_project_management_det_id.Text = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            trans_mode_det = "insert"
            btnremove.Hide()
            btninsert.Hide()
            btnupdate.Hide()
            btnOk.Show()
            btncancel.Show()
            transpnl.Enabled = True
            btnSave.Hide()
            btnNotSave.Hide()
        End If
    End Sub
    Private Sub Project_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnremove.Hide()
        btninsert.Hide()
        btnupdate.Hide()
        btnOk.Hide()
        btncancel.Hide()
        loader()
        If ds.Tables("trans_project_management").Rows.Count > 0 Then
            current_index = ds.Tables("trans_project_management").Rows.Count - 1
            initialize_record(ds.Tables("trans_project_management").Rows(current_index))
        End If
    End Sub
    Private Sub btnNotSave_Click_1(sender As Object, e As EventArgs) Handles btnNotSave.Click, Myformheader1.Click
        If MsgBox("Are you sure?, You want to Cancel ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            headerCleaner()
            clientpnl.Enabled = False
            transpnl.Enabled = False
            toogle(True)
            btnremove.Show()
            btninsert.Show()
            btnupdate.Show()
            btnOk.Hide()
            btncancel.Hide()
            cls.cleaner(transpnl)
            ds.Tables("trans_project_management_det").Clear()
            childLoader(id)
            loader()
            If ds.Tables("trans_project_management").Rows.Count > 0 Then
                current_index = ds.Tables("trans_project_management").Rows.Count - 1
                initialize_record(ds.Tables("trans_project_management").Rows(current_index))
            End If
        End If
    End Sub
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click

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
            toogle(False)
            cls.cleaner(clientpnl)
            clientpnl.Enabled = True
            txt_project_management_id.Text = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            txt_pm_year.Value = Today.Year
        End If


    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click


        If txt_date_from.Value > txt_date_to.Value Then
            MsgBox("Invalid Contruction Date range ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            txt_date_from.Focus()
        Else
            If txt_project_name_det.Text.ToString = "" And ifNull(txt_department_id.Value, "").ToString = "" And txt_insured_with.Text = "" Then
                MsgBox("Incomplete data!", MsgBoxStyle.OkOnly + vbInformation)
            Else
                Dim project_management_id As String = txt_project_management_id.Text.ToString
                Dim project_management_det_id As String = txt_project_management_det_id.Text.ToString
                Dim isPriorDate As Boolean = txt_ispriordate.Checked
                Dim trans_date As DateTime = txt_trans_date.Value
                Dim contract_date As DateTime = txt_contract_date.Value
                Dim currency_id As String = txt_currency_id.Value
                Dim currency_code As String = txt_currency_id.Text
                Dim exchange_rate As Decimal = txt_exchange_rate.EditValue
                Dim based_rate As Decimal = txt_based_rate.EditValue
                Dim po_no As String = txt_po_no.Text
                Dim department_code As String = txt_department_id.Text
                Dim department_id As String = txt_department_id.Value
                Dim project_name As String = txt_project_name_det.Text
                Dim date_from As DateTime = txt_date_from.Value
                Dim date_to As DateTime = txt_date_to.Value
                Dim contract_amount As Decimal = txt_contract_amount.EditValue
                Dim contract_amount_based As Decimal = txt_contract_amount_based.EditValue
                Dim contract_cost As Decimal = txt_contract_cost.EditValue
                Dim contract_cost_based As Decimal = contract_cost * (exchange_rate / based_rate)
                Dim profit_amount As Decimal = txt_profit_amount.EditValue
                Dim profit_amount_based As Decimal = profit_amount * (exchange_rate / based_rate)
                Dim accomplishment_amount As Decimal = txt_accomplishment_amount.EditValue
                Dim accomplishment_amount_based As Decimal = accomplishment_amount * (exchange_rate / based_rate)
                Dim billed_amount As Decimal = txt_billed_amount.EditValue
                Dim billed_amount_based As Decimal = billed_amount * (exchange_rate / based_rate)
                Dim collected_amount As Decimal = txt_collected_amount.EditValue
                Dim collected_amount_based As Decimal = collected_amount * (exchange_rate / based_rate)
                Dim insured_with As String = txt_insured_with.Text
                If trans_mode_det = "insert" Then
                    Dim dr As DataRow = ds.Tables("trans_project_management_det").NewRow
                    dr.Item("project_management_id") = project_management_id
                    dr.Item("project_management_det_id") = project_management_det_id
                    dr.Item("isPriorDate") = isPriorDate
                    dr.Item("trans_date") = trans_date
                    dr.Item("contract_date") = contract_date
                    dr.Item("currency_id") = currency_id
                    dr.Item("currency_code") = currency_code
                    dr.Item("exchange_rate") = exchange_rate
                    dr.Item("based_rate") = based_rate
                    dr.Item("po_no") = po_no
                    dr.Item("department_code") = department_code
                    dr.Item("department_id") = department_id
                    dr.Item("project_name") = project_name
                    dr.Item("date_from") = date_from
                    dr.Item("date_to") = date_to
                    dr.Item("contract_amount") = contract_amount
                    dr.Item("contract_cost") = contract_cost
                    dr.Item("contract_cost_based") = contract_cost_based
                    dr.Item("profit_amount") = profit_amount
                    dr.Item("profit_amount_based") = profit_amount_based
                    dr.Item("accomplishment_amount") = accomplishment_amount
                    dr.Item("accomplishment_amount_based") = accomplishment_amount_based
                    dr.Item("billed_amount") = billed_amount
                    dr.Item("billed_amount_based") = billed_amount_based
                    dr.Item("collected_amount") = collected_amount
                    dr.Item("collected_amount_based") = collected_amount_based
                    dr.Item("insured_with") = insured_with
                    ds.Tables("trans_project_management_det").Rows.Add(dr)
                Else
                    Dim drs = ds.Tables("trans_project_management_det").Select(String.Format("project_management_det_id='{0}'", project_management_det_id))
                    If drs.Length > 0 Then
                        Dim dr As DataRow = drs(0)
                        dr.Item("project_management_id") = project_management_id
                        dr.Item("project_management_det_id") = project_management_det_id
                        dr.Item("isPriorDate") = isPriorDate
                        dr.Item("trans_date") = trans_date
                        dr.Item("contract_date") = contract_date
                        dr.Item("currency_id") = currency_id
                        dr.Item("currency_code") = currency_code
                        dr.Item("exchange_rate") = exchange_rate
                        dr.Item("based_rate") = based_rate
                        dr.Item("po_no") = po_no
                        dr.Item("department_code") = department_code
                        dr.Item("department_id") = department_id
                        dr.Item("project_name") = project_name
                        dr.Item("date_from") = date_from
                        dr.Item("date_to") = date_to
                        dr.Item("contract_amount") = contract_amount
                        dr.Item("contract_cost") = contract_cost
                        dr.Item("contract_cost_based") = contract_cost_based
                        dr.Item("profit_amount") = profit_amount
                        dr.Item("profit_amount_based") = profit_amount_based
                        dr.Item("accomplishment_amount") = accomplishment_amount
                        dr.Item("accomplishment_amount_based") = accomplishment_amount_based
                        dr.Item("billed_amount") = billed_amount
                        dr.Item("billed_amount_based") = billed_amount_based
                        dr.Item("collected_amount") = collected_amount
                        dr.Item("collected_amount_based") = collected_amount_based
                        dr.Item("insured_with") = insured_with
                    End If
                End If

                cls.cleaner(transpnl)
                transpnl.Enabled = False
                btnremove.Show()
                btninsert.Show()
                btnupdate.Show()
                btnOk.Hide()
                btncancel.Hide()
                btnSave.Show()
                btnNotSave.Show()
                txt_currency_id.Text = ""
                trans_mode_det = ""

            End If
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
        btnNotSave.Show()
        trans_mode_det = ""
        gridRowFocus(dgview, {"project_management_det_id", ""})
    End Sub

    Private Sub projectCode_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave
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
    Private Sub txtclientCode_Leave_1(sender As Object, e As EventArgs) Handles txt_general_id.Leave
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

    Private Sub Textbox5_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        If txt_currency_id.Text = Nothing Then
            MsgBox("Choose currency first!", vbInformation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
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
                    Dim dra() As DataRow = dt.Select("currency_code like '" & txt_currency_id.Text.ToString.Replace("'", "''") & "'")
                    If dra.Count > 0 Then
                        dr = dra(0)
                    Else
                        browse.dt = dt
                        browse.format("Code,Name", "currency_code,currency_name", "140,240")
                        If browse.ShowDialog = DialogResult.OK Then
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("You want to save ?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
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
                Dim project_management_id As String = txt_project_management_id.Text
                Dim pm_year As Integer = txt_pm_year.Value
                Dim project_id As String = txt_project_id.Value
                Dim general_id As String = txt_general_id.Value

                Dim dic As New Dictionary(Of String, String)
                dic.Add("project_management_id", project_management_id)
                dic.Add("pm_year", pm_year)
                dic.Add("project_id", project_id)
                dic.Add("general_id", general_id)
                Dim qry = ""
                If project_management_id.Contains("tmp_") Then
                    qry = ATGenerateQuery("Insert", "trans_project_management", dic, Environment.MachineName,
                                      Environment.UserName, main.log_id, project_management_id, "project_management_id")
                Else
                    qry = ATGenerateQuery("Update", "trans_project_management", dic, Environment.MachineName,
                                      Environment.UserName, main.log_id, project_management_id, "project_management_id")
                End If
                Dim dt As DataTable = Query(qry)
                If dt.Rows.Count > 0 Then
                    project_management_id = dt.Rows(0).Item("return_id")
                    saveChild(project_management_id)

                    txt_currency_id.Text = ""

                End If
            End If
        End If

    End Sub
    Private Sub saveChild(ByVal id As String)
        Dim strInsert As String = ""
        Dim strUpdate As String = ""
        Dim strRemove As String = ""
        Dim lstInsert As List(Of String) = New List(Of String)
        Dim lstUpdate As List(Of String) = New List(Of String)
        Dim lstRemove As List(Of String) = New List(Of String)

        For Each dr As DataRow In ds.Tables("trans_project_management_det").Rows

            Dim project_management_det_id As String = dr.Item("project_management_det_id")
            Dim project_management_id As String = id

            Dim isPriorDate As Boolean = dr.Item("isPriorDate")
            Dim trans_date As DateTime = dr.Item("trans_date")
            Dim contract_date As DateTime = dr.Item("contract_date")
            Dim currency_id As String = dr.Item("currency_id")

            Dim exchange_rate As Decimal = dr.Item("exchange_rate")
            Dim based_rate As Decimal = dr.Item("based_rate")
            Dim po_no As String = dr.Item("po_no")
            Dim department_code As String = dr.Item("department_code")
            Dim department_id As String = dr.Item("department_id")
            Dim project_name As String = dr.Item("project_name")
            Dim date_from As DateTime = dr.Item("date_from")
            Dim date_to As DateTime = dr.Item("date_to")
            Dim contract_amount As Decimal = dr.Item("contract_amount")
            Dim contract_amount_based As Decimal = dr.Item("contract_amount_based")
            Dim contract_cost As Decimal = dr.Item("contract_cost")
            Dim contract_cost_based As Decimal = dr.Item("contract_cost_based")
            Dim profit_amount As Decimal = dr.Item("profit_amount")
            Dim profit_amount_based As Decimal = dr.Item("profit_amount_based")
            Dim accomplishment_amount As Decimal = dr.Item("accomplishment_amount")
            Dim accomplishment_amount_based As Decimal = dr.Item("accomplishment_amount_based")
            Dim billed_amount As Decimal = dr.Item("billed_amount")
            Dim billed_amount_based As Decimal = dr.Item("billed_amount_based")
            Dim collected_amount As Decimal = dr.Item("collected_amount")
            Dim collected_amount_based As Decimal = dr.Item("collected_amount_based")
            Dim insured_with As String = dr.Item("insured_with")
            Dim deleted As Boolean = dr.Item("deleted")



            Dim dic As New Dictionary(Of String, String)
            dic.Add("project_management_det_id", project_management_det_id)
            dic.Add("project_management_id", project_management_id)
            dic.Add("isPriorDate", If(isPriorDate, "1", "0"))
            dic.Add("trans_date", trans_date.ToString("yyyy-MM-dd"))
            dic.Add("contract_date", contract_date.ToString("yyyy-MM-dd"))
            dic.Add("currency_id", currency_id)
            dic.Add("exchange_rate", exchange_rate)
            dic.Add("based_rate", based_rate)
            dic.Add("po_no", po_no)
            dic.Add("department_code", department_code)
            dic.Add("department_id", department_id)
            dic.Add("project_name", project_name)
            dic.Add("date_from", date_from.ToString("yyyy-MM-dd"))
            dic.Add("date_to", date_to.ToString("yyyy-MM-dd"))
            dic.Add("contract_amount", contract_amount)
            dic.Add("contract_amount_based", contract_amount_based)
            dic.Add("contract_cost", contract_cost)
            dic.Add("contract_cost_based", contract_cost_based)
            dic.Add("profit_amount", profit_amount)
            dic.Add("profit_amount_based", profit_amount_based)
            dic.Add("accomplishment_amount", accomplishment_amount)
            dic.Add("accomplishment_amount_based", accomplishment_amount_based)
            dic.Add("billed_amount", billed_amount)
            dic.Add("billed_amount_based", billed_amount_based)
            dic.Add("collected_amount", collected_amount)
            dic.Add("collected_amount_based", collected_amount_based)
            dic.Add("insured_with", insured_with)


            If project_management_det_id.Contains("tmp_") Then
                If Not deleted Then
                    strInsert &= ATGenerateQuery("Insert", "trans_project_management_det", dic, Environment.MachineName,
                                                 Environment.UserName, main.log_id, project_management_det_id, "project_management_det_id")
                End If
            Else
                If deleted Then
                    lstRemove.Add(project_management_det_id)
                Else
                    strUpdate &= ATGenerateQuery("Update", "trans_project_management_det", dic, Environment.MachineName,
                                                 Environment.UserName, main.log_id, project_management_det_id, "project_management_det_id")

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
            strRemove = ATGenerateQuery("Remove", "trans_project_management_det", Nothing, Environment.MachineName, Environment.UserName,
                                        main.log_id, String.Join(",", lstRemove), "project_management_det_id")
            Query(strRemove)
        End If
    End Sub
    Private Sub dgview_SelectionChanged(sender As Object, e As EventArgs) Handles dgview.SelectionChanged
        bind_control_det()
    End Sub
    Private Sub bind_control_det()
        If Not trans_mode_det = "" Then
            Exit Sub
        End If
        If dgview.RowCount = 0 Then
            NewControls.clearControl(transpnl)
            Exit Sub
        End If
        If dgview.SelectedRows.Count = 0 Then
            NewControls.clearControl(transpnl)
            Exit Sub
        End If
        Dim sel As String = ifNull(dgview.SelectedRows(0).Cells("project_management_det_id").Value, "").ToString
        Dim tmp_dr = ds.Tables("trans_project_management_det").Select("project_management_det_id = '" & sel & "'")
        Dim dr As DataRow = Nothing
        If tmp_dr.Count > 0 Then
            dr = tmp_dr(0)
            NewControls.bindControl(transpnl, dr)
        End If
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txt_project_name_det.Text = "" Then
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
        End If

    End Sub
    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        If txt_project_name_det.Text = "" Then
            MsgBox("Select  record First", MsgBoxStyle.OkOnly + vbInformation)
        Else
            toggleDelete(dgview, "project_management_det_id", "po_no", "sel", ds)
        End If

    End Sub

    Private Sub GenerateComputation()
        Dim exchange_rate As Decimal = ifNull(txt_exchange_rate.EditValue, 0)
        Dim base_rate As Decimal = ifNull(txt_based_rate.EditValue, 0)
        Dim contruct_amount As Decimal = ifNull(txt_contract_amount.EditValue, 0)
        Dim contruct_cost As Decimal = ifNull(txt_contract_cost.EditValue, 0)
        Dim profit As Decimal = ifNull(txt_profit_amount.EditValue, 0)
        Dim accomplishment As Decimal = ifNull(txt_accomplishment_amount.EditValue, 0)
        If exchange_rate <> 0 And base_rate <> 0 Then
            txt_contract_amount_based.EditValue = contruct_amount * (exchange_rate / base_rate)
            profit = txt_contract_amount_based.EditValue - contruct_cost
            If contruct_amount <> 0 Then
                accomplishment = (profit / txt_contract_amount_based.EditValue) * 100
            End If
        End If
        txt_profit_amount.EditValue = profit
        txt_accomplishment_amount.EditValue = accomplishment
        Try
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub txt_exchange_rate_EditValueChanged(sender As Object, e As EventArgs) Handles txt_exchange_rate.EditValueChanged, txt_contract_cost.EditValueChanged, txt_contract_amount.EditValueChanged, txt_based_rate.EditValueChanged
        GenerateComputation()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If current_index > 0 Then
            current_index -= 1
            setCurrentRecord(current_index)
        Else
            MsgBox("first record")
        End If
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If current_index < ds.Tables("trans_project_management").Rows.Count - 1 Then
            current_index += 1
            setCurrentRecord(current_index)
        Else
            MsgBox("Last Record")
        End If
    End Sub
    Private Sub txt_project_management_id_TextChange(sender As Object, e As EventArgs) Handles txt_project_management_id.TextChange
        id = txt_project_management_id.Text
        childLoader(id)
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim viewer As New project_management_multiple_viewer
        viewer.parent = Me
        viewer.ShowDialog()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        toogle(False)
        clientpnl.Enabled = True
    End Sub
    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        ' conts_date_validations()
    End Sub
    'Private Sub conts_date_validations()
    '    Try
    '        Dim d = txt_date_from.Value > txt_date_to.Value
    '        If d = True Then

    '            MsgBox("Invalid Contruction Date range ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
    '            txt_date_from.Focus()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    End Try
    'End Sub
    Private Sub txt_date_to_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_to.ValueChanged
        'conts_date_validations()
    End Sub
    Private Sub txt_date_from_Leave(sender As Object, e As EventArgs)
        'conts_date_validations()
    End Sub
    Private Sub txt_date_to_Leave_1(sender As Object, e As EventArgs) Handles txt_date_to.Leave
        'conts_date_validations()
    End Sub
    Private Sub txt_ispriordate_CheckedChanged(sender As Object, e As EventArgs) Handles txt_ispriordate.CheckedChanged

        If txt_ispriordate.Checked = True Then
            txt_contract_amount.Enabled = False
            txt_contract_amount_based.Enabled = False
            txt_billed_amount.Enabled = False
            txt_collected_amount.Enabled = False
        Else
            txt_contract_amount.Enabled = True
            txt_contract_amount_based.Enabled = True
            txt_billed_amount.Enabled = True
            txt_collected_amount.Enabled = True

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

    Private Sub txt_accomplishment_amount_Leave(sender As Object, e As EventArgs) Handles txt_accomplishment_amount.Leave
        Dim accomplishment_amount As Integer = txt_accomplishment_amount.Text
        If accomplishment_amount > 100 Then
            txt_accomplishment_amount.Text = 100
        End If
    End Sub

    Private Sub txt_billed_amount_Leave(sender As Object, e As EventArgs) Handles txt_billed_amount.Leave
        Dim contract_amount_based As Double = txt_contract_amount_based.Text
        Dim billed_amount As Double = txt_billed_amount.Text
        If contract_amount_based < billed_amount Then
            MsgBox("Invalid Billed amount !", vbInformation + MsgBoxStyle.OkOnly)
            txt_billed_amount.Text = 0
        End If
    End Sub

    Private Sub txt_contract_amount_Leave(sender As Object, e As EventArgs) Handles txt_contract_amount.Leave
        Dim contract_amount As Double = txt_contract_amount.Text
        If txt_currency_id.Text = Nothing Then
            MsgBox("Choose currency first!", vbInformation + MsgBoxStyle.OkOnly)
            txt_contract_amount.Text = ""
            Exit Sub
        End If
        If contract_amount < 0 Then
            MsgBox("Invalid!", vbInformation + vbOKOnly)
            txt_contract_amount.Text = "0.00"
        Else
            txt_contract_amount.Text = Format(contract_amount, "#,##0.00")
        End If
        validation()
    End Sub
    Private Sub txt_contract_cost_Leave(sender As Object, e As EventArgs) Handles txt_contract_cost.Leave
        Dim contract_cost As Double = txt_contract_cost.Text
        If txt_contract_cost.Text < 0 Then
            MsgBox("Invalid!", vbInformation + vbOKOnly)
            txt_contract_cost.Text = "0.00"
        Else
            txt_contract_cost.Text = Format(contract_cost, "#,##0.00")
        End If
        validation()
    End Sub
    Private Sub validation()
        Try
            If txt_contract_cost.Text > txt_contract_amount_based.Text Then
                txt_contract_cost.Text = "0.00"
                MsgBox("Contract Amount must Greater than Contract Cost!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class