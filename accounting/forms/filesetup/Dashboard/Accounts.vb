Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class Accounts
    Dim ds2 As New FileSetupSet
    Dim dbTable As String = "lib_erp_chart"
    Dim isloaded As Boolean = False

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain4.SelectionChanged
        Dim dt As DataTable = ds2.Tables(dbTable)
        bind_control(dgMain4, "account_id", dt, Me)
        Dim dt_ewt As DataTable = FsQuery("SELECT b.chart_group_id AS group_id,b.chart_group_code,b.chart_group_name,a.chart_group_id FROM lib_erp_chart_group a LEFT JOIN lib_acc_chart_group b ON b.chart_group_id = a.group_id WHERE a.account_id = " & primary_key.Text)
        ds2.Tables("lib_acc_chart_group").Clear()
        For Each row As DataRow In dt_ewt.Rows
            ds2.Tables("lib_acc_chart_group").ImportRow(row)
        Next
    End Sub

    Private Sub loadAccounts()
        isloaded = True
        dgMain4.AutoGenerateColumns = False
        Dim sql = "SELECT a.*,b.chart_class_name FROM lib_erp_chart a LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id ORDER BY account_code"
        Dim dt As DataTable = FsQuery(sql)
        ds2.Tables(dbTable).Clear()
        For Each row As DataRow In dt.Rows
            ds2.Tables(dbTable).ImportRow(row)
        Next
        dgMain4.DataSource = ds2.Tables(dbTable)
    End Sub

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isloaded Then
            loadAccounts()
        End If
        Me.Location = New Drawing.Point(625, 400)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim sql As String = "SELECT a.account_id,a.account_code,a.account_name,a.description,b.chart_type,d.chart_group_code FROM lib_erp_chart a LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id LEFT JOIN lib_erp_chart_group c ON c.account_id = a.account_id LEFT JOIN lib_acc_chart_group d ON d.chart_group_id = c.group_id"
        Dim withDescription As Boolean = chart_report_filter.chk_description.Checked
        Dim withGroupCode As Boolean = chart_report_filter.chk_group_code.Checked
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
        sql = String.Format("SELECT company_name FROM lib_erp_company WHERE company_id = {0}", main.Sys_Default.Rows(0).Item("company_id"))
        dt = FsQuery(sql)

        Dim rep As New chart_report_print
        rep.DataSource = ds
        rep.DataMember = (CType(rep.DataSource, DataSet)).Tables(0).TableName
        printCOA(rep, withDescription, withGroupCode)
        rep.Parameters("rundate").Value = System.DateTime.Now.ToString("MMMM dd, yyyy")
        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("HH:mm:ss")
        rep.Parameters("company_name").Value = dt.Rows(0).Item("company_name")
        reportviewer.DocumentViewer1.DocumentSource = rep
        reportviewer.ShowDialog()
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

        cellHeaderCode.Text = "ACCOUNT CODE"
        cellHeaderCode.WidthF = 100
        cellHeaderTitle.Text = "ACCOUNT TITLE"
        cellHeaderTitle.WidthF = 200
        cellHeaderClass.Text = "CLASS"
        cellHeaderGroup.Text = "GROUP"
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
End Class