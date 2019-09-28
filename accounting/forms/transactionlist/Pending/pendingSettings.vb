Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class pendingSettings

    Public Property account_id As String = ""
    Public Property account_code As String = ""
    Public Property account_name As String = ""
    Public Property book_id As String = ""
    Public Property book_code As String = ""
    Public Property book_name As String = ""
    Public Property general_id As String = ""
    Public Property general_code As String = ""
    Public Property general_name As String = ""
    Public Property currency_id As String = ""
    Public Property currency_code As String = ""
    Public Property currency_name As String = ""
    Public Property trans_date As DateTime = Today
    Public Property trans_no As String = ""
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        trans_no = txt_trans_no.Text
        trans_date = txt_trans_date.Value
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub txt_book_id_Leave(sender As Object, e As EventArgs) Handles txt_book_id.Leave
        If txt_book_id.Text.Trim() = "" Then
            txt_book_id.RowData = Nothing
            txt_book_id.Value = ""
            txt_book_id.Text = ""
            book_id = ""
            book_code = ""
            book_name = ""
            Exit Sub
        End If
        Dim dt As DataTable = FsQuery(String.Format("SELECT book_id,book_code,book_name FROM lib_erp_book WHERE company_id = '{0}';", main.Sys_Default.Rows(0).Item("company_id").ToString()))
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("book_code = '{0}' OR book_name = '{0}'", txt_book_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "book_code,book_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_book_id.RowData = dr
                txt_book_id.Value = dr("book_id")
                txt_book_id.Text = dr("book_name")
                book_id = dr("book_id")
                book_code = dr("book_code")
                book_name = dr("book_name")
            Else
                txt_book_id.RowData = Nothing
                txt_book_id.Value = ""
                txt_book_id.Text = ""
                book_id = ""
                book_code = ""
                book_name = ""
            End If
        End If
    End Sub
    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        If txt_account_id.Text.Trim() = "" Then
            txt_account_id.RowData = Nothing
            txt_account_id.Value = ""
            txt_account_id.Text = ""
            account_id = ""
            account_code = ""
            account_name = ""
            Exit Sub
        End If
        Dim dt As DataTable = FsQuery("SELECT account_id,account_code,account_name FROM lib_erp_chart WHERE IFNULL(validation,0) = 1;")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("account_code = '{0}' OR account_name = '{0}'", txt_account_id.Text.ToString.Replace("'", "''")))
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
                txt_account_id.RowData = dr
                txt_account_id.Value = dr("account_id")
                txt_account_id.Text = dr("account_name")
                account_id = dr("account_id")
                account_code = dr("account_code")
                account_name = dr("account_name")
            Else
                txt_account_id.RowData = Nothing
                txt_account_id.Value = ""
                txt_account_id.Text = ""
                account_id = ""
                account_code = ""
                account_name = ""
            End If
        End If
    End Sub
    Private Sub txt_trans_date_ValueChanged(sender As Object, e As EventArgs) Handles txt_trans_date.ValueChanged
        trans_date = txt_trans_date.Value
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub pendingSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_account_id.Value = account_id
        txt_account_id.Text = account_name
        txt_book_id.Value = book_id
        txt_book_id.Text = book_name
        txt_trans_date.Value = trans_date
        txt_trans_no.Text = trans_no
    End Sub
End Class