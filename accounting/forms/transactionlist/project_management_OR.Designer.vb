<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class project_management_OR
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ds = New System.Data.DataSet()
        Me.trans_project_management_det = New System.Data.DataTable()
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
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trans_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pm_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billed_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.amount_collected = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.variance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_management_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contract_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contract_amount_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billed_amount_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance_amount_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exchange_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.based_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_project_management_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_project_management_det})
        '
        'trans_project_management_det
        '
        Me.trans_project_management_det.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.trans_project_management_det.TableName = "trans_project_management_det"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_project_management_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "trans_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "project_management_det_id"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "currency_id"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "exchange_rate"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "based_rate"
        Me.DataColumn7.DataType = GetType(Decimal)
        Me.DataColumn7.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "pm_year"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "general_id"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "project_id"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "project_code"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "project_name"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "general_code"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "general_name"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "project_description"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "amount_collected"
        Me.DataColumn16.DataType = GetType(Decimal)
        Me.DataColumn16.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "amount_collected_based"
        Me.DataColumn17.DataType = GetType(Decimal)
        Me.DataColumn17.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "variance"
        Me.DataColumn18.DataType = GetType(Decimal)
        Me.DataColumn18.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "variance_based"
        Me.DataColumn19.DataType = GetType(Decimal)
        Me.DataColumn19.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "deleted"
        Me.DataColumn20.DataType = GetType(Boolean)
        Me.DataColumn20.DefaultValue = False
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "billed_amount"
        Me.DataColumn21.DataType = GetType(Decimal)
        Me.DataColumn21.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "billed_amount_based"
        Me.DataColumn22.DataType = GetType(Decimal)
        Me.DataColumn22.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "tmp_amount_collected"
        Me.DataColumn23.DataType = GetType(Decimal)
        Me.DataColumn23.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "tmp_amount_collected_based"
        Me.DataColumn24.DataType = GetType(Decimal)
        Me.DataColumn24.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_id, Me.pm_year, Me.project_code, Me.project_name, Me.project_description, Me.billed_amount, Me.sel, Me.amount_collected, Me.variance, Me.trans_no, Me.trans_date, Me.project_management_det_id, Me.project_id, Me.general_id, Me.general_code, Me.general_name, Me.contract_amount, Me.contract_amount_based, Me.billed_amount_based, Me.balance_amount_based, Me.currency_id, Me.exchange_rate, Me.based_rate})
        Me.dgView.Location = New System.Drawing.Point(12, 66)
        Me.dgView.Name = "dgView"
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(776, 283)
        Me.dgView.TabIndex = 290
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
        Me.btnOK.Location = New System.Drawing.Point(345, 364)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 24)
        Me.btnOK.TabIndex = 288
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
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
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 286
        Me.Label1.Text = "Project Management"
        '
        'trans_id
        '
        Me.trans_id.DataPropertyName = "trans_id"
        Me.trans_id.HeaderText = "TRANSACTION ID"
        Me.trans_id.Name = "trans_id"
        Me.trans_id.Visible = False
        '
        'pm_year
        '
        Me.pm_year.DataPropertyName = "pm_year"
        Me.pm_year.HeaderText = "YEAR REF"
        Me.pm_year.Name = "pm_year"
        Me.pm_year.ReadOnly = True
        '
        'project_code
        '
        Me.project_code.DataPropertyName = "project_code"
        Me.project_code.HeaderText = "PROJECT CODE"
        Me.project_code.Name = "project_code"
        Me.project_code.ReadOnly = True
        '
        'project_name
        '
        Me.project_name.DataPropertyName = "project_name"
        Me.project_name.HeaderText = "PROJECT NAME"
        Me.project_name.Name = "project_name"
        Me.project_name.ReadOnly = True
        '
        'project_description
        '
        Me.project_description.DataPropertyName = "project_description"
        Me.project_description.HeaderText = "PROJECT DESCRIPTION"
        Me.project_description.Name = "project_description"
        Me.project_description.ReadOnly = True
        '
        'billed_amount
        '
        Me.billed_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.billed_amount.DataPropertyName = "billed_amount"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.billed_amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.billed_amount.HeaderText = "BILLED AMOUNT"
        Me.billed_amount.Name = "billed_amount"
        Me.billed_amount.ReadOnly = True
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 33
        '
        'amount_collected
        '
        Me.amount_collected.DataPropertyName = "amount_collected"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.amount_collected.DefaultCellStyle = DataGridViewCellStyle5
        Me.amount_collected.HeaderText = "AMOUNT COLLECTED"
        Me.amount_collected.Name = "amount_collected"
        '
        'variance
        '
        Me.variance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.variance.DataPropertyName = "variance"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.variance.DefaultCellStyle = DataGridViewCellStyle6
        Me.variance.HeaderText = "CONTRACT BALANCE"
        Me.variance.Name = "variance"
        Me.variance.ReadOnly = True
        '
        'trans_no
        '
        Me.trans_no.DataPropertyName = "trans_no"
        Me.trans_no.HeaderText = "trans_no"
        Me.trans_no.Name = "trans_no"
        Me.trans_no.Visible = False
        '
        'trans_date
        '
        Me.trans_date.DataPropertyName = "trans_date"
        Me.trans_date.HeaderText = "trans_date"
        Me.trans_date.Name = "trans_date"
        Me.trans_date.Visible = False
        '
        'project_management_det_id
        '
        Me.project_management_det_id.DataPropertyName = "project_management_det_id"
        Me.project_management_det_id.HeaderText = "project_management_det_id"
        Me.project_management_det_id.Name = "project_management_det_id"
        Me.project_management_det_id.Visible = False
        '
        'project_id
        '
        Me.project_id.DataPropertyName = "project_id"
        Me.project_id.HeaderText = "project_id"
        Me.project_id.Name = "project_id"
        Me.project_id.Visible = False
        '
        'general_id
        '
        Me.general_id.DataPropertyName = "general_id"
        Me.general_id.HeaderText = "general_id"
        Me.general_id.Name = "general_id"
        Me.general_id.Visible = False
        '
        'general_code
        '
        Me.general_code.DataPropertyName = "general_code"
        Me.general_code.HeaderText = "general_code"
        Me.general_code.Name = "general_code"
        Me.general_code.Visible = False
        '
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "general_name"
        Me.general_name.Name = "general_name"
        Me.general_name.Visible = False
        '
        'contract_amount
        '
        Me.contract_amount.DataPropertyName = "contract_amount"
        Me.contract_amount.HeaderText = "ORIGINAL CONTRACT"
        Me.contract_amount.Name = "contract_amount"
        Me.contract_amount.Visible = False
        '
        'contract_amount_based
        '
        Me.contract_amount_based.DataPropertyName = "contract_amount_based"
        Me.contract_amount_based.HeaderText = "contract_amount_based"
        Me.contract_amount_based.Name = "contract_amount_based"
        Me.contract_amount_based.Visible = False
        '
        'billed_amount_based
        '
        Me.billed_amount_based.DataPropertyName = "billed_amount_based"
        Me.billed_amount_based.HeaderText = "billed_amount_based"
        Me.billed_amount_based.Name = "billed_amount_based"
        Me.billed_amount_based.Visible = False
        '
        'balance_amount_based
        '
        Me.balance_amount_based.DataPropertyName = "balance_amount_based"
        Me.balance_amount_based.HeaderText = "balance_amount_based"
        Me.balance_amount_based.Name = "balance_amount_based"
        Me.balance_amount_based.Visible = False
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
        'project_management_OR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "project_management_OR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Management"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_project_management_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ds As DataSet
    Friend WithEvents trans_project_management_det As DataTable
    Friend WithEvents dgView As Windows.Forms.DataGridView
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
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
    Friend WithEvents trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pm_year As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billed_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents amount_collected As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents variance As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_management_det_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contract_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contract_amount_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billed_amount_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance_amount_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exchange_rate As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents based_rate As Windows.Forms.DataGridViewTextBoxColumn
End Class
