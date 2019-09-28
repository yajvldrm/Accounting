Public Class loading

    Public Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Loading"
        System.Threading.Thread.Sleep(1000)
        Label1.Text = "Loading ."
        System.Threading.Thread.Sleep(1000)
        Label1.Text = "Loading .."
        System.Threading.Thread.Sleep(1000)
        Label1.Text = "Loading ..."
    End Sub

End Class