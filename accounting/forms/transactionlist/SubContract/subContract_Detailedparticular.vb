Imports MySql.Data.MySqlClient
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Public Class subContract_Detailedparticular
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'Dim frm As New subContract_Detailedparticular_det
        'Dim list As New List(Of String)
        'Dim subcon_dt As DataTable = ds.Tables("trans_sub_contract_det")
        'Dim dataId As String = ""

        'For Each subcon_dr As DataRow In subcon_dt.Rows
        '    dataId = subcon_dr.Item("sub_contract_det_id")
        '    list.Add(dataId.ToString)
        'Next
        'Dim arr_id = String.Join(",", list)
        'frm.arr_id = arr_id
        'frm.ShowDialog()
        'If frm.DialogResult = DialogResult.OK Then
        '    For Each dr As DataRow In frm.SelectedRows
        '        ds.Tables("trans_sub_contract_det").ImportRow(dr)
        '    Next
        '    dgView.DataSource = ds.Tables("trans_sub_contract_det")
        'End If
        Dim frm As New subContract_Detailedparticular_det
        Dim lst As New List(Of String)
        Dim arr_id As String = ""
        For Each dr As DataRow In ds.Tables("trans_sub_contract_det").Rows
            If Not dr.Item("deleted") Then
                lst.Add(dr.Item("sub_contract_det_id").ToString)
            End If
        Next
        arr_id = String.Join(",", lst)
        frm.arr_id = arr_id
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            For Each dr As DataRow In frm.SelectedRows
                ds.Tables("trans_sub_contract_det").ImportRow(dr)
            Next
        End If
        loadDTToDG(dgView, ds.Tables("trans_sub_contract_det"))
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim dtOfdg As DataTable = dgView.DataSource
        Dim dt_name As String = dtOfdg.TableName
        Dim dt As New DataTable
        dt.TableName = dt_name
        dt = dtOfdg.Copy
        Dim arr_id = getCheckedGrid("sub_contract_det_id", "subconcode", "sels", dgView, "", True)
        If arr_id.Length > 0 Then
            For i As Integer = 0 To arr_id.Length - 1
                Dim dr As DataRow = dt.Select("sub_contract_det_id" & " = '" & arr_id(i) & "'")(0)
                transactionap.arr_deleted.Add(arr_id(i))
            Next
            For i As Integer = 0 To arr_id.Length - 1
                Dim dr As DataRow = dt.Select("sub_contract_det_id" & " = '" & arr_id(i) & "'")(0)
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
    Private Sub subContract_Detailedparticular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim compute As Decimal = 0.00
        For Each draw As DataRow In ds.Tables("trans_sub_contract_det").Rows
            compute += draw.Item("amount")
        Next
        txt_total.Text = Format(compute, "#,##0.00")
        loadDTToDG(dgView, ds.Tables("trans_sub_contract_det"))
    End Sub
End Class