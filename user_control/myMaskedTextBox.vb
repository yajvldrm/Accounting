Imports System.Windows.Forms

Public Class myMaskedTextBox
#Region "Declaration of Variable"
    Private _EnabledBackColor = Drawing.Color.White
    Private _EnabledForeColor = Drawing.Color.Black
    Private _DisabledBackColor = Drawing.Color.FromArgb(224, 224, 224)
    Private _DisabledForeColor = Drawing.Color.DarkBlue
    Private _Value As String = ""
    Private _Enabled As Boolean = False
#End Region
#Region "Property"
    Public Property EnabledBackColor() As Drawing.Color
        Get
            Return _EnabledBackColor
        End Get
        Set(value As Drawing.Color)
            _EnabledBackColor = value
            If Me.Enabled Then
                Me.BackColor = _EnabledBackColor
                Me.ForeColor = _EnabledForeColor
            End If
        End Set
    End Property
    Public Property EnabledForeColor() As Drawing.Color
        Get
            Return _EnabledForeColor
        End Get
        Set(value As Drawing.Color)
            _EnabledForeColor = value
            If Me.Enabled Then
                Me.BackColor = _EnabledBackColor
                Me.ForeColor = _EnabledForeColor
            End If
        End Set
    End Property
    Public Property DisabledBackColor() As Drawing.Color
        Get
            Return _DisabledBackColor
        End Get
        Set(value As Drawing.Color)
            _DisabledBackColor = value
            If Not Me.Enabled Then
                Me.BackColor = _DisabledBackColor
                Me.ForeColor = _DisabledForeColor
            End If
        End Set
    End Property
    Public Property DisabledForeColor() As Drawing.Color
        Get
            Return _DisabledForeColor
        End Get
        Set(value As Drawing.Color)
            _DisabledForeColor = value
            If Not Me.Enabled Then
                Me.BackColor = _DisabledBackColor
                Me.ForeColor = _DisabledForeColor
            End If
        End Set
    End Property
    Public Property Required As Boolean = False
    Public Property TextSource As String = ""
    Public Property ValueSource As String = ""
    Public Property AlwaysEnable As Boolean = False
    Public Property AlwaysDisable As Boolean = False
    Public Property NoClear As Boolean = False
    Public Property NoSave As Boolean = False
    Public Property Unique As Boolean = False
    Public Shadows Property Enabled() As Boolean
        Get
            Return _Enabled
        End Get
        Set(value As Boolean)
            _Enabled = value
            If value Then
                Me.ReadOnly = False
                Me.TabStop = True
                Me.BackColor = _EnabledBackColor
                Me.ForeColor = _EnabledForeColor
            Else
                Me.ReadOnly = True
                Me.TabStop = False
                Me.BackColor = _DisabledBackColor
                Me.ForeColor = _DisabledForeColor
            End If
        End Set
    End Property
    Public Property Value() As String
        Get
            Return _Value
        End Get
        Set(value As String)
            _Value = value
            Me.Text = value
        End Set
    End Property
#End Region
#Region "Event"
    Private Sub Me_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        If Not Me.Enabled Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            ' enter
            If Not Me.Multiline Then
                SendKeys.Send("{TAB}")
            End If
        End If
    End Sub
#End Region
End Class