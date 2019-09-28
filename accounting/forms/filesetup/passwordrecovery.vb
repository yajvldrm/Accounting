Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class passwordrecovery
    Private module_code As String = "ACC00904"
    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        Dim username As String = txt_username.Text
        Dim sql As String = String.Format("SELECT password FROM {0}.sys_erp_user WHERE username = '{1}' ", _serverDBFS, username)
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("Invalid Username")
        Else
            'txt_password.Text = DecryptPassword(dt.Rows(0).Item("password").ToString)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class