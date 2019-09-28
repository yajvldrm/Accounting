Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class GetAPForm
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Public Property TemporaryID As String = ""
    Public Property RowData As DataRow = Nothing
    Public Property bank_id As String = ""
    Public Property bank_name As String = ""
    Public Property trans_id As String = ""
    Public Property trans_no As String = ""
    Public Property filter_date As Date = New Date()
    Public Property currency_id As String = ""
    Public Property book_id As String = ""
    Public Property jbooks_id As String = ""
    Public Property GeneralID As String = ""
    Public Property GeneralCode As String = ""
    Public Property GeneralName As String = ""
    Public Property ExchangeRate As Decimal = 0
    Public Property BasedRate As Decimal = 0
    Public Property JournalCode As String = ""
    Public Property BookCode As String = ""
    Public Property GetAPTrans As Boolean = False
    Private Sub txt_bank_id_Leave(sender As Object, e As EventArgs) Handles txt_bank_id.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_chart WHERE IFNULL(validation,0) = '1'")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("account_name like '" & txt_bank_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "account_code,account_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_bank_id.RowData = dr
                txt_bank_id.Value = dr("account_id")
                txt_bank_id.Text = dr("account_name")
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txt_bank_id.Value = "" Then
            MsgBox("Setup bank first.")
        Else
            Dim dt As DataTable = dgOffset.DataSource
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    'row.Item("jbooks_id") = jbooks_id
                    Try
                        If row.Item("isInputted") Then
                            'row.Item("offset_type") = offset_type
                        Else
                            If row.Item("ref_jbooks_id") = "" Then
                                dt.Rows.Remove(row)
                            Else
                                row.Item("deleted") = True
                            End If
                        End If
                    Catch
                        If row.Item("ref_jbooks_id") = "" Then
                            dt.Rows.Remove(row)
                        Else
                            row.Item("deleted") = True
                        End If
                    End Try
                Next
            End If
            '--
            Dim drBank As DataRow = txt_bank_id.RowData
            Dim accountcode = drBank.Item("account_code").ToString
            'Dim accountname = txtaccountname.Text
            Dim tmp_dr() As DataRow = ds.Tables("checks").Select("jbooks_id LIKE '" & jbooks_id & "%'")
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
            cashcv.jbooks_id = TemporaryID
            cashcv.genref_id = GeneralID
            cashcv.genref_code = GeneralCode
            cashcv.genref_name = GeneralName
            cashcv.currency_id = currency_id
            cashcv.exchange_rate = ExchangeRate
            cashcv.based_rate = BasedRate
            cashcv.journal_code = JournalCode
            cashcv.book_code = BookCode
            cashcv.trans_date = filter_date
            cashcv.defaultDate = filter_date
            Dim sql As String = String.Format("SELECT bank_id,bank_code,bank_name " &
                                "FROM lib_erp_bank " &
                                "WHERE bank_code = '{0}'", accountcode)
            Dim dtBank As DataTable = FsQuery(sql)
            If dtBank.Rows.Count > 0 Then
                cashcv.txt_bank_id.AlwaysDisable = True
                cashcv.txt_bank_id.NoClear = True
                cashcv.txt_bank_name.NoClear = True
                cashcv.txt_bank_id.Text = dtBank.Rows(0).Item("bank_code")
                cashcv.txt_bank_id.Value = dtBank.Rows(0).Item("bank_id")
                cashcv.txt_bank_name.Text = dtBank.Rows(0).Item("bank_name")
                cashcv.bankCode = dtBank.Rows(0).Item("bank_code")
                cashcv.bankID = dtBank.Rows(0).Item("bank_id")
                cashcv.bankName = dtBank.Rows(0).Item("bank_name")
            Else
                cashcv.txt_bank_id.AlwaysDisable = False
                cashcv.txt_bank_id.NoClear = False
                cashcv.txt_bank_name.NoClear = False
            End If

            cashcv.OutstandingBalance = txttotal.DecimalValue
            cashcv.txtCheckAmount.EditValue = txttotal.DecimalValue
            cashcv.txtCheckAmountBased.EditValue = cashcv.txtCheckAmount.EditValue * (ExchangeRate / BasedRate)

            Dim sql_trans_jbooks As String = String.Format("SELECT b.ref_no,c.trans_no FROM trans_jbooks a LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id LEFT JOIN trans_header c ON c.trans_id = a.trans_id WHERE a.jbooks_id = '{0}'", jbooks_id)
            Dim data_trans_jbooks As DataTable = Query(sql_trans_jbooks)
            If data_trans_jbooks.Rows.Count = 0 Then
                sql_trans_jbooks = String.Format("SELECT trans_no FROM trans_header WHERE trans_id = '{0}'", trans_id)
                data_trans_jbooks = Query(sql_trans_jbooks)
                If data_trans_jbooks.Rows.Count > 0 Then
                    cashcv.reference_no = data_trans_jbooks.Rows(0).Item("trans_no").ToString
                Else
                    cashcv.reference_no = trans_no
                End If
            Else
                cashcv.book_code = BookCode
                cashcv.reference_no = data_trans_jbooks.Rows(0).Item("trans_no").ToString
            End If

            If cashcv.ShowDialog() = DialogResult.OK Then
                Dim tmp_ds = cashcv.ds.Tables("checks")
                dtCopy(ds.Tables("checks"), cashcv.ds.Tables("checks"), {"check_id", "check_no"})
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
            '--
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Public Sub InitializeData()
        Dim sql = ""
        If trans_id.ToString = "0" Then
            trans_id = ""
        End If
        If trans_id = "" Then
            sql = String.Format("SELECT a.jbooks_id AS ref_jbooks_id,'' AS jbooks_id_tmp,'' AS trans_id,IFNULL(m.journal_code,'') AS ref_journal_code " &
                ",a.trans_id,IF(IFNULL(b.ref_no,'') = '',c.trans_no,CONCAT(c.trans_no,' - ',b.ref_no)) AS ref_trans_no,c.trans_date AS ref_trans_date " &
                ",a.project_id,d.project_code,d.project_name " &
                ",a.department_id,e.department_code,e.department_name " &
                ",IFNULL(a.allocation_id,'') AS allocation_id,IFNULL(f.allocation_code,'') AS allocation_code,IFNULL(f.allocation_name,'') AS allocation_name " &
                ",a.account_id,g.account_code,g.account_name,g.validation " &
                ",a.currency_id,h.currency_code,h.currency_name " &
                ",a.exchange_rate,a.based_rate,a.debit,(a.credit - IF(j.debit IS NULL,0,j.debit)) AS tmp_amount,0 AS debit " &
                ",a.debit_based,0 AS debit_based,a.line_remarks " &
                ",a.general_id,i.general_code,i.general_name " &
                ",IF(a.debit != 0,1,2) as dc " &
                ",k.terms_id,k.jbooks_ap_id AS jbooks_terms_id,IFNULL(k.nodays,0) AS nodays " &
                ",IF(c.journal_id = '8',k.si_no,n.si_no) AS si_no,IF(c.journal_id = '8',k.rr_no,n.rr_no) AS rr_no,IF(c.journal_id = '8',k.po_no,n.po_no) AS po_no " &
                ",l.terms_code,l.terms_name " &
                ",c.description " & vbNewLine &
                "FROM trans_jbooks a " &
                "LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN trans_header c ON c.trans_id = a.trans_id " &
                "LEFT JOIN {2}.lib_erp_project d ON d.project_id = a.project_id " &
                "LEFT JOIN {2}.lib_erp_department e ON e.department_id = a.department_id " &
                "LEFT JOIN {2}.lib_erp_allocation f ON f.allocation_id = a.allocation_id " &
                "LEFT JOIN {2}.lib_erp_chart g ON g.account_id = a.account_id " &
                "LEFT JOIN {2}.lib_erp_currency h ON h.currency_id = a.currency_id " &
                "LEFT JOIN {2}.lib_erp_general i ON i.general_id = a.general_id " &
                "LEFT JOIN (SELECT ref_jbooks_id AS jbooks_id,SUM(debit) AS debit FROM trans_jbooks GROUP BY ref_jbooks_id) j ON j.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {3}.trans_jbooks_ap k ON k.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {2}.lib_erp_terms l ON l.terms_id = k.terms_id " &
                "LEFT JOIN {2}.lib_erp_journal m ON m.journal_id = c.journal_id " &
                "LEFT JOIN {3}.trans_header_ap n ON n.trans_id = c.trans_id " &
                "WHERE c.trans_date <= '{0}' " &
                "AND IF('{1}' <> '',a.currency_id = '{1}',true) " &
                "AND a.ref_jbooks_id IS NULL AND (a.credit - IF(j.debit IS NULL,0,j.debit)) <> 0 
                AND g.validation = 3 ", filter_date.ToString("yyyy-MM-dd"), currency_id, _serverDBFS, _serverDBMain)
        Else
            sql = String.Format("SELECT a.jbooks_id AS ref_jbooks_id,'' AS jbooks_id_tmp,IFNULL(m.journal_code,'') AS ref_journal_code " &
                ",a.trans_id,IF(IFNULL(b.ref_no,'') = '',c.trans_no,CONCAT(c.trans_no,' - ',b.ref_no)) AS ref_trans_no,c.trans_date AS ref_trans_date " &
                ",a.project_id,d.project_code,d.project_name " &
                ",a.department_id,e.department_code,e.department_name " &
                ",IFNULL(a.allocation_id,'') AS allocation_id,IFNULL(f.allocation_code,'') AS allocation_code,IFNULL(f.allocation_name,'') AS allocation_name " &
                ",a.account_id,g.account_code,g.account_name,g.validation " &
                ",a.currency_id,h.currency_code,h.currency_name " &
                ",a.exchange_rate,a.based_rate,a.debit,(a.credit - IF(j.debit IS NULL,0,j.debit)) AS tmp_amount,0 AS debit " &
                ",a.debit_based,0 AS debit_based,a.line_remarks " &
                ",a.general_id,i.general_code,i.general_name " &
                ",IF(a.debit != 0,1,2) as dc " &
                ",k.terms_id,k.jbooks_ap_id AS jbooks_terms_id,IFNULL(k.nodays,0) AS nodays " &
                ",IF(c.journal_id = '8',k.si_no,n.si_no) AS si_no,IF(c.journal_id = '8',k.rr_no,n.rr_no) AS rr_no,IF(c.journal_id = '8',k.po_no,n.po_no) AS po_no " &
                ",l.terms_code,l.terms_name " &
                ",c.description " & vbNewLine &
                "FROM trans_jbooks a " &
                "LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN trans_header c ON c.trans_id = a.trans_id " &
                "LEFT JOIN {3}.lib_erp_project d ON d.project_id = a.project_id " &
                "LEFT JOIN {3}.lib_erp_department e ON e.department_id = a.department_id " &
                "LEFT JOIN {3}.lib_erp_allocation f ON f.allocation_id = a.allocation_id " &
                "LEFT JOIN {3}.lib_erp_chart g ON g.account_id = a.account_id " &
                "LEFT JOIN {3}.lib_erp_currency h ON h.currency_id = a.currency_id " &
                "LEFT JOIN {3}.lib_erp_general i ON i.general_id = a.general_id " &
                "LEFT JOIN (SELECT ref_jbooks_id AS jbooks_id,SUM(debit) AS debit FROM trans_jbooks WHERE trans_id <> {2} GROUP BY ref_jbooks_id) j ON j.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {4}.trans_jbooks_ap k ON k.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {3}.lib_erp_terms l ON l.terms_id = k.terms_id " &
                "LEFT JOIN {3}.lib_erp_journal m ON m.journal_id = c.journal_id " &
                "LEFT JOIN {4}.trans_header_ap n ON n.trans_id = c.trans_id " &
                "WHERE c.trans_date <= '{0}' " &
                "AND IF('{1}' <> '',a.currency_id = '{1}',true) " &
                "AND a.trans_id <> {2} " &
                "AND a.ref_jbooks_id IS NULL AND (a.credit - IF(j.debit IS NULL,0,j.debit)) <> 0 
                AND g.validation = 3 ", filter_date.ToString("yyyy-MM-dd"), currency_id, trans_id, _serverDBFS, _serverDBMain)
        End If
        Dim _data As DataTable = Query(sql)
        Dim _dt = _data.Clone
        _dt.Clear()
        _dt.Columns("jbooks_id_tmp").DataType = Type.GetType("System.String")
        For Each dr As DataRow In _data.Rows
            _dt.ImportRow(dr)
        Next
        ds.Clear()
        For Each row As DataRow In _dt.Rows
            row.Item("jbooks_id_tmp") = jbooks_id & row.Item("ref_jbooks_id")
            If trans_id <> "" Then
                row.Item("trans_id") = trans_id
            End If
            ds.Tables("jbooks").ImportRow(row)
        Next
    End Sub
    Private Sub GetAPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgOffset.AutoGenerateColumns = False
        dgOffset.DataSource = ds.Tables("jbooks")
    End Sub

    Private Sub dgOffset_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgOffset.CellValueChanged
        If dgOffset.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim dt As DataTable = dgOffset.DataSource
        Dim i As Integer = e.RowIndex

        If dt.Rows(i)("isInputted") Then
            If dt.Rows(i)("debit") = 0 Then
                dt.Rows(i)("debit") = dt.Rows(i)("tmp_amount")
            End If
        Else
            dt.Rows(i)("debit") = 0.0
        End If

        dt.Rows(i)("debit_based") = dt.Rows(i)("debit") * (dt.Rows(i)("exchange_rate") / dt.Rows(i)("based_rate"))
        dt.Rows(i)("balance") = dt.Rows(i)("tmp_amount") - dt.Rows(i)("debit")

        If dt.Rows(i)("balance") < 0 Then
            MsgBox("Overpayments Datected.")
            dt.Rows(i)("debit") = dt.Rows(i)("tmp_amount")
            dt.Rows(i)("debit_based") = dt.Rows(i)("debit") * (dt.Rows(i)("exchange_rate") / dt.Rows(i)("based_rate"))
            dt.Rows(i)("balance") = dt.Rows(i)("tmp_amount") - dt.Rows(i)("debit")
        End If
        If e.ColumnIndex = 5 Then
            With DirectCast(dgOffset.Rows(i).DataBoundItem, DataRowView).Row
                '     |-- The index of boolean DataColumn
                .Item(0) = True
                .EndEdit()
            End With
        End If
    End Sub

    Private Sub dgOffset_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgOffset.DataBindingComplete
        Dim dt As DataTable = dgOffset.DataSource
        If dt.Rows.Count > 0 Then
            Dim totaldebit As Decimal = 0
            For Each row As DataRow In dt.Rows
                totaldebit += row.Item("debit")
            Next
            txttotal.DecimalValue = totaldebit
        End If
    End Sub

    Private Sub GetAPForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If bank_id <> "" Then
            txt_bank_id.RowData = RowData
            txt_bank_id.Value = bank_id
            txt_bank_id.Text = RowData.Item("account_name").ToString()
        Else
            txt_bank_id.RowData = Nothing
            txt_bank_id.Value = ""
            txt_bank_id.Text = ""
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim q As String = StringReplace(txtSearch.Text, "~!@#$%^&*()_+{}:""|<>?=[];'\,./+`", "")
        Dim dt As DataTable = dgOffset.DataSource
        Dim drs = dt.Select(String.Format("ref_trans_no LIKE '%{0}%' OR si_no LIKE '%{0}%' OR rr_no LIKE '%{0}%' OR general_name LIKE '%{0}%'", q))
        If drs.Length > 0 Then
            If currentSearchIndex >= drs.Length Then
                currentSearchIndex = 0
            End If
            Dim selectedID As String = drs(currentSearchIndex).Item("ref_trans_no").ToString
            dgOffset.ClearSelection()
            For Each row As DataGridViewRow In dgOffset.Rows
                If row.Cells("ref_trans_no").Value.ToString = selectedID Then
                    row.Selected = True
                    Dim tmp_index = dt.Rows.IndexOf(drs(currentSearchIndex))
                    dgOffset.FirstDisplayedScrollingRowIndex = tmp_index
                End If
            Next
        End If
    End Sub

    Private Sub GetAPForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If searchFocus Then
            If e.KeyCode = Keys.Enter And e.Control Then
                currentSearchIndex += 1
                txtSearch_TextChanged(Nothing, Nothing)
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        searchFocus = True
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        searchFocus = False
    End Sub
End Class