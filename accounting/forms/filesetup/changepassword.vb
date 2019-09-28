Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class changepassword
    Dim _username As String = ""
    Private module_code As String = "ACC00905"
    Public Property username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property
    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim opass As String = crypt(txt_old_password.Text)
        Dim npass As String = txt_new_password.Text
        Dim rpass As String = txt_retype_password.Text

        Dim sql As String = String.Format("SELECT password FROM {0}.sys_erp_user WHERE username = '{1}'", _serverDBFS, username)
        Dim dt As DataTable = Query(sql)

        Dim pass As String = dt.Rows(0).Item("password").ToString

        If npass <> rpass Then
            MsgBox("New Password Mismatch.")
        ElseIf opass <> pass Then
            MsgBox("Old Password Mismatch.")
        Else
            Dim dic As New Dictionary(Of String, String)
            dic.Add("username", username)
            dic.Add("password", crypt(npass))
            sql = ATGenerateQuery("Update", "sys_erp_user", dic, Environment.MachineName, Environment.UserName, main.log_id, username, "username")
            'sql = String.Format("UPDATE {0}.sys_erp_user SET password = '{1}' WHERE username = '{2}' ", _serverDBFS, crypt(npass), username)
            FsQuery(sql)
            MsgBox("Password Updated.")
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class