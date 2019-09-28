<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Project_management
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
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.clientpnl = New System.Windows.Forms.Panel()
        Me.txt_project_management_id = New user_control.textbox()
        Me.txt_general_name = New user_control.textbox()
        Me.txt_general_id = New user_control.textbox()
        Me.txt_pm_year = New System.Windows.Forms.NumericUpDown()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_project_name = New user_control.textbox()
        Me.txt_project_id = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.transpnl = New System.Windows.Forms.Panel()
        Me.txt_department_id = New user_control.textbox()
        Me.txt_project_management_det_id = New user_control.textbox()
        Me.txt_insured_with = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_collected_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_billed_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_accomplishment_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_profit_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_contract_cost = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_contract_amount_based = New DevExpress.XtraEditors.TextEdit()
        Me.txt_contract_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_based_rate = New DevExpress.XtraEditors.TextEdit()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.txt_exchange_rate = New DevExpress.XtraEditors.TextEdit()
        Me.txt_currency_id = New user_control.textbox()
        Me.txt_project_name_det = New System.Windows.Forms.TextBox()
        Me.txt_po_no = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_contract_date = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_trans_date = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ispriordate = New System.Windows.Forms.CheckBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_management_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectmanagementidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsPriorDateDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contract_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExchangerateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasedrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.po_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_from = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractcostbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfitamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfitamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccomplishmentamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccomplishmentamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilledamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilledamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollectedamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollectedamountbasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuredwithDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CurrencycodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Myformheader1 = New user_control.myformheader()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_project_management, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_project_management_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.clientpnl.SuspendLayout()
        CType(Me.txt_pm_year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transpnl.SuspendLayout()
        CType(Me.txt_collected_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_billed_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_accomplishment_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_profit_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contract_cost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contract_amount_based.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contract_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_based_rate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_exchange_rate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.trans_project_management, Me.trans_project_management_det})
        '
        'trans_project_management
        '
        Me.trans_project_management.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38})
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
        Me.DataColumn35.ColumnName = "general_code"
        Me.DataColumn35.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "general_name"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "project_code"
        Me.DataColumn37.DefaultValue = ""
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "project_name"
        Me.DataColumn38.DefaultValue = ""
        '
        'trans_project_management_det
        '
        Me.trans_project_management_det.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn39, Me.DataColumn40})
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
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "department_id"
        Me.DataColumn39.DefaultValue = ""
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "department_name"
        Me.DataColumn40.DefaultValue = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Project Management"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 2)
        Me.Panel1.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(194, 66)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 28)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "F5 Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(111, 66)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 28)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "F3 Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(28, 66)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 28)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "F2 Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(112, 66)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 28)
        Me.btnNotSave.TabIndex = 332
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        Me.btnNotSave.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(28, 66)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 28)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'clientpnl
        '
        Me.clientpnl.Controls.Add(Me.txt_project_management_id)
        Me.clientpnl.Controls.Add(Me.txt_general_name)
        Me.clientpnl.Controls.Add(Me.txt_general_id)
        Me.clientpnl.Controls.Add(Me.txt_pm_year)
        Me.clientpnl.Controls.Add(Me.txt_project_name)
        Me.clientpnl.Controls.Add(Me.txt_project_id)
        Me.clientpnl.Controls.Add(Me.Label4)
        Me.clientpnl.Controls.Add(Me.Label3)
        Me.clientpnl.Controls.Add(Me.Label2)
        Me.clientpnl.Enabled = False
        Me.clientpnl.Location = New System.Drawing.Point(12, 99)
        Me.clientpnl.Name = "clientpnl"
        Me.clientpnl.Size = New System.Drawing.Size(776, 85)
        Me.clientpnl.TabIndex = 7
        '
        'txt_project_management_id
        '
        Me.txt_project_management_id._Text = ""
        Me.txt_project_management_id.AllowNegative = False
        Me.txt_project_management_id.AlwaysDisable = False
        Me.txt_project_management_id.AlwaysEnable = False
        Me.txt_project_management_id.BackColor = System.Drawing.Color.White
        Me.txt_project_management_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_management_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_management_id.DataSource = ""
        Me.txt_project_management_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_management_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_management_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_management_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_management_id.ispk = False
        Me.txt_project_management_id.Location = New System.Drawing.Point(278, 6)
        Me.txt_project_management_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_management_id.MultiLine = False
        Me.txt_project_management_id.Name = "txt_project_management_id"
        Me.txt_project_management_id.NoClear = False
        Me.txt_project_management_id.NumberFormat = "@"
        Me.txt_project_management_id.Required = False
        Me.txt_project_management_id.RowData = Nothing
        Me.txt_project_management_id.SelectionLength = 0
        Me.txt_project_management_id.SelectionStart = 0
        Me.txt_project_management_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_project_management_id.TabIndex = 8
        Me.txt_project_management_id.TableData = Nothing
        Me.txt_project_management_id.TextSource = "project_management_id"
        Me.txt_project_management_id.UseSystemPasswordChar = False
        Me.txt_project_management_id.Value = ""
        Me.txt_project_management_id.ValueSource = ""
        Me.txt_project_management_id.Visible = False
        '
        'txt_general_name
        '
        Me.txt_general_name._Text = ""
        Me.txt_general_name.AllowNegative = False
        Me.txt_general_name.AlwaysDisable = False
        Me.txt_general_name.AlwaysEnable = False
        Me.txt_general_name.BackColor = System.Drawing.Color.White
        Me.txt_general_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_name.DataSource = ""
        Me.txt_general_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_name.Enabled = False
        Me.txt_general_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_name.ispk = False
        Me.txt_general_name.Location = New System.Drawing.Point(261, 58)
        Me.txt_general_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_name.MultiLine = False
        Me.txt_general_name.Name = "txt_general_name"
        Me.txt_general_name.NoClear = False
        Me.txt_general_name.NumberFormat = "@"
        Me.txt_general_name.Required = False
        Me.txt_general_name.RowData = Nothing
        Me.txt_general_name.SelectionLength = 0
        Me.txt_general_name.SelectionStart = 0
        Me.txt_general_name.Size = New System.Drawing.Size(462, 20)
        Me.txt_general_name.TabIndex = 7
        Me.txt_general_name.TableData = Nothing
        Me.txt_general_name.TextSource = "general_name"
        Me.txt_general_name.UseSystemPasswordChar = False
        Me.txt_general_name.Value = ""
        Me.txt_general_name.ValueSource = ""
        '
        'txt_general_id
        '
        Me.txt_general_id._Text = ""
        Me.txt_general_id.AllowNegative = False
        Me.txt_general_id.AlwaysDisable = False
        Me.txt_general_id.AlwaysEnable = False
        Me.txt_general_id.BackColor = System.Drawing.Color.White
        Me.txt_general_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.DataSource = ""
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.ispk = False
        Me.txt_general_id.Location = New System.Drawing.Point(135, 58)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_general_id.TabIndex = 6
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.TextSource = "general_code"
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = "general_id"
        '
        'txt_pm_year
        '
        Me.txt_pm_year.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bs, "pm_year", True))
        Me.txt_pm_year.Location = New System.Drawing.Point(135, 6)
        Me.txt_pm_year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_pm_year.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_pm_year.Name = "txt_pm_year"
        Me.txt_pm_year.Size = New System.Drawing.Size(120, 20)
        Me.txt_pm_year.TabIndex = 1
        Me.txt_pm_year.Tag = "pm_year"
        Me.txt_pm_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_pm_year.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'bs
        '
        Me.bs.DataMember = "trans_project_management"
        Me.bs.DataSource = Me.ds
        '
        'txt_project_name
        '
        Me.txt_project_name._Text = ""
        Me.txt_project_name.AllowNegative = False
        Me.txt_project_name.AlwaysDisable = False
        Me.txt_project_name.AlwaysEnable = False
        Me.txt_project_name.BackColor = System.Drawing.Color.White
        Me.txt_project_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_name.DataSource = ""
        Me.txt_project_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_name.Enabled = False
        Me.txt_project_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_name.ispk = False
        Me.txt_project_name.Location = New System.Drawing.Point(261, 32)
        Me.txt_project_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_name.MultiLine = False
        Me.txt_project_name.Name = "txt_project_name"
        Me.txt_project_name.NoClear = False
        Me.txt_project_name.NumberFormat = "@"
        Me.txt_project_name.Required = False
        Me.txt_project_name.RowData = Nothing
        Me.txt_project_name.SelectionLength = 0
        Me.txt_project_name.SelectionStart = 0
        Me.txt_project_name.Size = New System.Drawing.Size(462, 20)
        Me.txt_project_name.TabIndex = 4
        Me.txt_project_name.TableData = Nothing
        Me.txt_project_name.TextSource = "project_name"
        Me.txt_project_name.UseSystemPasswordChar = False
        Me.txt_project_name.Value = ""
        Me.txt_project_name.ValueSource = ""
        '
        'txt_project_id
        '
        Me.txt_project_id._Text = ""
        Me.txt_project_id.AllowNegative = False
        Me.txt_project_id.AlwaysDisable = False
        Me.txt_project_id.AlwaysEnable = False
        Me.txt_project_id.BackColor = System.Drawing.Color.White
        Me.txt_project_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_id.DataSource = ""
        Me.txt_project_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_id.ispk = False
        Me.txt_project_id.Location = New System.Drawing.Point(135, 32)
        Me.txt_project_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_id.MultiLine = False
        Me.txt_project_id.Name = "txt_project_id"
        Me.txt_project_id.NoClear = False
        Me.txt_project_id.NumberFormat = "@"
        Me.txt_project_id.Required = False
        Me.txt_project_id.RowData = Nothing
        Me.txt_project_id.SelectionLength = 0
        Me.txt_project_id.SelectionStart = 0
        Me.txt_project_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_project_id.TabIndex = 2
        Me.txt_project_id.TableData = Nothing
        Me.txt_project_id.TextSource = "project_code"
        Me.txt_project_id.UseSystemPasswordChar = False
        Me.txt_project_id.Value = ""
        Me.txt_project_id.ValueSource = "project_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PROJECT CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CLIENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "YEAR REFERENCE"
        '
        'transpnl
        '
        Me.transpnl.Controls.Add(Me.txt_department_id)
        Me.transpnl.Controls.Add(Me.txt_project_management_det_id)
        Me.transpnl.Controls.Add(Me.txt_insured_with)
        Me.transpnl.Controls.Add(Me.Label18)
        Me.transpnl.Controls.Add(Me.txt_collected_amount)
        Me.transpnl.Controls.Add(Me.Label17)
        Me.transpnl.Controls.Add(Me.txt_billed_amount)
        Me.transpnl.Controls.Add(Me.Label16)
        Me.transpnl.Controls.Add(Me.txt_accomplishment_amount)
        Me.transpnl.Controls.Add(Me.Label15)
        Me.transpnl.Controls.Add(Me.txt_profit_amount)
        Me.transpnl.Controls.Add(Me.Label14)
        Me.transpnl.Controls.Add(Me.txt_contract_cost)
        Me.transpnl.Controls.Add(Me.Label12)
        Me.transpnl.Controls.Add(Me.txt_contract_amount_based)
        Me.transpnl.Controls.Add(Me.txt_contract_amount)
        Me.transpnl.Controls.Add(Me.Label11)
        Me.transpnl.Controls.Add(Me.txt_date_to)
        Me.transpnl.Controls.Add(Me.Label13)
        Me.transpnl.Controls.Add(Me.txt_based_rate)
        Me.transpnl.Controls.Add(Me.txt_date_from)
        Me.transpnl.Controls.Add(Me.txt_exchange_rate)
        Me.transpnl.Controls.Add(Me.txt_currency_id)
        Me.transpnl.Controls.Add(Me.txt_project_name_det)
        Me.transpnl.Controls.Add(Me.txt_po_no)
        Me.transpnl.Controls.Add(Me.Label10)
        Me.transpnl.Controls.Add(Me.Label9)
        Me.transpnl.Controls.Add(Me.Label8)
        Me.transpnl.Controls.Add(Me.Label7)
        Me.transpnl.Controls.Add(Me.GroupBox1)
        Me.transpnl.Controls.Add(Me.txt_ispriordate)
        Me.transpnl.Enabled = False
        Me.transpnl.Location = New System.Drawing.Point(12, 382)
        Me.transpnl.Name = "transpnl"
        Me.transpnl.Size = New System.Drawing.Size(776, 206)
        Me.transpnl.TabIndex = 1
        '
        'txt_department_id
        '
        Me.txt_department_id._Text = ""
        Me.txt_department_id.AllowNegative = False
        Me.txt_department_id.AlwaysDisable = False
        Me.txt_department_id.AlwaysEnable = False
        Me.txt_department_id.BackColor = System.Drawing.Color.White
        Me.txt_department_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_department_id.DataSource = ""
        Me.txt_department_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_department_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_department_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_department_id.ispk = False
        Me.txt_department_id.Location = New System.Drawing.Point(135, 119)
        Me.txt_department_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_department_id.MultiLine = False
        Me.txt_department_id.Name = "txt_department_id"
        Me.txt_department_id.NoClear = False
        Me.txt_department_id.NumberFormat = "@"
        Me.txt_department_id.Required = False
        Me.txt_department_id.RowData = Nothing
        Me.txt_department_id.SelectionLength = 0
        Me.txt_department_id.SelectionStart = 0
        Me.txt_department_id.Size = New System.Drawing.Size(252, 20)
        Me.txt_department_id.TabIndex = 30
        Me.txt_department_id.TableData = Nothing
        Me.txt_department_id.TextSource = "department_code"
        Me.txt_department_id.UseSystemPasswordChar = False
        Me.txt_department_id.Value = ""
        Me.txt_department_id.ValueSource = "department_id"
        '
        'txt_project_management_det_id
        '
        Me.txt_project_management_det_id._Text = ""
        Me.txt_project_management_det_id.AllowNegative = False
        Me.txt_project_management_det_id.AlwaysDisable = False
        Me.txt_project_management_det_id.AlwaysEnable = False
        Me.txt_project_management_det_id.BackColor = System.Drawing.Color.White
        Me.txt_project_management_det_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_management_det_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_management_det_id.DataSource = ""
        Me.txt_project_management_det_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_management_det_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_management_det_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_management_det_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_management_det_id.ispk = False
        Me.txt_project_management_det_id.Location = New System.Drawing.Point(125, 6)
        Me.txt_project_management_det_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_management_det_id.MultiLine = False
        Me.txt_project_management_det_id.Name = "txt_project_management_det_id"
        Me.txt_project_management_det_id.NoClear = False
        Me.txt_project_management_det_id.NumberFormat = "@"
        Me.txt_project_management_det_id.Required = False
        Me.txt_project_management_det_id.RowData = Nothing
        Me.txt_project_management_det_id.SelectionLength = 0
        Me.txt_project_management_det_id.SelectionStart = 0
        Me.txt_project_management_det_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_project_management_det_id.TabIndex = 29
        Me.txt_project_management_det_id.TableData = Nothing
        Me.txt_project_management_det_id.TextSource = "project_management_det_id"
        Me.txt_project_management_det_id.UseSystemPasswordChar = False
        Me.txt_project_management_det_id.Value = ""
        Me.txt_project_management_det_id.ValueSource = ""
        Me.txt_project_management_det_id.Visible = False
        '
        'txt_insured_with
        '
        Me.txt_insured_with.Location = New System.Drawing.Point(518, 165)
        Me.txt_insured_with.Name = "txt_insured_with"
        Me.txt_insured_with.Size = New System.Drawing.Size(255, 20)
        Me.txt_insured_with.TabIndex = 19
        Me.txt_insured_with.Tag = "insured_with"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(445, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Insured With"
        '
        'txt_collected_amount
        '
        Me.txt_collected_amount.Location = New System.Drawing.Point(677, 139)
        Me.txt_collected_amount.Name = "txt_collected_amount"
        Me.txt_collected_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_collected_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_collected_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_collected_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_collected_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_collected_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_collected_amount.Properties.Mask.EditMask = "n2"
        Me.txt_collected_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_collected_amount.Size = New System.Drawing.Size(96, 20)
        Me.txt_collected_amount.TabIndex = 18
        Me.txt_collected_amount.Tag = "collected_amount"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(620, 142)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Collected"
        '
        'txt_billed_amount
        '
        Me.txt_billed_amount.Location = New System.Drawing.Point(518, 139)
        Me.txt_billed_amount.Name = "txt_billed_amount"
        Me.txt_billed_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_billed_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_billed_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_billed_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_billed_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_billed_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_billed_amount.Properties.Mask.EditMask = "n2"
        Me.txt_billed_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_billed_amount.Size = New System.Drawing.Size(96, 20)
        Me.txt_billed_amount.TabIndex = 17
        Me.txt_billed_amount.Tag = "billed_amount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(480, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Billed"
        '
        'txt_accomplishment_amount
        '
        Me.txt_accomplishment_amount.Location = New System.Drawing.Point(518, 113)
        Me.txt_accomplishment_amount.Name = "txt_accomplishment_amount"
        Me.txt_accomplishment_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_accomplishment_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_accomplishment_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_accomplishment_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_accomplishment_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_accomplishment_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_accomplishment_amount.Properties.Mask.EditMask = "n2"
        Me.txt_accomplishment_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_accomplishment_amount.Properties.MaxLength = 3
        Me.txt_accomplishment_amount.Properties.ReadOnly = True
        Me.txt_accomplishment_amount.Size = New System.Drawing.Size(255, 20)
        Me.txt_accomplishment_amount.TabIndex = 16
        Me.txt_accomplishment_amount.Tag = "accomplishment_amount"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(428, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Accomplishment"
        '
        'txt_profit_amount
        '
        Me.txt_profit_amount.Location = New System.Drawing.Point(518, 87)
        Me.txt_profit_amount.Name = "txt_profit_amount"
        Me.txt_profit_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_profit_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_profit_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_profit_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_profit_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_profit_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_profit_amount.Properties.Mask.EditMask = "n2"
        Me.txt_profit_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_profit_amount.Properties.ReadOnly = True
        Me.txt_profit_amount.Size = New System.Drawing.Size(255, 20)
        Me.txt_profit_amount.TabIndex = 15
        Me.txt_profit_amount.Tag = "profit_amount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(481, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Profit"
        '
        'txt_contract_cost
        '
        Me.txt_contract_cost.Location = New System.Drawing.Point(518, 61)
        Me.txt_contract_cost.Name = "txt_contract_cost"
        Me.txt_contract_cost.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_contract_cost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_contract_cost.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_contract_cost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_cost.Properties.EditFormat.FormatString = "n2"
        Me.txt_contract_cost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_cost.Properties.Mask.EditMask = "n2"
        Me.txt_contract_cost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_contract_cost.Size = New System.Drawing.Size(255, 20)
        Me.txt_contract_cost.TabIndex = 14
        Me.txt_contract_cost.Tag = "contract_cost"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(441, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Contract Cost"
        '
        'txt_contract_amount_based
        '
        Me.txt_contract_amount_based.Location = New System.Drawing.Point(620, 35)
        Me.txt_contract_amount_based.Name = "txt_contract_amount_based"
        Me.txt_contract_amount_based.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_contract_amount_based.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_contract_amount_based.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_contract_amount_based.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_amount_based.Properties.EditFormat.FormatString = "n2"
        Me.txt_contract_amount_based.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_amount_based.Properties.Mask.EditMask = "n2"
        Me.txt_contract_amount_based.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_contract_amount_based.Properties.ReadOnly = True
        Me.txt_contract_amount_based.Size = New System.Drawing.Size(153, 20)
        Me.txt_contract_amount_based.TabIndex = 13
        Me.txt_contract_amount_based.Tag = "contract_amount"
        '
        'txt_contract_amount
        '
        Me.txt_contract_amount.Location = New System.Drawing.Point(518, 35)
        Me.txt_contract_amount.Name = "txt_contract_amount"
        Me.txt_contract_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_contract_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_contract_amount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_contract_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_amount.Properties.EditFormat.FormatString = "n2"
        Me.txt_contract_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_contract_amount.Properties.Mask.EditMask = "n2"
        Me.txt_contract_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_contract_amount.Size = New System.Drawing.Size(96, 20)
        Me.txt_contract_amount.TabIndex = 12
        Me.txt_contract_amount.Tag = "contract_amount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(426, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Contract Amount"
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(620, 9)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(96, 20)
        Me.txt_date_to.TabIndex = 11
        Me.txt_date_to.Tag = "date_to"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(442, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Const. Period"
        '
        'txt_based_rate
        '
        Me.txt_based_rate.Location = New System.Drawing.Point(313, 67)
        Me.txt_based_rate.Name = "txt_based_rate"
        Me.txt_based_rate.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_based_rate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_based_rate.Size = New System.Drawing.Size(50, 20)
        Me.txt_based_rate.TabIndex = 6
        Me.txt_based_rate.Tag = "based_rate"
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(518, 9)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(96, 20)
        Me.txt_date_from.TabIndex = 10
        Me.txt_date_from.Tag = "date_from"
        '
        'txt_exchange_rate
        '
        Me.txt_exchange_rate.Location = New System.Drawing.Point(261, 67)
        Me.txt_exchange_rate.Name = "txt_exchange_rate"
        Me.txt_exchange_rate.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_exchange_rate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_exchange_rate.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_exchange_rate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_exchange_rate.Properties.EditFormat.FormatString = "n2"
        Me.txt_exchange_rate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_exchange_rate.Properties.Mask.EditMask = "n2"
        Me.txt_exchange_rate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_exchange_rate.Size = New System.Drawing.Size(50, 20)
        Me.txt_exchange_rate.TabIndex = 5
        Me.txt_exchange_rate.Tag = "exchange_rate"
        '
        'txt_currency_id
        '
        Me.txt_currency_id._Text = ""
        Me.txt_currency_id.AllowNegative = False
        Me.txt_currency_id.AlwaysDisable = False
        Me.txt_currency_id.AlwaysEnable = False
        Me.txt_currency_id.BackColor = System.Drawing.Color.White
        Me.txt_currency_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency_id.DataSource = ""
        Me.txt_currency_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency_id.ispk = False
        Me.txt_currency_id.Location = New System.Drawing.Point(135, 67)
        Me.txt_currency_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency_id.MultiLine = False
        Me.txt_currency_id.Name = "txt_currency_id"
        Me.txt_currency_id.NoClear = False
        Me.txt_currency_id.NumberFormat = "@"
        Me.txt_currency_id.Required = False
        Me.txt_currency_id.RowData = Nothing
        Me.txt_currency_id.SelectionLength = 0
        Me.txt_currency_id.SelectionStart = 0
        Me.txt_currency_id.Size = New System.Drawing.Size(120, 20)
        Me.txt_currency_id.TabIndex = 4
        Me.txt_currency_id.TableData = Nothing
        Me.txt_currency_id.TextSource = "currency_code"
        Me.txt_currency_id.UseSystemPasswordChar = False
        Me.txt_currency_id.Value = ""
        Me.txt_currency_id.ValueSource = "currency_id"
        '
        'txt_project_name_det
        '
        Me.txt_project_name_det.Location = New System.Drawing.Point(135, 145)
        Me.txt_project_name_det.Multiline = True
        Me.txt_project_name_det.Name = "txt_project_name_det"
        Me.txt_project_name_det.Size = New System.Drawing.Size(252, 40)
        Me.txt_project_name_det.TabIndex = 9
        Me.txt_project_name_det.Tag = "project_name"
        '
        'txt_po_no
        '
        Me.txt_po_no.Location = New System.Drawing.Point(135, 93)
        Me.txt_po_no.Name = "txt_po_no"
        Me.txt_po_no.Size = New System.Drawing.Size(120, 20)
        Me.txt_po_no.TabIndex = 7
        Me.txt_po_no.Tag = "po_no"
        Me.txt_po_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "PROJECT NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DEPARTMENT CODE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "P.O NO."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Currency"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_contract_date)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_trans_date)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 37)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "container"
        Me.GroupBox1.Text = "DATE"
        '
        'txt_contract_date
        '
        Me.txt_contract_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_contract_date.Location = New System.Drawing.Point(275, 12)
        Me.txt_contract_date.Name = "txt_contract_date"
        Me.txt_contract_date.Size = New System.Drawing.Size(96, 20)
        Me.txt_contract_date.TabIndex = 2
        Me.txt_contract_date.Tag = "contract_date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Transaction"
        '
        'txt_trans_date
        '
        Me.txt_trans_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_trans_date.Location = New System.Drawing.Point(94, 12)
        Me.txt_trans_date.Name = "txt_trans_date"
        Me.txt_trans_date.Size = New System.Drawing.Size(96, 20)
        Me.txt_trans_date.TabIndex = 1
        Me.txt_trans_date.Tag = "trans_date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(203, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Contract"
        '
        'txt_ispriordate
        '
        Me.txt_ispriordate.AutoSize = True
        Me.txt_ispriordate.Location = New System.Drawing.Point(27, 6)
        Me.txt_ispriordate.Name = "txt_ispriordate"
        Me.txt_ispriordate.Size = New System.Drawing.Size(92, 17)
        Me.txt_ispriordate.TabIndex = 1
        Me.txt_ispriordate.Tag = "isPriorDate"
        Me.txt_ispriordate.Text = "PRIOR YEAR"
        Me.txt_ispriordate.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(360, 66)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(80, 28)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "F7 Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(443, 66)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(80, 28)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "F8 Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(277, 66)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "F6 Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.Color.White
        Me.btninsert.Location = New System.Drawing.Point(28, 349)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(80, 27)
        Me.btninsert.TabIndex = 10
        Me.btninsert.Text = "&Add"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ForeColor = System.Drawing.Color.White
        Me.btnremove.Location = New System.Drawing.Point(194, 349)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(80, 27)
        Me.btnremove.TabIndex = 10
        Me.btnremove.Text = "D&elete"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(112, 349)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(80, 27)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "&Edit"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Green
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(28, 349)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 27)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Red
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(111, 349)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(80, 27)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.AutoGenerateColumns = False
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.department_id, Me.department_name, Me.project_management_det_id, Me.ProjectmanagementidDataGridViewTextBoxColumn, Me.IsPriorDateDataGridViewCheckBoxColumn, Me.trans_date, Me.contract_date, Me.CurrencyidDataGridViewTextBoxColumn, Me.ExchangerateDataGridViewTextBoxColumn, Me.BasedrateDataGridViewTextBoxColumn, Me.po_no, Me.department_code, Me.project_name, Me.date_from, Me.date_to, Me.ContractamountDataGridViewTextBoxColumn, Me.ContractamountbasedDataGridViewTextBoxColumn, Me.ContractcostDataGridViewTextBoxColumn, Me.ContractcostbasedDataGridViewTextBoxColumn, Me.ProfitamountDataGridViewTextBoxColumn, Me.ProfitamountbasedDataGridViewTextBoxColumn, Me.AccomplishmentamountDataGridViewTextBoxColumn, Me.AccomplishmentamountbasedDataGridViewTextBoxColumn, Me.BilledamountDataGridViewTextBoxColumn, Me.BilledamountbasedDataGridViewTextBoxColumn, Me.CollectedamountDataGridViewTextBoxColumn, Me.CollectedamountbasedDataGridViewTextBoxColumn, Me.InsuredwithDataGridViewTextBoxColumn, Me.DeletedDataGridViewCheckBoxColumn, Me.CurrencycodeDataGridViewTextBoxColumn, Me.CurrencynameDataGridViewTextBoxColumn})
        Me.dgview.DataMember = "trans_project_management_det"
        Me.dgview.DataSource = Me.ds
        Me.dgview.Location = New System.Drawing.Point(12, 190)
        Me.dgview.MultiSelect = False
        Me.dgview.Name = "dgview"
        Me.dgview.RowHeadersVisible = False
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(776, 153)
        Me.dgview.TabIndex = 333
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'department_id
        '
        Me.department_id.DataPropertyName = "department_id"
        Me.department_id.HeaderText = "department_id"
        Me.department_id.Name = "department_id"
        Me.department_id.Visible = False
        '
        'department_name
        '
        Me.department_name.DataPropertyName = "department_name"
        Me.department_name.HeaderText = "department_name"
        Me.department_name.Name = "department_name"
        Me.department_name.Visible = False
        '
        'project_management_det_id
        '
        Me.project_management_det_id.DataPropertyName = "project_management_det_id"
        Me.project_management_det_id.HeaderText = "project_management_det_id"
        Me.project_management_det_id.Name = "project_management_det_id"
        Me.project_management_det_id.Visible = False
        '
        'ProjectmanagementidDataGridViewTextBoxColumn
        '
        Me.ProjectmanagementidDataGridViewTextBoxColumn.DataPropertyName = "project_management_id"
        Me.ProjectmanagementidDataGridViewTextBoxColumn.HeaderText = "project_management_id"
        Me.ProjectmanagementidDataGridViewTextBoxColumn.Name = "ProjectmanagementidDataGridViewTextBoxColumn"
        Me.ProjectmanagementidDataGridViewTextBoxColumn.Visible = False
        '
        'IsPriorDateDataGridViewCheckBoxColumn
        '
        Me.IsPriorDateDataGridViewCheckBoxColumn.DataPropertyName = "isPriorDate"
        Me.IsPriorDateDataGridViewCheckBoxColumn.HeaderText = "isPriorDate"
        Me.IsPriorDateDataGridViewCheckBoxColumn.Name = "IsPriorDateDataGridViewCheckBoxColumn"
        Me.IsPriorDateDataGridViewCheckBoxColumn.Visible = False
        '
        'trans_date
        '
        Me.trans_date.DataPropertyName = "trans_date"
        Me.trans_date.HeaderText = "TRANSACTION DATE"
        Me.trans_date.Name = "trans_date"
        Me.trans_date.ReadOnly = True
        '
        'contract_date
        '
        Me.contract_date.DataPropertyName = "contract_date"
        Me.contract_date.HeaderText = "CONTRACT DATE"
        Me.contract_date.Name = "contract_date"
        Me.contract_date.ReadOnly = True
        '
        'CurrencyidDataGridViewTextBoxColumn
        '
        Me.CurrencyidDataGridViewTextBoxColumn.DataPropertyName = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.HeaderText = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.Name = "CurrencyidDataGridViewTextBoxColumn"
        Me.CurrencyidDataGridViewTextBoxColumn.Visible = False
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
        'po_no
        '
        Me.po_no.DataPropertyName = "po_no"
        Me.po_no.HeaderText = "P.O. NO."
        Me.po_no.Name = "po_no"
        Me.po_no.ReadOnly = True
        '
        'department_code
        '
        Me.department_code.DataPropertyName = "department_code"
        Me.department_code.HeaderText = "DEPARTMENT CODE"
        Me.department_code.Name = "department_code"
        Me.department_code.ReadOnly = True
        '
        'project_name
        '
        Me.project_name.DataPropertyName = "project_name"
        Me.project_name.HeaderText = "PROJECT NAME"
        Me.project_name.Name = "project_name"
        Me.project_name.ReadOnly = True
        '
        'date_from
        '
        Me.date_from.DataPropertyName = "date_from"
        Me.date_from.HeaderText = "CONSTRACTION FROM"
        Me.date_from.Name = "date_from"
        Me.date_from.ReadOnly = True
        '
        'date_to
        '
        Me.date_to.DataPropertyName = "date_to"
        Me.date_to.HeaderText = "CONSTRACTION TO"
        Me.date_to.Name = "date_to"
        Me.date_to.ReadOnly = True
        '
        'ContractamountDataGridViewTextBoxColumn
        '
        Me.ContractamountDataGridViewTextBoxColumn.DataPropertyName = "contract_amount"
        Me.ContractamountDataGridViewTextBoxColumn.HeaderText = "contract_amount"
        Me.ContractamountDataGridViewTextBoxColumn.Name = "ContractamountDataGridViewTextBoxColumn"
        Me.ContractamountDataGridViewTextBoxColumn.Visible = False
        '
        'ContractamountbasedDataGridViewTextBoxColumn
        '
        Me.ContractamountbasedDataGridViewTextBoxColumn.DataPropertyName = "contract_amount_based"
        Me.ContractamountbasedDataGridViewTextBoxColumn.HeaderText = "contract_amount_based"
        Me.ContractamountbasedDataGridViewTextBoxColumn.Name = "ContractamountbasedDataGridViewTextBoxColumn"
        Me.ContractamountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'ContractcostDataGridViewTextBoxColumn
        '
        Me.ContractcostDataGridViewTextBoxColumn.DataPropertyName = "contract_cost"
        Me.ContractcostDataGridViewTextBoxColumn.HeaderText = "contract_cost"
        Me.ContractcostDataGridViewTextBoxColumn.Name = "ContractcostDataGridViewTextBoxColumn"
        Me.ContractcostDataGridViewTextBoxColumn.Visible = False
        '
        'ContractcostbasedDataGridViewTextBoxColumn
        '
        Me.ContractcostbasedDataGridViewTextBoxColumn.DataPropertyName = "contract_cost_based"
        Me.ContractcostbasedDataGridViewTextBoxColumn.HeaderText = "contract_cost_based"
        Me.ContractcostbasedDataGridViewTextBoxColumn.Name = "ContractcostbasedDataGridViewTextBoxColumn"
        Me.ContractcostbasedDataGridViewTextBoxColumn.Visible = False
        '
        'ProfitamountDataGridViewTextBoxColumn
        '
        Me.ProfitamountDataGridViewTextBoxColumn.DataPropertyName = "profit_amount"
        Me.ProfitamountDataGridViewTextBoxColumn.HeaderText = "profit_amount"
        Me.ProfitamountDataGridViewTextBoxColumn.Name = "ProfitamountDataGridViewTextBoxColumn"
        Me.ProfitamountDataGridViewTextBoxColumn.Visible = False
        '
        'ProfitamountbasedDataGridViewTextBoxColumn
        '
        Me.ProfitamountbasedDataGridViewTextBoxColumn.DataPropertyName = "profit_amount_based"
        Me.ProfitamountbasedDataGridViewTextBoxColumn.HeaderText = "profit_amount_based"
        Me.ProfitamountbasedDataGridViewTextBoxColumn.Name = "ProfitamountbasedDataGridViewTextBoxColumn"
        Me.ProfitamountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'AccomplishmentamountDataGridViewTextBoxColumn
        '
        Me.AccomplishmentamountDataGridViewTextBoxColumn.DataPropertyName = "accomplishment_amount"
        Me.AccomplishmentamountDataGridViewTextBoxColumn.HeaderText = "accomplishment_amount"
        Me.AccomplishmentamountDataGridViewTextBoxColumn.Name = "AccomplishmentamountDataGridViewTextBoxColumn"
        Me.AccomplishmentamountDataGridViewTextBoxColumn.Visible = False
        '
        'AccomplishmentamountbasedDataGridViewTextBoxColumn
        '
        Me.AccomplishmentamountbasedDataGridViewTextBoxColumn.DataPropertyName = "accomplishment_amount_based"
        Me.AccomplishmentamountbasedDataGridViewTextBoxColumn.HeaderText = "accomplishment_amount_based"
        Me.AccomplishmentamountbasedDataGridViewTextBoxColumn.Name = "AccomplishmentamountbasedDataGridViewTextBoxColumn"
        Me.AccomplishmentamountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'BilledamountDataGridViewTextBoxColumn
        '
        Me.BilledamountDataGridViewTextBoxColumn.DataPropertyName = "billed_amount"
        Me.BilledamountDataGridViewTextBoxColumn.HeaderText = "BILLED"
        Me.BilledamountDataGridViewTextBoxColumn.Name = "BilledamountDataGridViewTextBoxColumn"
        Me.BilledamountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BilledamountbasedDataGridViewTextBoxColumn
        '
        Me.BilledamountbasedDataGridViewTextBoxColumn.DataPropertyName = "billed_amount_based"
        Me.BilledamountbasedDataGridViewTextBoxColumn.HeaderText = "billed_amount_based"
        Me.BilledamountbasedDataGridViewTextBoxColumn.Name = "BilledamountbasedDataGridViewTextBoxColumn"
        Me.BilledamountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'CollectedamountDataGridViewTextBoxColumn
        '
        Me.CollectedamountDataGridViewTextBoxColumn.DataPropertyName = "collected_amount"
        Me.CollectedamountDataGridViewTextBoxColumn.HeaderText = "COLLECTED"
        Me.CollectedamountDataGridViewTextBoxColumn.Name = "CollectedamountDataGridViewTextBoxColumn"
        Me.CollectedamountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollectedamountbasedDataGridViewTextBoxColumn
        '
        Me.CollectedamountbasedDataGridViewTextBoxColumn.DataPropertyName = "collected_amount_based"
        Me.CollectedamountbasedDataGridViewTextBoxColumn.HeaderText = "collected_amount_based"
        Me.CollectedamountbasedDataGridViewTextBoxColumn.Name = "CollectedamountbasedDataGridViewTextBoxColumn"
        Me.CollectedamountbasedDataGridViewTextBoxColumn.Visible = False
        '
        'InsuredwithDataGridViewTextBoxColumn
        '
        Me.InsuredwithDataGridViewTextBoxColumn.DataPropertyName = "insured_with"
        Me.InsuredwithDataGridViewTextBoxColumn.HeaderText = "insured_with"
        Me.InsuredwithDataGridViewTextBoxColumn.Name = "InsuredwithDataGridViewTextBoxColumn"
        Me.InsuredwithDataGridViewTextBoxColumn.Visible = False
        '
        'DeletedDataGridViewCheckBoxColumn
        '
        Me.DeletedDataGridViewCheckBoxColumn.DataPropertyName = "deleted"
        Me.DeletedDataGridViewCheckBoxColumn.HeaderText = "deleted"
        Me.DeletedDataGridViewCheckBoxColumn.Name = "DeletedDataGridViewCheckBoxColumn"
        Me.DeletedDataGridViewCheckBoxColumn.Visible = False
        '
        'CurrencycodeDataGridViewTextBoxColumn
        '
        Me.CurrencycodeDataGridViewTextBoxColumn.DataPropertyName = "currency_code"
        Me.CurrencycodeDataGridViewTextBoxColumn.HeaderText = "currency_code"
        Me.CurrencycodeDataGridViewTextBoxColumn.Name = "CurrencycodeDataGridViewTextBoxColumn"
        Me.CurrencycodeDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencynameDataGridViewTextBoxColumn
        '
        Me.CurrencynameDataGridViewTextBoxColumn.DataPropertyName = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.HeaderText = "currency_name"
        Me.CurrencynameDataGridViewTextBoxColumn.Name = "CurrencynameDataGridViewTextBoxColumn"
        Me.CurrencynameDataGridViewTextBoxColumn.Visible = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(800, 30)
        Me.Myformheader1.TabIndex = 0
        '
        'Project_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.transpnl)
        Me.Controls.Add(Me.clientpnl)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Project_management"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Management"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_project_management, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_project_management_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.clientpnl.ResumeLayout(False)
        Me.clientpnl.PerformLayout()
        CType(Me.txt_pm_year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transpnl.ResumeLayout(False)
        Me.transpnl.PerformLayout()
        CType(Me.txt_collected_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_billed_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_accomplishment_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_profit_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contract_cost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contract_amount_based.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contract_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_based_rate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_exchange_rate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnPrint As Windows.Forms.Button
    Friend WithEvents btnEdit As Windows.Forms.Button
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents btnNotSave As Windows.Forms.Button
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents clientpnl As Windows.Forms.Panel
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txt_pm_year As Windows.Forms.NumericUpDown
    Friend WithEvents txt_project_name As user_control.textbox
    Friend WithEvents transpnl As Windows.Forms.Panel
    Friend WithEvents btnPrevious As Windows.Forms.Button
    Friend WithEvents btnNext As Windows.Forms.Button
    Friend WithEvents btnSearch As Windows.Forms.Button
    Friend WithEvents btninsert As Windows.Forms.Button
    Friend WithEvents btnremove As Windows.Forms.Button
    Friend WithEvents btnupdate As Windows.Forms.Button
    Friend WithEvents txt_project_id As user_control.textbox
    Friend WithEvents txt_ispriordate As Windows.Forms.CheckBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txt_contract_date As Windows.Forms.DateTimePicker
    Friend WithEvents txt_trans_date As Windows.Forms.DateTimePicker
    Friend WithEvents txt_po_no As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents txt_date_to As Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txt_date_from As Windows.Forms.DateTimePicker
    Friend WithEvents txt_project_name_det As Windows.Forms.TextBox
    Friend WithEvents txt_contract_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_based_rate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_exchange_rate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_currency_id As user_control.textbox
    Friend WithEvents txt_insured_with As Windows.Forms.TextBox
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents txt_collected_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txt_billed_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents txt_accomplishment_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txt_profit_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txt_contract_cost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txt_contract_amount_based As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOk As Windows.Forms.Button
    Friend WithEvents btncancel As Windows.Forms.Button
    Friend WithEvents txt_general_name As user_control.textbox
    Friend WithEvents txt_general_id As user_control.textbox
    Friend WithEvents txt_project_management_id As user_control.textbox
    Friend WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents ds As DataSet
    Friend WithEvents trans_project_management As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
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
    Friend WithEvents txt_project_management_det_id As user_control.textbox
    Friend WithEvents dgview As Windows.Forms.DataGridView
    Friend WithEvents DataColumn35 As DataColumn
    Friend WithEvents DataColumn36 As DataColumn
    Friend WithEvents DataColumn37 As DataColumn
    Friend WithEvents DataColumn38 As DataColumn
    Friend WithEvents DataColumn39 As DataColumn
    Friend WithEvents DataColumn40 As DataColumn
    Friend WithEvents txt_department_id As user_control.textbox
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents department_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_management_det_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectmanagementidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsPriorDateDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contract_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExchangerateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasedrateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents po_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_from As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_to As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractcostDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractcostbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfitamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfitamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccomplishmentamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccomplishmentamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilledamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilledamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollectedamountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollectedamountbasedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsuredwithDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeletedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CurrencycodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencynameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
End Class
