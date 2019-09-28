<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailedChartList
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.account_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidationnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance_based = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_chart = New System.Data.DataTable()
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
        Me.txtsearch = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mainPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRunReport = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
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
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMain.AutoGenerateColumns = False
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.account_id, Me.AccountcodeDataGridViewTextBoxColumn, Me.account_name, Me.ValidationDataGridViewTextBoxColumn, Me.ValidationnameDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.credit_based, Me.balance_based})
        Me.dgMain.DataMember = "lib_erp_chart"
        Me.dgMain.DataSource = Me.ds
        Me.dgMain.Location = New System.Drawing.Point(12, 66)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(776, 487)
        Me.dgMain.TabIndex = 1
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'account_id
        '
        Me.account_id.DataPropertyName = "account_id"
        Me.account_id.HeaderText = "account_id"
        Me.account_id.Name = "account_id"
        Me.account_id.ReadOnly = True
        Me.account_id.Visible = False
        '
        'AccountcodeDataGridViewTextBoxColumn
        '
        Me.AccountcodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AccountcodeDataGridViewTextBoxColumn.DataPropertyName = "account_code"
        Me.AccountcodeDataGridViewTextBoxColumn.HeaderText = "Account Code"
        Me.AccountcodeDataGridViewTextBoxColumn.Name = "AccountcodeDataGridViewTextBoxColumn"
        Me.AccountcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'account_name
        '
        Me.account_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.account_name.DataPropertyName = "account_name"
        Me.account_name.HeaderText = "Account Title"
        Me.account_name.Name = "account_name"
        Me.account_name.ReadOnly = True
        '
        'ValidationDataGridViewTextBoxColumn
        '
        Me.ValidationDataGridViewTextBoxColumn.DataPropertyName = "validation"
        Me.ValidationDataGridViewTextBoxColumn.HeaderText = "validation"
        Me.ValidationDataGridViewTextBoxColumn.Name = "ValidationDataGridViewTextBoxColumn"
        Me.ValidationDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValidationDataGridViewTextBoxColumn.Visible = False
        '
        'ValidationnameDataGridViewTextBoxColumn
        '
        Me.ValidationnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ValidationnameDataGridViewTextBoxColumn.DataPropertyName = "validation_name"
        Me.ValidationnameDataGridViewTextBoxColumn.HeaderText = "Validation"
        Me.ValidationnameDataGridViewTextBoxColumn.Name = "ValidationnameDataGridViewTextBoxColumn"
        Me.ValidationnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValidationnameDataGridViewTextBoxColumn.Visible = False
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "debit_based"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.BalanceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Debit"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'credit_based
        '
        Me.credit_based.DataPropertyName = "credit_based"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.credit_based.DefaultCellStyle = DataGridViewCellStyle2
        Me.credit_based.HeaderText = "Credit"
        Me.credit_based.Name = "credit_based"
        Me.credit_based.ReadOnly = True
        '
        'balance_based
        '
        Me.balance_based.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.balance_based.DataPropertyName = "balance_based"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.balance_based.DefaultCellStyle = DataGridViewCellStyle3
        Me.balance_based.HeaderText = "Balance"
        Me.balance_based.Name = "balance_based"
        Me.balance_based.ReadOnly = True
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_chart})
        '
        'lib_erp_chart
        '
        Me.lib_erp_chart.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.lib_erp_chart.TableName = "lib_erp_chart"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "account_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "account_code"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "account_name"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "validation"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "validation_name"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "balance"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sel"
        Me.DataColumn7.DataType = GetType(Boolean)
        Me.DataColumn7.DefaultValue = False
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "debit"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "credit"
        Me.DataColumn9.DataType = GetType(Decimal)
        Me.DataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "debit_based"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "credit_based"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "balance_based"
        Me.DataColumn12.DataType = GetType(Decimal)
        Me.DataColumn12.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtsearch
        '
        Me.txtsearch._Text = ""
        Me.txtsearch.AllowNegative = False
        Me.txtsearch.AlwaysDisable = False
        Me.txtsearch.AlwaysEnable = False
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderColor = System.Drawing.Color.DarkGray
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.DataSource = ""
        Me.txtsearch.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtsearch.EnabledBackColor = System.Drawing.Color.White
        Me.txtsearch.ispk = False
        Me.txtsearch.Location = New System.Drawing.Point(638, 36)
        Me.txtsearch.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.MultiLine = False
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.SelectionLength = 0
        Me.txtsearch.SelectionStart = 0
        Me.txtsearch.Size = New System.Drawing.Size(150, 20)
        Me.txtsearch.TabIndex = 108
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = "account_code,account_name"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(594, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 25)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Chart of Accounts"
        '
        'mainPanel
        '
        Me.mainPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainPanel.Controls.Add(Me.btnRunReport)
        Me.mainPanel.Location = New System.Drawing.Point(12, 559)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(776, 29)
        Me.mainPanel.TabIndex = 112
        '
        'btnRunReport
        '
        Me.btnRunReport.Location = New System.Drawing.Point(3, 3)
        Me.btnRunReport.Name = "btnRunReport"
        Me.btnRunReport.Size = New System.Drawing.Size(75, 23)
        Me.btnRunReport.TabIndex = 0
        Me.btnRunReport.Text = "Run Report"
        Me.btnRunReport.UseVisualStyleBackColor = True
        '
        'border1
        '
        Me.border1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(15, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(773, 2)
        Me.border1.TabIndex = 110
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DetailedChartList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DetailedChartList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of Accounts"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents dgMain As Windows.Forms.DataGridView
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents border1 As borderedlabel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents mainPanel As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnRunReport As Windows.Forms.Button
    Friend WithEvents ds As DataSet
    Friend WithEvents lib_erp_chart As DataTable
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
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents account_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationnameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit_based As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance_based As Windows.Forms.DataGridViewTextBoxColumn
End Class
