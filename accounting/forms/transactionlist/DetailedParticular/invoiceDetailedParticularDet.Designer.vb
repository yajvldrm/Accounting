<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoiceDetailedParticularDet
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgView = New System.Windows.Forms.DataGridView()
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
        Me.trans_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_management_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pm_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_name_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contract_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contract_amount_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.billed_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billed_amount_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance_amount_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exchange_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.based_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_project_management_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 2)
        Me.Panel1.TabIndex = 281
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "Project Management"
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
        Me.btnOK.Location = New System.Drawing.Point(318, 359)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 24)
        Me.btnOK.TabIndex = 283
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
        Me.btnCancel.Location = New System.Drawing.Point(403, 358)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 284
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_id, Me.trans_no, Me.trans_date, Me.project_management_det_id, Me.pm_year, Me.project_id, Me.project_code, Me.project_name, Me.general_id, Me.general_code, Me.general_name, Me.department_code, Me.project_name_det, Me.contract_amount, Me.contract_amount_based, Me.sel, Me.billed_amount, Me.billed_amount_based, Me.balance_amount, Me.balance_amount_based, Me.currency_id, Me.exchange_rate, Me.based_rate})
        Me.dgView.Location = New System.Drawing.Point(12, 62)
        Me.dgView.Name = "dgView"
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(776, 283)
        Me.dgView.TabIndex = 285
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_project_management_det})
        '
        'trans_project_management_det
        '
        Me.trans_project_management_det.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
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
        Me.DataColumn2.ColumnName = "trans_id"
        Me.DataColumn2.DataType = GetType(Integer)
        Me.DataColumn2.DefaultValue = 0
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "trans_no"
        Me.DataColumn3.DataType = GetType(Integer)
        Me.DataColumn3.DefaultValue = 0
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "trans_date"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "project_management_det_id"
        Me.DataColumn5.DataType = GetType(Integer)
        Me.DataColumn5.DefaultValue = 0
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "pm_year"
        Me.DataColumn6.DataType = GetType(Integer)
        Me.DataColumn6.DefaultValue = 0
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "project_id"
        Me.DataColumn7.DataType = GetType(Integer)
        Me.DataColumn7.DefaultValue = 0
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "project_code"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "project_name"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "general_id"
        Me.DataColumn10.DataType = GetType(Integer)
        Me.DataColumn10.DefaultValue = 0
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "general_code"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "general_name"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "department_code"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "project_name_det"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "contract_amount"
        Me.DataColumn15.DataType = GetType(Decimal)
        Me.DataColumn15.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "contract_amount_based"
        Me.DataColumn16.DataType = GetType(Decimal)
        Me.DataColumn16.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "billed_amount"
        Me.DataColumn17.DataType = GetType(Decimal)
        Me.DataColumn17.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "billed_amount_based"
        Me.DataColumn18.DataType = GetType(Decimal)
        Me.DataColumn18.DefaultValue = "0.00"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "balance_amount"
        Me.DataColumn19.DataType = GetType(Decimal)
        Me.DataColumn19.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "currency_id"
        Me.DataColumn20.DataType = GetType(Integer)
        Me.DataColumn20.DefaultValue = 0
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
        'trans_id
        '
        Me.trans_id.DataPropertyName = "trans_id"
        Me.trans_id.HeaderText = "TRANSACTION ID"
        Me.trans_id.Name = "trans_id"
        Me.trans_id.Visible = False
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
        'pm_year
        '
        Me.pm_year.DataPropertyName = "pm_year"
        Me.pm_year.HeaderText = "YEAR REF"
        Me.pm_year.Name = "pm_year"
        Me.pm_year.ReadOnly = True
        '
        'project_id
        '
        Me.project_id.DataPropertyName = "project_id"
        Me.project_id.HeaderText = "project_id"
        Me.project_id.Name = "project_id"
        Me.project_id.Visible = False
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
        'department_code
        '
        Me.department_code.DataPropertyName = "department_code"
        Me.department_code.HeaderText = "PROJECT REFERENCE"
        Me.department_code.Name = "department_code"
        Me.department_code.ReadOnly = True
        '
        'project_name_det
        '
        Me.project_name_det.DataPropertyName = "project_name_det"
        Me.project_name_det.HeaderText = "PROJECT DESCRIPTION"
        Me.project_name_det.Name = "project_name_det"
        Me.project_name_det.ReadOnly = True
        '
        'contract_amount
        '
        Me.contract_amount.DataPropertyName = "contract_amount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.contract_amount.DefaultCellStyle = DataGridViewCellStyle1
        Me.contract_amount.HeaderText = "ORIGINAL CONTRACT"
        Me.contract_amount.Name = "contract_amount"
        Me.contract_amount.ReadOnly = True
        '
        'contract_amount_based
        '
        Me.contract_amount_based.DataPropertyName = "contract_amount_based"
        Me.contract_amount_based.HeaderText = "contract_amount_based"
        Me.contract_amount_based.Name = "contract_amount_based"
        Me.contract_amount_based.Visible = False
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 33
        '
        'billed_amount
        '
        Me.billed_amount.DataPropertyName = "billed_amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.billed_amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.billed_amount.HeaderText = "BILLED AMOUNT"
        Me.billed_amount.Name = "billed_amount"
        '
        'billed_amount_based
        '
        Me.billed_amount_based.DataPropertyName = "billed_amount_based"
        Me.billed_amount_based.HeaderText = "billed_amount_based"
        Me.billed_amount_based.Name = "billed_amount_based"
        Me.billed_amount_based.Visible = False
        '
        'balance_amount
        '
        Me.balance_amount.DataPropertyName = "balance_amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.balance_amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.balance_amount.HeaderText = "CONTRACT BALANCE"
        Me.balance_amount.Name = "balance_amount"
        Me.balance_amount.ReadOnly = True
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
        'invoiceDetailedParticularDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "invoiceDetailedParticularDet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_project_management_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents dgView As Windows.Forms.DataGridView
    Friend WithEvents ds As DataSet
    Friend WithEvents trans_project_management_det As DataTable
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
    Friend WithEvents trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_management_det_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pm_year As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_name_det As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contract_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contract_amount_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents billed_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billed_amount_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance_amount_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents currency_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exchange_rate As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents based_rate As Windows.Forms.DataGridViewTextBoxColumn
End Class
