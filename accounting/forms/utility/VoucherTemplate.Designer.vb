<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoucherTemplate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoucherTemplate))
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DsVoucherTemplateSet = New accounting.dsVoucherTemplateSet()
        Me.Get_voucher_moduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_voucher_moduleTableAdapter = New accounting.dsVoucherTemplateSetTableAdapters.get_voucher_moduleTableAdapter()
        Me.parent_grid = New DevExpress.XtraGrid.GridControl()
        Me.parent_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colmodule_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodule_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodule_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.parent_button = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.parent_hide = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtModuleID = New DevExpress.XtraEditors.TextEdit()
        Me.Get_lib_acc_voucher_templateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_lib_acc_voucher_templateTableAdapter = New accounting.dsVoucherTemplateSetTableAdapters.get_lib_acc_voucher_templateTableAdapter()
        Me.child_grid = New DevExpress.XtraGrid.GridControl()
        Me.child_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colvoucher_template_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodule_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltemplate_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfile_location = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoBrowse = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colmodule_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodule_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltemplate_type_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnReportDesigner = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DsVoucherTemplateSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Get_voucher_moduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parent_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parent_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.parent_button.SuspendLayout()
        Me.parent_hide.SuspendLayout()
        CType(Me.txtModuleID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Get_lib_acc_voucher_templateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.child_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.child_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsVoucherTemplateSet
        '
        Me.DsVoucherTemplateSet.DataSetName = "dsVoucherTemplateSet"
        Me.DsVoucherTemplateSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Get_voucher_moduleBindingSource
        '
        Me.Get_voucher_moduleBindingSource.DataMember = "get_voucher_module"
        Me.Get_voucher_moduleBindingSource.DataSource = Me.DsVoucherTemplateSet
        '
        'Get_voucher_moduleTableAdapter
        '
        Me.Get_voucher_moduleTableAdapter.ClearBeforeFill = True
        '
        'parent_grid
        '
        Me.parent_grid.DataSource = Me.Get_voucher_moduleBindingSource
        Me.parent_grid.Location = New System.Drawing.Point(12, 12)
        Me.parent_grid.MainView = Me.parent_view
        Me.parent_grid.Name = "parent_grid"
        Me.parent_grid.Size = New System.Drawing.Size(760, 220)
        Me.parent_grid.TabIndex = 1
        Me.parent_grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.parent_view})
        '
        'parent_view
        '
        Me.parent_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colmodule_id1, Me.colmodule_code1, Me.colmodule_name1})
        Me.parent_view.GridControl = Me.parent_grid
        Me.parent_view.Name = "parent_view"
        Me.parent_view.OptionsBehavior.Editable = False
        Me.parent_view.OptionsView.ShowGroupPanel = False
        '
        'colmodule_id1
        '
        Me.colmodule_id1.FieldName = "module_id"
        Me.colmodule_id1.Name = "colmodule_id1"
        '
        'colmodule_code1
        '
        Me.colmodule_code1.FieldName = "module_code"
        Me.colmodule_code1.Name = "colmodule_code1"
        '
        'colmodule_name1
        '
        Me.colmodule_name1.Caption = "Module"
        Me.colmodule_name1.FieldName = "module_name"
        Me.colmodule_name1.Name = "colmodule_name1"
        Me.colmodule_name1.Visible = True
        Me.colmodule_name1.VisibleIndex = 0
        '
        'parent_button
        '
        Me.parent_button.Controls.Add(Me.btnEdit)
        Me.parent_button.Controls.Add(Me.btnSave)
        Me.parent_button.Controls.Add(Me.btnCancel)
        Me.parent_button.Location = New System.Drawing.Point(12, 238)
        Me.parent_button.Name = "parent_button"
        Me.parent_button.Size = New System.Drawing.Size(251, 30)
        Me.parent_button.TabIndex = 2
        '
        'btnEdit
        '
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(3, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(84, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(165, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'parent_hide
        '
        Me.parent_hide.Controls.Add(Me.txtModuleID)
        Me.parent_hide.Location = New System.Drawing.Point(269, 238)
        Me.parent_hide.Name = "parent_hide"
        Me.parent_hide.Size = New System.Drawing.Size(293, 30)
        Me.parent_hide.TabIndex = 3
        '
        'txtModuleID
        '
        Me.txtModuleID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Get_voucher_moduleBindingSource, "module_code", True))
        Me.txtModuleID.Location = New System.Drawing.Point(3, 3)
        Me.txtModuleID.Name = "txtModuleID"
        Me.txtModuleID.Size = New System.Drawing.Size(100, 20)
        Me.txtModuleID.TabIndex = 0
        '
        'Get_lib_acc_voucher_templateBindingSource
        '
        Me.Get_lib_acc_voucher_templateBindingSource.DataMember = "get_lib_acc_voucher_template"
        Me.Get_lib_acc_voucher_templateBindingSource.DataSource = Me.DsVoucherTemplateSet
        '
        'Get_lib_acc_voucher_templateTableAdapter
        '
        Me.Get_lib_acc_voucher_templateTableAdapter.ClearBeforeFill = True
        '
        'child_grid
        '
        Me.child_grid.DataSource = Me.Get_lib_acc_voucher_templateBindingSource
        Me.child_grid.Location = New System.Drawing.Point(12, 274)
        Me.child_grid.MainView = Me.child_view
        Me.child_grid.Name = "child_grid"
        Me.child_grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoBrowse})
        Me.child_grid.Size = New System.Drawing.Size(760, 275)
        Me.child_grid.TabIndex = 4
        Me.child_grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.child_view})
        '
        'child_view
        '
        Me.child_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colvoucher_template_id, Me.colmodule_id, Me.coltemplate_type, Me.colfile_location, Me.colmodule_code, Me.colmodule_name, Me.coltemplate_type_name})
        Me.child_view.GridControl = Me.child_grid
        Me.child_view.Name = "child_view"
        Me.child_view.OptionsView.ShowGroupPanel = False
        '
        'colvoucher_template_id
        '
        Me.colvoucher_template_id.FieldName = "voucher_template_id"
        Me.colvoucher_template_id.Name = "colvoucher_template_id"
        '
        'colmodule_id
        '
        Me.colmodule_id.FieldName = "module_id"
        Me.colmodule_id.Name = "colmodule_id"
        '
        'coltemplate_type
        '
        Me.coltemplate_type.FieldName = "template_type"
        Me.coltemplate_type.Name = "coltemplate_type"
        '
        'colfile_location
        '
        Me.colfile_location.Caption = "Location"
        Me.colfile_location.ColumnEdit = Me.repoBrowse
        Me.colfile_location.FieldName = "file_location"
        Me.colfile_location.Name = "colfile_location"
        Me.colfile_location.Visible = True
        Me.colfile_location.VisibleIndex = 1
        '
        'repoBrowse
        '
        Me.repoBrowse.AutoHeight = False
        Me.repoBrowse.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Browse", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.repoBrowse.Name = "repoBrowse"
        '
        'colmodule_code
        '
        Me.colmodule_code.FieldName = "module_code"
        Me.colmodule_code.Name = "colmodule_code"
        '
        'colmodule_name
        '
        Me.colmodule_name.FieldName = "module_name"
        Me.colmodule_name.Name = "colmodule_name"
        '
        'coltemplate_type_name
        '
        Me.coltemplate_type_name.Caption = "Template"
        Me.coltemplate_type_name.FieldName = "template_type_name"
        Me.coltemplate_type_name.MaxWidth = 200
        Me.coltemplate_type_name.MinWidth = 200
        Me.coltemplate_type_name.Name = "coltemplate_type_name"
        Me.coltemplate_type_name.OptionsColumn.AllowEdit = False
        Me.coltemplate_type_name.Visible = True
        Me.coltemplate_type_name.VisibleIndex = 0
        Me.coltemplate_type_name.Width = 200
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Report (*.repx)|*.repx"
        '
        'btnReportDesigner
        '
        Me.btnReportDesigner.AutoSize = True
        Me.btnReportDesigner.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReportDesigner.Location = New System.Drawing.Point(666, 238)
        Me.btnReportDesigner.Name = "btnReportDesigner"
        Me.btnReportDesigner.Size = New System.Drawing.Size(106, 22)
        Me.btnReportDesigner.TabIndex = 5
        Me.btnReportDesigner.Text = "Report Designer"
        '
        'VoucherTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnReportDesigner)
        Me.Controls.Add(Me.child_grid)
        Me.Controls.Add(Me.parent_hide)
        Me.Controls.Add(Me.parent_button)
        Me.Controls.Add(Me.parent_grid)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VoucherTemplate"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Template"
        CType(Me.DsVoucherTemplateSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Get_voucher_moduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parent_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parent_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.parent_button.ResumeLayout(False)
        Me.parent_hide.ResumeLayout(False)
        CType(Me.txtModuleID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Get_lib_acc_voucher_templateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.child_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.child_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsVoucherTemplateSet As dsVoucherTemplateSet
    Friend WithEvents Get_voucher_moduleBindingSource As Windows.Forms.BindingSource
    Friend WithEvents Get_voucher_moduleTableAdapter As dsVoucherTemplateSetTableAdapters.get_voucher_moduleTableAdapter
    Friend WithEvents parent_grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents parent_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents parent_button As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents parent_hide As Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtModuleID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Get_lib_acc_voucher_templateBindingSource As Windows.Forms.BindingSource
    Friend WithEvents Get_lib_acc_voucher_templateTableAdapter As dsVoucherTemplateSetTableAdapters.get_lib_acc_voucher_templateTableAdapter
    Friend WithEvents child_grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents child_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colmodule_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodule_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodule_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvoucher_template_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodule_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltemplate_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfile_location As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodule_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodule_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltemplate_type_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repoBrowse As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents btnReportDesigner As DevExpress.XtraEditors.SimpleButton
End Class
