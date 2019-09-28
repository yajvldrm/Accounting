Imports System.Windows.Forms
Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports DevExpress.XtraSplashScreen

Public Class main
    Public Shared Journal As New DataTable
    Public Shared Sys_Default As New DataTable
    Public Shared Sys_Default_Det As New DataTable
    Public Shared dicAction As New Dictionary(Of String, Dictionary(Of String, Boolean))
    Public Shared user_id As String = "0"
    Private _dtStage As New DataTable
    Public Property dtStage() As DataTable
        Get
            Return _dtStage
        End Get
        Set(value As DataTable)
            _dtStage.Clear()
            _dtStage.Columns.Clear()
            For Each col As DataColumn In value.Columns
                _dtStage.Columns.Add(col.ColumnName)
                '_dtStage.Columns(col.ColumnName).DataType = col.DataType
                '_dtStage.Columns(col.ColumnName).DefaultValue = col.DefaultValue
            Next
            For Each row As DataRow In value.Rows
                _dtStage.ImportRow(row)
            Next
        End Set
    End Property
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

    Private m_ChildFormNumber As Integer
    Public Shared Sub setConnectionSettings()
        connectionlib.connectionlib.vtxtIP = My.Settings._serverIP
        connectionlib.connectionlib._serverDBFS = My.Settings._serverDBFS
        connectionlib.connectionlib._serverDBMain = My.Settings._serverDBMain
        connectionlib.connectionlib._serverUser = My.Settings._serverUser
        connectionlib.connectionlib._serverPass = My.Settings._serverPass
    End Sub

    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim flag = MsgBox("Are you sure to Exit?", MsgBoxStyle.YesNo, "Exit")
        If flag = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
    Friend Sub loadCompany()
        Sys_Default = Query("select * from sys_default")
        Sys_Default_Det = Query("select a.*,b.module_code from sys_default_det a inner join " & connectionlib.connectionlib._serverDBFS & ".sys_erp_modules b on a.module_id = b.module_id")
        settings.sys_beg = Sys_Default.Rows(0).Item("sys_beg")
    End Sub
    Public Sub setStage()
        Dim sql_stage As String = String.Format("" & _
            "SELECT a.stage_id,c.module_code,b.user_id " & _
            "FROM sys_erp_approval a " & _
            "LEFT JOIN sys_erp_approval_user b on b.approval_id = a.approval_id " & _
            "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " & _
            "")
        dtStage = FsQuery(sql_stage)
    End Sub
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        setConnectionSettings()
        If Not dbConnected(My.Settings._serverDBMain) Then
            showForm(connectionsettings, Me)
            Exit Sub
        End If
        If Not dbConnected(My.Settings._serverDBFS) Then
            showForm(connectionsettings, Me)
            Exit Sub
        End If
        'Journal = FsQuery("select * from lib_erp_journal")
        'Dim newtest = groupDataTableToList(Journal, "shooting,auto_number")
        'Dim test = groupBy(Journal, "shooting")

        login.ShowDialog()
        If login.DialogResult <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        'loading.Show()
        SplashScreenManager.ShowForm(GetType(acctg_splash))
        Journal = FsQuery("select * from lib_erp_journal")
        loadCompany()

        'settings.MdiParent = Me
        'settings.StartPosition = FormStartPosition.CenterScreen
        browse.StartPosition = FormStartPosition.CenterScreen

        filter.MdiParent = Me
        filter.StartPosition = FormStartPosition.CenterScreen
        reportviewer.DocumentViewer1.DocumentSource = Nothing
        reportviewer.Hide()
        reportddesigner.Hide()
        'System.Threading.Thread.Sleep(3000)
        'loading.Close()
        SplashScreenManager.CloseForm()
        'Dim sql_book As String = "SELECT * FROM lib_erp_book"
        'Dim dt_book As DataTable = FsQuery(sql_book)

        'Dim tmp1 As New ToolStripMenuItem

        'For Each row As DataRow In dt_book.Rows
        '    tmp1 = New ToolStripMenuItem
        '    tmp1.Name = "tmp_" & row.Item("book_id")
        '    tmp1.Text = row.Item("book_name")
        '    AddHandler tmp1.Click, AddressOf menu_click
        '    Me.BookToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {tmp1})
        'Next
        MenuStrip1.Focus()
    End Sub

    'Private Sub menu_click(sender As Object, e As EventArgs)
    '    Dim ctrl = CType(sender, ToolStripMenuItem)
    '    MsgBox("ID : " & ctrl.Name.ToString.Replace("tmp_", "") & " = Name : " & ctrl.Text)
    'End Sub

    Private Sub InvoicingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00101.Click
        'Dim dr As DataRow
        'dr = Journal.Select("journal_code = 'IB'")(0)
        'call_settings(dr)

        Dim transList As New Transaction_List
        Dim ib As New transactionib
        Dim dr = Journal.Select("journal_code = 'IB'")
        If dr.Count > 0 Then
            transList.journal_id = dr(0).Item("journal_id")
            transList.FormToView = ib
            ib.mainList = transList
            showForm(transList, Me)
        End If
    End Sub

    Private Sub AccountsPayableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00301.Click
        'Dim dr As DataRow
        'dr = Journal.Select("journal_code = 'AP'")(0)
        'call_settings(dr)

        Dim transList As New Transaction_List
        Dim ib As New transactionap
        Dim dr = Journal.Select("journal_code = 'AP'")
        If dr.Count > 0 Then
            transList.journal_id = dr(0).Item("journal_id")
            transList.FormToView = ib
            ib.mainList = transList
            showForm(transList, Me)
        End If
    End Sub

    Public Shared Sub call_settings(ByVal dr As DataRow)
        settings.journal_id = dr.Item("journal_id")
        settings.journal_code = dr.Item("journal_code")
        settings.journal_name = dr.Item("journal_name")
        settings.ShowDialog()
    End Sub

    Private Sub CheckVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00401.Click
        'Dim dr As DataRow
        'dr = Journal.Select("journal_code = 'CV'")(0)
        'call_settings(dr)

        Dim transList As New Transaction_List
        Dim ib As New transactioncv
        Dim dr = Journal.Select("journal_code = 'CV'")
        If dr.Count > 0 Then
            transList.journal_id = dr(0).Item("journal_id")
            transList.FormToView = ib
            ib.mainList = transList
            showForm(transList, Me)
        End If

    End Sub

    Private Sub PettyCashVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00601.Click
        'Dim dr As DataRow
        'dr = Journal.Select("journal_code = 'PC'")(0)
        'call_settings(dr)

        Dim transList As New Transaction_List
        Dim ib As New transactionpc
        Dim dr = Journal.Select("journal_code = 'PC'")
        If dr.Count > 0 Then
            transList.journal_id = dr(0).Item("journal_id")
            transList.FormToView = ib
            ib.mainList = transList
            showForm(transList, Me)
        End If

    End Sub

    Private Sub DebitCreditMemoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00701.Click
        'Dim dr As DataRow
        'dr = Journal.Select("journal_code = 'DC'")(0)
        'call_settings(dr)

        Dim transList As New Transaction_List
        Dim ib As New transactiondc
        Dim dr = Journal.Select("journal_code = 'DC'")
        If dr.Count > 0 Then
            transList.journal_id = dr(0).Item("journal_id")
            transList.FormToView = ib
            ib.mainList = transList
            showForm(transList, Me)
        End If

    End Sub

    Private Sub OfficialReceiptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00201.Click
        'Dim dr As DataRow
        'dr = Journal.Select("journal_code = 'CR'")(0)
        'call_settings(dr)

        Dim transList As New Transaction_List
        Dim ib As New transactioncr
        Dim dr = Journal.Select("journal_code = 'CR'")
        If dr.Count > 0 Then
            transList.journal_id = dr(0).Item("journal_id")
            transList.FormToView = ib
            ib.mainList = transList
            showForm(transList, Me)
        End If
    End Sub
   
    Private Sub ChartOfAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00806.Click
        showForm(chart, Me)
    End Sub

    Private Sub CurrencySetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00807.Click
        showForm(currency, Me)
    End Sub

    Private Sub CurrencyRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00808.Click
        showForm(currency_rate, Me)
    End Sub

    Private Sub InputVatSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00816.Click
        showForm(input_vat, Me)
    End Sub

    Private Sub OutputVatSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00817.Click
        showForm(output_vat, Me)
    End Sub

    Private Sub FinalTaxWithheldLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00815.Click
        showForm(final_tax, Me)
    End Sub

    Private Sub ExpandedTaxWithheldLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00814.Click
        showForm(ewt, Me)
    End Sub

    Private Sub GLBegbalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00811.Click
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

    Private Sub ChartGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00805.Click
        showForm(chart_group, Me)
    End Sub

    Private Sub JournalVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00501.Click
        'Dim dr As DataRow
        'dr = Journal.Select("journal_code = 'JB'")(0)
        'call_settings(dr)

        Dim transList As New Transaction_List
        Dim ib As New transactionjb
        Dim dr = Journal.Select("journal_code = 'JB'")
        If dr.Count > 0 Then
            transList.journal_id = dr(0).Item("journal_id")
            transList.FormToView = ib
            ib.mainList = transList
            showForm(transList, Me)
        End If
    End Sub

    Private Sub TrialBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01012.Click
        showForm(trialbalance, Me)
    End Sub

    Private Sub ChartClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00804.Click
        showForm(chartclass, Me)
    End Sub

    Private Sub BalanceSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01010.Click
        showForm(balancesheet, Me)
    End Sub

    Private Sub IncomeStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01011.Click
        showForm(incomestatement, Me)
    End Sub

    Private Sub AccountAnalysisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01013.Click
        showForm(accountanlysis, Me)
    End Sub

    Private Sub SubsidiaryLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01006.Click
        showForm(arsubsidiary, Me)
    End Sub

    Private Sub DetailedAgingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01005.Click
        showForm(ardetailedaging, Me)
    End Sub

    Private Sub AgingSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01007.Click
        showForm(aragingsummary, Me)
    End Sub

    Private Sub SummaryOfAccountsReceivableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01008.Click
        showForm(arsummary, Me)
    End Sub

    Private Sub SubsidiaryLedgerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ACC01002.Click
        showForm(apsubsidiary, Me)
    End Sub

    Private Sub DetailedAgingReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01001.Click
        showForm(apdetailedaging, Me)
    End Sub

    Private Sub AgingSummaryReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01003.Click
        showForm(apagingsummary, Me)
    End Sub

    Private Sub SummaryOfAccountsReceivableToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ACC01004.Click
        showForm(apsummary, Me)
    End Sub

    Private Sub ListOfInputVATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01015.Click
        showForm(inputvat, Me)
    End Sub

    Private Sub ListOfOutputVATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01016.Click
        showForm(outputvat, Me)
    End Sub

    Private Sub MonthlyExpandedTaxListAlphalistReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01017.Click
        showForm(ewtreport, Me)
    End Sub

    Private Sub ExcelReportsBIRFormsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01014.Click
        showForm(erbirforms, Me)
    End Sub

    Private Sub FixedAssetAccountReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC01009.Click
        showForm(fixedassetreport, Me)
    End Sub

    Private Sub EncryptDecryptToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        showForm(encrypt_decrypt, Me)
    End Sub

    Private Sub AllocationSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllocationSetupToolStripMenuItem.Click
        showForm(allocation, Me)
    End Sub

    Private Sub BankToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankToolStripMenuItem.Click
        showForm(bank, Me)
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        showForm(department, Me)
    End Sub

    Private Sub ProjectSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectSetupToolStripMenuItem.Click
        showForm(project, Me)
    End Sub

    Private Sub TermsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TermsToolStripMenuItem.Click
        showForm(terms, Me)
    End Sub

    Private Sub JsonToolStripMenuItem_Click(sender As Object, e As EventArgs)
        showForm(jsontest, Me)
    End Sub

    Private Sub StrDesignToolStripMenuItem_Click(sender As Object, e As EventArgs)
        strdesign.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim flag = MsgBox("Are you sure to Logout?", MsgBoxStyle.YesNo, "Logout")
        If flag = MsgBoxResult.Yes Then
            MenuStrip1.Visible = False
            login.ShowDialog()
        End If
    End Sub

    Private Sub QiutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QiutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AgingRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00906.Click
        showForm(agingrange, Me)
    End Sub

    Private Sub DatabaseConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00909.Click
        showForm(connectionsettings, Me)
    End Sub

    Private Sub BookCodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookCodesToolStripMenuItem.Click
        showForm(Book, Me)
    End Sub

    Private Sub JournalBookCodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00911.Click
        showForm(jbookssetup, Me)
    End Sub

    Private Sub FilterCodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterCodesToolStripMenuItem.Click
        showForm(filtercodessetup, Me)
    End Sub

    Private Sub UserAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00903.Click
        showForm(usermanagement, Me)
    End Sub

    Private Sub PasswordRecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00904.Click
        showForm(passwordrecovery, Me)
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00905.Click
        showForm(changepassword, Me)
    End Sub

    Private Sub StageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00819.Click
        showForm(stagesetup, Me)
    End Sub

    Private Sub UserSignatoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00912.Click
        showForm(listofmodules, Me)
    End Sub

    Private Sub AccountProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACC00901.Click
        showForm(userprofile, Me)
    End Sub

    Private Sub ACC00812_Click(sender As Object, e As EventArgs) Handles ACC00812.Click
        showForm(industry, Me)
    End Sub

    Private Sub ACC00803_Click(sender As Object, e As EventArgs) Handles ACC00803.Click
        showForm(category, Me)
    End Sub

    Private Sub ACC00810_Click(sender As Object, e As EventArgs) Handles ACC00810.Click
        showForm(GeneralLibrary, Me)
    End Sub

    Private Sub ACC00908_Click(sender As Object, e As EventArgs) Handles ACC00908.Click
        showForm(companyconfig, Me)
    End Sub

    Private Sub ACC01018_Click(sender As Object, e As EventArgs) Handles ACC01018.Click
        showForm(printingbooks, Me)
    End Sub
End Class
