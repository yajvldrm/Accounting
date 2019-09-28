Imports DevExpress.XtraEditors
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Public Class NewControls
    Public Shared Sub bindControl(ByVal hdr As Control, ByVal row As DataRow, Optional hasTransDate As Boolean = False)
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.MyTextBox Then
                Dim txt = CType(ctrl, user_control.MyTextBox)
                If txt.ValueSource <> "" Then
                    If row.Table.Columns.Contains(txt.ValueSource) Then
                        If txt.NumberFormat.ToString.Contains("#") Then
                            Dim tmpdt = row.Table
                            Dim tmp_value = row.Item(txt.ValueSource).ToString
                            txt.DecimalValue = If(tmp_value = "", 0, tmp_value)
                        Else
                            txt.Value = row.Item(txt.ValueSource).ToString
                        End If
                    End If
                End If
                If txt.TextSource <> "" Then
                    If row.Table.Columns.Contains(txt.TextSource) Then
                        txt.Text = row.Item(txt.TextSource).ToString
                    End If
                End If
            ElseIf TypeOf ctrl Is user_control.myDatePicker Then
                Dim txt = CType(ctrl, user_control.myDatePicker)
                If row.Table.Columns.Contains(txt.TextSource) Then
                    Dim str_date = row.Item(txt.TextSource).ToString
                    Dim tmp_date = CDate(If(str_date = "", txt.MinDate, str_date))
                    txt.Value = If(tmp_date < txt.MinDate, txt.MinDate, tmp_date)
                End If
            ElseIf TypeOf ctrl Is TextEdit Then
                Dim txt = CType(ctrl, TextEdit)
                If txt.Tag.ToString <> "" Then
                    If row.Table.Columns.Contains(txt.Tag) Then
                        txt.EditValue = row.Item(txt.Tag.ToString)
                    End If
                End If
            ElseIf TypeOf ctrl Is user_control.textbox Then
                Dim txt = CType(ctrl, user_control.textbox)
                If txt.ValueSource <> "" Then
                    If row.Table.Columns.Contains(txt.ValueSource) Then
                        If txt.NumberFormat.ToString.Contains("#") Then
                            Dim tmpdt = row.Table
                            Dim tmp_value = row.Item(txt.ValueSource).ToString
                            txt.DecimalValue = If(tmp_value = "", 0, tmp_value)
                        Else
                            txt.Value = row.Item(txt.ValueSource).ToString
                        End If
                    End If
                End If
                If txt.TextSource <> "" Then
                    If row.Table.Columns.Contains(txt.TextSource) Then
                        txt.Text = row.Item(txt.TextSource).ToString
                    End If
                End If
            ElseIf TypeOf ctrl Is System.Windows.Forms.TextBox Then
                Dim txt = CType(ctrl, System.Windows.Forms.TextBox)
                Dim tag As String = txt.Tag.ToString
                If row.Table.Columns.Contains(tag) Then
                    txt.Text = row.Item(tag).ToString
                End If
            ElseIf TypeOf ctrl Is System.Windows.Forms.DateTimePicker Then
                Dim txt = CType(ctrl, System.Windows.Forms.DateTimePicker)
                Dim tag As String = txt.Tag.ToString
                If row.Table.Columns.Contains(tag) Then
                    txt.Value = row.Item(tag)
                End If
            ElseIf TypeOf ctrl Is System.Windows.Forms.CheckBox Then
                Dim txt = CType(ctrl, System.Windows.Forms.CheckBox)
                Dim tag As String = txt.Tag.ToString
                If row.Table.Columns.Contains(tag) Then
                    txt.Checked = row.Item(tag)
                End If

            ElseIf TypeOf ctrl Is System.Windows.Forms.NumericUpDown Then
                Dim txt = CType(ctrl, System.Windows.Forms.NumericUpDown)
                Dim tag As String = txt.Tag.ToString
                If row.Table.Columns.Contains(tag) Then
                    ' txt.Value = row.Item(tag).ToString
                End If
            End If
        Next
        If hasTransDate Then
            Dim txtMonth = CType(hdr.Controls.Find("txt_month", True)(0), user_control.MyTextBox)
            Dim txtDay = CType(hdr.Controls.Find("txt_day", True)(0), user_control.MyTextBox)
            Dim txtYear = CType(hdr.Controls.Find("txt_year", True)(0), user_control.MyTextBox)
            Dim trans_date = CDate(row.Item("trans_date").ToString)
            txtMonth.Value = trans_date.Month
            txtMonth.Text = MonthName(trans_date.Month)
            txtDay.Text = trans_date.Day
            txtYear.Text = trans_date.Year
        End If
    End Sub
    Public Shared Sub clearControl(ByVal hdr As Control, Optional isHeader As Boolean = False)
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.MyTextBox Then
                Dim txt = CType(ctrl, user_control.MyTextBox)
                If isHeader Then
                    If txt.Name <> "txt_month" And txt.Name <> "txt_year" Then
                        If txt.NumberFormat.ToString.Contains("#") Then
                            txt.Text = "0"
                            txt.Value = "0"
                        Else
                            txt.Text = ""
                            txt.Value = ""
                            If txt.TextBrowse Then
                                txt.RowData = Nothing
                            End If
                        End If
                        If txt.Name = "txt_day" Then
                            txt.DecimalValue = Today.Day
                        End If
                    End If
                Else
                    If txt.NumberFormat.ToString.Contains("#") Then
                        txt.DecimalValue = 0
                    Else
                        txt.Text = ""
                        txt.Value = ""
                        If txt.TextBrowse Then
                            txt.RowData = Nothing
                        End If
                    End If
                End If
            ElseIf TypeOf ctrl Is user_control.myDatePicker Then
                Dim txt = CType(ctrl, user_control.myDatePicker)
                txt.Value = Today.Date
            ElseIf TypeOf ctrl Is TextEdit Then
                Dim txt = CType(ctrl, TextEdit)
                txt.EditValue = Nothing
                If txt.Properties.DisplayFormat.FormatString.ToString <> "" Then
                    txt.EditValue = 0.00
                End If
            ElseIf TypeOf ctrl Is user_control.textbox Then
                Dim txt = CType(ctrl, user_control.textbox)
                If isHeader Then
                    If txt.Name <> "txt_month" And txt.Name <> "txt_year" Then
                        If txt.NumberFormat.ToString.Contains("#") Then
                            txt.Text = "0"
                            txt.Value = "0"
                        Else
                            txt.Text = ""
                            txt.Value = ""
                            txt.RowData = Nothing
                        End If
                        If txt.Name = "txt_day" Then
                            txt.DecimalValue = Today.Day
                        End If
                    End If
                Else
                    If txt.NumberFormat.ToString.Contains("#") Then
                        txt.DecimalValue = 0
                    Else
                        txt.Text = ""
                        txt.Value = ""
                        txt.RowData = Nothing
                    End If
                End If
            End If

        Next
    End Sub
    Public Shared Sub enableControl(ByVal hdr As Control, Optional toEnable As Boolean = True, Optional isHeader As Boolean = False)
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.MyTextBox Then
                Dim txt = CType(ctrl, user_control.MyTextBox)
                If toEnable Then
                    If Not txt.AlwaysDisable Then
                        txt.Enabled = True
                    End If
                Else
                    If Not txt.AlwaysEnable Then
                        txt.Enabled = False
                    End If
                End If
            ElseIf TypeOf ctrl Is user_control.myDatePicker Then
                Dim txt = CType(ctrl, user_control.myDatePicker)
                txt.Enabled = toEnable
            ElseIf TypeOf ctrl Is TextEdit Then
                Dim txt = CType(ctrl, TextEdit)
                If txt.Name <> "txtAmount" And txt.Name <> "txtAmountBased" Then
                    txt.Enabled = toEnable
                End If
            End If
        Next
    End Sub
    Public Shared Function existTransNo(ByVal strTransNo As String, strTransID As String) As Boolean
        Dim exist As Boolean = False
        Dim sql_test As String = String.Format("SELECT trans_no FROM trans_header WHERE trans_no = '{0}' AND trans_id <> '{1}'", strTransNo, strTransID)
        Dim dt_test As DataTable = Query(sql_test)
        exist = dt_test.Rows.Count > 0
        Return exist
    End Function
    Public Shared Sub getNewTransNo(ByRef strTransNo As String, ByVal journal_id As String, ByVal book_id As String, ByVal month As String, ByVal year As String, ByVal trans_id As String)
        Dim exist As Boolean = False
        exist = existTransNo(strTransNo, trans_id)
        If exist Then
            'call getnewtransno(1,8,1,2015);
            Dim sql_new_trans_no As String = String.Format("CALL getnewtransno({0},'{1}',{2},{3});", journal_id, book_id, month, year)
            Dim dt_new_trans_no As DataTable = Query(sql_new_trans_no)
            If dt_new_trans_no.Rows.Count > 0 Then
                strTransNo = dt_new_trans_no.Rows(0).Item("trans_no_new").ToString
            End If
            getNewTransNo(strTransNo, journal_id, book_id, month, year, trans_id)
        End If
    End Sub
    Public Shared Sub refreshRecordDet(ByRef dgjbooks As DataGridView, ByRef ds As DataSet, ByVal txt_trans_id As user_control.MyTextBox)
        ds.Tables("jbooks").Clear()
        ds.Tables("checks").Clear()
        ds.Tables("ewt").Clear()
        ds.Tables("input_vat").Clear()
        ds.Tables("output_vat").Clear()
        ds.Tables("fixed_asset").Clear()
        ds.Tables("prepaid").Clear()
        ds.Tables("final_tax").Clear()
        If Not ds.Tables("input_vat_for_importation") Is Nothing Then
            ds.Tables("input_vat_for_importation").Clear()
        End If
        'ds.Tables("trans_mfo_pap").Clear()
        If ds.Tables.Contains("trans_sub_contract_offset") Then
            ds.Tables("trans_sub_contract_offset").Clear()
            Dim sql_sc_offset As String = String.Format("SELECT a.offset_sub_contract_id,a.jbooks_id,a.trans_sub_contract_id,a.amount_collected,a.amount_collected_based
            ,a.currency_id,a.exchange_rate,a.based_rate,1 AS sel
            FROM trans_sub_contract_offset a
            LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id
            WHERE b.trans_id = '{0}'
            ", txt_trans_id.Text)
            Dim dt_sc_offset As DataTable = Query(sql_sc_offset)
            For Each dr As DataRow In dt_sc_offset.Rows
                ds.Tables("trans_sub_contract_offset").ImportRow(dr)
            Next
        End If
        If ds.Tables.Contains("project_management_offset") Then
            ds.Tables("project_management_offset").Clear()
            Dim sql_pm_offset = String.Format("SELECT a.offset_project_management_id,a.jbooks_id,a.trans_project_management_id,a.amount_collected,a.amount_collected_based,a.currency_id,a.exchange_rate,a.based_rate,1 AS sel
                FROM trans_project_management_offset a
                LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id
                WHERE b.trans_id = '{0}'
            ", txt_trans_id.Text)
            Dim dt_pm_offset As DataTable = Query(sql_pm_offset)
            For Each dr As DataRow In dt_pm_offset.Rows
                ds.Tables("project_management_offset").ImportRow(dr)
            Next
        End If
        If ds.Tables.Contains("trans_sub_contract") Then
            ds.Tables("trans_sub_contract").Clear()

            Dim sql_project_management As String = String.Format("SELECT a.trans_sub_contract_id,a.trans_id,a.sub_contract_det_id,a.billed_amount,a.billed_amount_based
            ,a.currency_id,f.currency_code,f.currency_name,a.exchange_rate,a.based_rate
            ,b.subconid,e.subconcode,e.subconname,b.cons1,b.cons2,b.amount,b.amount_based,b.po_no
            ,b.trans_date
            ,sc_offset.amount_collected,sc_offset.amount_collected_based
            FROM trans_header_sub_contract a
            LEFT JOIN trans_sub_contract_det b ON b.sub_contract_det_id = a.sub_contract_det_id
            LEFT JOIN trans_sub_contract c ON c.sub_contract_id = b.sub_contract_id
            LEFT JOIN {1}.lib_erp_project d ON d.project_id = c.project_id
            LEFT JOIN {1}.lib_subcon e ON e.subConid = b.subconid
            LEFT JOIN {1}.lib_erp_currency f ON f.currency_id = a.currency_id
            LEFT JOIN (
	            SELECT a.trans_sub_contract_id
	            ,SUM(a.amount_collected) AS amount_collected
	            ,SUM(a.amount_collected_based) AS amount_collected_based
	            FROM trans_sub_contract_offset a
	            GROUP BY a.trans_sub_contract_id
            ) sc_offset ON sc_offset.trans_sub_contract_id = a.trans_sub_contract_id
            WHERE a.trans_id='{2}'", _serverDBMain, _serverDBFS, txt_trans_id.Text)
            Dim dt_project_management As DataTable = Query(sql_project_management)
            For Each dr As DataRow In dt_project_management.Rows
                ds.Tables("trans_sub_contract").ImportRow(dr)
            Next
        End If
        If ds.Tables.Contains("project_management") Then
            ds.Tables("project_management").Clear()
            Dim sql_project_management As String = String.Format("SELECT b.trans_project_management_id,a.trans_id,a.trans_no,a.trans_date
        ,b.project_management_det_id,d.pm_year
        ,d.project_id,e.project_code,e.project_name
        ,d.general_id,f.general_code,f.general_name
        ,c.department_code,c.project_name AS project_name_det
        ,c.contract_amount,c.contract_amount_based
        ,b.billed_amount,b.billed_amount_based
        ,IFNULL(c.contract_amount,0) - IFNULL(b.billed_amount,0) AS balance_amount
        ,IFNULL(c.contract_amount_based,0) - IFNULL(b.billed_amount_based,0) AS balance_amount_based
        FROM trans_header a
        LEFT JOIN trans_header_project_management b ON b.trans_id = a.trans_id
        LEFT JOIN (
	        SELECT a.project_management_det_id,a.project_management_id
	        ,a.department_code,a.project_name
	        ,a.contract_amount,a.contract_amount_based
	        ,IFNULL(a.contract_amount,0) - IFNULL(b.billed_amount,0) AS billed_amount
	        ,IFNULL(a.contract_amount_based,0) - IFNULL(b.billed_amount_based,0) AS billed_amount_based
	        FROM trans_project_management_det a
	        LEFT JOIN (
		        SELECT a.project_management_det_id
		        ,SUM(a.billed_amount) AS billed_amount
		        ,SUM(a.billed_amount_based) AS billed_amount_based
		        FROM trans_header_project_management a
		        GROUP BY a.project_management_det_id
	        ) b ON b.project_management_det_id = b.project_management_det_id
            GROUP BY a.project_management_det_id
        ) c ON c.project_management_det_id = b.project_management_det_id
        LEFT JOIN trans_project_management d ON d.project_management_id = c.project_management_id
        LEFT JOIN {0}.lib_erp_project e ON e.project_id = d.project_id
        LEFT JOIN {0}.lib_erp_general f ON f.general_id = d.general_id
        WHERE a.trans_id = '{1}' AND IFNULL(b.project_management_det_id,'') <> '' and d.deleted=0
        ", _serverDBFS, txt_trans_id.Text)
            Dim dt_project_management As DataTable = Query(sql_project_management)
            For Each dr As DataRow In dt_project_management.Rows
                ds.Tables("project_management").ImportRow(dr)
            Next
        End If

        If ds.Tables.Contains("detailed_particular") Then
            ds.Tables("particular").Clear()
            Dim sql_det_particular As String = String.Format("
                    select a.trans_detailed_particular_id, a.trans_id, a.po_no,a.rr_no,a.dr_no,a.si_no,a.due_date,ROUND(a.trans_header_detailed_amount, 2) as trans_header_detailed_amount 
                    from trans_header_detailed_particular a
                    WHERE trans_id = '{0}'", txt_trans_id.Text)
            Dim dt_det_particular As DataTable = Query(sql_det_particular)
            For Each dr As DataRow In dt_det_particular.Rows
                ds.Tables("detailed_particular").ImportRow(dr)
            Next
        End If

        ''Additional
        'If ds.Tables.Contains("trans_mfo_pap") Then
        '    ds.Tables("trans_mfo_pap").Clear()
        '    Dim sql_mfo_pap As String = String.Format("
        '            select * from trans_mfo_pap 
        '            WHERE trans_id = '{0}'", txt_trans_id.Text)
        '    Dim dt_mfo_pap As DataTable = Query(sql_mfo_pap)
        '    For Each dr As DataRow In dt_mfo_pap.Rows
        '        ds.Tables("trans_mfo_pap").ImportRow(dr)
        '    Next
        'End If

        Dim sql As String = String.Format("SELECT a.* " &
            ",IF(b.offset_ar <> 0 AND b.offset_ar IS NOT NULL,b.offset_ar,IF(b.offset_ap <> 0 AND b.offset_ap IS NOT NULL,b.offset_ap,IF(b.offset_ewt <> 0 AND b.offset_ewt IS NOT NULL,b.offset_ewt,IF(b.offset_final_tax <> 0 AND b.offset_final_tax IS NOT NULL,b.offset_final_tax,IF(b.offset_input_vat <> 0 AND b.offset_input_vat IS NOT NULL,b.offset_input_vat,IF(b.offset_output_vat <> 0 AND b.offset_output_vat IS NOT NULL,b.offset_output_vat,IF(b.offset_prepaid <> 0 AND b.offset_prepaid IS NOT NULL,b.offset_prepaid,IF(b.offset_fixed_asset <> 0 AND b.offset_fixed_asset IS NOT NULL,b.offset_fixed_asset,0)))))))) AS offset " &
            ",IF(b.offset_ar IS NOT NULL AND b.offset_ar > 0,c.credit,IF(b.offset_ap IS NOT NULL AND b.offset_ap > 0,c.debit,0)) AS minimum " &
            "FROM select_jbooks a " &
            "LEFT JOIN selectReferenceOffset b ON b.jbooks_id = a.jbooks_id " &
            "LEFT JOIN selectReferenceARAP c ON c.jbooks_id = a.jbooks_id " &
            "WHERE trans_id = {2}" &
            "", _serverDBFS, _serverDBMain, txt_trans_id.Text)
        Dim dt As DataTable = Query(sql)

        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("jbooks").NewRow
            For j = 0 To dt.Columns.Count - 1
                If dr.Table.Columns.Contains(dt.Columns(j).ColumnName) Then
                    dr(dt.Columns(j).ColumnName) = If(IsDBNull(dt.Rows(i)(dt.Columns(j).ColumnName)), "", dt.Rows(i)(dt.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("jbooks").Rows.Add(dr)
        Next
        dgjbooks.DataSource = ds.Tables("jbooks")
        For Each row As DataGridViewRow In dgjbooks.Rows
            If row.Cells("offset").Value Then
                row.ReadOnly = True
            End If
        Next

        'ewt
        Dim sql_ewt = String.Format("SELECT * FROM select_ewt " &
                                    "WHERE trans_id = {0}", txt_trans_id.Text, _serverDBFS)
        Dim dt_ewt As DataTable = Query(sql_ewt)
        For i = 0 To dt_ewt.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("ewt").NewRow
            For j = 0 To dt_ewt.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_ewt.Columns(j).ColumnName) Then
                    dr(dt_ewt.Columns(j).ColumnName) = If(IsDBNull(dt_ewt.Rows(i)(dt_ewt.Columns(j).ColumnName)), "", dt_ewt.Rows(i)(dt_ewt.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("ewt").Rows.Add(dr)
        Next

        'final_tax
        Dim sql_finaltax = String.Format("SELECT * FROM select_final_tax " &
                                    "WHERE trans_id = {0}", txt_trans_id.Text, _serverDBFS)
        Dim dt_finaltax As DataTable = Query(sql_finaltax)
        For i = 0 To dt_finaltax.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("final_tax").NewRow
            For j = 0 To dt_finaltax.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_finaltax.Columns(j).ColumnName) Then
                    dr(dt_finaltax.Columns(j).ColumnName) = If(IsDBNull(dt_finaltax.Rows(i)(dt_finaltax.Columns(j).ColumnName)), "", dt_finaltax.Rows(i)(dt_finaltax.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("final_tax").Rows.Add(dr)
        Next

        'inputvat
        Dim sql_inputvat = String.Format("SELECT * FROM select_input_vat " &
                                    "WHERE trans_id = {0} and (for_importation = '0' or for_importation = '') ", txt_trans_id.Text, _serverDBFS)
        Dim dt_inputvat As DataTable = Query(sql_inputvat)
        For i = 0 To dt_inputvat.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("input_vat").NewRow
            For j = 0 To dt_inputvat.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_inputvat.Columns(j).ColumnName) Then
                    dr(dt_inputvat.Columns(j).ColumnName) = If(IsDBNull(dt_inputvat.Rows(i)(dt_inputvat.Columns(j).ColumnName)), "", dt_inputvat.Rows(i)(dt_inputvat.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("input_vat").Rows.Add(dr)
        Next

        'input_vat_for_importation
        Dim sql_inputvat_for_importation = String.Format("SELECT a.import_Entry_id,a.Import_Entry_no, " +
                                                        "a.Release_Date,a.Taxable_goods,a.Date_of_importation, " +
                                                        "a.Dutiable_value,a.date_of_vatpayment, " +
                                                        "a.country_of_origin,a.OR_number,a.Total_Landed_Cost ,a.all_charges_before_release_from_customs,a.exempt  ,b.*  " +
                                                        "FROM {1}.trans_input_vat_importation a  " +
                                                        "INNER JOIN {1}.select_input_vat b ON a.input_vat_id = b.input_vat_id  " +
                                                        "where b.trans_id = '{0}'", txt_trans_id.Text, _serverDBMain)
        Dim dt_inputvat_for_importation As DataTable = Query(sql_inputvat_for_importation)
        For i = 0 To dt_inputvat_for_importation.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("input_vat_for_importation").NewRow
            For j = 0 To dt_inputvat_for_importation.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_inputvat_for_importation.Columns(j).ColumnName) Then
                    dr(dt_inputvat_for_importation.Columns(j).ColumnName) = If(IsDBNull(dt_inputvat_for_importation.Rows(i)(dt_inputvat_for_importation.Columns(j).ColumnName)), "", dt_inputvat_for_importation.Rows(i)(dt_inputvat_for_importation.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("input_vat_for_importation").Rows.Add(dr)
        Next

        'outputvat
        Dim sql_outputvat = String.Format("SELECT * FROM select_output_vat " &
                                    "WHERE trans_id = {0}", txt_trans_id.Text, _serverDBFS)
        Dim dt_outputvat As DataTable = Query(sql_outputvat)
        For i = 0 To dt_outputvat.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("output_vat").NewRow
            For j = 0 To dt_outputvat.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_outputvat.Columns(j).ColumnName) Then
                    dr(dt_outputvat.Columns(j).ColumnName) = If(IsDBNull(dt_outputvat.Rows(i)(dt_outputvat.Columns(j).ColumnName)), "", dt_outputvat.Rows(i)(dt_outputvat.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("output_vat").Rows.Add(dr)
        Next

        'prepaid
        Dim sql_prepaid = String.Format("SELECT * FROM select_prepaid " &
                                    "WHERE trans_id = {0}", txt_trans_id.Text)
        Dim dt_prepaid As DataTable = Query(sql_prepaid)
        For i = 0 To dt_prepaid.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("prepaid").NewRow
            For j = 0 To dt_prepaid.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_prepaid.Columns(j).ColumnName) Then
                    dr(dt_prepaid.Columns(j).ColumnName) = If(IsDBNull(dt_prepaid.Rows(i)(dt_prepaid.Columns(j).ColumnName)), "", dt_prepaid.Rows(i)(dt_prepaid.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("prepaid").Rows.Add(dr)
        Next

        'fixed_asset
        Dim sql_fixedasset = String.Format("SELECT * FROM select_fixed_asset " &
                                    "WHERE trans_id = {0}", txt_trans_id.Text)
        Dim dt_fixedasset As DataTable = Query(sql_fixedasset)
        For i = 0 To dt_fixedasset.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("fixed_asset").NewRow
            For j = 0 To dt_fixedasset.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_fixedasset.Columns(j).ColumnName) Then
                    dr(dt_fixedasset.Columns(j).ColumnName) = If(IsDBNull(dt_fixedasset.Rows(i)(dt_fixedasset.Columns(j).ColumnName)), "", dt_fixedasset.Rows(i)(dt_fixedasset.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("fixed_asset").Rows.Add(dr)
        Next

        'checks
        Dim sql_checks = String.Format("SELECT * FROM select_checks " &
                                    "WHERE trans_id = {0}", txt_trans_id.Text, _serverDBFS)
        Dim dt_checks As DataTable = Query(sql_checks)
        For i = 0 To dt_checks.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("checks").NewRow
            For j = 0 To dt_checks.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_checks.Columns(j).ColumnName) Then
                    dr(dt_checks.Columns(j).ColumnName) = If(IsDBNull(dt_checks.Rows(i)(dt_checks.Columns(j).ColumnName)), DBNull.Value, dt_checks.Rows(i)(dt_checks.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("checks").Rows.Add(dr)

        Next
        'trans_header_particular
        Dim sql_particular = String.Format("SELECT * FROM trans_header_particular " &
                                    "WHERE trans_id = {0}", txt_trans_id.Text)
        Dim dt_particular As DataTable = Query(sql_particular)
        For i = 0 To dt_particular.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("particular").NewRow
            For j = 0 To dt_particular.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_particular.Columns(j).ColumnName) Then
                    dr(dt_particular.Columns(j).ColumnName) = If(IsDBNull(dt_particular.Rows(i)(dt_particular.Columns(j).ColumnName)), "", dt_particular.Rows(i)(dt_particular.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("particular").Rows.Add(dr)
        Next
    End Sub
End Class
