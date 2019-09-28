<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class chart
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.account_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_class_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_noCompute = New System.Windows.Forms.CheckBox()
        Me.txt_isRestatement = New System.Windows.Forms.CheckBox()
        Me.txt_unit_applicable = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_account_id = New user_control.textbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_account_name = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_account_code = New user_control.textbox()
        Me.txt_chart_class_id = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_validation = New System.Windows.Forms.GroupBox()
        Me.txt_input_vat_importation = New System.Windows.Forms.CheckBox()
        Me.Rdo_button11 = New user_control.rdo_button()
        Me.Rdo_button10 = New user_control.rdo_button()
        Me.Rdo_button9 = New user_control.rdo_button()
        Me.Rdo_button12 = New user_control.rdo_button()
        Me.Rdo_button8 = New user_control.rdo_button()
        Me.Rdo_button7 = New user_control.rdo_button()
        Me.Rdo_button6 = New user_control.rdo_button()
        Me.Rdo_button5 = New user_control.rdo_button()
        Me.Rdo_button4 = New user_control.rdo_button()
        Me.Rdo_button3 = New user_control.rdo_button()
        Me.Rdo_button2 = New user_control.rdo_button()
        Me.Rdo_button1 = New user_control.rdo_button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.panelGroup = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Textbox6 = New user_control.textbox()
        Me.txt_chart_group_id = New user_control.textbox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dgGroup = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chart_group_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.group_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_group_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_group_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_chart_group_name = New user_control.textbox()
        Me.txt_chart_group_code = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.txtsearch = New user_control.textbox()
        Me.primary_key = New user_control.textbox()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.txt_validation.SuspendLayout()
        Me.panelGroup.SuspendLayout()
        CType(Me.dgGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 25)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Chart of Accounts"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.account_id, Me.account_code, Me.account_name, Me.chart_class_name})
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
        Me.dgMain.Size = New System.Drawing.Size(659, 150)
        Me.dgMain.TabIndex = 90
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
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account_code.DefaultCellStyle = DataGridViewCellStyle5
        Me.account_code.HeaderText = "Code"
        Me.account_code.Name = "account_code"
        Me.account_code.ReadOnly = True
        Me.account_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_code.Width = 80
        '
        'account_name
        '
        Me.account_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.account_name.DataPropertyName = "account_name"
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.account_name.DefaultCellStyle = DataGridViewCellStyle6
        Me.account_name.HeaderText = "Name"
        Me.account_name.Name = "account_name"
        Me.account_name.ReadOnly = True
        Me.account_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'chart_class_name
        '
        Me.chart_class_name.DataPropertyName = "chart_class_name"
        Me.chart_class_name.HeaderText = "Chart Class"
        Me.chart_class_name.Name = "chart_class_name"
        Me.chart_class_name.ReadOnly = True
        Me.chart_class_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_class_name.Width = 150
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 225)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 6
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 225)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 5
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
        Me.btnRemove.Location = New System.Drawing.Point(184, 225)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 4
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
        Me.btnUpdate.Location = New System.Drawing.Point(98, 225)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 3
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
        Me.btnInsert.Location = New System.Drawing.Point(12, 225)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_input_vat_importation)
        Me.Panel1.Controls.Add(Me.txt_noCompute)
        Me.Panel1.Controls.Add(Me.txt_isRestatement)
        Me.Panel1.Controls.Add(Me.txt_unit_applicable)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_account_id)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_date)
        Me.Panel1.Controls.Add(Me.txt_account_name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_account_code)
        Me.Panel1.Controls.Add(Me.txt_chart_class_id)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_validation)
        Me.Panel1.Location = New System.Drawing.Point(12, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 135)
        Me.Panel1.TabIndex = 96
        Me.Panel1.Tag = "container"
        '
        'txt_noCompute
        '
        Me.txt_noCompute.AutoSize = True
        Me.txt_noCompute.Location = New System.Drawing.Point(574, 29)
        Me.txt_noCompute.Name = "txt_noCompute"
        Me.txt_noCompute.Size = New System.Drawing.Size(85, 17)
        Me.txt_noCompute.TabIndex = 115
        Me.txt_noCompute.Text = "No Compute"
        Me.txt_noCompute.UseVisualStyleBackColor = True
        '
        'txt_isRestatement
        '
        Me.txt_isRestatement.AutoSize = True
        Me.txt_isRestatement.Location = New System.Drawing.Point(379, 29)
        Me.txt_isRestatement.Name = "txt_isRestatement"
        Me.txt_isRestatement.Size = New System.Drawing.Size(86, 17)
        Me.txt_isRestatement.TabIndex = 114
        Me.txt_isRestatement.Text = "Restatement"
        Me.txt_isRestatement.UseVisualStyleBackColor = True
        '
        'txt_unit_applicable
        '
        Me.txt_unit_applicable.AutoSize = True
        Me.txt_unit_applicable.Location = New System.Drawing.Point(471, 29)
        Me.txt_unit_applicable.Name = "txt_unit_applicable"
        Me.txt_unit_applicable.Size = New System.Drawing.Size(97, 17)
        Me.txt_unit_applicable.TabIndex = 113
        Me.txt_unit_applicable.Text = "Unit Applicable"
        Me.txt_unit_applicable.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(257, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(35, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "*"
        '
        'txt_account_id
        '
        Me.txt_account_id._Text = ""
        Me.txt_account_id.AllowNegative = False
        Me.txt_account_id.AlwaysDisable = False
        Me.txt_account_id.AlwaysEnable = False
        Me.txt_account_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_id.DataSource = ""
        Me.txt_account_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_id.Enabled = False
        Me.txt_account_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_id.ispk = False
        Me.txt_account_id.Location = New System.Drawing.Point(421, 29)
        Me.txt_account_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.MultiLine = False
        Me.txt_account_id.Name = "txt_account_id"
        Me.txt_account_id.NoClear = False
        Me.txt_account_id.NumberFormat = "@"
        Me.txt_account_id.Required = False
        Me.txt_account_id.RowData = Nothing
        Me.txt_account_id.SelectionLength = 0
        Me.txt_account_id.SelectionStart = 0
        Me.txt_account_id.Size = New System.Drawing.Size(36, 20)
        Me.txt_account_id.TabIndex = 1
        Me.txt_account_id.TableData = Nothing
        Me.txt_account_id.Tag = "main_id"
        Me.txt_account_id.TextSource = ""
        Me.txt_account_id.UseSystemPasswordChar = False
        Me.txt_account_id.Value = ""
        Me.txt_account_id.ValueSource = ""
        Me.txt_account_id.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(5, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 110
        Me.Label8.Tag = "label"
        Me.Label8.Text = "Code"
        '
        'txt_date
        '
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date.Location = New System.Drawing.Point(273, 27)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(100, 20)
        Me.txt_date.TabIndex = 5
        '
        'txt_account_name
        '
        Me.txt_account_name._Text = ""
        Me.txt_account_name.AllowNegative = False
        Me.txt_account_name.AlwaysDisable = False
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
        Me.txt_account_name.Location = New System.Drawing.Point(273, 3)
        Me.txt_account_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.MultiLine = False
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = True
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.SelectionLength = 0
        Me.txt_account_name.SelectionStart = 0
        Me.txt_account_name.Size = New System.Drawing.Size(384, 20)
        Me.txt_account_name.TabIndex = 3
        Me.txt_account_name.TableData = Nothing
        Me.txt_account_name.TextSource = ""
        Me.txt_account_name.UseSystemPasswordChar = False
        Me.txt_account_name.Value = ""
        Me.txt_account_name.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Date"
        '
        'txt_account_code
        '
        Me.txt_account_code._Text = ""
        Me.txt_account_code.AllowNegative = False
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
        Me.txt_account_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_code.ispk = False
        Me.txt_account_code.Location = New System.Drawing.Point(49, 3)
        Me.txt_account_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_code.MultiLine = False
        Me.txt_account_code.Name = "txt_account_code"
        Me.txt_account_code.NoClear = False
        Me.txt_account_code.NumberFormat = "@"
        Me.txt_account_code.Required = True
        Me.txt_account_code.RowData = Nothing
        Me.txt_account_code.SelectionLength = 0
        Me.txt_account_code.SelectionStart = 0
        Me.txt_account_code.Size = New System.Drawing.Size(170, 20)
        Me.txt_account_code.TabIndex = 2
        Me.txt_account_code.TableData = Nothing
        Me.txt_account_code.Tag = "focus"
        Me.txt_account_code.TextSource = ""
        Me.txt_account_code.UseSystemPasswordChar = False
        Me.txt_account_code.Value = ""
        Me.txt_account_code.ValueSource = ""
        '
        'txt_chart_class_id
        '
        Me.txt_chart_class_id._Text = ""
        Me.txt_chart_class_id.AllowNegative = False
        Me.txt_chart_class_id.AlwaysDisable = False
        Me.txt_chart_class_id.AlwaysEnable = False
        Me.txt_chart_class_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_class_id.BorderColor = System.Drawing.Color.White
        Me.txt_chart_class_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chart_class_id.DataSource = ""
        Me.txt_chart_class_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_class_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_class_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_chart_class_id.Enabled = False
        Me.txt_chart_class_id.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_chart_class_id.ispk = False
        Me.txt_chart_class_id.Location = New System.Drawing.Point(49, 27)
        Me.txt_chart_class_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_class_id.MultiLine = False
        Me.txt_chart_class_id.Name = "txt_chart_class_id"
        Me.txt_chart_class_id.NoClear = False
        Me.txt_chart_class_id.NumberFormat = "@"
        Me.txt_chart_class_id.Required = True
        Me.txt_chart_class_id.RowData = Nothing
        Me.txt_chart_class_id.SelectionLength = 0
        Me.txt_chart_class_id.SelectionStart = 0
        Me.txt_chart_class_id.Size = New System.Drawing.Size(170, 20)
        Me.txt_chart_class_id.TabIndex = 4
        Me.txt_chart_class_id.TableData = Nothing
        Me.txt_chart_class_id.TextSource = "chart_class_name"
        Me.txt_chart_class_id.UseSystemPasswordChar = False
        Me.txt_chart_class_id.Value = ""
        Me.txt_chart_class_id.ValueSource = "chart_class_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Class"
        '
        'txt_validation
        '
        Me.txt_validation.Controls.Add(Me.Rdo_button11)
        Me.txt_validation.Controls.Add(Me.Rdo_button10)
        Me.txt_validation.Controls.Add(Me.Rdo_button9)
        Me.txt_validation.Controls.Add(Me.Rdo_button12)
        Me.txt_validation.Controls.Add(Me.Rdo_button8)
        Me.txt_validation.Controls.Add(Me.Rdo_button7)
        Me.txt_validation.Controls.Add(Me.Rdo_button6)
        Me.txt_validation.Controls.Add(Me.Rdo_button5)
        Me.txt_validation.Controls.Add(Me.Rdo_button4)
        Me.txt_validation.Controls.Add(Me.Rdo_button3)
        Me.txt_validation.Controls.Add(Me.Rdo_button2)
        Me.txt_validation.Controls.Add(Me.Rdo_button1)
        Me.txt_validation.Location = New System.Drawing.Point(3, 46)
        Me.txt_validation.Name = "txt_validation"
        Me.txt_validation.Size = New System.Drawing.Size(654, 63)
        Me.txt_validation.TabIndex = 6
        Me.txt_validation.TabStop = False
        Me.txt_validation.Text = "Validation"
        '
        'txt_input_vat_importation
        '
        Me.txt_input_vat_importation.AutoSize = True
        Me.txt_input_vat_importation.Location = New System.Drawing.Point(181, 112)
        Me.txt_input_vat_importation.Name = "txt_input_vat_importation"
        Me.txt_input_vat_importation.Size = New System.Drawing.Size(96, 17)
        Me.txt_input_vat_importation.TabIndex = 19
        Me.txt_input_vat_importation.Tag = "13"
        Me.txt_input_vat_importation.Text = "For Importation"
        Me.txt_input_vat_importation.UseVisualStyleBackColor = True
        '
        'Rdo_button11
        '
        Me.Rdo_button11.AutoSize = True
        Me.Rdo_button11.DataSource = ""
        Me.Rdo_button11.Location = New System.Drawing.Point(424, 40)
        Me.Rdo_button11.Name = "Rdo_button11"
        Me.Rdo_button11.Size = New System.Drawing.Size(115, 17)
        Me.Rdo_button11.TabIndex = 18
        Me.Rdo_button11.TabStop = True
        Me.Rdo_button11.Text = "Purchase Discount"
        Me.Rdo_button11.TextSource = ""
        Me.Rdo_button11.Uncheckable = True
        Me.Rdo_button11.UseVisualStyleBackColor = True
        Me.Rdo_button11.Value = "12"
        Me.Rdo_button11.ValueSource = ""
        '
        'Rdo_button10
        '
        Me.Rdo_button10.AutoSize = True
        Me.Rdo_button10.DataSource = ""
        Me.Rdo_button10.Location = New System.Drawing.Point(339, 40)
        Me.Rdo_button10.Name = "Rdo_button10"
        Me.Rdo_button10.Size = New System.Drawing.Size(84, 17)
        Me.Rdo_button10.TabIndex = 16
        Me.Rdo_button10.TabStop = True
        Me.Rdo_button10.Text = "Gain or Loss"
        Me.Rdo_button10.TextSource = ""
        Me.Rdo_button10.Uncheckable = True
        Me.Rdo_button10.UseVisualStyleBackColor = True
        Me.Rdo_button10.Value = "10"
        Me.Rdo_button10.ValueSource = ""
        '
        'Rdo_button9
        '
        Me.Rdo_button9.AutoSize = True
        Me.Rdo_button9.DataSource = ""
        Me.Rdo_button9.Location = New System.Drawing.Point(339, 17)
        Me.Rdo_button9.Name = "Rdo_button9"
        Me.Rdo_button9.Size = New System.Drawing.Size(79, 17)
        Me.Rdo_button9.TabIndex = 15
        Me.Rdo_button9.TabStop = True
        Me.Rdo_button9.Text = "Fixed Asset"
        Me.Rdo_button9.TextSource = ""
        Me.Rdo_button9.Uncheckable = True
        Me.Rdo_button9.UseVisualStyleBackColor = True
        Me.Rdo_button9.Value = "9"
        Me.Rdo_button9.ValueSource = ""
        '
        'Rdo_button12
        '
        Me.Rdo_button12.AutoSize = True
        Me.Rdo_button12.DataSource = ""
        Me.Rdo_button12.Location = New System.Drawing.Point(424, 17)
        Me.Rdo_button12.Name = "Rdo_button12"
        Me.Rdo_button12.Size = New System.Drawing.Size(96, 17)
        Me.Rdo_button12.TabIndex = 17
        Me.Rdo_button12.TabStop = True
        Me.Rdo_button12.Text = "Sales Discount"
        Me.Rdo_button12.TextSource = ""
        Me.Rdo_button12.Uncheckable = True
        Me.Rdo_button12.UseVisualStyleBackColor = True
        Me.Rdo_button12.Value = "11"
        Me.Rdo_button12.ValueSource = ""
        '
        'Rdo_button8
        '
        Me.Rdo_button8.AutoSize = True
        Me.Rdo_button8.DataSource = ""
        Me.Rdo_button8.Location = New System.Drawing.Point(252, 40)
        Me.Rdo_button8.Name = "Rdo_button8"
        Me.Rdo_button8.Size = New System.Drawing.Size(81, 17)
        Me.Rdo_button8.TabIndex = 14
        Me.Rdo_button8.TabStop = True
        Me.Rdo_button8.Text = "Prepayment"
        Me.Rdo_button8.TextSource = ""
        Me.Rdo_button8.Uncheckable = True
        Me.Rdo_button8.UseVisualStyleBackColor = True
        Me.Rdo_button8.Value = "8"
        Me.Rdo_button8.ValueSource = ""
        '
        'Rdo_button7
        '
        Me.Rdo_button7.AutoSize = True
        Me.Rdo_button7.DataSource = ""
        Me.Rdo_button7.Location = New System.Drawing.Point(252, 17)
        Me.Rdo_button7.Name = "Rdo_button7"
        Me.Rdo_button7.Size = New System.Drawing.Size(76, 17)
        Me.Rdo_button7.TabIndex = 13
        Me.Rdo_button7.TabStop = True
        Me.Rdo_button7.Text = "Output Vat"
        Me.Rdo_button7.TextSource = ""
        Me.Rdo_button7.Uncheckable = True
        Me.Rdo_button7.UseVisualStyleBackColor = True
        Me.Rdo_button7.Value = "7"
        Me.Rdo_button7.ValueSource = ""
        '
        'Rdo_button6
        '
        Me.Rdo_button6.AutoSize = True
        Me.Rdo_button6.DataSource = ""
        Me.Rdo_button6.Location = New System.Drawing.Point(178, 40)
        Me.Rdo_button6.Name = "Rdo_button6"
        Me.Rdo_button6.Size = New System.Drawing.Size(68, 17)
        Me.Rdo_button6.TabIndex = 12
        Me.Rdo_button6.TabStop = True
        Me.Rdo_button6.Text = "Input Vat"
        Me.Rdo_button6.TextSource = ""
        Me.Rdo_button6.Uncheckable = True
        Me.Rdo_button6.UseVisualStyleBackColor = True
        Me.Rdo_button6.Value = "6"
        Me.Rdo_button6.ValueSource = ""
        '
        'Rdo_button5
        '
        Me.Rdo_button5.AutoSize = True
        Me.Rdo_button5.DataSource = ""
        Me.Rdo_button5.Location = New System.Drawing.Point(178, 17)
        Me.Rdo_button5.Name = "Rdo_button5"
        Me.Rdo_button5.Size = New System.Drawing.Size(68, 17)
        Me.Rdo_button5.TabIndex = 11
        Me.Rdo_button5.TabStop = True
        Me.Rdo_button5.Text = "Final Tax"
        Me.Rdo_button5.TextSource = ""
        Me.Rdo_button5.Uncheckable = True
        Me.Rdo_button5.UseVisualStyleBackColor = True
        Me.Rdo_button5.Value = "5"
        Me.Rdo_button5.ValueSource = ""
        '
        'Rdo_button4
        '
        Me.Rdo_button4.AutoSize = True
        Me.Rdo_button4.DataSource = ""
        Me.Rdo_button4.Location = New System.Drawing.Point(122, 40)
        Me.Rdo_button4.Name = "Rdo_button4"
        Me.Rdo_button4.Size = New System.Drawing.Size(50, 17)
        Me.Rdo_button4.TabIndex = 10
        Me.Rdo_button4.TabStop = True
        Me.Rdo_button4.Text = "EWT"
        Me.Rdo_button4.TextSource = ""
        Me.Rdo_button4.Uncheckable = True
        Me.Rdo_button4.UseVisualStyleBackColor = True
        Me.Rdo_button4.Value = "4"
        Me.Rdo_button4.ValueSource = ""
        '
        'Rdo_button3
        '
        Me.Rdo_button3.AutoSize = True
        Me.Rdo_button3.DataSource = ""
        Me.Rdo_button3.Location = New System.Drawing.Point(122, 17)
        Me.Rdo_button3.Name = "Rdo_button3"
        Me.Rdo_button3.Size = New System.Drawing.Size(39, 17)
        Me.Rdo_button3.TabIndex = 9
        Me.Rdo_button3.TabStop = True
        Me.Rdo_button3.Text = "AP"
        Me.Rdo_button3.TextSource = ""
        Me.Rdo_button3.Uncheckable = True
        Me.Rdo_button3.UseVisualStyleBackColor = True
        Me.Rdo_button3.Value = "3"
        Me.Rdo_button3.ValueSource = ""
        '
        'Rdo_button2
        '
        Me.Rdo_button2.AutoSize = True
        Me.Rdo_button2.DataSource = ""
        Me.Rdo_button2.Location = New System.Drawing.Point(31, 40)
        Me.Rdo_button2.Name = "Rdo_button2"
        Me.Rdo_button2.Size = New System.Drawing.Size(40, 17)
        Me.Rdo_button2.TabIndex = 8
        Me.Rdo_button2.TabStop = True
        Me.Rdo_button2.Text = "AR"
        Me.Rdo_button2.TextSource = ""
        Me.Rdo_button2.Uncheckable = True
        Me.Rdo_button2.UseVisualStyleBackColor = True
        Me.Rdo_button2.Value = "2"
        Me.Rdo_button2.ValueSource = ""
        '
        'Rdo_button1
        '
        Me.Rdo_button1.AutoSize = True
        Me.Rdo_button1.DataSource = ""
        Me.Rdo_button1.Location = New System.Drawing.Point(31, 17)
        Me.Rdo_button1.Name = "Rdo_button1"
        Me.Rdo_button1.Size = New System.Drawing.Size(85, 17)
        Me.Rdo_button1.TabIndex = 7
        Me.Rdo_button1.TabStop = True
        Me.Rdo_button1.Text = "Bank / Cash"
        Me.Rdo_button1.TextSource = ""
        Me.Rdo_button1.Uncheckable = True
        Me.Rdo_button1.UseVisualStyleBackColor = True
        Me.Rdo_button1.Value = "1"
        Me.Rdo_button1.ValueSource = ""
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(270, 225)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 23
        Me.btnPrint.TabStop = False
        Me.btnPrint.Tag = "btnPrint"
        Me.btnPrint.Text = "F5 Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'panelGroup
        '
        Me.panelGroup.AutoScroll = True
        Me.panelGroup.Controls.Add(Me.Button8)
        Me.panelGroup.Controls.Add(Me.Button9)
        Me.panelGroup.Controls.Add(Me.Button10)
        Me.panelGroup.Controls.Add(Me.Button6)
        Me.panelGroup.Controls.Add(Me.Button7)
        Me.panelGroup.Controls.Add(Me.Textbox6)
        Me.panelGroup.Controls.Add(Me.txt_chart_group_id)
        Me.panelGroup.Controls.Add(Me.Label27)
        Me.panelGroup.Controls.Add(Me.Label26)
        Me.panelGroup.Controls.Add(Me.dgGroup)
        Me.panelGroup.Controls.Add(Me.txt_chart_group_name)
        Me.panelGroup.Controls.Add(Me.txt_chart_group_code)
        Me.panelGroup.Location = New System.Drawing.Point(12, 387)
        Me.panelGroup.Name = "panelGroup"
        Me.panelGroup.Size = New System.Drawing.Size(659, 209)
        Me.panelGroup.TabIndex = 24
        Me.panelGroup.Tag = "subContainer"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(177, 159)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 24)
        Me.Button8.TabIndex = 28
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
        Me.Button9.Location = New System.Drawing.Point(91, 159)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 24)
        Me.Button9.TabIndex = 27
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
        Me.Button10.Location = New System.Drawing.Point(5, 159)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 24)
        Me.Button10.TabIndex = 26
        Me.Button10.Tag = "btn-sub-insert"
        Me.Button10.Text = "Insert"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(92, 159)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 24)
        Me.Button6.TabIndex = 30
        Me.Button6.Tag = "btn-sub-cancel"
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Green
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(6, 159)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 24)
        Me.Button7.TabIndex = 29
        Me.Button7.Tag = "btn-sub-ok"
        Me.Button7.Text = "OK"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Textbox6
        '
        Me.Textbox6._Text = ""
        Me.Textbox6.AllowNegative = False
        Me.Textbox6.AlwaysDisable = False
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
        Me.Textbox6.Location = New System.Drawing.Point(392, 159)
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
        'txt_chart_group_id
        '
        Me.txt_chart_group_id._Text = ""
        Me.txt_chart_group_id.AllowNegative = False
        Me.txt_chart_group_id.AlwaysDisable = False
        Me.txt_chart_group_id.AlwaysEnable = False
        Me.txt_chart_group_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_chart_group_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chart_group_id.DataSource = ""
        Me.txt_chart_group_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_chart_group_id.Enabled = False
        Me.txt_chart_group_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_chart_group_id.ispk = False
        Me.txt_chart_group_id.Location = New System.Drawing.Point(418, 159)
        Me.txt_chart_group_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_id.MultiLine = False
        Me.txt_chart_group_id.Name = "txt_chart_group_id"
        Me.txt_chart_group_id.NoClear = False
        Me.txt_chart_group_id.NumberFormat = "@"
        Me.txt_chart_group_id.Required = False
        Me.txt_chart_group_id.RowData = Nothing
        Me.txt_chart_group_id.SelectionLength = 0
        Me.txt_chart_group_id.SelectionStart = 0
        Me.txt_chart_group_id.Size = New System.Drawing.Size(125, 20)
        Me.txt_chart_group_id.TabIndex = 1
        Me.txt_chart_group_id.TableData = Nothing
        Me.txt_chart_group_id.Tag = "pk"
        Me.txt_chart_group_id.TextSource = ""
        Me.txt_chart_group_id.UseSystemPasswordChar = False
        Me.txt_chart_group_id.Value = ""
        Me.txt_chart_group_id.ValueSource = ""
        Me.txt_chart_group_id.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(160, 191)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 13)
        Me.Label27.TabIndex = 93
        Me.Label27.Text = "Description"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(5, 191)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 13)
        Me.Label26.TabIndex = 92
        Me.Label26.Text = "Group Code"
        '
        'dgGroup
        '
        Me.dgGroup.AllowUserToAddRows = False
        Me.dgGroup.AllowUserToDeleteRows = False
        Me.dgGroup.AllowUserToResizeColumns = False
        Me.dgGroup.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGroup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.deleted, Me.chart_group_id, Me.group_id, Me.chart_group_code, Me.chart_group_name})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgGroup.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgGroup.Location = New System.Drawing.Point(3, 3)
        Me.dgGroup.MultiSelect = False
        Me.dgGroup.Name = "dgGroup"
        Me.dgGroup.RowHeadersVisible = False
        Me.dgGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGroup.Size = New System.Drawing.Size(653, 150)
        Me.dgGroup.TabIndex = 25
        Me.dgGroup.Tag = "sub-grid"
        '
        'sel1
        '
        Me.sel1.DataPropertyName = "sel1"
        Me.sel1.FalseValue = "False"
        Me.sel1.HeaderText = "Sel"
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sel1.TrueValue = "True"
        Me.sel1.Width = 30
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.deleted.Visible = False
        '
        'chart_group_id
        '
        Me.chart_group_id.DataPropertyName = "chart_group_id"
        Me.chart_group_id.HeaderText = "chart_group_id"
        Me.chart_group_id.Name = "chart_group_id"
        Me.chart_group_id.ReadOnly = True
        Me.chart_group_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.chart_group_id.Visible = False
        '
        'group_id
        '
        Me.group_id.DataPropertyName = "group_id"
        Me.group_id.HeaderText = "group_id"
        Me.group_id.Name = "group_id"
        Me.group_id.ReadOnly = True
        Me.group_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.group_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.group_id.Visible = False
        '
        'chart_group_code
        '
        Me.chart_group_code.DataPropertyName = "chart_group_code"
        Me.chart_group_code.HeaderText = "Group Code"
        Me.chart_group_code.Name = "chart_group_code"
        Me.chart_group_code.ReadOnly = True
        Me.chart_group_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.chart_group_code.Width = 150
        '
        'chart_group_name
        '
        Me.chart_group_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.chart_group_name.DataPropertyName = "chart_group_name"
        Me.chart_group_name.HeaderText = "Group Description"
        Me.chart_group_name.Name = "chart_group_name"
        Me.chart_group_name.ReadOnly = True
        Me.chart_group_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'txt_chart_group_name
        '
        Me.txt_chart_group_name._Text = ""
        Me.txt_chart_group_name.AllowNegative = False
        Me.txt_chart_group_name.AlwaysDisable = True
        Me.txt_chart_group_name.AlwaysEnable = False
        Me.txt_chart_group_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_chart_group_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chart_group_name.DataSource = ""
        Me.txt_chart_group_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_chart_group_name.Enabled = False
        Me.txt_chart_group_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_chart_group_name.ispk = False
        Me.txt_chart_group_name.Location = New System.Drawing.Point(223, 188)
        Me.txt_chart_group_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_name.MultiLine = False
        Me.txt_chart_group_name.Name = "txt_chart_group_name"
        Me.txt_chart_group_name.NoClear = False
        Me.txt_chart_group_name.NumberFormat = "@"
        Me.txt_chart_group_name.Required = False
        Me.txt_chart_group_name.RowData = Nothing
        Me.txt_chart_group_name.SelectionLength = 0
        Me.txt_chart_group_name.SelectionStart = 0
        Me.txt_chart_group_name.Size = New System.Drawing.Size(433, 19)
        Me.txt_chart_group_name.TabIndex = 4
        Me.txt_chart_group_name.TableData = Nothing
        Me.txt_chart_group_name.TextSource = ""
        Me.txt_chart_group_name.UseSystemPasswordChar = False
        Me.txt_chart_group_name.Value = ""
        Me.txt_chart_group_name.ValueSource = ""
        '
        'txt_chart_group_code
        '
        Me.txt_chart_group_code._Text = ""
        Me.txt_chart_group_code.AllowNegative = False
        Me.txt_chart_group_code.AlwaysDisable = False
        Me.txt_chart_group_code.AlwaysEnable = False
        Me.txt_chart_group_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_chart_group_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chart_group_code.DataSource = ""
        Me.txt_chart_group_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_chart_group_code.Enabled = False
        Me.txt_chart_group_code.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_chart_group_code.ispk = False
        Me.txt_chart_group_code.Location = New System.Drawing.Point(72, 188)
        Me.txt_chart_group_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_code.MultiLine = False
        Me.txt_chart_group_code.Name = "txt_chart_group_code"
        Me.txt_chart_group_code.NoClear = False
        Me.txt_chart_group_code.NumberFormat = "@"
        Me.txt_chart_group_code.Required = True
        Me.txt_chart_group_code.RowData = Nothing
        Me.txt_chart_group_code.SelectionLength = 0
        Me.txt_chart_group_code.SelectionStart = 0
        Me.txt_chart_group_code.Size = New System.Drawing.Size(80, 19)
        Me.txt_chart_group_code.TabIndex = 3
        Me.txt_chart_group_code.TableData = Nothing
        Me.txt_chart_group_code.Tag = "focus fk"
        Me.txt_chart_group_code.TextSource = "chart_group_code"
        Me.txt_chart_group_code.UseSystemPasswordChar = False
        Me.txt_chart_group_code.Value = ""
        Me.txt_chart_group_code.ValueSource = "group_id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(475, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Search"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(684, 28)
        Me.Myformheader1.TabIndex = 109
        '
        'txtsearch
        '
        Me.txtsearch._Text = ""
        Me.txtsearch.AllowNegative = False
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
        Me.txtsearch.Location = New System.Drawing.Point(522, 34)
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
        Me.txtsearch.TextSource = "account_code,account_name"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'primary_key
        '
        Me.primary_key._Text = ""
        Me.primary_key.AllowNegative = False
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
        Me.primary_key.Location = New System.Drawing.Point(228, 34)
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
        Me.primary_key.TabIndex = 35
        Me.primary_key.TableData = Nothing
        Me.primary_key.TextSource = ""
        Me.primary_key.UseSystemPasswordChar = False
        Me.primary_key.Value = ""
        Me.primary_key.ValueSource = "account_id"
        Me.primary_key.Visible = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(15, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(656, 2)
        Me.border1.TabIndex = 88
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 610)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.panelGroup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.primary_key)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "chart"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of Accounts"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.txt_validation.ResumeLayout(False)
        Me.txt_validation.PerformLayout()
        Me.panelGroup.ResumeLayout(False)
        Me.panelGroup.PerformLayout()
        CType(Me.dgGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents primary_key As user_control.textbox
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_chart_class_id As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_account_name As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_account_code As user_control.textbox
    Friend WithEvents panelGroup As System.Windows.Forms.Panel
    Friend WithEvents txt_validation As System.Windows.Forms.GroupBox
    Friend WithEvents Rdo_button10 As user_control.rdo_button
    Friend WithEvents Rdo_button9 As user_control.rdo_button
    Friend WithEvents Rdo_button8 As user_control.rdo_button
    Friend WithEvents Rdo_button7 As user_control.rdo_button
    Friend WithEvents Rdo_button6 As user_control.rdo_button
    Friend WithEvents Rdo_button5 As user_control.rdo_button
    Friend WithEvents Rdo_button4 As user_control.rdo_button
    Friend WithEvents Rdo_button3 As user_control.rdo_button
    Friend WithEvents Rdo_button2 As user_control.rdo_button
    Friend WithEvents Rdo_button1 As user_control.rdo_button
    Friend WithEvents Textbox6 As user_control.textbox
    Friend WithEvents txt_chart_group_id As user_control.textbox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dgGroup As System.Windows.Forms.DataGridView
    Friend WithEvents txt_chart_group_name As user_control.textbox
    Friend WithEvents txt_chart_group_code As user_control.textbox
    Friend WithEvents txt_account_id As user_control.textbox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chart_group_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents group_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_group_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_group_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents account_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_class_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rdo_button11 As user_control.rdo_button
    Friend WithEvents Rdo_button12 As user_control.rdo_button
    Friend WithEvents txt_unit_applicable As Windows.Forms.CheckBox
    Friend WithEvents txt_isRestatement As Windows.Forms.CheckBox
    Friend WithEvents txt_noCompute As Windows.Forms.CheckBox
    Friend WithEvents txt_input_vat_importation As Windows.Forms.CheckBox
End Class
