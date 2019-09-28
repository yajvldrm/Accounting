Imports user_control
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(allocation))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.allocation_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allocation_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allocation_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_allocation = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.lib_erp_allocation_account = New System.Data.DataTable()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MyTextBox3 = New user_control.MyTextBox()
        Me.MyTextBox2 = New user_control.MyTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_allocation_id = New user_control.MyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsearch = New user_control.MyTextBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.MyPanel1 = New user_control.MyPanel()
        Me.txt_account_name = New user_control.MyTextBox()
        Me.txt_account_code = New user_control.MyTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MyTextBox6 = New user_control.MyTextBox()
        Me.MyButton6 = New user_control.MyButton()
        Me.dgSub = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.allocation_account_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MyButton9 = New user_control.MyButton()
        Me.MyButton10 = New user_control.MyButton()
        Me.MyButton7 = New user_control.MyButton()
        Me.MyButton8 = New user_control.MyButton()
        Me.MyButton3 = New user_control.MyButton()
        Me.MyButton2 = New user_control.MyButton()
        Me.MyButton1 = New user_control.MyButton()
        Me.MyButton4 = New user_control.MyButton()
        Me.MyButton5 = New user_control.MyButton()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_allocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_allocation_account, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MyPanel1.SuspendLayout()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.allocation_id, Me.allocation_code, Me.allocation_name})
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
        Me.sel.FalseValue = "False"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.TrueValue = "True"
        Me.sel.Width = 30
        '
        'allocation_id
        '
        Me.allocation_id.DataPropertyName = "allocation_id"
        Me.allocation_id.HeaderText = "ID"
        Me.allocation_id.Name = "allocation_id"
        Me.allocation_id.ReadOnly = True
        Me.allocation_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allocation_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.allocation_id.Visible = False
        '
        'allocation_code
        '
        Me.allocation_code.DataPropertyName = "allocation_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allocation_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.allocation_code.HeaderText = "Code"
        Me.allocation_code.Name = "allocation_code"
        Me.allocation_code.ReadOnly = True
        Me.allocation_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allocation_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'allocation_name
        '
        Me.allocation_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.allocation_name.DataPropertyName = "allocation_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.allocation_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.allocation_name.HeaderText = "Allocation Name"
        Me.allocation_name.Name = "allocation_name"
        Me.allocation_name.ReadOnly = True
        Me.allocation_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allocation_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_allocation, Me.lib_erp_allocation_account})
        '
        'lib_erp_allocation
        '
        Me.lib_erp_allocation.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.lib_erp_allocation.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"allocation_id"}, True)})
        Me.lib_erp_allocation.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.lib_erp_allocation.TableName = "lib_erp_allocation"
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
        Me.DataColumn2.ColumnName = "allocation_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "allocation_code"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "allocation_name"
        Me.DataColumn4.DefaultValue = ""
        '
        'lib_erp_allocation_account
        '
        Me.lib_erp_allocation_account.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.lib_erp_allocation_account.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"allocation_account_id"}, True)})
        Me.lib_erp_allocation_account.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn6}
        Me.lib_erp_allocation_account.TableName = "lib_erp_allocation_account"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sel"
        Me.DataColumn5.DataType = GetType(Boolean)
        Me.DataColumn5.DefaultValue = False
        '
        'DataColumn6
        '
        Me.DataColumn6.AllowDBNull = False
        Me.DataColumn6.ColumnName = "allocation_account_id"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "allocation_id"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "account_id"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "account_code"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "account_name"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "deleted"
        Me.DataColumn11.DataType = GetType(Boolean)
        Me.DataColumn11.DefaultValue = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Allocation Setup"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(525, 2)
        Me.border1.TabIndex = 89
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MyTextBox3)
        Me.GroupBox1.Controls.Add(Me.MyTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_allocation_id)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 40)
        Me.GroupBox1.TabIndex = 5
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
        Me.MyTextBox3.Location = New System.Drawing.Point(303, 12)
        Me.MyTextBox3.Name = "MyTextBox3"
        Me.MyTextBox3.NoClear = False
        Me.MyTextBox3.NoSave = False
        Me.MyTextBox3.NumberFormat = "@"
        Me.MyTextBox3.Required = True
        Me.MyTextBox3.RowData = Nothing
        Me.MyTextBox3.Size = New System.Drawing.Size(200, 20)
        Me.MyTextBox3.TabIndex = 3
        Me.MyTextBox3.TextBrowse = False
        Me.MyTextBox3.TextSource = "allocation_name"
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
        Me.MyTextBox2.Location = New System.Drawing.Point(59, 12)
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.NoClear = False
        Me.MyTextBox2.NoSave = False
        Me.MyTextBox2.NumberFormat = "@"
        Me.MyTextBox2.Required = True
        Me.MyTextBox2.RowData = Nothing
        Me.MyTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.MyTextBox2.TabIndex = 2
        Me.MyTextBox2.TextBrowse = False
        Me.MyTextBox2.TextSource = "allocation_code"
        Me.MyTextBox2.ToUpper = True
        Me.MyTextBox2.Unique = True
        Me.MyTextBox2.Value = ""
        Me.MyTextBox2.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Code"
        '
        'txt_allocation_id
        '
        Me.txt_allocation_id.AlwaysDisable = False
        Me.txt_allocation_id.AlwaysEnable = False
        Me.txt_allocation_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_allocation_id.BrowseDataSource = ""
        Me.txt_allocation_id.BrowseField = ""
        Me.txt_allocation_id.BrowseFilter = Nothing
        Me.txt_allocation_id.BrowseLabel = "Code,Name"
        Me.txt_allocation_id.BrowseLabelWidth = "100,200"
        Me.txt_allocation_id.BrowseTextSource = ""
        Me.txt_allocation_id.BrowseValueSource = ""
        Me.txt_allocation_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_allocation_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_id.Enabled = False
        Me.txt_allocation_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_allocation_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_allocation_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_id.ID = True
        Me.txt_allocation_id.Location = New System.Drawing.Point(0, 0)
        Me.txt_allocation_id.Name = "txt_allocation_id"
        Me.txt_allocation_id.NoClear = False
        Me.txt_allocation_id.NoSave = False
        Me.txt_allocation_id.NumberFormat = "@"
        Me.txt_allocation_id.Required = False
        Me.txt_allocation_id.RowData = Nothing
        Me.txt_allocation_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_allocation_id.TabIndex = 1
        Me.txt_allocation_id.TextBrowse = False
        Me.txt_allocation_id.TextSource = "allocation_id"
        Me.txt_allocation_id.ToUpper = True
        Me.txt_allocation_id.Unique = False
        Me.txt_allocation_id.Value = ""
        Me.txt_allocation_id.ValueSource = ""
        Me.txt_allocation_id.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Search"
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
        Me.txtsearch.TextSource = "allocation_code,allocation_name"
        Me.txtsearch.ToUpper = True
        Me.txtsearch.Unique = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(550, 28)
        Me.Myformheader1.TabIndex = 100
        '
        'MyPanel1
        '
        Me.MyPanel1.Controls.Add(Me.txt_account_name)
        Me.MyPanel1.Controls.Add(Me.txt_account_code)
        Me.MyPanel1.Controls.Add(Me.Label4)
        Me.MyPanel1.Controls.Add(Me.Label5)
        Me.MyPanel1.Controls.Add(Me.MyTextBox6)
        Me.MyPanel1.Controls.Add(Me.MyButton6)
        Me.MyPanel1.Controls.Add(Me.dgSub)
        Me.MyPanel1.Controls.Add(Me.MyButton9)
        Me.MyPanel1.Controls.Add(Me.MyButton10)
        Me.MyPanel1.Controls.Add(Me.MyButton7)
        Me.MyPanel1.Controls.Add(Me.MyButton8)
        Me.MyPanel1.CustomQuery = "[lib_erp_allocation_account]"
        Me.MyPanel1.Location = New System.Drawing.Point(12, 302)
        Me.MyPanel1.ModuleCode = ""
        Me.MyPanel1.MyDataBase = user_control.MyList.Database.FileSetup
        Me.MyPanel1.MyDGView = Me.dgSub
        Me.MyPanel1.MYFK = "txt_allocation_id"
        Me.MyPanel1.MyLogID = ""
        Me.MyPanel1.MyTable = "lib_erp_allocation_account"
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(526, 221)
        Me.MyPanel1.TabIndex = 110
        '
        'txt_account_name
        '
        Me.txt_account_name.AlwaysDisable = True
        Me.txt_account_name.AlwaysEnable = False
        Me.txt_account_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_name.BrowseDataSource = ""
        Me.txt_account_name.BrowseField = ""
        Me.txt_account_name.BrowseFilter = Nothing
        Me.txt_account_name.BrowseLabel = "Code,Name"
        Me.txt_account_name.BrowseLabelWidth = "100,200"
        Me.txt_account_name.BrowseTextSource = ""
        Me.txt_account_name.BrowseValueSource = ""
        Me.txt_account_name.Database = user_control.MyList.Database.FileSetup
        Me.txt_account_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_name.Enabled = False
        Me.txt_account_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_name.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_account_name.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_name.ID = False
        Me.txt_account_name.Location = New System.Drawing.Point(303, 198)
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NoSave = True
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = True
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.Size = New System.Drawing.Size(200, 20)
        Me.txt_account_name.TabIndex = 8
        Me.txt_account_name.TextBrowse = False
        Me.txt_account_name.TextSource = "account_name"
        Me.txt_account_name.ToUpper = True
        Me.txt_account_name.Unique = False
        Me.txt_account_name.Value = ""
        Me.txt_account_name.ValueSource = ""
        '
        'txt_account_code
        '
        Me.txt_account_code.AlwaysDisable = False
        Me.txt_account_code.AlwaysEnable = False
        Me.txt_account_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_code.BrowseDataSource = "lib_erp_chart"
        Me.txt_account_code.BrowseField = "account_code,account_name"
        Me.txt_account_code.BrowseFilter = Nothing
        Me.txt_account_code.BrowseLabel = "Code,Name"
        Me.txt_account_code.BrowseLabelWidth = "100,200"
        Me.txt_account_code.BrowseTextSource = "account_code"
        Me.txt_account_code.BrowseUpdate.Add(CType(resources.GetObject("txt_account_code.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_account_code.BrowseValueSource = "account_id"
        Me.txt_account_code.Database = user_control.MyList.Database.FileSetup
        Me.txt_account_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_code.Enabled = False
        Me.txt_account_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_code.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_account_code.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_code.ID = False
        Me.txt_account_code.Location = New System.Drawing.Point(59, 198)
        Me.txt_account_code.Name = "txt_account_code"
        Me.txt_account_code.NoClear = False
        Me.txt_account_code.NoSave = False
        Me.txt_account_code.NumberFormat = "@"
        Me.txt_account_code.Required = True
        Me.txt_account_code.RowData = Nothing
        Me.txt_account_code.Size = New System.Drawing.Size(200, 20)
        Me.txt_account_code.TabIndex = 7
        Me.txt_account_code.TextBrowse = True
        Me.txt_account_code.TextSource = "account_code"
        Me.txt_account_code.ToUpper = True
        Me.txt_account_code.Unique = True
        Me.txt_account_code.Value = ""
        Me.txt_account_code.ValueSource = "account_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Code"
        '
        'MyTextBox6
        '
        Me.MyTextBox6.AlwaysDisable = False
        Me.MyTextBox6.AlwaysEnable = False
        Me.MyTextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox6.BrowseDataSource = ""
        Me.MyTextBox6.BrowseField = ""
        Me.MyTextBox6.BrowseFilter = Nothing
        Me.MyTextBox6.BrowseLabel = "Code,Name"
        Me.MyTextBox6.BrowseLabelWidth = "100,200"
        Me.MyTextBox6.BrowseTextSource = ""
        Me.MyTextBox6.BrowseValueSource = ""
        Me.MyTextBox6.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox6.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox6.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox6.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox6.Enabled = False
        Me.MyTextBox6.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox6.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox6.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox6.ID = True
        Me.MyTextBox6.Location = New System.Drawing.Point(0, 186)
        Me.MyTextBox6.Name = "MyTextBox6"
        Me.MyTextBox6.NoClear = False
        Me.MyTextBox6.NoSave = False
        Me.MyTextBox6.NumberFormat = "@"
        Me.MyTextBox6.Required = False
        Me.MyTextBox6.RowData = Nothing
        Me.MyTextBox6.Size = New System.Drawing.Size(100, 20)
        Me.MyTextBox6.TabIndex = 6
        Me.MyTextBox6.TextBrowse = False
        Me.MyTextBox6.TextSource = "allocation_account_id"
        Me.MyTextBox6.ToUpper = True
        Me.MyTextBox6.Unique = False
        Me.MyTextBox6.Value = ""
        Me.MyTextBox6.ValueSource = ""
        Me.MyTextBox6.Visible = False
        '
        'MyButton6
        '
        Me.MyButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton6.ButtonType = user_control.MyList.ButtonType.ButtonRemove
        Me.MyButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton6.ForeColor = System.Drawing.Color.White
        Me.MyButton6.Location = New System.Drawing.Point(176, 158)
        Me.MyButton6.Name = "MyButton6"
        Me.MyButton6.Size = New System.Drawing.Size(80, 24)
        Me.MyButton6.TabIndex = 3
        Me.MyButton6.Text = "&Remove"
        Me.MyButton6.UseVisualStyleBackColor = False
        '
        'dgSub
        '
        Me.dgSub.AllowUserToAddRows = False
        Me.dgSub.AllowUserToDeleteRows = False
        Me.dgSub.AllowUserToResizeColumns = False
        Me.dgSub.AllowUserToResizeRows = False
        Me.dgSub.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSub.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.allocation_account_id, Me.account_id, Me.account_code, Me.account_name, Me.deleted})
        Me.dgSub.DataSource = Me.ds
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSub.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgSub.Location = New System.Drawing.Point(2, 2)
        Me.dgSub.MultiSelect = False
        Me.dgSub.Name = "dgSub"
        Me.dgSub.RowHeadersVisible = False
        Me.dgSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSub.Size = New System.Drawing.Size(520, 150)
        Me.dgSub.TabIndex = 0
        Me.dgSub.Tag = "sub-grid"
        '
        'sel1
        '
        Me.sel1.DataPropertyName = "sel"
        Me.sel1.FalseValue = "False"
        Me.sel1.HeaderText = "Sel"
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.TrueValue = "True"
        Me.sel1.Width = 30
        '
        'allocation_account_id
        '
        Me.allocation_account_id.DataPropertyName = "allocation_account_id"
        Me.allocation_account_id.HeaderText = "ID"
        Me.allocation_account_id.Name = "allocation_account_id"
        Me.allocation_account_id.ReadOnly = True
        Me.allocation_account_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.allocation_account_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.allocation_account_id.Visible = False
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
        Me.account_code.FillWeight = 179.6407!
        Me.account_code.HeaderText = "Code"
        Me.account_code.Name = "account_code"
        Me.account_code.ReadOnly = True
        Me.account_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.account_code.Width = 150
        '
        'account_name
        '
        Me.account_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.account_name.DataPropertyName = "account_name"
        Me.account_name.FillWeight = 20.35928!
        Me.account_name.HeaderText = "Account Name"
        Me.account_name.Name = "account_name"
        Me.account_name.ReadOnly = True
        Me.account_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "Deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleted.Visible = False
        '
        'MyButton9
        '
        Me.MyButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton9.ButtonType = user_control.MyList.ButtonType.ButtonUpdate
        Me.MyButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton9.ForeColor = System.Drawing.Color.White
        Me.MyButton9.Location = New System.Drawing.Point(90, 158)
        Me.MyButton9.Name = "MyButton9"
        Me.MyButton9.Size = New System.Drawing.Size(80, 24)
        Me.MyButton9.TabIndex = 2
        Me.MyButton9.Text = "&Update"
        Me.MyButton9.UseVisualStyleBackColor = False
        '
        'MyButton10
        '
        Me.MyButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton10.ButtonType = user_control.MyList.ButtonType.ButtonInsert
        Me.MyButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton10.ForeColor = System.Drawing.Color.White
        Me.MyButton10.Location = New System.Drawing.Point(4, 158)
        Me.MyButton10.Name = "MyButton10"
        Me.MyButton10.Size = New System.Drawing.Size(80, 24)
        Me.MyButton10.TabIndex = 1
        Me.MyButton10.Text = "&Insert"
        Me.MyButton10.UseVisualStyleBackColor = False
        '
        'MyButton7
        '
        Me.MyButton7.BackColor = System.Drawing.Color.Maroon
        Me.MyButton7.ButtonType = user_control.MyList.ButtonType.ButtonCancel
        Me.MyButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.MyButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton7.ForeColor = System.Drawing.Color.White
        Me.MyButton7.Location = New System.Drawing.Point(90, 158)
        Me.MyButton7.Name = "MyButton7"
        Me.MyButton7.Size = New System.Drawing.Size(80, 24)
        Me.MyButton7.TabIndex = 5
        Me.MyButton7.Text = "Ca&ncel"
        Me.MyButton7.UseVisualStyleBackColor = False
        '
        'MyButton8
        '
        Me.MyButton8.BackColor = System.Drawing.Color.Green
        Me.MyButton8.ButtonType = user_control.MyList.ButtonType.ButtonOK
        Me.MyButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.MyButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton8.ForeColor = System.Drawing.Color.White
        Me.MyButton8.Location = New System.Drawing.Point(4, 158)
        Me.MyButton8.Name = "MyButton8"
        Me.MyButton8.Size = New System.Drawing.Size(80, 24)
        Me.MyButton8.TabIndex = 4
        Me.MyButton8.Text = "&OK"
        Me.MyButton8.UseVisualStyleBackColor = False
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
        Me.MyButton3.TabIndex = 13
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
        Me.MyButton2.TabIndex = 12
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
        Me.MyButton1.TabIndex = 11
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
        Me.MyButton4.TabIndex = 15
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
        Me.MyButton5.TabIndex = 14
        Me.MyButton5.Text = "&Save"
        Me.MyButton5.UseVisualStyleBackColor = False
        '
        'allocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 535)
        Me.Controls.Add(Me.MyButton3)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.MyButton4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MyButton5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ModuleCode = "ACC00801"
        Me.MyDGView = Me.dgMain
        Me.MyTable = "lib_erp_allocation"
        Me.Name = "allocation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allocation Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_allocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_allocation_account, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents allocation_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allocation_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allocation_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox3 As user_control.MyTextBox
    Friend WithEvents MyTextBox2 As user_control.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_allocation_id As user_control.MyTextBox
    Friend WithEvents txtsearch As user_control.MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents lib_erp_allocation As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents lib_erp_allocation_account As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents MyPanel1 As user_control.MyPanel
    Friend WithEvents txt_account_name As user_control.MyTextBox
    Friend WithEvents txt_account_code As user_control.MyTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox6 As user_control.MyTextBox
    Friend WithEvents MyButton6 As user_control.MyButton
    Friend WithEvents dgSub As System.Windows.Forms.DataGridView
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents allocation_account_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MyButton7 As user_control.MyButton
    Friend WithEvents MyButton8 As user_control.MyButton
    Friend WithEvents MyButton9 As user_control.MyButton
    Friend WithEvents MyButton10 As user_control.MyButton
    Friend WithEvents MyButton3 As user_control.MyButton
    Friend WithEvents MyButton2 As user_control.MyButton
    Friend WithEvents MyButton1 As user_control.MyButton
    Friend WithEvents MyButton4 As user_control.MyButton
    Friend WithEvents MyButton5 As user_control.MyButton
End Class
