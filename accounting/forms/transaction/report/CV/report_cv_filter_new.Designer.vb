﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class report_cv_filter_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_cv_filter_new))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.withDepartment = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.option2 = New System.Windows.Forms.Panel()
        Me.Rdo_button6 = New user_control.rdo_button()
        Me.Rdo_button5 = New user_control.rdo_button()
        Me.Rdo_button3 = New user_control.rdo_button()
        Me.option4 = New System.Windows.Forms.Panel()
        Me.date_to = New System.Windows.Forms.DateTimePicker()
        Me.date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.option6_2 = New System.Windows.Forms.Panel()
        Me.general_name = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.general_id = New user_control.textbox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.withAllocation = New System.Windows.Forms.CheckBox()
        Me.option5 = New System.Windows.Forms.Panel()
        Me.Rdo_button8 = New user_control.rdo_button()
        Me.Rdo_button9 = New user_control.rdo_button()
        Me.Rdo_button10 = New user_control.rdo_button()
        Me.option6_1 = New System.Windows.Forms.Panel()
        Me.Rdo_button12 = New user_control.rdo_button()
        Me.Rdo_button13 = New user_control.rdo_button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.option3 = New System.Windows.Forms.Panel()
        Me.invoice_to = New user_control.textbox()
        Me.invoice_from = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.withProject = New System.Windows.Forms.CheckBox()
        Me.option6 = New System.Windows.Forms.Panel()
        Me.dgSelection = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isPrinted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.withEntry = New System.Windows.Forms.CheckBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.txt_print = New user_control.textbox()
        Me.border1 = New accounting.borderedlabel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txt_template_id = New user_control.textbox()
        Me.lbl_template = New System.Windows.Forms.Label()
        Me.withPrintedCheck = New System.Windows.Forms.CheckBox()
        Me.option2.SuspendLayout()
        Me.option4.SuspendLayout()
        Me.option6_2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.option5.SuspendLayout()
        Me.option6_1.SuspendLayout()
        Me.option3.SuspendLayout()
        Me.option6.SuspendLayout()
        CType(Me.dgSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'withDepartment
        '
        Me.withDepartment.AutoSize = True
        Me.withDepartment.Location = New System.Drawing.Point(260, 95)
        Me.withDepartment.Name = "withDepartment"
        Me.withDepartment.Size = New System.Drawing.Size(81, 17)
        Me.withDepartment.TabIndex = 67
        Me.withDepartment.Text = "Department"
        Me.withDepartment.UseVisualStyleBackColor = True
        Me.withDepartment.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(303, 295)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'option2
        '
        Me.option2.Controls.Add(Me.Rdo_button6)
        Me.option2.Controls.Add(Me.Rdo_button5)
        Me.option2.Controls.Add(Me.Rdo_button3)
        Me.option2.Location = New System.Drawing.Point(23, 118)
        Me.option2.Name = "option2"
        Me.option2.Size = New System.Drawing.Size(558, 26)
        Me.option2.TabIndex = 59
        '
        'Rdo_button6
        '
        Me.Rdo_button6.AutoSize = True
        Me.Rdo_button6.Checked = True
        Me.Rdo_button6.DataSource = ""
        Me.Rdo_button6.Location = New System.Drawing.Point(49, 5)
        Me.Rdo_button6.Name = "Rdo_button6"
        Me.Rdo_button6.Size = New System.Drawing.Size(97, 17)
        Me.Rdo_button6.TabIndex = 7
        Me.Rdo_button6.TabStop = True
        Me.Rdo_button6.Text = "By Voucher No"
        Me.Rdo_button6.TextSource = ""
        Me.Rdo_button6.Uncheckable = False
        Me.Rdo_button6.UseVisualStyleBackColor = True
        Me.Rdo_button6.Value = "1"
        Me.Rdo_button6.ValueSource = ""
        '
        'Rdo_button5
        '
        Me.Rdo_button5.AutoSize = True
        Me.Rdo_button5.DataSource = ""
        Me.Rdo_button5.Location = New System.Drawing.Point(264, 5)
        Me.Rdo_button5.Name = "Rdo_button5"
        Me.Rdo_button5.Size = New System.Drawing.Size(66, 17)
        Me.Rdo_button5.TabIndex = 6
        Me.Rdo_button5.Text = "By Client"
        Me.Rdo_button5.TextSource = ""
        Me.Rdo_button5.Uncheckable = False
        Me.Rdo_button5.UseVisualStyleBackColor = True
        Me.Rdo_button5.Value = "3"
        Me.Rdo_button5.ValueSource = ""
        '
        'Rdo_button3
        '
        Me.Rdo_button3.AutoSize = True
        Me.Rdo_button3.DataSource = ""
        Me.Rdo_button3.Location = New System.Drawing.Point(152, 5)
        Me.Rdo_button3.Name = "Rdo_button3"
        Me.Rdo_button3.Size = New System.Drawing.Size(106, 17)
        Me.Rdo_button3.TabIndex = 5
        Me.Rdo_button3.Text = "By Voucher Date"
        Me.Rdo_button3.TextSource = ""
        Me.Rdo_button3.Uncheckable = False
        Me.Rdo_button3.UseVisualStyleBackColor = True
        Me.Rdo_button3.Value = "2"
        Me.Rdo_button3.ValueSource = ""
        '
        'option4
        '
        Me.option4.Controls.Add(Me.date_to)
        Me.option4.Controls.Add(Me.date_from)
        Me.option4.Controls.Add(Me.Label5)
        Me.option4.Controls.Add(Me.Label6)
        Me.option4.Location = New System.Drawing.Point(23, 150)
        Me.option4.Name = "option4"
        Me.option4.Size = New System.Drawing.Size(558, 56)
        Me.option4.TabIndex = 61
        '
        'date_to
        '
        Me.date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_to.Location = New System.Drawing.Point(122, 34)
        Me.date_to.Name = "date_to"
        Me.date_to.Size = New System.Drawing.Size(177, 20)
        Me.date_to.TabIndex = 5
        '
        'date_from
        '
        Me.date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_from.Location = New System.Drawing.Point(122, 8)
        Me.date_from.Name = "date_from"
        Me.date_from.Size = New System.Drawing.Size(177, 20)
        Me.date_from.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "To :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "From :"
        '
        'option6_2
        '
        Me.option6_2.Controls.Add(Me.general_name)
        Me.option6_2.Controls.Add(Me.PictureBox2)
        Me.option6_2.Controls.Add(Me.general_id)
        Me.option6_2.Location = New System.Drawing.Point(5, 61)
        Me.option6_2.Name = "option6_2"
        Me.option6_2.Size = New System.Drawing.Size(550, 26)
        Me.option6_2.TabIndex = 19
        '
        'general_name
        '
        Me.general_name.AutoSize = True
        Me.general_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.general_name.ForeColor = System.Drawing.Color.Blue
        Me.general_name.Location = New System.Drawing.Point(124, 10)
        Me.general_name.Name = "general_name"
        Me.general_name.Size = New System.Drawing.Size(87, 13)
        Me.general_name.TabIndex = 179
        Me.general_name.Text = "General Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(105, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 178
        Me.PictureBox2.TabStop = False
        '
        'general_id
        '
        Me.general_id._Text = ""
        Me.general_id.AllowNegative = False
        Me.general_id.AlwaysDisable = False
        Me.general_id.AlwaysEnable = False
        Me.general_id.BackColor = System.Drawing.Color.White
        Me.general_id.BorderColor = System.Drawing.Color.DarkGray
        Me.general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.general_id.DataSource = ""
        Me.general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.general_id.EnabledBackColor = System.Drawing.Color.White
        Me.general_id.ispk = False
        Me.general_id.Location = New System.Drawing.Point(3, 6)
        Me.general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.general_id.MultiLine = False
        Me.general_id.Name = "general_id"
        Me.general_id.NoClear = False
        Me.general_id.NumberFormat = "@"
        Me.general_id.Required = False
        Me.general_id.RowData = Nothing
        Me.general_id.SelectionLength = 0
        Me.general_id.SelectionStart = 0
        Me.general_id.Size = New System.Drawing.Size(102, 20)
        Me.general_id.TabIndex = 177
        Me.general_id.TableData = Nothing
        Me.general_id.TextSource = ""
        Me.general_id.UseSystemPasswordChar = False
        Me.general_id.Value = ""
        Me.general_id.ValueSource = ""
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(222, 295)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'withAllocation
        '
        Me.withAllocation.AutoSize = True
        Me.withAllocation.Location = New System.Drawing.Point(367, 95)
        Me.withAllocation.Name = "withAllocation"
        Me.withAllocation.Size = New System.Drawing.Size(72, 17)
        Me.withAllocation.TabIndex = 68
        Me.withAllocation.Text = "Allocation"
        Me.withAllocation.UseVisualStyleBackColor = True
        Me.withAllocation.Visible = False
        '
        'option5
        '
        Me.option5.Controls.Add(Me.Rdo_button8)
        Me.option5.Controls.Add(Me.Rdo_button9)
        Me.option5.Controls.Add(Me.Rdo_button10)
        Me.option5.Location = New System.Drawing.Point(23, 243)
        Me.option5.Name = "option5"
        Me.option5.Size = New System.Drawing.Size(558, 48)
        Me.option5.TabIndex = 65
        '
        'Rdo_button8
        '
        Me.Rdo_button8.AutoSize = True
        Me.Rdo_button8.DataSource = ""
        Me.Rdo_button8.Location = New System.Drawing.Point(171, 7)
        Me.Rdo_button8.Name = "Rdo_button8"
        Me.Rdo_button8.Size = New System.Drawing.Size(183, 17)
        Me.Rdo_button8.TabIndex = 7
        Me.Rdo_button8.Text = "Printing with Comparative Amount"
        Me.Rdo_button8.TextSource = ""
        Me.Rdo_button8.Uncheckable = False
        Me.Rdo_button8.UseVisualStyleBackColor = True
        Me.Rdo_button8.Value = "3"
        Me.Rdo_button8.ValueSource = ""
        '
        'Rdo_button9
        '
        Me.Rdo_button9.AutoSize = True
        Me.Rdo_button9.Checked = True
        Me.Rdo_button9.DataSource = ""
        Me.Rdo_button9.Location = New System.Drawing.Point(16, 7)
        Me.Rdo_button9.Name = "Rdo_button9"
        Me.Rdo_button9.Size = New System.Drawing.Size(149, 17)
        Me.Rdo_button9.TabIndex = 6
        Me.Rdo_button9.TabStop = True
        Me.Rdo_button9.Text = "Printing in Based Currency"
        Me.Rdo_button9.TextSource = ""
        Me.Rdo_button9.Uncheckable = False
        Me.Rdo_button9.UseVisualStyleBackColor = True
        Me.Rdo_button9.Value = "1"
        Me.Rdo_button9.ValueSource = ""
        '
        'Rdo_button10
        '
        Me.Rdo_button10.AutoSize = True
        Me.Rdo_button10.DataSource = ""
        Me.Rdo_button10.Location = New System.Drawing.Point(16, 30)
        Me.Rdo_button10.Name = "Rdo_button10"
        Me.Rdo_button10.Size = New System.Drawing.Size(148, 17)
        Me.Rdo_button10.TabIndex = 5
        Me.Rdo_button10.Text = "Printing in Original Amount"
        Me.Rdo_button10.TextSource = ""
        Me.Rdo_button10.Uncheckable = False
        Me.Rdo_button10.UseVisualStyleBackColor = True
        Me.Rdo_button10.Value = "2"
        Me.Rdo_button10.ValueSource = ""
        '
        'option6_1
        '
        Me.option6_1.Controls.Add(Me.Rdo_button12)
        Me.option6_1.Controls.Add(Me.Rdo_button13)
        Me.option6_1.Location = New System.Drawing.Point(5, 6)
        Me.option6_1.Name = "option6_1"
        Me.option6_1.Size = New System.Drawing.Size(368, 48)
        Me.option6_1.TabIndex = 18
        '
        'Rdo_button12
        '
        Me.Rdo_button12.AutoSize = True
        Me.Rdo_button12.Checked = True
        Me.Rdo_button12.DataSource = ""
        Me.Rdo_button12.Location = New System.Drawing.Point(109, 6)
        Me.Rdo_button12.Name = "Rdo_button12"
        Me.Rdo_button12.Size = New System.Drawing.Size(151, 17)
        Me.Rdo_button12.TabIndex = 6
        Me.Rdo_button12.TabStop = True
        Me.Rdo_button12.Text = "All Clients (Group by Client)"
        Me.Rdo_button12.TextSource = ""
        Me.Rdo_button12.Uncheckable = False
        Me.Rdo_button12.UseVisualStyleBackColor = True
        Me.Rdo_button12.Value = "1"
        Me.Rdo_button12.ValueSource = ""
        '
        'Rdo_button13
        '
        Me.Rdo_button13.AutoSize = True
        Me.Rdo_button13.DataSource = ""
        Me.Rdo_button13.Location = New System.Drawing.Point(109, 29)
        Me.Rdo_button13.Name = "Rdo_button13"
        Me.Rdo_button13.Size = New System.Drawing.Size(70, 17)
        Me.Rdo_button13.TabIndex = 5
        Me.Rdo_button13.Text = "Per Client"
        Me.Rdo_button13.TextSource = ""
        Me.Rdo_button13.Uncheckable = False
        Me.Rdo_button13.UseVisualStyleBackColor = True
        Me.Rdo_button13.Value = "2"
        Me.Rdo_button13.ValueSource = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Check Voucher Report"
        '
        'option3
        '
        Me.option3.Controls.Add(Me.invoice_to)
        Me.option3.Controls.Add(Me.invoice_from)
        Me.option3.Controls.Add(Me.Label4)
        Me.option3.Controls.Add(Me.Label3)
        Me.option3.Location = New System.Drawing.Point(23, 150)
        Me.option3.Name = "option3"
        Me.option3.Size = New System.Drawing.Size(558, 56)
        Me.option3.TabIndex = 60
        '
        'invoice_to
        '
        Me.invoice_to._Text = ""
        Me.invoice_to.AllowNegative = False
        Me.invoice_to.AlwaysDisable = False
        Me.invoice_to.AlwaysEnable = False
        Me.invoice_to.BackColor = System.Drawing.Color.White
        Me.invoice_to.BorderColor = System.Drawing.Color.DarkGray
        Me.invoice_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.invoice_to.DataSource = ""
        Me.invoice_to.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.invoice_to.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.invoice_to.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.invoice_to.EnabledBackColor = System.Drawing.Color.White
        Me.invoice_to.ispk = False
        Me.invoice_to.Location = New System.Drawing.Point(161, 34)
        Me.invoice_to.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.invoice_to.MultiLine = False
        Me.invoice_to.Name = "invoice_to"
        Me.invoice_to.NoClear = False
        Me.invoice_to.NumberFormat = "@"
        Me.invoice_to.Required = False
        Me.invoice_to.RowData = Nothing
        Me.invoice_to.SelectionLength = 0
        Me.invoice_to.SelectionStart = 0
        Me.invoice_to.Size = New System.Drawing.Size(177, 20)
        Me.invoice_to.TabIndex = 3
        Me.invoice_to.TableData = Nothing
        Me.invoice_to.TextSource = ""
        Me.invoice_to.UseSystemPasswordChar = False
        Me.invoice_to.Value = ""
        Me.invoice_to.ValueSource = ""
        '
        'invoice_from
        '
        Me.invoice_from._Text = ""
        Me.invoice_from.AllowNegative = False
        Me.invoice_from.AlwaysDisable = False
        Me.invoice_from.AlwaysEnable = False
        Me.invoice_from.BackColor = System.Drawing.Color.White
        Me.invoice_from.BorderColor = System.Drawing.Color.DarkGray
        Me.invoice_from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.invoice_from.DataSource = ""
        Me.invoice_from.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.invoice_from.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.invoice_from.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.invoice_from.EnabledBackColor = System.Drawing.Color.White
        Me.invoice_from.ispk = False
        Me.invoice_from.Location = New System.Drawing.Point(161, 8)
        Me.invoice_from.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.invoice_from.MultiLine = False
        Me.invoice_from.Name = "invoice_from"
        Me.invoice_from.NoClear = False
        Me.invoice_from.NumberFormat = "@"
        Me.invoice_from.Required = False
        Me.invoice_from.RowData = Nothing
        Me.invoice_from.SelectionLength = 0
        Me.invoice_from.SelectionStart = 0
        Me.invoice_from.Size = New System.Drawing.Size(177, 20)
        Me.invoice_from.TabIndex = 2
        Me.invoice_from.TableData = Nothing
        Me.invoice_from.TextSource = ""
        Me.invoice_from.UseSystemPasswordChar = False
        Me.invoice_from.Value = ""
        Me.invoice_from.ValueSource = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Voucher Number To :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Voucher Number From :"
        '
        'withProject
        '
        Me.withProject.AutoSize = True
        Me.withProject.Location = New System.Drawing.Point(162, 95)
        Me.withProject.Name = "withProject"
        Me.withProject.Size = New System.Drawing.Size(59, 17)
        Me.withProject.TabIndex = 66
        Me.withProject.Text = "Project"
        Me.withProject.UseVisualStyleBackColor = True
        '
        'option6
        '
        Me.option6.Controls.Add(Me.option6_2)
        Me.option6.Controls.Add(Me.option6_1)
        Me.option6.Location = New System.Drawing.Point(23, 150)
        Me.option6.Name = "option6"
        Me.option6.Size = New System.Drawing.Size(558, 87)
        Me.option6.TabIndex = 62
        '
        'dgSelection
        '
        Me.dgSelection.AllowUserToAddRows = False
        Me.dgSelection.AllowUserToDeleteRows = False
        Me.dgSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSelection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.isPrinted, Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgSelection.Location = New System.Drawing.Point(20, 118)
        Me.dgSelection.Name = "dgSelection"
        Me.dgSelection.ReadOnly = True
        Me.dgSelection.RowHeadersVisible = False
        Me.dgSelection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSelection.Size = New System.Drawing.Size(560, 149)
        Me.dgSelection.TabIndex = 70
        Me.dgSelection.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "check_id"
        Me.Column7.HeaderText = "check_id"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'isPrinted
        '
        Me.isPrinted.DataPropertyName = "isPrinted"
        Me.isPrinted.HeaderText = "isPrinted"
        Me.isPrinted.Name = "isPrinted"
        Me.isPrinted.ReadOnly = True
        Me.isPrinted.Visible = False
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "file_path"
        Me.Column6.HeaderText = "file_path"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "trans_no"
        Me.Column1.HeaderText = "Voucher No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "general_name"
        Me.Column2.HeaderText = "Check Payee Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "check_no"
        Me.Column3.HeaderText = "Check No"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "check_date"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = "00/00/0000"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Check Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "check_amount"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "#,##0.00"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'withEntry
        '
        Me.withEntry.AutoSize = True
        Me.withEntry.Checked = True
        Me.withEntry.CheckState = System.Windows.Forms.CheckState.Checked
        Me.withEntry.Location = New System.Drawing.Point(493, 95)
        Me.withEntry.Name = "withEntry"
        Me.withEntry.Size = New System.Drawing.Size(75, 17)
        Me.withEntry.TabIndex = 72
        Me.withEntry.Text = "With Entry"
        Me.withEntry.UseVisualStyleBackColor = True
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(600, 28)
        Me.Myformheader1.TabIndex = 71
        '
        'txt_print
        '
        Me.txt_print._Text = ""
        Me.txt_print.AllowNegative = False
        Me.txt_print.AlwaysDisable = False
        Me.txt_print.AlwaysEnable = False
        Me.txt_print.BackColor = System.Drawing.Color.White
        Me.txt_print.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_print.DataSource = ""
        Me.txt_print.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_print.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_print.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_print.EnabledBackColor = System.Drawing.Color.White
        Me.txt_print.ispk = False
        Me.txt_print.Location = New System.Drawing.Point(56, 69)
        Me.txt_print.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_print.MultiLine = False
        Me.txt_print.Name = "txt_print"
        Me.txt_print.NoClear = False
        Me.txt_print.NumberFormat = "@"
        Me.txt_print.Required = False
        Me.txt_print.RowData = Nothing
        Me.txt_print.SelectionLength = 0
        Me.txt_print.SelectionStart = 0
        Me.txt_print.Size = New System.Drawing.Size(340, 20)
        Me.txt_print.TabIndex = 58
        Me.txt_print.TableData = Nothing
        Me.txt_print.TextSource = ""
        Me.txt_print.UseSystemPasswordChar = False
        Me.txt_print.Value = ""
        Me.txt_print.ValueSource = ""
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(20, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(559, 2)
        Me.border1.TabIndex = 56
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(53, 96)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 73
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(100, 93)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(357, 20)
        Me.txtSearch.TabIndex = 74
        '
        'txt_template_id
        '
        Me.txt_template_id._Text = ""
        Me.txt_template_id.AllowNegative = False
        Me.txt_template_id.AlwaysDisable = False
        Me.txt_template_id.AlwaysEnable = False
        Me.txt_template_id.BackColor = System.Drawing.Color.White
        Me.txt_template_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_template_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_template_id.DataSource = ""
        Me.txt_template_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_template_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_template_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_template_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_template_id.ispk = False
        Me.txt_template_id.Location = New System.Drawing.Point(459, 69)
        Me.txt_template_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_template_id.MultiLine = False
        Me.txt_template_id.Name = "txt_template_id"
        Me.txt_template_id.NoClear = False
        Me.txt_template_id.NumberFormat = "@"
        Me.txt_template_id.Required = False
        Me.txt_template_id.RowData = Nothing
        Me.txt_template_id.SelectionLength = 0
        Me.txt_template_id.SelectionStart = 0
        Me.txt_template_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_template_id.TabIndex = 75
        Me.txt_template_id.TableData = Nothing
        Me.txt_template_id.TextSource = ""
        Me.txt_template_id.UseSystemPasswordChar = False
        Me.txt_template_id.Value = ""
        Me.txt_template_id.ValueSource = ""
        '
        'lbl_template
        '
        Me.lbl_template.AutoSize = True
        Me.lbl_template.Location = New System.Drawing.Point(402, 72)
        Me.lbl_template.Name = "lbl_template"
        Me.lbl_template.Size = New System.Drawing.Size(51, 13)
        Me.lbl_template.TabIndex = 76
        Me.lbl_template.Text = "Template"
        '
        'withPrintedCheck
        '
        Me.withPrintedCheck.AutoSize = True
        Me.withPrintedCheck.Checked = True
        Me.withPrintedCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.withPrintedCheck.Location = New System.Drawing.Point(463, 96)
        Me.withPrintedCheck.Name = "withPrintedCheck"
        Me.withPrintedCheck.Size = New System.Drawing.Size(118, 17)
        Me.withPrintedCheck.TabIndex = 77
        Me.withPrintedCheck.Text = "With Printed Check"
        Me.withPrintedCheck.UseVisualStyleBackColor = True
        '
        'report_cv_filter_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 330)
        Me.Controls.Add(Me.dgSelection)
        Me.Controls.Add(Me.withPrintedCheck)
        Me.Controls.Add(Me.lbl_template)
        Me.Controls.Add(Me.txt_template_id)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.withEntry)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.withDepartment)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.option2)
        Me.Controls.Add(Me.txt_print)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.withAllocation)
        Me.Controls.Add(Me.option5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.option3)
        Me.Controls.Add(Me.withProject)
        Me.Controls.Add(Me.option6)
        Me.Controls.Add(Me.option4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "report_cv_filter_new"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing Option"
        Me.option2.ResumeLayout(False)
        Me.option2.PerformLayout()
        Me.option4.ResumeLayout(False)
        Me.option4.PerformLayout()
        Me.option6_2.ResumeLayout(False)
        Me.option6_2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.option5.ResumeLayout(False)
        Me.option5.PerformLayout()
        Me.option6_1.ResumeLayout(False)
        Me.option6_1.PerformLayout()
        Me.option3.ResumeLayout(False)
        Me.option3.PerformLayout()
        Me.option6.ResumeLayout(False)
        CType(Me.dgSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents withDepartment As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents option2 As System.Windows.Forms.Panel
    Friend WithEvents Rdo_button6 As user_control.rdo_button
    Friend WithEvents Rdo_button5 As user_control.rdo_button
    Friend WithEvents Rdo_button3 As user_control.rdo_button
    Friend WithEvents option4 As System.Windows.Forms.Panel
    Friend WithEvents date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents option6_2 As System.Windows.Forms.Panel
    Friend WithEvents general_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents general_id As user_control.textbox
    Friend WithEvents txt_print As user_control.textbox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents withAllocation As System.Windows.Forms.CheckBox
    Friend WithEvents option5 As System.Windows.Forms.Panel
    Friend WithEvents Rdo_button8 As user_control.rdo_button
    Friend WithEvents Rdo_button9 As user_control.rdo_button
    Friend WithEvents Rdo_button10 As user_control.rdo_button
    Friend WithEvents option6_1 As System.Windows.Forms.Panel
    Friend WithEvents Rdo_button12 As user_control.rdo_button
    Friend WithEvents Rdo_button13 As user_control.rdo_button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents option3 As System.Windows.Forms.Panel
    Friend WithEvents invoice_to As user_control.textbox
    Friend WithEvents invoice_from As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents withProject As System.Windows.Forms.CheckBox
    Friend WithEvents option6 As System.Windows.Forms.Panel
    Friend WithEvents dgSelection As System.Windows.Forms.DataGridView
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents withEntry As System.Windows.Forms.CheckBox
    Friend WithEvents lblSearch As Windows.Forms.Label
    Friend WithEvents txtSearch As Windows.Forms.TextBox
    Friend WithEvents txt_template_id As user_control.textbox
    Friend WithEvents lbl_template As Windows.Forms.Label
    Friend WithEvents withPrintedCheck As Windows.Forms.CheckBox
    Friend WithEvents Column7 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isPrinted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column6 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As Windows.Forms.DataGridViewTextBoxColumn
End Class