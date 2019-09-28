Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class cashor
    Private transmode As String = ""
    Private _jbooks_id As String = ""
    Private _genref_id As String = ""
    Private _genref_code As String = ""
    Private _genref_name As String = ""
    Private _currency_id As String = ""
    Private _reference_no As String = ""
    Private _journal_code As String = ""
    Private _book_code As String = ""
    Private _exchange_rate As Decimal = 0.0
    Private _based_rate As Decimal = 0.0
    Public Property OutstandingBalance As Decimal = 0
    Public Property bankCode As String = ""
    Public Property bankID As String = ""
    Public Property bankName As String = ""
    Public Property trans_date As DateTime = Now
    Public Property jbooks_id() As String
        Get
            Return _jbooks_id
        End Get
        Set(ByVal value As String)
            _jbooks_id = value
        End Set
    End Property
    Public Property genref_id() As String
        Get
            Return _genref_id
        End Get
        Set(ByVal value As String)
            _genref_id = value
        End Set
    End Property
    Public Property genref_code() As String
        Get
            Return _genref_code
        End Get
        Set(ByVal value As String)
            _genref_code = value
        End Set
    End Property
    Public Property genref_name() As String
        Get
            Return _genref_name
        End Get
        Set(ByVal value As String)
            _genref_name = value
        End Set
    End Property
    Public Property currency_id() As String
        Get
            Return _currency_id
        End Get
        Set(ByVal value As String)
            _currency_id = value
        End Set
    End Property
    Public Property reference_no() As String
        Get
            Return _reference_no
        End Get
        Set(ByVal value As String)
            _reference_no = value
        End Set
    End Property
    Public Property journal_code() As String
        Get
            Return _journal_code
        End Get
        Set(ByVal value As String)
            _journal_code = value
        End Set
    End Property
    Public Property book_code() As String
        Get
            Return _book_code
        End Get
        Set(ByVal value As String)
            _book_code = value
        End Set
    End Property
    Public Property exchange_rate() As Decimal
        Get
            Return _exchange_rate
        End Get
        Set(ByVal value As Decimal)
            _exchange_rate = value
        End Set
    End Property
    Public Property based_rate() As Decimal
        Get
            Return _based_rate
        End Get
        Set(ByVal value As Decimal)
            _based_rate = value
        End Set
    End Property
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txtCheckAmount.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtCheckAmount.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtCheckAmount.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtCheckAmountBased.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtCheckAmountBased.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtCheckAmountBased.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        dgdet.Columns("check_amount").DefaultCellStyle.Format = "n" & main.DecimalPlaces
    End Sub
    Private Sub cashcv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEditEnterToTab(Me)
        txt_general_id.Value = genref_id
        txt_general_id.Text = genref_code
        txt_general_name.Text = genref_name
        lbl_reference_no.Text = reference_no
        lbl_book_code.Text = book_code
        lbl_journal_code.Text = journal_code
        dgdet.AutoGenerateColumns = False
        clear_control(Me)
        'dgdet.DataSource = ds.Tables("checks")
        loadDTToDG(dgdet, ds.Tables("checks"))
        DisableControlDet(Me)
        ComputeTotalAmount()
        btninsert.Focus()
    End Sub
    Private Sub dgdet_SelectionChanged(sender As Object, e As EventArgs) Handles dgdet.SelectionChanged
        If dgdet.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        BindControlDet(Me, ds.Tables("checks").Rows(dgdet.SelectedRows(0).Index))
    End Sub
    Private Sub isCash_CheckedChanged(sender As Object, e As EventArgs) Handles isCash.CheckedChanged
        If transmode <> "" Then
            txt_check_no.Enabled = True
            txt_bank_name.Enabled = True
            If isCash.Checked Then
                txt_check_no.Enabled = False
                txt_bank_name.Enabled = False
            End If
        Else
            txt_check_no.Enabled = False
            txt_bank_name.Enabled = False
        End If
    End Sub
    Private Sub isCleared_CheckedChanged(sender As Object, e As EventArgs) Handles cleared.CheckedChanged
        If transmode <> "" Then
            txt_cleared_date.Enabled = False
            If cleared.Checked Then
                txt_cleared_date.Enabled = True
            End If
        Else
            txt_cleared_date.Enabled = False
        End If
    End Sub
    Private Sub isReleased_CheckedChanged(sender As Object, e As EventArgs) Handles released.CheckedChanged
        If transmode <> "" Then
            txt_deposit_date.Enabled = False
            If released.Checked Then
                txt_deposit_date.Enabled = True
            End If
        Else
            txt_deposit_date.Enabled = False
        End If
    End Sub
    Private Sub isCancelled_CheckedChanged(sender As Object, e As EventArgs) Handles cancelled.CheckedChanged
        If transmode <> "" Then
            txt_cancel_date.Enabled = False
            If cancelled.Checked Then
                txt_cancel_date.Enabled = True
            End If
        Else
            txt_cancel_date.Enabled = False
        End If
    End Sub
    Private Sub isReplaced_CheckedChanged(sender As Object, e As EventArgs) Handles isReplaced.CheckedChanged
        If transmode <> "" Then
            txt_replacement_check_no.Enabled = False
            If isReplaced.Checked Then
                txt_replacement_check_no.Enabled = True
            End If
        Else
            txt_replacement_check_no.Enabled = False
        End If
    End Sub
    Private Sub btnnotsave_Click(sender As Object, e As EventArgs) Handles btnnotsave.Click
        DisableControlDet(Me)
        Me.Hide()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.DialogResult = DialogResult.OK
        DisableControlDet(Me)
        Me.Hide()
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        transmode = "insert"
        EnableControlDet(Me)
        ClearControlDet(Me)
        txt_cleared_date.Enabled = False
        txt_deposit_date.Enabled = False
        txt_cancel_date.Enabled = False
        txt_cleared_date.Value = trans_date
        txt_deposit_date.Value = trans_date
        txt_cancel_date.Value = trans_date
        txt_check_date.Value = trans_date
        txt_general_id.Value = genref_id
        txt_general_id.Text = genref_code
        txt_general_name.Text = genref_name
        txt_bank_id.Value = bankID
        txt_bank_id.Text = bankCode
        txt_bank_name_depository.Text = bankName
        txt_bank_name.Focus()
        txtCheckAmount.EditValue = lbl_balance.Text
        txtCheckAmountBased.EditValue = txtCheckAmount.EditValue * (exchange_rate / based_rate)
        btnhdr2.Visible = False
        btndet2.Visible = True
    End Sub
    Private Sub txt_general_id_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim generaldt As DataTable = FsQuery("select * from lib_erp_general ORDER BY FIELD(category_id,1,2),general_code ASC")
        If generaldt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If generaldt.Rows.Count = 1 Then
                dr = generaldt.Rows(0)
            Else
                Dim dra() As DataRow = generaldt.Select("general_code like '" & txt_general_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = generaldt
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
    Private Sub txt_bank_id_Leave(sender As Object, e As EventArgs) Handles txt_bank_id.Leave
        Dim dt As DataTable = FsQuery("select * from lib_erp_bank")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("bank_code like '" & txt_bank_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "bank_code,bank_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_bank_id.RowData = dr
                txt_bank_id.Value = dr("bank_id")
                txt_bank_id.Text = dr("bank_code")
                txt_bank_name_depository.Text = dr("bank_name")
            End If
        End If
    End Sub
    Private Sub txt_check_amount_Leave(sender As Object, e As EventArgs) Handles txtCheckAmount.Leave
        txtCheckAmountBased.EditValue = txtCheckAmount.EditValue * (exchange_rate / based_rate)
    End Sub
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim dt As DataTable = ds.Tables("checks")
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0
        If transmode = "insert" Then
            dr = dt.NewRow
            dr("check_id") = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            If DataExist(dgdet, {"check_id", txt_check_id.Value}, {"check_no", "bank_id"}, {txt_check_no.Text, txt_bank_id.Value}, True, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
        Else
            sel = dgdet.SelectedRows(0).Index
            dr = ds.Tables("checks").Rows(sel)
            If DataExist(dgdet, {"check_id", txt_check_id.Value}, {"check_no", "bank_id"}, {txt_check_no.Text, txt_bank_id.Value}, False, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
        End If

        If Not isCash.Checked Then
            If txt_check_no.Text = "" Then
                MsgBox("Fillup the check number first.")
                txt_check_no.Focus()
                Exit Sub
            End If
        End If
        Dim check_id = dr.Item("check_id").ToString
        Dim selectedRows = dr.Table.Select(String.Format("check_id <> '{0}'", dr.Item("check_id")))
        Dim tmp_total As Decimal = 0
        For Each row As DataRow In selectedRows
            tmp_total += row.Item("check_amount")
        Next
        If txtCheckAmount.EditValue + tmp_total > OutstandingBalance Then
            MsgBox("Check Amount is Greaterthan outstanding balance.")
            Exit Sub
        End If

        dr.Item("check_id") = txt_check_id.Value
        dr.Item("jbooks_id") = jbooks_id
        dr.Item("general_id") = txt_general_id.Value
        dr.Item("currency_id") = currency_id
        dr.Item("exchange_rate") = exchange_rate
        dr.Item("based_rate") = based_rate
        dr.Item("check_no") = If(isCash.Checked, "", txt_check_no.Text)
        dr.Item("check_date") = txt_check_date.Value.ToString("yyyy-MM-dd")
        dr.Item("check_amount") = txtCheckAmount.EditValue
        dr.Item("check_amount_based") = txtCheckAmountBased.EditValue
        dr.Item("debit") = txtCheckAmount.EditValue
        dr.Item("debit_based") = txtCheckAmountBased.EditValue
        dr.Item("bank_id") = txt_bank_id.Value
        dr.Item("isCash") = isCash.Checked
        dr.Item("isReplaced") = isReplaced.Checked
        dr.Item("cleared") = cleared.Checked
        dr.Item("released") = released.Checked
        dr.Item("cancelled") = cancelled.Checked
        'dr.Item("crossed") = crossed.Checked
        dr.Item("replacement_check_no") = If(isReplaced.Checked, txt_replacement_check_no.Text, "")
        dr.Item("cleared_date") = txt_cleared_date.Value.ToString("yyyy-MM-dd")
        dr.Item("deposit_date") = txt_deposit_date.Value.ToString("yyyy-MM-dd")
        dr.Item("cancel_date") = txt_cancel_date.Value.ToString("yyyy-MM-dd")
        dr.Item("replaced") = isReplaced.Checked
        dr.Item("trans_no") = reference_no
        dr.Item("general_code") = txt_general_id.Text
        dr.Item("general_name") = txt_general_name.Text
        dr.Item("bank_code_depository") = txt_bank_id.Text
        dr.Item("bank_name_depository") = txt_bank_name_depository.Text
        dr.Item("bank_code") = txt_bank_code.Text
        dr.Item("bank_name") = txt_bank_name.Text

        If transmode = "insert" Then
            ds.Tables("checks").Rows.Add(dr)
        End If

        transmode = ""
        loadDTToDG(dgdet, ds.Tables("checks"))
        DisableControlDet(Me)
        ComputeTotalAmount()
        btninsert.Focus()
        btnhdr2.Visible = True
        btndet2.Visible = False
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If dgdet.SelectedRows.Count > 0 Then
            transmode = "update"
            EnableControlDet(Me)
            txt_general_id.Value = genref_id
            txt_general_id.Text = genref_code
            txt_general_name.Text = genref_name
            txt_bank_id.Value = bankID
            txt_bank_id.Text = bankCode
            txt_bank_name_depository.Text = bankName
            isCash.Focus()
            btnhdr2.Visible = False
            btndet2.Visible = True
        Else
            MsgBox("No Record Selected")
        End If
    End Sub
    Private Sub btnundo_Click(sender As Object, e As EventArgs) Handles btnundo.Click
        transmode = ""
        ClearControlDet(Me)
        DisableControlDet(Me)
        clear_control(Me)
        btnhdr2.Visible = True
        btndet2.Visible = False
        If dgdet.Rows.Count > 0 Then
            dgdet.ClearSelection()
            dgdet.Rows(0).Selected = True
        End If
    End Sub
    Private Sub cashor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DisableControlDet(Me)
    End Sub
    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim arr_id = getCheckedGrid("check_id", "check_no", "sel", dgdet, "", False, , False)
        If arr_id.Length > 0 Then
            For Each row As DataRow In ds.Tables("checks").Rows
                If arr_id.Contains(row.Item("check_id").ToString) Then
                    row.Item("deleted") = True
                End If
            Next
            loadDTToDG(dgdet, ds.Tables("checks"))
        End If
        ComputeTotalAmount()
    End Sub
    Private Sub cashor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadDTToDG(dgdet, ds.Tables("checks"))
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btninsert)
        dicShortCut.Add(114, btnupdate)
        dicShortCut.Add(115, btnremove)
        dicShortCut.Add(116, btnunprint)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub
    Private Sub ComputeTotalAmount()
        lbl_balance.Text = String.Format("{0:n" & main.DecimalPlaces & "}", OutstandingBalance)
        If ds.Tables("checks").Rows.Count > 0 Then
            Dim totalAmount As Decimal = 0
            Dim selectedDR = ds.Tables("checks").Select("deleted = False")
            For Each dr As DataRow In selectedDR
                totalAmount += dr.Item("check_amount")
            Next
            lbl_balance.Text = String.Format("{0:n" & main.DecimalPlaces & "}", (OutstandingBalance - totalAmount))
        End If
    End Sub
End Class