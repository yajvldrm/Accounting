Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class MyTextBox
#Region "Declaration of Variable"
    Private _EnabledBackColor = Drawing.Color.White
    Private _EnabledForeColor = Drawing.Color.Black
    Private _DisabledBackColor = Drawing.Color.FromArgb(224, 224, 224)
    Private _DisabledForeColor = Drawing.Color.DarkBlue
    'Private _TextSource As String = ""
    'Private _ValueSource As String = ""
    'Private _AlwaysEnable As Boolean = False
    'Private _AlwaysDisable As Boolean = False
    Private _Value As String = ""
    Private _DecimalValue As Decimal = 0
    Private _NumberFormat As String = "@"
    Private _Enabled As Boolean = False
    Private tmp_s As Integer = -1
    Private oldStr As String = ""
    Private _currentIndex As Integer = 0
#Region "For Browse"
    Private _BrowseUpdate As New List(Of MyTextBoxList)
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public Property BrowseUpdate As List(Of MyTextBoxList)
        Get
            Return _BrowseUpdate
        End Get
        Set(value As List(Of MyTextBoxList))
            _BrowseUpdate = value
        End Set
    End Property
#End Region
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
    Public Property Unique As Boolean = False
    Public Property Required As Boolean = False
    Public Property TextBrowse As Boolean = False
    Public Property TextSource As String = ""
    Public Property ValueSource As String = ""
    Public Property AlwaysEnable As Boolean = False
    Public Property AlwaysDisable As Boolean = False
    Public Property NoClear As Boolean = False
    Public Property ToUpper As Boolean = True
    Public Property ID As Boolean = False
    Public Property NoSave As Boolean = False
    Public Property NumberFormat() As String
        Get
            Return _NumberFormat
        End Get
        Set(value As String)
            _NumberFormat = value
            Me.TextAlign = HorizontalAlignment.Left
            If value <> "" And value <> "@" Then
                toNumeric(value)
                Me.TextAlign = HorizontalAlignment.Right
            End If
        End Set
    End Property
    Public Property DecimalValue() As Decimal
        Get
            Dim str As Decimal = 0
            If IsNumeric(Me.Text.ToString.Replace(",", "")) And Me.Text.ToString.Replace(",", "") <> "" Then
                str = Me.Text.ToString.Replace(",", "")
            End If
            Return str
        End Get
        Set(value As Decimal)
            Dim str As Decimal = 0
            If NumberFormat <> "" And NumberFormat <> "@" Then
                If IsNumeric(value.ToString.Replace(",", "")) Then
                    str = value.ToString.Replace(",", "")
                End If
                _DecimalValue = str
                Me.Text = str
                formatMyString()
                'toNumeric(Me.NumberFormat)
            End If
        End Set
    End Property
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
            Dim isChange As Boolean = False
            If _Value <> value Then
                isChange = True
            End If
            _Value = value
            If Me.NumberFormat <> "" And Me.NumberFormat <> "@" Then
                If value = "" Then
                    Me.Text = 0
                    Me.DecimalValue = 0
                Else
                    Me.Text = value.ToString.Replace(",", "")
                End If
            Else
                Me.Text = value
            End If
            If isChange Then
                RaiseEvent ValueChange(Me, New EventArgs)
            End If
        End Set
    End Property
#Region "For Browse"
    Public Property BrowseTextSource As String = ""
    Public Property BrowseValueSource As String = ""
    Public Property BrowseDataSource As String = ""
    Public Property BrowseField As String = ""
    Public Property BrowseLabel As String = "Code,Name"
    Public Property BrowseLabelWidth As String = "100,200"
    Public Property Database As MyList.Database = MyList.Database.FileSetup
    Public Property RowData As DataRow
    Public Property BrowseFilter As MyTextBox
