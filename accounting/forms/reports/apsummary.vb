Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class apsummary
    Private module_code As String = "ACC01004"
    Dim ds As New subsidiaryset
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub toDate_CheckedChanged(sender As Object, e As EventArgs) Handles toDate.CheckedChanged
        Dim tDate As Boolean = toDate.Checked
        If tDate Then
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
        Dim account As String = getRdoValue(account_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim date_from As String = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to As String = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim account_id As String = txt_account_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value
        Dim wComparison As Boolean = withComparison.Checked
        Dim wProjDept As Boolean = withProjectDepartment.Checked
        Dim tDate As Boolean = toDate.Checked
        Dim str_account_id As String = ""

        'validation
        If Not tDate Then
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
                    "WHERE  b.validation = '3' AND a.user_id = '{0}' AND c.module_code = '{1}'", main.user_id, module_code)
                Dim dt_account_id As DataTable = FsQuery(sql_account_id)
                str_account_id = dt_account_id.Rows(0).Item("account_id").ToString
                If str_account_id = "" Then
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

        'query
        Dim sql As String = String.Format("SELECT e.account_id,a.trans_id,a.trans_no,a.trans_date,a.description " &
                                          ",SUM(b.debit) AS debit,SUM(b.credit) AS credit,SUM(b.debit_based) AS debit_based,SUM(b.credit_based) AS credit_based,(b.exchange_rate / b.based_rate) AS exchange_rate " &
                                          ",b.currency_id,i.currency_name,i.currency_code " &
                                          ",b.general_id,g.general_name,g.general_code " &
                                          ",a.journal_id,j.journal_name,j.journal_code " &
                                          ",b.project_id,k.project_name,k.project_code " &
                                          ",b.department_id,l.department_name,l.department_code " &
                                          ",d.trans_no AS dn_ref " &
                                          ",e.account_code,e.account_name " &
                                          "FROM {1}.trans_header a " &
                                          "LEFT JOIN (" &
                                            "SELECT a.* FROM {1}.trans_jbooks a " &
                                            "LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id " &
                                            "WHERE b.validation = 3 " &
                                          ") b ON b.trans_id = a.trans_id " &
                                          "LEFT JOIN {1}.trans_jbooks c ON c.jbooks_id = b.ref_jbooks_id " &
                                          "LEFT JOIN {1}.trans_header d ON d.trans_id = c.trans_id " &
                                          "LEFT JOIN {0}.lib_erp_chart e ON e.account_id = b.account_id " &
                                          "LEFT JOIN (SELECT a.* FROM {0}.lib_erp_chart a WHERE a.validation = 2) f ON f.account_id = b.account_id " &
                                          "LEFT JOIN {0}.lib_acc_chart_multiple m ON m.account_id = f.account_id " &
                                          "LEFT JOIN {0}.lib_erp_general g ON g.general_id = b.general_id " &
                                          "LEFT JOIN {0}.lib_acc_general_multiple h ON h.general_id = g.general_id " &
                                          "LEFT JOIN {0}.lib_erp_currency i ON i.currency_id = b.currency_id " &
                                          "LEFT JOIN {0}.lib_erp_journal j ON j.journal_id = a.journal_id " &
                                          "LEFT JOIN {0}.lib_erp_project k ON k.project_id = b.project_id " &
                                          "LEFT JOIN {0}.lib_erp_department l ON l.department_id = b.department_id " & vbNewLine &
                                          "LEFT JOIN {0}.lib_erp_book n ON n.book_id = a.book_id " & vbNewLine &
                                          "", _serverDBFS, _serverDBMain)

        If Not tDate Then
            sql &= String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)
        Else
            sql &= String.Format(" WHERE a.trans_date <= '{0}' ", date_to)
        End If

        Select Case account
            Case "1"
            Case "2"
                sql &= String.Format(" AND e.account_id IN ({0}) ", str_account_id)
            Case "3"
                sql &= String.Format(" AND e.account_id LIKE {0} ", account_id)
        End Select

        If currency_id <> "" Then
            sql &= String.Format(" AND b.currency_id = {0} ", currency_id)
        End If

        If project_id <> "" Then
            sql &= String.Format(" AND b.project_id = {0} ", project_id)
        End If

        If department_id <> "" Then
            sql &= String.Format(" AND b.department_id = {0} ", department_id)
        End If

        sql &= String.Format(" AND e.validation = 3 AND n.company_id = '{0}' ", main.Sys_Default.Rows(0).Item("company_id").ToString)
        sql &= String.Format(" GROUP BY e.account_id,b.general_id ")

        If currency = "2" Then
            sql &= String.Format(" ,b.currency_id ")
        End If

        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
                                                  "FROM {1}.sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                  "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

        'Dim dt As DataTable = FsQuery(sql)
        Dim col As New List(Of KeyValuePair(Of String, String))
        col.Add(New KeyValuePair(Of String, String)("@dbMain", _serverDBMain))
        col.Add(New KeyValuePair(Of String, String)("@dbFS", _serverDBFS))
        col.Add(New KeyValuePair(Of String, String)("@validation", "AP"))
        col.Add(New KeyValuePair(Of String, String)("@currency_id", currency_id))
        col.Add(New KeyValuePair(Of String, String)("@account_id", account_id))
        col.Add(New KeyValuePair(Of String, String)("@book_id", ""))
        col.Add(New KeyValuePair(Of String, String)("@project_id", project_id))
        col.Add(New KeyValuePair(Of String, String)("@department_id", department_id))
        col.Add(New KeyValuePair(Of String, String)("@date_from", date_from))
        col.Add(New KeyValuePair(Of String, String)("@date_to", date_to))
        col.Add(New KeyValuePair(Of String, String)("@range_type", If(toDate.Checked, "2", "1")))
        col.Add(New KeyValuePair(Of String, String)("@w_currency", If(currency = "2", "1", "0")))
        col.Add(New KeyValuePair(Of String, String)("@w_project_department", If(wProjDept, "1", "0")))
        col.Add(New KeyValuePair(Of String, String)("@group_by_book", "0"))
        Dim dt As DataTable = ExecuteWithParameter("get_account_summary", ConnectionStringFS, CommandType.StoredProcedure, col)

        Dim dt_company As DataTable = FsQuery(sql_company)

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

        If sender.name = "btnPrint" Then
            If wComparison And currency = "2" Then
                Dim rep As New report_apsummary_print
                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                If toDate.Checked Then
                    rep.range.Text = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                Else
                    rep.range.Text = txt_date_from.Value.ToString("MMMM dd, yyyy") & " - " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                End If
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                Dim rep As New report_apsummary_print_1
                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                If toDate.Checked Then
                    rep.range.Text = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                Else
                    rep.range.Text = txt_date_from.Value.ToString("MMMM dd, yyyy") & " - " & txt_date_to.Value.ToString("MMMM dd, yyyy")
                End If
                If currency = "1" Then
                    If currency = "1" And currency_id = "" Then
                        rep.GroupHeader1.Visible = False
                        rep.GroupFooter1.Visible = False
                    Else
                        rep.ReportFooter.Visible = False
                    End If
                Else
                    If Not wComparison Then
                        rep.ReportFooter.Visible = False
                    End If
                End If
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            End If
        Else
            Try
                lblLoad.Visible = True
                Dim dicHeader As New Dictionary(Of String, String)
                dicHeader.Add("templateName", "")
                dicHeader.Add("companyName", "")
                dicHeader.Add("currenyName", "")
                Dim colName As String = "currency_name"
                Dim listAccount = Nothing
                If dt_company.Rows.Count > 0 Then
                    dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
                    dicHeader.Item("currencyName") = dt_company.Rows(0).Item("currency_name").ToString
                End If
                If currency = "2" Then
                    listAccount = groupDataTableToList(ds.Tables("Account"), colName)
                    If wComparison Then
                        dicHeader.Item("templateName") = "arapsummary.xlt"
                    Else
                        dicHeader.Item("templateName") = "arapsummary2.xlt"
                    End If
                    generateExcelReport(listAccount, colName, dicHeader, ds.Tables("Account"), True, wComparison)
                Else
                    Dim groupByCurrency As Boolean = False
                    If currency_id <> "" Then
                        groupByCurrency = True
                        listAccount = groupDataTableToList(ds.Tables("Account"), colName)
                    End If
                    dicHeader.Item("templateName") = "arapsummary2.xlt"
                    generateExcelReport(listAccount, colName, dicHeader, ds.Tables("Account"), groupByCurrency, False)
                    'MsgBox("Data Succesfully Load")
                End If
                MsgBox("Report Done")
                lblLoad.Visible = False
            Catch ex As Exception
                lblLoad.Visible = False
                MsgBox(String.Format("Error Occured : {0}", ex.Message))
                MyDebugging.AddText(ex.Message)
            End Try
        End If
    End Sub
    Private Sub generateExcelReport(ByVal listAccount As List(Of Object), ByVal colName As String, ByVal dicHeader As Dictionary(Of String, String), ByVal dt As DataTable, Optional originalCurrency As Boolean = False, Optional compare As Boolean = False)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHeader.Item("templateName"))
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = "AP Outstanding Balance"
        xlWorkSheet.Cells(3, 1) = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")

        If compare Then
            xlWorkSheet.Cells(4, 4) = "Oustanding Balance in " & dicHeader.Item("currencyName")
        End If

        Dim first_row As Integer = 5
        Dim current_row As Integer = 5
        Dim current_index As Integer = 0
        generateExcelGroup(xlWorkSheet, listAccount, colName, dt, current_row, current_index, originalCurrency, compare)
    End Sub
    Private Sub generateExcelGroup(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal colName As String, ByVal dt As DataTable, ByRef current_row As Integer, ByRef current_index As Integer, Optional originalCurrency As Boolean = False, Optional compare As Boolean = False)
        If originalCurrency Then
            Dim grandTotalFirstRow As Integer = current_row
            For Each item In listAccount
                Dim dicItem = Nothing
                If TypeOf dicItem Is Dictionary(Of String, String) Then
                    dicItem = CType(item, Dictionary(Of String, String))
                Else
                    dicItem = CType(item, Dictionary(Of String, Object))
                End If
                Dim endRange As Integer = 3
                If compare Then
                    endRange = 4
                End If
                xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(colName)
                xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                current_row += 1
                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If
                    xlWorkSheet.Cells(current_row, 1).Value = dic.Item("general_code")
                    xlWorkSheet.Cells(current_row, 2).Value = dic.Item("general_name")
                    xlWorkSheet.Cells(current_row, 3).Value = dic.Item("credit") - dic.Item("debit")
                    If compare Then
                        xlWorkSheet.Cells(current_row, 4).Value = dic.Item("credit_based") - dic.Item("debit_based")
                    End If
                    current_row += 1
                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem.Item(colName) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 3).Value = String.Format("=SUBTOTAL(9,C{0}:C{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                If compare Then
                    xlWorkSheet.Cells(current_row, 4).Value = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Font.Bold = True
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                End If
                current_row += 1
            Next
            current_row += 1
            xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            xlWorkSheet.Cells(current_row, 3).Value = String.Format("=SUBTOTAL(9,C{0}:C{1})", grandTotalFirstRow, current_row - 1)
            If compare Then
                xlWorkSheet.Cells(current_row, 4).Value = String.Format("=SUBTOTAL(9,D{0}:D{1})", grandTotalFirstRow, current_row - 1)
            End If
        Else
            Dim grandTotalFirstRow As Integer = current_row
            For Each row As DataRow In dt.Rows
                xlWorkSheet.Cells(current_row, 1).Value = row.Item("general_code")
                xlWorkSheet.Cells(current_row, 2).Value = row.Item("general_name")
                xlWorkSheet.Cells(current_row, 3).Value = row.Item("credit") - row.Item("debit")
                current_row += 1
            Next
            current_row += 1
            xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 3)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            xlWorkSheet.Cells(current_row, 3).Value = String.Format("=SUBTOTAL(9,C{0}:C{1})", grandTotalFirstRow, current_row - 1)
        End If
    End Sub
    Private Sub rdo_currency_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_currency_1.CheckedChanged, rdo_currency_2.CheckedChanged
        Dim currency As String = getRdoValue(currency_filter)
        txt_currency_id.Text = ""
        txt_currency_id.Value = ""
        lbl_currency_name.Text = "Currency Name"
        withComparison.Enabled = False
        If currency = "2" Then
            withComparison.Enabled = True
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        If Not toDate.Checked Then
            If txt_date_to.Value < txt_date_from.Value Then
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
    Private Sub apsummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.Value = New Date(Today.Year, 1, 1)
        txt_date_to.Value = Today
        txt_date_from.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
    End Sub

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
    End Sub
End Class