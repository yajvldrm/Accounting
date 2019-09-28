Imports System.Windows.Forms
Public Class TransactionListing
    Public Property myDataTable As DataTable = Nothing
    Public Property selectedID As String = "0"
    Private _transactionName As String = "Voucher No"
    Private currentSearchIndex As Integer = 0

    Public Property transactionName() As String
        Get
            Return _transactionName
        End Get
        Set(value As String)
            _transactionName = value
            dgList.Columns("col_trans_no").HeaderText = transactionName
        End Set
    End Property
    Public Property frmTransaction As Form = Nothing
    Private Sub setTransactionRecord()
        Dim selectedRows = dgList.SelectedRows
        If selectedRows.Count > 0 Then
            Dim id = selectedRows(0).Cells("col_trans_id").Value
            Try
                Dim propTransID As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("pkID")
                If Not propTransID Is Nothing Then
                    propTransID.SetValue(frmTransaction, id.ToString)
                End If
            Catch
            End Try
            Me.Hide()
            frmTransaction.Refresh()
        Else
            MsgBox("No Record Selected")
        End If
    End Sub
    Private Sub TransactionListing_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgList.AutoGenerateColumns = False
        ds.Tables("dt_trans").Clear()
        If myDataTable IsNot Nothing Then
            For Each dr As DataRow In myDataTable.Rows
                ds.Tables("dt_trans").ImportRow(dr)
            Next
        End If
        check_no.Visible = False
        If frmTransaction.Name = "transactioncv" Then
            check_no.Visible = True
        End If
        'bs.DataSource = myDataTable
        'dgList.DataSource = bs
        'If myDataTable IsNot Nothing Then
        '    If myDataTable.Rows.Count > 0 Then
        '        'myDataTable.DefaultView.Sort = "trans_no"
        '        'myDataTable.Select("", "trans_no asc")
        '        dgList.DataSource = myDataTable
        '        Dim selectedRows = myDataTable.Select("trans_id = '" & selectedID & "'")
        '        If selectedRows.Count > 0 Then
        '            For Each row As DataGridViewRow In dgList.Rows
        '                If row.Cells("col_trans_id").Value = selectedID Then
        '                    dgList.Rows(row.Index).Selected = True
        '                End If
        '            Next
        '        Else
        '            dgList.Rows(dgList.Rows.Count - 1).Selected = True
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub dgList_DoubleClick(sender As Object, e As EventArgs) Handles dgList.DoubleClick
        setTransactionRecord()
    End Sub

    Private Sub dgList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgList.KeyDown
        If e.KeyCode = 13 Then 'enter
            setTransactionRecord()
            Return
        ElseIf e.KeyCode = 27 Then 'escape
            Me.Hide()
        End If
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter And e.Control Then
            currentSearchIndex += 1
            txtsearch_TextChange(Nothing, Nothing)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles txtsearch.TextChange
        Dim q As String = txtsearch.Text
        If txtsearch.TextSource <> "" Then
            Dim cols = txtsearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            'Dim dt As DataTable = dgList.DataSource
            bs_trans.Filter = selectQuery.Substring(4)
            'Dim selectedRows = dt.Select(selectQuery.Substring(4))
            'If selectedRows.Length > 0 Then
            '    If currentSearchIndex >= selectedRows.Length Then
            '        currentSearchIndex = 0
            '    End If
            '    Dim selectedID As String = selectedRows(currentSearchIndex).Item("trans_id").ToString
            '    dgList.ClearSelection()
            '    For Each row As DataGridViewRow In dgList.Rows
            '        If row.Cells("col_trans_id").Value.ToString = selectedID Then
            '            row.Selected = True
            '            Dim tmp_index = dt.Rows.IndexOf(selectedRows(currentSearchIndex))
            '            dgList.FirstDisplayedScrollingRowIndex = tmp_index
            '        End If
            '    Next
            'End If
        End If
    End Sub
End Class