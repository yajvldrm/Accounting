<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acctg_splash
    Inherits DevExpress.XtraSplashScreen.SplashScreen

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
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.lblDll = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlContainer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.Controls.Add(Me.lblDll)
        Me.pnlContainer.Controls.Add(Me.PictureBox1)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(300, 300)
        Me.pnlContainer.TabIndex = 0
        '
        'lblDll
        '
        Me.lblDll.ForeColor = System.Drawing.Color.Black
        Me.lblDll.Location = New System.Drawing.Point(12, 210)
        Me.lblDll.Name = "lblDll"
        Me.lblDll.Size = New System.Drawing.Size(276, 86)
        Me.lblDll.TabIndex = 3
        Me.lblDll.Text = "[ Loading ... ]"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.accounting.My.Resources.Resources.loading1
        Me.PictureBox1.Location = New System.Drawing.Point(50, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'acctg_splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.pnlContainer)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "acctg_splash"
        Me.Text = "Form1"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents lblDll As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
