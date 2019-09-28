Imports System.Windows.Forms
Imports libacctng.myFunctions

Public Class reportoption
    Public Property targetForm As Form
    Public Property PrintOption As String = ""

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        PrintOption = getRdoValue(report_option)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub reportoption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOK.Focus()
    End Sub
End Class