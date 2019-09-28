Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class ewt
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim sql_company As String = String.Format("SELECT a.company_id,a.company_name " & _
            "FROM lib_erp_company a " & _
            "WHERE a.company_id = {0} ", main.Sys_Default.Rows(0).Item("company_id"))
        Dim dt_company As DataTable = FsQuery(sql_company)
        Dim sql As String = String.Format("SELECT a.ewt_id,a.ewt_code,a.ewt_name,a.tax_rate " & _
                                          "FROM lib_acc_ewt a " & _
                                          "")
        Dim dt As DataTable = FsQuery(sql)
        dt.TableName = "EWT"
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        If dt.Rows.Count = 0 Then
            MsgBox("No Recprds to Print.")
        Else
            Dim rep As New ewt_report_print
            rep.DataSource = ds
            rep.DataMember = (CType(rep.DataSource, DataSet)).Tables(0).TableName
            rep.Parameters("rundate").Value = System.DateTime.Now.ToString("MMMM dd, yyyy")
            rep.Parameters("runtime").Value = System.DateTime.Now.ToString("HH:mm:ss")
            rep.Parameters("company_name").Value = dt_company.Rows(0).Item("company_name")
            reportviewer.DocumentViewer1.DocumentSource = rep
            reportviewer.ShowDialog()
        End If
    End Sub
End Class