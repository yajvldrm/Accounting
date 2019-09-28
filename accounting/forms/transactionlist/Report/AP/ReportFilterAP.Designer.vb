<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFilterAP
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportFilterAP))
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabVoucher = New DevExpress.XtraTab.XtraTabPage()
        Me.voucherCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.voucherOK = New DevExpress.XtraEditors.SimpleButton()
        Me.txtOptions = New DevExpress.XtraEditors.RadioGroup()
        Me.txtTransIDTo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransIDFrom = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabList = New DevExpress.XtraTab.XtraTabPage()
        Me.txtOrderBy = New DevExpress.XtraEditors.RadioGroup()
        Me.txtWithProject = New System.Windows.Forms.CheckBox()
        Me.txtWithDepartment = New System.Windows.Forms.CheckBox()
        Me.txtWithAllocation = New System.Windows.Forms.CheckBox()
        Me.txtFilter = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabVoucher.SuspendLayout()
        CType(Me.txtOptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransIDTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransIDFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 40)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(460, 2)
        Me.border1.TabIndex = 44
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "AP Voucher Report"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 265)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabVoucher
        Me.XtraTabControl1.Size = New System.Drawing.Size(460, 184)
        Me.XtraTabControl1.TabIndex = 45
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabVoucher, Me.tabList})
        '
        'tabVoucher
        '
        Me.tabVoucher.Controls.Add(Me.voucherCancel)
        Me.tabVoucher.Controls.Add(Me.voucherOK)
        Me.tabVoucher.Controls.Add(Me.txtOptions)
        Me.tabVoucher.Controls.Add(Me.txtTransIDTo)
        Me.tabVoucher.Controls.Add(Me.Label3)
        Me.tabVoucher.Controls.Add(Me.txtTransIDFrom)
        Me.tabVoucher.Controls.Add(Me.Label2)
        Me.tabVoucher.Name = "tabVoucher"
        Me.tabVoucher.Size = New System.Drawing.Size(454, 156)
        Me.tabVoucher.Text = "Voucher"
        '
        'voucherCancel
        '
        Me.voucherCancel.ImageOptions.Image = CType(resources.GetObject("voucherCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.voucherCancel.Location = New System.Drawing.Point(230, 121)
        Me.voucherCancel.Name = "voucherCancel"
        Me.voucherCancel.Size = New System.Drawing.Size(75, 23)
        Me.voucherCancel.TabIndex = 6
        Me.voucherCancel.Text = "Cancel"
        '
        'voucherOK
        '
        Me.voucherOK.ImageOptions.Image = CType(resources.GetObject("voucherOK.ImageOptions.Image"), System.Drawing.Image)
        Me.voucherOK.Location = New System.Drawing.Point(149, 121)
        Me.voucherOK.Name = "voucherOK"
        Me.voucherOK.Size = New System.Drawing.Size(75, 23)
        Me.voucherOK.TabIndex = 5
        Me.voucherOK.Text = "OK"
        '
        'txtOptions
        '
        Me.txtOptions.EditValue = "1"
        Me.txtOptions.Location = New System.Drawing.Point(4, 64)
        Me.txtOptions.Name = "txtOptions"
        Me.txtOptions.Properties.Columns = 2
        Me.txtOptions.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Printing in Based Currency"), New DevExpress.XtraEditors.Controls.RadioGroupItem("3", "Printing with Comparative Amount"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Printing in Original Amount")})
        Me.txtOptions.Size = New System.Drawing.Size(447, 51)
        Me.txtOptions.TabIndex = 4
        '
        'txtTransIDTo
        '
        Me.txtTransIDTo.Location = New System.Drawing.Point(169, 38)
        Me.txtTransIDTo.Name = "txtTransIDTo"
        Me.txtTransIDTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTransIDTo.Properties.PopupView = Me.GridView1
        Me.txtTransIDTo.Size = New System.Drawing.Size(200, 20)
        Me.txtTransIDTo.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Voucher To:"
        '
        'txtTransIDFrom
        '
        Me.txtTransIDFrom.EditValue = ""
        Me.txtTransIDFrom.Location = New System.Drawing.Point(169, 12)
        Me.txtTransIDFrom.Name = "txtTransIDFrom"
        Me.txtTransIDFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTransIDFrom.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.txtTransIDFrom.Size = New System.Drawing.Size(200, 20)
        Me.txtTransIDFrom.TabIndex = 1
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Voucher From:"
        '
        'tabList
        '
        Me.tabList.Name = "tabList"
        Me.tabList.Size = New System.Drawing.Size(454, 320)
        Me.tabList.Text = "List"
        '
        'txtOrderBy
        '
        Me.txtOrderBy.EditValue = "1"
        Me.txtOrderBy.Location = New System.Drawing.Point(12, 75)
        Me.txtOrderBy.Name = "txtOrderBy"
        Me.txtOrderBy.Properties.Columns = 3
        Me.txtOrderBy.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "By Voucher No"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "By Voucher Date"), New DevExpress.XtraEditors.Controls.RadioGroupItem("3", "By Supplier")})
        Me.txtOrderBy.Size = New System.Drawing.Size(460, 27)
        Me.txtOrderBy.TabIndex = 7
        '
        'txtWithProject
        '
        Me.txtWithProject.AutoSize = True
        Me.txtWithProject.Location = New System.Drawing.Point(129, 108)
        Me.txtWithProject.Name = "txtWithProject"
        Me.txtWithProject.Size = New System.Drawing.Size(60, 17)
        Me.txtWithProject.TabIndex = 46
        Me.txtWithProject.Text = "Project"
        Me.txtWithProject.UseVisualStyleBackColor = True
        '
        'txtWithDepartment
        '
        Me.txtWithDepartment.AutoSize = True
        Me.txtWithDepartment.Location = New System.Drawing.Point(195, 108)
        Me.txtWithDepartment.Name = "txtWithDepartment"
        Me.txtWithDepartment.Size = New System.Drawing.Size(83, 17)
        Me.txtWithDepartment.TabIndex = 47
        Me.txtWithDepartment.Text = "Department"
        Me.txtWithDepartment.UseVisualStyleBackColor = True
        '
        'txtWithAllocation
        '
        Me.txtWithAllocation.AutoSize = True
        Me.txtWithAllocation.Location = New System.Drawing.Point(284, 108)
        Me.txtWithAllocation.Name = "txtWithAllocation"
        Me.txtWithAllocation.Size = New System.Drawing.Size(72, 17)
        Me.txtWithAllocation.TabIndex = 48
        Me.txtWithAllocation.Text = "Allocation"
        Me.txtWithAllocation.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(167, 45)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Properties.Columns = 2
        Me.txtFilter.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Voucher"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "List")})
        Me.txtFilter.Size = New System.Drawing.Size(150, 24)
        Me.txtFilter.TabIndex = 49
        '
        'ReportFilterAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.txtWithAllocation)
        Me.Controls.Add(Me.txtWithDepartment)
        Me.Controls.Add(Me.txtWithProject)
        Me.Controls.Add(Me.txtOrderBy)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportFilterAP"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AP Voucher Report"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabVoucher.ResumeLayout(False)
        Me.tabVoucher.PerformLayout()
        CType(Me.txtOptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransIDTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransIDFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents border1 As borderedlabel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabVoucher As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtTransIDTo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtTransIDFrom As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtOptions As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents voucherCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents voucherOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtOrderBy As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtWithProject As Windows.Forms.CheckBox
    Friend WithEvents txtWithDepartment As Windows.Forms.CheckBox
    Friend WithEvents txtWithAllocation As Windows.Forms.CheckBox
    Friend WithEvents txtFilter As DevExpress.XtraEditors.RadioGroup
End Class
