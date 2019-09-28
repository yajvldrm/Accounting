<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputvat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inputvat))
        Me.vat_filter = New System.Windows.Forms.GroupBox()
        Me.rdo_vat_5 = New user_control.rdo_button()
        Me.rdo_vat_4 = New user_control.rdo_button()
        Me.rdo_vat_2 = New user_control.rdo_button()
        Me.rdo_vat_3 = New user_control.rdo_button()
        Me.rdo_vat_1 = New user_control.rdo_button()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.printoption = New System.Windows.Forms.Panel()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.withComparison = New System.Windows.Forms.CheckBox()
        Me.lbl_currency_name = New System.Windows.Forms.Label()
        Me.rdo_currency_2 = New user_control.rdo_button()
        Me.txt_currency_id = New user_control.textbox()
        Me.currency_filter = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rdo_currency_1 = New user_control.rdo_button()
        Me.toDate = New System.Windows.Forms.CheckBox()
        Me.txt_general_id = New user_control.textbox()
        Me.rdo_general_1 = New user_control.rdo_button()
        Me.rdo_general_3 = New user_control.rdo_button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_general_name = New System.Windows.Forms.Label()
        Me.btnImportGeneral = New System.Windows.Forms.Button()
        Me.rdo_general_2 = New user_control.rdo_button()
        Me.general_filter = New System.Windows.Forms.GroupBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.input_vat_importation = New user_control.rdo_button()
        Me.input_vat = New user_control.rdo_button()
        Me.vat_filter.SuspendLayout()
        Me.printoption.SuspendLayout()
        Me.project_department_filter.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.currency_filter.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.general_filter.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vat_filter
        '
        Me.vat_filter.Controls.Add(Me.rdo_vat_5)
        Me.vat_filter.Controls.Add(Me.rdo_vat_4)
        Me.vat_filter.Controls.Add(Me.rdo_vat_2)
        Me.vat_filter.Controls.Add(Me.rdo_vat_3)
        Me.vat_filter.Controls.Add(Me.rdo_vat_1)
        Me.vat_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.vat_filter.Location = New System.Drawing.Point(11, 130)
        Me.vat_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.vat_filter.Name = "vat_filter"
        Me.vat_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.vat_filter.Size = New System.Drawing.Size(378, 90)
        Me.vat_filter.TabIndex = 233
        Me.vat_filter.TabStop = False
        Me.vat_filter.Text = "Value Added Tax"
        '
        'rdo_vat_5
        '
        Me.rdo_vat_5.AutoSize = True
        Me.rdo_vat_5.DataSource = ""
        Me.rdo_vat_5.Location = New System.Drawing.Point(81, 60)
        Me.rdo_vat_5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo_vat_5.Name = "rdo_vat_5"
        Me.rdo_vat_5.Size = New System.Drawing.Size(217, 17)
        Me.rdo_vat_5.TabIndex = 15
        Me.rdo_vat_5.Text = "Reconciliation of Listing for Enforcement"
        Me.rdo_vat_5.TextSource = ""
        Me.rdo_vat_5.Uncheckable = False
        Me.rdo_vat_5.UseVisualStyleBackColor = True
        Me.rdo_vat_5.Value = "5"
        Me.rdo_vat_5.ValueSource = ""
        '
        'rdo_vat_4
        '
        Me.rdo_vat_4.AutoSize = True
        Me.rdo_vat_4.DataSource = ""
        Me.rdo_vat_4.Location = New System.Drawing.Point(200, 40)
        Me.rdo_vat_4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_vat_4.Name = "rdo_vat_4"
        Me.rdo_vat_4.Size = New System.Drawing.Size(126, 17)
        Me.rdo_vat_4.TabIndex = 12
        Me.rdo_vat_4.Text = "Listing of Adjustment"
        Me.rdo_vat_4.TextSource = ""
        Me.rdo_vat_4.Uncheckable = False
        Me.rdo_vat_4.UseVisualStyleBackColor = True
        Me.rdo_vat_4.Value = "4"
        Me.rdo_vat_4.ValueSource = ""
        '
        'rdo_vat_2
        '
        Me.rdo_vat_2.AutoSize = True
        Me.rdo_vat_2.DataSource = ""
        Me.rdo_vat_2.Location = New System.Drawing.Point(30, 40)
        Me.rdo_vat_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_vat_2.Name = "rdo_vat_2"
        Me.rdo_vat_2.Size = New System.Drawing.Size(151, 17)
        Me.rdo_vat_2.TabIndex = 10
        Me.rdo_vat_2.Text = "List of Remitted Input VAT"
        Me.rdo_vat_2.TextSource = ""
        Me.rdo_vat_2.Uncheckable = False
        Me.rdo_vat_2.UseVisualStyleBackColor = True
        Me.rdo_vat_2.Value = "2"
        Me.rdo_vat_2.ValueSource = ""
        '
        'rdo_vat_3
        '
        Me.rdo_vat_3.AutoSize = True
        Me.rdo_vat_3.DataSource = ""
        Me.rdo_vat_3.Location = New System.Drawing.Point(200, 20)
        Me.rdo_vat_3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_vat_3.Name = "rdo_vat_3"
        Me.rdo_vat_3.Size = New System.Drawing.Size(124, 17)
        Me.rdo_vat_3.TabIndex = 11
        Me.rdo_vat_3.Text = "Listing of Unremitted"
        Me.rdo_vat_3.TextSource = ""
        Me.rdo_vat_3.Uncheckable = False
        Me.rdo_vat_3.UseVisualStyleBackColor = True
        Me.rdo_vat_3.Value = "3"
        Me.rdo_vat_3.ValueSource = ""
        '
        'rdo_vat_1
        '
        Me.rdo_vat_1.AutoSize = True
        Me.rdo_vat_1.Checked = True
        Me.rdo_vat_1.DataSource = ""
        Me.rdo_vat_1.Location = New System.Drawing.Point(30, 20)
        Me.rdo_vat_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_vat_1.Name = "rdo_vat_1"
        Me.rdo_vat_1.Size = New System.Drawing.Size(119, 17)
        Me.rdo_vat_1.TabIndex = 9
        Me.rdo_vat_1.TabStop = True
        Me.rdo_vat_1.Text = "Listing of Input VAT"
        Me.rdo_vat_1.TextSource = ""
        Me.rdo_vat_1.Uncheckable = False
        Me.rdo_vat_1.UseVisualStyleBackColor = True
        Me.rdo_vat_1.Value = "1"
        Me.rdo_vat_1.ValueSource = ""
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(82, 4)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_from.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 7)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "Date From"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(206, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "Date To"
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(255, 4)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(202, 480)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 21
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
        Me.btnPrint.Location = New System.Drawing.Point(123, 480)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'printoption
        '
        Me.printoption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.printoption.Controls.Add(Me.txt_date_from)
        Me.printoption.Controls.Add(Me.Label14)
        Me.printoption.Controls.Add(Me.Label13)
        Me.printoption.Controls.Add(Me.txt_date_to)
        Me.printoption.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.printoption.Location = New System.Drawing.Point(10, 95)
        Me.printoption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.printoption.Name = "printoption"
        Me.printoption.Size = New System.Drawing.Size(378, 30)
        Me.printoption.TabIndex = 232
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
        Me.project_department_filter.Location = New System.Drawing.Point(11, 382)
        Me.project_department_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Name = "project_department_filter"
        Me.project_department_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.project_department_filter.Size = New System.Drawing.Size(378, 90)
        Me.project_department_filter.TabIndex = 236
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
        Me.PictureBox4.Location = New System.Drawing.Point(176, 43)
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
        Me.Label7.Location = New System.Drawing.Point(27, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Project"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 67)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Department"
        '
        'withProjectDepartment
        '
        Me.withProjectDepartment.AutoSize = True
        Me.withProjectDepartment.Location = New System.Drawing.Point(72, 20)
        Me.withProjectDepartment.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.withProjectDepartment.Name = "withProjectDepartment"
        Me.withProjectDepartment.Size = New System.Drawing.Size(152, 17)
        Me.withProjectDepartment.TabIndex = 17
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
        Me.txt_department_id.TabIndex = 19
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
        Me.txt_project_id.TabIndex = 18
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.TextSource = ""
        Me.txt_project_id.UseSystemPasswordChar = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 24)
        Me.Label1.TabIndex = 229
        Me.Label1.Text = "Input VAT Report"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Currency"
        '
        'withComparison
        '
        Me.withComparison.AutoSize = True
        Me.withComparison.Enabled = False
        Me.withComparison.Location = New System.Drawing.Point(249, 19)
        Me.withComparison.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.withComparison.Name = "withComparison"
        Me.withComparison.Size = New System.Drawing.Size(107, 17)
        Me.withComparison.TabIndex = 15
        Me.withComparison.Text = "With Comparison"
        Me.withComparison.UseVisualStyleBackColor = True
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
        'rdo_currency_2
        '
        Me.rdo_currency_2.AutoSize = True
        Me.rdo_currency_2.DataSource = ""
        Me.rdo_currency_2.Location = New System.Drawing.Point(137, 18)
        Me.rdo_currency_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_currency_2.Name = "rdo_currency_2"
        Me.rdo_currency_2.Size = New System.Drawing.Size(108, 17)
        Me.rdo_currency_2.TabIndex = 14
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
        Me.txt_currency_id.Location = New System.Drawing.Point(72, 40)
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
        Me.txt_currency_id.TabIndex = 16
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.TextSource = ""
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = ""
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
        Me.currency_filter.Location = New System.Drawing.Point(11, 304)
        Me.currency_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Name = "currency_filter"
        Me.currency_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.currency_filter.Size = New System.Drawing.Size(378, 70)
        Me.currency_filter.TabIndex = 235
        Me.currency_filter.TabStop = False
        Me.currency_filter.Text = "Currency"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 42)
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
        Me.rdo_currency_1.Location = New System.Drawing.Point(22, 18)
        Me.rdo_currency_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_currency_1.Name = "rdo_currency_1"
        Me.rdo_currency_1.Size = New System.Drawing.Size(101, 17)
        Me.rdo_currency_1.TabIndex = 13
        Me.rdo_currency_1.TabStop = True
        Me.rdo_currency_1.Text = "Based Currency"
        Me.rdo_currency_1.TextSource = ""
        Me.rdo_currency_1.Uncheckable = False
        Me.rdo_currency_1.UseVisualStyleBackColor = True
        Me.rdo_currency_1.Value = "1"
        Me.rdo_currency_1.ValueSource = ""
        '
        'toDate
        '
        Me.toDate.AutoSize = True
        Me.toDate.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.toDate.Location = New System.Drawing.Point(25, 71)
        Me.toDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(64, 17)
        Me.toDate.TabIndex = 1
        Me.toDate.Text = "To Date"
        Me.toDate.UseVisualStyleBackColor = True
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
        Me.txt_general_id.Location = New System.Drawing.Point(75, 40)
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
        Me.txt_general_id.TabIndex = 8
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
        Me.rdo_general_1.Location = New System.Drawing.Point(10, 20)
        Me.rdo_general_1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_general_1.Name = "rdo_general_1"
        Me.rdo_general_1.Size = New System.Drawing.Size(36, 17)
        Me.rdo_general_1.TabIndex = 4
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
        Me.rdo_general_3.TabIndex = 7
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
        Me.PictureBox3.Location = New System.Drawing.Point(179, 42)
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
        Me.lbl_general_name.Location = New System.Drawing.Point(199, 42)
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
        Me.btnImportGeneral.Location = New System.Drawing.Point(140, 17)
        Me.btnImportGeneral.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnImportGeneral.Name = "btnImportGeneral"
        Me.btnImportGeneral.Size = New System.Drawing.Size(30, 20)
        Me.btnImportGeneral.TabIndex = 6
        Me.btnImportGeneral.Text = "..."
        Me.btnImportGeneral.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImportGeneral.UseVisualStyleBackColor = True
        '
        'rdo_general_2
        '
        Me.rdo_general_2.AutoSize = True
        Me.rdo_general_2.DataSource = ""
        Me.rdo_general_2.Location = New System.Drawing.Point(75, 20)
        Me.rdo_general_2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo_general_2.Name = "rdo_general_2"
        Me.rdo_general_2.Size = New System.Drawing.Size(61, 17)
        Me.rdo_general_2.TabIndex = 5
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
        Me.general_filter.Location = New System.Drawing.Point(11, 226)
        Me.general_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.general_filter.Name = "general_filter"
        Me.general_filter.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.general_filter.Size = New System.Drawing.Size(378, 70)
        Me.general_filter.TabIndex = 234
        Me.general_filter.TabStop = False
        Me.general_filter.Text = "General Library"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Margin = New System.Windows.Forms.Padding(4)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(400, 28)
        Me.Myformheader1.TabIndex = 237
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(44, 480)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 238
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
        Me.btnPrintOption.Location = New System.Drawing.Point(123, 480)
        Me.btnPrintOption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 239
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.border1.Location = New System.Drawing.Point(13, 60)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(375, 2)
        Me.border1.TabIndex = 230
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(55, 210)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 240
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.input_vat_importation)
        Me.GroupBox1.Controls.Add(Me.input_vat)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 31)
        Me.GroupBox1.TabIndex = 241
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'input_vat_importation
        '
        Me.input_vat_importation.AutoSize = True
        Me.input_vat_importation.DataSource = ""
        Me.input_vat_importation.Location = New System.Drawing.Point(131, 9)
        Me.input_vat_importation.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.input_vat_importation.Name = "input_vat_importation"
        Me.input_vat_importation.Size = New System.Drawing.Size(132, 17)
        Me.input_vat_importation.TabIndex = 11
        Me.input_vat_importation.Text = "Input VAT Importation"
        Me.input_vat_importation.TextSource = ""
        Me.input_vat_importation.Uncheckable = False
        Me.input_vat_importation.UseVisualStyleBackColor = True
        Me.input_vat_importation.Value = "1"
        Me.input_vat_importation.ValueSource = ""
        '
        'input_vat
        '
        Me.input_vat.AutoSize = True
        Me.input_vat.Checked = True
        Me.input_vat.DataSource = ""
        Me.input_vat.Location = New System.Drawing.Point(14, 9)
        Me.input_vat.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.input_vat.Name = "input_vat"
        Me.input_vat.Size = New System.Drawing.Size(100, 17)
        Me.input_vat.TabIndex = 10
        Me.input_vat.TabStop = True
        Me.input_vat.Text = "Input VAT Local"
        Me.input_vat.TextSource = ""
        Me.input_vat.Uncheckable = False
        Me.input_vat.UseVisualStyleBackColor = True
        Me.input_vat.Value = "1"
        Me.input_vat.ValueSource = ""
        '
        'inputvat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 520)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.toDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.printoption)
        Me.Controls.Add(Me.project_department_filter)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.general_filter)
        Me.Controls.Add(Me.currency_filter)
        Me.Controls.Add(Me.vat_filter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "inputvat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input VAT Report"
        Me.vat_filter.ResumeLayout(False)
        Me.vat_filter.PerformLayout()
        Me.printoption.ResumeLayout(False)
        Me.printoption.PerformLayout()
        Me.project_department_filter.ResumeLayout(False)
        Me.project_department_filter.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.currency_filter.ResumeLayout(False)
        Me.currency_filter.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.general_filter.ResumeLayout(False)
        Me.general_filter.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vat_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_vat_2 As user_control.rdo_button
    Friend WithEvents rdo_vat_3 As user_control.rdo_button
    Friend WithEvents rdo_vat_1 As user_control.rdo_button
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents printoption As System.Windows.Forms.Panel
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
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents withComparison As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_currency_name As System.Windows.Forms.Label
    Friend WithEvents rdo_currency_2 As user_control.rdo_button
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents currency_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_currency_1 As user_control.rdo_button
    Friend WithEvents toDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents rdo_general_1 As user_control.rdo_button
    Friend WithEvents rdo_general_3 As user_control.rdo_button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_general_name As System.Windows.Forms.Label
    Friend WithEvents btnImportGeneral As System.Windows.Forms.Button
    Friend WithEvents rdo_general_2 As user_control.rdo_button
    Friend WithEvents general_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_vat_4 As user_control.rdo_button
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents rdo_vat_5 As user_control.rdo_button
    Friend WithEvents lblLoad As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents input_vat_importation As user_control.rdo_button
    Friend WithEvents input_vat As user_control.rdo_button
End Class
