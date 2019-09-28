<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwordrecovery
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username = New user_control.textbox()
        Me.txt_password = New user_control.textbox()
        Me.btnRecover = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.Myformheader1 = New user_control.myformheader()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Password Recovery"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username._Text = ""
        Me.txt_username.AlwaysDisable = False
        Me.txt_username.AlwaysEnable = False
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.DataSource = ""
        Me.txt_username.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_username.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_username.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_username.Location = New System.Drawing.Point(77, 70)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_username.MultiLine = False
        Me.txt_username.Name = "txt_username"
        Me.txt_username.NoClear = False
        Me.txt_username.NumberFormat = "@"
        Me.txt_username.Required = False
        Me.txt_username.RowData = Nothing
        Me.txt_username.SelectionLength = 0
        Me.txt_username.SelectionStart = 0
        Me.txt_username.Size = New System.Drawing.Size(204, 18)
        Me.txt_username.TabIndex = 11
        Me.txt_username.TableData = Nothing
        Me.txt_username.TextSource = ""
        Me.txt_username.UseSystemPasswordChar = False
        Me.txt_username.Value = ""
        Me.txt_username.ValueSource = ""
        '
        'txt_password
        '
        Me.txt_password._Text = ""
        Me.txt_password.AlwaysDisable = False
        Me.txt_password.AlwaysEnable = False
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_password.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.DataSource = ""
        Me.txt_password.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_password.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_password.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_password.Enabled = False
        Me.txt_password.Location = New System.Drawing.Point(77, 97)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_password.MultiLine = False
        Me.txt_password.Name = "txt_password"
        Me.txt_password.NoClear = False
        Me.txt_password.NumberFormat = "@"
        Me.txt_password.Required = False
        Me.txt_password.RowData = Nothing
        Me.txt_password.SelectionLength = 0
        Me.txt_password.SelectionStart = 0
        Me.txt_password.Size = New System.Drawing.Size(204, 18)
        Me.txt_password.TabIndex = 12
        Me.txt_password.TableData = Nothing
        Me.txt_password.TextSource = ""
        Me.txt_password.UseSystemPasswordChar = False
        Me.txt_password.Value = ""
        Me.txt_password.ValueSource = ""
        '
        'btnRecover
        '
        Me.btnRecover.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRecover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnRecover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecover.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecover.ForeColor = System.Drawing.Color.White
        Me.btnRecover.Location = New System.Drawing.Point(49, 125)
        Me.btnRecover.Name = "btnRecover"
        Me.btnRecover.Size = New System.Drawing.Size(100, 23)
        Me.btnRecover.TabIndex = 65
        Me.btnRecover.Tag = "btnRecover"
        Me.btnRecover.Text = "Recover"
        Me.btnRecover.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(155, 125)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Tag = "btnCancel"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(20, 58)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(260, 2)
        Me.border1.TabIndex = 8
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(300, 28)
        Me.Myformheader1.TabIndex = 67
        '
        'passwordrecovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 164)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRecover)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "passwordrecovery"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Recovery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_username As user_control.textbox
    Friend WithEvents txt_password As user_control.textbox
    Friend WithEvents btnRecover As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Myformheader1 As user_control.myformheader
End Class
