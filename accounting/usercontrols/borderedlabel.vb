Imports System.Windows.Forms
Imports System.Drawing

Public Class borderedlabel
    Inherits Label
    Private _bordercolor As Color

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        If _bordercolor = Color.Empty Then
            _bordercolor = Color.DarkGray
        End If
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, _bordercolor, ButtonBorderStyle.Solid)
        Me.AutoSize = False
        Me.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Property BorderColor() As Color
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
End Class
