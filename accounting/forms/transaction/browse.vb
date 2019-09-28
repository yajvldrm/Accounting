
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Reflection
Imports user_control

Public Class browse
    Public Shared dt As DataTable = New DataTable
    Private FoundRows As Integer = 0
    Private currentIndex As Integer = 0
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Hide()
    End Sub

    Private Sub browse_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, dgview.KeyDown
        If e.KeyCode = Keys.Down Then
            If dgview.SelectedRows(0).Index < dgview.Rows.Count - 1 Then
                Dim inc = dgview.SelectedRows.Count
                'Dim currentRowIndex = dgview.CurrentRow.Index
                'dgview.ClearSelection()
                dgview.Rows(dgview.SelectedRows(0).Index + inc).Cells(0).Selected = True
            End If
        End If
        If e.KeyCode = Keys.Up Then
            If dgview.SelectedRows(0).Index > 0 Then
                dgview.Rows(dgview.SelectedRows(0).Index - 1).Cells(0).Selected = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            'If e.Control Then
            '    e.SuppressKeyPress = True
            '    currentIndex += 1
            '    If currentIndex >= FoundRows Then
            '        currentIndex = 0
            '    End If
            '    txtsearch_TextChange(Nothing, Nothing, currentIndex)
            'Else
            'End If
            btnok_Click(sender, e)
        End If
    End Sub

    Private Sub browse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not ActiveControl.Name = "txtsearch" Then
            txtsearch.Text = txtsearch.Text & e.KeyChar
            txtsearch.Focus()
            txtsearch.SelectionStart = txtsearch.Text.Length
        End If
    End Sub

    Private Sub browse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgview.AutoGenerateColumns = False
        dgview.DataSource = dt
    End Sub

    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles txtsearch.TextChange
        Dim dt3 = dt.Copy()
        Dim drs() As DataRow
        Dim lr As Boolean = True

        Dim q = txtsearch.Text.ToString.Replace("'", "").Replace("`", "").Replace("%", "").Replace("ñ", "").Replace("Ñ", "")
        Dim srch As String = ""
        For i = 0 To dgview.Columns.Count - 1
            srch &= String.Format(" OR {0} LIKE '%{1}%'", dgview.Columns(i).DataPropertyName, q)
        Next
        lr = False
        drs = dt3.Select(srch.Substring(4))
        FoundRows = drs.Length
        If drs.Length > 0 Then
            'Dim fi As FieldInfo = dr(0).GetType().GetField("_rowID", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
            'Dim rowID As Integer = fi.GetValue(dr(0))
            'dgview.Rows(rowID - 1).Cells(0).Selected = True
            'txtsearch.BackColor = Color.White
            'If index >= FoundRows Then
            '    index = 0
            'End If
            'Dim dr = drs(index)
            'dgview.ClearSelection()
            'dgview.Rows(dt3.Rows.IndexOf(dr)).Selected = True
            'dgview.FirstDisplayedScrollingRowIndex = dt3.Rows.IndexOf(dr)
            'emon-2017-11-10
            Dim newDt = dt.Clone
            newDt.Clear()
            For Each dr In drs
                newDt.ImportRow(dr)
            Next
            dgview.DataSource = newDt
            'emon-2017-11-10
            txtsearch.BackColor = Color.White
        Else
            'dgview.Rows(dgview.CurrentRow.Index).Cells(0).Selected = False
            dgview.DataSource = dt
            txtsearch.BackColor = Color.FromArgb(255, 192, 192)
        End If
    End Sub

    Private Sub browse_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtsearch.Text = ""
        txtsearch.Focus()
        If dgview.Rows.Count > 0 Then
            If dgview.CurrentRow.Index >= 0 Then
                dgview.Rows(dgview.CurrentRow.Index).Selected = True
            End If
        End If
    End Sub

    Public Sub format(header As String, field As String, width As String)
        Dim hdr() As String = header.Split(",")
        Dim fld() As String = field.Split(",")
        Dim wid() As String = width.Split(",")
        Dim tw As Integer = 0
        Dim defaultWidth As Integer = 0
        dgview.Columns.Clear()
        If Not fld(0) = "" Then
            For i = 0 To fld.Length - 1
                Dim col As New DataGridViewTextBoxColumn
                col.Name = fld(i)
                col.DataPropertyName = fld(i)
                col.HeaderText = hdr(i)
                col.Width = Val(wid(i))
                col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                defaultWidth += wid(i)
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

        btnok.Left = (Me.Width / 2) - btnok.Width
        btncancel.Left = btnok.Left + btnok.Width - 1
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If dgview.SelectedRows.Count > 0 Then
            Dim _id = dgview.SelectedRows(0).Cells(0).Value.ToString
            Dim _field = dgview.Columns(0).DataPropertyName
            Dim _drs = dt.Select(_field & " = '" & _id & "'")
            If _drs.Length > 0 Then
                Dim _dr = _drs(0)
                dgview.DataSource = dt
                For Each row As DataGridViewRow In dgview.Rows
                    If row.Cells(0).Value = _id Then
                        dgview.ClearSelection()
                        row.Selected = True
                    End If
                Next
            End If
        End If
        Me.DialogResult = DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub dgview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellDoubleClick
        btnok_Click(sender, e)
    End Sub

    Private Sub dgview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellContentClick

    End Sub

    Private Sub dgview_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtsearch_MouseMove(sender As Object, e As MouseEventArgs) Handles txtsearch.MouseWheel
        dgview.Focus()
    End Sub
End Class
