Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class begbal_iv_detail
    Dim dbTable As String = "trans_input_vat"
    Dim ds As New begbal
    Private transmode As String = ""
    Private _jbooks_id As String = "0"
    Private _begbal_date As String = ""
    Dim _currency_id As String = ""
    Dim _exchange_rate As String = ""
    Dim _based_rate As String = ""
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txt_vat_amount.NumberFormat = strNumberFormat
        txt_vat_amount_based.NumberFormat = strNumberFormat
        txt_vat_rate.NumberFormat = strNumberFormat
        txt_gross_amount.NumberFormat = strNumberFormat
        txt_gross_amount_based.NumberFormat = strNumberFormat
        txt_net_amount.NumberFormat = strNumberFormat
        txt_net_amount_based.NumberFormat = strNumberFormat
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
    Public Property begbal_date() As String
        Get
            Return _begbal_date
        End Get
        Set(ByVal value As String)
            _begbal_date = value
        End Set
    End Property
    Public Property MyParent As fsbeg = Nothing
    Public Property trans_id As String = ""
    Public Property book_id As String = ""
    Public Property project_id As String = ""
    Public Property department_id As String = ""
    Public Property account_id As String = ""
    Public Property BookUnitNoID As String = ""
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        If jbooks_id <> "0" And jbooks_id <> "" Then
            Dim sql = String.Format("SELECT a.input_vat_id,a.jbooks_id,a.general_id,a.currency_id,a.exchange_rate " &
                ",a.based_rate,a.offset_type,a.vat_class,a.vat_type,a.vat_rate,a.gross_amount,a.vat_amount " &
                ",a.net_amount,a.debit,a.credit,a.gross_amount_based,a.vat_amount_based,a.net_amount_based " &
                ",a.debit_based,a.credit_amount_based,a.ref_input_vat_id,b.general_name,b.tin " &
                ",CONCAT(b.address1,',',b.address2,',',b.address3,',',b.address4) AS address " &
                ",c.currency_name,d.ref_no,d.input_vat_ref_id " &
                ",IF(a.debit > e.credit,'Partially Paid',IF(a.debit = e.credit,'Fully Paid','')) AS status " &
                ",IF(a.debit > e.credit,e.credit,IF(a.debit = e.credit,a.debit,0)) AS minimum " &
                "FROM trans_input_vat a " &
                "LEFT JOIN {1}.lib_erp_general b ON b.general_id = a.general_id " &
                "LEFT JOIN {1}.lib_erp_currency c ON c.currency_id = a.currency_id " &
                "LEFT JOIN trans_input_vat_ref d ON d.input_vat_id = a.input_vat_id " &
                "LEFT JOIN (" &
                    "SELECT c.ref_input_vat_id AS input_vat_id,SUM(c.debit) AS debit,SUM(c.credit) AS credit " &
                    ",SUM(c.debit_based) AS debit_based,SUM(c.credit_amount_based) AS credit_based " &
                    "FROM trans_header a " &
                    "LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " &
                    "LEFT JOIN trans_input_vat c ON c.jbooks_id = b.jbooks_id " &
                    "WHERE c.ref_input_vat_id IS NOT NULL AND (a.status <> 'C' OR a.status IS NULL) " &
                    "GROUP BY c.ref_input_vat_id " &
                ") e ON e.input_vat_id = a.input_vat_id " &
                "WHERE a.jbooks_id = {0}", jbooks_id, _serverDBFS)
            Dim dt As DataTable = Query(sql)
            ds.Tables(dbTable).Clear()
            For Each row As DataRow In dt.Rows
                ds.Tables(dbTable).ImportRow(row)
            Next
            dgMain.DataSource = ds.Tables(dbTable)
        End If
        Dim tax_dt As DataTable = FsQuery(String.Format("SELECT * FROM lib_acc_input_vat WHERE effectivity_date <= '{0}' ORDER BY effectivity_date DESC LIMIT 1", System.DateTime.Today.ToString("s")))
        txt_vat_rate.DecimalValue = tax_dt.Rows(0).Item("vat_rate")
        Dim currency_sql As String = String.Format("SELECT a.currency_code,a.currency_name FROM lib_erp_currency a WHERE a.currency_id = {0}", currency_id)
        Dim currency_dt As DataTable = FsQuery(currency_sql)
        txt_currency_id.Value = currency_id
        txt_currency_id.Text = currency_dt.Rows(0).Item("currency_name")
        txt_exchange_rate.DecimalValue = exchange_rate
        txt_based_rate.DecimalValue = based_rate
        computeGrid()
    End Sub
    Private Sub begbal_ar_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDecimalPlaces(main.strNumberFormat)
        init_load()
        disable_control(Me)
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = dgMain.DataSource
        bind_control(dgMain, "input_vat_id", dt, Me)
    End Sub
    Private Sub begbal_ar_detail_FormClosed(sender As Object, e As Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DialogResult = DialogResult.OK
        'Me.Close()
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        setRdoValue(txt_vat_type, 1)
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
            If getRdoValue(txt_vat_type) = "1" Then
                txt_gross_amount.Enabled = True
                txt_net_amount.Enabled = False
            Else
                txt_gross_amount.Enabled = False
                txt_net_amount.Enabled = True
            End If
        Else
            MsgBox("No Record Selected")
        End If
    End Sub
    Private Sub computeAmount()
        Dim exchange_rate As Decimal = txt_exchange_rate.DecimalValue
        Dim based_rate As Decimal = txt_based_rate.DecimalValue
        Dim vat_rate As Decimal = txt_vat_rate.DecimalValue
        Dim gross As Decimal = txt_gross_amount.DecimalValue
        Dim net As Decimal = txt_net_amount.DecimalValue
        Dim inclusive = getRdoValue(txt_vat_type)
        Dim vat_amount As Decimal = 0
        If inclusive = "1" Then
            vat_amount = (gross / ((100 + vat_rate) / 100)) * (vat_rate / 100)
            txt_net_amount.DecimalValue = gross - vat_amount
        Else
            vat_amount = net * (vat_rate / 100)
            txt_gross_amount.DecimalValue = net + vat_amount
        End If
        txt_vat_amount_based.DecimalValue = vat_amount * (exchange_rate / based_rate)
        txt_gross_amount_based.DecimalValue = gross * (exchange_rate / based_rate)
        txt_net_amount_based.DecimalValue = net * (exchange_rate / based_rate)
        txt_vat_amount.DecimalValue = vat_amount
    End Sub
    Private Sub computeGrid()
        Dim total_gross As Decimal = 0
        Dim total_net As Decimal = 0
        Dim total_vat As Decimal = 0
        Dim total_debit As Decimal = 0
        Dim total_debit_based As Decimal = 0
        Dim dt As DataTable = dgMain.DataSource
        If dt.Select("deleted = 'False'").Count > 0 Then
            total_gross = dt.Compute("SUM(gross_amount)", "deleted = 'False'")
            total_net = dt.Compute("SUM(net_amount)", "deleted = 'False'")
            total_vat = dt.Compute("SUM(vat_amount)", "deleted = 'False'")
            total_debit = dt.Compute("SUM(debit)", "deleted = 'False'")
            total_debit_based = dt.Compute("SUM(debit_based)", "deleted = 'False'")
        End If
        txt_total_gross.DecimalValue = total_gross
        txt_total_net.DecimalValue = total_net
        txt_total_vat.DecimalValue = total_vat
        txt_total_based.DecimalValue = total_debit_based
        txt_total_amount.DecimalValue = total_debit
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = dgMain.DataSource
        Dim dr = dt.NewRow
        Dim err As Boolean = False
        Dim pk As String = ""
        Dim ref_no = txt_ref_no.Text
        Dim input_vat_id = txt_input_vat_id.Value
        Dim j_books_id = jbooks_id
        Dim general_id = txt_general_id.Value
        Dim general_name = txt_general_id.Text
        Dim general_tin = txt_tin.Text
        Dim general_address = txt_address.Text
        Dim currency_id = txt_currency_id.Value
        Dim currency_name = txt_currency_id.Text
        Dim exchange_rate = txt_exchange_rate.DecimalValue
        Dim based_rate = txt_based_rate.DecimalValue
        Dim vat_type = getRdoValue(txt_vat_type)
        Dim vat_rate = txt_vat_rate.DecimalValue
        Dim vat_amount = txt_vat_amount.DecimalValue
        Dim gross_amount = txt_gross_amount.DecimalValue
        Dim net_amount = txt_net_amount.DecimalValue
        Dim debit = vat_amount
        Dim vat_amount_based = txt_vat_amount_based.DecimalValue
        Dim gross_amount_based = txt_gross_amount_based.DecimalValue
        Dim net_amount_based = txt_net_amount_based.DecimalValue

        dr.Item("input_vat_id") = input_vat_id
        dr.Item("jbooks_id") = j_books_id
        dr.Item("ref_no") = ref_no
        dr.Item("general_id") = general_id
        dr.Item("general_name") = general_name
        dr.Item("tin") = general_tin
        dr.Item("address") = general_address
        dr.Item("currency_id") = currency_id
        dr.Item("currency_name") = currency_name
        dr.Item("exchange_rate") = exchange_rate
        dr.Item("based_rate") = based_rate
        dr.Item("vat_type") = vat_type
        dr.Item("vat_rate") = vat_rate
        dr.Item("vat_amount") = vat_amount
        dr.Item("gross_amount") = gross_amount
        dr.Item("net_amount") = net_amount
        dr.Item("debit") = debit
        dr.Item("debit_based") = debit * (exchange_rate / based_rate)
        dr.Item("vat_amount_based") = vat_amount_based
        dr.Item("gross_amount_based") = gross_amount_based
        dr.Item("net_amount_based") = net_amount_based
        dr.Item("ref_input_vat_id") = Nothing
        dr.Item("unit_id") = txt_unit_id.Value
        dr.Item("unit_name") = txt_unit_id.Text

        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            If transmode = "insert" Then
                If DataExist(dgMain, {"input_vat_id", txt_input_vat_id.Value}, {"ref_no"}, {txt_ref_no.Text}) Then
                    MsgBox("Input VAT already exist")
                    err = True
                Else
                    dr.Item("input_vat_id") = "ag-" & dt.Rows.Count
                    dt.Rows.Add(dr)
                    pk = dr.Item("input_vat_id")
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"input_vat_id", txt_input_vat_id.Value}, {"ref_no"}, {txt_ref_no.Text}, False) Then
                    MsgBox("Input VAT already exist")
                    err = True
                Else
                    Dim id = dgMain.SelectedRows(0).Cells("input_vat_id").Value.ToString
                    Dim row As DataRow = dt.Select(String.Format("input_vat_id = '{0}'", id))(0)
                    row.Item("ref_no") = ref_no
                    row.Item("general_id") = general_id
                    row.Item("general_name") = general_name
                    row.Item("tin") = general_tin
                    row.Item("address") = general_address
                    row.Item("currency_id") = currency_id
                    row.Item("currency_name") = currency_name
                    row.Item("exchange_rate") = exchange_rate
                    row.Item("based_rate") = based_rate
                    row.Item("vat_type") = vat_type
                    row.Item("vat_rate") = vat_rate
                    row.Item("vat_amount") = vat_amount
                    row.Item("gross_amount") = gross_amount
                    row.Item("net_amount") = net_amount
                    row.Item("debit") = debit
                    row.Item("debit_based") = debit * (exchange_rate / based_rate)
                    row.Item("vat_amount_based") = vat_amount_based
                    row.Item("gross_amount_based") = gross_amount_based
                    row.Item("net_amount_based") = net_amount_based
                    row.Item("ref_input_vat_id") = Nothing
                    row.Item("unit_id") = txt_unit_id.Value
                    row.Item("unit_name") = txt_unit_id.Text
                    pk = id
                End If
            ElseIf transmode = "remove" Then
            End If

            If Not err Then
                computeGrid()
                transmode = ""
                disable_control(Me)
                btnInsert.Focus()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("input_vat_id").Value.ToString = pk Then
                        row.Selected = True
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)
        Dim dt As DataTable = dgMain.DataSource
        bind_control(dgMain, "input_vat_id", dt, Me)
    End Sub
    Private Sub txt_genref_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim dt As DataTable = FsQuery("SELECT *,CONCAT(address1,',',address2,',',address3,',',address4) AS address FROM lib_erp_general ORDER BY FIELD(category_id,1,2),general_code ASC ")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("general_name like '{0}'", txt_general_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "general_code,general_name", "100,200")
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
                txt_address.Text = dr("address").ToString
                txt_tin.Text = dr("tin")
            End If
        End If
    End Sub
    Private Sub txt_gross_Leave(sender As Object, e As EventArgs) Handles txt_gross_amount.Leave
        computeAmount()
        If transmode = "update" Then
            Dim selectedRows = dgMain.SelectedRows
            If selectedRows.Count > 0 Then
                Dim selectedRow = selectedRows(0)
                If selectedRow.Cells("minimum").Value > txt_vat_amount.DecimalValue Then
                    MsgBox("Invalid amount.")
                    txt_gross_amount.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub txt_currency_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
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
                Dim sql As String = String.Format("SELECT * FROM lib_erp_currency_rate WHERE currency_id = {0} AND effectivitydate <= '{1}' ORDER BY effectivitydate DESC LIMIT 1", txt_currency_id.Value, begbal_date)
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
    Private Sub Rdo_button1_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button1.CheckedChanged
        Dim vat_type = getRdoValue(txt_vat_type)
        If txt_vat_type.Enabled Then
            If vat_type = "1" Then
                txt_gross_amount.Enabled = True
                txt_net_amount.Enabled = False
            Else
                txt_gross_amount.Enabled = False
                txt_net_amount.Enabled = True
            End If
        End If
    End Sub
    Private Sub txt_net_amount_Leave(sender As Object, e As EventArgs) Handles txt_net_amount.Leave
        computeAmount()
        If transmode = "update" Then
            Dim selectedRows = dgMain.SelectedRows
            If selectedRows.Count > 0 Then
                Dim selectedRow = selectedRows(0)
                If selectedRow.Cells("minimum").Value > txt_vat_amount.DecimalValue Then
                    MsgBox("Invalid amount.")
                    txt_net_amount.Focus()
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
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim selectedIDS = getCheckedGrid("input_vat_id", "ref_no", "sel", dgMain, , True, , True)
        If selectedIDS.Length > 0 Then
            For Each id As String In selectedIDS
                Dim selectedRows = ds.Tables(dbTable).Select(String.Format("input_vat_id = '{0}'", id))
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
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        Dim id As String = txt_input_vat_id.Value.ToString
        If id <> "" Then
            Try
                Dim dt As DataTable = ds.Tables("begbal_detail")
                dt.Clear()
                'ref_no,trans_date,book_code,account_code,debit,credit
                Dim sql = String.Format("SELECT a.trans_no AS ref_no,a.trans_date,d.book_code,e.account_code,e.account_name,b.debit,b.credit " & _
                    "FROM trans_header a " & _
                    "LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
                    "LEFT JOIN trans_input_vat c ON c.jbooks_id = b.jbooks_id " & _
                    "LEFT JOIN {1}.lib_erp_book d ON d.book_id = a.book_id " & _
                    "LEFT JOIN {1}.lib_erp_chart e ON e.account_id = b.account_id " & _
                    "WHERE c.ref_input_vat_id = '{0}' AND (a.status <> 'C' OR a.status IS NULL) ", id, _serverDBFS)
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

    Private Sub begbal_iv_detail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ds.Tables("trans_jbooks").Clear()
        If ds.Tables("trans_input_vat").Rows.Count = 0 Then
            ds.Tables("trans_input_vat").Clear()
            Dim dt_iv As DataTable = dgMain.DataSource
            For Each dr As DataRow In dt_iv.Rows
                ds.Tables("trans_input_vat").ImportRow(dr)
            Next
        End If
        For Each dr As DataRow In MyParent.ds.Tables("trans_jbooks").Rows
            ds.Tables("trans_jbooks").ImportRow(dr)
        Next
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
        If ds.Tables("trans_jbooks").Rows.Count > 0 Then
            If My.Settings._enableUnitNo Then
                Dim lstUnitID As New Dictionary(Of String, String)
                For Each dr As DataRow In ds.Tables("trans_input_vat").Rows
                    If Not lstUnitID.ContainsKey(dr("unit_id")) Then
                        lstUnitID.Add(dr("unit_id"), "")
                        If dr("unit_id").ToString <> "" Then
                            filter &= String.Format(" AND unit_id = '{0}'", dr("unit_id"))
                        End If
                        Dim drs = ds.Tables("trans_jbooks").Select(filter.Substring(5))
                        Dim jbooks_id = ""
                        Dim jbooks_debit As Decimal = 0
                        Dim jbooks_debit_based As Decimal = 0
                        If drs.Length > 0 Then
                            jbooks_id = drs(0)("jbooks_id")
                            If jbooks_id.Contains("tmp_") Or jbooks_id = "" Then
                                jbooks_debit = ds.Tables("trans_input_vat").Compute("SUM(debit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                jbooks_debit_based = ds.Tables("trans_input_vat").Compute("SUM(debit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
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
                                jbooks_debit = ds.Tables("trans_input_vat").Compute("SUM(debit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                jbooks_debit_based = ds.Tables("trans_input_vat").Compute("SUM(debit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
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
                            jbooks_debit = ds.Tables("trans_input_vat").Compute("SUM(debit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                            jbooks_debit_based = ds.Tables("trans_input_vat").Compute("SUM(debit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))

                            If jbooks_debit <> 0 Or jbooks_debit_based <> 0 Then
                                Dim dic As New Dictionary(Of String, String)
                                dic.Add("jbooks_id", "")
                                dic.Add("trans_id", trans_id)
                                dic.Add("account_id", account_id)
                                dic.Add("project_id", project_id)
                                dic.Add("department_id", department_id)
                                dic.Add("debit", jbooks_debit)
                                dic.Add("debit_based", jbooks_debit_based)
                                dic.Add("credit", "0")
                                dic.Add("credit_based", "0")
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
                For Each dr As DataRow In ds.Tables("trans_input_vat").Rows
                    Dim jbooks_id = dr("jbooks_id")
                    Dim input_vat_id = dr("input_vat_id")
                    Dim input_vat_ref_id = dr("input_vat_ref_id")
                    Dim ref_no = dr("ref_no")
                    Dim currency_id = dr("currency_id")
                    Dim exchange_rate = dr("exchange_rate")
                    Dim based_rate = dr("based_rate")
                    Dim general_id = dr("general_id")
                    Dim vat_type = dr("vat_type")
                    Dim vat_rate = dr("vat_rate")
                    Dim vat_amount = dr("vat_amount")
                    Dim gross_amount = dr("gross_amount")
                    Dim net_amount = dr("net_amount")
                    Dim debit = dr("debit")
                    Dim debit_based = dr("debit_based")
                    Dim vat_amount_based = dr("vat_amount_based")
                    Dim gross_amount_based = dr("gross_amount_based")
                    Dim net_amount_based = dr("net_amount_based")
                    Dim unit_id = dr("unit_id")
                    Dim deleted = dr("deleted")
                    If lstUnitID.ContainsKey(unit_id) Then
                        jbooks_id = lstUnitID(unit_id)
                    End If
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("input_vat_id", input_vat_id)
                    dic.Add("jbooks_id", jbooks_id)
                    dic.Add("currency_id", currency_id)
                    dic.Add("exchange_rate", exchange_rate)
                    dic.Add("based_rate", based_rate)
                    dic.Add("general_id", general_id)
                    dic.Add("vat_type", vat_type)
                    dic.Add("vat_amount", vat_amount)
                    dic.Add("gross_amount", gross_amount)
                    dic.Add("net_amount", net_amount)
                    dic.Add("debit", debit)
                    dic.Add("debit_based", debit_based)
                    dic.Add("credit", 0)
                    dic.Add("credit_amount_based", 0)
                    dic.Add("vat_amount_based", vat_amount_based)
                    dic.Add("gross_amount_based", vat_amount_based)
                    dic.Add("net_amount_based", vat_amount_based)
                    If input_vat_id.ToString.Contains("ag-") Or input_vat_id.ToString.Contains("tmp_") Or input_vat_id = "" Then
                        If Not deleted Then
                            Dim sql As String = ATGenerateQuery("Insert", "trans_input_vat", dic, Environment.MachineName, Environment.UserName, main.log_id, "|", "input_vat_id")
                            Dim return_id = Query(sql)
                            input_vat_id = return_id.Rows(0)("return_id").ToString
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("input_vat_ref_id", "")
                            dicDet.Add("input_vat_id", input_vat_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Insert", "trans_input_vat_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, "|", "input_vat_ref_id")
                            Query(sql)
                        End If
                    Else
                        If deleted Then
                            Dim sql As String = ATGenerateQuery("DELETE", "trans_input_vat", Nothing, Environment.MachineName, Environment.UserName, main.log_id, input_vat_id & "|", "input_vat_id")
                            Query(sql)
                        Else
                            Dim sql As String = ATGenerateQuery("UPDATE", "trans_input_vat", dic, Environment.MachineName, Environment.UserName, main.log_id, input_vat_id & "|", "input_vat_id")
                            Query(sql)
                            Dim return_id = Query(sql)
                            input_vat_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("input_vat_ref_id", input_vat_ref_id.ToString)
                            dicDet.Add("input_vat_id", input_vat_id)
                            dicDet.Add("ref_no", ref_no.ToString)
                            Dim sql_ref As String = ATGenerateQuery("Update", "trans_input_vat_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, input_vat_ref_id & "|", "input_vat_ref_id")
                            Query(sql)
                        End If
                    End If
                Next
            Else
                Dim jbooks_id As String = ""
                Dim drs = ds.Tables("trans_jbooks").Select(filter.Substring(5))
                Dim jbooks_debit As Decimal = 0
                Dim jbooks_debit_based As Decimal = 0
                If drs.Length > 0 Then
                    jbooks_id = drs(0)("jbooks_id")
                    If jbooks_id.Contains("tmp_") Or jbooks_id = "" Then
                        jbooks_debit = ds.Tables("trans_input_vat").Compute("SUM(debit)", String.Format("deleted = False"))
                        jbooks_debit_based = ds.Tables("trans_input_vat").Compute("SUM(debit_based)", String.Format("deleted = False"))
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
                        Try
                            jbooks_debit = ds.Tables("trans_input_vat").Compute("SUM(debit)", String.Format("deleted = False"))
                            jbooks_debit_based = ds.Tables("trans_input_vat").Compute("SUM(debit_based)", String.Format("deleted = False"))
                        Catch ex As Exception
                            jbooks_debit = 0
                            jbooks_debit_based = 0
                        End Try
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
                        Else
                            'Dim sql As String = ATGenerateQuery("Delete", "trans_jbooks", Nothing, Environment.MachineName, Environment.UserName, main.log_id, jbooks_id, "jbooks_id")
                            'Dim dt = Query(sql)
                        End If
                    End If
                Else
                    jbooks_debit = ds.Tables("trans_input_vat").Compute("SUM(debit)", String.Format("deleted = False"))
                    jbooks_debit_based = ds.Tables("trans_input_vat").Compute("SUM(debit_based)", String.Format("deleted = False"))

                    If jbooks_debit <> 0 Or jbooks_debit_based <> 0 Then
                        Dim dic As New Dictionary(Of String, String)
                        dic.Add("jbooks_id", "")
                        dic.Add("trans_id", trans_id)
                        dic.Add("account_id", account_id)
                        dic.Add("project_id", project_id)
                        dic.Add("department_id", department_id)
                        dic.Add("debit", jbooks_debit)
                        dic.Add("debit_based", jbooks_debit_based)
                        dic.Add("credit", "0")
                        dic.Add("credit_based", "0")
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
                For Each dr As DataRow In ds.Tables("trans_input_vat").Rows
                    Dim input_vat_id = dr("input_vat_id")
                    Dim input_vat_ref_id = dr("input_vat_ref_id")
                    Dim ref_no = dr("ref_no")
                    Dim currency_id = dr("currency_id")
                    Dim exchange_rate = dr("exchange_rate")
                    Dim based_rate = dr("based_rate")
                    Dim general_id = dr("general_id")
                    Dim vat_type = dr("vat_type")
                    Dim vat_rate = dr("vat_rate")
                    Dim vat_amount = dr("vat_amount")
                    Dim gross_amount = dr("gross_amount")
                    Dim net_amount = dr("net_amount")
                    Dim debit = dr("debit")
                    Dim debit_based = dr("debit_based")
                    Dim vat_amount_based = dr("vat_amount_based")
                    Dim gross_amount_based = dr("gross_amount_based")
                    Dim net_amount_based = dr("net_amount_based")
                    Dim deleted = dr("deleted")
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("input_vat_id", input_vat_id)
                    dic.Add("jbooks_id", jbooks_id)
                    dic.Add("currency_id", currency_id)
                    dic.Add("exchange_rate", exchange_rate)
                    dic.Add("based_rate", based_rate)
                    dic.Add("general_id", general_id)
                    dic.Add("vat_type", vat_type)
                    dic.Add("vat_amount", vat_amount)
                    dic.Add("gross_amount", gross_amount)
                    dic.Add("net_amount", net_amount)
                    dic.Add("debit", debit)
                    dic.Add("debit_based", debit_based)
                    dic.Add("credit", 0)
                    dic.Add("credit_amount_based", 0)
                    dic.Add("vat_amount_based", vat_amount_based)
                    dic.Add("gross_amount_based", vat_amount_based)
                    dic.Add("net_amount_based", vat_amount_based)
                    If input_vat_id.ToString.Contains("ag-") Or input_vat_id.ToString.Contains("tmp_") Or input_vat_id = "" Then
                        If Not deleted Then
                            Dim sql As String = ATGenerateQuery("Insert", "trans_input_vat", dic, Environment.MachineName, Environment.UserName, main.log_id, "|", "input_vat_id")
                            Dim return_id = Query(sql)
                            input_vat_id = return_id.Rows(0)("return_id").ToString
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("input_vat_ref_id", "")
                            dicDet.Add("input_vat_id", input_vat_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Insert", "trans_input_vat_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, "|", "input_vat_ref_id")
                            Query(sql_ref)
                        End If
                    Else
                        If deleted Then
                            Dim sql As String = ATGenerateQuery("DELETE", "trans_input_vat", Nothing, Environment.MachineName, Environment.UserName, main.log_id, input_vat_id & "|", "input_vat_id")
                            Query(sql)
                        Else
                            Dim sql As String = ATGenerateQuery("UPDATE", "trans_input_vat", dic, Environment.MachineName, Environment.UserName, main.log_id, input_vat_id & "|", "input_vat_id")
                            Query(sql)
                            Dim return_id = Query(sql)
                            input_vat_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("input_vat_ref_id", input_vat_ref_id.ToString)
                            dicDet.Add("input_vat_id", input_vat_id)
                            dicDet.Add("ref_no", ref_no.ToString)
                            Dim sql_ref As String = ATGenerateQuery("Update", "trans_input_vat_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, input_vat_ref_id & "|", "input_vat_ref_id")
                            Query(sql_ref)
                        End If
                    End If
                Next
            End If
        End If
    End Sub
End Class