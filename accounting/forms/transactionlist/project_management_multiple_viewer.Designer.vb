<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class project_management_multiple_viewer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.Myformheader1 = New user_control.myformheader()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.ds = New System.Data.DataSet()
        Me.trans_project_management = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.trans_project_management_det = New System.Data.DataTable()
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
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.project_management_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pm_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_project_management, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_project_management_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(438, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Quick Search"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.AutoGenerateColumns = False
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.project_management_id, Me.project_name, Me.general_name, Me.pm_year})
        Me.dgview.DataMember = "trans_project_management"
        Me.dgview.DataSource = Me.ds
        Me.dgview.Location = New System.Drawing.Point(22, 82)
        Me.dgview.Name = "dgview"
        Me.dgview.RowHeadersVisible = False
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(753, 495)
        Me.dgview.TabIndex = 13
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(800, 30)
        Me.Myformheader1.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(554, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox1.TabIndex = 17
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(24, 47)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(80, 24)
        Me.btnPrevious.TabIndex = 18
        Me.btnPrevious.Text = "Done"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_project_management, Me.trans_project_management_det})
        '
        'trans_project_management
        '
        Me.trans_project_management.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39})
        Me.trans_project_management.TableName = "trans_project_management"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "project_management_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "pm_year"
        Me.DataColumn2.DataType = GetType(Integer)
        Me.DataColumn2.DefaultValue = 0
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "general_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "project_id"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sel"
        Me.DataColumn35.DataType = GetType(Boolean)
        Me.DataColumn35.DefaultValue = False
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "general_code"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "general_name"
        Me.DataColumn37.DefaultValue = ""
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "project_code"
        Me.DataColumn38.DefaultValue = ""
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "project_name"
        Me.DataColumn39.DefaultValue = ""
        '
        'trans_project_management_det
        '
        Me.trans_project_management_det.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34})
        Me.trans_project_management_det.TableName = "trans_project_management_det"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "project_management_det_id"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "project_management_id"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "isPriorDate"
        Me.DataColumn7.DataType = GetType(Boolean)
        Me.DataColumn7.DefaultValue = False
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "trans_date"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "contract_date"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "currency_id"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "exchange_rate"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "based_rate"
        Me.DataColumn12.DataType = GetType(Decimal)
        Me.DataColumn12.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "po_no"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "department_code"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "project_name"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "date_from"
        Me.DataColumn16.DataType = GetType(Date)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "date_to"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "contract_amount"
        Me.DataColumn18.DataType = GetType(Decimal)
        Me.DataColumn18.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "contract_amount_based"
        Me.DataColumn19.DataType = GetType(Decimal)
        Me.DataColumn19.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "contract_cost"
        Me.DataColumn20.DataType = GetType(Decimal)
        Me.DataColumn20.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "contract_cost_based"
        Me.DataColumn21.DataType = GetType(Decimal)
        Me.DataColumn21.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "profit_amount"
        Me.DataColumn22.DataType = GetType(Decimal)
        Me.DataColumn22.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "profit_amount_based"
        Me.DataColumn23.DataType = GetType(Decimal)
        Me.DataColumn23.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "accomplishment_amount"
        Me.DataColumn24.DataType = GetType(Decimal)
        Me.DataColumn24.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "accomplishment_amount_based"
        Me.DataColumn25.DataType = GetType(Decimal)
        Me.DataColumn25.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "billed_amount"
        Me.DataColumn26.DataType = GetType(Decimal)
        Me.DataColumn26.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "billed_amount_based"
        Me.DataColumn27.DataType = GetType(Decimal)
        Me.DataColumn27.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "collected_amount"
        Me.DataColumn28.DataType = GetType(Decimal)
        Me.DataColumn28.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "collected_amount_based"
        Me.DataColumn29.DataType = GetType(Decimal)
        Me.DataColumn29.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "insured_with"
        Me.DataColumn30.DefaultValue = ""
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sel"
        Me.DataColumn31.DataType = GetType(Boolean)
        Me.DataColumn31.DefaultValue = False
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "deleted"
        Me.DataColumn32.DataType = GetType(Boolean)
        Me.DataColumn32.DefaultValue = False
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "currency_code"
        Me.DataColumn33.DefaultValue = ""
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "currency_name"
        Me.DataColumn34.DefaultValue = ""
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(110, 47)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'project_management_id
        '
        Me.project_management_id.DataPropertyName = "project_management_id"
        Me.project_management_id.HeaderText = "project_management_id"
        Me.project_management_id.Name = "project_management_id"
        Me.project_management_id.Visible = False
        '
        'project_name
        '
        Me.project_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.project_name.DataPropertyName = "project_name"
        Me.project_name.HeaderText = "Project Name"
        Me.project_name.Name = "project_name"
        '
        'general_name
        '
        Me.general_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Client"
        Me.general_name.Name = "general_name"
        '
        'pm_year
        '
        Me.pm_year.DataPropertyName = "pm_year"
        Me.pm_year.HeaderText = "Year"
        Me.pm_year.Name = "pm_year"
        '
        'project_management_multiple_viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "project_management_multiple_viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Project Viewer"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_project_management, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_project_management_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents dgview As Windows.Forms.DataGridView
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents btnPrevious As Windows.Forms.Button
    Friend WithEvents ds As DataSet
    Friend WithEvents trans_project_management As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn35 As DataColumn
    Friend WithEvents trans_project_management_det As DataTable
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
    Friend WithEvents DataColumn33 As DataColumn
    Friend WithEvents DataColumn34 As DataColumn
    Friend WithEvents DataColumn36 As DataColumn
    Friend WithEvents DataColumn37 As DataColumn
    Friend WithEvents DataColumn38 As DataColumn
    Friend WithEvents DataColumn39 As DataColumn
    Friend WithEvents btnDelete As Windows.Forms.Button
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents project_management_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pm_year As Windows.Forms.DataGridViewTextBoxColumn
End Class
