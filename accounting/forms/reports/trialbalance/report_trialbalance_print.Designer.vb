<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class report_trialbalance_print
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.runtime = New DevExpress.XtraReports.Parameters.Parameter()
        Me.range = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.company_logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Trial_balance_set1 = New accounting.trial_balance_set()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.account_currency = New DevExpress.XtraReports.UI.CalculatedField()
        Me.header_unit = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.header_book = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.footer_book = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.header_chart_class = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.header_chart_group = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.header_project = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.header_department = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.header_currency = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.footer_unit = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.footer_chart_class = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.footer_chart_group = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.footer_project = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.footer_department = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.footer_currency = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable8 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable9 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trial_balance_set1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 17.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.Transparent
        Me.XrTable2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable2.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(776.9998!, 17.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorderDashStyle = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell6.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[account_code]")})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBackColor = False
        Me.XrTableCell6.StylePriority.UseBorderColor = False
        Me.XrTableCell6.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell6.Weight = 0.52153211182902215R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell7.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[account_name]")})
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.StylePriority.UseBorderColor = False
        Me.XrTableCell7.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell7.Weight = 2.0113225674051516R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell8.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[debit]")})
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBackColor = False
        Me.XrTableCell8.StylePriority.UseBorderColor = False
        Me.XrTableCell8.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell8.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell8.Weight = 0.55043557979224378R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell9.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[credit]")})
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBackColor = False
        Me.XrTableCell9.StylePriority.UseBorderColor = False
        Me.XrTableCell9.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell9.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell9.Weight = 0.55043573544903657R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell10.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[chart_type]")})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBackColor = False
        Me.XrTableCell10.StylePriority.UseBorderColor = False
        Me.XrTableCell10.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell10.Weight = 0.32940964413026919R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 25.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'runtime
        '
        Me.runtime.Description = "runtime"
        Me.runtime.Name = "runtime"
        Me.runtime.Visible = False
        '
        'range
        '
        Me.range.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.range.LocationFloat = New DevExpress.Utils.PointFloat(188.5!, 39.99999!)
        Me.range.Name = "range"
        Me.range.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.range.SizeF = New System.Drawing.SizeF(400.0!, 20.0!)
        Me.range.StylePriority.UseFont = False
        Me.range.StylePriority.UsePadding = False
        Me.range.StylePriority.UseTextAlignment = False
        Me.range.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "IIF([book_name] == '','TRIAL BALANCE',[book_name])")})
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(188.5!, 20.0!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(400.0!, 20.0!)
        Me.lblTitle.StylePriority.UseFont = False
        Me.lblTitle.StylePriority.UsePadding = False
        Me.lblTitle.StylePriority.UseTextAlignment = False
        Me.lblTitle.Text = "TRIAL BALANCE"
        Me.lblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Company.tin]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(50.0!, 20.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel5.TextFormatString = "TIN {0}"
        Me.XrLabel5.Visible = False
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Company.address]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(50.0!, 20.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel4.Visible = False
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Company.company_name]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(188.5!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(400.0!, 20.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'company_logo
        '
        Me.company_logo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.company_logo.LocationFloat = New DevExpress.Utils.PointFloat(88.49992!, 0!)
        Me.company_logo.Name = "company_logo"
        Me.company_logo.SizeF = New System.Drawing.SizeF(100.0!, 50.0!)
        Me.company_logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.company_logo.Visible = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Calibri", 7.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(607.0001!, 14.99999!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 15.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UsePadding = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo1.TextFormatString = "Page No : {0} of {1}"
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters.runtime]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 7.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(657.0001!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(120.0!, 15.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 7.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(607.0001!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(50.0!, 15.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.Text = "Runtime :"
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable1.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 60.00001!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(776.9998!, 20.0!)
        Me.XrTable1.StylePriority.UseBackColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Code"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 0.36494987688275415R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Title"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell2.Weight = 1.4074529316522857R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Debit"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 0.38517560538977669R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Credit"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 0.38517560538977669R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Class"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 0.23050911489475306R
        '
        'Trial_balance_set1
        '
        Me.Trial_balance_set1.DataSetName = "trial_balance_set"
        Me.Trial_balance_set1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrTable3
        '
        Me.XrTable3.BackColor = System.Drawing.Color.Transparent
        Me.XrTable3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable3.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(776.9999!, 20.0!)
        Me.XrTable3.StylePriority.UseBackColor = False
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell12.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell12.BorderWidth = 2.0!
        Me.XrTableCell12.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBorderColor = False
        Me.XrTableCell12.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseBorderWidth = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "GRAND TOTAL : "
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell12.Weight = 2.5320043853628187R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell13.BorderWidth = 2.0!
        Me.XrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([debit])")})
        Me.XrTableCell13.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseBorderWidth = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell13.Summary = XrSummary1
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell13.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell13.Weight = 0.55043595358154984R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell14.BorderWidth = 2.0!
        Me.XrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([credit])")})
        Me.XrTableCell14.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.StylePriority.UseBorderWidth = False
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell14.Summary = XrSummary2
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell14.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell14.Weight = 0.5504357673970447R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell15.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell15.BorderWidth = 2.0!
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseBorderColor = False
        Me.XrTableCell15.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UseBorderWidth = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell15.Weight = 0.3302600955304365R
        '
        'account_currency
        '
        Me.account_currency.DataMember = "accounts"
        Me.account_currency.Expression = "CONCAT([account_name],' (',[currency_name] ,')')"
        Me.account_currency.Name = "account_currency"
        '
        'header_unit
        '
        Me.header_unit.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7})
        Me.header_unit.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("unit_name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.header_unit.HeightF = 20.0!
        Me.header_unit.Level = 5
        Me.header_unit.Name = "header_unit"
        '
        'XrLabel7
        '
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[unit_name]")})
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(777.0002!, 20.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'header_book
        '
        Me.header_book.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel1, Me.XrLabel2, Me.XrPageInfo1, Me.company_logo, Me.XrLabel3, Me.XrTable1, Me.XrLabel5, Me.lblTitle, Me.range})
        Me.header_book.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("book_name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.header_book.HeightF = 80.00002!
        Me.header_book.Level = 6
        Me.header_book.Name = "header_book"
        Me.header_book.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.header_book.RepeatEveryPage = True
        '
        'footer_book
        '
        Me.footer_book.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.footer_book.HeightF = 30.0!
        Me.footer_book.Level = 6
        Me.footer_book.Name = "footer_book"
        '
        'header_chart_class
        '
        Me.header_chart_class.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6})
        Me.header_chart_class.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("chart_class_name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.header_chart_class.HeightF = 20.1389!
        Me.header_chart_class.Level = 4
        Me.header_chart_class.Name = "header_chart_class"
        '
        'XrLabel6
        '
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[chart_class_name]")})
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(777.0002!, 20.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'header_chart_group
        '
        Me.header_chart_group.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8})
        Me.header_chart_group.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("chart_group_name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.header_chart_group.HeightF = 20.0!
        Me.header_chart_group.Level = 3
        Me.header_chart_group.Name = "header_chart_group"
        '
        'header_project
        '
        Me.header_project.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9})
        Me.header_project.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("project_name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.header_project.HeightF = 20.0!
        Me.header_project.Level = 2
        Me.header_project.Name = "header_project"
        '
        'header_department
        '
        Me.header_department.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10})
        Me.header_department.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("department_name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.header_department.HeightF = 20.0!
        Me.header_department.Level = 1
        Me.header_department.Name = "header_department"
        '
        'header_currency
        '
        Me.header_currency.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11})
        Me.header_currency.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("currency_name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.header_currency.HeightF = 20.0!
        Me.header_currency.Name = "header_currency"
        '
        'XrLabel8
        '
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[chart_group_name]")})
        Me.XrLabel8.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(777.0002!, 20.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[project_name]")})
        Me.XrLabel9.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(777.0002!, 20.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[department_name]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(777.0002!, 20.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[currency_name]")})
        Me.XrLabel11.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(777.0002!, 20.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'footer_unit
        '
        Me.footer_unit.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable9})
        Me.footer_unit.HeightF = 20.0!
        Me.footer_unit.Level = 5
        Me.footer_unit.Name = "footer_unit"
        '
        'footer_chart_class
        '
        Me.footer_chart_class.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable8})
        Me.footer_chart_class.HeightF = 20.0!
        Me.footer_chart_class.Level = 4
        Me.footer_chart_class.Name = "footer_chart_class"
        '
        'footer_chart_group
        '
        Me.footer_chart_group.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable7})
        Me.footer_chart_group.HeightF = 20.0!
        Me.footer_chart_group.Level = 3
        Me.footer_chart_group.Name = "footer_chart_group"
        '
        'footer_project
        '
        Me.footer_project.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6})
        Me.footer_project.HeightF = 20.0!
        Me.footer_project.Level = 2
        Me.footer_project.Name = "footer_project"
        '
        'footer_department
        '
        Me.footer_department.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.footer_department.HeightF = 20.0!
        Me.footer_department.Level = 1
        Me.footer_department.Name = "footer_department"
        '
        'footer_currency
        '
        Me.footer_currency.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.footer_currency.HeightF = 20.0!
        Me.footer_currency.Name = "footer_currency"
        '
        'XrTable4
        '
        Me.XrTable4.BackColor = System.Drawing.Color.Transparent
        Me.XrTable4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable4.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(776.9999!, 20.0!)
        Me.XrTable4.StylePriority.UseBackColor = False
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell11.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.BorderWidth = 1.0!
        Me.XrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[currency_name]")})
        Me.XrTableCell11.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell11.StylePriority.UseBorderColor = False
        Me.XrTableCell11.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseBorderWidth = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell11.TextFormatString = "SUB-TOTAL:{0}"
        Me.XrTableCell11.Weight = 2.5320043853628187R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell16.BorderWidth = 1.0!
        Me.XrTableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([debit])")})
        Me.XrTableCell16.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.StylePriority.UseBorderWidth = False
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell16.Summary = XrSummary13
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell16.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell16.Weight = 0.55043595358154984R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell17.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell17.BorderWidth = 1.0!
        Me.XrTableCell17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([credit])")})
        Me.XrTableCell17.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseBorderWidth = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell17.Summary = XrSummary14
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell17.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell17.Weight = 0.5504357673970447R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell18.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell18.BorderWidth = 1.0!
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBorderColor = False
        Me.XrTableCell18.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseBorderWidth = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell18.Weight = 0.3302600955304365R
        '
        'XrTable5
        '
        Me.XrTable5.BackColor = System.Drawing.Color.Transparent
        Me.XrTable5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable5.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(776.9999!, 20.0!)
        Me.XrTable5.StylePriority.UseBackColor = False
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell19.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell19.BorderWidth = 1.0!
        Me.XrTableCell19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[department_name]")})
        Me.XrTableCell19.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell19.StylePriority.UseBorderColor = False
        Me.XrTableCell19.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.StylePriority.UseBorderWidth = False
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UsePadding = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell19.TextFormatString = "SUB-TOTAL:{0}"
        Me.XrTableCell19.Weight = 2.5320043853628187R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell20.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell20.BorderWidth = 1.0!
        Me.XrTableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([debit])")})
        Me.XrTableCell20.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.StylePriority.UseBorderWidth = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell20.Summary = XrSummary11
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell20.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell20.Weight = 0.55043595358154984R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell21.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell21.BorderWidth = 1.0!
        Me.XrTableCell21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([credit])")})
        Me.XrTableCell21.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseBorderWidth = False
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell21.Summary = XrSummary12
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell21.Weight = 0.5504357673970447R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell22.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell22.BorderWidth = 1.0!
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBorderColor = False
        Me.XrTableCell22.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.StylePriority.UseBorderWidth = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell22.Weight = 0.3302600955304365R
        '
        'XrTable6
        '
        Me.XrTable6.BackColor = System.Drawing.Color.Transparent
        Me.XrTable6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable6.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(776.9999!, 20.0!)
        Me.XrTable6.StylePriority.UseBackColor = False
        Me.XrTable6.StylePriority.UseBorders = False
        Me.XrTable6.StylePriority.UseFont = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell23.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell23.BorderWidth = 1.0!
        Me.XrTableCell23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[project_name]")})
        Me.XrTableCell23.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell23.StylePriority.UseBorderColor = False
        Me.XrTableCell23.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.StylePriority.UseBorderWidth = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UsePadding = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell23.TextFormatString = "SUB-TOTAL:{0}"
        Me.XrTableCell23.Weight = 2.5320043853628187R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell24.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell24.BorderWidth = 1.0!
        Me.XrTableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([debit])")})
        Me.XrTableCell24.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell24.StylePriority.UseBorders = False
        Me.XrTableCell24.StylePriority.UseBorderWidth = False
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell24.Summary = XrSummary9
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell24.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell24.Weight = 0.55043595358154984R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell25.BorderWidth = 1.0!
        Me.XrTableCell25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([credit])")})
        Me.XrTableCell25.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell25.StylePriority.UseBorders = False
        Me.XrTableCell25.StylePriority.UseBorderWidth = False
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell25.Summary = XrSummary10
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell25.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell25.Weight = 0.5504357673970447R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell26.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell26.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell26.BorderWidth = 1.0!
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseBorderColor = False
        Me.XrTableCell26.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell26.StylePriority.UseBorders = False
        Me.XrTableCell26.StylePriority.UseBorderWidth = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell26.Weight = 0.3302600955304365R
        '
        'XrTable7
        '
        Me.XrTable7.BackColor = System.Drawing.Color.Transparent
        Me.XrTable7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable7.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(776.9999!, 20.0!)
        Me.XrTable7.StylePriority.UseBackColor = False
        Me.XrTable7.StylePriority.UseBorders = False
        Me.XrTable7.StylePriority.UseFont = False
        Me.XrTable7.StylePriority.UseTextAlignment = False
        Me.XrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell27.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell27.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell27.BorderWidth = 1.0!
        Me.XrTableCell27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[chart_group_name]")})
        Me.XrTableCell27.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell27.StylePriority.UseBorderColor = False
        Me.XrTableCell27.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell27.StylePriority.UseBorders = False
        Me.XrTableCell27.StylePriority.UseBorderWidth = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UsePadding = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell27.TextFormatString = "SUB-TOTAL:{0}"
        Me.XrTableCell27.Weight = 2.5320043853628187R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell28.BorderWidth = 1.0!
        Me.XrTableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([debit])")})
        Me.XrTableCell28.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UseBorderWidth = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell28.Summary = XrSummary7
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell28.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell28.Weight = 0.55043595358154984R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell29.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell29.BorderWidth = 1.0!
        Me.XrTableCell29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([credit])")})
        Me.XrTableCell29.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell29.StylePriority.UseBorders = False
        Me.XrTableCell29.StylePriority.UseBorderWidth = False
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell29.Summary = XrSummary8
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell29.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell29.Weight = 0.5504357673970447R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell30.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell30.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell30.BorderWidth = 1.0!
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseBorderColor = False
        Me.XrTableCell30.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell30.StylePriority.UseBorders = False
        Me.XrTableCell30.StylePriority.UseBorderWidth = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell30.Weight = 0.3302600955304365R
        '
        'XrTable8
        '
        Me.XrTable8.BackColor = System.Drawing.Color.Transparent
        Me.XrTable8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable8.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable8.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.XrTable8.Name = "XrTable8"
        Me.XrTable8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable8.SizeF = New System.Drawing.SizeF(776.9999!, 20.0!)
        Me.XrTable8.StylePriority.UseBackColor = False
        Me.XrTable8.StylePriority.UseBorders = False
        Me.XrTable8.StylePriority.UseFont = False
        Me.XrTable8.StylePriority.UseTextAlignment = False
        Me.XrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33, Me.XrTableCell34})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell31.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell31.BorderWidth = 1.0!
        Me.XrTableCell31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[chart_class_name]")})
        Me.XrTableCell31.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell31.StylePriority.UseBorderColor = False
        Me.XrTableCell31.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell31.StylePriority.UseBorders = False
        Me.XrTableCell31.StylePriority.UseBorderWidth = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UsePadding = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell31.TextFormatString = "SUB-TOTAL:{0}"
        Me.XrTableCell31.Weight = 2.5320043853628187R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell32.BorderWidth = 1.0!
        Me.XrTableCell32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([debit])")})
        Me.XrTableCell32.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell32.StylePriority.UseBorders = False
        Me.XrTableCell32.StylePriority.UseBorderWidth = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UseTextAlignment = False
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell32.Summary = XrSummary5
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell32.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell32.Weight = 0.55043595358154984R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell33.BorderWidth = 1.0!
        Me.XrTableCell33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([credit])")})
        Me.XrTableCell33.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell33.StylePriority.UseBorders = False
        Me.XrTableCell33.StylePriority.UseBorderWidth = False
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell33.Summary = XrSummary6
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell33.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell33.Weight = 0.5504357673970447R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell34.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell34.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell34.BorderWidth = 1.0!
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseBorderColor = False
        Me.XrTableCell34.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell34.StylePriority.UseBorders = False
        Me.XrTableCell34.StylePriority.UseBorderWidth = False
        Me.XrTableCell34.StylePriority.UseTextAlignment = False
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell34.Weight = 0.3302600955304365R
        '
        'XrTable9
        '
        Me.XrTable9.BackColor = System.Drawing.Color.Transparent
        Me.XrTable9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable9.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable9.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.XrTable9.Name = "XrTable9"
        Me.XrTable9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9})
        Me.XrTable9.SizeF = New System.Drawing.SizeF(776.9999!, 20.0!)
        Me.XrTable9.StylePriority.UseBackColor = False
        Me.XrTable9.StylePriority.UseBorders = False
        Me.XrTable9.StylePriority.UseFont = False
        Me.XrTable9.StylePriority.UseTextAlignment = False
        Me.XrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell35, Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell38})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell35.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell35.BorderWidth = 1.0!
        Me.XrTableCell35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[unit_name]")})
        Me.XrTableCell35.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell35.StylePriority.UseBorderColor = False
        Me.XrTableCell35.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell35.StylePriority.UseBorders = False
        Me.XrTableCell35.StylePriority.UseBorderWidth = False
        Me.XrTableCell35.StylePriority.UseFont = False
        Me.XrTableCell35.StylePriority.UsePadding = False
        Me.XrTableCell35.StylePriority.UseTextAlignment = False
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell35.TextFormatString = "SUB-TOTAL:{0}"
        Me.XrTableCell35.Weight = 2.5320043853628187R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell36.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell36.BorderWidth = 1.0!
        Me.XrTableCell36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([debit])")})
        Me.XrTableCell36.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell36.StylePriority.UseBorders = False
        Me.XrTableCell36.StylePriority.UseBorderWidth = False
        Me.XrTableCell36.StylePriority.UseFont = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell36.Summary = XrSummary3
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell36.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell36.Weight = 0.55043595358154984R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell37.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell37.BorderWidth = 1.0!
        Me.XrTableCell37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([credit])")})
        Me.XrTableCell37.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell37.StylePriority.UseBorders = False
        Me.XrTableCell37.StylePriority.UseBorderWidth = False
        Me.XrTableCell37.StylePriority.UseFont = False
        Me.XrTableCell37.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell37.Summary = XrSummary4
        Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell37.TextFormatString = "{0:#,##0.00}"
        Me.XrTableCell37.Weight = 0.5504357673970447R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell38.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell38.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell38.BorderWidth = 1.0!
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StylePriority.UseBorderColor = False
        Me.XrTableCell38.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell38.StylePriority.UseBorders = False
        Me.XrTableCell38.StylePriority.UseBorderWidth = False
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell38.Weight = 0.3302600955304365R
        '
        'report_trialbalance_print
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.header_unit, Me.header_book, Me.footer_book, Me.header_chart_class, Me.header_chart_group, Me.header_project, Me.header_department, Me.header_currency, Me.footer_unit, Me.footer_chart_class, Me.footer_chart_group, Me.footer_project, Me.footer_department, Me.footer_currency})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.account_currency})
        Me.DataMember = "accounts"
        Me.DataSource = Me.Trial_balance_set1
        Me.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.runtime})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Version = "17.2"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trial_balance_set1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents runtime As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents company_logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Trial_balance_set1 As accounting.trial_balance_set
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents account_currency As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents header_unit As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents range As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents header_book As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents footer_book As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents header_chart_class As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents header_chart_group As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents header_project As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents header_department As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents header_currency As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents footer_unit As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents footer_chart_class As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents footer_chart_group As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents footer_project As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents footer_department As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents footer_currency As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable9 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
End Class
