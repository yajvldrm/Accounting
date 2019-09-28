Imports System.Windows.Forms
Imports System.Drawing

Public Class acctg_splash
    Sub New()
        InitializeComponent()
    End Sub

    Public Enum SplashScreenCommand
        SetLabel
    End Enum
    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
        Dim command As SplashScreenCommand = CType(cmd, SplashScreenCommand)
        If command = SplashScreenCommand.SetLabel Then
            lblDll.Text = arg
        End If
    End Sub
    Private Sub acctg_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Color.Red
        pnlContainer.BackColor = Color.Red
        Me.BackColor = Color.Red
        TransparencyKey = Color.Red
    End Sub
End Class
