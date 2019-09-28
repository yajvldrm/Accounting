<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class companyconfig
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.txt_forex_account_id = New user_control.textbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_fiscal_year = New System.Windows.Forms.NumericUpDown()
        Me.txt_fiscal_month = New System.Windows.Forms.ComboBox()
        Me.isFiscal = New System.Windows.Forms.CheckBox()
        Me.txt_retained_account_id = New user_control.textbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.general_auto_number = New System.Windows.Forms.CheckBox()
        Me.txt_tin = New user_control.myMaskedTextBox()
        Me.txt_decimal_places = New user_control.textbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_rdo_code = New user_control.textbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.monthly_currency = New System.Windows.Forms.CheckBox()
        Me.txt_default_id = New user_control.textbox()
        Me.line_currency = New System.Windows.Forms.CheckBox()
        Me.line_remarks = New System.Windows.Forms.CheckBox()
        Me.w_alloc = New System.Windows.Forms.CheckBox()
        Me.w_dept = New System.Windows.Forms.CheckBox()
        Me.w_proj = New System.Windows.Forms.CheckBox()
        Me.txt_company_name = New user_control.textbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_company_id = New user_control.textbox()
        Me.txt_currency_code = New user_control.textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_sys_beg = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email = New user_control.textbox()
        Me.txt_tel_no = New user_control.textbox()
        Me.txt_fax_no = New user_control.textbox()
        Me.txt_address2 = New user_control.textbox()
        Me.txt_address1 = New user_control.textbox()
        Me.txt_company_code = New user_control.textbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_address3 = New user_control.textbox()
        Me.txt_address4 = New user_control.textbox()
        Me.used_in_report = New System.Windows.Forms.CheckBox()
        Me.txt_filter_code = New user_control.textbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.primary_key = New user_control.textbox()
        Me.btnAT = New user_control.MyButton()
        Me.border1 = New accounting.borderedlabel()
        Me.gboxContainer.SuspendLayout()
        CType(Me.txt_fiscal_year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(11, 68)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(97, 68)
        Me.btnNotSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 5
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "System Configuration"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(11, 68)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.txt_forex_account_id)
        Me.gboxContainer.Controls.Add(Me.Label15)
        Me.gboxContainer.Controls.Add(Me.txt_fiscal_year)
        Me.gboxContainer.Controls.Add(Me.txt_fiscal_month)
        Me.gboxContainer.Controls.Add(Me.isFiscal)
        Me.gboxContainer.Controls.Add(Me.txt_retained_account_id)
        Me.gboxContainer.Controls.Add(Me.Label14)
        Me.gboxContainer.Controls.Add(Me.general_auto_number)
        Me.gboxContainer.Controls.Add(Me.txt_tin)
        Me.gboxContainer.Controls.Add(Me.txt_decimal_places)
        Me.gboxContainer.Controls.Add(Me.Label13)
        Me.gboxContainer.Controls.Add(Me.txt_rdo_code)
        Me.gboxContainer.Controls.Add(Me.Label12)
        Me.gboxContainer.Controls.Add(Me.monthly_currency)
        Me.gboxContainer.Controls.Add(Me.txt_default_id)
        Me.gboxContainer.Controls.Add(Me.line_currency)
        Me.gboxContainer.Controls.Add(Me.line_remarks)
        Me.gboxContainer.Controls.Add(Me.w_alloc)
        Me.gboxContainer.Controls.Add(Me.w_dept)
        Me.gboxContainer.Controls.Add(Me.w_proj)
        Me.gboxContainer.Controls.Add(Me.txt_company_name)
        Me.gboxContainer.Controls.Add(Me.Label11)
        Me.gboxContainer.Controls.Add(Me.Label9)
        Me.gboxContainer.Controls.Add(Me.txt_company_id)
        Me.gboxContainer.Controls.Add(Me.txt_currency_code)
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.txt_sys_beg)
        Me.gboxContainer.Controls.Add(Me.Label4)
        Me.gboxContainer.Controls.Add(Me.txt_email)
        Me.gboxContainer.Controls.Add(Me.txt_tel_no)
        Me.gboxContainer.Controls.Add(Me.txt_fax_no)
        Me.gboxContainer.Controls.Add(Me.txt_address2)
        Me.gboxContainer.Controls.Add(Me.txt_address1)
        Me.gboxContainer.Controls.Add(Me.txt_company_code)
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Controls.Add(Me.Label6)
        Me.gboxContainer.Controls.Add(Me.Label5)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.txt_address3)
        Me.gboxContainer.Controls.Add(Me.txt_address4)
        Me.gboxContainer.Controls.Add(Me.used_in_report)
        Me.gboxContainer.Controls.Add(Me.txt_filter_code)
        Me.gboxContainer.Controls.Add(Me.Label10)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 98)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(576, 351)
        Me.gboxContainer.TabIndex = 8
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'txt_forex_account_id
        '
        Me.txt_forex_account_id._Text = ""
        Me.txt_forex_account_id.AllowNegative = False
        Me.txt_forex_account_id.AlwaysDisable = False
        Me.txt_forex_account_id.AlwaysEnable = False
        Me.txt_forex_account_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_forex_account_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_forex_account_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_forex_account_id.DataSource = ""
        Me.txt_forex_account_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_forex_account_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_forex_account_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_forex_account_id.Enabled = False
        Me.txt_forex_account_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_forex_account_id.ispk = False
        Me.txt_forex_account_id.Location = New System.Drawing.Point(400, 165)
        Me.txt_forex_account_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_forex_account_id.MultiLine = False
        Me.txt_forex_account_id.Name = "txt_forex_account_id"
        Me.txt_forex_account_id.NoClear = False
        Me.txt_forex_account_id.NumberFormat = "@"
        Me.txt_forex_account_id.Required = False
        Me.txt_forex_account_id.RowData = Nothing
        Me.txt_forex_account_id.SelectionLength = 0
        Me.txt_forex_account_id.SelectionStart = 0
        Me.txt_forex_account_id.Size = New System.Drawing.Size(170, 20)
        Me.txt_forex_account_id.TabIndex = 42
        Me.txt_forex_account_id.TableData = Nothing
        Me.txt_forex_account_id.TextSource = "forex_account_code"
        Me.txt_forex_account_id.UseSystemPasswordChar = False
        Me.txt_forex_account_id.Value = ""
        Me.txt_forex_account_id.ValueSource = "forex_account_id"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(278, 166)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Tag = "label"
        Me.Label15.Text = "FOREIGN EXCHANGE"
        '
        'txt_fiscal_year
        '
        Me.txt_fiscal_year.Location = New System.Drawing.Point(219, 232)
        Me.txt_fiscal_year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_fiscal_year.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.txt_fiscal_year.Name = "txt_fiscal_year"
        Me.txt_fiscal_year.Size = New System.Drawing.Size(51, 20)
        Me.txt_fiscal_year.TabIndex = 31
        Me.txt_fiscal_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_fiscal_year.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'txt_fiscal_month
        '
        Me.txt_fiscal_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_fiscal_month.FormattingEnabled = True
        Me.txt_fiscal_month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txt_fiscal_month.Location = New System.Drawing.Point(100, 232)
        Me.txt_fiscal_month.Name = "txt_fiscal_month"
        Me.txt_fiscal_month.Size = New System.Drawing.Size(113, 21)
        Me.txt_fiscal_month.TabIndex = 30
        '
        'isFiscal
        '
        Me.isFiscal.AutoSize = True
        Me.isFiscal.Enabled = False
        Me.isFiscal.Location = New System.Drawing.Point(32, 234)
        Me.isFiscal.Name = "isFiscal"
        Me.isFiscal.Size = New System.Drawing.Size(62, 17)
        Me.isFiscal.TabIndex = 29
        Me.isFiscal.Text = "FISCAL"
        Me.isFiscal.UseVisualStyleBackColor = True
        '
        'txt_retained_account_id
        '
        Me.txt_retained_account_id._Text = ""
        Me.txt_retained_account_id.AllowNegative = False
        Me.txt_retained_account_id.AlwaysDisable = False
        Me.txt_retained_account_id.AlwaysEnable = False
        Me.txt_retained_account_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_retained_account_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_retained_account_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_retained_account_id.DataSource = ""
        Me.txt_retained_account_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_retained_account_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_retained_account_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_retained_account_id.Enabled = False
        Me.txt_retained_account_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_retained_account_id.ispk = False
        Me.txt_retained_account_id.Location = New System.Drawing.Point(400, 139)
        Me.txt_retained_account_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_retained_account_id.MultiLine = False
        Me.txt_retained_account_id.Name = "txt_retained_account_id"
        Me.txt_retained_account_id.NoClear = False
        Me.txt_retained_account_id.NumberFormat = "@"
        Me.txt_retained_account_id.Required = False
        Me.txt_retained_account_id.RowData = Nothing
        Me.txt_retained_account_id.SelectionLength = 0
        Me.txt_retained_account_id.SelectionStart = 0
        Me.txt_retained_account_id.Size = New System.Drawing.Size(170, 20)
        Me.txt_retained_account_id.TabIndex = 15
        Me.txt_retained_account_id.TableData = Nothing
        Me.txt_retained_account_id.TextSource = "account_code"
        Me.txt_retained_account_id.UseSystemPasswordChar = False
        Me.txt_retained_account_id.Value = ""
        Me.txt_retained_account_id.ValueSource = "retained_account_id"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(281, 142)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Tag = "label"
        Me.Label14.Text = "RETAINED EARNING"
        '
        'general_auto_number
        '
        Me.general_auto_number.AutoSize = True
        Me.general_auto_number.Enabled = False
        Me.general_auto_number.Location = New System.Drawing.Point(45, 282)
        Me.general_auto_number.Name = "general_auto_number"
        Me.general_auto_number.Size = New System.Drawing.Size(106, 17)
        Me.general_auto_number.TabIndex = 34
        Me.general_auto_number.Text = "AUTO NUMBER"
        Me.general_auto_number.UseVisualStyleBackColor = True
        '
        'txt_tin
        '
        Me.txt_tin.AlwaysDisable = False
        Me.txt_tin.AlwaysEnable = False
        Me.txt_tin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tin.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tin.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tin.Enabled = False
        Me.txt_tin.EnabledBackColor = System.Drawing.Color.White
        Me.txt_tin.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_tin.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tin.Location = New System.Drawing.Point(100, 187)
        Me.txt_tin.Mask = "###-###-###-#####"
        Me.txt_tin.Name = "txt_tin"
        Me.txt_tin.NoClear = False
        Me.txt_tin.NoSave = False
        Me.txt_tin.Required = False
        Me.txt_tin.Size = New System.Drawing.Size(170, 20)
        Me.txt_tin.TabIndex = 22
        Me.txt_tin.TextSource = "tin"
        Me.txt_tin.Unique = False
        Me.txt_tin.Value = ""
        Me.txt_tin.ValueSource = ""
        '
        'txt_decimal_places
        '
        Me.txt_decimal_places._Text = ""
        Me.txt_decimal_places.AllowNegative = False
        Me.txt_decimal_places.AlwaysDisable = False
        Me.txt_decimal_places.AlwaysEnable = False
        Me.txt_decimal_places.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_decimal_places.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_decimal_places.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_decimal_places.DataSource = ""
        Me.txt_decimal_places.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_decimal_places.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_decimal_places.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_decimal_places.Enabled = False
        Me.txt_decimal_places.EnabledBackColor = System.Drawing.Color.White
        Me.txt_decimal_places.ispk = False
        Me.txt_decimal_places.Location = New System.Drawing.Point(400, 266)
        Me.txt_decimal_places.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_decimal_places.MultiLine = False
        Me.txt_decimal_places.Name = "txt_decimal_places"
        Me.txt_decimal_places.NoClear = False
        Me.txt_decimal_places.NumberFormat = "#,##0"
        Me.txt_decimal_places.Required = False
        Me.txt_decimal_places.RowData = Nothing
        Me.txt_decimal_places.SelectionLength = 0
        Me.txt_decimal_places.SelectionStart = 0
        Me.txt_decimal_places.Size = New System.Drawing.Size(170, 20)
        Me.txt_decimal_places.TabIndex = 33
        Me.txt_decimal_places.TableData = Nothing
        Me.txt_decimal_places.TextSource = ""
        Me.txt_decimal_places.UseSystemPasswordChar = False
        Me.txt_decimal_places.Value = "0"
        Me.txt_decimal_places.ValueSource = "decimal_places"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(297, 269)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Tag = "label"
        Me.Label13.Text = "DECIMAL PLACES"
        '
        'txt_rdo_code
        '
        Me.txt_rdo_code._Text = ""
        Me.txt_rdo_code.AllowNegative = False
        Me.txt_rdo_code.AlwaysDisable = False
        Me.txt_rdo_code.AlwaysEnable = False
        Me.txt_rdo_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rdo_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_rdo_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rdo_code.DataSource = ""
        Me.txt_rdo_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_rdo_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rdo_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_rdo_code.Enabled = False
        Me.txt_rdo_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_rdo_code.ispk = False
        Me.txt_rdo_code.Location = New System.Drawing.Point(400, 215)
        Me.txt_rdo_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_rdo_code.MultiLine = False
        Me.txt_rdo_code.Name = "txt_rdo_code"
        Me.txt_rdo_code.NoClear = False
        Me.txt_rdo_code.NumberFormat = "@"
        Me.txt_rdo_code.Required = False
        Me.txt_rdo_code.RowData = Nothing
        Me.txt_rdo_code.SelectionLength = 0
        Me.txt_rdo_code.SelectionStart = 0
        Me.txt_rdo_code.Size = New System.Drawing.Size(170, 20)
        Me.txt_rdo_code.TabIndex = 24
        Me.txt_rdo_code.TableData = Nothing
        Me.txt_rdo_code.TextSource = "rdo_code"
        Me.txt_rdo_code.UseSystemPasswordChar = False
        Me.txt_rdo_code.Value = ""
        Me.txt_rdo_code.ValueSource = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(333, 218)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Tag = "label"
        Me.Label12.Text = "RDO CODE"
        '
        'monthly_currency
        '
        Me.monthly_currency.AutoSize = True
        Me.monthly_currency.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.monthly_currency.Location = New System.Drawing.Point(357, 305)
        Me.monthly_currency.Name = "monthly_currency"
        Me.monthly_currency.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.monthly_currency.Size = New System.Drawing.Size(174, 17)
        Me.monthly_currency.TabIndex = 37
        Me.monthly_currency.Text = "MONTHLY CURRENCY RATE"
        Me.monthly_currency.UseVisualStyleBackColor = True
        '
        'txt_default_id
        '
        Me.txt_default_id._Text = ""
        Me.txt_default_id.AllowNegative = False
        Me.txt_default_id.AlwaysDisable = False
        Me.txt_default_id.AlwaysEnable = False
        Me.txt_default_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_default_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_default_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_default_id.DataSource = ""
        Me.txt_default_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_default_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_default_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_default_id.Enabled = False
        Me.txt_default_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_default_id.ispk = False
        Me.txt_default_id.Location = New System.Drawing.Point(41, 113)
        Me.txt_default_id.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_default_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_default_id.MultiLine = False
        Me.txt_default_id.Name = "txt_default_id"
        Me.txt_default_id.NoClear = False
        Me.txt_default_id.NumberFormat = "@"
        Me.txt_default_id.Required = False
        Me.txt_default_id.RowData = Nothing
        Me.txt_default_id.SelectionLength = 0
        Me.txt_default_id.SelectionStart = 0
        Me.txt_default_id.Size = New System.Drawing.Size(49, 16)
        Me.txt_default_id.TabIndex = 8
        Me.txt_default_id.TableData = Nothing
        Me.txt_default_id.TextSource = "default_id"
        Me.txt_default_id.UseSystemPasswordChar = False
        Me.txt_default_id.Value = ""
        Me.txt_default_id.ValueSource = "default_id"
        Me.txt_default_id.Visible = False
        '
        'line_currency
        '
        Me.line_currency.AutoSize = True
        Me.line_currency.Enabled = False
        Me.line_currency.Location = New System.Drawing.Point(357, 328)
        Me.line_currency.Name = "line_currency"
        Me.line_currency.Size = New System.Drawing.Size(131, 17)
        Me.line_currency.TabIndex = 40
        Me.line_currency.Text = "ENABLE CURRENCY"
        Me.line_currency.UseVisualStyleBackColor = True
        '
        'line_remarks
        '
        Me.line_remarks.AutoSize = True
        Me.line_remarks.Enabled = False
        Me.line_remarks.Location = New System.Drawing.Point(200, 328)
        Me.line_remarks.Name = "line_remarks"
        Me.line_remarks.Size = New System.Drawing.Size(151, 17)
        Me.line_remarks.TabIndex = 39
        Me.line_remarks.Text = "ENABLE LINE REMARKS"
        Me.line_remarks.UseVisualStyleBackColor = True
        '
        'w_alloc
        '
        Me.w_alloc.AutoSize = True
        Me.w_alloc.Enabled = False
        Me.w_alloc.Location = New System.Drawing.Point(200, 305)
        Me.w_alloc.Name = "w_alloc"
        Me.w_alloc.Size = New System.Drawing.Size(138, 17)
        Me.w_alloc.TabIndex = 36
        Me.w_alloc.Text = "ENABLE ALLOCATION"
        Me.w_alloc.UseVisualStyleBackColor = True
        '
        'w_dept
        '
        Me.w_dept.AutoSize = True
        Me.w_dept.Enabled = False
        Me.w_dept.Location = New System.Drawing.Point(45, 328)
        Me.w_dept.Name = "w_dept"
        Me.w_dept.Size = New System.Drawing.Size(146, 17)
        Me.w_dept.TabIndex = 38
        Me.w_dept.Text = "ENABLE DEPARTMENT"
        Me.w_dept.UseVisualStyleBackColor = True
        '
        'w_proj
        '
        Me.w_proj.AutoSize = True
        Me.w_proj.Enabled = False
        Me.w_proj.Location = New System.Drawing.Point(45, 305)
        Me.w_proj.Name = "w_proj"
        Me.w_proj.Size = New System.Drawing.Size(120, 17)
        Me.w_proj.TabIndex = 35
        Me.w_proj.Text = "ENABLE PROJECT"
        Me.w_proj.UseVisualStyleBackColor = True
        '
        'txt_company_name
        '
        Me.txt_company_name._Text = ""
        Me.txt_company_name.AllowNegative = False
        Me.txt_company_name.AlwaysDisable = False
        Me.txt_company_name.AlwaysEnable = False
        Me.txt_company_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_company_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_company_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_company_name.DataSource = ""
        Me.txt_company_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_company_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_company_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_company_name.Enabled = False
        Me.txt_company_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_company_name.ispk = False
        Me.txt_company_name.Location = New System.Drawing.Point(100, 43)
        Me.txt_company_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_company_name.MultiLine = False
        Me.txt_company_name.Name = "txt_company_name"
        Me.txt_company_name.NoClear = False
        Me.txt_company_name.NumberFormat = "@"
        Me.txt_company_name.Required = False
        Me.txt_company_name.RowData = Nothing
        Me.txt_company_name.SelectionLength = 0
        Me.txt_company_name.SelectionStart = 0
        Me.txt_company_name.Size = New System.Drawing.Size(470, 20)
        Me.txt_company_name.TabIndex = 3
        Me.txt_company_name.TableData = Nothing
        Me.txt_company_name.TextSource = "company_name"
        Me.txt_company_name.UseSystemPasswordChar = False
        Me.txt_company_name.Value = ""
        Me.txt_company_name.ValueSource = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(59, 46)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Tag = "label"
        Me.Label11.Text = "NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 190)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Tag = "label"
        Me.Label9.Text = "TIN"
        '
        'txt_company_id
        '
        Me.txt_company_id._Text = ""
        Me.txt_company_id.AllowNegative = False
        Me.txt_company_id.AlwaysDisable = False
        Me.txt_company_id.AlwaysEnable = False
        Me.txt_company_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_company_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_company_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_company_id.DataSource = ""
        Me.txt_company_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_company_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_company_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_company_id.Enabled = False
        Me.txt_company_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_company_id.ispk = False
        Me.txt_company_id.Location = New System.Drawing.Point(41, 95)
        Me.txt_company_id.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_company_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_company_id.MultiLine = False
        Me.txt_company_id.Name = "txt_company_id"
        Me.txt_company_id.NoClear = False
        Me.txt_company_id.NumberFormat = "@"
        Me.txt_company_id.Required = False
        Me.txt_company_id.RowData = Nothing
        Me.txt_company_id.SelectionLength = 0
        Me.txt_company_id.SelectionStart = 0
        Me.txt_company_id.Size = New System.Drawing.Size(49, 16)
        Me.txt_company_id.TabIndex = 6
        Me.txt_company_id.TableData = Nothing
        Me.txt_company_id.TextSource = "company_id"
        Me.txt_company_id.UseSystemPasswordChar = False
        Me.txt_company_id.Value = ""
        Me.txt_company_id.ValueSource = "company_id"
        Me.txt_company_id.Visible = False
        '
        'txt_currency_code
        '
        Me.txt_currency_code._Text = ""
        Me.txt_currency_code.AllowNegative = False
        Me.txt_currency_code.AlwaysDisable = False
        Me.txt_currency_code.AlwaysEnable = False
        Me.txt_currency_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_code.DataSource = ""
        Me.txt_currency_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_code.Enabled = False
        Me.txt_currency_code.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_currency_code.ispk = False
        Me.txt_currency_code.Location = New System.Drawing.Point(400, 240)
        Me.txt_currency_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_code.MultiLine = False
        Me.txt_currency_code.Name = "txt_currency_code"
        Me.txt_currency_code.NoClear = False
        Me.txt_currency_code.NumberFormat = "@"
        Me.txt_currency_code.Required = False
        Me.txt_currency_code.RowData = Nothing
        Me.txt_currency_code.SelectionLength = 0
        Me.txt_currency_code.SelectionStart = 0
        Me.txt_currency_code.Size = New System.Drawing.Size(170, 20)
        Me.txt_currency_code.TabIndex = 28
        Me.txt_currency_code.TableData = Nothing
        Me.txt_currency_code.TextSource = "currency_code"
        Me.txt_currency_code.UseSystemPasswordChar = False
        Me.txt_currency_code.Value = ""
        Me.txt_currency_code.ValueSource = "currency_id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 243)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Tag = "label"
        Me.Label7.Text = "BASED CURRENCY"
        '
        'txt_sys_beg
        '
        Me.txt_sys_beg.Enabled = False
        Me.txt_sys_beg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_sys_beg.Location = New System.Drawing.Point(100, 211)
        Me.txt_sys_beg.Name = "txt_sys_beg"
        Me.txt_sys_beg.Size = New System.Drawing.Size(170, 20)
        Me.txt_sys_beg.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Tag = "label"
        Me.Label4.Text = "BEG. BAL. DATE"
        '
        'txt_email
        '
        Me.txt_email._Text = ""
        Me.txt_email.AllowNegative = False
        Me.txt_email.AlwaysDisable = False
        Me.txt_email.AlwaysEnable = False
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_email.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.DataSource = ""
        Me.txt_email.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_email.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_email.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_email.Enabled = False
        Me.txt_email.EnabledBackColor = System.Drawing.Color.White
        Me.txt_email.ispk = False
        Me.txt_email.Location = New System.Drawing.Point(100, 139)
        Me.txt_email.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_email.MultiLine = False
        Me.txt_email.Name = "txt_email"
        Me.txt_email.NoClear = False
        Me.txt_email.NumberFormat = "@"
        Me.txt_email.Required = False
        Me.txt_email.RowData = Nothing
        Me.txt_email.SelectionLength = 0
        Me.txt_email.SelectionStart = 0
        Me.txt_email.Size = New System.Drawing.Size(170, 20)
        Me.txt_email.TabIndex = 12
        Me.txt_email.TableData = Nothing
        Me.txt_email.TextSource = "email_add"
        Me.txt_email.UseSystemPasswordChar = False
        Me.txt_email.Value = ""
        Me.txt_email.ValueSource = ""
        '
        'txt_tel_no
        '
        Me.txt_tel_no._Text = ""
        Me.txt_tel_no.AllowNegative = False
        Me.txt_tel_no.AlwaysDisable = False
        Me.txt_tel_no.AlwaysEnable = False
        Me.txt_tel_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tel_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_tel_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tel_no.DataSource = ""
        Me.txt_tel_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tel_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tel_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tel_no.Enabled = False
        Me.txt_tel_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_tel_no.ispk = False
        Me.txt_tel_no.Location = New System.Drawing.Point(100, 163)
        Me.txt_tel_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tel_no.MultiLine = False
        Me.txt_tel_no.Name = "txt_tel_no"
        Me.txt_tel_no.NoClear = False
        Me.txt_tel_no.NumberFormat = "@"
        Me.txt_tel_no.Required = False
        Me.txt_tel_no.RowData = Nothing
        Me.txt_tel_no.SelectionLength = 0
        Me.txt_tel_no.SelectionStart = 0
        Me.txt_tel_no.Size = New System.Drawing.Size(170, 20)
        Me.txt_tel_no.TabIndex = 18
        Me.txt_tel_no.TableData = Nothing
        Me.txt_tel_no.TextSource = "tel_no"
        Me.txt_tel_no.UseSystemPasswordChar = False
        Me.txt_tel_no.Value = ""
        Me.txt_tel_no.ValueSource = ""
        '
        'txt_fax_no
        '
        Me.txt_fax_no._Text = ""
        Me.txt_fax_no.AllowNegative = False
        Me.txt_fax_no.AlwaysDisable = False
        Me.txt_fax_no.AlwaysEnable = False
        Me.txt_fax_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fax_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_fax_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fax_no.DataSource = ""
        Me.txt_fax_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fax_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fax_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_fax_no.Enabled = False
        Me.txt_fax_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_fax_no.ispk = False
        Me.txt_fax_no.Location = New System.Drawing.Point(400, 191)
        Me.txt_fax_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fax_no.MultiLine = False
        Me.txt_fax_no.Name = "txt_fax_no"
        Me.txt_fax_no.NoClear = False
        Me.txt_fax_no.NumberFormat = "@"
        Me.txt_fax_no.Required = False
        Me.txt_fax_no.RowData = Nothing
        Me.txt_fax_no.SelectionLength = 0
        Me.txt_fax_no.SelectionStart = 0
        Me.txt_fax_no.Size = New System.Drawing.Size(170, 20)
        Me.txt_fax_no.TabIndex = 20
        Me.txt_fax_no.TableData = Nothing
        Me.txt_fax_no.TextSource = "fax_no"
        Me.txt_fax_no.UseSystemPasswordChar = False
        Me.txt_fax_no.Value = ""
        Me.txt_fax_no.ValueSource = ""
        '
        'txt_address2
        '
        Me.txt_address2._Text = ""
        Me.txt_address2.AllowNegative = False
        Me.txt_address2.AlwaysDisable = False
        Me.txt_address2.AlwaysEnable = False
        Me.txt_address2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address2.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address2.DataSource = ""
        Me.txt_address2.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address2.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address2.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_address2.Enabled = False
        Me.txt_address2.EnabledBackColor = System.Drawing.Color.White
        Me.txt_address2.ispk = False
        Me.txt_address2.Location = New System.Drawing.Point(100, 91)
        Me.txt_address2.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address2.MultiLine = False
        Me.txt_address2.Name = "txt_address2"
        Me.txt_address2.NoClear = False
        Me.txt_address2.NumberFormat = "@"
        Me.txt_address2.Required = False
        Me.txt_address2.RowData = Nothing
        Me.txt_address2.SelectionLength = 0
        Me.txt_address2.SelectionStart = 0
        Me.txt_address2.Size = New System.Drawing.Size(470, 20)
        Me.txt_address2.TabIndex = 7
        Me.txt_address2.TableData = Nothing
        Me.txt_address2.TextSource = "address2"
        Me.txt_address2.UseSystemPasswordChar = False
        Me.txt_address2.Value = ""
        Me.txt_address2.ValueSource = ""
        '
        'txt_address1
        '
        Me.txt_address1._Text = ""
        Me.txt_address1.AllowNegative = False
        Me.txt_address1.AlwaysDisable = False
        Me.txt_address1.AlwaysEnable = False
        Me.txt_address1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address1.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address1.DataSource = ""
        Me.txt_address1.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address1.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_address1.Enabled = False
        Me.txt_address1.EnabledBackColor = System.Drawing.Color.White
        Me.txt_address1.ispk = False
        Me.txt_address1.Location = New System.Drawing.Point(100, 67)
        Me.txt_address1.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address1.MultiLine = False
        Me.txt_address1.Name = "txt_address1"
        Me.txt_address1.NoClear = False
        Me.txt_address1.NumberFormat = "@"
        Me.txt_address1.Required = False
        Me.txt_address1.RowData = Nothing
        Me.txt_address1.SelectionLength = 0
        Me.txt_address1.SelectionStart = 0
        Me.txt_address1.Size = New System.Drawing.Size(470, 20)
        Me.txt_address1.TabIndex = 5
        Me.txt_address1.TableData = Nothing
        Me.txt_address1.TextSource = "address1"
        Me.txt_address1.UseSystemPasswordChar = False
        Me.txt_address1.Value = ""
        Me.txt_address1.ValueSource = ""
        '
        'txt_company_code
        '
        Me.txt_company_code._Text = ""
        Me.txt_company_code.AllowNegative = False
        Me.txt_company_code.AlwaysDisable = False
        Me.txt_company_code.AlwaysEnable = False
        Me.txt_company_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_company_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_company_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_company_code.DataSource = ""
        Me.txt_company_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_company_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_company_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_company_code.Enabled = False
        Me.txt_company_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_company_code.ispk = False
        Me.txt_company_code.Location = New System.Drawing.Point(100, 19)
        Me.txt_company_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_company_code.MultiLine = False
        Me.txt_company_code.Name = "txt_company_code"
        Me.txt_company_code.NoClear = False
        Me.txt_company_code.NumberFormat = "@"
        Me.txt_company_code.Required = False
        Me.txt_company_code.RowData = Nothing
        Me.txt_company_code.SelectionLength = 0
        Me.txt_company_code.SelectionStart = 0
        Me.txt_company_code.Size = New System.Drawing.Size(470, 20)
        Me.txt_company_code.TabIndex = 1
        Me.txt_company_code.TableData = Nothing
        Me.txt_company_code.TextSource = "company_code"
        Me.txt_company_code.UseSystemPasswordChar = False
        Me.txt_company_code.Value = ""
        Me.txt_company_code.ValueSource = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 142)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Tag = "label"
        Me.Label8.Text = "EMAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Tag = "label"
        Me.Label2.Text = "TEL NO."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Tag = "label"
        Me.Label6.Text = "ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Tag = "label"
        Me.Label5.Text = "FAX NO."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Tag = "label"
        Me.Label3.Text = "COMPANY CODE"
        '
        'txt_address3
        '
        Me.txt_address3._Text = ""
        Me.txt_address3.AllowNegative = False
        Me.txt_address3.AlwaysDisable = False
        Me.txt_address3.AlwaysEnable = False
        Me.txt_address3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address3.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address3.DataSource = ""
        Me.txt_address3.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address3.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address3.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_address3.Enabled = False
        Me.txt_address3.EnabledBackColor = System.Drawing.Color.White
        Me.txt_address3.ispk = False
        Me.txt_address3.Location = New System.Drawing.Point(100, 115)
        Me.txt_address3.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address3.MultiLine = False
        Me.txt_address3.Name = "txt_address3"
        Me.txt_address3.NoClear = False
        Me.txt_address3.NumberFormat = "@"
        Me.txt_address3.Required = False
        Me.txt_address3.RowData = Nothing
        Me.txt_address3.SelectionLength = 0
        Me.txt_address3.SelectionStart = 0
        Me.txt_address3.Size = New System.Drawing.Size(470, 20)
        Me.txt_address3.TabIndex = 9
        Me.txt_address3.TableData = Nothing
        Me.txt_address3.TextSource = "address3"
        Me.txt_address3.UseSystemPasswordChar = False
        Me.txt_address3.Value = ""
        Me.txt_address3.ValueSource = ""
        '
        'txt_address4
        '
        Me.txt_address4._Text = ""
        Me.txt_address4.AllowNegative = False
        Me.txt_address4.AlwaysDisable = False
        Me.txt_address4.AlwaysEnable = False
        Me.txt_address4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address4.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_address4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address4.DataSource = ""
        Me.txt_address4.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address4.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address4.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_address4.Enabled = False
        Me.txt_address4.EnabledBackColor = System.Drawing.Color.White
        Me.txt_address4.ispk = False
        Me.txt_address4.Location = New System.Drawing.Point(100, 115)
        Me.txt_address4.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address4.MultiLine = False
        Me.txt_address4.Name = "txt_address4"
        Me.txt_address4.NoClear = False
        Me.txt_address4.NumberFormat = "@"
        Me.txt_address4.Required = False
        Me.txt_address4.RowData = Nothing
        Me.txt_address4.SelectionLength = 0
        Me.txt_address4.SelectionStart = 0
        Me.txt_address4.Size = New System.Drawing.Size(470, 20)
        Me.txt_address4.TabIndex = 8
        Me.txt_address4.TableData = Nothing
        Me.txt_address4.TextSource = "address4"
        Me.txt_address4.UseSystemPasswordChar = False
        Me.txt_address4.Value = ""
        Me.txt_address4.ValueSource = ""
        '
        'used_in_report
        '
        Me.used_in_report.AutoSize = True
        Me.used_in_report.Enabled = False
        Me.used_in_report.Location = New System.Drawing.Point(6, 170)
        Me.used_in_report.Name = "used_in_report"
        Me.used_in_report.Size = New System.Drawing.Size(110, 17)
        Me.used_in_report.TabIndex = 16
        Me.used_in_report.Text = "USE IN REPORT"
        Me.used_in_report.UseVisualStyleBackColor = True
        Me.used_in_report.Visible = False
        '
        'txt_filter_code
        '
        Me.txt_filter_code._Text = ""
        Me.txt_filter_code.AllowNegative = False
        Me.txt_filter_code.AlwaysDisable = False
        Me.txt_filter_code.AlwaysEnable = False
        Me.txt_filter_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filter_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filter_code.DataSource = ""
        Me.txt_filter_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filter_code.Enabled = False
        Me.txt_filter_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_filter_code.ispk = False
        Me.txt_filter_code.Location = New System.Drawing.Point(6, 141)
        Me.txt_filter_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_code.MultiLine = False
        Me.txt_filter_code.Name = "txt_filter_code"
        Me.txt_filter_code.NoClear = False
        Me.txt_filter_code.NumberFormat = "@"
        Me.txt_filter_code.Required = False
        Me.txt_filter_code.RowData = Nothing
        Me.txt_filter_code.SelectionLength = 0
        Me.txt_filter_code.SelectionStart = 0
        Me.txt_filter_code.Size = New System.Drawing.Size(26, 20)
        Me.txt_filter_code.TabIndex = 10
        Me.txt_filter_code.TableData = Nothing
        Me.txt_filter_code.TextSource = "filter_code"
        Me.txt_filter_code.UseSystemPasswordChar = False
        Me.txt_filter_code.Value = ""
        Me.txt_filter_code.ValueSource = "filter_id"
        Me.txt_filter_code.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(149, 142)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Tag = "label"
        Me.Label10.Text = "FILTER CODE"
        Me.Label10.Visible = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(600, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'primary_key
        '
        Me.primary_key._Text = ""
        Me.primary_key.AllowNegative = False
        Me.primary_key.AlwaysDisable = False
        Me.primary_key.AlwaysEnable = False
        Me.primary_key.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.primary_key.BorderColor = System.Drawing.Color.DarkGray
        Me.primary_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.primary_key.DataSource = ""
        Me.primary_key.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.primary_key.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.primary_key.EnabledBackColor = System.Drawing.Color.White
        Me.primary_key.ispk = False
        Me.primary_key.Location = New System.Drawing.Point(253, 32)
        Me.primary_key.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.primary_key.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.MultiLine = False
        Me.primary_key.Name = "primary_key"
        Me.primary_key.NoClear = False
        Me.primary_key.NumberFormat = "@"
        Me.primary_key.Required = False
        Me.primary_key.RowData = Nothing
        Me.primary_key.SelectionLength = 0
        Me.primary_key.SelectionStart = 0
        Me.primary_key.Size = New System.Drawing.Size(88, 16)
        Me.primary_key.TabIndex = 2
        Me.primary_key.TableData = Nothing
        Me.primary_key.TextSource = ""
        Me.primary_key.UseSystemPasswordChar = False
        Me.primary_key.Value = ""
        Me.primary_key.ValueSource = "default_id"
        Me.primary_key.Visible = False
        '
        'btnAT
        '
        Me.btnAT.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAT.ButtonType = user_control.MyList.ButtonType.ButtonAdd
        Me.btnAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAT.ForeColor = System.Drawing.Color.White
        Me.btnAT.Location = New System.Drawing.Point(502, 68)
        Me.btnAT.Name = "btnAT"
        Me.btnAT.Size = New System.Drawing.Size(80, 24)
        Me.btnAT.TabIndex = 7
        Me.btnAT.Text = "Audit Trail"
        Me.btnAT.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(15, 62)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(570, 2)
        Me.border1.TabIndex = 3
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'companyconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 461)
        Me.Controls.Add(Me.btnAT)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.primary_key)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "companyconfig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Configuration"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        CType(Me.txt_fiscal_year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents primary_key As user_control.textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_email As user_control.textbox
    Friend WithEvents txt_tel_no As user_control.textbox
    Friend WithEvents txt_fax_no As user_control.textbox
    Friend WithEvents txt_address4 As user_control.textbox
    Friend WithEvents txt_address3 As user_control.textbox
    Friend WithEvents txt_address2 As user_control.textbox
    Friend WithEvents txt_address1 As user_control.textbox
    Friend WithEvents txt_company_code As user_control.textbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_currency_code As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_sys_beg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_company_id As user_control.textbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_filter_code As user_control.textbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_company_name As user_control.textbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_default_id As user_control.textbox
    Friend WithEvents used_in_report As System.Windows.Forms.CheckBox
    Friend WithEvents line_currency As System.Windows.Forms.CheckBox
    Friend WithEvents line_remarks As System.Windows.Forms.CheckBox
    Friend WithEvents w_alloc As System.Windows.Forms.CheckBox
    Friend WithEvents w_dept As System.Windows.Forms.CheckBox
    Friend WithEvents w_proj As System.Windows.Forms.CheckBox
    Friend WithEvents monthly_currency As System.Windows.Forms.CheckBox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents txt_rdo_code As user_control.textbox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_decimal_places As user_control.textbox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_tin As user_control.myMaskedTextBox
    Friend WithEvents general_auto_number As System.Windows.Forms.CheckBox
    Friend WithEvents btnAT As user_control.MyButton
    Friend WithEvents txt_retained_account_id As user_control.textbox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_fiscal_year As Windows.Forms.NumericUpDown
    Friend WithEvents txt_fiscal_month As Windows.Forms.ComboBox
    Friend WithEvents isFiscal As Windows.Forms.CheckBox
    Friend WithEvents txt_forex_account_id As user_control.textbox
    Friend WithEvents Label15 As Windows.Forms.Label
End Class
