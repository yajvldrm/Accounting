<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cashor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnhdr2 = New System.Windows.Forms.Panel()
        Me.btnnotsave = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnunprint = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.det = New System.Windows.Forms.Panel()
        Me.txtCheckAmountBased = New DevExpress.XtraEditors.TextEdit()
        Me.txtCheckAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txt_check_id = New user_control.textbox()
        Me.txt_bank_name = New user_control.textbox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_bank_code = New user_control.textbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cancel_date = New System.Windows.Forms.DateTimePicker()
        Me.cancelled = New System.Windows.Forms.CheckBox()
        Me.txt_deposit_date = New System.Windows.Forms.DateTimePicker()
        Me.released = New System.Windows.Forms.CheckBox()
        Me.txt_cleared_date = New System.Windows.Forms.DateTimePicker()
        Me.cleared = New System.Windows.Forms.CheckBox()
        Me.btndet2 = New System.Windows.Forms.Panel()
        Me.btnundo = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txt_replacement_check_no = New user_control.textbox()
        Me.isReplaced = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_bank_name_depository = New user_control.textbox()
        Me.txt_general_name = New user_control.textbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_check_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_check_no = New user_control.textbox()
        Me.txt_bank_id = New user_control.textbox()
        Me.txt_general_id = New user_control.textbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.isCash = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btndet1 = New System.Windows.Forms.Panel()
        Me.lbl_balance = New System.Windows.Forms.Label()
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_reference_no = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgdet = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.check_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank_name_depository = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_book_code = New System.Windows.Forms.Label()
        Me.lbl_journal_code = New System.Windows.Forms.Label()
        Me.ds = New System.Data.DataSet()
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
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnhdr2.SuspendLayout()
        Me.det.SuspendLayout()
        CType(Me.txtCheckAmountBased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btndet2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btndet1.SuspendLayout()
        CType(Me.dgdet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnhdr2
        '
        Me.btnhdr2.Controls.Add(Me.btnnotsave)
        Me.btnhdr2.Controls.Add(Me.btnsave)
        Me.btnhdr2.Location = New System.Drawing.Point(346, 484)
        Me.btnhdr2.Name = "btnhdr2"
        Me.btnhdr2.Size = New System.Drawing.Size(168, 26)
        Me.btnhdr2.TabIndex = 133
        '
        'btnnotsave
        '
        Me.btnnotsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnnotsave.BackColor = System.Drawing.Color.Maroon
        Me.btnnotsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnnotsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnotsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnotsave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnotsave.ForeColor = System.Drawing.Color.White
        Me.btnnotsave.Location = New System.Drawing.Point(87, 1)
        Me.btnnotsave.Name = "btnnotsave"
        Me.btnnotsave.Size = New System.Drawing.Size(80, 24)
        Me.btnnotsave.TabIndex = 6
        Me.btnnotsave.Text = "&Cancel"
        Me.btnnotsave.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsave.BackColor = System.Drawing.Color.Green
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(1, 1)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 24)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnunprint
        '
        Me.btnunprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnunprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnunprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnunprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnunprint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnunprint.ForeColor = System.Drawing.Color.White
        Me.btnunprint.Location = New System.Drawing.Point(319, 1)
        Me.btnunprint.Name = "btnunprint"
        Me.btnunprint.Size = New System.Drawing.Size(164, 23)
        Me.btnunprint.TabIndex = 4
        Me.btnunprint.Text = "F5 Unprint Printed Checks"
        Me.btnunprint.UseVisualStyleBackColor = False
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ForeColor = System.Drawing.Color.White
        Me.btnremove.Location = New System.Drawing.Point(173, 1)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(80, 24)
        Me.btnremove.TabIndex = 3
        Me.btnremove.Text = "F4 Remove"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.Color.White
        Me.btninsert.Location = New System.Drawing.Point(1, 1)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(80, 24)
        Me.btninsert.TabIndex = 1
        Me.btninsert.Text = "F2 Insert"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(87, 1)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(80, 24)
        Me.btnupdate.TabIndex = 2
        Me.btnupdate.Text = "F3 Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'det
        '
        Me.det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.det.Controls.Add(Me.txtCheckAmountBased)
        Me.det.Controls.Add(Me.txtCheckAmount)
        Me.det.Controls.Add(Me.txt_check_id)
        Me.det.Controls.Add(Me.txt_bank_name)
        Me.det.Controls.Add(Me.PictureBox3)
        Me.det.Controls.Add(Me.txt_bank_code)
        Me.det.Controls.Add(Me.Label13)
        Me.det.Controls.Add(Me.txt_cancel_date)
        Me.det.Controls.Add(Me.cancelled)
        Me.det.Controls.Add(Me.txt_deposit_date)
        Me.det.Controls.Add(Me.released)
        Me.det.Controls.Add(Me.txt_cleared_date)
        Me.det.Controls.Add(Me.cleared)
        Me.det.Controls.Add(Me.btndet2)
        Me.det.Controls.Add(Me.txt_replacement_check_no)
        Me.det.Controls.Add(Me.isReplaced)
        Me.det.Controls.Add(Me.Label12)
        Me.det.Controls.Add(Me.Label11)
        Me.det.Controls.Add(Me.txt_bank_name_depository)
        Me.det.Controls.Add(Me.txt_general_name)
        Me.det.Controls.Add(Me.PictureBox2)
        Me.det.Controls.Add(Me.PictureBox1)
        Me.det.Controls.Add(Me.txt_check_date)
        Me.det.Controls.Add(Me.txt_check_no)
        Me.det.Controls.Add(Me.txt_bank_id)
        Me.det.Controls.Add(Me.txt_general_id)
        Me.det.Controls.Add(Me.Label10)
        Me.det.Controls.Add(Me.Label9)
        Me.det.Controls.Add(Me.Label8)
        Me.det.Controls.Add(Me.Label7)
        Me.det.Controls.Add(Me.Label5)
        Me.det.Controls.Add(Me.isCash)
        Me.det.Location = New System.Drawing.Point(18, 275)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(820, 196)
        Me.det.TabIndex = 132
        '
        'txtCheckAmountBased
        '
        Me.txtCheckAmountBased.EditValue = "0.00"
        Me.txtCheckAmountBased.Enabled = False
        Me.txtCheckAmountBased.Location = New System.Drawing.Point(394, 165)
        Me.txtCheckAmountBased.Name = "txtCheckAmountBased"
        Me.txtCheckAmountBased.Properties.DisplayFormat.FormatString = "n4"
        Me.txtCheckAmountBased.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCheckAmountBased.Properties.EditFormat.FormatString = "n4"
        Me.txtCheckAmountBased.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCheckAmountBased.Properties.Mask.EditMask = "n4"
        Me.txtCheckAmountBased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCheckAmountBased.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCheckAmountBased.Size = New System.Drawing.Size(150, 20)
        Me.txtCheckAmountBased.TabIndex = 12
        Me.txtCheckAmountBased.Tag = "check_amount_based"
        '
        'txtCheckAmount
        '
        Me.txtCheckAmount.EditValue = "0.00"
        Me.txtCheckAmount.Enabled = False
        Me.txtCheckAmount.Location = New System.Drawing.Point(117, 165)
        Me.txtCheckAmount.Name = "txtCheckAmount"
        Me.txtCheckAmount.Properties.DisplayFormat.FormatString = "n4"
        Me.txtCheckAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCheckAmount.Properties.EditFormat.FormatString = "n4"
        Me.txtCheckAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCheckAmount.Properties.Mask.EditMask = "n4"
        Me.txtCheckAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCheckAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCheckAmount.Size = New System.Drawing.Size(150, 20)
        Me.txtCheckAmount.TabIndex = 11
        Me.txtCheckAmount.Tag = "check_amount"
        '
        'txt_check_id
        '
        Me.txt_check_id._Text = ""
        Me.txt_check_id.AllowNegative = False
        Me.txt_check_id.AlwaysDisable = True
        Me.txt_check_id.AlwaysEnable = False
        Me.txt_check_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_check_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_check_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_check_id.DataSource = ""
        Me.txt_check_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_check_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_check_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_check_id.Enabled = False
        Me.txt_check_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_check_id.ispk = False
        Me.txt_check_id.Location = New System.Drawing.Point(136, 7)
        Me.txt_check_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_check_id.MultiLine = False
        Me.txt_check_id.Name = "txt_check_id"
        Me.txt_check_id.NoClear = False
        Me.txt_check_id.NumberFormat = "@"
        Me.txt_check_id.Required = False
        Me.txt_check_id.RowData = Nothing
        Me.txt_check_id.SelectionLength = 0
        Me.txt_check_id.SelectionStart = 0
        Me.txt_check_id.Size = New System.Drawing.Size(131, 20)
        Me.txt_check_id.TabIndex = 1
        Me.txt_check_id.TableData = Nothing
        Me.txt_check_id.TextSource = "check_id"
        Me.txt_check_id.UseSystemPasswordChar = False
        Me.txt_check_id.Value = ""
        Me.txt_check_id.ValueSource = "check_id"
        Me.txt_check_id.Visible = False
        '
        'txt_bank_name
        '
        Me.txt_bank_name._Text = ""
        Me.txt_bank_name.AllowNegative = False
        Me.txt_bank_name.AlwaysDisable = False
        Me.txt_bank_name.AlwaysEnable = False
        Me.txt_bank_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bank_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_name.DataSource = ""
        Me.txt_bank_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_name.Enabled = False
        Me.txt_bank_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank_name.ispk = False
        Me.txt_bank_name.Location = New System.Drawing.Point(117, 59)
        Me.txt_bank_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_name.MultiLine = False
        Me.txt_bank_name.Name = "txt_bank_name"
        Me.txt_bank_name.NoClear = False
        Me.txt_bank_name.NumberFormat = "@"
        Me.txt_bank_name.Required = False
        Me.txt_bank_name.RowData = Nothing
        Me.txt_bank_name.SelectionLength = 0
        Me.txt_bank_name.SelectionStart = 0
        Me.txt_bank_name.Size = New System.Drawing.Size(427, 20)
        Me.txt_bank_name.TabIndex = 4
        Me.txt_bank_name.TableData = Nothing
        Me.txt_bank_name.TextSource = "bank_name"
        Me.txt_bank_name.UseSystemPasswordChar = False
        Me.txt_bank_name.Value = ""
        Me.txt_bank_name.ValueSource = ""
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(267, 63)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 131
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'txt_bank_code
        '
        Me.txt_bank_code._Text = ""
        Me.txt_bank_code.AllowNegative = False
        Me.txt_bank_code.AlwaysDisable = False
        Me.txt_bank_code.AlwaysEnable = False
        Me.txt_bank_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bank_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_code.DataSource = ""
        Me.txt_bank_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_code.Enabled = False
        Me.txt_bank_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank_code.ispk = False
        Me.txt_bank_code.Location = New System.Drawing.Point(117, 59)
        Me.txt_bank_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_code.MultiLine = False
        Me.txt_bank_code.Name = "txt_bank_code"
        Me.txt_bank_code.NoClear = False
        Me.txt_bank_code.NumberFormat = "@"
        Me.txt_bank_code.Required = False
        Me.txt_bank_code.RowData = Nothing
        Me.txt_bank_code.SelectionLength = 0
        Me.txt_bank_code.SelectionStart = 0
        Me.txt_bank_code.Size = New System.Drawing.Size(150, 20)
        Me.txt_bank_code.TabIndex = 129
        Me.txt_bank_code.TableData = Nothing
        Me.txt_bank_code.TextSource = "bank_code"
        Me.txt_bank_code.UseSystemPasswordChar = False
        Me.txt_bank_code.Value = ""
        Me.txt_bank_code.ValueSource = ""
        Me.txt_bank_code.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Depository Bank"
        '
        'txt_cancel_date
        '
        Me.txt_cancel_date.Enabled = False
        Me.txt_cancel_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_cancel_date.Location = New System.Drawing.Point(645, 85)
        Me.txt_cancel_date.Name = "txt_cancel_date"
        Me.txt_cancel_date.Size = New System.Drawing.Size(150, 20)
        Me.txt_cancel_date.TabIndex = 19
        Me.txt_cancel_date.Visible = False
        '
        'cancelled
        '
        Me.cancelled.AutoSize = True
        Me.cancelled.Enabled = False
        Me.cancelled.Location = New System.Drawing.Point(566, 88)
        Me.cancelled.Name = "cancelled"
        Me.cancelled.Size = New System.Drawing.Size(73, 17)
        Me.cancelled.TabIndex = 18
        Me.cancelled.Text = "Cancelled"
        Me.cancelled.UseVisualStyleBackColor = True
        Me.cancelled.Visible = False
        '
        'txt_deposit_date
        '
        Me.txt_deposit_date.Enabled = False
        Me.txt_deposit_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_deposit_date.Location = New System.Drawing.Point(645, 59)
        Me.txt_deposit_date.Name = "txt_deposit_date"
        Me.txt_deposit_date.Size = New System.Drawing.Size(150, 20)
        Me.txt_deposit_date.TabIndex = 17
        Me.txt_deposit_date.Visible = False
        '
        'released
        '
        Me.released.AutoSize = True
        Me.released.Enabled = False
        Me.released.Location = New System.Drawing.Point(566, 62)
        Me.released.Name = "released"
        Me.released.Size = New System.Drawing.Size(71, 17)
        Me.released.TabIndex = 16
        Me.released.Text = "Released"
        Me.released.UseVisualStyleBackColor = True
        Me.released.Visible = False
        '
        'txt_cleared_date
        '
        Me.txt_cleared_date.Enabled = False
        Me.txt_cleared_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_cleared_date.Location = New System.Drawing.Point(645, 33)
        Me.txt_cleared_date.Name = "txt_cleared_date"
        Me.txt_cleared_date.Size = New System.Drawing.Size(150, 20)
        Me.txt_cleared_date.TabIndex = 15
        '
        'cleared
        '
        Me.cleared.AutoSize = True
        Me.cleared.Enabled = False
        Me.cleared.Location = New System.Drawing.Point(566, 36)
        Me.cleared.Name = "cleared"
        Me.cleared.Size = New System.Drawing.Size(62, 17)
        Me.cleared.TabIndex = 14
        Me.cleared.Text = "Cleared"
        Me.cleared.UseVisualStyleBackColor = True
        '
        'btndet2
        '
        Me.btndet2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndet2.Controls.Add(Me.btnundo)
        Me.btndet2.Controls.Add(Me.btnok)
        Me.btndet2.Location = New System.Drawing.Point(645, 162)
        Me.btndet2.Name = "btndet2"
        Me.btndet2.Size = New System.Drawing.Size(170, 26)
        Me.btndet2.TabIndex = 127
        '
        'btnundo
        '
        Me.btnundo.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnundo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnundo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnundo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnundo.ForeColor = System.Drawing.Color.White
        Me.btnundo.Location = New System.Drawing.Point(87, 1)
        Me.btnundo.Name = "btnundo"
        Me.btnundo.Size = New System.Drawing.Size(80, 24)
        Me.btnundo.TabIndex = 26
        Me.btnundo.Text = "Cancel"
        Me.btnundo.UseVisualStyleBackColor = False
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(1, 1)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(80, 24)
        Me.btnok.TabIndex = 25
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'txt_replacement_check_no
        '
        Me.txt_replacement_check_no._Text = ""
        Me.txt_replacement_check_no.AllowNegative = False
        Me.txt_replacement_check_no.AlwaysDisable = True
        Me.txt_replacement_check_no.AlwaysEnable = False
        Me.txt_replacement_check_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_replacement_check_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_replacement_check_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_replacement_check_no.DataSource = ""
        Me.txt_replacement_check_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_replacement_check_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_replacement_check_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_replacement_check_no.Enabled = False
        Me.txt_replacement_check_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_replacement_check_no.ispk = False
        Me.txt_replacement_check_no.Location = New System.Drawing.Point(394, 139)
        Me.txt_replacement_check_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_replacement_check_no.MultiLine = False
        Me.txt_replacement_check_no.Name = "txt_replacement_check_no"
        Me.txt_replacement_check_no.NoClear = False
        Me.txt_replacement_check_no.NumberFormat = "@"
        Me.txt_replacement_check_no.Required = False
        Me.txt_replacement_check_no.RowData = Nothing
        Me.txt_replacement_check_no.SelectionLength = 0
        Me.txt_replacement_check_no.SelectionStart = 0
        Me.txt_replacement_check_no.Size = New System.Drawing.Size(150, 20)
        Me.txt_replacement_check_no.TabIndex = 10
        Me.txt_replacement_check_no.TableData = Nothing
        Me.txt_replacement_check_no.TextSource = "replacement_check_no"
        Me.txt_replacement_check_no.UseSystemPasswordChar = False
        Me.txt_replacement_check_no.Value = ""
        Me.txt_replacement_check_no.ValueSource = ""
        Me.txt_replacement_check_no.Visible = False
        '
        'isReplaced
        '
        Me.isReplaced.AutoSize = True
        Me.isReplaced.Enabled = False
        Me.isReplaced.Location = New System.Drawing.Point(292, 113)
        Me.isReplaced.Name = "isReplaced"
        Me.isReplaced.Size = New System.Drawing.Size(101, 17)
        Me.isReplaced.TabIndex = 8
        Me.isReplaced.Text = "In replaced with"
        Me.isReplaced.UseVisualStyleBackColor = True
        Me.isReplaced.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(289, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "In Based Currency"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(308, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Reference Doc"
        Me.Label11.Visible = False
        '
        'txt_bank_name_depository
        '
        Me.txt_bank_name_depository._Text = ""
        Me.txt_bank_name_depository.AllowNegative = False
        Me.txt_bank_name_depository.AlwaysDisable = True
        Me.txt_bank_name_depository.AlwaysEnable = False
        Me.txt_bank_name_depository.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_name_depository.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bank_name_depository.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_name_depository.DataSource = ""
        Me.txt_bank_name_depository.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_name_depository.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_name_depository.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_name_depository.Enabled = False
        Me.txt_bank_name_depository.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank_name_depository.ispk = False
        Me.txt_bank_name_depository.Location = New System.Drawing.Point(283, 85)
        Me.txt_bank_name_depository.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_name_depository.MultiLine = False
        Me.txt_bank_name_depository.Name = "txt_bank_name_depository"
        Me.txt_bank_name_depository.NoClear = False
        Me.txt_bank_name_depository.NumberFormat = "@"
        Me.txt_bank_name_depository.Required = False
        Me.txt_bank_name_depository.RowData = Nothing
        Me.txt_bank_name_depository.SelectionLength = 0
        Me.txt_bank_name_depository.SelectionStart = 0
        Me.txt_bank_name_depository.Size = New System.Drawing.Size(261, 20)
        Me.txt_bank_name_depository.TabIndex = 6
        Me.txt_bank_name_depository.TableData = Nothing
        Me.txt_bank_name_depository.TextSource = "bank_name_depository"
        Me.txt_bank_name_depository.UseSystemPasswordChar = False
        Me.txt_bank_name_depository.Value = ""
        Me.txt_bank_name_depository.ValueSource = ""
        '
        'txt_general_name
        '
        Me.txt_general_name._Text = ""
        Me.txt_general_name.AllowNegative = False
        Me.txt_general_name.AlwaysDisable = True
        Me.txt_general_name.AlwaysEnable = False
        Me.txt_general_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_name.DataSource = ""
        Me.txt_general_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_name.Enabled = False
        Me.txt_general_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_name.ispk = False
        Me.txt_general_name.Location = New System.Drawing.Point(283, 33)
        Me.txt_general_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.MultiLine = False
        Me.txt_general_name.Name = "txt_general_name"
        Me.txt_general_name.NoClear = True
        Me.txt_general_name.NumberFormat = "@"
        Me.txt_general_name.Required = False
        Me.txt_general_name.RowData = Nothing
        Me.txt_general_name.SelectionLength = 0
        Me.txt_general_name.SelectionStart = 0
        Me.txt_general_name.Size = New System.Drawing.Size(261, 20)
        Me.txt_general_name.TabIndex = 3
        Me.txt_general_name.TableData = Nothing
        Me.txt_general_name.TextSource = "general_name"
        Me.txt_general_name.UseSystemPasswordChar = False
        Me.txt_general_name.Value = ""
        Me.txt_general_name.ValueSource = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(267, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 118
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'txt_check_date
        '
        Me.txt_check_date.Enabled = False
        Me.txt_check_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_check_date.Location = New System.Drawing.Point(117, 139)
        Me.txt_check_date.Name = "txt_check_date"
        Me.txt_check_date.Size = New System.Drawing.Size(150, 20)
        Me.txt_check_date.TabIndex = 9
        '
        'txt_check_no
        '
        Me.txt_check_no._Text = ""
        Me.txt_check_no.AllowNegative = False
        Me.txt_check_no.AlwaysDisable = False
        Me.txt_check_no.AlwaysEnable = False
        Me.txt_check_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_check_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_check_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_check_no.DataSource = ""
        Me.txt_check_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_check_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_check_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_check_no.Enabled = False
        Me.txt_check_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_check_no.ispk = False
        Me.txt_check_no.Location = New System.Drawing.Point(117, 113)
        Me.txt_check_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_check_no.MultiLine = False
        Me.txt_check_no.Name = "txt_check_no"
        Me.txt_check_no.NoClear = False
        Me.txt_check_no.NumberFormat = "@"
        Me.txt_check_no.Required = False
        Me.txt_check_no.RowData = Nothing
        Me.txt_check_no.SelectionLength = 0
        Me.txt_check_no.SelectionStart = 0
        Me.txt_check_no.Size = New System.Drawing.Size(150, 20)
        Me.txt_check_no.TabIndex = 7
        Me.txt_check_no.TableData = Nothing
        Me.txt_check_no.TextSource = "check_no"
        Me.txt_check_no.UseSystemPasswordChar = False
        Me.txt_check_no.Value = ""
        Me.txt_check_no.ValueSource = ""
        '
        'txt_bank_id
        '
        Me.txt_bank_id._Text = ""
        Me.txt_bank_id.AllowNegative = False
        Me.txt_bank_id.AlwaysDisable = False
        Me.txt_bank_id.AlwaysEnable = False
        Me.txt_bank_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bank_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank_id.DataSource = ""
        Me.txt_bank_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank_id.Enabled = False
        Me.txt_bank_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank_id.ispk = False
        Me.txt_bank_id.Location = New System.Drawing.Point(117, 85)
        Me.txt_bank_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank_id.MultiLine = False
        Me.txt_bank_id.Name = "txt_bank_id"
        Me.txt_bank_id.NoClear = False
        Me.txt_bank_id.NumberFormat = "@"
        Me.txt_bank_id.Required = False
        Me.txt_bank_id.RowData = Nothing
        Me.txt_bank_id.SelectionLength = 0
        Me.txt_bank_id.SelectionStart = 0
        Me.txt_bank_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_bank_id.TabIndex = 5
        Me.txt_bank_id.TableData = Nothing
        Me.txt_bank_id.TextSource = "bank_code_depository"
        Me.txt_bank_id.UseSystemPasswordChar = False
        Me.txt_bank_id.Value = ""
        Me.txt_bank_id.ValueSource = "bank_id"
        '
        'txt_general_id
        '
        Me.txt_general_id._Text = ""
        Me.txt_general_id.AllowNegative = False
        Me.txt_general_id.AlwaysDisable = True
        Me.txt_general_id.AlwaysEnable = False
        Me.txt_general_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.DataSource = ""
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.Enabled = False
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.ispk = False
        Me.txt_general_id.Location = New System.Drawing.Point(117, 33)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = True
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_general_id.TabIndex = 2
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.TextSource = "general_code"
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = "general_id"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Check Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Check No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Bank"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Payee"
        '
        'isCash
        '
        Me.isCash.AutoSize = True
        Me.isCash.Enabled = False
        Me.isCash.Location = New System.Drawing.Point(53, 10)
        Me.isCash.Name = "isCash"
        Me.isCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.isCash.Size = New System.Drawing.Size(77, 17)
        Me.isCash.TabIndex = 13
        Me.isCash.Text = "Cash Entry"
        Me.isCash.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(565, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 13)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "OUTSTANDING BALANCE"
        Me.Label6.Visible = False
        '
        'btndet1
        '
        Me.btndet1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndet1.Controls.Add(Me.btnunprint)
        Me.btndet1.Controls.Add(Me.btnremove)
        Me.btndet1.Controls.Add(Me.btninsert)
        Me.btndet1.Controls.Add(Me.btnupdate)
        Me.btndet1.Location = New System.Drawing.Point(19, 245)
        Me.btndet1.Name = "btndet1"
        Me.btndet1.Size = New System.Drawing.Size(484, 26)
        Me.btndet1.TabIndex = 131
        '
        'lbl_balance
        '
        Me.lbl_balance.AutoSize = True
        Me.lbl_balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_balance.ForeColor = System.Drawing.Color.Blue
        Me.lbl_balance.Location = New System.Drawing.Point(728, 251)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(46, 13)
        Me.lbl_balance.TabIndex = 130
        Me.lbl_balance.Text = "0.0000"
        Me.lbl_balance.Visible = False
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(23, 67)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(820, 2)
        Me.border2.TabIndex = 122
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(18, 65)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(820, 2)
        Me.border1.TabIndex = 121
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "TRANSACTION NO."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 25)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "OR Check / Cash Entry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "JOURNAL CODE"
        '
        'lbl_reference_no
        '
        Me.lbl_reference_no.AutoSize = True
        Me.lbl_reference_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reference_no.ForeColor = System.Drawing.Color.Blue
        Me.lbl_reference_no.Location = New System.Drawing.Point(150, 73)
        Me.lbl_reference_no.Name = "lbl_reference_no"
        Me.lbl_reference_no.Size = New System.Drawing.Size(102, 13)
        Me.lbl_reference_no.TabIndex = 126
        Me.lbl_reference_no.Text = "lbl_reference_no"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "BOOK CODE"
        '
        'dgdet
        '
        Me.dgdet.AllowUserToAddRows = False
        Me.dgdet.AllowUserToDeleteRows = False
        Me.dgdet.AllowUserToResizeColumns = False
        Me.dgdet.AllowUserToResizeRows = False
        Me.dgdet.BackgroundColor = System.Drawing.Color.White
        Me.dgdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.deleted, Me.check_id, Me.general_code, Me.general_name, Me.check_no, Me.check_date, Me.check_amount, Me.bank_name, Me.bank_name_depository})
        Me.dgdet.EnableHeadersVisualStyles = False
        Me.dgdet.GridColor = System.Drawing.Color.White
        Me.dgdet.Location = New System.Drawing.Point(18, 89)
        Me.dgdet.MultiSelect = False
        Me.dgdet.Name = "dgdet"
        Me.dgdet.RowHeadersVisible = False
        Me.dgdet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgdet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdet.Size = New System.Drawing.Size(820, 150)
        Me.dgdet.TabIndex = 119
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.Width = 32
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.deleted.Visible = False
        '
        'check_id
        '
        Me.check_id.DataPropertyName = "check_id"
        Me.check_id.HeaderText = "ID"
        Me.check_id.Name = "check_id"
        Me.check_id.Visible = False
        '
        'general_code
        '
        Me.general_code.DataPropertyName = "general_code"
        Me.general_code.HeaderText = "Payee Code"
        Me.general_code.Name = "general_code"
        Me.general_code.ReadOnly = True
        Me.general_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.general_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.general_code.Width = 80
        '
        'general_name
        '
        Me.general_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Payee Name"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        Me.general_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.general_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'check_no
        '
        Me.check_no.DataPropertyName = "check_no"
        Me.check_no.HeaderText = "Check No"
        Me.check_no.Name = "check_no"
        Me.check_no.ReadOnly = True
        Me.check_no.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.check_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.check_no.Width = 80
        '
        'check_date
        '
        Me.check_date.DataPropertyName = "check_date"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "00/00/0000"
        Me.check_date.DefaultCellStyle = DataGridViewCellStyle1
        Me.check_date.HeaderText = "Check Date"
        Me.check_date.Name = "check_date"
        Me.check_date.ReadOnly = True
        Me.check_date.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.check_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.check_date.Width = 80
        '
        'check_amount
        '
        Me.check_amount.DataPropertyName = "check_amount"
        Me.check_amount.HeaderText = "Amount"
        Me.check_amount.Name = "check_amount"
        Me.check_amount.ReadOnly = True
        Me.check_amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.check_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.check_amount.Width = 80
        '
        'bank_name
        '
        Me.bank_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bank_name.DataPropertyName = "bank_name"
        Me.bank_name.HeaderText = "Check Bank Name"
        Me.bank_name.Name = "bank_name"
        Me.bank_name.ReadOnly = True
        Me.bank_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bank_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bank_name_depository
        '
        Me.bank_name_depository.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bank_name_depository.DataPropertyName = "bank_name_depository"
        Me.bank_name_depository.HeaderText = "Depository Bank"
        Me.bank_name_depository.Name = "bank_name_depository"
        Me.bank_name_depository.ReadOnly = True
        Me.bank_name_depository.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bank_name_depository.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lbl_book_code
        '
        Me.lbl_book_code.AutoSize = True
        Me.lbl_book_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_book_code.ForeColor = System.Drawing.Color.Blue
        Me.lbl_book_code.Location = New System.Drawing.Point(409, 45)
        Me.lbl_book_code.Name = "lbl_book_code"
        Me.lbl_book_code.Size = New System.Drawing.Size(90, 13)
        Me.lbl_book_code.TabIndex = 128
        Me.lbl_book_code.Text = "lbl_book_code"
        '
        'lbl_journal_code
        '
        Me.lbl_journal_code.AutoSize = True
        Me.lbl_journal_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_journal_code.ForeColor = System.Drawing.Color.Blue
        Me.lbl_journal_code.Location = New System.Drawing.Point(432, 73)
        Me.lbl_journal_code.Name = "lbl_journal_code"
        Me.lbl_journal_code.Size = New System.Drawing.Size(100, 13)
        Me.lbl_journal_code.TabIndex = 127
        Me.lbl_journal_code.Text = "lbl_journal_code"
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.checks})
        '
        'checks
        '
        Me.checks.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn73, Me.DataColumn74, Me.DataColumn72, Me.DataColumn75, Me.DataColumn76, Me.DataColumn155, Me.DataColumn265, Me.DataColumn266, Me.DataColumn267, Me.DataColumn268, Me.DataColumn269, Me.DataColumn270, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
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
        Me.DataColumn69.DefaultValue = False
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
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "bank_code"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "bank_name"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "isCash"
        Me.DataColumn3.DataType = GetType(Boolean)
        Me.DataColumn3.DefaultValue = False
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "isReplaced"
        Me.DataColumn4.DataType = GetType(Boolean)
        Me.DataColumn4.DefaultValue = False
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "debit"
        Me.DataColumn5.DataType = GetType(Decimal)
        Me.DataColumn5.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "credit"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "debit_based"
        Me.DataColumn7.DataType = GetType(Decimal)
        Me.DataColumn7.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "credit_based"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "bank_code_depository"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "bank_name_depository"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "isPDC"
        Me.DataColumn11.DataType = GetType(Boolean)
        Me.DataColumn11.DefaultValue = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(860, 28)
        Me.Myformheader1.TabIndex = 134
        '
        'cashor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 528)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnhdr2)
        Me.Controls.Add(Me.det)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btndet1)
        Me.Controls.Add(Me.lbl_balance)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_reference_no)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgdet)
        Me.Controls.Add(Me.lbl_book_code)
        Me.Controls.Add(Me.lbl_journal_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cashor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OR Check / Cash Entry"
        Me.btnhdr2.ResumeLayout(False)
        Me.det.ResumeLayout(False)
        Me.det.PerformLayout()
        CType(Me.txtCheckAmountBased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btndet2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btndet1.ResumeLayout(False)
        CType(Me.dgdet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnhdr2 As System.Windows.Forms.Panel
    Friend WithEvents btnnotsave As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnunprint As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents det As System.Windows.Forms.Panel
    Friend WithEvents txt_cancel_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents cancelled As System.Windows.Forms.CheckBox
    Friend WithEvents txt_deposit_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents released As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cleared_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents cleared As System.Windows.Forms.CheckBox
    Friend WithEvents btndet2 As System.Windows.Forms.Panel
    Friend WithEvents btnundo As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txt_replacement_check_no As user_control.textbox
    Friend WithEvents isReplaced As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_bank_name_depository As user_control.textbox
    Friend WithEvents txt_general_name As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_check_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_check_no As user_control.textbox
    Friend WithEvents txt_bank_id As user_control.textbox
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents isCash As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btndet1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_balance As System.Windows.Forms.Label
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_reference_no As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_book_code As System.Windows.Forms.Label
    Friend WithEvents lbl_journal_code As System.Windows.Forms.Label
    Friend WithEvents ds As System.Data.DataSet
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
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents txt_check_id As user_control.textbox
    Friend WithEvents dgdet As System.Windows.Forms.DataGridView
    Friend WithEvents txt_bank_name As user_control.textbox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_bank_code As user_control.textbox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents check_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_name_depository As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents txtCheckAmountBased As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCheckAmount As DevExpress.XtraEditors.TextEdit
End Class
