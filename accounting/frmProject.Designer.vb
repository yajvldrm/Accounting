<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProject
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.project_unit_no_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_unit_no_names = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_unit_no_codes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_project_unit_no = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.Searchtxt = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_project_unit_no_codes = New user_control.textbox()
        Me.txt_project_unit_no_names = New user_control.textbox()
        Me.txt_project_id = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_project_unit_no_id = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ProjectunitnocodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_project_unit_no, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(-2, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(531, 28)
        Me.Myformheader1.TabIndex = 1
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.project_unit_no_id, Me.project_unit_no_names, Me.project_unit_no_codes, Me.project_id, Me.project_name, Me.project_code})
        Me.dgMain.DataMember = "lib_erp_project_unit_no"
        Me.dgMain.DataSource = Me.ds
        Me.dgMain.Location = New System.Drawing.Point(17, 73)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(498, 150)
        Me.dgMain.TabIndex = 14
        Me.dgMain.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'project_unit_no_id
        '
        Me.project_unit_no_id.DataPropertyName = "project_unit_no_id"
        Me.project_unit_no_id.HeaderText = "project_unit_no_id"
        Me.project_unit_no_id.Name = "project_unit_no_id"
        Me.project_unit_no_id.Visible = False
        '
        'project_unit_no_names
        '
        Me.project_unit_no_names.DataPropertyName = "project_unit_no_names"
        Me.project_unit_no_names.HeaderText = "Name"
        Me.project_unit_no_names.Name = "project_unit_no_names"
        Me.project_unit_no_names.Width = 155
        '
        'project_unit_no_codes
        '
        Me.project_unit_no_codes.DataPropertyName = "project_unit_no_codes"
        Me.project_unit_no_codes.HeaderText = "Code"
        Me.project_unit_no_codes.Name = "project_unit_no_codes"
        Me.project_unit_no_codes.Width = 155
        '
        'project_id
        '
        Me.project_id.DataPropertyName = "project_id"
        Me.project_id.HeaderText = "project_id"
        Me.project_id.Name = "project_id"
        Me.project_id.Visible = False
        '
        'project_name
        '
        Me.project_name.DataPropertyName = "project_name"
        Me.project_name.HeaderText = "Project"
        Me.project_name.Name = "project_name"
        Me.project_name.Width = 155
        '
        'project_code
        '
        Me.project_code.DataPropertyName = "project_code"
        Me.project_code.HeaderText = "project_code"
        Me.project_code.Name = "project_code"
        Me.project_code.Visible = False
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_project_unit_no})
        '
        'lib_erp_project_unit_no
        '
        Me.lib_erp_project_unit_no.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.lib_erp_project_unit_no.TableName = "lib_erp_project_unit_no"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "project_unit_no_id"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "project_unit_no_names"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "project_unit_no_codes"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "project_id"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "project_name"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "project_code"
        '
        'Searchtxt
        '
        Me.Searchtxt._Text = ""
        Me.Searchtxt.AllowNegative = False
        Me.Searchtxt.AlwaysDisable = False
        Me.Searchtxt.AlwaysEnable = False
        Me.Searchtxt.BackColor = System.Drawing.Color.White
        Me.Searchtxt.BorderColor = System.Drawing.Color.DarkGray
        Me.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Searchtxt.DataSource = ""
        Me.Searchtxt.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Searchtxt.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Searchtxt.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.Searchtxt.EnabledBackColor = System.Drawing.Color.White
        Me.Searchtxt.ispk = False
        Me.Searchtxt.Location = New System.Drawing.Point(365, 44)
        Me.Searchtxt.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Searchtxt.MultiLine = False
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.NoClear = False
        Me.Searchtxt.NumberFormat = "@"
        Me.Searchtxt.Required = False
        Me.Searchtxt.RowData = Nothing
        Me.Searchtxt.SelectionLength = 0
        Me.Searchtxt.SelectionStart = 0
        Me.Searchtxt.Size = New System.Drawing.Size(150, 20)
        Me.Searchtxt.TabIndex = 13
        Me.Searchtxt.TableData = Nothing
        Me.Searchtxt.TextSource = "project_unit_no_codes,project_unit_no_names"
        Me.Searchtxt.UseSystemPasswordChar = False
        Me.Searchtxt.Value = ""
        Me.Searchtxt.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Search"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_project_unit_no_codes)
        Me.Panel1.Controls.Add(Me.txt_project_unit_no_names)
        Me.Panel1.Controls.Add(Me.txt_project_id)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_project_unit_no_id)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Panel1.Location = New System.Drawing.Point(17, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 105)
        Me.Panel1.TabIndex = 18
        Me.Panel1.Tag = "container"
        '
        'txt_project_unit_no_codes
        '
        Me.txt_project_unit_no_codes._Text = ""
        Me.txt_project_unit_no_codes.AllowNegative = False
        Me.txt_project_unit_no_codes.AlwaysDisable = False
        Me.txt_project_unit_no_codes.AlwaysEnable = False
        Me.txt_project_unit_no_codes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_unit_no_codes.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_unit_no_codes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_unit_no_codes.DataSource = ""
        Me.txt_project_unit_no_codes.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_unit_no_codes.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_unit_no_codes.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_unit_no_codes.Enabled = False
        Me.txt_project_unit_no_codes.EnabledBackColor = System.Drawing.Color.Empty
        Me.txt_project_unit_no_codes.ispk = False
        Me.txt_project_unit_no_codes.Location = New System.Drawing.Point(69, 12)
        Me.txt_project_unit_no_codes.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_unit_no_codes.MultiLine = False
        Me.txt_project_unit_no_codes.Name = "txt_project_unit_no_codes"
        Me.txt_project_unit_no_codes.NoClear = False
        Me.txt_project_unit_no_codes.NumberFormat = "@"
        Me.txt_project_unit_no_codes.Required = True
        Me.txt_project_unit_no_codes.RowData = Nothing
        Me.txt_project_unit_no_codes.SelectionLength = 0
        Me.txt_project_unit_no_codes.SelectionStart = 0
        Me.txt_project_unit_no_codes.Size = New System.Drawing.Size(400, 20)
        Me.txt_project_unit_no_codes.TabIndex = 6
        Me.txt_project_unit_no_codes.TableData = Nothing
        Me.txt_project_unit_no_codes.Tag = "focus"
        Me.txt_project_unit_no_codes.TextSource = ""
        Me.txt_project_unit_no_codes.UseSystemPasswordChar = False
        Me.txt_project_unit_no_codes.Value = ""
        Me.txt_project_unit_no_codes.ValueSource = ""
        '
        'txt_project_unit_no_names
        '
        Me.txt_project_unit_no_names._Text = ""
        Me.txt_project_unit_no_names.AllowNegative = False
        Me.txt_project_unit_no_names.AlwaysDisable = False
        Me.txt_project_unit_no_names.AlwaysEnable = False
        Me.txt_project_unit_no_names.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_unit_no_names.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_unit_no_names.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_unit_no_names.DataSource = ""
        Me.txt_project_unit_no_names.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_unit_no_names.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_unit_no_names.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_unit_no_names.Enabled = False
        Me.txt_project_unit_no_names.EnabledBackColor = System.Drawing.Color.Empty
        Me.txt_project_unit_no_names.ispk = False
        Me.txt_project_unit_no_names.Location = New System.Drawing.Point(69, 43)
        Me.txt_project_unit_no_names.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_unit_no_names.MultiLine = False
        Me.txt_project_unit_no_names.Name = "txt_project_unit_no_names"
        Me.txt_project_unit_no_names.NoClear = False
        Me.txt_project_unit_no_names.NumberFormat = "@"
        Me.txt_project_unit_no_names.Required = True
        Me.txt_project_unit_no_names.RowData = Nothing
        Me.txt_project_unit_no_names.SelectionLength = 0
        Me.txt_project_unit_no_names.SelectionStart = 0
        Me.txt_project_unit_no_names.Size = New System.Drawing.Size(400, 20)
        Me.txt_project_unit_no_names.TabIndex = 2
        Me.txt_project_unit_no_names.TableData = Nothing
        Me.txt_project_unit_no_names.Tag = ""
        Me.txt_project_unit_no_names.TextSource = ""
        Me.txt_project_unit_no_names.UseSystemPasswordChar = False
        Me.txt_project_unit_no_names.Value = ""
        Me.txt_project_unit_no_names.ValueSource = ""
        '
        'txt_project_id
        '
        Me.txt_project_id._Text = ""
        Me.txt_project_id.AllowNegative = False
        Me.txt_project_id.AlwaysDisable = False
        Me.txt_project_id.AlwaysEnable = False
        Me.txt_project_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_id.DataSource = ""
        Me.txt_project_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.Enabled = False
        Me.txt_project_id.EnabledBackColor = System.Drawing.Color.Empty
        Me.txt_project_id.ispk = False
        Me.txt_project_id.Location = New System.Drawing.Point(69, 73)
        Me.txt_project_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.MultiLine = False
        Me.txt_project_id.Name = "txt_project_id"
        Me.txt_project_id.NoClear = False
        Me.txt_project_id.NumberFormat = "@"
        Me.txt_project_id.Required = True
        Me.txt_project_id.RowData = Nothing
        Me.txt_project_id.SelectionLength = 0
        Me.txt_project_id.SelectionStart = 0
        Me.txt_project_id.Size = New System.Drawing.Size(400, 20)
        Me.txt_project_id.TabIndex = 3
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.Tag = ""
        Me.txt_project_id.TextSource = "project_name"
        Me.txt_project_id.UseSystemPasswordChar = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = "project_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(28, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(28, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Project"
        '
        'txt_project_unit_no_id
        '
        Me.txt_project_unit_no_id._Text = ""
        Me.txt_project_unit_no_id.AllowNegative = False
        Me.txt_project_unit_no_id.AlwaysDisable = False
        Me.txt_project_unit_no_id.AlwaysEnable = False
        Me.txt_project_unit_no_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_unit_no_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_unit_no_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_unit_no_id.DataSource = ""
        Me.txt_project_unit_no_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_unit_no_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_unit_no_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_unit_no_id.Enabled = False
        Me.txt_project_unit_no_id.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_project_unit_no_id.ispk = False
        Me.txt_project_unit_no_id.Location = New System.Drawing.Point(5, 5)
        Me.txt_project_unit_no_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_unit_no_id.MultiLine = False
        Me.txt_project_unit_no_id.Name = "txt_project_unit_no_id"
        Me.txt_project_unit_no_id.NoClear = False
        Me.txt_project_unit_no_id.NumberFormat = "@"
        Me.txt_project_unit_no_id.Required = False
        Me.txt_project_unit_no_id.RowData = Nothing
        Me.txt_project_unit_no_id.SelectionLength = 0
        Me.txt_project_unit_no_id.SelectionStart = 0
        Me.txt_project_unit_no_id.Size = New System.Drawing.Size(27, 10)
        Me.txt_project_unit_no_id.TabIndex = 0
        Me.txt_project_unit_no_id.TableData = Nothing
        Me.txt_project_unit_no_id.Tag = "focus"
        Me.txt_project_unit_no_id.TextSource = ""
        Me.txt_project_unit_no_id.UseSystemPasswordChar = False
        Me.txt_project_unit_no_id.Value = ""
        Me.txt_project_unit_no_id.ValueSource = ""
        Me.txt_project_unit_no_id.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(28, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Name"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(189, 230)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Delete"
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
        Me.btnInsert.Location = New System.Drawing.Point(16, 230)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 15
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Project Unit Setup"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(103, 230)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(103, 229)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 20
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
        Me.btnSave.Location = New System.Drawing.Point(17, 229)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ProjectunitnocodeDataGridViewTextBoxColumn
        '
        Me.ProjectunitnocodeDataGridViewTextBoxColumn.DataPropertyName = "project_unit_no_code"
        Me.ProjectunitnocodeDataGridViewTextBoxColumn.HeaderText = "project_unit_no_code"
        Me.ProjectunitnocodeDataGridViewTextBoxColumn.Name = "ProjectunitnocodeDataGridViewTextBoxColumn"
        '
        'frmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 380)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Searchtxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Unit Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_project_unit_no, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents dgMain As Windows.Forms.DataGridView
    Friend WithEvents Searchtxt As user_control.textbox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents txt_project_id As user_control.textbox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_project_unit_no_id As user_control.textbox
    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents btnInsert As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents btnNotSave As Windows.Forms.Button
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents ds As DataSet
    Friend WithEvents txt_project_unit_no_names As user_control.textbox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txt_project_unit_no_codes As user_control.textbox
    Friend WithEvents ProjectunitnocodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lib_erp_project_unit_no As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents project_unit_no_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_unit_no_names As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_unit_no_codes As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_code As Windows.Forms.DataGridViewTextBoxColumn
End Class
