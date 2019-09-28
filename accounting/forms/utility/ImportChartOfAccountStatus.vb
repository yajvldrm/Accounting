Public Class ImportChartOfAccountStatus

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtStatus.Text = ""
        btnClose.Visible = False
        Me.Close()
    End Sub
End Class