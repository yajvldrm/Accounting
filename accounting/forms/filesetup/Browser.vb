Imports System.Drawing
Imports connectionlib.connectionlib
Public Class Browser
    Public Enum Database
        FileSetup = 1
        Main = 2
    End Enum
    Public dtMain As DataTable
    Private WithControl As Boolean = False
    Private _value As Integer
    Public Property Value() As Integer
        Get
            Return _value
        End Get
        Set(ByVal value As Integer)
            _value = value
        End Set
    End Property
    Private _code As String
    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property
    Private _display As String
    Public Property DisplayString() As String
        Get
            Return _display
        End Get
        Set(ByVal value As String)
            _display = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub SetDefaults()
        dtMain = FsQuery("SELECT account_id, account_code, account_name FROM lib_erp_chart a LEFT JOIN lib_acc_chart_class b on a.chart_class_id = b.chart_class_id WHERE chart_type in ('I', 'E')")
        colID.DataPropertyName = "account_id"
        colCode.DataPropertyName = "account_code"
        colName.DataPropertyName = "account_name"
        dgv.DataSource = dtMain
    End Sub

    Public Sub SetDataPropertyName(id As String, code As String, name As String)
        colID.DataPropertyName = id
        colCode.DataPropertyName = code
        colName.DataPropertyName = name
    End Sub
    Public Sub SetQuery(sql As String, mode As Database)
        If mode = Database.FileSetup Then
            dtMain = FsQuery(sql)
        Else
            dtMain = Query(sql)
        End If
        dgv.DataSource = dtMain
    End Sub

    Private Sub Browser_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        Select Case e.KeyCode
            Case 27
                Me.Close()
            Case 13
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Dim i = dgv.SelectedRows(0).Index
                Value = dgv.Item(0, i).Value
                Code = dgv.Item(1, i).Value
                DisplayString = dgv.Item(2, i).Value
                Me.Hide()
        End Select
        If e.KeyCode = 38 Or e.KeyCode = 40 Or e.KeyCode = 35 Or e.KeyCode = 36 Or e.KeyCode = 34 Or e.KeyCode = 33 Then
            If dgv.SelectedRows.Count = 1 Then
                Dim selectedRow = dgv.SelectedRows(0)
                If selectedRow.Index > 0 Then
                    If e.KeyCode = 38 Then 'up
                        dgv.Rows(selectedRow.Index - 1).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = selectedRow.Index - 1
                    End If
                    Dim newIndex = selectedRow.Index - 13
                    If newIndex < 0 Then
                        newIndex = 0
                    End If
                    If e.KeyCode = 33 Then 'page up
                        dgv.Rows(newIndex).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = newIndex
                    End If
                End If
                If selectedRow.Index < dgv.Rows.Count - 1 Then
                    If e.KeyCode = 40 Then 'down
                        dgv.Rows(selectedRow.Index + 1).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = selectedRow.Index + 1
                    End If
                    Dim newIndex = selectedRow.Index + 13
                    If newIndex > dgv.Rows.Count - 1 Then
                        newIndex = dgv.Rows.Count - 1
                    End If
                    If e.KeyCode = 34 Then 'page down
                        dgv.Rows(newIndex).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = newIndex
                    End If
                End If
                If e.KeyCode = 35 Then 'end
                    dgv.Rows(dgv.Rows.Count - 1).Selected = True
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1
                End If
                If e.KeyCode = 36 Then 'home
                    dgv.Rows(0).Selected = True
                    dgv.FirstDisplayedScrollingRowIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub dgv_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles dgv.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSearch.Focus()
            Return
        Else
            txtSearch.Focus()
            txtSearch.Text &= e.KeyChar
            txtSearch.SelectionStart = txtSearch.Text.Length
            txtSearch.SelectionLength = 0
        End If
    End Sub

    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dtMain Is Nothing Or dtMain.Rows.Count <= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Me.Dispose()
        ElseIf dtMain.Rows.Count = 1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Value = dgv.Item(0, 0).Value
            Code = dgv.Item(1, 0).Value
            DisplayString = dgv.Item(2, 0).Value
            Me.Dispose()
        End If
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Dim i = dgv.SelectedRows(0).Index
        Value = dgv.Item(0, i).Value
        Code = dgv.Item(1, i).Value
        DisplayString = dgv.Item(2, i).Value
        Me.Hide()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            dgv.DataSource = dtMain
            txtSearch.BackColor = Color.White
        Else
            Dim q = txtSearch.Text.ToString.Replace("'", "").Replace("`", "").Replace("%", "").Replace("ñ", "").Replace("Ñ", "")
            Dim srch As String = ""
            For i = 1 To dgv.Columns.Count - 1
                srch = srch & IIf(srch = "", "", " or ") & dgv.Columns(i).DataPropertyName & " like '%" & q & "%'"
            Next
            Dim dtClone = dtMain.Copy()
            Dim drs() As DataRow = dtClone.Select(srch)
            If drs.Count > 0 Then
                dtClone = drs.CopyToDataTable
                dgv.DataSource = dtClone
                txtSearch.BackColor = Color.White
            Else
                dgv.DataSource = dtMain
                txtSearch.BackColor = Color.FromArgb(255, 192, 192)
            End If

        End If
    End Sub
End Class