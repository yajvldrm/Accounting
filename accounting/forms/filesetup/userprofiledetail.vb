Imports System.Windows.Forms

Public Class userprofiledetail
    Dim original_dt As DataTable = Nothing
    Private Sub allAccess_CheckedChanged(sender As Object, e As EventArgs) Handles allAccess.CheckedChanged
        For Each dgrow As DataGridViewRow In dgMain.Rows
            dgrow.Cells("m_view").Value = allAccess.Checked
        Next
    End Sub

    Private Sub allAdd_CheckedChanged(sender As Object, e As EventArgs) Handles allAdd.CheckedChanged
        For Each dgrow As DataGridViewRow In dgMain.Rows
            dgrow.Cells("m_add").Value = allAdd.Checked
        Next
    End Sub

    Private Sub allEdit_CheckedChanged(sender As Object, e As EventArgs) Handles allEdit.CheckedChanged
        For Each dgrow As DataGridViewRow In dgMain.Rows
            dgrow.Cells("m_edit").Value = allEdit.Checked
        Next
    End Sub

    Private Sub allDelete_CheckedChanged(sender As Object, e As EventArgs) Handles allDelete.CheckedChanged
        For Each dgrow As DataGridViewRow In dgMain.Rows
            dgrow.Cells("m_delete").Value = allDelete.Checked
        Next
    End Sub

    Private Sub allCancel_CheckedChanged(sender As Object, e As EventArgs) Handles allCancel.CheckedChanged
        For Each dgrow As DataGridViewRow In dgMain.Rows
            dgrow.Cells("m_cancel").Value = allCancel.Checked
        Next
    End Sub

    Private Sub allPrint_CheckedChanged(sender As Object, e As EventArgs) Handles allPrint.CheckedChanged
        For Each dgrow As DataGridViewRow In dgMain.Rows
            dgrow.Cells("m_print").Value = allPrint.Checked
        Next
    End Sub


    Private Sub dgMain_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgMain.CurrentCellDirtyStateChanged
        If dgMain.IsCurrentCellDirty Then
            dgMain.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim _newDT As DataTable = dgMain.DataSource
        For Each row As DataRow In _newDT.Rows
            Dim dra() As DataRow = original_dt.Select(String.Format("module_id = '{0}'", row.Item("module_id")))
            If dra.Count > 0 Then
                For Each col As DataColumn In original_dt.Columns
                    dra(0).Item(col.ColumnName) = row.Item(col.ColumnName)
                Next
            End If
        Next
        Me.Close()
    End Sub

    Private Sub Filter_CheckChange(sender As Object, e As EventArgs) Handles withTransaction.CheckedChanged, withSystemConfiguration.CheckedChanged, withReport.CheckedChanged, withFileSetup.CheckedChanged

        Dim _newDT As DataTable = dgMain.DataSource
        For Each row As DataRow In _newDT.Rows
            Dim dra() As DataRow = original_dt.Select(String.Format("module_id = '{0}'", row.Item("module_id")))
            If dra.Count > 0 Then
                For Each col As DataColumn In original_dt.Columns
                    dra(0).Item(col.ColumnName) = row.Item(col.ColumnName)
                Next
            End If
        Next

        Dim ids As String = ""

        Dim wTransaction As Boolean = withTransaction.Checked
        Dim wSystemConfiguration As Boolean = withSystemConfiguration.Checked
        Dim wReport As Boolean = withReport.Checked
        Dim wFileSetup As Boolean = withFileSetup.Checked

        If withTransaction.Checked Then
            ids &= ",2"
        End If
        If withSystemConfiguration.Checked Then
            ids &= ",3"
        End If
        If withReport.Checked Then
            ids &= ",4"
        End If
        If withFileSetup.Checked Then
            ids &= ",1"
        End If

        Dim dr() As DataRow = If(ids <> "", original_dt.Select(String.Format("module_type IN ({0})", ids.Substring(1))), Nothing)
        Dim newDT As New DataTable
        For Each col As DataColumn In original_dt.Columns
            newDT.Columns.Add(col.ColumnName)
        Next

        If Not dr Is Nothing Then
            For Each row As DataRow In dr
                newDT.ImportRow(row)
            Next
        End If
        dgMain.DataSource = newDT
    End Sub

    Private Sub allModules_CheckedChanged(sender As Object, e As EventArgs) Handles allModules.CheckedChanged
        withTransaction.Checked = allModules.Checked
        withSystemConfiguration.Checked = allModules.Checked
        withReport.Checked = allModules.Checked
        withFileSetup.Checked = allModules.Checked
    End Sub

    Private Sub userprofiledetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        original_dt = dgMain.DataSource
    End Sub
End Class