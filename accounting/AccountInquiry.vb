Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports System.Text
Public Class AccountInquiry
    Private module_code As String = "ACC01013"
    Public Property account_id As String = ""
    Private Sub AccountInquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Rdo_button4.Checked = True
        Rdo_button7.Checked = False
        If rdo2.Checked = True Then
            txt_date_from.Enabled = False
        Else
            txt_date_from.Enabled = True
        End If

        Rdo_button6.Checked = True
        MyCheckBox1.Enabled = True
        withComparison.Enabled = False
        txt_currency_id.Enabled = True
        Dim imonth = txt_date_from.MinDate.Month
        Dim iday = txt_date_from.MinDate.Day
        txt_date_from.Value = New Date(Today.Year, imonth, iday)

        If IsNothing(dgMain.DataSource) = False Then
            dgMain.DataSource = Nothing
        Else
            dgMain.Rows.Clear()
        End If
        InitializeData()
    End Sub
    Private Sub InitializeData()
        Dim general As String = getRdoValue(general_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim project_department As String = getRdoValue(project_department_filter)
        Dim journal As String = getRdoValue(journal_filter)
        Dim book As String = getRdoValue(book_filter)
        Dim allocation As String = getRdoValue(allocation_filter)

        Dim range As String = getRdoValue(range_filter)
        Dim date_from As DateTime = txt_date_from.Value
        Dim date_to As DateTime = txt_date_to.Value

        Dim general_id As String = txt_general_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value
        Dim allocation_id As String = txt_allocation_id.Value
        Dim journal_id As String = txt_journal_id.Value
        Dim book_id As String = txt_book_id.Value


        Dim str_general_id As String = ""

        Select Case general
            Case "1"
            Case "2"

                Dim sql_multiple_general As String = String.Format("SELECT GROUP_CONCAT(a.general_id) AS general_id " &
                    "FROM lib_acc_general_multiple a " &
                    "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
                    "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
                Dim dt_multiple_general As DataTable = FsQuery(sql_multiple_general)
                If dt_multiple_general.Rows.Count > 0 Then
                    str_general_id = dt_multiple_general.Rows(0).Item("general_id").ToString
                End If
            Case "3"
                If general_id = Nothing Then
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
        Dim col = New List(Of KeyValuePair(Of String, String))
        col.Add(New KeyValuePair(Of String, String)("@report_type", "1"))
        col.Add(New KeyValuePair(Of String, String)("@dbName", ""))
        col.Add(New KeyValuePair(Of String, String)("@account_id", account_id))
        col.Add(New KeyValuePair(Of String, String)("@general_id", If(str_general_id <> "", str_general_id, general_id)))
        col.Add(New KeyValuePair(Of String, String)("@range_type", range))
        col.Add(New KeyValuePair(Of String, String)("@date_from", date_from.ToString("yyyy-MM-dd")))
        col.Add(New KeyValuePair(Of String, String)("@date_to", date_to.ToString("yyyy-MM-dd")))
        col.Add(New KeyValuePair(Of String, String)("@journal_id", journal_id))
        col.Add(New KeyValuePair(Of String, String)("@book_id", book_id))
        col.Add(New KeyValuePair(Of String, String)("@currency_id", currency_id))
        col.Add(New KeyValuePair(Of String, String)("@book_unit_id", currency_id))
        Dim dt As DataTable = ExecuteWithParameter("get_lib_erp_chart_drilled_down", ConnectionStringFS, CommandType.StoredProcedure, col)

        dsko.Tables("Account").Clear()
        For Each row As DataRow In dt.Rows
            dsko.Tables("Account").ImportRow(row)
        Next
        dgMain.DataSource = dt
    End Sub
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


    Private Sub Rdo_button2_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button2.CheckedChanged
        btn_browse_general.Enabled = False
        txt_general_id.Text = ""
        txt_general_id.Enabled = False
    End Sub

    Private Sub Rdo_button1_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button1.CheckedChanged
        btn_browse_general.Enabled = True
        txt_general_id.Enabled = False
    End Sub

    Private Sub Rdo_button3_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button3.CheckedChanged
        txt_general_id.Enabled = True
        btn_browse_general.Enabled = False
    End Sub

    Private Sub Rdo_button6_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button6.CheckedChanged
        withComparison.Enabled = False
        txt_currency_id.Text = Nothing
    End Sub

    Private Sub Rdo_button5_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button5.CheckedChanged
        withComparison.Enabled = True
        txt_currency_id.Text = Nothing
    End Sub

    Private Sub MyCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MyCheckBox1.CheckedChanged
        If MyCheckBox1.Checked = True Then
            txt_project_id.Enabled = True
            txt_department_id.Enabled = True
        ElseIf MyCheckBox1.Checked = False Then
            txt_project_id.Enabled = False
            txt_department_id.Enabled = False
        End If

    End Sub

    Private Sub Rdo_button4_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button4.CheckedChanged


        txt_journal_id.Enabled = False
        txt_journal_id.Text = Nothing
        txt_journal_id.Value = Nothing


    End Sub

    Private Sub Rdo_button7_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button7.CheckedChanged
        txt_journal_id.Enabled = True
    End Sub

    Private Sub Rdo_button8_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button8.CheckedChanged

        txt_book_id.Enabled = False
        txt_book_id.Text = Nothing
        txt_book_id.Value = Nothing
    End Sub

    Private Sub Rdo_button9_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button9.CheckedChanged
        txt_book_id.Enabled = True
    End Sub

    Private Sub Rdo_button13_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button13.CheckedChanged
        txt_allocation_id.Enabled = False
    End Sub

    Private Sub Rdo_button12_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button12.CheckedChanged
        txt_allocation_id.Enabled = True
    End Sub

    Private Sub txt_general_id_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        If Rdo_button2.Checked = True Then
            txt_general_id.Enabled = False
            txt_general_id.Text = ""
        Else
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
                End If
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
        'End If
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
            End If
        End If

    End Sub

    Private Sub txt_journal_id_Leave(sender As Object, e As EventArgs) Handles txt_journal_id.Leave
        If Rdo_button4.Checked = True Then
            txt_journal_id.Enabled = False
            txt_journal_id.Text = ""

        Else
            Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_journal ")
            If data.Rows.Count = 0 Then
                MsgBox("No record found.")
            Else
                Dim dr As DataRow = Nothing
                If data.Rows.Count = 1 Then
                    dr = data.Rows(0)
                Else
                    Dim dra() As DataRow = data.Select("journal_code like '" & txt_journal_id.Text.ToString.Replace("'", "''") & "'")
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
                    txt_journal_id.RowData = dr
                    txt_journal_id.Value = dr("journal_id")
                    txt_journal_id.Text = dr("journal_code")
                End If
            End If

        End If

    End Sub


    Private Sub txt_book_id_Leave(sender As Object, e As EventArgs) Handles txt_book_id.Leave
        If Rdo_button8.Checked = True Then
            txt_book_id.Enabled = False
            txt_book_id.Text = ""
        Else
            Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_book ")
            If data.Rows.Count = 0 Then
                MsgBox("No record found.")
            Else
                Dim dr As DataRow = Nothing
                If data.Rows.Count = 1 Then
                    dr = data.Rows(0)
                Else
                    Dim dra() As DataRow = data.Select("book_code like '" & txt_book_id.Text.ToString.Replace("'", "''") & "'")
                    If dra.Count > 0 Then
                        dr = dra(0)
                    Else
                        browse.dt = data
                        browse.format("Book Code,Book Name", "book_code,book_name", "100,200")
                        If browse.ShowDialog() = DialogResult.OK Then
                            If browse.dgview.SelectedRows.Count > 0 Then
                                dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                            End If
                        End If
                    End If
                End If
                If Not dr Is Nothing Then
                    txt_book_id.RowData = dr
                    txt_book_id.Value = dr("book_id")
                    txt_book_id.Text = dr("book_code")
                End If
            End If
        End If

    End Sub

    Private Sub btn_browse_general_Click(sender As Object, e As EventArgs) Handles btn_browse_general.Click
        multiplegeneralsetup.ModuleCode = module_code
        multiplegeneralsetup.ShowDialog()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        InitializeData()
    End Sub

    Private Sub reportbooks(ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable)
        Dim sheetCtr As Integer = 0
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim lstTotal As New List(Of Integer)

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        If xlWorkBook.Worksheets.Count = 3 Then
            xlWorkBook.Worksheets(1).Delete()
            xlWorkBook.Worksheets(1).Delete()
        End If
        For Each journal In listAccount
            If sheetCtr > 0 Then
                xlWorkBook.Worksheets.Add()
            End If
            xlWorkSheet = xlWorkBook.Worksheets(1)
            xlWorkSheet.Name = journal.item("journal_name").ToString.Replace("/", "_")
            sheetCtr += 1
            excelBooks(lstTotal, journal.item("grouped"), dicHeader, strCol, ds.Tables("printbooks_report"), xlWorkSheet, journal.item("journal_name"))
        Next
    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        Dim range As String = getRdoValue(range_filter)
        Dim general As String = getRdoValue(general_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim project_department As String = getRdoValue(project_department_filter)
        Dim journal As String = getRdoValue(journal_filter)
        Dim book As String = getRdoValue(book_filter)
        Dim allocation As String = getRdoValue(allocation_filter)
        Dim date_from As DateTime = txt_date_from.Value
        Dim date_to As DateTime = txt_date_to.Value
        Dim general_id As String = txt_general_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value
        Dim allocation_id As String = txt_allocation_id.Value
        Dim journal_id As String = txt_journal_id.Value
        Dim book_id As String = txt_book_id.Value
        Dim wComparison As Boolean = withComparison.Checked
        Dim str_general_id As String = ""

        Select Case general
            Case "1"
            Case "2"
                Dim sql_multiple_general As String = String.Format("SELECT GROUP_CONCAT(a.general_id) AS general_id " &
                    "FROM lib_acc_general_multiple a " &
                    "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
                    "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
                Dim dt_multiple_general As DataTable = FsQuery(sql_multiple_general)
                If dt_multiple_general.Rows.Count > 0 Then
                    str_general_id = dt_multiple_general.Rows(0).Item("general_id").ToString
                End If
            Case "3"
                If general_id = "" Then
                    MsgBox("Select General Library First")
                    txt_general_id.Focus()
                    Exit Sub
                End If
        End Select



        Dim _range As String = ""
        Select Case range
            Case "1"
                _range = String.Format("From {0} to {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            Case "2"
                _range = String.Format("As of {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
            Case "3"
                _range = String.Format("Range w/ Beginning Balance : {0} - {1}", txt_date_from.Value.ToString("MMMM dd, yyyy"), txt_date_to.Value.ToString("MMMM dd, yyyy"))
        End Select


        If sender.Name.ToString() = "btnPrint" Then

            If wComparison And currency = "2" Then
                Dim rep As New accountanalysisReport1()
                Dim sql_kampani As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
                                                      "FROM {1}.sys_default a " &
                                                      "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                      "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)
                Dim dt_kampani As DataTable = FsQuery(sql_kampani)
                For Each dr As DataRow In dt_kampani.Rows
                    dsko.Tables("Company").ImportRow(dr)
                Next
                rep.DataSource = dsko
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.range.Text = _range
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()

            ElseIf currency = "1" Then

                Dim rep As New accountanalysisReport()
                Dim sql_kampani As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
                                                      "FROM {1}.sys_default a " &
                                                      "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                      "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)
                Dim dt_kampani As DataTable = FsQuery(sql_kampani)
                For Each dr As DataRow In dt_kampani.Rows
                    dsko.Tables("Company").ImportRow(dr)
                Next
                rep.DataSource = dsko
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.range.Text = _range
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()

            End If





        Else


            Dim bookName As String = ""

            Dim col = New List(Of KeyValuePair(Of String, String))
            col.Add(New KeyValuePair(Of String, String)("@report_type", "1"))
            col.Add(New KeyValuePair(Of String, String)("@dbName", ""))
            col.Add(New KeyValuePair(Of String, String)("@account_id", account_id))
            col.Add(New KeyValuePair(Of String, String)("@general_id", If(str_general_id <> "", str_general_id, general_id)))
            col.Add(New KeyValuePair(Of String, String)("@range_type", range))
            col.Add(New KeyValuePair(Of String, String)("@date_from", date_from.ToString("yyyy-MM-dd")))
            col.Add(New KeyValuePair(Of String, String)("@date_to", date_to.ToString("yyyy-MM-dd")))
            col.Add(New KeyValuePair(Of String, String)("@currency_id", currency_id))
            col.Add(New KeyValuePair(Of String, String)("@journal_id", journal_id))
            col.Add(New KeyValuePair(Of String, String)("@book_id", book_id))

            Dim dt As DataTable = ExecuteWithParameter("get_lib_erp_chart_drilled_down", ConnectionStringFS, CommandType.StoredProcedure, col)

            '    Dim dt As DataTable = Query(sql)
            Dim ds As New printbooks_set
            Dim sql_company As String = String.Format("SELECT a.* FROM lib_erp_company a")
            Dim dt_company As DataTable = FsQuery(sql_company)
            ds.Clear()
            For Each dr As DataRow In dt.Rows
                ds.Tables("printbooks_report").ImportRow(dr)
            Next

            Dim dicHeader As New Dictionary(Of String, String)
            dicHeader.Add("companyName", "")
            dicHeader.Add("book_name", If(bookName <> "", bookName.Substring(1), ""))
            If dt_company.Rows.Count > 0 Then
                dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
            End If
            Dim strGrouping As String = "journal_name,trans_no"
            Dim listAccount = groupDataTableToList(ds.Tables("printbooks_report"), strGrouping)
            reportbooks(listAccount, dicHeader, strGrouping, ds.Tables("printbooks_report"))

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
        _printoption.TabSep.Visible = False
        _printoption.Rdo_button1.Location = New Drawing.Point(50, 20)
        _printoption.Rdo_button2.Location = New Drawing.Point(106, 20)
        _printoption.ShowDialog()
        If _printoption.DialogResult = Windows.Forms.DialogResult.OK Then
            If _printoption.PrintOption = "1" Then
                btnPrint_Click(btnExcel, Nothing)
            Else
                btnPrint_Click(btnPrint, Nothing)
            End If
        End If
    End Sub







    Private Sub excelBooks(ByRef lstTotal As List(Of Integer), ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByRef xlWorkSheet As Excel.Worksheet, ByVal journal As String)
        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = journal
        xlWorkSheet.Cells(3, 1) = dicHeader.Item("book_name")
        If rdo1.Checked = True Then
            xlWorkSheet.Cells(4, 1) = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " To " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        Else
            xlWorkSheet.Cells(4, 1) = "As Of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        End If

        Dim current_row As Integer = 5
        xlWorkSheet.Cells(current_row, 1) = "Account Code"
        xlWorkSheet.Cells(current_row, 1).ColumnWidth = 8
        xlWorkSheet.Cells(current_row, 2) = ""
        xlWorkSheet.Cells(current_row, 2).ColumnWidth = 2
        xlWorkSheet.Cells(current_row, 3) = "Title"
        xlWorkSheet.Cells(current_row, 3).ColumnWidth = 30
        xlWorkSheet.Cells(current_row, 4) = "Debit"
        xlWorkSheet.Cells(current_row, 4).ColumnWidth = 15
        xlWorkSheet.Cells(current_row, 5) = "Credit"
        xlWorkSheet.Cells(current_row, 5).ColumnWidth = 15
        'xlWorkSheet.Cells(current_row, 6) = "General Reference"
        'xlWorkSheet.Cells(current_row, 6).ColumnWidth = 13
        'xlWorkSheet.Cells(current_row, 7) = "Proj/Dept Code"
        'xlWorkSheet.Cells(current_row, 7).ColumnWidth = 8
        'xlWorkSheet.Cells(current_row, 8) = "Document Reference"
        'xlWorkSheet.Cells(current_row, 8).ColumnWidth = 13

        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 5)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 5)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 5)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 5)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 5)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 5)).Font.Size = 10
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 5)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 5)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 5)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 5)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 5)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 5)).Font.Size = 8

        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 5)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 5)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 5)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 5)).HorizontalAlignment = Excel.Constants.xlCenter

        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 5)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 5)).WrapText = True
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 5)).VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 5)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 5)).Interior.Color = System.Drawing.Color.FromArgb(215, 228, 242)
        'xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        'xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        'xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        current_row += 1

        For Each transaction As Dictionary(Of String, Object) In listAccount
            Dim transaction_data As List(Of Object) = transaction.Item("datas")
            current_row += 1
            xlWorkSheet.Cells(current_row, 1) = "DATE"
            xlWorkSheet.Cells(current_row, 3) = ":    " & transaction_data(0).Item("trans_date")
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            current_row += 1
            xlWorkSheet.Cells(current_row, 1) = "Transaction No."
            xlWorkSheet.Cells(current_row, 3) = ":  " & transaction_data(0).Item("trans_no")
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            current_row += 1
            'xlWorkSheet.Cells(current_row, 1) = transaction_data(0).Item("person_label")
            'xlWorkSheet.Cells(current_row, 3) = ":  " & transaction_data(0).Item("general_name")
            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            'current_row += 1
            xlWorkSheet.Cells(current_row, 1) = "Particulars"
            xlWorkSheet.Cells(current_row, 3) = ":  " & transaction_data(0).Item("description")
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            current_row += 1

            Dim first_row As Integer = current_row
            For Each row In transaction_data
                xlWorkSheet.Cells(current_row, 1) = "'" & row.Item("account_code")
                xlWorkSheet.Cells(current_row, 1).Font.Size = 8
                xlWorkSheet.Cells(current_row, 3) = row.Item("account_name")
                xlWorkSheet.Cells(current_row, 3).Font.Size = 8


                xlWorkSheet.Cells(current_row, 4) = row.Item("debit_based")
                xlWorkSheet.Cells(current_row, 4).Font.Size = 8
                xlWorkSheet.Cells(current_row, 4).NumberFormat = "#,##0.00"


                xlWorkSheet.Cells(current_row, 5) = row.Item("credit_based")
                xlWorkSheet.Cells(current_row, 5).Font.Size = 8
                xlWorkSheet.Cells(current_row, 5).NumberFormat = "#,##0.00"


                'xlWorkSheet.Cells(current_row, 6) = row.Item("ref_trans_no")
                'xlWorkSheet.Cells(current_row, 6).Font.Size = 8
                'xlWorkSheet.Cells(current_row, 6).HorizontalAlignment = Excel.Constants.xlCenter
                'xlWorkSheet.Cells(current_row, 7) = row.Item("proj_dept")
                'xlWorkSheet.Cells(current_row, 7).Font.Size = 8
                'xlWorkSheet.Cells(current_row, 7).HorizontalAlignment = Excel.Constants.xlCenter
                'xlWorkSheet.Cells(current_row, 8) = row.Item("trans_general_name")
                'xlWorkSheet.Cells(current_row, 8).Font.Size = 8
                'xlWorkSheet.Cells(current_row, 8).HorizontalAlignment = Excel.Constants.xlCenter
                current_row += 1
            Next

            xlWorkSheet.Cells(current_row, 1) = transaction_data(0).Item("general_name") & " : "
            xlWorkSheet.Cells(current_row, 1).Font.Size = 8
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 5)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 5)).NumberFormat = "#,##0.00"
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
            lstTotal.Add(current_row)
            current_row += 1
        Next

        Dim strTotald As String = ""
        Dim strTotale As String = ""

        For Each t In lstTotal
            strTotald &= "+D" & t
            strTotale &= "+E" & t
        Next

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 4) = String.Format("=({0})", strTotald.Substring(1))
        xlWorkSheet.Cells(current_row, 5) = String.Format("=({0})", strTotale.Substring(1))
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 5)).NumberFormat = "#,##0.00"
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3

    End Sub





    'Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
    '    txt_date_to.MinDate = txt_date_from.Value
    'End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class