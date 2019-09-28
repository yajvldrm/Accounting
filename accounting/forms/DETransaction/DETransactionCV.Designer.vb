<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DETransactionCV
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Trans_idLabel As System.Windows.Forms.Label
        Dim Trans_noLabel As System.Windows.Forms.Label
        Dim Trans_dateLabel As System.Windows.Forms.Label
        Dim Book_idLabel As System.Windows.Forms.Label
        Dim Journal_idLabel As System.Windows.Forms.Label
        Dim General_idLabel As System.Windows.Forms.Label
        Dim Currency_idLabel As System.Windows.Forms.Label
        Dim Exchange_rateLabel As System.Windows.Forms.Label
        Dim Based_rateLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Amount_basedLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Allocation_idLabel As System.Windows.Forms.Label
        Dim Department_idLabel As System.Windows.Forms.Label
        Dim Project_idLabel As System.Windows.Forms.Label
        Dim Account_idLabel As System.Windows.Forms.Label
        Dim Based_rateLabel1 As System.Windows.Forms.Label
        Dim Exchange_rateLabel1 As System.Windows.Forms.Label
        Dim Currency_idLabel1 As System.Windows.Forms.Label
        Dim Line_remarksLabel As System.Windows.Forms.Label
        Dim DebitLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Dim Debit_basedLabel As System.Windows.Forms.Label
        Dim Credit_basedLabel As System.Windows.Forms.Label
        Dim Terms_idLabel As System.Windows.Forms.Label
        Dim General_codeLabel As System.Windows.Forms.Label
        Dim Ref_trans_noLabel As System.Windows.Forms.Label
        Dim NodaysLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DETransactionCV))
        Me.imgLock = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TransactionSet = New accounting.TransactionSet()
        Me.trans_header_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.trans_header_ta = New accounting.TransactionSetTableAdapters.get_trans_headerTableAdapter()
        Me.dgMain = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coltrans_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltrans_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltrans_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbook_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljournal_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexchange_rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbased_rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamount_based = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colposted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlHeader = New DevExpress.XtraEditors.PanelControl()
        Me.txtCurrencyName = New DevExpress.XtraEditors.TextEdit()
        Me.txtGeneralName = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtExchangeRate = New DevExpress.XtraEditors.TextEdit()
        Me.txtBasedRate = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmountBased = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmountWord = New DevExpress.XtraEditors.MemoEdit()
        Me.txtParticular = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCurrencyID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.currency_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEFileSetupSet = New accounting.DEFileSetupSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcurrency_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleffectivitydate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexchange_rate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbased_rate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtGeneralID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.general_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEFSTableSet = New accounting.DEFSTableSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colgeneral_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colattention = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcontact_person = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltel_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfax_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcell_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcategory_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail_add = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwebsite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcredit_amt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnodays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbillto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbilladd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbilladd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbilladd3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbilladd4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrawing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colspecs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbusiness_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepartment_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchecker = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colapprover = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colport_area = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colindustry_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrdo_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_name_bir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTransNo = New DevExpress.XtraEditors.TextEdit()
        Me.Trans_idSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Book_idSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Journal_idSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.currency_ta = New accounting.DEFileSetupSetTableAdapters.get_currency_rateTableAdapter()
        Me.btnSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.trans_jbooks_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.trans_jbooks_ta = New accounting.TransactionSetTableAdapters.get_trans_jbooksTableAdapter()
        Me.dgDet = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colisInputted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljbooks_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltrans_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproject_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepartment_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colallocation_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colaccount_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_id2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexchange_rate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbased_rate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldebit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldebit_based = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcredit_based = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_id2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colref_jbooks_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colline_remarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljbooks_id_tmp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproject_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproject_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepartment_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepartment_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colallocation_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colallocation_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colaccount_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colaccount_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalidation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colref_trans_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colref_book_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colref_journal_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colref_book_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colref_book_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colref_journal_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colref_journal_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsi_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrr_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpo_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldr_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnodays1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljbooks_terms_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coloffset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colminimum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.pnlDet = New DevExpress.XtraEditors.PanelControl()
        Me.txtGeneralNameDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtAccountNameDet = New DevExpress.XtraEditors.TextEdit()
        Me.chart_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRefTransNoDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtBasedRateDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtExchangeRateDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtLineRemarksDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtAccountIDDet = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colaccount_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colaccount_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colaccount_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchart_class_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalidation1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtProjectIDDet = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.project_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colproject_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproject_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproject_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDepartmentDet = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.department_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldepartment_id3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepartment_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepartment_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepartment_id_head = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAllocationDet = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.allocation_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colallocation_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colallocation_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colallocation_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDebitDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreditDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtDebitBasedDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreditBasedDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtNodaysDet = New DevExpress.XtraEditors.TextEdit()
        Me.txtTermsIDDet = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.terms_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colterms_id3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnodays3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfixed_day = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtGeneralIDDet = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colgeneral_id3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_code2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_name2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_type1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colattention1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcontact_person1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colposition1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltel_no1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfax_no1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcell_no1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcategory_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltin1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail_add1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwebsite1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms_id2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcredit_amt1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnodays2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvat1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbillto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbilladd11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbilladd21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbilladd31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbilladd41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrawing1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colspecs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbusiness_type1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepartment_id2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchecker1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colapprover1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colport_area1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colindustry_id1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrdo_code1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral_name_bir1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCurrencyIDDet = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcurrency_id3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleffectivitydate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexchange_rate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbased_rate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_code2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_name2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNotSave = New DevExpress.XtraEditors.SimpleButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInsert = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNotOK = New DevExpress.XtraEditors.SimpleButton()
        Me.chart_ta = New accounting.DEFSTableSetTableAdapters.lib_erp_chartTableAdapter()
        Me.general_ta = New accounting.DEFSTableSetTableAdapters.lib_erp_generalTableAdapter()
        Me.project_ta = New accounting.DEFSTableSetTableAdapters.lib_erp_projectTableAdapter()
        Me.department_ta = New accounting.DEFSTableSetTableAdapters.lib_erp_departmentTableAdapter()
        Me.allocation_ta = New accounting.DEFSTableSetTableAdapters.lib_erp_allocationTableAdapter()
        Me.terms_ta = New accounting.DEFSTableSetTableAdapters.lib_erp_termsTableAdapter()
        Trans_idLabel = New System.Windows.Forms.Label()
        Trans_noLabel = New System.Windows.Forms.Label()
        Trans_dateLabel = New System.Windows.Forms.Label()
        Book_idLabel = New System.Windows.Forms.Label()
        Journal_idLabel = New System.Windows.Forms.Label()
        General_idLabel = New System.Windows.Forms.Label()
        Currency_idLabel = New System.Windows.Forms.Label()
        Exchange_rateLabel = New System.Windows.Forms.Label()
        Based_rateLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        Amount_basedLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Allocation_idLabel = New System.Windows.Forms.Label()
        Department_idLabel = New System.Windows.Forms.Label()
        Project_idLabel = New System.Windows.Forms.Label()
        Account_idLabel = New System.Windows.Forms.Label()
        Based_rateLabel1 = New System.Windows.Forms.Label()
        Exchange_rateLabel1 = New System.Windows.Forms.Label()
        Currency_idLabel1 = New System.Windows.Forms.Label()
        Line_remarksLabel = New System.Windows.Forms.Label()
        DebitLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
        Debit_basedLabel = New System.Windows.Forms.Label()
        Credit_basedLabel = New System.Windows.Forms.Label()
        Terms_idLabel = New System.Windows.Forms.Label()
        General_codeLabel = New System.Windows.Forms.Label()
        Ref_trans_noLabel = New System.Windows.Forms.Label()
        NodaysLabel = New System.Windows.Forms.Label()
        CType(Me.imgLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_header_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.txtCurrencyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGeneralName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExchangeRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBasedRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountBased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParticular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrencyID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currency_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFileSetupSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGeneralID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.general_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFSTableSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trans_idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_jbooks_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDet.SuspendLayout()
        CType(Me.txtGeneralNameDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountNameDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefTransNoDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBasedRateDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExchangeRateDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLineRemarksDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountIDDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectIDDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.project_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartmentDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.department_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllocationDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allocation_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebitDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebitBasedDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditBasedDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNodaysDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTermsIDDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.terms_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGeneralIDDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrencyIDDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Trans_idLabel
        '
        Trans_idLabel.AutoSize = True
        Trans_idLabel.Location = New System.Drawing.Point(283, 14)
        Trans_idLabel.Name = "Trans_idLabel"
        Trans_idLabel.Size = New System.Drawing.Size(47, 13)
        Trans_idLabel.TabIndex = 0
        Trans_idLabel.Text = "trans id:"
        '
        'Trans_noLabel
        '
        Trans_noLabel.AutoSize = True
        Trans_noLabel.Location = New System.Drawing.Point(22, 8)
        Trans_noLabel.Name = "Trans_noLabel"
        Trans_noLabel.Size = New System.Drawing.Size(66, 13)
        Trans_noLabel.TabIndex = 2
        Trans_noLabel.Text = "Voucher No."
        '
        'Trans_dateLabel
        '
        Trans_dateLabel.AutoSize = True
        Trans_dateLabel.Location = New System.Drawing.Point(300, 8)
        Trans_dateLabel.Name = "Trans_dateLabel"
        Trans_dateLabel.Size = New System.Drawing.Size(30, 13)
        Trans_dateLabel.TabIndex = 4
        Trans_dateLabel.Text = "Date"
        '
        'Book_idLabel
        '
        Book_idLabel.AutoSize = True
        Book_idLabel.Location = New System.Drawing.Point(442, 14)
        Book_idLabel.Name = "Book_idLabel"
        Book_idLabel.Size = New System.Drawing.Size(45, 13)
        Book_idLabel.TabIndex = 6
        Book_idLabel.Text = "book id:"
        '
        'Journal_idLabel
        '
        Journal_idLabel.AutoSize = True
        Journal_idLabel.Location = New System.Drawing.Point(599, 14)
        Journal_idLabel.Name = "Journal_idLabel"
        Journal_idLabel.Size = New System.Drawing.Size(55, 13)
        Journal_idLabel.TabIndex = 8
        Journal_idLabel.Text = "journal id:"
        '
        'General_idLabel
        '
        General_idLabel.AutoSize = True
        General_idLabel.Location = New System.Drawing.Point(51, 29)
        General_idLabel.Name = "General_idLabel"
        General_idLabel.Size = New System.Drawing.Size(37, 13)
        General_idLabel.TabIndex = 10
        General_idLabel.Text = "Payee"
        '
        'Currency_idLabel
        '
        Currency_idLabel.AutoSize = True
        Currency_idLabel.Location = New System.Drawing.Point(37, 50)
        Currency_idLabel.Name = "Currency_idLabel"
        Currency_idLabel.Size = New System.Drawing.Size(51, 13)
        Currency_idLabel.TabIndex = 12
        Currency_idLabel.Text = "Currency"
        '
        'Exchange_rateLabel
        '
        Exchange_rateLabel.AutoSize = True
        Exchange_rateLabel.Location = New System.Drawing.Point(200, 71)
        Exchange_rateLabel.Name = "Exchange_rateLabel"
        Exchange_rateLabel.Size = New System.Drawing.Size(80, 13)
        Exchange_rateLabel.TabIndex = 14
        Exchange_rateLabel.Text = "Exchange Rate"
        '
        'Based_rateLabel
        '
        Based_rateLabel.AutoSize = True
        Based_rateLabel.Location = New System.Drawing.Point(392, 71)
        Based_rateLabel.Name = "Based_rateLabel"
        Based_rateLabel.Size = New System.Drawing.Size(62, 13)
        Based_rateLabel.TabIndex = 16
        Based_rateLabel.Text = "Based Rate"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(44, 71)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(44, 13)
        AmountLabel.TabIndex = 18
        AmountLabel.Text = "Amount"
        '
        'Amount_basedLabel
        '
        Amount_basedLabel.AutoSize = True
        Amount_basedLabel.Location = New System.Drawing.Point(566, 71)
        Amount_basedLabel.Name = "Amount_basedLabel"
        Amount_basedLabel.Size = New System.Drawing.Size(76, 13)
        Amount_basedLabel.TabIndex = 20
        Amount_basedLabel.Text = "Based Amount"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(31, 141)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(57, 13)
        DescriptionLabel.TabIndex = 22
        DescriptionLabel.Text = "Particulars"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(33, 90)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(55, 26)
        Label2.TabIndex = 32
        Label2.Text = "Amount in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Words"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Allocation_idLabel
        '
        Allocation_idLabel.AutoSize = True
        Allocation_idLabel.Location = New System.Drawing.Point(530, 71)
        Allocation_idLabel.Name = "Allocation_idLabel"
        Allocation_idLabel.Size = New System.Drawing.Size(53, 13)
        Allocation_idLabel.TabIndex = 30
        Allocation_idLabel.Text = "Allocation"
        '
        'Department_idLabel
        '
        Department_idLabel.AutoSize = True
        Department_idLabel.Location = New System.Drawing.Point(278, 71)
        Department_idLabel.Name = "Department_idLabel"
        Department_idLabel.Size = New System.Drawing.Size(64, 13)
        Department_idLabel.TabIndex = 28
        Department_idLabel.Text = "Department"
        '
        'Project_idLabel
        '
        Project_idLabel.AutoSize = True
        Project_idLabel.Location = New System.Drawing.Point(49, 71)
        Project_idLabel.Name = "Project_idLabel"
        Project_idLabel.Size = New System.Drawing.Size(41, 13)
        Project_idLabel.TabIndex = 26
        Project_idLabel.Text = "Project"
        '
        'Account_idLabel
        '
        Account_idLabel.AutoSize = True
        Account_idLabel.Location = New System.Drawing.Point(44, 50)
        Account_idLabel.Name = "Account_idLabel"
        Account_idLabel.Size = New System.Drawing.Size(46, 13)
        Account_idLabel.TabIndex = 24
        Account_idLabel.Text = "Account"
        '
        'Based_rateLabel1
        '
        Based_rateLabel1.AutoSize = True
        Based_rateLabel1.Location = New System.Drawing.Point(521, 28)
        Based_rateLabel1.Name = "Based_rateLabel1"
        Based_rateLabel1.Size = New System.Drawing.Size(62, 13)
        Based_rateLabel1.TabIndex = 22
        Based_rateLabel1.Text = "Based Rate"
        '
        'Exchange_rateLabel1
        '
        Exchange_rateLabel1.AutoSize = True
        Exchange_rateLabel1.Location = New System.Drawing.Point(262, 29)
        Exchange_rateLabel1.Name = "Exchange_rateLabel1"
        Exchange_rateLabel1.Size = New System.Drawing.Size(80, 13)
        Exchange_rateLabel1.TabIndex = 20
        Exchange_rateLabel1.Text = "Exchange Rate"
        '
        'Currency_idLabel1
        '
        Currency_idLabel1.AutoSize = True
        Currency_idLabel1.Location = New System.Drawing.Point(39, 29)
        Currency_idLabel1.Name = "Currency_idLabel1"
        Currency_idLabel1.Size = New System.Drawing.Size(51, 13)
        Currency_idLabel1.TabIndex = 18
        Currency_idLabel1.Text = "Currency"
        '
        'Line_remarksLabel
        '
        Line_remarksLabel.AutoSize = True
        Line_remarksLabel.Location = New System.Drawing.Point(20, 8)
        Line_remarksLabel.Name = "Line_remarksLabel"
        Line_remarksLabel.Size = New System.Drawing.Size(70, 13)
        Line_remarksLabel.TabIndex = 16
        Line_remarksLabel.Text = "Line Remarks"
        '
        'DebitLabel
        '
        DebitLabel.AutoSize = True
        DebitLabel.Location = New System.Drawing.Point(58, 92)
        DebitLabel.Name = "DebitLabel"
        DebitLabel.Size = New System.Drawing.Size(32, 13)
        DebitLabel.TabIndex = 31
        DebitLabel.Text = "Debit"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(54, 113)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(36, 13)
        CreditLabel.TabIndex = 32
        CreditLabel.Text = "Credit"
        '
        'Debit_basedLabel
        '
        Debit_basedLabel.AutoSize = True
        Debit_basedLabel.Location = New System.Drawing.Point(278, 92)
        Debit_basedLabel.Name = "Debit_basedLabel"
        Debit_basedLabel.Size = New System.Drawing.Size(64, 13)
        Debit_basedLabel.TabIndex = 33
        Debit_basedLabel.Text = "Debit Based"
        '
        'Credit_basedLabel
        '
        Credit_basedLabel.AutoSize = True
        Credit_basedLabel.Location = New System.Drawing.Point(274, 113)
        Credit_basedLabel.Name = "Credit_basedLabel"
        Credit_basedLabel.Size = New System.Drawing.Size(68, 13)
        Credit_basedLabel.TabIndex = 34
        Credit_basedLabel.Text = "Credit Based"
        '
        'Terms_idLabel
        '
        Terms_idLabel.AutoSize = True
        Terms_idLabel.Location = New System.Drawing.Point(547, 92)
        Terms_idLabel.Name = "Terms_idLabel"
        Terms_idLabel.Size = New System.Drawing.Size(36, 13)
        Terms_idLabel.TabIndex = 35
        Terms_idLabel.Text = "Terms"
        '
        'General_codeLabel
        '
        General_codeLabel.AutoSize = True
        General_codeLabel.Location = New System.Drawing.Point(40, 134)
        General_codeLabel.Name = "General_codeLabel"
        General_codeLabel.Size = New System.Drawing.Size(50, 13)
        General_codeLabel.TabIndex = 36
        General_codeLabel.Text = "Gen. Ref"
        '
        'Ref_trans_noLabel
        '
        Ref_trans_noLabel.AutoSize = True
        Ref_trans_noLabel.Location = New System.Drawing.Point(41, 155)
        Ref_trans_noLabel.Name = "Ref_trans_noLabel"
        Ref_trans_noLabel.Size = New System.Drawing.Size(49, 13)
        Ref_trans_noLabel.TabIndex = 37
        Ref_trans_noLabel.Text = "D.N. Ref"
        '
        'NodaysLabel
        '
        NodaysLabel.AutoSize = True
        NodaysLabel.Location = New System.Drawing.Point(552, 113)
        NodaysLabel.Name = "NodaysLabel"
        NodaysLabel.Size = New System.Drawing.Size(31, 13)
        NodaysLabel.TabIndex = 38
        NodaysLabel.Text = "Days"
        '
        'imgLock
        '
        Me.imgLock.Image = Global.accounting.My.Resources.Resources.lock
        Me.imgLock.Location = New System.Drawing.Point(184, 9)
        Me.imgLock.Name = "imgLock"
        Me.imgLock.Size = New System.Drawing.Size(25, 25)
        Me.imgLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLock.TabIndex = 355
        Me.imgLock.TabStop = False
        Me.imgLock.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(215, 14)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 20)
        Me.lblStatus.TabIndex = 353
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "Check Voucher"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 1)
        Me.Panel1.TabIndex = 363
        '
        'TransactionSet
        '
        Me.TransactionSet.DataSetName = "TransactionSet"
        Me.TransactionSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'trans_header_bs
        '
        Me.trans_header_bs.DataMember = "get_trans_header"
        Me.trans_header_bs.DataSource = Me.TransactionSet
        '
        'trans_header_ta
        '
        Me.trans_header_ta.ClearBeforeFill = True
        '
        'dgMain
        '
        Me.dgMain.DataSource = Me.trans_header_bs
        Me.dgMain.Location = New System.Drawing.Point(12, 45)
        Me.dgMain.MainView = Me.GridView1
        Me.dgMain.Name = "dgMain"
        Me.dgMain.Size = New System.Drawing.Size(200, 584)
        Me.dgMain.TabIndex = 365
        Me.dgMain.UseDisabledStatePainter = False
        Me.dgMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coltrans_id, Me.coltrans_no, Me.coltrans_date, Me.colbook_id, Me.coljournal_id, Me.colgeneral_id, Me.colcurrency_id, Me.colexchange_rate, Me.colbased_rate, Me.colamount, Me.colamount_based, Me.coldescription, Me.colposted, Me.colstatus})
        Me.GridView1.GridControl = Me.dgMain
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'coltrans_id
        '
        Me.coltrans_id.FieldName = "trans_id"
        Me.coltrans_id.Name = "coltrans_id"
        '
        'coltrans_no
        '
        Me.coltrans_no.Caption = "Trans No"
        Me.coltrans_no.FieldName = "trans_no"
        Me.coltrans_no.Name = "coltrans_no"
        Me.coltrans_no.Visible = True
        Me.coltrans_no.VisibleIndex = 0
        Me.coltrans_no.Width = 100
        '
        'coltrans_date
        '
        Me.coltrans_date.Caption = "Date"
        Me.coltrans_date.FieldName = "trans_date"
        Me.coltrans_date.Name = "coltrans_date"
        Me.coltrans_date.Visible = True
        Me.coltrans_date.VisibleIndex = 1
        Me.coltrans_date.Width = 65
        '
        'colbook_id
        '
        Me.colbook_id.FieldName = "book_id"
        Me.colbook_id.Name = "colbook_id"
        '
        'coljournal_id
        '
        Me.coljournal_id.FieldName = "journal_id"
        Me.coljournal_id.Name = "coljournal_id"
        '
        'colgeneral_id
        '
        Me.colgeneral_id.FieldName = "general_id"
        Me.colgeneral_id.Name = "colgeneral_id"
        '
        'colcurrency_id
        '
        Me.colcurrency_id.FieldName = "currency_id"
        Me.colcurrency_id.Name = "colcurrency_id"
        '
        'colexchange_rate
        '
        Me.colexchange_rate.FieldName = "exchange_rate"
        Me.colexchange_rate.Name = "colexchange_rate"
        '
        'colbased_rate
        '
        Me.colbased_rate.FieldName = "based_rate"
        Me.colbased_rate.Name = "colbased_rate"
        '
        'colamount
        '
        Me.colamount.FieldName = "amount"
        Me.colamount.Name = "colamount"
        '
        'colamount_based
        '
        Me.colamount_based.FieldName = "amount_based"
        Me.colamount_based.Name = "colamount_based"
        '
        'coldescription
        '
        Me.coldescription.FieldName = "description"
        Me.coldescription.Name = "coldescription"
        '
        'colposted
        '
        Me.colposted.FieldName = "posted"
        Me.colposted.Name = "colposted"
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Label2)
        Me.pnlHeader.Controls.Add(Me.txtCurrencyName)
        Me.pnlHeader.Controls.Add(Me.txtGeneralName)
        Me.pnlHeader.Controls.Add(Trans_noLabel)
        Me.pnlHeader.Controls.Add(Trans_dateLabel)
        Me.pnlHeader.Controls.Add(Me.txtTransDate)
        Me.pnlHeader.Controls.Add(General_idLabel)
        Me.pnlHeader.Controls.Add(Currency_idLabel)
        Me.pnlHeader.Controls.Add(Exchange_rateLabel)
        Me.pnlHeader.Controls.Add(Based_rateLabel)
        Me.pnlHeader.Controls.Add(AmountLabel)
        Me.pnlHeader.Controls.Add(Amount_basedLabel)
        Me.pnlHeader.Controls.Add(DescriptionLabel)
        Me.pnlHeader.Controls.Add(Me.txtExchangeRate)
        Me.pnlHeader.Controls.Add(Me.txtBasedRate)
        Me.pnlHeader.Controls.Add(Me.txtAmount)
        Me.pnlHeader.Controls.Add(Me.txtAmountBased)
        Me.pnlHeader.Controls.Add(Me.txtAmountWord)
        Me.pnlHeader.Controls.Add(Me.txtParticular)
        Me.pnlHeader.Controls.Add(Me.txtCurrencyID)
        Me.pnlHeader.Controls.Add(Me.txtGeneralID)
        Me.pnlHeader.Controls.Add(Me.txtTransNo)
        Me.pnlHeader.Location = New System.Drawing.Point(218, 74)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(770, 195)
        Me.pnlHeader.TabIndex = 371
        Me.pnlHeader.UseDisabledStatePainter = False
        '
        'txtCurrencyName
        '
        Me.txtCurrencyName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "currency_name", True))
        Me.txtCurrencyName.Enabled = False
        Me.txtCurrencyName.Location = New System.Drawing.Point(300, 47)
        Me.txtCurrencyName.Name = "txtCurrencyName"
        Me.txtCurrencyName.Size = New System.Drawing.Size(448, 20)
        Me.txtCurrencyName.TabIndex = 31
        '
        'txtGeneralName
        '
        Me.txtGeneralName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "general_name", True))
        Me.txtGeneralName.Enabled = False
        Me.txtGeneralName.Location = New System.Drawing.Point(300, 26)
        Me.txtGeneralName.Name = "txtGeneralName"
        Me.txtGeneralName.Size = New System.Drawing.Size(448, 20)
        Me.txtGeneralName.TabIndex = 29
        '
        'txtTransDate
        '
        Me.txtTransDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "trans_date", True))
        Me.txtTransDate.EditValue = Nothing
        Me.txtTransDate.Location = New System.Drawing.Point(336, 5)
        Me.txtTransDate.Name = "txtTransDate"
        Me.txtTransDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTransDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTransDate.Size = New System.Drawing.Size(100, 20)
        Me.txtTransDate.TabIndex = 5
        '
        'txtExchangeRate
        '
        Me.txtExchangeRate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "exchange_rate", True))
        Me.txtExchangeRate.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExchangeRate.Location = New System.Drawing.Point(286, 68)
        Me.txtExchangeRate.Name = "txtExchangeRate"
        Me.txtExchangeRate.Properties.DisplayFormat.FormatString = "n4"
        Me.txtExchangeRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRate.Properties.EditFormat.FormatString = "n4"
        Me.txtExchangeRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtExchangeRate.Properties.Mask.EditMask = "n4"
        Me.txtExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExchangeRate.Size = New System.Drawing.Size(100, 20)
        Me.txtExchangeRate.TabIndex = 15
        '
        'txtBasedRate
        '
        Me.txtBasedRate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "based_rate", True))
        Me.txtBasedRate.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBasedRate.Location = New System.Drawing.Point(460, 68)
        Me.txtBasedRate.Name = "txtBasedRate"
        Me.txtBasedRate.Properties.DisplayFormat.FormatString = "n4"
        Me.txtBasedRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRate.Properties.EditFormat.FormatString = "n4"
        Me.txtBasedRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtBasedRate.Properties.Mask.EditMask = "n4"
        Me.txtBasedRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBasedRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBasedRate.Size = New System.Drawing.Size(100, 20)
        Me.txtBasedRate.TabIndex = 17
        '
        'txtAmount
        '
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "amount", True))
        Me.txtAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(94, 68)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.DisplayFormat.FormatString = "n4"
        Me.txtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.EditFormat.FormatString = "n4"
        Me.txtAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtAmount.Properties.Mask.EditMask = "n4"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 19
        '
        'txtAmountBased
        '
        Me.txtAmountBased.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "amount_based", True))
        Me.txtAmountBased.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAmountBased.Enabled = False
        Me.txtAmountBased.Location = New System.Drawing.Point(648, 68)
        Me.txtAmountBased.Name = "txtAmountBased"
        Me.txtAmountBased.Properties.DisplayFormat.FormatString = "n4"
        Me.txtAmountBased.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountBased.Properties.EditFormat.FormatString = "n4"
        Me.txtAmountBased.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountBased.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtAmountBased.Properties.Mask.EditMask = "n4"
        Me.txtAmountBased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountBased.Properties.Name = "txtAmountBased"
        Me.txtAmountBased.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmountBased.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountBased.TabIndex = 21
        '
        'txtAmountWord
        '
        Me.txtAmountWord.Enabled = False
        Me.txtAmountWord.Location = New System.Drawing.Point(94, 89)
        Me.txtAmountWord.Name = "txtAmountWord"
        Me.txtAmountWord.Size = New System.Drawing.Size(654, 50)
        Me.txtAmountWord.TabIndex = 33
        '
        'txtParticular
        '
        Me.txtParticular.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "description", True))
        Me.txtParticular.Location = New System.Drawing.Point(94, 140)
        Me.txtParticular.Name = "txtParticular"
        Me.txtParticular.Size = New System.Drawing.Size(654, 50)
        Me.txtParticular.TabIndex = 23
        '
        'txtCurrencyID
        '
        Me.txtCurrencyID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "currency_id", True))
        Me.txtCurrencyID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCurrencyID.Location = New System.Drawing.Point(94, 47)
        Me.txtCurrencyID.Name = "txtCurrencyID"
        Me.txtCurrencyID.Properties.AutoHeight = False
        Me.txtCurrencyID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCurrencyID.Properties.DataSource = Me.currency_bs
        Me.txtCurrencyID.Properties.DisplayMember = "currency_name"
        Me.txtCurrencyID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtCurrencyID.Properties.NullText = ""
        Me.txtCurrencyID.Properties.ValueMember = "currency_id"
        Me.txtCurrencyID.Properties.View = Me.GridLookUpEdit1View
        Me.txtCurrencyID.Size = New System.Drawing.Size(200, 20)
        Me.txtCurrencyID.TabIndex = 13
        '
        'currency_bs
        '
        Me.currency_bs.DataMember = "get_currency_rate"
        Me.currency_bs.DataSource = Me.DEFileSetupSet
        '
        'DEFileSetupSet
        '
        Me.DEFileSetupSet.DataSetName = "DEFileSetupSet"
        Me.DEFileSetupSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcurrency_id1, Me.coleffectivitydate, Me.colexchange_rate1, Me.colbased_rate1, Me.colcurrency_code, Me.colcurrency_name})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsBehavior.Editable = False
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colcurrency_id1
        '
        Me.colcurrency_id1.FieldName = "currency_id"
        Me.colcurrency_id1.Name = "colcurrency_id1"
        '
        'coleffectivitydate
        '
        Me.coleffectivitydate.FieldName = "effectivitydate"
        Me.coleffectivitydate.Name = "coleffectivitydate"
        '
        'colexchange_rate1
        '
        Me.colexchange_rate1.FieldName = "exchange_rate"
        Me.colexchange_rate1.Name = "colexchange_rate1"
        '
        'colbased_rate1
        '
        Me.colbased_rate1.FieldName = "based_rate"
        Me.colbased_rate1.Name = "colbased_rate1"
        '
        'colcurrency_code
        '
        Me.colcurrency_code.Caption = "Code"
        Me.colcurrency_code.FieldName = "currency_code"
        Me.colcurrency_code.Name = "colcurrency_code"
        Me.colcurrency_code.Visible = True
        Me.colcurrency_code.VisibleIndex = 0
        Me.colcurrency_code.Width = 100
        '
        'colcurrency_name
        '
        Me.colcurrency_name.Caption = "Name"
        Me.colcurrency_name.FieldName = "currency_name"
        Me.colcurrency_name.Name = "colcurrency_name"
        Me.colcurrency_name.Visible = True
        Me.colcurrency_name.VisibleIndex = 1
        Me.colcurrency_name.Width = 200
        '
        'txtGeneralID
        '
        Me.txtGeneralID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "general_id", True))
        Me.txtGeneralID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGeneralID.Location = New System.Drawing.Point(94, 26)
        Me.txtGeneralID.Name = "txtGeneralID"
        Me.txtGeneralID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGeneralID.Properties.DataSource = Me.general_bs
        Me.txtGeneralID.Properties.DisplayMember = "general_code"
        Me.txtGeneralID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtGeneralID.Properties.NullText = ""
        Me.txtGeneralID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtGeneralID.Properties.ValueMember = "general_id"
        Me.txtGeneralID.Properties.View = Me.GridView2
        Me.txtGeneralID.Size = New System.Drawing.Size(200, 20)
        Me.txtGeneralID.TabIndex = 11
        '
        'general_bs
        '
        Me.general_bs.DataMember = "lib_erp_general"
        Me.general_bs.DataSource = Me.DEFSTableSet
        '
        'DEFSTableSet
        '
        Me.DEFSTableSet.DataSetName = "DEFSTableSet"
        Me.DEFSTableSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colgeneral_id1, Me.colgeneral_code, Me.colgeneral_name, Me.colgeneral_type, Me.coldate, Me.coladdress1, Me.coladdress2, Me.coladdress3, Me.coladdress4, Me.colattention, Me.colcontact_person, Me.colposition, Me.coltel_no, Me.colfax_no, Me.colcell_no, Me.colcategory_id, Me.coltin, Me.colemail_add, Me.colwebsite, Me.colterms_id, Me.colcredit_amt, Me.colnodays, Me.colremarks, Me.colvat, Me.colstatus1, Me.colbillto, Me.colbilladd1, Me.colbilladd2, Me.colbilladd3, Me.colbilladd4, Me.coldrawing, Me.colspecs, Me.colbusiness_type, Me.coldepartment_id, Me.colchecker, Me.colapprover, Me.colport_area, Me.colindustry_id, Me.colrdo_code, Me.colgeneral_name_bir})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colgeneral_id1
        '
        Me.colgeneral_id1.FieldName = "general_id"
        Me.colgeneral_id1.Name = "colgeneral_id1"
        '
        'colgeneral_code
        '
        Me.colgeneral_code.Caption = "Code"
        Me.colgeneral_code.FieldName = "general_code"
        Me.colgeneral_code.Name = "colgeneral_code"
        Me.colgeneral_code.Visible = True
        Me.colgeneral_code.VisibleIndex = 0
        Me.colgeneral_code.Width = 100
        '
        'colgeneral_name
        '
        Me.colgeneral_name.Caption = "Name"
        Me.colgeneral_name.FieldName = "general_name"
        Me.colgeneral_name.Name = "colgeneral_name"
        Me.colgeneral_name.Visible = True
        Me.colgeneral_name.VisibleIndex = 1
        Me.colgeneral_name.Width = 200
        '
        'colgeneral_type
        '
        Me.colgeneral_type.FieldName = "general_type"
        Me.colgeneral_type.Name = "colgeneral_type"
        '
        'coldate
        '
        Me.coldate.FieldName = "date"
        Me.coldate.Name = "coldate"
        '
        'coladdress1
        '
        Me.coladdress1.FieldName = "address1"
        Me.coladdress1.Name = "coladdress1"
        '
        'coladdress2
        '
        Me.coladdress2.FieldName = "address2"
        Me.coladdress2.Name = "coladdress2"
        '
        'coladdress3
        '
        Me.coladdress3.FieldName = "address3"
        Me.coladdress3.Name = "coladdress3"
        '
        'coladdress4
        '
        Me.coladdress4.FieldName = "address4"
        Me.coladdress4.Name = "coladdress4"
        '
        'colattention
        '
        Me.colattention.FieldName = "attention"
        Me.colattention.Name = "colattention"
        '
        'colcontact_person
        '
        Me.colcontact_person.FieldName = "contact_person"
        Me.colcontact_person.Name = "colcontact_person"
        '
        'colposition
        '
        Me.colposition.FieldName = "position"
        Me.colposition.Name = "colposition"
        '
        'coltel_no
        '
        Me.coltel_no.FieldName = "tel_no"
        Me.coltel_no.Name = "coltel_no"
        '
        'colfax_no
        '
        Me.colfax_no.FieldName = "fax_no"
        Me.colfax_no.Name = "colfax_no"
        '
        'colcell_no
        '
        Me.colcell_no.FieldName = "cell_no"
        Me.colcell_no.Name = "colcell_no"
        '
        'colcategory_id
        '
        Me.colcategory_id.FieldName = "category_id"
        Me.colcategory_id.Name = "colcategory_id"
        '
        'coltin
        '
        Me.coltin.FieldName = "tin"
        Me.coltin.Name = "coltin"
        '
        'colemail_add
        '
        Me.colemail_add.FieldName = "email_add"
        Me.colemail_add.Name = "colemail_add"
        '
        'colwebsite
        '
        Me.colwebsite.FieldName = "website"
        Me.colwebsite.Name = "colwebsite"
        '
        'colterms_id
        '
        Me.colterms_id.FieldName = "terms_id"
        Me.colterms_id.Name = "colterms_id"
        '
        'colcredit_amt
        '
        Me.colcredit_amt.FieldName = "credit_amt"
        Me.colcredit_amt.Name = "colcredit_amt"
        '
        'colnodays
        '
        Me.colnodays.FieldName = "nodays"
        Me.colnodays.Name = "colnodays"
        '
        'colremarks
        '
        Me.colremarks.FieldName = "remarks"
        Me.colremarks.Name = "colremarks"
        '
        'colvat
        '
        Me.colvat.FieldName = "vat"
        Me.colvat.Name = "colvat"
        '
        'colstatus1
        '
        Me.colstatus1.FieldName = "status"
        Me.colstatus1.Name = "colstatus1"
        '
        'colbillto
        '
        Me.colbillto.FieldName = "billto"
        Me.colbillto.Name = "colbillto"
        '
        'colbilladd1
        '
        Me.colbilladd1.FieldName = "billadd1"
        Me.colbilladd1.Name = "colbilladd1"
        '
        'colbilladd2
        '
        Me.colbilladd2.FieldName = "billadd2"
        Me.colbilladd2.Name = "colbilladd2"
        '
        'colbilladd3
        '
        Me.colbilladd3.FieldName = "billadd3"
        Me.colbilladd3.Name = "colbilladd3"
        '
        'colbilladd4
        '
        Me.colbilladd4.FieldName = "billadd4"
        Me.colbilladd4.Name = "colbilladd4"
        '
        'coldrawing
        '
        Me.coldrawing.FieldName = "drawing"
        Me.coldrawing.Name = "coldrawing"
        '
        'colspecs
        '
        Me.colspecs.FieldName = "specs"
        Me.colspecs.Name = "colspecs"
        '
        'colbusiness_type
        '
        Me.colbusiness_type.FieldName = "business_type"
        Me.colbusiness_type.Name = "colbusiness_type"
        '
        'coldepartment_id
        '
        Me.coldepartment_id.FieldName = "department_id"
        Me.coldepartment_id.Name = "coldepartment_id"
        '
        'colchecker
        '
        Me.colchecker.FieldName = "checker"
        Me.colchecker.Name = "colchecker"
        '
        'colapprover
        '
        Me.colapprover.FieldName = "approver"
        Me.colapprover.Name = "colapprover"
        '
        'colport_area
        '
        Me.colport_area.FieldName = "port_area"
        Me.colport_area.Name = "colport_area"
        '
        'colindustry_id
        '
        Me.colindustry_id.FieldName = "industry_id"
        Me.colindustry_id.Name = "colindustry_id"
        '
        'colrdo_code
        '
        Me.colrdo_code.FieldName = "rdo_code"
        Me.colrdo_code.Name = "colrdo_code"
        '
        'colgeneral_name_bir
        '
        Me.colgeneral_name_bir.FieldName = "general_name_bir"
        Me.colgeneral_name_bir.Name = "colgeneral_name_bir"
        '
        'txtTransNo
        '
        Me.txtTransNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "trans_no", True))
        Me.txtTransNo.Location = New System.Drawing.Point(94, 5)
        Me.txtTransNo.Name = "txtTransNo"
        Me.txtTransNo.Size = New System.Drawing.Size(200, 20)
        Me.txtTransNo.TabIndex = 3
        '
        'Trans_idSpinEdit
        '
        Me.Trans_idSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "trans_id", True))
        Me.Trans_idSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Trans_idSpinEdit.Enabled = False
        Me.Trans_idSpinEdit.Location = New System.Drawing.Point(336, 11)
        Me.Trans_idSpinEdit.Name = "Trans_idSpinEdit"
        Me.Trans_idSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Trans_idSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Trans_idSpinEdit.TabIndex = 1
        '
        'Book_idSpinEdit
        '
        Me.Book_idSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "book_id", True))
        Me.Book_idSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Book_idSpinEdit.Enabled = False
        Me.Book_idSpinEdit.Location = New System.Drawing.Point(493, 11)
        Me.Book_idSpinEdit.Name = "Book_idSpinEdit"
        Me.Book_idSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Book_idSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Book_idSpinEdit.TabIndex = 7
        '
        'Journal_idSpinEdit
        '
        Me.Journal_idSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_header_bs, "journal_id", True))
        Me.Journal_idSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Journal_idSpinEdit.Enabled = False
        Me.Journal_idSpinEdit.Location = New System.Drawing.Point(660, 11)
        Me.Journal_idSpinEdit.Name = "Journal_idSpinEdit"
        Me.Journal_idSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Journal_idSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Journal_idSpinEdit.TabIndex = 9
        '
        'currency_ta
        '
        Me.currency_ta.ClearBeforeFill = True
        '
        'btnSettings
        '
        Me.btnSettings.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSettings.ImageOptions.Image = CType(resources.GetObject("btnSettings.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSettings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSettings.Location = New System.Drawing.Point(945, 1)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(35, 35)
        Me.btnSettings.TabIndex = 372
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.ToolTip = "Settings"
        Me.btnSettings.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnSettings.ToolTipTitle = "Settings"
        '
        'trans_jbooks_bs
        '
        Me.trans_jbooks_bs.DataMember = "get_trans_jbooks"
        Me.trans_jbooks_bs.DataSource = Me.TransactionSet
        '
        'trans_jbooks_ta
        '
        Me.trans_jbooks_ta.ClearBeforeFill = True
        '
        'dgDet
        '
        Me.dgDet.DataSource = Me.trans_jbooks_bs
        Me.dgDet.Location = New System.Drawing.Point(219, 275)
        Me.dgDet.MainView = Me.GridView3
        Me.dgDet.Name = "dgDet"
        Me.dgDet.Size = New System.Drawing.Size(769, 120)
        Me.dgDet.TabIndex = 373
        Me.dgDet.UseDisabledStatePainter = False
        Me.dgDet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colisInputted, Me.coljbooks_id, Me.coltrans_id1, Me.colproject_id, Me.coldepartment_id1, Me.colallocation_id, Me.colaccount_id, Me.colcurrency_id2, Me.colexchange_rate2, Me.colbased_rate2, Me.coldebit, Me.colcredit, Me.coldebit_based, Me.colcredit_based, Me.colgeneral_id2, Me.colref_jbooks_id, Me.colline_remarks, Me.coldc, Me.coljbooks_id_tmp, Me.colproject_code, Me.colproject_name, Me.coldepartment_code, Me.coldepartment_name, Me.colallocation_code, Me.colallocation_name, Me.colaccount_code, Me.colaccount_name, Me.colvalidation, Me.colgeneral_code1, Me.colgeneral_name1, Me.colcurrency_code1, Me.colcurrency_name1, Me.colref_trans_no, Me.colref_book_id, Me.colref_journal_id, Me.colref_book_code, Me.colref_book_name, Me.colref_journal_code, Me.colref_journal_name, Me.colsi_no, Me.colrr_no, Me.colpo_no, Me.coldr_no, Me.colterms_id1, Me.colnodays1, Me.coljbooks_terms_id, Me.colterms_code, Me.colterms_name, Me.coloffset, Me.colminimum})
        Me.GridView3.GridControl = Me.dgDet
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsMenu.EnableColumnMenu = False
        Me.GridView3.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colisInputted
        '
        Me.colisInputted.FieldName = "isInputted"
        Me.colisInputted.Name = "colisInputted"
        '
        'coljbooks_id
        '
        Me.coljbooks_id.FieldName = "jbooks_id"
        Me.coljbooks_id.Name = "coljbooks_id"
        '
        'coltrans_id1
        '
        Me.coltrans_id1.FieldName = "trans_id"
        Me.coltrans_id1.Name = "coltrans_id1"
        '
        'colproject_id
        '
        Me.colproject_id.FieldName = "project_id"
        Me.colproject_id.Name = "colproject_id"
        '
        'coldepartment_id1
        '
        Me.coldepartment_id1.FieldName = "department_id"
        Me.coldepartment_id1.Name = "coldepartment_id1"
        '
        'colallocation_id
        '
        Me.colallocation_id.FieldName = "allocation_id"
        Me.colallocation_id.Name = "colallocation_id"
        '
        'colaccount_id
        '
        Me.colaccount_id.FieldName = "account_id"
        Me.colaccount_id.Name = "colaccount_id"
        '
        'colcurrency_id2
        '
        Me.colcurrency_id2.FieldName = "currency_id"
        Me.colcurrency_id2.Name = "colcurrency_id2"
        '
        'colexchange_rate2
        '
        Me.colexchange_rate2.FieldName = "exchange_rate"
        Me.colexchange_rate2.Name = "colexchange_rate2"
        '
        'colbased_rate2
        '
        Me.colbased_rate2.FieldName = "based_rate"
        Me.colbased_rate2.Name = "colbased_rate2"
        '
        'coldebit
        '
        Me.coldebit.FieldName = "debit"
        Me.coldebit.Name = "coldebit"
        '
        'colcredit
        '
        Me.colcredit.FieldName = "credit"
        Me.colcredit.Name = "colcredit"
        '
        'coldebit_based
        '
        Me.coldebit_based.Caption = "Debit Based"
        Me.coldebit_based.DisplayFormat.FormatString = "n4"
        Me.coldebit_based.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldebit_based.FieldName = "debit_based"
        Me.coldebit_based.Name = "coldebit_based"
        Me.coldebit_based.Visible = True
        Me.coldebit_based.VisibleIndex = 3
        Me.coldebit_based.Width = 66
        '
        'colcredit_based
        '
        Me.colcredit_based.Caption = "Credit Based"
        Me.colcredit_based.DisplayFormat.FormatString = "n4"
        Me.colcredit_based.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcredit_based.FieldName = "credit_based"
        Me.colcredit_based.Name = "colcredit_based"
        Me.colcredit_based.Visible = True
        Me.colcredit_based.VisibleIndex = 4
        Me.colcredit_based.Width = 66
        '
        'colgeneral_id2
        '
        Me.colgeneral_id2.FieldName = "general_id"
        Me.colgeneral_id2.Name = "colgeneral_id2"
        '
        'colref_jbooks_id
        '
        Me.colref_jbooks_id.FieldName = "ref_jbooks_id"
        Me.colref_jbooks_id.Name = "colref_jbooks_id"
        '
        'colline_remarks
        '
        Me.colline_remarks.FieldName = "line_remarks"
        Me.colline_remarks.Name = "colline_remarks"
        '
        'coldc
        '
        Me.coldc.FieldName = "dc"
        Me.coldc.Name = "coldc"
        '
        'coljbooks_id_tmp
        '
        Me.coljbooks_id_tmp.FieldName = "jbooks_id_tmp"
        Me.coljbooks_id_tmp.Name = "coljbooks_id_tmp"
        '
        'colproject_code
        '
        Me.colproject_code.FieldName = "project_code"
        Me.colproject_code.Name = "colproject_code"
        '
        'colproject_name
        '
        Me.colproject_name.FieldName = "project_name"
        Me.colproject_name.Name = "colproject_name"
        '
        'coldepartment_code
        '
        Me.coldepartment_code.FieldName = "department_code"
        Me.coldepartment_code.Name = "coldepartment_code"
        '
        'coldepartment_name
        '
        Me.coldepartment_name.FieldName = "department_name"
        Me.coldepartment_name.Name = "coldepartment_name"
        '
        'colallocation_code
        '
        Me.colallocation_code.FieldName = "allocation_code"
        Me.colallocation_code.Name = "colallocation_code"
        '
        'colallocation_name
        '
        Me.colallocation_name.FieldName = "allocation_name"
        Me.colallocation_name.Name = "colallocation_name"
        '
        'colaccount_code
        '
        Me.colaccount_code.Caption = "Account Code"
        Me.colaccount_code.FieldName = "account_code"
        Me.colaccount_code.Name = "colaccount_code"
        Me.colaccount_code.Visible = True
        Me.colaccount_code.VisibleIndex = 1
        Me.colaccount_code.Width = 79
        '
        'colaccount_name
        '
        Me.colaccount_name.Caption = "Account Name"
        Me.colaccount_name.FieldName = "account_name"
        Me.colaccount_name.Name = "colaccount_name"
        Me.colaccount_name.Visible = True
        Me.colaccount_name.VisibleIndex = 2
        Me.colaccount_name.Width = 161
        '
        'colvalidation
        '
        Me.colvalidation.FieldName = "validation"
        Me.colvalidation.Name = "colvalidation"
        '
        'colgeneral_code1
        '
        Me.colgeneral_code1.Caption = "General Code"
        Me.colgeneral_code1.FieldName = "general_code"
        Me.colgeneral_code1.Name = "colgeneral_code1"
        Me.colgeneral_code1.Visible = True
        Me.colgeneral_code1.VisibleIndex = 5
        Me.colgeneral_code1.Width = 79
        '
        'colgeneral_name1
        '
        Me.colgeneral_name1.Caption = "General Name"
        Me.colgeneral_name1.FieldName = "general_name"
        Me.colgeneral_name1.Name = "colgeneral_name1"
        Me.colgeneral_name1.Visible = True
        Me.colgeneral_name1.VisibleIndex = 6
        Me.colgeneral_name1.Width = 161
        '
        'colcurrency_code1
        '
        Me.colcurrency_code1.FieldName = "currency_code"
        Me.colcurrency_code1.Name = "colcurrency_code1"
        '
        'colcurrency_name1
        '
        Me.colcurrency_name1.FieldName = "currency_name"
        Me.colcurrency_name1.Name = "colcurrency_name1"
        '
        'colref_trans_no
        '
        Me.colref_trans_no.Caption = "DN Ref"
        Me.colref_trans_no.FieldName = "ref_trans_no"
        Me.colref_trans_no.Name = "colref_trans_no"
        Me.colref_trans_no.Visible = True
        Me.colref_trans_no.VisibleIndex = 7
        Me.colref_trans_no.Width = 99
        '
        'colref_book_id
        '
        Me.colref_book_id.FieldName = "ref_book_id"
        Me.colref_book_id.Name = "colref_book_id"
        '
        'colref_journal_id
        '
        Me.colref_journal_id.FieldName = "ref_journal_id"
        Me.colref_journal_id.Name = "colref_journal_id"
        '
        'colref_book_code
        '
        Me.colref_book_code.FieldName = "ref_book_code"
        Me.colref_book_code.Name = "colref_book_code"
        '
        'colref_book_name
        '
        Me.colref_book_name.FieldName = "ref_book_name"
        Me.colref_book_name.Name = "colref_book_name"
        '
        'colref_journal_code
        '
        Me.colref_journal_code.FieldName = "ref_journal_code"
        Me.colref_journal_code.Name = "colref_journal_code"
        '
        'colref_journal_name
        '
        Me.colref_journal_name.FieldName = "ref_journal_name"
        Me.colref_journal_name.Name = "colref_journal_name"
        '
        'colsi_no
        '
        Me.colsi_no.FieldName = "si_no"
        Me.colsi_no.Name = "colsi_no"
        '
        'colrr_no
        '
        Me.colrr_no.FieldName = "rr_no"
        Me.colrr_no.Name = "colrr_no"
        '
        'colpo_no
        '
        Me.colpo_no.FieldName = "po_no"
        Me.colpo_no.Name = "colpo_no"
        '
        'coldr_no
        '
        Me.coldr_no.FieldName = "dr_no"
        Me.coldr_no.Name = "coldr_no"
        '
        'colterms_id1
        '
        Me.colterms_id1.FieldName = "terms_id"
        Me.colterms_id1.Name = "colterms_id1"
        '
        'colnodays1
        '
        Me.colnodays1.FieldName = "nodays"
        Me.colnodays1.Name = "colnodays1"
        '
        'coljbooks_terms_id
        '
        Me.coljbooks_terms_id.FieldName = "jbooks_terms_id"
        Me.coljbooks_terms_id.Name = "coljbooks_terms_id"
        '
        'colterms_code
        '
        Me.colterms_code.FieldName = "terms_code"
        Me.colterms_code.Name = "colterms_code"
        '
        'colterms_name
        '
        Me.colterms_name.FieldName = "terms_name"
        Me.colterms_name.Name = "colterms_name"
        '
        'coloffset
        '
        Me.coloffset.FieldName = "offset"
        Me.coloffset.Name = "coloffset"
        '
        'colminimum
        '
        Me.colminimum.FieldName = "minimum"
        Me.colminimum.Name = "colminimum"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(218, 401)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 374
        Me.LabelControl1.Text = "0.00"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(348, 401)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl2.TabIndex = 375
        Me.LabelControl2.Text = "0.00"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(478, 401)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl3.TabIndex = 376
        Me.LabelControl3.Text = "0.00"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(888, 401)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl4.TabIndex = 379
        Me.LabelControl4.Text = "0.00"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(758, 401)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl5.TabIndex = 378
        Me.LabelControl5.Text = "0.00"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(628, 401)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 377
        Me.LabelControl6.Text = "0.00"
        '
        'pnlDet
        '
        Me.pnlDet.Controls.Add(Me.txtGeneralNameDet)
        Me.pnlDet.Controls.Add(Me.txtAccountNameDet)
        Me.pnlDet.Controls.Add(NodaysLabel)
        Me.pnlDet.Controls.Add(Ref_trans_noLabel)
        Me.pnlDet.Controls.Add(Me.txtRefTransNoDet)
        Me.pnlDet.Controls.Add(General_codeLabel)
        Me.pnlDet.Controls.Add(Terms_idLabel)
        Me.pnlDet.Controls.Add(Credit_basedLabel)
        Me.pnlDet.Controls.Add(Debit_basedLabel)
        Me.pnlDet.Controls.Add(CreditLabel)
        Me.pnlDet.Controls.Add(DebitLabel)
        Me.pnlDet.Controls.Add(Allocation_idLabel)
        Me.pnlDet.Controls.Add(Department_idLabel)
        Me.pnlDet.Controls.Add(Project_idLabel)
        Me.pnlDet.Controls.Add(Account_idLabel)
        Me.pnlDet.Controls.Add(Based_rateLabel1)
        Me.pnlDet.Controls.Add(Exchange_rateLabel1)
        Me.pnlDet.Controls.Add(Currency_idLabel1)
        Me.pnlDet.Controls.Add(Line_remarksLabel)
        Me.pnlDet.Controls.Add(Me.txtBasedRateDet)
        Me.pnlDet.Controls.Add(Me.txtExchangeRateDet)
        Me.pnlDet.Controls.Add(Me.txtLineRemarksDet)
        Me.pnlDet.Controls.Add(Me.txtAccountIDDet)
        Me.pnlDet.Controls.Add(Me.txtProjectIDDet)
        Me.pnlDet.Controls.Add(Me.txtDepartmentDet)
        Me.pnlDet.Controls.Add(Me.txtAllocationDet)
        Me.pnlDet.Controls.Add(Me.txtDebitDet)
        Me.pnlDet.Controls.Add(Me.txtCreditDet)
        Me.pnlDet.Controls.Add(Me.txtDebitBasedDet)
        Me.pnlDet.Controls.Add(Me.txtCreditBasedDet)
        Me.pnlDet.Controls.Add(Me.txtNodaysDet)
        Me.pnlDet.Controls.Add(Me.txtTermsIDDet)
        Me.pnlDet.Controls.Add(Me.txtGeneralIDDet)
        Me.pnlDet.Controls.Add(Me.txtCurrencyIDDet)
        Me.pnlDet.Location = New System.Drawing.Point(219, 449)
        Me.pnlDet.Name = "pnlDet"
        Me.pnlDet.Size = New System.Drawing.Size(769, 180)
        Me.pnlDet.TabIndex = 380
        Me.pnlDet.UseDisabledStatePainter = False
        '
        'txtGeneralNameDet
        '
        Me.txtGeneralNameDet.Enabled = False
        Me.txtGeneralNameDet.Location = New System.Drawing.Point(262, 131)
        Me.txtGeneralNameDet.Name = "txtGeneralNameDet"
        Me.txtGeneralNameDet.Size = New System.Drawing.Size(487, 20)
        Me.txtGeneralNameDet.TabIndex = 41
        '
        'txtAccountNameDet
        '
        Me.txtAccountNameDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.chart_bs, "account_name", True))
        Me.txtAccountNameDet.Enabled = False
        Me.txtAccountNameDet.Location = New System.Drawing.Point(262, 47)
        Me.txtAccountNameDet.Name = "txtAccountNameDet"
        Me.txtAccountNameDet.Size = New System.Drawing.Size(487, 20)
        Me.txtAccountNameDet.TabIndex = 40
        '
        'chart_bs
        '
        Me.chart_bs.DataMember = "lib_erp_chart"
        Me.chart_bs.DataSource = Me.DEFSTableSet
        '
        'txtRefTransNoDet
        '
        Me.txtRefTransNoDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "ref_trans_no", True))
        Me.txtRefTransNoDet.Location = New System.Drawing.Point(96, 152)
        Me.txtRefTransNoDet.Name = "txtRefTransNoDet"
        Me.txtRefTransNoDet.Size = New System.Drawing.Size(160, 20)
        Me.txtRefTransNoDet.TabIndex = 38
        '
        'txtBasedRateDet
        '
        Me.txtBasedRateDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "based_rate", True))
        Me.txtBasedRateDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBasedRateDet.Location = New System.Drawing.Point(589, 26)
        Me.txtBasedRateDet.Name = "txtBasedRateDet"
        Me.txtBasedRateDet.Properties.DisplayFormat.FormatString = "n4"
        Me.txtBasedRateDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRateDet.Properties.EditFormat.FormatString = "n4"
        Me.txtBasedRateDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRateDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtBasedRateDet.Properties.Mask.EditMask = "n4"
        Me.txtBasedRateDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBasedRateDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBasedRateDet.Size = New System.Drawing.Size(160, 20)
        Me.txtBasedRateDet.TabIndex = 23
        '
        'txtExchangeRateDet
        '
        Me.txtExchangeRateDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "exchange_rate", True))
        Me.txtExchangeRateDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExchangeRateDet.Location = New System.Drawing.Point(348, 26)
        Me.txtExchangeRateDet.Name = "txtExchangeRateDet"
        Me.txtExchangeRateDet.Properties.DisplayFormat.FormatString = "n4"
        Me.txtExchangeRateDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRateDet.Properties.EditFormat.FormatString = "n4"
        Me.txtExchangeRateDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRateDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtExchangeRateDet.Properties.Mask.EditMask = "n4"
        Me.txtExchangeRateDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExchangeRateDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExchangeRateDet.Size = New System.Drawing.Size(160, 20)
        Me.txtExchangeRateDet.TabIndex = 21
        '
        'txtLineRemarksDet
        '
        Me.txtLineRemarksDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "line_remarks", True))
        Me.txtLineRemarksDet.Location = New System.Drawing.Point(96, 5)
        Me.txtLineRemarksDet.Name = "txtLineRemarksDet"
        Me.txtLineRemarksDet.Size = New System.Drawing.Size(653, 20)
        Me.txtLineRemarksDet.TabIndex = 17
        '
        'txtAccountIDDet
        '
        Me.txtAccountIDDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "account_id", True))
        Me.txtAccountIDDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAccountIDDet.Location = New System.Drawing.Point(96, 47)
        Me.txtAccountIDDet.Name = "txtAccountIDDet"
        Me.txtAccountIDDet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAccountIDDet.Properties.DataSource = Me.chart_bs
        Me.txtAccountIDDet.Properties.DisplayMember = "account_code"
        Me.txtAccountIDDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtAccountIDDet.Properties.NullText = ""
        Me.txtAccountIDDet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtAccountIDDet.Properties.ValueMember = "account_id"
        Me.txtAccountIDDet.Properties.View = Me.GridView4
        Me.txtAccountIDDet.Size = New System.Drawing.Size(160, 20)
        Me.txtAccountIDDet.TabIndex = 25
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colaccount_id1, Me.colaccount_code1, Me.colaccount_name1, Me.colchart_class_id, Me.coldate1, Me.colvalidation1, Me.coldescription1})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colaccount_id1
        '
        Me.colaccount_id1.FieldName = "account_id"
        Me.colaccount_id1.Name = "colaccount_id1"
        '
        'colaccount_code1
        '
        Me.colaccount_code1.Caption = "Code"
        Me.colaccount_code1.FieldName = "account_code"
        Me.colaccount_code1.Name = "colaccount_code1"
        Me.colaccount_code1.Visible = True
        Me.colaccount_code1.VisibleIndex = 0
        Me.colaccount_code1.Width = 100
        '
        'colaccount_name1
        '
        Me.colaccount_name1.Caption = "Name"
        Me.colaccount_name1.FieldName = "account_name"
        Me.colaccount_name1.Name = "colaccount_name1"
        Me.colaccount_name1.Visible = True
        Me.colaccount_name1.VisibleIndex = 1
        Me.colaccount_name1.Width = 200
        '
        'colchart_class_id
        '
        Me.colchart_class_id.FieldName = "chart_class_id"
        Me.colchart_class_id.Name = "colchart_class_id"
        '
        'coldate1
        '
        Me.coldate1.FieldName = "date"
        Me.coldate1.Name = "coldate1"
        '
        'colvalidation1
        '
        Me.colvalidation1.FieldName = "validation"
        Me.colvalidation1.Name = "colvalidation1"
        '
        'coldescription1
        '
        Me.coldescription1.FieldName = "description"
        Me.coldescription1.Name = "coldescription1"
        '
        'txtProjectIDDet
        '
        Me.txtProjectIDDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "project_id", True))
        Me.txtProjectIDDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtProjectIDDet.Location = New System.Drawing.Point(96, 68)
        Me.txtProjectIDDet.Name = "txtProjectIDDet"
        Me.txtProjectIDDet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProjectIDDet.Properties.DataSource = Me.project_bs
        Me.txtProjectIDDet.Properties.DisplayMember = "project_name"
        Me.txtProjectIDDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtProjectIDDet.Properties.NullText = ""
        Me.txtProjectIDDet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtProjectIDDet.Properties.ValueMember = "project_id"
        Me.txtProjectIDDet.Properties.View = Me.GridView5
        Me.txtProjectIDDet.Size = New System.Drawing.Size(160, 20)
        Me.txtProjectIDDet.TabIndex = 27
        '
        'project_bs
        '
        Me.project_bs.DataMember = "lib_erp_project"
        Me.project_bs.DataSource = Me.DEFSTableSet
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproject_id1, Me.colproject_code1, Me.colproject_name1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colproject_id1
        '
        Me.colproject_id1.FieldName = "project_id"
        Me.colproject_id1.Name = "colproject_id1"
        '
        'colproject_code1
        '
        Me.colproject_code1.Caption = "Code"
        Me.colproject_code1.FieldName = "project_code"
        Me.colproject_code1.Name = "colproject_code1"
        Me.colproject_code1.Visible = True
        Me.colproject_code1.VisibleIndex = 0
        Me.colproject_code1.Width = 100
        '
        'colproject_name1
        '
        Me.colproject_name1.Caption = "Name"
        Me.colproject_name1.FieldName = "project_name"
        Me.colproject_name1.Name = "colproject_name1"
        Me.colproject_name1.Visible = True
        Me.colproject_name1.VisibleIndex = 1
        Me.colproject_name1.Width = 200
        '
        'txtDepartmentDet
        '
        Me.txtDepartmentDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "department_id", True))
        Me.txtDepartmentDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDepartmentDet.Location = New System.Drawing.Point(348, 68)
        Me.txtDepartmentDet.Name = "txtDepartmentDet"
        Me.txtDepartmentDet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDepartmentDet.Properties.DataSource = Me.department_bs
        Me.txtDepartmentDet.Properties.DisplayMember = "department_name"
        Me.txtDepartmentDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDepartmentDet.Properties.NullText = ""
        Me.txtDepartmentDet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtDepartmentDet.Properties.ValueMember = "department_id"
        Me.txtDepartmentDet.Properties.View = Me.GridView6
        Me.txtDepartmentDet.Size = New System.Drawing.Size(160, 20)
        Me.txtDepartmentDet.TabIndex = 29
        '
        'department_bs
        '
        Me.department_bs.DataMember = "lib_erp_department"
        Me.department_bs.DataSource = Me.DEFSTableSet
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldepartment_id3, Me.coldepartment_code1, Me.coldepartment_name1, Me.coldepartment_id_head})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'coldepartment_id3
        '
        Me.coldepartment_id3.FieldName = "department_id"
        Me.coldepartment_id3.Name = "coldepartment_id3"
        '
        'coldepartment_code1
        '
        Me.coldepartment_code1.Caption = "Code"
        Me.coldepartment_code1.FieldName = "department_code"
        Me.coldepartment_code1.Name = "coldepartment_code1"
        Me.coldepartment_code1.Visible = True
        Me.coldepartment_code1.VisibleIndex = 0
        Me.coldepartment_code1.Width = 100
        '
        'coldepartment_name1
        '
        Me.coldepartment_name1.Caption = "Name"
        Me.coldepartment_name1.FieldName = "department_name"
        Me.coldepartment_name1.Name = "coldepartment_name1"
        Me.coldepartment_name1.Visible = True
        Me.coldepartment_name1.VisibleIndex = 1
        Me.coldepartment_name1.Width = 200
        '
        'coldepartment_id_head
        '
        Me.coldepartment_id_head.FieldName = "department_id_head"
        Me.coldepartment_id_head.Name = "coldepartment_id_head"
        '
        'txtAllocationDet
        '
        Me.txtAllocationDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "allocation_id", True))
        Me.txtAllocationDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAllocationDet.Location = New System.Drawing.Point(589, 68)
        Me.txtAllocationDet.Name = "txtAllocationDet"
        Me.txtAllocationDet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAllocationDet.Properties.DataSource = Me.allocation_bs
        Me.txtAllocationDet.Properties.DisplayMember = "allocation_name"
        Me.txtAllocationDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtAllocationDet.Properties.NullText = ""
        Me.txtAllocationDet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtAllocationDet.Properties.ValueMember = "allocation_id"
        Me.txtAllocationDet.Properties.View = Me.GridView7
        Me.txtAllocationDet.Size = New System.Drawing.Size(160, 20)
        Me.txtAllocationDet.TabIndex = 31
        '
        'allocation_bs
        '
        Me.allocation_bs.DataMember = "lib_erp_allocation"
        Me.allocation_bs.DataSource = Me.DEFSTableSet
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colallocation_id1, Me.colallocation_code1, Me.colallocation_name1})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colallocation_id1
        '
        Me.colallocation_id1.FieldName = "allocation_id"
        Me.colallocation_id1.Name = "colallocation_id1"
        '
        'colallocation_code1
        '
        Me.colallocation_code1.Caption = "Code"
        Me.colallocation_code1.FieldName = "allocation_code"
        Me.colallocation_code1.Name = "colallocation_code1"
        Me.colallocation_code1.Visible = True
        Me.colallocation_code1.VisibleIndex = 0
        Me.colallocation_code1.Width = 100
        '
        'colallocation_name1
        '
        Me.colallocation_name1.Caption = "Name"
        Me.colallocation_name1.FieldName = "allocation_name"
        Me.colallocation_name1.Name = "colallocation_name1"
        Me.colallocation_name1.Visible = True
        Me.colallocation_name1.VisibleIndex = 1
        Me.colallocation_name1.Width = 200
        '
        'txtDebitDet
        '
        Me.txtDebitDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "debit", True))
        Me.txtDebitDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDebitDet.Location = New System.Drawing.Point(96, 89)
        Me.txtDebitDet.Name = "txtDebitDet"
        Me.txtDebitDet.Properties.DisplayFormat.FormatString = "n4"
        Me.txtDebitDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitDet.Properties.EditFormat.FormatString = "n4"
        Me.txtDebitDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDebitDet.Properties.Mask.EditMask = "n4"
        Me.txtDebitDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebitDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDebitDet.Size = New System.Drawing.Size(160, 20)
        Me.txtDebitDet.TabIndex = 32
        '
        'txtCreditDet
        '
        Me.txtCreditDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "credit", True))
        Me.txtCreditDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCreditDet.Location = New System.Drawing.Point(96, 110)
        Me.txtCreditDet.Name = "txtCreditDet"
        Me.txtCreditDet.Properties.DisplayFormat.FormatString = "n4"
        Me.txtCreditDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCreditDet.Properties.EditFormat.FormatString = "n4"
        Me.txtCreditDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCreditDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtCreditDet.Properties.Mask.EditMask = "n4"
        Me.txtCreditDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCreditDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCreditDet.Size = New System.Drawing.Size(160, 20)
        Me.txtCreditDet.TabIndex = 33
        '
        'txtDebitBasedDet
        '
        Me.txtDebitBasedDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "debit_based", True))
        Me.txtDebitBasedDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDebitBasedDet.Enabled = False
        Me.txtDebitBasedDet.Location = New System.Drawing.Point(348, 89)
        Me.txtDebitBasedDet.Name = "txtDebitBasedDet"
        Me.txtDebitBasedDet.Properties.DisplayFormat.FormatString = "n4"
        Me.txtDebitBasedDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitBasedDet.Properties.EditFormat.FormatString = "n4"
        Me.txtDebitBasedDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitBasedDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDebitBasedDet.Properties.Mask.EditMask = "n4"
        Me.txtDebitBasedDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebitBasedDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDebitBasedDet.Size = New System.Drawing.Size(160, 20)
        Me.txtDebitBasedDet.TabIndex = 34
        '
        'txtCreditBasedDet
        '
        Me.txtCreditBasedDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "credit_based", True))
        Me.txtCreditBasedDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCreditBasedDet.Enabled = False
        Me.txtCreditBasedDet.Location = New System.Drawing.Point(348, 110)
        Me.txtCreditBasedDet.Name = "txtCreditBasedDet"
        Me.txtCreditBasedDet.Properties.DisplayFormat.FormatString = "n4"
        Me.txtCreditBasedDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCreditBasedDet.Properties.EditFormat.FormatString = "n4"
        Me.txtCreditBasedDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCreditBasedDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtCreditBasedDet.Properties.Mask.EditMask = "n4"
        Me.txtCreditBasedDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCreditBasedDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCreditBasedDet.Size = New System.Drawing.Size(160, 20)
        Me.txtCreditBasedDet.TabIndex = 35
        '
        'txtNodaysDet
        '
        Me.txtNodaysDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "nodays", True))
        Me.txtNodaysDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNodaysDet.Location = New System.Drawing.Point(589, 110)
        Me.txtNodaysDet.Name = "txtNodaysDet"
        Me.txtNodaysDet.Properties.DisplayFormat.FormatString = "n0"
        Me.txtNodaysDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNodaysDet.Properties.EditFormat.FormatString = "n0"
        Me.txtNodaysDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNodaysDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtNodaysDet.Properties.Mask.EditMask = "n0"
        Me.txtNodaysDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNodaysDet.Properties.Name = "NodaysSpinEdit"
        Me.txtNodaysDet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNodaysDet.Size = New System.Drawing.Size(160, 20)
        Me.txtNodaysDet.TabIndex = 39
        '
        'txtTermsIDDet
        '
        Me.txtTermsIDDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "terms_id", True))
        Me.txtTermsIDDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTermsIDDet.Location = New System.Drawing.Point(589, 89)
        Me.txtTermsIDDet.Name = "txtTermsIDDet"
        Me.txtTermsIDDet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTermsIDDet.Properties.DataSource = Me.terms_bs
        Me.txtTermsIDDet.Properties.DisplayMember = "terms_name"
        Me.txtTermsIDDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtTermsIDDet.Properties.NullText = ""
        Me.txtTermsIDDet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtTermsIDDet.Properties.ValueMember = "terms_id"
        Me.txtTermsIDDet.Properties.View = Me.GridView8
        Me.txtTermsIDDet.Size = New System.Drawing.Size(160, 20)
        Me.txtTermsIDDet.TabIndex = 36
        '
        'terms_bs
        '
        Me.terms_bs.DataMember = "lib_erp_terms"
        Me.terms_bs.DataSource = Me.DEFSTableSet
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colterms_id3, Me.colterms_code1, Me.colterms_name1, Me.colterms_type, Me.colnodays3, Me.colfixed_day})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.Editable = False
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colterms_id3
        '
        Me.colterms_id3.FieldName = "terms_id"
        Me.colterms_id3.Name = "colterms_id3"
        '
        'colterms_code1
        '
        Me.colterms_code1.Caption = "Code"
        Me.colterms_code1.FieldName = "terms_code"
        Me.colterms_code1.Name = "colterms_code1"
        Me.colterms_code1.Visible = True
        Me.colterms_code1.VisibleIndex = 0
        Me.colterms_code1.Width = 100
        '
        'colterms_name1
        '
        Me.colterms_name1.Caption = "Name"
        Me.colterms_name1.FieldName = "terms_name"
        Me.colterms_name1.Name = "colterms_name1"
        Me.colterms_name1.Visible = True
        Me.colterms_name1.VisibleIndex = 1
        Me.colterms_name1.Width = 200
        '
        'colterms_type
        '
        Me.colterms_type.FieldName = "terms_type"
        Me.colterms_type.Name = "colterms_type"
        '
        'colnodays3
        '
        Me.colnodays3.FieldName = "nodays"
        Me.colnodays3.Name = "colnodays3"
        '
        'colfixed_day
        '
        Me.colfixed_day.FieldName = "fixed_day"
        Me.colfixed_day.Name = "colfixed_day"
        '
        'txtGeneralIDDet
        '
        Me.txtGeneralIDDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "general_id", True))
        Me.txtGeneralIDDet.Location = New System.Drawing.Point(96, 131)
        Me.txtGeneralIDDet.Name = "txtGeneralIDDet"
        Me.txtGeneralIDDet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGeneralIDDet.Properties.DataSource = Me.general_bs
        Me.txtGeneralIDDet.Properties.DisplayMember = "general_code"
        Me.txtGeneralIDDet.Properties.NullText = ""
        Me.txtGeneralIDDet.Properties.ValueMember = "general_id"
        Me.txtGeneralIDDet.Properties.View = Me.GridView9
        Me.txtGeneralIDDet.Size = New System.Drawing.Size(160, 20)
        Me.txtGeneralIDDet.TabIndex = 37
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colgeneral_id3, Me.colgeneral_code2, Me.colgeneral_name2, Me.colgeneral_type1, Me.coldate2, Me.coladdress11, Me.coladdress21, Me.coladdress31, Me.coladdress41, Me.colattention1, Me.colcontact_person1, Me.colposition1, Me.coltel_no1, Me.colfax_no1, Me.colcell_no1, Me.colcategory_id1, Me.coltin1, Me.colemail_add1, Me.colwebsite1, Me.colterms_id2, Me.colcredit_amt1, Me.colnodays2, Me.colremarks1, Me.colvat1, Me.colstatus2, Me.colbillto1, Me.colbilladd11, Me.colbilladd21, Me.colbilladd31, Me.colbilladd41, Me.coldrawing1, Me.colspecs1, Me.colbusiness_type1, Me.coldepartment_id2, Me.colchecker1, Me.colapprover1, Me.colport_area1, Me.colindustry_id1, Me.colrdo_code1, Me.colgeneral_name_bir1})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colgeneral_id3
        '
        Me.colgeneral_id3.FieldName = "general_id"
        Me.colgeneral_id3.Name = "colgeneral_id3"
        '
        'colgeneral_code2
        '
        Me.colgeneral_code2.Caption = "Code"
        Me.colgeneral_code2.FieldName = "general_code"
        Me.colgeneral_code2.Name = "colgeneral_code2"
        Me.colgeneral_code2.Visible = True
        Me.colgeneral_code2.VisibleIndex = 0
        Me.colgeneral_code2.Width = 100
        '
        'colgeneral_name2
        '
        Me.colgeneral_name2.Caption = "Name"
        Me.colgeneral_name2.FieldName = "general_name"
        Me.colgeneral_name2.Name = "colgeneral_name2"
        Me.colgeneral_name2.Visible = True
        Me.colgeneral_name2.VisibleIndex = 1
        Me.colgeneral_name2.Width = 284
        '
        'colgeneral_type1
        '
        Me.colgeneral_type1.FieldName = "general_type"
        Me.colgeneral_type1.Name = "colgeneral_type1"
        '
        'coldate2
        '
        Me.coldate2.FieldName = "date"
        Me.coldate2.Name = "coldate2"
        '
        'coladdress11
        '
        Me.coladdress11.FieldName = "address1"
        Me.coladdress11.Name = "coladdress11"
        '
        'coladdress21
        '
        Me.coladdress21.FieldName = "address2"
        Me.coladdress21.Name = "coladdress21"
        '
        'coladdress31
        '
        Me.coladdress31.FieldName = "address3"
        Me.coladdress31.Name = "coladdress31"
        '
        'coladdress41
        '
        Me.coladdress41.FieldName = "address4"
        Me.coladdress41.Name = "coladdress41"
        '
        'colattention1
        '
        Me.colattention1.FieldName = "attention"
        Me.colattention1.Name = "colattention1"
        '
        'colcontact_person1
        '
        Me.colcontact_person1.FieldName = "contact_person"
        Me.colcontact_person1.Name = "colcontact_person1"
        '
        'colposition1
        '
        Me.colposition1.FieldName = "position"
        Me.colposition1.Name = "colposition1"
        '
        'coltel_no1
        '
        Me.coltel_no1.FieldName = "tel_no"
        Me.coltel_no1.Name = "coltel_no1"
        '
        'colfax_no1
        '
        Me.colfax_no1.FieldName = "fax_no"
        Me.colfax_no1.Name = "colfax_no1"
        '
        'colcell_no1
        '
        Me.colcell_no1.FieldName = "cell_no"
        Me.colcell_no1.Name = "colcell_no1"
        '
        'colcategory_id1
        '
        Me.colcategory_id1.FieldName = "category_id"
        Me.colcategory_id1.Name = "colcategory_id1"
        '
        'coltin1
        '
        Me.coltin1.FieldName = "tin"
        Me.coltin1.Name = "coltin1"
        '
        'colemail_add1
        '
        Me.colemail_add1.FieldName = "email_add"
        Me.colemail_add1.Name = "colemail_add1"
        '
        'colwebsite1
        '
        Me.colwebsite1.FieldName = "website"
        Me.colwebsite1.Name = "colwebsite1"
        '
        'colterms_id2
        '
        Me.colterms_id2.FieldName = "terms_id"
        Me.colterms_id2.Name = "colterms_id2"
        '
        'colcredit_amt1
        '
        Me.colcredit_amt1.FieldName = "credit_amt"
        Me.colcredit_amt1.Name = "colcredit_amt1"
        '
        'colnodays2
        '
        Me.colnodays2.FieldName = "nodays"
        Me.colnodays2.Name = "colnodays2"
        '
        'colremarks1
        '
        Me.colremarks1.FieldName = "remarks"
        Me.colremarks1.Name = "colremarks1"
        '
        'colvat1
        '
        Me.colvat1.FieldName = "vat"
        Me.colvat1.Name = "colvat1"
        '
        'colstatus2
        '
        Me.colstatus2.FieldName = "status"
        Me.colstatus2.Name = "colstatus2"
        '
        'colbillto1
        '
        Me.colbillto1.FieldName = "billto"
        Me.colbillto1.Name = "colbillto1"
        '
        'colbilladd11
        '
        Me.colbilladd11.FieldName = "billadd1"
        Me.colbilladd11.Name = "colbilladd11"
        '
        'colbilladd21
        '
        Me.colbilladd21.FieldName = "billadd2"
        Me.colbilladd21.Name = "colbilladd21"
        '
        'colbilladd31
        '
        Me.colbilladd31.FieldName = "billadd3"
        Me.colbilladd31.Name = "colbilladd31"
        '
        'colbilladd41
        '
        Me.colbilladd41.FieldName = "billadd4"
        Me.colbilladd41.Name = "colbilladd41"
        '
        'coldrawing1
        '
        Me.coldrawing1.FieldName = "drawing"
        Me.coldrawing1.Name = "coldrawing1"
        '
        'colspecs1
        '
        Me.colspecs1.FieldName = "specs"
        Me.colspecs1.Name = "colspecs1"
        '
        'colbusiness_type1
        '
        Me.colbusiness_type1.FieldName = "business_type"
        Me.colbusiness_type1.Name = "colbusiness_type1"
        '
        'coldepartment_id2
        '
        Me.coldepartment_id2.FieldName = "department_id"
        Me.coldepartment_id2.Name = "coldepartment_id2"
        '
        'colchecker1
        '
        Me.colchecker1.FieldName = "checker"
        Me.colchecker1.Name = "colchecker1"
        '
        'colapprover1
        '
        Me.colapprover1.FieldName = "approver"
        Me.colapprover1.Name = "colapprover1"
        '
        'colport_area1
        '
        Me.colport_area1.FieldName = "port_area"
        Me.colport_area1.Name = "colport_area1"
        '
        'colindustry_id1
        '
        Me.colindustry_id1.FieldName = "industry_id"
        Me.colindustry_id1.Name = "colindustry_id1"
        '
        'colrdo_code1
        '
        Me.colrdo_code1.FieldName = "rdo_code"
        Me.colrdo_code1.Name = "colrdo_code1"
        '
        'colgeneral_name_bir1
        '
        Me.colgeneral_name_bir1.FieldName = "general_name_bir"
        Me.colgeneral_name_bir1.Name = "colgeneral_name_bir1"
        '
        'txtCurrencyIDDet
        '
        Me.txtCurrencyIDDet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.trans_jbooks_bs, "currency_id", True))
        Me.txtCurrencyIDDet.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCurrencyIDDet.Location = New System.Drawing.Point(96, 26)
        Me.txtCurrencyIDDet.Name = "txtCurrencyIDDet"
        Me.txtCurrencyIDDet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCurrencyIDDet.Properties.DataSource = Me.currency_bs
        Me.txtCurrencyIDDet.Properties.DisplayMember = "currency_name"
        Me.txtCurrencyIDDet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtCurrencyIDDet.Properties.NullText = ""
        Me.txtCurrencyIDDet.Properties.ValueMember = "currency_id"
        Me.txtCurrencyIDDet.Properties.View = Me.GridView10
        Me.txtCurrencyIDDet.Size = New System.Drawing.Size(160, 20)
        Me.txtCurrencyIDDet.TabIndex = 19
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcurrency_id3, Me.coleffectivitydate1, Me.colexchange_rate3, Me.colbased_rate3, Me.colcurrency_code2, Me.colcurrency_name2})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsBehavior.Editable = False
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colcurrency_id3
        '
        Me.colcurrency_id3.FieldName = "currency_id"
        Me.colcurrency_id3.Name = "colcurrency_id3"
        '
        'coleffectivitydate1
        '
        Me.coleffectivitydate1.FieldName = "effectivitydate"
        Me.coleffectivitydate1.Name = "coleffectivitydate1"
        '
        'colexchange_rate3
        '
        Me.colexchange_rate3.FieldName = "exchange_rate"
        Me.colexchange_rate3.Name = "colexchange_rate3"
        '
        'colbased_rate3
        '
        Me.colbased_rate3.FieldName = "based_rate"
        Me.colbased_rate3.Name = "colbased_rate3"
        '
        'colcurrency_code2
        '
        Me.colcurrency_code2.Caption = "Code"
        Me.colcurrency_code2.FieldName = "currency_code"
        Me.colcurrency_code2.Name = "colcurrency_code2"
        Me.colcurrency_code2.Visible = True
        Me.colcurrency_code2.VisibleIndex = 0
        Me.colcurrency_code2.Width = 100
        '
        'colcurrency_name2
        '
        Me.colcurrency_name2.Caption = "Name"
        Me.colcurrency_name2.FieldName = "currency_name"
        Me.colcurrency_name2.Name = "colcurrency_name2"
        Me.colcurrency_name2.Visible = True
        Me.colcurrency_name2.VisibleIndex = 1
        Me.colcurrency_name2.Width = 200
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNotSave)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(223, 42)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(417, 30)
        Me.FlowLayoutPanel1.TabIndex = 386
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Appearance.Options.UseForeColor = True
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 371
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Appearance.Options.UseForeColor = True
        Me.btnEdit.Location = New System.Drawing.Point(84, 3)
        Me.btnEdit.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEdit.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnEdit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 372
        Me.btnEdit.Text = "Edit"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Appearance.Options.UseForeColor = True
        Me.btnCancel.Location = New System.Drawing.Point(165, 3)
        Me.btnCancel.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 373
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(246, 3)
        Me.btnSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.Green
        Me.btnSave.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 374
        Me.btnSave.Text = "Save"
        Me.btnSave.Visible = False
        '
        'btnNotSave
        '
        Me.btnNotSave.Location = New System.Drawing.Point(327, 3)
        Me.btnNotSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.Maroon
        Me.btnNotSave.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnNotSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(75, 23)
        Me.btnNotSave.TabIndex = 375
        Me.btnNotSave.Text = "Cancel"
        Me.btnNotSave.Visible = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnInsert)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnUpdate)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnRemove)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOK)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNotOK)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(223, 420)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(417, 28)
        Me.FlowLayoutPanel2.TabIndex = 387
        '
        'btnInsert
        '
        Me.btnInsert.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Appearance.Options.UseForeColor = True
        Me.btnInsert.Location = New System.Drawing.Point(3, 3)
        Me.btnInsert.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInsert.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnInsert.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 386
        Me.btnInsert.Text = "Insert"
        '
        'btnUpdate
        '
        Me.btnUpdate.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Appearance.Options.UseForeColor = True
        Me.btnUpdate.Location = New System.Drawing.Point(84, 3)
        Me.btnUpdate.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 387
        Me.btnUpdate.Text = "Update"
        '
        'btnRemove
        '
        Me.btnRemove.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Appearance.Options.UseForeColor = True
        Me.btnRemove.Location = New System.Drawing.Point(165, 3)
        Me.btnRemove.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRemove.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnRemove.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 388
        Me.btnRemove.Text = "Remove"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(246, 3)
        Me.btnOK.LookAndFeel.SkinMaskColor = System.Drawing.Color.Green
        Me.btnOK.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnOK.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 389
        Me.btnOK.Text = "OK"
        Me.btnOK.Visible = False
        '
        'btnNotOK
        '
        Me.btnNotOK.Location = New System.Drawing.Point(327, 3)
        Me.btnNotOK.LookAndFeel.SkinMaskColor = System.Drawing.Color.Maroon
        Me.btnNotOK.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnNotOK.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnNotOK.Name = "btnNotOK"
        Me.btnNotOK.Size = New System.Drawing.Size(75, 23)
        Me.btnNotOK.TabIndex = 390
        Me.btnNotOK.Text = "Cancel"
        Me.btnNotOK.Visible = False
        '
        'chart_ta
        '
        Me.chart_ta.ClearBeforeFill = True
        '
        'general_ta
        '
        Me.general_ta.ClearBeforeFill = True
        '
        'project_ta
        '
        Me.project_ta.ClearBeforeFill = True
        '
        'department_ta
        '
        Me.department_ta.ClearBeforeFill = True
        '
        'allocation_ta
        '
        Me.allocation_ta.ClearBeforeFill = True
        '
        'terms_ta
        '
        Me.terms_ta.ClearBeforeFill = True
        '
        'DETransactionCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 642)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.pnlDet)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.dgDet)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Trans_idLabel)
        Me.Controls.Add(Me.Trans_idSpinEdit)
        Me.Controls.Add(Journal_idLabel)
        Me.Controls.Add(Book_idLabel)
        Me.Controls.Add(Me.Journal_idSpinEdit)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Book_idSpinEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imgLock)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DETransactionCV"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Voucher"
        CType(Me.imgLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_header_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.txtCurrencyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGeneralName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExchangeRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBasedRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountBased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParticular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrencyID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currency_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFileSetupSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGeneralID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.general_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFSTableSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trans_idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_jbooks_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDet.ResumeLayout(False)
        Me.pnlDet.PerformLayout()
        CType(Me.txtGeneralNameDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountNameDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefTransNoDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBasedRateDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExchangeRateDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLineRemarksDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountIDDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectIDDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.project_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartmentDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.department_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllocationDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allocation_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebitDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebitBasedDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditBasedDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNodaysDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTermsIDDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.terms_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGeneralIDDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrencyIDDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLock As Windows.Forms.PictureBox
    Friend WithEvents lblStatus As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents TransactionSet As TransactionSet
    Friend WithEvents trans_header_bs As Windows.Forms.BindingSource
    Friend WithEvents trans_header_ta As TransactionSetTableAdapters.get_trans_headerTableAdapter
    Friend WithEvents dgMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coltrans_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltrans_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltrans_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbook_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljournal_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexchange_rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbased_rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount_based As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colposted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Trans_idSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtTransDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Book_idSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Journal_idSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DEFileSetupSet As DEFileSetupSet
    Friend WithEvents txtCurrencyName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGeneralName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExchangeRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBasedRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmountBased As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmountWord As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtParticular As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents currency_bs As Windows.Forms.BindingSource
    Friend WithEvents currency_ta As DEFileSetupSetTableAdapters.get_currency_rateTableAdapter
    Friend WithEvents txtCurrencyID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcurrency_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleffectivitydate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexchange_rate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbased_rate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtGeneralID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTransNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSettings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents trans_jbooks_bs As Windows.Forms.BindingSource
    Friend WithEvents trans_jbooks_ta As TransactionSetTableAdapters.get_trans_jbooksTableAdapter
    Friend WithEvents dgDet As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colisInputted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljbooks_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltrans_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproject_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colallocation_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaccount_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexchange_rate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbased_rate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldebit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldebit_based As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcredit_based As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colref_jbooks_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colline_remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljbooks_id_tmp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproject_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproject_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colallocation_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colallocation_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaccount_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaccount_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalidation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colref_trans_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colref_book_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colref_journal_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colref_book_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colref_book_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colref_journal_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colref_journal_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsi_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrr_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpo_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldr_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnodays1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljbooks_terms_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coloffset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colminimum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlDet As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtBasedRateDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExchangeRateDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLineRemarksDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FlowLayoutPanel1 As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNotSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FlowLayoutPanel2 As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnInsert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNotOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRefTransNoDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAccountIDDet As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtProjectIDDet As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDepartmentDet As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAllocationDet As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDebitDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreditDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebitBasedDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreditBasedDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNodaysDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTermsIDDet As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtGeneralIDDet As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCurrencyIDDet As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtGeneralNameDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAccountNameDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colaccount_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaccount_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaccount_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchart_class_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalidation1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colattention As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcontact_person As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltel_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfax_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcell_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcategory_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail_add As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwebsite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcredit_amt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnodays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbillto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbilladd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbilladd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbilladd3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbilladd4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrawing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colspecs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbusiness_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchecker As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colapprover As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colport_area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colindustry_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrdo_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_name_bir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DEFSTableSet As DEFSTableSet
    Friend WithEvents chart_bs As Windows.Forms.BindingSource
    Friend WithEvents chart_ta As DEFSTableSetTableAdapters.lib_erp_chartTableAdapter
    Friend WithEvents general_bs As Windows.Forms.BindingSource
    Friend WithEvents general_ta As DEFSTableSetTableAdapters.lib_erp_generalTableAdapter
    Friend WithEvents project_bs As Windows.Forms.BindingSource
    Friend WithEvents project_ta As DEFSTableSetTableAdapters.lib_erp_projectTableAdapter
    Friend WithEvents department_bs As Windows.Forms.BindingSource
    Friend WithEvents department_ta As DEFSTableSetTableAdapters.lib_erp_departmentTableAdapter
    Friend WithEvents allocation_bs As Windows.Forms.BindingSource
    Friend WithEvents allocation_ta As DEFSTableSetTableAdapters.lib_erp_allocationTableAdapter
    Friend WithEvents terms_bs As Windows.Forms.BindingSource
    Friend WithEvents terms_ta As DEFSTableSetTableAdapters.lib_erp_termsTableAdapter
    Friend WithEvents colgeneral_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_code2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_type1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colattention1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcontact_person1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colposition1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltel_no1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfax_no1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcell_no1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcategory_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltin1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail_add1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwebsite1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcredit_amt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnodays2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvat1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbillto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbilladd11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbilladd21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbilladd31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbilladd41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrawing1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colspecs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbusiness_type1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchecker1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colapprover1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colport_area1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colindustry_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrdo_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral_name_bir1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleffectivitydate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexchange_rate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbased_rate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_code2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproject_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproject_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproject_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepartment_id_head As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colallocation_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colallocation_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colallocation_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_code1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnodays3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfixed_day As DevExpress.XtraGrid.Columns.GridColumn
End Class
