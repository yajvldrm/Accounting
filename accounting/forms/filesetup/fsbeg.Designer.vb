<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fsbeg
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fsbeg))
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.jbooks_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_unit_no_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_based_rate = New user_control.textbox()
        Me.txt_exchange_rate = New user_control.textbox()
        Me.txt_currency = New user_control.textbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_jbooks_id = New user_control.textbox()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.txt_account_name = New user_control.textbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_credit_based = New user_control.textbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_debit_based = New user_control.textbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_credit = New user_control.textbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_debit = New user_control.textbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_account_id = New user_control.textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_department_id = New user_control.textbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_project_id = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.panel_hdr = New System.Windows.Forms.Panel()
        Me.txt_trans_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_book_id = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_currency_id = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txt_trans_id = New user_control.textbox()
        Me.primary_key = New user_control.textbox()
        Me.lbl_debit = New System.Windows.Forms.Label()
        Me.lbl_credit = New System.Windows.Forms.Label()
        Me.lbl_difference = New System.Windows.Forms.Label()
        Me.lbl_difference_based = New System.Windows.Forms.Label()
        Me.lbl_credit_based = New System.Windows.Forms.Label()
        Me.lbl_debit_based = New System.Windows.Forms.Label()
        Me.txtsearch = New user_control.textbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Begbal = New accounting.begbal()
        Me.TransjbooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.border1 = New accounting.borderedlabel()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_hdr.SuspendLayout()
        CType(Me.Begbal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransjbooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeight = 28
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.jbooks_id, Me.account_code, Me.account_name, Me.debit, Me.credit, Me.debit_based, Me.credit_based, Me.project_name, Me.department_name, Me.book_unit_no_name})
        Me.dgMain.Location = New System.Drawing.Point(12, 96)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(737, 111)
        Me.dgMain.TabIndex = 89
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
        'jbooks_id
        '
        Me.jbooks_id.DataPropertyName = "jbooks_id"
        Me.jbooks_id.HeaderText = "ID"
        Me.jbooks_id.Name = "jbooks_id"
        Me.jbooks_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.jbooks_id.Visible = False
        '
        'account_code
        '
        Me.account_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.account_code.DataPropertyName = "account_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.account_code.HeaderText = "Account Code"
        Me.account_code.Name = "account_code"
        Me.account_code.ReadOnly = True
        Me.account_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'account_name
        '
        Me.account_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.account_name.DataPropertyName = "account_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.account_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.account_name.HeaderText = "Account Name"
        Me.account_name.Name = "account_name"
        Me.account_name.ReadOnly = True
        Me.account_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'debit
        '
        Me.debit.DataPropertyName = "debit"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "##,##0.00"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle3
        Me.debit.HeaderText = "Debit"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        Me.debit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.debit.Width = 80
        '
        'credit
        '
        Me.credit.DataPropertyName = "credit"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "##,##0.00"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.credit.DefaultCellStyle = DataGridViewCellStyle4
        Me.credit.HeaderText = "Credit"
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        Me.credit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.credit.Width = 80
        '
        'debit_based
        '
        Me.debit_based.DataPropertyName = "debit_based"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "##,##0.00"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.debit_based.DefaultCellStyle = DataGridViewCellStyle5
        Me.debit_based.HeaderText = "Debit Based"
        Me.debit_based.Name = "debit_based"
        Me.debit_based.ReadOnly = True
        Me.debit_based.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.debit_based.Width = 80
        '
        'credit_based
        '
        Me.credit_based.DataPropertyName = "credit_based"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "##,##0.00"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.credit_based.DefaultCellStyle = DataGridViewCellStyle6
        Me.credit_based.HeaderText = "Credit Based"
        Me.credit_based.Name = "credit_based"
        Me.credit_based.ReadOnly = True
        Me.credit_based.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.credit_based.Width = 80
        '
        'project_name
        '
        Me.project_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.project_name.DataPropertyName = "project_name"
        Me.project_name.HeaderText = "Project"
        Me.project_name.Name = "project_name"
        Me.project_name.ReadOnly = True
        '
        'department_name
        '
        Me.department_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.department_name.DataPropertyName = "department_name"
        Me.department_name.HeaderText = "Department"
        Me.department_name.Name = "department_name"
        Me.department_name.ReadOnly = True
        '
        'book_unit_no_name
        '
        Me.book_unit_no_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_unit_no_name.DataPropertyName = "book_unit_no_name"
        Me.book_unit_no_name.HeaderText = "Book Unit"
        Me.book_unit_no_name.Name = "book_unit_no_name"
        Me.book_unit_no_name.ReadOnly = True
        Me.book_unit_no_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 25)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "GL Beginning Balance"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(176, 240)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(90, 240)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(4, 240)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.Controls.Add(Me.txt_based_rate)
        Me.Panel1.Controls.Add(Me.txt_exchange_rate)
        Me.Panel1.Controls.Add(Me.txt_currency)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt_jbooks_id)
        Me.Panel1.Controls.Add(Me.btnViewDetails)
        Me.Panel1.Controls.Add(Me.txt_account_name)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txt_credit_based)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_debit_based)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txt_credit)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txt_debit)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_account_id)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_department_id)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_project_id)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(5, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 160)
        Me.Panel1.TabIndex = 100
        Me.Panel1.Tag = "container"
        '
        'txt_based_rate
        '
        Me.txt_based_rate._Text = ""
        Me.txt_based_rate.AllowNegative = False
        Me.txt_based_rate.AlwaysDisable = True
        Me.txt_based_rate.AlwaysEnable = False
        Me.txt_based_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_based_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_based_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_based_rate.DataSource = ""
        Me.txt_based_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_based_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_based_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_based_rate.Enabled = False
        Me.txt_based_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_based_rate.ispk = False
        Me.txt_based_rate.Location = New System.Drawing.Point(513, 130)
        Me.txt_based_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_based_rate.MultiLine = False
        Me.txt_based_rate.Name = "txt_based_rate"
        Me.txt_based_rate.NoClear = True
        Me.txt_based_rate.NumberFormat = "##,##0.00"
        Me.txt_based_rate.Required = False
        Me.txt_based_rate.RowData = Nothing
        Me.txt_based_rate.SelectionLength = 0
        Me.txt_based_rate.SelectionStart = 0
        Me.txt_based_rate.Size = New System.Drawing.Size(220, 20)
        Me.txt_based_rate.TabIndex = 13
        Me.txt_based_rate.TableData = Nothing
        Me.txt_based_rate.Tag = ""
        Me.txt_based_rate.TextSource = "based_rate"
        Me.txt_based_rate.UseSystemPasswordChar = False
        Me.txt_based_rate.Value = "0.00"
        Me.txt_based_rate.ValueSource = "based_rate"
        Me.txt_based_rate.Visible = False
        '
        'txt_exchange_rate
        '
        Me.txt_exchange_rate._Text = ""
        Me.txt_exchange_rate.AllowNegative = False
        Me.txt_exchange_rate.AlwaysDisable = True
        Me.txt_exchange_rate.AlwaysEnable = False
        Me.txt_exchange_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_exchange_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_exchange_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_exchange_rate.DataSource = ""
        Me.txt_exchange_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_exchange_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_exchange_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_exchange_rate.Enabled = False
        Me.txt_exchange_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_exchange_rate.ispk = False
        Me.txt_exchange_rate.Location = New System.Drawing.Point(325, 130)
        Me.txt_exchange_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_exchange_rate.MultiLine = False
        Me.txt_exchange_rate.Name = "txt_exchange_rate"
        Me.txt_exchange_rate.NoClear = True
        Me.txt_exchange_rate.NumberFormat = "##,##0.00"
        Me.txt_exchange_rate.Required = False
        Me.txt_exchange_rate.RowData = Nothing
        Me.txt_exchange_rate.SelectionLength = 0
        Me.txt_exchange_rate.SelectionStart = 0
        Me.txt_exchange_rate.Size = New System.Drawing.Size(117, 20)
        Me.txt_exchange_rate.TabIndex = 12
        Me.txt_exchange_rate.TableData = Nothing
        Me.txt_exchange_rate.Tag = "focus"
        Me.txt_exchange_rate.TextSource = "exchange_rate"
        Me.txt_exchange_rate.UseSystemPasswordChar = False
        Me.txt_exchange_rate.Value = "0.00"
        Me.txt_exchange_rate.ValueSource = "exchange_rate"
        Me.txt_exchange_rate.Visible = False
        '
        'txt_currency
        '
        Me.txt_currency._Text = ""
        Me.txt_currency.AllowNegative = False
        Me.txt_currency.AlwaysDisable = True
        Me.txt_currency.AlwaysEnable = False
        Me.txt_currency.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency.DataSource = ""
        Me.txt_currency.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency.Enabled = False
        Me.txt_currency.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency.ispk = False
        Me.txt_currency.Location = New System.Drawing.Point(88, 130)
        Me.txt_currency.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency.MultiLine = False
        Me.txt_currency.Name = "txt_currency"
        Me.txt_currency.NoClear = True
        Me.txt_currency.NumberFormat = "@"
        Me.txt_currency.Required = False
        Me.txt_currency.RowData = Nothing
        Me.txt_currency.SelectionLength = 0
        Me.txt_currency.SelectionStart = 0
        Me.txt_currency.Size = New System.Drawing.Size(146, 20)
        Me.txt_currency.TabIndex = 11
        Me.txt_currency.TableData = Nothing
        Me.txt_currency.Tag = ""
        Me.txt_currency.TextSource = "currency_name"
        Me.txt_currency.UseSystemPasswordChar = False
        Me.txt_currency.Value = ""
        Me.txt_currency.ValueSource = "currency_id"
        Me.txt_currency.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(448, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 188
        Me.Label13.Text = "Based Rate"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(242, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 187
        Me.Label14.Text = "Exchange Rate"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 186
        Me.Label15.Text = "Currency"
        Me.Label15.Visible = False
        '
        'txt_jbooks_id
        '
        Me.txt_jbooks_id._Text = ""
        Me.txt_jbooks_id.AllowNegative = False
        Me.txt_jbooks_id.AlwaysDisable = True
        Me.txt_jbooks_id.AlwaysEnable = False
        Me.txt_jbooks_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_jbooks_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_jbooks_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jbooks_id.DataSource = ""
        Me.txt_jbooks_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_jbooks_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_jbooks_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_jbooks_id.Enabled = False
        Me.txt_jbooks_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_jbooks_id.ispk = False
        Me.txt_jbooks_id.Location = New System.Drawing.Point(299, 6)
        Me.txt_jbooks_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_jbooks_id.MultiLine = False
        Me.txt_jbooks_id.Name = "txt_jbooks_id"
        Me.txt_jbooks_id.NoClear = False
        Me.txt_jbooks_id.NumberFormat = "@"
        Me.txt_jbooks_id.Required = False
        Me.txt_jbooks_id.RowData = Nothing
        Me.txt_jbooks_id.SelectionLength = 0
        Me.txt_jbooks_id.SelectionStart = 0
        Me.txt_jbooks_id.Size = New System.Drawing.Size(105, 20)
        Me.txt_jbooks_id.TabIndex = 1
        Me.txt_jbooks_id.TableData = Nothing
        Me.txt_jbooks_id.TextSource = ""
        Me.txt_jbooks_id.UseSystemPasswordChar = False
        Me.txt_jbooks_id.Value = ""
        Me.txt_jbooks_id.ValueSource = ""
        Me.txt_jbooks_id.Visible = False
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnViewDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Location = New System.Drawing.Point(633, 6)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(100, 23)
        Me.btnViewDetails.TabIndex = 2
        Me.btnViewDetails.Tag = "btnViewDetails"
        Me.btnViewDetails.Text = "View Schedule"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'txt_account_name
        '
        Me.txt_account_name._Text = ""
        Me.txt_account_name.AllowNegative = False
        Me.txt_account_name.AlwaysDisable = True
        Me.txt_account_name.AlwaysEnable = False
        Me.txt_account_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_name.DataSource = ""
        Me.txt_account_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_name.Enabled = False
        Me.txt_account_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_name.ispk = False
        Me.txt_account_name.Location = New System.Drawing.Point(345, 58)
        Me.txt_account_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.MultiLine = False
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = False
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.SelectionLength = 0
        Me.txt_account_name.SelectionStart = 0
        Me.txt_account_name.Size = New System.Drawing.Size(388, 20)
        Me.txt_account_name.TabIndex = 6
        Me.txt_account_name.TableData = Nothing
        Me.txt_account_name.Tag = ""
        Me.txt_account_name.TextSource = ""
        Me.txt_account_name.UseSystemPasswordChar = False
        Me.txt_account_name.Value = ""
        Me.txt_account_name.ValueSource = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(325, 60)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 175
        Me.PictureBox2.TabStop = False
        '
        'txt_credit_based
        '
        Me.txt_credit_based._Text = ""
        Me.txt_credit_based.AllowNegative = False
        Me.txt_credit_based.AlwaysDisable = True
        Me.txt_credit_based.AlwaysEnable = False
        Me.txt_credit_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_credit_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_credit_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_credit_based.DataSource = ""
        Me.txt_credit_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_credit_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_credit_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_credit_based.Enabled = False
        Me.txt_credit_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_credit_based.ispk = False
        Me.txt_credit_based.Location = New System.Drawing.Point(398, 105)
        Me.txt_credit_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_credit_based.MultiLine = False
        Me.txt_credit_based.Name = "txt_credit_based"
        Me.txt_credit_based.NoClear = False
        Me.txt_credit_based.NumberFormat = "##,##0.00"
        Me.txt_credit_based.Required = False
        Me.txt_credit_based.RowData = Nothing
        Me.txt_credit_based.SelectionLength = 0
        Me.txt_credit_based.SelectionStart = 0
        Me.txt_credit_based.Size = New System.Drawing.Size(335, 20)
        Me.txt_credit_based.TabIndex = 10
        Me.txt_credit_based.TableData = Nothing
        Me.txt_credit_based.Tag = ""
        Me.txt_credit_based.TextSource = ""
        Me.txt_credit_based.UseSystemPasswordChar = False
        Me.txt_credit_based.Value = "0.00"
        Me.txt_credit_based.ValueSource = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(327, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Credit Based"
        '
        'txt_debit_based
        '
        Me.txt_debit_based._Text = ""
        Me.txt_debit_based.AllowNegative = False
        Me.txt_debit_based.AlwaysDisable = True
        Me.txt_debit_based.AlwaysEnable = False
        Me.txt_debit_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_debit_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_debit_based.DataSource = ""
        Me.txt_debit_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_debit_based.Enabled = False
        Me.txt_debit_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_debit_based.ispk = False
        Me.txt_debit_based.Location = New System.Drawing.Point(398, 82)
        Me.txt_debit_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit_based.MultiLine = False
        Me.txt_debit_based.Name = "txt_debit_based"
        Me.txt_debit_based.NoClear = False
        Me.txt_debit_based.NumberFormat = "##,##0.00"
        Me.txt_debit_based.Required = False
        Me.txt_debit_based.RowData = Nothing
        Me.txt_debit_based.SelectionLength = 0
        Me.txt_debit_based.SelectionStart = 0
        Me.txt_debit_based.Size = New System.Drawing.Size(335, 20)
        Me.txt_debit_based.TabIndex = 8
        Me.txt_debit_based.TableData = Nothing
        Me.txt_debit_based.Tag = ""
        Me.txt_debit_based.TextSource = ""
        Me.txt_debit_based.UseSystemPasswordChar = False
        Me.txt_debit_based.Value = "0.00"
        Me.txt_debit_based.ValueSource = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(331, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Debit Based"
        '
        'txt_credit
        '
        Me.txt_credit._Text = ""
        Me.txt_credit.AllowNegative = False
        Me.txt_credit.AlwaysDisable = True
        Me.txt_credit.AlwaysEnable = False
        Me.txt_credit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_credit.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_credit.DataSource = ""
        Me.txt_credit.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_credit.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_credit.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_credit.Enabled = False
        Me.txt_credit.EnabledBackColor = System.Drawing.Color.White
        Me.txt_credit.ispk = False
        Me.txt_credit.Location = New System.Drawing.Point(88, 106)
        Me.txt_credit.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_credit.MultiLine = False
        Me.txt_credit.Name = "txt_credit"
        Me.txt_credit.NoClear = False
        Me.txt_credit.NumberFormat = "##,##0.00"
        Me.txt_credit.Required = False
        Me.txt_credit.RowData = Nothing
        Me.txt_credit.SelectionLength = 0
        Me.txt_credit.SelectionStart = 0
        Me.txt_credit.Size = New System.Drawing.Size(235, 20)
        Me.txt_credit.TabIndex = 9
        Me.txt_credit.TableData = Nothing
        Me.txt_credit.Tag = ""
        Me.txt_credit.TextSource = ""
        Me.txt_credit.UseSystemPasswordChar = False
        Me.txt_credit.Value = "0.00"
        Me.txt_credit.ValueSource = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Credit"
        '
        'txt_debit
        '
        Me.txt_debit._Text = ""
        Me.txt_debit.AllowNegative = False
        Me.txt_debit.AlwaysDisable = True
        Me.txt_debit.AlwaysEnable = False
        Me.txt_debit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_debit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_debit.DataSource = ""
        Me.txt_debit.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_debit.Enabled = False
        Me.txt_debit.EnabledBackColor = System.Drawing.Color.White
        Me.txt_debit.ispk = False
        Me.txt_debit.Location = New System.Drawing.Point(88, 82)
        Me.txt_debit.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit.MultiLine = False
        Me.txt_debit.Name = "txt_debit"
        Me.txt_debit.NoClear = False
        Me.txt_debit.NumberFormat = "##,##0.00"
        Me.txt_debit.Required = False
        Me.txt_debit.RowData = Nothing
        Me.txt_debit.SelectionLength = 0
        Me.txt_debit.SelectionStart = 0
        Me.txt_debit.Size = New System.Drawing.Size(235, 20)
        Me.txt_debit.TabIndex = 7
        Me.txt_debit.TableData = Nothing
        Me.txt_debit.Tag = ""
        Me.txt_debit.TextSource = ""
        Me.txt_debit.UseSystemPasswordChar = False
        Me.txt_debit.Value = "0.00"
        Me.txt_debit.ValueSource = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Debit"
        '
        'txt_account_id
        '
        Me.txt_account_id._Text = ""
        Me.txt_account_id.AllowNegative = False
        Me.txt_account_id.AlwaysDisable = True
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
        Me.txt_account_id.Location = New System.Drawing.Point(88, 58)
        Me.txt_account_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.MultiLine = False
        Me.txt_account_id.Name = "txt_account_id"
        Me.txt_account_id.NoClear = False
        Me.txt_account_id.NumberFormat = "@"
        Me.txt_account_id.Required = False
        Me.txt_account_id.RowData = Nothing
        Me.txt_account_id.SelectionLength = 0
        Me.txt_account_id.SelectionStart = 0
        Me.txt_account_id.Size = New System.Drawing.Size(235, 20)
        Me.txt_account_id.TabIndex = 5
        Me.txt_account_id.TableData = Nothing
        Me.txt_account_id.Tag = ""
        Me.txt_account_id.TextSource = "account_code"
        Me.txt_account_id.UseSystemPasswordChar = False
        Me.txt_account_id.Value = ""
        Me.txt_account_id.ValueSource = "account_id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Account Code"
        '
        'txt_department_id
        '
        Me.txt_department_id._Text = ""
        Me.txt_department_id.AllowNegative = False
        Me.txt_department_id.AlwaysDisable = True
        Me.txt_department_id.AlwaysEnable = False
        Me.txt_department_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department_id.DataSource = ""
        Me.txt_department_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.Enabled = False
        Me.txt_department_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department_id.ispk = False
        Me.txt_department_id.Location = New System.Drawing.Point(325, 34)
        Me.txt_department_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.MultiLine = False
        Me.txt_department_id.Name = "txt_department_id"
        Me.txt_department_id.NoClear = False
        Me.txt_department_id.NumberFormat = "@"
        Me.txt_department_id.Required = False
        Me.txt_department_id.RowData = Nothing
        Me.txt_department_id.SelectionLength = 0
        Me.txt_department_id.SelectionStart = 0
        Me.txt_department_id.Size = New System.Drawing.Size(136, 20)
        Me.txt_department_id.TabIndex = 4
        Me.txt_department_id.TableData = Nothing
        Me.txt_department_id.Tag = ""
        Me.txt_department_id.TextSource = "department_name"
        Me.txt_department_id.UseSystemPasswordChar = False
        Me.txt_department_id.Value = ""
        Me.txt_department_id.ValueSource = "department_id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Department"
        '
        'txt_project_id
        '
        Me.txt_project_id._Text = ""
        Me.txt_project_id.AllowNegative = False
        Me.txt_project_id.AlwaysDisable = True
        Me.txt_project_id.AlwaysEnable = False
        Me.txt_project_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_id.DataSource = ""
        Me.txt_project_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.Enabled = False
        Me.txt_project_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_id.ispk = False
        Me.txt_project_id.Location = New System.Drawing.Point(88, 34)
        Me.txt_project_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.MultiLine = False
        Me.txt_project_id.Name = "txt_project_id"
        Me.txt_project_id.NoClear = False
        Me.txt_project_id.NumberFormat = "@"
        Me.txt_project_id.Required = False
        Me.txt_project_id.RowData = Nothing
        Me.txt_project_id.SelectionLength = 0
        Me.txt_project_id.SelectionStart = 0
        Me.txt_project_id.Size = New System.Drawing.Size(146, 20)
        Me.txt_project_id.TabIndex = 3
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.Tag = "focus"
        Me.txt_project_id.TextSource = "project_name"
        Me.txt_project_id.UseSystemPasswordChar = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = "project_id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Project"
        '
        'btnNotSave
        '
        Me.btnNotSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(90, 240)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 20
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(4, 240)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'panel_hdr
        '
        Me.panel_hdr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel_hdr.Controls.Add(Me.txt_trans_date)
        Me.panel_hdr.Controls.Add(Me.txt_book_id)
        Me.panel_hdr.Controls.Add(Me.Label3)
        Me.panel_hdr.Controls.Add(Me.txt_currency_id)
        Me.panel_hdr.Controls.Add(Me.Label2)
        Me.panel_hdr.Controls.Add(Me.Label4)
        Me.panel_hdr.Location = New System.Drawing.Point(66, 70)
        Me.panel_hdr.Name = "panel_hdr"
        Me.panel_hdr.Size = New System.Drawing.Size(653, 20)
        Me.panel_hdr.TabIndex = 103
        '
        'txt_trans_date
        '
        Me.txt_trans_date.Enabled = False
        Me.txt_trans_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_trans_date.Location = New System.Drawing.Point(530, 0)
        Me.txt_trans_date.Name = "txt_trans_date"
        Me.txt_trans_date.Size = New System.Drawing.Size(161, 21)
        Me.txt_trans_date.TabIndex = 102
        '
        'txt_book_id
        '
        Me.txt_book_id._Text = ""
        Me.txt_book_id.AllowNegative = False
        Me.txt_book_id.AlwaysDisable = True
        Me.txt_book_id.AlwaysEnable = False
        Me.txt_book_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_id.DataSource = ""
        Me.txt_book_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_id.Enabled = False
        Me.txt_book_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_book_id.ispk = False
        Me.txt_book_id.Location = New System.Drawing.Point(275, 0)
        Me.txt_book_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_id.MultiLine = False
        Me.txt_book_id.Name = "txt_book_id"
        Me.txt_book_id.NoClear = False
        Me.txt_book_id.NumberFormat = "@"
        Me.txt_book_id.Required = False
        Me.txt_book_id.RowData = Nothing
        Me.txt_book_id.SelectionLength = 0
        Me.txt_book_id.SelectionStart = 0
        Me.txt_book_id.Size = New System.Drawing.Size(135, 20)
        Me.txt_book_id.TabIndex = 100
        Me.txt_book_id.TableData = Nothing
        Me.txt_book_id.TextSource = ""
        Me.txt_book_id.UseSystemPasswordChar = False
        Me.txt_book_id.Value = ""
        Me.txt_book_id.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Book"
        '
        'txt_currency_id
        '
        Me.txt_currency_id._Text = ""
        Me.txt_currency_id.AllowNegative = False
        Me.txt_currency_id.AlwaysDisable = False
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.DataSource = ""
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.Enabled = False
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.ispk = False
        Me.txt_currency_id.Location = New System.Drawing.Point(81, 0)
        Me.txt_currency_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.MultiLine = False
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.SelectionLength = 0
        Me.txt_currency_id.SelectionStart = 0
        Me.txt_currency_id.Size = New System.Drawing.Size(135, 20)
        Me.txt_currency_id.TabIndex = 98
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.TextSource = ""
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Currency"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Beginning Balance"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(262, 240)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Tag = "btnRemove"
        Me.btnPrint.Text = "F5 Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'txt_trans_id
        '
        Me.txt_trans_id._Text = ""
        Me.txt_trans_id.AllowNegative = False
        Me.txt_trans_id.AlwaysDisable = True
        Me.txt_trans_id.AlwaysEnable = False
        Me.txt_trans_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_id.DataSource = ""
        Me.txt_trans_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_id.Enabled = False
        Me.txt_trans_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_id.ispk = False
        Me.txt_trans_id.Location = New System.Drawing.Point(313, 37)
        Me.txt_trans_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_id.MultiLine = False
        Me.txt_trans_id.Name = "txt_trans_id"
        Me.txt_trans_id.NoClear = False
        Me.txt_trans_id.NumberFormat = "@"
        Me.txt_trans_id.Required = False
        Me.txt_trans_id.RowData = Nothing
        Me.txt_trans_id.SelectionLength = 0
        Me.txt_trans_id.SelectionStart = 0
        Me.txt_trans_id.Size = New System.Drawing.Size(35, 20)
        Me.txt_trans_id.TabIndex = 104
        Me.txt_trans_id.TableData = Nothing
        Me.txt_trans_id.TextSource = ""
        Me.txt_trans_id.UseSystemPasswordChar = False
        Me.txt_trans_id.Value = ""
        Me.txt_trans_id.ValueSource = ""
        Me.txt_trans_id.Visible = False
        '
        'primary_key
        '
        Me.primary_key._Text = ""
        Me.primary_key.AllowNegative = False
        Me.primary_key.AlwaysDisable = True
        Me.primary_key.AlwaysEnable = False
        Me.primary_key.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.primary_key.BorderColor = System.Drawing.Color.DarkGray
        Me.primary_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.primary_key.DataSource = ""
        Me.primary_key.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.primary_key.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.primary_key.Enabled = False
        Me.primary_key.EnabledBackColor = System.Drawing.Color.White
        Me.primary_key.ispk = False
        Me.primary_key.Location = New System.Drawing.Point(263, 37)
        Me.primary_key.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.MultiLine = False
        Me.primary_key.Name = "primary_key"
        Me.primary_key.NoClear = False
        Me.primary_key.NumberFormat = "@"
        Me.primary_key.Required = False
        Me.primary_key.RowData = Nothing
        Me.primary_key.SelectionLength = 0
        Me.primary_key.SelectionStart = 0
        Me.primary_key.Size = New System.Drawing.Size(44, 20)
        Me.primary_key.TabIndex = 90
        Me.primary_key.TableData = Nothing
        Me.primary_key.TextSource = ""
        Me.primary_key.UseSystemPasswordChar = False
        Me.primary_key.Value = ""
        Me.primary_key.ValueSource = "jbooks_id"
        Me.primary_key.Visible = False
        '
        'lbl_debit
        '
        Me.lbl_debit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_debit.AutoSize = True
        Me.lbl_debit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_debit.ForeColor = System.Drawing.Color.Blue
        Me.lbl_debit.Location = New System.Drawing.Point(14, 216)
        Me.lbl_debit.Name = "lbl_debit"
        Me.lbl_debit.Size = New System.Drawing.Size(31, 13)
        Me.lbl_debit.TabIndex = 107
        Me.lbl_debit.Text = "0.00"
        Me.lbl_debit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_credit
        '
        Me.lbl_credit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_credit.AutoSize = True
        Me.lbl_credit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_credit.ForeColor = System.Drawing.Color.Blue
        Me.lbl_credit.Location = New System.Drawing.Point(141, 216)
        Me.lbl_credit.Name = "lbl_credit"
        Me.lbl_credit.Size = New System.Drawing.Size(31, 13)
        Me.lbl_credit.TabIndex = 108
        Me.lbl_credit.Text = "0.00"
        Me.lbl_credit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_difference
        '
        Me.lbl_difference.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_difference.AutoSize = True
        Me.lbl_difference.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_difference.ForeColor = System.Drawing.Color.Red
        Me.lbl_difference.Location = New System.Drawing.Point(268, 216)
        Me.lbl_difference.Name = "lbl_difference"
        Me.lbl_difference.Size = New System.Drawing.Size(31, 13)
        Me.lbl_difference.TabIndex = 109
        Me.lbl_difference.Text = "0.00"
        Me.lbl_difference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_difference_based
        '
        Me.lbl_difference_based.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_difference_based.AutoSize = True
        Me.lbl_difference_based.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_difference_based.ForeColor = System.Drawing.Color.Red
        Me.lbl_difference_based.Location = New System.Drawing.Point(649, 216)
        Me.lbl_difference_based.Name = "lbl_difference_based"
        Me.lbl_difference_based.Size = New System.Drawing.Size(31, 13)
        Me.lbl_difference_based.TabIndex = 112
        Me.lbl_difference_based.Text = "0.00"
        Me.lbl_difference_based.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_credit_based
        '
        Me.lbl_credit_based.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_credit_based.AutoSize = True
        Me.lbl_credit_based.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_credit_based.ForeColor = System.Drawing.Color.Blue
        Me.lbl_credit_based.Location = New System.Drawing.Point(522, 216)
        Me.lbl_credit_based.Name = "lbl_credit_based"
        Me.lbl_credit_based.Size = New System.Drawing.Size(31, 13)
        Me.lbl_credit_based.TabIndex = 111
        Me.lbl_credit_based.Text = "0.00"
        Me.lbl_credit_based.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_debit_based
        '
        Me.lbl_debit_based.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_debit_based.AutoSize = True
        Me.lbl_debit_based.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_debit_based.ForeColor = System.Drawing.Color.Blue
        Me.lbl_debit_based.Location = New System.Drawing.Point(395, 216)
        Me.lbl_debit_based.Name = "lbl_debit_based"
        Me.lbl_debit_based.Size = New System.Drawing.Size(31, 13)
        Me.lbl_debit_based.TabIndex = 110
        Me.lbl_debit_based.Text = "0.00"
        Me.lbl_debit_based.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsearch
        '
        Me.txtsearch._Text = ""
        Me.txtsearch.AllowNegative = False
        Me.txtsearch.AlwaysDisable = False
        Me.txtsearch.AlwaysEnable = False
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderColor = System.Drawing.Color.DarkGray
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.DataSource = ""
        Me.txtsearch.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtsearch.EnabledBackColor = System.Drawing.Color.White
        Me.txtsearch.ispk = False
        Me.txtsearch.Location = New System.Drawing.Point(527, 34)
        Me.txtsearch.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.MultiLine = False
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.SelectionLength = 0
        Me.txtsearch.SelectionStart = 0
        Me.txtsearch.Size = New System.Drawing.Size(222, 20)
        Me.txtsearch.TabIndex = 1
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = "account_code,account_name,book_unit_no_name,project_name,department_name,project_" &
    "unit_no_names"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(484, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Search"
        '
        'Begbal
        '
        Me.Begbal.DataSetName = "begbal"
        Me.Begbal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransjbooksBindingSource
        '
        Me.TransjbooksBindingSource.DataMember = "trans_jbooks"
        Me.TransjbooksBindingSource.DataSource = Me.Begbal
        '
        'border1
        '
        Me.border1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(15, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(734, 2)
        Me.border1.TabIndex = 88
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fsbeg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 446)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_difference_based)
        Me.Controls.Add(Me.lbl_credit_based)
        Me.Controls.Add(Me.lbl_debit_based)
        Me.Controls.Add(Me.lbl_difference)
        Me.Controls.Add(Me.lbl_credit)
        Me.Controls.Add(Me.lbl_debit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txt_trans_id)
        Me.Controls.Add(Me.panel_hdr)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.primary_key)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(781, 485)
        Me.Name = "fsbeg"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Beginning Balance"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_hdr.ResumeLayout(False)
        Me.panel_hdr.PerformLayout()
        CType(Me.Begbal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransjbooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents primary_key As user_control.textbox
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_project_id As user_control.textbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_credit_based As user_control.textbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_debit_based As user_control.textbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_credit As user_control.textbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_debit As user_control.textbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_account_id As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_department_id As user_control.textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents txt_account_name As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents panel_hdr As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_book_id As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_trans_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_jbooks_id As user_control.textbox
    Friend WithEvents txt_trans_id As user_control.textbox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txt_based_rate As user_control.textbox
    Friend WithEvents txt_exchange_rate As user_control.textbox
    Friend WithEvents txt_currency As user_control.textbox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_debit As System.Windows.Forms.Label
    Friend WithEvents lbl_credit As System.Windows.Forms.Label
    Friend WithEvents lbl_difference As System.Windows.Forms.Label
    Friend WithEvents lbl_difference_based As System.Windows.Forms.Label
    Friend WithEvents lbl_credit_based As System.Windows.Forms.Label
    Friend WithEvents lbl_debit_based As System.Windows.Forms.Label
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Begbal As begbal
    Friend WithEvents TransjbooksBindingSource As Windows.Forms.BindingSource
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents jbooks_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_unit_no_name As Windows.Forms.DataGridViewTextBoxColumn
End Class
