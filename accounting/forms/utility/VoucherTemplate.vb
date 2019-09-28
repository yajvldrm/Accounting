Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Public Class VoucherTemplate
    Public Sub InitializeConnection()
        Using cn As New MySqlConnection With {.ConnectionString = ConnectionStringFS}
            Me.Get_voucher_moduleTableAdapter.Connection = cn
            Me.Get_lib_acc_voucher_templateTableAdapter.Connection = cn

            Me.Get_voucher_moduleTableAdapter.Fill(Me.DsVoucherTemplateSet.get_voucher_module)
        End Using
        EnableControl(False)
    End Sub
    Private Sub EnableControl(Optional enable = True)
        btnEdit.Visible = Not enable
        btnSave.Visible = enable
        btnCancel.Visible = enable
        parent_grid.Enabled = Not enable
        child_grid.Enabled = enable
    End Sub
    Private Sub VoucherTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        parent_hide.Visible = False
    End Sub

    Private Sub txtModuleID_EditValueChanged(sender As Object, e As EventArgs) Handles txtModuleID.EditValueChanged
        Dim id As String = txtModuleID.EditValue.ToString
        If id <> "" Then
            Me.Get_lib_acc_voucher_templateTableAdapter.Fill(Me.DsVoucherTemplateSet.get_lib_acc_voucher_template, id)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableControl()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim lstUpdate As New List(Of String)
        For Each dr As DataRow In Me.DsVoucherTemplateSet.get_lib_acc_voucher_template.Rows
            Dim str As String = String.Format("UPDATE lib_acc_voucher_template SET file_location = '{0}' WHERE voucher_template_id = '{1}'", dr.Item("file_location").ToString(), dr.Item("voucher_template_id").ToString())
            lstUpdate.Add(str)
        Next
        Dim strUpdate As String = String.Join(";", lstUpdate)
        FsQuery(strUpdate)
        InitializeConnection()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        EnableControl(False)
        Me.Get_voucher_moduleBindingSource.CancelEdit()
    End Sub

    Private Sub repoBrowse_Click(sender As Object, e As EventArgs) Handles repoBrowse.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow = child_view.GetFocusedDataRow
            If dr IsNot Nothing Then
                dr.Item("file_location") = OpenFileDialog1.FileName.Replace("\", "/")
            End If
        End If
    End Sub

    Private Sub btnReportDesigner_Click(sender As Object, e As EventArgs) Handles btnReportDesigner.Click
        reportddesigner.Show()
    End Sub
End Class