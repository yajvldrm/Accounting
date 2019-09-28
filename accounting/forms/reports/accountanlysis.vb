Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class accountanlysis
    Private module_code As String = "ACC01013"
    Dim ds As New FileSetupSet
    Dim ds_report As New accountanalysis_set
    Dim journal_ids As New List(Of String)
    Dim book_ids As New List(Of String)
    Dim book_unit_ids As New List(Of String)
    Dim templates As String = Application.StartupPath & "\templates"
    Dim bsBookUnit As BindingSource = New BindingSource

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
                lbl_currency_name.Text = dr("currency_name")
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
                Dim dra() As DataRow = data.Select("project_code like '" & txt_project_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "project_code,project_name", "200,400")
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
                If My.Settings._enableProjectUnit Then
                    loadProjectUnit(dr("project_id"))
                End If
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
                    browse.format("Code,Name", "department_code,department_name", "200,400")
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
    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo3.CheckedChanged, rdo2.CheckedChanged, rdo1.CheckedChanged
        Dim range As String = getRdoValue(range_filter)
        If range = "2" Then
            txt_date_from.Enabled = False
            txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        Else
            txt_date_from.Enabled = True
            txt_date_to.MinDate = txt_date_from.Value
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click

        Dim sort As String = txt_sortby.Value
        Dim range As String = getRdoValue(range_filter)
        Dim account As String = getRdoValue(account_filter)
        Dim general As String = getRdoValue(general_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim allocation As String = getRdoValue(allocation_filter)
        Dim filter As String = getRdoValue(filter1)
        Dim runningBalance As Boolean = w_running_balance.Checked

        Dim date_from = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to = txt_date_to.Value.ToString("yyyy-MM-dd")

        Dim account_id = txt_account_id.Value
        Dim general_id = txt_general_id.Value
        Dim currency_id = txt_currency_id.Value
        Dim project_id = txt_project_id.Value
        Dim department_id = txt_department_id.Value
        Dim allocation_id = txt_allocation_id.Value
        Dim wProjDept As Boolean = withProjectDepartment.Checked
        Dim wComparison As Boolean = withComparison.Checked
        Dim arr_journal_id = getCheckedGrid("journal_id", "journal_name", "sel1", dgJournal, "", False, "Select Journal First.")
        Dim arr_book_id = getCheckedGrid("book_id", "book_name", "sel", dgBooks, "", False, "Select Book First.")
        Dim arr_book_unit_id = getCheckedGridUnit("book_unit_no_id", "book_unit_no_name", "sel2", dgBookUnit, "", False, "*no message*", False)

        Dim journal_id As String = String.Join(",", arr_journal_id) & ",8"
        Dim book_id As String = String.Join(",", arr_book_id)
        Dim book_unit_no_id As String = String.Join(",", arr_book_unit_id)

        If arr_journal_id.Length = 0 Then
            Exit Sub
        End If
        If arr_book_id.Length = 0 Then
            Exit Sub
        End If

        If account = "" Then
            MsgBox("Select Filter for Account first.")
            account_filter.Focus()
            Exit Sub
        End If
        Select Case account
            Case "1"
            Case "2"
                Dim sql_multiple_account As String = String.Format("SELECT GROUP_CONCAT(a.account_id) AS account_id " &
                        "FROM lib_acc_chart_multiple a " &
                        "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
                        "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
                Dim dt_multiple_account As DataTable = FsQuery(sql_multiple_account)
                If dt_multiple_account.Rows.Count > 0 Then
                    account_id = dt_multiple_account.Rows(0).Item("account_id").ToString
                End If
            Case "3"
                If account_id = "" Then
                    MsgBox("Select Account First")
                    txt_account_id.Focus()
                    Exit Sub
                End If
        End Select
        Select Case general
            Case "1"
            Case "2"
                Dim sql_multiple_general As String = String.Format("SELECT GROUP_CONCAT(a.general_id) AS general_id " &
                        "FROM lib_acc_general_multiple a " &
                        "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
                        "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
                Dim dt_multiple_general As DataTable = FsQuery(sql_multiple_general)
                If dt_multiple_general.Rows.Count > 0 Then
                    general_id = dt_multiple_general.Rows(0).Item("general_id").ToString
                End If
            Case "3"
                If general_id = "" Then
                    MsgBox("Select General Library First")
                    txt_general_id.Focus()
                    Exit Sub
                End If
        End Select

        If range <> "2" Then
            If date_from > date_to Then
                MsgBox("Invalid date range.")
                Exit Sub
            End If
        End If
        If allocation = "2" Then
            If allocation_id = "" Then
                MsgBox("Select Allocation First.")
                txt_allocation_id.Focus()
                Exit Sub
            End If
        End If
        If sort = "" Then
            MsgBox("Select Sort By First.")
            txt_sortby.Focus()
            Exit Sub
        End If
        Dim col As New List(Of KeyValuePair(Of String, String))
        'col.Add(New KeyValuePair(Of String, String)("@report_type", ""))
        col.Add(New KeyValuePair(Of String, String)("@dbMain", _serverDBMain))
        col.Add(New KeyValuePair(Of String, String)("@dbFS", _serverDBFS))
        col.Add(New KeyValuePair(Of String, String)("@general_id", general_id))
        col.Add(New KeyValuePair(Of String, String)("@range_type", range))
        col.Add(New KeyValuePair(Of String, String)("@date_from", date_from))
        col.Add(New KeyValuePair(Of String, String)("@date_to", date_to))
        col.Add(New KeyValuePair(Of String, String)("@currency_id", currency_id))
        'col.Add(New KeyValuePair(Of String, String)("@w_project_department", If(wProjDept, "1", "0")))
        col.Add(New KeyValuePair(Of String, String)("@project_id", project_id))
        col.Add(New KeyValuePair(Of String, String)("@department_id", department_id))
        col.Add(New KeyValuePair(Of String, String)("@journal_id", journal_id))
        col.Add(New KeyValuePair(Of String, String)("@book_id", book_id))
        col.Add(New KeyValuePair(Of String, String)("@unit_id", book_unit_no_id))
        col.Add(New KeyValuePair(Of String, String)("@account_id", account_id))
        'col.Add(New KeyValuePair(Of String, String)("@module_code", module_code))
        col.Add(New KeyValuePair(Of String, String)("@unit_type", If(My.Settings._enableBookUnit, "1", "2")))
        col.Add(New KeyValuePair(Of String, String)("@order_by", sort))

        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
                                                  "FROM {1}.sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                  "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

        Dim dt As DataTable = ExecuteWithParameter("get_account_analysis_new", ConnectionStringFS, CommandType.StoredProcedure, col)
        'Dim strParam = String.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}'", "", _serverDBMain, _serverDBFS, general_id, range, date_from, date_to, currency_id, If(wProjDept, "1", "0"), project_id, department_id, journal_id, book_id, book_unit_no_id, account_id, module_code)
        'MyDebugging.AddText("ExecuteWithParameter : get_account_analysis")
        'MyDebugging.AddText(strParam)
        Dim dt_company As DataTable = Query(sql_company)

        ds_report.Tables("Account").Clear()
        ds_report.Tables("Company").Clear()
        dt = dt.DefaultView.ToTable

        For Each row As DataRow In dt.Rows
            ds_report.Tables("Account").ImportRow(row)
        Next

        For Each row As DataRow In dt_company.Rows
            ds_report.Tables("Company").ImportRow(row)
        Next

        If dt.Rows.Count = 0 Then
            MsgBox("No Records To Print.")
            Exit Sub
        End If

        Dim _range As String = ""
        Select Case range
            Case "1"
                _range = String.Format("From {0} to {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            Case "2"
                _range = String.Format("As of {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            Case "3"
                _range = String.Format("Range w/ Beginning Balance : {0} - {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
        End Select

        If sender.name = "btnPrint" Then
            If wComparison And currency = "2" Then
                Dim rep As New report_account_analysis_print
                rep.DataSource = ds_report
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                rep.range.Text = _range
                If book_unit_no_id <> "" Then
                    rep.GroupHeader7.Visible = True
                    rep.GroupFooter7.Visible = True
                Else
                    rep.GroupHeader7.GroupFields.Clear()
                    rep.GroupHeader7.Visible = False
                    rep.GroupFooter7.Visible = False
                End If
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                If currency = "1" Then
                    For Each row As DataRow In ds_report.Tables("Account").Rows
                        row.Item("debit") = row.Item("debit_based")
                        row.Item("credit") = row.Item("credit_based")
                    Next
                End If
                Dim rep As New report_account_analysis_print_1
                rep.DataSource = ds_report
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                rep.range.Text = _range
                If book_unit_no_id <> "" Then
                    rep.GroupHeader7.Visible = True
                    rep.GroupFooter7.Visible = True
                Else
                    rep.GroupHeader7.GroupFields.Clear()
                    rep.GroupHeader7.Visible = False
                    rep.GroupFooter7.Visible = False
                End If
                If Not wProjDept Then
                    rep.GroupHeader5.GroupFields.Clear()
                    rep.GroupHeader6.GroupFields.Clear()
                    rep.GroupHeader5.Visible = False
                    rep.GroupHeader6.Visible = False
                    rep.GroupFooter5.Visible = False
                    rep.GroupFooter6.Visible = False
                End If
                Select Case filter
                    Case "1"
                        rep.GroupHeader2.GroupFields.Clear()
                        rep.GroupHeader4.GroupFields.Clear()
                        rep.GroupHeader2.Visible = False
                        rep.GroupHeader4.Visible = False
                        rep.GroupFooter2.Visible = False
                        rep.GroupFooter4.Visible = False
                    Case "2"
                        rep.GroupHeader2.GroupFields.Clear()
                        rep.GroupHeader2.Visible = False
                        rep.GroupFooter2.Visible = False
                    Case "3"
                        rep.GroupHeader4.GroupFields.Clear()
                        rep.GroupHeader4.Visible = False
                        rep.GroupFooter4.Visible = False
                    Case "4"
                End Select
                If currency = "1" Then
                    rep.GroupHeader3.GroupFields.Clear()
                    rep.GroupHeader3.Visible = False
                    rep.GroupFooter3.Visible = False
                End If
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            End If
        Else
            Try
                lblLoad.Visible = True
                Dim dicHeader As New Dictionary(Of String, String)
                dicHeader.Add("companyName", "")
                dicHeader.Add("currencyName", "")
                dicHeader.Add("templateName", "")
                dicHeader.Add("range", _range)
                dicHeader.Add("w_running_balance", If(runningBalance, "1", "0"))
                If dt_company.Rows.Count > 0 Then
                    dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
                    dicHeader.Item("currencyName") = dt_company.Rows(0).Item("currency_name").ToString
                End If
                Dim strGrouping As String = "account_name"
                If filter = "3" Or filter = "4" Then
                    strGrouping &= ",journal_name"
                End If
                If currency_id <> "" Or currency = "2" Then
                    strGrouping &= ",currency_name"
                End If
                If wProjDept Then
                    strGrouping &= ",project_name,department_name"
                End If
                If book_unit_no_id <> "" Then
                    strGrouping &= ",book_unit_no_name"
                End If
                If currency = "1" Then
                    For Each row As DataRow In ds_report.Tables("Account").Rows
                        row.Item("debit") = row.Item("debit_based")
                        row.Item("credit") = row.Item("credit_based")
                    Next
                End If
                Dim listAccount = groupDataTableToList(ds_report.Tables("Account"), strGrouping)
                generateReportExcel(listAccount, dicHeader, strGrouping, ds_report.Tables("Account"), If(wComparison Or currency = "2", True, False))
                MsgBox("Report Done")
                lblLoad.Visible = False
            Catch ex As Exception
                lblLoad.Visible = False
                MsgBox(String.Format("Error Occured : {0}", ex.Message))
                MyDebugging.AddText(ex.Message)
            End Try
        End If
    End Sub
    'Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click

    '    Dim sort As String = txt_sortby.Value
    '    Dim range As String = getRdoValue(range_filter)
    '    Dim account As String = getRdoValue(account_filter)
    '    Dim general As String = getRdoValue(general_filter)
    '    Dim currency As String = getRdoValue(currency_filter)
    '    Dim allocation As String = getRdoValue(allocation_filter)
    '    Dim filter As String = getRdoValue(filter1)

    '    Dim date_from = txt_date_from.Value.ToString("yyyy-MM-dd")
    '    Dim date_to = txt_date_to.Value.ToString("yyyy-MM-dd")

    '    Dim account_id = txt_account_id.Value
    '    Dim general_id = txt_general_id.Value
    '    Dim currency_id = txt_currency_id.Value
    '    Dim project_id = txt_project_id.Value
    '    Dim department_id = txt_department_id.Value
    '    Dim allocation_id = txt_allocation_id.Value
    '    Dim wProjDept As Boolean = withProjectDepartment.Checked
    '    Dim wComparison As Boolean = withComparison.Checked
    '    Dim arr_book_id = getCheckedGrid("book_id", "book_name", "sel", dgBooks, "", False, "Select Book First.")
    '    Dim arr_book_unit_id = getCheckedGridUnit("book_unit_no_id", "book_unit_no_name", "sel2", dgBookUnit, "", False, "No Book Unit Selected.", False)

    '    Dim str_id As String = ""
    '    Dim str_id1 As String = ""
    '    Dim str_id2 As String = ""
    '    Dim str_account_id As String = ""
    '    Dim str_general_id As String = ""

    '    If arr_book_id.Length = 0 Then
    '        Exit Sub
    '    Else
    '        If account = "" Then
    '            MsgBox("Select Filter for Account first.")
    '            account_filter.Focus()
    '            Exit Sub
    '        End If
    '        Select Case account
    '            Case "1"
    '            Case "2"
    '                Dim sql_multiple_account As String = String.Format("SELECT GROUP_CONCAT(a.account_id) AS account_id " &
    '                    "FROM lib_acc_chart_multiple a " &
    '                    "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
    '                    "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
    '                Dim dt_multiple_account As DataTable = FsQuery(sql_multiple_account)
    '                If dt_multiple_account.Rows.Count > 0 Then
    '                    str_account_id = dt_multiple_account.Rows(0).Item("account_id").ToString
    '                End If
    '            Case "3"
    '                If account_id = "" Then
    '                    MsgBox("Select Account First")
    '                    txt_account_id.Focus()
    '                    Exit Sub
    '                End If
    '        End Select
    '        Select Case general
    '            Case "1"
    '            Case "2"
    '                Dim sql_multiple_general As String = String.Format("SELECT GROUP_CONCAT(a.general_id) AS general_id " &
    '                    "FROM lib_acc_general_multiple a " &
    '                    "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
    '                    "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
    '                Dim dt_multiple_general As DataTable = FsQuery(sql_multiple_general)
    '                If dt_multiple_general.Rows.Count > 0 Then
    '                    str_general_id = dt_multiple_general.Rows(0).Item("general_id").ToString
    '                End If
    '            Case "3"
    '                If general_id = "" Then
    '                    MsgBox("Select General Library First")
    '                    txt_general_id.Focus()
    '                    Exit Sub
    '                End If
    '        End Select

    '        ''''''''''''''''' Journal
    '        For i As Integer = 0 To journal_ids.ToArray.Length - 1
    '            str_id1 &= "," & journal_ids(i)
    '        Next
    '        If journal_ids.ToArray.Length = 0 Then
    '            MsgBox("No Journal Selected.")
    '            Exit Sub
    '        Else
    '            str_id1 &= ",8"
    '        End If

    '        ''''''''''''''''' Book
    '        For i As Integer = 0 To arr_book_id.Length - 1
    '            str_id &= "," & arr_book_id(i)
    '        Next
    '        '''''''''''''''''' Book Unit
    '        For i As Integer = 0 To arr_book_unit_id.Length - 1
    '            str_id2 &= "," & arr_book_unit_id(i)
    '        Next
    '        If arr_book_unit_id.ToArray.Length = 0 Then
    '            Exit Sub
    '        End If

    '        '''''''''''''''''
    '        If range <> "2" Then
    '            If date_from > date_to Then
    '                MsgBox("Invalid date range.")
    '                Exit Sub
    '            End If
    '        End If
    '        If allocation = "2" Then
    '            If allocation_id = "" Then
    '                MsgBox("Select Allocation First.")
    '                txt_allocation_id.Focus()
    '                Exit Sub
    '            End If
    '        End If
    '        If sort = "" Then
    '            MsgBox("Select Sort By First.")
    '            txt_sortby.Focus()
    '            Exit Sub
    '        End If

    '    End If

    '    Dim sql As String = String.Format("SELECT zz.book_unit_no_id,c.check_date,a.trans_id,a.trans_date,a.trans_no,a.description,DATE_FORMAT(a.trans_date,'%M %Y') AS month  " & vbNewLine &
    '        ",i.account_id,UPPER(CONCAT('(',i.account_code,') - ',i.account_name)) AS account_name,UPPER(i.account_code) AS account_code  " & vbNewLine &
    '        ",IF(c.replaced,c.replacement_check_no,c.check_no) as check_no " & vbNewLine &
    '        ",ap.chart_type " & vbNewLine &
    '        ",a.journal_id,am.journal_name,am.journal_code  " & vbNewLine &
    '        ",a.book_id,_book.book_name,_book.book_code  " & vbNewLine &
    '        ",IF(a.journal_id = '1',g.si_no  " & vbNewLine &
    '        "	,IF(a.journal_id = '2',e.si_no  " & vbNewLine &
    '        "		,IF(a.journal_id = '3',d.si_no  " & vbNewLine &
    '        "			,IF(a.journal_id = '4',f.si_no  " & vbNewLine &
    '        "				,IF(a.journal_id = '6',h.si_no  " & vbNewLine &
    '        "					,''))))) AS si_no  " & vbNewLine &
    '        ",IF(a.journal_id = '3',d.rr_no  " & vbNewLine &
    '        "	,IF(a.journal_id = '4',f.rr_no  " & vbNewLine &
    '        "		,'')) AS rr_no " & vbNewLine &
    '        ",IF(a.journal_id = '1',g.dr_no,'') AS dr_no " & vbNewLine &
    '        ",IF(a.journal_id = '1',g.po_no  " & vbNewLine &
    '        "	,IF(a.journal_id = '3',d.po_no  " & vbNewLine &
    '        "		,IF(a.journal_id = '6',h.po_no  " & vbNewLine &
    '        "			,''))) AS po_no  " & vbNewLine &
    '        ",IF(a.journal_id = '2',ref_jbooks.trans_no " & vbNewLine &
    '        "	,IF(a.journal_id = '3',ref_jbooks.trans_no, " & vbNewLine &
    '        "		IF(a.journal_id = '4',ref_ewt.trans_no, " & vbNewLine &
    '        "			IF(a.journal_id = '5',ref_final_tax.trans_no, " & vbNewLine &
    '        "				IF(a.journal_id = '6',ref_input_vat.trans_no, " & vbNewLine &
    '        "					IF(a.journal_id = '7',ref_output_vat.trans_no, " & vbNewLine &
    '        "						IF(a.journal_id = '8',ref_prepaid.trans_no, " & vbNewLine &
    '        "							IF(a.journal_id = '9',ref_fixed_asset.trans_no,'')))))))) AS ref_trans_no " & vbNewLine &
    '        ",IF(a.journal_id = '2' OR a.journal_id = '3',ref_terms.terms_name,'') AS terms_name " & vbNewLine &
    '        ",IF(a.journal_id = '2' OR a.journal_id = '3',ref_terms.nodays,NULL) AS nodays " & vbNewLine &
    '        ",IF(a.journal_id = '2' OR a.journal_id = '3',ref_jbooks.general_name,NULL) AS ref_general_name " & vbNewLine &
    '        ",an.general_name AS trans_general_name " & vbNewLine &
    '        ",v.account_id AS account_multiple_id  " & vbNewLine &
    '        ",b.project_id,b.department_id,ak.project_code,ak.project_name,al.department_code,al.department_name  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN b.currency_id  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '2' OR a.journal_id = '4',c.currency_id,b.currency_id)  " & vbNewLine &
    '        "	WHEN '2' THEN b.currency_id  " & vbNewLine &
    '        "	WHEN '3' THEN b.currency_id  " & vbNewLine &
    '        "	WHEN '4' THEN j.currency_id  " & vbNewLine &
    '        "	WHEN '5' THEN k.currency_id  " & vbNewLine &
    '        "	WHEN '6' THEN m.currency_id  " & vbNewLine &
    '        "	WHEN '7' THEN n.currency_id  " & vbNewLine &
    '        "	WHEN '8' THEN o.currency_id  " & vbNewLine &
    '        "	WHEN '9' THEN l.currency_id  " & vbNewLine &
    '        "	WHEN '10' THEN b.currency_id  " & vbNewLine &
    '        "END AS currency_id  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN ac.currency_name  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '2' OR a.journal_id = '4',ad.currency_name,ac.currency_name)  " & vbNewLine &
    '        "	WHEN '2' THEN ac.currency_name  " & vbNewLine &
    '        "	WHEN '3' THEN ac.currency_name  " & vbNewLine &
    '        "	WHEN '4' THEN ae.currency_name  " & vbNewLine &
    '        "	WHEN '5' THEN af.currency_name  " & vbNewLine &
    '        "	WHEN '6' THEN ah.currency_name  " & vbNewLine &
    '        "	WHEN '7' THEN ai.currency_name  " & vbNewLine &
    '        "	WHEN '8' THEN aj.currency_name  " & vbNewLine &
    '        "	WHEN '9' THEN ag.currency_name  " & vbNewLine &
    '        "	WHEN '10' THEN ac.currency_name  " & vbNewLine &
    '        "END AS currency_name  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN ao.general_id  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '2',x.general_id,w.general_id)  " & vbNewLine &
    '        "	WHEN '2' THEN w.general_id  " & vbNewLine &
    '        "	WHEN '3' THEN w.general_id  " & vbNewLine &
    '        "	WHEN '4' THEN y.general_id  " & vbNewLine &
    '        "	WHEN '5' THEN z.general_id  " & vbNewLine &
    '        "	WHEN '6' THEN aa.general_id  " & vbNewLine &
    '        "	WHEN '7' THEN ab.general_id  " & vbNewLine &
    '        "	WHEN '8' THEN w.general_id  " & vbNewLine &
    '        "	WHEN '9' THEN w.general_id  " & vbNewLine &
    '        "	WHEN '10' THEN w.general_id  " & vbNewLine &
    '        "END AS general_multiple_id  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN a.general_id  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '2',q.general_id,p.general_id)  " & vbNewLine &
    '        "	WHEN '2' THEN p.general_id  " & vbNewLine &
    '        "	WHEN '3' THEN p.general_id  " & vbNewLine &
    '        "	WHEN '4' THEN r.general_id  " & vbNewLine &
    '        "	WHEN '5' THEN s.general_id  " & vbNewLine &
    '        "	WHEN '6' THEN t.general_id  " & vbNewLine &
    '        "	WHEN '7' THEN u.general_id  " & vbNewLine &
    '        "	WHEN '8' THEN p.general_id  " & vbNewLine &
    '        "	WHEN '9' THEN p.general_id  " & vbNewLine &
    '        "	WHEN '10' THEN p.general_id  " & vbNewLine &
    '        "END AS general_id  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN an.general_name  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '2',q.general_name,p.general_name)  " & vbNewLine &
    '        "	WHEN '2' THEN p.general_name  " & vbNewLine &
    '        "	WHEN '3' THEN p.general_name  " & vbNewLine &
    '        "	WHEN '4' THEN r.general_name  " & vbNewLine &
    '        "	WHEN '5' THEN s.general_name  " & vbNewLine &
    '        "	WHEN '6' THEN t.general_name  " & vbNewLine &
    '        "	WHEN '7' THEN u.general_name  " & vbNewLine &
    '        "	WHEN '8' THEN p.general_name  " & vbNewLine &
    '        "	WHEN '9' THEN p.general_name  " & vbNewLine &
    '        "	WHEN '10' THEN p.general_name  " & vbNewLine &
    '        "END AS general_name  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN (b.debit) WHEN '1' THEN IF(a.journal_id = '2',(c.check_amount),(b.debit))  " & vbNewLine &
    '        "	WHEN '2' THEN (b.debit)  " & vbNewLine &
    '        "	WHEN '3' THEN (b.debit)  " & vbNewLine &
    '        "	WHEN '4' THEN (j.debit)  " & vbNewLine &
    '        "	WHEN '5' THEN (k.debit)  " & vbNewLine &
    '        "	WHEN '6' THEN (m.debit)  " & vbNewLine &
    '        "	WHEN '7' THEN (n.debit)  " & vbNewLine &
    '        "	WHEN '8' THEN (o.debit)  " & vbNewLine &
    '        "	WHEN '9' THEN (l.debit)  " & vbNewLine &
    '        "	WHEN '10' THEN (b.debit)  " & vbNewLine &
    '        "END AS debit  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN (b.credit)  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '4',(c.check_amount),(b.credit))  " & vbNewLine &
    '        "	WHEN '2' THEN (b.credit)  " & vbNewLine &
    '        "	WHEN '3' THEN (b.credit)  " & vbNewLine &
    '        "	WHEN '4' THEN (j.credit)  " & vbNewLine &
    '        "	WHEN '5' THEN (k.credit)  " & vbNewLine &
    '        "	WHEN '6' THEN (m.credit)  " & vbNewLine &
    '        "	WHEN '7' THEN (n.credit)  " & vbNewLine &
    '        "	WHEN '8' THEN (o.credit)  " & vbNewLine &
    '        "	WHEN '9' THEN (l.credit)  " & vbNewLine &
    '        "	WHEN '10' THEN (b.credit)  " & vbNewLine &
    '        "END AS credit  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN (b.debit_based)  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '2',(c.check_amount_based),(b.debit_based))  " & vbNewLine &
    '        "	WHEN '2' THEN (b.debit_based)  " & vbNewLine &
    '        "	WHEN '3' THEN (b.debit_based)  " & vbNewLine &
    '        "	WHEN '4' THEN (j.debit_based)  " & vbNewLine &
    '        "	WHEN '5' THEN (k.debit_based)  " & vbNewLine &
    '        "	WHEN '6' THEN (m.debit_based)  " & vbNewLine &
    '        "	WHEN '7' THEN (n.debit_based)  " & vbNewLine &
    '        "	WHEN '8' THEN (o.debit_based)  " & vbNewLine &
    '        "	WHEN '9' THEN (l.debit_based)  " & vbNewLine &
    '        "	WHEN '10' THEN (b.debit_based)  " & vbNewLine &
    '        "END AS debit_based  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN (b.credit_based)  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '4',(c.check_amount_based),(b.credit_based))  " & vbNewLine &
    '        "	WHEN '2' THEN (b.credit_based)  " & vbNewLine &
    '        "	WHEN '3' THEN (b.credit_based)  " & vbNewLine &
    '        "	WHEN '4' THEN (j.credit_based)  " & vbNewLine &
    '        "	WHEN '5' THEN (k.credit_based)  " & vbNewLine &
    '        "	WHEN '6' THEN (m.credit_amount_based)  " & vbNewLine &
    '        "	WHEN '7' THEN (n.credit_based)  " & vbNewLine &
    '        "	WHEN '8' THEN (o.credit_based)  " & vbNewLine &
    '        "	WHEN '9' THEN (l.credit_based)  " & vbNewLine &
    '        "	WHEN '10' THEN (b.credit_based)  " & vbNewLine &
    '        "END AS credit_based  " & vbNewLine &
    '         ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '1' THEN 'Bank/Cash'  " & vbNewLine &
    '        "	WHEN '2' THEN 'Accounts Receivable'  " & vbNewLine &
    '        "	WHEN '3' THEN 'Accounts Payable'  " & vbNewLine &
    '        "	WHEN '4' THEN 'EWT'  " & vbNewLine &
    '        "	WHEN '5' THEN 'Final TAX'  " & vbNewLine &
    '        "	WHEN '6' THEN 'Input VAT'  " & vbNewLine &
    '        "	WHEN '7' THEN 'Output VAT'  " & vbNewLine &
    '        "	WHEN '8' THEN 'Prepayment'  " & vbNewLine &
    '        "	WHEN '9' THEN 'Fixed Asset'  " & vbNewLine &
    '        "	WHEN '10' THEN 'Gain or Loss'  " & vbNewLine &
    '        "	ELSE 'No Validation'  " & vbNewLine &
    '        "END AS validation_name  " & vbNewLine &
    '        ",CASE i.validation  " & vbNewLine &
    '        "	WHEN '0' THEN (b.exchange_rate / b.based_rate)  " & vbNewLine &
    '        "	WHEN '1' THEN IF(a.journal_id = '4',(c.exchange_rate / c.based_rate),(b.exchange_rate / b.based_rate))  " & vbNewLine &
    '        "	WHEN '2' THEN (b.exchange_rate / b.based_rate)  " & vbNewLine &
    '        "	WHEN '3' THEN (b.exchange_rate / b.based_rate)  " & vbNewLine &
    '        "	WHEN '4' THEN (j.exchange_rate / j.based_rate)  " & vbNewLine &
    '        "	WHEN '5' THEN (k.exchange_rate / k.based_rate)  " & vbNewLine &
    '        "	WHEN '6' THEN (m.exchange_rate / m.based_rate)  " & vbNewLine &
    '        "	WHEN '7' THEN (n.exchange_rate / n.based_rate)  " & vbNewLine &
    '        "	WHEN '8' THEN (o.exchange_rate / o.based_rate)  " & vbNewLine &
    '        "	WHEN '9' THEN (l.exchange_rate / l.based_rate)  " & vbNewLine &
    '        "	WHEN '10' THEN (b.exchange_rate / b.based_rate)  " & vbNewLine &
    '        "END AS exchange_rate  " & vbNewLine &
    '    "FROM {1}.trans_header a " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_book _book On _book.book_id =  a.book_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_jbooks b On b.trans_id = a.trans_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_checks c On c.general_id = a.general_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_header_ap d On d.trans_id = a.trans_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_header_cr e On e.trans_id = a.trans_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_header_cv f On f.trans_id = a.trans_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_header_ib g On g.trans_id = a.trans_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_header_pc h On h.trans_id = a.trans_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_chart i On i.account_id = b.account_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_ewt j On j.jbooks_id = b.jbooks_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_final_tax k On k.jbooks_id = b.jbooks_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_fixed_asset l On l.jbooks_id = b.jbooks_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_input_vat m On m.jbooks_id = b.jbooks_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_output_vat n On n.jbooks_id = b.jbooks_id  " & vbNewLine &
    '        "LEFT JOIN {1}.trans_prepaid o On o.jbooks_id = b.jbooks_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_general p On p.general_id = b.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_general q On q.general_id = c.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_general r On r.general_id = j.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_general s On s.general_id = k.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_general t On t.general_id = m.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_general u On u.general_id = n.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_book_unit_no zz On zz.book_id = a.book_id  " & vbNewLine &
    '        "LEFT JOIN (" & vbNewLine &
    '        "   Select b.module_code, a.account_multiple_id,a.account_id,a.user_id,a.module_id " & vbNewLine &
    '        "   FROM {0}.lib_acc_chart_multiple a " & vbNewLine &
    '        "   LEFT JOIN {0}.sys_erp_modules b On b.module_id = a.module_id " & vbNewLine &
    '        ") v On v.account_id = b.account_id And v.module_code = '" & module_code & "' " & vbNewLine &
    '        "LEFT JOIN {0}.lib_acc_general_multiple w ON w.general_id = p.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_acc_general_multiple x ON x.general_id = q.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_acc_general_multiple y ON y.general_id = r.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_acc_general_multiple z ON z.general_id = s.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_acc_general_multiple aa ON aa.general_id = t.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_acc_general_multiple ab ON ab.general_id = u.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_currency ac ON ac.currency_id = b.currency_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_currency ad ON ad.currency_id = c.currency_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_currency ae ON ae.currency_id = j.currency_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_currency af ON af.currency_id = k.currency_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_currency ag ON ag.currency_id = l.currency_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_currency ah ON ah.currency_id = m.currency_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_currency ai ON ai.currency_id = n.currency_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_currency aj ON aj.currency_id = o.currency_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_project ak ON ak.project_id = b.project_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_department al ON al.department_id = b.department_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_journal am ON am.journal_id = a.journal_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_erp_general an ON an.general_id = a.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_acc_general_multiple ao ON ao.general_id = an.general_id  " & vbNewLine &
    '        "LEFT JOIN {0}.lib_acc_chart_class ap ON ap.chart_class_id = i.chart_class_id   " & vbNewLine &
    '        "LEFT JOIN ( " & vbNewLine &
    '        "	SELECT a.*,b.jbooks_id,c.general_name " & vbNewLine &
    '        "	FROM trans_header a " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & vbNewLine &
    '        "	LEFT JOIN {0}.lib_erp_general c ON c.general_id = a.general_id " & vbNewLine &
    '        ") ref_jbooks ON ref_jbooks.jbooks_id = b.ref_jbooks_id " & vbNewLine &
    '        "LEFT JOIN ( " & vbNewLine &
    '        "	SELECT a.*,c.ewt_id " & vbNewLine &
    '        "	FROM trans_header a " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & vbNewLine &
    '        "	LEFT JOIN trans_ewt c ON c.jbooks_id = b.jbooks_id " & vbNewLine &
    '        ") ref_ewt ON ref_ewt.ewt_id = j.ref_ewt_id " & vbNewLine &
    '        "LEFT JOIN ( " & vbNewLine &
    '        "	SELECT a.*,c.final_tax_id " & vbNewLine &
    '        "	FROM trans_header a " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & vbNewLine &
    '        "	LEFT JOIN trans_final_tax c ON c.jbooks_id = b.jbooks_id " & vbNewLine &
    '        ") ref_final_tax ON ref_final_tax.final_tax_id = k.ref_final_tax_id " & vbNewLine &
    '        "LEFT JOIN ( " & vbNewLine &
    '        "	SELECT a.*,c.fixed_asset_id " & vbNewLine &
    '        "	FROM trans_header a " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & vbNewLine &
    '        "	LEFT JOIN trans_fixed_asset c ON c.jbooks_id = b.jbooks_id " & vbNewLine &
    '        ") ref_fixed_asset ON ref_fixed_asset.fixed_asset_id = l.ref_fixed_asset_id " & vbNewLine &
    '        "LEFT JOIN ( " & vbNewLine &
    '        "	SELECT a.*,c.input_vat_id " & vbNewLine &
    '        "	FROM trans_header a " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & vbNewLine &
    '        "	LEFT JOIN trans_input_vat c ON c.jbooks_id = b.jbooks_id " & vbNewLine &
    '        ") ref_input_vat ON ref_input_vat.input_vat_id = m.ref_input_vat_id " & vbNewLine &
    '        "LEFT JOIN ( " & vbNewLine &
    '        "	SELECT a.*,c.output_vat_id " & vbNewLine &
    '        "	FROM trans_header a " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & vbNewLine &
    '        "	LEFT JOIN trans_output_vat c ON c.jbooks_id = b.jbooks_id " & vbNewLine &
    '        ") ref_output_vat ON ref_output_vat.output_vat_id = n.ref_output_vat_id " & vbNewLine &
    '        "LEFT JOIN ( " & vbNewLine &
    '        "	SELECT a.*,c.prepaid_id " & vbNewLine &
    '        "	FROM trans_header a " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & vbNewLine &
    '        "	LEFT JOIN trans_prepaid c ON c.jbooks_id = b.jbooks_id " & vbNewLine &
    '        ") ref_prepaid ON ref_prepaid.prepaid_id = o.ref_prepaid_id " & vbNewLine &
    '        "LEFT JOIN ( " & vbNewLine &
    '        "	SELECT b.jbooks_id,IF(a.journal_id = '2',e.terms_name,f.terms_name) AS terms_name " & vbNewLine &
    '        "	,IF(a.journal_id = '2',c.nodays,d.nodays) AS nodays " & vbNewLine &
    '        "	FROM trans_header a " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks_ar c ON c.jbooks_id = b.jbooks_id " & vbNewLine &
    '        "	LEFT JOIN trans_jbooks_ap d ON d.jbooks_id = b.jbooks_id " & vbNewLine &
    '        "	LEFT JOIN {0}.lib_erp_terms e ON e.terms_id = c.terms_id " & vbNewLine &
    '        "	LEFT JOIN {0}.lib_erp_terms f ON f.terms_id = d.terms_id " & vbNewLine &
    '        ") ref_terms ON ref_terms.jbooks_id = b.jbooks_id ", _serverDBFS, _serverDBMain)

    '    Select Case range
    '        Case "1"
    '            sql &= String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)
    '            If account = "2" Then
    '                If str_account_id <> "" Then
    '                    sql &= String.Format(" AND b.account_id IN ({0})", str_account_id)
    '                End If
    '            End If
    '            If account_id <> "" Then
    '                sql &= String.Format(" AND b.account_id = '{0}'", account_id)
    '            End If
    '        Case "2"
    '            sql &= String.Format(" WHERE a.trans_date <= '{0}' ", date_to)
    '            If account = "2" Then
    '                If str_account_id <> "" Then
    '                    sql &= String.Format(" AND b.account_id IN ({0})", str_account_id)
    '                End If
    '            End If
    '            If account_id <> "" Then
    '                sql &= String.Format(" AND b.account_id = '{0}'", account_id)
    '            End If
    '    End Select

    '    If range = "1" Or range = "2" Then
    '        If currency_id <> "" Then
    '            sql &= String.Format(" AND CASE i.validation " & vbNewLine &
    '                                            " WHEN '0' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '1' THEN IF(a.journal_id = '2' OR a.journal_id = '4',c.currency_id,b.currency_id) " & vbNewLine &
    '                                            " WHEN '2' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '3' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '4' THEN j.currency_id " & vbNewLine &
    '                                            " WHEN '5' THEN k.currency_id " & vbNewLine &
    '                                            " WHEN '6' THEN m.currency_id " & vbNewLine &
    '                                            " WHEN '7' THEN n.currency_id " & vbNewLine &
    '                                            " WHEN '8' THEN o.currency_id " & vbNewLine &
    '                                            " WHEN '9' THEN l.currency_id " & vbNewLine &
    '                                            " WHEN '10' THEN b.currency_id " & vbNewLine &
    '                                          " END = {0} ", currency_id)
    '        End If

    '        sql &= String.Format(" AND a.book_id IN ({0}) ", str_id.Substring(1))
    '        sql &= String.Format(" AND a.journal_id IN ({0}) ", str_id1.Substring(1))
    '        sql &= String.Format(" AND zz.book_unit_no_id IN ({0}) ", str_id2.Substring(1))

    '        sql &= String.Format(" and IFNULL(a.status,'') <> 'c' ")
    '        Select Case account
    '            Case "1"
    '            Case "2"
    '                sql &= String.Format(" AND i.account_id IN ({0}) ", str_account_id)
    '            Case "3"
    '                sql &= String.Format(" AND i.account_id = {0} ", account_id)
    '        End Select
    '        Select Case general
    '            Case "1"
    '            Case "2"
    '                sql &= String.Format("AND CASE i.validation " &
    '                                                "WHEN '0' THEN a.general_id " & vbNewLine &
    '                                                "WHEN '1' THEN IF(a.journal_id = '2',q.general_id,p.general_id) " & vbNewLine &
    '                                                "WHEN '2' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '3' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '4' THEN r.general_id " & vbNewLine &
    '                                                "WHEN '5' THEN s.general_id " & vbNewLine &
    '                                                "WHEN '6' THEN t.general_id " & vbNewLine &
    '                                                "WHEN '7' THEN u.general_id " & vbNewLine &
    '                                                "WHEN '8' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '9' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '10' THEN p.general_id " & vbNewLine &
    '                                            "END IN ({0}) ", str_general_id)
    '            Case "3"
    '                sql &= String.Format(" AND CASE i.validation " & vbNewLine &
    '                                                "WHEN '0' THEN a.general_id " & vbNewLine &
    '                                                "WHEN '1' THEN IF(a.journal_id = '2',q.general_id,p.general_id) " & vbNewLine &
    '                                                "WHEN '2' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '3' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '4' THEN r.general_id " & vbNewLine &
    '                                                "WHEN '5' THEN s.general_id " & vbNewLine &
    '                                                "WHEN '6' THEN t.general_id " & vbNewLine &
    '                                                "WHEN '7' THEN u.general_id " & vbNewLine &
    '                                                "WHEN '8' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '9' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '10' THEN p.general_id " & vbNewLine &
    '                                            "END = {0} ", general_id)
    '        End Select
    '    End If

    '    If range = "3" Then
    '        Dim tmp_sql = sql & String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)

    '        If account = "2" Then
    '            If str_account_id <> "" Then
    '                tmp_sql &= String.Format(" AND b.account_id IN ({0})", str_account_id)
    '            End If
    '        End If
    '        If account_id <> "" Then
    '            tmp_sql &= String.Format(" AND b.account_id = '{0}'", account_id)
    '        End If
    '        If currency_id <> "" Then
    '            sql &= String.Format(" AND CASE i.validation " & vbNewLine &
    '                                            " WHEN '0' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '1' THEN IF(a.journal_id = '2' OR a.journal_id = '4',c.currency_id,b.currency_id) " & vbNewLine &
    '                                            " WHEN '2' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '3' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '4' THEN j.currency_id " & vbNewLine &
    '                                            " WHEN '5' THEN k.currency_id " & vbNewLine &
    '                                            " WHEN '6' THEN m.currency_id " & vbNewLine &
    '                                            " WHEN '7' THEN n.currency_id " & vbNewLine &
    '                                            " WHEN '8' THEN o.currency_id " & vbNewLine &
    '                                            " WHEN '9' THEN l.currency_id " & vbNewLine &
    '                                            " WHEN '10' THEN b.currency_id " & vbNewLine &
    '                                        "END = {0} ", currency_id)
    '        End If
    '        sql &= String.Format(" AND a.book_id IN ({0}) ", str_id.Substring(1))
    '        sql &= String.Format(" AND a.journal_id IN ({0}) ", str_id1.Substring(1))
    '        sql &= String.Format(" AND zz.book_unit_no_id IN ({0}) ", str_id2.Substring(1))
    '        'Dito'
    '        sql &= String.Format(" and IFNULL(a.status,'') <> 'c' ")
    '        Select Case account
    '            Case "1"
    '            Case "2"
    '                sql &= String.Format(" AND v.account_id IN ({0}) ", str_account_id)
    '            Case "3"
    '                sql &= String.Format(" AND i.account_id = {0} ", account_id)
    '        End Select
    '        Select Case general
    '            Case "1"
    '            Case "2"
    '                sql &= String.Format("AND CASE i.validation " & vbNewLine &
    '                                                "WHEN '0' THEN a.general_id " & vbNewLine &
    '                                                "WHEN '1' THEN IF(a.journal_id = '2',q.general_id,p.general_id) " & vbNewLine &
    '                                                "WHEN '2' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '3' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '4' THEN r.general_id " & vbNewLine &
    '                                                "WHEN '5' THEN s.general_id " & vbNewLine &
    '                                                "WHEN '6' THEN t.general_id " & vbNewLine &
    '                                                "WHEN '7' THEN u.general_id " & vbNewLine &
    '                                                "WHEN '8' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '9' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '10' THEN p.general_id " & vbNewLine &
    '                                            "END IN ({0}) ", str_general_id)
    '            Case "3"
    '                sql &= String.Format(" AND CASE i.validation " & vbNewLine &
    '                                                "WHEN '0' THEN a.general_id " & vbNewLine &
    '                                                "WHEN '1' THEN IF(a.journal_id = '2',q.general_id,p.general_id) " & vbNewLine &
    '                                                "WHEN '2' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '3' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '4' THEN r.general_id " & vbNewLine &
    '                                                "WHEN '5' THEN s.general_id " & vbNewLine &
    '                                                "WHEN '6' THEN t.general_id " & vbNewLine &
    '                                                "WHEN '7' THEN u.general_id " & vbNewLine &
    '                                                "WHEN '8' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '9' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '10' THEN p.general_id " & vbNewLine &
    '                                            "END = {0} ", general_id)
    '        End Select
    '        sql &= String.Format(" WHERE a.trans_date <= '{0}' ", date_from)
    '        If account = "2" Then
    '            If str_account_id <> "" Then
    '                sql &= String.Format(" AND b.account_id IN ({0})", str_account_id)
    '            End If
    '        End If
    '        If account_id <> "" Then
    '            sql &= String.Format(" AND b.account_id = '{0}'", account_id)
    '        End If
    '        If currency_id <> "" Then
    '            sql &= String.Format(" AND CASE i.validation " & vbNewLine &
    '                                            " WHEN '0' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '1' THEN IF(a.journal_id = '2' OR a.journal_id = '4',c.currency_id,b.currency_id) " & vbNewLine &
    '                                            " WHEN '2' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '3' THEN b.currency_id " & vbNewLine &
    '                                            " WHEN '4' THEN j.currency_id " & vbNewLine &
    '                                            " WHEN '5' THEN k.currency_id " & vbNewLine &
    '                                            " WHEN '6' THEN m.currency_id " & vbNewLine &
    '                                            " WHEN '7' THEN n.currency_id " & vbNewLine &
    '                                            " WHEN '8' THEN o.currency_id " & vbNewLine &
    '                                            " WHEN '9' THEN l.currency_id " & vbNewLine &
    '                                            " WHEN '10' THEN b.currency_id " & vbNewLine &
    '                                        "END = {0} ", currency_id)

    '        End If

    '        sql &= String.Format(" AND a.book_id IN ({0}) ", str_id.Substring(1))
    '        sql &= String.Format(" AND a.journal_id IN ({0}) ", str_id1.Substring(1))
    '        sql &= String.Format(" AND zz.book_unit_no_id IN ({0}) ", str_id2.Substring(1))

    '        sql &= String.Format(" and IFNULL(a.status,'') <> 'c' ")
    '        Select Case account
    '            Case "1"
    '            Case "2"
    '                sql &= String.Format(" AND v.account_id IN ({0}) ", str_account_id)
    '            Case "3"
    '                sql &= String.Format(" AND i.account_id = {0} ", account_id)
    '        End Select
    '        Select Case general
    '            Case "1"
    '            Case "2"
    '                sql &= String.Format("AND CASE i.validation " & vbNewLine &
    '                                                "WHEN '0' THEN a.general_id " & vbNewLine &
    '                                                "WHEN '1' THEN IF(a.journal_id = '2',q.general_id,p.general_id) " & vbNewLine &
    '                                                "WHEN '2' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '3' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '4' THEN r.general_id " & vbNewLine &
    '                                                "WHEN '5' THEN s.general_id " & vbNewLine &
    '                                                "WHEN '6' THEN t.general_id " & vbNewLine &
    '                                                "WHEN '7' THEN u.general_id " & vbNewLine &
    '                                                "WHEN '8' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '9' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '10' THEN p.general_id " & vbNewLine &
    '                                            "END IN ({0}) ", str_general_id)
    '            Case "3"
    '                sql &= String.Format(" AND CASE i.validation " & vbNewLine &
    '                                                "WHEN '0' THEN a.general_id " & vbNewLine &
    '                                                "WHEN '1' THEN IF(a.journal_id = '2',q.general_id,p.general_id) " & vbNewLine &
    '                                                "WHEN '2' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '3' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '4' THEN r.general_id " & vbNewLine &
    '                                                "WHEN '5' THEN s.general_id " & vbNewLine &
    '                                                "WHEN '6' THEN t.general_id " & vbNewLine &
    '                                                "WHEN '7' THEN u.general_id " & vbNewLine &
    '                                                "WHEN '8' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '9' THEN p.general_id " & vbNewLine &
    '                                                "WHEN '10' THEN p.general_id " & vbNewLine &
    '                                            "END = {0} ", general_id)


    '        End Select
    '        sql &= String.Format("GROUP BY b.account_id ")
    '        sql = sql.Replace("SELECT a.trans_id,a.trans_date,a.trans_no,", "SELECT a.trans_id,a.trans_date,'BEG' AS trans_no,") & " UNION " & tmp_sql

    '    End If

    '    Dim sortp As String = ""
    '    sql &= String.Format(" GROUP BY a.trans_id,b.jbooks_id ")
    '    sql &= String.Format(" ORDER BY account_code ASC")
    '    If txt_sortby.Text = "Reference No." Then
    '        sql &= ",trans_no ASC"
    '        sortp = "trans_no"
    '    ElseIf txt_sortby.Text = "Date" Then
    '        sql &= ",trans_date ASC"
    '        sortp = "trans_date"
    '    ElseIf txt_sortby.Text = "Name" Then
    '        'dt.DefaultView.Sort = "general_name"
    '        sql &= ""
    '    ElseIf txt_sortby.Text = "Account Title" Then
    '        sql &= ",account_code ASC"
    '        sortp = "account_code"
    '    ElseIf txt_sortby.Text = "Journal Book" Then
    '        sql &= ",journal_name ASC"
    '        sortp = "journal_name"
    '    End If

    '    Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
    '                                              "FROM {1}.sys_default a " &
    '                                              "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
    '                                              "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

    '    Dim dt As DataTable = Query(sql)
    '    Dim dt_company As DataTable = Query(sql_company)

    '    ds_report.Tables("Account").Clear()
    '    ds_report.Tables("Company").Clear()
    '    dt = dt.DefaultView.ToTable

    '    For Each row As DataRow In dt.Rows
    '        ds_report.Tables("Account").ImportRow(row)
    '    Next

    '    For Each row As DataRow In dt_company.Rows
    '        ds_report.Tables("Company").ImportRow(row)
    '    Next
    '    Dim _range As String = ""
    '    Select Case range
    '        Case "1"
    '            _range = String.Format("From {0} to {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
    '        Case "2"
    '            _range = String.Format("As of {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
    '        Case "3"
    '            _range = String.Format("Range w/ Beginning Balance : {0} - {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
    '    End Select

    '    If sender.name = "btnPrint" Then
    '        If wComparison And currency = "2" Then
    '            Dim rep As New report_account_analysis_print
    '            rep.DataSource = ds_report
    '            rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
    '            rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
    '            rep.range.Text = _range
    '            If Not wProjDept Then
    '                rep.GroupHeader5.GroupFields.Clear()
    '                rep.GroupHeader6.GroupFields.Clear()
    '                rep.GroupHeader5.Visible = False
    '                rep.GroupHeader6.Visible = False
    '                rep.GroupFooter5.Visible = False
    '                rep.GroupFooter6.Visible = False
    '            End If
    '            Select Case filter
    '                Case "1"
    '                    rep.GroupHeader2.GroupFields.Clear()
    '                    rep.GroupHeader4.GroupFields.Clear()
    '                    rep.GroupHeader2.Visible = False
    '                    rep.GroupHeader4.Visible = False
    '                    rep.GroupFooter2.Visible = False
    '                    rep.GroupFooter4.Visible = False
    '                Case "2"
    '                    rep.GroupHeader2.GroupFields.Clear()
    '                    rep.GroupHeader2.Visible = False
    '                    rep.GroupFooter2.Visible = False
    '                Case "3"
    '                    rep.GroupHeader4.GroupFields.Clear()
    '                    rep.GroupHeader4.Visible = False
    '                    rep.GroupFooter4.Visible = False
    '                Case "4"
    '            End Select
    '            If currency = "1" Then
    '                rep.GroupHeader3.GroupFields.Clear()
    '                rep.GroupHeader3.Visible = False
    '                rep.GroupFooter3.Visible = False
    '            End If
    '            reportviewer.DocumentViewer1.DocumentSource = rep
    '            reportviewer.ShowDialog()
    '        Else
    '            If currency = "1" Then
    '                For Each row As DataRow In ds_report.Tables("Account").Rows
    '                    row.Item("debit") = row.Item("debit_based")
    '                    row.Item("credit") = row.Item("credit_based")
    '                Next
    '            End If
    '            Dim rep As New report_account_analysis_print_1
    '            rep.DataSource = ds_report
    '            rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
    '            rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
    '            rep.range.Text = _range
    '            If Not wProjDept Then
    '                rep.GroupHeader5.GroupFields.Clear()
    '                rep.GroupHeader6.GroupFields.Clear()
    '                rep.GroupHeader5.Visible = False
    '                rep.GroupHeader6.Visible = False
    '                rep.GroupFooter5.Visible = False
    '                rep.GroupFooter6.Visible = False
    '            End If
    '            Select Case filter
    '                Case "1"
    '                    rep.GroupHeader2.GroupFields.Clear()
    '                    rep.GroupHeader4.GroupFields.Clear()
    '                    rep.GroupHeader2.Visible = False
    '                    rep.GroupHeader4.Visible = False
    '                    rep.GroupFooter2.Visible = False
    '                    rep.GroupFooter4.Visible = False
    '                Case "2"
    '                    rep.GroupHeader2.GroupFields.Clear()
    '                    rep.GroupHeader2.Visible = False
    '                    rep.GroupFooter2.Visible = False
    '                Case "3"
    '                    rep.GroupHeader4.GroupFields.Clear()
    '                    rep.GroupHeader4.Visible = False
    '                    rep.GroupFooter4.Visible = False
    '                Case "4"
    '            End Select
    '            If currency = "1" Then
    '                rep.GroupHeader3.GroupFields.Clear()
    '                rep.GroupHeader3.Visible = False
    '                rep.GroupFooter3.Visible = False
    '            End If
    '            reportviewer.DocumentViewer1.DocumentSource = rep
    '            reportviewer.ShowDialog()
    '        End If
    '    Else
    '        Dim dicHeader As New Dictionary(Of String, String)
    '        dicHeader.Add("companyName", "")
    '        dicHeader.Add("currencyName", "")
    '        dicHeader.Add("templateName", "")
    '        dicHeader.Add("range", _range)
    '        If dt_company.Rows.Count > 0 Then
    '            dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
    '            dicHeader.Item("currencyName") = dt_company.Rows(0).Item("currency_name").ToString
    '        End If
    '        Dim strGrouping As String = "account_name"
    '        If filter = "3" Or filter = "4" Then
    '            strGrouping &= ",journal_name"
    '        End If
    '        If currency_id <> "" Or currency = "2" Then
    '            strGrouping &= ",currency_name"
    '        End If
    '        If wProjDept Then
    '            strGrouping &= ",project_name,department_name"
    '        End If
    '        If currency = "1" Then
    '            For Each row As DataRow In ds_report.Tables("Account").Rows
    '                row.Item("debit") = row.Item("debit_based")
    '                row.Item("credit") = row.Item("credit_based")
    '            Next
    '        End If
    '        Dim listAccount = groupDataTableToList(ds_report.Tables("Account"), strGrouping)
    '        generateReportExcel(listAccount, dicHeader, strGrouping, ds_report.Tables("Account"), If(wComparison Or currency = "2", True, False))
    '        'If wComparison And currency = "2" Then
    '        '    Dim listAccount = groupDataTableToList(ds_report.Tables("Account"), strGrouping)
    '        '    dicHeader.Item("templateName") = "accountanalysis.xlt"
    '        '    generateExcelReport(listAccount, dicHeader, strGrouping, ds_report.Tables("Account"))
    '        'Else
    '        '    If currency = "1" Then
    '        '        For Each row As DataRow In ds_report.Tables("Account").Rows
    '        '            row.Item("debit") = row.Item("debit_based")
    '        '            row.Item("credit") = row.Item("credit_based")
    '        '        Next
    '        '    End If
    '        '    Dim listAccount = groupDataTableToList(ds_report.Tables("Account"), strGrouping)
    '        '    dicHeader.Item("templateName") = "accountanalysis2.xlt"
    '        '    generateReportExcel(listAccount, dicHeader, strGrouping, ds_report.Tables("Account"))
    '        '    'generateExcelReport1(listAccount, dicHeader, strGrouping, ds_report.Tables("Account"))
    '        'End If
    '    End If
    'End Sub
    Private Sub generateReportExcel(ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, Optional OriginalCurrency As Boolean = False)
        Dim first_row As Integer = 5
        Dim current_row As Integer = 5
        Dim runningBalance As Boolean = CBool(dicHeader.Item("w_running_balance"))

        Dim last_column As Integer = 17
        If withComparison.Checked Then
            last_column += 2
            If w_currency.Checked Then
                last_column += 1
            End If
            If w_running_balance.Checked Then
                last_column += 2
            End If
        Else
            If w_currency.Checked Then
                last_column += 1
            End If
            If w_running_balance.Checked Then
                last_column += 1
            End If
        End If

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        xlApp.Calculation = Excel.XlCalculation.xlCalculationManual
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader("companyName")
        xlWorkSheet.Cells(2, 1) = "ACCOUNT ANALYSIS"
        xlWorkSheet.Cells(3, 1) = dicHeader.Item("range")

        Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, last_column))
        range.Merge()
        range.Font.Bold = True
        range.HorizontalAlignment = Excel.Constants.xlCenter
        range = xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, last_column))
        range.Merge()
        range.Font.Bold = True
        range.HorizontalAlignment = Excel.Constants.xlCenter
        range = xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, last_column))
        range.Merge()
        range.Font.Bold = True
        range.HorizontalAlignment = Excel.Constants.xlCenter
        'Date,Book,Journal,Transaction No
        xlWorkSheet.Cells(4, 1) = "Date"
        xlWorkSheet.Cells(4, 2) = "Book"
        xlWorkSheet.Cells(4, 3) = "Journal"
        xlWorkSheet.Cells(4, 4) = "Transaction No"
        xlWorkSheet.Cells(4, 5) = "Check No"
        xlWorkSheet.Cells(4, 6) = "General Name"
        xlWorkSheet.Cells(4, 7) = "Gen. Ref."
        xlWorkSheet.Cells(4, 8) = "DN Ref"
        xlWorkSheet.Cells(4, 9) = "Terms"
        xlWorkSheet.Cells(4, 10) = "No. Days"
        xlWorkSheet.Cells(4, 11) = "SI No"
        xlWorkSheet.Cells(4, 12) = "DR No"
        xlWorkSheet.Cells(4, 13) = "RR No"
        xlWorkSheet.Cells(4, 14) = "PO No"
        xlWorkSheet.Cells(4, 15) = "Particulars"
        Dim current_column As Integer = 16
        If w_currency.Checked Then
            xlWorkSheet.Cells(4, current_column) = "Currency"
            current_column += 1
        End If
        xlWorkSheet.Cells(4, current_column) = "Debit"
        current_column += 1
        xlWorkSheet.Cells(4, current_column) = "Credit"
        current_column += 1
        If runningBalance Then
            xlWorkSheet.Cells(4, current_column) = "Running Balance"
            current_column += 1
        End If
        current_column = 16
        If w_currency.Checked Then
            current_column += 1
        End If
        If OriginalCurrency Then
            xlWorkSheet.Cells(4, current_column) = String.Format("Debit in {0}", dicHeader("currencyName"))
            current_column += 1
            xlWorkSheet.Cells(4, current_column) = String.Format("Credit in {0}", dicHeader("currencyName"))
            current_column += 1
            If runningBalance Then
                xlWorkSheet.Cells(4, current_column) = "Debit Based"
                current_column += 1
                xlWorkSheet.Cells(4, current_column) = "Credit Based"
                current_column += 1
                xlWorkSheet.Cells(4, current_column) = "Running Balance Based"
                current_column += 1
            Else
                xlWorkSheet.Cells(4, current_column) = "Debit Based"
                current_column += 1
                xlWorkSheet.Cells(4, current_column) = "Credit Based"
                current_column += 1
            End If
        End If
        Dim current_index As Integer = 0
        generateGroupExcel(xlWorkSheet, listAccount, dicHeader, strCol, dtAccount, current_index, current_row, OriginalCurrency)
        xlApp.Calculation = Excel.XlCalculation.xlCalculationAutomatic
    End Sub
    Private Sub CopyAsValue(ByRef xlWorkSheet As Excel.Worksheet, ByVal obj As Object)
        xlWorkSheet.Range(obj, obj).Value2 = obj.Value
    End Sub
    Private Sub generateGroupExcel(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByRef current_index As Integer, ByRef current_row As Integer, Optional OriginalCurrency As Boolean = False)
        Dim last_column As Integer = 17
        If withComparison.Checked Then
            last_column += 2
            If w_currency.Checked Then
                last_column += 1
            End If
            If w_running_balance.Checked Then
                last_column += 2
            End If
        Else
            If w_currency.Checked Then
                last_column += 1
            End If
            If w_running_balance.Checked Then
                last_column += 1
            End If
        End If

        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        Dim runningBalance As Boolean = CBool(dicHeader.Item("w_running_balance"))
        For Each item In listAccount 'emon-remove dictionary
            If item.ContainsKey("grouped") Then
                Select Case field
                    Case "account_name"
                        current_row += 1
                        current_index += 1
                        xlWorkSheet.Cells(current_row, 1) = String.Format("*****{0}*****", item.Item(field))
                        Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column))
                        range.Merge()
                        range.Font.Bold = True
                        range.HorizontalAlignment = Excel.Constants.xlCenter
                        range.Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                        Dim first_row = current_row
                        current_row += 1
                        generateGroupExcel(xlWorkSheet, item.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row, OriginalCurrency)
                        current_row += 1
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = item.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        Dim current_column As Integer = 16
                        If w_currency.Checked Then
                            current_column = 17
                        End If
                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                        current_column += 1
                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                        current_column += 1
                        If OriginalCurrency Then
                            If runningBalance Then
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                                current_column += 1
                            Else
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                                current_column += 1
                            End If
                        Else
                            If runningBalance Then
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                                current_column += 1
                            End If
                        End If
                        If OriginalCurrency Then
                            If runningBalance Then
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 15), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            Else
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 15), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            End If
                        Else
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 15), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If

                        current_row += 1

                        xlWorkSheet.Cells(current_row, 1).Value = " NET : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        Dim drs = dtAccount.Select(String.Format("account_name = '{0}'", item.Item("account_name").ToString.Replace("'", "''")))
                        If drs.Count > 0 Then
                            current_column = 16
                            If w_currency.Checked Then
                                current_column = 17
                            End If
                            Dim isDebit = If(drs(0).Item("chart_type").ToString = "A" Or drs(0).Item("chart_type").ToString = "E", True, False)
                            If isDebit Then
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row - 1, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                            Else
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row - 1, ConvertToLetter(current_column - 1), ConvertToLetter(current_column - 2))
                            End If
                            If OriginalCurrency Then
                                If runningBalance Then
                                    current_column = 19
                                    If w_currency.Checked Then
                                        current_column = 20
                                    End If
                                    If isDebit Then
                                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row - 1, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                                    Else
                                        current_column += 1
                                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row - 1, ConvertToLetter(current_column - 1), ConvertToLetter(current_column - 2))
                                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 21))
                                    End If
                                Else
                                    current_column = 18
                                    If w_currency.Checked Then
                                        current_column = 19
                                    End If
                                    If isDebit Then
                                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row - 1, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 19))
                                    Else
                                        current_column += 1
                                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=({1}{0}-{2}{0})", current_row - 1, ConvertToLetter(current_column - 1), ConvertToLetter(current_column - 2))
                                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 20))
                                    End If
                                End If
                            End If
                        End If
                        If runningBalance Then
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 17), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        Else
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 17), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                    Case Else
                        Dim label As String = item.Item(field)
                        xlWorkSheet.Cells(current_row, 1).Value = label
                        Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2))
                        range.Merge()
                        range.Font.Bold = True
                        range.HorizontalAlignment = Excel.Constants.xlCenter
                        current_row += 1
                        current_index += 1
                        Dim first_row = current_row
                        generateGroupExcel(xlWorkSheet, item.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row, OriginalCurrency)
                        current_index -= 1
                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = String.Format("{0} - Total Debit/Credit ", label).ToUpper
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        Dim current_column As Integer = 16
                        If w_currency.Checked Then
                            current_column = 17
                        End If
                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                        current_column += 1
                        xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 17))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 18))
                        If OriginalCurrency Then
                            If runningBalance Then
                                current_column = 18
                                If w_currency.Checked Then
                                    current_column = 19
                                End If
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("={1}{0}-{2}{0}", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("={1}{0}-{2}{0}", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                                current_column += 1
                                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 19))
                                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 20))
                                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 21))
                                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 22))
                            Else
                                current_column = 18
                                If w_currency.Checked Then
                                    current_column = 19
                                End If
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                                current_column += 1
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                                current_column += 1
                                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 19))
                                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 20))
                            End If
                        Else
                            If runningBalance Then
                                current_column = 18
                                If w_currency.Checked Then
                                    current_column = 19
                                End If
                                xlWorkSheet.Cells(current_row, current_column) = String.Format("={1}{0}-{2}{0}", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 19))
                            End If
                        End If
                        If runningBalance Then
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 17), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        Else
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 17), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        'current_row += 1
                        'xlWorkSheet.Cells(current_row, 1) = String.Format("{0} - NET", label).ToUpper
                        'xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        'xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        'xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        'If w_running_balance.Checked Then
                        '    current_column = 17
                        '    If w_currency.Checked Then
                        '        current_column += 1
                        '    End If
                        '    xlWorkSheet.Cells(current_row, current_column) = String.Format("={1}{0}-{2}{0}", current_row - 1, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                        'End If
                        'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 18), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                        'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                End Select
            Else
                Dim current_column As Integer = 16
                'current_row += 1
                current_index += 1
                Dim net As Decimal = 0
                Dim net_based As Decimal = 0
                Dim chart_type As String = ""
                If item.ContainsKey(field) And item.ContainsKey("datas") Then
                    Dim label As String = item.Item(field)
                    If field = "account_name" Then
                        xlWorkSheet.Cells(current_row, 1) = String.Format("*****{0}*****", label)
                        Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column))
                        range.Merge()
                        range.Font.Bold = True
                        range.HorizontalAlignment = Excel.Constants.xlCenter
                        range.Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                    Else
                        xlWorkSheet.Cells(current_row, 1) = String.Format("{0}", label)
                        Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2))
                        range.Merge()
                        range.Font.Bold = True
                        range.HorizontalAlignment = Excel.Constants.xlCenter
                    End If
                    current_row += 1
                    Dim first_row = current_row
                    For Each a In item.Item("datas") 'emon-remove dictionary
                        Try
                            xlWorkSheet.Cells(current_row, 1) = "'" & CDate(a.Item("trans_date").ToString).ToString("MM/dd/yyyy")
                            xlWorkSheet.Cells(current_row, 2) = "'" & a.Item("book_code").ToString
                            xlWorkSheet.Cells(current_row, 3) = "'" & a.Item("journal_code").ToString
                            xlWorkSheet.Cells(current_row, 4) = "'" & a.Item("trans_no").ToString
                            xlWorkSheet.Cells(current_row, 5) = "'" & a.Item("check_no").ToString
                            xlWorkSheet.Cells(current_row, 6) = a.Item("general_name").ToString
                            xlWorkSheet.Cells(current_row, 7) = a.Item("ref_general_name").ToString
                            xlWorkSheet.Cells(current_row, 8) = "'" & a.Item("ref_trans_no").ToString
                            xlWorkSheet.Cells(current_row, 9) = a.Item("terms_name").ToString
                            xlWorkSheet.Cells(current_row, 10) = a.Item("nodays").ToString
                            xlWorkSheet.Cells(current_row, 11) = "'" & a.Item("si_no").ToString
                            xlWorkSheet.Cells(current_row, 12) = "'" & a.Item("dr_no").ToString
                            xlWorkSheet.Cells(current_row, 13) = "'" & a.Item("rr_no").ToString
                            xlWorkSheet.Cells(current_row, 14) = "'" & a.Item("po_no").ToString
                            xlWorkSheet.Cells(current_row, 15) = a.Item("description").ToString
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 15), xlWorkSheet.Cells(current_row, 15)).WrapText = False
                            current_column = 16
                            If w_currency.Checked Then
                                xlWorkSheet.Cells(current_row, current_column) = a.Item("currency_name").ToString
                                current_column += 1
                            End If
                            xlWorkSheet.Cells(current_row, current_column) = a.Item("debit").ToString
                            current_column += 1
                            xlWorkSheet.Cells(current_row, current_column) = a.Item("credit").ToString
                            current_column += 1
                            If runningBalance Then
                                xlWorkSheet.Cells(current_row, current_column) = a.Item("running_balance")
                                xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
                                current_column += 1
                            End If

                            chart_type = a.Item("chart_type").ToString
                            If a.Item("chart_type").ToString = "A" Or a.Item("chart_type").ToString = "E" Then
                                net += CDec(ifNull(a.Item("debit").ToString, 0)) - CDec(ifNull(a.Item("credit").ToString, 0))
                                net_based += CDec(ifNull(a.Item("debit_based").ToString, 0)) - CDec(ifNull(a.Item("credit_based").ToString, 0))
                            Else
                                net += CDec(ifNull(a.Item("credit").ToString, 0)) - CDec(ifNull(a.Item("debit").ToString, 0))
                                net_based += CDec(ifNull(a.Item("credit_based").ToString, 0)) - CDec(ifNull(a.Item("debit_based").ToString, 0))
                            End If
                            If OriginalCurrency Then
                                If runningBalance Then
                                    xlWorkSheet.Cells(current_row, current_column) = a.Item("debit_based").ToString
                                    current_column += 1
                                    xlWorkSheet.Cells(current_row, current_column) = a.Item("credit_based").ToString
                                    current_column += 1
                                    xlWorkSheet.Cells(current_row, current_column) = a.Item("running_balance_based").ToString
                                    xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
                                    current_column += 1
                                Else
                                    xlWorkSheet.Cells(current_row, current_column) = a.Item("debit_based").ToString
                                    current_column += 1
                                    xlWorkSheet.Cells(current_row, current_column) = a.Item("credit_based").ToString
                                    current_column += 1
                                    'xlWorkSheet.Cells(current_row, current_column) = a.Item("running_balance_based").ToString
                                    'xlWorkSheet.Cells(current_row, current_column).NumberFormat = "#,##0.00"
                                    'current_column += 1
                                End If
                            End If
                            current_column = 16
                            If w_currency.Checked Then
                                current_column = 17
                            End If
                            If runningBalance Then
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, current_column), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            Else
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, current_column), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            End If

                            current_row += 1
                        Catch ex As Exception
                            MyDebugging.AddText(ex.Message)
                        End Try
                    Next
                    xlWorkSheet.Cells(current_row, 1).Value = String.Format("{0} - TOTAL DEBIT/CREDIT", label)
                    xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                    current_column = 16
                    If w_currency.Checked Then
                        current_column = 17
                    End If
                    xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                    current_column += 1
                    xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                    'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 17))
                    'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 18))
                    If OriginalCurrency Then
                        If runningBalance Then
                            current_column = 18
                            If w_currency.Checked Then
                                current_column = 19
                            End If
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("={1}{0}-{2}{0}", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                            current_column += 1
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                            current_column += 1
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                            current_column += 1
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("={1}{0}-{2}{0}", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                            current_column += 1
                            'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 19))
                            'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 20))
                            'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 21))
                            'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 22))
                        Else
                            current_column = 18
                            If w_currency.Checked Then
                                current_column = 19
                            End If
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                            current_column += 1
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("=SUBTOTAL(9,{2}{0}:{2}{1})", first_row, current_row - 1, ConvertToLetter(current_column))
                            current_column += 1
                            'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 19))
                            'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 20))
                        End If
                    Else
                        If runningBalance Then
                            current_column = 18
                            If w_currency.Checked Then
                                current_column = 19
                            End If
                            xlWorkSheet.Cells(current_row, current_column) = String.Format("={1}{0}-{2}{0}", current_row, ConvertToLetter(current_column - 2), ConvertToLetter(current_column - 1))
                            'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 19))
                        End If
                    End If
                    If runningBalance Then
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 17), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    Else
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 17), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    End If
                    If field = "account_name" Then
                        current_row += 1

                        xlWorkSheet.Cells(current_row, 1).Value = String.Format("{0} - NET ", label)
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        'xlWorkSheet.Cells(current_row, 15) = String.Format("=SUBTOTAL(9,O{0}:O{1})", first_row, current_row - 1)
                        current_column = 16
                        If w_currency.Checked Then
                            current_column += 1
                        End If
                        If chart_type = "A" Or chart_type = "E" Then
                            xlWorkSheet.Cells(current_row, current_column) = net
                        Else
                            current_column += 1
                            xlWorkSheet.Cells(current_row, current_column) = net
                        End If
                        If OriginalCurrency Then
                            'xlWorkSheet.Cells(current_row, 17) = String.Format("=SUBTOTAL(9,Q{0}:Q{1})", first_row, current_row - 1)
                            If runningBalance Then
                                current_column = 19
                                If w_currency.Checked Then
                                    current_column += 1
                                End If
                                If chart_type = "A" Or chart_type = "E" Then
                                    xlWorkSheet.Cells(current_row, current_column) = net_based
                                Else
                                    current_column += 1
                                    xlWorkSheet.Cells(current_row, current_column) = net_based
                                End If
                            Else
                                current_column = 18
                                If w_currency.Checked Then
                                    current_column += 1
                                End If
                                If chart_type = "A" Or chart_type = "E" Then
                                    xlWorkSheet.Cells(current_row, current_column) = net_based
                                Else
                                    current_column += 1
                                    xlWorkSheet.Cells(current_row, current_column) = net_based
                                End If
                            End If
                        End If
                        If runningBalance Then
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 17), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        Else
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 17), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                    End If
                End If
                current_index -= 1
            End If
        Next
    End Sub
    Private Sub generateExcelReport(ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHeader.Item("templateName"))
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader("companyName")
        xlWorkSheet.Cells(3, 1) = dicHeader.Item("range")
        xlWorkSheet.Cells(4, 9) = String.Format("Debit in {0}", dicHeader("currencyName"))
        xlWorkSheet.Cells(4, 10) = String.Format("Credit in {0}", dicHeader("currencyName"))

        Dim first_row As Integer = 5
        Dim current_row As Integer = 5
        generateExcelGroup(xlWorkSheet, listAccount, dicHeader, strCol, dtAccount, 0, current_row)
    End Sub
    Private Sub generateExcelGroup(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByRef current_index As Integer, ByRef current_row As Integer)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        For Each item In listAccount
            Dim dicItem = Nothing
            Dim net As Decimal = 0
            Dim net_based As Decimal = 0
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field
                    Case "account_code"
                        current_row += 1
                        Dim drs = dtAccount.Select(String.Format("account_code = '{0}'", dicItem.Item(field)))
                        Dim account_name As String = String.Format("******* {0} - {1} *******", drs(0).Item("account_code"), drs(0).Item("account_name"))
                        Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10))
                        xlWorkSheet.Cells(current_row, 1).Value = account_name
                        range.Merge()
                        range.Font.Bold = True
                        range.HorizontalAlignment = Excel.Constants.xlCenter
                        range.Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                        current_row += 1
                        current_index += 1
                        Dim first_row As Integer = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row)
                        xlWorkSheet.Cells(current_row, 1).Value = drs(0).Item("account_name") & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 7))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 8))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 9))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 10))
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                        current_index -= 1
                        current_row += 1

                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = " NET : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        'xlWorkSheet.Cells(current_row, 8) = net
                        'xlWorkSheet.Cells(current_row, 10) = net_based
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUM(H{0}-G{0})", current_row - 2)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUM(J{0}-I{0})", current_row - 2)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                        current_row += 1
                    Case Else
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                        current_row += 1
                        current_index += 1
                        Dim first_row As Integer = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row)
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 7))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 8))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 9))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 10))
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        current_index -= 1
                        current_row += 1
                End Select
            Else
                xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                current_row += 1
                current_index += 1

                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If
                    Dim debit = If(dic.Item("debit").ToString = "", 0, dic.Item("debit"))
                    Dim credit = If(dic.Item("credit").ToString = "", 0, dic.Item("credit"))
                    Dim debit_based = If(dic.Item("debit_based").ToString = "", 0, dic.Item("debit_based"))
                    Dim credit_based = If(dic.Item("credit_based").ToString = "", 0, dic.Item("credit_based"))
                    xlWorkSheet.Cells(current_row, 1).Value = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 2).Value = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 3).Value = dic.Item("check_no")
                    xlWorkSheet.Cells(current_row, 4).Value = dic.Item("general_name")
                    xlWorkSheet.Cells(current_row, 5).Value = dic.Item("description")
                    xlWorkSheet.Cells(current_row, 6).Value = dic.Item("exchange_rate")
                    xlWorkSheet.Cells(current_row, 7).Value = dic.Item("debit")
                    xlWorkSheet.Cells(current_row, 8).Value = dic.Item("credit")
                    xlWorkSheet.Cells(current_row, 10).Value = dic.Item("debit_based")
                    xlWorkSheet.Cells(current_row, 11).Value = dic.Item("credit_based")

                    If dic.item("chart_type").ToString = "A" Or dic.item("chart_type").ToString = "E" Then
                        net += debit - credit
                        net_based += debit_based - credit_based
                    Else
                        net += credit - debit
                        net_based += credit_based - debit_based
                    End If
                    current_row += 1
                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 7))
                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 8))
                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 9))
                'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 10))
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                current_index -= 1
            End If
        Next
    End Sub
    Private Sub generateExcelReport1(ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHeader.Item("templateName"))
        xlApp.Visible = True
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader("companyName")
        xlWorkSheet.Cells(3, 1) = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")

        Dim first_row As Integer = 5
        Dim current_row As Integer = 5
        generateExcelGroup1(xlWorkSheet, listAccount, dicHeader, strCol, dtAccount, 0, current_row)
    End Sub
    Private Sub generateExcelGroup1(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByRef current_index As Integer, ByRef current_row As Integer)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        For Each item In listAccount
            Dim dicItem = Nothing
            Dim net As Decimal = 0
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field
                    Case "account_code"
                        current_row += 1
                        Dim drs = dtAccount.Select(String.Format("account_code = '{0}'", dicItem.Item(field)))
                        Dim account_name As String = String.Format("******* {0} - {1} *******", drs(0).Item("account_code"), drs(0).Item("account_name"))
                        Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8))
                        xlWorkSheet.Cells(current_row, 1).Value = account_name
                        range.Merge()
                        range.Font.Bold = True
                        range.HorizontalAlignment = Excel.Constants.xlCenter
                        range.Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                        current_row += 1
                        current_index += 1
                        Dim first_row As Integer = current_row
                        generateExcelGroup1(xlWorkSheet, dicItem.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row)
                        xlWorkSheet.Cells(current_row, 1).Value = drs(0).Item("account_name") & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 7))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 8))
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                        current_index -= 1
                        current_row += 1

                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = "NET : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 8) = net
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                        current_row += 1
                    Case Else
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                        current_row += 1
                        current_index += 1
                        Dim firstRow As Integer = current_row
                        generateExcelGroup1(xlWorkSheet, dicItem.Item("grouped"), dicHeader, strCol, dtAccount, current_index, current_row)
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", firstRow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", firstRow, current_row - 1)
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 7))
                        'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 8))
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        current_index -= 1
                        current_row += 1
                End Select
            Else
                If field = "account_code" Then
                    current_row += 1
                    Dim drs = dtAccount.Select(String.Format("account_code = '{0}'", dicItem.Item(field)))
                    Dim account_name As String = String.Format("******* {0} - {1} *******", drs(0).Item("account_code"), drs(0).Item("account_name"))
                    Dim range = xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8))
                    xlWorkSheet.Cells(current_row, 1).Value = account_name
                    range.Merge()
                    range.Font.Bold = True
                    range.HorizontalAlignment = Excel.Constants.xlCenter
                    range.Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                    current_row += 1
                    current_index += 1
                Else
                    xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                    xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                    xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                    xlWorkSheet.Cells(current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                    current_row += 1
                    current_index += 1
                End If

                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If
                    Dim debit = If(dic.Item("debit").ToString = "", 0, dic.Item("debit"))
                    Dim credit = If(dic.Item("credit").ToString = "", 0, dic.Item("credit"))
                    xlWorkSheet.Cells(current_row, 1).Value = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 2).Value = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 3).Value = dic.Item("check_no")
                    xlWorkSheet.Cells(current_row, 4).Value = dic.Item("general_name")
                    xlWorkSheet.Cells(current_row, 5).Value = dic.Item("description")
                    xlWorkSheet.Cells(current_row, 6).Value = dic.Item("exchange_rate")
                    xlWorkSheet.Cells(current_row, 7).Value = dic.Item("debit")
                    xlWorkSheet.Cells(current_row, 8).Value = dic.Item("credit")

                    If dic.item("chart_type").ToString = "A" Or dic.item("chart_type").ToString = "E" Then
                        net += debit - credit
                    Else
                        net += credit - debit
                    End If
                    current_row += 1
                Next

                If field = "account_code" Then
                    Dim drs = dtAccount.Select(String.Format("account_code = '{0}'", dicItem.Item(field)))
                    xlWorkSheet.Cells(current_row, 1).Value = drs(0).Item("account_name") & " : "
                    xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                    xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                    xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                    'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 7))
                    'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 8))
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                    current_index -= 1
                    current_row += 1

                    current_row += 1
                    xlWorkSheet.Cells(current_row, 1).Value = "NET : "
                    xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                    xlWorkSheet.Cells(current_row, 8) = net
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    current_row += 1
                Else
                    xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field) & " : "
                    xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                    xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                    xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                    'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 7))
                    'CopyAsValue(xlWorkSheet, xlWorkSheet.Cells(current_row, 8))
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    current_index -= 1
                    current_row += 1
                End If
            End If
        Next
    End Sub
    Private Sub loadBooks(ByVal id() As String)
        dgBooks.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT False AS sel,b.book_id,c.book_code,c.book_name,d.book_unit_no_name " & vbNewLine &
            "FROM {0}.lib_erp_journal a " & vbNewLine &
            "LEFT JOIN {0}.sys_acc_journal_book b ON b.journal_id = a.journal_id " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_book c ON c.book_id = b.book_id " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_book_unit_no d ON d.book_id = c.book_id " & vbNewLine &
            "", _serverDBFS)
        ds.Tables("lib_erp_book").Clear()
        If id.Length > 0 Then
            Dim str_id As String = ""
            For i As Integer = 0 To id.Length - 1
                str_id &= "," & id(i)
            Next
            sql &= String.Format("WHERE a.journal_id IN ({0}) AND c.book_code IS NOT NULL AND c.company_id = '{1}'", str_id.Substring(1), main.Sys_Default.Rows(0).Item("company_id").ToString())
            sql &= " GROUP BY c.book_id "
            Dim dt As DataTable = Query(sql)
            For Each row As DataRow In dt.Rows
                ds.Tables("lib_erp_book").ImportRow(row)
            Next
        Else
            sql &= String.Format("WHERE c.book_id IN ({0}) AND c.company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id").ToString())
        End If
        dgBooks.DataSource = ds.Tables("lib_erp_book")
    End Sub
    Private Sub loadBookUnit(ByVal id() As String)
        dgBookUnit.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT False AS sel2,b.book_id,c.book_code,c.book_name,d.book_unit_no_name,d.book_unit_no_id " & vbNewLine &
            "FROM {0}.lib_erp_journal a " & vbNewLine &
            "LEFT JOIN {0}.sys_acc_journal_book b ON b.journal_id = a.journal_id " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_book c ON c.book_id = b.book_id " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_book_unit_no d ON d.book_id = c.book_id " & vbNewLine &
            "WHERE IFNULL(d.book_unit_no_id,'') <> '' " & vbNewLine &
            "", _serverDBFS)
        ds.Tables("lib_erp_book_unit_no").Clear()

        If id IsNot Nothing Then
            Dim str_id As String = ""
            For i As Integer = 0 To id.Length - 1
                str_id &= "," & id(i)
            Next
            If id.Length > 0 Then
                sql &= String.Format(" AND c.book_id IN({0})", str_id.Substring(1))
                sql &= " GROUP BY d.book_unit_no_id 
            ORDER BY d.book_unit_no_code DESC "
                Dim dt As DataTable = Query(sql)
                For Each row As DataRow In dt.Rows
                    ds.Tables("lib_erp_book_unit_no").ImportRow(row)
                Next
            End If
        Else
            sql &= String.Format(" AND c.company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id").ToString())
            sql &= String.Format(" GROUP BY d.book_unit_no_id ")
            sql &= String.Format(" ORDER BY d.book_unit_no_code DESC ")
            Dim dt As DataTable = Query(sql)
            For Each row As DataRow In dt.Rows
                ds.Tables("lib_erp_book_unit_no").ImportRow(row)
            Next
        End If
        bsBookUnit.DataSource = ds.Tables("lib_erp_book_unit_no")
        dgBookUnit.DataSource = bsBookUnit
    End Sub
    Private Sub loadProjectUnit(ByVal id As String)
        dgBookUnit.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT False AS sel2,a.project_id AS book_id,a.project_unit_no_codes AS book_unit_no_name,a.project_unit_no_id AS book_unit_no_id
        FROM {0}.lib_erp_project_unit_no a ", _serverDBFS)
        ds.Tables("lib_erp_book_unit_no").Clear()

        If id <> "" Then
            'Dim str_id As String = ""
            'For i As Integer = 0 To id.Length - 1
            '    str_id &= "," & id(i)
            'Next
            sql &= String.Format(" WHERE a.project_id IN({0})", id)
            sql &= " ORDER BY a.project_unit_no_codes DESC "
            Dim dt As DataTable = Query(sql)
            For Each row As DataRow In dt.Rows
                ds.Tables("lib_erp_book_unit_no").ImportRow(row)
            Next
        Else
            sql &= " ORDER BY a.project_unit_no_codes DESC "
            Dim dt As DataTable = Query(sql)
            For Each row As DataRow In dt.Rows
                ds.Tables("lib_erp_book_unit_no").ImportRow(row)
            Next
        End If
        bsBookUnit.DataSource = ds.Tables("lib_erp_book_unit_no")
        dgBookUnit.DataSource = bsBookUnit
    End Sub

    Private Sub accountanlysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txt_date_from.Value = New Date(Today.Year, 1, 1)
        txt_date_to.Value = Today


        dgJournal.AutoGenerateColumns = False
        Dim sql_journal As String = String.Format("SELECT False AS sel,journal_id,journal_code,journal_name FROM lib_erp_journal WHERE journal_id <> 8")
        Dim dt_journal As DataTable = FsQuery(sql_journal)
        ds.Tables("lib_erp_journal").Clear()
        For Each row As DataRow In dt_journal.Rows
            ds.Tables("lib_erp_journal").ImportRow(row)
        Next
        dgJournal.DataSource = ds.Tables("lib_erp_journal")

        If My.Settings._enableUnitNo Then
            dgBookUnit.Enabled = True
            If My.Settings._enableBookUnit Then
                loadBookUnit(Nothing)
            Else
                loadProjectUnit("")
            End If
        Else
            dgBookUnit.Enabled = False
        End If

        txt_sortby.Text = "Chart Group"
        txt_sortby.Value = "1"
        txt_sortby.Focus()

        txt_date_from.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
    End Sub

    Private Sub checkAllJournal_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllJournal.CheckedChanged
        Dim dt As DataTable = dgJournal.DataSource
        For Each row As DataRow In dt.Rows
            row("sel") = checkAllJournal.Checked
        Next
        journal_ids.Clear()
        For Each dr As DataGridViewRow In dgJournal.Rows
            If dr.Cells("sel1").Value Then
                journal_ids.Add(dr.Cells("journal_id").Value.ToString)
            End If
        Next

        loadBooks(journal_ids.ToArray)
        'loadBookUnit(journal_ids.ToArray)
        'loadBookUnit(book_ids.ToArray)
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImportAccount.Click
        multiplecodesetup.ModuleCode = module_code
        multiplecodesetup.validation = "All"
        multiplecodesetup.ShowDialog()
    End Sub
    Private Sub txt_sortby_Leave(sender As Object, e As EventArgs) Handles txt_sortby.Leave
        Dim data As DataTable = FsQuery("SELECT '1' AS id,'Reference No.' AS name " &
                                        "UNION SELECT '2','Date' " &
                                        "UNION SELECT '3','Name' " &
                                        "UNION SELECT '4','Account Title' " &
                                        "UNION SELECT '5','Journal Book' " &
                                        "UNION SELECT '6','Chart Group' ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & txt_sortby.Text.ToString.Replace("'", "''") & "'")

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
                txt_sortby.Text = dr("name")
                txt_sortby.Value = dr("id")
            End If
        End If
    End Sub
    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_chart ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("account_code like '" & txt_account_id.Text.ToString.Replace("'", "''") & "'")
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
                txt_account_id.Text = dr("account_code")
                lbl_account_name.Text = dr("account_name")
            End If
        End If
    End Sub
    Private Sub txt_general_id_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_general ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("general_code like '" & txt_general_id.Text.ToString.Replace("'", "''") & "'")
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
                txt_general_id.Text = dr("general_code")
                lbl_general_name.Text = dr("general_name")
            End If
        End If
    End Sub
    Private Sub txt_allocation_id_Leave(sender As Object, e As EventArgs) Handles txt_allocation_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_allocation ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("allocation_code like '" & txt_allocation_id.Text.ToString.Replace("'", "''") & "'")
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
                txt_allocation_id.RowData = dr
                txt_allocation_id.Value = dr("allocation_id")
                txt_allocation_id.Text = dr("allocation_code")
                lbl_allocation_name.Text = dr("allocation_name")
            End If
        End If
    End Sub
    Private Sub account_filter_CheckChange(sender As Object, e As EventArgs) Handles rdo_account_3.CheckedChanged, rdo_account_2.CheckedChanged, rdo_account_1.CheckedChanged
        Dim account As String = getRdoValue(account_filter)
        txt_account_id.Text = ""
        txt_account_id.Value = ""
        lbl_account_name.Text = "Account Name"
        Select Case account
            Case "1"
                btnImportAccount.Enabled = False
                txt_account_id.Enabled = False
            Case "2"
                btnImportAccount.Enabled = True
                txt_account_id.Enabled = False
            Case "3"
                btnImportAccount.Enabled = False
                txt_account_id.Enabled = True
                txt_account_id.Focus()
        End Select
    End Sub
    Private Sub general_filter_CheckChange(sender As Object, e As EventArgs) Handles rdo_general_3.CheckedChanged, rdo_general_2.CheckedChanged, rdo_general_1.CheckedChanged
        Dim general As String = getRdoValue(general_filter)
        txt_general_id.Text = ""
        txt_general_id.Value = ""
        lbl_general_name.Text = "General Library Name"
        Select Case general
            Case "1"
                btnImportGeneral.Enabled = False
                txt_general_id.Enabled = False
            Case "2"
                btnImportGeneral.Enabled = True
                txt_general_id.Enabled = False
            Case "3"
                btnImportGeneral.Enabled = False
                txt_general_id.Enabled = True
                txt_general_id.Focus()
        End Select
    End Sub
    Private Sub allocation_filter_CheckChange(sender As Object, e As EventArgs) Handles rdo_allocation_2.CheckedChanged, rdo_allocation_1.CheckedChanged
        Dim allocation As String = getRdoValue(allocation_filter)
        txt_allocation_id.Enabled = False
        If allocation = "2" Then
            txt_allocation_id.Enabled = True
            txt_allocation_id.Focus()
        End If
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
    Private Sub dgJournal_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgJournal.CellValueChanged
        journal_ids.Clear()
        For Each dr As DataGridViewRow In dgJournal.Rows
            If dr.Cells("sel1").Value Then
                journal_ids.Add(dr.Cells("journal_id").Value.ToString)
            End If
        Next
        loadBooks(journal_ids.ToArray)

    End Sub
    Private Sub dgJournal_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgJournal.CurrentCellDirtyStateChanged
        If dgJournal.CurrentCell.ColumnIndex = 0 Then
            If dgJournal.IsCurrentCellDirty Then
                dgJournal.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub
    Private Sub btnImportGeneral_Click(sender As Object, e As EventArgs) Handles btnImportGeneral.Click
        multiplegeneralsetup.ModuleCode = module_code
        multiplegeneralsetup.ShowDialog()
    End Sub
    Private Sub rdo_currency_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_currency_2.CheckedChanged, rdo_currency_1.CheckedChanged
        Dim currency As String = getRdoValue(currency_filter)
        txt_currency_id.Text = ""
        txt_currency_id.Value = ""
        lbl_account_name.Text = "Account Name"
        withComparison.Enabled = False
        withComparison.Checked = False
        If currency = "2" Then
            withComparison.Enabled = True
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
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

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
    End Sub

    Private Sub txt_project_id_Load(sender As Object, e As EventArgs) Handles txt_project_id.Load

    End Sub

    Private Sub dgBooks_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgBooks_CellValueChanged_1(sender As Object, e As DataGridViewCellEventArgs)



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        For Each dr As DataGridViewRow In dgBookUnit.Rows
            dr.Cells("sel2").Value = checkAllBookUnit.Checked
        Next
    End Sub

    Private Sub dgBooks_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgBooks.CurrentCellDirtyStateChanged
        If dgBooks.CurrentCell.ColumnIndex = 0 Then
            If dgBooks.IsCurrentCellDirty Then
                dgBooks.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub

    Private Sub dgBookUnit_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub dgBooks_CellValueChanged_2(sender As Object, e As DataGridViewCellEventArgs) Handles dgBooks.CellValueChanged
        book_ids.Clear()
        For Each dr As DataGridViewRow In dgBooks.Rows
            If dr.Cells("sel").Value Then
                book_ids.Add(dr.Cells("book_id").Value.ToString)
            End If
        Next
        If My.Settings._enableBookUnit Then
            loadBookUnit(book_ids.ToArray)
        End If
    End Sub

    Private Sub checkAllBooks_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBooks.CheckedChanged


        Dim dt As DataTable = dgBooks.DataSource
        For Each row As DataRow In dt.Rows
            row("sel") = checkAllBooks.Checked
        Next
        book_ids.Clear()
        For Each dr As DataGridViewRow In dgBooks.Rows
            If dr.Cells("sel").Value Then
                book_ids.Add(dr.Cells("book_id").Value.ToString)
            End If
        Next
        If My.Settings._enableBookUnit Then
            loadBookUnit(book_ids.ToArray)
        End If

    End Sub

    Private Sub checkAllBookUnit_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBookUnit.CheckedChanged
        For Each dr As DataGridViewRow In dgBookUnit.Rows
            dr.Cells("sel2").Value = checkAllBookUnit.Checked
        Next
    End Sub

    Private Sub dgBookUnit_CellValueChanged_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgBookUnit.CellValueChanged

        For Each dr As DataGridViewRow In dgBookUnit.Rows
            If dr.Cells("sel2").Value Then
                book_unit_ids.Add(dr.Cells("book_unit_no_id").Value.ToString)
            End If
        Next
        'book_unit_ids.Clear()
    End Sub

    Private Sub dgBookUnit_CurrentCellDirtyStateChanged_1(sender As Object, e As EventArgs) Handles dgBookUnit.CurrentCellDirtyStateChanged
        If dgBookUnit.CurrentCell.ColumnIndex = 0 Then
            If dgBookUnit.IsCurrentCellDirty Then
                dgBookUnit.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub
    Private Sub txtSearchUnit_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUnit.TextChanged
        Dim q As String = txtSearchUnit.Text.ToString().Replace("'", "''")
        bsBookUnit.Filter = String.Format("book_unit_no_name LIKE '%{0}%'", q)
    End Sub

    Private Sub Myformheader1_Load(sender As Object, e As EventArgs) Handles Myformheader1.Load

    End Sub
End Class