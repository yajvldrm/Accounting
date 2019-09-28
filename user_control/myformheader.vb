Imports System.Windows.Forms
Imports System.Drawing

Public Class myformheader

    Dim WithEvents frm As New Form
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private borderColor As Color = Color.FromName(Me.BackColor.ToString) 'Border Color
    Private borderWidth As Integer = 5                                   ' declaring its variable where variable has a given value
    Private formRegion As Rectangle

    Private Sub myformheader_Load(sender As Object, e As EventArgs) Handles MyBase.Load     ' loading its form
        lblText.Text = Me.FindForm.Text               ' if the label in the header was equal to its respective form which is currently using
        Me.Width = Me.FindForm.Width                  ' then its name as well as the width will appear equally based on its given value
        formRegion = New Rectangle(0, 0, Me.FindForm.Width, Me.FindForm.Height)
        frm = Me.FindForm
    End Sub

    Private Sub myformheader_Resize(sender As Object, e As EventArgs) Handles frm.Resize
        Me.Width = frm.Width                  ' then its name as well as the width will appear equally based on its given value
        formRegion = New Rectangle(0, 0, Me.FindForm.Width, Me.FindForm.Height)
        borderColor = Color.FromArgb(Me.BackColor.ToArgb)
    End Sub
    Private Sub myformheader_Paint(sender As Object, e As PaintEventArgs) Handles frm.Paint
        'Draws the border.
        borderColor = Color.FromArgb(Me.BackColor.ToArgb)
        ControlPaint.DrawBorder(e.Graphics, formRegion, borderColor, _
        borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, _
        ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, _
        borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub

    Private Sub login_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.FindForm.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.FindForm.Top
    End Sub

    Private Sub login_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then

            Me.FindForm.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.FindForm.Left = Windows.Forms.Cursor.Position.X - mousex

        End If
    End Sub

    Private Sub login_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.FindForm.Close()               ' if the button exit of the header was click then the form which is currently using will be close
    End Sub
    Private Sub lblText_TextChanged(sender As Object, e As EventArgs) Handles frm.TextChanged
        lblText.Text = frm.Text                     ' label of the header will change based on the form which is currenyly using
    End Sub

End Class