<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesvat
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tin = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rdo = New user_control.textbox()
        Me.txt_address2 = New user_control.textbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_address = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_company = New user_control.textbox()
        Me.printoption = New System.Windows.Forms.Panel()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.vat_filter = New System.Windows.Forms.GroupBox()
        Me.rdo_vat_4 = New user_control.rdo_button()
        Me.rdo_vat_2 = New user_control.rdo_button()
        Me.rdo_vat_3 = New user_control.rdo_button()
        Me.rdo_vat_1 = New user_control.rdo_button()
        Me.toDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.printoption.SuspendLayout()
        Me.vat_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_tin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_rdo)
        Me.GroupBox1.Controls.Add(Me.txt_address2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_company)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 135)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(27, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 211
        Me.Label4.Text = "Company TIN"
        '
        'txt_tin
        '
        Me.txt_tin._Text = ""
        Me.txt_tin.AlwaysDisable = False
        Me.txt_tin.AlwaysEnable = False
        Me.txt_tin.BackColor = System.Drawing.Color.White
        Me.txt_tin.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_tin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tin.DataSource = ""
        Me.txt_tin.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tin.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tin.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tin.EnabledBackColor = System.Drawing.Color.White
        Me.txt_tin.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_tin.ispk = False
        Me.txt_tin.Location = New System.Drawing.Point(103, 105)
        Me.txt_tin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_tin.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tin.MultiLine = False
        Me.txt_tin.Name = "txt_tin"
        Me.txt_tin.NoClear = False
        Me.txt_tin.NumberFormat = "@"
        Me.txt_tin.Required = False
        Me.txt_tin.RowData = Nothing
        Me.txt_tin.SelectionLength = 0
        Me.txt_tin.SelectionStart = 0
        Me.txt_tin.Size = New System.Drawing.Size(368, 19)
        Me.txt_tin.TabIndex = 210
        Me.txt_tin.TableData = Nothing
        Me.txt_tin.TextSource = ""
        Me.txt_tin.UseSystemPasswordChar = False
        Me.txt_tin.Value = ""
        Me.txt_tin.ValueSource = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(42, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "RDO Code"
        '
        'txt_rdo
        '
        Me.txt_rdo._Text = ""
        Me.txt_rdo.AlwaysDisable = False
        Me.txt_rdo.AlwaysEnable = False
        Me.txt_rdo.BackColor = System.Drawing.Color.White
        Me.txt_rdo.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_rdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rdo.DataSource = ""
        Me.txt_rdo.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_rdo.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_rdo.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_rdo.EnabledBackColor = System.Drawing.Color.White
        Me.txt_rdo.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_rdo.ispk = False
        Me.txt_rdo.Location = New System.Drawing.Point(103, 83)
        Me.txt_rdo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_rdo.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_rdo.MultiLine = False
        Me.txt_rdo.Name = "txt_rdo"
        Me.txt_rdo.NoClear = False
        Me.txt_rdo.NumberFormat = "@"
        Me.txt_rdo.Required = False
        Me.txt_rdo.RowData = Nothing
        Me.txt_rdo.SelectionLength = 0
        Me.txt_rdo.SelectionStart = 0
        Me.txt_rdo.Size = New System.Drawing.Size(368, 19)
        Me.txt_rdo.TabIndex = 208
        Me.txt_rdo.TableData = Nothing
        Me.txt_rdo.TextSource = ""
        Me.txt_rdo.UseSystemPasswordChar = False
        Me.txt_rdo.Value = ""
        Me.txt_rdo.ValueSource = ""
        '
        'txt_address2
        '
        Me.txt_address2._Text = ""
        Me.txt_address2.AlwaysDisable = False
        Me.txt_address2.AlwaysEnable = False
        Me.txt_address2.BackColor = System.Drawing.Color.White
        Me.txt_address2.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address2.DataSource = ""
        Me.txt_address2.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address2.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address2.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_address2.EnabledBackColor = System.Drawing.Color.White
        Me.txt_address2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_address2.ispk = False
        Me.txt_address2.Location = New System.Drawing.Point(103, 61)
        Me.txt_address2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_address2.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address2.MultiLine = False
        Me.txt_address2.Name = "txt_address2"
        Me.txt_address2.NoClear = False
        Me.txt_address2.NumberFormat = "@"
        Me.txt_address2.Required = False
        Me.txt_address2.RowData = Nothing
        Me.txt_address2.SelectionLength = 0
        Me.txt_address2.SelectionStart = 0
        Me.txt_address2.Size = New System.Drawing.Size(368, 19)
        Me.txt_address2.TabIndex = 207
        Me.txt_address2.TableData = Nothing
        Me.txt_address2.TextSource = ""
        Me.txt_address2.UseSystemPasswordChar = False
        Me.txt_address2.Value = ""
        Me.txt_address2.ValueSource = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(5, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Company Address"
        '
        'txt_address
        '
        Me.txt_address._Text = ""
        Me.txt_address.AlwaysDisable = False
        Me.txt_address.AlwaysEnable = False
        Me.txt_address.BackColor = System.Drawing.Color.White
        Me.txt_address.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address.DataSource = ""
        Me.txt_address.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_address.EnabledBackColor = System.Drawing.Color.White
        Me.txt_address.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_address.ispk = False
        Me.txt_address.Location = New System.Drawing.Point(103, 39)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_address.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address.MultiLine = False
        Me.txt_address.Name = "txt_address"
        Me.txt_address.NoClear = False
        Me.txt_address.NumberFormat = "@"
        Me.txt_address.Required = False
        Me.txt_address.RowData = Nothing
        Me.txt_address.SelectionLength = 0
        Me.txt_address.SelectionStart = 0
        Me.txt_address.Size = New System.Drawing.Size(368, 19)
        Me.txt_address.TabIndex = 205
        Me.txt_address.TableData = Nothing
        Me.txt_address.TextSource = ""
        Me.txt_address.UseSystemPasswordChar = False
        Me.txt_address.Value = ""
        Me.txt_address.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(17, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "Company Name"
        '
        'txt_company
        '
        Me.txt_company._Text = ""
        Me.txt_company.AlwaysDisable = False
        Me.txt_company.AlwaysEnable = False
        Me.txt_company.BackColor = System.Drawing.Color.White
        Me.txt_company.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_company.DataSource = ""
        Me.txt_company.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_company.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_company.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_company.EnabledBackColor = System.Drawing.Color.White
        Me.txt_company.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_company.ispk = False
        Me.txt_company.Location = New System.Drawing.Point(103, 17)
        Me.txt_company.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_company.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_company.MultiLine = False
        Me.txt_company.Name = "txt_company"
        Me.txt_company.NoClear = False
        Me.txt_company.NumberFormat = "@"
        Me.txt_company.Required = False
        Me.txt_company.RowData = Nothing
        Me.txt_company.SelectionLength = 0
        Me.txt_company.SelectionStart = 0
        Me.txt_company.Size = New System.Drawing.Size(368, 19)
        Me.txt_company.TabIndex = 203
        Me.txt_company.TableData = Nothing
        Me.txt_company.TextSource = ""
        Me.txt_company.UseSystemPasswordChar = False
        Me.txt_company.Value = ""
        Me.txt_company.ValueSource = ""
        '
        'printoption
        '
        Me.printoption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.printoption.Controls.Add(Me.txt_date_from)
        Me.printoption.Controls.Add(Me.Label14)
        Me.printoption.Controls.Add(Me.Label13)
        Me.printoption.Controls.Add(Me.txt_date_to)
        Me.printoption.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.printoption.Location = New System.Drawing.Point(11, 274)
        Me.printoption.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.printoption.Name = "printoption"
        Me.printoption.Size = New System.Drawing.Size(478, 30)
        Me.printoption.TabIndex = 246
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(132, 4)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_from.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(72, 7)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "Date From"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(255, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "Date To"
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(305, 4)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 3
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(173, 310)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 255
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(252, 310)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 254
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'vat_filter
        '
        Me.vat_filter.Controls.Add(Me.rdo_vat_4)
        Me.vat_filter.Controls.Add(Me.rdo_vat_2)
        Me.vat_filter.Controls.Add(Me.rdo_vat_3)
        Me.vat_filter.Controls.Add(Me.rdo_vat_1)
        Me.vat_filter.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.vat_filter.Location = New System.Drawing.Point(11, 175)
        Me.vat_filter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.vat_filter.Name = "vat_filter"
        Me.vat_filter.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.vat_filter.Size = New System.Drawing.Size(478, 70)
        Me.vat_filter.TabIndex = 257
        Me.vat_filter.TabStop = False
        Me.vat_filter.Text = "Value Added Tax"
        '
        'rdo_vat_4
        '
        Me.rdo_vat_4.AutoSize = True
        Me.rdo_vat_4.DataSource = ""
        Me.rdo_vat_4.Enabled = False
        Me.rdo_vat_4.Location = New System.Drawing.Point(297, 40)
        Me.rdo_vat_4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.rdo_vat_2.Enabled = False
        Me.rdo_vat_2.Location = New System.Drawing.Point(56, 39)
        Me.rdo_vat_2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo_vat_2.Name = "rdo_vat_2"
        Me.rdo_vat_2.Size = New System.Drawing.Size(159, 17)
        Me.rdo_vat_2.TabIndex = 10
        Me.rdo_vat_2.Text = "List of Remitted Output VAT"
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
        Me.rdo_vat_3.Enabled = False
        Me.rdo_vat_3.Location = New System.Drawing.Point(297, 20)
        Me.rdo_vat_3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.rdo_vat_1.Location = New System.Drawing.Point(56, 20)
        Me.rdo_vat_1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo_vat_1.Name = "rdo_vat_1"
        Me.rdo_vat_1.Size = New System.Drawing.Size(217, 17)
        Me.rdo_vat_1.TabIndex = 9
        Me.rdo_vat_1.TabStop = True
        Me.rdo_vat_1.Text = "Reconciliation of Listing for Enforcement"
        Me.rdo_vat_1.TextSource = ""
        Me.rdo_vat_1.Uncheckable = False
        Me.rdo_vat_1.UseVisualStyleBackColor = True
        Me.rdo_vat_1.Value = "1"
        Me.rdo_vat_1.ValueSource = ""
        '
        'toDate
        '
        Me.toDate.AutoSize = True
        Me.toDate.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.toDate.Location = New System.Drawing.Point(30, 251)
        Me.toDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(64, 17)
        Me.toDate.TabIndex = 258
        Me.toDate.Text = "To Date"
        Me.toDate.UseVisualStyleBackColor = True
        '
        'salesvat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.Controls.Add(Me.toDate)
        Me.Controls.Add(Me.vat_filter)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.printoption)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "salesvat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Vat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.printoption.ResumeLayout(False)
        Me.printoption.PerformLayout()
        Me.vat_filter.ResumeLayout(False)
        Me.vat_filter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents printoption As System.Windows.Forms.Panel
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents vat_filter As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_vat_4 As user_control.rdo_button
    Friend WithEvents rdo_vat_2 As user_control.rdo_button
    Friend WithEvents rdo_vat_3 As user_control.rdo_button
    Friend WithEvents rdo_vat_1 As user_control.rdo_button
    Friend WithEvents txt_tin As user_control.textbox
    Friend WithEvents txt_rdo As user_control.textbox
    Friend WithEvents txt_address2 As user_control.textbox
    Friend WithEvents txt_address As user_control.textbox
    Friend WithEvents txt_company As user_control.textbox
    Friend WithEvents toDate As System.Windows.Forms.CheckBox
End Class
