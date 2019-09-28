Imports connectionlib.connectionlib
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.Data
Imports libacctng.myFunctions

Public Class ATFilter
    Private Sub txtType_ValueChange(sender As Object, e As EventArgs) Handles txtType.ValueChange
        txt_module_type.Value = txtType.Value
        txtModule.Value = ""
        txtModule.Text = ""
        txtModule.Enabled = False
        'ClearGrid()
        Dim sql As String = String.Format("SELECT a.at_module_id,a.at_module_type_id,a.at_module_name " &
            "FROM GetATModule a " &
            "WHERE a.at_module_type_id = '{0}' " &
            "", txtType.Value)
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count > 0 Then
            txtModule.Value = dt.Rows(0).Item("at_module_id").ToString
            txtModule.Text = dt.Rows(0).Item("at_module_name").ToString
            txtModule.Enabled = True
        End If
    End Sub
    Private Sub txtModule_ValueChange(sender As Object, e As EventArgs) Handles txtModule.ValueChange
        Dim at_module_id = txtModule.Value
        txtSubModule.Value = ""
        txtSubModule.Text = ""
        txtSubModule.Enabled = False
        'ClearGrid()
        Dim sql As String = String.Format("SELECT a.at_sub_module_id,a.at_module_id,a.at_sub_module_name " &
            "FROM GetATSubModule a " &
            "WHERE a.at_module_id = '{0}' " &
            "", txtModule.Value)
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count > 0 Then
            txtSubModule.Value = dt.Rows(0).Item("at_sub_module_id").ToString
            txtSubModule.Text = dt.Rows(0).Item("at_sub_module_name").ToString
            txtSubModule.Enabled = True
        End If
        If txtType.Value = 2 Then

        End If
    End Sub
    Private Sub txtSubModule_ValueChange(sender As Object, e As EventArgs) Handles txtSubModule.ValueChange
        Dim at_sub_module_id = txtSubModule.Value
        txtSubModuleFilter.Value = ""
        txtSubModuleFilter.Text = ""
        txtSubModuleFilter.Enabled = False
        'ClearGrid()
        Dim sql As String = String.Format("SELECT a.at_sub_module_filter_id,a.at_sub_module_id,a.at_sub_module_filter_name " &
            "FROM GetATSubModuleFilter a " &
            "WHERE a.at_sub_module_id = '{0}' " &
            "", txtSubModule.Value)
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count > 0 Then
            txtSubModuleFilter.Value = dt.Rows(0).Item("at_sub_module_filter_id").ToString
            txtSubModuleFilter.Text = dt.Rows(0).Item("at_sub_module_filter_name").ToString
            txtSubModuleFilter.Enabled = True
        End If
    End Sub
    Private Sub ATFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtType.Value = 2
        Dim sql As String = String.Format("SELECT book_id,book_name FROM lib_erp_book")
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count > 0 Then
            txtBook.Value = dt.Rows(0).Item("book_id").ToString
            txtBook.Text = dt.Rows(0).Item("book_name").ToString
        End If
    End Sub
    'Private Sub ClearGrid()
    '    lblNoRecords.Visible = True
    '    dgMain.DataSource = Nothing
    '    If dgMain.ColumnCount > 0 Then
    '        dgMain.Columns.Clear()
    '    End If
    'End Sub
    Private Sub filterTransaction(ByVal ModuleID As String)
        dgMain.DataSource = Nothing
        Dim journal_id As String = ""
        Select Case ModuleID
            Case "14" 'invoicing
                journal_id = "1"
            Case "15" 'or
                journal_id = "2"
            Case "16" 'cv
                journal_id = "4"
            Case "17" 'jb
                journal_id = "5"
            Case "18" 'ap
                journal_id = "3"
            Case "19" 'pc
                journal_id = "6"
            Case "20" 'dmcm
                journal_id = "7"
            Case "21" 'journalization
        End Select
        If journal_id <> "" Then
            ClassTransactionAT.LoadData(GridView1, journal_id)
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim ModuleID = txtModule.Value
        Dim SubModuleID = txtSubModule.Value
        Dim SubModuleFilterID = txtSubModuleFilter.Value
        Dim BookID = txtBook.Value
        Dim FilterID = txtFilter.Value
        Dim FilterValue = txtFilterValue.Text
        Dim ReportType = txtType.Value
        GridView1.Columns.Clear()
        Select Case ReportType
            Case "1" 'File Setup
                Dim ds = ClassFileSetupAT.LoadData(GridView1, ModuleID)
                ClassFileSetupAT.loadDataToGrid(dgMain, ds)
            Case "2" 'Transaction
                filterTransaction(ModuleID)
            Case "3" 'Rerports
            Case "4" 'Others
        End Select
    End Sub
    Private Sub PrintTransaction(ByVal ModuleID As String, ByVal ModuleName As String)
        Dim journal_id As String = ""
        Select Case ModuleID
            Case "14" 'invoicing
                journal_id = "1"
            Case "15" 'or
                journal_id = "2"
            Case "16" 'cv
                journal_id = "4"
            Case "17" 'jb
                journal_id = "5"
            Case "18" 'ap
                journal_id = "3"
            Case "19" 'pc
                journal_id = "6"
            Case "20" 'dmcm
                journal_id = "7"
            Case "21" 'journalization
        End Select
        If journal_id <> "" Then
            Dim sql As String = String.Format("CALL TransactionGetAT(0,'{0}');", journal_id)
            Dim dt As DataTable = Query(sql)
            If dt.Rows.Count > 0 Then
                Dim JBooks = groupDataTableToList(dt, "a_at_id")
                ClassTransactionExcel.CreateExcelTemplate(ModuleName, journal_id, JBooks)
            Else
                MsgBox("No Records Found.")
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim ModuleID = txtModule.Value
        Dim ModuleName = txtModule.Text
        Dim SubModuleID = txtSubModule.Value
        Dim SubModuleFilterID = txtSubModuleFilter.Value
        Dim BookID = txtBook.Value
        Dim FilterID = txtFilter.Value
        Dim FilterValue = txtFilterValue.Text
        Dim ReportType = txtType.Value
        Select Case ReportType
            Case "1" 'File Setup
                Dim ds = ClassFileSetupAT.LoadData(GridView1, ModuleID)
                ClassFileSetupExcel.CreateExcelTemplate(ModuleName, ModuleID, ds)
            Case "2" 'Transaction
                PrintTransaction(ModuleID, ModuleName)
            Case "3" 'Rerports
            Case "4" 'Others
        End Select
    End Sub
End Class