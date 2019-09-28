Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Public Class invoiceDetailedParticular
    Dim cls As New classCon
    Public Property MyParent As transactionib = Nothing
    Private MyLogId = main.log_id
    Public Property trans_id As String = ""
    Public Property current_index As Integer = 0

    Private Sub invoiceDetailedParticular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim total As Double
        loadDTToDG(dgView, ds.Tables("trans_project_management_det"))
        Dim dt As DataTable = ds.Tables("trans_project_management_det")
        For Each dr As DataRow In dt.Rows
            Dim contract_amount As Double = dr.Item("contract_amount")
            total += contract_amount
        Next
        lbl_total.Text = Format(total, "#,##0.00")
    End Sub

    Private Sub loader()
        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date
            ,b.project_management_det_id,d.pm_year
            ,d.project_id,e.project_code,e.project_name
            ,d.general_id,f.general_code,f.general_name
            ,c.department_code,c.project_name AS project_name_det
            ,c.contract_amount,c.contract_amount_based
            ,b.billed_amount,b.billed_amount_based
            ,(IFNULL(c.contract_amount,0) + IFNULL(b.billed_amount,0)) - IFNULL(c.billed_amount,0) AS balance_amount
            ,(IFNULL(c.contract_amount_based,0) + IFNULL(b.billed_amount_based,0)) - IFNULL(c.billed_amount_based,0) AS balance_amount_based
            FROM trans_header a
            LEFT JOIN trans_header_project_management b ON b.trans_id = a.trans_id
            LEFT JOIN (
    	        SELECT a.project_management_det_id,a.project_management_id
    	        ,a.department_code,a.project_name
    	        ,a.contract_amount,a.contract_amount_based
    	        ,IFNULL(a.contract_amount,0) - IFNULL(b.billed_amount,0) AS billed_amount
    	        ,IFNULL(a.contract_amount_based,0) - IFNULL(b.billed_amount_based,0) AS billed_amount_based
    	        FROM trans_project_management_det a
    	        LEFT JOIN (
    		        SELECT a.project_management_det_id
    		        ,SUM(a.billed_amount) AS billed_amount
    		        ,SUM(a.billed_amount_based) AS billed_amount_based
    		        FROM trans_header_project_management a
    		        GROUP BY a.project_management_det_id
    	        ) b ON b.project_management_det_id = b.project_management_det_id
            ) c ON c.project_management_det_id = b.project_management_det_id
            LEFT JOIN trans_project_management d ON d.project_management_id = c.project_management_id
            LEFT JOIN {0}.lib_erp_project e ON e.project_id = d.project_id
            LEFT JOIN {0}.lib_erp_general f ON f.general_id = d.general_id
            ", _serverDBFS)
        If trans_id <> "" Then
            sql &= String.Format("WHERE a.trans_id = '{0}'", trans_id)
        End If
        Dim dt As DataTable = Query(sql)
        ds.Tables("trans_project_management_det").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("trans_project_management_det").ImportRow(dr)
        Next
        dgView.DataSource = ds.Tables("trans_project_management_det")
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim frm As New invoiceDetailedParticularDet
        Dim lst As New List(Of String)
        Dim arr_id As String = ""
        For Each dr As DataRow In ds.Tables("trans_project_management_det").Rows
            If Not dr.Item("deleted") Then
                lst.Add(dr.Item("project_management_det_id").ToString)
            End If
        Next
        arr_id = String.Join(",", lst)
        frm.arr_id = arr_id
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            For Each dr As DataRow In frm.drs
                ds.Tables("trans_project_management_det").ImportRow(dr)
            Next
        End If
        loadDTToDG(dgView, ds.Tables("trans_project_management_det"))
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim dtOfdg As DataTable = dgView.DataSource
        Dim dt_name As String = dtOfdg.TableName
        Dim dt As New DataTable
        dt.TableName = dt_name
        dt = dtOfdg.Copy
        Dim arr_id = getCheckedGrid("trans_project_management_id", "project_code", "sel", dgView, "", True)
        If arr_id.Length > 0 Then
            For i As Integer = 0 To arr_id.Length - 1
                Dim dr As DataRow = dt.Select("trans_project_management_id" & " = '" & arr_id(i) & "'")(0)
                transactionib.arr_deleted.Add(arr_id(i))
            Next
            For i As Integer = 0 To arr_id.Length - 1
                Dim dr As DataRow = dt.Select("trans_project_management_id" & " = '" & arr_id(i) & "'")(0)
                dt.Rows.Remove(dr)
            Next
        End If
        ds.Tables(dt_name).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dt_name).ImportRow(row)
        Next
        loadDTToDG(dgView, ds.Tables(dt_name))
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub invoiceDetailedParticular_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MyParent.ds.Tables("project_management").Clear()
        For Each dr As DataRow In ds.Tables("trans_project_management_det").Rows
            MyParent.ds.Tables("project_management").ImportRow(dr)
        Next
    End Sub
    Private Sub dgView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellEndEdit
        Dim order As DataGridView = DirectCast(sender, DataGridView)
        If IsDBNull(order(0, e.RowIndex).Value) Then Exit Sub
        order("balance_amount", e.RowIndex).Value = ifNull(order("contract_amount", e.RowIndex).Value - order("billed_amount", e.RowIndex).Value, 0)
    End Sub

End Class