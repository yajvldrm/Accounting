Imports user_control
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chartclass
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.ds = New System.Data.DataSet()
        Me.lib_acc_chart_class = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MyTextBox4 = New user_control.MyTextBox()
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
        Me.txtsearch = New user_control.MyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chart_class_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_type_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_class_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_class_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_acc_chart_class, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Chart Class Setup"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.chart_class_id, Me.chart_type_name, Me.chart_class_code, Me.chart_class_name})
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
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_acc_chart_class})
        '
        'lib_acc_chart_class
        '
        Me.lib_acc_chart_class.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.lib_acc_chart_class.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"chart_class_id"}, True)})
        Me.lib_acc_chart_class.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.lib_acc_chart_class.TableName = "lib_acc_chart_class"
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
        Me.DataColumn2.ColumnName = "chart_class_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "chart_class_code"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "chart_class_name"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "chart_type"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "chart_type_name"
        Me.DataColumn6.DefaultValue = ""
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 113
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MyTextBox4)
        Me.GroupBox1.Controls.Add(Me.MyTextBox3)
        Me.GroupBox1.Controls.Add(Me.MyTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MyTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 70)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Chart Type"
        '
        'MyTextBox4
        '
        Me.MyTextBox4.AlwaysDisable = False
        Me.MyTextBox4.AlwaysEnable = False
        Me.MyTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox4.BrowseDataSource = "[chart_type]"
        Me.MyTextBox4.BrowseField = "chart_type,chart_type_name"
        Me.MyTextBox4.BrowseFilter = Nothing
        Me.MyTextBox4.BrowseLabel = "Code,Name"
        Me.MyTextBox4.BrowseLabelWidth = "100,200"
        Me.MyTextBox4.BrowseTextSource = "chart_type_name"
        Me.MyTextBox4.BrowseValueSource = "chart_type"
        Me.MyTextBox4.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox4.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox4.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox4.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox4.Enabled = False
        Me.MyTextBox4.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox4.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox4.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox4.ID = False
        Me.MyTextBox4.Location = New System.Drawing.Point(293, 15)
        Me.MyTextBox4.Name = "MyTextBox4"
        Me.MyTextBox4.NoClear = False
        Me.MyTextBox4.NoSave = False
        Me.MyTextBox4.NumberFormat = "@"
        Me.MyTextBox4.Required = True
        Me.MyTextBox4.RowData = Nothing
        Me.MyTextBox4.Size = New System.Drawing.Size(170, 20)
        Me.MyTextBox4.TabIndex = 3
        Me.MyTextBox4.TextBrowse = True
        Me.MyTextBox4.TextSource = "chart_type_name"
        Me.MyTextBox4.ToUpper = True
        Me.MyTextBox4.Unique = False
        Me.MyTextBox4.Value = ""
        Me.MyTextBox4.ValueSource = "chart_type"
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
        Me.MyTextBox3.TabIndex = 4
        Me.MyTextBox3.TextBrowse = False
        Me.MyTextBox3.TextSource = "chart_class_name"
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
        Me.MyTextBox2.Size = New System.Drawing.Size(170, 20)
        Me.MyTextBox2.TabIndex = 2
        Me.MyTextBox2.TextBrowse = False
        Me.MyTextBox2.TextSource = "chart_class_code"
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
        Me.MyTextBox1.TextSource = "chart_class_id"
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
        Me.MyButton3.TabIndex = 116
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
        Me.MyButton2.TabIndex = 115
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
        Me.MyButton1.TabIndex = 114
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
        Me.MyButton4.TabIndex = 118
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
        Me.MyButton5.TabIndex = 117
        Me.MyButton5.Text = "&Save"
        Me.MyButton5.UseVisualStyleBackColor = False
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
        Me.txtsearch.Location = New System.Drawing.Point(341, 38)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NoSave = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.Size = New System.Drawing.Size(147, 20)
        Me.txtsearch.TabIndex = 120
        Me.txtsearch.TextBrowse = False
        Me.txtsearch.TextSource = "chart_type_name,chart_class_code,chart_class_name"
        Me.txtsearch.ToUpper = True
        Me.txtsearch.Unique = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Search"
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
        'chart_class_id
        '
        Me.chart_class_id.DataPropertyName = "chart_class_id"
        Me.chart_class_id.HeaderText = "ID"
        Me.chart_class_id.Name = "chart_class_id"
        Me.chart_class_id.ReadOnly = True
        Me.chart_class_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_class_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.chart_class_id.Visible = False
        '
        'chart_type_name
        '
        Me.chart_type_name.DataPropertyName = "chart_type_name"
        Me.chart_type_name.HeaderText = "Type"
        Me.chart_type_name.Name = "chart_type_name"
        Me.chart_type_name.ReadOnly = True
        Me.chart_type_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_type_name.Width = 80
        '
        'chart_class_code
        '
        Me.chart_class_code.DataPropertyName = "chart_class_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chart_class_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.chart_class_code.HeaderText = "Code"
        Me.chart_class_code.Name = "chart_class_code"
        Me.chart_class_code.ReadOnly = True
        Me.chart_class_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_class_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.chart_class_code.Width = 150
        '
        'chart_class_name
        '
        Me.chart_class_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.chart_class_name.DataPropertyName = "chart_class_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.chart_class_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.chart_class_name.HeaderText = "Name"
        Me.chart_class_name.Name = "chart_class_name"
        Me.chart_class_name.ReadOnly = True
        Me.chart_class_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_class_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'chartclass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 345)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MyButton3)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.MyButton4)
        Me.Controls.Add(Me.MyButton5)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.CustomQuery = "[chart_class]"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ModuleCode = "ACC00804"
        Me.MyDGView = Me.dgMain
        Me.MyTable = "lib_acc_chart_class"
        Me.Name = "chartclass"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart Class Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_acc_chart_class, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents lib_acc_chart_class As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox4 As user_control.MyTextBox
    Friend WithEvents txtsearch As user_control.MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chart_class_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_type_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_class_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_class_name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
