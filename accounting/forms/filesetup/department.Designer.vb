Imports user_control
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class department
    Inherits MyForm

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
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.txtsearch = New user_control.MyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MyTextBox3 = New user_control.MyTextBox()
        Me.MyTextBox2 = New user_control.MyTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyTextBox1 = New user_control.MyTextBox()
        Me.MyButton3 = New user_control.MyButton()
        Me.MyButton2 = New user_control.MyButton()
        Me.MyButton1 = New user_control.MyButton()
        Me.MyButton4 = New user_control.MyButton()
        Me.MyButton5 = New user_control.MyButton()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_department = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_department, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(475, 2)
        Me.border1.TabIndex = 80
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.department_id, Me.department_code, Me.department_name})
        Me.dgMain.DataSource = Me.ds
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
        Me.dgMain.TabIndex = 86
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
        'department_id
        '
        Me.department_id.DataPropertyName = "department_id"
        Me.department_id.HeaderText = "Department ID"
        Me.department_id.Name = "department_id"
        Me.department_id.ReadOnly = True
        Me.department_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.department_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.department_id.Visible = False
        '
        'department_code
        '
        Me.department_code.DataPropertyName = "department_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.department_code.HeaderText = "Code"
        Me.department_code.Name = "department_code"
        Me.department_code.ReadOnly = True
        Me.department_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.department_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'department_name
        '
        Me.department_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.department_name.DataPropertyName = "department_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.department_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.department_name.HeaderText = "Department Name"
        Me.department_name.Name = "department_name"
        Me.department_name.ReadOnly = True
        Me.department_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.department_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Department Setup"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 102
        '
        'txtsearch
        '
        Me.txtsearch.AlwaysDisable = False
        Me.txtsearch.AlwaysEnable = True
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.BrowseDataSource = ""
        Me.txtsearch.BrowseField = ""
        Me.txtsearch.BrowseFilter = Nothing
        Me.txtsearch.BrowseLabel = "Code,Name"
        Me.txtsearch.BrowseLabelWidth = "100,200"
        Me.txtsearch.BrowseTextSource = ""
        Me.txtsearch.BrowseValueSource = ""
        Me.txtsearch.Database = user_control.MyList.Database.FileSetup
        Me.txtsearch.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtsearch.Enabled = False
        Me.txtsearch.EnabledBackColor = System.Drawing.Color.White
        Me.txtsearch.EnabledForeColor = System.Drawing.Color.Black
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.ID = False
        Me.txtsearch.Location = New System.Drawing.Point(341, 39)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NoSave = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.Size = New System.Drawing.Size(147, 20)
        Me.txtsearch.TabIndex = 103
        Me.txtsearch.TextBrowse = False
        Me.txtsearch.TextSource = "department_code,department_name"
        Me.txtsearch.ToUpper = True
        Me.txtsearch.Unique = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MyTextBox3)
        Me.GroupBox1.Controls.Add(Me.MyTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MyTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 70)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        '
        'MyTextBox3
        '
        Me.MyTextBox3.AlwaysDisable = False
        Me.MyTextBox3.AlwaysEnable = False
        Me.MyTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox3.BrowseDataSource = ""
        Me.MyTextBox3.BrowseField = ""
        Me.MyTextBox3.BrowseFilter = Nothing
        Me.MyTextBox3.BrowseLabel = "Code,Name"
        Me.MyTextBox3.BrowseLabelWidth = "100,200"
        Me.MyTextBox3.BrowseTextSource = ""
        Me.MyTextBox3.BrowseValueSource = ""
        Me.MyTextBox3.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox3.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox3.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox3.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox3.Enabled = False
        Me.MyTextBox3.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox3.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox3.ID = False
        Me.MyTextBox3.Location = New System.Drawing.Point(52, 36)
        Me.MyTextBox3.Name = "MyTextBox3"
        Me.MyTextBox3.NoClear = False
        Me.MyTextBox3.NoSave = False
        Me.MyTextBox3.NumberFormat = "@"
        Me.MyTextBox3.Required = True
        Me.MyTextBox3.RowData = Nothing
        Me.MyTextBox3.Size = New System.Drawing.Size(411, 20)
        Me.MyTextBox3.TabIndex = 3
        Me.MyTextBox3.TextBrowse = False
        Me.MyTextBox3.TextSource = "department_name"
        Me.MyTextBox3.ToUpper = True
        Me.MyTextBox3.Unique = True
        Me.MyTextBox3.Value = ""
        Me.MyTextBox3.ValueSource = ""
        '
        'MyTextBox2
        '
        Me.MyTextBox2.AlwaysDisable = False
        Me.MyTextBox2.AlwaysEnable = False
        Me.MyTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox2.BrowseDataSource = ""
        Me.MyTextBox2.BrowseField = ""
        Me.MyTextBox2.BrowseFilter = Nothing
        Me.MyTextBox2.BrowseLabel = "Code,Name"
        Me.MyTextBox2.BrowseLabelWidth = "100,200"
        Me.MyTextBox2.BrowseTextSource = ""
        Me.MyTextBox2.BrowseValueSource = ""
        Me.MyTextBox2.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox2.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox2.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox2.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox2.Enabled = False
        Me.MyTextBox2.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox2.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox2.ID = False
        Me.MyTextBox2.Location = New System.Drawing.Point(52, 15)
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.NoClear = False
        Me.MyTextBox2.NoSave = False
        Me.MyTextBox2.NumberFormat = "@"
        Me.MyTextBox2.Required = True
        Me.MyTextBox2.RowData = Nothing
        Me.MyTextBox2.Size = New System.Drawing.Size(411, 20)
        Me.MyTextBox2.TabIndex = 2
        Me.MyTextBox2.TextBrowse = False
        Me.MyTextBox2.TextSource = "department_code"
        Me.MyTextBox2.ToUpper = True
        Me.MyTextBox2.Unique = True
        Me.MyTextBox2.Value = ""
        Me.MyTextBox2.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Code"
        '
        'MyTextBox1
        '
        Me.MyTextBox1.AlwaysDisable = False
        Me.MyTextBox1.AlwaysEnable = False
        Me.MyTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox1.BrowseDataSource = ""
        Me.MyTextBox1.BrowseField = ""
        Me.MyTextBox1.BrowseFilter = Nothing
        Me.MyTextBox1.BrowseLabel = "Code,Name"
        Me.MyTextBox1.BrowseLabelWidth = "100,200"
        Me.MyTextBox1.BrowseTextSource = ""
        Me.MyTextBox1.BrowseValueSource = ""
        Me.MyTextBox1.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox1.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox1.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox1.Enabled = False
        Me.MyTextBox1.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox1.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox1.ID = True
        Me.MyTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.MyTextBox1.Name = "MyTextBox1"
        Me.MyTextBox1.NoClear = False
        Me.MyTextBox1.NoSave = False
        Me.MyTextBox1.NumberFormat = "@"
        Me.MyTextBox1.Required = False
        Me.MyTextBox1.RowData = Nothing
        Me.MyTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MyTextBox1.TabIndex = 1
        Me.MyTextBox1.TextBrowse = False
        Me.MyTextBox1.TextSource = "department_id"
        Me.MyTextBox1.ToUpper = True
        Me.MyTextBox1.Unique = False
        Me.MyTextBox1.Value = ""
        Me.MyTextBox1.ValueSource = ""
        Me.MyTextBox1.Visible = False
        '
        'MyButton3
        '
        Me.MyButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton3.ButtonType = user_control.MyList.ButtonType.ButtonDelete
        Me.MyButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton3.ForeColor = System.Drawing.Color.White
        Me.MyButton3.Location = New System.Drawing.Point(184, 226)
        Me.MyButton3.Name = "MyButton3"
        Me.MyButton3.Size = New System.Drawing.Size(80, 24)
        Me.MyButton3.TabIndex = 107
        Me.MyButton3.Text = "F4 Delete"
        Me.MyButton3.UseVisualStyleBackColor = False
        '
        'MyButton2
        '
        Me.MyButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton2.ButtonType = user_control.MyList.ButtonType.ButtonEdit
        Me.MyButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton2.ForeColor = System.Drawing.Color.White
        Me.MyButton2.Location = New System.Drawing.Point(98, 226)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(80, 24)
        Me.MyButton2.TabIndex = 106
        Me.MyButton2.Text = "F3 Edit"
        Me.MyButton2.UseVisualStyleBackColor = False
        '
        'MyButton1
        '
        Me.MyButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton1.ButtonType = user_control.MyList.ButtonType.ButtonAdd
        Me.MyButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton1.ForeColor = System.Drawing.Color.White
        Me.MyButton1.Location = New System.Drawing.Point(12, 226)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(80, 24)
        Me.MyButton1.TabIndex = 105
        Me.MyButton1.Text = "F2 Add"
        Me.MyButton1.UseVisualStyleBackColor = False
        '
        'MyButton4
        '
        Me.MyButton4.BackColor = System.Drawing.Color.Maroon
        Me.MyButton4.ButtonType = user_control.MyList.ButtonType.ButtonNotSave
        Me.MyButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.MyButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton4.ForeColor = System.Drawing.Color.White
        Me.MyButton4.Location = New System.Drawing.Point(98, 226)
        Me.MyButton4.Name = "MyButton4"
        Me.MyButton4.Size = New System.Drawing.Size(80, 24)
        Me.MyButton4.TabIndex = 109
        Me.MyButton4.Text = "&Cancel"
        Me.MyButton4.UseVisualStyleBackColor = False
        '
        'MyButton5
        '
        Me.MyButton5.BackColor = System.Drawing.Color.Green
        Me.MyButton5.ButtonType = user_control.MyList.ButtonType.ButtonSave
        Me.MyButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.MyButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton5.ForeColor = System.Drawing.Color.White
        Me.MyButton5.Location = New System.Drawing.Point(12, 226)
        Me.MyButton5.Name = "MyButton5"
        Me.MyButton5.Size = New System.Drawing.Size(80, 24)
        Me.MyButton5.TabIndex = 108
        Me.MyButton5.Text = "&Save"
        Me.MyButton5.UseVisualStyleBackColor = False
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_department})
        '
        'lib_erp_department
        '
        Me.lib_erp_department.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.lib_erp_department.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"department_id"}, True)})
        Me.lib_erp_department.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.lib_erp_department.TableName = "lib_erp_department"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "department_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "department_code"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "department_name"
        Me.DataColumn4.DefaultValue = ""
        '
        'department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 340)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MyButton3)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.MyButton4)
        Me.Controls.Add(Me.MyButton5)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ModuleCode = "ACC00809"
        Me.MyDGView = Me.dgMain
        Me.MyTable = "lib_erp_department"
        Me.Name = "department"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_department, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents department_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents txtsearch As user_control.MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents lib_erp_department As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox3 As user_control.MyTextBox
    Friend WithEvents MyTextBox2 As user_control.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox1 As user_control.MyTextBox
    Friend WithEvents MyButton3 As user_control.MyButton
    Friend WithEvents MyButton2 As user_control.MyButton
    Friend WithEvents MyButton1 As user_control.MyButton
    Friend WithEvents MyButton4 As user_control.MyButton
    Friend WithEvents MyButton5 As user_control.MyButton
End Class
