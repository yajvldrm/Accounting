Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Public Class DETransactionCV
    Public Property TransactionMonth As Integer = Today.Month
    Public Property TransactionYear As Integer = Today.Year
    Public Property BookID As String = ""
    Public Property Bookname As String = ""
    Public Property JournalID As String = ""
    Public Property JournalName As String = ""
    Public Property MySettings As XtraForm = Nothing
    Private transmode = ""
    Private Sub EnableControl(Optional enable As Boolean = True)
        dgMain.Enabled = Not enable
        btnAdd.Visible = Not enable
        btnEdit.Visible = Not enable
        btnCancel.Visible = Not enable
        btnSave.Visible = enable
        btnNotSave.Visible = enable
        pnlHeader.Enabled = enable
    End Sub
    Private Sub DETransactionCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using cn As New MySqlConnection With {.ConnectionString = ConnectionStringFS}
            Me.terms_ta.Connection = cn
            Me.general_ta.Connection = cn
            Me.currency_ta.Connection = cn
            Me.chart_ta.Connection = cn
            Me.project_ta.Connection = cn
            Me.department_ta.Connection = cn
            Me.allocation_ta.Connection = cn
        End Using
        Using cn As New MySqlConnection With {.ConnectionString = ConnectionStringMain}
            Me.trans_header_ta.Connection = cn
            Me.trans_jbooks_ta.Connection = cn
        End Using
        Me.terms_ta.Fill(Me.DEFSTableSet.lib_erp_terms)
        Me.allocation_ta.Fill(Me.DEFSTableSet.lib_erp_allocation)
        Me.department_ta.Fill(Me.DEFSTableSet.lib_erp_department)
        Me.project_ta.Fill(Me.DEFSTableSet.lib_erp_project)
        Me.general_ta.Fill(Me.DEFSTableSet.lib_erp_general)
        Me.chart_ta.Fill(Me.DEFSTableSet.lib_erp_chart)

        Dim minDate As Date = New Date(TransactionYear, TransactionMonth, 1)
        Dim maxDate As Date = minDate.AddMonths(1).AddDays(-1)
        txtTransDate.Properties.MinValue = minDate
        txtTransDate.Properties.MaxValue = maxDate
        txtTransDate.DateTime = Today

        Dim TransactionDate As Date = New Date(TransactionYear, TransactionMonth, 1)
        Me.trans_header_ta.Fill(TransactionSet.get_trans_header, BookID, JournalID, TransactionDate)

        EnableControl(False)
    End Sub

    Private Sub Trans_dateDateEdit_EditValueChanged(sender As Object, e As EventArgs) Handles txtTransDate.EditValueChanged
        Dim trans_date = txtTransDate.DateTime.ToString("yyyy-MM-dd")
        Me.currency_ta.Fill(Me.DEFileSetupSet.get_currency_rate, 1, trans_date)
    End Sub

    Private Sub txtCurrencyID_EditValueChanged(sender As Object, e As EventArgs) Handles txtCurrencyID.EditValueChanged
        Dim dr As DataRowView = txtCurrencyID.GetSelectedDataRow
        txtCurrencyName.EditValue = ""
        txtExchangeRate.EditValue = ""
        txtBasedRate.EditValue = ""
        If dr IsNot Nothing Then
            txtCurrencyIDDet.EditValue = txtCurrencyID.EditValue
            txtCurrencyName.EditValue = dr.Item("currency_name").ToString
            txtExchangeRate.EditValue = dr.Item("exchange_rate").ToString
            txtBasedRate.EditValue = dr.Item("based_rate").ToString
        End If
    End Sub

    Private Sub txtGeneralID_EditValueChanged(sender As Object, e As EventArgs) Handles txtGeneralID.EditValueChanged
        Dim dr As DataRowView = txtGeneralID.GetSelectedDataRow
        If dr IsNot Nothing Then
            txtGeneralName.EditValue = dr.Item("general_name").ToString
        End If
    End Sub

    Private Sub txtAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmount.EditValueChanged
        Dim amount As Decimal = CDec(ifNull(txtAmount.EditValue, 0))
        Dim exchange_rate As Decimal = CDec(ifNull(txtExchangeRate.EditValue, 0))
        Dim based_rate As Decimal = CDec(ifNull(txtBasedRate.EditValue, 0))
        txtAmountWord.EditValue = amount_words(amount)
        If based_rate <> 0 Then
            txtAmountBased.EditValue = (amount * (exchange_rate / based_rate))
        End If
    End Sub

    Private Sub txtExchangeRate_EditValueChanged(sender As Object, e As EventArgs) Handles txtExchangeRate.EditValueChanged, txtBasedRate.EditValueChanged
        Dim amount As Decimal = CDec(ifNull(txtAmount.EditValue, 0))
        Dim exchange_rate As Decimal = CDec(ifNull(txtExchangeRate.EditValue, 0))
        Dim based_rate As Decimal = CDec(ifNull(txtBasedRate.EditValue, 0))
        txtAmountWord.EditValue = amount_words(amount)
        If based_rate <> 0 Then
            txtAmountBased.EditValue = (amount * (exchange_rate / based_rate))
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EnableControl()
        trans_header_bs.AddNew()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableControl()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim trans_id As String = GridView1.GetFocusedRowCellValue("trans_id")
        If trans_id IsNot Nothing Then
            If transmode = "update" Then
                trans_header_bs.EndEdit()
                'IN trans_id bigint(20) unsigned,IN trans_no varchar(30),IN trans_date date,IN book_id smallint(5) unsigned,IN journal_id smallint(5) unsigned,IN general_id smallint(5) unsigned,IN currency_id smallint(5) unsigned,IN exchange_rate decimal(9,4),IN based_rate decimal(9,4),IN amount decimal(17,2),IN amount_based decimal(17,2) unsigned,IN description longtext,IN posted tinyint(1) unsigned,IN status varchar(1)
                trans_header_ta.Update(trans_id, txtTransNo.EditValue, txtTransDate.EditValue, BookID, JournalID, txtGeneralID.EditValue, txtCurrencyID.EditValue, txtExchangeRate.EditValue, txtBasedRate.EditValue, txtAmount.EditValue, txtAmountBased.EditValue, txtParticular.EditValue, Nothing, Nothing)
                TransactionSet.get_trans_header.AcceptChanges()
            End If
        End If
        If transmode = "insert" Then
            trans_header_bs.EndEdit()
            trans_header_ta.Update(TransactionSet.get_trans_header)
            TransactionSet.AcceptChanges()
        End If
        transmode = ""
        EnableControl(False)

        EnableControl(False)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If MySettings IsNot Nothing Then
            MySettings.ShowDialog()
        End If
    End Sub
    Public Overrides Sub Refresh()
        DETransactionCV_Load(Nothing, Nothing)
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        trans_header_bs.CancelEdit()
        EnableControl(False)
    End Sub

    Private Sub txtGeneralIDDet_EditValueChanged(sender As Object, e As EventArgs) Handles txtGeneralIDDet.EditValueChanged
        Dim dr As DataRowView = txtGeneralIDDet.GetSelectedDataRow
        If dr IsNot Nothing Then
            txtGeneralNameDet.EditValue = dr.Item("general_name").ToString
            txtTermsIDDet.EditValue = dr.Item("terms_id").ToString
        End If
    End Sub

    Private Sub txtCurrencyIDDet_EditValueChanged(sender As Object, e As EventArgs) Handles txtCurrencyIDDet.EditValueChanged
        Dim dr As DataRowView = txtCurrencyIDDet.GetSelectedDataRow
        If dr IsNot Nothing Then
            txtExchangeRateDet.EditValue = dr.Item("exchange_rate").ToString
            txtBasedRateDet.EditValue = dr.Item("based_rate").ToString
        End If
    End Sub

    Private Sub txtAccountIDDet_EditValueChanged(sender As Object, e As EventArgs) Handles txtAccountIDDet.EditValueChanged
        Dim dr As DataRowView = txtAccountIDDet.GetSelectedDataRow
        If dr IsNot Nothing Then
            txtAccountNameDet.EditValue = dr.Item("account_name").ToString
        End If
    End Sub

    Private Sub txtTermsIDDet_EditValueChanged(sender As Object, e As EventArgs) Handles txtTermsIDDet.EditValueChanged
        Dim dr As DataRowView = txtTermsIDDet.GetSelectedDataRow
        If dr IsNot Nothing Then
            txtNodaysDet.EditValue = dr.Item("nodays").ToString
            If dr.Item("fixed_day") Then
                txtNodaysDet.Enabled = False
            Else
                If pnlDet.Enabled Then
                    txtNodaysDet.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.SelectedRowsCount > 0 Then
            Dim trans_id = GridView1.GetFocusedRowCellValue("trans_id").ToString
            Try
                trans_jbooks_ta.Connection.Close()
            Catch ex As Exception
            End Try
            trans_jbooks_ta.Fill(TransactionSet.get_trans_jbooks, trans_id)
        End If
    End Sub

    Private Sub txtDebitDet_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebitDet.EditValueChanged
        Dim debit As Decimal = CDec(ifNull(txtDebitDet.EditValue, 0))
        Dim exchange_rate As Decimal = CDec(ifNull(txtExchangeRateDet.EditValue, 0))
        Dim based_rate As Decimal = CDec(ifNull(txtBasedRateDet.EditValue, 0))
        If based_rate <> 0 Then
            txtDebitBasedDet.EditValue = (debit * (exchange_rate / based_rate))
        End If
    End Sub

    Private Sub txtCreditDet_EditValueChanged(sender As Object, e As EventArgs) Handles txtCreditDet.EditValueChanged
        Dim credit As Decimal = CDec(ifNull(txtCreditDet.EditValue, 0))
        Dim exchange_rate As Decimal = CDec(ifNull(txtExchangeRateDet.EditValue, 0))
        Dim based_rate As Decimal = CDec(ifNull(txtBasedRateDet.EditValue, 0))
        If based_rate <> 0 Then
            txtCreditBasedDet.EditValue = (credit * (exchange_rate / based_rate))
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

    End Sub
End Class