<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionSearch
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.filter_view = New System.Windows.Forms.DataGridView()
        Me.JournalcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChecknoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JournalidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JournalnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet()
        Me.trans_header = New System.Data.DataTable()
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
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filter_journal_id = New System.Windows.Forms.ComboBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.filter_trans_no = New System.Windows.Forms.TextBox()
        Me.filter_check_no = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_trans_date = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_general_name = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_check_no = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_trans_no = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.filter_date_from = New System.Windows.Forms.DateTimePicker()
        Me.filter_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_trans_id = New System.Windows.Forms.TextBox()
        Me.NeedToHide = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_book_id = New System.Windows.Forms.TextBox()
        Me.txt_book_name = New System.Windows.Forms.TextBox()
        Me.filter_general = New System.Windows.Forms.TextBox()
        CType(Me.filter_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NeedToHide.SuspendLayout()
        Me.SuspendLayout()
        '
        'filter_view
        '
        Me.filter_view.AllowUserToAddRows = False
        Me.filter_view.AllowUserToDeleteRows = False
        Me.filter_view.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filter_view.AutoGenerateColumns = False
        Me.filter_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.filter_view.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JournalcodeDataGridViewTextBoxColumn, Me.TransnoDataGridViewTextBoxColumn, Me.ChecknoDataGridViewTextBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.GeneralnameDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.TransidDataGridViewTextBoxColumn, Me.GeneralidDataGridViewTextBoxColumn, Me.GeneralcodeDataGridViewTextBoxColumn, Me.JournalidDataGridViewTextBoxColumn, Me.JournalnameDataGridViewTextBoxColumn})
        Me.filter_view.DataSource = Me.bs
        Me.filter_view.Location = New System.Drawing.Point(12, 72)
        Me.filter_view.MultiSelect = False
        Me.filter_view.Name = "filter_view"
        Me.filter_view.ReadOnly = True
        Me.filter_view.RowHeadersVisible = False
        Me.filter_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.filter_view.Size = New System.Drawing.Size(780, 182)
        Me.filter_view.TabIndex = 0
        '
        'JournalcodeDataGridViewTextBoxColumn
        '
        Me.JournalcodeDataGridViewTextBoxColumn.DataPropertyName = "journal_code"
        Me.JournalcodeDataGridViewTextBoxColumn.HeaderText = "Journal"
        Me.JournalcodeDataGridViewTextBoxColumn.Name = "JournalcodeDataGridViewTextBoxColumn"
        Me.JournalcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.JournalcodeDataGridViewTextBoxColumn.Width = 50
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "Transaction No"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChecknoDataGridViewTextBoxColumn
        '
        Me.ChecknoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChecknoDataGridViewTextBoxColumn.DataPropertyName = "check_no"
        Me.ChecknoDataGridViewTextBoxColumn.HeaderText = "Check No"
        Me.ChecknoDataGridViewTextBoxColumn.Name = "ChecknoDataGridViewTextBoxColumn"
        Me.ChecknoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = "00/00/0000"
        Me.TransdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        Me.TransdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeneralnameDataGridViewTextBoxColumn
        '
        Me.GeneralnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GeneralnameDataGridViewTextBoxColumn.DataPropertyName = "general_name"
        Me.GeneralnameDataGridViewTextBoxColumn.HeaderText = "GenLib"
        Me.GeneralnameDataGridViewTextBoxColumn.Name = "GeneralnameDataGridViewTextBoxColumn"
        Me.GeneralnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.AmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransidDataGridViewTextBoxColumn
        '
        Me.TransidDataGridViewTextBoxColumn.DataPropertyName = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.HeaderText = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.Name = "TransidDataGridViewTextBoxColumn"
        Me.TransidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransidDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralidDataGridViewTextBoxColumn
        '
        Me.GeneralidDataGridViewTextBoxColumn.DataPropertyName = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.HeaderText = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.Name = "GeneralidDataGridViewTextBoxColumn"
        Me.GeneralidDataGridViewTextBoxColumn.ReadOnly = True
        Me.GeneralidDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralcodeDataGridViewTextBoxColumn
        '
        Me.GeneralcodeDataGridViewTextBoxColumn.DataPropertyName = "general_code"
        Me.GeneralcodeDataGridViewTextBoxColumn.HeaderText = "general_code"
        Me.GeneralcodeDataGridViewTextBoxColumn.Name = "GeneralcodeDataGridViewTextBoxColumn"
        Me.GeneralcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.GeneralcodeDataGridViewTextBoxColumn.Visible = False
        '
        'JournalidDataGridViewTextBoxColumn
        '
        Me.JournalidDataGridViewTextBoxColumn.DataPropertyName = "journal_id"
        Me.JournalidDataGridViewTextBoxColumn.HeaderText = "journal_id"
        Me.JournalidDataGridViewTextBoxColumn.Name = "JournalidDataGridViewTextBoxColumn"
        Me.JournalidDataGridViewTextBoxColumn.ReadOnly = True
        Me.JournalidDataGridViewTextBoxColumn.Visible = False
        '
        'JournalnameDataGridViewTextBoxColumn
        '
        Me.JournalnameDataGridViewTextBoxColumn.DataPropertyName = "journal_name"
        Me.JournalnameDataGridViewTextBoxColumn.HeaderText = "journal_name"
        Me.JournalnameDataGridViewTextBoxColumn.Name = "JournalnameDataGridViewTextBoxColumn"
        Me.JournalnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.JournalnameDataGridViewTextBoxColumn.Visible = False
        '
        'bs
        '
        Me.bs.DataMember = "trans_header"
        Me.bs.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_header})
        '
        'trans_header
        '
        Me.trans_header.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.trans_header.TableName = "trans_header"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "trans_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_no"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "trans_date"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "general_id"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "general_code"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "general_name"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "amount"
        Me.DataColumn7.DataType = GetType(Decimal)
        Me.DataColumn7.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "journal_id"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "journal_code"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "journal_name"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "check_no"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "book_id"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "book_code"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "book_name"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "description"
        Me.DataColumn15.DefaultValue = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Journal"
        '
        'filter_journal_id
        '
        Me.filter_journal_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter_journal_id.FormattingEnabled = True
        Me.filter_journal_id.Location = New System.Drawing.Point(61, 45)
        Me.filter_journal_id.Name = "filter_journal_id"
        Me.filter_journal_id.Size = New System.Drawing.Size(121, 21)
        Me.filter_journal_id.TabIndex = 2
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(705, 43)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 2)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Transaction Viewer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Transaction No"
        '
        'filter_trans_no
        '
        Me.filter_trans_no.Location = New System.Drawing.Point(274, 45)
        Me.filter_trans_no.Name = "filter_trans_no"
        Me.filter_trans_no.Size = New System.Drawing.Size(100, 20)
        Me.filter_trans_no.TabIndex = 7
        '
        'filter_check_no
        '
        Me.filter_check_no.Location = New System.Drawing.Point(441, 45)
        Me.filter_check_no.Name = "filter_check_no"
        Me.filter_check_no.Size = New System.Drawing.Size(100, 20)
        Me.filter_check_no.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Check No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(547, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "GenLib"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_trans_date)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_amount)
        Me.GroupBox1.Controls.Add(Me.txt_description)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_general_name)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_check_no)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_trans_no)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 160)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txt_trans_date
        '
        Me.txt_trans_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_trans_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bs, "trans_date", True))
        Me.txt_trans_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_trans_date.Location = New System.Drawing.Point(535, 15)
        Me.txt_trans_date.Name = "txt_trans_date"
        Me.txt_trans_date.Size = New System.Drawing.Size(109, 20)
        Me.txt_trans_date.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(495, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Date"
        '
        'txt_amount
        '
        Me.txt_amount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs, "amount", True))
        Me.txt_amount.Location = New System.Drawing.Point(544, 44)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount.Properties.Mask.EditMask = "n2"
        Me.txt_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_amount.Size = New System.Drawing.Size(100, 20)
        Me.txt_amount.TabIndex = 22
        '
        'txt_description
        '
        Me.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_description.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs, "description", True))
        Me.txt_description.Location = New System.Drawing.Point(222, 70)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ReadOnly = True
        Me.txt_description.Size = New System.Drawing.Size(422, 72)
        Me.txt_description.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(160, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Particulars"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(495, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Amount"
        '
        'txt_general_name
        '
        Me.txt_general_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_general_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs, "general_name", True))
        Me.txt_general_name.Location = New System.Drawing.Point(222, 44)
        Me.txt_general_name.Name = "txt_general_name"
        Me.txt_general_name.ReadOnly = True
        Me.txt_general_name.Size = New System.Drawing.Size(267, 20)
        Me.txt_general_name.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "GenLib"
        '
        'txt_check_no
        '
        Me.txt_check_no.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_check_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs, "check_no", True))
        Me.txt_check_no.Location = New System.Drawing.Point(389, 18)
        Me.txt_check_no.Name = "txt_check_no"
        Me.txt_check_no.ReadOnly = True
        Me.txt_check_no.Size = New System.Drawing.Size(100, 20)
        Me.txt_check_no.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(328, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Check No"
        '
        'txt_trans_no
        '
        Me.txt_trans_no.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_trans_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs, "trans_no", True))
        Me.txt_trans_no.Location = New System.Drawing.Point(222, 18)
        Me.txt_trans_no.Name = "txt_trans_no"
        Me.txt_trans_no.ReadOnly = True
        Me.txt_trans_no.Size = New System.Drawing.Size(100, 20)
        Me.txt_trans_no.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Transaction No"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(324, 426)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Location = New System.Drawing.Point(405, 426)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(506, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "From"
        '
        'filter_date_from
        '
        Me.filter_date_from.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filter_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.filter_date_from.Location = New System.Drawing.Point(542, 9)
        Me.filter_date_from.Name = "filter_date_from"
        Me.filter_date_from.Size = New System.Drawing.Size(109, 20)
        Me.filter_date_from.TabIndex = 16
        '
        'filter_date_to
        '
        Me.filter_date_to.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filter_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.filter_date_to.Location = New System.Drawing.Point(683, 9)
        Me.filter_date_to.Name = "filter_date_to"
        Me.filter_date_to.Size = New System.Drawing.Size(109, 20)
        Me.filter_date_to.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(657, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "To"
        '
        'txt_trans_id
        '
        Me.txt_trans_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs, "trans_id", True))
        Me.txt_trans_id.Location = New System.Drawing.Point(3, 3)
        Me.txt_trans_id.Name = "txt_trans_id"
        Me.txt_trans_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_trans_id.TabIndex = 0
        '
        'NeedToHide
        '
        Me.NeedToHide.Controls.Add(Me.txt_trans_id)
        Me.NeedToHide.Controls.Add(Me.txt_book_id)
        Me.NeedToHide.Controls.Add(Me.txt_book_name)
        Me.NeedToHide.Location = New System.Drawing.Point(486, 369)
        Me.NeedToHide.Name = "NeedToHide"
        Me.NeedToHide.Size = New System.Drawing.Size(306, 88)
        Me.NeedToHide.TabIndex = 0
        '
        'txt_book_id
        '
        Me.txt_book_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs, "book_id", True))
        Me.txt_book_id.Location = New System.Drawing.Point(109, 3)
        Me.txt_book_id.Name = "txt_book_id"
        Me.txt_book_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_book_id.TabIndex = 1
        '
        'txt_book_name
        '
        Me.txt_book_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs, "book_name", True))
        Me.txt_book_name.Location = New System.Drawing.Point(3, 29)
        Me.txt_book_name.Name = "txt_book_name"
        Me.txt_book_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_book_name.TabIndex = 2
        '
        'filter_general
        '
        Me.filter_general.Location = New System.Drawing.Point(594, 45)
        Me.filter_general.Name = "filter_general"
        Me.filter_general.Size = New System.Drawing.Size(100, 20)
        Me.filter_general.TabIndex = 19
        '
        'TransactionSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 461)
        Me.Controls.Add(Me.filter_general)
        Me.Controls.Add(Me.NeedToHide)
        Me.Controls.Add(Me.filter_date_to)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.filter_date_from)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.filter_check_no)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.filter_trans_no)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.filter_journal_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.filter_view)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(820, 500)
        Me.Name = "TransactionSearch"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Viewer"
        CType(Me.filter_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NeedToHide.ResumeLayout(False)
        Me.NeedToHide.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents filter_view As Windows.Forms.DataGridView
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents filter_journal_id As Windows.Forms.ComboBox
    Friend WithEvents btn_search As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents filter_trans_no As Windows.Forms.TextBox
    Friend WithEvents filter_check_no As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents ds As DataSet
    Friend WithEvents trans_header As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents filter_date_from As Windows.Forms.DateTimePicker
    Friend WithEvents filter_date_to As Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents JournalcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChecknoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JournalidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JournalnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents txt_description As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_general_name As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txt_check_no As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents txt_trans_no As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txt_trans_id As Windows.Forms.TextBox
    Friend WithEvents NeedToHide As Windows.Forms.FlowLayoutPanel
    Friend WithEvents filter_general As Windows.Forms.TextBox
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents txt_trans_date As Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txt_book_id As Windows.Forms.TextBox
    Friend WithEvents txt_book_name As Windows.Forms.TextBox
End Class
