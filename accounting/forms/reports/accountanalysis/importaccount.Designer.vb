<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class importaccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(importaccount))
        Me.Myformheader1 = New user_control.myformheader()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAsset = New System.Windows.Forms.CheckBox()
        Me.cboLiability = New System.Windows.Forms.CheckBox()
        Me.cboCapital = New System.Windows.Forms.CheckBox()
        Me.cboIncome = New System.Windows.Forms.CheckBox()
        Me.cboExpense = New System.Windows.Forms.CheckBox()
        Me.cboGroup = New System.Windows.Forms.CheckBox()
        Me.txtGroupName = New user_control.textbox()
        Me.txtGroup = New user_control.textbox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 1)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(300, 28)
        Me.Myformheader1.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Import"
        '
        'cboAsset
        '
        Me.cboAsset.AutoSize = True
        Me.cboAsset.Checked = True
        Me.cboAsset.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAsset.Location = New System.Drawing.Point(98, 75)
        Me.cboAsset.Name = "cboAsset"
        Me.cboAsset.Size = New System.Drawing.Size(67, 21)
        Me.cboAsset.TabIndex = 85
        Me.cboAsset.Text = "Asset"
        Me.cboAsset.UseVisualStyleBackColor = True
        '
        'cboLiability
        '
        Me.cboLiability.AutoSize = True
        Me.cboLiability.Checked = True
        Me.cboLiability.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboLiability.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLiability.Location = New System.Drawing.Point(98, 102)
        Me.cboLiability.Name = "cboLiability"
        Me.cboLiability.Size = New System.Drawing.Size(83, 21)
        Me.cboLiability.TabIndex = 86
        Me.cboLiability.Text = "Liability"
        Me.cboLiability.UseVisualStyleBackColor = True
        '
        'cboCapital
        '
        Me.cboCapital.AutoSize = True
        Me.cboCapital.Checked = True
        Me.cboCapital.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCapital.Location = New System.Drawing.Point(98, 129)
        Me.cboCapital.Name = "cboCapital"
        Me.cboCapital.Size = New System.Drawing.Size(77, 21)
        Me.cboCapital.TabIndex = 87
        Me.cboCapital.Text = "Capital"
        Me.cboCapital.UseVisualStyleBackColor = True
        '
        'cboIncome
        '
        Me.cboIncome.AutoSize = True
        Me.cboIncome.Checked = True
        Me.cboIncome.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIncome.Location = New System.Drawing.Point(98, 156)
        Me.cboIncome.Name = "cboIncome"
        Me.cboIncome.Size = New System.Drawing.Size(78, 21)
        Me.cboIncome.TabIndex = 88
        Me.cboIncome.Text = "Income"
        Me.cboIncome.UseVisualStyleBackColor = True
        '
        'cboExpense
        '
        Me.cboExpense.AutoSize = True
        Me.cboExpense.Checked = True
        Me.cboExpense.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExpense.Location = New System.Drawing.Point(98, 183)
        Me.cboExpense.Name = "cboExpense"
        Me.cboExpense.Size = New System.Drawing.Size(88, 21)
        Me.cboExpense.TabIndex = 89
        Me.cboExpense.Text = "Expense"
        Me.cboExpense.UseVisualStyleBackColor = True
        '
        'cboGroup
        '
        Me.cboGroup.AutoSize = True
        Me.cboGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGroup.Location = New System.Drawing.Point(98, 210)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(72, 21)
        Me.cboGroup.TabIndex = 90
        Me.cboGroup.Text = "Group"
        Me.cboGroup.UseVisualStyleBackColor = True
        '
        'txtGroupName
        '
        Me.txtGroupName._Text = ""
        Me.txtGroupName.AlwaysDisable = True
        Me.txtGroupName.AlwaysEnable = False
        Me.txtGroupName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGroupName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGroupName.DataSource = ""
        Me.txtGroupName.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGroupName.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGroupName.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtGroupName.Enabled = False
        Me.txtGroupName.Location = New System.Drawing.Point(132, 237)
        Me.txtGroupName.MultiLine = False
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.NoClear = False
        Me.txtGroupName.NumberFormat = "@"
        Me.txtGroupName.Required = False
        Me.txtGroupName.RowData = Nothing
        Me.txtGroupName.SelectionLength = 0
        Me.txtGroupName.SelectionStart = 0
        Me.txtGroupName.Size = New System.Drawing.Size(141, 20)
        Me.txtGroupName.TabIndex = 110
        Me.txtGroupName.TableData = Nothing
        Me.txtGroupName.TextSource = ""
        Me.txtGroupName.UseSystemPasswordChar = False
        Me.txtGroupName.Value = ""
        Me.txtGroupName.ValueSource = ""
        '
        'txtGroup
        '
        Me.txtGroup._Text = ""
        Me.txtGroup.AlwaysDisable = False
        Me.txtGroup.AlwaysEnable = False
        Me.txtGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGroup.BorderColor = System.Drawing.Color.DarkGray
        Me.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGroup.DataSource = ""
        Me.txtGroup.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGroup.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGroup.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtGroup.Enabled = False
        Me.txtGroup.Location = New System.Drawing.Point(53, 237)
        Me.txtGroup.MultiLine = False
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.NoClear = False
        Me.txtGroup.NumberFormat = "@"
        Me.txtGroup.Required = False
        Me.txtGroup.RowData = Nothing
        Me.txtGroup.SelectionLength = 0
        Me.txtGroup.SelectionStart = 0
        Me.txtGroup.Size = New System.Drawing.Size(62, 20)
        Me.txtGroup.TabIndex = 109
        Me.txtGroup.TableData = Nothing
        Me.txtGroup.TextSource = ""
        Me.txtGroup.UseSystemPasswordChar = False
        Me.txtGroup.Value = ""
        Me.txtGroup.ValueSource = ""
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(115, 241)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 112
        Me.PictureBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 241)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "Group"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(145, 263)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 114
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Green
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(39, 263)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 23)
        Me.btnOK.TabIndex = 113
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(260, 2)
        Me.border1.TabIndex = 84
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'importaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 293)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboGroup)
        Me.Controls.Add(Me.cboExpense)
        Me.Controls.Add(Me.cboIncome)
        Me.Controls.Add(Me.cboCapital)
        Me.Controls.Add(Me.cboLiability)
        Me.Controls.Add(Me.cboAsset)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "importaccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboAsset As System.Windows.Forms.CheckBox
    Friend WithEvents cboLiability As System.Windows.Forms.CheckBox
    Friend WithEvents cboCapital As System.Windows.Forms.CheckBox
    Friend WithEvents cboIncome As System.Windows.Forms.CheckBox
    Friend WithEvents cboExpense As System.Windows.Forms.CheckBox
    Friend WithEvents cboGroup As System.Windows.Forms.CheckBox
    Friend WithEvents txtGroupName As user_control.textbox
    Friend WithEvents txtGroup As user_control.textbox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
