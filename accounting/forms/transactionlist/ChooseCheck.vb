Public Class ChooseCheck
    Public Property SelectedID As String = ""
    Private Sub ChooseCheck_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim selectedRows = dgAccount.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            Dim currentIndex = selectedRow.Index
            Dim TMPSelectedID As String = selectedRow.Cells("jbooks_id_tmp").Value.ToString
            If e.KeyData = Windows.Forms.Keys.Enter Then
                SelectedID = TMPSelectedID
                e.SuppressKeyPress = False
                Me.DialogResult = Windows.Forms.DialogResult.OK
            ElseIf e.KeyData = Windows.Forms.Keys.Escape Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub dgAccount_DoubleClick(sender As Object, e As EventArgs) Handles dgAccount.DoubleClick
        Dim selectedRows = dgAccount.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            Dim currentIndex = selectedRow.Index
            Dim TMPSelectedID As String = selectedRow.Cells("jbooks_id_tmp").Value.ToString
            SelectedID = TMPSelectedID
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class