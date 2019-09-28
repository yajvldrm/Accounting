Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports libacctng.myFunctions
Public Class frmProject

    Private MyDT As DataTable = Nothing
    Dim dbTable As String = "lib_erp_project_unit_no"
    Private transmode As String = ""
    Private MyLogID = main.log_id
    Private module_code As String = "ACC001233"

    Private Sub init_load()
        Dim sql As String = String.Format("SELECT a.project_unit_no_id,a.project_unit_no_codes,a.project_unit_no_names,a.project_id
            ,b.project_code,b.project_name
            FROM lib_erp_project_unit_no a
            LEFT JOIN lib_erp_project b ON b.project_id = a.project_id")
        ds.Tables("lib_erp_project_unit_no").Clear()
        MyDT = ds.Tables("lib_erp_project_unit_no").Clone
        MyDT.Clear()

        Dim dt As DataTable = FsQuery(sql)
        For Each row As DataRow In dt.Rows
            ds.Tables("lib_erp_project_unit_no").ImportRow(row)
            MyDT.ImportRow(row)
        Next
        dgMain.DataSource = MyDT
    End Sub
    Private Sub frmProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgMain.SelectedRows.Count > 0 Then
            transmode = "update"
            enable_control(Me)
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim pk As String = "project_unit_no_id"
        Dim colName As String = "project_unit_no_names"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"

        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_erp_project_unit_no"
        Dim pk_delete As String = "project_unit_no_id"
        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""
        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg)

        If ctr > 0 Then
            MsgBox(String.Format("There are {0} transaction(s) where this record(s) are used." & Environment.NewLine & msg, ctr), MsgBoxStyle.Critical, "Unable to Delete")
        ElseIf arr_id.Length > 0 Then
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                ids &= arr_id(i) & "|"
                'str &= ATGenerateQuery("Remove",tbl_delete,Nothing,Environment.MachineName,Environment.UserName,MyLogID,)
                'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            Next
            str = ATGenerateQuery("Remove", tbl_delete, Nothing, Environment.MachineName, Environment.UserName, MyLogID, ids, "project_unit_no_id")
            FsQuery(str)
            clear_control(Me)
            init_load()
        End If
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
            dic.Remove("project_code")
            dic.Remove("project_name")
            If transmode = "insert" Then

                If dic.ContainsKey("sel") Then
                    dic.Remove("sel")
                End If
                Dim tmp_str = ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, MyLogID, "", "project_unit_no_id")
                Dim id As DataTable = FsQuery(tmp_str)
                pk = id.Rows(0).Item("return_id")
                addSave = True

            ElseIf transmode = "update" Then
                dic.Remove("sel")
                Dim id As DataTable = FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, MyLogID, txt_project_unit_no_id.Value, "project_unit_no_id"))
                pk = id.Rows(0).Item("return_id")
                MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
            ElseIf transmode = "remove" Then
            End If
            If Not err Then
                transmode = ""
                'disable_control(Me, main.dicAction.Item(module_code))
                btnInsert.Focus()
                init_load()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("project_unit_no_id").Value.ToString = pk Then
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

    Private Sub txt_project_id_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave
        Dim sql As String = String.Format("SELECT a.project_id,a.project_code,a.project_name
            FROM lib_erp_project a")

        Dim dt As DataTable = FsQuery(sql)
        Dim q As String = txt_project_id.Text.ToString.Replace("'", "''")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("project_name like '{0}'", q))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Project Code,Project Name", "project_code,project_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_project_id.RowData = dr
                txt_project_id.Value = dr("project_id")
                txt_project_id.Text = dr("project_name")
            End If
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)
        transmode = ""
        Dim selectedRow = dgMain.SelectedRows
        If selectedRow.Count > 0 Then
            selectedRow(0).Cells(0).Selected = False
            selectedRow(0).Cells(0).Selected = True
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgProjectUnits_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "project_unit_no_id", dt, Me)
    End Sub

    Private Sub Searchtxt_TextChange(sender As Object, e As EventArgs) Handles Searchtxt.TextChange
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
                dgMain.DataSource = newDt
            Else
                dgMain.DataSource = MyDT
            End If
        End If
    End Sub


End Class