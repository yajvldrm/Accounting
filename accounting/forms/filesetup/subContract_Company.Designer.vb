<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subContract_Company
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
        Me.components = New System.ComponentModel.Container()
        Me.txtsearch = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Myformheader1 = New user_control.myformheader()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet()
        Me.dt_subcon = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.txt_subcon_name = New user_control.textbox()
        Me.txt_subcon_code = New user_control.textbox()
        Me.txt_subcon_id = New user_control.textbox()
        Me.border1 = New accounting.borderedlabel()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.subConid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subconCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subconname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_subcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxContainer.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtsearch.ispk = True
        Me.txtsearch.Location = New System.Drawing.Point(336, 37)
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
        Me.txtsearch.TabIndex = 103
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = "subconcode,subconname"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(292, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "SubCon Company"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(182, 226)
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
        Me.btnUpdate.Location = New System.Drawing.Point(96, 226)
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
        Me.btnInsert.Location = New System.Drawing.Point(10, 226)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 107
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(96, 226)
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
        Me.btnSave.Location = New System.Drawing.Point(10, 226)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 110
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 114
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.AutoGenerateColumns = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeight = 28
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.subConid, Me.subconCode, Me.subconname})
        Me.dgMain.DataSource = Me.bs
        Me.dgMain.Location = New System.Drawing.Point(10, 72)
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
        Me.dgMain.TabIndex = 112
        Me.dgMain.Tag = "maingrid"
        '
        'bs
        '
        Me.bs.DataMember = "dt_subcon"
        Me.bs.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.dt_subcon})
        '
        'dt_subcon
        '
        Me.dt_subcon.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.dt_subcon.TableName = "dt_subcon"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "subConid"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "subconCode"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "subconname"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sel"
        Me.DataColumn4.DataType = GetType(Boolean)
        Me.DataColumn4.DefaultValue = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(45, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(45, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(13, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Tag = "label"
        Me.Label8.Text = "Code"
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.Label5)
        Me.gboxContainer.Controls.Add(Me.txt_subcon_name)
        Me.gboxContainer.Controls.Add(Me.Label4)
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.txt_subcon_code)
        Me.gboxContainer.Controls.Add(Me.txt_subcon_id)
        Me.gboxContainer.Location = New System.Drawing.Point(10, 255)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(476, 75)
        Me.gboxContainer.TabIndex = 104
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'txt_subcon_name
        '
        Me.txt_subcon_name._Text = ""
        Me.txt_subcon_name.AllowNegative = False
        Me.txt_subcon_name.AlwaysDisable = False
        Me.txt_subcon_name.AlwaysEnable = False
        Me.txt_subcon_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subcon_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_subcon_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subcon_name.DataSource = ""
        Me.txt_subcon_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subcon_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subcon_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_subcon_name.Enabled = False
        Me.txt_subcon_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_subcon_name.ispk = False
        Me.txt_subcon_name.Location = New System.Drawing.Point(58, 39)
        Me.txt_subcon_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subcon_name.MultiLine = False
        Me.txt_subcon_name.Name = "txt_subcon_name"
        Me.txt_subcon_name.NoClear = False
        Me.txt_subcon_name.NumberFormat = "@"
        Me.txt_subcon_name.Required = True
        Me.txt_subcon_name.RowData = Nothing
        Me.txt_subcon_name.SelectionLength = 0
        Me.txt_subcon_name.SelectionStart = 0
        Me.txt_subcon_name.Size = New System.Drawing.Size(400, 20)
        Me.txt_subcon_name.TabIndex = 3
        Me.txt_subcon_name.TableData = Nothing
        Me.txt_subcon_name.TextSource = ""
        Me.txt_subcon_name.UseSystemPasswordChar = False
        Me.txt_subcon_name.Value = ""
        Me.txt_subcon_name.ValueSource = ""
        '
        'txt_subcon_code
        '
        Me.txt_subcon_code._Text = ""
        Me.txt_subcon_code.AllowNegative = False
        Me.txt_subcon_code.AlwaysDisable = False
        Me.txt_subcon_code.AlwaysEnable = False
        Me.txt_subcon_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subcon_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_subcon_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subcon_code.DataSource = ""
        Me.txt_subcon_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subcon_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subcon_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_subcon_code.Enabled = False
        Me.txt_subcon_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_subcon_code.ispk = False
        Me.txt_subcon_code.Location = New System.Drawing.Point(58, 13)
        Me.txt_subcon_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subcon_code.MultiLine = False
        Me.txt_subcon_code.Name = "txt_subcon_code"
        Me.txt_subcon_code.NoClear = False
        Me.txt_subcon_code.NumberFormat = "@"
        Me.txt_subcon_code.Required = True
        Me.txt_subcon_code.RowData = Nothing
        Me.txt_subcon_code.SelectionLength = 0
        Me.txt_subcon_code.SelectionStart = 0
        Me.txt_subcon_code.Size = New System.Drawing.Size(400, 20)
        Me.txt_subcon_code.TabIndex = 2
        Me.txt_subcon_code.TableData = Nothing
        Me.txt_subcon_code.Tag = "subconCode"
        Me.txt_subcon_code.TextSource = ""
        Me.txt_subcon_code.UseSystemPasswordChar = False
        Me.txt_subcon_code.Value = ""
        Me.txt_subcon_code.ValueSource = ""
        '
        'txt_subcon_id
        '
        Me.txt_subcon_id._Text = ""
        Me.txt_subcon_id.AllowNegative = False
        Me.txt_subcon_id.AlwaysDisable = False
        Me.txt_subcon_id.AlwaysEnable = False
        Me.txt_subcon_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subcon_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_subcon_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subcon_id.DataSource = ""
        Me.txt_subcon_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subcon_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subcon_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_subcon_id.Enabled = False
        Me.txt_subcon_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_subcon_id.ispk = False
        Me.txt_subcon_id.Location = New System.Drawing.Point(411, 0)
        Me.txt_subcon_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subcon_id.MultiLine = False
        Me.txt_subcon_id.Name = "txt_subcon_id"
        Me.txt_subcon_id.NoClear = False
        Me.txt_subcon_id.NumberFormat = "@"
        Me.txt_subcon_id.Required = False
        Me.txt_subcon_id.RowData = Nothing
        Me.txt_subcon_id.SelectionLength = 0
        Me.txt_subcon_id.SelectionStart = 0
        Me.txt_subcon_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_subcon_id.TabIndex = 1
        Me.txt_subcon_id.TableData = Nothing
        Me.txt_subcon_id.TextSource = ""
        Me.txt_subcon_id.UseSystemPasswordChar = False
        Me.txt_subcon_id.Value = ""
        Me.txt_subcon_id.ValueSource = ""
        Me.txt_subcon_id.Visible = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(11, 64)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(475, 2)
        Me.border1.TabIndex = 106
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'subConid
        '
        Me.subConid.DataPropertyName = "subConid"
        Me.subConid.HeaderText = "id"
        Me.subConid.Name = "subConid"
        Me.subConid.ReadOnly = True
        Me.subConid.Visible = False
        '
        'subconCode
        '
        Me.subconCode.DataPropertyName = "subconCode"
        Me.subconCode.HeaderText = "Code"
        Me.subconCode.Name = "subconCode"
        Me.subconCode.ReadOnly = True
        '
        'subconname
        '
        Me.subconname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subconname.DataPropertyName = "subconname"
        Me.subconname.HeaderText = "Name"
        Me.subconname.Name = "subconname"
        Me.subconname.ReadOnly = True
        '
        'subContract_Company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 340)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "subContract_Company"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub Contract Company"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_subcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents border1 As borderedlabel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents btnInsert As Windows.Forms.Button
    Friend WithEvents btnNotSave As Windows.Forms.Button
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents dgMain As Windows.Forms.DataGridView
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents gboxContainer As Windows.Forms.GroupBox
    Friend WithEvents txt_subcon_name As user_control.textbox
    Friend WithEvents txt_subcon_code As user_control.textbox
    Friend WithEvents txt_subcon_id As user_control.textbox
    Friend WithEvents dt_subcon As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Public WithEvents ds As DataSet
    Friend WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents subConid As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subconCode As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subconname As Windows.Forms.DataGridViewTextBoxColumn
End Class
