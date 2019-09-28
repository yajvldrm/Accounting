Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms

Public Class approvalsetup
    Public transmode As String = ""
    Public transmodedet As String = ""
    Private _modules_id As String = ""
    Private module_code As String = "ACC00912"
    Public Property modules_id() As String
        Get
            Return _modules_id
        End Get
        Set(value As String)
            _modules_id = value
        End Set
    End Property

    Private Sub disableMainControl()
        btnAdd.Visible = main.dicAction.Item(module_code)("m_add")
        btnAdd.Enabled = main.dicAction.Item(module_code)("m_add")
        btnEdit.Visible = main.dicAction.Item(module_code)("m_edit")
        btnEdit.Enabled = main.dicAction.Item(module_code)("m_edit")
        btnDelete.Visible = main.dicAction.Item(module_code)("m_delete")
        btnDelete.Enabled = main.dicAction.Item(module_code)("m_delete")
        btnSave.Visible = False
        btnNotSave.Visible = False
        btnSave.Enabled = False
        btnNotSave.Enabled = False
        dgMain.Enabled = True
        txt_stage_id.Enabled = False
        'txt_stage_name.Enabled = False
        txt_main_approval_order.Enabled = False
        txt_main_order_no.Enabled = False
        txtsearch.Enabled = True

        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnOK.Enabled = False
        btnCancel.Enabled = False
        btnInsert.Visible = True
        btnUpdate.Visible = True
        btnRemove.Visible = True
        btnOK.Visible = False
        btnCancel.Visible = False
        dgSub.Enabled = False
        txt_approval_user_id.Enabled = False
        txt_user_id.Enabled = False
        'txt_user_fullname.Enabled = False
        txt_approval_order.Enabled = False
        txt_order_no.Enabled = False
    End Sub
    Private Sub enableMainControl()
        btnAdd.Visible = False
        btnEdit.Visible = False
        btnDelete.Visible = False
        btnSave.Visible = True
        btnNotSave.Visible = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnNotSave.Enabled = True
        dgMain.Enabled = False
        txt_stage_id.Enabled = True
        'txt_stage_name.Enabled = True
        txt_main_approval_order.Enabled = True
        txt_main_order_no.Enabled = True
        txtsearch.Enabled = False
        disableSubControl()
    End Sub
    Private Sub clearMainControl()
        txt_approval_id.Text = ""
        txt_stage_id.Text = ""
        txt_stage_id.Value = ""
        txt_stage_name.Text = ""
        setRdoValue(txt_main_approval_order, "0")
        txt_main_order_no.DecimalValue = 0
        ds.Tables("sys_erp_approval_user").Rows.Clear()
        clearSubControl()
    End Sub
    Private Sub disableSubControl()
        btnInsert.Visible = True
        btnUpdate.Visible = True
        btnRemove.Visible = True
        btnOK.Visible = False
        btnCancel.Visible = False
        btnInsert.Enabled = True
        btnUpdate.Enabled = True
        btnRemove.Enabled = True
        btnOK.Enabled = False
        btnCancel.Enabled = False
        dgSub.Enabled = True
        txt_approval_user_id.Enabled = False
        txt_user_id.Enabled = False
        'txt_user_fullname.Enabled = False
        txt_approval_order.Enabled = False
        txt_order_no.Enabled = False
    End Sub
    Private Sub enableSubControl()
        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnOK.Enabled = True
        btnCancel.Enabled = True
        btnInsert.Visible = False
        btnUpdate.Visible = False
        btnRemove.Visible = False
        btnOK.Visible = True
        btnCancel.Visible = True
        dgSub.Enabled = False
        txt_approval_user_id.Enabled = True
        txt_user_id.Enabled = True
        'txt_user_fullname.Enabled = True
        txt_approval_order.Enabled = True
        txt_order_no.Enabled = False
        If getRdoValue(txt_main_order_no) = "1" Then
            txt_order_no.Enabled = True
        End If
    End Sub
    Private Sub clearSubControl()
        txt_approval_user_id.Value = ""
        txt_approval_user_id.Text = ""
        txt_user_id.Text = ""
        txt_user_fullname.Text = ""
        setRdoValue(txt_approval_order, "0")
        txt_order_no.DecimalValue = 0
    End Sub
    Private Sub refresh_record()
        Dim tblmain As String = "sys_erp_approval"
        Dim sql As String = String.Format("SELECT a.approval_id,a.module_id,a.stage_id,a.approval_order,a.order_no " & _
                ",b.stage_code,b.stage_name,b.label " & _
            "FROM {0} a " & _
            "LEFT JOIN sys_erp_stage b ON b.stage_id = a.stage_id " & _
            "WHERE a.module_id = {1} " & _
            "", tblmain, If(modules_id <> "", modules_id, 0))
        ds.Tables(tblmain).Rows.Clear()
        Dim dt As DataTable = FsQuery(sql)
        For Each row As DataRow In dt.Rows
            Dim newdr As DataRow = ds.Tables(tblmain).NewRow
            For Each col As DataColumn In dt.Columns
                If ds.Tables(tblmain).Columns.Contains(col.ColumnName) Then
                    newdr.Item(col.ColumnName) = row.Item(col.ColumnName)
                End If
            Next
            ds.Tables(tblmain).Rows.Add(newdr)
        Next
    End Sub
    Private Sub refresh_record_det()
        Dim tbldet As String = "sys_erp_approval_user"
        Dim sql As String = String.Format("SELECT a.approval_user_id,a.approval_id,a.user_id,a.approval_order,a.order_no " & _
            ",b.username,b.user_fullname " & _
            "FROM {0} a " & _
            "LEFT JOIN sys_erp_user b ON b.user_id = a.user_id " & _
            "WHERE a.approval_id = {1} " & _
            "", tbldet, txt_approval_id.Text)
        ds.Tables(tbldet).Rows.Clear()
        Dim dt As DataTable = FsQuery(sql)
        For Each row As DataRow In dt.Rows
            Dim newdr As DataRow = ds.Tables(tbldet).NewRow
            For Each col As DataColumn In dt.Columns
                If ds.Tables(tbldet).Columns.Contains(col.ColumnName) Then
                    newdr.Item(col.ColumnName) = row.Item(col.ColumnName)
                End If
            Next
            ds.Tables(tbldet).Rows.Add(newdr)
        Next
    End Sub

    Private Sub approvalsetup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        showForm(listofmodules, main)
    End Sub
    Private Sub approvalsetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgMain.AutoGenerateColumns = False
        dgSub.AutoGenerateColumns = False
        dgMain.DataSource = ds.Tables("sys_erp_approval")
        dgSub.DataSource = ds.Tables("sys_erp_approval_user")
        refresh_record()
        disableMainControl()
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        If dgMain.Rows.Count > 0 Then
            Dim idname As String = "approval_id"
            Dim colname As String = ""
            Dim id As String = ""
            Dim dt As DataTable = ds.Tables("sys_erp_approval")
            For Each col As DataGridViewColumn In dgMain.Columns
                If col.DataPropertyName = idname Then
                    colname = col.Name
                    Exit For
                End If
            Next
            If colname <> "" Then
                If dgMain.Rows.Count > 0 Then
                    If dgMain.Columns.Contains(idname) Then
                        If dgMain.SelectedRows.Count > 0 Then
                            Dim selectedDGVRow = dgMain.SelectedRows(0)
                            id = selectedDGVRow.Cells(colname).Value.ToString
                        End If
                    End If
                End If
            End If
            If id <> "" Then
                Dim selectedRows() As DataRow = dt.Select(String.Format("{0} = '{1}'", idname, id))
                If selectedRows.Count > 0 Then
                    Dim selectedRow = selectedRows(0)
                    txt_approval_id.Text = selectedRow.Item("approval_id")
                    txt_stage_id.Text = selectedRow.Item("stage_code")
                    txt_stage_id.Value = selectedRow.Item("stage_id")
                    txt_stage_name.Text = selectedRow.Item("stage_name")
                    setRdoValue(txt_main_approval_order, If(selectedRow.Item("approval_order"), 1, 0))
                    txt_main_order_no.DecimalValue = selectedRow.Item("order_no")
                    refresh_record_det()
                End If
            End If
        End If
    End Sub

    Private Sub dgSub_SelectionChanged(sender As Object, e As EventArgs) Handles dgSub.SelectionChanged
        Dim idname As String = "approval_user_id"
        Dim colname As String = ""
        Dim id As String = ""
        Dim dt As DataTable = ds.Tables("sys_erp_approval_user")
        For Each col As DataGridViewColumn In dgSub.Columns
            If col.DataPropertyName = idname Then
                colname = col.Name
                Exit For
            End If
        Next
        If colname <> "" Then
            If dgSub.Rows.Count > 0 Then
                If dgSub.SelectedRows.Count > 0 Then
                    Dim selectedDGVRow = dgSub.SelectedRows(0)
                    id = selectedDGVRow.Cells(colname).Value.ToString
                End If
            End If
        End If
        If id <> "" Then
            Dim selectedRows() As DataRow = dt.Select(String.Format("{0} = '{1}'", idname, id))
            If selectedRows.Count > 0 Then
                Dim selectedRow = selectedRows(0)
                txt_approval_user_id.Text = selectedRow.Item("approval_user_id")
                txt_user_id.Text = selectedRow.Item("username")
                txt_user_id.Value = selectedRow.Item("user_id")
                txt_user_fullname.Text = selectedRow.Item("user_fullname")
                setRdoValue(txt_approval_order, If(selectedRow.Item("approval_order"), 1, 0))
                txt_order_no.DecimalValue = selectedRow.Item("order_no")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim tblmain As String = "sys_erp_approval"
        Dim tblsub As String = "sys_erp_approval_user"
        Dim dic As New Dictionary(Of String, String)
        dic.Add("approval_id", txt_approval_id.Text)
        dic.Add("module_id", modules_id)
        dic.Add("stage_id", txt_stage_id.Value)
        dic.Add("approval_order", getRdoValue(txt_main_approval_order))
        dic.Add("order_no", txt_main_order_no.DecimalValue)
        Dim parent_sql As String = ""
        If dic.Item("approval_id").ToString = "" Then
            parent_sql = genInsert(tblmain, dic) & ";"
        Else
            parent_sql = genUpdate(tblmain, dic) & ";"
        End If
        Dim flag As Boolean = False
        parent_sql &= "SELECT approval_id AS id FROM sys_erp_approval WHERE "
        For Each d In dic
            If d.Key <> "approval_id" Then
                parent_sql &= If(flag, " AND ", "") & String.Format(" {0} = '{1}' ", d.Key.ToString, d.Value.ToString)
                flag = True
            End If
        Next
        Dim parent_dt As DataTable = FsQuery(parent_sql)
        If parent_dt.Rows.Count > 0 Then
            Dim parent_id As String = parent_dt.Rows(0).Item("id")
            If ds.Tables(tblsub).Rows.Count Then
                For Each row As DataRow In ds.Tables(tblsub).Rows
                    Dim child_dic As New Dictionary(Of String, String)
                    child_dic.Add("approval_user_id", row.Item("approval_user_id"))
                    child_dic.Add("approval_id", parent_id)
                    child_dic.Add("user_id", row.Item("user_id"))
                    child_dic.Add("approval_order", If(row.Item("approval_order"), 1, 0))
                    child_dic.Add("order_no", row.Item("order_no"))
                    child_dic.Add("deleted", row.Item("deleted"))
                    Dim child_sql As String = ""
                    If child_dic.Item("approval_user_id").ToString.Contains("tmp_") Then
                        If child_dic.Item("deleted").ToString = "False" Or child_dic.Item("deleted").ToString = "0" Then
                            child_dic.Remove("deleted")
                            child_sql &= genInsert(tblsub, child_dic) & ";"
                        End If
                    Else
                        If child_dic.Item("deleted").ToString = "False" Or child_dic.Item("deleted").ToString = "0" Then
                            child_dic.Remove("deleted")
                            child_sql &= genUpdate(tblsub, child_dic) & ";"
                        Else
                            child_sql &= String.Format("DELETE FROM sys_erp_approval_user WHERE approval_user_id = {0}; ", child_dic.Item("approval_user_id"))
                        End If
                    End If
                    If child_sql <> "" Then
                        FsQuery(child_sql)
                    End If
                Next
                refresh_record()
                disableMainControl()
                If transmode = "add" Then
                    saveAddAnother(btnAdd, "Add New Approval?")
                End If
                transmode = ""
                transmodedet = ""
            End If
        End If
    End Sub
    Private Sub txt_user_id_Leave(sender As Object, e As EventArgs) Handles txt_user_id.Leave

        Dim dt As DataTable = FsQuery("select * from sys_erp_user")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("username like '{0}'", txt_user_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Username,Fullname", "username,user_fullname", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_user_id.RowData = dr
                txt_user_id.Value = dr("user_id")
                txt_user_id.Text = dr("username")
                txt_user_fullname.Text = dr("user_fullname")
            End If
        End If

    End Sub
    Private Sub txt_stage_id_Leave(sender As Object, e As EventArgs) Handles txt_stage_id.Leave

        Dim dt As DataTable = FsQuery("select * from sys_erp_stage")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("stage_code like '{0}'", txt_stage_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "stage_code,stage_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_stage_id.RowData = dr
                txt_stage_id.Value = dr("stage_id")
                txt_stage_id.Text = dr("stage_code")
                txt_stage_name.Text = dr("stage_name")
            End If
        End If

    End Sub
    Private Function getLastOrderNo(ByVal dg As DataGridView, ByVal colName As String) As String
        Dim last_no As Integer = 0
        Dim dt As DataTable = dg.DataSource
        If dt.Columns.Contains(colName) Then
            dt.Select("", colName)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    If row.Item(colName) >= last_no Then
                        last_no = row.Item(colName)
                    End If
                Next
            End If
        End If
        Return (last_no + 1).ToString
    End Function
    Private Sub Rdo_main_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button2.CheckedChanged, Rdo_button1.CheckedChanged
        'If transmode <> "" Then
        '    Dim approval_order As String = getRdoValue(txt_main_approval_order)
        '    txt_main_order_no.DecimalValue = 0
        '    txt_main_order_no.Enabled = False
        '    If approval_order = "1" Then
        '        txt_main_order_no.DecimalValue = getLastOrderNo(dgMain, "order_no")
        '        txt_main_order_no.Enabled = True
        '    End If
        'End If
        setRdoValue(txt_approval_order, getRdoValue(txt_main_approval_order))
    End Sub

    Private Sub Rdo_sub_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_button4.CheckedChanged, Rdo_button3.CheckedChanged
        If transmodedet <> "" Then
            Dim approval_order As String = getRdoValue(txt_approval_order)
            txt_order_no.DecimalValue = 0
            txt_order_no.Enabled = False
            If approval_order = "1" Then
                txt_order_no.DecimalValue = getLastOrderNo(dgSub, "order_no")
                txt_order_no.Enabled = True
            End If
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        transmode = "add"
        txt_main_order_no.DecimalValue = getLastOrderNo(dgMain, "order_no")
        txt_main_order_no.Enabled = True
        clearMainControl()
        enableMainControl()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgMain.Rows.Count > 0 And dgMain.SelectedRows.Count > 0 Then
            transmode = "edit"
            enableMainControl()
        Else
            MsgBox("No Record Selected")
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        transmode = ""
        disableMainControl()
        clearMainControl()
        If dgMain.Rows.Count > 0 Then
            If dgMain.SelectedRows.Count > 0 Then
                Dim selectedRows = dgMain.SelectedRows
                If selectedRows.Count > 0 Then
                    selectedRows(0).Cells(0).Selected = False
                    selectedRows(0).Cells(0).Selected = True
                End If
            End If
        End If
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmodedet = "add"
        clearSubControl()
        enableSubControl()
        txt_approval_user_id.Text = "tmp_" & Now.ToString("MMddyyyyHHmmss")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgSub.Rows.Count > 0 And dgSub.SelectedRows.Count > 0 Then
            transmodedet = "edit"
            enableSubControl()
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dt As DataTable = dgSub.DataSource
        Dim newdr As DataRow = dt.NewRow
        newdr.Item("approval_user_id") = txt_approval_user_id.Text
        newdr.Item("approval_id") = txt_approval_id.Text
        newdr.Item("user_id") = txt_user_id.Value
        newdr.Item("username") = txt_user_id.Text
        newdr.Item("user_fullname") = txt_user_fullname.Text
        newdr.Item("approval_order") = If(getRdoValue(txt_approval_order) = "1", True, False)
        newdr.Item("order_no") = txt_order_no.DecimalValue
        If transmodedet = "add" Then
            dt.Rows.Add(newdr)
        Else
            Dim selectedDrs = dt.Select(String.Format("approval_user_id = '{0}'", txt_approval_user_id.Text))
            If selectedDrs.Count > 0 Then
                For Each col As DataColumn In dt.Columns
                    selectedDrs(0).Item(col.ColumnName) = newdr.Item(col.ColumnName)
                Next
            Else
                dt.Rows.Add(newdr)
            End If
        End If
        transmodedet = ""
        disableSubControl()
        btnInsert.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        transmodedet = ""
        clearSubControl()
        disableSubControl()
        If dgSub.Rows.Count > 0 Then
            Dim selectedRows = dgSub.SelectedRows
            If selectedRows.Count > 0 Then
                selectedRows(0).Cells(0).Selected = False
                selectedRows(0).Cells(0).Selected = True
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim pk As String = "approval_id"
        Dim colName As String = "stage_name"
        Dim sel As String = "sel"
        Dim dg As DataGridView = dgMain
        Dim delMsg As String = "Are you sure to delete this record(s)?"
        'for delete query
        Dim db_delete As String = _serverDBFS
        Dim tbl_delete As String = "sys_erp_approval"
        Dim pk_delete As String = "approval_id"

        Dim msg As String = ""
        Dim ctr As Integer = 0
        Dim name As String = ""
        Dim str As String = ""

        Dim arr_id = getCheckedGrid(pk, colName, sel, dg, delMsg)
        If arr_id.Length > 0 Then
            For i As Integer = 0 To arr_id.Length - 1
                str &= String.Format("DELETE FROM {0}.{1} WHERE {2} = {3};", db_delete, tbl_delete, pk_delete, arr_id(i))
            Next
            Query(str)
            refresh_record()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim dr = ds.Tables("sys_erp_approval_user").Select("sel1 = 'True'")
        If dr.Count > 0 Then
            Dim a = MsgBox("Are you sure to delete this items?", MsgBoxStyle.YesNo, "Delete")
            If a = MsgBoxResult.Yes Then
                For Each row As DataRow In dr
                    row.Item("deleted") = Not row.Item("deleted")
                Next
            End If
        Else
            MsgBox("No Records Selected.")
        End If

        For Each _dr As DataGridViewRow In dgSub.Rows
            For Each cell As DataGridViewCell In _dr.Cells
                If _dr.Cells("deleted").Value Then
                    cell.Style.BackColor = Drawing.Color.Red
                Else
                    cell.Style.BackColor = Drawing.Color.White
                End If
            Next
        Next
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnInsert)
        dicShortCut.Add(114, btnUpdate)
        dicShortCut.Add(115, btnRemove)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub
End Class