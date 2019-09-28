Imports user_control
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionlocking
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Myformheader1 = New user_control.myformheader()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.ds = New System.Data.DataSet()
        Me.transaction_locking = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.MyButton2 = New user_control.MyButton()
        Me.MyButton1 = New user_control.MyButton()
        Me.MyButton4 = New user_control.MyButton()
        Me.MyButton5 = New user_control.MyButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_isLock = New user_control.MyCheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date_to = New user_control.myDatePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_date_from = New user_control.myDatePicker()
        Me.MyTextBox2 = New user_control.MyTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_transaction_locking_id = New user_control.MyTextBox()
        Me.txtsearch = New user_control.MyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MyButton3 = New user_control.MyButton()
        Me.border1 = New accounting.borderedlabel()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.transaction_locking_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_from = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transaction_locking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(800, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 25)
        Me.Label7.TabIndex = 280
        Me.Label7.Text = "Transaction Locking"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.transaction_locking_id, Me.journal_name, Me.date_from, Me.date_to})
        Me.dgMain.DataSource = Me.ds
        Me.dgMain.Location = New System.Drawing.Point(12, 61)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(776, 150)
        Me.dgMain.TabIndex = 282
        Me.dgMain.Tag = "maingrid"
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.transaction_locking})
        '
        'transaction_locking
        '
        Me.transaction_locking.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.transaction_locking.TableName = "transaction_locking"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "transaction_locking_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "journal_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "journal_name"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "date_from"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "date_to"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "isLock"
        Me.DataColumn7.DataType = GetType(Boolean)
        Me.DataColumn7.DefaultValue = True
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
        Me.MyButton2.Location = New System.Drawing.Point(98, 217)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(80, 24)
        Me.MyButton2.TabIndex = 285
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
        Me.MyButton1.Location = New System.Drawing.Point(12, 217)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(80, 24)
        Me.MyButton1.TabIndex = 284
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
        Me.MyButton4.Location = New System.Drawing.Point(98, 217)
        Me.MyButton4.Name = "MyButton4"
        Me.MyButton4.Size = New System.Drawing.Size(80, 24)
        Me.MyButton4.TabIndex = 288
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
        Me.MyButton5.Location = New System.Drawing.Point(12, 217)
        Me.MyButton5.Name = "MyButton5"
        Me.MyButton5.Size = New System.Drawing.Size(80, 24)
        Me.MyButton5.TabIndex = 287
        Me.MyButton5.Text = "&Save"
        Me.MyButton5.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_isLock)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_date_to)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_date_from)
        Me.GroupBox1.Controls.Add(Me.MyTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_transaction_locking_id)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 46)
        Me.GroupBox1.TabIndex = 283
        Me.GroupBox1.TabStop = False
        '
        'txt_isLock
        '
        Me.txt_isLock.AlwaysDisable = False
        Me.txt_isLock.AlwaysEnable = False
        Me.txt_isLock.AutoSize = True
        Me.txt_isLock.Checked = True
        Me.txt_isLock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.txt_isLock.Enabled = False
        Me.txt_isLock.isChecked = True
        Me.txt_isLock.Location = New System.Drawing.Point(662, 14)
        Me.txt_isLock.Name = "txt_isLock"
        Me.txt_isLock.NoSave = False
        Me.txt_isLock.Size = New System.Drawing.Size(50, 17)
        Me.txt_isLock.TabIndex = 5
        Me.txt_isLock.Text = "Lock"
        Me.txt_isLock.UseVisualStyleBackColor = True
        Me.txt_isLock.ValueSource = "isLock"
        Me.txt_isLock.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(504, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date To"
        '
        'txt_date_to
        '
        Me.txt_date_to.AlwaysDisable = False
        Me.txt_date_to.AlwaysEnable = False
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(556, 12)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.NoClear = False
        Me.txt_date_to.NoSave = False
        Me.txt_date_to.Required = False
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 4
        Me.txt_date_to.TextSource = "date_to"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date From"
        '
        'txt_date_from
        '
        Me.txt_date_from.AlwaysDisable = False
        Me.txt_date_from.AlwaysEnable = False
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(398, 15)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.NoClear = False
        Me.txt_date_from.NoSave = False
        Me.txt_date_from.Required = False
        Me.txt_date_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_from.TabIndex = 3
        Me.txt_date_from.TextSource = "date_from"
        '
        'MyTextBox2
        '
        Me.MyTextBox2.AlwaysDisable = False
        Me.MyTextBox2.AlwaysEnable = False
        Me.MyTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox2.BrowseDataSource = "[accounting_journal]"
        Me.MyTextBox2.BrowseField = "journal_code,journal_name"
        Me.MyTextBox2.BrowseFilter = Nothing
        Me.MyTextBox2.BrowseLabel = "Code,Name"
        Me.MyTextBox2.BrowseLabelWidth = "100,200"
        Me.MyTextBox2.BrowseTextSource = "journal_name"
        Me.MyTextBox2.BrowseValueSource = "journal_id"
        Me.MyTextBox2.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox2.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox2.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox2.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox2.Enabled = False
        Me.MyTextBox2.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox2.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox2.ID = False
        Me.MyTextBox2.Location = New System.Drawing.Point(130, 15)
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.NoClear = False
        Me.MyTextBox2.NoSave = False
        Me.MyTextBox2.NumberFormat = "@"
        Me.MyTextBox2.Required = True
        Me.MyTextBox2.RowData = Nothing
        Me.MyTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.MyTextBox2.TabIndex = 2
        Me.MyTextBox2.TextBrowse = True
        Me.MyTextBox2.TextSource = "journal_name"
        Me.MyTextBox2.ToUpper = True
        Me.MyTextBox2.Unique = False
        Me.MyTextBox2.Value = ""
        Me.MyTextBox2.ValueSource = "journal_id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transaction"
        '
        'txt_transaction_locking_id
        '
        Me.txt_transaction_locking_id.AlwaysDisable = False
        Me.txt_transaction_locking_id.AlwaysEnable = False
        Me.txt_transaction_locking_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_transaction_locking_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_transaction_locking_id.BrowseDataSource = ""
        Me.txt_transaction_locking_id.BrowseField = ""
        Me.txt_transaction_locking_id.BrowseFilter = Nothing
        Me.txt_transaction_locking_id.BrowseLabel = "Code,Name"
        Me.txt_transaction_locking_id.BrowseLabelWidth = "100,200"
        Me.txt_transaction_locking_id.BrowseTextSource = ""
        Me.txt_transaction_locking_id.BrowseValueSource = ""
        Me.txt_transaction_locking_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_transaction_locking_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_transaction_locking_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_transaction_locking_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_transaction_locking_id.Enabled = False
        Me.txt_transaction_locking_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_transaction_locking_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_transaction_locking_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_transaction_locking_id.ID = True
        Me.txt_transaction_locking_id.Location = New System.Drawing.Point(0, 0)
        Me.txt_transaction_locking_id.Name = "txt_transaction_locking_id"
        Me.txt_transaction_locking_id.NoClear = False
        Me.txt_transaction_locking_id.NoSave = False
        Me.txt_transaction_locking_id.NumberFormat = "@"
        Me.txt_transaction_locking_id.Required = False
        Me.txt_transaction_locking_id.RowData = Nothing
        Me.txt_transaction_locking_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_transaction_locking_id.TabIndex = 1
        Me.txt_transaction_locking_id.TextBrowse = False
        Me.txt_transaction_locking_id.TextSource = "transaction_locking_id"
        Me.txt_transaction_locking_id.ToUpper = True
        Me.txt_transaction_locking_id.Unique = False
        Me.txt_transaction_locking_id.Value = ""
        Me.txt_transaction_locking_id.ValueSource = ""
        Me.txt_transaction_locking_id.Visible = False
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
        Me.txtsearch.Location = New System.Drawing.Point(641, 34)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NoSave = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.Size = New System.Drawing.Size(147, 20)
        Me.txtsearch.TabIndex = 289
        Me.txtsearch.TextBrowse = False
        Me.txtsearch.TextSource = "module_name"
        Me.txtsearch.ToUpper = True
        Me.txtsearch.Unique = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(597, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 290
        Me.Label6.Text = "Search"
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
        Me.MyButton3.Location = New System.Drawing.Point(184, 217)
        Me.MyButton3.Name = "MyButton3"
        Me.MyButton3.Size = New System.Drawing.Size(80, 24)
        Me.MyButton3.TabIndex = 286
        Me.MyButton3.Text = "F4 Delete"
        Me.MyButton3.UseVisualStyleBackColor = False
        Me.MyButton3.Visible = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 56)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(776, 2)
        Me.border1.TabIndex = 281
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FalseValue = "False"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.TrueValue = "True"
        Me.sel.Width = 30
        '
        'transaction_locking_id
        '
        Me.transaction_locking_id.DataPropertyName = "transaction_locking_id"
        Me.transaction_locking_id.HeaderText = "ID"
        Me.transaction_locking_id.Name = "transaction_locking_id"
        Me.transaction_locking_id.ReadOnly = True
        Me.transaction_locking_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.transaction_locking_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.transaction_locking_id.Visible = False
        '
        'journal_name
        '
        Me.journal_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.journal_name.DataPropertyName = "journal_name"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.journal_name.DefaultCellStyle = DataGridViewCellStyle1
        Me.journal_name.HeaderText = "Transaction"
        Me.journal_name.Name = "journal_name"
        Me.journal_name.ReadOnly = True
        '
        'date_from
        '
        Me.date_from.DataPropertyName = "date_from"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = "00/00/0000"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.date_from.DefaultCellStyle = DataGridViewCellStyle2
        Me.date_from.HeaderText = "Date From"
        Me.date_from.Name = "date_from"
        Me.date_from.ReadOnly = True
        '
        'date_to
        '
        Me.date_to.DataPropertyName = "date_to"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = "00/00/0000"
        Me.date_to.DefaultCellStyle = DataGridViewCellStyle3
        Me.date_to.HeaderText = "Date To"
        Me.date_to.Name = "date_to"
        Me.date_to.ReadOnly = True
        '
        'transactionlocking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 305)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MyButton3)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.MyButton4)
        Me.Controls.Add(Me.MyButton5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Myformheader1)
        Me.CustomQuery = "[transaction_locking]"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ModuleCode = "ACC00801"
        Me.MyDataBase = user_control.MyList.Database.Main
        Me.MyDGView = Me.dgMain
        Me.MyTable = "transaction_locking"
        Me.Name = "transactionlocking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Locking"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transaction_locking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents MyButton2 As user_control.MyButton
    Friend WithEvents MyButton1 As user_control.MyButton
    Friend WithEvents MyButton4 As user_control.MyButton
    Friend WithEvents MyButton5 As user_control.MyButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox2 As user_control.MyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_transaction_locking_id As user_control.MyTextBox
    Friend WithEvents txtsearch As user_control.MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents transaction_locking As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents txt_isLock As user_control.MyCheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_date_to As user_control.myDatePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_date_from As user_control.myDatePicker
    Friend WithEvents MyButton3 As user_control.MyButton
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents transaction_locking_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_from As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_to As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
