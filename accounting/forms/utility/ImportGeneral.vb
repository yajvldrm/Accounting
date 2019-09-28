Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ImportGeneral
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
    Dim directory As String = Application.StartupPath & "\templates\"
    Dim templateFile As String = "GeneralLibrary.xlt"
    Dim dicValidation As New Dictionary(Of String, String)
    Private Sub btnGenerateTemplate_Click(sender As Object, e As EventArgs) Handles btnGenerateTemplate.Click
        If ExportResponse.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim withData = ExportResponse.exportData
            generateTemplate(withData)
        End If
    End Sub
    Public Sub generateTemplate(Optional withData As Boolean = False)
        Try
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(directory & "/" & templateFile)
            xlApp.Visible = True
            If withData Then
                generateGeneral()
                generateGeneralEWT()
                generateGeneralFinalTax()
            End If
            MsgBox("Generating Template : Done")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub
    Public Sub generateGeneral()
        Dim sql As String = String.Format("SELECT a.general_id,a.general_code,a.general_name,a.date,a.address1,a.address2,a.address3,a.address4,a.attention " & _
                    ",a.position,a.cell_no,a.tel_no,a.fax_no,a.category_id,a.tin,a.email_add,a.website,a.terms_id,a.nodays,a.industry_id " & _
                    ",a.status,IF(a.status = 0,'Active','Inactive') AS status_name " & _
                    ",b.category_code,b.category_name,c.industry_code,c.industry_name,d.terms_code,d.terms_name " & _
                    "FROM lib_erp_general a " & _
                    "LEFT JOIN lib_erp_category b ON b.category_id = a.category_id " & _
                    "LEFT JOIN lib_erp_industry c ON c.industry_id = a.industry_id " & _
                    "LEFT JOIN lib_erp_terms d ON d.terms_id = a.terms_id " & _
                    "ORDER BY a.general_id ")
        Dim dt As DataTable = FsQuery(sql)
        xlWorkSheet = xlWorkBook.Worksheets(1)
        Dim currentRow As Integer = 2
        For Each dr As DataRow In dt.Rows
            Dim str_date = dr.Item("date").ToString
            Dim tmp_date As Date = Today
            If str_date = "" Or str_date = "0000-00-00" Then
                tmp_date = CDate("0000-00-00")
            Else
                tmp_date = CDate(str_date)
            End If
            xlWorkSheet.Cells(currentRow, 1).Value = dr.Item("general_id").ToString
            xlWorkSheet.Cells(currentRow, 2).Value = dr.Item("general_code").ToString
            xlWorkSheet.Cells(currentRow, 3).Value = dr.Item("general_name").ToString
            xlWorkSheet.Cells(currentRow, 4).Value = tmp_date.ToString("MM/dd/yyyy")
            xlWorkSheet.Cells(currentRow, 5).Value = dr.Item("address1").ToString
            xlWorkSheet.Cells(currentRow, 6).Value = dr.Item("address2").ToString
            xlWorkSheet.Cells(currentRow, 7).Value = dr.Item("address3").ToString
            xlWorkSheet.Cells(currentRow, 8).Value = dr.Item("address4").ToString
            xlWorkSheet.Cells(currentRow, 9).Value = dr.Item("attention").ToString
            xlWorkSheet.Cells(currentRow, 10).Value = dr.Item("position").ToString
            xlWorkSheet.Cells(currentRow, 11).Value = dr.Item("cell_no").ToString
            xlWorkSheet.Cells(currentRow, 12).Value = dr.Item("tel_no").ToString
            xlWorkSheet.Cells(currentRow, 13).Value = dr.Item("fax_no").ToString
            xlWorkSheet.Cells(currentRow, 14).Value = dr.Item("category_name").ToString
            xlWorkSheet.Cells(currentRow, 15).Value = dr.Item("tin").ToString
            xlWorkSheet.Cells(currentRow, 16).Value = dr.Item("email_add").ToString
            xlWorkSheet.Cells(currentRow, 17).Value = dr.Item("website").ToString
            xlWorkSheet.Cells(currentRow, 18).Value = dr.Item("terms_name").ToString
            xlWorkSheet.Cells(currentRow, 19).Value = dr.Item("nodays").ToString
            xlWorkSheet.Cells(currentRow, 20).Value = dr.Item("industry_name").ToString
            xlWorkSheet.Cells(currentRow, 21).Value = dr.Item("status_name").ToString
            currentRow += 1
        Next
    End Sub
    Public Sub generateGeneralEWT()
        Dim sql As String = String.Format("SELECT a.general_ewt_id,a.general_id,a.ewt_id " &
            ",b.general_code,b.general_name,c.ewt_code,c.ewt_name " &
            "FROM lib_erp_general_ewt a " &
            "LEFT JOIN lib_erp_general b ON b.general_id = a.general_id " &
            "LEFT JOIN lib_acc_ewt c ON c.ewt_id = a.ewt_id ")
        Dim dt As DataTable = FsQuery(sql)
        xlWorkSheet = xlWorkBook.Worksheets(2)
        Dim currentRow As Integer = 2
        For Each dr As DataRow In dt.Rows
            xlWorkSheet.Cells(currentRow, 1).Value = dr.Item("general_ewt_id").ToString
            xlWorkSheet.Cells(currentRow, 2).Value = dr.Item("general_code").ToString
            xlWorkSheet.Cells(currentRow, 3).Value = dr.Item("ewt_code").ToString
            currentRow += 1
        Next
    End Sub
    Public Sub generateGeneralFinalTax()
        Dim sql As String = String.Format("SELECT a.general_final_tax_id,a.general_id,a.final_tax_id " &
            ",b.general_code,b.general_name,c.final_tax_code,c.final_tax_name " &
            "FROM lib_erp_general_final_tax a " &
            "LEFT JOIN lib_erp_general b ON b.general_id = a.general_id " &
            "LEFT JOIN lib_acc_final_tax c ON c.final_tax_id = a.final_tax_id ")
        Dim dt As DataTable = FsQuery(sql)
        xlWorkSheet = xlWorkBook.Worksheets(3)
        Dim currentRow As Integer = 2
        For Each dr As DataRow In dt.Rows
            xlWorkSheet.Cells(currentRow, 1).Value = dr.Item("general_final_tax_id").ToString
            xlWorkSheet.Cells(currentRow, 2).Value = dr.Item("general_code").ToString
            xlWorkSheet.Cells(currentRow, 3).Value = dr.Item("final_tax_code").ToString
            currentRow += 1
        Next
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
            showForm(ImportGeneralStatus, main)
            ImportGeneralStatus.btnClose.Visible = False
            ImportGeneralStatus.btnClose.Enabled = False
            setStatus("Initializing Importation ...")
            xlApp = New Excel.Application

            xlWorkBook = xlApp.Workbooks.Open(txtPath.Text)
            setStatus("****************************************************************************************************************", False)
            setStatus("Importing General", False)
            ImportGeneral()
            setStatus("****************************************************************************************************************", False)
            setStatus("Importing EWT", False)
            ImportGeneralEWT()
            setStatus("****************************************************************************************************************", False)
            setStatus("Importing Final Tax", False)
            ImportGeneralFinalTax()

            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            ImportGeneralStatus.btnClose.Visible = True
            ImportGeneralStatus.btnClose.Enabled = True
        End If
    End Sub
    Private Sub ImportGeneralFinalTax()
        Try
            xlWorkSheet = xlWorkBook.Worksheets(3)
            setStatus("Getting list of general")
            Dim sql_general As String = String.Format("SELECT a.general_id,a.general_code,a.general_name " &
                "FROM lib_erp_general a ")
            Dim dt_general As DataTable = FsQuery(sql_general)
            setStatus("Getting list of Final Tax")
            Dim sql_final_tax As String = String.Format("SELECT a.final_tax_id,a.final_tax_code,a.final_tax_name " &
                "FROM lib_acc_final_tax a ")
            Dim dt_final_tax As DataTable = FsQuery(sql_final_tax)
            Dim sql_insert As String = ""
            Dim sql_update As String = ""
            Dim tmp_insert As String = ""
            Dim ctr As Integer = 0
            Dim listError As New List(Of String)
            Dim listWarning As New List(Of String)
            Dim hasError As Boolean = False
            For i As Integer = 2 To xlWorkSheet.Rows.Count - 1
                Dim general_final_tax_id As String = getCellValue(xlWorkSheet, i, 1)
                Dim general_code As String = getCellValue(xlWorkSheet, i, 2)
                Dim final_tax_code As String = getCellValue(xlWorkSheet, i, 3)
                If general_code = "" Or final_tax_code = "" Then
                    setStatus("No General Code or Final Tax Code, Consider as end of file.")
                    Exit For
                End If
                Dim general_id As String = ""
                Dim final_tax_id As String = ""
                setStatus("Check if general exist : " & general_code)
                Dim generals = dt_general.Select(String.Format("general_code = '{0}'", general_code))
                setStatus("Check if Final Tax exist : " & final_tax_code)
                Dim final_taxes = dt_final_tax.Select(String.Format("final_tax_code = '{0}'", final_tax_code))
                If generals.Length > 0 Then
                    general_id = generals(0).Item("general_id").ToString
                Else
                    setStatus("Error : No General Found")
                    listError.Add(String.Format("Row[{0}][Err]: No General Found", i))
                    hasError = True
                End If
                If final_taxes.Length > 0 Then
                    final_tax_id = final_taxes(0).Item("final_tax_id").ToString
                Else
                    setStatus("Error : No Final Tax Found")
                    listError.Add(String.Format("Row[{0}][Err]: No Final Tax Found", i))
                    hasError = True
                End If
                If general_final_tax_id = "" Then
                    setStatus("Transmode : Insert")
                    If ctr < 100 Then
                        ctr += 1
                        tmp_insert &= String.Format(",('{0}','{1}')", general_id, final_tax_id)
                    Else
                        sql_insert &= String.Format("INSERT INTO lib_erp_general_final_tax(general_id,final_tax_id) VALUES{0};", tmp_insert.Substring(1))
                        tmp_insert = ""
                        ctr = 0
                    End If
                Else
                    setStatus("Transmode : Update")
                    sql_update &= String.Format("UPDATE lib_erp_general_final_tax SET general_id = '{0}',final_tax_id = '{1}' WHERE general_final_tax_id = '{2}';",
                        general_id, final_tax_id, general_final_tax_id)
                End If
            Next
            If tmp_insert <> "" Then
                sql_insert &= String.Format("INSERT INTO lib_erp_general_final_tax(general_id,final_tax_id) VALUES{0};", tmp_insert.Substring(1))
            End If
            setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" &
                      vbNewLine & "Run The Query")
            If sql_insert <> "" Then
                setStatus("Insert New Account ...")
                FsQuery(sql_insert)
            End If
            If sql_update <> "" Then
                setStatus("Update Existing Final Tax per General ...")
                FsQuery(sql_update)
            End If
            setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" &
                      vbNewLine & "Number of Warning : " & listWarning.Count, False)
            For Each i In listWarning
                setStatus(i, False)
            Next
            setStatus("Number of Error : " & listError.Count, False)
            For Each i In listError
                setStatus(i, False)
            Next
            If hasError Then
                setStatus("Importation of Final Tax per General Unsuccessfully ..." & "------------------------------------------------------------------------------------------------------------------------------------------------------", False)
            Else
                setStatus("Importation of Final Tax per General Successfully ..." & "------------------------------------------------------------------------------------------------------------------------------------------------------", False)
            End If
        Catch ex As Exception
            setStatus("****************************************************************************************************************" &
                      vbNewLine &
                      "Error : " & ex.Message &
                      "****************************************************************************************************************", False)
        End Try
    End Sub
    Private Sub ImportGeneralEWT()
        Try
            xlWorkSheet = xlWorkBook.Worksheets(2)
            setStatus("Getting list of general")
            Dim sql_general As String = String.Format("SELECT a.general_id,a.general_code,a.general_name " &
                "FROM lib_erp_general a ")
            Dim dt_general As DataTable = FsQuery(sql_general)
            setStatus("Getting list of EWT")
            Dim sql_ewt As String = String.Format("SELECT a.ewt_id,a.ewt_code,a.ewt_name " &
                "FROM lib_acc_ewt a ")
            Dim dt_ewt As DataTable = FsQuery(sql_ewt)
            Dim sql_insert As String = ""
            Dim sql_update As String = ""
            Dim tmp_insert As String = ""
            Dim ctr As Integer = 0
            Dim listError As New List(Of String)
            Dim listWarning As New List(Of String)
            Dim hasError As Boolean = False
            For i As Integer = 2 To xlWorkSheet.Rows.Count - 1
                Dim general_ewt_id As String = getCellValue(xlWorkSheet, i, 1)
                Dim general_code As String = getCellValue(xlWorkSheet, i, 2)
                Dim ewt_code As String = getCellValue(xlWorkSheet, i, 3)
                If general_code = "" Or ewt_code = "" Then
                    setStatus("No General Code or EWT Code, Consider as end of file.")
                    Exit For
                End If
                Dim general_id As String = ""
                Dim ewt_id As String = ""
                setStatus("Check if general exist : " & general_code)
                Dim generals = dt_general.Select(String.Format("general_code = '{0}'", general_code))
                setStatus("Check if EWT exist : " & ewt_code)
                Dim ewts = dt_ewt.Select(String.Format("ewt_code = '{0}'", ewt_code))
                If generals.Length > 0 Then
                    general_id = generals(0).Item("general_id").ToString
                Else
                    setStatus("Error : No General Found")
                    listError.Add(String.Format("Row[{0}][Err]: No General Found", i))
                    hasError = True
                End If
                If ewts.Length > 0 Then
                    ewt_id = ewts(0).Item("ewt_id").ToString
                Else
                    setStatus("Error : No EWT Found")
                    listError.Add(String.Format("Row[{0}][Err]: No EWT Found", i))
                    hasError = True
                End If
                If general_ewt_id = "" Then
                    setStatus("Transmode : Insert")
                    If ctr < 100 Then
                        ctr += 1
                        tmp_insert &= String.Format(",('{0}','{1}')", general_id, ewt_id)
                    Else
                        sql_insert &= String.Format("INSERT INTO lib_erp_general_ewt(general_id,ewt_id) VALUES{0};", tmp_insert.Substring(1))
                        tmp_insert = ""
                        ctr = 0
                    End If
                Else
                    setStatus("Transmode : Update")
                    sql_update &= String.Format("UPDATE lib_erp_general_ewt SET general_id = '{0}',ewt_id = '{1}' WHERE general_ewt_id = '{2}';",
                        general_id, ewt_id, general_ewt_id)
                End If
            Next
            If tmp_insert <> "" Then
                sql_insert &= String.Format("INSERT INTO lib_erp_general_ewt(general_id,ewt_id) VALUES{0};", tmp_insert.Substring(1))
            End If
            setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" &
                      vbNewLine & "Run The Query")
            If sql_insert <> "" Then
                setStatus("Insert New Account ...")
                FsQuery(sql_insert)
            End If
            If sql_update <> "" Then
                setStatus("Update Existing EWT per General ...")
                FsQuery(sql_update)
            End If
            setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" &
                      vbNewLine & "Number of Warning : " & listWarning.Count, False)
            For Each i In listWarning
                setStatus(i, False)
            Next
            setStatus("Number of Error : " & listError.Count, False)
            For Each i In listError
                setStatus(i, False)
            Next
            If hasError Then
                setStatus("Importation of EWT per General Unsuccessfully ..." & "------------------------------------------------------------------------------------------------------------------------------------------------------", False)
            Else
                setStatus("Importation of EWT per General Successfully ..." & "------------------------------------------------------------------------------------------------------------------------------------------------------", False)
            End If
        Catch ex As Exception
            setStatus("****************************************************************************************************************" &
                      vbNewLine &
                      "Error : " & ex.Message &
                      "****************************************************************************************************************", False)
        End Try
    End Sub
    Private Sub ImportGeneral()
        Try
            xlWorkSheet = xlWorkBook.Worksheets(1)
            setStatus("Get List of Existing General")
            Dim sql As String = String.Format("SELECT a.general_id,a.general_code,a.general_name,a.date,a.address1,a.address2,a.address3,a.address4,a.attention " &
                ",a.position,a.cell_no,a.tel_no,a.fax_no,a.category_id,a.tin,a.email_add,a.website,a.terms_id,a.nodays,a.industry_id " &
                ",a.status,IF(a.status = 0,'Active','Inactive') AS status_name " &
                ",b.category_code,b.category_name,c.industry_code,c.industry_name,d.terms_code,d.terms_name " &
                "FROM lib_erp_general a " &
                "LEFT JOIN lib_erp_category b ON b.category_id = a.category_id " &
                "LEFT JOIN lib_erp_industry c ON c.industry_id = a.industry_id " &
                "LEFT JOIN lib_erp_terms d ON d.terms_id = a.terms_id " &
                "ORDER BY a.general_id ")
            Dim dt As DataTable = FsQuery(sql)
            ds.Tables("dt").Clear()
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    ds.Tables("dt").ImportRow(dr)
                Next
            End If
            setStatus("Get List of Industry")
            Dim sql_industry As String = "SELECT industry_id,industry_code,industry_name FROM lib_erp_industry"
            Dim dt_industry As DataTable = FsQuery(sql_industry)
            setStatus("Get List of Category")
            Dim sql_category As String = "SELECT category_id,category_code,category_name FROM lib_erp_category"
            Dim dt_category As DataTable = FsQuery(sql_category)
            setStatus("Get List of Terms")
            Dim sql_terms As String = "SELECT terms_id,terms_code,terms_name FROM lib_erp_terms"
            Dim dt_terms As DataTable = FsQuery(sql_terms)
            Dim listError As New List(Of String)
            Dim listWarning As New List(Of String)
            Dim hasError As Boolean = False

            Dim general_ctr As Integer = 0
            Dim max_ctr = 50
            Dim listInsertGeneral As New List(Of String)
            Dim listUpdateGeneral As New List(Of String)

            Dim sql_insert As String = ""
            Dim sql_update As String = ""
            Dim sql_insert_industry As String = "" 'add industry
            Dim sql_insert_category As String = "" 'add category
            Dim sql_insert_terms As String = "" 'add terms
            Dim dicGeneralCategoryInsert As New Dictionary(Of String, String)
            Dim dicGeneralIndustryInsert As New Dictionary(Of String, String)
            Dim dicGeneralTermsInsert As New Dictionary(Of String, String)
            For i As Integer = 2 To xlWorkSheet.Rows.Count - 1
                Dim general_id As String = getCellValue(xlWorkSheet, i, 1)
                Dim general_code As String = getCellValue(xlWorkSheet, i, 2)
                Dim general_name As String = getCellValue(xlWorkSheet, i, 3)
                Dim general_date As String = getCellValue(xlWorkSheet, i, 4)
                If general_date <> "" Then
                    general_date = CDate(general_date).ToString("yyyy-MM-dd")
                End If
                Dim address1 As String = getCellValue(xlWorkSheet, i, 5)
                Dim address2 As String = getCellValue(xlWorkSheet, i, 6)
                Dim address3 As String = getCellValue(xlWorkSheet, i, 7)
                Dim address4 As String = getCellValue(xlWorkSheet, i, 8)
                Dim attention As String = getCellValue(xlWorkSheet, i, 9)
                Dim position As String = getCellValue(xlWorkSheet, i, 10)
                Dim cell_no As String = getCellValue(xlWorkSheet, i, 11)
                Dim tel_no As String = getCellValue(xlWorkSheet, i, 12)
                Dim fax_no As String = getCellValue(xlWorkSheet, i, 13)
                Dim category_name As String = getCellValue(xlWorkSheet, i, 14)
                Dim tin As String = getCellValue(xlWorkSheet, i, 15)
                Dim email_add As String = getCellValue(xlWorkSheet, i, 16)
                Dim website As String = getCellValue(xlWorkSheet, i, 17)
                Dim terms_name As String = getCellValue(xlWorkSheet, i, 18)
                Dim nodays As String = getCellValue(xlWorkSheet, i, 19)
                Dim industry_name As String = getCellValue(xlWorkSheet, i, 20)
                Dim status_name As String = getCellValue(xlWorkSheet, i, 21)
                Dim category_id As String = ""
                Dim terms_id As String = ""
                Dim industry_id As String = ""
                Dim status As String = ""
                If general_code = "" Then
                    setStatus("No General Code : Consider as end of file.")
                    Exit For
                End If
                setStatus(String.Format("Row[{0}]Gather Information : {1}", i, general_code))
                If general_id = "" Then
                    setStatus("Transmode : Insert")
                    setStatus("Test if Code Exist ...")
                    Dim tmpRows = ds.Tables("dt").Select(String.Format("general_code = '{0}'", general_code))
                    If tmpRows.Count > 0 Then
                        setStatus("Error : General Code Already Exist")
                        listError.Add(String.Format("Row[{0}][Err]: General Code Already Exist", i))
                        hasError = True
                    Else
                        Dim categoryRow = dt_category.Select(String.Format("category_name = '{0}'", category_name))
                        Dim industryRow = dt_industry.Select(String.Format("industry_name = '{0}'", industry_name))
                        Dim termsRow = dt_terms.Select(String.Format("terms_name = '{0}'", terms_name))
                        If status_name = "" Then
                            setStatus("Warning : No Value found with the status,consider as Active.")
                            listWarning.Add(String.Format("Row[{0}][Warn]: No Value found with the status,consider as Active.", i))
                            status = "0"
                        Else
                            status = If(status_name.ToLower = "active", "0", "1")
                        End If
                        setStatus("Check if Category Exist : " & category_name)
                        If categoryRow.Count > 0 Then
                            category_id = categoryRow(0).Item("category_id").ToString
                            If category_id = "" Then
                                dicGeneralCategoryInsert.Add(general_code, category_name)
                            End If
                        Else
                            If category_name <> "" Then
                                setStatus("No Category Found. Consider as new Category.")
                                'sql_insert_category &= String.Format(",('{0}','{0}')", category_name)
                                sql_insert_category &= String.Format("CALL SaveTransaction" &
                                            "('Insert','lib_erp_category','category_id,category_code,category_name'" &
                                            ",'{0}|{1}|{2}|','category_id','{0}','{3}','{4}','{5}');",
                                            "", category_name, category_name, Environment.MachineName, Environment.UserName, main.log_id)
                                Dim newCategoryRow = dt_category.NewRow
                                newCategoryRow.Item("category_code") = category_name
                                newCategoryRow.Item("category_name") = category_name
                                dt_category.Rows.Add(newCategoryRow)
                                dicGeneralCategoryInsert.Add(general_code, category_name)
                            End If
                        End If
                        setStatus("Check if Industry Exist : " & industry_name)
                        If industryRow.Count > 0 Then
                            industry_id = industryRow(0).Item("industry_id").ToString
                            If industry_id = "" Then
                                dicGeneralIndustryInsert.Add(general_code, industry_name)
                            End If
                        Else
                            If industry_name <> "" Then
                                setStatus("No Industry Found. Consider as new Industry.")
                                'sql_insert_industry &= String.Format(",('{0}','{0}')", industry_name)
                                sql_insert_industry &= String.Format("CALL SaveTransaction" &
                                            "('Insert','lib_erp_industry','industry_id,industry_code,industry_name'" &
                                            ",'{0}|{1}|{2}|','industry_id','{0}','{3}','{4}','{5}');",
                                            "", industry_name, industry_name, Environment.MachineName, Environment.UserName, main.log_id)
                                Dim newIndustryRow = dt_industry.NewRow
                                newIndustryRow.Item("industry_code") = industry_name
                                newIndustryRow.Item("industry_name") = industry_name
                                dt_industry.Rows.Add(newIndustryRow)
                                dicGeneralIndustryInsert.Add(general_code, industry_name)
                            End If
                        End If
                        setStatus("Check if Terms Exist : " & terms_name)
                        If termsRow.Count > 0 Then
                            terms_id = termsRow(0).Item("terms_id").ToString
                            If terms_id = "" Then
                                dicGeneralTermsInsert.Add(general_code, terms_name)
                            End If
                        Else
                            If terms_name <> "" Then
                                setStatus("No Terms Found. Consider as new Terms.")
                                'sql_insert_terms &= String.Format(",('{0}','{0}')", terms_name)
                                sql_insert_terms &= String.Format("CALL SaveTransaction" &
                                            "('Insert','lib_erp_terms','terms_id,terms_code,terms_name'" &
                                            ",'{0}|{1}|{2}|','terms_id','{0}','{3}','{4}','{5}');",
                                            "", terms_name, terms_name, Environment.MachineName, Environment.UserName, main.log_id)
                                Dim newTermsRow = dt_terms.NewRow
                                newTermsRow.Item("terms_code") = terms_name
                                newTermsRow.Item("terms_name") = terms_name
                                dt_terms.Rows.Add(newTermsRow)
                                dicGeneralTermsInsert.Add(general_code, terms_name)
                            End If
                        End If
                        general_ctr += 1
                        sql_insert &= String.Format("CALL SaveTransaction" &
                            "('Insert','lib_erp_general','general_id,general_code,general_name,date,address1,address2" &
                            ",address3,address4,attention,position,cell_no,tel_no,fax_no,category_id,tin,email_add,website" &
                            ",terms_id,nodays,industry_id,status'" &
                            ",'{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|','general_id','{0}','{21}','{22}','{23}');",
                            general_id, general_code, general_name, general_date, address1, address2, address3, address4, attention,
                            position, cell_no, tel_no, fax_no, category_id,
                            tin, email_add, website, terms_id, nodays,
                            industry_id, status, Environment.MachineName, Environment.UserName, main.log_id)
                        If general_ctr = max_ctr Then
                            If sql_insert <> "" Then
                                listInsertGeneral.Add(sql_insert)
                            End If
                            sql_insert = ""
                            general_ctr = 0
                        End If
                        Dim newDR = ds.Tables("dt").NewRow
                        newDR.Item("general_code") = general_code
                        ds.Tables("dt").Rows.Add(newDR)
                        'sql_insert &= String.Format(",('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'" & _
                        '    ",'{9}','{10}','{11}',{12},'{13}','{14}','{15}',{16},'{17}',{18},'{19}')",
                        '    general_code, general_name, general_date, address1, address2, address3, address4, attention,
                        '    position, cell_no, tel_no, fax_no, If(category_id = "", "default", "'" & category_id & "'"),
                        '    tin, email_add, website, If(terms_id = "", "default", "'" & terms_id & "'"), nodays,
                        '    If(industry_id = "", "default", "'" & industry_id & "'"), status)
                    End If
                Else
                    setStatus("Transmode : Update")
                    setStatus("Test if Code Exist ...")
                    Dim tmpRows = ds.Tables("dt").Select(String.Format("general_code = '{0}' AND general_id <> '{1}'", general_code, general_id))
                    If tmpRows.Count > 0 Then
                        setStatus("Error : General Code Already Exist")
                        listError.Add(String.Format("Row[{0}][Err]: General Code Already Exist", i))
                        hasError = True
                    Else
                        Dim categoryRow = dt_category.Select(String.Format("category_name = '{0}'", category_name))
                        Dim industryRow = dt_industry.Select(String.Format("industry_name = '{0}'", industry_name))
                        Dim termsRow = dt_terms.Select(String.Format("terms_name = '{0}'", terms_name))
                        If status_name = "" Then
                            setStatus("Warning : No Value found with the status,consider as Active.")
                            listWarning.Add(String.Format("Row[{0}][Warn]: No Value found with the status,consider as Active.", i))
                            status = "0"
                        Else
                            status = If(status_name.ToLower = "active", "0", "1")
                        End If
                        setStatus("Check if Category Exist : " & category_name)
                        If categoryRow.Count > 0 Then
                            category_id = categoryRow(0).Item("category_id").ToString
                            If category_id = "" Then
                                dicGeneralCategoryInsert.Add(general_code, category_name)
                            End If
                        Else
                            If category_name <> "" Then
                                setStatus("No Category Found. Consider as new Category.")
                                'sql_insert_category &= String.Format(",('{0}','{0}')", category_name)
                                sql_insert_category &= String.Format("CALL SaveTransaction" &
                                            "('Insert','lib_erp_category','category_id,category_code,category_name'" &
                                            ",'{0}|{1}|{2}|','terms_id','{0}','{3}','{4}','{5}');",
                                            "", category_name, category_name, Environment.MachineName, Environment.UserName, main.log_id)
                                Dim newCategoryRow = dt_category.NewRow
                                newCategoryRow.Item("category_code") = category_name
                                newCategoryRow.Item("category_name") = category_name
                                dt_category.Rows.Add(newCategoryRow)
                                dicGeneralCategoryInsert.Add(general_code, category_name)
                            End If
                        End If
                        setStatus("Check if Industry Exist : " & industry_name)
                        If industryRow.Count > 0 Then
                            industry_id = industryRow(0).Item("industry_id").ToString
                            If industry_id = "" Then
                                dicGeneralIndustryInsert.Add(general_code, industry_name)
                            End If
                        Else
                            If industry_name <> "" Then
                                setStatus("No Industry Found. Consider as new Industry.")
                                'sql_insert_industry &= String.Format(",('{0}','{0}')", industry_name)
                                sql_insert_industry &= String.Format("CALL SaveTransaction" &
                                            "('Insert','lib_erp_industry','industry_id,industry_code,industry_name'" &
                                            ",'{0}|{1}|{2}|','terms_id','{0}','{3}','{4}','{5}');",
                                            "", industry_name, industry_name, Environment.MachineName, Environment.UserName, main.log_id)
                                Dim newIndustryRow = dt_industry.NewRow
                                newIndustryRow.Item("industry_code") = industry_name
                                newIndustryRow.Item("industry_name") = industry_name
                                dt_industry.Rows.Add(newIndustryRow)
                                dicGeneralIndustryInsert.Add(general_code, industry_name)
                            End If
                        End If
                        setStatus("Check if Terms Exist : " & terms_name)
                        If termsRow.Count > 0 Then
                            terms_id = termsRow(0).Item("terms_id").ToString
                            If terms_id = "" Then
                                dicGeneralTermsInsert.Add(general_code, terms_name)
                            End If
                        Else
                            If terms_name <> "" Then
                                setStatus("No Terms Found. Consider as new Terms.")
                                'sql_insert_terms &= String.Format(",('{0}','{0}')", terms_name)
                                sql_insert_terms &= String.Format("CALL SaveTransaction" &
                                            "('Insert','lib_erp_terms','terms_id,terms_code,terms_name'" &
                                            ",'{0}|{1}|{2}|','terms_id','{0}','{3}','{4}','{5}');",
                                            "", terms_name, terms_name, Environment.MachineName, Environment.UserName, main.log_id)
                                Dim newTermsRow = dt_terms.NewRow
                                newTermsRow.Item("terms_code") = terms_name
                                newTermsRow.Item("terms_name") = terms_name
                                dt_terms.Rows.Add(newTermsRow)
                                dicGeneralTermsInsert.Add(general_code, terms_name)
                            End If
                        End If
                        general_ctr += 1
                        sql_update &= String.Format("CALL SaveTransaction" &
                            "('Update','lib_erp_general','general_id,general_code,general_name,date,address1,address2" &
                            ",address3,address4,attention,position,cell_no,tel_no,fax_no,category_id,tin,email_add,website" &
                            ",terms_id,nodays,industry_id,status'" &
                            ",'{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|','general_id','{0}','{21}','{22}','{23}');",
                            general_id, general_code, general_name, general_date, address1, address2, address3, address4, attention,
                            position, cell_no, tel_no, fax_no, category_id,
                            tin, email_add, website, terms_id, nodays,
                            industry_id, status, Environment.MachineName, Environment.UserName, main.log_id)
                        If general_ctr = max_ctr Then
                            If sql_update <> "" Then
                                listUpdateGeneral.Add(sql_update)
                            End If
                            general_ctr = 0
                            sql_update = ""
                        End If
                        'sql_update &= String.Format("UPDATE lib_erp_general SET general_code = '{0}',general_name = '{1}' " & _
                        '    ",date = '{2}',address1 = '{3}',address2 = '{4}',address3 = '{5}',address4 = '{6}' " & _
                        '    ",attention = '{7}',position = '{8}',cell_no = '{9}',tel_no = '{10}',fax_no = '{11}' " & _
                        '    ",category_id = {12},tin = '{13}',email_add = '{14}',website = '{15}',terms_id = {16} " & _
                        '    ",nodays = '{17}',industry_id = {18} " & _
                        '    ",status = '{19}' WHERE general_id = '{20}';" & _
                        '    "",
                        '    general_code, general_name, general_date, address1, address2, address3, address4, attention,
                        '    position, cell_no, tel_no, fax_no, If(category_id = "", "default", "'" & category_id & "'"),
                        '    tin, email_add, website, If(terms_id = "", "default", "'" & terms_id & "'"), nodays,
                        '    If(industry_id = "", "default", "'" & industry_id & "'"), status, general_id)
                    End If
                End If
            Next
            setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" &
                      vbNewLine & "Run The Query")
            If sql_insert <> "" Or listInsertGeneral.Count > 0 Then
                'Dim tmp_str = String.Format("INSERT INTO lib_erp_general(general_code,general_name,date,address1,address2" & _
                '    ",address3,address4,attention,position,cell_no,tel_no,fax_no,category_id,tin,email_add,website" & _
                '    ",terms_id,nodays,industry_id,status) VALUES{0}", sql_insert.Substring(1))
                setStatus("Insert New Account ...")
                For i As Integer = 0 To listInsertGeneral.Count - 1
                    FsQuery(listInsertGeneral(i))
                Next
                If sql_insert <> "" Then
                    FsQuery(sql_insert)
                End If
            End If
            If sql_update <> "" Or listUpdateGeneral.Count > 0 Then
                setStatus("Update Existing Account ...")
                For i As Integer = 0 To listUpdateGeneral.Count - 1
                    FsQuery(listUpdateGeneral(i))
                Next
                If sql_update <> "" Then
                    FsQuery(sql_update)
                End If
            End If
            If sql_insert_category <> "" Then
                'Dim tmp_str = String.Format("INSERT INTO lib_erp_category(category_code,category_name) VALUES{0}", sql_insert_category.Substring(1))
                'setStatus("Insert New Category ...")
                FsQuery(sql_insert_category)
            End If
            If sql_insert_industry <> "" Then
                'Dim tmp_str = String.Format("INSERT INTO lib_erp_industry(industry_code,industry_name) VALUES{0}", sql_insert_industry.Substring(1))
                setStatus("Insert New Industry ...")
                FsQuery(sql_insert_industry)
            End If
            If sql_insert_terms <> "" Then
                'Dim tmp_str = String.Format("INSERT INTO lib_erp_terms(terms_code,terms_name) VALUES{0}", sql_insert_terms.Substring(1))
                setStatus("Insert New Terms ...")
                FsQuery(sql_insert_terms)
            End If
            If dicGeneralCategoryInsert.Count > 0 Then
                setStatus("Insert Category to General ...")
                Dim sql_update_general_category As String = ""
                For Each item In dicGeneralCategoryInsert
                    Dim sql_general_id As String = String.Format("SELECT general_id FROM lib_erp_general WHERE general_code = '{0}'", item.Key)
                    Dim sql_category_id As String = String.Format("SELECT category_id FROM lib_erp_category WHERE category_name = '{0}'", item.Value)
                    Dim dt_general_id As DataTable = FsQuery(sql_general_id)
                    Dim dt_category_id As DataTable = FsQuery(sql_category_id)
                    If dt_general_id.Rows.Count > 0 And dt_category_id.Rows.Count > 0 Then
                        'sql_update_general_category &= String.Format("UPDATE lib_erp_general SET category_id = '{0}' WHERE general_id = '{1}';", dt_category_id.Rows(0).Item("category_id").ToString, dt_general_id.Rows(0).Item("general_id").ToString)
                        sql_update_general_category &= String.Format("CALL SaveTransaction" &
                            "('Update','lib_erp_general','general_id,category_id'" &
                            ",'{0}|{1}|','general_id','{0}','{2}','{3}','{4}');",
                            dt_general_id.Rows(0).Item("general_id").ToString, dt_category_id.Rows.Item("category_id").ToString, Environment.MachineName, Environment.UserName, main.log_id)
                    End If
                Next
                If sql_update_general_category <> "" Then
                    FsQuery(sql_update_general_category)
                End If
            End If
            If dicGeneralIndustryInsert.Count > 0 Then
                setStatus("Insert Industry to General ...")
                Dim sql_update_general_industry As String = ""
                For Each item In dicGeneralIndustryInsert
                    Dim sql_general_id As String = String.Format("SELECT general_id FROM lib_erp_general WHERE general_code = '{0}'", item.Key)
                    Dim sql_industry_id As String = String.Format("SELECT industry_id FROM lib_erp_industry WHERE industry_name = '{0}'", item.Value)
                    Dim dt_general_id As DataTable = FsQuery(sql_general_id)
                    Dim dt_industry_id As DataTable = FsQuery(sql_industry_id)
                    If dt_general_id.Rows.Count > 0 And dt_industry_id.Rows.Count > 0 Then
                        'sql_update_general_industry &= String.Format("UPDATE lib_erp_general SET industry_id = '{0}' WHERE general_id = '{1}';", dt_industry_id.Rows(0).Item("industry_id").ToString, dt_general_id.Rows(0).Item("general_id").ToString)
                        sql_update_general_industry &= String.Format("CALL SaveTransaction" &
                            "('Update','lib_erp_general','general_id,industry_id'" &
                            ",'{0}|{1}|','general_id','{0}','{2}','{3}','{4}');",
                            dt_general_id.Rows(0).Item("general_id").ToString, dt_industry_id.Rows.Item("industry_id").ToString, Environment.MachineName, Environment.UserName, main.log_id)
                    End If
                Next
                If sql_update_general_industry <> "" Then
                    FsQuery(sql_update_general_industry)
                End If
            End If
            If dicGeneralTermsInsert.Count > 0 Then
                setStatus("Insert Terms to General ...")
                Dim sql_update_general_terms As String = ""
                For Each item In dicGeneralTermsInsert
                    Dim sql_general_id As String = String.Format("SELECT general_id FROM lib_erp_general WHERE general_code = '{0}'", item.Key)
                    Dim sql_terms_id As String = String.Format("SELECT terms_id FROM lib_erp_terms WHERE terms_name = '{0}'", item.Value)
                    Dim dt_general_id As DataTable = FsQuery(sql_general_id)
                    Dim dt_terms_id As DataTable = FsQuery(sql_terms_id)
                    If dt_general_id.Rows.Count > 0 And dt_terms_id.Rows.Count > 0 Then
                        'sql_update_general_terms &= String.Format("UPDATE lib_erp_general SET terms_id = '{0}' WHERE general_id = '{1}';", dt_terms_id.Rows(0).Item("terms_id").ToString, dt_general_id.Rows(0).Item("general_id").ToString)
                        sql_update_general_terms &= String.Format("CALL SaveTransaction" &
                            "('Update','lib_erp_general','general_id,terms_id'" &
                            ",'{0}|{1}|','general_id','{0}','{2}','{3}','{4}');",
                            dt_general_id.Rows(0).Item("general_id").ToString, dt_terms_id.Rows.Item("terms_id").ToString, Environment.MachineName, Environment.UserName, main.log_id)
                    End If
                Next
                If sql_update_general_terms <> "" Then
                    'setStatus(sql_update_general_terms, False)
                    FsQuery(sql_update_general_terms)
                End If
            End If

            setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" &
                      vbNewLine & "Number of Warning : " & listWarning.Count, False)
            For Each i In listWarning
                setStatus(i, False)
            Next
            setStatus("Number of Error : " & listError.Count, False)
            For Each i In listError
                setStatus(i, False)
            Next
            If hasError Then
                setStatus("Importation of General Unsuccessfully ..." & "------------------------------------------------------------------------------------------------------------------------------------------------------", False)
            Else
                setStatus("Importation of General Successfully ..." & "------------------------------------------------------------------------------------------------------------------------------------------------------", False)
            End If
        Catch ex As Exception
            setStatus("****************************************************************************************************************" &
                      vbNewLine &
                      "Error : " & ex.Message &
                      "****************************************************************************************************************", False)
        End Try
    End Sub
    Private Sub setStatus(ByVal str As String, Optional withDateTime As Boolean = True)
        If withDateTime Then
            ImportGeneralStatus.txtStatus.AppendText(Now.ToString("[MM/dd/yyyy HH:mm:ss] - ") & str)
        Else
            ImportGeneralStatus.txtStatus.AppendText(str)
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