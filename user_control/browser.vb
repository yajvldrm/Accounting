Imports System.Windows.Forms
Imports System.Drawing
Imports System.Reflection

Public Class browser
    Public dt As DataTable = New DataTable
    Private _BrowseLabel As String = "Code,Name"
    Private _BrowseLabelWidth As String = "100,200"
    Private WithControl As Boolean = False
    Private FoundRows As Integer = 0
    Private currentIndex = 0
    Private Sub browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgview.AutoGenerateColumns = False
        dgview.DataSource = dt
        txtBrowse.Enabled = True
    End Sub
    Public Sub format(header As String, field As String, width As String)
        Dim hdr() As String = header.Split(",")
        Dim fld() As String = field.Split(",")
        Dim wid() As String = width.Split(",")
        Dim tw As Integer = 0

        dgview.Columns.Clear()
        If Not fld(0) = "" Then
            For i = 0 To fld.Length - 1
                Dim col As New DataGridViewTextBoxColumn
                col.Name = fld(i)
                col.DataPropertyName = fld(i)
                col.HeaderText = hdr(i)
                col.Width = Val(wid(i))
                If fld.Length = 1 Then
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Else
                    If i > 0 Then
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    End If
                End If
                col.HeaderCell.Style.Font = New Font("Verdana", 8, FontStyle.Bold)
                col.ReadOnly = True

                dgview.Columns.Add(col)
                tw = tw + wid(i) + 1
            Next
        End If
        If tw > 0 Then
            tw = tw + 1
        Else
            tw = 203
        End If
        Me.Width = tw + 26
        dgview.Width = tw

        'btnok.Left = (Me.Width / 2) - btnok.Width
        'btncancel.Left = btnok.Left + btnok.Width - 1
    End Sub
    Private Sub txtBrowse_TextChanged(sender As Object, e As EventArgs) Handles txtBrowse.TextChanged
        Dim dt3 = dt.Copy()
        Dim drs() As DataRow
        Dim lr As Boolean = True
        Dim q = txtBrowse.Text.ToString.Replace("'", "").Replace("`", "").Replace("%", "").Replace("ñ", "").Replace("Ñ", "")
        Dim srch As String = ""
        For i = 0 To dgview.Columns.Count - 1
            srch = srch & IIf(srch = "", "", " or ") & dgview.Columns(i).DataPropertyName & " like '%" & q & "%'"
        Next
        lr = False
        drs = dt3.Select(srch)
        FoundRows = drs.Length
        If drs.Length > 0 Then
            'Dim fi As FieldInfo = dr(index).GetType().GetField("_rowID", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
            'Dim rowID As Integer = fi.GetValue(dr(index))
            'dgBrowse.Rows(rowID - 1).Cells(0).Selected = True
            'If index >= FoundRows Then
            '    index = 0
            'End If
            'Dim dr = drs(index)
            'dgBrowse.ClearSelection()
            'dgBrowse.Rows(dt3.Rows.IndexOf(dr)).Selected = True
            'dgBrowse.FirstDisplayedScrollingRowIndex = dt3.Rows.IndexOf(dr)
            Dim newDt = dt.Clone
            newDt.Clear()
            For Each dr In drs
                newDt.ImportRow(dr)
            Next
            dgview.DataSource = newDt
            txtBrowse.BackColor = Color.White
        Else
            txtBrowse.BackColor = Color.FromArgb(255, 192, 192)
        End If
    End Sub
    Private Sub dgBrowse_Enter(sender As Object, e As EventArgs) Handles dgview.Enter
        'txtBrowse.Focus()
    End Sub
    Private Sub browser_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtBrowse.Focus()
    End Sub
    Private Sub txtBrowse_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtBrowse.KeyPress
        If Asc(e.KeyChar) = 27 Then
            Me.Close()
        ElseIf Asc(e.KeyChar) = 13 Then
            If Not WithControl Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub dgBrowse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgview.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtBrowse.Focus()
            Return
        Else
            txtBrowse.Focus()
            txtBrowse.Text &= e.KeyChar
            txtBrowse.SelectionStart = txtBrowse.Text.Length
            txtBrowse.SelectionLength = 0
        End If
    End Sub
    Private Sub txtBrowse_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBrowse.KeyDown
        WithControl = False
        If e.Control Then
            WithControl = True
        End If
        If e.KeyCode = Keys.Enter Then
            'txtBrowse_TextChanged(Nothing, Nothing, currentIndex)
            'currentIndex += 1
            'If currentIndex >= FoundRows Then
            '    currentIndex = 0
            'End If
            e.SuppressKeyPress = True
            dgview_DoubleClick(Nothing, Nothing)
        End If
        If e.KeyCode = 38 Or e.KeyCode = 40 Or e.KeyCode = 35 Or e.KeyCode = 36 Or e.KeyCode = 34 Or e.KeyCode = 33 Then
            If dgview.SelectedRows.Count = 1 Then
                Dim selectedRow = dgview.SelectedRows(0)
                If selectedRow.Index > 0 Then
                    If e.KeyCode = 38 Then 'up
                        dgview.Rows(selectedRow.Index - 1).Selected = True
                        dgview.FirstDisplayedScrollingRowIndex = selectedRow.Index - 1
                    End If
                    Dim newIndex = selectedRow.Index - 13
                    If newIndex < 0 Then
                        newIndex = 0
                    End If
                    If e.KeyCode = 33 Then 'page up
                        dgview.Rows(newIndex).Selected = True
                        dgview.FirstDisplayedScrollingRowIndex = newIndex
                    End If
                End If
                If selectedRow.Index < dgview.Rows.Count - 1 Then
                    If e.KeyCode = 40 Then 'down
                        dgview.Rows(selectedRow.Index + 1).Selected = True
                        dgview.FirstDisplayedScrollingRowIndex = selectedRow.Index + 1
                    End If
                    Dim newIndex = selectedRow.Index + 13
                    If newIndex > dgview.Rows.Count - 1 Then
                        newIndex = dgview.Rows.Count - 1
                    End If
                    If e.KeyCode = 34 Then 'page down
                        dgview.Rows(newIndex).Selected = True
                        dgview.FirstDisplayedScrollingRowIndex = newIndex
                    End If
                End If
                If e.KeyCode = 35 Then 'end
                    dgview.Rows(dgview.Rows.Count - 1).Selected = True
                    dgview.FirstDisplayedScrollingRowIndex = dgview.Rows.Count - 1
                End If
                If e.KeyCode = 36 Then 'home
                    dgview.Rows(0).Selected = True
                    dgview.FirstDisplayedScrollingRowIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub txtBrowse_MouseMove(sender As Object, e As MouseEventArgs) Handles txtBrowse.MouseWheel
        dgview.Focus()
    End Sub

    Private Sub dgview_DoubleClick(sender As Object, e As EventArgs) Handles dgview.DoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
End Class