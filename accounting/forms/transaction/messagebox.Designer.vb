<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class messagebox
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(284, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'picIcon
        '
        Me.picIcon.Image = Global.accounting.My.Resources.Resources.Info
        Me.picIcon.Location = New System.Drawing.Point(12, 46)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(50, 50)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picIcon.TabIndex = 1
        Me.picIcon.TabStop = False
        '
        'lblText
        '
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblText.Location = New System.Drawing.Point(68, 74)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(204, 37)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "a"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(68, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(204, 35)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'messagebox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 142)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.Myformheader1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "messagebox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounting"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
