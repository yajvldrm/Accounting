Imports user_control
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.category_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_category = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MyCheckBox1 = New user_control.MyCheckBox()
        Me.MyTextBox4 = New user_control.MyTextBox()
        Me.MyTextBox5 = New user_control.MyTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.MyCheckBox2 = New user_control.MyCheckBox()
        Me.DataColumn8 = New System.Data.DataColumn()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.category_id, Me.category_code, Me.category_name})
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
        Me.dgMain.Size = New System.Drawing.Size(526, 150)
        Me.dgMain.TabIndex = 1
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
        'category_id
        '
        Me.category_id.DataPropertyName = "category_id"
        Me.category_id.HeaderText = "ID"
        Me.category_id.Name = "category_id"
        Me.category_id.ReadOnly = True
        Me.category_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.category_id.Visible = False
        '
        'category_code
        '
        Me.category_code.DataPropertyName = "category_code"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_code.DefaultCellStyle = DataGridViewCellStyle3
        Me.category_code.HeaderText = "Code"
        Me.category_code.Name = "category_code"
        Me.category_code.ReadOnly = True
        Me.category_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.category_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.category_code.Width = 150
        '
        'category_name
        '
        Me.category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.category_name.DataPropertyName = "category_name"
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.category_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.category_name.HeaderText = "Category Name"
        Me.category_name.Name = "category_name"
        Me.category_name.ReadOnly = True
        Me.category_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.category_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_category})
        '
        'lib_erp_category
        '
        Me.lib_erp_category.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.lib_erp_category.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"category_id"}, True)})
        Me.lib_erp_category.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.lib_erp_category.TableName = "lib_erp_category"
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
        Me.DataColumn2.ColumnName = "category_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "category_code"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "category_name"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "start_trans_no"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "format"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "require_tin"
        Me.DataColumn7.DataType = GetType(Boolean)
        Me.DataColumn7.DefaultValue = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Category Setup"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(550, 28)
        Me.Myformheader1.TabIndex = 107
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(525, 2)
        Me.border1.TabIndex = 98
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MyCheckBox2)
        Me.GroupBox1.Controls.Add(Me.MyCheckBox1)
        Me.GroupBox1.Controls.Add(Me.MyTextBox4)
        Me.GroupBox1.Controls.Add(Me.MyTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MyTextBox3)
        Me.GroupBox1.Controls.Add(Me.MyTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MyTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 92)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'MyCheckBox1
        '
        Me.MyCheckBox1.AlwaysDisable = False
        Me.MyCheckBox1.AlwaysEnable = False
        Me.MyCheckBox1.AutoSize = True
        Me.MyCheckBox1.Enabled = False
        Me.MyCheckBox1.isChecked = False
        Me.MyCheckBox1.Location = New System.Drawing.Point(16, 62)
        Me.MyCheckBox1.Name = "MyCheckBox1"
        Me.MyCheckBox1.NoSave = False
        Me.MyCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MyCheckBox1.Size = New System.Drawing.Size(90, 17)
        Me.MyCheckBox1.TabIndex = 6
        Me.MyCheckBox1.Text = "Required TIN"
        Me.MyCheckBox1.UseVisualStyleBackColor = True
        Me.MyCheckBox1.ValueSource = "require_tin"
        '
        'MyTextBox4
        '
        Me.MyTextBox4.AlwaysDisable = False
        Me.MyTextBox4.AlwaysEnable = False
        Me.MyTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox4.BrowseDataSource = ""
        Me.MyTextBox4.BrowseField = ""
        Me.MyTextBox4.BrowseFilter = Nothing
        Me.MyTextBox4.BrowseLabel = "Code,Name"
        Me.MyTextBox4.BrowseLabelWidth = "100,200"
        Me.MyTextBox4.BrowseTextSource = ""
        Me.MyTextBox4.BrowseValueSource = ""
        Me.MyTextBox4.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox4.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox4.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox4.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox4.Enabled = False
        Me.MyTextBox4.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox4.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox4.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox4.ID = False
        Me.MyTextBox4.Location = New System.Drawing.Point(339, 40)
        Me.MyTextBox4.Name = "MyTextBox4"
        Me.MyTextBox4.NoClear = False
        Me.MyTextBox4.NoSave = False
        Me.MyTextBox4.NumberFormat = "@"
        Me.MyTextBox4.Required = True
        Me.MyTextBox4.RowData = Nothing
        Me.MyTextBox4.Size = New System.Drawing.Size(180, 20)
        Me.MyTextBox4.TabIndex = 5
        Me.MyTextBox4.TextBrowse = False
        Me.MyTextBox4.TextSource = "format"
        Me.MyTextBox4.ToUpper = True
        Me.MyTextBox4.Unique = False
        Me.MyTextBox4.Value = ""
        Me.MyTextBox4.ValueSource = ""
        '
        'MyTextBox5
        '
        Me.MyTextBox5.AlwaysDisable = False
        Me.MyTextBox5.AlwaysEnable = False
        Me.MyTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox5.BrowseDataSource = ""
        Me.MyTextBox5.BrowseField = ""
        Me.MyTextBox5.BrowseFilter = Nothing
        Me.MyTextBox5.BrowseLabel = "Code,Name"
        Me.MyTextBox5.BrowseLabelWidth = "100,200"
        Me.MyTextBox5.BrowseTextSource = ""
        Me.MyTextBox5.BrowseValueSource = ""
        Me.MyTextBox5.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox5.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox5.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox5.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox5.Enabled = False
        Me.MyTextBox5.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox5.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox5.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox5.ID = False
        Me.MyTextBox5.Location = New System.Drawing.Point(92, 40)
        Me.MyTextBox5.Name = "MyTextBox5"
        Me.MyTextBox5.NoClear = False
        Me.MyTextBox5.NoSave = False
        Me.MyTextBox5.NumberFormat = "@"
        Me.MyTextBox5.Required = True
        Me.MyTextBox5.RowData = Nothing
        Me.MyTextBox5.Size = New System.Drawing.Size(180, 20)
        Me.MyTextBox5.TabIndex = 4
        Me.MyTextBox5.TextBrowse = False
        Me.MyTextBox5.TextSource = "start_trans_no"
        Me.MyTextBox5.ToUpper = True
        Me.MyTextBox5.Unique = False
        Me.MyTextBox5.Value = ""
        Me.MyTextBox5.ValueSource = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Format"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Starting Number"
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
        Me.MyTextBox3.Location = New System.Drawing.Point(339, 19)
        Me.MyTextBox3.Name = "MyTextBox3"
        Me.MyTextBox3.NoClear = False
        Me.MyTextBox3.NoSave = False
        Me.MyTextBox3.NumberFormat = "@"
        Me.MyTextBox3.Required = True
        Me.MyTextBox3.RowData = Nothing
        Me.MyTextBox3.Size = New System.Drawing.Size(180, 20)
        Me.MyTextBox3.TabIndex = 3
        Me.MyTextBox3.TextBrowse = False
        Me.MyTextBox3.TextSource = "category_name"
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
        Me.MyTextBox2.Location = New System.Drawing.Point(92, 19)
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.NoClear = False
        Me.MyTextBox2.NoSave = False
        Me.MyTextBox2.NumberFormat = "@"
        Me.MyTextBox2.Required = True
        Me.MyTextBox2.RowData = Nothing
        Me.MyTextBox2.Size = New System.Drawing.Size(180, 20)
        Me.MyTextBox2.TabIndex = 2
        Me.MyTextBox2.TextBrowse = False
        Me.MyTextBox2.TextSource = "category_code"
        Me.MyTextBox2.ToUpper = True
        Me.MyTextBox2.Unique = True
        Me.MyTextBox2.Value = ""
        Me.MyTextBox2.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 22)
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
        Me.MyTextBox1.TextSource = "category_id"
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
        Me.MyButton3.TabIndex = 5
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
        Me.MyButton2.TabIndex = 4
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
        Me.MyButton1.TabIndex = 3
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
        Me.MyButton4.TabIndex = 112
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
        Me.MyButton5.TabIndex = 111
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
        Me.txtsearch.Location = New System.Drawing.Point(391, 38)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NoSave = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.Size = New System.Drawing.Size(147, 20)
        Me.txtsearch.TabIndex = 0
        Me.txtsearch.TextBrowse = False
        Me.txtsearch.TextSource = "category_code,category_name"
        Me.txtsearch.ToUpper = True
        Me.txtsearch.Unique = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Search"
        '
        'MyCheckBox2
        '
        Me.MyCheckBox2.AlwaysDisable = False
        Me.MyCheckBox2.AlwaysEnable = False
        Me.MyCheckBox2.AutoSize = True
        Me.MyCheckBox2.Enabled = False
        Me.MyCheckBox2.isChecked = False
        Me.MyCheckBox2.Location = New System.Drawing.Point(112, 62)
        Me.MyCheckBox2.Name = "MyCheckBox2"
        Me.MyCheckBox2.NoSave = False
        Me.MyCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MyCheckBox2.Size = New System.Drawing.Size(51, 17)
        Me.MyCheckBox2.TabIndex = 9
        Me.MyCheckBox2.Text = "Bank"
        Me.MyCheckBox2.UseVisualStyleBackColor = True
        Me.MyCheckBox2.ValueSource = "isBank"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "isBank"
        Me.DataColumn8.DataType = GetType(Boolean)
        Me.DataColumn8.DefaultValue = False
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 360)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MyButton3)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.MyButton4)
        Me.Controls.Add(Me.MyButton5)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ModuleCode = "ACC00803"
        Me.MyDGView = Me.dgMain
        Me.MyTable = "lib_erp_category"
        Me.Name = "category"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents category_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox4 As user_control.MyTextBox
    Friend WithEvents MyTextBox5 As user_control.MyTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents lib_erp_category As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents txtsearch As user_control.MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MyCheckBox1 As user_control.MyCheckBox
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents MyCheckBox2 As MyCheckBox
End Class
