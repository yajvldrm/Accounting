Public Class ewtreportFilter
    Public Property isHorizontal As Boolean = False
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub rdoVertical_CheckedChanged(sender As Object, e As EventArgs) Handles rdoVertical.CheckedChanged, rdoHorizontal.CheckedChanged
        isHorizontal = rdoHorizontal.Checked
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class