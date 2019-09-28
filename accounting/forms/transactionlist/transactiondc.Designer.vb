<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactiondc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transactiondc))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.border1 = New accounting.borderedlabel()
        Me.border2 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnCorrection = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnComment = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.hdr = New System.Windows.Forms.Panel()
        Me.txtAmountBased = New DevExpress.XtraEditors.TextEdit()
        Me.btnParticular = New System.Windows.Forms.PictureBox()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtBasedRate = New DevExpress.XtraEditors.TextEdit()
        Me.txt_trans_dc_id = New user_control.MyTextBox()
        Me.txtExchangeRate = New DevExpress.XtraEditors.TextEdit()
        Me.txt_trans_id = New user_control.MyTextBox()
        Me.txt_year = New user_control.MyTextBox()
        Me.txt_day = New user_control.MyTextBox()
        Me.txt_month = New user_control.MyTextBox()
        Me.txt_currency_name = New user_control.MyTextBox()
        Me.txt_general_name = New user_control.MyTextBox()
        Me.txt_description = New user_control.MyTextBox()
        Me.txt_amount_in_word = New user_control.MyTextBox()
        Me.txt_currency_id = New user_control.MyTextBox()
        Me.txt_general_id = New user_control.MyTextBox()
        Me.txt_trans_no = New user_control.MyTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldiffbasedtotal = New System.Windows.Forms.Label()
        Me.lbldebitbasedtotal = New System.Windows.Forms.Label()
        Me.lblcreditbasedtotal = New System.Windows.Forms.Label()
        Me.lbldifftotal = New System.Windows.Forms.Label()
        Me.lbldebittotal = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblcredittotal = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgjbooks = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.jbooks_id_tmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.offset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.validation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.det = New System.Windows.Forms.Panel()
        Me.txt_noCompute = New System.Windows.Forms.CheckBox()
        Me.txt_project_unit_no_id = New user_control.MyTextBox()
        Me.txt_project_id = New user_control.MyTextBox()
        Me.txt_particulars_det = New user_control.MyTextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_book_unit_no_id = New user_control.MyTextBox()
        Me.lblUnitNo = New System.Windows.Forms.Label()
        Me.txtCreditBased = New DevExpress.XtraEditors.TextEdit()
        Me.txtCredit = New DevExpress.XtraEditors.TextEdit()
        Me.txtDebitBased = New DevExpress.XtraEditors.TextEdit()
        Me.txtDebit = New DevExpress.XtraEditors.TextEdit()
        Me.txtBasedRateDet = New DevExpress.XtraEditors.TextEdit()
        Me.txt_validation = New user_control.MyTextBox()
        Me.txt_tmp_jbooks_id = New user_control.MyTextBox()
        Me.txtExchangeRateDet = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ref_book_code = New user_control.MyTextBox()
        Me.txt_ref_journal_code = New user_control.MyTextBox()
        Me.txt_allocation_id = New user_control.MyTextBox()
        Me.txt_account_id = New user_control.MyTextBox()
        Me.txt_nodays_det = New user_control.MyTextBox()
        Me.txt_terms_id_det = New user_control.MyTextBox()
        Me.txt_department_id = New user_control.MyTextBox()
        Me.txt_general_name_det = New user_control.MyTextBox()
        Me.txt_ref_jbooks_id = New user_control.MyTextBox()
        Me.txt_general_id_det = New user_control.MyTextBox()
        Me.txt_account_name = New user_control.MyTextBox()
        Me.lbltermsdet = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.txt_currency_id_det = New user_control.MyTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txt_line_remarks = New user_control.MyTextBox()
        Me.lblbasedrate = New System.Windows.Forms.Label()
        Me.lblLineRemarks = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblexchangerate = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblcurrency = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblAllocation = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ds = New System.Data.DataSet()
        Me.trans = New System.Data.DataTable()
        Me.DataColum101 = New System.Data.DataColumn()
        Me.DataColum102 = New System.Data.DataColumn()
        Me.DataColum103 = New System.Data.DataColumn()
        Me.DataColum104 = New System.Data.DataColumn()
        Me.DataColum105 = New System.Data.DataColumn()
        Me.DataColum106 = New System.Data.DataColumn()
        Me.DataColum107 = New System.Data.DataColumn()
        Me.DataColum108 = New System.Data.DataColumn()
        Me.DataColum109 = New System.Data.DataColumn()
        Me.DataColum110 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.description = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn160 = New System.Data.DataColumn()
        Me.DataColumn161 = New System.Data.DataColumn()
        Me.DataColumn162 = New System.Data.DataColumn()
        Me.DataColumn164 = New System.Data.DataColumn()
        Me.DataColumn275 = New System.Data.DataColumn()
        Me.DataColumn276 = New System.Data.DataColumn()
        Me.DataColumn277 = New System.Data.DataColumn()
        Me.DataColumn278 = New System.Data.DataColumn()
        Me.DataColumn279 = New System.Data.DataColumn()
        Me.DataColumn293 = New System.Data.DataColumn()
        Me.DataColumn294 = New System.Data.DataColumn()
        Me.DataColumn295 = New System.Data.DataColumn()
        Me.DataColumn296 = New System.Data.DataColumn()
        Me.DataColumn297 = New System.Data.DataColumn()
        Me.DataColumn298 = New System.Data.DataColumn()
        Me.DataColumn299 = New System.Data.DataColumn()
        Me.jbooks = New System.Data.DataTable()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn151 = New System.Data.DataColumn()
        Me.DataColumn152 = New System.Data.DataColumn()
        Me.DataColumn153 = New System.Data.DataColumn()
        Me.DataColumn165 = New System.Data.DataColumn()
        Me.DataColumn170 = New System.Data.DataColumn()
        Me.DataColumn171 = New System.Data.DataColumn()
        Me.DataColumn172 = New System.Data.DataColumn()
        Me.DataColumn173 = New System.Data.DataColumn()
        Me.DataColumn261 = New System.Data.DataColumn()
        Me.DataColumn262 = New System.Data.DataColumn()
        Me.DataColumn263 = New System.Data.DataColumn()
        Me.DataColumn264 = New System.Data.DataColumn()
        Me.DataColumn284 = New System.Data.DataColumn()
        Me.DataColumn285 = New System.Data.DataColumn()
        Me.DataColumn286 = New System.Data.DataColumn()
        Me.DataColumn287 = New System.Data.DataColumn()
        Me.DataColumn288 = New System.Data.DataColumn()
        Me.DataColumn306 = New System.Data.DataColumn()
        Me.DataColumn307 = New System.Data.DataColumn()
        Me.DataColumn308 = New System.Data.DataColumn()
        Me.DataColumn309 = New System.Data.DataColumn()
        Me.DataColumn310 = New System.Data.DataColumn()
        Me.DataColumn311 = New System.Data.DataColumn()
        Me.DataColumn313 = New System.Data.DataColumn()
        Me.DataColumn314 = New System.Data.DataColumn()
        Me.DataColumn315 = New System.Data.DataColumn()
        Me.DataColumn316 = New System.Data.DataColumn()
        Me.DataColumn317 = New System.Data.DataColumn()
        Me.DataColumn319 = New System.Data.DataColumn()
        Me.DataColumn320 = New System.Data.DataColumn()
        Me.DataColumn321 = New System.Data.DataColumn()
        Me.DataColumn322 = New System.Data.DataColumn()
        Me.ewt = New System.Data.DataTable()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn77 = New System.Data.DataColumn()
        Me.DataColumn78 = New System.Data.DataColumn()
        Me.DataColumn79 = New System.Data.DataColumn()
        Me.DataColumn96 = New System.Data.DataColumn()
        Me.DataColumn154 = New System.Data.DataColumn()
        Me.DataColumn163 = New System.Data.DataColumn()
        Me.DataColumn166 = New System.Data.DataColumn()
        Me.DataColumn167 = New System.Data.DataColumn()
        Me.DataColumn168 = New System.Data.DataColumn()
        Me.DataColumn169 = New System.Data.DataColumn()
        Me.DataColumn174 = New System.Data.DataColumn()
        Me.DataColumn175 = New System.Data.DataColumn()
        Me.DataColumn176 = New System.Data.DataColumn()
        Me.DataColumn177 = New System.Data.DataColumn()
        Me.DataColumn208 = New System.Data.DataColumn()
        Me.checks = New System.Data.DataTable()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn75 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.DataColumn155 = New System.Data.DataColumn()
        Me.DataColumn265 = New System.Data.DataColumn()
        Me.DataColumn266 = New System.Data.DataColumn()
        Me.DataColumn267 = New System.Data.DataColumn()
        Me.DataColumn268 = New System.Data.DataColumn()
        Me.DataColumn269 = New System.Data.DataColumn()
        Me.DataColumn270 = New System.Data.DataColumn()
        Me.DataColumn271 = New System.Data.DataColumn()
        Me.DataColumn272 = New System.Data.DataColumn()
        Me.DataColumn273 = New System.Data.DataColumn()
        Me.DataColumn274 = New System.Data.DataColumn()
        Me.DataColumn280 = New System.Data.DataColumn()
        Me.DataColumn281 = New System.Data.DataColumn()
        Me.DataColumn282 = New System.Data.DataColumn()
        Me.DataColumn283 = New System.Data.DataColumn()
        Me.DataColumn291 = New System.Data.DataColumn()
        Me.DataColumn292 = New System.Data.DataColumn()
        Me.DataColumn312 = New System.Data.DataColumn()
        Me.DataColumn318 = New System.Data.DataColumn()
        Me.fixed_asset = New System.Data.DataTable()
        Me.DataColumn80 = New System.Data.DataColumn()
        Me.DataColumn81 = New System.Data.DataColumn()
        Me.DataColumn82 = New System.Data.DataColumn()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.DataColumn85 = New System.Data.DataColumn()
        Me.DataColumn86 = New System.Data.DataColumn()
        Me.DataColumn87 = New System.Data.DataColumn()
        Me.DataColumn88 = New System.Data.DataColumn()
        Me.DataColumn89 = New System.Data.DataColumn()
        Me.DataColumn90 = New System.Data.DataColumn()
        Me.DataColumn91 = New System.Data.DataColumn()
        Me.DataColumn92 = New System.Data.DataColumn()
        Me.DataColumn93 = New System.Data.DataColumn()
        Me.DataColumn94 = New System.Data.DataColumn()
        Me.DataColumn95 = New System.Data.DataColumn()
        Me.DataColumn156 = New System.Data.DataColumn()
        Me.DataColumn249 = New System.Data.DataColumn()
        Me.DataColumn250 = New System.Data.DataColumn()
        Me.DataColumn251 = New System.Data.DataColumn()
        Me.DataColumn252 = New System.Data.DataColumn()
        Me.DataColumn253 = New System.Data.DataColumn()
        Me.DataColumn254 = New System.Data.DataColumn()
        Me.DataColumn255 = New System.Data.DataColumn()
        Me.DataColumn256 = New System.Data.DataColumn()
        Me.DataColumn257 = New System.Data.DataColumn()
        Me.DataColumn258 = New System.Data.DataColumn()
        Me.DataColumn259 = New System.Data.DataColumn()
        Me.DataColumn260 = New System.Data.DataColumn()
        Me.DataColumn289 = New System.Data.DataColumn()
        Me.DataColumn290 = New System.Data.DataColumn()
        Me.input_vat = New System.Data.DataTable()
        Me.DataColumn97 = New System.Data.DataColumn()
        Me.DataColumn98 = New System.Data.DataColumn()
        Me.DataColumn99 = New System.Data.DataColumn()
        Me.DataColumn100 = New System.Data.DataColumn()
        Me.DataColumn101 = New System.Data.DataColumn()
        Me.DataColumn102 = New System.Data.DataColumn()
        Me.DataColumn103 = New System.Data.DataColumn()
        Me.DataColumn104 = New System.Data.DataColumn()
        Me.DataColumn105 = New System.Data.DataColumn()
        Me.DataColumn106 = New System.Data.DataColumn()
        Me.DataColumn107 = New System.Data.DataColumn()
        Me.DataColumn108 = New System.Data.DataColumn()
        Me.DataColumn109 = New System.Data.DataColumn()
        Me.DataColumn110 = New System.Data.DataColumn()
        Me.DataColumn111 = New System.Data.DataColumn()
        Me.DataColumn112 = New System.Data.DataColumn()
        Me.DataColumn113 = New System.Data.DataColumn()
        Me.DataColumn114 = New System.Data.DataColumn()
        Me.DataColumn115 = New System.Data.DataColumn()
        Me.DataColumn116 = New System.Data.DataColumn()
        Me.DataColumn117 = New System.Data.DataColumn()
        Me.DataColumn157 = New System.Data.DataColumn()
        Me.DataColumn210 = New System.Data.DataColumn()
        Me.DataColumn211 = New System.Data.DataColumn()
        Me.DataColumn212 = New System.Data.DataColumn()
        Me.DataColumn213 = New System.Data.DataColumn()
        Me.DataColumn214 = New System.Data.DataColumn()
        Me.DataColumn215 = New System.Data.DataColumn()
        Me.DataColumn216 = New System.Data.DataColumn()
        Me.DataColumn217 = New System.Data.DataColumn()
        Me.DataColumn218 = New System.Data.DataColumn()
        Me.DataColumn219 = New System.Data.DataColumn()
        Me.DataColumn220 = New System.Data.DataColumn()
        Me.DataColumn221 = New System.Data.DataColumn()
        Me.DataColumn222 = New System.Data.DataColumn()
        Me.output_vat = New System.Data.DataTable()
        Me.DataColumn118 = New System.Data.DataColumn()
        Me.DataColumn119 = New System.Data.DataColumn()
        Me.DataColumn120 = New System.Data.DataColumn()
        Me.DataColumn121 = New System.Data.DataColumn()
        Me.DataColumn122 = New System.Data.DataColumn()
        Me.DataColumn123 = New System.Data.DataColumn()
        Me.DataColumn124 = New System.Data.DataColumn()
        Me.DataColumn125 = New System.Data.DataColumn()
        Me.DataColumn126 = New System.Data.DataColumn()
        Me.DataColumn127 = New System.Data.DataColumn()
        Me.DataColumn128 = New System.Data.DataColumn()
        Me.DataColumn129 = New System.Data.DataColumn()
        Me.DataColumn130 = New System.Data.DataColumn()
        Me.DataColumn131 = New System.Data.DataColumn()
        Me.DataColumn132 = New System.Data.DataColumn()
        Me.DataColumn133 = New System.Data.DataColumn()
        Me.DataColumn134 = New System.Data.DataColumn()
        Me.DataColumn135 = New System.Data.DataColumn()
        Me.DataColumn136 = New System.Data.DataColumn()
        Me.DataColumn137 = New System.Data.DataColumn()
        Me.DataColumn158 = New System.Data.DataColumn()
        Me.DataColumn223 = New System.Data.DataColumn()
        Me.DataColumn224 = New System.Data.DataColumn()
        Me.DataColumn225 = New System.Data.DataColumn()
        Me.DataColumn226 = New System.Data.DataColumn()
        Me.DataColumn227 = New System.Data.DataColumn()
        Me.DataColumn228 = New System.Data.DataColumn()
        Me.DataColumn229 = New System.Data.DataColumn()
        Me.DataColumn230 = New System.Data.DataColumn()
        Me.DataColumn231 = New System.Data.DataColumn()
        Me.DataColumn232 = New System.Data.DataColumn()
        Me.DataColumn233 = New System.Data.DataColumn()
        Me.DataColumn234 = New System.Data.DataColumn()
        Me.DataColumn235 = New System.Data.DataColumn()
        Me.DataColumn236 = New System.Data.DataColumn()
        Me.prepaid = New System.Data.DataTable()
        Me.DataColumn138 = New System.Data.DataColumn()
        Me.DataColumn139 = New System.Data.DataColumn()
        Me.DataColumn140 = New System.Data.DataColumn()
        Me.DataColumn141 = New System.Data.DataColumn()
        Me.DataColumn142 = New System.Data.DataColumn()
        Me.DataColumn143 = New System.Data.DataColumn()
        Me.DataColumn144 = New System.Data.DataColumn()
        Me.DataColumn145 = New System.Data.DataColumn()
        Me.DataColumn146 = New System.Data.DataColumn()
        Me.DataColumn147 = New System.Data.DataColumn()
        Me.DataColumn148 = New System.Data.DataColumn()
        Me.DataColumn149 = New System.Data.DataColumn()
        Me.DataColumn150 = New System.Data.DataColumn()
        Me.DataColumn159 = New System.Data.DataColumn()
        Me.DataColumn237 = New System.Data.DataColumn()
        Me.DataColumn238 = New System.Data.DataColumn()
        Me.DataColumn239 = New System.Data.DataColumn()
        Me.DataColumn240 = New System.Data.DataColumn()
        Me.DataColumn241 = New System.Data.DataColumn()
        Me.DataColumn242 = New System.Data.DataColumn()
        Me.DataColumn243 = New System.Data.DataColumn()
        Me.DataColumn244 = New System.Data.DataColumn()
        Me.DataColumn245 = New System.Data.DataColumn()
        Me.DataColumn246 = New System.Data.DataColumn()
        Me.DataColumn247 = New System.Data.DataColumn()
        Me.DataColumn248 = New System.Data.DataColumn()
        Me.final_tax = New System.Data.DataTable()
        Me.DataColumn178 = New System.Data.DataColumn()
        Me.DataColumn179 = New System.Data.DataColumn()
        Me.DataColumn180 = New System.Data.DataColumn()
        Me.DataColumn181 = New System.Data.DataColumn()
        Me.DataColumn182 = New System.Data.DataColumn()
        Me.DataColumn183 = New System.Data.DataColumn()
        Me.DataColumn184 = New System.Data.DataColumn()
        Me.DataColumn185 = New System.Data.DataColumn()
        Me.DataColumn186 = New System.Data.DataColumn()
        Me.DataColumn187 = New System.Data.DataColumn()
        Me.DataColumn188 = New System.Data.DataColumn()
        Me.DataColumn189 = New System.Data.DataColumn()
        Me.DataColumn190 = New System.Data.DataColumn()
        Me.DataColumn191 = New System.Data.DataColumn()
        Me.DataColumn192 = New System.Data.DataColumn()
        Me.DataColumn193 = New System.Data.DataColumn()
        Me.DataColumn194 = New System.Data.DataColumn()
        Me.DataColumn195 = New System.Data.DataColumn()
        Me.DataColumn196 = New System.Data.DataColumn()
        Me.DataColumn197 = New System.Data.DataColumn()
        Me.DataColumn198 = New System.Data.DataColumn()
        Me.DataColumn199 = New System.Data.DataColumn()
        Me.DataColumn200 = New System.Data.DataColumn()
        Me.DataColumn201 = New System.Data.DataColumn()
        Me.DataColumn202 = New System.Data.DataColumn()
        Me.DataColumn203 = New System.Data.DataColumn()
        Me.DataColumn204 = New System.Data.DataColumn()
        Me.DataColumn205 = New System.Data.DataColumn()
        Me.DataColumn206 = New System.Data.DataColumn()
        Me.DataColumn207 = New System.Data.DataColumn()
        Me.DataColumn209 = New System.Data.DataColumn()
        Me.particular = New System.Data.DataTable()
        Me.DataColumn300 = New System.Data.DataColumn()
        Me.DataColumn301 = New System.Data.DataColumn()
        Me.DataColumn302 = New System.Data.DataColumn()
        Me.DataColumn303 = New System.Data.DataColumn()
        Me.DataColumn304 = New System.Data.DataColumn()
        Me.DataColumn305 = New System.Data.DataColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.imgLock = New System.Windows.Forms.PictureBox()
        Me.btnViewSchedule = New System.Windows.Forms.Button()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.hdr.SuspendLayout()
        CType(Me.txtAmountBased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnParticular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBasedRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExchangeRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgjbooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.det.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditBased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebitBased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBasedRateDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExchangeRateDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jbooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ewt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fixed_asset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input_vat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.output_vat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prepaid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.final_tax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.particular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(14, 64)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(774, 2)
        Me.border1.TabIndex = 278
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(14, 66)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(774, 2)
        Me.border2.TabIndex = 279
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 25)
        Me.Label1.TabIndex = 277
        Me.Label1.Text = "Debit / Credit Memo"
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(100, 69)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(60, 24)
        Me.btnNotSave.TabIndex = 13
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        Me.btnNotSave.Visible = False
        '
        'btnCorrection
        '
        Me.btnCorrection.BackColor = System.Drawing.Color.Maroon
        Me.btnCorrection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCorrection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorrection.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorrection.ForeColor = System.Drawing.Color.White
        Me.btnCorrection.Location = New System.Drawing.Point(622, 35)
        Me.btnCorrection.Name = "btnCorrection"
        Me.btnCorrection.Size = New System.Drawing.Size(80, 24)
        Me.btnCorrection.TabIndex = 4
        Me.btnCorrection.Text = "Reject"
        Me.btnCorrection.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.Green
        Me.btnApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(539, 35)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(80, 24)
        Me.btnApprove.TabIndex = 3
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(17, 69)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 24)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "F2 Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(100, 69)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 24)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "F3 Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(705, 35)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 24)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(266, 69)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "F5 Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(598, 69)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(80, 24)
        Me.btnSettings.TabIndex = 10
        Me.btnSettings.Text = "F9 Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnComment
        '
        Me.btnComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComment.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComment.ForeColor = System.Drawing.Color.White
        Me.btnComment.Location = New System.Drawing.Point(705, 35)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(80, 24)
        Me.btnComment.TabIndex = 5
        Me.btnComment.Text = "Comment"
        Me.btnComment.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(17, 69)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'hdr
        '
        Me.hdr.Controls.Add(Me.txtAmountBased)
        Me.hdr.Controls.Add(Me.btnParticular)
        Me.hdr.Controls.Add(Me.txtAmount)
        Me.hdr.Controls.Add(Me.txtBasedRate)
        Me.hdr.Controls.Add(Me.txt_trans_dc_id)
        Me.hdr.Controls.Add(Me.txtExchangeRate)
        Me.hdr.Controls.Add(Me.txt_trans_id)
        Me.hdr.Controls.Add(Me.txt_year)
        Me.hdr.Controls.Add(Me.txt_day)
        Me.hdr.Controls.Add(Me.txt_month)
        Me.hdr.Controls.Add(Me.txt_currency_name)
        Me.hdr.Controls.Add(Me.txt_general_name)
        Me.hdr.Controls.Add(Me.txt_description)
        Me.hdr.Controls.Add(Me.txt_amount_in_word)
        Me.hdr.Controls.Add(Me.txt_currency_id)
        Me.hdr.Controls.Add(Me.txt_general_id)
        Me.hdr.Controls.Add(Me.txt_trans_no)
        Me.hdr.Controls.Add(Me.Label14)
        Me.hdr.Controls.Add(Me.PictureBox2)
        Me.hdr.Controls.Add(Me.Label11)
        Me.hdr.Controls.Add(Me.Label10)
        Me.hdr.Controls.Add(Me.Label6)
        Me.hdr.Controls.Add(Me.Label5)
        Me.hdr.Controls.Add(Me.PictureBox1)
        Me.hdr.Controls.Add(Me.Label4)
        Me.hdr.Controls.Add(Me.Label3)
        Me.hdr.Controls.Add(Me.Label2)
        Me.hdr.Controls.Add(Me.Label7)
        Me.hdr.Controls.Add(Me.Label9)
        Me.hdr.Controls.Add(Me.Label8)
        Me.hdr.Location = New System.Drawing.Point(17, 98)
        Me.hdr.Name = "hdr"
        Me.hdr.Size = New System.Drawing.Size(771, 196)
        Me.hdr.TabIndex = 14
        '
        'txtAmountBased
        '
        Me.txtAmountBased.EditValue = "0.00"
        Me.txtAmountBased.Enabled = False
        Me.txtAmountBased.Location = New System.Drawing.Point(633, 81)
        Me.txtAmountBased.Name = "txtAmountBased"
        Me.txtAmountBased.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmountBased.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmountBased.Properties.DisplayFormat.FormatString = "n4"
        Me.txtAmountBased.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountBased.Properties.EditFormat.FormatString = "n4"
        Me.txtAmountBased.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountBased.Properties.Mask.EditMask = "n4"
        Me.txtAmountBased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountBased.Size = New System.Drawing.Size(135, 20)
        Me.txtAmountBased.TabIndex = 14
        Me.txtAmountBased.Tag = "amount_based"
        '
        'btnParticular
        '
        Me.btnParticular.Image = Global.accounting.My.Resources.Resources.Table_Icon
        Me.btnParticular.Location = New System.Drawing.Point(89, 143)
        Me.btnParticular.Name = "btnParticular"
        Me.btnParticular.Size = New System.Drawing.Size(25, 25)
        Me.btnParticular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnParticular.TabIndex = 330
        Me.btnParticular.TabStop = False
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "0.00"
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(120, 81)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.DisplayFormat.FormatString = "n4"
        Me.txtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.EditFormat.FormatString = "n4"
        Me.txtAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.Mask.EditMask = "n4"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Size = New System.Drawing.Size(135, 20)
        Me.txtAmount.TabIndex = 11
        Me.txtAmount.Tag = "amount"
        '
        'txtBasedRate
        '
        Me.txtBasedRate.EditValue = "0.00"
        Me.txtBasedRate.Enabled = False
        Me.txtBasedRate.Location = New System.Drawing.Point(461, 81)
        Me.txtBasedRate.Name = "txtBasedRate"
        Me.txtBasedRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBasedRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBasedRate.Properties.DisplayFormat.FormatString = "n4"
        Me.txtBasedRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRate.Properties.EditFormat.FormatString = "n4"
        Me.txtBasedRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRate.Properties.Mask.EditMask = "n4"
        Me.txtBasedRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBasedRate.Size = New System.Drawing.Size(80, 20)
        Me.txtBasedRate.TabIndex = 13
        Me.txtBasedRate.Tag = "based_rate"
        '
        'txt_trans_dc_id
        '
        Me.txt_trans_dc_id.AlwaysDisable = False
        Me.txt_trans_dc_id.AlwaysEnable = False
        Me.txt_trans_dc_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_dc_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_dc_id.BrowseDataSource = ""
        Me.txt_trans_dc_id.BrowseField = ""
        Me.txt_trans_dc_id.BrowseFilter = Nothing
        Me.txt_trans_dc_id.BrowseLabel = "Code,Name"
        Me.txt_trans_dc_id.BrowseLabelWidth = "100,200"
        Me.txt_trans_dc_id.BrowseTextSource = ""
        Me.txt_trans_dc_id.BrowseValueSource = ""
        Me.txt_trans_dc_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_trans_dc_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_dc_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_dc_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_dc_id.Enabled = False
        Me.txt_trans_dc_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_dc_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_trans_dc_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_dc_id.ID = False
        Me.txt_trans_dc_id.Location = New System.Drawing.Point(68, 163)
        Me.txt_trans_dc_id.Name = "txt_trans_dc_id"
        Me.txt_trans_dc_id.NoClear = False
        Me.txt_trans_dc_id.NoSave = False
        Me.txt_trans_dc_id.NumberFormat = "@"
        Me.txt_trans_dc_id.Required = False
        Me.txt_trans_dc_id.RowData = Nothing
        Me.txt_trans_dc_id.Size = New System.Drawing.Size(23, 20)
        Me.txt_trans_dc_id.TabIndex = 2
        Me.txt_trans_dc_id.TextBrowse = False
        Me.txt_trans_dc_id.TextSource = "trans_dc_id"
        Me.txt_trans_dc_id.ToUpper = True
        Me.txt_trans_dc_id.Unique = False
        Me.txt_trans_dc_id.Value = ""
        Me.txt_trans_dc_id.ValueSource = ""
        Me.txt_trans_dc_id.Visible = False
        '
        'txtExchangeRate
        '
        Me.txtExchangeRate.EditValue = "0.00"
        Me.txtExchangeRate.Enabled = False
        Me.txtExchangeRate.Location = New System.Drawing.Point(311, 81)
        Me.txtExchangeRate.Name = "txtExchangeRate"
        Me.txtExchangeRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExchangeRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExchangeRate.Properties.DisplayFormat.FormatString = "n4"
        Me.txtExchangeRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRate.Properties.EditFormat.FormatString = "n4"
        Me.txtExchangeRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRate.Properties.Mask.EditMask = "n4"
        Me.txtExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExchangeRate.Size = New System.Drawing.Size(80, 20)
        Me.txtExchangeRate.TabIndex = 12
        Me.txtExchangeRate.Tag = "exchange_rate"
        '
        'txt_trans_id
        '
        Me.txt_trans_id.AlwaysDisable = False
        Me.txt_trans_id.AlwaysEnable = False
        Me.txt_trans_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_id.BrowseDataSource = ""
        Me.txt_trans_id.BrowseField = ""
        Me.txt_trans_id.BrowseFilter = Nothing
        Me.txt_trans_id.BrowseLabel = "Code,Name"
        Me.txt_trans_id.BrowseLabelWidth = "100,200"
        Me.txt_trans_id.BrowseTextSource = ""
        Me.txt_trans_id.BrowseValueSource = ""
        Me.txt_trans_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_trans_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_id.Enabled = False
        Me.txt_trans_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_trans_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_id.ID = False
        Me.txt_trans_id.Location = New System.Drawing.Point(45, 163)
        Me.txt_trans_id.Name = "txt_trans_id"
        Me.txt_trans_id.NoClear = False
        Me.txt_trans_id.NoSave = False
        Me.txt_trans_id.NumberFormat = "@"
        Me.txt_trans_id.Required = False
        Me.txt_trans_id.RowData = Nothing
        Me.txt_trans_id.Size = New System.Drawing.Size(23, 20)
        Me.txt_trans_id.TabIndex = 1
        Me.txt_trans_id.TextBrowse = False
        Me.txt_trans_id.TextSource = "trans_id"
        Me.txt_trans_id.ToUpper = True
        Me.txt_trans_id.Unique = False
        Me.txt_trans_id.Value = ""
        Me.txt_trans_id.ValueSource = ""
        Me.txt_trans_id.Visible = False
        '
        'txt_year
        '
        Me.txt_year.AlwaysDisable = True
        Me.txt_year.AlwaysEnable = False
        Me.txt_year.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_year.BrowseDataSource = ""
        Me.txt_year.BrowseField = ""
        Me.txt_year.BrowseFilter = Nothing
        Me.txt_year.BrowseLabel = "Code,Name"
        Me.txt_year.BrowseLabelWidth = "100,200"
        Me.txt_year.BrowseTextSource = ""
        Me.txt_year.BrowseValueSource = ""
        Me.txt_year.Database = user_control.MyList.Database.FileSetup
        Me.txt_year.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_year.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_year.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_year.Enabled = False
        Me.txt_year.EnabledBackColor = System.Drawing.Color.White
        Me.txt_year.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_year.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_year.ID = False
        Me.txt_year.Location = New System.Drawing.Point(396, 18)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.NoClear = False
        Me.txt_year.NoSave = False
        Me.txt_year.NumberFormat = "###0"
        Me.txt_year.Required = False
        Me.txt_year.RowData = Nothing
        Me.txt_year.Size = New System.Drawing.Size(50, 20)
        Me.txt_year.TabIndex = 6
        Me.txt_year.Text = "0"
        Me.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_year.TextBrowse = False
        Me.txt_year.TextSource = "year"
        Me.txt_year.ToUpper = True
        Me.txt_year.Unique = False
        Me.txt_year.Value = ""
        Me.txt_year.ValueSource = ""
        '
        'txt_day
        '
        Me.txt_day.AlwaysDisable = False
        Me.txt_day.AlwaysEnable = False
        Me.txt_day.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_day.BrowseDataSource = ""
        Me.txt_day.BrowseField = ""
        Me.txt_day.BrowseFilter = Nothing
        Me.txt_day.BrowseLabel = "Code,Name"
        Me.txt_day.BrowseLabelWidth = "100,200"
        Me.txt_day.BrowseTextSource = ""
        Me.txt_day.BrowseValueSource = ""
        Me.txt_day.Database = user_control.MyList.Database.FileSetup
        Me.txt_day.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_day.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_day.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_day.Enabled = False
        Me.txt_day.EnabledBackColor = System.Drawing.Color.White
        Me.txt_day.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_day.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_day.ID = False
        Me.txt_day.Location = New System.Drawing.Point(362, 18)
        Me.txt_day.Name = "txt_day"
        Me.txt_day.NoClear = False
        Me.txt_day.NoSave = False
        Me.txt_day.NumberFormat = "i"
        Me.txt_day.Required = False
        Me.txt_day.RowData = Nothing
        Me.txt_day.Size = New System.Drawing.Size(33, 20)
        Me.txt_day.TabIndex = 5
        Me.txt_day.Text = "0"
        Me.txt_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_day.TextBrowse = False
        Me.txt_day.TextSource = "day"
        Me.txt_day.ToUpper = True
        Me.txt_day.Unique = False
        Me.txt_day.Value = ""
        Me.txt_day.ValueSource = ""
        '
        'txt_month
        '
        Me.txt_month.AlwaysDisable = True
        Me.txt_month.AlwaysEnable = False
        Me.txt_month.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_month.BrowseDataSource = ""
        Me.txt_month.BrowseField = ""
        Me.txt_month.BrowseFilter = Nothing
        Me.txt_month.BrowseLabel = "Code,Name"
        Me.txt_month.BrowseLabelWidth = "100,200"
        Me.txt_month.BrowseTextSource = ""
        Me.txt_month.BrowseValueSource = ""
        Me.txt_month.Database = user_control.MyList.Database.FileSetup
        Me.txt_month.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_month.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_month.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_month.Enabled = False
        Me.txt_month.EnabledBackColor = System.Drawing.Color.White
        Me.txt_month.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_month.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_month.ID = False
        Me.txt_month.Location = New System.Drawing.Point(311, 18)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.NoClear = False
        Me.txt_month.NoSave = False
        Me.txt_month.NumberFormat = "@"
        Me.txt_month.Required = False
        Me.txt_month.RowData = Nothing
        Me.txt_month.Size = New System.Drawing.Size(50, 20)
        Me.txt_month.TabIndex = 4
        Me.txt_month.TextBrowse = False
        Me.txt_month.TextSource = "month"
        Me.txt_month.ToUpper = True
        Me.txt_month.Unique = False
        Me.txt_month.Value = ""
        Me.txt_month.ValueSource = ""
        '
        'txt_currency_name
        '
        Me.txt_currency_name.AlwaysDisable = True
        Me.txt_currency_name.AlwaysEnable = False
        Me.txt_currency_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_name.BrowseDataSource = ""
        Me.txt_currency_name.BrowseField = ""
        Me.txt_currency_name.BrowseFilter = Nothing
        Me.txt_currency_name.BrowseLabel = "Code,Name"
        Me.txt_currency_name.BrowseLabelWidth = "100,200"
        Me.txt_currency_name.BrowseTextSource = ""
        Me.txt_currency_name.BrowseValueSource = ""
        Me.txt_currency_name.Database = user_control.MyList.Database.FileSetup
        Me.txt_currency_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_name.Enabled = False
        Me.txt_currency_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_name.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_currency_name.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_name.ID = False
        Me.txt_currency_name.Location = New System.Drawing.Point(275, 60)
        Me.txt_currency_name.Name = "txt_currency_name"
        Me.txt_currency_name.NoClear = False
        Me.txt_currency_name.NoSave = False
        Me.txt_currency_name.NumberFormat = "@"
        Me.txt_currency_name.Required = False
        Me.txt_currency_name.RowData = Nothing
        Me.txt_currency_name.Size = New System.Drawing.Size(493, 20)
        Me.txt_currency_name.TabIndex = 10
        Me.txt_currency_name.TextBrowse = False
        Me.txt_currency_name.TextSource = "currency_name"
        Me.txt_currency_name.ToUpper = True
        Me.txt_currency_name.Unique = False
        Me.txt_currency_name.Value = ""
        Me.txt_currency_name.ValueSource = ""
        '
        'txt_general_name
        '
        Me.txt_general_name.AlwaysDisable = True
        Me.txt_general_name.AlwaysEnable = False
        Me.txt_general_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_name.BrowseDataSource = ""
        Me.txt_general_name.BrowseField = ""
        Me.txt_general_name.BrowseFilter = Nothing
        Me.txt_general_name.BrowseLabel = "Code,Name"
        Me.txt_general_name.BrowseLabelWidth = "100,200"
        Me.txt_general_name.BrowseTextSource = ""
        Me.txt_general_name.BrowseValueSource = ""
        Me.txt_general_name.Database = user_control.MyList.Database.FileSetup
        Me.txt_general_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_name.Enabled = False
        Me.txt_general_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_name.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_general_name.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_name.ID = False
        Me.txt_general_name.Location = New System.Drawing.Point(275, 39)
        Me.txt_general_name.Name = "txt_general_name"
        Me.txt_general_name.NoClear = False
        Me.txt_general_name.NoSave = False
        Me.txt_general_name.NumberFormat = "@"
        Me.txt_general_name.Required = False
        Me.txt_general_name.RowData = Nothing
        Me.txt_general_name.Size = New System.Drawing.Size(493, 20)
        Me.txt_general_name.TabIndex = 8
        Me.txt_general_name.TextBrowse = False
        Me.txt_general_name.TextSource = "general_name"
        Me.txt_general_name.ToUpper = True
        Me.txt_general_name.Unique = False
        Me.txt_general_name.Value = ""
        Me.txt_general_name.ValueSource = ""
        '
        'txt_description
        '
        Me.txt_description.AlwaysDisable = False
        Me.txt_description.AlwaysEnable = False
        Me.txt_description.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_description.BrowseDataSource = ""
        Me.txt_description.BrowseField = ""
        Me.txt_description.BrowseFilter = Nothing
        Me.txt_description.BrowseLabel = "Code,Name"
        Me.txt_description.BrowseLabelWidth = "100,200"
        Me.txt_description.BrowseTextSource = ""
        Me.txt_description.BrowseValueSource = ""
        Me.txt_description.Database = user_control.MyList.Database.FileSetup
        Me.txt_description.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_description.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_description.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_description.Enabled = False
        Me.txt_description.EnabledBackColor = System.Drawing.Color.White
        Me.txt_description.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_description.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_description.ID = False
        Me.txt_description.Location = New System.Drawing.Point(120, 143)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.NoClear = False
        Me.txt_description.NoSave = False
        Me.txt_description.NumberFormat = "@"
        Me.txt_description.Required = False
        Me.txt_description.RowData = Nothing
        Me.txt_description.Size = New System.Drawing.Size(648, 40)
        Me.txt_description.TabIndex = 16
        Me.txt_description.TextBrowse = False
        Me.txt_description.TextSource = ""
        Me.txt_description.ToUpper = False
        Me.txt_description.Unique = False
        Me.txt_description.Value = ""
        Me.txt_description.ValueSource = "description"
        '
        'txt_amount_in_word
        '
        Me.txt_amount_in_word.AlwaysDisable = True
        Me.txt_amount_in_word.AlwaysEnable = False
        Me.txt_amount_in_word.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_amount_in_word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amount_in_word.BrowseDataSource = ""
        Me.txt_amount_in_word.BrowseField = ""
        Me.txt_amount_in_word.BrowseFilter = Nothing
        Me.txt_amount_in_word.BrowseLabel = "Code,Name"
        Me.txt_amount_in_word.BrowseLabelWidth = "100,200"
        Me.txt_amount_in_word.BrowseTextSource = ""
        Me.txt_amount_in_word.BrowseValueSource = ""
        Me.txt_amount_in_word.Database = user_control.MyList.Database.FileSetup
        Me.txt_amount_in_word.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_amount_in_word.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_amount_in_word.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_amount_in_word.Enabled = False
        Me.txt_amount_in_word.EnabledBackColor = System.Drawing.Color.White
        Me.txt_amount_in_word.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_amount_in_word.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_amount_in_word.ID = False
        Me.txt_amount_in_word.Location = New System.Drawing.Point(120, 102)
        Me.txt_amount_in_word.Multiline = True
        Me.txt_amount_in_word.Name = "txt_amount_in_word"
        Me.txt_amount_in_word.NoClear = False
        Me.txt_amount_in_word.NoSave = False
        Me.txt_amount_in_word.NumberFormat = "@"
        Me.txt_amount_in_word.Required = False
        Me.txt_amount_in_word.RowData = Nothing
        Me.txt_amount_in_word.Size = New System.Drawing.Size(648, 40)
        Me.txt_amount_in_word.TabIndex = 15
        Me.txt_amount_in_word.TextBrowse = False
        Me.txt_amount_in_word.TextSource = ""
        Me.txt_amount_in_word.ToUpper = True
        Me.txt_amount_in_word.Unique = False
        Me.txt_amount_in_word.Value = ""
        Me.txt_amount_in_word.ValueSource = "amount_in_word"
        '
        'txt_currency_id
        '
        Me.txt_currency_id.AlwaysDisable = False
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.BrowseDataSource = "[currency]"
        Me.txt_currency_id.BrowseField = "currency_code,currency_name"
        Me.txt_currency_id.BrowseFilter = Nothing
        Me.txt_currency_id.BrowseLabel = "Code,Name"
        Me.txt_currency_id.BrowseLabelWidth = "100,200"
        Me.txt_currency_id.BrowseTextSource = "currency_code"
        Me.txt_currency_id.BrowseUpdate.Add(CType(resources.GetObject("txt_currency_id.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_currency_id.BrowseUpdate.Add(CType(resources.GetObject("txt_currency_id.BrowseUpdate1"), user_control.MyTextBoxList))
        Me.txt_currency_id.BrowseUpdate.Add(CType(resources.GetObject("txt_currency_id.BrowseUpdate2"), user_control.MyTextBoxList))
        Me.txt_currency_id.BrowseValueSource = "currency_id"
        Me.txt_currency_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.Enabled = False
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_currency_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.ID = False
        Me.txt_currency_id.Location = New System.Drawing.Point(120, 60)
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NoSave = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = True
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.Size = New System.Drawing.Size(135, 20)
        Me.txt_currency_id.TabIndex = 9
        Me.txt_currency_id.TextBrowse = True
        Me.txt_currency_id.TextSource = "currency_code"
        Me.txt_currency_id.ToUpper = True
        Me.txt_currency_id.Unique = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = "currency_id"
        '
        'txt_general_id
        '
        Me.txt_general_id.AlwaysDisable = False
        Me.txt_general_id.AlwaysEnable = False
        Me.txt_general_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.BrowseDataSource = "[general_client]"
        Me.txt_general_id.BrowseField = "general_code,general_name"
        Me.txt_general_id.BrowseFilter = Nothing
        Me.txt_general_id.BrowseLabel = "Code,Name"
        Me.txt_general_id.BrowseLabelWidth = "100,200"
        Me.txt_general_id.BrowseTextSource = "general_code"
        Me.txt_general_id.BrowseUpdate.Add(CType(resources.GetObject("txt_general_id.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_general_id.BrowseValueSource = "general_id"
        Me.txt_general_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.Enabled = False
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_general_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.ID = False
        Me.txt_general_id.Location = New System.Drawing.Point(120, 39)
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NoSave = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = True
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.Size = New System.Drawing.Size(135, 20)
        Me.txt_general_id.TabIndex = 7
        Me.txt_general_id.TextBrowse = True
        Me.txt_general_id.TextSource = "general_code"
        Me.txt_general_id.ToUpper = True
        Me.txt_general_id.Unique = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = "general_id"
        '
        'txt_trans_no
        '
        Me.txt_trans_no.AlwaysDisable = False
        Me.txt_trans_no.AlwaysEnable = False
        Me.txt_trans_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_no.BrowseDataSource = ""
        Me.txt_trans_no.BrowseField = ""
        Me.txt_trans_no.BrowseFilter = Nothing
        Me.txt_trans_no.BrowseLabel = "Code,Name"
        Me.txt_trans_no.BrowseLabelWidth = "100,200"
        Me.txt_trans_no.BrowseTextSource = ""
        Me.txt_trans_no.BrowseValueSource = ""
        Me.txt_trans_no.Database = user_control.MyList.Database.FileSetup
        Me.txt_trans_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_no.Enabled = False
        Me.txt_trans_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_no.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_trans_no.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_no.ID = False
        Me.txt_trans_no.Location = New System.Drawing.Point(120, 18)
        Me.txt_trans_no.Name = "txt_trans_no"
        Me.txt_trans_no.NoClear = False
        Me.txt_trans_no.NoSave = False
        Me.txt_trans_no.NumberFormat = "@"
        Me.txt_trans_no.Required = False
        Me.txt_trans_no.RowData = Nothing
        Me.txt_trans_no.Size = New System.Drawing.Size(135, 20)
        Me.txt_trans_no.TabIndex = 3
        Me.txt_trans_no.TextBrowse = False
        Me.txt_trans_no.TextSource = "trans_no"
        Me.txt_trans_no.ToUpper = True
        Me.txt_trans_no.Unique = False
        Me.txt_trans_no.Value = ""
        Me.txt_trans_no.ValueSource = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(101, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 16)
        Me.Label14.TabIndex = 185
        Me.Label14.Text = "*"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(257, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 174
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Particulars"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(5, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 31)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Amount in Words"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Currency"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(257, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 149
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Debit / Credit No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Ex. Rate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(550, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Based Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(392, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Based Rate"
        '
        'lbldiffbasedtotal
        '
        Me.lbldiffbasedtotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiffbasedtotal.ForeColor = System.Drawing.Color.Red
        Me.lbldiffbasedtotal.Location = New System.Drawing.Point(641, 456)
        Me.lbldiffbasedtotal.Name = "lbldiffbasedtotal"
        Me.lbldiffbasedtotal.Size = New System.Drawing.Size(115, 11)
        Me.lbldiffbasedtotal.TabIndex = 321
        Me.lbldiffbasedtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebitbasedtotal
        '
        Me.lbldebitbasedtotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebitbasedtotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbldebitbasedtotal.Location = New System.Drawing.Point(407, 456)
        Me.lbldebitbasedtotal.Name = "lbldebitbasedtotal"
        Me.lbldebitbasedtotal.Size = New System.Drawing.Size(115, 11)
        Me.lbldebitbasedtotal.TabIndex = 320
        Me.lbldebitbasedtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcreditbasedtotal
        '
        Me.lblcreditbasedtotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreditbasedtotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblcreditbasedtotal.Location = New System.Drawing.Point(526, 456)
        Me.lblcreditbasedtotal.Name = "lblcreditbasedtotal"
        Me.lblcreditbasedtotal.Size = New System.Drawing.Size(115, 11)
        Me.lblcreditbasedtotal.TabIndex = 319
        Me.lblcreditbasedtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldifftotal
        '
        Me.lbldifftotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldifftotal.ForeColor = System.Drawing.Color.Red
        Me.lbldifftotal.Location = New System.Drawing.Point(279, 456)
        Me.lbldifftotal.Name = "lbldifftotal"
        Me.lbldifftotal.Size = New System.Drawing.Size(115, 11)
        Me.lbldifftotal.TabIndex = 318
        Me.lbldifftotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebittotal
        '
        Me.lbldebittotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebittotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbldebittotal.Location = New System.Drawing.Point(45, 456)
        Me.lbldebittotal.Name = "lbldebittotal"
        Me.lbldebittotal.Size = New System.Drawing.Size(115, 11)
        Me.lbldebittotal.TabIndex = 317
        Me.lbldebittotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(20, 297)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(100, 24)
        Me.btnInsert.TabIndex = 34
        Me.btnInsert.Text = "&Insert Entry"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(226, 297)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 24)
        Me.btnRemove.TabIndex = 36
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lblcredittotal
        '
        Me.lblcredittotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcredittotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblcredittotal.Location = New System.Drawing.Point(164, 456)
        Me.lblcredittotal.Name = "lblcredittotal"
        Me.lblcredittotal.Size = New System.Drawing.Size(115, 11)
        Me.lblcredittotal.TabIndex = 316
        Me.lblcredittotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(123, 297)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 24)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "&Update Entry"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'dgjbooks
        '
        Me.dgjbooks.AllowUserToAddRows = False
        Me.dgjbooks.AllowUserToDeleteRows = False
        Me.dgjbooks.AllowUserToResizeColumns = False
        Me.dgjbooks.AllowUserToResizeRows = False
        Me.dgjbooks.BackgroundColor = System.Drawing.Color.White
        Me.dgjbooks.ColumnHeadersHeight = 28
        Me.dgjbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgjbooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.Column1, Me.deleted, Me.jbooks_id_tmp, Me.account_code, Me.account_name, Me.debit_based, Me.credit_based, Me.general_code, Me.general_name, Me.ref_trans_no, Me.dc, Me.offset, Me.validation, Me.minimum})
        Me.dgjbooks.Location = New System.Drawing.Point(20, 323)
        Me.dgjbooks.MultiSelect = False
        Me.dgjbooks.Name = "dgjbooks"
        Me.dgjbooks.RowHeadersVisible = False
        Me.dgjbooks.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgjbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgjbooks.Size = New System.Drawing.Size(768, 130)
        Me.dgjbooks.TabIndex = 37
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.Width = 30
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "unit_applicable"
        Me.Column1.HeaderText = "unit_applicable"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Visible = False
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Visible = False
        '
        'jbooks_id_tmp
        '
        Me.jbooks_id_tmp.DataPropertyName = "jbooks_id_tmp"
        Me.jbooks_id_tmp.HeaderText = "id"
        Me.jbooks_id_tmp.Name = "jbooks_id_tmp"
        Me.jbooks_id_tmp.ReadOnly = True
        Me.jbooks_id_tmp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jbooks_id_tmp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.jbooks_id_tmp.Visible = False
        '
        'account_code
        '
        Me.account_code.DataPropertyName = "account_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.account_code.HeaderText = "Acct. Code"
        Me.account_code.Name = "account_code"
        Me.account_code.ReadOnly = True
        Me.account_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.account_code.Width = 80
        '
        'account_name
        '
        Me.account_name.DataPropertyName = "account_name"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.account_name.HeaderText = "Acct. Title"
        Me.account_name.Name = "account_name"
        Me.account_name.ReadOnly = True
        Me.account_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.account_name.Width = 160
        '
        'debit_based
        '
        Me.debit_based.DataPropertyName = "debit_based"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "##,##0.00"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.debit_based.DefaultCellStyle = DataGridViewCellStyle3
        Me.debit_based.HeaderText = "Debit Based"
        Me.debit_based.Name = "debit_based"
        Me.debit_based.ReadOnly = True
        Me.debit_based.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.debit_based.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'credit_based
        '
        Me.credit_based.DataPropertyName = "credit_based"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "##,##0.00"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.credit_based.DefaultCellStyle = DataGridViewCellStyle4
        Me.credit_based.HeaderText = "Credit Based"
        Me.credit_based.Name = "credit_based"
        Me.credit_based.ReadOnly = True
        Me.credit_based.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.credit_based.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'general_code
        '
        Me.general_code.DataPropertyName = "general_code"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.general_code.DefaultCellStyle = DataGridViewCellStyle5
        Me.general_code.HeaderText = "Gen. Ref."
        Me.general_code.Name = "general_code"
        Me.general_code.ReadOnly = True
        Me.general_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.general_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.general_name.DefaultCellStyle = DataGridViewCellStyle6
        Me.general_name.HeaderText = "Gen. Name"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        Me.general_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.general_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.general_name.Width = 160
        '
        'ref_trans_no
        '
        Me.ref_trans_no.DataPropertyName = "ref_trans_no"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref_trans_no.DefaultCellStyle = DataGridViewCellStyle7
        Me.ref_trans_no.HeaderText = "D.N. Reference"
        Me.ref_trans_no.Name = "ref_trans_no"
        Me.ref_trans_no.ReadOnly = True
        Me.ref_trans_no.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ref_trans_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dc
        '
        Me.dc.DataPropertyName = "dc"
        Me.dc.HeaderText = "Column9"
        Me.dc.Name = "dc"
        Me.dc.Visible = False
        '
        'offset
        '
        Me.offset.DataPropertyName = "offset"
        Me.offset.HeaderText = "Offset"
        Me.offset.Name = "offset"
        Me.offset.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.offset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.offset.Visible = False
        '
        'validation
        '
        Me.validation.DataPropertyName = "validation"
        Me.validation.HeaderText = "validation"
        Me.validation.Name = "validation"
        Me.validation.Visible = False
        '
        'minimum
        '
        Me.minimum.DataPropertyName = "minimum"
        Me.minimum.HeaderText = "minimum"
        Me.minimum.Name = "minimum"
        Me.minimum.Visible = False
        '
        'det
        '
        Me.det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.det.Controls.Add(Me.txt_noCompute)
        Me.det.Controls.Add(Me.txt_project_unit_no_id)
        Me.det.Controls.Add(Me.txt_particulars_det)
        Me.det.Controls.Add(Me.PictureBox5)
        Me.det.Controls.Add(Me.txt_book_unit_no_id)
        Me.det.Controls.Add(Me.lblUnitNo)
        Me.det.Controls.Add(Me.txtCreditBased)
        Me.det.Controls.Add(Me.txtCredit)
        Me.det.Controls.Add(Me.txtDebitBased)
        Me.det.Controls.Add(Me.txtDebit)
        Me.det.Controls.Add(Me.txtBasedRateDet)
        Me.det.Controls.Add(Me.txt_validation)
        Me.det.Controls.Add(Me.txt_tmp_jbooks_id)
        Me.det.Controls.Add(Me.txtExchangeRateDet)
        Me.det.Controls.Add(Me.txt_ref_book_code)
        Me.det.Controls.Add(Me.txt_ref_journal_code)
        Me.det.Controls.Add(Me.txt_allocation_id)
        Me.det.Controls.Add(Me.txt_nodays_det)
        Me.det.Controls.Add(Me.txt_terms_id_det)
        Me.det.Controls.Add(Me.txt_department_id)
        Me.det.Controls.Add(Me.txt_general_name_det)
        Me.det.Controls.Add(Me.txt_ref_jbooks_id)
        Me.det.Controls.Add(Me.txt_general_id_det)
        Me.det.Controls.Add(Me.txt_project_id)
        Me.det.Controls.Add(Me.txt_account_name)
        Me.det.Controls.Add(Me.lbltermsdet)
        Me.det.Controls.Add(Me.Label28)
        Me.det.Controls.Add(Me.Label29)
        Me.det.Controls.Add(Me.btnUndo)
        Me.det.Controls.Add(Me.txt_currency_id_det)
        Me.det.Controls.Add(Me.btnOK)
        Me.det.Controls.Add(Me.txt_account_id)
        Me.det.Controls.Add(Me.txt_line_remarks)
        Me.det.Controls.Add(Me.lblbasedrate)
        Me.det.Controls.Add(Me.lblLineRemarks)
        Me.det.Controls.Add(Me.Label25)
        Me.det.Controls.Add(Me.lblexchangerate)
        Me.det.Controls.Add(Me.PictureBox4)
        Me.det.Controls.Add(Me.Label24)
        Me.det.Controls.Add(Me.lblcurrency)
        Me.det.Controls.Add(Me.Label23)
        Me.det.Controls.Add(Me.Label22)
        Me.det.Controls.Add(Me.lblAllocation)
        Me.det.Controls.Add(Me.lblDepartment)
        Me.det.Controls.Add(Me.lblProject)
        Me.det.Controls.Add(Me.PictureBox3)
        Me.det.Controls.Add(Me.Label20)
        Me.det.Location = New System.Drawing.Point(20, 469)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(768, 185)
        Me.det.TabIndex = 38
        '
        'txt_noCompute
        '
        Me.txt_noCompute.AutoSize = True
        Me.txt_noCompute.Location = New System.Drawing.Point(231, 99)
        Me.txt_noCompute.Name = "txt_noCompute"
        Me.txt_noCompute.Size = New System.Drawing.Size(15, 14)
        Me.txt_noCompute.TabIndex = 343
        Me.txt_noCompute.Tag = "noCompute"
        Me.txt_noCompute.UseVisualStyleBackColor = True
        Me.txt_noCompute.Visible = False
        '
        'txt_project_unit_no_id
        '
        Me.txt_project_unit_no_id.AlwaysDisable = False
        Me.txt_project_unit_no_id.AlwaysEnable = False
        Me.txt_project_unit_no_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_unit_no_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_unit_no_id.BrowseDataSource = "lib_erp_project_unit_no"
        Me.txt_project_unit_no_id.BrowseField = "project_unit_no_codes,project_unit_no_names"
        Me.txt_project_unit_no_id.BrowseFilter = Me.txt_project_id
        Me.txt_project_unit_no_id.BrowseLabel = "Code,Name"
        Me.txt_project_unit_no_id.BrowseLabelWidth = "100,200"
        Me.txt_project_unit_no_id.BrowseTextSource = "project_unit_no_names"
        Me.txt_project_unit_no_id.BrowseValueSource = "project_unit_no_id"
        Me.txt_project_unit_no_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_project_unit_no_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_unit_no_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_unit_no_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_unit_no_id.Enabled = False
        Me.txt_project_unit_no_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_unit_no_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_project_unit_no_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_unit_no_id.ID = False
        Me.txt_project_unit_no_id.Location = New System.Drawing.Point(638, 73)
        Me.txt_project_unit_no_id.Name = "txt_project_unit_no_id"
        Me.txt_project_unit_no_id.NoClear = False
        Me.txt_project_unit_no_id.NoSave = False
        Me.txt_project_unit_no_id.NumberFormat = "@"
        Me.txt_project_unit_no_id.Required = True
        Me.txt_project_unit_no_id.RowData = Nothing
        Me.txt_project_unit_no_id.Size = New System.Drawing.Size(125, 20)
        Me.txt_project_unit_no_id.TabIndex = 342
        Me.txt_project_unit_no_id.TextBrowse = True
        Me.txt_project_unit_no_id.TextSource = "project_unit_no_names"
        Me.txt_project_unit_no_id.ToUpper = True
        Me.txt_project_unit_no_id.Unique = False
        Me.txt_project_unit_no_id.Value = ""
        Me.txt_project_unit_no_id.ValueSource = "project_unit_no_id"
        '
        'txt_project_id
        '
        Me.txt_project_id.AlwaysDisable = False
        Me.txt_project_id.AlwaysEnable = False
        Me.txt_project_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_id.BrowseDataSource = "lib_erp_project"
        Me.txt_project_id.BrowseField = "project_code,project_name"
        Me.txt_project_id.BrowseFilter = Nothing
        Me.txt_project_id.BrowseLabel = "Code,Name"
        Me.txt_project_id.BrowseLabelWidth = "100,200"
        Me.txt_project_id.BrowseTextSource = "project_name"
        Me.txt_project_id.BrowseValueSource = "project_id"
        Me.txt_project_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_project_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.Enabled = False
        Me.txt_project_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_project_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.ID = False
        Me.txt_project_id.Location = New System.Drawing.Point(100, 73)
        Me.txt_project_id.Name = "txt_project_id"
        Me.txt_project_id.NoClear = False
        Me.txt_project_id.NoSave = False
        Me.txt_project_id.NumberFormat = "@"
        Me.txt_project_id.Required = True
        Me.txt_project_id.RowData = Nothing
        Me.txt_project_id.Size = New System.Drawing.Size(125, 20)
        Me.txt_project_id.TabIndex = 10
        Me.txt_project_id.TextBrowse = True
        Me.txt_project_id.TextSource = "project_name"
        Me.txt_project_id.ToUpper = True
        Me.txt_project_id.Unique = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = "project_id"
        '
        'txt_particulars_det
        '
        Me.txt_particulars_det.AlwaysDisable = True
        Me.txt_particulars_det.AlwaysEnable = False
        Me.txt_particulars_det.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_particulars_det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_particulars_det.BrowseDataSource = ""
        Me.txt_particulars_det.BrowseField = ""
        Me.txt_particulars_det.BrowseFilter = Nothing
        Me.txt_particulars_det.BrowseLabel = "Code,Name"
        Me.txt_particulars_det.BrowseLabelWidth = "100,200"
        Me.txt_particulars_det.BrowseTextSource = ""
        Me.txt_particulars_det.BrowseValueSource = ""
        Me.txt_particulars_det.Database = user_control.MyList.Database.FileSetup
        Me.txt_particulars_det.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_particulars_det.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_particulars_det.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_particulars_det.Enabled = False
        Me.txt_particulars_det.EnabledBackColor = System.Drawing.Color.White
        Me.txt_particulars_det.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_particulars_det.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_particulars_det.ID = False
        Me.txt_particulars_det.Location = New System.Drawing.Point(245, 157)
        Me.txt_particulars_det.Name = "txt_particulars_det"
        Me.txt_particulars_det.NoClear = False
        Me.txt_particulars_det.NoSave = False
        Me.txt_particulars_det.NumberFormat = "@"
        Me.txt_particulars_det.Required = False
        Me.txt_particulars_det.RowData = Nothing
        Me.txt_particulars_det.Size = New System.Drawing.Size(311, 20)
        Me.txt_particulars_det.TabIndex = 340
        Me.txt_particulars_det.Tag = "adjustToTop"
        Me.txt_particulars_det.TextBrowse = False
        Me.txt_particulars_det.TextSource = "particulars"
        Me.txt_particulars_det.ToUpper = True
        Me.txt_particulars_det.Unique = False
        Me.txt_particulars_det.Value = ""
        Me.txt_particulars_det.ValueSource = ""
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(227, 159)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 341
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "adjustToTop"
        '
        'txt_book_unit_no_id
        '
        Me.txt_book_unit_no_id.AlwaysDisable = False
        Me.txt_book_unit_no_id.AlwaysEnable = False
        Me.txt_book_unit_no_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_unit_no_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_unit_no_id.BrowseDataSource = "lib_erp_book_unit_no"
        Me.txt_book_unit_no_id.BrowseField = "book_unit_no_code,book_unit_no_name"
        Me.txt_book_unit_no_id.BrowseFilter = Nothing
        Me.txt_book_unit_no_id.BrowseLabel = "Code,Name"
        Me.txt_book_unit_no_id.BrowseLabelWidth = "100,200"
        Me.txt_book_unit_no_id.BrowseTextSource = "book_unit_no_name"
        Me.txt_book_unit_no_id.BrowseValueSource = "book_unit_no_id"
        Me.txt_book_unit_no_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_book_unit_no_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_unit_no_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_unit_no_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_unit_no_id.Enabled = False
        Me.txt_book_unit_no_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_book_unit_no_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_book_unit_no_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_unit_no_id.ID = False
        Me.txt_book_unit_no_id.Location = New System.Drawing.Point(638, 73)
        Me.txt_book_unit_no_id.Name = "txt_book_unit_no_id"
        Me.txt_book_unit_no_id.NoClear = False
        Me.txt_book_unit_no_id.NoSave = False
        Me.txt_book_unit_no_id.NumberFormat = "@"
        Me.txt_book_unit_no_id.Required = True
        Me.txt_book_unit_no_id.RowData = Nothing
        Me.txt_book_unit_no_id.Size = New System.Drawing.Size(125, 20)
        Me.txt_book_unit_no_id.TabIndex = 13
        Me.txt_book_unit_no_id.TextBrowse = True
        Me.txt_book_unit_no_id.TextSource = "book_unit_no_name"
        Me.txt_book_unit_no_id.ToUpper = True
        Me.txt_book_unit_no_id.Unique = False
        Me.txt_book_unit_no_id.Value = ""
        Me.txt_book_unit_no_id.ValueSource = "book_unit_no_id"
        '
        'lblUnitNo
        '
        Me.lblUnitNo.AutoSize = True
        Me.lblUnitNo.Location = New System.Drawing.Point(570, 76)
        Me.lblUnitNo.Name = "lblUnitNo"
        Me.lblUnitNo.Size = New System.Drawing.Size(43, 13)
        Me.lblUnitNo.TabIndex = 221
        Me.lblUnitNo.Text = "Unit No"
        '
        'txtCreditBased
        '
        Me.txtCreditBased.EditValue = "0.00"
        Me.txtCreditBased.Enabled = False
        Me.txtCreditBased.Location = New System.Drawing.Point(355, 115)
        Me.txtCreditBased.Name = "txtCreditBased"
        Me.txtCreditBased.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCreditBased.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCreditBased.Properties.DisplayFormat.FormatString = "n4"
        Me.txtCreditBased.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCreditBased.Properties.EditFormat.FormatString = "n4"
        Me.txtCreditBased.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCreditBased.Properties.Mask.EditMask = "n4"
        Me.txtCreditBased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCreditBased.Size = New System.Drawing.Size(125, 20)
        Me.txtCreditBased.TabIndex = 17
        Me.txtCreditBased.Tag = "credit_based"
        '
        'txtCredit
        '
        Me.txtCredit.EditValue = "0.00"
        Me.txtCredit.Enabled = False
        Me.txtCredit.Location = New System.Drawing.Point(100, 115)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredit.Properties.DisplayFormat.FormatString = "n4"
        Me.txtCredit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCredit.Properties.EditFormat.FormatString = "n4"
        Me.txtCredit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCredit.Properties.Mask.EditMask = "n4"
        Me.txtCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCredit.Size = New System.Drawing.Size(125, 20)
        Me.txtCredit.TabIndex = 16
        Me.txtCredit.Tag = "credit"
        '
        'txtDebitBased
        '
        Me.txtDebitBased.EditValue = "0.00"
        Me.txtDebitBased.Enabled = False
        Me.txtDebitBased.Location = New System.Drawing.Point(355, 94)
        Me.txtDebitBased.Name = "txtDebitBased"
        Me.txtDebitBased.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebitBased.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebitBased.Properties.DisplayFormat.FormatString = "n4"
        Me.txtDebitBased.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitBased.Properties.EditFormat.FormatString = "n4"
        Me.txtDebitBased.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitBased.Properties.Mask.EditMask = "n4"
        Me.txtDebitBased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebitBased.Size = New System.Drawing.Size(125, 20)
        Me.txtDebitBased.TabIndex = 15
        Me.txtDebitBased.Tag = "debit_based"
        '
        'txtDebit
        '
        Me.txtDebit.EditValue = "0.00"
        Me.txtDebit.Enabled = False
        Me.txtDebit.Location = New System.Drawing.Point(100, 94)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebit.Properties.DisplayFormat.FormatString = "n4"
        Me.txtDebit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebit.Properties.EditFormat.FormatString = "n4"
        Me.txtDebit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebit.Properties.Mask.EditMask = "n4"
        Me.txtDebit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebit.Size = New System.Drawing.Size(125, 20)
        Me.txtDebit.TabIndex = 14
        Me.txtDebit.Tag = "debit"
        '
        'txtBasedRateDet
        '
        Me.txtBasedRateDet.EditValue = "0.00"
        Me.txtBasedRateDet.Enabled = False
        Me.txtBasedRateDet.Location = New System.Drawing.Point(638, 52)
        Me.txtBasedRateDet.Name = "txtBasedRateDet"
        Me.txtBasedRateDet.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBasedRateDet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBasedRateDet.Properties.DisplayFormat.FormatString = "n4"
        Me.txtBasedRateDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRateDet.Properties.EditFormat.FormatString = "n4"
        Me.txtBasedRateDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBasedRateDet.Properties.Mask.EditMask = "n4"
        Me.txtBasedRateDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBasedRateDet.Size = New System.Drawing.Size(125, 20)
        Me.txtBasedRateDet.TabIndex = 6
        Me.txtBasedRateDet.Tag = "based_rate"
        '
        'txt_validation
        '
        Me.txt_validation.AlwaysDisable = True
        Me.txt_validation.AlwaysEnable = False
        Me.txt_validation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_validation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_validation.BrowseDataSource = ""
        Me.txt_validation.BrowseField = ""
        Me.txt_validation.BrowseFilter = Nothing
        Me.txt_validation.BrowseLabel = "Code,Name"
        Me.txt_validation.BrowseLabelWidth = "100,200"
        Me.txt_validation.BrowseTextSource = ""
        Me.txt_validation.BrowseValueSource = ""
        Me.txt_validation.Database = user_control.MyList.Database.FileSetup
        Me.txt_validation.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_validation.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_validation.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_validation.Enabled = False
        Me.txt_validation.EnabledBackColor = System.Drawing.Color.White
        Me.txt_validation.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_validation.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_validation.ID = False
        Me.txt_validation.Location = New System.Drawing.Point(227, 73)
        Me.txt_validation.Name = "txt_validation"
        Me.txt_validation.NoClear = False
        Me.txt_validation.NoSave = False
        Me.txt_validation.NumberFormat = "@"
        Me.txt_validation.Required = False
        Me.txt_validation.RowData = Nothing
        Me.txt_validation.Size = New System.Drawing.Size(23, 20)
        Me.txt_validation.TabIndex = 11
        Me.txt_validation.Tag = "adjustToTop"
        Me.txt_validation.TextBrowse = False
        Me.txt_validation.TextSource = "validation"
        Me.txt_validation.ToUpper = True
        Me.txt_validation.Unique = False
        Me.txt_validation.Value = ""
        Me.txt_validation.ValueSource = ""
        Me.txt_validation.Visible = False
        '
        'txt_tmp_jbooks_id
        '
        Me.txt_tmp_jbooks_id.AlwaysDisable = False
        Me.txt_tmp_jbooks_id.AlwaysEnable = False
        Me.txt_tmp_jbooks_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tmp_jbooks_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tmp_jbooks_id.BrowseDataSource = ""
        Me.txt_tmp_jbooks_id.BrowseField = ""
        Me.txt_tmp_jbooks_id.BrowseFilter = Nothing
        Me.txt_tmp_jbooks_id.BrowseLabel = "Code,Name"
        Me.txt_tmp_jbooks_id.BrowseLabelWidth = "100,200"
        Me.txt_tmp_jbooks_id.BrowseTextSource = ""
        Me.txt_tmp_jbooks_id.BrowseValueSource = ""
        Me.txt_tmp_jbooks_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_tmp_jbooks_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tmp_jbooks_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tmp_jbooks_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tmp_jbooks_id.Enabled = False
        Me.txt_tmp_jbooks_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_tmp_jbooks_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_tmp_jbooks_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tmp_jbooks_id.ID = False
        Me.txt_tmp_jbooks_id.Location = New System.Drawing.Point(291, 157)
        Me.txt_tmp_jbooks_id.Name = "txt_tmp_jbooks_id"
        Me.txt_tmp_jbooks_id.NoClear = False
        Me.txt_tmp_jbooks_id.NoSave = False
        Me.txt_tmp_jbooks_id.NumberFormat = "@"
        Me.txt_tmp_jbooks_id.Required = False
        Me.txt_tmp_jbooks_id.RowData = Nothing
        Me.txt_tmp_jbooks_id.Size = New System.Drawing.Size(210, 20)
        Me.txt_tmp_jbooks_id.TabIndex = 1
        Me.txt_tmp_jbooks_id.Tag = "adjustToTop"
        Me.txt_tmp_jbooks_id.TextBrowse = False
        Me.txt_tmp_jbooks_id.TextSource = "jbooks_id_tmp"
        Me.txt_tmp_jbooks_id.ToUpper = True
        Me.txt_tmp_jbooks_id.Unique = False
        Me.txt_tmp_jbooks_id.Value = ""
        Me.txt_tmp_jbooks_id.ValueSource = ""
        Me.txt_tmp_jbooks_id.Visible = False
        '
        'txtExchangeRateDet
        '
        Me.txtExchangeRateDet.EditValue = "0.00"
        Me.txtExchangeRateDet.Enabled = False
        Me.txtExchangeRateDet.Location = New System.Drawing.Point(355, 52)
        Me.txtExchangeRateDet.Name = "txtExchangeRateDet"
        Me.txtExchangeRateDet.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExchangeRateDet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExchangeRateDet.Properties.DisplayFormat.FormatString = "n4"
        Me.txtExchangeRateDet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRateDet.Properties.EditFormat.FormatString = "n4"
        Me.txtExchangeRateDet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExchangeRateDet.Properties.Mask.EditMask = "n4"
        Me.txtExchangeRateDet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExchangeRateDet.Size = New System.Drawing.Size(125, 20)
        Me.txtExchangeRateDet.TabIndex = 5
        Me.txtExchangeRateDet.Tag = "exchange_rate"
        '
        'txt_ref_book_code
        '
        Me.txt_ref_book_code.AlwaysDisable = False
        Me.txt_ref_book_code.AlwaysEnable = False
        Me.txt_ref_book_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_book_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ref_book_code.BrowseDataSource = ""
        Me.txt_ref_book_code.BrowseField = ""
        Me.txt_ref_book_code.BrowseFilter = Nothing
        Me.txt_ref_book_code.BrowseLabel = "Code,Name"
        Me.txt_ref_book_code.BrowseLabelWidth = "100,200"
        Me.txt_ref_book_code.BrowseTextSource = ""
        Me.txt_ref_book_code.BrowseValueSource = ""
        Me.txt_ref_book_code.Database = user_control.MyList.Database.FileSetup
        Me.txt_ref_book_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_book_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_book_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ref_book_code.Enabled = False
        Me.txt_ref_book_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_ref_book_code.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_ref_book_code.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ref_book_code.ID = False
        Me.txt_ref_book_code.Location = New System.Drawing.Point(268, 157)
        Me.txt_ref_book_code.Name = "txt_ref_book_code"
        Me.txt_ref_book_code.NoClear = False
        Me.txt_ref_book_code.NoSave = False
        Me.txt_ref_book_code.NumberFormat = "@"
        Me.txt_ref_book_code.Required = False
        Me.txt_ref_book_code.RowData = Nothing
        Me.txt_ref_book_code.Size = New System.Drawing.Size(23, 20)
        Me.txt_ref_book_code.TabIndex = 3
        Me.txt_ref_book_code.Tag = "adjustToTop"
        Me.txt_ref_book_code.TextBrowse = False
        Me.txt_ref_book_code.TextSource = "ref_book_code"
        Me.txt_ref_book_code.ToUpper = True
        Me.txt_ref_book_code.Unique = False
        Me.txt_ref_book_code.Value = ""
        Me.txt_ref_book_code.ValueSource = "ref_book_id"
        Me.txt_ref_book_code.Visible = False
        '
        'txt_ref_journal_code
        '
        Me.txt_ref_journal_code.AlwaysDisable = False
        Me.txt_ref_journal_code.AlwaysEnable = False
        Me.txt_ref_journal_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_journal_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ref_journal_code.BrowseDataSource = ""
        Me.txt_ref_journal_code.BrowseField = ""
        Me.txt_ref_journal_code.BrowseFilter = Nothing
        Me.txt_ref_journal_code.BrowseLabel = "Code,Name"
        Me.txt_ref_journal_code.BrowseLabelWidth = "100,200"
        Me.txt_ref_journal_code.BrowseTextSource = ""
        Me.txt_ref_journal_code.BrowseValueSource = ""
        Me.txt_ref_journal_code.Database = user_control.MyList.Database.FileSetup
        Me.txt_ref_journal_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_journal_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_journal_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ref_journal_code.Enabled = False
        Me.txt_ref_journal_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_ref_journal_code.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_ref_journal_code.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ref_journal_code.ID = False
        Me.txt_ref_journal_code.Location = New System.Drawing.Point(245, 157)
        Me.txt_ref_journal_code.Name = "txt_ref_journal_code"
        Me.txt_ref_journal_code.NoClear = False
        Me.txt_ref_journal_code.NoSave = False
        Me.txt_ref_journal_code.NumberFormat = "@"
        Me.txt_ref_journal_code.Required = False
        Me.txt_ref_journal_code.RowData = Nothing
        Me.txt_ref_journal_code.Size = New System.Drawing.Size(23, 20)
        Me.txt_ref_journal_code.TabIndex = 2
        Me.txt_ref_journal_code.Tag = "adjustToTop"
        Me.txt_ref_journal_code.TextBrowse = False
        Me.txt_ref_journal_code.TextSource = "ref_journal_code"
        Me.txt_ref_journal_code.ToUpper = True
        Me.txt_ref_journal_code.Unique = False
        Me.txt_ref_journal_code.Value = ""
        Me.txt_ref_journal_code.ValueSource = "ref_journal_id"
        Me.txt_ref_journal_code.Visible = False
        '
        'txt_allocation_id
        '
        Me.txt_allocation_id.AlwaysDisable = False
        Me.txt_allocation_id.AlwaysEnable = False
        Me.txt_allocation_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_allocation_id.BrowseDataSource = "[lib_erp_allocation]"
        Me.txt_allocation_id.BrowseField = "allocation_code,allocation_name"
        Me.txt_allocation_id.BrowseFilter = Me.txt_account_id
        Me.txt_allocation_id.BrowseLabel = "Code,Name"
        Me.txt_allocation_id.BrowseLabelWidth = "100,200"
        Me.txt_allocation_id.BrowseTextSource = "allocation_name"
        Me.txt_allocation_id.BrowseValueSource = "allocation_id"
        Me.txt_allocation_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_allocation_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_allocation_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_allocation_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_id.Enabled = False
        Me.txt_allocation_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_allocation_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_allocation_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_allocation_id.ID = False
        Me.txt_allocation_id.Location = New System.Drawing.Point(638, 94)
        Me.txt_allocation_id.Name = "txt_allocation_id"
        Me.txt_allocation_id.NoClear = False
        Me.txt_allocation_id.NoSave = False
        Me.txt_allocation_id.NumberFormat = "@"
        Me.txt_allocation_id.Required = True
        Me.txt_allocation_id.RowData = Nothing
        Me.txt_allocation_id.Size = New System.Drawing.Size(125, 20)
        Me.txt_allocation_id.TabIndex = 13
        Me.txt_allocation_id.TextBrowse = True
        Me.txt_allocation_id.TextSource = "allocation_name"
        Me.txt_allocation_id.ToUpper = True
        Me.txt_allocation_id.Unique = False
        Me.txt_allocation_id.Value = ""
        Me.txt_allocation_id.ValueSource = "allocation_id"
        '
        'txt_account_id
        '
        Me.txt_account_id.AlwaysDisable = False
        Me.txt_account_id.AlwaysEnable = False
        Me.txt_account_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_id.BrowseDataSource = "lib_erp_chart"
        Me.txt_account_id.BrowseField = "account_code,account_name"
        Me.txt_account_id.BrowseFilter = Nothing
        Me.txt_account_id.BrowseLabel = "Code,Name"
        Me.txt_account_id.BrowseLabelWidth = "100,400"
        Me.txt_account_id.BrowseTextSource = "account_code"
        Me.txt_account_id.BrowseUpdate.Add(CType(resources.GetObject("txt_account_id.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_account_id.BrowseValueSource = "account_id"
        Me.txt_account_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_account_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_id.Enabled = False
        Me.txt_account_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_account_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_id.ID = False
        Me.txt_account_id.Location = New System.Drawing.Point(100, 10)
        Me.txt_account_id.Name = "txt_account_id"
        Me.txt_account_id.NoClear = False
        Me.txt_account_id.NoSave = False
        Me.txt_account_id.NumberFormat = "@"
        Me.txt_account_id.Required = True
        Me.txt_account_id.RowData = Nothing
        Me.txt_account_id.Size = New System.Drawing.Size(125, 20)
        Me.txt_account_id.TabIndex = 1
        Me.txt_account_id.TextBrowse = True
        Me.txt_account_id.TextSource = "account_code"
        Me.txt_account_id.ToUpper = True
        Me.txt_account_id.Unique = False
        Me.txt_account_id.Value = ""
        Me.txt_account_id.ValueSource = "account_id"
        '
        'txt_nodays_det
        '
        Me.txt_nodays_det.AlwaysDisable = True
        Me.txt_nodays_det.AlwaysEnable = False
        Me.txt_nodays_det.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_nodays_det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nodays_det.BrowseDataSource = ""
        Me.txt_nodays_det.BrowseField = ""
        Me.txt_nodays_det.BrowseFilter = Nothing
        Me.txt_nodays_det.BrowseLabel = "Code,Name"
        Me.txt_nodays_det.BrowseLabelWidth = "100,200"
        Me.txt_nodays_det.BrowseTextSource = ""
        Me.txt_nodays_det.BrowseValueSource = ""
        Me.txt_nodays_det.Database = user_control.MyList.Database.FileSetup
        Me.txt_nodays_det.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nodays_det.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_nodays_det.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_nodays_det.Enabled = False
        Me.txt_nodays_det.EnabledBackColor = System.Drawing.Color.White
        Me.txt_nodays_det.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_nodays_det.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_nodays_det.ID = False
        Me.txt_nodays_det.Location = New System.Drawing.Point(733, 115)
        Me.txt_nodays_det.Name = "txt_nodays_det"
        Me.txt_nodays_det.NoClear = False
        Me.txt_nodays_det.NoSave = False
        Me.txt_nodays_det.NumberFormat = "##,##0"
        Me.txt_nodays_det.Required = False
        Me.txt_nodays_det.RowData = Nothing
        Me.txt_nodays_det.Size = New System.Drawing.Size(30, 20)
        Me.txt_nodays_det.TabIndex = 21
        Me.txt_nodays_det.Tag = "adjustToTop"
        Me.txt_nodays_det.Text = "0"
        Me.txt_nodays_det.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_nodays_det.TextBrowse = False
        Me.txt_nodays_det.TextSource = ""
        Me.txt_nodays_det.ToUpper = True
        Me.txt_nodays_det.Unique = False
        Me.txt_nodays_det.Value = ""
        Me.txt_nodays_det.ValueSource = "nodays"
        Me.txt_nodays_det.Visible = False
        '
        'txt_terms_id_det
        '
        Me.txt_terms_id_det.AlwaysDisable = False
        Me.txt_terms_id_det.AlwaysEnable = False
        Me.txt_terms_id_det.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_id_det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_terms_id_det.BrowseDataSource = "[terms]"
        Me.txt_terms_id_det.BrowseField = "terms_code,terms_name"
        Me.txt_terms_id_det.BrowseFilter = Me.txt_account_id
        Me.txt_terms_id_det.BrowseLabel = "Code,Name"
        Me.txt_terms_id_det.BrowseLabelWidth = "100,200"
        Me.txt_terms_id_det.BrowseTextSource = "terms_name"
        Me.txt_terms_id_det.BrowseUpdate.Add(CType(resources.GetObject("txt_terms_id_det.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_terms_id_det.BrowseValueSource = "terms_id"
        Me.txt_terms_id_det.Database = user_control.MyList.Database.FileSetup
        Me.txt_terms_id_det.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_id_det.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_id_det.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_terms_id_det.Enabled = False
        Me.txt_terms_id_det.EnabledBackColor = System.Drawing.Color.White
        Me.txt_terms_id_det.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_terms_id_det.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_terms_id_det.ID = False
        Me.txt_terms_id_det.Location = New System.Drawing.Point(638, 115)
        Me.txt_terms_id_det.Name = "txt_terms_id_det"
        Me.txt_terms_id_det.NoClear = False
        Me.txt_terms_id_det.NoSave = False
        Me.txt_terms_id_det.NumberFormat = "@"
        Me.txt_terms_id_det.Required = True
        Me.txt_terms_id_det.RowData = Nothing
        Me.txt_terms_id_det.Size = New System.Drawing.Size(94, 20)
        Me.txt_terms_id_det.TabIndex = 20
        Me.txt_terms_id_det.Tag = "adjustToTop"
        Me.txt_terms_id_det.TextBrowse = True
        Me.txt_terms_id_det.TextSource = "terms_name"
        Me.txt_terms_id_det.ToUpper = True
        Me.txt_terms_id_det.Unique = False
        Me.txt_terms_id_det.Value = ""
        Me.txt_terms_id_det.ValueSource = "terms_id"
        Me.txt_terms_id_det.Visible = False
        '
        'txt_department_id
        '
        Me.txt_department_id.AlwaysDisable = False
        Me.txt_department_id.AlwaysEnable = False
        Me.txt_department_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department_id.BrowseDataSource = "lib_erp_department"
        Me.txt_department_id.BrowseField = "department_code,department_name"
        Me.txt_department_id.BrowseFilter = Nothing
        Me.txt_department_id.BrowseLabel = "Code,Name"
        Me.txt_department_id.BrowseLabelWidth = "100,200"
        Me.txt_department_id.BrowseTextSource = "department_name"
        Me.txt_department_id.BrowseValueSource = "department_id"
        Me.txt_department_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_department_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.Enabled = False
        Me.txt_department_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_department_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.ID = False
        Me.txt_department_id.Location = New System.Drawing.Point(355, 73)
        Me.txt_department_id.Name = "txt_department_id"
        Me.txt_department_id.NoClear = False
        Me.txt_department_id.NoSave = False
        Me.txt_department_id.NumberFormat = "@"
        Me.txt_department_id.Required = True
        Me.txt_department_id.RowData = Nothing
        Me.txt_department_id.Size = New System.Drawing.Size(125, 20)
        Me.txt_department_id.TabIndex = 12
        Me.txt_department_id.TextBrowse = True
        Me.txt_department_id.TextSource = "department_name"
        Me.txt_department_id.ToUpper = True
        Me.txt_department_id.Unique = False
        Me.txt_department_id.Value = ""
        Me.txt_department_id.ValueSource = "department_id"
        '
        'txt_general_name_det
        '
        Me.txt_general_name_det.AlwaysDisable = True
        Me.txt_general_name_det.AlwaysEnable = False
        Me.txt_general_name_det.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name_det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_name_det.BrowseDataSource = ""
        Me.txt_general_name_det.BrowseField = ""
        Me.txt_general_name_det.BrowseFilter = Nothing
        Me.txt_general_name_det.BrowseLabel = "Code,Name"
        Me.txt_general_name_det.BrowseLabelWidth = "100,200"
        Me.txt_general_name_det.BrowseTextSource = ""
        Me.txt_general_name_det.BrowseValueSource = ""
        Me.txt_general_name_det.Database = user_control.MyList.Database.FileSetup
        Me.txt_general_name_det.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name_det.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name_det.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_name_det.Enabled = False
        Me.txt_general_name_det.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_name_det.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_general_name_det.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_name_det.ID = False
        Me.txt_general_name_det.Location = New System.Drawing.Point(245, 136)
        Me.txt_general_name_det.Name = "txt_general_name_det"
        Me.txt_general_name_det.NoClear = False
        Me.txt_general_name_det.NoSave = False
        Me.txt_general_name_det.NumberFormat = "@"
        Me.txt_general_name_det.Required = False
        Me.txt_general_name_det.RowData = Nothing
        Me.txt_general_name_det.Size = New System.Drawing.Size(518, 20)
        Me.txt_general_name_det.TabIndex = 19
        Me.txt_general_name_det.Tag = "adjustToTop"
        Me.txt_general_name_det.TextBrowse = False
        Me.txt_general_name_det.TextSource = "general_name"
        Me.txt_general_name_det.ToUpper = True
        Me.txt_general_name_det.Unique = False
        Me.txt_general_name_det.Value = ""
        Me.txt_general_name_det.ValueSource = ""
        '
        'txt_ref_jbooks_id
        '
        Me.txt_ref_jbooks_id.AlwaysDisable = False
        Me.txt_ref_jbooks_id.AlwaysEnable = False
        Me.txt_ref_jbooks_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_jbooks_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ref_jbooks_id.BrowseDataSource = "[ref_jbooks]"
        Me.txt_ref_jbooks_id.BrowseField = "trans_no,trans_date"
        Me.txt_ref_jbooks_id.BrowseFilter = Nothing
        Me.txt_ref_jbooks_id.BrowseLabel = "Code,Name"
        Me.txt_ref_jbooks_id.BrowseLabelWidth = "100,200"
        Me.txt_ref_jbooks_id.BrowseTextSource = "trans_no"
        Me.txt_ref_jbooks_id.BrowseValueSource = "jbooks_id"
        Me.txt_ref_jbooks_id.Database = user_control.MyList.Database.Main
        Me.txt_ref_jbooks_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_jbooks_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_jbooks_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ref_jbooks_id.Enabled = False
        Me.txt_ref_jbooks_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_ref_jbooks_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_ref_jbooks_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ref_jbooks_id.ID = False
        Me.txt_ref_jbooks_id.Location = New System.Drawing.Point(100, 157)
        Me.txt_ref_jbooks_id.Name = "txt_ref_jbooks_id"
        Me.txt_ref_jbooks_id.NoClear = False
        Me.txt_ref_jbooks_id.NoSave = False
        Me.txt_ref_jbooks_id.NumberFormat = "@"
        Me.txt_ref_jbooks_id.Required = True
        Me.txt_ref_jbooks_id.RowData = Nothing
        Me.txt_ref_jbooks_id.Size = New System.Drawing.Size(125, 20)
        Me.txt_ref_jbooks_id.TabIndex = 22
        Me.txt_ref_jbooks_id.Tag = "adjustToTop"
        Me.txt_ref_jbooks_id.TextBrowse = True
        Me.txt_ref_jbooks_id.TextSource = "ref_trans_no"
        Me.txt_ref_jbooks_id.ToUpper = True
        Me.txt_ref_jbooks_id.Unique = False
        Me.txt_ref_jbooks_id.Value = ""
        Me.txt_ref_jbooks_id.ValueSource = "ref_trans_id"
        '
        'txt_general_id_det
        '
        Me.txt_general_id_det.AlwaysDisable = False
        Me.txt_general_id_det.AlwaysEnable = False
        Me.txt_general_id_det.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id_det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id_det.BrowseDataSource = "[general_client]"
        Me.txt_general_id_det.BrowseField = "general_code,general_name"
        Me.txt_general_id_det.BrowseFilter = Nothing
        Me.txt_general_id_det.BrowseLabel = "Code,Name"
        Me.txt_general_id_det.BrowseLabelWidth = "100,200"
        Me.txt_general_id_det.BrowseTextSource = "general_code"
        Me.txt_general_id_det.BrowseUpdate.Add(CType(resources.GetObject("txt_general_id_det.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_general_id_det.BrowseUpdate.Add(CType(resources.GetObject("txt_general_id_det.BrowseUpdate1"), user_control.MyTextBoxList))
        Me.txt_general_id_det.BrowseUpdate.Add(CType(resources.GetObject("txt_general_id_det.BrowseUpdate2"), user_control.MyTextBoxList))
        Me.txt_general_id_det.BrowseValueSource = "general_id"
        Me.txt_general_id_det.Database = user_control.MyList.Database.FileSetup
        Me.txt_general_id_det.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id_det.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id_det.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id_det.Enabled = False
        Me.txt_general_id_det.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id_det.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_general_id_det.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id_det.ID = False
        Me.txt_general_id_det.Location = New System.Drawing.Point(100, 136)
        Me.txt_general_id_det.Name = "txt_general_id_det"
        Me.txt_general_id_det.NoClear = False
        Me.txt_general_id_det.NoSave = False
        Me.txt_general_id_det.NumberFormat = "@"
        Me.txt_general_id_det.Required = True
        Me.txt_general_id_det.RowData = Nothing
        Me.txt_general_id_det.Size = New System.Drawing.Size(125, 20)
        Me.txt_general_id_det.TabIndex = 18
        Me.txt_general_id_det.Tag = "adjustToTop"
        Me.txt_general_id_det.TextBrowse = True
        Me.txt_general_id_det.TextSource = "general_code"
        Me.txt_general_id_det.ToUpper = True
        Me.txt_general_id_det.Unique = False
        Me.txt_general_id_det.Value = ""
        Me.txt_general_id_det.ValueSource = "general_id"
        '
        'txt_account_name
        '
        Me.txt_account_name.AlwaysDisable = True
        Me.txt_account_name.AlwaysEnable = False
        Me.txt_account_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_name.BrowseDataSource = ""
        Me.txt_account_name.BrowseField = ""
        Me.txt_account_name.BrowseFilter = Nothing
        Me.txt_account_name.BrowseLabel = "Code,Name"
        Me.txt_account_name.BrowseLabelWidth = "100,200"
        Me.txt_account_name.BrowseTextSource = ""
        Me.txt_account_name.BrowseValueSource = ""
        Me.txt_account_name.Database = user_control.MyList.Database.FileSetup
        Me.txt_account_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_name.Enabled = False
        Me.txt_account_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_name.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_account_name.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_name.ID = False
        Me.txt_account_name.Location = New System.Drawing.Point(245, 10)
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NoSave = False
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = False
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.Size = New System.Drawing.Size(518, 20)
        Me.txt_account_name.TabIndex = 2
        Me.txt_account_name.TextBrowse = False
        Me.txt_account_name.TextSource = "account_name"
        Me.txt_account_name.ToUpper = True
        Me.txt_account_name.Unique = False
        Me.txt_account_name.Value = ""
        Me.txt_account_name.ValueSource = ""
        '
        'lbltermsdet
        '
        Me.lbltermsdet.AutoSize = True
        Me.lbltermsdet.Location = New System.Drawing.Point(570, 118)
        Me.lbltermsdet.Name = "lbltermsdet"
        Me.lbltermsdet.Size = New System.Drawing.Size(36, 13)
        Me.lbltermsdet.TabIndex = 213
        Me.lbltermsdet.Tag = "adjustToTop"
        Me.lbltermsdet.Text = "Terms"
        Me.lbltermsdet.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(270, 118)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 13)
        Me.Label28.TabIndex = 126
        Me.Label28.Tag = "adjustToTop"
        Me.Label28.Text = "Credit Based"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(270, 97)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 13)
        Me.Label29.TabIndex = 123
        Me.Label29.Tag = "adjustToTop"
        Me.Label29.Text = "Debit Based"
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.Maroon
        Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.ForeColor = System.Drawing.Color.White
        Me.btnUndo.Location = New System.Drawing.Point(664, 157)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(100, 24)
        Me.btnUndo.TabIndex = 61
        Me.btnUndo.Tag = "adjustToTop"
        Me.btnUndo.Text = "C&ancel"
        Me.btnUndo.UseVisualStyleBackColor = False
        Me.btnUndo.Visible = False
        '
        'txt_currency_id_det
        '
        Me.txt_currency_id_det.AlwaysDisable = False
        Me.txt_currency_id_det.AlwaysEnable = False
        Me.txt_currency_id_det.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id_det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id_det.BrowseDataSource = "[currency]"
        Me.txt_currency_id_det.BrowseField = "currency_code,currency_name"
        Me.txt_currency_id_det.BrowseFilter = Nothing
        Me.txt_currency_id_det.BrowseLabel = "Code,Name"
        Me.txt_currency_id_det.BrowseLabelWidth = "100,200"
        Me.txt_currency_id_det.BrowseTextSource = "currency_code"
        Me.txt_currency_id_det.BrowseUpdate.Add(CType(resources.GetObject("txt_currency_id_det.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_currency_id_det.BrowseUpdate.Add(CType(resources.GetObject("txt_currency_id_det.BrowseUpdate1"), user_control.MyTextBoxList))
        Me.txt_currency_id_det.BrowseUpdate.Add(CType(resources.GetObject("txt_currency_id_det.BrowseUpdate2"), user_control.MyTextBoxList))
        Me.txt_currency_id_det.BrowseValueSource = "currency_id"
        Me.txt_currency_id_det.Database = user_control.MyList.Database.FileSetup
        Me.txt_currency_id_det.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id_det.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id_det.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id_det.Enabled = False
        Me.txt_currency_id_det.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id_det.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_currency_id_det.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id_det.ID = False
        Me.txt_currency_id_det.Location = New System.Drawing.Point(100, 52)
        Me.txt_currency_id_det.Name = "txt_currency_id_det"
        Me.txt_currency_id_det.NoClear = False
        Me.txt_currency_id_det.NoSave = False
        Me.txt_currency_id_det.NumberFormat = "@"
        Me.txt_currency_id_det.Required = True
        Me.txt_currency_id_det.RowData = Nothing
        Me.txt_currency_id_det.Size = New System.Drawing.Size(125, 20)
        Me.txt_currency_id_det.TabIndex = 4
        Me.txt_currency_id_det.TextBrowse = True
        Me.txt_currency_id_det.TextSource = "currency_name"
        Me.txt_currency_id_det.ToUpper = True
        Me.txt_currency_id_det.Unique = False
        Me.txt_currency_id_det.Value = ""
        Me.txt_currency_id_det.ValueSource = "currency_id"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Green
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(561, 157)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 24)
        Me.btnOK.TabIndex = 60
        Me.btnOK.Tag = "adjustToTop"
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.Visible = False
        '
        'txt_line_remarks
        '
        Me.txt_line_remarks.AlwaysDisable = False
        Me.txt_line_remarks.AlwaysEnable = False
        Me.txt_line_remarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_line_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_line_remarks.BrowseDataSource = ""
        Me.txt_line_remarks.BrowseField = ""
        Me.txt_line_remarks.BrowseFilter = Nothing
        Me.txt_line_remarks.BrowseLabel = "Code,Name"
        Me.txt_line_remarks.BrowseLabelWidth = "100,200"
        Me.txt_line_remarks.BrowseTextSource = ""
        Me.txt_line_remarks.BrowseValueSource = ""
        Me.txt_line_remarks.Database = user_control.MyList.Database.FileSetup
        Me.txt_line_remarks.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_line_remarks.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_line_remarks.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_line_remarks.Enabled = False
        Me.txt_line_remarks.EnabledBackColor = System.Drawing.Color.White
        Me.txt_line_remarks.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_line_remarks.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_line_remarks.ID = False
        Me.txt_line_remarks.Location = New System.Drawing.Point(100, 31)
        Me.txt_line_remarks.Name = "txt_line_remarks"
        Me.txt_line_remarks.NoClear = False
        Me.txt_line_remarks.NoSave = False
        Me.txt_line_remarks.NumberFormat = "@"
        Me.txt_line_remarks.Required = False
        Me.txt_line_remarks.RowData = Nothing
        Me.txt_line_remarks.Size = New System.Drawing.Size(663, 20)
        Me.txt_line_remarks.TabIndex = 3
        Me.txt_line_remarks.TextBrowse = False
        Me.txt_line_remarks.TextSource = "line_remarks"
        Me.txt_line_remarks.ToUpper = True
        Me.txt_line_remarks.Unique = False
        Me.txt_line_remarks.Value = ""
        Me.txt_line_remarks.ValueSource = ""
        '
        'lblbasedrate
        '
        Me.lblbasedrate.AutoSize = True
        Me.lblbasedrate.Location = New System.Drawing.Point(570, 55)
        Me.lblbasedrate.Name = "lblbasedrate"
        Me.lblbasedrate.Size = New System.Drawing.Size(63, 13)
        Me.lblbasedrate.TabIndex = 196
        Me.lblbasedrate.Text = "Based Rate"
        '
        'lblLineRemarks
        '
        Me.lblLineRemarks.AutoSize = True
        Me.lblLineRemarks.Location = New System.Drawing.Point(10, 34)
        Me.lblLineRemarks.Name = "lblLineRemarks"
        Me.lblLineRemarks.Size = New System.Drawing.Size(72, 13)
        Me.lblLineRemarks.TabIndex = 127
        Me.lblLineRemarks.Text = "Line Remarks"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(10, 160)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 13)
        Me.Label25.TabIndex = 118
        Me.Label25.Tag = "adjustToTop"
        Me.Label25.Text = "D.N. Ref."
        '
        'lblexchangerate
        '
        Me.lblexchangerate.AutoSize = True
        Me.lblexchangerate.Location = New System.Drawing.Point(270, 55)
        Me.lblexchangerate.Name = "lblexchangerate"
        Me.lblexchangerate.Size = New System.Drawing.Size(81, 13)
        Me.lblexchangerate.TabIndex = 195
        Me.lblexchangerate.Text = "Exchange Rate"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(227, 138)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 117
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "adjustToTop"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 139)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 114
        Me.Label24.Tag = "adjustToTop"
        Me.Label24.Text = "Gen. Ref."
        '
        'lblcurrency
        '
        Me.lblcurrency.AutoSize = True
        Me.lblcurrency.Location = New System.Drawing.Point(10, 55)
        Me.lblcurrency.Name = "lblcurrency"
        Me.lblcurrency.Size = New System.Drawing.Size(49, 13)
        Me.lblcurrency.TabIndex = 194
        Me.lblcurrency.Text = "Currency"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 118)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 113
        Me.Label23.Tag = "adjustToTop"
        Me.Label23.Text = "Credit"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 97)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 13)
        Me.Label22.TabIndex = 111
        Me.Label22.Tag = "adjustToTop"
        Me.Label22.Text = "Debit"
        '
        'lblAllocation
        '
        Me.lblAllocation.AutoSize = True
        Me.lblAllocation.Location = New System.Drawing.Point(570, 97)
        Me.lblAllocation.Name = "lblAllocation"
        Me.lblAllocation.Size = New System.Drawing.Size(53, 13)
        Me.lblAllocation.TabIndex = 107
        Me.lblAllocation.Text = "Allocation"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(270, 76)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 104
        Me.lblDepartment.Text = "Department"
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Location = New System.Drawing.Point(10, 76)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(40, 13)
        Me.lblProject.TabIndex = 103
        Me.lblProject.Text = "Project"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(227, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 108
        Me.PictureBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 105
        Me.Label20.Text = "Account Code"
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans, Me.jbooks, Me.ewt, Me.checks, Me.fixed_asset, Me.input_vat, Me.output_vat, Me.prepaid, Me.final_tax, Me.particular})
        '
        'trans
        '
        Me.trans.Columns.AddRange(New System.Data.DataColumn() {Me.DataColum101, Me.DataColum102, Me.DataColum103, Me.DataColum104, Me.DataColum105, Me.DataColum106, Me.DataColum107, Me.DataColum108, Me.DataColum109, Me.DataColum110, Me.DataColumn1, Me.DataColumn2, Me.description, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn160, Me.DataColumn161, Me.DataColumn162, Me.DataColumn164, Me.DataColumn275, Me.DataColumn276, Me.DataColumn277, Me.DataColumn278, Me.DataColumn279, Me.DataColumn293, Me.DataColumn294, Me.DataColumn295, Me.DataColumn296, Me.DataColumn297, Me.DataColumn298, Me.DataColumn299})
        Me.trans.TableName = "trans"
        '
        'DataColum101
        '
        Me.DataColum101.ColumnName = "sel"
        Me.DataColum101.DataType = GetType(Boolean)
        Me.DataColum101.DefaultValue = False
        '
        'DataColum102
        '
        Me.DataColum102.ColumnName = "trans_id"
        Me.DataColum102.DefaultValue = ""
        '
        'DataColum103
        '
        Me.DataColum103.ColumnName = "trans_no"
        Me.DataColum103.DefaultValue = ""
        '
        'DataColum104
        '
        Me.DataColum104.ColumnName = "trans_date"
        Me.DataColum104.DataType = GetType(Date)
        '
        'DataColum105
        '
        Me.DataColum105.ColumnName = "book_id"
        Me.DataColum105.DefaultValue = ""
        '
        'DataColum106
        '
        Me.DataColum106.ColumnName = "journal_id"
        Me.DataColum106.DefaultValue = ""
        '
        'DataColum107
        '
        Me.DataColum107.ColumnName = "general_id"
        Me.DataColum107.DefaultValue = ""
        '
        'DataColum108
        '
        Me.DataColum108.ColumnName = "currency_id"
        Me.DataColum108.DefaultValue = ""
        '
        'DataColum109
        '
        Me.DataColum109.ColumnName = "exchange_rate"
        Me.DataColum109.DataType = GetType(Decimal)
        Me.DataColum109.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColum110
        '
        Me.DataColum110.ColumnName = "based_rate"
        Me.DataColum110.DataType = GetType(Decimal)
        Me.DataColum110.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "amount"
        Me.DataColumn1.DataType = GetType(Decimal)
        Me.DataColumn1.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "amount_based"
        Me.DataColumn2.DataType = GetType(Decimal)
        Me.DataColumn2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'description
        '
        Me.description.ColumnName = "description"
        Me.description.DefaultValue = ""
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "book_code"
        Me.DataColumn34.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "book_name"
        Me.DataColumn35.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "journal_code"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "journal_name"
        Me.DataColumn37.DefaultValue = ""
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "general_code"
        Me.DataColumn38.DefaultValue = ""
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "general_name"
        Me.DataColumn39.DefaultValue = ""
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "currency_code"
        Me.DataColumn40.DefaultValue = ""
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "currency_name"
        Me.DataColumn41.DefaultValue = ""
        '
        'DataColumn160
        '
        Me.DataColumn160.ColumnName = "posted"
        Me.DataColumn160.DataType = GetType(Short)
        Me.DataColumn160.DefaultValue = CType(0, Short)
        '
        'DataColumn161
        '
        Me.DataColumn161.ColumnName = "si_no"
        Me.DataColumn161.DefaultValue = ""
        '
        'DataColumn162
        '
        Me.DataColumn162.ColumnName = "dr_no"
        Me.DataColumn162.DefaultValue = ""
        '
        'DataColumn164
        '
        Me.DataColumn164.ColumnName = "po_no"
        Me.DataColumn164.DefaultValue = ""
        '
        'DataColumn275
        '
        Me.DataColumn275.ColumnName = "terms_id"
        Me.DataColumn275.DefaultValue = ""
        '
        'DataColumn276
        '
        Me.DataColumn276.ColumnName = "nodays"
        Me.DataColumn276.DataType = GetType(Short)
        Me.DataColumn276.DefaultValue = CType(0, Short)
        '
        'DataColumn277
        '
        Me.DataColumn277.ColumnName = "trans_cr_id"
        Me.DataColumn277.DefaultValue = ""
        '
        'DataColumn278
        '
        Me.DataColumn278.ColumnName = "terms_name"
        Me.DataColumn278.DefaultValue = ""
        '
        'DataColumn279
        '
        Me.DataColumn279.ColumnName = "due_date"
        Me.DataColumn279.DataType = GetType(Date)
        '
        'DataColumn293
        '
        Me.DataColumn293.ColumnName = "user_id"
        Me.DataColumn293.DefaultValue = ""
        '
        'DataColumn294
        '
        Me.DataColumn294.ColumnName = "status"
        Me.DataColumn294.DefaultValue = ""
        '
        'DataColumn295
        '
        Me.DataColumn295.ColumnName = "current_status"
        Me.DataColumn295.DefaultValue = ""
        '
        'DataColumn296
        '
        Me.DataColumn296.ColumnName = "current_approver"
        Me.DataColumn296.DefaultValue = ""
        '
        'DataColumn297
        '
        Me.DataColumn297.ColumnName = "approver"
        Me.DataColumn297.DefaultValue = ""
        '
        'DataColumn298
        '
        Me.DataColumn298.ColumnName = "prev_status"
        Me.DataColumn298.DefaultValue = ""
        '
        'DataColumn299
        '
        Me.DataColumn299.ColumnName = "prev_approver"
        Me.DataColumn299.DefaultValue = ""
        '
        'jbooks
        '
        Me.jbooks.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn151, Me.DataColumn152, Me.DataColumn153, Me.DataColumn165, Me.DataColumn170, Me.DataColumn171, Me.DataColumn172, Me.DataColumn173, Me.DataColumn261, Me.DataColumn262, Me.DataColumn263, Me.DataColumn264, Me.DataColumn284, Me.DataColumn285, Me.DataColumn286, Me.DataColumn287, Me.DataColumn288, Me.DataColumn306, Me.DataColumn307, Me.DataColumn308, Me.DataColumn309, Me.DataColumn310, Me.DataColumn311, Me.DataColumn313, Me.DataColumn314, Me.DataColumn315, Me.DataColumn316, Me.DataColumn317, Me.DataColumn319, Me.DataColumn320, Me.DataColumn321, Me.DataColumn322})
        Me.jbooks.TableName = "jbooks"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sel"
        Me.DataColumn3.DataType = GetType(Boolean)
        Me.DataColumn3.DefaultValue = False
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "jbooks_id"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "trans_id"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "project_id"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "department_id"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "allocation_id"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "account_id"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "line_remarks"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "debit"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "credit"
        Me.DataColumn12.DataType = GetType(Decimal)
        Me.DataColumn12.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "debit_based"
        Me.DataColumn13.DataType = GetType(Decimal)
        Me.DataColumn13.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "credit_based"
        Me.DataColumn14.DataType = GetType(Decimal)
        Me.DataColumn14.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "general_id"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ref_jbooks_id"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "project_code"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "project_name"
        Me.DataColumn18.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "department_code"
        Me.DataColumn19.DefaultValue = ""
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "department_name"
        Me.DataColumn20.DefaultValue = ""
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "allocation_code"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "allocation_name"
        Me.DataColumn22.DefaultValue = ""
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "account_code"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "account_name"
        Me.DataColumn24.DefaultValue = ""
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "general_code"
        Me.DataColumn25.DefaultValue = ""
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "general_name"
        Me.DataColumn26.DefaultValue = ""
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "ref_trans_no"
        Me.DataColumn27.DefaultValue = ""
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "ref_book_id"
        Me.DataColumn28.DefaultValue = ""
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "ref_journal_id"
        Me.DataColumn29.DefaultValue = ""
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "ref_book_code"
        Me.DataColumn30.DefaultValue = ""
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "ref_book_name"
        Me.DataColumn31.DefaultValue = ""
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "ref_journal_code"
        Me.DataColumn32.DefaultValue = ""
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "ref_journal_name"
        Me.DataColumn33.DefaultValue = ""
        '
        'DataColumn151
        '
        Me.DataColumn151.ColumnName = "jbooks_id_tmp"
        Me.DataColumn151.DefaultValue = ""
        '
        'DataColumn152
        '
        Me.DataColumn152.ColumnName = "validation"
        Me.DataColumn152.DefaultValue = ""
        '
        'DataColumn153
        '
        Me.DataColumn153.ColumnName = "deleted"
        Me.DataColumn153.DataType = GetType(Boolean)
        Me.DataColumn153.DefaultValue = False
        '
        'DataColumn165
        '
        Me.DataColumn165.ColumnName = "dc"
        Me.DataColumn165.DataType = GetType(Short)
        Me.DataColumn165.DefaultValue = CType(0, Short)
        '
        'DataColumn170
        '
        Me.DataColumn170.ColumnName = "currency_id"
        Me.DataColumn170.DefaultValue = ""
        '
        'DataColumn171
        '
        Me.DataColumn171.ColumnName = "exchange_rate"
        Me.DataColumn171.DataType = GetType(Decimal)
        Me.DataColumn171.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn172
        '
        Me.DataColumn172.ColumnName = "based_rate"
        Me.DataColumn172.DataType = GetType(Decimal)
        Me.DataColumn172.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn173
        '
        Me.DataColumn173.ColumnName = "currency_name"
        Me.DataColumn173.DefaultValue = ""
        '
        'DataColumn261
        '
        Me.DataColumn261.ColumnName = "ref_trans_date"
        Me.DataColumn261.DefaultValue = ""
        '
        'DataColumn262
        '
        Me.DataColumn262.ColumnName = "tmp_amount"
        Me.DataColumn262.DataType = GetType(Decimal)
        Me.DataColumn262.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn263
        '
        Me.DataColumn263.ColumnName = "isInputted"
        Me.DataColumn263.DataType = GetType(Boolean)
        Me.DataColumn263.DefaultValue = False
        '
        'DataColumn264
        '
        Me.DataColumn264.ColumnName = "balance"
        Me.DataColumn264.DataType = GetType(Decimal)
        Me.DataColumn264.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn284
        '
        Me.DataColumn284.ColumnName = "terms_id"
        Me.DataColumn284.DefaultValue = ""
        '
        'DataColumn285
        '
        Me.DataColumn285.ColumnName = "terms_code"
        Me.DataColumn285.DefaultValue = ""
        '
        'DataColumn286
        '
        Me.DataColumn286.ColumnName = "terms_name"
        Me.DataColumn286.DefaultValue = ""
        '
        'DataColumn287
        '
        Me.DataColumn287.ColumnName = "nodays"
        Me.DataColumn287.DataType = GetType(Decimal)
        Me.DataColumn287.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn288
        '
        Me.DataColumn288.ColumnName = "jbooks_terms_id"
        Me.DataColumn288.DefaultValue = ""
        '
        'DataColumn306
        '
        Me.DataColumn306.ColumnName = "offset"
        Me.DataColumn306.DataType = GetType(Integer)
        Me.DataColumn306.DefaultValue = 0
        '
        'DataColumn307
        '
        Me.DataColumn307.ColumnName = "minimum"
        Me.DataColumn307.DataType = GetType(Decimal)
        Me.DataColumn307.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn308
        '
        Me.DataColumn308.ColumnName = "si_no"
        Me.DataColumn308.DefaultValue = ""
        '
        'DataColumn309
        '
        Me.DataColumn309.ColumnName = "rr_no"
        Me.DataColumn309.DefaultValue = ""
        '
        'DataColumn310
        '
        Me.DataColumn310.ColumnName = "po_no"
        Me.DataColumn310.DefaultValue = ""
        '
        'DataColumn311
        '
        Me.DataColumn311.ColumnName = "dr_no"
        Me.DataColumn311.DefaultValue = ""
        '
        'DataColumn313
        '
        Me.DataColumn313.ColumnName = "unit_applicable"
        Me.DataColumn313.DataType = GetType(Boolean)
        Me.DataColumn313.DefaultValue = False
        '
        'DataColumn314
        '
        Me.DataColumn314.ColumnName = "book_unit_no_id"
        Me.DataColumn314.DefaultValue = ""
        '
        'DataColumn315
        '
        Me.DataColumn315.ColumnName = "book_unit_no_code"
        Me.DataColumn315.DefaultValue = ""
        '
        'DataColumn316
        '
        Me.DataColumn316.ColumnName = "book_unit_no_name"
        Me.DataColumn316.DefaultValue = ""
        '
        'DataColumn317
        '
        Me.DataColumn317.ColumnName = "particulars"
        Me.DataColumn317.DefaultValue = ""
        '
        'DataColumn319
        '
        Me.DataColumn319.ColumnName = "project_unit_no_id"
        Me.DataColumn319.DefaultValue = ""
        '
        'DataColumn320
        '
        Me.DataColumn320.ColumnName = "project_unit_no_codes"
        Me.DataColumn320.DefaultValue = ""
        '
        'DataColumn321
        '
        Me.DataColumn321.ColumnName = "project_unit_no_names"
        Me.DataColumn321.DefaultValue = ""
        '
        'DataColumn322
        '
        Me.DataColumn322.ColumnName = "noCompute"
        Me.DataColumn322.DataType = GetType(Boolean)
        Me.DataColumn322.DefaultValue = False
        '
        'ewt
        '
        Me.ewt.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn46, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn96, Me.DataColumn154, Me.DataColumn163, Me.DataColumn166, Me.DataColumn167, Me.DataColumn168, Me.DataColumn169, Me.DataColumn174, Me.DataColumn175, Me.DataColumn176, Me.DataColumn177, Me.DataColumn208})
        Me.ewt.TableName = "ewt"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "sel"
        Me.DataColumn42.DataType = GetType(Boolean)
        Me.DataColumn42.DefaultValue = False
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "jbooks_id"
        Me.DataColumn43.DefaultValue = ""
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "general_id"
        Me.DataColumn44.DefaultValue = ""
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "fs_ewt_id"
        Me.DataColumn45.DefaultValue = ""
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "offset_type"
        Me.DataColumn47.DefaultValue = ""
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "tax_rate"
        Me.DataColumn48.DataType = GetType(Decimal)
        Me.DataColumn48.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "amount"
        Me.DataColumn49.DataType = GetType(Decimal)
        Me.DataColumn49.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "tax_amount"
        Me.DataColumn50.DataType = GetType(Decimal)
        Me.DataColumn50.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "debit"
        Me.DataColumn51.DataType = GetType(Decimal)
        Me.DataColumn51.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "credit"
        Me.DataColumn52.DataType = GetType(Decimal)
        Me.DataColumn52.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "amount_based"
        Me.DataColumn53.DataType = GetType(Decimal)
        Me.DataColumn53.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "tax_amount_based"
        Me.DataColumn54.DataType = GetType(Decimal)
        Me.DataColumn54.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "debit_based"
        Me.DataColumn55.DataType = GetType(Decimal)
        Me.DataColumn55.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "credit_based"
        Me.DataColumn56.DataType = GetType(Decimal)
        Me.DataColumn56.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "ref_ewt_id"
        Me.DataColumn57.DefaultValue = ""
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "general_code"
        Me.DataColumn46.DefaultValue = ""
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "general_name"
        Me.DataColumn77.DefaultValue = ""
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "fs_ewt_code"
        Me.DataColumn78.DefaultValue = ""
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "fs_ewt_name"
        Me.DataColumn79.DefaultValue = ""
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "tin"
        Me.DataColumn96.DefaultValue = ""
        '
        'DataColumn154
        '
        Me.DataColumn154.ColumnName = "deleted"
        Me.DataColumn154.DataType = GetType(Boolean)
        Me.DataColumn154.DefaultValue = False
        '
        'DataColumn163
        '
        Me.DataColumn163.ColumnName = "trans_date"
        Me.DataColumn163.DataType = GetType(Date)
        '
        'DataColumn166
        '
        Me.DataColumn166.ColumnName = "ref_no"
        '
        'DataColumn167
        '
        Me.DataColumn167.ColumnName = "tmp_amount"
        Me.DataColumn167.DataType = GetType(Decimal)
        '
        'DataColumn168
        '
        Me.DataColumn168.ColumnName = "isInputted"
        Me.DataColumn168.DataType = GetType(Boolean)
        '
        'DataColumn169
        '
        Me.DataColumn169.ColumnName = "balance"
        '
        'DataColumn174
        '
        Me.DataColumn174.ColumnName = "currency_id"
        '
        'DataColumn175
        '
        Me.DataColumn175.ColumnName = "currency_name"
        '
        'DataColumn176
        '
        Me.DataColumn176.ColumnName = "exchange_rate"
        Me.DataColumn176.DataType = GetType(Decimal)
        '
        'DataColumn177
        '
        Me.DataColumn177.ColumnName = "based_rate"
        Me.DataColumn177.DataType = GetType(Decimal)
        '
        'DataColumn208
        '
        Me.DataColumn208.ColumnName = "ewt_id"
        Me.DataColumn208.DefaultValue = ""
        '
        'checks
        '
        Me.checks.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn73, Me.DataColumn74, Me.DataColumn72, Me.DataColumn75, Me.DataColumn76, Me.DataColumn155, Me.DataColumn265, Me.DataColumn266, Me.DataColumn267, Me.DataColumn268, Me.DataColumn269, Me.DataColumn270, Me.DataColumn271, Me.DataColumn272, Me.DataColumn273, Me.DataColumn274, Me.DataColumn280, Me.DataColumn281, Me.DataColumn282, Me.DataColumn283, Me.DataColumn291, Me.DataColumn292, Me.DataColumn312, Me.DataColumn318})
        Me.checks.TableName = "checks"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "check_id"
        Me.DataColumn58.DefaultValue = ""
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "jbooks_id"
        Me.DataColumn59.DefaultValue = ""
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "general_id"
        Me.DataColumn60.DefaultValue = ""
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "check_no"
        Me.DataColumn61.DefaultValue = ""
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "check_date"
        Me.DataColumn62.DataType = GetType(Date)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "check_amount"
        Me.DataColumn63.DataType = GetType(Decimal)
        Me.DataColumn63.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "check_amount_based"
        Me.DataColumn64.DataType = GetType(Decimal)
        Me.DataColumn64.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "bank_id"
        Me.DataColumn65.DefaultValue = ""
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "cleared"
        Me.DataColumn66.DataType = GetType(Boolean)
        Me.DataColumn66.DefaultValue = False
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "released"
        Me.DataColumn67.DataType = GetType(Boolean)
        Me.DataColumn67.DefaultValue = False
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "cancelled"
        Me.DataColumn68.DataType = GetType(Boolean)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "crossed"
        Me.DataColumn69.DataType = GetType(Boolean)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "replacement_check_no"
        Me.DataColumn70.DefaultValue = ""
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "cleared_date"
        Me.DataColumn71.DataType = GetType(Date)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "deposit_date"
        Me.DataColumn73.DataType = GetType(Date)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "cancel_date"
        Me.DataColumn74.DataType = GetType(Date)
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "replaced"
        Me.DataColumn72.DataType = GetType(Boolean)
        Me.DataColumn72.DefaultValue = False
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "general_code"
        Me.DataColumn75.DefaultValue = ""
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "general_name"
        Me.DataColumn76.DefaultValue = ""
        '
        'DataColumn155
        '
        Me.DataColumn155.ColumnName = "deleted"
        Me.DataColumn155.DefaultValue = "False"
        '
        'DataColumn265
        '
        Me.DataColumn265.ColumnName = "currency_id"
        Me.DataColumn265.DefaultValue = ""
        '
        'DataColumn266
        '
        Me.DataColumn266.ColumnName = "exchange_rate"
        Me.DataColumn266.DataType = GetType(Decimal)
        Me.DataColumn266.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn267
        '
        Me.DataColumn267.ColumnName = "based_rate"
        Me.DataColumn267.DataType = GetType(Decimal)
        Me.DataColumn267.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn268
        '
        Me.DataColumn268.ColumnName = "currency_code"
        Me.DataColumn268.DefaultValue = ""
        '
        'DataColumn269
        '
        Me.DataColumn269.ColumnName = "currency_name"
        Me.DataColumn269.DefaultValue = ""
        '
        'DataColumn270
        '
        Me.DataColumn270.ColumnName = "trans_no"
        Me.DataColumn270.DefaultValue = ""
        '
        'DataColumn271
        '
        Me.DataColumn271.ColumnName = "bank_code"
        Me.DataColumn271.DefaultValue = ""
        '
        'DataColumn272
        '
        Me.DataColumn272.ColumnName = "bank_name"
        Me.DataColumn272.DefaultValue = ""
        '
        'DataColumn273
        '
        Me.DataColumn273.ColumnName = "isCash"
        Me.DataColumn273.DataType = GetType(Boolean)
        Me.DataColumn273.DefaultValue = False
        '
        'DataColumn274
        '
        Me.DataColumn274.ColumnName = "isReplaced"
        Me.DataColumn274.DataType = GetType(Boolean)
        Me.DataColumn274.DefaultValue = False
        '
        'DataColumn280
        '
        Me.DataColumn280.ColumnName = "debit"
        Me.DataColumn280.DataType = GetType(Decimal)
        Me.DataColumn280.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn281
        '
        Me.DataColumn281.ColumnName = "credit"
        Me.DataColumn281.DataType = GetType(Decimal)
        Me.DataColumn281.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn282
        '
        Me.DataColumn282.ColumnName = "debit_based"
        Me.DataColumn282.DataType = GetType(Decimal)
        Me.DataColumn282.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn283
        '
        Me.DataColumn283.ColumnName = "credit_based"
        Me.DataColumn283.DataType = GetType(Decimal)
        Me.DataColumn283.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn291
        '
        Me.DataColumn291.ColumnName = "bank_code_depository"
        Me.DataColumn291.DefaultValue = ""
        '
        'DataColumn292
        '
        Me.DataColumn292.ColumnName = "bank_name_depository"
        Me.DataColumn292.DefaultValue = ""
        '
        'DataColumn312
        '
        Me.DataColumn312.ColumnName = "isPDC"
        Me.DataColumn312.DataType = GetType(Boolean)
        Me.DataColumn312.DefaultValue = False
        '
        'DataColumn318
        '
        Me.DataColumn318.ColumnName = "isPrinted"
        Me.DataColumn318.DataType = GetType(Boolean)
        Me.DataColumn318.DefaultValue = False
        '
        'fixed_asset
        '
        Me.fixed_asset.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn156, Me.DataColumn249, Me.DataColumn250, Me.DataColumn251, Me.DataColumn252, Me.DataColumn253, Me.DataColumn254, Me.DataColumn255, Me.DataColumn256, Me.DataColumn257, Me.DataColumn258, Me.DataColumn259, Me.DataColumn260, Me.DataColumn289, Me.DataColumn290})
        Me.fixed_asset.TableName = "fixed_asset"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "sel"
        Me.DataColumn80.DataType = GetType(Boolean)
        Me.DataColumn80.DefaultValue = False
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "fixed_asset_id"
        Me.DataColumn81.DefaultValue = ""
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "jbooks_id"
        Me.DataColumn82.DefaultValue = ""
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "currency_id"
        Me.DataColumn83.DefaultValue = ""
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "exchange_rate"
        Me.DataColumn84.DataType = GetType(Decimal)
        Me.DataColumn84.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "based_rate"
        Me.DataColumn85.DataType = GetType(Decimal)
        Me.DataColumn85.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "description"
        Me.DataColumn86.DefaultValue = ""
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "asset_code"
        Me.DataColumn87.DefaultValue = ""
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "historical_rate"
        Me.DataColumn88.DataType = GetType(Decimal)
        Me.DataColumn88.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "quantity"
        Me.DataColumn89.DataType = GetType(Integer)
        Me.DataColumn89.DefaultValue = 0
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "date_acquired"
        Me.DataColumn90.DataType = GetType(Date)
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "amount"
        Me.DataColumn91.DataType = GetType(Decimal)
        Me.DataColumn91.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "amount_based"
        Me.DataColumn92.DataType = GetType(Decimal)
        Me.DataColumn92.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "useful_life"
        Me.DataColumn93.DataType = GetType(Integer)
        Me.DataColumn93.DefaultValue = 0
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "date_start"
        Me.DataColumn94.DataType = GetType(Date)
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "debit"
        Me.DataColumn95.DataType = GetType(Decimal)
        Me.DataColumn95.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn156
        '
        Me.DataColumn156.ColumnName = "credit"
        Me.DataColumn156.DataType = GetType(Decimal)
        Me.DataColumn156.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn249
        '
        Me.DataColumn249.ColumnName = "debit_based"
        Me.DataColumn249.DataType = GetType(Decimal)
        Me.DataColumn249.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn250
        '
        Me.DataColumn250.ColumnName = "credit_based"
        Me.DataColumn250.DataType = GetType(Decimal)
        Me.DataColumn250.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn251
        '
        Me.DataColumn251.ColumnName = "ref_fixed_asset_id"
        Me.DataColumn251.DefaultValue = ""
        '
        'DataColumn252
        '
        Me.DataColumn252.ColumnName = "ref_no"
        Me.DataColumn252.DefaultValue = ""
        '
        'DataColumn253
        '
        Me.DataColumn253.ColumnName = "currency_code"
        Me.DataColumn253.DefaultValue = ""
        '
        'DataColumn254
        '
        Me.DataColumn254.ColumnName = "currency_name"
        Me.DataColumn254.DefaultValue = ""
        '
        'DataColumn255
        '
        Me.DataColumn255.ColumnName = "tmp_amount"
        Me.DataColumn255.DataType = GetType(Decimal)
        Me.DataColumn255.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn256
        '
        Me.DataColumn256.ColumnName = "isInputted"
        Me.DataColumn256.DataType = GetType(Boolean)
        Me.DataColumn256.DefaultValue = False
        '
        'DataColumn257
        '
        Me.DataColumn257.ColumnName = "deleted"
        Me.DataColumn257.DataType = GetType(Boolean)
        Me.DataColumn257.DefaultValue = False
        '
        'DataColumn258
        '
        Me.DataColumn258.ColumnName = "balance"
        Me.DataColumn258.DataType = GetType(Decimal)
        Me.DataColumn258.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn259
        '
        Me.DataColumn259.ColumnName = "trans_no"
        Me.DataColumn259.DefaultValue = ""
        '
        'DataColumn260
        '
        Me.DataColumn260.ColumnName = "trans_date"
        Me.DataColumn260.DefaultValue = ""
        '
        'DataColumn289
        '
        Me.DataColumn289.ColumnName = "salvage_value"
        Me.DataColumn289.DataType = GetType(Decimal)
        Me.DataColumn289.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn290
        '
        Me.DataColumn290.ColumnName = "salvage_value_based"
        Me.DataColumn290.DataType = GetType(Decimal)
        Me.DataColumn290.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'input_vat
        '
        Me.input_vat.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn97, Me.DataColumn98, Me.DataColumn99, Me.DataColumn100, Me.DataColumn101, Me.DataColumn102, Me.DataColumn103, Me.DataColumn104, Me.DataColumn105, Me.DataColumn106, Me.DataColumn107, Me.DataColumn108, Me.DataColumn109, Me.DataColumn110, Me.DataColumn111, Me.DataColumn112, Me.DataColumn113, Me.DataColumn114, Me.DataColumn115, Me.DataColumn116, Me.DataColumn117, Me.DataColumn157, Me.DataColumn210, Me.DataColumn211, Me.DataColumn212, Me.DataColumn213, Me.DataColumn214, Me.DataColumn215, Me.DataColumn216, Me.DataColumn217, Me.DataColumn218, Me.DataColumn219, Me.DataColumn220, Me.DataColumn221, Me.DataColumn222})
        Me.input_vat.TableName = "input_vat"
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "sel"
        Me.DataColumn97.DataType = GetType(Boolean)
        Me.DataColumn97.DefaultValue = False
        '
        'DataColumn98
        '
        Me.DataColumn98.ColumnName = "input_vat_id"
        Me.DataColumn98.DefaultValue = ""
        '
        'DataColumn99
        '
        Me.DataColumn99.ColumnName = "jbooks_id"
        Me.DataColumn99.DefaultValue = ""
        '
        'DataColumn100
        '
        Me.DataColumn100.ColumnName = "general_id"
        Me.DataColumn100.DefaultValue = ""
        '
        'DataColumn101
        '
        Me.DataColumn101.ColumnName = "currency_id"
        Me.DataColumn101.DefaultValue = ""
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "exchange_rate"
        Me.DataColumn102.DataType = GetType(Decimal)
        Me.DataColumn102.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn103
        '
        Me.DataColumn103.ColumnName = "based_rate"
        Me.DataColumn103.DataType = GetType(Decimal)
        Me.DataColumn103.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn104
        '
        Me.DataColumn104.ColumnName = "offset_type"
        Me.DataColumn104.DefaultValue = ""
        '
        'DataColumn105
        '
        Me.DataColumn105.ColumnName = "vat_class"
        Me.DataColumn105.DefaultValue = ""
        '
        'DataColumn106
        '
        Me.DataColumn106.ColumnName = "vat_type"
        Me.DataColumn106.DefaultValue = ""
        '
        'DataColumn107
        '
        Me.DataColumn107.ColumnName = "vat_rate"
        Me.DataColumn107.DataType = GetType(Decimal)
        Me.DataColumn107.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn108
        '
        Me.DataColumn108.ColumnName = "gross_amount"
        Me.DataColumn108.DataType = GetType(Decimal)
        Me.DataColumn108.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn109
        '
        Me.DataColumn109.ColumnName = "vat_amount"
        Me.DataColumn109.DataType = GetType(Decimal)
        Me.DataColumn109.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn110
        '
        Me.DataColumn110.ColumnName = "net_amount"
        Me.DataColumn110.DataType = GetType(Decimal)
        Me.DataColumn110.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn111
        '
        Me.DataColumn111.ColumnName = "debit"
        Me.DataColumn111.DataType = GetType(Decimal)
        Me.DataColumn111.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn112
        '
        Me.DataColumn112.ColumnName = "credit"
        Me.DataColumn112.DataType = GetType(Decimal)
        Me.DataColumn112.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn113
        '
        Me.DataColumn113.ColumnName = "gross_amount_based"
        Me.DataColumn113.DataType = GetType(Decimal)
        Me.DataColumn113.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn114
        '
        Me.DataColumn114.ColumnName = "net_amount_based"
        Me.DataColumn114.DataType = GetType(Decimal)
        Me.DataColumn114.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn115
        '
        Me.DataColumn115.ColumnName = "vat_amount_based"
        Me.DataColumn115.DataType = GetType(Decimal)
        Me.DataColumn115.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn116
        '
        Me.DataColumn116.ColumnName = "debit_based"
        Me.DataColumn116.DataType = GetType(Decimal)
        Me.DataColumn116.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn117
        '
        Me.DataColumn117.ColumnName = "credit_amount_based"
        Me.DataColumn117.DataType = GetType(Decimal)
        Me.DataColumn117.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn157
        '
        Me.DataColumn157.ColumnName = "ref_input_vat_id"
        Me.DataColumn157.DefaultValue = ""
        '
        'DataColumn210
        '
        Me.DataColumn210.ColumnName = "ref_no"
        Me.DataColumn210.DefaultValue = ""
        '
        'DataColumn211
        '
        Me.DataColumn211.ColumnName = "general_code"
        Me.DataColumn211.DefaultValue = ""
        '
        'DataColumn212
        '
        Me.DataColumn212.ColumnName = "general_name"
        Me.DataColumn212.DefaultValue = ""
        '
        'DataColumn213
        '
        Me.DataColumn213.ColumnName = "currency_code"
        Me.DataColumn213.DefaultValue = ""
        '
        'DataColumn214
        '
        Me.DataColumn214.ColumnName = "currency_name"
        Me.DataColumn214.DefaultValue = ""
        '
        'DataColumn215
        '
        Me.DataColumn215.ColumnName = "tmp_amount"
        Me.DataColumn215.DataType = GetType(Decimal)
        Me.DataColumn215.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn216
        '
        Me.DataColumn216.ColumnName = "address"
        Me.DataColumn216.DefaultValue = ""
        '
        'DataColumn217
        '
        Me.DataColumn217.ColumnName = "tin"
        Me.DataColumn217.DefaultValue = ""
        '
        'DataColumn218
        '
        Me.DataColumn218.ColumnName = "isInputted"
        Me.DataColumn218.DataType = GetType(Boolean)
        Me.DataColumn218.DefaultValue = False
        '
        'DataColumn219
        '
        Me.DataColumn219.ColumnName = "deleted"
        Me.DataColumn219.DataType = GetType(Boolean)
        Me.DataColumn219.DefaultValue = False
        '
        'DataColumn220
        '
        Me.DataColumn220.ColumnName = "balance"
        Me.DataColumn220.DataType = GetType(Decimal)
        Me.DataColumn220.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn221
        '
        Me.DataColumn221.ColumnName = "trans_no"
        Me.DataColumn221.DefaultValue = ""
        '
        'DataColumn222
        '
        Me.DataColumn222.ColumnName = "trans_date"
        Me.DataColumn222.DefaultValue = ""
        '
        'output_vat
        '
        Me.output_vat.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn118, Me.DataColumn119, Me.DataColumn120, Me.DataColumn121, Me.DataColumn122, Me.DataColumn123, Me.DataColumn124, Me.DataColumn125, Me.DataColumn126, Me.DataColumn127, Me.DataColumn128, Me.DataColumn129, Me.DataColumn130, Me.DataColumn131, Me.DataColumn132, Me.DataColumn133, Me.DataColumn134, Me.DataColumn135, Me.DataColumn136, Me.DataColumn137, Me.DataColumn158, Me.DataColumn223, Me.DataColumn224, Me.DataColumn225, Me.DataColumn226, Me.DataColumn227, Me.DataColumn228, Me.DataColumn229, Me.DataColumn230, Me.DataColumn231, Me.DataColumn232, Me.DataColumn233, Me.DataColumn234, Me.DataColumn235, Me.DataColumn236})
        Me.output_vat.TableName = "output_vat"
        '
        'DataColumn118
        '
        Me.DataColumn118.ColumnName = "sel"
        Me.DataColumn118.DataType = GetType(Boolean)
        Me.DataColumn118.DefaultValue = False
        '
        'DataColumn119
        '
        Me.DataColumn119.ColumnName = "output_vat_id"
        Me.DataColumn119.DefaultValue = ""
        '
        'DataColumn120
        '
        Me.DataColumn120.ColumnName = "jbooks_id"
        Me.DataColumn120.DefaultValue = ""
        '
        'DataColumn121
        '
        Me.DataColumn121.ColumnName = "general_id"
        Me.DataColumn121.DefaultValue = ""
        '
        'DataColumn122
        '
        Me.DataColumn122.ColumnName = "currency_id"
        Me.DataColumn122.DefaultValue = ""
        '
        'DataColumn123
        '
        Me.DataColumn123.ColumnName = "exchange_rate"
        Me.DataColumn123.DataType = GetType(Decimal)
        Me.DataColumn123.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn124
        '
        Me.DataColumn124.ColumnName = "based_rate"
        Me.DataColumn124.DataType = GetType(Decimal)
        Me.DataColumn124.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn125
        '
        Me.DataColumn125.ColumnName = "offset_type"
        Me.DataColumn125.DefaultValue = ""
        '
        'DataColumn126
        '
        Me.DataColumn126.ColumnName = "vat_class"
        Me.DataColumn126.DefaultValue = ""
        '
        'DataColumn127
        '
        Me.DataColumn127.ColumnName = "vat_type"
        Me.DataColumn127.DefaultValue = ""
        '
        'DataColumn128
        '
        Me.DataColumn128.ColumnName = "vat_rate"
        Me.DataColumn128.DataType = GetType(Decimal)
        Me.DataColumn128.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn129
        '
        Me.DataColumn129.ColumnName = "gross_amount"
        Me.DataColumn129.DataType = GetType(Decimal)
        Me.DataColumn129.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn130
        '
        Me.DataColumn130.ColumnName = "vat_amount"
        Me.DataColumn130.DataType = GetType(Decimal)
        Me.DataColumn130.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn131
        '
        Me.DataColumn131.ColumnName = "net_amount"
        Me.DataColumn131.DataType = GetType(Decimal)
        Me.DataColumn131.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn132
        '
        Me.DataColumn132.ColumnName = "debit"
        Me.DataColumn132.DataType = GetType(Decimal)
        Me.DataColumn132.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn133
        '
        Me.DataColumn133.ColumnName = "credit"
        Me.DataColumn133.DataType = GetType(Decimal)
        Me.DataColumn133.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn134
        '
        Me.DataColumn134.ColumnName = "gross_amount_based"
        Me.DataColumn134.DataType = GetType(Decimal)
        Me.DataColumn134.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn135
        '
        Me.DataColumn135.ColumnName = "vat_amount_based"
        Me.DataColumn135.DataType = GetType(Decimal)
        Me.DataColumn135.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn136
        '
        Me.DataColumn136.ColumnName = "net_amount_based"
        Me.DataColumn136.DataType = GetType(Decimal)
        Me.DataColumn136.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn137
        '
        Me.DataColumn137.ColumnName = "debit_based"
        Me.DataColumn137.DataType = GetType(Decimal)
        Me.DataColumn137.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn158
        '
        Me.DataColumn158.ColumnName = "credit_based"
        Me.DataColumn158.DataType = GetType(Decimal)
        Me.DataColumn158.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn223
        '
        Me.DataColumn223.ColumnName = "ref_output_vat_id"
        Me.DataColumn223.DefaultValue = ""
        '
        'DataColumn224
        '
        Me.DataColumn224.ColumnName = "ref_no"
        Me.DataColumn224.DefaultValue = ""
        '
        'DataColumn225
        '
        Me.DataColumn225.ColumnName = "general_code"
        Me.DataColumn225.DefaultValue = ""
        '
        'DataColumn226
        '
        Me.DataColumn226.ColumnName = "general_name"
        Me.DataColumn226.DefaultValue = ""
        '
        'DataColumn227
        '
        Me.DataColumn227.ColumnName = "currency_code"
        Me.DataColumn227.DefaultValue = ""
        '
        'DataColumn228
        '
        Me.DataColumn228.ColumnName = "currency_name"
        Me.DataColumn228.DefaultValue = ""
        '
        'DataColumn229
        '
        Me.DataColumn229.ColumnName = "tmp_amount"
        Me.DataColumn229.DataType = GetType(Decimal)
        Me.DataColumn229.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn230
        '
        Me.DataColumn230.ColumnName = "address"
        Me.DataColumn230.DefaultValue = ""
        '
        'DataColumn231
        '
        Me.DataColumn231.ColumnName = "tin"
        Me.DataColumn231.DefaultValue = ""
        '
        'DataColumn232
        '
        Me.DataColumn232.ColumnName = "isInputted"
        Me.DataColumn232.DataType = GetType(Boolean)
        Me.DataColumn232.DefaultValue = False
        '
        'DataColumn233
        '
        Me.DataColumn233.ColumnName = "deleted"
        Me.DataColumn233.DataType = GetType(Boolean)
        Me.DataColumn233.DefaultValue = False
        '
        'DataColumn234
        '
        Me.DataColumn234.ColumnName = "balance"
        Me.DataColumn234.DataType = GetType(Decimal)
        Me.DataColumn234.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn235
        '
        Me.DataColumn235.ColumnName = "trans_no"
        Me.DataColumn235.DefaultValue = ""
        '
        'DataColumn236
        '
        Me.DataColumn236.ColumnName = "trans_date"
        Me.DataColumn236.DefaultValue = ""
        '
        'prepaid
        '
        Me.prepaid.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn138, Me.DataColumn139, Me.DataColumn140, Me.DataColumn141, Me.DataColumn142, Me.DataColumn143, Me.DataColumn144, Me.DataColumn145, Me.DataColumn146, Me.DataColumn147, Me.DataColumn148, Me.DataColumn149, Me.DataColumn150, Me.DataColumn159, Me.DataColumn237, Me.DataColumn238, Me.DataColumn239, Me.DataColumn240, Me.DataColumn241, Me.DataColumn242, Me.DataColumn243, Me.DataColumn244, Me.DataColumn245, Me.DataColumn246, Me.DataColumn247, Me.DataColumn248})
        Me.prepaid.TableName = "prepaid"
        '
        'DataColumn138
        '
        Me.DataColumn138.ColumnName = "sel"
        Me.DataColumn138.DataType = GetType(Boolean)
        Me.DataColumn138.DefaultValue = False
        '
        'DataColumn139
        '
        Me.DataColumn139.ColumnName = "prepaid_id"
        Me.DataColumn139.DefaultValue = ""
        '
        'DataColumn140
        '
        Me.DataColumn140.ColumnName = "jbooks_id"
        Me.DataColumn140.DefaultValue = ""
        '
        'DataColumn141
        '
        Me.DataColumn141.ColumnName = "currency_id"
        Me.DataColumn141.DefaultValue = ""
        '
        'DataColumn142
        '
        Me.DataColumn142.ColumnName = "exchange_rate"
        Me.DataColumn142.DataType = GetType(Decimal)
        Me.DataColumn142.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn143
        '
        Me.DataColumn143.ColumnName = "based_rate"
        Me.DataColumn143.DataType = GetType(Decimal)
        Me.DataColumn143.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn144
        '
        Me.DataColumn144.ColumnName = "description"
        Me.DataColumn144.DefaultValue = ""
        '
        'DataColumn145
        '
        Me.DataColumn145.ColumnName = "date_acquired"
        Me.DataColumn145.DataType = GetType(Date)
        '
        'DataColumn146
        '
        Me.DataColumn146.ColumnName = "amount"
        Me.DataColumn146.DataType = GetType(Decimal)
        Me.DataColumn146.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn147
        '
        Me.DataColumn147.ColumnName = "amount_based"
        Me.DataColumn147.DataType = GetType(Decimal)
        Me.DataColumn147.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn148
        '
        Me.DataColumn148.ColumnName = "useful_life"
        Me.DataColumn148.DataType = GetType(Integer)
        Me.DataColumn148.DefaultValue = 0
        '
        'DataColumn149
        '
        Me.DataColumn149.ColumnName = "date_start"
        Me.DataColumn149.DataType = GetType(Date)
        '
        'DataColumn150
        '
        Me.DataColumn150.ColumnName = "debit"
        Me.DataColumn150.DataType = GetType(Decimal)
        Me.DataColumn150.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn159
        '
        Me.DataColumn159.ColumnName = "credit"
        Me.DataColumn159.DataType = GetType(Decimal)
        Me.DataColumn159.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn237
        '
        Me.DataColumn237.ColumnName = "debit_based"
        Me.DataColumn237.DataType = GetType(Decimal)
        Me.DataColumn237.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn238
        '
        Me.DataColumn238.ColumnName = "credit_based"
        Me.DataColumn238.DataType = GetType(Decimal)
        Me.DataColumn238.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn239
        '
        Me.DataColumn239.ColumnName = "ref_prepaid_id"
        Me.DataColumn239.DefaultValue = ""
        '
        'DataColumn240
        '
        Me.DataColumn240.ColumnName = "ref_no"
        Me.DataColumn240.DefaultValue = ""
        '
        'DataColumn241
        '
        Me.DataColumn241.ColumnName = "currency_code"
        Me.DataColumn241.DefaultValue = ""
        '
        'DataColumn242
        '
        Me.DataColumn242.ColumnName = "currency_name"
        Me.DataColumn242.DefaultValue = ""
        '
        'DataColumn243
        '
        Me.DataColumn243.ColumnName = "tmp_amount"
        Me.DataColumn243.DataType = GetType(Decimal)
        Me.DataColumn243.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn244
        '
        Me.DataColumn244.ColumnName = "isInputted"
        Me.DataColumn244.DataType = GetType(Boolean)
        Me.DataColumn244.DefaultValue = False
        '
        'DataColumn245
        '
        Me.DataColumn245.ColumnName = "deleted"
        Me.DataColumn245.DataType = GetType(Boolean)
        Me.DataColumn245.DefaultValue = False
        '
        'DataColumn246
        '
        Me.DataColumn246.ColumnName = "balance"
        Me.DataColumn246.DataType = GetType(Decimal)
        Me.DataColumn246.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn247
        '
        Me.DataColumn247.ColumnName = "trans_no"
        Me.DataColumn247.DefaultValue = ""
        '
        'DataColumn248
        '
        Me.DataColumn248.ColumnName = "trans_date"
        Me.DataColumn248.DefaultValue = ""
        '
        'final_tax
        '
        Me.final_tax.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn178, Me.DataColumn179, Me.DataColumn180, Me.DataColumn181, Me.DataColumn182, Me.DataColumn183, Me.DataColumn184, Me.DataColumn185, Me.DataColumn186, Me.DataColumn187, Me.DataColumn188, Me.DataColumn189, Me.DataColumn190, Me.DataColumn191, Me.DataColumn192, Me.DataColumn193, Me.DataColumn194, Me.DataColumn195, Me.DataColumn196, Me.DataColumn197, Me.DataColumn198, Me.DataColumn199, Me.DataColumn200, Me.DataColumn201, Me.DataColumn202, Me.DataColumn203, Me.DataColumn204, Me.DataColumn205, Me.DataColumn206, Me.DataColumn207, Me.DataColumn209})
        Me.final_tax.TableName = "final_tax"
        '
        'DataColumn178
        '
        Me.DataColumn178.ColumnName = "sel"
        Me.DataColumn178.DataType = GetType(Boolean)
        Me.DataColumn178.DefaultValue = False
        '
        'DataColumn179
        '
        Me.DataColumn179.ColumnName = "jbooks_id"
        Me.DataColumn179.DefaultValue = ""
        '
        'DataColumn180
        '
        Me.DataColumn180.ColumnName = "fs_final_tax_id"
        Me.DataColumn180.DefaultValue = ""
        '
        'DataColumn181
        '
        Me.DataColumn181.ColumnName = "offset_type"
        Me.DataColumn181.DefaultValue = ""
        '
        'DataColumn182
        '
        Me.DataColumn182.ColumnName = "tax_rate"
        Me.DataColumn182.DataType = GetType(Decimal)
        Me.DataColumn182.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn183
        '
        Me.DataColumn183.ColumnName = "amount"
        Me.DataColumn183.DataType = GetType(Decimal)
        Me.DataColumn183.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn184
        '
        Me.DataColumn184.ColumnName = "tax_amount"
        Me.DataColumn184.DataType = GetType(Decimal)
        Me.DataColumn184.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn185
        '
        Me.DataColumn185.ColumnName = "debit"
        Me.DataColumn185.DataType = GetType(Decimal)
        Me.DataColumn185.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn186
        '
        Me.DataColumn186.ColumnName = "credit"
        Me.DataColumn186.DataType = GetType(Decimal)
        Me.DataColumn186.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn187
        '
        Me.DataColumn187.ColumnName = "amount_based"
        Me.DataColumn187.DataType = GetType(Decimal)
        Me.DataColumn187.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn188
        '
        Me.DataColumn188.ColumnName = "tax_amount_based"
        Me.DataColumn188.DataType = GetType(Decimal)
        Me.DataColumn188.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn189
        '
        Me.DataColumn189.ColumnName = "debit_based"
        Me.DataColumn189.DataType = GetType(Decimal)
        Me.DataColumn189.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn190
        '
        Me.DataColumn190.ColumnName = "credit_based"
        Me.DataColumn190.DataType = GetType(Decimal)
        Me.DataColumn190.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn191
        '
        Me.DataColumn191.ColumnName = "ref_final_tax_id"
        Me.DataColumn191.DefaultValue = ""
        '
        'DataColumn192
        '
        Me.DataColumn192.ColumnName = "general_code"
        Me.DataColumn192.DefaultValue = ""
        '
        'DataColumn193
        '
        Me.DataColumn193.ColumnName = "general_name"
        Me.DataColumn193.DefaultValue = ""
        '
        'DataColumn194
        '
        Me.DataColumn194.ColumnName = "fs_final_tax_code"
        Me.DataColumn194.DefaultValue = ""
        '
        'DataColumn195
        '
        Me.DataColumn195.ColumnName = "fs_final_tax_name"
        Me.DataColumn195.DefaultValue = ""
        '
        'DataColumn196
        '
        Me.DataColumn196.ColumnName = "tin"
        Me.DataColumn196.DefaultValue = ""
        '
        'DataColumn197
        '
        Me.DataColumn197.ColumnName = "deleted"
        Me.DataColumn197.DataType = GetType(Boolean)
        Me.DataColumn197.DefaultValue = False
        '
        'DataColumn198
        '
        Me.DataColumn198.ColumnName = "trans_date"
        Me.DataColumn198.DefaultValue = ""
        '
        'DataColumn199
        '
        Me.DataColumn199.ColumnName = "ref_no"
        Me.DataColumn199.DefaultValue = ""
        '
        'DataColumn200
        '
        Me.DataColumn200.ColumnName = "tmp_amount"
        Me.DataColumn200.DataType = GetType(Decimal)
        Me.DataColumn200.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn201
        '
        Me.DataColumn201.ColumnName = "isInputted"
        Me.DataColumn201.DataType = GetType(Boolean)
        Me.DataColumn201.DefaultValue = False
        '
        'DataColumn202
        '
        Me.DataColumn202.ColumnName = "balance"
        Me.DataColumn202.DataType = GetType(Decimal)
        Me.DataColumn202.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn203
        '
        Me.DataColumn203.ColumnName = "currency_id"
        Me.DataColumn203.DefaultValue = ""
        '
        'DataColumn204
        '
        Me.DataColumn204.ColumnName = "currency_name"
        Me.DataColumn204.DefaultValue = ""
        '
        'DataColumn205
        '
        Me.DataColumn205.ColumnName = "exchange_rate"
        Me.DataColumn205.DataType = GetType(Decimal)
        Me.DataColumn205.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn206
        '
        Me.DataColumn206.ColumnName = "based_rate"
        Me.DataColumn206.DataType = GetType(Decimal)
        Me.DataColumn206.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn207
        '
        Me.DataColumn207.ColumnName = "general_id"
        Me.DataColumn207.DefaultValue = ""
        '
        'DataColumn209
        '
        Me.DataColumn209.ColumnName = "final_tax_id"
        Me.DataColumn209.DefaultValue = ""
        '
        'particular
        '
        Me.particular.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn300, Me.DataColumn301, Me.DataColumn302, Me.DataColumn303, Me.DataColumn304, Me.DataColumn305})
        Me.particular.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"trans_particular_id"}, True)})
        Me.particular.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn300}
        Me.particular.TableName = "particular"
        '
        'DataColumn300
        '
        Me.DataColumn300.AllowDBNull = False
        Me.DataColumn300.ColumnName = "trans_particular_id"
        Me.DataColumn300.DefaultValue = ""
        '
        'DataColumn301
        '
        Me.DataColumn301.ColumnName = "trans_id"
        Me.DataColumn301.DefaultValue = ""
        '
        'DataColumn302
        '
        Me.DataColumn302.ColumnName = "trans_particular_code"
        Me.DataColumn302.DefaultValue = ""
        '
        'DataColumn303
        '
        Me.DataColumn303.ColumnName = "trans_particular_name"
        Me.DataColumn303.DefaultValue = ""
        '
        'DataColumn304
        '
        Me.DataColumn304.ColumnName = "trans_particular_amount"
        Me.DataColumn304.DataType = GetType(Decimal)
        Me.DataColumn304.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn305
        '
        Me.DataColumn305.ColumnName = "deleted"
        Me.DataColumn305.DataType = GetType(Boolean)
        Me.DataColumn305.DefaultValue = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(183, 69)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "F4 Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(800, 30)
        Me.Myformheader1.TabIndex = 0
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(432, 69)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(80, 24)
        Me.btnPrevious.TabIndex = 322
        Me.btnPrevious.Text = "F7 Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(515, 69)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(80, 24)
        Me.btnNext.TabIndex = 323
        Me.btnNext.Text = "F8 Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(349, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 24)
        Me.btnSearch.TabIndex = 324
        Me.btnSearch.Text = "F6 Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(681, 69)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 327
        Me.btnExit.Text = "F10 Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'imgLock
        '
        Me.imgLock.Image = Global.accounting.My.Resources.Resources.lock
        Me.imgLock.Location = New System.Drawing.Point(243, 33)
        Me.imgLock.Name = "imgLock"
        Me.imgLock.Size = New System.Drawing.Size(25, 25)
        Me.imgLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLock.TabIndex = 334
        Me.imgLock.TabStop = False
        Me.imgLock.Visible = False
        '
        'btnViewSchedule
        '
        Me.btnViewSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnViewSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSchedule.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSchedule.ForeColor = System.Drawing.Color.White
        Me.btnViewSchedule.Location = New System.Drawing.Point(688, 297)
        Me.btnViewSchedule.Name = "btnViewSchedule"
        Me.btnViewSchedule.Size = New System.Drawing.Size(100, 24)
        Me.btnViewSchedule.TabIndex = 335
        Me.btnViewSchedule.Text = "View Schedule"
        Me.btnViewSchedule.UseVisualStyleBackColor = False
        '
        'lblBookName
        '
        Me.lblBookName.BackColor = System.Drawing.Color.Transparent
        Me.lblBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookName.Location = New System.Drawing.Point(13, 39)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(776, 21)
        Me.lblBookName.TabIndex = 336
        Me.lblBookName.Text = "BOOK NAME"
        Me.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(343, 314)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(114, 37)
        Me.lblStatus.TabIndex = 337
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'transactiondc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 665)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnViewSchedule)
        Me.Controls.Add(Me.imgLock)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.hdr)
        Me.Controls.Add(Me.lbldiffbasedtotal)
        Me.Controls.Add(Me.lbldebitbasedtotal)
        Me.Controls.Add(Me.lblcreditbasedtotal)
        Me.Controls.Add(Me.lbldifftotal)
        Me.Controls.Add(Me.lbldebittotal)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblcredittotal)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.det)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCorrection)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnComment)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblBookName)
        Me.Controls.Add(Me.dgjbooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "transactiondc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debit / Credit Memo"
        Me.hdr.ResumeLayout(False)
        Me.hdr.PerformLayout()
        CType(Me.txtAmountBased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnParticular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBasedRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExchangeRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgjbooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.det.ResumeLayout(False)
        Me.det.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditBased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebitBased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBasedRateDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExchangeRateDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jbooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ewt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fixed_asset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input_vat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.output_vat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prepaid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.final_tax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.particular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnCorrection As System.Windows.Forms.Button
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnComment As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents hdr As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbldiffbasedtotal As System.Windows.Forms.Label
    Friend WithEvents lbldebitbasedtotal As System.Windows.Forms.Label
    Friend WithEvents lblcreditbasedtotal As System.Windows.Forms.Label
    Friend WithEvents lbldifftotal As System.Windows.Forms.Label
    Friend WithEvents lbldebittotal As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblcredittotal As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgjbooks As System.Windows.Forms.DataGridView
    Friend WithEvents det As System.Windows.Forms.Panel
    Friend WithEvents lblLineRemarks As System.Windows.Forms.Label
    Friend WithEvents lbltermsdet As System.Windows.Forms.Label
    Friend WithEvents lblbasedrate As System.Windows.Forms.Label
    Friend WithEvents lblexchangerate As System.Windows.Forms.Label
    Friend WithEvents lblcurrency As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAllocation As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblProject As System.Windows.Forms.Label
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents trans As System.Data.DataTable
    Friend WithEvents DataColum101 As System.Data.DataColumn
    Friend WithEvents DataColum102 As System.Data.DataColumn
    Friend WithEvents DataColum103 As System.Data.DataColumn
    Friend WithEvents DataColum104 As System.Data.DataColumn
    Friend WithEvents DataColum105 As System.Data.DataColumn
    Friend WithEvents DataColum106 As System.Data.DataColumn
    Friend WithEvents DataColum107 As System.Data.DataColumn
    Friend WithEvents DataColum108 As System.Data.DataColumn
    Friend WithEvents DataColum109 As System.Data.DataColumn
    Friend WithEvents DataColum110 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents description As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn160 As System.Data.DataColumn
    Friend WithEvents DataColumn161 As System.Data.DataColumn
    Friend WithEvents DataColumn162 As System.Data.DataColumn
    Friend WithEvents DataColumn164 As System.Data.DataColumn
    Friend WithEvents DataColumn275 As System.Data.DataColumn
    Friend WithEvents DataColumn276 As System.Data.DataColumn
    Friend WithEvents DataColumn277 As System.Data.DataColumn
    Friend WithEvents DataColumn278 As System.Data.DataColumn
    Friend WithEvents DataColumn279 As System.Data.DataColumn
    Friend WithEvents DataColumn293 As System.Data.DataColumn
    Friend WithEvents DataColumn294 As System.Data.DataColumn
    Friend WithEvents DataColumn295 As System.Data.DataColumn
    Friend WithEvents DataColumn296 As System.Data.DataColumn
    Friend WithEvents DataColumn297 As System.Data.DataColumn
    Friend WithEvents DataColumn298 As System.Data.DataColumn
    Friend WithEvents DataColumn299 As System.Data.DataColumn
    Friend WithEvents jbooks As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn151 As System.Data.DataColumn
    Friend WithEvents DataColumn152 As System.Data.DataColumn
    Friend WithEvents DataColumn153 As System.Data.DataColumn
    Friend WithEvents DataColumn165 As System.Data.DataColumn
    Friend WithEvents DataColumn170 As System.Data.DataColumn
    Friend WithEvents DataColumn171 As System.Data.DataColumn
    Friend WithEvents DataColumn172 As System.Data.DataColumn
    Friend WithEvents DataColumn173 As System.Data.DataColumn
    Friend WithEvents DataColumn261 As System.Data.DataColumn
    Friend WithEvents DataColumn262 As System.Data.DataColumn
    Friend WithEvents DataColumn263 As System.Data.DataColumn
    Friend WithEvents DataColumn264 As System.Data.DataColumn
    Friend WithEvents DataColumn284 As System.Data.DataColumn
    Friend WithEvents DataColumn285 As System.Data.DataColumn
    Friend WithEvents DataColumn286 As System.Data.DataColumn
    Friend WithEvents DataColumn287 As System.Data.DataColumn
    Friend WithEvents DataColumn288 As System.Data.DataColumn
    Friend WithEvents ewt As System.Data.DataTable
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn96 As System.Data.DataColumn
    Friend WithEvents DataColumn154 As System.Data.DataColumn
    Friend WithEvents DataColumn163 As System.Data.DataColumn
    Friend WithEvents DataColumn166 As System.Data.DataColumn
    Friend WithEvents DataColumn167 As System.Data.DataColumn
    Friend WithEvents DataColumn168 As System.Data.DataColumn
    Friend WithEvents DataColumn169 As System.Data.DataColumn
    Friend WithEvents DataColumn174 As System.Data.DataColumn
    Friend WithEvents DataColumn175 As System.Data.DataColumn
    Friend WithEvents DataColumn176 As System.Data.DataColumn
    Friend WithEvents DataColumn177 As System.Data.DataColumn
    Friend WithEvents DataColumn208 As System.Data.DataColumn
    Friend WithEvents checks As System.Data.DataTable
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn155 As System.Data.DataColumn
    Friend WithEvents DataColumn265 As System.Data.DataColumn
    Friend WithEvents DataColumn266 As System.Data.DataColumn
    Friend WithEvents DataColumn267 As System.Data.DataColumn
    Friend WithEvents DataColumn268 As System.Data.DataColumn
    Friend WithEvents DataColumn269 As System.Data.DataColumn
    Friend WithEvents DataColumn270 As System.Data.DataColumn
    Friend WithEvents DataColumn271 As System.Data.DataColumn
    Friend WithEvents DataColumn272 As System.Data.DataColumn
    Friend WithEvents DataColumn273 As System.Data.DataColumn
    Friend WithEvents DataColumn274 As System.Data.DataColumn
    Friend WithEvents DataColumn280 As System.Data.DataColumn
    Friend WithEvents DataColumn281 As System.Data.DataColumn
    Friend WithEvents DataColumn282 As System.Data.DataColumn
    Friend WithEvents DataColumn283 As System.Data.DataColumn
    Friend WithEvents DataColumn291 As System.Data.DataColumn
    Friend WithEvents DataColumn292 As System.Data.DataColumn
    Friend WithEvents fixed_asset As System.Data.DataTable
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents DataColumn87 As System.Data.DataColumn
    Friend WithEvents DataColumn88 As System.Data.DataColumn
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents DataColumn93 As System.Data.DataColumn
    Friend WithEvents DataColumn94 As System.Data.DataColumn
    Friend WithEvents DataColumn95 As System.Data.DataColumn
    Friend WithEvents DataColumn156 As System.Data.DataColumn
    Friend WithEvents DataColumn249 As System.Data.DataColumn
    Friend WithEvents DataColumn250 As System.Data.DataColumn
    Friend WithEvents DataColumn251 As System.Data.DataColumn
    Friend WithEvents DataColumn252 As System.Data.DataColumn
    Friend WithEvents DataColumn253 As System.Data.DataColumn
    Friend WithEvents DataColumn254 As System.Data.DataColumn
    Friend WithEvents DataColumn255 As System.Data.DataColumn
    Friend WithEvents DataColumn256 As System.Data.DataColumn
    Friend WithEvents DataColumn257 As System.Data.DataColumn
    Friend WithEvents DataColumn258 As System.Data.DataColumn
    Friend WithEvents DataColumn259 As System.Data.DataColumn
    Friend WithEvents DataColumn260 As System.Data.DataColumn
    Friend WithEvents DataColumn289 As System.Data.DataColumn
    Friend WithEvents DataColumn290 As System.Data.DataColumn
    Friend WithEvents input_vat As System.Data.DataTable
    Friend WithEvents DataColumn97 As System.Data.DataColumn
    Friend WithEvents DataColumn98 As System.Data.DataColumn
    Friend WithEvents DataColumn99 As System.Data.DataColumn
    Friend WithEvents DataColumn100 As System.Data.DataColumn
    Friend WithEvents DataColumn101 As System.Data.DataColumn
    Friend WithEvents DataColumn102 As System.Data.DataColumn
    Friend WithEvents DataColumn103 As System.Data.DataColumn
    Friend WithEvents DataColumn104 As System.Data.DataColumn
    Friend WithEvents DataColumn105 As System.Data.DataColumn
    Friend WithEvents DataColumn106 As System.Data.DataColumn
    Friend WithEvents DataColumn107 As System.Data.DataColumn
    Friend WithEvents DataColumn108 As System.Data.DataColumn
    Friend WithEvents DataColumn109 As System.Data.DataColumn
    Friend WithEvents DataColumn110 As System.Data.DataColumn
    Friend WithEvents DataColumn111 As System.Data.DataColumn
    Friend WithEvents DataColumn112 As System.Data.DataColumn
    Friend WithEvents DataColumn113 As System.Data.DataColumn
    Friend WithEvents DataColumn114 As System.Data.DataColumn
    Friend WithEvents DataColumn115 As System.Data.DataColumn
    Friend WithEvents DataColumn116 As System.Data.DataColumn
    Friend WithEvents DataColumn117 As System.Data.DataColumn
    Friend WithEvents DataColumn157 As System.Data.DataColumn
    Friend WithEvents DataColumn210 As System.Data.DataColumn
    Friend WithEvents DataColumn211 As System.Data.DataColumn
    Friend WithEvents DataColumn212 As System.Data.DataColumn
    Friend WithEvents DataColumn213 As System.Data.DataColumn
    Friend WithEvents DataColumn214 As System.Data.DataColumn
    Friend WithEvents DataColumn215 As System.Data.DataColumn
    Friend WithEvents DataColumn216 As System.Data.DataColumn
    Friend WithEvents DataColumn217 As System.Data.DataColumn
    Friend WithEvents DataColumn218 As System.Data.DataColumn
    Friend WithEvents DataColumn219 As System.Data.DataColumn
    Friend WithEvents DataColumn220 As System.Data.DataColumn
    Friend WithEvents DataColumn221 As System.Data.DataColumn
    Friend WithEvents DataColumn222 As System.Data.DataColumn
    Friend WithEvents output_vat As System.Data.DataTable
    Friend WithEvents DataColumn118 As System.Data.DataColumn
    Friend WithEvents DataColumn119 As System.Data.DataColumn
    Friend WithEvents DataColumn120 As System.Data.DataColumn
    Friend WithEvents DataColumn121 As System.Data.DataColumn
    Friend WithEvents DataColumn122 As System.Data.DataColumn
    Friend WithEvents DataColumn123 As System.Data.DataColumn
    Friend WithEvents DataColumn124 As System.Data.DataColumn
    Friend WithEvents DataColumn125 As System.Data.DataColumn
    Friend WithEvents DataColumn126 As System.Data.DataColumn
    Friend WithEvents DataColumn127 As System.Data.DataColumn
    Friend WithEvents DataColumn128 As System.Data.DataColumn
    Friend WithEvents DataColumn129 As System.Data.DataColumn
    Friend WithEvents DataColumn130 As System.Data.DataColumn
    Friend WithEvents DataColumn131 As System.Data.DataColumn
    Friend WithEvents DataColumn132 As System.Data.DataColumn
    Friend WithEvents DataColumn133 As System.Data.DataColumn
    Friend WithEvents DataColumn134 As System.Data.DataColumn
    Friend WithEvents DataColumn135 As System.Data.DataColumn
    Friend WithEvents DataColumn136 As System.Data.DataColumn
    Friend WithEvents DataColumn137 As System.Data.DataColumn
    Friend WithEvents DataColumn158 As System.Data.DataColumn
    Friend WithEvents DataColumn223 As System.Data.DataColumn
    Friend WithEvents DataColumn224 As System.Data.DataColumn
    Friend WithEvents DataColumn225 As System.Data.DataColumn
    Friend WithEvents DataColumn226 As System.Data.DataColumn
    Friend WithEvents DataColumn227 As System.Data.DataColumn
    Friend WithEvents DataColumn228 As System.Data.DataColumn
    Friend WithEvents DataColumn229 As System.Data.DataColumn
    Friend WithEvents DataColumn230 As System.Data.DataColumn
    Friend WithEvents DataColumn231 As System.Data.DataColumn
    Friend WithEvents DataColumn232 As System.Data.DataColumn
    Friend WithEvents DataColumn233 As System.Data.DataColumn
    Friend WithEvents DataColumn234 As System.Data.DataColumn
    Friend WithEvents DataColumn235 As System.Data.DataColumn
    Friend WithEvents DataColumn236 As System.Data.DataColumn
    Friend WithEvents prepaid As System.Data.DataTable
    Friend WithEvents DataColumn138 As System.Data.DataColumn
    Friend WithEvents DataColumn139 As System.Data.DataColumn
    Friend WithEvents DataColumn140 As System.Data.DataColumn
    Friend WithEvents DataColumn141 As System.Data.DataColumn
    Friend WithEvents DataColumn142 As System.Data.DataColumn
    Friend WithEvents DataColumn143 As System.Data.DataColumn
    Friend WithEvents DataColumn144 As System.Data.DataColumn
    Friend WithEvents DataColumn145 As System.Data.DataColumn
    Friend WithEvents DataColumn146 As System.Data.DataColumn
    Friend WithEvents DataColumn147 As System.Data.DataColumn
    Friend WithEvents DataColumn148 As System.Data.DataColumn
    Friend WithEvents DataColumn149 As System.Data.DataColumn
    Friend WithEvents DataColumn150 As System.Data.DataColumn
    Friend WithEvents DataColumn159 As System.Data.DataColumn
    Friend WithEvents DataColumn237 As System.Data.DataColumn
    Friend WithEvents DataColumn238 As System.Data.DataColumn
    Friend WithEvents DataColumn239 As System.Data.DataColumn
    Friend WithEvents DataColumn240 As System.Data.DataColumn
    Friend WithEvents DataColumn241 As System.Data.DataColumn
    Friend WithEvents DataColumn242 As System.Data.DataColumn
    Friend WithEvents DataColumn243 As System.Data.DataColumn
    Friend WithEvents DataColumn244 As System.Data.DataColumn
    Friend WithEvents DataColumn245 As System.Data.DataColumn
    Friend WithEvents DataColumn246 As System.Data.DataColumn
    Friend WithEvents DataColumn247 As System.Data.DataColumn
    Friend WithEvents DataColumn248 As System.Data.DataColumn
    Friend WithEvents final_tax As System.Data.DataTable
    Friend WithEvents DataColumn178 As System.Data.DataColumn
    Friend WithEvents DataColumn179 As System.Data.DataColumn
    Friend WithEvents DataColumn180 As System.Data.DataColumn
    Friend WithEvents DataColumn181 As System.Data.DataColumn
    Friend WithEvents DataColumn182 As System.Data.DataColumn
    Friend WithEvents DataColumn183 As System.Data.DataColumn
    Friend WithEvents DataColumn184 As System.Data.DataColumn
    Friend WithEvents DataColumn185 As System.Data.DataColumn
    Friend WithEvents DataColumn186 As System.Data.DataColumn
    Friend WithEvents DataColumn187 As System.Data.DataColumn
    Friend WithEvents DataColumn188 As System.Data.DataColumn
    Friend WithEvents DataColumn189 As System.Data.DataColumn
    Friend WithEvents DataColumn190 As System.Data.DataColumn
    Friend WithEvents DataColumn191 As System.Data.DataColumn
    Friend WithEvents DataColumn192 As System.Data.DataColumn
    Friend WithEvents DataColumn193 As System.Data.DataColumn
    Friend WithEvents DataColumn194 As System.Data.DataColumn
    Friend WithEvents DataColumn195 As System.Data.DataColumn
    Friend WithEvents DataColumn196 As System.Data.DataColumn
    Friend WithEvents DataColumn197 As System.Data.DataColumn
    Friend WithEvents DataColumn198 As System.Data.DataColumn
    Friend WithEvents DataColumn199 As System.Data.DataColumn
    Friend WithEvents DataColumn200 As System.Data.DataColumn
    Friend WithEvents DataColumn201 As System.Data.DataColumn
    Friend WithEvents DataColumn202 As System.Data.DataColumn
    Friend WithEvents DataColumn203 As System.Data.DataColumn
    Friend WithEvents DataColumn204 As System.Data.DataColumn
    Friend WithEvents DataColumn205 As System.Data.DataColumn
    Friend WithEvents DataColumn206 As System.Data.DataColumn
    Friend WithEvents DataColumn207 As System.Data.DataColumn
    Friend WithEvents DataColumn209 As System.Data.DataColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents particular As System.Data.DataTable
    Friend WithEvents DataColumn300 As System.Data.DataColumn
    Friend WithEvents DataColumn301 As System.Data.DataColumn
    Friend WithEvents DataColumn302 As System.Data.DataColumn
    Friend WithEvents DataColumn303 As System.Data.DataColumn
    Friend WithEvents DataColumn304 As System.Data.DataColumn
    Friend WithEvents DataColumn305 As System.Data.DataColumn
    Friend WithEvents txt_year As user_control.MyTextBox
    Friend WithEvents txt_day As user_control.MyTextBox
    Friend WithEvents txt_month As user_control.MyTextBox
    Friend WithEvents txt_currency_name As user_control.MyTextBox
    Friend WithEvents txt_general_name As user_control.MyTextBox
    Friend WithEvents txt_description As user_control.MyTextBox
    Friend WithEvents txt_amount_in_word As user_control.MyTextBox
    Friend WithEvents txt_currency_id As user_control.MyTextBox
    Friend WithEvents txt_general_id As user_control.MyTextBox
    Friend WithEvents txt_trans_no As user_control.MyTextBox
    Friend WithEvents txt_trans_id As user_control.MyTextBox
    Friend WithEvents txt_trans_dc_id As user_control.MyTextBox
    Friend WithEvents txt_tmp_jbooks_id As user_control.MyTextBox
    Friend WithEvents txt_ref_book_code As user_control.MyTextBox
    Friend WithEvents txt_ref_journal_code As user_control.MyTextBox
    Friend WithEvents txt_allocation_id As user_control.MyTextBox
    Friend WithEvents txt_nodays_det As user_control.MyTextBox
    Friend WithEvents txt_terms_id_det As user_control.MyTextBox
    Friend WithEvents txt_department_id As user_control.MyTextBox
    Friend WithEvents txt_general_name_det As user_control.MyTextBox
    Friend WithEvents txt_account_name As user_control.MyTextBox
    Friend WithEvents txt_ref_jbooks_id As user_control.MyTextBox
    Friend WithEvents txt_general_id_det As user_control.MyTextBox
    Friend WithEvents txt_project_id As user_control.MyTextBox
    Friend WithEvents txt_account_id As user_control.MyTextBox
    Friend WithEvents txt_currency_id_det As user_control.MyTextBox
    Friend WithEvents txt_line_remarks As user_control.MyTextBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataColumn306 As System.Data.DataColumn
    Friend WithEvents txt_validation As user_control.MyTextBox
    Friend WithEvents DataColumn307 As System.Data.DataColumn
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnParticular As System.Windows.Forms.PictureBox
    Friend WithEvents DataColumn308 As System.Data.DataColumn
    Friend WithEvents DataColumn309 As System.Data.DataColumn
    Friend WithEvents DataColumn310 As System.Data.DataColumn
    Friend WithEvents DataColumn311 As System.Data.DataColumn
    Friend WithEvents DataColumn312 As System.Data.DataColumn
    Friend WithEvents imgLock As System.Windows.Forms.PictureBox
    Friend WithEvents btnViewSchedule As System.Windows.Forms.Button
    Friend WithEvents txtAmountBased As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBasedRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExchangeRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreditBased As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebitBased As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBasedRateDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExchangeRateDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_book_unit_no_id As user_control.MyTextBox
    Friend WithEvents lblUnitNo As Windows.Forms.Label
    Friend WithEvents DataColumn313 As DataColumn
    Friend WithEvents DataColumn314 As DataColumn
    Friend WithEvents DataColumn315 As DataColumn
    Friend WithEvents DataColumn316 As DataColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents jbooks_id_tmp As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents offset As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents validation As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minimum As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblBookName As Windows.Forms.Label
    Friend WithEvents txt_particulars_det As user_control.MyTextBox
    Friend WithEvents PictureBox5 As Windows.Forms.PictureBox
    Friend WithEvents DataColumn317 As DataColumn
    Friend WithEvents lblStatus As Windows.Forms.Label
    Friend WithEvents DataColumn318 As DataColumn
    Friend WithEvents txt_project_unit_no_id As user_control.MyTextBox
    Friend WithEvents DataColumn319 As DataColumn
    Friend WithEvents DataColumn320 As DataColumn
    Friend WithEvents DataColumn321 As DataColumn
    Friend WithEvents txt_noCompute As Windows.Forms.CheckBox
    Friend WithEvents DataColumn322 As DataColumn
End Class
