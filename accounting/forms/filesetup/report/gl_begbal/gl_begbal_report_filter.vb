Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class gl_begbal_report_filter
    Dim err As New ErrorProvider
    Private _trans_id As String = ""
    Private _trans_date As String = ""
    Dim templates As String = Application.StartupPath & "\templates"

    Public Property trans_date() As String
        Get
            Return _trans_date
        End Get
        Set(ByVal value As String)
            _trans_date = value
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
    Private Function testRequiredFields(ByVal obj As user_control.textbox) As Boolean
        Dim hasError As Boolean = False
        If obj.Value = "" Then
            err.SetError(obj, "This is required field and cannot be empty")
            hasError = True
        Else
            err.SetError(obj, "")
        End If
        Return hasError
    End Function
    Private Sub txt_sort_by_Leave(sender As Object, e As EventArgs) Handles txt_sort_by.Leave
        Dim dt As DataTable = FsQuery("SELECT 1 AS id,'Account Code' AS name UNION SELECT 2,'Account Title' UNION SELECT 3,'Debit' UNION SELECT 4,'Credit'")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("name like '{0}'", txt_sort_by.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "id,name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_sort_by.RowData = dr
                txt_sort_by.Value = dr("id")
                txt_sort_by.Text = dr("name")
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim sortBy = txt_sort_by.Value
        Dim ctr_for_err As Integer = 0

        If testRequiredFields(txt_sort_by) Then
            ctr_for_err += 1
        End If

        If ctr_for_err > 0 Then
            MsgBox("There are required field that cannot be empty.")
        Else
            If trans_id = "" Then
                MsgBox("No records to print.")
            Else
                Dim sql_company As String = String.Format("SELECT a.* FROM lib_erp_company a")
                Dim dt_company As DataTable = FsQuery(sql_company)
                Dim sql = String.Format("SELECT a.* FROM(
                    SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate
                    ,a.based_rate,a.debit,a.credit,a.debit_based,a.credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name
                    ,e.currency_name,e.currency_code ,IFNULL(f.book_unit_no_name,z.project_unit_no_names) AS book_unit_no_name,IFNULL(f.book_unit_no_code,z.project_unit_no_codes) AS book_unit_no_code
                    FROM trans_jbooks a
                    LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id
                    LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id
                    LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id
                    LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id
                    LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id
                    LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id
                    WHERE a.trans_id = '{0}' AND b.validation <> 3 AND b.validation <> 2
                    GROUP BY a.account_id
	                    UNION
                    SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate
                    ,SUM(a.debit) AS debit,SUM(a.credit) AS credit,SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks,b.account_name,b.account_code,b.validation
                    ,c.project_code,c.project_name,d.department_code,d.department_name ,e.currency_name,e.currency_code ,IFNULL(f.book_unit_no_name,z.project_unit_no_names) AS book_unit_no_name
                    ,IFNULL(f.book_unit_no_code,z.project_unit_no_codes) AS book_unit_no_code
                    FROM trans_jbooks a
                    LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id
                    LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id
                    LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id
                    LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id
                    LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id
                    LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id
                    WHERE a.trans_id = '{0}' AND b.validation = 3
                    GROUP BY a.account_id
	                    UNION
                    SELECT z.project_unit_no_names,IFNULL(a.book_unit_no_id,a.project_unit_no_id) AS book_unit_no_id,a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id
                    ,a.exchange_rate,a.based_rate,SUM(a.debit) AS debit,SUM(a.credit) AS credit,SUM(a.debit_based) AS debit_based,SUM(a.credit_based) AS credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks
                    ,b.account_name,b.account_code,b.validation,c.project_code,c.project_name,d.department_code,d.department_name ,e.currency_name,e.currency_code ,IFNULL(f.book_unit_no_name,z.project_unit_no_names) AS book_unit_no_name
                    ,IFNULL(f.book_unit_no_code,z.project_unit_no_codes) AS book_unit_no_code
                    FROM trans_jbooks a
                    LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id
                    LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id
                    LEFT JOIN {1}.lib_erp_department d ON d.department_id = a.department_id
                    LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id
                    LEFT JOIN {1}.lib_erp_book_unit_no f ON f.book_unit_no_id = a.book_unit_no_id
                    LEFT JOIN {1}.lib_erp_project_unit_no z ON z.project_unit_no_id = a.project_unit_no_id
                    WHERE a.trans_id = '{0}' AND b.validation = 2
                    GROUP BY a.account_id
                ) a", trans_id, _serverDBFS)
                Select Case sortBy
                    Case "1"
                        sql &= " ORDER BY a.account_code"
                    Case "2"
                        sql &= " ORDER BY a.account_name"
                    Case "3"
                        sql &= " ORDER BY a.debit"
                    Case "4"
                        sql &= " ORDER BY a.credit"
                End Select

                Dim ds As New begbal_report_set
                Dim dt As DataTable = Query(sql)
                Dim title = "As of " & trans_date
                Dim report_name As String = ""
                If dt_company.Rows.Count > 0 Then
                    report_name = dt_company.Rows(0).Item("company_name")
                End If

                If sender.name = "btnPrint" Then
                    Dim rep As New begbal_report
                    For Each row As DataRow In dt.Rows
                        ds.Tables("begbal_report").ImportRow(row)
                    Next
                    rep.DataSource = ds
                    rep.company_name.Text = report_name
                    rep.Parameters("rundate").Value = System.DateTime.Now.ToString("MMMM dd, yyyy")
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("HH:mm:ss")
                    rep.Parameters("title").Value = title
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                Else
                    Dim templeName As String = ""
                    Dim companyName As String = report_name
                    excelGL(ds, "gl.xlt", companyName)
                    MsgBox("Data Succesfully Load")
                End If

            End If
        End If
    End Sub
    Private Sub excelGL(ByVal ds As DataSet, ByVal templateName As String, ByVal companyName As String)
        Dim sortBy = txt_sort_by.Value
        Dim ctr_for_err As Integer = 0

        If testRequiredFields(txt_sort_by) Then
            ctr_for_err += 1
        End If

        If ctr_for_err > 0 Then
            MsgBox("There are required field that cannot be empty.")
        Else
            If trans_id = "" Then
                MsgBox("No records to print.")
            Else
                Dim sql = String.Format("SELECT a. * FROM (SELECT b.account_code,b.account_name,a.debit,a.credit " &
                                        "FROM trans_jbooks a " &
                                        "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                                        "WHERE a.trans_id = {0} And b.validation <> 3 And b.validation <> 2 " &
                                        "UNION " &
                                        "SELECT b.account_code,b.account_name,SUM(a.debit) AS debit,SUM(a.credit) AS credit  " &
                                        "FROM trans_jbooks a  " &
                                        "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id  " &
                                        "WHERE a.trans_id = {0} AND b.validation = 3 GROUP BY a.account_id  " &
                                        "UNION  " &
                                        "SELECT b.account_code,b.account_name,SUM(a.debit) AS debit,SUM(a.credit) AS credit  " &
                                        "FROM trans_jbooks a  " &
                                        "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id  " &
                                        "WHERE a.trans_id = {0} AND b.validation = 2 GROUP BY a.account_id) a ", trans_id, _serverDBFS)
                Select Case sortBy
                    Case "1"
                        sql &= " ORDER BY a.account_code"
                    Case "2"
                        sql &= " ORDER BY a.account_name"
                    Case "3"
                        sql &= " ORDER BY a.debit"
                    Case "4"
                        sql &= " ORDER BY a.credit"
                End Select

                Dim title = "As of " & trans_date
                Dim dt = Query(sql)
                Dim xlApp As Excel.Application
                Dim xlWorkBook As Excel.Workbook
                Dim xlWorkSheet As Excel.Worksheet

                xlApp = New Excel.Application
                xlApp.Visible = True
                xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
                xlWorkSheet = xlWorkBook.Worksheets(1)

                Dim current_row As Integer = 5
                Dim first_row = current_row

                xlWorkSheet.Cells(1, 1) = companyName
                xlWorkSheet.Cells(3, 1) = title

                For Each row As DataRow In dt.Rows
                    xlWorkSheet.Cells(current_row, 1) = "'" & row.Item("account_code")
                    xlWorkSheet.Cells(current_row, 2) = row.Item("account_name")
                    xlWorkSheet.Cells(current_row, 3) = row.Item("debit")
                    xlWorkSheet.Cells(current_row, 4) = row.Item("credit")
                    current_row += 1
                Next

                current_row += 1
                xlWorkSheet.Cells(current_row, 1) = "GRAND TOTAL : "
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 3) = String.Format("=SUM(C{0}:C{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 4) = String.Format("=SUM(D{0}:D{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 4)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
            End If
        End If
    End Sub
    Private Sub gl_begbal_report_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_sort_by.Text = "Account Code"
        txt_sort_by_Leave(Nothing, Nothing)
        btnPrintOption.Focus()
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        Dim _printoption As New reportoption
        _printoption.targetForm = Me
        _printoption.Label1.Hide()
        _printoption.cbo_sort.Hide()
        _printoption.ShowDialog()
        If _printoption.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim str_sortby As String = _printoption.cbo_sort.SelectedText
            If _printoption.PrintOption = "1" Then
                btnPrint_Click(btnExcel, Nothing)
            Else
                btnPrint_Click(btnPrint, Nothing)
            End If
        End If
    End Sub
End Class