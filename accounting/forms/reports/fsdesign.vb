Imports user_control
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class fsdesign
    Public Property FS_Type As Integer = 0
    Private FormShown As Boolean = False
    Private MyData As DataTable = Nothing
    Private currentDr As DataRow = Nothing
    Private fs_filter As New new_fs_filter
    'Private fs_filter As New fsdesign_filter
    Private Sub LoadTemplate()
        Dim sql As String = String.Format("SELECT a.template_id,a.template_code,a.template_name " &
            ",a.title1,a.title2,a.title3 " &
            "FROM sys_fs_template a " &
            "WHERE a.fs_type = '{0}' " &
            "", FS_Type)
        MyData = FsQuery(sql)
        fsdesign_view.MyData = MyData
        fsdesign_view.LoadData()
    End Sub
    Private Sub LoadTemplateDet(ByVal id As String)
        Dim sql As String = String.Format("SELECT a.template_det_id,a.template_id " &
            ",a.command_code,a.row_type,a.account_id,a.chart_group_id,a.display_text " &
            ",a.column_num,a.group_var,a.add_sub,a.repeat_num,a.show_zero,a.indent_num,a.order_by " &
            ",IF(row_type = '0',b.account_code,IF(IFNULL(row_type,1) = '1',c.chart_group_code,d.allocation_code)) AS chart_code " &
            ",IF(row_type = '0',b.account_name,IF(IFNULL(row_type,1) = '1',c.chart_group_name,d.allocation_name)) AS chart_name " &
            ",IF(a.row_type = '0','Chart of Account',IF(IFNULL(a.row_type,1) = '1','Chart Group','Allocation')) AS row_type_name " &
            ",a.computation " &
            "FROM sys_fs_template_det a " &
            "LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id " &
            "LEFT JOIN {0}.lib_acc_chart_group c ON c.chart_group_id = a.chart_group_id " &
            "LEFT JOIN {0}.lib_erp_allocation d ON d.allocation_id = a.allocation_id " &
            "WHERE a.template_id = '{1}' " &
            "ORDER BY a.order_by ASC " &
            "", _serverDBFS, id)
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables("dtdet").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("dtdet").ImportRow(row)
        Next
        dgMain.DataSource = ds.Tables("dtdet")
        initGrid(dgMain)
    End Sub
    Private Sub BindControl(ByVal row As DataRow)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MyTextBox Then
                Dim txt = CType(ctrl, MyTextBox)
                If txt.TextSource <> "" Then
                    If row.Table.Columns.Contains(txt.TextSource) Then
                        txt.Text = row.Item(txt.TextSource).ToString
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub EnableControl(Optional Enable As Boolean = True)
        btnAdd.Visible = Not Enable
        btnEdit.Visible = Not Enable
        btnDelete.Visible = Not Enable
        btnSaveAs.Visible = Not Enable
        btnView.Visible = Not Enable
        btnPrint.Visible = Not Enable
        btnPrevious.Visible = Not Enable
        btnNext.Visible = Not Enable
        btnReport.Visible = Not Enable
        btnSave.Visible = Enable
        btnCancel.Visible = Enable
        btnInsert.Visible = Enable
        btnRemove.Visible = Enable
        btnUp.Visible = Enable
        btnDown.Visible = Enable

        txt_template_id.Enabled = Enable
        txt_template_code.Enabled = Enable
        txt_template_name.Enabled = Enable
        txt_title_1.Enabled = Enable
        txt_title_2.Enabled = Enable
        txt_title_3.Enabled = Enable
        dgMain.ReadOnly = Not Enable
    End Sub
    Private Sub ClearControl()
        txt_template_id.Text = ""
        txt_template_code.Text = ""
        txt_template_name.Text = ""
        txt_title_1.Text = ""
        txt_title_2.Text = ""
        txt_title_3.Text = ""
        If dgMain.DataSource IsNot Nothing Then
            dgMain.DataSource = Nothing
        End If
        If dgMain.Rows.Count > 0 Then
            dgMain.Rows.Clear()
        End If
    End Sub
    Private Sub RowMove(Optional Up As Boolean = True)
        If dgMain.DataSource IsNot Nothing Then
            Dim currentDt As DataTable = dgMain.DataSource
            If dgMain.Rows.Count > 0 Then
                Dim selectedCells = dgMain.SelectedCells
                If selectedCells.Count > 0 Then
                    Dim selectedCell = selectedCells(0)
                    Dim selectedRow = selectedCell.OwningRow
                    Dim currentOrder = selectedRow.Cells("order_by").Value
                    Dim currentID = selectedRow.Cells("template_det_id").Value
                    If Up Then
                        If currentOrder > 0 Then
                            currentOrder -= 1
                            For Each dr As DataRow In currentDt.Rows
                                If dr.Item("order_by") = currentOrder Then
                                    dr.Item("order_by") = currentOrder + 1
                                End If
                            Next
                            Dim selectedDRs = currentDt.Select(String.Format("template_det_id = '{0}'", currentID))
                            If selectedDRs.Count > 0 Then
                                Dim selectedDr = selectedDRs(0)
                                selectedDr.Item("order_by") = currentOrder
                            End If
                            'currentDt.AcceptChanges()
                            currentDt.DefaultView.Sort = "order_by ASC"
                            dgMain.DataSource = currentDt
                            initGrid(dgMain)
                        End If
                    Else
                        If currentOrder < currentDt.Rows.Count - 1 Then
                            currentOrder += 1
                            For Each dr As DataRow In currentDt.Rows
                                If dr.Item("order_by") = currentOrder Then
                                    dr.Item("order_by") = currentOrder - 1
                                End If
                            Next
                            Dim selectedDRs = currentDt.Select(String.Format("template_det_id = '{0}'", currentID))
                            If selectedDRs.Count > 0 Then
                                Dim selectedDr = selectedDRs(0)
                                selectedDr.Item("order_by") = currentOrder
                            End If
                            'currentDt.AcceptChanges()
                            currentDt.DefaultView.Sort = "order_by ASC"
                            dgMain.DataSource = currentDt
                            initGrid(dgMain)
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ClearControl()
        EnableControl()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableControl()
    End Sub
    Private Sub fsdesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FS_Type = 1 Then
            Me.Text = "Balance Sheet"
        Else
            Me.Text = "Income Statement"
        End If
        dgMain.AutoGenerateColumns = False
        LoadTemplate()
        ClearControl()
        If MyData.Rows.Count > 0 Then
            currentDr = MyData.Rows(MyData.Rows.Count - 1)
            BindControl(currentDr)
            LoadTemplateDet(txt_template_id.Text)
        End If
        EnableControl(False)
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim lastIndex = -1
        Dim currentID = ""
        If dgMain.DataSource IsNot Nothing Then
            Dim currentDT As DataTable = dgMain.DataSource
            Dim newDr = currentDT.NewRow
            Dim newID = "tmp_" & Now.ToString("yyyyMMddHHmmss") & dgMain.Rows.Count
            If dgMain.Rows.Count > 0 Then
                Dim selectedCells = dgMain.SelectedCells
                If selectedCells.Count > 0 Then
                    Dim selectedCell = selectedCells(0)
                    Dim selectedRow = selectedCell.OwningRow
                    lastIndex = selectedRow.Cells("order_by").Value + 1
                    currentID = selectedRow.Cells("template_det_id").Value.ToString

                    Dim drs = currentDT.Select(String.Format("template_det_id = '{0}'", currentID))
                    Dim currentIndex = -1
                    If drs.Count > 0 Then
                        Dim dr = drs(0)
                        currentIndex = currentDT.Rows.IndexOf(dr)
                    End If

                    newDr.Item("template_det_id") = newID
                    newDr.Item("template_id") = txt_template_id.Text
                    newDr.Item("column_num") = 1
                    newDr.Item("add_sub") = False
                    newDr.Item("repeat_num") = 0
                    newDr.Item("show_zero") = True
                    newDr.Item("indent_num") = 0
                    newDr.Item("order_by") = lastIndex
                    newDr.Item("deleted") = False
                    'newDr.Item("")
                    currentDT.Rows.InsertAt(newDr, currentIndex + 1)
                    Dim found As Boolean = False
                    For Each row As DataRow In currentDT.Rows
                        If found Then
                            lastIndex += 1
                            row.Item("order_by") = lastIndex
                        End If
                        If row.Item("template_det_id").ToString = newID Then
                            found = True
                        End If
                    Next
                    dgMain.DataSource = currentDT
                    initGrid(dgMain)
                Else
                    For Each row As DataRow In currentDT.Rows
                        lastIndex = row.Item("order_by")
                    Next
                    lastIndex += 1
                    newDr.Item("template_det_id") = newID
                    newDr.Item("template_id") = txt_template_id.Text
                    newDr.Item("column_num") = 1
                    newDr.Item("add_sub") = False
                    newDr.Item("repeat_num") = 0
                    newDr.Item("show_zero") = True
                    newDr.Item("indent_num") = 0
                    newDr.Item("order_by") = lastIndex
                    newDr.Item("deleted") = False
                    currentDT.Rows.Add(newDr)
                    dgMain.DataSource = currentDT
                    initGrid(dgMain)
                End If
            Else
                lastIndex = 0
                newDr.Item("template_det_id") = newID
                newDr.Item("template_id") = txt_template_id.Text
                newDr.Item("column_num") = 1
                newDr.Item("add_sub") = False
                newDr.Item("repeat_num") = 0
                newDr.Item("show_zero") = True
                newDr.Item("indent_num") = 0
                newDr.Item("order_by") = lastIndex
                newDr.Item("deleted") = False
                currentDT.Rows.Add(newDr)
                dgMain.DataSource = currentDT
                initGrid(dgMain)
            End If
        Else
            Dim newDt As New DataTable("dt")
            newDt.Columns.Add(CreateDataColumn("template_det_id", "System.String", "template_det_id"))
            newDt.Columns.Add(CreateDataColumn("template_id", "System.String", "template_id"))
            newDt.Columns.Add(CreateDataColumn("command_code", "System.String", "command_code"))
            newDt.Columns.Add(CreateDataColumn("row_type", "System.Int32", "row_type"))
            newDt.Columns.Add(CreateDataColumn("row_type_name", "System.String", "row_type_name"))
            newDt.Columns.Add(CreateDataColumn("account_id", "System.String", "account_id"))
            newDt.Columns.Add(CreateDataColumn("chart_group_id", "System.String", "chart_group_id"))
            newDt.Columns.Add(CreateDataColumn("display_text", "System.String", "display_text"))
            newDt.Columns.Add(CreateDataColumn("column_num", "System.Int32", "column_num"))
            newDt.Columns.Add(CreateDataColumn("group_var", "System.String", "group_var"))
            newDt.Columns.Add(CreateDataColumn("add_sub", "System.Boolean", "add_sub"))
            newDt.Columns.Add(CreateDataColumn("repeat_num", "System.Int32", "repeat_num"))
            newDt.Columns.Add(CreateDataColumn("show_zero", "System.Boolean", "show_zero"))
            newDt.Columns.Add(CreateDataColumn("indent_num", "System.Int32", "indent_num"))
            newDt.Columns.Add(CreateDataColumn("order_by", "System.Int32", "order_by"))
            newDt.Columns.Add(CreateDataColumn("chart_code", "System.String", "chart_code"))
            newDt.Columns.Add(CreateDataColumn("chart_name", "System.String", "chart_name"))
            newDt.Columns.Add(CreateDataColumn("deleted", "System.Boolean", "deleted"))

            Dim newDr = newDt.NewRow
            Dim newID = "tmp_" & Now.ToString("yyyyMMddHHmmss") & lastIndex

            lastIndex = 0
            newDr.Item("template_det_id") = newID
            newDr.Item("template_id") = txt_template_id.Text
            newDr.Item("column_num") = 1
            newDr.Item("add_sub") = False
            newDr.Item("repeat_num") = 0
            newDr.Item("show_zero") = True
            newDr.Item("indent_num") = 0
            newDr.Item("order_by") = lastIndex
            newDr.Item("deleted") = False
            newDt.Rows.Add(newDr)
            dgMain.DataSource = newDt
            initGrid(dgMain)
        End If
    End Sub
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        RowMove(True)
    End Sub
    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        RowMove(False)
    End Sub
    Private Sub dgMain_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellValueChanged
        If FormShown Then
            If dgMain.DataSource IsNot Nothing Then
                If dgMain.Rows.Count > 0 Then
                    Dim c = e.ColumnIndex
                    Dim r = e.RowIndex
                    Dim columnName = dgMain.Columns(c).Name
                    Dim str = ifNull(dgMain.Rows(r).Cells(c).Value, "").ToString
                    If columnName = "command_code" Then
                        Dim returnDR As DataRow = Nothing
                        BrowseCommand(str, returnDR)
                        If returnDR IsNot Nothing Then
                            dgMain.Rows(r).Cells("command_code").Value = returnDR.Item("command_code").ToString
                        End If
                    ElseIf columnName = "row_type_name" Then
                        Dim returnDR As DataRow = Nothing
                        BrowseType(str, returnDR)
                        If returnDR IsNot Nothing Then
                            dgMain.Rows(r).Cells("row_type_name").Value = returnDR.Item("row_type_name").ToString
                            dgMain.Rows(r).Cells("row_type").Value = returnDR.Item("row_type").ToString
                        End If
                    ElseIf columnName = "chart_code" Then
                        Dim _row_type = dgMain.Rows(r).Cells("row_type").Value.ToString
                        Dim returnDR As DataRow = Nothing
                        BrowseChart(str, _row_type, returnDR)
                        If returnDR IsNot Nothing Then
                            dgMain.Rows(r).Cells("account_id").Value = ""
                            dgMain.Rows(r).Cells("chart_group_id").Value = ""
                            If _row_type = "0" Then
                                dgMain.Rows(r).Cells("account_id").Value = returnDR.Item("account_id").ToString
                                dgMain.Rows(r).Cells("chart_code").Value = returnDR.Item("account_code").ToString
                                dgMain.Rows(r).Cells("chart_name").Value = returnDR.Item("account_name").ToString
                            ElseIf _row_type = "1" Then
                                dgMain.Rows(r).Cells("chart_group_id").Value = returnDR.Item("chart_group_id").ToString
                                dgMain.Rows(r).Cells("chart_code").Value = returnDR.Item("chart_group_code").ToString
                                dgMain.Rows(r).Cells("chart_name").Value = returnDR.Item("chart_group_name").ToString
                            Else
                                dgMain.Rows(r).Cells("allocation_id").Value = returnDR.Item("allocation_id").ToString
                                dgMain.Rows(r).Cells("chart_code").Value = returnDR.Item("allocation_code").ToString
                                dgMain.Rows(r).Cells("chart_name").Value = returnDR.Item("allocation_name").ToString
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub CreateTextBrowse(ByVal sql As String,
                                 ByVal q As String,
                                 ByVal label As String,
                                 ByVal field As String,
                                 ByVal width As String,
                                 ByRef returnDr As DataRow)

        q = q.Replace("'", "''")
        Dim fields = field.Split(",")
        Dim strQ As String = ""
        For Each f In fields
            strQ &= String.Format(" OR {0} = '{1}' ", f, q)
        Next
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(strQ.Substring(4))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format(label, field, width)
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                returnDr = dr
            End If
        End If
    End Sub
    Private Sub BrowseCommand(ByVal str As String, ByRef drVar As DataRow)
        Dim sql As String = String.Format("SELECT 'B' AS command_code,'Bold face' AS command_name " &
            "UNION SELECT 'BI','Bold italic' " &
            "UNION SELECT 'BU','Bold underline' " &
            "UNION SELECT 'D','Prints double line' " &
            "UNION SELECT 'G','Prints Grand Total format' " &
            "UNION SELECT 'H','Hides printing or computation' " &
            "UNION SELECT 'I','Italic' " &
            "UNION SELECT 'IN','Insert before' " &
            "UNION SELECT 'L','Single line' " &
            "UNION SELECT 'N','Normal text' " &
            "UNION SELECT 'P','Print accounts, group computations or display text' " &
            "UNION SELECT 'S','Skips one or more lines' " &
            "UNION SELECT 'T','Prints total or sub-total format' " &
            "UNION SELECT 'U','Underline' " &
            "")

        Dim label As String = "Command,Description"
        Dim field As String = "command_code,command_name"
        Dim width As String = "50,200"
        CreateTextBrowse(sql, str, label, field, width, drVar)
    End Sub
    Private Sub BrowseType(ByVal str As String, ByRef drVar As DataRow)
        Dim sql As String = String.Format("SELECT '0' AS row_type,'Chart of Account' AS row_type_name " &
            "UNION SELECT '1','Chart Group' " &
            "UNION SELECT '2','Allocation' " &
            "")

        Dim label As String = "Type,Name"
        Dim field As String = "row_type,row_type_name"
        Dim width As String = "50,200"
        CreateTextBrowse(sql, str, label, field, width, drVar)
    End Sub
    Private Sub BrowseChart(ByVal str As String, ByVal row_type As String, ByRef drVar As DataRow)
        If row_type = "0" Then
            Dim sql As String = String.Format("SELECT a.account_id,a.account_code,a.account_name " &
            "FROM lib_erp_chart a " &
            "")
            'If FS_Type = 2 Then
            '    sql &= String.Format("LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " &
            '                         "WHERE IFNULL(b.chart_type,'') IN ('I','E','A')")
            'End If

            Dim label As String = "Code,Name"
            Dim field As String = "account_code,account_name"
            Dim width As String = "100,200"
            CreateTextBrowse(sql, str, label, field, width, drVar)
        ElseIf row_type = "1" Then
            Dim sql As String = String.Format("SELECT a.chart_group_id,a.chart_group_code,a.chart_group_name " &
            "FROM lib_acc_chart_group a " &
            "")

            'If FS_Type = 2 Then
            '    sql &= String.Format("LEFT JOIN lib_erp_chart_group b ON b.group_id = a.chart_group_id " &
            '                         "LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
            '                         "LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
            '                         "WHERE IFNULL(d.chart_type,'') IN ('I','E','A') " &
            '                         "GROUP BY a.chart_group_id ")
            'End If

            Dim label As String = "Code,Name"
            Dim field As String = "chart_group_code,chart_group_name"
            Dim width As String = "100,200"
            CreateTextBrowse(sql, str, label, field, width, drVar)
        Else
            Dim sql As String = String.Format("SELECT a.allocation_id,a.allocation_code,a.allocation_name " &
            "FROM lib_erp_allocation a " &
            "")

            Dim label As String = "Code,Name"
            Dim field As String = "allocation_code,allocation_name"
            Dim width As String = "100,200"
            CreateTextBrowse(sql, str, label, field, width, drVar)
        End If
    End Sub
    Private Sub fsdesign_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FormShown = True
    End Sub
    Private Sub dgMain_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgMain.CellFormatting
        If dgMain.Columns(e.ColumnIndex).Name.ToString = "add_sub" Then
            If e.Value.ToString <> "" Then
                If e.Value Then
                    e.Value = My.Resources.negative_15x15
                Else
                    e.Value = My.Resources.positive_15x15
                End If
            Else
                e.Value = My.Resources.positive_15x15
            End If
        End If
    End Sub
    Private Sub dgMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellDoubleClick
        Dim c = e.ColumnIndex
        Dim r = e.RowIndex
        If Not dgMain.ReadOnly Then
            If r > -1 Then
                Dim columnName = dgMain.Columns(c).Name.ToString
                Dim value = dgMain.Rows(r).Cells(c).Value.ToString
                If columnName = "add_sub" Then
                    If value = "True" Then
                        dgMain.Rows(r).Cells(c).Value = False
                    Else
                        dgMain.Rows(r).Cells(c).Value = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dic As New Dictionary(Of String, String)
        dic.Add("template_id", txt_template_id.Text)
        dic.Add("template_code", txt_template_code.Text)
        dic.Add("template_name", txt_template_name.Text)
        dic.Add("title1", txt_title_1.Text)
        dic.Add("title2", txt_title_2.Text)
        dic.Add("title3", txt_title_3.Text)
        dic.Add("fs_type", FS_Type)

        Dim transmode = ""

        Dim id As String = ""

        Dim dt_det As DataTable = dgMain.DataSource

        If dic.Item("template_id").ToString = "" Then
            'insert
            transmode = "Insert"
        Else
            transmode = "Update"
        End If

        Dim sql = ATGenerateQuery(transmode, "sys_fs_template", dic, Environment.MachineName, Environment.UserName, main.log_id)
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count > 0 Then
            id = dt.Rows(0).Item("return_id").ToString
        End If

        Dim sql_det As String = ""
        Dim detTransmode As String = ""
        For Each row As DataRow In dt_det.Rows
            detTransmode = ""
            Dim dic_det As New Dictionary(Of String, String)
            If row.Item("template_det_id").ToString = "" Or row.Item("template_det_id").ToString.Contains("tmp_") Then
                row.Item("template_det_id") = ""
                If Not row.Item("deleted") Then
                    detTransmode = "Insert"
                End If
            Else
                If row.Item("deleted") Then
                    detTransmode = "Remove"
                Else
                    detTransmode = "Update"
                End If
            End If
            dic_det.Add("template_det_id", row.Item("template_det_id").ToString)
            generateDictionary(row, "sel,command_name,row_type_name,chart_code,chart_name,deleted", dic_det)
            dic_det.Item("template_id") = id
            If detTransmode <> "" Then
                If detTransmode = "Remove" Then
                    sql_det = ATGenerateQuery(detTransmode, "sys_fs_template_det", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dic_det.Item("template_det_id").ToString & "|", "template_det_id")
                Else
                    sql_det = ATGenerateQuery(detTransmode, "sys_fs_template_det", dic_det, Environment.MachineName, Environment.UserName, main.log_id)
                End If
                FsQuery(sql_det)
            End If
        Next
        MsgBox("Successfully Save.")
        ClearControl()
        EnableControl(False)
        LoadTemplate()
        If id <> "" Then
            Dim drs = MyData.Select(String.Format("template_id = '{0}'", id))
            If drs.Count > 0 Then
                Dim dr = drs(0)
                currentDr = dr
                BindControl(dr)
                LoadTemplateDet(txt_template_id.Text)
            End If
        End If
    End Sub
    Private Sub generateDictionary(ByVal dr As DataRow, _
            ByVal col As String, _
            ByRef dic As Dictionary(Of String, String))
        Dim cols = col.Split(",")
        For Each dc As DataColumn In dr.Table.Columns
            If Not cols.Contains(dc.ColumnName.ToString) Then
                Dim myValue = dr.Item(dc.ColumnName.ToString).ToString
                If dc.DataType.ToString = "System.Boolean" Then
                    If myValue = "True" Then
                        myValue = "1"
                    Else
                        myValue = "0"
                    End If
                End If
                If dic.ContainsKey(dc.ColumnName.ToString) Then
                    dic.Item(dc.ColumnName.ToString) = myValue
                Else
                    dic.Add(dc.ColumnName.ToString, myValue)
                End If
            End If
        Next
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        LoadTemplate()
        fsdesign_view.ShowDialog()
        If fsdesign_view.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim id = fsdesign_view.MyTemplateID
            If id <> "" Then
                Dim drs = MyData.Select(String.Format("template_id = '{0}'", id))
                If drs.Count > 0 Then
                    Dim dr = drs(0)
                    currentDr = dr
                    BindControl(dr)
                    LoadTemplateDet(txt_template_id.Text)
                End If
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim id = txt_template_id.Text
        ClearControl()
        If id <> "" Then
            Dim drs = MyData.Select(String.Format("template_id = '{0}'", id))
            If drs.Count > 0 Then
                Dim dr = drs(0)
                currentDr = dr
                BindControl(dr)
                LoadTemplateDet(txt_template_id.Text)
            End If
        End If
        EnableControl(False)
    End Sub
    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        Dim id = txt_template_id.Text
        If id <> "" Then
            Dim drs = MyData.Select(String.Format("template_id = '{0}'", id))
            If drs.Count > 0 Then
                Dim dr = drs(0)
                currentDr = dr
                BindControl(dr)
                LoadTemplateDet(txt_template_id.Text)
            End If
            Dim dt_det As DataTable = dgMain.DataSource
            For Each dr As DataRow In dt_det.Rows
                dr.Item("template_det_id") = "tmp_" & Now.ToString("yyyyMMddHHmmssfff") & dt_det.Rows.IndexOf(dr)
            Next
            EnableControl()
            txt_template_id.Text = ""
        End If
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentDr IsNot Nothing Then
            If MyData IsNot Nothing Then
                Dim currentIndex = MyData.Rows.IndexOf(currentDr)
                If currentIndex > 0 Then
                    Dim dr = MyData.Rows(currentIndex - 1)
                    currentDr = dr
                    BindControl(currentDr)
                    LoadTemplateDet(txt_template_id.Text)
                Else
                    MsgBox("No Previous Record.")
                End If
            End If
        End If
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentDr IsNot Nothing Then
            If MyData IsNot Nothing Then
                Dim currentIndex = MyData.Rows.IndexOf(currentDr)
                If currentIndex < MyData.Rows.Count - 1 Then
                    Dim dr = MyData.Rows(currentIndex + 1)
                    currentDr = dr
                    BindControl(currentDr)
                    LoadTemplateDet(txt_template_id.Text)
                Else
                    MsgBox("Last Record")
                End If
            End If
        End If
    End Sub
    Private Sub initGrid(ByRef dg As DataGridView)
        For Each row As DataGridViewRow In dg.Rows
            If row.Cells("deleted").Value.ToString = "True" Then
                dgMain.CurrentCell = Nothing
                row.Visible = False
            End If
        Next
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim dttmp As DataTable = dgMain.DataSource
        Dim tmpview As New DataView(dttmp)
        tmpview.Sort = "order_by ASC"
        Dim dt = tmpview.ToTable
        For Each row As DataGridViewRow In dgMain.Rows
            If ifNull(row.Cells("sel").Value, "False").ToString = "True" Then
                Dim id = row.Cells("template_det_id").Value.ToString
                Dim drs = dt.Select(String.Format("template_det_id = '{0}'", id))
                If drs.Count > 0 Then
                    Dim dr = drs(0)
                    dr.Item("deleted") = True
                End If
                'dt.AcceptChanges()
            End If
        Next
        Dim currentIndex = 0
        For Each dr As DataRow In dt.Rows
            If dr.Item("deleted").ToString = "False" Then
                dr.Item("order_by") = currentIndex
                currentIndex += 1
            Else
                dr.Item("order_by") = "-1"
            End If
        Next
        'dt.AcceptChanges()
        dgMain.DataSource = dt
        initGrid(dgMain)
    End Sub
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        fs_filter.FS_Type = FS_Type
        If FS_Type = 1 Then
            fs_filter.lbl_title.Text = "Balance Sheet"
            fs_filter.Text = "Balance Sheet Setup"
        Else
            fs_filter.lbl_title.Text = "Income Statement"
            fs_filter.Text = "Income Statement Setup"
        End If
        fs_filter.template_id = txt_template_id.Text
        fs_filter.ShowDialog()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txt_template_id.Text <> "" Then
            Dim res = MsgBox("Are you sure to delete the template?", MsgBoxStyle.YesNo, "Delete Template")
            If res = MsgBoxResult.Yes Then
                Dim sql = ATGenerateQuery("Remove", "sys_fs_template", Nothing, Environment.MachineName, Environment.UserName, main.log_id, txt_template_id.Text & "|", "template_id")
                FsQuery(sql)
                ClearControl()
                LoadTemplate()
                currentDr = Nothing
                If MyData.Rows.Count > 0 Then
                    currentDr = MyData.Rows(MyData.Rows.Count - 1)
                    BindControl(currentDr)
                End If
            End If
        End If
    End Sub
End Class