Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms

Public Class subContract_Detailedparticular_det
    Public Property drs As New List(Of DataRow)
    Public Property SelectedRows As List(Of DataRow) = Nothing
    Public Property arr_id As String = ""
    Public Property asa As DataTable
    Public Property frms As subContract_Detailedparticular
    Public Property MyParents_source As subContract_Detailedparticular = Nothing
    Public Shared Property subConTrans_ID As Integer
    'Public Property MyData As New DataTable
    Private Sub InitializeData()
        Dim sql_SubCon_particular As String = String.Format("
            SELECT a.sub_contract_id,a.sc_year,a.project_id,c.project_code,c.project_name
            ,b.sub_contract_det_id,b.subconid,d.subconcode,d.subconname
            ,b.general_id,e.general_code,e.general_name
            ,b.trans_date,b.description,b.amount,b.amount_based,b.currency_id,f.currency_code,f.currency_name
            ,b.exchange_rate,b.based_rate,b.po_no,0 AS billed_amount,0 AS billed_amount_based,b.cons1,b.cons2
            ,b.department_id,g.department_code,g.department_name
            ,sc_offset.amount_collected AS paid_amount
            ,sc_offset.amount_collected_based AS paid_amount_based
            FROM trans_sub_contract a
            LEFT JOIN trans_sub_contract_det b ON b.sub_contract_id = a.sub_contract_id
            LEFT JOIN {1}.lib_erp_project c ON c.project_id = a.project_id
            LEFT JOIN {1}.lib_subcon d ON d.subConid = b.subconid
            LEFT JOIN {1}.lib_erp_general e ON e.general_id = b.general_id
            LEFT JOIN {1}.lib_erp_currency f ON f.currency_id = b.currency_id
            LEFT JOIN {1}.lib_erp_department g ON g.department_id = b.department_id
            LEFT JOIN (
	            SELECT b.sub_contract_det_id,SUM(a.amount_collected) AS amount_collected,SUM(a.amount_collected_based) AS amount_collected_based
	            FROM trans_sub_contract_offset a
	            LEFT JOIN trans_header_sub_contract b ON b.trans_sub_contract_id = a.trans_sub_contract_id
	            GROUP BY b.sub_contract_det_id
            ) sc_offset ON sc_offset.sub_contract_det_id = b.sub_contract_det_id
            WHERE IFNULL(b.sub_contract_det_id,'') <> ''
        ", _serverDBMain, _serverDBFS)
        If arr_id <> "" Then
            sql_SubCon_particular &= String.Format(" and b.sub_contract_det_id NOT IN({0})", arr_id)
        End If
        Dim dt As DataTable = Query(sql_SubCon_particular)
        ds.Tables("trans_sub_contract_det").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_sub_contract_det").ImportRow(dr)
        Next
        bs.DataSource = ds.Tables("trans_sub_contract_det")
    End Sub
    Private Sub subContract_Detailedparticular_det_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeData()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SelectedRows = New List(Of DataRow)
        For Each dr As DataRow In ds.Tables("trans_sub_contract_det").Rows
            If CBool(ifNull(dr("sel"), 0)) Then
                SelectedRows.Add(dr)
            End If
        Next

        Me.DialogResult = DialogResult.OK
        'Try
        '    'variable_tables = subContract_Detailedparticular.dsssss.Tables("trans_sub_contract_det")
        '    'Dim dt As DataTable = ds.Tables("trans_sub_contract_det")
        '    'Dim dt = ds.Tables("trans_sub_contract_det").Select("sel=true")
        '    'If dt.Length >= 0 Then
        '    '    For Each dr As DataRow In ds.Tables("trans_sub_contract_det").Select(String.Format("sel=true"))
        '    '        variable_tables.ImportRow(dr)
        '    '    Next
        '    '    ds.Tables("trans_sub_contract_det").Rows.Clear()
        '    '    asa = variable_tables
        '    'End If
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'Finally
        '    Me.DialogResult = DialogResult.OK
        'End Try
    End Sub
    Private Sub DsfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DsfToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub

    Private Sub dgView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub
End Class