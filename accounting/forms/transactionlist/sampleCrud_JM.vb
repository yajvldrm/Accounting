Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms

Public Class sampleCrud_JMs
    Private Sub sampleCrud_JMs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = String.Format("SELECT * FROM crud_info_sample", _serverDBFS)
        Dgvloader(sql, "tbl_crud")

    End Sub
    Public Sub Dgvloader(ByVal sql As String, ByVal tbls As String)
        Try

            Dim dt As DataTable = Query(sql)
            ds.Tables(tbls).Clear()
            For Each dr As DataRow In dt.Rows
                ds.Tables(tbls).ImportRow(dr)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sampleDataEntry.ids.Text = "tmp_" & Now.ToString("yyyyMMddHHmmss")
        sampleDataEntry.ShowDialog()

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dgview.SelectionChanged
        Try
            bind_source()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub bind_source()
        If dgview.SelectedRows.Count = 0 Then
            NewControls.clearControl(sampleDataEntry.Panel1)
            Exit Sub
        End If
        Dim sel As String = ifNull(dgview.SelectedRows(0).Cells("ids").Value, "").ToString
        Dim tmp_dr = ds.Tables("tbl_crud").Select("ids='" & sel & "'")
        Dim dr As DataRow = Nothing
        If tmp_dr.Count > 0 Then
            dr = tmp_dr(0)
            NewControls.bindControl(sampleDataEntry.Panel1, dr)
        End If
    End Sub
    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        ds.Tables("tbl_crud").Clear()
        'toggleDelete(dgview, "ids", "names", "sel", ds)
    End Sub
End Class