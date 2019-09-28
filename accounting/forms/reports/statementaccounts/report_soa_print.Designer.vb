<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class report_soa_print
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MySqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter7 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter8 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter9 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter10 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter11 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter12 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter13 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter14 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter15 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter16 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter17 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter18 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_soa_print))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter3 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter4 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter5 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter6 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter7 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter8 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter9 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter10 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter11 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter12 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter13 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter14 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter15 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter16 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter17 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter18 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLine1})
        Me.Detail.HeightF = 33.00001!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_erp_accounting_gwapingz_Connection"
        MySqlConnectionParameters1.DatabaseName = "erp_accounting_gwapingz"
        MySqlConnectionParameters1.ServerName = "localhost"
        Me.SqlDataSource1.ConnectionParameters = MySqlConnectionParameters1
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "erp_accounting_gwapingz_report_soa_print"
        QueryParameter1.Name = "@dbFS"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter1]", GetType(String))
        QueryParameter2.Name = "@dbMain"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter2]", GetType(String))
        QueryParameter3.Name = "@accountIDS"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter3]", GetType(String))
        QueryParameter4.Name = "@generalIDS"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter4]", GetType(String))
        QueryParameter5.Name = "@bookIDS"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter5]", GetType(String))
        QueryParameter6.Name = "@account"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter6]", GetType(String))
        QueryParameter7.Name = "@general"
        QueryParameter7.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter7.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter7]", GetType(String))
        QueryParameter8.Name = "@currency"
        QueryParameter8.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter8.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter8]", GetType(String))
        QueryParameter9.Name = "@date_from"
        QueryParameter9.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter9.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter9]", GetType(String))
        QueryParameter10.Name = "@date_to"
        QueryParameter10.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter10.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter10]", GetType(String))
        QueryParameter11.Name = "@account_id"
        QueryParameter11.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter11.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter11]", GetType(String))
        QueryParameter12.Name = "@general_id"
        QueryParameter12.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter12.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter12]", GetType(String))
        QueryParameter13.Name = "@currency_id"
        QueryParameter13.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter13.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter13]", GetType(String))
        QueryParameter14.Name = "@project_id"
        QueryParameter14.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter14.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter14]", GetType(String))
        QueryParameter15.Name = "@department_id"
        QueryParameter15.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter15.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter15]", GetType(String))
        QueryParameter16.Name = "@toDate"
        QueryParameter16.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter16.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter16]", GetType(SByte))
        QueryParameter17.Name = "@withComparison"
        QueryParameter17.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter17.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter17]", GetType(SByte))
        QueryParameter18.Name = "@withProjectDepartment"
        QueryParameter18.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter18.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter18]", GetType(SByte))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.Parameters.Add(QueryParameter5)
        StoredProcQuery1.Parameters.Add(QueryParameter6)
        StoredProcQuery1.Parameters.Add(QueryParameter7)
        StoredProcQuery1.Parameters.Add(QueryParameter8)
        StoredProcQuery1.Parameters.Add(QueryParameter9)
        StoredProcQuery1.Parameters.Add(QueryParameter10)
        StoredProcQuery1.Parameters.Add(QueryParameter11)
        StoredProcQuery1.Parameters.Add(QueryParameter12)
        StoredProcQuery1.Parameters.Add(QueryParameter13)
        StoredProcQuery1.Parameters.Add(QueryParameter14)
        StoredProcQuery1.Parameters.Add(QueryParameter15)
        StoredProcQuery1.Parameters.Add(QueryParameter16)
        StoredProcQuery1.Parameters.Add(QueryParameter17)
        StoredProcQuery1.Parameters.Add(QueryParameter18)
        StoredProcQuery1.StoredProcName = "erp_accounting_gwapingz.report_soa_print"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 3.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.PageFooterBand1.HeightF = 29.0!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3})
        Me.ReportHeaderBand1.HeightF = 51.0!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(638.0!, 33.0!)
        Me.XrLabel3.StyleName = "Title"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        '
        'parameter1
        '
        Me.parameter1.Description = "dbFS"
        Me.parameter1.Name = "parameter1"
        Me.parameter1.ValueInfo = "erp_file_setup_accounting_gwapingz"
        Me.parameter1.Visible = False
        '
        'parameter2
        '
        Me.parameter2.Description = "dbMain"
        Me.parameter2.Name = "parameter2"
        Me.parameter2.ValueInfo = "erp_accounting_gwapingz"
        Me.parameter2.Visible = False
        '
        'parameter3
        '
        Me.parameter3.Description = "accountIDS"
        Me.parameter3.Name = "parameter3"
        Me.parameter3.Visible = False
        '
        'parameter4
        '
        Me.parameter4.Description = "generalIDS"
        Me.parameter4.Name = "parameter4"
        Me.parameter4.Visible = False
        '
        'parameter5
        '
        Me.parameter5.Description = "bookIDS"
        Me.parameter5.Name = "parameter5"
        Me.parameter5.ValueInfo = "1,2"
        Me.parameter5.Visible = False
        '
        'parameter6
        '
        Me.parameter6.Description = "account"
        Me.parameter6.Name = "parameter6"
        Me.parameter6.Visible = False
        '
        'parameter7
        '
        Me.parameter7.Description = "general"
        Me.parameter7.Name = "parameter7"
        Me.parameter7.Visible = False
        '
        'parameter8
        '
        Me.parameter8.Description = "currency"
        Me.parameter8.Name = "parameter8"
        Me.parameter8.Visible = False
        '
        'parameter9
        '
        Me.parameter9.Description = "date_from"
        Me.parameter9.Name = "parameter9"
        Me.parameter9.ValueInfo = "2017-01-01"
        Me.parameter9.Visible = False
        '
        'parameter10
        '
        Me.parameter10.Description = "date_to"
        Me.parameter10.Name = "parameter10"
        Me.parameter10.ValueInfo = "2017-01-31"
        Me.parameter10.Visible = False
        '
        'parameter11
        '
        Me.parameter11.Description = "account_id"
        Me.parameter11.Name = "parameter11"
        Me.parameter11.Visible = False
        '
        'parameter12
        '
        Me.parameter12.Description = "general_id"
        Me.parameter12.Name = "parameter12"
        Me.parameter12.Visible = False
        '
        'parameter13
        '
        Me.parameter13.Description = "currency_id"
        Me.parameter13.Name = "parameter13"
        Me.parameter13.Visible = False
        '
        'parameter14
        '
        Me.parameter14.Description = "project_id"
        Me.parameter14.Name = "parameter14"
        Me.parameter14.Visible = False
        '
        'parameter15
        '
        Me.parameter15.Description = "department_id"
        Me.parameter15.Name = "parameter15"
        Me.parameter15.Visible = False
        '
        'parameter16
        '
        Me.parameter16.Description = "toDate"
        Me.parameter16.Name = "parameter16"
        Me.parameter16.Type = GetType(SByte)
        Me.parameter16.ValueInfo = "0"
        Me.parameter16.Visible = False
        '
        'parameter17
        '
        Me.parameter17.Description = "withComparison"
        Me.parameter17.Name = "parameter17"
        Me.parameter17.Type = GetType(SByte)
        Me.parameter17.ValueInfo = "0"
        Me.parameter17.Visible = False
        '
        'parameter18
        '
        Me.parameter18.Description = "withProjectDepartment"
        Me.parameter18.Name = "parameter18"
        Me.parameter18.Type = GetType(SByte)
        Me.parameter18.ValueInfo = "0"
        Me.parameter18.Visible = False
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "erp_accounting_gwapingz_report_soa_print.trans_no")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'report_soa_print
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooterBand1, Me.ReportHeaderBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "erp_accounting_gwapingz_report_soa_print"
        Me.DataSource = Me.SqlDataSource1
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parameter1, Me.parameter2, Me.parameter3, Me.parameter4, Me.parameter5, Me.parameter6, Me.parameter7, Me.parameter8, Me.parameter9, Me.parameter10, Me.parameter11, Me.parameter12, Me.parameter13, Me.parameter14, Me.parameter15, Me.parameter16, Me.parameter17, Me.parameter18})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents parameter1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter3 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter4 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter5 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter6 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter7 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter8 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter9 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter10 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter11 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter12 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter13 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter14 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter15 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter16 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter17 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents parameter18 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
