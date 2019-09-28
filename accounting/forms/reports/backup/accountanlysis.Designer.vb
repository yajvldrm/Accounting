<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountanlysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accountanlysis))
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.range_filter = New System.Windows.Forms.Panel()
        Me.rdo3 = New user_control.rdo_button()
        Me.rdo2 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_jbooks = New user_control.textbox()
        Me.allJBooks = New System.Windows.Forms.CheckBox()
        Me.dgBooks = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkAll = New System.Windows.Forms.CheckBox()
        Me.allocation_filter = New System.Windows.Forms.Panel()
        Me.txt_allocation = New user_control.textbox()
        Me.rdo_3 = New user_control.rdo_button()
        Me.rdo_2 = New user_control.rdo_button()
        Me.rdo_1 = New user_control.rdo_button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.account_filter = New user_control.textbox()
        Me.txt_account_id = New user_control.textbox()
        Me.txt_general_id = New user_control.textbox()
        Me.lbl_account_name = New System.Windows.Forms.Label()
        Me.lbl_general_name = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.wPreviosBalance = New System.Windows.Forms.CheckBox()
        Me.wRunningBalance = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.project_1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_department_id = New user_control.textbox()
        Me.withProject = New System.Windows.Forms.CheckBox()
        Me.txt_project_id = New user_control.textbox()
        Me.withDepartment = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_filter_project = New user_control.textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.currency_2 = New System.Windows.Forms.Panel()
        Me.txt_currency_name = New System.Windows.Forms.Label()
        Me.txt_currency_id = New user_control.textbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.currency_1 = New System.Windows.Forms.Panel()
        Me.rdo12 = New user_control.rdo_button()
        Me.rdo11 = New user_control.rdo_button()
        Me.txt_filter_currency = New user_control.textbox()
        Me.filter1 = New user_control.textbox()
        Me.txt_sortby = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.range_filter.SuspendLayout()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.allocation_filter.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.project_1.SuspendLayout()
        Me.currency_2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.currency_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(239, 64)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(92, 19)
        Me.txt_date_to.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 12)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Date To"
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(99, 64)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(92, 19)
        Me.txt_date_from.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Date From"
        '
        'range_filter
        '
        Me.range_filter.Controls.Add(Me.rdo3)
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Location = New System.Drawing.Point(11, 39)
        Me.range_filter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(352, 21)
        Me.range_filter.TabIndex = 18
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.DataSource = ""
        Me.rdo3.Location = New System.Drawing.Point(186, 2)
        Me.rdo3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(158, 16)
        Me.rdo3.TabIndex = 2
        Me.rdo3.Text = "Range with Beginning Balance"
        Me.rdo3.TextSource = ""
        Me.rdo3.Uncheckable = False
        Me.rdo3.UseVisualStyleBackColor = True
        Me.rdo3.Value = "3"
        Me.rdo3.ValueSource = ""
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.DataSource = ""
        Me.rdo2.Location = New System.Drawing.Point(89, 3)
        Me.rdo2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(93, 16)
        Me.rdo2.TabIndex = 1
        Me.rdo2.Text = "To Date / As Of"
        Me.rdo2.TextSource = ""
        Me.rdo2.Uncheckable = False
        Me.rdo2.UseVisualStyleBackColor = True
        Me.rdo2.Value = "2"
        Me.rdo2.ValueSource = ""
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Checked = True
        Me.rdo1.DataSource = ""
        Me.rdo1.Location = New System.Drawing.Point(9, 2)
        Me.rdo1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(76, 16)
        Me.rdo1.TabIndex = 0
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Range Only"
        Me.rdo1.TextSource = ""
        Me.rdo1.Uncheckable = False
        Me.rdo1.UseVisualStyleBackColor = True
        Me.rdo1.Value = "1"
        Me.rdo1.ValueSource = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Account Analysis"
        '
        'txt_jbooks
        '
        Me.txt_jbooks._Text = ""
        Me.txt_jbooks.AlwaysDisable = False
        Me.txt_jbooks.AlwaysEnable = False
        Me.txt_jbooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_jbooks.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_jbooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jbooks.DataSource = ""
        Me.txt_jbooks.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_jbooks.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_jbooks.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_jbooks.Enabled = False
        Me.txt_jbooks.Location = New System.Drawing.Point(212, 109)
        Me.txt_jbooks.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_jbooks.MultiLine = False
        Me.txt_jbooks.Name = "txt_jbooks"
        Me.txt_jbooks.NoClear = False
        Me.txt_jbooks.NumberFormat = "@"
        Me.txt_jbooks.Required = False
        Me.txt_jbooks.RowData = Nothing
        Me.txt_jbooks.SelectionLength = 0
        Me.txt_jbooks.SelectionStart = 0
        Me.txt_jbooks.Size = New System.Drawing.Size(141, 18)
        Me.txt_jbooks.TabIndex = 25
        Me.txt_jbooks.TableData = Nothing
        Me.txt_jbooks.TextSource = ""
        Me.txt_jbooks.Value = ""
        Me.txt_jbooks.ValueSource = ""
        '
        'allJBooks
        '
        Me.allJBooks.AutoSize = True
        Me.allJBooks.Checked = True
        Me.allJBooks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.allJBooks.Location = New System.Drawing.Point(212, 92)
        Me.allJBooks.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.allJBooks.Name = "allJBooks"
        Me.allJBooks.Size = New System.Drawing.Size(71, 16)
        Me.allJBooks.TabIndex = 26
        Me.allJBooks.Text = "All Journal"
        Me.allJBooks.UseVisualStyleBackColor = True
        '
        'dgBooks
        '
        Me.dgBooks.AllowUserToAddRows = False
        Me.dgBooks.AllowUserToDeleteRows = False
        Me.dgBooks.BackgroundColor = System.Drawing.Color.White
        Me.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.book_name, Me.book_id})
        Me.dgBooks.EnableHeadersVisualStyles = False
        Me.dgBooks.Location = New System.Drawing.Point(13, 91)
        Me.dgBooks.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgBooks.MultiSelect = False
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersVisible = False
        Me.dgBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBooks.Size = New System.Drawing.Size(188, 155)
        Me.dgBooks.TabIndex = 27
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FalseValue = "False"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sel.TrueValue = "True"
        Me.sel.Width = 32
        '
        'book_name
        '
        Me.book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_name.DataPropertyName = "book_name"
        Me.book_name.HeaderText = "Book"
        Me.book_name.Name = "book_name"
        Me.book_name.ReadOnly = True
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.HeaderText = "ID"
        Me.book_id.Name = "book_id"
        Me.book_id.Visible = False
        '
        'checkAll
        '
        Me.checkAll.AutoSize = True
        Me.checkAll.Location = New System.Drawing.Point(23, 97)
        Me.checkAll.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.checkAll.Name = "checkAll"
        Me.checkAll.Size = New System.Drawing.Size(15, 14)
        Me.checkAll.TabIndex = 28
        Me.checkAll.UseVisualStyleBackColor = True
        '
        'allocation_filter
        '
        Me.allocation_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.allocation_filter.Controls.Add(Me.txt_allocation)
        Me.allocation_filter.Controls.Add(Me.rdo_3)
        Me.allocation_filter.Controls.Add(Me.rdo_2)
        Me.allocation_filter.Controls.Add(Me.rdo_1)
        Me.allocation_filter.Location = New System.Drawing.Point(211, 171)
        Me.allocation_filter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.allocation_filter.Name = "allocation_filter"
        Me.allocation_filter.Size = New System.Drawing.Size(152, 75)
        Me.allocation_filter.TabIndex = 31
        '
        'txt_allocation
        '
        Me.txt_allocation._Text = ""
        Me.txt_allocation.AlwaysDisable = False
        Me.txt_allocation.AlwaysEnable = False
        Me.txt_allocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_allocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_allocation.DataSource = ""
        Me.txt_allocation.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation.Enabled = False
        Me.txt_allocation.Location = New System.Drawing.Point(11, 52)
        Me.txt_allocation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_allocation.MultiLine = False
        Me.txt_allocation.Name = "txt_allocation"
        Me.txt_allocation.NoClear = False
        Me.txt_allocation.NumberFormat = "@"
        Me.txt_allocation.Required = False
        Me.txt_allocation.RowData = Nothing
        Me.txt_allocation.SelectionLength = 0
        Me.txt_allocation.SelectionStart = 0
        Me.txt_allocation.Size = New System.Drawing.Size(121, 18)
        Me.txt_allocation.TabIndex = 26
        Me.txt_allocation.TableData = Nothing
        Me.txt_allocation.TextSource = ""
        Me.txt_allocation.Value = ""
        Me.txt_allocation.ValueSource = ""
        '
        'rdo_3
        '
        Me.rdo_3.AutoSize = True
        Me.rdo_3.DataSource = ""
        Me.rdo_3.Location = New System.Drawing.Point(14, 34)
        Me.rdo_3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo_3.Name = "rdo_3"
        Me.rdo_3.Size = New System.Drawing.Size(109, 16)
        Me.rdo_3.TabIndex = 2
        Me.rdo_3.Text = "Print Per Allocation"
        Me.rdo_3.TextSource = ""
        Me.rdo_3.Uncheckable = False
        Me.rdo_3.UseVisualStyleBackColor = True
        Me.rdo_3.Value = "3"
        Me.rdo_3.ValueSource = ""
        '
        'rdo_2
        '
        Me.rdo_2.AutoSize = True
        Me.rdo_2.DataSource = ""
        Me.rdo_2.Location = New System.Drawing.Point(14, 17)
        Me.rdo_2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo_2.Name = "rdo_2"
        Me.rdo_2.Size = New System.Drawing.Size(113, 16)
        Me.rdo_2.TabIndex = 1
        Me.rdo_2.Text = "Print with Allocation"
        Me.rdo_2.TextSource = ""
        Me.rdo_2.Uncheckable = False
        Me.rdo_2.UseVisualStyleBackColor = True
        Me.rdo_2.Value = "2"
        Me.rdo_2.ValueSource = ""
        '
        'rdo_1
        '
        Me.rdo_1.AutoSize = True
        Me.rdo_1.Checked = True
        Me.rdo_1.DataSource = ""
        Me.rdo_1.Location = New System.Drawing.Point(14, 2)
        Me.rdo_1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo_1.Name = "rdo_1"
        Me.rdo_1.Size = New System.Drawing.Size(128, 16)
        Me.rdo_1.TabIndex = 0
        Me.rdo_1.TabStop = True
        Me.rdo_1.Text = "Print without Allocation"
        Me.rdo_1.TextSource = ""
        Me.rdo_1.Uncheckable = False
        Me.rdo_1.UseVisualStyleBackColor = True
        Me.rdo_1.Value = "1"
        Me.rdo_1.ValueSource = ""
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(193, 539)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(62, 22)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(125, 539)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(62, 22)
        Me.btnPrint.TabIndex = 34
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'account_filter
        '
        Me.account_filter._Text = ""
        Me.account_filter.AlwaysDisable = False
        Me.account_filter.AlwaysEnable = False
        Me.account_filter.BackColor = System.Drawing.Color.White
        Me.account_filter.BorderColor = System.Drawing.Color.DarkGray
        Me.account_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.account_filter.DataSource = ""
        Me.account_filter.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.account_filter.DisabledBackColor = System.Drawing.Color.White
        Me.account_filter.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.account_filter.Location = New System.Drawing.Point(13, 249)
        Me.account_filter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.account_filter.MultiLine = False
        Me.account_filter.Name = "account_filter"
        Me.account_filter.NoClear = False
        Me.account_filter.NumberFormat = "@"
        Me.account_filter.Required = False
        Me.account_filter.RowData = Nothing
        Me.account_filter.SelectionLength = 0
        Me.account_filter.SelectionStart = 0
        Me.account_filter.Size = New System.Drawing.Size(285, 18)
        Me.account_filter.TabIndex = 36
        Me.account_filter.TableData = Nothing
        Me.account_filter.TextSource = ""
        Me.account_filter.Value = ""
        Me.account_filter.ValueSource = ""
        '
        'txt_account_id
        '
        Me.txt_account_id._Text = ""
        Me.txt_account_id.AlwaysDisable = False
        Me.txt_account_id.AlwaysEnable = False
        Me.txt_account_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_id.DataSource = ""
        Me.txt_account_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_id.Enabled = False
        Me.txt_account_id.Location = New System.Drawing.Point(89, 274)
        Me.txt_account_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_account_id.MultiLine = False
        Me.txt_account_id.Name = "txt_account_id"
        Me.txt_account_id.NoClear = False
        Me.txt_account_id.NumberFormat = "@"
        Me.txt_account_id.Required = False
        Me.txt_account_id.RowData = Nothing
        Me.txt_account_id.SelectionLength = 0
        Me.txt_account_id.SelectionStart = 0
        Me.txt_account_id.Size = New System.Drawing.Size(84, 18)
        Me.txt_account_id.TabIndex = 37
        Me.txt_account_id.TableData = Nothing
        Me.txt_account_id.TextSource = ""
        Me.txt_account_id.Value = ""
        Me.txt_account_id.ValueSource = ""
        '
        'txt_general_id
        '
        Me.txt_general_id._Text = ""
        Me.txt_general_id.AlwaysDisable = False
        Me.txt_general_id.AlwaysEnable = False
        Me.txt_general_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.DataSource = ""
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.Enabled = False
        Me.txt_general_id.Location = New System.Drawing.Point(89, 298)
        Me.txt_general_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(84, 18)
        Me.txt_general_id.TabIndex = 38
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.TextSource = ""
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = ""
        '
        'lbl_account_name
        '
        Me.lbl_account_name.AutoSize = True
        Me.lbl_account_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_account_name.Location = New System.Drawing.Point(191, 277)
        Me.lbl_account_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_account_name.Name = "lbl_account_name"
        Me.lbl_account_name.Size = New System.Drawing.Size(87, 13)
        Me.lbl_account_name.TabIndex = 187
        Me.lbl_account_name.Text = "Account Name"
        '
        'lbl_general_name
        '
        Me.lbl_general_name.AutoSize = True
        Me.lbl_general_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_general_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_general_name.Location = New System.Drawing.Point(190, 301)
        Me.lbl_general_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_general_name.Name = "lbl_general_name"
        Me.lbl_general_name.Size = New System.Drawing.Size(86, 13)
        Me.lbl_general_name.TabIndex = 189
        Me.lbl_general_name.Text = "General Name"
        '
        'btnImport
        '
        Me.btnImport.Enabled = False
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Location = New System.Drawing.Point(302, 249)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(62, 22)
        Me.btnImport.TabIndex = 190
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 277)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 12)
        Me.Label8.TabIndex = 191
        Me.Label8.Text = "Account Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 301)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 12)
        Me.Label9.TabIndex = 192
        Me.Label9.Text = "General Lib."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(174, 300)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 188
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(174, 276)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 186
        Me.PictureBox1.TabStop = False
        '
        'wPreviosBalance
        '
        Me.wPreviosBalance.AutoSize = True
        Me.wPreviosBalance.Enabled = False
        Me.wPreviosBalance.Location = New System.Drawing.Point(211, 133)
        Me.wPreviosBalance.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.wPreviosBalance.Name = "wPreviosBalance"
        Me.wPreviosBalance.Size = New System.Drawing.Size(146, 16)
        Me.wPreviosBalance.TabIndex = 29
        Me.wPreviosBalance.Text = "Print with Previous Balance"
        Me.wPreviosBalance.UseVisualStyleBackColor = True
        Me.wPreviosBalance.Visible = False
        '
        'wRunningBalance
        '
        Me.wRunningBalance.AutoSize = True
        Me.wRunningBalance.Enabled = False
        Me.wRunningBalance.Location = New System.Drawing.Point(211, 152)
        Me.wRunningBalance.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.wRunningBalance.Name = "wRunningBalance"
        Me.wRunningBalance.Size = New System.Drawing.Size(145, 16)
        Me.wRunningBalance.TabIndex = 30
        Me.wRunningBalance.Text = "Print with Running Balance"
        Me.wRunningBalance.UseVisualStyleBackColor = True
        Me.wRunningBalance.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.project_1)
        Me.GroupBox2.Controls.Add(Me.txt_filter_project)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.currency_2)
        Me.GroupBox2.Controls.Add(Me.currency_1)
        Me.GroupBox2.Controls.Add(Me.txt_filter_currency)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 165)
        Me.GroupBox2.TabIndex = 196
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 75)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 12)
        Me.Label10.TabIndex = 201
        Me.Label10.Text = "Project / Department"
        '
        'project_1
        '
        Me.project_1.Controls.Add(Me.Label6)
        Me.project_1.Controls.Add(Me.txt_department_id)
        Me.project_1.Controls.Add(Me.withProject)
        Me.project_1.Controls.Add(Me.txt_project_id)
        Me.project_1.Controls.Add(Me.withDepartment)
        Me.project_1.Controls.Add(Me.Label5)
        Me.project_1.Location = New System.Drawing.Point(10, 96)
        Me.project_1.Name = "project_1"
        Me.project_1.Size = New System.Drawing.Size(333, 58)
        Me.project_1.TabIndex = 199
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 13)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "W/ PROJECT"
        '
        'txt_department_id
        '
        Me.txt_department_id._Text = ""
        Me.txt_department_id.AlwaysDisable = False
        Me.txt_department_id.AlwaysEnable = False
        Me.txt_department_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department_id.DataSource = ""
        Me.txt_department_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.Enabled = False
        Me.txt_department_id.Location = New System.Drawing.Point(203, 31)
        Me.txt_department_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_department_id.MultiLine = False
        Me.txt_department_id.Name = "txt_department_id"
        Me.txt_department_id.NoClear = False
        Me.txt_department_id.NumberFormat = "@"
        Me.txt_department_id.Required = False
        Me.txt_department_id.RowData = Nothing
        Me.txt_department_id.SelectionLength = 0
        Me.txt_department_id.SelectionStart = 0
        Me.txt_department_id.Size = New System.Drawing.Size(121, 18)
        Me.txt_department_id.TabIndex = 185
        Me.txt_department_id.TableData = Nothing
        Me.txt_department_id.TextSource = ""
        Me.txt_department_id.Value = ""
        Me.txt_department_id.ValueSource = ""
        '
        'withProject
        '
        Me.withProject.AutoSize = True
        Me.withProject.Enabled = False
        Me.withProject.Location = New System.Drawing.Point(98, 12)
        Me.withProject.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.withProject.Name = "withProject"
        Me.withProject.Size = New System.Drawing.Size(83, 16)
        Me.withProject.TabIndex = 3
        Me.withProject.Text = "Project Code"
        Me.withProject.UseVisualStyleBackColor = True
        '
        'txt_project_id
        '
        Me.txt_project_id._Text = ""
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
        Me.txt_project_id.Location = New System.Drawing.Point(203, 9)
        Me.txt_project_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_project_id.MultiLine = False
        Me.txt_project_id.Name = "txt_project_id"
        Me.txt_project_id.NoClear = False
        Me.txt_project_id.NumberFormat = "@"
        Me.txt_project_id.Required = False
        Me.txt_project_id.RowData = Nothing
        Me.txt_project_id.SelectionLength = 0
        Me.txt_project_id.SelectionStart = 0
        Me.txt_project_id.Size = New System.Drawing.Size(121, 18)
        Me.txt_project_id.TabIndex = 184
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.TextSource = ""
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = ""
        '
        'withDepartment
        '
        Me.withDepartment.AutoSize = True
        Me.withDepartment.Enabled = False
        Me.withDepartment.Location = New System.Drawing.Point(98, 33)
        Me.withDepartment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.withDepartment.Name = "withDepartment"
        Me.withDepartment.Size = New System.Drawing.Size(103, 16)
        Me.withDepartment.TabIndex = 5
        Me.withDepartment.Text = "Department Code"
        Me.withDepartment.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "W/ DEPARTMENT"
        '
        'txt_filter_project
        '
        Me.txt_filter_project._Text = ""
        Me.txt_filter_project.AlwaysDisable = False
        Me.txt_filter_project.AlwaysEnable = False
        Me.txt_filter_project.BackColor = System.Drawing.Color.White
        Me.txt_filter_project.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filter_project.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filter_project.DataSource = ""
        Me.txt_filter_project.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_project.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_project.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filter_project.Location = New System.Drawing.Point(123, 72)
        Me.txt_filter_project.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_filter_project.MultiLine = False
        Me.txt_filter_project.Name = "txt_filter_project"
        Me.txt_filter_project.NoClear = False
        Me.txt_filter_project.NumberFormat = "@"
        Me.txt_filter_project.Required = False
        Me.txt_filter_project.RowData = Nothing
        Me.txt_filter_project.SelectionLength = 0
        Me.txt_filter_project.SelectionStart = 0
        Me.txt_filter_project.Size = New System.Drawing.Size(213, 18)
        Me.txt_filter_project.TabIndex = 200
        Me.txt_filter_project.TableData = Nothing
        Me.txt_filter_project.TextSource = ""
        Me.txt_filter_project.Value = ""
        Me.txt_filter_project.ValueSource = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 19)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 12)
        Me.Label7.TabIndex = 198
        Me.Label7.Text = "Currency"
        '
        'currency_2
        '
        Me.currency_2.Controls.Add(Me.txt_currency_name)
        Me.currency_2.Controls.Add(Me.txt_currency_id)
        Me.currency_2.Controls.Add(Me.PictureBox2)
        Me.currency_2.Location = New System.Drawing.Point(17, 40)
        Me.currency_2.Name = "currency_2"
        Me.currency_2.Size = New System.Drawing.Size(319, 26)
        Me.currency_2.TabIndex = 197
        Me.currency_2.Visible = False
        '
        'txt_currency_name
        '
        Me.txt_currency_name.AutoSize = True
        Me.txt_currency_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currency_name.ForeColor = System.Drawing.Color.Blue
        Me.txt_currency_name.Location = New System.Drawing.Point(91, 7)
        Me.txt_currency_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txt_currency_name.Name = "txt_currency_name"
        Me.txt_currency_name.Size = New System.Drawing.Size(91, 13)
        Me.txt_currency_name.TabIndex = 185
        Me.txt_currency_name.Text = "Currency Name"
        '
        'txt_currency_id
        '
        Me.txt_currency_id._Text = ""
        Me.txt_currency_id.AlwaysDisable = False
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.White
        Me.txt_currency_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.DataSource = ""
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.Location = New System.Drawing.Point(4, 4)
        Me.txt_currency_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_currency_id.MultiLine = False
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.SelectionLength = 0
        Me.txt_currency_id.SelectionStart = 0
        Me.txt_currency_id.Size = New System.Drawing.Size(71, 18)
        Me.txt_currency_id.TabIndex = 183
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.TextSource = ""
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(75, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 184
        Me.PictureBox2.TabStop = False
        '
        'currency_1
        '
        Me.currency_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currency_1.Controls.Add(Me.rdo12)
        Me.currency_1.Controls.Add(Me.rdo11)
        Me.currency_1.Location = New System.Drawing.Point(17, 40)
        Me.currency_1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.currency_1.Name = "currency_1"
        Me.currency_1.Size = New System.Drawing.Size(311, 21)
        Me.currency_1.TabIndex = 195
        Me.currency_1.Visible = False
        '
        'rdo12
        '
        Me.rdo12.AutoSize = True
        Me.rdo12.DataSource = ""
        Me.rdo12.Location = New System.Drawing.Point(143, 4)
        Me.rdo12.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo12.Name = "rdo12"
        Me.rdo12.Size = New System.Drawing.Size(140, 16)
        Me.rdo12.TabIndex = 1
        Me.rdo12.Text = "With Comparison Amount"
        Me.rdo12.TextSource = ""
        Me.rdo12.Uncheckable = False
        Me.rdo12.UseVisualStyleBackColor = True
        Me.rdo12.Value = "2"
        Me.rdo12.ValueSource = ""
        '
        'rdo11
        '
        Me.rdo11.AutoSize = True
        Me.rdo11.Checked = True
        Me.rdo11.DataSource = ""
        Me.rdo11.Location = New System.Drawing.Point(25, 4)
        Me.rdo11.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo11.Name = "rdo11"
        Me.rdo11.Size = New System.Drawing.Size(132, 16)
        Me.rdo11.TabIndex = 0
        Me.rdo11.TabStop = True
        Me.rdo11.Text = "No Comparison Amount"
        Me.rdo11.TextSource = ""
        Me.rdo11.Uncheckable = False
        Me.rdo11.UseVisualStyleBackColor = True
        Me.rdo11.Value = "1"
        Me.rdo11.ValueSource = ""
        '
        'txt_filter_currency
        '
        Me.txt_filter_currency._Text = ""
        Me.txt_filter_currency.AlwaysDisable = False
        Me.txt_filter_currency.AlwaysEnable = False
        Me.txt_filter_currency.BackColor = System.Drawing.Color.White
        Me.txt_filter_currency.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filter_currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filter_currency.DataSource = ""
        Me.txt_filter_currency.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_currency.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_currency.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filter_currency.Location = New System.Drawing.Point(67, 16)
        Me.txt_filter_currency.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_filter_currency.MultiLine = False
        Me.txt_filter_currency.Name = "txt_filter_currency"
        Me.txt_filter_currency.NoClear = False
        Me.txt_filter_currency.NumberFormat = "@"
        Me.txt_filter_currency.Required = False
        Me.txt_filter_currency.RowData = Nothing
        Me.txt_filter_currency.SelectionLength = 0
        Me.txt_filter_currency.SelectionStart = 0
        Me.txt_filter_currency.Size = New System.Drawing.Size(269, 18)
        Me.txt_filter_currency.TabIndex = 196
        Me.txt_filter_currency.TableData = Nothing
        Me.txt_filter_currency.TextSource = ""
        Me.txt_filter_currency.Value = ""
        Me.txt_filter_currency.ValueSource = ""
        '
        'filter1
        '
        Me.filter1._Text = ""
        Me.filter1.AlwaysDisable = False
        Me.filter1.AlwaysEnable = False
        Me.filter1.BackColor = System.Drawing.Color.White
        Me.filter1.BorderColor = System.Drawing.Color.DarkGray
        Me.filter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filter1.DataSource = ""
        Me.filter1.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.filter1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.filter1.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.filter1.Location = New System.Drawing.Point(61, 491)
        Me.filter1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.filter1.MultiLine = False
        Me.filter1.Name = "filter1"
        Me.filter1.NoClear = False
        Me.filter1.NumberFormat = "@"
        Me.filter1.Required = False
        Me.filter1.RowData = Nothing
        Me.filter1.SelectionLength = 0
        Me.filter1.SelectionStart = 0
        Me.filter1.Size = New System.Drawing.Size(303, 18)
        Me.filter1.TabIndex = 199
        Me.filter1.TableData = Nothing
        Me.filter1.TextSource = ""
        Me.filter1.Value = ""
        Me.filter1.ValueSource = ""
        '
        'txt_sortby
        '
        Me.txt_sortby._Text = ""
        Me.txt_sortby.AlwaysDisable = False
        Me.txt_sortby.AlwaysEnable = False
        Me.txt_sortby.BackColor = System.Drawing.Color.White
        Me.txt_sortby.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_sortby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sortby.DataSource = ""
        Me.txt_sortby.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sortby.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sortby.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_sortby.Location = New System.Drawing.Point(61, 515)
        Me.txt_sortby.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_sortby.MultiLine = False
        Me.txt_sortby.Name = "txt_sortby"
        Me.txt_sortby.NoClear = False
        Me.txt_sortby.NumberFormat = "@"
        Me.txt_sortby.Required = False
        Me.txt_sortby.RowData = Nothing
        Me.txt_sortby.SelectionLength = 0
        Me.txt_sortby.SelectionStart = 0
        Me.txt_sortby.Size = New System.Drawing.Size(304, 18)
        Me.txt_sortby.TabIndex = 200
        Me.txt_sortby.TableData = Nothing
        Me.txt_sortby.TextSource = ""
        Me.txt_sortby.Value = ""
        Me.txt_sortby.ValueSource = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 518)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 12)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Sort By"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(10, 34)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(352, 2)
        Me.border1.TabIndex = 17
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 494)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 12)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Sub Total"
        '
        'accountanlysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 572)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_sortby)
        Me.Controls.Add(Me.filter1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.lbl_general_name)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbl_account_name)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_general_id)
        Me.Controls.Add(Me.txt_account_id)
        Me.Controls.Add(Me.account_filter)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.allocation_filter)
        Me.Controls.Add(Me.wRunningBalance)
        Me.Controls.Add(Me.wPreviosBalance)
        Me.Controls.Add(Me.checkAll)
        Me.Controls.Add(Me.dgBooks)
        Me.Controls.Add(Me.allJBooks)
        Me.Controls.Add(Me.txt_jbooks)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.range_filter)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "accountanlysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Analysis"
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.allocation_filter.ResumeLayout(False)
        Me.allocation_filter.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.project_1.ResumeLayout(False)
        Me.project_1.PerformLayout()
        Me.currency_2.ResumeLayout(False)
        Me.currency_2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.currency_1.ResumeLayout(False)
        Me.currency_1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents range_filter As System.Windows.Forms.Panel
    Friend WithEvents rdo3 As user_control.rdo_button
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_jbooks As user_control.textbox
    Friend WithEvents allJBooks As System.Windows.Forms.CheckBox
    Friend WithEvents dgBooks As System.Windows.Forms.DataGridView
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkAll As System.Windows.Forms.CheckBox
    Friend WithEvents allocation_filter As System.Windows.Forms.Panel
    Friend WithEvents rdo_3 As user_control.rdo_button
    Friend WithEvents rdo_2 As user_control.rdo_button
    Friend WithEvents rdo_1 As user_control.rdo_button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txt_allocation As user_control.textbox
    Friend WithEvents account_filter As user_control.textbox
    Friend WithEvents txt_account_id As user_control.textbox
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents lbl_account_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_general_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents wPreviosBalance As System.Windows.Forms.CheckBox
    Friend WithEvents wRunningBalance As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents currency_2 As System.Windows.Forms.Panel
    Friend WithEvents txt_currency_name As System.Windows.Forms.Label
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents currency_1 As System.Windows.Forms.Panel
    Friend WithEvents rdo12 As user_control.rdo_button
    Friend WithEvents rdo11 As user_control.rdo_button
    Friend WithEvents txt_filter_currency As user_control.textbox
    Friend WithEvents filter1 As user_control.textbox
    Friend WithEvents txt_sortby As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents project_1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_department_id As user_control.textbox
    Friend WithEvents withProject As System.Windows.Forms.CheckBox
    Friend WithEvents txt_project_id As user_control.textbox
    Friend WithEvents withDepartment As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_filter_project As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
