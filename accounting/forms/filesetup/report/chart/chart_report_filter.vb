Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class chart_report_filter
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
        Dim withDescription As Boolean = chk_description.Checked
        Dim withGroupCode As Boolean = chk_group_code.Checked
        Dim sortBy = txt_sort_by.Value
        Dim groupID = txt_group_id.Value
        Dim groupBy = txt_group_by.Value
        Dim ctr_for_err As Integer = 0

        If testRequiredFields(txt_sort_by) Then
            ctr_for_err += 1
        End If

        If testRequiredFields(txt_group_by) Then
            ctr_for_err += 1
        End If

        Dim sql As String = "SELECT a.account_id,a.account_code,a.account_name,a.description,b.chart_type,d.chart_group_code " & _
                            "FROM lib_erp_chart a " & _
                            "LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " & _
                            "LEFT JOIN lib_erp_chart_group c ON c.account_id = a.account_id " & _
                            "LEFT JOIN lib_acc_chart_group d ON d.chart_group_id = c.group_id"

        If ctr_for_err > 0 Then
            MsgBox("There are required field that cannot be empty.")
        Else
            If sortBy.Contains("g") Then
                If groupID <> "" Then
                    sql &= String.Format(" WHERE c.group_id = {0}", groupID)
                End If
            ElseIf sortBy.Contains("v") Then
                sql &= String.Format(" WHERE a.validation = {0}", sortBy.Replace("v", ""))
            ElseIf sortBy.Contains("a") Then
                sql &= ""
            Else
                sql &= String.Format(" WHERE b.chart_class_id = {0}", sortBy)
            End If

            sql &= String.Format(" ORDER BY {0}", groupBy)
            Dim ds As New DataSet
            Dim dt As DataTable = FsQuery(sql)
            Dim dt1 As New DataTable
            dt1.TableName = "Chart"

            For Each col As DataColumn In dt.Columns
                dt1.Columns.Add(col.ColumnName)
            Next

            For Each row As DataRow In dt.Rows
                dt1.ImportRow(row)
            Next

            ds.Tables.Add(dt1)
            sql = String.Format("SELECT company_name " & _
                                "FROM lib_erp_company " & _
                                "WHERE company_id = {0}", main.Sys_Default.Rows(0).Item("company_id"))
            dt = FsQuery(sql)
            If dt.Rows.Count = 0 Then
                MsgBox("No Record Found")
            End If
            If sender.name = "btnPrint" Then
                Dim rep As New chart_report_print
                rep.DataSource = ds
                rep.DataMember = (CType(rep.DataSource, DataSet)).Tables(0).TableName
                printCOA(rep, withDescription, withGroupCode)
                rep.Parameters("rundate").Value = System.DateTime.Now.ToString("MMMM dd, yyyy")
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("HH:mm:ss")
                rep.Parameters("company_name").Value = dt.Rows(0).Item("company_name")
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                Dim templeName As String = ""
                Dim companyName As String = ""
                If dt.Rows.Count > 0 Then
                    companyName = dt.Rows(0).Item("company_name").ToString
                End If
                If chk_group_code.Checked = True Then
                    excelChart(ds, "chart.xlt", companyName)
                    MsgBox("Data Succesfuly Load")
                Else
                    excelChart2(ds, "chart2.xlt", companyName)
                    MsgBox("Data Succesfuly Load")
                End If
            End If
        End If
    End Sub
    Private Sub excelChart(ByVal ds As DataSet, ByVal templateName As String, ByVal companyName As String)
        Dim sortBy = txt_sort_by.Value
        Dim groupID = txt_group_id.Value
        Dim groupBy = txt_group_by.Value
        Dim ctr_for_err As Integer = 0

        If testRequiredFields(txt_sort_by) Then
            ctr_for_err += 1
        End If

        If testRequiredFields(txt_group_by) Then
            ctr_for_err += 1
        End If

        Dim sql As String = "SELECT a.account_id,a.account_code,a.account_name,a.description,b.chart_type,d.chart_group_code " & _
                            "FROM lib_erp_chart a " & _
                            "LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " & _
                            "LEFT JOIN lib_erp_chart_group c ON c.account_id = a.account_id " & _
                            "LEFT JOIN lib_acc_chart_group d ON d.chart_group_id = c.group_id"

        If ctr_for_err > 0 Then
            MsgBox("There are required field that cannot be empty.")
        Else
            If sortBy.Contains("g") Then
                If groupID <> "" Then
                    sql &= String.Format(" WHERE c.group_id = {0}", groupID)
                End If
            ElseIf sortBy.Contains("v") Then
                sql &= String.Format(" WHERE a.validation = {0}", sortBy.Replace("v", ""))
            ElseIf sortBy.Contains("a") Then
                sql &= ""
            Else
                sql &= String.Format(" WHERE b.chart_class_id = {0}", sortBy)
            End If
            sql &= String.Format(" ORDER BY {0}", groupBy)
        End If

        Dim dt = FsQuery(sql)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)
        xlWorkSheet.Cells(1, 1) = companyName

        Dim current_row As Integer = 4
        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = row.Item("account_code")
            xlWorkSheet.Cells(current_row, 2) = row.Item("account_name")
            xlWorkSheet.Cells(current_row, 3) = row.Item("chart_type")
            xlWorkSheet.Cells(current_row, 4) = row.Item("chart_group_code")
            current_row += 1
        Next
    End Sub
    Private Sub excelChart2(ByVal ds As DataSet, ByVal templateName As String, ByVal companyName As String)
        Dim sortBy = txt_sort_by.Value
        Dim groupID = txt_group_id.Value
        Dim groupBy = txt_group_by.Value
        Dim ctr_for_err As Integer = 0

        If testRequiredFields(txt_sort_by) Then
            ctr_for_err += 1
        End If

        If testRequiredFields(txt_group_by) Then
            ctr_for_err += 1
        End If

        Dim sql As String = "SELECT a.account_id,a.account_code,a.account_name,a.description,b.chart_type,d.chart_group_code " & _
                            "FROM lib_erp_chart a " & _
                            "LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " & _
                            "LEFT JOIN lib_erp_chart_group c ON c.account_id = a.account_id " & _
                            "LEFT JOIN lib_acc_chart_group d ON d.chart_group_id = c.group_id"

        If ctr_for_err > 0 Then
            MsgBox("There are required field that cannot be empty.")
        Else
            If sortBy.Contains("g") Then
                If groupID <> "" Then
                    sql &= String.Format(" WHERE c.group_id = {0}", groupID)
                End If
            ElseIf sortBy.Contains("v") Then
                sql &= String.Format(" WHERE a.validation = {0}", sortBy.Replace("v", ""))
            ElseIf sortBy.Contains("a") Then
                sql &= ""
            Else
                sql &= String.Format(" WHERE b.chart_class_id = {0}", sortBy)
            End If
            sql &= String.Format(" ORDER BY {0}", groupBy)
        End If

        Dim dt = FsQuery(sql)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = companyName

        Dim current_row As Integer = 4
        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = row.Item("account_code")
            xlWorkSheet.Cells(current_row, 2) = row.Item("account_name")
            xlWorkSheet.Cells(current_row, 3) = row.Item("chart_type")
            current_row += 1
        Next
    End Sub
    Public Sub printCOA(ByVal rep As XtraReport, ByVal withDescription As Boolean, ByVal withGroupCode As Boolean)
        Dim ds As DataSet = (CType(rep.DataSource, DataSet))
        Dim tblHeader As New XRTable
        Dim tblDetail As New XRTable
        Dim rowHeader As New XRTableRow
        Dim rowDetail As New XRTableRow

        tblHeader.HeightF = rep.FindControl("panel_header", False).HeightF
        tblHeader.WidthF = rep.FindControl("panel_header", False).WidthF
        tblHeader.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblHeader.BeginInit()

        tblDetail.HeightF = rep.FindControl("panel_detail", False).HeightF
        tblDetail.WidthF = rep.FindControl("panel_detail", False).WidthF
        tblDetail.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblDetail.BeginInit()

        Dim cellHeaderCode As New XRTableCell
        Dim cellHeaderTitle As New XRTableCell
        Dim cellHeaderClass As New XRTableCell
        Dim cellHeaderGroup As New XRTableCell
        Dim cellHeaderDescription As New XRTableCell

        Dim cellDetailCode As New XRTableCell
        Dim cellDetailTitle As New XRTableCell
        Dim cellDetailClass As New XRTableCell
        Dim cellDetailGroup As New XRTableCell
        Dim cellDetailDescription As New XRTableCell

        cellHeaderCode.Text = "Account Code"
        cellHeaderCode.WidthF = 100
        cellHeaderTitle.Text = "Account Title"
        cellHeaderTitle.WidthF = 200
        cellHeaderClass.Text = "Class"
        cellHeaderGroup.Text = "Group"
        cellHeaderDescription.Text = "Description"

        cellDetailCode.DataBindings.Add("Text", Nothing, "account_code")
        cellDetailCode.WidthF = 100
        cellDetailTitle.DataBindings.Add("Text", Nothing, "account_name")
        cellDetailTitle.WidthF = 200
        cellDetailClass.DataBindings.Add("Text", Nothing, "chart_type")
        cellDetailGroup.DataBindings.Add("Text", Nothing, "chart_group_code")
        cellDetailDescription.DataBindings.Add("Text", Nothing, "description")

        rowHeader.Cells.Add(cellHeaderCode)
        rowHeader.Cells.Add(cellHeaderTitle)
        rowHeader.Cells.Add(cellHeaderClass)
        rowDetail.Cells.Add(cellDetailCode)
        rowDetail.Cells.Add(cellDetailTitle)
        rowDetail.Cells.Add(cellDetailClass)

        If withGroupCode Then
            rowHeader.Cells.Add(cellHeaderGroup)
            rowDetail.Cells.Add(cellDetailGroup)
        End If

        If withDescription Then
            rowHeader.Cells.Add(cellHeaderDescription)
            rowDetail.Cells.Add(cellDetailDescription)
        End If

        tblHeader.Rows.Add(rowHeader)
        tblDetail.Rows.Add(rowDetail)
        tblHeader.EndInit()
        tblDetail.EndInit()

        rep.FindControl("panel_header", False).Controls.Add(tblHeader)
        rep.FindControl("panel_detail", False).Controls.Add(tblDetail)

    End Sub
    Private Sub txt_sort_by_Leave(sender As Object, e As EventArgs) Handles txt_sort_by.Leave
        Dim dt As DataTable = FsQuery("SELECT a.chart_class_id,a.chart_class_code,a.chart_class_name,a.chart_type FROM lib_acc_chart_class a UNION SELECT b.id,b.name,b.name,'' FROM ( select 'g1' as id,'Group Code' AS name UNION SELECT 'v1','Bank/Cash' union select 'v2','AR' union select 'v3','AP' union select 'v4','EWT' union select 'v5','Final Tax' union select 'v6','Input Vat' union select 'v7','Output Vat' union select 'v8','Prepayment' union select 'v9','Fixed Asset' union select 'v10','Gain or Loss' union select 'a1','All' ) b")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("chart_class_name like '{0}'", txt_sort_by.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "chart_class_code,chart_class_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_sort_by.RowData = dr
                txt_sort_by.Value = dr("chart_class_id")
                txt_sort_by.Text = dr("chart_class_name")
                If dr("chart_class_id").ToString.Contains("g") Then
                    txt_group_id.Enabled = True
                Else
                    txt_group_id.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub txt_group_id_Leave(sender As Object, e As EventArgs) Handles txt_group_id.Leave
        Dim dt As DataTable = FsQuery("SELECT * FROM lib_acc_chart_group")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("chart_group_name like '{0}'", txt_group_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "chart_group_code,chart_group_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_group_id.RowData = dr
                txt_group_id.Value = dr("chart_group_id")
                txt_group_id.Text = dr("chart_group_name")
            End If
        End If
    End Sub
    Private Sub txt_group_by_Leave(sender As Object, e As EventArgs) Handles txt_group_by.Leave
        Dim dt As DataTable = FsQuery("SELECT 'a.account_code' AS id,'Account Code' AS code,'Account Code' AS name UNION SELECT 'a.account_name','Title','Title' UNION SELECT 'b.chart_type','Account Type','Account Type' UNION SELECT 'd.chart_group_code','Group','Group'")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("name like '{0}'", txt_group_by.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "code,name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_group_by.RowData = dr
                txt_group_by.Value = dr("id")
                txt_group_by.Text = dr("name")
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub chart_report_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_sort_by.Text = "All"
        txt_sort_by_Leave(Nothing, Nothing)
        txt_group_by.Text = "Account Code"
        txt_group_by_Leave(Nothing, Nothing)
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