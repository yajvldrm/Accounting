Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports MySql.Data.MySqlClient
Public Class currencyrate
    Dim connMain As New MySqlConnection
    Dim connFS As New MySqlConnection
    Dim default_currency_id As String = ""
    Dim default_based_rate As Decimal = 0
    Public Property DecimalPlaces As Integer = 2
    Private Sub InitializeDecimalPlaces()
        repoNumeric.DisplayFormat.FormatString = "n" & DecimalPlaces
        repoNumeric.EditFormat.FormatString = "n" & DecimalPlaces
        repoNumeric.Mask.EditMask = "n" & DecimalPlaces
        txtExchangeRate.Properties.DisplayFormat.FormatString = "n" & DecimalPlaces
        txtExchangeRate.Properties.EditFormat.FormatString = "n" & DecimalPlaces
        txtExchangeRate.Properties.Mask.EditMask = "n" & DecimalPlaces
        txtBasedRate.Properties.DisplayFormat.FormatString = "n" & DecimalPlaces
        txtBasedRate.Properties.EditFormat.FormatString = "n" & DecimalPlaces
        txtBasedRate.Properties.Mask.EditMask = "n" & DecimalPlaces
    End Sub
    Private Sub InitializeConnection()
        EnableControl(False)
        'DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = True
        'CheckForIllegalCrossThreadCalls = False
        'bgWork.RunWorkerAsync()
        InitializeDecimalPlaces()
        connMain = New MySqlConnection(ConnectionStringMain)
        connFS = New MySqlConnection(ConnectionStringFS)
        If connFS.State = ConnectionState.Open Then
            connFS.Close()
        End If
        Me.Get_lib_erp_currencyTableAdapter.Connection = connFS
        Me.Get_lib_erp_currency_rateTableAdapter.Connection = connFS

        Me.Get_lib_erp_currencyTableAdapter.Fill(Me.Ds_currency_rate.get_lib_erp_currency)
        Me.Get_lib_erp_currency_rateTableAdapter.Fill(Me.Ds_currency_rate.get_lib_erp_currency_rate)
        If main.Sys_Default.Rows.Count > 0 Then
            default_currency_id = main.Sys_Default.Rows(0).Item("currency_id").ToString
            Dim sql As String = String.Format("SELECT based_rate 
                FROM lib_erp_currency_rate WHERE currency_id = '{0}' 
                ORDER BY currency_rate_id
                LIMIT 1", default_currency_id)
            Dim dt As DataTable = FsQuery(sql)
            If dt.Rows.Count > 0 Then
                default_based_rate = CDec(ifNull(dt.Rows(0).Item("based_rate"), 0))
            End If
        Else
            MsgBox("Set the default currency on System Configuration that will use for the transaction.")
            panel_button.Visible = False
        End If
    End Sub
    Private Sub EnableControl(Optional enable As Boolean = True)
        btnAdd.Visible = Not enable
        btnEdit.Visible = Not enable
        btnDelete.Visible = Not enable
        btnSave.Visible = enable
        btnCancel.Visible = enable
        parent_panel.Enabled = enable
        parent_grid.Enabled = Not enable
        txtSearch.Enabled = Not enable
        txtBasedRate.Enabled = False
    End Sub
    Private Sub currencyrate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        panel_hide.Visible = False
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Ds_currency_rate.get_lib_erp_currency_rate.currency_rate_idColumn.DefaultValue = GenerateRandomString()
        Me.Ds_currency_rate.get_lib_erp_currency_rate.currency_idColumn.DefaultValue = default_currency_id
        Me.Ds_currency_rate.get_lib_erp_currency_rate.based_rateColumn.DefaultValue = default_based_rate
        Me.Get_lib_erp_currency_rateBindingSource.AddNew()
        EnableControl()
        If default_based_rate = 0 Then
            txtBasedRate.Enabled = True
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Me.Ds_currency_rate.get_lib_erp_currency_rate.Rows.Count > 0 Then
            EnableControl()
        Else
            MsgBox("No record selected")
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim rowHandles = parent_view.GetSelectedRows()
        If rowHandles.Length > 0 Then
            Dim res = MsgBox("Delete Records?", MsgBoxStyle.YesNo, "Delete")
            If res = DialogResult.Yes Then
                Dim ids As New List(Of String)
                For i = 0 To rowHandles.Length - 1
                    Dim dv As DataRowView = parent_view.GetRow(rowHandles(i))
                    ids.Add(dv.Row.Item("currency_rate_id").ToString())
                Next
                Dim id As String = String.Join(",", ids)
                If id <> "" Then
                    Dim sql As String = String.Format("DELETE FROM lib_erp_currency_rate WHERE currency_rate_id IN({0})", id)
                    FsQuery(sql)
                    InitializeConnection()
                End If
            End If
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim currency_rate_id As String = ifNull(txtCurrencyRateID.EditValue, "").ToString
        Dim currency_id As String = ifNull(txtCurrencyID.EditValue, "").ToString
        Dim effectivitydate As String = If(ifNull(txtEffectivityDate.EditValue, "").ToString = "", "", CDate(txtEffectivityDate.EditValue).ToString("yyyy-MM-dd"))
        Dim exchange_rate As String = ifNull(txtExchangeRate.EditValue, "")
        Dim based_rate As String = ifNull(txtBasedRate.EditValue, "")
        If currency_id = "" Then
            MsgBox("Currency is Required")
            txtCurrencyID.Focus()
            Exit Sub
        End If
        If effectivitydate = "" Then
            MsgBox("Effectivity Date is Required")
            txtEffectivityDate.Focus()
            Exit Sub
        End If
        If exchange_rate = "" Then
            MsgBox("Exchange Rate is Required")
            txtExchangeRate.Focus()
            Exit Sub
        End If
        If based_rate = "" Then
            MsgBox("Based Rate is Required")
            txtBasedRate.Focus()
            Exit Sub
        End If
        If currency_rate_id.Contains("tmp_") Then
            Dim lst As New List(Of String)
            lst.Add("")
            lst.Add(currency_id)
            lst.Add(effectivitydate)
            lst.Add(exchange_rate)
            lst.Add(based_rate)
            Dim col As New List(Of KeyValuePair(Of String, String))
            col.Add(New KeyValuePair(Of String, String)("@val", ConcatinateValues(lst)))
            Dim dt As DataTable = ExecuteWithParameter("insert_lib_erp_currency_rate", ConnectionStringFS, CommandType.StoredProcedure, col)
            'If dt.Rows.Count > 0 Then

            'End If
            InitializeConnection()
            MsgBox("Save")
        Else
            Dim dic As New Dictionary(Of String, String)
            dic.Add("currency_id", currency_id)
            dic.Add("effectivitydate", effectivitydate)
            dic.Add("exchange_rate", exchange_rate)
            dic.Add("based_rate", based_rate)
            Dim sql As String = String.Format("UPDATE lib_erp_currency_rate SET {0} WHERE currency_rate_id = '{1}'", ConcatinateValues(dic), currency_rate_id)
            FsQuery(sql)
            InitializeConnection()
            MsgBox("Save")
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Get_lib_erp_currency_rateBindingSource.CancelEdit()
        EnableControl(False)
    End Sub
    Private Sub bgWork_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bgWork.DoWork
        imgLoading.Visible = True

        imgLoading.Visible = False
    End Sub
End Class