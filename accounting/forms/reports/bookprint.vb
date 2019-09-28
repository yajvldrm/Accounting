Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms

Public Class bookprint
    Private Sub loadJBooks()
        dg_journal.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT journal_id,journal_code,journal_name FROM lib_erp_journal")
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables("dtjournal").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("dtjournal").ImportRow(dr)
        Next
        dg_journal.DataSource = ds.Tables("dtjournal")
    End Sub
    Private Sub loadBooks(ByVal id() As String)
        dg_books.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT False AS sel,b.book_id,c.book_code,c.book_name " & _
                                          "FROM {0}.lib_erp_journal a " & _
                                          "LEFT JOIN {0}.sys_acc_journal_book b ON b.journal_id = a.journal_id " & _
                                          "LEFT JOIN {0}.lib_erp_book c ON c.book_id = b.book_id ", _serverDBFS)
        ds.Tables("dtbook").Clear()
        If id.Length > 0 Then
            Dim str_id As String = ""
            For i As Integer = 0 To id.Length - 1
                str_id &= "," & id(i)
            Next
            sql &= String.Format("WHERE a.journal_id IN ({0}) AND c.book_code IS NOT NULL " & _
                                 "GROUP BY c.book_id", str_id.Substring(1))
            Dim dt As DataTable = Query(sql)
            For Each row As DataRow In dt.Rows
                ds.Tables("dtbook").ImportRow(row)
            Next
        End If
        dg_books.DataSource = ds.Tables("dtbook")
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim currency As String = getRdoValue(grp_currency)
        Dim order_by As String = getRdoValue(grp_order_by)

    End Sub
    Private Function getIdsFromCheckedGrid(ByVal dg As DataGridView) As List(Of String)
        Dim returnList As New List(Of String)
        Return returnList
    End Function
    Private Sub dg_journal_CellValueChanged(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dg_journal.CellValueChanged
        Dim ids() As String = {}
        If dg_journal.RowCount > 0 Then

        End If
    End Sub
End Class