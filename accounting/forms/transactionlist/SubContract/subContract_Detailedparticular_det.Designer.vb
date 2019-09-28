<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subContract_Detailedparticular_det
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.ds = New System.Data.DataSet()
        Me.trans_sub_contract_det = New System.Data.DataTable()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DsfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencycodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubconcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubconnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cons1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cons2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilledamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubcontractdetidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubcontractidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScyearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubconidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExchangerateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasedrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilledamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_sub_contract_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgView.AutoGenerateColumns = False
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelDataGridViewCheckBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.CurrencycodeDataGridViewTextBoxColumn, Me.SubconcodeDataGridViewTextBoxColumn, Me.SubconnameDataGridViewTextBoxColumn, Me.ProjectcodeDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.Cons1DataGridViewTextBoxColumn, Me.Cons2DataGridViewTextBoxColumn, Me.BilledamountDataGridViewTextBoxColumn, Me.PaidamountDataGridViewTextBoxColumn, Me.PonoDataGridViewTextBoxColumn, Me.SubcontractdetidDataGridViewTextBoxColumn, Me.SubcontractidDataGridViewTextBoxColumn, Me.ScyearDataGridViewTextBoxColumn, Me.ProjectidDataGridViewTextBoxColumn, Me.ProjectnameDataGridViewTextBoxColumn, Me.SubconidDataGridViewTextBoxColumn, Me.GeneralidDataGridViewTextBoxColumn, Me.GeneralcodeDataGridViewTextBoxColumn, Me.GeneralnameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.AmountbasedDataGridViewTextBoxColumn, Me.DepartmentidDataGridViewTextBoxColumn, Me.CurrencyidDataGridViewTextBoxColumn, Me.CurrencynameDataGridViewTextBoxColumn, Me.ExchangerateDataGridViewTextBoxColumn, Me.BasedrateDataGridViewTextBoxColumn, Me.BilledamountbasedDataGridViewTextBoxColumn, Me.DepartmentcodeDataGridViewTextBoxColumn, Me.DepartmentnameDataGridViewTextBoxColumn, Me.PaidamountbasedDataGridViewTextBoxColumn})
        Me.dgView.DataSource = Me.bs
        Me.dgView.Location = New System.Drawing.Point(12, 66)
        Me.dgView.Name = "dgView"
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(776, 283)
        Me.dgView.TabIndex = 290
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_sub_contract_det})
        '
        'trans_sub_contract_det
        '
        Me.trans_sub_contract_det.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32})
        Me.trans_sub_contract_det.TableName = "trans_sub_contract_det"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.BackColor = System.Drawing.Color.Green
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(317, 362)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 24)
        Me.btnOK.TabIndex = 288
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(403, 362)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 289
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 2)
        Me.Panel1.TabIndex = 287
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 286
        Me.Label1.Text = "Sub Contract Management"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DsfToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 291
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'DsfToolStripMenuItem
        '
        Me.DsfToolStripMenuItem.Name = "DsfToolStripMenuItem"
        Me.DsfToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.DsfToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.DsfToolStripMenuItem.Text = "dsf"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sub_contract_det_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sub_contract_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sc_year"
        Me.DataColumn4.DefaultValue = "0000"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "project_id"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "project_code"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "project_name"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "subconid"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "subconcode"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "subconname"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "general_id"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "general_code"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "general_name"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "trans_date"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "description"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "amount"
        Me.DataColumn16.DataType = GetType(Decimal)
        Me.DataColumn16.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "amount_based"
        Me.DataColumn17.DataType = GetType(Decimal)
        Me.DataColumn17.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "currency_id"
        Me.DataColumn18.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "currency_code"
        Me.DataColumn19.DefaultValue = ""
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "currency_name"
        Me.DataColumn20.DefaultValue = ""
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "exchange_rate"
        Me.DataColumn21.DataType = GetType(Decimal)
        Me.DataColumn21.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "based_rate"
        Me.DataColumn22.DataType = GetType(Decimal)
        Me.DataColumn22.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "po_no"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "billed_amount"
        Me.DataColumn24.DataType = GetType(Decimal)
        Me.DataColumn24.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "billed_amount_based"
        Me.DataColumn25.DataType = GetType(Decimal)
        Me.DataColumn25.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "cons1"
        Me.DataColumn26.DataType = GetType(Date)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "cons2"
        Me.DataColumn27.DataType = GetType(Date)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "department_id"
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
        Me.DataColumn31.ColumnName = "paid_amount"
        Me.DataColumn31.DataType = GetType(Decimal)
        Me.DataColumn31.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "paid_amount_based"
        Me.DataColumn32.DataType = GetType(Decimal)
        Me.DataColumn32.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'bs
        '
        Me.bs.DataMember = "trans_sub_contract_det"
        Me.bs.DataSource = Me.ds
        '
        'SelDataGridViewCheckBoxColumn
        '
        Me.SelDataGridViewCheckBoxColumn.DataPropertyName = "sel"
        Me.SelDataGridViewCheckBoxColumn.HeaderText = ""
        Me.SelDataGridViewCheckBoxColumn.Name = "SelDataGridViewCheckBoxColumn"
        Me.SelDataGridViewCheckBoxColumn.Width = 32
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "00/00/0000"
        Me.TransdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        Me.TransdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrencycodeDataGridViewTextBoxColumn
        '
        Me.CurrencycodeDataGridViewTextBoxColumn.DataPropertyName = "currency_code"
        Me.CurrencycodeDataGridViewTextBoxColumn.HeaderText = "CURRENCY"
        Me.CurrencycodeDataGridViewTextBoxColumn.Name = "CurrencycodeDataGridViewTextBoxColumn"
        Me.CurrencycodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubconcodeDataGridViewTextBoxColumn
        '
        Me.SubconcodeDataGridViewTextBoxColumn.DataPropertyName = "subconcode"
        Me.SubconcodeDataGridViewTextBoxColumn.HeaderText = "SUB CONTRACTOR"
        Me.SubconcodeDataGridViewTextBoxColumn.Name = "SubconcodeDataGridViewTextBoxColumn"
        Me.SubconcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubconnameDataGridViewTextBoxColumn
        '
        Me.SubconnameDataGridViewTextBoxColumn.DataPropertyName = "subconname"
        Me.SubconnameDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.SubconnameDataGridViewTextBoxColumn.Name = "SubconnameDataGridViewTextBoxColumn"
        Me.SubconnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProjectcodeDataGridViewTextBoxColumn
        '
        Me.ProjectcodeDataGridViewTextBoxColumn.DataPropertyName = "project_code"
        Me.ProjectcodeDataGridViewTextBoxColumn.HeaderText = "PROJECT"
        Me.ProjectcodeDataGridViewTextBoxColumn.Name = "ProjectcodeDataGridViewTextBoxColumn"
        Me.ProjectcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.AmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "CONTRACT"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cons1DataGridViewTextBoxColumn
        '
        Me.Cons1DataGridViewTextBoxColumn.DataPropertyName = "cons1"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = "00/00/0000"
        Me.Cons1DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cons1DataGridViewTextBoxColumn.HeaderText = "FROM"
        Me.Cons1DataGridViewTextBoxColumn.Name = "Cons1DataGridViewTextBoxColumn"
        Me.Cons1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cons2DataGridViewTextBoxColumn
        '
        Me.Cons2DataGridViewTextBoxColumn.DataPropertyName = "cons2"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = "00/00/0000"
        Me.Cons2DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cons2DataGridViewTextBoxColumn.HeaderText = "TO"
        Me.Cons2DataGridViewTextBoxColumn.Name = "Cons2DataGridViewTextBoxColumn"
        Me.Cons2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'BilledamountDataGridViewTextBoxColumn
        '
        Me.BilledamountDataGridViewTextBoxColumn.DataPropertyName = "billed_amount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.BilledamountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.BilledamountDataGridViewTextBoxColumn.HeaderText = "BILLED"
        Me.BilledamountDataGridViewTextBoxColumn.Name = "BilledamountDataGridViewTextBoxColumn"
        '
        'PaidamountDataGridViewTextBoxColumn
        '
        Me.PaidamountDataGridViewTextBoxColumn.DataPropertyName = "paid_amount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.PaidamountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PaidamountDataGridViewTextBoxColumn.HeaderText = "PAID"
        Me.PaidamountDataGridViewTextBoxColumn.Name = "PaidamountDataGridViewTextBoxColumn"
        Me.PaidamountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PonoDataGridViewTextBoxColumn
        '
        Me.PonoDataGridViewTextBoxColumn.DataPropertyName = "po_no"
        Me.PonoDataGridViewTextBoxColumn.HeaderText = "PO No"
        Me.PonoDataGridViewTextBoxColumn.Name = "PonoDataGridViewTextBoxColumn"
        Me.PonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubcontractdetidDataGridViewTextBoxColumn
        '
        Me.SubcontractdetidDataGridViewTextBoxColumn.DataPropertyName = "sub_contract_det_id"
        Me.SubcontractdetidDataGridViewTextBoxColumn.HeaderText = "sub_contract_det_id"
        Me.SubcontractdetidDataGridViewTextBoxColumn.Name = "SubcontractdetidDataGridViewTextBoxColumn"
        Me.SubcontractdetidDataGridViewTextBoxColumn.Visible = False
        '
        'SubcontractidDataGridViewTextBoxColumn
        '
        Me.SubcontractidDataGridViewTextBoxColumn.DataPropertyName = "sub_contract_id"
        Me.SubcontractidDataGridViewTextBoxColumn.HeaderText = "sub_contract_id"
        Me.SubcontractidDataGridViewTextBoxColumn.Name = "SubcontractidDataGridViewTextBoxColumn"
        Me.SubcontractidDataGridViewTextBoxColumn.Visible = False
        '
        'ScyearDataGridViewTextBoxColumn
        '
        Me.ScyearDataGridViewTextBoxColumn.DataPropertyName = "sc_year"
        Me.ScyearDataGridViewTextBoxColumn.HeaderText = "sc_year"
        Me.ScyearDataGridViewTextBoxColumn.Name = "ScyearDataGridViewTextBoxColumn"
        Me.ScyearDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectidDataGridViewTextBoxColumn
        '
        Me.ProjectidDataGridViewTextBoxColumn.DataPropertyName = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn.HeaderText = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn.Name = "ProjectidDataGridViewTextBoxColumn"
        Me.ProjectidDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectnameDataGridViewTextBoxColumn
        '
        Me.ProjectnameDataGridViewTextBoxColumn.DataPropertyName = "project_name"
        Me.ProjectnameDataGridViewTextBoxColumn.HeaderText = "project_name"
        Me.ProjectnameDataGridViewTextBoxColumn.Name = "ProjectnameDataGridViewTextBoxColumn"
        Me.ProjectnameDataGridViewTextBoxColumn.Visible = False
        '
        'SubconidDataGridViewTextBoxColumn
        '
        Me.SubconidDataGridViewTextBoxColumn.DataPropertyName = "subconid"
        Me.SubconidDataGridViewTextBoxColumn.HeaderText = "subconid"
        Me.SubconidDataGridViewTextBoxColumn.Name = "SubconidDataGridViewTextBoxColumn"
        Me.SubconidDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralidDataGridViewTextBoxColumn
        '
        Me.GeneralidDataGridViewTextBoxColumn.DataPropertyName = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.HeaderText = "general_id"
        Me.GeneralidDataGridViewTextBoxColumn.Name = "GeneralidDataGridViewTextBoxColumn"
        Me.GeneralidDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralcodeDataGridViewTextBoxColumn
        '
        Me.GeneralcodeDataGridViewTextBoxColumn.DataPropertyName = "general_code"
        Me.GeneralcodeDataGridViewTextBoxColumn.HeaderText = "general_code"
        Me.GeneralcodeDataGridViewTextBoxColumn.Name = "GeneralcodeDataGridViewTextBoxColumn"
        Me.GeneralcodeDataGridViewTextBoxColumn.Visible = False
        '
        'GeneralnameDataGridViewTextBoxColumn
        '
        Me.GeneralnameDataGridViewTextBoxColumn.DataPropertyName = "general_name"
        Me.GeneralnameDataGridViewTextBoxColumn.HeaderText = "general_name"
        Me.GeneralnameDataGridViewTextBoxColumn.Name = "GeneralnameDataGridViewTextBoxColumn"
        Me.GeneralnameDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'AmountbasedDataGridViewTextBoxColumn
        '
        Me.AmountbasedDataGridViewTextBoxColumn.DataPropertyName = "amount_based"
        Me.AmountbasedDataGridViewTextBoxColumn.HeaderText = "amount_based"
        Me.AmountbasedDataGridViewTextBoxColumn.Name = "AmountbasedDataGridViewTextBoxColumn"
        Me.AmountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentidDataGridViewTextBoxColumn
        '
        Me.DepartmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id"
        Me.DepartmentidDataGridViewTextBoxColumn.HeaderText = "department_id"
        Me.DepartmentidDataGridViewTextBoxColumn.Name = "DepartmentidDataGridViewTextBoxColumn"
        Me.DepartmentidDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencyidDataGridViewTextBoxColumn
        '
        Me.CurrencyidDataGridViewTextBoxColumn.DataPropertyName = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.HeaderText = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.Name = "CurrencyidDataGridViewTextBoxColumn"
        Me.CurrencyidDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencynameDataGridViewTextBoxColumn
        '
        Me.CurrencynameDataGridViewTextBoxColumn.DataPropertyName = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.HeaderText = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.Name = "CurrencynameDataGridViewTextBoxColumn"
        Me.CurrencynameDataGridViewTextBoxColumn.Visible = False
        '
        'ExchangerateDataGridViewTextBoxColumn
        '
        Me.ExchangerateDataGridViewTextBoxColumn.DataPropertyName = "exchange_rate"
        Me.ExchangerateDataGridViewTextBoxColumn.HeaderText = "exchange_rate"
        Me.ExchangerateDataGridViewTextBoxColumn.Name = "ExchangerateDataGridViewTextBoxColumn"
        Me.ExchangerateDataGridViewTextBoxColumn.Visible = False
        '
        'BasedrateDataGridViewTextBoxColumn
        '
        Me.BasedrateDataGridViewTextBoxColumn.DataPropertyName = "based_rate"
        Me.BasedrateDataGridViewTextBoxColumn.HeaderText = "based_rate"
        Me.BasedrateDataGridViewTextBoxColumn.Name = "BasedrateDataGridViewTextBoxColumn"
        Me.BasedrateDataGridViewTextBoxColumn.Visible = False
        '
        'BilledamountbasedDataGridViewTextBoxColumn
        '
        Me.BilledamountbasedDataGridViewTextBoxColumn.DataPropertyName = "billed_amount_based"
        Me.BilledamountbasedDataGridViewTextBoxColumn.HeaderText = "billed_amount_based"
        Me.BilledamountbasedDataGridViewTextBoxColumn.Name = "BilledamountbasedDataGridViewTextBoxColumn"
        Me.BilledamountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentcodeDataGridViewTextBoxColumn
        '
        Me.DepartmentcodeDataGridViewTextBoxColumn.DataPropertyName = "department_code"
        Me.DepartmentcodeDataGridViewTextBoxColumn.HeaderText = "department_code"
        Me.DepartmentcodeDataGridViewTextBoxColumn.Name = "DepartmentcodeDataGridViewTextBoxColumn"
        Me.DepartmentcodeDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentnameDataGridViewTextBoxColumn
        '
        Me.DepartmentnameDataGridViewTextBoxColumn.DataPropertyName = "department_name"
        Me.DepartmentnameDataGridViewTextBoxColumn.HeaderText = "department_name"
        Me.DepartmentnameDataGridViewTextBoxColumn.Name = "DepartmentnameDataGridViewTextBoxColumn"
        Me.DepartmentnameDataGridViewTextBoxColumn.Visible = False
        '
        'PaidamountbasedDataGridViewTextBoxColumn
        '
        Me.PaidamountbasedDataGridViewTextBoxColumn.DataPropertyName = "paid_amount_based"
        Me.PaidamountbasedDataGridViewTextBoxColumn.HeaderText = "paid_amount_based"
        Me.PaidamountbasedDataGridViewTextBoxColumn.Name = "PaidamountbasedDataGridViewTextBoxColumn"
        Me.PaidamountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'subContract_Detailedparticular_det
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "subContract_Detailedparticular_det"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "subContract_Detailedparticular_det"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_sub_contract_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgView As Windows.Forms.DataGridView
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents trans_sub_contract_det As DataTable
    Public WithEvents ds As DataSet
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents DsfToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencycodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubconcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubconnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cons1DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cons2DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilledamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PonoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubcontractdetidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubcontractidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScyearDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubconidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencynameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExchangerateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasedrateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilledamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bs As Windows.Forms.BindingSource
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
End Class
