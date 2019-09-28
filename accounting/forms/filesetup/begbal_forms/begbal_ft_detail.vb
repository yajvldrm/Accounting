Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class begbal_ft_detail
    Dim dbTable As String = "trans_final_tax"
    Dim ds As New begbal
    Private transmode As String = ""
    Private _jbooks_id As String = "0"
    Private _begbal_date As String = ""
    Dim _currency_id As String = ""
    Dim _exchange_rate As String = ""
    Dim _based_rate As String = ""
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txt_amount.NumberFormat = strNumberFormat
        txt_tax_rate.NumberFormat = strNumberFormat
        txt_tax_amount.NumberFormat = strNumberFormat
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
            Dim sql = String.Format("SELECT a.final_tax_id,a.jbooks_id,a.general_id,a.currency_id,a.exchange_rate " &
                ",a.based_rate,a.fs_final_tax_id,a.offset_type,a.tax_rate,a.amount,a.tax_amount,a.debit,a.credit " &
                ",a.amount_based,a.tax_amount_based,a.debit_based,a.credit_based,a.ref_final_tax_id,b.general_name " &
                ",c.currency_name,d.final_tax_code,e.final_tax_ref_id,e.ref_no " &
                ",IF(a.credit > f.debit,'Partially Paid',IF(a.credit = f.debit,'Fully Paid','')) AS status " &
                ",IF(a.credit > f.debit,f.debit,IF(a.credit = f.debit,a.credit,0)) AS minimum " &
                "FROM trans_final_tax a " &
                "LEFT JOIN {1}.lib_erp_general b ON b.general_id = a.general_id " &
                "LEFT JOIN {1}.lib_erp_currency c ON c.currency_id = a.currency_id " &
                "LEFT JOIN {1}.lib_acc_final_tax d ON d.final_tax_id = a.fs_final_tax_id " &
                "LEFT JOIN trans_final_tax_ref e ON e.final_tax_id = a.final_tax_id " &
                "LEFT JOIN ( " &
                    "SELECT c.ref_final_tax_id AS final_tax_id,SUM(c.debit) AS debit,SUM(c.credit) AS credit " &
                    ",SUM(c.debit_based) AS debit_based,SUM(c.credit_based) AS credit_based " &
                    "FROM trans_header a " &
                    "LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " &
                    "LEFT JOIN trans_final_tax c ON c.jbooks_id = b.jbooks_id " &
                    "WHERE c.ref_final_tax_id IS NOT NULL AND (a.status <> 'C' OR a.status IS NULL) " &
                    "GROUP BY c.ref_final_tax_id " &
                ") f ON f.final_tax_id = a.final_tax_id " &
                "WHERE a.jbooks_id = {0}", jbooks_id, _serverDBFS)
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
        computeGrid()
    End Sub
    Private Sub begbal_ft_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDecimalPlaces(main.strNumberFormat)
        init_load()
        disable_control(Me)
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = dgMain.DataSource
        bind_control(dgMain, "final_tax_id", dt, Me)
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        enable_control(Me)
        clear_control(Me)
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("status").Value <> "" Then
                txt_general_id.Enabled = False
                txt_fs_final_tax_id.Enabled = False
            End If
        Else
            MsgBox("No record selected.")
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = dgMain.DataSource
        Dim dr = dt.NewRow
        Dim err As Boolean = False
        Dim pk As String = ""
        Dim final_tax_id = txt_final_tax_id.Value
        Dim ref_no = txt_ref_no.Text
        Dim currency_id = txt_currency_id.Value
        Dim currency_name = txt_currency_id.Text
        Dim exchange_rate = txt_exchange_rate.DecimalValue
        Dim based_rate = txt_based_rate.DecimalValue
        Dim general_id = txt_general_id.Value
        Dim general_name = txt_general_id.Text
        Dim fs_final_tax_id = txt_fs_final_tax_id.Value
        Dim final_tax_code = txt_fs_final_tax_id.Text
        Dim tax_rate = txt_tax_rate.DecimalValue
        Dim amount = txt_amount.DecimalValue
        Dim tax_amount = txt_tax_amount.DecimalValue
        Dim credit = tax_amount
        Dim credit_based = tax_amount * (exchange_rate / based_rate)

        dr.Item("final_tax_id") = final_tax_id
        dr.Item("ref_no") = ref_no
        dr.Item("currency_id") = currency_id
        dr.Item("currency_name") = currency_name
        dr.Item("exchange_rate") = exchange_rate
        dr.Item("based_rate") = based_rate
        dr.Item("general_id") = general_id
        dr.Item("general_name") = general_name
        dr.Item("fs_final_tax_id") = fs_final_tax_id
        dr.Item("final_tax_code") = final_tax_code
        dr.Item("tax_rate") = tax_rate
        dr.Item("amount") = amount
        dr.Item("tax_amount") = tax_amount
        dr.Item("amount_based") = amount * (exchange_rate / based_rate)
        dr.Item("tax_amount_based") = tax_amount * (exchange_rate / based_rate)
        dr.Item("credit") = credit
        dr.Item("credit_based") = credit_based
        dr.Item("unit_id") = txt_unit_id.Value
        dr.Item("unit_name") = txt_unit_id.Text

        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            If transmode = "insert" Then
                If DataExist(dgMain, {"final_tax_id", txt_final_tax_id.Value}, {"ref_no"}, {txt_ref_no.Text}) Then
                    MsgBox("Final Tax already exist")
                    err = True
                Else
                    dr.Item("final_tax_id") = "ag-" & dt.Rows.Count
                    dt.Rows.Add(dr)
                    pk = dr.Item("final_tax_id")
                End If
            ElseIf transmode = "update" Then
                If DataExist(dgMain, {"final_tax_id", txt_final_tax_id.Value}, {"ref_no"}, {txt_ref_no.Text}, False) Then
                    MsgBox("Final Tax already exist")
                    err = True
                Else
                    Dim id = dgMain.SelectedRows(0).Cells("final_tax_id").Value.ToString
                    Dim row As DataRow = dt.Select(String.Format("final_tax_id = '{0}'", id))(0)
                    row.Item("ref_no") = ref_no
                    row.Item("currency_id") = currency_id
                    row.Item("currency_name") = currency_name
                    row.Item("exchange_rate") = exchange_rate
                    row.Item("based_rate") = based_rate
                    row.Item("general_id") = general_id
                    row.Item("general_name") = general_name
                    row.Item("fs_final_tax_id") = fs_final_tax_id
                    row.Item("final_tax_code") = final_tax_code
                    row.Item("tax_rate") = tax_rate
                    row.Item("amount") = amount
                    row.Item("tax_amount") = tax_amount
                    row.Item("amount_based") = amount * (exchange_rate / based_rate)
                    row.Item("tax_amount_based") = tax_amount * (exchange_rate / based_rate)
                    row.Item("credit") = credit
                    row.Item("credit_based") = credit_based
                    row.Item("unit_id") = txt_unit_id.Value
                    row.Item("unit_name") = txt_unit_id.Text
                    pk = id
                End If
            End If
            loadDTToDG(dgMain, dt)
            If Not err Then
                computeGrid()
                transmode = ""
                disable_control(Me)
                btnInsert.Focus()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("final_tax_id").Value.ToString = pk Then
                        row.Selected = True
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)
        Dim dt As DataTable = dgMain.DataSource
        bind_control(dgMain, "final_tax_id", dt, Me)
    End Sub
    Private Sub computeGrid()
        Dim total_credit As Decimal = 0
        Dim total_credit_based As Decimal = 0
        Dim dt As DataTable = dgMain.DataSource
        If dt.Select("deleted = 'False'").Count > 0 Then
            total_credit = dt.Compute("SUM(credit)", "deleted = 'False'")
            total_credit_based = dt.Compute("SUM(credit_based)", "deleted = 'False'")
        End If
        txt_total_amount.DecimalValue = total_credit
        txt_total_based.DecimalValue = total_credit_based
    End Sub
    Private Sub begbal_ft_detail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DialogResult = DialogResult.OK
        'Me.Close()
    End Sub
    Private Sub txt_genref_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_general ORDER BY FIELD(category_id,1,2) ASC,general_code ASC ")
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
                txt_general_id.Text = dr("general_code")
                txt_general_name.Text = dr("general_name")
            End If
        End If
    End Sub
    Private Sub txt_ewt_code_Leave(sender As Object, e As EventArgs) Handles txt_fs_final_tax_id.Leave
        Dim dt As DataTable = FsQuery(String.Format("SELECT b.*,b.final_tax_id AS fs_final_tax_id FROM lib_erp_general_final_tax a LEFT JOIN lib_acc_final_tax b ON b.final_tax_id = a.final_tax_id WHERE a.general_id = {0}", txt_general_id.Value))
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("final_tax_code like '{0}'", txt_fs_final_tax_id.Text))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "final_tax_code,final_tax_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_fs_final_tax_id.RowData = dr
                txt_fs_final_tax_id.Value = dr("fs_final_tax_id")
                txt_fs_final_tax_id.Text = dr("final_tax_code")
                txt_tax_rate.DecimalValue = dr("final_tax_rate")
            End If
        End If
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
    Private Sub txt_amount_Leave(sender As Object, e As EventArgs) Handles txt_amount.Leave
        Dim tax_rate = txt_tax_rate.DecimalValue
        Dim amount = txt_amount.DecimalValue
        txt_tax_amount.DecimalValue = amount * (tax_rate / 100)
        If transmode = "update" Then
            Dim selectedRows = dgMain.SelectedRows
            If selectedRows.Count > 0 Then
                Dim selectedRow = selectedRows(0)
                If selectedRow.Cells("minimum").Value > txt_amount.DecimalValue Then
                    MsgBox("Invalid amount.")
                    txt_tax_amount.Focus()
                End If
            End If
        End If
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
        Dim selectedIDS = getCheckedGrid("final_tax_id", "ref_no", "sel", dgMain, , True, , True)
        If selectedIDS.Length > 0 Then
            For Each id As String In selectedIDS
                Dim selectedRows = ds.Tables(dbTable).Select(String.Format("final_tax_id = '{0}'", id))
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
        Dim id As String = txt_final_tax_id.Value.ToString
        If id <> "" Then
            Try
                Dim dt As DataTable = ds.Tables("begbal_detail")
                dt.Clear()
                'ref_no,trans_date,book_code,account_code,debit,credit
                Dim sql = String.Format("SELECT a.trans_no AS ref_no,a.trans_date,d.book_code,e.account_code,e.account_name,b.debit,b.credit " & _
                    "FROM trans_header a " & _
                    "LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
                    "LEFT JOIN trans_final_tax c ON c.jbooks_id = b.jbooks_id " & _
                    "LEFT JOIN {1}.lib_erp_book d ON d.book_id = a.book_id " & _
                    "LEFT JOIN {1}.lib_erp_chart e ON e.account_id = b.account_id " & _
                    "WHERE c.ref_final_tax_id = '{0}' AND (a.status <> 'C' OR a.status IS NULL)", id, _serverDBFS)
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

    Private Sub begbal_ft_detail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ds.Tables("trans_jbooks").Clear()
        For Each dr As DataRow In MyParent.ds.Tables("trans_jbooks").Rows
            ds.Tables("trans_jbooks").ImportRow(dr)
        Next
        Dim lstUnitID As New Dictionary(Of String, String)
        Dim filter As String = ""
        If project_id <> "" Then
            filter &= String.Format("AND project_id = '{0}'", project_id)
        End If
        If department_id <> "" Then
            filter &= String.Format("AND department_id = '{0}'", department_id)
        End If
        If account_id <> "" Then
            filter &= String.Format("AND account_id = '{0}'", account_id)
        End If
        If ds.Tables("trans_final_tax").Rows.Count = 0 Then
            ds.Tables("trans_final_tax").Clear()
            Dim dt_iv As DataTable = dgMain.DataSource
            For Each dr As DataRow In dt_iv.Rows
                ds.Tables("trans_final_tax").ImportRow(dr)
            Next
        End If
        If ds.Tables("trans_final_tax").Rows.Count > 0 Then
            If My.Settings._enableUnitNo Then
                For Each dr As DataRow In ds.Tables("trans_final_tax").Rows
                    If Not lstUnitID.ContainsKey(dr("unit_id")) Then
                        lstUnitID.Add(dr("unit_id"), "")
                        Dim drs = ds.Tables("trans_jbooks").Select(String.Format(filter.Substring(4) & " AND unit_id = '{0}'", dr("unit_id")))
                        Dim jbooks_id = ""
                        Dim jbooks_credit As Decimal = 0
                        Dim jbooks_credit_based As Decimal = 0
                        If drs.Length > 0 Then
                            jbooks_id = drs(0)("jbooks_id")
                            If jbooks_id.Contains("tmp_") Or jbooks_id = "" Then
                                jbooks_credit = ds.Tables("trans_final_tax").Compute("SUM(credit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                jbooks_credit_based = ds.Tables("trans_final_tax").Compute("SUM(credit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                If jbooks_credit <> 0 Or jbooks_credit_based <> 0 Then
                                    Dim dic As New Dictionary(Of String, String)
                                    dic.Add("jbooks_id", "")
                                    dic.Add("trans_id", trans_id)
                                    dic.Add("account_id", account_id)
                                    dic.Add("project_id", project_id)
                                    dic.Add("department_id", department_id)
                                    dic.Add("debit", "0")
                                    dic.Add("debit_based", "0")
                                    dic.Add("credit", jbooks_credit)
                                    dic.Add("credit_based", jbooks_credit_based)
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
                                jbooks_credit = ds.Tables("trans_final_tax").Compute("SUM(credit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                jbooks_credit_based = ds.Tables("trans_final_tax").Compute("SUM(credit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                                If jbooks_credit <> 0 Or jbooks_credit_based <> 0 Then
                                    Dim dic As New Dictionary(Of String, String)
                                    dic.Add("jbooks_id", jbooks_id)
                                    dic.Add("trans_id", trans_id)
                                    dic.Add("account_id", account_id)
                                    dic.Add("project_id", project_id)
                                    dic.Add("department_id", department_id)
                                    dic.Add("debit", "0")
                                    dic.Add("debit_based", "0")
                                    dic.Add("credit", jbooks_credit)
                                    dic.Add("credit_based", jbooks_credit_based)
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
                            jbooks_credit = ds.Tables("trans_final_tax").Compute("SUM(credit)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                            jbooks_credit_based = ds.Tables("trans_final_tax").Compute("SUM(credit_based)", String.Format("unit_id = '{0}' AND deleted = False", dr("unit_id")))
                            If jbooks_credit <> 0 Or jbooks_credit_based <> 0 Then
                                Dim dic As New Dictionary(Of String, String)
                                dic.Add("jbooks_id", "")
                                dic.Add("trans_id", trans_id)
                                dic.Add("account_id", account_id)
                                dic.Add("project_id", project_id)
                                dic.Add("department_id", department_id)
                                dic.Add("debit", "0")
                                dic.Add("debit_based", "0")
                                dic.Add("credit", jbooks_credit)
                                dic.Add("credit_based", jbooks_credit_based)
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
                For Each dr As DataRow In ds.Tables("trans_final_tax").Rows
                    Dim jbooks_id = dr("jbooks_id")
                    Dim final_tax_id = dr("final_tax_id")
                    Dim final_tax_ref_id = dr("final_tax_ref_id")
                    Dim ref_no = dr("ref_no")
                    Dim currency_id = dr("currency_id")
                    Dim exchange_rate = dr("exchange_rate")
                    Dim based_rate = dr("based_rate")
                    Dim general_id = dr("general_id")
                    Dim fs_final_tax_id = dr("fs_final_tax_id")
                    Dim tax_rate = dr("tax_rate")
                    Dim amount = dr("amount")
                    Dim tax_amount = dr("tax_amount")
                    Dim amount_based = dr("amount_based")
                    Dim tax_amount_based = dr("tax_amount_based")
                    Dim credit = dr("credit")
                    Dim credit_based = dr("credit_based")
                    Dim unit_id = dr("unit_id")
                    Dim deleted = dr("deleted")
                    If lstUnitID.ContainsKey(unit_id) Then
                        jbooks_id = lstUnitID(unit_id)
                    End If
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("final_tax_id", final_tax_id)
                    dic.Add("jbooks_id", jbooks_id)
                    dic.Add("currency_id", currency_id)
                    dic.Add("exchange_rate", exchange_rate)
                    dic.Add("based_rate", based_rate)
                    dic.Add("general_id", general_id)
                    dic.Add("fs_final_tax_id", fs_final_tax_id)
                    dic.Add("tax_rate", tax_rate)
                    dic.Add("amount", amount)
                    dic.Add("tax_amount", tax_amount)
                    dic.Add("amount_based", amount_based)
                    dic.Add("tax_amount_based", tax_amount_based)
                    dic.Add("credit", credit)
                    dic.Add("credit_based", credit_based)
                    dic.Add("debit", 0)
                    dic.Add("debit_based", 0)
                    If final_tax_id.ToString.Contains("ag-") Or final_tax_id.ToString.Contains("tmp_") Or final_tax_id = "" Then
                        If Not deleted Then
                            Dim sql As String = ATGenerateQuery("Insert", "trans_final_tax", dic, Environment.MachineName, Environment.UserName, main.log_id, "|", "final_tax_id")
                            Dim return_id = Query(sql)
                            final_tax_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("final_tax_ref_id", "")
                            dicDet.Add("final_tax_id", final_tax_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Insert", "trans_final_tax_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, "|", "final_tax_ref_id")
                            Query(sql_ref)
                        End If
                    Else
                        If deleted Then
                            Dim sql As String = ATGenerateQuery("DELETE", "trans_final_tax", Nothing, Environment.MachineName, Environment.UserName, main.log_id, final_tax_id & "|", "final_tax_id")
                            Query(sql)
                        Else
                            Dim sql As String = ATGenerateQuery("UPDATE", "trans_final_tax", dic, Environment.MachineName, Environment.UserName, main.log_id, final_tax_id & "|", "final_tax_id")
                            Query(sql)
                            Dim return_id = Query(sql)
                            final_tax_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("final_tax_ref_id", final_tax_ref_id)
                            dicDet.Add("final_tax_id", final_tax_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Update", "trans_final_tax_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, final_tax_ref_id & "|", "final_tax_ref_id")
                            Query(sql_ref)
                        End If
                    End If
                Next
            Else
                Dim drs = ds.Tables("trans_jbooks").Select(String.Format(filter.Substring(5)))
                Dim jbooks_id = ""
                Dim jbooks_credit As Decimal = 0
                Dim jbooks_credit_based As Decimal = 0
                If drs.Length > 0 Then
                    jbooks_id = drs(0)("jbooks_id")
                    If jbooks_id.Contains("tmp_") Or jbooks_id = "" Then
                        jbooks_credit = ds.Tables("trans_final_tax").Compute("SUM(credit)", String.Format("deleted = False"))
                        jbooks_credit_based = ds.Tables("trans_final_tax").Compute("SUM(credit_based)", String.Format("deleted = False"))
                        If jbooks_credit <> 0 Or jbooks_credit_based <> 0 Then
                            Dim dic As New Dictionary(Of String, String)
                            dic.Add("jbooks_id", "")
                            dic.Add("trans_id", trans_id)
                            dic.Add("account_id", account_id)
                            dic.Add("project_id", project_id)
                            dic.Add("department_id", department_id)
                            dic.Add("debit", "0")
                            dic.Add("debit_based", "0")
                            dic.Add("credit", jbooks_credit)
                            dic.Add("credit_based", jbooks_credit_based)
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
                        jbooks_credit = ds.Tables("trans_final_tax").Compute("SUM(credit)", String.Format("deleted = False"))
                        jbooks_credit_based = ds.Tables("trans_final_tax").Compute("SUM(credit_based)", String.Format("deleted = False"))
                        If jbooks_credit <> 0 Or jbooks_credit_based <> 0 Then
                            Dim dic As New Dictionary(Of String, String)
                            dic.Add("jbooks_id", jbooks_id)
                            dic.Add("trans_id", trans_id)
                            dic.Add("account_id", account_id)
                            dic.Add("project_id", project_id)
                            dic.Add("department_id", department_id)
                            dic.Add("debit", "0")
                            dic.Add("debit_based", "0")
                            dic.Add("credit", jbooks_credit)
                            dic.Add("credit_based", jbooks_credit_based)
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
                    jbooks_credit = ds.Tables("trans_final_tax").Compute("SUM(credit)", String.Format("deleted = False"))
                    jbooks_credit_based = ds.Tables("trans_final_tax").Compute("SUM(credit_based)", String.Format("deleted = False"))
                    If jbooks_credit <> 0 Or jbooks_credit_based <> 0 Then
                        Dim dic As New Dictionary(Of String, String)
                        dic.Add("jbooks_id", "")
                        dic.Add("trans_id", trans_id)
                        dic.Add("account_id", account_id)
                        dic.Add("project_id", project_id)
                        dic.Add("department_id", department_id)
                        dic.Add("debit", "0")
                        dic.Add("debit_based", "0")
                        dic.Add("credit", jbooks_credit)
                        dic.Add("credit_based", jbooks_credit_based)
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
                For Each dr As DataRow In ds.Tables("trans_final_tax").Rows
                    Dim final_tax_id = dr("final_tax_id")
                    Dim final_tax_ref_id = dr("final_tax_ref_id")
                    Dim ref_no = dr("ref_no")
                    Dim currency_id = dr("currency_id")
                    Dim exchange_rate = dr("exchange_rate")
                    Dim based_rate = dr("based_rate")
                    Dim general_id = dr("general_id")
                    Dim fs_final_tax_id = dr("fs_final_tax_id")
                    Dim tax_rate = dr("tax_rate")
                    Dim amount = dr("amount")
                    Dim tax_amount = dr("tax_amount")
                    Dim amount_based = dr("amount_based")
                    Dim tax_amount_based = dr("tax_amount_based")
                    Dim credit = dr("credit")
                    Dim credit_based = dr("credit_based")
                    Dim unit_id = dr("unit_id")
                    Dim deleted = dr("deleted")
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("final_tax_id", final_tax_id)
                    dic.Add("jbooks_id", jbooks_id)
                    dic.Add("currency_id", currency_id)
                    dic.Add("exchange_rate", exchange_rate)
                    dic.Add("based_rate", based_rate)
                    dic.Add("general_id", general_id)
                    dic.Add("fs_final_tax_id", fs_final_tax_id)
                    dic.Add("tax_rate", tax_rate)
                    dic.Add("amount", amount)
                    dic.Add("tax_amount", tax_amount)
                    dic.Add("amount_based", amount_based)
                    dic.Add("tax_amount_based", tax_amount_based)
                    dic.Add("credit", credit)
                    dic.Add("credit_based", credit_based)
                    dic.Add("debit", 0)
                    dic.Add("debit_based", 0)
                    If final_tax_id.ToString.Contains("ag-") Or final_tax_id.ToString.Contains("tmp_") Or final_tax_id = "" Then
                        If Not deleted Then
                            Dim sql As String = ATGenerateQuery("Insert", "trans_final_tax", dic, Environment.MachineName, Environment.UserName, main.log_id, "|", "final_tax_id")
                            Dim return_id = Query(sql)
                            final_tax_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("final_tax_ref_id", "")
                            dicDet.Add("final_tax_id", final_tax_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Insert", "trans_final_tax_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, "|", "final_tax_ref_id")
                            Query(sql_ref)
                        End If
                    Else
                        If deleted Then
                            Dim sql As String = ATGenerateQuery("DELETE", "trans_final_tax", Nothing, Environment.MachineName, Environment.UserName, main.log_id, final_tax_id & "|", "final_tax_id")
                            Query(sql)
                        Else
                            Dim sql As String = ATGenerateQuery("UPDATE", "trans_final_tax", dic, Environment.MachineName, Environment.UserName, main.log_id, final_tax_id & "|", "final_tax_id")
                            Query(sql)
                            Dim return_id = Query(sql)
                            final_tax_id = return_id.Rows(0)("return_id")
                            Dim dicDet As New Dictionary(Of String, String)
                            dicDet.Add("final_tax_ref_id", final_tax_ref_id)
                            dicDet.Add("final_tax_id", final_tax_id)
                            dicDet.Add("ref_no", ref_no)
                            Dim sql_ref As String = ATGenerateQuery("Update", "trans_final_tax_ref", dicDet, Environment.MachineName, Environment.UserName, main.log_id, final_tax_ref_id & "|", "final_tax_ref_id")
                            Query(sql_ref)
                        End If
                    End If
                Next
            End If
        End If
    End Sub
End Class