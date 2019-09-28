<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class offsetfinaltax
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
        Me.border2 = New accounting.borderedlabel()
        Me.txtjbooksid = New user_control.textbox()
        Me.Borderedlabel1 = New accounting.borderedlabel()
        Me.Borderedlabel2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdNotSave = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgOffset = New System.Windows.Forms.DataGridView()
        Me.txt_offset_type = New System.Windows.Forms.GroupBox()
        Me.rdo_adjustment = New user_control.rdo_button()
        Me.rdo_remittance = New user_control.rdo_button()
        Me.ds = New System.Data.DataSet()
        Me.final_tax = New System.Data.DataTable()
        Me.DataColumn178 = New System.Data.DataColumn()
        Me.DataColumn179 = New System.Data.DataColumn()
        Me.DataColumn180 = New System.Data.DataColumn()
        Me.DataColumn181 = New System.Data.DataColumn()
        Me.DataColumn182 = New System.Data.DataColumn()
        Me.DataColumn183 = New System.Data.DataColumn()
        Me.DataColumn184 = New System.Data.DataColumn()
        Me.DataColumn185 = New System.Data.DataColumn()
        Me.DataColumn186 = New System.Data.DataColumn()
        Me.DataColumn187 = New System.Data.DataColumn()
        Me.DataColumn188 = New System.Data.DataColumn()
        Me.DataColumn189 = New System.Data.DataColumn()
        Me.DataColumn190 = New System.Data.DataColumn()
        Me.DataColumn191 = New System.Data.DataColumn()
        Me.DataColumn192 = New System.Data.DataColumn()
        Me.DataColumn193 = New System.Data.DataColumn()
        Me.DataColumn194 = New System.Data.DataColumn()
        Me.DataColumn195 = New System.Data.DataColumn()
        Me.DataColumn196 = New System.Data.DataColumn()
        Me.DataColumn197 = New System.Data.DataColumn()
        Me.DataColumn198 = New System.Data.DataColumn()
        Me.DataColumn199 = New System.Data.DataColumn()
        Me.DataColumn200 = New System.Data.DataColumn()
        Me.DataColumn201 = New System.Data.DataColumn()
        Me.DataColumn202 = New System.Data.DataColumn()
        Me.DataColumn203 = New System.Data.DataColumn()
        Me.DataColumn204 = New System.Data.DataColumn()
        Me.DataColumn205 = New System.Data.DataColumn()
        Me.DataColumn206 = New System.Data.DataColumn()
        Me.DataColumn207 = New System.Data.DataColumn()
        Me.DataColumn209 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.txttotal = New user_control.textbox()
        Me.txt_search = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAll = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.bs_final_tax = New System.Windows.Forms.BindingSource(Me.components)
        Me.fs_final_tax_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.particulars = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmp_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isInputted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tax_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.JbooksidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FsfinaltaxidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OffsettypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReffinaltaxidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FsfinaltaxcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FsfinaltaxnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmpamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsInputtedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExchangerateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasedrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinaltaxidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParticularsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txt_offset_type.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.final_tax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.bs_final_tax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'border2
        '
        Me.border2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(21, 65)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(813, 2)
        Me.border2.TabIndex = 111
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtjbooksid.Location = New System.Drawing.Point(243, 34)
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
        Me.txtjbooksid.TabIndex = 119
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
        Me.Borderedlabel1.TabIndex = 117
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
        Me.Borderedlabel2.TabIndex = 116
        Me.Borderedlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(21, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(813, 2)
        Me.border1.TabIndex = 110
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(530, 575)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "TOTAL"
        '
        'cmdNotSave
        '
        Me.cmdNotSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdNotSave.BackColor = System.Drawing.Color.Maroon
        Me.cmdNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.cmdNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNotSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotSave.ForeColor = System.Drawing.Color.White
        Me.cmdNotSave.Location = New System.Drawing.Point(430, 611)
        Me.cmdNotSave.Name = "cmdNotSave"
        Me.cmdNotSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdNotSave.TabIndex = 113
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
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(324, 611)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdSave.TabIndex = 112
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
        Me.Label1.Size = New System.Drawing.Size(218, 25)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Final Tax Offsetting"
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
        Me.dgOffset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fs_final_tax_code, Me.description, Me.particulars, Me.trans_date, Me.ref_no, Me.general_name, Me.tmp_amount, Me.isInputted, Me.tax_amount, Me.balance, Me.SelDataGridViewCheckBoxColumn, Me.JbooksidDataGridViewTextBoxColumn, Me.FsfinaltaxidDataGridViewTextBoxColumn, Me.OffsettypeDataGridViewTextBoxColumn, Me.TaxrateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.TaxamountDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.AmountbasedDataGridViewTextBoxColumn, Me.TaxamountbasedDataGridViewTextBoxColumn, Me.DebitbasedDataGridViewTextBoxColumn, Me.CreditbasedDataGridViewTextBoxColumn, Me.ReffinaltaxidDataGridViewTextBoxColumn, Me.GeneralcodeDataGridViewTextBoxColumn, Me.GeneralnameDataGridViewTextBoxColumn, Me.FsfinaltaxcodeDataGridViewTextBoxColumn, Me.FsfinaltaxnameDataGridViewTextBoxColumn, Me.TinDataGridViewTextBoxColumn, Me.DeletedDataGridViewCheckBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.RefnoDataGridViewTextBoxColumn, Me.TmpamountDataGridViewTextBoxColumn, Me.IsInputtedDataGridViewCheckBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.CurrencyidDataGridViewTextBoxColumn, Me.CurrencynameDataGridViewTextBoxColumn, Me.ExchangerateDataGridViewTextBoxColumn, Me.BasedrateDataGridViewTextBoxColumn, Me.GeneralidDataGridViewTextBoxColumn, Me.FinaltaxidDataGridViewTextBoxColumn, Me.ParticularsDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.dgOffset.DataSource = Me.bs_final_tax
        Me.dgOffset.Location = New System.Drawing.Point(21, 115)
        Me.dgOffset.MultiSelect = False
        Me.dgOffset.Name = "dgOffset"
        Me.dgOffset.RowHeadersVisible = False
        Me.dgOffset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOffset.Size = New System.Drawing.Size(813, 450)
        Me.dgOffset.TabIndex = 108
        '
        'txt_offset_type
        '
        Me.txt_offset_type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_offset_type.Controls.Add(Me.rdo_adjustment)
        Me.txt_offset_type.Controls.Add(Me.rdo_remittance)
        Me.txt_offset_type.Location = New System.Drawing.Point(655, 71)
        Me.txt_offset_type.Name = "txt_offset_type"
        Me.txt_offset_type.Size = New System.Drawing.Size(178, 38)
        Me.txt_offset_type.TabIndex = 118
        Me.txt_offset_type.TabStop = False
        '
        'rdo_adjustment
        '
        Me.rdo_adjustment.AutoSize = True
        Me.rdo_adjustment.DataSource = ""
        Me.rdo_adjustment.Location = New System.Drawing.Point(91, 15)
        Me.rdo_adjustment.Name = "rdo_adjustment"
        Me.rdo_adjustment.Size = New System.Drawing.Size(74, 17)
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
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.final_tax})
        '
        'final_tax
        '
        Me.final_tax.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn178, Me.DataColumn179, Me.DataColumn180, Me.DataColumn181, Me.DataColumn182, Me.DataColumn183, Me.DataColumn184, Me.DataColumn185, Me.DataColumn186, Me.DataColumn187, Me.DataColumn188, Me.DataColumn189, Me.DataColumn190, Me.DataColumn191, Me.DataColumn192, Me.DataColumn193, Me.DataColumn194, Me.DataColumn195, Me.DataColumn196, Me.DataColumn197, Me.DataColumn198, Me.DataColumn199, Me.DataColumn200, Me.DataColumn201, Me.DataColumn202, Me.DataColumn203, Me.DataColumn204, Me.DataColumn205, Me.DataColumn206, Me.DataColumn207, Me.DataColumn209, Me.DataColumn1, Me.DataColumn2})
        Me.final_tax.TableName = "final_tax"
        '
        'DataColumn178
        '
        Me.DataColumn178.ColumnName = "sel"
        Me.DataColumn178.DataType = GetType(Boolean)
        Me.DataColumn178.DefaultValue = False
        '
        'DataColumn179
        '
        Me.DataColumn179.ColumnName = "jbooks_id"
        Me.DataColumn179.DefaultValue = ""
        '
        'DataColumn180
        '
        Me.DataColumn180.ColumnName = "fs_final_tax_id"
        Me.DataColumn180.DefaultValue = ""
        '
        'DataColumn181
        '
        Me.DataColumn181.ColumnName = "offset_type"
        Me.DataColumn181.DefaultValue = ""
        '
        'DataColumn182
        '
        Me.DataColumn182.ColumnName = "tax_rate"
        Me.DataColumn182.DataType = GetType(Decimal)
        Me.DataColumn182.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn183
        '
        Me.DataColumn183.ColumnName = "amount"
        Me.DataColumn183.DataType = GetType(Decimal)
        Me.DataColumn183.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn184
        '
        Me.DataColumn184.ColumnName = "tax_amount"
        Me.DataColumn184.DataType = GetType(Decimal)
        Me.DataColumn184.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn185
        '
        Me.DataColumn185.ColumnName = "debit"
        Me.DataColumn185.DataType = GetType(Decimal)
        Me.DataColumn185.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn186
        '
        Me.DataColumn186.ColumnName = "credit"
        Me.DataColumn186.DataType = GetType(Decimal)
        Me.DataColumn186.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn187
        '
        Me.DataColumn187.ColumnName = "amount_based"
        Me.DataColumn187.DataType = GetType(Decimal)
        Me.DataColumn187.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn188
        '
        Me.DataColumn188.ColumnName = "tax_amount_based"
        Me.DataColumn188.DataType = GetType(Decimal)
        Me.DataColumn188.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn189
        '
        Me.DataColumn189.ColumnName = "debit_based"
        Me.DataColumn189.DataType = GetType(Decimal)
        Me.DataColumn189.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn190
        '
        Me.DataColumn190.ColumnName = "credit_based"
        Me.DataColumn190.DataType = GetType(Decimal)
        Me.DataColumn190.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn191
        '
        Me.DataColumn191.ColumnName = "ref_final_tax_id"
        Me.DataColumn191.DefaultValue = ""
        '
        'DataColumn192
        '
        Me.DataColumn192.ColumnName = "general_code"
        Me.DataColumn192.DefaultValue = ""
        '
        'DataColumn193
        '
        Me.DataColumn193.ColumnName = "general_name"
        Me.DataColumn193.DefaultValue = ""
        '
        'DataColumn194
        '
        Me.DataColumn194.ColumnName = "fs_final_tax_code"
        Me.DataColumn194.DefaultValue = ""
        '
        'DataColumn195
        '
        Me.DataColumn195.ColumnName = "fs_final_tax_name"
        Me.DataColumn195.DefaultValue = ""
        '
        'DataColumn196
        '
        Me.DataColumn196.ColumnName = "tin"
        Me.DataColumn196.DefaultValue = ""
        '
        'DataColumn197
        '
        Me.DataColumn197.ColumnName = "deleted"
        Me.DataColumn197.DataType = GetType(Boolean)
        Me.DataColumn197.DefaultValue = False
        '
        'DataColumn198
        '
        Me.DataColumn198.ColumnName = "trans_date"
        Me.DataColumn198.DefaultValue = ""
        '
        'DataColumn199
        '
        Me.DataColumn199.ColumnName = "ref_no"
        Me.DataColumn199.DefaultValue = ""
        '
        'DataColumn200
        '
        Me.DataColumn200.ColumnName = "tmp_amount"
        Me.DataColumn200.DataType = GetType(Decimal)
        Me.DataColumn200.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn201
        '
        Me.DataColumn201.ColumnName = "isInputted"
        Me.DataColumn201.DataType = GetType(Boolean)
        Me.DataColumn201.DefaultValue = False
        '
        'DataColumn202
        '
        Me.DataColumn202.ColumnName = "balance"
        Me.DataColumn202.DataType = GetType(Decimal)
        Me.DataColumn202.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn203
        '
        Me.DataColumn203.ColumnName = "currency_id"
        Me.DataColumn203.DefaultValue = ""
        '
        'DataColumn204
        '
        Me.DataColumn204.ColumnName = "currency_name"
        Me.DataColumn204.DefaultValue = ""
        '
        'DataColumn205
        '
        Me.DataColumn205.ColumnName = "exchange_rate"
        Me.DataColumn205.DataType = GetType(Decimal)
        Me.DataColumn205.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn206
        '
        Me.DataColumn206.ColumnName = "based_rate"
        Me.DataColumn206.DataType = GetType(Decimal)
        Me.DataColumn206.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn207
        '
        Me.DataColumn207.ColumnName = "general_id"
        Me.DataColumn207.DefaultValue = ""
        '
        'DataColumn209
        '
        Me.DataColumn209.ColumnName = "final_tax_id"
        Me.DataColumn209.DefaultValue = ""
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
        Me.txttotal.Location = New System.Drawing.Point(578, 571)
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
        Me.txttotal.TabIndex = 121
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
        Me.txt_search.Location = New System.Drawing.Point(633, 40)
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
        Me.txt_search.TabIndex = 127
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
        Me.Label2.Location = New System.Drawing.Point(591, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Search"
        '
        'cboAll
        '
        Me.cboAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAll.AutoSize = True
        Me.cboAll.Location = New System.Drawing.Point(612, 86)
        Me.cboAll.Name = "cboAll"
        Me.cboAll.Size = New System.Drawing.Size(37, 17)
        Me.cboAll.TabIndex = 128
        Me.cboAll.Text = "All"
        Me.cboAll.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtDateFrom)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtDateTo)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(310, 80)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(296, 29)
        Me.FlowLayoutPanel1.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From"
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateFrom.Location = New System.Drawing.Point(39, 3)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(108, 20)
        Me.txtDateFrom.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "To"
        '
        'txtDateTo
        '
        Me.txtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateTo.Location = New System.Drawing.Point(179, 3)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(108, 20)
        Me.txtDateTo.TabIndex = 3
        '
        'bs_final_tax
        '
        Me.bs_final_tax.DataMember = "final_tax"
        Me.bs_final_tax.DataSource = Me.ds
        '
        'fs_final_tax_code
        '
        Me.fs_final_tax_code.DataPropertyName = "fs_final_tax_code"
        Me.fs_final_tax_code.HeaderText = "Reference No."
        Me.fs_final_tax_code.Name = "fs_final_tax_code"
        Me.fs_final_tax_code.ReadOnly = True
        Me.fs_final_tax_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fs_final_tax_code.Width = 120
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
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Gen. Ref."
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        Me.general_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.general_name.Width = 160
        '
        'tmp_amount
        '
        Me.tmp_amount.DataPropertyName = "tmp_amount"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "##,##0.00"
        DataGridViewCellStyle10.NullValue = "0.00"
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
        'tax_amount
        '
        Me.tax_amount.DataPropertyName = "tax_amount"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "##,##0.00"
        DataGridViewCellStyle11.NullValue = "0.00"
        Me.tax_amount.DefaultCellStyle = DataGridViewCellStyle11
        Me.tax_amount.HeaderText = "Amount Remitted"
        Me.tax_amount.Name = "tax_amount"
        Me.tax_amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tax_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tax_amount.Width = 120
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "##,##0.00"
        DataGridViewCellStyle12.NullValue = "0.00"
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
        'JbooksidDataGridViewTextBoxColumn
        '
        Me.JbooksidDataGridViewTextBoxColumn.DataPropertyName = "jbooks_id"
        Me.JbooksidDataGridViewTextBoxColumn.HeaderText = "jbooks_id"
        Me.JbooksidDataGridViewTextBoxColumn.Name = "JbooksidDataGridViewTextBoxColumn"
        Me.JbooksidDataGridViewTextBoxColumn.Visible = False
        '
        'FsfinaltaxidDataGridViewTextBoxColumn
        '
        Me.FsfinaltaxidDataGridViewTextBoxColumn.DataPropertyName = "fs_final_tax_id"
        Me.FsfinaltaxidDataGridViewTextBoxColumn.HeaderText = "fs_final_tax_id"
        Me.FsfinaltaxidDataGridViewTextBoxColumn.Name = "FsfinaltaxidDataGridViewTextBoxColumn"
        Me.FsfinaltaxidDataGridViewTextBoxColumn.Visible = False
        '
        'OffsettypeDataGridViewTextBoxColumn
        '
        Me.OffsettypeDataGridViewTextBoxColumn.DataPropertyName = "offset_type"
        Me.OffsettypeDataGridViewTextBoxColumn.HeaderText = "offset_type"
        Me.OffsettypeDataGridViewTextBoxColumn.Name = "OffsettypeDataGridViewTextBoxColumn"
        Me.OffsettypeDataGridViewTextBoxColumn.Visible = False
        '
        'TaxrateDataGridViewTextBoxColumn
        '
        Me.TaxrateDataGridViewTextBoxColumn.DataPropertyName = "tax_rate"
        Me.TaxrateDataGridViewTextBoxColumn.HeaderText = "tax_rate"
        Me.TaxrateDataGridViewTextBoxColumn.Name = "TaxrateDataGridViewTextBoxColumn"
        Me.TaxrateDataGridViewTextBoxColumn.Visible = False
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.Visible = False
        '
        'TaxamountDataGridViewTextBoxColumn
        '
        Me.TaxamountDataGridViewTextBoxColumn.DataPropertyName = "tax_amount"
        Me.TaxamountDataGridViewTextBoxColumn.HeaderText = "tax_amount"
        Me.TaxamountDataGridViewTextBoxColumn.Name = "TaxamountDataGridViewTextBoxColumn"
        Me.TaxamountDataGridViewTextBoxColumn.Visible = False
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
        'AmountbasedDataGridViewTextBoxColumn
        '
        Me.AmountbasedDataGridViewTextBoxColumn.DataPropertyName = "amount_based"
        Me.AmountbasedDataGridViewTextBoxColumn.HeaderText = "amount_based"
        Me.AmountbasedDataGridViewTextBoxColumn.Name = "AmountbasedDataGridViewTextBoxColumn"
        Me.AmountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'TaxamountbasedDataGridViewTextBoxColumn
        '
        Me.TaxamountbasedDataGridViewTextBoxColumn.DataPropertyName = "tax_amount_based"
        Me.TaxamountbasedDataGridViewTextBoxColumn.HeaderText = "tax_amount_based"
        Me.TaxamountbasedDataGridViewTextBoxColumn.Name = "TaxamountbasedDataGridViewTextBoxColumn"
        Me.TaxamountbasedDataGridViewTextBoxColumn.Visible = False
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
        'ReffinaltaxidDataGridViewTextBoxColumn
        '
        Me.ReffinaltaxidDataGridViewTextBoxColumn.DataPropertyName = "ref_final_tax_id"
        Me.ReffinaltaxidDataGridViewTextBoxColumn.HeaderText = "ref_final_tax_id"
        Me.ReffinaltaxidDataGridViewTextBoxColumn.Name = "ReffinaltaxidDataGridViewTextBoxColumn"
        Me.ReffinaltaxidDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralcodeDataGridViewTextBoxColumn
        '
        Me.GeneralcodeDataGridViewTextBoxColumn.DataPropertyName = "general_code"
        Me.GeneralcodeDataGridViewTextBoxColumn.HeaderText = "general_code"
        Me.GeneralcodeDataGridViewTextBoxColumn.Name = "GeneralcodeDataGridViewTextBoxColumn"
        Me.GeneralcodeDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralnameDataGridViewTextBoxColumn
        '
        Me.GeneralnameDataGridViewTextBoxColumn.DataPropertyName = "general_name"
        Me.GeneralnameDataGridViewTextBoxColumn.HeaderText = "general_name"
        Me.GeneralnameDataGridViewTextBoxColumn.Name = "GeneralnameDataGridViewTextBoxColumn"
        Me.GeneralnameDataGridViewTextBoxColumn.Visible = False
        '
        'FsfinaltaxcodeDataGridViewTextBoxColumn
        '
        Me.FsfinaltaxcodeDataGridViewTextBoxColumn.DataPropertyName = "fs_final_tax_code"
        Me.FsfinaltaxcodeDataGridViewTextBoxColumn.HeaderText = "fs_final_tax_code"
        Me.FsfinaltaxcodeDataGridViewTextBoxColumn.Name = "FsfinaltaxcodeDataGridViewTextBoxColumn"
        Me.FsfinaltaxcodeDataGridViewTextBoxColumn.Visible = False
        '
        'FsfinaltaxnameDataGridViewTextBoxColumn
        '
        Me.FsfinaltaxnameDataGridViewTextBoxColumn.DataPropertyName = "fs_final_tax_name"
        Me.FsfinaltaxnameDataGridViewTextBoxColumn.HeaderText = "fs_final_tax_name"
        Me.FsfinaltaxnameDataGridViewTextBoxColumn.Name = "FsfinaltaxnameDataGridViewTextBoxColumn"
        Me.FsfinaltaxnameDataGridViewTextBoxColumn.Visible = False
        '
        'TinDataGridViewTextBoxColumn
        '
        Me.TinDataGridViewTextBoxColumn.DataPropertyName = "tin"
        Me.TinDataGridViewTextBoxColumn.HeaderText = "tin"
        Me.TinDataGridViewTextBoxColumn.Name = "TinDataGridViewTextBoxColumn"
        Me.TinDataGridViewTextBoxColumn.Visible = False
        '
        'DeletedDataGridViewCheckBoxColumn
        '
        Me.DeletedDataGridViewCheckBoxColumn.DataPropertyName = "deleted"
        Me.DeletedDataGridViewCheckBoxColumn.HeaderText = "deleted"
        Me.DeletedDataGridViewCheckBoxColumn.Name = "DeletedDataGridViewCheckBoxColumn"
        Me.DeletedDataGridViewCheckBoxColumn.Visible = False
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date"
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "trans_date"
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        Me.TransdateDataGridViewTextBoxColumn.Visible = False
        '
        'RefnoDataGridViewTextBoxColumn
        '
        Me.RefnoDataGridViewTextBoxColumn.DataPropertyName = "ref_no"
        Me.RefnoDataGridViewTextBoxColumn.HeaderText = "ref_no"
        Me.RefnoDataGridViewTextBoxColumn.Name = "RefnoDataGridViewTextBoxColumn"
        Me.RefnoDataGridViewTextBoxColumn.Visible = False
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
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencyidDataGridViewTextBoxColumn
        '
        Me.CurrencyidDataGridViewTextBoxColumn.DataPropertyName = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.HeaderText = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.Name = "CurrencyidDataGridViewTextBoxColumn"
        Me.CurrencyidDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencynameDataGridViewTextBoxColumn
        '
        Me.CurrencynameDataGridViewTextBoxColumn.DataPropertyName = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.HeaderText = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.Name = "CurrencynameDataGridViewTextBoxColumn"
        Me.CurrencynameDataGridViewTextBoxColumn.Visible = False
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
        'GeneralidDataGridViewTextBoxColumn
        '
        Me.GeneralidDataGridViewTextBoxColumn.DataPropertyName = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.HeaderText = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.Name = "GeneralidDataGridViewTextBoxColumn"
        Me.GeneralidDataGridViewTextBoxColumn.Visible = False
        '
        'FinaltaxidDataGridViewTextBoxColumn
        '
        Me.FinaltaxidDataGridViewTextBoxColumn.DataPropertyName = "final_tax_id"
        Me.FinaltaxidDataGridViewTextBoxColumn.HeaderText = "final_tax_id"
        Me.FinaltaxidDataGridViewTextBoxColumn.Name = "FinaltaxidDataGridViewTextBoxColumn"
        Me.FinaltaxidDataGridViewTextBoxColumn.Visible = False
        '
        'ParticularsDataGridViewTextBoxColumn
        '
        Me.ParticularsDataGridViewTextBoxColumn.DataPropertyName = "particulars"
        Me.ParticularsDataGridViewTextBoxColumn.HeaderText = "particulars"
        Me.ParticularsDataGridViewTextBoxColumn.Name = "ParticularsDataGridViewTextBoxColumn"
        Me.ParticularsDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'offsetfinaltax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 650)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.cboAll)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.txtjbooksid)
        Me.Controls.Add(Me.Borderedlabel1)
        Me.Controls.Add(Me.Borderedlabel2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdNotSave)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgOffset)
        Me.Controls.Add(Me.txt_offset_type)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "offsetfinaltax"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Tax Offsetting"
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txt_offset_type.ResumeLayout(False)
        Me.txt_offset_type.PerformLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.final_tax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.bs_final_tax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents txtjbooksid As user_control.textbox
    Friend WithEvents Borderedlabel1 As accounting.borderedlabel
    Friend WithEvents Borderedlabel2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdNotSave As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgOffset As System.Windows.Forms.DataGridView
    Friend WithEvents txt_offset_type As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_adjustment As user_control.rdo_button
    Friend WithEvents rdo_remittance As user_control.rdo_button
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents final_tax As System.Data.DataTable
    Friend WithEvents DataColumn178 As System.Data.DataColumn
    Friend WithEvents DataColumn179 As System.Data.DataColumn
    Friend WithEvents DataColumn180 As System.Data.DataColumn
    Friend WithEvents DataColumn181 As System.Data.DataColumn
    Friend WithEvents DataColumn182 As System.Data.DataColumn
    Friend WithEvents DataColumn183 As System.Data.DataColumn
    Friend WithEvents DataColumn184 As System.Data.DataColumn
    Friend WithEvents DataColumn185 As System.Data.DataColumn
    Friend WithEvents DataColumn186 As System.Data.DataColumn
    Friend WithEvents DataColumn187 As System.Data.DataColumn
    Friend WithEvents DataColumn188 As System.Data.DataColumn
    Friend WithEvents DataColumn189 As System.Data.DataColumn
    Friend WithEvents DataColumn190 As System.Data.DataColumn
    Friend WithEvents DataColumn191 As System.Data.DataColumn
    Friend WithEvents DataColumn192 As System.Data.DataColumn
    Friend WithEvents DataColumn193 As System.Data.DataColumn
    Friend WithEvents DataColumn194 As System.Data.DataColumn
    Friend WithEvents DataColumn195 As System.Data.DataColumn
    Friend WithEvents DataColumn196 As System.Data.DataColumn
    Friend WithEvents DataColumn197 As System.Data.DataColumn
    Friend WithEvents DataColumn198 As System.Data.DataColumn
    Friend WithEvents DataColumn199 As System.Data.DataColumn
    Friend WithEvents DataColumn200 As System.Data.DataColumn
    Friend WithEvents DataColumn201 As System.Data.DataColumn
    Friend WithEvents DataColumn202 As System.Data.DataColumn
    Friend WithEvents DataColumn203 As System.Data.DataColumn
    Friend WithEvents DataColumn204 As System.Data.DataColumn
    Friend WithEvents DataColumn205 As System.Data.DataColumn
    Friend WithEvents DataColumn206 As System.Data.DataColumn
    Friend WithEvents DataColumn207 As System.Data.DataColumn
    Friend WithEvents DataColumn209 As System.Data.DataColumn
    Friend WithEvents txttotal As user_control.textbox
    Friend WithEvents txt_search As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents cboAll As Windows.Forms.CheckBox
    Friend WithEvents fs_final_tax_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents particulars As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmp_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isInputted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tax_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents JbooksidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FsfinaltaxidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OffsettypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxrateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReffinaltaxidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FsfinaltaxcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FsfinaltaxnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeletedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TmpamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsInputtedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencynameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExchangerateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasedrateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinaltaxidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParticularsDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bs_final_tax As Windows.Forms.BindingSource
    Friend WithEvents FlowLayoutPanel1 As Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtDateFrom As Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtDateTo As Windows.Forms.DateTimePicker
End Class
