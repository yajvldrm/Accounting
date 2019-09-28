Public Class ViewOffset

    Private Sub Form_KeyUp(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = 27 Then 'escape
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()
        End If
    End Sub
End Class