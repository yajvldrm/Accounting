Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Imports System.Text.RegularExpressions
Imports DevExpress.XtraSplashScreen

Public Class apsubsidiary
    Private module_code As String = "ACC01006"
    Dim ds As New subsidiaryset
    Dim dss As New FileSetupSet
    Dim templates As String = Application.StartupPath & "\templates"
    Dim book_ids As New List(Of String)
    Dim bsBookUnit As BindingSource = New BindingSource
    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged, rdo2.CheckedChanged, rdo3.CheckedChanged
        Dim range As String = getRdoValue(range_filter)
        If range = "2" Then
            txt_date_from.Enabled = False
            txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        Else
            txt_date_from.Enabled = True
            txt_date_to.MinDate = txt_date_from.Value
        End If
    End Sub
    Private Sub account_filter_CheckChange(sender As Object, e As EventArgs) Handles rdo_account_1.CheckedChanged, rdo_account_3.CheckedChanged, rdo_account_2.CheckedChanged
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
    Private Sub btnImportAccount_Click(sender As Object, e As EventArgs) Handles btnImportAccount.Click
        multiplecodesetup.ModuleCode = module_code
        multiplecodesetup.validation = "3"
        multiplecodesetup.ShowDialog()
    End Sub
    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_chart WHERE validation = 3")
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
    Private Sub general_filter_CheckChange(sender As Object, e As EventArgs) Handles rdo_general_1.CheckedChanged, rdo_general_2.CheckedChanged, rdo_general_3.CheckedChanged
        Dim general As String = getRdoValue(general_filter)
        txt_general_id.Text = ""
        txt_general_id.Value = ""
        lbl_general_name.Text = "General Name"
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
    Private Sub btnImportGeneral_Click(sender As Object, e As EventArgs) Handles btnImportGeneral.Click
        multiplegeneralsetup.ModuleCode = module_code
        multiplegeneralsetup.ShowDialog()
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
                    browse.format("Code,Name", "currency_code,currency_name", "200,400")
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
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim range As String = getRdoValue(range_filter)
        Dim account As String = getRdoValue(account_filter)
        Dim general As String = getRdoValue(general_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim date_from As String = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to As String = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim account_id As String = txt_account_id.Value
        Dim general_id As String = txt_general_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value
        Dim wComparison As Boolean = withComparison.Checked
        Dim wProjDept As Boolean = withProjectDepartment.Checked
        Dim unit_type As String = If(My.Settings._enableBookUnit, "1", "2")

        Dim lst_book = getCheckedGrid("book_id", "book_name", "sel", dgBooks, , False, "No Book Selected", False)
        Dim arr_book_unit_id = getCheckedGridUnit("book_unit_no_id", "book_unit_no_name", "sel2", dgBookUnits, "", False, "*no message*", False)

        If lst_book Is Nothing Or lst_book.Length = 0 Then
            Exit Sub
        End If
        Dim bookIds As String = String.Join(",", lst_book)

        'If arr_book_unit_id Is Nothing Or arr_book_unit_id.Length = 0 Then
        '    Exit Sub
        'End If
        Dim bookUnitIds As String = String.Join(",", arr_book_unit_id)

        'For i As Integer = 0 To arr_book_unit_id.Length - 1
        '    str_id2 &= "," & arr_book_unit_id(i)
        'Next

        'validation
        If range = "1" Or range = "3" Then
            If txt_date_from.Value > txt_date_to.Value Then
                MsgBox("Invalid Date Range.")
                txt_date_from.Focus()
                Exit Sub
            End If
        End If

        Select Case account
            Case "1"
            Case "2"
                Dim sql_account_id As String = String.Format("SELECT GROUP_CONCAT(a.account_id) AS account_id " &
                    "FROM lib_acc_chart_multiple a " &
                    "LEFT JOIN lib_erp_chart b ON b.account_id = a.account_id " &
                    "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " &
                    "WHERE b.validation = '3' AND a.user_id = '{0}' AND c.module_code = '{1}'", main.user_id, module_code)
                Dim dt_account_id As DataTable = FsQuery(sql_account_id)
                account_id = dt_account_id.Rows(0).Item("account_id").ToString
                If account_id = "" Then
                    MsgBox("Setup Multiple Account First.")
                    Exit Sub
                End If
            Case "3"
                If account_id = "" Then
                    MsgBox("Select Account First.")
                    txt_account_id.Focus()
                    Exit Sub
                End If
        End Select

        Select Case general
            Case "1"
            Case "2"
                Dim sql_general_id As String = String.Format("SELECT GROUP_CONCAT(a.general_id) AS general_id " &
                    "FROM lib_acc_general_multiple a " &
                    "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
                    "WHERE a.general_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
                Dim dt_general_id As DataTable = FsQuery(sql_general_id)
                general_id = dt_general_id.Rows(0).Item("general_id").ToString
                If general_id = "" Then
                    MsgBox("Setup Multiple General First.")
                    Exit Sub
                End If
            Case "3"
                If general_id = "" Then
                    MsgBox("Select General Library First.")
                    Exit Sub
                End If
        End Select
        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
                                                  "FROM {1}.sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                  "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

        Dim col As New List(Of KeyValuePair(Of String, String))
        col.Add(New KeyValuePair(Of String, String)("@dbMain", _serverDBMain))
        col.Add(New KeyValuePair(Of String, String)("@dbFS", _serverDBFS))
        col.Add(New KeyValuePair(Of String, String)("@account_id", account_id))
        col.Add(New KeyValuePair(Of String, String)("@general_id", general_id))
        col.Add(New KeyValuePair(Of String, String)("@currency_id", currency_id))
        col.Add(New KeyValuePair(Of String, String)("@date_from", date_from))
        col.Add(New KeyValuePair(Of String, String)("@date_to", date_to))
        col.Add(New KeyValuePair(Of String, String)("@project_id", project_id))
        col.Add(New KeyValuePair(Of String, String)("@department_id", department_id))
        col.Add(New KeyValuePair(Of String, String)("@range_type", range))
        col.Add(New KeyValuePair(Of String, String)("@validation", "3"))
        col.Add(New KeyValuePair(Of String, String)("@book_id", bookIds))
        col.Add(New KeyValuePair(Of String, String)("@unit_id", bookUnitIds))
        col.Add(New KeyValuePair(Of String, String)("@group_by_unit", If(groupByUnit.Checked, "1", "0")))
        col.Add(New KeyValuePair(Of String, String)("@unit_type", unit_type))
        Dim dt As DataTable = ExecuteWithParameter("get_subsidiary_ledger", ConnectionStringFS, CommandType.StoredProcedure, col)

        Dim str_log = ""
        For Each i In col
            str_log = String.Format("{0},'{1}'", str_log, i.Value)
        Next
        str_log = str_log.Substring(1)
        MyDebugging.AddText("ExecuteWithParameter : get_subsidiary_ledger")
        MyDebugging.AddText(str_log)

        Dim dt_company As DataTable = Query(sql_company)

        If dt.Rows.Count = 0 Then
            MsgBox("No Records To Print.")
            Exit Sub
        End If

        ds.Tables("Account").Clear()
        ds.Tables("Company").Clear()

        For Each row As DataRow In dt.Rows
            ds.Tables("Account").ImportRow(row)
        Next

        For Each row As DataRow In dt_company.Rows
            ds.Tables("Company").ImportRow(row)
        Next

        If currency = "2" And Not wComparison Then
            For Each row As DataRow In ds.Tables("Account").Rows
                row.Item("debit") = row.Item("debit_based")
                row.Item("credit") = row.Item("credit_based")
            Next
        End If

        Dim _Range As String = ""
        Select Case range
            Case "1"
                _Range = String.Format("FROM {0} TO {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            Case "2"
                _Range = String.Format("AS OF {0}", txt_date_to.Value.ToString("MMMM dd, yyyy"))
            Case "3"
                _Range = String.Format("Range W/ Beginning Balance : {0} - {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
        End Select

        If sender.name = "btnPrint" Then
            If Not groupByBook.Checked Then
                For Each dr As DataRow In ds.Tables("Account").Rows
                    dr.Item("book_name") = ""
                    dr.Item("book_code") = ""
                    dr.Item("book_id") = ""
                Next
            End If
            If wComparison And currency = "2" Then
                Dim rep As New report_apsubsidiary_print
                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                'rep.title.Text = _title
                rep.range.Text = _Range
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                Dim rep As New report_apsubsidiary_print_1
                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                'rep.title.Text = _title
                rep.range.Text = _Range
                If currency = "1" And currency_id = "" Then
                    rep.GHCurrency.Visible = False
                End If
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            End If
        Else
            Try
                lblLoad.Visible = True
                Dim dicHeader As New Dictionary(Of String, Object)
                dicHeader.Add("templateName", "")
                dicHeader.Add("CompanyName", "")
                dicHeader.Add("CurrenyName", "")
                Dim colName As String = ""
                Dim listAccount = Nothing
                Dim dateRange As String = _Range
                If dt_company.Rows.Count > 0 Then
                    dicHeader.Item("CompanyName") = dt_company.Rows(0).Item("company_name").ToString
                    dicHeader.Item("CurrencyName") = dt_company.Rows(0).Item("currency_name").ToString
                End If
                dicHeader.Add("ReportName", "Subsidiary Ledger of Accounts Payable")
                dicHeader.Add("RangeType", range)
                dicHeader.Add("DateFrom", txt_date_from.Value)
                dicHeader.Add("DateTo", txt_date_to.Value)
                dicHeader.Add("DateRange", dateRange)
                dicHeader.Add("GroupByBook", groupByBook.Checked)
                dicHeader.Add("NoRunningBalance", NoRunningBalance.Checked)
                dicHeader.Add("TabSeparated", tabSeparated.Checked)
                dicHeader.Add("GroupByUnit", groupByUnit.Checked)
                dicHeader.Add("CurrencyType", currency)
                dicHeader.Add("WithComparison", withComparison.Checked)
                Dim strGrouping As String = ""
                If groupByBook.Checked Then
                    strGrouping &= String.Format(",book_name")
                End If
                If tabSeparated.Checked Then
                    strGrouping &= String.Format(",account_code")
                End If
                If withProjectDepartment.Checked Or project_id <> "" Or department_id <> "" Then
                    strGrouping &= String.Format(",project_name,department_name")
                End If
                If (currency = "2" And withComparison.Checked) Or currency_id <> "" Then
                    strGrouping &= String.Format(",currency_name")
                End If
                strGrouping &= String.Format(",general_code")
                If bookUnitIds <> "" Or groupByUnit.Checked Then
                    strGrouping &= String.Format(",unit_name")
                End If
                strGrouping = strGrouping.Substring(1)
                Dim lstAccount = groupDataTableToList(dt, strGrouping)
                dicHeader.Add("StrGrouping", strGrouping)
                dicHeader.Add("ListAccount", lstAccount)
                dicHeader.Add("Company", dt_company)
                dicHeader.Add("Account", dt)
                ReportInExcel(dicHeader)
#Region "old - 2019-02-04"

                ''If tabSeparated.Checked Then
                'Dim dic As New Dictionary(Of String, Object)
                '    dic.Add("dicHeader", dicHeader)
                '    dic.Add("groupByBook", groupByBook.Checked)
                '    If groupByBook.Checked Then
                '        colName &= ",book_name"
                '    End If
                '    colName &= ",account_code"
                '    If currency = "2" Or currency_id <> "" Then
                '        colName &= ",currency_name"
                '    End If
                '    If currency = "2" And withComparison.Checked Then
                '        dic.Add("withComparison", True)
                '    Else
                '        dic.Add("withComparison", False)
                '    End If
                '    colName &= ",general_code"
                '    listAccount = groupDataTableToList(ds.Tables("Account"), colName.Substring(1))
                '    dic.Add("dateRange", _Range)
                '    dic.Add("colName", colName.Substring(1))
                '    dic.Add("ds", ds)
                '    dic.Add("listAccount", listAccount)
                '    generateTabSeparated(dic, bookUnitIds <> "")
                'Else
                '    If groupByBook.Checked Then
                '        If currency = "2" Then
                '            colName = "book_name,currency_name,general_code"
                '            If tabSeparated.Checked Then
                '                colName = "book_name,account_code,currency_name,general_code"
                '            End If
                '            listAccount = groupDataTableToList(ds.Tables("Account"), colName)
                '            If wComparison Then
                '                dicHeader.Item("templateName") = "arapsubsidiary.xlt"
                '            Else
                '                dicHeader.Item("templateName") = "arapsubsidiary2.xlt"
                '            End If
                '            generateReportExcel(listAccount, colName, dateRange, dicHeader, True, wComparison, bookUnitIds <> "")
                '            'MsgBox("Data Succesfully Load")
                '        Else
                '            colName = "book_name,general_code"
                '            If tabSeparated.Checked Then
                '                colName = "book_name,account_code,general_code"
                '            End If
                '            Dim groupByCurrency As Boolean = False
                '            If currency_id <> "" Then
                '                colName = "book_name,currency_name,general_code"
                '                If tabSeparated.Checked Then
                '                    colName = "book_name,account_code,currency_name,general_code"
                '                End If
                '                groupByCurrency = True
                '            End If
                '            listAccount = groupDataTableToList(ds.Tables("Account"), colName)
                '            dicHeader.Item("templateName") = "arapsubsidiary2.xlt"
                '            generateReportExcel(listAccount, colName, dateRange, dicHeader, groupByCurrency, False, bookUnitIds <> "")
                '            'MsgBox("Data Succesfully Load")
                '        End If
                '    Else
                '        If currency = "2" Then
                '            colName = "currency_name,general_code"
                '            If tabSeparated.Checked Then
                '                colName = "account_code,currency_name,general_code"
                '            End If
                '            listAccount = groupDataTableToList(ds.Tables("Account"), colName)
                '            If wComparison Then
                '                dicHeader.Item("templateName") = "arapsubsidiary.xlt"
                '            Else
                '                dicHeader.Item("templateName") = "arapsubsidiary2.xlt"
                '            End If
                '            generateExcelReport(listAccount, colName, dateRange, dicHeader, True, wComparison, bookUnitIds <> "")
                '            'MsgBox("Data Succesfully Load")
                '        Else
                '            colName = "general_code"
                '            If tabSeparated.Checked Then
                '                colName = "account_code,general_code"
                '            End If
                '            Dim groupByCurrency As Boolean = False
                '            If currency_id <> "" Then
                '                colName = "currency_name,general_code"
                '                If tabSeparated.Checked Then
                '                    colName = "account_code,currency_name,general_code"
                '                End If
                '                groupByCurrency = True

                '            End If
                '            listAccount = groupDataTableToList(ds.Tables("Account"), colName)
                '            dicHeader.Item("templateName") = "arapsubsidiary2.xlt"
                '            generateExcelReport(listAccount, colName, dateRange, dicHeader, groupByCurrency, False, bookUnitIds <> "")
                '            'MsgBox("Data Succesfully Load")
                '        End If
                '    End If
                'End If
#End Region
                MsgBox("Report Done")
                lblLoad.Visible = False
            Catch ex As Exception
                lblLoad.Visible = False
                MsgBox(String.Format("Error Occured : {0}", ex.Message))
                MyDebugging.AddText(ex.Message)
            End Try
        End If
    End Sub
    Private Function ExcelRange(ByRef xlWorkSheet As Excel.Worksheet,
                           ByVal r As Integer,
                           ByVal c As Integer,
                           Optional fr As Integer = -1,
                           Optional fc As Integer = -1) As Excel.Range
        fr = If(fr < 0, r, fr)
        fc = If(fc < 0, c, fc)
        Return xlWorkSheet.Range(xlWorkSheet.Cells(r, c), xlWorkSheet.Cells(fr, fc))
    End Function
    Private Sub ReportInExcel(ByRef dic As Dictionary(Of String, Object))
        Dim CompanyName As String = dic.Item("CompanyName")
        Dim CurrencyName As String = dic.Item("CurrencyName")
        Dim ReportName As String = dic.Item("ReportName")
        Dim RangeType As String = dic.Item("RangeType")
        Dim DateFrom As Date = dic.Item("DateFrom")
        Dim DateTo As Date = dic.Item("DateTo")
        Dim DateRange As String = dic.Item("DateRange")
        Dim GroupByBook As Boolean = dic.Item("GroupByBook")
        Dim NoRunningBalance As Boolean = dic.Item("NoRunningBalance")
        Dim TabSeparated As Boolean = dic.Item("TabSeparated")
        Dim GroupByUnit As Boolean = dic.Item("GroupByUnit")
        Dim CurrencyType As String = dic.Item("CurrencyType")
        Dim WithComparison As Boolean = dic.Item("WithComparison")
        Dim StrGrouping As String = dic.Item("StrGrouping")
        Dim ListAccount As List(Of Object) = dic.Item("ListAccount")
        Dim DTCompany As DataTable = dic.Item("Company")
        Dim DTAccount As DataTable = dic.Item("Account")
        If GroupByBook Then
            If TabSeparated Then
                For Each Book In ListAccount
                    Dim xlApp As Excel.Application
                    Dim xlWorkBook As Excel.Workbook
                    Dim xlWorkSheet As Excel.Worksheet

                    xlApp = New Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add
                    xlApp.Visible = True
                    xlApp.DisplayAlerts = False
                    Dim ctrTab As Integer = 0
                    If xlWorkBook.Worksheets.Count = 3 Then
                        xlWorkBook.Worksheets(1).Delete()
                        xlWorkBook.Worksheets(1).Delete()
                    End If
                    For Each Account In Book.Item("grouped")
                        If ctrTab > 0 Then
                            xlWorkBook.Worksheets().Add()
                        End If

                        ctrTab += 1

                        xlWorkSheet = xlWorkBook.Worksheets(1)
                        xlWorkSheet.Visible = True
                        Dim sheetName As String = Regex.Replace(Account.Item("account_code").ToString.Trim, "[^A-Za-z0-9,-]", "")
                        If sheetName.Length >= 30 Then
                            sheetName = sheetName.Substring(0, 30)
                        End If
                        xlWorkSheet.Name = sheetName

                        xlWorkSheet.Cells(1, 1) = CompanyName
                        xlWorkSheet.Cells(2, 1) = String.Format("{0} - {1}", ReportName, Book.Item("book_name"))
                        xlWorkSheet.Cells(3, 1) = DateRange

                        xlWorkSheet.Cells(4, 1) = "Date"
                        xlWorkSheet.Cells(4, 2) = "Transaction No."
                        xlWorkSheet.Cells(4, 3) = "Collection Reference"
                        xlWorkSheet.Cells(4, 4) = "Particulars"
                        xlWorkSheet.Cells(4, 5) = "Account Code"
                        xlWorkSheet.Cells(4, 6) = "Account Title"

                        ExcelRange(xlWorkSheet, 4, 1).ColumnWidth = 15
                        ExcelRange(xlWorkSheet, 4, 2).ColumnWidth = 20
                        ExcelRange(xlWorkSheet, 4, 3).ColumnWidth = 20
                        ExcelRange(xlWorkSheet, 4, 4).ColumnWidth = 30
                        ExcelRange(xlWorkSheet, 4, 5).ColumnWidth = 30
                        ExcelRange(xlWorkSheet, 4, 6).ColumnWidth = 30

                        Dim lastColumn As Integer = 0
                        If WithComparison Then
                            xlWorkSheet.Cells(4, 7) = "Debit in Original Amount"
                            xlWorkSheet.Cells(4, 8) = "Credit in Original Amount"
                            If NoRunningBalance Then
                                xlWorkSheet.Cells(4, 9) = "Debit in " & CurrencyName
                                xlWorkSheet.Cells(4, 10) = "Credit in " & CurrencyName
                                xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                                xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                                lastColumn = 10
                            Else
                                xlWorkSheet.Cells(4, 9) = "Balance in Original Amount"
                                xlWorkSheet.Cells(4, 10) = "Debit in " & CurrencyName
                                xlWorkSheet.Cells(4, 11) = "Credit in " & CurrencyName
                                xlWorkSheet.Cells(4, 12) = "Balance in " & CurrencyName
                                xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                                xlWorkSheet.Cells(4, 11).ColumnWidth = 15
                                xlWorkSheet.Cells(4, 12).ColumnWidth = 15
                                lastColumn = 12
                            End If
                        Else
                            xlWorkSheet.Cells(4, 7) = "Debit"
                            xlWorkSheet.Cells(4, 8) = "Credit"
                            If Not NoRunningBalance Then
                                xlWorkSheet.Cells(4, 9) = "Balance"
                                lastColumn = 9
                            Else
                                lastColumn = 8
                            End If
                        End If

                        ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).WrapText = True
                        ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, 1, 1, 1, lastColumn).MergeCells = True
                        ExcelRange(xlWorkSheet, 2, 1, 2, lastColumn).MergeCells = True
                        ExcelRange(xlWorkSheet, 3, 1, 3, lastColumn).MergeCells = True
                        ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).Font.Bold = True
                        ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Interior.Color = System.Drawing.Color.FromArgb(222, 235, 246)

                        Dim FirstRow As Integer = 5
                        Dim CurrentRow As Integer = 5
                        Dim CurrentIndex As Integer = 2
                        Dim newDic = dic
                        If newDic.ContainsKey("FirstRow") Then
                            newDic.Item("FirstRow") = FirstRow
                            newDic.Item("CurrentRow") = CurrentRow
                            newDic.Item("CurrentIndex") = CurrentIndex
                            newDic.Item("LastColumn") = lastColumn
                            newDic.Item("xlWorkSheet") = xlWorkSheet
                        Else
                            newDic.Add("FirstRow", FirstRow)
                            newDic.Add("CurrentRow", CurrentRow)
                            newDic.Add("CurrentIndex", CurrentIndex)
                            newDic.Add("LastColumn", lastColumn)
                            newDic.Add("xlWorkSheet", xlWorkSheet)
                        End If
                        If Account.ContainsKey("datas") Then
                            dic.Item("ListAccount") = Account.Item("datas")
                        Else
                            dic.Item("ListAccount") = Account.Item("grouped")
                        End If
                        ReportInExcelDetailed(dic)

                        FirstRow = newDic.Item("FirstRow")
                        CurrentRow = newDic.Item("CurrentRow")
                        CurrentIndex = newDic.Item("CurrentIndex")
                        xlWorkSheet = newDic.Item("xlWorkSheet")

                        CurrentRow += 1

                        xlWorkSheet.Cells(CurrentRow, 1).Value = "ENDING BALANCE : "
                        xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                        xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                        xlWorkSheet.Cells(CurrentRow, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", FirstRow, CurrentRow - 2)
                        xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", FirstRow, CurrentRow - 2)
                        If Not NoRunningBalance Then
                            xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow)
                            ExcelRange(xlWorkSheet, CurrentRow, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If

                        ExcelRange(xlWorkSheet, CurrentRow, 5, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                        If WithComparison Then
                            If NoRunningBalance Then
                                xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", FirstRow, CurrentRow - 2)
                                xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, CurrentRow - 2)
                            Else
                                xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, CurrentRow - 2)
                                xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=SUBTOTAL(9,K{0}:K{1})", FirstRow, CurrentRow - 2)
                                xlWorkSheet.Cells(CurrentRow, 12).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", CurrentRow)
                                ExcelRange(xlWorkSheet, CurrentRow, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            End If

                            ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                        End If
                        If NoRunningBalance Then
                            CurrentRow += 1
                            xlWorkSheet.Cells(CurrentRow, 1).Value = "NET : "
                            xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                            xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                            xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow - 1)
                            ExcelRange(xlWorkSheet, CurrentRow, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            If WithComparison Then
                                xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", CurrentRow - 1)
                                ExcelRange(xlWorkSheet, CurrentRow, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            End If
                            ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                        End If
                    Next
                Next
            Else
                Dim xlApp As Excel.Application
                Dim xlWorkBook As Excel.Workbook
                Dim xlWorkSheet As Excel.Worksheet

                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Add
                xlApp.Visible = True
                xlApp.DisplayAlerts = False
                Dim ctrTab As Integer = 0
                If xlWorkBook.Worksheets.Count = 3 Then
                    xlWorkBook.Worksheets(1).Delete()
                    xlWorkBook.Worksheets(1).Delete()
                End If
                For Each Book In ListAccount
                    If ctrTab > 0 Then
                        xlWorkBook.Worksheets().Add()
                    End If

                    ctrTab += 1

                    xlWorkSheet = xlWorkBook.Worksheets(1)
                    xlWorkSheet.Visible = True
                    Dim sheetName As String = Regex.Replace(Book.Item("book_name").ToString.Trim, "[^A-Za-z0-9,-]", "")
                    If sheetName.Length >= 30 Then
                        sheetName = sheetName.Substring(0, 30)
                    End If
                    xlWorkSheet.Name = sheetName

                    xlWorkSheet.Cells(1, 1) = CompanyName
                    xlWorkSheet.Cells(2, 1) = String.Format("{0} - {1}", ReportName, Book.Item("book_name"))
                    xlWorkSheet.Cells(3, 1) = DateRange

                    xlWorkSheet.Cells(4, 1) = "Date"
                    xlWorkSheet.Cells(4, 2) = "Transaction No."
                    xlWorkSheet.Cells(4, 3) = "Collection Reference"
                    xlWorkSheet.Cells(4, 4) = "Particulars"
                    xlWorkSheet.Cells(4, 5) = "Account Code"
                    xlWorkSheet.Cells(4, 6) = "Account Title"

                    ExcelRange(xlWorkSheet, 4, 1).ColumnWidth = 15
                    ExcelRange(xlWorkSheet, 4, 2).ColumnWidth = 20
                    ExcelRange(xlWorkSheet, 4, 3).ColumnWidth = 20
                    ExcelRange(xlWorkSheet, 4, 4).ColumnWidth = 30
                    ExcelRange(xlWorkSheet, 4, 5).ColumnWidth = 30
                    ExcelRange(xlWorkSheet, 4, 6).ColumnWidth = 30

                    Dim lastColumn As Integer = 0
                    If WithComparison Then
                        xlWorkSheet.Cells(4, 7) = "Debit in Original Amount"
                        xlWorkSheet.Cells(4, 8) = "Credit in Original Amount"
                        If NoRunningBalance Then
                            xlWorkSheet.Cells(4, 9) = "Debit in " & CurrencyName
                            xlWorkSheet.Cells(4, 10) = "Credit in " & CurrencyName
                            xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                            lastColumn = 10
                        Else
                            xlWorkSheet.Cells(4, 9) = "Balance in Original Amount"
                            xlWorkSheet.Cells(4, 10) = "Debit in " & CurrencyName
                            xlWorkSheet.Cells(4, 11) = "Credit in " & CurrencyName
                            xlWorkSheet.Cells(4, 12) = "Balance in " & CurrencyName
                            xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 11).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 12).ColumnWidth = 15
                            lastColumn = 12
                        End If
                    Else
                        xlWorkSheet.Cells(4, 7) = "Debit"
                        xlWorkSheet.Cells(4, 8) = "Credit"
                        If Not NoRunningBalance Then
                            xlWorkSheet.Cells(4, 9) = "Balance"
                            lastColumn = 9
                        Else
                            lastColumn = 8
                        End If
                    End If

                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).WrapText = True
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 1, 1, 1, lastColumn).MergeCells = True
                    ExcelRange(xlWorkSheet, 2, 1, 2, lastColumn).MergeCells = True
                    ExcelRange(xlWorkSheet, 3, 1, 3, lastColumn).MergeCells = True
                    ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).Font.Bold = True
                    ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Interior.Color = System.Drawing.Color.FromArgb(222, 235, 246)

                    Dim FirstRow As Integer = 5
                    Dim CurrentRow As Integer = 5
                    Dim CurrentIndex As Integer = 1
                    Dim newDic = dic
                    If newDic.ContainsKey("FirstRow") Then
                        newDic.Item("FirstRow") = FirstRow
                        newDic.Item("CurrentRow") = CurrentRow
                        newDic.Item("CurrentIndex") = CurrentIndex
                        newDic.Item("LastColumn") = lastColumn
                        newDic.Item("xlWorkSheet") = xlWorkSheet
                    Else
                        newDic.Add("FirstRow", FirstRow)
                        newDic.Add("CurrentRow", CurrentRow)
                        newDic.Add("CurrentIndex", CurrentIndex)
                        newDic.Add("LastColumn", lastColumn)
                        newDic.Add("xlWorkSheet", xlWorkSheet)
                    End If
                    If Book.ContainsKey("datas") Then
                        dic.Item("ListAccount") = Book.Item("datas")
                    Else
                        dic.Item("ListAccount") = Book.Item("grouped")
                    End If
                    ReportInExcelDetailed(dic)

                    FirstRow = newDic.Item("FirstRow")
                    CurrentRow = newDic.Item("CurrentRow")
                    CurrentIndex = newDic.Item("CurrentIndex")
                    xlWorkSheet = newDic.Item("xlWorkSheet")

                    CurrentRow += 1

                    xlWorkSheet.Cells(CurrentRow, 1).Value = "ENDING BALANCE : "
                    xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                    xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                    xlWorkSheet.Cells(CurrentRow, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", FirstRow, CurrentRow - 2)
                    xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", FirstRow, CurrentRow - 2)
                    If Not NoRunningBalance Then
                        xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow)
                        ExcelRange(xlWorkSheet, CurrentRow, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    End If

                    ExcelRange(xlWorkSheet, CurrentRow, 5, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    If WithComparison Then
                        If NoRunningBalance Then
                            xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", FirstRow, CurrentRow - 2)
                            xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, CurrentRow - 2)
                        Else
                            xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, CurrentRow - 2)
                            xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=SUBTOTAL(9,K{0}:K{1})", FirstRow, CurrentRow - 2)
                            xlWorkSheet.Cells(CurrentRow, 12).Value = String.Format("=FIXED(IMSUB(K{0},J{0}))", CurrentRow)
                            ExcelRange(xlWorkSheet, CurrentRow, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If

                        ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    End If
                    If NoRunningBalance Then
                        CurrentRow += 1
                        xlWorkSheet.Cells(CurrentRow, 1).Value = "NET : "
                        xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                        xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                        xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow - 1)
                        ExcelRange(xlWorkSheet, CurrentRow, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        If WithComparison Then
                            xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", CurrentRow - 1)
                            ExcelRange(xlWorkSheet, CurrentRow, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If
                        ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    End If
                Next
            End If
        Else
            If TabSeparated Then
                Dim xlApp As Excel.Application
                Dim xlWorkBook As Excel.Workbook
                Dim xlWorkSheet As Excel.Worksheet

                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Add
                xlApp.Visible = True
                xlApp.DisplayAlerts = False
                Dim ctrTab As Integer = 0
                If xlWorkBook.Worksheets.Count = 3 Then
                    xlWorkBook.Worksheets(1).Delete()
                    xlWorkBook.Worksheets(1).Delete()
                End If
                For Each Account In ListAccount
                    If ctrTab > 0 Then
                        xlWorkBook.Worksheets().Add()
                    End If

                    ctrTab += 1

                    xlWorkSheet = xlWorkBook.Worksheets(1)
                    xlWorkSheet.Visible = True
                    Dim sheetName As String = Regex.Replace(Account.Item("account_code").ToString.Trim, "[^A-Za-z0-9,-]", "")
                    If sheetName.Length >= 30 Then
                        sheetName = sheetName.Substring(0, 30)
                    End If
                    xlWorkSheet.Name = sheetName

                    xlWorkSheet.Cells(1, 1) = CompanyName
                    xlWorkSheet.Cells(2, 1) = String.Format("{0}", ReportName)
                    xlWorkSheet.Cells(3, 1) = DateRange

                    xlWorkSheet.Cells(4, 1) = "Date"
                    xlWorkSheet.Cells(4, 2) = "Transaction No."
                    xlWorkSheet.Cells(4, 3) = "Collection Reference"
                    xlWorkSheet.Cells(4, 4) = "Particulars"
                    xlWorkSheet.Cells(4, 5) = "Account Code"
                    xlWorkSheet.Cells(4, 6) = "Account Title"

                    ExcelRange(xlWorkSheet, 4, 1).ColumnWidth = 15
                    ExcelRange(xlWorkSheet, 4, 2).ColumnWidth = 20
                    ExcelRange(xlWorkSheet, 4, 3).ColumnWidth = 20
                    ExcelRange(xlWorkSheet, 4, 4).ColumnWidth = 30
                    ExcelRange(xlWorkSheet, 4, 5).ColumnWidth = 30
                    ExcelRange(xlWorkSheet, 4, 6).ColumnWidth = 30

                    Dim lastColumn As Integer = 0
                    If WithComparison Then
                        xlWorkSheet.Cells(4, 7) = "Debit in Original Amount"
                        xlWorkSheet.Cells(4, 8) = "Credit in Original Amount"
                        If NoRunningBalance Then
                            xlWorkSheet.Cells(4, 9) = "Debit in " & CurrencyName
                            xlWorkSheet.Cells(4, 10) = "Credit in " & CurrencyName
                            xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                            lastColumn = 10
                        Else
                            xlWorkSheet.Cells(4, 9) = "Balance in Original Amount"
                            xlWorkSheet.Cells(4, 10) = "Debit in " & CurrencyName
                            xlWorkSheet.Cells(4, 11) = "Credit in " & CurrencyName
                            xlWorkSheet.Cells(4, 12) = "Balance in " & CurrencyName
                            xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 11).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 12).ColumnWidth = 15
                            lastColumn = 12
                        End If
                    Else
                        xlWorkSheet.Cells(4, 7) = "Debit"
                        xlWorkSheet.Cells(4, 8) = "Credit"
                        If Not NoRunningBalance Then
                            xlWorkSheet.Cells(4, 9) = "Balance"
                            lastColumn = 9
                        Else
                            lastColumn = 8
                        End If
                    End If

                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).WrapText = True
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, 1, 1, 1, lastColumn).MergeCells = True
                    ExcelRange(xlWorkSheet, 2, 1, 2, lastColumn).MergeCells = True
                    ExcelRange(xlWorkSheet, 3, 1, 3, lastColumn).MergeCells = True
                    ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).Font.Bold = True
                    ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Interior.Color = System.Drawing.Color.FromArgb(222, 235, 246)

                    Dim FirstRow As Integer = 5
                    Dim CurrentRow As Integer = 5
                    Dim CurrentIndex As Integer = 1
                    Dim newDic = dic
                    If newDic.ContainsKey("FirstRow") Then
                        newDic.Item("FirstRow") = FirstRow
                        newDic.Item("CurrentRow") = CurrentRow
                        newDic.Item("CurrentIndex") = CurrentIndex
                        newDic.Item("LastColumn") = lastColumn
                        newDic.Item("xlWorkSheet") = xlWorkSheet
                    Else
                        newDic.Add("FirstRow", FirstRow)
                        newDic.Add("CurrentRow", CurrentRow)
                        newDic.Add("CurrentIndex", CurrentIndex)
                        newDic.Add("LastColumn", lastColumn)
                        newDic.Add("xlWorkSheet", xlWorkSheet)
                    End If
                    If Account.ContainsKey("datas") Then
                        dic.Item("ListAccount") = Account.Item("datas")
                    Else
                        dic.Item("ListAccount") = Account.Item("grouped")
                    End If
                    ReportInExcelDetailed(dic)

                    FirstRow = newDic.Item("FirstRow")
                    CurrentRow = newDic.Item("CurrentRow")
                    CurrentIndex = newDic.Item("CurrentIndex")
                    xlWorkSheet = newDic.Item("xlWorkSheet")

                    CurrentRow += 1

                    xlWorkSheet.Cells(CurrentRow, 1).Value = "ENDING BALANCE : "
                    xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                    xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                    xlWorkSheet.Cells(CurrentRow, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", FirstRow, CurrentRow - 2)
                    xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", FirstRow, CurrentRow - 2)
                    If Not NoRunningBalance Then
                        xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow)
                        ExcelRange(xlWorkSheet, CurrentRow, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    End If

                    ExcelRange(xlWorkSheet, CurrentRow, 5, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    If WithComparison Then
                        If NoRunningBalance Then
                            xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", FirstRow, CurrentRow - 2)
                            xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, CurrentRow - 2)
                        Else
                            xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, CurrentRow - 2)
                            xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=SUBTOTAL(9,K{0}:K{1})", FirstRow, CurrentRow - 2)
                            xlWorkSheet.Cells(CurrentRow, 12).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", CurrentRow)
                            ExcelRange(xlWorkSheet, CurrentRow, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If

                        ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    End If
                    If NoRunningBalance Then
                        CurrentRow += 1
                        xlWorkSheet.Cells(CurrentRow, 1).Value = "NET : "
                        xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                        xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                        xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow - 1)
                        ExcelRange(xlWorkSheet, CurrentRow, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        If WithComparison Then
                            xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", CurrentRow - 1)
                            ExcelRange(xlWorkSheet, CurrentRow, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If
                        ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    End If
                Next
            Else
                Dim xlApp As Excel.Application
                Dim xlWorkBook As Excel.Workbook
                Dim xlWorkSheet As Excel.Worksheet

                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Add
                xlApp.Visible = True
                xlApp.DisplayAlerts = False

                xlWorkSheet = xlWorkBook.Worksheets(1)

                xlWorkSheet.Cells(1, 1) = CompanyName
                xlWorkSheet.Cells(2, 1) = String.Format("{0}", ReportName)
                xlWorkSheet.Cells(3, 1) = DateRange

                xlWorkSheet.Cells(4, 1) = "Date"
                xlWorkSheet.Cells(4, 2) = "Transaction No."
                xlWorkSheet.Cells(4, 3) = "Collection Reference"
                xlWorkSheet.Cells(4, 4) = "Particulars"
                xlWorkSheet.Cells(4, 5) = "Account Code"
                xlWorkSheet.Cells(4, 6) = "Account Title"

                ExcelRange(xlWorkSheet, 4, 1).ColumnWidth = 15
                ExcelRange(xlWorkSheet, 4, 2).ColumnWidth = 20
                ExcelRange(xlWorkSheet, 4, 3).ColumnWidth = 20
                ExcelRange(xlWorkSheet, 4, 4).ColumnWidth = 30
                ExcelRange(xlWorkSheet, 4, 5).ColumnWidth = 30
                ExcelRange(xlWorkSheet, 4, 6).ColumnWidth = 30

                Dim lastColumn As Integer = 0
                If WithComparison Then
                    xlWorkSheet.Cells(4, 7) = "Debit in Original Amount"
                    xlWorkSheet.Cells(4, 8) = "Credit in Original Amount"
                    If NoRunningBalance Then
                        xlWorkSheet.Cells(4, 9) = "Debit in " & CurrencyName
                        xlWorkSheet.Cells(4, 10) = "Credit in " & CurrencyName
                        xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                        xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                        lastColumn = 10
                    Else
                        xlWorkSheet.Cells(4, 9) = "Balance in Original Amount"
                        xlWorkSheet.Cells(4, 10) = "Debit in " & CurrencyName
                        xlWorkSheet.Cells(4, 11) = "Credit in " & CurrencyName
                        xlWorkSheet.Cells(4, 12) = "Balance in " & CurrencyName
                        xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                        xlWorkSheet.Cells(4, 11).ColumnWidth = 15
                        xlWorkSheet.Cells(4, 12).ColumnWidth = 15
                        lastColumn = 12
                    End If
                Else
                    xlWorkSheet.Cells(4, 7) = "Debit"
                    xlWorkSheet.Cells(4, 8) = "Credit"
                    If Not NoRunningBalance Then
                        xlWorkSheet.Cells(4, 9) = "Balance"
                        lastColumn = 9
                    Else
                        lastColumn = 8
                    End If
                End If

                ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).WrapText = True
                ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, 1, 1, 1, lastColumn).MergeCells = True
                ExcelRange(xlWorkSheet, 2, 1, 2, lastColumn).MergeCells = True
                ExcelRange(xlWorkSheet, 3, 1, 3, lastColumn).MergeCells = True
                ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).Font.Bold = True
                ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                ExcelRange(xlWorkSheet, 1, 1, 4, lastColumn).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                ExcelRange(xlWorkSheet, 4, 1, 4, lastColumn).Interior.Color = System.Drawing.Color.FromArgb(222, 235, 246)

                Dim FirstRow As Integer = 5
                Dim CurrentRow As Integer = 5
                Dim CurrentIndex As Integer = 0
                Dim newDic = dic
                If newDic.ContainsKey("FirstRow") Then
                    newDic.Item("FirstRow") = FirstRow
                    newDic.Item("CurrentRow") = CurrentRow
                    newDic.Item("CurrentIndex") = CurrentIndex
                    newDic.Item("LastColumn") = lastColumn
                    newDic.Item("xlWorkSheet") = xlWorkSheet
                Else
                    newDic.Add("FirstRow", FirstRow)
                    newDic.Add("CurrentRow", CurrentRow)
                    newDic.Add("CurrentIndex", CurrentIndex)
                    newDic.Add("LastColumn", lastColumn)
                    newDic.Add("xlWorkSheet", xlWorkSheet)
                End If

                ReportInExcelDetailed(dic)

                FirstRow = newDic.Item("FirstRow")
                CurrentRow = newDic.Item("CurrentRow")
                CurrentIndex = newDic.Item("CurrentIndex")
                xlWorkSheet = newDic.Item("xlWorkSheet")

                CurrentRow += 1

                xlWorkSheet.Cells(CurrentRow, 1).Value = "ENDING BALANCE : "
                xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                xlWorkSheet.Cells(CurrentRow, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", FirstRow, CurrentRow - 2)
                xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", FirstRow, CurrentRow - 2)
                If Not NoRunningBalance Then
                    xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow)
                    ExcelRange(xlWorkSheet, CurrentRow, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                End If

                ExcelRange(xlWorkSheet, CurrentRow, 5, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                If WithComparison Then
                    If NoRunningBalance Then
                        xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", FirstRow, CurrentRow - 2)
                        xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, CurrentRow - 2)
                    Else
                        xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, CurrentRow - 2)
                        xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=SUBTOTAL(9,K{0}:K{1})", FirstRow, CurrentRow - 2)
                        xlWorkSheet.Cells(CurrentRow, 12).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", CurrentRow)
                        ExcelRange(xlWorkSheet, CurrentRow, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    End If

                    ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                End If
                If NoRunningBalance Then
                    CurrentRow += 1
                    xlWorkSheet.Cells(CurrentRow, 1).Value = "NET : "
                    xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                    xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                    xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow - 1)
                    ExcelRange(xlWorkSheet, CurrentRow, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    If WithComparison Then
                        xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", CurrentRow - 1)
                        ExcelRange(xlWorkSheet, CurrentRow, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    End If
                    ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, lastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Font.Bold = True
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, lastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                End If
            End If
        End If
    End Sub
    Private Sub ReportInExcelDetailed(ByRef dic As Dictionary(Of String, Object))
        Dim CompanyName As String = dic.Item("CompanyName")
        Dim CurrencyName As String = dic.Item("CurrencyName")
        Dim ReportName As String = dic.Item("ReportName")
        Dim RangeType As String = dic.Item("RangeType")
        Dim DateFrom As Date = dic.Item("DateFrom")
        Dim DateTo As Date = dic.Item("DateTo")
        Dim DateRange As String = dic.Item("DateRange")
        Dim GroupByBook As Boolean = dic.Item("GroupByBook")
        Dim NoRunningBalance As Boolean = dic.Item("NoRunningBalance")
        Dim TabSeparated As Boolean = dic.Item("TabSeparated")
        Dim GroupByUnit As Boolean = dic.Item("GroupByUnit")
        Dim CurrencyType As String = dic.Item("CurrencyType")
        Dim WithComparison As Boolean = dic.Item("WithComparison")
        Dim StrGrouping As String = dic.Item("StrGrouping")
        Dim ListAccount As List(Of Object) = dic.Item("ListAccount")
        Dim DTCompany As DataTable = dic.Item("Company")
        Dim DTAccount As DataTable = dic.Item("Account")

        Dim CurrentRow As Integer = dic.Item("CurrentRow")
        Dim CurrentIndex As Integer = dic.Item("CurrentIndex")
        Dim LastColumn As Integer = dic.Item("LastColumn")
        Dim xlWorkSheet As Excel.Worksheet = dic.Item("xlWorkSheet")

        Dim fields = StrGrouping.Split(",")
        Dim field = fields(CurrentIndex)
        For Each Item In ListAccount
            If field = "general_code" Then
                Dim drs = DTAccount.Select(String.Format("general_code = '{0}'", Item.Item(field)))
                If drs.Length > 0 Then
                    Dim general_name As String = drs(0).Item("general_name").ToString
                    xlWorkSheet.Cells(CurrentRow, 1).Value = "'" & Item.Item(field)
                    xlWorkSheet.Cells(CurrentRow, 2).Value = general_name
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, 2).Font.Bold = True
                    ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, 2).Font.Underline = True
                    ExcelRange(xlWorkSheet, CurrentRow, 1).IndentLevel = 2
                    CurrentRow += 1
                End If
            Else
                xlWorkSheet.Cells(CurrentRow, 1).Value = Item.Item(field)
                ExcelRange(xlWorkSheet, CurrentRow, 1).Font.Bold = True
                ExcelRange(xlWorkSheet, CurrentRow, 1).Font.Underline = True
                ExcelRange(xlWorkSheet, CurrentRow, 1).IndentLevel = 5
                CurrentRow += 1
            End If
            Dim FirstRow As Integer = CurrentRow
            CurrentIndex += 1
            dic.Item("CurrentRow") = CurrentRow
            dic.Item("CurrentIndex") = CurrentIndex
            If Item.ContainsKey("grouped") Then
                dic.Item("ListAccount") = Item.Item("grouped")
                ReportInExcelDetailed(dic)
                CurrentRow = dic.Item("CurrentRow")
                CurrentIndex = dic.Item("CurrentIndex")
                'CurrentRow += 1
                CurrentIndex -= 1
            Else
                Dim balance As Decimal = 0
                Dim balance_based As Decimal = 0
                For Each Account In Item.Item("datas")
                    Dim particulars As String = If(ifNull(Account.Item("journal_id"), "8") = "8", "BEGINNING BALANCE", Account.Item("description"))
                    Dim debit As Decimal = CDec(ifNull(Account.Item("debit"), 0))
                    Dim credit As Decimal = CDec(ifNull(Account.Item("credit"), 0))
                    Dim debit_based As Decimal = CDec(ifNull(Account.Item("debit_based"), 0))
                    Dim credit_based As Decimal = CDec(ifNull(Account.Item("credit_based"), 0))
                    If credit > debit Then
                        balance += credit - debit
                        balance_based += credit_based - debit_based
                    Else
                        balance -= debit - credit
                        balance_based -= debit_based - credit_based
                    End If
                    xlWorkSheet.Cells(CurrentRow, 1) = Account.Item("trans_date")
                    xlWorkSheet.Cells(CurrentRow, 2) = "'" & Account.Item("trans_no")
                    xlWorkSheet.Cells(CurrentRow, 3) = "'" & Account.Item("dn_ref")
                    xlWorkSheet.Cells(CurrentRow, 4) = particulars
                    xlWorkSheet.Cells(CurrentRow, 5) = "'" & Account.Item("account_code")
                    xlWorkSheet.Cells(CurrentRow, 6) = Account.Item("account_name")
                    xlWorkSheet.Cells(CurrentRow, 7) = debit
                    xlWorkSheet.Cells(CurrentRow, 8) = credit
                    If Not NoRunningBalance Then
                        xlWorkSheet.Cells(CurrentRow, 9) = balance
                    End If
                    If WithComparison Then
                        If NoRunningBalance Then
                            xlWorkSheet.Cells(CurrentRow, 9) = debit_based
                            xlWorkSheet.Cells(CurrentRow, 10) = credit_based
                        Else
                            xlWorkSheet.Cells(CurrentRow, 10) = debit_based
                            xlWorkSheet.Cells(CurrentRow, 11) = credit_based
                            xlWorkSheet.Cells(CurrentRow, 12) = balance_based
                        End If
                    End If
                    ExcelRange(xlWorkSheet, CurrentRow, 1).NumberFormat = "mm/dd/yyyy"
                    ExcelRange(xlWorkSheet, CurrentRow, 7,, LastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                    CurrentRow += 1
                Next
                CurrentIndex -= 1
            End If
            xlWorkSheet.Cells(CurrentRow, 1) = "TOTAL DEBIT/CREDIT :"
            ExcelRange(xlWorkSheet, CurrentRow, 1).Font.Italic = True
            ExcelRange(xlWorkSheet, CurrentRow, 1).IndentLevel = 5
            xlWorkSheet.Cells(CurrentRow, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", FirstRow, (CurrentRow - 1))
            xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", FirstRow, (CurrentRow - 1))
            If Not NoRunningBalance Then
                xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", (CurrentRow))
                ExcelRange(xlWorkSheet, CurrentRow, 9).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
            If WithComparison Then
                If NoRunningBalance Then
                    xlWorkSheet.Cells(CurrentRow, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", FirstRow, (CurrentRow - 1))
                    xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, (CurrentRow - 1))
                Else
                    xlWorkSheet.Cells(CurrentRow, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", FirstRow, (CurrentRow - 1))
                    xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=SUBTOTAL(9,K{0}:K{1})", FirstRow, (CurrentRow - 1))
                    xlWorkSheet.Cells(CurrentRow, 12).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", (CurrentRow))
                    ExcelRange(xlWorkSheet, CurrentRow, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                End If
            End If
            ExcelRange(xlWorkSheet, CurrentRow, 1,, LastColumn).Font.Bold = True
            ExcelRange(xlWorkSheet, CurrentRow, 1,, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            ExcelRange(xlWorkSheet, CurrentRow, 1,, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
            ExcelRange(xlWorkSheet, CurrentRow, 1,, LastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
            CurrentRow += 1
            If NoRunningBalance And field = "general_code" Then
                xlWorkSheet.Cells(CurrentRow, 1).Value = "NET : "
                xlWorkSheet.Cells(CurrentRow, 1).Font.Italic = True
                xlWorkSheet.Cells(CurrentRow, 1).IndentLevel = 5
                xlWorkSheet.Cells(CurrentRow, 8).Value = String.Format("=FIXED(IMSUB(H{0},G{0}),2)", CurrentRow - 1)
                ExcelRange(xlWorkSheet, CurrentRow, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                If WithComparison Then
                    xlWorkSheet.Cells(CurrentRow, 11).Value = String.Format("=FIXED(IMSUB(K{0},J{0}),2)", CurrentRow - 1)
                    ExcelRange(xlWorkSheet, CurrentRow, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                End If
                ExcelRange(xlWorkSheet, CurrentRow, 8, CurrentRow, LastColumn).NumberFormat = "#,##0.00_);(#,##0.00)"
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Font.Bold = True
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                ExcelRange(xlWorkSheet, CurrentRow, 1, CurrentRow, LastColumn).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                CurrentRow += 1
            End If
            dic.Item("CurrentRow") = CurrentRow
            dic.Item("CurrentIndex") = CurrentIndex
        Next
    End Sub
    Private Sub generateTabSeparated(ByVal dic As Dictionary(Of String, Object), ByVal withUnit As Boolean)
        Dim dicHeader As Dictionary(Of String, String) = dic.Item("dicHeader")
        Dim groupByBook As Boolean = dic.Item("groupByBook")
        Dim withComparison As Boolean = dic.Item("withComparison")
        Dim dateRange As String = dic.Item("dateRange")
        Dim colName As String = dic.Item("colName")
        Dim ds As DataSet = dic.Item("ds")
        Dim listAccount As List(Of Object) = dic.Item("listAccount")
        If groupByBook Then
            For Each book In listAccount
                Dim xlApp As Excel.Application
                Dim xlWorkBook As Excel.Workbook
                Dim xlWorkSheet As Excel.Worksheet

                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Add
                xlApp.Visible = True
                xlApp.DisplayAlerts = False
                Dim ctr As Integer = 0
                If xlWorkBook.Worksheets.Count = 3 Then
                    xlWorkBook.Worksheets(1).Delete()
                    xlWorkBook.Worksheets(1).Delete()
                End If

                Dim fields = colName.Split(",")
                If fields(1) = "account_code" Then
                    For Each account In book.Item("grouped")
                        If ctr > 0 Then
                            xlWorkBook.Worksheets().Add()
                        End If

                        ctr += 1

                        xlWorkSheet = xlWorkBook.Worksheets(1)
                        xlWorkSheet.Visible = True
                        Dim sheetName As String = Regex.Replace(account.Item("account_code").ToString.Trim, "[^A-Za-z0-9,-]", "")
                        If sheetName.Length >= 30 Then
                            sheetName = sheetName.Substring(0, 30)
                        End If
                        xlWorkSheet.Name = sheetName

                        xlWorkSheet.Cells(4, 1) = "Date"
                        xlWorkSheet.Cells(4, 2) = "Transaction No."
                        xlWorkSheet.Cells(4, 3) = "Collection Reference"
                        xlWorkSheet.Cells(4, 4) = "Particulars"
                        xlWorkSheet.Cells(4, 5) = "Account Title"

                        xlWorkSheet.Cells(4, 1).ColumnWidth = 15
                        xlWorkSheet.Cells(4, 2).ColumnWidth = 20
                        xlWorkSheet.Cells(4, 3).ColumnWidth = 20
                        xlWorkSheet.Cells(4, 4).ColumnWidth = 30
                        xlWorkSheet.Cells(4, 5).ColumnWidth = 30
                        xlWorkSheet.Cells(4, 6).ColumnWidth = 15
                        xlWorkSheet.Cells(4, 7).ColumnWidth = 15
                        xlWorkSheet.Cells(4, 8).ColumnWidth = 15

                        Dim lastColumn As Integer = 0
                        If withComparison Then
                            xlWorkSheet.Cells(4, 6) = "Debit in Original Amount"
                            xlWorkSheet.Cells(4, 7) = "Credit in Original Amount"
                            If NoRunningBalance.Checked Then
                                xlWorkSheet.Cells(4, 8) = "Debit in " & dicHeader.Item("currencyName")
                                xlWorkSheet.Cells(4, 9) = "Credit in " & dicHeader.Item("currencyName")
                                xlWorkSheet.Cells(4, 8).ColumnWidth = 15
                                xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                                lastColumn = 9
                            Else
                                xlWorkSheet.Cells(4, 8) = "Balance in Original Amount"
                                xlWorkSheet.Cells(4, 9) = "Debit in " & dicHeader.Item("currencyName")
                                xlWorkSheet.Cells(4, 10) = "Credit in " & dicHeader.Item("currencyName")
                                xlWorkSheet.Cells(4, 11) = "Balance in " & dicHeader.Item("currencyName")
                                xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                                xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                                xlWorkSheet.Cells(4, 11).ColumnWidth = 15
                                lastColumn = 11
                            End If
                        Else
                            xlWorkSheet.Cells(4, 6) = "Debit"
                            xlWorkSheet.Cells(4, 7) = "Credit"
                            If NoRunningBalance.Checked Then
                                xlWorkSheet.Cells(4, 8) = "Balance"
                                lastColumn = 8
                            Else
                                lastColumn = 7
                            End If
                        End If

                        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).WrapText = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, lastColumn)).MergeCells = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, lastColumn)).MergeCells = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, lastColumn)).MergeCells = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Interior.Color = System.Drawing.Color.FromArgb(222, 235, 246)

                        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
                        xlWorkSheet.Cells(2, 1) = "AR Subsidiary Ledger" & " - " & book.Item("book_name").ToString
                        xlWorkSheet.Cells(3, 1) = dateRange

                        Dim first_row As Integer = 5
                        Dim current_row As Integer = 5
                        Dim current_index As Integer = 2
                        Dim dicDetailed As New Dictionary(Of String, Object)
                        dicDetailed.Add("withComparison", withComparison)
                        dicDetailed.Add("colName", colName)
                        dicDetailed.Add("ds", ds)
                        dicDetailed.Add("listAccount", account.Item("grouped"))
                        dicDetailed.Add("first_row", first_row)
                        dicDetailed.Add("current_row", current_row)
                        dicDetailed.Add("current_index", current_index)
                        dicDetailed.Add("xlWorkSheet", xlWorkSheet)
                        dicDetailed.Add("isDetailed", False)
                        'generateExcelGroup(xlWorkSheet, g.Item("grouped"), colName, dicHeader, current_row, current_index, originalCurrency, compare, True)
                        generateTabSeparatedDetailed(dicDetailed, withUnit)

                        current_row = dicDetailed.Item("current_row")
                        current_index = dicDetailed.Item("current_index")

                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = "ENDING BALANCE : "
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                        xlWorkSheet.Cells(current_row, 6).Value = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 2)
                        xlWorkSheet.Cells(current_row, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 2)
                        If Not NoRunningBalance.Checked Then
                            xlWorkSheet.Cells(current_row, 8).Value = String.Format("=FIXED(IMSUB(F{0},G{0}),2)", current_row)
                            ExcelRange(xlWorkSheet, current_row, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, lastColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                        If withComparison Then
                            If NoRunningBalance.Checked Then
                                xlWorkSheet.Cells(current_row, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 2)
                                xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 2)
                            Else
                                xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 2)
                                xlWorkSheet.Cells(current_row, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 2)
                                xlWorkSheet.Cells(current_row, 11).Value = String.Format("=FIXED(IMSUB(I{0},J{0}),2)", current_row)
                                ExcelRange(xlWorkSheet, current_row, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                            End If
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, lastColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                        End If
                    Next
                End If
            Next
        Else
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add
            xlApp.Visible = True
            xlApp.DisplayAlerts = False
            Dim ctr As Integer = 0
            If xlWorkBook.Worksheets.Count = 3 Then
                xlWorkBook.Worksheets(1).Delete()
                xlWorkBook.Worksheets(1).Delete()
            End If

            Dim fields = colName.Split(",")
            If fields(0) = "account_code" Then
                For Each account In listAccount
                    If ctr > 0 Then
                        xlWorkBook.Worksheets().Add()
                    End If

                    ctr += 1

                    xlWorkSheet = xlWorkBook.Worksheets(1)
                    xlWorkSheet.Visible = True
                    Dim sheetName As String = Regex.Replace(account.Item("account_code").ToString.Trim, "[^A-Za-z0-9,-]", "")
                    If sheetName.Length >= 30 Then
                        sheetName = sheetName.Substring(0, 30)
                    End If
                    xlWorkSheet.Name = sheetName

                    xlWorkSheet.Cells(4, 1) = "Date"
                    xlWorkSheet.Cells(4, 2) = "Transaction No."
                    xlWorkSheet.Cells(4, 3) = "Collection Reference"
                    xlWorkSheet.Cells(4, 4) = "Particulars"
                    xlWorkSheet.Cells(4, 5) = "Account Title"

                    xlWorkSheet.Cells(4, 1).ColumnWidth = 15
                    xlWorkSheet.Cells(4, 2).ColumnWidth = 20
                    xlWorkSheet.Cells(4, 3).ColumnWidth = 20
                    xlWorkSheet.Cells(4, 4).ColumnWidth = 30
                    xlWorkSheet.Cells(4, 5).ColumnWidth = 30
                    xlWorkSheet.Cells(4, 6).ColumnWidth = 15
                    xlWorkSheet.Cells(4, 7).ColumnWidth = 15
                    xlWorkSheet.Cells(4, 8).ColumnWidth = 15

                    Dim lastColumn As Integer = 0
                    If withComparison Then
                        xlWorkSheet.Cells(4, 6) = "Debit in Original Amount"
                        xlWorkSheet.Cells(4, 7) = "Credit in Original Amount"
                        If NoRunningBalance.Checked Then
                            xlWorkSheet.Cells(4, 8) = "Debit in " & dicHeader.Item("currencyName")
                            xlWorkSheet.Cells(4, 9) = "Credit in " & dicHeader.Item("currencyName")
                            xlWorkSheet.Cells(4, 8).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                            lastColumn = 9
                        Else
                            xlWorkSheet.Cells(4, 8) = "Balance in Original Amount"
                            xlWorkSheet.Cells(4, 9) = "Debit in " & dicHeader.Item("currencyName")
                            xlWorkSheet.Cells(4, 10) = "Credit in " & dicHeader.Item("currencyName")
                            xlWorkSheet.Cells(4, 11) = "Balance in " & dicHeader.Item("currencyName")
                            xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                            xlWorkSheet.Cells(4, 11).ColumnWidth = 15
                            lastColumn = 11
                        End If
                    Else
                        xlWorkSheet.Cells(4, 6) = "Debit"
                        xlWorkSheet.Cells(4, 7) = "Credit"
                        If NoRunningBalance.Checked Then
                            lastColumn = 7
                        Else
                            xlWorkSheet.Cells(4, 8) = "Balance"
                            lastColumn = 8
                        End If
                    End If

                    xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).WrapText = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, lastColumn)).MergeCells = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, lastColumn)).MergeCells = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, lastColumn)).MergeCells = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).Font.Bold = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Interior.Color = System.Drawing.Color.FromArgb(222, 235, 246)

                    xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
                    xlWorkSheet.Cells(2, 1) = "AR Subsidiary Ledger"
                    xlWorkSheet.Cells(3, 1) = dateRange

                    Dim first_row As Integer = 5
                    Dim current_row As Integer = 5
                    Dim current_index As Integer = 1
                    Dim dicDetailed As New Dictionary(Of String, Object)
                    dicDetailed.Add("withComparison", withComparison)
                    dicDetailed.Add("colName", colName)
                    dicDetailed.Add("ds", ds)
                    dicDetailed.Add("listAccount", account.Item("grouped"))
                    dicDetailed.Add("first_row", first_row)
                    dicDetailed.Add("current_row", current_row)
                    dicDetailed.Add("current_index", current_index)
                    dicDetailed.Add("xlWorkSheet", xlWorkSheet)
                    dicDetailed.Add("isDetailed", False)
                    'generateExcelGroup(xlWorkSheet, g.Item("grouped"), colName, dicHeader, current_row, current_index, originalCurrency, compare, True)
                    generateTabSeparatedDetailed(dicDetailed, withUnit)

                    current_row = dicDetailed.Item("current_row")
                    current_index = dicDetailed.Item("current_index")

                    current_row += 1
                    xlWorkSheet.Cells(current_row, 1).Value = "ENDING BALANCE : "
                    xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                    xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                    xlWorkSheet.Cells(current_row, 6).Value = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 2)
                    xlWorkSheet.Cells(current_row, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 2)
                    If Not NoRunningBalance.Checked Then
                        xlWorkSheet.Cells(current_row, 8).Value = String.Format("=FIXED(IMSUB(F{0},G{0}),2)", current_row)
                        ExcelRange(xlWorkSheet, current_row, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    End If
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, lastColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    If withComparison Then
                        If NoRunningBalance.Checked Then
                            xlWorkSheet.Cells(current_row, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 2)
                            xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 2)
                        Else
                            xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 2)
                            xlWorkSheet.Cells(current_row, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 2)
                            xlWorkSheet.Cells(current_row, 11).Value = String.Format("=FIXED(IMSUB(I{0},J{0}),2)", current_row)
                            ExcelRange(xlWorkSheet, current_row, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, lastColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub generateTabSeparatedDetailed(ByRef dic As Dictionary(Of String, Object), ByVal withUnit As Boolean)
        Dim withComparison As Boolean = dic.Item("withComparison")
        Dim colName As String = dic.Item("colName")
        Dim ds As DataSet = dic.Item("ds")
        Dim listAccount As List(Of Object) = dic.Item("listAccount")
        Dim first_row As Integer = dic.Item("first_row")
        Dim current_row As Integer = dic.Item("current_row")
        Dim myFirstRow As Integer = current_row
        Dim current_index As Integer = dic.Item("current_index")
        Dim xlWorkSheet As Excel.Worksheet = dic.Item("xlWorkSheet")
        Dim isDetailed As Boolean = dic.Item("isDetailed")
        Dim colorGray = System.Drawing.Color.FromArgb(211, 211, 211)
        Dim lastCol As Integer = 7
        If NoRunningBalance.Checked Then
            lastCol = 7
        Else
            lastCol = 8
        End If
        If withComparison Then
            If NoRunningBalance.Checked Then
                lastCol = 9
            Else
                lastCol = 11
            End If
        End If

        Dim fields = colName.Split(",")
        If Not isDetailed Then
            Dim field = fields(current_index)
            For Each item In listAccount
                xlWorkSheet.Cells(current_row, 1).Value = "'" & item.Item(field)
                'GroupHeader
                If field <> "general_code" Then
                    ExcelRange(xlWorkSheet, current_row, 1).Font.Bold = True
                    ExcelRange(xlWorkSheet, current_row, 1).Font.Underline = True
                    ExcelRange(xlWorkSheet, current_row, 1).IndentLevel = 2
                    current_row += 1
                Else
                    Dim drs = ds.Tables("Account").Select(String.Format("general_code = '{0}'", item.Item(field)))
                    If drs.Length > 0 Then
                        Dim general_name = drs(0)("general_name")
                        Dim unit_name As String = ifNull(drs(0)("book_unit_no_name"), "").ToString
                        xlWorkSheet.Cells(current_row, 2) = general_name
                        If withUnit Then
                            xlWorkSheet.Cells(current_row + 1, 1) = unit_name
                        End If
                        ExcelRange(xlWorkSheet, current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                        ExcelRange(xlWorkSheet, current_row, 1, current_row + 1, lastCol).Font.Bold = True
                        ExcelRange(xlWorkSheet, current_row, 1, current_row + 1, lastCol).Interior.Color = colorGray
                        current_row += 2
                    End If
                End If

                current_index += 1
                'current_row += 1
                dic.Item("withComparison") = withComparison
                dic.Item("colName") = colName
                dic.Item("ds") = ds
                If item.ContainsKey("grouped") Then
                    dic.Item("listAccount") = item.Item("grouped")
                    dic.Item("isDetailed") = False
                Else
                    dic.Item("listAccount") = item.Item("datas")
                    dic.Item("isDetailed") = True
                End If
                dic.Item("first_row") = first_row
                dic.Item("current_row") = current_row
                dic.Item("current_index") = current_index
                dic.Item("xlWorkSheet") = xlWorkSheet
                myFirstRow = current_row
                'generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), colName, dicHeader, current_row, current_index, originalCurrency, compare)
                generateTabSeparatedDetailed(dic, withUnit)
                current_row = dic.Item("current_row")
                current_index = dic.Item("current_index")
                current_index -= 1
                'GroupFooter
                If field <> "currency_name" Then
                    xlWorkSheet.Cells(current_row, 1).Value = "TOTAL DEBIT/CREDIT : "
                    ExcelRange(xlWorkSheet, current_row, 1).Font.Italic = True
                    ExcelRange(xlWorkSheet, current_row, 1).IndentLevel = 5
                    xlWorkSheet.Cells(current_row, 6).Value = String.Format("=SUBTOTAL(9,F{0}:F{1})", myFirstRow, (current_row - 1))
                    xlWorkSheet.Cells(current_row, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", myFirstRow, (current_row - 1))
                    If Not NoRunningBalance.Checked Then
                        xlWorkSheet.Cells(current_row, 8).Value = String.Format("=FIXED(IMSUB(F{0},G{0}),2)", (current_row))
                        ExcelRange(xlWorkSheet, current_row, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    End If
                    If withComparison Then
                        If NoRunningBalance.Checked Then
                            xlWorkSheet.Cells(current_row, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", myFirstRow, (current_row - 1))
                            xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", myFirstRow, (current_row - 1))
                        Else
                            xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", myFirstRow, (current_row - 1))
                            xlWorkSheet.Cells(current_row, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", myFirstRow, (current_row - 1))
                            xlWorkSheet.Cells(current_row, 11).Value = String.Format("=FIXED(IMSUB(I{0},J{0}),2)", (current_row))
                            ExcelRange(xlWorkSheet, current_row, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If
                    End If
                    ExcelRange(xlWorkSheet, current_row, 1,, lastCol).Font.Bold = True
                    ExcelRange(xlWorkSheet, current_row, 1,, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    ExcelRange(xlWorkSheet, current_row, 1,, lastCol).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                    ExcelRange(xlWorkSheet, current_row, 1,, lastCol).NumberFormat = "#,##0.00_);(#,##0.00)"
                    current_row += 1
                End If
            Next
        Else
            'Detail
            Dim balance As Decimal = 0
            Dim balance_based As Decimal = 0
            For Each i In listAccount
                Dim particulars As String = If(ifNull(i.Item("journal_id"), "8") = "8", "BEGINNING BALANCE", i.Item("description"))
                Dim debit As Decimal = CDec(ifNull(i.Item("debit"), 0))
                Dim credit As Decimal = CDec(ifNull(i.Item("credit"), 0))
                Dim debit_based As Decimal = CDec(ifNull(i.Item("debit_based"), 0))
                Dim credit_based As Decimal = CDec(ifNull(i.Item("credit_based"), 0))
                If debit > credit Then
                    balance += debit - credit
                    balance_based += debit_based - credit_based
                Else
                    balance -= credit - debit
                    balance_based -= credit_based - debit_based
                End If
                xlWorkSheet.Cells(current_row, 1) = i.Item("trans_date")
                xlWorkSheet.Cells(current_row, 2) = i.Item("trans_no")
                xlWorkSheet.Cells(current_row, 3) = i.Item("dn_ref")
                xlWorkSheet.Cells(current_row, 4) = particulars
                xlWorkSheet.Cells(current_row, 5) = i.Item("account_name")
                xlWorkSheet.Cells(current_row, 6) = debit
                xlWorkSheet.Cells(current_row, 7) = credit
                If Not NoRunningBalance.Checked Then
                    xlWorkSheet.Cells(current_row, 8) = balance
                End If
                If withComparison Then
                    If NoRunningBalance.Checked Then
                        xlWorkSheet.Cells(current_row, 8) = debit_based
                        xlWorkSheet.Cells(current_row, 9) = credit_based
                    Else
                        xlWorkSheet.Cells(current_row, 9) = debit_based
                        xlWorkSheet.Cells(current_row, 10) = credit_based
                        xlWorkSheet.Cells(current_row, 11) = balance_based
                    End If
                End If
                ExcelRange(xlWorkSheet, current_row, 1).NumberFormat = "mm/dd/yyyy"
                ExcelRange(xlWorkSheet, current_row, 6,, lastCol).NumberFormat = "#,##0.00_);(#,##0.00)"
                current_row += 1
            Next
            dic.Item("current_row") = current_row
        End If
    End Sub
    Private Sub generateReportExcel(ByVal listAccount As List(Of Object), ByVal colName As String, ByVal dateRange As String, ByVal dicHeader As Dictionary(Of String, String), Optional originalCurrency As Boolean = False, Optional compare As Boolean = False, Optional withUnit As Boolean = False)
        Dim ctr As Integer = 0
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        If xlWorkBook.Worksheets.Count = 3 Then
            xlWorkBook.Worksheets(1).Delete()
            xlWorkBook.Worksheets(1).Delete()
        End If
        For Each g In listAccount
            If ctr > 0 Then
                xlWorkBook.Worksheets().Add()
            End If

            ctr += 1

            xlWorkSheet = xlWorkBook.Worksheets(1)
            xlWorkSheet.Visible = True
            Dim sheetName As String = Regex.Replace(g.Item("book_name").ToString.Trim, "[^A-Za-z0-9]", "")
            If sheetName.Length >= 30 Then
                sheetName = sheetName.Substring(0, 30)
            End If
            xlWorkSheet.Name = sheetName

            xlWorkSheet.Cells(4, 1) = "Date"
            xlWorkSheet.Cells(4, 2) = "Transaction No."
            xlWorkSheet.Cells(4, 3) = "Collection Reference"
            xlWorkSheet.Cells(4, 4) = "Particulars"
            xlWorkSheet.Cells(4, 5) = "Account Title"

            xlWorkSheet.Cells(4, 1).ColumnWidth = 15
            xlWorkSheet.Cells(4, 2).ColumnWidth = 20
            xlWorkSheet.Cells(4, 3).ColumnWidth = 20
            xlWorkSheet.Cells(4, 4).ColumnWidth = 30
            xlWorkSheet.Cells(4, 5).ColumnWidth = 30
            xlWorkSheet.Cells(4, 6).ColumnWidth = 15
            xlWorkSheet.Cells(4, 7).ColumnWidth = 15
            If Not NoRunningBalance.Checked Then
                xlWorkSheet.Cells(4, 8).ColumnWidth = 15
            End If

            Dim lastColumn As Integer = 0
            If compare Then
                xlWorkSheet.Cells(4, 6) = "Debit in Original Amount"
                xlWorkSheet.Cells(4, 7) = "Credit in Original Amount"
                If NoRunningBalance.Checked Then
                    xlWorkSheet.Cells(4, 8) = "Debit in " & dicHeader.Item("currencyName")
                    xlWorkSheet.Cells(4, 9) = "Credit in " & dicHeader.Item("currencyName")
                    xlWorkSheet.Cells(4, 8).ColumnWidth = 15
                    xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                    lastColumn = 9
                Else
                    xlWorkSheet.Cells(4, 8) = "Balance in Original Amount"
                    xlWorkSheet.Cells(4, 9) = "Debit in " & dicHeader.Item("currencyName")
                    xlWorkSheet.Cells(4, 10) = "Credit in " & dicHeader.Item("currencyName")
                    xlWorkSheet.Cells(4, 11) = "Balance in " & dicHeader.Item("currencyName")
                    xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                    xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                    xlWorkSheet.Cells(4, 11).ColumnWidth = 15
                    lastColumn = 11
                End If
            Else
                xlWorkSheet.Cells(4, 6) = "Debit"
                xlWorkSheet.Cells(4, 7) = "Credit"
                If NoRunningBalance.Checked Then
                    lastColumn = 7
                Else
                    xlWorkSheet.Cells(4, 8) = "Balance"
                    lastColumn = 8
                End If
            End If

            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).WrapText = True
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, lastColumn)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, lastColumn)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, lastColumn)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastColumn)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastColumn)).Interior.Color = System.Drawing.Color.FromArgb(222, 235, 246)

            xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
            xlWorkSheet.Cells(2, 1) = "AR Subsidiary Ledger" & " - " & g.Item("book_name").ToString
            xlWorkSheet.Cells(3, 1) = dateRange

            Dim first_row As Integer = 5
            Dim current_row As Integer = 5
            Dim current_index As Integer = 1
            generateExcelGroup(xlWorkSheet, g.Item("grouped"), colName, dicHeader, current_row, current_index, originalCurrency, compare, True, withUnit)

            current_row += 1
            xlWorkSheet.Cells(current_row, 1).Value = "ENDING BALANCE : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Cells(current_row, 6).Value = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 2)
            xlWorkSheet.Cells(current_row, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 2)
            If Not NoRunningBalance.Checked Then
                xlWorkSheet.Cells(current_row, 8).Value = String.Format("=FIXED(IMSUB(F{0},G{0}),2)", current_row)
                ExcelRange(xlWorkSheet, current_row, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, lastColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            If compare Then
                If NoRunningBalance.Checked Then
                    xlWorkSheet.Cells(current_row, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 2)
                    xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 2)
                Else
                    xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 2)
                    xlWorkSheet.Cells(current_row, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 2)
                    xlWorkSheet.Cells(current_row, 11).Value = String.Format("=FIXED(IMSUB(I{0},J{0}),2)", current_row)
                    ExcelRange(xlWorkSheet, current_row, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                End If
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, lastColumn)).NumberFormat = "#,##0.00_);(#,##0.00)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            End If
        Next
    End Sub
    Private Sub generateExcelReport(ByVal listAccount As List(Of Object), ByVal colName As String, ByVal dateRange As String, ByVal dicHeader As Dictionary(Of String, String), Optional originalCurrency As Boolean = False, Optional compare As Boolean = False, Optional withUnit As Boolean = False)
        Dim lastCol As Integer = 7
        If compare Then
            If NoRunningBalance.Checked Then
                lastCol = 9
            Else
                lastCol = 11
            End If
        Else
            If NoRunningBalance.Checked Then
                lastCol = 7
            Else
                lastCol = 8
            End If
        End If
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        xlWorkBook = xlApp.Workbooks.Add
        'xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHeader.Item("templateName"))
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = "AR Subsidiary Ledger"
        xlWorkSheet.Cells(3, 1) = dateRange
        xlWorkSheet.Cells(4, 1) = "Date"
        xlWorkSheet.Cells(4, 2) = "Transaction No"
        xlWorkSheet.Cells(4, 3) = "Collection Reference"
        xlWorkSheet.Cells(4, 4) = "Particulars"
        xlWorkSheet.Cells(4, 5) = "Account Name"
        xlWorkSheet.Cells(4, 6) = "Debit"
        xlWorkSheet.Cells(4, 7) = "Credit"
        If Not NoRunningBalance.Checked Then
            xlWorkSheet.Cells(4, 8) = "Balance"
        End If
        xlWorkSheet.Cells(4, 1).ColumnWidth = 15
        xlWorkSheet.Cells(4, 2).ColumnWidth = 20
        xlWorkSheet.Cells(4, 3).ColumnWidth = 20
        xlWorkSheet.Cells(4, 4).ColumnWidth = 30
        xlWorkSheet.Cells(4, 5).ColumnWidth = 30
        xlWorkSheet.Cells(4, 6).ColumnWidth = 15
        xlWorkSheet.Cells(4, 7).ColumnWidth = 15
        xlWorkSheet.Cells(4, 8).ColumnWidth = 15

        If compare Then
            If NoRunningBalance.Checked Then
                xlWorkSheet.Cells(4, 8) = "Debit in " & dicHeader.Item("currencyName")
                xlWorkSheet.Cells(4, 9) = "Credit in " & dicHeader.Item("currencyName")
                xlWorkSheet.Cells(4, 9).ColumnWidth = 15
            Else
                xlWorkSheet.Cells(4, 9) = "Debit in " & dicHeader.Item("currencyName")
                xlWorkSheet.Cells(4, 10) = "Credit in " & dicHeader.Item("currencyName")
                xlWorkSheet.Cells(4, 11) = "Balance in " & dicHeader.Item("currencyName")
                xlWorkSheet.Cells(4, 9).ColumnWidth = 15
                xlWorkSheet.Cells(4, 10).ColumnWidth = 15
                xlWorkSheet.Cells(4, 11).ColumnWidth = 15
            End If
        End If
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastCol)).WrapText = True
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, lastCol)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, lastCol)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, lastCol)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastCol)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastCol)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(4, lastCol)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, lastCol)).Interior.Color = System.Drawing.Color.FromArgb(222, 235, 246)

        Dim first_row As Integer = 5
        Dim current_row As Integer = 5
        Dim current_index As Integer = 0
        generateExcelGroup(xlWorkSheet, listAccount, colName, dicHeader, current_row, current_index, originalCurrency, compare, withUnit)

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "ENDING BALANCE : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 6).Value = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 2)
        xlWorkSheet.Cells(current_row, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 2)
        If Not NoRunningBalance.Checked Then
            xlWorkSheet.Cells(current_row, 8).Value = String.Format("=FIXED(IMSUB(F{0},G{0}),2)", current_row)
            ExcelRange(xlWorkSheet, current_row, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 6), xlWorkSheet.Cells(current_row, lastCol)).NumberFormat = "#,##0.00_);(#,##0.00)"
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        If compare Then
            If NoRunningBalance.Checked Then
                xlWorkSheet.Cells(current_row, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 2)
                xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 2)
            Else
                xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 2)
                xlWorkSheet.Cells(current_row, 10).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 2)
                xlWorkSheet.Cells(current_row, 11).Value = String.Format("=FIXED(IMSUB(I{0},J{0}),2)", current_row)
                ExcelRange(xlWorkSheet, current_row, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End If
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, lastCol)).NumberFormat = "#,##0.00_);(#,##0.00)"
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        End If
    End Sub
    Private Sub generateExcelGroup(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal colName As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_row As Integer, ByRef current_index As Integer, Optional originalCurrency As Boolean = False, Optional compare As Boolean = False, Optional groupByBook As Boolean = False, Optional withUnit As Boolean = False)
        Dim fields = colName.Split(",")
        Dim field = fields(current_index)
        Dim lastCol As Integer = 7
        If compare Then
            If NoRunningBalance.Checked Then
                lastCol = 9
            Else
                lastCol = 11
            End If
        Else
            If NoRunningBalance.Checked Then
                lastCol = 7
            Else
                lastCol = 8
            End If
        End If
        current_index += 1
        For Each item In listAccount
            Dim dicItem = Nothing
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field
                    Case "currency_name"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), colName, dicHeader, current_row, current_index, originalCurrency, compare, groupByBook, withUnit)
                        current_index -= 1
                End Select
            Else

                current_row += 1
                Dim general = ds.Tables("Account").Select(String.Format("general_code = '{0}'", dicItem.Item("general_code")))
                xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(field)
                xlWorkSheet.Cells(current_row, 1).HorizontalAlignment = Excel.Constants.xlLeft
                If general.Length > 0 Then
                    xlWorkSheet.Cells(current_row, 2).Value = general(0).Item("general_name").ToString
                End If
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 7)).Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                If compare Then
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 10)).Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                End If

                current_row += 1
                Dim first_rows As Integer = current_row
                Dim dics = Nothing
                Dim listDatas = CType(dicItem.Item("datas"), List(Of Object))
                For Each da In listDatas

                    If TypeOf da Is Dictionary(Of String, String) Then
                        dics = CType(da, Dictionary(Of String, String))
                    Else
                        dics = CType(da, Dictionary(Of String, Object))
                    End If
                Next
                If withUnit Then
                    xlWorkSheet.Cells(current_row, 1) = dics.Item("book_unit_no_code")
                End If
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Interior.Color = System.Drawing.Color.FromArgb(211, 211, 211)
                current_row += 1
                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                Dim balance As Decimal = 0
                Dim balance_based As Decimal = 0

                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If
                    Dim particulars = If(dic.Item("journal_id").ToString = "8", "BEGINNING BALANCE", dic.Item("description"))
                    'Dim balance As Decimal = dic.Item("debit") - dic.Item("credit")
                    'Dim balance_based As Decimal = dic.Item("debit_based") - dic.Item("credit_based")
                    Dim debit As Decimal = dic.Item("debit")
                    Dim credit As Decimal = dic.Item("credit")
                    Dim debit_based As Decimal = dic.Item("debit_based")
                    Dim credit_based As Decimal = dic.Item("credit_based")
                    If debit > credit Then
                        balance += debit - credit
                        balance_based += debit_based - credit_based
                    Else
                        balance -= credit - debit
                        balance_based -= credit_based - debit_based
                    End If
                    xlWorkSheet.Cells(current_row, 1) = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 1).NumberFormat = "mm/dd/yyyy"
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("dn_ref")
                    xlWorkSheet.Cells(current_row, 4) = particulars
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("account_name")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("debit")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("credit")
                    If Not NoRunningBalance.Checked Then
                        xlWorkSheet.Cells(current_row, 8) = balance
                    End If
                    If groupByBook Then
                        xlWorkSheet.Cells(current_row, 6).NumberFormat = "#,##0.00_);(#,##0.00)"
                        xlWorkSheet.Cells(current_row, 7).NumberFormat = "#,##0.00_);(#,##0.00)"
                        If Not NoRunningBalance.Checked Then
                            xlWorkSheet.Cells(current_row, 8).NumberFormat = "#,##0.00_);(#,##0.00)"
                        End If
                    End If
                    If compare Then
                        If NoRunningBalance.Checked Then
                            xlWorkSheet.Cells(current_row, 8) = dic.Item("debit_based")
                            xlWorkSheet.Cells(current_row, 9) = dic.Item("credit_based")
                        Else
                            xlWorkSheet.Cells(current_row, 9) = dic.Item("debit_based")
                            xlWorkSheet.Cells(current_row, 10) = dic.Item("credit_based")
                            xlWorkSheet.Cells(current_row, 11) = balance_based
                        End If
                        If groupByBook Then
                            If NoRunningBalance.Checked Then
                                xlWorkSheet.Cells(current_row, 8).NumberFormat = "#,##0.00_);(#,##0.00)"
                                xlWorkSheet.Cells(current_row, 9).NumberFormat = "#,##0.00_);(#,##0.00)"
                            Else
                                xlWorkSheet.Cells(current_row, 9).NumberFormat = "#,##0.00_);(#,##0.00)"
                                xlWorkSheet.Cells(current_row, 10).NumberFormat = "#,##0.00_);(#,##0.00)"
                                xlWorkSheet.Cells(current_row, 11).NumberFormat = "#,##0.00_);(#,##0.00)"
                            End If
                        End If
                    End If
                    current_row += 1
                Next
                xlWorkSheet.Cells(current_row, 1).Value = "TOTAL DEBIT/CREDIT : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 6).Value = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, (current_row - 1))
                xlWorkSheet.Cells(current_row, 7).Value = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, (current_row - 1))
                If Not NoRunningBalance.Checked Then
                    xlWorkSheet.Cells(current_row, 8).Value = String.Format("=FIXED(IMSUB(F{0},G{0}),2)", (current_row))
                    ExcelRange(xlWorkSheet, current_row, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                End If
                If groupByBook Then
                    xlWorkSheet.Cells(current_row, 6).NumberFormat = "#,##0.00_);(#,##0.00)"
                    xlWorkSheet.Cells(current_row, 7).NumberFormat = "#,##0.00_);(#,##0.00)"
                    If Not NoRunningBalance.Checked Then
                        xlWorkSheet.Cells(current_row, 8).NumberFormat = "#,##0.00_);(#,##0.00)"
                    End If
                End If
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                If compare Then
                    If NoRunningBalance.Checked Then
                        xlWorkSheet.Cells(current_row, 8).Value = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, (current_row - 1))
                        xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, (current_row - 1))
                    Else
                        xlWorkSheet.Cells(current_row, 9).Value = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, (current_row - 1))
                        xlWorkSheet.Cells(current_row, 10).Value = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, (current_row - 1))
                        xlWorkSheet.Cells(current_row, 11).Value = String.Format("=FIXED(IMSUB(J{0},K{0}),2)", (current_row))
                        ExcelRange(xlWorkSheet, current_row, 11).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End If
                    If groupByBook Then
                        If NoRunningBalance.Checked Then
                            xlWorkSheet.Cells(current_row, 8).NumberFormat = "#,##0.00_);(#,##0.00)"
                            xlWorkSheet.Cells(current_row, 9).NumberFormat = "#,##0.00_);(#,##0.00)"
                        Else
                            xlWorkSheet.Cells(current_row, 9).NumberFormat = "#,##0.00_);(#,##0.00)"
                            xlWorkSheet.Cells(current_row, 10).NumberFormat = "#,##0.00_);(#,##0.00)"
                            xlWorkSheet.Cells(current_row, 11).NumberFormat = "#,##0.00_);(#,##0.00)"
                        End If
                    End If
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Font.Bold = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastCol)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                End If
                current_row += 1
            End If
        Next
    End Sub
    Private Sub rdo_currency_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_currency_1.CheckedChanged, rdo_currency_2.CheckedChanged
        Dim currency As String = getRdoValue(currency_filter)
        'txt_currency_id.Text = ""
        'txt_currency_id.Value = ""
        'lbl_currency_name.Text = "Currency Name"
        withComparison.Enabled = False
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
    Private Sub arsubsidiary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.Value = New Date(Today.Year, 1, 1)
        txt_date_to.Value = Today
        txt_date_from.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)

        Dim sql As String = String.Format("SELECT book_id,book_code,book_name " & vbNewLine &
            "FROM lib_erp_book " & vbNewLine &
            "WHERE company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id").ToString)
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables("lib_erp_book").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("lib_erp_book").ImportRow(row)
        Next
        dgBooks.AutoGenerateColumns = False
        dgBooks.DataSource = ds.Tables("lib_erp_book")
        If My.Settings._enableUnitNo Then
            dgBookUnits.Enabled = True
            If My.Settings._enableBookUnit Then
                loadBookUnit(Nothing)
            Else
                loadProjectUnit("")
            End If
        Else
            dgBookUnits.Enabled = False
        End If
    End Sub

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
    End Sub

    Private Sub loadBookUnit(ByVal id() As String)
        dgBookUnits.AutoGenerateColumns = False
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
        dgBookUnits.DataSource = bsBookUnit
    End Sub
    Private Sub loadProjectUnit(ByVal id As String)
        dgBookUnits.AutoGenerateColumns = False
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
        dgBookUnits.DataSource = bsBookUnit
    End Sub
    Private Sub checkAllBook_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBooks.CheckedChanged


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

    Private Sub dgBooks_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgBooks.CellValueChanged
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

    Private Sub dgBooks_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgBooks.CurrentCellDirtyStateChanged
        If dgBooks.CurrentCell.ColumnIndex = 0 Then
            If dgBooks.IsCurrentCellDirty Then
                dgBooks.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub

    Private Sub checkAllBookUnits_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBookUnits.CheckedChanged
        For Each dr As DataGridViewRow In dgBookUnits.Rows
            dr.Cells("sel2").Value = checkAllBookUnits.Checked
        Next
    End Sub
End Class