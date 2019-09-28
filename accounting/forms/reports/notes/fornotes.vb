Public Class fornotes
    Public Property note_id As String = ""
    Public Property note_date As String = ""
    Public Property note_remarks As String = ""

    Private Sub MyButton4_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
    End Sub
    Private Sub fornotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_notes.Text = note_remarks

        txt_notes.Enabled = True
        'txt_notes.Focus()
    End Sub
    Private Sub MyButton5_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        note_date = Now.ToString("yyyy-MM-dd HH:mm:ss")
        note_remarks = txt_notes.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class