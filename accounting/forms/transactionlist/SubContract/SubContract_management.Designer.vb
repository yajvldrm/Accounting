<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubContract_management
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Myformheader1 = New user_control.myformheader()
        Me.clientpnl = New System.Windows.Forms.Panel()
        Me.txt_general_name = New user_control.textbox()
        Me.txt_general_id = New user_control.textbox()
        Me.txt_pm_year = New System.Windows.Forms.NumericUpDown()
        Me.txt_project_name = New user_control.textbox()
        Me.txt_project_id = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_subcon_management_id = New user_control.textbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subconcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subconname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accomplishment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cons1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cons2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billed_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.collected_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_contract_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_contract_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subconid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sc_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exchange_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.based_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.po_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isPrior = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.sub_contract_det_id_ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet()
        Me.trans_sub_contract = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.trans_sub_contract_det = New System.Data.DataTable()
        Me.DataColumn3 = New System.Data.DataColumn()
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
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.transpnl = New System.Windows.Forms.Panel()
        Me.txt_department_id = New user_control.textbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_contract_date = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txt_collected_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_billed_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_accomplishment_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_contract_amount_based = New DevExpress.XtraEditors.TextEdit()
        Me.txt_contract_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_based_rate = New DevExpress.XtraEditors.TextEdit()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.txt_exchange_rate = New DevExpress.XtraEditors.TextEdit()
        Me.txt_currency_id = New user_control.textbox()
        Me.txt_project_name_det = New System.Windows.Forms.TextBox()
        Me.txt_po_no = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ispriordate = New System.Windows.Forms.CheckBox()
        Me.txt_subconcodes = New user_control.textbox()
        Me.txt_subconnames = New user_control.textbox()
        Me.txt_sub_contract_det_id = New user_control.textbox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.pnl_crud = New System.Windows.Forms.Panel()
        Me.clientpnl.SuspendLayout()
        CType(Me.txt_pm_year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_sub_contract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_sub_contract_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transpnl.SuspendLayout()
        CType(Me.txt_collected_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_billed_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_accomplishment_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contract_amount_based.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contract_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_based_rate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_exchange_rate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_crud.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(800, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'clientpnl
        '
        Me.clientpnl.Controls.Add(Me.txt_general_name)
        Me.clientpnl.Controls.Add(Me.txt_general_id)
        Me.clientpnl.Controls.Add(Me.txt_pm_year)
        Me.clientpnl.Controls.Add(Me.txt_project_name)
        Me.clientpnl.Controls.Add(Me.txt_project_id)
        Me.clientpnl.Controls.Add(Me.Label4)
        Me.clientpnl.Controls.Add(Me.Label3)
        Me.clientpnl.Controls.Add(Me.Label2)
        Me.clientpnl.Enabled = False
        Me.clientpnl.Location = New System.Drawing.Point(11, 100)
        Me.clientpnl.Name = "clientpnl"
        Me.clientpnl.Size = New System.Drawing.Size(776, 84)
        Me.clientpnl.TabIndex = 1
        '
        'txt_general_name
        '
        Me.txt_general_name._Text = ""
        Me.txt_general_name.AllowNegative = False
        Me.txt_general_name.AlwaysDisable = False
        Me.txt_general_name.AlwaysEnable = False
        Me.txt_general_name.BackColor = System.Drawing.Color.White
        Me.txt_general_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_name.DataSource = ""
        Me.txt_general_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_name.Enabled = False
        Me.txt_general_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_name.ispk = False
        Me.txt_general_name.Location = New System.Drawing.Point(261, 58)
        Me.txt_general_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.MultiLine = False
        Me.txt_general_name.Name = "txt_general_name"
        Me.txt_general_name.NoClear = False
        Me.txt_general_name.NumberFormat = "@"
        Me.txt_general_name.Required = False
        Me.txt_general_name.RowData = Nothing
        Me.txt_general_name.SelectionLength = 0
        Me.txt_general_name.SelectionStart = 0
        Me.txt_general_name.Size = New System.Drawing.Size(462, 20)
        Me.txt_general_name.TabIndex = 7
        Me.txt_general_name.TableData = Nothing
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
        Me.txt_general_id.BackColor = System.Drawing.Color.White
        Me.txt_general_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.DataSource = ""
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.ispk = False
        Me.txt_general_id.Location = New System.Drawing.Point(135, 58)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_general_id.TabIndex = 3
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.TextSource = "general_code"
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = "general_id"
        '
        'txt_pm_year
        '
        Me.txt_pm_year.Location = New System.Drawing.Point(135, 6)
        Me.txt_pm_year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_pm_year.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_pm_year.Name = "txt_pm_year"
        Me.txt_pm_year.Size = New System.Drawing.Size(120, 20)
        Me.txt_pm_year.TabIndex = 1
        Me.txt_pm_year.Tag = "pm_year"
        Me.txt_pm_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_pm_year.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'txt_project_name
        '
        Me.txt_project_name._Text = ""
        Me.txt_project_name.AllowNegative = False
        Me.txt_project_name.AlwaysDisable = False
        Me.txt_project_name.AlwaysEnable = False
        Me.txt_project_name.BackColor = System.Drawing.Color.White
        Me.txt_project_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_name.DataSource = ""
        Me.txt_project_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_name.Enabled = False
        Me.txt_project_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_name.ispk = False
        Me.txt_project_name.Location = New System.Drawing.Point(261, 32)
        Me.txt_project_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_name.MultiLine = False
        Me.txt_project_name.Name = "txt_project_name"
        Me.txt_project_name.NoClear = False
        Me.txt_project_name.NumberFormat = "@"
        Me.txt_project_name.Required = False
        Me.txt_project_name.RowData = Nothing
        Me.txt_project_name.SelectionLength = 0
        Me.txt_project_name.SelectionStart = 0
        Me.txt_project_name.Size = New System.Drawing.Size(462, 20)
        Me.txt_project_name.TabIndex = 4
        Me.txt_project_name.TableData = Nothing
        Me.txt_project_name.TextSource = "project_name"
        Me.txt_project_name.UseSystemPasswordChar = False
        Me.txt_project_name.Value = ""
        Me.txt_project_name.ValueSource = ""
        '
        'txt_project_id
        '
        Me.txt_project_id._Text = ""
        Me.txt_project_id.AllowNegative = False
        Me.txt_project_id.AlwaysDisable = False
        Me.txt_project_id.AlwaysEnable = False
        Me.txt_project_id.BackColor = System.Drawing.Color.White
        Me.txt_project_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_id.DataSource = ""
        Me.txt_project_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_id.ispk = False
        Me.txt_project_id.Location = New System.Drawing.Point(135, 32)
        Me.txt_project_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.MultiLine = False
        Me.txt_project_id.Name = "txt_project_id"
        Me.txt_project_id.NoClear = False
        Me.txt_project_id.NumberFormat = "@"
        Me.txt_project_id.Required = False
        Me.txt_project_id.RowData = Nothing
        Me.txt_project_id.SelectionLength = 0
        Me.txt_project_id.SelectionStart = 0
        Me.txt_project_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_project_id.TabIndex = 2
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.TextSource = "project_code"
        Me.txt_project_id.UseSystemPasswordChar = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = "project_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PROJECT CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CLIENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "YEAR REFERENCE"
        '
        'txt_subcon_management_id
        '
        Me.txt_subcon_management_id._Text = ""
        Me.txt_subcon_management_id.AllowNegative = False
        Me.txt_subcon_management_id.AlwaysDisable = False
        Me.txt_subcon_management_id.AlwaysEnable = False
        Me.txt_subcon_management_id.BackColor = System.Drawing.Color.White
        Me.txt_subcon_management_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_subcon_management_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subcon_management_id.DataSource = ""
        Me.txt_subcon_management_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subcon_management_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subcon_management_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_subcon_management_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_subcon_management_id.ispk = False
        Me.txt_subcon_management_id.Location = New System.Drawing.Point(538, 67)
        Me.txt_subcon_management_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subcon_management_id.MultiLine = False
        Me.txt_subcon_management_id.Name = "txt_subcon_management_id"
        Me.txt_subcon_management_id.NoClear = False
        Me.txt_subcon_management_id.NumberFormat = "@"
        Me.txt_subcon_management_id.Required = False
        Me.txt_subcon_management_id.RowData = Nothing
        Me.txt_subcon_management_id.SelectionLength = 0
        Me.txt_subcon_management_id.SelectionStart = 0
        Me.txt_subcon_management_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_subcon_management_id.TabIndex = 8
        Me.txt_subcon_management_id.TableData = Nothing
        Me.txt_subcon_management_id.Tag = "sub_contract_id"
        Me.txt_subcon_management_id.TextSource = ""
        Me.txt_subcon_management_id.UseSystemPasswordChar = False
        Me.txt_subcon_management_id.Value = ""
        Me.txt_subcon_management_id.ValueSource = ""
        Me.txt_subcon_management_id.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 2)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sub Contract Management"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.AutoGenerateColumns = False
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.trans_date, Me.currency_code, Me.subconcode, Me.subconname, Me.department_code, Me.description, Me.amount, Me.accomplishment, Me.cons1, Me.cons2, Me.billed_amount, Me.collected_amount, Me.sub_contract_det_id, Me.sub_contract_id, Me.subconid, Me.sc_year, Me.amount_based, Me.currency_id, Me.exchange_rate, Me.based_rate, Me.supcd, Me.po_no, Me.isPrior, Me.sub_contract_det_id_ref, Me.department_id, Me.currency_name, Me.department_name, Me.deleted})
        Me.dgview.DataSource = Me.bs
        Me.dgview.Location = New System.Drawing.Point(12, 187)
        Me.dgview.MultiSelect = False
        Me.dgview.Name = "dgview"
        Me.dgview.RowHeadersVisible = False
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(775, 166)
        Me.dgview.TabIndex = 340
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'trans_date
        '
        Me.trans_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.trans_date.DataPropertyName = "trans_date"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = "00/00/0000"
        Me.trans_date.DefaultCellStyle = DataGridViewCellStyle7
        Me.trans_date.HeaderText = "DATE"
        Me.trans_date.MinimumWidth = 100
        Me.trans_date.Name = "trans_date"
        Me.trans_date.ReadOnly = True
        '
        'currency_code
        '
        Me.currency_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.currency_code.DataPropertyName = "currency_code"
        Me.currency_code.HeaderText = "CURRENCY"
        Me.currency_code.MinimumWidth = 100
        Me.currency_code.Name = "currency_code"
        Me.currency_code.ReadOnly = True
        '
        'subconcode
        '
        Me.subconcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subconcode.DataPropertyName = "subconcode"
        Me.subconcode.HeaderText = "CONTRACTOR"
        Me.subconcode.MinimumWidth = 100
        Me.subconcode.Name = "subconcode"
        Me.subconcode.ReadOnly = True
        '
        'subconname
        '
        Me.subconname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subconname.DataPropertyName = "subconname"
        Me.subconname.HeaderText = "NAME"
        Me.subconname.MinimumWidth = 100
        Me.subconname.Name = "subconname"
        Me.subconname.ReadOnly = True
        '
        'department_code
        '
        Me.department_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.department_code.DataPropertyName = "department_code"
        Me.department_code.HeaderText = "DEPARTMENT"
        Me.department_code.MinimumWidth = 100
        Me.department_code.Name = "department_code"
        Me.department_code.ReadOnly = True
        Me.department_code.Visible = False
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "PROJECT"
        Me.description.MinimumWidth = 100
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        '
        'amount
        '
        Me.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.amount.DataPropertyName = "amount"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.amount.DefaultCellStyle = DataGridViewCellStyle8
        Me.amount.HeaderText = "CONTRACT"
        Me.amount.MinimumWidth = 100
        Me.amount.Name = "amount"
        '
        'accomplishment
        '
        Me.accomplishment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.accomplishment.DataPropertyName = "accomplishment"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0.00"
        Me.accomplishment.DefaultCellStyle = DataGridViewCellStyle9
        Me.accomplishment.HeaderText = "ACCOMPLISHMENT"
        Me.accomplishment.MinimumWidth = 100
        Me.accomplishment.Name = "accomplishment"
        Me.accomplishment.ReadOnly = True
        '
        'cons1
        '
        Me.cons1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cons1.DataPropertyName = "cons1"
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = "00/00/0000"
        Me.cons1.DefaultCellStyle = DataGridViewCellStyle10
        Me.cons1.HeaderText = "FROM"
        Me.cons1.MinimumWidth = 100
        Me.cons1.Name = "cons1"
        Me.cons1.ReadOnly = True
        '
        'cons2
        '
        Me.cons2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cons2.DataPropertyName = "cons2"
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = "00/00/0000"
        Me.cons2.DefaultCellStyle = DataGridViewCellStyle11
        Me.cons2.HeaderText = "TO"
        Me.cons2.MinimumWidth = 100
        Me.cons2.Name = "cons2"
        Me.cons2.ReadOnly = True
        '
        'billed_amount
        '
        Me.billed_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.billed_amount.DataPropertyName = "billed_amount"
        Me.billed_amount.HeaderText = "BILLED"
        Me.billed_amount.MinimumWidth = 100
        Me.billed_amount.Name = "billed_amount"
        Me.billed_amount.ReadOnly = True
        '
        'collected_amount
        '
        Me.collected_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.collected_amount.DataPropertyName = "collected_amount"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0.00"
        Me.collected_amount.DefaultCellStyle = DataGridViewCellStyle12
        Me.collected_amount.HeaderText = "PAID"
        Me.collected_amount.MinimumWidth = 100
        Me.collected_amount.Name = "collected_amount"
        Me.collected_amount.ReadOnly = True
        '
        'sub_contract_det_id
        '
        Me.sub_contract_det_id.DataPropertyName = "sub_contract_det_id"
        Me.sub_contract_det_id.HeaderText = "sub_contract_det_id"
        Me.sub_contract_det_id.Name = "sub_contract_det_id"
        Me.sub_contract_det_id.Visible = False
        '
        'sub_contract_id
        '
        Me.sub_contract_id.DataPropertyName = "sub_contract_id"
        Me.sub_contract_id.HeaderText = "sub_contract_id"
        Me.sub_contract_id.Name = "sub_contract_id"
        Me.sub_contract_id.Visible = False
        '
        'subconid
        '
        Me.subconid.DataPropertyName = "subconid"
        Me.subconid.HeaderText = "subconid"
        Me.subconid.Name = "subconid"
        Me.subconid.Visible = False
        '
        'sc_year
        '
        Me.sc_year.DataPropertyName = "sc_year"
        Me.sc_year.HeaderText = "sc_year"
        Me.sc_year.Name = "sc_year"
        Me.sc_year.Visible = False
        '
        'amount_based
        '
        Me.amount_based.DataPropertyName = "amount_based"
        Me.amount_based.HeaderText = "amount_based"
        Me.amount_based.Name = "amount_based"
        Me.amount_based.Visible = False
        '
        'currency_id
        '
        Me.currency_id.DataPropertyName = "currency_id"
        Me.currency_id.HeaderText = "currency_id"
        Me.currency_id.Name = "currency_id"
        Me.currency_id.Visible = False
        '
        'exchange_rate
        '
        Me.exchange_rate.DataPropertyName = "exchange_rate"
        Me.exchange_rate.HeaderText = "exchange_rate"
        Me.exchange_rate.Name = "exchange_rate"
        Me.exchange_rate.Visible = False
        '
        'based_rate
        '
        Me.based_rate.DataPropertyName = "based_rate"
        Me.based_rate.HeaderText = "based_rate"
        Me.based_rate.Name = "based_rate"
        Me.based_rate.Visible = False
        '
        'supcd
        '
        Me.supcd.DataPropertyName = "supcd"
        Me.supcd.HeaderText = "supcd"
        Me.supcd.Name = "supcd"
        Me.supcd.Visible = False
        '
        'po_no
        '
        Me.po_no.DataPropertyName = "po_no"
        Me.po_no.HeaderText = "po_no"
        Me.po_no.Name = "po_no"
        Me.po_no.Visible = False
        '
        'isPrior
        '
        Me.isPrior.DataPropertyName = "isPrior"
        Me.isPrior.HeaderText = "isPrior"
        Me.isPrior.Name = "isPrior"
        Me.isPrior.Visible = False
        '
        'sub_contract_det_id_ref
        '
        Me.sub_contract_det_id_ref.DataPropertyName = "sub_contract_det_id_ref"
        Me.sub_contract_det_id_ref.HeaderText = "sub_contract_det_id_ref"
        Me.sub_contract_det_id_ref.Name = "sub_contract_det_id_ref"
        Me.sub_contract_det_id_ref.Visible = False
        '
        'department_id
        '
        Me.department_id.DataPropertyName = "department_id"
        Me.department_id.HeaderText = "department_id"
        Me.department_id.Name = "department_id"
        Me.department_id.Visible = False
        '
        'currency_name
        '
        Me.currency_name.DataPropertyName = "currency_name"
        Me.currency_name.HeaderText = "currency_name"
        Me.currency_name.Name = "currency_name"
        Me.currency_name.Visible = False
        '
        'department_name
        '
        Me.department_name.DataPropertyName = "department_name"
        Me.department_name.HeaderText = "department_name"
        Me.department_name.Name = "department_name"
        Me.department_name.Visible = False
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Visible = False
        '
        'bs
        '
        Me.bs.DataMember = "trans_sub_contract_det"
        Me.bs.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_sub_contract, Me.trans_sub_contract_det})
        '
        'trans_sub_contract
        '
        Me.trans_sub_contract.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn4})
        Me.trans_sub_contract.TableName = "trans_sub_contract"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sub_contract_id"
        Me.DataColumn1.DataType = GetType(Integer)
        Me.DataColumn1.DefaultValue = 0
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sc_year"
        Me.DataColumn2.DataType = GetType(Integer)
        Me.DataColumn2.DefaultValue = 0
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "project_id"
        Me.DataColumn4.DefaultValue = "0"
        '
        'trans_sub_contract_det
        '
        Me.trans_sub_contract_det.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35})
        Me.trans_sub_contract_det.TableName = "trans_sub_contract_det"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sub_contract_det_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sub_contract_id"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "subconid"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sc_year"
        Me.DataColumn7.DefaultValue = "0000"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "trans_date"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "description"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "amount"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "amount_based"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "currency_id"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "exchange_rate"
        Me.DataColumn13.DataType = GetType(Decimal)
        Me.DataColumn13.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "based_rate"
        Me.DataColumn14.DataType = GetType(Decimal)
        Me.DataColumn14.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "supcd"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "po_no"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "billed_amount"
        Me.DataColumn17.DataType = GetType(Decimal)
        Me.DataColumn17.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "collected_amount"
        Me.DataColumn18.DataType = GetType(Decimal)
        Me.DataColumn18.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "cons1"
        Me.DataColumn19.DataType = GetType(Date)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "cons2"
        Me.DataColumn20.DataType = GetType(Date)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "isPrior"
        Me.DataColumn21.DataType = GetType(Boolean)
        Me.DataColumn21.DefaultValue = False
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "accomplishment"
        Me.DataColumn22.DataType = GetType(Decimal)
        Me.DataColumn22.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sub_contract_det_id_ref"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "department_id"
        Me.DataColumn24.DefaultValue = ""
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "subconcode"
        Me.DataColumn25.DefaultValue = ""
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "subconname"
        Me.DataColumn26.DefaultValue = ""
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "currency_code"
        Me.DataColumn27.DefaultValue = ""
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "currency_name"
        Me.DataColumn28.DefaultValue = ""
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "department_code"
        Me.DataColumn29.DefaultValue = ""
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "department_name"
        Me.DataColumn30.DefaultValue = ""
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "deleted"
        Me.DataColumn31.DataType = GetType(Boolean)
        Me.DataColumn31.DefaultValue = False
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sel"
        Me.DataColumn32.DataType = GetType(Boolean)
        Me.DataColumn32.DefaultValue = False
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "general_id"
        Me.DataColumn33.DefaultValue = ""
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "general_code"
        Me.DataColumn34.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "general_name"
        Me.DataColumn35.DefaultValue = ""
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ForeColor = System.Drawing.Color.White
        Me.btnremove.Location = New System.Drawing.Point(170, 3)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(78, 22)
        Me.btnremove.TabIndex = 2
        Me.btnremove.Text = "D&elete"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'transpnl
        '
        Me.transpnl.Controls.Add(Me.txt_department_id)
        Me.transpnl.Controls.Add(Me.Label12)
        Me.transpnl.Controls.Add(Me.TextBox1)
        Me.transpnl.Controls.Add(Me.Label5)
        Me.transpnl.Controls.Add(Me.txt_contract_date)
        Me.transpnl.Controls.Add(Me.Label6)
        Me.transpnl.Controls.Add(Me.btncancel)
        Me.transpnl.Controls.Add(Me.btnOk)
        Me.transpnl.Controls.Add(Me.txt_collected_amount)
        Me.transpnl.Controls.Add(Me.Label17)
        Me.transpnl.Controls.Add(Me.txt_billed_amount)
        Me.transpnl.Controls.Add(Me.Label16)
        Me.transpnl.Controls.Add(Me.txt_accomplishment_amount)
        Me.transpnl.Controls.Add(Me.Label15)
        Me.transpnl.Controls.Add(Me.txt_contract_amount_based)
        Me.transpnl.Controls.Add(Me.txt_contract_amount)
        Me.transpnl.Controls.Add(Me.Label11)
        Me.transpnl.Controls.Add(Me.txt_date_to)
        Me.transpnl.Controls.Add(Me.Label13)
        Me.transpnl.Controls.Add(Me.txt_based_rate)
        Me.transpnl.Controls.Add(Me.txt_date_from)
        Me.transpnl.Controls.Add(Me.txt_exchange_rate)
        Me.transpnl.Controls.Add(Me.txt_currency_id)
        Me.transpnl.Controls.Add(Me.txt_project_name_det)
        Me.transpnl.Controls.Add(Me.txt_po_no)
        Me.transpnl.Controls.Add(Me.Label10)
        Me.transpnl.Controls.Add(Me.Label9)
        Me.transpnl.Controls.Add(Me.Label8)
        Me.transpnl.Controls.Add(Me.Label7)
        Me.transpnl.Controls.Add(Me.txt_ispriordate)
        Me.transpnl.Controls.Add(Me.txt_subconcodes)
        Me.transpnl.Controls.Add(Me.txt_subconnames)
        Me.transpnl.Enabled = False
        Me.transpnl.Location = New System.Drawing.Point(11, 379)
        Me.transpnl.Name = "transpnl"
        Me.transpnl.Size = New System.Drawing.Size(776, 209)
        Me.transpnl.TabIndex = 3
        '
        'txt_department_id
        '
        Me.txt_department_id._Text = ""
        Me.txt_department_id.AllowNegative = False
        Me.txt_department_id.AlwaysDisable = False
        Me.txt_department_id.AlwaysEnable = False
        Me.txt_department_id.BackColor = System.Drawing.Color.White
        Me.txt_department_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department_id.DataSource = ""
        Me.txt_department_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department_id.ispk = False
        Me.txt_department_id.Location = New System.Drawing.Point(135, 135)
        Me.txt_department_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.MultiLine = False
        Me.txt_department_id.Name = "txt_department_id"
        Me.txt_department_id.NoClear = False
        Me.txt_department_id.NumberFormat = "@"
        Me.txt_department_id.Required = False
        Me.txt_department_id.RowData = Nothing
        Me.txt_department_id.SelectionLength = 0
        Me.txt_department_id.SelectionStart = 0
        Me.txt_department_id.Size = New System.Drawing.Size(252, 20)
        Me.txt_department_id.TabIndex = 7
        Me.txt_department_id.TableData = Nothing
        Me.txt_department_id.TextSource = "department_code"
        Me.txt_department_id.UseSystemPasswordChar = False
        Me.txt_department_id.Value = ""
        Me.txt_department_id.ValueSource = "department_id"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(41, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sub Construction"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(494, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Tag = "insured_with"
        Me.TextBox1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(424, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 344
        Me.Label5.Text = "Insured with"
        Me.Label5.Visible = False
        '
        'txt_contract_date
        '
        Me.txt_contract_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_contract_date.Location = New System.Drawing.Point(135, 54)
        Me.txt_contract_date.Name = "txt_contract_date"
        Me.txt_contract_date.Size = New System.Drawing.Size(120, 20)
        Me.txt_contract_date.TabIndex = 2
        Me.txt_contract_date.Tag = "trans_date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Date"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Red
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(513, 183)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(80, 27)
        Me.btncancel.TabIndex = 16
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        Me.btncancel.Visible = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Green
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(599, 183)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 27)
        Me.btnOk.TabIndex = 17
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        Me.btnOk.Visible = False
        '
        'txt_collected_amount
        '
        Me.txt_collected_amount.Location = New System.Drawing.Point(653, 134)
        Me.txt_collected_amount.Name = "txt_collected_amount"
        Me.txt_collected_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_collected_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_collected_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_collected_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_collected_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_collected_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_collected_amount.Properties.Mask.EditMask = "n2"
        Me.txt_collected_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_collected_amount.Size = New System.Drawing.Size(96, 20)
        Me.txt_collected_amount.TabIndex = 14
        Me.txt_collected_amount.Tag = "collected_amount"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(596, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Collected"
        '
        'txt_billed_amount
        '
        Me.txt_billed_amount.Location = New System.Drawing.Point(494, 134)
        Me.txt_billed_amount.Name = "txt_billed_amount"
        Me.txt_billed_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_billed_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_billed_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_billed_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_billed_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_billed_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_billed_amount.Properties.Mask.EditMask = "n2"
        Me.txt_billed_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_billed_amount.Size = New System.Drawing.Size(96, 20)
        Me.txt_billed_amount.TabIndex = 13
        Me.txt_billed_amount.Tag = "billed_amount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(456, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Billed"
        '
        'txt_accomplishment_amount
        '
        Me.txt_accomplishment_amount.EditValue = "0.00"
        Me.txt_accomplishment_amount.Location = New System.Drawing.Point(494, 103)
        Me.txt_accomplishment_amount.Name = "txt_accomplishment_amount"
        Me.txt_accomplishment_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_accomplishment_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_accomplishment_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_accomplishment_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_accomplishment_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_accomplishment_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_accomplishment_amount.Properties.Mask.EditMask = "n2"
        Me.txt_accomplishment_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_accomplishment_amount.Size = New System.Drawing.Size(255, 20)
        Me.txt_accomplishment_amount.TabIndex = 12
        Me.txt_accomplishment_amount.Tag = "accomplishment"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(404, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Accomplishment"
        '
        'txt_contract_amount_based
        '
        Me.txt_contract_amount_based.Location = New System.Drawing.Point(596, 77)
        Me.txt_contract_amount_based.Name = "txt_contract_amount_based"
        Me.txt_contract_amount_based.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_contract_amount_based.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_contract_amount_based.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_contract_amount_based.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_amount_based.Properties.EditFormat.FormatString = "n2"
        Me.txt_contract_amount_based.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_amount_based.Properties.Mask.EditMask = "n2"
        Me.txt_contract_amount_based.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_contract_amount_based.Properties.ReadOnly = True
        Me.txt_contract_amount_based.Size = New System.Drawing.Size(153, 20)
        Me.txt_contract_amount_based.TabIndex = 10
        Me.txt_contract_amount_based.Tag = "amount_based"
        '
        'txt_contract_amount
        '
        Me.txt_contract_amount.Location = New System.Drawing.Point(494, 77)
        Me.txt_contract_amount.Name = "txt_contract_amount"
        Me.txt_contract_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_contract_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_contract_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_contract_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_contract_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_amount.Properties.Mask.EditMask = "n2"
        Me.txt_contract_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_contract_amount.Size = New System.Drawing.Size(96, 20)
        Me.txt_contract_amount.TabIndex = 11
        Me.txt_contract_amount.Tag = "amount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(402, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Contract Amount"
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date_to.Location = New System.Drawing.Point(596, 51)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(96, 20)
        Me.txt_date_to.TabIndex = 10
        Me.txt_date_to.Tag = "cons2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(418, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Const. Period"
        '
        'txt_based_rate
        '
        Me.txt_based_rate.Location = New System.Drawing.Point(317, 81)
        Me.txt_based_rate.Name = "txt_based_rate"
        Me.txt_based_rate.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_based_rate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_based_rate.Size = New System.Drawing.Size(50, 20)
        Me.txt_based_rate.TabIndex = 5
        Me.txt_based_rate.Tag = "based_rate"
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date_from.Location = New System.Drawing.Point(494, 51)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(96, 20)
        Me.txt_date_from.TabIndex = 9
        Me.txt_date_from.Tag = "cons1"
        '
        'txt_exchange_rate
        '
        Me.txt_exchange_rate.Location = New System.Drawing.Point(261, 81)
        Me.txt_exchange_rate.Name = "txt_exchange_rate"
        Me.txt_exchange_rate.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_exchange_rate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_exchange_rate.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_exchange_rate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_exchange_rate.Properties.EditFormat.FormatString = "n2"
        Me.txt_exchange_rate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_exchange_rate.Properties.Mask.EditMask = "n2"
        Me.txt_exchange_rate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_exchange_rate.Size = New System.Drawing.Size(50, 20)
        Me.txt_exchange_rate.TabIndex = 4
        Me.txt_exchange_rate.Tag = "exchange_rate"
        '
        'txt_currency_id
        '
        Me.txt_currency_id._Text = ""
        Me.txt_currency_id.AllowNegative = False
        Me.txt_currency_id.AlwaysDisable = False
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.White
        Me.txt_currency_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.DataSource = ""
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.ispk = False
        Me.txt_currency_id.Location = New System.Drawing.Point(135, 81)
        Me.txt_currency_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.MultiLine = False
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.SelectionLength = 0
        Me.txt_currency_id.SelectionStart = 0
        Me.txt_currency_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_currency_id.TabIndex = 3
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.Tag = "currency_code"
        Me.txt_currency_id.TextSource = "currency_code"
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = "currency_id"
        '
        'txt_project_name_det
        '
        Me.txt_project_name_det.Location = New System.Drawing.Point(135, 162)
        Me.txt_project_name_det.Multiline = True
        Me.txt_project_name_det.Name = "txt_project_name_det"
        Me.txt_project_name_det.Size = New System.Drawing.Size(252, 40)
        Me.txt_project_name_det.TabIndex = 8
        Me.txt_project_name_det.Tag = "description"
        '
        'txt_po_no
        '
        Me.txt_po_no.Location = New System.Drawing.Point(135, 107)
        Me.txt_po_no.Name = "txt_po_no"
        Me.txt_po_no.Size = New System.Drawing.Size(255, 20)
        Me.txt_po_no.TabIndex = 6
        Me.txt_po_no.Tag = "po_no"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "PROJECT NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DEPARTMENT CODE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "P.O NO."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Currency"
        '
        'txt_ispriordate
        '
        Me.txt_ispriordate.AutoSize = True
        Me.txt_ispriordate.Location = New System.Drawing.Point(99, 8)
        Me.txt_ispriordate.Name = "txt_ispriordate"
        Me.txt_ispriordate.Size = New System.Drawing.Size(92, 17)
        Me.txt_ispriordate.TabIndex = 1
        Me.txt_ispriordate.Tag = "isPriorDate"
        Me.txt_ispriordate.Text = "PRIOR YEAR"
        Me.txt_ispriordate.UseVisualStyleBackColor = True
        '
        'txt_subconcodes
        '
        Me.txt_subconcodes._Text = ""
        Me.txt_subconcodes.AllowNegative = False
        Me.txt_subconcodes.AlwaysDisable = False
        Me.txt_subconcodes.AlwaysEnable = False
        Me.txt_subconcodes.BackColor = System.Drawing.Color.White
        Me.txt_subconcodes.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_subconcodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subconcodes.DataSource = ""
        Me.txt_subconcodes.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subconcodes.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subconcodes.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_subconcodes.EnabledBackColor = System.Drawing.Color.White
        Me.txt_subconcodes.ispk = False
        Me.txt_subconcodes.Location = New System.Drawing.Point(135, 27)
        Me.txt_subconcodes.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subconcodes.MultiLine = False
        Me.txt_subconcodes.Name = "txt_subconcodes"
        Me.txt_subconcodes.NoClear = False
        Me.txt_subconcodes.NumberFormat = "@"
        Me.txt_subconcodes.Required = False
        Me.txt_subconcodes.RowData = Nothing
        Me.txt_subconcodes.SelectionLength = 0
        Me.txt_subconcodes.SelectionStart = 0
        Me.txt_subconcodes.Size = New System.Drawing.Size(95, 20)
        Me.txt_subconcodes.TabIndex = 1
        Me.txt_subconcodes.TableData = Nothing
        Me.txt_subconcodes.TextSource = "subconcode"
        Me.txt_subconcodes.UseSystemPasswordChar = False
        Me.txt_subconcodes.Value = "subConid"
        Me.txt_subconcodes.ValueSource = "subConid"
        '
        'txt_subconnames
        '
        Me.txt_subconnames._Text = ""
        Me.txt_subconnames.AllowNegative = False
        Me.txt_subconnames.AlwaysDisable = False
        Me.txt_subconnames.AlwaysEnable = False
        Me.txt_subconnames.BackColor = System.Drawing.Color.White
        Me.txt_subconnames.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_subconnames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subconnames.DataSource = ""
        Me.txt_subconnames.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subconnames.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_subconnames.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_subconnames.Enabled = False
        Me.txt_subconnames.EnabledBackColor = System.Drawing.Color.White
        Me.txt_subconnames.ispk = False
        Me.txt_subconnames.Location = New System.Drawing.Point(232, 27)
        Me.txt_subconnames.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_subconnames.MultiLine = False
        Me.txt_subconnames.Name = "txt_subconnames"
        Me.txt_subconnames.NoClear = False
        Me.txt_subconnames.NumberFormat = "@"
        Me.txt_subconnames.Required = False
        Me.txt_subconnames.RowData = Nothing
        Me.txt_subconnames.SelectionLength = 0
        Me.txt_subconnames.SelectionStart = 0
        Me.txt_subconnames.Size = New System.Drawing.Size(517, 20)
        Me.txt_subconnames.TabIndex = 348
        Me.txt_subconnames.TableData = Nothing
        Me.txt_subconnames.TextSource = "subconname"
        Me.txt_subconnames.UseSystemPasswordChar = False
        Me.txt_subconnames.Value = ""
        Me.txt_subconnames.ValueSource = ""
        '
        'txt_sub_contract_det_id
        '
        Me.txt_sub_contract_det_id._Text = ""
        Me.txt_sub_contract_det_id.AllowNegative = False
        Me.txt_sub_contract_det_id.AlwaysDisable = False
        Me.txt_sub_contract_det_id.AlwaysEnable = False
        Me.txt_sub_contract_det_id.BackColor = System.Drawing.Color.White
        Me.txt_sub_contract_det_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_sub_contract_det_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sub_contract_det_id.DataSource = ""
        Me.txt_sub_contract_det_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sub_contract_det_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sub_contract_det_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_sub_contract_det_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_sub_contract_det_id.ispk = False
        Me.txt_sub_contract_det_id.Location = New System.Drawing.Point(292, 5)
        Me.txt_sub_contract_det_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sub_contract_det_id.MultiLine = False
        Me.txt_sub_contract_det_id.Name = "txt_sub_contract_det_id"
        Me.txt_sub_contract_det_id.NoClear = False
        Me.txt_sub_contract_det_id.NumberFormat = "@"
        Me.txt_sub_contract_det_id.Required = False
        Me.txt_sub_contract_det_id.RowData = Nothing
        Me.txt_sub_contract_det_id.SelectionLength = 0
        Me.txt_sub_contract_det_id.SelectionStart = 0
        Me.txt_sub_contract_det_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_sub_contract_det_id.TabIndex = 29
        Me.txt_sub_contract_det_id.TableData = Nothing
        Me.txt_sub_contract_det_id.Tag = "sub_contract_det_id"
        Me.txt_sub_contract_det_id.TextSource = "sub_contract_det_id"
        Me.txt_sub_contract_det_id.UseSystemPasswordChar = False
        Me.txt_sub_contract_det_id.Value = "sub_contract_det_id"
        Me.txt_sub_contract_det_id.ValueSource = "sub_contract_det_id"
        Me.txt_sub_contract_det_id.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(88, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(78, 22)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "&Edit"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.Color.White
        Me.btninsert.Location = New System.Drawing.Point(4, 3)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(78, 22)
        Me.btninsert.TabIndex = 0
        Me.btninsert.Text = "&Add"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(262, 67)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "F6 Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(428, 67)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(80, 28)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "F8 Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(345, 67)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(80, 28)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "F7 Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(179, 67)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 28)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "F5 Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(97, 67)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 28)
        Me.btnNotSave.TabIndex = 354
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        Me.btnNotSave.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(13, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 28)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "F2 Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.YellowGreen
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(13, 67)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 28)
        Me.btnSave.TabIndex = 347
        Me.btnSave.Text = " Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(96, 67)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 28)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "F3 Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'pnl_crud
        '
        Me.pnl_crud.Controls.Add(Me.txt_sub_contract_det_id)
        Me.pnl_crud.Controls.Add(Me.btnremove)
        Me.pnl_crud.Controls.Add(Me.btnupdate)
        Me.pnl_crud.Controls.Add(Me.btninsert)
        Me.pnl_crud.Location = New System.Drawing.Point(11, 354)
        Me.pnl_crud.Name = "pnl_crud"
        Me.pnl_crud.Size = New System.Drawing.Size(776, 27)
        Me.pnl_crud.TabIndex = 2
        Me.pnl_crud.Visible = False
        '
        'SubContract_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.txt_subcon_management_id)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.transpnl)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.clientpnl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.pnl_crud)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "SubContract_management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubContract_management"
        Me.clientpnl.ResumeLayout(False)
        Me.clientpnl.PerformLayout()
        CType(Me.txt_pm_year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_sub_contract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_sub_contract_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transpnl.ResumeLayout(False)
        Me.transpnl.PerformLayout()
        CType(Me.txt_collected_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_billed_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_accomplishment_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contract_amount_based.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contract_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_based_rate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_exchange_rate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_crud.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents clientpnl As Windows.Forms.Panel
    Friend WithEvents txt_general_name As user_control.textbox
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents txt_pm_year As Windows.Forms.NumericUpDown
    Friend WithEvents txt_project_name As user_control.textbox
    Friend WithEvents txt_project_id As user_control.textbox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents dgview As Windows.Forms.DataGridView
    Friend WithEvents btnremove As Windows.Forms.Button
    Friend WithEvents transpnl As Windows.Forms.Panel
    Friend WithEvents txt_contract_date As Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents btncancel As Windows.Forms.Button
    Friend WithEvents txt_sub_contract_det_id As user_control.textbox
    Friend WithEvents btnOk As Windows.Forms.Button
    Friend WithEvents txt_collected_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txt_billed_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents txt_accomplishment_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txt_contract_amount_based As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_contract_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_date_to As Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txt_based_rate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_date_from As Windows.Forms.DateTimePicker
    Friend WithEvents txt_exchange_rate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents txt_project_name_det As Windows.Forms.TextBox
    Friend WithEvents txt_po_no As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txt_ispriordate As Windows.Forms.CheckBox
    Friend WithEvents btnupdate As Windows.Forms.Button
    Friend WithEvents btninsert As Windows.Forms.Button
    Friend WithEvents btnSearch As Windows.Forms.Button
    Friend WithEvents btnNext As Windows.Forms.Button
    Friend WithEvents btnPrevious As Windows.Forms.Button
    Friend WithEvents btnPrint As Windows.Forms.Button
    Friend WithEvents btnNotSave As Windows.Forms.Button
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents btnEdit As Windows.Forms.Button
    Friend WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents trans_sub_contract_det As DataTable
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents trans_sub_contract As DataTable
    Friend WithEvents ds As DataSet
    Public WithEvents txt_subcon_management_id As user_control.textbox
    Friend WithEvents pnl_crud As Windows.Forms.Panel
    Friend WithEvents txt_subconnames As user_control.textbox
    Friend WithEvents txt_subconcodes As user_control.textbox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txt_department_id As user_control.textbox
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents DataColumn18 As DataColumn
    Friend WithEvents DataColumn19 As DataColumn
    Friend WithEvents DataColumn20 As DataColumn
    Friend WithEvents DataColumn21 As DataColumn
    Friend WithEvents DataColumn22 As DataColumn
    Friend WithEvents DataColumn23 As DataColumn
    Friend WithEvents DataColumn24 As DataColumn
    Friend WithEvents DataColumn25 As DataColumn
    Friend WithEvents DataColumn26 As DataColumn
    Friend WithEvents DataColumn27 As DataColumn
    Friend WithEvents DataColumn28 As DataColumn
    Friend WithEvents DataColumn29 As DataColumn
    Friend WithEvents DataColumn30 As DataColumn
    Friend WithEvents DataColumn31 As DataColumn
    Friend WithEvents DataColumn32 As DataColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subconcode As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subconname As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accomplishment As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cons1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cons2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billed_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents collected_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_contract_det_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_contract_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subconid As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sc_year As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exchange_rate As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents based_rate As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supcd As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents po_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isPrior As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents sub_contract_det_id_ref As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataColumn33 As DataColumn
    Friend WithEvents DataColumn34 As DataColumn
    Friend WithEvents DataColumn35 As DataColumn
End Class
