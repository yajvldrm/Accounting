Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class offsetoutputvat
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
        dgOffset.Columns("vat_amount").DefaultCellStyle.Format = strNumberFormat
        dgOffset.Columns("balance").DefaultCellStyle.Format = strNumberFormat
    End Sub
    Private Sub cmdNotSave_Click(sender As Object, e As EventArgs) Handles cmdNotSave.Click
        Me.Hide()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim offset_type = getRdoValue(txt_offset_type)
        Dim total As Decimal = CDec(ifNull(txttotal.DecimalValue, 0))
        If total = 0 Then
            MsgBox("No Amount To Save")
            Exit Sub
        End If
        Dim dt As DataTable = ds.Tables("output_vat")
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                row.Item("jbooks_id") = jbooks_id
                Try
                    If row.Item("isInputted") Then
                        row.Item("offset_type") = offset_type
                    Else
                        If row.Item("ref_output_vat_id") = "" Then
                            dt.Rows.Remove(row)
                        Else
                            row.Item("deleted") = True
                        End If
                    End If
                Catch
                    If row.Item("ref_output_vat_id") = "" Then
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
            sql = String.Format("SELECT a.general_id,a.currency_id,a.exchange_rate,a.based_rate,a.jbooks_id,a.output_vat_id AS ref_output_vat_id,(a.vat_amount - IF(f.vat_amount IS NULL,0,f.vat_amount)) AS tmp_amount " &
                ",IFNULL(g.journal_code,'') AS ref_no,d.trans_no,d.trans_date,e.general_code,e.general_name,b.account_id,0 AS vat_amount
                ,d.description,b.line_remarks AS particulars " &
                "FROM trans_output_vat a " &
                "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN trans_jbooks_ref c ON c.jbooks_id = b.jbooks_id " &
                "LEFT JOIN trans_header d ON d.trans_id = b.trans_id " &
                "LEFT JOIN {6}.lib_erp_general e ON e.general_id = a.general_id " &
                "LEFT JOIN (SELECT a.ref_output_vat_id AS output_vat_id,SUM(a.vat_amount) AS vat_amount FROM trans_output_vat a GROUP BY a.ref_output_vat_id) f ON f.output_vat_id = a.output_vat_id " &
                "LEFT JOIN {6}.lib_erp_journal g ON g.journal_id = d.journal_id " &
                "WHERE b.account_id = {0} " &
                "AND d.trans_date <= '{1}' " &
                "AND a.currency_id = '{3}' " &
                "AND b.department_id {5} " &
                "AND a.general_id <> 0 AND (a.offset_type = 0 OR a.offset_type IS NULL) AND a.general_id is not null AND (a.vat_amount - IF(f.vat_amount IS NULL,0,f.vat_amount)) <> 0 ", account_id, filter_date, general_id, currency_id, If(project_id = "", " IS NULL ", " = " & project_id), If(department_id = "", " IS NULL ", " = " & department_id), _serverDBFS, If(BookID = "", "IS NULL", "= " & BookID))
        Else
            sql = String.Format("SELECT a.general_id,a.currency_id,a.exchange_rate,a.based_rate,a.jbooks_id,a.output_vat_id AS ref_output_vat_id,(a.vat_amount - IF(f.vat_amount IS NULL,0,f.vat_amount)) AS tmp_amount " &
                ",IFNULL(g.journal_code,'') AS ref_no,d.trans_no,d.trans_date,e.general_code,e.general_name,b.account_id,0 AS vat_amount
                ,d.description,b.line_remarks AS particulars " &
                "FROM trans_output_vat a " &
                "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN trans_jbooks_ref c ON c.jbooks_id = b.jbooks_id " &
                "LEFT JOIN trans_header d ON d.trans_id = b.trans_id " &
                "LEFT JOIN {7}.lib_erp_general e ON e.general_id = a.general_id " &
                "LEFT JOIN (SELECT a.ref_output_vat_id AS output_vat_id,SUM(a.vat_amount) AS vat_amount FROM trans_output_vat a LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id WHERE b.trans_id <> {1} GROUP BY a.ref_output_vat_id) f ON f.output_vat_id = a.output_vat_id " &
                "LEFT JOIN {7}.lib_erp_journal g ON g.journal_id = d.journal_id " &
                "WHERE b.account_id = {0} " &
                "AND d.trans_id <> {1} " &
                "AND d.trans_date <= '{2}' " &
                "AND a.currency_id = '{4}' " &
                "AND b.department_id {6} " &
                "AND a.general_id <> 0 AND (a.offset_type = 0 OR a.offset_type IS NULL) AND (a.vat_amount - IF(f.vat_amount IS NULL,0,f.vat_amount)) <> 0 ", account_id, trans_id, filter_date, general_id, currency_id, If(project_id = "", " IS NULL ", " = " & project_id), If(department_id = "", " IS NULL ", " = " & department_id), _serverDBFS, If(BookID = "", "IS NULL", "= " & BookID))
        End If
        Dim _data As DataTable = Query(sql)
        Dim _dt = _data.Clone
        _dt.Clear()
        _dt.Columns("jbooks_id").DataType = Type.GetType("System.String")
        For Each dr As DataRow In _data.Rows
            _dt.ImportRow(dr)
        Next
        ds.Tables("output_vat").Clear()

        For Each row As DataRow In _dt.Rows
            row.Item("jbooks_id") = jbooks_id
            ds.Tables("output_vat").ImportRow(row)
        Next
    End Sub
    Private Sub offsetoutputvat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgOffset.AutoGenerateColumns = False
        'dgOffset.DataSource = ds.Tables("output_vat")
        txtjbooksid.Text = jbooks_id
        txt_date_from.Value = CDate(main.Sys_Default.Rows(0).Item("sys_beg"))
        particulars.Visible = CBool(ifNull(main.Sys_Default.Rows(0).Item("line_remarks"), 0))
    End Sub

    Private Sub dgOffset_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgOffset.CellValueChanged
        If dgOffset.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim dt As DataTable = ds.Tables("output_vat")
        Dim i As Integer = e.RowIndex
        '1 - VAT Inclusive
        '2 - VAT Exclusive
        If dgOffset.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim colIndex = dgOffset.Columns("ref_output_vat_id").Index
        Dim count = dgOffset.CurrentRow.Cells()
        Dim id = dgOffset.CurrentRow.Cells(colIndex).Value.ToString()
        Dim drs = dt.Select(String.Format("ref_output_vat_id = '{0}'", id))
        If drs.Length > 0 Then
            'Dim dr As DataRow = drv.Row
            If drs(0).Item("isInputted") Then
                If drs(0).Item("vat_amount") = 0 Then
                    drs(0).Item("vat_amount") = drs(0).Item("tmp_amount")
                    drs(0).Item("debit") = drs(0).Item("vat_amount")
                End If
            Else
                drs(0).Item("vat_amount") = 0.0
                drs(0).Item("debit") = 0.0
            End If

            drs(0).Item("debit") = drs(0).Item("vat_amount")
            drs(0).Item("debit_based") = drs(0).Item("vat_amount") * (drs(0).Item("exchange_rate") / drs(0).Item("based_rate"))
            drs(0).Item("vat_amount_based") = drs(0).Item("vat_amount") * (drs(0).Item("exchange_rate") / drs(0).Item("based_rate"))
            drs(0).Item("balance") = drs(0).Item("tmp_amount") - drs(0).Item("vat_amount")

            If drs(0).Item("balance") < 0 Then
                MsgBox("Overpayments Datected.")
                drs(0).Item("vat_amount") = drs(0).Item("tmp_amount")
                drs(0).Item("debit") = drs(0).Item("vat_amount")
                drs(0).Item("vat_amount_based") = drs(0).Item("vat_amount") * (drs(0).Item("exchange_rate") / drs(0).Item("based_rate"))
                drs(0).Item("debit_based") = drs(0).Item("debit") * (drs(0).Item("exchange_rate") / drs(0).Item("based_rate"))
                drs(0).Item("balance") = drs(0).Item("tmp_amount") - drs(0).Item("vat_amount")
            End If
            drs(0).AcceptChanges()
        End If
        'Dim drv As DataRowView = bs_output_vat.Current
        'If drv IsNot Nothing Then
        'End If
        'If i > 0 Then
        '    If e.ColumnIndex = 5 Then
        '        With DirectCast(dgOffset.Rows(i).DataBoundItem, DataRowView).Row
        '            '     |-- The index of boolean DataColumn
        '            .Item(0) = True
        '            .EndEdit()
        '        End With
        '    End If
        'End If
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
            totaldebit += dr.Item("vat_amount")
        Next
        txttotal.DecimalValue = totaldebit
    End Sub
    Private Sub txt_search_TextChange(sender As Object, e As EventArgs) Handles txt_search.TextChange
        Dim q As String = StringReplace(txt_search.Text, "~!@#$%^&*()_+{}:""|<>?=[];'\,./+`", "")
        Dim sql = String.Format("trans_no LIKE '%{0}%'", q)
        bs_output_vat.Filter = sql
        'Dim dt As DataTable = ds.Tables("output_vat")
        'Dim drs = dt.Select(String.Format("trans_no LIKE '%{0}%'", q))
        'If drs.Length > 0 Then
        '    If currentSearchIndex >= drs.Length Then
        '        currentSearchIndex = 0
        '    End If
        '    Dim selectedID As String = drs(currentSearchIndex).Item("trans_no").ToString
        '    dgOffset.ClearSelection()
        '    For Each row As DataGridViewRow In dgOffset.Rows
        '        If row.Cells("trans_no").Value.ToString = selectedID Then
        '            row.Selected = True
        '            Dim tmp_index = dt.Rows.IndexOf(drs(currentSearchIndex))
        '            dgOffset.FirstDisplayedScrollingRowIndex = tmp_index
        '        End If
        '    Next
        'End If
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

    Private Sub cboALl_CheckedChanged(sender As Object, e As EventArgs) Handles cboALl.CheckedChanged
        Dim isInputted As Boolean = cboALl.Checked
        For Each dr As DataGridViewRow In dgOffset.Rows
            dr.Cells("isInputted").Value = isInputted
        Next
        ''Dim dt As DataTable = dgOffset.DataSource
        For Each row As DataGridViewRow In dgOffset.Rows
            Dim drv As DataRowView = row.DataBoundItem
            Dim dr = drv.Row
            If dr.Item("isInputted") Then
                If dr.Item("vat_amount") = 0 Then
                    dr.Item("vat_amount") = dr.Item("tmp_amount")
                    dr.Item("debit") = dr.Item("vat_amount")
                End If
            Else
                dr.Item("vat_amount") = 0.0
                dr.Item("debit") = 0.0
            End If
            'dr.Item("isInputted") = isInputted
            'If isInputted Then
            'Else
            'End If

            dr.Item("debit") = dr.Item("vat_amount")
            dr.Item("debit_based") = dr.Item("vat_amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
            dr.Item("vat_amount_based") = dr.Item("vat_amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
            dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("vat_amount")

            If dr.Item("balance") < 0 Then
                MsgBox("Overpayments Datected.")
                dr.Item("vat_amount") = dr.Item("tmp_amount")
                dr.Item("debit") = dr.Item("vat_amount")
                dr.Item("vat_amount_based") = dr.Item("vat_amount") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                dr.Item("debit_based") = dr.Item("debit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("vat_amount")
            End If
        Next
    End Sub
    Private Sub FilterByDate(dateFrom As DateTime, dateTo As DateTime)
        Dim q = String.Format("trans_date >= #{0}# AND trans_date <= #{1}#", dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"))
        If Not rdo1.Checked Then
            q = String.Format("trans_date <= #{0}#", dateTo.ToString("yyyy-MM-dd"))
        End If
        bs_output_vat.Filter = q
    End Sub

    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo2.CheckedChanged, rdo1.CheckedChanged
        If rdo1.Checked Then
            txt_date_from.Enabled = True
            txt_date_from.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg"))
            txt_date_to.MinDate = txt_date_from.Value
        Else
            txt_date_from.Enabled = False
            txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg"))
            'txt_date_to.MinDate = txt_date_from.Value
            FilterByDate(txt_date_from.Value, txt_date_to.Value)
        End If
    End Sub

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_to.ValueChanged, txt_date_from.ValueChanged
        txt_date_to.MinDate = txt_date_from.Value
        FilterByDate(txt_date_from.Value, txt_date_to.Value)
    End Sub
End Class