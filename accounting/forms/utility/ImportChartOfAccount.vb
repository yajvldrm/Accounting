Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ImportChartOfAccount
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
    Dim directory As String = Application.StartupPath & "\templates\"
    Dim templateFile As String = "ChartOfAccount.xlt"
    Dim dicValidation As New Dictionary(Of String, String)
    Private Sub btnGenerateTemplate_Click(sender As Object, e As EventArgs) Handles btnGenerateTemplate.Click
        If ExportResponse.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim withData = ExportResponse.exportData
            If withData Then
                Dim sql As String = String.Format("SELECT a.account_id,a.account_code,a.account_name,a.chart_class_id,a.date,a.validation " & _
                    ",IF(a.validation IS NULL OR a.validation = 0,'No Validation'" & _
                    ",IF(a.validation = 1,'Bank / Cash'" & _
                    ",IF(a.validation = 2,'AR'" & _
                    ",IF(a.validation = 3,'AP'" & _
                    ",IF(a.validation = 4,'EWT'" & _
                    ",IF(a.validation = 5,'Final Tax'" & _
                    ",IF(a.validation = 6,'Input Vat'" & _
                    ",IF(a.validation = 7,'Output Vat'" & _
                    ",IF(a.validation = 8,'Prepayment'" & _
                    ",IF(a.validation = 9,'Fixed Asset'" & _
                    ",IF(a.validation = 10,'Gain or Loss','No Validation'))))))))))) AS validation_name " & _
                    ",b.chart_class_code,b.chart_class_name " & _
                    ",d.chart_group_code,d.chart_group_name " & _
                    "FROM lib_erp_chart a " & _
                    "LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " & _
                    "LEFT JOIN lib_erp_chart_group c ON c.account_id = a.account_id " & _
                    "LEFT JOIN lib_acc_chart_group d ON d.chart_group_id = c.group_id " & _
                    "")
                Dim dt As DataTable = FsQuery(sql)
                ds.Tables("dt").Clear()
                If dt.Rows.Count > 0 Then
                    For Each dr As DataRow In dt.Rows
                        ds.Tables("dt").ImportRow(dr)
                    Next
                Else
                    MsgBox("No Record to show.")
                End If
                generateTemplate(dt, True)
            Else
                generateTemplate()
            End If
        End If
    End Sub
    Public Sub generateTemplate(Optional dt As DataTable = Nothing, Optional withData As Boolean = False)
        Dim currentRow As Integer = 2
        Try
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(directory & "/" & templateFile)
            xlApp.Visible = True
            xlWorkSheet = xlWorkBook.Worksheets(1)
            If withData Then
                For Each dr As DataRow In dt.Rows
                    Dim str_date = dr.Item("date").ToString
                    Dim tmp_date As Date = Today
                    If str_date = "" Or str_date = "0000-00-00" Then
                        tmp_date = CDate("0000-00-00")
                    Else
                        tmp_date = CDate(str_date)
                    End If
                    xlWorkSheet.Cells(currentRow, 1).Value = dr.Item("account_id").ToString
                    xlWorkSheet.Cells(currentRow, 2).Value = "'" & dr.Item("account_code").ToString
                    xlWorkSheet.Cells(currentRow, 3).Value = dr.Item("account_name").ToString
                    xlWorkSheet.Cells(currentRow, 4).Value = dr.Item("chart_class_code").ToString
                    xlWorkSheet.Cells(currentRow, 5).Value = tmp_date.ToString("MM/dd/yyyy")
                    xlWorkSheet.Cells(currentRow, 6).Value = dr.Item("validation_name").ToString
                    xlWorkSheet.Cells(currentRow, 7).Value = "'" & dr.Item("chart_group_code").ToString
                    currentRow += 1
                Next
            End If
            MsgBox("Generating Template : Done")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Dim openfile As New OpenFileDialog
            openfile.Filter = "Excel Files|*.xlsx"
            Dim path As String = openfile.FileName()
            If openfile.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Try
            Else
                path = openfile.FileName()
                txtPath.Text = path
            End If
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If txtPath.Text <> "" Then
            Try
                showForm(ImportChartOfAccountStatus, main)
                ImportChartOfAccountStatus.btnClose.Visible = False
                ImportChartOfAccountStatus.btnClose.Enabled = False
                setStatus("Initializing Importation ...")
                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Open(txtPath.Text)
                xlWorkSheet = xlWorkBook.Worksheets(1)
                setStatus("Get List of Chart Class")
                Dim sql_chart_class As String = "SELECT chart_class_id,chart_class_code,chart_class_name FROM lib_acc_chart_class"
                Dim dt_chart_class As DataTable = FsQuery(sql_chart_class)
                setStatus("Get List of Chart Group")
                Dim sql_chart_group As String = "SELECT chart_group_id,chart_group_code,chart_group_name FROM lib_acc_chart_group"
                Dim dt_chart_group As DataTable = FsQuery(sql_chart_group)
                Dim listError As New List(Of String)
                Dim listWarning As New List(Of String)
                Dim hasError As Boolean = False
                Dim lstInsert As New List(Of String)
                Dim lstUpdate As New List(Of String)
                Dim ctrInsert As Integer = 0
                Dim ctrUpdate As Integer = 0
                Dim tmp_insert As String = ""
                Dim tmp_update As String = ""
                Dim sql_insert_group As String = "" 'add chart group
                Dim sql_insert_account_group As String = "" 'add chart of account per group
                Dim dicAccountGroupInsert As New Dictionary(Of String, String) 'dictionary of chart group per account(add)
                Dim dicAccountGroupUpdate As New Dictionary(Of String, String) 'dictionary of chart group per account(update)
                Dim sql_update_group As String = "" 'update chart group
                Dim sql_update_account_group As String = "" 'update chart of account per group
                For i As Integer = 2 To xlWorkSheet.Rows.Count - 1
                    Dim account_id As String = getCellValue(xlWorkSheet, i, 1)
                    Dim account_code As String = CType(xlWorkSheet.Cells(i, 2), Excel.Range).Text.ToString.Trim.Replace("'", "")
                    Dim account_name As String = getCellValue(xlWorkSheet, i, 3)
                    Dim class_code As String = getCellValue(xlWorkSheet, i, 4)
                    Dim group_code As String = CType(xlWorkSheet.Cells(i, 7), Excel.Range).Text.ToString.Trim.Replace("'", "")
                    Dim chart_class As String = ""
                    Dim chart_group As String = ""
                    Dim account_date As String = getCellValue(xlWorkSheet, i, 5)
                    If account_date <> "" Then
                        account_date = CDate(account_date).ToString("yyyy-MM-dd")
                    End If
                    Dim validation As String = getCellValue(xlWorkSheet, i, 8)
                    If account_code = "" Then
                        setStatus("No Account Code : Consider as end of file.")
                        Exit For
                    End If
                    setStatus(String.Format("Row[{0}]Gather Information : {1}", i, account_code))
                    If account_id = "" Then
                        setStatus("Transmode : Insert")
                        setStatus("Test if Code Exist ...")
                        Dim tmpRows = ds.Tables("dt").Select(String.Format("account_code = '{0}'", account_code))
                        If tmpRows.Count > 0 Then
                            setStatus("Error : Account Code Already Exist")
                            listError.Add(String.Format("Row[{0}][Err]: Account Code Already Exist", i))
                            hasError = True
                        Else
                            setStatus("Check if Chart Class Exist : " & class_code)
                            Dim classRow = dt_chart_class.Select(String.Format("chart_class_code = '{0}'", class_code))
                            If classRow.Count > 0 Then
                                If validation = "" Then
                                    setStatus("Warning : No Value found with the validation,consider as No Validation.")
                                    listWarning.Add(String.Format("Row[{0}][Warn]: No Value found with the validation,consider as No Validation.", i))
                                    validation = "0"
                                End If
                                chart_class = classRow(0).Item("chart_class_id").ToString
                                'sql_insert &= String.Format(",('{0}','{1}','{2}','{3}','{4}')", account_code, account_name, chart_class, account_date, validation)
                                'IN `InTransmode` VARCHAR(10),IN `InTable` VARCHAR(60),IN `InFields` TEXT,IN `InValues` TEXT,IN `InPK` VARCHAR(60),IN `InValue` TEXT,IN `InComputerName` VARCHAR(60),IN `InUser` VARCHAR(60),IN `InLogID` BIGINT(20)
                                tmp_insert &= String.Format("CALL SaveTransaction" & _
                                    "('Insert','lib_erp_chart','account_id,account_code,account_name,chart_class_id,date,validation'" & _
                                    ",'{0}|{1}|{2}|{3}|{4}|{5}|','account_id','{0}','{6}','{7}','{8}');", _
                                    account_id, account_code, account_name, chart_class, account_date, validation, Environment.MachineName, Environment.UserName, main.log_id)
                                If ctrInsert >= 100 Then
                                    ctrInsert = 0
                                    lstInsert.Add(tmp_insert)
                                    tmp_insert = ""
                                Else
                                    ctrInsert += 1
                                End If
                                Dim newAccountRow = ds.Tables("dt").NewRow
                                newAccountRow.Item("account_code") = account_code
                                newAccountRow.Item("account_name") = account_name
                                ds.Tables("dt").Rows.Add(newAccountRow)
                                If group_code <> "" Then
                                    setStatus("Check if Chart Group Exist : " & group_code)
                                    Dim groupRow = dt_chart_group.Select(String.Format("chart_group_code = '{0}'", group_code))
                                    If groupRow.Count = 0 Then
                                        'sql_insert_group &= String.Format(",('{0}','{0}')", group_code)
                                        sql_insert_group &= String.Format("CALL SaveTransaction" & _
                                            "('Insert','lib_acc_chart_group','chart_group_id,chart_group_code,chart_group_name'" & _
                                            ",'{0}|{1}|{2}|','chart_group_id','{0}','{3}','{4}','{5}');", _
                                            "", group_code, group_code, Environment.MachineName, Environment.UserName, main.log_id)
                                        Dim newRow = dt_chart_group.NewRow
                                        newRow.Item("chart_group_code") = group_code
                                        newRow.Item("chart_group_name") = group_code
                                        dt_chart_group.Rows.Add(newRow)
                                    End If
                                    dicAccountGroupInsert.Add(account_code, group_code)
                                End If
                            Else
                                setStatus("Error : Chart Class Doesn't Exist")
                                listError.Add(String.Format("Row[{0}][Err]: Chart Class Doesn't Exist", i))
                                hasError = True
                            End If
                        End If
                    Else
                        setStatus("Transmode : Update")
                        'setStatus("Test if Code Exist ...")
                        Dim tmpRows = ds.Tables("dt").Select(String.Format("account_code = '{0}' AND account_id <> '{1}'", account_code, account_id))
                        'If tmpRows.Count > 0 Then
                        '    setStatus("Error : Account Code Already Exist")
                        '    listError.Add(String.Format("Row[{0}][Err]: Account Code Already Exist", i))
                        '    hasError = True
                        'Else

                        'End If
                        setStatus("Check if Chart Class Exist : " & class_code)
                        Dim classRow = dt_chart_class.Select(String.Format("chart_class_code = '{0}'", class_code))
                        If classRow.Count > 0 Then
                            setStatus("Check if account already in transaction ")
                            If validation = "" Then
                                setStatus("Warning : No Value found with the validation,consider as No Validation.")
                                listWarning.Add(String.Format("Row[{0}][Warn]: No Value found with the validation,consider as No Validation.", i))
                                validation = "0"
                            End If
                            chart_class = classRow(0).Item("chart_class_id").ToString
                            Dim used_in_transaction As Boolean = False
                            Dim sql_used_in_transaction As String = String.Format("SELECT jbooks_id FROM trans_jbooks WHERE account_id = '{0}'", account_id)
                            Dim dt_used_in_transaction As DataTable = Query(sql_used_in_transaction)
                            If dt_used_in_transaction.Rows.Count > 0 Then
                                used_in_transaction = True
                                setStatus("Warning : Account already used in transaction, validation unable to change.")
                                listWarning.Add(String.Format("Row[{0}][Warn]: Account already used in transaction, validation unable to change.", i))
                            End If
                            'sql_update &= String.Format("UPDATE lib_erp_chart " & _
                            '        "SET account_code = '{0}',account_name = '{1}',chart_class_id = '{2}',date = '{3}' WHERE account_id = '{4}';", account_code, account_name, chart_class, account_date, account_id)

                            If used_in_transaction Then
                                tmp_update &= String.Format("CALL SaveTransaction" &
                                    "('Update','lib_erp_chart','account_id,account_code,account_name,chart_class_id,date'" &
                                    ",'{0}|{1}|{2}|{3}|{4}|','account_id','{0}','{5}','{6}','{7}');",
                                    account_id, account_code, account_name, chart_class, account_date, validation, Environment.MachineName, Environment.UserName, main.log_id)
                            Else
                                tmp_update &= String.Format("CALL SaveTransaction" &
                                    "('Update','lib_erp_chart','account_id,account_code,account_name,chart_class_id,date'" &
                                    ",'{0}|{1}|{2}|{3}|{4}|{8}|','account_id','{0}','{5}','{6}','{7}');",
                                    account_id, account_code, account_name, chart_class, account_date, validation, Environment.MachineName, Environment.UserName, main.log_id, validation)
                            End If
                            If ctrUpdate >= 100 Then
                                ctrUpdate = 0
                                lstUpdate.Add(tmp_update)
                                tmp_update = ""
                            Else
                                ctrUpdate += 1
                            End If

                            'If Not used_in_transaction Then
                            '    sql_update &= String.Format("UPDATE lib_erp_chart SET validation = '{0}' WHERE account_id = '{1}';", validation, account_id)
                            'End If
                            Dim selectedAccount = ds.Tables("dt").Select(String.Format("account_id = '{0}'", account_id))
                            If selectedAccount.Count > 0 Then
                                Dim selectedRow = selectedAccount(0)
                                selectedRow.Item("account_code") = account_code
                                selectedRow.Item("account_name") = account_name
                                ds.Tables("dt").AcceptChanges()
                            End If
                            If group_code <> "" Then
                                setStatus("Check if Chart Group Exist : " & group_code)
                                Dim groupRow = dt_chart_group.Select(String.Format("chart_group_code = '{0}'", group_code))
                                If groupRow.Count = 0 Then
                                    'sql_insert_group &= String.Format(",('{0}','{0}')", group_code)
                                    sql_insert_group &= String.Format("CALL SaveTransaction" &
                                        "('Insert','lib_acc_chart_group','chart_group_id,chart_group_code,chart_group_name'" &
                                        ",'{0}|{1}|{2}|','chart_group_id','{0}','{3}','{4}','{5}');",
                                        "", group_code, group_code, Environment.MachineName, Environment.UserName, main.log_id)
                                    Dim newRow = dt_chart_group.NewRow
                                    newRow.Item("chart_group_code") = group_code
                                    newRow.Item("chart_group_name") = group_code
                                    dt_chart_group.Rows.Add(newRow)
                                End If
                                dicAccountGroupUpdate.Add(account_code, group_code)
                            End If
                        Else
                            setStatus("Error : Chart Class Doesn't Exist")
                            listError.Add(String.Format("Row[{0}][Err]: Chart Class Doesn't Exist", i))
                            hasError = True
                        End If
                    End If
                Next
                setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" & _
                          vbNewLine & "Run The Query")
                If lstInsert.Count > 0 Then
                    For Each strSql In lstInsert
                        FsQuery(strSql)
                    Next
                End If
                If tmp_insert <> "" Then
                    'Dim tmp_str = String.Format("INSERT INTO lib_erp_chart(account_code,account_name,chart_class_id,date,validation) VALUES{0}", sql_insert.Substring(1))
                    ''setStatus("Insert New Account ...")
                    'setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" & _
                    '      vbNewLine & tmp_str, False)
                    FsQuery(tmp_insert)
                End If
                If lstUpdate.Count > 0 Then
                    For Each strSql In lstUpdate
                        FsQuery(strSql)
                    Next
                End If
                If tmp_update <> "" Then
                    setStatus("Update Existing Account ...")
                    'setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" & _
                    '      vbNewLine & sql_update, False)
                    FsQuery(tmp_update)
                End If
                If sql_insert_group <> "" Then
                    'Dim tmp_str = String.Format("INSERT INTO lib_acc_chart_group(chart_group_code,chart_group_name) VALUES{0}", sql_insert_group.Substring(1))
                    setStatus("Insert New Chart Group ...")
                    'setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" & _
                    '      vbNewLine & tmp_str, False)
                    FsQuery(sql_insert_group)
                End If
                Dim tmp_sql_insert_account_group As String = ""
                Dim tmp_sql_update_account_group As String = ""
                For Each accGroup In dicAccountGroupInsert
                    Dim sql_account_id = String.Format("SELECT account_id FROM lib_erp_chart WHERE account_code = '{0}'", accGroup.Key)
                    Dim sql_group_id = String.Format("SELECT chart_group_id FROM lib_acc_chart_group WHERE chart_group_code = '{0}'", accGroup.Value)
                    Dim dt_account_id As DataTable = FsQuery(sql_account_id)
                    Dim dt_group_id As DataTable = FsQuery(sql_group_id)
                    If dt_account_id.Rows.Count > 0 And dt_group_id.Rows.Count > 0 Then
                        'tmp_sql_insert_account_group &= String.Format(",('{0}','{1}')", dt_account_id.Rows(0).Item("account_id").ToString, dt_group_id.Rows(0).Item("chart_group_id").ToString)
                        tmp_sql_insert_account_group &= String.Format("CALL SaveTransaction" & _
                            "('Insert','lib_erp_chart_group','chart_group_id,account_id,group_id'" & _
                            ",'{0}|{1}|{2}|','chart_group_id','{0}','{3}','{4}','{5}');", _
                            "", dt_account_id.Rows(0).Item("account_id").ToString, dt_group_id.Rows(0).Item("chart_group_id").ToString, Environment.MachineName, Environment.UserName, main.log_id)
                    End If
                Next
                For Each accGroup In dicAccountGroupUpdate
                    Dim sql_account_id = String.Format("SELECT account_id FROM lib_erp_chart WHERE account_code = '{0}'", accGroup.Key)
                    Dim sql_group_id = String.Format("SELECT chart_group_id FROM lib_acc_chart_group WHERE chart_group_code = '{0}'", accGroup.Value)
                    Dim dt_account_id As DataTable = FsQuery(sql_account_id)
                    Dim dt_group_id As DataTable = FsQuery(sql_group_id)

                    If dt_account_id.Rows.Count > 0 And dt_group_id.Rows.Count > 0 Then
                        Dim sql_account_exist As String = String.Format("SELECT chart_group_id FROM lib_erp_chart_group WHERE account_id = '{0}'", dt_account_id.Rows(0).Item("account_id").ToString)
                        Dim dt_account_exist As DataTable = FsQuery(sql_account_exist)
                        If dt_account_exist.Rows.Count > 0 Then
                            'tmp_sql_update_account_group &= String.Format("UPDATE lib_erp_chart_group SET group_id = '{0}' WHERE chart_group_id = '{1}';", dt_group_id.Rows(0).Item("chart_group_id").ToString, dt_account_exist.Rows(0).Item("chart_group_id").ToString)
                            tmp_sql_update_account_group &= String.Format("CALL SaveTransaction" & _
                                "('Update','lib_erp_chart_group','chart_group_id,account_id,group_id'" & _
                                ",'{0}|{1}|{2}|','chart_group_id','{0}','{3}','{4}','{5}');", _
                                dt_account_exist.Rows(0).Item("chart_group_id").ToString, dt_account_id.Rows(0).Item("account_id").ToString, dt_group_id.Rows(0).Item("chart_group_id").ToString, Environment.MachineName, Environment.UserName, main.log_id)
                        Else
                            'tmp_sql_insert_account_group &= String.Format(",('{0}','{1}')", dt_account_id.Rows(0).Item("account_id").ToString, dt_group_id.Rows(0).Item("chart_group_id").ToString)
                            tmp_sql_insert_account_group &= String.Format("CALL SaveTransaction" & _
                                "('Insert','lib_erp_chart_group','chart_group_id,account_id,group_id'" & _
                                ",'{0}|{1}|{2}|','chart_group_id','{0}','{3}','{4}','{5}');", _
                                "", dt_account_id.Rows(0).Item("account_id").ToString, dt_group_id.Rows(0).Item("chart_group_id").ToString, Environment.MachineName, Environment.UserName, main.log_id)
                        End If
                    End If
                Next
                If tmp_sql_insert_account_group <> "" Then
                    'Dim tmp_sql As String = String.Format("INSERT INTO lib_erp_chart_group(account_id,group_id) VALUES{0}", tmp_sql_insert_account_group.Substring(1))
                    setStatus("Insert Account Group ...")
                    FsQuery(tmp_sql_insert_account_group)
                End If
                If tmp_sql_update_account_group <> "" Then
                    setStatus("Update Account Group ...")
                    FsQuery(tmp_sql_update_account_group)
                End If
                setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" & _
                          vbNewLine & "Number of Warning : " & listWarning.Count, False)
                For Each i In listWarning
                    setStatus(i, False)
                Next
                setStatus("Number of Error : " & listError.Count, False)
                For Each i In listError
                    setStatus(i, False)
                Next
                If hasError Then
                    setStatus("Importation Unsuccessfully ..." & "------------------------------------------------------------------------------------------------------------------------------------------------------", False)
                Else
                    setStatus("Importation Successfully ..." & "------------------------------------------------------------------------------------------------------------------------------------------------------", False)
                End If
            Catch ex As Exception
                setStatus("****************************************************************************************************************" &
                          vbNewLine &
                          "Error : " & ex.Message &
                          "****************************************************************************************************************", False)
            End Try
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            ImportChartOfAccountStatus.btnClose.Visible = True
            ImportChartOfAccountStatus.btnClose.Enabled = True
        End If
    End Sub
    Private Sub setStatus(ByVal str As String, Optional withDateTime As Boolean = True)
        If withDateTime Then
            ImportChartOfAccountStatus.txtStatus.AppendText(Now.ToString("[MM/dd/yyyy HH:mm:ss] - ") & str)
        Else
            ImportChartOfAccountStatus.txtStatus.AppendText(str)
        End If
    End Sub
    Private Function getCellValue(ByVal xlWorkSheet As Excel.Worksheet, ByVal r As Integer, ByVal c As Integer) As String
        Return CType(xlWorkSheet.Cells(r, c), Excel.Range).Text.ToString.Trim.Replace("'", "''")
    End Function
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class