Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports MySql.Data.MySqlClient
Public Class ViewInputVat
    Private Sub Form_KeyUp(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = 27 Then 'escape
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()
        End If
    End Sub
    Private Sub ViewOffseting()
        If dgMain.Rows.Count > 0 Then
            If dgMain.SelectedRows.Count > 0 Then
                Dim selectedRow = dgMain.SelectedRows(0)
                Dim id As String = selectedRow.Cells("input_vat_id").Value.ToString
                If id <> "" Then
                    Dim dt = New DataTable()
                    Dim conn = generateConnection(_serverDBMain)
                    conn.Open()
                    Using cmd As New MySqlCommand With {.Connection = conn, .CommandType = CommandType.StoredProcedure, .CommandText = "GetJournalOffset"}
                        cmd.Parameters.AddWithValue("@validation", 6)
                        cmd.Parameters.AddWithValue("@jbooks_id", id)
                        Dim da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                    conn.Close()
                    If dt.Rows.Count > 0 Then
                        Dim frmOffset As New ViewInputVatOffset
                        frmOffset.dgMain.AutoGenerateColumns = False
                        frmOffset.dgMain.DataSource = dt
                        frmOffset.ShowDialog()
                    Else
                        MsgBox("No Schedule Found.")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub dgMain_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles dgMain.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            ViewOffseting()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub dgMain_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgMain.CellDoubleClick
        ViewOffseting()
    End Sub
End Class