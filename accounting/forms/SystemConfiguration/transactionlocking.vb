Public Class transactionlocking

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
    End Sub
End Class