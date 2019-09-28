<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.month_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.sales_month = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.sales_day = New System.Data.DataTable()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.accounts_receivable = New System.Data.DataTable()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.chart_accounts = New System.Data.DataTable()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.lbl_month = New System.Windows.Forms.Label()
        Me.lbl_day = New System.Windows.Forms.Label()
        Me.dgMain2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.txt_year = New System.Windows.Forms.NumericUpDown()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.target_year = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgMain3 = New System.Windows.Forms.DataGridView()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_receive = New System.Windows.Forms.Label()
        Me.lbl_chart = New System.Windows.Forms.Label()
        Me.dgMain4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.primary_key = New user_control.textbox()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_month, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_day, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accounts_receivable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.AutoGenerateColumns = False
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.month_name, Me.month, Me.amount})
        Me.dgMain.DataSource = Me.ds
        Me.dgMain.Location = New System.Drawing.Point(12, 42)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(244, 290)
        Me.dgMain.TabIndex = 211
        '
        'month_name
        '
        Me.month_name.DataPropertyName = "month_name"
        Me.month_name.HeaderText = "Month"
        Me.month_name.Name = "month_name"
        Me.month_name.ReadOnly = True
        '
        'month
        '
        Me.month.DataPropertyName = "month"
        Me.month.HeaderText = "month"
        Me.month.Name = "month"
        Me.month.Visible = False
        '
        'amount
        '
        Me.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.amount.DataPropertyName = "amount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "##,##0.00"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.sales_month, Me.sales_day, Me.accounts_receivable, Me.chart_accounts})
        '
        'sales_month
        '
        Me.sales_month.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.sales_month.TableName = "sales_month"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "month"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "month_name"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "year"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "amount"
        Me.DataColumn4.DataType = GetType(Decimal)
        Me.DataColumn4.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'sales_day
        '
        Me.sales_day.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6})
        Me.sales_day.TableName = "sales_day"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "trans_date"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "amount"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'accounts_receivable
        '
        Me.accounts_receivable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8})
        Me.accounts_receivable.TableName = "accounts_receivable"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "general_name"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "amount"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'chart_accounts
        '
        Me.chart_accounts.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.chart_accounts.TableName = "chart_accounts"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "account_code"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "account_name"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "amount"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lbl_month
        '
        Me.lbl_month.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_month.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_month.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_month.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbl_month.Location = New System.Drawing.Point(12, 9)
        Me.lbl_month.Name = "lbl_month"
        Me.lbl_month.Padding = New System.Windows.Forms.Padding(20, 1, 0, 0)
        Me.lbl_month.Size = New System.Drawing.Size(244, 30)
        Me.lbl_month.TabIndex = 209
        Me.lbl_month.Text = "Sales Per Month"
        Me.lbl_month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_day
        '
        Me.lbl_day.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_day.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_day.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_day.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbl_day.Location = New System.Drawing.Point(12, 339)
        Me.lbl_day.Name = "lbl_day"
        Me.lbl_day.Padding = New System.Windows.Forms.Padding(20, 1, 0, 0)
        Me.lbl_day.Size = New System.Drawing.Size(244, 30)
        Me.lbl_day.TabIndex = 212
        Me.lbl_day.Text = "Sales Per Day"
        Me.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgMain2
        '
        Me.dgMain2.AllowUserToAddRows = False
        Me.dgMain2.AllowUserToDeleteRows = False
        Me.dgMain2.AllowUserToResizeColumns = False
        Me.dgMain2.AllowUserToResizeRows = False
        Me.dgMain2.AutoGenerateColumns = False
        Me.dgMain2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgMain2.DataSource = Me.ds
        Me.dgMain2.Location = New System.Drawing.Point(12, 373)
        Me.dgMain2.MultiSelect = False
        Me.dgMain2.Name = "dgMain2"
        Me.dgMain2.RowHeadersVisible = False
        Me.dgMain2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain2.Size = New System.Drawing.Size(244, 290)
        Me.dgMain2.TabIndex = 213
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "trans_date"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = "00/00/0000"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "amount"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "##,##0.00"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'btn_load
        '
        Me.btn_load.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.ForeColor = System.Drawing.Color.White
        Me.btn_load.Location = New System.Drawing.Point(1270, 12)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(75, 25)
        Me.btn_load.TabIndex = 218
        Me.btn_load.Text = "Load"
        Me.btn_load.UseVisualStyleBackColor = False
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(1184, 15)
        Me.txt_year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(80, 19)
        Me.txt_year.TabIndex = 217
        Me.txt_year.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'lbl_year
        '
        Me.lbl_year.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_year.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbl_year.Location = New System.Drawing.Point(308, 9)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Padding = New System.Windows.Forms.Padding(20, 1, 0, 0)
        Me.lbl_year.Size = New System.Drawing.Size(1040, 30)
        Me.lbl_year.TabIndex = 216
        Me.lbl_year.Text = "Sales Per Year"
        Me.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'target_year
        '
        Me.target_year.AutoSize = True
        Me.target_year.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.target_year.Location = New System.Drawing.Point(1151, 17)
        Me.target_year.Name = "target_year"
        Me.target_year.Size = New System.Drawing.Size(29, 15)
        Me.target_year.TabIndex = 215
        Me.target_year.Text = "Year"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.ActiveCaption
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(270, 42)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10
        Series2.Name = "Collection Per Month"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1100, 299)
        Me.Chart1.TabIndex = 214
        Me.Chart1.Text = "Chart1"
        '
        'dgMain3
        '
        Me.dgMain3.AllowUserToAddRows = False
        Me.dgMain3.AllowUserToDeleteRows = False
        Me.dgMain3.AllowUserToResizeColumns = False
        Me.dgMain3.AllowUserToResizeRows = False
        Me.dgMain3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.general_name, Me.debit})
        Me.dgMain3.Location = New System.Drawing.Point(304, 373)
        Me.dgMain3.MultiSelect = False
        Me.dgMain3.Name = "dgMain3"
        Me.dgMain3.RowHeadersVisible = False
        Me.dgMain3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain3.Size = New System.Drawing.Size(500, 290)
        Me.dgMain3.TabIndex = 221
        '
        'general_name
        '
        Me.general_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Client"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        '
        'debit
        '
        Me.debit.DataPropertyName = "amount"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "##,##0.00"
        DataGridViewCellStyle9.NullValue = "0.00"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle9
        Me.debit.HeaderText = "Amount"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        Me.debit.Width = 130
        '
        'lbl_receive
        '
        Me.lbl_receive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_receive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_receive.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_receive.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_receive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbl_receive.Location = New System.Drawing.Point(304, 339)
        Me.lbl_receive.Name = "lbl_receive"
        Me.lbl_receive.Padding = New System.Windows.Forms.Padding(20, 1, 0, 0)
        Me.lbl_receive.Size = New System.Drawing.Size(500, 30)
        Me.lbl_receive.TabIndex = 220
        Me.lbl_receive.Text = "Accounts Receivable"
        Me.lbl_receive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_chart
        '
        Me.lbl_chart.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_chart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_chart.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_chart.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbl_chart.Location = New System.Drawing.Point(850, 339)
        Me.lbl_chart.Name = "lbl_chart"
        Me.lbl_chart.Padding = New System.Windows.Forms.Padding(20, 1, 0, 0)
        Me.lbl_chart.Size = New System.Drawing.Size(500, 30)
        Me.lbl_chart.TabIndex = 224
        Me.lbl_chart.Text = "Key Accounts"
        Me.lbl_chart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgMain4
        '
        Me.dgMain4.AllowUserToAddRows = False
        Me.dgMain4.AllowUserToDeleteRows = False
        Me.dgMain4.AllowUserToResizeColumns = False
        Me.dgMain4.AllowUserToResizeRows = False
        Me.dgMain4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column1})
        Me.dgMain4.Location = New System.Drawing.Point(850, 373)
        Me.dgMain4.MultiSelect = False
        Me.dgMain4.Name = "dgMain4"
        Me.dgMain4.ReadOnly = True
        Me.dgMain4.RowHeadersVisible = False
        Me.dgMain4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain4.Size = New System.Drawing.Size(500, 290)
        Me.dgMain4.TabIndex = 227
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "account_code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "account_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "amount"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "##,##0.00"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column1.HeaderText = "Amount"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 130
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.accounting.My.Resources.Resources.print
        Me.PictureBox4.Location = New System.Drawing.Point(15, 345)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 229
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.accounting.My.Resources.Resources.print
        Me.PictureBox3.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 228
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.accounting.My.Resources.Resources.print
        Me.PictureBox2.Location = New System.Drawing.Point(854, 345)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 226
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.accounting.My.Resources.Resources.print
        Me.PictureBox1.Location = New System.Drawing.Point(308, 345)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 225
        Me.PictureBox1.TabStop = False
        '
        'primary_key
        '
        Me.primary_key._Text = ""
        Me.primary_key.AlwaysDisable = False
        Me.primary_key.AlwaysEnable = False
        Me.primary_key.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.primary_key.BorderColor = System.Drawing.Color.DarkGray
        Me.primary_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.primary_key.DataSource = ""
        Me.primary_key.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.primary_key.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.primary_key.EnabledBackColor = System.Drawing.Color.White
        Me.primary_key.ispk = False
        Me.primary_key.Location = New System.Drawing.Point(466, 491)
        Me.primary_key.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.MultiLine = False
        Me.primary_key.Name = "primary_key"
        Me.primary_key.NoClear = False
        Me.primary_key.NumberFormat = "@"
        Me.primary_key.Required = False
        Me.primary_key.RowData = Nothing
        Me.primary_key.SelectionLength = 0
        Me.primary_key.SelectionStart = 0
        Me.primary_key.Size = New System.Drawing.Size(106, 18)
        Me.primary_key.TabIndex = 219
        Me.primary_key.TableData = Nothing
        Me.primary_key.TextSource = ""
        Me.primary_key.UseSystemPasswordChar = False
        Me.primary_key.Value = ""
        Me.primary_key.ValueSource = "account_id"
        Me.primary_key.Visible = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1360, 675)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.dgMain4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_chart)
        Me.Controls.Add(Me.lbl_receive)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.target_year)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.dgMain3)
        Me.Controls.Add(Me.dgMain2)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.lbl_month)
        Me.Controls.Add(Me.lbl_day)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.primary_key)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_month, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_day, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accounts_receivable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_month As System.Windows.Forms.Label
    Friend WithEvents lbl_day As System.Windows.Forms.Label
    Friend WithEvents dgMain2 As System.Windows.Forms.DataGridView
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents sales_month As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents sales_day As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents btn_load As System.Windows.Forms.Button
    Friend WithEvents txt_year As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents target_year As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents dgMain3 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_receive As System.Windows.Forms.Label
    Friend WithEvents primary_key As user_control.textbox
    Friend WithEvents lbl_chart As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents month_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents month As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accounts_receivable As System.Data.DataTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents chart_accounts As System.Data.DataTable
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents dgMain4 As System.Windows.Forms.DataGridView
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
