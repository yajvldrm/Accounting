Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class SummaryOfBooksByTotal

    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged, rdo2.CheckedChanged
        Dim range As String = getRdoValue(range_filter)
        If range = "2" Then
            txt_date_from.Enabled = False
            txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        Else
            txt_date_from.Enabled = True
            txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
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

    Private Sub SummaryOfBooksByTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrder()
        LoadJournal()
        LoadBook()
        cboOrder.ValueMember = "order_id"
        cboOrder.DisplayMember = "order_name"
        cboOrder.DataSource = dsFilter.Tables("tblOrder")
        cboJournal.ValueMember = "journal_id"
        cboJournal.DisplayMember = "journal_name"
        cboJournal.DataSource = dsFilter.Tables("tblJournal")
        dgBooks.AutoGenerateColumns = False
        dgBooks.DataSource = dsFilter.Tables("tblBook")
    End Sub
    Private Sub LoadOrder()
        Dim sql As String = String.Format("SELECT 1 AS order_id,'BY CLASS PER CODE' AS order_name
            UNION SELECT 2,'ALPHABETICAL ORDER'
            UNION SELECT 3,'ORDER BY CODE'
            ")
        Dim dt As DataTable = FsQuery(sql)
        dsFilter.Tables("tblOrder").Rows.Clear()
        For Each dr As DataRow In dt.Rows
            dsFilter.Tables("tblOrder").ImportRow(dr)
        Next
    End Sub
    Private Sub LoadJournal()
        Dim sql As String = String.Format("SELECT 3 AS journal_id,'ACCOUNTS PAYABLE BOOK' AS journal_name
            UNION SELECT 4,'CASH DISBURSEMENT BOOK'
            UNION SELECT 2,'CASH RECEIPTS BOOK'
            UNION SELECT 7,'DEBIT/CREDIT MEMO'
            UNION SELECT 1,'INCOME BOOK'
            UNION SELECT 5,'JOURNAL BOOK'
            UNION SELECT 6,'PETTY CASH BOOK'
            ")
        Dim dt As DataTable = FsQuery(sql)
        dsFilter.Tables("tblJournal").Rows.Clear()
        For Each dr As DataRow In dt.Rows
            dsFilter.Tables("tblJournal").ImportRow(dr)
        Next
    End Sub
    Private Sub LoadBook(Optional journal_id As String = "")
        Dim sql As String = String.Format("SELECT FALSE AS sel,b.book_id,b.book_name
            FROM sys_acc_journal_book a
            LEFT JOIN lib_erp_book b ON b.book_id = a.book_id")
        If journal_id <> "" Then
            sql &= String.Format(vbNewLine & "WHERE journal_id = '{0}'", journal_id)
        End If
        sql &= String.Format(" GROUP BY a.book_id")
        Dim dt As DataTable = FsQuery(sql)
        dsFilter.Tables("tblBook").Rows.Clear()
        For Each dr As DataRow In dt.Rows
            dsFilter.Tables("tblBook").ImportRow(dr)
        Next
    End Sub

    Private Sub cboJournal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJournal.SelectedIndexChanged
        Dim journal_id As String = cboJournal.SelectedValue.ToString
        LoadBook(journal_id)
    End Sub

    Private Sub checkAllBook_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBook.CheckedChanged
        For Each dr As DataRow In dsFilter.Tables("tblBook").Rows
            dr.Item("sel") = checkAllBook.Checked
        Next
        dsFilter.AcceptChanges()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        If txt_date_to.Value < txt_date_from.Value Then
            If rdo1.Checked Then
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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim order As String = cboOrder.SelectedValue
        Dim range As String = getRdoValue(range_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim date_from = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim journal_id = cboJournal.SelectedValue
        Dim currency_id = txt_currency_id.Value
        Dim project_id = txt_project_id.Value
        Dim department_id = txt_department_id.Value
        Dim wProjDept As Boolean = withProjectDepartment.Checked
        Dim wComparison As Boolean = withComparison.Checked
        Dim arr_id = getCheckedGrid("book_id", "book_name", "sel", dgBooks, "", False, "Select Book First.")
        Dim str_id As String = ""
        Dim str_id1 As String = ""
        Dim str_account_id As String = ""
        Dim str_general_id As String = ""

        If arr_id.Length = 0 Then
            Exit Sub
        Else
            For i As Integer = 0 To arr_id.Length - 1
                str_id &= "," & arr_id(i)
            Next
            If range <> "2" Then
                If date_from > date_to Then
                    MsgBox("Invalid date range.")
                    Exit Sub
                End If
            End If
        End If

        Dim sqlWhere As String = ""
        Dim sqlOrder As String = ""
        Dim sqlGroup As String = ""

        If order <> "" Then
            Select Case order
                Case "1"
                    sqlOrder = String.Format("FIELD(f.chart_type,'A','L','C','I','E'),c.account_code")
                Case "2"
                    sqlOrder = String.Format("c.account_name")
                Case "3"
                    sqlOrder = String.Format("c.account_code")
            End Select
            sqlOrder = String.Format("ORDER BY {0}", sqlOrder)
        End If
        Select Case range
            Case "1"
                sqlWhere &= String.Format(" AND a.trans_date BETWEEN '{0}' AND '{1}'", date_from, date_to)
            Case "2"
                sqlWhere &= String.Format(" AND a.trans_date <= '{0}'", date_to)
            Case "3"
        End Select
        If journal_id <> "" Then
            sqlWhere &= String.Format(" AND a.journal_id = '{0}'", journal_id)
        End If
        If currency_id <> "" Then
            sqlWhere &= String.Format(" AND b.currency_id = '{0}'", currency_id)
        End If
        If project_id <> "" Then
            sqlWhere &= String.Format(" AND b.project_id = '{0}'", project_id)
        End If
        If department_id <> "" Then
            sqlWhere &= String.Format(" AND b.department_id = '{0}'", department_id)
        End If
        If str_id <> "" Then
            sqlWhere &= String.Format(" AND a.book_id IN ({0})", str_id.Substring(1))
        End If
        If groupByBook.Checked Then
            sqlGroup &= String.Format(",a.book_id")
        End If
        If withProjectDepartment.Checked Then
            sqlGroup &= String.Format(",b.project_id,b.department_id")
        End If
        Dim sql As String = String.Format("SELECT a.journal_id,a.journal_code,a.journal_name
        ,a.book_id,a.book_code,a.book_name
        ,a.account_id,a.account_code,a.account_name,a.chart_class_type
        ,a.project_id,a.project_code,a.project_name
        ,a.department_id,a.department_code,a.department_name
        ,a.currency_id,a.currency_code,a.currency_name
        ,IF(a.debit > a.credit,a.debit - a.credit,0) AS debit
        ,IF(a.credit > a.debit,a.credit - a.debit,0) AS credit
        ,IF(a.debit_based > a.credit_based,a.debit_based - a.credit_based,0) AS debit_based
        ,IF(a.credit_based > a.debit_based,a.credit_based - a.debit_based,0) AS credit_based
        FROM (
	        SELECT a.trans_id,a.trans_no,a.trans_date
	        ,a.journal_id,e.journal_code,e.journal_name
	        ,a.book_id,d.book_code,d.book_name
	        ,b.jbooks_id,b.account_id,c.account_code,c.account_name,f.chart_type AS chart_class_type
            ,b.project_id,g.project_code,g.project_name
            ,b.department_id,h.department_code,h.department_name
            ,b.currency_id,i.currency_code,i.currency_name
	        ,SUM(IFNULL(b.debit,0)) AS debit
	        ,SUM(IFNULL(b.credit,0)) AS credit
	        ,SUM(IFNULL(b.debit_based,0)) AS debit_based
	        ,SUM(IFNULL(b.credit_based,0)) AS credit_based
	        FROM trans_header a
	        LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id
	        LEFT JOIN {0}.lib_erp_chart c ON c.account_id = b.account_id
	        LEFT JOIN {0}.lib_erp_book d ON d.book_id = a.book_id
	        LEFT JOIN {0}.lib_erp_journal e ON e.journal_id = a.journal_id
            LEFT JOIN {0}.lib_acc_chart_class f ON f.chart_class_id = c.chart_class_id
            LEFT JOIN {0}.lib_erp_project g ON g.project_id = b.project_id
            LEFT JOIN {0}.lib_erp_department h ON h.department_id = b.department_id
            LEFT JOIN {0}.lib_erp_currency i ON i.currency_id = b.currency_id
	        WHERE IFNULL(a.status,'') <> 'C' {2}
	        GROUP BY a.journal_id{3},b.account_id
	        {1}
        ) a ", _serverDBFS, sqlOrder, sqlWhere, sqlGroup)
        Dim dt As DataTable = Query(sql)
        ds.Tables("company").Clear()
        ds.Tables("account").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("account").ImportRow(dr)
        Next
        For Each dr As DataRow In main.Sys_Default.Rows
            ds.Tables("company").ImportRow(dr)
        Next
        If currency = "1" Then
            For Each dr As DataRow In ds.Tables("account").Rows
                dr.Item("debit") = dr.Item("debit_based")
                dr.Item("credit") = dr.Item("credit_based")
            Next
        End If
        If sender.Name = "btnPrint" Then
            If wComparison Then
                Dim rep As New SummaryOfBooksByTotalPrint1
                If Not wProjDept Then
                    rep.GroupHeader3.GroupFields.Clear()
                    rep.GroupHeader4.GroupFields.Clear()
                    rep.GroupHeader3.Visible = False
                    rep.GroupHeader4.Visible = False
                    rep.GroupFooter3.Visible = False
                    rep.GroupFooter4.Visible = False
                End If
                If currency_id = "" And currency = "1" Then
                    rep.GroupHeader2.GroupFields.Clear()
                    rep.GroupHeader2.Visible = False
                    rep.GroupFooter2.Visible = False
                End If
                If Not groupByBook.Checked Then
                    rep.GroupHeader1.GroupFields.Clear()
                    rep.GroupHeader1.Visible = False
                    rep.GroupFooter1.Visible = False
                End If
                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                rep.range.Text = cboJournal.Text
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                Dim rep As New SummaryOfBooksByTotalPrint
                If Not wProjDept Then
                    rep.GroupHeader3.GroupFields.Clear()
                    rep.GroupHeader4.GroupFields.Clear()
                    rep.GroupHeader3.Visible = False
                    rep.GroupHeader4.Visible = False
                    rep.GroupFooter3.Visible = False
                    rep.GroupFooter4.Visible = False
                End If
                If currency_id = "" And currency = "1" Then
                    rep.GroupHeader2.GroupFields.Clear()
                    rep.GroupHeader2.Visible = False
                    rep.GroupFooter2.Visible = False
                End If
                If Not groupByBook.Checked Then
                    rep.GroupHeader1.GroupFields.Clear()
                    rep.GroupHeader1.Visible = False
                    rep.GroupFooter1.Visible = False
                End If
                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                rep.range.Text = cboJournal.Text
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            End If
        Else
            Dim strGroup As String = ""
            If groupByBook.Checked Then
                strGroup &= String.Format(",book_name")
            End If
            If currency = "2" Or currency_id <> "" Then
                strGroup &= String.Format(",currency_name")
            End If
            If wProjDept Then
                strGroup &= String.Format(",project_name,department_name")
            End If
            Dim dic As New Dictionary(Of String, Object)
            dic.Add("order", order)
            dic.Add("range", range)
            dic.Add("currency", currency)
            dic.Add("date_from", date_from)
            dic.Add("date_to", date_to)
            dic.Add("journal_id", journal_id)
            dic.Add("currency_id", currency_id)
            dic.Add("project_id", project_id)
            dic.Add("department_id", department_id)
            dic.Add("wProjDept", wProjDept)
            dic.Add("wComparison", wComparison)
            dic.Add("arr_id", arr_id)
            dic.Add("groupByBook", groupByBook.Checked)
            dic.Add("journal_name", cboJournal.Text)
            If strGroup <> "" Then
                strGroup = strGroup.Substring(1)
                Dim lstAccount = groupDataTableToList(ds.Tables("account"), strGroup)
                Try
                    lblLoad.Visible = True
                    GenerateExcelReport(ds.Tables("company"), ds.Tables("account"), lstAccount, dic, strGroup)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            Else
                Try
                    lblLoad.Visible = True
                    GenerateExcelReport(ds.Tables("company"), ds.Tables("account"), Nothing, dic, strGroup)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            End If
        End If
    End Sub
    Private Sub GenerateExcelReport(ByVal company As DataTable,
                                    ByVal account As DataTable,
                                    ByVal lstAccount As List(Of Object),
                                    ByVal dic As Dictionary(Of String, Object),
                                    ByVal strGroup As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim current_row As Integer = 5
        Dim current_column As Integer = 1
        Dim last_column As Integer = current_column

        'initialize the page header
        xlWorkSheet.Cells(1, 1) = company.Rows(0).Item("company_name").ToString
        xlWorkSheet.Cells(2, 1) = "Summary of Books by Total"
        xlWorkSheet.Cells(3, 1) = dic.Item("journal_name").ToString
        Dim lastColumn As Integer = 5

        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 1)).ColumnWidth = 20
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 2), xlWorkSheet.Cells(1, 2)).ColumnWidth = 50
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 3), xlWorkSheet.Cells(1, 3)).ColumnWidth = 20
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 4), xlWorkSheet.Cells(1, 4)).ColumnWidth = 20
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 5), xlWorkSheet.Cells(1, 5)).ColumnWidth = 20
        If dic.Item("wComparison") Then
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 6), xlWorkSheet.Cells(1, 6)).ColumnWidth = 20
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 7), xlWorkSheet.Cells(1, 7)).ColumnWidth = 20
            lastColumn = 7
        End If
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, lastColumn)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, lastColumn)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, lastColumn)).MergeCells = True

        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(3, lastColumn)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(3, lastColumn)).Font.Bold = True

        'initialize the report header
        xlWorkSheet.Cells(current_row, 1) = "CODE"
        xlWorkSheet.Cells(current_row, 2) = "ACCOUNT TITLE"
        xlWorkSheet.Cells(current_row, 3) = "DEBIT"
        xlWorkSheet.Cells(current_row, 4) = "CREDIT"
        If dic.Item("wComparison") Then
            xlWorkSheet.Cells(current_row, 5) = "DEBIT BASED"
            xlWorkSheet.Cells(current_row, 6) = "CREDIT BASED"
            current_column = 7
        Else
            current_column = 5
        End If
        xlWorkSheet.Cells(current_row, current_column) = "ACCOUNT TYPE"

        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, lastColumn)).Font.Bold = True

        current_row += 1
        current_column = 1
        Dim firstRow As Integer = current_row
        If lstAccount IsNot Nothing Then
            Dim currentIndex As Integer = 0
            GenerateExcelReportGroup(xlWorkSheet, lstAccount, dic, current_row, current_column, firstRow, strGroup, currentIndex)
            xlWorkSheet.Cells(current_row, 1) = "Grand Total : "
            xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "C", firstRow, current_row - 1)
            xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "D", firstRow, current_row - 1)

            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 4)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"

            If dic.Item("wComparison") Then
                xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "E", firstRow, current_row - 1)
                xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "F", firstRow, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 6)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"
            End If
        Else
            For Each dr As DataRow In account.Rows
                xlWorkSheet.Cells(current_row, 1) = "'" & dr.Item("account_code").ToString
                xlWorkSheet.Cells(current_row, 2) = dr.Item("account_name").ToString
                xlWorkSheet.Cells(current_row, 3) = dr.Item("debit").ToString
                xlWorkSheet.Cells(current_row, 4) = dr.Item("credit").ToString
                If dic.Item("wComparison") Then
                    xlWorkSheet.Cells(current_row, 5) = dr.Item("debit_based").ToString
                    xlWorkSheet.Cells(current_row, 6) = dr.Item("credit_based").ToString
                    xlWorkSheet.Cells(current_row, 7) = dr.Item("chart_class_type").ToString
                Else
                    xlWorkSheet.Cells(current_row, 5) = dr.Item("chart_class_type").ToString
                End If
                current_row += 1
            Next
            xlWorkSheet.Cells(current_row, 1) = "Grand Total : "
            xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "C", firstRow, current_row - 1)
            xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "D", firstRow, current_row - 1)

            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 4)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"

            If dic.Item("wComparison") Then
                xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "E", firstRow, current_row - 1)
                xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "F", firstRow, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 6)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"
            End If

            '_(* #,##0.00_);_(* (#,##0.00);_(* "-"??_);_(@_)

            xlWorkSheet.Range(xlWorkSheet.Cells(firstRow, 1), xlWorkSheet.Cells(current_row - 1, 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(firstRow, 3), xlWorkSheet.Cells(current_row - 1, 4)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlWorkSheet.Range(xlWorkSheet.Cells(firstRow, 3), xlWorkSheet.Cells(current_row - 1, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"
            If dic.Item("wComparison") Then
                xlWorkSheet.Range(xlWorkSheet.Cells(firstRow, 5), xlWorkSheet.Cells(current_row - 1, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(firstRow, 5), xlWorkSheet.Cells(current_row - 1, 6)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
            xlWorkSheet.Range(xlWorkSheet.Cells(firstRow, lastColumn), xlWorkSheet.Cells(current_row - 1, lastColumn)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
    End Sub
    Private Sub GenerateExcelReportGroup(ByRef xlWorkSheet As Excel.Worksheet,
                                         ByVal lstAccount As List(Of Object),
                                         ByVal dic As Dictionary(Of String, Object),
                                         ByRef current_row As Integer,
                                         ByRef current_column As Integer,
                                         ByRef firstRow As Integer,
                                         ByRef strGroup As String,
                                         ByRef currentIndex As Integer)
        Dim fields = strGroup.Split(",")
        If currentIndex >= fields.Length Then
            Exit Sub
        End If
        Dim field = fields(currentIndex)
        For Each dicAccount In lstAccount
            Dim strGroupField As String = ""
            Select Case field
                Case "book_name"
                    strGroupField = "Book"
                Case "currency_name"
                    strGroupField = "Currency"
                Case "project_name"
                    strGroupField = "Project"
                Case "department_name"
                    strGroupField = "Department"
            End Select
            If dicAccount.ContainsKey("grouped") Then
                xlWorkSheet.Cells(current_row, 1) = String.Format("{0} : {1}", strGroupField, dicAccount.Item(field))
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2)).MergeCells = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                Dim myFirstRow As Integer = current_row
                Dim myLastRow As Integer = current_row
                current_row += 1
                currentIndex += 1
                GenerateExcelReportGroup(xlWorkSheet, dicAccount.Item("grouped"), dic, current_row, current_column, firstRow, strGroup, currentIndex)
                myLastRow = current_row - 1
                xlWorkSheet.Cells(current_row, 1) = String.Format("Sub-Total per {0} : {1}", strGroupField, dicAccount.Item(field))
                xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "C", myFirstRow, current_row - 1)
                xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "D", myFirstRow, current_row - 1)

                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2)).MergeCells = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 4)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"

                If dic.Item("wComparison") Then
                    xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "E", myFirstRow, current_row - 1)
                    xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "F", myFirstRow, current_row - 1)
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 6)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"
                End If
                current_row += 1
                currentIndex -= 1
            Else
                xlWorkSheet.Cells(current_row, 1).Value = String.Format("{0} : {1}", strGroupField, dicAccount.Item(field))
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2)).MergeCells = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                Dim myFirstRow As Integer = current_row
                Dim myLastRow As Integer = current_row
                current_row += 1
                currentIndex += 1

                If dicAccount.ContainsKey("datas") Then
                    Dim lstItem As List(Of Object) = dicAccount.Item("datas")
                    For Each dicItem In lstItem
                        xlWorkSheet.Cells(current_row, 1) = String.Format("'{0}", dicItem.Item("account_code").ToString())
                        xlWorkSheet.Cells(current_row, 2) = String.Format("{0}", dicItem.Item("account_name").ToString())
                        xlWorkSheet.Cells(current_row, 3) = String.Format("{0}", dicItem.Item("debit").ToString())
                        xlWorkSheet.Cells(current_row, 4) = String.Format("{0}", dicItem.Item("credit").ToString())
                        If dic.Item("wComparison") Then
                            xlWorkSheet.Cells(current_row, 5) = String.Format("{0}", dicItem.Item("debit_based").ToString())
                            xlWorkSheet.Cells(current_row, 6) = String.Format("{0}", dicItem.Item("credit_based").ToString())
                            xlWorkSheet.Cells(current_row, 7) = String.Format("{0}", dicItem.Item("chart_class_type").ToString())
                        Else
                            xlWorkSheet.Cells(current_row, 5) = String.Format("{0}", dicItem.Item("chart_class_type").ToString())
                        End If
                        current_row += 1
                    Next
                End If

                myLastRow = current_row - 1
                xlWorkSheet.Cells(current_row, 1) = String.Format("Sub-Total per {0} : {1}", strGroupField, dicAccount.Item(field))
                xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "C", myFirstRow, current_row - 1)
                xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "D", myFirstRow, current_row - 1)

                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 2)).MergeCells = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 4)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"

                If dic.Item("wComparison") Then
                    xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "E", myFirstRow, current_row - 1)
                    xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,{0}{1}:{0}{2})", "F", myFirstRow, current_row - 1)
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 6)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"
                End If

                xlWorkSheet.Range(xlWorkSheet.Cells(myFirstRow + 1, 1), xlWorkSheet.Cells(current_row - 1, 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xlWorkSheet.Range(xlWorkSheet.Cells(myFirstRow, 3), xlWorkSheet.Cells(current_row - 1, 4)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                xlWorkSheet.Range(xlWorkSheet.Cells(myFirstRow, 3), xlWorkSheet.Cells(current_row - 1, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"
                If dic.Item("wComparison") Then
                    xlWorkSheet.Range(xlWorkSheet.Cells(myFirstRow, 5), xlWorkSheet.Cells(current_row - 1, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* ""-""??_);_(@_)"
                    xlWorkSheet.Range(xlWorkSheet.Cells(myFirstRow, 5), xlWorkSheet.Cells(current_row - 1, 6)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    xlWorkSheet.Range(xlWorkSheet.Cells(myFirstRow, 7), xlWorkSheet.Cells(current_row - 1, 7)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Else
                    xlWorkSheet.Range(xlWorkSheet.Cells(myFirstRow, 5), xlWorkSheet.Cells(current_row - 1, 5)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                End If
                current_row += 1
                currentIndex -= 1
            End If
        Next
    End Sub

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
    End Sub
End Class