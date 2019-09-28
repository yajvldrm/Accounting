<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prepaidreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prepaidreport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.project_department_filter = New System.Windows.Forms.GroupBox()
        Me.txt_project_id = New user_control.textbox()
        Me.lbl_department_name = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbl_project_name = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.withProjectDepartment = New System.Windows.Forms.CheckBox()
        Me.txt_department_id = New user_control.textbox()
        Me.currency_filter = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.withComparison = New System.Windows.Forms.CheckBox()
        Me.lbl_currency_name = New System.Windows.Forms.Label()
        Me.rdo_currency_2 = New user_control.rdo_button()
        Me.txt_currency_id = New user_control.textbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rdo_currency_1 = New user_control.rdo_button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txt_month_to = New user_control.monthselector()
        Me.txt_month_from = New user_control.monthselector()
        Me.txt_year_to = New System.Windows.Forms.NumericUpDown()
        Me.txt_year_from = New System.Windows.Forms.NumericUpDown()
        Me.txt_account_id = New user_control.textbox()
        Me.rdo_account_1 = New user_control.rdo_button()
        Me.rdo_account_3 = New user_control.rdo_button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_account_name = New System.Windows.Forms.Label()
        Me.btnImportAccount = New System.Windows.Forms.Button()
        Me.rdo_account_2 = New user_control.rdo_button()
        Me.account_filter = New System.Windows.Forms.GroupBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.print_filter = New System.Windows.Forms.Panel()
        Me.rdo_print_2 = New user_control.rdo_button()
        Me.rdo_print_1 = New user_control.rdo_button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.project_department_filter.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.currency_filter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_year_to, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_year_from, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.account_filter.SuspendLayout()
        Me.print_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "Prepaid Reports"
        '
        'project_department_filter
        '
        Me.project_department_filter.Controls.Add(Me.txt_project_id)
        Me.project_department_filter.Controls.Add(Me.lbl_department_name)
        Me.project_department_filter.Controls.Add(Me.PictureBox5)
        Me.project_department_filter.Controls.Add(Me.lbl_project_name)
        Me.project_department_filter.Controls.Add(Me.PictureBox4)
        Me.project_department_filter.Controls.Add(Me.Label7)
        Me.project_department_filter.Controls.Add(Me.Label12)
        Me.project_department_filter.Controls.Add(Me.withProjectDepartment)
        Me.project_department_filter.Controls.Add(Me.txt_department_id)
        Me.project_department_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.project_department_filter.Location = New System.Drawing.Point(11, 336)
        Me.project_department_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Name = "project_department_filter"
        Me.project_department_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Size = New System.Drawing.Size(378, 90)
        Me.project_department_filter.TabIndex = 218
        Me.project_department_filter.TabStop = False
        Me.project_department_filter.Text = "Project / Department"
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
        Me.txt_project_id.Location = New System.Drawing.Point(80, 40)
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
        'lbl_department_name
        '
        Me.lbl_department_name.AutoSize = True
        Me.lbl_department_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_department_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_department_name.Location = New System.Drawing.Point(205, 65)
        Me.lbl_department_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_department_name.Name = "lbl_department_name"
        Me.lbl_department_name.Size = New System.Drawing.Size(110, 16)
        Me.lbl_department_name.TabIndex = 194
        Me.lbl_department_name.Text = "Department Name"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(184, 65)
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
        Me.lbl_project_name.Location = New System.Drawing.Point(205, 40)
        Me.lbl_project_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_project_name.Name = "lbl_project_name"
        Me.lbl_project_name.Size = New System.Drawing.Size(81, 16)
        Me.lbl_project_name.TabIndex = 192
        Me.lbl_project_name.Text = "Project Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(184, 42)
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
        Me.Label7.Location = New System.Drawing.Point(35, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Project"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 67)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Department"
        '
        'withProjectDepartment
        '
        Me.withProjectDepartment.AutoSize = True
        Me.withProjectDepartment.Location = New System.Drawing.Point(80, 18)
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
        Me.txt_department_id.Location = New System.Drawing.Point(80, 63)
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
        Me.currency_filter.Location = New System.Drawing.Point(11, 258)
        Me.currency_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Name = "currency_filter"
        Me.currency_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Size = New System.Drawing.Size(378, 70)
        Me.currency_filter.TabIndex = 217
        Me.currency_filter.TabStop = False
        Me.currency_filter.Text = "Currency"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Currency"
        '
        'withComparison
        '
        Me.withComparison.AutoSize = True
        Me.withComparison.Location = New System.Drawing.Point(249, 15)
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
        Me.lbl_currency_name.Location = New System.Drawing.Point(204, 40)
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
        Me.rdo_currency_2.Location = New System.Drawing.Point(137, 15)
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
        Me.txt_currency_id.Location = New System.Drawing.Point(80, 40)
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
        Me.PictureBox2.Location = New System.Drawing.Point(184, 41)
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
        Me.rdo_currency_1.Location = New System.Drawing.Point(22, 15)
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
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(202, 434)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 36
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
        Me.btnPrint.Location = New System.Drawing.Point(123, 434)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 35
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'txt_month_to
        '
        Me.txt_month_to.DicItems = CType(resources.GetObject("txt_month_to.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.txt_month_to.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_month_to.Location = New System.Drawing.Point(111, 152)
        Me.txt_month_to.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_month_to.Maximum = 12
        Me.txt_month_to.Minimum = 1
        Me.txt_month_to.Name = "txt_month_to"
        Me.txt_month_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_month_to.TabIndex = 295
        Me.txt_month_to.Value = "12"
        '
        'txt_month_from
        '
        Me.txt_month_from.DicItems = CType(resources.GetObject("txt_month_from.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.txt_month_from.Enabled = False
        Me.txt_month_from.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_month_from.Location = New System.Drawing.Point(111, 124)
        Me.txt_month_from.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_month_from.Maximum = 12
        Me.txt_month_from.Minimum = 1
        Me.txt_month_from.Name = "txt_month_from"
        Me.txt_month_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_month_from.TabIndex = 294
        Me.txt_month_from.Value = "1"
        '
        'txt_year_to
        '
        Me.txt_year_to.Enabled = False
        Me.txt_year_to.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_year_to.Location = New System.Drawing.Point(219, 152)
        Me.txt_year_to.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_year_to.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year_to.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.txt_year_to.Name = "txt_year_to"
        Me.txt_year_to.Size = New System.Drawing.Size(70, 20)
        Me.txt_year_to.TabIndex = 293
        Me.txt_year_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_year_to.Value = New Decimal(New Integer() {1970, 0, 0, 0})
        '
        'txt_year_from
        '
        Me.txt_year_from.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_year_from.Location = New System.Drawing.Point(219, 124)
        Me.txt_year_from.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_year_from.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year_from.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.txt_year_from.Name = "txt_year_from"
        Me.txt_year_from.Size = New System.Drawing.Size(70, 20)
        Me.txt_year_from.TabIndex = 292
        Me.txt_year_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_year_from.Value = New Decimal(New Integer() {1970, 0, 0, 0})
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
        Me.txt_account_id.Location = New System.Drawing.Point(80, 38)
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
        Me.rdo_account_1.Location = New System.Drawing.Point(15, 15)
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
        Me.rdo_account_3.Location = New System.Drawing.Point(15, 39)
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
        Me.PictureBox1.Location = New System.Drawing.Point(184, 41)
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
        Me.lbl_account_name.Location = New System.Drawing.Point(204, 40)
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
        Me.btnImportAccount.Location = New System.Drawing.Point(145, 15)
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
        Me.rdo_account_2.Location = New System.Drawing.Point(80, 15)
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
        Me.account_filter.Controls.Add(Me.rdo_account_2)
        Me.account_filter.Controls.Add(Me.btnImportAccount)
        Me.account_filter.Controls.Add(Me.lbl_account_name)
        Me.account_filter.Controls.Add(Me.PictureBox1)
        Me.account_filter.Controls.Add(Me.rdo_account_3)
        Me.account_filter.Controls.Add(Me.rdo_account_1)
        Me.account_filter.Controls.Add(Me.txt_account_id)
        Me.account_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.account_filter.Location = New System.Drawing.Point(11, 180)
        Me.account_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.account_filter.Name = "account_filter"
        Me.account_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.account_filter.Size = New System.Drawing.Size(378, 70)
        Me.account_filter.TabIndex = 215
        Me.account_filter.TabStop = False
        Me.account_filter.Text = "Account"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Margin = New System.Windows.Forms.Padding(4)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(400, 28)
        Me.Myformheader1.TabIndex = 296
        '
        'print_filter
        '
        Me.print_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.print_filter.Controls.Add(Me.rdo_print_2)
        Me.print_filter.Controls.Add(Me.rdo_print_1)
        Me.print_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.print_filter.Location = New System.Drawing.Point(11, 66)
        Me.print_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.print_filter.Name = "print_filter"
        Me.print_filter.Size = New System.Drawing.Size(378, 50)
        Me.print_filter.TabIndex = 297
        '
        'rdo_print_2
        '
        Me.rdo_print_2.AutoSize = True
        Me.rdo_print_2.DataSource = ""
        Me.rdo_print_2.Location = New System.Drawing.Point(25, 25)
        Me.rdo_print_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_print_2.Name = "rdo_print_2"
        Me.rdo_print_2.Size = New System.Drawing.Size(196, 17)
        Me.rdo_print_2.TabIndex = 1
        Me.rdo_print_2.Text = "Print List of Prepaid Accounts Setup"
        Me.rdo_print_2.TextSource = ""
        Me.rdo_print_2.Uncheckable = False
        Me.rdo_print_2.UseVisualStyleBackColor = True
        Me.rdo_print_2.Value = "2"
        Me.rdo_print_2.ValueSource = ""
        '
        'rdo_print_1
        '
        Me.rdo_print_1.AutoSize = True
        Me.rdo_print_1.Checked = True
        Me.rdo_print_1.DataSource = ""
        Me.rdo_print_1.Location = New System.Drawing.Point(25, 4)
        Me.rdo_print_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_print_1.Name = "rdo_print_1"
        Me.rdo_print_1.Size = New System.Drawing.Size(122, 17)
        Me.rdo_print_1.TabIndex = 0
        Me.rdo_print_1.TabStop = True
        Me.rdo_print_1.Text = "Print Lapsing Report"
        Me.rdo_print_1.TextSource = ""
        Me.rdo_print_1.Uncheckable = False
        Me.rdo_print_1.UseVisualStyleBackColor = True
        Me.rdo_print_1.Value = "1"
        Me.rdo_print_1.ValueSource = ""
        '
        'btnPrintOption
        '
        Me.btnPrintOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrintOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrintOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintOption.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(123, 434)
        Me.btnPrintOption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 300
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(44, 434)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 301
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
        Me.border1.Size = New System.Drawing.Size(375, 2)
        Me.border1.TabIndex = 201
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(55, 185)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 302
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'prepaidreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 470)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.print_filter)
        Me.Controls.Add(Me.txt_month_to)
        Me.Controls.Add(Me.txt_month_from)
        Me.Controls.Add(Me.txt_year_to)
        Me.Controls.Add(Me.txt_year_from)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.project_department_filter)
        Me.Controls.Add(Me.currency_filter)
        Me.Controls.Add(Me.account_filter)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "prepaidreport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prepaid Reports"
        Me.project_department_filter.ResumeLayout(False)
        Me.project_department_filter.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.currency_filter.ResumeLayout(False)
        Me.currency_filter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_year_to, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_year_from, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.account_filter.ResumeLayout(False)
        Me.account_filter.PerformLayout()
        Me.print_filter.ResumeLayout(False)
        Me.print_filter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents withComparison As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_currency_name As System.Windows.Forms.Label
    Friend WithEvents rdo_currency_2 As user_control.rdo_button
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents rdo_currency_1 As user_control.rdo_button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txt_month_to As user_control.monthselector
    Friend WithEvents txt_month_from As user_control.monthselector
    Friend WithEvents txt_year_to As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_year_from As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_account_id As user_control.textbox
    Friend WithEvents rdo_account_1 As user_control.rdo_button
    Friend WithEvents rdo_account_3 As user_control.rdo_button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_account_name As System.Windows.Forms.Label
    Friend WithEvents btnImportAccount As System.Windows.Forms.Button
    Friend WithEvents rdo_account_2 As user_control.rdo_button
    Friend WithEvents account_filter As System.Windows.Forms.GroupBox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents print_filter As System.Windows.Forms.Panel
    Friend WithEvents rdo_print_2 As user_control.rdo_button
    Friend WithEvents rdo_print_1 As user_control.rdo_button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
