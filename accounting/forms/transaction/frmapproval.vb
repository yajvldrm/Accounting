Imports connectionlib.connectionlib
Public Class frmapproval
    Public Shared module_code As String = ""
    Public Shared stage_id As Integer = 0
    Public Shared ref_id As Integer = 0
    Public Shared status As Integer = 0
    Public Shared log_id As Integer = 0
    Public Shared username As String = ""

    Private isSubmit As Boolean = False

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        isSubmit = False
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        isSubmit = True
        Query(String.Format("CALL approvedata('{0}',{1},{2},{3},{4},'{5}');", module_code, stage_id, ref_id, status, log_id, Trim(txtApproval.Text)))
        Me.Close()
    End Sub

    Private Sub frmapproval_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isSubmit Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub frmapproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = lblApproval.Text
        txtApproval.Text = lblApproval.Text & " by " & username
    End Sub
End Class