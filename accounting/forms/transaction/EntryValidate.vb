Imports System.Windows.Forms
Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports DevExpress.XtraEditors
Module EntryValidate
#Region "Backup Code"

#End Region
    Public Sub NewValidateEntry(ByVal frm As Form, ByVal dgjbooks As DataGridView, ByRef ds As DataSet, Optional dnref As Boolean = False, Optional BookCode As String = "", Optional JournalCode As String = "", Optional BookID As String = "0")

        Dim IsRounded As Boolean = False

        Dim months As New Dictionary(Of String, Integer)
        months.Add("January", 1)
        months.Add("February", 2)
        months.Add("March", 3)
        months.Add("April", 4)
        months.Add("May", 5)
        months.Add("June", 6)
        months.Add("July", 7)
        months.Add("August", 8)
        months.Add("September", 9)
        months.Add("October", 10)
        months.Add("November", 11)
        months.Add("December", 12)

        Dim lbldebittotal As Label = CType(frm.Controls.Find("lbldebittotal", True)(0), Label)
        Dim propEntryValidated As System.Reflection.PropertyInfo = Nothing
        Try
            propEntryValidated = frm.GetType.GetProperty("entryValidated")
        Catch
        End Try
        Dim txt_account_id As user_control.MyTextBox = CType(frm.Controls.Find("txt_account_id", True)(0), user_control.MyTextBox)

        Dim txt_debit As user_control.MyTextBox = Nothing
        Dim txtDebit As TextEdit = Nothing
        If frm.Controls.Find("txt_debit", True).Length > 0 Then
            txt_debit = CType(frm.Controls.Find("txt_debit", True)(0), user_control.MyTextBox)
        Else
            txtDebit = CType(frm.Controls.Find("txtDebit", True)(0), TextEdit)
        End If
        Dim txt_debit_based As user_control.MyTextBox = Nothing
        Dim txtDebitBased As TextEdit = Nothing
        If frm.Controls.Find("txt_debit_based", True).Length > 0 Then
            txt_debit_based = CType(frm.Controls.Find("txt_debit_based", True)(0), user_control.MyTextBox)
        Else
            txtDebitBased = CType(frm.Controls.Find("txtDebitBased", True)(0), TextEdit)
        End If
        Dim txt_book_unit_no_id As user_control.MyTextBox = CType(frm.Controls.Find("txt_book_unit_no_id", True)(0), user_control.MyTextBox)
        Dim txt_trans_id As user_control.MyTextBox = CType(frm.Controls.Find("txt_trans_id", True)(0), user_control.MyTextBox)
        Dim txt_trans_no As user_control.MyTextBox = CType(frm.Controls.Find("txt_trans_no", True)(0), user_control.MyTextBox)
        Dim txt_description As user_control.MyTextBox = CType(frm.Controls.Find("txt_description", True)(0), user_control.MyTextBox)
        Dim txt_tmp_jbooks_id As user_control.MyTextBox = CType(frm.Controls.Find("txt_tmp_jbooks_id", True)(0), user_control.MyTextBox)
        Dim txt_general_id As user_control.MyTextBox = CType(frm.Controls.Find("txt_general_id", True)(0), user_control.MyTextBox)
        Dim txt_currency_id_det As user_control.MyTextBox = CType(frm.Controls.Find("txt_currency_id_det", True)(0), user_control.MyTextBox)
        Dim txt_project_id As user_control.MyTextBox = CType(frm.Controls.Find("txt_project_id", True)(0), user_control.MyTextBox)
        Dim txt_department_id As user_control.MyTextBox = CType(frm.Controls.Find("txt_department_id", True)(0), user_control.MyTextBox)
        Dim txt_year As user_control.MyTextBox = CType(frm.Controls.Find("txt_year", True)(0), user_control.MyTextBox)
        Dim txt_month As user_control.MyTextBox = CType(frm.Controls.Find("txt_month", True)(0), user_control.MyTextBox)
        Dim txt_day As user_control.MyTextBox = CType(frm.Controls.Find("txt_day", True)(0), user_control.MyTextBox)
        Dim txt_exchange_rate_det As user_control.MyTextBox = Nothing
        Dim txtExchangeRateDet As TextEdit = Nothing
        If frm.Controls.Find("txt_exchange_rate_det", True).Length > 0 Then
            txt_exchange_rate_det = CType(frm.Controls.Find("txt_exchange_rate_det", True)(0), user_control.MyTextBox)
        Else
            txtExchangeRateDet = CType(frm.Controls.Find("txtExchangeRateDet", True)(0), TextEdit)
        End If
        Dim txt_based_rate_det As user_control.MyTextBox = Nothing
        Dim txtBasedRateDet As TextEdit = Nothing
        If frm.Controls.Find("txt_based_rate_det", True).Length > 0 Then
            txt_based_rate_det = CType(frm.Controls.Find("txt_based_rate_det", True)(0), user_control.MyTextBox)
        Else
            txtBasedRateDet = CType(frm.Controls.Find("txtBasedRateDet", True)(0), TextEdit)
        End If
        Dim txt_credit As user_control.MyTextBox = Nothing
        Dim txtCredit As TextEdit = Nothing
        If frm.Controls.Find("txt_credit", True).Length > 0 Then
            txt_credit = CType(frm.Controls.Find("txt_credit", True)(0), user_control.MyTextBox)
        Else
            txtCredit = CType(frm.Controls.Find("txtCredit", True)(0), TextEdit)
        End If
        Dim txt_credit_based As user_control.MyTextBox = Nothing
        Dim txtCreditBased As TextEdit = Nothing
        If frm.Controls.Find("txt_credit_based", True).Length > 0 Then
            txt_credit_based = CType(frm.Controls.Find("txt_credit_based", True)(0), user_control.MyTextBox)
        Else
            txtCreditBased = CType(frm.Controls.Find("txtCreditBased", True)(0), TextEdit)
        End If
        Dim txt_general_id_det As user_control.MyTextBox = CType(frm.Controls.Find("txt_general_id_det", True)(0), user_control.MyTextBox)
        Dim txt_general_name As user_control.MyTextBox = CType(frm.Controls.Find("txt_general_name", True)(0), user_control.MyTextBox)
        Dim txt_general_name_det As user_control.MyTextBox = CType(frm.Controls.Find("txt_general_name_det", True)(0), user_control.MyTextBox)
        Dim trans_date = New DateTime(txt_year.Text, txt_month.Value, txt_day.Text)
        '1 - Bank / Cash
        '2 - AR (debit)
        '3 - AP (credit)
        '4 - EWT (credit) Tax Amount
        '5 - Final Tax (credit) Tax Amount
        '6 - Input VAT (debit) Vat Amount
        '7 - Output VAT (credit) Vat Amount
        '8 - Prepayment (debit) Amount
        '9 - Fixed Asset (debit) Amount
        '10 - Gain or Loss
        Dim sel_ewt As DataTable = ds.Tables("ewt").Clone
        Dim sel_final_tax As DataTable = ds.Tables("final_tax").Clone
        Dim sel_input_vat As DataTable = ds.Tables("input_vat").Clone
        Dim sel_output_vat As DataTable = ds.Tables("output_vat").Clone
        Dim sel_prepaid As DataTable = ds.Tables("prepaid").Clone
        Dim sel_fixed_asset As DataTable = ds.Tables("fixed_asset").Clone
        Dim jbooks_id = If(dgjbooks.SelectedRows.Count > 0, ds.Tables("jbooks").Rows(dgjbooks.SelectedRows(0).Index)("jbooks_id_tmp"), 0)
        If Not txt_account_id.RowData Is Nothing Then
            Dim v As Integer = txt_account_id.RowData("validation")
            Dim debit As Decimal = 0.0
            Dim credit As Decimal = 0.0

            Dim txtDebitValue As Decimal = 0
            Dim txtCreditValue As Decimal = 0

            If "23456789".IndexOf(v.ToString) >= 0 Then
                'frm.Visible = False
            End If
            If txt_debit IsNot Nothing Then
                txtDebitValue = txt_debit.DecimalValue
            Else
                txtDebitValue = txtDebit.EditValue
            End If
            If txt_credit IsNot Nothing Then
                txtCreditValue = txt_credit.DecimalValue
            Else
                txtCreditValue = txtCredit.EditValue
            End If
            If txtDebitValue <> 0 Then
                Select Case v
                    Case 1
                        Dim accountcode = txt_account_id.Text
                        If dnref Then
                            Dim tmp_dr() As DataRow = ds.Tables("checks").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("checks").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim cashap_ds As DataTable = cashor.ds.Tables("checks")
                            cashap_ds.Clear()
                            dtCopy(cashap_ds, tmp_dt, {"check_id", "check_no"})
                            'copyDataTable(cashap_ds, tmp_dt, "check_id")
                            cashor.jbooks_id = txt_tmp_jbooks_id.Text
                            cashor.genref_id = txt_general_id.Value
                            cashor.genref_code = txt_general_id.Text
                            cashor.genref_name = txt_general_name.Text
                            cashor.currency_id = txt_currency_id_det.Value
                            If txt_exchange_rate_det IsNot Nothing Then
                                cashor.exchange_rate = txt_exchange_rate_det.DecimalValue
                            Else
                                cashor.exchange_rate = txtExchangeRateDet.EditValue
                            End If
                            If txt_based_rate_det IsNot Nothing Then
                                cashor.based_rate = txt_based_rate_det.DecimalValue
                            Else
                                cashor.based_rate = txtBasedRateDet.EditValue
                            End If
                            cashor.trans_date = trans_date
                            Dim sql As String = String.Format("SELECT bank_id,bank_code,bank_name " &
                                "FROM lib_erp_bank " &
                                "WHERE bank_code = '{0}'", accountcode)
                            Dim dt As DataTable = FsQuery(sql)
                            If dt.Rows.Count > 0 Then
                                cashor.txt_bank_id.AlwaysDisable = True
                                cashor.txt_bank_id.NoClear = True
                                cashor.txt_bank_name_depository.NoClear = True
                                cashor.txt_bank_id.Text = dt.Rows(0).Item("bank_code")
                                cashor.txt_bank_id.Value = dt.Rows(0).Item("bank_id")
                                cashor.txt_bank_name_depository.Text = dt.Rows(0).Item("bank_name")
                                cashor.bankCode = dt.Rows(0).Item("bank_code")
                                cashor.bankID = dt.Rows(0).Item("bank_id")
                                cashor.bankName = dt.Rows(0).Item("bank_name")
                            Else
                                cashor.txt_bank_id.AlwaysDisable = False
                                cashor.txt_bank_id.NoClear = False
                                cashor.txt_bank_name_depository.NoClear = False
                            End If
                            'cashor.txt_check_amount.NoClear = True
                            'cashor.txt_check_amount_based.NoClear = True
                            If txt_debit IsNot Nothing Then
                                cashor.OutstandingBalance = txt_debit.DecimalValue
                                cashor.txtCheckAmount.EditValue = txt_debit.DecimalValue
                            Else
                                cashor.OutstandingBalance = txtDebit.EditValue
                                cashor.txtCheckAmount.EditValue = txtDebit.EditValue
                            End If
                            If txt_exchange_rate_det IsNot Nothing Then
                                cashor.txtCheckAmountBased.EditValue = cashor.txtCheckAmount.EditValue * (txt_exchange_rate_det.DecimalValue / txt_based_rate_det.DecimalValue)
                            Else
                                cashor.txtCheckAmountBased.EditValue = cashor.txtCheckAmount.EditValue * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue)
                            End If
                            'raymond - 2016-06-08 (start)
                            Dim sql_trans_jbooks As String = String.Format("SELECT b.ref_no,c.trans_no FROM trans_jbooks a LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id LEFT JOIN trans_header c ON c.trans_id = a.trans_id WHERE a.jbooks_id = '{0}'", txt_tmp_jbooks_id.Text)
                            Dim data_trans_jbooks As DataTable = Query(sql_trans_jbooks)
                            If data_trans_jbooks.Rows.Count = 0 Then
                                sql_trans_jbooks = String.Format("SELECT trans_no FROM trans_header WHERE trans_id = {0}", If(txt_trans_id.Text = "", 0, txt_trans_id.Text))
                                data_trans_jbooks = Query(sql_trans_jbooks)
                                If data_trans_jbooks.Rows.Count > 0 Then
                                    cashor.book_code = BookCode
                                    cashor.reference_no = data_trans_jbooks.Rows(0).Item("trans_no").ToString
                                    cashor.journal_code = JournalCode
                                Else
                                    cashor.reference_no = txt_trans_no.Text
                                End If
                            Else
                                cashor.book_code = BookCode
                                cashor.reference_no = data_trans_jbooks.Rows(0).Item("trans_no").ToString
                                cashor.journal_code = JournalCode
                            End If
                            'raymond - 2016-06-08 (end)
                            If cashor.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("checks"), cashor.ds.Tables("checks"), {"check_id"})
                                'copyDataTable(ds.Tables("checks"), cashor.ds.Tables("checks"), "check_id")
                            End If
                            debit = 0
                            If ds.Tables("checks").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                debit = ds.Tables("checks").Compute("Sum(check_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                credit = 0
                                txtDebit.Enabled = False
                                txtCredit.Enabled = False
                            End If
                        End If
                    Case 3
                        If dnref Then
                            Dim tmp_dr() As DataRow = ds.Tables("jbooks").Select("jbooks_id_tmp LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("jbooks").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim offset_ds As DataTable = offsetap.ds.Tables("jbooks")
                            offset_ds.Clear()
                            offsetap.BookID = BookID
                            offsetap.account_id = txt_account_id.Value
                            offsetap.trans_id = txt_trans_id.Text
                            offsetap.jbooks_id = txt_tmp_jbooks_id.Text
                            offsetap.general_id = txt_general_id_det.Value
                            offsetap.currency_id = txt_currency_id_det.Value
                            offsetap.project_id = txt_project_id.Value
                            offsetap.department_id = txt_department_id.Value
                            offsetap.filter_date = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                            offsetap.exchange_rate = txtExchangeRateDet.EditValue
                            offsetap.based_rate = txtBasedRateDet.EditValue
                            offsetap.book_unit_no_id = txt_book_unit_no_id.Value
                            offsetap.ds.Tables("trans_sub_contract_offset").Clear()
                            If ds.Tables.Contains("trans_sub_contract_offset") Then
                                If ds.Tables.Contains("trans_sub_contract_offset") Then
                                    For Each dr As DataRow In ds.Tables("trans_sub_contract_offset").Rows
                                        offsetap.ds.Tables("trans_sub_contract_offset").ImportRow(dr)
                                    Next
                                End If
                            End If

                            offsetap.refresh_data()
                            dtReplace(offset_ds, tmp_dt, "ref_jbooks_id")
                            If offsetap.ds.Tables("jbooks").Rows.Count > 0 Then
                                If offsetap.ShowDialog() = DialogResult.OK Then
                                    dtCopy(ds.Tables("jbooks"), offsetap.ds.Tables("jbooks"), {"ref_jbooks_id"}, "isInputted", "jbooks_id")
                                End If
                                debit = 0
                                If ds.Tables("jbooks").Select("jbooks_id_tmp LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Count > 0 Then
                                    debit = ds.Tables("jbooks").Compute("Sum(debit)", "jbooks_id_tmp LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    credit = 0
                                End If
                                If ds.Tables.Contains("trans_sub_contract_offset") Then
                                    Dim dtSCAP As DataTable = offsetap.ds.Tables("trans_sub_contract_offset")
                                    For Each dr As DataRow In dtSCAP.Rows
                                        Dim drs = ds.Tables("trans_sub_contract_offset").Select(String.Format("trans_sub_contract_id = '{0}'", dr("trans_sub_contract_id").ToString))
                                        If drs.Length > 0 Then
                                            drs(0).Item("jbooks_id") = tmp_dr(0).Item("jbooks_id") & tmp_dr(0).Item("ref_jbooks_id")
                                            drs(0).Item("amount_collected") = dr("amount_collected")
                                            drs(0).Item("amount_collected_based") = dr("amount_collected_based")
                                            If CBool(ifNull(dr("sel"), 0)) Then
                                                drs(0).Item("deleted") = False
                                            Else
                                                drs(0).Item("deleted") = True
                                            End If
                                        Else
                                            If Not CBool(ifNull(dr("deleted"), 0)) Then
                                                If CBool(ifNull(dr("sel"), 0)) Then
                                                    If tmp_dr.Length > 0 Then
                                                        dr("jbooks_id") = tmp_dr(0).Item("jbooks_id") & tmp_dr(0).Item("ref_jbooks_id")
                                                    Else
                                                        dr("jbooks_id") = txt_tmp_jbooks_id.Text
                                                    End If
                                                    ds.Tables("trans_sub_contract_offset").ImportRow(dr)
                                                End If
                                            End If
                                        End If
                                    Next
                                End If
                            Else
                                MsgBox("No Outstanding Balance.")
                            End If
                        End If
                    Case 4 'EWT (credit)
                        Dim tmp_dr() As DataRow = ds.Tables("ewt").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("ewt").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetewt.ds.Tables("ewt")
                        offset_ds.Clear()
                        offsetewt.BookID = BookID
                        offsetewt.account_id = txt_account_id.Value
                        offsetewt.trans_id = txt_trans_id.Text
                        offsetewt.jbooks_id = txt_tmp_jbooks_id.Text
                        offsetewt.general_id = txt_general_id.Value
                        offsetewt.currency_id = txt_currency_id_det.Value
                        offsetewt.project_id = txt_project_id.Value
                        offsetewt.department_id = txt_department_id.Value
                        offsetewt.filter_date = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                        offsetewt.exchange_rate = txtExchangeRateDet.EditValue
                        offsetewt.based_rate = txtBasedRateDet.EditValue
                        offsetewt.refresh_data()
                        'dtCopy(offset_ds, tmp_dt)
                        dtReplace(offset_ds, tmp_dt, "ref_ewt_id")
                        If offsetewt.ds.Tables("ewt").Rows.Count > 0 Then
                            If offsetewt.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("ewt"), offsetewt.ds.Tables("ewt"), {"ref_ewt_id"}, "isInputted", "ewt_id")
                                debit = 0
                                If ds.Tables("ewt").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                    debit = ds.Tables("ewt").Compute("Sum(tax_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    credit = 0
                                End If
                            Else
                                debit = 0
                                If ds.Tables("ewt").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                    debit = ds.Tables("ewt").Compute("Sum(tax_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    credit = 0
                                End If
                            End If
                        Else
                            MsgBox("No Outstanding Balance.")
                        End If
                    Case 5 'Final Tax (credit)
                        Dim tmp_dr() As DataRow = ds.Tables("final_tax").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("final_tax").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetfinaltax.ds.Tables("final_tax")
                        offset_ds.Clear()
                        offsetfinaltax.BookID = BookID
                        offsetfinaltax.account_id = txt_account_id.Value
                        offsetfinaltax.trans_id = txt_trans_id.Text
                        offsetfinaltax.jbooks_id = txt_tmp_jbooks_id.Text
                        offsetfinaltax.general_id = txt_general_id.Value
                        offsetfinaltax.currency_id = txt_currency_id_det.Value
                        offsetfinaltax.project_id = txt_project_id.Value
                        offsetfinaltax.department_id = txt_department_id.Value
                        offsetfinaltax.filter_date = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                        offsetfinaltax.exchange_rate = txtExchangeRateDet.EditValue
                        offsetfinaltax.based_rate = txtBasedRateDet.EditValue
                        offsetfinaltax.refresh_data()
                        'dtCopy(offset_ds, tmp_dt)
                        dtReplace(offset_ds, tmp_dt, "ref_final_tax_id")
                        If offsetfinaltax.ds.Tables("final_tax").Rows.Count > 0 Then
                            If offsetfinaltax.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("final_tax"), offsetfinaltax.ds.Tables("final_tax"), {"ref_final_tax_id"}, "isInputted", "final_tax_id")
                                debit = 0
                                If ds.Tables("final_tax").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                    debit = ds.Tables("final_tax").Compute("Sum(tax_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    credit = 0
                                End If
                            Else
                                debit = 0
                                If ds.Tables("final_tax").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                    debit = ds.Tables("final_tax").Compute("Sum(tax_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    credit = 0
                                End If
                            End If
                        Else
                            MsgBox("No Outstanding Balance.")
                        End If
                    Case 6 'Input VAT (debit)
                        Dim sql As String = String.Format("SELECT input_vat_importation FROM {1}.lib_erp_chart where account_id = {0}", txt_account_id.Value, _serverDBFS)
                        Dim dt_input_vat_for_importation As DataTable = Query(sql)
                        If ifNull(dt_input_vat_for_importation.Rows(0)(0).ToString, 0) = 1 Then
                            '    For_Importation
                            IsRounded = True
                            Dim tmp_dr() As DataRow = ds.Tables("input_vat_for_importation").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'  AND deleted = 'False'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("input_vat_for_importation").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim setupinputvat_ds As DataTable = setupinputvat_importation.ds.Tables("input_vat_for_importation")
                            setupinputvat_ds.Clear()
                            dtCopy(setupinputvat_ds, tmp_dt, {"input_vat_id"})
                            setupinputvat_importation.jbooks_id = txt_tmp_jbooks_id.Text
                            setupinputvat_importation.currency_id = txt_currency_id_det.Value
                            If txt_exchange_rate_det IsNot Nothing Then
                                setupinputvat_importation.exchange_rate = txt_exchange_rate_det.DecimalValue
                            Else
                                setupinputvat_importation.exchange_rate = txtExchangeRateDet.EditValue
                            End If
                            If txt_based_rate_det IsNot Nothing Then
                                setupinputvat_importation.based_rate = txt_based_rate_det.DecimalValue
                            Else
                                setupinputvat_importation.based_rate = txtBasedRateDet.EditValue
                            End If
                            setupinputvat_importation.asofdate = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                            setupinputvat_importation.generalID = txt_general_id.Value
                            setupinputvat_importation.generalCode = txt_general_id.Text
                            setupinputvat_importation.generalName = txt_general_name.Text
                            If setupinputvat_importation.ShowDialog = DialogResult.OK Then
                                dtCopy(ds.Tables("input_vat_for_importation"), setupinputvat_importation.ds.Tables("input_vat_for_importation"), {"input_vat_id"})
                            End If
                            debit = 0
                            If ds.Tables("input_vat_for_importation").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                'debit = ds.Tables("input_vat_for_importation").Compute("Sum((vat_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                Dim debit_temp As Double
                                For Each item As DataRow In ds.Tables("input_vat_for_importation").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    debit_temp += item("vat_amount")
                                Next
                                debit = debit_temp
                                credit = 0
                                txtDebit.Enabled = False
                                txtCredit.Enabled = False
                            End If
                        Else
                            IsRounded = True
                            Dim tmp_dr() As DataRow = ds.Tables("input_vat").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("input_vat").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim setupinputvat_ds As DataTable = setupinputvat.ds.Tables("input_vat")
                            setupinputvat_ds.Clear()
                            dtCopy(setupinputvat_ds, tmp_dt, {"input_vat_id"})
                            setupinputvat.jbooks_id = txt_tmp_jbooks_id.Text
                            setupinputvat.currency_id = txt_currency_id_det.Value
                            If txt_exchange_rate_det IsNot Nothing Then
                                setupinputvat.exchange_rate = txt_exchange_rate_det.DecimalValue
                            Else
                                setupinputvat.exchange_rate = txtExchangeRateDet.EditValue
                            End If
                            If txt_based_rate_det IsNot Nothing Then
                                setupinputvat.based_rate = txt_based_rate_det.DecimalValue
                            Else
                                setupinputvat.based_rate = txtBasedRateDet.EditValue
                            End If
                            setupinputvat.asofdate = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                            setupinputvat.generalID = txt_general_id.Value
                            setupinputvat.generalCode = txt_general_id.Text
                            setupinputvat.generalName = txt_general_name.Text
                            If setupinputvat.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("input_vat"), setupinputvat.ds.Tables("input_vat"), {"input_vat_id"})
                            End If
                            debit = 0
                            If ds.Tables("input_vat").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                debit = ds.Tables("input_vat").Compute("Sum(vat_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                credit = 0
                                txtDebit.Enabled = False
                                txtCredit.Enabled = False
                            End If
                        End If




                    Case 7
            Dim tmpID = GetJBooksID(ds.Tables("jbooks"), txt_tmp_jbooks_id.Text, txt_account_id.Value, txt_general_id.Value, txt_currency_id_det.Value, txt_project_id.Value, txt_department_id.Value)
                        txt_tmp_jbooks_id.Text = tmpID
                        Dim tmp_dr() As DataRow = ds.Tables("output_vat").Select("jbooks_id LIKE '" & tmpID & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("output_vat").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetoutputvat.ds.Tables("output_vat")
                        offset_ds.Clear()
                        offsetoutputvat.BookID = BookID
                        offsetoutputvat.account_id = txt_account_id.Value
                        offsetoutputvat.trans_id = txt_trans_id.Text
                        offsetoutputvat.jbooks_id = tmpID
                        offsetoutputvat.general_id = txt_general_id.Value
                        offsetoutputvat.currency_id = txt_currency_id_det.Value
                        offsetoutputvat.project_id = txt_project_id.Value
                        offsetoutputvat.department_id = txt_department_id.Value
                        offsetoutputvat.filter_date = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                        offsetoutputvat.exchange_rate = txtExchangeRateDet.EditValue
                        offsetoutputvat.based_rate = txtBasedRateDet.EditValue
                        offsetoutputvat.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_output_vat_id")
                        If offsetoutputvat.ds.Tables("output_vat").Rows.Count > 0 Then
                            If offsetoutputvat.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("output_vat"), offsetoutputvat.ds.Tables("output_vat"), {"ref_output_vat_id"}, "isInputted", "output_vat_id")
                                debit = 0
                                If ds.Tables("output_vat").Select("jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'").Length > 0 Then
                                    debit = ds.Tables("output_vat").Compute("Sum(vat_amount)", "jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'")
                                    credit = 0
                                End If
                            Else
                                debit = 0
                                If ds.Tables("output_vat").Select("jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'").Length > 0 Then
                                    debit = ds.Tables("output_vat").Compute("Sum(vat_amount)", "jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'")
                                    credit = 0
                                End If
                            End If
                        Else
                            MsgBox("No Outstanding Balance.")
                        End If
                    Case 8
                        Dim tmp_dr() As DataRow = ds.Tables("prepaid").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("prepaid").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupprepaid_ds As DataTable = setupprepaid.ds.Tables("prepaid")
                        setupprepaid_ds.Clear()
                        dtCopy(setupprepaid_ds, tmp_dt, {"prepaid_id"})
                        setupprepaid.jbooks_id = txt_tmp_jbooks_id.Text
                        setupprepaid.currency_id = txt_currency_id_det.Value
                        If txt_exchange_rate_det IsNot Nothing Then
                            setupprepaid.exchange_rate = txt_exchange_rate_det.DecimalValue
                        Else
                            setupprepaid.exchange_rate = txtExchangeRateDet.EditValue
                        End If
                        If txt_based_rate_det IsNot Nothing Then
                            setupprepaid.based_rate = txt_based_rate_det.DecimalValue
                        Else
                            setupprepaid.based_rate = txtBasedRateDet.EditValue
                        End If
                        setupprepaid.trans_date = trans_date
                        If setupprepaid.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("prepaid"), setupprepaid.ds.Tables("prepaid"), {"prepaid_id"})
                        End If
                        debit = 0
                        If ds.Tables("prepaid").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                            debit = ds.Tables("prepaid").Compute("Sum(amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                            credit = 0
                            txtDebit.Enabled = False
                            txtCredit.Enabled = False
                        End If
                    Case 9
                        Dim tmp_dr() As DataRow = ds.Tables("fixed_asset").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("fixed_asset").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupfixedasset_ds As DataTable = setupfixedasset.ds.Tables("fixed_asset")
                        setupfixedasset_ds.Clear()
                        dtCopy(setupfixedasset_ds, tmp_dt, {"fixed_asset_id"})
                        setupfixedasset.jbooks_id = txt_tmp_jbooks_id.Text
                        setupfixedasset.currency_id = txt_currency_id_det.Value
                        If txt_exchange_rate_det IsNot Nothing Then
                            setupfixedasset.exchange_rate = txt_exchange_rate_det.DecimalValue
                        Else
                            setupfixedasset.exchange_rate = txtExchangeRateDet.EditValue
                        End If
                        If txt_based_rate_det IsNot Nothing Then
                            setupfixedasset.based_rate = txt_based_rate_det.DecimalValue
                        Else
                            setupfixedasset.based_rate = txtBasedRateDet.EditValue
                        End If
                        If setupfixedasset.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("fixed_asset"), setupfixedasset.ds.Tables("fixed_asset"), {"fixed_asset_id"})
                        End If
                        debit = 0
                        If ds.Tables("fixed_asset").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                            debit = ds.Tables("fixed_asset").Compute("Sum(amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                            credit = 0
                            txtDebit.Enabled = False
                            txtCredit.Enabled = False
                        End If
                End Select
            End If
            If txtCreditValue <> 0 Then
                Select Case v
                    Case 1
                        If dnref Then
                            Dim accountcode = txt_account_id.Text
                            'Dim accountname = txtaccountname.Text
                            Dim tmp_dr() As DataRow = ds.Tables("checks").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("checks").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim cashcv_ds As DataTable = cashcv.ds.Tables("checks")
                            cashcv_ds.Clear()
                            dtCopy(cashcv_ds, tmp_dt, {"check_id", "check_no"})
                            cashcv.jbooks_id = txt_tmp_jbooks_id.Text
                            cashcv.genref_id = txt_general_id.Value
                            cashcv.genref_code = txt_general_id.Text
                            cashcv.genref_name = txt_general_name.Text
                            cashcv.currency_id = txt_currency_id_det.Value
                            If txt_exchange_rate_det IsNot Nothing Then
                                cashcv.exchange_rate = txt_exchange_rate_det.DecimalValue
                            Else
                                cashcv.exchange_rate = txtExchangeRateDet.EditValue
                            End If
                            If txt_based_rate_det IsNot Nothing Then
                                cashcv.based_rate = txt_based_rate_det.DecimalValue
                            Else
                                cashcv.based_rate = txtBasedRateDet.EditValue
                            End If
                            cashcv.journal_code = JournalCode
                            cashcv.book_code = BookCode
                            cashcv.trans_date = trans_date
                            cashcv.defaultDate = New Date(txt_year.Text, months(txt_month.Text), txt_day.Text)
                            Dim sql As String = String.Format("SELECT bank_id,bank_code,bank_name " &
                                "FROM lib_erp_bank " &
                                "WHERE bank_code = '{0}'", accountcode)
                            Dim dt As DataTable = FsQuery(sql)
                            If dt.Rows.Count > 0 Then
                                cashcv.txt_bank_id.AlwaysDisable = True
                                cashcv.txt_bank_id.NoClear = True
                                cashcv.txt_bank_name.NoClear = True
                                cashcv.txt_bank_id.Text = dt.Rows(0).Item("bank_code")
                                cashcv.txt_bank_id.Value = dt.Rows(0).Item("bank_id")
                                cashcv.txt_bank_name.Text = dt.Rows(0).Item("bank_name")
                                cashcv.bankCode = dt.Rows(0).Item("bank_code")
                                cashcv.bankID = dt.Rows(0).Item("bank_id")
                                cashcv.bankName = dt.Rows(0).Item("bank_name")
                            Else
                                cashcv.txt_bank_id.AlwaysDisable = False
                                cashcv.txt_bank_id.NoClear = False
                                cashcv.txt_bank_name.NoClear = False
                            End If
                            'cashcv.txt_check_amount.NoClear = True
                            'cashcv.txt_check_amount_based.NoClear = True
                            If txt_credit IsNot Nothing Then
                                cashcv.OutstandingBalance = txt_credit.DecimalValue
                                cashcv.txtCheckAmount.EditValue = txt_credit.DecimalValue
                            Else
                                cashcv.OutstandingBalance = txtCredit.EditValue
                                cashcv.txtCheckAmount.EditValue = txtCredit.EditValue
                            End If
                            If txt_exchange_rate_det IsNot Nothing Then
                                cashcv.txtCheckAmountBased.EditValue = cashcv.txtCheckAmount.EditValue * (txt_exchange_rate_det.DecimalValue / txt_based_rate_det.DecimalValue)
                            Else
                                cashcv.txtCheckAmountBased.EditValue = cashcv.txtCheckAmount.EditValue * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue)
                            End If
                            'raymond - 2016-06-08 (start)
                            Dim sql_trans_jbooks As String = String.Format("SELECT b.ref_no,c.trans_no FROM trans_jbooks a LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id LEFT JOIN trans_header c ON c.trans_id = a.trans_id WHERE a.jbooks_id = '{0}'", txt_tmp_jbooks_id.Text)
                            Dim data_trans_jbooks As DataTable = Query(sql_trans_jbooks)
                            If data_trans_jbooks.Rows.Count = 0 Then
                                sql_trans_jbooks = String.Format("SELECT trans_no FROM trans_header WHERE trans_id = '{0}'", txt_trans_id.Text)
                                data_trans_jbooks = Query(sql_trans_jbooks)
                                If data_trans_jbooks.Rows.Count > 0 Then
                                    cashcv.reference_no = data_trans_jbooks.Rows(0).Item("trans_no").ToString
                                Else
                                    cashcv.reference_no = txt_trans_no.Text
                                End If
                            Else
                                cashcv.book_code = BookCode
                                cashcv.reference_no = data_trans_jbooks.Rows(0).Item("trans_no").ToString
                            End If
                            'raymond - 2016-06-08 (end)
                            If cashcv.ShowDialog() = DialogResult.OK Then
                                Dim tmp_ds = cashcv.ds.Tables("checks")
                                dtCopy(ds.Tables("checks"), cashcv.ds.Tables("checks"), {"check_id", "check_no"})
                            End If
                            credit = 0
                            If ds.Tables("checks").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                credit = ds.Tables("checks").Compute("Sum(check_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                debit = 0
                                txtDebit.Enabled = False
                                txtCredit.Enabled = False
                            End If
                        End If
                    Case 2
                        If dnref Then
                            Dim tmp_dr() As DataRow = ds.Tables("jbooks").Select("jbooks_id_tmp LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("jbooks").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim offset_ds As DataTable = offsetar.ds.Tables("jbooks")

                            offset_ds.Clear()
                            offsetar.BookID = BookID
                            offsetar.account_id = txt_account_id.Value
                            offsetar.trans_id = txt_trans_id.Text
                            offsetar.jbooks_id = txt_tmp_jbooks_id.Text
                            offsetar.general_id = txt_general_id_det.Value
                            offsetar.currency_id = txt_currency_id_det.Value
                            offsetar.project_id = txt_project_id.Value
                            offsetar.department_id = txt_department_id.Value
                            offsetar.filter_date = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                            offsetar.exchange_rate = txtExchangeRateDet.EditValue
                            offsetar.based_rate = txtBasedRateDet.EditValue
                            offsetar.book_unit_no_id = txt_book_unit_no_id.Value
                            offsetar.ds.Tables("project_management_offset").Clear()
                            If ds.Tables.Contains("project_management_offset") Then
                                If ds.Tables.Contains("project_management_offset") Then
                                    For Each dr As DataRow In ds.Tables("project_management_offset").Rows
                                        offsetar.ds.Tables("project_management_offset").ImportRow(dr)
                                    Next
                                End If
                            End If

                            offsetar.refresh_data()
                            dtReplace(offset_ds, tmp_dt, "ref_jbooks_id")
                            '================================================================================================================================

                            If offsetar.ds.Tables("jbooks").Rows.Count > 0 Then
                                If offsetar.ShowDialog() = DialogResult.OK Then
                                    dtCopy(ds.Tables("jbooks"), offsetar.ds.Tables("jbooks"), {"ref_jbooks_id"}, "isInputted", "jbooks_id")
                                End If
                                credit = 0
                                If ds.Tables("jbooks").Select("jbooks_id_tmp LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Count > 0 Then
                                    credit = ds.Tables("jbooks").Compute("Sum(credit)", "jbooks_id_tmp LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    debit = 0
                                End If
                                If ds.Tables.Contains("project_management_offset") Then
                                    Dim dtPMOR As DataTable = offsetar.ds.Tables("project_management_offset")
                                    For Each dr As DataRow In dtPMOR.Rows
                                        Dim drs = ds.Tables("project_management_offset").Select(String.Format("trans_project_management_id = '{0}'", dr("trans_project_management_id").ToString))
                                        If drs.Length > 0 Then
                                            drs(0).Item("jbooks_id") = tmp_dr(0).Item("jbooks_id") & tmp_dr(0).Item("ref_jbooks_id")
                                            drs(0).Item("amount_collected") = dr("amount_collected")
                                            drs(0).Item("amount_collected_based") = dr("amount_collected_based")
                                            If CBool(ifNull(dr("sel"), 0)) Then
                                                drs(0).Item("deleted") = False
                                            Else
                                                drs(0).Item("deleted") = True
                                            End If
                                        Else
                                            If Not CBool(ifNull(dr("deleted"), 0)) Then
                                                If CBool(ifNull(dr("sel"), 0)) Then
                                                    If tmp_dr.Length > 0 Then
                                                        dr("jbooks_id") = tmp_dr(0).Item("jbooks_id") & tmp_dr(0).Item("ref_jbooks_id")
                                                    Else
                                                        dr("jbooks_id") = txt_tmp_jbooks_id.Text
                                                    End If
                                                    ds.Tables("project_management_offset").ImportRow(dr)
                                                End If
                                            End If
                                        End If
                                    Next
                                End If
                            Else
                                MsgBox("No Outstanding Balance.")
                            End If
                        End If
                    Case 4
                        IsRounded = True
                        Dim tmp_dr() As DataRow = ds.Tables("ewt").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("ewt").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim tmp_ds As DataSet = setupewt.ds
                        Dim setupewt_ds = tmp_ds.Tables("ewt")
                        setupewt_ds.Clear()
                        dtCopy(setupewt_ds, tmp_dt, {"ewt_id"})
                        setupewt.jbooks_id = txt_tmp_jbooks_id.Text
                        setupewt.currency_id = txt_currency_id_det.Value
                        If txt_exchange_rate_det IsNot Nothing Then
                            setupewt.exchange_rate = txt_exchange_rate_det.DecimalValue
                        Else
                            setupewt.exchange_rate = txtExchangeRateDet.EditValue
                        End If
                        If txt_based_rate_det IsNot Nothing Then
                            setupewt.based_rate = txt_based_rate_det.DecimalValue
                        Else
                            setupewt.based_rate = txtBasedRateDet.EditValue
                        End If
                        setupewt.generalID = txt_general_id.Value
                        setupewt.generalCode = txt_general_id.Text
                        setupewt.generalName = txt_general_name.Text
                        setupewt.dgewt.AutoGenerateColumns = False
                        setupewt.dgewt.DataSource = setupewt_ds
                        Dim totaldebit = ifNull(lbldebittotal.Text.ToString.Replace(",", ""), "0").ToString
                        If totaldebit.Contains("(") Then
                            totaldebit = totaldebit.Replace("(", "").Replace(")", "")
                        End If
                        setupewt.initialAmount = CDec(ifNull(totaldebit, 0))
                        If setupewt.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("ewt"), setupewt.ds.Tables("ewt"), {"ewt_id"})
                        End If
                        credit = 0
                        If ds.Tables("ewt").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                            credit = ds.Tables("ewt").Compute("Sum(tax_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                            debit = 0
                            txtDebit.Enabled = False
                            txtCredit.Enabled = False
                        End If
                    Case 5
                        Dim tmp_dr() As DataRow = ds.Tables("final_tax").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("final_tax").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupfinaltax_ds As DataTable = setupfinaltax.ds.Tables("final_tax")
                        setupfinaltax_ds.Clear()
                        dtCopy(setupfinaltax_ds, tmp_dt, {"final_tax_id"})
                        setupfinaltax.jbooks_id = txt_tmp_jbooks_id.Text
                        setupfinaltax.currency_id = txt_currency_id_det.Value
                        If txt_exchange_rate_det IsNot Nothing Then
                            setupfinaltax.exchange_rate = txt_exchange_rate_det.DecimalValue
                        Else
                            setupfinaltax.exchange_rate = txtExchangeRateDet.EditValue
                        End If
                        If txt_based_rate_det IsNot Nothing Then
                            setupfinaltax.based_rate = txt_based_rate_det.DecimalValue
                        Else
                            setupfinaltax.based_rate = txtBasedRateDet.EditValue
                        End If
                        setupfinaltax.generalID = txt_general_id.Value
                        setupfinaltax.generalCode = txt_general_id.Text
                        setupfinaltax.generalName = txt_general_name.Text
                        If setupfinaltax.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("final_tax"), setupfinaltax.ds.Tables("final_tax"), {"final_tax_id"})
                        End If
                        credit = 0
                        If ds.Tables("final_tax").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                            credit = ds.Tables("final_tax").Compute("Sum(tax_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                            debit = 0
                            txtDebit.Enabled = False
                            txtCredit.Enabled = False
                        End If
                    Case 6
                        'Dim sql As String = String.Format("SELECT input_vat_importation FROM {1}.lib_erp_chart where account_id = {0}", txt_account_id.Value, _serverDBFS)
                        'Dim dt_input_vat_for_importation As DataTable = Query(sql)
                        'If ifNull(dt_input_vat_for_importation.Rows(0)(0).ToString, 0) = 1 Then
                        '    'offsetting for input vat importation
                        '    Dim tmpID = GetJBooksID(ds.Tables("jbooks"), txt_tmp_jbooks_id.Text, txt_account_id.Value, txt_general_id.Value, txt_currency_id_det.Value, txt_project_id.Value, txt_department_id.Value)
                        '    txt_tmp_jbooks_id.Text = tmpID
                        '    Dim tmp_dr() As DataRow = ds.Tables("input_vat_for_importation").Select("jbooks_id LIKE '" & tmpID & "%'")
                        '    Dim tmp_dt As New DataTable
                        '    For Each col As DataColumn In ds.Tables("input_vat_for_importation").Columns
                        '        tmp_dt.Columns.Add(col.ColumnName)
                        '    Next
                        '    For i As Integer = 0 To tmp_dr.Length - 1
                        '        tmp_dt.ImportRow(tmp_dr(i))
                        '    Next
                        '    Dim offset_ds As DataTable = offsetinputvat_importation.ds.Tables("input_vat_for_importation")
                        '    offset_ds.Clear()
                        '    offsetinputvat_importation.BookID = BookID
                        '    offsetinputvat_importation.account_id = txt_account_id.Value
                        '    offsetinputvat_importation.trans_id = txt_trans_id.Text
                        '    offsetinputvat_importation.jbooks_id = tmpID
                        '    offsetinputvat_importation.general_id = txt_general_id.Value
                        '    offsetinputvat_importation.currency_id = txt_currency_id_det.Value
                        '    offsetinputvat_importation.project_id = txt_project_id.Value
                        '    offsetinputvat_importation.department_id = txt_department_id.Value
                        '    offsetinputvat_importation.filter_date = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                        '    offsetinputvat_importation.exchange_rate = txtExchangeRateDet.EditValue
                        '    offsetinputvat_importation.based_rate = txtBasedRateDet.EditValue
                        '    offsetinputvat_importation.refresh_data()
                        '    dtReplace(offset_ds, tmp_dt, "ref_input_vat_id")
                        '    If offsetinputvat_importation.ds.Tables("input_vat_for_importation").Rows.Count > 0 Then
                        '        If offsetinputvat_importation.ShowDialog() = DialogResult.OK Then
                        '            dtCopy(ds.Tables("input_vat_for_importation"), offsetinputvat_importation.ds.Tables("input_vat_for_importation"), {"ref_input_vat_id"}, "isInputted", "input_vat_id")
                        '            credit = 0
                        '            If ds.Tables("input_vat_for_importation").Select("jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'").Length > 0 Then
                        '                credit = ds.Tables("input_vat_for_importation").Compute("Sum(vat_amount)", "jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'")
                        '                debit = 0
                        '            End If
                        '        Else
                        '            credit = 0
                        '            If ds.Tables("input_vat_for_importation").Select("jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'").Length > 0 Then
                        '                credit = ds.Tables("input_vat_for_importation").Compute("Sum(vat_amount)", "jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'")
                        '                debit = 0
                        '            End If
                        '        End If
                        '    Else
                        '        MsgBox("No Outstanding Balance.")
                        '    End If    


                        'Else
                        'input vat offset
                        Dim tmpID = GetJBooksID(ds.Tables("jbooks"), txt_tmp_jbooks_id.Text, txt_account_id.Value, txt_general_id.Value, txt_currency_id_det.Value, txt_project_id.Value, txt_department_id.Value)
                            txt_tmp_jbooks_id.Text = tmpID
                            Dim tmp_dr() As DataRow = ds.Tables("input_vat").Select("jbooks_id LIKE '" & tmpID & "%'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("input_vat").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim offset_ds As DataTable = offsetinputvat.ds.Tables("input_vat")
                            offset_ds.Clear()
                            offsetinputvat.BookID = BookID
                            offsetinputvat.account_id = txt_account_id.Value
                            offsetinputvat.trans_id = txt_trans_id.Text
                            offsetinputvat.jbooks_id = tmpID
                            offsetinputvat.general_id = txt_general_id.Value
                            offsetinputvat.currency_id = txt_currency_id_det.Value
                            offsetinputvat.project_id = txt_project_id.Value
                            offsetinputvat.department_id = txt_department_id.Value
                        offsetinputvat.filter_date = txt_year.Text & "-" & txt_day.Text & "-" & txt_month.Value
                        offsetinputvat.exchange_rate = txtExchangeRateDet.EditValue
                            offsetinputvat.based_rate = txtBasedRateDet.EditValue
                            offsetinputvat.txt_account_id = txt_account_id.Value
                            offsetinputvat.refresh_data()
                            dtReplace(offset_ds, tmp_dt, "ref_input_vat_id")
                            If offsetinputvat.ds.Tables("input_vat").Rows.Count > 0 Then
                                If offsetinputvat.ShowDialog() = DialogResult.OK Then
                                    dtCopy(ds.Tables("input_vat"), offsetinputvat.ds.Tables("input_vat"), {"ref_input_vat_id"}, "isInputted", "input_vat_id")
                                    credit = 0
                                    If ds.Tables("input_vat").Select("jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'").Length > 0 Then
                                        credit = ds.Tables("input_vat").Compute("Sum(vat_amount)", "jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'")
                                        debit = 0
                                    End If
                                Else
                                    credit = 0
                                    If ds.Tables("input_vat").Select("jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'").Length > 0 Then
                                        credit = ds.Tables("input_vat").Compute("Sum(vat_amount)", "jbooks_id LIKE '" & tmpID & "%' AND deleted = 'False'")
                                        debit = 0
                                    End If
                                End If
                            Else
                                MsgBox("No Outstanding Balance.")
                            End If
                        'End If 

                    Case 8
                        Dim tmp_dr() As DataRow = ds.Tables("prepaid").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("prepaid").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetprepaid.ds.Tables("prepaid")
                        offset_ds.Clear()
                        offsetprepaid.BookID = BookID
                        offsetprepaid.account_id = txt_account_id.Value
                        offsetprepaid.trans_id = txt_trans_id.Text
                        offsetprepaid.jbooks_id = txt_tmp_jbooks_id.Text
                        offsetprepaid.general_id = txt_general_id.Value
                        offsetprepaid.currency_id = txt_currency_id_det.Value
                        offsetprepaid.project_id = txt_project_id.Value
                        offsetprepaid.department_id = txt_department_id.Value
                        offsetprepaid.filter_date = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                        offsetprepaid.exchange_rate = txtExchangeRateDet.EditValue
                        offsetprepaid.based_rate = txtBasedRateDet.EditValue
                        offsetprepaid.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_prepaid_id")
                        If offsetprepaid.ds.Tables("prepaid").Rows.Count > 0 Then
                            If offsetprepaid.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("prepaid"), offsetprepaid.ds.Tables("prepaid"), {"ref_prepaid_id"}, "isInputted", "prepaid_id")
                                credit = 0
                                If ds.Tables("prepaid").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                    credit = ds.Tables("prepaid").Compute("Sum(amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    debit = 0
                                End If
                            Else
                                credit = 0
                                If ds.Tables("prepaid").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                    credit = ds.Tables("prepaid").Compute("Sum(amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    debit = 0
                                End If
                            End If
                        Else
                            MsgBox("No Outstanding Balance.")
                        End If
                    Case 7 ' output vat
                        IsRounded = True
                        Dim tmp_dr() As DataRow = ds.Tables("output_vat").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("output_vat").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupoutputvat_ds As DataTable = setupoutputvat.ds.Tables("output_vat")
                        setupoutputvat_ds.Clear()
                        dtCopy(setupoutputvat_ds, tmp_dt, {"output_vat_id"})
                        setupoutputvat.jbooks_id = txt_tmp_jbooks_id.Text
                        setupoutputvat.generalID = txt_general_id.Value
                        setupoutputvat.generalCode = txt_general_id.Text
                        setupoutputvat.generalName = txt_general_name.Text
                        setupoutputvat.currency_id = txt_currency_id_det.Value
                        If txt_exchange_rate_det IsNot Nothing Then
                            setupoutputvat.exchange_rate = txt_exchange_rate_det.DecimalValue
                        Else
                            setupoutputvat.exchange_rate = txtExchangeRateDet.EditValue
                        End If
                        If txt_based_rate_det IsNot Nothing Then
                            setupoutputvat.based_rate = txt_based_rate_det.DecimalValue
                        Else
                            setupoutputvat.based_rate = txtBasedRateDet.EditValue
                        End If
                        setupoutputvat.asofdate = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                        If setupoutputvat.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("output_vat"), setupoutputvat.ds.Tables("output_vat"), {"output_vat_id"})
                        End If
                        credit = 0
                        If ds.Tables("output_vat").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                            credit = ds.Tables("output_vat").Compute("Sum(vat_amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                            debit = 0
                            txtDebit.Enabled = False
                            txtCredit.Enabled = False
                        End If

                    Case 9
                        Dim tmp_dr() As DataRow = ds.Tables("fixed_asset").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("fixed_asset").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetfixedasset.ds.Tables("fixed_asset")
                        offset_ds.Clear()
                        offsetfixedasset.BookID = BookID
                        offsetfixedasset.account_id = txt_account_id.Value
                        offsetfixedasset.trans_id = txt_trans_id.Text
                        offsetfixedasset.jbooks_id = txt_tmp_jbooks_id.Text
                        offsetfixedasset.general_id = txt_general_id.Value
                        offsetfixedasset.currency_id = txt_currency_id_det.Value
                        offsetfixedasset.project_id = txt_project_id.Value
                        offsetfixedasset.department_id = txt_department_id.Value
                        offsetfixedasset.filter_date = txt_year.Text & "-" & txt_month.Value & "-" & txt_day.Text
                        offsetfixedasset.exchange_rate = txtExchangeRateDet.EditValue
                        offsetfixedasset.based_rate = txtBasedRateDet.EditValue
                        offsetfixedasset.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_fixed_asset_id")
                        If offsetfixedasset.ds.Tables("fixed_asset").Rows.Count > 0 Then
                            If offsetfixedasset.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("fixed_asset"), offsetfixedasset.ds.Tables("fixed_asset"), {"ref_fixed_asset_id"}, "isInputted", "fixed_asset_id")
                                credit = 0
                                If ds.Tables("fixed_asset").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                    credit = ds.Tables("fixed_asset").Compute("Sum(amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    debit = 0
                                End If
                            Else
                                credit = 0
                                If ds.Tables("fixed_asset").Select("jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'").Length > 0 Then
                                    credit = ds.Tables("fixed_asset").Compute("Sum(amount)", "jbooks_id LIKE '" & txt_tmp_jbooks_id.Text & "%' AND deleted = 'False'")
                                    debit = 0
                                End If
                            End If
                        Else
                            MsgBox("No Outstanding Balance.")
                        End If
                End Select
            End If
            If "123456789".IndexOf(v.ToString) >= 0 Then
                Dim tmp_jbooksidtmp = txt_tmp_jbooks_id.Text
                Dim tmp_id = txt_currency_id_det.Value
                Dim tmp_text = txt_currency_id_det.Text
                Dim tmp_xrate As Decimal = 0
                If txt_exchange_rate_det IsNot Nothing Then
                    tmp_xrate = txt_exchange_rate_det.DecimalValue
                Else
                    tmp_xrate = txtExchangeRateDet.EditValue
                End If
                Dim tmp_brate As Decimal = 0
                If txt_based_rate_det IsNot Nothing Then
                    tmp_brate = txt_based_rate_det.DecimalValue
                Else
                    tmp_brate = txtBasedRateDet.EditValue
                End If
                Dim tmp_accountRow = txt_account_id.RowData
                frm.Visible = True
                txt_account_id.RowData = tmp_accountRow
                txt_currency_id_det.Value = tmp_id
                txt_currency_id_det.Text = tmp_text
                If txt_exchange_rate_det IsNot Nothing Then
                    txt_exchange_rate_det.DecimalValue = tmp_xrate
                Else
                    txtExchangeRateDet.EditValue = tmp_xrate
                End If
                If txt_based_rate_det IsNot Nothing Then
                    txt_based_rate_det.DecimalValue = tmp_brate
                Else
                    txtbasedratedet.EditValue = tmp_brate
                End If
                If txt_debit IsNot Nothing Then
                    txt_debit.DecimalValue = debit
                Else
                    txtDebit.EditValue = debit
                End If
                If txt_credit IsNot Nothing Then
                    txt_credit.DecimalValue = credit
                Else
                    txtCredit.EditValue = credit
                End If
                If txt_debit_based IsNot Nothing Then
                    If txt_based_rate_det IsNot Nothing Then
                        txt_debit_based.DecimalValue = debit * (txt_exchange_rate_det.DecimalValue / txt_based_rate_det.DecimalValue)
                    Else
                        txt_debit_based.DecimalValue = debit * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue)
                    End If
                Else
                    If txt_exchange_rate_det IsNot Nothing Then
                        txtDebitBased.EditValue = debit * (txt_exchange_rate_det.DecimalValue / txt_based_rate_det.DecimalValue)
                    Else
                        txtDebitBased.EditValue = debit * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue)
                        If IsRounded Then
                            txtDebitBased.EditValue = Math.Round(debit * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue), 2)
                        End If
                    End If
                End If
                If txt_credit_based IsNot Nothing Then
                    If txt_exchange_rate_det IsNot Nothing Then
                        txt_credit_based.DecimalValue = credit * (txt_exchange_rate_det.DecimalValue / txt_based_rate_det.DecimalValue)
                    Else
                        txt_credit_based.DecimalValue = credit * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue)
                    End If
                Else
                    If txt_exchange_rate_det IsNot Nothing Then
                        txtCreditBased.EditValue = credit * (txt_exchange_rate_det.DecimalValue / txt_based_rate_det.DecimalValue)
                    Else
                        txtCreditBased.EditValue = credit * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue)
                        If IsRounded Then
                            txtCreditBased.EditValue = Math.Round(credit * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue), 2)
                        End If
                    End If
                End If
                If "123".IndexOf(v.ToString) < 0 Then
                    txt_general_id_det.Value = ""
                    txt_general_id_det.Text = ""
                    txt_general_name_det.Text = ""
                End If
                For Each dr As DataRow In ds.Tables("jbooks").Rows
                    If ds.Tables("jbooks").Columns.Contains("description") Then
                        Dim description = ifNull(dr.Item("description"), "").ToString
                        If Not txt_description.Text.Contains(description) Then
                            txt_description.Text = String.Format("{0}" & vbNewLine & "{1}", txt_description.Text, description)
                        End If
                    End If
                Next
                'If txt_debit IsNot Nothing Then
                '    txt_debit.Enabled = False
                'Else
                '    txtDebit.Enabled = False
                'End If
                'If txt_credit IsNot Nothing Then
                '    txt_credit.Enabled = False
                'Else
                '    txtCredit.Enabled = False
                'End If
                If Not propEntryValidated Is Nothing Then
                    propEntryValidated.SetValue(frm, True)
                    'entryValidated = propEntryValidated.GetValue(frm)
                End If
                'txt_debit.
                'Console.WriteLine(txt_credit.DecimalValue)
            End If
        End If
    End Sub
    Private Function GetJBooksID(ByVal dt As DataTable, ByVal jbooks_id As String, ByVal account_id As String, ByVal general_id As String, ByVal currency_id As String, Optional project_id As String = "", Optional department_id As String = "") As String
        Dim strFilter As String = String.Format("account_id = '{0}' AND currency_id = '{1}'", account_id, currency_id)
        If project_id <> "" Then
            strFilter &= String.Format(" AND project_id = '{0}'", project_id)
        End If
        If department_id <> "" Then
            strFilter &= String.Format(" AND department_id = '{0}'", department_id)
        End If
        Dim drs = dt.Select(strFilter)
        If drs.Length > 0 Then
            Return drs(0).Item("jbooks_id").ToString()
        End If
        Return jbooks_id
    End Function
End Module
