<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subContract_Detailedparticular
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subContract_Detailedparticular))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.sels = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencycodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subconcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubconnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cons1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cons2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilledamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountcollectedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_contract_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilledamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExchangerateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasedrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubconidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountcollectedbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.trans_sub_contract_det = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_total = New user_control.MyTextBox()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_sub_contract_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(403, 46)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 287
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(351, 367)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 24)
        Me.btnBack.TabIndex = 288
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(317, 46)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 286
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
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
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sels, Me.TransdateDataGridViewTextBoxColumn, Me.CurrencycodeDataGridViewTextBoxColumn, Me.subconcode, Me.SubconnameDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.Cons1DataGridViewTextBoxColumn, Me.Cons2DataGridViewTextBoxColumn, Me.BilledamountDataGridViewTextBoxColumn, Me.AmountcollectedDataGridViewTextBoxColumn, Me.PonoDataGridViewTextBoxColumn, Me.TransidDataGridViewTextBoxColumn, Me.sub_contract_det_id, Me.BilledamountbasedDataGridViewTextBoxColumn, Me.CurrencyidDataGridViewTextBoxColumn, Me.CurrencynameDataGridViewTextBoxColumn, Me.ExchangerateDataGridViewTextBoxColumn, Me.BasedrateDataGridViewTextBoxColumn, Me.SubconidDataGridViewTextBoxColumn, Me.AmountbasedDataGridViewTextBoxColumn, Me.AmountcollectedbasedDataGridViewTextBoxColumn, Me.DeletedDataGridViewCheckBoxColumn})
        Me.dgView.DataMember = "trans_sub_contract_det"
        Me.dgView.DataSource = Me.ds
        Me.dgView.Location = New System.Drawing.Point(12, 78)
        Me.dgView.Name = "dgView"
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(776, 283)
        Me.dgView.TabIndex = 283
        '
        'sels
        '
        Me.sels.DataPropertyName = "sel"
        Me.sels.HeaderText = ""
        Me.sels.Name = "sels"
        Me.sels.Width = 32
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "00/00/0000"
        Me.TransdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.TransdateDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        Me.TransdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrencycodeDataGridViewTextBoxColumn
        '
        Me.CurrencycodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CurrencycodeDataGridViewTextBoxColumn.DataPropertyName = "currency_code"
        Me.CurrencycodeDataGridViewTextBoxColumn.HeaderText = "CURRENCY"
        Me.CurrencycodeDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.CurrencycodeDataGridViewTextBoxColumn.Name = "CurrencycodeDataGridViewTextBoxColumn"
        Me.CurrencycodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'subconcode
        '
        Me.subconcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subconcode.DataPropertyName = "subconcode"
        Me.subconcode.HeaderText = "SUBCON"
        Me.subconcode.MinimumWidth = 100
        Me.subconcode.Name = "subconcode"
        Me.subconcode.ReadOnly = True
        '
        'SubconnameDataGridViewTextBoxColumn
        '
        Me.SubconnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SubconnameDataGridViewTextBoxColumn.DataPropertyName = "subconname"
        Me.SubconnameDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.SubconnameDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.SubconnameDataGridViewTextBoxColumn.Name = "SubconnameDataGridViewTextBoxColumn"
        Me.SubconnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.AmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "CONTRACT"
        Me.AmountDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cons1DataGridViewTextBoxColumn
        '
        Me.Cons1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cons1DataGridViewTextBoxColumn.DataPropertyName = "cons1"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = "00/00/0000"
        Me.Cons1DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cons1DataGridViewTextBoxColumn.HeaderText = "FROM"
        Me.Cons1DataGridViewTextBoxColumn.MinimumWidth = 100
        Me.Cons1DataGridViewTextBoxColumn.Name = "Cons1DataGridViewTextBoxColumn"
        Me.Cons1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cons2DataGridViewTextBoxColumn
        '
        Me.Cons2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cons2DataGridViewTextBoxColumn.DataPropertyName = "cons2"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = "00/00/0000"
        Me.Cons2DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cons2DataGridViewTextBoxColumn.HeaderText = "TO"
        Me.Cons2DataGridViewTextBoxColumn.MinimumWidth = 100
        Me.Cons2DataGridViewTextBoxColumn.Name = "Cons2DataGridViewTextBoxColumn"
        Me.Cons2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'BilledamountDataGridViewTextBoxColumn
        '
        Me.BilledamountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BilledamountDataGridViewTextBoxColumn.DataPropertyName = "billed_amount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.BilledamountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.BilledamountDataGridViewTextBoxColumn.HeaderText = "BILLED"
        Me.BilledamountDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.BilledamountDataGridViewTextBoxColumn.Name = "BilledamountDataGridViewTextBoxColumn"
        '
        'AmountcollectedDataGridViewTextBoxColumn
        '
        Me.AmountcollectedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountcollectedDataGridViewTextBoxColumn.DataPropertyName = "amount_collected"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.AmountcollectedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.AmountcollectedDataGridViewTextBoxColumn.HeaderText = "PAID"
        Me.AmountcollectedDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.AmountcollectedDataGridViewTextBoxColumn.Name = "AmountcollectedDataGridViewTextBoxColumn"
        Me.AmountcollectedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PonoDataGridViewTextBoxColumn
        '
        Me.PonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PonoDataGridViewTextBoxColumn.DataPropertyName = "po_no"
        Me.PonoDataGridViewTextBoxColumn.HeaderText = "PO NO"
        Me.PonoDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.PonoDataGridViewTextBoxColumn.Name = "PonoDataGridViewTextBoxColumn"
        Me.PonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransidDataGridViewTextBoxColumn
        '
        Me.TransidDataGridViewTextBoxColumn.DataPropertyName = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.HeaderText = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.Name = "TransidDataGridViewTextBoxColumn"
        Me.TransidDataGridViewTextBoxColumn.Visible = False
        '
        'sub_contract_det_id
        '
        Me.sub_contract_det_id.DataPropertyName = "sub_contract_det_id"
        Me.sub_contract_det_id.HeaderText = "sub_contract_det_id"
        Me.sub_contract_det_id.Name = "sub_contract_det_id"
        Me.sub_contract_det_id.Visible = False
        '
        'BilledamountbasedDataGridViewTextBoxColumn
        '
        Me.BilledamountbasedDataGridViewTextBoxColumn.DataPropertyName = "billed_amount_based"
        Me.BilledamountbasedDataGridViewTextBoxColumn.HeaderText = "billed_amount_based"
        Me.BilledamountbasedDataGridViewTextBoxColumn.Name = "BilledamountbasedDataGridViewTextBoxColumn"
        Me.BilledamountbasedDataGridViewTextBoxColumn.Visible = False
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
        'SubconidDataGridViewTextBoxColumn
        '
        Me.SubconidDataGridViewTextBoxColumn.DataPropertyName = "subconid"
        Me.SubconidDataGridViewTextBoxColumn.HeaderText = "subconid"
        Me.SubconidDataGridViewTextBoxColumn.Name = "SubconidDataGridViewTextBoxColumn"
        Me.SubconidDataGridViewTextBoxColumn.Visible = False
        '
        'AmountbasedDataGridViewTextBoxColumn
        '
        Me.AmountbasedDataGridViewTextBoxColumn.DataPropertyName = "amount_based"
        Me.AmountbasedDataGridViewTextBoxColumn.HeaderText = "amount_based"
        Me.AmountbasedDataGridViewTextBoxColumn.Name = "AmountbasedDataGridViewTextBoxColumn"
        Me.AmountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'AmountcollectedbasedDataGridViewTextBoxColumn
        '
        Me.AmountcollectedbasedDataGridViewTextBoxColumn.DataPropertyName = "amount_collected_based"
        Me.AmountcollectedbasedDataGridViewTextBoxColumn.HeaderText = "amount_collected_based"
        Me.AmountcollectedbasedDataGridViewTextBoxColumn.Name = "AmountcollectedbasedDataGridViewTextBoxColumn"
        Me.AmountcollectedbasedDataGridViewTextBoxColumn.Visible = False
        '
        'DeletedDataGridViewCheckBoxColumn
        '
        Me.DeletedDataGridViewCheckBoxColumn.DataPropertyName = "deleted"
        Me.DeletedDataGridViewCheckBoxColumn.HeaderText = "deleted"
        Me.DeletedDataGridViewCheckBoxColumn.Name = "DeletedDataGridViewCheckBoxColumn"
        Me.DeletedDataGridViewCheckBoxColumn.Visible = False
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_sub_contract_det})
        '
        'trans_sub_contract_det
        '
        Me.trans_sub_contract_det.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn4, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn3})
        Me.trans_sub_contract_det.TableName = "trans_sub_contract_det"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_sub_contract_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "trans_id"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sub_contract_det_id"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "billed_amount"
        Me.DataColumn37.DataType = GetType(Decimal)
        Me.DataColumn37.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "billed_amount_based"
        Me.DataColumn38.DataType = GetType(Decimal)
        Me.DataColumn38.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "currency_id"
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
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "exchange_rate"
        Me.DataColumn42.DataType = GetType(Decimal)
        Me.DataColumn42.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "based_rate"
        Me.DataColumn43.DataType = GetType(Decimal)
        Me.DataColumn43.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "subconid"
        Me.DataColumn44.DefaultValue = ""
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "subconcode"
        Me.DataColumn45.DefaultValue = ""
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "subconname"
        Me.DataColumn46.DefaultValue = ""
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "cons1"
        Me.DataColumn47.DataType = GetType(Date)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "cons2"
        Me.DataColumn48.DataType = GetType(Date)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "amount"
        Me.DataColumn49.DataType = GetType(Decimal)
        Me.DataColumn49.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "amount_based"
        Me.DataColumn50.DataType = GetType(Decimal)
        Me.DataColumn50.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "po_no"
        Me.DataColumn51.DefaultValue = ""
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "trans_date"
        Me.DataColumn52.DataType = GetType(Date)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "amount_collected"
        Me.DataColumn53.DataType = GetType(Decimal)
        Me.DataColumn53.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "amount_collected_based"
        Me.DataColumn54.DataType = GetType(Decimal)
        Me.DataColumn54.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "deleted"
        Me.DataColumn3.DataType = GetType(Boolean)
        Me.DataColumn3.DefaultValue = False
        '
        'bs
        '
        Me.bs.DataMember = "trans_sub_contract_det"
        Me.bs.DataSource = Me.ds
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 25)
        Me.Label1.TabIndex = 284
        Me.Label1.Text = "Sub Contract Particular"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 2)
        Me.Panel1.TabIndex = 285
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(529, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 289
        Me.Label2.Text = "Total :"
        '
        'txt_total
        '
        Me.txt_total.AlwaysDisable = False
        Me.txt_total.AlwaysEnable = False
        Me.txt_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.BrowseDataSource = "lib_erp_chart"
        Me.txt_total.BrowseField = "account_code,account_name"
        Me.txt_total.BrowseFilter = Nothing
        Me.txt_total.BrowseLabel = "Code,Name"
        Me.txt_total.BrowseLabelWidth = "100,400"
        Me.txt_total.BrowseTextSource = "account_code"
        Me.txt_total.BrowseUpdate.Add(CType(resources.GetObject("txt_total.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_total.BrowseValueSource = "account_id"
        Me.txt_total.Database = user_control.MyList.Database.FileSetup
        Me.txt_total.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_total.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_total.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total.Enabled = False
        Me.txt_total.EnabledBackColor = System.Drawing.Color.White
        Me.txt_total.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_total.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_total.ID = False
        Me.txt_total.Location = New System.Drawing.Point(572, 371)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.NoClear = False
        Me.txt_total.NoSave = False
        Me.txt_total.NumberFormat = "@"
        Me.txt_total.Required = True
        Me.txt_total.RowData = Nothing
        Me.txt_total.Size = New System.Drawing.Size(216, 20)
        Me.txt_total.TabIndex = 290
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_total.TextBrowse = True
        Me.txt_total.TextSource = "account_code"
        Me.txt_total.ToUpper = True
        Me.txt_total.Unique = False
        Me.txt_total.Value = ""
        Me.txt_total.ValueSource = "account_id"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 33
        '
        'subContract_Detailedparticular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "subContract_Detailedparticular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "subContract_Detailedparticular"
        Me.TopMost = True
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_sub_contract_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents btnBack As Windows.Forms.Button
    Friend WithEvents btnInsert As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents dgView As Windows.Forms.DataGridView
    Public WithEvents trans_sub_contract_det As DataTable
    Friend WithEvents ds As DataSet
    Public WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents oamount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents collected_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sc_year As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supcd As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents sub_contract_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isPrior As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accomplishment As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txt_total As user_control.MyTextBox
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn36 As DataColumn
    Friend WithEvents DataColumn37 As DataColumn
    Friend WithEvents DataColumn38 As DataColumn
    Friend WithEvents DataColumn39 As DataColumn
    Friend WithEvents DataColumn40 As DataColumn
    Friend WithEvents DataColumn41 As DataColumn
    Friend WithEvents DataColumn42 As DataColumn
    Friend WithEvents DataColumn43 As DataColumn
    Friend WithEvents DataColumn44 As DataColumn
    Friend WithEvents DataColumn45 As DataColumn
    Friend WithEvents DataColumn46 As DataColumn
    Friend WithEvents DataColumn47 As DataColumn
    Friend WithEvents DataColumn48 As DataColumn
    Friend WithEvents DataColumn49 As DataColumn
    Friend WithEvents DataColumn50 As DataColumn
    Friend WithEvents DataColumn51 As DataColumn
    Friend WithEvents DataColumn52 As DataColumn
    Friend WithEvents DataColumn53 As DataColumn
    Friend WithEvents DataColumn54 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents sels As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencycodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subconcode As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubconnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cons1DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cons2DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilledamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountcollectedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PonoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_contract_det_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilledamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencynameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExchangerateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasedrateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubconidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountcollectedbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeletedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
End Class
