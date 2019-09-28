Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class multiplegroupsetup
    Dim dbTable As String = "lib_acc_chart_group_multiple"
    Dim ds As New FileSetupSet
    Private transmode As String = ""
    Private Sub init_load()
        dgMain.AutoGenerateColumns = False
        Dim sql = "SELECT a.chart_group_multiple_id,a.chart_group_id,a.user_id,b.chart_group_code,b.chart_group_name " & _
            "FROM lib_acc_chart_group_multiple a " & _
            "LEFT JOIN lib_acc_chart_group b ON b.chart_group_id = a.chart_group_id "
        sql &= String.Format(" WHERE a.user_id = '{0}' ", main.user_id)
        Dim dt As DataTable = FsQuery(sql)
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
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        transmode = "update"
        enable_control(Me)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As DataTable = ds.Tables(dbTable)
        Dim err As Boolean = False
        Dim pk As Integer = 0

        Dim dic = generateDictionary(Me, dt)
        If dic.ContainsKey("user_id") Then
            dic.Item("user_id") = main.user_id
        Else
            dic.Add("user_id", main.user_id)
        End If
        If requiredChecker(Me) Then
            MsgBox("Fields that are required need to be filledup.")
        Else
            dic.Remove("chart_group_code")
            dic.Remove("chart_group_name")
            If transmode = "insert" Then
                If DataExist(dgMain, {"chart_group_multiple_id", txt_chart_group_multiple_id.Value}, {"chart_group_id"}, {txt_chart_group_id.Value}) Then
                    MsgBox("Group already exist")
                    err = True
                Else
                    If dic.ContainsKey("sel") Then
                        dic.Remove("sel")
                    End If
                    'Dim sql = genInsert(dbTable, dic)
                    Dim sql = ATGenerateQuery("Insert", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_chart_group_multiple_id.Value, "chart_group_multiple_id")
                    Dim id As DataTable = FsQuery(sql)
                    pk = id.Rows(0).Item("return_id")
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "update" Then
                dic.Remove("sel")
                If DataExist(dgMain, {"chart_group_multiple_id", txt_chart_group_multiple_id.Value}, {"chart_group_id"}, {txt_chart_group_id.Value}, False) Then
                    MsgBox("Group already exist")
                    err = True
                Else
                    'FsQuery(genUpdate(dbTable, dic))
                    FsQuery(ATGenerateQuery("Update", dbTable, dic, Environment.MachineName, Environment.UserName, main.log_id, txt_chart_group_multiple_id.Value, "chart_group_multiple_id"))
                    pk = txt_chart_group_multiple_id.Value
                    MsgBox("Successfully Saved.", MsgBoxStyle.Information, "Save")
                End If
            ElseIf transmode = "remove" Then
            End If
            If Not err Then
                transmode = ""
                disable_control(Me)
                btnInsert.Focus()
                init_load()
                For Each row As DataGridViewRow In dgMain.Rows
                    If row.Cells("chart_group_multiple_id").Value.ToString = pk Then
                        row.Selected = True
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)
        transmode = ""
    End Sub
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_load()
        disable_control(Me)
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain, "chart_group_multiple_id", dt, Me)
    End Sub
    Private Sub cboxAllHeader_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAllHeader.CheckedChanged
        For Each row As DataGridViewRow In dgMain.Rows
            row.Cells("sel").Value = cboxAllHeader.Checked
        Next
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim pk As String = "chart_group_multiple_id"
        Dim colName As String = "chart_group_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete the selected record(s)?"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "lib_acc_chart_group_multiple"
        Dim pk_delete As String = "chart_group_multiple_id"

        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""

        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg, True, "Select Record First", False)
        If arr_id.Length > 0 Then
            'For i As Integer = 0 To arr_id.Length - 1
            '    str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            'Next
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                'ids &= "," & arr_id(i)
                ids &= arr_id(i).ToString & "|"
            Next
            'str = String.Format("DELETE FROM {0}.{1} WHERE {2} IN ({3});", db_delete, tbl_delete, pk_delete, ids.Substring(1))
            'Query(str)
            FsQuery(ATGenerateQuery("Remove", dbTable, Nothing, Environment.MachineName, Environment.UserName, main.log_id, ids, "chart_group_multiple_id"))
            init_load()
        End If
    End Sub
    Private Sub txt_chart_group_code_Leave(sender As Object, e As EventArgs) Handles txt_chart_group_id.Leave
        Dim _sql As String = String.Format("SELECT * FROM lib_acc_chart_group ")
        Dim data As DataTable = FsQuery(_sql)
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("chart_group_code like '" & txt_chart_group_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "chart_group_code,chart_group_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_chart_group_id.RowData = dr
                txt_chart_group_id.Value = dr("chart_group_id")
                txt_chart_group_id.Text = dr("chart_group_code")
                txt_chart_group_name.Text = dr("chart_group_name")
            End If
        End If
    End Sub
End Class