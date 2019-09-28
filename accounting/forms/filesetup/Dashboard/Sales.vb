Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class Sales
    Dim ds As New begbal
    Dim dbTable As String = "trans_header"
    Dim isloaded As Boolean = False

    Private Sub loadSales2()
        isloaded = True
        dgMain2.AutoGenerateColumns = False
        Dim sql = String.Format("SELECT trans_date,amount FROM trans_header ORDER BY YEAR(trans_date) DESC, MONTH(trans_date) DESC, DAY(trans_date) DESC", _serverDBFS)
        Dim dt As DataTable = Query(sql)
        ds.Tables(dbTable).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
        Next
        dgMain2.DataSource = ds.Tables(dbTable)
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isloaded Then
            loadSales2()
        End If
        Me.Location = New Drawing.Point(1105, 345)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Sales_2.Close()
    End Sub
End Class