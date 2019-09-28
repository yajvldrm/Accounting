Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class offsetfixedasset
    Private _account_id As String = ""
    Private _trans_id As String = ""
    Private _jbooks_id As String = ""
    Private _filter_date As String = ""
    Private _general_id As String = ""
    Private _currency_id As String = ""
    Private _project_id As String = ""
    Private _department_id As String = ""
    Private currentSearchIndex As Integer = 0
    Private searchFocus As Boolean = False
    Private OriginalDT As DataTable = Nothing

    Public Property exchange_rate As Decimal = 0.0
    Public Property based_rate As Decimal = 0.0
    Public Property currency_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _currency_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _currency_id = value
        End Set
    End Property
    Public Property project_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _project_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _project_id = value
        End Set
    End Property
    Public Property department_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _department_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _department_id = value
        End Set
    End Property
    Public Property jbooks_id() As String
        Get
            Return _jbooks_id
        End Get
        Set(ByVal value As String)
            _jbooks_id = value
        End Set
    End Property
    Public Property general_id() As String
        Get
            Return _general_id
        End Get
        Set(ByVal value As String)
            _general_id = value
        End Set
    End Property
    Public Property BookID As String = ""
    Public Property trans_id() As String
        Get
            Return _trans_id
        End Get
        Set(ByVal value As String)
            _trans_id = value
        End Set
    End Property
    Public Property account_id() As String
        Get
            Return _account_id
        End Get
        Set(ByVal value As String)
            _account_id = value
        End Set
    End Property

    Public Property filter_date() As String
        Get
            Return _filter_date
        End Get
        Set(ByVal value As String)
            _filter_date = value
        End Set
    End Property
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        dgOffset.Columns("tmp_amount").DefaultCellStyle.Format = strNumberFormat
        dgOffset.Columns("amount").DefaultCellStyle.Format = strNumberFormat
        dgOffset.Columns("balance").DefaultCellStyle.Format = strNumberFormat
    End Sub
    Private Sub cmdNotSave_Click(sender As Object, e As EventArgs) Handles cmdNotSave.Click
        Me.Hide()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim dt As DataTable = ds.Tables("fixed_asset")
        Dim total As Decimal = CDec(ifNull(txttotal.DecimalValue, 0))
        If total = 0 Then
            MsgBox("No Amount To Save")
            Exit Sub
        End If
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                row.Item("jbooks_id") = jbooks_id
                Try
                    If row.Item("isInputted") Then
                    Else
                        If row.Item("ref_fixed_asset_id") = "" Then
                            dt.Rows.Remove(row)
                        Else
                            row.Item("deleted") = True
                        End If
                    End If
                Catch
                    If row.Item("ref_fixed_asset_id") = "" Then
                        dt.Rows.Remove(row)
                    Else
                        row.Item("deleted") = True
                    End If
                End Try
            Next
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Public Sub refresh_data()
        Dim sql = ""
        If trans_id = "" Then
            sql = String.Format("SELECT a.date_acquired,a.date_start,a.jbooks_id,a.currency_id,a.exchange_rate,a.based_rate, a.asset_code,a.description " &
                ",IFNULL(f.journal_code,'') AS ref_no,d.trans_no,d.trans_date,a.fixed_asset_id AS ref_fixed_asset_id,0 AS amount,a.salvage_value,a.salvage_value_based,(a.amount - IF(e.amount IS NULL,0,e.amount)) AS tmp_amount,b.line_remarks AS particulars " &
                "FROM trans_fixed_asset a " &
                "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN trans_jbooks_ref c ON c.jbooks_id = b.jbooks_id " &
                "LEFT JOIN trans_header d ON d.trans_id = b.trans_id " &
                "LEFT JOIN (SELECT a.ref_fixed_asset_id AS fixed_asset_id,SUM(a.amount) AS amount FROM trans_fixed_asset a GROUP BY a.ref_fixed_asset_id) e ON e.fixed_asset_id = a.fixed_asset_id " &
                "LEFT JOIN {6}.lib_erp_journal f ON f.journal_id = d.journal_id " &
                "WHERE b.account_id = {0} " &
                "AND b.currency_id = {2} " &
                "AND b.project_id {3} " &
                "AND b.department_id {4} " &
                "AND d.trans_date <= '{1}' AND a.ref_fixed_asset_id IS NULL AND (a.amount - IF(e.amount IS NULL,0,e.amount)) <> 0 ", account_id, filter_date, currency_id, If(project_id = "", " IS NULL ", " = " & project_id), If(department_id = "", " IS NULL ", " = " & department_id), If(BookID = "", "IS NULL", "= " & BookID), _serverDBFS)
        Else
            sql = String.Format("SELECT a.date_acquired,a.date_start,a.jbooks_id,a.currency_id,a.exchange_rate,a.based_rate, a.asset_code,a.description " &
                ",IFNULL(f.journal_code,'') AS ref_no,d.trans_no,d.trans_date,a.fixed_asset_id AS ref_fixed_asset_id,0 AS amount,a.salvage_value,a.salvage_value_based,(a.amount - IF(e.amount IS NULL,0,e.amount)) AS tmp_amount,b.line_remarks AS particulars " &
                "FROM trans_fixed_asset a " &
                "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN trans_jbooks_ref c ON c.jbooks_id = b.jbooks_id " &
                "LEFT JOIN trans_header d ON d.trans_id = b.trans_id " &
                "LEFT JOIN (SELECT a.ref_fixed_asset_id AS fixed_asset_id,SUM(a.amount) AS amount FROM trans_fixed_asset a LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id WHERE b.trans_id <> {1} GROUP BY a.ref_fixed_asset_id) e ON e.fixed_asset_id = a.fixed_asset_id " &
                "LEFT JOIN {7}.lib_erp_journal f ON f.journal_id = d.journal_id " &
                "WHERE b.account_id = {0} " &
                "AND b.currency_id = {3} " &
                "AND b.project_id {4} " &
                "AND b.department_id {5} " &
                "AND d.trans_id <> {1} " &
                "AND d.trans_date <= '{2}' AND a.ref_fixed_asset_id IS NULL AND (a.amount - IF(e.amount IS NULL,0,e.amount)) <> 0 ", account_id, trans_id, filter_date, currency_id, If(project_id = "", " IS NULL ", " = " & project_id), If(department_id = "", " IS NULL ", " = " & department_id), If(BookID = "", "IS NULL", "= " & BookID), _serverDBFS)
        End If
        Dim _data As DataTable = Query(sql)
        Dim _dt = _data.Clone
        _dt.Clear()
        _dt.Columns("jbooks_id").DataType = Type.GetType("System.String")
        For Each dr As DataRow In _data.Rows
            _dt.ImportRow(dr)
        Next
        ds.Tables("fixed_asset").Clear()
        For Each row As DataRow In _dt.Rows
            row.Item("jbooks_id") = jbooks_id
            ds.Tables("fixed_asset").ImportRow(row)
        Next
    End Sub
    Private Sub offsetfixedasset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgOffset.AutoGenerateColumns = False
        'dgOffset.DataSource = ds.Tables("fixed_asset")
        txtDateFrom.Value = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString())
        txtjbooksid.Text = jbooks_id
    End Sub

    Private Sub dgOffset_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgOffset.CellValueChanged
        If dgOffset.DataSource Is Nothing Then
            Exit Sub
        End If
        Dim i As Integer = e.RowIndex
        Dim drv As DataRowView = bs_fixed_asset.Current
        If drv IsNot Nothing Then
            Dim dr As DataRow = drv.Row
            If dr.Item("isInputted") Then
                If dr.Item("amount") = 0 Then
                    dr.Item("amount") = dr.Item("tmp_amount")
                    dr.Item("credit") = dr.Item("amount")
                    dr.Item("amount_based") = dr.Item("amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                    dr.Item("credit_based") = dr.Item("amount_based")
                End If
            Else
                dr.Item("amount") = 0.0
                dr.Item("credit") = 0.0
                dr.Item("amount_based") = 0.0
                dr.Item("credit_based") = 0.0
            End If

            dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("amount")
            dr.Item("amount_based") = dr.Item("amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
            dr.Item("credit_based") = dr.Item("amount_based")
            dr.Item("credit") = dr.Item("amount")


            If dr.Item("balance") < 0 Then
                MsgBox("Overpayments Datected.")
                dr.Item("amount") = dr.Item("tmp_amount")
                dr.Item("credit") = dr.Item("amount")
                dr.Item("amount_based") = dr.Item("amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                dr.Item("credit_based") = dr.Item("credit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("amount")
            End If
        End If
        If i > 0 Then
            If e.ColumnIndex = 5 Then
                With DirectCast(dgOffset.Rows(i).DataBoundItem, DataRowView).Row
                    '     |-- The index of boolean DataColumn
                    .Item(0) = True
                    .EndEdit()
                End With
            End If
        End If
    End Sub

    Private Sub dgOffset_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgOffset.CurrentCellDirtyStateChanged
        If dgOffset.CurrentCell.ColumnIndex = 5 Then
            If dgOffset.IsCurrentCellDirty Then
                dgOffset.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub

    Private Sub dgOffset_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgOffset.DataBindingComplete
        Dim totaldebit As Decimal = 0
        For Each row As DataGridViewRow In dgOffset.Rows
            Dim drv As DataRowView = row.DataBoundItem
            Dim dr = drv.Row
            totaldebit += dr.Item("amount")
        Next
        txttotal.DecimalValue = totaldebit
    End Sub
    Private Sub txt_search_TextChange(sender As Object, e As EventArgs) Handles txt_search.TextChange
        Dim q As String = StringReplace(txt_search.Text, "~!@#$%^&*()_+{}:""|<>?=[];'\,./+`", "")
        Dim dt As DataTable = dgOffset.DataSource
        Dim drs = dt.Select(String.Format("trans_no LIKE '%{0}%'", q))
        If drs.Length > 0 Then
            If currentSearchIndex >= drs.Length Then
                currentSearchIndex = 0
            End If
            Dim selectedID As String = drs(currentSearchIndex).Item("trans_no").ToString
            dgOffset.ClearSelection()
            For Each row As DataGridViewRow In dgOffset.Rows
                If row.Cells("trans_no").Value.ToString = selectedID Then
                    row.Selected = True
                    Dim tmp_index = dt.Rows.IndexOf(drs(currentSearchIndex))
                    dgOffset.FirstDisplayedScrollingRowIndex = tmp_index
                End If
            Next
        End If
    End Sub
    Private Sub offsetform_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If searchFocus Then
            If e.KeyCode = Keys.Enter And e.Control Then
                currentSearchIndex += 1
                txt_search_TextChange(Nothing, Nothing)
                e.SuppressKeyPress = True
            End If
        End If
    End Sub
    Private Sub txtsearch_Enter(sender As Object, e As EventArgs) Handles txt_search.Enter
        searchFocus = True
    End Sub

    Private Sub txtsearch_Leave(sender As Object, e As EventArgs) Handles txt_search.Leave
        searchFocus = False
    End Sub

    Private Sub dgOffset_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgOffset.DataError
        Dim ex = e.Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Invalid Input")
    End Sub

    Private Sub cboAll_CheckedChanged(sender As Object, e As EventArgs) Handles cboAll.CheckedChanged
        Dim isInputted As Boolean = cboAll.Checked
        ''Dim dt As DataTable = dgOffset.DataSource
        For Each row As DataGridViewRow In dgOffset.Rows
            Dim drv As DataRowView = row.DataBoundItem
            Dim dr = drv.Row
            dr.Item("isInputted") = isInputted
            If isInputted Then
                If dr.Item("amount") = 0 Then
                    dr.Item("amount") = dr.Item("tmp_amount")
                    dr.Item("credit") = dr.Item("amount")
                    dr.Item("amount_based") = dr.Item("amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                    dr.Item("credit_based") = dr.Item("amount_based")
                End If
            Else
                dr.Item("amount") = 0.0
                dr.Item("credit") = 0.0
                dr.Item("amount_based") = 0.0
                dr.Item("credit_based") = 0.0
            End If

            dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("amount")
            dr.Item("amount_based") = dr.Item("amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
            dr.Item("credit_based") = dr.Item("amount_based")
            dr.Item("credit") = dr.Item("amount")


            If dr.Item("balance") < 0 Then
                MsgBox("Overpayments Datected.")
                dr.Item("amount") = dr.Item("tmp_amount")
                dr.Item("credit") = dr.Item("amount")
                dr.Item("amount_based") = dr.Item("amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                dr.Item("credit_based") = dr.Item("credit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("amount")
            End If
        Next
    End Sub
    Private Sub FilterByDate(dateFrom As DateTime, dateTo As DateTime)
        Dim q = String.Format("ref_trans_date <= '{1}' AND ref_trans_date >= '{0}'", dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"))
        bs_fixed_asset.Filter = q
    End Sub

    Private Sub txtDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles txtDateFrom.ValueChanged
        txtDateTo.MinDate = txtDateFrom.Value
        FilterByDate(txtDateFrom.Value, txtDateTo.Value)
    End Sub

    Private Sub txtDateTo_ValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.ValueChanged
        FilterByDate(txtDateFrom.Value, txtDateTo.Value)
    End Sub
End Class