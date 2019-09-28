Imports System.Windows.Forms
Imports System.Drawing
Imports connectionlib.connectionlib

Public Class rdo_button

    Private _value As String = ""                               ' declaring its variable where variable has an empty value
    Private _bool As Boolean = Me.Checked                       ' declaring its variable where variable has already a value
    Private _uncheck As Boolean = False                         ' declaring its variable where variable is false
    Private _textsource As String = ""                          ' declaring its variable where variable has an empty value
    Private _valuesource As String = ""                         ' declaring its variable where variable has an empty value
    Private _datasource As String = ""                          ' declaring its variable where variable has an empty value

    Public Property DataSource() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _datasource
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _datasource = value
        End Set
    End Property

    Public Property ValueSource() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _valuesource
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _valuesource = value
        End Set
    End Property

    Public Property TextSource() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _textsource
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _textsource = value
        End Set
    End Property

    Public Property Value() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _value
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _value = value
        End Set
    End Property

    Public Property Uncheckable() As Boolean
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _uncheck
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal uncheck As Boolean)
            _uncheck = uncheck
        End Set
    End Property

    Private Sub rdo_uncheck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click
        If _uncheck Then                                    ' uncheck = false
            If _bool Then                                   ' bool = checked
                Me.Checked = False                          ' then radio button was unchecked
            Else                                            ' else not radio button was checked
                Me.Checked = True
            End If
            _bool = Me.Checked
        End If
    End Sub

    Private Sub rdo_checkchange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.CheckedChanged
        _bool = Not Me.Checked                        ' then radio button will unchecked
    End Sub

End Class