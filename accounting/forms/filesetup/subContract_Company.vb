Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class subContract_Company
    Dim transmode As String = Nothing
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        enable_control(Me)
        clear_control(Me)
    End Sub
    Private Sub subContract_Company_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub
    Private Sub loader()
        Try
            Dim sql As String = String.Format("SELECT * FROM {0}.lib_subcon", _serverDBFS)
            Dim dt As DataTable = Query(sql)
            For Each dr As DataRow In dt.Rows
                ds.Tables("dt_subcon").ImportRow(dr)
            Next
            bs.DataSource = ds.Tables("dt_subcon")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        If dgMain.RowCount = 0 Then
            NewControls.clearControl(gboxContainer)
            Exit Sub
        End If
        If dgMain.SelectedRows.Count = 0 Then
            NewControls.clearControl(gboxContainer)
            Exit Sub
        End If
        Dim sel As String = ifNull(dgMain.SelectedRows(0).Cells("subconid").Value, "").ToString
        txt_subcon_id.Text = ifNull(dgMain.SelectedRows(0).Cells("subconid").Value, "").ToString
        Dim tmp_dr = ds.Tables("dt_subcon").Select("subconid= '" & sel & "'")
        Dim dr As DataRow = Nothing
        If tmp_dr.Count > 0 Then
            dr = tmp_dr(0)
            NewControls.bindControl(gboxContainer, dr)
            txt_subcon_id.Value = dr("subconid")
            txt_subcon_code.Text = dr("subconcode")
            txt_subcon_name.Text = dr("subconname")
        End If
        sel = ""
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        NewControls.clearControl(gboxContainer)
        Me.Close()
        Exit Sub
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txt_subcon_id.Text <> Nothing Then
            transmode = "update"
            enable_control(Me)
        Else
            MsgBox("Select a Record First!", vbInformation + vbOKOnly)
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '    validation

        Dim sql As String = String.Format("SELECT * FROM {0}.lib_subcon where subconcode='{1}' or subconname='{2}'", _serverDBFS, txt_subcon_code.Text, txt_subcon_name.Text)
        Dim dts As DataTable = FsQuery(sql)
        If transmode = "update" Then
            saved_update()
            Exit Sub
        End If

        If dts.Rows.Count >= 1 Then
            MsgBox("Already existing!", vbCritical + vbOKOnly)
            Exit Sub
        Else
            If txt_subcon_code.Text = "" Or txt_subcon_name.Text = "" Then
                MsgBox("Please complete the data", vbInformation + vbOKOnly)
            Else
                saved_update()
            End If
        End If
    End Sub
    Private Sub saved_update()
        Try
            Dim ids As String = txt_subcon_id.Text
            Dim dic As New Dictionary(Of String, String)
            dic.Add("subconid", txt_subcon_id.Text)
            dic.Add("subconcode", txt_subcon_code.Text)
            dic.Add("subconname", txt_subcon_name.Text)
            If transmode = "insert" Then
                FsQuery(ATGenerateQuery("Insert", "lib_subcon", dic, Environment.MachineName, Environment.UserName, main.log_id, ids, "subconid"))
                ds.Tables("dt_subcon").Clear()
            Else
                FsQuery(ATGenerateQuery("Update", "lib_subcon", dic, Environment.MachineName, Environment.UserName, main.log_id, ids, "subConid"))
                ds.Tables("dt_subcon").Clear()
            End If
            disable_control(Me)
            loader()
            bs.DataSource = ds.Tables("dt_subcon")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Dim sql As String = ""
    Dim lst As List(Of String) = New List(Of String)
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If txt_subcon_id.Text = Nothing Then
            MsgBox("Select first !", vbInformation + vbOKOnly)
        Else
            If MsgBox("You want to Delete ?", vbCritical + vbYesNo) = MsgBoxResult.Yes Then
                For Each dr As DataRow In ds.Tables("dt_subcon").Select(String.Format("sel={0}", 1))
                    If ifNull(dr.Item("subConid"), 0) > 0 Then
                        lst.Add(dr.Item("subConid"))
                    Else
                        Exit Sub
                    End If
                Next
                FsQuery(ATGenerateQuery("Remove", "lib_subcon", Nothing, Environment.MachineName, Environment.UserName, main.log_id, String.Join(",", lst), "subConid"))
                lst.Clear()
            End If

            ds.Tables("dt_subcon").Clear()
        End If
        loader()
        bs.DataSource = ds.Tables("dt_subcon")
    End Sub
    Private Sub txtsearch_TextChange(sender As Object, e As EventArgs) Handles txtsearch.TextChange
        If txtsearch.Text = Nothing Then
            loader()
        Else
            Try
                Dim sql As String = String.Format("SELECT * FROM {0}.lib_subcon where subconCode like '%{1}%' or subConname like '%{1}%'", _serverDBFS, txtsearch.Text)
                Dim dt As DataTable = Query(sql)
                ds.Tables("dt_subcon").Clear()
                For Each dr As DataRow In dt.Rows
                    ds.Tables("dt_subcon").ImportRow(dr)
                Next
                bs.DataSource = ds.Tables("dt_subcon")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub
End Class