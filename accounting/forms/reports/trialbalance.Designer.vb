<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trialbalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trialbalance))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.range_filter = New System.Windows.Forms.Panel()
        Me.rdo3 = New user_control.rdo_button()
        Me.rdo2 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sort_filter = New System.Windows.Forms.GroupBox()
        Me.rdo6 = New user_control.rdo_button()
        Me.rdo5 = New user_control.rdo_button()
        Me.rdo4 = New user_control.rdo_button()
        Me.balance_filter = New System.Windows.Forms.Panel()
        Me.rdo18 = New user_control.rdo_button()
        Me.rdo17 = New user_control.rdo_button()
        Me.rdo16 = New user_control.rdo_button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.currency_filter = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.withComparison = New System.Windows.Forms.CheckBox()
        Me.txt_currency_name = New System.Windows.Forms.Label()
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.checkAllBook = New System.Windows.Forms.CheckBox()
        Me.dgBooks = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupByBook = New System.Windows.Forms.CheckBox()
        Me.groupByUnit = New System.Windows.Forms.CheckBox()
        Me.dgUnit = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.unit_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkAllUnit = New System.Windows.Forms.CheckBox()
        Me.border1 = New accounting.borderedlabel()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.range_filter.SuspendLayout()
        Me.sort_filter.SuspendLayout()
        Me.balance_filter.SuspendLayout()
        Me.currency_filter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_department_filter.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Trial Balance"
        '
        'range_filter
        '
        Me.range_filter.Controls.Add(Me.rdo3)
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Location = New System.Drawing.Point(12, 70)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(426, 30)
        Me.range_filter.TabIndex = 11
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.DataSource = ""
        Me.rdo3.Location = New System.Drawing.Point(235, 7)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(168, 17)
        Me.rdo3.TabIndex = 4
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
        Me.rdo2.Location = New System.Drawing.Point(118, 7)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(100, 17)
        Me.rdo2.TabIndex = 3
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
        Me.rdo1.Location = New System.Drawing.Point(21, 7)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(81, 17)
        Me.rdo1.TabIndex = 2
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Range Only"
        Me.rdo1.TextSource = ""
        Me.rdo1.Uncheckable = False
        Me.rdo1.UseVisualStyleBackColor = True
        Me.rdo1.Value = "1"
        Me.rdo1.ValueSource = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Date From"
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(121, 106)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_from.TabIndex = 5
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(291, 106)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Date To"
        '
        'sort_filter
        '
        Me.sort_filter.Controls.Add(Me.rdo6)
        Me.sort_filter.Controls.Add(Me.rdo5)
        Me.sort_filter.Controls.Add(Me.rdo4)
        Me.sort_filter.Location = New System.Drawing.Point(444, 70)
        Me.sort_filter.Name = "sort_filter"
        Me.sort_filter.Size = New System.Drawing.Size(426, 50)
        Me.sort_filter.TabIndex = 16
        Me.sort_filter.TabStop = False
        Me.sort_filter.Text = "Sort By"
        '
        'rdo6
        '
        Me.rdo6.AutoSize = True
        Me.rdo6.Checked = True
        Me.rdo6.DataSource = ""
        Me.rdo6.Location = New System.Drawing.Point(294, 19)
        Me.rdo6.Name = "rdo6"
        Me.rdo6.Size = New System.Drawing.Size(96, 17)
        Me.rdo6.TabIndex = 9
        Me.rdo6.TabStop = True
        Me.rdo6.Text = "Order By Code"
        Me.rdo6.TextSource = ""
        Me.rdo6.Uncheckable = False
        Me.rdo6.UseVisualStyleBackColor = True
        Me.rdo6.Value = "3"
        Me.rdo6.ValueSource = ""
        '
        'rdo5
        '
        Me.rdo5.AutoSize = True
        Me.rdo5.DataSource = ""
        Me.rdo5.Location = New System.Drawing.Point(164, 19)
        Me.rdo5.Name = "rdo5"
        Me.rdo5.Size = New System.Drawing.Size(73, 17)
        Me.rdo5.TabIndex = 8
        Me.rdo5.Text = "Per Group"
        Me.rdo5.TextSource = ""
        Me.rdo5.Uncheckable = False
        Me.rdo5.UseVisualStyleBackColor = True
        Me.rdo5.Value = "2"
        Me.rdo5.ValueSource = ""
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.DataSource = ""
        Me.rdo4.Location = New System.Drawing.Point(36, 19)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(112, 17)
        Me.rdo4.TabIndex = 7
        Me.rdo4.Text = "By Class Per Code"
        Me.rdo4.TextSource = ""
        Me.rdo4.Uncheckable = False
        Me.rdo4.UseVisualStyleBackColor = True
        Me.rdo4.Value = "1"
        Me.rdo4.ValueSource = ""
        '
        'balance_filter
        '
        Me.balance_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.balance_filter.Controls.Add(Me.rdo18)
        Me.balance_filter.Controls.Add(Me.rdo17)
        Me.balance_filter.Controls.Add(Me.rdo16)
        Me.balance_filter.Location = New System.Drawing.Point(12, 304)
        Me.balance_filter.Name = "balance_filter"
        Me.balance_filter.Size = New System.Drawing.Size(423, 30)
        Me.balance_filter.TabIndex = 19
        '
        'rdo18
        '
        Me.rdo18.AutoSize = True
        Me.rdo18.DataSource = ""
        Me.rdo18.Enabled = False
        Me.rdo18.Location = New System.Drawing.Point(313, 5)
        Me.rdo18.Name = "rdo18"
        Me.rdo18.Size = New System.Drawing.Size(87, 17)
        Me.rdo18.TabIndex = 19
        Me.rdo18.Text = "Per Schedule"
        Me.rdo18.TextSource = ""
        Me.rdo18.Uncheckable = False
        Me.rdo18.UseVisualStyleBackColor = True
        Me.rdo18.Value = "3"
        Me.rdo18.ValueSource = ""
        '
        'rdo17
        '
        Me.rdo17.AutoSize = True
        Me.rdo17.DataSource = ""
        Me.rdo17.Enabled = False
        Me.rdo17.Location = New System.Drawing.Point(159, 5)
        Me.rdo17.Name = "rdo17"
        Me.rdo17.Size = New System.Drawing.Size(138, 17)
        Me.rdo17.TabIndex = 18
        Me.rdo17.Text = "Consolidated per Group"
        Me.rdo17.TextSource = ""
        Me.rdo17.Uncheckable = False
        Me.rdo17.UseVisualStyleBackColor = True
        Me.rdo17.Value = "2"
        Me.rdo17.ValueSource = ""
        '
        'rdo16
        '
        Me.rdo16.AutoSize = True
        Me.rdo16.Checked = True
        Me.rdo16.DataSource = ""
        Me.rdo16.Location = New System.Drawing.Point(21, 5)
        Me.rdo16.Name = "rdo16"
        Me.rdo16.Size = New System.Drawing.Size(121, 17)
        Me.rdo16.TabIndex = 17
        Me.rdo16.TabStop = True
        Me.rdo16.Text = "Normal Trial Balance"
        Me.rdo16.TextSource = ""
        Me.rdo16.Uncheckable = False
        Me.rdo16.UseVisualStyleBackColor = True
        Me.rdo16.Value = "1"
        Me.rdo16.ValueSource = ""
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(442, 341)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 20
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
        Me.btnPrint.Location = New System.Drawing.Point(793, 341)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 214
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'currency_filter
        '
        Me.currency_filter.Controls.Add(Me.Label13)
        Me.currency_filter.Controls.Add(Me.withComparison)
        Me.currency_filter.Controls.Add(Me.txt_currency_name)
        Me.currency_filter.Controls.Add(Me.rdo_currency_2)
        Me.currency_filter.Controls.Add(Me.txt_currency_id)
        Me.currency_filter.Controls.Add(Me.PictureBox2)
        Me.currency_filter.Controls.Add(Me.rdo_currency_1)
        Me.currency_filter.Location = New System.Drawing.Point(12, 132)
        Me.currency_filter.Name = "currency_filter"
        Me.currency_filter.Size = New System.Drawing.Size(426, 70)
        Me.currency_filter.TabIndex = 210
        Me.currency_filter.TabStop = False
        Me.currency_filter.Text = "Currency"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 42)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 202
        Me.Label13.Text = "Currency"
        '
        'withComparison
        '
        Me.withComparison.AutoSize = True
        Me.withComparison.Location = New System.Drawing.Point(270, 20)
        Me.withComparison.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.withComparison.Name = "withComparison"
        Me.withComparison.Size = New System.Drawing.Size(107, 17)
        Me.withComparison.TabIndex = 12
        Me.withComparison.Text = "With Comparison"
        Me.withComparison.UseVisualStyleBackColor = True
        '
        'txt_currency_name
        '
        Me.txt_currency_name.AutoSize = True
        Me.txt_currency_name.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currency_name.ForeColor = System.Drawing.Color.Blue
        Me.txt_currency_name.Location = New System.Drawing.Point(195, 41)
        Me.txt_currency_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txt_currency_name.Name = "txt_currency_name"
        Me.txt_currency_name.Size = New System.Drawing.Size(93, 16)
        Me.txt_currency_name.TabIndex = 188
        Me.txt_currency_name.Text = "Currency Name"
        '
        'rdo_currency_2
        '
        Me.rdo_currency_2.AutoSize = True
        Me.rdo_currency_2.DataSource = ""
        Me.rdo_currency_2.Location = New System.Drawing.Point(157, 19)
        Me.rdo_currency_2.Name = "rdo_currency_2"
        Me.rdo_currency_2.Size = New System.Drawing.Size(108, 17)
        Me.rdo_currency_2.TabIndex = 11
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
        Me.txt_currency_id.Location = New System.Drawing.Point(71, 39)
        Me.txt_currency_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.txt_currency_id.TabIndex = 13
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.TextSource = ""
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(175, 41)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.rdo_currency_1.Location = New System.Drawing.Point(40, 19)
        Me.rdo_currency_1.Name = "rdo_currency_1"
        Me.rdo_currency_1.Size = New System.Drawing.Size(101, 17)
        Me.rdo_currency_1.TabIndex = 10
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
        Me.project_department_filter.Location = New System.Drawing.Point(12, 208)
        Me.project_department_filter.Name = "project_department_filter"
        Me.project_department_filter.Size = New System.Drawing.Size(426, 90)
        Me.project_department_filter.TabIndex = 211
        Me.project_department_filter.TabStop = False
        Me.project_department_filter.Text = "Project / Department"
        '
        'lbl_department_name
        '
        Me.lbl_department_name.AutoSize = True
        Me.lbl_department_name.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_department_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_department_name.Location = New System.Drawing.Point(199, 63)
        Me.lbl_department_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_department_name.Name = "lbl_department_name"
        Me.lbl_department_name.Size = New System.Drawing.Size(110, 16)
        Me.lbl_department_name.TabIndex = 194
        Me.lbl_department_name.Text = "Department Name"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(179, 63)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 193
        Me.PictureBox5.TabStop = False
        '
        'lbl_project_name
        '
        Me.lbl_project_name.AutoSize = True
        Me.lbl_project_name.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_project_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_project_name.Location = New System.Drawing.Point(199, 41)
        Me.lbl_project_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_project_name.Name = "lbl_project_name"
        Me.lbl_project_name.Size = New System.Drawing.Size(81, 16)
        Me.lbl_project_name.TabIndex = 192
        Me.lbl_project_name.Text = "Project Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(179, 41)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.Label12.Location = New System.Drawing.Point(5, 64)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Department"
        '
        'withProjectDepartment
        '
        Me.withProjectDepartment.AutoSize = True
        Me.withProjectDepartment.Location = New System.Drawing.Point(71, 19)
        Me.withProjectDepartment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.withProjectDepartment.Name = "withProjectDepartment"
        Me.withProjectDepartment.Size = New System.Drawing.Size(152, 17)
        Me.withProjectDepartment.TabIndex = 14
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
        Me.txt_department_id.Location = New System.Drawing.Point(71, 61)
        Me.txt_department_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.txt_department_id.TabIndex = 16
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
        Me.txt_project_id.Location = New System.Drawing.Point(71, 39)
        Me.txt_project_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.txt_project_id.TabIndex = 15
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.TextSource = ""
        Me.txt_project_id.UseSystemPasswordChar = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = ""
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(880, 28)
        Me.Myformheader1.TabIndex = 21
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(712, 341)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 213
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
        Me.btnPrintOption.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(362, 341)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 1
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'checkAllBook
        '
        Me.checkAllBook.AutoSize = True
        Me.checkAllBook.Location = New System.Drawing.Point(453, 133)
        Me.checkAllBook.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllBook.Name = "checkAllBook"
        Me.checkAllBook.Size = New System.Drawing.Size(15, 14)
        Me.checkAllBook.TabIndex = 215
        Me.checkAllBook.UseVisualStyleBackColor = True
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
        Me.dgBooks.Location = New System.Drawing.Point(443, 127)
        Me.dgBooks.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgBooks.MultiSelect = False
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersVisible = False
        Me.dgBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBooks.Size = New System.Drawing.Size(420, 207)
        Me.dgBooks.TabIndex = 216
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
        'groupByBook
        '
        Me.groupByBook.AutoSize = True
        Me.groupByBook.Location = New System.Drawing.Point(668, 132)
        Me.groupByBook.Name = "groupByBook"
        Me.groupByBook.Size = New System.Drawing.Size(191, 17)
        Me.groupByBook.TabIndex = 253
        Me.groupByBook.Text = "Print all Books in Separate Reports"
        Me.groupByBook.UseVisualStyleBackColor = True
        '
        'groupByUnit
        '
        Me.groupByUnit.AutoSize = True
        Me.groupByUnit.Location = New System.Drawing.Point(767, 131)
        Me.groupByUnit.Name = "groupByUnit"
        Me.groupByUnit.Size = New System.Drawing.Size(92, 17)
        Me.groupByUnit.TabIndex = 254
        Me.groupByUnit.Text = "Group by Unit"
        Me.groupByUnit.UseVisualStyleBackColor = True
        Me.groupByUnit.Visible = False
        '
        'dgUnit
        '
        Me.dgUnit.AllowUserToAddRows = False
        Me.dgUnit.AllowUserToDeleteRows = False
        Me.dgUnit.AllowUserToResizeColumns = False
        Me.dgUnit.AllowUserToResizeRows = False
        Me.dgUnit.BackgroundColor = System.Drawing.Color.White
        Me.dgUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgUnit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.unit_name, Me.unit_id})
        Me.dgUnit.EnableHeadersVisualStyles = False
        Me.dgUnit.Location = New System.Drawing.Point(655, 127)
        Me.dgUnit.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgUnit.MultiSelect = False
        Me.dgUnit.Name = "dgUnit"
        Me.dgUnit.RowHeadersVisible = False
        Me.dgUnit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUnit.Size = New System.Drawing.Size(208, 207)
        Me.dgUnit.TabIndex = 255
        Me.dgUnit.Visible = False
        '
        'sel1
        '
        Me.sel1.DataPropertyName = "sel1"
        Me.sel1.FalseValue = "False"
        Me.sel1.HeaderText = ""
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.TrueValue = "True"
        Me.sel1.Width = 32
        '
        'unit_name
        '
        Me.unit_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.unit_name.DataPropertyName = "unit_name"
        Me.unit_name.HeaderText = "Unit"
        Me.unit_name.Name = "unit_name"
        Me.unit_name.ReadOnly = True
        Me.unit_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.unit_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'unit_id
        '
        Me.unit_id.DataPropertyName = "unit_id"
        Me.unit_id.HeaderText = "ID"
        Me.unit_id.Name = "unit_id"
        Me.unit_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.unit_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit_id.Visible = False
        '
        'checkAllUnit
        '
        Me.checkAllUnit.AutoSize = True
        Me.checkAllUnit.Location = New System.Drawing.Point(666, 133)
        Me.checkAllUnit.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllUnit.Name = "checkAllUnit"
        Me.checkAllUnit.Size = New System.Drawing.Size(15, 14)
        Me.checkAllUnit.TabIndex = 256
        Me.checkAllUnit.UseVisualStyleBackColor = True
        Me.checkAllUnit.Visible = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(15, 60)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(853, 2)
        Me.border1.TabIndex = 10
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(295, 140)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 257
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'trialbalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 380)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.groupByBook)
        Me.Controls.Add(Me.checkAllBook)
        Me.Controls.Add(Me.dgBooks)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.project_department_filter)
        Me.Controls.Add(Me.currency_filter)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.balance_filter)
        Me.Controls.Add(Me.sort_filter)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.range_filter)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.groupByUnit)
        Me.Controls.Add(Me.dgUnit)
        Me.Controls.Add(Me.checkAllUnit)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "trialbalance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trial Balance"
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        Me.sort_filter.ResumeLayout(False)
        Me.sort_filter.PerformLayout()
        Me.balance_filter.ResumeLayout(False)
        Me.balance_filter.PerformLayout()
        Me.currency_filter.ResumeLayout(False)
        Me.currency_filter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_department_filter.ResumeLayout(False)
        Me.project_department_filter.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents range_filter As System.Windows.Forms.Panel
    Friend WithEvents rdo3 As user_control.rdo_button
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sort_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo6 As user_control.rdo_button
    Friend WithEvents rdo5 As user_control.rdo_button
    Friend WithEvents rdo4 As user_control.rdo_button
    Friend WithEvents balance_filter As System.Windows.Forms.Panel
    Friend WithEvents rdo18 As user_control.rdo_button
    Friend WithEvents rdo17 As user_control.rdo_button
    Friend WithEvents rdo16 As user_control.rdo_button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents currency_filter As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents withComparison As System.Windows.Forms.CheckBox
    Friend WithEvents txt_currency_name As System.Windows.Forms.Label
    Friend WithEvents rdo_currency_2 As user_control.rdo_button
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents rdo_currency_1 As user_control.rdo_button
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
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents checkAllBook As System.Windows.Forms.CheckBox
    Friend WithEvents dgBooks As System.Windows.Forms.DataGridView
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents groupByBook As System.Windows.Forms.CheckBox
    Friend WithEvents groupByUnit As Windows.Forms.CheckBox
    Friend WithEvents dgUnit As Windows.Forms.DataGridView
    Friend WithEvents checkAllUnit As Windows.Forms.CheckBox
    Friend WithEvents sel1 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents unit_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
