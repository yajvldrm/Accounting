Public Class ExportResponse
    Public Property exportData As Boolean = True
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub withData_CheckedChanged(sender As Object, e As EventArgs) Handles withData.CheckedChanged
        exportData = withData.Checked
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class