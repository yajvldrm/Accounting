<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apagingsummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(apagingsummary))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.withComparison = New System.Windows.Forms.CheckBox()
        Me.lbl_currency_name = New System.Windows.Forms.Label()
        Me.rdo_currency_2 = New user_control.rdo_button()
        Me.txt_currency_id = New user_control.textbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rdo_currency_1 = New user_control.rdo_button()
        Me.general_filter = New System.Windows.Forms.GroupBox()
        Me.rdo_general_2 = New user_control.rdo_button()
        Me.btnImportGeneral = New System.Windows.Forms.Button()
        Me.lbl_general_name = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.rdo_general_3 = New user_control.rdo_button()
        Me.rdo_general_1 = New user_control.rdo_button()
        Me.txt_general_id = New user_control.textbox()
        Me.account_filter = New System.Windows.Forms.GroupBox()
        Me.rdo_account_2 = New user_control.rdo_button()
        Me.btnImportAccount = New System.Windows.Forms.Button()
        Me.lbl_account_name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdo_account_3 = New user_control.rdo_button()
        Me.rdo_account_1 = New user_control.rdo_button()
        Me.txt_account_id = New user_control.textbox()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.groupByBook = New System.Windows.Forms.CheckBox()
        Me.checkAllBook = New System.Windows.Forms.CheckBox()
        Me.dgBooks = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.project_department_filter.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.currency_filter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.general_filter.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.account_filter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 24)
        Me.Label1.TabIndex = 228
        Me.Label1.Text = "Aging Summary of Accounts Payable"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.border1.Location = New System.Drawing.Point(15, 62)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(856, 2)
        Me.border1.TabIndex = 229
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.project_department_filter.Location = New System.Drawing.Point(443, 232)
        Me.project_department_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Name = "project_department_filter"
        Me.project_department_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Size = New System.Drawing.Size(428, 90)
        Me.project_department_filter.TabIndex = 246
        Me.project_department_filter.TabStop = False
        Me.project_department_filter.Text = "Project / Department"
        '
        'lbl_department_name
        '
        Me.lbl_department_name.AutoSize = True
        Me.lbl_department_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_department_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_department_name.Location = New System.Drawing.Point(196, 65)
        Me.lbl_department_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_department_name.Name = "lbl_department_name"
        Me.lbl_department_name.Size = New System.Drawing.Size(110, 16)
        Me.lbl_department_name.TabIndex = 194
        Me.lbl_department_name.Text = "Department Name"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(176, 66)
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
        Me.lbl_project_name.Location = New System.Drawing.Point(196, 44)
        Me.lbl_project_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_project_name.Name = "lbl_project_name"
        Me.lbl_project_name.Size = New System.Drawing.Size(81, 16)
        Me.lbl_project_name.TabIndex = 192
        Me.lbl_project_name.Text = "Project Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(176, 44)
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
        Me.Label7.Location = New System.Drawing.Point(27, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Project"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 66)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Department"
        '
        'withProjectDepartment
        '
        Me.withProjectDepartment.AutoSize = True
        Me.withProjectDepartment.Location = New System.Drawing.Point(72, 19)
        Me.withProjectDepartment.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.withProjectDepartment.Name = "withProjectDepartment"
        Me.withProjectDepartment.Size = New System.Drawing.Size(152, 17)
        Me.withProjectDepartment.TabIndex = 16
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
        Me.txt_department_id.Location = New System.Drawing.Point(72, 63)
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
        Me.txt_department_id.TabIndex = 18
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
        Me.txt_project_id.TabIndex = 17
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.TextSource = ""
        Me.txt_project_id.UseSystemPasswordChar = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = ""
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
        Me.currency_filter.Location = New System.Drawing.Point(11, 252)
        Me.currency_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Name = "currency_filter"
        Me.currency_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Size = New System.Drawing.Size(428, 70)
        Me.currency_filter.TabIndex = 245
        Me.currency_filter.TabStop = False
        Me.currency_filter.Text = "Currency"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Currency"
        '
        'withComparison
        '
        Me.withComparison.AutoSize = True
        Me.withComparison.Location = New System.Drawing.Point(267, 21)
        Me.withComparison.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.withComparison.Name = "withComparison"
        Me.withComparison.Size = New System.Drawing.Size(107, 17)
        Me.withComparison.TabIndex = 14
        Me.withComparison.Text = "With Comparison"
        Me.withComparison.UseVisualStyleBackColor = True
        '
        'lbl_currency_name
        '
        Me.lbl_currency_name.AutoSize = True
        Me.lbl_currency_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lbl_currency_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_currency_name.Location = New System.Drawing.Point(196, 44)
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
        Me.rdo_currency_2.Location = New System.Drawing.Point(155, 20)
        Me.rdo_currency_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_currency_2.Name = "rdo_currency_2"
        Me.rdo_currency_2.Size = New System.Drawing.Size(108, 17)
        Me.rdo_currency_2.TabIndex = 13
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
        Me.txt_currency_id.Location = New System.Drawing.Point(72, 43)
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
        Me.txt_currency_id.TabIndex = 15
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.TextSource = ""
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 45)
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
        Me.rdo_currency_1.Location = New System.Drawing.Point(40, 20)
        Me.rdo_currency_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_currency_1.Name = "rdo_currency_1"
        Me.rdo_currency_1.Size = New System.Drawing.Size(101, 17)
        Me.rdo_currency_1.TabIndex = 12
        Me.rdo_currency_1.TabStop = True
        Me.rdo_currency_1.Text = "Based Currency"
        Me.rdo_currency_1.TextSource = ""
        Me.rdo_currency_1.Uncheckable = False
        Me.rdo_currency_1.UseVisualStyleBackColor = True
        Me.rdo_currency_1.Value = "1"
        Me.rdo_currency_1.ValueSource = ""
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
        Me.general_filter.Location = New System.Drawing.Point(11, 174)
        Me.general_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.general_filter.Name = "general_filter"
        Me.general_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.general_filter.Size = New System.Drawing.Size(428, 70)
        Me.general_filter.TabIndex = 244
        Me.general_filter.TabStop = False
        Me.general_filter.Text = "General Library"
        '
        'rdo_general_2
        '
        Me.rdo_general_2.AutoSize = True
        Me.rdo_general_2.DataSource = ""
        Me.rdo_general_2.Location = New System.Drawing.Point(72, 18)
        Me.rdo_general_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_general_2.Name = "rdo_general_2"
        Me.rdo_general_2.Size = New System.Drawing.Size(61, 17)
        Me.rdo_general_2.TabIndex = 8
        Me.rdo_general_2.Text = "Multiple"
        Me.rdo_general_2.TextSource = ""
        Me.rdo_general_2.Uncheckable = False
        Me.rdo_general_2.UseVisualStyleBackColor = True
        Me.rdo_general_2.Value = "2"
        Me.rdo_general_2.ValueSource = ""
        '
        'btnImportGeneral
        '
        Me.btnImportGeneral.Enabled = False
        Me.btnImportGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportGeneral.Location = New System.Drawing.Point(137, 17)
        Me.btnImportGeneral.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnImportGeneral.Name = "btnImportGeneral"
        Me.btnImportGeneral.Size = New System.Drawing.Size(30, 20)
        Me.btnImportGeneral.TabIndex = 9
        Me.btnImportGeneral.Text = "..."
        Me.btnImportGeneral.UseVisualStyleBackColor = True
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
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(176, 42)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 191
        Me.PictureBox3.TabStop = False
        '
        'rdo_general_3
        '
        Me.rdo_general_3.AutoSize = True
        Me.rdo_general_3.DataSource = ""
        Me.rdo_general_3.Location = New System.Drawing.Point(7, 40)
        Me.rdo_general_3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_general_3.Name = "rdo_general_3"
        Me.rdo_general_3.Size = New System.Drawing.Size(61, 17)
        Me.rdo_general_3.TabIndex = 10
        Me.rdo_general_3.Text = "Specific"
        Me.rdo_general_3.TextSource = ""
        Me.rdo_general_3.Uncheckable = False
        Me.rdo_general_3.UseVisualStyleBackColor = True
        Me.rdo_general_3.Value = "3"
        Me.rdo_general_3.ValueSource = ""
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
        Me.rdo_general_1.TabIndex = 7
        Me.rdo_general_1.TabStop = True
        Me.rdo_general_1.Text = "All"
        Me.rdo_general_1.TextSource = ""
        Me.rdo_general_1.Uncheckable = False
        Me.rdo_general_1.UseVisualStyleBackColor = True
        Me.rdo_general_1.Value = "1"
        Me.rdo_general_1.ValueSource = ""
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
        Me.txt_general_id.TabIndex = 11
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.TextSource = ""
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = ""
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
        Me.account_filter.Location = New System.Drawing.Point(11, 96)
        Me.account_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.account_filter.Name = "account_filter"
        Me.account_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.account_filter.Size = New System.Drawing.Size(428, 70)
        Me.account_filter.TabIndex = 243
        Me.account_filter.TabStop = False
        Me.account_filter.Text = "Account"
        '
        'rdo_account_2
        '
        Me.rdo_account_2.AutoSize = True
        Me.rdo_account_2.DataSource = ""
        Me.rdo_account_2.Location = New System.Drawing.Point(72, 18)
        Me.rdo_account_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_account_2.Name = "rdo_account_2"
        Me.rdo_account_2.Size = New System.Drawing.Size(61, 17)
        Me.rdo_account_2.TabIndex = 3
        Me.rdo_account_2.Text = "Multiple"
        Me.rdo_account_2.TextSource = ""
        Me.rdo_account_2.Uncheckable = False
        Me.rdo_account_2.UseVisualStyleBackColor = True
        Me.rdo_account_2.Value = "2"
        Me.rdo_account_2.ValueSource = ""
        '
        'btnImportAccount
        '
        Me.btnImportAccount.Enabled = False
        Me.btnImportAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportAccount.Location = New System.Drawing.Point(137, 17)
        Me.btnImportAccount.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnImportAccount.Name = "btnImportAccount"
        Me.btnImportAccount.Size = New System.Drawing.Size(30, 20)
        Me.btnImportAccount.TabIndex = 4
        Me.btnImportAccount.Text = "..."
        Me.btnImportAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImportAccount.UseVisualStyleBackColor = True
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 42)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 191
        Me.PictureBox1.TabStop = False
        '
        'rdo_account_3
        '
        Me.rdo_account_3.AutoSize = True
        Me.rdo_account_3.DataSource = ""
        Me.rdo_account_3.Location = New System.Drawing.Point(7, 41)
        Me.rdo_account_3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_account_3.Name = "rdo_account_3"
        Me.rdo_account_3.Size = New System.Drawing.Size(61, 17)
        Me.rdo_account_3.TabIndex = 5
        Me.rdo_account_3.Text = "Specific"
        Me.rdo_account_3.TextSource = ""
        Me.rdo_account_3.Uncheckable = False
        Me.rdo_account_3.UseVisualStyleBackColor = True
        Me.rdo_account_3.Value = "3"
        Me.rdo_account_3.ValueSource = ""
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
        Me.rdo_account_1.TabIndex = 2
        Me.rdo_account_1.TabStop = True
        Me.rdo_account_1.Text = "All"
        Me.rdo_account_1.TextSource = ""
        Me.rdo_account_1.Uncheckable = False
        Me.rdo_account_1.UseVisualStyleBackColor = True
        Me.rdo_account_1.Value = "1"
        Me.rdo_account_1.ValueSource = ""
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
        Me.txt_account_id.TabIndex = 6
        Me.txt_account_id.TableData = Nothing
        Me.txt_account_id.TextSource = ""
        Me.txt_account_id.UseSystemPasswordChar = False
        Me.txt_account_id.Value = ""
        Me.txt_account_id.ValueSource = ""
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(83, 68)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 191
        Me.Label4.Text = "As of Date"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(444, 330)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 241
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
        Me.btnPrint.Location = New System.Drawing.Point(90, 330)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 240
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(885, 28)
        Me.Myformheader1.TabIndex = 247
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(11, 330)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 248
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
        Me.btnPrintOption.Location = New System.Drawing.Point(365, 330)
        Me.btnPrintOption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 249
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'groupByBook
        '
        Me.groupByBook.AutoSize = True
        Me.groupByBook.Location = New System.Drawing.Point(771, 75)
        Me.groupByBook.Name = "groupByBook"
        Me.groupByBook.Size = New System.Drawing.Size(96, 17)
        Me.groupByBook.TabIndex = 252
        Me.groupByBook.Text = "Group by Book"
        Me.groupByBook.UseVisualStyleBackColor = True
        '
        'checkAllBook
        '
        Me.checkAllBook.AutoSize = True
        Me.checkAllBook.Location = New System.Drawing.Point(451, 77)
        Me.checkAllBook.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllBook.Name = "checkAllBook"
        Me.checkAllBook.Size = New System.Drawing.Size(15, 14)
        Me.checkAllBook.TabIndex = 251
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
        Me.dgBooks.Location = New System.Drawing.Point(443, 71)
        Me.dgBooks.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgBooks.MultiSelect = False
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersVisible = False
        Me.dgBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBooks.Size = New System.Drawing.Size(428, 153)
        Me.dgBooks.TabIndex = 250
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
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(297, 135)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 253
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'apagingsummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 370)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.groupByBook)
        Me.Controls.Add(Me.checkAllBook)
        Me.Controls.Add(Me.dgBooks)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.project_department_filter)
        Me.Controls.Add(Me.currency_filter)
        Me.Controls.Add(Me.general_filter)
        Me.Controls.Add(Me.account_filter)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "apagingsummary"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aging Summary of Accounts Payable"
        Me.project_department_filter.ResumeLayout(False)
        Me.project_department_filter.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.currency_filter.ResumeLayout(False)
        Me.currency_filter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.general_filter.ResumeLayout(False)
        Me.general_filter.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.account_filter.ResumeLayout(False)
        Me.account_filter.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents general_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_general_2 As user_control.rdo_button
    Friend WithEvents btnImportGeneral As System.Windows.Forms.Button
    Friend WithEvents lbl_general_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents rdo_general_3 As user_control.rdo_button
    Friend WithEvents rdo_general_1 As user_control.rdo_button
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents account_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_account_2 As user_control.rdo_button
    Friend WithEvents btnImportAccount As System.Windows.Forms.Button
    Friend WithEvents lbl_account_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rdo_account_3 As user_control.rdo_button
    Friend WithEvents rdo_account_1 As user_control.rdo_button
    Friend WithEvents txt_account_id As user_control.textbox
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents groupByBook As System.Windows.Forms.CheckBox
    Friend WithEvents checkAllBook As System.Windows.Forms.CheckBox
    Friend WithEvents dgBooks As System.Windows.Forms.DataGridView
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
