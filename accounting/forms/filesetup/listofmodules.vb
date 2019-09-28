Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms

Public Class listofmodules
    Private MyDT As DataTable = Nothing
    Private Sub listofmodules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgMain.AutoGenerateColumns = False
        dgMain.DataMember = "dt"
        Dim sql As String = String.Format("SELECT module_id,module_code,module_name " & _
            "FROM sys_erp_modules " & _
            "WHERE system_id = 2 " & _
            "ORDER BY module_type" & _
            "")
        Dim dt As DataTable = FsQuery(sql)
        MyDT = ds.Tables("dt").Clone
        MyDT.Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("dt").ImportRow(row)
            MyDT.ImportRow(row)
        Next
        dgMain.DataSource = MyDT
    End Sub
    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles txtsearch.TextChange
        'searchGrid("module_name", dgMain, txtsearch.Text)
        Dim q As String = txtsearch.Text
        If txtsearch.TextSource <> "" Then
            Dim cols = txtsearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            'Dim dt As DataTable = dgMain.DataSource
            Dim selectedRows = MyDT.[Select](selectQuery.Substring(4), txtsearch.TextSource & " ASC")
            If selectedRows.Length > 0 Then
                Dim newDT = MyDT.Clone
                newDT.Clear()
                For Each dr In selectedRows
                    newDT.ImportRow(dr)
                Next
                dgMain.DataSource = newDT
            Else
                dgMain.DataSource = MyDT
            End If
        Else
            dgMain.DataSource = MyDT
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If dgMain.SelectedRows.Count = 0 Then
            MsgBox("No Record Selected")
            Exit Sub
        End If
        Dim _id = "module_id"
        Dim _id_name = "module_name"
        Dim _idName = ""
        Dim _id_Name1 = ""
        For Each col As DataGridViewColumn In dgMain.Columns
            If col.DataPropertyName = _id Then
                _idName = col.Name
            End If
            If col.DataPropertyName = _id_name Then
                _id_Name1 = col.Name
            End If
        Next
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            If _idName <> "" Then
                Dim id = selectedRow.Cells(_idName).Value.ToString
                Dim idName = selectedRow.Cells(_id_Name1).Value.ToString
                Dim appsetup As New approvalsetup
                showForm(appsetup, main)
                Me.Hide()
            End If
        End If
    End Sub
End Class