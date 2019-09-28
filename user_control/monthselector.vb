Imports System.Windows.Forms

Public Class monthselector

    Private _minimum As Integer = 1                         ' declaring its variable where variable has a given value
    Private _maximum As Integer = 12                        ' declaring its variable where variable has a given value
    Private _valuestr As Integer = 1                        ' declaring its variable where variable has a given value
    Private _textstr As String = MonthName(_valuestr)       ' declaring its variable where MonthName has a value string
    Private _DicItems As New Dictionary(Of Integer, String) ' declaring its variable where dictionary has a value of integer and string

    Overrides Property Text() As String
        Get                                                     ' retrieving the value of the private variable txtstr
            Return _textstr
        End Get
        Set(ByVal value As String)                              ' holding the selected value in the private variable txtstr
            _textstr = value
        End Set
    End Property
    Public Property Value() As String
        Get                                                     ' retrieving the value of the private variable valstr
            Return _valuestr
        End Get
        Set(ByVal value As String)                              ' holding the selected value in the private variable valstr
            _valuestr = value
            setValue(value)
        End Set
    End Property
    Public Property Minimum() As Integer
        Get                                                     ' retrieving the value of the private variable minimum
            Return _minimum
        End Get
        Set(ByVal value As Integer)                             ' holding the selected value in the private variable minimum
            _minimum = value
        End Set
    End Property
    Public Property Maximum() As Integer
        Get                                                     ' retrieving the value of the private variable maximum
            Return _maximum
        End Get
        Set(ByVal value As Integer)                             ' holding the selected value in the private variable maximum
            _maximum = value
        End Set
    End Property
    Public Property DicItems() As Dictionary(Of Integer, String)
        Get                                                     ' retrieving the value of the private variable dicitem
            Return _DicItems
        End Get
        Set(ByVal value As Dictionary(Of Integer, String))      ' holding the selected value in the private variable dicitim
            _DicItems = value
        End Set
    End Property

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If Me.Value = Maximum Then                              ' if monthselector was click by up it has a condition
            Me.Value = Minimum                                  ' that it must not exceed in maximum value which is given
        Else
            Me.Value += 1
        End If
    End Sub
    Private Sub btn_down_Click(sender As Object, e As EventArgs) Handles btn_down.Click
        If Me.Value = Minimum Then                              ' if monthselector was click by down it has a condition
            Me.Value = Maximum                                  ' that it must not dropped in minimum value which is given
        Else
            Me.Value -= 1
        End If
    End Sub

    Public Event ValueChange(ByVal sender As System.Object)

    Private Sub setValue(ByVal num As Integer)
        If num < Minimum Or num > Maximum Then              ' if monthselector was set by value that exceed its maximum
            MsgBox("Index out of range")                    ' then a msg will appear
        Else
            txtmonth.Value = num
            If DicItems.Count > 0 Then
                txtmonth.Text = DicItems.Item(num)
                Me.Text = DicItems.Item(num)
            Else
                txtmonth.Text = MonthName(num)
                Me.Text = MonthName(num)
            End If
            triggerValueChange()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Up Or keyData = Keys.Right Then           ' if keys was up or down
            btn_up_Click(Nothing, Nothing)                          ' then a respective private handles will terminate its value
            Return True
        ElseIf keyData = Keys.Down Or keyData = Keys.Left Then
            btn_down_Click(Nothing, Nothing)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub monthselector_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
    End Sub

    Private Sub monthselector_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.BorderStyle = Windows.Forms.BorderStyle.None
    End Sub

    Private Sub triggerValueChange()
        RaiseEvent ValueChange(Me)
    End Sub

End Class