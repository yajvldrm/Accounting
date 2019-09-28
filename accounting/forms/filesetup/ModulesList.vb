Imports connectionlib.connectionlib
Public Class ModulesList
    Public Property ModuleID As String = ""
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = String.Format("SELECT module_id,module_code,module_name FROM sys_erp_modules WHERE module_code IN ('ACC00101','ACC00201','ACC00301','ACC00401','ACC00501','ACC00601','ACC00701')")
        Dim dt As DataTable = FsQuery(sql)
        dgMain.AutoGenerateColumns = False
        dgMain.DataSource = dt
    End Sub

    Private Sub dgMain_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgMain.CellDoubleClick
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            ModuleID = selectedRow.Cells("module_id").Value.ToString
        End If
    End Sub

    Private Sub ModulesList_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Dim selectedRows = dgMain.SelectedRows
            If selectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class