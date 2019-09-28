Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class offsetar
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


    Public var_trans_no As String = ""
    'Public var_account_name As String = ""

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
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _jbooks_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _jbooks_id = value
        End Set
    End Property
    Public Property general_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _general_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _general_id = value
        End Set
    End Property
    Public Property book_unit_no_id As String = ""
    Public Property BookID As String = ""

    Public Property trans_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _trans_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _trans_id = value
        End Set
    End Property
    Public Property account_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _account_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _account_id = value
        End Set
    End Property

    Public Property filter_date() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _filter_date
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _filter_date = value
        End Set
    End Property
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        dgOffset.Columns("tmp_amount").DefaultCellStyle.Format = strNumberFormat
        dgOffset.Columns("credit").DefaultCellStyle.Format = strNumberFormat
        dgOffset.Columns("balance").DefaultCellStyle.Format = strNumberFormat
    End Sub
    Private Sub cmdNotSave_Click(sender As Object, e As EventArgs) Handles cmdNotSave.Click
        Me.Hide()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim total As Decimal = CDec(ifNull(txttotal.DecimalValue, 0))
        If total = 0 Then
            MsgBox("No Amount To Save")
            Exit Sub
        End If
        Dim dt As DataTable = ds.Tables("jbooks")
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                'row.Item("jbooks_id") = jbooks_id
                Try
                    If row.Item("isInputted") Then
                        'row.Item("offset_type") = offset_type
                    Else
                        row.Item("deleted") = True
                    End If
                Catch
                    'If row.Item("ref_jbooks_id") = "" Then
                    '    dt.Rows.Remove(row)
                    'Else
                    '    row.Item("deleted") = True
                    'End If
                End Try
            Next
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Public Sub refresh_data()
        Dim sql = ""
        If trans_id.ToString = "0" Then
            trans_id = ""
        End If
        If trans_id = "" Then
            sql = String.Format("SELECT a.jbooks_id AS ref_jbooks_id,'' AS jbooks_id_tmp,'' AS trans_id,IFNULL(m.journal_code,'') AS ref_journal_code " &
                ",a.trans_id,IF(IFNULL(b.ref_no,'') = '',c.trans_no,CONCAT(c.trans_no,' - ',b.ref_no)) AS ref_trans_no,c.trans_date AS ref_trans_date " &
                ",a.project_id,d.project_code,d.project_name " &
                ",a.department_id,e.department_code,e.department_name " &
                ",IFNULL(a.allocation_id,'') AS allocation_id,IFNULL(f.allocation_code,'') AS allocation_code,IFNULL(f.allocation_name,'') AS allocation_name " &
                ",a.account_id,g.account_code,g.account_name,g.validation,g.noCompute,g.unit_applicable " &
                ",a.currency_id,h.currency_code,h.currency_name " &
                ",a.exchange_rate,a.based_rate,a.credit,(a.debit - IF(j.credit IS NULL,0,j.credit)) AS tmp_amount,0 AS credit " &
                ",a.credit_based,0 AS credit_based,a.line_remarks " &
                ",a.general_id,i.general_code,i.general_name " &
                ",IF(a.debit != 0,1,2) as dc " &
                ",k.terms_id,k.jbooks_ar_id AS jbooks_terms_id,k.nodays " &
                ",IF(c.journal_id = '8',k.si_no,n.si_no) AS si_no,IF(c.journal_id = '8',k.dr_no,n.dr_no) AS dr_no,IF(c.journal_id = '8',k.po_no,n.po_no) AS po_no " &
                ",l.terms_code,l.terms_name " &
                ",a.book_unit_no_id,o.book_unit_no_code,o.book_unit_no_name,a.line_remarks AS particulars 
                ,a.project_unit_no_id,p.project_unit_no_codes,p.project_unit_no_names 
                ,c.description " &
                "FROM trans_jbooks a " &
                "LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN trans_header c ON c.trans_id = a.trans_id " &
                "LEFT JOIN {6}.lib_erp_project d ON d.project_id = a.project_id " &
                "LEFT JOIN {6}.lib_erp_department e ON e.department_id = a.department_id " &
                "LEFT JOIN {6}.lib_erp_allocation f ON f.allocation_id = a.allocation_id " &
                "LEFT JOIN {6}.lib_erp_chart g ON g.account_id = a.account_id " &
                "LEFT JOIN {6}.lib_erp_currency h ON h.currency_id = a.currency_id " &
                "LEFT JOIN {6}.lib_erp_general i ON i.general_id = a.general_id " &
                "LEFT JOIN (SELECT a.ref_jbooks_id AS jbooks_id,SUM(a.credit) AS credit FROM trans_jbooks a LEFT JOIN trans_header b ON b.trans_id = a.trans_id GROUP BY ref_jbooks_id) j ON j.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {7}.trans_jbooks_ar k ON k.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {6}.lib_erp_terms l ON l.terms_id = k.terms_id " &
                "LEFT JOIN {6}.lib_erp_journal m ON m.journal_id = c.journal_id " &
                "LEFT JOIN {7}.trans_header_ib n ON n.trans_id = c.trans_id " &
                "LEFT JOIN {6}.lib_erp_book_unit_no o ON o.book_unit_no_id = a.book_unit_no_id " &
                "LEFT JOIN {6}.lib_erp_project_unit_no p ON p.project_unit_no_id = a.project_unit_no_id " &
                "WHERE a.account_id = {0} " &
                "AND c.trans_date <= '{1}' " &
                "AND a.general_id = '{2}' " &
                "AND a.currency_id = '{3}' " &
                "AND a.project_id {4} " &
                "AND a.department_id {5} " &
                "AND IFNULL(a.book_unit_no_id,'') = '{9}' " &
                "AND a.ref_jbooks_id IS NULL AND (a.debit - IF(j.credit IS NULL,0,j.credit)) <> 0 " &
                "", account_id, filter_date, general_id, currency_id, If(project_id = "", " IS NULL ", " = " & project_id), If(department_id = "", " IS NULL ", " = " & department_id), _serverDBFS, _serverDBMain, If(BookID = "", "IS NULL", "= " & BookID), book_unit_no_id)
        Else
            sql = String.Format("SELECT a.jbooks_id AS ref_jbooks_id,'' AS jbooks_id_tmp,IFNULL(m.journal_code,'') AS ref_journal_code " &
                ",a.trans_id,IF(IFNULL(b.ref_no,'') = '',c.trans_no,CONCAT(c.trans_no,' - ',b.ref_no)) AS ref_trans_no,c.trans_date AS ref_trans_date " &
                ",a.project_id,d.project_code,d.project_name " &
                ",a.department_id,e.department_code,e.department_name " &
                ",IFNULL(a.allocation_id,'') AS allocation_id,IFNULL(f.allocation_code,'') AS allocation_code,IFNULL(f.allocation_name,'') AS allocation_name " &
                ",a.account_id,g.account_code,g.account_name,g.validation,g.noCompute,g.unit_applicable " &
                ",a.currency_id,h.currency_code,h.currency_name " &
                ",a.exchange_rate,a.based_rate,a.credit,(a.debit - IF(j.credit IS NULL,0,j.credit)) AS tmp_amount,0 AS credit " &
                ",a.credit_based,0 AS credit_based,a.line_remarks " &
                ",a.general_id,i.general_code,i.general_name " &
                ",IF(a.debit != 0,1,2) as dc " &
                ",k.terms_id,k.jbooks_ar_id AS jbooks_terms_id,k.nodays " &
                ",IF(c.journal_id = '8',k.si_no,n.si_no) AS si_no,IF(c.journal_id = '8',k.dr_no,n.dr_no) AS dr_no,IF(c.journal_id = '8',k.po_no,n.po_no) AS po_no " &
                ",l.terms_code,l.terms_name " &
                ",a.book_unit_no_id,o.book_unit_no_code,o.book_unit_no_name,a.line_remarks AS particulars
                ,a.project_unit_no_id,p.project_unit_no_codes,p.project_unit_no_names 
                ,c.description " &
                "FROM trans_jbooks a " &
                "LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN trans_header c ON c.trans_id = a.trans_id " &
                "LEFT JOIN {7}.lib_erp_project d ON d.project_id = a.project_id " &
                "LEFT JOIN {7}.lib_erp_department e ON e.department_id = a.department_id " &
                "LEFT JOIN {7}.lib_erp_allocation f ON f.allocation_id = a.allocation_id " &
                "LEFT JOIN {7}.lib_erp_chart g ON g.account_id = a.account_id " &
                "LEFT JOIN {7}.lib_erp_currency h ON h.currency_id = a.currency_id " &
                "LEFT JOIN {7}.lib_erp_general i ON i.general_id = a.general_id " &
                "LEFT JOIN (SELECT a.ref_jbooks_id AS jbooks_id,SUM(a.credit) AS credit FROM trans_jbooks a LEFT JOIN trans_header b ON b.trans_id = a.trans_id WHERE a.trans_id <> {2} GROUP BY a.ref_jbooks_id) j ON j.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {8}.trans_jbooks_ar k ON k.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {7}.lib_erp_terms l ON l.terms_id = k.terms_id " &
                "LEFT JOIN {7}.lib_erp_journal m ON m.journal_id = c.journal_id " &
                "LEFT JOIN {8}.trans_header_ib n ON n.trans_id = c.trans_id " &
                "LEFT JOIN {7}.lib_erp_book_unit_no o ON o.book_unit_no_id = a.book_unit_no_id " &
                "LEFT JOIN {7}.lib_erp_project_unit_no p ON p.project_unit_no_id = a.project_unit_no_id " &
                "WHERE a.account_id = {0} " &
                "AND c.trans_date <= '{1}' " &
                "AND a.trans_id <> {2} " &
                "AND a.general_id = {3} " &
                "AND a.currency_id = {4} " &
                "AND a.project_id {5} " &
                "AND a.department_id {6} " &
                "AND IFNULL(a.book_unit_no_id,'') = '{10}' " &
                "AND a.ref_jbooks_id IS NULL AND (a.debit - IF(j.credit IS NULL,0,j.credit)) <> 0 ", account_id, filter_date, trans_id, general_id, currency_id, If(project_id = "", " IS NULL ", " = " & project_id), If(department_id = "", " IS NULL ", " = " & department_id), _serverDBFS, _serverDBMain, If(BookID = "", "IS NULL", "= " & BookID), book_unit_no_id)
        End If
        Dim _data As DataTable = Query(sql)
        Dim _dt = _data.Clone
        _dt.Clear()
        _dt.Columns("ref_jbooks_id").DataType = Type.GetType("System.String")
        For Each dr As DataRow In _data.Rows
            _dt.ImportRow(dr)
        Next
        ds.Tables("jbooks").Clear()
        For Each row As DataRow In _dt.Rows
            row.Item("jbooks_id_tmp") = jbooks_id & row.Item("ref_jbooks_id")
            If trans_id <> "" Then
                row.Item("trans_id") = trans_id
            End If
            ds.Tables("jbooks").ImportRow(row)
        Next
    End Sub
    Private Sub offsetjbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgOffset.AutoGenerateColumns = False
        'dgOffset.DataSource = ds.Tables("jbooks")
        txtDateFrom.Value = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString())
        txtjbooksid.Text = jbooks_id
        particulars.Visible = CBool(ifNull(main.Sys_Default.Rows(0).Item("line_remarks"), 0))
    End Sub

    Private Sub dgOffset_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgOffset.CellValueChanged
        If dgOffset.DataSource Is Nothing Then
            Exit Sub
        End If
        Dim i As Integer = e.RowIndex
        Dim drv As DataRowView = bs_jbooks.Current
        If drv IsNot Nothing Then
            Dim dr As DataRow = drv.Row
            If dr.Item("isInputted") Then
                If dr.Item("credit") = 0 Then
                    dr.Item("credit") = dr.Item("tmp_amount")
                End If
            Else
                dr.Item("credit") = 0.0
            End If

            dr.Item("credit_based") = dr.Item("credit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
            dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("credit")

            If dr.Item("balance") < 0 Then
                MsgBox("Overpayments Datected.")
                dr.Item("credit") = dr.Item("tmp_amount")
                dr.Item("credit_based") = dr.Item("credit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("credit")
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
        'If dgOffset.CurrentCell.Then Then

        'End If
        'If dgOffset.CurrentCell.ColumnIndex = 8 Then
        '    If dgOffset.IsCurrentCellDirty Then
        '        dgOffset.CommitEdit(DataGridViewDataErrorContexts.Commit)
        '    End If
        'End If
        'If dgOffset.CurrentCell Is DataGridViewCheckBoxCell Then
        'End If
        'dgOffset.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub dgOffset_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgOffset.DataBindingComplete
        Dim totaldebit As Decimal = 0
        For Each row As DataGridViewRow In dgOffset.Rows
            Dim drv As DataRowView = row.DataBoundItem
            Dim dr = drv.Row
            totaldebit += dr.Item("credit")
        Next
        txttotal.DecimalValue = totaldebit
    End Sub

    Private Sub txt_search_TextChange(sender As Object, e As EventArgs) Handles txt_search.TextChange
        FilterByDate()
        'Dim q As String = StringReplace(txt_search.Text, "~!@#$%^&*()_+{}:""|<>?=[];'\,./+`", "")
        'Dim dt As DataTable = dgOffset.DataSource
        'Dim drs = dt.Select(String.Format("ref_trans_no LIKE '%{0}%'", q))
        'If drs.Length > 0 Then
        '    If currentSearchIndex >= drs.Length Then
        '        currentSearchIndex = 0
        '    End If
        '    Dim selectedID As String = drs(currentSearchIndex).Item("ref_trans_no").ToString
        '    dgOffset.ClearSelection()
        '    For Each row As DataGridViewRow In dgOffset.Rows
        '        If row.Cells("ref_trans_no").Value.ToString = selectedID Then
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

    Private Sub cboAll_CheckedChanged(sender As Object, e As EventArgs) Handles cboAll.CheckedChanged
        Dim isInputted As Boolean = cboAll.Checked
        ''Dim dt As DataTable = dgOffset.DataSource
        For Each row As DataGridViewRow In dgOffset.Rows
            Dim drv As DataRowView = row.DataBoundItem
            Dim dr = drv.Row
            dr.Item("isInputted") = isInputted
            If isInputted Then
                If dr.Item("credit") = 0 Then
                    dr.Item("credit") = dr.Item("tmp_amount")
                End If
            Else
                dr.Item("credit") = 0.0
            End If

            dr.Item("credit_based") = dr.Item("credit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
            dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("credit")

            If dr.Item("balance") < 0 Then
                MsgBox("Overpayments Datected.")
                dr.Item("credit") = dr.Item("tmp_amount")
                dr.Item("credit_based") = dr.Item("credit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
                dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("credit")
            End If
        Next
    End Sub
    Private Sub FilterByDate()
        Dim dateFrom = txtDateFrom.Value
        Dim dateTo = txtDateTo.Value
        Dim search As String = StringReplace(txt_search.Text, "~!@#$%^&*()_+{}:""|<>?=[];'\,./+`", "")
        Dim q = String.Format("ref_trans_date <= '{1}' AND ref_trans_date >= '{0}' AND ref_trans_no LIKE '%{2}%'", dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"), search)
        bs_jbooks.Filter = q
    End Sub

    Private Sub txtDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles txtDateFrom.ValueChanged
        txtDateTo.MinDate = txtDateFrom.Value
        FilterByDate()
    End Sub

    Private Sub txtDateTo_ValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.ValueChanged
        FilterByDate()
    End Sub

    Private Sub dgOffset_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgOffset.CellEndEdit
        dgOffset_CellValueChanged(sender, e)

    End Sub

    Private Sub dgOffset_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOffset.CellContentClick

        Dim cel As DataGridView = DirectCast(sender, DataGridView)
        Dim colName As String = dgOffset.CurrentCell.OwningColumn.Name.ToString
        If colName = "showProjectManagement" Then
            var_trans_no = cel("ref_trans_no", e.RowIndex).Value.ToString()
            ' var_account_name = cel("general_name_col", e.RowIndex).Value.ToString()
            Dim lst As New List(Of String)
            Dim lstOffset As New List(Of String)
            For Each dr As DataRow In ds.Tables("project_management_offset").Rows
                Dim id As String = ifNull(dr("offset_project_management_id"), "").ToString()
                If id <> "" And Not lstOffset.Contains(id) Then
                    lstOffset.Add(id)
                End If
            Next
            Dim trans_id As String = ""
            trans_id = cel("col_trans_id", e.RowIndex).Value.ToString
            jbooks_id = String.Join(",", lst)
            Dim PMOR As New project_management_OR
            PMOR.TransID = trans_id
            PMOR.OffsetID = String.Join(",", lstOffset)
            PMOR.MyParent = Me
            PMOR.ShowDialog()
            If PMOR.DialogResult = DialogResult.OK Then
                'ds.Tables("project_management_offset").Clear()
                For Each dr As DataRow In PMOR.ds.Tables("trans_project_management_det").Rows
                    Dim drs = ds.Tables("project_management_offset").Select(String.Format("trans_project_management_id = '{0}'", dr("trans_project_management_id")))
                    If drs.Length > 0 Then
                        drs(0)("sel") = dr("sel")
                        drs(0)("amount_collected") = dr("amount_collected")
                        drs(0)("amount_collected_based") = dr("amount_collected_based")
                        drs(0)("currency_id") = dr("currency_id")
                        drs(0)("exchange_rate") = dr("exchange_rate")
                        drs(0)("based_rate") = dr("based_rate")
                        If CBool(ifNull(dr("sel"), 0)) Then
                            drs(0)("deleted") = False
                        Else
                            drs(0)("deleted") = True
                        End If
                    Else
                        ds.Tables("project_management_offset").ImportRow(dr)
                    End If
                Next
            End If
            'loadDTToDG(project_management_OR.dgView, ds.Tables("trans_project_management_det"))

            'project_management_OR.ShowDialog()


            'Dim frm As New project_management_OR()
            'frm.ds.Tables("trans_project_management_det").Clear()

            'project_management_OR.ShowDialog()
        End If
    End Sub


End Class