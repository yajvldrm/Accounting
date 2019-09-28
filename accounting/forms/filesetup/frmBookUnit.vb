Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class frmBookUnit


    Private MyDT As DataTable = Nothing
    Private transmode As String = ""
    Dim dbTable As String = "lib_erp_book_unit_no"
    Private module_code As String = "ACC00123"
    Private MyLogID = main.log_id

    Private Sub init_load()
        Dim sql As String = String.Format("SELECT a.book_unit_no_id,a.book_unit_no_code,a.book_unit_no_name,a.book_id
            ,b.book_code,b.book_name
            FROM lib_erp_book_unit_no a
            LEFT JOIN lib_erp_book b ON b.book_id = a.book_id")
        ds.Tables("lib_erp_book_unit_no").Clear()
        MyDT = ds.Tables("lib_erp_book_unit_no").Clone
        MyDT.Clear()

        Dim dt As DataTable = FsQuery(sql)
        For Each row As DataRow In dt.Rows
            ds.Tables("lib_erp_book_unit_no").ImportRow(row)
            MyDT.ImportRow(row)

        Next
        dgBookUnits.DataSource = MyDT
    End Sub
    Private Sub frmBookUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        init_load()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As Integer = 0
        Dim addSave As Boolean = False
        Dim dic = generateDictionary(Me, dt)
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
            Exit Sub
        Else
            dic.Remove("book_code")
            dic.Remove("book_name")
            If transmode = "insert" Then

                If dic.ContainsKey("sel") Then
                    dic.Remove("sel")
                End If
                Dim tmp_str = ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, MyLogID, "", "book_unit_no_id")
                Dim id As DataTable = FsQuery(tmp_str)
                pk = id.Rows(0).Item("return_id")
                addSave = True

            ElseIf transmode = "update" Then
                dic.Remove("sel")
                Dim id As DataTable = FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, MyLogID, txt_book_unit_no_id.Value, "book_unit_no_id"))
                pk = id.Rows(0).Item("return_id")
                MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
            ElseIf transmode = "remove" Then
            End If
            If Not err Then
                transmode = ""
                'disable_control(Me, main.dicAction.Item(module_code))
                btnInsert.Focus()
                init_load()
                For Each row As DataGridViewRow In dgBookUnits.Rows
                    If row.Cells("book_unit_no_id").Value.ToString = pk Then
                        row.Cells(0).Selected = True
                    End If
                Next
                disable_control(Me)
                If addSave Then
                    saveAddAnother(btnInsert, "Add New Book?")
                End If
            End If
        End If
    End Sub

    Private Sub dgBookUnits_SelectionChanged(sender As Object, e As EventArgs) Handles dgBookUnits.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgBookUnits, "book_unit_no_id", dt, Me)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgBookUnits.SelectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)

        transmode = ""
        Dim selectedRow = dgBookUnits.SelectedRows
        selectedRow(0).Cells(0).Selected = False
        selectedRow(0).Cells(0).Selected = True


        'btnInsert.Visible = True
        'btnUpdate.Visible = True
        'btnRemove.Visible = True
        'btnInsert.Enabled = True
        'btnUpdate.Enabled = True
        'btnRemove.Enabled = True
        'btnSave.Visible = False
        'btnNotSave.Visible = False
        'dgBookUnits.Enabled = True

        'txt_book_id.Enabled = False
        'txt_book_unit_no_code.Enabled = False
        'txt_book_unit_no_name.Enabled = False
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim pk As String = "book_unit_no_id"
        Dim colName As String = "book_unit_no_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgBookUnits
        Dim delMsg As String = "Are you sure to delete this record(s)?"

        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_erp_book_unit_no"
        Dim pk_delete As String = "book_unit_no_id"
        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""
        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg)
        'If arr_id.Length > 0 Then
        '    For i As Integer = 0 To arr_id.Length - 1
        '        If isExistInTransaction(mainDB, tblTrans, pkTrans, pk, arr_id(i)) Then
        '            msg &= String.Format(Environment.NewLine & (i + 1) & ". {0}", getColumnValue(dgBookUnits, pk, arr_id(i), colName))
        '            ctr += 1
        '        End If
        '    Next
        'End If
        If ctr > 0 Then
            MsgBox(String.Format("There are {0} transaction(s) where this record(s) are used." & Environment.NewLine & msg, ctr), MsgBoxStyle.Critical, "Unable to Delete")
        ElseIf arr_id.Length > 0 Then
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                ids &= arr_id(i) & "|"
                'str &= ATGenerateQuery("Remove",tbl_delete,Nothing,Environment.MachineName,Environment.UserName,MyLogID,)
                'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            Next
            str = ATGenerateQuery("Remove", tbl_delete, Nothing, Environment.MachineName, Environment.UserName, MyLogID, ids, "book_unit_no_id")
            FsQuery(str)
            init_load()
        End If
    End Sub

    Private Sub Myformheader1_Load(sender As Object, e As EventArgs) Handles Myformheader1.Load

    End Sub

    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles Searchtxt.TextChange
        Dim q As String = Searchtxt.Text.ToString.Replace("'", "''")
        If Searchtxt.TextSource <> "" Then
            Dim cols = Searchtxt.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            Dim selectedRows = MyDT.[Select](selectQuery.Substring(4), Searchtxt.TextSource & " ASC")
            If selectedRows.Length > 0 Then

                Dim newDt = MyDT.Clone
                newDt.Clear()
                For Each dr As DataRow In selectedRows
                    newDt.ImportRow(dr)
                Next
                dgBookUnits.DataSource = newDt
            Else
                dgBookUnits.DataSource = MyDT
            End If
        End If
    End Sub

    Private Sub txt_book_id_Leave(sender As Object, e As EventArgs) Handles txt_book_id.Leave
        Dim sql As String = String.Format("SELECT a.book_id,a.book_code,a.book_name
            FROM lib_erp_book a
            WHERE a.company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id").ToString())
        Dim dt As DataTable = FsQuery(sql)
        Dim q As String = txt_book_id.Text.ToString.Replace("'", "''")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("book_name like '{0}'", q))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "book_code,book_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_book_id.RowData = dr
                txt_book_id.Value = dr("book_id")
                txt_book_id.Text = dr("book_name")
            End If
        End If
    End Sub
End Class