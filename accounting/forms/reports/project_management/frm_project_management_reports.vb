Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class frm_project_management_reports
    Dim filter As String
    Dim _lbl_filter As String = Nothing
    Dim variable As Boolean
    Dim variable_2nd As Boolean
    Dim validation As String = ""
    Dim validation_2nd As String = ""
    Dim _trans_id As String
    Dim validate_body As String
    Dim projectmanagementReport_analysis As New ProjectManagementReport_analysis
    Dim ds_project_management As New ds_pm
    Dim excel_report As Boolean = False
    Public sql_header As String

    Private Sub Generate_string(ByVal sql As String, ByVal ds As DataSet, ByVal tablename As String)
        Try
            Dim sqlGenerate As String = String.Format(sql)
            Dim dt As DataTable = Query(sqlGenerate)
            For Each draw As DataRow In dt.Rows
                ds.Tables(tablename).ImportRow(draw)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub btn_Preview_Click(sender As Object, e As EventArgs) Handles btn_Preview.Click
        excel_report = False
        validations()
    End Sub
    Private Sub validations()
        checker()
        If validation <> "meron" Then
            MsgBox("Select filter first !!", vbOKOnly + vbInformation)
            Exit Sub
        ElseIf chk_project_management_subsidiary.Checked Then
            Try
                subsidiary_filter()

                If validate_body = "1" Then
                    subsidiary_Reports()
                Else
                    MsgBox("Select filter first !", vbInformation + vbOKOnly)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            Try
                ''VALIDATION
                If chk_all_year_reference.Checked Then
                End If
                If chk_per_year_reference.Checked Then
                    If txt_year_ref.Value = Nothing Then
                        MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If
                End If
                If chk_per_project_code.Checked Then
                    If txt_project_code.Value = "" Then
                        MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If
                End If
                If chk_currency_.Checked Then
                    If txt_per_currency.Value = "" Then
                        MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                        Exit Sub
                    End If
                End If
                If chk_project_management_analysis.Checked Then
                    pm_analysis()
                ElseIf chk_project_income_and_expense_analysis_summary.Checked Then
                ElseIf chk_project_income_and_expense_analysis_detailed.Checked Then
                ElseIf chk_project_management_accomplishment_summary.Checked Then
                ElseIf chk_project_management_accomplishment_detailed.Checked Then
                Else
                    MsgBox("Select a Filter first")
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub
    Private Sub dateasOf_CheckedChanged(sender As Object, e As EventArgs) Handles dateasOf.CheckedChanged
        If dateasOf.Checked Then
            dtp_from.Enabled = False
        Else
            dtp_from.Enabled = True
        End If
    End Sub
    Private Sub chk_project_management_subsidiary_CheckedChanged(sender As Object, e As EventArgs) Handles chk_project_management_subsidiary.CheckedChanged
        checkBoxToggle(chk_project_management_subsidiary)
        If chk_project_management_subsidiary.Checked Then
            grp_orig.Visible = False
            grp_exp_analysis_summary.Visible = True
        Else
            grp_exp_analysis_summary.Visible = False
            grp_orig.Visible = True
        End If
    End Sub
    Public Sub subsidiary_filter()
        Try
            Dim lst As New List(Of DevExpress.XtraEditors.CheckEdit)
            lst.Add(chk_per_year)
            lst.Add(chk_per_project)
            lst.Add(chk_per_currency)
            For i As Integer = 0 To lst.Count - 1
                If lst(i).Checked = True Then
                    validate_body = "1"
                Else
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub chk_all_year_reference_CheckedChanged(sender As Object, e As EventArgs) Handles chk_all_year_reference.CheckedChanged
        checkBoxToggleFilter(chk_all_year_reference)
    End Sub

    Private Sub chk_per_year_reference_CheckedChanged(sender As Object, e As EventArgs) Handles chk_per_year_reference.CheckedChanged
        If chk_per_year_reference.Checked Then
            txt_year_ref.Visible = True
            checkBoxToggleFilter(chk_per_year_reference)
        Else
            txt_year_ref.Visible = False
        End If
    End Sub
    Private Sub chk_per_project_code_CheckedChanged(sender As Object, e As EventArgs) Handles chk_per_project_code.CheckedChanged
        If chk_per_project_code.Checked Then
            txt_project_code.Visible = True
            checkBoxToggleFilter(chk_per_project_code)
            txt_project_name.Visible = True
        Else
            txt_project_code.Visible = False
            txt_project_name.Visible = False
        End If
    End Sub
    Private Sub chk_currency__CheckedChanged(sender As Object, e As EventArgs) Handles chk_currency_.CheckedChanged
        If chk_currency_.Checked Then
            txt_per_currency.Visible = True
            txt_per_currency_names.Visible = True
            checkBoxToggleFilter(chk_currency_)
        Else
            txt_per_currency.Visible = False
            txt_per_currency_names.Visible = False
        End If
    End Sub
    Private Sub chk_per_currency_CheckedChanged(sender As Object, e As EventArgs) Handles chk_per_currency.CheckedChanged
        If chk_per_currency.Checked Then
            txt_per_currency_code.Visible = True
            txt_per_currency_name.Visible = True
        Else
            txt_per_currency_code.Visible = False
            txt_per_currency_name.Visible = False
        End If
    End Sub
    Private Sub chk_per_year_CheckedChanged(sender As Object, e As EventArgs) Handles chk_per_year.CheckedChanged
        If chk_per_year.Checked Then
            txt_per_year_code.Visible = True
        Else
            txt_per_year_code.Visible = False
        End If
    End Sub

    Private Sub chk_per_project_CheckedChanged(sender As Object, e As EventArgs) Handles chk_per_project.CheckedChanged
        If chk_per_project.Checked Then
            txt_per_project_code.Visible = True
            txt_per_project_name.Visible = True
        Else
            txt_per_project_code.Visible = False
            txt_per_project_name.Visible = False
        End If
    End Sub
    Public Sub checkBoxToggle(ByVal chk As DevExpress.XtraEditors.CheckEdit)
        Try
            Dim lst As New List(Of DevExpress.XtraEditors.CheckEdit)
            lst.Add(chk_project_management_analysis)
            lst.Add(chk_project_management_subsidiary)
            lst.Add(chk_project_income_and_expense_analysis_summary)
            lst.Add(chk_project_income_and_expense_analysis_detailed)
            lst.Add(chk_project_management_accomplishment_summary)
            lst.Add(chk_project_management_accomplishment_detailed)
            For i As Integer = 0 To lst.Count - 1
                If chk IsNot lst(i) Then
                    lst(i).Checked = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Public Sub checkBoxToggleFilter(ByVal chk As DevExpress.XtraEditors.CheckEdit)
        Try
            Dim lst As New List(Of DevExpress.XtraEditors.CheckEdit)
            lst.Add(chk_all_year_reference)
            lst.Add(chk_per_year_reference)
            lst.Add(chk_per_project_code)
            lst.Add(chk_currency_)


            For i As Integer = 0 To lst.Count
                If chk IsNot lst(i) Then
                    lst(i).Checked = False
                End If
            Next
            chk.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub chk_project_management_analysis_CheckedChanged(sender As Object, e As EventArgs) Handles chk_project_management_analysis.CheckedChanged
        checkBoxToggle(chk_project_management_analysis)
    End Sub
    Private Sub chk_project_income_and_expense_analysis_summary_CheckedChanged(sender As Object, e As EventArgs) Handles chk_project_income_and_expense_analysis_summary.CheckedChanged
        checkBoxToggle(chk_project_income_and_expense_analysis_summary)
    End Sub
    Private Sub chk_project_income_and_expense_analysis_detailed_CheckedChanged(sender As Object, e As EventArgs) Handles chk_project_income_and_expense_analysis_detailed.CheckedChanged
        checkBoxToggle(chk_project_income_and_expense_analysis_detailed)
    End Sub
    Private Sub chk_project_management_accomplishment_summary_CheckedChanged(sender As Object, e As EventArgs) Handles chk_project_management_accomplishment_summary.CheckedChanged
        checkBoxToggle(chk_project_management_accomplishment_summary)
    End Sub

    Private Sub chk_project_management_accomplishment_detailed_CheckedChanged(sender As Object, e As EventArgs) Handles chk_project_management_accomplishment_detailed.CheckedChanged
        checkBoxToggle(chk_project_management_accomplishment_detailed)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Public Sub checker()
        'head_filter
        Try
            Dim lst As New List(Of DevExpress.XtraEditors.CheckEdit)
            lst.Add(chk_project_management_analysis)
            lst.Add(chk_project_management_subsidiary)
            lst.Add(chk_project_income_and_expense_analysis_summary)
            lst.Add(chk_project_income_and_expense_analysis_detailed)
            lst.Add(chk_project_management_accomplishment_summary)
            lst.Add(chk_project_management_accomplishment_detailed)

            For i As Integer = 0 To lst.Count - 1
                If lst(i).Checked = True Then
                    validation = "meron"
                End If
            Next
            If validation = "" Then
                variable = False
                Exit Sub
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click

        'checker()
        Dim report As New classProjectManagementReport
        report.all_year = chk_all_year_reference.Checked
        report.asOf = dateasOf.Checked
        report.currency_id = txt_per_currency.Value
        report.date_from = dtp_from.Value
        report.date_to = dtp_to.Value
        report.project_id = txt_per_project_code.Value
        report.year_reference = txt_year_ref.Value
        report.per_currency = chk_per_currency.Checked
        report.per_project = chk_per_project.Checked
        report.per_year_reference = chk_per_year_reference.Checked
        If chk_project_management_analysis.Checked Then
            report.ExcelAccountAnalysis()
        ElseIf chk_project_management_subsidiary.Checked Then
            report.ExcelAccountSubsidiary()

        End If
        'excel_report = True
        'validations()
        'Dim ds As DataSet = report.GenerateData
        'report.GenerateExcel(ds)
    End Sub

    Private Sub txt_per_project_code_Leave(sender As Object, e As EventArgs) Handles txt_per_project_code.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_project")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("project_code like '" & txt_per_project_code.Text.ToString.Replace("'", "''") & "'")
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
                txt_per_project_code.RowData = dr
                txt_per_project_code.Value = dr("project_id")
                txt_per_project_code.Text = dr("project_code")
                txt_per_project_name.Text = dr("project_name")
            End If
  
        End If
    End Sub

    Private Sub txt_per_currency_code_Leave(sender As Object, e As EventArgs) Handles txt_per_currency_code.Leave
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
                    Dim dra() As DataRow = dt.Select("currency_code like '" & txt_per_currency_code.Text.ToString.Replace("'", "''") & "'")
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
                    txt_per_currency_code.RowData = dr
                    txt_per_currency_code.Value = dr("currency_id")
                    txt_per_currency_code.Text = dr("currency_code")
                    txt_per_currency_name.Text = dr("currency_name")
                End If
            End If
        End If
    End Sub

    Public Sub subsidiary_Reports()
        Dim projectmanagementReport_subsidiaryReport As New ProjectManagementReport
        Dim pm_subsidiary_ds As New pm_subsidiary_ds
        If chk_per_year.Checked Then
            If txt_per_year_code.Value = Nothing Then
                MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                Exit Sub
            End If
        End If
        If chk_per_project.Checked Then
            If txt_per_project_code.Value = "" Then
                MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                Exit Sub
            End If

        End If
        If chk_per_currency.Checked Then
            If txt_per_currency_code.Value = "" Then
                MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                Exit Sub
            End If
        End If
        pm_subsidiary_ds.Tables("pm_headers").Clear()
        Try

            sql_header = String.Format("SELECT DISTINCT
                                                    IFNULL(project_management_id,0)project_management_id,
                                                    IFNULL(c.trans_project_management_id,0)trans_project_management_id,
                                                    ifnull(c.trans_id,0)trans_id,
                                                    IFNULL(a.pm_year,0)pm_year,
                                                    IFNULL(e.general_id,0)general_id,
                                                    IFNULL(a.project_id,0)project_id,
                                                    IFNULL(b.currency_id,0)currency_id,
                                                    IFNULL(b.trans_date,NULL)trans_date,
                                                    IFNULL(b.contract_date,0)contract_date,
                                                    IFNULL(b.po_no,'')po_no,
                                                    IFNULL(b.department_code,'')department_code,
                                                    IFNULL(b.project_name,'')project_name,
                                                    IFNULL(b.date_from,'')date_from,
                                                    IFNULL(b.date_to,'')date_to,
                                                    IFNULL(b.contract_amount,0.00)contract_amount,
                                                    IFNULL(b.contract_amount_based,0.00)contract_amount_based,
                                                    IFNULL(billing.billed_amount_ib,0)billed_amount,
                                                    IFNULL(billing.billed_amount_based_ib,0)billed_amount_based,
                                                    IFNULL(billing.trans_no_ib,0)trans_no,
                                                    IFNULL(billing.trans_date_ib,NULL)trans_date_ib,
                                                   IFNULL(collect.offset_project_management_id,0) as offset_project_management_id,
                                                    IFNULL(c.trans_project_management_id,0)trans_project_management_id,
                                                    IFNULL(collect.trans_no_cr,0) as trans_nos,
                                                   IFNULL(collect.trans_date_cr,NULL) as trans_dates,
                                                    e.book_id as book_id,
                                                    e.journal_id as journal_id,
                                                    e.exchange_rate as exchange_rate,
                                                    e.based_rate as based_rate,
                                                   IFNULL(collect.amount_collected,0) as amount_collected,
                                                    IFNULL(collect.amount_collected_based,0) as amount_collected_based,
                                                    IFNULL(b.project_name,'None') as description 
                                                    FROM 
                                                    {0}.trans_project_management a 
                                                    left join {0}.trans_project_management_det b using(project_management_id)
                                                    left join {0}.trans_header_project_management c using(project_management_det_id)
                                                    left join {0}.trans_project_management_offset d using(trans_project_management_id)
                                                    left join {0}.trans_header e using(trans_id)
                                                    left join (
													SELECT 
														IFNULL(z.trans_id,0)trans_id,
														IFNULL(z.trans_no,0)trans_no_ib,
														IFNULL(z.trans_date,'')trans_date_ib,
														IFNULL(x.billed_amount,0.00)billed_amount_ib,
														IFNULL(x.billed_amount_based,0.00)billed_amount_based_ib 
													FROM {0}.trans_header z
													LEFT JOIN {0}.trans_header_ib y on z.trans_id=y.trans_id
													LEFT JOIN {0}.trans_header_project_management x on z.trans_id=x.trans_id
                                                        )billing on e.trans_id=billing.trans_id
                                                        left join ( 
													SELECT 
														IFNULL(x.offset_project_management_id,0)offset_project_management_id,
														IFNULL(z.trans_id,0)trans_id_cr,
														IFNULL(z.trans_no,0)trans_no_cr,
														IFNULL(z.trans_date,'')trans_date_cr,
														IFNULL(x.amount_collected,0.00)amount_collected,
														IFNULL(x.amount_collected_based,0.00)amount_collected_based 
													FROM {0}.trans_header z
													LEFT JOIN {0}.trans_header_cr y on z.trans_id=y.trans_id
													LEFT JOIN {0}.trans_header_project_management h on z.trans_id=h.trans_id
													LEFT JOIN {0}.trans_project_management_offset x on h.trans_project_management_id=x.trans_project_management_id
                                        ) collect on e.trans_id=collect.trans_id_cr
                                        where c.trans_id <> '' 
                                        ", _serverDBMain)

            If chk_per_year.Checked Then
                If txt_per_year_code.Text = Nothing Then
                    MsgBox("Input Year first!", vbInformation + vbOKOnly)
                Else
                    sql_header &= String.Format(" AND a.pm_year  = {0}", txt_per_year_code.Text)
                    ' sql_or &= String.Format(" AND e.pm_year = {0}", txt_per_year_code.Text)
                End If
            End If


            If chk_per_project.Checked Then
                If txt_per_project_code.Text = Nothing Then
                    MsgBox("Input Project First!", vbInformation + vbOKOnly)
                End If
                sql_header &= String.Format(" AND a.project_id = {0}", txt_per_project_code.Value)
                '  sql_or &= String.Format(" AND  e.project_id = {0}", txt_per_project_code.Text)
            End If

            If chk_per_currency.Checked Then
                If txt_per_currency_code.Text = Nothing Then
                    MsgBox("Input Currency First!", vbInformation + vbOKOnly)
                Else
                    sql_header &= String.Format(" AND b.currency_id = {0}", txt_per_currency_code.Value)
                    ' sql_or &= String.Format(" AND b.currency_id = {0}", txt_per_currency_code.Text)
                End If
            End If

            If dateasOf.Checked Then

                sql_header &= String.Format("  AND  b.trans_date <=  '{0}'", dtp_to.Value.ToString("yyyy-MM-dd"))
            Else
                sql_header &= String.Format(" AND  b.trans_date BETWEEN '{0}' AND '{1}'", dtp_from.Value.ToString("yyyy-MM-dd"), dtp_to.Value.ToString("yyyy-MM-dd"))
            End If

            ' Dim dt_Or As DataTable = Query(sql_or)
            Dim dt_header As DataTable = Query(sql_header)
            If dt_header.Rows.Count = 0 Then
                MsgBox("No Record!", vbInformation + vbOKOnly)
                Exit Sub
            End If
            For Each drh As DataRow In dt_header.Rows
                pm_subsidiary_ds.Tables("pm_headers").ImportRow(drh)
            Next

            If dateasOf.Checked Then
                projectmanagementReport_subsidiaryReport.lbl_dates.Text = "As of " + dtp_to.Value.ToString("MMMM dd, yyyy")
            Else
                projectmanagementReport_subsidiaryReport.lbl_dates.Text = "Range: From " + dtp_from.Value.ToString("MMMM dd, yyyy") + " - To " + dtp_to.Value.ToString("MMMM dd, yyyy")
            End If
            projectmanagementReport_subsidiaryReport.DataSource = pm_subsidiary_ds
            reportviewer.DocumentViewer1.DocumentSource = projectmanagementReport_subsidiaryReport
            reportviewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message.tostring)
        End Try
    End Sub
    Public Sub pm_analysis()

        Try
            Dim sql As String = String.Format("SELECT a.project_management_id,a.pm_year,a.general_id,a.project_id,a.deleted
            ,b.project_management_det_id,b.isPriorDate,b.trans_date,b.contract_date,b.currency_id,b.exchange_rate,b.based_rate
            ,b.po_no,b.project_name AS project_description,b.date_from,b.date_to,b.contract_amount,b.contract_amount_based
            ,b.contract_cost,b.contract_cost_based,b.profit_amount,b.profit_amount_based,format(b.accomplishment_amount,2)accomplishment_amount,b.accomplishment_amount_based
            ,IFNULL(b.billed_amount,0) + IFNULL(billing.billed_amount,0) AS billed_amount
            ,IFNULL(b.billed_amount_based,0) + IFNULL(billing.billed_amount_based,0) AS billed_amount_based
            ,IFNULL(b.collected_amount,0) + IFNULL(billing.amount_collected,0) AS amount_collected
            ,IFNULL(b.collected_amount_based,0) + IFNULL(billing.amount_collected_based,0) AS amount_collected_based
            ,IF(IFNULL(b.contract_amount, 0) > (IFNULL(b.billed_amount, 0) + IFNULL(billing.billed_amount, 0)),(IFNULL(b.contract_amount, 0)-(IFNULL(b.billed_amount, 0) +  billing.billed_amount)),0) unbilled_amount
		    ,IFNULL(b.contract_amount_based,0) - (IFNULL(b.billed_amount_based,0) + IFNULL(billing.billed_amount_based,0)) AS unbilled_amount_based
		    ,(IFNULL(b.billed_amount,0) + IFNULL(billing.billed_amount,0)) - (IFNULL(b.collected_amount,0) + IFNULL(billing.amount_collected,0)) AS balance_amount
		    ,(IFNULL(b.billed_amount_based,0) + IFNULL(billing.billed_amount_based,0)) - (IFNULL(b.collected_amount_based,0) + IFNULL(billing.amount_collected_based,0)) AS balance_amount_based
            ,b.insured_with,b.department_id
            ,c.project_code,c.project_name
            ,d.general_code,d.general_name
            ,e.department_code,e.department_name
            ,f.currency_code,f.currency_name
            FROM trans_project_management a
            LEFT JOIN trans_project_management_det b ON b.project_management_id = a.project_management_id
            LEFT JOIN {0}.lib_erp_project c ON c.project_id = a.project_id
            LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id
            LEFT JOIN {0}.lib_erp_department e ON e.department_id = b.department_id
            LEFT JOIN {0}.lib_erp_currency f ON f.currency_id = b.currency_id
			LEFT JOIN (
				SELECT a.project_management_det_id
				,SUM(a.billed_amount) AS billed_amount
				,SUM(a.billed_amount_based) AS billed_amount_based
				,SUM(IFNULL(collection.amount_collected,0)) AS amount_collected
				,SUM(IFNULL(collection.amount_collected_based,0)) AS amount_collected_based
				FROM trans_header_project_management a
				LEFT JOIN (
					SELECT a.trans_project_management_id
					,SUM(a.amount_collected) AS amount_collected
					,SUM(a.amount_collected_based) AS amount_collected_based
					FROM trans_project_management_offset a
					GROUP BY a.trans_project_management_id
				) collection ON collection.trans_project_management_id = a.trans_project_management_id
				GROUP BY a.project_management_det_id
			) billing ON billing.project_management_det_id = b.project_management_det_id
            WHERE IFNULL(b.project_management_det_id,'') <> ''", _serverDBFS)

            If chk_all_year_reference.Checked Then
            End If
            If chk_per_year_reference.Checked Then
                sql &= String.Format(" and a.pm_year = '{0}'", txt_year_ref.Value)
                filter = String.Format("All Year Reference : {0}", txt_year_ref.Text)
            End If
            If chk_per_project_code.Checked Then
                sql &= String.Format(" and a.project_id = '{0}'", txt_project_code.Value)
                filter = String.Format("Per Project Code : '{0}'", txt_project_code.Text)
            End If
            If chk_currency_.Checked Then
                sql &= String.Format(" and b.currency_id = '{0}'", txt_per_currency.Value)
                filter = String.Format("Per Currency : '{0}'", txt_per_currency.Text)
            End If

            If dateasOf.Checked Then
                sql &= String.Format("  AND  b.trans_date <=  '{0}'", dtp_to.Value.ToString("yyyy-MM-dd"))
            Else
                sql &= String.Format(" AND  b.trans_date BETWEEN '{0}' AND '{1}'", dtp_from.Value.ToString("yyyy-MM-dd"), dtp_to.Value.ToString("yyyy-MM-dd"))
            End If
            sql &= String.Format(" ORDER BY	a.pm_year,f.currency_name,c.project_name")

            If dateasOf.Checked Then
                projectmanagementReport_analysis.lbl_dates.Text = "As of " + dtp_to.Value.ToString("MMMM dd, yyyy")
            Else
                projectmanagementReport_analysis.lbl_dates.Text = "Range: From " + dtp_from.Value.ToString("MMMM dd, yyyy") + " - To " + dtp_to.Value.ToString("MMMM dd, yyyy")
            End If

            ds_project_management.Tables("pm_analysis").Clear()

            Dim dt As DataTable = Query(sql)
            For Each dr As DataRow In dt.Rows

                ds_project_management.Tables("pm_analysis").ImportRow(dr)
            Next
            If excel_report = False Then


                projectmanagementReport_analysis.analysis_filter.Text = filter
                projectmanagementReport_analysis.DataSource = ds_project_management
                reportviewer.DocumentViewer1.DocumentSource = projectmanagementReport_analysis
                reportviewer.ShowDialog()
            Else
                generate_excel_analysis()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub generate_excel_analysis()
        'Try
        '    Dim company As DataRow = ds_project_management.Tables("pm_analysis").rows(0)
        '    Dim ewt As DataTable = ds.Tables("EWT")

        '    Dim tin() As String = company.Item("tin").ToString.Split({"-"}, StringSplitOptions.RemoveEmptyEntries)
        '    Dim xlApp As Excel.Application
        '    Dim xlWorkBook As Excel.Workbook
        '    Dim xlWorkSheet As Excel.Worksheet
        '    xlApp = New Excel.Application
        '    xlWorkBook = xlApp.Workbooks.Open(templates & "\0619e.xlt")
        '    xlApp.Visible = True
        '    xlWorkSheet = xlWorkBook.Worksheets(1)

        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub


    Private Sub txt_project_code_Leave(sender As Object, e As EventArgs) Handles txt_project_code.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_project")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("project_code like '" & txt_per_project_code.Text.ToString.Replace("'", "''") & "'")
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
                txt_project_code.RowData = dr
                txt_project_code.Value = dr("project_id")
                txt_project_code.Text = dr("project_code")
                txt_project_name.Text = dr("project_name")
            End If

        End If
    End Sub

    Private Sub txt_per_currency_Leave(sender As Object, e As EventArgs) Handles txt_per_currency.Leave
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
                    Dim dra() As DataRow = dt.Select("currency_code like '" & txt_per_currency_code.Text.ToString.Replace("'", "''") & "'")
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
                    txt_per_currency.RowData = dr
                    txt_per_currency.Value = dr("currency_id")
                    txt_per_currency.Text = dr("currency_code")
                    txt_per_currency_names.Text = dr("currency_name")
                End If
            End If
        End If
    End Sub
End Class