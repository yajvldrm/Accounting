Imports System.Windows.Forms
Imports System.Drawing
Public Class MyRadioButton
    Public Property AlwaysEnable As Boolean = False
    Public Property AlwaysDisable As Boolean = False
    Public Property Value As String = ""
    Public Property Uncheckable As Boolean = False

    Private Sub MyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        If TypeOf Me.Parent Is MyRadioGroup Then
            If Me.Checked Then
                Dim MyParentGroup = CType(Me.Parent, MyRadioGroup)
                MyParentGroup.Value = Me.Value
            End If
        End If
    End Sub
    Private Sub MyRadioButtonClick(sender As Object, e As EventArgs) Handles MyBase.Click
        If Uncheckable Then
            Me.Checked = Not Me.Checked
        End If
    End Sub
End Class
