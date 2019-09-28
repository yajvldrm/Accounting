Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class trialbalance
    Private module_code As String = "ACC01012"
    Dim ds As New trial_balance_set
    Dim dt_accounts As DataTable = Nothing
    Dim templates As String = Application.StartupPath & "\templates"
    Dim strChar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim lstBook As New List(Of String)

    Private Sub range_filter_change(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged, rdo2.CheckedChanged, rdo3.CheckedChanged
        Dim range As String = getRdoValue(range_filter)
        If range = "2" Then
            txt_date_from.Enabled = False
            txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        Else
            txt_date_from.Enabled = True
            txt_date_to.MinDate = txt_date_from.Value
        End If
    End Sub
    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        Dim data_currency As DataTable = FsQuery("SELECT a.currency_name,a.currency_code,a.currency_id FROM lib_erp_currency a")
        If data_currency.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data_currency.Rows.Count = 1 Then
                dr = data_currency.Rows(0)
            Else
                Dim dra() As DataRow = data_currency.Select("currency_code like '" & txt_currency_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data_currency
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
                txt_currency_id.Text = dr("currency_code")
                txt_currency_name.Text = dr("currency_name")
            End If
        End If
    End Sub
    Private Sub trialbalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lst As New List(Of String)
        loadUnit(lst)

        txt_date_from.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        txt_date_to.MinDate = txt_date_from.Value

        btnPrintOption.Focus()

        Dim sql_book As String = String.Format("SELECT book_id,book_code,book_name " & vbNewLine &
            "FROM lib_erp_book a " & vbNewLine &
            "WHERE a.company_id = '{0}' ", main.Sys_Default.Rows(0).Item("company_id").ToString())
        Dim dt_book As DataTable = FsQuery(sql_book)
        ds.Tables("lib_erp_book").Clear()
        For Each dr As DataRow In dt_book.Rows
            ds.Tables("lib_erp_book").ImportRow(dr)
        Next
        dgBooks.AutoGenerateColumns = False
        dgBooks.DataSource = ds.Tables("lib_erp_book")
    End Sub
    Private Sub txt_project_id_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave
        Dim data As DataTable = FsQuery("SELECT a.project_name,a.project_code,a.project_id FROM lib_erp_project a")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("project_code like '" & txt_project_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "project_code,project_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_project_id.RowData = dr
                txt_project_id.Value = dr("project_id")
                txt_project_id.Text = dr("project_code")
                lbl_project_name.Text = dr("project_name")
                If My.Settings._enableBookUnit Then
                    Dim lst As New List(Of String)
                    lst.Add(dr("project_id"))
                    loadUnit(lst)
                End If
            Else
                Dim lst As New List(Of String)
                loadUnit(lst)
            End If
        End If
    End Sub
    Private Sub txt_department_id_Leave(sender As Object, e As EventArgs) Handles txt_department_id.Leave
        Dim data As DataTable = FsQuery("SELECT a.department_name,a.department_code,a.department_id FROM lib_erp_department a")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("department_code like '" & txt_department_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "department_code,department_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_department_id.RowData = dr
                txt_department_id.Value = dr("department_id")
                txt_department_id.Text = dr("department_code")
                lbl_department_name.Text = dr("department_name")
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim range As String = getRdoValue(range_filter)
        Dim sort As String = getRdoValue(sort_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim date_from = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim currency_id = txt_currency_id.Value
        Dim project_id = txt_project_id.Value
        Dim department_id = txt_department_id.Value
        Dim wProjectDepartment As Boolean = withProjectDepartment.Checked
        Dim wComparison As Boolean = withComparison.Checked

        Dim lst_book = getCheckedGrid("book_id", "book_name", "sel", dgBooks, , False, "No Book Selected", False)
        If lst_book Is Nothing Or lst_book.Length = 0 Then
            Exit Sub
        End If
        Dim bookIds = String.Join(",", lst_book)

        Dim lst_unit = getCheckedGrid("unit_id", "unit_name", "sel1", dgUnit, , False, "*No Message*", False)
        Dim unitIds = String.Join(",", lst_unit)
        Dim unit_table As String = ""
        Dim unit_id As String = ""
        Dim unit_code As String = ""
        Dim unit_name As String = ""
        If My.Settings._enableBookUnit Then
            unit_table = "lib_erp_book_unit_no"
            unit_id = "book_unit_no_id"
            unit_code = "book_unit_no_code"
            unit_name = "book_unit_no_name"
        Else
            unit_table = "lib_erp_project_unit_no"
            unit_id = "project_unit_no_id"
            unit_code = "project_unit_no_codes"
            unit_name = "project_unit_no_names"
        End If

        Dim sql_accounts As String = ""

        If groupByBook.Checked Then
            sql_accounts = String.Format("SELECT a.account_id,a.account_code,a.account_name,b.chart_type
            ,a.chart_class_id,b.chart_class_code,b.chart_class_name
            ,unit." & unit_code & " AS unit_code,unit." & unit_name & " AS unit_name
            ,project.project_code,project.project_name
            ,department.department_code,department.department_name
            ,c.currency_id,c.project_id,c.department_id,e.currency_name, " & vbNewLine &
            "IF(SUM(c.debit) > SUM(c.credit), " & vbNewLine &
            "  (SUM(c.debit) - SUM(c.credit)),0 " & vbNewLine &
            ") AS debit, " & vbNewLine &
            "IF(SUM(c.credit) > SUM(c.debit), " & vbNewLine &
            "  (SUM(c.credit) - SUM(c.debit)),0 " & vbNewLine &
            ") AS credit, " & vbNewLine &
            "IF(SUM(c.debit_based) > SUM(c.credit_based), " & vbNewLine &
            "  (SUM(c.debit_based) - SUM(c.credit_based)),0 " & vbNewLine &
            ") AS debit_based, " & vbNewLine &
            "IF(SUM(c.credit_based) > SUM(c.debit_based), " & vbNewLine &
            "  (SUM(c.credit_based) - SUM(c.debit_based)),0 " & vbNewLine &
            ") AS credit_based " & vbNewLine &
            ",_book.book_id,_book.book_code,CONCAT('TRIAL BALANCE - ',_book.book_name) AS book_name " & vbNewLine &
            ",chart_group.group_id,account_group.chart_group_code,CONCAT(account_group.chart_group_code,' - ',account_group.chart_group_name) AS chart_group_name " & vbNewLine &
            "FROM lib_erp_chart a " & vbNewLine &
            "LEFT JOIN lib_erp_book _book ON _book.company_id = '{2}' " & vbNewLine &
            "LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " & vbNewLine &
            "LEFT JOIN (
                SELECT a.chart_group_id,a.account_id,a.group_id
			    FROM lib_erp_chart_group a
			    GROUP BY a.account_id
            ) chart_group ON chart_group.account_id = a.account_id " & vbNewLine &
            "LEFT JOIN lib_acc_chart_group account_group ON account_group.chart_group_id = chart_group.group_id " & vbNewLine &
            "LEFT JOIN {1}.trans_jbooks c ON c.account_id = a.account_id
            LEFT JOIN " & unit_table & " unit ON unit." & unit_id & " = c." & unit_id & "
            LEFT JOIN lib_erp_project project ON project.project_id = c.project_id
            LEFT JOIN lib_erp_department department ON department.department_id = c.department_id " & vbNewLine &
            "LEFT JOIN {1}.trans_header d ON d.trans_id = c.trans_id AND d.book_id = _book.book_id " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_currency e ON e.currency_id = c.currency_id ", _serverDBFS, _serverDBMain, main.Sys_Default.Rows(0).Item("company_id").ToString)

            Select Case range
                Case "1" ' Range Only
                    sql_accounts &= String.Format("WHERE d.trans_date BETWEEN '{0}' AND '{1}'  ", date_from, date_to)
                Case "2" ' To Date / As Of
                    sql_accounts &= String.Format("WHERE d.trans_date <= '{0}'  ", date_to)
                Case "3" ' Range with Beginning Balance
                    Dim book_name As String = "'TRIAL BALANCE' AS book_name"
                    If groupByBook.Checked Then
                        book_name = "_book.book_name"
                    End If
                    sql_accounts = String.Format("SELECT a.account_id,a.account_name,a.account_code
                        ,a.chart_class_id,b.chart_class_code,b.chart_class_name
                        ,chart_group.chart_group_id,account_group.chart_group_code,account_group.chart_group_name
                        ,b.chart_type,IfNull(d.currency_id,e.currency_id) AS currency_id,f.currency_name 
                        ,d.beg_debit,d.beg_credit,d.beg_debit_based,d.beg_credit_based,d.department_id
                        ,d.project_id
                        ,d.unit_code,d.unit_name
                        ,d.project_code,d.project_name
                        ,d.department_code,d.department_name
                        ,e.debit,e.credit,e.debit_based,e.credit_based " & vbNewLine &
                        ",header.book_id,_book.book_code," & book_name & " " & vbNewLine &
                        "FROM {1}.lib_erp_chart a  " & vbNewLine &
                        "LEFT JOIN {1}.lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id  " & vbNewLine &
                        "LEFT JOIN {2}.trans_jbooks c ON c.account_id = a.account_id  " & vbNewLine &
                        "LEFT JOIN {2}.trans_header header ON header.trans_id = c.trans_id  " & vbNewLine &
                        "LEFT JOIN {1}.lib_erp_book _book ON _book.book_id = header.book_id  " & vbNewLine &
                        "LEFT JOIN (
                            SELECT a.chart_group_id,a.account_id,a.group_id
			                FROM {1}.lib_erp_chart_group a
			                GROUP BY a.account_id
                        ) chart_group ON chart_group.account_id = a.account_id " & vbNewLine &
                        "LEFT JOIN {1}.lib_acc_chart_group account_group ON account_group.chart_group_id = chart_group.group_id " & vbNewLine &
                        "LEFT JOIN ( " & vbNewLine &
                        "  SELECT a.book_id,b.account_id,b.currency_id,b.project_id,b.department_id , " & vbNewLine &
                        "  IF((SUM(b.debit) > SUM(b.credit)),  " & vbNewLine &
                        "    (SUM(b.debit) - SUM(b.credit)),0  " & vbNewLine &
                        "  ) AS beg_debit , " & vbNewLine &
                        "  IF((SUM(b.credit) > SUM(b.debit)),  " & vbNewLine &
                        "    (SUM(b.credit) - SUM(b.debit)),0  " & vbNewLine &
                        "  ) AS beg_credit , " & vbNewLine &
                        "  IF((SUM(b.debit_based) > SUM(b.credit_based)),  " & vbNewLine &
                        "    (SUM(b.debit_based) - SUM(b.credit_based)),0  " & vbNewLine &
                        "  ) AS beg_debit_based , " & vbNewLine &
                        "  IF((SUM(b.credit_based) > SUM(b.debit_based)),  " & vbNewLine &
                        "    (SUM(b.credit_based) - SUM(b.debit_based)),0  " & vbNewLine &
                        "  ) AS beg_credit_based
                        ,unit." & unit_code & " AS unit_code,unit." & unit_name & " AS unit_name
                        ,project.project_code,project.project_name
                        ,department.department_code,department.department_name
                         " & vbNewLine &
                        "  FROM {2}.trans_header a  " & vbNewLine &
                        "  LEFT JOIN {2}.trans_jbooks b ON b.trans_id = a.trans_id
                        LEFT JOIN " & unit_table & " unit ON unit." & unit_id & " = b." & unit_id & "
                        LEFT JOIN {1}.lib_erp_project project ON project.project_id = b.project_id
                        LEFT JOIN {1}.lib_erp_department department ON department.department_id = b.department_id
                         " & vbNewLine &
                        "  WHERE a.trans_date <= '{0}' AND a.book_id IN ({3})  ", txt_date_from.Value.AddDays(-1).ToString("yyyy-MM-dd"), _serverDBFS, _serverDBMain, bookIds)
                    If unitIds <> "" Then
                        If My.Settings._enableBookUnit Then
                            sql_accounts &= String.Format(" AND b.book_unit_no_id IN ({0}) ", unitIds)
                        Else
                            sql_accounts &= String.Format(" AND b.project_unit_no_id IN ({0}) ", unitIds)
                        End If
                    End If
                    'where filter
                    If currency_id <> "" Then
                        sql_accounts &= String.Format(" AND b.currency_id = {0} ", currency_id)
                    End If

                    If project_id <> "" Then
                        sql_accounts &= String.Format(" AND b.project_id = {0} ", project_id)
                    End If

                    If department_id <> "" Then
                        sql_accounts &= String.Format(" AND b.department_id = {0} ", department_id)
                    End If
                    'end of where filter

                    sql_accounts &= String.Format("GROUP BY b.account_id ")

                    'group filter
                    If currency = "2" Then
                        sql_accounts &= " ,b.currency_id "
                    End If
                    'end of group filter

                    sql_accounts &= String.Format(") d ON d.account_id = a.account_id AND d.book_id = _book.book_id ")
                    If currency = "2" Then
                        sql_accounts &= " AND d.currency_id = c.currency_id "
                    End If

                    sql_accounts &= String.Format("LEFT JOIN ( " & vbNewLine &
                        "  SELECT a.book_id,b.account_id,b.currency_id , " & vbNewLine &
                        "  SUM(b.debit) AS debit , " & vbNewLine &
                        "  SUM(b.credit) AS credit , " & vbNewLine &
                        "  SUM(b.debit_based) AS debit_based , " & vbNewLine &
                        "  SUM(b.credit_based) AS credit_based  " & vbNewLine &
                        "  FROM {2}.trans_header a  " & vbNewLine &
                        "  LEFT JOIN {2}.trans_jbooks b ON b.trans_id = a.trans_id  " & vbNewLine &
                        "  WHERE a.trans_date BETWEEN '{0}' AND '{1}' AND a.book_id IN ({3}) ", date_from, date_to, _serverDBMain, bookIds)
                    If unitIds <> "" Then
                        If My.Settings._enableBookUnit Then
                            sql_accounts &= String.Format(" AND b.book_unit_no_id IN ({0}) ", unitIds)
                        Else
                            sql_accounts &= String.Format(" AND b.project_unit_no_id IN ({0}) ", unitIds)
                        End If
                    End If
                    'where filter
                    If currency_id <> "" Then
                        sql_accounts &= String.Format(" AND b.currency_id = {0} ", currency_id)
                    End If

                    If project_id <> "" Then
                        sql_accounts &= String.Format(" AND b.project_id = {0} ", project_id)
                    End If

                    If department_id <> "" Then
                        sql_accounts &= String.Format(" AND b.department_id = {0} ", department_id)
                    End If
                    'end of where filter

                    sql_accounts &= String.Format("GROUP BY a.book_id,b.account_id ")

                    'group filter
                    If currency = "2" Then
                        sql_accounts &= " ,b.currency_id "
                    End If
                    'end of group filter

                    sql_accounts &= String.Format(") e ON e.account_id = a.account_id AND e.book_id = _book.book_id ")
                    If currency = "2" Then
                        sql_accounts &= " AND e.currency_id = c.currency_id "
                    End If

                    sql_accounts &= String.Format("LEFT JOIN {0}.lib_erp_currency f ON f.currency_id = c.currency_id " & vbNewLine &
                                                  "WHERE e.debit IS NOT NULL OR d.beg_debit IS NOT NULL " & vbNewLine &
                                                  "AND header.book_id IN ({1}) ", _serverDBFS, bookIds)

                    sql_accounts &= "GROUP BY _book.book_id,a.account_id "
                    If currency = "2" Then
                        sql_accounts &= ",c.currency_id "
                    End If
            End Select

            If range <> "3" Then
                If currency_id <> "" Then
                    sql_accounts &= String.Format(" AND c.currency_id = {0} ", currency_id)
                End If

                If project_id <> "" Then
                    sql_accounts &= String.Format(" AND c.project_id = {0} ", project_id)
                End If

                If department_id <> "" Then
                    sql_accounts &= String.Format(" AND c.department_id = {0} ", department_id)
                End If
                sql_accounts &= String.Format(" AND _book.book_id IN ({0}) ", bookIds)
                If unitIds <> "" Then
                    If My.Settings._enableBookUnit Then
                        sql_accounts &= String.Format(" AND c.book_unit_no_id IN ({0}) ", unitIds)
                    Else
                        sql_accounts &= String.Format(" AND c.project_unit_no_id IN ({0}) ", unitIds)
                    End If
                End If
                sql_accounts &= "GROUP BY _book.book_id,a.account_id "
                If groupByUnit.Checked Then
                    If My.Settings._enableBookUnit Then
                        sql_accounts &= ",c.book_unit_no_id "
                    Else
                        sql_accounts &= ",c.project_unit_no_id "
                    End If
                Else
                    If unitIds <> "" Then
                        If My.Settings._enableBookUnit Then
                            sql_accounts &= String.Format(" ,c.book_unit_no_id ")
                        Else
                            sql_accounts &= String.Format(" ,c.project_unit_no_id ")
                        End If
                    End If
                End If
                If currency <> "1" Then
                    sql_accounts &= " ,c.currency_id "
                End If
            End If

            Select Case sort
                Case "1"
                    sql_accounts &= " ORDER BY FIELD(b.chart_type,'A','L','C','I','E'),a.account_code "
                Case "2"
                    sql_accounts &= " ORDER BY account_group.chart_group_code,a.account_code "
                Case "3"
                    sql_accounts &= " ORDER BY a.account_code,FIELD(b.chart_type,'A','L','C','I','E') "
            End Select

        ElseIf groupByUnit.Checked Then

            sql_accounts = String.Format("SELECT f.book_unit_no_id,f.book_unit_no_code,f.book_unit_no_name
            ,a.chart_class_id,b.chart_class_code,b.chart_class_name
            ,a.account_id,a.account_code,a.account_name,b.chart_type
            ,c.currency_id,c.project_id,c.department_id,e.currency_name
            ,project.project_code,project.project_name
            ,unit." & unit_code & " AS unit_code,unit." & unit_name & " AS unit_name
            ,department.department_code,department.department_name
            " & vbNewLine &
            ",chart_group.group_id,account_group.chart_group_code,CONCAT(account_group.chart_group_code,' - ',account_group.chart_group_name) AS chart_group_name " & vbNewLine &
           ",IF(SUM(c.debit) > SUM(c.credit), " & vbNewLine &
           "  (SUM(c.debit) - SUM(c.credit)),0 " & vbNewLine &
           ") AS debit, " & vbNewLine &
           "IF(SUM(c.credit) > SUM(c.debit), " & vbNewLine &
           "  (SUM(c.credit) - SUM(c.debit)),0 " & vbNewLine &
           ") AS credit, " & vbNewLine &
           "IF(SUM(c.debit_based) > SUM(c.credit_based), " & vbNewLine &
           "  (SUM(c.debit_based) - SUM(c.credit_based)),0 " & vbNewLine &
           ") AS debit_based, " & vbNewLine &
           "IF(SUM(c.credit_based) > SUM(c.debit_based), " & vbNewLine &
           "  (SUM(c.credit_based) - SUM(c.debit_based)),0 " & vbNewLine &
           ") AS credit_based " & vbNewLine &
           ",_book.book_id,_book.book_code,'TRIAL BALANCE' AS book_name " & vbNewLine &
           "FROM lib_erp_chart a " & vbNewLine &
           "LEFT JOIN lib_erp_book _book ON 1 = 1 " & vbNewLine &
           "LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " & vbNewLine &
           "LEFT JOIN (
                SELECT a.chart_group_id,a.account_id,a.group_id
			    FROM lib_erp_chart_group a
			    GROUP BY a.account_id
            ) chart_group ON chart_group.account_id = a.account_id " & vbNewLine &
            "LEFT JOIN lib_acc_chart_group account_group ON account_group.chart_group_id = chart_group.group_id " & vbNewLine &
           "LEFT JOIN {1}.trans_jbooks c ON c.account_id = a.account_id " & vbNewLine &
           "LEFT JOIN {1}.trans_header d ON d.trans_id = c.trans_id AND d.book_id = _book.book_id " & vbNewLine &
           "LEFT JOIN {0}.lib_erp_project project ON project.project_id = c.project_id
           LEFT JOIN " & unit_table & " unit ON unit." & unit_id & " = c." & unit_id & "
            " & vbNewLine &
           "LEFT JOIN {0}.lib_erp_department department ON department.department_id = c.department_id " & vbNewLine &
           "LEFT JOIN {0}.lib_erp_book_unit_no f ON f.book_unit_no_id = c.book_unit_no_id " & vbNewLine &
           "LEFT JOIN {0}.lib_erp_currency e ON e.currency_id = c.currency_id ", _serverDBFS, _serverDBMain)

            Select Case range
                Case "1" ' Range Only
                    sql_accounts &= String.Format("WHERE d.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)
                Case "2" ' To Date / As Of
                    sql_accounts &= String.Format("WHERE d.trans_date <= '{0}' ", date_to)
                Case "3" ' Range with Beginning Balance
                    Dim book_name As String = "'TRIAL BALANCE' AS book_name"
                    If groupByBook.Checked Then
                        book_name = "_book.book_name"
                    End If
                    sql_accounts = String.Format("SELECT a.account_id,a.account_name,a.account_code
                        ,a.chart_class_id,b.chart_class_code,b.chart_class_name
                        ,chart_group.chart_group_id,account_group.chart_group_code,account_group.chart_group_name
                        ,b.chart_type,IfNull(d.currency_id,e.currency_id) AS currency_id,f.currency_name 
                        ,d.beg_debit,d.beg_credit,d.beg_debit_based,d.beg_credit_based,d.department_id,d.project_id 
                        ,d.unit_code,d.unit_name
                        ,d.project_code,d.project_name
                        ,d.department_code,d.department_name
                        ,e.debit,e.credit,e.debit_based,e.credit_based " & vbNewLine &
                        ",header.book_id,_book.book_code," & book_name & " " & vbNewLine &
                        "FROM {1}.lib_erp_chart a  " & vbNewLine &
                        "LEFT JOIN {1}.lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id  " & vbNewLine &
                        "LEFT JOIN {2}.trans_jbooks c ON c.account_id = a.account_id  " & vbNewLine &
                        "LEFT JOIN {2}.trans_header header ON header.trans_id = c.trans_id  " & vbNewLine &
                        "LEFT JOIN {1}.lib_erp_book _book ON _book.book_id = header.book_id  " & vbNewLine &
                        "LEFT JOIN (
                            SELECT a.chart_group_id,a.account_id,a.group_id
			                FROM {1}.lib_erp_chart_group a
			                GROUP BY a.account_id
                        ) chart_group ON chart_group.account_id = a.account_id " & vbNewLine &
                        "LEFT JOIN {1}.lib_acc_chart_group account_group ON account_group.chart_group_id = chart_group.group_id " & vbNewLine &
                        "LEFT JOIN ( " & vbNewLine &
                        "  SELECT a.book_id,b.account_id,b.currency_id,b.project_id,b.department_id , " & vbNewLine &
                        "  IF((SUM(b.debit) > SUM(b.credit)),  " & vbNewLine &
                        "    (SUM(b.debit) - SUM(b.credit)),0  " & vbNewLine &
                        "  ) AS beg_debit , " & vbNewLine &
                        "  IF((SUM(b.credit) > SUM(b.debit)),  " & vbNewLine &
                        "    (SUM(b.credit) - SUM(b.debit)),0  " & vbNewLine &
                        "  ) AS beg_credit , " & vbNewLine &
                        "  IF((SUM(b.debit_based) > SUM(b.credit_based)),  " & vbNewLine &
                        "    (SUM(b.debit_based) - SUM(b.credit_based)),0  " & vbNewLine &
                        "  ) AS beg_debit_based , " & vbNewLine &
                        "  IF((SUM(b.credit_based) > SUM(b.debit_based)),  " & vbNewLine &
                        "    (SUM(b.credit_based) - SUM(b.debit_based)),0  " & vbNewLine &
                        "  ) AS beg_credit_based
                           ,unit." & unit_code & " AS unit_code,unit." & unit_name & " AS unit_name
                           ,project.project_code,project.project_name
                           ,department.department_code,department.department_name
                         " & vbNewLine &
                        "  FROM {2}.trans_header a  " & vbNewLine &
                        "  LEFT JOIN {2}.trans_jbooks b ON b.trans_id = a.trans_id
                           LEFT JOIN {1}.lib_erp_project project ON project.project_id = b.project_id
                           LEFT JOIN {1}." & unit_table & " unit ON unit." & unit_id & " = b." & unit_id & "
                           LEFT JOIN {1}.lib_erp_department department ON department.department_id = b.department_id
                         " & vbNewLine &
                        "  WHERE a.trans_date <= '{0}' AND a.book_id IN ({3}) ", txt_date_from.Value.AddDays(-1).ToString("yyyy-MM-dd"), _serverDBFS, _serverDBMain, bookIds)
                    If unitIds <> "" Then
                        If My.Settings._enableBookUnit Then
                            sql_accounts &= String.Format(" AND b.book_unit_no_id IN ({0}) ", unitIds)
                        Else
                            sql_accounts &= String.Format(" AND b.project_unit_no_id IN ({0}) ", unitIds)
                        End If
                    End If
                    'where filter
                    If currency_id <> "" Then
                        sql_accounts &= String.Format(" AND b.currency_id = {0} ", currency_id)
                    End If

                    If project_id <> "" Then
                        sql_accounts &= String.Format(" AND b.project_id = {0} ", project_id)
                    End If

                    If department_id <> "" Then
                        sql_accounts &= String.Format(" AND b.department_id = {0} ", department_id)
                    End If
                    'end of where filter

                    sql_accounts &= String.Format("GROUP BY b.account_id ")

                    'group filter
                    If currency = "2" Then
                        sql_accounts &= " ,b.currency_id "
                    End If
                    'end of group filter

                    sql_accounts &= String.Format(") d ON d.account_id = a.account_id ")
                    If currency = "2" Then
                        sql_accounts &= " AND d.currency_id = c.currency_id "
                    End If

                    sql_accounts &= String.Format("LEFT JOIN ( " & vbNewLine &
                        "  SELECT b.account_id,b.currency_id , " & vbNewLine &
                        "  SUM(b.debit) AS debit , " & vbNewLine &
                        "  SUM(b.credit) AS credit , " & vbNewLine &
                        "  SUM(b.debit_based) AS debit_based , " & vbNewLine &
                        "  SUM(b.credit_based) AS credit_based  " & vbNewLine &
                        "  FROM {2}.trans_header a  " & vbNewLine &
                        "  LEFT JOIN {2}.trans_jbooks b ON b.trans_id = a.trans_id  " & vbNewLine &
                        "  WHERE a.trans_date BETWEEN '{0}' AND '{1}' AND a.book_id IN ({3}) ", date_from, date_to, _serverDBMain, bookIds)
                    If unitIds <> "" Then
                        If My.Settings._enableBookUnit Then
                            sql_accounts &= String.Format(" AND b.book_unit_no_id IN ({0}) ", unitIds)
                        Else
                            sql_accounts &= String.Format(" AND b.project_unit_no_id IN ({0}) ", unitIds)
                        End If
                    End If
                    'where filter
                    If currency_id <> "" Then
                        sql_accounts &= String.Format(" AND b.currency_id = {0} ", currency_id)
                    End If

                    If project_id <> "" Then
                        sql_accounts &= String.Format(" AND b.project_id = {0} ", project_id)
                    End If

                    If department_id <> "" Then
                        sql_accounts &= String.Format(" AND b.department_id = {0} ", department_id)
                    End If
                    'end of where filter

                    sql_accounts &= String.Format("GROUP BY b.account_id ")

                    'group filter
                    If currency = "2" Then
                        sql_accounts &= " ,b.currency_id "
                    End If
                    'end of group filter

                    sql_accounts &= String.Format(") e ON e.account_id = a.account_id ")
                    If currency = "2" Then
                        sql_accounts &= " AND e.currency_id = c.currency_id "
                    End If

                    sql_accounts &= String.Format("LEFT JOIN {0}.lib_erp_currency f ON f.currency_id = c.currency_id " & vbNewLine &
                                                  "WHERE e.debit IS NOT NULL OR d.beg_debit IS NOT NULL " & vbNewLine &
                                                  "AND header.book_id IN ({1}) ", _serverDBFS, bookIds)

                    sql_accounts &= "GROUP BY a.account_id "
                    If currency = "2" Then
                        sql_accounts &= ",c.currency_id "
                    End If
            End Select

            If range <> "3" Then
                If currency_id <> "" Then
                    sql_accounts &= String.Format(" AND c.currency_id = {0} ", currency_id)
                End If

                If project_id <> "" Then
                    sql_accounts &= String.Format(" AND c.project_id = {0} ", project_id)
                End If

                If department_id <> "" Then
                    sql_accounts &= String.Format(" AND c.department_id = {0} ", department_id)
                End If
                sql_accounts &= String.Format(" AND _book.book_id IN ({0}) ", bookIds)
                If unitIds <> "" Then
                    If My.Settings._enableBookUnit Then
                        sql_accounts &= String.Format(" AND c.book_unit_no_id IN ({0}) ", unitIds)
                    Else
                        sql_accounts &= String.Format(" AND c.project_unit_no_id IN ({0}) ", unitIds)
                    End If
                End If
                sql_accounts &= "GROUP BY a.account_id "
                If currency <> "1" Then
                    sql_accounts &= " ,c.currency_id "
                End If
            End If

            Select Case sort
                Case "1"
                    sql_accounts &= " ORDER BY FIELD(b.chart_type,'A','L','C','I','E'),a.account_code "
                Case "2"
                    sql_accounts &= " ORDER BY account_group.chart_group_code,a.account_code "
                Case "3"
                    sql_accounts &= " ORDER BY a.account_code,FIELD(b.chart_type,'A','L','C','I','E') "
            End Select

        Else
            sql_accounts = String.Format("SELECT a.account_id,a.account_code,a.account_name
            ,a.chart_class_id,b.chart_class_code,b.chart_class_name
            ,b.chart_type,c.currency_id,c.project_id,c.department_id,e.currency_name
            ,unit." & unit_code & " AS unit_code,unit." & unit_name & " AS unit_name
            ,project.project_code,project.project_name
            ,department.department_code,department.department_name
            " & vbNewLine &
            ",IF(SUM(c.debit) > SUM(c.credit), " & vbNewLine &
            "  (SUM(c.debit) - SUM(c.credit)),0 " & vbNewLine &
            ") AS debit, " & vbNewLine &
            "IF(SUM(c.credit) > SUM(c.debit), " & vbNewLine &
            "  (SUM(c.credit) - SUM(c.debit)),0 " & vbNewLine &
            ") AS credit, " & vbNewLine &
            "IF(SUM(c.debit_based) > SUM(c.credit_based), " & vbNewLine &
            "  (SUM(c.debit_based) - SUM(c.credit_based)),0 " & vbNewLine &
            ") AS debit_based, " & vbNewLine &
            "IF(SUM(c.credit_based) > SUM(c.debit_based), " & vbNewLine &
            "  (SUM(c.credit_based) - SUM(c.debit_based)),0 " & vbNewLine &
            ") AS credit_based " & vbNewLine &
            ",_book.book_id,_book.book_code,'TRIAL BALANCE' AS book_name " & vbNewLine &
            ",chart_group.group_id,account_group.chart_group_code,CONCAT(account_group.chart_group_code,' - ',account_group.chart_group_name) AS chart_group_name " & vbNewLine &
            "FROM lib_erp_chart a " & vbNewLine &
            "LEFT JOIN lib_erp_book _book ON 1 = 1 " & vbNewLine &
            "LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " & vbNewLine &
            "LEFT JOIN (
                SELECT a.chart_group_id,a.account_id,a.group_id
			    FROM lib_erp_chart_group a
			    GROUP BY a.account_id
            ) chart_group ON chart_group.account_id = a.account_id " & vbNewLine &
            "LEFT JOIN lib_acc_chart_group account_group ON account_group.chart_group_id = chart_group.group_id " & vbNewLine &
            "LEFT JOIN {1}.trans_jbooks c ON c.account_id = a.account_id " & vbNewLine &
            "LEFT JOIN {1}.trans_header d ON d.trans_id = c.trans_id AND d.book_id = _book.book_id
            LEFT JOIN {0}." & unit_table & " unit ON unit." & unit_id & " = c." & unit_id & " " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_project project ON project.project_id = c.project_id " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_department department ON department.department_id = c.department_id " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_currency e ON e.currency_id = c.currency_id ", _serverDBFS, _serverDBMain)

            Select Case range
                Case "1" ' Range Only
                    sql_accounts &= String.Format("WHERE d.trans_date BETWEEN '{0}' AND '{1}'  ", date_from, date_to)
                Case "2" ' To Date / As Of
                    sql_accounts &= String.Format("WHERE d.trans_date <= '{0}'  ", date_to)
                Case "3" ' Range with Beginning Balance
                    Dim book_name As String = "'TRIAL BALANCE' AS book_name"
                    If groupByBook.Checked Then
                        book_name = "_book.book_name"
                    End If
                    sql_accounts = String.Format("SELECT a.account_id,a.account_name,a.account_code
                        ,a.chart_class_id,b.chart_class_code,b.chart_class_name
                        ,chart_group.chart_group_id,account_group.chart_group_code,account_group.chart_group_name
                        ,b.chart_type,IfNull(d.currency_id,e.currency_id) AS currency_id,f.currency_name 
                        ,d.beg_debit,d.beg_credit,d.beg_debit_based,d.beg_credit_based,d.department_id,d.project_id
                        ,d.unit_code,d.unit_name
                        ,d.project_code,d.project_name
                        ,d.department_code,d.department_name
                        ,e.debit,e.credit,e.debit_based,e.credit_based " & vbNewLine &
                        ",header.book_id,_book.book_code," & book_name & " " & vbNewLine &
                        "FROM {1}.lib_erp_chart a  " & vbNewLine &
                        "LEFT JOIN {1}.lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id  " & vbNewLine &
                        "LEFT JOIN {2}.trans_jbooks c ON c.account_id = a.account_id  " & vbNewLine &
                        "LEFT JOIN {2}.trans_header header ON header.trans_id = c.trans_id  " & vbNewLine &
                        "LEFT JOIN {1}.lib_erp_book _book ON _book.book_id = header.book_id  " & vbNewLine &
                        "LEFT JOIN (
                            SELECT a.chart_group_id,a.account_id,a.group_id
			                FROM {1}.lib_erp_chart_group a
			                GROUP BY a.account_id
                        ) chart_group ON chart_group.account_id = a.account_id " & vbNewLine &
                        "LEFT JOIN {1}.lib_acc_chart_group account_group ON account_group.chart_group_id = chart_group.group_id " & vbNewLine &
                        "LEFT JOIN ( " & vbNewLine &
                        "  SELECT a.book_id,b.account_id,b.currency_id,b.project_id,b.department_id , " & vbNewLine &
                        "  IF(SUM(b.debit) > SUM(b.credit),  " & vbNewLine &
                        "    (SUM(b.debit) - SUM(b.credit)),0  " & vbNewLine &
                        "  ) AS beg_debit , " & vbNewLine & ' beg_debit
                        "  IF(SUM(b.credit) > SUM(b.debit),  " & vbNewLine &
                        "    (SUM(b.credit) - SUM(b.debit)),0  " & vbNewLine &
                        "  ) AS beg_credit , " & vbNewLine &
                        "  IF(SUM(b.debit_based) > SUM(b.credit_based),  " & vbNewLine &
                        "    (SUM(b.debit_based) - SUM(b.credit_based)),0  " & vbNewLine &
                        "  ) AS beg_debit_based , " & vbNewLine &
                        "  IF(SUM(b.credit_based) > SUM(b.debit_based),  " & vbNewLine &
                        "    (SUM(b.credit_based) - SUM(b.debit_based)),0  " & vbNewLine &
                        "  ) AS beg_credit_based
                           ,unit." & unit_code & " AS unit_code,unit." & unit_name & " AS unit_name
                           ,project.project_code,project.project_name
                           ,department.department_code,department.department_name
                        " & vbNewLine &
                        "  FROM {2}.trans_header a  " & vbNewLine &
                        "  LEFT JOIN {2}.trans_jbooks b ON b.trans_id = a.trans_id
                        LEFT JOIN " & unit_table & " unit ON unit." & unit_id & " = b." & unit_id & "
                         " & vbNewLine &
                        "  LEFT JOIN {1}.lib_erp_project project ON project.project_id = b.project_id " & vbNewLine &
                        "  LEFT JOIN {1}.lib_erp_department department ON department.department_id = b.department_id " & vbNewLine &
                        "  WHERE a.trans_date <= '{0}' AND a.book_id IN ({3})  ", txt_date_from.Value.AddDays(-1).ToString("yyyy-MM-dd"), _serverDBFS, _serverDBMain, bookIds)
                    If unitIds <> "" Then
                        If My.Settings._enableBookUnit Then
                            sql_accounts &= String.Format(" AND b.book_unit_no_id IN ({0}) ", unitIds)
                        Else
                            sql_accounts &= String.Format(" AND b.project_unit_no_id IN ({0}) ", unitIds)
                        End If
                    End If
                    'where filter
                    If currency_id <> "" Then
                        sql_accounts &= String.Format(" AND b.currency_id = {0} ", currency_id)
                    End If

                    If project_id <> "" Then
                        sql_accounts &= String.Format(" AND b.project_id = {0} ", project_id)
                    End If

                    If department_id <> "" Then
                        sql_accounts &= String.Format(" AND b.department_id = {0} ", department_id)
                    End If
                    'end of where filter

                    sql_accounts &= String.Format("GROUP BY b.account_id ")

                    'group filter
                    If currency = "2" Then
                        sql_accounts &= " ,b.currency_id "
                    End If
                    'end of group filter

                    sql_accounts &= String.Format(") d ON d.account_id = a.account_id ")
                    If currency = "2" Then
                        sql_accounts &= " AND d.currency_id = c.currency_id "
                    End If

                    sql_accounts &= String.Format("LEFT JOIN ( " & vbNewLine &
                        "  SELECT b.account_id,b.currency_id , " & vbNewLine &
                        "  SUM(b.debit) AS debit , " & vbNewLine &
                        "  SUM(b.credit) AS credit , " & vbNewLine &
                        "  SUM(b.debit_based) AS debit_based , " & vbNewLine &
                        "  SUM(b.credit_based) AS credit_based  " & vbNewLine &
                        "  FROM {2}.trans_header a  " & vbNewLine &
                        "  LEFT JOIN {2}.trans_jbooks b ON b.trans_id = a.trans_id  " & vbNewLine &
                        "  WHERE a.trans_date BETWEEN '{0}' AND '{1}' AND a.book_id IN ({3}) ", date_from, date_to, _serverDBMain, bookIds)
                    If unitIds <> "" Then
                        If My.Settings._enableBookUnit Then
                            sql_accounts &= String.Format(" AND b.book_unit_no_id IN ({0}) ", unitIds)
                        Else
                            sql_accounts &= String.Format(" AND b.project_unit_no_id IN ({0}) ", unitIds)
                        End If
                    End If
                    'where filter
                    If currency_id <> "" Then
                        sql_accounts &= String.Format(" AND b.currency_id = {0} ", currency_id)
                    End If

                    If project_id <> "" Then
                        sql_accounts &= String.Format(" AND b.project_id = {0} ", project_id)
                    End If

                    If department_id <> "" Then
                        sql_accounts &= String.Format(" AND b.department_id = {0} ", department_id)
                    End If
                    'end of where filter

                    sql_accounts &= String.Format("GROUP BY b.account_id ")

                    'group filter
                    If currency = "2" Then
                        sql_accounts &= " ,b.currency_id "
                    End If
                    'end of group filter

                    sql_accounts &= String.Format(") e ON e.account_id = a.account_id ")
                    If currency = "2" Then
                        sql_accounts &= " AND e.currency_id = c.currency_id "
                    End If

                    sql_accounts &= String.Format("LEFT JOIN {0}.lib_erp_currency f ON f.currency_id = c.currency_id " & vbNewLine &
                                                  "WHERE e.debit IS NOT NULL OR d.beg_debit IS NOT NULL " & vbNewLine &
                                                  "AND header.book_id IN ({1}) ", _serverDBFS, bookIds)

                    sql_accounts &= "GROUP BY a.account_id "
                    If currency = "2" Then
                        sql_accounts &= ",c.currency_id "
                    End If
            End Select

            If range <> "3" Then
                If currency_id <> "" Then
                    sql_accounts &= String.Format(" AND c.currency_id = {0} ", currency_id)
                End If

                If project_id <> "" Then
                    sql_accounts &= String.Format(" AND c.project_id = {0} ", project_id)
                End If

                If department_id <> "" Then
                    sql_accounts &= String.Format(" AND c.department_id = {0} ", department_id)
                End If
                sql_accounts &= String.Format(" AND _book.book_id IN ({0}) ", bookIds)
                If unitIds <> "" Then
                    If My.Settings._enableBookUnit Then
                        sql_accounts &= String.Format(" AND c.book_unit_no_id IN ({0}) ", unitIds)
                    Else
                        sql_accounts &= String.Format(" AND c.project_unit_no_id IN ({0}) ", unitIds)
                    End If
                End If
                sql_accounts &= "GROUP BY a.account_id "
                If currency <> "1" Then
                    sql_accounts &= " ,c.currency_id "
                End If
            End If

            Select Case sort
                Case "1"
                    sql_accounts &= " ORDER BY FIELD(b.chart_type,'A','L','C','I','E'),a.account_code "
                Case "2"
                    sql_accounts &= " ORDER BY account_group.chart_group_code,a.account_code "
                Case "3"
                    sql_accounts &= " ORDER BY a.account_code,FIELD(b.chart_type,'A','L','C','I','E') "
            End Select
        End If

        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin " &
                                                  "FROM sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id", _serverDBFS)

        '--printing
        sql_accounts = String.Format("SELECT * FROM ({0}) a WHERE (a.debit-a.credit <> 0 OR a.debit_based - a.credit_based <> 0)", sql_accounts)
        If range = "3" Then
            sql_accounts &= String.Format(" OR (a.beg_debit-a.beg_credit <> 0 OR a.beg_debit_based - a.beg_credit_based <> 0)")
        End If
        Dim dt As DataTable = FsQuery(sql_accounts)
        Dim dt_company As DataTable = Query(sql_company)

        ds.Tables("Company").Clear()
        ds.Tables("accounts").Clear()
        If dt_company.Rows.Count > 0 Then
            ds.Tables("Company").ImportRow(dt_company.Rows(0))
        End If

        For Each row As DataRow In dt.Rows
            If currency = "1" Or currency = "4" Then
                row.Item("debit") = row.Item("debit_based")
                row.Item("credit") = row.Item("credit_based")
                If range = "3" Then
                    row.Item("beg_debit") = row.Item("beg_debit_based")
                    row.Item("beg_credit") = row.Item("beg_credit_based")
                End If
            End If
            ds.Tables("accounts").ImportRow(row)
        Next

        If sender.name = "btnPrint" Then
            Dim dateRange As String = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
            If range = "1" Then
                dateRange = String.Format("From {0} to {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            End If
            If range = "3" Then
                dateRange = String.Format("Range with Beggining Balance From {0} to {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            End If
            If range = "3" Then
                If wComparison And currency = "2" Then
                    Dim rep As New report_trialbalance_print_3
                    rep.DataSource = ds
                    If unitIds <> "" Or Not groupByUnit.Checked Then
                        rep.header_unit.Visible = False
                        rep.header_unit.GroupFields.Clear()
                        rep.footer_unit.Visible = False
                    End If
                    If sort = "3" Then
                        rep.header_chart_class.Visible = False
                        rep.header_chart_class.GroupFields.Clear()
                        rep.footer_chart_class.Visible = False
                        rep.header_chart_group.Visible = False
                        rep.header_chart_group.GroupFields.Clear()
                        rep.footer_chart_group.Visible = False
                    End If
                    If sort = "2" Then
                        rep.header_chart_class.Visible = False
                        rep.header_chart_class.GroupFields.Clear()
                        rep.footer_chart_class.Visible = False
                    End If
                    If project_id = "" And Not withProjectDepartment.Checked Then
                        rep.header_project.Visible = False
                        rep.header_project.GroupFields.Clear()
                        rep.footer_project.Visible = False
                    End If
                    If department_id = "" And Not withProjectDepartment.Checked Then
                        rep.header_department.Visible = False
                        rep.header_department.GroupFields.Clear()
                        rep.footer_department.Visible = False
                    End If
                    If currency = "1" And currency_id = "" Then
                        rep.header_currency.Visible = False
                        rep.header_currency.GroupFields.Clear()
                        rep.footer_currency.Visible = False
                    End If
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    rep.range.Text = dateRange
                    rep.lbl1.Text = "As of " & txt_date_from.Value.AddDays(-1).ToString("MMMM dd, yyyy")
                    rep.lbl2.Text = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                    rep.lbl3.Text = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")

                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                Else
                    Dim rep As New report_trialbalance_print_2
                    rep.DataSource = ds
                    If unitIds <> "" Or Not groupByUnit.Checked Then
                        rep.header_unit.Visible = False
                        rep.header_unit.GroupFields.Clear()
                        rep.footer_unit.Visible = False
                    End If
                    If sort = "3" Then
                        rep.header_chart_class.Visible = False
                        rep.header_chart_class.GroupFields.Clear()
                        rep.footer_chart_class.Visible = False
                        rep.header_chart_group.Visible = False
                        rep.header_chart_group.GroupFields.Clear()
                        rep.footer_chart_group.Visible = False
                    End If
                    If sort = "2" Then
                        rep.header_chart_class.Visible = False
                        rep.header_chart_class.GroupFields.Clear()
                        rep.footer_chart_class.Visible = False
                    End If
                    If project_id = "" And Not withProjectDepartment.Checked Then
                        rep.header_project.Visible = False
                        rep.header_project.GroupFields.Clear()
                        rep.footer_project.Visible = False
                    End If
                    If department_id = "" And Not withProjectDepartment.Checked Then
                        rep.header_department.Visible = False
                        rep.header_department.GroupFields.Clear()
                        rep.footer_department.Visible = False
                    End If
                    If currency = "1" And currency_id = "" Then
                        rep.header_currency.Visible = False
                        rep.header_currency.GroupFields.Clear()
                        rep.footer_currency.Visible = False
                    End If
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    rep.range.Text = dateRange
                    rep.lbl1.Text = "As of " & txt_date_from.Value.AddDays(-1).ToString("MMMM dd, yyyy")
                    rep.lbl2.Text = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                    rep.lbl3.Text = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                End If
            Else
                If wComparison And currency = "2" Then
                    Dim rep As New report_trialbalance_print_1
                    rep.DataSource = ds
                    If unitIds <> "" Or Not groupByUnit.Checked Then
                        rep.header_unit.Visible = False
                        rep.header_unit.GroupFields.Clear()
                        rep.footer_unit.Visible = False
                    End If
                    If sort = "3" Then
                        rep.header_chart_class.Visible = False
                        rep.header_chart_class.GroupFields.Clear()
                        rep.footer_chart_class.Visible = False
                        rep.header_chart_group.Visible = False
                        rep.header_chart_group.GroupFields.Clear()
                        rep.footer_chart_group.Visible = False
                    End If
                    If sort = "2" Then
                        rep.header_chart_class.Visible = False
                        rep.header_chart_class.GroupFields.Clear()
                        rep.footer_chart_class.Visible = False
                    End If
                    If project_id = "" And Not withProjectDepartment.Checked Then
                        rep.header_project.Visible = False
                        rep.header_project.GroupFields.Clear()
                        rep.footer_project.Visible = False
                    End If
                    If department_id = "" And Not withProjectDepartment.Checked Then
                        rep.header_department.Visible = False
                        rep.header_department.GroupFields.Clear()
                        rep.footer_department.Visible = False
                    End If
                    If currency = "1" And currency_id = "" Then
                        rep.header_currency.Visible = False
                        rep.header_currency.GroupFields.Clear()
                        rep.footer_currency.Visible = False
                    End If
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    rep.range.Text = dateRange
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                Else
                    Dim rep As New report_trialbalance_print
                    rep.DataSource = ds
                    If unitIds <> "" Or Not groupByUnit.Checked Then
                        rep.header_unit.Visible = False
                        rep.header_unit.GroupFields.Clear()
                        rep.footer_unit.Visible = False
                    End If
                    If sort = "3" Then
                        rep.header_chart_class.Visible = False
                        rep.header_chart_class.GroupFields.Clear()
                        rep.footer_chart_class.Visible = False
                        rep.header_chart_group.Visible = False
                        rep.header_chart_group.GroupFields.Clear()
                        rep.footer_chart_group.Visible = False
                    End If
                    If sort = "2" Then
                        rep.header_chart_class.Visible = False
                        rep.header_chart_class.GroupFields.Clear()
                        rep.footer_chart_class.Visible = False
                    End If
                    If project_id = "" And Not withProjectDepartment.Checked Then
                        rep.header_project.Visible = False
                        rep.header_project.GroupFields.Clear()
                        rep.footer_project.Visible = False
                    End If
                    If department_id = "" And Not withProjectDepartment.Checked Then
                        rep.header_department.Visible = False
                        rep.header_department.GroupFields.Clear()
                        rep.footer_department.Visible = False
                    End If
                    If currency = "1" And currency_id = "" Then
                        rep.header_currency.Visible = False
                        rep.header_currency.GroupFields.Clear()
                        rep.footer_currency.Visible = False
                    End If
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    rep.range.Text = dateRange
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                End If
            End If
        Else
            'SplashScreenManager.ShowForm(GetType(SCLoad))
            Dim dicParam As New Dictionary(Of String, Object)

            Dim companyName As String = ""
            Dim dateRange As String = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
            If range = "1" Then
                dateRange = String.Format("From {0} to {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            End If
            If range = "3" Then
                dateRange = String.Format("Range with Beggining Balance From {0} to {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            End If
            If dt_company.Rows.Count > 0 Then
                companyName = dt_company.Rows(0).Item("company_name").ToString
            End If

            Dim strGroup = ""

            Dim lbl1 As String = ""
            Dim lbl2 As String = ""
            Dim lbl3 As String = ""
            If range = "3" Then
                lbl1 = "As of " & txt_date_from.Value.AddDays(-1).ToString("MMMM dd, yyyy")
                lbl2 = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy") & ""
                lbl3 = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy") & ""
            End If
            If groupByBook.Checked Then
                strGroup &= ",book_code"
            End If
            If unitIds <> "" Then
                strGroup &= ",unit_name"
            Else
                If groupByUnit.Checked Then
                    strGroup &= ",unit_name"
                End If
            End If
            If sort = "1" Then
                strGroup &= ",chart_class_name,chart_group_name"
            End If
            If sort = "2" Then
                strGroup &= ",chart_group_name"
            End If
            If withProjectDepartment.Checked Then
                strGroup &= ",project_name,department_name"
            Else
                If project_id <> "" Then
                    strGroup &= ",project_name"
                End If
                If department_id <> "" Then
                    strGroup &= ",department_id"
                End If
            End If
            dicParam.Add("withComparison", False)
            If currency = "2" Then
                strGroup &= ",currency_name"
                If withComparison.Checked Then
                    dicParam.Item("withComparison") = True
                End If
            End If
            dicParam.Add("ds", ds)
            dicParam.Add("companyName", companyName)
            dicParam.Add("reportTitle", "TRIAL BALANCE")
            dicParam.Add("dateRange", dateRange)
            dicParam.Add("rangeType", range)
            Dim lst As New List(Of Object)
            If strGroup <> "" Then
                dicParam.Add("strGroup", strGroup.Substring(1))
                lst = groupDataTableToList(ds.Tables("accounts"), strGroup.Substring(1))
            Else
                dicParam.Add("strGroup", strGroup)
            End If
            dicParam.Add("list", lst)
            If lbl1 <> "" Then
                dicParam.Add("lbl1", lbl1)
                dicParam.Add("lbl2", lbl2)
                dicParam.Add("lbl3", lbl3)
            End If
            dicParam.Add("groupByBook", groupByBook.Checked)
            Dim debit = ds.Tables("accounts").Compute("SUM(debit)", Nothing)
            Dim credit = ds.Tables("accounts").Compute("SUM(credit)", Nothing)
            Dim debit_based = ds.Tables("accounts").Compute("SUM(debit)", Nothing)
            Dim credit_based = ds.Tables("accounts").Compute("SUM(credit)", Nothing)
            Dim diff = debit - credit
            Dim diff_based = debit_based - credit_based
            Dim amt_based = String.Format("{0:n2}", diff_based)
            If diff_based <> 0 Then
                MsgBox(String.Format("Imbalance TrialBalance : {0:n6}", diff_based))
            End If
            Try
                lblLoad.Visible = True
                ExcelReport(dicParam)
                MsgBox("Report Done")
                lblLoad.Visible = False
            Catch ex As Exception
                lblLoad.Visible = False
                MsgBox(String.Format("Error Occured : {0}", ex.Message))
                MyDebugging.AddText(ex.Message)
            End Try
            ' 2019-01-02
            '' - Excel
            'Dim templateName As String = ""
            'Dim companyName As String = ""
            'Dim dateRange As String = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
            'If dt_company.Rows.Count > 0 Then
            '    companyName = dt_company.Rows(0).Item("company_name").ToString
            'End If
            'If range = "3" Then
            '    Dim lbl1 = "As of " & txt_date_from.Value.AddDays(-1).ToString("MMMM dd, yyyy")
            '    Dim lbl2 = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy") & ""
            '    Dim lbl3 = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy") & ""
            '    Dim strGroup As String = "currency_name"
            '    If sort = "2" Then
            '        strGroup = "chart_group_name," & strGroup
            '    End If
            '    If wComparison And currency = "2" Then
            '        Dim listAccount = groupDataTableToList(ds.Tables("accounts"), strGroup)
            '        excelTrialBalance1(ds, "TrialBalance4.xlt", companyName, lbl1, lbl2, lbl3, listAccount, strGroup, True, True)
            '        MsgBox("Data Succesfully Load")
            '    Else
            '        If currency = "2" Then
            '            Dim listAccount = groupDataTableToList(ds.Tables("accounts"), strGroup)
            '            excelTrialBalance1(ds, "TrialBalance4.xlt", companyName, lbl1, lbl2, lbl3, listAccount, strGroup, True)
            '            MsgBox("Data Succesfully Load")
            '        Else
            '            strGroup = "book_name"
            '            If sort = "2" Then
            '                strGroup = "chart_group_name," & strGroup
            '            End If
            '            Dim listAccount = groupDataTableToList(ds.Tables("accounts"), strGroup)
            '            excelTrialBalance1(ds, "TrialBalance4.xlt", companyName, lbl1, lbl2, lbl3, listAccount, strGroup)
            '            MsgBox("Data Succesfully Load")
            '        End If
            '    End If
            'Else
            '    Dim strGroup As String = "currency_name"
            '    If sort = "2" Then
            '        strGroup = "chart_group_name," & strGroup
            '    End If
            '    If wComparison And currency = "2" Then
            '        Dim listAccount = groupDataTableToList(ds.Tables("accounts"), strGroup)
            '        excelTrialBalance(ds, "TrialBalance2.xlt", companyName, dateRange, listAccount, strGroup, True, True)
            '        MsgBox("Data Succesfully Load")
            '    Else
            '        If currency = "2" Then
            '            Dim listAccount = groupDataTableToList(ds.Tables("accounts"), strGroup)
            '            excelTrialBalance(ds, "TrialBalance.xlt", companyName, dateRange, listAccount, strGroup, True)
            '            MsgBox("Data Succesfully Load")
            '        Else
            '            If sort = "2" Then
            '                Dim listAccount = groupDataTableToList(ds.Tables("accounts"), "chart_group_name")
            '                excelTrialBalance(ds, "TrialBalance.xlt", companyName, dateRange, listAccount, "chart_group_name", True)
            '                MsgBox("Data Succesfully Load")
            '            Else
            '                excelTrialBalance(ds, "TrialBalance.xlt", companyName, dateRange)
            '                MsgBox("Data Succesfully Load")
            '            End If
            '        End If
            '    End If
            'End If
            'SplashScreenManager.CloseForm()
            'MsgBox("Report Done")
        End If
    End Sub
    ''' <summary>
    ''' Generate Trial Balance to Excel : 2019-01-02
    ''' </summary>
    ''' <param name="dicOption">Parameter to Generate the Report</param>
    Private Sub ExcelReport(ByVal dicOption As Dictionary(Of String, Object))
        Dim ds As DataSet = dicOption.Item("ds")
        Dim list As List(Of Object) = dicOption.Item("list")
        Dim strGroup As String = dicOption.Item("strGroup")
        Dim companyName As String = dicOption.Item("companyName")
        Dim reportTitle As String = dicOption.Item("reportTitle")
        Dim dateRange As String = dicOption.Item("dateRange")
        Dim rangeType As String = dicOption.Item("rangeType")
        Dim groupByBook As Boolean = dicOption.Item("groupByBook")
        Dim withComparison As Boolean = dicOption.Item("withComparison")

        Dim lbl1 As String = ""
        Dim lbl2 As String = ""
        Dim lbl3 As String = ""
        If dicOption.ContainsKey("lbl1") Then
            lbl1 = dicOption.Item("lbl1")
            lbl2 = dicOption.Item("lbl2")
            lbl3 = dicOption.Item("lbl3")
        End If

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.DisplayAlerts = False
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add()

        Dim currentRow As Integer = 6
        If groupByBook Then
            Dim tabCtr As Integer = 0
            Dim lastCol As Integer = 5
            If rangeType = "3" Then
                lastCol = 9
                If withComparison Then
                    lastCol = 15
                End If
            Else
                If withComparison Then
                    lastCol = 7
                End If
            End If
            dicOption.Add("lastCol", lastCol)
            For Each item In list
                currentRow = 6
                Dim currentIndex As Integer = 1
                Dim bookCode As String = item.Item("book_code").ToString
                Dim bookName As String = ""
                Dim drs = ds.Tables("lib_erp_book").Select(String.Format("book_code = '{0}'", bookCode))
                If drs.Length > 0 Then
                    bookName = drs(0).Item("book_name").ToString
                End If
                tabCtr += 1
                If xlWorkBook.Worksheets.Count < tabCtr Then
                    xlWorkBook.Worksheets.Add()
                End If
                xlWorkSheet = xlWorkBook.Worksheets(1)
                xlWorkSheet.Name = bookCode
                xlWorkSheet.Cells(1, 1) = companyName
                xlWorkSheet.Cells(2, 1) = String.Format("TRIAL BALANCE - {0}", bookName)
                xlWorkSheet.Cells(3, 1) = dateRange
                If rangeType = "3" Then
                    If withComparison Then
                        xlWorkSheet.Cells(4, 1) = "CODE"
                        xlWorkSheet.Cells(4, 2) = "TITLE"
                        xlWorkSheet.Cells(4, 3) = dicOption.Item("lbl1")
                        xlWorkSheet.Cells(4, 7) = dicOption.Item("lbl2")
                        xlWorkSheet.Cells(4, 11) = dicOption.Item("lbl3")
                        xlWorkSheet.Cells(4, 15) = "TYPE"
                        xlWorkSheet.Cells(5, 3) = "DEBIT"
                        xlWorkSheet.Cells(5, 4) = "CREDIT"
                        xlWorkSheet.Cells(5, 5) = "DEBIT BASED"
                        xlWorkSheet.Cells(5, 6) = "CREDIT BASED"
                        xlWorkSheet.Cells(5, 7) = "DEBIT"
                        xlWorkSheet.Cells(5, 8) = "CREDIT"
                        xlWorkSheet.Cells(5, 9) = "DEBIT BASED"
                        xlWorkSheet.Cells(5, 10) = "CREDIT BASED"
                        xlWorkSheet.Cells(5, 11) = "DEBIT"
                        xlWorkSheet.Cells(5, 12) = "CREDIT"
                        xlWorkSheet.Cells(5, 13) = "DEBIT BASED"
                        xlWorkSheet.Cells(5, 14) = "CREDIT BASED"
                        ExcelRange(xlWorkSheet, 4, 1, 5, 1).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 2, 5, 2).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 3, 4, 6).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 7, 4, 10).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 11, 4, 14).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Font.Bold = True
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    Else
                        xlWorkSheet.Cells(4, 1) = "CODE"
                        xlWorkSheet.Cells(4, 2) = "TITLE"
                        xlWorkSheet.Cells(4, 3) = dicOption.Item("lbl1")
                        xlWorkSheet.Cells(4, 5) = dicOption.Item("lbl2")
                        xlWorkSheet.Cells(4, 7) = dicOption.Item("lbl3")
                        xlWorkSheet.Cells(4, 9) = "TYPE"
                        xlWorkSheet.Cells(5, 3) = "DEBIT"
                        xlWorkSheet.Cells(5, 4) = "CREDIT"
                        xlWorkSheet.Cells(5, 5) = "DEBIT"
                        xlWorkSheet.Cells(5, 6) = "CREDIT"
                        xlWorkSheet.Cells(5, 7) = "DEBIT"
                        xlWorkSheet.Cells(5, 8) = "CREDIT"
                        ExcelRange(xlWorkSheet, 4, 1, 5, 1).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 2, 5, 2).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 3, 4, 4).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 5, 4, 6).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 7, 4, 8).MergeCells = True
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Font.Bold = True
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    End If
                Else
                    If withComparison Then
                        xlWorkSheet.Cells(5, 1) = "CODE"
                        xlWorkSheet.Cells(5, 2) = "TITLE"
                        xlWorkSheet.Cells(5, 3) = "DEBIT"
                        xlWorkSheet.Cells(5, 4) = "CREDIT"
                        xlWorkSheet.Cells(5, 5) = "DEBIT BASED"
                        xlWorkSheet.Cells(5, 6) = "CREDIT BASED"
                        xlWorkSheet.Cells(5, 7) = "TYPE"
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Font.Bold = True
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    Else
                        xlWorkSheet.Cells(5, 1) = "CODE"
                        xlWorkSheet.Cells(5, 2) = "TITLE"
                        xlWorkSheet.Cells(5, 3) = "DEBIT"
                        xlWorkSheet.Cells(5, 4) = "CREDIT"
                        xlWorkSheet.Cells(5, 5) = "TYPE"
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Font.Bold = True
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    End If
                End If

                If item.ContainsKey("grouped") Then
                    ExcelReportDetailed(dicOption, item.Item("grouped"), currentIndex, xlWorkSheet, currentRow)
                Else
                    ExcelReportDetailed(dicOption, item.Item("datas"), currentIndex, xlWorkSheet, currentRow)
                End If

                ExcelRange(xlWorkSheet, 1, 1,, lastCol).MergeCells = True
                ExcelRange(xlWorkSheet, 2, 1,, lastCol).MergeCells = True
                ExcelRange(xlWorkSheet, 3, 1,, lastCol).MergeCells = True
                ExcelRange(xlWorkSheet, 1, 1, 3, lastCol).Font.Bold = True
                ExcelRange(xlWorkSheet, 1, 1, 3, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                ExcelRange(xlWorkSheet, 1, 1, 3, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                ExcelRange(xlWorkSheet, 1, 1).ColumnWidth = 15
                ExcelRange(xlWorkSheet, 1, 2).ColumnWidth = 50
                ExcelRange(xlWorkSheet, 1, 3,, lastCol - 1).ColumnWidth = 15
                ExcelRange(xlWorkSheet, 1, lastCol).ColumnWidth = 10

                xlWorkSheet.Cells(currentRow, 1) = "GRAND TOTAL "
                ExcelRange(xlWorkSheet, currentRow, 1,, 2).MergeCells = True
                ExcelRange(xlWorkSheet, currentRow, 1,, lastCol).Font.Bold = True
                ExcelRange(xlWorkSheet, currentRow, 1, , lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                ExcelRange(xlWorkSheet, 6, 3, currentRow, lastCol).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Cells(currentRow, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", 6, currentRow - 1)
                xlWorkSheet.Cells(currentRow, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", 6, currentRow - 1)
                If rangeType = "3" Then
                    xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", 6, currentRow - 1)
                    If withComparison Then
                        xlWorkSheet.Cells(currentRow, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", 6, currentRow - 1)
                        xlWorkSheet.Cells(currentRow, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", 6, currentRow - 1)
                        xlWorkSheet.Cells(currentRow, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", 6, currentRow - 1)
                        xlWorkSheet.Cells(currentRow, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", 6, currentRow - 1)
                        xlWorkSheet.Cells(currentRow, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", 6, currentRow - 1)
                        xlWorkSheet.Cells(currentRow, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", 6, currentRow - 1)
                    End If
                Else
                    If withComparison Then
                        xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", 6, currentRow - 1)
                        xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", 6, currentRow - 1)
                    End If
                End If
            Next
        Else
            If xlWorkBook.Worksheets.Count <= 0 Then
                xlWorkBook.Worksheets.Add()
            End If
            xlWorkSheet = xlWorkBook.Worksheets(1)
            xlWorkSheet.Cells(1, 1) = companyName
            xlWorkSheet.Cells(2, 1) = reportTitle
            xlWorkSheet.Cells(3, 1) = dateRange
            Dim currentIndex As Integer = 0
            Dim lastCol As Integer = 5
            If rangeType = "3" Then
                lastCol = 9
                If withComparison Then
                    lastCol = 15
                End If
            Else
                If withComparison Then
                    lastCol = 7
                End If
            End If
            dicOption.Add("lastCol", lastCol)
            If rangeType = "3" Then
                If withComparison Then
                    xlWorkSheet.Cells(4, 1) = "CODE"
                    xlWorkSheet.Cells(4, 2) = "TITLE"
                    xlWorkSheet.Cells(4, 3) = dicOption.Item("lbl1")
                    xlWorkSheet.Cells(4, 7) = dicOption.Item("lbl2")
                    xlWorkSheet.Cells(4, 11) = dicOption.Item("lbl3")
                    xlWorkSheet.Cells(4, 15) = "TYPE"
                    xlWorkSheet.Cells(5, 3) = "DEBIT"
                    xlWorkSheet.Cells(5, 4) = "CREDIT"
                    xlWorkSheet.Cells(5, 5) = "DEBIT BASED"
                    xlWorkSheet.Cells(5, 6) = "CREDIT BASED"
                    xlWorkSheet.Cells(5, 7) = "DEBIT"
                    xlWorkSheet.Cells(5, 8) = "CREDIT"
                    xlWorkSheet.Cells(5, 9) = "DEBIT BASED"
                    xlWorkSheet.Cells(5, 10) = "CREDIT BASED"
                    xlWorkSheet.Cells(5, 11) = "DEBIT"
                    xlWorkSheet.Cells(5, 12) = "CREDIT"
                    xlWorkSheet.Cells(5, 13) = "DEBIT BASED"
                    xlWorkSheet.Cells(5, 14) = "CREDIT BASED"
                    ExcelRange(xlWorkSheet, 4, 1, 5, 1).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 2, 5, 2).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 3, 4, 6).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 7, 4, 10).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 11, 4, 14).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Font.Bold = True
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                Else
                    xlWorkSheet.Cells(4, 1) = "CODE"
                    xlWorkSheet.Cells(4, 2) = "TITLE"
                    xlWorkSheet.Cells(4, 3) = dicOption.Item("lbl1")
                    xlWorkSheet.Cells(4, 5) = dicOption.Item("lbl2")
                    xlWorkSheet.Cells(4, 7) = dicOption.Item("lbl3")
                    xlWorkSheet.Cells(4, 9) = "TYPE"
                    xlWorkSheet.Cells(5, 3) = "DEBIT"
                    xlWorkSheet.Cells(5, 4) = "CREDIT"
                    xlWorkSheet.Cells(5, 5) = "DEBIT"
                    xlWorkSheet.Cells(5, 6) = "CREDIT"
                    xlWorkSheet.Cells(5, 7) = "DEBIT"
                    xlWorkSheet.Cells(5, 8) = "CREDIT"
                    ExcelRange(xlWorkSheet, 4, 1, 5, 1).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 2, 5, 2).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 3, 4, 4).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 5, 4, 6).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 7, 4, 8).MergeCells = True
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Font.Bold = True
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                End If
            Else
                If withComparison Then
                    xlWorkSheet.Cells(5, 1) = "CODE"
                    xlWorkSheet.Cells(5, 2) = "TITLE"
                    xlWorkSheet.Cells(5, 3) = "DEBIT"
                    xlWorkSheet.Cells(5, 4) = "CREDIT"
                    xlWorkSheet.Cells(5, 5) = "DEBIT BASED"
                    xlWorkSheet.Cells(5, 6) = "CREDIT BASED"
                    xlWorkSheet.Cells(5, 7) = "TYPE"
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Font.Bold = True
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                Else
                    xlWorkSheet.Cells(5, 1) = "CODE"
                    xlWorkSheet.Cells(5, 2) = "TITLE"
                    xlWorkSheet.Cells(5, 3) = "DEBIT"
                    xlWorkSheet.Cells(5, 4) = "CREDIT"
                    xlWorkSheet.Cells(5, 5) = "TYPE"
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Font.Bold = True
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 5, 1, 5, lastCol).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                End If
            End If
            ExcelReportDetailed(dicOption, list, currentIndex, xlWorkSheet, currentRow)

            ExcelRange(xlWorkSheet, 1, 1,, lastCol).MergeCells = True
            ExcelRange(xlWorkSheet, 2, 1,, lastCol).MergeCells = True
            ExcelRange(xlWorkSheet, 3, 1,, lastCol).MergeCells = True
            ExcelRange(xlWorkSheet, 1, 1, 3, lastCol).Font.Bold = True
            ExcelRange(xlWorkSheet, 1, 1, 3, lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            ExcelRange(xlWorkSheet, 1, 1, 3, lastCol).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            xlWorkSheet.Cells(currentRow, 1) = "GRAND TOTAL "
            ExcelRange(xlWorkSheet, currentRow, 1,, 2).MergeCells = True
            ExcelRange(xlWorkSheet, currentRow, 1,, lastCol).Font.Bold = True
            ExcelRange(xlWorkSheet, currentRow, 1, , lastCol).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            ExcelRange(xlWorkSheet, 6, 3, currentRow, lastCol).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"

            ExcelRange(xlWorkSheet, 1, 1).ColumnWidth = 15
            ExcelRange(xlWorkSheet, 1, 2).ColumnWidth = 50
            ExcelRange(xlWorkSheet, 1, 3,, lastCol - 1).ColumnWidth = 15
            ExcelRange(xlWorkSheet, 1, lastCol).ColumnWidth = 10

            xlWorkSheet.Cells(currentRow, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", 6, currentRow - 1)
            xlWorkSheet.Cells(currentRow, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", 6, currentRow - 1)
            If rangeType = "3" Then
                xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", 6, currentRow - 1)
                xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", 6, currentRow - 1)
                xlWorkSheet.Cells(currentRow, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", 6, currentRow - 1)
                xlWorkSheet.Cells(currentRow, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", 6, currentRow - 1)
                If withComparison Then
                    xlWorkSheet.Cells(currentRow, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", 6, currentRow - 1)
                End If
            Else
                If withComparison Then
                    xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", 6, currentRow - 1)
                    xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", 6, currentRow - 1)
                End If
            End If
        End If
    End Sub
    Private Sub ExcelReportDetailed(ByVal dicOption As Dictionary(Of String, Object), ByVal obj As Object, ByRef currentIndex As Integer, ByRef xlWorkSheet As Excel.Worksheet, ByRef currentRow As Integer)
        Dim lastCol As Integer = dicOption.Item("lastCol")
        If obj IsNot Nothing And obj.Count > 0 Then
            Dim lstField = dicOption.Item("strGroup").ToString.Split(",")
            Dim isDetailed As Boolean = True
            If TypeOf obj Is List(Of Object) Then
                Dim lst As List(Of Object) = obj
                For Each item In lst
                    If item.ContainsKey("grouped") Then
                        Dim groupField As String = lstField(currentIndex)
                        Dim groupName As String = item.Item(groupField).ToString
                        Dim firstRow As Integer = currentRow
                        Dim lastRow As Integer = currentRow
                        If groupField <> "chart_group_name" Then
                            MyDebugging.AddText(groupField)
                            MyDebugging.AddText(groupName)
                            xlWorkSheet.Cells(currentRow, 1) = groupName
                            ExcelRange(xlWorkSheet, currentRow, 1).IndentLevel = currentIndex * 5
                            ExcelRange(xlWorkSheet, currentRow, 1).Font.Bold = True
                            currentRow += 1
                        End If
                        currentIndex += 1
                        ExcelReportDetailed(dicOption, item.Item("grouped"), currentIndex, xlWorkSheet, currentRow)
                        lastRow = currentRow - 1
                        currentIndex -= 1
                        If groupField <> "chart_group_name" Then
                            xlWorkSheet.Cells(currentRow, 1) = "Sub-Total " & groupName
                            xlWorkSheet.Cells(currentRow, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstRow, lastRow)
                            xlWorkSheet.Cells(currentRow, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstRow, lastRow)
                            ExcelRange(xlWorkSheet, currentRow, 1,, 4).Font.Bold = True
                            If dicOption.Item("rangeType") = "3" Then
                                xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", firstRow, lastRow)
                                ExcelRange(xlWorkSheet, currentRow, 1,, 8).Font.Bold = True
                                If dicOption.Item("withComparison") Then
                                    xlWorkSheet.Cells(currentRow, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", firstRow, lastRow)
                                    ExcelRange(xlWorkSheet, currentRow, 1,, 14).Font.Bold = True
                                End If
                            Else
                                If dicOption.Item("withComparison") Then
                                    xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstRow, lastRow)
                                    ExcelRange(xlWorkSheet, currentRow, 1,, 6).Font.Bold = True
                                End If
                            End If
                            currentRow += 1
                        End If
                        'ExcelRange(xlWorkSheet, currentRow, 1).IndentLevel = currentIndex * 5
                        isDetailed = False
                    End If
                    If item.ContainsKey("datas") Then
                        Dim groupField As String = lstField(currentIndex)
                        Dim groupName As String = item.Item(groupField).ToString
                        Dim firstRow As Integer = currentRow
                        Dim lastRow As Integer = currentRow
                        If groupField <> "chart_group_name" Then
                            xlWorkSheet.Cells(currentRow, 1) = groupName
                            ExcelRange(xlWorkSheet, currentRow, 1).IndentLevel = currentIndex * 5
                            ExcelRange(xlWorkSheet, currentRow, 1).Font.Bold = True
                            currentRow += 1
                        End If
                        For Each i In item.Item("datas")
                            ExcelReportDetailed(dicOption, i, currentIndex, xlWorkSheet, currentRow)
                        Next
                        If groupField <> "chart_group_name" Then
                            lastRow = currentRow - 1
                            xlWorkSheet.Cells(currentRow, 1) = "Sub-Total " & groupName
                            'ExcelRange(xlWorkSheet, currentRow, 1).IndentLevel = currentIndex * 5
                            xlWorkSheet.Cells(currentRow, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstRow, lastRow)
                            xlWorkSheet.Cells(currentRow, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstRow, lastRow)
                            ExcelRange(xlWorkSheet, currentRow, 1,, 4).Font.Bold = True
                            If dicOption.Item("rangeType") = "3" Then
                                xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", firstRow, lastRow)
                                ExcelRange(xlWorkSheet, currentRow, 1,, 8).Font.Bold = True
                                If dicOption.Item("withComparison") Then
                                    xlWorkSheet.Cells(currentRow, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", firstRow, lastRow)
                                    ExcelRange(xlWorkSheet, currentRow, 1,, 14).Font.Bold = True
                                End If
                            Else
                                If dicOption.Item("withComparison") Then
                                    xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstRow, lastRow)
                                    xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstRow, lastRow)
                                    ExcelRange(xlWorkSheet, currentRow, 1,, 6).Font.Bold = True
                                End If
                            End If
                            currentRow += 1
                        End If
                        isDetailed = False
                    End If
                    If isDetailed Then
                        xlWorkSheet.Cells(currentRow, 1) = "'" & item.Item("account_code")
                        xlWorkSheet.Cells(currentRow, 2) = item.Item("account_name")
                        xlWorkSheet.Cells(currentRow, 3) = item.Item("debit")
                        xlWorkSheet.Cells(currentRow, 4) = item.Item("credit")
                        If dicOption.Item("rangeType") = "3" Then
                            If dicOption.Item("withComparison") Then
                                xlWorkSheet.Cells(currentRow, 3) = item.Item("beg_debit")
                                xlWorkSheet.Cells(currentRow, 4) = item.Item("beg_credit")
                                xlWorkSheet.Cells(currentRow, 5) = item.Item("beg_debit_based")
                                xlWorkSheet.Cells(currentRow, 6) = item.Item("beg_credit_based")
                                xlWorkSheet.Cells(currentRow, 7) = item.Item("debit")
                                xlWorkSheet.Cells(currentRow, 8) = item.Item("credit")
                                xlWorkSheet.Cells(currentRow, 9) = item.Item("debit_based")
                                xlWorkSheet.Cells(currentRow, 10) = item.Item("credit_based")
                                Dim amt = (ifNull(item.Item("beg_debit"), 0) - ifNull(item.Item("beg_credit"), 0)) + (ifNull(item.Item("debit"), 0) - ifNull(item.Item("credit"), 0))
                                Dim amt_based = (ifNull(item.Item("beg_debit_based"), 0) - ifNull(item.Item("beg_credit_based"), 0)) + (ifNull(item.Item("debit_based"), 0) - ifNull(item.Item("credit_based"), 0))
                                xlWorkSheet.Cells(currentRow, 11) = If(amt > 0, amt, 0)
                                xlWorkSheet.Cells(currentRow, 12) = If(amt < 0, amt * -1, 0)
                                xlWorkSheet.Cells(currentRow, 13) = If(amt_based > 0, amt_based, 0)
                                xlWorkSheet.Cells(currentRow, 14) = If(amt_based < 0, amt_based * -1, 0)
                                xlWorkSheet.Cells(currentRow, 15) = item.Item("chart_type")
                            Else
                                xlWorkSheet.Cells(currentRow, 3) = item.Item("beg_debit")
                                xlWorkSheet.Cells(currentRow, 4) = item.Item("beg_credit")
                                xlWorkSheet.Cells(currentRow, 5) = item.Item("debit")
                                xlWorkSheet.Cells(currentRow, 6) = item.Item("credit")
                                Dim amt = (ifNull(item.Item("beg_debit"), 0) - ifNull(item.Item("beg_credit"), 0)) + (ifNull(item.Item("debit"), 0) - ifNull(item.Item("credit"), 0))
                                xlWorkSheet.Cells(currentRow, 7) = If(amt > 0, amt, 0)
                                xlWorkSheet.Cells(currentRow, 8) = If(amt < 0, amt * -1, 0)
                                xlWorkSheet.Cells(currentRow, 9) = item.Item("chart_type")
                            End If
                        Else
                            If dicOption.Item("withComparison") Then
                                xlWorkSheet.Cells(currentRow, 5) = item.Item("debit_based")
                                xlWorkSheet.Cells(currentRow, 6) = item.Item("credit_based")
                                xlWorkSheet.Cells(currentRow, 7) = item.Item("chart_type")
                            Else
                                xlWorkSheet.Cells(currentRow, 5) = item.Item("chart_type")
                            End If
                        End If
                        currentRow += 1
                    End If
                Next
            Else
                If obj.ContainsKey("grouped") Then
                    Dim groupField As String = lstField(currentIndex)
                    Dim groupName As String = obj.Item(groupField).ToString
                    Dim firstRow As Integer = currentRow
                    Dim lastRow As Integer = currentRow
                    xlWorkSheet.Cells(currentRow, 1) = groupName
                    If groupField <> "chart_group_name" Then
                        ExcelRange(xlWorkSheet, currentRow, 1).IndentLevel = currentIndex * 5
                        ExcelRange(xlWorkSheet, currentRow, 1).Font.Bold = True
                        currentRow += 1
                    End If
                    currentIndex += 1
                    ExcelReportDetailed(dicOption, obj.Item("grouped"), currentIndex, xlWorkSheet, currentRow)
                    lastRow = currentRow - 1
                    currentIndex -= 1
                    If groupField <> "" Then
                        xlWorkSheet.Cells(currentRow, 1) = "Sub-Total " & groupName
                        'ExcelRange(xlWorkSheet, currentRow, 1).IndentLevel = currentIndex * 5
                        xlWorkSheet.Cells(currentRow, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstRow, lastRow)
                        xlWorkSheet.Cells(currentRow, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstRow, lastRow)
                        ExcelRange(xlWorkSheet, currentRow, 1,, 4).Font.Bold = True
                        If dicOption.Item("rangeType") = "3" Then
                            xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstRow, lastRow)
                            xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstRow, lastRow)
                            xlWorkSheet.Cells(currentRow, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", firstRow, lastRow)
                            xlWorkSheet.Cells(currentRow, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", firstRow, lastRow)
                            ExcelRange(xlWorkSheet, currentRow, 1,, 8).Font.Bold = True
                            If dicOption.Item("withComparison") Then
                                xlWorkSheet.Cells(currentRow, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", firstRow, lastRow)
                                ExcelRange(xlWorkSheet, currentRow, 1,, 14).Font.Bold = True
                            End If
                        Else
                            If dicOption.Item("withComparison") Then
                                xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstRow, lastRow)
                                ExcelRange(xlWorkSheet, currentRow, 1,, 6).Font.Bold = True
                            End If
                        End If
                        currentRow += 1
                    End If
                    isDetailed = False
                End If
                If obj.ContainsKey("datas") Then
                    Dim groupField As String = lstField(currentIndex)
                    Dim groupName As String = obj.Item(groupField).ToString
                    Dim firstRow As Integer = currentRow
                    Dim lastRow As Integer = currentRow
                    If groupField <> "chart_group_name" Then
                        xlWorkSheet.Cells(currentRow, 1) = groupName
                        ExcelRange(xlWorkSheet, currentRow, 1).IndentLevel = currentIndex * 5
                        ExcelRange(xlWorkSheet, currentRow, 1).Font.Bold = True
                        currentRow += 1
                    End If
                    For Each i In obj.Item("datas")
                        ExcelReportDetailed(dicOption, i, currentIndex, xlWorkSheet, currentRow)
                    Next
                    If groupField <> "chart_group_name" Then
                        lastRow = currentRow - 1
                        xlWorkSheet.Cells(currentRow, 1) = "Sub-Total " & groupName
                        'ExcelRange(xlWorkSheet, currentRow, 1,, 4).IndentLevel = currentIndex * 5
                        xlWorkSheet.Cells(currentRow, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstRow, lastRow)
                        xlWorkSheet.Cells(currentRow, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstRow, lastRow)
                        ExcelRange(xlWorkSheet, currentRow, 1,, 4).Font.Bold = True
                        If dicOption.Item("rangeType") = "3" Then
                            xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstRow, lastRow)
                            xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstRow, lastRow)
                            xlWorkSheet.Cells(currentRow, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", firstRow, lastRow)
                            xlWorkSheet.Cells(currentRow, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", firstRow, lastRow)
                            ExcelRange(xlWorkSheet, currentRow, 1,, 4).Font.Bold = True
                            If dicOption.Item("withComparison") Then
                                xlWorkSheet.Cells(currentRow, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 14) = String.Format("=SUBTOTAL(9,N{0}:N{1})", firstRow, lastRow)
                                ExcelRange(xlWorkSheet, currentRow, 1,, 14).Font.Bold = True
                            End If
                        Else
                            If dicOption.Item("withComparison") Then
                                xlWorkSheet.Cells(currentRow, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstRow, lastRow)
                                xlWorkSheet.Cells(currentRow, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", firstRow, lastRow)
                                ExcelRange(xlWorkSheet, currentRow, 1,, 6).Font.Bold = True
                            End If
                        End If
                        currentRow += 1
                    End If
                    isDetailed = False
                End If
                If isDetailed Then
                    xlWorkSheet.Cells(currentRow, 1) = "'" & obj.Item("account_code")
                    xlWorkSheet.Cells(currentRow, 2) = obj.Item("account_name")
                    xlWorkSheet.Cells(currentRow, 3) = obj.Item("debit")
                    xlWorkSheet.Cells(currentRow, 4) = obj.Item("credit")
                    If dicOption.Item("rangeType") = "3" Then
                        If dicOption.Item("withComparison") Then
                            xlWorkSheet.Cells(currentRow, 3) = obj.Item("beg_debit")
                            xlWorkSheet.Cells(currentRow, 4) = obj.Item("beg_credit")
                            xlWorkSheet.Cells(currentRow, 5) = obj.Item("beg_debit_based")
                            xlWorkSheet.Cells(currentRow, 6) = obj.Item("beg_credit_based")
                            xlWorkSheet.Cells(currentRow, 7) = obj.Item("debit")
                            xlWorkSheet.Cells(currentRow, 8) = obj.Item("credit")
                            xlWorkSheet.Cells(currentRow, 9) = obj.Item("debit_based")
                            xlWorkSheet.Cells(currentRow, 10) = obj.Item("credit_based")
                            Dim amt = (ifNull(obj.Item("beg_debit"), 0) - ifNull(obj.Item("beg_credit"), 0)) + (ifNull(obj.Item("debit"), 0) - ifNull(obj.Item("credit"), 0))
                            Dim amt_based = (ifNull(obj.Item("beg_debit_based"), 0) - ifNull(obj.Item("beg_credit_based"), 0)) + (ifNull(obj.Item("debit_based"), 0) - ifNull(obj.Item("credit_based"), 0))
                            xlWorkSheet.Cells(currentRow, 11) = If(amt > 0, amt, 0)
                            xlWorkSheet.Cells(currentRow, 12) = If(amt < 0, amt * -1, 0)
                            xlWorkSheet.Cells(currentRow, 13) = If(amt_based > 0, amt_based, 0)
                            xlWorkSheet.Cells(currentRow, 14) = If(amt_based < 0, amt_based * -1, 0)
                            xlWorkSheet.Cells(currentRow, 15) = obj.Item("chart_type")
                        Else
                            xlWorkSheet.Cells(currentRow, 3) = obj.Item("beg_debit")
                            xlWorkSheet.Cells(currentRow, 4) = obj.Item("beg_credit")
                            xlWorkSheet.Cells(currentRow, 5) = obj.Item("debit")
                            xlWorkSheet.Cells(currentRow, 6) = obj.Item("credit")
                            Dim amt = (ifNull(obj.Item("beg_debit"), 0) - ifNull(obj.Item("beg_credit"), 0)) + (ifNull(obj.Item("debit"), 0) - ifNull(obj.Item("credit"), 0))
                            xlWorkSheet.Cells(currentRow, 7) = If(amt > 0, amt, 0)
                            xlWorkSheet.Cells(currentRow, 8) = If(amt < 0, amt * -1, 0)
                            xlWorkSheet.Cells(currentRow, 9) = obj.Item("chart_type")
                        End If
                    Else
                        If dicOption.Item("withComparison") Then
                            xlWorkSheet.Cells(currentRow, 5) = obj.Item("debit_based")
                            xlWorkSheet.Cells(currentRow, 6) = obj.Item("credit_based")
                            xlWorkSheet.Cells(currentRow, 7) = obj.Item("chart_type")
                        Else
                            xlWorkSheet.Cells(currentRow, 5) = obj.Item("chart_type")
                        End If
                    End If
                    currentRow += 1
                End If
            End If
        Else
            For Each dr As DataRow In ds.Tables("accounts").Rows
                xlWorkSheet.Cells(currentRow, 1) = "'" & dr.Item("account_code")
                xlWorkSheet.Cells(currentRow, 2) = dr.Item("account_name")
                xlWorkSheet.Cells(currentRow, 3) = dr.Item("debit")
                xlWorkSheet.Cells(currentRow, 4) = dr.Item("credit")
                If dicOption.Item("rangeType") = "3" Then
                    If dicOption.Item("withComparison") Then
                        xlWorkSheet.Cells(currentRow, 3) = dr.Item("beg_debit")
                        xlWorkSheet.Cells(currentRow, 4) = dr.Item("beg_credit")
                        xlWorkSheet.Cells(currentRow, 5) = dr.Item("beg_debit_based")
                        xlWorkSheet.Cells(currentRow, 6) = dr.Item("beg_credit_based")
                        xlWorkSheet.Cells(currentRow, 7) = dr.Item("debit")
                        xlWorkSheet.Cells(currentRow, 8) = dr.Item("credit")
                        xlWorkSheet.Cells(currentRow, 9) = dr.Item("debit_based")
                        xlWorkSheet.Cells(currentRow, 10) = dr.Item("credit_based")
                        Dim amt = (ifNull(dr.Item("beg_debit"), 0) - ifNull(dr.Item("beg_credit"), 0)) + (ifNull(dr.Item("debit"), 0) - ifNull(dr.Item("credit"), 0))
                        Dim amt_based = (ifNull(dr.Item("beg_debit_based"), 0) - ifNull(dr.Item("beg_credit_based"), 0)) + (ifNull(dr.Item("debit_based"), 0) - ifNull(dr.Item("credit_based"), 0))
                        xlWorkSheet.Cells(currentRow, 11) = If(amt > 0, amt, 0)
                        xlWorkSheet.Cells(currentRow, 12) = If(amt < 0, amt * -1, 0)
                        xlWorkSheet.Cells(currentRow, 13) = If(amt_based > 0, amt_based, 0)
                        xlWorkSheet.Cells(currentRow, 14) = If(amt_based < 0, amt_based * -1, 0)
                        xlWorkSheet.Cells(currentRow, 15) = dr.Item("chart_type")
                    Else
                        xlWorkSheet.Cells(currentRow, 3) = dr.Item("beg_debit")
                        xlWorkSheet.Cells(currentRow, 4) = dr.Item("beg_credit")
                        xlWorkSheet.Cells(currentRow, 5) = dr.Item("debit")
                        xlWorkSheet.Cells(currentRow, 6) = dr.Item("credit")
                        Dim amt = (ifNull(dr.Item("beg_debit"), 0) - ifNull(dr.Item("beg_credit"), 0)) + (ifNull(dr.Item("debit"), 0) - ifNull(dr.Item("credit"), 0))
                        xlWorkSheet.Cells(currentRow, 7) = If(amt > 0, amt, 0)
                        xlWorkSheet.Cells(currentRow, 8) = If(amt < 0, amt * -1, 0)
                        xlWorkSheet.Cells(currentRow, 9) = dr.Item("chart_type")
                    End If
                Else
                    If dicOption.Item("withComparison") Then
                        xlWorkSheet.Cells(currentRow, 5) = dr.Item("debit_based")
                        xlWorkSheet.Cells(currentRow, 6) = dr.Item("credit_based")
                        xlWorkSheet.Cells(currentRow, 7) = dr.Item("chart_type")
                    Else
                        xlWorkSheet.Cells(currentRow, 5) = dr.Item("chart_type")
                    End If
                End If
                currentRow += 1
            Next
        End If
    End Sub
    Private Sub excelTrialBalance(ByVal ds As DataSet, ByVal templateName As String, ByVal companyName As String, ByVal dateRange As String, Optional list As List(Of Object) = Nothing, Optional colName As String = "", Optional groupByCurrency As Boolean = False, Optional wCompare As Boolean = False)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = companyName
        xlWorkSheet.Cells(3, 1) = dateRange

        Dim current_row As Integer = 5
        Dim first_row As Integer = 5

        If list Is Nothing Then
            If ds.Tables("accounts").Rows.Count > 0 Then
                For Each row As DataRow In ds.Tables("accounts").Rows
                    xlWorkSheet.Cells(current_row, 1) = "'" & row.Item("account_code")
                    xlWorkSheet.Cells(current_row, 2) = row.Item("account_name")
                    xlWorkSheet.Cells(current_row, 3) = row.Item("debit")
                    xlWorkSheet.Cells(current_row, 4) = row.Item("credit")
                    xlWorkSheet.Cells(current_row, 5) = row.Item("chart_type")
                    current_row += 1
                Next
            End If
        Else
            If colName.Contains(",") Then
                Dim fields = colName.Split(",")
                For Each k In list
                    Dim dGroup = CType(k, Dictionary(Of String, Object))
                    xlWorkSheet.Cells(current_row, 1).Value = dGroup.Item(fields(0))
                    current_row += 1
                    For Each i In dGroup.Item("grouped")
                        Dim dicGroup = CType(i, Dictionary(Of String, Object))
                        xlWorkSheet.Cells(current_row, 1).Value = dicGroup.Item(fields(1))
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        For Each j In CType(dicGroup.Item("datas"), List(Of Object))
                            Dim currDic = j
                            xlWorkSheet.Cells(current_row, 1) = "'" & currDic.Item("account_code")
                            xlWorkSheet.Cells(current_row, 2) = currDic.Item("account_name")
                            xlWorkSheet.Cells(current_row, 3) = currDic.Item("debit")
                            xlWorkSheet.Cells(current_row, 4) = currDic.Item("credit")
                            If wCompare Then
                                xlWorkSheet.Cells(current_row, 5) = currDic.Item("debit_based")
                                xlWorkSheet.Cells(current_row, 6) = currDic.Item("credit_based")
                                xlWorkSheet.Cells(current_row, 7) = currDic.Item("chart_type")
                            Else
                                xlWorkSheet.Cells(current_row, 5) = currDic.Item("chart_type")
                            End If
                            current_row += 1
                        Next
                    Next
                Next
            Else
                For Each i In list
                    Dim dicGroup = CType(i, Dictionary(Of String, Object))
                    xlWorkSheet.Cells(current_row, 1).Value = dicGroup.Item(colName)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                    current_row += 1
                    For Each j In CType(dicGroup.Item("datas"), List(Of Object))
                        Dim currDic = j
                        xlWorkSheet.Cells(current_row, 1) = "'" & currDic.Item("account_code")
                        xlWorkSheet.Cells(current_row, 2) = currDic.Item("account_name")
                        xlWorkSheet.Cells(current_row, 3) = currDic.Item("debit")
                        xlWorkSheet.Cells(current_row, 4) = currDic.Item("credit")
                        If wCompare Then
                            xlWorkSheet.Cells(current_row, 5) = currDic.Item("debit_based")
                            xlWorkSheet.Cells(current_row, 6) = currDic.Item("credit_based")
                            xlWorkSheet.Cells(current_row, 7) = currDic.Item("chart_type")
                        Else
                            xlWorkSheet.Cells(current_row, 5) = currDic.Item("chart_type")
                        End If
                        current_row += 1
                    Next
                Next
            End If
        End If
        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUM(C{0}:C{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUM(D{0}:D{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        If wCompare Then
            xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Cells(current_row, 6) = String.Format("=SUM(F{0}:F{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 5) = String.Format("=SUM(E{0}:E{1})", first_row, current_row - 1)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Color = System.Drawing.Color.White
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        End If
    End Sub
    Private Function ExcelRange(ByRef xlWorkSheet As Excel.Worksheet, ByRef row As Integer, ByRef col As Integer, Optional lastRow As Integer = -1, Optional lastCol As Integer = -1) As Excel.Range
        lastRow = If(lastRow < 0, row, lastRow)
        lastCol = If(lastCol < 0, col, lastCol)
        Return xlWorkSheet.Range(xlWorkSheet.Cells(row, col), xlWorkSheet.Cells(lastRow, lastCol))
    End Function
    Private Sub excelTrialBalance1(ByVal ds As DataSet, ByVal templateName As String, ByVal companyName As String, ByVal lbl1 As String, ByVal lbl2 As String, ByVal lbl3 As String, ByVal list As List(Of Object), ByVal colName As String, Optional groupByCurrency As Boolean = False, Optional wCompare As Boolean = False)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim dateRanges As String = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim current_row As Integer = 6
        Dim first_row As Integer = 6

        Dim listRow As New List(Of Integer)
        Dim listRowBased As New List(Of Integer)

        xlWorkSheet.Cells(1, 1) = companyName
        xlWorkSheet.Cells(3, 1) = dateRanges


        xlWorkSheet.Cells(4, 3) = lbl1
        xlWorkSheet.Cells(4, 5) = lbl2
        xlWorkSheet.Cells(4, 7) = lbl3
        If colName.Contains(",") Then
            Dim fields = colName.Split(",")
            For Each k In list
                Dim dGroup = CType(k, Dictionary(Of String, Object))
                xlWorkSheet.Cells(current_row, 1).Value = dGroup.Item(colName)
                current_row += 1
                For Each i In dGroup.Item("grouped")
                    Dim dicGroup = CType(i, Dictionary(Of String, Object))
                    If groupByCurrency Then
                        xlWorkSheet.Cells(current_row, 1).Value = dicGroup.Item(colName)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                    End If
                    For Each j In CType(dicGroup.Item("datas"), List(Of Object))
                        Dim currDic = j
                        xlWorkSheet.Cells(current_row, 1) = "'" & currDic.Item("account_code")
                        xlWorkSheet.Cells(current_row, 2) = currDic.Item("account_name")
                        xlWorkSheet.Cells(current_row, 3) = currDic.Item("beg_debit")
                        xlWorkSheet.Cells(current_row, 4) = currDic.Item("beg_credit")
                        xlWorkSheet.Cells(current_row, 5) = currDic.Item("debit")
                        xlWorkSheet.Cells(current_row, 6) = currDic.Item("credit")
                        Dim f1 = (ifNull(currDic.Item("beg_debit"), 0) - ifNull(currDic.Item("beg_credit"), 0)) + (ifNull(currDic.Item("debit"), 0) - ifNull(currDic.Item("credit"), 0))
                        xlWorkSheet.Cells(current_row, 7) = If(f1 > 0, f1, 0)
                        xlWorkSheet.Cells(current_row, 8) = If(f1 < 0, f1 * -1, 0)
                        xlWorkSheet.Cells(current_row, 9) = currDic.Item("chart_type")
                        listRow.Add(current_row)
                        If wCompare Then
                            current_row += 1
                            xlWorkSheet.Cells(current_row, 3) = currDic.Item("beg_debit_based")
                            xlWorkSheet.Cells(current_row, 4) = currDic.Item("beg_credit_based")
                            xlWorkSheet.Cells(current_row, 5) = currDic.Item("debit_based")
                            xlWorkSheet.Cells(current_row, 6) = currDic.Item("credit_based")
                            Dim f2 = (ifNull(currDic.Item("beg_debit_based"), 0) - ifNull(currDic.Item("beg_credit_based"), 0)) + (ifNull(currDic.Item("debit_based"), 0) - ifNull(currDic.Item("credit_based"), 0))
                            xlWorkSheet.Cells(current_row, 7) = If(f2 > 0, f2, 0)
                            xlWorkSheet.Cells(current_row, 8) = If(f2 < 0, f2 * -1, 0)
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                            listRowBased.Add(current_row)
                        End If
                        current_row += 1
                    Next
                Next
            Next
        Else
            For Each i In list
                Dim dicGroup = CType(i, Dictionary(Of String, Object))
                If groupByCurrency Then
                    xlWorkSheet.Cells(current_row, 1).Value = dicGroup.Item(colName)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                    current_row += 1
                End If
                For Each j In CType(dicGroup.Item("datas"), List(Of Object))
                    Dim currDic = j
                    xlWorkSheet.Cells(current_row, 1) = "'" & currDic.Item("account_code")
                    xlWorkSheet.Cells(current_row, 2) = currDic.Item("account_name")
                    xlWorkSheet.Cells(current_row, 3) = currDic.Item("beg_debit")
                    xlWorkSheet.Cells(current_row, 4) = currDic.Item("beg_credit")
                    xlWorkSheet.Cells(current_row, 5) = currDic.Item("debit")
                    xlWorkSheet.Cells(current_row, 6) = currDic.Item("credit")
                    Dim f1 = (ifNull(currDic.Item("beg_debit"), 0) - ifNull(currDic.Item("beg_credit"), 0)) + (ifNull(currDic.Item("debit"), 0) - ifNull(currDic.Item("credit"), 0))
                    xlWorkSheet.Cells(current_row, 7) = If(f1 > 0, f1, 0)
                    xlWorkSheet.Cells(current_row, 8) = If(f1 < 0, f1 * -1, 0)
                    xlWorkSheet.Cells(current_row, 9) = currDic.Item("chart_type")
                    listRow.Add(current_row)
                    If wCompare Then
                        current_row += 1
                        xlWorkSheet.Cells(current_row, 3) = currDic.Item("beg_debit_based")
                        xlWorkSheet.Cells(current_row, 4) = currDic.Item("beg_credit_based")
                        xlWorkSheet.Cells(current_row, 5) = currDic.Item("debit_based")
                        xlWorkSheet.Cells(current_row, 6) = currDic.Item("credit_based")
                        Dim f2 = (ifNull(currDic.Item("beg_debit_based"), 0) - ifNull(currDic.Item("beg_credit_based"), 0)) + (ifNull(currDic.Item("debit_based"), 0) - ifNull(currDic.Item("credit_based"), 0))
                        xlWorkSheet.Cells(current_row, 7) = If(f2 > 0, f2, 0)
                        xlWorkSheet.Cells(current_row, 8) = If(f2 < 0, f2 * -1, 0)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                        listRowBased.Add(current_row)
                    End If
                    current_row += 1
                Next
            Next
        End If

        If rdo_currency_1.Checked = True Then
            current_row += 1
            xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Cells(current_row, 3) = String.Format("=SUM(C{0}:C{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 4) = String.Format("=SUM(D{0}:D{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 5) = String.Format("=SUM(E{0}:E{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 6) = String.Format("=SUM(F{0}:F{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 7) = String.Format("=SUM(G{0}:G{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUM(H{0}:H{1})", first_row, current_row - 1)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            current_row += 1
        ElseIf rdo_currency_2.Checked = True And withComparison.Checked = False Then
            current_row += 1
            xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Cells(current_row, 3) = String.Format("=SUM(C{0}:C{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 4) = String.Format("=SUM(D{0}:D{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 5) = String.Format("=SUM(E{0}:E{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 6) = String.Format("=SUM(F{0}:F{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 7) = String.Format("=SUM(G{0}:G{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUM(H{0}:H{1})", first_row, current_row - 1)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            current_row += 1
        ElseIf rdo_currency_2.Checked = True And withComparison.Checked = True Then
            current_row += 1
            xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Cells(current_row, 3) = String.Format("=SUMPRODUCT(C{0}:C{1},MOD(ROW(C{0}:C{1})+0,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 4) = String.Format("=SUMPRODUCT(D{0}:D{1},MOD(ROW(D{0}:D{1})+0,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 5) = String.Format("=SUMPRODUCT(E{0}:E{1},MOD(ROW(E{0}:E{1})+0,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 6) = String.Format("=SUMPRODUCT(F{0}:F{1},MOD(ROW(F{0}:F{1})+0,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 7) = String.Format("=SUMPRODUCT(G{0}:G{1},MOD(ROW(G{0}:G{1})+0,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUMPRODUCT(H{0}:H{1},MOD(ROW(H{0}:H{1})+0,2))", first_row, current_row - 1)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            current_row += 1
            xlWorkSheet.Cells(current_row, 3) = String.Format("=SUMPRODUCT(C{0}:C{1},MOD(ROW(C{0}:C{1})-1,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 4) = String.Format("=SUMPRODUCT(D{0}:D{1},MOD(ROW(D{0}:D{1})-1,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 5) = String.Format("=SUMPRODUCT(E{0}:E{1},MOD(ROW(E{0}:E{1})-1,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 6) = String.Format("=SUMPRODUCT(F{0}:F{1},MOD(ROW(F{0}:F{1})-1,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 7) = String.Format("=SUMPRODUCT(G{0}:G{1},MOD(ROW(G{0}:G{1})-1,2))", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 8) = String.Format("=SUMPRODUCT(H{0}:H{1},MOD(ROW(H{0}:H{1})-1,2))", first_row, current_row - 1)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub withProjectDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles withProjectDepartment.CheckedChanged
        Dim wProjDept As Boolean = withProjectDepartment.Checked
        txt_project_id.Enabled = True
        txt_department_id.Enabled = True
        If Not wProjDept Then
            txt_project_id.Value = ""
            txt_project_id.Text = ""
            txt_project_id.Enabled = False
            lbl_project_name.Text = "Project Name"
            txt_department_id.Value = ""
            txt_department_id.Text = ""
            txt_department_id.Enabled = False
            lbl_department_name.Text = "Department Name"
        End If
    End Sub
    Private Sub rdo_currency_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_currency_1.CheckedChanged, rdo_currency_2.CheckedChanged
        Dim currency As String = getRdoValue(currency_filter)
        withComparison.Enabled = False
        If currency = "2" Then
            withComparison.Enabled = True
        End If
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        If txt_date_to.Value < txt_date_from.Value Then
            If rdo1.Checked Or rdo3.Checked Then
                MsgBox("Invalid Date Range.")
                Exit Sub
            End If
        End If
        Dim _printoption As New reportoption
        _printoption.targetForm = Me
        _printoption.Label1.Hide()
        _printoption.cbo_sort.Hide()
        _printoption.ShowDialog()
        If _printoption.DialogResult = Windows.Forms.DialogResult.OK Then
            If _printoption.PrintOption = "1" Then
                btnPrint_Click(btnExcel, Nothing)
            Else
                btnPrint_Click(btnPrint, Nothing)
            End If
        End If
    End Sub

    Private Sub checkAllBook_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBook.CheckedChanged
        For Each dr As DataGridViewRow In dgBooks.Rows
            dr.Cells("sel").Value = checkAllBook.Checked
        Next
    End Sub

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
    End Sub

    Private Sub dgBooks_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgBooks.CellValueChanged
        lstBook.Clear()
        For Each dr As DataGridViewRow In dgBooks.Rows
            If dr.Cells("sel").Value Then
                lstBook.Add(dr.Cells("book_id").Value.ToString)
            End If
        Next
        If My.Settings._enableBookUnit Then
            loadUnit(lstBook)
        End If
    End Sub
    Private Sub loadUnit(ByVal lst As List(Of String))
        Dim ids As String = String.Join(",", lst)
        If My.Settings._enableBookUnit Then
            Dim sql As String = String.Format("SELECT book_unit_no_id AS unit_id,book_unit_no_code AS unit_code,book_unit_no_name AS unit_name
            FROM lib_erp_book_unit_no ")
            If ids <> "" Then
                sql &= String.Format("WHERE book_id IN ({0})", ids)
            End If
            Dim dt As DataTable = FsQuery(sql)
            ds.Tables("lib_erp_unit").Clear()
            For Each dr As DataRow In dt.Rows
                ds.Tables("lib_erp_unit").ImportRow(dr)
            Next
            dgUnit.AutoGenerateColumns = False
            dgUnit.DataSource = ds.Tables("lib_erp_unit")
        Else
            Dim sql As String = String.Format("SELECT project_unit_no_id AS unit_id,project_unit_no_codes AS unit_code,project_unit_no_names AS unit_name
            FROM lib_erp_project_unit_no ")
            If ids <> "" Then
                sql &= String.Format("WHERE project_id IN ({0})", ids)
            End If
            Dim dt As DataTable = FsQuery(sql)
            ds.Tables("lib_erp_unit").Clear()
            For Each dr As DataRow In dt.Rows
                ds.Tables("lib_erp_unit").ImportRow(dr)
            Next
            dgUnit.AutoGenerateColumns = False
            dgUnit.DataSource = ds.Tables("lib_erp_unit")
        End If
    End Sub

    Private Sub checkAllUnit_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllUnit.CheckedChanged
        For Each dr As DataGridViewRow In dgUnit.Rows
            dr.Cells("sel1").Value = checkAllUnit.Checked
        Next
    End Sub
End Class