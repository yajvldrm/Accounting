Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports System.IO
Imports user_control
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class pendingAP
    Dim begbal_date As DateTime = main.Sys_Default.Rows(0).Item("sys_beg")
    Public Sub InitializeConnection()
        Dim unit_type As String = ""
        If My.Settings._enableUnitNo Then
            If My.Settings._enableBookUnit Then
                unit_type = "1"
            End If
        End If
        Dim col As New List(Of KeyValuePair(Of String, String))
        col.Add(New KeyValuePair(Of String, String)("@dbFS", _serverDBFS))
        col.Add(New KeyValuePair(Of String, String)("@unit_type", unit_type))
        Dim dt As DataTable = ExecuteWithParameter("acc_get_pending_ap", ConnectionStringMain, CommandType.StoredProcedure, col)
        ds.Tables("trans_header").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_header").ImportRow(dr)
        Next
        bs.DataSource = ds.Tables("trans_header")
    End Sub
    Private Sub FilterView()
        Dim str As String = ""
        Dim journal_id As String = ""
        Dim general_id As String = txt_general_id.Value
        Dim account_id As String = txt_account_id.Value
        Dim range_type As String = If(rdo_range.Checked, "1", "2")
        Dim date_from As DateTime = txt_date_from.Value
        Dim date_to As DateTime = txt_date_to.Value
        Dim q As String = txt_trans_no.Text.Trim()

        If txt_journal_id.SelectedIndex > 0 Then
            journal_id = txt_journal_id.SelectedIndex
        End If

        If range_type = "" Then
            If date_from > date_to Then
                MsgBox("Invalid Date Range")
                Exit Sub
            End If
        End If
        If general_id <> "" Then
            str &= String.Format(" AND general_id = '{0}'", general_id)
        End If
        If account_id <> "" Then
            str &= String.Format(" AND account_id = '{0}'", account_id)
        End If
        If range_type = "1" Then
            str &= String.Format(" AND trans_date >= #{0}# AND trans_date <= #{1}#", date_from.ToString("yyyy-MM-dd"), date_to.ToString("yyyy-MM-dd"))
        Else
            str &= String.Format(" AND trans_date <= #{0}#", date_to.ToString("yyyy-MM-dd"))
        End If
        If q <> "" Then
            str &= String.Format(" AND trans_no LIKE '%{0}%'", q)
        End If
        If journal_id <> "" Then
            str &= String.Format(" AND journal_id = '{0}'", journal_id)
        End If
        If str <> "" Then
            str = str.Substring(5, str.Length - 5)
        End If
        bs.Filter = str
    End Sub

    Private Sub RangeChange(sender As Object, e As EventArgs) Handles rdo_range.CheckedChanged, rdo_asof.CheckedChanged
        Dim range_type As String = If(rdo_range.Checked, "1", "2")
        If range_type = "1" Then
            txt_date_from.Enabled = True
            txt_date_to.MinDate = txt_date_from.Value
        Else
            txt_date_from.Enabled = False
            txt_date_to.MinDate = begbal_date
        End If

    End Sub

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs)
        txt_date_to.MinDate = txt_date_from.Value
    End Sub

    Private Sub pendingAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_general_id.Enabled = True
        txt_account_id.Enabled = True
        txt_date_from.MinDate = begbal_date
        txt_date_from.MaxDate = Today()
        txt_date_to.MaxDate = Today()
        rdo_asof.Checked = True
        main.btnShowPendingAP.Visible = False
        Me.Height = Me.Parent.Height - main.MenuStrip1.Height
    End Sub

    Private Sub pendingAP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        main.btnShowPendingAP.Visible = True
    End Sub

    Private Sub FilterChange(sender As Object, e As EventArgs) Handles txt_general_id.ValueChange, txt_account_id.ValueChange, txt_trans_no.TextChanged, txt_date_to.ValueChanged, txt_date_from.ValueChanged, txt_journal_id.SelectedIndexChanged
        FilterView()
    End Sub

    Private Sub txt_general_id_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        If txt_general_id.Text.Trim() = "" Then
            Exit Sub
        End If
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_general ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("general_name like '" & txt_general_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "general_code,general_name", "200,400")
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
                txt_general_id.Text = dr("general_name")
            Else
                txt_general_id.RowData = Nothing
                txt_general_id.Value = ""
                txt_general_id.Text = ""
                'lbl_general_name.Text = dr("general_name")
            End If
        End If
    End Sub

    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        If txt_account_id.Text.Trim() = "" Then
            Exit Sub
        End If
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_chart WHERE validation = '3' ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("account_name like '" & txt_account_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "account_code,account_name", "200,400")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_account_id.RowData = dr
                txt_account_id.Value = dr("account_id")
                txt_account_id.Text = dr("account_name")
            Else
                txt_account_id.RowData = Nothing
                txt_account_id.Value = ""
                txt_account_id.Text = ""
                'lbl_account_name.Text = dr("account_name")
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim selectedIDs As String = ""
        Dim lstID As New List(Of String)
        Dim trans_id As String = ""
        Dim trans_no As String = ""
        Dim book_id As String = ""
        Dim book_code As String = ""
        Dim book_name As String = ""
        Dim general_id As String = ""
        Dim general_code As String = ""
        Dim general_name As String = ""
        Dim account_id As String = ""
        Dim account_code As String = ""
        Dim account_name As String = ""
        Dim currency_id As String = ""
        Dim currency_code As String = ""
        Dim currency_name As String = ""
        Dim exchange_rate As Decimal = 0
        Dim based_rate As Decimal = 0
        Dim trans_date As New DateTime
        Dim totalAmount As Decimal = 0
        For Each drv As DataGridViewRow In dgView.Rows
            If drv.Selected Then
                lstID.Add(drv.Cells("jbooks_id").Value.ToString())
                trans_id = drv.Cells("trans_id").Value.ToString()
                trans_no = drv.Cells("trans_no").Value.ToString()
                book_id = drv.Cells("book_id").Value.ToString()
                book_code = drv.Cells("book_code").Value.ToString()
                book_name = drv.Cells("book_name").Value.ToString()
                general_id = drv.Cells("general_id").Value.ToString()
                general_code = drv.Cells("general_code").Value.ToString()
                general_name = drv.Cells("general_name").Value.ToString()
                currency_id = drv.Cells("currency_id").Value.ToString()
                currency_code = drv.Cells("currency_code").Value.ToString()
                currency_name = drv.Cells("currency_name").Value.ToString()
                exchange_rate = drv.Cells("exchange_rate").Value.ToString()
                based_rate = drv.Cells("based_rate").Value.ToString()
                trans_date = drv.Cells("trans_date").Value
            End If
        Next
        selectedIDs = String.Join(",", lstID)
        If selectedIDs <> "" Then
            pendingSettings.book_id = book_id
            pendingSettings.book_code = book_code
            pendingSettings.book_name = book_name
            pendingSettings.general_id = general_id
            pendingSettings.general_code = general_code
            pendingSettings.general_name = general_name
            pendingSettings.currency_id = currency_id
            pendingSettings.currency_code = currency_code
            pendingSettings.currency_name = currency_name
            pendingSettings.trans_date = trans_date
            pendingSettings.trans_no = trans_no
            pendingSettings.ShowDialog()
            If pendingSettings.DialogResult = DialogResult.OK Then
                book_id = pendingSettings.book_id
                book_code = pendingSettings.book_code
                book_name = pendingSettings.book_name
                account_id = pendingSettings.account_id
                account_code = pendingSettings.account_code
                account_name = pendingSettings.account_name
                trans_date = pendingSettings.trans_date
                trans_no = pendingSettings.trans_no
                If account_id = "" Then
                    MsgBox("No CIB Found")
                Else
                    Dim unit_type As String = ""
                    If My.Settings._enableUnitNo Then
                        If My.Settings._enableBookUnit Then
                            unit_type = "1"
                        End If
                    End If
                    Dim col As New List(Of KeyValuePair(Of String, String))
                    col.Add(New KeyValuePair(Of String, String)("@dbMain", _serverDBMain))
                    col.Add(New KeyValuePair(Of String, String)("@dbFS", _serverDBFS))
                    col.Add(New KeyValuePair(Of String, String)("@trans_id", trans_id))
                    col.Add(New KeyValuePair(Of String, String)("@jbooks_id", selectedIDs))
                    col.Add(New KeyValuePair(Of String, String)("@unit_type", unit_type))
                    Dim dtTrans As DataTable = ExecuteWithParameter("get_trans_apcv", ConnectionStringMain, CommandType.StoredProcedure, col)
                    Dim dtJBooks As DataTable = ExecuteWithParameter("get_trans_apcv_new", ConnectionStringMain, CommandType.StoredProcedure, col)
                    Dim dtChecks As DataTable = ds.Tables("checks").Clone
                    dtChecks.Clear()
                    If dtTrans.Rows.Count > 0 And dtJBooks.Rows.Count > 0 Then
                        Dim str As String = trans_date.ToString("yyyy-MM-dd")
                        Dim d As New MySql.Data.Types.MySqlDateTime(str)
                        dtTrans.Rows(0).Item("trans_date") = d
                        dtTrans.Rows(0).Item("trans_no") = trans_no
                        totalAmount = dtJBooks.Compute("SUM(debit)", "TRUE")
                        dtTrans.Rows(0).Item("amount") = totalAmount
                        dtTrans.Rows(0).Item("amount_based") = totalAmount * (exchange_rate / based_rate)
                        dtTrans.Rows(0).Item("general_id") = general_id
                        dtTrans.Rows(0).Item("general_code") = general_code
                        dtTrans.Rows(0).Item("general_name") = general_name
                        Dim newDR As DataRow = dtJBooks.NewRow
                        Dim check_id = GenerateRandomString() & "_cash"
                        newDR.Item("jbooks_id_tmp") = check_id
                        newDR.Item("project_id") = dtJBooks.Rows(0).Item("project_id")
                        newDR.Item("project_code") = dtJBooks.Rows(0).Item("project_code")
                        newDR.Item("project_name") = dtJBooks.Rows(0).Item("project_name")
                        newDR.Item("department_id") = dtJBooks.Rows(0).Item("department_id")
                        newDR.Item("department_code") = dtJBooks.Rows(0).Item("department_code")
                        newDR.Item("department_name") = dtJBooks.Rows(0).Item("department_name")
                        newDR.Item("account_id") = account_id
                        newDR.Item("account_code") = account_code
                        newDR.Item("account_name") = account_name
                        newDR.Item("debit") = 0
                        newDR.Item("credit") = totalAmount
                        newDR.Item("debit_based") = 0
                        newDR.Item("credit_based") = (totalAmount * (exchange_rate / based_rate))
                        newDR.Item("validation") = 1
                        newDR.Item("dc") = 1
                        newDR.Item("currency_id") = currency_id
                        newDR.Item("currency_code") = currency_code
                        newDR.Item("currency_name") = currency_name
                        newDR.Item("exchange_rate") = exchange_rate
                        newDR.Item("based_rate") = based_rate
                        dtJBooks.Rows.Add(newDR)
                        'cashcv
                        Dim cashcv_ds As DataTable = cashcv.ds.Tables("checks")
                        cashcv_ds.Clear()
                        'dtCopy(cashcv_ds, tmp_dt, {"check_id", "check_no"})
                        cashcv.jbooks_id = check_id
                        cashcv.genref_id = general_id
                        cashcv.genref_code = general_code
                        cashcv.genref_name = general_name
                        cashcv.currency_id = currency_id
                        cashcv.exchange_rate = exchange_rate
                        cashcv.based_rate = based_rate
                        cashcv.journal_code = "CV"
                        cashcv.book_code = book_code
                        cashcv.trans_date = trans_date
                        cashcv.defaultDate = trans_date
                        Dim sql As String = String.Format("SELECT bank_id,bank_code,bank_name " &
                            "FROM lib_erp_bank " &
                            "WHERE bank_code = '{0}'", account_code)
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
                        cashcv.OutstandingBalance = totalAmount
                        cashcv.txtCheckAmount.EditValue = totalAmount
                        cashcv.txtCheckAmountBased.EditValue = cashcv.txtCheckAmount.EditValue * (exchange_rate / based_rate)

                        'raymond - 2016-06-08 (start)
                        cashcv.book_code = book_code
                        cashcv.reference_no = ""
                        'raymond - 2016-06-08 (end)
                        If cashcv.ShowDialog() = DialogResult.OK Then
                            Dim tmp_ds = cashcv.ds.Tables("checks")
                            dtCopy(dtChecks, cashcv.ds.Tables("checks"), {"check_id", "check_no"})
                            transactioncv.CreateCVFromAP = True
                            transactioncv.BookID = book_id
                            transactioncv.BookCode = book_code
                            transactioncv.BookName = book_name
                            transactioncv.JournalID = "4"
                            transactioncv.JournalCode = "CV"
                            transactioncv.transMode = "add"
                            transactioncv.mySettings = New settings
                            showForm(transactioncv, main)
                            transactioncv.ReverseAP(dtTrans.Rows(0), dtJBooks, dtChecks, trans_no)
                        End If
                    Else
                        MsgBox("Voucher already paid.")
                    End If
                End If
            End If
        Else
            MsgBox("No Record Selected")
        End If
        InitializeConnection()
    End Sub
End Class