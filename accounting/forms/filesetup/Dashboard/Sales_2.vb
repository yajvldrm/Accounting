Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class Sales_2
    Dim ds As New begbal
    Dim dbTable As String = "trans_header"
    Dim isloaded As Boolean = False

    Private Sub loadSales()
        isloaded = True
        dgMain.AutoGenerateColumns = False
        Dim sql = String.Format("SELECT MONTHNAME(trans_date) as trans_month, SUM(amount) as amount FROM trans_header WHERE YEAR(trans_date) GROUP BY MONTH(trans_date) ORDER BY MONTH(trans_date)")
        Dim dt As DataTable = Query(sql)
        ds.Tables(dbTable).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
        Next
        dgMain.DataSource = ds.Tables(dbTable)
    End Sub

    Private Sub Sales_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isloaded Then
            loadSales()
        End If
        Me.Location = New Drawing.Point(1105, 20)
    End Sub
End Class