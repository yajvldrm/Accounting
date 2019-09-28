Imports user_control
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currency_rate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(currency_rate))
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.currency_rate_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.effectivitydate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exchange_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_currency_rate = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MyDatePicker1 = New user_control.myDatePicker()
        Me.MyTextBox5 = New user_control.MyTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MyTextBox6 = New user_control.MyTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_symbol = New user_control.MyTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_currency_name = New user_control.MyTextBox()
        Me.txt_currency_id = New user_control.MyTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MyTextBox1 = New user_control.MyTextBox()
        Me.MyButton3 = New user_control.MyButton()
        Me.MyButton2 = New user_control.MyButton()
        Me.MyButton1 = New user_control.MyButton()
        Me.MyButton4 = New user_control.MyButton()
        Me.MyButton5 = New user_control.MyButton()
        Me.txtsearch = New user_control.MyTextBox()
        Me.Myformheader1 = New user_control.myformheader()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_currency_rate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.currency_rate_id, Me.effectivitydate, Me.currency_name, Me.exchange_rate})
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
        Me.dgMain.Size = New System.Drawing.Size(476, 156)
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
        'currency_rate_id
        '
        Me.currency_rate_id.DataPropertyName = "currency_rate_id"
        Me.currency_rate_id.HeaderText = "Currency Rate ID"
        Me.currency_rate_id.Name = "currency_rate_id"
        Me.currency_rate_id.ReadOnly = True
        Me.currency_rate_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.currency_rate_id.Visible = False
        '
        'effectivitydate
        '
        Me.effectivitydate.DataPropertyName = "effectivitydate"
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.effectivitydate.DefaultCellStyle = DataGridViewCellStyle3
        Me.effectivitydate.HeaderText = "Date"
        Me.effectivitydate.Name = "effectivitydate"
        Me.effectivitydate.ReadOnly = True
        Me.effectivitydate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.effectivitydate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'currency_name
        '
        Me.currency_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.currency_name.DataPropertyName = "currency_name"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currency_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.currency_name.HeaderText = "Currency Name"
        Me.currency_name.Name = "currency_name"
        Me.currency_name.ReadOnly = True
        Me.currency_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.currency_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'exchange_rate
        '
        Me.exchange_rate.DataPropertyName = "exchange_rate"
        Me.exchange_rate.HeaderText = "Rate"
        Me.exchange_rate.Name = "exchange_rate"
        Me.exchange_rate.ReadOnly = True
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_currency_rate})
        '
        'lib_erp_currency_rate
        '
        Me.lib_erp_currency_rate.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.lib_erp_currency_rate.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"currency_rate_id"}, True)})
        Me.lib_erp_currency_rate.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.lib_erp_currency_rate.TableName = "lib_erp_currency_rate"
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
        Me.DataColumn2.ColumnName = "currency_rate_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "currency_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "currency_code"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "currency_name"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "symbol"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "effectivitydate"
        Me.DataColumn7.DataType = GetType(Date)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "exchange_rate"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "based_rate"
        Me.DataColumn9.DataType = GetType(Decimal)
        Me.DataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Currency Rate Setup"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MyDatePicker1)
        Me.GroupBox1.Controls.Add(Me.MyTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.MyTextBox6)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_symbol)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_currency_name)
        Me.GroupBox1.Controls.Add(Me.txt_currency_id)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.MyTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 101)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        '
        'MyDatePicker1
        '
        Me.MyDatePicker1.AlwaysDisable = False
        Me.MyDatePicker1.AlwaysEnable = False
        Me.MyDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MyDatePicker1.Location = New System.Drawing.Point(313, 21)
        Me.MyDatePicker1.Name = "MyDatePicker1"
        Me.MyDatePicker1.NoClear = False
        Me.MyDatePicker1.NoSave = False
        Me.MyDatePicker1.Required = False
        Me.MyDatePicker1.Size = New System.Drawing.Size(150, 20)
        Me.MyDatePicker1.TabIndex = 5
        Me.MyDatePicker1.TextSource = "effectivitydate"
        '
        'MyTextBox5
        '
        Me.MyTextBox5.AlwaysDisable = True
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
        Me.MyTextBox5.DecimalValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.MyTextBox5.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox5.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox5.Enabled = False
        Me.MyTextBox5.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox5.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox5.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox5.ID = False
        Me.MyTextBox5.Location = New System.Drawing.Point(313, 63)
        Me.MyTextBox5.Name = "MyTextBox5"
        Me.MyTextBox5.NoClear = True
        Me.MyTextBox5.NoSave = False
        Me.MyTextBox5.NumberFormat = "##,##0.00"
        Me.MyTextBox5.Required = True
        Me.MyTextBox5.RowData = Nothing
        Me.MyTextBox5.Size = New System.Drawing.Size(150, 20)
        Me.MyTextBox5.TabIndex = 7
        Me.MyTextBox5.Text = "1.00"
        Me.MyTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MyTextBox5.TextBrowse = False
        Me.MyTextBox5.TextSource = ""
        Me.MyTextBox5.ToUpper = True
        Me.MyTextBox5.Unique = False
        Me.MyTextBox5.Value = "1.00"
        Me.MyTextBox5.ValueSource = "based_rate"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(247, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Based Rate"
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
        Me.MyTextBox6.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.MyTextBox6.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox6.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox6.Enabled = False
        Me.MyTextBox6.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox6.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox6.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox6.ID = False
        Me.MyTextBox6.Location = New System.Drawing.Point(313, 42)
        Me.MyTextBox6.Name = "MyTextBox6"
        Me.MyTextBox6.NoClear = False
        Me.MyTextBox6.NoSave = False
        Me.MyTextBox6.NumberFormat = "##,##0.00"
        Me.MyTextBox6.Required = True
        Me.MyTextBox6.RowData = Nothing
        Me.MyTextBox6.Size = New System.Drawing.Size(150, 20)
        Me.MyTextBox6.TabIndex = 6
        Me.MyTextBox6.Text = "0.00"
        Me.MyTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MyTextBox6.TextBrowse = False
        Me.MyTextBox6.TextSource = ""
        Me.MyTextBox6.ToUpper = True
        Me.MyTextBox6.Unique = False
        Me.MyTextBox6.Value = ""
        Me.MyTextBox6.ValueSource = "exchange_rate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(280, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Rate"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(280, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Date"
        '
        'txt_symbol
        '
        Me.txt_symbol.AlwaysDisable = True
        Me.txt_symbol.AlwaysEnable = False
        Me.txt_symbol.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_symbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_symbol.BrowseDataSource = ""
        Me.txt_symbol.BrowseField = ""
        Me.txt_symbol.BrowseFilter = Nothing
        Me.txt_symbol.BrowseLabel = "Code,Name"
        Me.txt_symbol.BrowseLabelWidth = "100,200"
        Me.txt_symbol.BrowseTextSource = ""
        Me.txt_symbol.BrowseValueSource = ""
        Me.txt_symbol.Database = user_control.MyList.Database.FileSetup
        Me.txt_symbol.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_symbol.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_symbol.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_symbol.Enabled = False
        Me.txt_symbol.EnabledBackColor = System.Drawing.Color.White
        Me.txt_symbol.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_symbol.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_symbol.ID = False
        Me.txt_symbol.Location = New System.Drawing.Point(57, 67)
        Me.txt_symbol.Name = "txt_symbol"
        Me.txt_symbol.NoClear = False
        Me.txt_symbol.NoSave = True
        Me.txt_symbol.NumberFormat = "@"
        Me.txt_symbol.Required = True
        Me.txt_symbol.RowData = Nothing
        Me.txt_symbol.Size = New System.Drawing.Size(150, 20)
        Me.txt_symbol.TabIndex = 4
        Me.txt_symbol.TextBrowse = False
        Me.txt_symbol.TextSource = "symbol"
        Me.txt_symbol.ToUpper = True
        Me.txt_symbol.Unique = False
        Me.txt_symbol.Value = ""
        Me.txt_symbol.ValueSource = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Symbol"
        '
        'txt_currency_name
        '
        Me.txt_currency_name.AlwaysDisable = True
        Me.txt_currency_name.AlwaysEnable = False
        Me.txt_currency_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_name.BrowseDataSource = ""
        Me.txt_currency_name.BrowseField = ""
        Me.txt_currency_name.BrowseFilter = Nothing
        Me.txt_currency_name.BrowseLabel = "Code,Name"
        Me.txt_currency_name.BrowseLabelWidth = "100,200"
        Me.txt_currency_name.BrowseTextSource = ""
        Me.txt_currency_name.BrowseValueSource = ""
        Me.txt_currency_name.Database = user_control.MyList.Database.FileSetup
        Me.txt_currency_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_name.Enabled = False
        Me.txt_currency_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_name.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_currency_name.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_name.ID = False
        Me.txt_currency_name.Location = New System.Drawing.Point(57, 46)
        Me.txt_currency_name.Name = "txt_currency_name"
        Me.txt_currency_name.NoClear = False
        Me.txt_currency_name.NoSave = True
        Me.txt_currency_name.NumberFormat = "@"
        Me.txt_currency_name.Required = True
        Me.txt_currency_name.RowData = Nothing
        Me.txt_currency_name.Size = New System.Drawing.Size(150, 20)
        Me.txt_currency_name.TabIndex = 3
        Me.txt_currency_name.TextBrowse = False
        Me.txt_currency_name.TextSource = "currency_name"
        Me.txt_currency_name.ToUpper = True
        Me.txt_currency_name.Unique = False
        Me.txt_currency_name.Value = ""
        Me.txt_currency_name.ValueSource = ""
        '
        'txt_currency_id
        '
        Me.txt_currency_id.AlwaysDisable = False
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.BrowseDataSource = "lib_erp_currency"
        Me.txt_currency_id.BrowseField = "currency_code,currency_name"
        Me.txt_currency_id.BrowseFilter = Nothing
        Me.txt_currency_id.BrowseLabel = "Code,Name"
        Me.txt_currency_id.BrowseLabelWidth = "100,200"
        Me.txt_currency_id.BrowseTextSource = "currency_code"
        Me.txt_currency_id.BrowseUpdate.Add(CType(resources.GetObject("txt_currency_id.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_currency_id.BrowseUpdate.Add(CType(resources.GetObject("txt_currency_id.BrowseUpdate1"), user_control.MyTextBoxList))
        Me.txt_currency_id.BrowseValueSource = "currency_id"
        Me.txt_currency_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.Enabled = False
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_currency_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.ID = False
        Me.txt_currency_id.Location = New System.Drawing.Point(57, 25)
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NoSave = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = True
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_currency_id.TabIndex = 2
        Me.txt_currency_id.TextBrowse = True
        Me.txt_currency_id.TextSource = "currency_code"
        Me.txt_currency_id.ToUpper = True
        Me.txt_currency_id.Unique = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = "currency_id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Code"
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
        Me.MyTextBox1.Location = New System.Drawing.Point(208, 25)
        Me.MyTextBox1.Name = "MyTextBox1"
        Me.MyTextBox1.NoClear = False
        Me.MyTextBox1.NoSave = False
        Me.MyTextBox1.NumberFormat = "@"
        Me.MyTextBox1.Required = False
        Me.MyTextBox1.RowData = Nothing
        Me.MyTextBox1.Size = New System.Drawing.Size(49, 20)
        Me.MyTextBox1.TabIndex = 1
        Me.MyTextBox1.TextBrowse = False
        Me.MyTextBox1.TextSource = "currency_rate_id"
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
        Me.MyButton3.Location = New System.Drawing.Point(184, 232)
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
        Me.MyButton2.Location = New System.Drawing.Point(98, 232)
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
        Me.MyButton1.Location = New System.Drawing.Point(12, 232)
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
        Me.MyButton4.Location = New System.Drawing.Point(98, 232)
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
        Me.MyButton5.Location = New System.Drawing.Point(12, 232)
        Me.MyButton5.Name = "MyButton5"
        Me.MyButton5.Size = New System.Drawing.Size(80, 24)
        Me.MyButton5.TabIndex = 108
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
        Me.txtsearch.TabIndex = 103
        Me.txtsearch.TextBrowse = False
        Me.txtsearch.TextSource = "currency_name"
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
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 87
        '
        'currency_rate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 375)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MyButton3)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.MyButton4)
        Me.Controls.Add(Me.MyButton5)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ModuleCode = "ACC00808"
        Me.MyDGView = Me.dgMain
        Me.MyTable = "lib_erp_currency_rate"
        Me.Name = "currency_rate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Rate Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_currency_rate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents currency_rate_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents effectivitydate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exchange_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents txtsearch As user_control.MyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MyButton3 As user_control.MyButton
    Friend WithEvents MyButton2 As user_control.MyButton
    Friend WithEvents MyButton1 As user_control.MyButton
    Friend WithEvents MyButton4 As user_control.MyButton
    Friend WithEvents MyButton5 As user_control.MyButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_symbol As user_control.MyTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_currency_name As user_control.MyTextBox
    Friend WithEvents txt_currency_id As user_control.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox1 As user_control.MyTextBox
    Friend WithEvents MyDatePicker1 As user_control.myDatePicker
    Friend WithEvents MyTextBox5 As user_control.MyTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox6 As user_control.MyTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents lib_erp_currency_rate As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
End Class
