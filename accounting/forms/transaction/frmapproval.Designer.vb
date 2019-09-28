<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmapproval
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
        Me.border1 = New accounting.borderedlabel()
        Me.lblApproval = New System.Windows.Forms.Label()
        Me.border2 = New accounting.borderedlabel()
        Me.txtApproval = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Myformheader1 = New user_control.myformheader()
        Me.SuspendLayout()
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(20, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(260, 2)
        Me.border1.TabIndex = 278
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApproval
        '
        Me.lblApproval.AutoSize = True
        Me.lblApproval.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApproval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblApproval.Location = New System.Drawing.Point(20, 32)
        Me.lblApproval.Name = "lblApproval"
        Me.lblApproval.Size = New System.Drawing.Size(141, 25)
        Me.lblApproval.TabIndex = 277
        Me.lblApproval.Text = "frmapproval"
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(20, 65)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(260, 2)
        Me.border2.TabIndex = 279
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtApproval
        '
        Me.txtApproval.Location = New System.Drawing.Point(20, 70)
        Me.txtApproval.Multiline = True
        Me.txtApproval.Name = "txtApproval"
        Me.txtApproval.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtApproval.Size = New System.Drawing.Size(260, 174)
        Me.txtApproval.TabIndex = 280
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(153, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 300
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(47, 252)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 23)
        Me.btnOK.TabIndex = 299
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(300, 28)
        Me.Myformheader1.TabIndex = 301
        '
        'frmapproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 288)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txtApproval)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.lblApproval)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmapproval"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmapproval"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents lblApproval As System.Windows.Forms.Label
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents txtApproval As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Myformheader1 As user_control.myformheader
End Class
