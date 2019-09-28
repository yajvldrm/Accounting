Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Public Class headerSpreadSheet
    Public Property XLSPath As String = My.Settings.XLSPath
    Public Property FilePath As String = ""
    Public Property TransMode As String = ""

    Private Sub headerSpreadSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FilePath <> "" And TransMode <> "add" Then
            Try
                excel_viewer.LoadDocument(Replace(FilePath, "%20", "\"))
                MyDebugging.AddText("Load File: {0}", FilePath)
            Catch ex As Exception
            End Try
        End If
        If FilePath = "" Then
            excel_viewer.CreateNewDocument()
            FilePath = XLSPath & GenerateRandomString() & ".xls"
        End If
    End Sub
End Class