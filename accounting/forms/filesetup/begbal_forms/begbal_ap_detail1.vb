Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class begbal_ap_detail
    Dim dbTable As String = "trans_jbooks"
    Dim ds As New begbal
    Private transmode As String = ""
    Private _currency_id As String = "0"
    Private _exchange_rate As Decimal = 0
    Private _based_rate As Decimal = 0
    Private _book_id As String = ""
    Private _trans_date As String = ""
    Private _trans_id As String = ""
    Private _account_id As String = Nothing
    Private _project_id As String = Nothing
    Private _department_id As String = Nothing
    Private _allocation_id As String = Nothing
    Private _line_remarks As String = Nothing
    Public Property begbal_date As DateTime = Today
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txt_debit.NumberFormat = strNumberFormat
        txt_credit.NumberFormat = strNumberFormat
        txt_debit_based.NumberFormat = strNumberFormat
        txt_credit_based.NumberFormat = strNumberFormat
        txt_exchange_rate.NumberFormat = strNumberFormat
        txt_based_rate.NumberFormat = strNumberFormat
    End Sub
    Public Property line_remarks() As String
        Get
            Return _line_remarks
        End Get
        Set(ByVal value As String)
            _line_remarks = value
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
    Public Property allocation_id() As String
        Get
            Return _allocation_id
        End Get
        Set(ByVal value As String)
            _allocation_id = value
        End Set
    End Property
    Public Property department_id() As String
        Get
            Return _department_id
        End Get
        Set(ByVal value As String)
            _department_id = value
        End Set
    End Property
    Public Property project_id() As String
        Get
            Return _project_id
        End Get
        Set(ByVal value As String)
            _project_id = value
        End Set
    End Property
    Public Property account_id() As String
        Get
            Return _account_id
        End Get
        Set(ByVal value As String)
            _account_id = value
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
    Public Property trans_id() As String
        Get
            Return _trans_id
        End Get
        Set(ByVal value As String)
            _trans_id = value
        End Set
    End Property
    Public Property book_id() As String
        Get
            Return _book_id
        End Get
        Set(ByVal value As String)
            _book_id = value
        End Set
    End Property
    Public Property trans_date() As String
        Get
            Return _trans_date
        End Get
        Set(ByVal value As String)
            _trans_date = value
        End Set
    End Property
    'Public Property BookUnitNoID As String = ""
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        ds.Tables(dbTable).Clear()
        Dim sql_unit As String = String.Format(",a.book_unit_no_id AS unit_id,j.book_unit_no_code AS unit_code,j.book_unit_no_name AS unit_name ")
        If My.Settings._enableProjectUnit Then
            sql_unit = String.Format(",a.project_unit_no_id AS unit_id,i.project_unit_no_codes AS unit_code,i.project_unit_no_names AS unit_name ")
        End If
        If trans_id <> "" And account_id <> "" Then
            Dim sql = String.Format("SELECT a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id " &
                ",a.account_id,a.currency_id,a.exchange_rate,a.based_rate,a.debit,a.credit,a.debit_based,a.credit_based " &
                ",a.general_id,a.ref_jbooks_id,a.line_remarks " &
                ",b.ref_no,b.ref_date,d.general_name,d.general_code " &
                ",IF(a.credit > e.debit,'Partially Paid',IF(a.credit = e.debit,'Fully Paid','')) as status " &
                ",IF(a.credit > e.debit,e.debit,IF(a.credit = e.debit,a.credit,0)) AS minimum " &
                ",f.terms_id,IFNULL(f.nodays,0) AS nodays,f.si_no,f.rr_no,f.po_no " &
                ",g.terms_code,g.terms_name " &
                ",h.currency_code,h.currency_name " &
                ",c.account_code,c.account_name " &
                sql_unit &
                "FROM trans_jbooks a " &
                "LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {2}.lib_erp_chart c ON c.account_id = a.account_id " &
                "LEFT JOIN {2}.lib_erp_general d ON d.general_id = a.general_id " &
                "LEFT JOIN (" &
                    "SELECT a.ref_jbooks_id AS jbooks_id,SUM(a.debit) AS debit,SUM(a.credit) AS credit " &
                    "FROM trans_jbooks a " &
                    "LEFT JOIN trans_header b ON b.trans_id = a.trans_id " &
                    "WHERE ref_jbooks_id IS NOT NULL AND (b.status <> 'C' OR b.status IS NULL) " &
                    "GROUP BY a.ref_jbooks_id " &
                ") e ON e.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {3}.trans_jbooks_ap f ON f.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {2}.lib_erp_terms g ON g.terms_id = f.terms_id " &
                "LEFT JOIN {2}.lib_erp_currency h ON h.currency_id = a.currency_id " &
                "LEFT JOIN {2}.lib_erp_project_unit_no i ON i.project_unit_no_id = a.project_unit_no_id " &
                "LEFT JOIN {2}.lib_erp_book_unit_no j ON j.book_unit_no_id = a.book_unit_no_id " &
                "WHERE c.validation = 3 AND a.trans_id = {0} AND a.account_id = {1} ", trans_id, account_id, _serverDBFS, _serverDBMain)
            If project_id <> "" Then
                sql &= String.Format(" AND a.project_id = '{0}'", project_id)
            End If
            If department_id <> "" Then
                sql &= String.Format(" AND a.department_id = '{0}'", department_id)
            End If
            'If My.Settings._enableBookUnit Then
            '    If My.Settings._enableBookUnit Then
            '        If BookUnitNoID <> "" Then
            '            sql &= String.Format(" AND j.book_unit_no_id = '{0}'", BookUnitNoID)
            '        End If
            '    Else
            '        If BookUnitNoID <> "" Then
            '            sql &= String.Format(" AND i.project_unit_no_names = '{0}'", BookUnitNoID)
            '        End If
            '    End If
            'End If
            Dim dt As DataTable = Query(sql)
            For Each row As DataRow In dt.Rows
                ds.Tables(dbTable).ImportRow(row)
            Next
        End If
        dgMain.DataSource = ds.Tables(dbTable)
        Dim currency_sql As String = String.Format("SELECT a.currency_code,a.currency_name FROM lib_erp_currency a WHERE a.currency_id = {0}", currency_id)
        Dim currency_dt As DataTable = FsQuery(currency_sql)
        txt_currency_name.Value = currency_id
        txt_currency_name.Text = currency_dt.Rows(0).Item("currency_name")
        txt_exchange_rate.DecimalValue = exchange_rate
        txt_based_rate.DecimalValue = based_rate
        computeGrid()
    End Sub
    Private Sub computeGrid()
        Dim dt As DataTable = dgMain.DataSource
        Dim credit As Decimal = 0
        Dim credit_based As Decimal = 0
        For Each row As DataRow In dt.Rows
            credit += row.Item("credit")
            credit_based += row.Item("credit_based")
        Next
        txt_total_amount.DecimalValue = credit
        txt_total_based.DecimalValue = credit_based
    End Sub
    Private Sub begbal_ap_detail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = DialogResult.OK
        'Me.Close()
    End Sub
    Private Sub begbal_ar_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDecimalPlaces(main.strNumberFormat)
        init_load()
        disable_control(Me)
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "jbooks_id", dt, Me)
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        txt_ref_date.Value = begbal_date
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As String = ""
        Dim dic_head As New Dictionary(Of String, String)
        dic_head.Add("trans_id", trans_id)
        dic_head.Add("trans_date", trans_date)
        dic_head.Add("book_id", book_id)
        dic_head.Add("journal_id", 8)
        dic_head.Add("currency_id", currency_id)
        Dim dic As New Dictionary(Of String, String)

        If project_id = "" Then
            project_id = Nothing
        End If
        If department_id = "" Then
            department_id = Nothing
        End If
        If allocation_id = "" Then
            allocation_id = Nothing
        End If

        dic.Add("jbooks_id", txt_jbooks_id.Value)
        dic.Add("trans_id", trans_id)
        dic.Add("currency_id", txt_currency_name.Value)
        dic.Add("exchange_rate", txt_exchange_rate.DecimalValue)
        dic.Add("based_rate", txt_based_rate.DecimalValue)
        dic.Add("debit", txt_debit.DecimalValue)
        dic.Add("debit_based", txt_debit_based.DecimalValue)
        dic.Add("credit", txt_credit.DecimalValue)
        dic.Add("credit_based", txt_credit_based.DecimalValue)
        dic.Add("general_id", txt_general_id.Value)
        dic.Add("account_id", account_id)
        dic.Add("project_id", project_id)
        dic.Add("department_id", department_id)
        dic.Add("line_remarks", line_remarks)
        dic.Add("allocation_id", allocation_id)
        If My.Settings._enableUnitNo Then
            If My.Settings._enableBookUnit Then
                dic.Add("book_unit_no_id", txt_unit_id.Value)
            Else
                dic.Add("project_unit_no_id", txt_unit_id.Value)
            End If
        End If

        Dim dic_ref As New Dictionary(Of String, String)

        dic_ref.Add("jbooks_ref_id", txt_jbooks_id.Value)
        dic_ref.Add("jbooks_id", txt_jbooks_id.Value)
        dic_ref.Add("ref_no", txt_ref_no.Text)
        dic_ref.Add("ref_date", CDate(txt_ref_date.Text).ToString("yyyy-MM-dd"))

        Dim dic_ap As New Dictionary(Of String, String)

        dic_ap.Add("jbooks_ap_id", txt_jbooks_id.Value)
        dic_ap.Add("jbooks_id", txt_jbooks_id.Value)
        dic_ap.Add("terms_id", txt_terms_id.Value)
        dic_ap.Add("nodays", txt_nodays.DecimalValue)
        dic_ap.Add("si_no", txt_si_no.Text)
        dic_ap.Add("rr_no", txt_rr_no.Text)
        dic_ap.Add("po_no", txt_po_no.Text)
        If dic.Item("general_id").ToString = "" Then
            MsgBox("General is required.")
            txt_general_id.Focus()
            Exit Sub
        End If
        If trans_id = "" Then
            Dim id As DataTable = Query(ATGenerateQuery("Insert", "trans_header", dic_head, Environment.MachineName, Environment.UserName, main.log_id, trans_id, "trans_id"))
            'Dim id As DataTable = Query(genInsert("trans_header", dic_head) & ";SELECT LAST_INSERT_ID() AS id;")
            dic.Item("trans_id") = id.Rows(0).Item("return_id").ToString
            Dim _id As DataTable = Query(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Text, "jbooks_id"))
            'Dim _id As DataTable = Query(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
            dic_ref.Item("jbooks_id") = _id.Rows(0).Item("return_id")
            Query(ATGenerateQuery("Insert", dbTable & "_ref", dic_ref, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
            'Query(genInsert(dbTable & "_ref", dic_ref))
            dic_ap.Item("jbooks_id") = _id.Rows(0).Item("return_id")
            'Query(genInsert(dbTable & "_ap", dic_ap))
            Query(ATGenerateQuery("Insert", dbTable & "_ap", dic_ap, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
            pk = _id.Rows(0).Item("return_id")
            MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
        ElseIf transmode = "insert" Then
            If DataExist(dgMain, {"jbooks_id", txt_jbooks_id.Value}, {"ref_no"}, {txt_ref_no.Text}) Then
                MsgBox("AP already exist")
                err = True
            Else
                Dim id As DataTable = Query(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
                'Dim id As DataTable = Query(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                dic_ref.Item("jbooks_id") = id.Rows(0).Item("return_id")
                dic_ap.Item("jbooks_id") = id.Rows(0).Item("return_id")
                Query(ATGenerateQuery("Insert", dbTable & "_ref", dic_ref, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
                'Dim sql = genInsert(dbTable & "_ref", dic_ref)
                'Query(sql)
                Query(ATGenerateQuery("Insert", dbTable & "_ap", dic_ap, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
                'Query(genInsert(dbTable & "_ap", dic_ap))
                pk = id.Rows(0).Item("return_id")
                MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
            End If

        ElseIf transmode = "update" Then
            If DataExist(dgMain, {"jbooks_id", txt_jbooks_id.Value}, {"ref_no"}, {txt_ref_no.Text}, False) Then
                MsgBox("AP already exist")
                err = True
            Else
                Query(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
                'Query(genUpdate(dbTable, dic))
                Dim tmp As DataTable = Query(String.Format("SELECT jbooks_id FROM {0}_ref WHERE jbooks_id = {1} ", dbTable, dic_ref("jbooks_id")))
                If tmp.Rows.Count > 0 Then
                    dic_ref.Remove("jbooks_ref_id")
                    Dim tmp_sql = ATGenerateQuery("Update", dbTable & "_ref", dic_ref, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id")
                    'Dim tmp_sql = genUpdate(dbTable & "_ref", dic_ref)
                    Query(tmp_sql)
                Else
                    Query(ATGenerateQuery("Insert", dbTable & "_ref", dic_ref, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
                    'Query(genInsert(dbTable & "_ref", dic_ref))
                End If
                tmp = Query(String.Format("SELECT jbooks_id FROM {0}_ap WHERE jbooks_id = {1} ", dbTable, dic_ref("jbooks_id")))
                If tmp.Rows.Count > 0 Then
                    dic_ap.Remove("jbooks_ap_id")
                    Query(ATGenerateQuery("Update", dbTable & "_ap", dic_ap, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
                    'Query(genUpdate(dbTable & "_ap", dic_ap))
                Else
                    Query(ATGenerateQuery("Insert", dbTable & "_ap", dic_ap, Environment.MachineName, Environment.UserName, main.log_id, txt_jbooks_id.Value, "jbooks_id"))
                    'Query(genInsert(dbTable & "_ap", dic_ap))
                End If
                pk = txt_jbooks_id.Value
                MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
            End If
        End If
        If Not err Then
            disable_control(Me)
            init_load()
            'bind_control(dgMain, "jbooks_id", ds.Tables(dbTable), Me)
            For Each row As DataGridViewRow In dgMain.Rows
                If row.Cells("jbooks_id").Value.ToString = pk Then
                    row.Selected = True
                End If
            Next

        End If
    End Sub
    Private Sub txt_genref_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_general ORDER BY FIELD(category_id,2,1),general_code ASC ")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("general_code like '{0}'", txt_general_id.Text.ToString.Replace("'", "''")))
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
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        Dim id As String = txt_jbooks_id.Value.ToString
        If id <> "" Then
            Try
                Dim dt As DataTable = ds.Tables("begbal_detail")
                dt.Clear()
                'ref_no,trans_date,book_code,account_code,debit,credit
                Dim sql = String.Format("SELECT a.trans_no AS ref_no,a.trans_date,d.book_code,e.account_code,e.account_name,b.debit,b.credit " &
                    "FROM trans_header a " &
                    "LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " &
                    "LEFT JOIN trans_jbooks_ref c ON c.jbooks_id = b.jbooks_id " &
                    "LEFT JOIN {1}.lib_erp_book d ON d.book_id = a.book_id " &
                    "LEFT JOIN {1}.lib_erp_chart e ON e.account_id = b.account_id " &
                    "WHERE b.ref_jbooks_id = '{0}' AND (a.status <> 'C' OR a.status IS NULL)", id, _serverDBFS)
                Dim data As DataTable = Query(sql)

                For Each row As DataRow In data.Rows
                    dt.ImportRow(row)
                Next

                'Dim autogeneratecolumns As System.Reflection.PropertyInfo = begbal_det.Controls("dgMain").GetType.GetProperty("AutoGenerateColumns")
                'If Not autogeneratecolumns Is Nothing Then
                '    autogeneratecolumns.SetValue(begbal_det.Controls("dgmain"), False, Nothing)
                'End If
                'Dim datasource As System.Reflection.PropertyInfo = begbal_det.Controls("dgMain").GetType.GetProperty("DataSource")
                'If Not datasource Is Nothing Then
                '    datasource.SetValue(begbal_det.Controls("dgMain"), dt, Nothing)
                'End If

                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item("book_code").ToString = "" And dt.Rows.Count = 1 Then
                        MsgBox("No Records to View.")
                    Else
                        'begbal_det.ShowDialog()
                        Dim frmDet As New begbal_det_new
                        frmDet.trans_no = txt_ref_no.Text
                        frmDet.trans_date = txt_ref_date.Value
                        frmDet.general_name = txt_general_name.Text
                        frmDet.line_remarks = ""
                        frmDet.amount = txt_credit.DecimalValue
                        frmDet.si_no = txt_si_no.Text
                        frmDet.rr_no = txt_rr_no.Text
                        frmDet.po_no = txt_po_no.Text
                        frmDet.jbooks_id = id
                        frmDet.ShowDialog()
                    End If
                Else
                    MsgBox("No Records to View.")
                End If
            Catch err As Exception
                MsgBox(err.Message)
            End Try
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        clear_control(Me)
        init_load()
        disable_control(Me)
    End Sub
    Private Sub txt_currency_Leave(sender As Object, e As EventArgs) Handles txt_currency_name.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_currency")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("currency_name like '{0}'", txt_currency_name.Text.ToString.Replace("'", "''")))
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
                txt_currency_name.RowData = dr
                txt_currency_name.Value = dr("currency_id")
                txt_currency_name.Text = dr("currency_name")
                Dim sql As String = String.Format("SELECT * FROM lib_erp_currency_rate WHERE currency_id = {0} AND effectivitydate <= '{1}' ORDER BY effectivitydate DESC LIMIT 1", txt_currency_name.Value, trans_date)
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
    Private Sub txt_credit_Leave(sender As Object, e As EventArgs) Handles txt_credit.Leave
        txt_credit_based.DecimalValue = txt_credit.DecimalValue * (txt_exchange_rate.DecimalValue / txt_based_rate.DecimalValue)
        If transmode = "update" Then
            Dim selectedRows = dgMain.SelectedRows
            If selectedRows.Count > 0 Then
                Dim selectedRow = selectedRows(0)
                If selectedRow.Cells("minimum").Value > txt_credit.DecimalValue Then
                    MsgBox("Invalid amount.")
                    txt_credit.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub txttermsiddet_Leave(sender As Object, e As EventArgs) Handles txt_terms_id.Leave
        Dim terms As DataTable = FsQuery("select * from lib_erp_terms where terms_type = 1 or terms_type = 3")

        If terms.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If terms.Rows.Count = 1 Then
                dr = terms.Rows(0)
            Else
                Dim dra() As DataRow = terms.Select("terms_name like '" & txt_terms_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = terms
                    browse.format("Code,Name", "terms_code,terms_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            'ap 1-3
            'ar 2-3
            If Not dr Is Nothing Then
                txt_terms_id.RowData = dr
                txt_terms_id.Value = dr("terms_id")
                txt_terms_id.Text = dr("terms_name")
                txt_nodays.Text = dr("nodays")
                If dr("fixed_day") = 0 Then
                    txt_nodays.Enabled = True
                Else
                    txt_nodays.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub txt_debit_Leave(sender As Object, e As EventArgs) Handles txt_debit.Leave
        txt_debit_based.DecimalValue = txt_debit.DecimalValue * (txt_exchange_rate.DecimalValue / txt_based_rate.DecimalValue)
    End Sub
    Private Sub txt_ref_no_Leave(sender As Object, e As EventArgs) Handles txt_ref_no.Leave
        Dim ref_no = sender.Text
        Dim jbooks_id = txt_jbooks_id.Text
        If ref_no = "" Or ref_no Is Nothing Then
            MsgBox("Reference Number is Required")
        Else
            If transmode = "insert" Then
                Dim sql As String = String.Format("SELECT ref_no FROM trans_jbooks_ref WHERE ref_no = '{0}'", ref_no)
                Dim dt As DataTable = Query(sql)
                If dt.Rows.Count > 0 Then
                    If txt_ref_no.Enabled Then
                        MsgBox("Reference Number Already in Used.")
                        txt_ref_no.Focus()
                    End If
                End If
            ElseIf transmode = "update" Then
                Dim sql As String = String.Format("SELECT ref_no FROM trans_jbooks_ref WHERE ref_no = '{0}' AND jbooks_id <> '{1}'", ref_no, jbooks_id)
                Dim dt As DataTable = Query(sql)
                If dt.Rows.Count > 0 Then
                    If txt_ref_no.Enabled Then
                        MsgBox("Reference Number Already in Used.")
                        txt_ref_no.Focus()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim _printoption As New reportoption
        _printoption.targetForm = Me
        _printoption.Rdo_button1.Hide()
        _printoption.cbo_sort.Text = "INVOICE NO."
        _printoption.cbo_sort.Items.Add("GEN. REF.")
        _printoption.cbo_sort.Items.Add("INVOICE NO.")
        _printoption.cbo_sort.Items.Add("ACCT. CODE")
        _printoption.btnOK.Focus()
        _printoption.ShowDialog()

        Dim sql As String = String.Format(" SELECT a.sys_beg, b.company_name " &
                                          "FROM sys_default a " &
                                          "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                          "", _serverDBFS)
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count > 0 Then
            Dim sql_account As String = String.Format("SELECT a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate " &
            ",a.debit,a.credit,a.debit_based,a.credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks " &
            ",d.ref_no,d.ref_date,b.account_code,e.general_code,e.general_name " &
            ",f.project_code,f.project_name,g.department_code,g.department_name,h.currency_code,h.currency_name " &
            " FROM trans_jbooks a " &
            " LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id " &
            " LEFT JOIN trans_header c ON c.trans_id = a.trans_id " &
            " LEFT JOIN trans_jbooks_ref d ON d.jbooks_id = a.jbooks_id " &
            " LEFT JOIN {0}.lib_erp_general e ON e.general_id = a.general_id" &
            " LEFT JOIN {0}.lib_erp_project f ON f.project_id = a.project_id" &
            " LEFT JOIN {0}.lib_erp_department g ON g.department_id = a.department_id " &
            " LEFT JOIN {0}.lib_erp_currency h ON h.currency_id = a.currency_id " &
            " WHERE b.validation = 3 AND c.journal_id = 8 AND d.ref_date <= '{1}' ", _serverDBFS, CDate(dt.Rows(0).Item("sys_beg")).ToString("yyyy-MM-dd"))
            If _printoption.cbo_sort.Text <> "" Then
                Dim tmp_str As String = ""
                Select Case _printoption.cbo_sort.Text
                    Case "GEN. REF."
                        tmp_str = "e.general_code"
                    Case "INVOICE NO."
                        tmp_str = "d.ref_no"
                    Case "ACCT. CODE"
                        tmp_str = "b.account_code"
                End Select
                sql_account &= String.Format(" ORDER BY {0}", tmp_str)
            End If
            Dim dt_account As DataTable = Query(sql_account)
            If dt_account.Rows.Count > 0 Then
                Dim ds As New beg_bal_apar
                For Each row As DataRow In dt_account.Rows
                    ds.Tables("dt_apar").ImportRow(row)
                Next
                Dim rep As New report_begbal_apar_print
                rep.DataSource = ds
                rep.company_name.Text = dt.Rows(0).Item("company_name")
                rep.report_name.Text = "BEGINNING BALANCES FOR ACCOUNTS PAYABLE"
                rep.as_of_date.Text = String.Format("As Of {0}", CDate(dt.Rows(0).Item("sys_beg")).ToString("MMM, yyyy"))
                rep.run_date.Text = Now.ToString("MM/dd/yyyy")
                rep.run_time.Text = Now.ToString("HH:mm:ss")
                rep.trans_no.Text = "Invoice No."
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                MsgBox("No Records to Print")
            End If
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        deleteHeader(dgMain, _serverDBMain, dbTable, "jbooks_id", "sel", main.log_id)
        init_load()
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnInsert)
        dicShortCut.Add(114, btnUpdate)
        dicShortCut.Add(115, btnRemove)
        dicShortCut.Add(116, btnPrint)
        dicShortCut.Add(117, btnViewDetails)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub

    Private Sub txt_po_no_Load(sender As Object, e As EventArgs) Handles txt_po_no.Load

    End Sub

    Private Sub txt_unit_Leave(sender As Object, e As EventArgs) Handles txt_unit_id.Leave
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
End Class