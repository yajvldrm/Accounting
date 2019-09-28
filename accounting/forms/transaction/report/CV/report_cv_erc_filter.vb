Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class report_cv_erc_filter
    Public MyDT As DataTable
    Public ors_burs As String
    Public fund_cluster As String
    ''Public txt_mfo_pap_code As String
    Public txt_mfo_erc_responsibility As String
    Public mode_of_payment As String
    Public dialog As Integer
    Private transmodedet As String = ""
    Private mode As Integer
    Private transmode As String = ""
    Private _transid As String
    Dim dbTable As String = "trans_mfo_pap"
    Private MyLogID = main.log_id

    'Dim dt_temp As DataTable
    ''Public Property trans_id As String
    Public Property TransactionID As String = ""
    Private Sub report_cv_erc_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Visible = False
        btnNotSave.Visible = False
        txt_mfo_pap_id.Visible = False
        txt_trans_id.Visible = False
        txt_mode_of_payment.Visible = False
        txt_trans_additional_id.Visible = False
        txt_mfo_pap_code.Enabled = False
        txt_mfo_pap_name.Enabled = False
        txt_mfo_responsibility_center.Enabled = False
        dgMFO.Enabled = True
        ''transactioncv.initLoad()

    End Sub

    Public Property transid_add() As String
        Get
            Return _transid
        End Get
        Set(value As String)
            _transid = value
        End Set
    End Property
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbo_fund_cluster_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub report_cv_erc_filter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim dt1 As DataTable = ds.Tables("trans_additional")
        Dim dr1 As DataRow = Nothing
        dr1 = dt1.NewRow
        dr1("trans_additional_id") = "tmp_" & Now.ToString("yyyyMMddHHmmssfff")
        ds.Tables("trans_additional").ImportRow(dr1)
        dt1.Rows.Add(dr1)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
    Public Property transId() As String
        Get
            Return _transid
        End Get
        Set(value As String)
            _transid = value
        End Set
    End Property

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        Dim arrID = getCheckedGrid("mfo_pap_id", "mfo_pap_code", "sel", dgMFO, "", False, , False)
        If arrID.Count > 0 Then
            For Each dr As DataRow In ds.Tables("trans_mfo_pap").Rows
                If arrID.Contains(dr.Item("mfo_pap_id").ToString) Then
                    dr.Item("deleted") = True
                    ds.Tables("trans_mfo_pap").AcceptChanges()
                End If
            Next
            loadDTToDG(dgMFO, ds.Tables("trans_mfo_pap"))
        End If
    End Sub

    Private Sub dgMFO_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        If dgMFO.IsCurrentCellDirty Then
            dgMFO.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Function getRowsCount() As Integer
        Dim ctr As Integer = 0
        For Each row As DataGridViewRow In dgMFO.Rows
            If Not row.Cells("deleted").Value Then
                ctr += 1
            End If
        Next
        Return ctr
    End Function
    Private Function getCurrentRowIndex() As Integer
        Dim index As Integer = -1
        Dim currentRow = dgMFO.CurrentCell.OwningRow
        For Each row As DataGridViewRow In dgMFO.Rows
            If Not row.Cells("deleted").Value Then
                If row.Equals(currentRow) Then
                    index = row.Index
                End If
            End If
        Next
        Return index
    End Function

    Private Sub dgMFO_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        e.Cancel = True
    End Sub

    Private Sub report_cv_erc_filter_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgMFO.AutoGenerateColumns = False
        loadDTToDG(dgMFO, ds.Tables("trans_mfo_pap"))
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgMFO_SelectionChanged(sender As Object, e As EventArgs) Handles dgMFO.SelectionChanged
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMFO, "mfo_pap_id", dt, Me)
    End Sub

    Private Sub txt_mfo_pap_name_Leave(sender As Object, e As EventArgs) Handles txt_mfo_pap_name.Leave
        Dim sql As String = String.Format("SELECT * FROM lib_erp_mfo")
        Dim dt As DataTable = FsQuery(sql)
        Dim q As String = txt_mfo_pap_name.Text.ToString.Replace("'", "''")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("mfo_name like '{0}'", q))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "mfo_code,mfo_name", "140,240")


                    If browse.ShowDialog = DialogResult.OK Then

                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_mfo_pap_name.RowData = dr
                txt_mfo_pap_id.Value = dr("mfo_id").ToString()
                txt_mfo_pap_name.Text = dr("mfo_name")
                txt_mfo_responsibility_center.Text = dr("mfo_code")

            End If
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control(Me)
        enable_control(Me)
    End Sub

    Private Sub btn_edit_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgMFO.SelectedRows.Count > 0 Then
            transmode = "update"
            btnInsert.Visible = False
            btnUpdate.Visible = False
            btnRemove.Visible = False
            btnSave.Visible = True
            btnNotSave.Visible = True

            txt_mfo_pap_name.Enabled = True
            txt_mfo_pap_code.Enabled = True
            txt_mfo_responsibility_center.Enabled = True
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim arr_id = getCheckedGrid("mfo_pap_id", "mfo_pap_name", "sel", dgMFO, "", False)
        Dim dt As DataTable = ds.Tables("trans_mfo_pap")
        Dim newDt As New DataTable("tmp_trans_mfo_pap")
        For Each col As DataColumn In dt.Columns
            Dim newCol As New DataColumn
            newCol.ColumnName = col.ColumnName
            newCol.DataType = col.DataType
            newDt.Columns.Add(newCol)
        Next
        For Each dr As DataRow In dt.Rows
            If arr_id.Contains(dr.Item("mfo_pap_id")) Then
                If Not dr.Item("mfo_pap_id").ToString.Contains("tmp_") Then
                    dr.Item("deleted") = True
                Else
                    dt.Rows.Remove(dr)
                End If
            Else
                If Not dr.Item("deleted") Then
                    newDt.ImportRow(dr)
                End If
            End If
        Next
        For Each dr As DataRow In dt.Rows
            If arr_id.Contains(dr.Item("mfo_pap_id")) Then
                dr.Item("deleted") = True
            End If
        Next
        'dgjbooks.DataSource = newDt
        loadDTToDG(dgMFO, ds.Tables("trans_mfo_pap"))
    End Sub

    Private Sub txt_mfo_pap_name_TextChange(sender As Object, e As EventArgs) Handles txt_mfo_pap_name.TextChange

    End Sub

    Private Sub txt_mfo_pap_code_Leave(sender As Object, e As EventArgs) Handles txt_mfo_pap_code.Leave

        Dim dt_temp As DataTable = New DataTable()
        dt_temp.Clear()
        dt_temp.Columns.Add("code")
        Dim drow As DataRow = dt_temp.NewRow
        If txt_mfo_pap_id.Value = 1 Or txt_mfo_pap_id.Value = 2 Or txt_mfo_pap_id.Value = 3 Or txt_mfo_pap_id.Value = 4 Or txt_mfo_pap_id.Value = 5 Or txt_mfo_pap_id.Value = 6 Or txt_mfo_pap_id.Value = 7 Then
            drow("code") = "100010000"
            dt_temp.Rows.Add(drow)
        ElseIf txt_mfo_pap_id.Value = 8 Then
            drow("code") = "100020000"
            dt_temp.Rows.Add(drow)
            Dim drow2 As DataRow = dt_temp.NewRow
            drow2("code") = "100030000"
            dt_temp.Rows.Add(drow2)
        ElseIf txt_mfo_pap_id.Value = 9 Then
            drow("code") = "100040000"
            dt_temp.Rows.Add(drow)
        ElseIf txt_mfo_pap_id.Value = 10 Then
            drow("code") = "301010001"
            dt_temp.Rows.Add(drow)
            Dim drow2 As DataRow = dt_temp.NewRow
            drow2("code") = "301010002"
            dt_temp.Rows.Add(drow2)
        ElseIf txt_mfo_pap_id.Value = 11 Then
            drow("code") = "301020000"
            dt_temp.Rows.Add(drow)
        ElseIf txt_mfo_pap_id.Value = 12 Or txt_mfo_pap_id.Value = 13 Or txt_mfo_pap_id.Value = 14 Or txt_mfo_pap_id.Value = 15 Then
            drow("code") = "301030000"
            dt_temp.Rows.Add(drow)
        End If

        If dt_temp.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            browse.dt = dt_temp
            browse.format("Code", "code", "320")
            If browse.ShowDialog = DialogResult.OK Then
                If browse.dgview.SelectedRows.Count > 0 Then
                    drow = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                End If
            End If
        End If

        If Not drow Is Nothing Then
            txt_mfo_pap_name.RowData = drow
            txt_mfo_pap_code.Text = drow("code")
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If transmode = "insert" Then
            Dim dt1 As DataTable = ds.Tables("trans_mfo_pap")
            Dim dr1 As DataRow = Nothing
            dr1 = dt1.NewRow
            dr1("mfo_pap_id") = "tmp_" & Now.ToString("yyyyMMddHHmmssfff")
            dr1("trans_id") = TransactionID
            dr1("mfo_pap_name") = txt_mfo_pap_name.Text
            dr1("mfo_pap_code") = txt_mfo_pap_code.Text
            dr1("mfo_responsibility_center") = txt_mfo_responsibility_center.Text
            ds.Tables("trans_mfo_pap").ImportRow(dr1)
            dt1.Rows.Add(dr1)
            loadDTToDG(dgMFO, ds.Tables("trans_mfo_pap"))

            btnInsert.Visible = True
            btnUpdate.Visible = True
            btnRemove.Visible = True
            btnInsert.Enabled = True
            btnUpdate.Enabled = True
            btnRemove.Enabled = True
            btnSave.Visible = False
            btnNotSave.Visible = False

        Else
            Dim dr As DataRow = Nothing
            Dim drow() As DataRow = ds.Tables("trans_mfo_pap").Select(String.Format("mfo_pap_id = {0}", txt_mfo_pap_id.Text))
            dr = drow(0)
            dr("mfo_pap_name") = txt_mfo_pap_name.Text
            dr("mfo_pap_code") = txt_mfo_pap_code.Text
            dr("mfo_responsibility_center") = txt_mfo_responsibility_center.Text
            ''clear_control(False)
            'enable_control(False)
        End If

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control_det()
        transmodedet = ""
    End Sub
    Private Sub disable_control_det()
        transmode = ""
        btnSave.Visible = False
        btnNotSave.Visible = False
        btnInsert.Visible = True
        btnUpdate.Visible = True
        btnRemove.Visible = True
        dgMFO.Enabled = True
        NewControls.clearControl(Panel1)
        NewControls.enableControl(Panel1, False)
        dgMFO.ClearSelection()
        If dgMFO.Rows.Count > 0 Then
            dgMFO.Rows(0).Selected = True
        End If
    End Sub

    Private Sub txt_fund_name_Leave(sender As Object, e As EventArgs) Handles txt_fund_name.Leave
        Dim sql As String = String.Format("SELECT * FROM lib_erp_fund_cluster")
        Dim dt As DataTable = FsQuery(sql)
        Dim q As String = txt_fund_name.Text.ToString.Replace("'", "''")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("fund_name like '{0}'", q))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "fund_code,fund_name", "140,240")


                    If browse.ShowDialog = DialogResult.OK Then

                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_fund_name.RowData = dr
                txt_fund_name.Text = dr("fund_name")
                txt_fund_code.Text = dr("fund_code")

            End If
        End If
    End Sub

    Private Sub rdo_mds_check_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_mds_check.CheckedChanged
        If rdo_mds_check.Checked Then
            txt_mode_of_payment.Text = "MDS Check"
        End If
    End Sub

    Private Sub rdo_commercial_check_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_commercial_check.CheckedChanged
        If rdo_commercial_check.Checked Then
            txt_mode_of_payment.Text = "Commercial Check"
        End If
    End Sub

    Private Sub rdo_ada_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_ada.CheckedChanged
        If rdo_ada.Checked Then
            txt_mode_of_payment.Text = "ADA"
        End If
    End Sub

    Private Sub rdo_others_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_others.CheckedChanged
        If rdo_others.Checked Then
            txt_mode_of_payment.Text = "OTHERS"
        End If
    End Sub
End Class
