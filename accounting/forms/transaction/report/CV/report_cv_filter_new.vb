﻿Imports System.Windows.Forms
Imports System.Drawing
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Public Class report_cv_filter_new
    'raymond - 2016-06-10

    'initialization
    Dim ds As New trans_dataset

    Dim sql_sys_default As String = ""
    Dim sql_header As String = ""
    Dim sql_jbooks As String = ""
    Dim sql_additional As String = ""
    Dim sql_mfo_pap As String = ""
    Dim sql_particular As String = ""
    Dim sql_signatory As String = ""

    Private _journalid As String
    Private _bookid As String
    Private _transid As String
    Private _transno As String

    Private OriginalDT As DataTable = Nothing
    'end of initialization

    'properties
    Public Property journal_id() As String
        Get
            Return _journalid
        End Get
        Set(ByVal value As String)
            _journalid = value
        End Set
    End Property

    Public Property transid() As String
        Get
            Return _transid
        End Get
        Set(value As String)
            _transid = value
        End Set
    End Property
    Public Property transno() As String
        Get
            Return _transno
        End Get
        Set(value As String)
            _transno = value
            invoice_from.Text = transno
            invoice_to.Text = transno
            invoice_Leave(invoice_from, Nothing)
            invoice_Leave(invoice_to, Nothing)
        End Set
    End Property

    Public Property book_id() As String
        Get
            Return _bookid
        End Get
        Set(ByVal value As String)
            _bookid = value
        End Set
    End Property
    'end of properties

    'sub and function declaration
    Private Sub initLoad()

    End Sub

    Private Sub hideAllOptions()
        'option1.Visible = False
        option2.Visible = False
        option3.Visible = False
        option4.Visible = False
        option5.Visible = False
        option6.Visible = False
        dgSelection.Visible = False
        'option7.Visible = False
        'option8.Visible = False
    End Sub
    Private Sub createData()

        ds.Clear()

        If sql_sys_default <> "" Then
            'company
            Dim dt_sys_default As DataTable = Query(sql_sys_default)
            For Each row As DataRow In dt_sys_default.Rows
                ds.Tables("Company").ImportRow(row)
            Next
        End If
        If sql_header <> "" Then
            'header
            Dim dt_header As DataTable = Query(sql_header)
            For Each row As DataRow In dt_header.Rows
                ds.Tables("Header").ImportRow(row)
            Next
        End If
        If sql_jbooks <> "" Then
            'jbooks
            Dim dt_jbooks As DataTable = Query(sql_jbooks)
            For Each row As DataRow In dt_jbooks.Rows
                ds.Tables("JBooks").ImportRow(row)
            Next
        End If
        If sql_particular <> "" Then
            'particulars
            Dim dt_particular As DataTable = Query(sql_particular)
            For Each row As DataRow In dt_particular.Rows
                ds.Tables("Particulars").ImportRow(row)
            Next
        End If
        If sql_additional <> "" Then
            'header
            Dim dt_additional As DataTable = Query(sql_additional)
            For Each row As DataRow In dt_additional.Rows
                ds.Tables("additional").ImportRow(row)
            Next
        End If
        If sql_mfo_pap <> "" Then
            'header
            Dim dt_mfo_pap As DataTable = Query(sql_mfo_pap)
            For Each row As DataRow In dt_mfo_pap.Rows
                ds.Tables("mfo_pap").ImportRow(row)
            Next
        End If
        If sql_signatory <> "" Then
            'signatory
            Dim dt_signatory As DataTable = FsQuery(sql_signatory)
            For Each row As DataRow In dt_signatory.Rows
                ds.Tables("Signatory").ImportRow(row)
            Next
        End If
    End Sub
    'end of sub and functions declaration
    Private Sub loadChecks()
        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no " &
            ",c.check_id,c.bank_id,c.check_no,c.cancel_date,c.cancelled,c.check_amount,c.check_amount_based,c.check_date,c.cleared,c.cleared_date,c.crossed,c.currency_id,c.general_id,c.released,c.replaced,c.replacement_check_no " &
            ",d.bank_code,d.bank_name,d.file_path " &
            ",e.currency_code,e.currency_name,e.symbol " &
            ",f.general_code,f.general_name " &
            ",'' AS word_amount,'' AS word_amount_based " &
            ",c.isPrinted " &
            "FROM trans_header a " &
            "LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " &
            "LEFT JOIN trans_checks c ON c.jbooks_id = b.jbooks_id " &
            "LEFT JOIN {0}.lib_erp_bank d ON d.bank_id = c.bank_id " &
            "LEFT JOIN {0}.lib_erp_currency e ON e.currency_id = c.currency_id " &
            "LEFT JOIN {0}.lib_erp_general f ON f.general_id = c.general_id " &
            "LEFT JOIN {0}.lib_erp_book g ON g.book_id = a.book_id " &
            "WHERE a.journal_id = {1} AND a.book_id = {2} AND c.check_id <> '' AND g.company_id = '{3}' " &
            "" &
            "", _serverDBFS,
                If(journal_id.ToString = "", 0, journal_id),
                If(book_id.ToString = "", 0, book_id),
                main.Sys_Default.Rows(0).Item("company_id").ToString())
        Dim dt As DataTable = Query(sql)
        OriginalDT = dt.Clone()
        dgSelection.AutoGenerateColumns = False
        dgSelection.DataSource = dt
        OriginalDT.Clear()
        For Each dr As DataRow In dt.Rows
            OriginalDT.ImportRow(dr)
        Next
    End Sub
    'events declaration
    Private Sub report_ap_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideAllOptions()
        option6_2.Visible = False
        loadChecks()
        txt_print._Text = "Disbursement Voucher"
        txt_print_Leave(Nothing, Nothing)
        withProject.Checked = main.Sys_Default.Rows(0).Item("w_proj")
        withDepartment.Checked = main.Sys_Default.Rows(0).Item("w_dept")
        withAllocation.Checked = main.Sys_Default.Rows(0).Item("w_alloc")
    End Sub

    Private Sub txt_print_Leave(sender As Object, e As EventArgs) Handles txt_print.Leave

        Dim dt As DataTable = FsQuery("SELECT 1 AS id,'Disbursement Voucher' AS name,'' AS code " &
                                      "UNION SELECT 2,'Disbursement Voucher List','' " &
                                      "UNION SELECT 3,'Print Check','' " &
                                      "")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("name like '{0}'", txt_print.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Name", "name", "200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            'Dim idasd = browse.dgview.
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_print.RowData = dr
                txt_print.Value = dr("id")
                txt_print.Text = dr("name")
                showOptions1(dr("id"))
            End If
        End If

    End Sub
    Private Sub invoice_Leave(sender As Object, e As EventArgs) Handles invoice_from.Leave, invoice_to.Leave
        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date " &
            "FROM trans_header a " &
            "LEFT JOIN {1}.lib_erp_book b ON b.book_id = a.book_id " &
            "WHERE a.journal_id = '{0}' AND b.company_id = '{2}' " &
            "ORDER BY a.trans_date DESC,a.trans_no DESC " &
            "", journal_id, _serverDBFS, main.Sys_Default.Rows(0).Item("company_id").ToString())
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("trans_no like '{0}'", sender.Text))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Invoice No.,Date", "trans_no,trans_date", "200,100")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                sender.RowData = dr
                sender.Value = dr("trans_id")
                sender.Text = dr("trans_no")
            End If
        End If

    End Sub
    Private Sub general_id_Leave(sender As Object, e As EventArgs) Handles general_id.Leave

        Dim dt As DataTable = FsQuery(String.Format("SELECT * FROM lib_erp_general"))
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("general_code like '{0}'", general_id.Text))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "general_code,general_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                general_id.RowData = dr
                general_id.Value = dr("general_id")
                general_id.Text = dr("general_code")
                general_name.Text = dr("general_name")
            End If
        End If

    End Sub

    Private Sub showOptions1(ByVal print As String)
        hideAllOptions()
        'option8.Visible = True
        '1 : Invoice
        '2 : Invoice List
        lblSearch.Visible = False
        txtSearch.Visible = False
        withPrintedCheck.Visible = False
        withEntry.Visible = True
        lbl_template.Visible = False
        txt_template_id.Visible = False
        Select Case print
            Case "1"
                If _serverDBFS.Contains("erp_fs_drdc") Then
                    lbl_template.Visible = True
                    txt_template_id.Visible = True
                End If
                'option1.Visible = True
                option2.Visible = False
                'Rdo_button1.Checked = False
                'Rdo_button1.Checked = True
                option3.Visible = True
                option4.Visible = False
                option5.Visible = True
                option6.Visible = False
                'option7.Visible = False
                withProject.Visible = False
                withDepartment.Visible = False
            Case "2"
                'option1.Visible = False
                option2.Visible = True
                option5.Visible = True
                Rdo_button6.Checked = False
                Rdo_button6.Checked = True
            Case "3"
                lblSearch.Visible = True
                txtSearch.Visible = True
                withPrintedCheck.Visible = True
                withEntry.Visible = False
                dgSelection.Visible = True
                withProject.Visible = False
                withDepartment.Visible = False
                withAllocation.Visible = False
        End Select
    End Sub

    Private Sub printInvoiceChange(sender As Object, e As EventArgs)
        'Dim rdo = getRdoValue(option1)
        Select Case True
            Case "1" 'with entries
                '
            Case "2" 'without entries
                option3.Visible = True
                option4.Visible = False
                option5.Visible = False
                option6.Visible = False
                'option7.Visible = True
        End Select
    End Sub
    Private Sub printInvoiceListChange(sender As Object, e As EventArgs) Handles Rdo_button6.CheckedChanged, Rdo_button3.CheckedChanged, Rdo_button5.CheckedChanged
        Dim rdo = getRdoValue(option2)
        Select Case rdo
            Case "1" 'By Invoice No
                option3.Visible = True
                option4.Visible = False
                option5.Visible = True
                option6.Visible = False
                'option7.Visible = False
            Case "2" 'By Invoice Date
                option3.Visible = False
                option4.Visible = True
                option5.Visible = True
                option6.Visible = False
                'option7.Visible = False
            Case "3" 'By Client
                option3.Visible = False
                option4.Visible = False
                option5.Visible = True
                option6.Visible = True
                'option7.Visible = False
        End Select
    End Sub
    Private Sub printClientChange(sender As Object, e As EventArgs) Handles Rdo_button12.CheckedChanged
        Dim rdo = getRdoValue(option6_1)
        Select Case rdo
            Case "1" 'All Clients
                option6_2.Visible = False
            Case "2" 'Per Clients
                option6_2.Visible = True
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim DialogResult As DialogResult = MsgBox("Do you want to print normal check voucher?", MessageBoxButtons.YesNo, "Some Title")

        If DialogResult = DialogResult.Yes Then
            Dim _withEntry As Boolean = withEntry.Checked
            Dim _print = txt_print.Value
            Dim _general_id = general_id.Value

            'Dim _cutParticulars = cutParticulars.Checked
            'Dim _vouchInPeso = vouchInPeso.Checked

            'Dim _entries = getRdoValue(option1)
            Dim _invoice = getRdoValue(option2)
            Dim _currency = getRdoValue(option5)
            Dim _client = getRdoValue(option6_1)

            Dim _invoice_from = invoice_from.Value
            Dim _invoice_to = invoice_to.Value

            Dim _trans_no_from = invoice_from.Text
            Dim _trans_no_to = invoice_to.Text

            Dim _date_from = date_from.Value.ToString("yyyy-MM-dd")
            Dim _date_to = date_to.Value.ToString("yyyy-MM-dd")

            '   sys_default
            sql_sys_default = String.Format("SELECT a.company_id,b.company_name,b.address1 AS address,b.tel_no,b.fax_no,b.tin " &
                                                "FROM sys_default a " &
                                                "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id ", _serverDBFS)
            '   header
            sql_header = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,b.currency_name, " &
                                       "b.currency_code,a.amount,a.amount_based,a.exchange_rate, " &
                                       "a.based_rate,a.description,a.general_id,c.general_code,c.general_name, " &
                                       "c.address1 AS address,c.attention, " &
                                       "IF(a.status = 'A','Approved',(IF(a.status = 'C','Cancelled',''))) AS status " &
                                       ",d.si_no,d.rr_no,b.symbol
                                   ,f.user_id,f.username,f.user_fullname
                                   ,e.book_code,e.book_name " &
                                        "FROM trans_header a " &
                                        "LEFT JOIN {1}.lib_erp_currency b ON b.currency_id = a.currency_id " &
                                        "LEFT JOIN {1}.lib_erp_general c ON c.general_id = a.general_id " &
                                        "LEFT JOIN {2}.trans_header_cv d ON d.trans_id = a.trans_id " &
                                        "LEFT JOIN {1}.lib_erp_book e ON e.book_id = a.book_id " &
                                        "LEFT JOIN (
                                            SELECT a.trans_id,c.user_id,c.username,c.user_fullname
                                            FROM {2}_at.trans_header a
                                            LEFT JOIN sys_log b ON b.log_id = a.log_id
                                            LEFT JOIN {1}.sys_erp_user c ON c.user_id = b.user_id
                                            WHERE a.transmode = 'Insert'
                                            GROUP BY a.trans_id
                                       ) f ON f.trans_id = a.trans_id " &
                                        "WHERE a.journal_id = {0} AND e.company_id = '{3}' ", journal_id, _serverDBFS, _serverDBMain, main.Sys_Default.Rows(0).Item("company_id").ToString())

            '   jbooks
            sql_jbooks = String.Format("Select a.trans_id, a.jbooks_id, b.account_code, b.account_name " &
                ", a.debit, a.credit, a.debit_based, a.credit_based, c.general_code, c.general_name, i.trans_no As ref_ref_no " &
                ", f.project_code, f.project_name, g.department_code, g.department_name, h.allocation_code, k.bank_name, concat(j.check_no,' - ', date_format(j.check_date,'%m/%d/%Y')) as check_no,j.check_no as check_no_only,b.validation,a.line_remarks " &
                "FROM trans_jbooks a " &
                "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                "LEFT JOIN {1}.lib_erp_general c ON c.general_id = a.general_id " &
                "LEFT JOIN {2}.trans_jbooks d ON d.jbooks_id = a.ref_jbooks_id " &
                "LEFT JOIN {2}.trans_header i ON i.trans_id = d.trans_id " &
                "LEFT JOIN {2}.trans_header e ON e.trans_id = a.trans_id " &
                "LEFT JOIN {1}.lib_erp_project f ON f.project_id = a.project_id " &
                "LEFT JOIN {1}.lib_erp_department g ON g.department_id = a.department_id " &
                "LEFT JOIN {1}.lib_erp_allocation h ON h.allocation_id = a.allocation_id " &
                "LEFT JOIN {2}.trans_checks j ON j.jbooks_id = a.jbooks_id " &
                "LEFT JOIN {1}.lib_erp_bank k ON k.bank_id = j.bank_id " &
                "WHERE e.journal_id = {0} ", journal_id, _serverDBFS, _serverDBMain)
            If _print = "1" Then
                sql_jbooks &= "GROUP BY a.jbooks_id "
            End If
            sql_jbooks &= "order by IF(a.debit <> 0,1,2),b.account_code"
            sql_particular = String.Format("SELECT a.trans_particular_id,a.trans_id,a.trans_particular_code " &
                ",a.trans_particular_name,a.trans_particular_amount " &
                "FROM trans_header_particular a " &
                "")
            sql_signatory = String.Format("SELECT a.user_signatory_id,a.user_id,a.label1,a.user_id1 " &
                ",a.position1,a.label2,a.user_id2,a.position2,a.label3,a.user_id3,a.position3 " &
                ",a.label4,a.user_id4,a.position4,a.label5,a.user_id5,a.position5 " &
                ",b.username,b.user_fullname " &
                ",c.username AS username1,c.user_fullname AS user_fullname1 " &
                ",d.username AS username2,d.user_fullname AS user_fullname2 " &
                ",e.username AS username3,e.user_fullname AS user_fullname3 " &
                ",f.username AS username4,f.user_fullname AS user_fullname4 " &
                ",g.username AS username5,g.user_fullname AS user_fullname5 " &
                ",h.module_code,h.module_name " &
                "FROM sys_erp_user_signatory a " &
                "LEFT JOIN sys_erp_user b ON b.user_id = a.user_id " &
                "LEFT JOIN sys_erp_user c ON c.user_id = a.user_id1 " &
                "LEFT JOIN sys_erp_user d ON d.user_id = a.user_id2 " &
                "LEFT JOIN sys_erp_user e ON e.user_id = a.user_id3 " &
                "LEFT JOIN sys_erp_user f ON f.user_id = a.user_id4 " &
                "LEFT JOIN sys_erp_user g ON g.user_id = a.user_id5 " &
                "LEFT JOIN sys_erp_modules h ON h.module_id = a.module_id " &
                "WHERE a.user_id = '{0}' AND h.module_code = '{1}' " &
                "", main.user_id, "ACC00401")

            Dim col As New List(Of KeyValuePair(Of String, String))
            col.Add(New KeyValuePair(Of String, String)("@module_code", "ACC00401"))
            Dim dt_template = ExecuteWithParameter("get_lib_acc_voucher_template", ConnectionStringFS, CommandType.StoredProcedure, col)

            Select Case _print
                Case "1" ' Invoice
                    If _invoice_from = "" Or _invoice_to = "" Then
                        MsgBox("Complete the filter first.")
                        Exit Sub
                    End If

                    sql_header &= String.Format("AND a.trans_no BETWEEN '{0}' AND '{1}' ", _trans_no_from, _trans_no_to)

                    ' Print Invoice With Entries
                    '   _invoice_from
                    '   _invoice_to
                    '   _currency
                    createData()

                    For Each row As DataRow In ds.Tables("Header").Rows
                        row.Item("amount_word") = amount_words(Format(ifNull(row.Item("amount"), 0), "n2"))
                        For Each dr As DataRow In ds.Tables("jbooks").Rows
                            If dr.Item("trans_id") = row.Item("trans_id") Then
                                If dr.Item("ref_ref_no").ToString <> "" Then
                                    row.Item("dn_ref") &= "," & dr.Item("ref_ref_no")
                                End If
                                If dr.Item("bank_name").ToString <> "" Then
                                    row.Item("bank_name") &= "," & dr.Item("bank_name")
                                End If
                                If dr.Item("check_no").ToString <> "" Then
                                    row.Item("check_no") &= "," & dr.Item("check_no")
                                End If
                                If dr.Item("check_no_only").ToString <> "" Then
                                    row.Item("check_no_only") &= "," & dr.Item("check_no_only")
                                End If
                            End If
                        Next
                        If row.Item("dn_ref").ToString <> "" Then
                            row.Item("dn_ref") = row.Item("dn_ref").ToString.Substring(1)
                        End If
                        If row.Item("bank_name").ToString <> "" Then
                            row.Item("bank_name") = row.Item("bank_name").ToString.Substring(1)
                        End If
                        If row.Item("check_no").ToString <> "" Then
                            row.Item("check_no") = row.Item("check_no").ToString.Substring(1)
                        End If
                        If row.Item("check_no_only").ToString <> "" Then
                            row.Item("check_no_only") = row.Item("check_no_only").ToString.Substring(1)
                        End If
                    Next

                    If _currency = "1" Then
                        For Each row As DataRow In ds.Tables("JBooks").Rows
                            row.Item("debit") = row.Item("debit_based")
                            row.Item("credit") = row.Item("credit_based")
                        Next
                    End If
                    If _serverDBFS.Contains("erp_fs_drdc") Then
                        Dim drTemplate As DataRow = txt_template_id.RowData
                        If drTemplate IsNot Nothing Then
                            Dim file_location As String = drTemplate.Item("file_location").ToString
                            Dim rep As New XtraReport
                            Try
                                rep = rep.FromFile(file_location)
                                generateDuravilleReport(rep)
                            Catch ex As Exception
                                MsgBox(String.Format("File Not Found : {0}", file_location))
                                Exit Sub
                            End Try
                        Else
                            MsgBox("No Template Found")
                            Exit Sub
                        End If
                    Else
                        If _currency = "1" Or _currency = "2" Then
                            'Dim rep As New dura_cv
                            Dim rep As New XtraReport
                            Try
                                rep = rep.FromFile(dt_template.Rows(0).Item("file_location").ToString())
                            Catch ex As Exception
                                MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(0).Item("file_location").ToString()))
                                Exit Sub
                            End Try
                            Try
                                rep.Parameters("S001").Value = main.S001
                                rep.Parameters("S002").Value = main.S002
                                rep.Parameters("print_system_name").Value = main.system_name
                                rep.Parameters("print_username").Value = main.CurrentUsername
                            Catch ex As Exception
                            End Try
                            rep.DataSource = ds
                            Dim frm As String = ""

                            frm = "#,##0.00000000000000000000"
                            frm = frm.Substring(0, 6 + main.Sys_Default.Rows(0).Item("decimal_places"))

                            'rep.DataMember = "Header"
                            generateReport(rep, withProject.Checked, withDepartment.Checked, withAllocation.Checked)

                            If rep.FindControl("amount", False) IsNot Nothing Then
                                'rep.FindControl("amount", False).TextFormatString = "{0:" & frm & "}"
                            End If
                            If rep.FindControl("runtime", False) IsNot Nothing Then
                                rep.FindControl("runtime", False).Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                            End If
                            If rep.FindControl("company_logo", False) IsNot Nothing Then
                                DirectCast(rep.FindControl("company_logo", False), XRPictureBox).ImageUrl = Application.StartupPath & "/img/logo.png"
                            End If
                            reportviewer.DocumentViewer1.DocumentSource = rep
                            reportviewer.ShowDialog()
                        ElseIf _currency = "3" Then
                            Dim rep As New XtraReport
                            Try
                                rep = rep.FromFile(dt_template.Rows(1).Item("file_location").ToString())
                            Catch ex As Exception
                                MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(1).Item("file_location").ToString()))
                                Exit Sub
                            End Try
                            Try
                                rep.Parameters("S001").Value = main.S001
                                rep.Parameters("S002").Value = main.S002
                                rep.Parameters("print_system_name").Value = main.system_name
                                rep.Parameters("print_username").Value = main.CurrentUsername
                            Catch ex As Exception
                            End Try
                            rep.DataSource = ds
                            Dim frm As String = ""

                            frm = "#,##0.00000000000000000000"
                            frm = frm.Substring(0, 6 + main.Sys_Default.Rows(0).Item("decimal_places"))

                            'rep.DataMember = "Header"
                            generateReport(rep, withProject.Checked, withDepartment.Checked, withAllocation.Checked, True)

                            If rep.FindControl("amount", False) IsNot Nothing Then
                                'rep.FindControl("amount", False).TextFormatString = "{0:" & frm & "}"
                            End If
                            If rep.FindControl("runtime", False) IsNot Nothing Then
                                rep.FindControl("runtime", False).Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                            End If
                            If rep.FindControl("company_logo", False) IsNot Nothing Then
                                DirectCast(rep.FindControl("company_logo", False), XRPictureBox).ImageUrl = Application.StartupPath & "/img/logo.png"
                            End If
                            reportviewer.DocumentViewer1.DocumentSource = rep
                            reportviewer.ShowDialog()
                        End If
                    End If
                'If Not _withEntry Then
                '    Select Case main.Sys_Default.Rows(0).Item("company_code").ToString
                '        Case "DMI"
                '            generateDuravilleReport(New DMI_voucher)
                '        Case "LCSDC"
                '            generateDuravilleReport(New landcris_voucher)
                '        Case "DRDC"
                '            generateDuravilleReport(New DRDC_voucher)
                '        Case "DCLS"
                '            generateDuravilleReport(New DCLS_voucher)
                '        Case "HFC"
                '            generateDuravilleReport(New hamilton_voucher)
                '        Case "LRCC"
                '            generateDuravilleReport(New lancris_voucher)
                '        Case "NLDC"
                '            generateDuravilleReport(New NLDC_voucher)
                '        Case "LPDC"
                '            generateDuravilleReport(New LPDC_voucher)
                '        Case Else
                '            generateDuravilleReport(New hamilton_voucher)
                '    End Select
                'Else

                'End If
                'MsgBox("Print Invoice With Entries")
                Case "2" ' Invoice List
                    Select Case _invoice
                        Case "1" ' By Invoice No
                            ' Print Invoice List By Invoice No
                            '   _invoice_from
                            '   _invoice_to
                            sql_header &= String.Format("AND a.trans_id BETWEEN {0} AND {1} ", _invoice_from, _invoice_to)
                            If _invoice_from = "" Or _invoice_to = "" Then
                                MsgBox("Complete the filter first.")
                                Exit Sub
                            End If
                            createData()

                            If _currency = "1" Then
                                For Each row As DataRow In ds.Tables("JBooks").Rows
                                    row.Item("debit") = row.Item("debit_based")
                                    row.Item("credit") = row.Item("credit_based")
                                Next
                            End If

                            For Each row As DataRow In ds.Tables("Header").Rows
                                row.Item("amount_word") = amount_words(Format(ifNull(row.Item("amount"), 0), "n2"))
                                For Each dr As DataRow In ds.Tables("jbooks").Rows
                                    If dr.Item("trans_id") = row.Item("trans_id") Then
                                        If dr.Item("ref_ref_no").ToString <> "" Then
                                            row.Item("dn_ref") &= "," & dr.Item("ref_ref_no")
                                        End If
                                        If dr.Item("bank_name").ToString <> "" Then
                                            row.Item("bank_name") &= "," & dr.Item("bank_name")
                                        End If
                                        If dr.Item("check_no").ToString <> "" Then
                                            row.Item("check_no") &= "," & dr.Item("check_no")
                                        End If
                                    End If
                                Next
                                If row.Item("dn_ref").ToString <> "" Then
                                    row.Item("dn_ref") = row.Item("dn_ref").ToString.Substring(1)
                                End If
                                If row.Item("bank_name").ToString <> "" Then
                                    row.Item("bank_name") = row.Item("bank_name").ToString.Substring(1)
                                End If
                                If row.Item("check_no").ToString <> "" Then
                                    row.Item("check_no") = row.Item("check_no").ToString.Substring(1)
                                End If
                            Next

                            Dim rep As New XtraReport
                            Try
                                If _currency = "3" Then
                                    rep = rep.FromFile(dt_template.Rows(4).Item("file_location").ToString())
                                Else
                                    rep = rep.FromFile(dt_template.Rows(2).Item("file_location").ToString())
                                End If
                            Catch ex As Exception
                                If _currency = "3" Then
                                    MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(4).Item("file_location").ToString()))
                                Else
                                    MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(2).Item("file_location").ToString()))
                                End If
                                Exit Sub
                            End Try
                            Try
                                rep.Parameters("S001").Value = main.S001
                                rep.Parameters("S002").Value = main.S002
                                rep.Parameters("print_system_name").Value = main.system_name
                                rep.Parameters("print_username").Value = main.CurrentUsername
                            Catch ex As Exception
                            End Try
                            rep.DataSource = ds
                            rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                            rep.Parameters("fromto").Value = "FROM : [ " & invoice_from.Text & " - " & invoice_to.Text & " ]"

                            If rep.FindControl("company_logo", False) IsNot Nothing Then
                                DirectCast(rep.FindControl("company_logo", False), XRPictureBox).ImageUrl = Application.StartupPath & "/img/logo.png"
                            End If
                            reportviewer.DocumentViewer1.DocumentSource = rep
                            reportviewer.ShowDialog()
                        'MsgBox("Print Invoice List By Invoice No")
                        Case "2" ' By Invoice Date
                            ' Print Invoice List By Invoice Date
                            '   _date_from
                            '   _date_to
                            sql_header &= String.Format("AND a.trans_date BETWEEN '{0}' AND '{1}' ", _date_from, _date_to)
                            If date_from.Value > date_to.Value Then
                                MsgBox("Invalid date-range.")
                                Exit Sub
                            End If
                            createData()

                            If _currency = "1" Then
                                For Each row As DataRow In ds.Tables("JBooks").Rows
                                    row.Item("debit") = row.Item("debit_based")
                                    row.Item("credit") = row.Item("credit_based")
                                Next
                            End If

                            For Each row As DataRow In ds.Tables("Header").Rows
                                row.Item("amount_word") = amount_words(Format(ifNull(row.Item("amount"), 0), "n2"))
                                For Each dr As DataRow In ds.Tables("jbooks").Rows
                                    If dr.Item("trans_id") = row.Item("trans_id") Then
                                        If dr.Item("ref_ref_no").ToString <> "" Then
                                            row.Item("dn_ref") &= "," & dr.Item("ref_ref_no")
                                        End If
                                        If dr.Item("bank_name").ToString <> "" Then
                                            row.Item("bank_name") &= "," & dr.Item("bank_name")
                                        End If
                                        If dr.Item("check_no").ToString <> "" Then
                                            row.Item("check_no") &= "," & dr.Item("check_no")
                                        End If
                                    End If
                                Next
                                If row.Item("dn_ref").ToString <> "" Then
                                    row.Item("dn_ref") = row.Item("dn_ref").ToString.Substring(1)
                                End If
                                If row.Item("bank_name").ToString <> "" Then
                                    row.Item("bank_name") = row.Item("bank_name").ToString.Substring(1)
                                End If
                                If row.Item("check_no").ToString <> "" Then
                                    row.Item("check_no") = row.Item("check_no").ToString.Substring(1)
                                End If
                            Next

                            Dim rep As New XtraReport
                            Try
                                If _currency = "3" Then
                                    rep = rep.FromFile(dt_template.Rows(4).Item("file_location").ToString())
                                Else
                                    rep = rep.FromFile(dt_template.Rows(2).Item("file_location").ToString())
                                End If
                            Catch ex As Exception
                                If _currency = "3" Then
                                    MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(4).Item("file_location").ToString()))
                                Else
                                    MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(2).Item("file_location").ToString()))
                                End If
                                Exit Sub
                            End Try
                            Try
                                rep.Parameters("S001").Value = main.S001
                                rep.Parameters("S002").Value = main.S002
                                rep.Parameters("print_system_name").Value = main.system_name
                                rep.Parameters("print_username").Value = main.CurrentUsername
                            Catch ex As Exception
                            End Try
                            rep.DataSource = ds
                            rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                            rep.Parameters("fromto").Value = "FROM : [ " & date_from.Value.ToString("MMMM dd, yyyy") & " - " & date_to.Value.ToString("MMMM dd, yyyy") & " ]"

                            If rep.FindControl("company_logo", False) IsNot Nothing Then
                                DirectCast(rep.FindControl("company_logo", False), XRPictureBox).ImageUrl = Application.StartupPath & "/img/logo.png"
                            End If
                            reportviewer.DocumentViewer1.DocumentSource = rep
                            reportviewer.ShowDialog()

                        'MsgBox("Print Invoice List By Invoice Date")
                        Case "3" ' By Client
                            Select Case _client
                                Case "1" ' All Clients
                                    ' Print Invoice List By All Client
                                    createData()

                                    If _currency = "1" Then
                                        For Each row As DataRow In ds.Tables("JBooks").Rows
                                            row.Item("debit") = row.Item("debit_based")
                                            row.Item("credit") = row.Item("credit_based")
                                        Next
                                    End If

                                    For Each row As DataRow In ds.Tables("Header").Rows
                                        row.Item("amount_word") = amount_words(Format(ifNull(row.Item("amount"), 0), "n2"))
                                        For Each dr As DataRow In ds.Tables("jbooks").Rows
                                            If dr.Item("trans_id") = row.Item("trans_id") Then
                                                If dr.Item("ref_ref_no").ToString <> "" Then
                                                    row.Item("dn_ref") &= "," & dr.Item("ref_ref_no")
                                                End If
                                                If dr.Item("bank_name").ToString <> "" Then
                                                    row.Item("bank_name") &= "," & dr.Item("bank_name")
                                                End If
                                                If dr.Item("check_no").ToString <> "" Then
                                                    row.Item("check_no") &= "," & dr.Item("check_no")
                                                End If
                                            End If
                                        Next
                                        If row.Item("dn_ref").ToString <> "" Then
                                            row.Item("dn_ref") = row.Item("dn_ref").ToString.Substring(1)
                                        End If
                                        If row.Item("bank_name").ToString <> "" Then
                                            row.Item("bank_name") = row.Item("bank_name").ToString.Substring(1)
                                        End If
                                        If row.Item("check_no").ToString <> "" Then
                                            row.Item("check_no") = row.Item("check_no").ToString.Substring(1)
                                        End If
                                    Next

                                    Dim rep As New XtraReport
                                    Try
                                        If _currency = "3" Then
                                            rep = rep.FromFile(dt_template.Rows(5).Item("file_location").ToString())
                                        Else
                                            rep = rep.FromFile(dt_template.Rows(3).Item("file_location").ToString())
                                        End If
                                    Catch ex As Exception
                                        If _currency = "3" Then
                                            MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(5).Item("file_location").ToString()))
                                        Else
                                            MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(3).Item("file_location").ToString()))
                                        End If
                                        Exit Sub
                                    End Try
                                    Try
                                        rep.Parameters("S001").Value = main.S001
                                        rep.Parameters("S002").Value = main.S002
                                        rep.Parameters("print_system_name").Value = main.system_name
                                        rep.Parameters("print_username").Value = main.CurrentUsername
                                    Catch ex As Exception
                                    End Try
                                    rep.DataSource = ds
                                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                                    rep.Parameters("fromto").Value = "All Clients"
                                    reportviewer.DocumentViewer1.DocumentSource = rep
                                    reportviewer.ShowDialog()

                                'MsgBox("Print Invoice List By All Client")
                                Case "2" ' Per Clients
                                    If _general_id = "" Then
                                        MsgBox("Complete the filter first.")
                                        Exit Sub
                                    End If
                                    ' Print Invoice List By Particular Client

                                    sql_header &= String.Format("AND a.general_id = {0} ", _general_id)

                                    createData()

                                    If _currency = "1" Then
                                        For Each row As DataRow In ds.Tables("JBooks").Rows
                                            row.Item("debit") = row.Item("debit_based")
                                            row.Item("credit") = row.Item("credit_based")
                                        Next
                                    End If

                                    For Each row As DataRow In ds.Tables("Header").Rows
                                        row.Item("amount_word") = amount_words(Format(ifNull(row.Item("amount"), 0), "n2"))
                                        For Each dr As DataRow In ds.Tables("jbooks").Rows
                                            If dr.Item("trans_id") = row.Item("trans_id") Then
                                                If dr.Item("ref_ref_no").ToString <> "" Then
                                                    row.Item("dn_ref") &= "," & dr.Item("ref_ref_no")
                                                End If
                                                If dr.Item("bank_name").ToString <> "" Then
                                                    row.Item("bank_name") &= "," & dr.Item("bank_name")
                                                End If
                                                If dr.Item("check_no").ToString <> "" Then
                                                    row.Item("check_no") &= "," & dr.Item("check_no")
                                                End If
                                            End If
                                        Next
                                        If row.Item("dn_ref").ToString <> "" Then
                                            row.Item("dn_ref") = row.Item("dn_ref").ToString.Substring(1)
                                        End If
                                        If row.Item("bank_name").ToString <> "" Then
                                            row.Item("bank_name") = row.Item("bank_name").ToString.Substring(1)
                                        End If
                                        If row.Item("check_no").ToString <> "" Then
                                            row.Item("check_no") = row.Item("check_no").ToString.Substring(1)
                                        End If
                                    Next

                                    Dim rep As New XtraReport
                                    Try
                                        If _currency = "3" Then
                                            rep = rep.FromFile(dt_template.Rows(4).Item("file_location").ToString())
                                        Else
                                            rep = rep.FromFile(dt_template.Rows(2).Item("file_location").ToString())
                                        End If
                                    Catch ex As Exception
                                        If _currency = "3" Then
                                            MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(4).Item("file_location").ToString()))
                                        Else
                                            MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(2).Item("file_location").ToString()))
                                        End If
                                        Exit Sub
                                    End Try
                                    Try
                                        rep.Parameters("S001").Value = main.S001
                                        rep.Parameters("S002").Value = main.S002
                                        rep.Parameters("print_system_name").Value = main.system_name
                                        rep.Parameters("print_username").Value = main.CurrentUsername
                                    Catch ex As Exception
                                    End Try
                                    rep.DataSource = ds
                                    rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                                    rep.Parameters("fromto").Value = "Client : " & general_name.Text
                                    reportviewer.DocumentViewer1.DocumentSource = rep
                                    reportviewer.ShowDialog()

                                    'MsgBox("Print Invoice List By Particular Client")
                            End Select
                    End Select
                Case "3"
                    If dgSelection.Rows.Count > 0 Then
                        If dgSelection.SelectedRows.Count > 0 Then
                            Dim selectedRow = dgSelection.SelectedRows(0)
                            Dim dt As DataTable = dgSelection.DataSource
                            Dim dr As DataRow = dt.Select(String.Format("check_id = {0}", selectedRow.Cells(0).Value.ToString))(0)
                            dr.Item("word_amount") = amount_words(CDec(ifNull(dr.Item("check_amount"), 0)))
                            dr.Item("word_amount_based") = amount_words(CDec(ifNull(dr.Item("check_amount_based"), 0)))
                            MyDebugging.AddText(amount_words(CDec(ifNull(dr.Item("check_amount"), 0))))
                            MyDebugging.AddText(amount_words(CDec(ifNull(dr.Item("check_amount_based"), 0))))
                            Dim filePath = dr.Item("file_path").ToString
                            Try

                            Catch ex As Exception

                            End Try
                            Dim rep = XtraReport.FromFile(filePath, True)
                            rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                            rep.Parameters("rundate").Value = Today
                            For i As Integer = 0 To rep.Parameters.Count - 1
                                If dt.Columns.Contains(rep.Parameters(i).Name.ToString) Then
                                    rep.Parameters(i).Value = dr.Item(rep.Parameters(i).Name)
                                End If
                            Next
                            reportviewer.DocumentViewer1.DocumentSource = rep
                            reportviewer.ShowDialog()
                            Dim fields As New Dictionary(Of String, String)
                            fields.Add("check_id", selectedRow.Cells(0).Value.ToString)
                            fields.Add("isPrinted", "1")
                            Dim qry As String = ATGenerateQuery("Update", "trans_checks", fields, Environment.MachineName, Environment.UserName, main.log_id, selectedRow.Cells(0).Value.ToString, "check_id")
                            Query(qry)
                            loadChecks()
                        End If
                    End If
            End Select
        ElseIf DialogResult = DialogResult.No Then


            '    Dim _withEntry As Boolean = withEntry.Checked
            '        Dim _print = txt_print.Value
            '        Dim _general_id = general_id.Value

            '        'Dim _cutParticulars = cutParticulars.Checked
            '        'Dim _vouchInPeso = vouchInPeso.Checked

            '        'Dim _entries = getRdoValue(option1)
            '        Dim _invoice = getRdoValue(option2)
            '        Dim _currency = getRdoValue(option5)
            '        Dim _client = getRdoValue(option6_1)

            '        Dim _invoice_from = invoice_from.Value
            '        Dim _invoice_to = invoice_to.Value

            '        Dim _trans_no_from = invoice_from.Text
            '        Dim _trans_no_to = invoice_to.Text

            '        Dim _date_from = date_from.Value.ToString("yyyy-MM-dd")
            '        Dim _date_to = date_to.Value.ToString("yyyy-MM-dd")

            '        '   sys_default
            '        sql_sys_default = String.Format("SELECT a.company_id,b.company_name,b.address1 AS address,b.tel_no,b.fax_no,b.tin " &
            '                                            "FROM sys_default a " &
            '                                            "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id ", _serverDBFS)
            '        '   header
            '        sql_header = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,b.currency_name, " &
            '                                   "b.currency_code,a.amount,a.amount_based,a.exchange_rate, " &
            '                                   "a.based_rate,a.description,a.general_id,c.general_code,c.general_name, " &
            '                                   "c.address1 AS address,c.attention, " &
            '                                   "IF(a.status = 'A','Approved',(IF(a.status = 'C','Cancelled',''))) AS status " &
            '                                   ",d.si_no,d.rr_no,b.symbol
            '                           ,f.user_id,f.username,f.user_fullname
            '                           ,e.book_code,e.book_name " &
            '                                    "FROM trans_header a " &
            '                                    "LEFT JOIN {1}.lib_erp_currency b ON b.currency_id = a.currency_id " &
            '                                    "LEFT JOIN {1}.lib_erp_general c ON c.general_id = a.general_id " &
            '                                    "LEFT JOIN {2}.trans_header_cv d ON d.trans_id = a.trans_id " &
            '                                    "LEFT JOIN {1}.lib_erp_book e ON e.book_id = a.book_id " &
            '                                    "LEFT JOIN (
            '                                    SELECT a.trans_id,c.user_id,c.username,c.user_fullname
            '                                    FROM {2}_at.trans_header a
            '                                    LEFT JOIN sys_log b ON b.log_id = a.log_id
            '                                    LEFT JOIN {1}.sys_erp_user c ON c.user_id = b.user_id
            '                                    WHERE a.transmode = 'Insert'
            '                                    GROUP BY a.trans_id
            '                               ) f ON f.trans_id = a.trans_id " &
            '                                    "WHERE a.journal_id = {0} AND e.company_id = '{3}' ", journal_id, _serverDBFS, _serverDBMain, main.Sys_Default.Rows(0).Item("company_id").ToString())

            '        '   additional
            '        sql_additional = String.Format("SELECT a.trans_additional_id, a.trans_id, a.ors_burs_no, a.fund_cluster, a.mode_of_payment from {2}.trans_additional a WHERE a.trans_id = {0} ", transid, _serverDBFS, _serverDBMain)
            '    sql_mfo_pap = String.Format("SELECT * from {2}.trans_mfo_pap a WHERE a.trans_id = {0} ", transid, _serverDBFS, _serverDBMain)
            '    '   jbooks
            '    sql_jbooks = String.Format("SELECT a.trans_id,a.jbooks_id,b.account_code,b.account_name " &
            '            ",a.debit,a.credit,a.debit_based,a.credit_based,c.general_code,c.general_name,i.trans_no AS ref_ref_no " &
            '            ",f.project_code,f.project_name,g.department_code,g.department_name,h.allocation_code,k.bank_name,concat(j.check_no,' - ', date_format(j.check_date,'%m/%d/%Y')) as check_no,j.check_no as check_no_only,b.validation,a.line_remarks " &
            '            "FROM trans_jbooks a " &
            '            "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
            '            "LEFT JOIN {1}.lib_erp_general c ON c.general_id = a.general_id " &
            '            "LEFT JOIN {2}.trans_jbooks d ON d.jbooks_id = a.ref_jbooks_id " &
            '            "LEFT JOIN {2}.trans_header i ON i.trans_id = d.trans_id " &
            '            "LEFT JOIN {2}.trans_header e ON e.trans_id = a.trans_id " &
            '            "LEFT JOIN {1}.lib_erp_project f ON f.project_id = a.project_id " &
            '            "LEFT JOIN {1}.lib_erp_department g ON g.department_id = a.department_id " &
            '            "LEFT JOIN {1}.lib_erp_allocation h ON h.allocation_id = a.allocation_id " &
            '            "LEFT JOIN {2}.trans_checks j ON j.jbooks_id = a.jbooks_id " &
            '            "LEFT JOIN {1}.lib_erp_bank k ON k.bank_id = j.bank_id " &
            '            "WHERE e.journal_id = {0} ", journal_id, _serverDBFS, _serverDBMain)
            '        If _print = "1" Then
            '            sql_jbooks &= "GROUP BY a.jbooks_id "
            '        End If
            '        sql_jbooks &= "order by IF(a.debit <> 0,1,2),b.account_code"
            '    sql_particular = String.Format("SELECT a.trans_particular_id,a.trans_id,a.trans_particular_code " &
            '            ",a.trans_particular_name,a.trans_particular_amount " &
            '            "FROM trans_header_particular a where a.trans_id = {0} ", transid)
            '    sql_signatory = String.Format("SELECT a.user_signatory_id,a.user_id,a.label1,a.user_id1 " &
            '            ",a.position1,a.label2,a.user_id2,a.position2,a.label3,a.user_id3,a.position3 " &
            '            ",a.label4,a.user_id4,a.position4,a.label5,a.user_id5,a.position5 " &
            '            ",b.username,b.user_fullname " &
            '            ",c.username AS username1,c.user_fullname AS user_fullname1 " &
            '            ",d.username AS username2,d.user_fullname AS user_fullname2 " &
            '            ",e.username AS username3,e.user_fullname AS user_fullname3 " &
            '            ",f.username AS username4,f.user_fullname AS user_fullname4 " &
            '            ",g.username AS username5,g.user_fullname AS user_fullname5 " &
            '            ",h.module_code,h.module_name " &
            '            "FROM sys_erp_user_signatory a " &
            '            "LEFT JOIN sys_erp_user b ON b.user_id = a.user_id " &
            '            "LEFT JOIN sys_erp_user c ON c.user_id = a.user_id1 " &
            '            "LEFT JOIN sys_erp_user d ON d.user_id = a.user_id2 " &
            '            "LEFT JOIN sys_erp_user e ON e.user_id = a.user_id3 " &
            '            "LEFT JOIN sys_erp_user f ON f.user_id = a.user_id4 " &
            '            "LEFT JOIN sys_erp_user g ON g.user_id = a.user_id5 " &
            '            "LEFT JOIN sys_erp_modules h ON h.module_id = a.module_id " &
            '            "WHERE a.user_id = '{0}' AND h.module_code = '{1}' " &
            '            "", main.user_id, "ACC00401")

            '        Dim col As New List(Of KeyValuePair(Of String, String))
            '        col.Add(New KeyValuePair(Of String, String)("@module_code", "ACC00401"))
            '        Dim dt_template = ExecuteWithParameter("get_lib_acc_voucher_template", ConnectionStringFS, CommandType.StoredProcedure, col)

            '    Select Case _print
            '        Case "1" ' Invoice
            '            If _invoice_from = "" Or _invoice_to = "" Then
            '                MsgBox("Complete the filter first.")
            '                Exit Sub
            '            End If

            '            sql_header &= String.Format("AND a.trans_no BETWEEN '{0}' AND '{1}' ", _trans_no_from, _trans_no_to)

            '            ' Print Invoice With Entries
            '            '   _invoice_from
            '            '   _invoice_to
            '            '   _currency
            '            createData()

            '            For Each row As DataRow In ds.Tables("Header").Rows
            '                row.Item("amount_word") = amount_words(Format(ifNull(row.Item("amount"), 0), "n2"))
            '                For Each dr As DataRow In ds.Tables("jbooks").Rows
            '                    If dr.Item("trans_id") = row.Item("trans_id") Then
            '                        If dr.Item("ref_ref_no").ToString <> "" Then
            '                            row.Item("dn_ref") &= "," & dr.Item("ref_ref_no")
            '                        End If
            '                        If dr.Item("bank_name").ToString <> "" Then
            '                            row.Item("bank_name") &= "," & dr.Item("bank_name")
            '                        End If
            '                        If dr.Item("check_no").ToString <> "" Then
            '                            row.Item("check_no") &= "," & dr.Item("check_no")
            '                        End If
            '                        If dr.Item("check_no_only").ToString <> "" Then
            '                            row.Item("check_no_only") &= "," & dr.Item("check_no_only")
            '                        End If
            '                    End If
            '                Next
            '                If row.Item("dn_ref").ToString <> "" Then
            '                    row.Item("dn_ref") = row.Item("dn_ref").ToString.Substring(1)
            '                End If
            '                If row.Item("bank_name").ToString <> "" Then
            '                    row.Item("bank_name") = row.Item("bank_name").ToString.Substring(1)
            '                End If
            '                If row.Item("check_no").ToString <> "" Then
            '                    row.Item("check_no") = row.Item("check_no").ToString.Substring(1)
            '                End If
            '                If row.Item("check_no_only").ToString <> "" Then
            '                    row.Item("check_no_only") = row.Item("check_no_only").ToString.Substring(1)
            '                End If
            '            Next

            '            If _currency = "1" Then
            '                For Each row As DataRow In ds.Tables("JBooks").Rows
            '                    row.Item("debit") = row.Item("debit_based")
            '                    row.Item("credit") = row.Item("credit_based")
            '                Next
            '            End If
            '            If _serverDBFS.Contains("erp_fs_drdc") Then
            '                Dim drTemplate As DataRow = txt_template_id.RowData
            '                If drTemplate IsNot Nothing Then
            '                    Dim file_location As String = drTemplate.Item("file_location").ToString
            '                    Dim rep As New XtraReport
            '                    Try
            '                        rep = rep.FromFile(file_location)
            '                        generateDuravilleReport(rep)
            '                    Catch ex As Exception
            '                        MsgBox(String.Format("File Not Found : {0}", file_location))
            '                        Exit Sub
            '                    End Try
            '                Else
            '                    MsgBox("No Template Found")
            '                    Exit Sub
            '                End If
            '            Else

            '                If _currency = "1" Or _currency = "2" Then
            '                    'Dim rep As New dura_cv
            '                    Dim rep As New XtraReport
            '                    Try
            '                        rep = rep.FromFile(dt_template.Rows(6).Item("file_location").ToString())
            '                    Catch ex As Exception
            '                        MsgBox(String.Format("File Not Found : {0}", dt_template.Rows(6).Item("file_location").ToString()))
            '                        Exit Sub
            '                    End Try
            '                    Try
            '                        rep.Parameters("S001").Value = main.S001
            '                        rep.Parameters("S002").Value = main.S002
            '                        rep.Parameters("print_system_name").Value = main.system_name
            '                        rep.Parameters("print_username").Value = main.CurrentUsername
            '                    Catch ex As Exception
            '                    End Try
            '                    rep.DataSource = ds
            '                    Dim frm As String = ""

            '                    frm = "#,##0.00000000000000000000"
            '                    frm = frm.Substring(0, 6 + main.Sys_Default.Rows(0).Item("decimal_places"))

            '                    'rep.DataMember = "Header"
            '                    generateReport(rep, withProject.Checked, withDepartment.Checked, withAllocation.Checked)

            '                    If rep.FindControl("amount", False) IsNot Nothing Then
            '                        'rep.FindControl("amount", False).TextFormatString = "{0:" & frm & "}"
            '                    End If
            '                    If rep.FindControl("runtime", False) IsNot Nothing Then
            '                        rep.FindControl("runtime", False).Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
            '                    End If
            '                    If rep.FindControl("company_logo", False) IsNot Nothing Then
            '                        DirectCast(rep.FindControl("company_logo", False), XRPictureBox).ImageUrl = Application.StartupPath & "/img/logo.png"
            '                    End If
            '                    ''
            '                    Dim rpt_sub_particular As XtraReport = New XtraReport()
            '                    Dim rpt_sub_additional As XtraReport = New XtraReport()

            '                    rpt_sub_particular.LoadLayout(Application.StartupPath & "/repx/Particulars.repx")
            '                    rpt_sub_additional.LoadLayout(Application.StartupPath & "/repx/Additional.repx")


            '                    For Each band1 As Band In rep.Band

            '                        For Each ctrlx As XRControl In band1.Controls

            '                            If ctrlx.Name = "Detail1" Then

            '                                For Each ctrlx2 As XRControl In ctrlx.Controls

            '                                    If ctrlx2.Name = "sub_report_particular" Then
            '                                        CType(ctrlx2, XRSubreport).ReportSource = rpt_sub_particular
            '                                    End If

            '                                    If ctrlx2.Name = "sub_report_additional" Then
            '                                        CType(ctrlx2, XRSubreport).ReportSource = rpt_sub_additional
            '                                    End If
            '                                Next
            '                            End If
            '                        Next
            '                    Next


            '                    rpt_sub_particular.Report.DataSource = ds
            '                    rpt_sub_additional.Report.DataSource = ds.Tables("mfo_pap")

            '                    'For Each row As DataRow In ds.Tables("additional").Rows
            '                    '    If row.Item("mode_of_payment").ToString = "MDS check" Then

            '                    '    End If

            '                    'Next

            '                    reportviewer.DocumentViewer1.DocumentSource = rep
            '                    reportviewer.ShowDialog()
            '                End If
            '            End If
            '    End Select
            Me.Close()
        End If
    End Sub
    'end of events declaration
    Public Sub generateReport(ByVal rep As XtraReport, ByVal withProject As Boolean, ByVal withDepartment As Boolean, ByVal withAllocation As Boolean, Optional withCompare As Boolean = False)

        Dim ds As DataSet = (CType(rep.DataSource, DataSet))
        'rep.DataMember = "JBooks"
        Dim tblHeader As New XRTable
        Dim tblDetail As New XRTable
        Dim tblSubDetail As New XRTable

        Dim rowHeader As New XRTableRow
        Dim rowDetail As New XRTableRow
        Dim rowSubDetail As New XRTableRow

        tblHeader.HeightF = rep.FindControl("panel_header", False).HeightF
        tblHeader.WidthF = rep.FindControl("panel_header", False).WidthF
        tblHeader.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        tblHeader.Font = New Font(rep.Font.FontFamily, rep.Font.Size, FontStyle.Bold)
        tblHeader.BeginInit()

        tblDetail.HeightF = rep.FindControl("panel_detail", False).HeightF
        tblDetail.WidthF = rep.FindControl("panel_detail", False).WidthF
        tblDetail.Borders = DevExpress.XtraPrinting.BorderSide.None
        tblDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        tblDetail.BeginInit()

        If withCompare Then
            tblSubDetail.HeightF = rep.FindControl("panel_sub_detail", False).HeightF
            tblSubDetail.WidthF = rep.FindControl("panel_sub_detail", False).WidthF
            tblSubDetail.Borders = DevExpress.XtraPrinting.BorderSide.None
            tblSubDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            tblSubDetail.BeginInit()
        End If

        Dim cellHeaderCode As New XRTableCell
        Dim cellHeaderTitle As New XRTableCell
        Dim cellHeaderProject As New XRTableCell
        Dim cellHeaderDepartment As New XRTableCell
        Dim cellHeaderAllocation As New XRTableCell
        Dim cellHeaderDebit As New XRTableCell
        Dim cellHeaderCredit As New XRTableCell
        Dim cellHeaderGenRef As New XRTableCell
        Dim cellHeaderDNRef As New XRTableCell

        Dim cellDetailCode As New XRTableCell
        Dim cellDetailTitle As New XRTableCell
        Dim cellDetailProject As New XRTableCell
        Dim cellDetailDepartment As New XRTableCell
        Dim cellDetailAllocation As New XRTableCell
        Dim cellDetailDebit As New XRTableCell
        Dim cellDetailCredit As New XRTableCell
        Dim cellDetailGenRef As New XRTableCell
        Dim cellDetailDNRef As New XRTableCell

        Dim cellDetailBlank100 As New XRTableCell
        Dim cellDetailBlank200 As New XRTableCell
        Dim cellDetailBlank1 As New XRTableCell
        Dim cellDetailBlank2 As New XRTableCell
        Dim cellDetailBlank3 As New XRTableCell
        Dim cellDetailBlank4 As New XRTableCell
        Dim cellDetailBlank5 As New XRTableCell
        Dim cellDetailDebitBased As New XRTableCell
        Dim cellDetailCreditBased As New XRTableCell

        cellHeaderCode.Text = "CODE"
        cellHeaderCode.WidthF = 100
        cellHeaderTitle.Text = "ACCOUNT TITLE"
        cellHeaderTitle.WidthF = 200
        cellHeaderProject.Text = "PROJECT"
        cellHeaderDepartment.Text = "DEPARTMENT"
        cellHeaderAllocation.Text = "ALLOCATION"
        cellHeaderDebit.Text = "DEBIT"
        cellHeaderCredit.Text = "CREDIT"
        cellHeaderGenRef.Text = "GEN.REF"
        cellHeaderDNRef.Text = "DN REF"

        cellDetailCode.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.account_code")
        cellDetailCode.WidthF = 100
        cellDetailCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        cellDetailTitle.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.account_name")
        cellDetailTitle.CanShrink = False
        cellDetailTitle.CanGrow = False
        cellDetailTitle.Multiline = False
        cellDetailTitle.WordWrap = False
        cellDetailTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        cellDetailTitle.WidthF = 200
        cellDetailProject.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.project_code")
        cellDetailDepartment.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.department_code")
        cellDetailAllocation.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.allocation_code")
        cellDetailDebit.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.debit")
        cellDetailDebit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        cellDetailDebit.TextFormatString = "{0:#,##0.00}"
        cellDetailCredit.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.credit")
        cellDetailCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        cellDetailCredit.TextFormatString = "{0:#,##0.00}"
        cellDetailGenRef.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.general_code")
        cellDetailDNRef.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.ref_ref_no")

        cellDetailBlank100.WidthF = 100
        cellDetailBlank200.WidthF = 200
        cellDetailDebitBased.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.debit_based")
        cellDetailCreditBased.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.credit_based")

        rowHeader.Cells.Add(cellHeaderCode)
        rowHeader.Cells.Add(cellHeaderTitle)

        rowDetail.Cells.Add(cellDetailCode)
        rowDetail.Cells.Add(cellDetailTitle)

        If withProject Then
            rowHeader.Cells.Add(cellHeaderProject)
            rowDetail.Cells.Add(cellDetailProject)
        End If

        If withDepartment Then
            rowHeader.Cells.Add(cellHeaderDepartment)
            rowDetail.Cells.Add(cellDetailDepartment)
        End If

        If withAllocation Then
            rowHeader.Cells.Add(cellHeaderAllocation)
            rowDetail.Cells.Add(cellDetailAllocation)
        End If

        If withCompare Then
            rowSubDetail.Cells.Add(cellDetailBlank100)
            rowSubDetail.Cells.Add(cellDetailBlank200)
            If withProject Then
                rowSubDetail.Cells.Add(cellDetailBlank1)
            End If
            If withDepartment Then
                rowSubDetail.Cells.Add(cellDetailBlank2)
            End If
            If withAllocation Then
                rowSubDetail.Cells.Add(cellDetailBlank3)
            End If
            rowSubDetail.Cells.Add(cellDetailDebitBased)
            rowSubDetail.Cells.Add(cellDetailCreditBased)
            rowSubDetail.Cells.Add(cellDetailBlank4)
            rowSubDetail.Cells.Add(cellDetailBlank5)
        End If

        rowHeader.Cells.Add(cellHeaderDebit)
        rowHeader.Cells.Add(cellHeaderCredit)
        rowHeader.Cells.Add(cellHeaderGenRef)
        rowHeader.Cells.Add(cellHeaderDNRef)

        rowDetail.Cells.Add(cellDetailDebit)
        rowDetail.Cells.Add(cellDetailCredit)
        rowDetail.Cells.Add(cellDetailGenRef)
        rowDetail.Cells.Add(cellDetailDNRef)

        tblHeader.Rows.Add(rowHeader)
        tblDetail.Rows.Add(rowDetail)
        tblSubDetail.Rows.Add(rowSubDetail)

        tblHeader.EndInit()
        tblDetail.EndInit()
        tblSubDetail.EndInit()

        If ds.Tables("Signatory").Rows.Count > 0 Then
            Dim pageWidth As Int32 = rep.PageWidth
            Dim marginLeft As Int32 = rep.Margins.Left
            Dim marginRight As Int32 = rep.Margins.Right
            Dim paperWidth = pageWidth - (marginLeft + marginRight)
            If rep.FindControl("panel_signatory", True) IsNot Nothing Then
                Dim dicSignatory As New Dictionary(Of String, Dictionary(Of String, String))
                Dim dr As DataRow = ds.Tables("Signatory").Rows(0)
                Dim ctr As Integer = 0
                Dim row_ctr As Integer = 0
                Dim col_ctr As Integer = 0
                For i As Integer = 1 To 5
                    If dr.Item("label" & i).ToString <> "" Then
                        Dim newDic As New Dictionary(Of String, String)
                        newDic.Add("label" & ctr, dr.Item("label" & i).ToString)
                        newDic.Add("user_fullname" & ctr, dr.Item("user_fullname" & i).ToString)
                        newDic.Add("position" & ctr, dr.Item("position" & i).ToString)
                        dicSignatory.Add("signatory" & ctr, newDic)
                        ctr += 1
                    End If
                Next
                If ctr > 0 Then
                    For i As Integer = 0 To ctr - 1
                        Dim tableMarginLeft As Integer = 10
                        Dim tableWidth As Integer = paperWidth / ctr - (tableMarginLeft * (ctr - 1))

                        Dim tmp_table As New XRTable
                        tmp_table.WidthF = tableWidth
                        tmp_table.HeightF = 100
                        tmp_table.Borders = DevExpress.XtraPrinting.BorderSide.None
                        tmp_table.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                        tmp_table.Font = New Font(rep.Font.FontFamily, 10, FontStyle.Regular)
                        tmp_table.BeginInit()
                        Dim rowLabel As New XRTableRow
                        Dim cellLabel As New XRTableCell
                        cellLabel.Text = dicSignatory.Item("signatory" & i).Item("label" & i).ToString
                        cellLabel.HeightF = 20
                        cellLabel.WidthF = tableWidth
                        rowLabel.Cells.Add(cellLabel)
                        Dim rowSign As New XRTableRow
                        Dim cellSign As New XRTableCell
                        cellSign.Text = ""
                        cellSign.HeightF = 40
                        rowSign.HeightF = 40
                        cellSign.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                        cellSign.BorderWidth = 1
                        cellSign.BorderColor = Color.Black
                        rowSign.Cells.Add(cellSign)
                        Dim rowName As New XRTableRow
                        Dim cellName As New XRTableCell
                        cellName.Text = dicSignatory.Item("signatory" & i).Item("user_fullname" & i).ToString.ToUpper
                        cellName.WidthF = tableWidth
                        cellName.HeightF = 20
                        rowName.Cells.Add(cellName)
                        Dim rowPosition As New XRTableRow
                        Dim cellPosition As New XRTableCell
                        cellPosition.Text = dicSignatory.Item("signatory" & i).Item("position" & i).ToString.ToUpper
                        cellPosition.WidthF = tableWidth
                        cellPosition.HeightF = 20
                        rowPosition.Cells.Add(cellPosition)
                        tmp_table.Rows.Add(rowLabel)
                        tmp_table.Rows.Add(rowSign)
                        tmp_table.Rows.Add(rowName)
                        tmp_table.Rows.Add(rowPosition)
                        tmp_table.EndInit()
                        rep.FindControl("panel_signatory", False).Controls.Add(tmp_table)

                        Dim panel_signatory = rep.FindControl("panel_signatory", False)
                        Dim margin = rep.Margins.Left + rep.Margins.Right
                        Dim width = rep.PageWidth - margin
                        Dim tableHeight As Integer = 80

                        Dim tableMarginTop As Integer = 5
                        Dim tmpMarginLeft As Integer = 0
                        Dim tmpMarginTop As Integer = 0
                        Dim x As Integer = 0
                        Dim y As Integer = 0

                        If ctr <= 5 Then
                            x = (tableMarginLeft * col_ctr) + (tableWidth * col_ctr)
                            tmp_table.LocationF = New PointF(x, y)
                            panel_signatory.WidthF = (tableWidth * ctr) + (tableMarginLeft * (ctr - 1))
                            panel_signatory.HeightF = tableHeight + tmpMarginTop
                            panel_signatory.LocationF = New PointF((width / 2) - (panel_signatory.WidthF / 2), panel_signatory.LocationF.Y)
                            col_ctr += 1
                        ElseIf ctr = 4 Then
                            panel_signatory.HeightF = (tableHeight * 2) + tableMarginTop
                            panel_signatory.WidthF = (tableWidth * 2) + tableMarginLeft
                            panel_signatory.LocationF = New PointF((width / 2) - (panel_signatory.WidthF / 2), panel_signatory.LocationF.Y)
                            If row_ctr = 0 Then
                                y = 0
                                x = (tableMarginLeft * col_ctr) + (tableWidth * col_ctr)
                                If col_ctr = 0 Then
                                    col_ctr += 1
                                Else
                                    col_ctr = 0
                                    row_ctr += 1
                                End If
                            Else
                                y = (tableHeight * row_ctr) + tableMarginTop
                                x = (tableMarginLeft * col_ctr) + (tableWidth * col_ctr)
                                If col_ctr = 0 Then
                                    col_ctr += 1
                                Else
                                    col_ctr = 0
                                    row_ctr += 1
                                End If
                            End If
                            tmp_table.LocationF = New PointF(x, y)
                        ElseIf ctr = 5 Then
                            panel_signatory.HeightF = (tableHeight * 2) + tableMarginTop
                            panel_signatory.WidthF = (tableWidth * 3) + (tableMarginLeft * 2)
                            panel_signatory.LocationF = New PointF((width / 2) - (panel_signatory.WidthF / 2), panel_signatory.LocationF.Y)
                            tmpMarginLeft = 0
                            If row_ctr = 0 Then
                                y = 0
                                x = (tableMarginLeft * col_ctr) + (tableWidth * col_ctr)
                                If col_ctr <= 1 Then
                                    col_ctr += 1
                                Else
                                    col_ctr = 0
                                    row_ctr += 1
                                End If
                            Else
                                y = (tableHeight * row_ctr) + tableMarginTop
                                x = (tableMarginLeft * col_ctr) + (tableWidth * col_ctr) + (tableWidth / 2)
                                If col_ctr = 0 Then
                                    col_ctr += 1
                                Else
                                    col_ctr = 0
                                    row_ctr += 1
                                End If
                            End If
                            tmp_table.LocationF = New PointF(x, y)
                        End If
                    Next
                End If
            End If
        End If

        rep.FindControl("panel_header", False).Controls.Add(tblHeader)
        rep.FindControl("panel_detail", False).Controls.Add(tblDetail)
        If withCompare Then
            rep.FindControl("panel_sub_detail", False).Controls.Add(tblSubDetail)
        End If
    End Sub
    Private Sub generateDuravilleReport(ByRef rep As XtraReport)
        For Each drHead As DataRow In ds.Tables("Header").Rows
            Dim trans_id = drHead.Item("trans_id").ToString
            'particular
            Dim str_particular As String = drHead.Item("description").ToString
            Dim myParticulars = ds.Tables("Particulars").Select(String.Format("trans_id = '{0}'", trans_id))
            Dim myJBooks = ds.Tables("JBooks").Select(String.Format("trans_id = '{0}'", trans_id))
            For Each dr As DataRow In myParticulars
                Dim tmp_amount As String = ""
                Dim new_str As String = ""
                If dr.Item("trans_particular_amount").ToString <> "" And dr.Item("trans_particular_amount") > 0 Then
                    tmp_amount = String.Format("{0:##,##0.00}", dr.Item("trans_particular_amount"))
                End If
                new_str = dr.Item("trans_particular_code").ToString & dr.Item("trans_particular_name").ToString
                new_str = new_str.PadRight(32, " ")
                AddLine(str_particular, new_str)
                AddString(str_particular, tmp_amount, 10)
            Next
            drHead.Item("MyParticular") = str_particular
            'amount
            Dim str_amount As String = ""
            For Each dr As DataRow In myJBooks
                Dim tmp_amount As String = ""
                If dr.Item("validation").ToString = "1" Then
                    If dr.Item("credit").ToString <> "" And dr.Item("credit") > 0 Then
                        tmp_amount = String.Format("{0:##,##0.00}", dr.Item("credit"))
                    End If
                    If tmp_amount.Trim() <> "" Then
                        AddLine(str_amount, drHead.Item("symbol").ToString & tmp_amount)
                    End If
                End If
            Next
            ds.Tables("Header").AcceptChanges()
            drHead.Item("MyAmount") = str_amount
        Next
        rep.DataSource = ds
        'rep.img_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
        'If Not withTemplate Then
        '    For Each ctrl In rep.GroupHeader1.Controls
        '        If Not ctrl.tag.ToString.Contains("visible") Then
        '            ctrl.visible = False
        '        End If
        '    Next
        '    For Each ctrl In rep.Detail.Controls
        '        If Not ctrl.tag.ToString.Contains("visible") Then
        '            ctrl.visible = False
        '        End If
        '    Next
        '    For Each ctrl In rep.GroupFooter1.Controls
        '        If Not ctrl.tag.ToString.Contains("visible") Then
        '            ctrl.visible = False
        '        End If
        '    Next
        'End If
        reportviewer.DocumentViewer1.DocumentSource = rep
        reportviewer.ShowDialog()
    End Sub
    Private Sub AddLine(ByRef varStr As String, ByVal str As String)
        varStr &= vbNewLine & str
    End Sub
    Private Sub AddString(ByRef varStr As String, ByVal str As String, Optional num As Integer = 100)
        varStr &= str.PadLeft(num, " ")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, withPrintedCheck.CheckedChanged
        If OriginalDT IsNot Nothing Then
            Dim q = txtSearch.Text.Trim().Replace("'", "").Replace("%", "")
            Dim wPrintedCheck As Boolean = withPrintedCheck.Checked
            Dim dt As DataTable = OriginalDT.Clone()
            'If q <> "" Then
            'End If
            Dim selectStr As String = String.Format("(trans_no LIKE '%{0}%' OR general_name LIKE '%{0}%' OR check_no LIKE '%{0}%')", q)
            If Not wPrintedCheck Then
                selectStr &= String.Format(" AND isPrinted = False")
            End If
            Dim drs = OriginalDT.Select(selectStr)
            dt.Clear()
            For Each dr As DataRow In drs
                dt.ImportRow(dr)
            Next
            dgSelection.DataSource = dt
        End If
    End Sub

    Private Sub txt_template_id_Leave(sender As Object, e As EventArgs) Handles txt_template_id.Leave

        Dim dt As DataTable = FsQuery(String.Format("SELECT template_id,template_code,template_name,file_location
            FROM lib_acc_template
            WHERE company_id = '{0}'
            ", main.Sys_Default.Rows(0).Item("company_id").ToString()))
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("template_code like '{0}'", txt_template_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "template_code,template_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            'Dim idasd = browse.dgview.
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_template_id.RowData = dr
                txt_template_id.Value = dr("template_id")
                txt_template_id.Text = dr("template_code")
            End If
        End If

    End Sub

    Private Sub dgSelection_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgSelection.CellFormatting
        For Each row As DataGridViewRow In dgSelection.Rows
            If CBool(row.Cells("isPrinted").Value) Then
                row.DefaultCellStyle.BackColor = Color.Green
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub
End Class