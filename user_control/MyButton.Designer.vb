<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyButton
    Inherits System.Windows.Forms.Button

    'UserControl overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Me.ForeColor = Drawing.Color.White
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Dim MyFont = New Drawing.Font("Century Gothic", 8.25, Drawing.GraphicsUnit.Point)
        Me.Font = New Drawing.Font(MyFont, Drawing.FontStyle.Bold)
        Me.Size = New Drawing.Size(80, 24)
        Me.BackColor = Drawing.Color.FromArgb(50, 50, 50)
        Me.FlatAppearance.MouseDownBackColor = Drawing.Color.Silver
        Me.FlatAppearance.MouseOverBackColor = Drawing.Color.Gray
        Me.FlatAppearance.BorderSize = 1
    End Sub
End Class
