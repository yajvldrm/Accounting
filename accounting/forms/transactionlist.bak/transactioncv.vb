Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports System.IO
Imports user_control
Imports System.Drawing

Public Class transactioncv

    'properties
    Private _pkName As String = "trans_id"
    Private _pkID As String = 0
    Private _mainList As Form
    Private _transMode As String

    Public Property pkName() As String
        Get
            Return _pkName
        End Get
        Set(value As String)
            _pkName = value
        End Set
    End Property

    Public Property pkID() As String
        Get
            Return _pkID
        End Get
        Set(value As String)
            _pkID = value
        End Set
    End Property

    Public Property mainList() As Transaction_List
        Get
            Return _mainList
        End Get
        Set(value As Transaction_List)
            _mainList = value
        End Set
    End Property

    Public Property transmode() As String
        Get
            Return _transMode
        End Get
        Set(value As String)
            _transMode = value
        End Set
    End Property

    Public Property colhdr As String = "Invoicing No,Date,Client,Currency"
    Public Property colfld As String = "trans_no,trans_date,general_name,currency_name"
    Public Property dbName As String = _serverDBMain
    Public Property tblName As String = "trans_header"
    'end of properties

    Private general As New DataTable
    Private currency As New DataTable
    Private chart As New DataTable
    Private terms As New DataTable
    Private project As New DataTable
    Private department As New DataTable
    Private allocation As New DataTable
    Private _journalid As String
    Private _journalcode As String
    Private _bookid As String
    Private _bookname As String
    Private module_code As String = "ACC00401"
    Private transmodedet As String = ""
    Public Shared currentDr As DataRow = Nothing

    Public Property journal_id() As String
        Get
            Return _journalid
        End Get
        Set(ByVal value As String)
            _journalid = value
        End Set
    End Property

    Public Property journal_code() As String
        Get
            Return _journalcode
        End Get
        Set(ByVal value As String)
            _journalcode = value
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

    Public Property book_name() As String
        Get
            Return _bookname
        End Get
        Set(ByVal value As String)
            _bookname = value
        End Set
    End Property

    Friend Sub formload()
        dgjbooks.AutoGenerateColumns = False
        dgjbooks.DataSource = ds.Tables("jbooks")
        ds.Tables("jbooks").DefaultView.Sort = "dc,account_code"
        disable_control()
        If main.Sys_Default.Rows(0)("line_remarks") = 0 Then
            lblLineRemarks.Visible = False
            txtlineremarks.Visible = False
            For Each obj As Control In det.Controls
                obj.Top -= 23
            Next
            det.Height -= 23
            Me.Height -= 23
        End If
        If main.Sys_Default.Rows(0)("line_currency") = 0 Then
            lblcurrency.Visible = False
            lblexchangerate.Visible = False
            lblbasedrate.Visible = False
            txt_currency_id.Visible = False
            txt_exchange_rate.Visible = False
            txt_based_rate.Visible = False
            For Each obj As Control In det.Controls
                obj.Top -= 23
            Next
            det.Height -= 23
            Me.Height -= 23
        End If
        If main.Sys_Default.Rows(0)("w_alloc") = 0 Then
            txtallocation.Visible = False
            lblAllocation.Visible = False
        End If
        If main.Sys_Default.Rows(0)("w_proj") = 0 Then
            txtproject.Visible = False
            lblProject.Visible = False
        End If
        If main.Sys_Default.Rows(0)("w_dept") = 0 Then
            txtdepartment.Visible = False
            lblDepartment.Visible = False
        End If
        If main.Sys_Default.Rows(0)("w_alloc") = 0 And main.Sys_Default.Rows(0)("w_proj") = 0 And main.Sys_Default.Rows(0)("w_dept") = 0 Then
            For Each obj As Control In det.Controls
                If obj.Tag IsNot Nothing Then
                    If obj.Tag.ToString <> "" And obj.Tag.ToString.Contains("adjustToTop") Then
                        obj.Top -= 23
                    End If
                End If
            Next
            det.Height -= 23
            Me.Height -= 23
        End If
    End Sub

    Private Sub transcv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formload()
    End Sub

    Private Sub clear_control()
        For Each ctrl As Control In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If ctr.NumberFormat.Substring(0, 1) = "#" Then
                    ctr.DecimalValue = 0.0
                Else
                    If Not ctr.NoClear Then
                        ctr.Value = ""
                        ctr.Text = ""
                    End If
                End If
            End If
        Next
        txttransid.Value = 0
        txttransid.Text = 0
        For i = 0 To ds.Tables.Count - 1
            If Not ds.Tables(i).TableName = "trans" Then
                ds.Tables(i).Rows.Clear()
            End If
        Next
        lbldebittotal.Text = Format(0, txtdebit.NumberFormat)
        lblcredittotal.Text = Format(0, txtdebitbased.NumberFormat)
        lbldifftotal.Text = Format(0, txtdebit.NumberFormat)
        lbldebitbasedtotal.Text = Format(0, txtdebitbased.NumberFormat)
        lblcreditbasedtotal.Text = Format(0, txtcreditbased.NumberFormat)
        lbldiffbasedtotal.Text = Format(0, txtdebit.NumberFormat)
        clear_control_det()
    End Sub

    Private Sub enable_control()
        btnSubmit.Visible = False
        btnApprove.Visible = False
        btnCorrection.Visible = False
        btnComment.Visible = False
        btnAdd.Visible = False
        btnEdit.Visible = False
        btnCancel.Visible = False
        btnPrint.Visible = False
        btnSettings.Visible = False
        btnSave.Visible = True
        btnNotSave.Visible = True
        btnInsert.Enabled = True
        btnUpdate.Enabled = True
        btnRemove.Enabled = True
        btnOK.Enabled = False
        btnUndo.Enabled = False
        dgjbooks.Enabled = True
        For Each ctrl As Control In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.AlwaysDisable Then
                    ctr.Enabled = True
                End If
            End If
        Next
        Dim dr As DataRow = main.Sys_Default_Det.Select("module_code = 'ACC00401'")(0)
        If dr("auto_number") = 0 Then
            txttransno.Enabled = True
        End If
        Dim dr2 As DataRow = main.Sys_Default.Rows(0)
        If dr2("line_remarks") = 0 Then
            txtdesc.Enabled = True
        End If
        If dr("auto_number") = 1 Then
            txtday.Focus()
        Else
            txttransno.Enabled = True
        End If
    End Sub

    Private Sub disable_control(Optional creator As Boolean = False, Optional dr As DataRow = Nothing)
        btnAdd.Visible = main.dicAction.Item(module_code).Item("m_add")
        btnEdit.Visible = main.dicAction.Item(module_code).Item("m_edit")
        btnCancel.Visible = main.dicAction.Item(module_code).Item("m_cancel")
        btnPrint.Visible = main.dicAction.Item(module_code).Item("m_print")
        btnSubmit.Visible = False
        btnApprove.Visible = False
        btnCorrection.Visible = False
        btnComment.Visible = False
        btnEdit.Enabled = False
        dgjbooks.Enabled = True
        If dr IsNot Nothing Then
            'get stage_id
            Dim _dr = main.dtStage.Select(String.Format("module_code = '{0}' AND user_id = '{1}'", module_code, main.user_id))
            If _dr.Count > 0 Then 'if user is one inside the stage
                If creator Then 'if user is the creator
                    'if the creator is the previous approver and status is for correction
                    If dr.Item("prev_approver").ToString = main.user_id And dr.Item("current_status").ToString = "2" Then
                        btnSubmit.Visible = True
                        btnEdit.Enabled = True
                    End If
                Else
                    'if current user is not the current approver
                    If dr.Item("current_approver").ToString <> main.user_id Then
                        'if the current status is for correction and the user is the previous approver
                        If dr.Item("prev_approver").ToString = main.user_id And dr.Item("current_status").ToString = "2" Then
                            btnApprove.Visible = True
                            btnCorrection.Visible = True
                            btnComment.Visible = True
                            btnEdit.Enabled = True
                        Else
                            'if submitted and 
                            If dr.Item("user_id").ToString = dr.Item("current_approver").ToString And dr.Item("prev_approver").ToString <> "" Then
                                btnApprove.Visible = True
                                btnCorrection.Visible = True
                                btnComment.Visible = True
                                btnEdit.Enabled = True
                            Else
                                If dr.Item("current_status").ToString = "1" Then
                                    btnApprove.Visible = True
                                    btnCorrection.Visible = True
                                    btnComment.Visible = True
                                    btnEdit.Enabled = True
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                'if not yet submitted
                If dr.Item("current_approver").ToString = dr.Item("user_id").ToString And (dr.Item("prev_approver").ToString = "" Or dr.Item("prev_approver").ToString <> main.user_id) Then
                    btnSubmit.Visible = True
                    btnEdit.Enabled = True
                Else
                    'if the transaction back to its creator and status is for correction
                    If dr.Item("user_id").ToString = dr.Item("prev_approver").ToString And dr.Item("current_status").ToString = "2" Then
                        btnSubmit.Visible = True
                        btnEdit.Enabled = True
                    End If
                End If
            End If
        End If
        btnSettings.Visible = True
        btnSave.Visible = False
        btnNotSave.Visible = False
        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnOK.Enabled = False
        btnUndo.Enabled = False
        For Each ctrl As Control In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            End If
        Next
    End Sub

    Private Sub clear_control_det()
        For Each ctrl As Control In det.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If ctr.NumberFormat.Substring(0, 1) = "#" Then
                    ctr.DecimalValue = 0.0
                Else
                    If Not ctr.NoClear Then
                        ctr.Value = ""
                        ctr.Text = ""
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub enable_control_det()
        If txtbasedrate.DecimalValue = 0 Then
            MsgBox("Unable to modify entries because the Based Rate amount is equal to zero.")
            Exit Sub
        End If
        btnSave.Enabled = False
        btnNotSave.Enabled = False
        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnOK.Enabled = True
        btnUndo.Enabled = True
        dgjbooks.Enabled = False
        For Each ctrl As Control In det.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.AlwaysDisable Then
                    ctr.Enabled = True
                End If
            End If
        Next
        Dim dr As DataRow = main.Sys_Default.Rows(0)
        If dr("line_remarks") = 1 Then
            lblLineRemarks.Visible = True
            txtlineremarks.Visible = True
        Else
            txtlineremarks.Enabled = True
            'lblLineRemarks.Visible = False
            'txtlineremarks.Visible = False
        End If
        If dr("w_proj") = 1 Then
            lblProject.Visible = True
            txtproject.Visible = True
            txtproject.Enabled = True
            'Else
            '    lblProject.Visible = False
            '    txtproject.Visible = False
        End If
        If dr("w_dept") = 1 Then
            lblDepartment.Visible = True
            txtdepartment.Visible = True
            txtdepartment.Enabled = True
            'Else
            '    lblDepartment.Visible = False
            '    txtdepartment.Visible = False
        End If
        If dr("w_alloc") = 1 Then
            lblAllocation.Visible = True
            txtallocation.Visible = True
            txtallocation.Enabled = True
            'Else
            '    lblAllocation.Visible = False
            '    txtallocation.Visible = False
        End If
        txtaccount.Focus()
    End Sub

    Private Sub disable_control_det()
        btnSave.Enabled = True
        btnNotSave.Enabled = True
        btnInsert.Enabled = True
        btnUpdate.Enabled = True
        btnRemove.Enabled = True
        btnOK.Enabled = False
        btnUndo.Enabled = False
        dgjbooks.Enabled = True
        For Each ctrl As Control In det.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            End If
        Next
    End Sub

    Friend Sub refresh_record()
        Dim sql As String = String.Format("SELECT currentapprover.user_id AS current_approver,currentapprover.status AS current_status " & _
            ",prevapprover.user_id AS prev_approver,prevapprover.status AS prev_status " & _
            ",creator.user_id,creator.stage_id " & _
            ",a.* " & _
            ",ifnull(b.trans_cv_id,'') as trans_cv_id,ifnull(b.si_no,'') as si_no,ifnull(b.rr_no,'') as rr_no " & _
            ",c.general_code,c.general_name " & _
            ",d.currency_code,d.currency_name " & _
            "from trans_header a " & _
            "left join trans_header_cv b on a.trans_id = b.trans_id " & _
            "left join {0}.lib_erp_general c on a.general_id = c.general_id " & _
            "left join {0}.lib_erp_currency d on a.currency_id = d.currency_id " & _
            "LEFT JOIN ( " & _
                "SELECT * " & _
                "FROM trans_header_status " & _
                "GROUP BY ref_id " & _
            ") creator ON creator.ref_id = a.trans_id " & _
            "LEFT JOIN ( " & _
                "SELECT b.* " & _
                "FROM ( " & _
                "SELECT MAX(approved_date) AS approved_date,ref_id " & _
                "FROM trans_header_status " & _
                "GROUP BY ref_id " & _
                ") a " & _
                "LEFT JOIN trans_header_status b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " & _
                "GROUP BY ref_id " & _
            ") currentapprover ON currentapprover.ref_id = a.trans_id " & _
            "LEFT JOIN ( " & _
                "SELECT b.* " & _
                "FROM ( " & _
                "SELECT MAX(b.approved_date) AS approved_date,b.ref_id,b.user_id " & _
                "FROM ( " & _
                    "SELECT MAX(approved_date) AS approved_date,ref_id,user_id,status " & _
                    "FROM trans_header_approval " & _
                    "GROUP BY ref_id,user_id " & _
                ") a " & _
                "LEFT JOIN trans_header_approval b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " & _
                "WHERE b.status <> 2 " & _
                "GROUP BY b.ref_id " & _
                "ORDER BY b.approved_date " & _
                ") a " & _
                "LEFT JOIN trans_header_approval b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " & _
            ") prevapprover ON prevapprover.ref_id = a.trans_id " & _
            "WHERE a.trans_id = '{1}'; " & _
        "", _serverDBFS, pkID)
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count > 0 Then
            txttransid.Text = dt.Rows(0).Item("trans_id").ToString
            txttranscvid.Text = dt.Rows(0).Item("trans_cv_id").ToString
            Dim trans_date As String = dt.Rows(0).Item("trans_date").ToString
            If trans_date <> "" Then
                txtmonth.Text = MonthName(trans_date.Split("/")(0))
                txtmonth.Value = trans_date.Split("/")(0)
                txtday.Text = trans_date.Split("/")(1)
                txtyear.Text = trans_date.Split("/")(2).Substring(0, 4)
            End If
            For Each ctrl As Control In hdr.Controls
                If TypeOf ctrl Is user_control.textbox Then
                    Dim txtbox As user_control.textbox = CType(ctrl, user_control.textbox)
                    If txtbox.ValueSource <> "" Then
                        If dt.Columns.Contains(txtbox.ValueSource) Then
                            txtbox.Value = dt.Rows(0).Item(txtbox.ValueSource).ToString
                            If txtbox.NumberFormat.ToString.Contains("#") Then
                                txtbox.DecimalValue = dt.Rows(0).Item(txtbox.ValueSource).ToString
                            End If
                        End If
                    End If
                    If txtbox.TextSource <> "" Then
                        If dt.Columns.Contains(txtbox.TextSource) Then
                            txtbox.Text = dt.Rows(0).Item(txtbox.TextSource).ToString
                        End If
                    End If
                ElseIf TypeOf ctrl Is user_control.myDatePicker Then
                    Dim txtbox = CType(ctrl, user_control.myDatePicker)
                    If txtbox.TextSource <> "" Then
                        If dt.Columns.Contains(txtbox.TextSource) Then
                            Dim tmp_due_date = If(dt.Rows(0).Item(txtbox.TextSource).ToString = "", Today.ToString("MM/dd/yyyy"), dt.Rows(0).Item(txtbox.TextSource).ToString)
                            txtbox.Value = CDate(tmp_due_date)
                        End If
                    End If
                End If
            Next
            currentDr = dt.Rows(0)
            disable_control(dt.Rows(0).Item("user_id").ToString = main.user_id, dt.Rows(0))
            refresh_record_det()
            txtamountwords.Text = amount_words(txtamount.DecimalValue)
            computeTotal()
        End If
    End Sub

    Private Sub refresh_record_det()
        Dim dt As DataTable = Query("select True AS isInputted,a.*,if(a.debit!=0,1,2) as dc,a.jbooks_id as jbooks_id_tmp " & _
            ",b.project_code,b.project_name " & _
            ",c.department_code,c.department_name " & _
            ",d.allocation_code,d.allocation_name " & _
            ",e.account_code,e.account_name,e.validation " & _
            ",f.general_code,f.general_name " & _
            ",g.currency_code,g.currency_name " & _
            ",z2.trans_no as ref_trans_no,z2.book_id as ref_book_id,z2.journal_id as ref_journal_id " & _
            ",x2.book_code as ref_book_code,x2.book_name as ref_book_name " & _
            ",y2.journal_code as ref_journal_code,y2.journal_name as ref_journal_name " & _
            ",IF(j.validation = '2',i.terms_id,IF(j.validation = '3',h.terms_id,NULL)) AS terms_id " & _
            ",IF(j.validation = '2',ifnull(i.nodays,0),IF(j.validation = '3',ifnull(h.nodays,0),0)) AS nodays " & _
            ",IF(j.validation = '2',i.jbooks_ar_id,IF(j.validation = '3',h.jbooks_ap_id,NULL)) AS jbooks_terms_id " & _
            ",IF(j.validation = '2',l.terms_code,IF(j.validation = '3',k.terms_code,NULL)) AS terms_code " & _
            ",IF(j.validation = '2',l.terms_name,IF(j.validation = '3',k.terms_name,NULL)) AS terms_name " & _
            "from trans_jbooks a " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_project b on a.project_id = b.project_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_department c on a.department_id = c.department_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_allocation d on a.allocation_id = d.allocation_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_chart e on a.account_id = e.account_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_general f on a.general_id = f.general_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_currency g on a.currency_id = g.currency_id " & _
            "left join " & connectionlib.connectionlib._serverDBMain & ".trans_jbooks_ap h on h.jbooks_id = a.jbooks_id " & _
            "left join " & connectionlib.connectionlib._serverDBMain & ".trans_jbooks_ar i on i.jbooks_id = a.jbooks_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_chart j on j.account_id = a.account_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_terms k on k.terms_id = h.terms_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_terms l on l.terms_id = i.terms_id " & _
            "left join trans_jbooks a2 on a.ref_jbooks_id = a2.jbooks_id " & _
            "left join trans_header z2 on a2.trans_id = z2.trans_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_book x2 on z2.book_id = x2.book_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_journal y2 on z2.journal_id = y2.journal_id " & _
            "where a.trans_id = " & txttransid.Text & " " & _
            "order by dc,e.account_code")
        ds.Tables("jbooks").Clear()
        ds.Tables("checks").Clear()
        ds.Tables("ewt").Clear()
        ds.Tables("input_vat").Clear()
        ds.Tables("output_vat").Clear()
        ds.Tables("fixed_asset").Clear()
        ds.Tables("prepaid").Clear()
        ds.Tables("final_tax").Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("jbooks").NewRow
            For j = 0 To dt.Columns.Count - 1
                If dr.Table.Columns.Contains(dt.Columns(j).ColumnName) Then
                    dr(dt.Columns(j).ColumnName) = If(IsDBNull(dt.Rows(i)(dt.Columns(j).ColumnName)), "", dt.Rows(i)(dt.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("jbooks").Rows.Add(dr)
        Next
        dgjbooks.DataSource = ds.Tables("jbooks")
        'ewt
        Dim sql_ewt = String.Format("SELECT True AS isInputted,a.*,d.general_code,d.general_name,e.currency_code,e.currency_name," & _
                                    "f.ewt_code AS fs_ewt_code,f.ewt_name AS fs_ewt_name " & _
                                    "FROM trans_ewt a " & _
                                    "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " & _
                                    "LEFT JOIN trans_header c ON c.trans_id = b.trans_id " & _
                                    "LEFT JOIN {1}.lib_erp_general d ON d.general_id = a.general_id " & _
                                    "LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " & _
                                    "LEFT JOIN {1}.lib_acc_ewt f ON f.ewt_id = a.fs_ewt_id " & _
                                    "WHERE c.trans_id = {0}", txttransid.Text, _serverDBFS)
        Dim dt_ewt As DataTable = Query(sql_ewt)
        For i = 0 To dt_ewt.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("ewt").NewRow
            For j = 0 To dt_ewt.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_ewt.Columns(j).ColumnName) Then
                    dr(dt_ewt.Columns(j).ColumnName) = If(IsDBNull(dt_ewt.Rows(i)(dt_ewt.Columns(j).ColumnName)), "", dt_ewt.Rows(i)(dt_ewt.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("ewt").Rows.Add(dr)
        Next

        'final_tax
        Dim sql_finaltax = String.Format("SELECT True AS isInputted,a.*,d.general_code,d.general_name,e.currency_code,e.currency_name," & _
                                    "f.final_tax_code AS fs_final_tax_code,f.final_tax_name AS fs_final_tax_name " & _
                                    "FROM trans_final_tax a " & _
                                    "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " & _
                                    "LEFT JOIN trans_header c ON c.trans_id = b.trans_id " & _
                                    "LEFT JOIN {1}.lib_erp_general d ON d.general_id = a.general_id " & _
                                    "LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " & _
                                    "LEFT JOIN {1}.lib_acc_final_tax f ON f.final_tax_id = a.fs_final_tax_id " & _
                                    "WHERE c.trans_id = {0}", txttransid.Text, _serverDBFS)
        Dim dt_finaltax As DataTable = Query(sql_finaltax)
        For i = 0 To dt_finaltax.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("final_tax").NewRow
            For j = 0 To dt_finaltax.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_finaltax.Columns(j).ColumnName) Then
                    dr(dt_finaltax.Columns(j).ColumnName) = If(IsDBNull(dt_finaltax.Rows(i)(dt_finaltax.Columns(j).ColumnName)), "", dt_finaltax.Rows(i)(dt_finaltax.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("final_tax").Rows.Add(dr)
        Next

        'inputvat
        Dim sql_inputvat = String.Format("SELECT True AS isInputted,a.*,d.general_code,d.general_name,e.currency_code,e.currency_name " & _
                                    "FROM trans_input_vat a " & _
                                    "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " & _
                                    "LEFT JOIN trans_header c ON c.trans_id = b.trans_id " & _
                                    "LEFT JOIN {1}.lib_erp_general d ON d.general_id = a.general_id " & _
                                    "LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " & _
                                    "WHERE c.trans_id = {0}", txttransid.Text, _serverDBFS)
        Dim dt_inputvat As DataTable = Query(sql_inputvat)
        For i = 0 To dt_inputvat.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("input_vat").NewRow
            For j = 0 To dt_inputvat.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_inputvat.Columns(j).ColumnName) Then
                    dr(dt_inputvat.Columns(j).ColumnName) = If(IsDBNull(dt_inputvat.Rows(i)(dt_inputvat.Columns(j).ColumnName)), "", dt_inputvat.Rows(i)(dt_inputvat.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("input_vat").Rows.Add(dr)
        Next

        'outputvat
        Dim sql_outputvat = String.Format("SELECT True AS isInputted,a.*,d.general_code,d.general_name,e.currency_code,e.currency_name " & _
                                    "FROM trans_output_vat a " & _
                                    "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " & _
                                    "LEFT JOIN trans_header c ON c.trans_id = b.trans_id " & _
                                    "LEFT JOIN {1}.lib_erp_general d ON d.general_id = a.general_id " & _
                                    "LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " & _
                                    "WHERE c.trans_id = {0}", txttransid.Text, _serverDBFS)
        Dim dt_outputvat As DataTable = Query(sql_outputvat)
        For i = 0 To dt_outputvat.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("output_vat").NewRow
            For j = 0 To dt_outputvat.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_outputvat.Columns(j).ColumnName) Then
                    dr(dt_outputvat.Columns(j).ColumnName) = If(IsDBNull(dt_outputvat.Rows(i)(dt_outputvat.Columns(j).ColumnName)), "", dt_outputvat.Rows(i)(dt_outputvat.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("output_vat").Rows.Add(dr)
        Next

        'prepaid
        Dim sql_prepaid = String.Format("SELECT True AS isInputted,a.* " & _
                                    "FROM trans_prepaid a " & _
                                    "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " & _
                                    "LEFT JOIN trans_header c ON c.trans_id = b.trans_id " & _
                                    "WHERE c.trans_id = {0}", txttransid.Text)
        Dim dt_prepaid As DataTable = Query(sql_prepaid)
        For i = 0 To dt_prepaid.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("prepaid").NewRow
            For j = 0 To dt_prepaid.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_prepaid.Columns(j).ColumnName) Then
                    dr(dt_prepaid.Columns(j).ColumnName) = If(IsDBNull(dt_prepaid.Rows(i)(dt_prepaid.Columns(j).ColumnName)), "", dt_prepaid.Rows(i)(dt_prepaid.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("prepaid").Rows.Add(dr)
        Next

        'fixed_asset
        Dim sql_fixedasset = String.Format("SELECT True AS isInputted,a.* " & _
                                    "FROM trans_fixed_asset a " & _
                                    "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " & _
                                    "LEFT JOIN trans_header c ON c.trans_id = b.trans_id " & _
                                    "WHERE c.trans_id = {0}", txttransid.Text)
        Dim dt_fixedasset As DataTable = Query(sql_fixedasset)
        For i = 0 To dt_fixedasset.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("fixed_asset").NewRow
            For j = 0 To dt_fixedasset.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_fixedasset.Columns(j).ColumnName) Then
                    dr(dt_fixedasset.Columns(j).ColumnName) = If(IsDBNull(dt_fixedasset.Rows(i)(dt_fixedasset.Columns(j).ColumnName)), "", dt_fixedasset.Rows(i)(dt_fixedasset.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("fixed_asset").Rows.Add(dr)
        Next

        'checks
        Dim sql_checks = String.Format("SELECT True AS isInputted,a.* " & _
                                       ",IF(a.check_no = '',1,0) AS isCash " & _
                                       ",IF(a.replacement_check_no = '',0,1) AS isReplaced " & _
                                    ",c.trans_no " & _
                                    ",d.general_code,d.general_name " & _
                                    ",e.currency_code,e.currency_name " & _
                                    ",f.bank_code AS bank_code_depository,f.bank_name AS bank_name_depository " & _
                                    "FROM trans_checks a " & _
                                    "LEFT JOIN trans_jbooks b ON b.jbooks_id = a.jbooks_id " & _
                                    "LEFT JOIN trans_header c ON c.trans_id = b.trans_id " & _
                                    "LEFT JOIN {1}.lib_erp_general d ON d.general_id = a.general_id " & _
                                    "LEFT JOIN {1}.lib_erp_currency e ON e.currency_id = a.currency_id " & _
                                    "LEFT JOIN {1}.lib_erp_bank f ON f.bank_id = a.bank_id " & _
                                    "WHERE c.trans_id = {0}", txttransid.Text, _serverDBFS)
        Dim dt_checks As DataTable = Query(sql_checks)
        For i = 0 To dt_checks.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("checks").NewRow
            For j = 0 To dt_checks.Columns.Count - 1
                If dr.Table.Columns.Contains(dt_checks.Columns(j).ColumnName) Then
                    dr(dt_checks.Columns(j).ColumnName) = If(IsDBNull(dt_checks.Rows(i)(dt_checks.Columns(j).ColumnName)), "", dt_checks.Rows(i)(dt_checks.Columns(j).ColumnName))
                End If
            Next
            ds.Tables("checks").Rows.Add(dr)
        Next
    End Sub

    Private Sub bind_control_det()
        If Not transmodedet = "" Then
            Exit Sub
        End If
        If dgjbooks.RowCount = 0 Then
            clear_control_det()
            Exit Sub
        End If
        If dgjbooks.SelectedRows.Count = 0 Then
            clear_control_det()
            Exit Sub
        End If
        Dim sel As String = dgjbooks.SelectedRows(0).Cells("jbooks_id_tmp").Value.ToString
        Dim dr As DataRow = ds.Tables("jbooks").Select("jbooks_id_tmp = '" & sel & "'")(0)
        txtlineremarks.Text = dr("line_remarks")
        txtproject.Value = dr("project_id").ToString
        txtproject.Text = dr("project_name").ToString
        txtdepartment.Value = dr("department_id").ToString
        txtdepartment.Text = dr("department_name").ToString
        txt_currency_id.Value = dr("currency_id").ToString
        txt_currency_id.Text = dr("currency_name").ToString
        txt_exchange_rate.DecimalValue = dr("exchange_rate").ToString
        txt_based_rate.DecimalValue = dr("based_rate").ToString
        txtallocation.Value = dr("allocation_id").ToString
        txtallocation.Text = dr("allocation_name").ToString
        txtaccount.Value = dr("account_id").ToString
        txtaccount.Text = dr("account_code").ToString
        txtaccountname.Text = dr("account_name").ToString
        txtdebit.DecimalValue = dr("debit").ToString
        txtcredit.DecimalValue = dr("credit").ToString
        txtdebitbased.DecimalValue = dr("debit_based").ToString
        txtcreditbased.DecimalValue = dr("credit_based").ToString
        txtgeneraldet.Value = dr("general_id").ToString
        txtgeneraldet.Text = dr("general_code").ToString
        txtgeneraldetname.Text = dr("general_name").ToString
        txtdnref.Value = dr("ref_jbooks_id").ToString
        txtdnref.Text = dr("ref_trans_no").ToString
        txtdnrefbookcode.Text = dr("ref_book_code").ToString
        txtdnrefjournalcode.Text = dr("ref_journal_code").ToString
        txtjbooksidtmp.Text = If(dr("jbooks_id_tmp").ToString = "", Now.ToString("yyyyMMddHHmmss"), dr("jbooks_id_tmp"))
        txttermsiddet.Value = dr("terms_id").ToString
        txttermsiddet.Text = dr("terms_name").ToString
        txtnodaysdet.DecimalValue = ifNull(dr("nodays"), 0)
        If dr.Item("validation").ToString = "2" Or dr.Item("validation").ToString = "3" Then
            lbltermsdet.Visible = True
            txttermsiddet.Visible = True
            txtnodaysdet.Visible = True
        Else
            lbltermsdet.Visible = False
            txttermsiddet.Visible = False
            txtnodaysdet.Visible = False
        End If
    End Sub

    Private Sub computeTotal()
        Dim dtot As Decimal = If(ds.Tables("jbooks").Select("deleted = 'False'").Count > 0, ds.Tables("jbooks").Compute("sum(debit)", "deleted = 'False'"), 0)
        Dim ctot As Decimal = If(ds.Tables("jbooks").Select("deleted = 'False'").Count > 0, ds.Tables("jbooks").Compute("sum(credit)", "deleted = 'False'"), 0)
        Dim diff As Decimal = dtot - ctot
        lbldebittotal.Text = Format(dtot, txtdebit.NumberFormat)
        lblcredittotal.Text = Format(ctot, txtdebitbased.NumberFormat)
        lbldifftotal.Text = Format(diff, txtdebit.NumberFormat)
        Dim dbtot As Decimal = If(ds.Tables("jbooks").Select("deleted = 'False'").Count > 0, ds.Tables("jbooks").Compute("sum(debit_based)", "deleted = 'False'"), 0)
        Dim cbtot As Decimal = If(ds.Tables("jbooks").Select("deleted = 'False'").Count > 0, ds.Tables("jbooks").Compute("sum(credit_based)", "deleted = 'False'"), 0)
        Dim diffb As Decimal = dbtot - cbtot
        lbldebitbasedtotal.Text = Format(dbtot, txtdebitbased.NumberFormat)
        lblcreditbasedtotal.Text = Format(cbtot, txtcreditbased.NumberFormat)
        lbldiffbasedtotal.Text = Format(diffb, txtdebitbased.NumberFormat)
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click, btnCorrection.Click, btnComment.Click
        Dim errorStr As String = "Request Not Available"
        If currentDr.Item("current_approver").ToString = main.user_id Then
            MsgBox(errorStr)
            Exit Sub
        Else
            'if previous approver is the login user and the status is not for correction
            If currentDr.Item("prev_approver").ToString = main.user_id And currentDr.Item("current_status").ToString <> "2" Then
                MsgBox(errorStr)
                Exit Sub
            Else
                'if user already approved the transaction
                Dim sql_approved As String = String.Format("" & _
                "SELECT b.* " & _
                "FROM ( " & _
                    "SELECT MAX(approved_date) AS approved_date,ref_id,user_id " & _
                    "FROM trans_header_approval " & _
                    "GROUP BY ref_id,user_id " & _
                ") a " & _
                "LEFT JOIN trans_header_approval b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id AND b.user_id = a.user_id " & _
                "WHERE b.ref_id = {0}; " & _
                "", currentDr.Item("trans_id").ToString)
                Dim dt_approved As DataTable = Query(sql_approved)
                If dt_approved.Rows.Count > 0 Then
                    Dim drApproved = dt_approved.Select(String.Format("user_id = '{0}'", main.user_id))
                    If drApproved.Count > 0 Then
                        If currentDr.Item("current_status").ToString <> "0" And currentDr.Item("current_status").ToString <> "1" Then
                            If currentDr.Item("current_status").ToString <> "2" Then
                                MsgBox(errorStr)
                                Exit Sub
                            End If
                        Else
                            If currentDr.Item("current_status").ToString = "1" Then
                                If drApproved(0).Item("status") <> "2" Then
                                    MsgBox(errorStr)
                                    Exit Sub
                                End If
                            End If
                        End If
                    End If
                End If
                'get all approver and stage
                Dim sql_stage As String = String.Format("" & _
                "SELECT c.approval_user_id,c.approval_id,c.user_id,c.approval_order,c.order_no AS approval_order " & _
                ",a.order_no AS stage_order,False AS _used " & _
                "FROM sys_erp_approval a " & _
                "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " & _
                "LEFT JOIN sys_erp_approval_user c ON c.approval_id = a.approval_id " & _
                "WHERE b.module_code = '{0}' " & _
                "ORDER BY a.order_no; " & _
                "", module_code)
                Dim dt_stage As DataTable = FsQuery(sql_stage)
                Dim stage_order_no As Integer = dt_stage.Rows(0).Item("stage_order")
                For Each dr As DataRow In dt_stage.Rows
                    Dim drs = dt_approved.Select(String.Format("user_id = {0}", dr.Item("user_id").ToString))
                    If drs.Count > 0 And dr.Item("user_id").ToString <> main.user_id Then
                        If drs(0).Item("status").ToString <> "0" And drs(0).Item("status").ToString <> "2" Then
                            stage_order_no = dr.Item("stage_order")
                            dr.Item("_used") = True
                        End If
                    Else
                        drs = dt_stage.Select(String.Format("user_id = {0}", main.user_id))
                        If drs.Count > 0 Then
                            If drs(0).Item("stage_order") > stage_order_no Then
                                'check kung lahat ng mababang stage_no ay naka pag approve na
                                drs = dt_stage.Select(String.Format("_used = False AND stage_order < {0}", drs(0).Item("stage_order")))
                                If drs.Count > 0 Then
                                    MsgBox(errorStr)
                                    Exit Sub
                                End If
                            Else
                            End If
                        Else
                            drs = dt_stage.Select(String.Format("user_id = '{0}'", main.user_id))
                            If drs.Count > 0 Then
                                If drs(0).Item("stage_order") > stage_order_no Then
                                    'check kung lahat ng mababang stage_no ay naka pag approve na
                                    drs = dt_stage.Select(String.Format("_used = False AND stage_order < {0}", drs(0).Item("stage_order")))
                                    If drs.Count > 0 Then
                                        MsgBox(errorStr)
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        End If
        Dim btn = CType(sender, Button)
        Select Case btn.Name
            Case "btnApprove"
                frmapproval.lblApproval.Text = "Approved"
                frmapproval.status = 1
            Case "btnCorrection"
                frmapproval.lblApproval.Text = "For Correction"
                frmapproval.status = 2
            Case "btnComment"
                frmapproval.lblApproval.Text = "Comment"
                frmapproval.status = 9
        End Select
        frmapproval.module_code = module_code
        frmapproval.stage_id = getStageID(module_code, main.user_id)
        frmapproval.ref_id = txttransid.Text
        If frmapproval.ShowDialog = Windows.Forms.DialogResult.OK Then
            refresh_record()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Query(String.Format("CALL approvedata('{0}',{1},{2},{3},{4},'{5}');", module_code, 0, txttransid.Text, 0, frmapproval.log_id, ""))
        refresh_record()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim where As String = ""
        txtday.Text = Now().Day
        If main.Sys_Default.Rows(0)("monthly_currency") Then
            where = "where DATE_FORMAT(effectivitydate,'%Y-%m') = '" & txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "' "
        Else
            where = "where effectivitydate = '" & txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "-" & txtday.Text.PadLeft(2, "0") & "'"
        End If
        Dim _tmp_sql As String = "select a.currency_id,a.currency_code,a.currency_name " & _
            ",b.exchange_rate,b.based_rate " & _
            "from lib_erp_currency a " & _
            "inner join (select a.currency_id,a.exchange_rate,a.based_rate " & _
                    "from lib_erp_currency_rate a " & _
                    "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " & _
                            "FROM lib_erp_currency_rate " & where & _
                    "group by currency_id) b on a.currency_id = b.currency_id " & _
                "and a.effectivitydate = b.effectivitydate) b on a.currency_id = b.currency_id"
        currency = FsQuery(_tmp_sql)
        If currency.Rows.Count = 0 Then
            MsgBox(String.Format("No Currency Rate Setup for the {0}.", If(main.Sys_Default.Rows(0)("monthly_currency"), "Month", "Day")))
            Exit Sub
        End If
        transmode = "add"
        enable_control()
        clear_control()
        Dim sql As String = String.Format("SELECT auto_number FROM lib_erp_journal WHERE journal_id = {0}", journal_id)
        Dim dt As DataTable = FsQuery(sql)
        txtday.Text = Now().Day
        If dt.Rows(0).Item("auto_number") = 1 Then
            Dim newno = Query("call getnewtransno(" & journal_id & "," & book_id & "," & txtmonth.Value & "," & txtyear.Text & ")").Rows(0)("trans_no_new")
            txttransno.Text = newno
            txttransno.Enabled = False
        Else
            txttransno.Text = ""
            txttransno.Enabled = True
            txttransno.Focus()
        End If
        ds.Clear()
        dgjbooks.DataSource = ds.Tables("jbooks")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        transmode = "edit"
        enable_control()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        report_cv_filter.journal_id = journal_id
        report_cv_filter.book_id = book_id
        report_cv_filter.transid = txttransid.Text
        report_cv_filter.transno = txttransno.Text
        report_cv_filter.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        mainList.btnHide.Visible = True
        mainList.btnCancel.Visible = False
        mainList.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txttransno.Text = "" Then
            MsgBox("Cannot save transaction. Transaction No. is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If txtgeneral.Text = "" Then
            MsgBox("Cannot save transaction. Supplier is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If txtcurrency.Text = "" Then
            MsgBox("Cannot save transaction. Currency is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If txtexchangerate.DecimalValue = 0 Then
            MsgBox("Cannot save transaction. Exchange Rate must not be zero.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If txtbasedrate.DecimalValue = 0 Then
            MsgBox("Cannot save transaction. Based Rate must not be zero.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If ds.Tables("jbooks").Rows.Count = 0 Then
            MsgBox("Cannot save transaction. No details in transaction.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If Val(lbldifftotal.Text.Replace(",", "")) <> 0 Then
            MsgBox("Cannot save transaction. Debit and Credit is not balance.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If Val(lbldiffbasedtotal.Text.Replace(",", "")) <> 0 Then
            MsgBox("Cannot save transaction. Debit and Credit is not balance.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        Dim tmp_pk As String = "0"
        Dim pk_name As String = "trans_id"

        'header
        Dim qry As String = ""
        Dim fields As New Dictionary(Of String, String)
        fields.Add("trans_id", txttransid.Text)
        fields.Add("trans_no", txttransno.Text)
        fields.Add("trans_date", txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "-" & txtday.Text.PadLeft(2, "0"))
        fields.Add("book_id", book_id)
        fields.Add("journal_id", journal_id)
        fields.Add("general_id", txtgeneral.Value)
        fields.Add("currency_id", txtcurrency.Value)
        fields.Add("exchange_rate", txtexchangerate.DecimalValue)
        fields.Add("based_rate", txtbasedrate.DecimalValue)
        fields.Add("amount", txtamount.DecimalValue)
        fields.Add("amount_based", txtamountbased.DecimalValue)
        fields.Add("description", txtdesc.Text)
        If transmode = "add" Then
            qry = genInsert("trans_header", fields)
        Else
            qry = genUpdate("trans_header", fields)
        End If
        Dim dt As DataTable = Query(qry)
        Dim trans_id As String = ""
        Dim addsave As Boolean = False
        If transmode = "add" Then
            qry = "select trans_id from trans_header where trans_no = '" & txttransno.Text & "' and book_id = " & book_id & " and journal_id = " & journal_id
            dt = Query(qry)
            trans_id = dt.Rows(0)("trans_id")
            Query(String.Format("CALL submitapproval('{0}',{1},{2});", module_code, trans_id, main.user_id))
            addsave = True
        Else
            trans_id = txttransid.Text
        End If
        tmp_pk = trans_id

        'ap
        If Not txtsino.Text = "" Or Not txtrrno.Text = "" Then
            qry = ""
            fields = New Dictionary(Of String, String)
            fields.Add("trans_cv_id", txttranscvid.Text)
            fields.Add("trans_id", trans_id)
            fields.Add("si_no", txtsino.Text)
            fields.Add("rr_no", txtrrno.Text)
            If txttranscvid.Text = "" Then
                qry = genInsert("trans_header_cv", fields)
            Else
                qry = genUpdate("trans_header_cv", fields)
            End If
            dt = Query(qry)
        End If

        'jbooks
        Dim jbooks_ids As New Dictionary(Of String, String)
        For i = 0 To ds.Tables("jbooks").Rows.Count - 1
            qry = ""
            Dim dr As DataRow = ds.Tables("jbooks").Rows(i)
            fields = New Dictionary(Of String, String)
            fields.Add("jbooks_id", dr("jbooks_id"))
            Dim jbookstransid As String = IIf(dr("trans_id") = "", trans_id, dr("trans_id"))
            fields.Add("trans_id", jbookstransid)
            Dim projectid As String = IIf(dr("project_id").ToString = "", Nothing, dr("project_id").ToString)
            fields.Add("project_id", projectid)
            Dim departmentid As String = IIf(dr("department_id").ToString = "", Nothing, dr("department_id"))
            fields.Add("department_id", departmentid)
            Dim allocationid As String = IIf(dr("allocation_id") = "", Nothing, dr("allocation_id"))
            fields.Add("allocation_id", allocationid)
            fields.Add("account_id", dr("account_id"))
            fields.Add("line_remarks", dr("line_remarks"))
            fields.Add("debit", dr("debit"))
            fields.Add("credit", dr("credit"))
            fields.Add("currency_id", dr("currency_id"))
            fields.Add("exchange_rate", dr("exchange_rate"))
            fields.Add("based_rate", dr("based_rate"))
            Dim debit_based As Decimal = 0
            Dim credit_based As Decimal = 0
            If dr("ref_jbooks_id") = "" And dr("validation").ToString <> "10" Then
                debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
            Else
                debit_based = dr("debit_based")
                credit_based = dr("credit_based")
            End If
            fields.Add("debit_based", debit_based)
            fields.Add("credit_based", credit_based)
            Dim generalid As String = IIf(dr("general_id") = "", Nothing, dr("general_id"))
            fields.Add("general_id", generalid)
            Dim refjbooksid As String = IIf(dr("ref_jbooks_id") = "", Nothing, dr("ref_jbooks_id"))
            fields.Add("ref_jbooks_id", refjbooksid)
            If dr("jbooks_id") = "" Or dr.Item("jbooks_id").ToString.Contains("tmp_") Then
                If dr("deleted").ToString = "False" Then
                    qry = genInsert("trans_jbooks", fields)
                End If
            Else
                If dr("deleted").ToString = "True" Then
                    qry = String.Format("DELETE FROM trans_jbooks WHERE jbooks_id = {0}", dr("jbooks_id"))
                Else
                    qry = genUpdate("trans_jbooks", fields)
                End If
            End If
            If qry <> "" Then
                dt = Query(qry)
            End If
            If dr.Item("validation").ToString = "2" Or dr.Item("validation").ToString = "3" Then
                Dim tmp_dt As New DataTable
                If dr.Item("jbooks_id").ToString = "" Then
                    Dim tmp_sql As String = String.Format("SELECT jbooks_id AS id FROM trans_jbooks WHERE ")
                    Dim flag As Boolean = False
                    For Each item In fields
                        If item.Key <> "jbooks_id" Then
                            If item.Value IsNot Nothing Then
                                If item.Value.ToString <> "" And item.Value.ToString <> "0" Then
                                    tmp_sql &= If(Not flag, " ", " AND ") & String.Format(" {0} = '{1}' ", item.Key, item.Value)
                                    flag = True
                                End If
                            End If
                        End If
                    Next
                    tmp_dt = Query(tmp_sql)
                End If
                If dr("validation").ToString = "2" And dr("debit") > 0 Then
                    fields = New Dictionary(Of String, String)
                    fields.Add("jbooks_ar_id", dr("jbooks_terms_id"))
                    fields.Add("jbooks_id", If(dr("jbooks_id").ToString = "", tmp_dt.Rows(0).Item("id"), dr("jbooks_id")))
                    fields.Add("nodays", ifNull(dr("nodays"), 0))
                    fields.Add("terms_id", dr("terms_id"))
                    If fields.Item("jbooks_id").ToString <> "" Then
                        If fields.Item("jbooks_ar_id").ToString = "" Then
                            qry = genInsert("trans_jbooks_ar", fields)
                        Else
                            qry = genUpdate("trans_jbooks_ar", fields)
                        End If
                        dt = Query(qry)
                    End If
                ElseIf dr("validation").ToString = "3" And dr("credit") > 0 Then
                    fields = New Dictionary(Of String, String)
                    fields.Add("jbooks_ap_id", dr("jbooks_terms_id").ToString)
                    fields.Add("jbooks_id", If(dr("jbooks_id").ToString = "", tmp_dt.Rows(0).Item("id"), dr("jbooks_id")))
                    fields.Add("nodays", dr("nodays"))
                    fields.Add("terms_id", dr("terms_id"))
                    If fields.Item("jbooks_id").ToString <> "" Then
                        If fields.Item("jbooks_ap_id").ToString = "" Then
                            qry = genInsert("trans_jbooks_ap", fields)
                        Else
                            qry = genUpdate("trans_jbooks_ap", fields)
                        End If
                        dt = Query(qry)
                    End If
                End If
            End If
        Next
        Dim jbooks_id As String = ""
        qry = "select jbooks_id from trans_jbooks where trans_id = " & trans_id
        dt = Query(qry)
        For Each dr As DataRow In ds.Tables("jbooks").Rows
            If dr("jbooks_id") = "" Then
                jbooks_id = dt.Rows(dr.Table.Rows.IndexOf(dr))("jbooks_id")
            Else
                jbooks_id = dr("jbooks_id")
            End If
            jbooks_ids.Add(dr("jbooks_id_tmp"), jbooks_id)
        Next

        'ewt
        If ds.Tables("ewt").Rows.Count > 0 Then
            For i = 0 To ds.Tables("ewt").Rows.Count - 1
                qry = ""
                Dim dr As DataRow = ds.Tables("ewt").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("ewt_id", dr("ewt_id"))
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("fs_ewt_id", dr("fs_ewt_id"))
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("tax_rate", dr("tax_rate").ToString)
                fields.Add("amount", dr("amount").ToString)
                fields.Add("tax_amount", dr("tax_amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id"))
                fields.Add("exchange_rate", dr("exchange_rate"))
                fields.Add("based_rate", dr("based_rate"))
                Dim amount_based As Decimal = 0
                Dim tax_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_ewt_id") = "" Then
                    amount_based = dr("amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    tax_amount_based = dr("tax_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    amount_based = dr("amount_based")
                    tax_amount_based = dr("tax_amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("tax_amount_based", tax_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                Dim refewtid As String = IIf(dr("ref_ewt_id") = "", Nothing, dr("ref_ewt_id"))
                fields.Add("ref_ewt_id", refewtid)
                If dr("ewt_id").ToString.Contains("tmp_") Then
                    dr("ewt_id") = ""
                End If
                If dr("ewt_id") = "" Then
                    If dr("deleted").ToString = "False" Then
                        qry = genInsert("trans_ewt", fields)
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        qry = String.Format("DELETE FROM trans_ewt WHERE ewt_id = {0}", dr("ewt_id"))
                    Else
                        qry = genUpdate("trans_ewt", fields)
                    End If
                End If
                If qry <> "" Then
                    dt = Query(qry)
                End If
            Next
        End If

        'final_tax
        If ds.Tables("final_tax").Rows.Count > 0 Then
            For i = 0 To ds.Tables("final_tax").Rows.Count - 1
                qry = ""
                Dim dr As DataRow = ds.Tables("final_tax").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("final_tax_id", dr("final_tax_id"))
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("fs_final_tax_id", dr("fs_final_tax_id"))
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("tax_rate", dr("tax_rate").ToString)
                fields.Add("amount", dr("amount").ToString)
                fields.Add("tax_amount", dr("tax_amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id"))
                fields.Add("exchange_rate", dr("exchange_rate"))
                fields.Add("based_rate", dr("based_rate"))
                Dim amount_based As Decimal = 0
                Dim tax_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_final_tax_id") = "" Then
                    amount_based = dr("amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    tax_amount_based = dr("tax_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    amount_based = dr("amount_based")
                    tax_amount_based = dr("tax_amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("tax_amount_based", tax_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                Dim reffinaltaxid As String = IIf(dr("ref_final_tax_id") = "", Nothing, dr("ref_final_tax_id"))
                fields.Add("ref_final_tax_id", reffinaltaxid)
                If dr("final_tax_id").ToString.Contains("tmp_") Then
                    dr("final_tax_id") = ""
                End If
                If dr("final_tax_id") = "" Then
                    If dr("deleted").ToString = "False" Then
                        qry = genInsert("trans_final_tax", fields)
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        qry = String.Format("DELETE FROM trans_final_tax WHERE final_tax_id = {0}", dr("final_tax_id"))
                    Else
                        qry = genUpdate("trans_final_tax", fields)
                    End If
                End If
                If qry <> "" Then
                    dt = Query(qry)
                End If
            Next
        End If

        'checks
        If ds.Tables("checks").Rows.Count > 0 Then
            For i = 0 To ds.Tables("checks").Rows.Count - 1
                qry = ""
                Dim dr As DataRow = ds.Tables("checks").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("check_id", dr("check_id"))
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("check_no", dr("check_no"))
                fields.Add("check_date", Format(dr("check_date"), "yyyy-MM-dd"))
                fields.Add("check_amount", dr("check_amount").ToString)
                fields.Add("check_amount_based", dr("check_amount_based"))
                fields.Add("bank_id", dr("bank_id"))
                fields.Add("cleared", IIf(dr("cleared"), "1", "0"))
                fields.Add("released", IIf(dr("released"), "1", "0"))
                fields.Add("cancelled", IIf(dr("cancelled"), "1", "0"))
                fields.Add("crossed", IIf(dr("crossed"), "1", "0"))
                fields.Add("replacement_check_no", dr("replacement_check_no"))
                fields.Add("cleared_date", Format(dr("cleared_date"), "yyyy-MM-dd"))
                fields.Add("deposit_date", Format(dr("deposit_date"), "yyyy-MM-dd"))
                fields.Add("cancel_date", Format(dr("cancel_date"), "yyyy-MM-dd"))
                fields.Add("replaced", IIf(dr("replaced"), "1", "0"))
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                If dr("check_id").ToString.Contains("tmp_") Then
                    dr("check_id") = ""
                End If
                If dr("check_id") = "" Then
                    If dr("deleted").ToString = "False" Then
                        qry = genInsert("trans_checks", fields)
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        qry = String.Format("DELETE FROM trans_checks WHERE check_id = {0}", dr("check_id"))
                    Else
                        qry = genUpdate("trans_checks", fields)
                    End If
                End If
                If qry <> "" Then
                    dt = Query(qry)
                End If
            Next
        End If

        'fixed asset
        If ds.Tables("fixed_asset").Rows.Count > 0 Then
            For i = 0 To ds.Tables("fixed_asset").Rows.Count - 1
                qry = ""
                Dim dr As DataRow = ds.Tables("fixed_asset").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("fixed_asset_id", dr("fixed_asset_id"))
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("description", dr("description"))
                fields.Add("asset_code", dr("asset_code"))
                fields.Add("date_acquired", Format(dr("date_acquired"), "yyyy-MM-dd"))
                fields.Add("amount", dr("amount").ToString)
                fields.Add("salvage_value", dr("salvage_value").ToString)
                fields.Add("salvage_value_based", dr("salvage_value_based").ToString)
                fields.Add("quantity", dr("quantity").ToString)
                fields.Add("historical_rate", dr("historical_rate").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                Dim amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_fixed_asset_id") = "" Then
                    amount_based = dr("amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    amount_based = dr("amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("useful_life", dr("useful_life").ToString)
                fields.Add("date_start", Format(dr("date_start"), "yyyy-MM-dd"))
                fields.Add("ref_fixed_asset_id", If(dr("ref_fixed_asset_id") = "", Nothing, dr("ref_fixed_asset_id")))
                If dr("fixed_asset_id").ToString.Contains("tmp_") Then
                    dr("fixed_asset_id") = ""
                End If
                If dr("fixed_asset_id") = "" Then
                    If dr("deleted").ToString = "False" Then
                        qry = genInsert("trans_fixed_asset", fields)
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        qry = String.Format("DELETE FROM trans_fixed_asset WHERE fixed_asset_id = {0}", dr("fixed_asset_id"))
                    Else
                        qry = genUpdate("trans_fixed_asset", fields)
                    End If
                End If
                If qry <> "" Then
                    dt = Query(qry)
                End If
            Next
        End If

        'input vat
        If ds.Tables("input_vat").Rows.Count > 0 Then
            For i = 0 To ds.Tables("input_vat").Rows.Count - 1
                qry = ""
                Dim dr As DataRow = ds.Tables("input_vat").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("input_vat_id", dr("input_vat_id"))
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("vat_class", dr("vat_class").ToString)
                fields.Add("vat_type", dr("vat_type").ToString)
                fields.Add("vat_rate", dr("vat_rate").ToString)
                fields.Add("gross_amount", dr("gross_amount").ToString)
                fields.Add("vat_amount", dr("vat_amount").ToString)
                fields.Add("net_amount", dr("net_amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                Dim gross_amount_based As Decimal = 0
                Dim vat_amount_based As Decimal = 0
                Dim net_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_amount_based As Decimal = 0
                If dr("ref_input_vat_id") = "" Then
                    gross_amount_based = dr("gross_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    vat_amount_based = dr("vat_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    net_amount_based = dr("net_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_amount_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    gross_amount_based = dr("gross_amount_based")
                    vat_amount_based = dr("vat_amount_based")
                    net_amount_based = dr("net_amount_based")
                    debit_based = dr("debit_based")
                    credit_amount_based = dr("credit_amount_based")
                End If
                fields.Add("gross_amount_based", gross_amount_based.ToString)
                fields.Add("vat_amount_based", vat_amount_based.ToString)
                fields.Add("net_amount_based", net_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_amount_based", credit_amount_based.ToString)
                fields.Add("ref_input_vat_id", If(dr("ref_input_vat_id") = "", Nothing, dr("ref_input_vat_id")))
                If dr("input_vat_id").ToString.Contains("tmp_") Then
                    dr("input_vat_id") = ""
                End If
                If dr("input_vat_id") = "" Then
                    If dr("deleted").ToString = "False" Then
                        qry = genInsert("trans_input_vat", fields)
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        qry = String.Format("DELETE FROM trans_input_vat WHERE input_vat_id = {0}", dr("input_vat_id"))
                    Else
                        qry = genUpdate("trans_input_vat", fields)
                    End If
                End If
                If qry <> "" Then
                    dt = Query(qry)
                End If
            Next
        End If

        'output vat
        If ds.Tables("output_vat").Rows.Count > 0 Then
            For i = 0 To ds.Tables("output_vat").Rows.Count - 1
                qry = ""
                Dim dr As DataRow = ds.Tables("output_vat").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("output_vat_id", dr("output_vat_id"))
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("vat_type", dr("vat_type").ToString)
                fields.Add("vat_rate", dr("vat_rate").ToString)
                fields.Add("gross_amount", dr("gross_amount").ToString)
                fields.Add("vat_amount", dr("vat_amount").ToString)
                fields.Add("net_amount", dr("net_amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                Dim gross_amount_based As Decimal = 0
                Dim vat_amount_based As Decimal = 0
                Dim net_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_output_vat_id") = "" Then
                    gross_amount_based = dr("gross_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    vat_amount_based = dr("vat_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    net_amount_based = dr("net_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    gross_amount_based = dr("gross_amount_based")
                    vat_amount_based = dr("vat_amount_based")
                    net_amount_based = dr("net_amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("gross_amount_based", gross_amount_based.ToString)
                fields.Add("vat_amount_based", vat_amount_based.ToString)
                fields.Add("net_amount_based", net_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("ref_output_vat_id", If(dr("ref_output_vat_id") = "", Nothing, dr("ref_output_vat_id")))
                If dr("output_vat_id").ToString.Contains("tmp_") Then
                    dr("output_vat_id") = ""
                End If
                If dr("output_vat_id") = "" Then
                    If dr("deleted").ToString = "False" Then
                        qry = genInsert("trans_output_vat", fields)
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        qry = String.Format("DELETE FROM trans_output_vat WHERE output_vat_id = {0}", dr("output_vat_id"))
                    Else
                        qry = genUpdate("trans_output_vat", fields)
                    End If
                End If
                If qry <> "" Then
                    dt = Query(qry)
                End If
            Next
        End If

        'prepaid
        If ds.Tables("prepaid").Rows.Count > 0 Then
            For i = 0 To ds.Tables("prepaid").Rows.Count - 1
                qry = ""
                Dim dr As DataRow = ds.Tables("prepaid").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("prepaid_id", dr("prepaid_id"))
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Remove("description")
                fields.Add("description", dr("description"))
                fields.Remove("date_acquired")
                fields.Add("date_acquired", Format(dr("date_acquired"), "yyyy-MM-dd"))
                fields.Add("amount", dr("amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                Dim amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_prepaid_id") = "" Then
                    amount_based = dr("amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    amount_based = dr("amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("useful_life", dr("useful_life").ToString)
                fields.Add("date_start", Format(dr("date_start"), "yyyy-MM-dd"))
                fields.Add("ref_prepaid_id", If(dr("ref_prepaid_id") = "", Nothing, dr("ref_prepaid_id")))
                If dr("prepaid_id").ToString.Contains("tmp_") Then
                    dr("prepaid_id") = ""
                End If
                If dr("prepaid_id") = "" Then
                    If dr("deleted").ToString = "False" Then
                        qry = genInsert("trans_prepaid", fields)
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        qry = String.Format("DELETE FROM trans_prepaid WHERE prepaid_id = {0}", dr("prepaid_id"))
                    Else
                        qry = genUpdate("trans_prepaid", fields)
                    End If
                End If
                If qry <> "" Then
                    dt = Query(qry)
                End If
            Next
        End If
        disable_control()
        refresh_record()
        transmode = ""
        transmodedet = ""
        mainList.pk_Name = pk_name
        mainList.trans_id = tmp_pk
        If addsave Then
            saveAddAnother(btnAdd)
        End If
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control()
        transmode = ""
        transmodedet = ""
        refresh_record()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmodedet = "insert"
        enable_control_det()
        clear_control_det()
        txtjbooksidtmp.Text = Now.ToString("yyyyMMddHHmmss")
        Dim dr As DataRow = txtcurrency.RowData
        txtaccount.Focus()
        txt_currency_id.Value = txtcurrency.Value
        txt_currency_id.Text = txtcurrency.Text
        txt_exchange_rate.DecimalValue = txtexchangerate.DecimalValue
        txt_based_rate.DecimalValue = txtbasedrate.DecimalValue
        txt_currency_id.RowData = txtcurrency.RowData
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        enable_control_det()
        If txtdebit.DecimalValue = 0 And txtcredit.DecimalValue = 0 Then
            transmodedet = "update"
            txtaccount.Focus()
        ElseIf txtdebit.DecimalValue <> 0 Then
            txt_currency_id.Enabled = True
            txtaccount.Enabled = True
            txtaccount.Focus()
            txtdebit.Enabled = True
            txtdebit.Focus()
            btnOK.Focus()
        Else
            txt_currency_id.Enabled = True
            txtaccount.Enabled = True
            txtaccount.Focus()
            txtcredit.Enabled = True
            txtcredit.Focus()
            btnOK.Focus()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim arr_id = getCheckedGrid("jbooks_id_tmp", "account_name", "sel", dgjbooks, "", False)
        Dim dt As DataTable = ds.Tables("jbooks")
        Dim newDt As New DataTable("tmp_jbooks")
        For Each col As DataColumn In dt.Columns
            Dim newCol As New DataColumn
            newCol.ColumnName = col.ColumnName
            newCol.DataType = col.DataType
            newDt.Columns.Add(newCol)
        Next
        For Each dr As DataRow In dt.Rows
            If arr_id.Contains(dr.Item("jbooks_id")) Then
                dr.Item("deleted") = True
            Else
                If Not dr.Item("deleted") Then
                    newDt.ImportRow(dr)
                End If
            End If
        Next
        dgjbooks.DataSource = newDt
        computeTotal()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim tmp_pk As String = "0"
        Dim dg As DataGridView = dgjbooks
        Dim pk_name As String = "jbooks_id_tmp"
        Dim dr As DataRow = Nothing
        Dim sel As String = ""
        If transmodedet = "insert" Then
            dr = ds.Tables("jbooks").NewRow
            dr("jbooks_id") = ""
            dr("jbooks_id_tmp") = txtjbooksidtmp.Text
        Else
            sel = dgjbooks.SelectedRows(0).Cells("jbooks_id_tmp").Value.ToString
            dr = ds.Tables("jbooks").Select("jbooks_id_tmp = '" & sel & "'")(0)
        End If
        tmp_pk = dr("jbooks_id_tmp").ToString
        dr("currency_id") = txt_currency_id.Value
        dr("currency_name") = txt_currency_id.Text
        dr("exchange_rate") = txt_exchange_rate.DecimalValue
        dr("based_rate") = txt_based_rate.DecimalValue
        dr("line_remarks") = txtlineremarks.Text
        dr("project_id") = txtproject.Value
        Dim proj_code As String = ""
        If Not txtproject.RowData Is Nothing Then proj_code = txtproject.RowData("project_code")
        dr("project_code") = proj_code
        dr("project_name") = txtproject.Text
        dr("department_id") = txtdepartment.Value
        Dim dept_code As String = ""
        If Not txtdepartment.RowData Is Nothing Then dept_code = txtdepartment.RowData("department_code")
        dr("department_code") = dept_code
        dr("department_name") = txtdepartment.Text
        dr("account_id") = txtaccount.Value
        dr("account_code") = txtaccount.Text
        dr("account_name") = txtaccountname.Text
        dr("debit") = txtdebit.DecimalValue
        dr("credit") = txtcredit.DecimalValue
        dr("debit_based") = txtdebitbased.DecimalValue
        dr("credit_based") = txtcreditbased.DecimalValue
        dr("general_id") = txtgeneraldet.Value
        dr("general_code") = txtgeneraldet.Text
        dr("general_name") = txtgeneraldetname.Text
        dr("ref_jbooks_id") = txtdnref.Value
        dr("ref_trans_no") = txtdnref.Text
        dr("ref_book_id") = txtdnrefbookcode.Value
        dr("ref_book_code") = txtdnrefbookcode.Text
        dr("ref_journal_id") = txtdnrefjournalcode.Value
        dr("ref_journal_code") = txtdnrefjournalcode.Text
        Dim v As Integer = txtaccount.RowData("validation")
        dr("validation") = v
        If v = "2" Or v = "3" Then
            dr("terms_id") = txttermsiddet.Value
            dr("terms_name") = txttermsiddet.Text
            dr("nodays") = txtnodaysdet.DecimalValue
        End If
        dr("dc") = IIf(txtdebit.DecimalValue <> 0, 1, 2)
        If (txtcredit.DecimalValue = 0 And txtdebit.DecimalValue = 0) Or (txtdebitbased.DecimalValue = 0 And txtcreditbased.DecimalValue = 0) Then
            Dim tmp_table As String = ""
            Select Case txtaccount.RowData.Item("validation").ToString
                Case "1"
                    tmp_table = "checks"
                Case "2"
                    tmp_table = "jbooks"
                Case "3"
                    tmp_table = "jbooks"
                Case "4"
                    tmp_table = "ewt"
                Case "5"
                    tmp_table = "final_tax"
                Case "6"
                    tmp_table = "input_vat"
                Case "7"
                    tmp_table = "output_vat"
                Case "8"
                    tmp_table = "prepaid"
                Case "9"
                    tmp_table = "fixed_asset"
                Case "10"
                    tmp_table = "jbooks"
                Case "0"
                    tmp_table = "jbooks"
            End Select
            Dim drows() As DataRow = ds.Tables(tmp_table).Select("jbooks_id = '" & dr("jbooks_id_tmp") & "'")
            For Each row As DataRow In drows
                row.Item("deleted") = True
            Next
            Dim err = MsgBox("The Value of Debit and Credit is Zero, Delete the JBooks?", MsgBoxStyle.YesNo, "Delete JBooks?")
            If err = vbYes Then
                dr("deleted") = True
            End If
        End If
        If transmodedet = "insert" Then
            If recordExist(dgjbooks, {"account_id", txtaccount.Value}, {"debit", "credit"}, {txtdebit.DecimalValue, txtcredit.DecimalValue}) Then
                MsgBox("Unable to add existing record.")
            Else
                ds.Tables("jbooks").Rows.Add(dr)
            End If
        End If
        computeTotal()
        If v.ToString = "1" Then
            If ds.Tables("jbooks").Select("validation = '1'").Count > 0 Then
                txtamount.DecimalValue = ds.Tables("jbooks").Compute("sum(credit)", "validation = '1'")
                txtamountbased.DecimalValue = txtamount.DecimalValue * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                txtamountwords.Text = amount_words(txtamount.DecimalValue)
            End If
        End If
        Dim dt As DataTable = ds.Tables("jbooks")
        Dim newDt As New DataTable("tmp_jbooks")
        For Each col As DataColumn In dt.Columns
            Dim newCol As New DataColumn
            newCol.ColumnName = col.ColumnName
            newCol.DataType = col.DataType
            newDt.Columns.Add(newCol)
        Next
        For Each row As DataRow In dt.Rows
            If Not row.Item("deleted") Then
                newDt.ImportRow(row)
            End If
        Next
        dgjbooks.DataSource = newDt
        disable_control_det()
        btnInsert.Focus()
        transmodedet = ""
        gridRowFocus(dgjbooks, {pk_name, tmp_pk})
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        disable_control_det()
        transmodedet = ""
    End Sub

    Private Sub transactioncv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim closed As Boolean = False
        If transmode <> "" Then
            Dim confirm = MsgBox("There are transactions that are not yet done. Are you sure to exit the form?", MsgBoxStyle.YesNo, "Transaction Undone.")
            If confirm = MsgBoxResult.No Then
                e.Cancel = True
                closed = True
            End If
        End If
        If Not closed Then
            e.Cancel = True
            mainList.btnHide.Visible = False
            mainList.btnCancel.Visible = True
            mainList.Show()
            Dim btnFilter As Button = CType(mainList.Controls.Find("btnFilter", True)(0), Button)
            btnFilter.PerformClick()
            Me.Hide()
        End If
    End Sub

    Public Overrides Sub Refresh()
        Me.Top = (Me.Parent.Height - Me.Height) / 2
        Me.Left = (Me.Parent.Width - Me.Width) / 2
        If pkID <> "" Then
            refresh_record()
        End If
    End Sub

    Private Sub txtgeneral_Leave(sender As Object, e As EventArgs) Handles txtgeneral.Leave
        general = FsQuery("select * from lib_erp_general WHERE general_type = 1 OR general_type = 3 ")
        If general.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If general.Rows.Count = 1 Then
                dr = general.Rows(0)
            Else
                Dim dra() As DataRow = general.Select("general_code like '" & txtgeneral.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = general
                    browse.format("Code,Name", "general_code,general_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtgeneral.RowData = dr
                txtgeneral.Value = dr("general_id")
                txtgeneral.Text = dr("general_code")
                txtgeneralname.Text = dr("general_name")
            End If
        End If
    End Sub

    Private Sub txtcurrency_Leave(sender As Object, e As EventArgs) Handles txtcurrency.Leave
        currency = FsQuery("select a.currency_id,a.currency_code,a.currency_name " & _
            ",b.exchange_rate,b.based_rate " & _
            "from lib_erp_currency a " & _
            "inner join (select a.currency_id,a.exchange_rate,a.based_rate " & _
                    "from lib_erp_currency_rate a " & _
                    "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " & _
                            "FROM lib_erp_currency_rate " & _
                            "where left(effectivitydate,7) <= '" & txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "' " & _
                    "group by currency_id) b on a.currency_id = b.currency_id " & _
                "and a.effectivitydate = b.effectivitydate) b on a.currency_id = b.currency_id")
        If currency.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If currency.Rows.Count = 1 Then
                dr = currency.Rows(0)
            Else
                Dim dra() As DataRow = currency.Select("currency_code like '" & txtcurrency.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = currency
                    browse.format("Code,Name", "currency_code,currency_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtcurrency.RowData = dr
                txtcurrency.Value = dr("currency_id")
                txtcurrency.Text = dr("currency_code")
                txtcurrencyname.Text = dr("currency_name")
                txtexchangerate.Text = dr("exchange_rate")
                txtbasedrate.Text = dr("based_rate")

                txt_currency_id.Value = dr("currency_id")
                txt_currency_id.Text = dr("currency_name")
                txt_exchange_rate.DecimalValue = dr("exchange_rate")
                txt_based_rate.DecimalValue = dr("based_rate")
            End If
        End If
    End Sub

    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        Dim dt As DataTable = FsQuery("select a.currency_id,a.currency_code,a.currency_name " & _
            ",b.exchange_rate,b.based_rate " & _
            "from lib_erp_currency a " & _
            "inner join (select a.currency_id,a.exchange_rate,a.based_rate " & _
                    "from lib_erp_currency_rate a " & _
                    "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " & _
                            "FROM lib_erp_currency_rate " & _
                            "where left(effectivitydate,7) <= '" & txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "' " & _
                    "group by currency_id) b on a.currency_id = b.currency_id " & _
                "and a.effectivitydate = b.effectivitydate) b on a.currency_id = b.currency_id")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("currency_name like '{0}'", txt_currency_id.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
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
                txt_currency_id.Text = dr("currency_name")
                txt_exchange_rate.DecimalValue = dr("exchange_rate")
                txt_based_rate.DecimalValue = dr("based_rate")
            End If
        End If
    End Sub

    Private Sub txtaccount_Leave(sender As Object, e As EventArgs) Handles txtaccount.Leave
        chart = FsQuery("select * from lib_erp_chart")
        If chart.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If chart.Rows.Count = 1 Then
                dr = chart.Rows(0)
            Else
                Dim dra() As DataRow = chart.Select("account_code like '" & txtaccount.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = chart
                    browse.format("Code,Name", "account_code,account_name", "100,300")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                Dim validate As Integer = dr("validation")
                txtaccount.RowData = dr
                txtaccount.Value = dr("account_id")
                txtaccount.Text = dr("account_code")
                txtaccountname.Text = dr("account_name")
                If validate = 10 Then
                    txtdebit.Enabled = False
                    txtcredit.Enabled = False
                    txtdebitbased.Enabled = True
                    txtcreditbased.Enabled = True
                Else
                    txtdebitbased.Enabled = False
                    txtcreditbased.Enabled = False
                    If "23".IndexOf(validate.ToString) >= 0 Then
                        txtgeneraldet.Value = txtgeneral.Value
                        txtgeneraldet.Text = txtgeneral.Text
                        txtgeneraldetname.Text = txtgeneralname.Text
                    Else
                        txtgeneraldet.Value = ""
                        txtgeneraldet.Text = ""
                        txtgeneraldetname.Text = ""
                    End If
                End If
                If "23".IndexOf(validate.ToString) < 0 Then
                    txtgeneraldet.Enabled = False
                    lbltermsdet.Visible = False
                    txttermsiddet.Visible = False
                    txtnodaysdet.Visible = False
                    txttermsiddet.Value = ""
                    txttermsiddet.Text = ""
                    txtnodaysdet.DecimalValue = 0
                Else
                    txtgeneraldet.Enabled = True
                    lbltermsdet.Visible = True
                    txttermsiddet.Visible = True
                    txtnodaysdet.Visible = True

                End If
            End If
        End If
    End Sub

    Private Sub txtproject_Leave(sender As Object, e As EventArgs) Handles txtproject.Leave
        project = FsQuery("select * from lib_erp_project")
        If project.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If project.Rows.Count = 1 Then
                dr = project.Rows(0)
            Else
                Dim dra() As DataRow = project.Select("project_name like '" & txtproject.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = project
                    browse.format("Code,Name", "project_code,project_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtproject.RowData = dr
                txtproject.Value = dr("project_id")
                txtproject.Text = dr("project_name")
            End If
        End If
    End Sub

    Private Sub txtdepartment_Leave(sender As Object, e As EventArgs) Handles txtdepartment.Leave
        department = FsQuery("select * from lib_erp_department")
        If department.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If department.Rows.Count = 1 Then
                dr = department.Rows(0)
            Else
                Dim dra() As DataRow = department.Select("department_name like '" & txtdepartment.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = department
                    browse.format("Code,Name", "department_code,department_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtdepartment.RowData = dr
                txtdepartment.Value = dr("department_id")
                txtdepartment.Text = dr("department_name")
            End If
        End If
    End Sub

    Private Sub txtallocation_Leave(sender As Object, e As EventArgs) Handles txtallocation.Leave
        allocation = FsQuery("select a.* from lib_erp_allocation a inner join lib_erp_allocation_account b on a.allocation_id = b.allocation_id where b.account_id = " & txtaccount.Value)
        If allocation.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If allocation.Rows.Count = 1 Then
                dr = allocation.Rows(0)
            Else
                Dim dra() As DataRow = allocation.Select("allocation_name like '" & txtallocation.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = allocation
                    browse.format("Code,Name", "allocation_code,allocation_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtallocation.RowData = dr
                txtallocation.Value = dr("allocation_id")
                txtallocation.Text = dr("allocation_name")
            End If
        End If
    End Sub

    Private Sub txttermsiddet_Leave(sender As Object, e As EventArgs) Handles txttermsiddet.Leave
        Dim validation = txtaccount.RowData
        If validation.Item("validation") = "2" Then
            terms = FsQuery("select * from lib_erp_terms where terms_type = 1 or terms_type = 3")
        Else
            terms = FsQuery("select * from lib_erp_terms where terms_type = 2 or terms_type = 3")
        End If
        If terms.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If terms.Rows.Count = 1 Then
                dr = terms.Rows(0)
            Else
                Dim dra() As DataRow = terms.Select("terms_name like '" & txttermsiddet.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = terms
                    browse.format("Code,Name", "terms_code,terms_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txttermsiddet.RowData = dr
                txttermsiddet.Value = dr("terms_id")
                txttermsiddet.Text = dr("terms_name")
                txtnodaysdet.Text = dr("nodays")
                If dr("fixed_day") = 0 Then
                    txtnodaysdet.Enabled = True
                Else
                    txtnodaysdet.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub txtgeneraldet_Leave(sender As Object, e As EventArgs) Handles txtgeneraldet.Leave
        Dim v As Integer = txtaccount.RowData("validation")
        If "2310".IndexOf(v.ToString) > 0 Then
            general = FsQuery("select * from lib_erp_general WHERE general_type = 1 OR general_type = 3 ")
            If general.Rows.Count = 0 Then
                MsgBox("No record found.")
            Else
                Dim dr As DataRow = Nothing
                If general.Rows.Count = 1 Then
                    dr = general.Rows(0)
                Else
                    Dim dra() As DataRow = general.Select("general_code like '" & txtgeneraldet.Text.ToString.Replace("'", "''") & "'")
                    If dra.Count > 0 Then
                        dr = dra(0)
                    Else
                        browse.dt = general
                        browse.format("Code,Name", "general_code,general_name", "140,240")
                        If browse.ShowDialog() = DialogResult.OK Then
                            If browse.dgview.SelectedRows.Count > 0 Then
                                dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                            End If
                        End If
                    End If
                End If
                If Not dr Is Nothing Then
                    txtgeneraldet.RowData = dr
                    txtgeneraldet.Value = dr("general_id")
                    txtgeneraldet.Text = dr("general_code")
                    txtgeneraldetname.Text = dr("general_name")
                End If
            End If
        End If
    End Sub

    Private Sub txtdebit_Leave(sender As Object, e As EventArgs) Handles txtdebit.Leave
        Dim v As Integer = 0
        Dim flag As Boolean = False
        If txtdebit.DecimalValue <> 0 Then
            If Not txtaccount.RowData Is Nothing Then
                v = txtaccount.RowData("validation")
                If "2310".IndexOf(v.ToString) < 0 Then
                    NewValidateEntry(Me, dgjbooks, ds)
                End If
            End If
        End If
        If v <> 3 Then
            txtdebitbased.DecimalValue = txtdebit.DecimalValue * (txt_exchange_rate.DecimalValue / txt_based_rate.DecimalValue)
            txtdnref.Enabled = False
        Else
            txtdnref.Enabled = True
            txtdnref.Focus()
        End If
        If "456789".IndexOf(v.ToString) >= 0 Then
            btnOK_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtdebitbased_Leave(sender As Object, e As EventArgs) Handles txtdebitbased.Leave
        If txtdebitbased.DecimalValue <> 0 Then
            txtcreditbased.DecimalValue = 0
        End If
    End Sub

    Private Sub txtcredit_Leave(sender As Object, e As EventArgs) Handles txtcredit.Leave
        Dim v As Integer = 0
        Dim flag As Boolean = False
        If txtcredit.DecimalValue <> 0 Then
            If Not txtaccount.RowData Is Nothing Then
                v = txtaccount.RowData("validation")
                If "2310".IndexOf(v.ToString) < 0 Then
                    NewValidateEntry(Me, dgjbooks, ds)
                End If
                If v.ToString = "1" Then
                    NewValidateEntry(Me, dgjbooks, ds, True)
                End If
            End If
        End If
        If v <> 2 Then
            txtcreditbased.DecimalValue = txtcredit.DecimalValue * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
            txtdnref.Enabled = False
        Else
            txtdnref.Enabled = True
            txtdnref.Focus()
        End If
        If "1456789".IndexOf(v.ToString) >= 0 Then
            btnOK_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtcreditbased_Leave(sender As Object, e As EventArgs) Handles txtcreditbased.Leave
        If txtcreditbased.DecimalValue <> 0 Then
            txtdebitbased.DecimalValue = 0
        End If
    End Sub

    Private Sub txtdnref_Leave(sender As Object, e As EventArgs) Handles txtdnref.Leave
        NewValidateEntry(Me, dgjbooks, ds, True)
        Dim v_dr As DataRow = txtaccount.RowData
        Dim v As String = v_dr.Item("validation")
        dgjbooks.DataSource = ds.Tables("jbooks")
        computeTotal()
        If v.ToString = "1" Then
            If ds.Tables("jbooks").Select("validation = '1'").Count > 0 Then
                txtamount.DecimalValue = ds.Tables("jbooks").Compute("sum(credit)", "validation = '1'")
                txtamountbased.DecimalValue = txtamount.DecimalValue * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                txtamountwords.Text = amount_words(txtamount.DecimalValue)
            End If
        End If
        disable_control_det()
        btnInsert.Focus()
        transmodedet = ""
    End Sub

    Private Sub txtday_TextChange(sender As Object, e As EventArgs) Handles txtday.TextChange
        Dim month As Integer = txtmonth.Value
        Dim year As Integer = txtyear.Value
        Dim dd As Integer = txtday.DecimalValue
        Dim max_day As Integer = 30
        If month = 1 Or month = 3 Or month = 5 Or month = 7 Or month = 8 Or month = 10 Or month = 12 Then
            max_day = 31
        ElseIf month = 2 Then
            If year Mod 4 = 0 Then
                max_day = 29
            Else
                max_day = 28
            End If
        End If
        If dd > 31 Or dd < 1 Then
            txtday.DecimalValue = 1
        ElseIf dd >= max_day Then
            txtday.DecimalValue = max_day
        End If
    End Sub

    Private Sub transcv_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Top = (Me.Parent.Height - Me.Height) / 2
        Me.Left = (Me.Parent.Width - Me.Width) / 2
        refresh_record()
    End Sub

    Private Sub transcv_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.Top = (Me.Parent.Height - Me.Height) / 2
        Me.Left = (Me.Parent.Width - Me.Width) / 2
    End Sub

    Private Sub dgjbooks_SelectionChanged(sender As Object, e As EventArgs) Handles dgjbooks.SelectionChanged
        bind_control_det()
    End Sub

    Private Sub txtdesc_Leave(sender As Object, e As EventArgs) Handles txtdesc.Leave
        btnInsert.Focus()
    End Sub

    Private Sub ValidateEntry(Optional dnref As Boolean = False)
        '1 - Bank / Cash
        '2 - AR (debit)
        '3 - AP (credit)
        '4 - EWT (credit) Tax Amount
        '5 - Final Tax (credit) Tax Amount
        '6 - Input VAT (debit) Vat Amount
        '7 - Output VAT (credit) Vat Amount
        '8 - Prepayment (debit) Amount
        '9 - Fixed Asset (debit) Amount
        '10 - Gain or Loss
        Dim sel_ewt As DataTable = ds.Tables("ewt").Clone
        Dim sel_final_tax As DataTable = ds.Tables("final_tax").Clone
        Dim sel_input_vat As DataTable = ds.Tables("input_vat").Clone
        Dim sel_output_vat As DataTable = ds.Tables("output_vat").Clone
        Dim sel_prepaid As DataTable = ds.Tables("prepaid").Clone
        Dim sel_fixed_asset As DataTable = ds.Tables("fixed_asset").Clone
        Dim jbooks_id = If(dgjbooks.SelectedRows.Count > 0, ds.Tables("jbooks").Rows(dgjbooks.SelectedRows(0).Index)("jbooks_id_tmp"), 0)
        If Not txtaccount.RowData Is Nothing Then
            Dim v As Integer = txtaccount.RowData("validation")
            Dim debit As Decimal = 0.0
            Dim credit As Decimal = 0.0
            If "23456789".IndexOf(v.ToString) >= 0 Then
                Me.Visible = False
            End If
            If txtdebit.DecimalValue <> 0 Then
                Select Case v
                    Case 3
                        If dnref Then
                            Dim tmp_dr() As DataRow = ds.Tables("jbooks").Select("account_id = '" & txtaccount.Value & "'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("jbooks").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim offset_ds As DataTable = offsetap.ds.Tables("jbooks")
                            offset_ds.Clear()
                            offsetap.account_id = txtaccount.Value
                            offsetap.trans_id = txttransid.Text
                            offsetap.jbooks_id = txtjbooksidtmp.Text
                            offsetap.general_id = txtgeneral.Value
                            offsetap.currency_id = txt_currency_id.Value
                            offsetap.project_id = txtproject.Value
                            offsetap.department_id = txtdepartment.Value
                            offsetap.filter_date = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                            offsetap.refresh_data()
                            dtReplace(offset_ds, tmp_dt, "ref_jbooks_id")
                            If offsetap.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("jbooks"), offsetap.ds.Tables("jbooks"), {"ref_jbooks_id"}, "isInputted", "jbooks_id")
                            End If
                            debit = 0
                            If ds.Tables("jbooks").Select("account_id = '" & txtaccount.Value & "' AND deleted = 'False'").Count > 0 Then
                                debit = ds.Tables("jbooks").Compute("Sum(debit)", "account_id = '" & txtaccount.Value & "' AND deleted = 'False'")
                            End If
                        End If
                    Case 4 'EWT (credit)
                        Dim tmp_dr() As DataRow = ds.Tables("ewt").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("ewt").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetewt.ds.Tables("ewt")
                        offset_ds.Clear()
                        offsetewt.account_id = txtaccount.Value
                        offsetewt.trans_id = txttransid.Text
                        offsetewt.jbooks_id = txtjbooksidtmp.Text
                        offsetewt.general_id = txtgeneral.Value
                        offsetewt.currency_id = txt_currency_id.Value
                        offsetewt.project_id = txtproject.Value
                        offsetewt.department_id = txtdepartment.Value
                        offsetewt.filter_date = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                        offsetewt.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_ewt_id")
                        If offsetewt.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("ewt"), offsetewt.ds.Tables("ewt"), {"ref_ewt_id"}, "isInputted", "ewt_id")
                            debit = 0
                            If ds.Tables("ewt").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                debit = ds.Tables("ewt").Compute("Sum(tax_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        Else
                            debit = 0
                            If ds.Tables("ewt").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                debit = ds.Tables("ewt").Compute("Sum(tax_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        End If
                    Case 5 'Final Tax (credit)
                        Dim tmp_dr() As DataRow = ds.Tables("final_tax").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("final_tax").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetfinaltax.ds.Tables("final_tax")
                        offset_ds.Clear()
                        offsetfinaltax.account_id = txtaccount.Value
                        offsetfinaltax.trans_id = txttransid.Text
                        offsetfinaltax.jbooks_id = txtjbooksidtmp.Text
                        offsetfinaltax.general_id = txtgeneral.Value
                        offsetfinaltax.currency_id = txt_currency_id.Value
                        offsetfinaltax.project_id = txtproject.Value
                        offsetfinaltax.department_id = txtdepartment.Value
                        offsetfinaltax.filter_date = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                        offsetfinaltax.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_final_tax_id")
                        If offsetfinaltax.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("final_tax"), offsetfinaltax.ds.Tables("final_tax"), {"ref_final_tax_id"}, "isInputted", "final_tax_id")
                            debit = 0
                            If ds.Tables("final_tax").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                debit = ds.Tables("final_tax").Compute("Sum(tax_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        Else
                            debit = 0
                            If ds.Tables("final_tax").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                debit = ds.Tables("final_tax").Compute("Sum(tax_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        End If
                    Case 6 'Input VAT (debit)
                        Dim tmp_dr() As DataRow = ds.Tables("input_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("input_vat").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupinputvat_ds As DataTable = setupinputvat.ds.Tables("input_vat")
                        setupinputvat_ds.Clear()
                        dtCopy(setupinputvat_ds, tmp_dt, {"input_vat_id"})
                        setupinputvat.jbooks_id = txtjbooksidtmp.Text
                        setupinputvat.currency_id = txt_currency_id.Value
                        setupinputvat.exchange_rate = txt_exchange_rate.DecimalValue
                        setupinputvat.based_rate = txt_based_rate.DecimalValue
                        setupinputvat.asofdate = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                        If setupinputvat.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("input_vat"), setupinputvat.ds.Tables("input_vat"), {"input_vat_id"})
                        End If
                        debit = 0
                        If ds.Tables("input_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                            debit = ds.Tables("input_vat").Compute("Sum(vat_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                        End If
                    Case 7
                        Dim tmp_dr() As DataRow = ds.Tables("output_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("output_vat").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetoutputvat.ds.Tables("output_vat")
                        offset_ds.Clear()
                        offsetoutputvat.account_id = txtaccount.Value
                        offsetoutputvat.trans_id = txttransid.Text
                        offsetoutputvat.jbooks_id = txtjbooksidtmp.Text
                        offsetoutputvat.general_id = txtgeneral.Value
                        offsetoutputvat.currency_id = txt_currency_id.Value
                        offsetoutputvat.project_id = txtproject.Value
                        offsetoutputvat.department_id = txtdepartment.Value
                        offsetoutputvat.filter_date = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                        offsetoutputvat.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_output_vat_id")
                        If offsetoutputvat.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("output_vat"), offsetoutputvat.ds.Tables("output_vat"), {"ref_output_vat_id"}, "isInputted", "output_vat_id")
                            debit = 0
                            If ds.Tables("output_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                debit = ds.Tables("output_vat").Compute("Sum(vat_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        Else
                            debit = 0
                            If ds.Tables("output_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                debit = ds.Tables("output_vat").Compute("Sum(vat_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        End If
                    Case 8
                        Dim tmp_dr() As DataRow = ds.Tables("prepaid").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("prepaid").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupprepaid_ds As DataTable = setupprepaid.ds.Tables("prepaid")
                        setupprepaid_ds.Clear()
                        dtCopy(setupprepaid_ds, tmp_dt, {"prepaid_id"})
                        setupprepaid.jbooks_id = txtjbooksidtmp.Text
                        setupprepaid.currency_id = txt_currency_id.Value
                        setupprepaid.exchange_rate = txt_exchange_rate.DecimalValue
                        setupprepaid.based_rate = txt_based_rate.DecimalValue
                        If setupprepaid.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("prepaid"), setupprepaid.ds.Tables("prepaid"), {"prepaid_id"})
                        End If
                        debit = 0
                        If ds.Tables("prepaid").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                            debit = ds.Tables("prepaid").Compute("Sum(amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                        End If
                    Case 9
                        Dim tmp_dr() As DataRow = ds.Tables("fixed_asset").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("fixed_asset").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupfixedasset_ds As DataTable = setupfixedasset.ds.Tables("fixed_asset")
                        setupfixedasset_ds.Clear()
                        dtCopy(setupfixedasset_ds, tmp_dt, {"fixed_asset_id"})
                        setupfixedasset.jbooks_id = txtjbooksidtmp.Text
                        setupfixedasset.currency_id = txt_currency_id.Value
                        setupfixedasset.exchange_rate = txt_exchange_rate.DecimalValue
                        setupfixedasset.based_rate = txt_based_rate.DecimalValue
                        If setupfixedasset.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("fixed_asset"), setupfixedasset.ds.Tables("fixed_asset"), {"fixed_asset_id"})
                        End If
                        debit = 0
                        If ds.Tables("fixed_asset").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                            debit = ds.Tables("fixed_asset").Compute("Sum(amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                        End If
                End Select
            End If
            If Val(txtcredit.Text.Replace(",", "")) <> 0 Then
                Select Case v
                    Case 1
                        If dnref Then
                            Dim accountcode = txtaccount.Text
                            Dim tmp_dr() As DataRow = ds.Tables("checks").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("checks").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim cashcv_ds As DataTable = cashcv.ds.Tables("checks")
                            cashcv_ds.Clear()
                            dtCopy(cashcv_ds, tmp_dt, {"check_id"})
                            cashcv.jbooks_id = txtjbooksidtmp.Text
                            cashcv.genref_id = txtgeneral.Value
                            cashcv.genref_code = txtgeneral.Text
                            cashcv.genref_name = txtgeneralname.Text
                            cashcv.currency_id = txt_currency_id.Value
                            cashcv.exchange_rate = txt_exchange_rate.DecimalValue
                            cashcv.based_rate = txt_based_rate.DecimalValue
                            Dim sql As String = String.Format("SELECT bank_id,bank_code,bank_name " & _
                                "FROM lib_erp_bank " & _
                                "WHERE bank_code = '{0}'", accountcode)
                            Dim dt As DataTable = FsQuery(sql)
                            If dt.Rows.Count > 0 Then
                                cashcv.txt_bank_id.AlwaysDisable = True
                                cashcv.txt_bank_id.NoClear = True
                                cashcv.txt_bank_name.NoClear = True
                                cashcv.txt_bank_id.Text = dt.Rows(0).Item("bank_code")
                                cashcv.txt_bank_id.Value = dt.Rows(0).Item("bank_id")
                                cashcv.txt_bank_name.Text = dt.Rows(0).Item("bank_name")
                            Else
                                cashcv.txt_bank_id.AlwaysDisable = False
                                cashcv.txt_bank_id.NoClear = False
                                cashcv.txt_bank_name.NoClear = False
                            End If
                            Dim sql_trans_jbooks As String = String.Format("SELECT b.ref_no,c.trans_no FROM trans_jbooks a LEFT JOIN trans_jbooks_ref b ON b.jbooks_id = a.jbooks_id LEFT JOIN trans_header c ON c.trans_id = a.trans_id WHERE a.jbooks_id = {0}", txtjbooksidtmp.Value)
                            Dim data_trans_jbooks As DataTable = Query(sql_trans_jbooks)
                            If data_trans_jbooks.Rows.Count = 0 Then
                                sql_trans_jbooks = String.Format("SELECT trans_no FROM trans_header WHERE trans_id = {0}", txttransid.Text)
                                data_trans_jbooks = Query(sql_trans_jbooks)
                                If data_trans_jbooks.Rows.Count > 0 Then
                                    cashcv.reference_no = data_trans_jbooks.Rows(0).Item("trans_no").ToString
                                End If
                            Else
                                cashcv.book_code = data_trans_jbooks.Rows(0).Item("ref_no").ToString
                                cashcv.reference_no = data_trans_jbooks.Rows(0).Item("trans_no").ToString
                            End If
                            If cashcv.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("checks"), cashcv.ds.Tables("checks"), {"check_id"})
                            End If
                            credit = 0
                            If ds.Tables("checks").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                credit = ds.Tables("checks").Compute("Sum(check_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        End If
                    Case 2
                        If dnref Then
                            Dim tmp_dr() As DataRow = ds.Tables("jbooks").Select("account_id = '" & txtaccount.Value & "'")
                            Dim tmp_dt As New DataTable
                            For Each col As DataColumn In ds.Tables("jbooks").Columns
                                tmp_dt.Columns.Add(col.ColumnName)
                            Next
                            For i As Integer = 0 To tmp_dr.Length - 1
                                tmp_dt.ImportRow(tmp_dr(i))
                            Next
                            Dim offset_ds As DataTable = offsetar.ds.Tables("jbooks")
                            offset_ds.Clear()
                            offsetar.account_id = txtaccount.Value
                            offsetar.trans_id = txttransid.Text
                            offsetar.jbooks_id = txtjbooksidtmp.Text
                            offsetar.general_id = txtgeneral.Value
                            offsetar.currency_id = txt_currency_id.Value
                            offsetar.project_id = txtproject.Value
                            offsetar.department_id = txtdepartment.Value
                            offsetar.filter_date = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                            offsetar.refresh_data()
                            dtReplace(offset_ds, tmp_dt, "ref_jbooks_id")
                            If offsetar.ShowDialog() = DialogResult.OK Then
                                dtCopy(ds.Tables("jbooks"), offsetar.ds.Tables("jbooks"), {"ref_jbooks_id"}, "isInputted", "jbooks_id")
                            End If
                            credit = 0
                            If ds.Tables("jbooks").Select("account_id = '" & txtaccount.Value & "' AND deleted = 'False'").Count > 0 Then
                                credit = ds.Tables("jbooks").Compute("Sum(credit)", "account_id = '" & txtaccount.Value & "' AND deleted = 'False'")
                            End If
                        End If
                    Case 4
                        Dim tmp_dr() As DataRow = ds.Tables("ewt").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("ewt").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupewt_ds As DataTable = setupewt.ds.Tables("ewt")
                        setupewt_ds.Clear()
                        dtCopy(setupewt_ds, tmp_dt, {"ewt_id"})
                        setupewt.jbooks_id = txtjbooksidtmp.Text
                        setupewt.currency_id = txt_currency_id.Value
                        setupewt.exchange_rate = txt_exchange_rate.DecimalValue
                        setupewt.based_rate = txt_based_rate.DecimalValue
                        If setupewt.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("ewt"), setupewt.ds.Tables("ewt"), {"ewt_id"})
                        End If
                        credit = 0
                        If ds.Tables("ewt").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                            credit = ds.Tables("ewt").Compute("Sum(tax_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                        End If
                    Case 5
                        Dim tmp_dr() As DataRow = ds.Tables("final_tax").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("final_tax").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupfinaltax_ds As DataTable = setupfinaltax.ds.Tables("final_tax")
                        setupfinaltax_ds.Clear()
                        dtCopy(setupfinaltax_ds, tmp_dt, {"final_tax_id"})
                        setupfinaltax.jbooks_id = txtjbooksidtmp.Text
                        setupfinaltax.currency_id = txt_currency_id.Value
                        setupfinaltax.exchange_rate = txt_exchange_rate.DecimalValue
                        setupfinaltax.based_rate = txt_based_rate.DecimalValue
                        If setupfinaltax.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("final_tax"), setupfinaltax.ds.Tables("final_tax"), {"final_tax_id"})
                        End If
                        credit = 0
                        If ds.Tables("final_tax").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                            credit = ds.Tables("final_tax").Compute("Sum(tax_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                        End If
                    Case 6
                        Dim tmp_dr() As DataRow = ds.Tables("input_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("input_vat").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetinputvat.ds.Tables("input_vat")
                        offset_ds.Clear()
                        offsetinputvat.account_id = txtaccount.Value
                        offsetinputvat.trans_id = txttransid.Text
                        offsetinputvat.jbooks_id = txtjbooksidtmp.Text
                        offsetinputvat.general_id = txtgeneral.Value
                        offsetinputvat.currency_id = txt_currency_id.Value
                        offsetinputvat.project_id = txtproject.Value
                        offsetinputvat.department_id = txtdepartment.Value
                        offsetinputvat.filter_date = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                        offsetinputvat.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_input_vat_id")
                        If offsetinputvat.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("input_vat"), offsetinputvat.ds.Tables("input_vat"), {"ref_input_vat_id"}, "isInputted", "input_vat_id")
                            credit = 0
                            If ds.Tables("input_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                credit = ds.Tables("input_vat").Compute("Sum(vat_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        Else
                            credit = 0
                            If ds.Tables("input_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                credit = ds.Tables("input_vat").Compute("Sum(vat_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        End If
                    Case 8
                        Dim tmp_dr() As DataRow = ds.Tables("prepaid").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("prepaid").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetprepaid.ds.Tables("prepaid")
                        offset_ds.Clear()
                        offsetprepaid.account_id = txtaccount.Value
                        offsetprepaid.trans_id = txttransid.Text
                        offsetprepaid.jbooks_id = txtjbooksidtmp.Text
                        offsetprepaid.general_id = txtgeneral.Value
                        offsetprepaid.currency_id = txt_currency_id.Value
                        offsetprepaid.project_id = txtproject.Value
                        offsetprepaid.department_id = txtdepartment.Value
                        offsetprepaid.filter_date = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                        offsetprepaid.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_prepaid_id")
                        If offsetprepaid.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("prepaid"), offsetprepaid.ds.Tables("prepaid"), {"ref_prepaid_id"}, "isInputted", "prepaid_id")
                            credit = 0
                            If ds.Tables("prepaid").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                credit = ds.Tables("prepaid").Compute("Sum(amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        Else
                            credit = 0
                            If ds.Tables("prepaid").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                credit = ds.Tables("prepaid").Compute("Sum(amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        End If
                    Case 7
                        Dim tmp_dr() As DataRow = ds.Tables("output_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("output_vat").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim setupoutputvat_ds As DataTable = setupoutputvat.ds.Tables("output_vat")
                        setupoutputvat_ds.Clear()
                        dtCopy(setupoutputvat_ds, tmp_dt, {"output_vat_id"})
                        setupoutputvat.jbooks_id = txtjbooksidtmp.Text
                        setupoutputvat.str_general_id = txtgeneral.Value
                        setupoutputvat.str_general_code = txtgeneral.Text
                        setupoutputvat.str_general_name = txtgeneralname.Text
                        setupoutputvat.currency_id = txt_currency_id.Value
                        setupoutputvat.exchange_rate = txt_exchange_rate.DecimalValue
                        setupoutputvat.based_rate = txt_based_rate.DecimalValue
                        setupoutputvat.asofdate = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                        If setupoutputvat.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("output_vat"), setupoutputvat.ds.Tables("output_vat"), {"output_vat_id"})
                        End If
                        credit = 0
                        If ds.Tables("output_vat").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                            credit = ds.Tables("output_vat").Compute("Sum(vat_amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                        End If
                    Case 9
                        Dim tmp_dr() As DataRow = ds.Tables("fixed_asset").Select("jbooks_id = '" & txtjbooksidtmp.Text & "'")
                        Dim tmp_dt As New DataTable
                        For Each col As DataColumn In ds.Tables("fixed_asset").Columns
                            tmp_dt.Columns.Add(col.ColumnName)
                        Next
                        For i As Integer = 0 To tmp_dr.Length - 1
                            tmp_dt.ImportRow(tmp_dr(i))
                        Next
                        Dim offset_ds As DataTable = offsetfixedasset.ds.Tables("fixed_asset")
                        offset_ds.Clear()
                        offsetfixedasset.account_id = txtaccount.Value
                        offsetfixedasset.trans_id = txttransid.Text
                        offsetfixedasset.jbooks_id = txtjbooksidtmp.Text
                        offsetfixedasset.general_id = txtgeneral.Value
                        offsetfixedasset.currency_id = txt_currency_id.Value
                        offsetfixedasset.project_id = txtproject.Value
                        offsetfixedasset.department_id = txtdepartment.Value
                        offsetfixedasset.filter_date = txtyear.Value & "-" & txtmonth.Value & "-" & txtday.Text
                        offsetfixedasset.refresh_data()
                        dtReplace(offset_ds, tmp_dt, "ref_fixed_asset_id")
                        If offsetfixedasset.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("fixed_asset"), offsetfixedasset.ds.Tables("fixed_asset"), {"ref_fixed_asset_id"}, "isInputted", "fixed_asset_id")
                            credit = 0
                            If ds.Tables("fixed_asset").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                credit = ds.Tables("fixed_asset").Compute("Sum(amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        Else
                            credit = 0
                            If ds.Tables("fixed_asset").Select("jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'").Length > 0 Then
                                credit = ds.Tables("fixed_asset").Compute("Sum(amount)", "jbooks_id = '" & txtjbooksidtmp.Text & "' AND deleted = 'False'")
                            End If
                        End If
                End Select
            End If
            If "123456789".IndexOf(v.ToString) >= 0 Then
                Dim tmp_jbooksidtmp = txtjbooksidtmp.Text
                Dim tmp_id = txt_currency_id.Value
                Dim tmp_text = txt_currency_id.Text
                Dim tmp_xrate = txt_exchange_rate.DecimalValue
                Dim tmp_brate = txt_based_rate.DecimalValue
                Me.Visible = True
                gridRowFocus(dgjbooks, {"jbooks_id_tmp", tmp_jbooksidtmp})
                txt_currency_id.Value = tmp_id
                txt_currency_id.Text = tmp_text
                txt_exchange_rate.DecimalValue = tmp_xrate
                txt_based_rate.DecimalValue = tmp_brate
                txtdebit.DecimalValue = debit
                txtcredit.DecimalValue = credit
                If "23".IndexOf(v.ToString) < 0 Then
                    txtgeneraldet.Value = ""
                    txtgeneraldet.Text = ""
                    txtgeneraldetname.Text = ""
                End If
            End If
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class