<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class begbal_ar_detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(begbal_ar_detail))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_hdr = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_department = New user_control.textbox()
        Me.txt_account_name = New user_control.textbox()
        Me.txt_project = New user_control.textbox()
        Me.txt_account = New user_control.textbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_unit_id = New user_control.textbox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.txt_po_no = New user_control.textbox()
        Me.txt_dr_no = New user_control.textbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_ref_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_nodays = New user_control.textbox()
        Me.txt_based_rate = New user_control.textbox()
        Me.txt_terms_id = New user_control.textbox()
        Me.txt_exchange_rate = New user_control.textbox()
        Me.lbltermsdet = New System.Windows.Forms.Label()
        Me.txt_currency_name = New user_control.textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_jbooks_id = New user_control.textbox()
        Me.txt_credit_based = New user_control.textbox()
        Me.txt_debit_based = New user_control.textbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_general_name = New user_control.textbox()
        Me.txt_general_id = New user_control.textbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_credit = New user_control.textbox()
        Me.txt_debit = New user_control.textbox()
        Me.txt_ref_no = New user_control.textbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txt_total_based = New user_control.textbox()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.jbooks_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_total_amount = New user_control.textbox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.panel_hdr.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 25)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Receivable Beginning Balance - Details"
        '
        'panel_hdr
        '
        Me.panel_hdr.Controls.Add(Me.PictureBox1)
        Me.panel_hdr.Controls.Add(Me.txt_department)
        Me.panel_hdr.Controls.Add(Me.txt_account_name)
        Me.panel_hdr.Controls.Add(Me.txt_project)
        Me.panel_hdr.Controls.Add(Me.txt_account)
        Me.panel_hdr.Controls.Add(Me.Label8)
        Me.panel_hdr.Controls.Add(Me.Label5)
        Me.panel_hdr.Controls.Add(Me.Label3)
        Me.panel_hdr.Controls.Add(Me.Label2)
        Me.panel_hdr.Location = New System.Drawing.Point(12, 70)
        Me.panel_hdr.Name = "panel_hdr"
        Me.panel_hdr.Size = New System.Drawing.Size(676, 50)
        Me.panel_hdr.TabIndex = 179
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(335, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 220
        Me.PictureBox1.TabStop = False
        '
        'txt_department
        '
        Me.txt_department._Text = ""
        Me.txt_department.AllowNegative = False
        Me.txt_department.AlwaysDisable = True
        Me.txt_department.AlwaysEnable = False
        Me.txt_department.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department.DataSource = ""
        Me.txt_department.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department.Enabled = False
        Me.txt_department.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department.ispk = False
        Me.txt_department.Location = New System.Drawing.Point(422, 27)
        Me.txt_department.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department.MultiLine = False
        Me.txt_department.Name = "txt_department"
        Me.txt_department.NoClear = False
        Me.txt_department.NumberFormat = "@"
        Me.txt_department.Required = False
        Me.txt_department.RowData = Nothing
        Me.txt_department.SelectionLength = 0
        Me.txt_department.SelectionStart = 0
        Me.txt_department.Size = New System.Drawing.Size(200, 20)
        Me.txt_department.TabIndex = 11
        Me.txt_department.TableData = Nothing
        Me.txt_department.Tag = ""
        Me.txt_department.TextSource = ""
        Me.txt_department.UseSystemPasswordChar = False
        Me.txt_department.Value = ""
        Me.txt_department.ValueSource = ""
        '
        'txt_account_name
        '
        Me.txt_account_name._Text = ""
        Me.txt_account_name.AllowNegative = False
        Me.txt_account_name.AlwaysDisable = True
        Me.txt_account_name.AlwaysEnable = False
        Me.txt_account_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account_name.DataSource = ""
        Me.txt_account_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account_name.Enabled = False
        Me.txt_account_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account_name.ispk = False
        Me.txt_account_name.Location = New System.Drawing.Point(354, 3)
        Me.txt_account_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.MultiLine = False
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = False
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.SelectionLength = 0
        Me.txt_account_name.SelectionStart = 0
        Me.txt_account_name.Size = New System.Drawing.Size(268, 20)
        Me.txt_account_name.TabIndex = 10
        Me.txt_account_name.TableData = Nothing
        Me.txt_account_name.Tag = ""
        Me.txt_account_name.TextSource = ""
        Me.txt_account_name.UseSystemPasswordChar = False
        Me.txt_account_name.Value = ""
        Me.txt_account_name.ValueSource = ""
        '
        'txt_project
        '
        Me.txt_project._Text = ""
        Me.txt_project.AllowNegative = False
        Me.txt_project.AlwaysDisable = True
        Me.txt_project.AlwaysEnable = False
        Me.txt_project.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project.DataSource = ""
        Me.txt_project.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project.Enabled = False
        Me.txt_project.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project.ispk = False
        Me.txt_project.Location = New System.Drawing.Point(132, 27)
        Me.txt_project.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project.MultiLine = False
        Me.txt_project.Name = "txt_project"
        Me.txt_project.NoClear = False
        Me.txt_project.NumberFormat = "@"
        Me.txt_project.Required = False
        Me.txt_project.RowData = Nothing
        Me.txt_project.SelectionLength = 0
        Me.txt_project.SelectionStart = 0
        Me.txt_project.Size = New System.Drawing.Size(200, 20)
        Me.txt_project.TabIndex = 8
        Me.txt_project.TableData = Nothing
        Me.txt_project.Tag = ""
        Me.txt_project.TextSource = ""
        Me.txt_project.UseSystemPasswordChar = False
        Me.txt_project.Value = ""
        Me.txt_project.ValueSource = ""
        '
        'txt_account
        '
        Me.txt_account._Text = ""
        Me.txt_account.AllowNegative = False
        Me.txt_account.AlwaysDisable = True
        Me.txt_account.AlwaysEnable = False
        Me.txt_account.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_account.DataSource = ""
        Me.txt_account.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_account.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_account.Enabled = False
        Me.txt_account.EnabledBackColor = System.Drawing.Color.White
        Me.txt_account.ispk = False
        Me.txt_account.Location = New System.Drawing.Point(132, 3)
        Me.txt_account.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account.MultiLine = False
        Me.txt_account.Name = "txt_account"
        Me.txt_account.NoClear = False
        Me.txt_account.NumberFormat = "@"
        Me.txt_account.Required = False
        Me.txt_account.RowData = Nothing
        Me.txt_account.SelectionLength = 0
        Me.txt_account.SelectionStart = 0
        Me.txt_account.Size = New System.Drawing.Size(200, 20)
        Me.txt_account.TabIndex = 7
        Me.txt_account.TableData = Nothing
        Me.txt_account.Tag = ""
        Me.txt_account.TextSource = ""
        Me.txt_account.UseSystemPasswordChar = False
        Me.txt_account.Value = ""
        Me.txt_account.ValueSource = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(246, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = ">"
        Me.Label8.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Code"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_unit_id)
        Me.Panel2.Controls.Add(Me.lblUnit)
        Me.Panel2.Controls.Add(Me.txt_po_no)
        Me.Panel2.Controls.Add(Me.txt_dr_no)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txt_ref_date)
        Me.Panel2.Controls.Add(Me.txt_nodays)
        Me.Panel2.Controls.Add(Me.txt_based_rate)
        Me.Panel2.Controls.Add(Me.txt_terms_id)
        Me.Panel2.Controls.Add(Me.txt_exchange_rate)
        Me.Panel2.Controls.Add(Me.lbltermsdet)
        Me.Panel2.Controls.Add(Me.txt_currency_name)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_jbooks_id)
        Me.Panel2.Controls.Add(Me.txt_credit_based)
        Me.Panel2.Controls.Add(Me.txt_debit_based)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txt_general_name)
        Me.Panel2.Controls.Add(Me.txt_general_id)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txt_credit)
        Me.Panel2.Controls.Add(Me.txt_debit)
        Me.Panel2.Controls.Add(Me.txt_ref_no)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(12, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 167)
        Me.Panel2.TabIndex = 211
        Me.Panel2.Tag = "container"
        '
        'txt_unit_id
        '
        Me.txt_unit_id._Text = ""
        Me.txt_unit_id.AllowNegative = False
        Me.txt_unit_id.AlwaysDisable = False
        Me.txt_unit_id.AlwaysEnable = False
        Me.txt_unit_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_unit_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_unit_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_unit_id.DataSource = ""
        Me.txt_unit_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_unit_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_unit_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_unit_id.Enabled = False
        Me.txt_unit_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_unit_id.ispk = False
        Me.txt_unit_id.Location = New System.Drawing.Point(423, 137)
        Me.txt_unit_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_unit_id.MultiLine = False
        Me.txt_unit_id.Name = "txt_unit_id"
        Me.txt_unit_id.NoClear = False
        Me.txt_unit_id.NumberFormat = "@"
        Me.txt_unit_id.Required = False
        Me.txt_unit_id.RowData = Nothing
        Me.txt_unit_id.SelectionLength = 0
        Me.txt_unit_id.SelectionStart = 0
        Me.txt_unit_id.Size = New System.Drawing.Size(200, 20)
        Me.txt_unit_id.TabIndex = 323
        Me.txt_unit_id.TableData = Nothing
        Me.txt_unit_id.Tag = ""
        Me.txt_unit_id.TextSource = "unit_code"
        Me.txt_unit_id.UseSystemPasswordChar = False
        Me.txt_unit_id.Value = ""
        Me.txt_unit_id.ValueSource = "unit_id"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(391, 140)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblUnit.TabIndex = 322
        Me.lblUnit.Text = "Unit"
        '
        'txt_po_no
        '
        Me.txt_po_no._Text = ""
        Me.txt_po_no.AllowNegative = False
        Me.txt_po_no.AlwaysDisable = False
        Me.txt_po_no.AlwaysEnable = False
        Me.txt_po_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_po_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_po_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_po_no.DataSource = ""
        Me.txt_po_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_po_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_po_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_po_no.Enabled = False
        Me.txt_po_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_po_no.ispk = False
        Me.txt_po_no.Location = New System.Drawing.Point(423, 53)
        Me.txt_po_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_po_no.MultiLine = False
        Me.txt_po_no.Name = "txt_po_no"
        Me.txt_po_no.NoClear = False
        Me.txt_po_no.NumberFormat = "@"
        Me.txt_po_no.Required = False
        Me.txt_po_no.RowData = Nothing
        Me.txt_po_no.SelectionLength = 0
        Me.txt_po_no.SelectionStart = 0
        Me.txt_po_no.Size = New System.Drawing.Size(200, 20)
        Me.txt_po_no.TabIndex = 8
        Me.txt_po_no.TableData = Nothing
        Me.txt_po_no.TextSource = "po_no"
        Me.txt_po_no.UseSystemPasswordChar = False
        Me.txt_po_no.Value = ""
        Me.txt_po_no.ValueSource = ""
        '
        'txt_dr_no
        '
        Me.txt_dr_no._Text = ""
        Me.txt_dr_no.AllowNegative = False
        Me.txt_dr_no.AlwaysDisable = False
        Me.txt_dr_no.AlwaysEnable = False
        Me.txt_dr_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_dr_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_dr_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dr_no.DataSource = ""
        Me.txt_dr_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_dr_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_dr_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_dr_no.Enabled = False
        Me.txt_dr_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_dr_no.ispk = False
        Me.txt_dr_no.Location = New System.Drawing.Point(133, 53)
        Me.txt_dr_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_dr_no.MultiLine = False
        Me.txt_dr_no.Name = "txt_dr_no"
        Me.txt_dr_no.NoClear = False
        Me.txt_dr_no.NumberFormat = "@"
        Me.txt_dr_no.Required = False
        Me.txt_dr_no.RowData = Nothing
        Me.txt_dr_no.SelectionLength = 0
        Me.txt_dr_no.SelectionStart = 0
        Me.txt_dr_no.Size = New System.Drawing.Size(200, 20)
        Me.txt_dr_no.TabIndex = 7
        Me.txt_dr_no.TableData = Nothing
        Me.txt_dr_no.TextSource = "dr_no"
        Me.txt_dr_no.UseSystemPasswordChar = False
        Me.txt_dr_no.Value = ""
        Me.txt_dr_no.ValueSource = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(373, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 13)
        Me.Label18.TabIndex = 325
        Me.Label18.Text = "P.O. No."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(81, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 324
        Me.Label19.Text = "D.R. No."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(336, 118)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 219
        Me.PictureBox3.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(389, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 215
        Me.Label17.Text = "Date"
        '
        'txt_ref_date
        '
        Me.txt_ref_date.Enabled = False
        Me.txt_ref_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_ref_date.Location = New System.Drawing.Point(423, 11)
        Me.txt_ref_date.Name = "txt_ref_date"
        Me.txt_ref_date.Size = New System.Drawing.Size(200, 20)
        Me.txt_ref_date.TabIndex = 3
        Me.txt_ref_date.Value = New Date(2017, 6, 27, 0, 0, 0, 0)
        '
        'txt_nodays
        '
        Me.txt_nodays._Text = ""
        Me.txt_nodays.AllowNegative = False
        Me.txt_nodays.AlwaysDisable = True
        Me.txt_nodays.AlwaysEnable = False
        Me.txt_nodays.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_nodays.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_nodays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nodays.DataSource = ""
        Me.txt_nodays.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nodays.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_nodays.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_nodays.Enabled = False
        Me.txt_nodays.EnabledBackColor = System.Drawing.Color.White
        Me.txt_nodays.ispk = False
        Me.txt_nodays.Location = New System.Drawing.Point(274, 137)
        Me.txt_nodays.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nodays.MultiLine = False
        Me.txt_nodays.Name = "txt_nodays"
        Me.txt_nodays.NoClear = False
        Me.txt_nodays.NumberFormat = "##,##0"
        Me.txt_nodays.Required = True
        Me.txt_nodays.RowData = Nothing
        Me.txt_nodays.SelectionLength = 0
        Me.txt_nodays.SelectionStart = 0
        Me.txt_nodays.Size = New System.Drawing.Size(59, 20)
        Me.txt_nodays.TabIndex = 16
        Me.txt_nodays.TableData = Nothing
        Me.txt_nodays.TextSource = ""
        Me.txt_nodays.UseSystemPasswordChar = False
        Me.txt_nodays.Value = "0"
        Me.txt_nodays.ValueSource = "nodays"
        '
        'txt_based_rate
        '
        Me.txt_based_rate._Text = ""
        Me.txt_based_rate.AllowNegative = False
        Me.txt_based_rate.AlwaysDisable = False
        Me.txt_based_rate.AlwaysEnable = False
        Me.txt_based_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_based_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_based_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_based_rate.DataSource = ""
        Me.txt_based_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_based_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_based_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_based_rate.Enabled = False
        Me.txt_based_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_based_rate.ispk = False
        Me.txt_based_rate.Location = New System.Drawing.Point(558, 32)
        Me.txt_based_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_based_rate.MultiLine = False
        Me.txt_based_rate.Name = "txt_based_rate"
        Me.txt_based_rate.NoClear = True
        Me.txt_based_rate.NumberFormat = "##,##0.00"
        Me.txt_based_rate.Required = False
        Me.txt_based_rate.RowData = Nothing
        Me.txt_based_rate.SelectionLength = 0
        Me.txt_based_rate.SelectionStart = 0
        Me.txt_based_rate.Size = New System.Drawing.Size(65, 20)
        Me.txt_based_rate.TabIndex = 6
        Me.txt_based_rate.TableData = Nothing
        Me.txt_based_rate.Tag = ""
        Me.txt_based_rate.TextSource = ""
        Me.txt_based_rate.UseSystemPasswordChar = False
        Me.txt_based_rate.Value = "0.00"
        Me.txt_based_rate.ValueSource = "based_rate"
        '
        'txt_terms_id
        '
        Me.txt_terms_id._Text = ""
        Me.txt_terms_id.AllowNegative = False
        Me.txt_terms_id.AlwaysDisable = False
        Me.txt_terms_id.AlwaysEnable = False
        Me.txt_terms_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_terms_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_terms_id.DataSource = ""
        Me.txt_terms_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_terms_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_terms_id.Enabled = False
        Me.txt_terms_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_terms_id.ispk = False
        Me.txt_terms_id.Location = New System.Drawing.Point(133, 137)
        Me.txt_terms_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_terms_id.MultiLine = False
        Me.txt_terms_id.Name = "txt_terms_id"
        Me.txt_terms_id.NoClear = False
        Me.txt_terms_id.NumberFormat = "@"
        Me.txt_terms_id.Required = True
        Me.txt_terms_id.RowData = Nothing
        Me.txt_terms_id.SelectionLength = 0
        Me.txt_terms_id.SelectionStart = 0
        Me.txt_terms_id.Size = New System.Drawing.Size(140, 20)
        Me.txt_terms_id.TabIndex = 15
        Me.txt_terms_id.TableData = Nothing
        Me.txt_terms_id.TextSource = "terms_name"
        Me.txt_terms_id.UseSystemPasswordChar = False
        Me.txt_terms_id.Value = ""
        Me.txt_terms_id.ValueSource = "terms_id"
        '
        'txt_exchange_rate
        '
        Me.txt_exchange_rate._Text = ""
        Me.txt_exchange_rate.AllowNegative = False
        Me.txt_exchange_rate.AlwaysDisable = False
        Me.txt_exchange_rate.AlwaysEnable = False
        Me.txt_exchange_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_exchange_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_exchange_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_exchange_rate.DataSource = ""
        Me.txt_exchange_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_exchange_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_exchange_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_exchange_rate.Enabled = False
        Me.txt_exchange_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_exchange_rate.ispk = False
        Me.txt_exchange_rate.Location = New System.Drawing.Point(423, 32)
        Me.txt_exchange_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_exchange_rate.MultiLine = False
        Me.txt_exchange_rate.Name = "txt_exchange_rate"
        Me.txt_exchange_rate.NoClear = True
        Me.txt_exchange_rate.NumberFormat = "##,##0.00"
        Me.txt_exchange_rate.Required = False
        Me.txt_exchange_rate.RowData = Nothing
        Me.txt_exchange_rate.SelectionLength = 0
        Me.txt_exchange_rate.SelectionStart = 0
        Me.txt_exchange_rate.Size = New System.Drawing.Size(65, 20)
        Me.txt_exchange_rate.TabIndex = 5
        Me.txt_exchange_rate.TableData = Nothing
        Me.txt_exchange_rate.Tag = ""
        Me.txt_exchange_rate.TextSource = ""
        Me.txt_exchange_rate.UseSystemPasswordChar = False
        Me.txt_exchange_rate.Value = "0.00"
        Me.txt_exchange_rate.ValueSource = "exchange_rate"
        '
        'lbltermsdet
        '
        Me.lbltermsdet.AutoSize = True
        Me.lbltermsdet.Location = New System.Drawing.Point(94, 140)
        Me.lbltermsdet.Name = "lbltermsdet"
        Me.lbltermsdet.Size = New System.Drawing.Size(36, 13)
        Me.lbltermsdet.TabIndex = 213
        Me.lbltermsdet.Text = "Terms"
        '
        'txt_currency_name
        '
        Me.txt_currency_name._Text = ""
        Me.txt_currency_name.AllowNegative = False
        Me.txt_currency_name.AlwaysDisable = True
        Me.txt_currency_name.AlwaysEnable = False
        Me.txt_currency_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_name.DataSource = ""
        Me.txt_currency_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_name.Enabled = False
        Me.txt_currency_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_name.ispk = False
        Me.txt_currency_name.Location = New System.Drawing.Point(133, 32)
        Me.txt_currency_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_name.MultiLine = False
        Me.txt_currency_name.Name = "txt_currency_name"
        Me.txt_currency_name.NoClear = True
        Me.txt_currency_name.NumberFormat = "@"
        Me.txt_currency_name.Required = False
        Me.txt_currency_name.RowData = Nothing
        Me.txt_currency_name.SelectionLength = 0
        Me.txt_currency_name.SelectionStart = 0
        Me.txt_currency_name.Size = New System.Drawing.Size(200, 20)
        Me.txt_currency_name.TabIndex = 4
        Me.txt_currency_name.TableData = Nothing
        Me.txt_currency_name.Tag = ""
        Me.txt_currency_name.TextSource = "currency_name"
        Me.txt_currency_name.UseSystemPasswordChar = False
        Me.txt_currency_name.Value = ""
        Me.txt_currency_name.ValueSource = "currency_id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(492, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Based Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Exchange Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Currency"
        '
        'txt_jbooks_id
        '
        Me.txt_jbooks_id._Text = ""
        Me.txt_jbooks_id.AllowNegative = False
        Me.txt_jbooks_id.AlwaysDisable = True
        Me.txt_jbooks_id.AlwaysEnable = False
        Me.txt_jbooks_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_jbooks_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_jbooks_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jbooks_id.DataSource = ""
        Me.txt_jbooks_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_jbooks_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_jbooks_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_jbooks_id.Enabled = False
        Me.txt_jbooks_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_jbooks_id.ispk = False
        Me.txt_jbooks_id.Location = New System.Drawing.Point(53, 35)
        Me.txt_jbooks_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_jbooks_id.MultiLine = False
        Me.txt_jbooks_id.Name = "txt_jbooks_id"
        Me.txt_jbooks_id.NoClear = False
        Me.txt_jbooks_id.NumberFormat = "@"
        Me.txt_jbooks_id.Required = False
        Me.txt_jbooks_id.RowData = Nothing
        Me.txt_jbooks_id.SelectionLength = 0
        Me.txt_jbooks_id.SelectionStart = 0
        Me.txt_jbooks_id.Size = New System.Drawing.Size(39, 20)
        Me.txt_jbooks_id.TabIndex = 1
        Me.txt_jbooks_id.TableData = Nothing
        Me.txt_jbooks_id.TextSource = ""
        Me.txt_jbooks_id.UseSystemPasswordChar = False
        Me.txt_jbooks_id.Value = ""
        Me.txt_jbooks_id.ValueSource = ""
        Me.txt_jbooks_id.Visible = False
        '
        'txt_credit_based
        '
        Me.txt_credit_based._Text = ""
        Me.txt_credit_based.AllowNegative = True
        Me.txt_credit_based.AlwaysDisable = True
        Me.txt_credit_based.AlwaysEnable = False
        Me.txt_credit_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_credit_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_credit_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_credit_based.DataSource = ""
        Me.txt_credit_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_credit_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_credit_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_credit_based.Enabled = False
        Me.txt_credit_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_credit_based.ispk = False
        Me.txt_credit_based.Location = New System.Drawing.Point(423, 95)
        Me.txt_credit_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_credit_based.MultiLine = False
        Me.txt_credit_based.Name = "txt_credit_based"
        Me.txt_credit_based.NoClear = False
        Me.txt_credit_based.NumberFormat = "##,##0.00"
        Me.txt_credit_based.Required = False
        Me.txt_credit_based.RowData = Nothing
        Me.txt_credit_based.SelectionLength = 0
        Me.txt_credit_based.SelectionStart = 0
        Me.txt_credit_based.Size = New System.Drawing.Size(200, 20)
        Me.txt_credit_based.TabIndex = 12
        Me.txt_credit_based.TableData = Nothing
        Me.txt_credit_based.Tag = ""
        Me.txt_credit_based.TextSource = ""
        Me.txt_credit_based.UseSystemPasswordChar = False
        Me.txt_credit_based.Value = "0.00"
        Me.txt_credit_based.ValueSource = "credit_based"
        '
        'txt_debit_based
        '
        Me.txt_debit_based._Text = ""
        Me.txt_debit_based.AllowNegative = True
        Me.txt_debit_based.AlwaysDisable = True
        Me.txt_debit_based.AlwaysEnable = False
        Me.txt_debit_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_debit_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_debit_based.DataSource = ""
        Me.txt_debit_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_debit_based.Enabled = False
        Me.txt_debit_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_debit_based.ispk = False
        Me.txt_debit_based.Location = New System.Drawing.Point(423, 74)
        Me.txt_debit_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit_based.MultiLine = False
        Me.txt_debit_based.Name = "txt_debit_based"
        Me.txt_debit_based.NoClear = False
        Me.txt_debit_based.NumberFormat = "##,##0.00"
        Me.txt_debit_based.Required = False
        Me.txt_debit_based.RowData = Nothing
        Me.txt_debit_based.SelectionLength = 0
        Me.txt_debit_based.SelectionStart = 0
        Me.txt_debit_based.Size = New System.Drawing.Size(200, 20)
        Me.txt_debit_based.TabIndex = 10
        Me.txt_debit_based.TableData = Nothing
        Me.txt_debit_based.Tag = ""
        Me.txt_debit_based.TextSource = ""
        Me.txt_debit_based.UseSystemPasswordChar = False
        Me.txt_debit_based.Value = "0.00"
        Me.txt_debit_based.ValueSource = "debit_based"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(353, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Credit Based"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(355, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Debit Based"
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
        Me.txt_general_name.Location = New System.Drawing.Point(355, 116)
        Me.txt_general_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.MultiLine = False
        Me.txt_general_name.Name = "txt_general_name"
        Me.txt_general_name.NoClear = False
        Me.txt_general_name.NumberFormat = "@"
        Me.txt_general_name.Required = False
        Me.txt_general_name.RowData = Nothing
        Me.txt_general_name.SelectionLength = 0
        Me.txt_general_name.SelectionStart = 0
        Me.txt_general_name.Size = New System.Drawing.Size(268, 20)
        Me.txt_general_name.TabIndex = 14
        Me.txt_general_name.TableData = Nothing
        Me.txt_general_name.Tag = ""
        Me.txt_general_name.TextSource = "general_name"
        Me.txt_general_name.UseSystemPasswordChar = False
        Me.txt_general_name.Value = ""
        Me.txt_general_name.ValueSource = ""
        '
        'txt_general_id
        '
        Me.txt_general_id._Text = ""
        Me.txt_general_id.AllowNegative = False
        Me.txt_general_id.AlwaysDisable = False
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
        Me.txt_general_id.Location = New System.Drawing.Point(133, 116)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = True
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(200, 20)
        Me.txt_general_id.TabIndex = 13
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.Tag = ""
        Me.txt_general_id.TextSource = "general_code"
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = "general_id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(336, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = ">"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(86, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "GenRef"
        '
        'txt_credit
        '
        Me.txt_credit._Text = ""
        Me.txt_credit.AllowNegative = True
        Me.txt_credit.AlwaysDisable = True
        Me.txt_credit.AlwaysEnable = False
        Me.txt_credit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_credit.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_credit.DataSource = ""
        Me.txt_credit.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_credit.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_credit.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_credit.Enabled = False
        Me.txt_credit.EnabledBackColor = System.Drawing.Color.White
        Me.txt_credit.ispk = False
        Me.txt_credit.Location = New System.Drawing.Point(133, 95)
        Me.txt_credit.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_credit.MultiLine = False
        Me.txt_credit.Name = "txt_credit"
        Me.txt_credit.NoClear = False
        Me.txt_credit.NumberFormat = "##,##0.00"
        Me.txt_credit.Required = False
        Me.txt_credit.RowData = Nothing
        Me.txt_credit.SelectionLength = 0
        Me.txt_credit.SelectionStart = 0
        Me.txt_credit.Size = New System.Drawing.Size(200, 20)
        Me.txt_credit.TabIndex = 11
        Me.txt_credit.TableData = Nothing
        Me.txt_credit.Tag = ""
        Me.txt_credit.TextSource = ""
        Me.txt_credit.UseSystemPasswordChar = False
        Me.txt_credit.Value = "0.00"
        Me.txt_credit.ValueSource = "credit"
        '
        'txt_debit
        '
        Me.txt_debit._Text = ""
        Me.txt_debit.AllowNegative = True
        Me.txt_debit.AlwaysDisable = False
        Me.txt_debit.AlwaysEnable = False
        Me.txt_debit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_debit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_debit.DataSource = ""
        Me.txt_debit.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_debit.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_debit.Enabled = False
        Me.txt_debit.EnabledBackColor = System.Drawing.Color.White
        Me.txt_debit.ispk = False
        Me.txt_debit.Location = New System.Drawing.Point(133, 74)
        Me.txt_debit.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_debit.MultiLine = False
        Me.txt_debit.Name = "txt_debit"
        Me.txt_debit.NoClear = False
        Me.txt_debit.NumberFormat = "##,##0.00"
        Me.txt_debit.Required = False
        Me.txt_debit.RowData = Nothing
        Me.txt_debit.SelectionLength = 0
        Me.txt_debit.SelectionStart = 0
        Me.txt_debit.Size = New System.Drawing.Size(200, 20)
        Me.txt_debit.TabIndex = 9
        Me.txt_debit.TableData = Nothing
        Me.txt_debit.Tag = ""
        Me.txt_debit.TextSource = ""
        Me.txt_debit.UseSystemPasswordChar = False
        Me.txt_debit.Value = "0.00"
        Me.txt_debit.ValueSource = "debit"
        '
        'txt_ref_no
        '
        Me.txt_ref_no._Text = ""
        Me.txt_ref_no.AllowNegative = False
        Me.txt_ref_no.AlwaysDisable = False
        Me.txt_ref_no.AlwaysEnable = False
        Me.txt_ref_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_ref_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ref_no.DataSource = ""
        Me.txt_ref_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ref_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ref_no.Enabled = False
        Me.txt_ref_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_ref_no.ispk = False
        Me.txt_ref_no.Location = New System.Drawing.Point(133, 11)
        Me.txt_ref_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_no.MultiLine = False
        Me.txt_ref_no.Name = "txt_ref_no"
        Me.txt_ref_no.NoClear = False
        Me.txt_ref_no.NumberFormat = "@"
        Me.txt_ref_no.Required = False
        Me.txt_ref_no.RowData = Nothing
        Me.txt_ref_no.SelectionLength = 0
        Me.txt_ref_no.SelectionStart = 0
        Me.txt_ref_no.Size = New System.Drawing.Size(200, 20)
        Me.txt_ref_no.TabIndex = 2
        Me.txt_ref_no.TableData = Nothing
        Me.txt_ref_no.Tag = "focus"
        Me.txt_ref_no.TextSource = "ref_no"
        Me.txt_ref_no.UseSystemPasswordChar = False
        Me.txt_ref_no.Value = ""
        Me.txt_ref_no.ValueSource = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(96, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Credit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(98, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Debit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(53, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Reference No."
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 282)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 7
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 282)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txt_total_based
        '
        Me.txt_total_based._Text = ""
        Me.txt_total_based.AllowNegative = False
        Me.txt_total_based.AlwaysDisable = True
        Me.txt_total_based.AlwaysEnable = False
        Me.txt_total_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_total_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_based.DataSource = ""
        Me.txt_total_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total_based.Enabled = False
        Me.txt_total_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_total_based.ispk = False
        Me.txt_total_based.Location = New System.Drawing.Point(353, 282)
        Me.txt_total_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_based.MultiLine = False
        Me.txt_total_based.Name = "txt_total_based"
        Me.txt_total_based.NoClear = False
        Me.txt_total_based.NumberFormat = "##,##0.00"
        Me.txt_total_based.Required = False
        Me.txt_total_based.RowData = Nothing
        Me.txt_total_based.SelectionLength = 0
        Me.txt_total_based.SelectionStart = 0
        Me.txt_total_based.Size = New System.Drawing.Size(105, 23)
        Me.txt_total_based.TabIndex = 2
        Me.txt_total_based.TableData = Nothing
        Me.txt_total_based.TextSource = ""
        Me.txt_total_based.UseSystemPasswordChar = False
        Me.txt_total_based.Value = "0.00"
        Me.txt_total_based.ValueSource = ""
        Me.txt_total_based.Visible = False
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.jbooks_id, Me.ref_no, Me.general_name, Me.debit, Me.status, Me.minimum})
        Me.dgMain.Location = New System.Drawing.Point(12, 126)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(676, 150)
        Me.dgMain.TabIndex = 202
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Width = 30
        '
        'jbooks_id
        '
        Me.jbooks_id.DataPropertyName = "jbooks_id"
        Me.jbooks_id.HeaderText = "ID"
        Me.jbooks_id.Name = "jbooks_id"
        Me.jbooks_id.Visible = False
        '
        'ref_no
        '
        Me.ref_no.DataPropertyName = "ref_no"
        Me.ref_no.HeaderText = "Reference No."
        Me.ref_no.Name = "ref_no"
        Me.ref_no.ReadOnly = True
        '
        'general_name
        '
        Me.general_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Client"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        '
        'debit
        '
        Me.debit.DataPropertyName = "debit"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "##,##0.00"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle1
        Me.debit.HeaderText = "Amount"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        Me.debit.Width = 120
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 120
        '
        'minimum
        '
        Me.minimum.DataPropertyName = "minimum"
        Me.minimum.HeaderText = "minimum"
        Me.minimum.Name = "minimum"
        Me.minimum.Visible = False
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.ForeColor = System.Drawing.Color.White
        Me.btnViewDetails.Location = New System.Drawing.Point(573, 282)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(115, 24)
        Me.btnViewDetails.TabIndex = 206
        Me.btnViewDetails.Tag = "btnViewDetails"
        Me.btnViewDetails.Text = "F6 View Schedule"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(184, 282)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(98, 282)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(12, 282)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(426, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 208
        Me.Label9.Text = "Total"
        '
        'txt_total_amount
        '
        Me.txt_total_amount._Text = ""
        Me.txt_total_amount.AllowNegative = False
        Me.txt_total_amount.AlwaysDisable = True
        Me.txt_total_amount.AlwaysEnable = False
        Me.txt_total_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_amount.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_total_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_amount.DataSource = ""
        Me.txt_total_amount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_amount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_amount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total_amount.Enabled = False
        Me.txt_total_amount.EnabledBackColor = System.Drawing.Color.White
        Me.txt_total_amount.ispk = False
        Me.txt_total_amount.Location = New System.Drawing.Point(460, 282)
        Me.txt_total_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_amount.MultiLine = False
        Me.txt_total_amount.Name = "txt_total_amount"
        Me.txt_total_amount.NoClear = False
        Me.txt_total_amount.NumberFormat = "##,##0.00"
        Me.txt_total_amount.Required = False
        Me.txt_total_amount.RowData = Nothing
        Me.txt_total_amount.SelectionLength = 0
        Me.txt_total_amount.SelectionStart = 0
        Me.txt_total_amount.Size = New System.Drawing.Size(107, 20)
        Me.txt_total_amount.TabIndex = 207
        Me.txt_total_amount.TableData = Nothing
        Me.txt_total_amount.TextSource = ""
        Me.txt_total_amount.UseSystemPasswordChar = False
        Me.txt_total_amount.Value = "0.00"
        Me.txt_total_amount.ValueSource = ""
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(700, 28)
        Me.Myformheader1.TabIndex = 213
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(270, 282)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 214
        Me.btnPrint.Tag = "btnRemove"
        Me.btnPrint.Text = "F5 Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(15, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(670, 2)
        Me.border1.TabIndex = 90
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'begbal_ar_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 490)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_total_amount)
        Me.Controls.Add(Me.panel_hdr)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.txt_total_based)
        Me.Controls.Add(Me.btnInsert)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "begbal_ar_detail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receivable Beginning balance - Details"
        Me.panel_hdr.ResumeLayout(False)
        Me.panel_hdr.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panel_hdr As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_department As user_control.textbox
    Friend WithEvents txt_account_name As user_control.textbox
    Friend WithEvents txt_project As user_control.textbox
    Friend WithEvents txt_account As user_control.textbox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_jbooks_id As user_control.textbox
    Friend WithEvents txt_credit_based As user_control.textbox
    Friend WithEvents txt_debit_based As user_control.textbox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_general_name As user_control.textbox
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_credit As user_control.textbox
    Friend WithEvents txt_debit As user_control.textbox
    Friend WithEvents txt_ref_no As user_control.textbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txt_total_based As user_control.textbox
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_total_amount As user_control.textbox
    Friend WithEvents txt_based_rate As user_control.textbox
    Friend WithEvents txt_exchange_rate As user_control.textbox
    Friend WithEvents txt_currency_name As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nodays As user_control.textbox
    Friend WithEvents txt_terms_id As user_control.textbox
    Friend WithEvents lbltermsdet As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txt_ref_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents jbooks_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minimum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_po_no As user_control.textbox
    Friend WithEvents txt_dr_no As user_control.textbox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_unit_id As user_control.textbox
    Friend WithEvents lblUnit As Windows.Forms.Label
End Class
