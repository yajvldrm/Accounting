<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class soa
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
        Me.toDate = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_dept = New user_control.MyTextBox()
        Me.btn_notes = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_proj = New user_control.MyTextBox()
        Me.txt_currency = New user_control.MyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_account = New user_control.MyTextBox()
        Me.txt_client = New user_control.MyTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.printoption = New System.Windows.Forms.Panel()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_category = New System.Windows.Forms.ComboBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.printoption.SuspendLayout()
        Me.SuspendLayout()
        '
        'toDate
        '
        Me.toDate.AutoSize = True
        Me.toDate.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.toDate.Location = New System.Drawing.Point(30, 66)
        Me.toDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(64, 17)
        Me.toDate.TabIndex = 1
        Me.toDate.Text = "To Date"
        Me.toDate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 24)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Statement of Accounts"
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(51, 234)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 273
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        Me.btnExcel.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(213, 234)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(132, 234)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_dept)
        Me.GroupBox2.Controls.Add(Me.btn_notes)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_proj)
        Me.GroupBox2.Controls.Add(Me.txt_currency)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_account)
        Me.GroupBox2.Controls.Add(Me.txt_client)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 100)
        Me.GroupBox2.TabIndex = 270
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(139, 70)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 278
        Me.Label9.Text = "(per page)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(54, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "NOTES"
        '
        'txt_dept
        '
        Me.txt_dept.AlwaysDisable = False
        Me.txt_dept.AlwaysEnable = False
        Me.txt_dept.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_dept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dept.BrowseDataSource = "lib_erp_department"
        Me.txt_dept.BrowseField = "department_code,department_name"
        Me.txt_dept.BrowseFilter = Nothing
        Me.txt_dept.BrowseLabel = "Code,Name"
        Me.txt_dept.BrowseLabelWidth = "100,200"
        Me.txt_dept.BrowseTextSource = "department_code"
        Me.txt_dept.BrowseValueSource = "department_id"
        Me.txt_dept.Database = user_control.MyList.Database.FileSetup
        Me.txt_dept.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_dept.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_dept.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_dept.Enabled = False
        Me.txt_dept.EnabledBackColor = System.Drawing.Color.White
        Me.txt_dept.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_dept.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_dept.ID = False
        Me.txt_dept.Location = New System.Drawing.Point(289, 66)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.NoClear = False
        Me.txt_dept.NoSave = False
        Me.txt_dept.NumberFormat = "@"
        Me.txt_dept.Required = False
        Me.txt_dept.RowData = Nothing
        Me.txt_dept.Size = New System.Drawing.Size(100, 20)
        Me.txt_dept.TabIndex = 8
        Me.txt_dept.TextBrowse = True
        Me.txt_dept.TextSource = "department_code"
        Me.txt_dept.ToUpper = True
        Me.txt_dept.Unique = False
        Me.txt_dept.Value = ""
        Me.txt_dept.ValueSource = "department_id"
        '
        'btn_notes
        '
        Me.btn_notes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_notes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_notes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_notes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_notes.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_notes.ForeColor = System.Drawing.Color.Black
        Me.btn_notes.Location = New System.Drawing.Point(99, 66)
        Me.btn_notes.Name = "btn_notes"
        Me.btn_notes.Size = New System.Drawing.Size(35, 20)
        Me.btn_notes.TabIndex = 5
        Me.btn_notes.Text = "* * *"
        Me.btn_notes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_notes.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label8.Location = New System.Drawing.Point(211, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 262
        Me.Label8.Text = "DEPARTMENT"
        '
        'txt_proj
        '
        Me.txt_proj.AlwaysDisable = False
        Me.txt_proj.AlwaysEnable = False
        Me.txt_proj.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_proj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_proj.BrowseDataSource = "lib_erp_project"
        Me.txt_proj.BrowseField = "project_code,project_name"
        Me.txt_proj.BrowseFilter = Nothing
        Me.txt_proj.BrowseLabel = "Code,Name"
        Me.txt_proj.BrowseLabelWidth = "100,200"
        Me.txt_proj.BrowseTextSource = "project_code"
        Me.txt_proj.BrowseValueSource = "project_id"
        Me.txt_proj.Database = user_control.MyList.Database.FileSetup
        Me.txt_proj.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_proj.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_proj.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_proj.Enabled = False
        Me.txt_proj.EnabledBackColor = System.Drawing.Color.White
        Me.txt_proj.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_proj.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_proj.ID = False
        Me.txt_proj.Location = New System.Drawing.Point(289, 43)
        Me.txt_proj.Name = "txt_proj"
        Me.txt_proj.NoClear = False
        Me.txt_proj.NoSave = False
        Me.txt_proj.NumberFormat = "@"
        Me.txt_proj.Required = False
        Me.txt_proj.RowData = Nothing
        Me.txt_proj.Size = New System.Drawing.Size(100, 20)
        Me.txt_proj.TabIndex = 7
        Me.txt_proj.TextBrowse = True
        Me.txt_proj.TextSource = "project_code"
        Me.txt_proj.ToUpper = True
        Me.txt_proj.Unique = False
        Me.txt_proj.Value = ""
        Me.txt_proj.ValueSource = "project_id"
        '
        'txt_currency
        '
        Me.txt_currency.AlwaysDisable = False
        Me.txt_currency.AlwaysEnable = False
        Me.txt_currency.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency.BrowseDataSource = "lib_erp_currency"
        Me.txt_currency.BrowseField = "currency_code,currency_name"
        Me.txt_currency.BrowseFilter = Nothing
        Me.txt_currency.BrowseLabel = "Code,Name"
        Me.txt_currency.BrowseLabelWidth = "100,200"
        Me.txt_currency.BrowseTextSource = "currency_code"
        Me.txt_currency.BrowseValueSource = "currency_id"
        Me.txt_currency.Database = user_control.MyList.Database.FileSetup
        Me.txt_currency.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency.Enabled = False
        Me.txt_currency.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_currency.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency.ID = False
        Me.txt_currency.Location = New System.Drawing.Point(289, 20)
        Me.txt_currency.Name = "txt_currency"
        Me.txt_currency.NoClear = False
        Me.txt_currency.NoSave = False
        Me.txt_currency.NumberFormat = "@"
        Me.txt_currency.Required = False
        Me.txt_currency.RowData = Nothing
        Me.txt_currency.Size = New System.Drawing.Size(100, 20)
        Me.txt_currency.TabIndex = 6
        Me.txt_currency.TextBrowse = True
        Me.txt_currency.TextSource = "currency_code"
        Me.txt_currency.ToUpper = True
        Me.txt_currency.Unique = False
        Me.txt_currency.Value = ""
        Me.txt_currency.ValueSource = "currency_id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label6.Location = New System.Drawing.Point(223, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 258
        Me.Label6.Text = "CURRENCY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label7.Location = New System.Drawing.Point(232, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 259
        Me.Label7.Text = "PROJECT"
        '
        'txt_account
        '
        Me.txt_account.AlwaysDisable = False
        Me.txt_account.AlwaysEnable = False
        Me.txt_account.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account.BrowseDataSource = "lib_erp_chart"
        Me.txt_account.BrowseField = "account_code,account_name"
        Me.txt_account.BrowseFilter = Nothing
        Me.txt_account.BrowseLabel = "Code,Name"
        Me.txt_account.BrowseLabelWidth = "100,200"
        Me.txt_account.BrowseTextSource = "account_code"
        Me.txt_account.BrowseValueSource = "account_id"
        Me.txt_account.Database = user_control.MyList.Database.FileSetup
        Me.txt_account.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account.Enabled = False
        Me.txt_account.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_account.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account.ID = False
        Me.txt_account.Location = New System.Drawing.Point(99, 43)
        Me.txt_account.Name = "txt_account"
        Me.txt_account.NoClear = False
        Me.txt_account.NoSave = False
        Me.txt_account.NumberFormat = "@"
        Me.txt_account.Required = False
        Me.txt_account.RowData = Nothing
        Me.txt_account.Size = New System.Drawing.Size(100, 20)
        Me.txt_account.TabIndex = 4
        Me.txt_account.TextBrowse = True
        Me.txt_account.TextSource = "account_code"
        Me.txt_account.ToUpper = True
        Me.txt_account.Unique = False
        Me.txt_account.Value = ""
        Me.txt_account.ValueSource = "account_id"
        '
        'txt_client
        '
        Me.txt_client.AlwaysDisable = False
        Me.txt_client.AlwaysEnable = False
        Me.txt_client.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_client.BrowseDataSource = "lib_erp_general"
        Me.txt_client.BrowseField = "general_code,general_name"
        Me.txt_client.BrowseFilter = Nothing
        Me.txt_client.BrowseLabel = "Code,Name"
        Me.txt_client.BrowseLabelWidth = "100,200"
        Me.txt_client.BrowseTextSource = "general_code"
        Me.txt_client.BrowseValueSource = "general_id"
        Me.txt_client.Database = user_control.MyList.Database.FileSetup
        Me.txt_client.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_client.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_client.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_client.Enabled = False
        Me.txt_client.EnabledBackColor = System.Drawing.Color.White
        Me.txt_client.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_client.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_client.ID = False
        Me.txt_client.Location = New System.Drawing.Point(99, 20)
        Me.txt_client.Name = "txt_client"
        Me.txt_client.NoClear = False
        Me.txt_client.NoSave = False
        Me.txt_client.NumberFormat = "@"
        Me.txt_client.Required = False
        Me.txt_client.RowData = Nothing
        Me.txt_client.Size = New System.Drawing.Size(100, 20)
        Me.txt_client.TabIndex = 3
        Me.txt_client.TextBrowse = True
        Me.txt_client.TextSource = "general_code"
        Me.txt_client.ToUpper = True
        Me.txt_client.Unique = False
        Me.txt_client.Value = ""
        Me.txt_client.ValueSource = "general_id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(21, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "CLIENT CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(7, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 255
        Me.Label3.Text = "ACCOUNT CODE"
        '
        'printoption
        '
        Me.printoption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.printoption.Controls.Add(Me.txt_date_from)
        Me.printoption.Controls.Add(Me.Label14)
        Me.printoption.Controls.Add(Me.Label13)
        Me.printoption.Controls.Add(Me.txt_date_to)
        Me.printoption.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.printoption.Location = New System.Drawing.Point(11, 91)
        Me.printoption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.printoption.Name = "printoption"
        Me.printoption.Size = New System.Drawing.Size(398, 30)
        Me.printoption.TabIndex = 266
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(87, 4)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(110, 20)
        Me.txt_date_from.TabIndex = 192
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 7)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "Date From"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(211, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "Date To"
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(260, 4)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(110, 20)
        Me.txt_date_to.TabIndex = 194
        '
        'btnPrintOption
        '
        Me.btnPrintOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrintOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrintOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintOption.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(132, 234)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 271
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(134, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "CATEGORY"
        '
        'cbo_category
        '
        Me.cbo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_category.FormattingEnabled = True
        Me.cbo_category.Location = New System.Drawing.Point(201, 63)
        Me.cbo_category.Name = "cbo_category"
        Me.cbo_category.Size = New System.Drawing.Size(200, 21)
        Me.cbo_category.TabIndex = 2
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(420, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.border1.Location = New System.Drawing.Point(15, 58)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(390, 2)
        Me.border1.TabIndex = 250
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(65, 85)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 276
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'soa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 270)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.cbo_category)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.printoption)
        Me.Controls.Add(Me.toDate)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "soa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statement of Account"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.printoption.ResumeLayout(False)
        Me.printoption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents toDate As System.Windows.Forms.CheckBox
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents printoption As System.Windows.Forms.Panel
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_category As System.Windows.Forms.ComboBox
    Friend WithEvents txt_account As user_control.MyTextBox
    Friend WithEvents txt_client As user_control.MyTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_dept As user_control.MyTextBox
    Friend WithEvents btn_notes As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_proj As user_control.MyTextBox
    Friend WithEvents txt_currency As user_control.MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
