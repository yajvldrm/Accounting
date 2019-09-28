<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBook
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
        Me.txt_id = New user_control.textbox()
        Me.txt_code = New user_control.textbox()
        Me.txt_name = New user_control.textbox()
        Me.hdr = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hdr.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_id
        '
        Me.txt_id._Text = ""
        Me.txt_id.AlwaysDisable = True
        Me.txt_id.AlwaysEnable = False
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.DataSource = ""
        Me.txt_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_id.Enabled = False
        Me.txt_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_id.ispk = True
        Me.txt_id.Location = New System.Drawing.Point(6, 40)
        Me.txt_id.MultiLine = False
        Me.txt_id.Name = "txt_id"
        Me.txt_id.NoClear = False
        Me.txt_id.NumberFormat = "@"
        Me.txt_id.Required = False
        Me.txt_id.RowData = Nothing
        Me.txt_id.SelectionLength = 0
        Me.txt_id.SelectionStart = 0
        Me.txt_id.Size = New System.Drawing.Size(27, 20)
        Me.txt_id.TabIndex = 0
        Me.txt_id.TableData = Nothing
        Me.txt_id.TextSource = "book_id"
        Me.txt_id.UseSystemPasswordChar = False
        Me.txt_id.Value = ""
        Me.txt_id.ValueSource = ""
        '
        'txt_code
        '
        Me.txt_code._Text = ""
        Me.txt_code.AlwaysDisable = False
        Me.txt_code.AlwaysEnable = False
        Me.txt_code.BackColor = System.Drawing.Color.White
        Me.txt_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_code.DataSource = ""
        Me.txt_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_code.Enabled = False
        Me.txt_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_code.ispk = False
        Me.txt_code.Location = New System.Drawing.Point(53, 66)
        Me.txt_code.MultiLine = False
        Me.txt_code.Name = "txt_code"
        Me.txt_code.NoClear = False
        Me.txt_code.NumberFormat = "@"
        Me.txt_code.Required = False
        Me.txt_code.RowData = Nothing
        Me.txt_code.SelectionLength = 0
        Me.txt_code.SelectionStart = 0
        Me.txt_code.Size = New System.Drawing.Size(105, 20)
        Me.txt_code.TabIndex = 1
        Me.txt_code.TableData = Nothing
        Me.txt_code.TextSource = "book_code"
        Me.txt_code.UseSystemPasswordChar = False
        Me.txt_code.Value = ""
        Me.txt_code.ValueSource = ""
        '
        'txt_name
        '
        Me.txt_name._Text = ""
        Me.txt_name.AlwaysDisable = False
        Me.txt_name.AlwaysEnable = False
        Me.txt_name.BackColor = System.Drawing.Color.White
        Me.txt_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.DataSource = ""
        Me.txt_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_name.Enabled = False
        Me.txt_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_name.ispk = False
        Me.txt_name.Location = New System.Drawing.Point(205, 66)
        Me.txt_name.MultiLine = False
        Me.txt_name.Name = "txt_name"
        Me.txt_name.NoClear = False
        Me.txt_name.NumberFormat = "@"
        Me.txt_name.Required = False
        Me.txt_name.RowData = Nothing
        Me.txt_name.SelectionLength = 0
        Me.txt_name.SelectionStart = 0
        Me.txt_name.Size = New System.Drawing.Size(105, 20)
        Me.txt_name.TabIndex = 2
        Me.txt_name.TableData = Nothing
        Me.txt_name.TextSource = "book_name"
        Me.txt_name.UseSystemPasswordChar = False
        Me.txt_name.Value = ""
        Me.txt_name.ValueSource = ""
        '
        'hdr
        '
        Me.hdr.Controls.Add(Me.btnCancel)
        Me.hdr.Controls.Add(Me.btnSave)
        Me.hdr.Controls.Add(Me.btnEdit)
        Me.hdr.Controls.Add(Me.Label2)
        Me.hdr.Controls.Add(Me.Label1)
        Me.hdr.Controls.Add(Me.txt_id)
        Me.hdr.Controls.Add(Me.txt_name)
        Me.hdr.Controls.Add(Me.txt_code)
        Me.hdr.Location = New System.Drawing.Point(12, 12)
        Me.hdr.Name = "hdr"
        Me.hdr.Size = New System.Drawing.Size(323, 90)
        Me.hdr.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(168, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(87, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(6, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Code"
        '
        'frmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 110)
        Me.Controls.Add(Me.hdr)
        Me.Name = "frmBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBook"
        Me.hdr.ResumeLayout(False)
        Me.hdr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_id As user_control.textbox
    Friend WithEvents txt_code As user_control.textbox
    Friend WithEvents txt_name As user_control.textbox
    Friend WithEvents hdr As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
