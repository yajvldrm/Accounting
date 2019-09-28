<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setupewt
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
        Dim ewt As System.Data.DataTable
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setupewt))
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.dgewt = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ewt_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fs_ewt_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fs_ewt_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.offset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ds = New System.Data.DataSet()
        Me.txtjbooksid = New user_control.textbox()
        Me.txtTIN = New user_control.textbox()
        Me.txtewtname = New user_control.textbox()
        Me.txtewt = New user_control.textbox()
        Me.txtgeneralname = New user_control.textbox()
        Me.txtgeneral = New user_control.textbox()
        Me.det = New System.Windows.Forms.Panel()
        Me.txttaxamount = New DevExpress.XtraEditors.TextEdit()
        Me.txttaxrate = New DevExpress.XtraEditors.TextEdit()
        Me.txt_tmp_amount = New DevExpress.XtraEditors.TextEdit()
        Me.txtamount = New DevExpress.XtraEditors.TextEdit()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        ewt = New System.Data.DataTable()
        CType(ewt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgewt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.det.SuspendLayout()
        CType(Me.txttaxamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttaxrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tmp_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ewt
        '
        ewt.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        ewt.TableName = "ewt"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ewt_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "jbooks_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "general_id"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "fs_ewt_id"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "offset_type"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tax_rate"
        Me.DataColumn7.DataType = GetType(Decimal)
        Me.DataColumn7.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "amount"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "tax_amount"
        Me.DataColumn9.DataType = GetType(Decimal)
        Me.DataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "debit"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "credit"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "amount_based"
        Me.DataColumn12.DataType = GetType(Decimal)
        Me.DataColumn12.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "tax_amount_based"
        Me.DataColumn13.DataType = GetType(Decimal)
        Me.DataColumn13.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "debit_based"
        Me.DataColumn14.DataType = GetType(Decimal)
        Me.DataColumn14.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "credit_based"
        Me.DataColumn15.DataType = GetType(Decimal)
        Me.DataColumn15.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ref_ewt_id"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "general_code"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "general_name"
        Me.DataColumn18.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "tin"
        Me.DataColumn19.DefaultValue = ""
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fs_ewt_code"
        Me.DataColumn20.DefaultValue = ""
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "fs_ewt_name"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
        Me.DataColumn22.ColumnName = "currency_id"
        Me.DataColumn22.DefaultValue = ""
        '
        'DataColumn23
        '
        Me.DataColumn23.AllowDBNull = False
        Me.DataColumn23.ColumnName = "exchange_rate"
        Me.DataColumn23.DataType = GetType(Decimal)
        Me.DataColumn23.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn24
        '
        Me.DataColumn24.AllowDBNull = False
        Me.DataColumn24.ColumnName = "based_rate"
        Me.DataColumn24.DataType = GetType(Decimal)
        Me.DataColumn24.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "deleted"
        Me.DataColumn25.DataType = GetType(Boolean)
        Me.DataColumn25.DefaultValue = False
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "offset"
        Me.DataColumn26.DataType = GetType(Integer)
        Me.DataColumn26.DefaultValue = 0
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "minimum"
        Me.DataColumn27.DataType = GetType(Decimal)
        Me.DataColumn27.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'dgewt
        '
        Me.dgewt.AllowUserToAddRows = False
        Me.dgewt.AllowUserToDeleteRows = False
        Me.dgewt.AllowUserToResizeColumns = False
        Me.dgewt.AllowUserToResizeRows = False
        Me.dgewt.BackgroundColor = System.Drawing.Color.White
        Me.dgewt.ColumnHeadersHeight = 28
        Me.dgewt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgewt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.ewt_id, Me.deleted, Me.tin, Me.general_name, Me.fs_ewt_code, Me.tax_rate, Me.amount, Me.tax_amount, Me.general_id, Me.fs_ewt_id, Me.offset, Me.minimum})
        Me.dgewt.Location = New System.Drawing.Point(22, 79)
        Me.dgewt.Name = "dgewt"
        Me.dgewt.RowHeadersVisible = False
        Me.dgewt.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgewt.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgewt.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgewt.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgewt.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgewt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgewt.Size = New System.Drawing.Size(713, 147)
        Me.dgewt.TabIndex = 1
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FalseValue = "False"
        Me.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.TrueValue = "True"
        Me.sel.Width = 30
        '
        'ewt_id
        '
        Me.ewt_id.DataPropertyName = "ewt_id"
        Me.ewt_id.HeaderText = "ewt_id"
        Me.ewt_id.Name = "ewt_id"
        Me.ewt_id.Visible = False
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Visible = False
        '
        'tin
        '
        Me.tin.DataPropertyName = "tin"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tin.DefaultCellStyle = DataGridViewCellStyle1
        Me.tin.HeaderText = "TIN"
        Me.tin.Name = "tin"
        Me.tin.ReadOnly = True
        Me.tin.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.general_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.general_name.HeaderText = "Supplier Name"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        Me.general_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.general_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.general_name.Width = 160
        '
        'fs_ewt_code
        '
        Me.fs_ewt_code.DataPropertyName = "fs_ewt_code"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fs_ewt_code.DefaultCellStyle = DataGridViewCellStyle3
        Me.fs_ewt_code.HeaderText = "EWT Code"
        Me.fs_ewt_code.Name = "fs_ewt_code"
        Me.fs_ewt_code.ReadOnly = True
        Me.fs_ewt_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fs_ewt_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fs_ewt_code.Width = 120
        '
        'tax_rate
        '
        Me.tax_rate.DataPropertyName = "tax_rate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "##,##0.00"
        Me.tax_rate.DefaultCellStyle = DataGridViewCellStyle4
        Me.tax_rate.HeaderText = "Tax Rate"
        Me.tax_rate.Name = "tax_rate"
        Me.tax_rate.ReadOnly = True
        Me.tax_rate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tax_rate.Width = 80
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "##,##0.00"
        Me.amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.amount.HeaderText = "Amount of Payment"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.amount.Width = 130
        '
        'tax_amount
        '
        Me.tax_amount.DataPropertyName = "tax_amount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "##,##0.00"
        Me.tax_amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.tax_amount.HeaderText = "Tax Withheld"
        Me.tax_amount.Name = "tax_amount"
        Me.tax_amount.ReadOnly = True
        Me.tax_amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tax_amount.Width = 90
        '
        'general_id
        '
        Me.general_id.DataPropertyName = "general_id"
        Me.general_id.HeaderText = "general_id"
        Me.general_id.Name = "general_id"
        Me.general_id.Visible = False
        '
        'fs_ewt_id
        '
        Me.fs_ewt_id.DataPropertyName = "fs_ewt_id"
        Me.fs_ewt_id.HeaderText = "fs_ewt_id"
        Me.fs_ewt_id.Name = "fs_ewt_id"
        Me.fs_ewt_id.Visible = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EWT Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(194, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Supplier Code"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(194, 232)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "F4 Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(108, 232)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "F3 Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(22, 232)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "F2 Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(194, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "EWT Code"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "Tax Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Amount Based"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(526, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Tax Withheld"
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.Maroon
        Me.btnUndo.Enabled = False
        Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.ForeColor = System.Drawing.Color.White
        Me.btnUndo.Location = New System.Drawing.Point(628, 94)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(80, 24)
        Me.btnUndo.TabIndex = 52
        Me.btnUndo.Text = "Cancel"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Green
        Me.btnOK.Enabled = False
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(542, 94)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 24)
        Me.btnOK.TabIndex = 51
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(379, 391)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 62
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(293, 391)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(571, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "TIN"
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {ewt})
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
        Me.txtjbooksid.Location = New System.Drawing.Point(636, 36)
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
        Me.txtjbooksid.TabIndex = 1
        Me.txtjbooksid.TableData = Nothing
        Me.txtjbooksid.TextSource = ""
        Me.txtjbooksid.UseSystemPasswordChar = False
        Me.txtjbooksid.Value = ""
        Me.txtjbooksid.ValueSource = ""
        Me.txtjbooksid.Visible = False
        '
        'txtTIN
        '
        Me.txtTIN._Text = ""
        Me.txtTIN.AllowNegative = False
        Me.txtTIN.AlwaysDisable = False
        Me.txtTIN.AlwaysEnable = False
        Me.txtTIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTIN.BorderColor = System.Drawing.Color.DarkGray
        Me.txtTIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTIN.DataSource = ""
        Me.txtTIN.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTIN.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTIN.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtTIN.Enabled = False
        Me.txtTIN.EnabledBackColor = System.Drawing.Color.White
        Me.txtTIN.ForeColor = System.Drawing.Color.Black
        Me.txtTIN.ispk = False
        Me.txtTIN.Location = New System.Drawing.Point(602, 11)
        Me.txtTIN.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTIN.MultiLine = False
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.NoClear = False
        Me.txtTIN.NumberFormat = "@"
        Me.txtTIN.Required = False
        Me.txtTIN.RowData = Nothing
        Me.txtTIN.SelectionLength = 0
        Me.txtTIN.SelectionStart = 0
        Me.txtTIN.Size = New System.Drawing.Size(100, 20)
        Me.txtTIN.TabIndex = 4
        Me.txtTIN.TableData = Nothing
        Me.txtTIN.TextSource = ""
        Me.txtTIN.UseSystemPasswordChar = False
        Me.txtTIN.Value = ""
        Me.txtTIN.ValueSource = ""
        '
        'txtewtname
        '
        Me.txtewtname._Text = ""
        Me.txtewtname.AllowNegative = False
        Me.txtewtname.AlwaysDisable = False
        Me.txtewtname.AlwaysEnable = False
        Me.txtewtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtewtname.BorderColor = System.Drawing.Color.DarkGray
        Me.txtewtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtewtname.DataSource = ""
        Me.txtewtname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtewtname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtewtname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtewtname.Enabled = False
        Me.txtewtname.EnabledBackColor = System.Drawing.Color.White
        Me.txtewtname.ForeColor = System.Drawing.Color.Black
        Me.txtewtname.ispk = False
        Me.txtewtname.Location = New System.Drawing.Point(211, 37)
        Me.txtewtname.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtewtname.MultiLine = False
        Me.txtewtname.Name = "txtewtname"
        Me.txtewtname.NoClear = False
        Me.txtewtname.NumberFormat = "@"
        Me.txtewtname.Required = False
        Me.txtewtname.RowData = Nothing
        Me.txtewtname.SelectionLength = 0
        Me.txtewtname.SelectionStart = 0
        Me.txtewtname.Size = New System.Drawing.Size(491, 20)
        Me.txtewtname.TabIndex = 6
        Me.txtewtname.TableData = Nothing
        Me.txtewtname.TextSource = ""
        Me.txtewtname.UseSystemPasswordChar = False
        Me.txtewtname.Value = ""
        Me.txtewtname.ValueSource = ""
        '
        'txtewt
        '
        Me.txtewt._Text = ""
        Me.txtewt.AllowNegative = False
        Me.txtewt.AlwaysDisable = False
        Me.txtewt.AlwaysEnable = False
        Me.txtewt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtewt.BorderColor = System.Drawing.Color.DarkGray
        Me.txtewt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtewt.DataSource = ""
        Me.txtewt.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtewt.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtewt.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtewt.Enabled = False
        Me.txtewt.EnabledBackColor = System.Drawing.Color.White
        Me.txtewt.ForeColor = System.Drawing.Color.Black
        Me.txtewt.ispk = False
        Me.txtewt.Location = New System.Drawing.Point(90, 37)
        Me.txtewt.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtewt.MultiLine = False
        Me.txtewt.Name = "txtewt"
        Me.txtewt.NoClear = False
        Me.txtewt.NumberFormat = "@"
        Me.txtewt.Required = False
        Me.txtewt.RowData = Nothing
        Me.txtewt.SelectionLength = 0
        Me.txtewt.SelectionStart = 0
        Me.txtewt.Size = New System.Drawing.Size(100, 20)
        Me.txtewt.TabIndex = 5
        Me.txtewt.TableData = Nothing
        Me.txtewt.TextSource = ""
        Me.txtewt.UseSystemPasswordChar = False
        Me.txtewt.Value = ""
        Me.txtewt.ValueSource = ""
        '
        'txtgeneralname
        '
        Me.txtgeneralname._Text = ""
        Me.txtgeneralname.AllowNegative = False
        Me.txtgeneralname.AlwaysDisable = False
        Me.txtgeneralname.AlwaysEnable = False
        Me.txtgeneralname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneralname.BorderColor = System.Drawing.Color.DarkGray
        Me.txtgeneralname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgeneralname.DataSource = ""
        Me.txtgeneralname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneralname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneralname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtgeneralname.Enabled = False
        Me.txtgeneralname.EnabledBackColor = System.Drawing.Color.White
        Me.txtgeneralname.ForeColor = System.Drawing.Color.Black
        Me.txtgeneralname.ispk = False
        Me.txtgeneralname.Location = New System.Drawing.Point(211, 11)
        Me.txtgeneralname.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneralname.MultiLine = False
        Me.txtgeneralname.Name = "txtgeneralname"
        Me.txtgeneralname.NoClear = False
        Me.txtgeneralname.NumberFormat = "@"
        Me.txtgeneralname.Required = False
        Me.txtgeneralname.RowData = Nothing
        Me.txtgeneralname.SelectionLength = 0
        Me.txtgeneralname.SelectionStart = 0
        Me.txtgeneralname.Size = New System.Drawing.Size(350, 20)
        Me.txtgeneralname.TabIndex = 3
        Me.txtgeneralname.TableData = Nothing
        Me.txtgeneralname.TextSource = ""
        Me.txtgeneralname.UseSystemPasswordChar = False
        Me.txtgeneralname.Value = ""
        Me.txtgeneralname.ValueSource = ""
        '
        'txtgeneral
        '
        Me.txtgeneral._Text = ""
        Me.txtgeneral.AllowNegative = False
        Me.txtgeneral.AlwaysDisable = False
        Me.txtgeneral.AlwaysEnable = False
        Me.txtgeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneral.BorderColor = System.Drawing.Color.DarkGray
        Me.txtgeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgeneral.DataSource = ""
        Me.txtgeneral.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneral.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneral.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtgeneral.Enabled = False
        Me.txtgeneral.EnabledBackColor = System.Drawing.Color.White
        Me.txtgeneral.ForeColor = System.Drawing.Color.Black
        Me.txtgeneral.ispk = False
        Me.txtgeneral.Location = New System.Drawing.Point(90, 11)
        Me.txtgeneral.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneral.MultiLine = False
        Me.txtgeneral.Name = "txtgeneral"
        Me.txtgeneral.NoClear = False
        Me.txtgeneral.NumberFormat = "@"
        Me.txtgeneral.Required = False
        Me.txtgeneral.RowData = Nothing
        Me.txtgeneral.SelectionLength = 0
        Me.txtgeneral.SelectionStart = 0
        Me.txtgeneral.Size = New System.Drawing.Size(100, 20)
        Me.txtgeneral.TabIndex = 2
        Me.txtgeneral.TableData = Nothing
        Me.txtgeneral.TextSource = ""
        Me.txtgeneral.UseSystemPasswordChar = False
        Me.txtgeneral.Value = ""
        Me.txtgeneral.ValueSource = ""
        '
        'det
        '
        Me.det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.det.Controls.Add(Me.txttaxamount)
        Me.det.Controls.Add(Me.txttaxrate)
        Me.det.Controls.Add(Me.txt_tmp_amount)
        Me.det.Controls.Add(Me.txtgeneral)
        Me.det.Controls.Add(Me.txtamount)
        Me.det.Controls.Add(Me.Label4)
        Me.det.Controls.Add(Me.PictureBox1)
        Me.det.Controls.Add(Me.Label2)
        Me.det.Controls.Add(Me.PictureBox2)
        Me.det.Controls.Add(Me.Label22)
        Me.det.Controls.Add(Me.txtTIN)
        Me.det.Controls.Add(Me.Label3)
        Me.det.Controls.Add(Me.txtewtname)
        Me.det.Controls.Add(Me.Label5)
        Me.det.Controls.Add(Me.txtewt)
        Me.det.Controls.Add(Me.btnOK)
        Me.det.Controls.Add(Me.txtgeneralname)
        Me.det.Controls.Add(Me.btnUndo)
        Me.det.Controls.Add(Me.Label6)
        Me.det.Location = New System.Drawing.Point(22, 261)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(713, 123)
        Me.det.TabIndex = 108
        '
        'txttaxamount
        '
        Me.txttaxamount.EditValue = "0.00"
        Me.txttaxamount.Enabled = False
        Me.txttaxamount.Location = New System.Drawing.Point(602, 63)
        Me.txttaxamount.Name = "txttaxamount"
        Me.txttaxamount.Properties.DisplayFormat.FormatString = "n4"
        Me.txttaxamount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttaxamount.Properties.EditFormat.FormatString = "n4"
        Me.txttaxamount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttaxamount.Properties.Mask.EditMask = "n4"
        Me.txttaxamount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttaxamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txttaxamount.Size = New System.Drawing.Size(100, 20)
        Me.txttaxamount.TabIndex = 10
        Me.txttaxamount.Tag = ""
        '
        'txttaxrate
        '
        Me.txttaxrate.EditValue = "0.00"
        Me.txttaxrate.Enabled = False
        Me.txttaxrate.Location = New System.Drawing.Point(90, 64)
        Me.txttaxrate.Name = "txttaxrate"
        Me.txttaxrate.Properties.DisplayFormat.FormatString = "n4"
        Me.txttaxrate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttaxrate.Properties.EditFormat.FormatString = "n4"
        Me.txttaxrate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttaxrate.Properties.Mask.EditMask = "n4"
        Me.txttaxrate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttaxrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txttaxrate.Size = New System.Drawing.Size(100, 20)
        Me.txttaxrate.TabIndex = 7
        Me.txttaxrate.Tag = ""
        '
        'txt_tmp_amount
        '
        Me.txt_tmp_amount.EditValue = "0.00"
        Me.txt_tmp_amount.Enabled = False
        Me.txt_tmp_amount.Location = New System.Drawing.Point(320, 89)
        Me.txt_tmp_amount.Name = "txt_tmp_amount"
        Me.txt_tmp_amount.Properties.DisplayFormat.FormatString = "n4"
        Me.txt_tmp_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_tmp_amount.Properties.EditFormat.FormatString = "n4"
        Me.txt_tmp_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_tmp_amount.Properties.Mask.EditMask = "n4"
        Me.txt_tmp_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_tmp_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_tmp_amount.Size = New System.Drawing.Size(140, 20)
        Me.txt_tmp_amount.TabIndex = 9
        Me.txt_tmp_amount.Tag = ""
        Me.txt_tmp_amount.Visible = False
        '
        'txtamount
        '
        Me.txtamount.EditValue = "0.00"
        Me.txtamount.Enabled = False
        Me.txtamount.Location = New System.Drawing.Point(320, 63)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Properties.DisplayFormat.FormatString = "n4"
        Me.txtamount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtamount.Properties.EditFormat.FormatString = "n4"
        Me.txtamount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtamount.Properties.Mask.EditMask = "n4"
        Me.txtamount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtamount.Size = New System.Drawing.Size(140, 20)
        Me.txtamount.TabIndex = 8
        Me.txtamount.Tag = ""
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(752, 28)
        Me.Myformheader1.TabIndex = 109
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(22, 66)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(713, 2)
        Me.border2.TabIndex = 5
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(22, 64)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(713, 2)
        Me.border1.TabIndex = 4
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'setupewt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 430)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.det)
        Me.Controls.Add(Me.txtjbooksid)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgewt)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setupewt"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EWT Details"
        CType(ewt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgewt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.det.ResumeLayout(False)
        Me.det.PerformLayout()
        CType(Me.txttaxamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttaxrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tmp_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgewt As System.Windows.Forms.DataGridView
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtgeneralname As user_control.textbox
    Friend WithEvents txtgeneral As user_control.textbox
    Friend WithEvents txtewtname As user_control.textbox
    Friend WithEvents txtewt As user_control.textbox
    Friend WithEvents txtTIN As user_control.textbox
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents txtjbooksid As user_control.textbox
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents det As System.Windows.Forms.Panel
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ewt_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fs_ewt_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tax_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tax_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fs_ewt_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents offset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minimum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txttaxamount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttaxrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_tmp_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtamount As DevExpress.XtraEditors.TextEdit
End Class
