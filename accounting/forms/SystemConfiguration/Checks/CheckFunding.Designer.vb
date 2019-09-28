<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckFunding
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_check_id = New user_control.textbox()
        Me.txt_general_id = New user_control.textbox()
        Me.txt_bank_id = New user_control.textbox()
        Me.txt_trans_id = New user_control.textbox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txt_date_from = New user_control.myDatePicker()
        Me.txt_date_to = New user_control.myDatePicker()
        Me.include = New user_control.MyRadioGroup()
        Me.MyRadioButton3 = New user_control.MyRadioButton()
        Me.MyRadioButton2 = New user_control.MyRadioButton()
        Me.MyRadioButton1 = New user_control.MyRadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.check_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank_name_depository = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.funded = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.funded_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.released = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.isPDC = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.include.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(12, 61)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(200, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update Check Status"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_check_id)
        Me.GroupBox1.Controls.Add(Me.txt_general_id)
        Me.GroupBox1.Controls.Add(Me.txt_bank_id)
        Me.GroupBox1.Controls.Add(Me.txt_trans_id)
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.txt_date_from)
        Me.GroupBox1.Controls.Add(Me.txt_date_to)
        Me.GroupBox1.Controls.Add(Me.include)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 123)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Option"
        '
        'txt_check_id
        '
        Me.txt_check_id._Text = ""
        Me.txt_check_id.AlwaysDisable = False
        Me.txt_check_id.AlwaysEnable = True
        Me.txt_check_id.BackColor = System.Drawing.Color.White
        Me.txt_check_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_check_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_check_id.DataSource = ""
        Me.txt_check_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_check_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_check_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_check_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_check_id.ispk = False
        Me.txt_check_id.Location = New System.Drawing.Point(332, 45)
        Me.txt_check_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_check_id.MultiLine = False
        Me.txt_check_id.Name = "txt_check_id"
        Me.txt_check_id.NoClear = False
        Me.txt_check_id.NumberFormat = "@"
        Me.txt_check_id.Required = False
        Me.txt_check_id.RowData = Nothing
        Me.txt_check_id.SelectionLength = 0
        Me.txt_check_id.SelectionStart = 0
        Me.txt_check_id.Size = New System.Drawing.Size(180, 20)
        Me.txt_check_id.TabIndex = 8
        Me.txt_check_id.TableData = Nothing
        Me.txt_check_id.TextSource = ""
        Me.txt_check_id.UseSystemPasswordChar = False
        Me.txt_check_id.Value = ""
        Me.txt_check_id.ValueSource = ""
        '
        'txt_general_id
        '
        Me.txt_general_id._Text = ""
        Me.txt_general_id.AlwaysDisable = False
        Me.txt_general_id.AlwaysEnable = True
        Me.txt_general_id.BackColor = System.Drawing.Color.White
        Me.txt_general_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.DataSource = ""
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.ispk = False
        Me.txt_general_id.Location = New System.Drawing.Point(571, 45)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(180, 20)
        Me.txt_general_id.TabIndex = 9
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.TextSource = ""
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = ""
        '
        'txt_bank_id
        '
        Me.txt_bank_id._Text = ""
        Me.txt_bank_id.AlwaysDisable = False
        Me.txt_bank_id.AlwaysEnable = True
        Me.txt_bank_id.BackColor = System.Drawing.Color.White
        Me.txt_bank_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bank_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_id.DataSource = ""
        Me.txt_bank_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank_id.ispk = False
        Me.txt_bank_id.Location = New System.Drawing.Point(89, 19)
        Me.txt_bank_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_id.MultiLine = False
        Me.txt_bank_id.Name = "txt_bank_id"
        Me.txt_bank_id.NoClear = False
        Me.txt_bank_id.NumberFormat = "@"
        Me.txt_bank_id.Required = False
        Me.txt_bank_id.RowData = Nothing
        Me.txt_bank_id.SelectionLength = 0
        Me.txt_bank_id.SelectionStart = 0
        Me.txt_bank_id.Size = New System.Drawing.Size(180, 20)
        Me.txt_bank_id.TabIndex = 4
        Me.txt_bank_id.TableData = Nothing
        Me.txt_bank_id.TextSource = ""
        Me.txt_bank_id.UseSystemPasswordChar = False
        Me.txt_bank_id.Value = ""
        Me.txt_bank_id.ValueSource = ""
        '
        'txt_trans_id
        '
        Me.txt_trans_id._Text = ""
        Me.txt_trans_id.AlwaysDisable = False
        Me.txt_trans_id.AlwaysEnable = True
        Me.txt_trans_id.BackColor = System.Drawing.Color.White
        Me.txt_trans_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_id.DataSource = ""
        Me.txt_trans_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_id.ispk = False
        Me.txt_trans_id.Location = New System.Drawing.Point(89, 45)
        Me.txt_trans_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_id.MultiLine = False
        Me.txt_trans_id.Name = "txt_trans_id"
        Me.txt_trans_id.NoClear = False
        Me.txt_trans_id.NumberFormat = "@"
        Me.txt_trans_id.Required = False
        Me.txt_trans_id.RowData = Nothing
        Me.txt_trans_id.SelectionLength = 0
        Me.txt_trans_id.SelectionStart = 0
        Me.txt_trans_id.Size = New System.Drawing.Size(180, 20)
        Me.txt_trans_id.TabIndex = 7
        Me.txt_trans_id.TableData = Nothing
        Me.txt_trans_id.TextSource = ""
        Me.txt_trans_id.UseSystemPasswordChar = False
        Me.txt_trans_id.Value = ""
        Me.txt_trans_id.ValueSource = ""
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(332, 84)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(100, 23)
        Me.btnFilter.TabIndex = 14
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'txt_date_from
        '
        Me.txt_date_from.AlwaysDisable = False
        Me.txt_date_from.AlwaysEnable = True
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(412, 19)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.NoClear = False
        Me.txt_date_from.NoSave = False
        Me.txt_date_from.Required = False
        Me.txt_date_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_from.TabIndex = 5
        Me.txt_date_from.TextSource = ""
        '
        'txt_date_to
        '
        Me.txt_date_to.AlwaysDisable = False
        Me.txt_date_to.AlwaysEnable = True
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(651, 19)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.NoClear = False
        Me.txt_date_to.NoSave = False
        Me.txt_date_to.Required = False
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 6
        Me.txt_date_to.TextSource = ""
        '
        'include
        '
        Me.include.AlwaysDisable = False
        Me.include.AlwaysEnable = True
        Me.include.Controls.Add(Me.MyRadioButton3)
        Me.include.Controls.Add(Me.MyRadioButton2)
        Me.include.Controls.Add(Me.MyRadioButton1)
        Me.include.Location = New System.Drawing.Point(28, 71)
        Me.include.Name = "include"
        Me.include.NoSave = False
        Me.include.Required = False
        Me.include.Size = New System.Drawing.Size(245, 45)
        Me.include.TabIndex = 10
        Me.include.TabStop = False
        Me.include.Text = "Include"
        Me.include.Value = "1"
        Me.include.ValueSource = ""
        '
        'MyRadioButton3
        '
        Me.MyRadioButton3.AlwaysDisable = False
        Me.MyRadioButton3.AlwaysEnable = True
        Me.MyRadioButton3.AutoSize = True
        Me.MyRadioButton3.Location = New System.Drawing.Point(124, 19)
        Me.MyRadioButton3.Name = "MyRadioButton3"
        Me.MyRadioButton3.Size = New System.Drawing.Size(100, 17)
        Me.MyRadioButton3.TabIndex = 13
        Me.MyRadioButton3.Text = "Not Yet Funded"
        Me.MyRadioButton3.Uncheckable = False
        Me.MyRadioButton3.UseVisualStyleBackColor = True
        Me.MyRadioButton3.Value = "3"
        '
        'MyRadioButton2
        '
        Me.MyRadioButton2.AlwaysDisable = False
        Me.MyRadioButton2.AlwaysEnable = True
        Me.MyRadioButton2.AutoSize = True
        Me.MyRadioButton2.Location = New System.Drawing.Point(48, 19)
        Me.MyRadioButton2.Name = "MyRadioButton2"
        Me.MyRadioButton2.Size = New System.Drawing.Size(61, 17)
        Me.MyRadioButton2.TabIndex = 12
        Me.MyRadioButton2.Text = "Funded"
        Me.MyRadioButton2.Uncheckable = False
        Me.MyRadioButton2.UseVisualStyleBackColor = True
        Me.MyRadioButton2.Value = "2"
        '
        'MyRadioButton1
        '
        Me.MyRadioButton1.AlwaysDisable = False
        Me.MyRadioButton1.AlwaysEnable = True
        Me.MyRadioButton1.AutoSize = True
        Me.MyRadioButton1.Checked = True
        Me.MyRadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.MyRadioButton1.Name = "MyRadioButton1"
        Me.MyRadioButton1.Size = New System.Drawing.Size(36, 17)
        Me.MyRadioButton1.TabIndex = 11
        Me.MyRadioButton1.TabStop = True
        Me.MyRadioButton1.Text = "All"
        Me.MyRadioButton1.Uncheckable = False
        Me.MyRadioButton1.UseVisualStyleBackColor = True
        Me.MyRadioButton1.Value = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(532, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Payee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(569, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Check Date To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Check No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Check Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Voucher No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank"
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check_id, Me.bank_name_depository, Me.check_date, Me.trans_no, Me.check_no, Me.general_name, Me.check_amount, Me.funded, Me.funded_date, Me.status, Me.released, Me.isPDC})
        Me.dgMain.Location = New System.Drawing.Point(12, 219)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(826, 269)
        Me.dgMain.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Funding of Checks"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(850, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(218, 61)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 56)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(826, 2)
        Me.border1.TabIndex = 279
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'check_id
        '
        Me.check_id.DataPropertyName = "check_id"
        Me.check_id.HeaderText = "ID"
        Me.check_id.Name = "check_id"
        Me.check_id.Visible = False
        '
        'bank_name_depository
        '
        Me.bank_name_depository.DataPropertyName = "bank_name_depository"
        Me.bank_name_depository.HeaderText = "Bank"
        Me.bank_name_depository.Name = "bank_name_depository"
        Me.bank_name_depository.ReadOnly = True
        '
        'check_date
        '
        Me.check_date.DataPropertyName = "check_date"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "00/00/0000"
        Me.check_date.DefaultCellStyle = DataGridViewCellStyle1
        Me.check_date.HeaderText = "Check Date"
        Me.check_date.Name = "check_date"
        Me.check_date.ReadOnly = True
        Me.check_date.Width = 80
        '
        'trans_no
        '
        Me.trans_no.DataPropertyName = "trans_no"
        Me.trans_no.HeaderText = "Check Voucher No"
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        '
        'check_no
        '
        Me.check_no.DataPropertyName = "check_no"
        Me.check_no.HeaderText = "Check No"
        Me.check_no.Name = "check_no"
        Me.check_no.ReadOnly = True
        '
        'general_name
        '
        Me.general_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Payee"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        '
        'check_amount
        '
        Me.check_amount.DataPropertyName = "check_amount"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.check_amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.check_amount.HeaderText = "Amount"
        Me.check_amount.Name = "check_amount"
        Me.check_amount.ReadOnly = True
        '
        'funded
        '
        Me.funded.DataPropertyName = "funded"
        Me.funded.FalseValue = "0"
        Me.funded.HeaderText = "Funded"
        Me.funded.Name = "funded"
        Me.funded.TrueValue = "1"
        Me.funded.Width = 55
        '
        'funded_date
        '
        Me.funded_date.DataPropertyName = "funded_date"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = "00/00/0000"
        Me.funded_date.DefaultCellStyle = DataGridViewCellStyle3
        Me.funded_date.HeaderText = "Date"
        Me.funded_date.Name = "funded_date"
        Me.funded_date.Width = 75
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 80
        '
        'released
        '
        Me.released.DataPropertyName = "released"
        Me.released.FalseValue = "0"
        Me.released.HeaderText = "released"
        Me.released.Name = "released"
        Me.released.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.released.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.released.TrueValue = "1"
        Me.released.Visible = False
        '
        'isPDC
        '
        Me.isPDC.DataPropertyName = "isPDC"
        Me.isPDC.HeaderText = "PDC"
        Me.isPDC.Name = "isPDC"
        Me.isPDC.ReadOnly = True
        Me.isPDC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.isPDC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.isPDC.Width = 32
        '
        'CheckFunding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 500)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckFunding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funding of Checks"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.include.ResumeLayout(False)
        Me.include.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents txt_date_from As user_control.myDatePicker
    Friend WithEvents txt_date_to As user_control.myDatePicker
    Friend WithEvents include As user_control.MyRadioGroup
    Friend WithEvents MyRadioButton3 As user_control.MyRadioButton
    Friend WithEvents MyRadioButton2 As user_control.MyRadioButton
    Friend WithEvents MyRadioButton1 As user_control.MyRadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_check_id As user_control.textbox
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents txt_bank_id As user_control.textbox
    Friend WithEvents txt_trans_id As user_control.textbox
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents check_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_name_depository As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents funded As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents funded_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents released As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents isPDC As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
