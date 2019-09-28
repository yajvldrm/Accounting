<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setupfixedasset
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
        Me.dgdet = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.fixed_asset_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_acquired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asset_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useful_life = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.offset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.btndet1 = New System.Windows.Forms.Panel()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.det = New System.Windows.Forms.Panel()
        Me.txt_useful_life = New DevExpress.XtraEditors.TextEdit()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.txt_salvage_value = New DevExpress.XtraEditors.TextEdit()
        Me.txt_quantity = New DevExpress.XtraEditors.TextEdit()
        Me.txt_historical_rate = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_asset_code = New user_control.textbox()
        Me.txt_description = New user_control.textbox()
        Me.txt_date_start = New System.Windows.Forms.DateTimePicker()
        Me.txt_date_acquired = New System.Windows.Forms.DateTimePicker()
        Me.btndet2 = New System.Windows.Forms.Panel()
        Me.btnundo = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnhdr2 = New System.Windows.Forms.Panel()
        Me.btnnotsave = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Myformheader1 = New user_control.myformheader()
        CType(Me.dgdet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fixed_asset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btndet1.SuspendLayout()
        Me.det.SuspendLayout()
        CType(Me.txt_useful_life.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_salvage_value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_historical_rate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btndet2.SuspendLayout()
        Me.btnhdr2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgdet
        '
        Me.dgdet.AllowUserToAddRows = False
        Me.dgdet.AllowUserToDeleteRows = False
        Me.dgdet.AllowUserToResizeColumns = False
        Me.dgdet.AllowUserToResizeRows = False
        Me.dgdet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgdet.BackgroundColor = System.Drawing.Color.White
        Me.dgdet.ColumnHeadersHeight = 28
        Me.dgdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.deleted, Me.fixed_asset_id, Me.description, Me.date_acquired, Me.asset_code, Me.amount, Me.useful_life, Me.offset, Me.minimum})
        Me.dgdet.Location = New System.Drawing.Point(17, 77)
        Me.dgdet.Name = "dgdet"
        Me.dgdet.RowHeadersVisible = False
        Me.dgdet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgdet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdet.Size = New System.Drawing.Size(691, 143)
        Me.dgdet.TabIndex = 0
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.Width = 30
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Visible = False
        '
        'fixed_asset_id
        '
        Me.fixed_asset_id.DataPropertyName = "fixed_asset_id"
        Me.fixed_asset_id.HeaderText = "fixed_asset_id"
        Me.fixed_asset_id.Name = "fixed_asset_id"
        Me.fixed_asset_id.Visible = False
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_acquired
        '
        Me.date_acquired.DataPropertyName = "date_acquired"
        Me.date_acquired.HeaderText = "Date Acquired"
        Me.date_acquired.Name = "date_acquired"
        Me.date_acquired.ReadOnly = True
        Me.date_acquired.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.date_acquired.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'asset_code
        '
        Me.asset_code.DataPropertyName = "asset_code"
        Me.asset_code.HeaderText = "Asset Code"
        Me.asset_code.Name = "asset_code"
        Me.asset_code.ReadOnly = True
        Me.asset_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.asset_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.asset_code.Width = 140
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        Me.amount.HeaderText = "Acquisition Cost"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'useful_life
        '
        Me.useful_life.DataPropertyName = "useful_life"
        Me.useful_life.HeaderText = "Useful Life"
        Me.useful_life.Name = "useful_life"
        Me.useful_life.ReadOnly = True
        Me.useful_life.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.useful_life.Width = 70
        '
        'offset
        '
        Me.offset.DataPropertyName = "offset"
        Me.offset.HeaderText = "offset"
        Me.offset.Name = "offset"
        Me.offset.Visible = False
        '
        'minimum
        '
        Me.minimum.DataPropertyName = "minimum"
        Me.minimum.HeaderText = "minimum"
        Me.minimum.Name = "minimum"
        Me.minimum.Visible = False
        '
        'border2
        '
        Me.border2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(17, 64)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(691, 2)
        Me.border2.TabIndex = 5
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(17, 62)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(691, 2)
        Me.border1.TabIndex = 4
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fixed Asset Details"
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.fixed_asset})
        '
        'fixed_asset
        '
        Me.fixed_asset.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn156, Me.DataColumn249, Me.DataColumn250, Me.DataColumn251, Me.DataColumn252, Me.DataColumn253, Me.DataColumn254, Me.DataColumn255, Me.DataColumn256, Me.DataColumn257, Me.DataColumn258, Me.DataColumn259, Me.DataColumn260, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
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
        Me.DataColumn3.ColumnName = "offset"
        Me.DataColumn3.DataType = GetType(Integer)
        Me.DataColumn3.DefaultValue = 0
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "minimum"
        Me.DataColumn4.DataType = GetType(Decimal)
        Me.DataColumn4.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btndet1
        '
        Me.btndet1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndet1.Controls.Add(Me.btnremove)
        Me.btndet1.Controls.Add(Me.btninsert)
        Me.btndet1.Controls.Add(Me.btnupdate)
        Me.btndet1.Location = New System.Drawing.Point(20, 226)
        Me.btndet1.Name = "btndet1"
        Me.btndet1.Size = New System.Drawing.Size(256, 26)
        Me.btndet1.TabIndex = 126
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ForeColor = System.Drawing.Color.White
        Me.btnremove.Location = New System.Drawing.Point(174, 1)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(80, 24)
        Me.btnremove.TabIndex = 3
        Me.btnremove.Text = "F4 Remove"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.Color.White
        Me.btninsert.Location = New System.Drawing.Point(2, 1)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(80, 24)
        Me.btninsert.TabIndex = 1
        Me.btninsert.Text = "F2 Insert"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(88, 1)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(80, 24)
        Me.btnupdate.TabIndex = 2
        Me.btnupdate.Text = "F3 Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'det
        '
        Me.det.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.det.Controls.Add(Me.txt_useful_life)
        Me.det.Controls.Add(Me.txt_amount)
        Me.det.Controls.Add(Me.txt_salvage_value)
        Me.det.Controls.Add(Me.txt_quantity)
        Me.det.Controls.Add(Me.txt_historical_rate)
        Me.det.Controls.Add(Me.Label7)
        Me.det.Controls.Add(Me.txt_asset_code)
        Me.det.Controls.Add(Me.txt_description)
        Me.det.Controls.Add(Me.txt_date_start)
        Me.det.Controls.Add(Me.txt_date_acquired)
        Me.det.Controls.Add(Me.btndet2)
        Me.det.Controls.Add(Me.Label6)
        Me.det.Controls.Add(Me.Label9)
        Me.det.Controls.Add(Me.Label8)
        Me.det.Controls.Add(Me.Label4)
        Me.det.Controls.Add(Me.Label5)
        Me.det.Controls.Add(Me.Label3)
        Me.det.Controls.Add(Me.Label22)
        Me.det.Controls.Add(Me.Label2)
        Me.det.Location = New System.Drawing.Point(17, 261)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(691, 121)
        Me.det.TabIndex = 127
        '
        'txt_useful_life
        '
        Me.txt_useful_life.EditValue = "0"
        Me.txt_useful_life.Enabled = False
        Me.txt_useful_life.Location = New System.Drawing.Point(337, 87)
        Me.txt_useful_life.Name = "txt_useful_life"
        Me.txt_useful_life.Properties.DisplayFormat.FormatString = "n"
        Me.txt_useful_life.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_useful_life.Properties.EditFormat.FormatString = "n"
        Me.txt_useful_life.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_useful_life.Properties.Mask.EditMask = "n"
        Me.txt_useful_life.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_useful_life.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_useful_life.Size = New System.Drawing.Size(100, 20)
        Me.txt_useful_life.TabIndex = 10
        Me.txt_useful_life.Tag = "useful_life"
        '
        'txt_amount
        '
        Me.txt_amount.EditValue = "0.00"
        Me.txt_amount.Enabled = False
        Me.txt_amount.Location = New System.Drawing.Point(94, 87)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.DisplayFormat.FormatString = "n4"
        Me.txt_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount.Properties.EditFormat.FormatString = "n4"
        Me.txt_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount.Properties.Mask.EditMask = "n4"
        Me.txt_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_amount.Size = New System.Drawing.Size(174, 20)
        Me.txt_amount.TabIndex = 9
        Me.txt_amount.Tag = "amount"
        '
        'txt_salvage_value
        '
        Me.txt_salvage_value.EditValue = "0.00"
        Me.txt_salvage_value.Enabled = False
        Me.txt_salvage_value.Location = New System.Drawing.Point(531, 61)
        Me.txt_salvage_value.Name = "txt_salvage_value"
        Me.txt_salvage_value.Properties.DisplayFormat.FormatString = "n4"
        Me.txt_salvage_value.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_salvage_value.Properties.EditFormat.FormatString = "n4"
        Me.txt_salvage_value.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_salvage_value.Properties.Mask.EditMask = "n4"
        Me.txt_salvage_value.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_salvage_value.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_salvage_value.Size = New System.Drawing.Size(153, 20)
        Me.txt_salvage_value.TabIndex = 8
        Me.txt_salvage_value.Tag = "salvage_value"
        '
        'txt_quantity
        '
        Me.txt_quantity.EditValue = "0"
        Me.txt_quantity.Enabled = False
        Me.txt_quantity.Location = New System.Drawing.Point(337, 61)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Properties.DisplayFormat.FormatString = "n"
        Me.txt_quantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_quantity.Properties.EditFormat.FormatString = "n"
        Me.txt_quantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_quantity.Properties.Mask.EditMask = "n"
        Me.txt_quantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_quantity.Size = New System.Drawing.Size(100, 20)
        Me.txt_quantity.TabIndex = 7
        Me.txt_quantity.Tag = "quantity"
        '
        'txt_historical_rate
        '
        Me.txt_historical_rate.EditValue = "0.00"
        Me.txt_historical_rate.Enabled = False
        Me.txt_historical_rate.Location = New System.Drawing.Point(531, 9)
        Me.txt_historical_rate.Name = "txt_historical_rate"
        Me.txt_historical_rate.Properties.DisplayFormat.FormatString = "n4"
        Me.txt_historical_rate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_historical_rate.Properties.EditFormat.FormatString = "n4"
        Me.txt_historical_rate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_historical_rate.Properties.Mask.EditMask = "n4"
        Me.txt_historical_rate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_historical_rate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_historical_rate.Size = New System.Drawing.Size(153, 20)
        Me.txt_historical_rate.TabIndex = 4
        Me.txt_historical_rate.Tag = "historical_rate"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(451, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Salvage Value"
        '
        'txt_asset_code
        '
        Me.txt_asset_code._Text = ""
        Me.txt_asset_code.AllowNegative = False
        Me.txt_asset_code.AlwaysDisable = False
        Me.txt_asset_code.AlwaysEnable = False
        Me.txt_asset_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_asset_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_asset_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_asset_code.DataSource = ""
        Me.txt_asset_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_asset_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_asset_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_asset_code.Enabled = False
        Me.txt_asset_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_asset_code.ispk = False
        Me.txt_asset_code.Location = New System.Drawing.Point(94, 61)
        Me.txt_asset_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_asset_code.MultiLine = False
        Me.txt_asset_code.Name = "txt_asset_code"
        Me.txt_asset_code.NoClear = False
        Me.txt_asset_code.NumberFormat = "@"
        Me.txt_asset_code.Required = False
        Me.txt_asset_code.RowData = Nothing
        Me.txt_asset_code.SelectionLength = 0
        Me.txt_asset_code.SelectionStart = 0
        Me.txt_asset_code.Size = New System.Drawing.Size(174, 20)
        Me.txt_asset_code.TabIndex = 6
        Me.txt_asset_code.TableData = Nothing
        Me.txt_asset_code.TextSource = "asset_code"
        Me.txt_asset_code.UseSystemPasswordChar = False
        Me.txt_asset_code.Value = ""
        Me.txt_asset_code.ValueSource = ""
        '
        'txt_description
        '
        Me.txt_description._Text = ""
        Me.txt_description.AllowNegative = False
        Me.txt_description.AlwaysDisable = False
        Me.txt_description.AlwaysEnable = False
        Me.txt_description.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_description.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_description.DataSource = ""
        Me.txt_description.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_description.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_description.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_description.Enabled = False
        Me.txt_description.EnabledBackColor = System.Drawing.Color.White
        Me.txt_description.ispk = False
        Me.txt_description.Location = New System.Drawing.Point(94, 35)
        Me.txt_description.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_description.MultiLine = False
        Me.txt_description.Name = "txt_description"
        Me.txt_description.NoClear = False
        Me.txt_description.NumberFormat = "@"
        Me.txt_description.Required = False
        Me.txt_description.RowData = Nothing
        Me.txt_description.SelectionLength = 0
        Me.txt_description.SelectionStart = 0
        Me.txt_description.Size = New System.Drawing.Size(590, 20)
        Me.txt_description.TabIndex = 5
        Me.txt_description.TableData = Nothing
        Me.txt_description.TextSource = "description"
        Me.txt_description.UseSystemPasswordChar = False
        Me.txt_description.Value = ""
        Me.txt_description.ValueSource = ""
        '
        'txt_date_start
        '
        Me.txt_date_start.Enabled = False
        Me.txt_date_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_start.Location = New System.Drawing.Point(337, 8)
        Me.txt_date_start.Name = "txt_date_start"
        Me.txt_date_start.Size = New System.Drawing.Size(100, 21)
        Me.txt_date_start.TabIndex = 3
        '
        'txt_date_acquired
        '
        Me.txt_date_acquired.Enabled = False
        Me.txt_date_acquired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_acquired.Location = New System.Drawing.Point(94, 8)
        Me.txt_date_acquired.Name = "txt_date_acquired"
        Me.txt_date_acquired.Size = New System.Drawing.Size(97, 21)
        Me.txt_date_acquired.TabIndex = 2
        '
        'btndet2
        '
        Me.btndet2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndet2.Controls.Add(Me.btnundo)
        Me.btndet2.Controls.Add(Me.btnok)
        Me.btndet2.Location = New System.Drawing.Point(517, 90)
        Me.btndet2.Name = "btndet2"
        Me.btndet2.Size = New System.Drawing.Size(169, 26)
        Me.btndet2.TabIndex = 132
        '
        'btnundo
        '
        Me.btnundo.BackColor = System.Drawing.Color.Maroon
        Me.btnundo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnundo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnundo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnundo.ForeColor = System.Drawing.Color.White
        Me.btnundo.Location = New System.Drawing.Point(87, 1)
        Me.btnundo.Name = "btnundo"
        Me.btnundo.Size = New System.Drawing.Size(80, 24)
        Me.btnundo.TabIndex = 16
        Me.btnundo.Text = "Cancel"
        Me.btnundo.UseVisualStyleBackColor = False
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.Green
        Me.btnok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(1, 1)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(80, 24)
        Me.btnok.TabIndex = 15
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Description"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(449, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "Historical Rate"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Lapsing Start Date"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Useful Life"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Acquisition Cost"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 117
        Me.Label22.Text = "Date Acquired"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Asset Code"
        '
        'btnhdr2
        '
        Me.btnhdr2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnhdr2.Controls.Add(Me.btnnotsave)
        Me.btnhdr2.Controls.Add(Me.btnsave)
        Me.btnhdr2.Location = New System.Drawing.Point(276, 392)
        Me.btnhdr2.Name = "btnhdr2"
        Me.btnhdr2.Size = New System.Drawing.Size(168, 26)
        Me.btnhdr2.TabIndex = 133
        '
        'btnnotsave
        '
        Me.btnnotsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnnotsave.BackColor = System.Drawing.Color.Maroon
        Me.btnnotsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnnotsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnotsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnotsave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnotsave.ForeColor = System.Drawing.Color.White
        Me.btnnotsave.Location = New System.Drawing.Point(87, 1)
        Me.btnnotsave.Name = "btnnotsave"
        Me.btnnotsave.Size = New System.Drawing.Size(80, 24)
        Me.btnnotsave.TabIndex = 5
        Me.btnnotsave.Text = "&Cancel"
        Me.btnnotsave.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsave.BackColor = System.Drawing.Color.Green
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(1, 1)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 24)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(720, 28)
        Me.Myformheader1.TabIndex = 134
        '
        'setupfixedasset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 434)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btndet1)
        Me.Controls.Add(Me.btnhdr2)
        Me.Controls.Add(Me.det)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdet)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setupfixedasset"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixed Asset Details"
        CType(Me.dgdet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fixed_asset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btndet1.ResumeLayout(False)
        Me.det.ResumeLayout(False)
        Me.det.PerformLayout()
        CType(Me.txt_useful_life.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_salvage_value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_historical_rate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btndet2.ResumeLayout(False)
        Me.btnhdr2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgdet As System.Windows.Forms.DataGridView
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents btndet1 As System.Windows.Forms.Panel
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents det As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btndet2 As System.Windows.Forms.Panel
    Friend WithEvents btnundo As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnhdr2 As System.Windows.Forms.Panel
    Friend WithEvents btnnotsave As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txt_date_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_date_acquired As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_asset_code As user_control.textbox
    Friend WithEvents txt_description As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents fixed_asset_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_acquired As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asset_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents useful_life As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents offset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minimum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_useful_life As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_salvage_value As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_quantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_historical_rate As DevExpress.XtraEditors.TextEdit
End Class
