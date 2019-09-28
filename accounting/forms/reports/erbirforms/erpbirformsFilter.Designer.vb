<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class erpbirformsFilter
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAmendedYes = New System.Windows.Forms.RadioButton()
        Me.chkAmendedNo = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTaxesWithheldNo = New System.Windows.Forms.RadioButton()
        Me.chkTaxesWithheldYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkGovernment = New System.Windows.Forms.RadioButton()
        Me.chkPrivate = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAmendedNo)
        Me.GroupBox1.Controls.Add(Me.chkAmendedYes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Amended Form?"
        '
        'chkAmendedYes
        '
        Me.chkAmendedYes.AutoSize = True
        Me.chkAmendedYes.Location = New System.Drawing.Point(6, 19)
        Me.chkAmendedYes.Name = "chkAmendedYes"
        Me.chkAmendedYes.Size = New System.Drawing.Size(43, 17)
        Me.chkAmendedYes.TabIndex = 1
        Me.chkAmendedYes.Text = "Yes"
        Me.chkAmendedYes.UseVisualStyleBackColor = True
        '
        'chkAmendedNo
        '
        Me.chkAmendedNo.AutoSize = True
        Me.chkAmendedNo.Checked = True
        Me.chkAmendedNo.Location = New System.Drawing.Point(55, 19)
        Me.chkAmendedNo.Name = "chkAmendedNo"
        Me.chkAmendedNo.Size = New System.Drawing.Size(39, 17)
        Me.chkAmendedNo.TabIndex = 2
        Me.chkAmendedNo.TabStop = True
        Me.chkAmendedNo.Text = "No"
        Me.chkAmendedNo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTaxesWithheldNo)
        Me.GroupBox2.Controls.Add(Me.chkTaxesWithheldYes)
        Me.GroupBox2.Location = New System.Drawing.Point(124, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 48)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Any Taxes Withheld?"
        '
        'chkTaxesWithheldNo
        '
        Me.chkTaxesWithheldNo.AutoSize = True
        Me.chkTaxesWithheldNo.Checked = True
        Me.chkTaxesWithheldNo.Location = New System.Drawing.Point(55, 19)
        Me.chkTaxesWithheldNo.Name = "chkTaxesWithheldNo"
        Me.chkTaxesWithheldNo.Size = New System.Drawing.Size(39, 17)
        Me.chkTaxesWithheldNo.TabIndex = 2
        Me.chkTaxesWithheldNo.TabStop = True
        Me.chkTaxesWithheldNo.Text = "No"
        Me.chkTaxesWithheldNo.UseVisualStyleBackColor = True
        '
        'chkTaxesWithheldYes
        '
        Me.chkTaxesWithheldYes.AutoSize = True
        Me.chkTaxesWithheldYes.Location = New System.Drawing.Point(6, 19)
        Me.chkTaxesWithheldYes.Name = "chkTaxesWithheldYes"
        Me.chkTaxesWithheldYes.Size = New System.Drawing.Size(43, 17)
        Me.chkTaxesWithheldYes.TabIndex = 1
        Me.chkTaxesWithheldYes.Text = "Yes"
        Me.chkTaxesWithheldYes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkGovernment)
        Me.GroupBox3.Controls.Add(Me.chkPrivate)
        Me.GroupBox3.Location = New System.Drawing.Point(257, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 48)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Company"
        '
        'chkGovernment
        '
        Me.chkGovernment.AutoSize = True
        Me.chkGovernment.Location = New System.Drawing.Point(70, 19)
        Me.chkGovernment.Name = "chkGovernment"
        Me.chkGovernment.Size = New System.Drawing.Size(83, 17)
        Me.chkGovernment.TabIndex = 2
        Me.chkGovernment.Text = "Government"
        Me.chkGovernment.UseVisualStyleBackColor = True
        '
        'chkPrivate
        '
        Me.chkPrivate.AutoSize = True
        Me.chkPrivate.Checked = True
        Me.chkPrivate.Location = New System.Drawing.Point(6, 19)
        Me.chkPrivate.Name = "chkPrivate"
        Me.chkPrivate.Size = New System.Drawing.Size(58, 17)
        Me.chkPrivate.TabIndex = 1
        Me.chkPrivate.TabStop = True
        Me.chkPrivate.Text = "Private"
        Me.chkPrivate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(217, 73)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Tag = "btnCancel"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.BackColor = System.Drawing.Color.Green
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(138, 73)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 25)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Tag = "btnOK"
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'erpbirformsFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 110)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "erpbirformsFilter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "0619-E"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents chkAmendedNo As Windows.Forms.RadioButton
    Friend WithEvents chkAmendedYes As Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents chkTaxesWithheldNo As Windows.Forms.RadioButton
    Friend WithEvents chkTaxesWithheldYes As Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents chkGovernment As Windows.Forms.RadioButton
    Friend WithEvents chkPrivate As Windows.Forms.RadioButton
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents btnOK As Windows.Forms.Button
End Class
