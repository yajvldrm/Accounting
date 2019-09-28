<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepassword
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txt_new_password = New user_control.textbox()
        Me.txt_old_password = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_retype_password = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(150, 183)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Tag = "btnCancel"
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(44, 183)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txt_new_password
        '
        Me.txt_new_password._Text = ""
        Me.txt_new_password.AlwaysDisable = False
        Me.txt_new_password.AlwaysEnable = False
        Me.txt_new_password.BackColor = System.Drawing.Color.White
        Me.txt_new_password.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_new_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_new_password.DataSource = ""
        Me.txt_new_password.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_new_password.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_new_password.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_new_password.EnabledBackColor = System.Drawing.Color.White
        Me.txt_new_password.ispk = False
        Me.txt_new_password.Location = New System.Drawing.Point(114, 127)
        Me.txt_new_password.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_new_password.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_new_password.MultiLine = False
        Me.txt_new_password.Name = "txt_new_password"
        Me.txt_new_password.NoClear = False
        Me.txt_new_password.NumberFormat = "@"
        Me.txt_new_password.Required = False
        Me.txt_new_password.RowData = Nothing
        Me.txt_new_password.SelectionLength = 0
        Me.txt_new_password.SelectionStart = 0
        Me.txt_new_password.Size = New System.Drawing.Size(162, 18)
        Me.txt_new_password.TabIndex = 2
        Me.txt_new_password.TableData = Nothing
        Me.txt_new_password.TextSource = ""
        Me.txt_new_password.UseSystemPasswordChar = True
        Me.txt_new_password.Value = ""
        Me.txt_new_password.ValueSource = ""
        '
        'txt_old_password
        '
        Me.txt_old_password._Text = ""
        Me.txt_old_password.AlwaysDisable = False
        Me.txt_old_password.AlwaysEnable = False
        Me.txt_old_password.BackColor = System.Drawing.Color.White
        Me.txt_old_password.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_old_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_old_password.DataSource = ""
        Me.txt_old_password.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_old_password.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_old_password.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_old_password.EnabledBackColor = System.Drawing.Color.White
        Me.txt_old_password.ispk = False
        Me.txt_old_password.Location = New System.Drawing.Point(114, 103)
        Me.txt_old_password.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_old_password.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_old_password.MultiLine = False
        Me.txt_old_password.Name = "txt_old_password"
        Me.txt_old_password.NoClear = False
        Me.txt_old_password.NumberFormat = "@"
        Me.txt_old_password.Required = False
        Me.txt_old_password.RowData = Nothing
        Me.txt_old_password.SelectionLength = 0
        Me.txt_old_password.SelectionStart = 0
        Me.txt_old_password.Size = New System.Drawing.Size(162, 18)
        Me.txt_old_password.TabIndex = 1
        Me.txt_old_password.TableData = Nothing
        Me.txt_old_password.TextSource = ""
        Me.txt_old_password.UseSystemPasswordChar = True
        Me.txt_old_password.Value = ""
        Me.txt_old_password.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Old Password"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(16, 61)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(260, 2)
        Me.border1.TabIndex = 68
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 25)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Change Password"
        '
        'txt_retype_password
        '
        Me.txt_retype_password._Text = ""
        Me.txt_retype_password.AlwaysDisable = False
        Me.txt_retype_password.AlwaysEnable = False
        Me.txt_retype_password.BackColor = System.Drawing.Color.White
        Me.txt_retype_password.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_retype_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_retype_password.DataSource = ""
        Me.txt_retype_password.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_retype_password.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_retype_password.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_retype_password.EnabledBackColor = System.Drawing.Color.White
        Me.txt_retype_password.ispk = False
        Me.txt_retype_password.Location = New System.Drawing.Point(114, 151)
        Me.txt_retype_password.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_retype_password.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_retype_password.MultiLine = False
        Me.txt_retype_password.Name = "txt_retype_password"
        Me.txt_retype_password.NoClear = False
        Me.txt_retype_password.NumberFormat = "@"
        Me.txt_retype_password.Required = False
        Me.txt_retype_password.RowData = Nothing
        Me.txt_retype_password.SelectionLength = 0
        Me.txt_retype_password.SelectionStart = 0
        Me.txt_retype_password.Size = New System.Drawing.Size(162, 18)
        Me.txt_retype_password.TabIndex = 3
        Me.txt_retype_password.TableData = Nothing
        Me.txt_retype_password.TextSource = ""
        Me.txt_retype_password.UseSystemPasswordChar = True
        Me.txt_retype_password.Value = ""
        Me.txt_retype_password.ValueSource = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Retype Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(16, 73)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(77, 17)
        Me.lblUsername.TabIndex = 77
        Me.lblUsername.Text = "Username"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(292, 28)
        Me.Myformheader1.TabIndex = 78
        '
        'changepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txt_retype_password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txt_new_password)
        Me.Controls.Add(Me.txt_old_password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "changepassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txt_new_password As user_control.textbox
    Friend WithEvents txt_old_password As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_retype_password As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
End Class
