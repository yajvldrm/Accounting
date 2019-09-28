Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Public Class project_management_OR
    Public Property MyParent As offsetar = Nothing
    Public Property TransID As String = ""
    Public Property OffsetID As String = ""
    Private Sub dgView_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellContentClick
    End Sub

    Private Sub project_management_OR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
        dgView.DataSource = ds.Tables("trans_project_management_det")
    End Sub
    Private Sub loader()
        Dim trans_where = ""
        Dim offset_where = ""
        If TransID <> "" Then
            trans_where = String.Format("AND a.trans_id NOT IN ({0})", TransID)
        End If
        If OffsetID <> "" Then
            offset_where = String.Format("WHERE a.offset_project_management_id NOT IN ({0})", OffsetID)
        End If
        Dim sql As String = String.Format("SELECT a.trans_project_management_id,a.trans_id,a.project_management_det_id,a.currency_id,a.exchange_rate,a.based_rate
            ,a.billed_amount,a.billed_amount_based
            ,c.pm_year,c.general_id,c.project_id,d.project_code,d.project_name,e.general_code,e.general_name
            ,b.project_name AS project_description
            ,0 AS amount_collected
            ,0 AS amount_collected_based
            ,IFNULL(pm_offset.amount_collected,0) AS tmp_amount_collected
            ,IFNULL(pm_offset.amount_collected_based,0) AS tmp_amount_collected_based
            ,(a.billed_amount - IFNULL(pm_offset.amount_collected,0)) AS variance
            ,(a.billed_amount_based - IFNULL(pm_offset.amount_collected_based,0)) AS variance_based
            FROM trans_header_project_management a
            LEFT JOIN trans_project_management_det b ON b.project_management_det_id = a.project_management_det_id
            LEFT JOIN trans_project_management c ON c.project_management_id = b.project_management_id
            LEFT JOIN {0}.lib_erp_project d ON d.project_id = c.project_id
            LEFT JOIN {0}.lib_erp_general e ON e.general_id = c.general_id
            LEFT JOIN (
	            SELECT a.trans_project_management_id,a.jbooks_id
                ,SUM(a.amount_collected) AS amount_collected
                ,SUM(a.amount_collected_based) AS amount_collected_based
	            FROM trans_project_management_offset a
                {2}
                GROUP BY a.trans_project_management_id
            ) pm_offset ON pm_offset.trans_project_management_id = a.trans_project_management_id
            WHERE IFNULL(a.billed_amount,0) - IFNULL(pm_offset.amount_collected,0) <> 0 {1}", _serverDBFS, trans_where, offset_where)
        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_project_management_det").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_project_management_det").ImportRow(dr)
        Next
        If MyParent IsNot Nothing Then
            Dim dtParent As DataTable = MyParent.ds.Tables("project_management_offset")
            For Each dr As DataRow In dtParent.Rows
                Dim id As String = dr("trans_project_management_id").ToString
                Dim drs = ds.Tables("trans_project_management_det").Select(String.Format("trans_project_management_id = '{0}'", id))
                If drs.Length > 0 Then
                    drs(0)("sel") = dr("sel")
                    drs(0)("deleted") = dr("deleted")
                    drs(0)("amount_collected") = dr("amount_collected")
                    drs(0)("variance") = drs(0)("variance") - dr("amount_collected")
                End If
            Next
        End If
        dgView.AutoGenerateColumns = False
        dgView.DataSource = ds.Tables("trans_project_management_det")
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub dgView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellEndEdit
        dgView_CellValueChanged(sender, e)
    End Sub

    Private Sub dgView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellValueChanged
        If dgView.DataSource Is Nothing Then
            Exit Sub
        End If
        If dgView.SelectedRows IsNot Nothing Then
            Dim drv As DataRowView = dgView.SelectedRows(0).DataBoundItem
            If drv IsNot Nothing Then
                Dim dr As DataRow = drv.Row
                If CBool(ifNull(dr("sel"), 0)) Then
                    If dr("billed_amount") Then
                        If dr("amount_collected") = 0 Then
                            dr("amount_collected") = dr("variance")
                        End If
                    Else
                        dr("amount_collected") = 0
                    End If
                Else
                    dr("amount_collected") = 0
                End If
                dr("variance") = dr("billed_amount") - dr("tmp_amount_collected") - dr("amount_collected")
                If dr("amount_collected") = 0 Then
                    dr("variance") = dr("billed_amount") - dr("tmp_amount_collected")
                End If
                If dr("variance") < 0 Then
                    MsgBox("Overpayment Detected")
                    dr("amount_collected") = dr("billed_amount")
                    dr("variance") = 0
                End If
            End If
        End If
        With DirectCast(dgView.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            '     |-- The index of boolean DataColumn
            .EndEdit()
        End With
        'Dim i As Integer = e.RowIndex

        'Dim drv As DataRowView = bs_jbooks.Current
        'If drv IsNot Nothing Then
        '    Dim dr As DataRow = drv.Row
        '    If dr.Item("isInputted") Then
        '        If dr.Item("credit") = 0 Then
        '            dr.Item("credit") = dr.Item("tmp_amount")
        '        End If
        '    Else
        '        dr.Item("credit") = 0.0
        '    End If

        '    dr.Item("credit_based") = dr.Item("credit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
        '    dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("credit")

        '    If dr.Item("balance") < 0 Then
        '        MsgBox("Overpayments Datected.")
        '        dr.Item("credit") = dr.Item("tmp_amount")
        '        dr.Item("credit_based") = dr.Item("credit") * (dr.Item("exchange_rate") / dr.Item("based_rate"))
        '        dr.Item("balance") = dr.Item("tmp_amount") - dr.Item("credit")
        '    End If
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
End Class