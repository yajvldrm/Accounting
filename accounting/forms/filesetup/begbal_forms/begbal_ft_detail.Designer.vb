<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class begbal_ft_detail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(begbal_ft_detail))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.final_tax_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_unit_id = New user_control.textbox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_general_name = New user_control.textbox()
        Me.txt_final_tax_id = New user_control.textbox()
        Me.txt_based_rate = New user_control.textbox()
        Me.txt_exchange_rate = New user_control.textbox()
        Me.txt_currency_id = New user_control.textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tax_amount = New user_control.textbox()
        Me.txt_tax_rate = New user_control.textbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_general_id = New user_control.textbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_amount = New user_control.textbox()
        Me.txt_fs_final_tax_id = New user_control.textbox()
        Me.txt_ref_no = New user_control.textbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_total_amount = New user_control.textbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total_based = New user_control.textbox()
        Me.panel_hdr = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_department = New user_control.textbox()
        Me.txt_account_name = New user_control.textbox()
        Me.txt_project = New user_control.textbox()
        Me.txt_account = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_hdr.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(184, 282)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 222
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(12, 282)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 220
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(98, 282)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 221
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.final_tax_id, Me.ref_no, Me.general_name, Me.amount, Me.tax_amount, Me.status, Me.deleted, Me.minimum})
        Me.dgMain.Location = New System.Drawing.Point(12, 126)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(676, 150)
        Me.dgMain.TabIndex = 219
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Width = 30
        '
        'final_tax_id
        '
        Me.final_tax_id.DataPropertyName = "final_tax_id"
        Me.final_tax_id.HeaderText = "ID"
        Me.final_tax_id.Name = "final_tax_id"
        Me.final_tax_id.ReadOnly = True
        Me.final_tax_id.Visible = False
        '
        'ref_no
        '
        Me.ref_no.DataPropertyName = "ref_no"
        Me.ref_no.HeaderText = "Reference No."
        Me.ref_no.Name = "ref_no"
        Me.ref_no.ReadOnly = True
        Me.ref_no.Width = 150
        '
        'general_name
        '
        Me.general_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Supplier's Name"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "##,##0.00"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.amount.DefaultCellStyle = DataGridViewCellStyle1
        Me.amount.HeaderText = "Tax Base"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Width = 120
        '
        'tax_amount
        '
        Me.tax_amount.DataPropertyName = "tax_amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "##,##0.00"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.tax_amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.tax_amount.HeaderText = "Tax Required to be Withheld"
        Me.tax_amount.Name = "tax_amount"
        Me.tax_amount.ReadOnly = True
        Me.tax_amount.Width = 120
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Visible = False
        '
        'minimum
        '
        Me.minimum.DataPropertyName = "minimum"
        Me.minimum.HeaderText = "minimum"
        Me.minimum.Name = "minimum"
        Me.minimum.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_unit_id)
        Me.Panel2.Controls.Add(Me.lblUnit)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.txt_general_name)
        Me.Panel2.Controls.Add(Me.txt_final_tax_id)
        Me.Panel2.Controls.Add(Me.txt_based_rate)
        Me.Panel2.Controls.Add(Me.txt_exchange_rate)
        Me.Panel2.Controls.Add(Me.txt_currency_id)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_tax_amount)
        Me.Panel2.Controls.Add(Me.txt_tax_rate)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txt_general_id)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txt_amount)
        Me.Panel2.Controls.Add(Me.txt_fs_final_tax_id)
        Me.Panel2.Controls.Add(Me.txt_ref_no)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(12, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 157)
        Me.Panel2.TabIndex = 229
        Me.Panel2.Tag = "container"
        '
        'txt_unit_id
        '
        Me.txt_unit_id._Text = ""
        Me.txt_unit_id.AllowNegative = False
        Me.txt_unit_id.AlwaysDisable = False
        Me.txt_unit_id.AlwaysEnable = False
        Me.txt_unit_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_unit_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_unit_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_unit_id.DataSource = ""
        Me.txt_unit_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_unit_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_unit_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_unit_id.Enabled = False
        Me.txt_unit_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_unit_id.ispk = False
        Me.txt_unit_id.Location = New System.Drawing.Point(98, 121)
        Me.txt_unit_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_unit_id.MultiLine = False
        Me.txt_unit_id.Name = "txt_unit_id"
        Me.txt_unit_id.NoClear = False
        Me.txt_unit_id.NumberFormat = "@"
        Me.txt_unit_id.Required = False
        Me.txt_unit_id.RowData = Nothing
        Me.txt_unit_id.SelectionLength = 0
        Me.txt_unit_id.SelectionStart = 0
        Me.txt_unit_id.Size = New System.Drawing.Size(202, 20)
        Me.txt_unit_id.TabIndex = 325
        Me.txt_unit_id.TableData = Nothing
        Me.txt_unit_id.Tag = ""
        Me.txt_unit_id.TextSource = "unit_code"
        Me.txt_unit_id.UseSystemPasswordChar = False
        Me.txt_unit_id.Value = ""
        Me.txt_unit_id.ValueSource = "unit_id"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(66, 124)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblUnit.TabIndex = 324
        Me.lblUnit.Text = "Unit"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(302, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 222
        Me.PictureBox3.TabStop = False
        '
        'txt_general_name
        '
        Me.txt_general_name._Text = ""
        Me.txt_general_name.AllowNegative = False
        Me.txt_general_name.AlwaysDisable = True
        Me.txt_general_name.AlwaysEnable = False
        Me.txt_general_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_name.DataSource = ""
        Me.txt_general_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_name.Enabled = False
        Me.txt_general_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_name.ispk = False
        Me.txt_general_name.Location = New System.Drawing.Point(321, 37)
        Me.txt_general_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.MultiLine = False
        Me.txt_general_name.Name = "txt_general_name"
        Me.txt_general_name.NoClear = False
        Me.txt_general_name.NumberFormat = "@"
        Me.txt_general_name.Required = False
        Me.txt_general_name.RowData = Nothing
        Me.txt_general_name.SelectionLength = 0
        Me.txt_general_name.SelectionStart = 0
        Me.txt_general_name.Size = New System.Drawing.Size(344, 20)
        Me.txt_general_name.TabIndex = 4
        Me.txt_general_name.TableData = Nothing
        Me.txt_general_name.Tag = ""
        Me.txt_general_name.TextSource = ""
        Me.txt_general_name.UseSystemPasswordChar = False
        Me.txt_general_name.Value = ""
        Me.txt_general_name.ValueSource = ""
        '
        'txt_final_tax_id
        '
        Me.txt_final_tax_id._Text = ""
        Me.txt_final_tax_id.AllowNegative = False
        Me.txt_final_tax_id.AlwaysDisable = True
        Me.txt_final_tax_id.AlwaysEnable = False
        Me.txt_final_tax_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_final_tax_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_final_tax_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_final_tax_id.DataSource = ""
        Me.txt_final_tax_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_final_tax_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_final_tax_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_final_tax_id.Enabled = False
        Me.txt_final_tax_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_final_tax_id.ispk = False
        Me.txt_final_tax_id.Location = New System.Drawing.Point(463, 16)
        Me.txt_final_tax_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_final_tax_id.MultiLine = False
        Me.txt_final_tax_id.Name = "txt_final_tax_id"
        Me.txt_final_tax_id.NoClear = False
        Me.txt_final_tax_id.NumberFormat = "@"
        Me.txt_final_tax_id.Required = False
        Me.txt_final_tax_id.RowData = Nothing
        Me.txt_final_tax_id.SelectionLength = 0
        Me.txt_final_tax_id.SelectionStart = 0
        Me.txt_final_tax_id.Size = New System.Drawing.Size(202, 20)
        Me.txt_final_tax_id.TabIndex = 1
        Me.txt_final_tax_id.TableData = Nothing
        Me.txt_final_tax_id.TextSource = ""
        Me.txt_final_tax_id.UseSystemPasswordChar = False
        Me.txt_final_tax_id.Value = ""
        Me.txt_final_tax_id.ValueSource = ""
        Me.txt_final_tax_id.Visible = False
        '
        'txt_based_rate
        '
        Me.txt_based_rate._Text = ""
        Me.txt_based_rate.AllowNegative = False
        Me.txt_based_rate.AlwaysDisable = False
        Me.txt_based_rate.AlwaysEnable = False
        Me.txt_based_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_based_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_based_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_based_rate.DataSource = ""
        Me.txt_based_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_based_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_based_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_based_rate.Enabled = False
        Me.txt_based_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_based_rate.ispk = False
        Me.txt_based_rate.Location = New System.Drawing.Point(463, 79)
        Me.txt_based_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_based_rate.MultiLine = False
        Me.txt_based_rate.Name = "txt_based_rate"
        Me.txt_based_rate.NoClear = True
        Me.txt_based_rate.NumberFormat = "##,##0.00"
        Me.txt_based_rate.Required = False
        Me.txt_based_rate.RowData = Nothing
        Me.txt_based_rate.SelectionLength = 0
        Me.txt_based_rate.SelectionStart = 0
        Me.txt_based_rate.Size = New System.Drawing.Size(202, 20)
        Me.txt_based_rate.TabIndex = 8
        Me.txt_based_rate.TableData = Nothing
        Me.txt_based_rate.Tag = ""
        Me.txt_based_rate.TextSource = ""
        Me.txt_based_rate.UseSystemPasswordChar = False
        Me.txt_based_rate.Value = "0.00"
        Me.txt_based_rate.ValueSource = ""
        '
        'txt_exchange_rate
        '
        Me.txt_exchange_rate._Text = ""
        Me.txt_exchange_rate.AllowNegative = False
        Me.txt_exchange_rate.AlwaysDisable = False
        Me.txt_exchange_rate.AlwaysEnable = False
        Me.txt_exchange_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_exchange_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_exchange_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_exchange_rate.DataSource = ""
        Me.txt_exchange_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_exchange_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_exchange_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_exchange_rate.Enabled = False
        Me.txt_exchange_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_exchange_rate.ispk = False
        Me.txt_exchange_rate.Location = New System.Drawing.Point(98, 79)
        Me.txt_exchange_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_exchange_rate.MultiLine = False
        Me.txt_exchange_rate.Name = "txt_exchange_rate"
        Me.txt_exchange_rate.NoClear = True
        Me.txt_exchange_rate.NumberFormat = "##,##0.00"
        Me.txt_exchange_rate.Required = False
        Me.txt_exchange_rate.RowData = Nothing
        Me.txt_exchange_rate.SelectionLength = 0
        Me.txt_exchange_rate.SelectionStart = 0
        Me.txt_exchange_rate.Size = New System.Drawing.Size(202, 20)
        Me.txt_exchange_rate.TabIndex = 7
        Me.txt_exchange_rate.TableData = Nothing
        Me.txt_exchange_rate.Tag = ""
        Me.txt_exchange_rate.TextSource = ""
        Me.txt_exchange_rate.UseSystemPasswordChar = False
        Me.txt_exchange_rate.Value = "0.00"
        Me.txt_exchange_rate.ValueSource = ""
        '
        'txt_currency_id
        '
        Me.txt_currency_id._Text = ""
        Me.txt_currency_id.AllowNegative = False
        Me.txt_currency_id.AlwaysDisable = True
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.DataSource = ""
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.Enabled = False
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.ispk = False
        Me.txt_currency_id.Location = New System.Drawing.Point(463, 58)
        Me.txt_currency_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.MultiLine = False
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = True
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.SelectionLength = 0
        Me.txt_currency_id.SelectionStart = 0
        Me.txt_currency_id.Size = New System.Drawing.Size(202, 20)
        Me.txt_currency_id.TabIndex = 6
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.Tag = ""
        Me.txt_currency_id.TextSource = "currency_name"
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = "currency_id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(397, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Based Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Exchange Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Currency"
        '
        'txt_tax_amount
        '
        Me.txt_tax_amount._Text = ""
        Me.txt_tax_amount.AllowNegative = False
        Me.txt_tax_amount.AlwaysDisable = True
        Me.txt_tax_amount.AlwaysEnable = False
        Me.txt_tax_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tax_amount.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_tax_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tax_amount.DataSource = ""
        Me.txt_tax_amount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tax_amount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tax_amount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tax_amount.Enabled = False
        Me.txt_tax_amount.EnabledBackColor = System.Drawing.Color.White
        Me.txt_tax_amount.ispk = False
        Me.txt_tax_amount.Location = New System.Drawing.Point(463, 121)
        Me.txt_tax_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tax_amount.MultiLine = False
        Me.txt_tax_amount.Name = "txt_tax_amount"
        Me.txt_tax_amount.NoClear = False
        Me.txt_tax_amount.NumberFormat = "##,##0.00"
        Me.txt_tax_amount.Required = False
        Me.txt_tax_amount.RowData = Nothing
        Me.txt_tax_amount.SelectionLength = 0
        Me.txt_tax_amount.SelectionStart = 0
        Me.txt_tax_amount.Size = New System.Drawing.Size(202, 20)
        Me.txt_tax_amount.TabIndex = 11
        Me.txt_tax_amount.TableData = Nothing
        Me.txt_tax_amount.Tag = ""
        Me.txt_tax_amount.TextSource = ""
        Me.txt_tax_amount.UseSystemPasswordChar = False
        Me.txt_tax_amount.Value = "0.00"
        Me.txt_tax_amount.ValueSource = ""
        '
        'txt_tax_rate
        '
        Me.txt_tax_rate._Text = ""
        Me.txt_tax_rate.AllowNegative = False
        Me.txt_tax_rate.AlwaysDisable = True
        Me.txt_tax_rate.AlwaysEnable = False
        Me.txt_tax_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tax_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_tax_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tax_rate.DataSource = ""
        Me.txt_tax_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tax_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tax_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tax_rate.Enabled = False
        Me.txt_tax_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_tax_rate.ispk = False
        Me.txt_tax_rate.Location = New System.Drawing.Point(463, 100)
        Me.txt_tax_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tax_rate.MultiLine = False
        Me.txt_tax_rate.Name = "txt_tax_rate"
        Me.txt_tax_rate.NoClear = False
        Me.txt_tax_rate.NumberFormat = "##,##0.00"
        Me.txt_tax_rate.Required = False
        Me.txt_tax_rate.RowData = Nothing
        Me.txt_tax_rate.SelectionLength = 0
        Me.txt_tax_rate.SelectionStart = 0
        Me.txt_tax_rate.Size = New System.Drawing.Size(202, 20)
        Me.txt_tax_rate.TabIndex = 10
        Me.txt_tax_rate.TableData = Nothing
        Me.txt_tax_rate.Tag = ""
        Me.txt_tax_rate.TextSource = ""
        Me.txt_tax_rate.UseSystemPasswordChar = False
        Me.txt_tax_rate.Value = "0.00"
        Me.txt_tax_rate.ValueSource = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(317, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Tax Required to be Withheld"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(409, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Tax Rate"
        '
        'txt_general_id
        '
        Me.txt_general_id._Text = ""
        Me.txt_general_id.AllowNegative = False
        Me.txt_general_id.AlwaysDisable = False
        Me.txt_general_id.AlwaysEnable = False
        Me.txt_general_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.DataSource = ""
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.Enabled = False
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.ispk = False
        Me.txt_general_id.Location = New System.Drawing.Point(98, 37)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(202, 20)
        Me.txt_general_id.TabIndex = 3
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.Tag = ""
        Me.txt_general_id.TextSource = "general_name"
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = "general_id"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Supplier's Name"
        '
        'txt_amount
        '
        Me.txt_amount._Text = ""
        Me.txt_amount.AllowNegative = False
        Me.txt_amount.AlwaysDisable = False
        Me.txt_amount.AlwaysEnable = False
        Me.txt_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_amount.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amount.DataSource = ""
        Me.txt_amount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_amount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_amount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_amount.Enabled = False
        Me.txt_amount.EnabledBackColor = System.Drawing.Color.White
        Me.txt_amount.ispk = False
        Me.txt_amount.Location = New System.Drawing.Point(98, 100)
        Me.txt_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_amount.MultiLine = False
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.NoClear = False
        Me.txt_amount.NumberFormat = "##,##0.00"
        Me.txt_amount.Required = False
        Me.txt_amount.RowData = Nothing
        Me.txt_amount.SelectionLength = 0
        Me.txt_amount.SelectionStart = 0
        Me.txt_amount.Size = New System.Drawing.Size(202, 20)
        Me.txt_amount.TabIndex = 9
        Me.txt_amount.TableData = Nothing
        Me.txt_amount.Tag = ""
        Me.txt_amount.TextSource = ""
        Me.txt_amount.UseSystemPasswordChar = False
        Me.txt_amount.Value = "0.00"
        Me.txt_amount.ValueSource = ""
        '
        'txt_fs_final_tax_id
        '
        Me.txt_fs_final_tax_id._Text = ""
        Me.txt_fs_final_tax_id.AllowNegative = False
        Me.txt_fs_final_tax_id.AlwaysDisable = False
        Me.txt_fs_final_tax_id.AlwaysEnable = False
        Me.txt_fs_final_tax_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fs_final_tax_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_fs_final_tax_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fs_final_tax_id.DataSource = ""
        Me.txt_fs_final_tax_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fs_final_tax_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fs_final_tax_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_fs_final_tax_id.Enabled = False
        Me.txt_fs_final_tax_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_fs_final_tax_id.ispk = False
        Me.txt_fs_final_tax_id.Location = New System.Drawing.Point(98, 58)
        Me.txt_fs_final_tax_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fs_final_tax_id.MultiLine = False
        Me.txt_fs_final_tax_id.Name = "txt_fs_final_tax_id"
        Me.txt_fs_final_tax_id.NoClear = True
        Me.txt_fs_final_tax_id.NumberFormat = "@"
        Me.txt_fs_final_tax_id.Required = False
        Me.txt_fs_final_tax_id.RowData = Nothing
        Me.txt_fs_final_tax_id.SelectionLength = 0
        Me.txt_fs_final_tax_id.SelectionStart = 0
        Me.txt_fs_final_tax_id.Size = New System.Drawing.Size(202, 20)
        Me.txt_fs_final_tax_id.TabIndex = 5
        Me.txt_fs_final_tax_id.TableData = Nothing
        Me.txt_fs_final_tax_id.Tag = ""
        Me.txt_fs_final_tax_id.TextSource = "final_tax_code"
        Me.txt_fs_final_tax_id.UseSystemPasswordChar = False
        Me.txt_fs_final_tax_id.Value = ""
        Me.txt_fs_final_tax_id.ValueSource = "final_tax_id"
        '
        'txt_ref_no
        '
        Me.txt_ref_no._Text = ""
        Me.txt_ref_no.AllowNegative = False
        Me.txt_ref_no.AlwaysDisable = False
        Me.txt_ref_no.AlwaysEnable = False
        Me.txt_ref_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_ref_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ref_no.DataSource = ""
        Me.txt_ref_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ref_no.Enabled = False
        Me.txt_ref_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_ref_no.ispk = False
        Me.txt_ref_no.Location = New System.Drawing.Point(98, 16)
        Me.txt_ref_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_no.MultiLine = False
        Me.txt_ref_no.Name = "txt_ref_no"
        Me.txt_ref_no.NoClear = False
        Me.txt_ref_no.NumberFormat = "@"
        Me.txt_ref_no.Required = False
        Me.txt_ref_no.RowData = Nothing
        Me.txt_ref_no.SelectionLength = 0
        Me.txt_ref_no.SelectionStart = 0
        Me.txt_ref_no.Size = New System.Drawing.Size(202, 20)
        Me.txt_ref_no.TabIndex = 2
        Me.txt_ref_no.TableData = Nothing
        Me.txt_ref_no.Tag = "focus"
        Me.txt_ref_no.TextSource = ""
        Me.txt_ref_no.UseSystemPasswordChar = False
        Me.txt_ref_no.Value = ""
        Me.txt_ref_no.ValueSource = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tax Base"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Final Tax Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Reference No."
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 282)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 227
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(413, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 226
        Me.Label9.Text = "Total"
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 282)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 228
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Department"
        '
        'txt_total_amount
        '
        Me.txt_total_amount._Text = ""
        Me.txt_total_amount.AllowNegative = False
        Me.txt_total_amount.AlwaysDisable = True
        Me.txt_total_amount.AlwaysEnable = False
        Me.txt_total_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_amount.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_total_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_amount.DataSource = ""
        Me.txt_total_amount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_amount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_amount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total_amount.Enabled = False
        Me.txt_total_amount.EnabledBackColor = System.Drawing.Color.White
        Me.txt_total_amount.ispk = False
        Me.txt_total_amount.Location = New System.Drawing.Point(447, 282)
        Me.txt_total_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_amount.MultiLine = False
        Me.txt_total_amount.Name = "txt_total_amount"
        Me.txt_total_amount.NoClear = False
        Me.txt_total_amount.NumberFormat = "##,##0.00"
        Me.txt_total_amount.Required = False
        Me.txt_total_amount.RowData = Nothing
        Me.txt_total_amount.SelectionLength = 0
        Me.txt_total_amount.SelectionStart = 0
        Me.txt_total_amount.Size = New System.Drawing.Size(120, 23)
        Me.txt_total_amount.TabIndex = 225
        Me.txt_total_amount.TableData = Nothing
        Me.txt_total_amount.TextSource = ""
        Me.txt_total_amount.UseSystemPasswordChar = False
        Me.txt_total_amount.Value = "0.00"
        Me.txt_total_amount.ValueSource = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 25)
        Me.Label1.TabIndex = 217
        Me.Label1.Text = "Final Tax Beginning Balance - Details"
        '
        'txt_total_based
        '
        Me.txt_total_based._Text = ""
        Me.txt_total_based.AllowNegative = False
        Me.txt_total_based.AlwaysDisable = True
        Me.txt_total_based.AlwaysEnable = False
        Me.txt_total_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_total_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_based.DataSource = ""
        Me.txt_total_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total_based.Enabled = False
        Me.txt_total_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_total_based.ispk = False
        Me.txt_total_based.Location = New System.Drawing.Point(302, 282)
        Me.txt_total_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_based.MultiLine = False
        Me.txt_total_based.Name = "txt_total_based"
        Me.txt_total_based.NoClear = False
        Me.txt_total_based.NumberFormat = "##,##0.00"
        Me.txt_total_based.Required = False
        Me.txt_total_based.RowData = Nothing
        Me.txt_total_based.SelectionLength = 0
        Me.txt_total_based.SelectionStart = 0
        Me.txt_total_based.Size = New System.Drawing.Size(105, 23)
        Me.txt_total_based.TabIndex = 231
        Me.txt_total_based.TableData = Nothing
        Me.txt_total_based.TextSource = ""
        Me.txt_total_based.UseSystemPasswordChar = False
        Me.txt_total_based.Value = "0.00"
        Me.txt_total_based.ValueSource = ""
        Me.txt_total_based.Visible = False
        '
        'panel_hdr
        '
        Me.panel_hdr.Controls.Add(Me.PictureBox1)
        Me.panel_hdr.Controls.Add(Me.txt_department)
        Me.panel_hdr.Controls.Add(Me.txt_account_name)
        Me.panel_hdr.Controls.Add(Me.txt_project)
        Me.panel_hdr.Controls.Add(Me.txt_account)
        Me.panel_hdr.Controls.Add(Me.Label5)
        Me.panel_hdr.Controls.Add(Me.Label3)
        Me.panel_hdr.Controls.Add(Me.Label2)
        Me.panel_hdr.Location = New System.Drawing.Point(12, 70)
        Me.panel_hdr.Name = "panel_hdr"
        Me.panel_hdr.Size = New System.Drawing.Size(676, 50)
        Me.panel_hdr.TabIndex = 224
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(339, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 222
        Me.PictureBox1.TabStop = False
        '
        'txt_department
        '
        Me.txt_department._Text = ""
        Me.txt_department.AllowNegative = False
        Me.txt_department.AlwaysDisable = True
        Me.txt_department.AlwaysEnable = False
        Me.txt_department.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department.DataSource = ""
        Me.txt_department.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department.Enabled = False
        Me.txt_department.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department.ispk = False
        Me.txt_department.Location = New System.Drawing.Point(418, 27)
        Me.txt_department.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department.MultiLine = False
        Me.txt_department.Name = "txt_department"
        Me.txt_department.NoClear = False
        Me.txt_department.NumberFormat = "@"
        Me.txt_department.Required = False
        Me.txt_department.RowData = Nothing
        Me.txt_department.SelectionLength = 0
        Me.txt_department.SelectionStart = 0
        Me.txt_department.Size = New System.Drawing.Size(200, 20)
        Me.txt_department.TabIndex = 11
        Me.txt_department.TableData = Nothing
        Me.txt_department.Tag = ""
        Me.txt_department.TextSource = ""
        Me.txt_department.UseSystemPasswordChar = False
        Me.txt_department.Value = ""
        Me.txt_department.ValueSource = ""
        '
        'txt_account_name
        '
        Me.txt_account_name._Text = ""
        Me.txt_account_name.AllowNegative = False
        Me.txt_account_name.AlwaysDisable = True
        Me.txt_account_name.AlwaysEnable = False
        Me.txt_account_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_name.DataSource = ""
        Me.txt_account_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_name.Enabled = False
        Me.txt_account_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_name.ispk = False
        Me.txt_account_name.Location = New System.Drawing.Point(358, 3)
        Me.txt_account_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.MultiLine = False
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = False
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.SelectionLength = 0
        Me.txt_account_name.SelectionStart = 0
        Me.txt_account_name.Size = New System.Drawing.Size(260, 20)
        Me.txt_account_name.TabIndex = 10
        Me.txt_account_name.TableData = Nothing
        Me.txt_account_name.Tag = ""
        Me.txt_account_name.TextSource = ""
        Me.txt_account_name.UseSystemPasswordChar = False
        Me.txt_account_name.Value = ""
        Me.txt_account_name.ValueSource = ""
        '
        'txt_project
        '
        Me.txt_project._Text = ""
        Me.txt_project.AllowNegative = False
        Me.txt_project.AlwaysDisable = True
        Me.txt_project.AlwaysEnable = False
        Me.txt_project.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project.DataSource = ""
        Me.txt_project.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project.Enabled = False
        Me.txt_project.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project.ispk = False
        Me.txt_project.Location = New System.Drawing.Point(136, 27)
        Me.txt_project.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project.MultiLine = False
        Me.txt_project.Name = "txt_project"
        Me.txt_project.NoClear = False
        Me.txt_project.NumberFormat = "@"
        Me.txt_project.Required = False
        Me.txt_project.RowData = Nothing
        Me.txt_project.SelectionLength = 0
        Me.txt_project.SelectionStart = 0
        Me.txt_project.Size = New System.Drawing.Size(200, 20)
        Me.txt_project.TabIndex = 8
        Me.txt_project.TableData = Nothing
        Me.txt_project.Tag = ""
        Me.txt_project.TextSource = ""
        Me.txt_project.UseSystemPasswordChar = False
        Me.txt_project.Value = ""
        Me.txt_project.ValueSource = ""
        '
        'txt_account
        '
        Me.txt_account._Text = ""
        Me.txt_account.AllowNegative = False
        Me.txt_account.AlwaysDisable = True
        Me.txt_account.AlwaysEnable = False
        Me.txt_account.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account.DataSource = ""
        Me.txt_account.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account.Enabled = False
        Me.txt_account.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account.ispk = False
        Me.txt_account.Location = New System.Drawing.Point(136, 3)
        Me.txt_account.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account.MultiLine = False
        Me.txt_account.Name = "txt_account"
        Me.txt_account.NoClear = False
        Me.txt_account.NumberFormat = "@"
        Me.txt_account.Required = False
        Me.txt_account.RowData = Nothing
        Me.txt_account.SelectionLength = 0
        Me.txt_account.SelectionStart = 0
        Me.txt_account.Size = New System.Drawing.Size(200, 20)
        Me.txt_account.TabIndex = 7
        Me.txt_account.TableData = Nothing
        Me.txt_account.Tag = ""
        Me.txt_account.TextSource = ""
        Me.txt_account.UseSystemPasswordChar = False
        Me.txt_account.Value = ""
        Me.txt_account.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Code"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(700, 28)
        Me.Myformheader1.TabIndex = 232
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(15, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(670, 2)
        Me.border1.TabIndex = 218
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.ForeColor = System.Drawing.Color.White
        Me.btnViewDetails.Location = New System.Drawing.Point(573, 282)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(115, 24)
        Me.btnViewDetails.TabIndex = 233
        Me.btnViewDetails.Tag = "btnViewDetails"
        Me.btnViewDetails.Text = "F6 View Schedule"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'begbal_ft_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 480)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_total_amount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_total_based)
        Me.Controls.Add(Me.panel_hdr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "begbal_ft_detail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Tax Beginning balance - Details"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_hdr.ResumeLayout(False)
        Me.panel_hdr.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_tax_amount As user_control.textbox
    Friend WithEvents txt_tax_rate As user_control.textbox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As user_control.textbox
    Friend WithEvents txt_fs_final_tax_id As user_control.textbox
    Friend WithEvents txt_ref_no As user_control.textbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_total_amount As user_control.textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_total_based As user_control.textbox
    Friend WithEvents panel_hdr As System.Windows.Forms.Panel
    Friend WithEvents txt_department As user_control.textbox
    Friend WithEvents txt_account_name As user_control.textbox
    Friend WithEvents txt_project As user_control.textbox
    Friend WithEvents txt_account As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_based_rate As user_control.textbox
    Friend WithEvents txt_exchange_rate As user_control.textbox
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_final_tax_id As user_control.textbox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_general_name As user_control.textbox
    Friend WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents final_tax_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tax_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents minimum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_unit_id As user_control.textbox
    Friend WithEvents lblUnit As Windows.Forms.Label
End Class
