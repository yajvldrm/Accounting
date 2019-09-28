<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountInquiry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountInquiry))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.range_filter = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdo3 = New user_control.rdo_button()
        Me.rdo2 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.currency_filter = New System.Windows.Forms.Panel()
        Me.lbl_currency_name = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_currency_id = New user_control.MyTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.withComparison = New user_control.MyCheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Rdo_button5 = New user_control.rdo_button()
        Me.Rdo_button6 = New user_control.rdo_button()
        Me.project_department_filter = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_department_id = New user_control.MyTextBox()
        Me.txt_project_id = New user_control.MyTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MyCheckBox1 = New user_control.MyCheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.journal_filter = New System.Windows.Forms.Panel()
        Me.txt_journal_id = New user_control.MyTextBox()
        Me.Rdo_button7 = New user_control.rdo_button()
        Me.Rdo_button4 = New user_control.rdo_button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.allocation_filter = New System.Windows.Forms.Panel()
        Me.lbl_allocation_name = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txt_allocation_id = New user_control.MyTextBox()
        Me.Rdo_button12 = New user_control.rdo_button()
        Me.Rdo_button13 = New user_control.rdo_button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.TransidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RrnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountmultipleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralmultipleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExchangerateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JournalidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JournalnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReftransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermsnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransgeneralnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefgeneralnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JournalcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChecknoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanynamesssDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsko = New accounting.accountanalysis_set()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_chart = New System.Data.DataTable()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.company = New System.Data.DataTable()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.general_filter = New System.Windows.Forms.Panel()
        Me.lbl_account_name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_general_id = New user_control.MyTextBox()
        Me.btn_browse_general = New user_control.MyButton()
        Me.Rdo_button3 = New user_control.rdo_button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Rdo_button1 = New user_control.rdo_button()
        Me.Rdo_button2 = New user_control.rdo_button()
        Me.book_filter = New System.Windows.Forms.Panel()
        Me.txt_book_id = New user_control.MyTextBox()
        Me.Rdo_button8 = New user_control.rdo_button()
        Me.Rdo_button9 = New user_control.rdo_button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btn_filter = New user_control.MyButton()
        Me.range_filter.SuspendLayout()
        Me.currency_filter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_department_filter.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.journal_filter.SuspendLayout()
        Me.allocation_filter.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsko, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.company, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.general_filter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.book_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 25)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Account Inquiry"
        '
        'range_filter
        '
        Me.range_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.range_filter.Controls.Add(Me.Label5)
        Me.range_filter.Controls.Add(Me.rdo3)
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Location = New System.Drawing.Point(11, 80)
        Me.range_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(535, 28)
        Me.range_filter.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Date"
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.DataSource = ""
        Me.rdo3.Location = New System.Drawing.Point(349, 5)
        Me.rdo3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(171, 17)
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
        Me.rdo2.Checked = True
        Me.rdo2.DataSource = ""
        Me.rdo2.Location = New System.Drawing.Point(229, 5)
        Me.rdo2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(101, 17)
        Me.rdo2.TabIndex = 2
        Me.rdo2.TabStop = True
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
        Me.rdo1.DataSource = ""
        Me.rdo1.Location = New System.Drawing.Point(124, 5)
        Me.rdo1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(81, 17)
        Me.rdo1.TabIndex = 1
        Me.rdo1.Text = "Range Only"
        Me.rdo1.TextSource = ""
        Me.rdo1.Uncheckable = False
        Me.rdo1.UseVisualStyleBackColor = True
        Me.rdo1.Value = "1"
        Me.rdo1.ValueSource = ""
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(775, 86)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(725, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Date To"
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(611, 86)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_from.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(550, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Date From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Filter Options"
        '
        'currency_filter
        '
        Me.currency_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currency_filter.Controls.Add(Me.lbl_currency_name)
        Me.currency_filter.Controls.Add(Me.PictureBox2)
        Me.currency_filter.Controls.Add(Me.txt_currency_id)
        Me.currency_filter.Controls.Add(Me.Label9)
        Me.currency_filter.Controls.Add(Me.withComparison)
        Me.currency_filter.Controls.Add(Me.Label7)
        Me.currency_filter.Controls.Add(Me.Rdo_button5)
        Me.currency_filter.Controls.Add(Me.Rdo_button6)
        Me.currency_filter.Location = New System.Drawing.Point(11, 150)
        Me.currency_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Name = "currency_filter"
        Me.currency_filter.Size = New System.Drawing.Size(867, 28)
        Me.currency_filter.TabIndex = 113
        '
        'lbl_currency_name
        '
        Me.lbl_currency_name.AutoSize = True
        Me.lbl_currency_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_currency_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_currency_name.Location = New System.Drawing.Point(647, 5)
        Me.lbl_currency_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_currency_name.Name = "lbl_currency_name"
        Me.lbl_currency_name.Size = New System.Drawing.Size(93, 16)
        Me.lbl_currency_name.TabIndex = 190
        Me.lbl_currency_name.Text = "Currency Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(627, 5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 189
        Me.PictureBox2.TabStop = False
        '
        'txt_currency_id
        '
        Me.txt_currency_id.AlwaysDisable = False
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.BrowseDataSource = ""
        Me.txt_currency_id.BrowseField = ""
        Me.txt_currency_id.BrowseFilter = Nothing
        Me.txt_currency_id.BrowseLabel = "Code,Name"
        Me.txt_currency_id.BrowseLabelWidth = "100,200"
        Me.txt_currency_id.BrowseTextSource = ""
        Me.txt_currency_id.BrowseValueSource = ""
        Me.txt_currency_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.Enabled = False
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_currency_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.ID = False
        Me.txt_currency_id.Location = New System.Drawing.Point(520, 3)
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NoSave = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_currency_id.TabIndex = 32
        Me.txt_currency_id.TextBrowse = False
        Me.txt_currency_id.TextSource = ""
        Me.txt_currency_id.ToUpper = True
        Me.txt_currency_id.Unique = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(465, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Currency"
        '
        'withComparison
        '
        Me.withComparison.AlwaysDisable = False
        Me.withComparison.AlwaysEnable = False
        Me.withComparison.AutoSize = True
        Me.withComparison.Enabled = False
        Me.withComparison.isChecked = False
        Me.withComparison.Location = New System.Drawing.Point(350, 6)
        Me.withComparison.Name = "withComparison"
        Me.withComparison.NoSave = False
        Me.withComparison.Size = New System.Drawing.Size(106, 17)
        Me.withComparison.TabIndex = 29
        Me.withComparison.Text = "With Comparison"
        Me.withComparison.UseVisualStyleBackColor = True
        Me.withComparison.ValueSource = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Currency"
        '
        'Rdo_button5
        '
        Me.Rdo_button5.AutoSize = True
        Me.Rdo_button5.DataSource = ""
        Me.Rdo_button5.Location = New System.Drawing.Point(236, 5)
        Me.Rdo_button5.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button5.Name = "Rdo_button5"
        Me.Rdo_button5.Size = New System.Drawing.Size(105, 17)
        Me.Rdo_button5.TabIndex = 3
        Me.Rdo_button5.Text = "Original Currency"
        Me.Rdo_button5.TextSource = ""
        Me.Rdo_button5.Uncheckable = False
        Me.Rdo_button5.UseVisualStyleBackColor = True
        Me.Rdo_button5.Value = "2"
        Me.Rdo_button5.ValueSource = ""
        '
        'Rdo_button6
        '
        Me.Rdo_button6.AutoSize = True
        Me.Rdo_button6.Checked = True
        Me.Rdo_button6.DataSource = ""
        Me.Rdo_button6.Location = New System.Drawing.Point(124, 6)
        Me.Rdo_button6.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button6.Name = "Rdo_button6"
        Me.Rdo_button6.Size = New System.Drawing.Size(100, 17)
        Me.Rdo_button6.TabIndex = 2
        Me.Rdo_button6.TabStop = True
        Me.Rdo_button6.Text = "Based Currency"
        Me.Rdo_button6.TextSource = ""
        Me.Rdo_button6.Uncheckable = False
        Me.Rdo_button6.UseVisualStyleBackColor = True
        Me.Rdo_button6.Value = "1"
        Me.Rdo_button6.ValueSource = ""
        '
        'project_department_filter
        '
        Me.project_department_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.project_department_filter.Controls.Add(Me.Label16)
        Me.project_department_filter.Controls.Add(Me.PictureBox4)
        Me.project_department_filter.Controls.Add(Me.Label13)
        Me.project_department_filter.Controls.Add(Me.PictureBox3)
        Me.project_department_filter.Controls.Add(Me.txt_department_id)
        Me.project_department_filter.Controls.Add(Me.txt_project_id)
        Me.project_department_filter.Controls.Add(Me.Label11)
        Me.project_department_filter.Controls.Add(Me.Label10)
        Me.project_department_filter.Controls.Add(Me.MyCheckBox1)
        Me.project_department_filter.Controls.Add(Me.Label8)
        Me.project_department_filter.Location = New System.Drawing.Point(11, 186)
        Me.project_department_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Name = "project_department_filter"
        Me.project_department_filter.Size = New System.Drawing.Size(867, 28)
        Me.project_department_filter.TabIndex = 114
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(750, 5)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 16)
        Me.Label16.TabIndex = 194
        Me.Label16.Text = "Department Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(730, 5)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 193
        Me.PictureBox4.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(454, 5)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 16)
        Me.Label13.TabIndex = 192
        Me.Label13.Text = "Project Name"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(434, 5)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 191
        Me.PictureBox3.TabStop = False
        '
        'txt_department_id
        '
        Me.txt_department_id.AlwaysDisable = False
        Me.txt_department_id.AlwaysEnable = False
        Me.txt_department_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department_id.BrowseDataSource = ""
        Me.txt_department_id.BrowseField = ""
        Me.txt_department_id.BrowseFilter = Nothing
        Me.txt_department_id.BrowseLabel = "Code,Name"
        Me.txt_department_id.BrowseLabelWidth = "100,200"
        Me.txt_department_id.BrowseTextSource = ""
        Me.txt_department_id.BrowseValueSource = ""
        Me.txt_department_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_department_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.Enabled = False
        Me.txt_department_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_department_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.ID = False
        Me.txt_department_id.Location = New System.Drawing.Point(618, 3)
        Me.txt_department_id.Name = "txt_department_id"
        Me.txt_department_id.NoClear = False
        Me.txt_department_id.NoSave = False
        Me.txt_department_id.NumberFormat = "@"
        Me.txt_department_id.Required = False
        Me.txt_department_id.RowData = Nothing
        Me.txt_department_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_department_id.TabIndex = 36
        Me.txt_department_id.TextBrowse = False
        Me.txt_department_id.TextSource = ""
        Me.txt_department_id.ToUpper = True
        Me.txt_department_id.Unique = False
        Me.txt_department_id.Value = ""
        Me.txt_department_id.ValueSource = ""
        '
        'txt_project_id
        '
        Me.txt_project_id.AlwaysDisable = False
        Me.txt_project_id.AlwaysEnable = False
        Me.txt_project_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_id.BrowseDataSource = ""
        Me.txt_project_id.BrowseField = ""
        Me.txt_project_id.BrowseFilter = Nothing
        Me.txt_project_id.BrowseLabel = "Code,Name"
        Me.txt_project_id.BrowseLabelWidth = "100,200"
        Me.txt_project_id.BrowseTextSource = ""
        Me.txt_project_id.BrowseValueSource = ""
        Me.txt_project_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_project_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.Enabled = False
        Me.txt_project_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_project_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.ID = False
        Me.txt_project_id.Location = New System.Drawing.Point(328, 3)
        Me.txt_project_id.Name = "txt_project_id"
        Me.txt_project_id.NoClear = False
        Me.txt_project_id.NoSave = False
        Me.txt_project_id.NumberFormat = "@"
        Me.txt_project_id.Required = False
        Me.txt_project_id.RowData = Nothing
        Me.txt_project_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_project_id.TabIndex = 35
        Me.txt_project_id.TextBrowse = False
        Me.txt_project_id.TextSource = ""
        Me.txt_project_id.ToUpper = True
        Me.txt_project_id.Unique = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(550, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Department"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(282, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Project"
        '
        'MyCheckBox1
        '
        Me.MyCheckBox1.AlwaysDisable = False
        Me.MyCheckBox1.AlwaysEnable = False
        Me.MyCheckBox1.AutoSize = True
        Me.MyCheckBox1.Enabled = False
        Me.MyCheckBox1.isChecked = False
        Me.MyCheckBox1.Location = New System.Drawing.Point(124, 6)
        Me.MyCheckBox1.Name = "MyCheckBox1"
        Me.MyCheckBox1.NoSave = False
        Me.MyCheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.MyCheckBox1.TabIndex = 28
        Me.MyCheckBox1.Text = " With Project/Department"
        Me.MyCheckBox1.UseVisualStyleBackColor = True
        Me.MyCheckBox1.ValueSource = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Project/Dept"
        '
        'journal_filter
        '
        Me.journal_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.journal_filter.Controls.Add(Me.txt_journal_id)
        Me.journal_filter.Controls.Add(Me.Rdo_button7)
        Me.journal_filter.Controls.Add(Me.Rdo_button4)
        Me.journal_filter.Controls.Add(Me.Label14)
        Me.journal_filter.Location = New System.Drawing.Point(11, 222)
        Me.journal_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.journal_filter.Name = "journal_filter"
        Me.journal_filter.Size = New System.Drawing.Size(438, 28)
        Me.journal_filter.TabIndex = 115
        '
        'txt_journal_id
        '
        Me.txt_journal_id.AlwaysDisable = False
        Me.txt_journal_id.AlwaysEnable = False
        Me.txt_journal_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_journal_id.BrowseDataSource = ""
        Me.txt_journal_id.BrowseField = ""
        Me.txt_journal_id.BrowseFilter = Nothing
        Me.txt_journal_id.BrowseLabel = "Code,Name"
        Me.txt_journal_id.BrowseLabelWidth = "100,200"
        Me.txt_journal_id.BrowseTextSource = ""
        Me.txt_journal_id.BrowseValueSource = ""
        Me.txt_journal_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_journal_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_journal_id.Enabled = False
        Me.txt_journal_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_journal_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_journal_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_journal_id.ID = False
        Me.txt_journal_id.Location = New System.Drawing.Point(319, 3)
        Me.txt_journal_id.Name = "txt_journal_id"
        Me.txt_journal_id.NoClear = False
        Me.txt_journal_id.NoSave = False
        Me.txt_journal_id.NumberFormat = "@"
        Me.txt_journal_id.Required = False
        Me.txt_journal_id.RowData = Nothing
        Me.txt_journal_id.Size = New System.Drawing.Size(109, 20)
        Me.txt_journal_id.TabIndex = 36
        Me.txt_journal_id.TextBrowse = False
        Me.txt_journal_id.TextSource = ""
        Me.txt_journal_id.ToUpper = True
        Me.txt_journal_id.Unique = False
        Me.txt_journal_id.Value = ""
        Me.txt_journal_id.ValueSource = ""
        '
        'Rdo_button7
        '
        Me.Rdo_button7.AutoSize = True
        Me.Rdo_button7.DataSource = ""
        Me.Rdo_button7.Location = New System.Drawing.Point(236, 5)
        Me.Rdo_button7.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button7.Name = "Rdo_button7"
        Me.Rdo_button7.Size = New System.Drawing.Size(78, 17)
        Me.Rdo_button7.TabIndex = 35
        Me.Rdo_button7.Text = "Per Journal"
        Me.Rdo_button7.TextSource = ""
        Me.Rdo_button7.Uncheckable = False
        Me.Rdo_button7.UseVisualStyleBackColor = True
        Me.Rdo_button7.Value = "2"
        Me.Rdo_button7.ValueSource = ""
        '
        'Rdo_button4
        '
        Me.Rdo_button4.AutoSize = True
        Me.Rdo_button4.Checked = True
        Me.Rdo_button4.DataSource = ""
        Me.Rdo_button4.Location = New System.Drawing.Point(124, 6)
        Me.Rdo_button4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button4.Name = "Rdo_button4"
        Me.Rdo_button4.Size = New System.Drawing.Size(78, 17)
        Me.Rdo_button4.TabIndex = 31
        Me.Rdo_button4.TabStop = True
        Me.Rdo_button4.Text = "All Journals"
        Me.Rdo_button4.TextSource = ""
        Me.Rdo_button4.Uncheckable = False
        Me.Rdo_button4.UseVisualStyleBackColor = True
        Me.Rdo_button4.Value = "1"
        Me.Rdo_button4.ValueSource = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Journal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 15)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Book"
        '
        'allocation_filter
        '
        Me.allocation_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.allocation_filter.Controls.Add(Me.lbl_allocation_name)
        Me.allocation_filter.Controls.Add(Me.PictureBox7)
        Me.allocation_filter.Controls.Add(Me.txt_allocation_id)
        Me.allocation_filter.Controls.Add(Me.Rdo_button12)
        Me.allocation_filter.Controls.Add(Me.Rdo_button13)
        Me.allocation_filter.Controls.Add(Me.Label15)
        Me.allocation_filter.Location = New System.Drawing.Point(11, 258)
        Me.allocation_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.allocation_filter.Name = "allocation_filter"
        Me.allocation_filter.Size = New System.Drawing.Size(867, 28)
        Me.allocation_filter.TabIndex = 116
        '
        'lbl_allocation_name
        '
        Me.lbl_allocation_name.AutoSize = True
        Me.lbl_allocation_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_allocation_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_allocation_name.Location = New System.Drawing.Point(465, 5)
        Me.lbl_allocation_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_allocation_name.Name = "lbl_allocation_name"
        Me.lbl_allocation_name.Size = New System.Drawing.Size(97, 16)
        Me.lbl_allocation_name.TabIndex = 198
        Me.lbl_allocation_name.Text = "Allocation Name"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(445, 6)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 197
        Me.PictureBox7.TabStop = False
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
        Me.txt_allocation_id.ID = False
        Me.txt_allocation_id.Location = New System.Drawing.Point(337, 3)
        Me.txt_allocation_id.Name = "txt_allocation_id"
        Me.txt_allocation_id.NoClear = False
        Me.txt_allocation_id.NoSave = False
        Me.txt_allocation_id.NumberFormat = "@"
        Me.txt_allocation_id.Required = False
        Me.txt_allocation_id.RowData = Nothing
        Me.txt_allocation_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_allocation_id.TabIndex = 37
        Me.txt_allocation_id.TextBrowse = False
        Me.txt_allocation_id.TextSource = ""
        Me.txt_allocation_id.ToUpper = True
        Me.txt_allocation_id.Unique = False
        Me.txt_allocation_id.Value = ""
        Me.txt_allocation_id.ValueSource = ""
        '
        'Rdo_button12
        '
        Me.Rdo_button12.AutoSize = True
        Me.Rdo_button12.DataSource = ""
        Me.Rdo_button12.Location = New System.Drawing.Point(236, 5)
        Me.Rdo_button12.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button12.Name = "Rdo_button12"
        Me.Rdo_button12.Size = New System.Drawing.Size(96, 17)
        Me.Rdo_button12.TabIndex = 35
        Me.Rdo_button12.Text = "With Allocation"
        Me.Rdo_button12.TextSource = ""
        Me.Rdo_button12.Uncheckable = False
        Me.Rdo_button12.UseVisualStyleBackColor = True
        Me.Rdo_button12.Value = "2"
        Me.Rdo_button12.ValueSource = ""
        '
        'Rdo_button13
        '
        Me.Rdo_button13.AutoSize = True
        Me.Rdo_button13.Checked = True
        Me.Rdo_button13.DataSource = ""
        Me.Rdo_button13.Location = New System.Drawing.Point(124, 6)
        Me.Rdo_button13.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button13.Name = "Rdo_button13"
        Me.Rdo_button13.Size = New System.Drawing.Size(111, 17)
        Me.Rdo_button13.TabIndex = 31
        Me.Rdo_button13.TabStop = True
        Me.Rdo_button13.Text = "Without Allocation"
        Me.Rdo_button13.TextSource = ""
        Me.Rdo_button13.Uncheckable = False
        Me.Rdo_button13.UseVisualStyleBackColor = True
        Me.Rdo_button13.Value = "1"
        Me.Rdo_button13.ValueSource = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 15)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Allocation"
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AutoGenerateColumns = False
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransidDataGridViewTextBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.TransnoDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.AccountidDataGridViewTextBoxColumn, Me.AccountcodeDataGridViewTextBoxColumn, Me.AccountnameDataGridViewTextBoxColumn, Me.SinoDataGridViewTextBoxColumn, Me.RrnoDataGridViewTextBoxColumn, Me.PonoDataGridViewTextBoxColumn, Me.AccountmultipleidDataGridViewTextBoxColumn, Me.ProjectidDataGridViewTextBoxColumn, Me.DepartmentidDataGridViewTextBoxColumn, Me.ProjectcodeDataGridViewTextBoxColumn, Me.ProjectnameDataGridViewTextBoxColumn, Me.DepartmentcodeDataGridViewTextBoxColumn, Me.DepartmentnameDataGridViewTextBoxColumn, Me.CurrencyidDataGridViewTextBoxColumn, Me.CurrencynameDataGridViewTextBoxColumn, Me.GeneralmultipleidDataGridViewTextBoxColumn, Me.GeneralidDataGridViewTextBoxColumn, Me.GeneralnameDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.DebitbasedDataGridViewTextBoxColumn, Me.CreditbasedDataGridViewTextBoxColumn, Me.ExchangerateDataGridViewTextBoxColumn, Me.JournalidDataGridViewTextBoxColumn, Me.JournalnameDataGridViewTextBoxColumn, Me.MonthDataGridViewTextBoxColumn, Me.CharttypeDataGridViewTextBoxColumn, Me.DrnoDataGridViewTextBoxColumn, Me.ReftransnoDataGridViewTextBoxColumn, Me.TermsnameDataGridViewTextBoxColumn, Me.NodaysDataGridViewTextBoxColumn, Me.TransgeneralnameDataGridViewTextBoxColumn, Me.RefgeneralnameDataGridViewTextBoxColumn, Me.JournalcodeDataGridViewTextBoxColumn, Me.BookcodeDataGridViewTextBoxColumn, Me.BooknameDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.ChecknoDataGridViewTextBoxColumn, Me.CheckdateDataGridViewTextBoxColumn, Me.CompanynamesssDataGridViewTextBoxColumn})
        Me.dgMain.DataMember = "Account"
        Me.dgMain.DataSource = Me.dsko
        Me.dgMain.Location = New System.Drawing.Point(11, 322)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.ReadOnly = True
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.Size = New System.Drawing.Size(883, 204)
        Me.dgMain.TabIndex = 117
        '
        'TransidDataGridViewTextBoxColumn
        '
        Me.TransidDataGridViewTextBoxColumn.DataPropertyName = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.HeaderText = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.Name = "TransidDataGridViewTextBoxColumn"
        Me.TransidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransidDataGridViewTextBoxColumn.Visible = False
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date"
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "Trans Date"
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        Me.TransdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "Trans No."
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Particulars"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountidDataGridViewTextBoxColumn
        '
        Me.AccountidDataGridViewTextBoxColumn.DataPropertyName = "account_id"
        Me.AccountidDataGridViewTextBoxColumn.HeaderText = "account_id"
        Me.AccountidDataGridViewTextBoxColumn.Name = "AccountidDataGridViewTextBoxColumn"
        Me.AccountidDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountidDataGridViewTextBoxColumn.Visible = False
        '
        'AccountcodeDataGridViewTextBoxColumn
        '
        Me.AccountcodeDataGridViewTextBoxColumn.DataPropertyName = "account_code"
        Me.AccountcodeDataGridViewTextBoxColumn.HeaderText = "Account Code"
        Me.AccountcodeDataGridViewTextBoxColumn.Name = "AccountcodeDataGridViewTextBoxColumn"
        Me.AccountcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountnameDataGridViewTextBoxColumn
        '
        Me.AccountnameDataGridViewTextBoxColumn.DataPropertyName = "account_name"
        Me.AccountnameDataGridViewTextBoxColumn.HeaderText = "account_name"
        Me.AccountnameDataGridViewTextBoxColumn.Name = "AccountnameDataGridViewTextBoxColumn"
        Me.AccountnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountnameDataGridViewTextBoxColumn.Visible = False
        '
        'SinoDataGridViewTextBoxColumn
        '
        Me.SinoDataGridViewTextBoxColumn.DataPropertyName = "si_no"
        Me.SinoDataGridViewTextBoxColumn.HeaderText = "si_no"
        Me.SinoDataGridViewTextBoxColumn.Name = "SinoDataGridViewTextBoxColumn"
        Me.SinoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SinoDataGridViewTextBoxColumn.Visible = False
        '
        'RrnoDataGridViewTextBoxColumn
        '
        Me.RrnoDataGridViewTextBoxColumn.DataPropertyName = "rr_no"
        Me.RrnoDataGridViewTextBoxColumn.HeaderText = "rr_no"
        Me.RrnoDataGridViewTextBoxColumn.Name = "RrnoDataGridViewTextBoxColumn"
        Me.RrnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RrnoDataGridViewTextBoxColumn.Visible = False
        '
        'PonoDataGridViewTextBoxColumn
        '
        Me.PonoDataGridViewTextBoxColumn.DataPropertyName = "po_no"
        Me.PonoDataGridViewTextBoxColumn.HeaderText = "po_no"
        Me.PonoDataGridViewTextBoxColumn.Name = "PonoDataGridViewTextBoxColumn"
        Me.PonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PonoDataGridViewTextBoxColumn.Visible = False
        '
        'AccountmultipleidDataGridViewTextBoxColumn
        '
        Me.AccountmultipleidDataGridViewTextBoxColumn.DataPropertyName = "account_multiple_id"
        Me.AccountmultipleidDataGridViewTextBoxColumn.HeaderText = "account_multiple_id"
        Me.AccountmultipleidDataGridViewTextBoxColumn.Name = "AccountmultipleidDataGridViewTextBoxColumn"
        Me.AccountmultipleidDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountmultipleidDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectidDataGridViewTextBoxColumn
        '
        Me.ProjectidDataGridViewTextBoxColumn.DataPropertyName = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn.HeaderText = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn.Name = "ProjectidDataGridViewTextBoxColumn"
        Me.ProjectidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProjectidDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentidDataGridViewTextBoxColumn
        '
        Me.DepartmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id"
        Me.DepartmentidDataGridViewTextBoxColumn.HeaderText = "department_id"
        Me.DepartmentidDataGridViewTextBoxColumn.Name = "DepartmentidDataGridViewTextBoxColumn"
        Me.DepartmentidDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentidDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectcodeDataGridViewTextBoxColumn
        '
        Me.ProjectcodeDataGridViewTextBoxColumn.DataPropertyName = "project_code"
        Me.ProjectcodeDataGridViewTextBoxColumn.HeaderText = "project_code"
        Me.ProjectcodeDataGridViewTextBoxColumn.Name = "ProjectcodeDataGridViewTextBoxColumn"
        Me.ProjectcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProjectcodeDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectnameDataGridViewTextBoxColumn
        '
        Me.ProjectnameDataGridViewTextBoxColumn.DataPropertyName = "project_name"
        Me.ProjectnameDataGridViewTextBoxColumn.HeaderText = "project_name"
        Me.ProjectnameDataGridViewTextBoxColumn.Name = "ProjectnameDataGridViewTextBoxColumn"
        Me.ProjectnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProjectnameDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentcodeDataGridViewTextBoxColumn
        '
        Me.DepartmentcodeDataGridViewTextBoxColumn.DataPropertyName = "department_code"
        Me.DepartmentcodeDataGridViewTextBoxColumn.HeaderText = "department_code"
        Me.DepartmentcodeDataGridViewTextBoxColumn.Name = "DepartmentcodeDataGridViewTextBoxColumn"
        Me.DepartmentcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentcodeDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentnameDataGridViewTextBoxColumn
        '
        Me.DepartmentnameDataGridViewTextBoxColumn.DataPropertyName = "department_name"
        Me.DepartmentnameDataGridViewTextBoxColumn.HeaderText = "department_name"
        Me.DepartmentnameDataGridViewTextBoxColumn.Name = "DepartmentnameDataGridViewTextBoxColumn"
        Me.DepartmentnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentnameDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencyidDataGridViewTextBoxColumn
        '
        Me.CurrencyidDataGridViewTextBoxColumn.DataPropertyName = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.HeaderText = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.Name = "CurrencyidDataGridViewTextBoxColumn"
        Me.CurrencyidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CurrencyidDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencynameDataGridViewTextBoxColumn
        '
        Me.CurrencynameDataGridViewTextBoxColumn.DataPropertyName = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CurrencynameDataGridViewTextBoxColumn.Name = "CurrencynameDataGridViewTextBoxColumn"
        Me.CurrencynameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeneralmultipleidDataGridViewTextBoxColumn
        '
        Me.GeneralmultipleidDataGridViewTextBoxColumn.DataPropertyName = "general_multiple_id"
        Me.GeneralmultipleidDataGridViewTextBoxColumn.HeaderText = "general_multiple_id"
        Me.GeneralmultipleidDataGridViewTextBoxColumn.Name = "GeneralmultipleidDataGridViewTextBoxColumn"
        Me.GeneralmultipleidDataGridViewTextBoxColumn.ReadOnly = True
        Me.GeneralmultipleidDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralidDataGridViewTextBoxColumn
        '
        Me.GeneralidDataGridViewTextBoxColumn.DataPropertyName = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.HeaderText = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.Name = "GeneralidDataGridViewTextBoxColumn"
        Me.GeneralidDataGridViewTextBoxColumn.ReadOnly = True
        Me.GeneralidDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralnameDataGridViewTextBoxColumn
        '
        Me.GeneralnameDataGridViewTextBoxColumn.DataPropertyName = "general_name"
        Me.GeneralnameDataGridViewTextBoxColumn.HeaderText = "General Name"
        Me.GeneralnameDataGridViewTextBoxColumn.Name = "GeneralnameDataGridViewTextBoxColumn"
        Me.GeneralnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "debit"
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "Debit"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        Me.DebitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebitbasedDataGridViewTextBoxColumn
        '
        Me.DebitbasedDataGridViewTextBoxColumn.DataPropertyName = "debit_based"
        Me.DebitbasedDataGridViewTextBoxColumn.HeaderText = "Debit Based"
        Me.DebitbasedDataGridViewTextBoxColumn.Name = "DebitbasedDataGridViewTextBoxColumn"
        Me.DebitbasedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreditbasedDataGridViewTextBoxColumn
        '
        Me.CreditbasedDataGridViewTextBoxColumn.DataPropertyName = "credit_based"
        Me.CreditbasedDataGridViewTextBoxColumn.HeaderText = "Credit Based"
        Me.CreditbasedDataGridViewTextBoxColumn.Name = "CreditbasedDataGridViewTextBoxColumn"
        Me.CreditbasedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExchangerateDataGridViewTextBoxColumn
        '
        Me.ExchangerateDataGridViewTextBoxColumn.DataPropertyName = "exchange_rate"
        Me.ExchangerateDataGridViewTextBoxColumn.HeaderText = "exchange_rate"
        Me.ExchangerateDataGridViewTextBoxColumn.Name = "ExchangerateDataGridViewTextBoxColumn"
        Me.ExchangerateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExchangerateDataGridViewTextBoxColumn.Visible = False
        '
        'JournalidDataGridViewTextBoxColumn
        '
        Me.JournalidDataGridViewTextBoxColumn.DataPropertyName = "journal_id"
        Me.JournalidDataGridViewTextBoxColumn.HeaderText = "journal_id"
        Me.JournalidDataGridViewTextBoxColumn.Name = "JournalidDataGridViewTextBoxColumn"
        Me.JournalidDataGridViewTextBoxColumn.ReadOnly = True
        Me.JournalidDataGridViewTextBoxColumn.Visible = False
        '
        'JournalnameDataGridViewTextBoxColumn
        '
        Me.JournalnameDataGridViewTextBoxColumn.DataPropertyName = "journal_name"
        Me.JournalnameDataGridViewTextBoxColumn.HeaderText = "journal_name"
        Me.JournalnameDataGridViewTextBoxColumn.Name = "JournalnameDataGridViewTextBoxColumn"
        Me.JournalnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.JournalnameDataGridViewTextBoxColumn.Visible = False
        '
        'MonthDataGridViewTextBoxColumn
        '
        Me.MonthDataGridViewTextBoxColumn.DataPropertyName = "month"
        Me.MonthDataGridViewTextBoxColumn.HeaderText = "month"
        Me.MonthDataGridViewTextBoxColumn.Name = "MonthDataGridViewTextBoxColumn"
        Me.MonthDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonthDataGridViewTextBoxColumn.Visible = False
        '
        'CharttypeDataGridViewTextBoxColumn
        '
        Me.CharttypeDataGridViewTextBoxColumn.DataPropertyName = "chart_type"
        Me.CharttypeDataGridViewTextBoxColumn.HeaderText = "chart_type"
        Me.CharttypeDataGridViewTextBoxColumn.Name = "CharttypeDataGridViewTextBoxColumn"
        Me.CharttypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CharttypeDataGridViewTextBoxColumn.Visible = False
        '
        'DrnoDataGridViewTextBoxColumn
        '
        Me.DrnoDataGridViewTextBoxColumn.DataPropertyName = "dr_no"
        Me.DrnoDataGridViewTextBoxColumn.HeaderText = "dr_no"
        Me.DrnoDataGridViewTextBoxColumn.Name = "DrnoDataGridViewTextBoxColumn"
        Me.DrnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DrnoDataGridViewTextBoxColumn.Visible = False
        '
        'ReftransnoDataGridViewTextBoxColumn
        '
        Me.ReftransnoDataGridViewTextBoxColumn.DataPropertyName = "ref_trans_no"
        Me.ReftransnoDataGridViewTextBoxColumn.HeaderText = "ref_trans_no"
        Me.ReftransnoDataGridViewTextBoxColumn.Name = "ReftransnoDataGridViewTextBoxColumn"
        Me.ReftransnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReftransnoDataGridViewTextBoxColumn.Visible = False
        '
        'TermsnameDataGridViewTextBoxColumn
        '
        Me.TermsnameDataGridViewTextBoxColumn.DataPropertyName = "terms_name"
        Me.TermsnameDataGridViewTextBoxColumn.HeaderText = "terms_name"
        Me.TermsnameDataGridViewTextBoxColumn.Name = "TermsnameDataGridViewTextBoxColumn"
        Me.TermsnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.TermsnameDataGridViewTextBoxColumn.Visible = False
        '
        'NodaysDataGridViewTextBoxColumn
        '
        Me.NodaysDataGridViewTextBoxColumn.DataPropertyName = "nodays"
        Me.NodaysDataGridViewTextBoxColumn.HeaderText = "nodays"
        Me.NodaysDataGridViewTextBoxColumn.Name = "NodaysDataGridViewTextBoxColumn"
        Me.NodaysDataGridViewTextBoxColumn.ReadOnly = True
        Me.NodaysDataGridViewTextBoxColumn.Visible = False
        '
        'TransgeneralnameDataGridViewTextBoxColumn
        '
        Me.TransgeneralnameDataGridViewTextBoxColumn.DataPropertyName = "trans_general_name"
        Me.TransgeneralnameDataGridViewTextBoxColumn.HeaderText = "trans_general_name"
        Me.TransgeneralnameDataGridViewTextBoxColumn.Name = "TransgeneralnameDataGridViewTextBoxColumn"
        Me.TransgeneralnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransgeneralnameDataGridViewTextBoxColumn.Visible = False
        '
        'RefgeneralnameDataGridViewTextBoxColumn
        '
        Me.RefgeneralnameDataGridViewTextBoxColumn.DataPropertyName = "ref_general_name"
        Me.RefgeneralnameDataGridViewTextBoxColumn.HeaderText = "ref_general_name"
        Me.RefgeneralnameDataGridViewTextBoxColumn.Name = "RefgeneralnameDataGridViewTextBoxColumn"
        Me.RefgeneralnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.RefgeneralnameDataGridViewTextBoxColumn.Visible = False
        '
        'JournalcodeDataGridViewTextBoxColumn
        '
        Me.JournalcodeDataGridViewTextBoxColumn.DataPropertyName = "journal_code"
        Me.JournalcodeDataGridViewTextBoxColumn.HeaderText = "Journal"
        Me.JournalcodeDataGridViewTextBoxColumn.Name = "JournalcodeDataGridViewTextBoxColumn"
        Me.JournalcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookcodeDataGridViewTextBoxColumn
        '
        Me.BookcodeDataGridViewTextBoxColumn.DataPropertyName = "book_code"
        Me.BookcodeDataGridViewTextBoxColumn.HeaderText = "Book"
        Me.BookcodeDataGridViewTextBoxColumn.Name = "BookcodeDataGridViewTextBoxColumn"
        Me.BookcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BooknameDataGridViewTextBoxColumn
        '
        Me.BooknameDataGridViewTextBoxColumn.DataPropertyName = "book_name"
        Me.BooknameDataGridViewTextBoxColumn.HeaderText = "book_name"
        Me.BooknameDataGridViewTextBoxColumn.Name = "BooknameDataGridViewTextBoxColumn"
        Me.BooknameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BooknameDataGridViewTextBoxColumn.Visible = False
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.BalanceDataGridViewTextBoxColumn.Visible = False
        '
        'ChecknoDataGridViewTextBoxColumn
        '
        Me.ChecknoDataGridViewTextBoxColumn.DataPropertyName = "check_no"
        Me.ChecknoDataGridViewTextBoxColumn.HeaderText = "check_no"
        Me.ChecknoDataGridViewTextBoxColumn.Name = "ChecknoDataGridViewTextBoxColumn"
        Me.ChecknoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChecknoDataGridViewTextBoxColumn.Visible = False
        '
        'CheckdateDataGridViewTextBoxColumn
        '
        Me.CheckdateDataGridViewTextBoxColumn.DataPropertyName = "check_date"
        Me.CheckdateDataGridViewTextBoxColumn.HeaderText = "check_date"
        Me.CheckdateDataGridViewTextBoxColumn.Name = "CheckdateDataGridViewTextBoxColumn"
        Me.CheckdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.CheckdateDataGridViewTextBoxColumn.Visible = False
        '
        'CompanynamesssDataGridViewTextBoxColumn
        '
        Me.CompanynamesssDataGridViewTextBoxColumn.DataPropertyName = "company_namesss"
        Me.CompanynamesssDataGridViewTextBoxColumn.HeaderText = "company_namesss"
        Me.CompanynamesssDataGridViewTextBoxColumn.Name = "CompanynamesssDataGridViewTextBoxColumn"
        Me.CompanynamesssDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompanynamesssDataGridViewTextBoxColumn.Visible = False
        '
        'dsko
        '
        Me.dsko.DataSetName = "dsko"
        Me.dsko.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_chart, Me.company})
        '
        'lib_erp_chart
        '
        Me.lib_erp_chart.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn6, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn23, Me.DataColumn26, Me.DataColumn29, Me.DataColumn32, Me.DataColumn35, Me.DataColumn36})
        Me.lib_erp_chart.TableName = "lib_erp_chart"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "account_code"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "balance"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "debit"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "credit"
        Me.DataColumn9.DataType = GetType(Decimal)
        Me.DataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "debit_based"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "credit_based"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "balance_based"
        Me.DataColumn12.DataType = GetType(Decimal)
        Me.DataColumn12.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "currency_code"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "journal_code"
        Me.DataColumn26.DefaultValue = ""
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "book_code"
        Me.DataColumn29.DefaultValue = ""
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "general_code"
        Me.DataColumn32.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "trans_no"
        Me.DataColumn35.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "trans_date"
        Me.DataColumn36.DataType = GetType(Date)
        '
        'company
        '
        Me.company.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40})
        Me.company.TableName = "company"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "address"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "company_name"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "Column3"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "Column4"
        '
        'btnPrintOption
        '
        Me.btnPrintOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrintOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrintOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrintOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintOption.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(420, 533)
        Me.btnPrintOption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 219
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(340, 533)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 218
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        Me.btnExcel.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(499, 533)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 217
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'general_filter
        '
        Me.general_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.general_filter.Controls.Add(Me.lbl_account_name)
        Me.general_filter.Controls.Add(Me.PictureBox1)
        Me.general_filter.Controls.Add(Me.txt_general_id)
        Me.general_filter.Controls.Add(Me.btn_browse_general)
        Me.general_filter.Controls.Add(Me.Rdo_button3)
        Me.general_filter.Controls.Add(Me.Label6)
        Me.general_filter.Controls.Add(Me.Rdo_button1)
        Me.general_filter.Controls.Add(Me.Rdo_button2)
        Me.general_filter.Location = New System.Drawing.Point(11, 115)
        Me.general_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.general_filter.Name = "general_filter"
        Me.general_filter.Size = New System.Drawing.Size(867, 28)
        Me.general_filter.TabIndex = 112
        '
        'lbl_account_name
        '
        Me.lbl_account_name.AutoSize = True
        Me.lbl_account_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_account_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_account_name.Location = New System.Drawing.Point(551, 5)
        Me.lbl_account_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_account_name.Name = "lbl_account_name"
        Me.lbl_account_name.Size = New System.Drawing.Size(90, 16)
        Me.lbl_account_name.TabIndex = 223
        Me.lbl_account_name.Text = "General Library"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(531, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 222
        Me.PictureBox1.TabStop = False
        '
        'txt_general_id
        '
        Me.txt_general_id.AlwaysDisable = False
        Me.txt_general_id.AlwaysEnable = False
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
        Me.txt_general_id.Location = New System.Drawing.Point(420, 3)
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NoSave = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_general_id.TabIndex = 31
        Me.txt_general_id.TextBrowse = False
        Me.txt_general_id.TextSource = ""
        Me.txt_general_id.ToUpper = True
        Me.txt_general_id.Unique = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = ""
        '
        'btn_browse_general
        '
        Me.btn_browse_general.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_browse_general.ButtonType = user_control.MyList.ButtonType.ButtonAdd
        Me.btn_browse_general.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_browse_general.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btn_browse_general.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse_general.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_browse_general.ForeColor = System.Drawing.Color.White
        Me.btn_browse_general.Location = New System.Drawing.Point(302, 4)
        Me.btn_browse_general.Name = "btn_browse_general"
        Me.btn_browse_general.Size = New System.Drawing.Size(35, 20)
        Me.btn_browse_general.TabIndex = 30
        Me.btn_browse_general.Text = "..."
        Me.btn_browse_general.UseVisualStyleBackColor = False
        '
        'Rdo_button3
        '
        Me.Rdo_button3.AutoSize = True
        Me.Rdo_button3.DataSource = ""
        Me.Rdo_button3.Location = New System.Drawing.Point(352, 5)
        Me.Rdo_button3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button3.Name = "Rdo_button3"
        Me.Rdo_button3.Size = New System.Drawing.Size(63, 17)
        Me.Rdo_button3.TabIndex = 28
        Me.Rdo_button3.Text = "Specific"
        Me.Rdo_button3.TextSource = ""
        Me.Rdo_button3.Uncheckable = False
        Me.Rdo_button3.UseVisualStyleBackColor = True
        Me.Rdo_button3.Value = "3"
        Me.Rdo_button3.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "General Library"
        '
        'Rdo_button1
        '
        Me.Rdo_button1.AutoSize = True
        Me.Rdo_button1.DataSource = ""
        Me.Rdo_button1.Location = New System.Drawing.Point(236, 5)
        Me.Rdo_button1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button1.Name = "Rdo_button1"
        Me.Rdo_button1.Size = New System.Drawing.Size(61, 17)
        Me.Rdo_button1.TabIndex = 3
        Me.Rdo_button1.Text = "Multiple"
        Me.Rdo_button1.TextSource = ""
        Me.Rdo_button1.Uncheckable = False
        Me.Rdo_button1.UseVisualStyleBackColor = True
        Me.Rdo_button1.Value = "2"
        Me.Rdo_button1.ValueSource = ""
        '
        'Rdo_button2
        '
        Me.Rdo_button2.AutoSize = True
        Me.Rdo_button2.Checked = True
        Me.Rdo_button2.DataSource = ""
        Me.Rdo_button2.Location = New System.Drawing.Point(124, 6)
        Me.Rdo_button2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button2.Name = "Rdo_button2"
        Me.Rdo_button2.Size = New System.Drawing.Size(36, 17)
        Me.Rdo_button2.TabIndex = 2
        Me.Rdo_button2.TabStop = True
        Me.Rdo_button2.Text = "All"
        Me.Rdo_button2.TextSource = ""
        Me.Rdo_button2.Uncheckable = False
        Me.Rdo_button2.UseVisualStyleBackColor = True
        Me.Rdo_button2.Value = "1"
        Me.Rdo_button2.ValueSource = ""
        '
        'book_filter
        '
        Me.book_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.book_filter.Controls.Add(Me.txt_book_id)
        Me.book_filter.Controls.Add(Me.Label12)
        Me.book_filter.Controls.Add(Me.Rdo_button8)
        Me.book_filter.Controls.Add(Me.Rdo_button9)
        Me.book_filter.Location = New System.Drawing.Point(458, 222)
        Me.book_filter.Name = "book_filter"
        Me.book_filter.Size = New System.Drawing.Size(420, 28)
        Me.book_filter.TabIndex = 220
        '
        'txt_book_id
        '
        Me.txt_book_id.AlwaysDisable = False
        Me.txt_book_id.AlwaysEnable = False
        Me.txt_book_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_id.BrowseDataSource = ""
        Me.txt_book_id.BrowseField = ""
        Me.txt_book_id.BrowseFilter = Nothing
        Me.txt_book_id.BrowseLabel = "Code,Name"
        Me.txt_book_id.BrowseLabelWidth = "100,200"
        Me.txt_book_id.BrowseTextSource = ""
        Me.txt_book_id.BrowseValueSource = ""
        Me.txt_book_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_book_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_id.Enabled = False
        Me.txt_book_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_book_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_book_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_id.ID = False
        Me.txt_book_id.Location = New System.Drawing.Point(203, 3)
        Me.txt_book_id.Name = "txt_book_id"
        Me.txt_book_id.NoClear = False
        Me.txt_book_id.NoSave = False
        Me.txt_book_id.NumberFormat = "@"
        Me.txt_book_id.Required = False
        Me.txt_book_id.RowData = Nothing
        Me.txt_book_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_book_id.TabIndex = 39
        Me.txt_book_id.TextBrowse = False
        Me.txt_book_id.TextSource = ""
        Me.txt_book_id.ToUpper = True
        Me.txt_book_id.Unique = False
        Me.txt_book_id.Value = ""
        Me.txt_book_id.ValueSource = ""
        '
        'Rdo_button8
        '
        Me.Rdo_button8.AutoSize = True
        Me.Rdo_button8.Checked = True
        Me.Rdo_button8.DataSource = ""
        Me.Rdo_button8.Location = New System.Drawing.Point(56, 6)
        Me.Rdo_button8.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button8.Name = "Rdo_button8"
        Me.Rdo_button8.Size = New System.Drawing.Size(69, 17)
        Me.Rdo_button8.TabIndex = 37
        Me.Rdo_button8.TabStop = True
        Me.Rdo_button8.Text = "All Books"
        Me.Rdo_button8.TextSource = ""
        Me.Rdo_button8.Uncheckable = False
        Me.Rdo_button8.UseVisualStyleBackColor = True
        Me.Rdo_button8.Value = "1"
        Me.Rdo_button8.ValueSource = ""
        '
        'Rdo_button9
        '
        Me.Rdo_button9.AutoSize = True
        Me.Rdo_button9.DataSource = ""
        Me.Rdo_button9.Location = New System.Drawing.Point(129, 6)
        Me.Rdo_button9.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Rdo_button9.Name = "Rdo_button9"
        Me.Rdo_button9.Size = New System.Drawing.Size(69, 17)
        Me.Rdo_button9.TabIndex = 38
        Me.Rdo_button9.Text = "Per Book"
        Me.Rdo_button9.TextSource = ""
        Me.Rdo_button9.Uncheckable = False
        Me.Rdo_button9.UseVisualStyleBackColor = True
        Me.Rdo_button9.Value = "2"
        Me.Rdo_button9.ValueSource = ""
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(420, 533)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 221
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btn_filter
        '
        Me.btn_filter.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_filter.ButtonType = user_control.MyList.ButtonType.ButtonAdd
        Me.btn_filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filter.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_filter.ForeColor = System.Drawing.Color.White
        Me.btn_filter.Location = New System.Drawing.Point(12, 293)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(82, 23)
        Me.btn_filter.TabIndex = 32
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.UseVisualStyleBackColor = False
        '
        'AccountInquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 593)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.book_filter)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.allocation_filter)
        Me.Controls.Add(Me.journal_filter)
        Me.Controls.Add(Me.project_department_filter)
        Me.Controls.Add(Me.currency_filter)
        Me.Controls.Add(Me.general_filter)
        Me.Controls.Add(Me.range_filter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "AccountInquiry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        Me.currency_filter.ResumeLayout(False)
        Me.currency_filter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_department_filter.ResumeLayout(False)
        Me.project_department_filter.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.journal_filter.ResumeLayout(False)
        Me.journal_filter.PerformLayout()
        Me.allocation_filter.ResumeLayout(False)
        Me.allocation_filter.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsko, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.company, System.ComponentModel.ISupportInitialize).EndInit()
        Me.general_filter.ResumeLayout(False)
        Me.general_filter.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.book_filter.ResumeLayout(False)
        Me.book_filter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents range_filter As Windows.Forms.Panel
    Friend WithEvents rdo3 As user_control.rdo_button
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txt_date_to As Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_date_from As Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents currency_filter As Windows.Forms.Panel
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Rdo_button5 As user_control.rdo_button
    Friend WithEvents Rdo_button6 As user_control.rdo_button
    Friend WithEvents withComparison As user_control.MyCheckBox
    Friend WithEvents project_department_filter As Windows.Forms.Panel
    Friend WithEvents MyCheckBox1 As user_control.MyCheckBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents journal_filter As Windows.Forms.Panel
    Friend WithEvents Rdo_button9 As user_control.rdo_button
    Friend WithEvents Rdo_button8 As user_control.rdo_button
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Rdo_button7 As user_control.rdo_button
    Friend WithEvents Rdo_button4 As user_control.rdo_button
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents allocation_filter As Windows.Forms.Panel
    Friend WithEvents Rdo_button12 As user_control.rdo_button
    Friend WithEvents Rdo_button13 As user_control.rdo_button
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents dgMain As Windows.Forms.DataGridView
    Friend WithEvents btnPrintOption As Windows.Forms.Button
    Friend WithEvents btnExcel As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents general_filter As Windows.Forms.Panel
    Friend WithEvents Rdo_button3 As user_control.rdo_button
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Rdo_button1 As user_control.rdo_button
    Friend WithEvents Rdo_button2 As user_control.rdo_button
    Friend WithEvents btn_browse_general As user_control.MyButton
    Friend WithEvents book_filter As Windows.Forms.Panel
    Friend WithEvents txt_general_id As user_control.MyTextBox
    Friend WithEvents txt_currency_id As user_control.MyTextBox
    Friend WithEvents txt_department_id As user_control.MyTextBox
    Friend WithEvents txt_project_id As user_control.MyTextBox
    Friend WithEvents txt_journal_id As user_control.MyTextBox
    Friend WithEvents txt_book_id As user_control.MyTextBox
    Friend WithEvents txt_allocation_id As user_control.MyTextBox
    Friend WithEvents btnPrint As Windows.Forms.Button
    Friend WithEvents lbl_account_name As Windows.Forms.Label
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents lbl_currency_name As Windows.Forms.Label
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents lbl_allocation_name As Windows.Forms.Label
    Friend WithEvents PictureBox7 As Windows.Forms.PictureBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents PictureBox4 As Windows.Forms.PictureBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents PictureBox3 As Windows.Forms.PictureBox
    Friend WithEvents btn_filter As user_control.MyButton
    Friend WithEvents dsko As accountanalysis_set
    Friend WithEvents DataColumn40 As DataColumn
    Friend WithEvents DataColumn39 As DataColumn
    Friend WithEvents DataColumn38 As DataColumn
    Friend WithEvents DataColumn37 As DataColumn
    Friend WithEvents company As DataTable
    Friend WithEvents DataColumn36 As DataColumn
    Friend WithEvents DataColumn35 As DataColumn
    Friend WithEvents DataColumn32 As DataColumn
    Friend WithEvents DataColumn29 As DataColumn
    Friend WithEvents DataColumn26 As DataColumn
    Friend WithEvents DataColumn23 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents lib_erp_chart As DataTable
    Friend WithEvents ds As DataSet
    Friend WithEvents TransidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SinoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RrnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PonoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountmultipleidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencynameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralmultipleidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExchangerateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JournalidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JournalnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharttypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReftransnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermsnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NodaysDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransgeneralnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefgeneralnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JournalcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BooknameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChecknoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanynamesssDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
End Class
