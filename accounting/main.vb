Imports System.Windows.Forms
Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports DevExpress.XtraSplashScreen
Imports System.Drawing
Imports System.Reflection

Public Class main
    Public Shared Journal As New DataTable
    Public Shared Sys_Default As New DataTable
    Public Shared Sys_Default_Det As New DataTable
    Public Shared dicAction As New Dictionary(Of String, Dictionary(Of String, Boolean))
    Public Shared CurrentUsername As String = ""
    Public Shared user_id As String = "0"
    Public Shared log_id As String = "0"
    Public strNumberFormat As String = "#,##0.00"
    Public DecimalPlaces As Integer = 0
    Public Shared listBook As DataTable = Nothing
    Public Shared listMonth As DataTable = Nothing
    Private _dtStage As New DataTable
    Private m_ChildFormNumber As Integer
    Public S001 As String = ""
    Public S002 As String = ""
    Public Shared id As Integer = 0
    Public system_name As String = "Computerized Accounting System"
    Friend Sub generateNumberFormat(ByVal decimalPlaces As Integer)
        strNumberFormat = "#,##0"
        If decimalPlaces > 0 Then
            strNumberFormat &= "."
            For i As Integer = 0 To decimalPlaces - 1
                strNumberFormat &= "0"
            Next
        End If
    End Sub
    Public Property dtStage() As DataTable
        Get
            Return _dtStage
        End Get
        Set(value As DataTable)
            _dtStage.Clear()
            _dtStage.Columns.Clear()
            For Each col As DataColumn In value.Columns
                _dtStage.Columns.Add(col.ColumnName)
            Next
            For Each row As DataRow In value.Rows
                _dtStage.ImportRow(row)
            Next
        End Set
    End Property

    'Public Property SubContract_management As Object

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Public Shared Sub setConnectionSettings()
        connectionlib.connectionlib.vtxtIP = My.Settings._serverIP
        connectionlib.connectionlib._serverDBFS = My.Settings._serverDBFS
        connectionlib.connectionlib._serverDBMain = My.Settings._serverDBMain
        connectionlib.connectionlib._serverUser = My.Settings._serverUser
        connectionlib.connectionlib._serverPass = My.Settings._serverPass
        connectionlib.connectionlib._serverPort = My.Settings._serverPort
        connectionlib.connectionlib.mysqlErrorReport = My.Settings.mysqlError
        connectionlib.connectionlib.setConnectionString()
    End Sub
    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim flag = MsgBox("Are you sure to Exit?", MsgBoxStyle.YesNo, "Exit")
        If flag = MsgBoxResult.No Then
            e.Cancel = True
        End If
        MyDebugging.AddText("----- Accounting Close -----")
    End Sub
    Friend Sub loadCompany()
        Sys_Default = Query(String.Format("SELECT a.*,b.company_code,b.company_name,b.address1,b.address2,b.tin,b.rdo_code " &
            ",a.currency_id,c.currency_code,c.currency_name,c.symbol " &
" FROM sys_default a " &
" LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id" &
" LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id ", _serverDBFS))
        Sys_Default_Det = Query("select a.*,b.module_code from sys_default_det a inner join " & connectionlib.connectionlib._serverDBFS & ".sys_erp_modules b on a.module_id = b.module_id")
        settings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
        DecimalPlaces = Sys_Default.Rows(0).Item("decimal_places")
        generateNumberFormat(Sys_Default.Rows(0).Item("decimal_places"))
        offsetap.initializeDecimalPlaces(strNumberFormat)
        offsetar.initializeDecimalPlaces(strNumberFormat)
        offsetewt.initializeDecimalPlaces(strNumberFormat)
        offsetfinaltax.initializeDecimalPlaces(strNumberFormat)
        offsetfixedasset.initializeDecimalPlaces(strNumberFormat)
        offsetinputvat.initializeDecimalPlaces(strNumberFormat)
        offsetoutputvat.initializeDecimalPlaces(strNumberFormat)
        offsetprepaid.initializeDecimalPlaces(strNumberFormat)
        setupewt.initializeDecimalPlaces(strNumberFormat)
        setupfinaltax.initializeDecimalPlaces(strNumberFormat)
        setupfixedasset.initializeDecimalPlaces(strNumberFormat)
        setupinputvat.initializeDecimalPlaces(strNumberFormat)
        setupoutputvat.initializeDecimalPlaces(strNumberFormat)
        setupprepaid.initializeDecimalPlaces(strNumberFormat)
        cashcv.initializeDecimalPlaces(strNumberFormat)
        cashor.initializeDecimalPlaces(strNumberFormat)
        Dim MyTitlePath = Application.StartupPath & "/default.txt"
        Dim S001P = Application.StartupPath & "/S001.txt"
        Dim S002P = Application.StartupPath & "/S002.txt"
        Dim MyTitle = My.Computer.FileSystem.ReadAllText(MyTitlePath)
        S001 = My.Computer.FileSystem.ReadAllText(S001P)
        S002 = My.Computer.FileSystem.ReadAllText(S002P)
        Me.Text = String.Format(MyTitle & " ({0}) - {1}", Sys_Default.Rows(0).Item("company_code").ToString, CurrentUsername.ToUpper)
        Dim sql_book As String = String.Format("SELECT a.book_id,a.book_code,a.book_name FROM lib_erp_book a WHERE a.company_id = '{0}'", Sys_Default.Rows(0).Item("company_id"))
        listBook = FsQuery(sql_book)
        Dim sql_month As String = String.Format("SELECT 1 AS id,'January' AS name " &
            "UNION SELECT 2,'February' " &
            "UNION SELECT 3,'March' " &
            "UNION SELECT 4,'April' " &
            "UNION SELECT 5,'May' " &
            "UNION SELECT 6,'June' " &
            "UNION SELECT 7,'July' " &
            "UNION SELECT 8,'August' " &
            "UNION SELECT 9,'September' " &
            "UNION SELECT 10,'October' " &
            "UNION SELECT 11,'November' " &
            "UNION SELECT 12,'December' ")
        listMonth = Query(sql_month)
    End Sub
    Public Sub setStage()
        Dim sql_stage As String = String.Format("" &
            "SELECT a.stage_id,c.module_code,b.user_id " &
            "FROM sys_erp_approval a " &
            "LEFT JOIN sys_erp_approval_user b on b.approval_id = a.approval_id " &
            "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " &
            "")
        dtStage = FsQuery(sql_stage)
    End Sub
    Private Sub PaintBackground(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim g As Graphics = e.Graphics
        Dim recW = 200
        Dim recH = 100
        Dim img As Image = Image.FromFile(Application.StartupPath & "\img\Omniray.png")
        Dim imgW = img.Width
        Dim imgH = img.Height
        Dim newImgW = 0
        Dim newImgH = 0
        Dim div = 0.0
        Dim x As Integer = 10
        Dim y As Integer = 40
        If imgW > imgH Then
            If imgW > recW Then
                div = imgW / recW
            Else
                div = recW / imgW
            End If
            newImgW = recW
            newImgH = imgH / div
        Else
            If imgH > recH Then
                div = imgH / recH
            Else
                div = recH / imgH
            End If
            newImgH = recH
            newImgW = imgW / div
        End If
        g.DrawImage(img, x, y, newImgW, newImgH)

        Dim ag As Graphics = e.Graphics
        Dim arecW = 200
        Dim arecH = 100
        Dim aimg As Image = Image.FromFile(Application.StartupPath & "\img\logo.png")
        Dim aimgW = aimg.Width
        Dim aimgH = aimg.Height
        Dim anewImgW = 0
        Dim anewImgH = 0
        Dim adiv = 0.0
        Dim ax As Integer = 10
        Dim ay As Integer = Me.Height - (60 + arecH)
        If aimgW > aimgH Then
            If aimgW > arecW Then
                adiv = aimgW / arecW
            Else
                adiv = arecW / aimgW
            End If
            anewImgW = arecW
            anewImgH = aimgH / adiv
        Else
            If aimgH > arecH Then
                adiv = aimgH / arecH
            Else
                adiv = arecH / aimgH
            End If
            anewImgH = arecH
            anewImgW = aimgW / adiv
        End If
        ag.DrawImage(aimg, ax, ay, anewImgW, anewImgH)
    End Sub
    Friend Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CreateSHBackup()
        Dim path As String = Application.StartupPath & "\log\SystemUpdate.exe"
        Dim MyUpdate As Process = Process.Start(path)
        MyUpdate.Close()
        connectionlib.connectionlib.DefaultLogPath = Application.StartupPath & "/log/"
        connectionlib.connectionlib.MyDebugging = New connectionlib.DebugModule()
        MyDebugging.AddText("----- Accounting Start -----")
        'CreateSHBackup()
        Application.EnableVisualStyles()

        Dim C As Control

        For Each C In Me.Controls
            If TypeOf C Is MdiClient Then
                C.BackColor = Me.BackColor
                AddHandler C.Paint, AddressOf PaintBackground
                Exit For
            End If
        Next
        'MDIContainerBackground.BackColor = Me.BackColor
        'showForm(MDIContainerBackground, Me)
        C = Nothing

        setConnectionSettings()
        If Not dbConnected(My.Settings._serverDBMain) Then

            showForm(connectionsettings, Me)
            Exit Sub
        End If
        If Not dbConnected(My.Settings._serverDBFS) Then
            showForm(connectionsettings, Me)
            Exit Sub
        End If
        login.ShowDialog()
        If login.DialogResult <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        'log_id = 1
        'frmapproval.username = "alas"
        'frmapproval.log_id = 1
        'changepassword.username = "alas"
        'changepassword.lblUsername.Text = "alas"
        'MyDebugging.AddText("Start Initialization")
        'setStage()
        'Dim listAction As New List(Of String)
        'listAction.Add("m_add")
        'listAction.Add("m_edit")
        'listAction.Add("m_delete")
        'listAction.Add("m_cancel")
        'listAction.Add("m_print")
        'listAction.Add("m_verify")
        'listAction.Add("m_approve")

        'Dim sql = String.Format("SELECT a.module_code,b.m_view,b.m_add,b.m_edit,b.m_delete,b.m_cancel,b.m_verify,b.m_approve,b.m_print " &
        '        "FROM {0}.sys_erp_modules a " &
        '        "LEFT JOIN {0}.sys_erp_profile_det b ON b.module_id = a.module_id " &
        '        "LEFT JOIN {0}.sys_erp_user c ON c.profile_id = b.profile_id " &
        '        "WHERE a.system_id = 2 AND c.username = '{1}' " &
        '        "", _serverDBFS, "alas")
        'Dim dt = Query(sql)
        'Dim _sql As String = String.Format("SELECT module_code FROM {0}.sys_erp_modules WHERE system_id = 2 ", _serverDBFS)
        'Dim _dt As DataTable = Query(_sql)
        'Dim drs As New List(Of DataRow)
        'For Each dr As DataRow In dt.Rows
        '    If dr.Item("m_view").ToString = "0" Then
        '        drs.Add(dr)
        '    End If
        '    Dim dic As New Dictionary(Of String, Boolean)
        '    For Each action In listAction
        '        dic.Add(action, dr.Item(action))
        '    Next
        '    If dicAction.Keys.Contains(dr.Item("module_code")) Then
        '        dicAction.Item(dr.Item("module_code")) = dic
        '    Else
        '        dicAction.Add(dr.Item("module_code"), dic)
        '    End If
        'Next
        'For Each dr As DataRow In _dt.Rows
        '    Dim tmp_dr() As DataRow = dt.Select(String.Format("module_code = '{0}'", dr.Item("module_code")))
        '    If tmp_dr.Count = 0 Then
        '        drs.Add(dr)
        '    End If
        'Next
        'emon - remove when login need

        SplashScreenManager.ShowForm(GetType(acctg_splash))
        'spla
        'For Each x In AppDomain.CurrentDomain.GetAssemblies()
        '    Assembly.Load(x.FullName)
        '    SplashScreenManager.Default.SendCommand(acctg_splash.SplashScreenCommand.SetLabel, x.FullName.ToString)
        'Next

        Journal = FsQuery("select * from lib_erp_journal")
        'SplashScreenManager.Default.SendCommand(acctg_splash.SplashScreenCommand.SetLabel, "Load Journal ...")
        loadCompany()
        'SplashScreenManager.Default.SendCommand(acctg_splash.SplashScreenCommand.SetLabel, "Load Company ...")
        browse.StartPosition = FormStartPosition.CenterScreen

        filter.MdiParent = Me
        filter.StartPosition = FormStartPosition.CenterScreen
        'reportviewer.DocumentViewer1.DocumentSource = Nothing
        'SplashScreenManager.Default.SendCommand(acctg_splash.SplashScreenCommand.SetLabel, "Load Report Viewer ...")
        'showForm(Dashboard, Me)
        'SplashScreenManager.Default.SendCommand(acctg_splash.SplashScreenCommand.SetLabel, "Load Dashboard ...")
        'reportviewer.Hide()
        'reportddesigner.Hide()
        'SplashScreenManager.Default.SendCommand(acctg_splash.SplashScreenCommand.SetLabel, "Load Report Designer ...")
        SplashScreenManager.CloseForm()
        MenuStrip1.Focus()
        'btnShowPendingAP.Visible = False
        'showForm(pendingAP, Me)
        'pendingAP.InitializeConnection()
        MyDebugging.AddText("End of Initialization")
        tmpMenu1.Visible = My.Settings._withPM
        tmpMenu2.Visible = My.Settings._withPM
        tmpMenu3.Visible = My.Settings._withPM
        tmpMenu4.Visible = My.Settings._withPM
        'ViewerToolStripMenuItem.Visible = False
    End Sub
    Private Sub InvoicingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00101.Click
        Dim dr As DataRow
        dr = Journal.Select("journal_code = 'IB'")(0)
        Dim frmSettings As New settings
        Dim frmTransaction As New transactionib
        frmTransaction.initializeDecimalPlaces(strNumberFormat)
        frmSettings.frmTransaction = frmTransaction
        frmSettings.journal_id = dr.Item("journal_id")
        frmSettings.journal_code = dr.Item("journal_code")
        frmSettings.journal_name = dr.Item("journal_name")
        frmSettings.journal_id = dr.Item("journal_id")
        If Sys_Default.Rows.Count > 0 Then
            frmSettings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
            frmSettings.minDate = CDate(Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        End If
        frmSettings.init()
        frmSettings.ShowDialog()

    End Sub

    Public Shared Sub call_settings(ByVal dr As DataRow)
        settings.journal_id = dr.Item("journal_id")
        settings.journal_code = dr.Item("journal_code")
        settings.journal_name = dr.Item("journal_name")
        settings.ShowDialog()
    End Sub
    Private Sub PettyCashVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00601.Click
        Dim dr As DataRow
        dr = Journal.Select("journal_code = 'PC'")(0)
        Dim frmSettings As New settings
        Dim frmTransaction As New transactionpc
        frmTransaction.initializeDecimalPlaces(strNumberFormat)
        frmSettings.frmTransaction = frmTransaction
        frmSettings.journal_id = dr.Item("journal_id")
        frmSettings.journal_code = dr.Item("journal_code")
        frmSettings.journal_name = dr.Item("journal_name")
        frmSettings.journal_id = dr.Item("journal_id")
        If Sys_Default.Rows.Count > 0 Then
            frmSettings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
            frmSettings.minDate = CDate(Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        End If
        frmSettings.init()
        frmSettings.ShowDialog()
    End Sub
    Private Sub DebitCreditMemoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00701.Click
        Dim dr As DataRow
        dr = Journal.Select("journal_code = 'DC'")(0)
        Dim frmSettings As New settings
        Dim frmTransaction As New transactiondc
        frmTransaction.initializeDecimalPlaces(strNumberFormat)
        frmSettings.frmTransaction = frmTransaction
        frmSettings.journal_id = dr.Item("journal_id")
        frmSettings.journal_code = dr.Item("journal_code")
        frmSettings.journal_name = dr.Item("journal_name")
        frmSettings.journal_id = dr.Item("journal_id")
        If Sys_Default.Rows.Count > 0 Then
            frmSettings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
            frmSettings.minDate = CDate(Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        End If
        frmSettings.init()
        frmSettings.ShowDialog()
    End Sub
    Private Sub OfficialReceiptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00201.Click
        Dim dr As DataRow
        dr = Journal.Select("journal_code = 'CR'")(0)
        Dim frmSettings As New settings
        Dim frmTransaction As New transactioncr
        frmTransaction.initializeDecimalPlaces(strNumberFormat)
        frmSettings.frmTransaction = frmTransaction
        frmSettings.journal_id = dr.Item("journal_id")
        frmSettings.journal_code = dr.Item("journal_code")
        frmSettings.journal_name = dr.Item("journal_name")
        frmSettings.journal_id = dr.Item("journal_id")
        If Sys_Default.Rows.Count > 0 Then
            frmSettings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
            frmSettings.minDate = CDate(Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        End If
        frmSettings.init()
        frmSettings.ShowDialog()
    End Sub
    Private Sub GLBegbalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00811.Click
        fsbeg.initializeDecimalPlaces(strNumberFormat)
        begbal_ap_detail.initializeDecimalPlaces(strNumberFormat)
        begbal_ar_detail.initializeDecimalPlaces(strNumberFormat)
        begbal_ewt_detail.initializeDecimalPlaces(strNumberFormat)
        begbal_fa_detail.initializeDecimalPlaces(strNumberFormat)
        begbal_ft_detail.initializeDecimalPlaces(strNumberFormat)
        begbal_iv_detail.initializeDecimalPlaces(strNumberFormat)
        begbal_ov_detail.initializeDecimalPlaces(strNumberFormat)
        begbal_pre_detail.initializeDecimalPlaces(strNumberFormat)
        Dim dr As DataRow
        dr = Journal.Select("journal_code = 'BEG'")(0)
        call_filter(dr, Sys_Default.Rows(0).Item("sys_beg"))
    End Sub
    Private Sub call_filter(ByVal dr As DataRow, ByVal sys_beg As DateTime)
        filter.journal_id = dr.Item("journal_id")
        filter.journal_code = dr.Item("journal_code")
        filter.sys_beg = sys_beg
        showForm(filter, Me)
    End Sub
    Private Sub JournalVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00501.Click
        Dim dr As DataRow
        dr = Journal.Select("journal_code = 'JB'")(0)
        Dim frmSettings As New settings
        Dim frmTransaction As New transactionjb
        frmTransaction.initializeDecimalPlaces(strNumberFormat)
        frmSettings.frmTransaction = frmTransaction
        frmSettings.journal_id = dr.Item("journal_id")
        frmSettings.journal_code = dr.Item("journal_code")
        frmSettings.journal_name = dr.Item("journal_name")
        frmSettings.journal_id = dr.Item("journal_id")
        If Sys_Default.Rows.Count > 0 Then
            frmSettings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
            frmSettings.minDate = CDate(Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        End If
        frmSettings.init()
        frmSettings.ShowDialog()
    End Sub
    Private Sub EncryptDecryptToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        showForm(encrypt_decrypt, Me)
    End Sub
    Private Sub CreateSHBackup()
        Dim lst As New List(Of String)
        lst.Add("erp_accounting_afsc")
        lst.Add("erp_accounting_afsc_at")
        lst.Add("erp_accounting_api")
        lst.Add("erp_accounting_api_at")
        lst.Add("erp_accounting_crdi")
        lst.Add("erp_accounting_crdi_at")
        lst.Add("erp_accounting_nhi")
        lst.Add("erp_accounting_nhi_at")
        lst.Add("erp_accounting_nhi_test")
        lst.Add("erp_accounting_nhi_test_at")
        lst.Add("erp_accounting_nhi_upload")
        lst.Add("erp_accounting_omp")
        lst.Add("erp_accounting_omp_at")
        lst.Add("erp_accounting_pi")
        lst.Add("erp_accounting_pi_at")
        lst.Add("erp_accounting_swldc")
        lst.Add("erp_accounting_swldc_at")
        lst.Add("erp_file_setup_accounting_afsc")
        lst.Add("erp_file_setup_accounting_afsc_at")
        lst.Add("erp_file_setup_accounting_api")
        lst.Add("erp_file_setup_accounting_api_at")
        lst.Add("erp_file_setup_accounting_omp")
        lst.Add("erp_file_setup_accounting_omp_at")
        lst.Add("erp_file_setup_accounting_pi")
        lst.Add("erp_file_setup_accounting_pi_at")
        lst.Add("erp_file_setup_accounting_swldc")
        lst.Add("erp_file_setup_accounting_swldc_at")
        lst.Add("erp_file_setup_hris_main")
        lst.Add("erp_file_setup_hris_main_at")
        lst.Add("erp_file_setup_hris_main_early")
        lst.Add("erp_file_setup_hris_main_early_at")
        lst.Add("erp_file_setup_hris_main_practice_early")
        lst.Add("erp_file_setup_hris_main_practice_early_at")
        lst.Add("erp_fs")
        lst.Add("erp_fs_afcsc")
        lst.Add("erp_fs_afcsc_at")
        lst.Add("erp_fs_alhi")
        lst.Add("erp_fs_alhi10032018")
        lst.Add("erp_fs_alhi10032018_at")
        lst.Add("erp_fs_alhi_at")
        lst.Add("erp_fs_alhi_test")
        lst.Add("erp_fs_alhi_test_at")
        lst.Add("erp_fs_alhi_v2")
        lst.Add("erp_fs_alhi_v2_at")
        lst.Add("erp_fs_at")
        lst.Add("erp_fs_drdc")
        lst.Add("erp_fs_drdc_v2")
        lst.Add("erp_fs_drdc_v2_at")
        lst.Add("erp_fs_inventory")
        lst.Add("erp_fs_ngg_v2")
        lst.Add("erp_fs_ngg_v2_at")
        lst.Add("erp_fs_pjdc_v2")
        lst.Add("erp_fs_pjdc_v2_at")
        lst.Add("erp_fs_sldc_v2")
        lst.Add("erp_fs_sldc_v2_at")
        lst.Add("erp_fs_sunwealth")
        lst.Add("erp_fs_sunwealth_at")
        lst.Add("erp_fs_tovgi_v2")
        lst.Add("erp_fs_tovgi_v2_at")
        lst.Add("erp_fs_v2")
        lst.Add("erp_fs_v2_at")
        lst.Add("erp_fs_verleo")
        lst.Add("erp_fs_wcdc")
        lst.Add("erp_fs_wcdi_v2")
        lst.Add("erp_fs_wcdi_v2_at")
        lst.Add("erp_fs_weecomm_v2")
        lst.Add("erp_fs_weecomm_v2_at")
        lst.Add("erp_interment_db")
        lst.Add("erp_red")
        lst.Add("erp_red_afcsc")
        lst.Add("erp_red_alhi")
        lst.Add("erp_red_alhi10032018")
        lst.Add("erp_red_alhi_test")
        lst.Add("erp_red_alhi_v2")
        lst.Add("erp_red_alhi_v2_at")
        lst.Add("erp_red_drdc")
        lst.Add("erp_red_drdc_v2")
        lst.Add("erp_red_drdc_v2_at")
        lst.Add("erp_red_ngg_v2")
        lst.Add("erp_red_ngg_v2_at")
        lst.Add("erp_red_pjdc_v2")
        lst.Add("erp_red_pjdc_v2_at")
        lst.Add("erp_red_pjdc_v2_upload")
        lst.Add("erp_red_sample")
        lst.Add("erp_red_sldc_v2")
        lst.Add("erp_red_sldc_v2_at")
        lst.Add("erp_red_sunwealth")
        lst.Add("erp_red_tovgi_v2")
        lst.Add("erp_red_tovgi_v2_at")
        lst.Add("erp_red_v2")
        lst.Add("erp_red_v2_at")
        lst.Add("erp_red_v2_atcrm_ticket_document_at")
        lst.Add("erp_red_wcdi_v2")
        lst.Add("erp_red_wcdi_v2_at")
        lst.Add("erp_red_wcdi_v2erp_red_wcdi_v2_at")
        lst.Add("erp_red_weecomm_v2")
        lst.Add("erp_red_weecomm_v2_at")
        lst.Add("erp_time_and_attendance")
        lst.Add("erp_time_and_attendance_at")
        lst.Add("erp_time_and_attendance_early")
        lst.Add("erp_time_and_attendance_early_at")
        lst.Add("erp_time_and_attendance_ncca")
        lst.Add("erp_time_and_attendance_ncca_at")
        lst.Add("erp_time_and_attendance_osg")
        lst.Add("erp_time_and_attendance_osg_at")
        lst.Add("erp_time_and_attendance_practice")
        lst.Add("erp_time_and_attendance_practice_at")
        lst.Add("erp_time_and_attendance_practice_early")
        lst.Add("erp_time_and_attendance_sample")
        lst.Add("erp_time_and_attendance_sample_at")
        lst.Add("erp_time_and_attendance_tann")
        lst.Add("erp_time_and_attendance_tann_at")
        lst.Add("erp_time_and_attendance_xyz")
        lst.Add("erp_time_and_attendance_xyz_at")
        lst.Add("exam")
        lst.Add("fs_verleo")
        lst.Add("hris_fs_db_atalian")
        lst.Add("hris_fs_db_atalian_at")
        lst.Add("hris_fs_db_llda")
        lst.Add("hris_fs_db_llda_at")
        lst.Add("hris_fs_db_namria")
        lst.Add("hris_fs_db_ncca")
        lst.Add("hris_fs_db_ncca_at")
        lst.Add("hris_fs_db_northcomp")
        lst.Add("hris_fs_db_osg")
        lst.Add("hris_fs_db_osg_at")
        lst.Add("hris_fs_db_phil_ret")
        lst.Add("hris_fs_db_phil_ret_at")
        lst.Add("hris_fs_db_sample")
        lst.Add("hris_fs_db_sample_at")
        lst.Add("hris_fs_db_sci")
        lst.Add("hris_fs_db_sei")
        lst.Add("hris_fs_db_tann")
        lst.Add("hris_fs_db_tann_at")
        lst.Add("hris_fs_db_xyz")
        lst.Add("hris_fs_db_xyz_at")
        lst.Add("hris_payroll_main")
        lst.Add("hris_payroll_main_at")
        lst.Add("hris_payroll_main_atalian")
        lst.Add("hris_payroll_main_llda")
        lst.Add("hris_payroll_main_namria")
        lst.Add("hris_payroll_main_ncca")
        lst.Add("hris_payroll_main_northcomp")
        lst.Add("hris_payroll_main_osg")
        lst.Add("hris_payroll_main_phil_ret")
        lst.Add("hris_payroll_main_phil_ret_at")
        lst.Add("hris_payroll_main_pmo")
        lst.Add("hris_payroll_main_sci")
        lst.Add("hris_payroll_main_sei")
        lst.Add("hris_payroll_main_tan")
        lst.Add("hris_payroll_main_xyz")
        lst.Add("hris_test_db")
        lst.Add("hris_test_db_at")
        lst.Add("hris_test_db_namria")
        lst.Add("hris_test_db_northcomp")
        lst.Add("hris_test_db_pmo")
        lst.Add("hris_trans_db_namria")
        lst.Add("hris_trans_db_namria_at")
        lst.Add("hrisdbsei")
        lst.Add("humanresourcenamria")
        lst.Add("humanresourcephilret")
        lst.Add("humanresourcesei")
        lst.Add("inv_file_setup")
        lst.Add("inv_main")
        lst.Add("inv_main10032018")
        lst.Add("inv_main_afcsc")
        lst.Add("inv_main_afcsc_at")
        lst.Add("inv_main_afcsc_test")
        lst.Add("inv_main_test")
        lst.Add("inv_main_test_at")
        lst.Add("inv_main_verleo")
        lst.Add("inv_main_wcdc")
        lst.Add("inventory_main")
        lst.Add("main_db_verleo")
        lst.Add("myexam")
        lst.Add("pms_transaction_db")
        lst.Add("pms_transaction_db_wcdc")
        lst.Add("sms_main")
        For Each dbname As String In lst
            'MyDebugging.CreateSHFile(dbname)
        Next
    End Sub
    Private Sub ACC00810_Click(sender As Object, e As EventArgs) Handles ACC00810.Click
        GeneralLibrary.initializeDecimalPlaces(strNumberFormat)
        showForm(GeneralLibrary, Me)
    End Sub
    Private Sub ACC00806_Click(sender As Object, e As EventArgs) Handles ACC00806.Click
        showForm(chart, Me)
    End Sub
    Private Sub ACC01009_Click(sender As Object, e As EventArgs) Handles ACC01009.Click
        showForm(fixedassetreport, Me)
    End Sub
    Private Sub ACC01013_Click(sender As Object, e As EventArgs) Handles ACC01013.Click
        showForm(accountanlysis, Me)
    End Sub
    Private Sub ACC01018_Click(sender As Object, e As EventArgs) Handles ACC01018.Click
        showForm(printingbooks, Me)
    End Sub
    Private Sub ACC01001_Click(sender As Object, e As EventArgs) Handles ACC01001.Click
        showForm(apdetailedaging, Me)
    End Sub
    Private Sub ACC01005_Click(sender As Object, e As EventArgs) Handles ACC01005.Click
        showForm(ardetailedaging, Me)
    End Sub
    Private Sub ACC01012_Click(sender As Object, e As EventArgs) Handles ACC01012.Click
        showForm(trialbalance, Me)
    End Sub
    Private Sub ACC01019_Click(sender As Object, e As EventArgs) Handles ACC01019.Click
        showForm(journals, Me)
    End Sub
    Private Sub ACC00808_Click(sender As Object, e As EventArgs) Handles ACC00808.Click
        'currency_rate.initializeDecimalPlaces(strNumberFormat)
        'currency_rate.InitialiseMyForm(currency_rate)
        'currency_rate.InitializeDecimalPlaces(Me.DecimalPlaces)
        'currency_rate.MyLogID = log_id
        currencyrate.DecimalPlaces = Me.DecimalPlaces
        showForm(currencyrate, Me)
    End Sub
    Private Sub ACC01006_Click(sender As Object, e As EventArgs) Handles ACC01006.Click
        showForm(arsubsidiary, Me)
    End Sub
    Private Sub ACC01007_Click(sender As Object, e As EventArgs) Handles ACC01007.Click
        showForm(aragingsummary, Me)
    End Sub
    Private Sub ACC01008_Click(sender As Object, e As EventArgs) Handles ACC01008.Click
        showForm(arsummary, Me)
    End Sub
    Private Sub ACC01002_Click(sender As Object, e As EventArgs) Handles ACC01002.Click
        showForm(apsubsidiary, Me)
    End Sub

    Private Sub ACC01016_Click(sender As Object, e As EventArgs) Handles ACC01016asdasdas.Click
        'showForm(outputvat, Me)
    End Sub
    Private Sub ACC00908_Click(sender As Object, e As EventArgs) Handles ACC00908.Click
        showForm(companyconfig, Me)
    End Sub
    Private Sub ACC00901_Click(sender As Object, e As EventArgs) Handles ACC00901.Click
        showForm(userprofile, Me)
    End Sub
    Private Sub ACC00903_Click(sender As Object, e As EventArgs) Handles ACC00903.Click
        showForm(usermanagement, Me)
    End Sub
    Private Sub ACC00904_Click(sender As Object, e As EventArgs) Handles ACC00904.Click
        showForm(passwordrecovery, Me)
    End Sub
    Private Sub ACC00905_Click(sender As Object, e As EventArgs) Handles ACC00905.Click
        showForm(changepassword, Me)
    End Sub
    Private Sub ACC00819_Click(sender As Object, e As EventArgs) Handles ACC00819.Click
        showForm(stagesetup, Me)
    End Sub
    Private Sub ACC00912_Click(sender As Object, e As EventArgs) Handles ACC00912.Click
        approvalsetup.InitialiseMyForm(approvalsetup)
        approvalsetup.MyLogID = log_id
        showForm(approvalsetup, Me)
    End Sub
    Private Sub BookCodesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ACC00821.Click
        Book.InitialiseMyForm(Book)
        Book.MyLogID = log_id
        Book.txt_filter.Value = Sys_Default.Rows(0).Item("company_id").ToString
        showForm(Book, Me)
    End Sub
    Private Sub ACC00911_Click(sender As Object, e As EventArgs) Handles ACC00911.Click
        showForm(jbookssetup, Me)
    End Sub
    Private Sub ACC00910_Click(sender As Object, e As EventArgs) Handles ACC00910.Click
        showForm(filtercodessetup, Me)
    End Sub
    Private Sub ACC00804_Click(sender As Object, e As EventArgs) Handles ACC00804.Click
        chartclass.InitialiseMyForm(chartclass)
        chartclass.MyLogID = log_id
        showForm(chartclass, Me)
    End Sub
    Private Sub ACC00805_Click(sender As Object, e As EventArgs) Handles ACC00805.Click
        showForm(chart_group, Me)
    End Sub
    Private Sub ACC00812_Click(sender As Object, e As EventArgs) Handles ACC00812.Click
        showForm(industry, Me)
    End Sub
    Private Sub ACC00803_Click(sender As Object, e As EventArgs) Handles ACC00803.Click
        category.InitialiseMyForm(category)
        category.MyLogID = log_id
        showForm(category, Me)
    End Sub
    Private Sub ACC00807_Click(sender As Object, e As EventArgs) Handles ACC00807.Click
        currency.InitialiseMyForm(currency)
        currency.MyLogID = log_id
        showForm(currency, Me)
    End Sub
    Private Sub ACC00814_Click(sender As Object, e As EventArgs) Handles ACC00814.Click

        ewt.InitialiseMyForm(ewt)
        ewt.MyLogID = log_id
        showForm(ewt, Me)
    End Sub
    Private Sub ACC00815_Click(sender As Object, e As EventArgs) Handles ACC00815.Click
        final_tax.InitialiseMyForm(final_tax)
        final_tax.MyLogID = log_id
        showForm(final_tax, Me)
    End Sub
    Private Sub ACC00816_Click(sender As Object, e As EventArgs) Handles ACC00816.Click
        input_vat.initializeDecimalPlaces(strNumberFormat)
        showForm(input_vat, Me)
    End Sub
    Private Sub ACC00817_Click(sender As Object, e As EventArgs) Handles ACC00817.Click
        output_vat.initializeDecimalPlaces(strNumberFormat)
        showForm(output_vat, Me)
    End Sub
    Private Sub ACC00801_Click(sender As Object, e As EventArgs) Handles ACC00801.Click

        allocation.InitialiseMyForm(allocation)
        allocation.MyLogID = log_id
        showForm(allocation, Me)
    End Sub
    Private Sub ACC00802_Click(sender As Object, e As EventArgs) Handles ACC00802.Click
        showForm(bank, Me)
    End Sub
    Private Sub ACC00809_Click(sender As Object, e As EventArgs) Handles ACC00809.Click
        department.InitialiseMyForm(department)
        department.MyLogID = log_id
        showForm(department, Me)
    End Sub
    Private Sub ACC00813_Click(sender As Object, e As EventArgs) Handles ACC00813.Click
        showForm(project, Me)
    End Sub
    Private Sub ACC00818_Click(sender As Object, e As EventArgs) Handles ACC00818.Click
        showForm(terms, Me)
    End Sub
    Private Sub ACC00906_Click(sender As Object, e As EventArgs) Handles ACC00906.Click
        showForm(agingrange, Me)
    End Sub
    Private Sub ACC00909_Click(sender As Object, e As EventArgs) Handles ACC00909.Click
        showForm(connectionsettings, Me)
    End Sub
    Private Sub ACC01004_Click(sender As Object, e As EventArgs) Handles ACC01004.Click
        showForm(apsummary, Me)
    End Sub
    Private Sub ACC01003_Click(sender As Object, e As EventArgs) Handles ACC01003.Click
        showForm(apagingsummary, Me)
    End Sub
    Private Sub ImportChartOfAccountToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ACC00822.Click
        showForm(ImportChartOfAccount, Me)
    End Sub
    Private Sub ImportGeneralLibraryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ACC00823.Click
        showForm(ImportGeneral, Me)
    End Sub
    Private Sub HideToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem1.Click
        Dashboard.Close()
    End Sub
    Private Sub ShowToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem1.Click
        showForm(Dashboard, Me)
    End Sub
    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Dim flag = MsgBox("Are you sure to Logout?", MsgBoxStyle.YesNo, "Logout")
        If flag = MsgBoxResult.Yes Then
            For Each frm As Form In Me.MdiChildren
                frm.Close()
            Next
            MenuStrip1.Visible = False
            login.ShowDialog()
            loadCompany()
        End If
    End Sub
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub DefaultSignatoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00820.Click
        usersignatories.UserID = user_id
        showForm(usersignatories, Me)
    End Sub
    Private Sub PrepaidReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01034.Click
        showForm(prepaidreport, Me)
    End Sub
    Private Sub StatementOfAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01035.Click
        showForm(soareport, Me)
    End Sub
    Private Sub ComparativeIncomeStatementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        showForm(incomestatement, Me)
    End Sub
    Private Sub ACC01011_Click(sender As Object, e As EventArgs) Handles ACC01011.Click
        'showForm(incomestatement, Me)
        Dim FS_Design As New new_fs_filter
        FS_Design.FS_Type = 2
        FS_Design.lbl_title.Text = "Income Statement"
        FS_Design.Text = "Income Statement"
        showForm(FS_Design, Me)
    End Sub
    Private Sub CheckVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00401.Click
        Dim dr As DataRow
        dr = Journal.Select("journal_code = 'CV'")(0)
        Dim frmSettings As New settings
        Dim frmTransaction As New transactioncv
        frmTransaction.initializeDecimalPlaces(strNumberFormat)
        frmSettings.frmTransaction = frmTransaction
        frmSettings.journal_id = dr.Item("journal_id")
        frmSettings.journal_code = dr.Item("journal_code")
        frmSettings.journal_name = dr.Item("journal_name")
        frmSettings.journal_id = dr.Item("journal_id")
        If Sys_Default.Rows.Count > 0 Then
            frmSettings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
            frmSettings.minDate = CDate(Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        End If
        frmSettings.init()
        frmSettings.ShowDialog()
        'Dim dr As DataRow = Journal.Select("journal_code = 'CV'")(0)
        'Dim frmSettings As New DESettings
        'Dim frmTransaction As New DETransactionCV
        'frmSettings.frmTransaction = frmTransaction
        'frmSettings.journal_id = dr.Item("journal_id").ToString
        'frmSettings.journal_code = dr.Item("journal_code").ToString
        'frmSettings.journal_name = dr.Item("journal_name").ToString
        'If Sys_Default.Rows.Count > 0 Then
        '    frmSettings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
        '    frmSettings.minDate = CDate(Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        'End If
        'frmSettings.ShowDialog()
    End Sub
    Private Sub CheckReleasingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC0040103.Click
        showForm(CheckReleased, Me)
    End Sub
    Private Sub CheckFundingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC0040102.Click
        showForm(CheckFunding, Me)
    End Sub
    Private Sub ACC01010_CLICK(sender As Object, e As EventArgs) Handles ACC01010.Click
        'showForm(balancesheet, Me)
        Dim FS_Design As New new_fs_filter
        FS_Design.FS_Type = 1
        FS_Design.lbl_title.Text = "Balance Sheet"
        FS_Design.Text = "Balance Sheet"
        showForm(FS_Design, Me)
    End Sub
    Private Sub ComparativeBalanceSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01020.Click
        showForm(balancesheet, Me)
        'showForm(balancespreadsheet, Me)
    End Sub
    Private Sub ChecksReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01025.Click
        showForm(checks, Me)
    End Sub
    Private Sub AccountsPayableVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01026.Click
        Dim newBook As New allbook
        newBook.journal_id = "3"
        newBook.journal_name = sender.Text
        showForm(newBook, Me)
    End Sub
    Private Sub OfficialReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01027.Click
        Dim newBook As New allbook
        newBook.journal_id = "2"
        newBook.journal_name = sender.Text
        showForm(newBook, Me)
    End Sub
    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01028.Click
        Dim newBook As New allbook
        newBook.journal_id = "1"
        newBook.journal_name = sender.Text
        showForm(newBook, Me)
    End Sub
    Private Sub CheckVoucherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ACC01029.Click
        Dim newBook As New allbook
        newBook.journal_id = "4"
        newBook.journal_name = sender.Text
        showForm(newBook, Me)
    End Sub
    Private Sub DebitCreditMemoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ACC01031.Click
        Dim newBook As New allbook
        newBook.journal_id = "7"
        newBook.journal_name = sender.Text
        showForm(newBook, Me)
    End Sub
    Private Sub PettyCashVoucherToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ACC01032.Click
        Dim newBook As New allbook
        newBook.journal_id = "6"
        newBook.journal_name = sender.Text
        showForm(newBook, Me)
    End Sub
    Private Sub JournalVoucherToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ACC01030.Click
        Dim newBook As New allbook
        newBook.journal_id = "5"
        newBook.journal_name = sender.Text
        showForm(newBook, Me)
    End Sub

    Private Sub SOAOldToolStripMenuItem_Click(sender As Object, e As EventArgs)
        showForm(soa, Me)
    End Sub

    Private Sub TransactionLockingToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ACC00824.Click
        transactionlockingbook.InitialiseMyForm(transactionlockingbook)
        transactionlockingbook.MyLogID = log_id
        showForm(transactionlockingbook, Me)
    End Sub

    Private Sub ClosingOfNominalAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00825.Click
        showForm(ClosingNominalAccount, Me)
    End Sub

    Private Sub IncomeStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01023.Click
        Dim FS_Design As New fsdesign
        FS_Design.FS_Type = 2
        showForm(FS_Design, Me)
    End Sub

    Private Sub BalanceSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01022.Click
        Dim FS_Design As New fsdesign
        FS_Design.FS_Type = 1
        showForm(FS_Design, Me)
    End Sub

    Private Sub VoucherTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00826.Click
        Dim frm As New VoucherTemplate
        frm.InitializeConnection()
        frm.ShowDialog()
    End Sub

    Private Sub SummaryOfBooksByTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryOfBooksByTotalToolStripMenuItem.Click
        showForm(SummaryOfBooksByTotal, Me)
    End Sub

    Private Sub ACC00123_Click(sender As Object, e As EventArgs) Handles ACC00123.Click
        showForm(frmBookUnit, Me)
    End Sub

    Private Sub PracticeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DetailChartListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01033.Click
        showForm(DetailedChartList, Me)
    End Sub

    Private Sub ACC001233_Click(sender As Object, e As EventArgs) Handles ACC001233.Click
        showForm(frmProject, Me)
    End Sub

    Private Sub OtherFileSetupToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OtherFileSetupToolStripMenuItem.Click
        ACC001233.Visible = My.Settings._enableProjectUnit
        ACC00123.Visible = My.Settings._enableBookUnit
    End Sub

    Private Sub BasicBalanceSheetToolStripMenuItem_Click(sender As Object, e As EventArgs)
        showForm(balancesheet, Me)
    End Sub

    Private Sub BasicIncomeStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01021.Click
        showForm(incomestatement, Me)
    End Sub

    Private Sub btnUnitSetup_Click(sender As Object, e As EventArgs) Handles btnUnitSetup.Click
        If My.Settings._enableBookUnit Then
            showForm(frmBookUnit, Me)
        Else
            showForm(frmBookUnit, Me)
        End If
    End Sub

    Private Sub btnShowPendingAP_Click(sender As Object, e As EventArgs) Handles btnShowPendingAP.Click
        showForm(pendingAP, Me)
        pendingAP.InitializeConnection()
    End Sub

    Private Sub btnShowPendingAR_Click(sender As Object, e As EventArgs) Handles btnShowPendingAR.Click
        showForm(pendingAR, Me)
        pendingAR.InitializeConnection()
    End Sub

    Private Sub ProjectManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tmpMenu1.Click
        showForm(Project_management, Me)
        'a
    End Sub

    Private Sub ImportPOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportPOToolStripMenuItem.Click
        showForm(ImportPO, Me)
    End Sub

    Private Sub AccountPayablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountPayablesToolStripMenuItem.Click
        Dim dr As DataRow
        dr = Journal.Select("journal_code = 'AP'")(0)
        Dim frmSettings As New settings
        Dim frmTransaction As New transactionap
        frmTransaction.initializeDecimalPlaces(strNumberFormat)
        frmSettings.frmTransaction = frmTransaction
        frmSettings.journal_id = dr.Item("journal_id")
        frmSettings.journal_code = dr.Item("journal_code")
        frmSettings.journal_name = dr.Item("journal_name")
        frmSettings.journal_id = dr.Item("journal_id")
        If Sys_Default.Rows.Count > 0 Then
            frmSettings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
            frmSettings.minDate = CDate(Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        End If
        frmSettings.init()
        frmSettings.ShowDialog()
    End Sub

    Private Sub SubContractManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tmpMenu3.Click
        'Dim frm As New SubContract_management
        'frm.Show()
        showForm(SubContract_management, Me)
    End Sub

    Private Sub ProjectManagementReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tmpMenu2.Click
        showForm(frm_project_management_reports, Me)
    End Sub
    Private Sub OutputVatDatFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutputVATDATToolStripMenuItem.Click
        showForm(OutputVat_DatFile, Me)
    End Sub

    Private Sub OutputVatReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01016.Click
        showForm(outputvat, Me)
    End Sub

    Private Sub InputVatReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01015.Click
        showForm(inputvat, Me)
    End Sub

    Private Sub InputVarDatFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputVATDATToolStripMenuItem.Click

        showForm(inputVat_DatFile, Me)
    End Sub

    Private Sub SubContractReport_Click(sender As Object, e As EventArgs) Handles tmpMenu4.Click
        showForm(frm_subcon_management_report, Me)
    End Sub

    Private Sub SubconSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubconSetupToolStripMenuItem.Click
        showForm(subContract_Company, Me)
    End Sub
    Private Sub ACC01017_Click(sender As Object, e As EventArgs) Handles ACC0101744e4234234234.Click

    End Sub



    Private Sub ACC01014_Click(sender As Object, e As EventArgs) Handles ACC01014.Click
        showForm(erbirforms, Me)
    End Sub

    Private Sub WToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01017.Click
        showForm(ewtreport, Me)
    End Sub

    Private Sub EwtDatFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EwtDatFileToolStripMenuItem.Click
        showForm(ewtreport_DatFile, Me)
    End Sub

    Private Sub ViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewerToolStripMenuItem.Click
        showForm(TransactionSearch, Me)
    End Sub

    Private Sub DisbursementSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisbursementSummaryToolStripMenuItem.Click
        showForm(DisbursementSummary, Me)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BudgetSetupToolStripMenuItem.Click
        showForm(BudgetSetup, Me)
    End Sub
End Class
