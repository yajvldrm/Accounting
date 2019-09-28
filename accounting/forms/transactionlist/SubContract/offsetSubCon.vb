Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms

Public Class offsetSubCon
    Public Property MyParent As offsetap = Nothing
    Public Property TransID As String = ""
    Public Property OffsetID As String = ""
    Private Sub loader()
        Dim trans_where = ""
        Dim offset_where = ""
        If TransID <> "" Then
            trans_where = String.Format("AND a.trans_id NOT IN ({0})", TransID)
        End If
        If OffsetID <> "" Then
            offset_where = String.Format("WHERE a.offset_sub_contract_id NOT IN ({0})", OffsetID)
        End If
        Dim sql As String = String.Format("SELECT a.trans_sub_contract_id,a.trans_id,a.sub_contract_det_id,a.billed_amount,a.billed_amount_based
            ,a.currency_id,f.currency_code,f.currency_name,a.exchange_rate,a.based_rate
            ,b.subconid,e.subconcode,e.subconname,b.cons1,b.cons2,b.amount,b.amount_based,b.po_no
            ,b.trans_date
            ,0 AS amount_collected,0 AS amount_collected_based
            ,c.sc_year,d.project_code,d.project_name,b.description
            ,IFNULL(a.billed_amount,0) - IFNULL(sc_offset.amount_collected,0) AS variance
            ,IFNULL(a.billed_amount_based,0) - IFNULL(sc_offset.amount_collected_based,0) AS variance_based
            FROM trans_header_sub_contract a
            LEFT JOIN trans_sub_contract_det b ON b.sub_contract_det_id = a.sub_contract_det_id
            LEFT JOIN trans_sub_contract c ON c.sub_contract_id = b.sub_contract_id
            LEFT JOIN {0}.lib_erp_project d ON d.project_id = c.project_id
            LEFT JOIN {0}.lib_subcon e ON e.subConid = b.subconid
            LEFT JOIN {0}.lib_erp_currency f ON f.currency_id = a.currency_id
            LEFT JOIN (
	            SELECT a.trans_sub_contract_id
	            ,SUM(a.amount_collected) AS amount_collected
	            ,SUM(a.amount_collected_based) AS amount_collected_based
	            FROM trans_sub_contract_offset a
                {2}
	            GROUP BY a.trans_sub_contract_id
            ) sc_offset ON sc_offset.trans_sub_contract_id = a.trans_sub_contract_id
            WHERE IFNULL(a.billed_amount,0) - IFNULL(sc_offset.amount_collected,0) <> 0 {1}", _serverDBFS, trans_where, offset_where)
        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_sub_contract_offset").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_sub_contract_offset").ImportRow(dr)
        Next
        If MyParent IsNot Nothing Then
            Dim dtParent As DataTable = MyParent.ds.Tables("trans_sub_contract_offset")
            For Each dr As DataRow In dtParent.Rows
                Dim id As String = dr("trans_sub_contract_id").ToString
                Dim drs = ds.Tables("trans_sub_contract_offset").Select(String.Format("trans_sub_contract_id = '{0}'", id))
                If drs.Length > 0 Then
                    drs(0)("sel") = dr("sel")
                    drs(0)("deleted") = dr("deleted")
                    drs(0)("amount_collected") = dr("amount_collected")
                    drs(0)("variance") = drs(0)("variance") - dr("amount_collected")
                End If
            Next
        End If
        dgView.AutoGenerateColumns = False
        dgView.DataSource = ds.Tables("trans_sub_contract_offset")
    End Sub

    Private Sub offsetSubCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub dgView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellValueChanged
        If ds.Tables("trans_sub_contract_det") IsNot Nothing Then
            If dgView.DataSource Is Nothing Then
                Exit Sub
            End If
            If dgView.Rows.Count > 0 And dgView.SelectedRows IsNot Nothing Then
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
                ' |-- The index of boolean DataColumn
                .EndEdit()
            End With
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class