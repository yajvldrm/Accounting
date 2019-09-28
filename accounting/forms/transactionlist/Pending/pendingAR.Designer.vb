<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pendingAR
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.rdo_asof = New System.Windows.Forms.RadioButton()
        Me.rdo_range = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_trans_no = New System.Windows.Forms.TextBox()
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.SelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.exchange_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.based_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jbooks_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet()
        Me.trans_header = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.checks = New System.Data.DataTable()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_general_id = New user_control.MyTextBox()
        Me.txt_account_id = New user_control.MyTextBox()
        Me.txt_journal_id = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GenRef"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txt_date_to)
        Me.Panel1.Controls.Add(Me.txt_date_from)
        Me.Panel1.Controls.Add(Me.rdo_asof)
        Me.Panel1.Controls.Add(Me.rdo_range)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 80)
        Me.Panel1.TabIndex = 2
        '
        'txt_date_to
        '
        Me.txt_date_to.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(54, 54)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(102, 20)
        Me.txt_date_to.TabIndex = 6
        '
        'txt_date_from
        '
        Me.txt_date_from.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(54, 28)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(102, 20)
        Me.txt_date_from.TabIndex = 5
        '
        'rdo_asof
        '
        Me.rdo_asof.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdo_asof.AutoSize = True
        Me.rdo_asof.Location = New System.Drawing.Point(86, 5)
        Me.rdo_asof.Name = "rdo_asof"
        Me.rdo_asof.Size = New System.Drawing.Size(51, 17)
        Me.rdo_asof.TabIndex = 4
        Me.rdo_asof.TabStop = True
        Me.rdo_asof.Text = "As Of"
        Me.rdo_asof.UseVisualStyleBackColor = True
        '
        'rdo_range
        '
        Me.rdo_range.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdo_range.AutoSize = True
        Me.rdo_range.Location = New System.Drawing.Point(22, 5)
        Me.rdo_range.Name = "rdo_range"
        Me.rdo_range.Size = New System.Drawing.Size(57, 17)
        Me.rdo_range.TabIndex = 3
        Me.rdo_range.TabStop = True
        Me.rdo_range.Text = "Range"
        Me.rdo_range.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ref No"
        '
        'txt_trans_no
        '
        Me.txt_trans_no.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_trans_no.Location = New System.Drawing.Point(59, 145)
        Me.txt_trans_no.Name = "txt_trans_no"
        Me.txt_trans_no.Size = New System.Drawing.Size(111, 20)
        Me.txt_trans_no.TabIndex = 4
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgView.AutoGenerateColumns = False
        Me.dgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelDataGridViewCheckBoxColumn, Me.exchange_rate, Me.based_rate, Me.general_id, Me.general_code, Me.trans_id, Me.trans_no, Me.trans_date, Me.book_id, Me.book_code, Me.book_name, Me.journal_id, Me.journal_code, Me.journal_name, Me.jbooks_id, Me.account_id, Me.account_code, Me.account_name, Me.general_name, Me.project_id, Me.project_code, Me.project_name, Me.department_id, Me.department_code, Me.department_name, Me.unit_id, Me.unit_code, Me.unit_name, Me.debit, Me.credit, Me.credit_based, Me.debit_based, Me.currency_id, Me.currency_code, Me.currency_name})
        Me.dgView.DataSource = Me.bs
        Me.dgView.Location = New System.Drawing.Point(12, 227)
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(158, 120)
        Me.dgView.TabIndex = 5
        '
        'SelDataGridViewCheckBoxColumn
        '
        Me.SelDataGridViewCheckBoxColumn.DataPropertyName = "sel"
        Me.SelDataGridViewCheckBoxColumn.HeaderText = "sel"
        Me.SelDataGridViewCheckBoxColumn.Name = "SelDataGridViewCheckBoxColumn"
        Me.SelDataGridViewCheckBoxColumn.ReadOnly = True
        Me.SelDataGridViewCheckBoxColumn.Visible = False
        '
        'exchange_rate
        '
        Me.exchange_rate.DataPropertyName = "exchange_rate"
        Me.exchange_rate.HeaderText = "exchange_rate"
        Me.exchange_rate.Name = "exchange_rate"
        Me.exchange_rate.ReadOnly = True
        Me.exchange_rate.Visible = False
        '
        'based_rate
        '
        Me.based_rate.DataPropertyName = "based_rate"
        Me.based_rate.HeaderText = "based_rate"
        Me.based_rate.Name = "based_rate"
        Me.based_rate.ReadOnly = True
        Me.based_rate.Visible = False
        '
        'general_id
        '
        Me.general_id.DataPropertyName = "general_id"
        Me.general_id.HeaderText = "general_id"
        Me.general_id.Name = "general_id"
        Me.general_id.ReadOnly = True
        Me.general_id.Visible = False
        '
        'general_code
        '
        Me.general_code.DataPropertyName = "general_code"
        Me.general_code.HeaderText = "general_code"
        Me.general_code.Name = "general_code"
        Me.general_code.ReadOnly = True
        Me.general_code.Visible = False
        '
        'trans_id
        '
        Me.trans_id.DataPropertyName = "trans_id"
        Me.trans_id.HeaderText = "trans_id"
        Me.trans_id.Name = "trans_id"
        Me.trans_id.ReadOnly = True
        Me.trans_id.Visible = False
        '
        'trans_no
        '
        Me.trans_no.DataPropertyName = "trans_no"
        Me.trans_no.HeaderText = "Ref No"
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        '
        'trans_date
        '
        Me.trans_date.DataPropertyName = "trans_date"
        Me.trans_date.HeaderText = "Date"
        Me.trans_date.Name = "trans_date"
        Me.trans_date.ReadOnly = True
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.HeaderText = "book_id"
        Me.book_id.Name = "book_id"
        Me.book_id.ReadOnly = True
        Me.book_id.Visible = False
        '
        'book_code
        '
        Me.book_code.DataPropertyName = "book_code"
        Me.book_code.HeaderText = "Book"
        Me.book_code.Name = "book_code"
        Me.book_code.ReadOnly = True
        '
        'book_name
        '
        Me.book_name.DataPropertyName = "book_name"
        Me.book_name.HeaderText = "book_name"
        Me.book_name.Name = "book_name"
        Me.book_name.ReadOnly = True
        Me.book_name.Visible = False
        '
        'journal_id
        '
        Me.journal_id.DataPropertyName = "journal_id"
        Me.journal_id.HeaderText = "journal_id"
        Me.journal_id.Name = "journal_id"
        Me.journal_id.ReadOnly = True
        Me.journal_id.Visible = False
        '
        'journal_code
        '
        Me.journal_code.DataPropertyName = "journal_code"
        Me.journal_code.HeaderText = "journal_code"
        Me.journal_code.Name = "journal_code"
        Me.journal_code.ReadOnly = True
        Me.journal_code.Visible = False
        '
        'journal_name
        '
        Me.journal_name.DataPropertyName = "journal_name"
        Me.journal_name.HeaderText = "journal_name"
        Me.journal_name.Name = "journal_name"
        Me.journal_name.ReadOnly = True
        Me.journal_name.Visible = False
        '
        'jbooks_id
        '
        Me.jbooks_id.DataPropertyName = "jbooks_id"
        Me.jbooks_id.HeaderText = "jbooks_id"
        Me.jbooks_id.Name = "jbooks_id"
        Me.jbooks_id.ReadOnly = True
        Me.jbooks_id.Visible = False
        '
        'account_id
        '
        Me.account_id.DataPropertyName = "account_id"
        Me.account_id.HeaderText = "account_id"
        Me.account_id.Name = "account_id"
        Me.account_id.ReadOnly = True
        Me.account_id.Visible = False
        '
        'account_code
        '
        Me.account_code.DataPropertyName = "account_code"
        Me.account_code.HeaderText = "account_code"
        Me.account_code.Name = "account_code"
        Me.account_code.ReadOnly = True
        Me.account_code.Visible = False
        '
        'account_name
        '
        Me.account_name.DataPropertyName = "account_name"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.account_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.account_name.HeaderText = "Account"
        Me.account_name.Name = "account_name"
        Me.account_name.ReadOnly = True
        '
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.general_name.DefaultCellStyle = DataGridViewCellStyle5
        Me.general_name.HeaderText = "General"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        '
        'project_id
        '
        Me.project_id.DataPropertyName = "project_id"
        Me.project_id.HeaderText = "project_id"
        Me.project_id.Name = "project_id"
        Me.project_id.ReadOnly = True
        Me.project_id.Visible = False
        '
        'project_code
        '
        Me.project_code.DataPropertyName = "project_code"
        Me.project_code.HeaderText = "Project"
        Me.project_code.Name = "project_code"
        Me.project_code.ReadOnly = True
        '
        'project_name
        '
        Me.project_name.DataPropertyName = "project_name"
        Me.project_name.HeaderText = "project_name"
        Me.project_name.Name = "project_name"
        Me.project_name.ReadOnly = True
        Me.project_name.Visible = False
        '
        'department_id
        '
        Me.department_id.DataPropertyName = "department_id"
        Me.department_id.HeaderText = "department_id"
        Me.department_id.Name = "department_id"
        Me.department_id.ReadOnly = True
        Me.department_id.Visible = False
        '
        'department_code
        '
        Me.department_code.DataPropertyName = "department_code"
        Me.department_code.HeaderText = "Department"
        Me.department_code.Name = "department_code"
        Me.department_code.ReadOnly = True
        '
        'department_name
        '
        Me.department_name.DataPropertyName = "department_name"
        Me.department_name.HeaderText = "department_name"
        Me.department_name.Name = "department_name"
        Me.department_name.ReadOnly = True
        Me.department_name.Visible = False
        '
        'unit_id
        '
        Me.unit_id.DataPropertyName = "unit_id"
        Me.unit_id.HeaderText = "unit_id"
        Me.unit_id.Name = "unit_id"
        Me.unit_id.ReadOnly = True
        Me.unit_id.Visible = False
        '
        'unit_code
        '
        Me.unit_code.DataPropertyName = "unit_code"
        Me.unit_code.HeaderText = "unit_code"
        Me.unit_code.Name = "unit_code"
        Me.unit_code.ReadOnly = True
        Me.unit_code.Visible = False
        '
        'unit_name
        '
        Me.unit_name.DataPropertyName = "unit_name"
        Me.unit_name.HeaderText = "Unit"
        Me.unit_name.Name = "unit_name"
        Me.unit_name.ReadOnly = True
        '
        'debit
        '
        Me.debit.DataPropertyName = "debit"
        Me.debit.HeaderText = "debit"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        Me.debit.Visible = False
        '
        'credit
        '
        Me.credit.DataPropertyName = "credit"
        Me.credit.HeaderText = "credit"
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        Me.credit.Visible = False
        '
        'credit_based
        '
        Me.credit_based.DataPropertyName = "credit_based"
        Me.credit_based.HeaderText = "Debit"
        Me.credit_based.Name = "credit_based"
        Me.credit_based.ReadOnly = True
        Me.credit_based.Visible = False
        '
        'debit_based
        '
        Me.debit_based.DataPropertyName = "debit_based"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.debit_based.DefaultCellStyle = DataGridViewCellStyle6
        Me.debit_based.HeaderText = "Amount"
        Me.debit_based.Name = "debit_based"
        Me.debit_based.ReadOnly = True
        '
        'currency_id
        '
        Me.currency_id.DataPropertyName = "currency_id"
        Me.currency_id.HeaderText = "currency_id"
        Me.currency_id.Name = "currency_id"
        Me.currency_id.ReadOnly = True
        Me.currency_id.Visible = False
        '
        'currency_code
        '
        Me.currency_code.DataPropertyName = "currency_code"
        Me.currency_code.HeaderText = "currency_code"
        Me.currency_code.Name = "currency_code"
        Me.currency_code.ReadOnly = True
        Me.currency_code.Visible = False
        '
        'currency_name
        '
        Me.currency_name.DataPropertyName = "currency_name"
        Me.currency_name.HeaderText = "currency_name"
        Me.currency_name.Name = "currency_name"
        Me.currency_name.ReadOnly = True
        Me.currency_name.Visible = False
        '
        'bs
        '
        Me.bs.DataMember = "trans_header"
        Me.bs.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_header, Me.checks})
        '
        'trans_header
        '
        Me.trans_header.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35})
        Me.trans_header.TableName = "trans_header"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "trans_no"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "trans_date"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "book_id"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "book_code"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "book_name"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "journal_id"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "journal_code"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "journal_name"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "jbooks_id"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "account_id"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "account_code"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "account_name"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "project_id"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "project_code"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "project_name"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "department_id"
        Me.DataColumn18.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "department_code"
        Me.DataColumn19.DefaultValue = ""
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "department_name"
        Me.DataColumn20.DefaultValue = ""
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "unit_id"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "unit_code"
        Me.DataColumn22.DefaultValue = ""
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "unit_name"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "debit"
        Me.DataColumn24.DataType = GetType(Decimal)
        Me.DataColumn24.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "credit"
        Me.DataColumn25.DataType = GetType(Decimal)
        Me.DataColumn25.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "debit_based"
        Me.DataColumn26.DataType = GetType(Decimal)
        Me.DataColumn26.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "credit_based"
        Me.DataColumn27.DataType = GetType(Decimal)
        Me.DataColumn27.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "general_id"
        Me.DataColumn28.DefaultValue = ""
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "general_code"
        Me.DataColumn29.DefaultValue = ""
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "general_name"
        Me.DataColumn30.DefaultValue = ""
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "currency_id"
        Me.DataColumn31.DefaultValue = ""
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "currency_code"
        Me.DataColumn32.DefaultValue = ""
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "currency_name"
        Me.DataColumn33.DefaultValue = ""
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "exchange_rate"
        Me.DataColumn34.DataType = GetType(Decimal)
        Me.DataColumn34.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "based_rate"
        Me.DataColumn35.DataType = GetType(Decimal)
        Me.DataColumn35.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'checks
        '
        Me.checks.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72})
        Me.checks.TableName = "checks"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "check_id"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "jbooks_id"
        Me.DataColumn37.DefaultValue = ""
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "general_id"
        Me.DataColumn38.DefaultValue = ""
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "check_no"
        Me.DataColumn39.DefaultValue = ""
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "check_date"
        Me.DataColumn40.DataType = GetType(Date)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "check_amount"
        Me.DataColumn41.DataType = GetType(Decimal)
        Me.DataColumn41.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "check_amount_based"
        Me.DataColumn42.DataType = GetType(Decimal)
        Me.DataColumn42.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "bank_id"
        Me.DataColumn43.DefaultValue = ""
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "cleared"
        Me.DataColumn44.DataType = GetType(Boolean)
        Me.DataColumn44.DefaultValue = False
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "released"
        Me.DataColumn45.DataType = GetType(Boolean)
        Me.DataColumn45.DefaultValue = False
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "cancelled"
        Me.DataColumn46.DataType = GetType(Boolean)
        Me.DataColumn46.DefaultValue = False
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "crossed"
        Me.DataColumn47.DataType = GetType(Boolean)
        Me.DataColumn47.DefaultValue = False
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "replacement_check_no"
        Me.DataColumn48.DefaultValue = ""
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "cleared_date"
        Me.DataColumn49.DataType = GetType(Date)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "deposit_date"
        Me.DataColumn50.DataType = GetType(Date)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "cancel_date"
        Me.DataColumn51.DataType = GetType(Date)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "replaced"
        Me.DataColumn52.DataType = GetType(Boolean)
        Me.DataColumn52.DefaultValue = False
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "general_code"
        Me.DataColumn53.DefaultValue = ""
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "general_name"
        Me.DataColumn54.DefaultValue = ""
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "deleted"
        Me.DataColumn55.DataType = GetType(Boolean)
        Me.DataColumn55.DefaultValue = False
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "currency_id"
        Me.DataColumn56.DefaultValue = ""
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "exchange_rate"
        Me.DataColumn57.DataType = GetType(Decimal)
        Me.DataColumn57.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "based_rate"
        Me.DataColumn58.DataType = GetType(Decimal)
        Me.DataColumn58.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "currency_code"
        Me.DataColumn59.DefaultValue = ""
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "currency_name"
        Me.DataColumn60.DefaultValue = ""
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "trans_no"
        Me.DataColumn61.DefaultValue = ""
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "bank_code"
        Me.DataColumn62.DefaultValue = ""
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "bank_name"
        Me.DataColumn63.DefaultValue = ""
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "isCash"
        Me.DataColumn64.DataType = GetType(Boolean)
        Me.DataColumn64.DefaultValue = False
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "isReplaced"
        Me.DataColumn65.DataType = GetType(Boolean)
        Me.DataColumn65.DefaultValue = False
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "debit"
        Me.DataColumn66.DataType = GetType(Decimal)
        Me.DataColumn66.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "credit"
        Me.DataColumn67.DataType = GetType(Decimal)
        Me.DataColumn67.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "debit_based"
        Me.DataColumn68.DataType = GetType(Decimal)
        Me.DataColumn68.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "credit_based"
        Me.DataColumn69.DataType = GetType(Decimal)
        Me.DataColumn69.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "bank_code_depository"
        Me.DataColumn70.DefaultValue = ""
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "bank_name_depository"
        Me.DataColumn71.DefaultValue = ""
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "isPDC"
        Me.DataColumn72.DataType = GetType(Boolean)
        Me.DataColumn72.DefaultValue = False
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 198)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "Create OR"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Account"
        '
        'txt_general_id
        '
        Me.txt_general_id.AlwaysDisable = False
        Me.txt_general_id.AlwaysEnable = True
        Me.txt_general_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_general_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.BrowseDataSource = ""
        Me.txt_general_id.BrowseField = ""
        Me.txt_general_id.BrowseFilter = Nothing
        Me.txt_general_id.BrowseLabel = "Code,Name"
        Me.txt_general_id.BrowseLabelWidth = "100,200"
        Me.txt_general_id.BrowseTextSource = ""
        Me.txt_general_id.BrowseValueSource = ""
        Me.txt_general_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.Enabled = False
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_general_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.ID = False
        Me.txt_general_id.Location = New System.Drawing.Point(62, 7)
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NoSave = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.Size = New System.Drawing.Size(108, 20)
        Me.txt_general_id.TabIndex = 1
        Me.txt_general_id.TextBrowse = False
        Me.txt_general_id.TextSource = ""
        Me.txt_general_id.ToUpper = True
        Me.txt_general_id.Unique = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = ""
        '
        'txt_account_id
        '
        Me.txt_account_id.AlwaysDisable = False
        Me.txt_account_id.AlwaysEnable = True
        Me.txt_account_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_account_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_id.BrowseDataSource = ""
        Me.txt_account_id.BrowseField = ""
        Me.txt_account_id.BrowseFilter = Nothing
        Me.txt_account_id.BrowseLabel = "Code,Name"
        Me.txt_account_id.BrowseLabelWidth = "100,200"
        Me.txt_account_id.BrowseTextSource = ""
        Me.txt_account_id.BrowseValueSource = ""
        Me.txt_account_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_account_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_id.Enabled = False
        Me.txt_account_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_account_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_id.ID = False
        Me.txt_account_id.Location = New System.Drawing.Point(62, 33)
        Me.txt_account_id.Name = "txt_account_id"
        Me.txt_account_id.NoClear = False
        Me.txt_account_id.NoSave = False
        Me.txt_account_id.NumberFormat = "@"
        Me.txt_account_id.Required = False
        Me.txt_account_id.RowData = Nothing
        Me.txt_account_id.Size = New System.Drawing.Size(108, 20)
        Me.txt_account_id.TabIndex = 8
        Me.txt_account_id.TextBrowse = False
        Me.txt_account_id.TextSource = ""
        Me.txt_account_id.ToUpper = True
        Me.txt_account_id.Unique = False
        Me.txt_account_id.Value = ""
        Me.txt_account_id.ValueSource = ""
        '
        'txt_journal_id
        '
        Me.txt_journal_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_journal_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_journal_id.FormattingEnabled = True
        Me.txt_journal_id.Items.AddRange(New Object() {"ALL VOUCHER", "Invoicing", "Official Receipt", "Accounts Payable", "Check Voucher", "Journal Voucher", "Petty Cash Voucher", "Debit/Credit Memo", "Beginning Balance"})
        Me.txt_journal_id.Location = New System.Drawing.Point(59, 171)
        Me.txt_journal_id.Name = "txt_journal_id"
        Me.txt_journal_id.Size = New System.Drawing.Size(111, 21)
        Me.txt_journal_id.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Voucher"
        '
        'pendingAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 359)
        Me.Controls.Add(Me.txt_journal_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_account_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.txt_trans_no)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_general_id)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 398)
        Me.Name = "pendingAR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pending AR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents txt_date_to As Windows.Forms.DateTimePicker
    Friend WithEvents txt_date_from As Windows.Forms.DateTimePicker
    Friend WithEvents rdo_asof As Windows.Forms.RadioButton
    Friend WithEvents rdo_range As Windows.Forms.RadioButton
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txt_trans_no As Windows.Forms.TextBox
    Friend WithEvents dgView As Windows.Forms.DataGridView
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents ds As DataSet
    Friend WithEvents trans_header As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents DataColumn18 As DataColumn
    Friend WithEvents DataColumn19 As DataColumn
    Friend WithEvents DataColumn20 As DataColumn
    Friend WithEvents DataColumn21 As DataColumn
    Friend WithEvents DataColumn22 As DataColumn
    Friend WithEvents DataColumn23 As DataColumn
    Friend WithEvents DataColumn24 As DataColumn
    Friend WithEvents DataColumn25 As DataColumn
    Friend WithEvents DataColumn26 As DataColumn
    Friend WithEvents DataColumn27 As DataColumn
    Friend WithEvents DataColumn28 As DataColumn
    Friend WithEvents DataColumn29 As DataColumn
    Friend WithEvents DataColumn30 As DataColumn
    Friend WithEvents txt_general_id As user_control.MyTextBox
    Friend WithEvents txt_account_id As user_control.MyTextBox
    Friend WithEvents DataColumn31 As DataColumn
    Friend WithEvents DataColumn32 As DataColumn
    Friend WithEvents DataColumn33 As DataColumn
    Friend WithEvents DataColumn34 As DataColumn
    Friend WithEvents DataColumn35 As DataColumn
    Friend WithEvents checks As DataTable
    Friend WithEvents DataColumn36 As DataColumn
    Friend WithEvents DataColumn37 As DataColumn
    Friend WithEvents DataColumn38 As DataColumn
    Friend WithEvents DataColumn39 As DataColumn
    Friend WithEvents DataColumn40 As DataColumn
    Friend WithEvents DataColumn41 As DataColumn
    Friend WithEvents DataColumn42 As DataColumn
    Friend WithEvents DataColumn43 As DataColumn
    Friend WithEvents DataColumn44 As DataColumn
    Friend WithEvents DataColumn45 As DataColumn
    Friend WithEvents DataColumn46 As DataColumn
    Friend WithEvents DataColumn47 As DataColumn
    Friend WithEvents DataColumn48 As DataColumn
    Friend WithEvents DataColumn49 As DataColumn
    Friend WithEvents DataColumn50 As DataColumn
    Friend WithEvents DataColumn51 As DataColumn
    Friend WithEvents DataColumn52 As DataColumn
    Friend WithEvents DataColumn53 As DataColumn
    Friend WithEvents DataColumn54 As DataColumn
    Friend WithEvents DataColumn55 As DataColumn
    Friend WithEvents DataColumn56 As DataColumn
    Friend WithEvents DataColumn57 As DataColumn
    Friend WithEvents DataColumn58 As DataColumn
    Friend WithEvents DataColumn59 As DataColumn
    Friend WithEvents DataColumn60 As DataColumn
    Friend WithEvents DataColumn61 As DataColumn
    Friend WithEvents DataColumn62 As DataColumn
    Friend WithEvents DataColumn63 As DataColumn
    Friend WithEvents DataColumn64 As DataColumn
    Friend WithEvents DataColumn65 As DataColumn
    Friend WithEvents DataColumn66 As DataColumn
    Friend WithEvents DataColumn67 As DataColumn
    Friend WithEvents DataColumn68 As DataColumn
    Friend WithEvents DataColumn69 As DataColumn
    Friend WithEvents DataColumn70 As DataColumn
    Friend WithEvents DataColumn71 As DataColumn
    Friend WithEvents DataColumn72 As DataColumn
    Friend WithEvents SelDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents exchange_rate As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents based_rate As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jbooks_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_journal_id As Windows.Forms.ComboBox
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
