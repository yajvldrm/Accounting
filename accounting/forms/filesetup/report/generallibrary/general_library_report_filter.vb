Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class general_library_report_filter
    Dim err As New ErrorProvider
    Dim templates As String = Application.StartupPath & "\templates"

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
    Private Sub btnPrint_Click(sender As Object, e As EventArgs, str_sort As String)
        Dim sortBy = txt_sort_by.Value
        Dim filterdBy = txt_filtered_id.Value
        Dim ctr_for_err As Integer = 0

        If testRequiredFields(txt_sort_by) Then
            ctr_for_err += 1
        End If

        If sortBy <> "1" Then
            If testRequiredFields(txt_filtered_id) Then
                ctr_for_err += 1
            End If
        End If

        If ctr_for_err > 0 Then
            MsgBox("There are required field that cannot be empty.")
        Else
            Dim sql_company As String = String.Format("SELECT a.* FROM lib_erp_company a")
            Dim dt_company As DataTable = FsQuery(sql_company)
            Dim sql = "SELECT a.general_id,a.general_code,a.general_name,a.tin,a.tel_no,a.attention,a.address1,a.status,a.category_id " & _
                      " ,c.ewt_code,c.ewt_name,c.tax_rate,d.category_code,d.category_name " & _
                      " FROM lib_erp_general a " & _
                      " LEFT JOIN lib_erp_general_ewt b ON b.general_id = a.general_id " & _
                      " LEFT JOIN lib_acc_ewt c ON c.ewt_id = b.ewt_id " & _
                      " LEFT JOIN lib_erp_category d ON d.category_id =a.category_id"

            Dim title = ""
            Dim report_name As String = ""
            If dt_company.Rows.Count > 0 Then
                report_name = dt_company.Rows(0).Item("company_name")
            End If

            Select Case sortBy
                Case "1"
                    title = "LIST OF ALL GENERAL LIBRARIES"
                    sql &= ""
                Case "2"
                    title = String.Format("LIST OF GENERAL LIBRARIES UNDER {0} INDUSTRY", txt_filtered_id.Text)
                    sql &= String.Format(" WHERE a.industry_id = {0}", filterdBy)
                Case "3"
                    title = String.Format("LIST OF GENERAL LIBRARIES UNDER {0} CATEGORIES", txt_filtered_id.Text)
                    sql &= String.Format(" WHERE a.category_id = {0}", filterdBy)
                Case "4"
                    title = String.Format("LIST OF ACTIVE GENERAL LIBRARIES UNDER {0} CATEGORIES", txt_filtered_id.Text)
                    sql &= String.Format(" WHERE a.category_id = {0} AND status = 0", filterdBy)
                Case "5"
                    title = String.Format("LIST OF INACTIVE GENERAL LIBRARIES UNDER {0} CATEGORIES", txt_filtered_id.Text)
                    sql &= String.Format(" WHERE a.category_id = {0} AND status = 1", filterdBy)
            End Select

            If sender.name = "btnPrint" Then
                Dim ds As New general_library_report_set
                Dim dt As DataTable = FsQuery(sql)
                Dim rep As New general_library_report_print
                For Each row As DataRow In dt.Rows
                    ds.Tables("general_library_report").ImportRow(row)
                Next
                rep.company_name.Text = report_name
                rep.print_title.Text = title
                rep.DataSource = ds
                rep.runday.Text = System.DateTime.Now.ToString("MMMM dd, yyyy")
                rep.runt.Text = System.DateTime.Now.ToString("HH:mm:ss")
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                Dim templeName As String = ""
                Dim companyName As String = ""

                If dt_company.Rows.Count > 0 Then
                    companyName = dt_company.Rows(0).Item("company_name").ToString
                End If
                excelGeneral("general.xlt", companyName)
                MsgBox("Data Succesfully Load")
            End If
        End If

    End Sub
    Private Sub excelGeneral(ByVal templateName As String, ByVal companyName As String)
        Dim sortBy = txt_sort_by.Value
        Dim filterdBy = txt_filtered_id.Value
        Dim ctr_for_err As Integer = 0

        Dim sql = "SELECT a.general_id,a.general_code,a.general_name,a.tin,a.tel_no,a.attention,a.address1,a.status,a.category_id " & _
                  " ,c.ewt_code,c.ewt_name,c.tax_rate,d.category_code,d.category_name,e.terms_name " & _
                  " FROM lib_erp_general a " & _
                  " LEFT JOIN lib_erp_general_ewt b ON b.general_id = a.general_id " & _
                  " LEFT JOIN lib_acc_ewt c ON c.ewt_id = b.ewt_id " & _
                  " LEFT JOIN lib_erp_category d ON d.category_id =a.category_id " & _
                  " left join lib_erp_terms e on e.terms_id = a.terms_id"

        If sortBy <> "1" Then
            If testRequiredFields(txt_filtered_id) Then
                ctr_for_err += 1
            End If
        End If

        Select Case sortBy
            Case "1"
                sql &= ""
            Case "2"
                sql &= String.Format(" WHERE a.industry_id = {0}", filterdBy)
            Case "3"
                sql &= String.Format(" WHERE a.category_id = {0}", filterdBy)
            Case "4"
                sql &= String.Format(" WHERE a.category_id = {0} AND status = 0", filterdBy)
            Case "5"
                sql &= String.Format(" WHERE a.category_id = {0} AND status = 1", filterdBy)
        End Select

        Dim dt = FsQuery(sql)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim current_row As Integer = 4

        xlWorkSheet.Cells(1, 1) = companyName
        xlWorkSheet.Cells(current_row, 1) = txt_filtered_id.Text
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 3
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        current_row += 1

        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = row.Item("general_code")
            xlWorkSheet.Cells(current_row, 2) = row.Item("general_name")
            xlWorkSheet.Cells(current_row, 3) = row.Item("tin")
            xlWorkSheet.Cells(current_row, 4) = row.Item("tel_no")
            xlWorkSheet.Cells(current_row, 5) = row.Item("attention")
            xlWorkSheet.Cells(current_row, 6) = row.Item("address1")
            xlWorkSheet.Cells(current_row, 7) = row.Item("ewt_code")
            xlWorkSheet.Cells(current_row, 8) = row.Item("tax_rate")
            current_row += 1
        Next
    End Sub
    Private Sub txt_sort_by_Leave(sender As Object, e As EventArgs) Handles txt_sort_by.Leave
        Dim dt As DataTable = FsQuery("SELECT 1 AS id,'Print All' AS name UNION SELECT 2,'Print Per Industry' UNION SELECT 3,'Print Per Category' UNION SELECT 4,'Active' UNION SELECT 5,'Inactive'")
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
                If dr("id").ToString = "1" Then
                    txt_filtered_id.Enabled = False
                Else
                    If dr("id").ToString = "2" Then
                        lblFiltered.Text = "Industry"
                    Else
                        lblFiltered.Text = "Category"
                    End If
                    txt_filtered_id.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub txt_filtered_id_Leave(sender As Object, e As EventArgs) Handles txt_filtered_id.Leave
        Dim sql = ""
        If txt_sort_by.Value = "2" Then
            sql = "SELECT industry_id AS id,industry_code AS code,industry_name AS name FROM lib_erp_industry"
        Else
            sql = "SELECT category_id AS id,category_code AS code,category_name AS name FROM lib_erp_category"
        End If
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("name like '{0}'", txt_filtered_id.Text.ToString.Replace("'", "''")))
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
                txt_filtered_id.RowData = dr
                txt_filtered_id.Value = dr("id")
                txt_filtered_id.Text = dr("name")
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub general_library_report_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_sort_by.Text = "Print All"
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
                btnPrint_Click(btnExcel, Nothing, str_sortby)
            Else
                btnPrint_Click(btnPrint, Nothing, str_sortby)
            End If
        End If
    End Sub
End Class