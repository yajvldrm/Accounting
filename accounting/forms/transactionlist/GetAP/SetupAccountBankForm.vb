Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class SetupAccountBankForm
    Public Property account_id As String = ""
    Public Property account_code As String = ""
    Public Property account_name As String = ""
    Public Property trans_no As String = ""
    Private Sub txt_bank_id_Leave(sender As Object, e As EventArgs) Handles txt_bank_id.Leave
        Dim dt As DataTable = FsQuery("SELECT account_id,account_code,account_name FROM lib_erp_chart WHERE IFNULL(validation,0) = 1;")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("account_code = '{0}' OR account_name = '{0}'", txt_bank_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "account_code,account_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_bank_id.RowData = dr
                txt_bank_id.Value = dr("account_id")
                txt_bank_id.Text = dr("account_name")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        account_id = txt_bank_id.Value
        account_code = txt_bank_id.RowData.Item("account_code").ToString
        account_name = txt_bank_id.RowData.Item("account_name").ToString
        trans_no = txt_trans_no.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub SetupAccountBankForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_trans_no.Text = trans_no
    End Sub
End Class