<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class currencyrate
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Currency_idLabel As System.Windows.Forms.Label
        Dim EffectivitydateLabel As System.Windows.Forms.Label
        Dim Exchange_rateLabel As System.Windows.Forms.Label
        Dim Based_rateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(currencyrate))
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ds_currency_rate = New accounting.ds_currency_rate()
        Me.Get_lib_erp_currency_rateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_lib_erp_currency_rateTableAdapter = New accounting.ds_currency_rateTableAdapters.get_lib_erp_currency_rateTableAdapter()
        Me.TableAdapterManager = New accounting.ds_currency_rateTableAdapters.TableAdapterManager()
        Me.parent_grid = New DevExpress.XtraGrid.GridControl()
        Me.parent_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcurrency_rate_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleffectivitydate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexchange_rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repoNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colbased_rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panel_button = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.parent_panel = New DevExpress.XtraEditors.PanelControl()
        Me.txtBasedRate = New DevExpress.XtraEditors.TextEdit()
        Me.txtExchangeRate = New DevExpress.XtraEditors.TextEdit()
        Me.txtEffectivityDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCurrencyID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GetliberpcurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.panel_hide = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtCurrencyRateID = New DevExpress.XtraEditors.TextEdit()
        Me.txtSearch = New DevExpress.XtraEditors.SearchControl()
        Me.Get_lib_erp_currencyTableAdapter = New accounting.ds_currency_rateTableAdapters.get_lib_erp_currencyTableAdapter()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.bgWork = New System.ComponentModel.BackgroundWorker()
        Me.imgLoading = New DevExpress.XtraEditors.PictureEdit()
        Currency_idLabel = New System.Windows.Forms.Label()
        EffectivitydateLabel = New System.Windows.Forms.Label()
        Exchange_rateLabel = New System.Windows.Forms.Label()
        Based_rateLabel = New System.Windows.Forms.Label()
        CType(Me.Ds_currency_rate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Get_lib_erp_currency_rateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parent_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parent_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repoNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_button.SuspendLayout()
        CType(Me.parent_panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.parent_panel.SuspendLayout()
        CType(Me.txtBasedRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExchangeRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEffectivityDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEffectivityDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrencyID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetliberpcurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_hide.SuspendLayout()
        CType(Me.txtCurrencyRateID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLoading.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Currency_idLabel
        '
        Currency_idLabel.AutoSize = True
        Currency_idLabel.Location = New System.Drawing.Point(46, 8)
        Currency_idLabel.Name = "Currency_idLabel"
        Currency_idLabel.Size = New System.Drawing.Size(55, 13)
        Currency_idLabel.TabIndex = 0
        Currency_idLabel.Text = "Currency:"
        '
        'EffectivitydateLabel
        '
        EffectivitydateLabel.AutoSize = True
        EffectivitydateLabel.Location = New System.Drawing.Point(313, 8)
        EffectivitydateLabel.Name = "EffectivitydateLabel"
        EffectivitydateLabel.Size = New System.Drawing.Size(34, 13)
        EffectivitydateLabel.TabIndex = 2
        EffectivitydateLabel.Text = "Date:"
        '
        'Exchange_rateLabel
        '
        Exchange_rateLabel.AutoSize = True
        Exchange_rateLabel.Location = New System.Drawing.Point(20, 34)
        Exchange_rateLabel.Name = "Exchange_rateLabel"
        Exchange_rateLabel.Size = New System.Drawing.Size(84, 13)
        Exchange_rateLabel.TabIndex = 4
        Exchange_rateLabel.Text = "Exchange Rate:"
        '
        'Based_rateLabel
        '
        Based_rateLabel.AutoSize = True
        Based_rateLabel.Location = New System.Drawing.Point(281, 34)
        Based_rateLabel.Name = "Based_rateLabel"
        Based_rateLabel.Size = New System.Drawing.Size(66, 13)
        Based_rateLabel.TabIndex = 6
        Based_rateLabel.Text = "Based Rate:"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 39)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(467, 2)
        Me.border1.TabIndex = 2
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency Rate Setup"
        '
        'Ds_currency_rate
        '
        Me.Ds_currency_rate.DataSetName = "ds_currency_rate"
        Me.Ds_currency_rate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Get_lib_erp_currency_rateBindingSource
        '
        Me.Get_lib_erp_currency_rateBindingSource.DataMember = "get_lib_erp_currency_rate"
        Me.Get_lib_erp_currency_rateBindingSource.DataSource = Me.Ds_currency_rate
        '
        'Get_lib_erp_currency_rateTableAdapter
        '
        Me.Get_lib_erp_currency_rateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = accounting.ds_currency_rateTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'parent_grid
        '
        Me.parent_grid.DataSource = Me.Get_lib_erp_currency_rateBindingSource
        Me.parent_grid.Location = New System.Drawing.Point(12, 44)
        Me.parent_grid.MainView = Me.parent_view
        Me.parent_grid.Name = "parent_grid"
        Me.parent_grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repoNumeric})
        Me.parent_grid.Size = New System.Drawing.Size(468, 220)
        Me.parent_grid.TabIndex = 3
        Me.parent_grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.parent_view})
        '
        'parent_view
        '
        Me.parent_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcurrency_rate_id, Me.colcurrency_id, Me.coleffectivitydate, Me.colexchange_rate, Me.colbased_rate, Me.colcurrency_code, Me.colcurrency_name})
        Me.parent_view.GridControl = Me.parent_grid
        Me.parent_view.Name = "parent_view"
        Me.parent_view.OptionsBehavior.Editable = False
        Me.parent_view.OptionsSelection.CheckBoxSelectorColumnWidth = 35
        Me.parent_view.OptionsSelection.MultiSelect = True
        Me.parent_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.parent_view.OptionsView.ShowGroupPanel = False
        '
        'colcurrency_rate_id
        '
        Me.colcurrency_rate_id.FieldName = "currency_rate_id"
        Me.colcurrency_rate_id.Name = "colcurrency_rate_id"
        '
        'colcurrency_id
        '
        Me.colcurrency_id.FieldName = "currency_id"
        Me.colcurrency_id.Name = "colcurrency_id"
        '
        'coleffectivitydate
        '
        Me.coleffectivitydate.Caption = "Effectivity Date"
        Me.coleffectivitydate.FieldName = "effectivitydate"
        Me.coleffectivitydate.Name = "coleffectivitydate"
        Me.coleffectivitydate.Visible = True
        Me.coleffectivitydate.VisibleIndex = 2
        '
        'colexchange_rate
        '
        Me.colexchange_rate.Caption = "Exchange Rate"
        Me.colexchange_rate.ColumnEdit = Me.repoNumeric
        Me.colexchange_rate.FieldName = "exchange_rate"
        Me.colexchange_rate.Name = "colexchange_rate"
        Me.colexchange_rate.Visible = True
        Me.colexchange_rate.VisibleIndex = 3
        '
        'repoNumeric
        '
        Me.repoNumeric.AutoHeight = False
        Me.repoNumeric.DisplayFormat.FormatString = "n2"
        Me.repoNumeric.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoNumeric.EditFormat.FormatString = "n2"
        Me.repoNumeric.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repoNumeric.Mask.EditMask = "n2"
        Me.repoNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.repoNumeric.Name = "repoNumeric"
        '
        'colbased_rate
        '
        Me.colbased_rate.FieldName = "based_rate"
        Me.colbased_rate.Name = "colbased_rate"
        '
        'colcurrency_code
        '
        Me.colcurrency_code.FieldName = "currency_code"
        Me.colcurrency_code.Name = "colcurrency_code"
        '
        'colcurrency_name
        '
        Me.colcurrency_name.Caption = "Currency"
        Me.colcurrency_name.FieldName = "currency_name"
        Me.colcurrency_name.Name = "colcurrency_name"
        Me.colcurrency_name.Visible = True
        Me.colcurrency_name.VisibleIndex = 1
        '
        'panel_button
        '
        Me.panel_button.Controls.Add(Me.btnAdd)
        Me.panel_button.Controls.Add(Me.btnEdit)
        Me.panel_button.Controls.Add(Me.btnDelete)
        Me.panel_button.Controls.Add(Me.btnSave)
        Me.panel_button.Controls.Add(Me.btnCancel)
        Me.panel_button.Location = New System.Drawing.Point(12, 270)
        Me.panel_button.Name = "panel_button"
        Me.panel_button.Size = New System.Drawing.Size(408, 30)
        Me.panel_button.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(84, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(165, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(246, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(327, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'parent_panel
        '
        Me.parent_panel.Controls.Add(Based_rateLabel)
        Me.parent_panel.Controls.Add(Me.txtBasedRate)
        Me.parent_panel.Controls.Add(Exchange_rateLabel)
        Me.parent_panel.Controls.Add(Me.txtExchangeRate)
        Me.parent_panel.Controls.Add(EffectivitydateLabel)
        Me.parent_panel.Controls.Add(Me.txtEffectivityDate)
        Me.parent_panel.Controls.Add(Currency_idLabel)
        Me.parent_panel.Controls.Add(Me.txtCurrencyID)
        Me.parent_panel.Location = New System.Drawing.Point(12, 306)
        Me.parent_panel.Name = "parent_panel"
        Me.parent_panel.Size = New System.Drawing.Size(468, 58)
        Me.parent_panel.TabIndex = 6
        '
        'txtBasedRate
        '
        Me.txtBasedRate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Get_lib_erp_currency_rateBindingSource, "based_rate", True))
        Me.txtBasedRate.Enabled = False
        Me.txtBasedRate.Location = New System.Drawing.Point(353, 31)
        Me.txtBasedRate.Name = "txtBasedRate"
        Me.txtBasedRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBasedRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBasedRate.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBasedRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRate.Properties.EditFormat.FormatString = "n2"
        Me.txtBasedRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRate.Properties.Mask.EditMask = "n2"
        Me.txtBasedRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBasedRate.Size = New System.Drawing.Size(100, 20)
        Me.txtBasedRate.TabIndex = 7
        '
        'txtExchangeRate
        '
        Me.txtExchangeRate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Get_lib_erp_currency_rateBindingSource, "exchange_rate", True))
        Me.txtExchangeRate.Location = New System.Drawing.Point(107, 31)
        Me.txtExchangeRate.Name = "txtExchangeRate"
        Me.txtExchangeRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExchangeRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExchangeRate.Properties.DisplayFormat.FormatString = "n2"
        Me.txtExchangeRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRate.Properties.EditFormat.FormatString = "n2"
        Me.txtExchangeRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRate.Properties.Mask.EditMask = "n2"
        Me.txtExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExchangeRate.Size = New System.Drawing.Size(100, 20)
        Me.txtExchangeRate.TabIndex = 5
        '
        'txtEffectivityDate
        '
        Me.txtEffectivityDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Get_lib_erp_currency_rateBindingSource, "effectivitydate", True))
        Me.txtEffectivityDate.EditValue = Nothing
        Me.txtEffectivityDate.Location = New System.Drawing.Point(353, 5)
        Me.txtEffectivityDate.Name = "txtEffectivityDate"
        Me.txtEffectivityDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEffectivityDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEffectivityDate.Size = New System.Drawing.Size(100, 20)
        Me.txtEffectivityDate.TabIndex = 3
        '
        'txtCurrencyID
        '
        Me.txtCurrencyID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Get_lib_erp_currency_rateBindingSource, "currency_id", True))
        Me.txtCurrencyID.Location = New System.Drawing.Point(107, 5)
        Me.txtCurrencyID.Name = "txtCurrencyID"
        Me.txtCurrencyID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCurrencyID.Properties.DataSource = Me.GetliberpcurrencyBindingSource
        Me.txtCurrencyID.Properties.DisplayMember = "currency_name"
        Me.txtCurrencyID.Properties.NullText = ""
        Me.txtCurrencyID.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.txtCurrencyID.Properties.ValueMember = "currency_id"
        Me.txtCurrencyID.Size = New System.Drawing.Size(200, 20)
        Me.txtCurrencyID.TabIndex = 1
        '
        'GetliberpcurrencyBindingSource
        '
        Me.GetliberpcurrencyBindingSource.DataMember = "get_lib_erp_currency"
        Me.GetliberpcurrencyBindingSource.DataSource = Me.Ds_currency_rate
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'panel_hide
        '
        Me.panel_hide.Controls.Add(Me.txtCurrencyRateID)
        Me.panel_hide.Location = New System.Drawing.Point(426, 270)
        Me.panel_hide.Name = "panel_hide"
        Me.panel_hide.Size = New System.Drawing.Size(54, 30)
        Me.panel_hide.TabIndex = 5
        '
        'txtCurrencyRateID
        '
        Me.txtCurrencyRateID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Get_lib_erp_currency_rateBindingSource, "currency_rate_id", True))
        Me.txtCurrencyRateID.Location = New System.Drawing.Point(3, 3)
        Me.txtCurrencyRateID.Name = "txtCurrencyRateID"
        Me.txtCurrencyRateID.Size = New System.Drawing.Size(51, 20)
        Me.txtCurrencyRateID.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Client = Me.parent_grid
        Me.txtSearch.Location = New System.Drawing.Point(280, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.txtSearch.Properties.Client = Me.parent_grid
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.TabIndex = 1
        '
        'Get_lib_erp_currencyTableAdapter
        '
        Me.Get_lib_erp_currencyTableAdapter.ClearBeforeFill = True
        '
        'bgWork
        '
        '
        'imgLoading
        '
        Me.imgLoading.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgLoading.EditValue = Global.accounting.My.Resources.Resources.loading
        Me.imgLoading.Location = New System.Drawing.Point(196, 139)
        Me.imgLoading.Name = "imgLoading"
        Me.imgLoading.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgLoading.Properties.ReadOnly = True
        Me.imgLoading.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgLoading.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.imgLoading.Size = New System.Drawing.Size(100, 96)
        Me.imgLoading.TabIndex = 7
        Me.imgLoading.Visible = False
        '
        'currencyrate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 374)
        Me.Controls.Add(Me.imgLoading)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.panel_hide)
        Me.Controls.Add(Me.parent_panel)
        Me.Controls.Add(Me.panel_button)
        Me.Controls.Add(Me.parent_grid)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "currencyrate"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Rate Setup"
        CType(Me.Ds_currency_rate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Get_lib_erp_currency_rateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parent_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parent_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repoNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_button.ResumeLayout(False)
        CType(Me.parent_panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.parent_panel.ResumeLayout(False)
        Me.parent_panel.PerformLayout()
        CType(Me.txtBasedRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExchangeRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEffectivityDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEffectivityDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrencyID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetliberpcurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_hide.ResumeLayout(False)
        CType(Me.txtCurrencyRateID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLoading.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents border1 As borderedlabel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Ds_currency_rate As ds_currency_rate
    Friend WithEvents Get_lib_erp_currency_rateBindingSource As Windows.Forms.BindingSource
    Friend WithEvents Get_lib_erp_currency_rateTableAdapter As ds_currency_rateTableAdapters.get_lib_erp_currency_rateTableAdapter
    Friend WithEvents TableAdapterManager As ds_currency_rateTableAdapters.TableAdapterManager
    Friend WithEvents parent_grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents parent_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcurrency_rate_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleffectivitydate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexchange_rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbased_rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panel_button As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents parent_panel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtBasedRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExchangeRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEffectivityDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCurrencyID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents panel_hide As Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtCurrencyRateID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSearch As DevExpress.XtraEditors.SearchControl
    Friend WithEvents GetliberpcurrencyBindingSource As Windows.Forms.BindingSource
    Friend WithEvents Get_lib_erp_currencyTableAdapter As ds_currency_rateTableAdapters.get_lib_erp_currencyTableAdapter
    Friend WithEvents repoNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents bgWork As ComponentModel.BackgroundWorker
    Friend WithEvents imgLoading As DevExpress.XtraEditors.PictureEdit
End Class
