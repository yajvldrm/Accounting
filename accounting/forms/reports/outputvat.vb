Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class outputvat
    Private module_code As String = "ACC01016"
    Dim ds As New inputoutputvatset
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub toDate_CheckedChanged(sender As Object, e As EventArgs) Handles toDate.CheckedChanged
        Dim tDate As Boolean = toDate.Checked
        If tDate Then
            txt_date_from.Enabled = False
        Else
            txt_date_from.Enabled = True
        End If
    End Sub
    Private Sub rdo_general_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_general_1.CheckedChanged, rdo_general_2.CheckedChanged, rdo_general_3.CheckedChanged
        Dim general As String = getRdoValue(general_filter)
        Select Case general
            Case "1"
                btnImportGeneral.Enabled = False
                txt_general_id.Enabled = False
            Case "2"
                btnImportGeneral.Enabled = True
                txt_general_id.Enabled = False
            Case "3"
                btnImportGeneral.Enabled = False
                txt_general_id.Enabled = True
                txt_general_id.Focus()
        End Select
    End Sub
    Private Sub withProjectDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles withProjectDepartment.CheckedChanged
        Dim wProjDept As Boolean = withProjectDepartment.Checked
        If Not wProjDept Then
            txt_project_id.Value = ""
            txt_project_id.Text = ""
            lbl_project_name.Text = ""
            txt_department_id.Value = ""
            txt_department_id.Text = ""
            lbl_department_name.Text = ""
        End If
    End Sub
    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        Dim data_currency As DataTable = FsQuery("SELECT a.currency_name,a.currency_code,a.currency_id FROM lib_erp_currency a")
        If data_currency.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data_currency.Rows.Count = 1 Then
                dr = data_currency.Rows(0)
            Else
                Dim dra() As DataRow = data_currency.Select("currency_code like '" & txt_currency_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data_currency
                    browse.format("Code,Name", "currency_code,currency_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_currency_id.RowData = dr
                txt_currency_id.Value = dr("currency_id")
                txt_currency_id.Text = dr("currency_code")
                lbl_currency_name.Text = dr("currency_name")
            End If
        End If
    End Sub
    Private Sub txt_project_id_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave
        Dim data As DataTable = FsQuery("SELECT a.project_name,a.project_code,a.project_id FROM lib_erp_project a")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("project_code like '" & txt_project_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "project_code,project_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_project_id.RowData = dr
                txt_project_id.Value = dr("project_id")
                txt_project_id.Text = dr("project_code")
            End If
        End If
    End Sub
    Private Sub txt_department_id_Leave(sender As Object, e As EventArgs) Handles txt_department_id.Leave
        Dim data As DataTable = FsQuery("SELECT a.department_name,a.department_code,a.department_id FROM lib_erp_department a")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("department_code like '" & txt_department_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "department_code,department_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_department_id.RowData = dr
                txt_department_id.Value = dr("department_id")
                txt_department_id.Text = dr("department_code")
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click
        Dim vat As String = getRdoValue(vat_filter)
        Dim general As String = getRdoValue(general_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim date_from As String = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to As String = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim general_id As String = txt_general_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value
        Dim wComparison As Boolean = withComparison.Checked
        Dim wProjectDepartment As Boolean = withProjectDepartment.Checked
        Dim tDate As Boolean = toDate.Checked
        Dim str_general_id As String = ""

        'validation
        If Not tDate Then
            If txt_date_from.Value > txt_date_to.Value Then
                MsgBox("Invalid Date Range.")
                txt_date_from.Focus()
                Exit Sub
            End If
        End If

        Select Case general
            Case "1"
            Case "2"
                Dim sql_general_id As String = String.Format("SELECT GROUP_CONCAT(a.general_id) AS general_id " & _
                    "FROM lib_acc_general_multiple a " & _
                    "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " & _
                    "WHERE a.user_id = '{0}' AND b.module_code = '{1}'", main.user_id, module_code)
                Dim dt_general_id As DataTable = FsQuery(sql_general_id)
                str_general_id = dt_general_id.Rows(0).Item("general_id").ToString
                If str_general_id = "" Then
                    MsgBox("Setup Multiple General First.")
                    Exit Sub
                End If
            Case "3"
                If general_id = "" Then
                    MsgBox("Select General Library First.")
                    Exit Sub
                End If
        End Select

        'query
        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " & _
            ",b.jbooks_id " & _
            ",c.output_vat_id AS vat_id,c.gross_amount,c.vat_amount,c.net_amount,c.gross_amount_based,c.vat_amount_based,c.net_amount_based " & _
            ",d.vat_amount AS ref_vat_amount,d.vat_amount_based AS ref_vat_amount_based " & _
            ",c.offset_type,d.offset_type AS ref_offset_type " & _
            ",c.general_id,f.general_code,f.general_name,f.address1 AS address,f.tin " & _
            ",c.currency_id,h.currency_code,h.currency_name " & _
            ",b.project_id,i.project_code,i.project_name " & _
            ",b.department_id,j.department_code,j.department_name " & _
            "FROM {1}.trans_header a " & _
            "LEFT JOIN {1}.trans_jbooks b ON b.trans_id = a.trans_id " & _
            "LEFT JOIN {1}.trans_output_vat c ON c.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN ( " & _
                " SELECT a.offset_type,a.ref_output_vat_id AS output_vat_id,SUM(a.vat_amount) AS vat_amount,SUM(a.vat_amount_based) AS vat_amount_based " & _
                " FROM {1}.trans_output_vat a " & _
                " GROUP BY a.ref_output_vat_id,a.offset_type " & _
            " ) d ON d.output_vat_id = c.output_vat_id " & _
            "LEFT JOIN {0}.lib_erp_chart e ON e.account_id = b.account_id " & _
            "LEFT JOIN {0}.lib_erp_general f ON f.general_id = c.general_id " & _
            "LEFT JOIN {0}.lib_acc_general_multiple g ON g.general_id = f.general_id " & _
            "LEFT JOIN {0}.lib_erp_currency h ON h.currency_id = c.currency_id " & _
            "LEFT JOIN {0}.lib_erp_project i ON i.project_id = b.project_id " & _
            "LEFT JOIN {0}.lib_erp_department j ON j.department_id = b.department_id ", _serverDBFS, _serverDBMain)

        If Not tDate Then
            sql &= String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)
        Else
            sql &= String.Format(" WHERE a.trans_date <= '{0}' ", date_to)
        End If

        sql &= String.Format(" AND e.validation = 7 AND c.offset_type = 0 ")
        If general = "2" Then
            sql &= String.Format(" AND c.general_id IN ({0}) ", str_general_id)
        End If

        If general = "3" And general_id <> "" Then
            sql &= String.Format(" AND c.general_id = {0} ", general_id)
        End If

        If currency_id <> "" Then
            sql &= String.Format(" AND c.currency_id = {0} ", currency_id)
        End If

        Select Case vat
            Case "1"
            Case "2"
                sql &= String.Format(" AND d.offset_type = 1 ")
            Case "3"
                sql &= String.Format(" AND (d.offset_type = 0 OR d.offset_type IS NULL) ")
            Case "4"
                sql &= String.Format(" AND d.offset_type = 2 ")
        End Select

        If project_id <> "" Then
            sql &= String.Format(" AND b.project_id = {0} ", project_id)
        End If

        If department_id <> "" Then
            sql &= String.Format(" AND b.department_id = {0} ", department_id)
        End If

        sql &= String.Format(" GROUP BY c.output_vat_id ")
        If vat = "2" Or vat = "4" Then
            sql &= String.Format(" ,d.offset_type ")
        End If

        If currency = "2" Then
            sql &= String.Format(" ,c.currency_id ")
        End If

        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name " &
                                                  "FROM {1}.sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                  "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

        Dim dt_balance As DataTable = FsQuery(sql)
        Dim dt_company As DataTable = FsQuery(sql_company)

        ds.Tables("Accounts").Clear()
        ds.Tables("Company").Clear()

        For Each row As DataRow In dt_balance.Rows
            ds.Tables("Accounts").ImportRow(row)
        Next

        For Each row As DataRow In dt_company.Rows
            ds.Tables("Company").ImportRow(row)
        Next

        'reporting
        Dim str_daterange As String = ""
        Dim str_title As String = ""
        Dim str_name As String = "OUTPUT VAT"
        Dim str_columnname As String = ""

        Select Case vat
            Case "1"
                str_title = "Listing of Output VAT"
            Case "2"
                str_title = "Listing of Remitted Output VAT"
                str_columnname = "Amount of Vat. Remitted"
            Case "3"
                str_title = "Listing of Unremitted Output VAT"
                str_columnname = "Amount of Vat. Unremitted"

                For Each row As DataRow In ds.Tables("Accounts").Rows
                    row.Item("ref_vat_amount") = row.Item("vat_amount")
                    row.Item("ref_vat_amount_based") = row.Item("vat_amount_based")
                Next

            Case "4"
                str_title = "Listing of Adjusted Output VAT"
                str_columnname = "Amount of Vat. Adjusted"
        End Select

        If tDate Then
            str_daterange = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        Else
            str_daterange = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        End If

        If currency = "2" And Not wComparison Then
            For Each row As DataRow In ds.Tables("Accounts").Rows
                row.Item("gross_amount") = row.Item("gross_amount_based")
                row.Item("net_amount") = row.Item("net_amount_based")
                row.Item("vat_amount") = row.Item("vat_amount_based")
                row.Item("ref_vat_amount") = row.Item("ref_vat_amount_based")
            Next
        End If

        If sender.name = "btnPrint" Then
            If currency = "2" And wComparison Then
                If vat <> "1" Then
                    Dim rep As New report_input_output_vat_print
                    rep.DataSource = ds
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.Parameters("title").Value = str_title
                    rep.Parameters("name").Value = str_name
                    rep.Parameters("daterange").Value = str_daterange
                    rep.Parameters("columnname").Value = str_columnname
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    If Not wProjectDepartment Then
                        rep.GroupHeader2.Visible = False
                        rep.GroupHeader3.Visible = False
                        rep.GroupFooter2.Visible = False
                        rep.GroupFooter3.Visible = False
                    End If
                    If project_id <> "" Then
                        rep.GroupHeader2.Visible = True
                        rep.GroupFooter2.Visible = True
                    End If
                    If department_id <> "" Then
                        rep.GroupHeader3.Visible = True
                        rep.GroupFooter3.Visible = True
                    End If
                    rep.ReportFooter.Visible = False
                    If Not rep.GroupHeader1.Visible And Not rep.GroupHeader2.Visible And Not rep.GroupHeader3.Visible Then
                        rep.ReportFooter.Visible = True
                    End If
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                Else
                    Dim rep As New report_input_output_vat_print_2
                    rep.DataSource = ds
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.Parameters("title").Value = str_title
                    rep.Parameters("name").Value = str_name
                    rep.Parameters("daterange").Value = str_daterange
                    rep.Parameters("columnname").Value = str_columnname
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    If Not wProjectDepartment Then
                        rep.GroupHeader2.Visible = False
                        rep.GroupHeader3.Visible = False
                        rep.GroupFooter2.Visible = False
                        rep.GroupFooter3.Visible = False
                    End If
                    If project_id <> "" Then
                        rep.GroupHeader2.Visible = True
                        rep.GroupFooter2.Visible = True
                    End If
                    If department_id <> "" Then
                        rep.GroupHeader3.Visible = True
                        rep.GroupFooter3.Visible = True
                    End If
                    rep.ReportFooter.Visible = False
                    If Not rep.GroupHeader1.Visible And Not rep.GroupHeader2.Visible And Not rep.GroupHeader3.Visible Then
                        rep.ReportFooter.Visible = True
                    End If
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                End If
            Else
                If vat <> "1" Then
                    Dim rep As New report_input_output_vat_print_1
                    rep.DataSource = ds
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.Parameters("title").Value = str_title
                    rep.Parameters("name").Value = str_name
                    rep.Parameters("daterange").Value = str_daterange
                    rep.Parameters("columnname").Value = str_columnname
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    If Not wProjectDepartment Then
                        rep.GroupHeader2.Visible = False
                        rep.GroupHeader3.Visible = False
                        rep.GroupFooter2.Visible = False
                        rep.GroupFooter3.Visible = False
                    End If
                    If project_id <> "" Then
                        rep.GroupHeader2.Visible = True
                        rep.GroupFooter2.Visible = True
                    End If
                    If department_id <> "" Then
                        rep.GroupHeader3.Visible = True
                        rep.GroupFooter3.Visible = True
                    End If
                    If currency = "1" Then
                        rep.GroupHeader1.Visible = False
                        rep.GroupFooter1.Visible = False
                    End If
                    If currency_id <> "" Then
                        rep.GroupHeader1.Visible = True
                        rep.GroupFooter1.Visible = True
                    End If
                    rep.ReportFooter.Visible = False
                    If Not rep.GroupHeader1.Visible And Not rep.GroupHeader2.Visible And Not rep.GroupHeader3.Visible Then
                        rep.ReportFooter.Visible = True
                    End If
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                Else
                    Dim rep As New report_input_output_vat_print_3
                    rep.DataSource = ds
                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.Parameters("title").Value = str_title
                    rep.Parameters("name").Value = str_name
                    rep.Parameters("daterange").Value = str_daterange
                    rep.Parameters("columnname").Value = str_columnname
                    rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                    If Not wProjectDepartment Then
                        rep.GroupHeader2.Visible = False
                        rep.GroupHeader3.Visible = False
                        rep.GroupFooter2.Visible = False
                        rep.GroupFooter3.Visible = False
                    End If
                    If project_id <> "" Then
                        rep.GroupHeader2.Visible = True
                        rep.GroupFooter2.Visible = True
                    End If
                    If department_id <> "" Then
                        rep.GroupHeader3.Visible = True
                        rep.GroupFooter3.Visible = True
                    End If
                    If currency = "1" Then
                        rep.GroupHeader1.Visible = False
                        rep.GroupFooter1.Visible = False
                    End If
                    If currency_id <> "" Then
                        rep.GroupHeader1.Visible = True
                        rep.GroupFooter1.Visible = True
                    End If
                    rep.ReportFooter.Visible = False
                    If Not rep.GroupHeader1.Visible And Not rep.GroupHeader2.Visible And Not rep.GroupHeader3.Visible Then
                        rep.ReportFooter.Visible = True
                    End If
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                End If
            End If
        Else
            Dim dicHeader As New Dictionary(Of String, String)
            dicHeader.Add("companyName", "")
            Dim templateName As String = ""
            If dt_company.Rows.Count > 0 Then
                dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
            End If
            Dim strGrouping As String = "currency_name"
            If wProjectDepartment Then
                strGrouping &= ",project_name,department_name"
            End If
            Dim listAccount = groupDataTableToList(ds.Tables("Accounts"), strGrouping)
            If vat = "5" Then
                templateName = "sales_vat.xlt"
                Try
                    lblLoad.Visible = True
                    excelSalesVat(templateName)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            ElseIf vat = "1" Then
                If currency = "2" Then
                    templateName = "inputoutputvat3.xlt"
                    Try
                        lblLoad.Visible = True
                        excelinputoutput3(listAccount, strGrouping, dicHeader, templateName, str_title, str_daterange)
                        MsgBox("Report Done")
                        lblLoad.Visible = False
                    Catch ex As Exception
                        lblLoad.Visible = False
                        MsgBox(String.Format("Error Occured : {0}", ex.Message))
                        MyDebugging.AddText(ex.Message)
                    End Try
                    'MsgBox("Data Succesfully Load")
                Else
                    templateName = "inputoutputvat4.xlt"
                    Try
                        lblLoad.Visible = True
                        excelinputoutput4(listAccount, strGrouping, dicHeader, templateName, str_title, str_daterange)
                        MsgBox("Report Done")
                        lblLoad.Visible = False
                    Catch ex As Exception
                        lblLoad.Visible = False
                        MsgBox(String.Format("Error Occured : {0}", ex.Message))
                        MyDebugging.AddText(ex.Message)
                    End Try
                    'MsgBox("Data Succesfully Load")
                End If
            Else
                If currency = "2" Then
                    templateName = "inputoutputvat.xlt"
                    Try
                        lblLoad.Visible = True
                        excelinputoutput(listAccount, strGrouping, dicHeader, templateName, str_title, str_daterange, str_columnname)
                        MsgBox("Report Done")
                        lblLoad.Visible = False
                    Catch ex As Exception
                        lblLoad.Visible = False
                        MsgBox(String.Format("Error Occured : {0}", ex.Message))
                        MyDebugging.AddText(ex.Message)
                    End Try
                    'MsgBox("Data Succesfully Load")
                Else
                    templateName = "inputoutputvat2.xlt"
                    Try
                        lblLoad.Visible = True
                        excelinputoutput2(listAccount, strGrouping, dicHeader, templateName, str_title, str_daterange, str_columnname)
                        MsgBox("Report Done")
                        lblLoad.Visible = False
                    Catch ex As Exception
                        lblLoad.Visible = False
                        MsgBox(String.Format("Error Occured : {0}", ex.Message))
                        MyDebugging.AddText(ex.Message)
                    End Try
                    'MsgBox("Data Succesfully Load")
                End If
            End If
        End If
    End Sub
    Private Sub excelSalesVat(ByVal templateName As String)
        Dim date_from As String = txt_date_from.Value.ToString("yyyy-MM-dd")
        Dim date_to As String = txt_date_to.Value.ToString("yyyy-MM-dd")
        Dim vat As String = getRdoValue(vat_filter)
        Dim tDate As Boolean = toDate.Checked

        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " & _
            ",b.jbooks_id " & _
            ",c.output_vat_id AS vat_id,c.gross_amount,c.vat_amount,c.net_amount,c.gross_amount_based,c.vat_amount_based,c.net_amount_based " & _
            ",d.vat_amount AS ref_vat_amount,d.vat_amount_based AS ref_vat_amount_based " & _
            ",c.offset_type,d.offset_type AS ref_offset_type " & _
            ",c.general_id,f.general_code,f.general_name,f.address1 AS address,f.tin " & _
            ",c.currency_id,h.currency_code,h.currency_name " & _
            ",b.project_id,i.project_code,i.project_name " & _
            ",b.department_id,j.department_code,j.department_name " & _
            "FROM {1}.trans_header a " & _
            "LEFT JOIN {1}.trans_jbooks b ON b.trans_id = a.trans_id " & _
            "LEFT JOIN {1}.trans_output_vat c ON c.jbooks_id = b.jbooks_id " & _
            "LEFT JOIN ( " & _
                " SELECT a.offset_type,a.ref_output_vat_id AS output_vat_id,SUM(a.vat_amount) AS vat_amount,SUM(a.vat_amount_based) AS vat_amount_based " & _
                " FROM {1}.trans_output_vat a " & _
                " GROUP BY a.ref_output_vat_id,a.offset_type " & _
            " ) d ON d.output_vat_id = c.output_vat_id " & _
            "LEFT JOIN {0}.lib_erp_chart e ON e.account_id = b.account_id " & _
            "LEFT JOIN {0}.lib_erp_general f ON f.general_id = c.general_id " & _
            "LEFT JOIN {0}.lib_acc_general_multiple g ON g.general_id = f.general_id " & _
            "LEFT JOIN {0}.lib_erp_currency h ON h.currency_id = c.currency_id " & _
            "LEFT JOIN {0}.lib_erp_project i ON i.project_id = b.project_id " & _
            "LEFT JOIN {0}.lib_erp_department j ON j.department_id = b.department_id ", _serverDBFS, _serverDBMain)

        If Not tDate Then
            sql &= String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}' ", date_from, date_to)
        Else
            sql &= String.Format(" WHERE a.trans_date <= '{0}' ", date_to)
        End If

        sql &= String.Format(" AND e.validation = 7 AND c.offset_type = 0 ")
        sql &= String.Format(" GROUP BY c.output_vat_id ")

        Dim dt As DataTable = FsQuery(sql)
        ds.Tables("Accounts").Clear()

        For Each row As DataRow In dt.Rows
            ds.Tables("Accounts").ImportRow(row)
        Next

        Dim str_daterange As String = ""
        Dim str_title As String = "Reconciliation of Listing for Enforcement"

        If tDate Then
            str_daterange = "As of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        Else
            str_daterange = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " to " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        End If

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim first_row As Integer = 9
        Dim current_row As Integer = 9
        Dim current_index As Integer = 0

        xlWorkSheet.Cells(1, 1) = "SALES TRANSACTION"
        xlWorkSheet.Cells(2, 1) = str_title
        xlWorkSheet.Cells(4, 1) = "TIN: " & main.Sys_Default.Rows(0).Item("tin")
        xlWorkSheet.Cells(5, 1) = "OWNER'S NAME: " & main.Sys_Default.Rows(0).Item("company_name")
        xlWorkSheet.Cells(6, 1) = "OWNER'S TRADE NAME: " & main.Sys_Default.Rows(0).Item("company_name")
        xlWorkSheet.Cells(7, 1) = "OWNER'S ADDRESS: " & main.Sys_Default.Rows(0).Item("address1")

        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = row.Item("trans_date")
            xlWorkSheet.Cells(current_row, 2) = row.Item("tin")
            xlWorkSheet.Cells(current_row, 3) = row.Item("general_name")
            xlWorkSheet.Cells(current_row, 4) = ""
            xlWorkSheet.Cells(current_row, 5) = row.Item("address")
            xlWorkSheet.Cells(current_row, 6) = row.Item("net_amount")
            xlWorkSheet.Cells(current_row, 7) = ""
            xlWorkSheet.Cells(current_row, 8) = ""
            xlWorkSheet.Cells(current_row, 9) = row.Item("net_amount")
            xlWorkSheet.Cells(current_row, 10) = row.Item("vat_amount")
            xlWorkSheet.Cells(current_row, 11) = row.Item("gross_amount")
            current_row += 1
        Next

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        current_row += 1
    End Sub
    Private Sub excelinputoutput(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByVal templateName As String, ByVal str_title As String, ByVal str_daterange As String, ByVal str_columnname As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = "OUTPUT VAT"
        xlWorkSheet.Cells(3, 1) = str_title
        xlWorkSheet.Cells(4, 1) = str_daterange
        xlWorkSheet.Cells(6, 9) = str_columnname
        xlWorkSheet.Cells(6, 13) = str_columnname

        Dim first_row As Integer = 7
        Dim current_row As Integer = 7
        Dim current_index As Integer = 0
        reportinputoutput(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        current_row += 1
    End Sub
    Private Sub reportinputoutput(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer, Optional wCompare As Boolean = False, Optional originalCurrency As Boolean = False)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        current_index += 1
        For Each item In listAccount
            Dim dicItem = Nothing
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field
                    Case "currency_name"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        reportinputoutput(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_row, current_index, originalCurrency)
                        current_index -= 1
                    Case Else
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                        reportinputoutput(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_row, current_index, originalCurrency)
                        current_index -= 1
                End Select
            Else
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                current_row += 1

                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("tin")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("general_name")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("address")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("gross_amount")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("vat_amount")
                    xlWorkSheet.Cells(current_row, 8) = dic.Item("net_amount")
                    xlWorkSheet.Cells(current_row, 9) = dic.Item("ref_vat_amount")

                    xlWorkSheet.Cells(current_row, 10) = dic.Item("gross_amount_based")
                    xlWorkSheet.Cells(current_row, 11) = dic.Item("vat_amount_based")
                    xlWorkSheet.Cells(current_row, 12) = dic.Item("net_amount_based")
                    xlWorkSheet.Cells(current_row, 13) = dic.Item("ref_vat_amount_based")
                    current_row += 1

                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 12) = String.Format("=SUBTOTAL(9,L{0}:L{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 13) = String.Format("=SUBTOTAL(9,M{0}:M{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                current_row += 1
            End If
        Next
    End Sub
    Private Sub excelinputoutput2(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByVal templateName As String, ByVal str_title As String, ByVal str_daterange As String, ByVal str_columnname As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = "OUTPUT VAT"
        xlWorkSheet.Cells(3, 1) = str_title
        xlWorkSheet.Cells(4, 1) = str_daterange
        xlWorkSheet.Cells(5, 9) = str_columnname

        Dim first_row As Integer = 6
        Dim current_row As Integer = 6
        Dim current_index As Integer = 0
        reportinputoutput2(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        current_row += 1
    End Sub
    Private Sub reportinputoutput2(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer, Optional originalCurrency As Boolean = False)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        current_index += 1
        For Each item In listAccount
            Dim dicItem = Nothing
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field
                    Case "currency_name"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        reportinputoutput(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_row, current_index, originalCurrency)
                        current_index -= 1
                    Case Else
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                        reportinputoutput(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_row, current_index, originalCurrency)
                        current_index -= 1
                End Select
            Else
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("tin")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("general_name")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("address")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("gross_amount")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("vat_amount")
                    xlWorkSheet.Cells(current_row, 8) = dic.Item("net_amount")
                    xlWorkSheet.Cells(current_row, 9) = dic.Item("ref_vat_amount")
                    current_row += 1

                Next
            End If
        Next
    End Sub
    Private Sub excelinputoutput3(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByVal templateName As String, ByVal str_title As String, ByVal str_daterange As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = "OUTPUT VAT"
        xlWorkSheet.Cells(3, 1) = str_title
        xlWorkSheet.Cells(4, 1) = str_daterange

        Dim first_row As Integer = 7
        Dim current_row As Integer = 7
        Dim current_index As Integer = 0
        reportinputoutput3(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        current_row += 1
    End Sub
    Private Sub reportinputoutput3(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer, Optional originalCurrency As Boolean = False)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        current_index += 1
        For Each item In listAccount
            Dim dicItem = Nothing
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field
                    Case "currency_name"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        reportinputoutput(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_row, current_index, originalCurrency)
                        current_index -= 1
                    Case Else
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                        reportinputoutput(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_row, current_index, originalCurrency)
                        current_index -= 1
                End Select
            Else
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                current_row += 1

                Dim first_row As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("tin")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("general_name")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("address")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("gross_amount")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("vat_amount")
                    xlWorkSheet.Cells(current_row, 8) = dic.Item("net_amount")

                    xlWorkSheet.Cells(current_row, 9) = dic.Item("gross_amount_based")
                    xlWorkSheet.Cells(current_row, 10) = dic.Item("vat_amount_based")
                    xlWorkSheet.Cells(current_row, 11) = dic.Item("net_amount_based")
                    current_row += 1

                Next
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field) & " : "
                xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
                xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 10) = String.Format("=SUBTOTAL(9,J{0}:J{1})", first_row, current_row - 1)
                xlWorkSheet.Cells(current_row, 11) = String.Format("=SUBTOTAL(9,K{0}:K{1})", first_row, current_row - 1)
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 11)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                current_row += 1
            End If
        Next
    End Sub
    Private Sub excelinputoutput4(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByVal templateName As String, ByVal str_title As String, ByVal str_daterange As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = "OUTPUT VAT"
        xlWorkSheet.Cells(3, 1) = str_title
        xlWorkSheet.Cells(4, 1) = str_daterange

        Dim first_row As Integer = 6
        Dim current_row As Integer = 6
        Dim current_index As Integer = 0
        reportinputoutput4(xlWorkSheet, listAccount, strCol, dicHeader, current_index, current_row)

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 6) = String.Format("=SUBTOTAL(9,F{0}:F{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 7) = String.Format("=SUBTOTAL(9,G{0}:G{1})", first_row, current_row - 1)
        xlWorkSheet.Cells(current_row, 8) = String.Format("=SUBTOTAL(9,H{0}:H{1})", first_row, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Interior.Color = System.Drawing.Color.FromArgb(192, 255, 192)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
        current_row += 1
    End Sub
    Private Sub reportinputoutput4(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHeader As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer, Optional originalCurrency As Boolean = False)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        current_index += 1
        For Each item In listAccount
            Dim dicItem = Nothing
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field
                    Case "currency_name"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        reportinputoutput(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_row, current_index, originalCurrency)
                        current_index -= 1
                    Case Else
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 4
                        reportinputoutput(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHeader, current_row, current_index, originalCurrency)
                        current_index -= 1
                End Select
            Else
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If

                    xlWorkSheet.Cells(current_row, 1) = dic.Item("trans_no")
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("trans_date")
                    xlWorkSheet.Cells(current_row, 3) = dic.Item("tin")
                    xlWorkSheet.Cells(current_row, 4) = dic.Item("general_name")
                    xlWorkSheet.Cells(current_row, 5) = dic.Item("address")
                    xlWorkSheet.Cells(current_row, 6) = dic.Item("gross_amount")
                    xlWorkSheet.Cells(current_row, 7) = dic.Item("vat_amount")
                    xlWorkSheet.Cells(current_row, 8) = dic.Item("net_amount")
                    current_row += 1

                Next
            End If
        Next
    End Sub
    Private Sub rdo_currency_1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_currency_1.CheckedChanged, rdo_currency_2.CheckedChanged
        Dim currency As String = getRdoValue(currency_filter)
        withComparison.Enabled = False
        If currency = "2" Then
            withComparison.Enabled = True
        End If
    End Sub
    Private Sub btnImportGeneral_Click(sender As Object, e As EventArgs) Handles btnImportGeneral.Click
        multiplegeneralsetup.ModuleCode = module_code
        multiplegeneralsetup.ShowDialog()
    End Sub
    Private Sub txt_general_id_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_general ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("general_code like '" & txt_general_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "general_code,general_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_general_id.RowData = dr
                txt_general_id.Value = dr("general_id")
                txt_general_id.Text = dr("general_code")
                lbl_general_name.Text = dr("general_name")
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        If txt_date_to.Value < txt_date_from.Value Then
            MsgBox("Invalid Date Range.")
            Exit Sub
        End If
        Dim _printoption As New reportoption
        _printoption.targetForm = Me
        _printoption.Label1.Hide()
        _printoption.cbo_sort.Hide()
        If rdo_vat_5.Checked Then
            _printoption.Rdo_button2.Enabled = False
            _printoption.Rdo_button1.Checked = True
        End If
        _printoption.ShowDialog()
        If _printoption.DialogResult = Windows.Forms.DialogResult.OK Then
            If _printoption.PrintOption = "1" Then
                btnPrint_Click(btnExcel, Nothing)
            Else
                btnPrint_Click(btnPrint, Nothing)
            End If
        End If
    End Sub
    Private Sub rdo_vat_5_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_vat_5.CheckedChanged
        If rdo_vat_5.Checked = True Then
            general_filter.Enabled = False
            currency_filter.Enabled = False
            project_department_filter.Enabled = False
        Else
            general_filter.Enabled = True
            currency_filter.Enabled = True
            project_department_filter.Enabled = True
        End If
    End Sub
    Private Sub outputvat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.Value = New Date(Today.Year, 1, 1)
        txt_date_to.Value = Today
    End Sub
End Class