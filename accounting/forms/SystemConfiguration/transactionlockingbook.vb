Imports connectionlib.connectionlib
Imports MySql.Data.MySqlClient

Public Class transactionlockingbook

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        txtTransaction.Value = txt_filter.Value
        txtTransaction.Text = txt_filter.Text
    End Sub

    Private Sub txt_transaction_ValueChange(sender As Object, e As EventArgs) Handles txt_filter.ValueChange
        txtTransaction.Value = txt_filter.Value
        txtTransaction.Text = txt_filter.Text
        'Dim sql As String = String.Format("SELECT a.transaction_locking_id,a.journal_id,a.date_from,a.date_to,a.isLock,a.book_id "  & _
        '",b.journal_code,b.journal_name,c.book_code,c.book_name "  & _
        '"FROM transaction_locking_book a "  & _
        '"LEFT JOIN {0}.lib_erp_journal b ON b.journal_id = a.journal_id "  & _
        '"LEFT JOIN {0}.lib_erp_book c ON c.book_id = a.book_id "  & _
        '"WHERE a.journal_id = '{1}' "  & _
        '"", _serverDBFS, txt_filter.Value)
        'Dim dt As DataTable = Query(sql)
        'ds.Tables("transaction_locking_book").Clear()
        'For Each dr As DataRow In dt.Rows
        '    ds.Tables("transaction_locking_book").ImportRow(dr)
        'Next
        'MyDGView.AutoGenerateColumns = False
        'MyDGView.DataSource = ds.Tables("transaction_locking_book")
    End Sub

    Private Sub transactionlockingbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_filter.Enabled = True
    End Sub

    Private Sub txt_transaction_Leave(sender As Object, e As EventArgs) Handles txt_filter.Leave
        txt_filter.callBrowser()
    End Sub

    Private Sub MyButton5_Click(sender As Object, e As EventArgs) Handles MyButton5.Click
        Me.okSave = True
        If checkLockingAvailability() Then
            Me.okSave = True
        Else
            MsgBox("Unable to Lock Transaction")
            Me.okSave = False
        End If
    End Sub
    Private Function checkLockingAvailability() As Boolean
        Dim a As Boolean = False
        Dim conn = generateConnection(_serverDBMain)
        conn.Open()
        '_dbFS
        '_journal_id
        '_book_id
        '_date_from
        '_date_to
        Using cmd As New MySqlCommand With {.Connection = conn, .CommandType = CommandType.StoredProcedure, .CommandText = "checkLockingAvailability"}
            cmd.Parameters.AddWithValue("@_dbFS", _serverDBFS)
            cmd.Parameters.AddWithValue("@_journal_id", txtTransaction.Value)
            cmd.Parameters.AddWithValue("@_book_id", txtBookID.Value)
            cmd.Parameters.AddWithValue("@_date_from", txt_date_from.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@_date_to", txt_date_to.Value.ToString("yyyy-MM-dd"))
            Dim dt = New DataTable()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If CInt(dt.Rows(0).Item("num_status").ToString) > 0 And CInt(dt.Rows(0).Item("num_approval").ToString) > 0 Then
                    a = False
                Else
                    a = True
                End If
            End If
        End Using
        conn.Close()
        Return a
    End Function
End Class