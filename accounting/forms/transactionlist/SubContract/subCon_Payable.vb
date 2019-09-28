Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class subCon_Payable
    Public Property _payable_datatable As DataTable

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub subCon_Payable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each dr As DataRow In _payable_datatable.Rows
            ds.Tables("trans_subCon_management").ImportRow(dr)
        Next
        dgView.DataSource = ds.Tables("trans_subcon_management")
    End Sub

End Class