'Imports System.Windows.Forms
'Imports libacctng.myFunctions
'Imports connectionlib.connectionlib

Imports System.Text
Imports System.Security.Cryptography

Public Class encrypt_decrypt

    'Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
    '    Dim cipherText As String = txt_string.Text
    '    txt_generated.Text = crypt(cipherText)
    'End Sub

    'Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
    '    Dim plainText As String = txt_string.Text
    '    txt_generated.Text = DecryptPassword(plainText)
    'End Sub

    Private Function haval256(ByVal str As String) As String
        Dim security As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim bytestring() As Byte = System.Text.Encoding.ASCII.GetBytes(str)
        bytestring = security.ComputeHash(bytestring)

        Dim finalstring As String = Nothing
        For Each bt As Byte In bytestring
            finalstring &= bt.ToString("x2")
        Next
        Return finalstring
    End Function

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        txt_generated.Text = haval256(txt_string.Text)
    End Sub
End Class