Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class report_cv_erc_filter_new
    Dim MyDT As DataTable

    Private Sub report_cv_erc_filter_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' For Fund Cluster
        Dim sql As String = String.Format("select * from lib_erp_fund_cluster")
        ds.Tables("lib_erp_fund").Clear()
        MyDT = ds.Tables("lib_erp_fund").Clone
        MyDT.Clear()

        Dim dt As DataTable = FsQuery(sql)
        For Each row As DataRow In dt.Rows
            ds.Tables("lib_erp_fund").ImportRow(row)
            MyDT.ImportRow(row)

        Next
        cbo_fund_cluster.DataSource = MyDT
        cbo_fund_cluster.DisplayMember = "fund_name"
        cbo_fund_cluster.ValueMember = "fund_id"

        '' For MFO/PAP
        Dim sql1 As String = String.Format("select * from lib_erp_mfo")
        ds.Tables("lib_erp_mfo").Clear()
        MyDT = ds.Tables("lib_erp_mfo").Clone
        MyDT.Clear()

        Dim dt1 As DataTable = FsQuery(sql1)
        For Each row As DataRow In dt1.Rows
            ds.Tables("lib_erp_mfo").ImportRow(row)
            MyDT.ImportRow(row)

        Next
        cbo_mfo_pap.DisplayMember = "mfo_name"
        cbo_mfo_pap.ValueMember = "mfo_id"
        cbo_mfo_pap.DataSource = MyDT


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_mfo_pap.SelectedIndexChanged
        Dim sql As String = String.Format("select  mfo_code from lib_erp_mfo where mfo_id = {0}", cbo_mfo_pap.SelectedValue)
        Dim dt As DataTable = FsQuery(sql)
        TextBox2.Text = dt(0)(0).ToString
    End Sub
End Class