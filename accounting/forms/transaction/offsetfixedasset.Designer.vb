<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class offsetfixedasset
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtjbooksid = New user_control.textbox()
        Me.Borderedlabel1 = New accounting.borderedlabel()
        Me.Borderedlabel2 = New accounting.borderedlabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdNotSave = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgOffset = New System.Windows.Forms.DataGridView()
        Me.ds = New System.Data.DataSet()
        Me.fixed_asset = New System.Data.DataTable()
        Me.DataColumn80 = New System.Data.DataColumn()
        Me.DataColumn81 = New System.Data.DataColumn()
        Me.DataColumn82 = New System.Data.DataColumn()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.DataColumn85 = New System.Data.DataColumn()
        Me.DataColumn86 = New System.Data.DataColumn()
        Me.DataColumn87 = New System.Data.DataColumn()
        Me.DataColumn88 = New System.Data.DataColumn()
        Me.DataColumn89 = New System.Data.DataColumn()
        Me.DataColumn90 = New System.Data.DataColumn()
        Me.DataColumn91 = New System.Data.DataColumn()
        Me.DataColumn92 = New System.Data.DataColumn()
        Me.DataColumn93 = New System.Data.DataColumn()
        Me.DataColumn94 = New System.Data.DataColumn()
        Me.DataColumn95 = New System.Data.DataColumn()
        Me.DataColumn156 = New System.Data.DataColumn()
        Me.DataColumn249 = New System.Data.DataColumn()
        Me.DataColumn250 = New System.Data.DataColumn()
        Me.DataColumn251 = New System.Data.DataColumn()
        Me.DataColumn252 = New System.Data.DataColumn()
        Me.DataColumn253 = New System.Data.DataColumn()
        Me.DataColumn254 = New System.Data.DataColumn()
        Me.DataColumn255 = New System.Data.DataColumn()
        Me.DataColumn256 = New System.Data.DataColumn()
        Me.DataColumn257 = New System.Data.DataColumn()
        Me.DataColumn258 = New System.Data.DataColumn()
        Me.DataColumn259 = New System.Data.DataColumn()
        Me.DataColumn260 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.txttotal = New user_control.textbox()
        Me.txt_search = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAll = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.bs_fixed_asset = New System.Windows.Forms.BindingSource(Me.components)
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmp_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isInputted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FixedassetidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JbooksidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExchangerateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasedrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoricalrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateacquiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsefullifeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatestartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReffixedassetidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencycodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmpamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsInputtedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalvagevalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalvagevaluebasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParticularsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fixed_asset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.bs_fixed_asset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtjbooksid
        '
        Me.txtjbooksid._Text = ""
        Me.txtjbooksid.AllowNegative = False
        Me.txtjbooksid.AlwaysDisable = True
        Me.txtjbooksid.AlwaysEnable = False
        Me.txtjbooksid.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtjbooksid.BorderColor = System.Drawing.Color.DarkGray
        Me.txtjbooksid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjbooksid.DataSource = ""
        Me.txtjbooksid.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjbooksid.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtjbooksid.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtjbooksid.Enabled = False
        Me.txtjbooksid.EnabledBackColor = System.Drawing.Color.White
        Me.txtjbooksid.ForeColor = System.Drawing.Color.Black
        Me.txtjbooksid.ispk = False
        Me.txtjbooksid.Location = New System.Drawing.Point(267, 34)
        Me.txtjbooksid.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjbooksid.MultiLine = False
        Me.txtjbooksid.Name = "txtjbooksid"
        Me.txtjbooksid.NoClear = False
        Me.txtjbooksid.NumberFormat = "@"
        Me.txtjbooksid.Required = False
        Me.txtjbooksid.RowData = Nothing
        Me.txtjbooksid.SelectionLength = 0
        Me.txtjbooksid.SelectionStart = 0
        Me.txtjbooksid.Size = New System.Drawing.Size(100, 20)
        Me.txtjbooksid.TabIndex = 143
        Me.txtjbooksid.TableData = Nothing
        Me.txtjbooksid.TextSource = ""
        Me.txtjbooksid.UseSystemPasswordChar = False
        Me.txtjbooksid.Value = ""
        Me.txtjbooksid.ValueSource = ""
        Me.txtjbooksid.Visible = False
        '
        'Borderedlabel1
        '
        Me.Borderedlabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Borderedlabel1.BorderColor = System.Drawing.Color.White
        Me.Borderedlabel1.Location = New System.Drawing.Point(21, 600)
        Me.Borderedlabel1.Name = "Borderedlabel1"
        Me.Borderedlabel1.Size = New System.Drawing.Size(813, 2)
        Me.Borderedlabel1.TabIndex = 142
        Me.Borderedlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Borderedlabel2
        '
        Me.Borderedlabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Borderedlabel2.BorderColor = System.Drawing.Color.DarkGray
        Me.Borderedlabel2.Location = New System.Drawing.Point(21, 598)
        Me.Borderedlabel2.Name = "Borderedlabel2"
        Me.Borderedlabel2.Size = New System.Drawing.Size(813, 2)
        Me.Borderedlabel2.TabIndex = 141
        Me.Borderedlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(530, 575)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "TOTAL"
        '
        'cmdNotSave
        '
        Me.cmdNotSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdNotSave.BackColor = System.Drawing.Color.Maroon
        Me.cmdNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.cmdNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNotSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotSave.ForeColor = System.Drawing.Color.White
        Me.cmdNotSave.Location = New System.Drawing.Point(430, 611)
        Me.cmdNotSave.Name = "cmdNotSave"
        Me.cmdNotSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdNotSave.TabIndex = 138
        Me.cmdNotSave.Text = "&Cancel"
        Me.cmdNotSave.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSave.BackColor = System.Drawing.Color.Green
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(324, 611)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdSave.TabIndex = 137
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(21, 65)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(813, 2)
        Me.border2.TabIndex = 136
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(21, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(813, 2)
        Me.border1.TabIndex = 135
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 25)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Fixed Asset Offsetting"
        '
        'dgOffset
        '
        Me.dgOffset.AllowUserToAddRows = False
        Me.dgOffset.AllowUserToDeleteRows = False
        Me.dgOffset.AllowUserToResizeColumns = False
        Me.dgOffset.AllowUserToResizeRows = False
        Me.dgOffset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgOffset.AutoGenerateColumns = False
        Me.dgOffset.ColumnHeadersHeight = 28
        Me.dgOffset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgOffset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_no, Me.Column1, Me.trans_date, Me.ref_no, Me.description, Me.tmp_amount, Me.isInputted, Me.amount, Me.balance, Me.SelDataGridViewCheckBoxColumn, Me.FixedassetidDataGridViewTextBoxColumn, Me.JbooksidDataGridViewTextBoxColumn, Me.CurrencyidDataGridViewTextBoxColumn, Me.ExchangerateDataGridViewTextBoxColumn, Me.BasedrateDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.AssetcodeDataGridViewTextBoxColumn, Me.HistoricalrateDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DateacquiredDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.AmountbasedDataGridViewTextBoxColumn, Me.UsefullifeDataGridViewTextBoxColumn, Me.DatestartDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.DebitbasedDataGridViewTextBoxColumn, Me.CreditbasedDataGridViewTextBoxColumn, Me.ReffixedassetidDataGridViewTextBoxColumn, Me.RefnoDataGridViewTextBoxColumn, Me.CurrencycodeDataGridViewTextBoxColumn, Me.CurrencynameDataGridViewTextBoxColumn, Me.TmpamountDataGridViewTextBoxColumn, Me.IsInputtedDataGridViewCheckBoxColumn, Me.DeletedDataGridViewCheckBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.TransnoDataGridViewTextBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.SalvagevalueDataGridViewTextBoxColumn, Me.SalvagevaluebasedDataGridViewTextBoxColumn, Me.ParticularsDataGridViewTextBoxColumn})
        Me.dgOffset.DataSource = Me.bs_fixed_asset
        Me.dgOffset.Location = New System.Drawing.Point(21, 75)
        Me.dgOffset.Name = "dgOffset"
        Me.dgOffset.RowHeadersVisible = False
        Me.dgOffset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOffset.Size = New System.Drawing.Size(813, 490)
        Me.dgOffset.TabIndex = 133
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.fixed_asset})
        '
        'fixed_asset
        '
        Me.fixed_asset.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn156, Me.DataColumn249, Me.DataColumn250, Me.DataColumn251, Me.DataColumn252, Me.DataColumn253, Me.DataColumn254, Me.DataColumn255, Me.DataColumn256, Me.DataColumn257, Me.DataColumn258, Me.DataColumn259, Me.DataColumn260, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.fixed_asset.TableName = "fixed_asset"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "sel"
        Me.DataColumn80.DataType = GetType(Boolean)
        Me.DataColumn80.DefaultValue = False
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "fixed_asset_id"
        Me.DataColumn81.DefaultValue = ""
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "jbooks_id"
        Me.DataColumn82.DefaultValue = ""
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "currency_id"
        Me.DataColumn83.DefaultValue = ""
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "exchange_rate"
        Me.DataColumn84.DataType = GetType(Decimal)
        Me.DataColumn84.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "based_rate"
        Me.DataColumn85.DataType = GetType(Decimal)
        Me.DataColumn85.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "description"
        Me.DataColumn86.DefaultValue = ""
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "asset_code"
        Me.DataColumn87.DefaultValue = ""
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "historical_rate"
        Me.DataColumn88.DataType = GetType(Decimal)
        Me.DataColumn88.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "quantity"
        Me.DataColumn89.DataType = GetType(Integer)
        Me.DataColumn89.DefaultValue = 0
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "date_acquired"
        Me.DataColumn90.DataType = GetType(Date)
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "amount"
        Me.DataColumn91.DataType = GetType(Decimal)
        Me.DataColumn91.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "amount_based"
        Me.DataColumn92.DataType = GetType(Decimal)
        Me.DataColumn92.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "useful_life"
        Me.DataColumn93.DataType = GetType(Integer)
        Me.DataColumn93.DefaultValue = 0
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "date_start"
        Me.DataColumn94.DataType = GetType(Date)
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "debit"
        Me.DataColumn95.DataType = GetType(Decimal)
        Me.DataColumn95.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn156
        '
        Me.DataColumn156.ColumnName = "credit"
        Me.DataColumn156.DataType = GetType(Decimal)
        Me.DataColumn156.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn249
        '
        Me.DataColumn249.ColumnName = "debit_based"
        Me.DataColumn249.DataType = GetType(Decimal)
        Me.DataColumn249.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn250
        '
        Me.DataColumn250.ColumnName = "credit_based"
        Me.DataColumn250.DataType = GetType(Decimal)
        Me.DataColumn250.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn251
        '
        Me.DataColumn251.ColumnName = "ref_fixed_asset_id"
        Me.DataColumn251.DefaultValue = ""
        '
        'DataColumn252
        '
        Me.DataColumn252.ColumnName = "ref_no"
        Me.DataColumn252.DefaultValue = ""
        '
        'DataColumn253
        '
        Me.DataColumn253.ColumnName = "currency_code"
        Me.DataColumn253.DefaultValue = ""
        '
        'DataColumn254
        '
        Me.DataColumn254.ColumnName = "currency_name"
        Me.DataColumn254.DefaultValue = ""
        '
        'DataColumn255
        '
        Me.DataColumn255.ColumnName = "tmp_amount"
        Me.DataColumn255.DataType = GetType(Decimal)
        Me.DataColumn255.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn256
        '
        Me.DataColumn256.ColumnName = "isInputted"
        Me.DataColumn256.DataType = GetType(Boolean)
        Me.DataColumn256.DefaultValue = False
        '
        'DataColumn257
        '
        Me.DataColumn257.ColumnName = "deleted"
        Me.DataColumn257.DataType = GetType(Boolean)
        Me.DataColumn257.DefaultValue = False
        '
        'DataColumn258
        '
        Me.DataColumn258.ColumnName = "balance"
        Me.DataColumn258.DataType = GetType(Decimal)
        Me.DataColumn258.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn259
        '
        Me.DataColumn259.ColumnName = "trans_no"
        Me.DataColumn259.DefaultValue = ""
        '
        'DataColumn260
        '
        Me.DataColumn260.ColumnName = "trans_date"
        Me.DataColumn260.DefaultValue = ""
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "salvage_value"
        Me.DataColumn1.DataType = GetType(Decimal)
        Me.DataColumn1.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "salvage_value_based"
        Me.DataColumn2.DataType = GetType(Decimal)
        Me.DataColumn2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "particulars"
        Me.DataColumn3.DefaultValue = ""
        '
        'txttotal
        '
        Me.txttotal._Text = ""
        Me.txttotal.AllowNegative = False
        Me.txttotal.AlwaysDisable = True
        Me.txttotal.AlwaysEnable = False
        Me.txttotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttotal.BorderColor = System.Drawing.Color.DarkGray
        Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotal.DataSource = ""
        Me.txttotal.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttotal.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttotal.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txttotal.Enabled = False
        Me.txttotal.EnabledBackColor = System.Drawing.Color.White
        Me.txttotal.ispk = False
        Me.txttotal.Location = New System.Drawing.Point(575, 571)
        Me.txttotal.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttotal.MultiLine = False
        Me.txttotal.Name = "txttotal"
        Me.txttotal.NoClear = False
        Me.txttotal.NumberFormat = "##,##0.00"
        Me.txttotal.Required = False
        Me.txttotal.RowData = Nothing
        Me.txttotal.SelectionLength = 0
        Me.txttotal.SelectionStart = 0
        Me.txttotal.Size = New System.Drawing.Size(105, 20)
        Me.txttotal.TabIndex = 144
        Me.txttotal.TableData = Nothing
        Me.txttotal.TextSource = ""
        Me.txttotal.UseSystemPasswordChar = False
        Me.txttotal.Value = ""
        Me.txttotal.ValueSource = ""
        '
        'txt_search
        '
        Me.txt_search._Text = ""
        Me.txt_search.AllowNegative = False
        Me.txt_search.AlwaysDisable = False
        Me.txt_search.AlwaysEnable = False
        Me.txt_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.BackColor = System.Drawing.Color.White
        Me.txt_search.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.DataSource = ""
        Me.txt_search.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_search.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_search.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_search.EnabledBackColor = System.Drawing.Color.White
        Me.txt_search.ispk = False
        Me.txt_search.Location = New System.Drawing.Point(634, 40)
        Me.txt_search.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_search.MultiLine = False
        Me.txt_search.Name = "txt_search"
        Me.txt_search.NoClear = False
        Me.txt_search.NumberFormat = "@"
        Me.txt_search.Required = False
        Me.txt_search.RowData = Nothing
        Me.txt_search.SelectionLength = 0
        Me.txt_search.SelectionStart = 0
        Me.txt_search.Size = New System.Drawing.Size(200, 20)
        Me.txt_search.TabIndex = 147
        Me.txt_search.TableData = Nothing
        Me.txt_search.TextSource = ""
        Me.txt_search.UseSystemPasswordChar = False
        Me.txt_search.Value = ""
        Me.txt_search.ValueSource = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(592, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Search"
        '
        'cboAll
        '
        Me.cboAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAll.AutoSize = True
        Me.cboAll.Location = New System.Drawing.Point(549, 41)
        Me.cboAll.Name = "cboAll"
        Me.cboAll.Size = New System.Drawing.Size(37, 17)
        Me.cboAll.TabIndex = 148
        Me.cboAll.Text = "All"
        Me.cboAll.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtDateFrom)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtDateTo)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(247, 31)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(296, 29)
        Me.FlowLayoutPanel1.TabIndex = 149
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From"
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateFrom.Location = New System.Drawing.Point(40, 3)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(108, 21)
        Me.txtDateFrom.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "To"
        '
        'txtDateTo
        '
        Me.txtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateTo.Location = New System.Drawing.Point(179, 3)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(108, 21)
        Me.txtDateTo.TabIndex = 3
        '
        'bs_fixed_asset
        '
        Me.bs_fixed_asset.DataMember = "fixed_asset"
        Me.bs_fixed_asset.DataSource = Me.ds
        '
        'trans_no
        '
        Me.trans_no.DataPropertyName = "trans_no"
        Me.trans_no.HeaderText = "Reference No."
        Me.trans_no.MinimumWidth = 100
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        Me.trans_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.trans_no.Width = 120
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "particulars"
        Me.Column1.HeaderText = "Particulars"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'trans_date
        '
        Me.trans_date.DataPropertyName = "trans_date"
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = "00/00/0000"
        Me.trans_date.DefaultCellStyle = DataGridViewCellStyle9
        Me.trans_date.HeaderText = "Reference Date"
        Me.trans_date.Name = "trans_date"
        Me.trans_date.ReadOnly = True
        Me.trans_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ref_no
        '
        Me.ref_no.DataPropertyName = "ref_no"
        Me.ref_no.HeaderText = "Journal Code"
        Me.ref_no.Name = "ref_no"
        Me.ref_no.ReadOnly = True
        Me.ref_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ref_no.Width = 80
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tmp_amount
        '
        Me.tmp_amount.DataPropertyName = "tmp_amount"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "##,##0.00"
        DataGridViewCellStyle10.NullValue = "0.0"
        Me.tmp_amount.DefaultCellStyle = DataGridViewCellStyle10
        Me.tmp_amount.HeaderText = "Amount"
        Me.tmp_amount.Name = "tmp_amount"
        Me.tmp_amount.ReadOnly = True
        Me.tmp_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'isInputted
        '
        Me.isInputted.DataPropertyName = "isInputted"
        Me.isInputted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.isInputted.HeaderText = ""
        Me.isInputted.Name = "isInputted"
        Me.isInputted.Width = 30
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "##,##0.00"
        DataGridViewCellStyle11.NullValue = "0.0"
        Me.amount.DefaultCellStyle = DataGridViewCellStyle11
        Me.amount.HeaderText = "Disposal / Adjustment"
        Me.amount.Name = "amount"
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.amount.Width = 120
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "##,##0.00"
        DataGridViewCellStyle12.NullValue = "0.0"
        Me.balance.DefaultCellStyle = DataGridViewCellStyle12
        Me.balance.HeaderText = "Balance"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SelDataGridViewCheckBoxColumn
        '
        Me.SelDataGridViewCheckBoxColumn.DataPropertyName = "sel"
        Me.SelDataGridViewCheckBoxColumn.HeaderText = "sel"
        Me.SelDataGridViewCheckBoxColumn.Name = "SelDataGridViewCheckBoxColumn"
        Me.SelDataGridViewCheckBoxColumn.Visible = False
        '
        'FixedassetidDataGridViewTextBoxColumn
        '
        Me.FixedassetidDataGridViewTextBoxColumn.DataPropertyName = "fixed_asset_id"
        Me.FixedassetidDataGridViewTextBoxColumn.HeaderText = "fixed_asset_id"
        Me.FixedassetidDataGridViewTextBoxColumn.Name = "FixedassetidDataGridViewTextBoxColumn"
        Me.FixedassetidDataGridViewTextBoxColumn.Visible = False
        '
        'JbooksidDataGridViewTextBoxColumn
        '
        Me.JbooksidDataGridViewTextBoxColumn.DataPropertyName = "jbooks_id"
        Me.JbooksidDataGridViewTextBoxColumn.HeaderText = "jbooks_id"
        Me.JbooksidDataGridViewTextBoxColumn.Name = "JbooksidDataGridViewTextBoxColumn"
        Me.JbooksidDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencyidDataGridViewTextBoxColumn
        '
        Me.CurrencyidDataGridViewTextBoxColumn.DataPropertyName = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.HeaderText = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.Name = "CurrencyidDataGridViewTextBoxColumn"
        Me.CurrencyidDataGridViewTextBoxColumn.Visible = False
        '
        'ExchangerateDataGridViewTextBoxColumn
        '
        Me.ExchangerateDataGridViewTextBoxColumn.DataPropertyName = "exchange_rate"
        Me.ExchangerateDataGridViewTextBoxColumn.HeaderText = "exchange_rate"
        Me.ExchangerateDataGridViewTextBoxColumn.Name = "ExchangerateDataGridViewTextBoxColumn"
        Me.ExchangerateDataGridViewTextBoxColumn.Visible = False
        '
        'BasedrateDataGridViewTextBoxColumn
        '
        Me.BasedrateDataGridViewTextBoxColumn.DataPropertyName = "based_rate"
        Me.BasedrateDataGridViewTextBoxColumn.HeaderText = "based_rate"
        Me.BasedrateDataGridViewTextBoxColumn.Name = "BasedrateDataGridViewTextBoxColumn"
        Me.BasedrateDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'AssetcodeDataGridViewTextBoxColumn
        '
        Me.AssetcodeDataGridViewTextBoxColumn.DataPropertyName = "asset_code"
        Me.AssetcodeDataGridViewTextBoxColumn.HeaderText = "asset_code"
        Me.AssetcodeDataGridViewTextBoxColumn.Name = "AssetcodeDataGridViewTextBoxColumn"
        Me.AssetcodeDataGridViewTextBoxColumn.Visible = False
        '
        'HistoricalrateDataGridViewTextBoxColumn
        '
        Me.HistoricalrateDataGridViewTextBoxColumn.DataPropertyName = "historical_rate"
        Me.HistoricalrateDataGridViewTextBoxColumn.HeaderText = "historical_rate"
        Me.HistoricalrateDataGridViewTextBoxColumn.Name = "HistoricalrateDataGridViewTextBoxColumn"
        Me.HistoricalrateDataGridViewTextBoxColumn.Visible = False
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Visible = False
        '
        'DateacquiredDataGridViewTextBoxColumn
        '
        Me.DateacquiredDataGridViewTextBoxColumn.DataPropertyName = "date_acquired"
        Me.DateacquiredDataGridViewTextBoxColumn.HeaderText = "date_acquired"
        Me.DateacquiredDataGridViewTextBoxColumn.Name = "DateacquiredDataGridViewTextBoxColumn"
        Me.DateacquiredDataGridViewTextBoxColumn.Visible = False
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.Visible = False
        '
        'AmountbasedDataGridViewTextBoxColumn
        '
        Me.AmountbasedDataGridViewTextBoxColumn.DataPropertyName = "amount_based"
        Me.AmountbasedDataGridViewTextBoxColumn.HeaderText = "amount_based"
        Me.AmountbasedDataGridViewTextBoxColumn.Name = "AmountbasedDataGridViewTextBoxColumn"
        Me.AmountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'UsefullifeDataGridViewTextBoxColumn
        '
        Me.UsefullifeDataGridViewTextBoxColumn.DataPropertyName = "useful_life"
        Me.UsefullifeDataGridViewTextBoxColumn.HeaderText = "useful_life"
        Me.UsefullifeDataGridViewTextBoxColumn.Name = "UsefullifeDataGridViewTextBoxColumn"
        Me.UsefullifeDataGridViewTextBoxColumn.Visible = False
        '
        'DatestartDataGridViewTextBoxColumn
        '
        Me.DatestartDataGridViewTextBoxColumn.DataPropertyName = "date_start"
        Me.DatestartDataGridViewTextBoxColumn.HeaderText = "date_start"
        Me.DatestartDataGridViewTextBoxColumn.Name = "DatestartDataGridViewTextBoxColumn"
        Me.DatestartDataGridViewTextBoxColumn.Visible = False
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "debit"
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "debit"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        Me.DebitDataGridViewTextBoxColumn.Visible = False
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.Visible = False
        '
        'DebitbasedDataGridViewTextBoxColumn
        '
        Me.DebitbasedDataGridViewTextBoxColumn.DataPropertyName = "debit_based"
        Me.DebitbasedDataGridViewTextBoxColumn.HeaderText = "debit_based"
        Me.DebitbasedDataGridViewTextBoxColumn.Name = "DebitbasedDataGridViewTextBoxColumn"
        Me.DebitbasedDataGridViewTextBoxColumn.Visible = False
        '
        'CreditbasedDataGridViewTextBoxColumn
        '
        Me.CreditbasedDataGridViewTextBoxColumn.DataPropertyName = "credit_based"
        Me.CreditbasedDataGridViewTextBoxColumn.HeaderText = "credit_based"
        Me.CreditbasedDataGridViewTextBoxColumn.Name = "CreditbasedDataGridViewTextBoxColumn"
        Me.CreditbasedDataGridViewTextBoxColumn.Visible = False
        '
        'ReffixedassetidDataGridViewTextBoxColumn
        '
        Me.ReffixedassetidDataGridViewTextBoxColumn.DataPropertyName = "ref_fixed_asset_id"
        Me.ReffixedassetidDataGridViewTextBoxColumn.HeaderText = "ref_fixed_asset_id"
        Me.ReffixedassetidDataGridViewTextBoxColumn.Name = "ReffixedassetidDataGridViewTextBoxColumn"
        Me.ReffixedassetidDataGridViewTextBoxColumn.Visible = False
        '
        'RefnoDataGridViewTextBoxColumn
        '
        Me.RefnoDataGridViewTextBoxColumn.DataPropertyName = "ref_no"
        Me.RefnoDataGridViewTextBoxColumn.HeaderText = "ref_no"
        Me.RefnoDataGridViewTextBoxColumn.Name = "RefnoDataGridViewTextBoxColumn"
        Me.RefnoDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencycodeDataGridViewTextBoxColumn
        '
        Me.CurrencycodeDataGridViewTextBoxColumn.DataPropertyName = "currency_code"
        Me.CurrencycodeDataGridViewTextBoxColumn.HeaderText = "currency_code"
        Me.CurrencycodeDataGridViewTextBoxColumn.Name = "CurrencycodeDataGridViewTextBoxColumn"
        Me.CurrencycodeDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencynameDataGridViewTextBoxColumn
        '
        Me.CurrencynameDataGridViewTextBoxColumn.DataPropertyName = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.HeaderText = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.Name = "CurrencynameDataGridViewTextBoxColumn"
        Me.CurrencynameDataGridViewTextBoxColumn.Visible = False
        '
        'TmpamountDataGridViewTextBoxColumn
        '
        Me.TmpamountDataGridViewTextBoxColumn.DataPropertyName = "tmp_amount"
        Me.TmpamountDataGridViewTextBoxColumn.HeaderText = "tmp_amount"
        Me.TmpamountDataGridViewTextBoxColumn.Name = "TmpamountDataGridViewTextBoxColumn"
        Me.TmpamountDataGridViewTextBoxColumn.Visible = False
        '
        'IsInputtedDataGridViewCheckBoxColumn
        '
        Me.IsInputtedDataGridViewCheckBoxColumn.DataPropertyName = "isInputted"
        Me.IsInputtedDataGridViewCheckBoxColumn.HeaderText = "isInputted"
        Me.IsInputtedDataGridViewCheckBoxColumn.Name = "IsInputtedDataGridViewCheckBoxColumn"
        Me.IsInputtedDataGridViewCheckBoxColumn.Visible = False
        '
        'DeletedDataGridViewCheckBoxColumn
        '
        Me.DeletedDataGridViewCheckBoxColumn.DataPropertyName = "deleted"
        Me.DeletedDataGridViewCheckBoxColumn.HeaderText = "deleted"
        Me.DeletedDataGridViewCheckBoxColumn.Name = "DeletedDataGridViewCheckBoxColumn"
        Me.DeletedDataGridViewCheckBoxColumn.Visible = False
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.Visible = False
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.Visible = False
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date"
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "trans_date"
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        Me.TransdateDataGridViewTextBoxColumn.Visible = False
        '
        'SalvagevalueDataGridViewTextBoxColumn
        '
        Me.SalvagevalueDataGridViewTextBoxColumn.DataPropertyName = "salvage_value"
        Me.SalvagevalueDataGridViewTextBoxColumn.HeaderText = "salvage_value"
        Me.SalvagevalueDataGridViewTextBoxColumn.Name = "SalvagevalueDataGridViewTextBoxColumn"
        Me.SalvagevalueDataGridViewTextBoxColumn.Visible = False
        '
        'SalvagevaluebasedDataGridViewTextBoxColumn
        '
        Me.SalvagevaluebasedDataGridViewTextBoxColumn.DataPropertyName = "salvage_value_based"
        Me.SalvagevaluebasedDataGridViewTextBoxColumn.HeaderText = "salvage_value_based"
        Me.SalvagevaluebasedDataGridViewTextBoxColumn.Name = "SalvagevaluebasedDataGridViewTextBoxColumn"
        Me.SalvagevaluebasedDataGridViewTextBoxColumn.Visible = False
        '
        'ParticularsDataGridViewTextBoxColumn
        '
        Me.ParticularsDataGridViewTextBoxColumn.DataPropertyName = "particulars"
        Me.ParticularsDataGridViewTextBoxColumn.HeaderText = "particulars"
        Me.ParticularsDataGridViewTextBoxColumn.Name = "ParticularsDataGridViewTextBoxColumn"
        Me.ParticularsDataGridViewTextBoxColumn.Visible = False
        '
        'offsetfixedasset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 650)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.cboAll)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtjbooksid)
        Me.Controls.Add(Me.Borderedlabel1)
        Me.Controls.Add(Me.Borderedlabel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdNotSave)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgOffset)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "offsetfixedasset"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixed Asset Offsetting"
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fixed_asset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.bs_fixed_asset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtjbooksid As user_control.textbox
    Friend WithEvents Borderedlabel1 As accounting.borderedlabel
    Friend WithEvents Borderedlabel2 As accounting.borderedlabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdNotSave As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgOffset As System.Windows.Forms.DataGridView
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents fixed_asset As System.Data.DataTable
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents DataColumn87 As System.Data.DataColumn
    Friend WithEvents DataColumn88 As System.Data.DataColumn
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents DataColumn93 As System.Data.DataColumn
    Friend WithEvents DataColumn94 As System.Data.DataColumn
    Friend WithEvents DataColumn95 As System.Data.DataColumn
    Friend WithEvents DataColumn156 As System.Data.DataColumn
    Friend WithEvents DataColumn249 As System.Data.DataColumn
    Friend WithEvents DataColumn250 As System.Data.DataColumn
    Friend WithEvents DataColumn251 As System.Data.DataColumn
    Friend WithEvents DataColumn252 As System.Data.DataColumn
    Friend WithEvents DataColumn253 As System.Data.DataColumn
    Friend WithEvents DataColumn254 As System.Data.DataColumn
    Friend WithEvents DataColumn255 As System.Data.DataColumn
    Friend WithEvents DataColumn256 As System.Data.DataColumn
    Friend WithEvents DataColumn257 As System.Data.DataColumn
    Friend WithEvents DataColumn258 As System.Data.DataColumn
    Friend WithEvents DataColumn259 As System.Data.DataColumn
    Friend WithEvents DataColumn260 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents txttotal As user_control.textbox
    Friend WithEvents txt_search As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents cboAll As Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel1 As Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtDateFrom As Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtDateTo As Windows.Forms.DateTimePicker
    Friend WithEvents trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmp_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isInputted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FixedassetidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JbooksidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExchangerateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasedrateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssetcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HistoricalrateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateacquiredDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsefullifeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatestartDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReffixedassetidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencycodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencynameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TmpamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsInputtedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DeletedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalvagevalueDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalvagevaluebasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParticularsDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bs_fixed_asset As Windows.Forms.BindingSource
End Class
