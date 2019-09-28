Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class agingrange
    Dim dbTable As String = "sys_aging_range"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private module_code As String = "ACC00906"

    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = "SELECT * FROM sys_aging_range"
        Dim dt As DataTable = Query(sql)
        ds.Tables(dbTable).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
        Next
        dgMain.DataSource = ds.Tables(dbTable)
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
        txt_days_from.DecimalValue = lastDaysTo() + 1
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        transmode = "update"
        enable_control(Me)
    End Sub
    Private Function lastDaysTo(Optional id As String = "") As Integer
        Dim days_to As Integer = 0
        Dim dt As DataTable = dgMain.DataSource
        For Each row As DataRow In dt.Rows
            If id <> "" Then
                If id <> row.Item("aging_range_id") Then
                    days_to = CType(row.Item("days_to"), Integer)
                End If
            Else
                days_to = CType(row.Item("days_to"), Integer)
            End If
        Next
        Return days_to
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As Integer = 0

        Dim days_to As Integer = lastDaysTo(txt_aging_range_id.Value)

        Dim dic = generateDictionary(Me, dt)
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            If transmode = "insert" Then
                If DataExist(dgMain, {"aging_range_id", txt_aging_range_id.Value}, {"days_from", "days_to"}, {txt_days_from.DecimalValue, txt_days_to.DecimalValue}) Then
                    MsgBox("Range already exist")
                    err = True
                Else
                    If dic.ContainsKey("sel") Then
                        dic.Remove("sel")
                    End If
                    'Dim id As DataTable = Query(genInsert(dbTable, dic) & ";SELECT LAST_INSERT_ID() AS id;")
                    Dim id As DataTable = Query(ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_aging_range_id.Value, "aging_range_id"))
                    pk = id.Rows(0).Item("return_id")
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "update" Then
                dic.Remove("sel")
                If DataExist(dgMain, {"aging_range_id", txt_aging_range_id.Value}, {"days_from", "days_to"}, {txt_days_from.DecimalValue, txt_days_to.DecimalValue}, False) Then
                    MsgBox("Range already exist")
                    err = True
                Else
                    'Query(genUpdate(dbTable, dic))
                    Query(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_aging_range_id.Value, "aging_range_id"))
                    pk = txt_aging_range_id.Value
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "remove" Then
                End If
                If Not err Then
                    transmode = ""
                disable_control(Me, main.dicAction.Item(module_code))
                    btnInsert.Focus()
                    init_load()
                    For Each row As DataGridViewRow In dgMain.Rows
                        If row.Cells("aging_range_id").Value.ToString = pk Then
                            row.Selected = True
                        End If
                    Next
                End If
        End If

        txt_days_from.Text = ""
        txt_days_to.Text = ""
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me, main.dicAction.Item(module_code))
        transmode = ""

        txt_days_from.Text = ""
        txt_days_to.Text = ""
    End Sub
    Private Sub agingrange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me, main.dicAction.Item(module_code))
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "aging_range_id", dt, Me)
    End Sub
    Private Sub cboxAllHeader_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAllHeader.CheckedChanged
        For Each row As DataGridViewRow In dgMain.Rows
            row.Cells("sel").Value = cboxAllHeader.Checked
        Next
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim pk As String = "aging_range_id"
        Dim colName As String = "days_from"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        'for delete query
        Dim db_delete As String = _serverDBMain
        Dim tbl_delete As String = "sys_aging_range"
        Dim pk_delete As String = "aging_range_id"


        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""

        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg)

        If arr_id.Length > 0 Then
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                'str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
                ids &= arr_id(i).ToString & "|"
            Next
            'Query(str)
            Query(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "aging_range_id"))
            init_load()
        End If
    End Sub
End Class