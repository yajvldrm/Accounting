Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading.Tasks
Public Class SecFunctions
    Public Shared password As String = "Omn!ray@2018"

    Public Shared mySHA256 As SHA256 = SHA256Managed.Create()

    Public iv As Byte() = New Byte(15) {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Public key As Byte() = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password))
    Public Function EncryptString(ByVal plainText As String, ByVal key As Byte(), ByVal iv As Byte()) As String
        Dim encryptor As Aes = Aes.Create()
        encryptor.Mode = CipherMode.CBC
        encryptor.Key = key
        encryptor.IV = iv
        Dim memoryStream As MemoryStream = New MemoryStream()
        Dim aesEncryptor As ICryptoTransform = encryptor.CreateEncryptor()
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write)
        Dim plainBytes As Byte() = Encoding.ASCII.GetBytes(plainText)
        cryptoStream.Write(plainBytes, 0, plainBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length)
        Return cipherText
    End Function
    Public Function DecryptString(ByVal cipherText As String, ByVal key As Byte(), ByVal iv As Byte()) As String
        Dim encryptor As Aes = Aes.Create()
        encryptor.Mode = CipherMode.CBC
        encryptor.Key = key
        encryptor.IV = iv
        Dim memoryStream As MemoryStream = New MemoryStream()
        Dim aesDecryptor As ICryptoTransform = encryptor.CreateDecryptor()
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write)
        Dim plainText As String = String.Empty
        Try
            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
            cryptoStream.Write(cipherBytes, 0, cipherBytes.Length)
            cryptoStream.FlushFinalBlock()
            Dim plainBytes As Byte() = memoryStream.ToArray()
            plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length)
        Finally
            memoryStream.Close()
            cryptoStream.Close()
        End Try

        Return plainText
    End Function
End Class