#End Region
#End Region
#Region "Event Handler"
    Private Sub Me_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        _currentIndex = Me.SelectionStart
        oldStr = Me.Text
        If Not NumberFormat = "@" And Not NumberFormat = "" Then
            If Asc(e.KeyCode) <> 8 Then
                If (Asc(e.KeyValue) < 48 Or Asc(e.KeyValue) > 57) And Not e.KeyCode = Keys.OemPeriod Then
                    Dim h As Boolean = True
                    If e.Control Then
                        If e.KeyCode = Keys.A Or e.KeyCode = Keys.V Or e.KeyCode = Keys.C Or e.KeyCode = Keys.X Then
                            h = False
                        End If
                    End If
                    e.Handled = h
                Else
                    If NumberFormat.Substring(0, 1) = "#" Then
                        Dim dp = Me.Text.IndexOf(".")
                        If dp < 0 Then dp = Me.Text.Length
                        Dim s = Me.SelectionStart
                        If Me.Text.Length >= 17 Then
                            If dp > s Then
                                e.Handled = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If e.KeyCode = 13 Then
            If Not Me.Multiline Then
                e.SuppressKeyPress = True
                SendKeys.Send("{TAB}")
            End If
        End If
    End Sub
    Private Sub Me_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        If Not Me.Enabled Then
            SendKeys.Send("{TAB}")
        Else
            Me.SelectionStart = 0
            Me.SelectionLength = Me.Text.Length
        End If
    End Sub
    Private Sub Me_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        If Me.Enabled Then
            If Text = "" Then                               ' if txt is null
                Value = ""                                  ' then its value is null
                RowData = Nothing
            End If
            If Me.TextBrowse Then
                callBrowser()
            End If
        Else
            Return
        End If
    End Sub
    Private Sub Me_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        If Me.Enabled Then
            If Me.ToUpper Then
                Dim currenct_selection = Me.SelectionStart
                'Me.Text = Me.Text.ToString.ToUpper
                Me.SelectionStart = currenct_selection
            End If
            formatMyString()
            'If NumberFormat.Contains(",") Then
            '    Dim str = Me.Text
            '    Dim strLength = str.Length
            '    Dim _strLength = oldStr.Length
            '    Me.Text = Format(CType(str.Replace(",", ""), Decimal), NumberFormat)
            '    Dim strToIndex = Me.Text.Substring(0, _currentIndex)
            '    Dim comaFound = 0
            '    If strToIndex.Contains(",") Then
            '        comaFound = strToIndex.Split(",").Length - 1
            '    End If
            '    Dim selectionStart = _currentIndex + comaFound
            '    If selectionStart < 0 Then
            '        selectionStart = 1
            '    End If
            '    Me.SelectionStart = selectionStart
            'End If
        End If
    End Sub
