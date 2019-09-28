Imports System.Windows.Forms
Imports System.Drawing
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Public Class report_ib_filter_new
    'raymond - 2016-06-10

    'initialization
    Dim ds As New trans_dataset
    Dim sql_sys_default As String = ""
    Dim sql_header As String = ""
    Dim sql_jbooks As String = ""
    Dim sql_particular As String = ""
    Dim sql_signatory As String = ""

    Private _journalid As String
    Private _bookid As String
    Private _transid As String
    Private _transno As String
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

    Public Property book_id() As String
        Get
            Return _bookid
        End Get
        Set(ByVal value As String)
            _bookid = value
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
        End Set
    End Property
    'end of properties

    'sub and function declaration
    Private Sub hideAllOptions()
        'option1.Visible = False
        option2.Visible = False
        option3.Visible = False
        option4.Visible = False
        option5.Visible = False
        option6.Visible = False
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
            'particular
            Dim dt_particular As DataTable = Query(sql_particular)
            For Each row As DataRow In dt_particular.Rows
                ds.Tables("Particulars").ImportRow(row)
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

    'events declaration
    Private Sub report_ib_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideAllOptions()
        option6_2.Visible = False
        invoice_from.Text = transno
        invoice_from.Value = transid
        invoice_to.Text = transno
        invoice_to.Value = transid
        txt_print.Text = "Sales Voucher"
        txt_print_Leave(Nothing, Nothing)
        invoice_from.Text = transno
        invoice_to.Text = transno
        invoice_Leave(invoice_from, Nothing)
        invoice_Leave(invoice_to, Nothing)
        withProject.Checked = main.Sys_Default.Rows(0).Item("w_proj")
        withDepartment.Checked = main.Sys_Default.Rows(0).Item("w_dept")
        withAllocation.Checked = main.Sys_Default.Rows(0).Item("w_alloc")
    End Sub

    Private Sub txt_print_Leave(sender As Object, e As EventArgs) Handles txt_print.Leave
        Dim dt As DataTable = FsQuery("SELECT 'Sales Voucher' AS name,'' AS code,1 AS id UNION SELECT 'Sales Voucher List','',2")
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
                Dim dra() As DataRow = dt.Select(String.Format("trans_no like '{0}'", sender.Text.ToString.Replace("'", "''")))
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
                Dim dra() As DataRow = dt.Select(String.Format("general_code like '{0}'", general_id.Text.ToString.Replace("'", "''")))
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
        Select Case print
            Case "1"
                'option1.Visible = True
                option2.Visible = False
                'Rdo_button1.Checked = False
                'Rdo_button1.Checked = True
                option3.Visible = True
                option4.Visible = False
                option6.Visible = False
                'option7.Visible = False
            Case "2"
                'option1.Visible = False
                option2.Visible = True
                Rdo_button6.Checked = False
                Rdo_button6.Checked = True
        End Select
        option5.Visible = True
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
        sql_header = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,b.currency_name,b.currency_code,b.symbol,a.amount,a.amount_based,a.exchange_rate,a.based_rate,a.description,a.general_id,c.general_code,c.general_name,c.address1 AS address,c.attention,IF(a.status = 'A','Approved',(IF(a.status = 'C','Cancelled',''))) AS status " &
                                   ",d.due_date,d.si_no,d.dr_no,d.po_no,d.terms_id,d.nodays,e.terms_name
                                   ,g.user_id,g.username,g.user_fullname
                                   ,f.book_code,f.book_name " &
                                       "FROM trans_header a " &
                                       "LEFT JOIN {1}.lib_erp_currency b ON b.currency_id = a.currency_id " &
                                       "LEFT JOIN {1}.lib_erp_general c ON c.general_id = a.general_id " &
                                       "LEFT JOIN {2}.trans_header_ib d ON d.trans_id = a.trans_id " &
                                       "LEFT JOIN {1}.lib_erp_terms e ON e.terms_id = d.terms_id " &
                                       "LEFT JOIN {1}.lib_erp_book f ON f.book_id = a.book_id " &
                                       "LEFT JOIN (
                                            SELECT a.trans_id,c.user_id,c.username,c.user_fullname
                                            FROM {2}_at.trans_header a
                                            LEFT JOIN sys_log b ON b.log_id = a.log_id
                                            LEFT JOIN {1}.sys_erp_user c ON c.user_id = b.user_id
                                            WHERE a.transmode = 'Insert'
                                            GROUP BY a.trans_id
                                       ) g ON g.trans_id = a.trans_id " &
                                       "WHERE a.journal_id = {0} AND f.company_id = '{3}' ", journal_id, _serverDBFS, _serverDBMain, main.Sys_Default.Rows(0).Item("company_id").ToString())
        '   jbooks
        sql_jbooks = String.Format("SELECT a.trans_id,a.jbooks_id,b.account_code,b.account_name,a.debit,a.credit,a.debit_based,a.credit_based,c.general_code,c.general_name,i.trans_id AS ref_ref_no,f.project_code,f.project_name " &
                                   ",g.department_code,g.department_name,h.allocation_code,a.line_remarks " &
                                       "FROM trans_jbooks a " &
                                       "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                                       "LEFT JOIN {1}.lib_erp_general c ON c.general_id = a.general_id " &
                                       "LEFT JOIN {2}.trans_jbooks d ON d.jbooks_id = a.ref_jbooks_id " &
                                       "LEFT JOIN {2}.trans_header i ON i.trans_id = d.trans_id " &
                                       "LEFT JOIN {2}.trans_header e ON e.trans_id = a.trans_id " &
                                       "LEFT JOIN {1}.lib_erp_project f ON f.project_id = a.project_id " &
                                       "LEFT JOIN {1}.lib_erp_department g ON g.department_id = a.department_id " &
                                       "LEFT JOIN {1}.lib_erp_allocation h ON h.allocation_id = a.allocation_id " &
                                       "WHERE e.journal_id = {0} order by (IF(a.debit > a.credit,0,1)) ASC,b.account_code", journal_id, _serverDBFS, _serverDBMain)
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
            "", main.user_id, "ACC00101")

        Dim col As New List(Of KeyValuePair(Of String, String))
        col.Add(New KeyValuePair(Of String, String)("@module_code", "ACC00101"))
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
                    row.Item("amount_word") = amount_words(Format(row.Item("amount"), "n2")).ToString.Replace("ONLY", row.Item("currency_name") & " ONLY")
                Next

                If _currency = "1" Then
                    For Each row As DataRow In ds.Tables("JBooks").Rows
                        row.Item("debit") = row.Item("debit_based")
                        row.Item("credit") = row.Item("credit_based")
                    Next
                End If

                If _currency = "1" Or _currency = "2" Then
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
                'MsgBox("Print Invoice With Entries")
            Case "2" ' Invoice List
                Select Case _invoice
                    Case "1" ' By Invoice No
                        ' Print Invoice List By Invoice No
                        '   _invoice_from
                        '   _invoice_to
                        sql_header &= String.Format("AND a.trans_no BETWEEN '{0}' AND '{1}' ", invoice_from.Text, invoice_to.Text)
                        sql_header &= String.Format(" ORDER BY a.trans_no ")
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
                            row.Item("amount_word") = amount_words(Format(row.Item("amount"), "n2"))
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
                        sql_header &= String.Format(" ORDER BY a.trans_no ")
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
                            row.Item("amount_word") = amount_words(Format(row.Item("amount"), "n2"))
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
                                    row.Item("amount_word") = amount_words(Format(row.Item("amount"), "n2"))
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
                                    row.Item("amount_word") = amount_words(Format(row.Item("amount"), "n2"))
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
        End Select
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
        cellDetailCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        cellDetailCode.WidthF = 100
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
        cellDetailDebit.DataBindings("Text").FormatString = "{0:#,##0.00}"
        cellDetailCredit.DataBindings.Add("Text", ds.Tables("Header"), "Header_JBooks.credit")
        cellDetailCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        cellDetailCredit.DataBindings("Text").FormatString = "{0:#,##0.00}"
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
End Class