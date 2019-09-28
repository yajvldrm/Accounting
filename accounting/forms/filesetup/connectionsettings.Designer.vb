<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connectionsettings
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.txt_file_setup = New System.Windows.Forms.TextBox()
        Me.txt_main = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.mysqlError = New System.Windows.Forms.CheckBox()
        Me.txt_port = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.enableUnitNo = New System.Windows.Forms.CheckBox()
        Me.enableBookUnit = New System.Windows.Forms.RadioButton()
        Me.enableProjectUnit = New System.Windows.Forms.RadioButton()
        Me.border1 = New accounting.borderedlabel()
        Me.withPM = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Database Connection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "File Setup"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Main"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Password"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(57, 304)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(163, 304)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(100, 23)
        Me.btnNotSave.TabIndex = 21
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'txt_file_setup
        '
        Me.txt_file_setup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_file_setup.Location = New System.Drawing.Point(91, 109)
        Me.txt_file_setup.Name = "txt_file_setup"
        Me.txt_file_setup.Size = New System.Drawing.Size(200, 20)
        Me.txt_file_setup.TabIndex = 6
        '
        'txt_main
        '
        Me.txt_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_main.Location = New System.Drawing.Point(91, 135)
        Me.txt_main.Name = "txt_main"
        Me.txt_main.Size = New System.Drawing.Size(200, 20)
        Me.txt_main.TabIndex = 8
        '
        'txt_username
        '
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Location = New System.Drawing.Point(91, 161)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(200, 20)
        Me.txt_username.TabIndex = 10
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Location = New System.Drawing.Point(91, 187)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(200, 20)
        Me.txt_password.TabIndex = 12
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_server
        '
        Me.txt_server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_server.Location = New System.Drawing.Point(91, 83)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(200, 20)
        Me.txt_server.TabIndex = 4
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(320, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'mysqlError
        '
        Me.mysqlError.AutoSize = True
        Me.mysqlError.Location = New System.Drawing.Point(9, 242)
        Me.mysqlError.Name = "mysqlError"
        Me.mysqlError.Size = New System.Drawing.Size(107, 17)
        Me.mysqlError.TabIndex = 15
        Me.mysqlError.Text = "MySQL Message"
        Me.mysqlError.UseVisualStyleBackColor = True
        '
        'txt_port
        '
        Me.txt_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_port.Location = New System.Drawing.Point(91, 213)
        Me.txt_port.Name = "txt_port"
        Me.txt_port.Size = New System.Drawing.Size(200, 20)
        Me.txt_port.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Port"
        '
        'enableUnitNo
        '
        Me.enableUnitNo.AutoSize = True
        Me.enableUnitNo.Location = New System.Drawing.Point(122, 242)
        Me.enableUnitNo.Name = "enableUnitNo"
        Me.enableUnitNo.Size = New System.Drawing.Size(98, 17)
        Me.enableUnitNo.TabIndex = 16
        Me.enableUnitNo.Text = "Enable Unit No"
        Me.enableUnitNo.UseVisualStyleBackColor = True
        '
        'enableBookUnit
        '
        Me.enableBookUnit.AutoSize = True
        Me.enableBookUnit.Location = New System.Drawing.Point(55, 268)
        Me.enableBookUnit.Name = "enableBookUnit"
        Me.enableBookUnit.Size = New System.Drawing.Size(69, 17)
        Me.enableBookUnit.TabIndex = 18
        Me.enableBookUnit.Text = "BookUnit"
        Me.enableBookUnit.UseVisualStyleBackColor = True
        '
        'enableProjectUnit
        '
        Me.enableProjectUnit.AutoSize = True
        Me.enableProjectUnit.Location = New System.Drawing.Point(168, 268)
        Me.enableProjectUnit.Name = "enableProjectUnit"
        Me.enableProjectUnit.Size = New System.Drawing.Size(80, 17)
        Me.enableProjectUnit.TabIndex = 19
        Me.enableProjectUnit.Text = "Project Unit"
        Me.enableProjectUnit.UseVisualStyleBackColor = True
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(20, 65)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(280, 2)
        Me.border1.TabIndex = 2
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'withPM
        '
        Me.withPM.AutoSize = True
        Me.withPM.Location = New System.Drawing.Point(226, 242)
        Me.withPM.Name = "withPM"
        Me.withPM.Size = New System.Drawing.Size(85, 17)
        Me.withPM.TabIndex = 17
        Me.withPM.Text = "PM/SubCon"
        Me.withPM.UseVisualStyleBackColor = True
        '
        'connectionsettings
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 353)
        Me.Controls.Add(Me.withPM)
        Me.Controls.Add(Me.enableProjectUnit)
        Me.Controls.Add(Me.enableBookUnit)
        Me.Controls.Add(Me.enableUnitNo)
        Me.Controls.Add(Me.txt_port)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mysqlError)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txt_server)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_main)
        Me.Controls.Add(Me.txt_file_setup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "connectionsettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents txt_file_setup As System.Windows.Forms.TextBox
    Friend WithEvents txt_main As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_server As System.Windows.Forms.TextBox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents mysqlError As System.Windows.Forms.CheckBox
    Friend WithEvents txt_port As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents enableUnitNo As Windows.Forms.CheckBox
    Friend WithEvents enableBookUnit As Windows.Forms.RadioButton
    Friend WithEvents enableProjectUnit As Windows.Forms.RadioButton
    Friend WithEvents withPM As Windows.Forms.CheckBox
End Class
