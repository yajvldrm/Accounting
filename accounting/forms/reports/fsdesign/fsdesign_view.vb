Public Class fsdesign_view
    Public Property MyData As DataTable = Nothing
    Public Property MyTemplateID As String = ""
    Friend Sub LoadData()
        dgMain.AutoGenerateColumns = False
        dgMain.DataSource = MyData
    End Sub

    Private Sub dgMain_DoubleClick(sender As Object, e As EventArgs) Handles dgMain.DoubleClick
        If dgMain.Rows.Count > 0 Then
            Dim selectedRows = dgMain.SelectedRows
            If selectedRows.Count > 0 Then
                Dim selectedRow = selectedRows(0)
                MyTemplateID = selectedRow.Cells("template_id").Value.ToString()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class