<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pendingSettings
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_book_id = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_trans_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_account_id = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_trans_no = New user_control.textbox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 2)
        Me.Panel1.TabIndex = 2
        '
        'txt_book_id
        '
        Me.txt_book_id._Text = ""
        Me.txt_book_id.AllowNegative = False
        Me.txt_book_id.AlwaysDisable = False
        Me.txt_book_id.AlwaysEnable = False
        Me.txt_book_id.BackColor = System.Drawing.Color.White
        Me.txt_book_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_id.DataSource = ""
        Me.txt_book_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_book_id.ispk = False
        Me.txt_book_id.Location = New System.Drawing.Point(126, 67)
        Me.txt_book_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_id.MultiLine = False
        Me.txt_book_id.Name = "txt_book_id"
        Me.txt_book_id.NoClear = False
        Me.txt_book_id.NumberFormat = "@"
        Me.txt_book_id.Required = False
        Me.txt_book_id.RowData = Nothing
        Me.txt_book_id.SelectionLength = 0
        Me.txt_book_id.SelectionStart = 0
        Me.txt_book_id.Size = New System.Drawing.Size(105, 20)
        Me.txt_book_id.TabIndex = 3
        Me.txt_book_id.TableData = Nothing
        Me.txt_book_id.TextSource = ""
        Me.txt_book_id.UseSystemPasswordChar = False
        Me.txt_book_id.Value = ""
        Me.txt_book_id.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date"
        '
        'txt_trans_date
        '
        Me.txt_trans_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_trans_date.Location = New System.Drawing.Point(126, 93)
        Me.txt_trans_date.Name = "txt_trans_date"
        Me.txt_trans_date.Size = New System.Drawing.Size(105, 20)
        Me.txt_trans_date.TabIndex = 5
        '
        'txt_account_id
        '
        Me.txt_account_id._Text = ""
        Me.txt_account_id.AllowNegative = False
        Me.txt_account_id.AlwaysDisable = False
        Me.txt_account_id.AlwaysEnable = False
        Me.txt_account_id.BackColor = System.Drawing.Color.White
        Me.txt_account_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_id.DataSource = ""
        Me.txt_account_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_id.ispk = False
        Me.txt_account_id.Location = New System.Drawing.Point(126, 119)
        Me.txt_account_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.MultiLine = False
        Me.txt_account_id.Name = "txt_account_id"
        Me.txt_account_id.NoClear = False
        Me.txt_account_id.NumberFormat = "@"
        Me.txt_account_id.Required = False
        Me.txt_account_id.RowData = Nothing
        Me.txt_account_id.SelectionLength = 0
        Me.txt_account_id.SelectionStart = 0
        Me.txt_account_id.Size = New System.Drawing.Size(105, 20)
        Me.txt_account_id.TabIndex = 7
        Me.txt_account_id.TableData = Nothing
        Me.txt_account_id.TextSource = ""
        Me.txt_account_id.UseSystemPasswordChar = False
        Me.txt_account_id.Value = ""
        Me.txt_account_id.ValueSource = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CIB Account"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(145, 145)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 24)
        Me.btnCancel.TabIndex = 342
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(39, 145)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 24)
        Me.btnOK.TabIndex = 341
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 343
        Me.Label5.Text = "Trans No"
        '
        'txt_trans_no
        '
        Me.txt_trans_no._Text = ""
        Me.txt_trans_no.AllowNegative = False
        Me.txt_trans_no.AlwaysDisable = False
        Me.txt_trans_no.AlwaysEnable = False
        Me.txt_trans_no.BackColor = System.Drawing.Color.White
        Me.txt_trans_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_no.DataSource = ""
        Me.txt_trans_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_no.ispk = False
        Me.txt_trans_no.Location = New System.Drawing.Point(126, 41)
        Me.txt_trans_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_no.MultiLine = False
        Me.txt_trans_no.Name = "txt_trans_no"
        Me.txt_trans_no.NoClear = False
        Me.txt_trans_no.NumberFormat = "@"
        Me.txt_trans_no.Required = False
        Me.txt_trans_no.RowData = Nothing
        Me.txt_trans_no.SelectionLength = 0
        Me.txt_trans_no.SelectionStart = 0
        Me.txt_trans_no.Size = New System.Drawing.Size(105, 20)
        Me.txt_trans_no.TabIndex = 344
        Me.txt_trans_no.TableData = Nothing
        Me.txt_trans_no.TextSource = ""
        Me.txt_trans_no.UseSystemPasswordChar = False
        Me.txt_trans_no.Value = ""
        Me.txt_trans_no.ValueSource = ""
        '
        'pendingSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 181)
        Me.Controls.Add(Me.txt_trans_no)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txt_account_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_trans_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_book_id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pendingSettings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents txt_book_id As user_control.textbox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_trans_date As Windows.Forms.DateTimePicker
    Friend WithEvents txt_account_id As user_control.textbox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txt_trans_no As user_control.textbox
End Class
