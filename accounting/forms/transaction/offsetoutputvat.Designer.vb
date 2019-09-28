<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class offsetoutputvat
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdNotSave = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgOffset = New System.Windows.Forms.DataGridView()
        Me.bs_output_vat = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet()
        Me.output_vat = New System.Data.DataTable()
        Me.DataColumn118 = New System.Data.DataColumn()
        Me.DataColumn119 = New System.Data.DataColumn()
        Me.DataColumn120 = New System.Data.DataColumn()
        Me.DataColumn121 = New System.Data.DataColumn()
        Me.DataColumn122 = New System.Data.DataColumn()
        Me.DataColumn123 = New System.Data.DataColumn()
        Me.DataColumn124 = New System.Data.DataColumn()
        Me.DataColumn125 = New System.Data.DataColumn()
        Me.DataColumn126 = New System.Data.DataColumn()
        Me.DataColumn127 = New System.Data.DataColumn()
        Me.DataColumn128 = New System.Data.DataColumn()
        Me.DataColumn129 = New System.Data.DataColumn()
        Me.DataColumn130 = New System.Data.DataColumn()
        Me.DataColumn131 = New System.Data.DataColumn()
        Me.DataColumn132 = New System.Data.DataColumn()
        Me.DataColumn133 = New System.Data.DataColumn()
        Me.DataColumn134 = New System.Data.DataColumn()
        Me.DataColumn135 = New System.Data.DataColumn()
        Me.DataColumn136 = New System.Data.DataColumn()
        Me.DataColumn137 = New System.Data.DataColumn()
        Me.DataColumn158 = New System.Data.DataColumn()
        Me.DataColumn223 = New System.Data.DataColumn()
        Me.DataColumn224 = New System.Data.DataColumn()
        Me.DataColumn225 = New System.Data.DataColumn()
        Me.DataColumn226 = New System.Data.DataColumn()
        Me.DataColumn227 = New System.Data.DataColumn()
        Me.DataColumn228 = New System.Data.DataColumn()
        Me.DataColumn229 = New System.Data.DataColumn()
        Me.DataColumn230 = New System.Data.DataColumn()
        Me.DataColumn231 = New System.Data.DataColumn()
        Me.DataColumn232 = New System.Data.DataColumn()
        Me.DataColumn233 = New System.Data.DataColumn()
        Me.DataColumn234 = New System.Data.DataColumn()
        Me.DataColumn235 = New System.Data.DataColumn()
        Me.DataColumn236 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.rdo_adjustment = New user_control.rdo_button()
        Me.rdo_remittance = New user_control.rdo_button()
        Me.txtjbooksid = New user_control.textbox()
        Me.txt_offset_type = New System.Windows.Forms.GroupBox()
        Me.txttotal = New user_control.textbox()
        Me.txt_search = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboALl = New System.Windows.Forms.CheckBox()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.range_filter = New System.Windows.Forms.Panel()
        Me.rdo2 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.Borderedlabel1 = New accounting.borderedlabel()
        Me.Borderedlabel2 = New accounting.borderedlabel()
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_output_vat_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.particulars = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmp_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isInputted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.vat_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_output_vat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.output_vat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txt_offset_type.SuspendLayout()
        Me.range_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(462, 486)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 126
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
        Me.cmdNotSave.Location = New System.Drawing.Point(396, 522)
        Me.cmdNotSave.Name = "cmdNotSave"
        Me.cmdNotSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdNotSave.TabIndex = 125
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
        Me.cmdSave.Location = New System.Drawing.Point(290, 522)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdSave.TabIndex = 124
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 25)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Output VAT Offsetting"
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
        Me.dgOffset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_no, Me.ref_output_vat_id, Me.description, Me.particulars, Me.trans_date, Me.ref_no, Me.general_name, Me.tmp_amount, Me.isInputted, Me.vat_amount, Me.balance, Me.SelDataGridViewCheckBoxColumn})
        Me.dgOffset.DataSource = Me.bs_output_vat
        Me.dgOffset.Location = New System.Drawing.Point(21, 115)
        Me.dgOffset.MultiSelect = False
        Me.dgOffset.Name = "dgOffset"
        Me.dgOffset.RowHeadersVisible = False
        Me.dgOffset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOffset.Size = New System.Drawing.Size(745, 361)
        Me.dgOffset.TabIndex = 120
        '
        'bs_output_vat
        '
        Me.bs_output_vat.DataMember = "output_vat"
        Me.bs_output_vat.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.output_vat})
        '
        'output_vat
        '
        Me.output_vat.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn118, Me.DataColumn119, Me.DataColumn120, Me.DataColumn121, Me.DataColumn122, Me.DataColumn123, Me.DataColumn124, Me.DataColumn125, Me.DataColumn126, Me.DataColumn127, Me.DataColumn128, Me.DataColumn129, Me.DataColumn130, Me.DataColumn131, Me.DataColumn132, Me.DataColumn133, Me.DataColumn134, Me.DataColumn135, Me.DataColumn136, Me.DataColumn137, Me.DataColumn158, Me.DataColumn223, Me.DataColumn224, Me.DataColumn225, Me.DataColumn226, Me.DataColumn227, Me.DataColumn228, Me.DataColumn229, Me.DataColumn230, Me.DataColumn231, Me.DataColumn232, Me.DataColumn233, Me.DataColumn234, Me.DataColumn235, Me.DataColumn236, Me.DataColumn1, Me.DataColumn2})
        Me.output_vat.TableName = "output_vat"
        '
        'DataColumn118
        '
        Me.DataColumn118.ColumnName = "sel"
        Me.DataColumn118.DataType = GetType(Boolean)
        Me.DataColumn118.DefaultValue = False
        '
        'DataColumn119
        '
        Me.DataColumn119.ColumnName = "output_vat_id"
        Me.DataColumn119.DefaultValue = ""
        '
        'DataColumn120
        '
        Me.DataColumn120.ColumnName = "jbooks_id"
        Me.DataColumn120.DefaultValue = ""
        '
        'DataColumn121
        '
        Me.DataColumn121.ColumnName = "general_id"
        Me.DataColumn121.DefaultValue = ""
        '
        'DataColumn122
        '
        Me.DataColumn122.ColumnName = "currency_id"
        Me.DataColumn122.DefaultValue = ""
        '
        'DataColumn123
        '
        Me.DataColumn123.ColumnName = "exchange_rate"
        Me.DataColumn123.DataType = GetType(Decimal)
        Me.DataColumn123.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn124
        '
        Me.DataColumn124.ColumnName = "based_rate"
        Me.DataColumn124.DataType = GetType(Decimal)
        Me.DataColumn124.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn125
        '
        Me.DataColumn125.ColumnName = "offset_type"
        Me.DataColumn125.DefaultValue = ""
        '
        'DataColumn126
        '
        Me.DataColumn126.ColumnName = "vat_class"
        Me.DataColumn126.DefaultValue = ""
        '
        'DataColumn127
        '
        Me.DataColumn127.ColumnName = "vat_type"
        Me.DataColumn127.DefaultValue = ""
        '
        'DataColumn128
        '
        Me.DataColumn128.ColumnName = "vat_rate"
        Me.DataColumn128.DataType = GetType(Decimal)
        Me.DataColumn128.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn129
        '
        Me.DataColumn129.ColumnName = "gross_amount"
        Me.DataColumn129.DataType = GetType(Decimal)
        Me.DataColumn129.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn130
        '
        Me.DataColumn130.ColumnName = "vat_amount"
        Me.DataColumn130.DataType = GetType(Decimal)
        Me.DataColumn130.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn131
        '
        Me.DataColumn131.ColumnName = "net_amount"
        Me.DataColumn131.DataType = GetType(Decimal)
        Me.DataColumn131.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn132
        '
        Me.DataColumn132.ColumnName = "debit"
        Me.DataColumn132.DataType = GetType(Decimal)
        Me.DataColumn132.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn133
        '
        Me.DataColumn133.ColumnName = "credit"
        Me.DataColumn133.DataType = GetType(Decimal)
        Me.DataColumn133.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn134
        '
        Me.DataColumn134.ColumnName = "gross_amount_based"
        Me.DataColumn134.DataType = GetType(Decimal)
        Me.DataColumn134.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn135
        '
        Me.DataColumn135.ColumnName = "vat_amount_based"
        Me.DataColumn135.DataType = GetType(Decimal)
        Me.DataColumn135.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn136
        '
        Me.DataColumn136.ColumnName = "net_amount_based"
        Me.DataColumn136.DataType = GetType(Decimal)
        Me.DataColumn136.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn137
        '
        Me.DataColumn137.ColumnName = "debit_based"
        Me.DataColumn137.DataType = GetType(Decimal)
        Me.DataColumn137.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn158
        '
        Me.DataColumn158.ColumnName = "credit_based"
        Me.DataColumn158.DataType = GetType(Decimal)
        Me.DataColumn158.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn223
        '
        Me.DataColumn223.ColumnName = "ref_output_vat_id"
        Me.DataColumn223.DefaultValue = ""
        '
        'DataColumn224
        '
        Me.DataColumn224.ColumnName = "ref_no"
        Me.DataColumn224.DefaultValue = ""
        '
        'DataColumn225
        '
        Me.DataColumn225.ColumnName = "general_code"
        Me.DataColumn225.DefaultValue = ""
        '
        'DataColumn226
        '
        Me.DataColumn226.ColumnName = "general_name"
        Me.DataColumn226.DefaultValue = ""
        '
        'DataColumn227
        '
        Me.DataColumn227.ColumnName = "currency_code"
        Me.DataColumn227.DefaultValue = ""
        '
        'DataColumn228
        '
        Me.DataColumn228.ColumnName = "currency_name"
        Me.DataColumn228.DefaultValue = ""
        '
        'DataColumn229
        '
        Me.DataColumn229.ColumnName = "tmp_amount"
        Me.DataColumn229.DataType = GetType(Decimal)
        Me.DataColumn229.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn230
        '
        Me.DataColumn230.ColumnName = "address"
        Me.DataColumn230.DefaultValue = ""
        '
        'DataColumn231
        '
        Me.DataColumn231.ColumnName = "tin"
        Me.DataColumn231.DefaultValue = ""
        '
        'DataColumn232
        '
        Me.DataColumn232.ColumnName = "isInputted"
        Me.DataColumn232.DataType = GetType(Boolean)
        Me.DataColumn232.DefaultValue = False
        '
        'DataColumn233
        '
        Me.DataColumn233.ColumnName = "deleted"
        Me.DataColumn233.DataType = GetType(Boolean)
        Me.DataColumn233.DefaultValue = False
        '
        'DataColumn234
        '
        Me.DataColumn234.ColumnName = "balance"
        Me.DataColumn234.DataType = GetType(Decimal)
        Me.DataColumn234.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn235
        '
        Me.DataColumn235.ColumnName = "trans_no"
        Me.DataColumn235.DefaultValue = ""
        '
        'DataColumn236
        '
        Me.DataColumn236.ColumnName = "trans_date"
        Me.DataColumn236.DataType = GetType(Date)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "particulars"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "description"
        Me.DataColumn2.DefaultValue = ""
        '
        'rdo_adjustment
        '
        Me.rdo_adjustment.AutoSize = True
        Me.rdo_adjustment.DataSource = ""
        Me.rdo_adjustment.Location = New System.Drawing.Point(91, 15)
        Me.rdo_adjustment.Name = "rdo_adjustment"
        Me.rdo_adjustment.Size = New System.Drawing.Size(76, 17)
        Me.rdo_adjustment.TabIndex = 1
        Me.rdo_adjustment.Text = "Adjusment"
        Me.rdo_adjustment.TextSource = ""
        Me.rdo_adjustment.Uncheckable = False
        Me.rdo_adjustment.UseVisualStyleBackColor = True
        Me.rdo_adjustment.Value = "2"
        Me.rdo_adjustment.ValueSource = ""
        '
        'rdo_remittance
        '
        Me.rdo_remittance.AutoSize = True
        Me.rdo_remittance.Checked = True
        Me.rdo_remittance.DataSource = ""
        Me.rdo_remittance.Location = New System.Drawing.Point(6, 15)
        Me.rdo_remittance.Name = "rdo_remittance"
        Me.rdo_remittance.Size = New System.Drawing.Size(79, 17)
        Me.rdo_remittance.TabIndex = 0
        Me.rdo_remittance.TabStop = True
        Me.rdo_remittance.Text = "Remittance"
        Me.rdo_remittance.TextSource = ""
        Me.rdo_remittance.Uncheckable = False
        Me.rdo_remittance.UseVisualStyleBackColor = True
        Me.rdo_remittance.Value = "1"
        Me.rdo_remittance.ValueSource = ""
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
        Me.txtjbooksid.Location = New System.Drawing.Point(268, 40)
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
        Me.txtjbooksid.TabIndex = 131
        Me.txtjbooksid.TableData = Nothing
        Me.txtjbooksid.TextSource = ""
        Me.txtjbooksid.UseSystemPasswordChar = False
        Me.txtjbooksid.Value = ""
        Me.txtjbooksid.ValueSource = ""
        Me.txtjbooksid.Visible = False
        '
        'txt_offset_type
        '
        Me.txt_offset_type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_offset_type.Controls.Add(Me.rdo_adjustment)
        Me.txt_offset_type.Controls.Add(Me.rdo_remittance)
        Me.txt_offset_type.Location = New System.Drawing.Point(587, 71)
        Me.txt_offset_type.Name = "txt_offset_type"
        Me.txt_offset_type.Size = New System.Drawing.Size(178, 38)
        Me.txt_offset_type.TabIndex = 130
        Me.txt_offset_type.TabStop = False
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
        Me.txttotal.Location = New System.Drawing.Point(507, 482)
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
        Me.txttotal.TabIndex = 132
        Me.txttotal.TableData = Nothing
        Me.txttotal.TextSource = ""
        Me.txttotal.UseSystemPasswordChar = False
        Me.txttotal.Value = "0.00"
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
        Me.txt_search.Location = New System.Drawing.Point(565, 40)
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
        Me.txt_search.TabIndex = 135
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
        Me.Label2.Location = New System.Drawing.Point(523, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Search"
        '
        'cboALl
        '
        Me.cboALl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboALl.AutoSize = True
        Me.cboALl.Location = New System.Drawing.Point(544, 86)
        Me.cboALl.Name = "cboALl"
        Me.cboALl.Size = New System.Drawing.Size(37, 17)
        Me.cboALl.TabIndex = 136
        Me.cboALl.Text = "All"
        Me.cboALl.UseVisualStyleBackColor = True
        '
        'txt_date_to
        '
        Me.txt_date_to.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(419, 88)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 21)
        Me.txt_date_to.TabIndex = 139
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Date To"
        '
        'txt_date_from
        '
        Me.txt_date_from.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(256, 88)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(100, 21)
        Me.txt_date_from.TabIndex = 138
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Date From"
        '
        'range_filter
        '
        Me.range_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Location = New System.Drawing.Point(-44, 79)
        Me.range_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(232, 30)
        Me.range_filter.TabIndex = 137
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.DataSource = ""
        Me.rdo2.Location = New System.Drawing.Point(130, 7)
        Me.rdo2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(100, 17)
        Me.rdo2.TabIndex = 2
        Me.rdo2.Text = "To Date / As Of"
        Me.rdo2.TextSource = ""
        Me.rdo2.Uncheckable = False
        Me.rdo2.UseVisualStyleBackColor = True
        Me.rdo2.Value = "2"
        Me.rdo2.ValueSource = ""
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Checked = True
        Me.rdo1.DataSource = ""
        Me.rdo1.Location = New System.Drawing.Point(35, 7)
        Me.rdo1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(81, 17)
        Me.rdo1.TabIndex = 1
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Range Only"
        Me.rdo1.TextSource = ""
        Me.rdo1.Uncheckable = False
        Me.rdo1.UseVisualStyleBackColor = True
        Me.rdo1.Value = "1"
        Me.rdo1.ValueSource = ""
        '
        'Borderedlabel1
        '
        Me.Borderedlabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Borderedlabel1.BorderColor = System.Drawing.Color.White
        Me.Borderedlabel1.Location = New System.Drawing.Point(21, 511)
        Me.Borderedlabel1.Name = "Borderedlabel1"
        Me.Borderedlabel1.Size = New System.Drawing.Size(745, 2)
        Me.Borderedlabel1.TabIndex = 129
        Me.Borderedlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Borderedlabel2
        '
        Me.Borderedlabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Borderedlabel2.BorderColor = System.Drawing.Color.DarkGray
        Me.Borderedlabel2.Location = New System.Drawing.Point(21, 509)
        Me.Borderedlabel2.Name = "Borderedlabel2"
        Me.Borderedlabel2.Size = New System.Drawing.Size(745, 2)
        Me.Borderedlabel2.TabIndex = 128
        Me.Borderedlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border2
        '
        Me.border2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(21, 65)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(745, 2)
        Me.border2.TabIndex = 123
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(21, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(745, 2)
        Me.border1.TabIndex = 122
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trans_no
        '
        Me.trans_no.DataPropertyName = "trans_no"
        Me.trans_no.HeaderText = "Reference No."
        Me.trans_no.MinimumWidth = 100
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        Me.trans_no.Width = 120
        '
        'ref_output_vat_id
        '
        Me.ref_output_vat_id.DataPropertyName = "ref_output_vat_id"
        Me.ref_output_vat_id.HeaderText = "ref_output_vat_id"
        Me.ref_output_vat_id.Name = "ref_output_vat_id"
        Me.ref_output_vat_id.Visible = False
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "Particulars"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'particulars
        '
        Me.particulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.particulars.DataPropertyName = "particulars"
        Me.particulars.HeaderText = "Line Remarks"
        Me.particulars.Name = "particulars"
        Me.particulars.ReadOnly = True
        Me.particulars.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'trans_date
        '
        Me.trans_date.DataPropertyName = "trans_date"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "00/00/0000"
        Me.trans_date.DefaultCellStyle = DataGridViewCellStyle1
        Me.trans_date.HeaderText = "Reference Date"
        Me.trans_date.Name = "trans_date"
        Me.trans_date.ReadOnly = True
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
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Gen. Ref."
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        Me.general_name.Width = 160
        '
        'tmp_amount
        '
        Me.tmp_amount.DataPropertyName = "tmp_amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "##,##0.00"
        Me.tmp_amount.DefaultCellStyle = DataGridViewCellStyle2
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
        'vat_amount
        '
        Me.vat_amount.DataPropertyName = "vat_amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "##,##0.00"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.vat_amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.vat_amount.HeaderText = "Amount Remitted"
        Me.vat_amount.Name = "vat_amount"
        Me.vat_amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.vat_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.vat_amount.Width = 120
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "##,##0.00"
        Me.balance.DefaultCellStyle = DataGridViewCellStyle4
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
        '
        'offsetoutputvat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.range_filter)
        Me.Controls.Add(Me.cboALl)
        Me.Controls.Add(Me.dgOffset)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdNotSave)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtjbooksid)
        Me.Controls.Add(Me.Borderedlabel1)
        Me.Controls.Add(Me.Borderedlabel2)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.txt_offset_type)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "offsetoutputvat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Output VAT Offsetting"
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_output_vat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.output_vat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txt_offset_type.ResumeLayout(False)
        Me.txt_offset_type.PerformLayout()
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdNotSave As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgOffset As System.Windows.Forms.DataGridView
    Friend WithEvents rdo_adjustment As user_control.rdo_button
    Friend WithEvents rdo_remittance As user_control.rdo_button
    Friend WithEvents txtjbooksid As user_control.textbox
    Friend WithEvents Borderedlabel1 As accounting.borderedlabel
    Friend WithEvents Borderedlabel2 As accounting.borderedlabel
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents txt_offset_type As System.Windows.Forms.GroupBox
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents output_vat As System.Data.DataTable
    Friend WithEvents DataColumn118 As System.Data.DataColumn
    Friend WithEvents DataColumn119 As System.Data.DataColumn
    Friend WithEvents DataColumn120 As System.Data.DataColumn
    Friend WithEvents DataColumn121 As System.Data.DataColumn
    Friend WithEvents DataColumn122 As System.Data.DataColumn
    Friend WithEvents DataColumn123 As System.Data.DataColumn
    Friend WithEvents DataColumn124 As System.Data.DataColumn
    Friend WithEvents DataColumn125 As System.Data.DataColumn
    Friend WithEvents DataColumn126 As System.Data.DataColumn
    Friend WithEvents DataColumn127 As System.Data.DataColumn
    Friend WithEvents DataColumn128 As System.Data.DataColumn
    Friend WithEvents DataColumn129 As System.Data.DataColumn
    Friend WithEvents DataColumn130 As System.Data.DataColumn
    Friend WithEvents DataColumn131 As System.Data.DataColumn
    Friend WithEvents DataColumn132 As System.Data.DataColumn
    Friend WithEvents DataColumn133 As System.Data.DataColumn
    Friend WithEvents DataColumn134 As System.Data.DataColumn
    Friend WithEvents DataColumn135 As System.Data.DataColumn
    Friend WithEvents DataColumn136 As System.Data.DataColumn
    Friend WithEvents DataColumn137 As System.Data.DataColumn
    Friend WithEvents DataColumn158 As System.Data.DataColumn
    Friend WithEvents DataColumn223 As System.Data.DataColumn
    Friend WithEvents DataColumn224 As System.Data.DataColumn
    Friend WithEvents DataColumn225 As System.Data.DataColumn
    Friend WithEvents DataColumn226 As System.Data.DataColumn
    Friend WithEvents DataColumn227 As System.Data.DataColumn
    Friend WithEvents DataColumn228 As System.Data.DataColumn
    Friend WithEvents DataColumn229 As System.Data.DataColumn
    Friend WithEvents DataColumn230 As System.Data.DataColumn
    Friend WithEvents DataColumn231 As System.Data.DataColumn
    Friend WithEvents DataColumn232 As System.Data.DataColumn
    Friend WithEvents DataColumn233 As System.Data.DataColumn
    Friend WithEvents DataColumn234 As System.Data.DataColumn
    Friend WithEvents DataColumn235 As System.Data.DataColumn
    Friend WithEvents DataColumn236 As System.Data.DataColumn
    Friend WithEvents txttotal As user_control.textbox
    Friend WithEvents txt_search As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents cboALl As Windows.Forms.CheckBox
    Friend WithEvents bs_output_vat As Windows.Forms.BindingSource
    Friend WithEvents txt_date_to As Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_date_from As Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents range_filter As Windows.Forms.Panel
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_output_vat_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents particulars As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmp_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isInputted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents vat_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
End Class
