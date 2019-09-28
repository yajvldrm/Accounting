Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class DetailedChartList
    Dim dbTable As String = "lib_erp_chart"
    'Dim dss As New FileSetupSet
    Private MyDT As DataTable = Nothing
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False

        'report_type
        'dbName
        'account_id
        'general_id
        'range_type
        'date_from
        'date_to
        'currency_id

        Dim col = New List(Of KeyValuePair(Of String, String))
        col.Add(New KeyValuePair(Of String, String)("@report_type", "0"))
        col.Add(New KeyValuePair(Of String, String)("@dbname", ""))
        col.Add(New KeyValuePair(Of String, String)("@account_id", ""))
        col.Add(New KeyValuePair(Of String, String)("@general_id", ""))
        col.Add(New KeyValuePair(Of String, String)("@range_type", ""))
        col.Add(New KeyValuePair(Of String, String)("@date_from", ""))
        col.Add(New KeyValuePair(Of String, String)("@date_to", ""))
        col.Add(New KeyValuePair(Of String, String)("@currency_id", ""))
        col.Add(New KeyValuePair(Of String, String)("@journal_id", ""))
        col.Add(New KeyValuePair(Of String, String)("@book_id", ""))
        col.Add(New KeyValuePair(Of String, String)("@book_unit_id", ""))

        Dim dt As DataTable = ExecuteWithParameter("get_lib_erp_chart_drilled_down", ConnectionStringFS, CommandType.StoredProcedure, col)

        ds.Tables(dbTable).Clear()
            MyDT = ds.Tables(dbTable).Clone
            MyDT.Clear()
            For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
            MyDT.ImportRow(row)
            Next
            dgMain.DataSource = MyDT


    End Sub
    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles txtsearch.TextChange
        Dim q As String = txtsearch.Text.ToString.Replace("'", "''")
        If txtsearch.TextSource <> "" Then
            Dim cols = txtsearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            Dim selectedRows = MyDT.[Select](selectQuery.Substring(4), txtsearch.TextSource & " ASC")
            If selectedRows.Length > 0 Then

                Dim newDt = MyDT.Clone
                newDt.Clear()
                For Each dr As DataRow In selectedRows
                    newDt.ImportRow(dr)
                Next
                dgMain.DataSource = newDt
            Else
                dgMain.DataSource = MyDT
            End If
        End If






    End Sub

    Private Sub DetailedChartList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
    End Sub

    Private Sub dgMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellContentClick

    End Sub

    Private Sub dgMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellDoubleClick

        If dgMain.SelectedRows.Count = 1 Then
            If dgMain.SelectedRows(0).Cells("account_id").Value <> Nothing Then
                Dim account_id As String = dgMain.SelectedRows(0).Cells("account_id").Value.ToString()
                AccountInquiry.account_id = account_id
                AccountInquiry.ShowDialog()
            End If
        End If

    End Sub

    Private Sub Myformheader1_Load(sender As Object, e As EventArgs) Handles Myformheader1.Load

    End Sub

    Private Sub btnRunReport_Click(sender As Object, e As EventArgs) Handles btnRunReport.Click
        Dim account_ids As String() = getCheckedGrid("account_id", "account_name", "sel", dgMain, "", False,, False)
        If account_ids.Length > 0 Then
            Dim account_id As String = String.Join(",", account_ids)
            AccountInquiry.account_id = account_id
            AccountInquiry.ShowDialog()
        End If
    End Sub

    Private Sub txtsearch_Load(sender As Object, e As EventArgs) Handles txtsearch.Load

    End Sub
End Class