<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ewtreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ewtreport))
        Me.txt_year = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.report_option_filter = New System.Windows.Forms.GroupBox()
        Me.btnDiskette = New System.Windows.Forms.Button()
        Me.quarter_filter = New System.Windows.Forms.GroupBox()
        Me.Rdo_button4 = New user_control.rdo_button()
        Me.Rdo_button3 = New user_control.rdo_button()
        Me.Rdo_button2 = New user_control.rdo_button()
        Me.Rdo_button1 = New user_control.rdo_button()
        Me.by_filter = New System.Windows.Forms.GroupBox()
        Me.Rdo_button5 = New user_control.rdo_button()
        Me.Rdo_button6 = New user_control.rdo_button()
        Me.txt_filter_option = New user_control.textbox()
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
        Me.currency_filter = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.withComparison = New System.Windows.Forms.CheckBox()
        Me.lbl_currency_name = New System.Windows.Forms.Label()
        Me.rdo_currency_2 = New user_control.rdo_button()
        Me.txt_currency_id = New user_control.textbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rdo_currency_1 = New user_control.rdo_button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_ewt = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txt_ewt_id = New user_control.textbox()
        Me.txt_print_option = New user_control.textbox()
        Me.txt_month = New user_control.monthselector()
        Me.Myformheader1 = New user_control.myformheader()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.txt_year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.report_option_filter.SuspendLayout()
        Me.quarter_filter.SuspendLayout()
        Me.by_filter.SuspendLayout()
        Me.project_department_filter.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.currency_filter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_year.Location = New System.Drawing.Point(313, 174)
        Me.txt_year.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(70, 20)
        Me.txt_year.TabIndex = 3
        Me.txt_year.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Expanded Withholding Tax Report"
        '
        'report_option_filter
        '
        Me.report_option_filter.Controls.Add(Me.btnDiskette)
        Me.report_option_filter.Controls.Add(Me.quarter_filter)
        Me.report_option_filter.Controls.Add(Me.by_filter)
        Me.report_option_filter.Controls.Add(Me.txt_filter_option)
        Me.report_option_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.report_option_filter.Location = New System.Drawing.Point(13, 66)
        Me.report_option_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.report_option_filter.Name = "report_option_filter"
        Me.report_option_filter.Padding = New System.Windows.Forms.Padding(4)
        Me.report_option_filter.Size = New System.Drawing.Size(474, 100)
        Me.report_option_filter.TabIndex = 211
        Me.report_option_filter.TabStop = False
        Me.report_option_filter.Text = "Report Option"
        '
        'btnDiskette
        '
        Me.btnDiskette.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDiskette.BackgroundImage = Global.accounting.My.Resources.Resources.diskette
        Me.btnDiskette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDiskette.Enabled = False
        Me.btnDiskette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDiskette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnDiskette.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiskette.Location = New System.Drawing.Point(396, 21)
        Me.btnDiskette.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDiskette.Name = "btnDiskette"
        Me.btnDiskette.Size = New System.Drawing.Size(70, 20)
        Me.btnDiskette.TabIndex = 218
        Me.btnDiskette.UseVisualStyleBackColor = False
        '
        'quarter_filter
        '
        Me.quarter_filter.Controls.Add(Me.Rdo_button4)
        Me.quarter_filter.Controls.Add(Me.Rdo_button3)
        Me.quarter_filter.Controls.Add(Me.Rdo_button2)
        Me.quarter_filter.Controls.Add(Me.Rdo_button1)
        Me.quarter_filter.Location = New System.Drawing.Point(37, 50)
        Me.quarter_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.quarter_filter.Name = "quarter_filter"
        Me.quarter_filter.Padding = New System.Windows.Forms.Padding(4)
        Me.quarter_filter.Size = New System.Drawing.Size(400, 40)
        Me.quarter_filter.TabIndex = 216
        Me.quarter_filter.TabStop = False
        Me.quarter_filter.Visible = False
        '
        'Rdo_button4
        '
        Me.Rdo_button4.AutoSize = True
        Me.Rdo_button4.DataSource = ""
        Me.Rdo_button4.Location = New System.Drawing.Point(302, 14)
        Me.Rdo_button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Rdo_button4.Name = "Rdo_button4"
        Me.Rdo_button4.Size = New System.Drawing.Size(82, 17)
        Me.Rdo_button4.TabIndex = 3
        Me.Rdo_button4.Text = "4th Quarter"
        Me.Rdo_button4.TextSource = ""
        Me.Rdo_button4.Uncheckable = False
        Me.Rdo_button4.UseVisualStyleBackColor = True
        Me.Rdo_button4.Value = "4"
        Me.Rdo_button4.ValueSource = ""
        '
        'Rdo_button3
        '
        Me.Rdo_button3.AutoSize = True
        Me.Rdo_button3.DataSource = ""
        Me.Rdo_button3.Location = New System.Drawing.Point(207, 14)
        Me.Rdo_button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Rdo_button3.Name = "Rdo_button3"
        Me.Rdo_button3.Size = New System.Drawing.Size(82, 17)
        Me.Rdo_button3.TabIndex = 2
        Me.Rdo_button3.Text = "3rd Quarter"
        Me.Rdo_button3.TextSource = ""
        Me.Rdo_button3.Uncheckable = False
        Me.Rdo_button3.UseVisualStyleBackColor = True
        Me.Rdo_button3.Value = "3"
        Me.Rdo_button3.ValueSource = ""
        '
        'Rdo_button2
        '
        Me.Rdo_button2.AutoSize = True
        Me.Rdo_button2.DataSource = ""
        Me.Rdo_button2.Location = New System.Drawing.Point(110, 14)
        Me.Rdo_button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Rdo_button2.Name = "Rdo_button2"
        Me.Rdo_button2.Size = New System.Drawing.Size(84, 17)
        Me.Rdo_button2.TabIndex = 1
        Me.Rdo_button2.Text = "2nd Quarter"
        Me.Rdo_button2.TextSource = ""
        Me.Rdo_button2.Uncheckable = False
        Me.Rdo_button2.UseVisualStyleBackColor = True
        Me.Rdo_button2.Value = "2"
        Me.Rdo_button2.ValueSource = ""
        '
        'Rdo_button1
        '
        Me.Rdo_button1.AutoSize = True
        Me.Rdo_button1.Checked = True
        Me.Rdo_button1.DataSource = ""
        Me.Rdo_button1.Location = New System.Drawing.Point(16, 14)
        Me.Rdo_button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Rdo_button1.Name = "Rdo_button1"
        Me.Rdo_button1.Size = New System.Drawing.Size(81, 17)
        Me.Rdo_button1.TabIndex = 0
        Me.Rdo_button1.TabStop = True
        Me.Rdo_button1.Text = "1st Quarter"
        Me.Rdo_button1.TextSource = ""
        Me.Rdo_button1.Uncheckable = False
        Me.Rdo_button1.UseVisualStyleBackColor = True
        Me.Rdo_button1.Value = "1"
        Me.Rdo_button1.ValueSource = ""
        '
        'by_filter
        '
        Me.by_filter.Controls.Add(Me.Rdo_button5)
        Me.by_filter.Controls.Add(Me.Rdo_button6)
        Me.by_filter.Location = New System.Drawing.Point(121, 50)
        Me.by_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.by_filter.Name = "by_filter"
        Me.by_filter.Padding = New System.Windows.Forms.Padding(4)
        Me.by_filter.Size = New System.Drawing.Size(197, 39)
        Me.by_filter.TabIndex = 217
        Me.by_filter.TabStop = False
        Me.by_filter.Visible = False
        '
        'Rdo_button5
        '
        Me.Rdo_button5.AutoSize = True
        Me.Rdo_button5.DataSource = ""
        Me.Rdo_button5.Location = New System.Drawing.Point(108, 13)
        Me.Rdo_button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Rdo_button5.Name = "Rdo_button5"
        Me.Rdo_button5.Size = New System.Drawing.Size(67, 17)
        Me.Rdo_button5.TabIndex = 3
        Me.Rdo_button5.Text = "By Detail"
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
        Me.Rdo_button6.Location = New System.Drawing.Point(16, 13)
        Me.Rdo_button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Rdo_button6.Name = "Rdo_button6"
        Me.Rdo_button6.Size = New System.Drawing.Size(64, 17)
        Me.Rdo_button6.TabIndex = 2
        Me.Rdo_button6.TabStop = True
        Me.Rdo_button6.Text = "By Total"
        Me.Rdo_button6.TextSource = ""
        Me.Rdo_button6.Uncheckable = False
        Me.Rdo_button6.UseVisualStyleBackColor = True
        Me.Rdo_button6.Value = "1"
        Me.Rdo_button6.ValueSource = ""
        '
        'txt_filter_option
        '
        Me.txt_filter_option._Text = ""
        Me.txt_filter_option.AllowNegative = False
        Me.txt_filter_option.AlwaysDisable = False
        Me.txt_filter_option.AlwaysEnable = False
        Me.txt_filter_option.BackColor = System.Drawing.Color.White
        Me.txt_filter_option.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filter_option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filter_option.DataSource = ""
        Me.txt_filter_option.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_option.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_option.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filter_option.EnabledBackColor = System.Drawing.Color.White
        Me.txt_filter_option.ispk = False
        Me.txt_filter_option.Location = New System.Drawing.Point(6, 21)
        Me.txt_filter_option.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_filter_option.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_option.MultiLine = False
        Me.txt_filter_option.Name = "txt_filter_option"
        Me.txt_filter_option.NoClear = False
        Me.txt_filter_option.NumberFormat = "@"
        Me.txt_filter_option.Required = False
        Me.txt_filter_option.RowData = Nothing
        Me.txt_filter_option.SelectionLength = 0
        Me.txt_filter_option.SelectionStart = 0
        Me.txt_filter_option.Size = New System.Drawing.Size(384, 19)
        Me.txt_filter_option.TabIndex = 1
        Me.txt_filter_option.TableData = Nothing
        Me.txt_filter_option.TextSource = ""
        Me.txt_filter_option.UseSystemPasswordChar = False
        Me.txt_filter_option.Value = ""
        Me.txt_filter_option.ValueSource = ""
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
        Me.project_department_filter.Location = New System.Drawing.Point(14, 331)
        Me.project_department_filter.Margin = New System.Windows.Forms.Padding(5)
        Me.project_department_filter.Name = "project_department_filter"
        Me.project_department_filter.Padding = New System.Windows.Forms.Padding(5)
        Me.project_department_filter.Size = New System.Drawing.Size(472, 90)
        Me.project_department_filter.TabIndex = 213
        Me.project_department_filter.TabStop = False
        Me.project_department_filter.Text = "Project / Department"
        '
        'lbl_department_name
        '
        Me.lbl_department_name.AutoSize = True
        Me.lbl_department_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_department_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_department_name.Location = New System.Drawing.Point(214, 65)
        Me.lbl_department_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_department_name.Name = "lbl_department_name"
        Me.lbl_department_name.Size = New System.Drawing.Size(110, 16)
        Me.lbl_department_name.TabIndex = 194
        Me.lbl_department_name.Text = "Department Name"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(194, 65)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
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
        Me.lbl_project_name.Location = New System.Drawing.Point(214, 40)
        Me.lbl_project_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_project_name.Name = "lbl_project_name"
        Me.lbl_project_name.Size = New System.Drawing.Size(81, 16)
        Me.lbl_project_name.TabIndex = 192
        Me.lbl_project_name.Text = "Project Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(194, 42)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 191
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Project"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 65)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Department"
        '
        'withProjectDepartment
        '
        Me.withProjectDepartment.AutoSize = True
        Me.withProjectDepartment.Location = New System.Drawing.Point(90, 18)
        Me.withProjectDepartment.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
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
        Me.txt_department_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department_id.ispk = False
        Me.txt_department_id.Location = New System.Drawing.Point(90, 62)
        Me.txt_department_id.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
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
        Me.txt_project_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_id.ispk = False
        Me.txt_project_id.Location = New System.Drawing.Point(90, 40)
        Me.txt_project_id.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
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
        'currency_filter
        '
        Me.currency_filter.Controls.Add(Me.Label13)
        Me.currency_filter.Controls.Add(Me.withComparison)
        Me.currency_filter.Controls.Add(Me.lbl_currency_name)
        Me.currency_filter.Controls.Add(Me.rdo_currency_2)
        Me.currency_filter.Controls.Add(Me.txt_currency_id)
        Me.currency_filter.Controls.Add(Me.PictureBox2)
        Me.currency_filter.Controls.Add(Me.rdo_currency_1)
        Me.currency_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.currency_filter.Location = New System.Drawing.Point(14, 251)
        Me.currency_filter.Margin = New System.Windows.Forms.Padding(5)
        Me.currency_filter.Name = "currency_filter"
        Me.currency_filter.Padding = New System.Windows.Forms.Padding(5)
        Me.currency_filter.Size = New System.Drawing.Size(472, 70)
        Me.currency_filter.TabIndex = 212
        Me.currency_filter.TabStop = False
        Me.currency_filter.Text = "Currency"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 42)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 202
        Me.Label13.Text = "Currency"
        '
        'withComparison
        '
        Me.withComparison.AutoSize = True
        Me.withComparison.Enabled = False
        Me.withComparison.Location = New System.Drawing.Point(301, 17)
        Me.withComparison.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.withComparison.Name = "withComparison"
        Me.withComparison.Size = New System.Drawing.Size(107, 17)
        Me.withComparison.TabIndex = 12
        Me.withComparison.Text = "With Comparison"
        Me.withComparison.UseVisualStyleBackColor = True
        '
        'lbl_currency_name
        '
        Me.lbl_currency_name.AutoSize = True
        Me.lbl_currency_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_currency_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_currency_name.Location = New System.Drawing.Point(214, 42)
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
        Me.rdo_currency_2.Location = New System.Drawing.Point(186, 17)
        Me.rdo_currency_2.Margin = New System.Windows.Forms.Padding(5)
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
        Me.txt_currency_id.Location = New System.Drawing.Point(90, 39)
        Me.txt_currency_id.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
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
        Me.PictureBox2.Location = New System.Drawing.Point(194, 42)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
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
        Me.rdo_currency_1.Location = New System.Drawing.Point(65, 17)
        Me.rdo_currency_1.Margin = New System.Windows.Forms.Padding(5)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(117, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "For the Month of"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(141, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 219
        Me.Label5.Text = "Print Option"
        '
        'lbl_ewt
        '
        Me.lbl_ewt.AutoSize = True
        Me.lbl_ewt.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lbl_ewt.Location = New System.Drawing.Point(164, 226)
        Me.lbl_ewt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ewt.Name = "lbl_ewt"
        Me.lbl_ewt.Size = New System.Drawing.Size(41, 13)
        Me.lbl_ewt.TabIndex = 220
        Me.lbl_ewt.Text = "E.W.T."
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(252, 431)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(173, 431)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'txt_ewt_id
        '
        Me.txt_ewt_id._Text = ""
        Me.txt_ewt_id.AllowNegative = False
        Me.txt_ewt_id.AlwaysDisable = False
        Me.txt_ewt_id.AlwaysEnable = False
        Me.txt_ewt_id.BackColor = System.Drawing.Color.White
        Me.txt_ewt_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_ewt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ewt_id.DataSource = ""
        Me.txt_ewt_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ewt_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ewt_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ewt_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_ewt_id.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_ewt_id.ispk = False
        Me.txt_ewt_id.Location = New System.Drawing.Point(209, 222)
        Me.txt_ewt_id.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_ewt_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ewt_id.MultiLine = False
        Me.txt_ewt_id.Name = "txt_ewt_id"
        Me.txt_ewt_id.NoClear = False
        Me.txt_ewt_id.NumberFormat = "@"
        Me.txt_ewt_id.Required = False
        Me.txt_ewt_id.RowData = Nothing
        Me.txt_ewt_id.SelectionLength = 0
        Me.txt_ewt_id.SelectionStart = 0
        Me.txt_ewt_id.Size = New System.Drawing.Size(174, 20)
        Me.txt_ewt_id.TabIndex = 5
        Me.txt_ewt_id.TableData = Nothing
        Me.txt_ewt_id.TextSource = ""
        Me.txt_ewt_id.UseSystemPasswordChar = False
        Me.txt_ewt_id.Value = ""
        Me.txt_ewt_id.ValueSource = ""
        '
        'txt_print_option
        '
        Me.txt_print_option._Text = ""
        Me.txt_print_option.AllowNegative = False
        Me.txt_print_option.AlwaysDisable = False
        Me.txt_print_option.AlwaysEnable = False
        Me.txt_print_option.BackColor = System.Drawing.Color.White
        Me.txt_print_option.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_print_option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_print_option.DataSource = ""
        Me.txt_print_option.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_print_option.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_print_option.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_print_option.EnabledBackColor = System.Drawing.Color.White
        Me.txt_print_option.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_print_option.ispk = False
        Me.txt_print_option.Location = New System.Drawing.Point(209, 198)
        Me.txt_print_option.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_print_option.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_print_option.MultiLine = False
        Me.txt_print_option.Name = "txt_print_option"
        Me.txt_print_option.NoClear = False
        Me.txt_print_option.NumberFormat = "@"
        Me.txt_print_option.Required = False
        Me.txt_print_option.RowData = Nothing
        Me.txt_print_option.SelectionLength = 0
        Me.txt_print_option.SelectionStart = 0
        Me.txt_print_option.Size = New System.Drawing.Size(174, 20)
        Me.txt_print_option.TabIndex = 4
        Me.txt_print_option.TableData = Nothing
        Me.txt_print_option.TextSource = ""
        Me.txt_print_option.UseSystemPasswordChar = False
        Me.txt_print_option.Value = ""
        Me.txt_print_option.ValueSource = ""
        '
        'txt_month
        '
        Me.txt_month.DicItems = CType(resources.GetObject("txt_month.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.txt_month.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_month.Location = New System.Drawing.Point(209, 174)
        Me.txt_month.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_month.Maximum = 12
        Me.txt_month.Minimum = 1
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(100, 20)
        Me.txt_month.TabIndex = 2
        Me.txt_month.Value = "1"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Margin = New System.Windows.Forms.Padding(4)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 221
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(173, 431)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 7
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        Me.btnExcel.Visible = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.border1.Location = New System.Drawing.Point(13, 60)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(475, 2)
        Me.border1.TabIndex = 18
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ewtreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 470)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lbl_ewt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_ewt_id)
        Me.Controls.Add(Me.txt_print_option)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.project_department_filter)
        Me.Controls.Add(Me.currency_filter)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_month)
        Me.Controls.Add(Me.report_option_filter)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExcel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ewtreport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expanded Withholding Tax Report"
        CType(Me.txt_year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.report_option_filter.ResumeLayout(False)
        Me.quarter_filter.ResumeLayout(False)
        Me.quarter_filter.PerformLayout()
        Me.by_filter.ResumeLayout(False)
        Me.by_filter.PerformLayout()
        Me.project_department_filter.ResumeLayout(False)
        Me.project_department_filter.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.currency_filter.ResumeLayout(False)
        Me.currency_filter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_year As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents report_option_filter As System.Windows.Forms.GroupBox
    Friend WithEvents txt_filter_option As user_control.textbox
    Friend WithEvents by_filter As System.Windows.Forms.GroupBox
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
    Friend WithEvents currency_filter As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents withComparison As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_currency_name As System.Windows.Forms.Label
    Friend WithEvents rdo_currency_2 As user_control.rdo_button
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents rdo_currency_1 As user_control.rdo_button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_print_option As user_control.textbox
    Friend WithEvents txt_ewt_id As user_control.textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_ewt As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Rdo_button5 As user_control.rdo_button
    Friend WithEvents Rdo_button6 As user_control.rdo_button
    Friend WithEvents txt_month As user_control.monthselector
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnDiskette As System.Windows.Forms.Button
    Friend WithEvents quarter_filter As System.Windows.Forms.GroupBox
    Friend WithEvents Rdo_button4 As user_control.rdo_button
    Friend WithEvents Rdo_button3 As user_control.rdo_button
    Friend WithEvents Rdo_button2 As user_control.rdo_button
    Friend WithEvents Rdo_button1 As user_control.rdo_button
    Friend WithEvents folderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnExcel As System.Windows.Forms.Button
End Class
