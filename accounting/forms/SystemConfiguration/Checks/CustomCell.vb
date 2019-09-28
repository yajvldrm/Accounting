Imports user_control
Imports System.Windows.Forms
Imports System.Drawing

Public Class CustomeCell
    Inherits DataGridViewCell
    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(btnApproval)
        End Get
    End Property

    Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer, cellState As DataGridViewElementStates, value As Object, _
        formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
        Dim ctrl = DirectCast(value, btnApproval)
        Dim img = New Bitmap(cellBounds.Width, cellBounds.Height)
        ctrl.DrawToBitmap(img, New Rectangle(0, 0, ctrl.Width, ctrl.Height))
        graphics.DrawImage(img, cellBounds.Location)
    End Sub

    Protected Overrides Sub OnClick(e As DataGridViewCellEventArgs)
        Dim objs As List(Of Object) = TryCast(DataGridView.DataSource, List(Of Object))
        If objs Is Nothing Then
            Return
        End If
        If e.RowIndex < 0 OrElse e.RowIndex >= objs.Count Then
            Return
        End If

        Dim ctrl As btnApproval = objs(e.RowIndex).Ctrl
        ' Take any action - I will just change the color for now.
        ctrl.BackColor = Color.Red
        ctrl.Refresh()
        DataGridView.InvalidateCell(e.ColumnIndex, e.RowIndex)
    End Sub
End Class