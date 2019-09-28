Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports Microsoft.Office.Interop

Public Class classSubconManagementReport
    Public Property trans_first_total As Integer
    Public Function ExcelRange(ByRef xlWorkSheet As Excel.Worksheet, ByRef fr As Integer, ByRef fc As Integer, Optional lr As Integer = -1, Optional lc As Integer = -1) As Excel.Range
        lc = If(lc < 0, fc, lc)
        lr = If(lr < 0, fr, lr)
        Return xlWorkSheet.Range(xlWorkSheet.Cells(fr, fc), xlWorkSheet.Cells(lr, lc))
    End Function
    Public Sub subcon_report_analysis()
        Dim date_filter As String = Nothing
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


                                                    FROM trans_sub_contract_det a
                                                            LEFT JOIN {0}.trans_header_sub_contract b ON a.sub_contract_det_id = b.sub_contract_det_id
                                                            LEFT JOIN {0}.trans_sub_contract_offset c ON b.trans_sub_contract_id = c.trans_sub_contract_id
                                                            LEFT JOIN {1}.lib_erp_general d ON a.general_id = d.general_id
                                                            LEFT JOIN {1}.lib_erp_project e ON a.project_id = e.project_id
                                                            LEFT JOIN {1}.lib_subCOn f ON a.subconid = f.subconid where sc_year<>'' 
                                                            ", _serverDBMain, _serverDBFS)
            SubCon_management_analysis_ds.Tables("sc_management_analysis").Clear()
            If frm_subcon_management_report.chk_per_year.Checked Then
                sql &= String.Format("and a.sc_year = {0}", frm_subcon_management_report.txt_year_ref.Value)
            ElseIf frm_subcon_management_report.chk_per_project.Checked Then
                sql &= String.Format("and  e.project_code = {0}", frm_subcon_management_report.txt_project_code.Text)
            ElseIf frm_subcon_management_report.chk_per_subcon.Checked Then
                sql &= String.Format("and  f.subConid = {0}", frm_subcon_management_report.txt_per_subcon.Value)
            End If
            If frm_subcon_management_report.dateasOf.Checked Then
                sql &= String.Format(" and a.trans_date  <= '{0}'", frm_subcon_management_report.dtp_to.Value.ToString("yyyy-MM-dd"))
            Else
                sql &= String.Format(" and a.trans_date between '{0}' and '{1}'", frm_subcon_management_report.dtp_from.Value.ToString("yyyy-MM-dd"), frm_subcon_management_report.dtp_to.Value.ToString("yyyy-MM-dd"))
            End If

            If frm_subcon_management_report.dateasOf.Checked Then
                subcon_analysis.analysis_filter.Text = "As of " + frm_subcon_management_report.dtp_to.Value.ToString("MMMM dd, yyyy")
                date_filter = "As of " + frm_subcon_management_report.dtp_to.Value.ToString("MMMM dd, yyyy")
            Else
                subcon_analysis.analysis_filter.Text = "Range: From " + frm_subcon_management_report.dtp_from.Value.ToString("MMMM dd, yyyy") + " - To " + frm_subcon_management_report.dtp_to.Value.ToString("MMMM dd, yyyy")
                date_filter = "Range: From " + frm_subcon_management_report.dtp_from.Value.ToString("MMMM dd, yyyy") + " - To " + frm_subcon_management_report.dtp_to.Value.ToString("MMMM dd, yyyy")
            End If
            Dim dt_Header As DataTable = Query(sql)
            If dt_Header.Rows.Count = 0 Then
                MsgBox("No Record!", vbInformation + MsgBoxStyle.OkOnly)
            End If
            If dt_Header.Rows.Count = 0 Then
                MsgBox("No Record!")
                Exit Sub
            End If
            For Each dr As DataRow In dt_Header.Rows
                SubCon_management_analysis_ds.Tables("sc_management_analysis").ImportRow(dr)
            Next
            Dim ds As New DataSet
            Dim dtCompany As New DataTable("lib_erp_company")
            Dim sqlCompany As String = String.Format("SELECT a.company_id,b.company_code,b.company_name
            FROM sys_default a
            LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id
            LIMIT 1
        ", _serverDBFS)
            dtCompany = Query(sqlCompany)
            dtCompany.TableName = "lib_erp_company"
            ds.Tables.Add(dtCompany)
            Dim company_name As String = ds.Tables("lib_erp_company").Rows(0)("company_name").ToString().ToUpper()
            Dim report_name As String = "Analysis Reports"
            Dim report_label As String = date_filter

            Dim strGroup As String = "sc_year,currency,project_name"
            Dim lstAccount = groupDataTableToList(SubCon_management_analysis_ds.Tables("sc_management_analysis"), strGroup)
            ''GENERATE EXCEL REPORTS FOR SUBCON MANAGEMENT ANALYSIS
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add
            xlApp.Visible = True
            xlApp.DisplayAlerts = False
            xlWorkSheet = xlWorkBook.Worksheets(1)

            xlWorkSheet.Cells(1, 1) = company_name
            xlWorkSheet.Cells(2, 1) = report_name
            xlWorkSheet.Cells(3, 1) = report_label

            xlWorkSheet.Cells(4, 1) = "P.O Date"
            xlWorkSheet.Cells(4, 2) = "Const. Period"
            xlWorkSheet.Cells(4, 3) = "P.O. No"
            xlWorkSheet.Cells(4, 4) = "Project No"
            xlWorkSheet.Cells(4, 5) = "SubCon / Supplier"
            xlWorkSheet.Cells(4, 6) = "Contract"
            xlWorkSheet.Cells(4, 7) = "Billed"
            xlWorkSheet.Cells(4, 8) = "Unbilled"
            xlWorkSheet.Cells(4, 9) = "Paid"
            xlWorkSheet.Cells(4, 10) = "Unpaid"

            ExcelRange(xlWorkSheet, 4, 1, 4, 10).Interior.Color = Drawing.Color.LightGray

            ExcelRange(xlWorkSheet, 4, 1, 5, 1).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 2, 5, 2).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 3, 5, 3).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 4, 5, 4).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 5, 5, 5).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 6, 5, 6).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 7, 5, 7).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 8, 5, 8).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 9, 5, 9).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 10, 5, 10).MergeCells = True


            Dim first_row As Integer = 6
            Dim current_row As Integer = first_row
            Dim currency_name As String = Nothing
            Dim trans_first_row As Integer = 0
            Dim trans_first_total As Integer
            For Each groups In lstAccount

                xlWorkSheet.Cells(current_row, 4) = groups("sc_year")
                For Each currency In groups("grouped")
                    trans_first_total = current_row
                    currency_name = currency("currency")
                    xlWorkSheet.Cells(current_row, 3) = currency_name
                    current_row += 1
                    For Each drproject In currency("grouped")

                        xlWorkSheet.Cells(current_row, 4) = drproject("project_name")
                        ExcelRange(xlWorkSheet, current_row, 1, current_row, 10).Interior.Color = Drawing.Color.LightSlateGray

                        current_row += 1
                        trans_first_row = current_row
                        For Each dr In drproject("datas")

                            xlWorkSheet.Cells(current_row, 1) = dr("trans_date")
                            xlWorkSheet.Cells(current_row, 2) = dr("const_period")
                            xlWorkSheet.Cells(current_row, 3) = dr("po_no")
                            xlWorkSheet.Cells(current_row, 4) = dr("department_code")
                            xlWorkSheet.Cells(current_row, 5) = dr("description")
                            xlWorkSheet.Cells(current_row, 6) = dr("amount")
                            xlWorkSheet.Cells(current_row, 7) = dr("billed_amount")
                            '   xlWorkSheet.Cells(current_row, 8) = String.Format("={1}-G{0}", current_row - 1, dr("unbilled"))
                            xlWorkSheet.Cells(current_row, 9) = dr("amount_collected")
                            'xlWorkSheet.Cells(current_row, 10) = dr("unpaid")
                            current_row += 1
                        Next


                        ExcelRange(xlWorkSheet, current_row, 1, current_row, 10).Interior.Color = Drawing.Color.Gray

                        xlWorkSheet.Cells(current_row, 5) = "TOTAL"
                        ' xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", trans_first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", trans_first_row, current_row - 1)

                        xlWorkSheet.Cells(current_row, 8) = String.Format("=H{0}-H{1}", trans_first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", trans_first_row, current_row - 1)
                        current_row += 1
                    Next

                    ExcelRange(xlWorkSheet, current_row, 1, current_row, 10).Interior.Color = Drawing.Color.Bisque
                    xlWorkSheet.Cells(current_row, 5) = String.Format("TOTAL {0}", currency("currency"))
                    xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,G{0}:G{1})", trans_first_total, current_row - 1)
                    xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", trans_first_total, current_row - 1)
                    xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", trans_first_total, current_row - 1)
                    current_row += 2
                Next

            Next

            ExcelRange(xlWorkSheet, 1, 1, 2, 10).Font.Bold = True
            ExcelRange(xlWorkSheet, 1, 1, 2, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 1, 1, 2, 10).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            ExcelRange(xlWorkSheet, 1, 1).ColumnWidth = 15
            ExcelRange(xlWorkSheet, 1, 2).ColumnWidth = 30
            ExcelRange(xlWorkSheet, 1, 3).ColumnWidth = 15
            ExcelRange(xlWorkSheet, 1, 4).ColumnWidth = 15
            ExcelRange(xlWorkSheet, 1, 5).ColumnWidth = 30


            ExcelRange(xlWorkSheet, 1, 6,, 10).ColumnWidth = 15

            ExcelRange(xlWorkSheet, 1, 1, 1, 10).MergeCells = True
            ExcelRange(xlWorkSheet, 2, 1, 2, 10).MergeCells = True
            ExcelRange(xlWorkSheet, 3, 1, 3, 10).MergeCells = True


            ExcelRange(xlWorkSheet, 1, 1, 1, 10).Font.Bold = True
            ExcelRange(xlWorkSheet, 2, 1, 2, 10).Font.Bold = True
            ExcelRange(xlWorkSheet, 3, 1, 3, 10).Font.Bold = True
            ExcelRange(xlWorkSheet, 4, 1, 4, 10).Font.Bold = True


            ExcelRange(xlWorkSheet, 3, 1, 3, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 1, 4, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 2, 4, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 3, 4, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 4, 4, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 5, 4, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 6, 4, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 7, 4, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 8, 4, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 9, 4, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 10, 4, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            ExcelRange(xlWorkSheet, 4, 1, 4, 1).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 2, 4, 2).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 3, 4, 3).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 4, 4, 4).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 5, 4, 5).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 6, 4, 6).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 7, 4, 7).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 8, 4, 8).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 9, 4, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 10, 4, 10).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



            ExcelRange(xlWorkSheet, 4, 1, 4, 10).Font.Bold = True
            'ExcelRange(xlWorkSheet, 4, 1,, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'ExcelRange(xlWorkSheet, 4, 1,, 10).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            'Dim first_row As Integer = 6
            'Dim current_row As Integer = first_row
            'Dim strGroup As String = "project_name"
            'Dim lstAccount = groupDataTableToList(dt_Header, strGroup)
            'For Each drYear In lstAccount
            '    Dim first_row_for_year As Integer = current_row
            '    xlWorkSheet.Cells(current_row, 6) = drYear("sc_year")
            '    For Each drCurrency In drYear("grouped")
            '        Dim first_row_for_currency As Integer = current_row
            '        xlWorkSheet.Cells(current_row, 6) = drCurrency("currency_name")
            '        currency = drCurrency("currency_name")
            '        current_row += 1
            '        '    For Each drProject In drCurrency("grouped")
            '        Dim first_row_for_project As Integer = current_row
            '        xlWorkSheet.Cells(current_row, 6) = drProject("project_name")
            '        ExcelRange(xlWorkSheet, current_row, 1, current_row, 10).Interior.Color = Drawing.Color.Coral
            '        current_row += 1
            '        For Each dr In drProject("datas")
            '            xlWorkSheet.Cells(current_row, 1) = String.Format("{0:d}", dr("trans_date"))
            '            xlWorkSheet.Cells(current_row, 2) = String.Format("{0:d} - {1:d}", Convert.ToDateTime(dr("date_from")).ToString("mm/dd/yyyy"), Convert.ToDateTime(dr("date_to")).ToString("mm/dd/yyyy"))
            '            xlWorkSheet.Cells(current_row, 3) = dr("po_no")
            '            xlWorkSheet.Cells(current_row, 4) = dr("department_code")
            '            xlWorkSheet.Cells(current_row, 5) = dr("project_description")
            '            xlWorkSheet.Cells(current_row, 6) = dr("contract_amount")
            '            xlWorkSheet.Cells(current_row, 7) = dr("accomplishment_amount")
            '            Dim accomplishment As Decimal = If(ifNull(dr("accomplishment_amount"), 0) = 0, 0, dr("contract_amount") / ifNull(dr("accomplishment_amount"), 0))
            '            xlWorkSheet.Cells(current_row, 8) = dr("profit_amount")
            '            xlWorkSheet.Cells(current_row, 9) = dr("contract_cost")
            '            xlWorkSheet.Cells(current_row, 10) = dr("billed_amount")
            '            xlWorkSheet.Cells(current_row, 11) = dr("unbilled_amount")
            '            xlWorkSheet.Cells(current_row, 12) = dr("amount_collected")
            '            xlWorkSheet.Cells(current_row, 13) = dr("balance_amount")
            '            current_row += 1
            '        Next





            'ExcelRange(xlWorkSheet, current_row, 1, current_row, 13).Interior.Color = Drawing.Color.Gray
            'xlWorkSheet.Cells(current_row, 5) = "TOTAL"
            'xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row_for_project, current_row - 1)
            'xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row_for_project, current_row - 1)
            'xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row_for_project, current_row - 1)
            'xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row_for_project, current_row - 1)
            'xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row_for_project, current_row - 1)
            'xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row_for_project, current_row - 1)

            'xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row_for_project, current_row - 1)
            ''current_row += 1
            'Next
            ''ExcelRange(xlWorkSheet, current_row, 1, current_row, 13).Interior.Color = Drawing.Color.Bisque
            ''xlWorkSheet.Cells(current_row, 5) = String.Format("TOTAL {0}", drCurrency("currency_name"))
            ''xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row_for_currency, current_row - 1)
            ''xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row_for_currency, current_row - 1)
            ''xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row_for_currency, current_row - 1)
            ''xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row_for_currency, current_row - 1)
            ''xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row_for_currency, current_row - 1)
            ''xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row_for_currency, current_row - 1)
            ''xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row_for_currency, current_row - 1)
            ''current_row += 1
            'Next


            Dim formatRange As Excel.Range

            formatRange = xlWorkSheet.Range("F8", String.Format("J{0}", current_row))
            formatRange.NumberFormat = "#,##0.00"

            formatRange = xlWorkSheet.Range("A8", String.Format("B{0}", current_row))
            formatRange.NumberFormat = "mm/dd/yyyy"

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Exit Sub

    End Sub
    Public Sub subcon_report_subsidiary()
        Try
            Dim subcon_subsidiary As New subcon_subsidiary
            Dim SubCon_management_subsidiary As New SubCon_management_subsidiary
            Dim date_filter As String = Nothing

            Dim sql As String = String.Format("SELECT DISTINCT
                                                b.trans_date,
	                                            IFnull(e.sc_year, 0) sc_year,
	                                            concat(e.cons1, ' to ', e.cons2) const_date,
	                                            e.po_no,
	                                            e.department_code,
	                                            e.description,
	                                            IFNULL(e.amount,0) contract_amount,
	                                            (b.trans_no) AS ap_trans_no,
	                                            (b.trans_date) ap_trans_date,
	                                            IFNULL(b.amount,0) billed,
	                                            (d.trans_no) cv_trans_no,
	                                            (d.trans_date) cv_trans_date,
	                                            IFNULL(d.amount,0) cv_collected_amount,
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
            If frm_subcon_management_report.chk_per_year.Checked Then
                sql &= String.Format("and e.sc_year = {0}", frm_subcon_management_report.txt_year_ref.Value)
            ElseIf frm_subcon_management_report.chk_per_project.Checked Then
                sql &= String.Format("and  g.project_code = {0}", frm_subcon_management_report.txt_project_code.Text)
            ElseIf frm_subcon_management_report.chk_per_subcon.Checked Then
                sql &= String.Format("and  f.general_id = {0}", frm_subcon_management_report.txt_per_subcon.Value)
            End If

            If frm_subcon_management_report.dateasOf.Checked Then
                sql &= String.Format(" and b.trans_date <= '{0}'", frm_subcon_management_report.dtp_to.Value.ToString("yyyy-MM-dd"))
            Else
                sql &= String.Format(" and b.trans_date between '{0}' and '{1}'", frm_subcon_management_report.dtp_from.Value.ToString("yyyy-MM-dd"), frm_subcon_management_report.dtp_to.Value.ToString("yyyy-MM-dd"))

            End If

            If frm_subcon_management_report.dateasOf.Checked Then
                subcon_subsidiary.subsidiary_filter.Text = "As of " + frm_subcon_management_report.dtp_to.Value.ToString("MMMM dd, yyyy")
                date_filter = subcon_subsidiary.subsidiary_filter.Text
            Else
                subcon_subsidiary.subsidiary_filter.Text = "Range: From " + frm_subcon_management_report.dtp_from.Value.ToString("MMMM dd, yyyy") + " - To " + frm_subcon_management_report.dtp_to.Value.ToString("MMMM dd, yyyy")
                date_filter = subcon_subsidiary.subsidiary_filter.Text
            End If
            Dim dt As DataTable = Query(sql)
            If dt.Rows.Count = 0 Then
                MsgBox("No Record!", vbInformation + MsgBoxStyle.OkOnly)
            End If
            For Each dr As DataRow In dt.Rows
                SubCon_management_subsidiary.Tables("subcon_subsidiary").ImportRow(dr)
            Next

            Dim ds As New DataSet
            Dim dtCompany As New DataTable("lib_erp_company")
            Dim sqlCompany As String = String.Format("SELECT a.company_id,b.company_code,b.company_name
            FROM sys_default a
            LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id
            LIMIT 1
        ", _serverDBFS)
            dtCompany = Query(sqlCompany)
            dtCompany.TableName = "lib_erp_company"
            ds.Tables.Add(dtCompany)
            Dim company_name As String = ds.Tables("lib_erp_company").Rows(0)("company_name").ToString().ToUpper()
            Dim report_name As String = "Subsidiary Reports"
            Dim report_label As String = date_filter


            'GENERATE_EXCEL_REPORTS

            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add
            'xlApp.Visible = True
            'xlApp.DisplayAlerts = False
            xlWorkSheet = xlWorkBook.Worksheets(1)

            xlWorkSheet.Cells(1, 1) = company_name
            xlWorkSheet.Cells(2, 1) = report_name
            xlWorkSheet.Cells(3, 1) = report_label

            xlWorkSheet.Cells(4, 1) = "Const. Period"
            xlWorkSheet.Cells(4, 2) = "P.O. No"
            xlWorkSheet.Cells(4, 3) = "Project No"
            xlWorkSheet.Cells(4, 4) = "Project Name"
            xlWorkSheet.Cells(4, 5) = "Contract"
            xlWorkSheet.Cells(4, 6) = "Billed"
            xlWorkSheet.Cells(4, 7) = "Unbilled"
            xlWorkSheet.Cells(4, 8) = "Paid"
            xlWorkSheet.Cells(4, 9) = "Balance"

            ExcelRange(xlWorkSheet, 4, 1, 4, 9).Interior.Color = Drawing.Color.LightSlateGray


            'ExcelRange(xlWorkSheet, 4, 1, 4, 2).MergeCells = True
            'ExcelRange(xlWorkSheet, 4, 3, 4, 4).MergeCells = True
            'ExcelRange(xlWorkSheet, 4, 5, 5, 6).MergeCells = True
            'ExcelRange(xlWorkSheet, 4, 7, 4, 8).MergeCells = True
            'ExcelRange(xlWorkSheet, 4, 9, 4, 10).MergeCells = True
            'ExcelRange(xlWorkSheet, 4, 11, 4, 12).MergeCells = True
            'ExcelRange(xlWorkSheet, 4, 13, 4, 14).MergeCells = True
            'ExcelRange(xlWorkSheet, 4, 15, 4, 16).MergeCells = True
            'ExcelRange(xlWorkSheet, 4, 17, 4, 18).MergeCells = True


            ExcelRange(xlWorkSheet, 4, 1, 4, 18).Font.Bold = True
            ExcelRange(xlWorkSheet, 4, 1, 4, 18).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 1, 4, 18).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            ExcelRange(xlWorkSheet, 1, 1).ColumnWidth = 25
            ExcelRange(xlWorkSheet, 1, 2).ColumnWidth = 15

            ExcelRange(xlWorkSheet, 1, 3).ColumnWidth = 15
            ExcelRange(xlWorkSheet, 1, 4).ColumnWidth = 30

            ExcelRange(xlWorkSheet, 1, 5,, 13).ColumnWidth = 15

            ExcelRange(xlWorkSheet, 1, 1, 1, 9).MergeCells = True
            ExcelRange(xlWorkSheet, 2, 1, 2, 9).MergeCells = True
            ExcelRange(xlWorkSheet, 3, 1, 3, 9).MergeCells = True

            'ExcelRange(xlWorkSheet, 1, 1, 1, 18).Font.Bold = True
            'ExcelRange(xlWorkSheet, 2, 1, 2, 18).Font.Bold = True
            'ExcelRange(xlWorkSheet, 3, 1, 3, 18).Font.Bold = True

            ExcelRange(xlWorkSheet, 1, 1, 1, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 2, 1, 2, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 3, 1, 3, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            ExcelRange(xlWorkSheet, 1, 1, 1, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 2, 1, 2, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 3, 1, 3, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            ExcelRange(xlWorkSheet, 4, 1,, 9).Font.Bold = True
            ExcelRange(xlWorkSheet, 4, 1,, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 1,, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            'ExcelRange(xlWorkSheet, 4, 1, 5, 6).Interior.Color = Drawing.Color.YellowGreen
            'ExcelRange(xlWorkSheet, 4, 1, 5, 18).Interior.Color = Drawing.Color.YellowGreen
            'ExcelRange(xlWorkSheet, 5, 7, 5, 9).Interior.Color = Drawing.Color.YellowGreen

            Dim first_row As Integer = 5
            Dim current_row As Integer = first_row
            trans_first_total = current_row
            Dim strGroup As String = "project_id,ap_trans_no,cv_trans_no"
            Dim lstAccount = groupDataTableToList(dt, strGroup)
            Dim first_row_for_year As Integer = current_row
            Dim first_row_for_currency As Integer = current_row
            Dim contract_first_row As Integer = current_row
            'current_row += 1

            Dim Sql_billing As String = sql

            Sql_billing += String.Format(" Group By b.trans_no")
            Dim dt_billing As DataTable = Query(Sql_billing)

            For Each dr As DataRow In dt_billing.Rows
                Dim _contract_first_row As Integer
                Dim billed_first_row As Integer

                xlWorkSheet.Cells(current_row, 1) = dr("const_date")
                xlWorkSheet.Cells(current_row, 2) = dr("po_no")
                xlWorkSheet.Cells(current_row, 3) = dr("department_code")
                xlWorkSheet.Cells(current_row, 4) = dr("project_name")
                xlWorkSheet.Cells(current_row, 5) = dr("contract_amount")
                _contract_first_row = current_row
                current_row += 1
                If ifNull(dr("billed"), 0) = 0 Then
                Else
                    xlWorkSheet.Cells(current_row, 1) = If(dr("billed") = 0, "", "INVOICE")
                    xlWorkSheet.Cells(current_row, 2) = If(dr("billed") = 0, "", "IB -" + Convert.ToDateTime(dr("ap_trans_date")) + " " + dr("ap_trans_no").ToString)
                    xlWorkSheet.Cells(current_row, 6) = If(dr("billed") = 0, "", dr("billed"))
                    xlWorkSheet.Cells(current_row, 7) = If(dr("billed") = 0, "", ifNull(dr("contract_amount"), 0) - ifNull(dr("billed"), 0))
                    ExcelRange(xlWorkSheet, current_row, 2, current_row, 4).MergeCells = True
                    billed_first_row = current_row
                    current_row += 1
                    If dr("cv_collected_amount") = 0 Then
                    Else
                        Dim Sql_collected As String = sql
                        Sql_collected += String.Format(" Group By d.trans_no")
                        Dim dt_collected As DataTable = Query(Sql_collected)
                        Dim ap_trans_no As String = String.Format("ap_trans_no = '{0}'", dr("ap_trans_no").ToString)
                        For Each item As DataRow In dt_collected.Select(ap_trans_no)
                            xlWorkSheet.Cells(current_row, 1) = If(item("cv_collected_amount") = 0, 0.00, "OR")
                            xlWorkSheet.Cells(current_row, 2) = If(item("cv_collected_amount") = 0, 0.00, dr("ap_trans_no").ToString) + " " + "CV -" + Convert.ToDateTime(item("cv_trans_date")) + " " + item("cv_trans_no").ToString
                            xlWorkSheet.Cells(current_row, 8) = If(item("cv_collected_amount") = 0, 0.00, item("cv_collected_amount"))
                            xlWorkSheet.Cells(current_row, 9) = If(item("cv_collected_amount") = 0, 0.00, String.Format("=F{0}-H{1}", billed_first_row, current_row))
                            ExcelRange(xlWorkSheet, current_row, 2, current_row, 4).MergeCells = True
                            current_row += 1
                        Next
                    End If
                End If
                ExcelRange(xlWorkSheet, current_row, 1, current_row, 9).Interior.Color = Drawing.Color.Gray
                xlWorkSheet.Cells(current_row, 4) = "TOTAL"
                xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}: E{1})", _contract_first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", _contract_first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", _contract_first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", _contract_first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", _contract_first_row, current_row - 1)
                current_row += 1
            Next
            ExcelRange(xlWorkSheet, current_row, 1, current_row, 9).Interior.Color = Drawing.Color.Bisque
            xlWorkSheet.Cells(current_row, 4) = String.Format("Grand Total")
            xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", trans_first_total, current_row - 1)
            xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", trans_first_total, current_row - 1)
            xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", trans_first_total, current_row - 1)
            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", trans_first_total, current_row - 1)
            xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", trans_first_total, current_row - 1)
            current_row += 2
            'ExcelRange(xlWorkSheet, current_row, 1, current_row, 13).Interior.Color = Drawing.Color.Gray
            '                    xlWorkSheet.Cells(current_row, 5) = "TOTAL"
            '                    xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9, F{0}: F{1})", first_row_for_project, current_row - 1)
            '                    xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row_for_project, current_row - 1)
            '                    xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row_for_project, current_row - 1)
            '                    xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row_for_project, current_row - 1)
            '                    xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row_for_project, current_row - 1)
            '                    xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row_for_project, current_row - 1)

            '                    xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row_for_project, current_row - 1)
            '                    current_row += 1
            'Dim formatRange As Excel.Range
            'formatRange = xlWorkSheet.Range("F8", String.Format("F{0}", current_row))
            'formatRange.NumberFormat = "#,##0.00"
            'formatRange = xlWorkSheet.Range("H8", String.Format("M{0}", current_row))
            'formatRange.NumberFormat = "#,##0.00"

            'formatRange = xlWorkSheet.Range("A8", String.Format("B{0}", current_row))
            'formatRange.NumberFormat = "mm/dd/yyyy"
            ExcelRange(xlWorkSheet, first_row, 1, current_row, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, first_row, 1, current_row, 4).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            Dim formatRange As Excel.Range
            formatRange = xlWorkSheet.Range("E5", String.Format("I{0}", current_row))
            formatRange.NumberFormat = "#,##0.00"

            formatRange = xlWorkSheet.Range("A1", String.Format("A{0}", current_row))
            formatRange.NumberFormat = "mm/dd/yyyy"
            xlApp.Visible = True
            xlApp.DisplayAlerts = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class
