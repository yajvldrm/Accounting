Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports System.IO
Imports user_control
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class transactionib
#Region "Variable Declaration"
    Private isInitialize As Boolean = False
    Private general As New DataTable
    Private currency As New DataTable
    Private chart As New DataTable
    Private terms As New DataTable
    Private project As New DataTable
    Private department As New DataTable
    Private allocation As New DataTable
    Private module_code As String = "ACC00101"
    Private transmodedet As String = ""
    Public currentDr As DataRow = Nothing
    Private tmpRowData As DataRow = Nothing
    Private myDataTable As DataTable = Nothing
    Private withApproval As Boolean = False
#End Region
#Region "Property"
    Public Property entryValidated As Boolean = False
    Public Property pkName As String = "trans_id"
    Public Property pkID As String = "0"
    Public Property transMode As String = ""
    Public Property BookID As String = ""
    Private _Month As String = ""
    Public Property Month() As String
        Get
            Return _Month
        End Get
        Set(value As String)
            _Month = value
            txt_month.Value = value
            txt_month.Text = MonthName(value)
        End Set
    End Property
    Private _Year As String = ""
    Public Property Year As String
        Get
            Return _Year
        End Get
        Set(value As String)
            _Year = value
            txt_year.Text = value
        End Set
    End Property
    Public Property JournalID As String = ""
    Public Property mySettings As settings = Nothing
    Public Property colhdr As String = "Invoicing No,Date,Client,Currency"
    Public Property colfld As String = "trans_no,trans_date,general_name,currency_name"
    Public Property dbName As String = _serverDBMain
    Public Property tblName As String = "trans_header"
#End Region
#Region "Other Functions/Subs"
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        If strNumberFormat.IndexOf(".") = -1 Then
            'strNumberFormat = "i"
        End If
        txtAmount.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtAmount.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtAmount.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtExchangeRate.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtExchangeRate.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtExchangeRate.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtBasedRate.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtBasedRate.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtBasedRate.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtAmountBased.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtAmountBased.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtAmountBased.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtExchangeRateDet.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtExchangeRateDet.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtExchangeRateDet.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtBasedRateDet.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtBasedRateDet.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtBasedRateDet.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtDebit.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtDebit.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtDebit.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtCredit.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtCredit.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtCredit.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtDebitBased.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtDebitBased.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtDebitBased.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtCreditBased.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtCreditBased.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtCreditBased.Properties.Mask.EditMask = "n" & main.DecimalPlaces
    End Sub
    Friend Sub loadLastTransaction(Optional pageNumber As Integer = 0)
        Dim sql As String = String.Format("SELECT currentapprover.user_id AS current_approver,currentapprover.status AS current_status " &
        ",prevapprover.user_id AS prev_approver,prevapprover.status AS prev_status " &
        ",creator.user_id,creator.stage_id " &
        ",a.* " &
        ",c.general_code,c.general_name " &
        ",d.currency_code,d.currency_name " &
        ",IFNULL(b.trans_ib_id,'') AS trans_ib_id,IFNULL(b.si_no,'') AS si_no,IFNULL(b.dr_no,'') AS dr_no,IFNULL(b.po_no,'') AS po_no " &
        ",IFNULL(b.terms_id,'') AS terms_id,IFNULL(b.nodays,0) AS nodays,e.terms_name,b.due_date " &
        ",IFNULL(_lock.isLock,0) AS isLock  " &
        "FROM trans_header a " &
        "LEFT JOIN selectTransactionLocking _lock ON _lock.trans_id = a.trans_id " &
        "LEFT JOIN trans_header_ib b ON a.trans_id = b.trans_id " &
        "LEFT JOIN {0}.lib_erp_general c ON a.general_id = c.general_id " &
        "LEFT JOIN {0}.lib_erp_currency d ON a.currency_id = d.currency_id " &
        "LEFT JOIN {0}.lib_erp_terms e ON b.terms_id = e.terms_id " &
        "LEFT JOIN ( " &
          "SELECT * " &
          "FROM trans_header_status " &
          "GROUP BY ref_id " &
        ") creator ON creator.ref_id = a.trans_id " &
        "LEFT JOIN ( " &
          "SELECT b.* " &
          "FROM ( " &
            "SELECT MAX(approved_date) AS approved_date,ref_id " &
            "FROM trans_header_status " &
            "GROUP BY ref_id " &
          ") a " &
          "LEFT JOIN trans_header_status b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " &
          "GROUP BY ref_id " &
        ") currentapprover ON currentapprover.ref_id = a.trans_id " &
        "LEFT JOIN ( " &
          "SELECT b.* " &
          "FROM ( " &
            "SELECT MAX(b.approved_date) AS approved_date,b.ref_id,b.user_id " &
            "FROM ( " &
                "SELECT MAX(approved_date) AS approved_date,ref_id,user_id,status " &
                "FROM trans_header_approval " &
                "GROUP BY ref_id,user_id " &
            ") a " &
            "LEFT JOIN trans_header_approval b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " &
            "WHERE b.status <> 2 " &
            "GROUP BY b.ref_id " &
            "ORDER BY b.approved_date " &
          ") a " &
          "LEFT JOIN trans_header_approval b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " &
        ") prevapprover ON prevapprover.ref_id = a.trans_id " &
        "WHERE a.journal_id = '{1}' AND a.book_id = '{2}' AND DATE_FORMAT(a.trans_date,'%Y-%m') = '{3}-{4}' " &
        "ORDER BY a.trans_no ASC " &
        "", _serverDBFS, JournalID, BookID, Year, Month.PadLeft(2, "0"))
        myDataTable = Query(sql)
        Me.ds.Tables("trans").Clear()
        For Each dr As DataRow In myDataTable.Rows
            Me.ds.Tables("trans").ImportRow(dr)
        Next
        If myDataTable.Rows.Count > 0 Then
            Dim LastIndex As Integer = myDataTable.Rows.Count - 1
            If pkID <> "" Then
                Dim selectedRows = myDataTable.Select("trans_id = '" & pkID & "'")
                If selectedRows.Count > 0 Then
                    LastIndex = myDataTable.Rows.IndexOf(selectedRows(0))
                End If
            End If
            clear_control()
            NewControls.bindControl(hdr, myDataTable.Rows(LastIndex), True)
            currentDr = myDataTable.Rows(LastIndex)
            disable_control(myDataTable.Rows(LastIndex).Item("user_id").ToString = main.user_id, myDataTable.Rows(LastIndex))
            NewControls.refreshRecordDet(dgjbooks, ds, txt_trans_id)
            If CDec(txtAmountBased.EditValue) < 0 Then
                txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(txtAmountBased.EditValue), main.DecimalPlaces)
            ElseIf CDec(txtAmountBased.EditValue) > 0 Then
                txt_amount_in_word.Text = amount_words(txtAmountBased.EditValue, main.DecimalPlaces)
            Else
                txt_amount_in_word.Text = ""
            End If
            computeTotal()
            pkID = myDataTable.Rows(LastIndex).Item("trans_id")
        Else
            Dim res = MsgBox("No Transaction Found for the Month. Want to add?", MsgBoxStyle.YesNo, "No Transaction")
            If res = MsgBoxResult.Yes Then
                btnAdd.PerformClick()
            Else
                clear_control()
                btnEdit.Enabled = False
            End If
        End If
    End Sub
    Friend Sub init()
        isInitialize = True
        TextEditEnterToTab(Me)
        dgjbooks.AutoGenerateColumns = False
        dgjbooks.DataSource = ds.Tables("jbooks")
        ds.Tables("jbooks").DefaultView.Sort = "dc,account_code"
        disable_control()
        Dim num As Integer = 21
        If main.Sys_Default.Rows(0)("line_remarks") = 0 Then
            lblLineRemarks.Visible = False
            txt_line_remarks.Visible = False
            lblcurrency.Top -= num
            txt_currency_id_det.Top -= num
            lblexchangerate.Top -= num
            txtExchangeRateDet.Top -= num
            lblbasedrate.Top -= num
            txtBasedRateDet.Top -= num
            lblProject.Top -= num
            txt_project_id.Top -= num
            lblDepartment.Top -= num
            txt_department_id.Top -= num
            lblUnitNo.Top -= num
            txt_book_unit_no_id.Top -= num
            txt_project_unit_no_id.Top -= num
            lblAllocation.Top -= num
            txt_allocation_id.Top -= num
            For Each obj As Control In det.Controls
                If obj.Tag IsNot Nothing Then
                    If obj.Tag.ToString <> "" And obj.Tag.ToString.Contains("adjustToTop") Then
                        obj.Top -= num
                    ElseIf TypeOf obj Is TextEdit Then
                        If obj.Tag.ToString() <> "" And Not obj.Tag.ToString.Contains("exchange_rate") And Not obj.Tag.ToString.Contains("based_rate") Then
                            obj.Top -= num
                        End If
                    End If
                End If
            Next
            det.Height -= num
            Me.Height -= num
        End If
        If main.Sys_Default.Rows(0)("line_currency") = 0 Then
            lblcurrency.Visible = False
            lblexchangerate.Visible = False
            lblbasedrate.Visible = False
            txt_currency_id_det.Visible = False
            txtExchangeRateDet.Visible = False
            txtBasedRateDet.Visible = False
            lblProject.Top -= num
            txt_project_id.Top -= num
            lblDepartment.Top -= num
            txt_department_id.Top -= num
            lblUnitNo.Top -= num
            txt_book_unit_no_id.Top -= num
            txt_project_unit_no_id.Top -= num
            lblAllocation.Top -= num
            txt_allocation_id.Top -= num
            For Each obj As Control In det.Controls
                If obj.Tag IsNot Nothing Then
                    If obj.Tag.ToString <> "" And obj.Tag.ToString.Contains("adjustToTop") Then
                        obj.Top -= num
                    ElseIf TypeOf obj Is TextEdit Then
                        If obj.Tag.ToString() <> "" And Not obj.Tag.ToString.Contains("exchange_rate") And Not obj.Tag.ToString.Contains("based_rate") Then
                            obj.Top -= num
                        End If
                    End If
                End If
            Next
            det.Height -= num
            Me.Height -= num
        End If
        If main.Sys_Default.Rows(0)("w_alloc") = 0 Then
            txt_allocation_id.Visible = False
            lblAllocation.Visible = False
        End If
        If main.Sys_Default.Rows(0)("w_proj") = 0 Then
            txt_project_id.Visible = False
            lblProject.Visible = False
        End If
        If main.Sys_Default.Rows(0)("w_dept") = 0 Then
            txt_department_id.Visible = False
            lblDepartment.Visible = False
        End If
        If main.Sys_Default.Rows(0)("w_alloc") = 0 And main.Sys_Default.Rows(0)("w_proj") = 0 And main.Sys_Default.Rows(0)("w_dept") = 0 Then
            For Each obj As Control In det.Controls
                If obj.Tag IsNot Nothing Then
                    If obj.Tag.ToString <> "" And obj.Tag.ToString.Contains("adjustToTop") Then
                        obj.Top -= num
                    ElseIf TypeOf obj Is TextEdit Then
                        If obj.Tag.ToString() <> "" And Not obj.Tag.ToString.Contains("exchange_rate") And Not obj.Tag.ToString.Contains("based_rate") Then
                            obj.Top -= num
                        End If
                    End If
                End If
            Next
            det.Height -= num
            Me.Height -= num
        End If
        Dim sql As String = String.Format("SELECT COUNT(a.approval_id) AS numRow " &
            "FROM sys_erp_approval a " &
            "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
            "WHERE b.module_code = '{0}'", module_code)
        Dim dt As DataTable = FsQuery(sql)
        withApproval = If(dt.Rows(0).Item("numRow").ToString = "0", False, True)
    End Sub
    Public Sub clear_control()
        NewControls.clearControl(hdr, True)
        For Each dt As DataTable In ds.Tables
            If dt.TableName = "trans" Then
                dt.Clear()
            End If
        Next
        'ds.Clear()
        lblcredittotal.Text = Format(0, txtDebitBased.Properties.DisplayFormat.FormatString)
        lbldifftotal.Text = Format(0, txtDebit.Properties.DisplayFormat.FormatString)
        lbldebitbasedtotal.Text = Format(0, txtDebitBased.Properties.DisplayFormat.FormatString)
        lblcreditbasedtotal.Text = Format(0, txtCreditBased.Properties.DisplayFormat.FormatString)
        lbldiffbasedtotal.Text = Format(0, txtDebit.Properties.DisplayFormat.FormatString)
        NewControls.clearControl(det)
    End Sub
    Private Sub enable_control()
        btnSearch.Visible = False
        btnNext.Visible = False
        btnPrevious.Visible = False
        btnParticular.Enabled = True
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
        btnInsert.Visible = True
        btnUpdate.Visible = True
        btnRemove.Visible = True
        btnOK.Visible = False
        btnUndo.Visible = False
        dgjbooks.Enabled = True
        btnExit.Visible = False
        NewControls.enableControl(hdr, True, True)
        Dim dr As DataRow = main.Sys_Default_Det.Select("module_code = 'ACC00101'")(0)
        Dim dr2 As DataRow = main.Sys_Default.Rows(0)
        If dr2("line_remarks") = 0 Then
            txt_description.Enabled = True
        End If
        If dr("auto_number") = 1 Then
            txt_trans_no.Enabled = False
            txt_day.Focus()
        Else
            txt_trans_no.Enabled = True
            txt_trans_no.Focus()
        End If
    End Sub
    Public Overrides Sub Refresh()
        If Not isInitialize Then
            init()
        End If
        Dim lagayan As String = mySettings.book_name
        lblBookName.Text = lagayan.ToString()
        dgjbooks.AutoGenerateColumns = False
        loadLastTransaction()
    End Sub
    Public Sub disable_control(Optional creator As Boolean = False, Optional dr As DataRow = Nothing)
        btnAdd.Visible = main.dicAction.Item(module_code).Item("m_add")
        btnEdit.Visible = main.dicAction.Item(module_code).Item("m_edit")
        btnCancel.Visible = main.dicAction.Item(module_code).Item("m_cancel")
        btnPrint.Visible = main.dicAction.Item(module_code).Item("m_print")
        btnSearch.Visible = True
        btnNext.Visible = True
        btnPrevious.Visible = True
        btnSubmit.Visible = False
        btnApprove.Visible = False
        btnCorrection.Visible = False
        btnComment.Visible = False
        btnEdit.Enabled = False
        dgjbooks.Enabled = True
        lblStatus.Text = ""
        lblStatus.Visible = False
        btnExit.Visible = True
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
            If dr.Item("status").ToString = "C" Then
                btnSubmit.Visible = False
                btnApprove.Visible = False
                btnEdit.Enabled = False
                btnCancel.Enabled = False
                btnCorrection.Visible = False
                btnPrint.Enabled = True
                lblStatus.Text = "Cancelled"
                lblStatus.Visible = True
            Else
                btnEdit.Enabled = True
                btnCancel.Enabled = True
                btnPrint.Enabled = True
            End If
            If dr.Item("isLock") Then
                btnSubmit.Visible = False
                btnApprove.Visible = False
                btnEdit.Enabled = False
                btnCancel.Enabled = False
                btnCorrection.Visible = False
                btnPrint.Enabled = True
                imgLock.Visible = True
            Else
                imgLock.Visible = False
            End If
        End If
        If Not withApproval Then
            btnSubmit.Visible = False
            btnApprove.Visible = False
            btnComment.Visible = False
        End If
        btnSettings.Visible = True
        btnSave.Visible = False
        btnNotSave.Visible = False
        btnInsert.Visible = False
        btnUpdate.Visible = False
        btnRemove.Visible = False
        btnOK.Visible = False
        btnUndo.Visible = False
        NewControls.enableControl(hdr, False, True)
    End Sub
    Private Sub enable_control_det()
        If txtBasedRate.EditValue = 0 Then
            MsgBox("Unable to modify entries because the Based Rate amount is equal to zero.")
            Exit Sub
        End If
        btnSave.Visible = False
        btnNotSave.Visible = False
        btnInsert.Visible = False
        btnUpdate.Visible = False
        btnRemove.Visible = False
        btnOK.Visible = True
        btnUndo.Visible = True
        dgjbooks.Enabled = False
        NewControls.enableControl(det)
        Dim dr As DataRow = main.Sys_Default.Rows(0)
        'txt_account_id.Focus()
    End Sub
    Private Sub disable_control_det()
        transmodedet = ""
        btnSave.Visible = True
        btnNotSave.Visible = True
        btnInsert.Visible = True
        btnUpdate.Visible = True
        btnRemove.Visible = True
        btnOK.Visible = False
        btnUndo.Visible = False
        dgjbooks.Enabled = True
        NewControls.clearControl(det)
        NewControls.enableControl(det, False)
        dgjbooks.ClearSelection()
        If dgjbooks.Rows.Count > 0 Then
            dgjbooks.Rows(0).Selected = True
        End If
    End Sub
    Friend Sub refresh_record()
        Dim sql As String = String.Format("SELECT currentapprover.user_id AS current_approver,currentapprover.status AS current_status " &
        ",prevapprover.user_id AS prev_approver,prevapprover.status AS prev_status " &
        ",creator.user_id,creator.stage_id " &
        ",a.* " &
        ",c.general_code,c.general_name " &
        ",d.currency_code,d.currency_name " &
        ",IFNULL(b.trans_ib_id,'') AS trans_ib_id,IFNULL(b.si_no,'') AS si_no,IFNULL(b.dr_no,'') AS dr_no,IFNULL(b.po_no,'') AS po_no " &
        ",IFNULL(b.terms_id,'') AS terms_id,IFNULL(b.nodays,0) AS nodays,e.terms_name,b.due_date " &
        "FROM trans_header a " &
        "LEFT JOIN trans_header_ib b ON a.trans_id = b.trans_id " &
        "LEFT JOIN {0}.lib_erp_general c ON a.general_id = c.general_id " &
        "LEFT JOIN {0}.lib_erp_currency d ON a.currency_id = d.currency_id " &
        "LEFT JOIN {0}.lib_erp_terms e ON b.terms_id = e.terms_id " &
        "LEFT JOIN ( " &
          "SELECT * " &
          "FROM trans_header_status " &
          "GROUP BY ref_id " &
        ") creator ON creator.ref_id = a.trans_id " &
        "LEFT JOIN ( " &
          "SELECT b.* " &
          "FROM ( " &
            "SELECT MAX(approved_date) AS approved_date,ref_id " &
            "FROM trans_header_status " &
            "GROUP BY ref_id " &
          ") a " &
          "LEFT JOIN trans_header_status b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " &
          "GROUP BY ref_id " &
        ") currentapprover ON currentapprover.ref_id = a.trans_id " &
        "LEFT JOIN ( " &
          "SELECT b.* " &
          "FROM ( " &
            "SELECT MAX(b.approved_date) AS approved_date,b.ref_id,b.user_id " &
            "FROM ( " &
                "SELECT MAX(approved_date) AS approved_date,ref_id,user_id,status " &
                "FROM trans_header_approval " &
                "GROUP BY ref_id,user_id " &
            ") a " &
            "LEFT JOIN trans_header_approval b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " &
            "WHERE b.status <> 2 " &
            "GROUP BY b.ref_id " &
            "ORDER BY b.approved_date " &
          ") a " &
          "LEFT JOIN trans_header_approval b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id " &
        ") prevapprover ON prevapprover.ref_id = a.trans_id " &
        "WHERE a.trans_id = '{1}'; " &
        "", _serverDBFS, pkID)
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count > 0 Then
            NewControls.bindControl(hdr, dt.Rows(0), True)
            currentDr = dt.Rows(0)
            disable_control(dt.Rows(0).Item("user_id").ToString = main.user_id, dt.Rows(0))
            NewControls.refreshRecordDet(dgjbooks, ds, txt_trans_id)
            If CDec(txtAmountBased.EditValue) < 0 Then
                txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(txtAmountBased.EditValue), main.DecimalPlaces)
            ElseIf CDec(txtAmountBased.EditValue) > 0 Then
                txt_amount_in_word.Text = amount_words(txtAmountBased.EditValue, main.DecimalPlaces)
            Else
                txt_amount_in_word.Text = ""
            End If
            computeTotal()
        End If
    End Sub
    Private Sub bind_control_det()
        If Not transmodedet = "" Then
            Exit Sub
        End If
        If dgjbooks.RowCount = 0 Then
            NewControls.clearControl(det)
            Exit Sub
        End If
        If dgjbooks.SelectedRows.Count = 0 Then
            NewControls.clearControl(det)
            Exit Sub
        End If
        Dim sel As String = dgjbooks.SelectedRows(0).Cells("jbooks_id_tmp").Value.ToString
        Dim tmp_dr = ds.Tables("jbooks").Select("jbooks_id_tmp = '" & sel & "'")
        Dim dr As DataRow = Nothing
        If tmp_dr.Count > 0 Then
            dr = tmp_dr(0)
            NewControls.bindControl(det, dr)
            If dr.Item("validation").ToString = "2" Or dr.Item("validation").ToString = "3" Then
                lbltermsdet.Visible = True
                txt_terms_id_det.Visible = True
                txt_nodays_det.Visible = True
            Else
                lbltermsdet.Visible = False
                txt_terms_id_det.Visible = False
                txt_nodays_det.Visible = False
            End If

            Dim unit_applicable As Boolean = CBool(ifNull(dr.Item("unit_applicable"), 0))
            If unit_applicable Then
                If My.Settings._enableUnitNo Then
                    lblUnitNo.Visible = True
                    If My.Settings._enableBookUnit Then
                        txt_book_unit_no_id.Visible = True
                        txt_project_unit_no_id.Visible = False
                    Else
                        txt_project_unit_no_id.Visible = True
                        txt_book_unit_no_id.Visible = False
                    End If
                End If
            Else
                lblUnitNo.Visible = False
                txt_project_unit_no_id.Visible = False
                txt_book_unit_no_id.Visible = False
            End If
        End If
    End Sub
    Public Sub computeTotal()
        Dim dtot As Decimal = 0
        Dim ctot As Decimal = 0
        Dim dbtot As Decimal = 0
        Dim cbtot As Decimal = 0
        For Each dr As DataRow In ds.Tables("jbooks").Rows
            If Not dr.Item("deleted") Then
                dtot += Math.Round(CDec(ifNull(dr.Item("debit"), 0)), main.DecimalPlaces)
                ctot += Math.Round(CDec(ifNull(dr.Item("credit"), 0)), main.DecimalPlaces)
                dbtot += Math.Round(CDec(ifNull(dr.Item("debit_based"), 0)), main.DecimalPlaces)
                cbtot += Math.Round(CDec(ifNull(dr.Item("credit_based"), 0)), main.DecimalPlaces)
                'dtot += CDec(ifNull(dr.Item("debit"), 0))
                'ctot += CDec(ifNull(dr.Item("credit"), 0))
                'dbtot += CDec(ifNull(dr.Item("debit_based"), 0))
                'cbtot += CDec(ifNull(dr.Item("credit_based"), 0))
            End If
        Next
        'If(ds.Tables("jbooks").Select("deleted = 'False'").Count > 0, ds.Tables("jbooks").Compute("sum(debit)", "deleted = 'False'"), 0)
        'Dim ctot As Decimal = If(ds.Tables("jbooks").Select("deleted = 'False'").Count > 0, ds.Tables("jbooks").Compute("sum(credit)", "deleted = 'False'"), 0)
        Dim diff As Decimal = dtot - ctot
        lbldebittotal.Text = Format(dtot, txtDebit.Properties.DisplayFormat.FormatString)
        lblcredittotal.Text = Format(ctot, txtDebitBased.Properties.DisplayFormat.FormatString)
        lbldifftotal.Text = Format(diff, txtDebit.Properties.DisplayFormat.FormatString)
        'Dim dbtot As Decimal = If(ds.Tables("jbooks").Select("deleted = 'False'").Count > 0, ds.Tables("jbooks").Compute("sum(debit_based)", "deleted = 'False'"), 0)
        'Dim cbtot As Decimal = If(ds.Tables("jbooks").Select("deleted = 'False'").Count > 0, ds.Tables("jbooks").Compute("sum(credit_based)", "deleted = 'False'"), 0)
        Dim diffb As Decimal = dbtot - cbtot
        lbldebitbasedtotal.Text = Format(dbtot, txtDebitBased.Properties.DisplayFormat.FormatString)
        lblcreditbasedtotal.Text = Format(cbtot, txtCreditBased.Properties.DisplayFormat.FormatString)
        lbldiffbasedtotal.Text = Format(diffb, txtDebitBased.Properties.DisplayFormat.FormatString)
    End Sub
