<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stagesetup
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboxAllHeader = New System.Windows.Forms.CheckBox()
        Me.border1 = New accounting.borderedlabel()
        Me.txt_stage_id = New user_control.textbox()
        Me.txt_stage_name = New user_control.textbox()
        Me.txt_stage_code = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsearch = New user_control.textbox()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_label = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.stage_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stage_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.gboxContainer.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Search"
        '
        'cboxAllHeader
        '
        Me.cboxAllHeader.AutoSize = True
        Me.cboxAllHeader.Location = New System.Drawing.Point(28, 80)
        Me.cboxAllHeader.Name = "cboxAllHeader"
        Me.cboxAllHeader.Size = New System.Drawing.Size(15, 14)
        Me.cboxAllHeader.TabIndex = 113
        Me.cboxAllHeader.UseVisualStyleBackColor = True
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(20, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(460, 2)
        Me.border1.TabIndex = 106
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_stage_id
        '
        Me.txt_stage_id._Text = ""
        Me.txt_stage_id.AlwaysDisable = False
        Me.txt_stage_id.AlwaysEnable = False
        Me.txt_stage_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_stage_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stage_id.DataSource = ""
        Me.txt_stage_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_id.Enabled = False
        Me.txt_stage_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_stage_id.ispk = False
        Me.txt_stage_id.Location = New System.Drawing.Point(6, 11)
        Me.txt_stage_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_id.MultiLine = False
        Me.txt_stage_id.Name = "txt_stage_id"
        Me.txt_stage_id.NoClear = False
        Me.txt_stage_id.NumberFormat = "@"
        Me.txt_stage_id.Required = False
        Me.txt_stage_id.RowData = Nothing
        Me.txt_stage_id.SelectionLength = 0
        Me.txt_stage_id.SelectionStart = 0
        Me.txt_stage_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_stage_id.TabIndex = 1
        Me.txt_stage_id.TableData = Nothing
        Me.txt_stage_id.TextSource = "stage_id"
        Me.txt_stage_id.UseSystemPasswordChar = False
        Me.txt_stage_id.Value = ""
        Me.txt_stage_id.ValueSource = "stage_id"
        Me.txt_stage_id.Visible = False
        '
        'txt_stage_name
        '
        Me.txt_stage_name._Text = ""
        Me.txt_stage_name.AlwaysDisable = False
        Me.txt_stage_name.AlwaysEnable = False
        Me.txt_stage_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_stage_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stage_name.DataSource = ""
        Me.txt_stage_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_name.Enabled = False
        Me.txt_stage_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_stage_name.ispk = False
        Me.txt_stage_name.Location = New System.Drawing.Point(59, 60)
        Me.txt_stage_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_name.MultiLine = False
        Me.txt_stage_name.Name = "txt_stage_name"
        Me.txt_stage_name.NoClear = False
        Me.txt_stage_name.NumberFormat = "@"
        Me.txt_stage_name.Required = True
        Me.txt_stage_name.RowData = Nothing
        Me.txt_stage_name.SelectionLength = 0
        Me.txt_stage_name.SelectionStart = 0
        Me.txt_stage_name.Size = New System.Drawing.Size(395, 20)
        Me.txt_stage_name.TabIndex = 3
        Me.txt_stage_name.TableData = Nothing
        Me.txt_stage_name.TextSource = "stage_name"
        Me.txt_stage_name.UseSystemPasswordChar = False
        Me.txt_stage_name.Value = ""
        Me.txt_stage_name.ValueSource = "stage_name"
        '
        'txt_stage_code
        '
        Me.txt_stage_code._Text = ""
        Me.txt_stage_code.AlwaysDisable = False
        Me.txt_stage_code.AlwaysEnable = False
        Me.txt_stage_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_stage_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stage_code.DataSource = ""
        Me.txt_stage_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_code.Enabled = False
        Me.txt_stage_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_stage_code.ispk = False
        Me.txt_stage_code.Location = New System.Drawing.Point(59, 34)
        Me.txt_stage_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_code.MultiLine = False
        Me.txt_stage_code.Name = "txt_stage_code"
        Me.txt_stage_code.NoClear = False
        Me.txt_stage_code.NumberFormat = "@"
        Me.txt_stage_code.Required = True
        Me.txt_stage_code.RowData = Nothing
        Me.txt_stage_code.SelectionLength = 0
        Me.txt_stage_code.SelectionStart = 0
        Me.txt_stage_code.Size = New System.Drawing.Size(395, 20)
        Me.txt_stage_code.TabIndex = 2
        Me.txt_stage_code.TableData = Nothing
        Me.txt_stage_code.Tag = "focus"
        Me.txt_stage_code.TextSource = "stage_code"
        Me.txt_stage_code.UseSystemPasswordChar = False
        Me.txt_stage_code.Value = ""
        Me.txt_stage_code.ValueSource = "stage_code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Code"
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
        Me.txtsearch.Location = New System.Drawing.Point(326, 40)
        Me.txtsearch.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.MultiLine = False
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.SelectionLength = 0
        Me.txtsearch.SelectionStart = 0
        Me.txtsearch.Size = New System.Drawing.Size(154, 20)
        Me.txtsearch.TabIndex = 115
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = ""
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.Label5)
        Me.gboxContainer.Controls.Add(Me.txt_label)
        Me.gboxContainer.Controls.Add(Me.Label4)
        Me.gboxContainer.Controls.Add(Me.txt_stage_id)
        Me.gboxContainer.Controls.Add(Me.txt_stage_name)
        Me.gboxContainer.Controls.Add(Me.txt_stage_code)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Location = New System.Drawing.Point(20, 264)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(460, 127)
        Me.gboxContainer.TabIndex = 104
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(46, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(46, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(46, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "*"
        '
        'txt_label
        '
        Me.txt_label._Text = ""
        Me.txt_label.AlwaysDisable = False
        Me.txt_label.AlwaysEnable = False
        Me.txt_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_label.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_label.DataSource = ""
        Me.txt_label.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_label.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_label.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_label.Enabled = False
        Me.txt_label.EnabledBackColor = System.Drawing.Color.White
        Me.txt_label.ispk = False
        Me.txt_label.Location = New System.Drawing.Point(59, 86)
        Me.txt_label.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_label.MultiLine = False
        Me.txt_label.Name = "txt_label"
        Me.txt_label.NoClear = False
        Me.txt_label.NumberFormat = "@"
        Me.txt_label.Required = True
        Me.txt_label.RowData = Nothing
        Me.txt_label.SelectionLength = 0
        Me.txt_label.SelectionStart = 0
        Me.txt_label.Size = New System.Drawing.Size(395, 20)
        Me.txt_label.TabIndex = 4
        Me.txt_label.TableData = Nothing
        Me.txt_label.TextSource = "label"
        Me.txt_label.UseSystemPasswordChar = False
        Me.txt_label.Value = ""
        Me.txt_label.ValueSource = "label"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Label"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.stage_id, Me.stage_code, Me.stage_name})
        Me.dgMain.Location = New System.Drawing.Point(20, 72)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(460, 156)
        Me.dgMain.TabIndex = 112
        Me.dgMain.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.Width = 30
        '
        'stage_id
        '
        Me.stage_id.DataPropertyName = "stage_id"
        Me.stage_id.HeaderText = "ID"
        Me.stage_id.Name = "stage_id"
        Me.stage_id.ReadOnly = True
        Me.stage_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stage_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.stage_id.Visible = False
        '
        'stage_code
        '
        Me.stage_code.DataPropertyName = "stage_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stage_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.stage_code.HeaderText = "Code"
        Me.stage_code.Name = "stage_code"
        Me.stage_code.ReadOnly = True
        Me.stage_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stage_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'stage_name
        '
        Me.stage_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stage_name.DataPropertyName = "stage_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.stage_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.stage_name.HeaderText = "Stage Name"
        Me.stage_name.Name = "stage_name"
        Me.stage_name.ReadOnly = True
        Me.stage_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stage_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 234)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 111
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
        Me.btnSave.Location = New System.Drawing.Point(12, 234)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 110
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
        Me.btnRemove.Location = New System.Drawing.Point(184, 234)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 109
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
        Me.btnUpdate.Location = New System.Drawing.Point(98, 234)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 108
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
        Me.btnInsert.Location = New System.Drawing.Point(12, 234)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 107
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Stage Setup"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 116
        '
        'stagesetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 404)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboxAllHeader)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.txtsearch)
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
        Me.Name = "stagesetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stage Setup"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboxAllHeader As System.Windows.Forms.CheckBox
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents txt_stage_id As user_control.textbox
    Friend WithEvents txt_stage_name As user_control.textbox
    Friend WithEvents txt_stage_code As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_label As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents stage_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stage_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stage_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
