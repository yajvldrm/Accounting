Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Public Class invoiceDetailedParticularDet
    Dim cls As New classCon
    Public Property drs As New List(Of DataRow)
    Public Property MyParent As invoiceDetailedParticular = Nothing
    Public Property arr_id As String = ""
    Private MyLogId = main.log_id
    Public Property current_index As Integer = 0
    Public Shared Property arr_general_id As String

    Private Sub loader()
        Dim sql As String = String.Format("SELECT a.project_management_id,b.project_management_det_id
            ,a.pm_year
            ,a.project_id,c.project_code,c.project_name
            ,a.general_id,d.general_code,d.general_name
            ,b.department_code,b.project_name AS project_name_det
            ,IFNULL(b.contract_amount,0) - IFNULL(e.billed_amount,0) AS contract_amount
            ,IFNULL(b.contract_amount_based,0) - IFNULL(e.billed_amount_based,0) AS contract_amount_based
            ,0 AS billed_amount,0 AS billed_amount_based
            ,IFNULL(b.contract_amount,0) - IFNULL(e.billed_amount,0) AS balance_amount
            ,IFNULL(b.contract_amount_based,0) - IFNULL(e.billed_amount_based,0) AS balance_amount_based
            ,b.currency_id,b.exchange_rate,b.based_rate
            FROM trans_project_management a
            LEFT JOIN trans_project_management_det b ON b.project_management_id = a.project_management_id
            LEFT JOIN {0}.lib_erp_project c ON c.project_id = a.project_id
            LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id
            LEFT JOIN (
	            SELECT a.project_management_det_id
	            ,SUM(a.billed_amount) AS billed_amount
	            ,SUM(a.billed_amount_based) AS billed_amount_based
	            FROM trans_header_project_management a
	            GROUP BY a.project_management_det_id
            ) e ON e.project_management_det_id = b.project_management_det_id
            WHERE IFNULL(b.project_management_det_id,'') <> '' And a.general_id={1}
        ", _serverDBFS, ifNull(arr_general_id, 0))

        If arr_id <> "" Then
            sql &= String.Format("AND b.project_management_det_id NOT IN ({0})", arr_id)
        End If
        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_project_management_det").Clear()

        For Each dr As DataRow In dt.Rows

            ds.Tables("trans_project_management_det").ImportRow(dr)

        Next
        dgView.AutoGenerateColumns = False
        dgView.DataSource = ds.Tables("trans_project_management_det")
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'toggleInsert(dgView, "project_management_det_id", "project_management_det_id", "sel", ds)
        For Each dr As DataRow In ds.Tables("trans_project_management_det").Rows
            If dr.Item("sel") Then
                drs.Add(dr)
            End If
        Next
        Me.DialogResult = DialogResult.OK
    End Sub
    Public Shared Sub toggleInsert(ByVal dg As DataGridView, ByVal pk As String, ByVal name As String, ByVal sel As String, ByVal ds As DataSet, Optional deleted As String = "deleted")

        Dim dtOfdg As DataTable = dg.DataSource
        Dim dt_name As String = dtOfdg.TableName

        Dim dt As New DataTable
        dt.TableName = dt_name
        dt = dtOfdg.Copy

        Dim arr_id = getCheckedGrid(pk, name, sel, dg, "", False)
        If arr_id.Length > 0 Then
            For i As Integer = 0 To arr_id.Length - 1
                Dim dr As DataRow = dt.Select(pk & " = '" & arr_id(i) & "'")(0)
                dr.Item("deleted") = False
                'dr.Item(deleted) = Not dr.Item(deleted)
            Next
        End If
        ds.Tables(dt_name).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dt_name).ImportRow(row)
        Next
        'dg.DataSource = ds.Tables(dt_name)
        loadDTToDG(dg, ds.Tables(dt_name))
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Public Shared Sub loadDTToDG(ByRef dg As DataGridView, ByVal dt As DataTable)
        dg.AutoGenerateColumns = False
        dg.DataSource = dt
        Dim delCol As String = ""
        For Each col As DataGridViewColumn In dg.Columns
            If col.DataPropertyName = "deleted" Then
                delCol = col.Name
            End If
        Next
        For Each row As DataGridViewRow In dg.Rows
            If row.Cells(delCol).Value Then
                dg.CurrentCell = Nothing
                row.Visible = False
                dg.Rows(row.Index).Visible = False
            End If
        Next
    End Sub

    Private Sub dgView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellValueChanged
        'Dim i As Integer = e.RowIndex
        'With DirectCast(dgView.Rows(i).DataBoundItem, DataRowView).Row
        '    '     |-- The index of boolean DataColumn
        '    .Item(0) = True
        '    .EndEdit()
        'End With
    End Sub

    Private Sub dgView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellClick
        'Try
        '    Dim i As Integer = e.RowIndex
        '    With DirectCast(dgView.Rows(i).DataBoundItem, DataRowView).Row
        '        '     |-- The index of boolean DataColumn
        '        .Item(0) = True
        '        .EndEdit()

        '    End With
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try


    End Sub

    Private Sub dgView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellEndEdit
        Try
            Dim order As DataGridView = DirectCast(sender, DataGridView)
            If IsDBNull(order(0, e.RowIndex).Value) Then Exit Sub
            order("balance_amount", e.RowIndex).Value = order("contract_amount", e.RowIndex).Value - order("billed_amount", e.RowIndex).Value

        Catch ex As Exception

        End Try

    End Sub

    Private Sub invoiceDetailedParticularDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub dgView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub
End Class