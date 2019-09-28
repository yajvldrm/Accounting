Imports System.Windows.Forms
Imports System.Drawing
Public Class MyRadioGroup
    Public Property NoSave As Boolean = False
    Public Property AlwaysEnable As Boolean = False
    Public Property AlwaysDisable As Boolean = False
    Public Property ValueSource As String = ""
    Public Property Required As Boolean = False
    Public Property Value() As String
        Get
            Dim returnValue As String = ""
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is MyRadioButton Then
                    Dim ctr = CType(ctrl, MyRadioButton)
                    If ctr.Checked Then
                        returnValue = ctr.Value
                    End If
                End If
            Next
            Return returnValue
        End Get
        Set(value As String)
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is MyRadioButton Then
                    Dim ctr = CType(ctrl, MyRadioButton)
                    If ctr.Value = value Then
                        If ctr.Name <> "" Then
                            ctr.Checked = True
                        End If
                    End If
                End If
            Next
            RaiseEvent ValueChange(Me, New System.EventArgs)
        End Set
    End Property
    Public Event ValueChange(sender As Object, e As EventArgs)
End Class
