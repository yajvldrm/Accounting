<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allocation
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.allocation_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allocation_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allocation_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_allocation_name = New user_control.textbox()
        Me.txt_allocation_code = New user_control.textbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_allocation_id = New user_control.textbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelSub = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Textbox6 = New user_control.textbox()
        Me.txt_allocation_account_id = New user_control.textbox()
        Me.txt_account_name = New user_control.textbox()
        Me.txt_account_code = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgSub = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.allocation_account_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.txtsearch = New user_control.textbox()
        Me.primary_key = New user_control.textbox()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxContainer.SuspendLayout()
        Me.panelSub.SuspendLayout()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeight = 28
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.allocation_id, Me.allocation_code, Me.allocation_name})
        Me.dgMain.Location = New System.Drawing.Point(12, 70)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(526, 150)
        Me.dgMain.TabIndex = 95
        Me.dgMain.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FalseValue = "False"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.TrueValue = "True"
        Me.sel.Width = 30
        '
        'allocation_id
        '
        Me.allocation_id.DataPropertyName = "allocation_id"
        Me.allocation_id.HeaderText = "ID"
        Me.allocation_id.Name = "allocation_id"
        Me.allocation_id.ReadOnly = True
        Me.allocation_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allocation_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.allocation_id.Visible = False
        '
        'allocation_code
        '
        Me.allocation_code.DataPropertyName = "allocation_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allocation_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.allocation_code.HeaderText = "Code"
        Me.allocation_code.Name = "allocation_code"
        Me.allocation_code.ReadOnly = True
        Me.allocation_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allocation_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'allocation_name
        '
        Me.allocation_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.allocation_name.DataPropertyName = "allocation_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.allocation_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.allocation_name.HeaderText = "Allocation Name"
        Me.allocation_name.Name = "allocation_name"
        Me.allocation_name.ReadOnly = True
        Me.allocation_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allocation_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(184, 226)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 92
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Delete"
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
        Me.btnUpdate.Location = New System.Drawing.Point(98, 226)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 91
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
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
        Me.btnInsert.Location = New System.Drawing.Point(12, 226)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 90
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Controls.Add(Me.txt_allocation_name)
        Me.gboxContainer.Controls.Add(Me.txt_allocation_code)
        Me.gboxContainer.Controls.Add(Me.Label9)
        Me.gboxContainer.Controls.Add(Me.txt_allocation_id)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 255)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(526, 50)
        Me.gboxContainer.TabIndex = 87
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(257, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(225, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 113
        Me.Label8.Tag = "label"
        Me.Label8.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(36, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "*"
        '
        'txt_allocation_name
        '
        Me.txt_allocation_name._Text = ""
        Me.txt_allocation_name.AlwaysDisable = False
        Me.txt_allocation_name.AlwaysEnable = False
        Me.txt_allocation_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_allocation_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_allocation_name.DataSource = ""
        Me.txt_allocation_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_name.Enabled = False
        Me.txt_allocation_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_allocation_name.ispk = False
        Me.txt_allocation_name.Location = New System.Drawing.Point(270, 19)
        Me.txt_allocation_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_name.MultiLine = False
        Me.txt_allocation_name.Name = "txt_allocation_name"
        Me.txt_allocation_name.NoClear = False
        Me.txt_allocation_name.NumberFormat = "@"
        Me.txt_allocation_name.Required = True
        Me.txt_allocation_name.RowData = Nothing
        Me.txt_allocation_name.SelectionLength = 0
        Me.txt_allocation_name.SelectionStart = 0
        Me.txt_allocation_name.Size = New System.Drawing.Size(250, 20)
        Me.txt_allocation_name.TabIndex = 3
        Me.txt_allocation_name.TableData = Nothing
        Me.txt_allocation_name.TextSource = ""
        Me.txt_allocation_name.UseSystemPasswordChar = False
        Me.txt_allocation_name.Value = ""
        Me.txt_allocation_name.ValueSource = ""
        '
        'txt_allocation_code
        '
        Me.txt_allocation_code._Text = ""
        Me.txt_allocation_code.AlwaysDisable = False
        Me.txt_allocation_code.AlwaysEnable = False
        Me.txt_allocation_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_allocation_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_allocation_code.DataSource = ""
        Me.txt_allocation_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_code.Enabled = False
        Me.txt_allocation_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_allocation_code.ispk = False
        Me.txt_allocation_code.Location = New System.Drawing.Point(49, 19)
        Me.txt_allocation_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_code.MultiLine = False
        Me.txt_allocation_code.Name = "txt_allocation_code"
        Me.txt_allocation_code.NoClear = False
        Me.txt_allocation_code.NumberFormat = "@"
        Me.txt_allocation_code.Required = True
        Me.txt_allocation_code.RowData = Nothing
        Me.txt_allocation_code.SelectionLength = 0
        Me.txt_allocation_code.SelectionStart = 0
        Me.txt_allocation_code.Size = New System.Drawing.Size(170, 20)
        Me.txt_allocation_code.TabIndex = 2
        Me.txt_allocation_code.TableData = Nothing
        Me.txt_allocation_code.Tag = "focus"
        Me.txt_allocation_code.TextSource = ""
        Me.txt_allocation_code.UseSystemPasswordChar = False
        Me.txt_allocation_code.Value = ""
        Me.txt_allocation_code.ValueSource = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(7, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 112
        Me.Label9.Tag = "label"
        Me.Label9.Text = "Code"
        '
        'txt_allocation_id
        '
        Me.txt_allocation_id._Text = ""
        Me.txt_allocation_id.AlwaysDisable = False
        Me.txt_allocation_id.AlwaysEnable = False
        Me.txt_allocation_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_allocation_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_allocation_id.DataSource = ""
        Me.txt_allocation_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_id.Enabled = False
        Me.txt_allocation_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_allocation_id.ispk = False
        Me.txt_allocation_id.Location = New System.Drawing.Point(0, 0)
        Me.txt_allocation_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_id.MultiLine = False
        Me.txt_allocation_id.Name = "txt_allocation_id"
        Me.txt_allocation_id.NoClear = False
        Me.txt_allocation_id.NumberFormat = "@"
        Me.txt_allocation_id.Required = False
        Me.txt_allocation_id.RowData = Nothing
        Me.txt_allocation_id.SelectionLength = 0
        Me.txt_allocation_id.SelectionStart = 0
        Me.txt_allocation_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_allocation_id.TabIndex = 1
        Me.txt_allocation_id.TableData = Nothing
        Me.txt_allocation_id.TextSource = ""
        Me.txt_allocation_id.UseSystemPasswordChar = False
        Me.txt_allocation_id.Value = ""
        Me.txt_allocation_id.ValueSource = ""
        Me.txt_allocation_id.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Allocation Setup"
        '
        'panelSub
        '
        Me.panelSub.Controls.Add(Me.Button8)
        Me.panelSub.Controls.Add(Me.Button9)
        Me.panelSub.Controls.Add(Me.Button10)
        Me.panelSub.Controls.Add(Me.Button6)
        Me.panelSub.Controls.Add(Me.Button7)
        Me.panelSub.Controls.Add(Me.Textbox6)
        Me.panelSub.Controls.Add(Me.txt_allocation_account_id)
        Me.panelSub.Controls.Add(Me.txt_account_name)
        Me.panelSub.Controls.Add(Me.txt_account_code)
        Me.panelSub.Controls.Add(Me.Label4)
        Me.panelSub.Controls.Add(Me.Label5)
        Me.panelSub.Controls.Add(Me.dgSub)
        Me.panelSub.Location = New System.Drawing.Point(12, 311)
        Me.panelSub.Name = "panelSub"
        Me.panelSub.Size = New System.Drawing.Size(526, 212)
        Me.panelSub.TabIndex = 97
        Me.panelSub.Tag = "subContainer"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(175, 159)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 24)
        Me.Button8.TabIndex = 93
        Me.Button8.Tag = "btn-sub-remove"
        Me.Button8.Text = "Remove"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(89, 159)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 24)
        Me.Button9.TabIndex = 92
        Me.Button9.Tag = "btn-sub-update"
        Me.Button9.Text = "Update"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(3, 159)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 24)
        Me.Button10.TabIndex = 91
        Me.Button10.Tag = "btn-sub-insert"
        Me.Button10.Text = "Insert"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(89, 159)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 24)
        Me.Button6.TabIndex = 95
        Me.Button6.Tag = "btn-sub-cancel"
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Green
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(3, 159)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 24)
        Me.Button7.TabIndex = 94
        Me.Button7.Tag = "btn-sub-ok"
        Me.Button7.Text = "OK"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Textbox6
        '
        Me.Textbox6._Text = ""
        Me.Textbox6.AlwaysDisable = True
        Me.Textbox6.AlwaysEnable = False
        Me.Textbox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Textbox6.BorderColor = System.Drawing.Color.DarkGray
        Me.Textbox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox6.DataSource = ""
        Me.Textbox6.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Textbox6.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Textbox6.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.Textbox6.Enabled = False
        Me.Textbox6.EnabledBackColor = System.Drawing.Color.White
        Me.Textbox6.ispk = False
        Me.Textbox6.Location = New System.Drawing.Point(435, 159)
        Me.Textbox6.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Textbox6.MultiLine = False
        Me.Textbox6.Name = "Textbox6"
        Me.Textbox6.NoClear = False
        Me.Textbox6.NumberFormat = "@"
        Me.Textbox6.Required = False
        Me.Textbox6.RowData = Nothing
        Me.Textbox6.SelectionLength = 0
        Me.Textbox6.SelectionStart = 0
        Me.Textbox6.Size = New System.Drawing.Size(20, 20)
        Me.Textbox6.TabIndex = 2
        Me.Textbox6.TableData = Nothing
        Me.Textbox6.Tag = "transmode"
        Me.Textbox6.TextSource = ""
        Me.Textbox6.UseSystemPasswordChar = False
        Me.Textbox6.Value = ""
        Me.Textbox6.ValueSource = ""
        Me.Textbox6.Visible = False
        '
        'txt_allocation_account_id
        '
        Me.txt_allocation_account_id._Text = ""
        Me.txt_allocation_account_id.AlwaysDisable = True
        Me.txt_allocation_account_id.AlwaysEnable = False
        Me.txt_allocation_account_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_account_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_allocation_account_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_allocation_account_id.DataSource = ""
        Me.txt_allocation_account_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_account_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_account_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_account_id.Enabled = False
        Me.txt_allocation_account_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_allocation_account_id.ispk = False
        Me.txt_allocation_account_id.Location = New System.Drawing.Point(461, 159)
        Me.txt_allocation_account_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_account_id.MultiLine = False
        Me.txt_allocation_account_id.Name = "txt_allocation_account_id"
        Me.txt_allocation_account_id.NoClear = False
        Me.txt_allocation_account_id.NumberFormat = "@"
        Me.txt_allocation_account_id.Required = False
        Me.txt_allocation_account_id.RowData = Nothing
        Me.txt_allocation_account_id.SelectionLength = 0
        Me.txt_allocation_account_id.SelectionStart = 0
        Me.txt_allocation_account_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_allocation_account_id.TabIndex = 1
        Me.txt_allocation_account_id.TableData = Nothing
        Me.txt_allocation_account_id.Tag = "pk"
        Me.txt_allocation_account_id.TextSource = ""
        Me.txt_allocation_account_id.UseSystemPasswordChar = False
        Me.txt_allocation_account_id.Value = ""
        Me.txt_allocation_account_id.ValueSource = ""
        Me.txt_allocation_account_id.Visible = False
        '
        'txt_account_name
        '
        Me.txt_account_name._Text = ""
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
        Me.txt_account_name.Location = New System.Drawing.Point(270, 188)
        Me.txt_account_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.MultiLine = False
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = False
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.SelectionLength = 0
        Me.txt_account_name.SelectionStart = 0
        Me.txt_account_name.Size = New System.Drawing.Size(250, 20)
        Me.txt_account_name.TabIndex = 4
        Me.txt_account_name.TableData = Nothing
        Me.txt_account_name.Tag = ""
        Me.txt_account_name.TextSource = ""
        Me.txt_account_name.UseSystemPasswordChar = False
        Me.txt_account_name.Value = ""
        Me.txt_account_name.ValueSource = ""
        '
        'txt_account_code
        '
        Me.txt_account_code._Text = ""
        Me.txt_account_code.AlwaysDisable = False
        Me.txt_account_code.AlwaysEnable = False
        Me.txt_account_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_code.DataSource = ""
        Me.txt_account_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_code.Enabled = False
        Me.txt_account_code.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_account_code.ispk = False
        Me.txt_account_code.Location = New System.Drawing.Point(49, 188)
        Me.txt_account_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_code.MultiLine = False
        Me.txt_account_code.Name = "txt_account_code"
        Me.txt_account_code.NoClear = False
        Me.txt_account_code.NumberFormat = "@"
        Me.txt_account_code.Required = False
        Me.txt_account_code.RowData = Nothing
        Me.txt_account_code.SelectionLength = 0
        Me.txt_account_code.SelectionStart = 0
        Me.txt_account_code.Size = New System.Drawing.Size(170, 20)
        Me.txt_account_code.TabIndex = 3
        Me.txt_account_code.TableData = Nothing
        Me.txt_account_code.Tag = "focus fk"
        Me.txt_account_code.TextSource = "account_code"
        Me.txt_account_code.UseSystemPasswordChar = False
        Me.txt_account_code.Value = ""
        Me.txt_account_code.ValueSource = "account_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Tag = "label"
        Me.Label5.Text = "Code"
        '
        'dgSub
        '
        Me.dgSub.AllowUserToAddRows = False
        Me.dgSub.AllowUserToDeleteRows = False
        Me.dgSub.AllowUserToResizeColumns = False
        Me.dgSub.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSub.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.deleted, Me.allocation_account_id, Me.account_id, Me.account_code, Me.account_name})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSub.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgSub.Location = New System.Drawing.Point(3, 3)
        Me.dgSub.MultiSelect = False
        Me.dgSub.Name = "dgSub"
        Me.dgSub.RowHeadersVisible = False
        Me.dgSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSub.Size = New System.Drawing.Size(520, 150)
        Me.dgSub.TabIndex = 8
        Me.dgSub.Tag = "sub-grid"
        '
        'sel1
        '
        Me.sel1.DataPropertyName = "sel1"
        Me.sel1.FalseValue = "False"
        Me.sel1.HeaderText = "Sel"
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.TrueValue = "True"
        Me.sel1.Width = 30
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "Deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleted.Visible = False
        '
        'allocation_account_id
        '
        Me.allocation_account_id.DataPropertyName = "allocation_account_id"
        Me.allocation_account_id.HeaderText = "ID"
        Me.allocation_account_id.Name = "allocation_account_id"
        Me.allocation_account_id.ReadOnly = True
        Me.allocation_account_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allocation_account_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.allocation_account_id.Visible = False
        '
        'account_id
        '
        Me.account_id.DataPropertyName = "account_id"
        Me.account_id.HeaderText = "ID"
        Me.account_id.Name = "account_id"
        Me.account_id.ReadOnly = True
        Me.account_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.account_id.Visible = False
        '
        'account_code
        '
        Me.account_code.DataPropertyName = "account_code"
        Me.account_code.FillWeight = 179.6407!
        Me.account_code.HeaderText = "Code"
        Me.account_code.Name = "account_code"
        Me.account_code.ReadOnly = True
        Me.account_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.account_code.Width = 150
        '
        'account_name
        '
        Me.account_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.account_name.DataPropertyName = "account_name"
        Me.account_name.FillWeight = 20.35928!
        Me.account_name.HeaderText = "Account Name"
        Me.account_name.Name = "account_name"
        Me.account_name.ReadOnly = True
        Me.account_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 226)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 94
        Me.btnNotSave.Tag = "btnNotSave"
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
        Me.btnSave.Location = New System.Drawing.Point(12, 226)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 93
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Search"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(550, 28)
        Me.Myformheader1.TabIndex = 100
        '
        'txtsearch
        '
        Me.txtsearch._Text = ""
        Me.txtsearch.AlwaysDisable = False
        Me.txtsearch.AlwaysEnable = False
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderColor = System.Drawing.Color.DarkGray
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.DataSource = ""
        Me.txtsearch.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtsearch.EnabledBackColor = System.Drawing.Color.White
        Me.txtsearch.ispk = False
        Me.txtsearch.Location = New System.Drawing.Point(388, 34)
        Me.txtsearch.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.MultiLine = False
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.SelectionLength = 0
        Me.txtsearch.SelectionStart = 0
        Me.txtsearch.Size = New System.Drawing.Size(150, 20)
        Me.txtsearch.TabIndex = 1
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = ""
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'primary_key
        '
        Me.primary_key._Text = ""
        Me.primary_key.AlwaysDisable = False
        Me.primary_key.AlwaysEnable = False
        Me.primary_key.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.primary_key.BorderColor = System.Drawing.Color.DarkGray
        Me.primary_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.primary_key.DataSource = ""
        Me.primary_key.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.primary_key.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.primary_key.EnabledBackColor = System.Drawing.Color.White
        Me.primary_key.ispk = False
        Me.primary_key.Location = New System.Drawing.Point(208, 36)
        Me.primary_key.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.MultiLine = False
        Me.primary_key.Name = "primary_key"
        Me.primary_key.NoClear = False
        Me.primary_key.NumberFormat = "@"
        Me.primary_key.Required = False
        Me.primary_key.RowData = Nothing
        Me.primary_key.SelectionLength = 0
        Me.primary_key.SelectionStart = 0
        Me.primary_key.Size = New System.Drawing.Size(105, 20)
        Me.primary_key.TabIndex = 96
        Me.primary_key.TableData = Nothing
        Me.primary_key.TextSource = ""
        Me.primary_key.UseSystemPasswordChar = False
        Me.primary_key.Value = ""
        Me.primary_key.ValueSource = "allocation_id"
        Me.primary_key.Visible = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(525, 2)
        Me.border1.TabIndex = 89
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'allocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 535)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.panelSub)
        Me.Controls.Add(Me.primary_key)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "allocation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allocation Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        Me.panelSub.ResumeLayout(False)
        Me.panelSub.PerformLayout()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txt_allocation_id As user_control.textbox
    Friend WithEvents txt_allocation_name As user_control.textbox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_allocation_code As user_control.textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents primary_key As user_control.textbox
    Friend WithEvents panelSub As System.Windows.Forms.Panel
    Friend WithEvents txt_allocation_account_id As user_control.textbox
    Friend WithEvents txt_account_name As user_control.textbox
    Friend WithEvents txt_account_code As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgSub As System.Windows.Forms.DataGridView
    Friend WithEvents Textbox6 As user_control.textbox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents allocation_account_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents allocation_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allocation_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allocation_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
