Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles

Public Class myDateTimePicker
    Private _textsource As String = ""
    Private _value As String = ""
    Public Property TextSource() As String
        Get
            Return _textsource
        End Get
        Set(value As String)
            _textsource = value
        End Set
    End Property
    Public Property Value() As String
        Get
            Return _value
        End Get
        Set(value As String)
            _value = value
            dtp.Value = value
        End Set
    End Property
    Private Sub dtp_SizeChanged(sender As Object, e As EventArgs) Handles dtp.SizeChanged
        Me.Height = dtp.Height
        Me.Width = dtp.Width - 2
    End Sub

    Private Sub myDateTimePicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        'txt.BorderStyle = Windows.Forms.BorderStyle.None
        'txt.Height = dtp.Height - 2
    End Sub

    Private Sub myDateTimePicker_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.Height = dtp.Height
    End Sub

    Private Sub txt_Load(sender As Object, e As EventArgs)
        dtp.CalendarMonthBackground = Drawing.Color.Aqua
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = Me.CreateGraphics

        'The dropDownRectangle defines position and size of dropdownbutton block, 
        'the width is fixed to 17 and height to 16. 
        'The dropdownbutton is aligned to right
        Dim dropDownRectangle As Rectangle = New Rectangle(ClientRectangle.Width - 17, 0, 17, Me.Height)
        Dim bkgBrush As Brush
        Dim visualState As ComboBoxState

        'When the control is enabled the brush is set to Backcolor, 
        'otherwise to color stored in _backDisabledColor
        If (Me.Enabled) Then
            bkgBrush = New SolidBrush(Me.BackColor)
            visualState = ComboBoxState.Normal
        Else
            bkgBrush = New SolidBrush(Color.DarkGray)
            visualState = ComboBoxState.Disabled
        End If

        'Painting...in action

        'Filling the background
        g.FillRectangle(bkgBrush, 0, 0, ClientRectangle.Width, ClientRectangle.Height)

        'Drawing the datetime text
        g.DrawString(Me.Text, Me.Font, Brushes.Black, 0, 2)

        'Drawing the dropdownbutton using ComboBoxRenderer
        ComboBoxRenderer.DrawDropDownButton(g, dropDownRectangle, visualState)

        dtp.Visible = False
        g.Dispose()
        bkgBrush.Dispose()
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        Value = sender.Value
    End Sub
End Class