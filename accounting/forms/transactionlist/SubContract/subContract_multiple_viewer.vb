Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Public Class subContract_multiple_viewer
    Private MyLogId = main.log_id
    Public select_id As String
    ''Public Shared id As Integer
    Public Property MyParent As SubContract_management
    Private Sub subContract_multiple_viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub
    Private Sub loader()
        Dim sql As String = String.Format("SELECT a.sub_contract_id,a.sc_year,a.project_id
                        ,b.project_code,b.project_name
                        FROM trans_sub_contract a
                        LEFT JOIN {1}.lib_erp_project b ON b.project_id = a.project_id", _serverDBMain, _serverDBFS)
        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_sub_contract").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_sub_contract").ImportRow(dr)
        Next
        dgview.DataSource = ds.Tables("trans_sub_contract")
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim pk As String = "sub_contract_id"
        Dim colName As String = "project_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgview
        Dim delMsg As String = "Are you sure to delete this record(s)?"

        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "trans_sub_contract"
        Dim pk_delete As String = "sub_contract_id"
        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""
        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg)

        If ctr > 0 Then
            MsgBox(String.Format("There are {0} transaction(s) where this record(s) are used." & Environment.NewLine & msg, ctr),
                                                                                            MsgBoxStyle.Critical, "Unable to Delete")
        ElseIf arr_id.Length > 0 Then
            Dim ids As String = ""
            For i As Integer = 0 To arr_id.Length - 1
                ids &= arr_id(i) & "|"
            Next
            str = ATGenerateQuery("Remove", tbl_delete, Nothing, Environment.MachineName, Environment.UserName, MyLogId, ids, "sub_contract_id")
            ''FsQuery(str)
            Query(str)
            clear_control(Me)
            loader()
        End If
    End Sub

    Private Sub dgview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellDoubleClick
        btnDone.PerformClick()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If dgview.Rows.Count >= 0 Then
            If dgview.SelectedRows IsNot Nothing Then
                Dim id As String = dgview.SelectedRows(0).Cells("sub_contract_id").Value.ToString
                If MyParent IsNot Nothing Then
                    MyParent.loaders()
                    Dim drs = MyParent.ds.Tables("trans_sub_contract").Select(String.Format("sub_contract_id ='{0}'", id))
                    If drs.Count > 0 Then
                        Dim index As Integer = MyParent.ds.Tables("trans_sub_contract").Rows.IndexOf(drs(0))
                        MyParent.current_index = index
                        MyParent.setCurrentRecord(index)
                        MyParent.txt_subcon_management_id.Text = dgview.SelectedRows(0).Cells("sub_contract_id").Value.ToString
                        Me.DialogResult = DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub
End Class