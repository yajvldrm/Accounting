Imports user_control
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class approvalsetup
    Inherits MyForm

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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(approvalsetup))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.Myformheader1 = New user_control.myformheader()
        Me.dgSub = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.approval_user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.stage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stage_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.approval_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.MyPanel1 = New user_control.MyPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_order_no_det = New user_control.MyTextBox()
        Me.txt_user_fullname = New user_control.MyTextBox()
        Me.txt_user_id = New user_control.MyTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_approval_user_id = New user_control.MyTextBox()
        Me.MyButton6 = New user_control.MyButton()
        Me.MyButton9 = New user_control.MyButton()
        Me.MyButton10 = New user_control.MyButton()
        Me.MyButton7 = New user_control.MyButton()
        Me.MyButton8 = New user_control.MyButton()
        Me.MyButton3 = New user_control.MyButton()
        Me.MyButton2 = New user_control.MyButton()
        Me.MyButton1 = New user_control.MyButton()
        Me.MyButton4 = New user_control.MyButton()
        Me.MyButton5 = New user_control.MyButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_order_no = New user_control.MyTextBox()
        Me.txt_stage_name = New user_control.MyTextBox()
        Me.txt_stage_id = New user_control.MyTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_approval_id = New user_control.MyTextBox()
        Me.txt_approval_order = New user_control.MyRadioGroup()
        Me.MyRadioButton2 = New user_control.MyRadioButton()
        Me.MyRadioButton1 = New user_control.MyRadioButton()
        Me.txt_module_id = New user_control.MyTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sys_erp_approval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sys_erp_approval_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txt_approval_order.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataColumn10.DefaultValue = ""
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
        Me.DataColumn12.ColumnName = "sel"
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
        Me.DataColumn18.DefaultValue = ""
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
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(20, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(560, 2)
        Me.border1.TabIndex = 102
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'dgSub
        '
        Me.dgSub.AllowUserToAddRows = False
        Me.dgSub.AllowUserToDeleteRows = False
        Me.dgSub.AllowUserToResizeColumns = False
        Me.dgSub.AllowUserToResizeRows = False
        Me.dgSub.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSub.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.approval_user_id, Me.username, Me.Column1, Me.deleted})
        Me.dgSub.DataSource = Me.ds
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSub.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.sel1.DataPropertyName = "sel"
        Me.sel1.FalseValue = "False"
        Me.sel1.HeaderText = "Sel"
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.TrueValue = "True"
        Me.sel1.Width = 30
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
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "Deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleted.Visible = False
        '
        'stage_name
        '
        Me.stage_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stage_name.DataPropertyName = "stage_name"
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.stage_name.DefaultCellStyle = DataGridViewCellStyle7
        Me.stage_name.HeaderText = "Stage Name"
        Me.stage_name.Name = "stage_name"
        Me.stage_name.ReadOnly = True
        Me.stage_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stage_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'stage_code
        '
        Me.stage_code.DataPropertyName = "stage_code"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stage_code.DefaultCellStyle = DataGridViewCellStyle8
        Me.stage_code.HeaderText = "Code"
        Me.stage_code.Name = "stage_code"
        Me.stage_code.ReadOnly = True
        Me.stage_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stage_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.AutoGenerateColumns = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeight = 28
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.approval_id, Me.stage_code, Me.stage_name})
        Me.dgMain.DataSource = Me.ds
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
        'MyPanel1
        '
        Me.MyPanel1.Controls.Add(Me.PictureBox2)
        Me.MyPanel1.Controls.Add(Me.Label5)
        Me.MyPanel1.Controls.Add(Me.txt_order_no_det)
        Me.MyPanel1.Controls.Add(Me.txt_user_fullname)
        Me.MyPanel1.Controls.Add(Me.txt_user_id)
        Me.MyPanel1.Controls.Add(Me.Label7)
        Me.MyPanel1.Controls.Add(Me.txt_approval_user_id)
        Me.MyPanel1.Controls.Add(Me.MyButton6)
        Me.MyPanel1.Controls.Add(Me.MyButton9)
        Me.MyPanel1.Controls.Add(Me.MyButton10)
        Me.MyPanel1.Controls.Add(Me.MyButton7)
        Me.MyPanel1.Controls.Add(Me.MyButton8)
        Me.MyPanel1.Controls.Add(Me.dgSub)
        Me.MyPanel1.CustomQuery = "[approval_setup_user]"
        Me.MyPanel1.Location = New System.Drawing.Point(20, 337)
        Me.MyPanel1.ModuleCode = ""
        Me.MyPanel1.MyDataBase = user_control.MyList.Database.FileSetup
        Me.MyPanel1.MyDGView = Me.dgSub
        Me.MyPanel1.MYFK = "txt_approval_id"
        Me.MyPanel1.MyTable = "sys_erp_approval_user"
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(560, 253)
        Me.MyPanel1.TabIndex = 115
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(278, 198)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 151
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Order Number"
        '
        'txt_order_no_det
        '
        Me.txt_order_no_det.AlwaysDisable = False
        Me.txt_order_no_det.AlwaysEnable = False
        Me.txt_order_no_det.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_order_no_det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_order_no_det.BrowseDataSource = ""
        Me.txt_order_no_det.BrowseField = ""
        Me.txt_order_no_det.BrowseFilter = Nothing
        Me.txt_order_no_det.BrowseLabel = "Code,Name"
        Me.txt_order_no_det.BrowseLabelWidth = "100,200"
        Me.txt_order_no_det.BrowseTextSource = ""
        Me.txt_order_no_det.BrowseValueSource = ""
        Me.txt_order_no_det.Database = user_control.MyList.Database.FileSetup
        Me.txt_order_no_det.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_order_no_det.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_order_no_det.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_order_no_det.Enabled = False
        Me.txt_order_no_det.EnabledBackColor = System.Drawing.Color.White
        Me.txt_order_no_det.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_order_no_det.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_order_no_det.ID = False
        Me.txt_order_no_det.Location = New System.Drawing.Point(320, 222)
        Me.txt_order_no_det.Name = "txt_order_no_det"
        Me.txt_order_no_det.NoClear = False
        Me.txt_order_no_det.NoSave = False
        Me.txt_order_no_det.NumberFormat = "##,##0"
        Me.txt_order_no_det.Required = True
        Me.txt_order_no_det.RowData = Nothing
        Me.txt_order_no_det.Size = New System.Drawing.Size(200, 20)
        Me.txt_order_no_det.TabIndex = 7
        Me.txt_order_no_det.Text = "0"
        Me.txt_order_no_det.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_order_no_det.TextBrowse = False
        Me.txt_order_no_det.TextSource = "order_no"
        Me.txt_order_no_det.ToUpper = True
        Me.txt_order_no_det.Unique = True
        Me.txt_order_no_det.Value = ""
        Me.txt_order_no_det.ValueSource = ""
        '
        'txt_user_fullname
        '
        Me.txt_user_fullname.AlwaysDisable = True
        Me.txt_user_fullname.AlwaysEnable = False
        Me.txt_user_fullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_fullname.BrowseDataSource = ""
        Me.txt_user_fullname.BrowseField = ""
        Me.txt_user_fullname.BrowseFilter = Nothing
        Me.txt_user_fullname.BrowseLabel = "Code,Name"
        Me.txt_user_fullname.BrowseLabelWidth = "100,200"
        Me.txt_user_fullname.BrowseTextSource = "user_fullname"
        Me.txt_user_fullname.BrowseValueSource = ""
        Me.txt_user_fullname.Database = user_control.MyList.Database.FileSetup
        Me.txt_user_fullname.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_fullname.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_fullname.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_fullname.Enabled = False
        Me.txt_user_fullname.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_fullname.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_user_fullname.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_fullname.ID = False
        Me.txt_user_fullname.Location = New System.Drawing.Point(295, 196)
        Me.txt_user_fullname.Name = "txt_user_fullname"
        Me.txt_user_fullname.NoClear = False
        Me.txt_user_fullname.NoSave = True
        Me.txt_user_fullname.NumberFormat = "@"
        Me.txt_user_fullname.Required = True
        Me.txt_user_fullname.RowData = Nothing
        Me.txt_user_fullname.Size = New System.Drawing.Size(225, 20)
        Me.txt_user_fullname.TabIndex = 3
        Me.txt_user_fullname.TextBrowse = False
        Me.txt_user_fullname.TextSource = "user_fullname"
        Me.txt_user_fullname.ToUpper = True
        Me.txt_user_fullname.Unique = True
        Me.txt_user_fullname.Value = ""
        Me.txt_user_fullname.ValueSource = ""
        '
        'txt_user_id
        '
        Me.txt_user_id.AlwaysDisable = False
        Me.txt_user_id.AlwaysEnable = False
        Me.txt_user_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_id.BrowseDataSource = "sys_erp_user"
        Me.txt_user_id.BrowseField = "username,user_fullname"
        Me.txt_user_id.BrowseFilter = Nothing
        Me.txt_user_id.BrowseLabel = "Code,Name"
        Me.txt_user_id.BrowseLabelWidth = "100,200"
        Me.txt_user_id.BrowseTextSource = "username"
        Me.txt_user_id.BrowseUpdate.Add(CType(resources.GetObject("txt_user_id.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_user_id.BrowseValueSource = "user_id"
        Me.txt_user_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_user_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_id.Enabled = False
        Me.txt_user_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_user_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_id.ID = False
        Me.txt_user_id.Location = New System.Drawing.Point(76, 196)
        Me.txt_user_id.Name = "txt_user_id"
        Me.txt_user_id.NoClear = False
        Me.txt_user_id.NoSave = False
        Me.txt_user_id.NumberFormat = "@"
        Me.txt_user_id.Required = True
        Me.txt_user_id.RowData = Nothing
        Me.txt_user_id.Size = New System.Drawing.Size(200, 20)
        Me.txt_user_id.TabIndex = 2
        Me.txt_user_id.TextBrowse = True
        Me.txt_user_id.TextSource = "username"
        Me.txt_user_id.ToUpper = True
        Me.txt_user_id.Unique = True
        Me.txt_user_id.Value = ""
        Me.txt_user_id.ValueSource = "user_id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "User"
        '
        'txt_approval_user_id
        '
        Me.txt_approval_user_id.AlwaysDisable = False
        Me.txt_approval_user_id.AlwaysEnable = False
        Me.txt_approval_user_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_approval_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_approval_user_id.BrowseDataSource = ""
        Me.txt_approval_user_id.BrowseField = ""
        Me.txt_approval_user_id.BrowseFilter = Nothing
        Me.txt_approval_user_id.BrowseLabel = "Code,Name"
        Me.txt_approval_user_id.BrowseLabelWidth = "100,200"
        Me.txt_approval_user_id.BrowseTextSource = ""
        Me.txt_approval_user_id.BrowseValueSource = ""
        Me.txt_approval_user_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_approval_user_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_approval_user_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_approval_user_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_approval_user_id.Enabled = False
        Me.txt_approval_user_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_approval_user_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_approval_user_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_approval_user_id.ID = True
        Me.txt_approval_user_id.Location = New System.Drawing.Point(15, 184)
        Me.txt_approval_user_id.Name = "txt_approval_user_id"
        Me.txt_approval_user_id.NoClear = False
        Me.txt_approval_user_id.NoSave = False
        Me.txt_approval_user_id.NumberFormat = "@"
        Me.txt_approval_user_id.Required = False
        Me.txt_approval_user_id.RowData = Nothing
        Me.txt_approval_user_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_approval_user_id.TabIndex = 1
        Me.txt_approval_user_id.TextBrowse = False
        Me.txt_approval_user_id.TextSource = "approval_user_id"
        Me.txt_approval_user_id.ToUpper = True
        Me.txt_approval_user_id.Unique = False
        Me.txt_approval_user_id.Value = ""
        Me.txt_approval_user_id.ValueSource = ""
        Me.txt_approval_user_id.Visible = False
        '
        'MyButton6
        '
        Me.MyButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton6.ButtonType = user_control.MyList.ButtonType.ButtonRemove
        Me.MyButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton6.ForeColor = System.Drawing.Color.White
        Me.MyButton6.Location = New System.Drawing.Point(177, 160)
        Me.MyButton6.Name = "MyButton6"
        Me.MyButton6.Size = New System.Drawing.Size(80, 24)
        Me.MyButton6.TabIndex = 11
        Me.MyButton6.Text = "&Remove"
        Me.MyButton6.UseVisualStyleBackColor = False
        '
        'MyButton9
        '
        Me.MyButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton9.ButtonType = user_control.MyList.ButtonType.ButtonUpdate
        Me.MyButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton9.ForeColor = System.Drawing.Color.White
        Me.MyButton9.Location = New System.Drawing.Point(91, 160)
        Me.MyButton9.Name = "MyButton9"
        Me.MyButton9.Size = New System.Drawing.Size(80, 24)
        Me.MyButton9.TabIndex = 10
        Me.MyButton9.Text = "&Update"
        Me.MyButton9.UseVisualStyleBackColor = False
        '
        'MyButton10
        '
        Me.MyButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton10.ButtonType = user_control.MyList.ButtonType.ButtonInsert
        Me.MyButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton10.ForeColor = System.Drawing.Color.White
        Me.MyButton10.Location = New System.Drawing.Point(5, 160)
        Me.MyButton10.Name = "MyButton10"
        Me.MyButton10.Size = New System.Drawing.Size(80, 24)
        Me.MyButton10.TabIndex = 9
        Me.MyButton10.Text = "&Insert"
        Me.MyButton10.UseVisualStyleBackColor = False
        '
        'MyButton7
        '
        Me.MyButton7.BackColor = System.Drawing.Color.Maroon
        Me.MyButton7.ButtonType = user_control.MyList.ButtonType.ButtonCancel
        Me.MyButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.MyButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton7.ForeColor = System.Drawing.Color.White
        Me.MyButton7.Location = New System.Drawing.Point(91, 160)
        Me.MyButton7.Name = "MyButton7"
        Me.MyButton7.Size = New System.Drawing.Size(80, 24)
        Me.MyButton7.TabIndex = 13
        Me.MyButton7.Text = "Ca&ncel"
        Me.MyButton7.UseVisualStyleBackColor = False
        '
        'MyButton8
        '
        Me.MyButton8.BackColor = System.Drawing.Color.Green
        Me.MyButton8.ButtonType = user_control.MyList.ButtonType.ButtonOK
        Me.MyButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.MyButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton8.ForeColor = System.Drawing.Color.White
        Me.MyButton8.Location = New System.Drawing.Point(5, 160)
        Me.MyButton8.Name = "MyButton8"
        Me.MyButton8.Size = New System.Drawing.Size(80, 24)
        Me.MyButton8.TabIndex = 12
        Me.MyButton8.Text = "&OK"
        Me.MyButton8.UseVisualStyleBackColor = False
        '
        'MyButton3
        '
        Me.MyButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton3.ButtonType = user_control.MyList.ButtonType.ButtonDelete
        Me.MyButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton3.ForeColor = System.Drawing.Color.White
        Me.MyButton3.Location = New System.Drawing.Point(192, 234)
        Me.MyButton3.Name = "MyButton3"
        Me.MyButton3.Size = New System.Drawing.Size(80, 24)
        Me.MyButton3.TabIndex = 119
        Me.MyButton3.Text = "F4 Delete"
        Me.MyButton3.UseVisualStyleBackColor = False
        '
        'MyButton2
        '
        Me.MyButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton2.ButtonType = user_control.MyList.ButtonType.ButtonEdit
        Me.MyButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton2.ForeColor = System.Drawing.Color.White
        Me.MyButton2.Location = New System.Drawing.Point(106, 234)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(80, 24)
        Me.MyButton2.TabIndex = 118
        Me.MyButton2.Text = "F3 Edit"
        Me.MyButton2.UseVisualStyleBackColor = False
        '
        'MyButton1
        '
        Me.MyButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MyButton1.ButtonType = user_control.MyList.ButtonType.ButtonAdd
        Me.MyButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.MyButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.MyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton1.ForeColor = System.Drawing.Color.White
        Me.MyButton1.Location = New System.Drawing.Point(20, 234)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(80, 24)
        Me.MyButton1.TabIndex = 117
        Me.MyButton1.Text = "F2 Add"
        Me.MyButton1.UseVisualStyleBackColor = False
        '
        'MyButton4
        '
        Me.MyButton4.BackColor = System.Drawing.Color.Maroon
        Me.MyButton4.ButtonType = user_control.MyList.ButtonType.ButtonNotSave
        Me.MyButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.MyButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton4.ForeColor = System.Drawing.Color.White
        Me.MyButton4.Location = New System.Drawing.Point(106, 234)
        Me.MyButton4.Name = "MyButton4"
        Me.MyButton4.Size = New System.Drawing.Size(80, 24)
        Me.MyButton4.TabIndex = 121
        Me.MyButton4.Text = "&Cancel"
        Me.MyButton4.UseVisualStyleBackColor = False
        '
        'MyButton5
        '
        Me.MyButton5.BackColor = System.Drawing.Color.Green
        Me.MyButton5.ButtonType = user_control.MyList.ButtonType.ButtonSave
        Me.MyButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.MyButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MyButton5.ForeColor = System.Drawing.Color.White
        Me.MyButton5.Location = New System.Drawing.Point(20, 234)
        Me.MyButton5.Name = "MyButton5"
        Me.MyButton5.Size = New System.Drawing.Size(80, 24)
        Me.MyButton5.TabIndex = 120
        Me.MyButton5.Text = "&Save"
        Me.MyButton5.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_order_no)
        Me.GroupBox1.Controls.Add(Me.txt_stage_name)
        Me.GroupBox1.Controls.Add(Me.txt_stage_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_approval_id)
        Me.GroupBox1.Controls.Add(Me.txt_approval_order)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 70)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(278, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 150
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Order Number"
        '
        'txt_order_no
        '
        Me.txt_order_no.AlwaysDisable = False
        Me.txt_order_no.AlwaysEnable = False
        Me.txt_order_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_order_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_order_no.BrowseDataSource = ""
        Me.txt_order_no.BrowseField = ""
        Me.txt_order_no.BrowseFilter = Nothing
        Me.txt_order_no.BrowseLabel = "Code,Name"
        Me.txt_order_no.BrowseLabelWidth = "100,200"
        Me.txt_order_no.BrowseTextSource = ""
        Me.txt_order_no.BrowseValueSource = ""
        Me.txt_order_no.Database = user_control.MyList.Database.FileSetup
        Me.txt_order_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_order_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_order_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_order_no.Enabled = False
        Me.txt_order_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_order_no.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_order_no.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_order_no.ID = False
        Me.txt_order_no.Location = New System.Drawing.Point(320, 38)
        Me.txt_order_no.Name = "txt_order_no"
        Me.txt_order_no.NoClear = False
        Me.txt_order_no.NoSave = False
        Me.txt_order_no.NumberFormat = "##,##0"
        Me.txt_order_no.Required = True
        Me.txt_order_no.RowData = Nothing
        Me.txt_order_no.Size = New System.Drawing.Size(200, 20)
        Me.txt_order_no.TabIndex = 7
        Me.txt_order_no.Text = "0"
        Me.txt_order_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_order_no.TextBrowse = False
        Me.txt_order_no.TextSource = "order_no"
        Me.txt_order_no.ToUpper = True
        Me.txt_order_no.Unique = True
        Me.txt_order_no.Value = ""
        Me.txt_order_no.ValueSource = ""
        '
        'txt_stage_name
        '
        Me.txt_stage_name.AlwaysDisable = True
        Me.txt_stage_name.AlwaysEnable = False
        Me.txt_stage_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stage_name.BrowseDataSource = ""
        Me.txt_stage_name.BrowseField = ""
        Me.txt_stage_name.BrowseFilter = Nothing
        Me.txt_stage_name.BrowseLabel = "Code,Name"
        Me.txt_stage_name.BrowseLabelWidth = "100,200"
        Me.txt_stage_name.BrowseTextSource = "stage_name"
        Me.txt_stage_name.BrowseValueSource = ""
        Me.txt_stage_name.Database = user_control.MyList.Database.FileSetup
        Me.txt_stage_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_name.Enabled = False
        Me.txt_stage_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_stage_name.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_stage_name.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_name.ID = False
        Me.txt_stage_name.Location = New System.Drawing.Point(295, 12)
        Me.txt_stage_name.Name = "txt_stage_name"
        Me.txt_stage_name.NoClear = False
        Me.txt_stage_name.NoSave = True
        Me.txt_stage_name.NumberFormat = "@"
        Me.txt_stage_name.Required = True
        Me.txt_stage_name.RowData = Nothing
        Me.txt_stage_name.Size = New System.Drawing.Size(225, 20)
        Me.txt_stage_name.TabIndex = 3
        Me.txt_stage_name.TextBrowse = False
        Me.txt_stage_name.TextSource = "stage_name"
        Me.txt_stage_name.ToUpper = True
        Me.txt_stage_name.Unique = True
        Me.txt_stage_name.Value = ""
        Me.txt_stage_name.ValueSource = ""
        '
        'txt_stage_id
        '
        Me.txt_stage_id.AlwaysDisable = False
        Me.txt_stage_id.AlwaysEnable = False
        Me.txt_stage_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stage_id.BrowseDataSource = "sys_erp_stage"
        Me.txt_stage_id.BrowseField = "stage_code,stage_name"
        Me.txt_stage_id.BrowseFilter = Nothing
        Me.txt_stage_id.BrowseLabel = "Code,Name"
        Me.txt_stage_id.BrowseLabelWidth = "100,200"
        Me.txt_stage_id.BrowseTextSource = "stage_code"
        Me.txt_stage_id.BrowseUpdate.Add(CType(resources.GetObject("txt_stage_id.BrowseUpdate"), user_control.MyTextBoxList))
        Me.txt_stage_id.BrowseValueSource = "stage_id"
        Me.txt_stage_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_stage_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_stage_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_stage_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_id.Enabled = False
        Me.txt_stage_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_stage_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_stage_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_stage_id.ID = False
        Me.txt_stage_id.Location = New System.Drawing.Point(76, 12)
        Me.txt_stage_id.Name = "txt_stage_id"
        Me.txt_stage_id.NoClear = False
        Me.txt_stage_id.NoSave = False
        Me.txt_stage_id.NumberFormat = "@"
        Me.txt_stage_id.Required = True
        Me.txt_stage_id.RowData = Nothing
        Me.txt_stage_id.Size = New System.Drawing.Size(200, 20)
        Me.txt_stage_id.TabIndex = 2
        Me.txt_stage_id.TextBrowse = True
        Me.txt_stage_id.TextSource = "stage_code"
        Me.txt_stage_id.ToUpper = True
        Me.txt_stage_id.Unique = True
        Me.txt_stage_id.Value = ""
        Me.txt_stage_id.ValueSource = "stage_id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Stage"
        '
        'txt_approval_id
        '
        Me.txt_approval_id.AlwaysDisable = False
        Me.txt_approval_id.AlwaysEnable = False
        Me.txt_approval_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_approval_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_approval_id.BrowseDataSource = ""
        Me.txt_approval_id.BrowseField = ""
        Me.txt_approval_id.BrowseFilter = Nothing
        Me.txt_approval_id.BrowseLabel = "Code,Name"
        Me.txt_approval_id.BrowseLabelWidth = "100,200"
        Me.txt_approval_id.BrowseTextSource = ""
        Me.txt_approval_id.BrowseValueSource = ""
        Me.txt_approval_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_approval_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_approval_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_approval_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_approval_id.Enabled = False
        Me.txt_approval_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_approval_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_approval_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_approval_id.ID = True
        Me.txt_approval_id.Location = New System.Drawing.Point(0, 0)
        Me.txt_approval_id.Name = "txt_approval_id"
        Me.txt_approval_id.NoClear = False
        Me.txt_approval_id.NoSave = False
        Me.txt_approval_id.NumberFormat = "@"
        Me.txt_approval_id.Required = False
        Me.txt_approval_id.RowData = Nothing
        Me.txt_approval_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_approval_id.TabIndex = 1
        Me.txt_approval_id.TextBrowse = False
        Me.txt_approval_id.TextSource = "approval_id"
        Me.txt_approval_id.ToUpper = True
        Me.txt_approval_id.Unique = False
        Me.txt_approval_id.Value = ""
        Me.txt_approval_id.ValueSource = ""
        Me.txt_approval_id.Visible = False
        '
        'txt_approval_order
        '
        Me.txt_approval_order.AlwaysDisable = False
        Me.txt_approval_order.AlwaysEnable = False
        Me.txt_approval_order.Controls.Add(Me.MyRadioButton2)
        Me.txt_approval_order.Controls.Add(Me.MyRadioButton1)
        Me.txt_approval_order.Location = New System.Drawing.Point(59, 31)
        Me.txt_approval_order.Name = "txt_approval_order"
        Me.txt_approval_order.NoSave = False
        Me.txt_approval_order.Required = False
        Me.txt_approval_order.Size = New System.Drawing.Size(179, 32)
        Me.txt_approval_order.TabIndex = 4
        Me.txt_approval_order.TabStop = False
        Me.txt_approval_order.Value = "0"
        Me.txt_approval_order.ValueSource = "approval_order"
        '
        'MyRadioButton2
        '
        Me.MyRadioButton2.AlwaysDisable = False
        Me.MyRadioButton2.AlwaysEnable = False
        Me.MyRadioButton2.AutoSize = True
        Me.MyRadioButton2.Location = New System.Drawing.Point(99, 10)
        Me.MyRadioButton2.Name = "MyRadioButton2"
        Me.MyRadioButton2.Size = New System.Drawing.Size(75, 17)
        Me.MyRadioButton2.TabIndex = 6
        Me.MyRadioButton2.Text = "Sequential"
        Me.MyRadioButton2.Uncheckable = False
        Me.MyRadioButton2.UseVisualStyleBackColor = True
        Me.MyRadioButton2.Value = "1"
        '
        'MyRadioButton1
        '
        Me.MyRadioButton1.AlwaysDisable = False
        Me.MyRadioButton1.AlwaysEnable = False
        Me.MyRadioButton1.AutoSize = True
        Me.MyRadioButton1.Checked = True
        Me.MyRadioButton1.Location = New System.Drawing.Point(5, 10)
        Me.MyRadioButton1.Name = "MyRadioButton1"
        Me.MyRadioButton1.Size = New System.Drawing.Size(88, 17)
        Me.MyRadioButton1.TabIndex = 5
        Me.MyRadioButton1.TabStop = True
        Me.MyRadioButton1.Text = "Simultaneous"
        Me.MyRadioButton1.Uncheckable = False
        Me.MyRadioButton1.UseVisualStyleBackColor = True
        Me.MyRadioButton1.Value = "0"
        '
        'txt_module_id
        '
        Me.txt_module_id.AlwaysDisable = False
        Me.txt_module_id.AlwaysEnable = True
        Me.txt_module_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_module_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_module_id.BrowseDataSource = "[accounting_transaction]"
        Me.txt_module_id.BrowseField = "module_code,module_name"
        Me.txt_module_id.BrowseFilter = Nothing
        Me.txt_module_id.BrowseLabel = "Code,Name"
        Me.txt_module_id.BrowseLabelWidth = "100,200"
        Me.txt_module_id.BrowseTextSource = "module_name"
        Me.txt_module_id.BrowseValueSource = "module_id"
        Me.txt_module_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_module_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_module_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_module_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_module_id.Enabled = False
        Me.txt_module_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_module_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_module_id.ForeColor = System.Drawing.Color.Black
        Me.txt_module_id.ID = False
        Me.txt_module_id.Location = New System.Drawing.Point(278, 40)
        Me.txt_module_id.Name = "txt_module_id"
        Me.txt_module_id.NoClear = True
        Me.txt_module_id.NoSave = False
        Me.txt_module_id.NumberFormat = "@"
        Me.txt_module_id.Required = True
        Me.txt_module_id.RowData = Nothing
        Me.txt_module_id.Size = New System.Drawing.Size(302, 20)
        Me.txt_module_id.TabIndex = 0
        Me.txt_module_id.TextBrowse = True
        Me.txt_module_id.TextSource = "module_name"
        Me.txt_module_id.ToUpper = True
        Me.txt_module_id.Unique = False
        Me.txt_module_id.Value = ""
        Me.txt_module_id.ValueSource = "module_id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Transaction"
        '
        'approvalsetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 602)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_module_id)
        Me.Controls.Add(Me.MyButton3)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.MyButton4)
        Me.Controls.Add(Me.MyButton5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Label1)
        Me.CustomQuery = "[approval_setup]"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MyDGView = Me.dgMain
        Me.MyFilter = "txt_module_id"
        Me.MyTable = "sys_erp_approval"
        Me.Name = "approvalsetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Setup"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sys_erp_approval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sys_erp_approval_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txt_approval_order.ResumeLayout(False)
        Me.txt_approval_order.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents dgSub As System.Windows.Forms.DataGridView
    Friend WithEvents stage_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stage_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents approval_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents MyPanel1 As user_control.MyPanel
    Friend WithEvents MyButton3 As user_control.MyButton
    Friend WithEvents MyButton2 As user_control.MyButton
    Friend WithEvents MyButton1 As user_control.MyButton
    Friend WithEvents MyButton4 As user_control.MyButton
    Friend WithEvents MyButton5 As user_control.MyButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_stage_name As user_control.MyTextBox
    Friend WithEvents txt_stage_id As user_control.MyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_approval_id As user_control.MyTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_order_no As user_control.MyTextBox
    Friend WithEvents txt_approval_order As user_control.MyRadioGroup
    Friend WithEvents MyRadioButton2 As user_control.MyRadioButton
    Friend WithEvents MyRadioButton1 As user_control.MyRadioButton
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents approval_user_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_order_no_det As user_control.MyTextBox
    Friend WithEvents txt_user_fullname As user_control.MyTextBox
    Friend WithEvents txt_user_id As user_control.MyTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_approval_user_id As user_control.MyTextBox
    Friend WithEvents MyButton6 As user_control.MyButton
    Friend WithEvents MyButton9 As user_control.MyButton
    Friend WithEvents MyButton10 As user_control.MyButton
    Friend WithEvents MyButton7 As user_control.MyButton
    Friend WithEvents MyButton8 As user_control.MyButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_module_id As user_control.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
