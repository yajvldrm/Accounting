<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class offsetewt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdNotSave = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgOffset = New System.Windows.Forms.DataGridView()
        Me.bs_ewt = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet()
        Me.ewt = New System.Data.DataTable()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn77 = New System.Data.DataColumn()
        Me.DataColumn78 = New System.Data.DataColumn()
        Me.DataColumn79 = New System.Data.DataColumn()
        Me.DataColumn96 = New System.Data.DataColumn()
        Me.DataColumn154 = New System.Data.DataColumn()
        Me.DataColumn163 = New System.Data.DataColumn()
        Me.DataColumn166 = New System.Data.DataColumn()
        Me.DataColumn167 = New System.Data.DataColumn()
        Me.DataColumn168 = New System.Data.DataColumn()
        Me.DataColumn169 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.txt_offset_type = New System.Windows.Forms.GroupBox()
        Me.rdo_adjustment = New user_control.rdo_button()
        Me.rdo_remittance = New user_control.rdo_button()
        Me.txtjbooksid = New user_control.textbox()
        Me.txttotal = New user_control.textbox()
        Me.txt_search = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Borderedlabel1 = New accounting.borderedlabel()
        Me.Borderedlabel2 = New accounting.borderedlabel()
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.cboALl = New System.Windows.Forms.CheckBox()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.range_filter = New System.Windows.Forms.Panel()
        Me.rdo2 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.particulars = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmp_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isInputted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tax_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.JbooksidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FsewtidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ref_ewt_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FsewtcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FsewtnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.EwtidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineremarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParticularsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_ewt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ewt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txt_offset_type.SuspendLayout()
        Me.range_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EWT Offsetting"
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
        Me.cmdNotSave.Location = New System.Drawing.Point(396, 520)
        Me.cmdNotSave.Name = "cmdNotSave"
        Me.cmdNotSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdNotSave.TabIndex = 50
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
        Me.cmdSave.Location = New System.Drawing.Point(290, 520)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdSave.TabIndex = 49
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(462, 483)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "TOTAL"
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
        Me.dgOffset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_no, Me.description, Me.trans_date, Me.ref_no, Me.general_name, Me.particulars, Me.tmp_amount, Me.isInputted, Me.tax_amount, Me.balance, Me.SelDataGridViewCheckBoxColumn, Me.JbooksidDataGridViewTextBoxColumn, Me.GeneralidDataGridViewTextBoxColumn, Me.FsewtidDataGridViewTextBoxColumn, Me.OffsettypeDataGridViewTextBoxColumn, Me.TaxrateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.TaxamountDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.AmountbasedDataGridViewTextBoxColumn, Me.TaxamountbasedDataGridViewTextBoxColumn, Me.DebitbasedDataGridViewTextBoxColumn, Me.CreditbasedDataGridViewTextBoxColumn, Me.ref_ewt_id, Me.GeneralcodeDataGridViewTextBoxColumn, Me.GeneralnameDataGridViewTextBoxColumn, Me.FsewtcodeDataGridViewTextBoxColumn, Me.FsewtnameDataGridViewTextBoxColumn, Me.TinDataGridViewTextBoxColumn, Me.DeletedDataGridViewCheckBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.RefnoDataGridViewTextBoxColumn, Me.TmpamountDataGridViewTextBoxColumn, Me.IsInputtedDataGridViewCheckBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.CurrencyidDataGridViewTextBoxColumn, Me.CurrencynameDataGridViewTextBoxColumn, Me.ExchangerateDataGridViewTextBoxColumn, Me.BasedrateDataGridViewTextBoxColumn, Me.EwtidDataGridViewTextBoxColumn, Me.TransnoDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.LineremarksDataGridViewTextBoxColumn, Me.ParticularsDataGridViewTextBoxColumn})
        Me.dgOffset.DataSource = Me.bs_ewt
        Me.dgOffset.Location = New System.Drawing.Point(21, 112)
        Me.dgOffset.MultiSelect = False
        Me.dgOffset.Name = "dgOffset"
        Me.dgOffset.RowHeadersVisible = False
        Me.dgOffset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOffset.Size = New System.Drawing.Size(745, 361)
        Me.dgOffset.TabIndex = 0
        '
        'bs_ewt
        '
        Me.bs_ewt.DataMember = "ewt"
        Me.bs_ewt.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.ewt})
        '
        'ewt
        '
        Me.ewt.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn46, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn96, Me.DataColumn154, Me.DataColumn163, Me.DataColumn166, Me.DataColumn167, Me.DataColumn168, Me.DataColumn169, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.ewt.TableName = "ewt"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "sel"
        Me.DataColumn42.DataType = GetType(Boolean)
        Me.DataColumn42.DefaultValue = False
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "jbooks_id"
        Me.DataColumn43.DefaultValue = ""
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "general_id"
        Me.DataColumn44.DefaultValue = ""
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "fs_ewt_id"
        Me.DataColumn45.DefaultValue = ""
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "offset_type"
        Me.DataColumn47.DefaultValue = ""
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "tax_rate"
        Me.DataColumn48.DataType = GetType(Decimal)
        Me.DataColumn48.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "amount"
        Me.DataColumn49.DataType = GetType(Decimal)
        Me.DataColumn49.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "tax_amount"
        Me.DataColumn50.DataType = GetType(Decimal)
        Me.DataColumn50.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "debit"
        Me.DataColumn51.DataType = GetType(Decimal)
        Me.DataColumn51.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "credit"
        Me.DataColumn52.DataType = GetType(Decimal)
        Me.DataColumn52.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "amount_based"
        Me.DataColumn53.DataType = GetType(Decimal)
        Me.DataColumn53.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "tax_amount_based"
        Me.DataColumn54.DataType = GetType(Decimal)
        Me.DataColumn54.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "debit_based"
        Me.DataColumn55.DataType = GetType(Decimal)
        Me.DataColumn55.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "credit_based"
        Me.DataColumn56.DataType = GetType(Decimal)
        Me.DataColumn56.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "ref_ewt_id"
        Me.DataColumn57.DefaultValue = ""
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "general_code"
        Me.DataColumn46.DefaultValue = ""
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "general_name"
        Me.DataColumn77.DefaultValue = ""
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "fs_ewt_code"
        Me.DataColumn78.DefaultValue = ""
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "fs_ewt_name"
        Me.DataColumn79.DefaultValue = ""
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "tin"
        Me.DataColumn96.DefaultValue = ""
        '
        'DataColumn154
        '
        Me.DataColumn154.ColumnName = "deleted"
        Me.DataColumn154.DataType = GetType(Boolean)
        Me.DataColumn154.DefaultValue = False
        '
        'DataColumn163
        '
        Me.DataColumn163.ColumnName = "trans_date"
        Me.DataColumn163.DataType = GetType(Date)
        '
        'DataColumn166
        '
        Me.DataColumn166.ColumnName = "ref_no"
        '
        'DataColumn167
        '
        Me.DataColumn167.ColumnName = "tmp_amount"
        Me.DataColumn167.DataType = GetType(Decimal)
        '
        'DataColumn168
        '
        Me.DataColumn168.ColumnName = "isInputted"
        Me.DataColumn168.DataType = GetType(Boolean)
        Me.DataColumn168.DefaultValue = False
        '
        'DataColumn169
        '
        Me.DataColumn169.ColumnName = "balance"
        Me.DataColumn169.DataType = GetType(Decimal)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "currency_id"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "currency_name"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "exchange_rate"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "based_rate"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ewt_id"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "trans_no"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "description"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "line_remarks"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "particulars"
        Me.DataColumn9.DefaultValue = ""
        '
        'txt_offset_type
        '
        Me.txt_offset_type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_offset_type.Controls.Add(Me.rdo_adjustment)
        Me.txt_offset_type.Controls.Add(Me.rdo_remittance)
        Me.txt_offset_type.Location = New System.Drawing.Point(587, 68)
        Me.txt_offset_type.Name = "txt_offset_type"
        Me.txt_offset_type.Size = New System.Drawing.Size(178, 38)
        Me.txt_offset_type.TabIndex = 55
        Me.txt_offset_type.TabStop = False
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
        Me.txtjbooksid.Location = New System.Drawing.Point(196, 34)
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
        Me.txtjbooksid.TabIndex = 107
        Me.txtjbooksid.TableData = Nothing
        Me.txtjbooksid.TextSource = ""
        Me.txtjbooksid.UseSystemPasswordChar = False
        Me.txtjbooksid.Value = ""
        Me.txtjbooksid.ValueSource = ""
        Me.txtjbooksid.Visible = False
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
        Me.txttotal.Location = New System.Drawing.Point(507, 479)
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
        Me.Label2.Location = New System.Drawing.Point(523, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Search"
        '
        'Borderedlabel1
        '
        Me.Borderedlabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Borderedlabel1.BorderColor = System.Drawing.Color.White
        Me.Borderedlabel1.Location = New System.Drawing.Point(21, 508)
        Me.Borderedlabel1.Name = "Borderedlabel1"
        Me.Borderedlabel1.Size = New System.Drawing.Size(745, 2)
        Me.Borderedlabel1.TabIndex = 54
        Me.Borderedlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Borderedlabel2
        '
        Me.Borderedlabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Borderedlabel2.BorderColor = System.Drawing.Color.DarkGray
        Me.Borderedlabel2.Location = New System.Drawing.Point(21, 506)
        Me.Borderedlabel2.Name = "Borderedlabel2"
        Me.Borderedlabel2.Size = New System.Drawing.Size(745, 2)
        Me.Borderedlabel2.TabIndex = 53
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
        Me.border2.TabIndex = 5
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
        Me.border1.TabIndex = 4
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboALl
        '
        Me.cboALl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboALl.AutoSize = True
        Me.cboALl.Location = New System.Drawing.Point(544, 83)
        Me.cboALl.Name = "cboALl"
        Me.cboALl.Size = New System.Drawing.Size(37, 17)
        Me.cboALl.TabIndex = 128
        Me.cboALl.Text = "All"
        Me.cboALl.UseVisualStyleBackColor = True
        '
        'txt_date_to
        '
        Me.txt_date_to.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(430, 80)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 21)
        Me.txt_date_to.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Date To"
        '
        'txt_date_from
        '
        Me.txt_date_from.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(267, 80)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(100, 21)
        Me.txt_date_from.TabIndex = 143
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Date From"
        '
        'range_filter
        '
        Me.range_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Location = New System.Drawing.Point(-33, 71)
        Me.range_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(232, 30)
        Me.range_filter.TabIndex = 142
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
        'trans_no
        '
        Me.trans_no.DataPropertyName = "trans_no"
        Me.trans_no.HeaderText = "Reference No."
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        Me.trans_no.Width = 120
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
        'particulars
        '
        Me.particulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.particulars.DataPropertyName = "particulars"
        Me.particulars.HeaderText = "Line Remarks"
        Me.particulars.Name = "particulars"
        Me.particulars.ReadOnly = True
        Me.particulars.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tmp_amount
        '
        Me.tmp_amount.DataPropertyName = "tmp_amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "##,##0.00"
        DataGridViewCellStyle2.NullValue = "0.00"
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
        'tax_amount
        '
        Me.tax_amount.DataPropertyName = "tax_amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "##,##0.00"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.tax_amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.tax_amount.HeaderText = "Amount Remitted"
        Me.tax_amount.Name = "tax_amount"
        Me.tax_amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tax_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tax_amount.Width = 120
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "##,##0.00"
        DataGridViewCellStyle4.NullValue = "0.00"
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
        Me.SelDataGridViewCheckBoxColumn.Visible = False
        '
        'JbooksidDataGridViewTextBoxColumn
        '
        Me.JbooksidDataGridViewTextBoxColumn.DataPropertyName = "jbooks_id"
        Me.JbooksidDataGridViewTextBoxColumn.HeaderText = "jbooks_id"
        Me.JbooksidDataGridViewTextBoxColumn.Name = "JbooksidDataGridViewTextBoxColumn"
        Me.JbooksidDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralidDataGridViewTextBoxColumn
        '
        Me.GeneralidDataGridViewTextBoxColumn.DataPropertyName = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.HeaderText = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.Name = "GeneralidDataGridViewTextBoxColumn"
        Me.GeneralidDataGridViewTextBoxColumn.Visible = False
        '
        'FsewtidDataGridViewTextBoxColumn
        '
        Me.FsewtidDataGridViewTextBoxColumn.DataPropertyName = "fs_ewt_id"
        Me.FsewtidDataGridViewTextBoxColumn.HeaderText = "fs_ewt_id"
        Me.FsewtidDataGridViewTextBoxColumn.Name = "FsewtidDataGridViewTextBoxColumn"
        Me.FsewtidDataGridViewTextBoxColumn.Visible = False
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
        'ref_ewt_id
        '
        Me.ref_ewt_id.DataPropertyName = "ref_ewt_id"
        Me.ref_ewt_id.HeaderText = "ref_ewt_id"
        Me.ref_ewt_id.Name = "ref_ewt_id"
        Me.ref_ewt_id.Visible = False
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
        'FsewtcodeDataGridViewTextBoxColumn
        '
        Me.FsewtcodeDataGridViewTextBoxColumn.DataPropertyName = "fs_ewt_code"
        Me.FsewtcodeDataGridViewTextBoxColumn.HeaderText = "fs_ewt_code"
        Me.FsewtcodeDataGridViewTextBoxColumn.Name = "FsewtcodeDataGridViewTextBoxColumn"
        Me.FsewtcodeDataGridViewTextBoxColumn.Visible = False
        '
        'FsewtnameDataGridViewTextBoxColumn
        '
        Me.FsewtnameDataGridViewTextBoxColumn.DataPropertyName = "fs_ewt_name"
        Me.FsewtnameDataGridViewTextBoxColumn.HeaderText = "fs_ewt_name"
        Me.FsewtnameDataGridViewTextBoxColumn.Name = "FsewtnameDataGridViewTextBoxColumn"
        Me.FsewtnameDataGridViewTextBoxColumn.Visible = False
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
        'EwtidDataGridViewTextBoxColumn
        '
        Me.EwtidDataGridViewTextBoxColumn.DataPropertyName = "ewt_id"
        Me.EwtidDataGridViewTextBoxColumn.HeaderText = "ewt_id"
        Me.EwtidDataGridViewTextBoxColumn.Name = "EwtidDataGridViewTextBoxColumn"
        Me.EwtidDataGridViewTextBoxColumn.Visible = False
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'LineremarksDataGridViewTextBoxColumn
        '
        Me.LineremarksDataGridViewTextBoxColumn.DataPropertyName = "line_remarks"
        Me.LineremarksDataGridViewTextBoxColumn.HeaderText = "line_remarks"
        Me.LineremarksDataGridViewTextBoxColumn.Name = "LineremarksDataGridViewTextBoxColumn"
        Me.LineremarksDataGridViewTextBoxColumn.Visible = False
        '
        'ParticularsDataGridViewTextBoxColumn
        '
        Me.ParticularsDataGridViewTextBoxColumn.DataPropertyName = "particulars"
        Me.ParticularsDataGridViewTextBoxColumn.HeaderText = "particulars"
        Me.ParticularsDataGridViewTextBoxColumn.Name = "ParticularsDataGridViewTextBoxColumn"
        Me.ParticularsDataGridViewTextBoxColumn.Visible = False
        '
        'offsetewt
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
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtjbooksid)
        Me.Controls.Add(Me.txt_offset_type)
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
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "offsetewt"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EWT Offsetting"
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_ewt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ewt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txt_offset_type.ResumeLayout(False)
        Me.txt_offset_type.PerformLayout()
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdNotSave As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Borderedlabel1 As accounting.borderedlabel
    Friend WithEvents Borderedlabel2 As accounting.borderedlabel
    Friend WithEvents dgOffset As System.Windows.Forms.DataGridView
    Friend WithEvents txt_offset_type As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_adjustment As user_control.rdo_button
    Friend WithEvents rdo_remittance As user_control.rdo_button
    Friend WithEvents txtjbooksid As user_control.textbox
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn169 As System.Data.DataColumn
    Friend WithEvents DataColumn168 As System.Data.DataColumn
    Friend WithEvents DataColumn167 As System.Data.DataColumn
    Friend WithEvents DataColumn166 As System.Data.DataColumn
    Friend WithEvents DataColumn163 As System.Data.DataColumn
    Friend WithEvents DataColumn154 As System.Data.DataColumn
    Friend WithEvents DataColumn96 As System.Data.DataColumn
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents ewt As System.Data.DataTable
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents txttotal As user_control.textbox
    Friend WithEvents txt_search As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents cboALl As Windows.Forms.CheckBox
    Friend WithEvents bs_ewt As Windows.Forms.BindingSource
    Friend WithEvents txt_date_to As Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_date_from As Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents range_filter As Windows.Forms.Panel
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents particulars As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmp_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isInputted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tax_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents JbooksidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FsewtidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ref_ewt_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FsewtcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FsewtnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents EwtidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineremarksDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParticularsDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
End Class
