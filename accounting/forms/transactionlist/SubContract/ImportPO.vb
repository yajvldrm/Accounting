Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.OleDb

Public Class ImportPO
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim browser As New FolderBrowserDialog()
        If browser.ShowDialog = DialogResult.OK Then
            txtPath.Text = browser.SelectedPath
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Dim dir = txtPath.Text.Trim

            If dir <> "" Then

                Dim lstNeedFiles As New List(Of String)
                lstNeedFiles.Add("EXPORTAPPROJDET.DBF")
                lstNeedFiles.Add("EXPORTAPPROJHEAD.DBF")
                lstNeedFiles.Add("EXPORTDEPT.DBF")
                lstNeedFiles.Add("EXPORTGENERAL.DBF")
                lstNeedFiles.Add("EXPORTPROJ.DBF")

                Dim lstFoundFiles As New List(Of String)
                Dim strFileSize As String = ""
                Dim di As New IO.DirectoryInfo(dir)
                Dim aryFi As IO.FileInfo() = di.GetFiles("*.DBF")
                Dim fi As IO.FileInfo
                Dim ctrFound As Integer = 0

                For Each fi In aryFi
                    strFileSize = (Math.Round(fi.Length / 1024)).ToString()
                    lstFoundFiles.Add(fi.Name)
                Next

                For Each item As String In lstNeedFiles
                    If lstFoundFiles.Contains(item) Then
                        ctrFound += 1
                    End If
                Next
                If ctrFound = lstNeedFiles.Count Then
                    For Each item As String In lstNeedFiles
                        Try
                            Dim cmd As OleDbCommand
                            Dim dr As OleDbDataReader
                            Dim sqlStr As String = ""
                            Dim myAdapter As OleDbDataAdapter
                            Dim conn As OleDbConnection = New OleDbConnection()
                            Dim x As String = Path.GetDirectoryName(String.Format("{0}/{1}", dir, item))
                            conn.ConnectionString = "Provider=VFPOLEDB;Data Source=" + x + ";"
                            'conn.ConnectionString = "Provider=vfpoledb;Data Source=" & x & ";Extended Properties=dBASE IV;User ID=Admin;Password=;"
                            conn.Open()
                            sqlStr = "Select * from " & item
                            myAdapter = New OleDbDataAdapter(sqlStr, conn)
                            Dim YourResultSet As DataTable = New DataTable()
                            myAdapter.Fill(ds, item.Replace(".DBF", ""))

                        Catch ex As Exception
                            MyDebugging.AddText("[Import PO] " & ex.Message)
                            MsgBox(ex.Message.ToString)
                        End Try
                    Next
                    Dim sql_proj As String = String.Format("SELECT project_id,project_code,project_name FROM lib_erp_project")
                    Dim sql_dept As String = String.Format("SELECT department_id,department_code,department_name FROM lib_erp_department")
                    Dim sql_general As String = String.Format("SELECT * FROM lib_erp_general")

                    Dim dt_proj As DataTable = FsQuery(sql_proj)
                    Dim dt_dept As DataTable = FsQuery(sql_dept)
                    Dim dt_general As DataTable = FsQuery(sql_general)

                    ImportDepartment(dt_dept, ds.Tables("EXPORTDEPT"))
                    ImportGeneral(dt_general, ds.Tables("EXPORTGENERAL"))
                    ImportProject(dt_proj, ds.Tables("EXPORTPROJ"))
                    dt_proj = FsQuery(sql_proj)
                    dt_dept = FsQuery(sql_dept)
                    dt_general = FsQuery(sql_general)

                    Dim dicID As New Dictionary(Of String, String)
                    ImportHead(ds.Tables("EXPORTAPPROJHEAD"), dt_proj, dicID)
                    ImportDet(ds.Tables("EXPORTAPPROJDET"), dt_proj, dt_dept, dicID)
                    MsgBox("Import Done")
                Else
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ImportDet(ByVal dt As DataTable, ByVal dtProj As DataTable, ByVal dtDept As DataTable, ByVal dicID As Dictionary(Of String, String))
        Try
            Dim sql As String = ""
            For Each dr As DataRow In dt.Rows
                Dim sub_contract_id As String = ""
                Dim project_id As String = ""
                Dim drs = dtProj.Select(String.Format("project_code = '{0}'", dr.Item("project")))
                If drs.Length > 0 Then
                    project_id = drs(0).Item("project_id").ToString
                End If
                Dim dicKey As String = String.Format("{0}-{1}", dr.Item("yearref").ToString(), project_id)
                If dicID.ContainsKey(dicKey) Then
                    sub_contract_id = dicID.Item(dicKey).ToString()
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("sub_contract_det_id", "")
                    dic.Add("sub_contract_id", sub_contract_id)
                    dic.Add("sc_year", dr.Item("yearref").ToString())
                    dic.Add("project_id", project_id)
                    Dim d As DateTime = If(ifNull(dr.Item("date"), "").ToString() = "", Today, dr.Item("date"))
                    dic.Add("trans_date", d.ToString("yyyy-MM-dd"))
                    Dim department_id As String = ""
                    Dim drsDepartment = dtDept.Select(String.Format("department_code = '{0}'", dr.Item("dept_cd").ToString))
                    If drsDepartment.Length > 0 Then
                        department_id = drsDepartment(0).Item("department_id").ToString
                    End If
                    dic.Add("department_id", department_id)
                    dic.Add("amount", dr.Item("amount"))
                    dic.Add("oamount", dr.Item("oamount"))

                    'Dim currency_id As String = ""
                    'Dim drsCurrency = dtDept.Select(String.Format("currency = '{0}'", dr.Item("currency").ToString))
                    'If drsCurrency.Length > 0 Then
                    '    currency_id = drsCurrency(0).Item("currency_id").ToString
                    'End If
                    dic.Add("currency", dr.Item("currency").ToString)
                    dic.Add("exchange_rate", dr.Item("exrate"))
                    dic.Add("based_rate", dr.Item("basedrate"))
                    dic.Add("supcd", dr.Item("supcd"))
                    dic.Add("po_no", dr.Item("po_no"))
                    dic.Add("cons1", dr.Item("cons1"))
                    dic.Add("cons2", dr.Item("cons2"))
                    sql = ATGenerateQuery("Insert", "trans_sub_contract_det", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "sub_contract_det_id")
                    Query(sql)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub ImportHead(ByVal dt As DataTable, ByVal dtProj As DataTable, ByRef dicID As Dictionary(Of String, String))
        Try
            Dim sql As String = ""
            For Each dr As DataRow In dt.Rows
                Dim dicKey As String = ""
                Dim dic As New Dictionary(Of String, String)
                dic.Add("sub_contract_id", "")
                dic.Add("sc_year", dr.Item("yearref").ToString())
                Dim project_id As String = ""
                Dim drs = dtProj.Select(String.Format("project_code = '{0}'", dr.Item("project")))
                If drs.Length > 0 Then
                    project_id = drs(0).Item("project_id").ToString
                End If
                dic.Add("project_id", project_id)
                dicKey = String.Format("{0}-{1}", dr.Item("yearref").ToString(), project_id)
                dicID.Add(dicKey, "")
                sql = ATGenerateQuery("Insert", "trans_sub_contract", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "sub_contract_id")
                Dim dtReturn As DataTable = Query(sql)
                If dtReturn.Rows.Count > 0 Then
                    dicID.Item(dicKey) = dtReturn.Rows(0).Item("return_id").ToString()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub ImportGeneral(ByVal dtGeneral As DataTable, ByVal dt As DataTable)
        Try
            Dim lstInsert As New List(Of String)
            Dim sql As String = ""
            Dim ctr As Integer = 0
            Dim maxQuery As Integer = 50
            For Each dr As DataRow In dt.Rows
                Dim drs = dtGeneral.Select(String.Format("general_code = '{0}'", dr.Item("code")))
                If dr.Item("status") = "A" Or dr.Item("status") = "I" Then
                Else
                    If drs.Count = 0 Then
                        Dim dic As New Dictionary(Of String, String)
                        dic.Add("general_id", "")
                        dic.Add("general_code", dr.Item("code").ToString())
                        dic.Add("general_name", dr.Item("name").ToString())
                        Dim d As DateTime = If(ifNull(dr.Item("date"), "").ToString = "", Today, dr.Item("date"))
                        dic.Add("date", d.ToString("yyyy-MM-dd"))
                        dic.Add("address1", dr.Item("address1").ToString())
                        dic.Add("address2", dr.Item("address2").ToString())
                        dic.Add("address3", dr.Item("address3").ToString())
                        dic.Add("address4", dr.Item("address4").ToString())
                        dic.Add("attention", dr.Item("attention").ToString())
                        dic.Add("position", dr.Item("position").ToString())
                        dic.Add("tel_no", dr.Item("tel_no").ToString())
                        dic.Add("fax_no", dr.Item("fax_no").ToString())
                        dic.Add("cell_no", dr.Item("cellphone").ToString())
                        dic.Add("tin", dr.Item("tin").ToString())
                        dic.Add("email_add", dr.Item("email").ToString())
                        dic.Add("website", dr.Item("website").ToString())
                        dic.Add("remarks", dr.Item("remarks").ToString())
                        dic.Add("vat", dr.Item("vat").ToString())
                        dic.Add("status", dr.Item("status").ToString())
                        dic.Add("billto", dr.Item("billto").ToString())
                        dic.Add("billadd1", dr.Item("billadd1").ToString())
                        dic.Add("billadd2", dr.Item("billadd2").ToString())
                        dic.Add("billadd3", dr.Item("billadd3").ToString())
                        dic.Add("billadd4", dr.Item("billadd4").ToString())
                        dic.Add("drawing", dr.Item("drawing").ToString())
                        dic.Add("specs", dr.Item("specs").ToString())
                        sql &= ATGenerateQuery("Insert", "lib_erp_general", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "general_id")
                        ctr += 1
                        If ctr >= maxQuery Then
                            lstInsert.Add(sql)
                            sql = ""
                            ctr = 0
                        End If
                    End If
                End If
            Next
            If lstInsert.Count > 0 Then
                For Each query As String In lstInsert
                    FsQuery(query)
                Next
            End If
            If sql <> "" Then
                FsQuery(sql)
            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Private Sub ImportDepartment(ByVal dtDept As DataTable, ByVal dt As DataTable)
        Try
            Dim lstInsert As New List(Of String)
            Dim sql As String = ""
            Dim ctr As Integer = 0
            Dim maxQuery As Integer = 50
            For Each dr As DataRow In dt.Rows
                Dim drs = dtDept.Select(String.Format("department_code = '{0}'", dr.Item("dept_cd")))
                If drs.Count = 0 Then
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("department_id", "")
                    dic.Add("department_code", dr.Item("dept_cd").ToString())
                    dic.Add("department_name", dr.Item("dept_name").ToString())
                    sql &= ATGenerateQuery("Insert", "lib_erp_department", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "department_id")
                    ctr += 1
                    If ctr >= maxQuery Then
                        lstInsert.Add(sql)
                        sql = ""
                        ctr = 0
                    End If
                End If
            Next
            If lstInsert.Count > 0 Then
                For Each query As String In lstInsert
                    FsQuery(query)
                Next
            End If
            If sql <> "" Then
                FsQuery(sql)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Private Sub ImportProject(ByVal dtProj As DataTable, ByVal dt As DataTable)
        Try
            Dim lstInsert As New List(Of String)
            Dim sql As String = ""
            Dim ctr As Integer = 0
            Dim maxQuery As Integer = 50
            For Each dr As DataRow In dt.Rows
                Dim drs = dtProj.Select(String.Format("project_code = '{0}'", dr.Item("prj_cd")))
                If drs.Count = 0 Then
                    Dim dic As New Dictionary(Of String, String)
                    dic.Add("project_id", "")
                    dic.Add("project_code", dr.Item("prj_cd").ToString())
                    dic.Add("project_name", dr.Item("prj_name").ToString())
                    sql &= ATGenerateQuery("Insert", "lib_erp_project", dic, Environment.MachineName, Environment.UserName, main.log_id, "", "project_id")
                    ctr += 1
                    If ctr >= maxQuery Then
                        lstInsert.Add(sql)
                        sql = ""
                        ctr = 0
                    End If
                End If
            Next
            If lstInsert.Count > 0 Then
                For Each query As String In lstInsert
                    FsQuery(query)
                Next
            End If
            If sql <> "" Then
                FsQuery(sql)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
End Class