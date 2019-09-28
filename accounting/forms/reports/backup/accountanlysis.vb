Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Public Class accountanlysis

    Dim ds As New DataSet
    Dim ds_book As New FileSetupSet

    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave

        Dim data_currency As DataTable = FsQuery("SELECT a.currency_name,a.currency_code,a.currency_id FROM lib_erp_currency a")
        If data_currency.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data_currency.Rows.Count = 1 Then
                dr = data_currency.Rows(0)
            Else
                Dim dra() As DataRow = data_currency.Select("currency_code like '" & txt_currency_id.Text & "'")
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

    Private Sub txt_project_id_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave

        Dim data As DataTable = FsQuery("SELECT a.project_name,a.project_code,a.project_id FROM lib_erp_project a")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("project_code like '" & txt_project_id.Text & "'")
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
                Dim dra() As DataRow = data.Select("department_code like '" & txt_department_id.Text & "'")
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
            End If
        End If
    End Sub

    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged, rdo2.CheckedChanged, rdo3.CheckedChanged
        Dim range As String = getRdoValue(range_filter)
        If range = "2" Then
            txt_date_from.Enabled = False
        Else
            txt_date_from.Enabled = True
        End If
    End Sub

    Private Sub withDepartment_CheckedChanged(sender As Object, e As EventArgs)
        txt_department_id.Enabled = False
        If withDepartment.Checked Then
            txt_department_id.Enabled = True
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim range As String = getRdoValue(range_filter)
        Dim sort As String = txt_sortby.Value
        Dim currency As String = txt_filter_currency.Value
        Dim amount As String = getRdoValue(currency_1)
        Dim project As String = txt_filter_project.Value
        Dim account As String = account_filter.Value
        Dim printFilter As String = filter1.Value

        Dim date_from = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim currency_id = txt_currency_id.Value
        Dim project_id = txt_project_id.Value
        Dim department_id = txt_department_id.Value
        Dim account_id = txt_account_id.Value
        Dim general_id = txt_general_id.Value
        Dim journal_id = txt_jbooks.Value

        Dim wProject = withProject.Checked
        Dim wDepartment = withDepartment.Checked
        Dim oneLinePrint = printInOneLine.Checked

        Dim arr_id = getCheckedGrid("book_id", "book_name", "sel", dgBooks, "", False, "Select Book First.")
        Dim str_id As String = ""

        If arr_id.Length = 0 Then
            Exit Sub
        Else
            ' validation
            If account = "" Then
                MsgBox("Select Filter for Account first.")
                account_filter.Focus()
                Exit Sub
            End If
            Select Case account
                Case "1"
                Case "2"
                    If account_id = "" Then
                        MsgBox("Select Account First")
                        txt_account_id.Focus()
                        Exit Sub
                    End If
                Case "3"
                    If general_id = "" Then
                        MsgBox("Select General Reference First")
                        txt_general_id.Focus()
                        Exit Sub
                    End If
                Case "4"
                    If account_id = "" Or general_id = "" Then
                        MsgBox("Select Account and/or General Reference First")
                        txt_account_id.Focus()
                        Exit Sub
                    End If
            End Select

            For i As Integer = 0 To arr_id.Length - 1
                str_id &= "," & arr_id(i)
            Next

            str_id.Substring(1)

            If Not allJBooks.Checked Then
                If txt_jbooks.Value = "" Then
                    MsgBox("No Journal Selected.")
                    Exit Sub
                End If
            End If
            If range <> "2" Then
                If date_from > date_to Then
                    MsgBox("Invalid date range.")
                    Exit Sub
                End If
            End If

            If currency = "" Then
                MsgBox("Select Filter for Currency First.")
                txt_filter_currency.Focus()
                Exit Sub
            End If
            If currency = "3" Then
                If currency_id = "" Then
                    MsgBox("Choose currency first.")
                    Exit Sub
                End If
            End If

            If project = "" Then
                MsgBox("Select Filter for Project/Department First.")
                txt_filter_project.Focus()
                Exit Sub
            End If
            If project = "3" Then
                If wProject Then
                    If project_id = "" Then
                        MsgBox("Choose project first.")
                        Exit Sub
                    End If
                End If
                If wDepartment Then
                    If department_id = "" Then
                        MsgBox("Choose department first.")
                        Exit Sub
                    End If
                End If
            End If
            If printFilter = "" Then
                MsgBox("SELECT Filter First.")
                filter1.Focus()
                Exit Sub
            End If
            If sort = "" Then
                MsgBox("Select Sort By First.")
                txt_sortby.Focus()
                Exit Sub
            End If
        End If

        Dim sql_balance As String = String.Format("SELECT " & _
            "a.trans_id,a.trans_date,a.trans_no,a.description " & _
            ",i.account_id,UPPER(i.account_name) AS account_name,UPPER(i.account_code) AS account_code " & _
            ",IF(c.replaced,c.replacement_check_no,c.check_no) AS check_no " & _
            ",IF(a.journal_id = '1',g.si_no " & _
                ",IF(a.journal_id = '2',e.si_no " & _
                    ",IF(a.journal_id = '3',d.si_no " & _
                        ",IF(a.journal_id = '4',f.si_no " & _
                            ",IF(a.journal_id = '6',h.si_no " & _
            ",''))))) AS si_no " & _
            ",IF(a.journal_id = '3',d.rr_no " & _
                ",IF(a.journal_id = '4',f.rr_no " & _
            ",'')) AS rr_no" & _
            ",IF(a.journal_id = '1',g.po_no " & _
                ",IF(a.journal_id = '3',d.po_no " & _
                    ",IF(a.journal_id = '6',h.po_no " & _
            ",''))) AS po_no " & _
            ",CASE i.validation " & _
                "WHEN '0' THEN p.general_id " & _
                "WHEN '1' THEN IF(a.journal_id = '2',q.general_id,p.general_id) " & _
                "WHEN '2' THEN p.general_id " & _
                "WHEN '3' THEN p.general_id " & _
                "WHEN '4' THEN r.general_id " & _
                "WHEN '5' THEN s.general_id " & _
                "WHEN '6' THEN t.general_id " & _
                "WHEN '7' THEN u.general_id " & _
                "WHEN '8' THEN p.general_id " & _
                "WHEN '9' THEN p.general_id " & _
                "WHEN '10' THEN p.general_id " & _
            "END AS general_id " & _
            ",CASE i.validation " & _
                "WHEN '0' THEN p.general_name " & _
                "WHEN '1' THEN IF(a.journal_id = '2',q.general_name,p.general_name) " & _
                "WHEN '2' THEN p.general_name " & _
                "WHEN '3' THEN p.general_name " & _
                "WHEN '4' THEN r.general_name " & _
                "WHEN '5' THEN s.general_name " & _
                "WHEN '6' THEN t.general_name " & _
                "WHEN '7' THEN u.general_name " & _
                "WHEN '8' THEN p.general_name " & _
                "WHEN '9' THEN p.general_name " & _
                "WHEN '10' THEN p.general_name " & _
            "END AS general_name " & _
            ",CASE i.validation " & _
                "WHEN '0' THEN b.debit " & _
                "WHEN '1' THEN IF(a.journal_id = '2',c.check_amount,b.debit) " & _
                "WHEN '2' THEN b.debit " & _
                "WHEN '3' THEN b.debit " & _
                "WHEN '4' THEN j.debit " & _
                "WHEN '5' THEN k.debit " & _
                "WHEN '6' THEN m.debit " & _
                "WHEN '7' THEN n.debit " & _
                "WHEN '8' THEN o.debit " & _
                "WHEN '9' THEN l.debit " & _
                "WHEN '10' THEN b.debit " & _
            "END AS debit " & _
            ",CASE i.validation " & _
                "WHEN '0' THEN b.credit " & _
                "WHEN '1' THEN IF(a.journal_id = '4',c.check_amount,b.credit) " & _
                "WHEN '2' THEN b.credit " & _
                "WHEN '3' THEN b.credit " & _
                "WHEN '4' THEN j.credit " & _
                "WHEN '5' THEN k.credit " & _
                "WHEN '6' THEN m.credit " & _
                "WHEN '7' THEN n.credit " & _
                "WHEN '8' THEN o.credit " & _
                "WHEN '9' THEN l.credit " & _
                "WHEN '10' THEN b.credit " & _
            "END AS credit " & _
            ",CASE i.validation " & _
                "WHEN '0' THEN b.debit_based " & _
                "WHEN '1' THEN IF(a.journal_id = '2',c.check_amount_based,b.debit_based) " & _
                "WHEN '2' THEN b.debit_based " & _
                "WHEN '3' THEN b.debit_based " & _
                "WHEN '4' THEN j.debit_based " & _
                "WHEN '5' THEN k.debit_based " & _
                "WHEN '6' THEN m.debit_based " & _
                "WHEN '7' THEN n.debit_based " & _
                "WHEN '8' THEN o.debit_based " & _
                "WHEN '9' THEN l.debit_based " & _
                "WHEN '10' THEN b.debit_based " & _
            "END AS debit_based " & _
            ",CASE i.validation " & _
                "WHEN '0' THEN b.credit_based " & _
                "WHEN '1' THEN IF(a.journal_id = '4',c.check_amount_based,b.credit_based) " & _
                "WHEN '2' THEN b.credit_based " & _
                "WHEN '3' THEN b.credit_based " & _
                "WHEN '4' THEN j.credit_based " & _
                "WHEN '5' THEN k.credit_based " & _
                "WHEN '6' THEN m.credit_amount_based " & _
                "WHEN '7' THEN n.credit_based " & _
                "WHEN '8' THEN o.credit_based " & _
                "WHEN '9' THEN l.credit_based " & _
                "WHEN '10' THEN b.credit_based " & _
            "END AS credit_based " & _
            "FROM erp_accounting.trans_header a " & _
            "LEFT JOIN erp_accounting.trans_jbooks b ON b.trans_id = a.trans_id " & _
            "LEFT JOIN erp_accounting.trans_checks c ON c.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN erp_accounting.trans_header_ap d ON d.trans_id = a.trans_id " & _
            "LEFT JOIN erp_accounting.trans_header_cr e ON e.trans_id = a.trans_id " & _
            "LEFT JOIN erp_accounting.trans_header_cv f ON f.trans_id = a.trans_id " & _
            "LEFT JOIN erp_accounting.trans_header_ib g ON g.trans_id = a.trans_id " & _
            "LEFT JOIN erp_accounting.trans_header_pc h ON h.trans_id = a.trans_id " & _
            "LEFT JOIN erp_file_setup.lib_erp_chart i ON i.account_id = b.account_id " & _
            "LEFT JOIN erp_accounting.trans_ewt j ON j.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN erp_accounting.trans_final_tax k ON k.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN erp_accounting.trans_fixed_asset l ON l.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN erp_accounting.trans_input_vat m ON m.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN erp_accounting.trans_output_vat n ON n.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN erp_accounting.trans_prepaid o ON o.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN erp_file_setup.lib_erp_general p ON p.general_id = b.general_id " & _
            "LEFT JOIN erp_file_setup.lib_erp_general q ON q.general_id = c.general_id " & _
            "LEFT JOIN erp_file_setup.lib_erp_general r ON r.general_id = j.general_id " & _
            "LEFT JOIN erp_file_setup.lib_erp_general s ON s.general_id = k.general_id " & _
            "LEFT JOIN erp_file_setup.lib_erp_general t ON t.general_id = m.general_id " & _
            "LEFT JOIN erp_file_setup.lib_erp_general u ON u.general_id = n.general_id " & _
            "")

        Select Case range
            Case "1"
                sql_balance &= String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)
            Case "2"
                sql_balance &= String.Format(" WHERE a.trans_date <= '{0}' ", date_to)
        End Select

        If range = "1" Or range = "2" Then
            sql_balance &= String.Format(" AND a.book_id IN ({0}) ", str_id.Substring(1))
        End If

        If Not allJBooks.Checked Then
            sql_balance &= String.Format(" AND a.journal_id = {0} ", journal_id)
        End If

        If range = "3" Then
            Dim tmp_sql = sql_balance & String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}' AND a.journal_id <> 0 ", date_from, date_to)
            sql_balance &= String.Format(" WHERE a.trans_date <= '{0}' AND a.journal_id = 0 UNION ", date_from) & tmp_sql
            sql_balance &= String.Format(" AND a.book_id IN ({0}) ", str_id.Substring(1))
            If Not allJBooks.Checked Then
                sql_balance &= String.Format(" AND a.journal_id = {0} ", journal_id)
            End If
        End If

        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin FROM erp_accounting.sys_default a LEFT JOIN erp_file_setup.lib_erp_company b ON b.company_id = a.company_id")

        Dim dt_balance As DataTable = Query(sql_balance)
        Dim dt_company As DataTable = Query(sql_company)

        ds.Clear()

        'For Each row As DataRow In dt_balance.Rows
        '    ds.Tables("Balance").ImportRow(row)
        'Next
        'For Each row As DataRow In dt_company.Rows
        '    ds.Tables("Company").ImportRow(row)
        'Next


    End Sub
    Private Sub loadBooks(ByVal id As String, Optional all As Boolean = False)

        dgBooks.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT False AS sel,b.book_id,c.book_code,c.book_name FROM erp_file_setup.lib_erp_journal a LEFT JOIN erp_file_setup.sys_acc_journal_book b ON b.journal_id = a.journal_id LEFT JOIN erp_file_setup.lib_erp_book c ON c.book_id = b.book_id ")

        If Not all Then
            sql &= String.Format("WHERE a.journal_id = {0} ", id)
        End If
        sql &= " GROUP BY c.book_id "

        Dim dt As DataTable = Query(sql)
        ds_book.Clear()

        For Each row As DataRow In dt.Rows
            ds_book.Tables("lib_erp_book").ImportRow(row)
        Next

        dgBooks.DataSource = ds_book.Tables("lib_erp_book")
    End Sub
    Private Sub accountanlysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBooks(0, True)
    End Sub

    Private Sub checkAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkAll.CheckedChanged
        For Each dr As DataGridViewRow In dgBooks.Rows
            dr.Cells("sel").Value = checkAll.Checked
        Next
    End Sub

    Private Sub allJBooks_CheckedChanged(sender As Object, e As EventArgs) Handles allJBooks.CheckedChanged
        txt_jbooks.Enabled = Not allJBooks.Checked
        If allJBooks.Checked Then
            loadBooks(0, True)
        Else
            txt_jbooks.Focus()
            allJBooks.Focus()
        End If
    End Sub

    Private Sub txt_jbooks_Leave(sender As Object, e As EventArgs) Handles txt_jbooks.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_journal ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("journal_name like '" & txt_jbooks.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "journal_code,journal_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_jbooks.RowData = dr
                txt_jbooks.Value = dr("journal_id")
                txt_jbooks.Text = dr("journal_name")
                loadBooks(dr("journal_id"))
            End If
        End If
    End Sub

    Private Sub rdo_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_1.CheckedChanged, rdo_2.CheckedChanged, rdo_3.CheckedChanged
        Dim _allocation = getRdoValue(allocation_filter)
        txt_allocation.Enabled = False
        If _allocation = "3" Then
            txt_allocation.Enabled = True
        End If
    End Sub

    Private Sub txt_allocation_Leave(sender As Object, e As EventArgs) Handles txt_allocation.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_allocation ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("allocation_name like '" & txt_allocation.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "allocation_code,allocation_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_allocation.RowData = dr
                txt_allocation.Value = dr("allocation_id")
                txt_allocation.Text = dr("allocation_name")
                'loadBooks(dr("journal_id"))
            End If
        End If
    End Sub

    Private Sub account_filter_Leave(sender As Object, e As EventArgs) Handles account_filter.Leave
        Dim data As DataTable = FsQuery("SELECT '1' AS id,'MULTIPLE ACCOUNTS' AS name " & _
                                        "UNION SELECT '2','PER ACCOUNT' " & _
                                        "UNION SELECT '3','PER GENERAL LIBRARIES WITH MULTIPLE ACCOUNTS' " & _
                                        "UNION SELECT '4','PER GENERAL LIBRARIES WITH PER ACCOUNT' " & _
                                        "")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & account_filter.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Name", "name", "300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                account_filter.RowData = dr
                account_filter.Value = dr("id")
                account_filter.Text = dr("name")
                txt_account_id.Enabled = False
                txt_general_id.Enabled = False
                btnImport.Enabled = False
                Select Case dr("id").ToString
                    Case "1"
                        btnImport.Enabled = True
                    Case "2"
                        txt_account_id.Enabled = True
                    Case "3"
                        btnImport.Enabled = True
                        txt_general_id.Enabled = True
                    Case "4"
                        txt_account_id.Enabled = True
                        txt_general_id.Enabled = True
                End Select
            End If
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        multiplecodesetup.ShowDialog()
    End Sub

    Private Sub txt_filter_currency_Leave(sender As Object, e As EventArgs) Handles txt_filter_currency.Leave
        Dim data As DataTable = FsQuery("SELECT '1' AS id,'All Currency without Grouping in PHP' AS name " & _
                                        "UNION SELECT '2','All Currency Group per Currency in Original Amount' " & _
                                        "UNION SELECT '3','Per Currency in Original Amount' " & _
                                        "UNION SELECT '4','All Currency Grouped per Currency in PHP' " & _
                                        "")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & txt_filter_currency.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Name", "name", "300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_filter_currency.RowData = dr
                txt_filter_currency.Value = dr("id")
                txt_filter_currency.Text = dr("name")
                currency_1.Visible = False
                currency_2.Visible = False
                Select Case dr("id")
                    Case "1"
                    Case "2"
                        currency_1.Visible = True
                    Case "3"
                        currency_2.Visible = True
                    Case "4"
                End Select
            End If
        End If
    End Sub

    Private Sub filter1_Leave(sender As Object, e As EventArgs) Handles filter1.Leave
        Dim data As DataTable = FsQuery("SELECT '1' AS id,'Simple Analysis without any Sub Total' AS name " & _
                                        "UNION SELECT '2','With Monthly Total' " & _
                                        "UNION SELECT '3','With Per Journal Total' " & _
                                        "UNION SELECT '4','Combination Of Monthly and Journal Total' " & _
                                        "")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & filter1.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Name", "name", "300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                filter1.RowData = dr
                filter1.Value = dr("id")
                filter1.Text = dr("name")
            End If
        End If
    End Sub

    Private Sub txt_sortby_Leave(sender As Object, e As EventArgs) Handles txt_sortby.Leave
        Dim data As DataTable = FsQuery("SELECT '1' AS id,'Reference No.' AS name " & _
                                        "UNION SELECT '2','Date' " & _
                                        "UNION SELECT '3','Name' " & _
                                        "UNION SELECT '4','Account Title' " & _
                                        "UNION SELECT '5','Journal Book' " & _
                                        "")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & txt_sortby.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Name", "name", "300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_sortby.RowData = dr
                txt_sortby.Value = dr("id")
                txt_sortby.Text = dr("name")
            End If
        End If
    End Sub

    Private Sub txt_filter_project_Leave(sender As Object, e As EventArgs) Handles txt_filter_project.Leave

        Dim data As DataTable = FsQuery("SELECT '1' AS id,'Without project / department' AS name " & _
                                        "UNION SELECT '2','All Project / Department Code Group per Combination' " & _
                                        "UNION SELECT '3','Group Per Project / Department Code' " & _
                                        "")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & txt_filter_project.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Name", "name", "300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_filter_project.RowData = dr
                txt_filter_project.Value = dr("id")
                txt_filter_project.Text = dr("name")
                withProject.Enabled = False
                withDepartment.Enabled = False
                txt_project_id.Enabled = False
                txt_department_id.Enabled = False
                If dr("id") = "3" Then
                    withProject.Enabled = True
                    withDepartment.Enabled = True
                    withPD_CheckedChanged(Nothing, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub withPD_CheckedChanged(sender As Object, e As EventArgs) Handles withProject.CheckedChanged, withDepartment.CheckedChanged
        txt_project_id.Enabled = False
        txt_department_id.Enabled = False
        If txt_filter_project.Value.ToString = "3" Then
            If withProject.Checked Then
                txt_project_id.Enabled = True
            End If
            If withDepartment.Checked Then
                txt_department_id.Enabled = True
            End If
        End If
    End Sub
End Class