Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI

Public Class ewtreport
    Dim ds As New finalewtset
    Dim isGeneral As Boolean = False
    Private module_code As String = "ACC01017"
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub ewtreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_month.Value = DateTime.Today.ToString("MM")
        txt_year.Value = DateTime.Today.ToString("yyyy")
    End Sub
    Private Sub txt_filter_option_Leave(sender As Object, e As EventArgs) Handles txt_filter_option.Leave
        Dim data As DataTable = FsQuery("SELECT '1' AS id,'Detailed List of Withholding for the Month' AS name " &
            "UNION SELECT '8','Detailed List of Withholding Quarterly' " &
                                        "UNION SELECT '2','Detailed List of Remitted for the Month' " &
            "UNION SELECT '9','Detailed List of Remitted Quarterly' " &
                                        "UNION SELECT '3','Alphalist of Payees Subject to Expanded Withholding Tax (Year End)' " &
                                        "UNION SELECT '4','Alphalist of Payees Subject to Expanded Withholding Tax (Month End)' " &
                                        "UNION SELECT '5','Alphalist Quarterly' " &
                                        "UNION SELECT '6','Alphalist Annually' " &
                                        "UNION SELECT '7','Alphabetical List of Payees from whome Taxes were Withheld' ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & txt_filter_option.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Name", "name", "450")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_filter_option.RowData = dr
                txt_filter_option.Value = dr("id")
                txt_filter_option.Text = dr("name")
                quarter_filter.Visible = False
                by_filter.Visible = False
                btnDiskette.Enabled = False
                Select Case dr("id")
                    Case "2"
                        btnDiskette.Enabled = True
                    Case "5"
                        quarter_filter.Visible = True
                    Case "6"
                        by_filter.Visible = True
                    Case "8"
                        quarter_filter.Visible = True
                    Case "9"
                        quarter_filter.Visible = True

                End Select
            End If
        End If
    End Sub
    Private Sub txt_print_option_Leave(sender As Object, e As EventArgs) Handles txt_print_option.Leave
        Dim data As New DataTable
        Dim filter_id As String = txt_filter_option.Value
        If filter_id = "1" Then
            data = FsQuery("SELECT '1' AS id,'All EWT Code' AS name " &
                            "UNION SELECT '2','All EWT Code Grouped Per EWT' " &
                            "UNION SELECT '3','All EWT Code Total Per Supplier' " &
                            "UNION SELECT '4','All Supplier' " &
                            "UNION SELECT '5','Per EWT Code' " &
                            "UNION SELECT '6','Per EWT Code Total Per Supplier' " &
                            "UNION SELECT '7','Per Supplier' " &
                            " ")
        Else
            data = FsQuery("SELECT '1' AS id,'All EWT Code' AS name " &
                            "UNION SELECT '2','All EWT Code Total Per Supplier' " &
                            "UNION SELECT '3','All Supplier' " &
                            "UNION SELECT '4','Per EWT Code' " &
                            "UNION SELECT '5','Per EWT Code Total Per Supplier' " &
                            "UNION SELECT '6','Per Supplier' " &
                            " ")
        End If
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & txt_print_option.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Name", "name", "300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_print_option.RowData = dr
                txt_print_option.Value = dr("id")
                txt_print_option.Text = dr("name")
                If filter_id = "1" Then
                    Select Case dr("id")
                        Case "1", "2", "3"
                            txt_ewt_id.Enabled = False
                            lbl_ewt.Text = "EWT"
                        Case "4"
                            txt_ewt_id.Enabled = False
                            lbl_ewt.Text = "Supplier"
                        Case "5"
                            isGeneral = False
                            txt_ewt_id.Enabled = True
                            lbl_ewt.Text = "EWT"
                        Case "6"
                            isGeneral = False
                            txt_ewt_id.Enabled = True
                            lbl_ewt.Text = "EWT"
                        Case "7"
                            isGeneral = True
                            txt_ewt_id.Enabled = True
                            lbl_ewt.Text = "Supplier"
                    End Select
                Else
                    Select Case dr("id")
                        Case "1", "2", "3"
                            isGeneral = False
                            txt_ewt_id.Enabled = False
                            lbl_ewt.Text = "EWT"
                        Case "4", "5"
                            isGeneral = False
                            txt_ewt_id.Enabled = True
                            lbl_ewt.Text = "EWT"
                        Case "6"
                            isGeneral = True
                            txt_ewt_id.Enabled = True
                            lbl_ewt.Text = "Supplier"
                    End Select
                End If
            End If
        End If
    End Sub
    'Private Sub Generate_excel_reports_2307()
    '    Try
    '        Dim Month As DateTime.ToString("")
    '        Dim year As DateTime
    '        Dim company As DataRow = ds.Tables("Company").Rows(0)
    '        Dim ewt As DataTable = ds.Tables("EWT")

    '        Dim tin() As String = company.Item("tin").ToString.Split({"-"}, StringSplitOptions.RemoveEmptyEntries)

    '        Dim xlApp As Excel.Application
    '        Dim xlWorkBook As Excel.Workbook
    '        Dim xlWorkSheet As Excel.Worksheet
    '        Dim xlShape As Excel.Shape = Nothing

    '        xlApp = New Excel.Application
    '        xlWorkBook = xlApp.Workbooks.Open(templates & "\2307.xlt")
    '        xlApp.Visible = True
    '        xlWorkSheet = xlWorkBook.Worksheets(2)

    '        'Month
    '        xlShape = xlWorkSheet.Shapes.Item("Textbox 2")
    '        xlShape.TextFrame.Characters.Text = month() + " " + year()
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter





    '        'TIN
    '        If company.Item("tin").ToString.Trim() <> "" And tin.Length = 4 Then

    '            'Tin no 1
    '            xlShape = xlWorkSheet.Shapes.Item("Rectangle 42")
    '            xlShape.TextFrame.Characters.Text = tin(0)
    '            xlShape.TextEffect.FontBold = True
    '            xlShape.TextFrame.MarginTop = "0"
    '            xlShape.TextFrame.MarginRight = "0"
    '            xlShape.TextFrame.MarginBottom = "0"
    '            xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '            xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '            'Tin no 2
    '            xlShape = xlWorkSheet.Shapes.Item("Rectangle 40")
    '            xlShape.TextFrame.Characters.Text = tin(1)
    '            xlShape.TextEffect.FontBold = True
    '            xlShape.TextFrame.MarginTop = "0"
    '            xlShape.TextFrame.MarginRight = "0"
    '            xlShape.TextFrame.MarginBottom = "0"
    '            xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '            xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '            'Tin no 3
    '            xlShape = xlWorkSheet.Shapes.Item("Rectangle 39")
    '            xlShape.TextFrame.Characters.Text = tin(2)
    '            xlShape.TextEffect.FontBold = True
    '            xlShape.TextFrame.MarginTop = "0"
    '            xlShape.TextFrame.MarginRight = "0"
    '            xlShape.TextFrame.MarginBottom = "0"
    '            xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '            xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '            'Tin no 4
    '            xlShape = xlWorkSheet.Shapes.Item("Rectangle 37")
    '            xlShape.TextFrame.Characters.Text = tin(3)
    '            xlShape.TextEffect.FontBold = True
    '            xlShape.TextFrame.MarginTop = "0"
    '            xlShape.TextFrame.MarginRight = "0"
    '            xlShape.TextFrame.MarginBottom = "0"
    '            xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '            xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        End If

    '        'RDO Code
    '        xlShape = xlWorkSheet.Shapes.Item("Rectangle 46")
    '        xlShape.TextFrame.Characters.Text = company.Item("rdo_code")
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        'Company Name
    '        xlShape = xlWorkSheet.Shapes.Item("Rectangle 47")
    '        xlShape.TextFrame.Characters.Text = company.Item("company_name")
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    '        'Telephone Number
    '        xlShape = xlWorkSheet.Shapes.Item("Rectangle 21")
    '        xlShape.TextFrame.Characters.Text = company.Item("tel_no")
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        'Address
    '        xlShape = xlWorkSheet.Shapes.Item("Rectangle 165")
    '        xlShape.TextFrame.Characters.Text = company.Item("address")
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    '        'Signatory Name
    '        xlShape = xlWorkSheet.Shapes.Item("Text Box 488")
    '        xlShape.TextFrame.Characters.Text = signatory_name
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        'Signatory Position
    '        xlShape = xlWorkSheet.Shapes.Item("Text Box 489")
    '        xlShape.TextFrame.Characters.Text = signatory_position
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        Dim r As Integer = 29
    '        For Each row As DataRow In ewt.Rows
    '            xlWorkSheet.Cells(r, 1) = row.Item("ewt_name").ToString
    '            xlWorkSheet.Cells(r, 18) = row.Item("ewt_code").ToString
    '            xlWorkSheet.Cells(r, 21) = String.Format("{0:##,##0.00}", row.Item("amount_based"))
    '            xlWorkSheet.Cells(r, 25) = String.Format("{0:#}%", row.Item("tax_rate"))
    '            xlWorkSheet.Cells(r, 27) = String.Format("{0:##,##0.00}", row.Item("tax_amount_based"))
    '            xlWorkSheet.Rows.WrapText = False
    '            r += 1
    '        Next

    '    Catch ex As Exception

    '    End Try

    'End Sub
    Private Sub txt_ewt_id_Leave(sender As Object, e As EventArgs) Handles txt_ewt_id.Leave
        Dim sql As String = ""
        If isGeneral Then
            sql = String.Format("SELECT general_id AS id,general_code AS code,general_name AS name FROM {0}.lib_erp_general", _serverDBFS)
        Else
            sql = String.Format("SELECT ewt_id AS id,ewt_code AS code,ewt_name AS name FROM {0}.lib_acc_ewt", _serverDBFS)
        End If
        Dim data As DataTable = FsQuery(sql)
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("code like '" & txt_ewt_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "code,name", "100,400")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_ewt_id.RowData = dr
                txt_ewt_id.Value = dr("id")
                txt_ewt_id.Text = dr("code")
            End If
        End If
    End Sub
    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        Dim data As DataTable = FsQuery(String.Format("SELECT * FROM {0}.lib_erp_currency ", _serverDBFS))
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("currency_code like '" & txt_currency_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
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
                    browse.format("Code,Name", "project_code,project_name", "200,400")
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
                    browse.format("Code,Name", "department_code,department_name", "200,400")
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
    Private Sub rdo_currency_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_currency_1.CheckedChanged, rdo_currency_2.CheckedChanged
        Dim currency As String = getRdoValue(currency_filter)
        withComparison.Enabled = False
        If currency = "2" Then
            withComparison.Enabled = True
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnDiskette.Click
        Dim quarter As String = getRdoValue(quarter_filter)
        Dim by As String = getRdoValue(by_filter)
        Dim currency As String = getRdoValue(currency_filter)
        Dim filter_id As String = txt_filter_option.Value
        Dim print As String = txt_print_option.Value
        Dim ewt_id As String = txt_ewt_id.Value
        Dim currency_id As String = txt_currency_id.Value
        Dim project_id As String = txt_project_id.Value
        Dim department_id As String = txt_department_id.Value
        Dim month As String = txt_month.Value
        Dim year As String = txt_year.Value
        Dim wProjectDepartment As Boolean = withProjectDepartment.Checked
        Dim wComparison As Boolean = withComparison.Checked
        Dim sql_where As String = ""

        If filter_id = "" Then
            MsgBox("Select Report Filter First.")
            txt_filter_option.Focus()
            Exit Sub
        End If
        If print = "" Then
            MsgBox("Select Print Option First.")
            txt_print_option.Focus()
            Exit Sub
        End If

        Select Case filter_id
            Case "1"
            Case "2"
            Case "3", "4", "5", "6"
                MsgBox("No Records To Print.")
                Exit Sub
        End Select

        Select Case print
            Case "5", "6", "7"
                If ewt_id = "" Then
                    MsgBox("Select EWT First.")
                    txt_ewt_id.Focus()
                    Exit Sub
                End If
        End Select

        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " &
            ",c.offset_type,c.ewt_id,c.amount,c.tax_amount,c.amount_based,c.tax_amount_based " &
            ",c.fs_ewt_id,e.ewt_code,e.ewt_name,e.tax_rate " &
            ",c.general_id,f.general_code,f.general_name,'' AS rdo_code " &
            ",c.currency_id,g.currency_code,g.currency_name " &
            ",b.project_id,h.project_code,h.project_name " &
            ",b.department_id,i.department_code,i.department_name " &
            ",d.offset_type AS ref_offset_type,d.amount AS ref_amount,d.tax_amount AS ref_tax_amount,d.amount_based AS ref_amount_based,d.tax_amount_based AS ref_tax_amount_based " &
            ",d.trans_no AS dn_ref " &
            "FROM {1}.trans_header a " &
            "LEFT JOIN {1}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "LEFT JOIN {1}.trans_ewt c ON c.jbooks_id = b.jbooks_id " &
            "LEFT JOIN (" &
                "SELECT a.offset_type,a.ref_ewt_id AS ewt_id,SUM(a.amount) AS amount,SUM(a.tax_amount) AS tax_amount,SUM(a.amount_based) AS amount_based,SUM(a.tax_amount_based) AS tax_amount_based,c.trans_no " &
                "FROM {1}.trans_ewt a " &
                "LEFT JOIN {1}.trans_jbooks b ON b.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {1}.trans_header c ON c.trans_id = b.trans_id " &
                "GROUP BY a.ref_ewt_id,a.offset_type " &
            ") d ON d.ewt_id = c.ewt_id " &
            "LEFT JOIN {0}.lib_acc_ewt e ON e.ewt_id = c.fs_ewt_id " &
            "LEFT JOIN {0}.lib_erp_general f ON f.general_id = c.general_id " &
            "LEFT JOIN {0}.lib_erp_currency g ON g.currency_id = c.currency_id " &
            "LEFT JOIN {0}.lib_erp_project h ON h.project_id = b.project_id " &
            "LEFT JOIN {0}.lib_erp_department i ON i.department_id = b.department_id " &
            "LEFT JOIN {0}.lib_erp_chart j ON j.account_id = b.account_id ", _serverDBFS, _serverDBMain)
        If filter_id = "1" Or filter_id = "2" Then
            sql_where &= String.Format("  AND DATE_FORMAT(a.trans_date,'%c-%Y') = '{0}-{1}' ", month, year)
            If filter_id = "2" Then
                sql_where &= String.Format(" AND (d.offset_type <> 0 OR d.offset_type IS NOT NULL) ")
            End If
        End If

        sql_where &= String.Format(" AND j.validation = 4 AND c.offset_type = 0 ")
        If filter_id = "1" Then
            Select Case print
                Case "1"
                Case "2"
                Case "3", "4"
                Case "5", "6"
                    sql_where &= String.Format(" AND c.fs_ewt_id = {0} ", ewt_id)
                Case "7"
                    sql_where &= String.Format(" AND c.general_id = {0} ", ewt_id)
            End Select
        Else
            sql_where &= String.Format(" AND d.offset_type = 1 ")
            Select Case print
                Case "1"
                Case "2"
                Case "2"
                Case "4", "5"
                    sql_where &= String.Format(" AND c.fs_ewt_id = {0} ", ewt_id)
                Case "6"
                    sql_where &= String.Format(" AND c.general_id = {0} ", ewt_id)
            End Select
        End If
        If sql_where <> "" Then
            sql &= " WHERE " & sql_where.Substring(5)
        End If

        sql &= String.Format(" GROUP BY c.ewt_id ")
        Select Case filter_id
            Case "2"
                sql &= String.Format(" ,d.offset_type ")
        End Select

        If currency = "2" Then
            sql &= String.Format(" ,c.currency_id ")
        End If

        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,c.currency_name,b.rdo_code " &
                                                  "FROM {1}.sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                  "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)

        Dim dt_balance As DataTable = FsQuery(sql)
        Dim dt_company As DataTable = FsQuery(sql_company)

        If dt_balance.Rows.Count = 0 Then
            MsgBox("No Records to Print.")
            Exit Sub
        End If

        ds.Tables("Accounts").Clear()
        ds.Tables("Company").Clear()

        For Each row As DataRow In dt_balance.Rows
            ds.Tables("Accounts").ImportRow(row)
        Next
        For Each row As DataRow In dt_company.Rows
            ds.Tables("Company").ImportRow(row)
        Next

        'reporting
        If currency = "2" And Not wComparison Then
            For Each row As DataRow In ds.Tables("Accounts").Rows
                row.Item("amount") = row.Item("amount_based")
                row.Item("tax_amount") = row.Item("tax_amount_based")
                row.Item("ref_amount") = row.Item("ref_amount_based")
                row.Item("ref_tax_amount") = row.Item("ref_tax_amount_based")
            Next
        End If

        Dim str_daterange As String = ""
        Dim str_title As String = ""
        Dim str_name As String = "EXPANDED WITHHOLDING TAX"
        Dim str_columnname As String = ""

        Select Case filter_id
            Case "1"
                str_title = "Expanded Withholding Tax Withheld"
                str_daterange = "For the Month of " & MonthName(month) & " " & year
            Case "2"
                str_title = "Expanded Withholding Tax Remitted"
                str_daterange = "For the Month of " & MonthName(month) & " " & year
            Case "3"
            Case "4"
            Case "5"
            Case "6"
        End Select

        If sender.Name = "btnPrint" Then
            If filter_id = "8" Then

            Else
            End If

            If currency = "2" And wComparison Then
                If filter_id = "1" Then
                    If print <> "2" Then
                        Dim rep As New report_final_ewt_print
                        rep.DataSource = ds
                        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                        rep.Parameters("title").Value = str_title
                        rep.Parameters("name").Value = str_name
                        rep.Parameters("daterange").Value = str_daterange
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
                        rep.GroupHeader4.Visible = False
                        rep.GroupFooter4.Visible = False
                        If print = "3" Or print = "6" Then
                            rep.GroupHeader5.Visible = False
                            rep.GroupFooter5.Visible = False
                            rep.columnNo.Text = "TIN"
                            rep.columnName.Text = "NAME"
                            rep.trans_no.DataBindings.Add("Text", Nothing, "tin")
                            rep.trans_name.DataBindings.Add("Text", Nothing, "general_name")
                        Else
                            rep.GroupFooter6.Visible = False
                        End If
                        reportviewer.DocumentViewer1.DocumentSource = rep
                        reportviewer.ShowDialog()
                    Else
                        Dim rep As New report_final_ewt_print_2
                        rep.DataSource = ds
                        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                        rep.Parameters("title").Value = str_title
                        rep.Parameters("name").Value = str_name
                        rep.Parameters("daterange").Value = str_daterange
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
                        reportviewer.DocumentViewer1.DocumentSource = rep
                        reportviewer.ShowDialog()
                    End If
                Else
                    If print <> "2" And print <> "5" Then
                        Dim rep As New report_final_ewt_print_4
                        rep.DataSource = ds
                        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                        rep.Parameters("title").Value = str_title
                        rep.Parameters("name").Value = str_name
                        rep.Parameters("daterange").Value = str_daterange
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
                        reportviewer.DocumentViewer1.DocumentSource = rep
                        reportviewer.ShowDialog()
                    Else
                        Dim rep As New report_final_ewt_print
                        rep.DataSource = ds
                        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                        rep.Parameters("title").Value = str_title
                        rep.Parameters("name").Value = str_name
                        rep.Parameters("daterange").Value = str_daterange
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
                        rep.GroupHeader4.Visible = False
                        rep.GroupFooter4.Visible = False
                        rep.GroupHeader5.Visible = False
                        rep.GroupFooter5.Visible = False
                        rep.columnNo.Text = "TIN"
                        rep.columnName.Text = "NAME"
                        rep.trans_no.DataBindings.Add("Text", Nothing, "tin")
                        rep.trans_name.DataBindings.Add("Text", Nothing, "general_name")
                        rep.GroupFooter6.Visible = False
                        reportviewer.DocumentViewer1.DocumentSource = rep
                        reportviewer.ShowDialog()
                    End If
                End If
            Else
                If filter_id = "1" Then
                    If print <> "2" Then
                        Dim rep As New report_final_ewt_print_1
                        rep.DataSource = ds
                        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                        rep.Parameters("title").Value = str_title
                        rep.Parameters("name").Value = str_name
                        rep.Parameters("daterange").Value = str_daterange
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
                        rep.GroupHeader4.Visible = False
                        rep.GroupFooter4.Visible = False
                        If print = "3" Or print = "6" Then
                            rep.GroupHeader5.Visible = False
                            rep.GroupFooter5.Visible = False
                            rep.columnNo.Text = "TIN"
                            rep.columnName.Text = "NAME"
                            rep.trans_no.DataBindings.Add("Text", Nothing, "tin")
                            rep.trans_name.DataBindings.Add("Text", Nothing, "general_name")
                        Else
                            rep.GroupFooter6.Visible = False
                        End If
                        reportviewer.DocumentViewer1.DocumentSource = rep
                        reportviewer.ShowDialog()
                    Else
                        Dim rep As New report_final_ewt_print_3
                        rep.DataSource = ds
                        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                        rep.Parameters("title").Value = str_title
                        rep.Parameters("name").Value = str_name
                        rep.Parameters("daterange").Value = str_daterange
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
                        reportviewer.DocumentViewer1.DocumentSource = rep
                        reportviewer.ShowDialog()
                    End If
                Else
                    If print <> "2" And print <> "5" Then
                        Dim rep As New report_final_ewt_print_5
                        rep.DataSource = ds
                        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                        rep.Parameters("title").Value = str_title
                        rep.Parameters("name").Value = str_name
                        rep.Parameters("daterange").Value = str_daterange
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
                        reportviewer.DocumentViewer1.DocumentSource = rep
                        reportviewer.ShowDialog()
                    Else
                        Dim rep As New report_final_ewt_print_1
                        rep.DataSource = ds
                        rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                        rep.Parameters("title").Value = str_title
                        rep.Parameters("name").Value = str_name
                        rep.Parameters("daterange").Value = str_daterange
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
                        rep.GroupHeader4.Visible = False
                        rep.GroupFooter4.Visible = False
                        rep.GroupHeader5.Visible = False
                        rep.GroupFooter5.Visible = False
                        rep.columnNo.Text = "TIN"
                        rep.columnName.Text = "NAME"
                        rep.trans_no.DataBindings.Add("Text", Nothing, "tin")
                        rep.trans_name.DataBindings.Add("Text", Nothing, "general_name")
                        rep.GroupFooter6.Visible = False
                        reportviewer.DocumentViewer1.DocumentSource = rep
                        reportviewer.ShowDialog()
                    End If
                End If
            End If
        ElseIf sender.Name = "btnDiskette" Then
            If folderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim fileName As String = String.Format("{0}{1}{2}1601E.dat", ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9), month.PadLeft(2, "0"), year.PadLeft(4, "0"))
                Dim path As String = folderBrowser.SelectedPath & "\" & fileName
                If File.Exists(path) Then
                    Dim delete = MsgBox("File Already Exist. Want to replace with the new one?", MsgBoxStyle.YesNo, "1601E")
                    If delete = MsgBoxResult.No Then
                        Exit Sub
                    End If
                    File.Delete(fileName)
                End If
                Dim fs As FileStream = File.Create(path)
                Dim rdo_code_length As Integer = ifNull(If(ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").Substring(9).Length > 3, 4, 3), 0)
                Dim HMAP = String.Format("HMAP,H1601E,{0},{1},""{2}"",{3}/{4},{5}",
                                          ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9),
                                          ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").Substring(9, rdo_code_length).PadLeft(4, "0"),
                                          ds.Tables("Company").Rows(0).Item("company_name"),
                                          month.PadLeft(2, "0"), year.PadLeft(4, "0"),
                                          ds.Tables("Company").Rows(0).Item("rdo_code"))
                Dim DMAP As String = ""
                Dim ctr As Integer = 1
                Dim total_tax_rate As Decimal = 0
                Dim total_amount_based As Decimal = 0
                AddText(fs, HMAP)
                For Each dr As DataRow In ds.Tables("Accounts").Rows
                    DMAP = String.Format("DMAP,D1601E,{0},{1},{2},""{3}"",,,,{4}/{5},{6},,{7},{8},{9}",
                                         ctr,
                                         dr.Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9),
                                         dr.Item("tin").ToString.Replace("-", "").PadLeft(14, "0").Substring(9, 4).PadLeft(4, "0"),
                                         dr.Item("general_name"),
                                         month.PadLeft(2, "0"), year.PadLeft(4, "0"),
                                         dr.Item("ewt_code"),
                                         dr.Item("tax_rate"),
                                         dr.Item("amount_based"),
                                         dr.Item("tax_amount"))
                    AddText(fs, Environment.NewLine & DMAP)
                    total_tax_rate += CDec(ifNull(dr.Item("tax_rate"), 0))
                    total_amount_based += dr.Item("amount_based")
                    ctr += 1
                Next
                Dim CMAP As String = String.Format("CMAP,C1601E,{0},{1},{2}/{3},{4},{5}",
                                                   ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9),
                                                   ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").Substring(9, rdo_code_length).PadLeft(4, "0"),
                                                   month.PadLeft(2, "0"), year.PadLeft(4, "0"),
                                                   total_tax_rate, total_amount_based)
                AddText(fs, Environment.NewLine & CMAP)
                fs.Close()
            End If
        End If
    End Sub
    Private Shared Sub AddText(ByVal fs As FileStream, ByVal value As String)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(value)
        fs.Write(info, 0, info.Length)
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txt_filter_option_TextChange(sender As Object, e As EventArgs) Handles txt_filter_option.TextChange
        If txt_filter_option.Text = "Alphabetical List of Payees from whome Taxes were Withheld" Then
            btnPrint.Visible = False
            btnExcel.Visible = True
            currency_filter.Enabled = False
            project_department_filter.Enabled = False
            txt_print_option.Enabled = False
            txt_ewt_id.Enabled = False
        Else
            btnPrint.Visible = True
            btnExcel.Visible = False
            currency_filter.Enabled = True
            project_department_filter.Enabled = True
            txt_print_option.Enabled = True
            txt_ewt_id.Enabled = True
        End If
    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim templateName As String = "ewt_vat.xlt"
        excelEWTVat(templateName)
        'Dim filter As New ewtreportFilter
        'filter.ShowDialog()
        'If filter.DialogResult = DialogResult.OK Then
        '    Dim isHorizontal = filter.isHorizontal
        '    If isHorizontal Then
        '        excelEWTHorizontal()
        '    Else
        '        Dim templateName As String = "ewt_vat.xlt"
        '        excelEWTVat(templateName)
        '    End If
        'End If
    End Sub
    Private Sub excelEWTHorizontal()
        Dim month As String = txt_month.Value
        Dim year As String = txt_year.Value

        Dim sql = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date
            ,b.project_id,f.project_code,f.project_name
            ,d.tin,d.general_name,c.fs_ewt_id,e.ewt_code,e.ewt_name,c.amount,c.amount_based,c.tax_amount,c.tax_amount_based,c.tax_rate
            FROM trans_header a
            LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id
            LEFT JOIN trans_ewt c ON c.jbooks_id = b.jbooks_id
            LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id
            LEFT JOIN {0}.lib_acc_ewt e ON e.ewt_id = c.fs_ewt_id
            LEFT JOIN {0}.lib_erp_project f ON f.project_id = b.project_id
            WHERE c.ewt_id IS NOT NULL AND c.ref_ewt_id IS NULL AND DATE_FORMAT(a.trans_date,'%c-%Y') = '{1}-{2}'
            ORDER BY d.general_name", _serverDBFS, month, year)

        Dim dtPlain As DataTable = Query(sql)
        Dim dtTemplate As DataTable = dtPlain.Clone
        dtTemplate.Clear()
        Dim grouped = From row In dtPlain
                      Group row By atc_group = New With {
                          Key .fs_ewt_id = row.Field(Of UInt16)("fs_ewt_id"),
                          Key .ewt_code = row.Field(Of String)("ewt_code"),
                          Key .tax_rate = row.Field(Of Decimal)("tax_rate")
                      } Into Group
                      Select New With {
                                  Key .Key = atc_group
                      }
        For Each row In grouped
            Dim col As New DataColumn
            col.ColumnName = String.Format("col_{0}", row.Key.fs_ewt_id.ToString())
            col.Namespace = String.Format("col_{0}", row.Key.fs_ewt_id.ToString())
            col.Caption = String.Format("{0} ({1}%)", row.Key.ewt_code.ToString(), CInt(row.Key.tax_rate.ToString()))
            col.DataType = GetType(Decimal)
            dtTemplate.Columns.Add(col)
        Next
        For Each dr As DataRow In dtPlain.Rows
            dtTemplate.ImportRow(dr)
        Next
        For Each dr As DataRow In dtTemplate.Rows
            Dim col_id As String = String.Format("col_{0}", dr("fs_ewt_id").ToString())
            dr(col_id) = dr("tax_amount_based")
        Next

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim autonum As Integer = 1
        Dim first_column As Integer = 4
        Dim current_column As Integer = first_column
        Dim current_row As Integer = 10
        Dim firstrow As Integer = current_row
        Dim current_index As Integer = 0

        xlWorkSheet.Cells(1, 1) = "BIR FORM 1601E - SCHEDULE 1"
        xlWorkSheet.Cells(2, 1) = "ALPHABETICAL LIST OF PAYEES FROM WHOME TAXES WERE WITHHELD"
        xlWorkSheet.Cells(3, 1) = "FOR THE MONTH OF " & MonthName(month) & ", " & year
        xlWorkSheet.Cells(5, 1) = "TIN: " & main.Sys_Default.Rows(0).Item("tin")
        xlWorkSheet.Cells(6, 1) = "WITHHOLDING AGENT'S NAME: " & main.Sys_Default.Rows(0).Item("company_name")

        xlWorkSheet.Cells(8, 1) = "SEQ NO."
        xlWorkSheet.Cells(8, 2) = "PAYEE"
        xlWorkSheet.Cells(8, 3) = "REF NO."
        Dim i As Integer = first_column
        For Each row In grouped
            xlWorkSheet.Cells(8, i) = String.Format("{0} ({1}%)", row.Key.ewt_code.ToString, CInt(row.Key.tax_rate.ToString))
            i += 1
        Next
        xlWorkSheet.Cells(8, i) = String.Format("INCOME PAYMENT")
        i += 1
        xlWorkSheet.Cells(8, i) = String.Format("AMOUNT WITHHELD")
        For Each dr As DataRow In dtTemplate.Rows
            xlWorkSheet.Cells(current_row, 1) = "SEQ NO."
            xlWorkSheet.Cells(current_row, 2) = "PAYEE"
            xlWorkSheet.Cells(current_row, 3) = "REF NO."
            current_column = first_column

        Next
    End Sub
    Private Sub excelEWTVat(ByVal templateName As String)
        Dim month As String = txt_month.Value
        Dim year As String = txt_year.Value

        Dim sql = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " &
                                " ,d.tin,d.general_name,e.ewt_code,e.ewt_name,c.amount,c.amount_based,c.tax_amount,c.tax_amount_based,c.tax_rate " &
                                " FROM trans_header a " &
                                " LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " &
                                " LEFT JOIN trans_ewt c ON c.jbooks_id = b.jbooks_id " &
                                " LEFT JOIN {0}.lib_erp_general d ON d.general_id = a.general_id " &
                                " LEFT JOIN {0}.lib_acc_ewt e ON e.ewt_id = c.fs_ewt_id " &
                                " WHERE c.ewt_id IS NOT NULL AND c.ref_ewt_id IS NULL ", _serverDBFS)

        sql &= String.Format(" AND DATE_FORMAT(a.trans_date,'%c-%Y') = '{0}-{1}'", month, year)
        sql &= " order by d.general_name ASC"

        Dim dt As DataTable = Query(sql)
        ds.Tables("Accounts").Clear()

        For Each row As DataRow In dt.Rows
            ds.Tables("Accounts").ImportRow(row)
        Next

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & templateName)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim autonum As Integer = 1
        Dim current_row As Integer = 9
        Dim firstrow As Integer = current_row
        Dim current_index As Integer = 0

        xlWorkSheet.Cells(1, 1) = "BIR FORM 1601E - SCHEDULE 1"
        xlWorkSheet.Cells(2, 1) = "ALPHABETICAL LIST OF PAYEES FROM WHOME TAXES WERE WITHHELD"
        xlWorkSheet.Cells(3, 1) = "FOR THE MONTH OF " & MonthName(month) & ", " & year
        xlWorkSheet.Cells(5, 1) = "TIN: " & main.Sys_Default.Rows(0).Item("tin")
        xlWorkSheet.Cells(6, 1) = "WITHHOLDING AGENT'S NAME: " & main.Sys_Default.Rows(0).Item("company_name")

        For Each row As DataRow In dt.Rows
            xlWorkSheet.Cells(current_row, 1) = autonum
            xlWorkSheet.Cells(current_row, 2) = row.Item("tin")
            xlWorkSheet.Cells(current_row, 3) = row.Item("general_name")
            xlWorkSheet.Cells(current_row, 4) = ""
            xlWorkSheet.Cells(current_row, 5) = row.Item("ewt_code")
            xlWorkSheet.Cells(current_row, 6) = row.Item("ewt_name")
            xlWorkSheet.Cells(current_row, 7) = row.Item("amount_based")
            xlWorkSheet.Cells(current_row, 8) = row.Item("tax_rate")
            xlWorkSheet.Cells(current_row, 9) = row.Item("tax_amount_based")
            current_row += 1
            autonum += 1
        Next

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 9) = String.Format("=SUBTOTAL(9,I{0}:I{1})", firstrow, current_row - 1)
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
End Class