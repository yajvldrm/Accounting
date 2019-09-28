Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class begbal_pre_detail
    Dim dbTable As String = "trans_prepaid"
    Dim ds As New begbal
    Private transmode As String = ""
    Private _jbooks_id As String = "0"
    Dim _currency_id As String = ""
    Dim _exchange_rate As String = ""
    Dim _based_rate As String = ""
    Dim loadEnd As Boolean = False
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txt_historical_rate.NumberFormat = strNumberFormat
        txt_amount.NumberFormat = strNumberFormat
        txt_amount_based.NumberFormat = strNumberFormat
        txt_useful_life.NumberFormat = strNumberFormat
        txt_net_book_value.NumberFormat = strNumberFormat
        txt_net_book_value_based.NumberFormat = strNumberFormat
        txt_debit_based.NumberFormat = strNumberFormat
        txt_quantity.NumberFormat = strNumberFormat
        txt_exchange_rate.NumberFormat = strNumberFormat
        txt_based_rate.NumberFormat = strNumberFormat
    End Sub
    Public Property currency_id() As String
        Get
            Return _currency_id
        End Get
        Set(ByVal value As String)
            _currency_id = value
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
    Public Property jbooks_id() As String
        Get
            Return _jbooks_id
        End Get
        Set(ByVal value As String)
            _jbooks_id = value
        End Set
    End Property
    Public Property MyParent As fsbeg = Nothing
    Public Property trans_id As String = ""
    Public Property book_id As String = ""
    Public Property project_id As String = ""
    Public Property department_id As String = ""
    Public Property account_id As String = ""
    Public Property BookUnitNoID As String = ""
    Public Property begbal_date As DateTime = Today
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        If jbooks_id <> "0" And jbooks_id <> "" Then
            Dim sql = String.Format("SELECT a.prepaid_id,a.jbooks_id,a.currency_id,a.exchange_rate,a.based_rate,a.description " &
                ",a.date_acquired,a.amount,a.amount_based,a.useful_life,a.date_start,a.debit,a.credit,a.debit_based,a.credit_based " &
                ",a.ref_prepaid_id,asset_code,historical_rate,quantity,net_book_value,net_book_value_based,b.currency_name,c.prepaid_ref_id,c.ref_no " &
                ",IF(a.debit > d.credit,'Partially Paid',IF(a.debit = d.credit,'Fully Paid','')) AS status " &
                ",IF(a.debit > d.credit,d.credit,IF(a.debit = d.credit,a.debit,0)) AS minimum " &
                "FROM trans_prepaid a " &
                "LEFT JOIN {1}.lib_erp_currency b ON b.currency_id = a.currency_id " &
                "LEFT JOIN trans_prepaid_ref c ON c.prepaid_id = a.prepaid_id " &
                "LEFT JOIN (" &
                    "SELECT a.ref_prepaid_id AS prepaid_id,SUM(a.debit) AS debit,SUM(a.credit) AS credit " &
                    ",SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based " &
                    "FROM trans_prepaid a " &
                    "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " &
                    "LEFT JOIN trans_header c ON c.trans_id = b.trans_id " &
                    "WHERE (c.status <> 'C' OR c.status IS NULL) " &
                    "GROUP BY a.ref_prepaid_id " &
                ") d ON d.prepaid_id = a.prepaid_id " &
                "WHERE a.jbooks_id = {0} AND a.currency_id = {2}", jbooks_id, _serverDBFS, currency_id)
            Dim dt As DataTable = Query(sql)
            ds.Tables(dbTable).Clear()
            For Each row As DataRow In dt.Rows
                ds.Tables(dbTable).ImportRow(row)
            Next
            dgMain.DataSource = ds.Tables(dbTable)
        End If
        Dim currency_sql As String = String.Format("SELECT a.currency_code,a.currency_name FROM lib_erp_currency a WHERE a.currency_id = {0}", currency_id)
        Dim currency_dt As DataTable = FsQuery(currency_sql)
        txt_currency_id.Value = currency_id
        txt_currency_id.Text = currency_dt.Rows(0).Item("currency_name")
        txt_exchange_rate.DecimalValue = exchange_rate
        txt_based_rate.DecimalValue = based_rate
        Dim company_sql As String = String.Format("SELECT sys_beg FROM sys_default LIMIT 1")
        Dim company_dt As DataTable = Query(company_sql)
        Dim maxdate As DateTime = company_dt.Rows(0).Item("sys_beg")
        txt_date_acquired.MaxDate = maxdate
        computeGrid()
        loadEnd = True
    End Sub
    Private Sub begbal_pre_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDecimalPlaces(main.strNumberFormat)
        init_load()
        disable_control(Me)
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = dgMain.DataSource
        bind_control(dgMain, "prepaid_id", dt, Me)
    End Sub
    Private Sub begbal_pre_detail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DialogResult = DialogResult.OK
        'Me.Close()
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        txt_prepaid_id.Text = "ag-" & Now.ToString("yyyyMMddHHmmssfff")
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
        Else
            MsgBox("No Record Selected")
        End If
    End Sub
    Private Sub computeGrid()
        Dim total_debit As Decimal = 0
        Dim total_debit_based As Decimal = 0
        Dim dt As DataTable = dgMain.DataSource
        If dt.Select("deleted = 'False'").Count > 0 Then
            total_debit = dt.Compute("SUM(debit)", "deleted = 'False'")
            total_debit_based = dt.Compute("SUM(debit_based)", "deleted = 'False'")
        End If
        txt_total_based.DecimalValue = total_debit_based
        txt_total_amount.DecimalValue = total_debit
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = dgMain.DataSource
        Dim dr = dt.NewRow
        Dim err As Boolean = False
        Dim pk As String = ""
        Dim prepaid_id = txt_prepaid_id.Value
        Dim ref_no = txt_ref_no.Text
        Dim j_books_id = jbooks_id
        Dim historical_rate = txt_historical_rate.DecimalValue
        Dim currency_id = txt_currency_id.Value
        Dim currency_name = txt_currency_id.Text
        Dim exchange_rate = txt_exchange_rate.DecimalValue
        Dim based_rate = txt_based_rate.DecimalValue
        Dim date_acquired = txt_date_acquired.Value
        Dim date_start = txt_date_start.Value
        Dim amount = txt_amount.DecimalValue
        Dim amount_based = amount * (exchange_rate / based_rate)
        Dim net_book_value = txt_net_book_value.DecimalValue
        Dim net_book_value_based = net_book_value * (exchange_rate / based_rate)
        Dim useful_life = txt_useful_life.DecimalValue
        Dim asset_code = txt_asset_code.Text
        Dim quantity = txt_quantity.DecimalValue
        Dim description = txt_description.Text
        Dim debit = net_book_value
        Dim debit_based = net_book_value_based
        'trans_prepaid
        dr.Item("prepaid_id") = prepaid_id
        dr.Item("jbooks_id") = j_books_id
        dr.Item("currency_id") = currency_id
        dr.Item("currency_name") = currency_name
        dr.Item("exchange_rate") = exchange_rate
        dr.Item("based_rate") = based_rate
        dr.Item("description") = description
        dr.Item("asset_code") = asset_code
        dr.Item("historical_rate") = historical_rate
        dr.Item("quantity") = quantity
        dr.Item("date_acquired") = date_acquired
        dr.Item("amount") = amount
        dr.Item("amount_based") = amount_based
        dr.Item("net_book_value") = net_book_value
        dr.Item("net_book_value_based") = net_book_value_based
        dr.Item("useful_life") = useful_life
        dr.Item("date_start") = date_start
        dr.Item("debit") = debit
        dr.Item("debit_based") = debit_based
        dr.Item("credit") = 0
        dr.Item("credit_based") = 0
        dr.Item("unit_id") = txt_unit_id.Value
        dr.Item("unit_name") = txt_unit_id.Text
        'trans_prepaid_ref
        dr.Item("ref_no") = ref_no

        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            If transmode = "insert" Then
                If DataExist(dgMain, {"prepaid_id", txt_prepaid_id.Value}, {"ref_no"}, {txt_ref_no.Text}) Then
                    MsgBox("Prepayment already exist")
                    err = True
                Else
                    dr.Item("prepaid_id") = "ag-" & dt.Rows.Count
                    dt.Rows.Add(dr)
                    pk = dr.Item("prepaid_id")
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"prepaid_id", txt_prepaid_id.Value}, {"ref_no"}, {txt_ref_no.Text}, False) Then
                    MsgBox("Prepayment already exist")
                    err = True
                Else
                    Dim id = dgMain.SelectedRows(0).Cells("prepaid_id").Value.ToString
                    Dim row As DataRow = dt.Select(String.Format("prepaid_id = '{0}'", id))(0)
                    'trans_prepaid
                    row.Item("jbooks_id") = j_books_id
                    row.Item("currency_id") = currency_id
                    row.Item("currency_name") = currency_name
                    row.Item("exchange_rate") = exchange_rate
                    row.Item("based_rate") = based_rate
                    row.Item("description") = description
                    row.Item("asset_code") = asset_code
                    row.Item("historical_rate") = historical_rate
                    row.Item("quantity") = quantity
                    row.Item("date_acquired") = date_acquired
                    row.Item("amount") = amount
                    row.Item("amount_based") = amount_based
                    row.Item("net_book_value") = net_book_value
                    row.Item("net_book_value_based") = net_book_value_based
                    row.Item("useful_life") = useful_life
                    row.Item("date_start") = date_start
                    row.Item("debit") = debit
                    row.Item("debit_based") = debit_based
                    row.Item("credit") = 0
                    row.Item("credit_based") = 0
                    row.Item("unit_id") = txt_unit_id.Value
                    row.Item("unit_name") = txt_unit_id.Text
                    'trans_prepaid_ref
                    row.Item("ref_no") = ref_no
                    pk = id
                End If
            ElseIf transmode = "remove" Then
            End If
            loadDTToDG(dgMain, dt)
            If Not err Then
                computeGrid()
                transmode = ""
                disable_control(Me)
                btnInsert.Focus()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("prepaid_id").Value.ToString = pk Then
                        row.Selected = True
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)
        Dim dt As DataTable = dgMain.DataSource
        bind_control(dgMain, "prepaid_id", dt, Me)
    End Sub
    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_currency")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("currency_name like '{0}'", txt_currency_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "currency_code,currency_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_currency_id.RowData = dr
                txt_currency_id.Value = dr("currency_id")
                txt_currency_id.Text = dr("currency_name")
                Dim sql As String = String.Format("SELECT * FROM lib_erp_currency_rate WHERE currency_id = {0} AND effectivitydate <= '{1}' ORDER BY effectivitydate DESC LIMIT 1", txt_currency_id.Value, begbal_date.ToString("yyyy-MM-dd"))
                Dim rate_dt As DataTable = FsQuery(sql)
                If rate_dt.Rows.Count > 0 Then
                    txt_exchange_rate.DecimalValue = rate_dt.Rows(0).Item("exchange_rate")
                    txt_based_rate.DecimalValue = rate_dt.Rows(0).Item("based_rate")
                Else
                    txt_exchange_rate.DecimalValue = 0
                    txt_based_rate.DecimalValue = 0
                End If
            End If
        End If
    End Sub
    Private Sub computeNetBookValue()
        '
        'Formula to compute the "Net Book Value"
        '
        'Depreciation for the Month = (Acquisition Cost - Salvage Value) / Useful Life
        'Accumulated Depreciation = Number of months between Start of Lapsing upto System Begining Balance Date * Depreciation for the Month
        'Netbook Value = Acquisition Cost - Accumulated Depreciation
        '
        If loadEnd Then
            Dim amount As Decimal = txt_amount.DecimalValue
            Dim exchange_rate As Decimal = txt_exchange_rate.DecimalValue
            Dim based_rate As Decimal = txt_based_rate.DecimalValue
            Dim useful_life As Decimal = txt_useful_life.DecimalValue
            Dim lapsing As Date = txt_date_start.Value
            Dim begbal As DateTime = begbal_date 'magigin january 1 ng current year pagdating sa transaction
            Dim Monthly_Depreciation = If(useful_life = 0, 0, (amount / useful_life))
            Dim Months_Between_Lapsing_and_Begbal As Integer = DateDiff(DateInterval.Month, lapsing, begbal) + 1
            Dim Accumulate_Depreciation As Decimal = Months_Between_Lapsing_and_Begbal * Monthly_Depreciation
            Dim netbook_value = amount - Accumulate_Depreciation
            txt_net_book_value.DecimalValue = amount * (exchange_rate / based_rate)
            txt_amount_based.DecimalValue = amount * (exchange_rate / based_rate)
            txt_debit_based.DecimalValue = amount * (exchange_rate / based_rate)
            txt_net_book_value.DecimalValue = netbook_value
            txt_net_book_value_based.DecimalValue = netbook_value * (exchange_rate / based_rate)
        End If
    End Sub
    Private Sub ComputeResult(sender As Object, e As EventArgs) Handles txt_useful_life.Leave, txt_amount.Leave, txt_date_start.ValueChanged, txt_exchange_rate.Leave, txt_based_rate.Leave
        computeNetBookValue()
        If transmode = "update" Then
            If loadEnd Then
                Dim selectedRows = dgMain.SelectedRows
                If selectedRows.Count > 0 Then
                    Dim selectedRow = selectedRows(0)
                    If selectedRow.Cells("minimum").Value > txt_net_book_value.DecimalValue Then
                        MsgBox("Invalid amount.")
                        If sender.Name <> "txt_exchange_rate" And sender.Name <> "txt_based_rate" Then
                            sender.Focus()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txt_net_book_value_Leave(sender As Object, e As EventArgs) Handles txt_net_book_value.Leave
        txt_net_book_value_based.DecimalValue = txt_net_book_value.DecimalValue * (txt_exchange_rate.DecimalValue / txt_based_rate.DecimalValue)
    End Sub

    Private Sub txt_date_acquired_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_acquired.ValueChanged
        txt_date_start.MinDate = txt_date_acquired.Value
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnInsert)
        dicShortCut.Add(114, btnUpdate)
        dicShortCut.Add(115, btnRemove)
        'dicShortCut.Add(116, btnPrint)
        dicShortCut.Add(117, btnViewDetails)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        Dim id As String = txt_prepaid_id.Value.ToString
        If id <> "" Then
            Try
                Dim dt As DataTable = ds.Tables("begbal_detail")
                dt.Clear()
                'ref_no,trans_date,book_code,account_code,debit,credit
                Dim sql = String.Format("SELECT a.trans_no AS ref_no,a.trans_date,d.book_code,e.account_code,e.account_name,b.debit,b.credit " & _
                    "FROM trans_header a " & _
                    "LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
                    "LEFT JOIN trans_prepaid c ON c.jbooks_id = b.jbooks_id " & _
                    "LEFT JOIN {1}.lib_erp_book d ON d.book_id = a.book_id " & _
                    "LEFT JOIN {1}.lib_erp_chart e ON e.account_id = b.account_id " & _
                    "WHERE c.ref_prepaid_id = '{0}' AND (a.status <> 'C' OR a.status IS NULL)", id, _serverDBFS)
                Dim data As DataTable = Query(sql)

                For Each row As DataRow In data.Rows
                    dt.ImportRow(row)
                Next

                Dim autogeneratecolumns As System.Reflection.PropertyInfo = begbal_det.Controls("dgMain").GetType.GetProperty("AutoGenerateColumns")
                If Not autogeneratecolumns Is Nothing Then
                    autogeneratecolumns.SetValue(begbal_det.Controls("dgmain"), False, Nothing)
                End If
                Dim datasource As System.Reflection.PropertyInfo = begbal_det.Controls("dgMain").GetType.GetProperty("DataSource")
                If Not datasource Is Nothing Then
                    datasource.SetValue(begbal_det.Controls("dgMain"), dt, Nothing)
                End If

                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item("book_code").ToString = "" And dt.Rows.Count = 1 Then
                        MsgBox("No Records to View.")
                    Else
                        begbal_det.Refresh()
                        begbal_det.ShowDialog()
                    End If
                Else
                    MsgBox("No Records to View.")
                End If
            Catch err As Exception
                MsgBox(err.Message)
            End Try
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim selectedIDS = getCheckedGrid("prepaid_id", "ref_no", "sel", dgMain, , True, , True)
        If selectedIDS.Length > 0 Then
            For Each id As String In selectedIDS
                Dim selectedRows = ds.Tables(dbTable).Select(String.Format("prepaid_id = '{0}'", id))
                If selectedRows.Count > 0 Then
                    Dim selectedRow = selectedRows(0)
                    selectedRow.Item("deleted") = True
                    ds.Tables(dbTable).AcceptChanges()
                End If
            Next
            loadDTToDG(dgMain, ds.Tables(dbTable))
            computeGrid()
        End If
    End Sub

    Private Sub txt_ref_no_Leave(sender As Object, e As EventArgs) Handles txt_ref_no.Leave
        Dim ref_no As String = txt_ref_no.Text
        If ref_no = "" Then
            MsgBox("Reference Number is Required.")
            txt_ref_no.Focus()
        Else
            If transmode = "insert" Then
                Dim sql As String = String.Format("SELECT prepaid_id FROM trans_prepaid_ref WHERE ref_no = '{0}'", ref_no)
                Dim dt As DataTable = Query(sql)
                If dt.Rows.Count > 0 Then
                    If txt_ref_no.Enabled Then
                        MsgBox("Reference Number Already Exist.")
                        txt_ref_no.Focus()
                    End If
                End If
            Else
                Dim sql As String = String.Format("SELECT prepaid_id FROM trans_prepaid_ref WHERE ref_no = '{0}' AND prepaid_id <> '{1}'", ref_no, txt_prepaid_id.Text)
                Dim dt As DataTable = Query(sql)
                If dt.Rows.Count > 0 Then
                    If txt_ref_no.Enabled Then
                        MsgBox("Reference Number Already Exist.")
                        txt_ref_no.Focus()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub dgMain_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgMain.CellFormatting
        For Each row As DataGridViewRow In dgMain.Rows
            If row.Cells("status").Value.ToString <> "" Then
                row.Cells(0).ReadOnly = True
            End If
        Next
    End Sub

    Private Sub txt_unit_id_Leave(sender As Object, e As EventArgs) Handles txt_unit_id.Leave
        If My.Settings._enableUnitNo Then
            If My.Settings._enableBookUnit Then
                Dim sql As String = String.Format("SELECT book_unit_no_id AS unit_id,book_unit_no_code AS unit_code,book_unit_no_name AS unit_name FROM lib_erp_book_unit_no")
                If book_id <> "" Then
                    sql &= String.Format(" WHERE book_id = '{0}'", book_id)
                End If
                Dim dt As DataTable = FsQuery(sql)
                If dt.Rows.Count = 0 Then
                    MsgBox("No record found.")
                Else
                    Dim dr As DataRow = Nothing
                    If dt.Rows.Count = 1 Then
                        dr = dt.Rows(0)
                    Else
                        Dim dra() As DataRow = dt.Select(String.Format("unit_name like '{0}'", txt_unit_id.Text.ToString.Replace("'", "''")))
                        If dra.Count > 0 Then
                            dr = dra(0)
                        Else
                            browse.dt = dt
                            browse.format("Code,Name", "unit_code,unit_name", "100,200")
                            If browse.ShowDialog() = DialogResult.OK Then
                                If browse.dgview.SelectedRows.Count > 0 Then
                                    dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                                End If
                            End If
                        End If
                    End If
                    If Not dr Is Nothing Then
                        txt_unit_id.RowData = dr
                        txt_unit_id.Value = dr("unit_id")
                        txt_unit_id.Text = dr("unit_name")
                    End If
                End If
            Else
                Dim sql As String = String.Format("SELECT project_unit_no_id AS unit_id,project_unit_no_codes AS unit_code,project_unit_no_names AS unit_name FROM lib_erp_project_unit_no")
                If project_id <> "" Then
                    sql &= String.Format(" WHERE project_id = '{0}'", project_id)
                End If
                Dim dt As DataTable = FsQuery(sql)
                If dt.Rows.Count = 0 Then
                    MsgBox("No record found.")
                Else
                    Dim dr As DataRow = Nothing
                    If dt.Rows.Count = 1 Then
                        dr = dt.Rows(0)
                    Else
                        Dim dra() As DataRow = dt.Select(String.Format("unit_name like '{0}'", txt_unit_id.Text.ToString.Replace("'", "''")))
                        If dra.Count > 0 Then
                            dr = dra(0)
                        Else
                            browse.dt = dt
                            browse.format("Code,Name", "unit_code,unit_name", "100,200")
                            If browse.ShowDialog() = DialogResult.OK Then
                                If browse.dgview.SelectedRows.Count > 0 Then
                                    dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                                End If
                            End If
                        End If
                    End If
                    If Not dr Is Nothing Then
                        txt_unit_id.RowData = dr
                        txt_unit_id.Value = dr("unit_id")
                        txt_unit_id.Text = dr("unit_name")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub begbal_pre_detail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ds.Tables("trans_jbooks").Clear()
        For Each dr As DataRow In MyParent.ds.Tables("trans_jbooks").Rows
            ds.Tables("trans_jbooks").ImportRow(dr)
        Next
        Dim lstUnitID As New Dictionary(Of String, String)
        Dim filter As String = ""
        If project_id <> "" Then
            filter &= String.Format(" AND project_id = '{0}'", project_id)
        End If
        If department_id <> "" Then
            filter &= String.Format(" AND department_id = '{0}'", department_id)
        End If
        If account_id <> "" Then
            filter &= String.Format(" AND account_id = '{0}'", account_id)
        End If
        If ds.Tables("trans_prepaid").Rows.Count = 0 Then
            ds.Tables("trans_prepaid").Clear()
            Dim dt_iv As DataTable = dgMain.DataSource
            For Each dr As DataRow In dt_iv.Rows
                ds.Tables("trans_prepaid").ImportRow(dr)
            Next
        End If
        If ds.Tables("trans_prepaid").Rows.Count > 0 Then
            If My.Settings._enableUnitNo Then
                For Each dr As DataRow In ds.Tables("trans_prepaid").Rows
                    If Not lstUnitID.ContainsKey(dr("unit_id")) Then
                        lstUnitID.Add(dr("unit_id"), "")
                        Dim drs = ds.Tables("trans_jbooks").Select(String.Format(filter.Substring(5) & " AND unit_id = '{0}'", dr("unit_id")))
                        Dim jbooks_id = ""
                        Dim jbooks_debit As Decimal = 0
                        Dim jbooks_debit_based As Decimal = 0
                        If drs.Length > 0 Then
                            jbooks_id = drs(0)("jbooks_id")
                            If jbooks_id.Contains("tmp_") Or jbooks_id = "" Then
                                jbooks_debit = ds.Tables("trans_prepaid").Compute("SUM(debit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                jbooks_debit_based = ds.Tables("trans_ewt").Compute("SUM(debit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                If jbooks_debit <> 0 Or jbooks_debit_based <> 0 Then
                                    Dim dic As New Dictionary(Of String, String)
                                    dic.Add("jbooks_id", "")
                                    dic.Add("trans_id", trans_id)
                                    dic.Add("account_id", account_id)
                                    dic.Add("project_id", project_id)
                                    dic.Add("department_id", department_id)
                                    dic.Add("credit", "0")
                                    dic.Add("credit_based", "0")
                                    dic.Add("debit", jbooks_debit)
                                    dic.Add("debit_based", jbooks_debit_based)
                                    dic.Add("currency_id", dr("currency_id"))
                                    dic.Add("exchange_rate", dr("exchange_rate"))
                                    dic.Add("based_rate", dr("based_rate"))
                                    If My.Settings._enableUnitNo Then
                                        If My.Settings._enableBookUnit Then
                                            dic.Add("book_unit_no_id", dr("unit_id"))
                                        Else
                                            dic.Add("project_unit_no_id", dr("unit_id"))
                                        End If
                                    End If
                                    Dim sql As String = ATGenerateQuery("Insert", "trans_jbooks", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "jbooks_id")
                                    Dim dt As DataTable = Query(sql)
                                    If dt.Rows.Count > 0 Then
                                        lstUnitID.Item(dr("unit_id")) = dt(0)("return_id")
                                    End If
                                End If
                            Else
                                jbooks_debit = ds.Tables("trans_prepaid").Compute("SUM(debit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                jbooks_debit_based = ds.Tables("trans_prepaid").Compute("SUM(debit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                If jbooks_debit <> 0 Or jbooks_debit_based <> 0 Then
                                    Dim dic As New Dictionary(Of String, String)
                                    dic.Add("jbooks_id", jbooks_id)
                                    dic.Add("trans_id", trans_id)
                                    dic.Add("account_id", account_id)
                                    dic.Add("project_id", project_id)
                                    dic.Add("department_id", department_id)
                                    dic.Add("credit", "0")
                                    dic.Add("credit_based", "0")
                                    dic.Add("debit", jbooks_debit)
                                    dic.Add("debit_based", jbooks_debit_based)
                                    dic.Add("currency_id", dr("currency_id"))
                                    dic.Add("exchange_rate", dr("exchange_rate"))
                                    dic.Add("based_rate", dr("based_rate"))
                                    If My.Settings._enableUnitNo Then
                                        If My.Settings._enableBookUnit Then
                                            dic.Add("book_unit_no_id", dr("unit_id"))
                                        Else
                                            dic.Add("project_unit_no_id", dr("unit_id"))
                                        End If
                                    End If
                                    Dim sql As String = ATGenerateQuery("Update", "trans_jbooks", dic, Environment.MachineName, Environment.UserName, main.log_id, jbooks_id, "jbooks_id")
                                    Dim dt As DataTable = Query(sql)
                                    If dt.Rows.Count > 0 Then
                                        lstUnitID.Item(dr("unit_id")) = dt(0)("return_id")
                                    End If
                                End If
                            End If
                        Else
                            jbooks_debit = ds.Tables("trans_prepaid").Compute("SUM(debit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                            jbooks_debit_based = ds.Tables("trans_prepaid").Compute("SUM(debit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                            If jbooks_debit <> 0 Or jbooks_debit_based <> 0 Then
                                Dim dic As New Dictionary(Of String, String)
                                dic.Add("jbooks_id", "")
                                dic.Add("trans_id", trans_id)
                                dic.Add("account_id", account_id)
                                dic.Add("project_id", project_id)
                                dic.Add("department_id", department_id)
                                dic.Add("credit", "0")
                                dic.Add("credit_based", "0")
                                dic.Add("debit", jbooks_debit)
                                dic.Add("debit_based", jbooks_debit_based)
                                dic.Add("currency_id", dr("currency_id"))
                                dic.Add("exchange_rate", dr("exchange_rate"))
                                dic.Add("based_rate", dr("based_rate"))
                                If My.Settings._enableUnitNo Then
                                    If My.Settings._enableBookUnit Then
                                        dic.Add("book_unit_no_id", dr("unit_id"))
                                    Else
                                        dic.Add("project_unit_no_id", dr("unit_id"))
                                    End If
                                End If
                                Dim sql As String = ATGenerateQuery("Insert", "trans_jbooks", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "jbooks_id")
                                Dim dt As DataTable = Query(sql)
                                If dt.Rows.Count > 0 Then
                                    lstUnitID.Item(dr("unit_id")) = dt(0)("return_id")
                                End If
                            End If
                        End If
                    End If
                Next
                For Each dr As DataRow In ds.Tables("trans_prepaid").Rows
                    Dim jbooks_id = dr("jbooks_id")
                    Dim prepaid_id = dr("prepaid_id")
                    Dim prepaid_ref_id = dr("prepaid_ref_id")
                    Dim ref_no = dr("ref_no")
                    Dim currency_id = dr("currency_id")
                    Dim exchange_rate = dr("exchange_rate")
                    Dim based_rate = dr("based_rate")
                    Dim description = dr("description")
                    Dim asset_code = dr("asset_code")
                    Dim historical_rate = dr("historical_rate")
                    Dim quantity = dr("quantity")
                    Dim date_acquired = CDate(dr("date_acquired")).ToString("yyyy-MM-dd")
                    Dim amount = dr("amount")
                    Dim amount_based = dr("amount_based")
                    Dim net_book_value = dr("net_book_value")
                    Dim net_book_value_based = dr("net_book_value_based")
                    Dim useful_life = dr("useful_life")
                    Dim date_start = CDate(dr("date_start")).ToString("yyyy-MM-dd")
                    Dim debit = dr("debit")
                    Dim debit_based = dr("debit_based")
                    Dim unit_id = dr("unit_id")
                    Dim deleted = dr("deleted")
                    If lstUnitID.ContainsKey(unit_id) Then
                        jbooks_id = lstUnitID(unit_id)
                    End If
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("prepaid_id", prepaid_id)
                    dic.Add("jbooks_id", jbooks_id)
                    dic.Add("currency_id", currency_id)
                    dic.Add("exchange_rate", exchange_rate)
                    dic.Add("based_rate", based_rate)
                    dic.Add("description", description)
                    dic.Add("asset_code", asset_code)
                    dic.Add("historical_rate", historical_rate)
                    dic.Add("quantity", quantity)
                    dic.Add("date_acquired", date_acquired)
                    dic.Add("amount", amount)
                    dic.Add("amount_based", amount_based)
                    dic.Add("net_book_value", net_book_value)
                    dic.Add("net_book_value_based", net_book_value_based)
                    dic.Add("useful_life", useful_life)
                    dic.Add("date_start", date_start)
                    dic.Add("debit", debit)
                    dic.Add("debit_based", debit_based)
                    dic.Add("credit", "0")
                    dic.Add("credit_based", "0")
                    If prepaid_id.ToString.Contains("ag-") Or prepaid_id.ToString.Contains("tmp_") Or prepaid_id = "" Then
                        If Not deleted Then
                            Dim sql As String = ATGenerateQuery("Insert", "trans_prepaid", dic, Environment.MachineName, Environment.UserName, main.log_id, "|", "prepaid_id")
                            Dim return_id = Query(sql)
                            prepaid_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("prepaid_ref_id", "")
                            dicDet.Add("prepaid_id", prepaid_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Insert", "trans_prepaid_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, "|", "prepaid_ref_id")
                            Query(sql_ref)
                        End If
                    Else
                        If deleted Then
                            Dim sql As String = ATGenerateQuery("DELETE", "trans_prepaid", Nothing, Environment.MachineName, Environment.UserName, main.log_id, prepaid_id & "|", "prepaid_id")
                            Query(sql)
                        Else
                            Dim sql As String = ATGenerateQuery("UPDATE", "trans_prepaid", dic, Environment.MachineName, Environment.UserName, main.log_id, prepaid_id & "|", "prepaid_id")
                            Query(sql)
                            Dim return_id = Query(sql)
                            prepaid_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("prepaid_ref_id", prepaid_ref_id)
                            dicDet.Add("prepaid_id", prepaid_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Update", "trans_prepaid_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, prepaid_ref_id & "|", "prepaid_ref_id")
                            Query(sql_ref)
                        End If
                    End If
                Next
            Else
                Dim drs = ds.Tables("trans_jbooks").Select(String.Format(filter.Substring(5)))
                Dim jbooks_id = ""
                Dim jbooks_debit As Decimal = 0
                Dim jbooks_debit_based As Decimal = 0
                If drs.Length > 0 Then
                    jbooks_id = drs(0)("jbooks_id")
                    If jbooks_id.Contains("tmp_") Or jbooks_id = "" Then
                        jbooks_debit = ds.Tables("trans_prepaid").Compute("SUM(debit)", String.Format("deleted = False"))
                        jbooks_debit_based = ds.Tables("trans_ewt").Compute("SUM(debit_based)", String.Format("deleted = False"))
                        If jbooks_debit <> 0 Or jbooks_debit_based <> 0 Then
                            Dim dic As New Dictionary(Of String, String)
                            dic.Add("jbooks_id", "")
                            dic.Add("trans_id", trans_id)
                            dic.Add("account_id", account_id)
                            dic.Add("project_id", project_id)
                            dic.Add("department_id", department_id)
                            dic.Add("credit", "0")
                            dic.Add("credit_based", "0")
                            dic.Add("debit", jbooks_debit)
                            dic.Add("debit_based", jbooks_debit_based)
                            dic.Add("currency_id", currency_id)
                            dic.Add("exchange_rate", exchange_rate)
                            dic.Add("based_rate", based_rate)
                            Dim sql As String = ATGenerateQuery("Insert", "trans_jbooks", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "jbooks_id")
                            Dim dt As DataTable = Query(sql)
                            If dt.Rows.Count > 0 Then
                                jbooks_id = dt(0)("return_id")
                            End If
                        End If
                    Else
                        jbooks_debit = ds.Tables("trans_prepaid").Compute("SUM(debit)", String.Format("deleted = False"))
                        jbooks_debit_based = ds.Tables("trans_prepaid").Compute("SUM(debit_based)", String.Format("deleted = False"))
                        If jbooks_debit <> 0 Or jbooks_debit_based <> 0 Then
                            Dim dic As New Dictionary(Of String, String)
                            dic.Add("jbooks_id", jbooks_id)
                            dic.Add("trans_id", trans_id)
                            dic.Add("account_id", account_id)
                            dic.Add("project_id", project_id)
                            dic.Add("department_id", department_id)
                            dic.Add("credit", "0")
                            dic.Add("credit_based", "0")
                            dic.Add("debit", jbooks_debit)
                            dic.Add("debit_based", jbooks_debit_based)
                            dic.Add("currency_id", currency_id)
                            dic.Add("exchange_rate", exchange_rate)
                            dic.Add("based_rate", based_rate)
                            Dim sql As String = ATGenerateQuery("Update", "trans_jbooks", dic, Environment.MachineName, Environment.UserName, main.log_id, jbooks_id, "jbooks_id")
                            Dim dt As DataTable = Query(sql)
                            If dt.Rows.Count > 0 Then
                                jbooks_id = dt(0)("return_id")
                            End If
                        End If
                    End If
                Else
                    jbooks_debit = ds.Tables("trans_prepaid").Compute("SUM(debit)", String.Format("deleted = False"))
                    jbooks_debit_based = ds.Tables("trans_prepaid").Compute("SUM(debit_based)", String.Format("deleted = False"))
                    If jbooks_debit <> 0 Or jbooks_debit_based <> 0 Then
                        Dim dic As New Dictionary(Of String, String)
                        dic.Add("jbooks_id", "")
                        dic.Add("trans_id", trans_id)
                        dic.Add("account_id", account_id)
                        dic.Add("project_id", project_id)
                        dic.Add("department_id", department_id)
                        dic.Add("credit", "0")
                        dic.Add("credit_based", "0")
                        dic.Add("debit", jbooks_debit)
                        dic.Add("debit_based", jbooks_debit_based)
                        dic.Add("currency_id", currency_id)
                        dic.Add("exchange_rate", exchange_rate)
                        dic.Add("based_rate", based_rate)
                        Dim sql As String = ATGenerateQuery("Insert", "trans_jbooks", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "jbooks_id")
                        Dim dt As DataTable = Query(sql)
                        If dt.Rows.Count > 0 Then
                            jbooks_id = dt(0)("return_id")
                        End If
                    End If
                End If
                For Each dr As DataRow In ds.Tables("trans_prepaid").Rows
                    Dim prepaid_id = dr("prepaid_id")
                    Dim ref_prepaid_id = dr("ref_prepaid_id")
                    Dim ref_no = dr("ref_no")
                    Dim currency_id = dr("currency_id")
                    Dim exchange_rate = dr("exchange_rate")
                    Dim based_rate = dr("based_rate")
                    Dim description = dr("description")
                    Dim asset_code = dr("asset_code").ToString
                    Dim historical_rate = dr("historical_rate")
                    Dim quantity = dr("quantity")
                    Dim date_acquired = CDate(dr("date_acquired")).ToString("yyyy-MM-dd")
                    Dim amount = dr("amount")
                    Dim amount_based = dr("amount_based")
                    Dim net_book_value = dr("net_book_value")
                    Dim net_book_value_based = dr("net_book_value_based")
                    Dim useful_life = dr("useful_life")
                    Dim date_start = CDate(dr("date_start")).ToString("yyyy-MM-dd")
                    Dim debit = dr("debit")
                    Dim debit_based = dr("debit_based")
                    Dim unit_id = dr("unit_id")
                    Dim deleted = dr("deleted")
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("prepaid_id", prepaid_id)
                    dic.Add("jbooks_id", jbooks_id)
                    dic.Add("currency_id", currency_id)
                    dic.Add("exchange_rate", exchange_rate)
                    dic.Add("based_rate", based_rate)
                    dic.Add("description", description)
                    dic.Add("asset_code", asset_code)
                    dic.Add("historical_rate", historical_rate)
                    dic.Add("quantity", quantity)
                    dic.Add("date_acquired", date_acquired)
                    dic.Add("amount", amount)
                    dic.Add("amount_based", amount_based)
                    dic.Add("net_book_value", net_book_value)
                    dic.Add("net_book_value_based", net_book_value_based)
                    dic.Add("useful_life", useful_life)
                    dic.Add("date_start", date_start)
                    dic.Add("debit", debit)
                    dic.Add("debit_based", debit_based)
                    dic.Add("credit", "0")
                    dic.Add("credit_based", "0")
                    If prepaid_id.ToString.Contains("ag-") Or prepaid_id.ToString.Contains("tmp_") Or prepaid_id = "" Then
                        If Not deleted Then
                            Dim sql As String = ATGenerateQuery("Insert", "trans_prepaid", dic, Environment.MachineName, Environment.UserName, main.log_id, "|", "prepaid_id")
                            Dim return_id = Query(sql)
                            prepaid_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("prepaid_ref_id", "")
                            dicDet.Add("prepaid_id", prepaid_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Insert", "trans_prepaid_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, "|", "prepaid_ref_id")
                            Query(sql_ref)
                        End If
                    Else
                        If deleted Then
                            Dim sql As String = ATGenerateQuery("DELETE", "trans_prepaid", Nothing, Environment.MachineName, Environment.UserName, main.log_id, prepaid_id & "|", "prepaid_id")
                            Query(sql)
                        Else
                            Dim sql As String = ATGenerateQuery("UPDATE", "trans_prepaid", dic, Environment.MachineName, Environment.UserName, main.log_id, prepaid_id & "|", "prepaid_id")
                            Query(sql)
                            Dim return_id = Query(sql)
                            prepaid_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("prepaid_ref_id", txt_prepaid_ref_id.Text)
                            dicDet.Add("prepaid_id", prepaid_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Update", "trans_prepaid_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, txt_prepaid_ref_id.Text & "|", "prepaid_ref_id")
                            Query(sql_ref)
                        End If
                    End If
                Next
            End If
        End If

    End Sub
End Class