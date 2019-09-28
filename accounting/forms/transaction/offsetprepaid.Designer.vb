<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class offsetprepaid
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
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdNotSave = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Borderedlabel1 = New accounting.borderedlabel()
        Me.Borderedlabel2 = New accounting.borderedlabel()
        Me.dgOffset = New System.Windows.Forms.DataGridView()
        Me.ds = New System.Data.DataSet()
        Me.prepaid = New System.Data.DataTable()
        Me.DataColumn138 = New System.Data.DataColumn()
        Me.DataColumn139 = New System.Data.DataColumn()
        Me.DataColumn140 = New System.Data.DataColumn()
        Me.DataColumn141 = New System.Data.DataColumn()
        Me.DataColumn142 = New System.Data.DataColumn()
        Me.DataColumn143 = New System.Data.DataColumn()
        Me.DataColumn144 = New System.Data.DataColumn()
        Me.DataColumn145 = New System.Data.DataColumn()
        Me.DataColumn146 = New System.Data.DataColumn()
        Me.DataColumn147 = New System.Data.DataColumn()
        Me.DataColumn148 = New System.Data.DataColumn()
        Me.DataColumn149 = New System.Data.DataColumn()
        Me.DataColumn150 = New System.Data.DataColumn()
        Me.DataColumn159 = New System.Data.DataColumn()
        Me.DataColumn237 = New System.Data.DataColumn()
        Me.DataColumn238 = New System.Data.DataColumn()
        Me.DataColumn239 = New System.Data.DataColumn()
        Me.DataColumn240 = New System.Data.DataColumn()
        Me.DataColumn241 = New System.Data.DataColumn()
        Me.DataColumn242 = New System.Data.DataColumn()
        Me.DataColumn243 = New System.Data.DataColumn()
        Me.DataColumn244 = New System.Data.DataColumn()
        Me.DataColumn245 = New System.Data.DataColumn()
        Me.DataColumn246 = New System.Data.DataColumn()
        Me.DataColumn247 = New System.Data.DataColumn()
        Me.DataColumn248 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.txtjbooksid = New user_control.textbox()
        Me.txttotal = New user_control.textbox()
        Me.txt_search = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboALl = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.bs_prepaid = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PrepaididDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JbooksidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExchangerateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasedrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateacquiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsefullifeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatestartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefprepaididDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencycodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmpamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsInputtedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParticularsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prepaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.bs_prepaid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.border1.Size = New System.Drawing.Size(813, 2)
        Me.border1.TabIndex = 4
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Prepayment Offsetting"
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
        Me.cmdSave.Location = New System.Drawing.Point(324, 611)
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
        Me.Label6.Location = New System.Drawing.Point(530, 575)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "TOTAL"
        '
        'Borderedlabel1
        '
        Me.Borderedlabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Borderedlabel1.BorderColor = System.Drawing.Color.White
        Me.Borderedlabel1.Location = New System.Drawing.Point(21, 600)
        Me.Borderedlabel1.Name = "Borderedlabel1"
        Me.Borderedlabel1.Size = New System.Drawing.Size(813, 2)
        Me.Borderedlabel1.TabIndex = 54
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
        Me.Borderedlabel2.TabIndex = 53
        Me.Borderedlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgOffset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_no, Me.Column1, Me.trans_date, Me.ref_no, Me.description, Me.tmp_amount, Me.isInputted, Me.amount, Me.balance, Me.SelDataGridViewCheckBoxColumn, Me.PrepaididDataGridViewTextBoxColumn, Me.JbooksidDataGridViewTextBoxColumn, Me.CurrencyidDataGridViewTextBoxColumn, Me.ExchangerateDataGridViewTextBoxColumn, Me.BasedrateDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DateacquiredDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.AmountbasedDataGridViewTextBoxColumn, Me.UsefullifeDataGridViewTextBoxColumn, Me.DatestartDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.DebitbasedDataGridViewTextBoxColumn, Me.CreditbasedDataGridViewTextBoxColumn, Me.RefprepaididDataGridViewTextBoxColumn, Me.RefnoDataGridViewTextBoxColumn, Me.CurrencycodeDataGridViewTextBoxColumn, Me.CurrencynameDataGridViewTextBoxColumn, Me.TmpamountDataGridViewTextBoxColumn, Me.IsInputtedDataGridViewCheckBoxColumn, Me.DeletedDataGridViewCheckBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.TransnoDataGridViewTextBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.ParticularsDataGridViewTextBoxColumn})
        Me.dgOffset.DataSource = Me.bs_prepaid
        Me.dgOffset.Location = New System.Drawing.Point(21, 75)
        Me.dgOffset.Name = "dgOffset"
        Me.dgOffset.RowHeadersVisible = False
        Me.dgOffset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOffset.Size = New System.Drawing.Size(813, 490)
        Me.dgOffset.TabIndex = 0
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.prepaid})
        '
        'prepaid
        '
        Me.prepaid.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn138, Me.DataColumn139, Me.DataColumn140, Me.DataColumn141, Me.DataColumn142, Me.DataColumn143, Me.DataColumn144, Me.DataColumn145, Me.DataColumn146, Me.DataColumn147, Me.DataColumn148, Me.DataColumn149, Me.DataColumn150, Me.DataColumn159, Me.DataColumn237, Me.DataColumn238, Me.DataColumn239, Me.DataColumn240, Me.DataColumn241, Me.DataColumn242, Me.DataColumn243, Me.DataColumn244, Me.DataColumn245, Me.DataColumn246, Me.DataColumn247, Me.DataColumn248, Me.DataColumn1})
        Me.prepaid.TableName = "prepaid"
        '
        'DataColumn138
        '
        Me.DataColumn138.ColumnName = "sel"
        Me.DataColumn138.DataType = GetType(Boolean)
        Me.DataColumn138.DefaultValue = False
        '
        'DataColumn139
        '
        Me.DataColumn139.ColumnName = "prepaid_id"
        Me.DataColumn139.DefaultValue = ""
        '
        'DataColumn140
        '
        Me.DataColumn140.ColumnName = "jbooks_id"
        Me.DataColumn140.DefaultValue = ""
        '
        'DataColumn141
        '
        Me.DataColumn141.ColumnName = "currency_id"
        Me.DataColumn141.DefaultValue = ""
        '
        'DataColumn142
        '
        Me.DataColumn142.ColumnName = "exchange_rate"
        Me.DataColumn142.DataType = GetType(Decimal)
        Me.DataColumn142.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn143
        '
        Me.DataColumn143.ColumnName = "based_rate"
        Me.DataColumn143.DataType = GetType(Decimal)
        Me.DataColumn143.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn144
        '
        Me.DataColumn144.ColumnName = "description"
        Me.DataColumn144.DefaultValue = ""
        '
        'DataColumn145
        '
        Me.DataColumn145.ColumnName = "date_acquired"
        Me.DataColumn145.DataType = GetType(Date)
        '
        'DataColumn146
        '
        Me.DataColumn146.ColumnName = "amount"
        Me.DataColumn146.DataType = GetType(Decimal)
        Me.DataColumn146.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn147
        '
        Me.DataColumn147.ColumnName = "amount_based"
        Me.DataColumn147.DataType = GetType(Decimal)
        Me.DataColumn147.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn148
        '
        Me.DataColumn148.ColumnName = "useful_life"
        Me.DataColumn148.DataType = GetType(Integer)
        Me.DataColumn148.DefaultValue = 0
        '
        'DataColumn149
        '
        Me.DataColumn149.ColumnName = "date_start"
        Me.DataColumn149.DataType = GetType(Date)
        '
        'DataColumn150
        '
        Me.DataColumn150.ColumnName = "debit"
        Me.DataColumn150.DataType = GetType(Decimal)
        Me.DataColumn150.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn159
        '
        Me.DataColumn159.ColumnName = "credit"
        Me.DataColumn159.DataType = GetType(Decimal)
        Me.DataColumn159.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn237
        '
        Me.DataColumn237.ColumnName = "debit_based"
        Me.DataColumn237.DataType = GetType(Decimal)
        Me.DataColumn237.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn238
        '
        Me.DataColumn238.ColumnName = "credit_based"
        Me.DataColumn238.DataType = GetType(Decimal)
        Me.DataColumn238.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn239
        '
        Me.DataColumn239.ColumnName = "ref_prepaid_id"
        Me.DataColumn239.DefaultValue = ""
        '
        'DataColumn240
        '
        Me.DataColumn240.ColumnName = "ref_no"
        Me.DataColumn240.DefaultValue = ""
        '
        'DataColumn241
        '
        Me.DataColumn241.ColumnName = "currency_code"
        Me.DataColumn241.DefaultValue = ""
        '
        'DataColumn242
        '
        Me.DataColumn242.ColumnName = "currency_name"
        Me.DataColumn242.DefaultValue = ""
        '
        'DataColumn243
        '
        Me.DataColumn243.ColumnName = "tmp_amount"
        Me.DataColumn243.DataType = GetType(Decimal)
        Me.DataColumn243.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn244
        '
        Me.DataColumn244.ColumnName = "isInputted"
        Me.DataColumn244.DataType = GetType(Boolean)
        Me.DataColumn244.DefaultValue = False
        '
        'DataColumn245
        '
        Me.DataColumn245.ColumnName = "deleted"
        Me.DataColumn245.DataType = GetType(Boolean)
        Me.DataColumn245.DefaultValue = False
        '
        'DataColumn246
        '
        Me.DataColumn246.ColumnName = "balance"
        Me.DataColumn246.DataType = GetType(Decimal)
        Me.DataColumn246.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn247
        '
        Me.DataColumn247.ColumnName = "trans_no"
        Me.DataColumn247.DefaultValue = ""
        '
        'DataColumn248
        '
        Me.DataColumn248.ColumnName = "trans_date"
        Me.DataColumn248.DefaultValue = ""
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "particulars"
        Me.DataColumn1.DefaultValue = ""
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
        Me.txtjbooksid.Location = New System.Drawing.Point(275, 40)
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
        Me.txtjbooksid.TabIndex = 132
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
        Me.txttotal.TabIndex = 133
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
        Me.txt_search.TabIndex = 136
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
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Search"
        '
        'cboALl
        '
        Me.cboALl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboALl.AutoSize = True
        Me.cboALl.Location = New System.Drawing.Point(549, 43)
        Me.cboALl.Name = "cboALl"
        Me.cboALl.Size = New System.Drawing.Size(37, 17)
        Me.cboALl.TabIndex = 137
        Me.cboALl.Text = "All"
        Me.cboALl.UseVisualStyleBackColor = True
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
        Me.FlowLayoutPanel1.TabIndex = 138
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
        'bs_prepaid
        '
        Me.bs_prepaid.DataMember = "prepaid"
        Me.bs_prepaid.DataSource = Me.ds
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
        'PrepaididDataGridViewTextBoxColumn
        '
        Me.PrepaididDataGridViewTextBoxColumn.DataPropertyName = "prepaid_id"
        Me.PrepaididDataGridViewTextBoxColumn.HeaderText = "prepaid_id"
        Me.PrepaididDataGridViewTextBoxColumn.Name = "PrepaididDataGridViewTextBoxColumn"
        Me.PrepaididDataGridViewTextBoxColumn.Visible = False
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
        'RefprepaididDataGridViewTextBoxColumn
        '
        Me.RefprepaididDataGridViewTextBoxColumn.DataPropertyName = "ref_prepaid_id"
        Me.RefprepaididDataGridViewTextBoxColumn.HeaderText = "ref_prepaid_id"
        Me.RefprepaididDataGridViewTextBoxColumn.Name = "RefprepaididDataGridViewTextBoxColumn"
        Me.RefprepaididDataGridViewTextBoxColumn.Visible = False
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
        'ParticularsDataGridViewTextBoxColumn
        '
        Me.ParticularsDataGridViewTextBoxColumn.DataPropertyName = "particulars"
        Me.ParticularsDataGridViewTextBoxColumn.HeaderText = "particulars"
        Me.ParticularsDataGridViewTextBoxColumn.Name = "ParticularsDataGridViewTextBoxColumn"
        Me.ParticularsDataGridViewTextBoxColumn.Visible = False
        '
        'offsetprepaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 650)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.cboALl)
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
        Me.Name = "offsetprepaid"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prepayment Offsetting"
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prepaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.bs_prepaid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents prepaid As System.Data.DataTable
    Friend WithEvents DataColumn138 As System.Data.DataColumn
    Friend WithEvents DataColumn139 As System.Data.DataColumn
    Friend WithEvents DataColumn140 As System.Data.DataColumn
    Friend WithEvents DataColumn141 As System.Data.DataColumn
    Friend WithEvents DataColumn142 As System.Data.DataColumn
    Friend WithEvents DataColumn143 As System.Data.DataColumn
    Friend WithEvents DataColumn144 As System.Data.DataColumn
    Friend WithEvents DataColumn145 As System.Data.DataColumn
    Friend WithEvents DataColumn146 As System.Data.DataColumn
    Friend WithEvents DataColumn147 As System.Data.DataColumn
    Friend WithEvents DataColumn148 As System.Data.DataColumn
    Friend WithEvents DataColumn149 As System.Data.DataColumn
    Friend WithEvents DataColumn150 As System.Data.DataColumn
    Friend WithEvents DataColumn159 As System.Data.DataColumn
    Friend WithEvents DataColumn237 As System.Data.DataColumn
    Friend WithEvents DataColumn238 As System.Data.DataColumn
    Friend WithEvents DataColumn239 As System.Data.DataColumn
    Friend WithEvents DataColumn240 As System.Data.DataColumn
    Friend WithEvents DataColumn241 As System.Data.DataColumn
    Friend WithEvents DataColumn242 As System.Data.DataColumn
    Friend WithEvents DataColumn243 As System.Data.DataColumn
    Friend WithEvents DataColumn244 As System.Data.DataColumn
    Friend WithEvents DataColumn245 As System.Data.DataColumn
    Friend WithEvents DataColumn246 As System.Data.DataColumn
    Friend WithEvents DataColumn247 As System.Data.DataColumn
    Friend WithEvents DataColumn248 As System.Data.DataColumn
    Friend WithEvents txtjbooksid As user_control.textbox
    Friend WithEvents txttotal As user_control.textbox
    Friend WithEvents txt_search As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents cboALl As Windows.Forms.CheckBox
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
    Friend WithEvents PrepaididDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JbooksidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExchangerateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasedrateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateacquiredDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsefullifeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatestartDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefprepaididDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencycodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencynameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TmpamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsInputtedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DeletedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParticularsDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bs_prepaid As Windows.Forms.BindingSource
End Class
