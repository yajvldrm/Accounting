<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_project_management_reports
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
        Me.grp_filter = New System.Windows.Forms.GroupBox()
        Me.chk_project_management_accomplishment_summary = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_project_management_subsidiary = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_project_income_and_expense_analysis_summary = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_project_income_and_expense_analysis_detailed = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_project_management_accomplishment_detailed = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_project_management_analysis = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateasOf = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_Preview = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_currency_ = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_per_year_reference = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_all_year_reference = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_per_project_code = New DevExpress.XtraEditors.CheckEdit()
        Me.grp_orig = New System.Windows.Forms.GroupBox()
        Me.txt_project_code = New user_control.textbox()
        Me.txt_per_currency = New user_control.textbox()
        Me.txt_per_currency_names = New System.Windows.Forms.TextBox()
        Me.txt_project_name = New System.Windows.Forms.TextBox()
        Me.txt_year_ref = New System.Windows.Forms.NumericUpDown()
        Me.grp_exp_analysis_summary = New System.Windows.Forms.GroupBox()
        Me.txt_per_project_code = New user_control.textbox()
        Me.txt_per_currency_code = New user_control.textbox()
        Me.txt_per_year_code = New System.Windows.Forms.NumericUpDown()
        Me.txt_per_currency_name = New System.Windows.Forms.TextBox()
        Me.txt_per_project_name = New System.Windows.Forms.TextBox()
        Me.chk_per_currency = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_per_year = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_per_project = New DevExpress.XtraEditors.CheckEdit()
        Me.grp_filter.SuspendLayout()
        CType(Me.chk_project_management_accomplishment_summary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_project_management_subsidiary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_project_income_and_expense_analysis_summary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_project_income_and_expense_analysis_detailed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_project_management_accomplishment_detailed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_project_management_analysis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dateasOf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_currency_.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_per_year_reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_all_year_reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_per_project_code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_orig.SuspendLayout()
        CType(Me.txt_year_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_exp_analysis_summary.SuspendLayout()
        CType(Me.txt_per_year_code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_per_currency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_per_year.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_per_project.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_filter
        '
        Me.grp_filter.Controls.Add(Me.chk_project_management_accomplishment_summary)
        Me.grp_filter.Controls.Add(Me.chk_project_management_subsidiary)
        Me.grp_filter.Controls.Add(Me.chk_project_income_and_expense_analysis_summary)
        Me.grp_filter.Controls.Add(Me.chk_project_income_and_expense_analysis_detailed)
        Me.grp_filter.Controls.Add(Me.chk_project_management_accomplishment_detailed)
        Me.grp_filter.Controls.Add(Me.chk_project_management_analysis)
        Me.grp_filter.Location = New System.Drawing.Point(8, 37)
        Me.grp_filter.Name = "grp_filter"
        Me.grp_filter.Size = New System.Drawing.Size(260, 158)
        Me.grp_filter.TabIndex = 6
        Me.grp_filter.TabStop = False
        '
        'chk_project_management_accomplishment_summary
        '
        Me.chk_project_management_accomplishment_summary.Location = New System.Drawing.Point(6, 110)
        Me.chk_project_management_accomplishment_summary.Name = "chk_project_management_accomplishment_summary"
        Me.chk_project_management_accomplishment_summary.Properties.Caption = "Project Management Accomplishment Summary"
        Me.chk_project_management_accomplishment_summary.Size = New System.Drawing.Size(264, 19)
        Me.chk_project_management_accomplishment_summary.TabIndex = 8
        '
        'chk_project_management_subsidiary
        '
        Me.chk_project_management_subsidiary.Location = New System.Drawing.Point(6, 35)
        Me.chk_project_management_subsidiary.Name = "chk_project_management_subsidiary"
        Me.chk_project_management_subsidiary.Properties.Caption = "Project Management Subsidiary"
        Me.chk_project_management_subsidiary.Size = New System.Drawing.Size(244, 19)
        Me.chk_project_management_subsidiary.TabIndex = 7
        '
        'chk_project_income_and_expense_analysis_summary
        '
        Me.chk_project_income_and_expense_analysis_summary.Location = New System.Drawing.Point(6, 60)
        Me.chk_project_income_and_expense_analysis_summary.Name = "chk_project_income_and_expense_analysis_summary"
        Me.chk_project_income_and_expense_analysis_summary.Properties.Caption = "Project Income and Expense Analysis Summary"
        Me.chk_project_income_and_expense_analysis_summary.Size = New System.Drawing.Size(257, 19)
        Me.chk_project_income_and_expense_analysis_summary.TabIndex = 6
        '
        'chk_project_income_and_expense_analysis_detailed
        '
        Me.chk_project_income_and_expense_analysis_detailed.Location = New System.Drawing.Point(6, 85)
        Me.chk_project_income_and_expense_analysis_detailed.Name = "chk_project_income_and_expense_analysis_detailed"
        Me.chk_project_income_and_expense_analysis_detailed.Properties.Caption = "Project Income and Expense Analysis Detailed"
        Me.chk_project_income_and_expense_analysis_detailed.Size = New System.Drawing.Size(264, 19)
        Me.chk_project_income_and_expense_analysis_detailed.TabIndex = 5
        '
        'chk_project_management_accomplishment_detailed
        '
        Me.chk_project_management_accomplishment_detailed.Location = New System.Drawing.Point(6, 135)
        Me.chk_project_management_accomplishment_detailed.Name = "chk_project_management_accomplishment_detailed"
        Me.chk_project_management_accomplishment_detailed.Properties.Caption = "Project Management Accomplishment Detailed"
        Me.chk_project_management_accomplishment_detailed.Size = New System.Drawing.Size(244, 19)
        Me.chk_project_management_accomplishment_detailed.TabIndex = 3
        '
        'chk_project_management_analysis
        '
        Me.chk_project_management_analysis.EditValue = True
        Me.chk_project_management_analysis.Location = New System.Drawing.Point(6, 10)
        Me.chk_project_management_analysis.Name = "chk_project_management_analysis"
        Me.chk_project_management_analysis.Properties.Caption = "Project Management Analysis"
        Me.chk_project_management_analysis.Size = New System.Drawing.Size(193, 19)
        Me.chk_project_management_analysis.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtp_to)
        Me.GroupBox3.Controls.Add(Me.dtp_from)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dateasOf)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 84)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'dtp_to
        '
        Me.dtp_to.Location = New System.Drawing.Point(81, 59)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(181, 20)
        Me.dtp_to.TabIndex = 16
        '
        'dtp_from
        '
        Me.dtp_from.Location = New System.Drawing.Point(81, 35)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(181, 20)
        Me.dtp_from.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Date to"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date From "
        '
        'dateasOf
        '
        Me.dateasOf.Location = New System.Drawing.Point(5, 11)
        Me.dateasOf.Name = "dateasOf"
        Me.dateasOf.Properties.Caption = "Date as Of"
        Me.dateasOf.Size = New System.Drawing.Size(84, 19)
        Me.dateasOf.TabIndex = 12
        '
        'btn_Preview
        '
        Me.btn_Preview.Location = New System.Drawing.Point(20, 387)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.Size = New System.Drawing.Size(75, 23)
        Me.btn_Preview.TabIndex = 17
        Me.btn_Preview.Text = "Preview"
        Me.btn_Preview.UseVisualStyleBackColor = True
        '
        'btn_excel
        '
        Me.btn_excel.Location = New System.Drawing.Point(101, 387)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(75, 23)
        Me.btn_excel.TabIndex = 17
        Me.btn_excel.Text = "Excel"
        Me.btn_excel.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(182, 387)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 17
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-4, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 33)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Project Management"
        '
        'chk_currency_
        '
        Me.chk_currency_.Location = New System.Drawing.Point(7, 84)
        Me.chk_currency_.Name = "chk_currency_"
        Me.chk_currency_.Properties.Caption = "Per Currency"
        Me.chk_currency_.Size = New System.Drawing.Size(109, 19)
        Me.chk_currency_.TabIndex = 9
        '
        'chk_per_year_reference
        '
        Me.chk_per_year_reference.Location = New System.Drawing.Point(7, 34)
        Me.chk_per_year_reference.Name = "chk_per_year_reference"
        Me.chk_per_year_reference.Properties.Caption = "Per Year Reference"
        Me.chk_per_year_reference.Size = New System.Drawing.Size(123, 19)
        Me.chk_per_year_reference.TabIndex = 10
        '
        'chk_all_year_reference
        '
        Me.chk_all_year_reference.EditValue = True
        Me.chk_all_year_reference.Location = New System.Drawing.Point(7, 9)
        Me.chk_all_year_reference.Name = "chk_all_year_reference"
        Me.chk_all_year_reference.Properties.Caption = "All Year Reference"
        Me.chk_all_year_reference.Size = New System.Drawing.Size(123, 19)
        Me.chk_all_year_reference.TabIndex = 11
        '
        'chk_per_project_code
        '
        Me.chk_per_project_code.Location = New System.Drawing.Point(7, 59)
        Me.chk_per_project_code.Name = "chk_per_project_code"
        Me.chk_per_project_code.Properties.Caption = "Per Project Code"
        Me.chk_per_project_code.Size = New System.Drawing.Size(109, 19)
        Me.chk_per_project_code.TabIndex = 12
        '
        'grp_orig
        '
        Me.grp_orig.Controls.Add(Me.txt_project_code)
        Me.grp_orig.Controls.Add(Me.txt_per_currency)
        Me.grp_orig.Controls.Add(Me.txt_per_currency_names)
        Me.grp_orig.Controls.Add(Me.txt_project_name)
        Me.grp_orig.Controls.Add(Me.txt_year_ref)
        Me.grp_orig.Controls.Add(Me.chk_per_project_code)
        Me.grp_orig.Controls.Add(Me.chk_all_year_reference)
        Me.grp_orig.Controls.Add(Me.chk_per_year_reference)
        Me.grp_orig.Controls.Add(Me.chk_currency_)
        Me.grp_orig.Location = New System.Drawing.Point(7, 194)
        Me.grp_orig.Name = "grp_orig"
        Me.grp_orig.Size = New System.Drawing.Size(260, 107)
        Me.grp_orig.TabIndex = 7
        Me.grp_orig.TabStop = False
        '
        'txt_project_code
        '
        Me.txt_project_code._Text = ""
        Me.txt_project_code.AllowNegative = False
        Me.txt_project_code.AlwaysDisable = False
        Me.txt_project_code.AlwaysEnable = False
        Me.txt_project_code.BackColor = System.Drawing.Color.White
        Me.txt_project_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_code.DataSource = ""
        Me.txt_project_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_code.ispk = False
        Me.txt_project_code.Location = New System.Drawing.Point(122, 58)
        Me.txt_project_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_code.MultiLine = False
        Me.txt_project_code.Name = "txt_project_code"
        Me.txt_project_code.NoClear = False
        Me.txt_project_code.NumberFormat = "@"
        Me.txt_project_code.Required = False
        Me.txt_project_code.RowData = Nothing
        Me.txt_project_code.SelectionLength = 0
        Me.txt_project_code.SelectionStart = 0
        Me.txt_project_code.Size = New System.Drawing.Size(49, 20)
        Me.txt_project_code.TabIndex = 27
        Me.txt_project_code.TableData = Nothing
        Me.txt_project_code.TextSource = ""
        Me.txt_project_code.UseSystemPasswordChar = False
        Me.txt_project_code.Value = ""
        Me.txt_project_code.ValueSource = ""
        Me.txt_project_code.Visible = False
        '
        'txt_per_currency
        '
        Me.txt_per_currency._Text = ""
        Me.txt_per_currency.AllowNegative = False
        Me.txt_per_currency.AlwaysDisable = False
        Me.txt_per_currency.AlwaysEnable = False
        Me.txt_per_currency.BackColor = System.Drawing.Color.White
        Me.txt_per_currency.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_per_currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_per_currency.DataSource = ""
        Me.txt_per_currency.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_per_currency.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_per_currency.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_per_currency.EnabledBackColor = System.Drawing.Color.White
        Me.txt_per_currency.ispk = False
        Me.txt_per_currency.Location = New System.Drawing.Point(122, 84)
        Me.txt_per_currency.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_per_currency.MultiLine = False
        Me.txt_per_currency.Name = "txt_per_currency"
        Me.txt_per_currency.NoClear = False
        Me.txt_per_currency.NumberFormat = "@"
        Me.txt_per_currency.Required = False
        Me.txt_per_currency.RowData = Nothing
        Me.txt_per_currency.SelectionLength = 0
        Me.txt_per_currency.SelectionStart = 0
        Me.txt_per_currency.Size = New System.Drawing.Size(49, 20)
        Me.txt_per_currency.TabIndex = 26
        Me.txt_per_currency.TableData = Nothing
        Me.txt_per_currency.TextSource = ""
        Me.txt_per_currency.UseSystemPasswordChar = False
        Me.txt_per_currency.Value = ""
        Me.txt_per_currency.ValueSource = ""
        Me.txt_per_currency.Visible = False
        '
        'txt_per_currency_names
        '
        Me.txt_per_currency_names.Location = New System.Drawing.Point(175, 83)
        Me.txt_per_currency_names.Name = "txt_per_currency_names"
        Me.txt_per_currency_names.ReadOnly = True
        Me.txt_per_currency_names.Size = New System.Drawing.Size(79, 20)
        Me.txt_per_currency_names.TabIndex = 25
        Me.txt_per_currency_names.Visible = False
        '
        'txt_project_name
        '
        Me.txt_project_name.Location = New System.Drawing.Point(175, 58)
        Me.txt_project_name.Name = "txt_project_name"
        Me.txt_project_name.ReadOnly = True
        Me.txt_project_name.Size = New System.Drawing.Size(79, 20)
        Me.txt_project_name.TabIndex = 24
        Me.txt_project_name.Visible = False
        '
        'txt_year_ref
        '
        Me.txt_year_ref.Location = New System.Drawing.Point(122, 34)
        Me.txt_year_ref.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year_ref.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year_ref.Name = "txt_year_ref"
        Me.txt_year_ref.Size = New System.Drawing.Size(132, 20)
        Me.txt_year_ref.TabIndex = 20
        Me.txt_year_ref.Tag = "pm_year"
        Me.txt_year_ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_year_ref.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.txt_year_ref.Visible = False
        '
        'grp_exp_analysis_summary
        '
        Me.grp_exp_analysis_summary.Controls.Add(Me.txt_per_project_code)
        Me.grp_exp_analysis_summary.Controls.Add(Me.txt_per_currency_code)
        Me.grp_exp_analysis_summary.Controls.Add(Me.txt_per_year_code)
        Me.grp_exp_analysis_summary.Controls.Add(Me.txt_per_currency_name)
        Me.grp_exp_analysis_summary.Controls.Add(Me.txt_per_project_name)
        Me.grp_exp_analysis_summary.Controls.Add(Me.chk_per_currency)
        Me.grp_exp_analysis_summary.Controls.Add(Me.chk_per_year)
        Me.grp_exp_analysis_summary.Controls.Add(Me.chk_per_project)
        Me.grp_exp_analysis_summary.Location = New System.Drawing.Point(7, 194)
        Me.grp_exp_analysis_summary.Name = "grp_exp_analysis_summary"
        Me.grp_exp_analysis_summary.Size = New System.Drawing.Size(260, 107)
        Me.grp_exp_analysis_summary.TabIndex = 19
        Me.grp_exp_analysis_summary.TabStop = False
        '
        'txt_per_project_code
        '
        Me.txt_per_project_code._Text = ""
        Me.txt_per_project_code.AllowNegative = False
        Me.txt_per_project_code.AlwaysDisable = False
        Me.txt_per_project_code.AlwaysEnable = False
        Me.txt_per_project_code.BackColor = System.Drawing.Color.White
        Me.txt_per_project_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_per_project_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_per_project_code.DataSource = ""
        Me.txt_per_project_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_per_project_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_per_project_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_per_project_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_per_project_code.ispk = False
        Me.txt_per_project_code.Location = New System.Drawing.Point(91, 42)
        Me.txt_per_project_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_per_project_code.MultiLine = False
        Me.txt_per_project_code.Name = "txt_per_project_code"
        Me.txt_per_project_code.NoClear = False
        Me.txt_per_project_code.NumberFormat = "@"
        Me.txt_per_project_code.Required = False
        Me.txt_per_project_code.RowData = Nothing
        Me.txt_per_project_code.SelectionLength = 0
        Me.txt_per_project_code.SelectionStart = 0
        Me.txt_per_project_code.Size = New System.Drawing.Size(63, 20)
        Me.txt_per_project_code.TabIndex = 23
        Me.txt_per_project_code.TableData = Nothing
        Me.txt_per_project_code.TextSource = ""
        Me.txt_per_project_code.UseSystemPasswordChar = False
        Me.txt_per_project_code.Value = ""
        Me.txt_per_project_code.ValueSource = ""
        Me.txt_per_project_code.Visible = False
        '
        'txt_per_currency_code
        '
        Me.txt_per_currency_code._Text = ""
        Me.txt_per_currency_code.AllowNegative = False
        Me.txt_per_currency_code.AlwaysDisable = False
        Me.txt_per_currency_code.AlwaysEnable = False
        Me.txt_per_currency_code.BackColor = System.Drawing.Color.White
        Me.txt_per_currency_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_per_currency_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_per_currency_code.DataSource = ""
        Me.txt_per_currency_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_per_currency_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_per_currency_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_per_currency_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_per_currency_code.ispk = False
        Me.txt_per_currency_code.Location = New System.Drawing.Point(91, 68)
        Me.txt_per_currency_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_per_currency_code.MultiLine = False
        Me.txt_per_currency_code.Name = "txt_per_currency_code"
        Me.txt_per_currency_code.NoClear = False
        Me.txt_per_currency_code.NumberFormat = "@"
        Me.txt_per_currency_code.Required = False
        Me.txt_per_currency_code.RowData = Nothing
        Me.txt_per_currency_code.SelectionLength = 0
        Me.txt_per_currency_code.SelectionStart = 0
        Me.txt_per_currency_code.Size = New System.Drawing.Size(63, 20)
        Me.txt_per_currency_code.TabIndex = 22
        Me.txt_per_currency_code.TableData = Nothing
        Me.txt_per_currency_code.TextSource = ""
        Me.txt_per_currency_code.UseSystemPasswordChar = False
        Me.txt_per_currency_code.Value = ""
        Me.txt_per_currency_code.ValueSource = ""
        Me.txt_per_currency_code.Visible = False
        '
        'txt_per_year_code
        '
        Me.txt_per_year_code.Location = New System.Drawing.Point(91, 16)
        Me.txt_per_year_code.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_per_year_code.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_per_year_code.Name = "txt_per_year_code"
        Me.txt_per_year_code.Size = New System.Drawing.Size(163, 20)
        Me.txt_per_year_code.TabIndex = 19
        Me.txt_per_year_code.Tag = "pm_year"
        Me.txt_per_year_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_per_year_code.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.txt_per_year_code.Visible = False
        '
        'txt_per_currency_name
        '
        Me.txt_per_currency_name.Location = New System.Drawing.Point(160, 67)
        Me.txt_per_currency_name.Name = "txt_per_currency_name"
        Me.txt_per_currency_name.ReadOnly = True
        Me.txt_per_currency_name.Size = New System.Drawing.Size(96, 20)
        Me.txt_per_currency_name.TabIndex = 18
        Me.txt_per_currency_name.Visible = False
        '
        'txt_per_project_name
        '
        Me.txt_per_project_name.Location = New System.Drawing.Point(160, 42)
        Me.txt_per_project_name.Name = "txt_per_project_name"
        Me.txt_per_project_name.ReadOnly = True
        Me.txt_per_project_name.Size = New System.Drawing.Size(96, 20)
        Me.txt_per_project_name.TabIndex = 17
        Me.txt_per_project_name.Visible = False
        '
        'chk_per_currency
        '
        Me.chk_per_currency.Location = New System.Drawing.Point(7, 67)
        Me.chk_per_currency.Name = "chk_per_currency"
        Me.chk_per_currency.Properties.Caption = "Per Currency"
        Me.chk_per_currency.Size = New System.Drawing.Size(88, 19)
        Me.chk_per_currency.TabIndex = 12
        '
        'chk_per_year
        '
        Me.chk_per_year.Location = New System.Drawing.Point(7, 17)
        Me.chk_per_year.Name = "chk_per_year"
        Me.chk_per_year.Properties.Caption = "Per Year"
        Me.chk_per_year.Size = New System.Drawing.Size(62, 19)
        Me.chk_per_year.TabIndex = 11
        '
        'chk_per_project
        '
        Me.chk_per_project.Location = New System.Drawing.Point(7, 42)
        Me.chk_per_project.Name = "chk_per_project"
        Me.chk_per_project.Properties.Caption = "Per Project "
        Me.chk_per_project.Size = New System.Drawing.Size(81, 19)
        Me.chk_per_project.TabIndex = 10
        '
        'frm_project_management_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 414)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.btn_Preview)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grp_filter)
        Me.Controls.Add(Me.grp_exp_analysis_summary)
        Me.Controls.Add(Me.grp_orig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_project_management_reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.grp_filter.ResumeLayout(False)
        CType(Me.chk_project_management_accomplishment_summary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_project_management_subsidiary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_project_income_and_expense_analysis_summary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_project_income_and_expense_analysis_detailed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_project_management_accomplishment_detailed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_project_management_analysis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dateasOf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_currency_.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_per_year_reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_all_year_reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_per_project_code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_orig.ResumeLayout(False)
        Me.grp_orig.PerformLayout()
        CType(Me.txt_year_ref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_exp_analysis_summary.ResumeLayout(False)
        Me.grp_exp_analysis_summary.PerformLayout()
        CType(Me.txt_per_year_code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_per_currency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_per_year.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_per_project.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_filter As Windows.Forms.GroupBox
    Friend WithEvents chk_project_management_accomplishment_summary As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_project_management_subsidiary As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_project_income_and_expense_analysis_summary As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_project_income_and_expense_analysis_detailed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_project_management_accomplishment_detailed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_project_management_analysis As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents dateasOf As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtp_to As Windows.Forms.DateTimePicker
    Friend WithEvents dtp_from As Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btn_Preview As Windows.Forms.Button
    Friend WithEvents btn_excel As Windows.Forms.Button
    Friend WithEvents btn_cancel As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents chk_currency_ As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_per_year_reference As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_all_year_reference As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_per_project_code As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grp_orig As Windows.Forms.GroupBox
    Friend WithEvents grp_exp_analysis_summary As Windows.Forms.GroupBox
    Friend WithEvents txt_per_currency_name As Windows.Forms.TextBox
    Friend WithEvents txt_per_project_name As Windows.Forms.TextBox
    Friend WithEvents chk_per_currency As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_per_year As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_per_project As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_per_year_code As Windows.Forms.NumericUpDown
    Friend WithEvents txt_per_project_code As user_control.textbox
    Friend WithEvents txt_per_currency_code As user_control.textbox
    Friend WithEvents txt_project_code As user_control.textbox
    Friend WithEvents txt_per_currency As user_control.textbox
    Friend WithEvents txt_per_currency_names As Windows.Forms.TextBox
    Friend WithEvents txt_project_name As Windows.Forms.TextBox
    Friend WithEvents txt_year_ref As Windows.Forms.NumericUpDown
End Class