#End Region
    Public Shared Property arr_deleted As New List(Of Integer)

#Region "Events"
    Private Sub transactionib_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim closed As Boolean = False
        If transMode <> "" Then
            Dim confirm = MsgBox("There are transactions that are not yet done. Are you sure to exit the form?", MsgBoxStyle.YesNo, "Transaction Undone.")
            If confirm = MsgBoxResult.No Then
                e.Cancel = True
                closed = True
            Else
                mySettings.toClose = True
            End If
        End If
        'If Not closed Then
        '    If mySettings IsNot Nothing Then
        '        e.Cancel = True
        '        Me.Hide()
        '        mySettings.ShowDialog()
        '        mySettings.toClose = False
        '    End If
        'End If
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
                Dim sql_approved As String = String.Format("" &
                "SELECT b.* " &
                "FROM ( " &
                    "SELECT MAX(approved_date) AS approved_date,ref_id,user_id " &
                    "FROM trans_header_approval " &
                    "GROUP BY ref_id,user_id " &
                ") a " &
                "LEFT JOIN trans_header_approval b ON b.approved_date = a.approved_date AND b.ref_id = a.ref_id AND b.user_id = a.user_id " &
                "WHERE b.ref_id = {0}; " &
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
                Dim sql_stage As String = String.Format("" &
                "SELECT c.approval_user_id,c.approval_id,c.user_id,c.approval_order,c.order_no AS approval_order " &
                ",a.order_no AS stage_order,False AS _used " &
                "FROM sys_erp_approval a " &
                "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
                "LEFT JOIN sys_erp_approval_user c ON c.approval_id = a.approval_id " &
                "WHERE b.module_code = '{0}' " &
                "ORDER BY a.order_no; " &
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
        frmapproval.ref_id = txt_trans_id.Text
        If frmapproval.ShowDialog = Windows.Forms.DialogResult.OK Then
            refresh_record()
        End If
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Query(String.Format("CALL approvedata('{0}',{1},{2},{3},{4},'{5}');", module_code, 0, txt_trans_id.Text, 0, frmapproval.log_id, ""))
        refresh_record()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim where As String = ""
        txt_day.Text = Now().Day
        Me.AccessibleName = main.Sys_Default.Rows(0)("monthly_currency")
        If main.Sys_Default.Rows(0)("monthly_currency") Then
            where = "where DATE_FORMAT(effectivitydate,'%Y-%m') = '" & txt_year.Text & "-" & txt_month.Value.PadLeft(2, "0") & "' "
        Else
            where = "where effectivitydate = '" & txt_year.Text & "-" & txt_month.Value.PadLeft(2, "0") & "-" & txt_day.Text.PadLeft(2, "0") & "'"
        End If
        Dim _tmp_sql As String = "select a.currency_id,a.currency_code,a.currency_name " &
            ",b.exchange_rate,b.based_rate " &
            "from lib_erp_currency a " &
            "inner join (select a.currency_id,a.exchange_rate,a.based_rate " &
                    "from lib_erp_currency_rate a " &
                    "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " &
                            "FROM lib_erp_currency_rate " & where &
                    "group by currency_id) b on a.currency_id = b.currency_id " &
                "and a.effectivitydate = b.effectivitydate) b on a.currency_id = b.currency_id"
        currency = FsQuery(_tmp_sql)
        If currency.Rows.Count = 0 Then
            MsgBox(String.Format("No Currency Rate Setup for the {0}.", If(main.Sys_Default.Rows(0)("monthly_currency"), "Month", "Day")))
            Exit Sub
        End If
        transMode = "add"
        enable_control()
        clear_control()
        Dim sql As String = String.Format("SELECT auto_number FROM lib_erp_journal WHERE journal_id = {0}", JournalID)
        Dim dt As DataTable = FsQuery(sql)
        txt_due_date.Value = DateTime.Today
        txt_day.Text = Now().Day
        txt_trans_no.Enabled = True
        If dt.Rows(0).Item("auto_number") = 1 Then
            Dim tmp_sql As String = "call getnewtransno(" & JournalID & "," & BookID & "," & txt_month.Value & "," & txt_year.Text & ")"
            Dim newno = Query("call getnewtransno(" & JournalID & "," & BookID & "," & txt_month.Value & "," & txt_year.Text & ")").Rows(0)("trans_no_new")
            txt_trans_no.Text = newno.ToString
            'txt_trans_no.Enabled = False
            txt_day.Focus()
        Else
            txt_trans_no.Text = ""
            'txt_trans_no.Enabled = True
            txt_trans_no.Focus()
        End If
        ds.Clear()
        dgjbooks.DataSource = ds.Tables("jbooks")
        lblStatus.Text = ""
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim allowEdit As Boolean = True
        Me.AccessibleName = main.Sys_Default.Rows(0)("monthly_currency")
        For Each dr As DataRow In ds.Tables("jbooks").Rows
            Dim offset As Integer = CInt(ifNull(dr.Item("offset"), 0))
            If offset > 0 Then
                allowEdit = False
            End If
        Next
        transMode = "edit"
        enable_control()
        txt_currency_id.Enabled = False
        If Not allowEdit Then
            txt_general_id.Enabled = False
            txt_day.Enabled = False
        End If
        'txtExchangeRate.Enabled = False
        'txtBasedRate.Enabled = False
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        report_ib_filter_new.journal_id = JournalID
        report_ib_filter_new.book_id = BookID
        report_ib_filter_new.transid = txt_trans_id.Text
        report_ib_filter_new.transno = txt_trans_no.Text
        report_ib_filter_new.ShowDialog()
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        mySettings.ShowDialog()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        TransactionListing.myDataTable = myDataTable
        TransactionListing.transactionName = "Invoicing No"
        TransactionListing.selectedID = pkID
        TransactionListing.frmTransaction = Me
        TransactionListing.ShowDialog()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'emon-2017-11-21
        Dim tmp_trans_date = txt_year.Text & "-" & txt_month.Value.PadLeft(2, "0") & "-" & txt_day.Text.PadLeft(2, "0")
        Dim sql_lock = String.Format("SELECT MAX(IFNULL(isLock,False)) AS isLock FROM transaction_locking WHERE journal_id = '{0}' AND '{1}' BETWEEN date_from AND date_to", JournalID, tmp_trans_date)
        Dim dt_lock As DataTable = Query(sql_lock)
        If dt_lock.Rows.Count > 0 Then
            If dt_lock.Rows(0).Item("isLock").ToString <> "" Then
                If dt_lock.Rows(0).Item("isLock") Then
                    MsgBox("Transaction is Lock.")
                    btnSave.Enabled = True
                    Exit Sub
                End If
            End If
        End If
        'emon-2017-11-21
        If txt_trans_no.Text = "" Then
            MsgBox("Cannot save transaction. Transaction No. is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            btnSave.Enabled = True
            Exit Sub
        Else
            Dim sql_test_trans_no = String.Format("SELECT trans_no AS existing FROM trans_header WHERE trans_no = '{0}' AND trans_id <> '{1}' AND journal_id = '{2}'", txt_trans_no.Text, txt_trans_id.Text, JournalID)
            Dim dt_test_rans_no As DataTable = Query(sql_test_trans_no)
            If dt_test_rans_no.Rows.Count > 0 Then
                Dim dr As DataRow = main.Sys_Default_Det.Select("module_code = 'ACC00101'")(0)
                If dr("auto_number") = 1 Then
                    Dim res = MsgBox("Transaction Number Already Exist. Want to Generate New transaction Number?", MsgBoxStyle.YesNo)
                    If res = MsgBoxResult.Yes Then
                        Dim strTransNo As String = txt_trans_no.Text
                        NewControls.getNewTransNo(strTransNo, JournalID, BookID, Month, Year, txt_trans_id.Text)
                        txt_trans_no.Text = strTransNo
                    Else
                        btnSave.Enabled = True
                        Exit Sub
                    End If
                Else
                    MsgBox("Transaction Number already exist. Review first the reference number and try to save again.")
                    Exit Sub
                End If
            End If
        End If
        If txt_general_id.Text = "" Then
            MsgBox("Cannot save transaction. Supplier is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            btnSave.Enabled = True
            Exit Sub
        End If
        If txt_currency_id.Text = "" Then
            MsgBox("Cannot save transaction. Currency is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            btnSave.Enabled = True
            Exit Sub
        End If
        If txtExchangeRate.EditValue = 0 Then
            MsgBox("Cannot save transaction. Exchange Rate must not be zero.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            btnSave.Enabled = True
            Exit Sub
        End If
        If txtBasedRate.EditValue = 0 Then
            MsgBox("Cannot save transaction. Based Rate must not be zero.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            btnSave.Enabled = True
            Exit Sub
        End If
        If ds.Tables("jbooks").Rows.Count = 0 Then
            MsgBox("Cannot save transaction. No details in transaction.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            btnSave.Enabled = True
            Exit Sub
        End If
        If Val(lbldifftotal.Text.Replace(",", "")) <> 0 Then
            MsgBox("Cannot save transaction. Debit and Credit is not balance.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            btnSave.Enabled = True
            Exit Sub
        End If
        If Val(lbldiffbasedtotal.Text.Replace(",", "")) <> 0 Then
            MsgBox("Cannot save transaction. Debit and Credit is not balance.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            btnSave.Enabled = True
            Exit Sub
        End If
        Dim tmp_pk As String = "0"
        Dim pk_name As String = "trans_id"

        'header
        Dim qry As String = ""
        Dim fields As New Dictionary(Of String, String)

        fields.Add("trans_id", txt_trans_id.Text)
        fields.Add("trans_no", txt_trans_no.Text)
        fields.Add("trans_date", txt_year.Text & "-" & txt_month.Value.PadLeft(2, "0") & "-" & txt_day.Text.PadLeft(2, "0"))
        fields.Add("book_id", BookID)
        fields.Add("journal_id", JournalID)
        fields.Add("general_id", txt_general_id.Value)
        fields.Add("currency_id", txt_currency_id.Value)
        fields.Add("exchange_rate", txtExchangeRate.EditValue)
        fields.Add("based_rate", txtBasedRate.EditValue)
        fields.Add("amount", txtAmount.EditValue)
        fields.Add("amount_based", txtAmountBased.EditValue)
        fields.Add("description", txt_description.Text)
        If transMode = "add" Then
            'qry = genInsert("trans_header", fields)
            qry = ATGenerateQuery("Insert", "trans_header", fields, Environment.MachineName, Environment.UserName, main.log_id, txt_trans_id.Text, "trans_id")
        Else
            'qry = genUpdate("trans_header", fields)
            qry = ATGenerateQuery("Update", "trans_header", fields, Environment.MachineName, Environment.UserName, main.log_id, txt_trans_id.Text, "trans_id")
        End If
        Dim dt As DataTable = Query(qry)
        Dim trans_id As String = dt.Rows(0).Item("return_id").ToString
        Dim addsave As Boolean = False
        If transMode = "add" Then
            'qry = "SELECT trans_id FROM trans_header WHERE trans_no = '" & txt_trans_no.Text & "' AND book_id = " & BookID & " AND journal_id = " & JournalID
            'dt = Query(qry)
            'trans_id = dt.Rows(0)("trans_id").ToString
            Query(String.Format("CALL submitapproval('{0}',{1},{2});", module_code, trans_id, main.user_id))
            addsave = True
            'Else
            '    trans_id = txt_trans_id.Text
        End If

        tmp_pk = trans_id
        pkID = trans_id

        'particular
        Dim sql_particular As String = ""
        For Each dr As DataRow In ds.Tables("particular").Rows
            fields = New Dictionary(Of String, String)
            fields.Add("trans_particular_id", dr.Item("trans_particular_id").ToString)
            fields.Add("trans_id", trans_id)
            fields.Add("trans_particular_code", dr.Item("trans_particular_code").ToString)
            fields.Add("trans_particular_name", dr.Item("trans_particular_name").ToString)
            fields.Add("trans_particular_amount", dr.Item("trans_particular_amount").ToString)

            If fields.Item("trans_particular_id").ToString.Contains("tmp_") Then

                If Not dr.Item("deleted") Then

                    'sql_particular &= genInsert("trans_header_particular", fields) & ";"
                    sql_particular &= ATGenerateQuery("Insert", "trans_header_particular", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("trans_particular_id").ToString, "trans_particular_id")
                End If
            Else
                If dr.Item("deleted") Then
                    'sql_particular &= String.Format("DELETE FROM trans_header_particular WHERE trans_particular_id = '{0}';", fields.Item("trans_particular_id").ToString)
                    qry &= ATGenerateQuery("Remove", "trans_header_particular", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("trans_particular_id").ToString & "|", "trans_particular_id")
                Else
                    'sql_particular &= genUpdate("trans_header_particular", fields) & ";"
                    qry &= ATGenerateQuery("Update", "trans_header_particular", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("trans_particular_id").ToString, "trans_particular_id")
                End If
            End If
        Next
        If sql_particular <> "" Then
            Query(sql_particular)
        End If

        'ib
        qry = ""
        fields = New Dictionary(Of String, String)
        fields.Add("trans_ib_id", txt_trans_ib_id.Text)
        fields.Add("trans_id", trans_id)
        fields.Add("dr_no", txt_dr_no.Text)
        fields.Add("po_no", txt_po_no.Text)
        fields.Add("due_date", CDate(txt_due_date.Value).ToString("yyyy-MM-dd"))
        fields.Add("terms_id", txt_terms_id.Value)
        fields.Add("nodays", txt_nodays.DecimalValue)
        If txt_trans_ib_id.Text = "" Then
            'qry = genInsert("trans_header_ib", fields)
            qry = ATGenerateQuery("Insert", "trans_header_ib", fields, Environment.MachineName, Environment.UserName, main.log_id, txt_trans_ib_id.Text, "trans_ib_id")
        Else
            'qry = genUpdate("trans_header_ib", fields)
            qry = ATGenerateQuery("Update", "trans_header_ib", fields, Environment.MachineName, Environment.UserName, main.log_id, txt_trans_ib_id.Text, "trans_ib_id")
        End If
        dt = Query(qry)





        'project management 
        Dim sql_project_management_remove As String = ""
        For i As Integer = 0 To arr_deleted.Count - 1
            sql_project_management_remove = ATGenerateQuery("Remove", "trans_header_project_management", Nothing, Environment.MachineName, Environment.UserName, main.log_id, arr_deleted(i).ToString & "|", "trans_project_management_id")
            If sql_project_management_remove <> "" Then
                Query(sql_project_management_remove)
            End If
        Next



        Dim sql_project_management As String = ""
        For Each dr As DataRow In ds.Tables("project_management").Rows
            fields = New Dictionary(Of String, String)
            fields.Add("trans_project_management_id", dr.Item("trans_project_management_id"))
            fields.Add("trans_id", trans_id)
            fields.Add("project_management_det_id", dr.Item("project_management_det_id"))
            fields.Add("billed_amount", dr.Item("billed_amount"))
            fields.Add("billed_amount_based", dr.Item("billed_amount_based"))
            fields.Add("currency_id", If(dr.Item("currency_id") = 0, 1, 1))
            fields.Add("exchange_rate", dr.Item("exchange_rate"))
            fields.Add("based_rate", dr.Item("based_rate"))
            If fields.Item("trans_project_management_id").ToString.Contains("tmp_") Or fields.Item("trans_project_management_id").ToString() = 0 Then
                If Not dr.Item("deleted") Then
                    sql_project_management &= ATGenerateQuery("Insert", "trans_header_project_management", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("trans_project_management_id").ToString, "trans_project_management_id")
                End If
            Else
                If dr.Item("deleted") Then
                Else
                    sql_project_management &= ATGenerateQuery("Update", "trans_header_project_management", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("trans_project_management_id").ToString, "trans_project_management_id")
                End If
            End If
        Next
        If sql_project_management <> "" Then
            Query(sql_project_management)
        End If




        'jbooks
        qry = ""
        Dim jbooks_ids As New Dictionary(Of String, String)
        For i = 0 To ds.Tables("jbooks").Rows.Count - 1
            qry = ""
            Dim dr As DataRow = ds.Tables("jbooks").Rows(i)
            fields = New Dictionary(Of String, String)
            fields.Add("jbooks_id", IIf(dr("jbooks_id_tmp").ToString.Contains("tmp_") Or dr("jbooks_id_tmp").ToString = "", dr("jbooks_id_tmp").ToString, dr("jbooks_id").ToString))
            Dim jbookstransid As String = IIf(dr("trans_id").ToString = "", trans_id, dr("trans_id").ToString)
            fields.Add("trans_id", jbookstransid)
            Dim projectid As String = IIf(dr("project_id").ToString = "", Nothing, dr("project_id").ToString)
            fields.Add("project_id", projectid)
            Dim departmentid As String = IIf(dr("department_id").ToString = "", Nothing, dr("department_id").ToString)
            fields.Add("department_id", departmentid)
            Dim allocationid As String = IIf(dr("allocation_id").ToString = "", Nothing, dr("allocation_id").ToString)
            fields.Add("allocation_id", allocationid)
            Dim bookunitnoid As String = IIf(dr("book_unit_no_id").ToString = "", Nothing, dr("book_unit_no_id").ToString)
            Dim projectunitnoid As String = IIf(dr("project_unit_no_id").ToString = "", Nothing, dr("project_unit_no_id").ToString)
            fields.Add("book_unit_no_id", bookunitnoid)
            fields.Add("project_unit_no_id", projectunitnoid)
            fields.Add("account_id", dr("account_id").ToString)
            fields.Add("line_remarks", dr("line_remarks").ToString)
            fields.Add("debit", dr("debit").ToString)
            fields.Add("credit", dr("credit").ToString)
            fields.Add("currency_id", dr("currency_id").ToString)
            fields.Add("exchange_rate", dr("exchange_rate").ToString)
            fields.Add("based_rate", dr("based_rate").ToString)
            Dim debit_based As Decimal = 0
            Dim credit_based As Decimal = 0
            If dr("ref_jbooks_id").ToString = "" And dr("validation").ToString <> "10" Then
                debit_based = dr("debit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                credit_based = dr("credit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
            Else
                debit_based = dr("debit_based").ToString
                credit_based = dr("credit_based").ToString
            End If
            fields.Add("debit_based", debit_based)
            fields.Add("credit_based", credit_based)
            Dim generalid As String = IIf(dr("general_id").ToString = "", Nothing, dr("general_id").ToString)
            fields.Add("general_id", generalid)
            Dim refjbooksid As String = IIf(dr("ref_jbooks_id").ToString = "", Nothing, dr("ref_jbooks_id").ToString)
            fields.Add("ref_jbooks_id", refjbooksid)

            If CDec(ifNull(dr("debit"), 0)) = 0 And CDec(ifNull(dr("debit_based"), 0)) And CDec(ifNull(dr("credit"), 0)) = 0 And CDec(ifNull(dr("credit_based"), 0)) Then
                dr("deleted") = True
            End If

            If dr("jbooks_id_tmp").ToString = "" Or dr.Item("jbooks_id_tmp").ToString.Contains("tmp_") Or fields("jbooks_id").ToString = "" Or fields.Item("jbooks_id").ToString.Contains("tmp_") Then
                If dr("deleted").ToString = "False" Then
                    'qry = genInsert("trans_jbooks", fields) & ";SELECT LAST_INSERT_ID() AS id;"
                    qry = ATGenerateQuery("Insert", "trans_jbooks", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("jbooks_id").ToString, "jbooks_id")
                End If
            Else
                If dr("deleted").ToString = "True" Then
                    'qry = String.Format("DELETE FROM trans_jbooks WHERE jbooks_id = {0}", dr("jbooks_id").ToString)
                    qry = ATGenerateQuery("Remove", "trans_jbooks", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("jbooks_id").ToString & "|", "jbooks_id")
                Else
                    'qry = genUpdate("trans_jbooks", fields)
                    qry = ATGenerateQuery("Update", "trans_jbooks", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("jbooks_id").ToString, "jbooks_id")
                End If
            End If
            If qry <> "" Then
                Dim lastID As DataTable = Query(qry)
                If lastID.Rows.Count > 0 Then
                    jbooks_ids.Add(dr("jbooks_id_tmp").ToString, lastID.Rows(0).Item("return_id").ToString)
                Else
                    jbooks_ids.Add(dr("jbooks_id_tmp").ToString, dr.Item("jbooks_id").ToString)
                End If
            Else
                jbooks_ids.Add(dr("jbooks_id_tmp").ToString, "")
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
                                    If IsNumeric(item.Value) Then
                                        tmp_sql &= If(Not flag, " ", " AND ") & String.Format(" ROUND({0},2) = ROUND({1},2) ", item.Key, item.Value)
                                    Else
                                        tmp_sql &= If(Not flag, " ", " AND ") & String.Format(" {0} = '{1}' ", item.Key, item.Value.Replace("'", "''"))
                                    End If
                                    flag = True
                                End If
                            End If
                        End If
                    Next
                    tmp_dt = Query(tmp_sql)
                End If
                If dr("validation").ToString = "2" And dr("debit") > 0 Then
                    fields = New Dictionary(Of String, String)
                    fields.Add("jbooks_ar_id", dr("jbooks_terms_id").ToString)
                    fields.Add("jbooks_id", If(dr("jbooks_id").ToString = "", tmp_dt.Rows(0).Item("id").ToString, dr("jbooks_id").ToString))
                    fields.Add("nodays", ifNull(dr("nodays"), 0))
                    fields.Add("terms_id", dr("terms_id").ToString)
                    If fields.Item("jbooks_ar_id").ToString = "" Or fields.Item("jbooks_ar_id").ToString.Contains("tmp_") Then
                        'qry = genInsert("trans_jbooks_ar", fields)
                        qry = ATGenerateQuery("Insert", "trans_jbooks_ar", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("jbooks_terms_id").ToString, "jbooks_ar_id")
                    Else
                        'qry = genUpdate("trans_jbooks_ar", fields)
                        qry = ATGenerateQuery("Update", "trans_jbooks_ar", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("jbooks_terms_id").ToString, "jbooks_ar_id")
                    End If
                    Try
                        dt = Query(qry)

                    Catch ex As Exception
                        MyDebugging.AddText(ex.Message)
                    End Try
                ElseIf dr("validation").ToString = "3" And dr("credit") > 0 Then
                    fields = New Dictionary(Of String, String)
                    fields.Add("jbooks_ap_id", dr("jbooks_terms_id").ToString)
                    fields.Add("jbooks_id", If(dr("jbooks_id").ToString = "", tmp_dt.Rows(0).Item("id").ToString, dr("jbooks_id").ToString))
                    fields.Add("nodays", dr("nodays").ToString)
                    fields.Add("terms_id", dr("terms_id").ToString)
                    If fields.Item("jbooks_id").ToString <> "" Then
                        If fields.Item("jbooks_ap_id").ToString = "" Then
                            'qry = genInsert("trans_jbooks_ap", fields)
                            qry = ATGenerateQuery("Insert", "trans_jbooks_ap", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("jbooks_terms_id").ToString, "jbooks_ap_id")
                        Else
                            'qry = genUpdate("trans_jbooks_ap", fields)
                            qry = ATGenerateQuery("Update", "trans_jbooks_ap", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("jbooks_terms_id").ToString, "jbooks_ap_id")
                        End If
                        Try
                            dt = Query(qry)
                        Catch ex As Exception
                            MyDebugging.AddText(ex.Message)
                        End Try
                    End If
                End If
            End If
        Next
        'Dim jbooks_id As String = ""
        'qry = "SELECT jbooks_id FROM trans_jbooks WHERE trans_id = " & trans_id
        'dt = Query(qry)
        'For Each dr As DataRow In ds.Tables("jbooks").Rows
        '    If dr("jbooks_id").ToString = "" Then
        '        If dt.Rows.Count > dr.Table.Rows.IndexOf(dr) Then
        '            jbooks_id = dt.Rows(dr.Table.Rows.IndexOf(dr))("jbooks_id").ToString
        '        Else
        '            jbooks_id = dt.Rows(0)("jbooks_id").ToString
        '        End If
        '    Else
        '        jbooks_id = dr("jbooks_id").ToString
        '    End If
        '    jbooks_ids.Add(dr("jbooks_id_tmp").ToString, jbooks_id)
        'Next

        'ewt
        If ds.Tables("ewt").Rows.Count > 0 Then
            For i = 0 To ds.Tables("ewt").Rows.Count - 1
                qry = ""
                Dim dr As DataRow = ds.Tables("ewt").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("ewt_id", dr("ewt_id").ToString)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id").ToString))
                fields.Add("general_id", dr("general_id").ToString)
                fields.Add("fs_ewt_id", dr("fs_ewt_id").ToString)
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("tax_rate", dr("tax_rate").ToString)
                fields.Add("amount", dr("amount").ToString)
                fields.Add("tax_amount", dr("tax_amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                Dim amount_based As Decimal = 0
                Dim tax_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_ewt_id").ToString = "" Then
                    amount_based = dr("amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    tax_amount_based = dr("tax_amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    debit_based = dr("debit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    credit_based = dr("credit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                Else
                    amount_based = dr("amount_based").ToString
                    tax_amount_based = dr("tax_amount_based").ToString
                    debit_based = dr("debit_based").ToString
                    credit_based = dr("credit_based").ToString
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("tax_amount_based", tax_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                Dim refewtid As String = IIf(dr("ref_ewt_id").ToString = "", Nothing, dr("ref_ewt_id").ToString)
                fields.Add("ref_ewt_id", refewtid)
                If dr("ewt_id").ToString.Contains("tmp_") Then
                    dr("ewt_id") = ""
                End If
                If dr("ewt_id").ToString = "" Then
                    If dr("deleted").ToString = "False" Then
                        'qry = genInsert("trans_ewt", fields)
                        qry = ATGenerateQuery("Insert", "trans_ewt", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("ewt_id").ToString, "ewt_id")
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        'qry = String.Format("DELETE FROM trans_ewt WHERE ewt_id = {0}", dr("ewt_id").ToString)
                        qry = ATGenerateQuery("Remove", "trans_ewt", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("ewt_id").ToString & "|", "ewt_id")
                    Else
                        'qry = genUpdate("trans_ewt", fields)
                        qry = ATGenerateQuery("Update", "trans_ewt", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("ewt_id").ToString, "ewt_id")
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
                fields.Add("final_tax_id", dr("final_tax_id").ToString)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id").ToString))
                fields.Add("general_id", dr("general_id").ToString)
                fields.Add("fs_final_tax_id", dr("fs_final_tax_id").ToString)
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("tax_rate", dr("tax_rate").ToString)
                fields.Add("amount", dr("amount").ToString)
                fields.Add("tax_amount", dr("tax_amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                Dim amount_based As Decimal = 0
                Dim tax_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_final_tax_id").ToString = "" Then
                    amount_based = dr("amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    tax_amount_based = dr("tax_amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    debit_based = dr("debit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    credit_based = dr("credit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                Else
                    amount_based = dr("amount_based").ToString
                    tax_amount_based = dr("tax_amount_based").ToString
                    debit_based = dr("debit_based").ToString
                    credit_based = dr("credit_based").ToString
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("tax_amount_based", tax_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                Dim reffinaltaxid As String = IIf(dr("ref_final_tax_id").ToString = "", Nothing, dr("ref_final_tax_id").ToString)
                fields.Add("ref_final_tax_id", reffinaltaxid)
                If dr("final_tax_id").ToString.Contains("tmp_") Then
                    dr("final_tax_id") = ""
                End If
                If dr("final_tax_id").ToString = "" Then
                    If dr("deleted").ToString = "False" Then
                        'qry = genInsert("trans_final_tax", fields)
                        qry = ATGenerateQuery("Insert", "trans_final_tax", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("final_tax_id").ToString, "final_tax_id")
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        'qry = String.Format("DELETE FROM trans_final_tax WHERE final_tax_id = {0}", dr("final_tax_id").ToString)
                        qry = ATGenerateQuery("Remove", "trans_final_tax", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("final_tax_id").ToString & "|", "final_tax_id")
                    Else
                        'qry = genUpdate("trans_final_tax", fields)
                        qry = ATGenerateQuery("Update", "trans_final_tax", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("final_tax_id").ToString, "final_tax_id")
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
                fields.Add("check_id", dr("check_id").ToString)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id").ToString))
                fields.Add("general_id", dr("general_id").ToString)
                fields.Add("check_no", dr("check_no").ToString)
                fields.Add("check_date", CDate(dr("check_date").ToString).ToString("yyyy-MM-dd"))
                fields.Add("check_amount", dr("check_amount").ToString)
                fields.Add("check_amount_based", dr("check_amount_based").ToString)
                fields.Add("bank_id", dr("bank_id").ToString)
                fields.Add("cleared", IIf(dr("cleared"), "1", "0"))
                fields.Add("released", IIf(dr("released"), "1", "0"))
                fields.Add("cancelled", IIf(dr("cancelled"), "1", "0"))
                fields.Add("crossed", IIf(dr("crossed"), "1", "0"))
                fields.Add("replacement_check_no", dr("replacement_check_no").ToString)
                fields.Add("cleared_date", CDate(dr("cleared_date").ToString).ToString("yyyy-MM-dd"))
                fields.Add("deposit_date", CDate(dr("deposit_date").ToString).ToString("yyyy-MM-dd"))
                fields.Add("cancel_date", CDate(dr("cancel_date").ToString).ToString("yyyy-MM-dd"))
                fields.Add("replaced", IIf(dr("replaced"), "1", "0"))
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                If dr("check_id").ToString.Contains("tmp_") Then
                    dr("check_id") = ""
                End If
                If dr("check_id").ToString = "" Then
                    If dr("deleted").ToString = "False" Then
                        'qry = genInsert("trans_checks", fields)
                        qry = ATGenerateQuery("Insert", "trans_checks", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("check_id").ToString, "check_id")
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        'qry = String.Format("DELETE FROM trans_checks WHERE check_id = {0}", dr("check_id").ToString)
                        qry = ATGenerateQuery("Remove", "trans_checks", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("check_id").ToString & "|", "check_id")
                    Else
                        'qry = genUpdate("trans_checks", fields)
                        qry = ATGenerateQuery("Update", "trans_checks", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("check_id").ToString, "check_id")
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
                fields.Add("fixed_asset_id", dr("fixed_asset_id").ToString)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id").ToString))
                fields.Add("description", dr("description").ToString)
                fields.Add("asset_code", dr("asset_code").ToString)
                fields.Add("date_acquired", CDate(dr("date_acquired").ToString).ToString("yyyy-MM-dd"))
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
                If dr("ref_fixed_asset_id").ToString = "" Then
                    amount_based = dr("amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    debit_based = dr("debit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    credit_based = dr("credit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                Else
                    amount_based = dr("amount_based").ToString
                    debit_based = dr("debit_based").ToString
                    credit_based = dr("credit_based").ToString
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("useful_life", dr("useful_life").ToString)
                fields.Add("date_start", CDate(dr("date_start").ToString).ToString("yyyy-MM-dd"))
                fields.Add("ref_fixed_asset_id", If(dr("ref_fixed_asset_id").ToString = "", Nothing, dr("ref_fixed_asset_id").ToString))
                If dr("fixed_asset_id").ToString.Contains("tmp_") Then
                    dr("fixed_asset_id") = ""
                End If
                If dr("fixed_asset_id").ToString = "" Then
                    If dr("deleted").ToString = "False" Then
                        'qry = genInsert("trans_fixed_asset", fields)
                        qry = ATGenerateQuery("Insert", "trans_fixed_asset", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("fixed_asset_id").ToString, "fixed_asset_id")
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        'qry = String.Format("DELETE FROM trans_fixed_asset WHERE fixed_asset_id = {0}", dr("fixed_asset_id").ToString)
                        qry = ATGenerateQuery("Remove", "trans_fixed_asset", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("fixed_asset_id").ToString & "|", "fixed_asset_id")
                    Else
                        'qry = genUpdate("trans_fixed_asset", fields)
                        qry = ATGenerateQuery("Update", "trans_fixed_asset", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("fixed_asset_id").ToString, "fixed_asset_id")
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
                fields.Add("input_vat_id", dr("input_vat_id").ToString)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id").ToString))
                fields.Add("general_id", dr("general_id").ToString)
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
                If dr("ref_input_vat_id").ToString = "" Then
                    gross_amount_based = dr("gross_amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    vat_amount_based = dr("vat_amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    net_amount_based = dr("net_amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    debit_based = dr("debit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    credit_amount_based = dr("credit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                Else
                    gross_amount_based = dr("gross_amount_based").ToString
                    vat_amount_based = dr("vat_amount_based").ToString
                    net_amount_based = dr("net_amount_based").ToString
                    debit_based = dr("debit_based").ToString
                    credit_amount_based = dr("credit_amount_based").ToString
                End If
                fields.Add("gross_amount_based", gross_amount_based.ToString)
                fields.Add("vat_amount_based", vat_amount_based.ToString)
                fields.Add("net_amount_based", net_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_amount_based", credit_amount_based.ToString)
                fields.Add("ref_input_vat_id", If(dr("ref_input_vat_id").ToString = "", Nothing, dr("ref_input_vat_id").ToString))
                If dr("input_vat_id").ToString.Contains("tmp_") Then
                    dr("input_vat_id") = ""
                End If
                If dr("input_vat_id").ToString = "" Then
                    If dr("deleted").ToString = "False" Then
                        'qry = genInsert("trans_input_vat", fields)
                        qry = ATGenerateQuery("Insert", "trans_input_vat", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("input_vat_id").ToString, "input_vat_id")
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        'qry = String.Format("DELETE FROM trans_input_vat WHERE input_vat_id = {0}", dr("input_vat_id").ToString)
                        qry = ATGenerateQuery("Remove", "trans_input_vat", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("input_vat_id").ToString & "|", "input_vat_id")
                    Else
                        'qry = genUpdate("trans_input_vat", fields)
                        qry = ATGenerateQuery("Update", "trans_input_vat", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("input_vat_id").ToString, "input_vat_id")
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
                fields.Add("output_vat_id", dr("output_vat_id").ToString)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id").ToString))
                fields.Add("general_id", dr("general_id").ToString)
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
                If dr("ref_output_vat_id").ToString = "" Then
                    gross_amount_based = dr("gross_amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    vat_amount_based = dr("vat_amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    net_amount_based = dr("net_amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    debit_based = dr("debit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    credit_based = dr("credit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                Else
                    gross_amount_based = dr("gross_amount_based").ToString
                    vat_amount_based = dr("vat_amount_based").ToString
                    net_amount_based = dr("net_amount_based").ToString
                    debit_based = dr("debit_based").ToString
                    credit_based = dr("credit_based").ToString
                End If
                fields.Add("gross_amount_based", gross_amount_based.ToString)
                fields.Add("vat_amount_based", vat_amount_based.ToString)
                fields.Add("net_amount_based", net_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("ref_output_vat_id", If(dr("ref_output_vat_id").ToString = "", Nothing, dr("ref_output_vat_id").ToString))
                If dr("output_vat_id").ToString.Contains("tmp_") Then
                    dr("output_vat_id") = ""
                End If
                If dr("output_vat_id").ToString = "" Then
                    If dr("deleted").ToString = "False" Then
                        'qry = genInsert("trans_output_vat", fields)
                        qry = ATGenerateQuery("Insert", "trans_output_vat", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("output_vat_id").ToString, "output_vat_id")
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        'qry = String.Format("DELETE FROM trans_output_vat WHERE output_vat_id = {0}", dr("output_vat_id").ToString)
                        qry = ATGenerateQuery("Remove", "trans_output_vat", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("output_vat_id").ToString & "|", "output_vat_id")
                    Else
                        'qry = genUpdate("trans_output_vat", fields)
                        qry = ATGenerateQuery("Update", "trans_output_vat", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("output_vat_id").ToString, "output_vat_id")
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
                fields.Add("prepaid_id", dr("prepaid_id").ToString)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id").ToString))
                fields.Remove("description")
                fields.Add("description", dr("description").ToString)
                fields.Remove("date_acquired")
                fields.Add("date_acquired", CDate(dr("date_acquired").ToString).ToString("yyyy-MM-dd"))
                fields.Add("amount", dr("amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                fields.Add("currency_id", dr("currency_id").ToString)
                fields.Add("exchange_rate", dr("exchange_rate").ToString)
                fields.Add("based_rate", dr("based_rate").ToString)
                Dim amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_prepaid_id").ToString = "" Then
                    amount_based = dr("amount") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    debit_based = dr("debit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    credit_based = dr("credit") * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                Else
                    amount_based = dr("amount_based").ToString
                    debit_based = dr("debit_based").ToString
                    credit_based = dr("credit_based").ToString
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("useful_life", dr("useful_life").ToString)
                fields.Add("date_start", CDate(dr("date_start").ToString).ToString("yyyy-MM-dd"))
                fields.Add("ref_prepaid_id", If(dr("ref_prepaid_id").ToString = "", Nothing, dr("ref_prepaid_id").ToString))
                If dr("prepaid_id").ToString.Contains("tmp_") Then
                    dr("prepaid_id") = ""
                End If
                If dr("prepaid_id").ToString = "" Then
                    If dr("deleted").ToString = "False" Then
                        'qry = genInsert("trans_prepaid", fields)
                        qry = ATGenerateQuery("Insert", "trans_prepaid", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("prepaid_id").ToString, "prepaid_id")
                    End If
                Else
                    If dr("deleted").ToString = "True" Then
                        'qry = String.Format("DELETE FROM trans_prepaid WHERE prepaid_id = {0}", dr("prepaid_id").ToString)
                        qry = ATGenerateQuery("Remove", "trans_prepaid", Nothing, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("prepaid_id").ToString & "|", "prepaid_id")
                    Else
                        'qry = genUpdate("trans_prepaid", fields)
                        qry = ATGenerateQuery("Update", "trans_prepaid", fields, Environment.MachineName, Environment.UserName, main.log_id, dr.Item("prepaid_id").ToString, "prepaid_id")
                    End If
                End If
                If qry <> "" Then
                    dt = Query(qry)
                End If
            Next
        End If
        disable_control()
        loadLastTransaction()
        transMode = ""
        transmodedet = ""
        If addsave Then
            saveAddAnother(btnAdd)
        End If
    End Sub
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control()
        transMode = ""
        transmodedet = ""
        loadLastTransaction()
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmodedet = "insert"
        entryValidated = False
        enable_control_det()
        NewControls.clearControl(det)
        txt_tmp_jbooks_id.Text = "tmp_" & Now.ToString("yyyyMMddHHmmss")
        'If txt_line_remarks.Visible Then
        '    txt_line_remarks.Focus()
        'ElseIf txt_currency_id_det.Visible Then
        '    txt_currency_id_det.Focus()
        '    'ElseIf txt_allocation_id.Visible Then
        '    '    txt_allocation_id.Focus()
        'Else
        'End If
        txt_account_id.Focus()
        txt_currency_id_det.Value = txt_currency_id.Value
        txt_currency_id_det.Text = txt_currency_name.Text
        txtExchangeRateDet.EditValue = txtExchangeRate.EditValue
        txtBasedRateDet.EditValue = txtBasedRate.EditValue
        txt_currency_id_det.RowData = txt_currency_id.RowData
        txt_general_id_det.Value = txt_general_id.Value
        txt_general_id_det.Text = txt_general_id.Text
        txt_general_name_det.Text = txt_general_name.Text
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txt_account_id.Focus()
        Dim selectedRows = dgjbooks.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value > 0 Then
                If "456789".Contains(selectedRow.Cells("validation").Value.ToString) Then
                    enable_control_det()
                    txt_account_id.Focus()
                    btnOK.Focus()
                    entryValidated = False
                    EntryValidate.NewValidateEntry(Me, dgjbooks, ds, True, , , BookID)
                    btnOK.PerformClick()
                    Exit Sub
                End If
                If "23".Contains(selectedRow.Cells("validation").Value.ToString) Then
                    If selectedRow.Cells("offset").Value = 2 Then
                        MsgBox("Unable to Edit.")
                        Exit Sub
                    End If
                    enable_control_det()
                    If txtDebit.EditValue = 0 And txtCredit.EditValue = 0 Then
                        transmodedet = "update"
                        txt_account_id.Focus()
                    ElseIf txtDebit.EditValue <> 0 Then
                        txt_currency_id.Enabled = True
                        txt_account_id.Enabled = True
                        txtDebit.Enabled = True
                    Else
                        txt_currency_id.Enabled = True
                        txt_account_id.Enabled = True
                        txtCredit.Enabled = True
                    End If
                End If
            Else
                enable_control_det()
                If txtDebit.EditValue = 0 And txtCredit.EditValue = 0 Then
                    transmodedet = "update"
                    txt_account_id.Focus()
                ElseIf txtDebit.EditValue <> 0 Then
                    txt_currency_id.Enabled = True
                    txt_account_id.Enabled = True
                    txtDebit.Enabled = True
                Else
                    txt_currency_id.Enabled = True
                    txt_account_id.Enabled = True
                    txtCredit.Enabled = True
                End If
            End If
        Else
            MsgBox("No Record Selected")
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'toggleDelete(dgjbooks, "jbooks_id_tmp", "account_name", "sel", ds)
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
            If arr_id.Contains(dr.Item("jbooks_id")) Or arr_id.Contains(dr.Item("jbooks_id_tmp")) Then
                If Not dr.Item("jbooks_id").ToString.Contains("tmp_") Or Not dr.Item("jbooks_id_tmp").ToString.Contains("tmp_") Then
                    dr.Item("deleted") = True
                Else
                    dt.Rows.Remove(dr)
                End If
            Else
                If Not dr.Item("deleted") Then
                    newDt.ImportRow(dr)
                End If
            End If
        Next
        'dgjbooks.DataSource = newDt
        For Each dr As DataRow In dt.Rows
            If arr_id.Contains(dr.Item("jbooks_id")) Or arr_id.Contains(dr.Item("jbooks_id_tmp")) Then
                dr.Item("deleted") = True
            End If
        Next
        loadDTToDG(dgjbooks, dt)
        computeTotal()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If (txtDebit.EditValue = 0 And txtCredit.EditValue = 0) And (txtDebitBased.EditValue = 0 And txtCreditBased.EditValue = 0) Then
            MsgBox("Debit/Credit is Zero")
            Exit Sub
        End If

        Dim tmp_pk As String = "0"
        Dim dg As DataGridView = dgjbooks
        Dim pk_name As String = "jbooks_id_tmp"
        Dim dr As DataRow = Nothing
        Dim sel As String = ""
        txtDebit.Enabled = False
        txtCredit.Enabled = False
        Dim v As Integer = If(txt_account_id.RowData Is Nothing, txt_validation.Text, txt_account_id.RowData("validation"))
        Dim noCompute As Boolean = If(txt_account_id.RowData Is Nothing, txt_noCompute.Checked, txt_account_id.RowData("noCompute"))
        Dim flag As Boolean = False
        If "456789".Contains(v.ToString) Then
            If Not entryValidated Then
                EntryValidate.NewValidateEntry(Me, dgjbooks, ds, True, , , BookID)
                flag = True
            End If
            'If "268".Contains(v.ToString) Then
            '    If CDec(ifNull(txtDebit.EditValue, 0)) = 0 Then
            '    End If
            'Else
            '    If CDec(ifNull(txtCredit.EditValue, 0)) = 0 Then
            '        If Not entryValidated Then
            '            EntryValidate.NewValidateEntry(Me, dgjbooks, ds, True, , , BookID)
            '        End If
            '    End If
            'End If
        Else
            If v = "2" And txtCredit.EditValue <> 0 Then
                EntryValidate.NewValidateEntry(Me, dgjbooks, ds, True, , , BookID)
                flag = True
            ElseIf v = "3" And txtDebit.EditValue <> 0 Then
                EntryValidate.NewValidateEntry(Me, dgjbooks, ds, True, , , BookID)
                flag = True
            End If
        End If

        Dim selectedRows = dgjbooks.SelectedRows
        If ds.Tables("jbooks").Select("jbooks_id = '" & txt_tmp_jbooks_id.Text & "'").Length > 0 Then
            For Each row As DataGridViewRow In dgjbooks.Rows
                If row.Cells("jbooks_id_tmp").Value.ToString = txt_tmp_jbooks_id.Text Then
                    row.Selected = True
                End If
            Next
        End If
        selectedRows = dgjbooks.SelectedRows
        If transmodedet = "insert" And ds.Tables("jbooks").Select("jbooks_id = '" & txt_tmp_jbooks_id.Text & "'").Length = 0 Then
            dr = ds.Tables("jbooks").NewRow
            dr("jbooks_id") = ""
            dr("jbooks_id_tmp") = txt_tmp_jbooks_id.Text
        Else
            transmodedet = "update"
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("validation").Value = "2" Then 'debit,ar
                If txtDebit.EditValue < selectedRow.Cells("minimum").Value Then
                    MsgBox("Unable to Save. Debit is lower than the expected value.")
                    Exit Sub
                End If
            End If
            If selectedRow.Cells("validation").Value = "3" Then 'credit,ap
                If txtCredit.EditValue < selectedRow.Cells("minimum").Value Then
                    MsgBox("Unable to Save. Credit is lower than the expected value.")
                    Exit Sub
                End If
            End If
            sel = dgjbooks.SelectedRows(0).Cells("jbooks_id_tmp").Value.ToString
            dr = ds.Tables("jbooks").Select("jbooks_id_tmp = '" & sel & "'")(0)
        End If
        tmp_pk = dr("jbooks_id_tmp").ToString
        dr("currency_id") = txt_currency_id_det.Value
        dr("currency_name") = txt_currency_id_det.Text
        dr("exchange_rate") = txtExchangeRateDet.EditValue
        dr("based_rate") = txtBasedRateDet.EditValue
        dr("line_remarks") = txt_line_remarks.Text
        dr("project_id") = txt_project_id.Value
        Dim proj_code As String = ""
        If Not txt_project_id.RowData Is Nothing Then proj_code = txt_project_id.RowData("project_code")
        dr("project_code") = proj_code
        dr("project_name") = txt_project_id.Text
        dr("department_id") = txt_department_id.Value
        Dim dept_code As String = ""
        If Not txt_department_id.RowData Is Nothing Then dept_code = txt_department_id.RowData("department_code")
        dr("department_code") = dept_code
        dr("department_name") = txt_department_id.Text
        dr("account_id") = txt_account_id.Value
        dr("account_code") = txt_account_id.Text
        dr("account_name") = txt_account_name.Text
        dr("debit") = txtDebit.EditValue
        dr("credit") = txtCredit.EditValue
        dr("debit_based") = txtDebitBased.EditValue
        dr("credit_based") = txtCreditBased.EditValue
        If "23".Contains(v.ToString) Then
            dr("general_id") = txt_general_id_det.Value
            dr("general_code") = txt_general_id_det.Text
            dr("general_name") = txt_general_name_det.Text
        Else
            dr("general_id") = ""
            dr("general_code") = ""
            dr("general_name") = ""
        End If
        dr("ref_jbooks_id") = txt_ref_jbooks_id.Value
        dr("ref_trans_no") = txt_ref_jbooks_id.Text
        dr("ref_book_id") = txt_ref_book_code.Value
        dr("ref_book_code") = txt_ref_book_code.Text
        dr("ref_journal_id") = txt_ref_journal_code.Value
        dr("ref_journal_code") = txt_ref_journal_code.Text

        Dim unit_applicable As Boolean = CBool(ifNull(txt_account_id.RowData("unit_applicable"), 0))
        Dim book_unit_no_RowData As DataRow = txt_book_unit_no_id.RowData
        Dim book_unit_no_code As String = ""
        If book_unit_no_RowData IsNot Nothing Then
            book_unit_no_code = ifNull(book_unit_no_RowData.Item("book_unit_no_code"), "").ToString
        End If
        dr("unit_applicable") = If(unit_applicable, 1, 0)
        dr("book_unit_no_id") = txt_book_unit_no_id.Value
        dr("book_unit_no_name") = txt_book_unit_no_id.Text
        dr("book_unit_no_code") = book_unit_no_code
        Dim project_unit_no_RowData As DataRow = txt_project_unit_no_id.RowData
        Dim project_unit_no_code As String = ""
        If project_unit_no_RowData IsNot Nothing Then
            project_unit_no_code = ifNull(project_unit_no_RowData.Item("project_unit_no_codes"), "").ToString
        End If
        dr("project_unit_no_id") = txt_project_unit_no_id.Value
        dr("project_unit_no_names") = txt_project_unit_no_id.Text
        dr("project_unit_no_codes") = project_unit_no_code
        dr("validation") = v
        dr("noCompute") = noCompute
        If v = "2" Or v = "3" Then
            dr("terms_id") = txt_terms_id_det.Value
            dr("terms_name") = txt_terms_id_det.Text
            dr("nodays") = txt_nodays_det.DecimalValue
            If txt_general_id_det.Value.ToString = "" Then
                MsgBox("Gen.Ref is Required")
                txt_general_id_det.Focus()
                Exit Sub
            End If
        End If
        dr("dc") = IIf(txtDebit.EditValue <> 0, 1, 2)
        If (txtCredit.EditValue = 0 And txtDebit.EditValue = 0) Or (txtDebitBased.EditValue = 0 And txtCreditBased.EditValue = 0) Then
            Dim tmp_table As String = ""
            Select Case txt_account_id.RowData.Item("validation").ToString
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
                If txtDebitBased.EditValue = 0 And txtCreditBased.EditValue = 0 Then
                    row.Item("deleted") = True
                    dr("deleted") = True
                Else
                    If txt_account_id.RowData.Item("validation").ToString = "10" Then
                        row.Item("deleted") = False
                        dr("deleted") = False
                    Else
                        row.Item("deleted") = True
                        dr("deleted") = True
                    End If
                End If
            Next
            'dr("deleted") = True
            'Dim err = MsgBox("The Value of Debit and Credit is Zero, Delete the JBooks?", MsgBoxStyle.YesNo, "Delete JBooks?")
            'If err = vbYes Then
            'End If
        End If
        If v <> "2" And v <> "3" Then
            If transmodedet = "insert" And ds.Tables("jbooks").Select("jbooks_id = '" & txt_tmp_jbooks_id.Text & "'").Length = 0 Then
                If txtDebitBased.EditValue = 0 And txtCreditBased.EditValue = 0 Then
                Else
                    ds.Tables("jbooks").Rows.Add(dr)
                End If
            End If
        Else
            If transmodedet = "insert" Then
                Dim filter As String = String.Format("account_id = '{0}' AND project_id = '{1}' AND department_id = '{2}' AND allocation_id = '{3}' AND general_id = '{4}' AND book_unit_no_id = '{5}' AND line_remarks = '{6}' AND deleted = 'False'",
                                                                     dr.Item("account_id").ToString, dr.Item("project_id").ToString, dr.Item("department_id").ToString, dr.Item("allocation_id").ToString, dr.Item("general_id").ToString, dr.Item("book_unit_no_id").ToString, dr.Item("line_remarks").ToString.Replace("'", "''"))
                If CDec(txtDebit.EditValue) > 0 Then
                    filter &= String.Format(" AND debit_based > 0")
                Else
                    filter &= String.Format(" AND credit_based > 0")
                End If
                Dim foundRows = ds.Tables("jbooks").Select(filter)
                If foundRows.Length > 0 Then
                    'If recordExist(dgjbooks, {"account_id", txt_account_id.Value}, {"debit", "credit"}, {txtDebit.EditValue, txtCredit.EditValue}) Then
                    MsgBox("Unable to add existing record.")
                Else
                    If Not flag Then
                        ds.Tables("jbooks").Rows.Add(dr)
                    End If
                End If
            Else
                Dim filter As String = String.Format("jbooks_id_tmp <> '{7}' AND account_id = '{0}' AND project_id = '{1}' AND department_id = '{2}' AND allocation_id = '{3}' AND general_id = '{4}' AND book_unit_no_id = '{5}' AND line_remarks = '{6}' AND deleted = 'False'",
                                                                     dr.Item("account_id").ToString, dr.Item("project_id").ToString, dr.Item("department_id").ToString, dr.Item("allocation_id").ToString, dr.Item("general_id").ToString, dr.Item("book_unit_no_id").ToString, dr.Item("line_remarks").ToString.Replace("'", "''"), dr.Item("jbooks_id_tmp").ToString)
                If CDec(txtDebit.EditValue) > 0 Then
                    filter &= String.Format(" AND debit_based > 0")
                Else
                    filter &= String.Format(" AND credit_based > 0")
                End If
                Dim foundRows = ds.Tables("jbooks").Select(filter)
                If foundRows.Length > 0 Then
                    'If recordExist(dgjbooks, {"account_id", txt_account_id.Value}, {"debit", "credit"}, {txtDebit.EditValue, txtCredit.EditValue}) Then
                    MsgBox("Unable to add existing record.")
                Else
                    Try
                        If Not flag Then
                            ds.Tables("jbooks").Rows.Add(dr)
                        End If
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
        computeTotal()
        If v.ToString = "2" Then
            If ds.Tables("jbooks").Select("validation = '2'").Count > 0 Then
                Dim tmp_debit = ds.Tables("jbooks").Compute("sum(debit)", "validation = '2' AND deleted = 'False' AND noCompute = 'False'")
                txtAmount.EditValue = If(tmp_debit.ToString = "", 0, tmp_debit)
                txtAmountBased.EditValue = txtAmount.EditValue * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                If CDec(txtAmountBased.EditValue) < 0 Then
                    txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(txtAmountBased.EditValue), main.DecimalPlaces)
                ElseIf CDec(txtAmountBased.EditValue) > 0 Then
                    txt_amount_in_word.Text = amount_words(txtAmountBased.EditValue, main.DecimalPlaces)
                Else
                    txt_amount_in_word.Text = ""
                End If
            End If
        End If
        Dim dt As DataTable = ds.Tables("jbooks")
        'Dim newDt As New DataTable("tmp_jbooks")
        'For Each col As DataColumn In dt.Columns
        '    Dim newCol As New DataColumn
        '    newCol.ColumnName = col.ColumnName
        '    newCol.DataType = col.DataType
        '    newDt.Columns.Add(newCol)
        'Next
        'For Each row As DataRow In dt.Rows
        '    If Not row.Item("deleted") Then
        '        newDt.ImportRow(row)
        '    End If
        'Next
        ''dgjbooks.DataSource = newDt
        loadDTToDG(dgjbooks, dt)
        'emon - 2017-07-18
        Dim tmp_table_name As String = ""
        Select Case v.ToString
            Case "4"
                tmp_table_name = "ewt"
            Case "5"
                tmp_table_name = "final_tax"
            Case "7"
                tmp_table_name = "output_vat"
            Case "1"
                tmp_table_name = "checks"
            Case "6"
                tmp_table_name = "input_vat"
            Case "8"
                tmp_table_name = "prepaid"
            Case "9"
                tmp_table_name = "fixed_asset"
        End Select
        If "457".Contains(v.ToString) Then
            If dr.Item("debit") > 0 Then ' if debit then set deleted to true
                Dim rows = ds.Tables(tmp_table_name).Select(String.Format("jbooks_id = '{0}'", dr.Item("jbooks_id").ToString))
                If rows.Length > 0 Then
                    For Each row In rows
                        If row.Item("debit") = 0 Then
                            row.Item("deleted") = True
                            ds.Tables(tmp_table_name).AcceptChanges()
                        End If
                    Next
                End If
            End If
        End If
        If "689".Contains(v.ToString) Then
            If dr.Item("credit") > 0 Then ' if credit then set deleted to true
                Dim rows = ds.Tables(tmp_table_name).Select(String.Format("jbooks_id = '{0}'", dr.Item("jbooks_id").ToString))
                If rows.Length > 0 Then
                    For Each row In rows
                        If row.Item("credit") = 0 Then
                            row.Item("deleted") = True
                            ds.Tables(tmp_table_name).AcceptChanges()
                        End If
                    Next
                End If
            End If
        End If
        'end - 2017-07-18
        entryValidated = False
        disable_control_det()
        btnInsert.Focus()
        transmodedet = ""
        gridRowFocus(dgjbooks, {pk_name, tmp_pk})
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        disable_control_det()
        transmodedet = ""
    End Sub
    Private Sub txt_currency_id_Leave(sender As Object, e As EventArgs) Handles txt_currency_id.Leave
        If txt_currency_id.RowData IsNot Nothing Then
            Dim dr = txt_currency_id.RowData
            txt_currency_id.RowData = dr
            txt_currency_id.Value = dr.Item("currency_id")
            txt_currency_id.Text = dr.Item("currency_name")
            txtExchangeRate.EditValue = dr.Item("exchange_rate")
            txtBasedRate.EditValue = dr.Item("based_rate")
            txt_currency_id_det.RowData = dr
            txt_currency_id_det.Value = dr.Item("currency_id")
            txt_currency_id_det.Text = dr.Item("currency_name")
            txtExchangeRateDet.EditValue = dr.Item("exchange_rate")
            txtBasedRateDet.EditValue = dr.Item("based_rate")
        End If
    End Sub
    Private Sub txt_currency_id_det_Leave(sender As Object, e As EventArgs) Handles txt_currency_id_det.Leave
        If txt_currency_id.RowData IsNot Nothing Then
            Dim dr = txt_currency_id_det.RowData
            txtExchangeRateDet.EditValue = dr.Item("exchange_rate")
            txtBasedRateDet.EditValue = dr.Item("based_rate")
        End If
    End Sub
    Private Sub txt_account_id_Leave(sender As Object, e As EventArgs) Handles txt_account_id.Leave
        If txt_account_id.RowData IsNot Nothing Then
            tmpRowData = txt_account_id.RowData
            Dim dr = txt_account_id.RowData
            If Not dr Is Nothing Then
                Dim validate As Integer = dr("validation")

                Dim unit_applicable As Boolean = CBool(ifNull(dr.Item("unit_applicable"), 0))

                If unit_applicable Then
                    If My.Settings._enableUnitNo Then
                        If My.Settings._enableBookUnit Then
                            lblUnitNo.Visible = True
                            lblUnitNo.Text = "Book Unit"
                            txt_book_unit_no_id.Visible = True
                            If txt_currency_id_det.Visible Then
                                txt_currency_id_det.Focus()
                            ElseIf txt_line_remarks.Visible Then
                                txt_line_remarks.Focus()
                            ElseIf txt_project_id.Visible Then
                                txt_project_id.Focus()
                            ElseIf txt_department_id.Visible Then
                                txt_department_id.Focus()
                            Else
                                txt_book_unit_no_id.Focus()
                            End If
                            txt_project_unit_no_id.Visible = False
                        Else
                            lblUnitNo.Visible = True
                            lblUnitNo.Text = "Project Unit"
                            lblUnitNo.Visible = True
                            txt_project_unit_no_id.Visible = True
                            If txt_currency_id_det.Visible Then
                                txt_currency_id_det.Focus()
                            ElseIf txt_line_remarks.Visible Then
                                txt_line_remarks.Focus()
                            ElseIf txt_project_id.Visible Then
                                txt_project_id.Focus()
                            ElseIf txt_department_id.Visible Then
                                txt_department_id.Focus()
                            Else
                                txt_project_unit_no_id.Focus()
                            End If
                            txt_book_unit_no_id.Visible = False
                        End If
                    End If
                Else
                    txt_book_unit_no_id.RowData = Nothing
                    txt_book_unit_no_id.Value = ""
                    txt_book_unit_no_id.Text = ""
                    txt_book_unit_no_id.Visible = False
                    txt_project_unit_no_id.Visible = False
                    lblUnitNo.Visible = False
                End If

                If validate = 10 Then
                    txtDebit.Enabled = False
                    txtCredit.Enabled = False
                    txtDebitBased.Enabled = True
                    txtCreditBased.Enabled = True
                    txt_ref_jbooks_id.Enabled = False
                Else
                    txtDebitBased.Enabled = False
                    txtCreditBased.Enabled = False
                    If transmodedet = "insert" Then
                        If "123".IndexOf(validate.ToString) >= 0 Then
                            txt_general_id_det.Value = txt_general_id.Value
                            txt_general_id_det.Text = txt_general_id.Text
                            txt_general_name_det.Text = txt_general_name.Text
                        Else
                            txt_general_id_det.Value = ""
                            txt_general_id_det.Text = ""
                            txt_general_name_det.Text = ""
                        End If
                    End If
                End If
                If "23".IndexOf(validate.ToString) < 0 Then
                    txt_general_id_det.Enabled = False
                    lbltermsdet.Visible = False
                    txt_terms_id_det.Visible = False
                    txt_nodays_det.Visible = False
                    txt_terms_id_det.Value = ""
                    txt_terms_id_det.Text = ""
                    txt_nodays_det.DecimalValue = 0
                Else
                    txt_general_id_det.Enabled = True
                    lbltermsdet.Visible = True
                    txt_terms_id_det.Visible = True
                    txt_nodays_det.Visible = True
                    If transmodedet = "insert" Then
                        txt_terms_id_det.Value = txt_terms_id.Value
                        txt_terms_id_det.Text = txt_terms_id.Text
                        txt_nodays_det.DecimalValue = txt_nodays.DecimalValue
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txt_terms_id_det_Leave(sender As Object, e As EventArgs) Handles txt_terms_id_det.Leave
        Dim dr = txt_terms_id_det.RowData
        If dr IsNot Nothing Then
            If Not dr Is Nothing Then
                If dr("fixed_day") = 0 Then
                    txt_nodays_det.Enabled = True
                    txt_nodays_det.Focus()
                Else
                    txt_nodays_det.Enabled = False
                    btnOK.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub txtdebit_Leave(sender As Object, e As EventArgs) Handles txtDebit.Leave
        If txtDebit.Enabled Then
            Dim v As Integer = 0
            Dim flag As Boolean = False
            Dim tmp_rowData = txt_account_id.RowData
            If txtDebit.EditValue <> 0 Then
                txtCredit.EditValue = 0.0
                txtCreditBased.EditValue = 0.0
                txtDebitBased.EditValue = txtDebit.EditValue * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue)
                If Not txt_account_id.RowData Is Nothing Then
                    v = txt_account_id.RowData("validation")
                    If "2310".IndexOf(v.ToString) < 0 Then
                        entryValidated = False
                        NewValidateEntry(Me, dgjbooks, ds, False, , , BookID)
                    End If
                End If
            Else
                If Not txt_account_id.RowData Is Nothing Then
                    v = txt_account_id.RowData("validation")
                    If v = 9 Then
                        txtCredit.EditValue = 1
                        txtCreditBased.EditValue = 1
                        entryValidated = False
                        NewValidateEntry(Me, dgjbooks, ds, False, , , BookID)
                    End If
                End If
            End If
            If tmp_rowData IsNot Nothing Then
                txt_account_id.Value = tmp_rowData.Item("account_id")
                txt_account_id.Text = tmp_rowData.Item("account_code")
                txt_account_name.Text = tmp_rowData.Item("account_name")
                txt_account_id.RowData = tmp_rowData
            End If
            If v <> 3 Then
                txt_ref_jbooks_id.Enabled = False
                txt_ref_jbooks_id.Value = ""
                txt_ref_jbooks_id.Text = ""
                If v = 2 Then
                    txt_terms_id_det.Enabled = True
                End If
            Else
                txt_ref_jbooks_id.Enabled = True
                'txt_debit.Enabled = False
                txt_terms_id_det.Enabled = False
                txt_nodays_det.Enabled = False
                txtCredit.Focus()
            End If
            If "456789".IndexOf(v.ToString) >= 0 And (txtDebit.EditValue <> 0 Or txtCredit.EditValue <> 0) Then
                If txtDebit.EditValue > 0 Or txtCredit.EditValue > 0 Then
                    btnOK_Click(Nothing, Nothing)
                End If
            End If
        End If
    End Sub
    Private Sub txtdebitbased_Leave(sender As Object, e As EventArgs) Handles txtDebitBased.Leave
        If txtDebitBased.EditValue <> 0 Then
            txtCreditBased.EditValue = 0.0
        End If
    End Sub
    Private Sub txtcredit_Leave(sender As Object, e As EventArgs) Handles txtCredit.Leave
        If txtCredit.Enabled Then
            Dim v As Integer = 0
            Dim flag As Boolean = False
            Dim tmp_rowData = txt_account_id.RowData
            If txtCredit.EditValue <> 0 Then
                txtDebit.EditValue = 0.0
                txtDebitBased.EditValue = 0.0
                txtCreditBased.EditValue = txtCredit.EditValue * (txtExchangeRateDet.EditValue / txtBasedRateDet.EditValue)
                If Not txt_account_id.RowData Is Nothing Then
                    v = txt_account_id.RowData("validation")
                    If "2310".IndexOf(v.ToString) < 0 Then
                        entryValidated = False
                        NewValidateEntry(Me, dgjbooks, ds, False, , , BookID)
                    End If
                End If
            End If
            If Not txt_account_id.RowData Is Nothing Then
                v = txt_account_id.RowData("validation")
            End If
            If tmp_rowData IsNot Nothing Then
                txt_account_id.Value = tmp_rowData.Item("account_id")
                txt_account_id.Text = tmp_rowData.Item("account_code")
                txt_account_name.Text = tmp_rowData.Item("account_name")
                txt_account_id.RowData = tmp_rowData
            End If
            If v <> 2 Then
                'txtCreditBased.EditValue = txtCredit.EditValue * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                txt_ref_jbooks_id.Enabled = False
                txt_ref_jbooks_id.Value = ""
                txt_ref_jbooks_id.Text = ""
                If v = 3 Then
                    If CDec(txtDebit.EditValue) <> 0 Then
                        'offset ap
                        txt_ref_jbooks_id.Enabled = True
                        txt_terms_id_det.Enabled = False
                        txt_general_id_det.Enabled = True
                        txt_general_id_det.Focus()
                        'txt_ref_jbooks_id.Focus()
                    Else
                        'setup ap
                        txt_ref_jbooks_id.Enabled = False
                        txt_terms_id_det.Enabled = True
                        If CDec(txtCredit.EditValue) <> 0 Then
                            txt_general_id_det.Enabled = True
                            txt_general_id_det.Focus()
                        Else
                            txt_general_id_det.Enabled = False
                            btnOK.Focus()
                        End If
                        'txtCredit.Enabled = False
                    End If
                End If
            Else
                If CDec(txtCredit.EditValue) <> 0 Then
                    txt_ref_jbooks_id.Enabled = True
                    'txtCredit.Enabled = False
                    txt_terms_id_det.Enabled = False
                    txt_nodays_det.Enabled = False
                End If
                txt_general_id_det.Focus()
            End If
            If "456789".IndexOf(v.ToString) >= 0 Then
                If txtDebit.EditValue > 0 Or txtCredit.EditValue > 0 Then
                    btnOK_Click(Nothing, Nothing)
                End If
            End If
        End If
    End Sub
    Private Sub txtcreditbased_Leave(sender As Object, e As EventArgs) Handles txtCreditBased.Leave
        If txtCreditBased.EditValue <> 0 Then
            txtDebitBased.EditValue = 0.0
        End If
    End Sub
    Private Sub txtdnref_Leave(sender As Object, e As EventArgs) Handles txt_ref_jbooks_id.Leave
        If txt_ref_jbooks_id.Enabled Then
            txt_ref_jbooks_id.Enabled = False
            entryValidated = False
            NewValidateEntry(Me, dgjbooks, ds, True, , , BookID)
            Dim v_dr As DataRow = txt_account_id.RowData
            If v_dr Is Nothing Then
                v_dr = tmpRowData
            End If
            Dim v As String = v_dr.Item("validation")
            dgjbooks.DataSource = ds.Tables("jbooks")
            computeTotal()
            If v.ToString = "2" Then
                If ds.Tables("jbooks").Select("validation = '2'").Count > 0 Then
                    Dim tmp_debit = ds.Tables("jbooks").Compute("sum(debit)", "validation = '2' AND deleted = 'False'")
                    txtAmount.EditValue = If(tmp_debit.ToString = "", 0, tmp_debit)
                    txtAmountBased.EditValue = txtAmount.EditValue * (txtExchangeRate.EditValue / txtBasedRate.EditValue)
                    If CDec(txtAmountBased.EditValue) < 0 Then
                        txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(txtAmountBased.EditValue), main.DecimalPlaces)
                    ElseIf CDec(txtAmountBased.EditValue) > 0 Then
                        txt_amount_in_word.Text = amount_words(txtAmountBased.EditValue, main.DecimalPlaces)
                    Else
                        txt_amount_in_word.Text = ""
                    End If
                End If
            End If
            If txtDebit.EditValue = 0 And txtCredit.EditValue = 0 Then
                Exit Sub
            End If
            disable_control_det()
            btnInsert.Focus()
            transmodedet = ""
        End If
    End Sub
    Private Sub txtday_TextChange(sender As Object, e As EventArgs) Handles txt_day.TextChanged
        Dim month As Integer = If(txt_month.Value = "", 0, txt_month.Value)
        Dim year As Integer = If(txt_year.Text = "", 0, txt_year.Text)
        Dim dd As Integer = txt_day.DecimalValue
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
            txt_day.DecimalValue = 1
        ElseIf dd >= max_day Then
            txt_day.DecimalValue = max_day
        End If
        If mySettings IsNot Nothing Then
            Dim min_date = mySettings.minDate
            If month = min_date.Month And year = min_date.Year Then
                If txt_day.DecimalValue < min_date.Day Then
                    txt_day.DecimalValue = min_date.Day
                End If
            End If
        End If
    End Sub
    Private Sub transjb_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Me.Parent IsNot Nothing Then
            Me.Top = (Me.Parent.Height - Me.Height) / 2
            Me.Left = (Me.Parent.Width - Me.Width) / 2
        End If
    End Sub
    Private Sub transjb_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Parent IsNot Nothing Then
            Me.Top = (Me.Parent.Height - Me.Height) / 2
            Me.Left = (Me.Parent.Width - Me.Width) / 2
        End If
    End Sub
    Private Sub dgjbooks_SelectionChanged(sender As Object, e As EventArgs) Handles dgjbooks.SelectionChanged
        bind_control_det()
    End Sub
    Private Sub txtdesc_Leave(sender As Object, e As EventArgs)
        btnInsert.Focus()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim trans_id As String = txt_trans_id.Text
        If trans_id <> "" And trans_id <> "0" Then
            Dim res = MsgBox("Are you sure to cancel this transaction?", MsgBoxStyle.YesNo, "Cancel Transaction")
            If res = MsgBoxResult.Yes Then
                Dim sqlCancel As String = String.Format("CALL cancelTransaction('{0}','{1}')", trans_id, main.log_id)
                Dim dtCancel As DataTable = Query(sqlCancel)
                If dtCancel.Rows.Count > 0 Then
                    If dtCancel.Columns.Contains("noCancel") Then
                        MsgBox("Transaction unable to cancel.")
                    Else
                        loadLastTransaction()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnParticular_Click(sender As Object, e As EventArgs) Handles btnParticular.Click
        trans_particular.TransactionID = txt_trans_id.Text
        trans_particular.Description = txt_description.Text
        trans_particular.TransactionName = "Sales Voucher"
        trans_particular.dsParticular.Tables("trans_header_particular").Clear()
        copyDataTable(trans_particular.dsParticular.Tables("trans_header_particular"), ds.Tables("particular"), "trans_particular_id")
        trans_particular.EnableParticular(Not btnAdd.Visible)
        trans_particular.ShowDialog()
        copyDataTable(ds.Tables("particular"), trans_particular.dsParticular.Tables("trans_header_particular"), "trans_particular_id")
        txt_description.Text = trans_particular.txt_description.Text
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If btnPrevious.Enabled Then
            If myDataTable IsNot Nothing Then
                If myDataTable.Rows.Count > 0 Then
                    btnPrevious.Enabled = False
                    Dim currentIndex As Integer = 0
                    Dim myCurrentRows = myDataTable.Select("trans_id = '" & pkID & "'")
                    If myCurrentRows.Length > 0 Then
                        Dim mycurrentRow = myCurrentRows(0)
                        currentIndex = myDataTable.Rows.IndexOf(mycurrentRow)
                    End If
                    If currentIndex > 0 Then
                        clear_control()
                        NewControls.bindControl(hdr, myDataTable.Rows(currentIndex - 1), True)
                        currentDr = myDataTable.Rows(currentIndex - 1)
                        disable_control(myDataTable.Rows(currentIndex - 1).Item("user_id").ToString = main.user_id, myDataTable.Rows(currentIndex - 1))
                        NewControls.refreshRecordDet(dgjbooks, ds, txt_trans_id)
                        If CDec(txtAmountBased.EditValue) < 0 Then
                            txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(txtAmountBased.EditValue), main.DecimalPlaces)
                        ElseIf CDec(txtAmountBased.EditValue) > 0 Then
                            txt_amount_in_word.Text = amount_words(txtAmountBased.EditValue, main.DecimalPlaces)
                        Else
                            txt_amount_in_word.Text = ""
                        End If
                        computeTotal()
                        pkID = myDataTable.Rows(currentIndex - 1).Item("trans_id")
                    Else
                        MsgBox("No Previous Record Available.")
                    End If
                    btnPrevious.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnNext.Enabled Then
            If myDataTable IsNot Nothing Then
                If myDataTable.Rows.Count > 0 Then
                    btnNext.Enabled = False
                    Dim currentIndex As Integer = 0
                    Dim myCurrentRows = myDataTable.Select("trans_id = '" & pkID & "'")
                    If myCurrentRows.Length > 0 Then
                        Dim mycurrentRow = myCurrentRows(0)
                        currentIndex = myDataTable.Rows.IndexOf(mycurrentRow)
                    End If
                    If currentIndex < myDataTable.Rows.Count - 1 Then
                        clear_control()
                        NewControls.bindControl(hdr, myDataTable.Rows(currentIndex + 1), True)
                        currentDr = myDataTable.Rows(currentIndex + 1)
                        disable_control(myDataTable.Rows(currentIndex + 1).Item("user_id").ToString = main.user_id, myDataTable.Rows(currentIndex + 1))
                        NewControls.refreshRecordDet(dgjbooks, ds, txt_trans_id)
                        If CDec(txtAmountBased.EditValue) < 0 Then
                            txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(txtAmountBased.EditValue), main.DecimalPlaces)
                        ElseIf CDec(txtAmountBased.EditValue) > 0 Then
                            txt_amount_in_word.Text = amount_words(txtAmountBased.EditValue, main.DecimalPlaces)
                        Else
                            txt_amount_in_word.Text = ""
                        End If
                        computeTotal()
                        pkID = myDataTable.Rows(currentIndex + 1).Item("trans_id")
                    Else
                        MsgBox("Last Record.")
                    End If
                    btnNext.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub transactionap_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnAdd)                'F2
        dicShortCut.Add(114, btnEdit)               'F3
        dicShortCut.Add(115, btnCancel)             'F4
        dicShortCut.Add(116, btnPrint)             'F5
        dicShortCut.Add(117, btnSearch)              'F6
        dicShortCut.Add(118, btnPrevious)           'F7
        dicShortCut.Add(119, btnNext)               'F8
        dicShortCut.Add(120, btnSettings)           'F9
        dicShortCut.Add(121, btnExit) 'F10
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn As Button = dicShortCut.Item(e.KeyCode)
            If btn.Enabled And btn.Visible Then
                btn.PerformClick()
                Return
            End If
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub dgjbooks_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgjbooks.CellFormatting
        For Each row As DataGridViewRow In dgjbooks.Rows
            Dim cellColor = Color.Black
            Select Case row.Cells("offset").Value
                Case "0"
                    cellColor = Color.Black
                Case "1"
                    cellColor = Color.Red
                Case "2"
                    cellColor = Color.Green
            End Select
            For Each col As DataGridViewColumn In dgjbooks.Columns
                row.Cells(col.Name).Style.ForeColor = cellColor
            Next
        Next
    End Sub
#End Region


    Private Sub btnViewSchedule_Click(sender As Object, e As EventArgs) Handles btnViewSchedule.Click
        Dim scheduleFound As Boolean = False
        Dim jbooks_id As String = ""
        Dim offset As Integer = 0
        Dim validation As Integer = 0
        If dgjbooks.Rows.Count > 0 Then
            If dgjbooks.SelectedRows.Count > 0 Then
                Dim selectedRow = dgjbooks.SelectedRows(0)
                jbooks_id = selectedRow.Cells("jbooks_id_tmp").Value.ToString
                offset = selectedRow.Cells("offset").Value
                validation = selectedRow.Cells("validation").Value
            End If
        End If
        If jbooks_id <> "" Then
            If offset > 0 Then
                If validation = "2" Or validation = "3" Then
                    Dim dt = New DataTable()
                    Dim conn = generateConnection(_serverDBMain)
                    conn.Open()
                    Using cmd As New MySqlCommand With {.Connection = conn, .CommandType = CommandType.StoredProcedure, .CommandText = "GetJournalOffset"}
                        cmd.Parameters.AddWithValue("@validation", validation)
                        cmd.Parameters.AddWithValue("@jbooks_id", jbooks_id)
                        Dim da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                    conn.Close()
                    If dt.Rows.Count > 0 Then
                        scheduleFound = True
                        'Dim frmOffset As New ViewOffset
                        'frmOffset.dgMain.AutoGenerateColumns = False
                        'frmOffset.dgMain.DataSource = dt
                        'frmOffset.ShowDialog()
                        Dim trans_date = New Date(txt_year.Text, txt_month.Value, txt_day.Text)
                        Dim frmDet As New begbal_det_new
                        frmDet.trans_no = txt_trans_no.Text
                        frmDet.trans_date = trans_date
                        frmDet.general_name = txt_general_name.Text
                        frmDet.line_remarks = txt_line_remarks.Text
                        If validation = "2" Then
                            frmDet.amount = txtDebit.EditValue
                        Else
                            frmDet.amount = txtCredit.EditValue
                        End If
                        frmDet.si_no = ""
                        frmDet.rr_no = ""
                        frmDet.po_no = ""
                        frmDet.jbooks_id = jbooks_id
                        frmDet.ShowDialog()
                    End If
                ElseIf validation = "4" _
                        Or validation = "5" _
                        Or validation = "6" _
                        Or validation = "7" _
                        Or validation = "8" _
                        Or validation = "9" _
                        Then
                    Dim dt = New DataTable()
                    Dim conn = generateConnection(_serverDBMain)
                    conn.Open()
                    Using cmd As New MySqlCommand With {.Connection = conn, .CommandType = CommandType.StoredProcedure, .CommandText = "GetJournalDetail"}
                        cmd.Parameters.AddWithValue("@validation", validation)
                        cmd.Parameters.AddWithValue("@jbooks_id", jbooks_id)
                        Dim da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                    conn.Close()
                    If dt.Rows.Count > 0 Then
                        Select Case validation
                            Case "4"
                                scheduleFound = True
                                Dim frmOffset As New ViewEWT
                                frmOffset.dgMain.AutoGenerateColumns = False
                                frmOffset.dgMain.DataSource = dt
                                frmOffset.ShowDialog()
                            Case "5"
                                scheduleFound = True
                                Dim frmOffset As New ViewFinalTax
                                frmOffset.dgMain.AutoGenerateColumns = False
                                frmOffset.dgMain.DataSource = dt
                                frmOffset.ShowDialog()
                            Case "6"
                                scheduleFound = True
                                Dim frmOffset As New ViewInputVat
                                frmOffset.dgMain.AutoGenerateColumns = False
                                frmOffset.dgMain.DataSource = dt
                                frmOffset.ShowDialog()
                            Case "7"
                                scheduleFound = True
                                Dim frmOffset As New ViewInputVat
                                frmOffset.dgMain.AutoGenerateColumns = False
                                frmOffset.dgMain.DataSource = dt
                                frmOffset.ShowDialog()
                            Case "8"
                                scheduleFound = True
                                Dim frmOffset As New ViewPrepaid
                                frmOffset.dgMain.AutoGenerateColumns = False
                                frmOffset.dgMain.DataSource = dt
                                frmOffset.ShowDialog()
                            Case "9"
                                scheduleFound = True
                                Dim frmOffset As New ViewFixedAsset
                                frmOffset.dgMain.AutoGenerateColumns = False
                                frmOffset.dgMain.DataSource = dt
                                frmOffset.ShowDialog()
                        End Select
                    End If
                End If
            End If
        End If
        If Not scheduleFound Then
            MsgBox("No Schedule Found.")
        End If
    End Sub

    Private Sub det_Paint(sender As Object, e As PaintEventArgs) Handles det.Paint

    End Sub

    Private Sub txt_day_Leave(sender As Object, e As EventArgs) Handles txt_day.Leave
        Dim month As Integer = If(txt_month.Value = "", 0, txt_month.Value)
        Dim year As Integer = If(txt_year.Text = "", 0, txt_year.Text)
        Dim dd As Integer = txt_day.DecimalValue
        Dim d = New Date(year, month, dd)
        Dim today = Date.Today
        If True Then
            If d > today Then
                txt_day.DecimalValue = today.Day
            End If
        End If
    End Sub

    Private Sub txt_trans_no_TextChanged(sender As Object, e As EventArgs) Handles txt_trans_no.Leave
        If txt_trans_no.Enabled Then
            txt_trans_no.Text = txt_trans_no.Text.ToUpper()
            Dim sql As String = String.Format("SELECT * FROM trans_header a WHERE a.trans_no = '{0}'", Trim(txt_trans_no.Text))
            Dim dt As DataTable = Query(sql)
            If dt.Rows.Count > 0 Then
                MsgBox("Transaction No Already Exist.")
            End If
        End If
    End Sub

    Private Sub btnDetailedParticular_Click(sender As Object, e As EventArgs) Handles btnDetailedParticular.Click
        If txt_trans_no.Text = "" Then
            MsgBox("Input your invoice No. first!", vbInformation + vbOKOnly)
        Else

            Dim frm As New invoiceDetailedParticular()

            frm.ds.Tables("trans_project_management_det").Clear()
            For Each dr As DataRow In ds.Tables("project_management").Rows
                frm.ds.Tables("trans_project_management_det").ImportRow(dr)
            Next
            frm.MyParent = Me
            invoiceDetailedParticularDet.arr_general_id = txt_general_id.Value
            frm.ShowDialog()
        End If
    End Sub

    Private Sub transactionib_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_project_id_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave
        If txt_department_id.Visible Then
            txt_department_id.Focus()
        Else
            If txt_project_unit_no_id.Visible Then
                txt_project_unit_no_id.Focus()
            End If
        End If
    End Sub

    Private Sub txt_department_id_Leave(sender As Object, e As EventArgs) Handles txt_department_id.Leave
        If txt_project_unit_no_id.Visible Then
            txt_project_unit_no_id.Focus()
        End If
    End Sub

    Private Sub txt_project_unit_no_id_Leave(sender As Object, e As EventArgs) Handles txt_project_unit_no_id.Leave
        txtDebit.Focus()
    End Sub

    Private Sub txt_allocation_id_Leave(sender As Object, e As EventArgs) Handles txt_allocation_id.Leave
        'txt_account_id.Focus()
    End Sub
End Class