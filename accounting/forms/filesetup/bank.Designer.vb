<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bank
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_bank_id = New user_control.textbox()
        Me.txt_bank_name = New user_control.textbox()
        Me.txt_bank_code = New user_control.textbox()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_file_path = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bank_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearch = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReportDesigner = New System.Windows.Forms.Button()
        Me.od = New System.Windows.Forms.OpenFileDialog()
        Me.border1 = New accounting.borderedlabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Myformheader1 = New user_control.myformheader()
        Me.gboxContainer.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_bank_id
        '
        Me.txt_bank_id._Text = ""
        Me.txt_bank_id.AlwaysDisable = False
        Me.txt_bank_id.AlwaysEnable = False
        Me.txt_bank_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bank_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_id.DataSource = ""
        Me.txt_bank_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_id.Enabled = False
        Me.txt_bank_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank_id.ispk = False
        Me.txt_bank_id.Location = New System.Drawing.Point(1, 1)
        Me.txt_bank_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_id.MultiLine = False
        Me.txt_bank_id.Name = "txt_bank_id"
        Me.txt_bank_id.NoClear = False
        Me.txt_bank_id.NumberFormat = "@"
        Me.txt_bank_id.Required = False
        Me.txt_bank_id.RowData = Nothing
        Me.txt_bank_id.SelectionLength = 0
        Me.txt_bank_id.SelectionStart = 0
        Me.txt_bank_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_bank_id.TabIndex = 1
        Me.txt_bank_id.TableData = Nothing
        Me.txt_bank_id.TextSource = ""
        Me.txt_bank_id.UseSystemPasswordChar = False
        Me.txt_bank_id.Value = ""
        Me.txt_bank_id.ValueSource = ""
        Me.txt_bank_id.Visible = False
        '
        'txt_bank_name
        '
        Me.txt_bank_name._Text = ""
        Me.txt_bank_name.AlwaysDisable = False
        Me.txt_bank_name.AlwaysEnable = False
        Me.txt_bank_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bank_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_name.DataSource = ""
        Me.txt_bank_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_name.Enabled = False
        Me.txt_bank_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank_name.ispk = False
        Me.txt_bank_name.Location = New System.Drawing.Point(69, 43)
        Me.txt_bank_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_name.MultiLine = False
        Me.txt_bank_name.Name = "txt_bank_name"
        Me.txt_bank_name.NoClear = False
        Me.txt_bank_name.NumberFormat = "@"
        Me.txt_bank_name.Required = True
        Me.txt_bank_name.RowData = Nothing
        Me.txt_bank_name.SelectionLength = 0
        Me.txt_bank_name.SelectionStart = 0
        Me.txt_bank_name.Size = New System.Drawing.Size(400, 20)
        Me.txt_bank_name.TabIndex = 3
        Me.txt_bank_name.TableData = Nothing
        Me.txt_bank_name.TextSource = ""
        Me.txt_bank_name.UseSystemPasswordChar = False
        Me.txt_bank_name.Value = ""
        Me.txt_bank_name.ValueSource = ""
        '
        'txt_bank_code
        '
        Me.txt_bank_code._Text = ""
        Me.txt_bank_code.AlwaysDisable = False
        Me.txt_bank_code.AlwaysEnable = False
        Me.txt_bank_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bank_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_code.DataSource = ""
        Me.txt_bank_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_code.Enabled = False
        Me.txt_bank_code.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bank_code.ispk = False
        Me.txt_bank_code.Location = New System.Drawing.Point(69, 19)
        Me.txt_bank_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_code.MultiLine = False
        Me.txt_bank_code.Name = "txt_bank_code"
        Me.txt_bank_code.NoClear = False
        Me.txt_bank_code.NumberFormat = "@"
        Me.txt_bank_code.Required = True
        Me.txt_bank_code.RowData = Nothing
        Me.txt_bank_code.SelectionLength = 0
        Me.txt_bank_code.SelectionStart = 0
        Me.txt_bank_code.Size = New System.Drawing.Size(400, 20)
        Me.txt_bank_code.TabIndex = 2
        Me.txt_bank_code.TableData = Nothing
        Me.txt_bank_code.Tag = "focus"
        Me.txt_bank_code.TextSource = ""
        Me.txt_bank_code.UseSystemPasswordChar = False
        Me.txt_bank_code.Value = ""
        Me.txt_bank_code.ValueSource = ""
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.btnBrowse)
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.txt_file_path)
        Me.gboxContainer.Controls.Add(Me.Label4)
        Me.gboxContainer.Controls.Add(Me.Label9)
        Me.gboxContainer.Controls.Add(Me.txt_bank_name)
        Me.gboxContainer.Controls.Add(Me.txt_bank_code)
        Me.gboxContainer.Controls.Add(Me.txt_bank_id)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 261)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(476, 100)
        Me.gboxContainer.TabIndex = 69
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(56, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(56, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "*"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(432, 67)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(37, 20)
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Tag = "btnNotSave"
        Me.btnBrowse.Text = ". . ."
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(24, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 117
        Me.Label8.Tag = "label"
        Me.Label8.Text = "Name"
        '
        'txt_file_path
        '
        Me.txt_file_path._Text = ""
        Me.txt_file_path.AlwaysDisable = False
        Me.txt_file_path.AlwaysEnable = False
        Me.txt_file_path.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_file_path.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_file_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_file_path.DataSource = ""
        Me.txt_file_path.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_file_path.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_file_path.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_file_path.Enabled = False
        Me.txt_file_path.EnabledBackColor = System.Drawing.Color.White
        Me.txt_file_path.ispk = False
        Me.txt_file_path.Location = New System.Drawing.Point(69, 67)
        Me.txt_file_path.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_file_path.MultiLine = False
        Me.txt_file_path.Name = "txt_file_path"
        Me.txt_file_path.NoClear = False
        Me.txt_file_path.NumberFormat = "@"
        Me.txt_file_path.Required = True
        Me.txt_file_path.RowData = Nothing
        Me.txt_file_path.SelectionLength = 0
        Me.txt_file_path.SelectionStart = 0
        Me.txt_file_path.Size = New System.Drawing.Size(357, 20)
        Me.txt_file_path.TabIndex = 4
        Me.txt_file_path.TableData = Nothing
        Me.txt_file_path.TextSource = ""
        Me.txt_file_path.UseSystemPasswordChar = False
        Me.txt_file_path.Value = ""
        Me.txt_file_path.ValueSource = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Template"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(34, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 116
        Me.Label9.Tag = "label"
        Me.Label9.Text = "Code"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.deleted, Me.bank_id, Me.bank_code, Me.bank_name})
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
        Me.dgMain.Size = New System.Drawing.Size(476, 156)
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
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.deleted.Visible = False
        '
        'bank_id
        '
        Me.bank_id.DataPropertyName = "bank_id"
        Me.bank_id.HeaderText = "ID"
        Me.bank_id.Name = "bank_id"
        Me.bank_id.ReadOnly = True
        Me.bank_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bank_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bank_id.Visible = False
        '
        'bank_code
        '
        Me.bank_code.DataPropertyName = "bank_code"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_code.DefaultCellStyle = DataGridViewCellStyle3
        Me.bank_code.HeaderText = "Code"
        Me.bank_code.Name = "bank_code"
        Me.bank_code.ReadOnly = True
        Me.bank_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bank_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bank_name
        '
        Me.bank_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bank_name.DataPropertyName = "bank_name"
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.bank_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.bank_name.HeaderText = "Bank Name"
        Me.bank_name.Name = "bank_name"
        Me.bank_name.ReadOnly = True
        Me.bank_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bank_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 232)
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
        Me.btnSave.Location = New System.Drawing.Point(12, 232)
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
        Me.btnRemove.Location = New System.Drawing.Point(184, 232)
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
        Me.btnUpdate.Location = New System.Drawing.Point(98, 232)
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
        Me.btnInsert.Location = New System.Drawing.Point(12, 232)
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
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Bank Setup"
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
        Me.txtsearch.TextSource = "bank_code,bank_name"
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
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Search"
        '
        'btnReportDesigner
        '
        Me.btnReportDesigner.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnReportDesigner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnReportDesigner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnReportDesigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportDesigner.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportDesigner.ForeColor = System.Drawing.Color.White
        Me.btnReportDesigner.Location = New System.Drawing.Point(368, 232)
        Me.btnReportDesigner.Name = "btnReportDesigner"
        Me.btnReportDesigner.Size = New System.Drawing.Size(120, 24)
        Me.btnReportDesigner.TabIndex = 102
        Me.btnReportDesigner.Tag = "btnInsert"
        Me.btnReportDesigner.Text = "Report Designer"
        Me.btnReportDesigner.UseVisualStyleBackColor = False
        '
        'od
        '
        Me.od.DefaultExt = "Report Files (*.repx)|*.repx"
        Me.od.FileName = "od"
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
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 103
        '
        'bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 370)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnReportDesigner)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bank"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents txt_bank_id As user_control.textbox
    Friend WithEvents txt_bank_name As user_control.textbox
    Friend WithEvents txt_bank_code As user_control.textbox
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents bank_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnReportDesigner As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txt_file_path As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents od As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
