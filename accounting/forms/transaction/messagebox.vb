Public Class messagebox
    Private _MsgTitle As String
    Private _MsgIcon As String
    Private _MsgIconUrl As String

    Public Property MsgTitle() As String
        Get
            Return _MsgTitle
        End Get
        Set(value As String)
            _MsgTitle = value
        End Set
    End Property
    Public Property MsgIcon() As String
        Get
            Return _MsgIcon
        End Get
        Set(value As String)
            _MsgIcon = value
        End Set
    End Property
    Public Property MsgIconUrl() As String
        Get
            Return _MsgIconUrl
        End Get
        Set(value As String)
            _MsgIconUrl = value
        End Set
    End Property

    Private Sub messagebox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = MsgTitle

    End Sub
End Class