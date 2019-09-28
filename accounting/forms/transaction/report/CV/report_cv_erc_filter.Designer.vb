<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class report_cv_erc_filter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_cv_erc_filter))
        Me.Myformheader1 = New user_control.myformheader()
        Me.lbl_fund = New System.Windows.Forms.Label()
        Me.txt_ors_burs = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ds = New System.Data.DataSet()
        Me.trans_additional = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.trans_mfo_pap = New System.Data.DataTable()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.lib_erp_fund_cluster = New System.Data.DataTable()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.lib_erp_mfo = New System.Data.DataTable()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.additional = New System.Data.DataTable()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdo_mds_check = New user_control.MyRadioButton()
        Me.rdo_commercial_check = New user_control.MyRadioButton()
        Me.rdo_ada = New user_control.MyRadioButton()
        Me.rdo_others = New user_control.MyRadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_mode_of_payment = New user_control.textbox()
        Me.txt_fund_code = New user_control.textbox()
        Me.mfo_pap_namesssss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfo_pap_codessss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfo_responsibility_centersss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_trans_mfo_pap = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_trans_additional_id = New user_control.textbox()
        Me.txt_trans_id = New user_control.textbox()
        Me.txt_mfo_pap_code = New user_control.textbox()
        Me.txt_mfo_pap_name = New user_control.textbox()
        Me.txt_mfo_pap_id = New user_control.textbox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txt_mfo_responsibility_center = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.dgMFO = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.trans_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfo_pap_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfo_pap_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfo_responsibility_center = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfo_pap_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txt_fund_name = New user_control.textbox()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_additional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_mfo_pap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_fund_cluster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_mfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.additional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bs_trans_mfo_pap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgMFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        resources.ApplyResources(Me.Myformheader1, "Myformheader1")
        Me.Myformheader1.Name = "Myformheader1"
        '
        'lbl_fund
        '
        resources.ApplyResources(Me.lbl_fund, "lbl_fund")
        Me.lbl_fund.Name = "lbl_fund"
        '
        'txt_ors_burs
        '
        Me.txt_ors_burs._Text = ""
        Me.txt_ors_burs.AllowNegative = False
        Me.txt_ors_burs.AlwaysDisable = False
        Me.txt_ors_burs.AlwaysEnable = False
        Me.txt_ors_burs.BackColor = System.Drawing.Color.White
        Me.txt_ors_burs.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_ors_burs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ors_burs.DataSource = ""
        Me.txt_ors_burs.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ors_burs.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ors_burs.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ors_burs.EnabledBackColor = System.Drawing.Color.White
        Me.txt_ors_burs.ispk = False
        resources.ApplyResources(Me.txt_ors_burs, "txt_ors_burs")
        Me.txt_ors_burs.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ors_burs.MultiLine = False
        Me.txt_ors_burs.Name = "txt_ors_burs"
        Me.txt_ors_burs.NoClear = False
        Me.txt_ors_burs.NumberFormat = "@"
        Me.txt_ors_burs.Required = False
        Me.txt_ors_burs.RowData = Nothing
        Me.txt_ors_burs.SelectionLength = 0
        Me.txt_ors_burs.SelectionStart = 0
        Me.txt_ors_burs.TableData = Nothing
        Me.txt_ors_burs.TextSource = ""
        Me.txt_ors_burs.UseSystemPasswordChar = False
        Me.txt_ors_burs.Value = ""
        Me.txt_ors_burs.ValueSource = ""
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'ds
        '
        Me.ds.DataSetName = "NewDataSet"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_additional, Me.trans_mfo_pap, Me.lib_erp_fund_cluster, Me.lib_erp_mfo, Me.additional})
        '
        'trans_additional
        '
        Me.trans_additional.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn21})
        Me.trans_additional.TableName = "trans_additional"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "trans_additional_id"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "deleted"
        Me.DataColumn21.DataType = GetType(Boolean)
        Me.DataColumn21.DefaultValue = False
        '
        'trans_mfo_pap
        '
        Me.trans_mfo_pap.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn14, Me.DataColumn16, Me.DataColumn17})
        Me.trans_mfo_pap.TableName = "trans_mfo_pap"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "trans_id"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "mfo_pap_name"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "mfo_pap_code"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "mfo_responsibility_center"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "mfo_pap_id"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sel"
        Me.DataColumn16.DataType = GetType(Boolean)
        Me.DataColumn16.DefaultValue = False
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "deleted"
        Me.DataColumn17.DataType = GetType(Boolean)
        Me.DataColumn17.DefaultValue = False
        '
        'lib_erp_fund_cluster
        '
        Me.lib_erp_fund_cluster.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.lib_erp_fund_cluster.TableName = "lib_erp_fund_cluster"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fund_id"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "fund_code"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "fund_name"
        '
        'lib_erp_mfo
        '
        Me.lib_erp_mfo.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.lib_erp_mfo.TableName = "lib_erp_mfo"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "mfo_id"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "mfo_code"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "mfo_name"
        '
        'additional
        '
        Me.additional.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn3, Me.DataColumn15, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.additional.TableName = "additional"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_additional_id"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "trans_id"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "ors_burs_no"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "fund_cluster"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "mode_of_payment"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "fund_name"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'rdo_mds_check
        '
        Me.rdo_mds_check.AlwaysDisable = False
        Me.rdo_mds_check.AlwaysEnable = False
        resources.ApplyResources(Me.rdo_mds_check, "rdo_mds_check")
        Me.rdo_mds_check.Name = "rdo_mds_check"
        Me.rdo_mds_check.TabStop = True
        Me.rdo_mds_check.Uncheckable = False
        Me.rdo_mds_check.UseVisualStyleBackColor = True
        Me.rdo_mds_check.Value = "1"
        '
        'rdo_commercial_check
        '
        Me.rdo_commercial_check.AlwaysDisable = False
        Me.rdo_commercial_check.AlwaysEnable = False
        resources.ApplyResources(Me.rdo_commercial_check, "rdo_commercial_check")
        Me.rdo_commercial_check.Name = "rdo_commercial_check"
        Me.rdo_commercial_check.TabStop = True
        Me.rdo_commercial_check.Tag = ""
        Me.rdo_commercial_check.Uncheckable = False
        Me.rdo_commercial_check.UseVisualStyleBackColor = True
        Me.rdo_commercial_check.Value = "2"
        '
        'rdo_ada
        '
        Me.rdo_ada.AlwaysDisable = False
        Me.rdo_ada.AlwaysEnable = False
        resources.ApplyResources(Me.rdo_ada, "rdo_ada")
        Me.rdo_ada.Name = "rdo_ada"
        Me.rdo_ada.TabStop = True
        Me.rdo_ada.Uncheckable = False
        Me.rdo_ada.UseVisualStyleBackColor = True
        Me.rdo_ada.Value = "3"
        '
        'rdo_others
        '
        Me.rdo_others.AlwaysDisable = False
        Me.rdo_others.AlwaysEnable = False
        resources.ApplyResources(Me.rdo_others, "rdo_others")
        Me.rdo_others.Name = "rdo_others"
        Me.rdo_others.TabStop = True
        Me.rdo_others.Uncheckable = False
        Me.rdo_others.UseVisualStyleBackColor = True
        Me.rdo_others.Value = "4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_mode_of_payment)
        Me.GroupBox1.Controls.Add(Me.rdo_others)
        Me.GroupBox1.Controls.Add(Me.rdo_mds_check)
        Me.GroupBox1.Controls.Add(Me.rdo_ada)
        Me.GroupBox1.Controls.Add(Me.rdo_commercial_check)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txt_mode_of_payment
        '
        Me.txt_mode_of_payment._Text = ""
        Me.txt_mode_of_payment.AllowNegative = False
        Me.txt_mode_of_payment.AlwaysDisable = False
        Me.txt_mode_of_payment.AlwaysEnable = False
        Me.txt_mode_of_payment.BackColor = System.Drawing.Color.White
        Me.txt_mode_of_payment.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_mode_of_payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mode_of_payment.DataSource = ""
        Me.txt_mode_of_payment.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mode_of_payment.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_mode_of_payment.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_mode_of_payment.EnabledBackColor = System.Drawing.Color.White
        Me.txt_mode_of_payment.ispk = False
        resources.ApplyResources(Me.txt_mode_of_payment, "txt_mode_of_payment")
        Me.txt_mode_of_payment.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mode_of_payment.MultiLine = False
        Me.txt_mode_of_payment.Name = "txt_mode_of_payment"
        Me.txt_mode_of_payment.NoClear = False
        Me.txt_mode_of_payment.NumberFormat = "@"
        Me.txt_mode_of_payment.Required = False
        Me.txt_mode_of_payment.RowData = Nothing
        Me.txt_mode_of_payment.SelectionLength = 0
        Me.txt_mode_of_payment.SelectionStart = 0
        Me.txt_mode_of_payment.TableData = Nothing
        Me.txt_mode_of_payment.TextSource = ""
        Me.txt_mode_of_payment.UseSystemPasswordChar = False
        Me.txt_mode_of_payment.Value = ""
        Me.txt_mode_of_payment.ValueSource = ""
        '
        'txt_fund_code
        '
        Me.txt_fund_code._Text = ""
        Me.txt_fund_code.AllowNegative = False
        Me.txt_fund_code.AlwaysDisable = False
        Me.txt_fund_code.AlwaysEnable = False
        Me.txt_fund_code.BackColor = System.Drawing.Color.White
        Me.txt_fund_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_fund_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fund_code.DataSource = ""
        Me.txt_fund_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fund_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fund_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_fund_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_fund_code.ispk = False
        resources.ApplyResources(Me.txt_fund_code, "txt_fund_code")
        Me.txt_fund_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fund_code.MultiLine = False
        Me.txt_fund_code.Name = "txt_fund_code"
        Me.txt_fund_code.NoClear = False
        Me.txt_fund_code.NumberFormat = "@"
        Me.txt_fund_code.Required = False
        Me.txt_fund_code.RowData = Nothing
        Me.txt_fund_code.SelectionLength = 0
        Me.txt_fund_code.SelectionStart = 0
        Me.txt_fund_code.TableData = Nothing
        Me.txt_fund_code.TextSource = ""
        Me.txt_fund_code.UseSystemPasswordChar = False
        Me.txt_fund_code.Value = ""
        Me.txt_fund_code.ValueSource = ""
        '
        'mfo_pap_namesssss
        '
        Me.mfo_pap_namesssss.DataPropertyName = "mfo_pap_name"
        resources.ApplyResources(Me.mfo_pap_namesssss, "mfo_pap_namesssss")
        Me.mfo_pap_namesssss.Name = "mfo_pap_namesssss"
        '
        'mfo_pap_codessss
        '
        Me.mfo_pap_codessss.DataPropertyName = "mfo_pap_code"
        resources.ApplyResources(Me.mfo_pap_codessss, "mfo_pap_codessss")
        Me.mfo_pap_codessss.Name = "mfo_pap_codessss"
        '
        'mfo_responsibility_centersss
        '
        Me.mfo_responsibility_centersss.DataPropertyName = "mfo_responsibility_center"
        resources.ApplyResources(Me.mfo_responsibility_centersss, "mfo_responsibility_centersss")
        Me.mfo_responsibility_centersss.Name = "mfo_responsibility_centersss"
        '
        'bs_trans_mfo_pap
        '
        Me.bs_trans_mfo_pap.DataMember = "trans_mfo_pap"
        Me.bs_trans_mfo_pap.DataSource = Me.ds
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_trans_additional_id)
        Me.Panel1.Controls.Add(Me.txt_trans_id)
        Me.Panel1.Controls.Add(Me.txt_mfo_pap_code)
        Me.Panel1.Controls.Add(Me.txt_mfo_pap_name)
        Me.Panel1.Controls.Add(Me.txt_mfo_pap_id)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnInsert)
        Me.Panel1.Controls.Add(Me.txt_mfo_responsibility_center)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnNotSave)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Tag = "container"
        '
        'txt_trans_additional_id
        '
        Me.txt_trans_additional_id._Text = ""
        Me.txt_trans_additional_id.AllowNegative = False
        Me.txt_trans_additional_id.AlwaysDisable = False
        Me.txt_trans_additional_id.AlwaysEnable = False
        Me.txt_trans_additional_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_additional_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_additional_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_additional_id.DataSource = ""
        Me.txt_trans_additional_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_additional_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_additional_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        resources.ApplyResources(Me.txt_trans_additional_id, "txt_trans_additional_id")
        Me.txt_trans_additional_id.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_trans_additional_id.ispk = False
        Me.txt_trans_additional_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_additional_id.MultiLine = False
        Me.txt_trans_additional_id.Name = "txt_trans_additional_id"
        Me.txt_trans_additional_id.NoClear = False
        Me.txt_trans_additional_id.NumberFormat = "@"
        Me.txt_trans_additional_id.Required = False
        Me.txt_trans_additional_id.RowData = Nothing
        Me.txt_trans_additional_id.SelectionLength = 0
        Me.txt_trans_additional_id.SelectionStart = 0
        Me.txt_trans_additional_id.TableData = Nothing
        Me.txt_trans_additional_id.Tag = "focus"
        Me.txt_trans_additional_id.TextSource = ""
        Me.txt_trans_additional_id.UseSystemPasswordChar = False
        Me.txt_trans_additional_id.Value = ""
        Me.txt_trans_additional_id.ValueSource = ""
        '
        'txt_trans_id
        '
        Me.txt_trans_id._Text = ""
        Me.txt_trans_id.AllowNegative = False
        Me.txt_trans_id.AlwaysDisable = False
        Me.txt_trans_id.AlwaysEnable = False
        Me.txt_trans_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_id.DataSource = ""
        Me.txt_trans_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        resources.ApplyResources(Me.txt_trans_id, "txt_trans_id")
        Me.txt_trans_id.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_trans_id.ispk = False
        Me.txt_trans_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_id.MultiLine = False
        Me.txt_trans_id.Name = "txt_trans_id"
        Me.txt_trans_id.NoClear = False
        Me.txt_trans_id.NumberFormat = "@"
        Me.txt_trans_id.Required = False
        Me.txt_trans_id.RowData = Nothing
        Me.txt_trans_id.SelectionLength = 0
        Me.txt_trans_id.SelectionStart = 0
        Me.txt_trans_id.TableData = Nothing
        Me.txt_trans_id.Tag = "focus"
        Me.txt_trans_id.TextSource = ""
        Me.txt_trans_id.UseSystemPasswordChar = False
        Me.txt_trans_id.Value = ""
        Me.txt_trans_id.ValueSource = ""
        '
        'txt_mfo_pap_code
        '
        Me.txt_mfo_pap_code._Text = ""
        Me.txt_mfo_pap_code.AllowNegative = False
        Me.txt_mfo_pap_code.AlwaysDisable = False
        Me.txt_mfo_pap_code.AlwaysEnable = False
        Me.txt_mfo_pap_code.BackColor = System.Drawing.Color.White
        Me.txt_mfo_pap_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_mfo_pap_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mfo_pap_code.DataSource = ""
        Me.txt_mfo_pap_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mfo_pap_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_mfo_pap_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_mfo_pap_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_mfo_pap_code.ispk = False
        resources.ApplyResources(Me.txt_mfo_pap_code, "txt_mfo_pap_code")
        Me.txt_mfo_pap_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mfo_pap_code.MultiLine = False
        Me.txt_mfo_pap_code.Name = "txt_mfo_pap_code"
        Me.txt_mfo_pap_code.NoClear = False
        Me.txt_mfo_pap_code.NumberFormat = "@"
        Me.txt_mfo_pap_code.Required = False
        Me.txt_mfo_pap_code.RowData = Nothing
        Me.txt_mfo_pap_code.SelectionLength = 0
        Me.txt_mfo_pap_code.SelectionStart = 0
        Me.txt_mfo_pap_code.TableData = Nothing
        Me.txt_mfo_pap_code.TextSource = ""
        Me.txt_mfo_pap_code.UseSystemPasswordChar = False
        Me.txt_mfo_pap_code.Value = ""
        Me.txt_mfo_pap_code.ValueSource = ""
        '
        'txt_mfo_pap_name
        '
        Me.txt_mfo_pap_name._Text = ""
        Me.txt_mfo_pap_name.AllowNegative = False
        Me.txt_mfo_pap_name.AlwaysDisable = False
        Me.txt_mfo_pap_name.AlwaysEnable = False
        Me.txt_mfo_pap_name.BackColor = System.Drawing.Color.White
        Me.txt_mfo_pap_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_mfo_pap_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mfo_pap_name.DataSource = ""
        Me.txt_mfo_pap_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mfo_pap_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_mfo_pap_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_mfo_pap_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_mfo_pap_name.ispk = False
        resources.ApplyResources(Me.txt_mfo_pap_name, "txt_mfo_pap_name")
        Me.txt_mfo_pap_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mfo_pap_name.MultiLine = False
        Me.txt_mfo_pap_name.Name = "txt_mfo_pap_name"
        Me.txt_mfo_pap_name.NoClear = False
        Me.txt_mfo_pap_name.NumberFormat = "@"
        Me.txt_mfo_pap_name.Required = True
        Me.txt_mfo_pap_name.RowData = Nothing
        Me.txt_mfo_pap_name.SelectionLength = 0
        Me.txt_mfo_pap_name.SelectionStart = 0
        Me.txt_mfo_pap_name.TableData = Nothing
        Me.txt_mfo_pap_name.TextSource = ""
        Me.txt_mfo_pap_name.UseSystemPasswordChar = False
        Me.txt_mfo_pap_name.Value = ""
        Me.txt_mfo_pap_name.ValueSource = ""
        '
        'txt_mfo_pap_id
        '
        Me.txt_mfo_pap_id._Text = ""
        Me.txt_mfo_pap_id.AllowNegative = False
        Me.txt_mfo_pap_id.AlwaysDisable = False
        Me.txt_mfo_pap_id.AlwaysEnable = False
        Me.txt_mfo_pap_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_mfo_pap_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_mfo_pap_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mfo_pap_id.DataSource = ""
        Me.txt_mfo_pap_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mfo_pap_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_mfo_pap_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        resources.ApplyResources(Me.txt_mfo_pap_id, "txt_mfo_pap_id")
        Me.txt_mfo_pap_id.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_mfo_pap_id.ispk = False
        Me.txt_mfo_pap_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mfo_pap_id.MultiLine = False
        Me.txt_mfo_pap_id.Name = "txt_mfo_pap_id"
        Me.txt_mfo_pap_id.NoClear = False
        Me.txt_mfo_pap_id.NumberFormat = "@"
        Me.txt_mfo_pap_id.Required = False
        Me.txt_mfo_pap_id.RowData = Nothing
        Me.txt_mfo_pap_id.SelectionLength = 0
        Me.txt_mfo_pap_id.SelectionStart = 0
        Me.txt_mfo_pap_id.TableData = Nothing
        Me.txt_mfo_pap_id.Tag = "focus"
        Me.txt_mfo_pap_id.TextSource = ""
        Me.txt_mfo_pap_id.UseSystemPasswordChar = False
        Me.txt_mfo_pap_id.Value = ""
        Me.txt_mfo_pap_id.ValueSource = ""
        '
        'btnUpdate
        '
        resources.ApplyResources(Me.btnUpdate, "btnUpdate")
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        resources.ApplyResources(Me.btnRemove, "btnRemove")
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        resources.ApplyResources(Me.btnInsert, "btnInsert")
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txt_mfo_responsibility_center
        '
        Me.txt_mfo_responsibility_center._Text = ""
        Me.txt_mfo_responsibility_center.AllowNegative = False
        Me.txt_mfo_responsibility_center.AlwaysDisable = False
        Me.txt_mfo_responsibility_center.AlwaysEnable = False
        Me.txt_mfo_responsibility_center.BackColor = System.Drawing.Color.White
        Me.txt_mfo_responsibility_center.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_mfo_responsibility_center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mfo_responsibility_center.DataSource = ""
        Me.txt_mfo_responsibility_center.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mfo_responsibility_center.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_mfo_responsibility_center.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_mfo_responsibility_center.EnabledBackColor = System.Drawing.Color.White
        Me.txt_mfo_responsibility_center.ispk = False
        resources.ApplyResources(Me.txt_mfo_responsibility_center, "txt_mfo_responsibility_center")
        Me.txt_mfo_responsibility_center.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_mfo_responsibility_center.MultiLine = False
        Me.txt_mfo_responsibility_center.Name = "txt_mfo_responsibility_center"
        Me.txt_mfo_responsibility_center.NoClear = False
        Me.txt_mfo_responsibility_center.NumberFormat = "@"
        Me.txt_mfo_responsibility_center.Required = False
        Me.txt_mfo_responsibility_center.RowData = Nothing
        Me.txt_mfo_responsibility_center.SelectionLength = 0
        Me.txt_mfo_responsibility_center.SelectionStart = 0
        Me.txt_mfo_responsibility_center.TableData = Nothing
        Me.txt_mfo_responsibility_center.TextSource = ""
        Me.txt_mfo_responsibility_center.UseSystemPasswordChar = False
        Me.txt_mfo_responsibility_center.Value = ""
        Me.txt_mfo_responsibility_center.ValueSource = ""
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNotSave
        '
        resources.ApplyResources(Me.btnNotSave, "btnNotSave")
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.UseVisualStyleBackColor = True
        '
        'dgMFO
        '
        Me.dgMFO.AllowUserToAddRows = False
        Me.dgMFO.AllowUserToDeleteRows = False
        Me.dgMFO.AutoGenerateColumns = False
        Me.dgMFO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.trans_id, Me.mfo_pap_name, Me.mfo_pap_code, Me.mfo_responsibility_center, Me.mfo_pap_id, Me.deleted})
        Me.dgMFO.DataSource = Me.bs_trans_mfo_pap
        resources.ApplyResources(Me.dgMFO, "dgMFO")
        Me.dgMFO.Name = "dgMFO"
        Me.dgMFO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMFO.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        resources.ApplyResources(Me.sel, "sel")
        Me.sel.Name = "sel"
        '
        'trans_id
        '
        Me.trans_id.DataPropertyName = "trans_id"
        resources.ApplyResources(Me.trans_id, "trans_id")
        Me.trans_id.Name = "trans_id"
        '
        'mfo_pap_name
        '
        Me.mfo_pap_name.DataPropertyName = "mfo_pap_name"
        resources.ApplyResources(Me.mfo_pap_name, "mfo_pap_name")
        Me.mfo_pap_name.Name = "mfo_pap_name"
        '
        'mfo_pap_code
        '
        Me.mfo_pap_code.DataPropertyName = "mfo_pap_code"
        resources.ApplyResources(Me.mfo_pap_code, "mfo_pap_code")
        Me.mfo_pap_code.Name = "mfo_pap_code"
        '
        'mfo_responsibility_center
        '
        Me.mfo_responsibility_center.DataPropertyName = "mfo_responsibility_center"
        resources.ApplyResources(Me.mfo_responsibility_center, "mfo_responsibility_center")
        Me.mfo_responsibility_center.Name = "mfo_responsibility_center"
        '
        'mfo_pap_id
        '
        Me.mfo_pap_id.DataPropertyName = "mfo_pap_id"
        resources.ApplyResources(Me.mfo_pap_id, "mfo_pap_id")
        Me.mfo_pap_id.Name = "mfo_pap_id"
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        resources.ApplyResources(Me.deleted, "deleted")
        Me.deleted.Name = "deleted"
        '
        'txt_fund_name
        '
        Me.txt_fund_name._Text = ""
        Me.txt_fund_name.AllowNegative = False
        Me.txt_fund_name.AlwaysDisable = False
        Me.txt_fund_name.AlwaysEnable = False
        Me.txt_fund_name.BackColor = System.Drawing.Color.White
        Me.txt_fund_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_fund_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fund_name.DataSource = ""
        Me.txt_fund_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fund_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fund_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_fund_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_fund_name.ispk = False
        resources.ApplyResources(Me.txt_fund_name, "txt_fund_name")
        Me.txt_fund_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_fund_name.MultiLine = False
        Me.txt_fund_name.Name = "txt_fund_name"
        Me.txt_fund_name.NoClear = False
        Me.txt_fund_name.NumberFormat = "@"
        Me.txt_fund_name.Required = False
        Me.txt_fund_name.RowData = Nothing
        Me.txt_fund_name.SelectionLength = 0
        Me.txt_fund_name.SelectionStart = 0
        Me.txt_fund_name.TableData = Nothing
        Me.txt_fund_name.TextSource = ""
        Me.txt_fund_name.UseSystemPasswordChar = False
        Me.txt_fund_name.Value = ""
        Me.txt_fund_name.ValueSource = ""
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        resources.ApplyResources(Me.border1, "border1")
        Me.border1.Name = "border1"
        '
        'report_cv_erc_filter
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txt_fund_name)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.dgMFO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ors_burs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_fund)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txt_fund_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "report_cv_erc_filter"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_additional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_mfo_pap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_fund_cluster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_mfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.additional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bs_trans_mfo_pap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgMFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents lbl_fund As Windows.Forms.Label
    Friend WithEvents txt_ors_burs As user_control.textbox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents ds As DataSet
    Friend WithEvents border1 As borderedlabel
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents rdo_others As user_control.MyRadioButton
    Friend WithEvents rdo_ada As user_control.MyRadioButton
    Friend WithEvents rdo_commercial_check As user_control.MyRadioButton
    Friend WithEvents rdo_mds_check As user_control.MyRadioButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents txt_fund_code As user_control.textbox
    Friend WithEvents trans_additional As DataTable
    Friend WithEvents trans_mfo_pap As DataTable
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    'Friend WithEvents trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mfo_pap_namesssss As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mfo_pap_codessss As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mfo_responsibility_centersss As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lib_erp_fund_cluster As DataTable
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents lib_erp_mfo As DataTable
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents bs_trans_mfo_pap As Windows.Forms.BindingSource
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents dgMFO As Windows.Forms.DataGridView
    Friend WithEvents btnInsert As Windows.Forms.Button
    Friend WithEvents txt_mfo_responsibility_center As user_control.textbox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txt_mfo_pap_id As user_control.textbox
    Friend WithEvents txt_mfo_pap_code As user_control.textbox
    Friend WithEvents txt_mfo_pap_name As user_control.textbox
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents txt_trans_id As user_control.textbox
    Friend WithEvents btnNotSave As Windows.Forms.Button
    Friend WithEvents txt_fund_name As user_control.textbox
    Friend WithEvents txt_mode_of_payment As user_control.textbox
    Friend WithEvents txt_trans_additional_id As user_control.textbox
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents additional As DataTable
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents DataColumn18 As DataColumn
    Friend WithEvents DataColumn19 As DataColumn
    Friend WithEvents DataColumn20 As DataColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mfo_pap_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mfo_pap_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mfo_responsibility_center As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mfo_pap_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataColumn21 As DataColumn
End Class
