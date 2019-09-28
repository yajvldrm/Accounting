Imports System.Windows.Forms
Imports System.Drawing

Public Class radiogroup

    Private _bordercolor As Color = Color.DarkGray                  ' declaring its variable where variale has a given value
    Private _value As String = ""                                   ' declaring its variable where variable has an empty value

    Private Sub radiogroup_DragDrop(sender As Object, e As EventArgs) Handles MyBase.DragDrop
        MsgBox("drop")
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, _bordercolor, ButtonBorderStyle.Solid)
    End Sub

    Public Property BorderColor() As Color
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _bordercolor
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Color)
            _bordercolor = value
        End Set
    End Property

    'Public Property Value() As String
    '    ' Retrieves the value of the private variable colBColor.
    '    Get
    '        _value = getRdoValue(Me)
    '        Return _value
    '    End Get
    '    ' Stores the selected value in the private variable colBColor, and 
    '    ' updates the background color of the label control lblDisplay.
    '    Set(ByVal value As String)
    '        _value = value
    '        setRdoValue(Me, _value)
    '    End Set
    'End Property

    'raymond - 2016-05-18

End Class