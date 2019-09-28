<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usermanagement
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboxAllHeader = New System.Windows.Forms.CheckBox()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_retype_password = New System.Windows.Forms.TextBox()
        Me.txt_approver = New System.Windows.Forms.CheckBox()
        Me.txt_checker = New System.Windows.Forms.CheckBox()
        Me.txt_email = New user_control.textbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_department_id = New user_control.textbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_user_position = New user_control.textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_profile_id = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_user_id = New user_control.textbox()
        Me.txt_user_fullname = New user_control.textbox()
        Me.txt_username = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.txtsearch = New user_control.textbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnSignatory = New System.Windows.Forms.Button()
        Me.txt_user_profile_id = New user_control.textbox()
        Me.gboxContainer.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxAllHeader
        '
        Me.cboxAllHeader.AutoSize = True
        Me.cboxAllHeader.Location = New System.Drawing.Point(27, 73)
        Me.cboxAllHeader.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboxAllHeader.Name = "cboxAllHeader"
        Me.cboxAllHeader.Size = New System.Drawing.Size(15, 14)
        Me.cboxAllHeader.TabIndex = 1
        Me.cboxAllHeader.UseVisualStyleBackColor = True
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.txt_user_profile_id)
        Me.gboxContainer.Controls.Add(Me.Label16)
        Me.gboxContainer.Controls.Add(Me.Label14)
        Me.gboxContainer.Controls.Add(Me.Label13)
        Me.gboxContainer.Controls.Add(Me.Label12)
        Me.gboxContainer.Controls.Add(Me.Label11)
        Me.gboxContainer.Controls.Add(Me.txt_password)
        Me.gboxContainer.Controls.Add(Me.txt_retype_password)
        Me.gboxContainer.Controls.Add(Me.txt_approver)
        Me.gboxContainer.Controls.Add(Me.txt_checker)
        Me.gboxContainer.Controls.Add(Me.txt_email)
        Me.gboxContainer.Controls.Add(Me.Label9)
        Me.gboxContainer.Controls.Add(Me.txt_department_id)
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.txt_user_position)
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.Label6)
        Me.gboxContainer.Controls.Add(Me.Label5)
        Me.gboxContainer.Controls.Add(Me.txt_profile_id)
        Me.gboxContainer.Controls.Add(Me.Label4)
        Me.gboxContainer.Controls.Add(Me.txt_user_id)
        Me.gboxContainer.Controls.Add(Me.txt_user_fullname)
        Me.gboxContainer.Controls.Add(Me.txt_username)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Location = New System.Drawing.Point(19, 229)
        Me.gboxContainer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gboxContainer.Size = New System.Drawing.Size(463, 151)
        Me.gboxContainer.TabIndex = 70
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(48, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 16)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(48, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 16)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(48, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 16)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(295, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(49, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 16)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "*"
        '
        'txt_password
        '
        Me.txt_password.Enabled = False
        Me.txt_password.Location = New System.Drawing.Point(61, 54)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(150, 19)
        Me.txt_password.TabIndex = 6
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_retype_password
        '
        Me.txt_retype_password.Enabled = False
        Me.txt_retype_password.Location = New System.Drawing.Point(309, 52)
        Me.txt_retype_password.Name = "txt_retype_password"
        Me.txt_retype_password.Size = New System.Drawing.Size(150, 19)
        Me.txt_retype_password.TabIndex = 7
        Me.txt_retype_password.UseSystemPasswordChar = True
        '
        'txt_approver
        '
        Me.txt_approver.AutoSize = True
        Me.txt_approver.Location = New System.Drawing.Point(121, 13)
        Me.txt_approver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_approver.Name = "txt_approver"
        Me.txt_approver.Size = New System.Drawing.Size(68, 16)
        Me.txt_approver.TabIndex = 3
        Me.txt_approver.Text = "Approver"
        Me.txt_approver.UseVisualStyleBackColor = True
        '
        'txt_checker
        '
        Me.txt_checker.AutoSize = True
        Me.txt_checker.Location = New System.Drawing.Point(61, 13)
        Me.txt_checker.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_checker.Name = "txt_checker"
        Me.txt_checker.Size = New System.Drawing.Size(62, 16)
        Me.txt_checker.TabIndex = 2
        Me.txt_checker.Text = "Checker"
        Me.txt_checker.UseVisualStyleBackColor = True
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
        Me.txt_email.Location = New System.Drawing.Point(61, 99)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_email.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_email.MultiLine = False
        Me.txt_email.Name = "txt_email"
        Me.txt_email.NoClear = False
        Me.txt_email.NumberFormat = "@"
        Me.txt_email.Required = True
        Me.txt_email.RowData = Nothing
        Me.txt_email.SelectionLength = 0
        Me.txt_email.SelectionStart = 0
        Me.txt_email.Size = New System.Drawing.Size(398, 18)
        Me.txt_email.TabIndex = 9
        Me.txt_email.TableData = Nothing
        Me.txt_email.TextSource = "email"
        Me.txt_email.UseSystemPasswordChar = False
        Me.txt_email.Value = ""
        Me.txt_email.ValueSource = "email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 12)
        Me.Label9.TabIndex = 40
        Me.Label9.Tag = "label"
        Me.Label9.Text = "Email"
        '
        'txt_department_id
        '
        Me.txt_department_id._Text = ""
        Me.txt_department_id.AllowNegative = False
        Me.txt_department_id.AlwaysDisable = False
        Me.txt_department_id.AlwaysEnable = False
        Me.txt_department_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department_id.DataSource = ""
        Me.txt_department_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.Enabled = False
        Me.txt_department_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department_id.ispk = False
        Me.txt_department_id.Location = New System.Drawing.Point(308, 118)
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
        Me.txt_department_id.Size = New System.Drawing.Size(150, 18)
        Me.txt_department_id.TabIndex = 11
        Me.txt_department_id.TableData = Nothing
        Me.txt_department_id.Tag = ""
        Me.txt_department_id.TextSource = "department_name"
        Me.txt_department_id.UseSystemPasswordChar = False
        Me.txt_department_id.Value = ""
        Me.txt_department_id.ValueSource = "department_id"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 121)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 12)
        Me.Label8.TabIndex = 38
        Me.Label8.Tag = "label"
        Me.Label8.Text = "Department"
        '
        'txt_user_position
        '
        Me.txt_user_position._Text = ""
        Me.txt_user_position.AllowNegative = False
        Me.txt_user_position.AlwaysDisable = False
        Me.txt_user_position.AlwaysEnable = False
        Me.txt_user_position.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_position.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_user_position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_position.DataSource = ""
        Me.txt_user_position.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_position.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_position.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_position.Enabled = False
        Me.txt_user_position.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_position.ispk = False
        Me.txt_user_position.Location = New System.Drawing.Point(61, 121)
        Me.txt_user_position.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_user_position.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_position.MultiLine = False
        Me.txt_user_position.Name = "txt_user_position"
        Me.txt_user_position.NoClear = False
        Me.txt_user_position.NumberFormat = "@"
        Me.txt_user_position.Required = True
        Me.txt_user_position.RowData = Nothing
        Me.txt_user_position.SelectionLength = 0
        Me.txt_user_position.SelectionStart = 0
        Me.txt_user_position.Size = New System.Drawing.Size(150, 18)
        Me.txt_user_position.TabIndex = 10
        Me.txt_user_position.TableData = Nothing
        Me.txt_user_position.Tag = ""
        Me.txt_user_position.TextSource = "user_position"
        Me.txt_user_position.UseSystemPasswordChar = False
        Me.txt_user_position.Value = ""
        Me.txt_user_position.ValueSource = "user_position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 124)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 12)
        Me.Label7.TabIndex = 36
        Me.Label7.Tag = "label"
        Me.Label7.Text = "Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 57)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 12)
        Me.Label6.TabIndex = 34
        Me.Label6.Tag = "label"
        Me.Label6.Text = "Retype Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 12)
        Me.Label5.TabIndex = 32
        Me.Label5.Tag = "label"
        Me.Label5.Text = "Password"
        '
        'txt_profile_id
        '
        Me.txt_profile_id._Text = ""
        Me.txt_profile_id.AllowNegative = False
        Me.txt_profile_id.AlwaysDisable = False
        Me.txt_profile_id.AlwaysEnable = False
        Me.txt_profile_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_profile_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_profile_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_profile_id.DataSource = ""
        Me.txt_profile_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_profile_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_profile_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_profile_id.Enabled = False
        Me.txt_profile_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_profile_id.ispk = False
        Me.txt_profile_id.Location = New System.Drawing.Point(308, 30)
        Me.txt_profile_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_profile_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_profile_id.MultiLine = False
        Me.txt_profile_id.Name = "txt_profile_id"
        Me.txt_profile_id.NoClear = False
        Me.txt_profile_id.NumberFormat = "@"
        Me.txt_profile_id.Required = False
        Me.txt_profile_id.RowData = Nothing
        Me.txt_profile_id.SelectionLength = 0
        Me.txt_profile_id.SelectionStart = 0
        Me.txt_profile_id.Size = New System.Drawing.Size(150, 18)
        Me.txt_profile_id.TabIndex = 5
        Me.txt_profile_id.TableData = Nothing
        Me.txt_profile_id.Tag = ""
        Me.txt_profile_id.TextSource = "profile_name"
        Me.txt_profile_id.UseSystemPasswordChar = False
        Me.txt_profile_id.Value = ""
        Me.txt_profile_id.ValueSource = "profile_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 12)
        Me.Label4.TabIndex = 30
        Me.Label4.Tag = "label"
        Me.Label4.Text = "User Profile"
        '
        'txt_user_id
        '
        Me.txt_user_id._Text = ""
        Me.txt_user_id.AllowNegative = False
        Me.txt_user_id.AlwaysDisable = False
        Me.txt_user_id.AlwaysEnable = False
        Me.txt_user_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_id.DataSource = ""
        Me.txt_user_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_id.Enabled = False
        Me.txt_user_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_id.ispk = False
        Me.txt_user_id.Location = New System.Drawing.Point(324, 11)
        Me.txt_user_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_user_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_id.MultiLine = False
        Me.txt_user_id.Name = "txt_user_id"
        Me.txt_user_id.NoClear = False
        Me.txt_user_id.NumberFormat = "@"
        Me.txt_user_id.Required = False
        Me.txt_user_id.RowData = Nothing
        Me.txt_user_id.SelectionLength = 0
        Me.txt_user_id.SelectionStart = 0
        Me.txt_user_id.Size = New System.Drawing.Size(49, 18)
        Me.txt_user_id.TabIndex = 1
        Me.txt_user_id.TableData = Nothing
        Me.txt_user_id.TextSource = "user_id"
        Me.txt_user_id.UseSystemPasswordChar = False
        Me.txt_user_id.Value = ""
        Me.txt_user_id.ValueSource = "user_id"
        Me.txt_user_id.Visible = False
        '
        'txt_user_fullname
        '
        Me.txt_user_fullname._Text = ""
        Me.txt_user_fullname.AllowNegative = False
        Me.txt_user_fullname.AlwaysDisable = False
        Me.txt_user_fullname.AlwaysEnable = False
        Me.txt_user_fullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_fullname.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_user_fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_fullname.DataSource = ""
        Me.txt_user_fullname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_fullname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_fullname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_fullname.Enabled = False
        Me.txt_user_fullname.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_fullname.ispk = False
        Me.txt_user_fullname.Location = New System.Drawing.Point(61, 77)
        Me.txt_user_fullname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_user_fullname.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_fullname.MultiLine = False
        Me.txt_user_fullname.Name = "txt_user_fullname"
        Me.txt_user_fullname.NoClear = False
        Me.txt_user_fullname.NumberFormat = "@"
        Me.txt_user_fullname.Required = True
        Me.txt_user_fullname.RowData = Nothing
        Me.txt_user_fullname.SelectionLength = 0
        Me.txt_user_fullname.SelectionStart = 0
        Me.txt_user_fullname.Size = New System.Drawing.Size(398, 18)
        Me.txt_user_fullname.TabIndex = 8
        Me.txt_user_fullname.TableData = Nothing
        Me.txt_user_fullname.TextSource = "user_fullname"
        Me.txt_user_fullname.UseSystemPasswordChar = False
        Me.txt_user_fullname.Value = ""
        Me.txt_user_fullname.ValueSource = "user_fullname"
        '
        'txt_username
        '
        Me.txt_username._Text = ""
        Me.txt_username.AllowNegative = False
        Me.txt_username.AlwaysDisable = False
        Me.txt_username.AlwaysEnable = False
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_username.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.DataSource = ""
        Me.txt_username.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_username.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_username.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_username.Enabled = False
        Me.txt_username.EnabledBackColor = System.Drawing.Color.White
        Me.txt_username.ispk = False
        Me.txt_username.Location = New System.Drawing.Point(63, 33)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_username.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_username.MultiLine = False
        Me.txt_username.Name = "txt_username"
        Me.txt_username.NoClear = False
        Me.txt_username.NumberFormat = "@"
        Me.txt_username.Required = True
        Me.txt_username.RowData = Nothing
        Me.txt_username.SelectionLength = 0
        Me.txt_username.SelectionStart = 0
        Me.txt_username.Size = New System.Drawing.Size(150, 18)
        Me.txt_username.TabIndex = 4
        Me.txt_username.TableData = Nothing
        Me.txt_username.Tag = "focus"
        Me.txt_username.TextSource = "username"
        Me.txt_username.UseSystemPasswordChar = False
        Me.txt_username.Value = ""
        Me.txt_username.ValueSource = "username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 12)
        Me.Label3.TabIndex = 28
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Username"
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeight = 28
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.user_id, Me.username, Me.user_fullname})
        Me.dgMain.Location = New System.Drawing.Point(19, 66)
        Me.dgMain.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(463, 132)
        Me.dgMain.TabIndex = 0
        Me.dgMain.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.Width = 30
        '
        'user_id
        '
        Me.user_id.DataPropertyName = "user_id"
        Me.user_id.HeaderText = "ID"
        Me.user_id.Name = "user_id"
        Me.user_id.ReadOnly = True
        Me.user_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.user_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.user_id.Visible = False
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.DefaultCellStyle = DataGridViewCellStyle5
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_fullname
        '
        Me.user_fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_fullname.DataPropertyName = "user_fullname"
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.user_fullname.DefaultCellStyle = DataGridViewCellStyle6
        Me.user_fullname.HeaderText = "Fullname"
        Me.user_fullname.Name = "user_fullname"
        Me.user_fullname.ReadOnly = True
        Me.user_fullname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.user_fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(95, 204)
        Me.btnNotSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 6
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(11, 204)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(179, 204)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Delete"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(95, 204)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(11, 204)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "User Management"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(19, 59)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(463, 2)
        Me.border1.TabIndex = 72
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtsearch
        '
        Me.txtsearch._Text = ""
        Me.txtsearch.AllowNegative = False
        Me.txtsearch.AlwaysDisable = False
        Me.txtsearch.AlwaysEnable = False
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderColor = System.Drawing.Color.DarkGray
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.DataSource = ""
        Me.txtsearch.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtsearch.EnabledBackColor = System.Drawing.Color.White
        Me.txtsearch.ispk = False
        Me.txtsearch.Location = New System.Drawing.Point(353, 38)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtsearch.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.MultiLine = False
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.SelectionLength = 0
        Me.txtsearch.SelectionStart = 0
        Me.txtsearch.Size = New System.Drawing.Size(129, 18)
        Me.txtsearch.TabIndex = 101
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = "username,user_fullname"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(312, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 12)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Search"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 102
        '
        'btnSignatory
        '
        Me.btnSignatory.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSignatory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSignatory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignatory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignatory.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignatory.ForeColor = System.Drawing.Color.White
        Me.btnSignatory.Location = New System.Drawing.Point(402, 204)
        Me.btnSignatory.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSignatory.Name = "btnSignatory"
        Me.btnSignatory.Size = New System.Drawing.Size(80, 24)
        Me.btnSignatory.TabIndex = 103
        Me.btnSignatory.Tag = "btnRemove"
        Me.btnSignatory.Text = "Signatory"
        Me.btnSignatory.UseVisualStyleBackColor = False
        '
        'txt_user_profile_id
        '
        Me.txt_user_profile_id._Text = ""
        Me.txt_user_profile_id.AllowNegative = False
        Me.txt_user_profile_id.AlwaysDisable = False
        Me.txt_user_profile_id.AlwaysEnable = False
        Me.txt_user_profile_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_profile_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_user_profile_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_profile_id.DataSource = ""
        Me.txt_user_profile_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_profile_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_profile_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_profile_id.Enabled = False
        Me.txt_user_profile_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_profile_id.ispk = False
        Me.txt_user_profile_id.Location = New System.Drawing.Point(377, 11)
        Me.txt_user_profile_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_user_profile_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_profile_id.MultiLine = False
        Me.txt_user_profile_id.Name = "txt_user_profile_id"
        Me.txt_user_profile_id.NoClear = False
        Me.txt_user_profile_id.NumberFormat = "@"
        Me.txt_user_profile_id.Required = False
        Me.txt_user_profile_id.RowData = Nothing
        Me.txt_user_profile_id.SelectionLength = 0
        Me.txt_user_profile_id.SelectionStart = 0
        Me.txt_user_profile_id.Size = New System.Drawing.Size(41, 18)
        Me.txt_user_profile_id.TabIndex = 108
        Me.txt_user_profile_id.TableData = Nothing
        Me.txt_user_profile_id.TextSource = "user_profile_id"
        Me.txt_user_profile_id.UseSystemPasswordChar = False
        Me.txt_user_profile_id.Value = ""
        Me.txt_user_profile_id.ValueSource = "user_profile_id"
        Me.txt_user_profile_id.Visible = False
        '
        'usermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 392)
        Me.Controls.Add(Me.btnSignatory)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboxAllHeader)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "usermanagement"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboxAllHeader As System.Windows.Forms.CheckBox
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_user_id As user_control.textbox
    Friend WithEvents txt_username As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents user_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_fullname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_approver As System.Windows.Forms.CheckBox
    Friend WithEvents txt_checker As System.Windows.Forms.CheckBox
    Friend WithEvents txt_email As user_control.textbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_department_id As user_control.textbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_user_position As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_profile_id As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_user_fullname As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_retype_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSignatory As System.Windows.Forms.Button
    Friend WithEvents txt_user_profile_id As user_control.textbox
End Class
