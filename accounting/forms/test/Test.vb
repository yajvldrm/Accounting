Imports connectionlib.connectionlib
Public Class Test
    Private Sub GetDataFromPath(ByVal str As String, ByVal filename As String)
        Dim ConnectionString As String

        ConnectionString = String.Format("Provider=vfpoledb;Data Source={0};", str)
        Dim dBaseConnection As New System.Data.OleDb.OleDbConnection(ConnectionString)
        dBaseConnection.Open()

        Dim dBaseCommand As New System.Data.OleDb.OleDbCommand(String.Format("SELECT * FROM {0}", filename), dBaseConnection)
        Dim dt As New DataTable
        Dim da As New System.Data.OleDb.OleDbDataAdapter(dBaseCommand)
        da.Fill(dt)

        dBaseConnection.Close()
    End Sub
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GetDataFromPath()
    End Sub
End Class