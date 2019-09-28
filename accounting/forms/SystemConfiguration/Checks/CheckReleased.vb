Imports connectionlib.connectionlib
Public Class CheckReleased
    Private Sub LoadChecks(Optional toDg As Boolean = True)
        dgMain.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT a.* " &
            "FROM select_checks a " &
            "" &
            "WHERE a.isCash <> '1' AND a.journal_id = '4' AND a.cancelled <> '1' AND (a.funded = '1' OR a.isPDC) " &
            "")
        If txt_bank_id.Value <> "" Then
            sql &= String.Format(" AND a.bank_id = '{0}' ", txt_bank_id.Value)
        End If
        If txt_date_from.Value <= txt_date_to.Value Then
            sql &= String.Format(" AND a.check_date BETWEEN '{0}' AND '{1}' ",
                txt_date_from.Value.ToString("yyyy-MM-dd"), txt_date_to.Value.ToString("yyyy-MM-dd"))
        End If
        If txt_trans_id.Value <> "" Then
            sql &= String.Format(" AND a.trans_id = '{0}' ", txt_trans_id.Value)
        End If
        If txt_check_id.Value <> "" Then
            sql &= String.Format(" AND a.check_id = '{0}' ", txt_check_id.Value)
        End If
        If txt_general_id.Value <> "" Then
            sql &= String.Format(" AND a.general_id = '{0}' ", txt_general_id.Value)
        End If
        Dim dt As DataTable = Query(sql)
        If toDg Then
            dgMain.DataSource = dt
        Else
        End If
    End Sub
    Private Sub CreateTextBrowse(ByVal sql As String,
                                 ByVal q As String,
                                 ByVal label As String,
                                 ByVal field As String,
                                 ByVal width As String,
                                 ByRef returnDr As DataRow,
                                 Optional isFS As Boolean = True)

        q = q.Replace("'", "''")
        Dim fields = field.Split(",")
        Dim strQ As String = ""
        For Each f In fields
            If f <> "trans_date" And f <> "check_date" Then
                strQ &= String.Format(" OR {0} = '{1}' ", f, q)
            End If
        Next
        Dim dt As DataTable = Nothing
        If isFS Then
            dt = FsQuery(sql)
        Else
            dt = Query(sql)
        End If
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(strQ.Substring(4))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format(label, field, width)
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                returnDr = dr
            End If
        End If
    End Sub
    Private Sub BankBrowse(sender As Object, e As EventArgs) Handles txt_bank_id.Leave
        Dim sql As String = String.Format("SELECT bank_id,bank_code,bank_name " &
            "FROM lib_erp_bank" &
            "")
        Dim q As String = txt_bank_id.Text.Trim
        Dim label As String = "Code,Name"
        Dim field As String = "bank_code,bank_name"
        Dim width As String = "100,200"
        Dim dr As DataRow = Nothing
        CreateTextBrowse(sql, q, label, field, width, dr)
        If dr IsNot Nothing Then
            txt_bank_id.Text = dr.Item("bank_name").ToString
            txt_bank_id.Value = dr.Item("bank_id").ToString
        Else
            txt_bank_id.Text = ""
            txt_bank_id.Value = ""
        End If
    End Sub
    Private Sub TransactionBrowse(sender As Object, e As EventArgs) Handles txt_trans_id.Leave
        Dim sql As String = String.Format("SELECT trans_id,trans_no,trans_date " &
            "FROM trans_header " &
            "WHERE journal_id = '4' " &
            "")
        Dim q As String = txt_trans_id.Text.Trim
        Dim label As String = "Voucher No,Date"
        Dim field As String = "trans_no,trans_date"
        Dim width As String = "200,100"
        Dim dr As DataRow = Nothing
        CreateTextBrowse(sql, q, label, field, width, dr, False)
        If dr IsNot Nothing Then
            txt_trans_id.Text = dr.Item("trans_no").ToString
            txt_trans_id.Value = dr.Item("trans_id").ToString
        Else
            txt_trans_id.Text = ""
            txt_trans_id.Value = ""
        End If
    End Sub
    Private Sub CheckBrowse(sender As Object, e As EventArgs) Handles txt_check_id.Leave
        Dim sql As String = String.Format("SELECT a.* " &
            "FROM select_checks a " &
            "" &
            "WHERE a.isCash <> '1' AND a.journal_id = '4' AND a.cancelled <> '1' " &
            "")
        Dim q As String = txt_check_id.Text.Trim
        Dim label As String = "Check No,Date"
        Dim field As String = "check_no,check_date"
        Dim width As String = "200,100"
        Dim dr As DataRow = Nothing
        CreateTextBrowse(sql, q, label, field, width, dr, False)
        If dr IsNot Nothing Then
            txt_check_id.Text = dr.Item("check_no").ToString
            txt_check_id.Value = dr.Item("check_id").ToString
        Else
            txt_check_id.Text = ""
            txt_check_id.Value = ""
        End If
    End Sub
    Private Sub GeneralBrowse(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim sql As String = String.Format("SELECT general_id,general_code,general_name " &
            "FROM lib_erp_general " &
            "")
        Dim q As String = txt_general_id.Text.Trim
        Dim label As String = "Code,Name"
        Dim field As String = "general_code,general_name"
        Dim width As String = "100,200"
        Dim dr As DataRow = Nothing
        CreateTextBrowse(sql, q, label, field, width, dr)
        If dr IsNot Nothing Then
            txt_general_id.Text = dr.Item("general_code").ToString
            txt_general_id.Value = dr.Item("general_id").ToString
        Else
            txt_general_id.Text = ""
            txt_general_id.Value = ""
        End If
    End Sub
    Private Sub CheckFunding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.Value = Today.ToString("MM/01/yyyy")
        txt_date_to.Value = GetLastDayOfMonth(Today.Month, Today.Year)
        LoadChecks()
    End Sub
    Public Function GetLastDayOfMonth(intMonth, intYear) As Date
        Return DateSerial(intYear, intMonth + 1, 0)
    End Function
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim dt As DataTable = dgMain.DataSource
        If dt IsNot Nothing Then
            For Each dr As DataRow In dt.Rows
                Dim dic As New Dictionary(Of String, String)
                dic.Add("check_id", dr.Item("check_id").ToString)
                If dr.Item("released").ToString = "True" Or dr.Item("released").ToString = "1" Then
                    dic.Add("released", "1")
                    dic.Add("deposit_date", CDate(dr.Item("deposit_date").ToString).ToString("yyyy-MM-dd"))
                Else
                    dic.Add("released", "0")
                    dic.Add("deposit_date", Nothing)
                End If
                Dim sql = ATGenerateQuery("Update", "trans_checks", dic, Environment.MachineName, Environment.UserName, main.log_id)
                Query(sql)
            Next
            MsgBox("Save.")
            LoadChecks()
        End If
    End Sub

    Private Sub dgMain_CellValueChanged(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgMain.CellValueChanged
        Dim r = e.RowIndex
        Dim c = e.ColumnIndex
        Dim colName = dgMain.Columns(c).Name
        If r >= 0 Then
            Dim val = dgMain.Rows(r).Cells(c).Value
        End If
        If colName = "released" Then
            If dgMain.Rows(r).Cells("isPDC").Value Then
                If dgMain.Rows(r).Cells("funded").Value Then
                    If dgMain.Rows(r).Cells(c).Value = 0 Then
                        dgMain.Rows(r).Cells(c).Value = 1
                    End If
                Else
                    If dgMain.Rows(r).Cells(c).Value Then
                        dgMain.Rows(r).Cells("deposit_date").Value = Today
                    Else
                        dgMain.Rows(r).Cells("deposit_date").Value = DBNull.Value
                    End If
                End If
            Else
                If dgMain.Rows(r).Cells(c).Value Then
                    dgMain.Rows(r).Cells("deposit_date").Value = Today
                Else
                    dgMain.Rows(r).Cells("deposit_date").Value = DBNull.Value
                End If
            End If
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadChecks()
    End Sub
End Class