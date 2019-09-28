<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionib
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transactionib))
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
        Me.txtcurrency = New user_control.MyTextBox()
        Me.txtgeneral = New user_control.MyTextBox()
        Me.txtterms = New user_control.MyTextBox()
        Me.txtdesc = New user_control.MyTextBox()
        Me.txtamountwords = New user_control.MyTextBox()
        Me.txtamountbased = New user_control.MyTextBox()
        Me.txtamount = New user_control.MyTextBox()
        Me.txtyear = New user_control.MyTextBox()
        Me.txtday = New user_control.MyTextBox()
        Me.txtmonth = New user_control.MyTextBox()
        Me.txtcurrencyname = New user_control.MyTextBox()
        Me.txtpono = New user_control.MyTextBox()
        Me.txtgeneralname = New user_control.MyTextBox()
        Me.txtbasedrate = New user_control.MyTextBox()
        Me.txtnodays = New user_control.MyTextBox()
        Me.txtdrno = New user_control.MyTextBox()
        Me.txttransno = New user_control.MyTextBox()
        Me.txtexchangerate = New user_control.MyTextBox()
        Me.btnParticular = New System.Windows.Forms.Button()
        Me.txtduedate = New user_control.myDatePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
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
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.jbooks_id_tmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.det = New System.Windows.Forms.Panel()
        Me.txtjbooksidtmp = New user_control.MyTextBox()
        Me.txtdnrefbookcode = New user_control.MyTextBox()
        Me.txtdnrefjournalcode = New user_control.MyTextBox()
        Me.txtdnref = New user_control.MyTextBox()
        Me.txtgeneraldetname = New user_control.MyTextBox()
        Me.txtgeneraldet = New user_control.MyTextBox()
        Me.txtcreditbased = New user_control.MyTextBox()
        Me.txtdebitbased = New user_control.MyTextBox()
        Me.txtcredit = New user_control.MyTextBox()
        Me.txtdebit = New user_control.MyTextBox()
        Me.txttermsiddet = New user_control.MyTextBox()
        Me.txtnodaysdet = New user_control.MyTextBox()
        Me.txtallocation = New user_control.MyTextBox()
        Me.txtdepartment = New user_control.MyTextBox()
        Me.txtproject = New user_control.MyTextBox()
        Me.txtaccountname = New user_control.MyTextBox()
        Me.txt_based_rate = New user_control.MyTextBox()
        Me.txtaccount = New user_control.MyTextBox()
        Me.txt_currency_id = New user_control.MyTextBox()
        Me.txtlineremarks = New user_control.MyTextBox()
        Me.txt_exchange_rate = New user_control.MyTextBox()
        Me.lblLineRemarks = New System.Windows.Forms.Label()
        Me.lbltermsdet = New System.Windows.Forms.Label()
        Me.lblbasedrate = New System.Windows.Forms.Label()
        Me.lblexchangerate = New System.Windows.Forms.Label()
        Me.lblcurrency = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblAllocation = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
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
        Me.txttransid = New user_control.MyTextBox()
        Me.txttransibid = New user_control.MyTextBox()
        Me.hdr.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgjbooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.det.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 277
        Me.Label1.Text = "Sales Voucher"
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(708, 71)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 23)
        Me.btnNotSave.TabIndex = 300
        Me.btnNotSave.Text = "Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        Me.btnNotSave.Visible = False
        '
        'btnCorrection
        '
        Me.btnCorrection.BackColor = System.Drawing.Color.Maroon
        Me.btnCorrection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCorrection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorrection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorrection.ForeColor = System.Drawing.Color.White
        Me.btnCorrection.Location = New System.Drawing.Point(192, 71)
        Me.btnCorrection.Name = "btnCorrection"
        Me.btnCorrection.Size = New System.Drawing.Size(80, 23)
        Me.btnCorrection.TabIndex = 304
        Me.btnCorrection.Text = "Reject"
        Me.btnCorrection.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.Green
        Me.btnApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(106, 71)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(80, 23)
        Me.btnApprove.TabIndex = 303
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(364, 71)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 23)
        Me.btnAdd.TabIndex = 297
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(450, 71)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 23)
        Me.btnEdit.TabIndex = 298
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(278, 71)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 23)
        Me.btnSubmit.TabIndex = 305
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(622, 71)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 23)
        Me.btnPrint.TabIndex = 301
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(708, 71)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(80, 23)
        Me.btnSettings.TabIndex = 302
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnComment
        '
        Me.btnComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComment.ForeColor = System.Drawing.Color.White
        Me.btnComment.Location = New System.Drawing.Point(278, 71)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(80, 23)
        Me.btnComment.TabIndex = 306
        Me.btnComment.Text = "Comment"
        Me.btnComment.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(622, 71)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 23)
        Me.btnSave.TabIndex = 299
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'hdr
        '
        Me.hdr.Controls.Add(Me.txtcurrency)
        Me.hdr.Controls.Add(Me.txtgeneral)
        Me.hdr.Controls.Add(Me.txtterms)
        Me.hdr.Controls.Add(Me.txtdesc)
        Me.hdr.Controls.Add(Me.txtamountwords)
        Me.hdr.Controls.Add(Me.txtamountbased)
        Me.hdr.Controls.Add(Me.txtamount)
        Me.hdr.Controls.Add(Me.txtyear)
        Me.hdr.Controls.Add(Me.txtday)
        Me.hdr.Controls.Add(Me.txtmonth)
        Me.hdr.Controls.Add(Me.txtcurrencyname)
        Me.hdr.Controls.Add(Me.txtpono)
        Me.hdr.Controls.Add(Me.txtgeneralname)
        Me.hdr.Controls.Add(Me.txtbasedrate)
        Me.hdr.Controls.Add(Me.txtnodays)
        Me.hdr.Controls.Add(Me.txtdrno)
        Me.hdr.Controls.Add(Me.txttransno)
        Me.hdr.Controls.Add(Me.txtexchangerate)
        Me.hdr.Controls.Add(Me.btnParticular)
        Me.hdr.Controls.Add(Me.txtduedate)
        Me.hdr.Controls.Add(Me.Label14)
        Me.hdr.Controls.Add(Me.Label27)
        Me.hdr.Controls.Add(Me.Label12)
        Me.hdr.Controls.Add(Me.Label13)
        Me.hdr.Controls.Add(Me.Label26)
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
        Me.hdr.Size = New System.Drawing.Size(771, 201)
        Me.hdr.TabIndex = 310
        '
        'txtcurrency
        '
        Me.txtcurrency.AlwaysDisable = False
        Me.txtcurrency.AlwaysEnable = False
        Me.txtcurrency.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcurrency.BrowseDataSource = "[currency]"
        Me.txtcurrency.BrowseField = "currency_code,currency_name"
        Me.txtcurrency.BrowseFilter = Nothing
        Me.txtcurrency.BrowseLabel = "Code,Name"
        Me.txtcurrency.BrowseLabelWidth = "100,200"
        Me.txtcurrency.BrowseTextSource = "currency_name"
        Me.txtcurrency.BrowseUpdate.Add(CType(resources.GetObject("txtcurrency.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txtcurrency.BrowseValueSource = "currency_id"
        Me.txtcurrency.Database = user_control.MyList.Database.FileSetup
        Me.txtcurrency.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrency.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcurrency.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtcurrency.Enabled = False
        Me.txtcurrency.EnabledBackColor = System.Drawing.Color.White
        Me.txtcurrency.EnabledForeColor = System.Drawing.Color.Black
        Me.txtcurrency.ForeColor = System.Drawing.Color.Black
        Me.txtcurrency.ID = False
        Me.txtcurrency.Location = New System.Drawing.Point(89, 65)
        Me.txtcurrency.Name = "txtcurrency"
        Me.txtcurrency.NoClear = False
        Me.txtcurrency.NumberFormat = "@"
        Me.txtcurrency.Required = False
        Me.txtcurrency.RowData = Nothing
        Me.txtcurrency.Size = New System.Drawing.Size(141, 20)
        Me.txtcurrency.TabIndex = 25
        Me.txtcurrency.TextBrowse = True
        Me.txtcurrency.TextSource = "currency_name"
        Me.txtcurrency.ToUpper = True
        Me.txtcurrency.Value = ""
        Me.txtcurrency.ValueSource = "currency_id"
        '
        'txtgeneral
        '
        Me.txtgeneral.AlwaysDisable = False
        Me.txtgeneral.AlwaysEnable = False
        Me.txtgeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgeneral.BrowseDataSource = "lib_erp_general"
        Me.txtgeneral.BrowseField = "general_code,general_name"
        Me.txtgeneral.BrowseFilter = Nothing
        Me.txtgeneral.BrowseLabel = "Code,Name"
        Me.txtgeneral.BrowseLabelWidth = "100,200"
        Me.txtgeneral.BrowseTextSource = "general_code"
        Me.txtgeneral.BrowseUpdate.Add(CType(resources.GetObject("txtgeneral.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txtgeneral.BrowseValueSource = "general_id"
        Me.txtgeneral.Database = user_control.MyList.Database.FileSetup
        Me.txtgeneral.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneral.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneral.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtgeneral.Enabled = False
        Me.txtgeneral.EnabledBackColor = System.Drawing.Color.White
        Me.txtgeneral.EnabledForeColor = System.Drawing.Color.Black
        Me.txtgeneral.ForeColor = System.Drawing.Color.Black
        Me.txtgeneral.ID = False
        Me.txtgeneral.Location = New System.Drawing.Point(89, 44)
        Me.txtgeneral.Name = "txtgeneral"
        Me.txtgeneral.NoClear = False
        Me.txtgeneral.NumberFormat = "@"
        Me.txtgeneral.Required = False
        Me.txtgeneral.RowData = Nothing
        Me.txtgeneral.Size = New System.Drawing.Size(141, 20)
        Me.txtgeneral.TabIndex = 23
        Me.txtgeneral.TextBrowse = True
        Me.txtgeneral.TextSource = "general_code"
        Me.txtgeneral.ToUpper = True
        Me.txtgeneral.Value = ""
        Me.txtgeneral.ValueSource = "general_id"
        '
        'txtterms
        '
        Me.txtterms.AlwaysDisable = False
        Me.txtterms.AlwaysEnable = False
        Me.txtterms.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtterms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtterms.BrowseDataSource = "[terms_payment]"
        Me.txtterms.BrowseField = "terms_code,terms_name"
        Me.txtterms.BrowseFilter = Nothing
        Me.txtterms.BrowseLabel = "Code,Name"
        Me.txtterms.BrowseLabelWidth = "100,200"
        Me.txtterms.BrowseTextSource = "terms_name"
        Me.txtterms.BrowseValueSource = "terms_id"
        Me.txtterms.Database = user_control.MyList.Database.FileSetup
        Me.txtterms.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtterms.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtterms.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtterms.Enabled = False
        Me.txtterms.EnabledBackColor = System.Drawing.Color.White
        Me.txtterms.EnabledForeColor = System.Drawing.Color.Black
        Me.txtterms.ForeColor = System.Drawing.Color.Black
        Me.txtterms.ID = False
        Me.txtterms.Location = New System.Drawing.Point(628, 23)
        Me.txtterms.Name = "txtterms"
        Me.txtterms.NoClear = False
        Me.txtterms.NumberFormat = "@"
        Me.txtterms.Required = False
        Me.txtterms.RowData = Nothing
        Me.txtterms.Size = New System.Drawing.Size(99, 20)
        Me.txtterms.TabIndex = 21
        Me.txtterms.TextBrowse = True
        Me.txtterms.TextSource = "terms_name"
        Me.txtterms.ToUpper = True
        Me.txtterms.Value = ""
        Me.txtterms.ValueSource = "terms_id"
        Me.txtterms.Visible = False
        '
        'txtdesc
        '
        Me.txtdesc.AlwaysDisable = False
        Me.txtdesc.AlwaysEnable = False
        Me.txtdesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesc.BrowseDataSource = ""
        Me.txtdesc.BrowseField = ""
        Me.txtdesc.BrowseFilter = Nothing
        Me.txtdesc.BrowseLabel = "Code,Name"
        Me.txtdesc.BrowseLabelWidth = "100,200"
        Me.txtdesc.BrowseTextSource = ""
        Me.txtdesc.BrowseValueSource = ""
        Me.txtdesc.Database = user_control.MyList.Database.FileSetup
        Me.txtdesc.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdesc.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdesc.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdesc.Enabled = False
        Me.txtdesc.EnabledBackColor = System.Drawing.Color.White
        Me.txtdesc.EnabledForeColor = System.Drawing.Color.Black
        Me.txtdesc.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtdesc.ID = False
        Me.txtdesc.Location = New System.Drawing.Point(90, 153)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.NoClear = False
        Me.txtdesc.NumberFormat = "@"
        Me.txtdesc.Required = False
        Me.txtdesc.RowData = Nothing
        Me.txtdesc.Size = New System.Drawing.Size(678, 45)
        Me.txtdesc.TabIndex = 32
        Me.txtdesc.TextBrowse = False
        Me.txtdesc.TextSource = "description"
        Me.txtdesc.ToUpper = True
        Me.txtdesc.Value = ""
        Me.txtdesc.ValueSource = ""
        '
        'txtamountwords
        '
        Me.txtamountwords.AlwaysDisable = True
        Me.txtamountwords.AlwaysEnable = False
        Me.txtamountwords.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtamountwords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamountwords.BrowseDataSource = ""
        Me.txtamountwords.BrowseField = ""
        Me.txtamountwords.BrowseFilter = Nothing
        Me.txtamountwords.BrowseLabel = "Code,Name"
        Me.txtamountwords.BrowseLabelWidth = "100,200"
        Me.txtamountwords.BrowseTextSource = ""
        Me.txtamountwords.BrowseValueSource = ""
        Me.txtamountwords.Database = user_control.MyList.Database.FileSetup
        Me.txtamountwords.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtamountwords.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtamountwords.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtamountwords.Enabled = False
        Me.txtamountwords.EnabledBackColor = System.Drawing.Color.White
        Me.txtamountwords.EnabledForeColor = System.Drawing.Color.Black
        Me.txtamountwords.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtamountwords.ID = False
        Me.txtamountwords.Location = New System.Drawing.Point(90, 107)
        Me.txtamountwords.Multiline = True
        Me.txtamountwords.Name = "txtamountwords"
        Me.txtamountwords.NoClear = False
        Me.txtamountwords.NumberFormat = "@"
        Me.txtamountwords.Required = False
        Me.txtamountwords.RowData = Nothing
        Me.txtamountwords.Size = New System.Drawing.Size(678, 45)
        Me.txtamountwords.TabIndex = 31
        Me.txtamountwords.TextBrowse = False
        Me.txtamountwords.TextSource = "amount_words"
        Me.txtamountwords.ToUpper = True
        Me.txtamountwords.Value = ""
        Me.txtamountwords.ValueSource = ""
        '
        'txtamountbased
        '
        Me.txtamountbased.AlwaysDisable = False
        Me.txtamountbased.AlwaysEnable = False
        Me.txtamountbased.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtamountbased.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamountbased.BrowseDataSource = ""
        Me.txtamountbased.BrowseField = ""
        Me.txtamountbased.BrowseFilter = Nothing
        Me.txtamountbased.BrowseLabel = "Code,Name"
        Me.txtamountbased.BrowseLabelWidth = "100,200"
        Me.txtamountbased.BrowseTextSource = ""
        Me.txtamountbased.BrowseValueSource = ""
        Me.txtamountbased.Database = user_control.MyList.Database.FileSetup
        Me.txtamountbased.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txtamountbased.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtamountbased.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtamountbased.Enabled = False
        Me.txtamountbased.EnabledBackColor = System.Drawing.Color.White
        Me.txtamountbased.EnabledForeColor = System.Drawing.Color.Black
        Me.txtamountbased.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtamountbased.ID = False
        Me.txtamountbased.Location = New System.Drawing.Point(628, 86)
        Me.txtamountbased.Name = "txtamountbased"
        Me.txtamountbased.NoClear = False
        Me.txtamountbased.NumberFormat = "##,##0.0000"
        Me.txtamountbased.Required = False
        Me.txtamountbased.RowData = Nothing
        Me.txtamountbased.Size = New System.Drawing.Size(140, 20)
        Me.txtamountbased.TabIndex = 30
        Me.txtamountbased.Text = "0.0000"
        Me.txtamountbased.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtamountbased.TextBrowse = False
        Me.txtamountbased.TextSource = ""
        Me.txtamountbased.ToUpper = True
        Me.txtamountbased.Value = "0.0000"
        Me.txtamountbased.ValueSource = "amount_based"
        '
        'txtamount
        '
        Me.txtamount.AlwaysDisable = True
        Me.txtamount.AlwaysEnable = False
        Me.txtamount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamount.BrowseDataSource = ""
        Me.txtamount.BrowseField = ""
        Me.txtamount.BrowseFilter = Nothing
        Me.txtamount.BrowseLabel = "Code,Name"
        Me.txtamount.BrowseLabelWidth = "100,200"
        Me.txtamount.BrowseTextSource = ""
        Me.txtamount.BrowseValueSource = ""
        Me.txtamount.Database = user_control.MyList.Database.FileSetup
        Me.txtamount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txtamount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtamount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtamount.Enabled = False
        Me.txtamount.EnabledBackColor = System.Drawing.Color.White
        Me.txtamount.EnabledForeColor = System.Drawing.Color.Black
        Me.txtamount.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtamount.ID = False
        Me.txtamount.Location = New System.Drawing.Point(89, 86)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.NoClear = False
        Me.txtamount.NumberFormat = "##,##0.0000"
        Me.txtamount.Required = False
        Me.txtamount.RowData = Nothing
        Me.txtamount.Size = New System.Drawing.Size(141, 20)
        Me.txtamount.TabIndex = 27
        Me.txtamount.Text = "0.0000"
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtamount.TextBrowse = False
        Me.txtamount.TextSource = ""
        Me.txtamount.ToUpper = True
        Me.txtamount.Value = "0.0000"
        Me.txtamount.ValueSource = "amount"
        '
        'txtyear
        '
        Me.txtyear.AlwaysDisable = True
        Me.txtyear.AlwaysEnable = False
        Me.txtyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtyear.BrowseDataSource = ""
        Me.txtyear.BrowseField = ""
        Me.txtyear.BrowseFilter = Nothing
        Me.txtyear.BrowseLabel = "Code,Name"
        Me.txtyear.BrowseLabelWidth = "100,200"
        Me.txtyear.BrowseTextSource = ""
        Me.txtyear.BrowseValueSource = ""
        Me.txtyear.Database = user_control.MyList.Database.FileSetup
        Me.txtyear.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtyear.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtyear.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtyear.Enabled = False
        Me.txtyear.EnabledBackColor = System.Drawing.Color.White
        Me.txtyear.EnabledForeColor = System.Drawing.Color.Black
        Me.txtyear.ForeColor = System.Drawing.Color.Black
        Me.txtyear.ID = False
        Me.txtyear.Location = New System.Drawing.Point(415, 2)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.NoClear = True
        Me.txtyear.NumberFormat = "@"
        Me.txtyear.Required = False
        Me.txtyear.RowData = Nothing
        Me.txtyear.Size = New System.Drawing.Size(40, 20)
        Me.txtyear.TabIndex = 17
        Me.txtyear.TextBrowse = False
        Me.txtyear.TextSource = "trans_date_year"
        Me.txtyear.ToUpper = True
        Me.txtyear.Value = ""
        Me.txtyear.ValueSource = ""
        '
        'txtday
        '
        Me.txtday.AlwaysDisable = False
        Me.txtday.AlwaysEnable = False
        Me.txtday.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtday.BrowseDataSource = ""
        Me.txtday.BrowseField = ""
        Me.txtday.BrowseFilter = Nothing
        Me.txtday.BrowseLabel = "Code,Name"
        Me.txtday.BrowseLabelWidth = "100,200"
        Me.txtday.BrowseTextSource = ""
        Me.txtday.BrowseValueSource = ""
        Me.txtday.Database = user_control.MyList.Database.FileSetup
        Me.txtday.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtday.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtday.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtday.Enabled = False
        Me.txtday.EnabledBackColor = System.Drawing.Color.White
        Me.txtday.EnabledForeColor = System.Drawing.Color.Black
        Me.txtday.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtday.ID = False
        Me.txtday.Location = New System.Drawing.Point(384, 2)
        Me.txtday.Name = "txtday"
        Me.txtday.NoClear = False
        Me.txtday.NumberFormat = "#0"
        Me.txtday.Required = False
        Me.txtday.RowData = Nothing
        Me.txtday.Size = New System.Drawing.Size(30, 20)
        Me.txtday.TabIndex = 16
        Me.txtday.Text = "0"
        Me.txtday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtday.TextBrowse = False
        Me.txtday.TextSource = "trans_date_day"
        Me.txtday.ToUpper = True
        Me.txtday.Value = ""
        Me.txtday.ValueSource = ""
        '
        'txtmonth
        '
        Me.txtmonth.AlwaysDisable = True
        Me.txtmonth.AlwaysEnable = False
        Me.txtmonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonth.BrowseDataSource = ""
        Me.txtmonth.BrowseField = ""
        Me.txtmonth.BrowseFilter = Nothing
        Me.txtmonth.BrowseLabel = "Code,Name"
        Me.txtmonth.BrowseLabelWidth = "100,200"
        Me.txtmonth.BrowseTextSource = ""
        Me.txtmonth.BrowseValueSource = ""
        Me.txtmonth.Database = user_control.MyList.Database.FileSetup
        Me.txtmonth.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmonth.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtmonth.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtmonth.Enabled = False
        Me.txtmonth.EnabledBackColor = System.Drawing.Color.White
        Me.txtmonth.EnabledForeColor = System.Drawing.Color.Black
        Me.txtmonth.ForeColor = System.Drawing.Color.Black
        Me.txtmonth.ID = False
        Me.txtmonth.Location = New System.Drawing.Point(315, 2)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.NoClear = True
        Me.txtmonth.NumberFormat = "@"
        Me.txtmonth.Required = False
        Me.txtmonth.RowData = Nothing
        Me.txtmonth.Size = New System.Drawing.Size(68, 20)
        Me.txtmonth.TabIndex = 15
        Me.txtmonth.TextBrowse = False
        Me.txtmonth.TextSource = "trans_date_month"
        Me.txtmonth.ToUpper = True
        Me.txtmonth.Value = ""
        Me.txtmonth.ValueSource = ""
        '
        'txtcurrencyname
        '
        Me.txtcurrencyname.AlwaysDisable = True
        Me.txtcurrencyname.AlwaysEnable = False
        Me.txtcurrencyname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcurrencyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcurrencyname.BrowseDataSource = ""
        Me.txtcurrencyname.BrowseField = ""
        Me.txtcurrencyname.BrowseFilter = Nothing
        Me.txtcurrencyname.BrowseLabel = "Code,Name"
        Me.txtcurrencyname.BrowseLabelWidth = "100,200"
        Me.txtcurrencyname.BrowseTextSource = ""
        Me.txtcurrencyname.BrowseValueSource = ""
        Me.txtcurrencyname.Database = user_control.MyList.Database.FileSetup
        Me.txtcurrencyname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrencyname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcurrencyname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtcurrencyname.Enabled = False
        Me.txtcurrencyname.EnabledBackColor = System.Drawing.Color.White
        Me.txtcurrencyname.EnabledForeColor = System.Drawing.Color.Black
        Me.txtcurrencyname.ForeColor = System.Drawing.Color.Black
        Me.txtcurrencyname.ID = False
        Me.txtcurrencyname.Location = New System.Drawing.Point(246, 65)
        Me.txtcurrencyname.Name = "txtcurrencyname"
        Me.txtcurrencyname.NoClear = False
        Me.txtcurrencyname.NumberFormat = "@"
        Me.txtcurrencyname.Required = False
        Me.txtcurrencyname.RowData = Nothing
        Me.txtcurrencyname.Size = New System.Drawing.Size(522, 20)
        Me.txtcurrencyname.TabIndex = 26
        Me.txtcurrencyname.TextBrowse = False
        Me.txtcurrencyname.TextSource = "currency_name"
        Me.txtcurrencyname.ToUpper = True
        Me.txtcurrencyname.Value = ""
        Me.txtcurrencyname.ValueSource = ""
        '
        'txtpono
        '
        Me.txtpono.AlwaysDisable = False
        Me.txtpono.AlwaysEnable = False
        Me.txtpono.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpono.BrowseDataSource = ""
        Me.txtpono.BrowseField = ""
        Me.txtpono.BrowseFilter = Nothing
        Me.txtpono.BrowseLabel = "Code,Name"
        Me.txtpono.BrowseLabelWidth = "100,200"
        Me.txtpono.BrowseTextSource = ""
        Me.txtpono.BrowseValueSource = ""
        Me.txtpono.Database = user_control.MyList.Database.FileSetup
        Me.txtpono.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpono.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpono.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtpono.Enabled = False
        Me.txtpono.EnabledBackColor = System.Drawing.Color.White
        Me.txtpono.EnabledForeColor = System.Drawing.Color.Black
        Me.txtpono.ForeColor = System.Drawing.Color.Black
        Me.txtpono.ID = False
        Me.txtpono.Location = New System.Drawing.Point(315, 23)
        Me.txtpono.Name = "txtpono"
        Me.txtpono.NoClear = False
        Me.txtpono.NumberFormat = "@"
        Me.txtpono.Required = False
        Me.txtpono.RowData = Nothing
        Me.txtpono.Size = New System.Drawing.Size(140, 20)
        Me.txtpono.TabIndex = 20
        Me.txtpono.TextBrowse = False
        Me.txtpono.TextSource = "po_no"
        Me.txtpono.ToUpper = True
        Me.txtpono.Value = ""
        Me.txtpono.ValueSource = ""
        '
        'txtgeneralname
        '
        Me.txtgeneralname.AlwaysDisable = True
        Me.txtgeneralname.AlwaysEnable = False
        Me.txtgeneralname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneralname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgeneralname.BrowseDataSource = ""
        Me.txtgeneralname.BrowseField = ""
        Me.txtgeneralname.BrowseFilter = Nothing
        Me.txtgeneralname.BrowseLabel = "Code,Name"
        Me.txtgeneralname.BrowseLabelWidth = "100,200"
        Me.txtgeneralname.BrowseTextSource = ""
        Me.txtgeneralname.BrowseValueSource = ""
        Me.txtgeneralname.Database = user_control.MyList.Database.FileSetup
        Me.txtgeneralname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneralname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneralname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtgeneralname.Enabled = False
        Me.txtgeneralname.EnabledBackColor = System.Drawing.Color.White
        Me.txtgeneralname.EnabledForeColor = System.Drawing.Color.Black
        Me.txtgeneralname.ForeColor = System.Drawing.Color.Black
        Me.txtgeneralname.ID = False
        Me.txtgeneralname.Location = New System.Drawing.Point(246, 44)
        Me.txtgeneralname.Name = "txtgeneralname"
        Me.txtgeneralname.NoClear = False
        Me.txtgeneralname.NumberFormat = "@"
        Me.txtgeneralname.Required = False
        Me.txtgeneralname.RowData = Nothing
        Me.txtgeneralname.Size = New System.Drawing.Size(522, 20)
        Me.txtgeneralname.TabIndex = 24
        Me.txtgeneralname.TextBrowse = False
        Me.txtgeneralname.TextSource = "general_name"
        Me.txtgeneralname.ToUpper = True
        Me.txtgeneralname.Value = ""
        Me.txtgeneralname.ValueSource = ""
        '
        'txtbasedrate
        '
        Me.txtbasedrate.AlwaysDisable = False
        Me.txtbasedrate.AlwaysEnable = False
        Me.txtbasedrate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtbasedrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbasedrate.BrowseDataSource = ""
        Me.txtbasedrate.BrowseField = ""
        Me.txtbasedrate.BrowseFilter = Nothing
        Me.txtbasedrate.BrowseLabel = "Code,Name"
        Me.txtbasedrate.BrowseLabelWidth = "100,200"
        Me.txtbasedrate.BrowseTextSource = ""
        Me.txtbasedrate.BrowseValueSource = ""
        Me.txtbasedrate.Database = user_control.MyList.Database.FileSetup
        Me.txtbasedrate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txtbasedrate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtbasedrate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtbasedrate.Enabled = False
        Me.txtbasedrate.EnabledBackColor = System.Drawing.Color.White
        Me.txtbasedrate.EnabledForeColor = System.Drawing.Color.Black
        Me.txtbasedrate.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtbasedrate.ID = False
        Me.txtbasedrate.Location = New System.Drawing.Point(454, 86)
        Me.txtbasedrate.Name = "txtbasedrate"
        Me.txtbasedrate.NoClear = False
        Me.txtbasedrate.NumberFormat = "##,##0.0000"
        Me.txtbasedrate.Required = False
        Me.txtbasedrate.RowData = Nothing
        Me.txtbasedrate.Size = New System.Drawing.Size(68, 20)
        Me.txtbasedrate.TabIndex = 29
        Me.txtbasedrate.Text = "0.0000"
        Me.txtbasedrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbasedrate.TextBrowse = False
        Me.txtbasedrate.TextSource = ""
        Me.txtbasedrate.ToUpper = True
        Me.txtbasedrate.Value = ""
        Me.txtbasedrate.ValueSource = "based_rate"
        '
        'txtnodays
        '
        Me.txtnodays.AlwaysDisable = False
        Me.txtnodays.AlwaysEnable = False
        Me.txtnodays.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnodays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnodays.BrowseDataSource = ""
        Me.txtnodays.BrowseField = ""
        Me.txtnodays.BrowseFilter = Nothing
        Me.txtnodays.BrowseLabel = "Code,Name"
        Me.txtnodays.BrowseLabelWidth = "100,200"
        Me.txtnodays.BrowseTextSource = ""
        Me.txtnodays.BrowseValueSource = ""
        Me.txtnodays.Database = user_control.MyList.Database.FileSetup
        Me.txtnodays.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnodays.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnodays.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtnodays.Enabled = False
        Me.txtnodays.EnabledBackColor = System.Drawing.Color.White
        Me.txtnodays.EnabledForeColor = System.Drawing.Color.Black
        Me.txtnodays.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtnodays.ID = False
        Me.txtnodays.Location = New System.Drawing.Point(728, 23)
        Me.txtnodays.Name = "txtnodays"
        Me.txtnodays.NoClear = False
        Me.txtnodays.NumberFormat = "##,##0"
        Me.txtnodays.Required = False
        Me.txtnodays.RowData = Nothing
        Me.txtnodays.Size = New System.Drawing.Size(40, 20)
        Me.txtnodays.TabIndex = 22
        Me.txtnodays.Text = "0"
        Me.txtnodays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnodays.TextBrowse = False
        Me.txtnodays.TextSource = ""
        Me.txtnodays.ToUpper = True
        Me.txtnodays.Value = "0"
        Me.txtnodays.ValueSource = "nodays"
        Me.txtnodays.Visible = False
        '
        'txtdrno
        '
        Me.txtdrno.AlwaysDisable = False
        Me.txtdrno.AlwaysEnable = False
        Me.txtdrno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdrno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdrno.BrowseDataSource = ""
        Me.txtdrno.BrowseField = ""
        Me.txtdrno.BrowseFilter = Nothing
        Me.txtdrno.BrowseLabel = "Code,Name"
        Me.txtdrno.BrowseLabelWidth = "100,200"
        Me.txtdrno.BrowseTextSource = ""
        Me.txtdrno.BrowseValueSource = ""
        Me.txtdrno.Database = user_control.MyList.Database.FileSetup
        Me.txtdrno.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdrno.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdrno.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdrno.Enabled = False
        Me.txtdrno.EnabledBackColor = System.Drawing.Color.White
        Me.txtdrno.EnabledForeColor = System.Drawing.Color.Black
        Me.txtdrno.ForeColor = System.Drawing.Color.Black
        Me.txtdrno.ID = False
        Me.txtdrno.Location = New System.Drawing.Point(89, 23)
        Me.txtdrno.Name = "txtdrno"
        Me.txtdrno.NoClear = False
        Me.txtdrno.NumberFormat = "@"
        Me.txtdrno.Required = False
        Me.txtdrno.RowData = Nothing
        Me.txtdrno.Size = New System.Drawing.Size(141, 20)
        Me.txtdrno.TabIndex = 19
        Me.txtdrno.TextBrowse = False
        Me.txtdrno.TextSource = "dr_no"
        Me.txtdrno.ToUpper = True
        Me.txtdrno.Value = ""
        Me.txtdrno.ValueSource = ""
        '
        'txttransno
        '
        Me.txttransno.AlwaysDisable = False
        Me.txttransno.AlwaysEnable = False
        Me.txttransno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttransno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttransno.BrowseDataSource = ""
        Me.txttransno.BrowseField = ""
        Me.txttransno.BrowseFilter = Nothing
        Me.txttransno.BrowseLabel = "Code,Name"
        Me.txttransno.BrowseLabelWidth = "100,200"
        Me.txttransno.BrowseTextSource = ""
        Me.txttransno.BrowseValueSource = ""
        Me.txttransno.Database = user_control.MyList.Database.FileSetup
        Me.txttransno.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttransno.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttransno.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txttransno.Enabled = False
        Me.txttransno.EnabledBackColor = System.Drawing.Color.White
        Me.txttransno.EnabledForeColor = System.Drawing.Color.Black
        Me.txttransno.ForeColor = System.Drawing.Color.Black
        Me.txttransno.ID = False
        Me.txttransno.Location = New System.Drawing.Point(89, 2)
        Me.txttransno.Name = "txttransno"
        Me.txttransno.NoClear = False
        Me.txttransno.NumberFormat = "@"
        Me.txttransno.Required = False
        Me.txttransno.RowData = Nothing
        Me.txttransno.Size = New System.Drawing.Size(141, 20)
        Me.txttransno.TabIndex = 14
        Me.txttransno.TextBrowse = False
        Me.txttransno.TextSource = "trans_no"
        Me.txttransno.ToUpper = True
        Me.txttransno.Value = ""
        Me.txttransno.ValueSource = ""
        '
        'txtexchangerate
        '
        Me.txtexchangerate.AlwaysDisable = False
        Me.txtexchangerate.AlwaysEnable = False
        Me.txtexchangerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtexchangerate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtexchangerate.BrowseDataSource = ""
        Me.txtexchangerate.BrowseField = ""
        Me.txtexchangerate.BrowseFilter = Nothing
        Me.txtexchangerate.BrowseLabel = "Code,Name"
        Me.txtexchangerate.BrowseLabelWidth = "100,200"
        Me.txtexchangerate.BrowseTextSource = ""
        Me.txtexchangerate.BrowseValueSource = ""
        Me.txtexchangerate.Database = user_control.MyList.Database.FileSetup
        Me.txtexchangerate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txtexchangerate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtexchangerate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtexchangerate.Enabled = False
        Me.txtexchangerate.EnabledBackColor = System.Drawing.Color.White
        Me.txtexchangerate.EnabledForeColor = System.Drawing.Color.Black
        Me.txtexchangerate.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtexchangerate.ID = False
        Me.txtexchangerate.Location = New System.Drawing.Point(315, 86)
        Me.txtexchangerate.Name = "txtexchangerate"
        Me.txtexchangerate.NoClear = False
        Me.txtexchangerate.NumberFormat = "##,##0.0000"
        Me.txtexchangerate.Required = False
        Me.txtexchangerate.RowData = Nothing
        Me.txtexchangerate.Size = New System.Drawing.Size(68, 20)
        Me.txtexchangerate.TabIndex = 28
        Me.txtexchangerate.Text = "0.0000"
        Me.txtexchangerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtexchangerate.TextBrowse = False
        Me.txtexchangerate.TextSource = ""
        Me.txtexchangerate.ToUpper = True
        Me.txtexchangerate.Value = ""
        Me.txtexchangerate.ValueSource = "exchange_rate"
        '
        'btnParticular
        '
        Me.btnParticular.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnParticular.Enabled = False
        Me.btnParticular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnParticular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnParticular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParticular.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParticular.ForeColor = System.Drawing.Color.White
        Me.btnParticular.Location = New System.Drawing.Point(89, 153)
        Me.btnParticular.Name = "btnParticular"
        Me.btnParticular.Size = New System.Drawing.Size(45, 45)
        Me.btnParticular.TabIndex = 314
        Me.btnParticular.Text = ". . ."
        Me.btnParticular.UseVisualStyleBackColor = False
        Me.btnParticular.Visible = False
        '
        'txtduedate
        '
        Me.txtduedate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtduedate.Location = New System.Drawing.Point(627, 2)
        Me.txtduedate.Name = "txtduedate"
        Me.txtduedate.Size = New System.Drawing.Size(141, 20)
        Me.txtduedate.TabIndex = 18
        Me.txtduedate.TextSource = "due_date"
        Me.txtduedate.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(74, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 16)
        Me.Label14.TabIndex = 185
        Me.Label14.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(574, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 13)
        Me.Label27.TabIndex = 184
        Me.Label27.Text = "Duedate"
        Me.Label27.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(592, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 183
        Me.Label12.Text = "Terms"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(266, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "P.O. No."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(2, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 13)
        Me.Label26.TabIndex = 180
        Me.Label26.Text = "D.R. No."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(230, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 174
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Particulars"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(2, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 31)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Amount in Words"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Currency"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(230, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 149
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Client Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Invoicing No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Ex. Rate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(550, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Based Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(389, 90)
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
        Me.btnInsert.Enabled = False
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(20, 300)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(100, 23)
        Me.btnInsert.TabIndex = 33
        Me.btnInsert.Text = "Insert Entry"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.Enabled = False
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(232, 300)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 23)
        Me.btnRemove.TabIndex = 35
        Me.btnRemove.Text = "Remove"
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
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(126, 300)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 23)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update Entry"
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
        Me.dgjbooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.deleted, Me.jbooks_id_tmp, Me.account_code, Me.account_name, Me.debit, Me.credit, Me.general_code, Me.general_name, Me.ref_trans_no, Me.dc})
        Me.dgjbooks.Location = New System.Drawing.Point(20, 323)
        Me.dgjbooks.MultiSelect = False
        Me.dgjbooks.Name = "dgjbooks"
        Me.dgjbooks.RowHeadersVisible = False
        Me.dgjbooks.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgjbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgjbooks.Size = New System.Drawing.Size(768, 130)
        Me.dgjbooks.TabIndex = 36
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.Width = 30
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
        'debit
        '
        Me.debit.DataPropertyName = "debit"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "##,##0.00"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle3
        Me.debit.HeaderText = "Debit"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        Me.debit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.debit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'credit
        '
        Me.credit.DataPropertyName = "credit"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "##,##0.00"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.credit.DefaultCellStyle = DataGridViewCellStyle4
        Me.credit.HeaderText = "Credit"
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        Me.credit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.credit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'det
        '
        Me.det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.det.Controls.Add(Me.txtjbooksidtmp)
        Me.det.Controls.Add(Me.txtdnrefbookcode)
        Me.det.Controls.Add(Me.txtdnrefjournalcode)
        Me.det.Controls.Add(Me.txtdnref)
        Me.det.Controls.Add(Me.txtgeneraldetname)
        Me.det.Controls.Add(Me.txtgeneraldet)
        Me.det.Controls.Add(Me.txtcreditbased)
        Me.det.Controls.Add(Me.txtdebitbased)
        Me.det.Controls.Add(Me.txtcredit)
        Me.det.Controls.Add(Me.txtdebit)
        Me.det.Controls.Add(Me.txttermsiddet)
        Me.det.Controls.Add(Me.txtnodaysdet)
        Me.det.Controls.Add(Me.txtallocation)
        Me.det.Controls.Add(Me.txtdepartment)
        Me.det.Controls.Add(Me.txtproject)
        Me.det.Controls.Add(Me.txtaccountname)
        Me.det.Controls.Add(Me.txt_based_rate)
        Me.det.Controls.Add(Me.txtaccount)
        Me.det.Controls.Add(Me.txt_currency_id)
        Me.det.Controls.Add(Me.txtlineremarks)
        Me.det.Controls.Add(Me.txt_exchange_rate)
        Me.det.Controls.Add(Me.lblLineRemarks)
        Me.det.Controls.Add(Me.lbltermsdet)
        Me.det.Controls.Add(Me.lblbasedrate)
        Me.det.Controls.Add(Me.lblexchangerate)
        Me.det.Controls.Add(Me.lblcurrency)
        Me.det.Controls.Add(Me.Label28)
        Me.det.Controls.Add(Me.Label29)
        Me.det.Controls.Add(Me.btnUndo)
        Me.det.Controls.Add(Me.btnOK)
        Me.det.Controls.Add(Me.Label25)
        Me.det.Controls.Add(Me.PictureBox4)
        Me.det.Controls.Add(Me.Label24)
        Me.det.Controls.Add(Me.Label23)
        Me.det.Controls.Add(Me.Label22)
        Me.det.Controls.Add(Me.PictureBox3)
        Me.det.Controls.Add(Me.lblAllocation)
        Me.det.Controls.Add(Me.Label20)
        Me.det.Controls.Add(Me.lblDepartment)
        Me.det.Controls.Add(Me.lblProject)
        Me.det.Location = New System.Drawing.Point(20, 469)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(768, 185)
        Me.det.TabIndex = 37
        '
        'txtjbooksidtmp
        '
        Me.txtjbooksidtmp.AlwaysDisable = False
        Me.txtjbooksidtmp.AlwaysEnable = False
        Me.txtjbooksidtmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtjbooksidtmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjbooksidtmp.BrowseDataSource = ""
        Me.txtjbooksidtmp.BrowseField = ""
        Me.txtjbooksidtmp.BrowseFilter = Nothing
        Me.txtjbooksidtmp.BrowseLabel = "Code,Name"
        Me.txtjbooksidtmp.BrowseLabelWidth = "100,200"
        Me.txtjbooksidtmp.BrowseTextSource = ""
        Me.txtjbooksidtmp.BrowseValueSource = ""
        Me.txtjbooksidtmp.Database = user_control.MyList.Database.FileSetup
        Me.txtjbooksidtmp.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjbooksidtmp.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtjbooksidtmp.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtjbooksidtmp.Enabled = False
        Me.txtjbooksidtmp.EnabledBackColor = System.Drawing.Color.White
        Me.txtjbooksidtmp.EnabledForeColor = System.Drawing.Color.Black
        Me.txtjbooksidtmp.ForeColor = System.Drawing.Color.Black
        Me.txtjbooksidtmp.ID = False
        Me.txtjbooksidtmp.Location = New System.Drawing.Point(394, 156)
        Me.txtjbooksidtmp.Name = "txtjbooksidtmp"
        Me.txtjbooksidtmp.NoClear = False
        Me.txtjbooksidtmp.NumberFormat = "@"
        Me.txtjbooksidtmp.Required = False
        Me.txtjbooksidtmp.RowData = Nothing
        Me.txtjbooksidtmp.Size = New System.Drawing.Size(92, 20)
        Me.txtjbooksidtmp.TabIndex = 58
        Me.txtjbooksidtmp.Tag = "adjustToTop"
        Me.txtjbooksidtmp.TextBrowse = False
        Me.txtjbooksidtmp.TextSource = "tmp_jbooks_id"
        Me.txtjbooksidtmp.ToUpper = True
        Me.txtjbooksidtmp.Value = ""
        Me.txtjbooksidtmp.ValueSource = ""
        Me.txtjbooksidtmp.Visible = False
        '
        'txtdnrefbookcode
        '
        Me.txtdnrefbookcode.AlwaysDisable = False
        Me.txtdnrefbookcode.AlwaysEnable = False
        Me.txtdnrefbookcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdnrefbookcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdnrefbookcode.BrowseDataSource = ""
        Me.txtdnrefbookcode.BrowseField = ""
        Me.txtdnrefbookcode.BrowseFilter = Nothing
        Me.txtdnrefbookcode.BrowseLabel = "Code,Name"
        Me.txtdnrefbookcode.BrowseLabelWidth = "100,200"
        Me.txtdnrefbookcode.BrowseTextSource = ""
        Me.txtdnrefbookcode.BrowseValueSource = ""
        Me.txtdnrefbookcode.Database = user_control.MyList.Database.FileSetup
        Me.txtdnrefbookcode.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdnrefbookcode.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdnrefbookcode.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdnrefbookcode.Enabled = False
        Me.txtdnrefbookcode.EnabledBackColor = System.Drawing.Color.White
        Me.txtdnrefbookcode.EnabledForeColor = System.Drawing.Color.Black
        Me.txtdnrefbookcode.ForeColor = System.Drawing.Color.Black
        Me.txtdnrefbookcode.ID = False
        Me.txtdnrefbookcode.Location = New System.Drawing.Point(291, 156)
        Me.txtdnrefbookcode.Name = "txtdnrefbookcode"
        Me.txtdnrefbookcode.NoClear = False
        Me.txtdnrefbookcode.NumberFormat = "@"
        Me.txtdnrefbookcode.Required = False
        Me.txtdnrefbookcode.RowData = Nothing
        Me.txtdnrefbookcode.Size = New System.Drawing.Size(40, 20)
        Me.txtdnrefbookcode.TabIndex = 57
        Me.txtdnrefbookcode.Tag = "adjustToTop"
        Me.txtdnrefbookcode.TextBrowse = False
        Me.txtdnrefbookcode.TextSource = "ref_book_code"
        Me.txtdnrefbookcode.ToUpper = True
        Me.txtdnrefbookcode.Value = ""
        Me.txtdnrefbookcode.ValueSource = ""
        Me.txtdnrefbookcode.Visible = False
        '
        'txtdnrefjournalcode
        '
        Me.txtdnrefjournalcode.AlwaysDisable = False
        Me.txtdnrefjournalcode.AlwaysEnable = False
        Me.txtdnrefjournalcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdnrefjournalcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdnrefjournalcode.BrowseDataSource = ""
        Me.txtdnrefjournalcode.BrowseField = ""
        Me.txtdnrefjournalcode.BrowseFilter = Nothing
        Me.txtdnrefjournalcode.BrowseLabel = "Code,Name"
        Me.txtdnrefjournalcode.BrowseLabelWidth = "100,200"
        Me.txtdnrefjournalcode.BrowseTextSource = ""
        Me.txtdnrefjournalcode.BrowseValueSource = ""
        Me.txtdnrefjournalcode.Database = user_control.MyList.Database.FileSetup
        Me.txtdnrefjournalcode.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdnrefjournalcode.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdnrefjournalcode.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdnrefjournalcode.Enabled = False
        Me.txtdnrefjournalcode.EnabledBackColor = System.Drawing.Color.White
        Me.txtdnrefjournalcode.EnabledForeColor = System.Drawing.Color.Black
        Me.txtdnrefjournalcode.ForeColor = System.Drawing.Color.Black
        Me.txtdnrefjournalcode.ID = False
        Me.txtdnrefjournalcode.Location = New System.Drawing.Point(245, 156)
        Me.txtdnrefjournalcode.Name = "txtdnrefjournalcode"
        Me.txtdnrefjournalcode.NoClear = False
        Me.txtdnrefjournalcode.NumberFormat = "@"
        Me.txtdnrefjournalcode.Required = False
        Me.txtdnrefjournalcode.RowData = Nothing
        Me.txtdnrefjournalcode.Size = New System.Drawing.Size(40, 20)
        Me.txtdnrefjournalcode.TabIndex = 56
        Me.txtdnrefjournalcode.Tag = "adjustToTop"
        Me.txtdnrefjournalcode.TextBrowse = False
        Me.txtdnrefjournalcode.TextSource = "ref_journal_code"
        Me.txtdnrefjournalcode.ToUpper = True
        Me.txtdnrefjournalcode.Value = ""
        Me.txtdnrefjournalcode.ValueSource = ""
        Me.txtdnrefjournalcode.Visible = False
        '
        'txtdnref
        '
        Me.txtdnref.AlwaysDisable = False
        Me.txtdnref.AlwaysEnable = False
        Me.txtdnref.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdnref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdnref.BrowseDataSource = ""
        Me.txtdnref.BrowseField = ""
        Me.txtdnref.BrowseFilter = Nothing
        Me.txtdnref.BrowseLabel = "Code,Name"
        Me.txtdnref.BrowseLabelWidth = "100,200"
        Me.txtdnref.BrowseTextSource = ""
        Me.txtdnref.BrowseValueSource = ""
        Me.txtdnref.Database = user_control.MyList.Database.FileSetup
        Me.txtdnref.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdnref.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdnref.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdnref.Enabled = False
        Me.txtdnref.EnabledBackColor = System.Drawing.Color.White
        Me.txtdnref.EnabledForeColor = System.Drawing.Color.Black
        Me.txtdnref.ForeColor = System.Drawing.Color.Black
        Me.txtdnref.ID = False
        Me.txtdnref.Location = New System.Drawing.Point(88, 156)
        Me.txtdnref.Name = "txtdnref"
        Me.txtdnref.NoClear = False
        Me.txtdnref.NumberFormat = "@"
        Me.txtdnref.Required = False
        Me.txtdnref.RowData = Nothing
        Me.txtdnref.Size = New System.Drawing.Size(141, 20)
        Me.txtdnref.TabIndex = 55
        Me.txtdnref.Tag = "adjustToTop"
        Me.txtdnref.TextBrowse = False
        Me.txtdnref.TextSource = "ref_trans_no"
        Me.txtdnref.ToUpper = True
        Me.txtdnref.Value = ""
        Me.txtdnref.ValueSource = "ref_jbooks_id"
        '
        'txtgeneraldetname
        '
        Me.txtgeneraldetname.AlwaysDisable = True
        Me.txtgeneraldetname.AlwaysEnable = False
        Me.txtgeneraldetname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneraldetname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgeneraldetname.BrowseDataSource = ""
        Me.txtgeneraldetname.BrowseField = ""
        Me.txtgeneraldetname.BrowseFilter = Nothing
        Me.txtgeneraldetname.BrowseLabel = "Code,Name"
        Me.txtgeneraldetname.BrowseLabelWidth = "100,200"
        Me.txtgeneraldetname.BrowseTextSource = ""
        Me.txtgeneraldetname.BrowseValueSource = ""
        Me.txtgeneraldetname.Database = user_control.MyList.Database.FileSetup
        Me.txtgeneraldetname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneraldetname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneraldetname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtgeneraldetname.Enabled = False
        Me.txtgeneraldetname.EnabledBackColor = System.Drawing.Color.White
        Me.txtgeneraldetname.EnabledForeColor = System.Drawing.Color.Black
        Me.txtgeneraldetname.ForeColor = System.Drawing.Color.Black
        Me.txtgeneraldetname.ID = False
        Me.txtgeneraldetname.Location = New System.Drawing.Point(245, 135)
        Me.txtgeneraldetname.Name = "txtgeneraldetname"
        Me.txtgeneraldetname.NoClear = False
        Me.txtgeneraldetname.NumberFormat = "@"
        Me.txtgeneraldetname.Required = False
        Me.txtgeneraldetname.RowData = Nothing
        Me.txtgeneraldetname.Size = New System.Drawing.Size(519, 20)
        Me.txtgeneraldetname.TabIndex = 54
        Me.txtgeneraldetname.Tag = "adjustToTop"
        Me.txtgeneraldetname.TextBrowse = False
        Me.txtgeneraldetname.TextSource = "general_name"
        Me.txtgeneraldetname.ToUpper = True
        Me.txtgeneraldetname.Value = ""
        Me.txtgeneraldetname.ValueSource = ""
        '
        'txtgeneraldet
        '
        Me.txtgeneraldet.AlwaysDisable = False
        Me.txtgeneraldet.AlwaysEnable = False
        Me.txtgeneraldet.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneraldet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgeneraldet.BrowseDataSource = "lib_erp_general"
        Me.txtgeneraldet.BrowseField = "general_code,general_name"
        Me.txtgeneraldet.BrowseFilter = Nothing
        Me.txtgeneraldet.BrowseLabel = "Code,Name"
        Me.txtgeneraldet.BrowseLabelWidth = "100,200"
        Me.txtgeneraldet.BrowseTextSource = "general_code"
        Me.txtgeneraldet.BrowseUpdate.Add(CType(resources.GetObject("txtgeneraldet.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txtgeneraldet.BrowseValueSource = "general_id"
        Me.txtgeneraldet.Database = user_control.MyList.Database.FileSetup
        Me.txtgeneraldet.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtgeneraldet.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgeneraldet.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtgeneraldet.Enabled = False
        Me.txtgeneraldet.EnabledBackColor = System.Drawing.Color.White
        Me.txtgeneraldet.EnabledForeColor = System.Drawing.Color.Black
        Me.txtgeneraldet.ForeColor = System.Drawing.Color.Black
        Me.txtgeneraldet.ID = False
        Me.txtgeneraldet.Location = New System.Drawing.Point(88, 135)
        Me.txtgeneraldet.Name = "txtgeneraldet"
        Me.txtgeneraldet.NoClear = False
        Me.txtgeneraldet.NumberFormat = "@"
        Me.txtgeneraldet.Required = False
        Me.txtgeneraldet.RowData = Nothing
        Me.txtgeneraldet.Size = New System.Drawing.Size(141, 20)
        Me.txtgeneraldet.TabIndex = 53
        Me.txtgeneraldet.Tag = "adjustToTop"
        Me.txtgeneraldet.TextBrowse = True
        Me.txtgeneraldet.TextSource = "general_code"
        Me.txtgeneraldet.ToUpper = True
        Me.txtgeneraldet.Value = ""
        Me.txtgeneraldet.ValueSource = "general_id"
        '
        'txtcreditbased
        '
        Me.txtcreditbased.AlwaysDisable = False
        Me.txtcreditbased.AlwaysEnable = False
        Me.txtcreditbased.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcreditbased.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcreditbased.BrowseDataSource = ""
        Me.txtcreditbased.BrowseField = ""
        Me.txtcreditbased.BrowseFilter = Nothing
        Me.txtcreditbased.BrowseLabel = "Code,Name"
        Me.txtcreditbased.BrowseLabelWidth = "100,200"
        Me.txtcreditbased.BrowseTextSource = ""
        Me.txtcreditbased.BrowseValueSource = ""
        Me.txtcreditbased.Database = user_control.MyList.Database.FileSetup
        Me.txtcreditbased.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txtcreditbased.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcreditbased.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtcreditbased.Enabled = False
        Me.txtcreditbased.EnabledBackColor = System.Drawing.Color.White
        Me.txtcreditbased.EnabledForeColor = System.Drawing.Color.Black
        Me.txtcreditbased.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtcreditbased.ID = False
        Me.txtcreditbased.Location = New System.Drawing.Point(357, 114)
        Me.txtcreditbased.Name = "txtcreditbased"
        Me.txtcreditbased.NoClear = False
        Me.txtcreditbased.NumberFormat = "##,##0.0000"
        Me.txtcreditbased.Required = False
        Me.txtcreditbased.RowData = Nothing
        Me.txtcreditbased.Size = New System.Drawing.Size(139, 20)
        Me.txtcreditbased.TabIndex = 50
        Me.txtcreditbased.Tag = "adjustToTop"
        Me.txtcreditbased.Text = "0.0000"
        Me.txtcreditbased.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcreditbased.TextBrowse = False
        Me.txtcreditbased.TextSource = ""
        Me.txtcreditbased.ToUpper = True
        Me.txtcreditbased.Value = ""
        Me.txtcreditbased.ValueSource = "credit_based"
        '
        'txtdebitbased
        '
        Me.txtdebitbased.AlwaysDisable = False
        Me.txtdebitbased.AlwaysEnable = False
        Me.txtdebitbased.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdebitbased.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdebitbased.BrowseDataSource = ""
        Me.txtdebitbased.BrowseField = ""
        Me.txtdebitbased.BrowseFilter = Nothing
        Me.txtdebitbased.BrowseLabel = "Code,Name"
        Me.txtdebitbased.BrowseLabelWidth = "100,200"
        Me.txtdebitbased.BrowseTextSource = ""
        Me.txtdebitbased.BrowseValueSource = ""
        Me.txtdebitbased.Database = user_control.MyList.Database.FileSetup
        Me.txtdebitbased.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txtdebitbased.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdebitbased.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdebitbased.Enabled = False
        Me.txtdebitbased.EnabledBackColor = System.Drawing.Color.White
        Me.txtdebitbased.EnabledForeColor = System.Drawing.Color.Black
        Me.txtdebitbased.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtdebitbased.ID = False
        Me.txtdebitbased.Location = New System.Drawing.Point(357, 93)
        Me.txtdebitbased.Name = "txtdebitbased"
        Me.txtdebitbased.NoClear = False
        Me.txtdebitbased.NumberFormat = "##,##0.0000"
        Me.txtdebitbased.Required = False
        Me.txtdebitbased.RowData = Nothing
        Me.txtdebitbased.Size = New System.Drawing.Size(139, 20)
        Me.txtdebitbased.TabIndex = 48
        Me.txtdebitbased.Tag = "adjustToTop"
        Me.txtdebitbased.Text = "0.0000"
        Me.txtdebitbased.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtdebitbased.TextBrowse = False
        Me.txtdebitbased.TextSource = ""
        Me.txtdebitbased.ToUpper = True
        Me.txtdebitbased.Value = ""
        Me.txtdebitbased.ValueSource = "debit_based"
        '
        'txtcredit
        '
        Me.txtcredit.AlwaysDisable = False
        Me.txtcredit.AlwaysEnable = False
        Me.txtcredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcredit.BrowseDataSource = ""
        Me.txtcredit.BrowseField = ""
        Me.txtcredit.BrowseFilter = Nothing
        Me.txtcredit.BrowseLabel = "Code,Name"
        Me.txtcredit.BrowseLabelWidth = "100,200"
        Me.txtcredit.BrowseTextSource = ""
        Me.txtcredit.BrowseValueSource = ""
        Me.txtcredit.Database = user_control.MyList.Database.FileSetup
        Me.txtcredit.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txtcredit.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcredit.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtcredit.Enabled = False
        Me.txtcredit.EnabledBackColor = System.Drawing.Color.White
        Me.txtcredit.EnabledForeColor = System.Drawing.Color.Black
        Me.txtcredit.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtcredit.ID = False
        Me.txtcredit.Location = New System.Drawing.Point(88, 114)
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.NoClear = False
        Me.txtcredit.NumberFormat = "##,##0.0000"
        Me.txtcredit.Required = False
        Me.txtcredit.RowData = Nothing
        Me.txtcredit.Size = New System.Drawing.Size(141, 20)
        Me.txtcredit.TabIndex = 49
        Me.txtcredit.Tag = "adjustToTop"
        Me.txtcredit.Text = "0.0000"
        Me.txtcredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcredit.TextBrowse = False
        Me.txtcredit.TextSource = ""
        Me.txtcredit.ToUpper = True
        Me.txtcredit.Value = ""
        Me.txtcredit.ValueSource = "credit"
        '
        'txtdebit
        '
        Me.txtdebit.AlwaysDisable = False
        Me.txtdebit.AlwaysEnable = False
        Me.txtdebit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdebit.BrowseDataSource = ""
        Me.txtdebit.BrowseField = ""
        Me.txtdebit.BrowseFilter = Nothing
        Me.txtdebit.BrowseLabel = "Code,Name"
        Me.txtdebit.BrowseLabelWidth = "100,200"
        Me.txtdebit.BrowseTextSource = ""
        Me.txtdebit.BrowseValueSource = ""
        Me.txtdebit.Database = user_control.MyList.Database.FileSetup
        Me.txtdebit.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txtdebit.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdebit.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdebit.Enabled = False
        Me.txtdebit.EnabledBackColor = System.Drawing.Color.White
        Me.txtdebit.EnabledForeColor = System.Drawing.Color.Black
        Me.txtdebit.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtdebit.ID = False
        Me.txtdebit.Location = New System.Drawing.Point(88, 93)
        Me.txtdebit.Name = "txtdebit"
        Me.txtdebit.NoClear = False
        Me.txtdebit.NumberFormat = "##,##0.0000"
        Me.txtdebit.Required = False
        Me.txtdebit.RowData = Nothing
        Me.txtdebit.Size = New System.Drawing.Size(141, 20)
        Me.txtdebit.TabIndex = 47
        Me.txtdebit.Tag = "adjustToTop"
        Me.txtdebit.Text = "0.0000"
        Me.txtdebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtdebit.TextBrowse = False
        Me.txtdebit.TextSource = ""
        Me.txtdebit.ToUpper = True
        Me.txtdebit.Value = ""
        Me.txtdebit.ValueSource = "debit"
        '
        'txttermsiddet
        '
        Me.txttermsiddet.AlwaysDisable = False
        Me.txttermsiddet.AlwaysEnable = False
        Me.txttermsiddet.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttermsiddet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttermsiddet.BrowseDataSource = "[terms_payment]"
        Me.txttermsiddet.BrowseField = "terms_code,terms_name"
        Me.txttermsiddet.BrowseFilter = Nothing
        Me.txttermsiddet.BrowseLabel = "Code,Name"
        Me.txttermsiddet.BrowseLabelWidth = "100,200"
        Me.txttermsiddet.BrowseTextSource = "terms_name"
        Me.txttermsiddet.BrowseValueSource = "terms_id"
        Me.txttermsiddet.Database = user_control.MyList.Database.FileSetup
        Me.txttermsiddet.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttermsiddet.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttermsiddet.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txttermsiddet.Enabled = False
        Me.txttermsiddet.EnabledBackColor = System.Drawing.Color.White
        Me.txttermsiddet.EnabledForeColor = System.Drawing.Color.Black
        Me.txttermsiddet.ForeColor = System.Drawing.Color.Black
        Me.txttermsiddet.ID = False
        Me.txttermsiddet.Location = New System.Drawing.Point(623, 114)
        Me.txttermsiddet.Name = "txttermsiddet"
        Me.txttermsiddet.NoClear = False
        Me.txttermsiddet.NumberFormat = "@"
        Me.txttermsiddet.Required = False
        Me.txttermsiddet.RowData = Nothing
        Me.txttermsiddet.Size = New System.Drawing.Size(99, 20)
        Me.txttermsiddet.TabIndex = 51
        Me.txttermsiddet.Tag = "adjustToTop"
        Me.txttermsiddet.TextBrowse = True
        Me.txttermsiddet.TextSource = "terms_name"
        Me.txttermsiddet.ToUpper = True
        Me.txttermsiddet.Value = ""
        Me.txttermsiddet.ValueSource = "terms_id"
        '
        'txtnodaysdet
        '
        Me.txtnodaysdet.AlwaysDisable = False
        Me.txtnodaysdet.AlwaysEnable = False
        Me.txtnodaysdet.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnodaysdet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnodaysdet.BrowseDataSource = ""
        Me.txtnodaysdet.BrowseField = ""
        Me.txtnodaysdet.BrowseFilter = Nothing
        Me.txtnodaysdet.BrowseLabel = "Code,Name"
        Me.txtnodaysdet.BrowseLabelWidth = "100,200"
        Me.txtnodaysdet.BrowseTextSource = ""
        Me.txtnodaysdet.BrowseValueSource = ""
        Me.txtnodaysdet.Database = user_control.MyList.Database.FileSetup
        Me.txtnodaysdet.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnodaysdet.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnodaysdet.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtnodaysdet.Enabled = False
        Me.txtnodaysdet.EnabledBackColor = System.Drawing.Color.White
        Me.txtnodaysdet.EnabledForeColor = System.Drawing.Color.Black
        Me.txtnodaysdet.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtnodaysdet.ID = False
        Me.txtnodaysdet.Location = New System.Drawing.Point(723, 114)
        Me.txtnodaysdet.Name = "txtnodaysdet"
        Me.txtnodaysdet.NoClear = False
        Me.txtnodaysdet.NumberFormat = "##,##0"
        Me.txtnodaysdet.Required = False
        Me.txtnodaysdet.RowData = Nothing
        Me.txtnodaysdet.Size = New System.Drawing.Size(40, 20)
        Me.txtnodaysdet.TabIndex = 52
        Me.txtnodaysdet.Tag = "adjustToTop"
        Me.txtnodaysdet.Text = "0"
        Me.txtnodaysdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnodaysdet.TextBrowse = False
        Me.txtnodaysdet.TextSource = ""
        Me.txtnodaysdet.ToUpper = True
        Me.txtnodaysdet.Value = "0"
        Me.txtnodaysdet.ValueSource = "nodays"
        Me.txtnodaysdet.Visible = False
        '
        'txtallocation
        '
        Me.txtallocation.AlwaysDisable = False
        Me.txtallocation.AlwaysEnable = False
        Me.txtallocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtallocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtallocation.BrowseDataSource = "lib_erp_allocation"
        Me.txtallocation.BrowseField = "allocation_code,allocation_name"
        Me.txtallocation.BrowseFilter = Nothing
        Me.txtallocation.BrowseLabel = "Code,Name"
        Me.txtallocation.BrowseLabelWidth = "100,200"
        Me.txtallocation.BrowseTextSource = "allocation_name"
        Me.txtallocation.BrowseValueSource = "allocation_id"
        Me.txtallocation.Database = user_control.MyList.Database.FileSetup
        Me.txtallocation.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtallocation.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtallocation.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtallocation.Enabled = False
        Me.txtallocation.EnabledBackColor = System.Drawing.Color.White
        Me.txtallocation.EnabledForeColor = System.Drawing.Color.Black
        Me.txtallocation.ForeColor = System.Drawing.Color.Black
        Me.txtallocation.ID = False
        Me.txtallocation.Location = New System.Drawing.Point(623, 72)
        Me.txtallocation.Name = "txtallocation"
        Me.txtallocation.NoClear = False
        Me.txtallocation.NumberFormat = "@"
        Me.txtallocation.Required = False
        Me.txtallocation.RowData = Nothing
        Me.txtallocation.Size = New System.Drawing.Size(141, 20)
        Me.txtallocation.TabIndex = 46
        Me.txtallocation.TextBrowse = True
        Me.txtallocation.TextSource = "allocation_name"
        Me.txtallocation.ToUpper = True
        Me.txtallocation.Value = ""
        Me.txtallocation.ValueSource = "allocation_id"
        '
        'txtdepartment
        '
        Me.txtdepartment.AlwaysDisable = False
        Me.txtdepartment.AlwaysEnable = False
        Me.txtdepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdepartment.BrowseDataSource = "lib_erp_department"
        Me.txtdepartment.BrowseField = "department_code,department_name"
        Me.txtdepartment.BrowseFilter = Nothing
        Me.txtdepartment.BrowseLabel = "Code,Name"
        Me.txtdepartment.BrowseLabelWidth = "100,200"
        Me.txtdepartment.BrowseTextSource = "department_name"
        Me.txtdepartment.BrowseValueSource = "department_id"
        Me.txtdepartment.Database = user_control.MyList.Database.FileSetup
        Me.txtdepartment.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdepartment.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdepartment.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdepartment.Enabled = False
        Me.txtdepartment.EnabledBackColor = System.Drawing.Color.White
        Me.txtdepartment.EnabledForeColor = System.Drawing.Color.Black
        Me.txtdepartment.ForeColor = System.Drawing.Color.Black
        Me.txtdepartment.ID = False
        Me.txtdepartment.Location = New System.Drawing.Point(357, 72)
        Me.txtdepartment.Name = "txtdepartment"
        Me.txtdepartment.NoClear = False
        Me.txtdepartment.NumberFormat = "@"
        Me.txtdepartment.Required = False
        Me.txtdepartment.RowData = Nothing
        Me.txtdepartment.Size = New System.Drawing.Size(139, 20)
        Me.txtdepartment.TabIndex = 45
        Me.txtdepartment.TextBrowse = True
        Me.txtdepartment.TextSource = "department_name"
        Me.txtdepartment.ToUpper = True
        Me.txtdepartment.Value = ""
        Me.txtdepartment.ValueSource = "department_id"
        '
        'txtproject
        '
        Me.txtproject.AlwaysDisable = False
        Me.txtproject.AlwaysEnable = False
        Me.txtproject.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtproject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproject.BrowseDataSource = "lib_erp_project"
        Me.txtproject.BrowseField = "project_code,project_name"
        Me.txtproject.BrowseFilter = Nothing
        Me.txtproject.BrowseLabel = "Code,Name"
        Me.txtproject.BrowseLabelWidth = "100,200"
        Me.txtproject.BrowseTextSource = "project_name"
        Me.txtproject.BrowseValueSource = "project_id"
        Me.txtproject.Database = user_control.MyList.Database.FileSetup
        Me.txtproject.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtproject.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtproject.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtproject.Enabled = False
        Me.txtproject.EnabledBackColor = System.Drawing.Color.White
        Me.txtproject.EnabledForeColor = System.Drawing.Color.Black
        Me.txtproject.ForeColor = System.Drawing.Color.Black
        Me.txtproject.ID = False
        Me.txtproject.Location = New System.Drawing.Point(88, 72)
        Me.txtproject.Name = "txtproject"
        Me.txtproject.NoClear = False
        Me.txtproject.NumberFormat = "@"
        Me.txtproject.Required = False
        Me.txtproject.RowData = Nothing
        Me.txtproject.Size = New System.Drawing.Size(141, 20)
        Me.txtproject.TabIndex = 44
        Me.txtproject.TextBrowse = True
        Me.txtproject.TextSource = "project_name"
        Me.txtproject.ToUpper = True
        Me.txtproject.Value = ""
        Me.txtproject.ValueSource = "project_id"
        '
        'txtaccountname
        '
        Me.txtaccountname.AlwaysDisable = True
        Me.txtaccountname.AlwaysEnable = False
        Me.txtaccountname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaccountname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaccountname.BrowseDataSource = ""
        Me.txtaccountname.BrowseField = ""
        Me.txtaccountname.BrowseFilter = Nothing
        Me.txtaccountname.BrowseLabel = "Code,Name"
        Me.txtaccountname.BrowseLabelWidth = "100,200"
        Me.txtaccountname.BrowseTextSource = ""
        Me.txtaccountname.BrowseValueSource = ""
        Me.txtaccountname.Database = user_control.MyList.Database.FileSetup
        Me.txtaccountname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtaccountname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaccountname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtaccountname.Enabled = False
        Me.txtaccountname.EnabledBackColor = System.Drawing.Color.White
        Me.txtaccountname.EnabledForeColor = System.Drawing.Color.Black
        Me.txtaccountname.ForeColor = System.Drawing.Color.Black
        Me.txtaccountname.ID = False
        Me.txtaccountname.Location = New System.Drawing.Point(245, 51)
        Me.txtaccountname.Name = "txtaccountname"
        Me.txtaccountname.NoClear = False
        Me.txtaccountname.NumberFormat = "@"
        Me.txtaccountname.Required = False
        Me.txtaccountname.RowData = Nothing
        Me.txtaccountname.Size = New System.Drawing.Size(519, 20)
        Me.txtaccountname.TabIndex = 43
        Me.txtaccountname.TextBrowse = False
        Me.txtaccountname.TextSource = "account_name"
        Me.txtaccountname.ToUpper = True
        Me.txtaccountname.Value = ""
        Me.txtaccountname.ValueSource = ""
        '
        'txt_based_rate
        '
        Me.txt_based_rate.AlwaysDisable = False
        Me.txt_based_rate.AlwaysEnable = False
        Me.txt_based_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_based_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_based_rate.BrowseDataSource = ""
        Me.txt_based_rate.BrowseField = ""
        Me.txt_based_rate.BrowseFilter = Nothing
        Me.txt_based_rate.BrowseLabel = "Code,Name"
        Me.txt_based_rate.BrowseLabelWidth = "100,200"
        Me.txt_based_rate.BrowseTextSource = ""
        Me.txt_based_rate.BrowseValueSource = ""
        Me.txt_based_rate.Database = user_control.MyList.Database.FileSetup
        Me.txt_based_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txt_based_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_based_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_based_rate.Enabled = False
        Me.txt_based_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_based_rate.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_based_rate.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_based_rate.ID = False
        Me.txt_based_rate.Location = New System.Drawing.Point(623, 30)
        Me.txt_based_rate.Name = "txt_based_rate"
        Me.txt_based_rate.NoClear = False
        Me.txt_based_rate.NumberFormat = "##,##0.0000"
        Me.txt_based_rate.Required = False
        Me.txt_based_rate.RowData = Nothing
        Me.txt_based_rate.Size = New System.Drawing.Size(141, 20)
        Me.txt_based_rate.TabIndex = 41
        Me.txt_based_rate.Text = "0.0000"
        Me.txt_based_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_based_rate.TextBrowse = False
        Me.txt_based_rate.TextSource = ""
        Me.txt_based_rate.ToUpper = True
        Me.txt_based_rate.Value = ""
        Me.txt_based_rate.ValueSource = "based_rate"
        '
        'txtaccount
        '
        Me.txtaccount.AlwaysDisable = False
        Me.txtaccount.AlwaysEnable = False
        Me.txtaccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaccount.BrowseDataSource = "lib_erp_chart"
        Me.txtaccount.BrowseField = "account_code,account_name"
        Me.txtaccount.BrowseFilter = Nothing
        Me.txtaccount.BrowseLabel = "Code,Name"
        Me.txtaccount.BrowseLabelWidth = "100,200"
        Me.txtaccount.BrowseTextSource = "account_code"
        Me.txtaccount.BrowseUpdate.Add(CType(resources.GetObject("txtaccount.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txtaccount.BrowseValueSource = "account_id"
        Me.txtaccount.Database = user_control.MyList.Database.FileSetup
        Me.txtaccount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtaccount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaccount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtaccount.Enabled = False
        Me.txtaccount.EnabledBackColor = System.Drawing.Color.White
        Me.txtaccount.EnabledForeColor = System.Drawing.Color.Black
        Me.txtaccount.ForeColor = System.Drawing.Color.Black
        Me.txtaccount.ID = False
        Me.txtaccount.Location = New System.Drawing.Point(88, 51)
        Me.txtaccount.Name = "txtaccount"
        Me.txtaccount.NoClear = False
        Me.txtaccount.NumberFormat = "@"
        Me.txtaccount.Required = False
        Me.txtaccount.RowData = Nothing
        Me.txtaccount.Size = New System.Drawing.Size(141, 20)
        Me.txtaccount.TabIndex = 42
        Me.txtaccount.TextBrowse = True
        Me.txtaccount.TextSource = "account_code"
        Me.txtaccount.ToUpper = True
        Me.txtaccount.Value = ""
        Me.txtaccount.ValueSource = "account_id"
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
        Me.txt_currency_id.BrowseTextSource = "currency_name"
        Me.txt_currency_id.BrowseValueSource = "currency_id"
        Me.txt_currency_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.Enabled = False
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_currency_id.ForeColor = System.Drawing.Color.Black
        Me.txt_currency_id.ID = False
        Me.txt_currency_id.Location = New System.Drawing.Point(88, 30)
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.Size = New System.Drawing.Size(141, 20)
        Me.txt_currency_id.TabIndex = 39
        Me.txt_currency_id.TextBrowse = True
        Me.txt_currency_id.TextSource = "currency_name"
        Me.txt_currency_id.ToUpper = True
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = "currency_id"
        '
        'txtlineremarks
        '
        Me.txtlineremarks.AlwaysDisable = False
        Me.txtlineremarks.AlwaysEnable = False
        Me.txtlineremarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtlineremarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlineremarks.BrowseDataSource = ""
        Me.txtlineremarks.BrowseField = ""
        Me.txtlineremarks.BrowseFilter = Nothing
        Me.txtlineremarks.BrowseLabel = "Code,Name"
        Me.txtlineremarks.BrowseLabelWidth = "100,200"
        Me.txtlineremarks.BrowseTextSource = ""
        Me.txtlineremarks.BrowseValueSource = ""
        Me.txtlineremarks.Database = user_control.MyList.Database.FileSetup
        Me.txtlineremarks.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlineremarks.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtlineremarks.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtlineremarks.Enabled = False
        Me.txtlineremarks.EnabledBackColor = System.Drawing.Color.White
        Me.txtlineremarks.EnabledForeColor = System.Drawing.Color.Black
        Me.txtlineremarks.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtlineremarks.ID = False
        Me.txtlineremarks.Location = New System.Drawing.Point(88, 9)
        Me.txtlineremarks.Name = "txtlineremarks"
        Me.txtlineremarks.NoClear = False
        Me.txtlineremarks.NumberFormat = "@"
        Me.txtlineremarks.Required = False
        Me.txtlineremarks.RowData = Nothing
        Me.txtlineremarks.Size = New System.Drawing.Size(676, 20)
        Me.txtlineremarks.TabIndex = 38
        Me.txtlineremarks.TextBrowse = False
        Me.txtlineremarks.TextSource = "line_remarks"
        Me.txtlineremarks.ToUpper = True
        Me.txtlineremarks.Value = ""
        Me.txtlineremarks.ValueSource = ""
        '
        'txt_exchange_rate
        '
        Me.txt_exchange_rate.AlwaysDisable = False
        Me.txt_exchange_rate.AlwaysEnable = False
        Me.txt_exchange_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_exchange_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_exchange_rate.BrowseDataSource = ""
        Me.txt_exchange_rate.BrowseField = ""
        Me.txt_exchange_rate.BrowseFilter = Nothing
        Me.txt_exchange_rate.BrowseLabel = "Code,Name"
        Me.txt_exchange_rate.BrowseLabelWidth = "100,200"
        Me.txt_exchange_rate.BrowseTextSource = ""
        Me.txt_exchange_rate.BrowseValueSource = ""
        Me.txt_exchange_rate.Database = user_control.MyList.Database.FileSetup
        Me.txt_exchange_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.txt_exchange_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_exchange_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_exchange_rate.Enabled = False
        Me.txt_exchange_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_exchange_rate.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_exchange_rate.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_exchange_rate.ID = False
        Me.txt_exchange_rate.Location = New System.Drawing.Point(357, 30)
        Me.txt_exchange_rate.Name = "txt_exchange_rate"
        Me.txt_exchange_rate.NoClear = False
        Me.txt_exchange_rate.NumberFormat = "##,##0.0000"
        Me.txt_exchange_rate.Required = False
        Me.txt_exchange_rate.RowData = Nothing
        Me.txt_exchange_rate.Size = New System.Drawing.Size(139, 20)
        Me.txt_exchange_rate.TabIndex = 40
        Me.txt_exchange_rate.Text = "0.0000"
        Me.txt_exchange_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_exchange_rate.TextBrowse = False
        Me.txt_exchange_rate.TextSource = ""
        Me.txt_exchange_rate.ToUpper = True
        Me.txt_exchange_rate.Value = ""
        Me.txt_exchange_rate.ValueSource = "exchange_rate"
        '
        'lblLineRemarks
        '
        Me.lblLineRemarks.AutoSize = True
        Me.lblLineRemarks.Location = New System.Drawing.Point(8, 11)
        Me.lblLineRemarks.Name = "lblLineRemarks"
        Me.lblLineRemarks.Size = New System.Drawing.Size(72, 13)
        Me.lblLineRemarks.TabIndex = 127
        Me.lblLineRemarks.Text = "Line Remarks"
        '
        'lbltermsdet
        '
        Me.lbltermsdet.AutoSize = True
        Me.lbltermsdet.Location = New System.Drawing.Point(570, 119)
        Me.lbltermsdet.Name = "lbltermsdet"
        Me.lbltermsdet.Size = New System.Drawing.Size(36, 13)
        Me.lbltermsdet.TabIndex = 213
        Me.lbltermsdet.Tag = "adjustToTop"
        Me.lbltermsdet.Text = "Terms"
        Me.lbltermsdet.Visible = False
        '
        'lblbasedrate
        '
        Me.lblbasedrate.AutoSize = True
        Me.lblbasedrate.Location = New System.Drawing.Point(554, 34)
        Me.lblbasedrate.Name = "lblbasedrate"
        Me.lblbasedrate.Size = New System.Drawing.Size(63, 13)
        Me.lblbasedrate.TabIndex = 196
        Me.lblbasedrate.Text = "Based Rate"
        '
        'lblexchangerate
        '
        Me.lblexchangerate.AutoSize = True
        Me.lblexchangerate.Location = New System.Drawing.Point(270, 34)
        Me.lblexchangerate.Name = "lblexchangerate"
        Me.lblexchangerate.Size = New System.Drawing.Size(81, 13)
        Me.lblexchangerate.TabIndex = 195
        Me.lblexchangerate.Text = "Exchange Rate"
        '
        'lblcurrency
        '
        Me.lblcurrency.AutoSize = True
        Me.lblcurrency.Location = New System.Drawing.Point(8, 34)
        Me.lblcurrency.Name = "lblcurrency"
        Me.lblcurrency.Size = New System.Drawing.Size(49, 13)
        Me.lblcurrency.TabIndex = 194
        Me.lblcurrency.Text = "Currency"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(285, 116)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 13)
        Me.Label28.TabIndex = 126
        Me.Label28.Tag = "adjustToTop"
        Me.Label28.Text = "Credit Based"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(285, 95)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 13)
        Me.Label29.TabIndex = 123
        Me.Label29.Tag = "adjustToTop"
        Me.Label29.Text = "Debit Based"
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.Maroon
        Me.btnUndo.Enabled = False
        Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.ForeColor = System.Drawing.Color.White
        Me.btnUndo.Location = New System.Drawing.Point(664, 156)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(100, 23)
        Me.btnUndo.TabIndex = 60
        Me.btnUndo.Tag = "adjustToTop"
        Me.btnUndo.Text = "Cancel"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Green
        Me.btnOK.Enabled = False
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(558, 156)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 23)
        Me.btnOK.TabIndex = 59
        Me.btnOK.Tag = "adjustToTop"
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 161)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 13)
        Me.Label25.TabIndex = 118
        Me.Label25.Tag = "adjustToTop"
        Me.Label25.Text = "D.N. Ref."
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(229, 137)
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
        Me.Label24.Location = New System.Drawing.Point(8, 139)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 114
        Me.Label24.Tag = "adjustToTop"
        Me.Label24.Text = "Gen. Ref."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 116)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 113
        Me.Label23.Tag = "adjustToTop"
        Me.Label23.Text = "Credit"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 93)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 13)
        Me.Label22.TabIndex = 111
        Me.Label22.Tag = "adjustToTop"
        Me.Label22.Text = "Debit"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(229, 53)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 108
        Me.PictureBox3.TabStop = False
        '
        'lblAllocation
        '
        Me.lblAllocation.AutoSize = True
        Me.lblAllocation.Location = New System.Drawing.Point(554, 74)
        Me.lblAllocation.Name = "lblAllocation"
        Me.lblAllocation.Size = New System.Drawing.Size(53, 13)
        Me.lblAllocation.TabIndex = 107
        Me.lblAllocation.Text = "Allocation"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 105
        Me.Label20.Text = "Account Code"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(285, 74)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 104
        Me.lblDepartment.Text = "Department"
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Location = New System.Drawing.Point(8, 74)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(40, 13)
        Me.lblProject.TabIndex = 103
        Me.lblProject.Text = "Project"
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
        Me.DataColum101.AllowDBNull = False
        Me.DataColum101.ColumnName = "sel"
        Me.DataColum101.DataType = GetType(Boolean)
        Me.DataColum101.DefaultValue = False
        '
        'DataColum102
        '
        Me.DataColum102.AllowDBNull = False
        Me.DataColum102.ColumnName = "trans_id"
        Me.DataColum102.DefaultValue = ""
        '
        'DataColum103
        '
        Me.DataColum103.AllowDBNull = False
        Me.DataColum103.ColumnName = "trans_no"
        Me.DataColum103.DefaultValue = ""
        '
        'DataColum104
        '
        Me.DataColum104.AllowDBNull = False
        Me.DataColum104.ColumnName = "trans_date"
        Me.DataColum104.DataType = GetType(Date)
        '
        'DataColum105
        '
        Me.DataColum105.AllowDBNull = False
        Me.DataColum105.ColumnName = "book_id"
        Me.DataColum105.DefaultValue = ""
        '
        'DataColum106
        '
        Me.DataColum106.AllowDBNull = False
        Me.DataColum106.ColumnName = "journal_id"
        Me.DataColum106.DefaultValue = ""
        '
        'DataColum107
        '
        Me.DataColum107.AllowDBNull = False
        Me.DataColum107.ColumnName = "general_id"
        Me.DataColum107.DefaultValue = ""
        '
        'DataColum108
        '
        Me.DataColum108.AllowDBNull = False
        Me.DataColum108.ColumnName = "currency_id"
        Me.DataColum108.DefaultValue = ""
        '
        'DataColum109
        '
        Me.DataColum109.AllowDBNull = False
        Me.DataColum109.ColumnName = "exchange_rate"
        Me.DataColum109.DataType = GetType(Decimal)
        Me.DataColum109.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColum110
        '
        Me.DataColum110.AllowDBNull = False
        Me.DataColum110.ColumnName = "based_rate"
        Me.DataColum110.DataType = GetType(Decimal)
        Me.DataColum110.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "amount"
        Me.DataColumn1.DataType = GetType(Decimal)
        Me.DataColumn1.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "amount_based"
        Me.DataColumn2.DataType = GetType(Decimal)
        Me.DataColumn2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'description
        '
        Me.description.AllowDBNull = False
        Me.description.ColumnName = "description"
        Me.description.DefaultValue = ""
        '
        'DataColumn34
        '
        Me.DataColumn34.AllowDBNull = False
        Me.DataColumn34.ColumnName = "book_code"
        Me.DataColumn34.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.AllowDBNull = False
        Me.DataColumn35.ColumnName = "book_name"
        Me.DataColumn35.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.AllowDBNull = False
        Me.DataColumn36.ColumnName = "journal_code"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "journal_name"
        Me.DataColumn37.DefaultValue = ""
        '
        'DataColumn38
        '
        Me.DataColumn38.AllowDBNull = False
        Me.DataColumn38.ColumnName = "general_code"
        Me.DataColumn38.DefaultValue = ""
        '
        'DataColumn39
        '
        Me.DataColumn39.AllowDBNull = False
        Me.DataColumn39.ColumnName = "general_name"
        Me.DataColumn39.DefaultValue = ""
        '
        'DataColumn40
        '
        Me.DataColumn40.AllowDBNull = False
        Me.DataColumn40.ColumnName = "currency_code"
        Me.DataColumn40.DefaultValue = ""
        '
        'DataColumn41
        '
        Me.DataColumn41.AllowDBNull = False
        Me.DataColumn41.ColumnName = "currency_name"
        Me.DataColumn41.DefaultValue = ""
        '
        'DataColumn160
        '
        Me.DataColumn160.AllowDBNull = False
        Me.DataColumn160.ColumnName = "posted"
        Me.DataColumn160.DataType = GetType(Short)
        Me.DataColumn160.DefaultValue = CType(0, Short)
        '
        'DataColumn161
        '
        Me.DataColumn161.AllowDBNull = False
        Me.DataColumn161.ColumnName = "si_no"
        Me.DataColumn161.DefaultValue = ""
        '
        'DataColumn162
        '
        Me.DataColumn162.AllowDBNull = False
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
        Me.DataColumn277.ColumnName = "trans_ib_id"
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
        Me.jbooks.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn151, Me.DataColumn152, Me.DataColumn153, Me.DataColumn165, Me.DataColumn170, Me.DataColumn171, Me.DataColumn172, Me.DataColumn173, Me.DataColumn261, Me.DataColumn262, Me.DataColumn263, Me.DataColumn264, Me.DataColumn284, Me.DataColumn285, Me.DataColumn286, Me.DataColumn287, Me.DataColumn288})
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
        Me.DataColumn8.AllowDBNull = False
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
        Me.DataColumn21.AllowDBNull = False
        Me.DataColumn21.ColumnName = "allocation_code"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn22
        '
        Me.DataColumn22.AllowDBNull = False
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
        Me.DataColumn32.AllowDBNull = False
        Me.DataColumn32.ColumnName = "ref_journal_code"
        Me.DataColumn32.DefaultValue = ""
        '
        'DataColumn33
        '
        Me.DataColumn33.AllowDBNull = False
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
        Me.DataColumn152.DataType = GetType(Short)
        Me.DataColumn152.DefaultValue = CType(0, Short)
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
        Me.DataColumn43.AllowDBNull = False
        Me.DataColumn43.ColumnName = "jbooks_id"
        Me.DataColumn43.DefaultValue = ""
        '
        'DataColumn44
        '
        Me.DataColumn44.AllowDBNull = False
        Me.DataColumn44.ColumnName = "general_id"
        Me.DataColumn44.DefaultValue = ""
        '
        'DataColumn45
        '
        Me.DataColumn45.AllowDBNull = False
        Me.DataColumn45.ColumnName = "fs_ewt_id"
        Me.DataColumn45.DefaultValue = ""
        '
        'DataColumn47
        '
        Me.DataColumn47.AllowDBNull = False
        Me.DataColumn47.ColumnName = "offset_type"
        Me.DataColumn47.DefaultValue = ""
        '
        'DataColumn48
        '
        Me.DataColumn48.AllowDBNull = False
        Me.DataColumn48.ColumnName = "tax_rate"
        Me.DataColumn48.DataType = GetType(Decimal)
        Me.DataColumn48.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn49
        '
        Me.DataColumn49.AllowDBNull = False
        Me.DataColumn49.ColumnName = "amount"
        Me.DataColumn49.DataType = GetType(Decimal)
        Me.DataColumn49.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn50
        '
        Me.DataColumn50.AllowDBNull = False
        Me.DataColumn50.ColumnName = "tax_amount"
        Me.DataColumn50.DataType = GetType(Decimal)
        Me.DataColumn50.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn51
        '
        Me.DataColumn51.AllowDBNull = False
        Me.DataColumn51.ColumnName = "debit"
        Me.DataColumn51.DataType = GetType(Decimal)
        Me.DataColumn51.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn52
        '
        Me.DataColumn52.AllowDBNull = False
        Me.DataColumn52.ColumnName = "credit"
        Me.DataColumn52.DataType = GetType(Decimal)
        Me.DataColumn52.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn53
        '
        Me.DataColumn53.AllowDBNull = False
        Me.DataColumn53.ColumnName = "amount_based"
        Me.DataColumn53.DataType = GetType(Decimal)
        Me.DataColumn53.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn54
        '
        Me.DataColumn54.AllowDBNull = False
        Me.DataColumn54.ColumnName = "tax_amount_based"
        Me.DataColumn54.DataType = GetType(Decimal)
        Me.DataColumn54.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn55
        '
        Me.DataColumn55.AllowDBNull = False
        Me.DataColumn55.ColumnName = "debit_based"
        Me.DataColumn55.DataType = GetType(Decimal)
        Me.DataColumn55.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn56
        '
        Me.DataColumn56.AllowDBNull = False
        Me.DataColumn56.ColumnName = "credit_based"
        Me.DataColumn56.DataType = GetType(Decimal)
        Me.DataColumn56.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn57
        '
        Me.DataColumn57.AllowDBNull = False
        Me.DataColumn57.ColumnName = "ref_ewt_id"
        Me.DataColumn57.DefaultValue = ""
        '
        'DataColumn46
        '
        Me.DataColumn46.AllowDBNull = False
        Me.DataColumn46.ColumnName = "general_code"
        Me.DataColumn46.DefaultValue = ""
        '
        'DataColumn77
        '
        Me.DataColumn77.AllowDBNull = False
        Me.DataColumn77.ColumnName = "general_name"
        Me.DataColumn77.DefaultValue = ""
        '
        'DataColumn78
        '
        Me.DataColumn78.AllowDBNull = False
        Me.DataColumn78.ColumnName = "fs_ewt_code"
        Me.DataColumn78.DefaultValue = ""
        '
        'DataColumn79
        '
        Me.DataColumn79.AllowDBNull = False
        Me.DataColumn79.ColumnName = "fs_ewt_name"
        Me.DataColumn79.DefaultValue = ""
        '
        'DataColumn96
        '
        Me.DataColumn96.AllowDBNull = False
        Me.DataColumn96.ColumnName = "tin"
        Me.DataColumn96.DefaultValue = ""
        '
        'DataColumn154
        '
        Me.DataColumn154.AllowDBNull = False
        Me.DataColumn154.ColumnName = "deleted"
        Me.DataColumn154.DataType = GetType(Boolean)
        Me.DataColumn154.DefaultValue = False
        '
        'DataColumn163
        '
        Me.DataColumn163.ColumnName = "trans_date"
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
        Me.checks.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn73, Me.DataColumn74, Me.DataColumn72, Me.DataColumn75, Me.DataColumn76, Me.DataColumn155, Me.DataColumn265, Me.DataColumn266, Me.DataColumn267, Me.DataColumn268, Me.DataColumn269, Me.DataColumn270, Me.DataColumn271, Me.DataColumn272, Me.DataColumn273, Me.DataColumn274, Me.DataColumn280, Me.DataColumn281, Me.DataColumn282, Me.DataColumn283, Me.DataColumn291, Me.DataColumn292})
        Me.checks.TableName = "checks"
        '
        'DataColumn58
        '
        Me.DataColumn58.AllowDBNull = False
        Me.DataColumn58.ColumnName = "check_id"
        Me.DataColumn58.DefaultValue = ""
        '
        'DataColumn59
        '
        Me.DataColumn59.AllowDBNull = False
        Me.DataColumn59.ColumnName = "jbooks_id"
        Me.DataColumn59.DefaultValue = ""
        '
        'DataColumn60
        '
        Me.DataColumn60.AllowDBNull = False
        Me.DataColumn60.ColumnName = "general_id"
        Me.DataColumn60.DefaultValue = ""
        '
        'DataColumn61
        '
        Me.DataColumn61.AllowDBNull = False
        Me.DataColumn61.ColumnName = "check_no"
        Me.DataColumn61.DefaultValue = ""
        '
        'DataColumn62
        '
        Me.DataColumn62.AllowDBNull = False
        Me.DataColumn62.ColumnName = "check_date"
        Me.DataColumn62.DataType = GetType(Date)
        '
        'DataColumn63
        '
        Me.DataColumn63.AllowDBNull = False
        Me.DataColumn63.ColumnName = "check_amount"
        Me.DataColumn63.DataType = GetType(Decimal)
        Me.DataColumn63.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn64
        '
        Me.DataColumn64.AllowDBNull = False
        Me.DataColumn64.ColumnName = "check_amount_based"
        Me.DataColumn64.DataType = GetType(Decimal)
        Me.DataColumn64.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn65
        '
        Me.DataColumn65.AllowDBNull = False
        Me.DataColumn65.ColumnName = "bank_id"
        Me.DataColumn65.DefaultValue = ""
        '
        'DataColumn66
        '
        Me.DataColumn66.AllowDBNull = False
        Me.DataColumn66.ColumnName = "cleared"
        Me.DataColumn66.DataType = GetType(Boolean)
        Me.DataColumn66.DefaultValue = False
        '
        'DataColumn67
        '
        Me.DataColumn67.AllowDBNull = False
        Me.DataColumn67.ColumnName = "released"
        Me.DataColumn67.DataType = GetType(Boolean)
        Me.DataColumn67.DefaultValue = False
        '
        'DataColumn68
        '
        Me.DataColumn68.AllowDBNull = False
        Me.DataColumn68.ColumnName = "cancelled"
        Me.DataColumn68.DataType = GetType(Boolean)
        '
        'DataColumn69
        '
        Me.DataColumn69.AllowDBNull = False
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
        Me.DataColumn71.AllowDBNull = False
        Me.DataColumn71.ColumnName = "cleared_date"
        Me.DataColumn71.DataType = GetType(Date)
        '
        'DataColumn73
        '
        Me.DataColumn73.AllowDBNull = False
        Me.DataColumn73.ColumnName = "deposit_date"
        Me.DataColumn73.DataType = GetType(Date)
        '
        'DataColumn74
        '
        Me.DataColumn74.AllowDBNull = False
        Me.DataColumn74.ColumnName = "cancel_date"
        Me.DataColumn74.DataType = GetType(Date)
        '
        'DataColumn72
        '
        Me.DataColumn72.AllowDBNull = False
        Me.DataColumn72.ColumnName = "replaced"
        Me.DataColumn72.DataType = GetType(Boolean)
        Me.DataColumn72.DefaultValue = False
        '
        'DataColumn75
        '
        Me.DataColumn75.AllowDBNull = False
        Me.DataColumn75.ColumnName = "general_code"
        Me.DataColumn75.DefaultValue = ""
        '
        'DataColumn76
        '
        Me.DataColumn76.AllowDBNull = False
        Me.DataColumn76.ColumnName = "general_name"
        Me.DataColumn76.DefaultValue = ""
        '
        'DataColumn155
        '
        Me.DataColumn155.AllowDBNull = False
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
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(536, 71)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 23)
        Me.btnCancel.TabIndex = 307
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(808, 30)
        Me.Myformheader1.TabIndex = 0
        '
        'txttransid
        '
        Me.txttransid.AlwaysDisable = False
        Me.txttransid.AlwaysEnable = False
        Me.txttransid.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttransid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttransid.BrowseDataSource = ""
        Me.txttransid.BrowseField = ""
        Me.txttransid.BrowseFilter = Nothing
        Me.txttransid.BrowseLabel = "Code,Name"
        Me.txttransid.BrowseLabelWidth = "100,200"
        Me.txttransid.BrowseTextSource = ""
        Me.txttransid.BrowseValueSource = ""
        Me.txttransid.Database = user_control.MyList.Database.FileSetup
        Me.txttransid.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttransid.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttransid.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txttransid.Enabled = False
        Me.txttransid.EnabledBackColor = System.Drawing.Color.White
        Me.txttransid.EnabledForeColor = System.Drawing.Color.Black
        Me.txttransid.ForeColor = System.Drawing.Color.Black
        Me.txttransid.ID = False
        Me.txttransid.Location = New System.Drawing.Point(22, 71)
        Me.txttransid.Name = "txttransid"
        Me.txttransid.NoClear = False
        Me.txttransid.NumberFormat = "@"
        Me.txttransid.Required = False
        Me.txttransid.RowData = Nothing
        Me.txttransid.Size = New System.Drawing.Size(20, 20)
        Me.txttransid.TabIndex = 322
        Me.txttransid.TextBrowse = False
        Me.txttransid.TextSource = "trans_id"
        Me.txttransid.ToUpper = True
        Me.txttransid.Value = ""
        Me.txttransid.ValueSource = ""
        Me.txttransid.Visible = False
        '
        'txttransibid
        '
        Me.txttransibid.AlwaysDisable = False
        Me.txttransibid.AlwaysEnable = False
        Me.txttransibid.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttransibid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttransibid.BrowseDataSource = ""
        Me.txttransibid.BrowseField = ""
        Me.txttransibid.BrowseFilter = Nothing
        Me.txttransibid.BrowseLabel = "Code,Name"
        Me.txttransibid.BrowseLabelWidth = "100,200"
        Me.txttransibid.BrowseTextSource = ""
        Me.txttransibid.BrowseValueSource = ""
        Me.txttransibid.Database = user_control.MyList.Database.FileSetup
        Me.txttransibid.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttransibid.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txttransibid.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txttransibid.Enabled = False
        Me.txttransibid.EnabledBackColor = System.Drawing.Color.White
        Me.txttransibid.EnabledForeColor = System.Drawing.Color.Black
        Me.txttransibid.ForeColor = System.Drawing.Color.Black
        Me.txttransibid.ID = False
        Me.txttransibid.Location = New System.Drawing.Point(41, 71)
        Me.txttransibid.Name = "txttransibid"
        Me.txttransibid.NoClear = False
        Me.txttransibid.NumberFormat = "@"
        Me.txttransibid.Required = False
        Me.txttransibid.RowData = Nothing
        Me.txttransibid.Size = New System.Drawing.Size(20, 20)
        Me.txttransibid.TabIndex = 323
        Me.txttransibid.TextBrowse = False
        Me.txttransibid.TextSource = "trans_ib_id"
        Me.txttransibid.ToUpper = True
        Me.txttransibid.Value = ""
        Me.txttransibid.ValueSource = ""
        Me.txttransibid.Visible = False
        '
        'transactionib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 665)
        Me.Controls.Add(Me.txttransibid)
        Me.Controls.Add(Me.txttransid)
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
        Me.Controls.Add(Me.dgjbooks)
        Me.Controls.Add(Me.det)
        Me.Controls.Add(Me.btnCorrection)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnComment)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transactionib"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Voucher"
        Me.hdr.ResumeLayout(False)
        Me.hdr.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgjbooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.det.ResumeLayout(False)
        Me.det.PerformLayout()
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
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
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
    Friend WithEvents txtduedate As user_control.myDatePicker
    Friend WithEvents btnParticular As System.Windows.Forms.Button
    Friend WithEvents particular As System.Data.DataTable
    Friend WithEvents DataColumn300 As System.Data.DataColumn
    Friend WithEvents DataColumn301 As System.Data.DataColumn
    Friend WithEvents DataColumn302 As System.Data.DataColumn
    Friend WithEvents DataColumn303 As System.Data.DataColumn
    Friend WithEvents DataColumn304 As System.Data.DataColumn
    Friend WithEvents DataColumn305 As System.Data.DataColumn
    Friend WithEvents txtexchangerate As user_control.MyTextBox
    Friend WithEvents txtbasedrate As user_control.MyTextBox
    Friend WithEvents txtnodays As user_control.MyTextBox
    Friend WithEvents txtdrno As user_control.MyTextBox
    Friend WithEvents txttransno As user_control.MyTextBox
    Friend WithEvents txtgeneralname As user_control.MyTextBox
    Friend WithEvents txtpono As user_control.MyTextBox
    Friend WithEvents txtcurrencyname As user_control.MyTextBox
    Friend WithEvents txtyear As user_control.MyTextBox
    Friend WithEvents txtday As user_control.MyTextBox
    Friend WithEvents txtmonth As user_control.MyTextBox
    Friend WithEvents txtamount As user_control.MyTextBox
    Friend WithEvents txtamountbased As user_control.MyTextBox
    Friend WithEvents txtdesc As user_control.MyTextBox
    Friend WithEvents txtamountwords As user_control.MyTextBox
    Friend WithEvents txtlineremarks As user_control.MyTextBox
    Friend WithEvents txt_currency_id As user_control.MyTextBox
    Friend WithEvents txt_based_rate As user_control.MyTextBox
    Friend WithEvents txt_exchange_rate As user_control.MyTextBox
    Friend WithEvents txtallocation As user_control.MyTextBox
    Friend WithEvents txtdepartment As user_control.MyTextBox
    Friend WithEvents txtproject As user_control.MyTextBox
    Friend WithEvents txtaccountname As user_control.MyTextBox
    Friend WithEvents txtaccount As user_control.MyTextBox
    Friend WithEvents txtterms As user_control.MyTextBox
    Friend WithEvents txttermsiddet As user_control.MyTextBox
    Friend WithEvents txtnodaysdet As user_control.MyTextBox
    Friend WithEvents txtcreditbased As user_control.MyTextBox
    Friend WithEvents txtdebitbased As user_control.MyTextBox
    Friend WithEvents txtcredit As user_control.MyTextBox
    Friend WithEvents txtdebit As user_control.MyTextBox
    Friend WithEvents txtgeneraldetname As user_control.MyTextBox
    Friend WithEvents txtgeneraldet As user_control.MyTextBox
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents jbooks_id_tmp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtdnref As user_control.MyTextBox
    Friend WithEvents txttransid As user_control.MyTextBox
    Friend WithEvents txttransibid As user_control.MyTextBox
    Friend WithEvents txtjbooksidtmp As user_control.MyTextBox
    Friend WithEvents txtdnrefbookcode As user_control.MyTextBox
    Friend WithEvents txtdnrefjournalcode As user_control.MyTextBox
    Friend WithEvents txtcurrency As user_control.MyTextBox
    Friend WithEvents txtgeneral As user_control.MyTextBox
End Class
