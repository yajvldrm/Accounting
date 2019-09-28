Imports System.Data.OleDb
Imports System.Deployment
Imports System.IO
Imports System.Windows.Forms

Public Class Po_SubCon
    Private loadDrives As Boolean = False
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private sqlStr As String = ""
    Private myAdapter As OleDbDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As OpenFileDialog = New OpenFileDialog()
        Dim conn As OleDbConnection = New OleDbConnection()
        file.ShowDialog()
        Dim x As String = Path.GetDirectoryName(file.FileName)
        conn.ConnectionString = "Provider=VFPOLEDB;Data Source=" + x + ";"
        'conn.ConnectionString = "Provider=vfpoledb;Data Source=" & x & ";Extended Properties=dBASE IV;User ID=Admin;Password=;"
        conn.Open()
        Dim v = file.SafeFileName.Split(".")
        sqlStr = "Select * from " & file.SafeFileName
        myAdapter = New OleDbDataAdapter(sqlStr, conn)
        Dim YourResultSet As DataTable = New DataTable()
        myAdapter.Fill(ds, "table")
        bs.DataSource = ds.Tables("table")
    End Sub
End Class