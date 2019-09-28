Imports System.Windows.Forms
Imports System.Drawing
Imports connectionlib.connectionlib

Public Class textbox

    Private _disabledbackcolor As Color = Color.FromArgb(224, 224, 224)     ' declaring its variable where variable has already a value
    Private _disabledforecolor As Color = Color.DarkBlue                    ' declaring its variable where variable has already a value
    Private _textstr As String = ""                                         ' declaring its variable where variable has an empty value
    Private _value As String = ""                                           ' declaring its variable where variable has an empty value
    Private _multiline As Boolean = False                                   ' declaring its variable where variable is false
    Private _numberformat As String = "@"                                   ' declaring its variable where variable has already a value
    Private _bordercolor As Color = Color.DarkGray                          ' declaring its variable where variable has already a value
    Private _rowdata As DataRow                                             ' declaring its variable
    Private _tabledata As DataTable                                         ' declaring its vraiable
    Private _rect As New Rectangle                                          ' declaring its variable
    Private _alwaysenable As Boolean = False                                ' declaring its variable where variable is false
    Private _alwaysdisable As Boolean = False                               ' declaring its variable where variable is false
    Private _noclear As Boolean = False                                     ' declaring its variable where variable is false
    Private _textsource As String = ""                                      ' declaring its variable where variable has an empty value
    Private _valuesource As String = ""                                     ' declaring its variable where variable has an empty value
    Private _datasource As String = ""                                      ' declaring its variable where variable has an empty value
    Private _enabledbackcolor As Color = Color.White                        ' declaring its variabloe where variable has already a value
    Private _ispk As Boolean = False                                        ' declaring its variable where variable is false

    'emon - 2017-07-20
    Public Property MinimumValue As Decimal = 0

    'jesa - 2017-04-24
    Public Property ispk() As Boolean
        Get                                                                 ' retrieving the value of the private variable ispk 
            Return _ispk
        End Get
        Set(value As Boolean)                                               ' holding the selected value in the private variable ispk
            _ispk = value
        End Set
    End Property

    'emon - 2017-04-21
    Public Property EnabledBackColor() As Color
        Get                                                             ' retrieving the value of the private variable enablebckcolor 
            Return _enabledbackcolor
        End Get
        Set(value As Color)                                             ' holding the selected value in the private variable enablebckcolor
            _enabledbackcolor = value
        End Set
    End Property

    'raymond - 2016-05-06
    Private _required As Boolean = False

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

    Public Property Required() As Boolean
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _required
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Boolean)
            _required = value
        End Set
    End Property

    Public Property UseSystemPasswordChar() As Boolean
        ' Retrieves the value of the private variable colBColor.
        Get
            Return txt.UseSystemPasswordChar
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Boolean)
            txt.UseSystemPasswordChar = value
        End Set
    End Property

    Private Sub textbox_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If MultiLine Then                                                           ' multine = false
            txt.Height = Me.Height - 7
            txt.Top = 3
        Else
            txt.Top = ((Me.Height - txt.Height) / 2) - 1
        End If
    End Sub

    Public Property _Text() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _textstr
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _textstr = value
            txt.Text = value
        End Set
    End Property

    Public Property DisabledBackColor() As Color
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _disabledbackcolor
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Color)
            _disabledbackcolor = value
        End Set
    End Property

    Public Property DisabledForeColor() As Color
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _disabledforecolor
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Color)
            _disabledforecolor = value
        End Set
    End Property

    Public Property Value() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return IIf(_value = "", IIf(_numberformat.Substring(0, 1) = "#", _textstr.Replace(",", ""), _textstr), _value)
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _value = value
        End Set
    End Property

    Public Overrides Property Text() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _textstr
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            txt.Text = value
            Me.Invalidate(_rect)
        End Set
    End Property

    Public Property DecimalValue() As Decimal
        ' Retrieves the value of the private variable colBColor.
        Get
            Dim _val As Decimal = 0.0
            If Not txt.Text = "" Then
                _val = Val(txt.Text.Replace(",", ""))
            End If
            Return _val
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Decimal)
            txt.Text = IIf(_numberformat.Substring(0, 1) = "#", Format(value, _numberformat), "")
            Me.Invalidate(_rect)
        End Set
    End Property

    Public Property AlwaysEnable() As Boolean
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _alwaysenable
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Boolean)
            _alwaysenable = value
        End Set
    End Property

    Public Property AlwaysDisable() As Boolean
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _alwaysdisable
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Boolean)
            _alwaysdisable = value
        End Set
    End Property

    Public Property NoClear() As Boolean
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _noclear
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Boolean)
            _noclear = value
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

    Public Property MultiLine() As Boolean
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _multiline
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Boolean)
            _multiline = value
            txt.Multiline = value
            If value Then
                txt.Top = 0
                txt.Height = Me.Height
            Else
                txt.Top = ((Me.Height - txt.Height) / 2) - 1
            End If
        End Set
    End Property

    Public Property NumberFormat() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _numberformat
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _numberformat = value
            If "Nid#".IndexOf(value.Substring(0, 1)) >= 0 Then
                txt.TextAlign = HorizontalAlignment.Right
                'txt.MaxLength = 17
            Else
                txt.TextAlign = HorizontalAlignment.Left
                txt.MaxLength = 32767
            End If
        End Set
    End Property

    Public Property AllowNegative As Boolean = False

    Public Property SelectionStart() As Integer
        ' Retrieves the value of the private variable colBColor.
        Get
            Return txt.SelectionStart
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Integer)
            txt.SelectionStart = value
        End Set
    End Property

    Public Property SelectionLength() As Integer
        ' Retrieves the value of the private variable colBColor.
        Get
            Return txt.SelectionLength
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Integer)
            txt.SelectionLength = value
        End Set
    End Property

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

    Public Property RowData() As DataRow
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _rowdata
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As DataRow)
            _rowdata = value
        End Set
    End Property

    Public Property TableData() As DataTable
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _tabledata
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As DataTable)
            _tabledata = value
        End Set
    End Property

    Private Sub textbox_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled = True Then                                               ' if textbox was enabled
            Me.BackColor = EnabledBackColor                                     ' then back color will enable as well as
            Me.ForeColor = Color.Black                                          ' its fore color
        Else
            Me.BackColor = _disabledbackcolor
            Me.ForeColor = _disabledforecolor
        End If
    End Sub

    Private Sub textbox_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        txt.BackColor = Me.BackColor
    End Sub

    Private Sub textbox_ForeColorChanged(sender As Object, e As EventArgs) Handles Me.ForeColorChanged
        txt.ForeColor = Me.ForeColor
    End Sub

    Public Event TextChange(sender As Object, e As EventArgs)

    Private Sub txt_KeyDown(sender As Object, e As KeyEventArgs) Handles txt.KeyDown

        If Not NumberFormat = "@" And Not NumberFormat = "" Then
            If (e.KeyCode) <> 8 Then
                If (Asc(e.KeyValue) < 48 Or Asc(e.KeyValue) > 57) And Not e.KeyCode = Keys.OemPeriod Then
                    Dim h As Boolean = True
                    If e.Control Then
                        If e.KeyCode = Keys.A Or e.KeyCode = Keys.V Or e.KeyCode = Keys.C Or e.KeyCode = Keys.X Or e.KeyCode = Keys.Z Then
                            h = False
                        End If
                    End If
                    e.Handled = h
                Else
                    If NumberFormat.Substring(0, 1) = "#" Then
                        Dim dp = txt.Text.IndexOf(".")
                        If dp < 0 Then dp = txt.Text.Length
                        Dim s = txt.SelectionStart
                        If txt.Text.Length >= 17 Then
                            If dp > s Then
                                e.Handled = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If e.KeyValue = 13 Then
            If Not MultiLine Then
                If Not e.Control Then
                    SendKeys.Send("{TAB}")
                    e.SuppressKeyPress = True
                End If
            End If
        End If
    End Sub

    Private Sub txt_Enter(sender As Object, e As EventArgs) Handles txt.Enter
        txt.Focus()
        txt.SelectAll()
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txt.TextChanged
        If Not NumberFormat = "@" And Not NumberFormat = "" Then
            If txt.Enabled = True Then
                If NumberFormat.Substring(0, 1) = "#" Then
                    If txt.Text = "" Then
                        txt.Text = "0"
                    End If
                    Dim nod = False
                    Dim donly = False
                    Dim dp = txt.Text.IndexOf(".")
                    If dp < 0 Then nod = True
                    If dp = 0 Then donly = True
                    Dim n1 = txt.Text.Length
                    Dim c1 = txt.Text.Split(",").Length - 1
                    Dim lz = 0
                    If txt.Text.Substring(0, 1) = "0" Then lz = 1
                    Dim s = txt.SelectionStart
                    Dim d = txt.Text.Split(".").Length
                    If d > 2 Then txt.Text = txt.Text.Substring(0, s - 1) & txt.Text.Substring(s)
                    txt.Text = Format(Val(txt.Text.Replace(",", "")), NumberFormat)
                    Dim n2 = txt.Text.Length
                    Dim c2 = txt.Text.Split(",").Length - 1
                    Dim cx = 0
                    If c1 > c2 Then cx = c1 - c2
                    If c2 > c1 Then cx = c2 - c1
                    Dim toS = 0
                    If s > 0 And s <= txt.Text.Length Then
                        If txt.Text.Substring(0, s).Contains(",") Then
                            toS = txt.Text.Substring(0, txt.SelectionStart).Split(",").Length - 1
                            'cx += 1
                            's += toS
                        End If
                    End If
                    Dim sn = s + (n2 - n1) - lz - cx
                    dp = txt.Text.IndexOf(".")
                    If dp < 0 Then dp = txt.Text.Length
                    If d > 2 Then
                        sn = dp + 1
                    Else
                        If dp < s Then sn = sn + 1
                        If dp = 1 Then
                            If txt.Text.Substring(0, 1) = "0" Then
                                sn = sn + 1
                            End If
                        End If
                    End If
                    If sn <= 0 Then sn = 1
                    If nod Then sn = s + cx Else sn = s + cx
                    If donly Then sn = dp + 1
                    txt.SelectionStart = sn
                    If txt.SelectionStart = 1 Then
                        If txt.Text.IndexOf(".") = 2 Then
                            If txt.Text.Substring(1, 2) = "0." Then
                                txt.Text = Format(Val(txt.Text.Substring(0, 1) & txt.Text.Substring(2)), NumberFormat)
                            End If
                        End If
                    End If
                End If
                If NumberFormat = "d" Then
                    If Not txt.Text = "" Then
                        Dim mm As String = "  "
                        Dim dd As String = "  "
                        Dim yy As String = "    "
                        Dim ss As Integer = txt.SelectionStart
                        Dim s1 As Integer = txt.Text.IndexOf("/")
                        Dim s2 As Integer = txt.Text.IndexOf("/", s1 + 1)
                        Dim sx As Integer = 0
                        If s1 > 0 Then
                            If s1 > 2 Then
                                If s2 < 0 Then
                                    mm = txt.Text.Substring(0, 1) & " "
                                    s2 = s1
                                    s1 = 1
                                    sx = -2
                                Else
                                    mm = txt.Text.Substring(0, s1)
                                End If
                            Else
                                mm = txt.Text.Substring(0, s1)
                            End If
                            If s2 >= 0 Then
                                dd = txt.Text.Substring(s1 + 1, s2 - s1 - 1)
                            Else
                                dd = txt.Text.Substring(s1 + 1, 1) & " "
                                sx = -2
                                s2 = s1 + 2
                            End If
                            yy = txt.Text.Substring(s2 + 1)
                            If mm.Length > 2 Then
                                If ss = mm.Length Then
                                    Dim mmx = mm.Substring(2)
                                    mm = mm.Substring(0, 2)
                                    dd = mmx & dd.Substring(1)
                                    sx = 1
                                Else
                                    mm = mm.Substring(0, ss) & mm.Substring(ss + 1)
                                End If
                            End If
                            If dd.Length > 2 Then
                                If ss - s1 - 1 = dd.Length Then
                                    Dim ddx = dd.Substring(2)
                                    dd = dd.Substring(0, 2)
                                    yy = ddx & yy.Substring(1)
                                    sx = 1
                                Else
                                    dd = dd.Substring(0, ss - s1 - 1) & dd.Substring(ss - s1)
                                End If
                            End If
                            If yy.Length > 4 Then
                                If yy.ToString.Contains(" 00:00:00") Then
                                    yy = yy.ToString.Replace(" 00:00:00", "")
                                Else
                                    If ss < txt.Text.Length Then
                                        Dim x = ss - s2 - 1
                                        Dim y = ss - s2 + 1
                                        yy = (yy.Substring(0, ss - s2 - 1) & yy.Substring(ss - s2))
                                    End If
                                End If
                            End If
                        Else
                            mm = (txt.Text & mm).Substring(0, 2)
                        End If
                        yy = (yy & "    ").Substring(0, 4)
                        If Val(mm) > 12 Then mm = "12"
                        If Not Trim(dd) = "" And Not Trim(yy) = "" And Not Trim(mm) = "" Then
                            If Val(mm) > 0 And Val(yy) > 0 Then
                                Dim daylast As Integer = (Convert.ToDateTime(mm & "/01/" & yy).AddMonths(1).AddDays(-1)).Day()
                                If Val(dd) > daylast Then dd = daylast
                            End If
                        End If
                        txt.Text = mm & "/" & dd & "/" & yy
                        If ss = 2 Or ss = 5 Then ss += 1
                        ss += sx
                        txt.SelectionStart = ss
                    End If
                End If
            Else
                If NumberFormat.Substring(0, 1) = "#" Then
                    txt.Text = Format(Val(txt.Text.Replace(",", "")), NumberFormat)
                End If
            End If
        End If
        _textstr = txt.Text
        RaiseEvent TextChange(sender, e)
    End Sub

    Public Shadows Event Leave(sender As Object, e As EventArgs)

    Private Sub txt_Leave(sender As Object, e As EventArgs) Handles txt.Leave

        txt.Text = txt.Text.Trim
        If Text = "" Then                               ' if txt is null
            Value = ""                                  ' then its value is null
        End If
        If Not AllowNegative Then
            If DecimalValue < MinimumValue Then
                DecimalValue = MinimumValue
            End If
        End If
        RaiseEvent Leave(Me, e)
    End Sub

    Private Sub textbox_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged
        txt.Font = Me.Font                              ' fontxt is equal to its txtbox font
        If (txt.Height - Me.Height < 6) Then
            Me.Height = txt.Height + 6
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        If txt.Enabled Then
            txt.ForeColor = Color.Black
            txt.Visible = True
        Else
            Dim _dfc As SolidBrush = New SolidBrush(_disabledforecolor)
            Dim sf As SizeF = e.Graphics.MeasureString(txt.Text, Me.Font, txt.Width)
            Dim tp As New Point
            tp.X = IIf(txt.TextAlign = HorizontalAlignment.Left, txt.Left - 2,
                       IIf(txt.TextAlign = HorizontalAlignment.Right, txt.Width - sf.Width + 4, (txt.Width / 2) - (sf.Width / 2)))
            tp.Y = txt.Top
            e.Graphics.DrawString(txt.Text, Me.Font, _dfc, tp)
            txt.Visible = False
        End If
    End Sub

    Private Sub textbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MultiLine Then
            Me.Height = 48
        End If
    End Sub

    Private Sub txt_MouseDown(sender As Object, e As MouseEventArgs) Handles txt.MouseDown
        txt.Focus()
        txt.SelectAll()
    End Sub

End Class
