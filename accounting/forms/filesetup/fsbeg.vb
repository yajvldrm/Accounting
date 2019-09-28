Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class fsbeg
    Dim dbTable As String = "trans_header" ' header
    Dim jbooksTable As String = "trans_jbooks" ' jbooks
    'child tables
    Dim checkTable As String = "trans_check"
    Dim ewtTable As String = "trans_ewt"
    Dim ftTable As String = "trans_final_tax"
    Dim faTable As String = "trans_fixed_asset"
    Dim headerapTable As String = "trans_header_ap"
    Dim headercvTable As String = "trans_header_cv"
    Dim ivTable As String = "trans_input_vat"
    Dim ovTable As String = "trans_output_vat"
    Dim preTable As String = "trans_prepaid"
    Dim okLoad As Boolean = False
    Dim isEnabled As Boolean = False
    'end of child tables
    Public ds As New begbal
    Dim currency_rate As DataRow = Nothing
    Private transmode As String = ""
    Dim child As String = ""
    Private module_code As String = "ACC00811"
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Private MyDT As DataTable = Nothing

    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txt_debit.NumberFormat = strNumberFormat
        txt_credit.NumberFormat = strNumberFormat
        txt_debit_based.NumberFormat = strNumberFormat
        txt_credit_based.NumberFormat = strNumberFormat
        txt_exchange_rate.NumberFormat = strNumberFormat
        txt_based_rate.NumberFormat = strNumberFormat
    End Sub
    Private Sub init_load()

        If My.Settings._enableBookUnit Then

            With dgMain 'DataGridView

                .RowHeadersVisible = False
                .Columns(10).HeaderCell.Value = "Book Unit"
                .Columns(10).DataPropertyName = "book_unit_no_name"
                .Columns(10).Name = "book_unit_no_name"

            End With


            'txt_book_unit_no_id.Name = "txt_book_unit_no_id"
            'txt_book_unit_no_id.TextSource = "book_unit_no_name"
            'txt_book_unit_no_id.ValueSource = "book_unit_no_id"
            'Label16.Text = "Book Unit"

            dgMain.AutoGenerateColumns = False
            dgMain.DataSource = Nothing
            ds.Tables(jbooksTable).Clear()
            MyDT = ds.Tables(jbooksTable).Clone
            MyDT.Clear()

            Dim _sql = String.Format("SELECT trans_id FROM trans_header WHERE currency_id = {0} AND book_id = {1} AND trans_date = '{2}' AND journal_id = 8", txt_currency_id.Value, txt_book_id.Value, txt_trans_date.Value.ToString("yyyy-MM-dd"))
            Dim _dt As DataTable = Query(_sql)
            If _dt.Rows.Count > 0 Then
                txt_trans_id.Value = _dt.Rows(0).Item("trans_id").ToString

                'Dim sql = String.Format("SELECT a.book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,a.debit,a.credit,a.debit_based,a.credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name " &
                '",e.currency_name,e.currency_code " &
                '",f.book_unit_no_name,f.book_unit_no_code " &
                '"FROM trans_jbooks a " &
                '"LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                '"LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id " &
                '"LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id " &
                '"LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " &
                '"LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id " &
                '"WHERE a.trans_id = {0} AND b.validation <> 3 AND b.validation <> 2 " &
                '"UNION " &
                '"SELECT a.book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,SUM(a.debit) AS debit,SUM(a.credit) AS credit,SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name " &
                '",e.currency_name,e.currency_code " &
                '",f.book_unit_no_name,f.book_unit_no_code " &
                '"FROM trans_jbooks a " &
                '"LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                '"LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id " &
                '"LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id " &
                '"LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " &
                '"LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id " &
                '"WHERE a.trans_id = {0} AND b.validation = 3 GROUP BY a.account_id,a.project_id,a.department_id " &
                '"UNION " &
                '"SELECT a.book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,SUM(a.debit) AS debit,SUM(a.credit) AS credit,SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name " &
                '",e.currency_name,e.currency_code " &
                '",f.book_unit_no_name,f.book_unit_no_code " &
                '"FROM trans_jbooks a " &
                '"LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                '"LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id " &
                '"LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id " &
                '"LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " &
                '"LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id " &
                '"WHERE a.trans_id = {0} AND b.validation = 2 GROUP BY a.account_id,a.project_id,a.department_id,a.book_unit_no_id " &
                '"ORDER BY account_code ASC " &
                '"", txt_trans_id.Value, _serverDBFS)
                Dim sql = String.Format("SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.project_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,a.debit,a.credit,a.debit_based
                ,a.credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name
                ,e.currency_name,e.currency_code
                ,CONVERT(IFNULL(f.book_unit_no_name,z.project_unit_no_names)USING UTF8) AS book_unit_no_name,CONVERT(IFNULL(f.book_unit_no_code,z.project_unit_no_codes)USING UTF8) AS book_unit_no_code
                FROM trans_jbooks a
                LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id
                LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id
                LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id
                LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id
                LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id
                LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id
                WHERE a.trans_id = '{0}' AND b.validation <> 3 AND b.validation <> 2
                UNION
                SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.project_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,SUM(a.debit) AS debit,SUM(a.credit) AS credit
                ,SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name
                ,e.currency_name,e.currency_code
                ,CONVERT(IFNULL(f.book_unit_no_name,z.project_unit_no_names)USING UTF8) AS book_unit_no_name,CONVERT(IFNULL(f.book_unit_no_code,z.project_unit_no_codes)USING UTF8) AS book_unit_no_code
                FROM trans_jbooks a
                LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id
                LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id
                LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id
                LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id
                LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id
                LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id
                WHERE a.trans_id = '{0}' AND b.validation = 3
                GROUP BY a.account_id,a.project_id,a.department_id
                UNION
                SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.project_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,SUM(a.debit) AS debit,SUM(a.credit) AS credit
                ,SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name
                ,e.currency_name,e.currency_code
                ,CONVERT(IFNULL(f.book_unit_no_name,z.project_unit_no_names)USING UTF8) AS book_unit_no_name,CONVERT(IFNULL(f.book_unit_no_code,z.project_unit_no_codes)USING UTF8) AS book_unit_no_code
                FROM trans_jbooks a
                LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id
                LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id
                LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id
                LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id
                LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id
                LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id
                WHERE a.trans_id = '{0}' AND b.validation = 2
                GROUP BY a.account_id,a.project_id,a.department_id
                ORDER BY account_code ASC ", txt_trans_id.Value, _serverDBFS)
                Dim dt As DataTable = Query(sql)
                dt.DefaultView.Sort = "account_code ASC"
                For Each row As DataRow In dt.Rows
                    ds.Tables(jbooksTable).ImportRow(row)
                    MyDT.ImportRow(row)
                Next
            End If

            dgMain.DataSource = MyDT

        Else 'Project Unit


            With dgMain 'DataGridView

                .RowHeadersVisible = False
                .Columns(8).HeaderCell.Value = "Project Unit"
                .Columns(8).DataPropertyName = "project_unit_no_names"
                .Columns(8).Name = "project_unit_no_names"

            End With


            'txt_book_unit_no_id.Name = "txt_project_unit_no_id"
            'txt_book_unit_no_id.TextSource = "project_unit_no_names"
            'txt_book_unit_no_id.ValueSource = "project_unit_no_id"
            'Label16.Text = "Project Unit"


            dgMain.AutoGenerateColumns = False
            dgMain.DataSource = Nothing
            ds.Tables(jbooksTable).Clear()
            MyDT = ds.Tables(jbooksTable).Clone
            MyDT.Clear()

            Dim _sql = String.Format("SELECT trans_id FROM trans_header WHERE currency_id = {0} AND book_id = {1} AND trans_date = '{2}' AND journal_id = 8", txt_currency_id.Value, txt_book_id.Value, txt_trans_date.Value.ToString("yyyy-MM-dd"))
            Dim _dt As DataTable = Query(_sql)
            If _dt.Rows.Count > 0 Then
                txt_trans_id.Value = _dt.Rows(0).Item("trans_id").ToString

                Dim sql = String.Format("SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,a.debit,a.credit,a.debit_based,a.credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name " &
                ",e.currency_name,e.currency_code " &
                ",IFNULL(f.book_unit_no_name,z.project_unit_no_names) AS book_unit_no_name,IFNULL(f.book_unit_no_code,z.project_unit_no_codes) AS book_unit_no_code " &
                "FROM trans_jbooks a " &
                "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                "LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id " &
                "LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id " &
                "LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " &
                "LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id " &
                "LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id " &
                "WHERE a.trans_id = {0} AND b.validation <> 3 AND b.validation <> 2 " &
                "UNION " &
                "SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,SUM(a.debit) AS debit,SUM(a.credit) AS credit,SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name " &
                ",e.currency_name,e.currency_code " &
                ",IFNULL(f.book_unit_no_name,z.project_unit_no_names) AS book_unit_no_name,IFNULL(f.book_unit_no_code,z.project_unit_no_codes) AS book_unit_no_code " &
                "FROM trans_jbooks a " &
                "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                "LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id " &
                "LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id " &
                "LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " &
                "LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id " &
                "LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id " &
                "WHERE a.trans_id = {0} AND b.validation = 3 GROUP BY a.account_id,a.project_id,a.department_id " &
                "UNION " &
                "SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate,SUM(a.debit) AS debit,SUM(a.credit) AS credit,SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name " &
                ",e.currency_name,e.currency_code " &
                ",IFNULL(f.book_unit_no_name,z.project_unit_no_names) AS book_unit_no_name,IFNULL(f.book_unit_no_code,z.project_unit_no_codes) AS book_unit_no_code " &
                "FROM trans_jbooks a " &
                "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                "LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id " &
                "LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id " &
                "LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " &
                "LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id " &
                "LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id " &
                "WHERE a.trans_id = {0} AND b.validation = 2 GROUP BY a.account_id,a.project_id,a.department_id " &
                "ORDER BY account_code ASC " &
                "", txt_trans_id.Value, _serverDBFS)

                Dim dt As DataTable = Query(sql)
                dt.DefaultView.Sort = "account_code ASC"
                For Each row As DataRow In dt.Rows
                    ds.Tables(jbooksTable).ImportRow(row)
                    MyDT.ImportRow(row)
                Next
            End If

            dgMain.DataSource = MyDT

        End If

        Dim currency_rate_dt As DataTable = FsQuery(String.Format("SELECT * FROM lib_erp_currency_rate WHERE currency_id = {0} AND effectivitydate <= '{1}' ORDER BY effectivitydate DESC LIMIT 1", txt_currency_id.Value, txt_trans_date.Value.ToString("yyyy-MM-dd")))
        If currency_rate_dt.Rows.Count > 0 Then
            currency_rate = currency_rate_dt.Rows(0)
            txt_currency.Value = txt_currency_id.Value
            txt_currency.Text = txt_currency_id.Text
            txt_exchange_rate.DecimalValue = currency_rate.Item("exchange_rate")
            txt_based_rate.DecimalValue = currency_rate.Item("based_rate")
            okLoad = True
        Else
            MsgBox("No Currency Setup for the Month")
        End If
        computeGrid()
    End Sub
    Private Sub fsbeg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDecimalPlaces(main.strNumberFormat)
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
        If Not okLoad Then
            btnInsert.Visible = False
            btnRemove.Visible = False
            btnUpdate.Visible = False
        End If
    End Sub
    Private Sub computeGrid()
        Dim dt As DataTable = dgMain.DataSource

        Dim debit As Decimal = 0
        Dim credit As Decimal = 0
        Dim debit_based As Decimal = 0
        Dim credit_based As Decimal = 0

        For Each row As DataRow In dt.Rows
            debit += row.Item("debit")
            credit += row.Item("credit")
            debit_based += row.Item("debit_based")
            credit_based += row.Item("credit_based")
        Next

        lbl_debit.Text = debit.ToString(main.strNumberFormat)
        lbl_credit.Text = credit.ToString(main.strNumberFormat)
        lbl_difference.Text = (debit - credit).ToString(main.strNumberFormat)
        lbl_debit_based.Text = debit_based.ToString(main.strNumberFormat)
        lbl_credit_based.Text = credit_based.ToString(main.strNumberFormat)
        lbl_difference_based.Text = (debit_based - credit_based).ToString(main.strNumberFormat)

    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged

        Dim dt As DataTable = dgMain.DataSource
        bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")

        If dgMain.SelectedRows.Count = 1 Then
            If dgMain.SelectedRows(0).Cells("jbooks_id").Value <> Nothing Then
                Dim dr() As DataRow = dt.Select("jbooks_id = '" & dgMain.SelectedRows(0).Cells("jbooks_id").Value.ToString & "'")
                If dr.Length = 1 Then
                    txt_currency.Value = dr(0).Item("currency_id").ToString
                    txt_currency.Text = dr(0).Item("currency_name").ToString
                End If
                'MsgBox(txt_book_unit_no_id.Name.ToString + ", " + dr(0).Item("project_unit_no_names").ToString)
            End If
        End If

        Dim _dt As DataTable = FsQuery(String.Format("SELECT * FROM lib_erp_chart WHERE account_id = '{0}'", txt_account_id.Value))
        If _dt.Rows.Count > 0 Then
            If "23456789".Contains(_dt.Rows(0).Item("validation").ToString) Then
                btnViewDetails.Enabled = True
            Else
                btnViewDetails.Enabled = False
            End If
        Else
            btnViewDetails.Enabled = False
        End If

    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        'clear the tables
        ds.Tables(checkTable).Rows.Clear()
        ds.Tables(ewtTable).Rows.Clear()
        ds.Tables(faTable).Rows.Clear()
        ds.Tables(headerapTable).Rows.Clear()
        ds.Tables(headercvTable).Rows.Clear()
        ds.Tables(ivTable).Rows.Clear()
        ds.Tables(ovTable).Rows.Clear()
        ds.Tables(preTable).Rows.Clear()
        'end of clearing the tables
        Dim dr As DataRow = main.Sys_Default.Rows(0)
        'If dr("line_remarks") = 1 Then
        '    txt_line_remarks.Enabled = True
        '    txt_line_remarks.Focus()
        'End If
        clear_control(Me)
        enable_control(Me)
        txt_jbooks_id.Value = Nothing
        txt_jbooks_id.Text = Nothing
        txt_account_id.RowData = Nothing
        txt_account_id.Enabled = True
        If dr("w_proj") <> 1 And dr("w_dept") <> 1 Then
            txt_account_id.Focus()
        End If
        If dr("w_proj") = 1 And dr("w_dept") = 1 Then
            txt_project_id.Enabled = True
            txt_department_id.Enabled = True
            txt_project_id.Focus()
        ElseIf dr("w_proj") = 1 Then
            txt_project_id.Enabled = True
            txt_project_id.Focus()
        ElseIf dr("w_dept") = 1 Then
            txt_department_id.Enabled = True
            txt_department_id.Focus()
        End If
        'If dr("w_alloc") = 1 Then
        '    txtallocation.Enabled = True
        'End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If dgMain.SelectedRows.Count = 0 Then
            MsgBox("No Record Selected")
            Exit Sub
        End If
        Dim dra As DataRow = main.Sys_Default.Rows(0)
        'If dr("line_remarks") = 1 Then
        '    txt_line_remarks.Enabled = True
        '    txt_line_remarks.Focus()
        'End If
        If dra("w_dept") = 1 Then
            txt_department_id.Enabled = True
            txt_department_id.Focus()
        End If
        If dra("w_proj") = 1 Then
            txt_project_id.Enabled = True
            txt_project_id.Focus()
        End If
        transmode = "update"
        enable_control(Me)
        Dim dt As DataTable = dgMain.DataSource
        If dgMain.SelectedRows.Count = 1 Then
            If dgMain.SelectedRows(0).Cells("jbooks_id").Value <> Nothing Then
                Dim dr() As DataRow = dt.Select("jbooks_id = '" & dgMain.SelectedRows(0).Cells("jbooks_id").Value.ToString & "'")
                If dr.Length = 1 Then
                    txt_debit.Enabled = False
                    txt_debit_based.Enabled = False
                    txt_credit.Enabled = False
                    txt_credit_based.Enabled = False
                    Select Case dr(0).Item("validation")
                        Case "0", "1", "10"
                            txt_debit.Enabled = True
                            txt_debit_based.Enabled = True
                            txt_credit.Enabled = True
                            txt_credit_based.Enabled = True
                            txt_account_id.Enabled = True
                            txt_account_id.Focus()
                        Case "2", "6", "8", "9"
                            txt_debit.Enabled = True
                            txt_debit.Focus()
                            'txt_exchange_rate.Focus()
                            'txt_debit_based.Enabled = True
                        Case "3", "4", "5", "7"
                            txt_credit.Enabled = True
                            txt_credit.Focus()
                            'txt_exchange_rate.Focus()
                            'txt_credit_based.Enabled = True
                    End Select
                End If
            End If
        End If

        Dim _dts As DataTable = FsQuery(String.Format("SELECT * FROM lib_erp_chart WHERE account_id = {0}", txt_account_id.Value))
        txt_account_id.RowData = _dts.Rows(0)
        isEnabled = Convert.ToBoolean(_dts.Rows(0).Item("unit_applicable"))
        If isEnabled Then
            txt_project_id.Enabled = True
            txt_department_id.Enabled = True
            'txt_book_unit_no_id.Enabled = True
        Else
            txt_project_id.Enabled = False
            txt_department_id.Enabled = False
            'txt_book_unit_no_id.Enabled = False
        End If

    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        Dim dt As DataTable = dgMain.DataSource
        bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
        If dgMain.RowCount > 0 Then
            Dim selectedRow = dgMain.SelectedRows
            selectedRow(0).Cells(0).Selected = False
            selectedRow(0).Cells(0).Selected = True
        End If
        transmode = ""
    End Sub
    Private Sub fsbegbal_FormClosed(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If txt_debit.Enabled Then
            If txt_debit.Text = "" Or txt_debit.Text = "0" Or txt_debit_based.Text = "" Or txt_debit_based.Text = "0" Then
                e.Cancel = True
            Else
                filter.Show()
            End If
        ElseIf txt_credit.Enabled Then
            If txt_credit.Text = "" Or txt_credit.Text = "0" Or txt_credit_based.Text = "" Or txt_credit_based.Text = "0" Then
                e.Cancel = True
            Else
                filter.Show()
            End If
        End If
    End Sub
    Private Sub txt_general_code_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave

        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_project")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("project_name like '{0}'", txt_project_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
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
                txt_project_id.Text = dr("project_name")
            Else
                MsgBox("Project is required")
                txt_project_id.Value = ""
                txt_project_id.Text = ""
                txt_project_id.Focus()
            End If
        End If
    End Sub
    Private Sub txt_department_Leave(sender As Object, e As EventArgs) Handles txt_department_id.Leave

        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_department")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("department_name like '{0}'", txt_department_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
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
                txt_department_id.Text = dr("department_name")
            Else
                MsgBox("Department is required.")
                txt_department_id.Value = ""
                txt_department_id.Text = ""
                txt_department_id.Focus()
            End If
        End If

    End Sub
    Private Sub txt_account_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave

        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_chart ORDER BY account_code")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("account_code like '{0}'", txt_account_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "account_code,account_name", "100,400")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                Dim dtSource As DataTable = dgMain.DataSource
                Dim jbooks_id As String = txt_jbooks_id.Value
                Dim account_id As String = dr("account_id")
                Dim project_id As String = txt_project_id.Value
                Dim department_id As String = txt_department_id.Value
                Dim strFilter = String.Format("account_id = '{0}' AND jbooks_id <> '{1}'", account_id, jbooks_id)
                If project_id <> "" Then
                    strFilter &= String.Format(" AND project_id = '{0}'", project)
                End If
                If department_id <> "" Then
                    strFilter &= String.Format(" AND department_id = '{0}'", department_id)
                End If
                Dim drs = dtSource.Select(strFilter)
                If drs.Length > 0 Then
                    'If DataExist(dgMain, {"jbooks_id", txt_jbooks_id.Value}, {"account_id", "project_id", "department_id"}, {dr("account_id"), txt_project_id.Value, txt_department_id.Value}, If(transmode = "insert", True, False)) Then
                    MsgBox("Record already exist")
                    txt_account_id.Focus()
                Else
                    'If CBool(ifNull(dr("unit_applicable"), 0)) Then
                    '    txt_book_unit_no_id.Enabled = True
                    '    txt_book_unit_no_id.Focus()
                    'Else
                    '    txt_book_unit_no_id.Enabled = False
                    'End If
                    txt_account_id.RowData = dr
                    txt_account_id.Value = dr("account_id")
                    txt_account_id.Text = dr("account_code")
                    txt_account_name.Text = dr("account_name")
                    Select Case dr("validation").ToString
                        Case "0", "1", "10" 'debit or credit
                            txt_debit.Enabled = True
                            txt_credit.Enabled = True
                            txt_debit_based.Enabled = True
                            txt_credit_based.Enabled = True
                            txt_debit.Focus()
                        Case "2", "6", "8", "9" 'debit
                            txt_debit.Enabled = True
                            txt_credit.Enabled = False
                            txt_credit.Text = 0
                            txt_credit.Value = 0
                            txt_debit_based.Enabled = False
                            txt_debit_based.Text = 0
                            txt_debit_based.Value = 0
                            txt_credit_based.Enabled = False
                            txt_credit_based.Text = 0
                            txt_credit_based.Value = 0
                            txt_debit.Focus()
                        Case "3", "4", "5", "7" 'credit
                            txt_debit.Enabled = False
                            txt_debit.Text = 0
                            txt_debit.Value = 0
                            txt_credit.Enabled = True
                            txt_debit_based.Enabled = False
                            txt_debit_based.Text = 0
                            txt_debit_based.Value = 0
                            txt_credit_based.Enabled = False
                            txt_credit_based.Text = 0
                            txt_credit_based.Value = 0
                            txt_credit.Focus()
                    End Select
                End If
            End If
        End If
    End Sub
    Private Sub txt_debit_Leave(sender As Object, e As EventArgs) Handles txt_debit.Leave

        Dim dr As DataRow = txt_account_id.RowData
        Dim debit = txt_debit.DecimalValue
        Dim debit_based = txt_debit_based.DecimalValue
        Dim credit = txt_credit.DecimalValue
        Dim credit_based = txt_credit_based.DecimalValue
        Dim exchange_rate = txt_exchange_rate.DecimalValue
        Dim based_rate = txt_based_rate.DecimalValue
        If debit = 0 Then
            txt_debit_based.DecimalValue = 0
        Else
            txt_credit.DecimalValue = 0
            txt_credit_based.DecimalValue = 0
            txt_debit_based.DecimalValue = debit * (exchange_rate / based_rate)
            'txt_debit_based.Focus()
            btnInsert.Focus()
            If debit <> 0 And txt_debit_based.Enabled = False Then
                txt_debit.Enabled = False
                btnInsert.Focus()
                validateModule()
            End If
        End If
    End Sub

    Private Sub txt_credit_Leave(sender As Object, e As EventArgs) Handles txt_credit.Leave
        Dim dr As DataRow = txt_account_id.RowData
        Dim debit = txt_debit.DecimalValue
        Dim debit_based = txt_debit_based.DecimalValue
        Dim credit = txt_credit.DecimalValue
        Dim credit_based = txt_credit_based.DecimalValue
        Dim exchange_rate = txt_exchange_rate.DecimalValue
        Dim based_rate = txt_based_rate.DecimalValue
        If credit = 0 Then
            txt_credit_based.DecimalValue = 0
        Else
            txt_debit.DecimalValue = 0
            txt_debit_based.DecimalValue = 0
            txt_credit_based.DecimalValue = credit * (exchange_rate / based_rate)
            'txt_credit_based.Focus()
            btnInsert.Focus()
            If credit <> 0 And txt_credit_based.Enabled = False Then
                validateModule()
            End If
        End If
    End Sub
    Private Function getForm(ByVal str As String, ByVal dt As DataTable) As Form
        Dim frm As String = "begbal_" & str & "_detail"
        Dim ProjAndForm = "accounting." & frm  '' String Of Your Project And Form Name
        Dim objType As Type = Type.[GetType](ProjAndForm) '' Get Type Of your string
        Dim objForm As Control = DirectCast(Activator.CreateInstance(objType), Control) '' Convert Type to Control and now you can use this Control
        'Try
        '    Dim propEntryValidated As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("BookUnitNoID")
        '    propEntryValidated.SetValue(objForm, txt_book_unit_no_id.Value)
        'Catch ex As Exception
        'End Try
        Try
            Dim mo As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_currency").GetType.GetProperty("Value")
            If Not mo Is Nothing Then
                mo.SetValue(objForm.Controls("panel_hdr").Controls("txt_currency"), txt_currency_id.Value, Nothing)
            End If
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_currency").GetType.GetProperty("Text")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_currency"), txt_currency_id.Text, Nothing)
            End If
            Dim mp As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_currency").GetType.GetProperty("RowData")
            If Not mp Is Nothing Then
                mp.SetValue(objForm.Controls("panel_hdr").Controls("txt_currency"), txt_currency_id.RowData, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_exchange_rate").GetType.GetProperty("DecimalValue")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_exchange_rate"), currency_rate.Item("exchange_rate"), Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_based_rate").GetType.GetProperty("DecimalValue")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_based_rate"), currency_rate.Item("based_rate"), Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_account").GetType.GetProperty("Text")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_account"), txt_account_id.Text, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_account_name").GetType.GetProperty("Text")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_account_name"), txt_account_name.Text, Nothing)
            End If
        Catch e As Exception
            MsgBox(e.Message)
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_project").GetType.GetProperty("Text")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_project"), txt_project_id.Text, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_department").GetType.GetProperty("Text")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_department"), txt_department_id.Text, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mc As System.Reflection.PropertyInfo = objForm.Controls("dgMain").GetType.GetProperty("AutoGenerateColumns")
            If Not mc Is Nothing Then
                mc.SetValue(objForm.Controls("dgmain"), False, Nothing)
            End If
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("dgMain").GetType.GetProperty("DataSource")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("dgMain"), dt, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("begbal_date")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_trans_date.Value, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("jbooks_id")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_jbooks_id.Value, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("trans_date")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_trans_date.Value.ToString("yyyy-MM-dd"), Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("MyParent")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, Me, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("account_id")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_account_id.Value, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("trans_id")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_trans_id.Value, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("book_id")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_book_id.Value, Nothing)
            End If
        Catch
        End Try
        'project,department,allocation,line_remarks
        'Try
        '    Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("line_remarks")
        '    If Not mn Is Nothing Then
        '        mn.SetValue(objForm, txt_line_remarks.Text)
        '    End If
        'Catch
        'End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("department_id")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_department_id.Value, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("project_id")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_project_id.Value, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("currency_id")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_currency_id.Value, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("exchange_rate")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_exchange_rate.DecimalValue, Nothing)
            End If
        Catch
        End Try
        Try
            Dim mn As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("based_rate")
            If Not mn Is Nothing Then
                mn.SetValue(objForm, txt_based_rate.DecimalValue, Nothing)
            End If
        Catch
        End Try
        Return objForm
    End Function
    Private Function saveTrans(ByVal dt As DataTable, ByVal tbl As String, ByVal pk As String, ByVal fk() As String, Optional str() As String = Nothing) As String
        Dim sql As String = ""

        For Each row As DataRow In dt.Rows
            Dim dic As New Dictionary(Of String, String)
            Dim dic_ref As New Dictionary(Of String, String)
            Dim isInsert = False
            dic_ref.Add("sel", False)
            dic_ref.Add(pk, Nothing)
            If row.Item(pk).ToString.Contains("ag-") Then
                isInsert = True
            End If
            For Each col As DataColumn In dt.Columns
                Dim val As String = ""
                If TypeOf (row.Item(col.ColumnName)) Is DateTime Then
                    val = CType(row.Item(col.ColumnName), Date).ToString("yyyy-MM-dd")
                Else
                    val = row.Item(col.ColumnName).ToString
                End If
                dic.Add(col.ColumnName, If(val Is Nothing, "", val))
            Next
            If dic.ContainsKey(fk(0)) Then
                dic.Item(fk(0)) = fk(1)
            Else
                dic.Add(fk(0), fk(1))
            End If
            If str.Length > 0 Then
                For Each a In str
                    If dic.ContainsKey(a) Then
                        dic.Remove(a)
                    End If
                Next
            End If
            If isInsert Then
                If dic.ContainsKey("deleted") Then
                    If dic.Item("deleted").ToString = "False" Then
                        dic.Remove("deleted")
                        dic_ref.Add("ref_no", dic.Item("ref_no"))
                        dic.Remove("ref_no")
                        dic.Remove("sel")
                        Dim tmp_sql = genInsert(tbl, dic)
                        Dim id As DataTable = Query(tmp_sql & ";SELECT LAST_INSERT_ID() AS id;")
                        dic_ref.Item(pk) = id.Rows(0).Item("id")
                        sql &= genInsert(tbl & "_ref", dic_ref) & ";"
                    End If
                Else
                    dic_ref.Add("ref_no", dic.Item("ref_no"))
                    dic.Remove("ref_no")
                    Dim tmp_sql = genInsert(tbl, dic)
                    Dim id As DataTable = Query(tmp_sql & ";SELECT LAST_INSERT_ID() AS id;")
                    dic_ref.Item(pk) = id.Rows(0).Item("id")
                    sql &= genInsert(tbl & "_ref", dic_ref) & ";"
                End If
            Else
                If dic.ContainsKey("deleted") Then
                    If dic.Item("deleted").ToString = "True" Then
                        Query(String.Format("DELETE FROM {0} WHERE {1} = '{2}';", tbl, pk, dic.Item(pk)))
                    Else
                        dic.Remove("deleted")
                        dic.Remove("sel")
                        dic_ref.Item(pk) = dic.Item(pk)
                        dic_ref.Add("ref_no", dic.Item("ref_no"))
                        dic_ref.Remove("sel")
                        dic.Remove("ref_no")
                        Query(genUpdate(tbl, dic))
                        sql &= genUpdate(tbl & "_ref", dic_ref) & ";"
                    End If
                Else
                    dic_ref.Item(pk) = dic.Item(pk)
                    dic_ref.Add("ref_no", dic.Item("ref_no"))
                    dic_ref.Remove("sel")
                    dic.Remove("ref_no")
                    Query(genUpdate(tbl, dic))
                    sql &= genUpdate(tbl & "_ref", dic_ref) & ";"
                End If
            End If
        Next

        Return sql
    End Function
    Private Sub validateModule()
        Dim dr As DataRow = txt_account_id.RowData
        Dim debit = txt_debit.DecimalValue
        Dim debit_based = txt_debit_based.DecimalValue
        Dim credit = txt_credit.DecimalValue
        Dim credit_based = txt_credit_based.DecimalValue
        Select Case dr("validation").ToString
            Case "0", "1", "10" 'debit/credit
            Case "2" 'ar debit
                Dim ar_form = getForm("ar", ds.Tables(jbooksTable))
                If ar_form.ShowDialog = DialogResult.OK Then
                    init_load()
                    disable_control(Me, main.dicAction.Item(module_code))
                    Dim dt As DataTable = dgMain.DataSource
                    bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
                End If
            Case "6" 'iv debit
                ds.Tables(ivTable).Clear()
                Dim iv_form = getForm("iv", ds.Tables(ivTable))
                If iv_form.ShowDialog = DialogResult.OK Then
                    init_load()
                    'Dim txt_total_amount = CType(iv_form.Controls("txt_total_amount"), user_control.textbox)
                    'Dim txt_total_based = CType(iv_form.Controls("txt_total_based"), user_control.textbox)
                    'txt_debit.DecimalValue = txt_total_amount.DecimalValue
                    'txt_debit_based.DecimalValue = txt_total_based.DecimalValue
                    'saveModule(iv_form)
                    disable_control(Me, main.dicAction.Item(module_code))
                    Dim dt As DataTable = dgMain.DataSource
                    bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
                End If
            Case "8" 'pre debit
                ds.Tables(preTable).Clear()
                Dim pre_form = getForm("pre", ds.Tables(preTable))
                If pre_form.ShowDialog = DialogResult.OK Then
                    init_load()
                    'Dim txt_total_amount = CType(pre_form.Controls("txt_total_amount"), user_control.textbox)
                    'Dim txt_total_based = CType(pre_form.Controls("txt_total_based"), user_control.textbox)
                    'txt_debit.DecimalValue = txt_total_amount.DecimalValue
                    'txt_debit_based.DecimalValue = txt_total_based.DecimalValue
                    'saveModule(pre_form)
                    disable_control(Me, main.dicAction.Item(module_code))
                    Dim dt As DataTable = dgMain.DataSource
                    bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
                End If
            Case "9" 'fa debit
                ds.Tables(faTable).Clear()
                Dim fa_form = getForm("fa", ds.Tables(faTable))
                If fa_form.ShowDialog = DialogResult.OK Then
                    init_load()
                    'Dim txt_total_amount = CType(fa_form.Controls("txt_total_amount"), user_control.textbox)
                    'Dim txt_total_based = CType(fa_form.Controls("txt_total_based"), user_control.textbox)
                    'txt_debit.DecimalValue = txt_total_amount.DecimalValue
                    'txt_debit_based.DecimalValue = txt_total_based.DecimalValue
                    'saveModule(fa_form)
                    disable_control(Me, main.dicAction.Item(module_code))
                    Dim dt As DataTable = dgMain.DataSource
                    bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
                End If
            Case "3" 'ap credit
                Dim ap_form = getForm("ap", ds.Tables(jbooksTable))
                If ap_form.ShowDialog = DialogResult.OK Then
                    init_load()
                    disable_control(Me, main.dicAction.Item(module_code))
                    Dim dt As DataTable = dgMain.DataSource
                    bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
                End If
            Case "4" 'ewt credit
                ds.Tables(ewtTable).Clear()
                Dim ewt_form = getForm("ewt", ds.Tables(ewtTable))
                If ewt_form.ShowDialog = DialogResult.OK Then
                    init_load()
                    'Dim txt_total_amount = CType(ewt_form.Controls("txt_total_amount"), user_control.textbox)
                    'Dim txt_total_based = CType(ewt_form.Controls("txt_total_based"), user_control.textbox)
                    'txt_credit.DecimalValue = txt_total_amount.DecimalValue
                    'txt_credit_based.DecimalValue = txt_total_based.DecimalValue
                    'saveModule(ewt_form)
                    disable_control(Me, main.dicAction.Item(module_code))
                    Dim dt As DataTable = dgMain.DataSource
                    bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
                End If
            Case "5" 'ft credit
                ds.Tables(ftTable).Clear()
                Dim ft_form = getForm("ft", ds.Tables(ftTable))
                If ft_form.ShowDialog = DialogResult.OK Then
                    init_load()
                    'Dim txt_total_amount = CType(ft_form.Controls("txt_total_amount"), user_control.textbox)
                    'Dim txt_total_based = CType(ft_form.Controls("txt_total_based"), user_control.textbox)
                    'txt_credit.DecimalValue = txt_total_amount.DecimalValue
                    'txt_credit_based.DecimalValue = txt_total_based.DecimalValue
                    'saveModule(ft_form)
                    disable_control(Me, main.dicAction.Item(module_code))
                    Dim dt As DataTable = dgMain.DataSource
                    bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
                End If
            Case "7" 'ov credit
                ds.Tables(ovTable).Clear()
                Dim ov_form = getForm("ov", ds.Tables(ovTable))
                If ov_form.ShowDialog = DialogResult.OK Then
                    init_load()
                    'Dim txt_total_amount = CType(ov_form.Controls("txt_total_amount"), user_control.textbox)
                    'Dim txt_total_based = CType(ov_form.Controls("txt_total_based"), user_control.textbox)
                    'txt_credit.DecimalValue = txt_total_amount.DecimalValue
                    'txt_credit_based.DecimalValue = txt_total_based.DecimalValue
                    'saveModule(ov_form)
                    disable_control(Me, main.dicAction.Item(module_code))
                    Dim dt As DataTable = dgMain.DataSource
                    bind_control(dgMain, "jbooks_id", dt, Me, "panel_hdr")
                End If
        End Select
        transmode = ""
    End Sub
    Private Sub saveModule(Optional form As Form = Nothing)
        Dim dr As DataRow = txt_account_id.RowData
        Dim debit = txt_debit.DecimalValue
        Dim debit_based = txt_debit_based.DecimalValue
        Dim credit = txt_credit.DecimalValue
        Dim credit_based = txt_credit_based.DecimalValue
        Select Case dr("validation").ToString
            Case "0", "1", "10" 'debit/credit
                If (debit = 0 And credit = 0) Or (debit <> 0 And debit_based = 0) Or (credit <> 0 And credit_based = 0) Then
                    MsgBox("No debit or credit found")
                Else
                    If txt_trans_id.Value = "" Then
                        Dim id As DataTable = Query(saveHeader())
                        Query(saveJBooks(id.Rows(0).Item("id").ToString))
                    Else
                        Query(saveJBooks(txt_trans_id.Value))
                    End If
                End If
            Case "2" 'ar debit
            Case "6" 'iv debit
                If debit = 0 Or (debit <> 0 And debit_based = 0) Then
                    MsgBox("No debit found")
                Else
                    If transmode = "insert" Then
                        Dim _id As DataTable = Nothing
                        If txt_trans_id.Value = "" Then
                            Dim id As DataTable = Query(saveHeader())
                            _id = Query(saveJBooks(id.Rows(0).Item("id").ToString))
                        Else
                            _id = Query(saveJBooks(txt_trans_id.Value))
                        End If
                        Try
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, ivTable, "input_vat_id", {"jbooks_id", _id.Rows(0).Item("id").ToString}, {"currency_name", "general_name", "address", "tin", "ref_input_vat_id", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    Else
                        Try
                            Query(saveJBooks())
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, ivTable, "input_vat_id", {"jbooks_id", txt_jbooks_id.Value}, {"currency_name", "general_name", "address", "tin", "ref_input_vat_id", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    End If
                End If
            Case "8" 'pre debit
                If debit = 0 Or (debit <> 0 And debit_based = 0) Then
                    MsgBox("No debit found")
                Else
                    If transmode = "insert" Then
                        Dim _id As DataTable = Nothing
                        If txt_trans_id.Value = "" Then
                            Dim id As DataTable = Query(saveHeader())
                            _id = Query(saveJBooks(id.Rows(0).Item("id").ToString))
                        Else
                            _id = Query(saveJBooks(txt_trans_id.Value))
                        End If
                        Try
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, preTable, "prepaid_id", {"jbooks_id", _id.Rows(0).Item("id").ToString}, {"currency_name", "ref_prepaid_id", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    Else
                        Try
                            Query(saveJBooks())
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, preTable, "prepaid_id", {"jbooks_id", txt_jbooks_id.Value}, {"currency_name", "ref_prepaid_id", "status", "minimum"})
                            Query(sql)
                        Catch e As Exception
                            Console.WriteLine(e.Message)
                        End Try
                    End If
                End If
            Case "9" 'fa debit
                If debit = 0 Or (debit <> 0 And debit_based = 0) Then
                    MsgBox("No debit found")
                Else
                    If transmode = "insert" Then
                        Dim _id As DataTable = Nothing
                        If txt_trans_id.Value = "" Then
                            Dim id As DataTable = Query(saveHeader())
                            _id = Query(saveJBooks(id.Rows(0).Item("id").ToString))
                        Else
                            _id = Query(saveJBooks(txt_trans_id.Value))
                        End If
                        Try
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, faTable, "fixed_asset_id", {"jbooks_id", _id.Rows(0).Item("id").ToString}, {"currency_name", "ref_fixed_asset_id", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    Else
                        Try
                            Query(saveJBooks())
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, faTable, "fixed_asset_id", {"jbooks_id", txt_jbooks_id.Value}, {"currency_name", "ref_fixed_asset_id", "status", "minimum"})
                            Query(sql)
                        Catch e As Exception
                        End Try
                    End If
                End If
            Case "3" 'ap credit
            Case "4" 'ewt credit
                If credit = 0 Or (credit <> 0 And credit_based = 0) Then
                    MsgBox("No debit found")
                Else
                    If transmode = "insert" Then
                        Dim _id As DataTable = Nothing
                        If txt_trans_id.Value = "" Then
                            Dim id As DataTable = Query(saveHeader())
                            _id = Query(saveJBooks(id.Rows(0).Item("id").ToString))
                        Else
                            _id = Query(saveJBooks(txt_trans_id.Value))
                        End If
                        Try
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, ewtTable, "ewt_id", {"jbooks_id", _id.Rows(0).Item("id").ToString}, {"currency_name", "general_name", "ewt_code", "ref_ewt_id", "general_code", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    Else
                        Try
                            Query(saveJBooks())
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, ewtTable, "ewt_id", {"jbooks_id", txt_jbooks_id.Value}, {"currency_name", "general_name", "ewt_code", "ref_ewt_id", "general_code", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    End If
                End If
            Case "5" 'ft credit
                If credit = 0 Or (credit <> 0 And credit_based = 0) Then
                    MsgBox("No debit found")
                Else
                    If transmode = "insert" Then
                        Dim _id As DataTable = Nothing
                        If txt_trans_id.Value = "" Then
                            Dim id As DataTable = Query(saveHeader())
                            _id = Query(saveJBooks(id.Rows(0).Item("id").ToString))
                        Else
                            _id = Query(saveJBooks(txt_trans_id.Value))
                        End If
                        Try
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, ftTable, "final_tax_id", {"jbooks_id", _id.Rows(0).Item("id").ToString}, {"currency_name", "general_name", "final_tax_code", "ref_final_tax_id", "general_code", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    Else
                        Try
                            Query(saveJBooks())
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, ftTable, "final_tax_id", {"jbooks_id", txt_jbooks_id.Value}, {"currency_name", "general_name", "final_tax_code", "ref_final_tax_id", "general_code", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    End If
                End If
            Case "7" 'ov credit
                If credit = 0 Or (credit <> 0 And credit_based = 0) Then
                    MsgBox("No debit found")
                Else
                    If transmode = "insert" Then
                        Dim _id As DataTable = Nothing
                        If txt_trans_id.Value = "" Then
                            Dim id As DataTable = Query(saveHeader())
                            _id = Query(saveJBooks(id.Rows(0).Item("id").ToString))
                        Else
                            _id = Query(saveJBooks(txt_trans_id.Value))
                        End If
                        Try
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, ovTable, "output_vat_id", {"jbooks_id", _id.Rows(0).Item("id").ToString}, {"currency_name", "general_name", "address", "tin", "ref_output_vat_id", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    Else
                        Try
                            Query(saveJBooks())
                            Dim _grid = CType(form.Controls("dgMain"), DataGridView)
                            Dim _dt As DataTable = _grid.DataSource
                            Dim sql = saveTrans(_dt, ovTable, "output_vat_id", {"jbooks_id", txt_jbooks_id.Value}, {"currency_name", "general_name", "address", "tin", "ref_output_vat_id", "status", "minimum"})
                            Query(sql)
                        Catch
                        End Try
                    End If
                End If
        End Select
        init_load()
    End Sub
    Private Function saveHeader() As String
        Dim str As String = ""
        Dim dic As New Dictionary(Of String, String)

        Dim trans_id = primary_key.Value
        Dim trans_no = "BEG"
        Dim trans_date = txt_trans_date.Value.ToString("yyyy-MM-dd")
        Dim book_id = txt_book_id.Value
        Dim journal_id = 8
        Dim currency_id = txt_currency_id.Value

        dic.Add("trans_id", trans_id)
        dic.Add("trans_no", trans_no)
        dic.Add("trans_date", trans_date)
        dic.Add("book_id", book_id)
        dic.Add("journal_id", journal_id)
        dic.Add("currency_id", currency_id)

        If transmode = "insert" Then
            str = genInsert("trans_header", dic) & ";SELECT LAST_INSERT_ID() AS id;"
        Else
            str = genUpdate("trans_header", dic)
        End If
        Return str
    End Function
    Private Function saveJBooks(Optional fk As String = "") As String
        Dim str As String = ""
        Dim dic As New Dictionary(Of String, String)

        Dim jbooks_id = txt_jbooks_id.Value
        Dim trans_id = fk
        Dim project_id = txt_project_id.Value
        Dim department_id = txt_department_id.Value
        Dim account_id = txt_account_id.Value
        'Dim line_remarks = txt_line_remarks.Value
        Dim debit = txt_debit.DecimalValue
        Dim credit = txt_credit.DecimalValue
        Dim debit_based = txt_debit_based.DecimalValue
        Dim credit_based = txt_credit_based.DecimalValue
        'Dim bookUnitNoId = txt_book_unit_no_id.Value

        dic.Add("jbooks_id", jbooks_id)
        dic.Add("trans_id", trans_id)
        dic.Add("project_id", project_id)
        dic.Add("currency_id", txt_currency.Value)
        dic.Add("exchange_rate", txt_exchange_rate.DecimalValue)
        dic.Add("based_rate", txt_based_rate.DecimalValue)
        dic.Add("department_id", department_id)
        dic.Add("account_id", account_id)
        'dic.Add("line_remarks", line_remarks)
        dic.Add("debit", debit)
        dic.Add("credit", credit)
        dic.Add("debit_based", debit_based)
        dic.Add("credit_based", credit_based)
        dic.Add("ref_jbooks_id", Nothing)
        'dic.Add("book_unit_no_id", bookUnitNoId)
        If department_id = "" Then
            dic.Item("department_id") = Nothing
        End If
        If trans_id = "" Then
            dic.Remove("trans_id")
        End If
        If project_id = "" Then
            dic.Item("project_id") = Nothing
        End If
        If account_id = "" Then
            dic.Item("account_id") = Nothing
        End If

        If jbooks_id = "" Then
            str = genInsert("trans_jbooks", dic) & ";SELECT LAST_INSERT_ID() AS id;"
        Else
            str = genUpdate("trans_jbooks", dic)
        End If
        Return str
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim err As Boolean = False
        Dim pk As Integer = 0
        Dim addSave As Boolean = False

        If txt_debit.DecimalValue = 0 And txt_credit.DecimalValue = 0 Then
            MsgBox("No Details Found.")
            Exit Sub
        End If
        If transmode = "insert" Then
            If txt_trans_id.Value = "" Then
                Dim id As DataTable = Query(saveHeader())
                Dim dt As DataTable = Query(saveJBooks(id.Rows(0).Item("id")))
            Else
                If DataExist(dgMain, {"jbooks_id", txt_jbooks_id.Value}, {"account_id", "project_id", "department_id"}, {txt_account_id.Value, txt_project_id.Value, txt_department_id.Value},, False) Then
                    MsgBox("Record already exist")
                    err = True
                Else
                    Dim id As DataTable = Query(saveJBooks(txt_trans_id.Value))
                    pk = id.Rows(0).Item("id")
                    addSave = True
                End If
            End If
        ElseIf transmode = "update" Then
            If DataExist(dgMain, {"jbooks_id", txt_jbooks_id.Value}, {"account_id", "project_id", "department_id"}, {txt_account_id.Value, txt_project_id.Value, txt_department_id.Value}, False, False) Then
                MsgBox("Record already exist")
                err = True
            Else
                Dim dt As DataTable = Query(saveJBooks())
                pk = txt_jbooks_id.Value
                MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
            End If
        ElseIf transmode = "remove" Then
        End If
        If Not err Then
            disable_control(Me, main.dicAction.Item(module_code))
            'txt_book_unit_no_id.Text = ""
            init_load()
            For Each row As DataGridViewRow In dgMain.Rows
                If row.Cells("jbooks_id").Value.ToString = pk Then
                    row.Cells(0).Selected = True
                End If
            Next
            If addSave Then
                saveAddAnother(btnInsert)
            End If
        End If
        transmode = ""
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Try
            Dim a As System.Reflection.PropertyInfo = gl_begbal_report_filter.GetType.GetProperty("trans_id")
            If Not a Is Nothing Then
                a.SetValue(gl_begbal_report_filter, txt_trans_id.Text, Nothing)
            End If
            Dim b As System.Reflection.PropertyInfo = gl_begbal_report_filter.GetType.GetProperty("trans_date")
            If Not b Is Nothing Then
                b.SetValue(gl_begbal_report_filter, txt_trans_date.Value.ToString("MMMM dd, yyyy"), Nothing)
            End If
            gl_begbal_report_filter.ShowDialog()
        Catch err As Exception
            MsgBox(err.Message)
        End Try
    End Sub

    Private Sub txt_currency_Leave(sender As Object, e As EventArgs) Handles txt_currency.Leave

        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_currency")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("currency_name like '{0}'", txt_currency.Text.ToString.Replace("'", "''")))
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
                txt_currency.RowData = dr
                txt_currency.Value = dr("currency_id")
                txt_currency.Text = dr("currency_name")
                Dim sql As String = String.Format("SELECT * FROM lib_erp_currency_rate WHERE currency_id = {0} AND effectivitydate <= '{1}' ORDER BY effectivitydate DESC LIMIT 1", txt_currency.Value, txt_trans_date.Value.ToString("yyyy-MM-dd"))
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

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        deleteHeader(dgMain, _serverDBMain, jbooksTable, "jbooks_id", "sel", main.log_id)
        init_load()
    End Sub
    Private Sub TransactionFormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If transmode <> "" Then
            Dim confirm = MsgBox("There are transactions that are not yet done. Are you sure to exit the form?", MsgBoxStyle.YesNo, "Transaction Undone.")
            If confirm = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles txtsearch.TextChange
        Dim q As String = txtsearch.Text
        If txtsearch.TextSource <> "" Then
            Dim cols = txtsearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            'Dim dt As DataTable = dgMain.DataSource
            Dim selectedRows = MyDT.[Select](selectQuery.Substring(4), txtsearch.TextSource & " ASC")
            If selectedRows.Length > 0 Then
                'If currentSearchIndex >= selectedRows.Length Then
                '    currentSearchIndex = 0
                'End If
                'Dim selectedID As String = selectedRows(currentSearchIndex).Item("jbooks_id").ToString
                'dgMain.ClearSelection()
                'For Each row As DataGridViewRow In dgMain.Rows
                '    If row.Cells("jbooks_id").Value.ToString = selectedID Then
                '        row.Selected = True
                '        Dim tmp_index = dt.Rows.IndexOf(selectedRows(currentSearchIndex))
                '        dgMain.FirstDisplayedScrollingRowIndex = tmp_index
                '    End If
                'Next
                Dim newDT = MyDT.Clone
                newDT.Clear()
                For Each dr As DataRow In selectedRows
                    newDT.ImportRow(dr)
                Next
                dgMain.DataSource = newDT
            Else
                dgMain.DataSource = MyDT
            End If
        Else
            dgMain.DataSource = MyDT
        End If
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        If txt_account_id.RowData IsNot Nothing Then
            If "23456789".Contains(txt_account_id.RowData.Item("validation").ToString) Then
                transmode = "update"
                validateModule()
            End If
        End If
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnInsert)
        dicShortCut.Add(114, btnUpdate)
        dicShortCut.Add(115, btnRemove)
        dicShortCut.Add(116, btnPrint)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub


    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_book_unit_no_id_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_book_unit_no_id_Leave(sender As Object, e As EventArgs)

        'If My.Settings._enableBookUnit Then

        '    Dim sql As String = String.Format("SELECT * FROM lib_erp_book_unit_no WHERE book_id = '{0}'", txt_book_id.Value)
        '    Dim dt As DataTable = FsQuery(sql)
        '    If dt.Rows.Count = 0 Then
        '        MsgBox("No record found.")
        '    Else
        '        Dim dr As DataRow = Nothing
        '        If dt.Rows.Count = 1 Then
        '            dr = dt.Rows(0)
        '        Else
        '            Dim str_filter = String.Format("book_unit_no_code = '{0}' OR book_unit_no_name = '{0}'", txt_book_unit_no_id.Text.ToString())
        '            Dim dra() As DataRow = dt.Select(str_filter)
        '            If dra.Count > 0 Then
        '                dr = dra(0)
        '            Else
        '                browse.dt = dt
        '                browse.format("Code,Name", "book_unit_no_code,book_unit_no_name", "100,200")
        '                If browse.ShowDialog() = DialogResult.OK Then
        '                    If browse.dgview.SelectedRows.Count > 0 Then
        '                        dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
        '                    End If
        '                End If
        '            End If
        '        End If
        '        'If Not dr Is Nothing Then
        '        '    txt_book_unit_no_id.RowData = dr
        '        '    txt_book_unit_no_id.Text = dr("book_unit_no_name")
        '        '    txt_book_unit_no_id.Value = dr("book_unit_no_id")
        '        'End If
        '    End If

        'Else

        '    Dim sql As String = String.Format("SELECT * FROM lib_erp_project_unit_no WHERE project_id = '{0}'", txt_project_id.Value)
        '    Dim dt As DataTable = FsQuery(sql)
        '    If dt.Rows.Count = 0 Then
        '        MsgBox("No record found.")
        '    Else
        '        Dim dr As DataRow = Nothing
        '        If dt.Rows.Count = 1 Then
        '            dr = dt.Rows(0)
        '        Else
        '            Dim str_filter = String.Format("project_unit_no_codes = '{0}' OR project_unit_no_names = '{0}'", txt_book_unit_no_id.Text.ToString())
        '            Dim dra() As DataRow = dt.Select(str_filter)
        '            If dra.Count > 0 Then
        '                dr = dra(0)
        '            Else
        '                browse.dt = dt
        '                browse.format("Code,Name", "project_unit_no_codes,project_unit_no_names", "100,200")
        '                If browse.ShowDialog() = DialogResult.OK Then
        '                    If browse.dgview.SelectedRows.Count > 0 Then
        '                        dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
        '                    End If
        '                End If
        '            End If
        '        End If
        '        'If Not dr Is Nothing Then
        '        '    txt_book_unit_no_id.RowData = dr
        '        '    txt_book_unit_no_id.Text = dr("project_unit_no_names")
        '        '    txt_book_unit_no_id.Value = dr("project_unit_no_id")
        '        'End If
        '    End If

        'End If


    End Sub

    Private Sub txt_project_id_Load(sender As Object, e As EventArgs) Handles txt_project_id.Load

    End Sub
End Class