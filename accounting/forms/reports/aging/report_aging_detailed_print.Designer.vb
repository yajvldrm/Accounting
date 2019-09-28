<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class report_aging_detailed_print
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
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.detailRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailBased = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailOriginal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.panel_detail = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.runtime = New DevExpress.XtraReports.Parameters.Parameter()
        Me.name = New DevExpress.XtraReports.Parameters.Parameter()
        Me.title = New DevExpress.XtraReports.Parameters.Parameter()
        Me.daterange = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.company_logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.headerRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.columnNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.columnName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.headerBased = New DevExpress.XtraReports.UI.XRTableCell()
        Me.headerOriginal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.panel_header = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.panelPercentage = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.footer3Row = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.footer3Based = New DevExpress.XtraReports.UI.XRTableCell()
        Me.footer3Original = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.panel_grand_total = New DevExpress.XtraReports.UI.XRPanel()
        Me.Agingset1 = New accounting.agingset()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader4 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.footer2Row = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.footer2Based = New DevExpress.XtraReports.UI.XRTableCell()
        Me.footer2Original = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.panel_footer_2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.footer1Row = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.footer1Based = New DevExpress.XtraReports.UI.XRTableCell()
        Me.footer1Original = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.panel_footer_1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupFooter4 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupHeader5 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.last_day = New DevExpress.XtraReports.Parameters.Parameter()
        Me.col_prefix = New DevExpress.XtraReports.Parameters.Parameter()
        Me.GroupHeader6 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter5 = New DevExpress.XtraReports.UI.GroupFooterBand()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agingset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 17.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseTextAlignment = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.Black
        Me.XrTable2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable2.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.detailRow})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1119.0!, 17.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorderDashStyle = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'detailRow
        '
        Me.detailRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.detailBased, Me.detailOriginal, Me.XrTableCell11, Me.XrTableCell12})
        Me.detailRow.Name = "detailRow"
        Me.detailRow.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[trans_no]")})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorderColor = False
        Me.XrTableCell6.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell6.Weight = 0.62555838853352863R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[trans_date]")})
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBorderColor = False
        Me.XrTableCell7.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.TextFormatString = "{0:MM/dd/yyyy}"
        Me.XrTableCell7.Weight = 0.43789108548057792R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[description]")})
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorderColor = False
        Me.XrTableCell8.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell8.Weight = 1.1197493808190009R
        '
        'detailBased
        '
        Me.detailBased.BorderColor = System.Drawing.Color.Black
        Me.detailBased.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.detailBased.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.detailBased.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount_based]")})
        Me.detailBased.Name = "detailBased"
        Me.detailBased.StylePriority.UseBorderColor = False
        Me.detailBased.StylePriority.UseBorderDashStyle = False
        Me.detailBased.StylePriority.UseBorders = False
        Me.detailBased.StylePriority.UseTextAlignment = False
        Me.detailBased.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.detailBased.TextFormatString = "{0:#,##0.00}"
        Me.detailBased.Weight = 0.62555893847533439R
        '
        'detailOriginal
        '
        Me.detailOriginal.BorderColor = System.Drawing.Color.Black
        Me.detailOriginal.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.detailOriginal.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.detailOriginal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[amount]")})
        Me.detailOriginal.Name = "detailOriginal"
        Me.detailOriginal.StylePriority.UseBorderColor = False
        Me.detailOriginal.StylePriority.UseBorderDashStyle = False
        Me.detailOriginal.StylePriority.UseBorders = False
        Me.detailOriginal.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.detailOriginal.Summary = XrSummary1
        Me.detailOriginal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.detailOriginal.TextFormatString = "{0:#,##0.00}"
        Me.detailOriginal.Weight = 0.62555871591440015R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel_detail})
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.Weight = 3.1277926139278049R
        '
        'panel_detail
        '
        Me.panel_detail.BorderColor = System.Drawing.Color.Black
        Me.panel_detail.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.panel_detail.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.panel_detail.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.panel_detail.Name = "panel_detail"
        Me.panel_detail.SizeF = New System.Drawing.SizeF(499.9999!, 17.00001!)
        Me.panel_detail.StylePriority.UseBorderColor = False
        Me.panel_detail.StylePriority.UseBorderDashStyle = False
        Me.panel_detail.StylePriority.UseBorders = False
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[account_code]")})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBorderColor = False
        Me.XrTableCell12.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell12.Weight = 0.43789087684935346R
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
        'name
        '
        Me.name.Description = "name"
        Me.name.Name = "name"
        Me.name.Visible = False
        '
        'title
        '
        Me.title.Description = "title"
        Me.title.Name = "title"
        Me.title.Visible = False
        '
        'daterange
        '
        Me.daterange.Description = "daterange"
        Me.daterange.Name = "daterange"
        Me.daterange.Visible = False
        '
        'XrLabel7
        '
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters.daterange]")})
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(309.5!, 60.00003!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(500.0!, 20.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 7.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(949.0001!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(50.0!, 15.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.Text = "Runtime :"
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters.runtime]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 7.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(999.0001!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(120.0!, 15.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Calibri", 7.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(949.0001!, 14.99999!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 15.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UsePadding = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo1.TextFormatString = "Page No : {0} of {1}"
        '
        'company_logo
        '
        Me.company_logo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.company_logo.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 0!)
        Me.company_logo.Name = "company_logo"
        Me.company_logo.SizeF = New System.Drawing.SizeF(100.0!, 50.0!)
        Me.company_logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Company.company_name]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(309.5!, 20.00002!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(500.0!, 20.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Company.address]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel4.Visible = False
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Company.tin]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.00002!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel5.TextFormatString = "TIN: {0}"
        Me.XrLabel5.Visible = False
        '
        'XrLabel6
        '
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters.name]")})
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(309.5!, 40.00002!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(500.0!, 20.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.XrTable1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 80.00003!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.headerRow})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1119.0!, 40.00001!)
        Me.XrTable1.StylePriority.UseBackColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'headerRow
        '
        Me.headerRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.columnNo, Me.columnName, Me.XrTableCell3, Me.headerBased, Me.headerOriginal, Me.XrTableCell2, Me.XrTableCell4})
        Me.headerRow.Name = "headerRow"
        Me.headerRow.Weight = 1.0R
        '
        'columnNo
        '
        Me.columnNo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.columnNo.Name = "columnNo"
        Me.columnNo.StylePriority.UseBorders = False
        Me.columnNo.Text = "Bill No."
        Me.columnNo.Weight = 0.032956935333564162R
        '
        'columnName
        '
        Me.columnName.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.columnName.Name = "columnName"
        Me.columnName.StylePriority.UseBorders = False
        Me.columnName.Text = "Date"
        Me.columnName.Weight = 0.023069855263822818R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.Text = "Particulars"
        Me.XrTableCell3.Weight = 0.05899291497042889R
        '
        'headerBased
        '
        Me.headerBased.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.headerBased.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Concat('TOTAL IN ',[Company.currency_name])")})
        Me.headerBased.Name = "headerBased"
        Me.headerBased.StylePriority.UseBorders = False
        Me.headerBased.Weight = 0.032956934397867656R
        '
        'headerOriginal
        '
        Me.headerOriginal.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.headerOriginal.Name = "headerOriginal"
        Me.headerOriginal.StylePriority.UseBorders = False
        Me.headerOriginal.Text = "Total in Based Currency"
        Me.headerOriginal.Weight = 0.032956934397867656R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel_header})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.Weight = 0.16478467007291209R
        '
        'panel_header
        '
        Me.panel_header.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.panel_header.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.SizeF = New System.Drawing.SizeF(500.0!, 40.00002!)
        Me.panel_header.StylePriority.UseBorders = False
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.Text = "Code"
        Me.XrTableCell4.Weight = 0.023069934085658994R
        '
        'XrTable6
        '
        Me.XrTable6.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 30.0!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(1119.0!, 20.0!)
        Me.XrTable6.StylePriority.UseFont = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell10, Me.XrTableCell14})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.BorderWidth = 2.0!
        Me.XrTableCell1.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseBorderWidth = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "PERCENTAGE :"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 2.1831992916557743R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell10.BorderWidth = 2.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseBorderWidth = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,##0.00}"
        Me.XrTableCell10.Summary = XrSummary2
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell10.Weight = 1.2511192054801354R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell14.BorderWidth = 2.0!
        Me.XrTableCell14.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panelPercentage})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.StylePriority.UseBorderWidth = False
        Me.XrTableCell14.Weight = 3.56568343749632R
        '
        'panelPercentage
        '
        Me.panelPercentage.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.panelPercentage.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.panelPercentage.BorderWidth = 2.0!
        Me.panelPercentage.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.panelPercentage.Name = "panelPercentage"
        Me.panelPercentage.SizeF = New System.Drawing.SizeF(499.9992!, 20.0!)
        Me.panelPercentage.StylePriority.UseBorderDashStyle = False
        Me.panelPercentage.StylePriority.UseBorders = False
        Me.panelPercentage.StylePriority.UseBorderWidth = False
        '
        'XrTable5
        '
        Me.XrTable5.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.footer3Row})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(1119.0!, 20.0!)
        Me.XrTable5.StylePriority.UseFont = False
        '
        'footer3Row
        '
        Me.footer3Row.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.footer3Based, Me.footer3Original, Me.XrTableCell17})
        Me.footer3Row.Name = "footer3Row"
        Me.footer3Row.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.BorderWidth = 2.0!
        Me.XrTableCell9.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseBorderWidth = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "GRAND TOTAL : "
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.61526481264913735R
        '
        'footer3Based
        '
        Me.footer3Based.BackColor = System.Drawing.Color.Transparent
        Me.footer3Based.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.footer3Based.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.footer3Based.BorderWidth = 2.0!
        Me.footer3Based.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([amount_based])")})
        Me.footer3Based.Name = "footer3Based"
        Me.footer3Based.StylePriority.UseBackColor = False
        Me.footer3Based.StylePriority.UseBorderDashStyle = False
        Me.footer3Based.StylePriority.UseBorders = False
        Me.footer3Based.StylePriority.UseBorderWidth = False
        Me.footer3Based.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.footer3Based.Summary = XrSummary3
        Me.footer3Based.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.footer3Based.TextFormatString = "{0:#,##0.00}"
        Me.footer3Based.Weight = 0.17629390863874567R
        '
        'footer3Original
        '
        Me.footer3Original.BackColor = System.Drawing.Color.Transparent
        Me.footer3Original.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.footer3Original.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.footer3Original.BorderWidth = 2.0!
        Me.footer3Original.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([amount])")})
        Me.footer3Original.Name = "footer3Original"
        Me.footer3Original.StylePriority.UseBackColor = False
        Me.footer3Original.StylePriority.UseBorderDashStyle = False
        Me.footer3Original.StylePriority.UseBorders = False
        Me.footer3Original.StylePriority.UseBorderWidth = False
        Me.footer3Original.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.footer3Original.Summary = XrSummary4
        Me.footer3Original.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.footer3Original.TextFormatString = "{0:#,##0.00}"
        Me.footer3Original.Weight = 0.17629439284382725R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell17.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell17.BorderWidth = 2.0!
        Me.XrTableCell17.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel_grand_total})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseBorderWidth = False
        Me.XrTableCell17.Weight = 1.0048732788440768R
        '
        'panel_grand_total
        '
        Me.panel_grand_total.BackColor = System.Drawing.Color.Transparent
        Me.panel_grand_total.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.panel_grand_total.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.panel_grand_total.BorderWidth = 1.0!
        Me.panel_grand_total.LocationFloat = New DevExpress.Utils.PointFloat(0.0004272461!, 0.00003814697!)
        Me.panel_grand_total.Name = "panel_grand_total"
        Me.panel_grand_total.SizeF = New System.Drawing.SizeF(499.9988!, 19.99996!)
        Me.panel_grand_total.StylePriority.UseBackColor = False
        Me.panel_grand_total.StylePriority.UseBorderDashStyle = False
        Me.panel_grand_total.StylePriority.UseBorders = False
        Me.panel_grand_total.StylePriority.UseBorderWidth = False
        '
        'Agingset1
        '
        Me.Agingset1.DataSetName = "agingset"
        Me.Agingset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("general_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 20.0!
        Me.GroupHeader1.Level = 3
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[general_name]")})
        Me.XrLabel12.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(1119.0!, 20.0!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UsePadding = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("currency_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 20.00001!
        Me.GroupHeader2.Level = 2
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.Visible = False
        '
        'XrLabel9
        '
        Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[currency_name]")})
        Me.XrLabel9.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(1069.0!, 20.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UsePadding = False
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10})
        Me.GroupHeader3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("project_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader3.HeightF = 20.00001!
        Me.GroupHeader3.Level = 1
        Me.GroupHeader3.Name = "GroupHeader3"
        Me.GroupHeader3.Visible = False
        '
        'XrLabel10
        '
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[project_name]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(99.99997!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(1019.0!, 20.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UsePadding = False
        '
        'GroupHeader4
        '
        Me.GroupHeader4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11})
        Me.GroupHeader4.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("department_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader4.HeightF = 20.0!
        Me.GroupHeader4.Name = "GroupHeader4"
        Me.GroupHeader4.Visible = False
        '
        'XrLabel11
        '
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[department_name]")})
        Me.XrLabel11.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(969.0001!, 20.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UsePadding = False
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.XrTable4})
        Me.GroupFooter1.HeightF = 31.25!
        Me.GroupFooter1.Level = 3
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel13
        '
        Me.XrLabel13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel13.BorderWidth = 3.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.00001!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(1119.0!, 4.999987!)
        Me.XrLabel13.StylePriority.UseBorderDashStyle = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseBorderWidth = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable4
        '
        Me.XrTable4.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.footer2Row})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(1119.0!, 20.0!)
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'footer2Row
        '
        Me.footer2Row.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell16, Me.footer2Based, Me.footer2Original, Me.XrTableCell21})
        Me.footer2Row.Name = "footer2Row"
        Me.footer2Row.Weight = 1.0R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell16.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[general_name]")})
        Me.XrTableCell16.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.StylePriority.UseBorderWidth = False
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell16.TextFormatString = "{0} : "
        Me.XrTableCell16.Weight = 2.1831992057070848R
        '
        'footer2Based
        '
        Me.footer2Based.BackColor = System.Drawing.Color.Transparent
        Me.footer2Based.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.footer2Based.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.footer2Based.BorderWidth = 1.0!
        Me.footer2Based.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([amount_based])")})
        Me.footer2Based.Name = "footer2Based"
        Me.footer2Based.StylePriority.UseBackColor = False
        Me.footer2Based.StylePriority.UseBorderDashStyle = False
        Me.footer2Based.StylePriority.UseBorders = False
        Me.footer2Based.StylePriority.UseBorderWidth = False
        Me.footer2Based.StylePriority.UseTextAlignment = False
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.footer2Based.Summary = XrSummary5
        Me.footer2Based.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.footer2Based.TextFormatString = "{0:#,##0.00}"
        Me.footer2Based.Weight = 0.62555811193646349R
        '
        'footer2Original
        '
        Me.footer2Original.BackColor = System.Drawing.Color.Transparent
        Me.footer2Original.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.footer2Original.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.footer2Original.BorderWidth = 1.0!
        Me.footer2Original.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([amount])")})
        Me.footer2Original.Name = "footer2Original"
        Me.footer2Original.StylePriority.UseBackColor = False
        Me.footer2Original.StylePriority.UseBorderDashStyle = False
        Me.footer2Original.StylePriority.UseBorders = False
        Me.footer2Original.StylePriority.UseBorderWidth = False
        Me.footer2Original.StylePriority.UseTextAlignment = False
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.footer2Original.Summary = XrSummary6
        Me.footer2Original.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.footer2Original.TextFormatString = "{0:#,##0.00}"
        Me.footer2Original.Weight = 0.6255610133500511R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell21.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell21.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel_footer_2})
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.Weight = 3.5656830034225537R
        '
        'panel_footer_2
        '
        Me.panel_footer_2.BackColor = System.Drawing.Color.Transparent
        Me.panel_footer_2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.panel_footer_2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.panel_footer_2.BorderWidth = 1.0!
        Me.panel_footer_2.LocationFloat = New DevExpress.Utils.PointFloat(0.0004882813!, 0!)
        Me.panel_footer_2.Name = "panel_footer_2"
        Me.panel_footer_2.SizeF = New System.Drawing.SizeF(499.9991!, 19.99998!)
        Me.panel_footer_2.StylePriority.UseBackColor = False
        Me.panel_footer_2.StylePriority.UseBorderDashStyle = False
        Me.panel_footer_2.StylePriority.UseBorders = False
        Me.panel_footer_2.StylePriority.UseBorderWidth = False
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.GroupFooter2.HeightF = 20.0!
        Me.GroupFooter2.Level = 2
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.Visible = False
        '
        'XrTable3
        '
        Me.XrTable3.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.footer1Row})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(1119.0!, 20.0!)
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'footer1Row
        '
        Me.footer1Row.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.footer1Based, Me.footer1Original, Me.XrTableCell18})
        Me.footer1Row.Name = "footer1Row"
        Me.footer1Row.Weight = 1.0R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell13.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[currency_name]")})
        Me.XrTableCell13.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(50, 0, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseBorderWidth = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell13.TextFormatString = "{0} : "
        Me.XrTableCell13.Weight = 2.1831992057070848R
        '
        'footer1Based
        '
        Me.footer1Based.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.footer1Based.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.footer1Based.BorderWidth = 1.0!
        Me.footer1Based.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([amount_based])")})
        Me.footer1Based.Name = "footer1Based"
        Me.footer1Based.StylePriority.UseBorderDashStyle = False
        Me.footer1Based.StylePriority.UseBorders = False
        Me.footer1Based.StylePriority.UseBorderWidth = False
        Me.footer1Based.StylePriority.UseTextAlignment = False
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.footer1Based.Summary = XrSummary7
        Me.footer1Based.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.footer1Based.TextFormatString = "{0:#,##0.00}"
        Me.footer1Based.Weight = 0.62555811193646349R
        '
        'footer1Original
        '
        Me.footer1Original.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.footer1Original.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.footer1Original.BorderWidth = 1.0!
        Me.footer1Original.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([amount])")})
        Me.footer1Original.Name = "footer1Original"
        Me.footer1Original.StylePriority.UseBorderDashStyle = False
        Me.footer1Original.StylePriority.UseBorders = False
        Me.footer1Original.StylePriority.UseBorderWidth = False
        Me.footer1Original.StylePriority.UseTextAlignment = False
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.footer1Original.Summary = XrSummary8
        Me.footer1Original.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.footer1Original.TextFormatString = "{0:#,##0.00}"
        Me.footer1Original.Weight = 0.62555925077339447R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell18.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel_footer_1})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell18.Weight = 3.5656849872312559R
        '
        'panel_footer_1
        '
        Me.panel_footer_1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.panel_footer_1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.panel_footer_1.BorderWidth = 1.0!
        Me.panel_footer_1.LocationFloat = New DevExpress.Utils.PointFloat(0.00006103516!, 0!)
        Me.panel_footer_1.Name = "panel_footer_1"
        Me.panel_footer_1.SizeF = New System.Drawing.SizeF(499.9999!, 19.99995!)
        Me.panel_footer_1.StylePriority.UseBorderDashStyle = False
        Me.panel_footer_1.StylePriority.UseBorders = False
        Me.panel_footer_1.StylePriority.UseBorderWidth = False
        '
        'GroupFooter3
        '
        Me.GroupFooter3.HeightF = 0!
        Me.GroupFooter3.Level = 1
        Me.GroupFooter3.Name = "GroupFooter3"
        Me.GroupFooter3.Visible = False
        '
        'GroupFooter4
        '
        Me.GroupFooter4.HeightF = 0!
        Me.GroupFooter4.Name = "GroupFooter4"
        Me.GroupFooter4.Visible = False
        '
        'GroupHeader5
        '
        Me.GroupHeader5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14})
        Me.GroupHeader5.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("account_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader5.HeightF = 40.0!
        Me.GroupHeader5.Level = 4
        Me.GroupHeader5.Name = "GroupHeader5"
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[account_name]")})
        Me.XrLabel14.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(1119.0!, 20.0!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel14.TextFormatString = "******* {0} *******"
        '
        'last_day
        '
        Me.last_day.Description = "last_day"
        Me.last_day.Name = "last_day"
        Me.last_day.Visible = False
        '
        'col_prefix
        '
        Me.col_prefix.Description = "col_prefix"
        Me.col_prefix.Name = "col_prefix"
        Me.col_prefix.Visible = False
        '
        'GroupHeader6
        '
        Me.GroupHeader6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel6, Me.XrLabel5, Me.XrTable1, Me.XrLabel3, Me.company_logo, Me.XrPageInfo1, Me.XrLabel2, Me.XrLabel1, Me.XrLabel7})
        Me.GroupHeader6.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("book_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader6.HeightF = 120.0!
        Me.GroupHeader6.Level = 5
        Me.GroupHeader6.Name = "GroupHeader6"
        Me.GroupHeader6.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.GroupHeader6.RepeatEveryPage = True
        '
        'GroupFooter5
        '
        Me.GroupFooter5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5, Me.XrTable6})
        Me.GroupFooter5.HeightF = 50.0!
        Me.GroupFooter5.Level = 5
        Me.GroupFooter5.Name = "GroupFooter5"
        '
        'report_aging_detailed_print
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3, Me.GroupHeader4, Me.GroupFooter1, Me.GroupFooter2, Me.GroupFooter3, Me.GroupFooter4, Me.GroupHeader5, Me.GroupHeader6, Me.GroupFooter5})
        Me.DataMember = "Account"
        Me.DataSource = Me.Agingset1
        Me.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.runtime, Me.name, Me.title, Me.daterange, Me.last_day, Me.col_prefix})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Version = "17.2"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agingset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents runtime As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents name As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents title As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents daterange As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents company_logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents headerRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents columnNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents columnName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents headerBased As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents headerOriginal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents panel_header As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailBased As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailOriginal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents panel_detail As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Agingset1 As accounting.agingset
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader4 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter4 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents footer1Row As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents panel_footer_1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents footer2Row As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents footer2Based As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents footer2Original As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents panel_footer_2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents footer1Based As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents footer1Original As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents footer3Row As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents footer3Based As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents footer3Original As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents panel_grand_total As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents GroupHeader5 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents last_day As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents col_prefix As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents panelPercentage As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents GroupHeader6 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter5 As DevExpress.XtraReports.UI.GroupFooterBand
End Class
