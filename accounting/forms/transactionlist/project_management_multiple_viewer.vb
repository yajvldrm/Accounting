Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms

Public Class project_management_multiple_viewer
    Private MyLogId = main.log_id
    Public Property parent As Project_management
    Dim conStr As String = "Server=" & vtxtIP & ";User Id=" & _serverUser & ";Password=" & _serverPass & ";Database=" & _serverDBMain & ";Port = " & _serverPort & ";Convert Zero Datetime=True;Connect Timeout=6000000"
    Private Sub loader()
        Dim sql As String = String.Format("SELECT a.project_management_id,a.pm_year,a.general_id,a.project_id
        ,b.general_code,b.general_name,c.project_code,c.project_name
        FROM trans_project_management a
        LEFT JOIN {0}.lib_erp_general b ON b.general_id = a.general_id
        LEFT JOIN {0}.lib_erp_project c on c.project_id=a.project_id
        where deleted=0
         ", _serverDBFS)

        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_project_management").Clear()

        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_project_management").ImportRow(dr)
        Next


        dgview.DataSource = ds.Tables("trans_project_management")


    End Sub

    Private Sub project_management_multiple_viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub dgview_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgview.CellDoubleClick
        If dgview.Rows.Count > 0 Then
            If dgview.SelectedRows IsNot Nothing Then
                Dim id As String = dgview.SelectedRows(0).Cells("project_management_id").Value.ToString
                If parent IsNot Nothing Then
                    parent.loader()
                    Dim drs = parent.ds.Tables("trans_project_management").Select(String.Format("project_management_id ='{0}'", id))
                    If drs.Count > 0 Then
                        Dim index As Integer = parent.ds.Tables("trans_project_management").Rows.IndexOf(drs(0))
                        parent.current_index = index
                        parent.setCurrentRecord(index)
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim dt As DataTable = ds.Tables("trans_project_management")
            For Each dr As DataRow In dt.Rows
                If dr.Item("sel") = True Then
                    Dim dic As New Dictionary(Of String, String)
                    Dim qry As String = ""
                    dic.Add("project_management_id", dr.Item("project_management_id").ToString)
                    dic.Add("pm_year", dr.Item("pm_year").ToString)
                    dic.Add("general_id", dr.Item("general_id").ToString)
                    dic.Add("project_id", dr.Item("project_id").ToString)
                    dic.Add("deleted", 1)
                    qry = ATGenerateQuery("Update", "trans_project_management", dic, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("project_management_id").ToString, "project_management_id")
                    Query(qry)
                End If
            Next
            loader()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub



    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If dgview.Rows.Count > 0 Then
            If dgview.SelectedRows IsNot Nothing Then
                Dim id As String = dgview.SelectedRows(0).Cells("project_management_id").Value.ToString
                If parent IsNot Nothing Then
                    parent.loader()
                    Dim drs = parent.ds.Tables("trans_project_management").Select(String.Format("project_management_id ='{0}'", id))
                    If drs.Count > 0 Then
                        Dim index As Integer = parent.ds.Tables("trans_project_management").Rows.IndexOf(drs(0))
                        parent.current_index = index
                        parent.setCurrentRecord(index)
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub
End Class