<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class begbal_fa_detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(begbal_fa_detail))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_hdr = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_department = New user_control.textbox()
        Me.txt_account_name = New user_control.textbox()
        Me.txt_project = New user_control.textbox()
        Me.txt_account = New user_control.textbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.fixed_asset_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useful_life = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_unit_id = New user_control.textbox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.txt_amount_based = New user_control.textbox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_salvage_value_based = New user_control.textbox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_net_book_value_based = New user_control.textbox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_salvage_value = New user_control.textbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_debit_based = New user_control.textbox()
        Me.txt_net_book_value = New user_control.textbox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_fixed_asset_id = New user_control.textbox()
        Me.txt_based_rate = New user_control.textbox()
        Me.txt_exchange_rate = New user_control.textbox()
        Me.txt_currency_id = New user_control.textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_date_start = New System.Windows.Forms.DateTimePicker()
        Me.txt_date_acquired = New System.Windows.Forms.DateTimePicker()
        Me.txt_historical_rate = New user_control.textbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_amount = New user_control.textbox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_quantity = New user_control.textbox()
        Me.txt_useful_life = New user_control.textbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_description = New user_control.textbox()
        Me.txt_asset_code = New user_control.textbox()
        Me.txt_ref_no = New user_control.textbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.txt_total_amount = New user_control.textbox()
        Me.txt_total_based = New user_control.textbox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.panel_hdr.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 25)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Fixed Assets Beginning Balance - Details"
        '
        'panel_hdr
        '
        Me.panel_hdr.Controls.Add(Me.PictureBox2)
        Me.panel_hdr.Controls.Add(Me.txt_department)
        Me.panel_hdr.Controls.Add(Me.txt_account_name)
        Me.panel_hdr.Controls.Add(Me.txt_project)
        Me.panel_hdr.Controls.Add(Me.txt_account)
        Me.panel_hdr.Controls.Add(Me.Label5)
        Me.panel_hdr.Controls.Add(Me.Label3)
        Me.panel_hdr.Controls.Add(Me.Label2)
        Me.panel_hdr.Location = New System.Drawing.Point(12, 70)
        Me.panel_hdr.Name = "panel_hdr"
        Me.panel_hdr.Size = New System.Drawing.Size(782, 50)
        Me.panel_hdr.TabIndex = 209
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(335, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 222
        Me.PictureBox2.TabStop = False
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
        Me.txt_department.Location = New System.Drawing.Point(419, 27)
        Me.txt_department.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department.MultiLine = False
        Me.txt_department.Name = "txt_department"
        Me.txt_department.NoClear = False
        Me.txt_department.NumberFormat = "@"
        Me.txt_department.Required = False
        Me.txt_department.RowData = Nothing
        Me.txt_department.SelectionLength = 0
        Me.txt_department.SelectionStart = 0
        Me.txt_department.Size = New System.Drawing.Size(359, 20)
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
        Me.txt_account_name.Location = New System.Drawing.Point(354, 3)
        Me.txt_account_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.MultiLine = False
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = False
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.SelectionLength = 0
        Me.txt_account_name.SelectionStart = 0
        Me.txt_account_name.Size = New System.Drawing.Size(424, 20)
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
        Me.txt_project.Location = New System.Drawing.Point(97, 27)
        Me.txt_project.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project.MultiLine = False
        Me.txt_project.Name = "txt_project"
        Me.txt_project.NoClear = False
        Me.txt_project.NumberFormat = "@"
        Me.txt_project.Required = False
        Me.txt_project.RowData = Nothing
        Me.txt_project.SelectionLength = 0
        Me.txt_project.SelectionStart = 0
        Me.txt_project.Size = New System.Drawing.Size(234, 20)
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
        Me.txt_account.Location = New System.Drawing.Point(97, 3)
        Me.txt_account.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account.MultiLine = False
        Me.txt_account.Name = "txt_account"
        Me.txt_account.NoClear = False
        Me.txt_account.NumberFormat = "@"
        Me.txt_account.Required = False
        Me.txt_account.RowData = Nothing
        Me.txt_account.SelectionLength = 0
        Me.txt_account.SelectionStart = 0
        Me.txt_account.Size = New System.Drawing.Size(234, 20)
        Me.txt_account.TabIndex = 7
        Me.txt_account.TableData = Nothing
        Me.txt_account.Tag = ""
        Me.txt_account.TextSource = ""
        Me.txt_account.UseSystemPasswordChar = False
        Me.txt_account.Value = ""
        Me.txt_account.ValueSource = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(519, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 211
        Me.Label9.Text = "Total"
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
        Me.btnRemove.TabIndex = 207
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
        Me.btnInsert.TabIndex = 205
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
        Me.btnUpdate.TabIndex = 206
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
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.fixed_asset_id, Me.ref_no, Me.description, Me.amount, Me.useful_life, Me.status, Me.deleted, Me.minimum})
        Me.dgMain.Location = New System.Drawing.Point(12, 126)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(782, 150)
        Me.dgMain.TabIndex = 204
        Me.dgMain.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Width = 30
        '
        'fixed_asset_id
        '
        Me.fixed_asset_id.DataPropertyName = "fixed_asset_id"
        Me.fixed_asset_id.HeaderText = "ID"
        Me.fixed_asset_id.Name = "fixed_asset_id"
        Me.fixed_asset_id.Visible = False
        '
        'ref_no
        '
        Me.ref_no.DataPropertyName = "ref_no"
        Me.ref_no.HeaderText = "Reference No."
        Me.ref_no.Name = "ref_no"
        Me.ref_no.ReadOnly = True
        Me.ref_no.Width = 150
        '
        'description
        '
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "Item Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Width = 200
        '
        'amount
        '
        Me.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.amount.DataPropertyName = "amount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "##,##0.00"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.amount.DefaultCellStyle = DataGridViewCellStyle1
        Me.amount.HeaderText = "Aquisition Cost"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'useful_life
        '
        Me.useful_life.DataPropertyName = "useful_life"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "##,##0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.useful_life.DefaultCellStyle = DataGridViewCellStyle2
        Me.useful_life.HeaderText = "Estimated Ueful Life"
        Me.useful_life.Name = "useful_life"
        Me.useful_life.ReadOnly = True
        Me.useful_life.Width = 200
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
        Me.Panel2.Controls.Add(Me.txt_amount_based)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.txt_salvage_value_based)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.txt_net_book_value_based)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.txt_salvage_value)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.txt_debit_based)
        Me.Panel2.Controls.Add(Me.txt_net_book_value)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.txt_fixed_asset_id)
        Me.Panel2.Controls.Add(Me.txt_based_rate)
        Me.Panel2.Controls.Add(Me.txt_exchange_rate)
        Me.Panel2.Controls.Add(Me.txt_currency_id)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_date_start)
        Me.Panel2.Controls.Add(Me.txt_date_acquired)
        Me.Panel2.Controls.Add(Me.txt_historical_rate)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txt_amount)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txt_quantity)
        Me.Panel2.Controls.Add(Me.txt_useful_life)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txt_description)
        Me.Panel2.Controls.Add(Me.txt_asset_code)
        Me.Panel2.Controls.Add(Me.txt_ref_no)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(12, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 170)
        Me.Panel2.TabIndex = 214
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
        Me.txt_unit_id.Location = New System.Drawing.Point(629, 139)
        Me.txt_unit_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_unit_id.MultiLine = False
        Me.txt_unit_id.Name = "txt_unit_id"
        Me.txt_unit_id.NoClear = False
        Me.txt_unit_id.NumberFormat = "@"
        Me.txt_unit_id.Required = False
        Me.txt_unit_id.RowData = Nothing
        Me.txt_unit_id.SelectionLength = 0
        Me.txt_unit_id.SelectionStart = 0
        Me.txt_unit_id.Size = New System.Drawing.Size(151, 20)
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
        Me.lblUnit.Location = New System.Drawing.Point(597, 142)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblUnit.TabIndex = 324
        Me.lblUnit.Text = "Unit"
        '
        'txt_amount_based
        '
        Me.txt_amount_based._Text = ""
        Me.txt_amount_based.AllowNegative = False
        Me.txt_amount_based.AlwaysDisable = True
        Me.txt_amount_based.AlwaysEnable = False
        Me.txt_amount_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_amount_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_amount_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amount_based.DataSource = ""
        Me.txt_amount_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_amount_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_amount_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_amount_based.Enabled = False
        Me.txt_amount_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_amount_based.ispk = False
        Me.txt_amount_based.Location = New System.Drawing.Point(629, 55)
        Me.txt_amount_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_amount_based.MultiLine = False
        Me.txt_amount_based.Name = "txt_amount_based"
        Me.txt_amount_based.NoClear = False
        Me.txt_amount_based.NumberFormat = "##,##0.00"
        Me.txt_amount_based.Required = False
        Me.txt_amount_based.RowData = Nothing
        Me.txt_amount_based.SelectionLength = 0
        Me.txt_amount_based.SelectionStart = 0
        Me.txt_amount_based.Size = New System.Drawing.Size(150, 20)
        Me.txt_amount_based.TabIndex = 9
        Me.txt_amount_based.TableData = Nothing
        Me.txt_amount_based.Tag = ""
        Me.txt_amount_based.TextSource = ""
        Me.txt_amount_based.UseSystemPasswordChar = False
        Me.txt_amount_based.Value = "0.00"
        Me.txt_amount_based.ValueSource = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(517, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 13)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "Aquisition Cost Based"
        '
        'txt_salvage_value_based
        '
        Me.txt_salvage_value_based._Text = ""
        Me.txt_salvage_value_based.AllowNegative = False
        Me.txt_salvage_value_based.AlwaysDisable = True
        Me.txt_salvage_value_based.AlwaysEnable = False
        Me.txt_salvage_value_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_salvage_value_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_salvage_value_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_salvage_value_based.DataSource = ""
        Me.txt_salvage_value_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_salvage_value_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_salvage_value_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_salvage_value_based.Enabled = False
        Me.txt_salvage_value_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_salvage_value_based.ispk = False
        Me.txt_salvage_value_based.Location = New System.Drawing.Point(629, 76)
        Me.txt_salvage_value_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_salvage_value_based.MultiLine = False
        Me.txt_salvage_value_based.Name = "txt_salvage_value_based"
        Me.txt_salvage_value_based.NoClear = False
        Me.txt_salvage_value_based.NumberFormat = "##,##0.00"
        Me.txt_salvage_value_based.Required = False
        Me.txt_salvage_value_based.RowData = Nothing
        Me.txt_salvage_value_based.SelectionLength = 0
        Me.txt_salvage_value_based.SelectionStart = 0
        Me.txt_salvage_value_based.Size = New System.Drawing.Size(150, 20)
        Me.txt_salvage_value_based.TabIndex = 12
        Me.txt_salvage_value_based.TableData = Nothing
        Me.txt_salvage_value_based.Tag = ""
        Me.txt_salvage_value_based.TextSource = ""
        Me.txt_salvage_value_based.UseSystemPasswordChar = False
        Me.txt_salvage_value_based.Value = "0.00"
        Me.txt_salvage_value_based.ValueSource = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(517, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 13)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Salvage Value Based"
        '
        'txt_net_book_value_based
        '
        Me.txt_net_book_value_based._Text = ""
        Me.txt_net_book_value_based.AllowNegative = False
        Me.txt_net_book_value_based.AlwaysDisable = True
        Me.txt_net_book_value_based.AlwaysEnable = False
        Me.txt_net_book_value_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_net_book_value_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_net_book_value_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_net_book_value_based.DataSource = ""
        Me.txt_net_book_value_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_net_book_value_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_net_book_value_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_net_book_value_based.Enabled = False
        Me.txt_net_book_value_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_net_book_value_based.ispk = False
        Me.txt_net_book_value_based.Location = New System.Drawing.Point(629, 97)
        Me.txt_net_book_value_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_net_book_value_based.MultiLine = False
        Me.txt_net_book_value_based.Name = "txt_net_book_value_based"
        Me.txt_net_book_value_based.NoClear = False
        Me.txt_net_book_value_based.NumberFormat = "##,##0.00"
        Me.txt_net_book_value_based.Required = False
        Me.txt_net_book_value_based.RowData = Nothing
        Me.txt_net_book_value_based.SelectionLength = 0
        Me.txt_net_book_value_based.SelectionStart = 0
        Me.txt_net_book_value_based.Size = New System.Drawing.Size(150, 20)
        Me.txt_net_book_value_based.TabIndex = 15
        Me.txt_net_book_value_based.TableData = Nothing
        Me.txt_net_book_value_based.Tag = ""
        Me.txt_net_book_value_based.TextSource = ""
        Me.txt_net_book_value_based.UseSystemPasswordChar = False
        Me.txt_net_book_value_based.Value = "0.00"
        Me.txt_net_book_value_based.ValueSource = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(511, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 13)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Net Book Value Based"
        '
        'txt_salvage_value
        '
        Me.txt_salvage_value._Text = ""
        Me.txt_salvage_value.AllowNegative = False
        Me.txt_salvage_value.AlwaysDisable = False
        Me.txt_salvage_value.AlwaysEnable = False
        Me.txt_salvage_value.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_salvage_value.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_salvage_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_salvage_value.DataSource = ""
        Me.txt_salvage_value.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_salvage_value.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_salvage_value.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_salvage_value.Enabled = False
        Me.txt_salvage_value.EnabledBackColor = System.Drawing.Color.White
        Me.txt_salvage_value.ispk = False
        Me.txt_salvage_value.Location = New System.Drawing.Point(90, 97)
        Me.txt_salvage_value.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_salvage_value.MultiLine = False
        Me.txt_salvage_value.Name = "txt_salvage_value"
        Me.txt_salvage_value.NoClear = False
        Me.txt_salvage_value.NumberFormat = "##,##0.00"
        Me.txt_salvage_value.Required = False
        Me.txt_salvage_value.RowData = Nothing
        Me.txt_salvage_value.SelectionLength = 0
        Me.txt_salvage_value.SelectionStart = 0
        Me.txt_salvage_value.Size = New System.Drawing.Size(150, 20)
        Me.txt_salvage_value.TabIndex = 13
        Me.txt_salvage_value.TableData = Nothing
        Me.txt_salvage_value.Tag = ""
        Me.txt_salvage_value.TextSource = ""
        Me.txt_salvage_value.UseSystemPasswordChar = False
        Me.txt_salvage_value.Value = "0.00"
        Me.txt_salvage_value.ValueSource = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 13)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Salvage Value"
        '
        'txt_debit_based
        '
        Me.txt_debit_based._Text = ""
        Me.txt_debit_based.AllowNegative = False
        Me.txt_debit_based.AlwaysDisable = True
        Me.txt_debit_based.AlwaysEnable = False
        Me.txt_debit_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_debit_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_debit_based.DataSource = ""
        Me.txt_debit_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_debit_based.Enabled = False
        Me.txt_debit_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_debit_based.ispk = False
        Me.txt_debit_based.Location = New System.Drawing.Point(629, 118)
        Me.txt_debit_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit_based.MultiLine = False
        Me.txt_debit_based.Name = "txt_debit_based"
        Me.txt_debit_based.NoClear = False
        Me.txt_debit_based.NumberFormat = "##,##0.00"
        Me.txt_debit_based.Required = False
        Me.txt_debit_based.RowData = Nothing
        Me.txt_debit_based.SelectionLength = 0
        Me.txt_debit_based.SelectionStart = 0
        Me.txt_debit_based.Size = New System.Drawing.Size(150, 20)
        Me.txt_debit_based.TabIndex = 18
        Me.txt_debit_based.TableData = Nothing
        Me.txt_debit_based.Tag = ""
        Me.txt_debit_based.TextSource = ""
        Me.txt_debit_based.UseSystemPasswordChar = False
        Me.txt_debit_based.Value = "0.00"
        Me.txt_debit_based.ValueSource = ""
        '
        'txt_net_book_value
        '
        Me.txt_net_book_value._Text = ""
        Me.txt_net_book_value.AllowNegative = False
        Me.txt_net_book_value.AlwaysDisable = False
        Me.txt_net_book_value.AlwaysEnable = False
        Me.txt_net_book_value.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_net_book_value.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_net_book_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_net_book_value.DataSource = ""
        Me.txt_net_book_value.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_net_book_value.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_net_book_value.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_net_book_value.Enabled = False
        Me.txt_net_book_value.EnabledBackColor = System.Drawing.Color.White
        Me.txt_net_book_value.ispk = False
        Me.txt_net_book_value.Location = New System.Drawing.Point(355, 97)
        Me.txt_net_book_value.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_net_book_value.MultiLine = False
        Me.txt_net_book_value.Name = "txt_net_book_value"
        Me.txt_net_book_value.NoClear = False
        Me.txt_net_book_value.NumberFormat = "##,##0.00"
        Me.txt_net_book_value.Required = False
        Me.txt_net_book_value.RowData = Nothing
        Me.txt_net_book_value.SelectionLength = 0
        Me.txt_net_book_value.SelectionStart = 0
        Me.txt_net_book_value.Size = New System.Drawing.Size(150, 20)
        Me.txt_net_book_value.TabIndex = 14
        Me.txt_net_book_value.TableData = Nothing
        Me.txt_net_book_value.Tag = ""
        Me.txt_net_book_value.TextSource = ""
        Me.txt_net_book_value.UseSystemPasswordChar = False
        Me.txt_net_book_value.Value = "0.00"
        Me.txt_net_book_value.ValueSource = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(561, 121)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Debit Based"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(270, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Net Book Value"
        '
        'txt_fixed_asset_id
        '
        Me.txt_fixed_asset_id._Text = ""
        Me.txt_fixed_asset_id.AllowNegative = False
        Me.txt_fixed_asset_id.AlwaysDisable = True
        Me.txt_fixed_asset_id.AlwaysEnable = False
        Me.txt_fixed_asset_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fixed_asset_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_fixed_asset_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fixed_asset_id.DataSource = ""
        Me.txt_fixed_asset_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fixed_asset_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fixed_asset_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_fixed_asset_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_fixed_asset_id.ispk = False
        Me.txt_fixed_asset_id.Location = New System.Drawing.Point(355, 12)
        Me.txt_fixed_asset_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fixed_asset_id.MultiLine = False
        Me.txt_fixed_asset_id.Name = "txt_fixed_asset_id"
        Me.txt_fixed_asset_id.NoClear = False
        Me.txt_fixed_asset_id.NumberFormat = "@"
        Me.txt_fixed_asset_id.Required = False
        Me.txt_fixed_asset_id.RowData = Nothing
        Me.txt_fixed_asset_id.SelectionLength = 0
        Me.txt_fixed_asset_id.SelectionStart = 0
        Me.txt_fixed_asset_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_fixed_asset_id.TabIndex = 1
        Me.txt_fixed_asset_id.TableData = Nothing
        Me.txt_fixed_asset_id.TextSource = ""
        Me.txt_fixed_asset_id.UseSystemPasswordChar = False
        Me.txt_fixed_asset_id.Value = ""
        Me.txt_fixed_asset_id.ValueSource = ""
        Me.txt_fixed_asset_id.Visible = False
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
        Me.txt_based_rate.Location = New System.Drawing.Point(629, 33)
        Me.txt_based_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_based_rate.MultiLine = False
        Me.txt_based_rate.Name = "txt_based_rate"
        Me.txt_based_rate.NoClear = True
        Me.txt_based_rate.NumberFormat = "##,##0.00"
        Me.txt_based_rate.Required = False
        Me.txt_based_rate.RowData = Nothing
        Me.txt_based_rate.SelectionLength = 0
        Me.txt_based_rate.SelectionStart = 0
        Me.txt_based_rate.Size = New System.Drawing.Size(150, 20)
        Me.txt_based_rate.TabIndex = 6
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
        Me.txt_exchange_rate.Location = New System.Drawing.Point(355, 33)
        Me.txt_exchange_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_exchange_rate.MultiLine = False
        Me.txt_exchange_rate.Name = "txt_exchange_rate"
        Me.txt_exchange_rate.NoClear = True
        Me.txt_exchange_rate.NumberFormat = "##,##0.00"
        Me.txt_exchange_rate.Required = False
        Me.txt_exchange_rate.RowData = Nothing
        Me.txt_exchange_rate.SelectionLength = 0
        Me.txt_exchange_rate.SelectionStart = 0
        Me.txt_exchange_rate.Size = New System.Drawing.Size(150, 20)
        Me.txt_exchange_rate.TabIndex = 5
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
        Me.txt_currency_id.Location = New System.Drawing.Point(90, 33)
        Me.txt_currency_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.MultiLine = False
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = True
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.SelectionLength = 0
        Me.txt_currency_id.SelectionStart = 0
        Me.txt_currency_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_currency_id.TabIndex = 4
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
        Me.Label7.Location = New System.Drawing.Point(563, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Based Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(271, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Exchange Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Currency"
        '
        'txt_date_start
        '
        Me.txt_date_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_start.Location = New System.Drawing.Point(355, 55)
        Me.txt_date_start.Name = "txt_date_start"
        Me.txt_date_start.Size = New System.Drawing.Size(150, 20)
        Me.txt_date_start.TabIndex = 8
        '
        'txt_date_acquired
        '
        Me.txt_date_acquired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_acquired.Location = New System.Drawing.Point(90, 54)
        Me.txt_date_acquired.Name = "txt_date_acquired"
        Me.txt_date_acquired.Size = New System.Drawing.Size(150, 20)
        Me.txt_date_acquired.TabIndex = 7
        '
        'txt_historical_rate
        '
        Me.txt_historical_rate._Text = ""
        Me.txt_historical_rate.AllowNegative = False
        Me.txt_historical_rate.AlwaysDisable = False
        Me.txt_historical_rate.AlwaysEnable = False
        Me.txt_historical_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_historical_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_historical_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_historical_rate.DataSource = ""
        Me.txt_historical_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_historical_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_historical_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_historical_rate.Enabled = False
        Me.txt_historical_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_historical_rate.ispk = False
        Me.txt_historical_rate.Location = New System.Drawing.Point(629, 12)
        Me.txt_historical_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_historical_rate.MultiLine = False
        Me.txt_historical_rate.Name = "txt_historical_rate"
        Me.txt_historical_rate.NoClear = False
        Me.txt_historical_rate.NumberFormat = "##,##0.00"
        Me.txt_historical_rate.Required = False
        Me.txt_historical_rate.RowData = Nothing
        Me.txt_historical_rate.SelectionLength = 0
        Me.txt_historical_rate.SelectionStart = 0
        Me.txt_historical_rate.Size = New System.Drawing.Size(150, 20)
        Me.txt_historical_rate.TabIndex = 3
        Me.txt_historical_rate.TableData = Nothing
        Me.txt_historical_rate.Tag = ""
        Me.txt_historical_rate.TextSource = ""
        Me.txt_historical_rate.UseSystemPasswordChar = False
        Me.txt_historical_rate.Value = "0.00"
        Me.txt_historical_rate.ValueSource = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(550, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Historical Rate"
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
        Me.txt_amount.Location = New System.Drawing.Point(90, 76)
        Me.txt_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_amount.MultiLine = False
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.NoClear = False
        Me.txt_amount.NumberFormat = "##,##0.00"
        Me.txt_amount.Required = False
        Me.txt_amount.RowData = Nothing
        Me.txt_amount.SelectionLength = 0
        Me.txt_amount.SelectionStart = 0
        Me.txt_amount.Size = New System.Drawing.Size(150, 20)
        Me.txt_amount.TabIndex = 10
        Me.txt_amount.TableData = Nothing
        Me.txt_amount.Tag = ""
        Me.txt_amount.TextSource = ""
        Me.txt_amount.UseSystemPasswordChar = False
        Me.txt_amount.Value = "0.00"
        Me.txt_amount.ValueSource = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Aquisition Cost"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(270, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Start of Lapsing"
        '
        'txt_quantity
        '
        Me.txt_quantity._Text = ""
        Me.txt_quantity.AllowNegative = False
        Me.txt_quantity.AlwaysDisable = False
        Me.txt_quantity.AlwaysEnable = False
        Me.txt_quantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quantity.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_quantity.DataSource = ""
        Me.txt_quantity.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_quantity.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_quantity.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_quantity.Enabled = False
        Me.txt_quantity.EnabledBackColor = System.Drawing.Color.White
        Me.txt_quantity.ispk = False
        Me.txt_quantity.Location = New System.Drawing.Point(355, 118)
        Me.txt_quantity.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_quantity.MultiLine = False
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.NoClear = False
        Me.txt_quantity.NumberFormat = "##,##0.00"
        Me.txt_quantity.Required = False
        Me.txt_quantity.RowData = Nothing
        Me.txt_quantity.SelectionLength = 0
        Me.txt_quantity.SelectionStart = 0
        Me.txt_quantity.Size = New System.Drawing.Size(150, 20)
        Me.txt_quantity.TabIndex = 17
        Me.txt_quantity.TableData = Nothing
        Me.txt_quantity.Tag = ""
        Me.txt_quantity.TextSource = ""
        Me.txt_quantity.UseSystemPasswordChar = False
        Me.txt_quantity.Value = "0.00"
        Me.txt_quantity.ValueSource = ""
        '
        'txt_useful_life
        '
        Me.txt_useful_life._Text = ""
        Me.txt_useful_life.AllowNegative = False
        Me.txt_useful_life.AlwaysDisable = False
        Me.txt_useful_life.AlwaysEnable = False
        Me.txt_useful_life.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_useful_life.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_useful_life.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_useful_life.DataSource = ""
        Me.txt_useful_life.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_useful_life.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_useful_life.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_useful_life.Enabled = False
        Me.txt_useful_life.EnabledBackColor = System.Drawing.Color.White
        Me.txt_useful_life.ispk = False
        Me.txt_useful_life.Location = New System.Drawing.Point(355, 76)
        Me.txt_useful_life.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_useful_life.MultiLine = False
        Me.txt_useful_life.Name = "txt_useful_life"
        Me.txt_useful_life.NoClear = False
        Me.txt_useful_life.NumberFormat = "##,##0.00"
        Me.txt_useful_life.Required = False
        Me.txt_useful_life.RowData = Nothing
        Me.txt_useful_life.SelectionLength = 0
        Me.txt_useful_life.SelectionStart = 0
        Me.txt_useful_life.Size = New System.Drawing.Size(150, 20)
        Me.txt_useful_life.TabIndex = 11
        Me.txt_useful_life.TableData = Nothing
        Me.txt_useful_life.Tag = ""
        Me.txt_useful_life.TextSource = ""
        Me.txt_useful_life.UseSystemPasswordChar = False
        Me.txt_useful_life.Value = "0.00"
        Me.txt_useful_life.ValueSource = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(289, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "No. of Units"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(246, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Estimated Useful Life"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Date Acquired"
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
        Me.txt_description.Location = New System.Drawing.Point(90, 139)
        Me.txt_description.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_description.MultiLine = False
        Me.txt_description.Name = "txt_description"
        Me.txt_description.NoClear = False
        Me.txt_description.NumberFormat = "@"
        Me.txt_description.Required = False
        Me.txt_description.RowData = Nothing
        Me.txt_description.SelectionLength = 0
        Me.txt_description.SelectionStart = 0
        Me.txt_description.Size = New System.Drawing.Size(415, 20)
        Me.txt_description.TabIndex = 19
        Me.txt_description.TableData = Nothing
        Me.txt_description.Tag = ""
        Me.txt_description.TextSource = ""
        Me.txt_description.UseSystemPasswordChar = False
        Me.txt_description.Value = ""
        Me.txt_description.ValueSource = ""
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
        Me.txt_asset_code.Location = New System.Drawing.Point(90, 118)
        Me.txt_asset_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_asset_code.MultiLine = False
        Me.txt_asset_code.Name = "txt_asset_code"
        Me.txt_asset_code.NoClear = False
        Me.txt_asset_code.NumberFormat = "@"
        Me.txt_asset_code.Required = False
        Me.txt_asset_code.RowData = Nothing
        Me.txt_asset_code.SelectionLength = 0
        Me.txt_asset_code.SelectionStart = 0
        Me.txt_asset_code.Size = New System.Drawing.Size(150, 20)
        Me.txt_asset_code.TabIndex = 16
        Me.txt_asset_code.TableData = Nothing
        Me.txt_asset_code.Tag = ""
        Me.txt_asset_code.TextSource = ""
        Me.txt_asset_code.UseSystemPasswordChar = False
        Me.txt_asset_code.Value = ""
        Me.txt_asset_code.ValueSource = ""
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
        Me.txt_ref_no.Location = New System.Drawing.Point(90, 12)
        Me.txt_ref_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_no.MultiLine = False
        Me.txt_ref_no.Name = "txt_ref_no"
        Me.txt_ref_no.NoClear = False
        Me.txt_ref_no.NumberFormat = "@"
        Me.txt_ref_no.Required = False
        Me.txt_ref_no.RowData = Nothing
        Me.txt_ref_no.SelectionLength = 0
        Me.txt_ref_no.SelectionStart = 0
        Me.txt_ref_no.Size = New System.Drawing.Size(150, 20)
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
        Me.Label10.Location = New System.Drawing.Point(4, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Item Description"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Item Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 15)
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
        Me.btnSave.TabIndex = 212
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.btnNotSave.TabIndex = 213
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
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
        Me.txt_total_amount.Location = New System.Drawing.Point(553, 282)
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
        Me.txt_total_amount.TabIndex = 210
        Me.txt_total_amount.TableData = Nothing
        Me.txt_total_amount.TextSource = ""
        Me.txt_total_amount.UseSystemPasswordChar = False
        Me.txt_total_amount.Value = "0.00"
        Me.txt_total_amount.ValueSource = ""
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
        Me.txt_total_based.Location = New System.Drawing.Point(408, 282)
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
        Me.txt_total_based.TabIndex = 216
        Me.txt_total_based.TableData = Nothing
        Me.txt_total_based.TextSource = ""
        Me.txt_total_based.UseSystemPasswordChar = False
        Me.txt_total_based.Value = "0.00"
        Me.txt_total_based.ValueSource = ""
        Me.txt_total_based.Visible = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(805, 28)
        Me.Myformheader1.TabIndex = 217
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.ForeColor = System.Drawing.Color.White
        Me.btnViewDetails.Location = New System.Drawing.Point(679, 282)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(115, 24)
        Me.btnViewDetails.TabIndex = 220
        Me.btnViewDetails.Tag = "btnViewDetails"
        Me.btnViewDetails.Text = "F6 View Schedule"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(780, 2)
        Me.border1.TabIndex = 203
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'begbal_fa_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 490)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txt_total_amount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_total_based)
        Me.Controls.Add(Me.panel_hdr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "begbal_fa_detail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixed Assets Beginning balance - Details"
        Me.panel_hdr.ResumeLayout(False)
        Me.panel_hdr.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_total_amount As user_control.textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_total_based As user_control.textbox
    Friend WithEvents panel_hdr As System.Windows.Forms.Panel
    Friend WithEvents txt_department As user_control.textbox
    Friend WithEvents txt_account_name As user_control.textbox
    Friend WithEvents txt_project As user_control.textbox
    Friend WithEvents txt_account As user_control.textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_amount As user_control.textbox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_quantity As user_control.textbox
    Friend WithEvents txt_useful_life As user_control.textbox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_description As user_control.textbox
    Friend WithEvents txt_asset_code As user_control.textbox
    Friend WithEvents txt_ref_no As user_control.textbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents txt_historical_rate As user_control.textbox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_date_acquired As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_date_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_based_rate As user_control.textbox
    Friend WithEvents txt_exchange_rate As user_control.textbox
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fixed_asset_id As user_control.textbox
    Friend WithEvents txt_net_book_value As user_control.textbox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_salvage_value As user_control.textbox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents txt_debit_based As user_control.textbox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_salvage_value_based As user_control.textbox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_net_book_value_based As user_control.textbox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_amount_based As user_control.textbox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents fixed_asset_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents useful_life As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents minimum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_unit_id As user_control.textbox
    Friend WithEvents lblUnit As Windows.Forms.Label
End Class
