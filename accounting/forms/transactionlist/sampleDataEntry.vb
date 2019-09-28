Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Public Class sampleDataEntry

    Private Sub btn_Add_Click_1(sender As Object, e As EventArgs) Handles btn_Add.Click
        Try

            MsgBox(generateRange(DateTimePicker1.Value, DateTimePicker2.Value))
            'add to dataset
            Dim dr As DataRow = sampleCrud_JMs.ds.Tables("tbl_crud").NewRow
            dr.Item("namess") = txt_name.Text
            dr.Item("course") = txt_course.Text
            dr.Item("year") = txt_year.Text
            sampleCrud_JMs.ds.Tables("tbl_crud").Rows.Add(dr)

            ''edit to dataset
            Dim drs = sampleCrud_JMs.ds.Tables("tbl_crud").Select(String.Format("ids='{0}'", ids.Text))
            If drs.Length > 0 Then
                Dim drt As DataRow = drs(0)

                drt.Item("namess") = txt_name.Text
                drt.Item("course") = txt_course.Text
                drt.Item("year") = txt_year.Text
                drt.Item("ids") = ids.Text
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class