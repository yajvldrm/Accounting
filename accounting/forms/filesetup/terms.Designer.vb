<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class terms
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
        Me.txt_terms_id = New user_control.textbox()
        Me.txt_terms_code = New user_control.textbox()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fixed_day = New System.Windows.Forms.CheckBox()
        Me.txt_terms_type = New System.Windows.Forms.GroupBox()
        Me.Rdo_button3 = New user_control.rdo_button()
        Me.Rdo_button2 = New user_control.rdo_button()
        Me.Rdo_button1 = New user_control.rdo_button()
        Me.txt_terms_name = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nodays = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.terms_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.terms_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.terms_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.gboxContainer.SuspendLayout()
        Me.txt_terms_type.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_terms_id
        '
        Me.txt_terms_id._Text = ""
        Me.txt_terms_id.AlwaysDisable = False
        Me.txt_terms_id.AlwaysEnable = False
        Me.txt_terms_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_terms_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_terms_id.DataSource = ""
        Me.txt_terms_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_terms_id.Enabled = False
        Me.txt_terms_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_terms_id.ispk = False
        Me.txt_terms_id.Location = New System.Drawing.Point(6, 8)
        Me.txt_terms_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_id.MultiLine = False
        Me.txt_terms_id.Name = "txt_terms_id"
        Me.txt_terms_id.NoClear = False
        Me.txt_terms_id.NumberFormat = "@"
        Me.txt_terms_id.Required = False
        Me.txt_terms_id.RowData = Nothing
        Me.txt_terms_id.SelectionLength = 0
        Me.txt_terms_id.SelectionStart = 0
        Me.txt_terms_id.Size = New System.Drawing.Size(20, 20)
        Me.txt_terms_id.TabIndex = 1
        Me.txt_terms_id.TableData = Nothing
        Me.txt_terms_id.TextSource = "terms_id"
        Me.txt_terms_id.UseSystemPasswordChar = False
        Me.txt_terms_id.Value = ""
        Me.txt_terms_id.ValueSource = "terms_id"
        Me.txt_terms_id.Visible = False
        '
        'txt_terms_code
        '
        Me.txt_terms_code._Text = ""
        Me.txt_terms_code.AlwaysDisable = False
        Me.txt_terms_code.AlwaysEnable = False
        Me.txt_terms_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_terms_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_terms_code.DataSource = ""
        Me.txt_terms_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_terms_code.Enabled = False
        Me.txt_terms_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_terms_code.ispk = False
        Me.txt_terms_code.Location = New System.Drawing.Point(71, 77)
        Me.txt_terms_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_code.MultiLine = False
        Me.txt_terms_code.Name = "txt_terms_code"
        Me.txt_terms_code.NoClear = False
        Me.txt_terms_code.NumberFormat = "@"
        Me.txt_terms_code.Required = True
        Me.txt_terms_code.RowData = Nothing
        Me.txt_terms_code.SelectionLength = 0
        Me.txt_terms_code.SelectionStart = 0
        Me.txt_terms_code.Size = New System.Drawing.Size(200, 20)
        Me.txt_terms_code.TabIndex = 6
        Me.txt_terms_code.TableData = Nothing
        Me.txt_terms_code.Tag = "focus"
        Me.txt_terms_code.TextSource = "terms_code"
        Me.txt_terms_code.UseSystemPasswordChar = False
        Me.txt_terms_code.Value = ""
        Me.txt_terms_code.ValueSource = "terms_code"
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.Label6)
        Me.gboxContainer.Controls.Add(Me.Label5)
        Me.gboxContainer.Controls.Add(Me.txt_fixed_day)
        Me.gboxContainer.Controls.Add(Me.txt_terms_type)
        Me.gboxContainer.Controls.Add(Me.txt_terms_name)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.txt_nodays)
        Me.gboxContainer.Controls.Add(Me.Label4)
        Me.gboxContainer.Controls.Add(Me.txt_terms_id)
        Me.gboxContainer.Controls.Add(Me.txt_terms_code)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 255)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(476, 135)
        Me.gboxContainer.TabIndex = 69
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(337, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(58, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 16)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(58, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "*"
        '
        'txt_fixed_day
        '
        Me.txt_fixed_day.AutoSize = True
        Me.txt_fixed_day.Location = New System.Drawing.Point(350, 103)
        Me.txt_fixed_day.Name = "txt_fixed_day"
        Me.txt_fixed_day.Size = New System.Drawing.Size(73, 17)
        Me.txt_fixed_day.TabIndex = 9
        Me.txt_fixed_day.Text = "Fixed Day"
        Me.txt_fixed_day.UseVisualStyleBackColor = True
        '
        'txt_terms_type
        '
        Me.txt_terms_type.Controls.Add(Me.Rdo_button3)
        Me.txt_terms_type.Controls.Add(Me.Rdo_button2)
        Me.txt_terms_type.Controls.Add(Me.Rdo_button1)
        Me.txt_terms_type.Location = New System.Drawing.Point(99, 19)
        Me.txt_terms_type.Name = "txt_terms_type"
        Me.txt_terms_type.Size = New System.Drawing.Size(278, 49)
        Me.txt_terms_type.TabIndex = 2
        Me.txt_terms_type.TabStop = False
        Me.txt_terms_type.Tag = "container"
        Me.txt_terms_type.Text = "Type"
        '
        'Rdo_button3
        '
        Me.Rdo_button3.AutoSize = True
        Me.Rdo_button3.DataSource = ""
        Me.Rdo_button3.Location = New System.Drawing.Point(214, 19)
        Me.Rdo_button3.Name = "Rdo_button3"
        Me.Rdo_button3.Size = New System.Drawing.Size(47, 17)
        Me.Rdo_button3.TabIndex = 5
        Me.Rdo_button3.TabStop = True
        Me.Rdo_button3.Text = "Both"
        Me.Rdo_button3.TextSource = ""
        Me.Rdo_button3.Uncheckable = False
        Me.Rdo_button3.UseVisualStyleBackColor = True
        Me.Rdo_button3.Value = "3"
        Me.Rdo_button3.ValueSource = ""
        '
        'Rdo_button2
        '
        Me.Rdo_button2.AutoSize = True
        Me.Rdo_button2.DataSource = ""
        Me.Rdo_button2.Location = New System.Drawing.Point(120, 19)
        Me.Rdo_button2.Name = "Rdo_button2"
        Me.Rdo_button2.Size = New System.Drawing.Size(88, 17)
        Me.Rdo_button2.TabIndex = 4
        Me.Rdo_button2.TabStop = True
        Me.Rdo_button2.Text = "Selling Terms"
        Me.Rdo_button2.TextSource = ""
        Me.Rdo_button2.Uncheckable = False
        Me.Rdo_button2.UseVisualStyleBackColor = True
        Me.Rdo_button2.Value = "2"
        Me.Rdo_button2.ValueSource = ""
        '
        'Rdo_button1
        '
        Me.Rdo_button1.AutoSize = True
        Me.Rdo_button1.DataSource = ""
        Me.Rdo_button1.Location = New System.Drawing.Point(16, 19)
        Me.Rdo_button1.Name = "Rdo_button1"
        Me.Rdo_button1.Size = New System.Drawing.Size(98, 17)
        Me.Rdo_button1.TabIndex = 3
        Me.Rdo_button1.TabStop = True
        Me.Rdo_button1.Text = "Payment Terms"
        Me.Rdo_button1.TextSource = ""
        Me.Rdo_button1.Uncheckable = False
        Me.Rdo_button1.UseVisualStyleBackColor = True
        Me.Rdo_button1.Value = "1"
        Me.Rdo_button1.ValueSource = ""
        '
        'txt_terms_name
        '
        Me.txt_terms_name._Text = ""
        Me.txt_terms_name.AlwaysDisable = False
        Me.txt_terms_name.AlwaysEnable = False
        Me.txt_terms_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_terms_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_terms_name.DataSource = ""
        Me.txt_terms_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_terms_name.Enabled = False
        Me.txt_terms_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_terms_name.ispk = False
        Me.txt_terms_name.Location = New System.Drawing.Point(71, 103)
        Me.txt_terms_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_name.MultiLine = False
        Me.txt_terms_name.Name = "txt_terms_name"
        Me.txt_terms_name.NoClear = False
        Me.txt_terms_name.NumberFormat = "@"
        Me.txt_terms_name.Required = True
        Me.txt_terms_name.RowData = Nothing
        Me.txt_terms_name.SelectionLength = 0
        Me.txt_terms_name.SelectionStart = 0
        Me.txt_terms_name.Size = New System.Drawing.Size(200, 20)
        Me.txt_terms_name.TabIndex = 7
        Me.txt_terms_name.TableData = Nothing
        Me.txt_terms_name.TextSource = "terms_name"
        Me.txt_terms_name.UseSystemPasswordChar = False
        Me.txt_terms_name.Value = ""
        Me.txt_terms_name.ValueSource = "terms_name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Name"
        '
        'txt_nodays
        '
        Me.txt_nodays._Text = ""
        Me.txt_nodays.AlwaysDisable = False
        Me.txt_nodays.AlwaysEnable = False
        Me.txt_nodays.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_nodays.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_nodays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nodays.DataSource = ""
        Me.txt_nodays.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nodays.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_nodays.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_nodays.Enabled = False
        Me.txt_nodays.EnabledBackColor = System.Drawing.Color.White
        Me.txt_nodays.ispk = False
        Me.txt_nodays.Location = New System.Drawing.Point(350, 77)
        Me.txt_nodays.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nodays.MultiLine = False
        Me.txt_nodays.Name = "txt_nodays"
        Me.txt_nodays.NoClear = False
        Me.txt_nodays.NumberFormat = "##,##0"
        Me.txt_nodays.Required = True
        Me.txt_nodays.RowData = Nothing
        Me.txt_nodays.SelectionLength = 0
        Me.txt_nodays.SelectionStart = 0
        Me.txt_nodays.Size = New System.Drawing.Size(100, 20)
        Me.txt_nodays.TabIndex = 8
        Me.txt_nodays.TableData = Nothing
        Me.txt_nodays.TextSource = "nodays"
        Me.txt_nodays.UseSystemPasswordChar = False
        Me.txt_nodays.Value = "0"
        Me.txt_nodays.ValueSource = "nodays"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(277, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Tag = "label"
        Me.Label4.Text = "No. of Days"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Code"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.terms_id, Me.terms_code, Me.terms_name})
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
        Me.dgMain.Size = New System.Drawing.Size(476, 150)
        Me.dgMain.TabIndex = 77
        Me.dgMain.Tag = "maingrid"
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
        'terms_id
        '
        Me.terms_id.DataPropertyName = "terms_id"
        Me.terms_id.HeaderText = "Terms ID"
        Me.terms_id.Name = "terms_id"
        Me.terms_id.ReadOnly = True
        Me.terms_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.terms_id.Visible = False
        '
        'terms_code
        '
        Me.terms_code.DataPropertyName = "terms_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terms_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.terms_code.HeaderText = "Code"
        Me.terms_code.Name = "terms_code"
        Me.terms_code.ReadOnly = True
        Me.terms_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.terms_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'terms_name
        '
        Me.terms_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.terms_name.DataPropertyName = "terms_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.terms_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.terms_name.HeaderText = "Terms Name"
        Me.terms_name.Name = "terms_name"
        Me.terms_name.ReadOnly = True
        Me.terms_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.terms_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.btnNotSave.TabIndex = 76
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
        Me.btnSave.TabIndex = 75
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.btnRemove.TabIndex = 74
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
        Me.btnUpdate.TabIndex = 73
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
        Me.btnInsert.TabIndex = 72
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Terms Setup"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 78
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(475, 2)
        Me.border1.TabIndex = 71
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'terms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 400)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "terms"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terms Setup"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        Me.txt_terms_type.ResumeLayout(False)
        Me.txt_terms_type.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents txt_terms_id As user_control.textbox
    Friend WithEvents txt_terms_code As user_control.textbox
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_terms_name As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nodays As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_terms_type As System.Windows.Forms.GroupBox
    Friend WithEvents Rdo_button3 As user_control.rdo_button
    Friend WithEvents Rdo_button2 As user_control.rdo_button
    Friend WithEvents Rdo_button1 As user_control.rdo_button
    Friend WithEvents txt_fixed_day As System.Windows.Forms.CheckBox
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents terms_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents terms_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents terms_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
