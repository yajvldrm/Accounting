<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class report_balancesheet_print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_balancesheet_print))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.runtime = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Balancesheet_set1 = New accounting.balancesheet_set()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.comparativemonth = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.daterange = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.company_logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.af = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cm = New DevExpress.XtraReports.UI.CalculatedField()
        Me.diff = New DevExpress.XtraReports.UI.CalculatedField()
        Me.isDebit = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Balancesheet_set1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.Black
        Me.XrTable2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable2.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(777.0!, 17.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorderDashStyle = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell11, Me.XrTableCell13})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell4.Weight = 0.37795550634717984R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.account_name")})
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell8.Weight = 1.5798543675175749R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.af", "{0:#,##0.00}")})
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell9.Weight = 0.97890439424804987R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.cm", "{0:#,##0.00}")})
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.Weight = 0.97890475984500658R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.diff", "{0:#,##0.00}")})
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell13.Weight = 0.97890485926875737R
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
        'Balancesheet_set1
        '
        Me.Balancesheet_set1.DataSetName = "balancesheet_set"
        Me.Balancesheet_set1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.XrLabel8, Me.XrLabel7, Me.XrLabel1, Me.XrLabel2, Me.XrPageInfo1, Me.company_logo, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6})
        Me.PageHeader.HeightF = 130.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.XrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable1.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 90.00002!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(777.0001!, 40.00001!)
        Me.XrTable1.StylePriority.UseBackColor = False
        Me.XrTable1.StylePriority.UseBorderDashStyle = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell32, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.Weight = 0.72R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseBorders = False
        Me.XrTableCell32.Weight = 1.6146209764936958R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.Text = "As of"
        Me.XrTableCell1.Weight = 0.807310484982333R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.Text = "As of"
        Me.XrTableCell2.Weight = 0.80731049562731716R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.Text = "Difference"
        Me.XrTableCell3.Weight = 0.80731063225721444R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell33, Me.lbl1, Me.lbl2, Me.lbl3})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 0.72R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell33.BorderWidth = 1.0!
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell33.StylePriority.UseBorders = False
        Me.XrTableCell33.StylePriority.UseBorderWidth = False
        Me.XrTableCell33.Weight = 1.6146209764936958R
        '
        'lbl1
        '
        Me.lbl1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.lbl1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lbl1.BorderWidth = 1.0!
        Me.lbl1.Name = "lbl1"
        Me.lbl1.StylePriority.UseBorderDashStyle = False
        Me.lbl1.StylePriority.UseBorders = False
        Me.lbl1.StylePriority.UseBorderWidth = False
        Me.lbl1.Text = "lbl1"
        Me.lbl1.Weight = 0.80731048498233293R
        '
        'lbl2
        '
        Me.lbl2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.lbl2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lbl2.BorderWidth = 1.0!
        Me.lbl2.Name = "lbl2"
        Me.lbl2.StylePriority.UseBorderDashStyle = False
        Me.lbl2.StylePriority.UseBorders = False
        Me.lbl2.StylePriority.UseBorderWidth = False
        Me.lbl2.Text = "lbl2"
        Me.lbl2.Weight = 0.80731049562731727R
        '
        'lbl3
        '
        Me.lbl3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.lbl3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lbl3.BorderWidth = 1.0!
        Me.lbl3.Name = "lbl3"
        Me.lbl3.StylePriority.UseBorderDashStyle = False
        Me.lbl3.StylePriority.UseBorders = False
        Me.lbl3.StylePriority.UseBorderWidth = False
        Me.lbl3.Text = "lbl3"
        Me.lbl3.Weight = 0.80731063225721444R
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.comparativemonth, "Text", "")})
        Me.XrLabel8.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(88.5!, 70.00002!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(600.0!, 20.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "BALANCE SHEET"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'comparativemonth
        '
        Me.comparativemonth.Description = "comparativemonth"
        Me.comparativemonth.Name = "comparativemonth"
        Me.comparativemonth.Visible = False
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.daterange, "Text", "")})
        Me.XrLabel7.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(88.5!, 50.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(600.0!, 20.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "BALANCE SHEET"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'daterange
        '
        Me.daterange.Description = "daterange"
        Me.daterange.Name = "daterange"
        Me.daterange.Visible = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Courier New", 6.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(607.0001!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(50.0!, 15.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Runtime :"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.runtime, "Text", "")})
        Me.XrLabel2.Font = New System.Drawing.Font("Courier New", 6.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(657.0001!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(120.0!, 15.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "XrLabel1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Courier New", 6.0!)
        Me.XrPageInfo1.Format = "Page No : {0} of {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(607.0001!, 14.99999!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 15.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'company_logo
        '
        Me.company_logo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.company_logo.LocationFloat = New DevExpress.Utils.PointFloat(93.99999!, 0.0!)
        Me.company_logo.Name = "company_logo"
        Me.company_logo.SizeF = New System.Drawing.SizeF(100.0!, 50.0!)
        Me.company_logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Company.company_name")})
        Me.XrLabel3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(194.0!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(400.0!, 20.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "SOHBI KOHGEI (PHILS.), INC."
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Company.address")})
        Me.XrLabel4.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(50.0!, 20.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "SEZ LIMA TECHNOLOGY CENTER LIPA CITY BATANGAS PHILIPPINES,"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel4.Visible = False
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Company.tin", "TIN {0}")})
        Me.XrLabel5.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 20.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(50.00006!, 20.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "TIN 005-739-706-000"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel5.Visible = False
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(194.0!, 20.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(400.0!, 30.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "BALANCE SHEET"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Condition = "([chart_type] = 'I' OR [chart_type] = 'E')"
        '
        '
        '
        Me.FormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'af
        '
        Me.af.DataMember = "Balance"
        Me.af.Expression = resources.GetString("af.Expression")
        Me.af.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.af.Name = "af"
        '
        'cm
        '
        Me.cm.DataMember = "Balance"
        Me.cm.Expression = resources.GetString("cm.Expression")
        Me.cm.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.cm.Name = "cm"
        '
        'diff
        '
        Me.diff.DataMember = "Balance"
        Me.diff.Expression = "([af] - [cm])"
        Me.diff.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.diff.Name = "diff"
        '
        'isDebit
        '
        Me.isDebit.DataMember = "Balance"
        Me.isDebit.Expression = "IIF(([chart_type] = 'A' OR [chart_type] = 'E'),True,False)"
        Me.isDebit.FieldType = DevExpress.XtraReports.UI.FieldType.[Boolean]
        Me.isDebit.Name = "isDebit"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("chart_type_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 30.0!
        Me.GroupHeader1.Level = 2
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.BorderWidth = 3.0!
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.chart_type_name", "**--- {0} ---**")})
        Me.XrLabel12.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(777.0001!, 20.0!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderDashStyle = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel9"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("chart_class_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 33.00001!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.chart_class_name", "{0}")})
        Me.XrLabel9.Font = New System.Drawing.Font("Courier New", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(20.00001!, 10.00001!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(290.8002!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "XrLabel9"
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10})
        Me.GroupHeader3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("chart_group_code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader3.HeightF = 33.00001!
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.chart_group_name")})
        Me.XrLabel10.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(39.99999!, 10.00001!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(270.8001!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "XrLabel10"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.GroupFooter1.HeightF = 17.0!
        Me.GroupFooter1.Level = 2
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable5
        '
        Me.XrTable5.BorderColor = System.Drawing.Color.Black
        Me.XrTable5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTable5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable5.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0.000125885!, 0.0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(777.0!, 17.0!)
        Me.XrTable5.StylePriority.UseBorderColor = False
        Me.XrTable5.StylePriority.UseBorderDashStyle = False
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.chart_type_name", "TOTAL {0}")})
        Me.XrTableCell20.Font = New System.Drawing.Font("Courier New", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.Text = "TOTAL"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell20.Weight = 1.9578098802079973R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.af")})
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:##,##0.00}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell21.Summary = XrSummary1
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.Weight = 0.97890439424804987R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.cm")})
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:##,##0.00}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell22.Summary = XrSummary2
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell22.Weight = 0.97890475984500658R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.diff")})
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:##,##0.00}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell23.Summary = XrSummary3
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell23.Weight = 0.97890485926875737R
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.GroupFooter2.HeightF = 17.0!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrTable4
        '
        Me.XrTable4.BorderColor = System.Drawing.Color.Black
        Me.XrTable4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTable4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable4.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0.0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(777.0!, 17.0!)
        Me.XrTable4.StylePriority.UseBorderColor = False
        Me.XrTable4.StylePriority.UseBorderDashStyle = False
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell14.Weight = 0.12598439570995568R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.chart_class_name", "TOTAL {0}")})
        Me.XrTableCell15.Font = New System.Drawing.Font("Courier New", 8.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "TOTAL"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell15.Weight = 1.8318254781547991R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.af")})
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:##,##0.00}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell16.Summary = XrSummary4
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell16.Weight = 0.97890439424804987R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.cm")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:##,##0.00}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell17.Summary = XrSummary5
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell17.Weight = 0.97890475984500658R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.diff")})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:##,##0.00}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell18.Summary = XrSummary6
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell18.Weight = 0.97890485926875737R
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.GroupFooter3.HeightF = 17.0!
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'XrTable3
        '
        Me.XrTable3.BorderColor = System.Drawing.Color.Black
        Me.XrTable3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTable3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable3.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(777.0!, 17.0!)
        Me.XrTable3.StylePriority.UseBorderColor = False
        Me.XrTable3.StylePriority.UseBorderDashStyle = False
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell10, Me.XrTableCell12})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell5.Weight = 0.25196956655233838R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.chart_group_name", "TOTAL {0}")})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "TOTAL"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell6.Weight = 1.7058403073124164R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.af")})
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:##,##0.00}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell7.Summary = XrSummary7
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell7.Weight = 0.97890439424804987R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.cm")})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:##,##0.00}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell10.Summary = XrSummary8
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell10.Weight = 0.97890475984500658R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance.diff")})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBorderDashStyle = False
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:##,##0.00}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell12.Summary = XrSummary9
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell12.Weight = 0.97890485926875737R
        '
        'report_balancesheet_print
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3, Me.GroupFooter1, Me.GroupFooter2, Me.GroupFooter3})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.af, Me.cm, Me.diff, Me.isDebit})
        Me.DataMember = "Balance"
        Me.DataSource = Me.Balancesheet_set1
        Me.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.runtime, Me.daterange, Me.comparativemonth})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Version = "15.2"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Balancesheet_set1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents runtime As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Balancesheet_set1 As accounting.balancesheet_set
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lbl1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents comparativemonth As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents daterange As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents company_logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents af As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cm As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents diff As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents isDebit As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
End Class
