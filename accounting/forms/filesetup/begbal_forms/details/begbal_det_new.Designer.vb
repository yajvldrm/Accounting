<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class begbal_det_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(begbal_det_new))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.txt_line_remarks = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_po_no = New System.Windows.Forms.TextBox()
        Me.txt_rr_no = New System.Windows.Forms.TextBox()
        Me.txt_si_no = New System.Windows.Forms.TextBox()
        Me.txt_trans_date = New DevExpress.XtraEditors.DateEdit()
        Me.txt_trans_no = New System.Windows.Forms.TextBox()
        Me.txt_general_name = New System.Windows.Forms.TextBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.TransidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunningbalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunningbalancebasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet()
        Me.get_offsetting_schedule = New System.Data.DataTable()
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblLoad = New System.Windows.Forms.Label()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txt_line_remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_trans_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_trans_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.get_offsetting_schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Collection Details"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 2)
        Me.Panel1.TabIndex = 1
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.txt_amount)
        Me.LayoutControl1.Controls.Add(Me.txt_line_remarks)
        Me.LayoutControl1.Controls.Add(Me.txt_po_no)
        Me.LayoutControl1.Controls.Add(Me.txt_rr_no)
        Me.LayoutControl1.Controls.Add(Me.txt_si_no)
        Me.LayoutControl1.Controls.Add(Me.txt_trans_date)
        Me.LayoutControl1.Controls.Add(Me.txt_trans_no)
        Me.LayoutControl1.Controls.Add(Me.txt_general_name)
        Me.LayoutControl1.Location = New System.Drawing.Point(12, 40)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(760, 138)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(440, 12)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.ReadOnly = True
        Me.txt_amount.Size = New System.Drawing.Size(308, 20)
        Me.txt_amount.TabIndex = 12
        '
        'txt_line_remarks
        '
        Me.txt_line_remarks.Location = New System.Drawing.Point(70, 60)
        Me.txt_line_remarks.Name = "txt_line_remarks"
        Me.txt_line_remarks.Properties.ReadOnly = True
        Me.txt_line_remarks.Size = New System.Drawing.Size(678, 42)
        Me.txt_line_remarks.StyleController = Me.LayoutControl1
        Me.txt_line_remarks.TabIndex = 11
        '
        'txt_po_no
        '
        Me.txt_po_no.Location = New System.Drawing.Point(558, 106)
        Me.txt_po_no.Name = "txt_po_no"
        Me.txt_po_no.ReadOnly = True
        Me.txt_po_no.Size = New System.Drawing.Size(190, 20)
        Me.txt_po_no.TabIndex = 10
        '
        'txt_rr_no
        '
        Me.txt_rr_no.Location = New System.Drawing.Point(323, 106)
        Me.txt_rr_no.Name = "txt_rr_no"
        Me.txt_rr_no.ReadOnly = True
        Me.txt_rr_no.Size = New System.Drawing.Size(173, 20)
        Me.txt_rr_no.TabIndex = 9
        '
        'txt_si_no
        '
        Me.txt_si_no.Location = New System.Drawing.Point(70, 106)
        Me.txt_si_no.Name = "txt_si_no"
        Me.txt_si_no.ReadOnly = True
        Me.txt_si_no.Size = New System.Drawing.Size(191, 20)
        Me.txt_si_no.TabIndex = 8
        '
        'txt_trans_date
        '
        Me.txt_trans_date.EditValue = Nothing
        Me.txt_trans_date.Location = New System.Drawing.Point(441, 36)
        Me.txt_trans_date.Name = "txt_trans_date"
        Me.txt_trans_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_trans_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_trans_date.Properties.ReadOnly = True
        Me.txt_trans_date.Size = New System.Drawing.Size(307, 20)
        Me.txt_trans_date.StyleController = Me.LayoutControl1
        Me.txt_trans_date.TabIndex = 6
        '
        'txt_trans_no
        '
        Me.txt_trans_no.Location = New System.Drawing.Point(70, 36)
        Me.txt_trans_no.Name = "txt_trans_no"
        Me.txt_trans_no.ReadOnly = True
        Me.txt_trans_no.Size = New System.Drawing.Size(309, 20)
        Me.txt_trans_no.TabIndex = 5
        '
        'txt_general_name
        '
        Me.txt_general_name.Location = New System.Drawing.Point(70, 12)
        Me.txt_general_name.Name = "txt_general_name"
        Me.txt_general_name.ReadOnly = True
        Me.txt_general_name.Size = New System.Drawing.Size(308, 20)
        Me.txt_general_name.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem4, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(760, 138)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txt_general_name
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(370, 24)
        Me.LayoutControlItem1.Text = "GenRef"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txt_trans_no
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(371, 24)
        Me.LayoutControlItem2.Text = "Voucher No"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txt_trans_date
        Me.LayoutControlItem3.Location = New System.Drawing.Point(371, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(369, 24)
        Me.LayoutControlItem3.Text = "Date"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txt_si_no
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(253, 24)
        Me.LayoutControlItem5.Text = "S.I."
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txt_rr_no
        Me.LayoutControlItem6.Location = New System.Drawing.Point(253, 94)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem6.Text = "R.R."
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txt_po_no
        Me.LayoutControlItem7.Location = New System.Drawing.Point(488, 94)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(252, 24)
        Me.LayoutControlItem7.Text = "P.O."
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txt_line_remarks
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(740, 46)
        Me.LayoutControlItem4.Text = "Remarks"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txt_amount
        Me.LayoutControlItem8.Location = New System.Drawing.Point(370, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(370, 24)
        Me.LayoutControlItem8.Text = "Amount"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(55, 13)
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMain.AutoGenerateColumns = False
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransidDataGridViewTextBoxColumn, Me.TransdateDataGridViewTextBoxColumn, Me.TransnoDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.DebitbasedDataGridViewTextBoxColumn, Me.CreditbasedDataGridViewTextBoxColumn, Me.RunningbalanceDataGridViewTextBoxColumn, Me.RunningbalancebasedDataGridViewTextBoxColumn})
        Me.dgMain.DataSource = Me.bs
        Me.dgMain.Location = New System.Drawing.Point(12, 172)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.ReadOnly = True
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(760, 377)
        Me.dgMain.TabIndex = 3
        '
        'TransidDataGridViewTextBoxColumn
        '
        Me.TransidDataGridViewTextBoxColumn.DataPropertyName = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.HeaderText = "trans_id"
        Me.TransidDataGridViewTextBoxColumn.Name = "TransidDataGridViewTextBoxColumn"
        Me.TransidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransidDataGridViewTextBoxColumn.Visible = False
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "trans_date"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TransdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        Me.TransdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "Voucher No"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        Me.TransnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "debit"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.DebitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "Debit"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        Me.DebitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "credit"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.CreditDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebitbasedDataGridViewTextBoxColumn
        '
        Me.DebitbasedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DebitbasedDataGridViewTextBoxColumn.DataPropertyName = "debit_based"
        Me.DebitbasedDataGridViewTextBoxColumn.HeaderText = "debit_based"
        Me.DebitbasedDataGridViewTextBoxColumn.Name = "DebitbasedDataGridViewTextBoxColumn"
        Me.DebitbasedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DebitbasedDataGridViewTextBoxColumn.Visible = False
        '
        'CreditbasedDataGridViewTextBoxColumn
        '
        Me.CreditbasedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CreditbasedDataGridViewTextBoxColumn.DataPropertyName = "credit_based"
        Me.CreditbasedDataGridViewTextBoxColumn.HeaderText = "credit_based"
        Me.CreditbasedDataGridViewTextBoxColumn.Name = "CreditbasedDataGridViewTextBoxColumn"
        Me.CreditbasedDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditbasedDataGridViewTextBoxColumn.Visible = False
        '
        'RunningbalanceDataGridViewTextBoxColumn
        '
        Me.RunningbalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RunningbalanceDataGridViewTextBoxColumn.DataPropertyName = "running_balance"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.RunningbalanceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.RunningbalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.RunningbalanceDataGridViewTextBoxColumn.Name = "RunningbalanceDataGridViewTextBoxColumn"
        Me.RunningbalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RunningbalancebasedDataGridViewTextBoxColumn
        '
        Me.RunningbalancebasedDataGridViewTextBoxColumn.DataPropertyName = "running_balance_based"
        Me.RunningbalancebasedDataGridViewTextBoxColumn.HeaderText = "running_balance_based"
        Me.RunningbalancebasedDataGridViewTextBoxColumn.Name = "RunningbalancebasedDataGridViewTextBoxColumn"
        Me.RunningbalancebasedDataGridViewTextBoxColumn.ReadOnly = True
        Me.RunningbalancebasedDataGridViewTextBoxColumn.Visible = False
        '
        'bs
        '
        Me.bs.DataMember = "get_offsetting_schedule"
        Me.bs.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.get_offsetting_schedule})
        '
        'get_offsetting_schedule
        '
        Me.get_offsetting_schedule.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.get_offsetting_schedule.TableName = "get_offsetting_schedule"
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
        Me.DataColumn4.ColumnName = "debit"
        Me.DataColumn4.DataType = GetType(Decimal)
        Me.DataColumn4.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "credit"
        Me.DataColumn5.DataType = GetType(Decimal)
        Me.DataColumn5.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "debit_based"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "credit_based"
        Me.DataColumn7.DataType = GetType(Decimal)
        Me.DataColumn7.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "running_balance"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "running_balance_based"
        Me.DataColumn9.DataType = GetType(Decimal)
        Me.DataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "journal_id"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "journal_code"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "journal_name"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "book_id"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "book_code"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "book_name"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "currency_id"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "currency_code"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "currency_name"
        Me.DataColumn18.DefaultValue = ""
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(167, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.ToolTip = "Print"
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(247, 230)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 226
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'begbal_det_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "begbal_det_new"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection Details"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txt_line_remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_trans_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_trans_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.get_offsetting_schedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txt_po_no As Windows.Forms.TextBox
    Friend WithEvents txt_rr_no As Windows.Forms.TextBox
    Friend WithEvents txt_si_no As Windows.Forms.TextBox
    Friend WithEvents txt_trans_date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_trans_no As Windows.Forms.TextBox
    Friend WithEvents txt_general_name As Windows.Forms.TextBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txt_line_remarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgMain As Windows.Forms.DataGridView
    Friend WithEvents ds As DataSet
    Friend WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents get_offsetting_schedule As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents txt_amount As Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TransidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransdateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RunningbalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RunningbalancebasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents DataColumn18 As DataColumn
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
