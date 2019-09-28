<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accountanlysis
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
        Me.dgBooks = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allocation_filter = New System.Windows.Forms.Panel()
        Me.lbl_allocation_name = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.rdo_allocation_2 = New user_control.rdo_button()
        Me.rdo_allocation_1 = New user_control.rdo_button()
        Me.txt_allocation_id = New user_control.textbox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.account_filter = New System.Windows.Forms.GroupBox()
        Me.rdo_account_2 = New user_control.rdo_button()
        Me.btnImportAccount = New System.Windows.Forms.Button()
        Me.lbl_account_name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdo_account_3 = New user_control.rdo_button()
        Me.rdo_account_1 = New user_control.rdo_button()
        Me.txt_account_id = New user_control.textbox()
        Me.checkAllJournal = New System.Windows.Forms.CheckBox()
        Me.dgJournal = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.journal_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_filter = New System.Windows.Forms.GroupBox()
        Me.rdo_general_2 = New user_control.rdo_button()
        Me.btnImportGeneral = New System.Windows.Forms.Button()
        Me.lbl_general_name = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.rdo_general_3 = New user_control.rdo_button()
        Me.rdo_general_1 = New user_control.rdo_button()
        Me.txt_general_id = New user_control.textbox()
        Me.currency_filter = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.withComparison = New System.Windows.Forms.CheckBox()
        Me.lbl_currency_name = New System.Windows.Forms.Label()
        Me.rdo_currency_2 = New user_control.rdo_button()
        Me.txt_currency_id = New user_control.textbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rdo_currency_1 = New user_control.rdo_button()
        Me.project_department_filter = New System.Windows.Forms.GroupBox()
        Me.lbl_department_name = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbl_project_name = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.withProjectDepartment = New System.Windows.Forms.CheckBox()
        Me.txt_department_id = New user_control.textbox()
        Me.txt_project_id = New user_control.textbox()
        Me.filter1 = New System.Windows.Forms.Panel()
        Me.rdo_filter_2 = New user_control.rdo_button()
        Me.rdo_filter_3 = New user_control.rdo_button()
        Me.rdo_filter_4 = New user_control.rdo_button()
        Me.rdo_filter_1 = New user_control.rdo_button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.Myformheader1 = New user_control.myformheader()
        Me.txt_sortby = New user_control.textbox()
        Me.checkAllBooks = New System.Windows.Forms.CheckBox()
        Me.dgBookUnit = New System.Windows.Forms.DataGridView()
        Me.sel2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_unit_no_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_unit_no_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkAllBookUnit = New System.Windows.Forms.CheckBox()
        Me.txtSearchUnit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.w_running_balance = New System.Windows.Forms.CheckBox()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.Borderedlabel2 = New accounting.borderedlabel()
        Me.Borderedlabel1 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.w_currency = New System.Windows.Forms.CheckBox()
        Me.range_filter.SuspendLayout()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.allocation_filter.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.account_filter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.general_filter.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.currency_filter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_department_filter.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filter1.SuspendLayout()
        CType(Me.dgBookUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(289, 104)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Date To"
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(126, 104)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_from.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Date From"
        '
        'range_filter
        '
        Me.range_filter.Controls.Add(Me.rdo3)
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Location = New System.Drawing.Point(11, 66)
        Me.range_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(446, 30)
        Me.range_filter.TabIndex = 18
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.DataSource = ""
        Me.rdo3.Location = New System.Drawing.Point(244, 7)
        Me.rdo3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(168, 17)
        Me.rdo3.TabIndex = 3
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
        Me.rdo2.Location = New System.Drawing.Point(130, 7)
        Me.rdo2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(100, 17)
        Me.rdo2.TabIndex = 2
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
        Me.rdo1.Location = New System.Drawing.Point(35, 7)
        Me.rdo1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(81, 17)
        Me.rdo1.TabIndex = 1
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
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Account Analysis"
        '
        'dgBooks
        '
        Me.dgBooks.AllowUserToAddRows = False
        Me.dgBooks.AllowUserToDeleteRows = False
        Me.dgBooks.AllowUserToResizeColumns = False
        Me.dgBooks.AllowUserToResizeRows = False
        Me.dgBooks.BackgroundColor = System.Drawing.Color.White
        Me.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.book_name, Me.book_id})
        Me.dgBooks.EnableHeadersVisualStyles = False
        Me.dgBooks.Location = New System.Drawing.Point(692, 66)
        Me.dgBooks.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgBooks.MultiSelect = False
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersVisible = False
        Me.dgBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBooks.Size = New System.Drawing.Size(220, 220)
        Me.dgBooks.TabIndex = 27
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FalseValue = "False"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        Me.book_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.HeaderText = "Book ID"
        Me.book_id.Name = "book_id"
        Me.book_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.book_id.Visible = False
        '
        'allocation_filter
        '
        Me.allocation_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.allocation_filter.Controls.Add(Me.lbl_allocation_name)
        Me.allocation_filter.Controls.Add(Me.PictureBox7)
        Me.allocation_filter.Controls.Add(Me.rdo_allocation_2)
        Me.allocation_filter.Controls.Add(Me.rdo_allocation_1)
        Me.allocation_filter.Controls.Add(Me.txt_allocation_id)
        Me.allocation_filter.Location = New System.Drawing.Point(467, 294)
        Me.allocation_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.allocation_filter.Name = "allocation_filter"
        Me.allocation_filter.Size = New System.Drawing.Size(670, 64)
        Me.allocation_filter.TabIndex = 197
        '
        'lbl_allocation_name
        '
        Me.lbl_allocation_name.AutoSize = True
        Me.lbl_allocation_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_allocation_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_allocation_name.Location = New System.Drawing.Point(429, 35)
        Me.lbl_allocation_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_allocation_name.Name = "lbl_allocation_name"
        Me.lbl_allocation_name.Size = New System.Drawing.Size(97, 16)
        Me.lbl_allocation_name.TabIndex = 196
        Me.lbl_allocation_name.Text = "Allocation Name"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(409, 36)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 195
        Me.PictureBox7.TabStop = False
        '
        'rdo_allocation_2
        '
        Me.rdo_allocation_2.AutoSize = True
        Me.rdo_allocation_2.DataSource = ""
        Me.rdo_allocation_2.Location = New System.Drawing.Point(132, 34)
        Me.rdo_allocation_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_allocation_2.Name = "rdo_allocation_2"
        Me.rdo_allocation_2.Size = New System.Drawing.Size(119, 17)
        Me.rdo_allocation_2.TabIndex = 26
        Me.rdo_allocation_2.Text = "Print with Allocation"
        Me.rdo_allocation_2.TextSource = ""
        Me.rdo_allocation_2.Uncheckable = False
        Me.rdo_allocation_2.UseVisualStyleBackColor = True
        Me.rdo_allocation_2.Value = "2"
        Me.rdo_allocation_2.ValueSource = ""
        '
        'rdo_allocation_1
        '
        Me.rdo_allocation_1.AutoSize = True
        Me.rdo_allocation_1.Checked = True
        Me.rdo_allocation_1.DataSource = ""
        Me.rdo_allocation_1.Location = New System.Drawing.Point(255, 11)
        Me.rdo_allocation_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_allocation_1.Name = "rdo_allocation_1"
        Me.rdo_allocation_1.Size = New System.Drawing.Size(135, 17)
        Me.rdo_allocation_1.TabIndex = 25
        Me.rdo_allocation_1.TabStop = True
        Me.rdo_allocation_1.Text = "Print without Allocation"
        Me.rdo_allocation_1.TextSource = ""
        Me.rdo_allocation_1.Uncheckable = False
        Me.rdo_allocation_1.UseVisualStyleBackColor = True
        Me.rdo_allocation_1.Value = "1"
        Me.rdo_allocation_1.ValueSource = ""
        '
        'txt_allocation_id
        '
        Me.txt_allocation_id._Text = ""
        Me.txt_allocation_id.AllowNegative = False
        Me.txt_allocation_id.AlwaysDisable = False
        Me.txt_allocation_id.AlwaysEnable = False
        Me.txt_allocation_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_allocation_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_allocation_id.DataSource = ""
        Me.txt_allocation_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_id.Enabled = False
        Me.txt_allocation_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_allocation_id.ispk = False
        Me.txt_allocation_id.Location = New System.Drawing.Point(255, 34)
        Me.txt_allocation_id.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_allocation_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_id.MultiLine = False
        Me.txt_allocation_id.Name = "txt_allocation_id"
        Me.txt_allocation_id.NoClear = False
        Me.txt_allocation_id.NumberFormat = "@"
        Me.txt_allocation_id.Required = False
        Me.txt_allocation_id.RowData = Nothing
        Me.txt_allocation_id.SelectionLength = 0
        Me.txt_allocation_id.SelectionStart = 0
        Me.txt_allocation_id.Size = New System.Drawing.Size(150, 19)
        Me.txt_allocation_id.TabIndex = 27
        Me.txt_allocation_id.TableData = Nothing
        Me.txt_allocation_id.TextSource = ""
        Me.txt_allocation_id.UseSystemPasswordChar = False
        Me.txt_allocation_id.Value = ""
        Me.txt_allocation_id.ValueSource = ""
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(612, 466)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(533, 466)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 33
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(475, 438)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Sort By"
        '
        'account_filter
        '
        Me.account_filter.Controls.Add(Me.rdo_account_2)
        Me.account_filter.Controls.Add(Me.btnImportAccount)
        Me.account_filter.Controls.Add(Me.lbl_account_name)
        Me.account_filter.Controls.Add(Me.PictureBox1)
        Me.account_filter.Controls.Add(Me.rdo_account_3)
        Me.account_filter.Controls.Add(Me.rdo_account_1)
        Me.account_filter.Controls.Add(Me.txt_account_id)
        Me.account_filter.Location = New System.Drawing.Point(13, 132)
        Me.account_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.account_filter.Name = "account_filter"
        Me.account_filter.Padding = New System.Windows.Forms.Padding(4)
        Me.account_filter.Size = New System.Drawing.Size(442, 70)
        Me.account_filter.TabIndex = 205
        Me.account_filter.TabStop = False
        Me.account_filter.Text = "Account"
        '
        'rdo_account_2
        '
        Me.rdo_account_2.AutoSize = True
        Me.rdo_account_2.DataSource = ""
        Me.rdo_account_2.Location = New System.Drawing.Point(72, 18)
        Me.rdo_account_2.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo_account_2.Name = "rdo_account_2"
        Me.rdo_account_2.Size = New System.Drawing.Size(61, 17)
        Me.rdo_account_2.TabIndex = 7
        Me.rdo_account_2.Text = "Multiple"
        Me.rdo_account_2.TextSource = ""
        Me.rdo_account_2.Uncheckable = False
        Me.rdo_account_2.UseVisualStyleBackColor = True
        Me.rdo_account_2.Value = "2"
        Me.rdo_account_2.ValueSource = ""
        '
        'btnImportAccount
        '
        Me.btnImportAccount.Enabled = False
        Me.btnImportAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportAccount.Location = New System.Drawing.Point(137, 17)
        Me.btnImportAccount.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnImportAccount.Name = "btnImportAccount"
        Me.btnImportAccount.Size = New System.Drawing.Size(30, 20)
        Me.btnImportAccount.TabIndex = 8
        Me.btnImportAccount.Text = "..."
        Me.btnImportAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImportAccount.UseVisualStyleBackColor = True
        '
        'lbl_account_name
        '
        Me.lbl_account_name.AutoSize = True
        Me.lbl_account_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_account_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_account_name.Location = New System.Drawing.Point(196, 42)
        Me.lbl_account_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_account_name.Name = "lbl_account_name"
        Me.lbl_account_name.Size = New System.Drawing.Size(90, 16)
        Me.lbl_account_name.TabIndex = 192
        Me.lbl_account_name.Text = "Account Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 42)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 191
        Me.PictureBox1.TabStop = False
        '
        'rdo_account_3
        '
        Me.rdo_account_3.AutoSize = True
        Me.rdo_account_3.DataSource = ""
        Me.rdo_account_3.Location = New System.Drawing.Point(7, 40)
        Me.rdo_account_3.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo_account_3.Name = "rdo_account_3"
        Me.rdo_account_3.Size = New System.Drawing.Size(61, 17)
        Me.rdo_account_3.TabIndex = 9
        Me.rdo_account_3.Text = "Specific"
        Me.rdo_account_3.TextSource = ""
        Me.rdo_account_3.Uncheckable = False
        Me.rdo_account_3.UseVisualStyleBackColor = True
        Me.rdo_account_3.Value = "3"
        Me.rdo_account_3.ValueSource = ""
        '
        'rdo_account_1
        '
        Me.rdo_account_1.AutoSize = True
        Me.rdo_account_1.Checked = True
        Me.rdo_account_1.DataSource = ""
        Me.rdo_account_1.Location = New System.Drawing.Point(7, 18)
        Me.rdo_account_1.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo_account_1.Name = "rdo_account_1"
        Me.rdo_account_1.Size = New System.Drawing.Size(36, 17)
        Me.rdo_account_1.TabIndex = 6
        Me.rdo_account_1.TabStop = True
        Me.rdo_account_1.Text = "All"
        Me.rdo_account_1.TextSource = ""
        Me.rdo_account_1.Uncheckable = False
        Me.rdo_account_1.UseVisualStyleBackColor = True
        Me.rdo_account_1.Value = "1"
        Me.rdo_account_1.ValueSource = ""
        '
        'txt_account_id
        '
        Me.txt_account_id._Text = ""
        Me.txt_account_id.AllowNegative = False
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
        Me.txt_account_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_id.ispk = False
        Me.txt_account_id.Location = New System.Drawing.Point(72, 40)
        Me.txt_account_id.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_account_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.MultiLine = False
        Me.txt_account_id.Name = "txt_account_id"
        Me.txt_account_id.NoClear = False
        Me.txt_account_id.NumberFormat = "@"
        Me.txt_account_id.Required = False
        Me.txt_account_id.RowData = Nothing
        Me.txt_account_id.SelectionLength = 0
        Me.txt_account_id.SelectionStart = 0
        Me.txt_account_id.Size = New System.Drawing.Size(100, 19)
        Me.txt_account_id.TabIndex = 10
        Me.txt_account_id.TableData = Nothing
        Me.txt_account_id.TextSource = ""
        Me.txt_account_id.UseSystemPasswordChar = False
        Me.txt_account_id.Value = ""
        Me.txt_account_id.ValueSource = ""
        '
        'checkAllJournal
        '
        Me.checkAllJournal.AutoSize = True
        Me.checkAllJournal.Location = New System.Drawing.Point(477, 72)
        Me.checkAllJournal.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllJournal.Name = "checkAllJournal"
        Me.checkAllJournal.Size = New System.Drawing.Size(15, 14)
        Me.checkAllJournal.TabIndex = 23
        Me.checkAllJournal.UseVisualStyleBackColor = True
        '
        'dgJournal
        '
        Me.dgJournal.AllowUserToAddRows = False
        Me.dgJournal.AllowUserToDeleteRows = False
        Me.dgJournal.AllowUserToResizeColumns = False
        Me.dgJournal.AllowUserToResizeRows = False
        Me.dgJournal.BackgroundColor = System.Drawing.Color.White
        Me.dgJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgJournal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.journal_name, Me.journal_id})
        Me.dgJournal.EnableHeadersVisualStyles = False
        Me.dgJournal.Location = New System.Drawing.Point(467, 66)
        Me.dgJournal.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgJournal.MultiSelect = False
        Me.dgJournal.Name = "dgJournal"
        Me.dgJournal.RowHeadersVisible = False
        Me.dgJournal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgJournal.Size = New System.Drawing.Size(220, 220)
        Me.dgJournal.TabIndex = 206
        '
        'sel1
        '
        Me.sel1.DataPropertyName = "sel"
        Me.sel1.FalseValue = "False"
        Me.sel1.HeaderText = ""
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.TrueValue = "True"
        Me.sel1.Width = 32
        '
        'journal_name
        '
        Me.journal_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.journal_name.DataPropertyName = "journal_name"
        Me.journal_name.HeaderText = "Journal"
        Me.journal_name.Name = "journal_name"
        Me.journal_name.ReadOnly = True
        Me.journal_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'journal_id
        '
        Me.journal_id.DataPropertyName = "journal_id"
        Me.journal_id.HeaderText = "Journal ID"
        Me.journal_id.Name = "journal_id"
        Me.journal_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_id.Visible = False
        '
        'general_filter
        '
        Me.general_filter.Controls.Add(Me.rdo_general_2)
        Me.general_filter.Controls.Add(Me.btnImportGeneral)
        Me.general_filter.Controls.Add(Me.lbl_general_name)
        Me.general_filter.Controls.Add(Me.PictureBox3)
        Me.general_filter.Controls.Add(Me.rdo_general_3)
        Me.general_filter.Controls.Add(Me.rdo_general_1)
        Me.general_filter.Controls.Add(Me.txt_general_id)
        Me.general_filter.Location = New System.Drawing.Point(13, 210)
        Me.general_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.general_filter.Name = "general_filter"
        Me.general_filter.Padding = New System.Windows.Forms.Padding(4)
        Me.general_filter.Size = New System.Drawing.Size(442, 70)
        Me.general_filter.TabIndex = 208
        Me.general_filter.TabStop = False
        Me.general_filter.Text = "General Library"
        '
        'rdo_general_2
        '
        Me.rdo_general_2.AutoSize = True
        Me.rdo_general_2.DataSource = ""
        Me.rdo_general_2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.rdo_general_2.Location = New System.Drawing.Point(72, 18)
        Me.rdo_general_2.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo_general_2.Name = "rdo_general_2"
        Me.rdo_general_2.Size = New System.Drawing.Size(61, 17)
        Me.rdo_general_2.TabIndex = 12
        Me.rdo_general_2.Text = "Multiple"
        Me.rdo_general_2.TextSource = ""
        Me.rdo_general_2.Uncheckable = False
        Me.rdo_general_2.UseVisualStyleBackColor = True
        Me.rdo_general_2.Value = "2"
        Me.rdo_general_2.ValueSource = ""
        '
        'btnImportGeneral
        '
        Me.btnImportGeneral.Enabled = False
        Me.btnImportGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportGeneral.Location = New System.Drawing.Point(137, 17)
        Me.btnImportGeneral.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnImportGeneral.Name = "btnImportGeneral"
        Me.btnImportGeneral.Size = New System.Drawing.Size(30, 20)
        Me.btnImportGeneral.TabIndex = 13
        Me.btnImportGeneral.Text = "..."
        Me.btnImportGeneral.UseVisualStyleBackColor = True
        '
        'lbl_general_name
        '
        Me.lbl_general_name.AutoSize = True
        Me.lbl_general_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_general_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_general_name.Location = New System.Drawing.Point(196, 42)
        Me.lbl_general_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_general_name.Name = "lbl_general_name"
        Me.lbl_general_name.Size = New System.Drawing.Size(126, 16)
        Me.lbl_general_name.TabIndex = 192
        Me.lbl_general_name.Text = "General Library Name"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(176, 42)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 191
        Me.PictureBox3.TabStop = False
        '
        'rdo_general_3
        '
        Me.rdo_general_3.AutoSize = True
        Me.rdo_general_3.DataSource = ""
        Me.rdo_general_3.Location = New System.Drawing.Point(7, 40)
        Me.rdo_general_3.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo_general_3.Name = "rdo_general_3"
        Me.rdo_general_3.Size = New System.Drawing.Size(61, 17)
        Me.rdo_general_3.TabIndex = 14
        Me.rdo_general_3.Text = "Specific"
        Me.rdo_general_3.TextSource = ""
        Me.rdo_general_3.Uncheckable = False
        Me.rdo_general_3.UseVisualStyleBackColor = True
        Me.rdo_general_3.Value = "3"
        Me.rdo_general_3.ValueSource = ""
        '
        'rdo_general_1
        '
        Me.rdo_general_1.AutoSize = True
        Me.rdo_general_1.Checked = True
        Me.rdo_general_1.DataSource = ""
        Me.rdo_general_1.Location = New System.Drawing.Point(7, 18)
        Me.rdo_general_1.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo_general_1.Name = "rdo_general_1"
        Me.rdo_general_1.Size = New System.Drawing.Size(36, 17)
        Me.rdo_general_1.TabIndex = 11
        Me.rdo_general_1.TabStop = True
        Me.rdo_general_1.Text = "All"
        Me.rdo_general_1.TextSource = ""
        Me.rdo_general_1.Uncheckable = False
        Me.rdo_general_1.UseVisualStyleBackColor = True
        Me.rdo_general_1.Value = "1"
        Me.rdo_general_1.ValueSource = ""
        '
        'txt_general_id
        '
        Me.txt_general_id._Text = ""
        Me.txt_general_id.AllowNegative = False
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
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.ispk = False
        Me.txt_general_id.Location = New System.Drawing.Point(72, 40)
        Me.txt_general_id.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(100, 19)
        Me.txt_general_id.TabIndex = 15
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.TextSource = ""
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = ""
        '
        'currency_filter
        '
        Me.currency_filter.Controls.Add(Me.Label13)
        Me.currency_filter.Controls.Add(Me.withComparison)
        Me.currency_filter.Controls.Add(Me.lbl_currency_name)
        Me.currency_filter.Controls.Add(Me.rdo_currency_2)
        Me.currency_filter.Controls.Add(Me.txt_currency_id)
        Me.currency_filter.Controls.Add(Me.PictureBox2)
        Me.currency_filter.Controls.Add(Me.rdo_currency_1)
        Me.currency_filter.Location = New System.Drawing.Point(13, 288)
        Me.currency_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.currency_filter.Name = "currency_filter"
        Me.currency_filter.Padding = New System.Windows.Forms.Padding(4)
        Me.currency_filter.Size = New System.Drawing.Size(444, 70)
        Me.currency_filter.TabIndex = 209
        Me.currency_filter.TabStop = False
        Me.currency_filter.Text = "Currency"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 42)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 202
        Me.Label13.Text = "Currency"
        '
        'withComparison
        '
        Me.withComparison.AutoSize = True
        Me.withComparison.Location = New System.Drawing.Point(285, 16)
        Me.withComparison.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.withComparison.Name = "withComparison"
        Me.withComparison.Size = New System.Drawing.Size(107, 17)
        Me.withComparison.TabIndex = 18
        Me.withComparison.Text = "With Comparison"
        Me.withComparison.UseVisualStyleBackColor = True
        '
        'lbl_currency_name
        '
        Me.lbl_currency_name.AutoSize = True
        Me.lbl_currency_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_currency_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_currency_name.Location = New System.Drawing.Point(196, 42)
        Me.lbl_currency_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_currency_name.Name = "lbl_currency_name"
        Me.lbl_currency_name.Size = New System.Drawing.Size(93, 16)
        Me.lbl_currency_name.TabIndex = 188
        Me.lbl_currency_name.Text = "Currency Name"
        '
        'rdo_currency_2
        '
        Me.rdo_currency_2.AutoSize = True
        Me.rdo_currency_2.DataSource = ""
        Me.rdo_currency_2.Location = New System.Drawing.Point(171, 15)
        Me.rdo_currency_2.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo_currency_2.Name = "rdo_currency_2"
        Me.rdo_currency_2.Size = New System.Drawing.Size(108, 17)
        Me.rdo_currency_2.TabIndex = 17
        Me.rdo_currency_2.Text = "Original Currency"
        Me.rdo_currency_2.TextSource = ""
        Me.rdo_currency_2.Uncheckable = False
        Me.rdo_currency_2.UseVisualStyleBackColor = True
        Me.rdo_currency_2.Value = "2"
        Me.rdo_currency_2.ValueSource = ""
        '
        'txt_currency_id
        '
        Me.txt_currency_id._Text = ""
        Me.txt_currency_id.AllowNegative = False
        Me.txt_currency_id.AlwaysDisable = False
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.White
        Me.txt_currency_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.DataSource = ""
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.ispk = False
        Me.txt_currency_id.Location = New System.Drawing.Point(72, 40)
        Me.txt_currency_id.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_currency_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.MultiLine = False
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.SelectionLength = 0
        Me.txt_currency_id.SelectionStart = 0
        Me.txt_currency_id.Size = New System.Drawing.Size(100, 19)
        Me.txt_currency_id.TabIndex = 19
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.TextSource = ""
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 42)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 187
        Me.PictureBox2.TabStop = False
        '
        'rdo_currency_1
        '
        Me.rdo_currency_1.AutoSize = True
        Me.rdo_currency_1.Checked = True
        Me.rdo_currency_1.DataSource = ""
        Me.rdo_currency_1.Location = New System.Drawing.Point(52, 15)
        Me.rdo_currency_1.Margin = New System.Windows.Forms.Padding(4)
        Me.rdo_currency_1.Name = "rdo_currency_1"
        Me.rdo_currency_1.Size = New System.Drawing.Size(101, 17)
        Me.rdo_currency_1.TabIndex = 16
        Me.rdo_currency_1.TabStop = True
        Me.rdo_currency_1.Text = "Based Currency"
        Me.rdo_currency_1.TextSource = ""
        Me.rdo_currency_1.Uncheckable = False
        Me.rdo_currency_1.UseVisualStyleBackColor = True
        Me.rdo_currency_1.Value = "1"
        Me.rdo_currency_1.ValueSource = ""
        '
        'project_department_filter
        '
        Me.project_department_filter.Controls.Add(Me.lbl_department_name)
        Me.project_department_filter.Controls.Add(Me.PictureBox5)
        Me.project_department_filter.Controls.Add(Me.lbl_project_name)
        Me.project_department_filter.Controls.Add(Me.PictureBox4)
        Me.project_department_filter.Controls.Add(Me.Label7)
        Me.project_department_filter.Controls.Add(Me.Label12)
        Me.project_department_filter.Controls.Add(Me.withProjectDepartment)
        Me.project_department_filter.Controls.Add(Me.txt_department_id)
        Me.project_department_filter.Controls.Add(Me.txt_project_id)
        Me.project_department_filter.Location = New System.Drawing.Point(13, 366)
        Me.project_department_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.project_department_filter.Name = "project_department_filter"
        Me.project_department_filter.Padding = New System.Windows.Forms.Padding(4)
        Me.project_department_filter.Size = New System.Drawing.Size(442, 90)
        Me.project_department_filter.TabIndex = 210
        Me.project_department_filter.TabStop = False
        Me.project_department_filter.Text = "Project / Department"
        '
        'lbl_department_name
        '
        Me.lbl_department_name.AutoSize = True
        Me.lbl_department_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_department_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_department_name.Location = New System.Drawing.Point(196, 64)
        Me.lbl_department_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_department_name.Name = "lbl_department_name"
        Me.lbl_department_name.Size = New System.Drawing.Size(110, 16)
        Me.lbl_department_name.TabIndex = 194
        Me.lbl_department_name.Text = "Department Name"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(176, 64)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 193
        Me.PictureBox5.TabStop = False
        '
        'lbl_project_name
        '
        Me.lbl_project_name.AutoSize = True
        Me.lbl_project_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_project_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_project_name.Location = New System.Drawing.Point(196, 42)
        Me.lbl_project_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_project_name.Name = "lbl_project_name"
        Me.lbl_project_name.Size = New System.Drawing.Size(81, 16)
        Me.lbl_project_name.TabIndex = 192
        Me.lbl_project_name.Text = "Project Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(176, 42)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 191
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 42)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Project"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 64)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Department"
        '
        'withProjectDepartment
        '
        Me.withProjectDepartment.AutoSize = True
        Me.withProjectDepartment.Location = New System.Drawing.Point(72, 18)
        Me.withProjectDepartment.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.withProjectDepartment.Name = "withProjectDepartment"
        Me.withProjectDepartment.Size = New System.Drawing.Size(152, 17)
        Me.withProjectDepartment.TabIndex = 20
        Me.withProjectDepartment.Text = "With Project / Department"
        Me.withProjectDepartment.UseVisualStyleBackColor = True
        '
        'txt_department_id
        '
        Me.txt_department_id._Text = ""
        Me.txt_department_id.AllowNegative = False
        Me.txt_department_id.AlwaysDisable = False
        Me.txt_department_id.AlwaysEnable = False
        Me.txt_department_id.BackColor = System.Drawing.Color.White
        Me.txt_department_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department_id.DataSource = ""
        Me.txt_department_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.Enabled = False
        Me.txt_department_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department_id.ispk = False
        Me.txt_department_id.Location = New System.Drawing.Point(72, 62)
        Me.txt_department_id.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_department_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.MultiLine = False
        Me.txt_department_id.Name = "txt_department_id"
        Me.txt_department_id.NoClear = False
        Me.txt_department_id.NumberFormat = "@"
        Me.txt_department_id.Required = False
        Me.txt_department_id.RowData = Nothing
        Me.txt_department_id.SelectionLength = 0
        Me.txt_department_id.SelectionStart = 0
        Me.txt_department_id.Size = New System.Drawing.Size(100, 19)
        Me.txt_department_id.TabIndex = 22
        Me.txt_department_id.TableData = Nothing
        Me.txt_department_id.TextSource = ""
        Me.txt_department_id.UseSystemPasswordChar = False
        Me.txt_department_id.Value = ""
        Me.txt_department_id.ValueSource = ""
        '
        'txt_project_id
        '
        Me.txt_project_id._Text = ""
        Me.txt_project_id.AllowNegative = False
        Me.txt_project_id.AlwaysDisable = False
        Me.txt_project_id.AlwaysEnable = False
        Me.txt_project_id.BackColor = System.Drawing.Color.White
        Me.txt_project_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_id.DataSource = ""
        Me.txt_project_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.Enabled = False
        Me.txt_project_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_id.ispk = False
        Me.txt_project_id.Location = New System.Drawing.Point(72, 40)
        Me.txt_project_id.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_project_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.MultiLine = False
        Me.txt_project_id.Name = "txt_project_id"
        Me.txt_project_id.NoClear = False
        Me.txt_project_id.NumberFormat = "@"
        Me.txt_project_id.Required = False
        Me.txt_project_id.RowData = Nothing
        Me.txt_project_id.SelectionLength = 0
        Me.txt_project_id.SelectionStart = 0
        Me.txt_project_id.Size = New System.Drawing.Size(100, 19)
        Me.txt_project_id.TabIndex = 21
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.TextSource = ""
        Me.txt_project_id.UseSystemPasswordChar = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = ""
        '
        'filter1
        '
        Me.filter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filter1.Controls.Add(Me.rdo_filter_2)
        Me.filter1.Controls.Add(Me.rdo_filter_3)
        Me.filter1.Controls.Add(Me.rdo_filter_4)
        Me.filter1.Controls.Add(Me.rdo_filter_1)
        Me.filter1.Location = New System.Drawing.Point(467, 366)
        Me.filter1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.filter1.Name = "filter1"
        Me.filter1.Size = New System.Drawing.Size(670, 64)
        Me.filter1.TabIndex = 212
        '
        'rdo_filter_2
        '
        Me.rdo_filter_2.AutoSize = True
        Me.rdo_filter_2.DataSource = ""
        Me.rdo_filter_2.Location = New System.Drawing.Point(337, 10)
        Me.rdo_filter_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_filter_2.Name = "rdo_filter_2"
        Me.rdo_filter_2.Size = New System.Drawing.Size(115, 17)
        Me.rdo_filter_2.TabIndex = 29
        Me.rdo_filter_2.Text = "With Monthly Total"
        Me.rdo_filter_2.TextSource = ""
        Me.rdo_filter_2.Uncheckable = False
        Me.rdo_filter_2.UseVisualStyleBackColor = True
        Me.rdo_filter_2.Value = "2"
        Me.rdo_filter_2.ValueSource = ""
        '
        'rdo_filter_3
        '
        Me.rdo_filter_3.AutoSize = True
        Me.rdo_filter_3.DataSource = ""
        Me.rdo_filter_3.Location = New System.Drawing.Point(128, 35)
        Me.rdo_filter_3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_filter_3.Name = "rdo_filter_3"
        Me.rdo_filter_3.Size = New System.Drawing.Size(131, 17)
        Me.rdo_filter_3.TabIndex = 30
        Me.rdo_filter_3.Text = "With Per Journal Total"
        Me.rdo_filter_3.TextSource = ""
        Me.rdo_filter_3.Uncheckable = False
        Me.rdo_filter_3.UseVisualStyleBackColor = True
        Me.rdo_filter_3.Value = "3"
        Me.rdo_filter_3.ValueSource = ""
        '
        'rdo_filter_4
        '
        Me.rdo_filter_4.AutoSize = True
        Me.rdo_filter_4.DataSource = ""
        Me.rdo_filter_4.Location = New System.Drawing.Point(337, 35)
        Me.rdo_filter_4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_filter_4.Name = "rdo_filter_4"
        Me.rdo_filter_4.Size = New System.Drawing.Size(224, 17)
        Me.rdo_filter_4.TabIndex = 31
        Me.rdo_filter_4.Text = "Combination of Monthly and Journal Total"
        Me.rdo_filter_4.TextSource = ""
        Me.rdo_filter_4.Uncheckable = False
        Me.rdo_filter_4.UseVisualStyleBackColor = True
        Me.rdo_filter_4.Value = "4"
        Me.rdo_filter_4.ValueSource = ""
        '
        'rdo_filter_1
        '
        Me.rdo_filter_1.AutoSize = True
        Me.rdo_filter_1.Checked = True
        Me.rdo_filter_1.DataSource = ""
        Me.rdo_filter_1.Location = New System.Drawing.Point(128, 10)
        Me.rdo_filter_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_filter_1.Name = "rdo_filter_1"
        Me.rdo_filter_1.Size = New System.Drawing.Size(205, 17)
        Me.rdo_filter_1.TabIndex = 28
        Me.rdo_filter_1.TabStop = True
        Me.rdo_filter_1.Text = "Simple Analysis without any Sub Total"
        Me.rdo_filter_1.TextSource = ""
        Me.rdo_filter_1.Uncheckable = False
        Me.rdo_filter_1.UseVisualStyleBackColor = True
        Me.rdo_filter_1.Value = "1"
        Me.rdo_filter_1.ValueSource = ""
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(454, 466)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 215
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        Me.btnExcel.Visible = False
        '
        'btnPrintOption
        '
        Me.btnPrintOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrintOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrintOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintOption.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(533, 466)
        Me.btnPrintOption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 216
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(1150, 28)
        Me.Myformheader1.TabIndex = 214
        '
        'txt_sortby
        '
        Me.txt_sortby._Text = ""
        Me.txt_sortby.AllowNegative = False
        Me.txt_sortby.AlwaysDisable = False
        Me.txt_sortby.AlwaysEnable = False
        Me.txt_sortby.BackColor = System.Drawing.Color.White
        Me.txt_sortby.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_sortby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sortby.DataSource = ""
        Me.txt_sortby.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sortby.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sortby.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_sortby.EnabledBackColor = System.Drawing.Color.White
        Me.txt_sortby.ispk = False
        Me.txt_sortby.Location = New System.Drawing.Point(521, 435)
        Me.txt_sortby.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_sortby.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sortby.MultiLine = False
        Me.txt_sortby.Name = "txt_sortby"
        Me.txt_sortby.NoClear = False
        Me.txt_sortby.NumberFormat = "@"
        Me.txt_sortby.Required = False
        Me.txt_sortby.RowData = Nothing
        Me.txt_sortby.SelectionLength = 0
        Me.txt_sortby.SelectionStart = 0
        Me.txt_sortby.Size = New System.Drawing.Size(616, 19)
        Me.txt_sortby.TabIndex = 32
        Me.txt_sortby.TableData = Nothing
        Me.txt_sortby.TextSource = ""
        Me.txt_sortby.UseSystemPasswordChar = False
        Me.txt_sortby.Value = ""
        Me.txt_sortby.ValueSource = ""
        '
        'checkAllBooks
        '
        Me.checkAllBooks.AutoSize = True
        Me.checkAllBooks.Location = New System.Drawing.Point(704, 72)
        Me.checkAllBooks.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllBooks.Name = "checkAllBooks"
        Me.checkAllBooks.Size = New System.Drawing.Size(15, 14)
        Me.checkAllBooks.TabIndex = 219
        Me.checkAllBooks.UseVisualStyleBackColor = True
        '
        'dgBookUnit
        '
        Me.dgBookUnit.AllowUserToAddRows = False
        Me.dgBookUnit.AllowUserToDeleteRows = False
        Me.dgBookUnit.AllowUserToResizeColumns = False
        Me.dgBookUnit.AllowUserToResizeRows = False
        Me.dgBookUnit.BackgroundColor = System.Drawing.Color.White
        Me.dgBookUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBookUnit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel2, Me.book_unit_no_name, Me.book_unit_no_id})
        Me.dgBookUnit.EnableHeadersVisualStyles = False
        Me.dgBookUnit.Location = New System.Drawing.Point(916, 94)
        Me.dgBookUnit.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgBookUnit.MultiSelect = False
        Me.dgBookUnit.Name = "dgBookUnit"
        Me.dgBookUnit.RowHeadersVisible = False
        Me.dgBookUnit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBookUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBookUnit.Size = New System.Drawing.Size(220, 192)
        Me.dgBookUnit.TabIndex = 220
        '
        'sel2
        '
        Me.sel2.DataPropertyName = "sel2"
        Me.sel2.FalseValue = "False"
        Me.sel2.HeaderText = ""
        Me.sel2.Name = "sel2"
        Me.sel2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel2.TrueValue = "True"
        Me.sel2.Width = 32
        '
        'book_unit_no_name
        '
        Me.book_unit_no_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_unit_no_name.DataPropertyName = "book_unit_no_name"
        Me.book_unit_no_name.HeaderText = "Unit No"
        Me.book_unit_no_name.Name = "book_unit_no_name"
        Me.book_unit_no_name.ReadOnly = True
        Me.book_unit_no_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_unit_no_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'book_unit_no_id
        '
        Me.book_unit_no_id.DataPropertyName = "book_unit_no_id"
        Me.book_unit_no_id.HeaderText = "Book Unit ID"
        Me.book_unit_no_id.Name = "book_unit_no_id"
        Me.book_unit_no_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_unit_no_id.Visible = False
        '
        'checkAllBookUnit
        '
        Me.checkAllBookUnit.AutoSize = True
        Me.checkAllBookUnit.Location = New System.Drawing.Point(928, 100)
        Me.checkAllBookUnit.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllBookUnit.Name = "checkAllBookUnit"
        Me.checkAllBookUnit.Size = New System.Drawing.Size(15, 14)
        Me.checkAllBookUnit.TabIndex = 221
        Me.checkAllBookUnit.UseVisualStyleBackColor = True
        '
        'txtSearchUnit
        '
        Me.txtSearchUnit.Location = New System.Drawing.Point(963, 67)
        Me.txtSearchUnit.Name = "txtSearchUnit"
        Me.txtSearchUnit.Size = New System.Drawing.Size(175, 20)
        Me.txtSearchUnit.TabIndex = 222
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(917, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 223
        Me.Label5.Text = "Search"
        '
        'w_running_balance
        '
        Me.w_running_balance.AutoSize = True
        Me.w_running_balance.Location = New System.Drawing.Point(1016, 40)
        Me.w_running_balance.Name = "w_running_balance"
        Me.w_running_balance.Size = New System.Drawing.Size(122, 17)
        Me.w_running_balance.TabIndex = 224
        Me.w_running_balance.Text = "W/ Running Balance"
        Me.w_running_balance.UseVisualStyleBackColor = True
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(430, 200)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 225
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'Borderedlabel2
        '
        Me.Borderedlabel2.BorderColor = System.Drawing.Color.DarkGray
        Me.Borderedlabel2.Location = New System.Drawing.Point(11, 460)
        Me.Borderedlabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Borderedlabel2.Name = "Borderedlabel2"
        Me.Borderedlabel2.Size = New System.Drawing.Size(1126, 2)
        Me.Borderedlabel2.TabIndex = 213
        Me.Borderedlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Borderedlabel1
        '
        Me.Borderedlabel1.BorderColor = System.Drawing.Color.DarkGray
        Me.Borderedlabel1.Location = New System.Drawing.Point(461, 62)
        Me.Borderedlabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Borderedlabel1.Name = "Borderedlabel1"
        Me.Borderedlabel1.Size = New System.Drawing.Size(2, 400)
        Me.Borderedlabel1.TabIndex = 211
        Me.Borderedlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(11, 60)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(1126, 2)
        Me.border1.TabIndex = 17
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'w_currency
        '
        Me.w_currency.AutoSize = True
        Me.w_currency.Location = New System.Drawing.Point(923, 40)
        Me.w_currency.Name = "w_currency"
        Me.w_currency.Size = New System.Drawing.Size(87, 17)
        Me.w_currency.TabIndex = 226
        Me.w_currency.Text = "W/ Currency"
        Me.w_currency.UseVisualStyleBackColor = True
        '
        'accountanlysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 500)
        Me.Controls.Add(Me.w_currency)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.w_running_balance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSearchUnit)
        Me.Controls.Add(Me.checkAllBookUnit)
        Me.Controls.Add(Me.dgBookUnit)
        Me.Controls.Add(Me.checkAllBooks)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Borderedlabel2)
        Me.Controls.Add(Me.filter1)
        Me.Controls.Add(Me.Borderedlabel1)
        Me.Controls.Add(Me.project_department_filter)
        Me.Controls.Add(Me.general_filter)
        Me.Controls.Add(Me.checkAllJournal)
        Me.Controls.Add(Me.dgJournal)
        Me.Controls.Add(Me.account_filter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_sortby)
        Me.Controls.Add(Me.dgBooks)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.range_filter)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.allocation_filter)
        Me.Controls.Add(Me.currency_filter)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "accountanlysis"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Analysis"
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.allocation_filter.ResumeLayout(False)
        Me.allocation_filter.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.account_filter.ResumeLayout(False)
        Me.account_filter.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgJournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.general_filter.ResumeLayout(False)
        Me.general_filter.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.currency_filter.ResumeLayout(False)
        Me.currency_filter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_department_filter.ResumeLayout(False)
        Me.project_department_filter.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filter1.ResumeLayout(False)
        Me.filter1.PerformLayout()
        CType(Me.dgBookUnit, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgBooks As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txt_account_id As user_control.textbox
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents txt_sortby As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents allocation_filter As System.Windows.Forms.Panel
    Friend WithEvents lbl_allocation_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_allocation_id As user_control.textbox
    Friend WithEvents rdo_allocation_2 As user_control.rdo_button
    Friend WithEvents rdo_allocation_1 As user_control.rdo_button
    Friend WithEvents account_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_account_2 As user_control.rdo_button
    Friend WithEvents btnImportAccount As System.Windows.Forms.Button
    Friend WithEvents lbl_account_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rdo_account_3 As user_control.rdo_button
    Friend WithEvents rdo_account_1 As user_control.rdo_button
    Friend WithEvents checkAllJournal As System.Windows.Forms.CheckBox
    Friend WithEvents dgJournal As System.Windows.Forms.DataGridView
    Friend WithEvents general_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_general_2 As user_control.rdo_button
    Friend WithEvents btnImportGeneral As System.Windows.Forms.Button
    Friend WithEvents lbl_general_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents rdo_general_3 As user_control.rdo_button
    Friend WithEvents rdo_general_1 As user_control.rdo_button
    Friend WithEvents rdo_currency_2 As user_control.rdo_button
    Friend WithEvents rdo_currency_1 As user_control.rdo_button
    Friend WithEvents currency_filter As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents withComparison As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_currency_name As System.Windows.Forms.Label
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents project_department_filter As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_department_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_project_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents withProjectDepartment As System.Windows.Forms.CheckBox
    Friend WithEvents txt_department_id As user_control.textbox
    Friend WithEvents txt_project_id As user_control.textbox
    Friend WithEvents Borderedlabel1 As accounting.borderedlabel
    Friend WithEvents filter1 As System.Windows.Forms.Panel
    Friend WithEvents rdo_filter_2 As user_control.rdo_button
    Friend WithEvents rdo_filter_3 As user_control.rdo_button
    Friend WithEvents rdo_filter_4 As user_control.rdo_button
    Friend WithEvents rdo_filter_1 As user_control.rdo_button
    Friend WithEvents Borderedlabel2 As accounting.borderedlabel
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents checkAllBooks As Windows.Forms.CheckBox
    Friend WithEvents dgBookUnit As Windows.Forms.DataGridView
    Friend WithEvents checkAllBookUnit As Windows.Forms.CheckBox
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel1 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents journal_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel2 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_unit_no_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_unit_no_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearchUnit As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents w_running_balance As Windows.Forms.CheckBox
    Friend WithEvents lblLoad As Windows.Forms.Label
    Friend WithEvents w_currency As Windows.Forms.CheckBox
End Class
