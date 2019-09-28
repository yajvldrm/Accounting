<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chart_group
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
        Me.border1 = New accounting.borderedlabel()
        Me.txt_chart_group_id = New user_control.textbox()
        Me.txt_chart_group_name = New user_control.textbox()
        Me.txt_chart_group_code = New user_control.textbox()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chart_group_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_group_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_group_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearch = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.gboxContainer.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txt_chart_group_id
        '
        Me.txt_chart_group_id._Text = ""
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
        Me.txt_chart_group_id.Location = New System.Drawing.Point(6, 11)
        Me.txt_chart_group_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_id.MultiLine = False
        Me.txt_chart_group_id.Name = "txt_chart_group_id"
        Me.txt_chart_group_id.NoClear = False
        Me.txt_chart_group_id.NumberFormat = "@"
        Me.txt_chart_group_id.Required = False
        Me.txt_chart_group_id.RowData = Nothing
        Me.txt_chart_group_id.SelectionLength = 0
        Me.txt_chart_group_id.SelectionStart = 0
        Me.txt_chart_group_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_chart_group_id.TabIndex = 1
        Me.txt_chart_group_id.TableData = Nothing
        Me.txt_chart_group_id.TextSource = ""
        Me.txt_chart_group_id.UseSystemPasswordChar = False
        Me.txt_chart_group_id.Value = ""
        Me.txt_chart_group_id.ValueSource = ""
        Me.txt_chart_group_id.Visible = False
        '
        'txt_chart_group_name
        '
        Me.txt_chart_group_name._Text = ""
        Me.txt_chart_group_name.AlwaysDisable = False
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
        Me.txt_chart_group_name.Location = New System.Drawing.Point(57, 45)
        Me.txt_chart_group_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_name.MultiLine = False
        Me.txt_chart_group_name.Name = "txt_chart_group_name"
        Me.txt_chart_group_name.NoClear = False
        Me.txt_chart_group_name.NumberFormat = "@"
        Me.txt_chart_group_name.Required = True
        Me.txt_chart_group_name.RowData = Nothing
        Me.txt_chart_group_name.SelectionLength = 0
        Me.txt_chart_group_name.SelectionStart = 0
        Me.txt_chart_group_name.Size = New System.Drawing.Size(400, 20)
        Me.txt_chart_group_name.TabIndex = 3
        Me.txt_chart_group_name.TableData = Nothing
        Me.txt_chart_group_name.TextSource = ""
        Me.txt_chart_group_name.UseSystemPasswordChar = False
        Me.txt_chart_group_name.Value = ""
        Me.txt_chart_group_name.ValueSource = ""
        '
        'txt_chart_group_code
        '
        Me.txt_chart_group_code._Text = ""
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
        Me.txt_chart_group_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_chart_group_code.ispk = False
        Me.txt_chart_group_code.Location = New System.Drawing.Point(57, 19)
        Me.txt_chart_group_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_code.MultiLine = False
        Me.txt_chart_group_code.Name = "txt_chart_group_code"
        Me.txt_chart_group_code.NoClear = False
        Me.txt_chart_group_code.NumberFormat = "@"
        Me.txt_chart_group_code.Required = True
        Me.txt_chart_group_code.RowData = Nothing
        Me.txt_chart_group_code.SelectionLength = 0
        Me.txt_chart_group_code.SelectionStart = 0
        Me.txt_chart_group_code.Size = New System.Drawing.Size(400, 20)
        Me.txt_chart_group_code.TabIndex = 2
        Me.txt_chart_group_code.TableData = Nothing
        Me.txt_chart_group_code.Tag = "focus"
        Me.txt_chart_group_code.TextSource = ""
        Me.txt_chart_group_code.UseSystemPasswordChar = False
        Me.txt_chart_group_code.Value = ""
        Me.txt_chart_group_code.ValueSource = ""
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.txt_chart_group_name)
        Me.gboxContainer.Controls.Add(Me.Label5)
        Me.gboxContainer.Controls.Add(Me.txt_chart_group_code)
        Me.gboxContainer.Controls.Add(Me.Label4)
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.txt_chart_group_id)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 255)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(476, 75)
        Me.gboxContainer.TabIndex = 69
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(44, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(44, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(11, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(14, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Tag = "label"
        Me.Label8.Text = "Code"
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToOrderColumns = True
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeight = 28
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.chart_group_id, Me.chart_group_code, Me.chart_group_name})
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
        'sel1
        '
        Me.sel1.DataPropertyName = "sel1"
        Me.sel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel1.HeaderText = "Sel"
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.Width = 30
        '
        'chart_group_id
        '
        Me.chart_group_id.DataPropertyName = "chart_group_id"
        Me.chart_group_id.HeaderText = "ID"
        Me.chart_group_id.Name = "chart_group_id"
        Me.chart_group_id.ReadOnly = True
        Me.chart_group_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.chart_group_id.Visible = False
        '
        'chart_group_code
        '
        Me.chart_group_code.DataPropertyName = "chart_group_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chart_group_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.chart_group_code.HeaderText = "Code"
        Me.chart_group_code.Name = "chart_group_code"
        Me.chart_group_code.ReadOnly = True
        Me.chart_group_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'chart_group_name
        '
        Me.chart_group_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.chart_group_name.DataPropertyName = "chart_group_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.chart_group_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.chart_group_name.HeaderText = "Book Name"
        Me.chart_group_name.Name = "chart_group_name"
        Me.chart_group_name.ReadOnly = True
        Me.chart_group_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.Label1.Size = New System.Drawing.Size(206, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Chart Group Setup"
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
        Me.txtsearch.Location = New System.Drawing.Point(338, 34)
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
        Me.txtsearch.TextSource = "chart_group_code,chart_group_name"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Search"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 111
        '
        'chart_group
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 340)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "chart_group"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart Group Setup"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents txt_chart_group_id As user_control.textbox
    Friend WithEvents txt_chart_group_name As user_control.textbox
    Friend WithEvents txt_chart_group_code As user_control.textbox
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chart_group_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_group_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_group_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