#End Region
#Region "Sub"
    Private Sub toNumeric(ByVal format As String)
        If format.Contains("N") Then
            Dim decimalPlace As Integer = format.Replace("N", "")
            If Me.Text.ToString.Replace(",", "") = "" Then
                Me.Text = "0.".PadRight(2 + decimalPlace, "0")
            End If
            If IsNumeric(Me.Text.ToString.Replace(",", "")) Then
                Dim comma = Me.Text.ToString.Length - (Me.Text.ToString.Replace(",", "").Length)
                Dim periodIndex = Me.Text.ToString.IndexOf(".")
                Dim startSelection = Me.SelectionStart + comma
                Dim temp As Double = Me.Text.ToString.Replace(",", "")
                Me.Text = temp.ToString("F" & decimalPlace)
                Me.SelectionStart = startSelection
                If Me.Text.Contains(".") Then
                End If
            End If
        End If
    End Sub
    Public Sub callBrowser()
        If Me.Enabled Then
            If Me.TextBrowse Then
                If Not Me.Required Then
                    If Me.Text = "" Then
                        Return
                    End If
                End If
                Dim BrowseQuery As String = Functions.getBrowseQuery(Me)
                If Not BrowseFilter Is Nothing Then
                    If BrowseDataSource <> "[terms]" Then
                        Dim filt As MyTextBox = BrowseFilter
                        Dim filtval As String = IIf(filt.Value = "", filt.Text, filt.Value)
                        If filtval <> "" Then
                            BrowseQuery &= " WHERE "
                        End If
                        If filtval = "(null)" Then
                            BrowseQuery &= filt.ValueSource
                            BrowseQuery &= " is null "
                        ElseIf filtval = "!(null)" Then
                            BrowseQuery &= filt.ValueSource
                            BrowseQuery &= " is not null "
                        ElseIf filtval <> "" Then
                            BrowseQuery &= IIf(filt.BrowseValueSource = "", filt.ValueSource, filt.BrowseValueSource)
                            BrowseQuery &= " = '" & filtval & "'"
                        End If
                    End If
                    If BrowseDataSource = "[lib_erp_chart]" Then
                        BrowseQuery &= " GROUP BY a.account_id"
                    ElseIf BrowseDataSource = "[lib_erp_allocation]" Then
                        BrowseQuery &= " GROUP BY a.allocation_id"
                    End If
                End If
                Dim dt As DataTable = Nothing
                If BrowseQuery <> "" Then
                    If Me.Database = MyList.Database.FileSetup Then
                        dt = FsQuery(BrowseQuery)
                    Else
                        dt = Query(BrowseQuery)
                    End If
                End If
                If dt Is Nothing Then
                    Exit Sub
                End If
                If dt.Rows.Count = 0 Then
                    MsgBox("No record found.")
                    Me.Value = ""
                    Me.Text = ""
                    Me.RowData = Nothing
                Else
                    Dim dr As DataRow = Nothing
                    If dt.Rows.Count = 1 Then
                        dr = dt.Rows(0)
                    Else
                        Dim dra() As DataRow = dt.Select(IIf(BrowseTextSource = "", TextSource, BrowseTextSource) & " = '" & Me.Text & "'")
                        If dra.Count = 1 Then
                            dr = dra(0)
                        Else
                            Dim field = Me.BrowseField
                            If field = "" Then
                                If dt.Columns.Count >= 3 Then
                                    field = dt.Columns(1).ColumnName & "," & dt.Columns(2).ColumnName
                                End If
                            End If
                            Dim myBrowse As New browser
                            'myBrowse.CallForm = CallForm
                            myBrowse.dt = dt
                            myBrowse.format(Me.BrowseLabel, field, Me.BrowseLabelWidth)
                            myBrowse.Select()
                            If myBrowse.ShowDialog() = DialogResult.OK Then
                                If myBrowse.dgview.SelectedRows.Count > 0 Then
                                    Dim _id = myBrowse.dgview.SelectedRows(0).Cells(0).Value.ToString
                                    Dim _field = myBrowse.dgview.Columns(0).DataPropertyName
                                    Dim _drs = myBrowse.dt.Select(_field & " = '" & _id & "'")
                                    If _drs.Length > 0 Then
                                        dr = _drs(0)
                                    Else
                                        dr = myBrowse.dt.Rows(myBrowse.dgview.SelectedRows(0).Index)
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If Not dr Is Nothing Then
                        RowData = dr
                        Value = dr(IIf(BrowseValueSource = "", ValueSource, BrowseValueSource))
                        Me.Text = dr(IIf(BrowseTextSource = "", TextSource, BrowseTextSource))
                        If BrowseUpdate IsNot Nothing Then
                            If BrowseUpdate.Count > 0 Then
                                Dim MyForm = Me.FindForm
                                For Each ctrl In BrowseUpdate
                                    Dim ctrs = MyForm.Controls.Find(ctrl.Control, True)
                                    If ctrs.Length > 0 Then
                                        If TypeOf ctrs(0) Is MyTextBox Then
                                            Dim ctr = CType(ctrs(0), MyTextBox)
                                            If ctr.ValueSource <> "" Then
                                                ctr.Value = dr.Item(IIf(ctr.BrowseValueSource = "", ctr.ValueSource, ctr.BrowseValueSource)).ToString
                                            End If
                                            If ctr.TextSource <> "" Then
                                                ctr.Text = dr.Item(IIf(ctr.BrowseTextSource = "", ctr.TextSource, ctr.BrowseTextSource)).ToString
                                            End If
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    Else
                        Me.Value = ""
                        Me.Text = ""
                        Me.RowData = Nothing
                        For Each ctrl In BrowseUpdate
                            Dim MyForm = Me.FindForm
                            Dim ctrs = MyForm.Controls.Find(ctrl.Control, True)
                            If ctrs.Length > 0 Then
                                If TypeOf ctrs(0) Is MyTextBox Then
                                    Dim ctr = CType(ctrs(0), MyTextBox)
                                    If ctr.ValueSource <> "" Then
                                        ctr.Value = ""
                                    End If
                                    If ctr.TextSource <> "" Then
                                        ctr.Text = ""
                                    End If
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub formatMyString()
        If Not NumberFormat = "@" And Not NumberFormat = "" Then
            If Me.Enabled = True Then
                If NumberFormat.Substring(0, 1) = "#" Then
                    If Me.Text = "" Then
                        Me.Text = "0"
                    End If
                    Dim nod = False
                    Dim donly = False
                    Dim dp = Me.Text.IndexOf(".")
                    If dp < 0 Then nod = True
                    If dp = 0 Then donly = True
                    Dim n1 = Me.Text.Length
                    Dim c1 = Me.Text.Split(",").Length - 1
                    Dim lz = 0
                    If Me.Text.Substring(0, 1) = "0" Then lz = 1
                    Dim s = Me.SelectionStart
                    Dim d = Me.Text.Split(".").Length
                    If d > 2 Then Me.Text = Me.Text.Substring(0, s - 1) & Me.Text.Substring(s)
                    Me.Text = Format(Val(Me.Text.Replace(",", "")), NumberFormat)
                    Dim n2 = Me.Text.Length
                    Dim c2 = Me.Text.Split(",").Length - 1
                    Dim cx = 0
                    If c1 > c2 Then cx = c1 - c2
                    If c2 > c1 Then cx = c2 - c1
                    Dim toS = 0
                    If s <= Me.Text.Length Then
                        If Me.Text.Substring(0, s).Contains(",") Then
                            toS = Me.Text.Substring(0, Me.SelectionStart).Split(",").Length - 1
                            'cx += 1
                            's += toS
                        End If
                    End If
                    Dim sn = s + (n2 - n1) - lz - cx
                    dp = Me.Text.IndexOf(".")
                    If dp < 0 Then dp = Me.Text.Length
                    If d > 2 Then
                        sn = dp + 1
                    Else
                        If dp < s Then sn = sn + 1
                        If dp = 1 Then
                            If Me.Text.Substring(0, 1) = "0" Then
                                sn = sn + 1
                            End If
                        End If
                    End If
                    If nod Then sn = s + cx Else sn = s + cx
                    If sn <= 0 Then sn = 1
                    If donly Then sn = dp + 1
                    Me.SelectionStart = sn
                    If Me.SelectionStart = 1 Then
                        If Me.Text.IndexOf(".") = 2 Then
                            If Me.Text.Substring(1, 2) = "0." Then
                                Me.Text = Format(Val(Me.Text.Substring(0, 1) & Me.Text.Substring(2)), NumberFormat)
                            End If
                        End If
                    End If
                End If
                If NumberFormat = "d" Then
                    If Not Me.Text = "" Then
                        Dim mm As String = "  "
                        Dim dd As String = "  "
                        Dim yy As String = "    "
                        Dim ss As Integer = Me.SelectionStart
                        Dim s1 As Integer = Me.Text.IndexOf("/")
                        Dim s2 As Integer = Me.Text.IndexOf("/", s1 + 1)
                        Dim sx As Integer = 0
                        If s1 > 0 Then
                            If s1 > 2 Then
                                If s2 < 0 Then
                                    mm = Me.Text.Substring(0, 1) & " "
                                    s2 = s1
                                    s1 = 1
                                    sx = -2
                                Else
                                    mm = Me.Text.Substring(0, s1)
                                End If
                            Else
                                mm = Me.Text.Substring(0, s1)
                            End If
                            If s2 >= 0 Then
                                dd = Me.Text.Substring(s1 + 1, s2 - s1 - 1)
                            Else
                                dd = Me.Text.Substring(s1 + 1, 1) & " "
                                sx = -2
                                s2 = s1 + 2
                            End If
                            yy = Me.Text.Substring(s2 + 1)
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
                                    If ss < Me.Text.Length Then
                                        Dim x = ss - s2 - 1
                                        Dim y = ss - s2 + 1
                                        yy = (yy.Substring(0, ss - s2 - 1) & yy.Substring(ss - s2))
                                    End If
                                End If
                            End If
                        Else
                            mm = (Me.Text & mm).Substring(0, 2)
                        End If
                        yy = (yy & "    ").Substring(0, 4)
                        If Val(mm) > 12 Then mm = "12"
                        If Not Trim(dd) = "" And Not Trim(yy) = "" And Not Trim(mm) = "" Then
                            If Val(mm) > 0 And Val(yy) > 0 Then
                                Dim daylast As Integer = (Convert.ToDateTime(mm & "/01/" & yy).AddMonths(1).AddDays(-1)).Day()
                                If Val(dd) > daylast Then dd = daylast
                            End If
                        End If
                        Me.Text = mm & "/" & dd & "/" & yy
                        If ss = 2 Or ss = 5 Then ss += 1
                        ss += sx
                        Me.SelectionStart = ss
                    End If
                End If
            Else
                If NumberFormat.Substring(0, 1) = "#" Then
                    Me.Text = Format(Val(Me.Text.Replace(",", "")), NumberFormat)
                End If
            End If
        End If
    End Sub
    Public Event ValueChange(sender As Object, e As EventArgs)
#End Region
End Class
