<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arsubsidiary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(arsubsidiary))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.range_filter = New System.Windows.Forms.Panel()
        Me.rdo3 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.rdo2 = New user_control.rdo_button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.printoption = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_general_id = New user_control.textbox()
        Me.rdo_general_1 = New user_control.rdo_button()
        Me.rdo_general_3 = New user_control.rdo_button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_general_name = New System.Windows.Forms.Label()
        Me.btnImportGeneral = New System.Windows.Forms.Button()
        Me.rdo_general_2 = New user_control.rdo_button()
        Me.general_filter = New System.Windows.Forms.GroupBox()
        Me.rdo_currency_1 = New user_control.rdo_button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_currency_id = New user_control.textbox()
        Me.rdo_currency_2 = New user_control.rdo_button()
        Me.lbl_currency_name = New System.Windows.Forms.Label()
        Me.withComparison = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.currency_filter = New System.Windows.Forms.GroupBox()
        Me.txt_project_id = New user_control.textbox()
        Me.txt_department_id = New user_control.textbox()
        Me.withProjectDepartment = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbl_project_name = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbl_department_name = New System.Windows.Forms.Label()
        Me.project_department_filter = New System.Windows.Forms.GroupBox()
        Me.txt_account_id = New user_control.textbox()
        Me.rdo_account_1 = New user_control.rdo_button()
        Me.rdo_account_3 = New user_control.rdo_button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_account_name = New System.Windows.Forms.Label()
        Me.btnImportAccount = New System.Windows.Forms.Button()
        Me.rdo_account_2 = New user_control.rdo_button()
        Me.account_filter = New System.Windows.Forms.GroupBox()
        Me.groupByUnit = New System.Windows.Forms.CheckBox()
        Me.NoRunningBalance = New System.Windows.Forms.CheckBox()
        Me.tabSeparated = New System.Windows.Forms.CheckBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.groupByBook = New System.Windows.Forms.CheckBox()
        Me.checkAllBooks = New System.Windows.Forms.CheckBox()
        Me.dgBooks = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgBookUnits = New System.Windows.Forms.DataGridView()
        Me.sel2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_unit_no_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_unit_no_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkAllBookUnits = New System.Windows.Forms.CheckBox()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.range_filter.SuspendLayout()
        Me.printoption.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.general_filter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.currency_filter.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_department_filter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.account_filter.SuspendLayout()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBookUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(402, 398)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'range_filter
        '
        Me.range_filter.Controls.Add(Me.rdo3)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.range_filter.Location = New System.Drawing.Point(571, 66)
        Me.range_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(218, 82)
        Me.range_filter.TabIndex = 24
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.DataSource = ""
        Me.rdo3.Location = New System.Drawing.Point(25, 58)
        Me.rdo3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(168, 17)
        Me.rdo3.TabIndex = 2
        Me.rdo3.Text = "Range with Beginning Balance"
        Me.rdo3.TextSource = ""
        Me.rdo3.Uncheckable = False
        Me.rdo3.UseVisualStyleBackColor = True
        Me.rdo3.Value = "3"
        Me.rdo3.ValueSource = ""
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Checked = True
        Me.rdo1.DataSource = ""
        Me.rdo1.Location = New System.Drawing.Point(25, 8)
        Me.rdo1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(81, 17)
        Me.rdo1.TabIndex = 0
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Range Only"
        Me.rdo1.TextSource = ""
        Me.rdo1.Uncheckable = False
        Me.rdo1.UseVisualStyleBackColor = True
        Me.rdo1.Value = "1"
        Me.rdo1.ValueSource = ""
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.DataSource = ""
        Me.rdo2.Location = New System.Drawing.Point(25, 33)
        Me.rdo2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(100, 17)
        Me.rdo2.TabIndex = 1
        Me.rdo2.Text = "To Date / As Of"
        Me.rdo2.TextSource = ""
        Me.rdo2.Uncheckable = False
        Me.rdo2.UseVisualStyleBackColor = True
        Me.rdo2.Value = "2"
        Me.rdo2.ValueSource = ""
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(589, 417)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 10)
        Me.btnPrint.TabIndex = 33
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(84, 28)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(110, 20)
        Me.txt_date_to.TabIndex = 194
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "Date To"
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(84, 7)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(110, 20)
        Me.txt_date_from.TabIndex = 192
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 10)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "Date From"
        '
        'printoption
        '
        Me.printoption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.printoption.Controls.Add(Me.txt_date_from)
        Me.printoption.Controls.Add(Me.Label14)
        Me.printoption.Controls.Add(Me.Label13)
        Me.printoption.Controls.Add(Me.txt_date_to)
        Me.printoption.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.printoption.Location = New System.Drawing.Point(571, 149)
        Me.printoption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.printoption.Name = "printoption"
        Me.printoption.Size = New System.Drawing.Size(218, 56)
        Me.printoption.TabIndex = 203
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 24)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "Subsidiary Ledger of Receivable Accounts"
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
        'rdo_general_1
        '
        Me.rdo_general_1.AutoSize = True
        Me.rdo_general_1.Checked = True
        Me.rdo_general_1.DataSource = ""
        Me.rdo_general_1.Location = New System.Drawing.Point(7, 18)
        Me.rdo_general_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
        'rdo_general_3
        '
        Me.rdo_general_3.AutoSize = True
        Me.rdo_general_3.DataSource = ""
        Me.rdo_general_3.Location = New System.Drawing.Point(7, 41)
        Me.rdo_general_3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(176, 43)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 191
        Me.PictureBox3.TabStop = False
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
        'rdo_general_2
        '
        Me.rdo_general_2.AutoSize = True
        Me.rdo_general_2.DataSource = ""
        Me.rdo_general_2.Location = New System.Drawing.Point(72, 18)
        Me.rdo_general_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
        'general_filter
        '
        Me.general_filter.Controls.Add(Me.rdo_general_2)
        Me.general_filter.Controls.Add(Me.btnImportGeneral)
        Me.general_filter.Controls.Add(Me.lbl_general_name)
        Me.general_filter.Controls.Add(Me.PictureBox3)
        Me.general_filter.Controls.Add(Me.rdo_general_3)
        Me.general_filter.Controls.Add(Me.rdo_general_1)
        Me.general_filter.Controls.Add(Me.txt_general_id)
        Me.general_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.general_filter.Location = New System.Drawing.Point(11, 144)
        Me.general_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.general_filter.Name = "general_filter"
        Me.general_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.general_filter.Size = New System.Drawing.Size(556, 70)
        Me.general_filter.TabIndex = 212
        Me.general_filter.TabStop = False
        Me.general_filter.Text = "General Library"
        '
        'rdo_currency_1
        '
        Me.rdo_currency_1.AutoSize = True
        Me.rdo_currency_1.Checked = True
        Me.rdo_currency_1.DataSource = ""
        Me.rdo_currency_1.Location = New System.Drawing.Point(40, 20)
        Me.rdo_currency_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 43)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 187
        Me.PictureBox2.TabStop = False
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
        Me.txt_currency_id.Location = New System.Drawing.Point(72, 41)
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
        'rdo_currency_2
        '
        Me.rdo_currency_2.AutoSize = True
        Me.rdo_currency_2.DataSource = ""
        Me.rdo_currency_2.Location = New System.Drawing.Point(155, 20)
        Me.rdo_currency_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
        'withComparison
        '
        Me.withComparison.AutoSize = True
        Me.withComparison.Location = New System.Drawing.Point(267, 21)
        Me.withComparison.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.withComparison.Name = "withComparison"
        Me.withComparison.Size = New System.Drawing.Size(107, 17)
        Me.withComparison.TabIndex = 18
        Me.withComparison.Text = "With Comparison"
        Me.withComparison.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Currency"
        '
        'currency_filter
        '
        Me.currency_filter.Controls.Add(Me.Label3)
        Me.currency_filter.Controls.Add(Me.withComparison)
        Me.currency_filter.Controls.Add(Me.lbl_currency_name)
        Me.currency_filter.Controls.Add(Me.rdo_currency_2)
        Me.currency_filter.Controls.Add(Me.txt_currency_id)
        Me.currency_filter.Controls.Add(Me.PictureBox2)
        Me.currency_filter.Controls.Add(Me.rdo_currency_1)
        Me.currency_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.currency_filter.Location = New System.Drawing.Point(11, 222)
        Me.currency_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Name = "currency_filter"
        Me.currency_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Size = New System.Drawing.Size(556, 70)
        Me.currency_filter.TabIndex = 213
        Me.currency_filter.TabStop = False
        Me.currency_filter.Text = "Currency"
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
        'withProjectDepartment
        '
        Me.withProjectDepartment.AutoSize = True
        Me.withProjectDepartment.Location = New System.Drawing.Point(72, 19)
        Me.withProjectDepartment.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.withProjectDepartment.Name = "withProjectDepartment"
        Me.withProjectDepartment.Size = New System.Drawing.Size(152, 17)
        Me.withProjectDepartment.TabIndex = 20
        Me.withProjectDepartment.Text = "With Project / Department"
        Me.withProjectDepartment.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 65)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Department"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Project"
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
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(176, 65)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 193
        Me.PictureBox5.TabStop = False
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
        Me.project_department_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.project_department_filter.Location = New System.Drawing.Point(11, 300)
        Me.project_department_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Name = "project_department_filter"
        Me.project_department_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Size = New System.Drawing.Size(557, 90)
        Me.project_department_filter.TabIndex = 214
        Me.project_department_filter.TabStop = False
        Me.project_department_filter.Text = "Project / Department"
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
        'rdo_account_1
        '
        Me.rdo_account_1.AutoSize = True
        Me.rdo_account_1.Checked = True
        Me.rdo_account_1.DataSource = ""
        Me.rdo_account_1.Location = New System.Drawing.Point(7, 18)
        Me.rdo_account_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
        'rdo_account_3
        '
        Me.rdo_account_3.AutoSize = True
        Me.rdo_account_3.DataSource = ""
        Me.rdo_account_3.Location = New System.Drawing.Point(7, 41)
        Me.rdo_account_3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 43)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 191
        Me.PictureBox1.TabStop = False
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
        'rdo_account_2
        '
        Me.rdo_account_2.AutoSize = True
        Me.rdo_account_2.DataSource = ""
        Me.rdo_account_2.Location = New System.Drawing.Point(72, 18)
        Me.rdo_account_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
        'account_filter
        '
        Me.account_filter.Controls.Add(Me.groupByUnit)
        Me.account_filter.Controls.Add(Me.NoRunningBalance)
        Me.account_filter.Controls.Add(Me.tabSeparated)
        Me.account_filter.Controls.Add(Me.rdo_account_2)
        Me.account_filter.Controls.Add(Me.btnImportAccount)
        Me.account_filter.Controls.Add(Me.lbl_account_name)
        Me.account_filter.Controls.Add(Me.PictureBox1)
        Me.account_filter.Controls.Add(Me.rdo_account_3)
        Me.account_filter.Controls.Add(Me.rdo_account_1)
        Me.account_filter.Controls.Add(Me.txt_account_id)
        Me.account_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.account_filter.Location = New System.Drawing.Point(11, 66)
        Me.account_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.account_filter.Name = "account_filter"
        Me.account_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.account_filter.Size = New System.Drawing.Size(556, 70)
        Me.account_filter.TabIndex = 211
        Me.account_filter.TabStop = False
        Me.account_filter.Text = "Account"
        '
        'groupByUnit
        '
        Me.groupByUnit.AutoSize = True
        Me.groupByUnit.Location = New System.Drawing.Point(418, 17)
        Me.groupByUnit.Name = "groupByUnit"
        Me.groupByUnit.Size = New System.Drawing.Size(92, 17)
        Me.groupByUnit.TabIndex = 240
        Me.groupByUnit.Text = "Group By Unit"
        Me.groupByUnit.UseVisualStyleBackColor = True
        '
        'NoRunningBalance
        '
        Me.NoRunningBalance.AutoSize = True
        Me.NoRunningBalance.Location = New System.Drawing.Point(291, 17)
        Me.NoRunningBalance.Name = "NoRunningBalance"
        Me.NoRunningBalance.Size = New System.Drawing.Size(121, 17)
        Me.NoRunningBalance.TabIndex = 239
        Me.NoRunningBalance.Text = "No Running Balance"
        Me.NoRunningBalance.UseVisualStyleBackColor = True
        '
        'tabSeparated
        '
        Me.tabSeparated.AutoSize = True
        Me.tabSeparated.Location = New System.Drawing.Point(176, 19)
        Me.tabSeparated.Name = "tabSeparated"
        Me.tabSeparated.Size = New System.Drawing.Size(97, 17)
        Me.tabSeparated.TabIndex = 238
        Me.tabSeparated.Text = "Tab Separated"
        Me.tabSeparated.UseVisualStyleBackColor = True
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(800, 28)
        Me.Myformheader1.TabIndex = 215
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(510, 417)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 10)
        Me.btnExcel.TabIndex = 216
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
        Me.btnPrintOption.Location = New System.Drawing.Point(323, 398)
        Me.btnPrintOption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 217
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'groupByBook
        '
        Me.groupByBook.AutoSize = True
        Me.groupByBook.Location = New System.Drawing.Point(691, 210)
        Me.groupByBook.Name = "groupByBook"
        Me.groupByBook.Size = New System.Drawing.Size(96, 17)
        Me.groupByBook.TabIndex = 235
        Me.groupByBook.Text = "Group by Book"
        Me.groupByBook.UseVisualStyleBackColor = True
        '
        'checkAllBooks
        '
        Me.checkAllBooks.AutoSize = True
        Me.checkAllBooks.Location = New System.Drawing.Point(583, 212)
        Me.checkAllBooks.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllBooks.Name = "checkAllBooks"
        Me.checkAllBooks.Size = New System.Drawing.Size(15, 14)
        Me.checkAllBooks.TabIndex = 234
        Me.checkAllBooks.UseVisualStyleBackColor = True
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
        Me.dgBooks.Location = New System.Drawing.Point(571, 206)
        Me.dgBooks.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgBooks.MultiSelect = False
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersVisible = False
        Me.dgBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBooks.Size = New System.Drawing.Size(218, 100)
        Me.dgBooks.TabIndex = 233
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
        Me.book_id.HeaderText = "ID"
        Me.book_id.Name = "book_id"
        Me.book_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.book_id.Visible = False
        '
        'dgBookUnits
        '
        Me.dgBookUnits.AllowUserToAddRows = False
        Me.dgBookUnits.AllowUserToDeleteRows = False
        Me.dgBookUnits.AllowUserToResizeColumns = False
        Me.dgBookUnits.AllowUserToResizeRows = False
        Me.dgBookUnits.BackgroundColor = System.Drawing.Color.White
        Me.dgBookUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBookUnits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel2, Me.book_unit_no_name, Me.book_unit_no_id})
        Me.dgBookUnits.EnableHeadersVisualStyles = False
        Me.dgBookUnits.Location = New System.Drawing.Point(571, 314)
        Me.dgBookUnits.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgBookUnits.MultiSelect = False
        Me.dgBookUnits.Name = "dgBookUnits"
        Me.dgBookUnits.RowHeadersVisible = False
        Me.dgBookUnits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBookUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBookUnits.Size = New System.Drawing.Size(218, 97)
        Me.dgBookUnits.TabIndex = 236
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
        Me.book_unit_no_name.HeaderText = "Unit No."
        Me.book_unit_no_name.Name = "book_unit_no_name"
        Me.book_unit_no_name.ReadOnly = True
        Me.book_unit_no_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_unit_no_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'book_unit_no_id
        '
        Me.book_unit_no_id.DataPropertyName = "book_unit_no_id"
        Me.book_unit_no_id.HeaderText = "ID"
        Me.book_unit_no_id.Name = "book_unit_no_id"
        Me.book_unit_no_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_unit_no_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.book_unit_no_id.Visible = False
        '
        'checkAllBookUnits
        '
        Me.checkAllBookUnits.AutoSize = True
        Me.checkAllBookUnits.Location = New System.Drawing.Point(583, 320)
        Me.checkAllBookUnits.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllBookUnits.Name = "checkAllBookUnits"
        Me.checkAllBookUnits.Size = New System.Drawing.Size(15, 14)
        Me.checkAllBookUnits.TabIndex = 237
        Me.checkAllBookUnits.UseVisualStyleBackColor = True
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(255, 170)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 238
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.border1.Location = New System.Drawing.Point(12, 60)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(777, 2)
        Me.border1.TabIndex = 199
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'arsubsidiary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 440)
        Me.Controls.Add(Me.checkAllBooks)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.checkAllBookUnits)
        Me.Controls.Add(Me.dgBookUnits)
        Me.Controls.Add(Me.groupByBook)
        Me.Controls.Add(Me.dgBooks)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.project_department_filter)
        Me.Controls.Add(Me.currency_filter)
        Me.Controls.Add(Me.general_filter)
        Me.Controls.Add(Me.account_filter)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.printoption)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.range_filter)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "arsubsidiary"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subsidiary Ledger of Receivable Accounts"
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        Me.printoption.ResumeLayout(False)
        Me.printoption.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.general_filter.ResumeLayout(False)
        Me.general_filter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.currency_filter.ResumeLayout(False)
        Me.currency_filter.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_department_filter.ResumeLayout(False)
        Me.project_department_filter.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.account_filter.ResumeLayout(False)
        Me.account_filter.PerformLayout()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBookUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents range_filter As System.Windows.Forms.Panel
    Friend WithEvents rdo3 As user_control.rdo_button
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents printoption As System.Windows.Forms.Panel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents rdo_general_1 As user_control.rdo_button
    Friend WithEvents rdo_general_3 As user_control.rdo_button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_general_name As System.Windows.Forms.Label
    Friend WithEvents btnImportGeneral As System.Windows.Forms.Button
    Friend WithEvents rdo_general_2 As user_control.rdo_button
    Friend WithEvents general_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_currency_1 As user_control.rdo_button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents rdo_currency_2 As user_control.rdo_button
    Friend WithEvents lbl_currency_name As System.Windows.Forms.Label
    Friend WithEvents withComparison As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents currency_filter As System.Windows.Forms.GroupBox
    Friend WithEvents txt_project_id As user_control.textbox
    Friend WithEvents txt_department_id As user_control.textbox
    Friend WithEvents withProjectDepartment As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_project_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_department_name As System.Windows.Forms.Label
    Friend WithEvents project_department_filter As System.Windows.Forms.GroupBox
    Friend WithEvents txt_account_id As user_control.textbox
    Friend WithEvents rdo_account_1 As user_control.rdo_button
    Friend WithEvents rdo_account_3 As user_control.rdo_button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_account_name As System.Windows.Forms.Label
    Friend WithEvents btnImportAccount As System.Windows.Forms.Button
    Friend WithEvents rdo_account_2 As user_control.rdo_button
    Friend WithEvents account_filter As System.Windows.Forms.GroupBox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents groupByBook As System.Windows.Forms.CheckBox
    Friend WithEvents checkAllBooks As System.Windows.Forms.CheckBox
    Friend WithEvents dgBooks As System.Windows.Forms.DataGridView
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBookUnits As Windows.Forms.DataGridView
    Friend WithEvents sel2 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_unit_no_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_unit_no_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkAllBookUnits As Windows.Forms.CheckBox
    Friend WithEvents tabSeparated As Windows.Forms.CheckBox
    Friend WithEvents NoRunningBalance As Windows.Forms.CheckBox
    Friend WithEvents lblLoad As Windows.Forms.Label
    Friend WithEvents groupByUnit As Windows.Forms.CheckBox
End Class
