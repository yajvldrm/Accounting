Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class frmlogin
    Dim default_user As String = "emon"
    Dim default_password As String = "pogi"
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        main.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim username As String = txt_username.Text
        Dim password As String = txt_password.Text

        Dim sql As String = String.Format("SELECT user_id FROM {0}.sys_erp_user WHERE username = '{1}' AND password = '{2}' ", _serverDBFS, username, crypt(password))
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count > 0 Then
            main.MenuStrip1.Show()
            main.Focus()
            Me.Close()
        Else
            MsgBox("Invalid Login")
        End If
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class