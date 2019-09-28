<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setupinputvat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setupinputvat))
        Me.dgdet = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.input_vat_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vat_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gross_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vat_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.net_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.offset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnnotsave = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.input_vat = New System.Data.DataTable()
        Me.DataColumn97 = New System.Data.DataColumn()
        Me.DataColumn98 = New System.Data.DataColumn()
        Me.DataColumn99 = New System.Data.DataColumn()
        Me.DataColumn100 = New System.Data.DataColumn()
        Me.DataColumn101 = New System.Data.DataColumn()
        Me.DataColumn102 = New System.Data.DataColumn()
        Me.DataColumn103 = New System.Data.DataColumn()
        Me.DataColumn104 = New System.Data.DataColumn()
        Me.DataColumn105 = New System.Data.DataColumn()
        Me.DataColumn106 = New System.Data.DataColumn()
        Me.DataColumn107 = New System.Data.DataColumn()
        Me.DataColumn108 = New System.Data.DataColumn()
        Me.DataColumn109 = New System.Data.DataColumn()
        Me.DataColumn110 = New System.Data.DataColumn()
        Me.DataColumn111 = New System.Data.DataColumn()
        Me.DataColumn112 = New System.Data.DataColumn()
        Me.DataColumn113 = New System.Data.DataColumn()
        Me.DataColumn114 = New System.Data.DataColumn()
        Me.DataColumn115 = New System.Data.DataColumn()
        Me.DataColumn116 = New System.Data.DataColumn()
        Me.DataColumn117 = New System.Data.DataColumn()
        Me.DataColumn157 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.det = New System.Windows.Forms.Panel()
        Me.txtnetamount = New DevExpress.XtraEditors.TextEdit()
        Me.txt_jbooks_id = New user_control.textbox()
        Me.txtvatamount = New DevExpress.XtraEditors.TextEdit()
        Me.btndet2 = New System.Windows.Forms.Panel()
        Me.btnundo = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtgrossamount = New DevExpress.XtraEditors.TextEdit()
        Me.radvatclass = New System.Windows.Forms.Panel()
        Me.rdovatclass3 = New user_control.rdo_button()
        Me.rdovatclass2 = New user_control.rdo_button()
        Me.rdovatclass1 = New user_control.rdo_button()
        Me.radvattype = New System.Windows.Forms.Panel()
        Me.rdovattype2 = New user_control.rdo_button()
        Me.rdovattype1 = New user_control.rdo_button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttin = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtvatrate = New user_control.textbox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtaddress = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtgeneralname = New user_control.textbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtgeneral = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btndet1 = New System.Windows.Forms.Panel()
        Me.btnhdr2 = New System.Windows.Forms.Panel()
        Me.ds = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
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
        Me.DataColumn138 = New System.Data.DataColumn()
        Me.DataColumn139 = New System.Data.DataColumn()
        Me.DataColumn140 = New System.Data.DataColumn()
        Me.DataColumn141 = New System.Data.DataColumn()
        Me.DataColumn142 = New System.Data.DataColumn()
        Me.DataColumn143 = New System.Data.DataColumn()
        Me.DataColumn144 = New System.Data.DataColumn()
        Me.DataColumn210 = New System.Data.DataColumn()
        Me.DataColumn211 = New System.Data.DataColumn()
        Me.DataColumn212 = New System.Data.DataColumn()
        Me.DataColumn213 = New System.Data.DataColumn()
        Me.DataColumn214 = New System.Data.DataColumn()
        Me.DataColumn215 = New System.Data.DataColumn()
        Me.DataColumn216 = New System.Data.DataColumn()
        Me.DataColumn217 = New System.Data.DataColumn()
        Me.DataColumn218 = New System.Data.DataColumn()
        Me.DataColumn219 = New System.Data.DataColumn()
        Me.DataColumn220 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.Myformheader1 = New user_control.myformheader()
        Me.menuImport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.browseImport = New System.Windows.Forms.FolderBrowserDialog()
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.dgdet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input_vat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.det.SuspendLayout()
        CType(Me.txtnetamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvatamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btndet2.SuspendLayout()
        CType(Me.txtgrossamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radvatclass.SuspendLayout()
        Me.radvattype.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btndet1.SuspendLayout()
        Me.btnhdr2.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuImport.SuspendLayout()
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
        Me.dgdet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.deleted, Me.input_vat_id, Me.tin, Me.general_name, Me.address, Me.vat_rate, Me.gross_amount, Me.vat_amount, Me.net_amount, Me.offset, Me.minimum, Me.general_code})
        Me.dgdet.Location = New System.Drawing.Point(22, 78)
        Me.dgdet.MultiSelect = False
        Me.dgdet.Name = "dgdet"
        Me.dgdet.RowHeadersVisible = False
        Me.dgdet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgdet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdet.Size = New System.Drawing.Size(793, 168)
        Me.dgdet.TabIndex = 1
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
        Me.deleted.FalseValue = "False"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.deleted.TrueValue = "True"
        Me.deleted.Visible = False
        '
        'input_vat_id
        '
        Me.input_vat_id.DataPropertyName = "input_vat_id"
        Me.input_vat_id.HeaderText = "ID"
        Me.input_vat_id.Name = "input_vat_id"
        Me.input_vat_id.Visible = False
        '
        'tin
        '
        Me.tin.DataPropertyName = "tin"
        Me.tin.HeaderText = "TIN"
        Me.tin.Name = "tin"
        Me.tin.ReadOnly = True
        Me.tin.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Supplier Name"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        Me.general_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.general_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.general_name.Width = 160
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "Supplier Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.address.Width = 160
        '
        'vat_rate
        '
        Me.vat_rate.DataPropertyName = "vat_rate"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "##,##0.00"
        Me.vat_rate.DefaultCellStyle = DataGridViewCellStyle1
        Me.vat_rate.HeaderText = "VAT Rate"
        Me.vat_rate.Name = "vat_rate"
        Me.vat_rate.ReadOnly = True
        Me.vat_rate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vat_rate.Width = 60
        '
        'gross_amount
        '
        Me.gross_amount.DataPropertyName = "gross_amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "##,##0.00"
        Me.gross_amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.gross_amount.HeaderText = "Purchase Amount"
        Me.gross_amount.Name = "gross_amount"
        Me.gross_amount.ReadOnly = True
        Me.gross_amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'vat_amount
        '
        Me.vat_amount.DataPropertyName = "vat_amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "##,##0.00"
        Me.vat_amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.vat_amount.HeaderText = "Vat Amount"
        Me.vat_amount.Name = "vat_amount"
        Me.vat_amount.ReadOnly = True
        Me.vat_amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vat_amount.Width = 80
        '
        'net_amount
        '
        Me.net_amount.DataPropertyName = "net_amount"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "##,##0.00"
        Me.net_amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.net_amount.HeaderText = "Net Purchase"
        Me.net_amount.Name = "net_amount"
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
        'general_code
        '
        Me.general_code.DataPropertyName = "general_code"
        Me.general_code.HeaderText = "general_code"
        Me.general_code.Name = "general_code"
        Me.general_code.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input VAT Details"
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ForeColor = System.Drawing.Color.White
        Me.btnremove.Location = New System.Drawing.Point(173, 1)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(80, 24)
        Me.btnremove.TabIndex = 13
        Me.btnremove.Text = "F4 Remove"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(87, 1)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(80, 24)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "F3 Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.Color.White
        Me.btninsert.Location = New System.Drawing.Point(1, 1)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(80, 24)
        Me.btninsert.TabIndex = 11
        Me.btninsert.Text = "F2 Insert"
        Me.btninsert.UseVisualStyleBackColor = False
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
        Me.btnnotsave.TabIndex = 100
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
        Me.btnsave.TabIndex = 99
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'input_vat
        '
        Me.input_vat.TableName = "input_vat"
        '
        'DataColumn97
        '
        Me.DataColumn97.AllowDBNull = False
        Me.DataColumn97.ColumnName = "input_vat_id"
        Me.DataColumn97.DefaultValue = ""
        '
        'DataColumn98
        '
        Me.DataColumn98.AllowDBNull = False
        Me.DataColumn98.ColumnName = "jbooks_id"
        Me.DataColumn98.DefaultValue = ""
        '
        'DataColumn99
        '
        Me.DataColumn99.AllowDBNull = False
        Me.DataColumn99.ColumnName = "general_id"
        Me.DataColumn99.DefaultValue = ""
        '
        'DataColumn100
        '
        Me.DataColumn100.AllowDBNull = False
        Me.DataColumn100.ColumnName = "vat_class"
        Me.DataColumn100.DataType = GetType(Short)
        Me.DataColumn100.DefaultValue = CType(0, Short)
        '
        'DataColumn101
        '
        Me.DataColumn101.AllowDBNull = False
        Me.DataColumn101.ColumnName = "vat_type"
        Me.DataColumn101.DataType = GetType(Short)
        Me.DataColumn101.DefaultValue = CType(0, Short)
        '
        'DataColumn102
        '
        Me.DataColumn102.AllowDBNull = False
        Me.DataColumn102.ColumnName = "vat_rate"
        Me.DataColumn102.DataType = GetType(Decimal)
        Me.DataColumn102.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn103
        '
        Me.DataColumn103.AllowDBNull = False
        Me.DataColumn103.ColumnName = "offset_type"
        Me.DataColumn103.DataType = GetType(Short)
        Me.DataColumn103.DefaultValue = CType(0, Short)
        '
        'DataColumn104
        '
        Me.DataColumn104.AllowDBNull = False
        Me.DataColumn104.ColumnName = "gross_amount"
        Me.DataColumn104.DataType = GetType(Decimal)
        Me.DataColumn104.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn105
        '
        Me.DataColumn105.AllowDBNull = False
        Me.DataColumn105.ColumnName = "vat_amount"
        Me.DataColumn105.DataType = GetType(Decimal)
        '
        'DataColumn106
        '
        Me.DataColumn106.AllowDBNull = False
        Me.DataColumn106.ColumnName = "net_amount"
        Me.DataColumn106.DataType = GetType(Decimal)
        Me.DataColumn106.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn107
        '
        Me.DataColumn107.AllowDBNull = False
        Me.DataColumn107.ColumnName = "debit"
        Me.DataColumn107.DataType = GetType(Decimal)
        Me.DataColumn107.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn108
        '
        Me.DataColumn108.AllowDBNull = False
        Me.DataColumn108.ColumnName = "credit"
        Me.DataColumn108.DataType = GetType(Decimal)
        Me.DataColumn108.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn109
        '
        Me.DataColumn109.AllowDBNull = False
        Me.DataColumn109.ColumnName = "gross_amount_based"
        Me.DataColumn109.DataType = GetType(Decimal)
        Me.DataColumn109.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn110
        '
        Me.DataColumn110.AllowDBNull = False
        Me.DataColumn110.ColumnName = "vat_amount_based"
        Me.DataColumn110.DataType = GetType(Decimal)
        Me.DataColumn110.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn111
        '
        Me.DataColumn111.AllowDBNull = False
        Me.DataColumn111.ColumnName = "net_amount_based"
        Me.DataColumn111.DataType = GetType(Decimal)
        Me.DataColumn111.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn112
        '
        Me.DataColumn112.AllowDBNull = False
        Me.DataColumn112.ColumnName = "debit_based"
        Me.DataColumn112.DataType = GetType(Decimal)
        Me.DataColumn112.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn113
        '
        Me.DataColumn113.AllowDBNull = False
        Me.DataColumn113.ColumnName = "credit_based"
        Me.DataColumn113.DataType = GetType(Decimal)
        Me.DataColumn113.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn114
        '
        Me.DataColumn114.AllowDBNull = False
        Me.DataColumn114.ColumnName = "ref_input_vat_id"
        Me.DataColumn114.DefaultValue = ""
        '
        'DataColumn115
        '
        Me.DataColumn115.AllowDBNull = False
        Me.DataColumn115.ColumnName = "general_code"
        Me.DataColumn115.DefaultValue = ""
        '
        'DataColumn116
        '
        Me.DataColumn116.AllowDBNull = False
        Me.DataColumn116.ColumnName = "general_name"
        Me.DataColumn116.DefaultValue = ""
        '
        'DataColumn117
        '
        Me.DataColumn117.AllowDBNull = False
        Me.DataColumn117.ColumnName = "tin"
        Me.DataColumn117.DefaultValue = ""
        '
        'DataColumn157
        '
        Me.DataColumn157.ColumnName = "deleted"
        Me.DataColumn157.DataType = GetType(Boolean)
        Me.DataColumn157.DefaultValue = False
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "currency_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "exchange_rate"
        Me.DataColumn2.DataType = GetType(Decimal)
        Me.DataColumn2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "based_rate"
        Me.DataColumn3.DataType = GetType(Decimal)
        Me.DataColumn3.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn4
        '
        Me.DataColumn4.AllowDBNull = False
        Me.DataColumn4.ColumnName = "address"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.AllowDBNull = False
        Me.DataColumn5.ColumnName = "sel"
        Me.DataColumn5.DataType = GetType(Boolean)
        Me.DataColumn5.DefaultValue = False
        '
        'det
        '
        Me.det.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.det.Controls.Add(Me.txtnetamount)
        Me.det.Controls.Add(Me.txt_jbooks_id)
        Me.det.Controls.Add(Me.txtvatamount)
        Me.det.Controls.Add(Me.btndet2)
        Me.det.Controls.Add(Me.txtgrossamount)
        Me.det.Controls.Add(Me.radvatclass)
        Me.det.Controls.Add(Me.radvattype)
        Me.det.Controls.Add(Me.Label7)
        Me.det.Controls.Add(Me.txttin)
        Me.det.Controls.Add(Me.Label6)
        Me.det.Controls.Add(Me.Label5)
        Me.det.Controls.Add(Me.Label3)
        Me.det.Controls.Add(Me.txtvatrate)
        Me.det.Controls.Add(Me.Label22)
        Me.det.Controls.Add(Me.txtaddress)
        Me.det.Controls.Add(Me.Label2)
        Me.det.Controls.Add(Me.txtgeneralname)
        Me.det.Controls.Add(Me.PictureBox1)
        Me.det.Controls.Add(Me.txtgeneral)
        Me.det.Controls.Add(Me.Label4)
        Me.det.Location = New System.Drawing.Point(22, 281)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(793, 140)
        Me.det.TabIndex = 114
        '
        'txtnetamount
        '
        Me.txtnetamount.EditValue = "0.00"
        Me.txtnetamount.Enabled = False
        Me.txtnetamount.Location = New System.Drawing.Point(621, 86)
        Me.txtnetamount.Name = "txtnetamount"
        Me.txtnetamount.Properties.DisplayFormat.FormatString = "n4"
        Me.txtnetamount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtnetamount.Properties.EditFormat.FormatString = "n4"
        Me.txtnetamount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtnetamount.Properties.Mask.EditMask = "n4"
        Me.txtnetamount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtnetamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtnetamount.Size = New System.Drawing.Size(160, 20)
        Me.txtnetamount.TabIndex = 13
        Me.txtnetamount.Tag = "net_amount"
        '
        'txt_jbooks_id
        '
        Me.txt_jbooks_id._Text = ""
        Me.txt_jbooks_id.AllowNegative = False
        Me.txt_jbooks_id.AlwaysDisable = True
        Me.txt_jbooks_id.AlwaysEnable = False
        Me.txt_jbooks_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_jbooks_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_jbooks_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_jbooks_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jbooks_id.DataSource = ""
        Me.txt_jbooks_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_jbooks_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_jbooks_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_jbooks_id.Enabled = False
        Me.txt_jbooks_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_jbooks_id.ispk = False
        Me.txt_jbooks_id.Location = New System.Drawing.Point(536, 8)
        Me.txt_jbooks_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_jbooks_id.MultiLine = False
        Me.txt_jbooks_id.Name = "txt_jbooks_id"
        Me.txt_jbooks_id.NoClear = False
        Me.txt_jbooks_id.NumberFormat = "@"
        Me.txt_jbooks_id.Required = False
        Me.txt_jbooks_id.RowData = Nothing
        Me.txt_jbooks_id.SelectionLength = 0
        Me.txt_jbooks_id.SelectionStart = 0
        Me.txt_jbooks_id.Size = New System.Drawing.Size(244, 20)
        Me.txt_jbooks_id.TabIndex = 1
        Me.txt_jbooks_id.TableData = Nothing
        Me.txt_jbooks_id.TextSource = "jbooks_id"
        Me.txt_jbooks_id.UseSystemPasswordChar = False
        Me.txt_jbooks_id.Value = ""
        Me.txt_jbooks_id.ValueSource = ""
        Me.txt_jbooks_id.Visible = False
        '
        'txtvatamount
        '
        Me.txtvatamount.EditValue = "0.00"
        Me.txtvatamount.Enabled = False
        Me.txtvatamount.Location = New System.Drawing.Point(347, 86)
        Me.txtvatamount.Name = "txtvatamount"
        Me.txtvatamount.Properties.DisplayFormat.FormatString = "n4"
        Me.txtvatamount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtvatamount.Properties.EditFormat.FormatString = "n4"
        Me.txtvatamount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtvatamount.Properties.Mask.EditMask = "n4"
        Me.txtvatamount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtvatamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtvatamount.Size = New System.Drawing.Size(191, 20)
        Me.txtvatamount.TabIndex = 12
        Me.txtvatamount.Tag = "vat_amount"
        '
        'btndet2
        '
        Me.btndet2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndet2.Controls.Add(Me.btnundo)
        Me.btndet2.Controls.Add(Me.btnok)
        Me.btndet2.Location = New System.Drawing.Point(620, 109)
        Me.btndet2.Name = "btndet2"
        Me.btndet2.Size = New System.Drawing.Size(168, 26)
        Me.btndet2.TabIndex = 51
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
        Me.btnundo.TabIndex = 53
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
        Me.btnok.TabIndex = 52
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'txtgrossamount
        '
        Me.txtgrossamount.EditValue = "0.00"
        Me.txtgrossamount.Enabled = False
        Me.txtgrossamount.Location = New System.Drawing.Point(91, 86)
        Me.txtgrossamount.Name = "txtgrossamount"
        Me.txtgrossamount.Properties.DisplayFormat.FormatString = "n4"
        Me.txtgrossamount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtgrossamount.Properties.EditFormat.FormatString = "n4"
        Me.txtgrossamount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtgrossamount.Properties.Mask.EditMask = "n4"
        Me.txtgrossamount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtgrossamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtgrossamount.Size = New System.Drawing.Size(178, 20)
        Me.txtgrossamount.TabIndex = 11
        Me.txtgrossamount.Tag = "gross_amount"
        '
        'radvatclass
        '
        Me.radvatclass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.radvatclass.Controls.Add(Me.rdovatclass3)
        Me.radvatclass.Controls.Add(Me.rdovatclass2)
        Me.radvatclass.Controls.Add(Me.rdovatclass1)
        Me.radvatclass.Location = New System.Drawing.Point(209, 5)
        Me.radvatclass.Name = "radvatclass"
        Me.radvatclass.Size = New System.Drawing.Size(321, 22)
        Me.radvatclass.TabIndex = 3
        '
        'rdovatclass3
        '
        Me.rdovatclass3.AutoSize = True
        Me.rdovatclass3.DataSource = ""
        Me.rdovatclass3.Enabled = False
        Me.rdovatclass3.Location = New System.Drawing.Point(170, 3)
        Me.rdovatclass3.Name = "rdovatclass3"
        Me.rdovatclass3.Size = New System.Drawing.Size(147, 17)
        Me.rdovatclass3.TabIndex = 6
        Me.rdovatclass3.TabStop = True
        Me.rdovatclass3.Text = "Other than Capital Goods"
        Me.rdovatclass3.TextSource = ""
        Me.rdovatclass3.Uncheckable = False
        Me.rdovatclass3.UseVisualStyleBackColor = True
        Me.rdovatclass3.Value = "3"
        Me.rdovatclass3.ValueSource = "vat_class"
        '
        'rdovatclass2
        '
        Me.rdovatclass2.AutoSize = True
        Me.rdovatclass2.DataSource = ""
        Me.rdovatclass2.Enabled = False
        Me.rdovatclass2.Location = New System.Drawing.Point(73, 3)
        Me.rdovatclass2.Name = "rdovatclass2"
        Me.rdovatclass2.Size = New System.Drawing.Size(91, 17)
        Me.rdovatclass2.TabIndex = 5
        Me.rdovatclass2.TabStop = True
        Me.rdovatclass2.Text = "Capital Goods"
        Me.rdovatclass2.TextSource = ""
        Me.rdovatclass2.Uncheckable = False
        Me.rdovatclass2.UseVisualStyleBackColor = True
        Me.rdovatclass2.Value = "2"
        Me.rdovatclass2.ValueSource = "vat_class"
        '
        'rdovatclass1
        '
        Me.rdovatclass1.AutoSize = True
        Me.rdovatclass1.DataSource = ""
        Me.rdovatclass1.Enabled = False
        Me.rdovatclass1.Location = New System.Drawing.Point(2, 3)
        Me.rdovatclass1.Name = "rdovatclass1"
        Me.rdovatclass1.Size = New System.Drawing.Size(65, 17)
        Me.rdovatclass1.TabIndex = 4
        Me.rdovatclass1.TabStop = True
        Me.rdovatclass1.Text = "Services"
        Me.rdovatclass1.TextSource = ""
        Me.rdovatclass1.Uncheckable = False
        Me.rdovatclass1.UseVisualStyleBackColor = True
        Me.rdovatclass1.Value = "1"
        Me.rdovatclass1.ValueSource = "vat_class"
        '
        'radvattype
        '
        Me.radvattype.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.radvattype.Controls.Add(Me.rdovattype2)
        Me.radvattype.Controls.Add(Me.rdovattype1)
        Me.radvattype.Location = New System.Drawing.Point(91, 112)
        Me.radvattype.Name = "radvattype"
        Me.radvattype.Size = New System.Drawing.Size(194, 22)
        Me.radvattype.TabIndex = 11
        '
        'rdovattype2
        '
        Me.rdovattype2.AutoSize = True
        Me.rdovattype2.DataSource = ""
        Me.rdovattype2.Enabled = False
        Me.rdovattype2.Location = New System.Drawing.Point(99, 3)
        Me.rdovattype2.Name = "rdovattype2"
        Me.rdovattype2.Size = New System.Drawing.Size(91, 17)
        Me.rdovattype2.TabIndex = 13
        Me.rdovattype2.TabStop = True
        Me.rdovattype2.Text = "VAT Exclusive"
        Me.rdovattype2.TextSource = ""
        Me.rdovattype2.Uncheckable = False
        Me.rdovattype2.UseVisualStyleBackColor = True
        Me.rdovattype2.Value = "2"
        Me.rdovattype2.ValueSource = "vat_type"
        '
        'rdovattype1
        '
        Me.rdovattype1.AutoSize = True
        Me.rdovattype1.DataSource = ""
        Me.rdovattype1.Enabled = False
        Me.rdovattype1.Location = New System.Drawing.Point(4, 3)
        Me.rdovattype1.Name = "rdovattype1"
        Me.rdovattype1.Size = New System.Drawing.Size(89, 17)
        Me.rdovattype1.TabIndex = 12
        Me.rdovattype1.TabStop = True
        Me.rdovattype1.Text = "VAT Inclusive"
        Me.rdovattype1.TextSource = ""
        Me.rdovattype1.Uncheckable = False
        Me.rdovattype1.UseVisualStyleBackColor = True
        Me.rdovattype1.Value = "1"
        Me.rdovattype1.ValueSource = "vat_type"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(544, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "Net Purchase"
        '
        'txttin
        '
        Me.txttin._Text = ""
        Me.txttin.AllowNegative = False
        Me.txttin.AlwaysDisable = True
        Me.txttin.AlwaysEnable = False
        Me.txttin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttin.BorderColor = System.Drawing.Color.DarkGray
        Me.txttin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttin.DataSource = ""
        Me.txttin.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttin.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttin.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txttin.Enabled = False
        Me.txttin.EnabledBackColor = System.Drawing.Color.White
        Me.txttin.ispk = False
        Me.txttin.Location = New System.Drawing.Point(671, 34)
        Me.txttin.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttin.MultiLine = False
        Me.txttin.Name = "txttin"
        Me.txttin.NoClear = False
        Me.txttin.NumberFormat = "@"
        Me.txttin.Required = False
        Me.txttin.RowData = Nothing
        Me.txttin.SelectionLength = 0
        Me.txttin.SelectionStart = 0
        Me.txttin.Size = New System.Drawing.Size(110, 20)
        Me.txttin.TabIndex = 9
        Me.txttin.TableData = Nothing
        Me.txttin.TextSource = "tin"
        Me.txttin.UseSystemPasswordChar = False
        Me.txttin.Value = ""
        Me.txttin.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(640, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "TIN"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "VAT Amount"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Gross Purchase"
        '
        'txtvatrate
        '
        Me.txtvatrate._Text = ""
        Me.txtvatrate.AllowNegative = False
        Me.txtvatrate.AlwaysDisable = True
        Me.txtvatrate.AlwaysEnable = False
        Me.txtvatrate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtvatrate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtvatrate.BorderColor = System.Drawing.Color.DarkGray
        Me.txtvatrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvatrate.DataSource = ""
        Me.txtvatrate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvatrate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtvatrate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtvatrate.Enabled = False
        Me.txtvatrate.EnabledBackColor = System.Drawing.Color.White
        Me.txtvatrate.ispk = False
        Me.txtvatrate.Location = New System.Drawing.Point(91, 7)
        Me.txtvatrate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvatrate.MultiLine = False
        Me.txtvatrate.Name = "txtvatrate"
        Me.txtvatrate.NoClear = True
        Me.txtvatrate.NumberFormat = "##,##0.00"
        Me.txtvatrate.Required = False
        Me.txtvatrate.RowData = Nothing
        Me.txtvatrate.SelectionLength = 0
        Me.txtvatrate.SelectionStart = 0
        Me.txtvatrate.Size = New System.Drawing.Size(100, 20)
        Me.txtvatrate.TabIndex = 2
        Me.txtvatrate.TableData = Nothing
        Me.txtvatrate.TextSource = ""
        Me.txtvatrate.UseSystemPasswordChar = False
        Me.txtvatrate.Value = "0.00"
        Me.txtvatrate.ValueSource = "vat_rate"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 120
        Me.Label22.Text = "VAT Rate"
        '
        'txtaddress
        '
        Me.txtaddress._Text = ""
        Me.txtaddress.AllowNegative = False
        Me.txtaddress.AlwaysDisable = True
        Me.txtaddress.AlwaysEnable = False
        Me.txtaddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaddress.BorderColor = System.Drawing.Color.DarkGray
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.DataSource = ""
        Me.txtaddress.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtaddress.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaddress.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtaddress.Enabled = False
        Me.txtaddress.EnabledBackColor = System.Drawing.Color.White
        Me.txtaddress.ispk = False
        Me.txtaddress.Location = New System.Drawing.Point(91, 60)
        Me.txtaddress.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtaddress.MultiLine = False
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.NoClear = False
        Me.txtaddress.NumberFormat = "@"
        Me.txtaddress.Required = False
        Me.txtaddress.RowData = Nothing
        Me.txtaddress.SelectionLength = 0
        Me.txtaddress.SelectionStart = 0
        Me.txtaddress.Size = New System.Drawing.Size(691, 20)
        Me.txtaddress.TabIndex = 10
        Me.txtaddress.TableData = Nothing
        Me.txtaddress.TextSource = "tin"
        Me.txtaddress.UseSystemPasswordChar = False
        Me.txtaddress.Value = ""
        Me.txtaddress.ValueSource = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Address"
        '
        'txtgeneralname
        '
        Me.txtgeneralname._Text = ""
        Me.txtgeneralname.AllowNegative = False
        Me.txtgeneralname.AlwaysDisable = True
        Me.txtgeneralname.AlwaysEnable = False
        Me.txtgeneralname.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtgeneralname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneralname.BorderColor = System.Drawing.Color.DarkGray
        Me.txtgeneralname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgeneralname.DataSource = ""
        Me.txtgeneralname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneralname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneralname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtgeneralname.Enabled = False
        Me.txtgeneralname.EnabledBackColor = System.Drawing.Color.White
        Me.txtgeneralname.ispk = False
        Me.txtgeneralname.Location = New System.Drawing.Point(209, 34)
        Me.txtgeneralname.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneralname.MultiLine = False
        Me.txtgeneralname.Name = "txtgeneralname"
        Me.txtgeneralname.NoClear = False
        Me.txtgeneralname.NumberFormat = "@"
        Me.txtgeneralname.Required = False
        Me.txtgeneralname.RowData = Nothing
        Me.txtgeneralname.SelectionLength = 0
        Me.txtgeneralname.SelectionStart = 0
        Me.txtgeneralname.Size = New System.Drawing.Size(420, 20)
        Me.txtgeneralname.TabIndex = 8
        Me.txtgeneralname.TableData = Nothing
        Me.txtgeneralname.TextSource = "general_code"
        Me.txtgeneralname.UseSystemPasswordChar = False
        Me.txtgeneralname.Value = ""
        Me.txtgeneralname.ValueSource = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(192, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'txtgeneral
        '
        Me.txtgeneral._Text = ""
        Me.txtgeneral.AllowNegative = False
        Me.txtgeneral.AlwaysDisable = False
        Me.txtgeneral.AlwaysEnable = False
        Me.txtgeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtgeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneral.BorderColor = System.Drawing.Color.DarkGray
        Me.txtgeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgeneral.DataSource = ""
        Me.txtgeneral.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneral.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneral.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtgeneral.Enabled = False
        Me.txtgeneral.EnabledBackColor = System.Drawing.Color.White
        Me.txtgeneral.ispk = False
        Me.txtgeneral.Location = New System.Drawing.Point(91, 34)
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
        Me.txtgeneral.TabIndex = 7
        Me.txtgeneral.TableData = Nothing
        Me.txtgeneral.TextSource = "general_code"
        Me.txtgeneral.UseSystemPasswordChar = False
        Me.txtgeneral.Value = ""
        Me.txtgeneral.ValueSource = "general_id"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Supplier Code"
        '
        'btndet1
        '
        Me.btndet1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndet1.Controls.Add(Me.btnremove)
        Me.btndet1.Controls.Add(Me.btninsert)
        Me.btndet1.Controls.Add(Me.btnupdate)
        Me.btndet1.Location = New System.Drawing.Point(22, 250)
        Me.btndet1.Name = "btndet1"
        Me.btndet1.Size = New System.Drawing.Size(254, 26)
        Me.btndet1.TabIndex = 115
        '
        'btnhdr2
        '
        Me.btnhdr2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnhdr2.Controls.Add(Me.btnnotsave)
        Me.btnhdr2.Controls.Add(Me.btnsave)
        Me.btnhdr2.Location = New System.Drawing.Point(331, 427)
        Me.btnhdr2.Name = "btnhdr2"
        Me.btnhdr2.Size = New System.Drawing.Size(170, 26)
        Me.btnhdr2.TabIndex = 116
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn123, Me.DataColumn124, Me.DataColumn125, Me.DataColumn126, Me.DataColumn127, Me.DataColumn128, Me.DataColumn129, Me.DataColumn130, Me.DataColumn131, Me.DataColumn132, Me.DataColumn133, Me.DataColumn134, Me.DataColumn135, Me.DataColumn136, Me.DataColumn137, Me.DataColumn138, Me.DataColumn139, Me.DataColumn140, Me.DataColumn141, Me.DataColumn142, Me.DataColumn143, Me.DataColumn144, Me.DataColumn210, Me.DataColumn211, Me.DataColumn212, Me.DataColumn213, Me.DataColumn214, Me.DataColumn215, Me.DataColumn216, Me.DataColumn217, Me.DataColumn218, Me.DataColumn219, Me.DataColumn220, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable1.TableName = "input_vat"
        '
        'DataColumn123
        '
        Me.DataColumn123.ColumnName = "sel"
        Me.DataColumn123.DataType = GetType(Boolean)
        Me.DataColumn123.DefaultValue = False
        '
        'DataColumn124
        '
        Me.DataColumn124.ColumnName = "input_vat_id"
        Me.DataColumn124.DefaultValue = ""
        '
        'DataColumn125
        '
        Me.DataColumn125.ColumnName = "jbooks_id"
        Me.DataColumn125.DefaultValue = ""
        '
        'DataColumn126
        '
        Me.DataColumn126.ColumnName = "general_id"
        Me.DataColumn126.DefaultValue = ""
        '
        'DataColumn127
        '
        Me.DataColumn127.ColumnName = "currency_id"
        Me.DataColumn127.DefaultValue = ""
        '
        'DataColumn128
        '
        Me.DataColumn128.ColumnName = "exchange_rate"
        Me.DataColumn128.DataType = GetType(Decimal)
        Me.DataColumn128.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn129
        '
        Me.DataColumn129.ColumnName = "based_rate"
        Me.DataColumn129.DataType = GetType(Decimal)
        Me.DataColumn129.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn130
        '
        Me.DataColumn130.ColumnName = "offset_type"
        Me.DataColumn130.DefaultValue = ""
        '
        'DataColumn131
        '
        Me.DataColumn131.ColumnName = "vat_class"
        Me.DataColumn131.DefaultValue = ""
        '
        'DataColumn132
        '
        Me.DataColumn132.ColumnName = "vat_type"
        Me.DataColumn132.DefaultValue = ""
        '
        'DataColumn133
        '
        Me.DataColumn133.ColumnName = "vat_rate"
        Me.DataColumn133.DataType = GetType(Decimal)
        Me.DataColumn133.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn134
        '
        Me.DataColumn134.ColumnName = "gross_amount"
        Me.DataColumn134.DataType = GetType(Decimal)
        Me.DataColumn134.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn135
        '
        Me.DataColumn135.ColumnName = "vat_amount"
        Me.DataColumn135.DataType = GetType(Decimal)
        Me.DataColumn135.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn136
        '
        Me.DataColumn136.ColumnName = "net_amount"
        Me.DataColumn136.DataType = GetType(Decimal)
        Me.DataColumn136.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn137
        '
        Me.DataColumn137.ColumnName = "debit"
        Me.DataColumn137.DataType = GetType(Decimal)
        Me.DataColumn137.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn138
        '
        Me.DataColumn138.ColumnName = "credit"
        Me.DataColumn138.DataType = GetType(Decimal)
        Me.DataColumn138.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn139
        '
        Me.DataColumn139.ColumnName = "gross_amount_based"
        Me.DataColumn139.DataType = GetType(Decimal)
        Me.DataColumn139.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn140
        '
        Me.DataColumn140.ColumnName = "net_amount_based"
        Me.DataColumn140.DataType = GetType(Decimal)
        Me.DataColumn140.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn141
        '
        Me.DataColumn141.ColumnName = "vat_amount_based"
        Me.DataColumn141.DataType = GetType(Decimal)
        Me.DataColumn141.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn142
        '
        Me.DataColumn142.ColumnName = "debit_based"
        Me.DataColumn142.DataType = GetType(Decimal)
        Me.DataColumn142.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn143
        '
        Me.DataColumn143.ColumnName = "credit_amount_based"
        Me.DataColumn143.DataType = GetType(Decimal)
        Me.DataColumn143.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn144
        '
        Me.DataColumn144.ColumnName = "ref_input_vat_id"
        Me.DataColumn144.DefaultValue = ""
        '
        'DataColumn210
        '
        Me.DataColumn210.ColumnName = "ref_no"
        Me.DataColumn210.DefaultValue = ""
        '
        'DataColumn211
        '
        Me.DataColumn211.ColumnName = "general_code"
        Me.DataColumn211.DefaultValue = ""
        '
        'DataColumn212
        '
        Me.DataColumn212.ColumnName = "general_name"
        Me.DataColumn212.DefaultValue = ""
        '
        'DataColumn213
        '
        Me.DataColumn213.ColumnName = "currency_code"
        Me.DataColumn213.DefaultValue = ""
        '
        'DataColumn214
        '
        Me.DataColumn214.ColumnName = "currency_name"
        Me.DataColumn214.DefaultValue = ""
        '
        'DataColumn215
        '
        Me.DataColumn215.ColumnName = "tmp_amount"
        Me.DataColumn215.DataType = GetType(Decimal)
        Me.DataColumn215.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn216
        '
        Me.DataColumn216.ColumnName = "address"
        Me.DataColumn216.DefaultValue = ""
        '
        'DataColumn217
        '
        Me.DataColumn217.ColumnName = "tin"
        Me.DataColumn217.DefaultValue = ""
        '
        'DataColumn218
        '
        Me.DataColumn218.ColumnName = "isInputted"
        Me.DataColumn218.DataType = GetType(Boolean)
        Me.DataColumn218.DefaultValue = False
        '
        'DataColumn219
        '
        Me.DataColumn219.ColumnName = "deleted"
        Me.DataColumn219.DataType = GetType(Boolean)
        Me.DataColumn219.DefaultValue = False
        '
        'DataColumn220
        '
        Me.DataColumn220.ColumnName = "balance"
        Me.DataColumn220.DataType = GetType(Decimal)
        Me.DataColumn220.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "trans_no"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "trans_date"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "offset"
        Me.DataColumn8.DataType = GetType(Integer)
        Me.DataColumn8.DefaultValue = 0
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "minimum"
        Me.DataColumn9.DataType = GetType(Decimal)
        Me.DataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(832, 28)
        Me.Myformheader1.TabIndex = 117
        '
        'menuImport
        '
        Me.menuImport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImport, Me.btnExport})
        Me.menuImport.Name = "menuImport"
        Me.menuImport.Size = New System.Drawing.Size(160, 48)
        '
        'btnImport
        '
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(159, 22)
        Me.btnImport.Text = "Import"
        '
        'btnExport
        '
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(159, 22)
        Me.btnExport.Text = "Export Template"
        '
        'browseImport
        '
        Me.browseImport.ShowNewFolderButton = False
        '
        'border2
        '
        Me.border2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(22, 65)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(793, 2)
        Me.border2.TabIndex = 5
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(22, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(793, 2)
        Me.border1.TabIndex = 4
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'setupinputvat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 476)
        Me.ContextMenuStrip = Me.menuImport
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnhdr2)
        Me.Controls.Add(Me.btndet1)
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
        Me.Name = "setupinputvat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input VAT Details"
        CType(Me.dgdet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input_vat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.det.ResumeLayout(False)
        Me.det.PerformLayout()
        CType(Me.txtnetamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvatamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btndet2.ResumeLayout(False)
        CType(Me.txtgrossamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radvatclass.ResumeLayout(False)
        Me.radvatclass.PerformLayout()
        Me.radvattype.ResumeLayout(False)
        Me.radvattype.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btndet1.ResumeLayout(False)
        Me.btnhdr2.ResumeLayout(False)
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuImport.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgdet As System.Windows.Forms.DataGridView
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnnotsave As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents input_vat As System.Data.DataTable
    Friend WithEvents DataColumn97 As System.Data.DataColumn
    Friend WithEvents DataColumn98 As System.Data.DataColumn
    Friend WithEvents DataColumn99 As System.Data.DataColumn
    Friend WithEvents DataColumn100 As System.Data.DataColumn
    Friend WithEvents DataColumn101 As System.Data.DataColumn
    Friend WithEvents DataColumn102 As System.Data.DataColumn
    Friend WithEvents DataColumn103 As System.Data.DataColumn
    Friend WithEvents DataColumn104 As System.Data.DataColumn
    Friend WithEvents DataColumn105 As System.Data.DataColumn
    Friend WithEvents DataColumn106 As System.Data.DataColumn
    Friend WithEvents DataColumn107 As System.Data.DataColumn
    Friend WithEvents DataColumn108 As System.Data.DataColumn
    Friend WithEvents DataColumn109 As System.Data.DataColumn
    Friend WithEvents DataColumn110 As System.Data.DataColumn
    Friend WithEvents DataColumn111 As System.Data.DataColumn
    Friend WithEvents DataColumn112 As System.Data.DataColumn
    Friend WithEvents DataColumn113 As System.Data.DataColumn
    Friend WithEvents DataColumn114 As System.Data.DataColumn
    Friend WithEvents DataColumn115 As System.Data.DataColumn
    Friend WithEvents DataColumn116 As System.Data.DataColumn
    Friend WithEvents DataColumn117 As System.Data.DataColumn
    Friend WithEvents DataColumn157 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents det As System.Windows.Forms.Panel
    Friend WithEvents radvattype As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttin As user_control.textbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnundo As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtvatrate As user_control.textbox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtgeneralname As user_control.textbox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtgeneral As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdovatclass1 As user_control.rdo_button
    Friend WithEvents rdovatclass3 As user_control.rdo_button
    Friend WithEvents rdovatclass2 As user_control.rdo_button
    Friend WithEvents rdovattype2 As user_control.rdo_button
    Friend WithEvents rdovattype1 As user_control.rdo_button
    Friend WithEvents radvatclass As System.Windows.Forms.Panel
    Friend WithEvents btndet1 As System.Windows.Forms.Panel
    Friend WithEvents btndet2 As System.Windows.Forms.Panel
    Friend WithEvents btnhdr2 As System.Windows.Forms.Panel
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents DataColumn138 As System.Data.DataColumn
    Friend WithEvents DataColumn139 As System.Data.DataColumn
    Friend WithEvents DataColumn140 As System.Data.DataColumn
    Friend WithEvents DataColumn141 As System.Data.DataColumn
    Friend WithEvents DataColumn142 As System.Data.DataColumn
    Friend WithEvents DataColumn143 As System.Data.DataColumn
    Friend WithEvents DataColumn144 As System.Data.DataColumn
    Friend WithEvents DataColumn210 As System.Data.DataColumn
    Friend WithEvents DataColumn211 As System.Data.DataColumn
    Friend WithEvents DataColumn212 As System.Data.DataColumn
    Friend WithEvents DataColumn213 As System.Data.DataColumn
    Friend WithEvents DataColumn214 As System.Data.DataColumn
    Friend WithEvents DataColumn215 As System.Data.DataColumn
    Friend WithEvents DataColumn216 As System.Data.DataColumn
    Friend WithEvents DataColumn217 As System.Data.DataColumn
    Friend WithEvents DataColumn218 As System.Data.DataColumn
    Friend WithEvents DataColumn219 As System.Data.DataColumn
    Friend WithEvents DataColumn220 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents txt_jbooks_id As user_control.textbox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents txtgrossamount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtvatamount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtnetamount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents menuImport As Windows.Forms.ContextMenuStrip
    Friend WithEvents btnImport As Windows.Forms.ToolStripMenuItem
    Friend WithEvents browseImport As Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnExport As Windows.Forms.ToolStripMenuItem
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents input_vat_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tin As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vat_rate As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gross_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vat_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents net_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents offset As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minimum As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_code As Windows.Forms.DataGridViewTextBoxColumn
End Class
