Public Class reportviewer
    Private Sub reportviewer_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.DocumentViewer1.DocumentSource = Nothing
        Me.Hide()
    End Sub
End Class