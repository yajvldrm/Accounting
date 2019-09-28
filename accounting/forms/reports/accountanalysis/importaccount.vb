Imports System.Windows.Forms
Imports connectionlib.connectionlib

Public Class importaccount
    Public Property WithAsset As Boolean
    Public Property WithLiability As Boolean
    Public Property WithCapital As Boolean
    Public Property WithIncome As Boolean
    Public Property WithExpense As Boolean
    Public Property WithGroup As Boolean
    Public Property GroupId As String

    Private Sub cboGroup_CheckedChanged(sender As Object, e As EventArgs) Handles cboGroup.CheckedChanged
        txtGroup.Enabled = cboGroup.Checked
    End Sub
    Private Sub txtGroup_Leave(sender As Object, e As EventArgs) Handles txtGroup.Leave
        Dim dt As DataTable = FsQuery("SELECT chart_group_id,chart_group_code,chart_group_name FROM lib_acc_chart_group")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select("chart_group_code LIKE '" & txtGroup.Text.ToString.Replace("'", "''") & "' OR chart_group_name LIKE '" & txtGroup.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "chart_group_code,chart_group_name", "100,300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtGroup.RowData = dr
                txtGroup.Value = dr("chart_group_id")
                txtGroup.Text = dr("chart_group_code")
                txtGroupName.Text = dr("chart_group_name")
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        WithAsset = cboAsset.Checked
        WithLiability = cboLiability.Checked
        WithCapital = cboCapital.Checked
        WithIncome = cboIncome.Checked
        WithExpense = cboExpense.Checked
        WithGroup = cboGroup.Checked
        GroupId = txtGroup.Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class