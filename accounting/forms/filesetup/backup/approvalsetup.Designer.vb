<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class approvalsetup
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(approvalsetup))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.approval_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stage_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.sys_erp_approval = New System.Data.DataTable()
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
        Me.sys_erp_approval_user = New System.Data.DataTable()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgSub = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.approval_user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelSub = New System.Windows.Forms.Panel()
        Me.txt_user_fullname = New user_control.textbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_user_id = New user_control.textbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_order_no = New user_control.textbox()
        Me.txt_approval_order = New System.Windows.Forms.Panel()
        Me.Rdo_button3 = New user_control.rdo_button()
        Me.Rdo_button4 = New user_control.rdo_button()
        Me.txt_approval_user_id = New user_control.textbox()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_main_order_no = New user_control.textbox()
        Me.txt_main_approval_order = New System.Windows.Forms.Panel()
        Me.Rdo_button2 = New user_control.rdo_button()
        Me.Rdo_button1 = New user_control.rdo_button()
        Me.txt_stage_name = New user_control.textbox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_stage_id = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_approval_id = New user_control.textbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearch = New user_control.textbox()
        Me.border1 = New accounting.borderedlabel()
        Me.lblModule = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sys_erp_approval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sys_erp_approval_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSub.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txt_approval_order.SuspendLayout()
        Me.gboxContainer.SuspendLayout()
        Me.txt_main_approval_order.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 234)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 106
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 234)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 107
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(379, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Search"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(89, 160)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 95
        Me.btnCancel.Tag = "btn-sub-cancel"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Green
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(3, 160)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 24)
        Me.btnOK.TabIndex = 94
        Me.btnOK.Tag = "btn-sub-ok"
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(175, 160)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 93
        Me.btnRemove.Tag = "btn-sub-remove"
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeight = 28
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.approval_id, Me.stage_code, Me.stage_name})
        Me.dgMain.Location = New System.Drawing.Point(20, 72)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(560, 156)
        Me.dgMain.TabIndex = 108
        Me.dgMain.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FalseValue = "False"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.TrueValue = "True"
        Me.sel.Width = 30
        '
        'approval_id
        '
        Me.approval_id.DataPropertyName = "approval_id"
        Me.approval_id.HeaderText = "ID"
        Me.approval_id.Name = "approval_id"
        Me.approval_id.ReadOnly = True
        Me.approval_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.approval_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.approval_id.Visible = False
        '
        'stage_code
        '
        Me.stage_code.DataPropertyName = "stage_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stage_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.stage_code.HeaderText = "Code"
        Me.stage_code.Name = "stage_code"
        Me.stage_code.ReadOnly = True
        Me.stage_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stage_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'stage_name
        '
        Me.stage_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stage_name.DataPropertyName = "stage_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.stage_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.stage_name.HeaderText = "Stage Name"
        Me.stage_name.Name = "stage_name"
        Me.stage_name.ReadOnly = True
        Me.stage_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stage_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.sys_erp_approval, Me.sys_erp_approval_user})
        '
        'sys_erp_approval
        '
        Me.sys_erp_approval.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.sys_erp_approval.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"approval_id"}, True)})
        Me.sys_erp_approval.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn2}
        Me.sys_erp_approval.TableName = "sys_erp_approval"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "approval_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "module_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "module_code"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "module_name"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "stage_id"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "stage_code"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "stage_name"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "label"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "approval_order"
        Me.DataColumn10.DataType = GetType(Boolean)
        Me.DataColumn10.DefaultValue = False
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "order_no"
        Me.DataColumn11.DataType = GetType(Integer)
        Me.DataColumn11.DefaultValue = 0
        '
        'sys_erp_approval_user
        '
        Me.sys_erp_approval_user.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.sys_erp_approval_user.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"approval_user_id"}, True)})
        Me.sys_erp_approval_user.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn13}
        Me.sys_erp_approval_user.TableName = "sys_erp_approval_user"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sel1"
        Me.DataColumn12.DataType = GetType(Boolean)
        Me.DataColumn12.DefaultValue = False
        '
        'DataColumn13
        '
        Me.DataColumn13.AllowDBNull = False
        Me.DataColumn13.ColumnName = "approval_user_id"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "approval_id"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "user_id"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "username"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "user_fullname"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "approval_order"
        Me.DataColumn18.DataType = GetType(Boolean)
        Me.DataColumn18.DefaultValue = False
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "order_no"
        Me.DataColumn19.DataType = GetType(Integer)
        Me.DataColumn19.DefaultValue = 0
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "deleted"
        Me.DataColumn20.DataType = GetType(Boolean)
        Me.DataColumn20.DefaultValue = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(89, 160)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 92
        Me.btnUpdate.Tag = "btn-sub-update"
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(3, 160)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 91
        Me.btnInsert.Tag = "btn-sub-insert"
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(184, 234)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 105
        Me.btnDelete.Tag = "btnRemove"
        Me.btnDelete.Text = "F4 Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(98, 234)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 24)
        Me.btnEdit.TabIndex = 104
        Me.btnEdit.Tag = "btnUpdate"
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
        Me.btnAdd.Location = New System.Drawing.Point(12, 234)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 24)
        Me.btnAdd.TabIndex = 103
        Me.btnAdd.Tag = "btnInsert"
        Me.btnAdd.Text = "F2 Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgSub
        '
        Me.dgSub.AllowUserToAddRows = False
        Me.dgSub.AllowUserToDeleteRows = False
        Me.dgSub.AllowUserToResizeColumns = False
        Me.dgSub.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSub.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.deleted, Me.approval_user_id, Me.username, Me.Column1})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSub.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgSub.Location = New System.Drawing.Point(3, 3)
        Me.dgSub.MultiSelect = False
        Me.dgSub.Name = "dgSub"
        Me.dgSub.RowHeadersVisible = False
        Me.dgSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSub.Size = New System.Drawing.Size(554, 151)
        Me.dgSub.TabIndex = 8
        Me.dgSub.Tag = "sub-grid"
        '
        'sel1
        '
        Me.sel1.DataPropertyName = "sel1"
        Me.sel1.FalseValue = "False"
        Me.sel1.HeaderText = "Sel"
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.TrueValue = "True"
        Me.sel1.Width = 30
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "Deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleted.Visible = False
        '
        'approval_user_id
        '
        Me.approval_user_id.DataPropertyName = "approval_user_id"
        Me.approval_user_id.HeaderText = "ID"
        Me.approval_user_id.Name = "approval_user_id"
        Me.approval_user_id.ReadOnly = True
        Me.approval_user_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.approval_user_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.approval_user_id.Visible = False
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "user_fullname"
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'panelSub
        '
        Me.panelSub.Controls.Add(Me.btnRemove)
        Me.panelSub.Controls.Add(Me.txt_user_fullname)
        Me.panelSub.Controls.Add(Me.PictureBox1)
        Me.panelSub.Controls.Add(Me.txt_user_id)
        Me.panelSub.Controls.Add(Me.Label5)
        Me.panelSub.Controls.Add(Me.Label4)
        Me.panelSub.Controls.Add(Me.txt_order_no)
        Me.panelSub.Controls.Add(Me.txt_approval_order)
        Me.panelSub.Controls.Add(Me.txt_approval_user_id)
        Me.panelSub.Controls.Add(Me.dgSub)
        Me.panelSub.Controls.Add(Me.btnUpdate)
        Me.panelSub.Controls.Add(Me.btnInsert)
        Me.panelSub.Controls.Add(Me.btnCancel)
        Me.panelSub.Controls.Add(Me.btnOK)
        Me.panelSub.Location = New System.Drawing.Point(20, 340)
        Me.panelSub.Name = "panelSub"
        Me.panelSub.Size = New System.Drawing.Size(560, 253)
        Me.panelSub.TabIndex = 110
        Me.panelSub.Tag = "subContainer"
        '
        'txt_user_fullname
        '
        Me.txt_user_fullname._Text = ""
        Me.txt_user_fullname.AlwaysDisable = True
        Me.txt_user_fullname.AlwaysEnable = False
        Me.txt_user_fullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_fullname.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_user_fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_fullname.DataSource = ""
        Me.txt_user_fullname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_fullname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_fullname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_fullname.Enabled = False
        Me.txt_user_fullname.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_fullname.ispk = False
        Me.txt_user_fullname.Location = New System.Drawing.Point(181, 189)
        Me.txt_user_fullname.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_fullname.MultiLine = False
        Me.txt_user_fullname.Name = "txt_user_fullname"
        Me.txt_user_fullname.NoClear = False
        Me.txt_user_fullname.NumberFormat = "@"
        Me.txt_user_fullname.Required = False
        Me.txt_user_fullname.RowData = Nothing
        Me.txt_user_fullname.SelectionLength = 0
        Me.txt_user_fullname.SelectionStart = 0
        Me.txt_user_fullname.Size = New System.Drawing.Size(360, 20)
        Me.txt_user_fullname.TabIndex = 3
        Me.txt_user_fullname.TableData = Nothing
        Me.txt_user_fullname.TextSource = ""
        Me.txt_user_fullname.UseSystemPasswordChar = False
        Me.txt_user_fullname.Value = ""
        Me.txt_user_fullname.ValueSource = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'txt_user_id
        '
        Me.txt_user_id._Text = ""
        Me.txt_user_id.AlwaysDisable = False
        Me.txt_user_id.AlwaysEnable = False
        Me.txt_user_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_id.DataSource = ""
        Me.txt_user_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_id.Enabled = False
        Me.txt_user_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_id.ispk = False
        Me.txt_user_id.Location = New System.Drawing.Point(61, 188)
        Me.txt_user_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_id.MultiLine = False
        Me.txt_user_id.Name = "txt_user_id"
        Me.txt_user_id.NoClear = False
        Me.txt_user_id.NumberFormat = "@"
        Me.txt_user_id.Required = False
        Me.txt_user_id.RowData = Nothing
        Me.txt_user_id.SelectionLength = 0
        Me.txt_user_id.SelectionStart = 0
        Me.txt_user_id.Size = New System.Drawing.Size(105, 20)
        Me.txt_user_id.TabIndex = 2
        Me.txt_user_id.TableData = Nothing
        Me.txt_user_id.TextSource = "username"
        Me.txt_user_id.UseSystemPasswordChar = False
        Me.txt_user_id.Value = ""
        Me.txt_user_id.ValueSource = "user_id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Order No"
        '
        'txt_order_no
        '
        Me.txt_order_no._Text = ""
        Me.txt_order_no.AlwaysDisable = False
        Me.txt_order_no.AlwaysEnable = False
        Me.txt_order_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_order_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_order_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_order_no.DataSource = ""
        Me.txt_order_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_order_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_order_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_order_no.Enabled = False
        Me.txt_order_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_order_no.ispk = False
        Me.txt_order_no.Location = New System.Drawing.Point(297, 218)
        Me.txt_order_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_order_no.MultiLine = False
        Me.txt_order_no.Name = "txt_order_no"
        Me.txt_order_no.NoClear = False
        Me.txt_order_no.NumberFormat = "##,##0"
        Me.txt_order_no.Required = False
        Me.txt_order_no.RowData = Nothing
        Me.txt_order_no.SelectionLength = 0
        Me.txt_order_no.SelectionStart = 0
        Me.txt_order_no.Size = New System.Drawing.Size(105, 20)
        Me.txt_order_no.TabIndex = 7
        Me.txt_order_no.TableData = Nothing
        Me.txt_order_no.TextSource = ""
        Me.txt_order_no.UseSystemPasswordChar = False
        Me.txt_order_no.Value = "0"
        Me.txt_order_no.ValueSource = ""
        '
        'txt_approval_order
        '
        Me.txt_approval_order.Controls.Add(Me.Rdo_button3)
        Me.txt_approval_order.Controls.Add(Me.Rdo_button4)
        Me.txt_approval_order.Location = New System.Drawing.Point(59, 215)
        Me.txt_approval_order.Name = "txt_approval_order"
        Me.txt_approval_order.Size = New System.Drawing.Size(176, 25)
        Me.txt_approval_order.TabIndex = 4
        Me.txt_approval_order.Visible = False
        '
        'Rdo_button3
        '
        Me.Rdo_button3.AutoSize = True
        Me.Rdo_button3.DataSource = ""
        Me.Rdo_button3.Location = New System.Drawing.Point(98, 4)
        Me.Rdo_button3.Name = "Rdo_button3"
        Me.Rdo_button3.Size = New System.Drawing.Size(75, 17)
        Me.Rdo_button3.TabIndex = 6
        Me.Rdo_button3.Text = "Sequential"
        Me.Rdo_button3.TextSource = ""
        Me.Rdo_button3.Uncheckable = False
        Me.Rdo_button3.UseVisualStyleBackColor = True
        Me.Rdo_button3.Value = "1"
        Me.Rdo_button3.ValueSource = ""
        '
        'Rdo_button4
        '
        Me.Rdo_button4.AutoSize = True
        Me.Rdo_button4.Checked = True
        Me.Rdo_button4.DataSource = ""
        Me.Rdo_button4.Location = New System.Drawing.Point(4, 4)
        Me.Rdo_button4.Name = "Rdo_button4"
        Me.Rdo_button4.Size = New System.Drawing.Size(88, 17)
        Me.Rdo_button4.TabIndex = 5
        Me.Rdo_button4.TabStop = True
        Me.Rdo_button4.Text = "Simultaneous"
        Me.Rdo_button4.TextSource = ""
        Me.Rdo_button4.Uncheckable = False
        Me.Rdo_button4.UseVisualStyleBackColor = True
        Me.Rdo_button4.Value = "0"
        Me.Rdo_button4.ValueSource = ""
        '
        'txt_approval_user_id
        '
        Me.txt_approval_user_id._Text = ""
        Me.txt_approval_user_id.AlwaysDisable = True
        Me.txt_approval_user_id.AlwaysEnable = False
        Me.txt_approval_user_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_approval_user_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_approval_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_approval_user_id.DataSource = ""
        Me.txt_approval_user_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_approval_user_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_approval_user_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_approval_user_id.Enabled = False
        Me.txt_approval_user_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_approval_user_id.ispk = False
        Me.txt_approval_user_id.Location = New System.Drawing.Point(498, 160)
        Me.txt_approval_user_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_approval_user_id.MultiLine = False
        Me.txt_approval_user_id.Name = "txt_approval_user_id"
        Me.txt_approval_user_id.NoClear = False
        Me.txt_approval_user_id.NumberFormat = "@"
        Me.txt_approval_user_id.Required = False
        Me.txt_approval_user_id.RowData = Nothing
        Me.txt_approval_user_id.SelectionLength = 0
        Me.txt_approval_user_id.SelectionStart = 0
        Me.txt_approval_user_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_approval_user_id.TabIndex = 1
        Me.txt_approval_user_id.TableData = Nothing
        Me.txt_approval_user_id.Tag = "pk"
        Me.txt_approval_user_id.TextSource = ""
        Me.txt_approval_user_id.UseSystemPasswordChar = False
        Me.txt_approval_user_id.Value = ""
        Me.txt_approval_user_id.ValueSource = ""
        Me.txt_approval_user_id.Visible = False
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.txt_main_order_no)
        Me.gboxContainer.Controls.Add(Me.txt_main_approval_order)
        Me.gboxContainer.Controls.Add(Me.txt_stage_name)
        Me.gboxContainer.Controls.Add(Me.PictureBox3)
        Me.gboxContainer.Controls.Add(Me.txt_stage_id)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Controls.Add(Me.txt_approval_id)
        Me.gboxContainer.Location = New System.Drawing.Point(20, 264)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(560, 70)
        Me.gboxContainer.TabIndex = 100
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Order No"
        '
        'txt_main_order_no
        '
        Me.txt_main_order_no._Text = ""
        Me.txt_main_order_no.AlwaysDisable = False
        Me.txt_main_order_no.AlwaysEnable = False
        Me.txt_main_order_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_main_order_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_main_order_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_main_order_no.DataSource = ""
        Me.txt_main_order_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_main_order_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_main_order_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_main_order_no.Enabled = False
        Me.txt_main_order_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_main_order_no.ispk = False
        Me.txt_main_order_no.Location = New System.Drawing.Point(299, 42)
        Me.txt_main_order_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_main_order_no.MultiLine = False
        Me.txt_main_order_no.Name = "txt_main_order_no"
        Me.txt_main_order_no.NoClear = False
        Me.txt_main_order_no.NumberFormat = "##,##0"
        Me.txt_main_order_no.Required = False
        Me.txt_main_order_no.RowData = Nothing
        Me.txt_main_order_no.SelectionLength = 0
        Me.txt_main_order_no.SelectionStart = 0
        Me.txt_main_order_no.Size = New System.Drawing.Size(105, 20)
        Me.txt_main_order_no.TabIndex = 7
        Me.txt_main_order_no.TableData = Nothing
        Me.txt_main_order_no.TextSource = ""
        Me.txt_main_order_no.UseSystemPasswordChar = False
        Me.txt_main_order_no.Value = "0"
        Me.txt_main_order_no.ValueSource = ""
        '
        'txt_main_approval_order
        '
        Me.txt_main_approval_order.Controls.Add(Me.Rdo_button2)
        Me.txt_main_approval_order.Controls.Add(Me.Rdo_button1)
        Me.txt_main_approval_order.Location = New System.Drawing.Point(61, 39)
        Me.txt_main_approval_order.Name = "txt_main_approval_order"
        Me.txt_main_approval_order.Size = New System.Drawing.Size(176, 25)
        Me.txt_main_approval_order.TabIndex = 4
        '
        'Rdo_button2
        '
        Me.Rdo_button2.AutoSize = True
        Me.Rdo_button2.DataSource = ""
        Me.Rdo_button2.Location = New System.Drawing.Point(98, 4)
        Me.Rdo_button2.Name = "Rdo_button2"
        Me.Rdo_button2.Size = New System.Drawing.Size(75, 17)
        Me.Rdo_button2.TabIndex = 6
        Me.Rdo_button2.Text = "Sequential"
        Me.Rdo_button2.TextSource = ""
        Me.Rdo_button2.Uncheckable = False
        Me.Rdo_button2.UseVisualStyleBackColor = True
        Me.Rdo_button2.Value = "1"
        Me.Rdo_button2.ValueSource = ""
        '
        'Rdo_button1
        '
        Me.Rdo_button1.AutoSize = True
        Me.Rdo_button1.Checked = True
        Me.Rdo_button1.DataSource = ""
        Me.Rdo_button1.Location = New System.Drawing.Point(4, 4)
        Me.Rdo_button1.Name = "Rdo_button1"
        Me.Rdo_button1.Size = New System.Drawing.Size(88, 17)
        Me.Rdo_button1.TabIndex = 5
        Me.Rdo_button1.TabStop = True
        Me.Rdo_button1.Text = "Simultaneous"
        Me.Rdo_button1.TextSource = ""
        Me.Rdo_button1.Uncheckable = False
        Me.Rdo_button1.UseVisualStyleBackColor = True
        Me.Rdo_button1.Value = "0"
        Me.Rdo_button1.ValueSource = ""
        '
        'txt_stage_name
        '
        Me.txt_stage_name._Text = ""
        Me.txt_stage_name.AlwaysDisable = True
        Me.txt_stage_name.AlwaysEnable = False
        Me.txt_stage_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_stage_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stage_name.DataSource = ""
        Me.txt_stage_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_name.Enabled = False
        Me.txt_stage_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_stage_name.ispk = False
        Me.txt_stage_name.Location = New System.Drawing.Point(181, 13)
        Me.txt_stage_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_name.MultiLine = False
        Me.txt_stage_name.Name = "txt_stage_name"
        Me.txt_stage_name.NoClear = False
        Me.txt_stage_name.NumberFormat = "@"
        Me.txt_stage_name.Required = False
        Me.txt_stage_name.RowData = Nothing
        Me.txt_stage_name.SelectionLength = 0
        Me.txt_stage_name.SelectionStart = 0
        Me.txt_stage_name.Size = New System.Drawing.Size(360, 20)
        Me.txt_stage_name.TabIndex = 3
        Me.txt_stage_name.TableData = Nothing
        Me.txt_stage_name.TextSource = ""
        Me.txt_stage_name.UseSystemPasswordChar = False
        Me.txt_stage_name.Value = ""
        Me.txt_stage_name.ValueSource = ""
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(166, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 109
        Me.PictureBox3.TabStop = False
        '
        'txt_stage_id
        '
        Me.txt_stage_id._Text = ""
        Me.txt_stage_id.AlwaysDisable = False
        Me.txt_stage_id.AlwaysEnable = False
        Me.txt_stage_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_stage_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stage_id.DataSource = ""
        Me.txt_stage_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_id.Enabled = False
        Me.txt_stage_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_stage_id.ispk = False
        Me.txt_stage_id.Location = New System.Drawing.Point(61, 12)
        Me.txt_stage_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_id.MultiLine = False
        Me.txt_stage_id.Name = "txt_stage_id"
        Me.txt_stage_id.NoClear = False
        Me.txt_stage_id.NumberFormat = "@"
        Me.txt_stage_id.Required = False
        Me.txt_stage_id.RowData = Nothing
        Me.txt_stage_id.SelectionLength = 0
        Me.txt_stage_id.SelectionStart = 0
        Me.txt_stage_id.Size = New System.Drawing.Size(105, 20)
        Me.txt_stage_id.TabIndex = 2
        Me.txt_stage_id.TableData = Nothing
        Me.txt_stage_id.TextSource = "stage_code"
        Me.txt_stage_id.UseSystemPasswordChar = False
        Me.txt_stage_id.Value = ""
        Me.txt_stage_id.ValueSource = "stage_id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stage"
        '
        'txt_approval_id
        '
        Me.txt_approval_id._Text = ""
        Me.txt_approval_id.AlwaysDisable = True
        Me.txt_approval_id.AlwaysEnable = False
        Me.txt_approval_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_approval_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_approval_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_approval_id.DataSource = ""
        Me.txt_approval_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_approval_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_approval_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_approval_id.Enabled = False
        Me.txt_approval_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_approval_id.ispk = False
        Me.txt_approval_id.Location = New System.Drawing.Point(6, 39)
        Me.txt_approval_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_approval_id.MultiLine = False
        Me.txt_approval_id.Name = "txt_approval_id"
        Me.txt_approval_id.NoClear = False
        Me.txt_approval_id.NumberFormat = "@"
        Me.txt_approval_id.Required = False
        Me.txt_approval_id.RowData = Nothing
        Me.txt_approval_id.SelectionLength = 0
        Me.txt_approval_id.SelectionStart = 0
        Me.txt_approval_id.Size = New System.Drawing.Size(47, 20)
        Me.txt_approval_id.TabIndex = 1
        Me.txt_approval_id.TableData = Nothing
        Me.txt_approval_id.TextSource = ""
        Me.txt_approval_id.UseSystemPasswordChar = False
        Me.txt_approval_id.Value = ""
        Me.txt_approval_id.ValueSource = ""
        Me.txt_approval_id.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Approval Setup"
        '
        'txtsearch
        '
        Me.txtsearch._Text = ""
        Me.txtsearch.AlwaysDisable = False
        Me.txtsearch.AlwaysEnable = False
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.BorderColor = System.Drawing.Color.DarkGray
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.DataSource = ""
        Me.txtsearch.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtsearch.Enabled = False
        Me.txtsearch.EnabledBackColor = System.Drawing.Color.White
        Me.txtsearch.ispk = False
        Me.txtsearch.Location = New System.Drawing.Point(426, 40)
        Me.txtsearch.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.MultiLine = False
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.SelectionLength = 0
        Me.txtsearch.SelectionStart = 0
        Me.txtsearch.Size = New System.Drawing.Size(154, 20)
        Me.txtsearch.TabIndex = 112
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = ""
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(20, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(560, 2)
        Me.border1.TabIndex = 102
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModule
        '
        Me.lblModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModule.ForeColor = System.Drawing.Color.Blue
        Me.lblModule.Location = New System.Drawing.Point(237, 234)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(343, 23)
        Me.lblModule.TabIndex = 113
        Me.lblModule.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(600, 28)
        Me.Myformheader1.TabIndex = 114
        '
        'approvalsetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 602)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.lblModule)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.panelSub)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "approvalsetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sys_erp_approval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sys_erp_approval_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSub.ResumeLayout(False)
        Me.panelSub.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txt_approval_order.ResumeLayout(False)
        Me.txt_approval_order.PerformLayout()
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        Me.txt_main_approval_order.ResumeLayout(False)
        Me.txt_main_approval_order.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txt_approval_user_id As user_control.textbox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dgSub As System.Windows.Forms.DataGridView
    Friend WithEvents txt_approval_id As user_control.textbox
    Friend WithEvents panelSub As System.Windows.Forms.Panel
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_stage_id As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents sys_erp_approval As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents sys_erp_approval_user As System.Data.DataTable
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents txt_main_order_no As user_control.textbox
    Friend WithEvents txt_main_approval_order As System.Windows.Forms.Panel
    Friend WithEvents Rdo_button2 As user_control.rdo_button
    Friend WithEvents Rdo_button1 As user_control.rdo_button
    Friend WithEvents txt_stage_name As user_control.textbox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_user_fullname As user_control.textbox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_user_id As user_control.textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_order_no As user_control.textbox
    Friend WithEvents txt_approval_order As System.Windows.Forms.Panel
    Friend WithEvents Rdo_button3 As user_control.rdo_button
    Friend WithEvents Rdo_button4 As user_control.rdo_button
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents approval_user_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents approval_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stage_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stage_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblModule As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
End Class
