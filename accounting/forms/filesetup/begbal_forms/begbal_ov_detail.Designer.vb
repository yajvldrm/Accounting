<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class begbal_ov_detail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(begbal_ov_detail))
        Me.txt_based_rate = New user_control.textbox()
        Me.txt_exchange_rate = New user_control.textbox()
        Me.txt_currency_id = New user_control.textbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_output_vat_id = New user_control.textbox()
        Me.txt_vat_amount_based = New user_control.textbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_net_amount_based = New user_control.textbox()
        Me.txt_gross_amount_based = New user_control.textbox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_total_based = New user_control.textbox()
        Me.txt_vat_type = New System.Windows.Forms.Panel()
        Me.Rdo_button2 = New user_control.rdo_button()
        Me.Rdo_button1 = New user_control.rdo_button()
        Me.txt_address = New user_control.textbox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_tin = New user_control.textbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.output_vat_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gross_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vat_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.net_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_net_amount = New user_control.textbox()
        Me.txt_gross_amount = New user_control.textbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_general_id = New user_control.textbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_vat_amount = New user_control.textbox()
        Me.txt_vat_rate = New user_control.textbox()
        Me.txt_ref_no = New user_control.textbox()
        Me.txt_total_vat = New user_control.textbox()
        Me.txt_total_net = New user_control.textbox()
        Me.txt_total_amount = New user_control.textbox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_unit_id = New user_control.textbox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_department = New user_control.textbox()
        Me.txt_account_name = New user_control.textbox()
        Me.txt_project = New user_control.textbox()
        Me.txt_account = New user_control.textbox()
        Me.txt_total_gross = New user_control.textbox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panel_hdr = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.txt_vat_type.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panel_hdr.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txt_based_rate.Location = New System.Drawing.Point(624, 32)
        Me.txt_based_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_based_rate.MultiLine = False
        Me.txt_based_rate.Name = "txt_based_rate"
        Me.txt_based_rate.NoClear = True
        Me.txt_based_rate.NumberFormat = "##,##0.00"
        Me.txt_based_rate.Required = False
        Me.txt_based_rate.RowData = Nothing
        Me.txt_based_rate.SelectionLength = 0
        Me.txt_based_rate.SelectionStart = 0
        Me.txt_based_rate.Size = New System.Drawing.Size(150, 20)
        Me.txt_based_rate.TabIndex = 8
        Me.txt_based_rate.TableData = Nothing
        Me.txt_based_rate.Tag = ""
        Me.txt_based_rate.TextSource = ""
        Me.txt_based_rate.UseSystemPasswordChar = False
        Me.txt_based_rate.Value = "0.00"
        Me.txt_based_rate.ValueSource = ""
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
        Me.txt_exchange_rate.Location = New System.Drawing.Point(366, 31)
        Me.txt_exchange_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_exchange_rate.MultiLine = False
        Me.txt_exchange_rate.Name = "txt_exchange_rate"
        Me.txt_exchange_rate.NoClear = True
        Me.txt_exchange_rate.NumberFormat = "##,##0.00"
        Me.txt_exchange_rate.Required = False
        Me.txt_exchange_rate.RowData = Nothing
        Me.txt_exchange_rate.SelectionLength = 0
        Me.txt_exchange_rate.SelectionStart = 0
        Me.txt_exchange_rate.Size = New System.Drawing.Size(150, 20)
        Me.txt_exchange_rate.TabIndex = 7
        Me.txt_exchange_rate.TableData = Nothing
        Me.txt_exchange_rate.Tag = ""
        Me.txt_exchange_rate.TextSource = ""
        Me.txt_exchange_rate.UseSystemPasswordChar = False
        Me.txt_exchange_rate.Value = "0.00"
        Me.txt_exchange_rate.ValueSource = ""
        '
        'txt_currency_id
        '
        Me.txt_currency_id._Text = ""
        Me.txt_currency_id.AllowNegative = False
        Me.txt_currency_id.AlwaysDisable = True
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.DataSource = ""
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.Enabled = False
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.ispk = False
        Me.txt_currency_id.Location = New System.Drawing.Point(108, 31)
        Me.txt_currency_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.MultiLine = False
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = True
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.SelectionLength = 0
        Me.txt_currency_id.SelectionStart = 0
        Me.txt_currency_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_currency_id.TabIndex = 6
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.Tag = ""
        Me.txt_currency_id.TextSource = "currency_name"
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = "currency_id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(558, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "Based Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 183
        Me.Label6.Text = "Exchange Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 182
        Me.Label4.Text = "Currency"
        '
        'txt_output_vat_id
        '
        Me.txt_output_vat_id._Text = ""
        Me.txt_output_vat_id.AllowNegative = False
        Me.txt_output_vat_id.AlwaysDisable = True
        Me.txt_output_vat_id.AlwaysEnable = False
        Me.txt_output_vat_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_output_vat_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_output_vat_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_output_vat_id.DataSource = ""
        Me.txt_output_vat_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_output_vat_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_output_vat_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_output_vat_id.Enabled = False
        Me.txt_output_vat_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_output_vat_id.ispk = False
        Me.txt_output_vat_id.Location = New System.Drawing.Point(522, 10)
        Me.txt_output_vat_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_output_vat_id.MultiLine = False
        Me.txt_output_vat_id.Name = "txt_output_vat_id"
        Me.txt_output_vat_id.NoClear = False
        Me.txt_output_vat_id.NumberFormat = "@"
        Me.txt_output_vat_id.Required = False
        Me.txt_output_vat_id.RowData = Nothing
        Me.txt_output_vat_id.SelectionLength = 0
        Me.txt_output_vat_id.SelectionStart = 0
        Me.txt_output_vat_id.Size = New System.Drawing.Size(96, 20)
        Me.txt_output_vat_id.TabIndex = 1
        Me.txt_output_vat_id.TableData = Nothing
        Me.txt_output_vat_id.TextSource = ""
        Me.txt_output_vat_id.UseSystemPasswordChar = False
        Me.txt_output_vat_id.Value = ""
        Me.txt_output_vat_id.ValueSource = ""
        Me.txt_output_vat_id.Visible = False
        '
        'txt_vat_amount_based
        '
        Me.txt_vat_amount_based._Text = ""
        Me.txt_vat_amount_based.AllowNegative = False
        Me.txt_vat_amount_based.AlwaysDisable = True
        Me.txt_vat_amount_based.AlwaysEnable = False
        Me.txt_vat_amount_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_vat_amount_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_vat_amount_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vat_amount_based.DataSource = ""
        Me.txt_vat_amount_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_vat_amount_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_vat_amount_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_vat_amount_based.Enabled = False
        Me.txt_vat_amount_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_vat_amount_based.ispk = False
        Me.txt_vat_amount_based.Location = New System.Drawing.Point(366, 115)
        Me.txt_vat_amount_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_vat_amount_based.MultiLine = False
        Me.txt_vat_amount_based.Name = "txt_vat_amount_based"
        Me.txt_vat_amount_based.NoClear = False
        Me.txt_vat_amount_based.NumberFormat = "##,##0.00"
        Me.txt_vat_amount_based.Required = False
        Me.txt_vat_amount_based.RowData = Nothing
        Me.txt_vat_amount_based.SelectionLength = 0
        Me.txt_vat_amount_based.SelectionStart = 0
        Me.txt_vat_amount_based.Size = New System.Drawing.Size(150, 20)
        Me.txt_vat_amount_based.TabIndex = 17
        Me.txt_vat_amount_based.TableData = Nothing
        Me.txt_vat_amount_based.Tag = ""
        Me.txt_vat_amount_based.TextSource = ""
        Me.txt_vat_amount_based.UseSystemPasswordChar = False
        Me.txt_vat_amount_based.Value = "0.00"
        Me.txt_vat_amount_based.ValueSource = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(263, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "VAT Amount Based"
        '
        'txt_net_amount_based
        '
        Me.txt_net_amount_based._Text = ""
        Me.txt_net_amount_based.AllowNegative = False
        Me.txt_net_amount_based.AlwaysDisable = True
        Me.txt_net_amount_based.AlwaysEnable = False
        Me.txt_net_amount_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_net_amount_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_net_amount_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_net_amount_based.DataSource = ""
        Me.txt_net_amount_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_net_amount_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_net_amount_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_net_amount_based.Enabled = False
        Me.txt_net_amount_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_net_amount_based.ispk = False
        Me.txt_net_amount_based.Location = New System.Drawing.Point(624, 116)
        Me.txt_net_amount_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_net_amount_based.MultiLine = False
        Me.txt_net_amount_based.Name = "txt_net_amount_based"
        Me.txt_net_amount_based.NoClear = False
        Me.txt_net_amount_based.NumberFormat = "##,##0.00"
        Me.txt_net_amount_based.Required = False
        Me.txt_net_amount_based.RowData = Nothing
        Me.txt_net_amount_based.SelectionLength = 0
        Me.txt_net_amount_based.SelectionStart = 0
        Me.txt_net_amount_based.Size = New System.Drawing.Size(150, 20)
        Me.txt_net_amount_based.TabIndex = 18
        Me.txt_net_amount_based.TableData = Nothing
        Me.txt_net_amount_based.Tag = ""
        Me.txt_net_amount_based.TextSource = ""
        Me.txt_net_amount_based.UseSystemPasswordChar = False
        Me.txt_net_amount_based.Value = "0.00"
        Me.txt_net_amount_based.ValueSource = ""
        '
        'txt_gross_amount_based
        '
        Me.txt_gross_amount_based._Text = ""
        Me.txt_gross_amount_based.AllowNegative = False
        Me.txt_gross_amount_based.AlwaysDisable = True
        Me.txt_gross_amount_based.AlwaysEnable = False
        Me.txt_gross_amount_based.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_gross_amount_based.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_gross_amount_based.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_gross_amount_based.DataSource = ""
        Me.txt_gross_amount_based.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_gross_amount_based.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_gross_amount_based.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_gross_amount_based.Enabled = False
        Me.txt_gross_amount_based.EnabledBackColor = System.Drawing.Color.White
        Me.txt_gross_amount_based.ispk = False
        Me.txt_gross_amount_based.Location = New System.Drawing.Point(108, 115)
        Me.txt_gross_amount_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_gross_amount_based.MultiLine = False
        Me.txt_gross_amount_based.Name = "txt_gross_amount_based"
        Me.txt_gross_amount_based.NoClear = False
        Me.txt_gross_amount_based.NumberFormat = "##,##0.00"
        Me.txt_gross_amount_based.Required = False
        Me.txt_gross_amount_based.RowData = Nothing
        Me.txt_gross_amount_based.SelectionLength = 0
        Me.txt_gross_amount_based.SelectionStart = 0
        Me.txt_gross_amount_based.Size = New System.Drawing.Size(150, 20)
        Me.txt_gross_amount_based.TabIndex = 16
        Me.txt_gross_amount_based.TableData = Nothing
        Me.txt_gross_amount_based.Tag = ""
        Me.txt_gross_amount_based.TextSource = ""
        Me.txt_gross_amount_based.UseSystemPasswordChar = False
        Me.txt_gross_amount_based.Value = "0.00"
        Me.txt_gross_amount_based.ValueSource = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(534, 119)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Net Sales Based"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Gross Sales Based"
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
        Me.txt_total_based.Location = New System.Drawing.Point(267, 282)
        Me.txt_total_based.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_based.MultiLine = False
        Me.txt_total_based.Name = "txt_total_based"
        Me.txt_total_based.NoClear = False
        Me.txt_total_based.NumberFormat = "##,##0.00"
        Me.txt_total_based.Required = False
        Me.txt_total_based.RowData = Nothing
        Me.txt_total_based.SelectionLength = 0
        Me.txt_total_based.SelectionStart = 0
        Me.txt_total_based.Size = New System.Drawing.Size(10, 23)
        Me.txt_total_based.TabIndex = 218
        Me.txt_total_based.TableData = Nothing
        Me.txt_total_based.TextSource = ""
        Me.txt_total_based.UseSystemPasswordChar = False
        Me.txt_total_based.Value = "0.00"
        Me.txt_total_based.ValueSource = ""
        Me.txt_total_based.Visible = False
        '
        'txt_vat_type
        '
        Me.txt_vat_type.Controls.Add(Me.Rdo_button2)
        Me.txt_vat_type.Controls.Add(Me.Rdo_button1)
        Me.txt_vat_type.Location = New System.Drawing.Point(624, 10)
        Me.txt_vat_type.Name = "txt_vat_type"
        Me.txt_vat_type.Size = New System.Drawing.Size(150, 20)
        Me.txt_vat_type.TabIndex = 3
        Me.txt_vat_type.Tag = "container"
        '
        'Rdo_button2
        '
        Me.Rdo_button2.AutoSize = True
        Me.Rdo_button2.DataSource = ""
        Me.Rdo_button2.Location = New System.Drawing.Point(77, 2)
        Me.Rdo_button2.Name = "Rdo_button2"
        Me.Rdo_button2.Size = New System.Drawing.Size(70, 17)
        Me.Rdo_button2.TabIndex = 5
        Me.Rdo_button2.Text = "Exclusive"
        Me.Rdo_button2.TextSource = ""
        Me.Rdo_button2.Uncheckable = False
        Me.Rdo_button2.UseVisualStyleBackColor = True
        Me.Rdo_button2.Value = "2"
        Me.Rdo_button2.ValueSource = ""
        '
        'Rdo_button1
        '
        Me.Rdo_button1.AutoSize = True
        Me.Rdo_button1.Checked = True
        Me.Rdo_button1.DataSource = ""
        Me.Rdo_button1.Location = New System.Drawing.Point(4, 2)
        Me.Rdo_button1.Name = "Rdo_button1"
        Me.Rdo_button1.Size = New System.Drawing.Size(67, 17)
        Me.Rdo_button1.TabIndex = 4
        Me.Rdo_button1.TabStop = True
        Me.Rdo_button1.Text = "Inclusive"
        Me.Rdo_button1.TextSource = ""
        Me.Rdo_button1.Uncheckable = False
        Me.Rdo_button1.UseVisualStyleBackColor = True
        Me.Rdo_button1.Value = "1"
        Me.Rdo_button1.ValueSource = ""
        '
        'txt_address
        '
        Me.txt_address._Text = ""
        Me.txt_address.AllowNegative = False
        Me.txt_address.AlwaysDisable = True
        Me.txt_address.AlwaysEnable = False
        Me.txt_address.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address.DataSource = ""
        Me.txt_address.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_address.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_address.Enabled = False
        Me.txt_address.EnabledBackColor = System.Drawing.Color.White
        Me.txt_address.ispk = False
        Me.txt_address.Location = New System.Drawing.Point(108, 73)
        Me.txt_address.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_address.MultiLine = False
        Me.txt_address.Name = "txt_address"
        Me.txt_address.NoClear = False
        Me.txt_address.NumberFormat = "@"
        Me.txt_address.Required = False
        Me.txt_address.RowData = Nothing
        Me.txt_address.SelectionLength = 0
        Me.txt_address.SelectionStart = 0
        Me.txt_address.Size = New System.Drawing.Size(408, 20)
        Me.txt_address.TabIndex = 11
        Me.txt_address.TableData = Nothing
        Me.txt_address.Tag = ""
        Me.txt_address.TextSource = ""
        Me.txt_address.UseSystemPasswordChar = False
        Me.txt_address.Value = ""
        Me.txt_address.ValueSource = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Client's Address"
        '
        'txt_tin
        '
        Me.txt_tin._Text = ""
        Me.txt_tin.AllowNegative = False
        Me.txt_tin.AlwaysDisable = True
        Me.txt_tin.AlwaysEnable = False
        Me.txt_tin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tin.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_tin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tin.DataSource = ""
        Me.txt_tin.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tin.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_tin.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_tin.Enabled = False
        Me.txt_tin.EnabledBackColor = System.Drawing.Color.White
        Me.txt_tin.ispk = False
        Me.txt_tin.Location = New System.Drawing.Point(624, 53)
        Me.txt_tin.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_tin.MultiLine = False
        Me.txt_tin.Name = "txt_tin"
        Me.txt_tin.NoClear = False
        Me.txt_tin.NumberFormat = "@"
        Me.txt_tin.Required = False
        Me.txt_tin.RowData = Nothing
        Me.txt_tin.SelectionLength = 0
        Me.txt_tin.SelectionStart = 0
        Me.txt_tin.Size = New System.Drawing.Size(150, 20)
        Me.txt_tin.TabIndex = 10
        Me.txt_tin.TableData = Nothing
        Me.txt_tin.Tag = ""
        Me.txt_tin.TextSource = ""
        Me.txt_tin.UseSystemPasswordChar = False
        Me.txt_tin.Value = ""
        Me.txt_tin.ValueSource = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(557, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Client's TIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(294, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 215
        Me.Label9.Text = "Total"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(12, 282)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 209
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(98, 282)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 210
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.output_vat_id, Me.ref_no, Me.general_name, Me.gross_amount, Me.vat_amount, Me.net_amount, Me.status, Me.deleted, Me.minimum})
        Me.dgMain.Location = New System.Drawing.Point(12, 126)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(778, 150)
        Me.dgMain.TabIndex = 208
        Me.dgMain.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Width = 30
        '
        'output_vat_id
        '
        Me.output_vat_id.DataPropertyName = "output_vat_id"
        Me.output_vat_id.HeaderText = "ID"
        Me.output_vat_id.Name = "output_vat_id"
        Me.output_vat_id.ReadOnly = True
        Me.output_vat_id.Visible = False
        '
        'ref_no
        '
        Me.ref_no.DataPropertyName = "ref_no"
        Me.ref_no.HeaderText = "Reference No."
        Me.ref_no.Name = "ref_no"
        Me.ref_no.ReadOnly = True
        Me.ref_no.Width = 150
        '
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Supplier's Name"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        Me.general_name.Width = 200
        '
        'gross_amount
        '
        Me.gross_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.gross_amount.DataPropertyName = "gross_amount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "##,##0.00"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.gross_amount.DefaultCellStyle = DataGridViewCellStyle1
        Me.gross_amount.HeaderText = "Gross Purchases"
        Me.gross_amount.Name = "gross_amount"
        Me.gross_amount.ReadOnly = True
        '
        'vat_amount
        '
        Me.vat_amount.DataPropertyName = "vat_amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "##,##0.00"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.vat_amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.vat_amount.HeaderText = "VAT Amount"
        Me.vat_amount.Name = "vat_amount"
        Me.vat_amount.ReadOnly = True
        Me.vat_amount.Width = 120
        '
        'net_amount
        '
        Me.net_amount.DataPropertyName = "net_amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "##,##0.00"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.net_amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.net_amount.HeaderText = "Net Purchases"
        Me.net_amount.Name = "net_amount"
        Me.net_amount.ReadOnly = True
        Me.net_amount.Width = 120
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Visible = False
        '
        'minimum
        '
        Me.minimum.DataPropertyName = "minimum"
        Me.minimum.HeaderText = "minimum"
        Me.minimum.Name = "minimum"
        Me.minimum.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 25)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Output VAT Beginning Balance - Schedule"
        '
        'txt_net_amount
        '
        Me.txt_net_amount._Text = ""
        Me.txt_net_amount.AllowNegative = False
        Me.txt_net_amount.AlwaysDisable = True
        Me.txt_net_amount.AlwaysEnable = False
        Me.txt_net_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_net_amount.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_net_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_net_amount.DataSource = ""
        Me.txt_net_amount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_net_amount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_net_amount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_net_amount.Enabled = False
        Me.txt_net_amount.EnabledBackColor = System.Drawing.Color.White
        Me.txt_net_amount.ispk = False
        Me.txt_net_amount.Location = New System.Drawing.Point(624, 95)
        Me.txt_net_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_net_amount.MultiLine = False
        Me.txt_net_amount.Name = "txt_net_amount"
        Me.txt_net_amount.NoClear = False
        Me.txt_net_amount.NumberFormat = "##,##0.00"
        Me.txt_net_amount.Required = False
        Me.txt_net_amount.RowData = Nothing
        Me.txt_net_amount.SelectionLength = 0
        Me.txt_net_amount.SelectionStart = 0
        Me.txt_net_amount.Size = New System.Drawing.Size(150, 20)
        Me.txt_net_amount.TabIndex = 15
        Me.txt_net_amount.TableData = Nothing
        Me.txt_net_amount.Tag = ""
        Me.txt_net_amount.TextSource = ""
        Me.txt_net_amount.UseSystemPasswordChar = False
        Me.txt_net_amount.Value = "0.00"
        Me.txt_net_amount.ValueSource = ""
        '
        'txt_gross_amount
        '
        Me.txt_gross_amount._Text = ""
        Me.txt_gross_amount.AllowNegative = False
        Me.txt_gross_amount.AlwaysDisable = False
        Me.txt_gross_amount.AlwaysEnable = False
        Me.txt_gross_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_gross_amount.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_gross_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_gross_amount.DataSource = ""
        Me.txt_gross_amount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_gross_amount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_gross_amount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_gross_amount.Enabled = False
        Me.txt_gross_amount.EnabledBackColor = System.Drawing.Color.White
        Me.txt_gross_amount.ispk = False
        Me.txt_gross_amount.Location = New System.Drawing.Point(108, 94)
        Me.txt_gross_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_gross_amount.MultiLine = False
        Me.txt_gross_amount.Name = "txt_gross_amount"
        Me.txt_gross_amount.NoClear = False
        Me.txt_gross_amount.NumberFormat = "##,##0.00"
        Me.txt_gross_amount.Required = False
        Me.txt_gross_amount.RowData = Nothing
        Me.txt_gross_amount.SelectionLength = 0
        Me.txt_gross_amount.SelectionStart = 0
        Me.txt_gross_amount.Size = New System.Drawing.Size(150, 20)
        Me.txt_gross_amount.TabIndex = 13
        Me.txt_gross_amount.TableData = Nothing
        Me.txt_gross_amount.Tag = ""
        Me.txt_gross_amount.TextSource = ""
        Me.txt_gross_amount.UseSystemPasswordChar = False
        Me.txt_gross_amount.Value = "0.00"
        Me.txt_gross_amount.ValueSource = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(568, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Net Sales"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(41, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Gross Sales"
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
        Me.txt_general_id.Location = New System.Drawing.Point(108, 52)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(408, 20)
        Me.txt_general_id.TabIndex = 9
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.Tag = ""
        Me.txt_general_id.TextSource = "general_name"
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = "general_id"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Client's Name"
        '
        'txt_vat_amount
        '
        Me.txt_vat_amount._Text = ""
        Me.txt_vat_amount.AllowNegative = False
        Me.txt_vat_amount.AlwaysDisable = True
        Me.txt_vat_amount.AlwaysEnable = False
        Me.txt_vat_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_vat_amount.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_vat_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vat_amount.DataSource = ""
        Me.txt_vat_amount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_vat_amount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_vat_amount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_vat_amount.Enabled = False
        Me.txt_vat_amount.EnabledBackColor = System.Drawing.Color.White
        Me.txt_vat_amount.ispk = False
        Me.txt_vat_amount.Location = New System.Drawing.Point(366, 94)
        Me.txt_vat_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_vat_amount.MultiLine = False
        Me.txt_vat_amount.Name = "txt_vat_amount"
        Me.txt_vat_amount.NoClear = False
        Me.txt_vat_amount.NumberFormat = "##,##0.00"
        Me.txt_vat_amount.Required = False
        Me.txt_vat_amount.RowData = Nothing
        Me.txt_vat_amount.SelectionLength = 0
        Me.txt_vat_amount.SelectionStart = 0
        Me.txt_vat_amount.Size = New System.Drawing.Size(150, 20)
        Me.txt_vat_amount.TabIndex = 14
        Me.txt_vat_amount.TableData = Nothing
        Me.txt_vat_amount.Tag = ""
        Me.txt_vat_amount.TextSource = ""
        Me.txt_vat_amount.UseSystemPasswordChar = False
        Me.txt_vat_amount.Value = "0.00"
        Me.txt_vat_amount.ValueSource = ""
        '
        'txt_vat_rate
        '
        Me.txt_vat_rate._Text = ""
        Me.txt_vat_rate.AllowNegative = False
        Me.txt_vat_rate.AlwaysDisable = True
        Me.txt_vat_rate.AlwaysEnable = False
        Me.txt_vat_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_vat_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_vat_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vat_rate.DataSource = ""
        Me.txt_vat_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_vat_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_vat_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_vat_rate.Enabled = False
        Me.txt_vat_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_vat_rate.ispk = False
        Me.txt_vat_rate.Location = New System.Drawing.Point(624, 74)
        Me.txt_vat_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_vat_rate.MultiLine = False
        Me.txt_vat_rate.Name = "txt_vat_rate"
        Me.txt_vat_rate.NoClear = True
        Me.txt_vat_rate.NumberFormat = "##,##0.00"
        Me.txt_vat_rate.Required = False
        Me.txt_vat_rate.RowData = Nothing
        Me.txt_vat_rate.SelectionLength = 0
        Me.txt_vat_rate.SelectionStart = 0
        Me.txt_vat_rate.Size = New System.Drawing.Size(150, 20)
        Me.txt_vat_rate.TabIndex = 12
        Me.txt_vat_rate.TableData = Nothing
        Me.txt_vat_rate.Tag = ""
        Me.txt_vat_rate.TextSource = ""
        Me.txt_vat_rate.UseSystemPasswordChar = False
        Me.txt_vat_rate.Value = "0.00"
        Me.txt_vat_rate.ValueSource = ""
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
        Me.txt_ref_no.Location = New System.Drawing.Point(108, 10)
        Me.txt_ref_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ref_no.MultiLine = False
        Me.txt_ref_no.Name = "txt_ref_no"
        Me.txt_ref_no.NoClear = False
        Me.txt_ref_no.NumberFormat = "@"
        Me.txt_ref_no.Required = False
        Me.txt_ref_no.RowData = Nothing
        Me.txt_ref_no.SelectionLength = 0
        Me.txt_ref_no.SelectionStart = 0
        Me.txt_ref_no.Size = New System.Drawing.Size(150, 20)
        Me.txt_ref_no.TabIndex = 2
        Me.txt_ref_no.TableData = Nothing
        Me.txt_ref_no.Tag = "focus"
        Me.txt_ref_no.TextSource = ""
        Me.txt_ref_no.UseSystemPasswordChar = False
        Me.txt_ref_no.Value = ""
        Me.txt_ref_no.ValueSource = ""
        '
        'txt_total_vat
        '
        Me.txt_total_vat._Text = ""
        Me.txt_total_vat.AllowNegative = False
        Me.txt_total_vat.AlwaysDisable = True
        Me.txt_total_vat.AlwaysEnable = False
        Me.txt_total_vat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_vat.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_total_vat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_vat.DataSource = ""
        Me.txt_total_vat.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_vat.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_vat.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total_vat.Enabled = False
        Me.txt_total_vat.EnabledBackColor = System.Drawing.Color.White
        Me.txt_total_vat.ispk = False
        Me.txt_total_vat.Location = New System.Drawing.Point(434, 285)
        Me.txt_total_vat.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_vat.MultiLine = False
        Me.txt_total_vat.Name = "txt_total_vat"
        Me.txt_total_vat.NoClear = False
        Me.txt_total_vat.NumberFormat = "##,##0.00"
        Me.txt_total_vat.Required = False
        Me.txt_total_vat.RowData = Nothing
        Me.txt_total_vat.SelectionLength = 0
        Me.txt_total_vat.SelectionStart = 0
        Me.txt_total_vat.Size = New System.Drawing.Size(100, 20)
        Me.txt_total_vat.TabIndex = 220
        Me.txt_total_vat.TableData = Nothing
        Me.txt_total_vat.TextSource = ""
        Me.txt_total_vat.UseSystemPasswordChar = False
        Me.txt_total_vat.Value = "0.00"
        Me.txt_total_vat.ValueSource = ""
        '
        'txt_total_net
        '
        Me.txt_total_net._Text = ""
        Me.txt_total_net.AllowNegative = False
        Me.txt_total_net.AlwaysDisable = True
        Me.txt_total_net.AlwaysEnable = False
        Me.txt_total_net.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_net.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_total_net.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_net.DataSource = ""
        Me.txt_total_net.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_net.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_net.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total_net.Enabled = False
        Me.txt_total_net.EnabledBackColor = System.Drawing.Color.White
        Me.txt_total_net.ispk = False
        Me.txt_total_net.Location = New System.Drawing.Point(540, 285)
        Me.txt_total_net.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_net.MultiLine = False
        Me.txt_total_net.Name = "txt_total_net"
        Me.txt_total_net.NoClear = False
        Me.txt_total_net.NumberFormat = "##,##0.00"
        Me.txt_total_net.Required = False
        Me.txt_total_net.RowData = Nothing
        Me.txt_total_net.SelectionLength = 0
        Me.txt_total_net.SelectionStart = 0
        Me.txt_total_net.Size = New System.Drawing.Size(100, 20)
        Me.txt_total_net.TabIndex = 219
        Me.txt_total_net.TableData = Nothing
        Me.txt_total_net.TextSource = ""
        Me.txt_total_net.UseSystemPasswordChar = False
        Me.txt_total_net.Value = "0.00"
        Me.txt_total_net.ValueSource = ""
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
        Me.txt_total_amount.Location = New System.Drawing.Point(278, 282)
        Me.txt_total_amount.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_amount.MultiLine = False
        Me.txt_total_amount.Name = "txt_total_amount"
        Me.txt_total_amount.NoClear = False
        Me.txt_total_amount.NumberFormat = "##,##0.00"
        Me.txt_total_amount.Required = False
        Me.txt_total_amount.RowData = Nothing
        Me.txt_total_amount.SelectionLength = 0
        Me.txt_total_amount.SelectionStart = 0
        Me.txt_total_amount.Size = New System.Drawing.Size(10, 23)
        Me.txt_total_amount.TabIndex = 214
        Me.txt_total_amount.TableData = Nothing
        Me.txt_total_amount.TextSource = ""
        Me.txt_total_amount.UseSystemPasswordChar = False
        Me.txt_total_amount.Value = "0.00"
        Me.txt_total_amount.ValueSource = ""
        Me.txt_total_amount.Visible = False
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
        Me.btnRemove.TabIndex = 211
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(296, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "VAT Amount"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_unit_id)
        Me.Panel2.Controls.Add(Me.lblUnit)
        Me.Panel2.Controls.Add(Me.txt_based_rate)
        Me.Panel2.Controls.Add(Me.txt_exchange_rate)
        Me.Panel2.Controls.Add(Me.txt_currency_id)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_output_vat_id)
        Me.Panel2.Controls.Add(Me.txt_vat_amount_based)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.txt_net_amount_based)
        Me.Panel2.Controls.Add(Me.txt_gross_amount_based)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.txt_vat_type)
        Me.Panel2.Controls.Add(Me.txt_address)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txt_tin)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txt_net_amount)
        Me.Panel2.Controls.Add(Me.txt_gross_amount)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txt_general_id)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txt_vat_amount)
        Me.Panel2.Controls.Add(Me.txt_vat_rate)
        Me.Panel2.Controls.Add(Me.txt_ref_no)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(12, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 145)
        Me.Panel2.TabIndex = 217
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
        Me.txt_unit_id.Location = New System.Drawing.Point(366, 10)
        Me.txt_unit_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_unit_id.MultiLine = False
        Me.txt_unit_id.Name = "txt_unit_id"
        Me.txt_unit_id.NoClear = False
        Me.txt_unit_id.NumberFormat = "@"
        Me.txt_unit_id.Required = False
        Me.txt_unit_id.RowData = Nothing
        Me.txt_unit_id.SelectionLength = 0
        Me.txt_unit_id.SelectionStart = 0
        Me.txt_unit_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_unit_id.TabIndex = 325
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
        Me.lblUnit.Location = New System.Drawing.Point(334, 13)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblUnit.TabIndex = 324
        Me.lblUnit.Text = "Unit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(567, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "VAT Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Reference No."
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
        Me.txt_department.Location = New System.Drawing.Point(350, 26)
        Me.txt_department.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department.MultiLine = False
        Me.txt_department.Name = "txt_department"
        Me.txt_department.NoClear = False
        Me.txt_department.NumberFormat = "@"
        Me.txt_department.Required = False
        Me.txt_department.RowData = Nothing
        Me.txt_department.SelectionLength = 0
        Me.txt_department.SelectionStart = 0
        Me.txt_department.Size = New System.Drawing.Size(428, 19)
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
        Me.txt_account_name.Location = New System.Drawing.Point(285, 3)
        Me.txt_account_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account_name.MultiLine = False
        Me.txt_account_name.Name = "txt_account_name"
        Me.txt_account_name.NoClear = False
        Me.txt_account_name.NumberFormat = "@"
        Me.txt_account_name.Required = False
        Me.txt_account_name.RowData = Nothing
        Me.txt_account_name.SelectionLength = 0
        Me.txt_account_name.SelectionStart = 0
        Me.txt_account_name.Size = New System.Drawing.Size(493, 19)
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
        Me.txt_project.Location = New System.Drawing.Point(113, 26)
        Me.txt_project.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project.MultiLine = False
        Me.txt_project.Name = "txt_project"
        Me.txt_project.NoClear = False
        Me.txt_project.NumberFormat = "@"
        Me.txt_project.Required = False
        Me.txt_project.RowData = Nothing
        Me.txt_project.SelectionLength = 0
        Me.txt_project.SelectionStart = 0
        Me.txt_project.Size = New System.Drawing.Size(150, 19)
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
        Me.txt_account.Location = New System.Drawing.Point(113, 3)
        Me.txt_account.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_account.MultiLine = False
        Me.txt_account.Name = "txt_account"
        Me.txt_account.NoClear = False
        Me.txt_account.NumberFormat = "@"
        Me.txt_account.Required = False
        Me.txt_account.RowData = Nothing
        Me.txt_account.SelectionLength = 0
        Me.txt_account.SelectionStart = 0
        Me.txt_account.Size = New System.Drawing.Size(150, 19)
        Me.txt_account.TabIndex = 7
        Me.txt_account.TableData = Nothing
        Me.txt_account.Tag = ""
        Me.txt_account.TextSource = ""
        Me.txt_account.UseSystemPasswordChar = False
        Me.txt_account.Value = ""
        Me.txt_account.ValueSource = ""
        '
        'txt_total_gross
        '
        Me.txt_total_gross._Text = ""
        Me.txt_total_gross.AllowNegative = False
        Me.txt_total_gross.AlwaysDisable = True
        Me.txt_total_gross.AlwaysEnable = False
        Me.txt_total_gross.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_gross.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_total_gross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_gross.DataSource = ""
        Me.txt_total_gross.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_gross.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total_gross.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total_gross.Enabled = False
        Me.txt_total_gross.EnabledBackColor = System.Drawing.Color.White
        Me.txt_total_gross.ispk = False
        Me.txt_total_gross.Location = New System.Drawing.Point(328, 285)
        Me.txt_total_gross.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total_gross.MultiLine = False
        Me.txt_total_gross.Name = "txt_total_gross"
        Me.txt_total_gross.NoClear = False
        Me.txt_total_gross.NumberFormat = "##,##0.00"
        Me.txt_total_gross.Required = False
        Me.txt_total_gross.RowData = Nothing
        Me.txt_total_gross.SelectionLength = 0
        Me.txt_total_gross.SelectionStart = 0
        Me.txt_total_gross.Size = New System.Drawing.Size(100, 20)
        Me.txt_total_gross.TabIndex = 221
        Me.txt_total_gross.TableData = Nothing
        Me.txt_total_gross.TextSource = ""
        Me.txt_total_gross.UseSystemPasswordChar = False
        Me.txt_total_gross.Value = "0.00"
        Me.txt_total_gross.ValueSource = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 282)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 205
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Department"
        '
        'panel_hdr
        '
        Me.panel_hdr.Controls.Add(Me.PictureBox1)
        Me.panel_hdr.Controls.Add(Me.txt_department)
        Me.panel_hdr.Controls.Add(Me.txt_account_name)
        Me.panel_hdr.Controls.Add(Me.txt_project)
        Me.panel_hdr.Controls.Add(Me.txt_account)
        Me.panel_hdr.Controls.Add(Me.Label5)
        Me.panel_hdr.Controls.Add(Me.Label3)
        Me.panel_hdr.Controls.Add(Me.Label2)
        Me.panel_hdr.Location = New System.Drawing.Point(12, 70)
        Me.panel_hdr.Name = "panel_hdr"
        Me.panel_hdr.Size = New System.Drawing.Size(781, 50)
        Me.panel_hdr.TabIndex = 213
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(266, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 224
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Code"
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
        Me.btnNotSave.TabIndex = 216
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(780, 2)
        Me.border1.TabIndex = 207
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(805, 28)
        Me.Myformheader1.TabIndex = 222
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.ForeColor = System.Drawing.Color.White
        Me.btnViewDetails.Location = New System.Drawing.Point(675, 282)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(115, 24)
        Me.btnViewDetails.TabIndex = 234
        Me.btnViewDetails.Tag = "btnViewDetails"
        Me.btnViewDetails.Text = "F6 View Schedule"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'begbal_ov_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 465)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.txt_total_based)
        Me.Controls.Add(Me.txt_total_amount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_total_vat)
        Me.Controls.Add(Me.txt_total_net)
        Me.Controls.Add(Me.txt_total_gross)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_hdr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "begbal_ov_detail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Output VAT Beginning balance - Details"
        Me.txt_vat_type.ResumeLayout(False)
        Me.txt_vat_type.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panel_hdr.ResumeLayout(False)
        Me.panel_hdr.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_based_rate As user_control.textbox
    Friend WithEvents txt_exchange_rate As user_control.textbox
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_output_vat_id As user_control.textbox
    Friend WithEvents txt_vat_amount_based As user_control.textbox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_net_amount_based As user_control.textbox
    Friend WithEvents txt_gross_amount_based As user_control.textbox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_total_based As user_control.textbox
    Friend WithEvents txt_vat_type As System.Windows.Forms.Panel
    Friend WithEvents Rdo_button2 As user_control.rdo_button
    Friend WithEvents Rdo_button1 As user_control.rdo_button
    Friend WithEvents txt_address As user_control.textbox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_tin As user_control.textbox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_net_amount As user_control.textbox
    Friend WithEvents txt_gross_amount As user_control.textbox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_vat_amount As user_control.textbox
    Friend WithEvents txt_vat_rate As user_control.textbox
    Friend WithEvents txt_ref_no As user_control.textbox
    Friend WithEvents txt_total_vat As user_control.textbox
    Friend WithEvents txt_total_net As user_control.textbox
    Friend WithEvents txt_total_amount As user_control.textbox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_department As user_control.textbox
    Friend WithEvents txt_account_name As user_control.textbox
    Friend WithEvents txt_project As user_control.textbox
    Friend WithEvents txt_account As user_control.textbox
    Friend WithEvents txt_total_gross As user_control.textbox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panel_hdr As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents output_vat_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gross_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vat_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents net_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents minimum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_unit_id As user_control.textbox
    Friend WithEvents lblUnit As Windows.Forms.Label
End Class
