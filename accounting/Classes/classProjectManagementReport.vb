Imports Microsoft.Office.Interop
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class classProjectManagementReport
    Public report_type As Integer = 0
    Public all_year As Boolean = False
    Public per_year_reference As Boolean = False
    Public per_project As Boolean = False
    Public per_currency As Boolean = False
    Public year_reference As String = ""
    Public project_id As String = ""
    Public currency_id As String = ""
    Public asOf As Boolean = False
    Public date_from As DateTime = Today
    Public date_to As DateTime = Today
    Private currency As String = Nothing


    Public Sub ExcelAccountAnalysis()
        Try

            'generate data
            Dim ds As New DataSet
            Dim dtCompany As New DataTable("lib_erp_company")
            Dim dtHead As New DataTable("project_management")
            Dim sqlCompany As String = String.Format("SELECT a.company_id,b.company_code,b.company_name
            FROM sys_default a
            LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id
            LIMIT 1
        ", _serverDBFS)
            Dim sqlHead As String = String.Format("SELECT a.project_management_id,a.pm_year,a.general_id,a.project_id,a.deleted
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
            If per_year_reference Then
                If year_reference <> "" Then
                    sqlHead &= String.Format(" AND a.pm_year = '{0}'", year_reference)
                End If
            End If
            If per_project Then
                If project_id <> "" Then
                    sqlHead &= String.Format(" AND a.project_id = '{0}'", project_id)
                End If
            End If
            If per_currency Then
                If currency_id <> "" Then
                    sqlHead &= String.Format(" AND b.currency_id = '{0}'", currency_id)
                End If
            End If
            If asOf Then
                sqlHead &= String.Format(" AND b.trans_date <= '{0}'", date_to.ToString("yyyy-MM-dd"))
            Else
                sqlHead &= String.Format(" AND b.trans_date BETWEEN '{0}' AND '{1}'", date_from.ToString("yyyy-MM-dd"), date_to.ToString("yyyy-MM-dd"))
            End If
            sqlHead &= String.Format(" ORDER BY a.pm_year,f.currency_name,c.project_name")
            dtCompany = Query(sqlCompany)
            dtHead = Query(sqlHead)
            dtCompany.TableName = "lib_erp_company"
            dtHead.TableName = "project_management"
            ds.Tables.Add(dtCompany)
            ds.Tables.Add(dtHead)

            Dim strGroup As String = "pm_year,currency_name,project_name"
            Dim lstAccount = groupDataTableToList(ds.Tables("project_management"), strGroup)
            'generate excel
            Dim company_name As String = ds.Tables("lib_erp_company").Rows(0)("company_name").ToString().ToUpper()
            Dim report_name As String = "Project Management Analysis"
            Dim report_label As String = ""

            If asOf Then
                report_label = String.Format("AS OF {0:d}", date_to)
            Else
                report_label = String.Format("FROM {0:d} TO {0:d}", date_from, date_to)
            End If

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

            xlWorkSheet.Cells(5, 1) = "Date"
            xlWorkSheet.Cells(5, 2) = "Const. Period"
            xlWorkSheet.Cells(5, 3) = "P.O. No"
            xlWorkSheet.Cells(5, 4) = "Project No"
            xlWorkSheet.Cells(5, 5) = "Project Name"
            xlWorkSheet.Cells(5, 6) = "Contract"
            xlWorkSheet.Cells(5, 7) = "Accomplishment"
            xlWorkSheet.Cells(5, 7) = "'%"
            xlWorkSheet.Cells(5, 8) = "Accomplished"
            xlWorkSheet.Cells(5, 9) = "Unaccomplished"
            xlWorkSheet.Cells(5, 10) = "Billed"
            xlWorkSheet.Cells(5, 11) = "Unbilled"
            xlWorkSheet.Cells(5, 12) = "Paid"
            xlWorkSheet.Cells(5, 13) = "Balance"

            xlWorkSheet.Cells(4, 7) = "Accomplished"

            ExcelRange(xlWorkSheet, 4, 1, 5, 1).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 2, 5, 2).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 3, 5, 3).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 4, 5, 4).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 5, 5, 5).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 6, 5, 6).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 7, 4, 9).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 10, 5, 10).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 11, 5, 11).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 12, 5, 12).MergeCells = True
            ExcelRange(xlWorkSheet, 4, 13, 5, 13).MergeCells = True


            ExcelRange(xlWorkSheet, 4, 1, 5, 13).Font.Bold = True
            ExcelRange(xlWorkSheet, 4, 1, 5, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 4, 1, 5, 13).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            ExcelRange(xlWorkSheet, 1, 1).ColumnWidth = 25
            ExcelRange(xlWorkSheet, 1, 2).ColumnWidth = 15
            ExcelRange(xlWorkSheet, 1, 3).ColumnWidth = 15
            ExcelRange(xlWorkSheet, 1, 4).ColumnWidth = 30
            ExcelRange(xlWorkSheet, 1, 5,, 13).ColumnWidth = 15

            ExcelRange(xlWorkSheet, 1, 1, 1, 13).MergeCells = True
            ExcelRange(xlWorkSheet, 2, 1, 2, 13).MergeCells = True
            ExcelRange(xlWorkSheet, 3, 1, 3, 13).MergeCells = True

            ExcelRange(xlWorkSheet, 1, 1, 1, 13).Font.Bold = True
            ExcelRange(xlWorkSheet, 2, 1, 2, 13).Font.Bold = True
            ExcelRange(xlWorkSheet, 3, 1, 3, 13).Font.Bold = True

            ExcelRange(xlWorkSheet, 1, 1, 1, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 2, 1, 2, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 3, 1, 3, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            ExcelRange(xlWorkSheet, 1, 1, 1, 13).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 2, 1, 2, 13).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 3, 1, 3, 13).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            ExcelRange(xlWorkSheet, 5, 1,, 13).Font.Bold = True
            ExcelRange(xlWorkSheet, 5, 1,, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 5, 1,, 13).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            ExcelRange(xlWorkSheet, 4, 1, 5, 6).Interior.Color = Drawing.Color.LightSlateGray
            ExcelRange(xlWorkSheet, 4, 10, 5, 13).Interior.Color = Drawing.Color.LightSlateGray
            ExcelRange(xlWorkSheet, 5, 7, 5, 9).Interior.Color = Drawing.Color.LightSlateGray
            'ExcelRange(xlWorkSheet, 5, 1, 5, 13).Interior.Color = Drawing.Color.LightSlateGray

            Dim first_row As Integer = 6
            Dim current_row As Integer = first_row
            For Each drYear In lstAccount
                Dim first_row_for_year As Integer = current_row
                xlWorkSheet.Cells(current_row, 3) = drYear("pm_year")
                For Each drCurrency In drYear("grouped")
                    Dim first_row_for_currency As Integer = current_row
                    xlWorkSheet.Cells(current_row, 5) = drCurrency("currency_name")
                    currency = drCurrency("currency_name")
                    current_row += 1
                    For Each drProject In drCurrency("grouped")
                        Dim first_row_for_project As Integer = current_row
                        xlWorkSheet.Cells(current_row, 5) = drProject("project_name")
                        ExcelRange(xlWorkSheet, current_row, 1, current_row, 13).Interior.Color = Drawing.Color.LightSlateGray
                        current_row += 1
                        For Each dr In drProject("datas")
                            xlWorkSheet.Cells(current_row, 1) = String.Format("{0:d}", dr("trans_date"))
                            xlWorkSheet.Cells(current_row, 2) = String.Format("{0:d} - {1:d}", Convert.ToDateTime(dr("date_from")).ToString("mm/dd/yyyy"), Convert.ToDateTime(dr("date_to")).ToString("mm/dd/yyyy"))
                            xlWorkSheet.Cells(current_row, 3) = dr("po_no")
                            xlWorkSheet.Cells(current_row, 4) = dr("department_code")
                            xlWorkSheet.Cells(current_row, 5) = dr("project_description")
                            xlWorkSheet.Cells(current_row, 6) = dr("contract_amount")
                            xlWorkSheet.Cells(current_row, 7) = dr("accomplishment_amount")
                            Dim accomplishment As Decimal = If(ifNull(dr("accomplishment_amount"), 0) = 0, 0, dr("contract_amount") / ifNull(dr("accomplishment_amount"), 0))
                            xlWorkSheet.Cells(current_row, 8) = dr("profit_amount")
                            xlWorkSheet.Cells(current_row, 9) = dr("contract_cost")
                            xlWorkSheet.Cells(current_row, 10) = dr("billed_amount")
                            xlWorkSheet.Cells(current_row, 11) = dr("unbilled_amount")
                            xlWorkSheet.Cells(current_row, 12) = dr("amount_collected")
                            xlWorkSheet.Cells(current_row, 13) = dr("balance_amount")
                            current_row += 1
                        Next
                        ExcelRange(xlWorkSheet, current_row, 1, current_row, 13).Interior.Color = Drawing.Color.Gray
                        xlWorkSheet.Cells(current_row, 5) = "TOTAL"
                        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row_for_project, current_row - 1)
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row_for_project, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row_for_project, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row_for_project, current_row - 1)
                        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row_for_project, current_row - 1)
                        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row_for_project, current_row - 1)

                        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row_for_project, current_row - 1)
                        current_row += 1
                    Next
                    ExcelRange(xlWorkSheet, current_row, 1, current_row, 13).Interior.Color = Drawing.Color.Bisque
                    xlWorkSheet.Cells(current_row, 5) = String.Format("TOTAL {0}", drCurrency("currency_name"))
                    xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row_for_currency, current_row - 1)
                    xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row_for_currency, current_row - 1)
                    xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row_for_currency, current_row - 1)
                    xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row_for_currency, current_row - 1)
                    xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row_for_currency, current_row - 1)
                    xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row_for_currency, current_row - 1)
                    xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row_for_currency, current_row - 1)
                    current_row += 1
                Next

            Next
            Dim formatRange As Excel.Range
            formatRange = xlWorkSheet.Range("F8", String.Format("F{0}", current_row))
            formatRange.NumberFormat = "#,##0.00"
            formatRange = xlWorkSheet.Range("H8", String.Format("M{0}", current_row))
            formatRange.NumberFormat = "#,##0.00"
            formatRange = xlWorkSheet.Range("A8", String.Format("B{0}", current_row))
            formatRange.NumberFormat = "mm/dd/yyyy"

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Public Sub ExcelAccountSubsidiary()
        Dim projectmanagementReport_subsidiaryReport As New ProjectManagementReport
        Dim pm_subsidiary_ds As New pm_subsidiary_ds
        Dim date_filter As String = Nothing
        If frm_project_management_reports.chk_per_year.Checked Then
            If frm_project_management_reports.txt_per_year_code.Value = Nothing Then
                MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                Exit Sub
            End If
        End If
        If frm_project_management_reports.chk_per_project.Checked Then
            If frm_project_management_reports.txt_per_project_code.Value = "" Then
                MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                Exit Sub
            End If

        End If
        If frm_project_management_reports.chk_per_currency.Checked Then
            If frm_project_management_reports.txt_per_currency_code.Value = "" Then
                MsgBox("Incomplete Data!", vbInformation + vbOKOnly)
                Exit Sub
            End If
        End If
        pm_subsidiary_ds.Tables("pm_headers").Clear()

        Dim sql_header As String = String.Format("SELECT DISTINCT
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
                                                    if(IFNULL(collect.trans_no_cr,0)='0','None',IFNULL(collect.trans_no_cr,'')) as trans_nos,
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

        If frm_project_management_reports.chk_per_year.Checked Then
                If frm_project_management_reports.txt_per_year_code.Text = Nothing Then
                    MsgBox("Input Year first!", vbInformation + vbOKOnly)
                Else
                    sql_header &= String.Format(" AND a.pm_year  = {0}", frm_project_management_reports.txt_per_year_code.Text)
                    ' sql_or &= String.Format(" AND e.pm_year = {0}", txt_per_year_code.Text)
                End If
            End If


            If frm_project_management_reports.chk_per_project.Checked Then
                If frm_project_management_reports.txt_per_project_code.Text = Nothing Then
                    MsgBox("Input Project First!", vbInformation + vbOKOnly)
                End If
                sql_header &= String.Format(" AND a.project_id = {0}", frm_project_management_reports.txt_per_project_code.Value)
                '  sql_or &= String.Format(" AND  e.project_id = {0}", txt_per_project_code.Text)
            End If

            If frm_project_management_reports.chk_per_currency.Checked Then
                If frm_project_management_reports.txt_per_currency_code.Text = Nothing Then
                    MsgBox("Input Currency First!", vbInformation + vbOKOnly)
                Else
                    sql_header &= String.Format(" AND b.currency_id = {0}", frm_project_management_reports.txt_per_currency_code.Value)
                    ' sql_or &= String.Format(" AND b.currency_id = {0}", txt_per_currency_code.Text)
                End If
            End If

            If frm_project_management_reports.dateasOf.Checked Then
                sql_header &= String.Format("  AND  b.trans_date <=  '{0}'", frm_project_management_reports.dtp_to.Value.ToString("yyyy-MM-dd"))
            Else
                sql_header &= String.Format(" AND  b.trans_date BETWEEN '{0}' AND '{1}'", frm_project_management_reports.dtp_from.Value.ToString("yyyy-MM-dd"), frm_project_management_reports.dtp_to.Value.ToString("yyyy-MM-dd"))
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

            If frm_project_management_reports.dateasOf.Checked Then
                projectmanagementReport_subsidiaryReport.lbl_dates.Text = "As of " + frm_project_management_reports.dtp_to.Value.ToString("MMMM dd, yyyy")
            date_filter = projectmanagementReport_subsidiaryReport.lbl_dates.Text
        Else
            projectmanagementReport_subsidiaryReport.lbl_dates.Text = "Range: From " + frm_project_management_reports.dtp_from.Value.ToString("MMMM dd, yyyy") + " - To " + frm_project_management_reports.dtp_to.Value.ToString("MMMM dd, yyyy")
            date_filter = projectmanagementReport_subsidiaryReport.lbl_dates.Text
        End If

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
        ExcelRange(xlWorkSheet, 4, 1, 5, 6).Interior.Color = Drawing.Color.LightSlateGray
        ExcelRange(xlWorkSheet, 4, 1, 5, 18).Interior.Color = Drawing.Color.LightSlateGray
        ExcelRange(xlWorkSheet, 5, 7, 5, 9).Interior.Color = Drawing.Color.LightSlateGray
        'ExcelRange(xlWorkSheet, 4, 1, 4, 9).Interior.Color = Drawing.Color.LightSlateGray


        Dim first_row As Integer = 5
        Dim current_row As Integer = first_row
        Dim strGroup As String = "project_id,trans_no,trans_nos"
        Dim lstAccount = groupDataTableToList(dt_header, strGroup)
        Dim first_row_for_year As Integer = current_row
        Dim first_row_for_currency As Integer = current_row
        Dim contract_first_row As Integer = current_row
        'current_row += 1

        Dim Sql_billing As String = sql_header

        Sql_billing += String.Format(" Group By billing.trans_no_ib")
        Dim dt_billing As DataTable = Query(Sql_billing)
        Dim _contract_first_row As Integer
        For Each dr As DataRow In dt_billing.Rows

            Dim billed_first_row As Integer

            xlWorkSheet.Cells(current_row, 1) = Convert.ToDateTime(dr("date_from")) + " to " + Convert.ToDateTime(dr("date_to"))
            xlWorkSheet.Cells(current_row, 2) = dr("po_no")
            xlWorkSheet.Cells(current_row, 3) = dr("department_code")
            xlWorkSheet.Cells(current_row, 4) = dr("project_name")
            xlWorkSheet.Cells(current_row, 5) = dr("contract_amount")
            _contract_first_row = current_row
            current_row += 1
            If ifNull(dr("billed_amount"), 0) = 0 Then
            Else

                xlWorkSheet.Cells(current_row, 1) = If(dr("billed_amount") = 0, "", "INVOICE")
                xlWorkSheet.Cells(current_row, 2) = If(dr("billed_amount") = 0, "", "IB -" + Convert.ToDateTime(dr("trans_date_ib")) + " " + dr("trans_no").ToString)
                xlWorkSheet.Cells(current_row, 6) = If(dr("billed_amount") = 0, "", dr("billed_amount"))
                xlWorkSheet.Cells(current_row, 7) = If(dr("billed_amount") = 0, "", ifNull(dr("contract_amount"), 0) - ifNull(dr("billed_amount"), 0))
                ExcelRange(xlWorkSheet, current_row, 2, current_row, 4).MergeCells = True
                billed_first_row = current_row
                current_row += 1
                If dr("amount_collected") = 0 Then
                Else
                    Dim Sql_collected As String = sql_header
                    Sql_collected += String.Format(" Group By collect.trans_no_cr")
                    Dim dt_collected As DataTable = Query(Sql_collected)
                    Dim bobojm As String = String.Format("trans_no = '{0}'", dr("trans_no").ToString)
                    For Each item As DataRow In dt_collected.Select(bobojm)
                        xlWorkSheet.Cells(current_row, 1) = If(item("amount_collected") = 0, 0.00, "OR")
                        xlWorkSheet.Cells(current_row, 2) = If(item("amount_collected") = 0, 0.00, dr("trans_no").ToString) + " " + "CV -" + Convert.ToDateTime(item("trans_dates")) + " " + item("trans_nos").ToString
                        xlWorkSheet.Cells(current_row, 8) = If(item("amount_collected") = 0, 0.00, item("amount_collected"))
                        xlWorkSheet.Cells(current_row, 9) = If(item("amount_collected") = 0, 0.00, String.Format("=F{0}-H{1}", billed_first_row, current_row))
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
        xlWorkSheet.Cells(current_row, 4) = "GRAND TOTAL"
        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9, E{0}: E{1})", _contract_first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", _contract_first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", _contract_first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", _contract_first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", _contract_first_row, current_row - 1)

        current_row += 1
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

    End Sub
    Public Function GenerateData() As DataSet
        Dim ds As New DataSet
        Dim dtCompany As New DataTable("lib_erp_company")
        Dim dtHead As New DataTable("project_management")
        Dim dtBilling As New DataTable("project_management_billing")
        Dim dtCollection As New DataTable("project_management_collection")

        Dim sqlCompany As String = String.Format("SELECT a.company_id,b.company_code,b.company_name
            FROM sys_default a
            LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id
            LIMIT 1
        ", _serverDBFS)
        Dim sqlHead As String = String.Format("SELECT a.project_management_id,a.pm_year,a.general_id,a.project_id,a.deleted
            ,b.project_management_det_id,b.isPriorDate,b.trans_date,b.contract_date,b.currency_id,b.exchange_rate,b.based_rate
            ,b.po_no,b.project_name AS project_description,b.date_from,b.date_to,b.contract_amount,b.contract_amount_based
            ,b.contract_cost,b.contract_cost_based,b.profit_amount,b.profit_amount_based,b.accomplishment_amount,b.accomplishment_amount_based
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
            FROM trans_project_management a
            LEFT JOIN trans_project_management_det b ON b.project_management_id = a.project_management_id
            LEFT JOIN {0}.lib_erp_project c ON c.project_id = a.project_id
            LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id
            LEFT JOIN {0}.lib_erp_department e ON e.department_id = b.department_id
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
        If Not all_year Then
            If year_reference <> "" Then
                sqlHead &= String.Format(" AND a.pm_year = '{0}'", year_reference)
            End If
        End If
        If project_id <> "" Then
            sqlHead &= String.Format(" AND a.project_id = '{0}'", project_id)
        End If
        If currency_id <> "" Then
            sqlHead &= String.Format(" AND b.currency_id = '{0}'", currency_id)
        End If
        If asOf Then
            sqlHead &= String.Format(" AND b.trans_date <= '{0}'", date_to.ToString("yyyy-MM-dd"))
        Else
            sqlHead &= String.Format(" AND b.trans_date BETWEEN '{0}' AND '{1}'", date_from.ToString("yyyy-MM-dd"), date_to.ToString("yyyy-MM-dd"))
        End If

        Dim sqlBilling As String = String.Format("SELECT a.trans_project_management_id,a.trans_id,a.project_management_det_id
            ,a.billed_amount,a.billed_amount_based,a.currency_id,a.exchange_rate,a.based_rate
            ,b.trans_no,b.trans_date
            FROM trans_header_project_management a
            LEFT JOIN trans_header b ON b.trans_id = a.trans_id")
        Dim sqlCollection As String = String.Format("SELECT a.offset_project_management_id,a.jbooks_id,a.trans_project_management_id
            ,a.amount_collected,a.amount_collected_based,a.currency_id,a.exchange_rate,a.based_rate
            ,b.trans_id,c.trans_no,c.trans_date
            FROM trans_project_management_offset a
            LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id
            LEFT JOIN trans_header c ON c.trans_id = b.trans_id
        ")
        dtCompany = Query(sqlCompany)
        dtHead = Query(sqlHead)
        dtBilling = Query(sqlBilling)
        dtCollection = Query(sqlCollection)
        dtCompany.TableName = "lib_erp_company"
        dtHead.TableName = "project_management"
        dtBilling.TableName = "project_management_billing"
        dtCollection.TableName = "project_management_collection"
        ds.Tables.Add(dtCompany)
        ds.Tables.Add(dtHead)
        ds.Tables.Add(dtBilling)
        ds.Tables.Add(dtCollection)
        Return ds
    End Function
    Public Sub GenerateExcel(ByVal ds As DataSet)
        Dim company_name As String = ds.Tables("lib_erp_company").Rows(0)("company_name").ToString().ToUpper()
        Dim report_name As String = "Project Management"
        Dim report_label As String = ""

        If asOf Then
            report_label = String.Format("AS OF {0:d}", date_to)
        Else
            report_label = String.Format("FROM {0:d} TO {0:d}", date_from, date_to)
        End If

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

        xlWorkSheet.Cells(5, 1) = "Const. Period"
        xlWorkSheet.Cells(5, 2) = "P.O. No"
        xlWorkSheet.Cells(5, 3) = "Project No"
        xlWorkSheet.Cells(5, 4) = "Project Name"
        xlWorkSheet.Cells(5, 5) = "Contract Amount"
        xlWorkSheet.Cells(5, 6) = "Billed"
        xlWorkSheet.Cells(5, 7) = "Unbilled"
        xlWorkSheet.Cells(5, 8) = "Payment"
        xlWorkSheet.Cells(5, 9) = "Balance"

        ExcelRange(xlWorkSheet, 1, 1).ColumnWidth = 25
        ExcelRange(xlWorkSheet, 1, 2).ColumnWidth = 15
        ExcelRange(xlWorkSheet, 1, 3).ColumnWidth = 15
        ExcelRange(xlWorkSheet, 1, 4).ColumnWidth = 30
        ExcelRange(xlWorkSheet, 1, 5,, 9).ColumnWidth = 15

        ExcelRange(xlWorkSheet, 1, 1, 1, 9).MergeCells = True
        ExcelRange(xlWorkSheet, 2, 1, 2, 9).MergeCells = True
        ExcelRange(xlWorkSheet, 3, 1, 3, 9).MergeCells = True

        ExcelRange(xlWorkSheet, 1, 1, 1, 9).Font.Bold = True
        ExcelRange(xlWorkSheet, 2, 1, 2, 9).Font.Bold = True
        ExcelRange(xlWorkSheet, 3, 1, 3, 9).Font.Bold = True

        ExcelRange(xlWorkSheet, 1, 1, 1, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        ExcelRange(xlWorkSheet, 2, 1, 2, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        ExcelRange(xlWorkSheet, 3, 1, 3, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        ExcelRange(xlWorkSheet, 1, 1, 1, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        ExcelRange(xlWorkSheet, 2, 1, 2, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        ExcelRange(xlWorkSheet, 3, 1, 3, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ExcelRange(xlWorkSheet, 5, 1,, 9).Font.Bold = True
        ExcelRange(xlWorkSheet, 5, 1,, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        ExcelRange(xlWorkSheet, 5, 1,, 9).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        Dim first_row As Integer = 6
        Dim current_row As Integer = first_row
        For Each dr As DataRow In ds.Tables("project_management").Rows
            xlWorkSheet.Cells(current_row, 1) = String.Format("{0:d}-{1:d}", CDate(dr("date_from")), CDate(dr("date_to")))
            xlWorkSheet.Cells(current_row, 2) = dr("po_no")
            xlWorkSheet.Cells(current_row, 3) = dr("department_code")
            xlWorkSheet.Cells(current_row, 4) = dr("project_name")
            xlWorkSheet.Cells(current_row, 5) = dr("contract_amount")
            xlWorkSheet.Cells(current_row, 6) = dr("billed_amount")
            xlWorkSheet.Cells(current_row, 7) = dr("unbilled_amount")
            xlWorkSheet.Cells(current_row, 8) = dr("amount_collected")
            xlWorkSheet.Cells(current_row, 9) = dr("balance_amount")
            Dim contract_amount As Decimal = dr("contract_amount")
            current_row += 1
            Dim drBillings = ds.Tables("project_management_billing").Select(String.Format("project_management_det_id = '{0}'", dr("project_management_det_id")))
            For Each drBilling As DataRow In drBillings
                contract_amount -= drBilling("billed_amount")
                xlWorkSheet.Cells(current_row, 1) = "BILLING"
                xlWorkSheet.Cells(current_row, 2) = drBilling("trans_no")
                xlWorkSheet.Cells(current_row, 3) = String.Format("{0:d}", drBilling("trans_date"))
                xlWorkSheet.Cells(current_row, 6) = drBilling("billed_amount")
                xlWorkSheet.Cells(current_row, 7) = contract_amount
                Dim billed_amount As Decimal = drBilling("billed_amount")
                current_row += 1
                Dim drCollections = ds.Tables("project_management_collection").Select(String.Format("trans_project_management_id = '{0}'", drBilling("trans_project_management_id")))
                For Each drCollection As DataRow In drCollections
                    billed_amount -= drCollection("amount_collected")
                    xlWorkSheet.Cells(current_row, 1) = "COLLECTION"
                    xlWorkSheet.Cells(current_row, 2) = drCollection("trans_no")
                    xlWorkSheet.Cells(current_row, 3) = String.Format("{0:d}", drCollection("trans_date"))
                    xlWorkSheet.Cells(current_row, 8) = drCollection("amount_collected")
                    xlWorkSheet.Cells(current_row, 9) = billed_amount
                    current_row += 1
                Next
            Next
        Next
        Dim formatRange As Excel.Range
        formatRange = xlWorkSheet.Range("f6", String.Format("f{0}", current_row))
        formatRange.NumberFormat = "#,###,###.00"

        ExcelRange(xlWorkSheet, first_row, 6, current_row, 6).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
    End Sub
    Public Function ExcelRange(ByRef xlWorkSheet As Excel.Worksheet, ByRef fr As Integer, ByRef fc As Integer, Optional lr As Integer = -1, Optional lc As Integer = -1) As Excel.Range
        lc = If(lc < 0, fc, lc)
        lr = If(lr < 0, fr, lr)
        Return xlWorkSheet.Range(xlWorkSheet.Cells(fr, fc), xlWorkSheet.Cells(lr, lc))
    End Function
End Class
