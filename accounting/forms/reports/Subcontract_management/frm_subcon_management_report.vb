Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frm_subcon_management_report
    Dim cls_subcon As New classSubconManagementReport
    Private Sub btn_Preview_Click(sender As Object, e As EventArgs) Handles btn_Preview.Click
        Dim sql As String = ""
        If chk_subcon_management_analysis.Checked Then
            sc_analysis()
        ElseIf chk_subcon_management_subsidiary.Checked Then
            sc_subsidiary()
        Else
            MsgBox("Select Reports First", vbInformation + vbOKOnly)
        End If
    End Sub

    Private Sub dateasOf_CheckedChanged(sender As Object, e As EventArgs) Handles dateasOf.CheckedChanged
        If dateasOf.Checked Then
            dtp_from.Enabled = False
        Else
            dtp_from.Enabled = True
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
    Public Sub sc_analysis()
        Dim subcon_analysis As New subcon_analysis
        Dim SubCon_management_analysis_ds As New SubCon_management_analysis
        Try
            Dim sql As String = String.Format("SELECT DISTINCT
	                                                a.sc_year,
	                                                a.trans_date,
	                                                e.project_code,
	                                                e.project_name,
	                                                f.subConid,	    
	                                                f.subconname,
	                                                concat(a.cons1, ' to ', a.cons2) const_period,
	                                                a.po_no,
	                                                a.department_code,
	                                                d.general_name,
	                                                a.description,
	                                                IFNULL(a.amount, 0) amount,
	                                                IFNULL(b.billed_amount, 0) billed_amount,
	                                                IFNULL(amount - b.billed_amount, 0) Unbilled,
	                                                IFNULL(c.amount_collected, 0) amount_collected,
	                                                IFNULL(amount - amount_collected, 0) Unpaid,
	                                               	IFNULL(a.currency_id,0)currency_id,
													ifnull(a.currency,'None')currency
                                                FROM
	                                                trans_sub_contract_det a
                                                LEFT JOIN {0}.trans_header_sub_contract b ON a.sub_contract_det_id = b.sub_contract_det_id
                                                LEFT JOIN {0}.trans_sub_contract_offset c ON b.trans_sub_contract_id = c.trans_sub_contract_id
                                                LEFT JOIN {1}.lib_erp_general d ON a.general_id = d.general_id
                                                LEFT JOIN {1}.lib_erp_project e ON a.project_id = e.project_id
                                                LEFT JOIN {1}.lib_subCOn f ON a.subconid = f.subconid where sc_year<>'' 
                                                ", _serverDBMain, _serverDBFS)
            SubCon_management_analysis_ds.Tables("sc_management_analysis").Clear()

            If chk_per_year.Checked Then
                sql &= String.Format("and a.sc_year = {0}", txt_year_ref.Value)
            ElseIf chk_per_project.Checked Then
                sql &= String.Format("and  e.project_code = {0}", txt_project_code.Text)
            ElseIf chk_per_subcon.Checked Then
                sql &= String.Format("and  f.subConid = {0}", txt_per_subcon.Value)
            End If
            If dateasOf.Checked Then
                sql &= String.Format(" and a.trans_date  <= '{0}'", dtp_to.Value.ToString("yyyy-MM-dd"))
            Else
                sql &= String.Format(" and a.trans_date between '{0}' and '{1}'", dtp_from.Value.ToString("yyyy-MM-dd"), dtp_to.Value.ToString("yyyy-MM-dd"))
            End If

            If dateasOf.Checked Then
                subcon_analysis.analysis_filter.Text = "As of " + dtp_to.Value.ToString("MMMM dd, yyyy")
            Else
                subcon_analysis.analysis_filter.Text = "Range: From " + dtp_from.Value.ToString("MMMM dd, yyyy") + " - To " + dtp_to.Value.ToString("MMMM dd, yyyy")
            End If
            Dim dt As DataTable = Query(sql)
            If dt.Rows.Count = 0 Then
                MsgBox("No Record!", vbInformation + MsgBoxStyle.OkOnly)
            End If
            If dt.Rows.Count = 0 Then
                MsgBox("No Record!")
                Exit Sub
            End If
            For Each dr As DataRow In dt.Rows
                SubCon_management_analysis_ds.Tables("sc_management_analysis").ImportRow(dr)
            Next
            subcon_analysis.DataSource = SubCon_management_analysis_ds
            reportviewer.DocumentViewer1.DocumentSource = subcon_analysis
            reportviewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub sc_subsidiary()
        Try
            Dim subcon_subsidiary As New subcon_subsidiary
            Dim SubCon_management_subsidiary As New SubCon_management_subsidiary

            Dim sql As String = String.Format("SELECT DISTINCT
                                                b.trans_date,
	                                            IFnull(e.sc_year, 0) sc_year,
	                                            concat(e.cons1, ' to ', e.cons2) const_date,
	                                            e.po_no,
	                                            e.department_code,
	                                            e.description,
	                                            (e.amount) contract_amount,
	                                            (b.trans_no) AS ap_trans_no,
	                                            (b.trans_date) ap_trans_date,
	                                            (b.amount) billed,
	                                            (d.trans_no) cv_trans_no,
	                                            (d.trans_date) cv_trans_date,
	                                            (d.amount) cv_collected_amount,
	                                            f.general_id,
	                                            f.general_code,
	                                            f.general_name,
	                                            g.project_id,
	                                            g.project_code,
	                                            g.project_name
                                            FROM
	                                            trans_header_sub_contract a
                                            LEFT JOIN trans_header b ON a.trans_id = b.trans_id
                                            LEFT JOIN trans_jbooks c ON a.trans_id = c.trans_id
                                            LEFT JOIN (
	                                            SELECT DISTINCT
		                                            a.trans_sub_contract_id,
		                                            c.trans_id,
		                                            c.trans_no,
		                                            c.trans_date,
		                                            c.book_id,
		                                            c.journal_id,
		                                            c.general_id,
		                                            c.currency_id,
		                                            c.exchange_rate,
		                                            c.based_rate,
		                                            (a.amount_collected) amount,
		                                            (a.amount_collected_based) amount_based,
		                                            c.description
	                                            FROM
		                                            trans_sub_contract_offset A
	                                            LEFT JOIN trans_jbooks D ON A.jbooks_id = D.jbooks_id
	                                            LEFT JOIN trans_header C ON D.trans_id = C.trans_id
	                                            LEFT JOIN trans_header_sub_contract B ON A.trans_sub_contract_id = B.trans_sub_contract_id
	                                            LEFT JOIN erp_file_setup_accounting_cct.lib_erp_general e ON c.general_id = e.general_id
                                            ) d ON a.trans_sub_contract_id = d.trans_sub_contract_id
                                            LEFT JOIN trans_sub_contract_det e ON a.sub_contract_det_id = e.sub_contract_det_id
                                            LEFT JOIN erp_file_setup_accounting_cct.lib_erp_general f ON b.general_id = f.general_id
                                            LEFT JOIN erp_file_setup_accounting_cct.lib_erp_project g ON c.project_id = g.project_id
                                            WHERE
	                                            c.credit <> 0
                                                
                                                ", _serverDBMain, _serverDBFS)
            SubCon_management_subsidiary.Tables("subcon_subsidiary").Clear()

            'filter
            If chk_per_year.Checked Then
                sql &= String.Format("and e.sc_year = {0}", txt_year_ref.Value)
            ElseIf chk_per_project.Checked Then
                sql &= String.Format("and  g.project_code = {0}", txt_project_code.Text)
            ElseIf chk_per_subcon.Checked Then
                sql &= String.Format("and  f.general_id = {0}", txt_per_subcon.Value)
            End If

            If dateasOf.Checked Then
                sql &= String.Format(" and b.trans_date <= '{0}'", dtp_to.Value.ToString("yyyy-MM-dd"))
            Else
                sql &= String.Format(" and b.trans_date between '{0}' and '{1}'", dtp_from.Value.ToString("yyyy-MM-dd"), dtp_to.Value.ToString("yyyy-MM-dd"))
            End If

            If dateasOf.Checked Then
                subcon_subsidiary.subsidiary_filter.Text = "As of " + dtp_to.Value.ToString("MMMM dd, yyyy")
            Else
                subcon_subsidiary.subsidiary_filter.Text = "Range: From " + dtp_from.Value.ToString("MMMM dd, yyyy") + " - To " + dtp_to.Value.ToString("MMMM dd, yyyy")
            End If
            Dim dt As DataTable = Query(sql)
            If dt.Rows.Count = 0 Then
                MsgBox("No Record!", vbInformation + MsgBoxStyle.OkOnly)
            End If
            For Each dr As DataRow In dt.Rows
                SubCon_management_subsidiary.Tables("subcon_subsidiary").ImportRow(dr)
            Next
            subcon_subsidiary.DataSource = SubCon_management_subsidiary
            reportviewer.DocumentViewer1.DocumentSource = subcon_subsidiary
            reportviewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
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
                Dim dra() As DataRow = dt.Select("project_code like '" & txt_project_code.Text.ToString.Replace("'", "''") & "'")
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

    Private Sub per_year_CheckedChanged(sender As Object, e As EventArgs) Handles chk_per_year.CheckedChanged
        If chk_per_year.Checked Then
            txt_year_ref.Visible = True
        Else
            txt_year_ref.Visible = False

        End If
    End Sub

    Private Sub chk_per_project_CheckedChanged(sender As Object, e As EventArgs) Handles chk_per_project.CheckedChanged
        If chk_per_project.Checked Then
            txt_project_code.Visible = True
            txt_project_name.Visible = True
        Else
            txt_project_code.Visible = False
            txt_project_name.Visible = False
        End If
    End Sub

    Private Sub chk_per_subcon_CheckedChanged(sender As Object, e As EventArgs) Handles chk_per_subcon.CheckedChanged
        If chk_per_subcon.Checked Then
            txt_per_subcon.Visible = True
            txt_per_subcon_name.Visible = True
        Else
            txt_per_subcon.Visible = False
            txt_per_subcon_name.Visible = False
        End If
    End Sub



    Private Sub txt_per_subcon_Leave(sender As Object, e As EventArgs) Handles txt_per_subcon.Leave
        If Me.txt_per_subcon.Text = String.Empty Then
        Else
            Dim dt As DataTable = FsQuery("SELECT * FROM lib_subCOn")
            If dt.Rows.Count = 0 Then
                MsgBox("No record found.")
            Else
                Dim dr As DataRow = Nothing
                If dt.Rows.Count = 1 Then
                    dr = dt.Rows(0)
                Else
                    Dim dra() As DataRow = dt.Select("subconcode like '" & txt_per_subcon.Text.ToString.Replace("'", "''") & "'")
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
                    txt_per_subcon.RowData = dr
                    txt_per_subcon.Value = dr("subconid")
                    txt_per_subcon.Text = dr("subconcode")
                    txt_per_subcon_name.Text = dr("subconname")

                End If
            End If
        End If

    End Sub

    Public Sub checkBoxToggle(ByVal chk As DevExpress.XtraEditors.CheckEdit)

        Try
            Dim lst As New List(Of DevExpress.XtraEditors.CheckEdit)
            lst.Add(chk_subcon_management_analysis)
            lst.Add(chk_subcon_management_subsidiary)


            For i As Integer = 0 To lst.Count
                If chk IsNot lst(i) Then
                    lst(i).Checked = False
                End If
            Next
            chk.Checked = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk_subcon_management_analysis_CheckedChanged(sender As Object, e As EventArgs) Handles chk_subcon_management_analysis.CheckedChanged
        checkBoxToggle(chk_subcon_management_analysis)
    End Sub

    Private Sub chk_subcon_management_subsidiary_CheckedChanged(sender As Object, e As EventArgs) Handles chk_subcon_management_subsidiary.CheckedChanged
        checkBoxToggle(chk_subcon_management_subsidiary)
    End Sub

    Private Sub frm_subcon_management_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click
        Dim sql As String = ""
        If chk_subcon_management_analysis.Checked Then
            cls_subcon.subcon_report_analysis()
        ElseIf chk_subcon_management_subsidiary.Checked Then
            cls_subcon.subcon_report_subsidiary()
        Else
            MsgBox("Select Reports First", vbInformation + vbOKOnly)
        End If
    End Sub
End Class