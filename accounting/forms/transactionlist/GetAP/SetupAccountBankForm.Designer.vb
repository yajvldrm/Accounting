<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupAccountBankForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txt_bank_id = New user_control.MyTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_trans_date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_trans_no = New user_control.textbox()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 2)
        Me.Panel1.TabIndex = 281
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 25)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "Setup CIB Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 282
        Me.Label2.Text = "Account:"
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
        Me.btnCancel.Location = New System.Drawing.Point(145, 129)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 24)
        Me.btnCancel.TabIndex = 340
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
        Me.btnOK.Location = New System.Drawing.Point(39, 129)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 24)
        Me.btnOK.TabIndex = 339
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txt_bank_id
        '
        Me.txt_bank_id.AlwaysDisable = False
        Me.txt_bank_id.AlwaysEnable = False
        Me.txt_bank_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_id.BrowseDataSource = ""
        Me.txt_bank_id.BrowseField = ""
        Me.txt_bank_id.BrowseFilter = Nothing
        Me.txt_bank_id.BrowseLabel = "Code,Name"
        Me.txt_bank_id.BrowseLabelWidth = "100,200"
        Me.txt_bank_id.BrowseTextSource = ""
        Me.txt_bank_id.BrowseValueSource = ""
        Me.txt_bank_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_bank_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_id.Enabled = False
        Me.txt_bank_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_bank_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_id.ID = False
        Me.txt_bank_id.Location = New System.Drawing.Point(94, 71)
        Me.txt_bank_id.Name = "txt_bank_id"
        Me.txt_bank_id.NoClear = False
        Me.txt_bank_id.NoSave = False
        Me.txt_bank_id.NumberFormat = "@"
        Me.txt_bank_id.Required = False
        Me.txt_bank_id.RowData = Nothing
        Me.txt_bank_id.Size = New System.Drawing.Size(178, 20)
        Me.txt_bank_id.TabIndex = 341
        Me.txt_bank_id.TextBrowse = False
        Me.txt_bank_id.TextSource = ""
        Me.txt_bank_id.ToUpper = True
        Me.txt_bank_id.Unique = False
        Me.txt_bank_id.Value = ""
        Me.txt_bank_id.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 342
        Me.Label3.Text = "Voucher Date:"
        '
        'txt_trans_date
        '
        Me.txt_trans_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_trans_date.Location = New System.Drawing.Point(94, 97)
        Me.txt_trans_date.Name = "txt_trans_date"
        Me.txt_trans_date.Size = New System.Drawing.Size(100, 20)
        Me.txt_trans_date.TabIndex = 343
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 344
        Me.Label4.Text = "Trans No"
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
        Me.txt_trans_no.Location = New System.Drawing.Point(94, 45)
        Me.txt_trans_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_no.MultiLine = False
        Me.txt_trans_no.Name = "txt_trans_no"
        Me.txt_trans_no.NoClear = False
        Me.txt_trans_no.NumberFormat = "@"
        Me.txt_trans_no.Required = False
        Me.txt_trans_no.RowData = Nothing
        Me.txt_trans_no.SelectionLength = 0
        Me.txt_trans_no.SelectionStart = 0
        Me.txt_trans_no.Size = New System.Drawing.Size(178, 20)
        Me.txt_trans_no.TabIndex = 345
        Me.txt_trans_no.TableData = Nothing
        Me.txt_trans_no.TextSource = ""
        Me.txt_trans_no.UseSystemPasswordChar = False
        Me.txt_trans_no.Value = ""
        Me.txt_trans_no.ValueSource = ""
        '
        'SetupAccountBankForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 165)
        Me.Controls.Add(Me.txt_trans_no)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_trans_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_bank_id)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SetupAccountBankForm"
        Me.ShowIcon = False
        Me.Text = "Setup CIB Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents txt_bank_id As user_control.MyTextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_trans_date As Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txt_trans_no As user_control.textbox
End Class
