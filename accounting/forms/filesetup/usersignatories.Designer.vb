<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usersignatories
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.module_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.sys_erp_user_signatory = New System.Data.DataTable()
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
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.sys_erp_modules = New System.Data.DataTable()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.hdr = New System.Windows.Forms.Panel()
        Me.txt_module_id = New user_control.MyTextBox()
        Me.txt_user_id = New user_control.MyTextBox()
        Me.txt_user_signatory_id = New user_control.MyTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MyTextBox10 = New user_control.MyTextBox()
        Me.MyTextBox11 = New user_control.MyTextBox()
        Me.MyTextBox12 = New user_control.MyTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MyTextBox7 = New user_control.MyTextBox()
        Me.MyTextBox8 = New user_control.MyTextBox()
        Me.MyTextBox9 = New user_control.MyTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MyTextBox13 = New user_control.MyTextBox()
        Me.MyTextBox14 = New user_control.MyTextBox()
        Me.MyTextBox15 = New user_control.MyTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MyTextBox4 = New user_control.MyTextBox()
        Me.MyTextBox5 = New user_control.MyTextBox()
        Me.MyTextBox6 = New user_control.MyTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MyTextBox3 = New user_control.MyTextBox()
        Me.MyTextBox2 = New user_control.MyTextBox()
        Me.MyTextBox1 = New user_control.MyTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sys_erp_user_signatory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sys_erp_modules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hdr.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 25)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "User Signatories"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(650, 28)
        Me.Myformheader1.TabIndex = 88
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.AutoGenerateColumns = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.module_id, Me.module_name})
        Me.dgMain.DataSource = Me.ds
        Me.dgMain.Location = New System.Drawing.Point(12, 63)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(626, 150)
        Me.dgMain.TabIndex = 1
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "sel"
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'module_id
        '
        Me.module_id.DataPropertyName = "module_id"
        Me.module_id.HeaderText = "module_id"
        Me.module_id.Name = "module_id"
        Me.module_id.ReadOnly = True
        Me.module_id.Visible = False
        '
        'module_name
        '
        Me.module_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.module_name.DataPropertyName = "module_name"
        Me.module_name.HeaderText = "Module Name"
        Me.module_name.Name = "module_name"
        Me.module_name.ReadOnly = True
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.sys_erp_user_signatory, Me.sys_erp_modules})
        '
        'sys_erp_user_signatory
        '
        Me.sys_erp_user_signatory.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33})
        Me.sys_erp_user_signatory.TableName = "sys_erp_user_signatory"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "user_signatory_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "user_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "module_id"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "label1"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "label2"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "label3"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "label4"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "label5"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "user_id1"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "user_id2"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "user_id3"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "user_id4"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "user_id5"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "position1"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "position2"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "position3"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "position4"
        Me.DataColumn18.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "position5"
        Me.DataColumn19.DefaultValue = ""
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "username"
        Me.DataColumn20.DefaultValue = ""
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "username1"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "username2"
        Me.DataColumn22.DefaultValue = ""
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "username3"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "username4"
        Me.DataColumn24.DefaultValue = ""
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "username5"
        Me.DataColumn25.DefaultValue = ""
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "user_fullname"
        Me.DataColumn26.DefaultValue = ""
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "user_fullname1"
        Me.DataColumn27.DefaultValue = ""
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "user_fullname2"
        Me.DataColumn28.DefaultValue = ""
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "user_fullname3"
        Me.DataColumn29.DefaultValue = ""
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "user_fullname4"
        Me.DataColumn30.DefaultValue = ""
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "user_fullname5"
        Me.DataColumn31.DefaultValue = ""
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "module_code"
        Me.DataColumn32.DefaultValue = ""
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "module_name"
        Me.DataColumn33.DefaultValue = ""
        '
        'sys_erp_modules
        '
        Me.sys_erp_modules.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn34, Me.DataColumn35, Me.DataColumn36})
        Me.sys_erp_modules.TableName = "sys_erp_modules"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "module_id"
        Me.DataColumn34.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "module_code"
        Me.DataColumn35.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "module_name"
        Me.DataColumn36.DefaultValue = ""
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(98, 219)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Tag = ""
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAs.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAs.ForeColor = System.Drawing.Color.White
        Me.btnSaveAs.Location = New System.Drawing.Point(12, 219)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(80, 24)
        Me.btnSaveAs.TabIndex = 2
        Me.btnSaveAs.Tag = ""
        Me.btnSaveAs.Text = "F2 Save As"
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 219)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 99
        Me.btnNotSave.Tag = ""
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 219)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 98
        Me.btnSave.Tag = ""
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'hdr
        '
        Me.hdr.Controls.Add(Me.txt_module_id)
        Me.hdr.Controls.Add(Me.txt_user_id)
        Me.hdr.Controls.Add(Me.txt_user_signatory_id)
        Me.hdr.Controls.Add(Me.GroupBox4)
        Me.hdr.Controls.Add(Me.GroupBox3)
        Me.hdr.Controls.Add(Me.GroupBox5)
        Me.hdr.Controls.Add(Me.GroupBox2)
        Me.hdr.Controls.Add(Me.GroupBox1)
        Me.hdr.Location = New System.Drawing.Point(12, 249)
        Me.hdr.Name = "hdr"
        Me.hdr.Size = New System.Drawing.Size(626, 219)
        Me.hdr.TabIndex = 4
        '
        'txt_module_id
        '
        Me.txt_module_id.AlwaysDisable = False
        Me.txt_module_id.AlwaysEnable = False
        Me.txt_module_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_module_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_module_id.BrowseDataSource = ""
        Me.txt_module_id.BrowseField = ""
        Me.txt_module_id.BrowseFilter = Nothing
        Me.txt_module_id.BrowseLabel = "Code,Name"
        Me.txt_module_id.BrowseLabelWidth = "100,200"
        Me.txt_module_id.BrowseTextSource = ""
        Me.txt_module_id.BrowseValueSource = ""
        Me.txt_module_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_module_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_module_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_module_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_module_id.Enabled = False
        Me.txt_module_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_module_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_module_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_module_id.ID = False
        Me.txt_module_id.Location = New System.Drawing.Point(7, 162)
        Me.txt_module_id.Name = "txt_module_id"
        Me.txt_module_id.NoClear = False
        Me.txt_module_id.NoSave = False
        Me.txt_module_id.NumberFormat = "@"
        Me.txt_module_id.Required = False
        Me.txt_module_id.RowData = Nothing
        Me.txt_module_id.Size = New System.Drawing.Size(97, 19)
        Me.txt_module_id.TabIndex = 3
        Me.txt_module_id.TextBrowse = False
        Me.txt_module_id.TextSource = "module_id"
        Me.txt_module_id.ToUpper = False
        Me.txt_module_id.Unique = False
        Me.txt_module_id.Value = ""
        Me.txt_module_id.ValueSource = ""
        Me.txt_module_id.Visible = False
        '
        'txt_user_id
        '
        Me.txt_user_id.AlwaysDisable = False
        Me.txt_user_id.AlwaysEnable = False
        Me.txt_user_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_id.BrowseDataSource = ""
        Me.txt_user_id.BrowseField = ""
        Me.txt_user_id.BrowseFilter = Nothing
        Me.txt_user_id.BrowseLabel = "Code,Name"
        Me.txt_user_id.BrowseLabelWidth = "100,200"
        Me.txt_user_id.BrowseTextSource = ""
        Me.txt_user_id.BrowseValueSource = ""
        Me.txt_user_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_user_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_id.Enabled = False
        Me.txt_user_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_user_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_id.ID = False
        Me.txt_user_id.Location = New System.Drawing.Point(7, 137)
        Me.txt_user_id.Name = "txt_user_id"
        Me.txt_user_id.NoClear = False
        Me.txt_user_id.NoSave = False
        Me.txt_user_id.NumberFormat = "@"
        Me.txt_user_id.Required = False
        Me.txt_user_id.RowData = Nothing
        Me.txt_user_id.Size = New System.Drawing.Size(97, 19)
        Me.txt_user_id.TabIndex = 2
        Me.txt_user_id.TextBrowse = False
        Me.txt_user_id.TextSource = "user_id"
        Me.txt_user_id.ToUpper = False
        Me.txt_user_id.Unique = False
        Me.txt_user_id.Value = ""
        Me.txt_user_id.ValueSource = ""
        Me.txt_user_id.Visible = False
        '
        'txt_user_signatory_id
        '
        Me.txt_user_signatory_id.AlwaysDisable = False
        Me.txt_user_signatory_id.AlwaysEnable = False
        Me.txt_user_signatory_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_signatory_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_signatory_id.BrowseDataSource = ""
        Me.txt_user_signatory_id.BrowseField = ""
        Me.txt_user_signatory_id.BrowseFilter = Nothing
        Me.txt_user_signatory_id.BrowseLabel = "Code,Name"
        Me.txt_user_signatory_id.BrowseLabelWidth = "100,200"
        Me.txt_user_signatory_id.BrowseTextSource = ""
        Me.txt_user_signatory_id.BrowseValueSource = ""
        Me.txt_user_signatory_id.Database = user_control.MyList.Database.FileSetup
        Me.txt_user_signatory_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_user_signatory_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_user_signatory_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_signatory_id.Enabled = False
        Me.txt_user_signatory_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_user_signatory_id.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_user_signatory_id.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_user_signatory_id.ID = True
        Me.txt_user_signatory_id.Location = New System.Drawing.Point(7, 112)
        Me.txt_user_signatory_id.Name = "txt_user_signatory_id"
        Me.txt_user_signatory_id.NoClear = False
        Me.txt_user_signatory_id.NoSave = False
        Me.txt_user_signatory_id.NumberFormat = "@"
        Me.txt_user_signatory_id.Required = False
        Me.txt_user_signatory_id.RowData = Nothing
        Me.txt_user_signatory_id.Size = New System.Drawing.Size(97, 19)
        Me.txt_user_signatory_id.TabIndex = 1
        Me.txt_user_signatory_id.TextBrowse = False
        Me.txt_user_signatory_id.TextSource = "user_signatory_id"
        Me.txt_user_signatory_id.ToUpper = False
        Me.txt_user_signatory_id.Unique = False
        Me.txt_user_signatory_id.Value = ""
        Me.txt_user_signatory_id.ValueSource = ""
        Me.txt_user_signatory_id.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MyTextBox10)
        Me.GroupBox4.Controls.Add(Me.MyTextBox11)
        Me.GroupBox4.Controls.Add(Me.MyTextBox12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(316, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Signatory 5"
        '
        'MyTextBox10
        '
        Me.MyTextBox10.AlwaysDisable = False
        Me.MyTextBox10.AlwaysEnable = False
        Me.MyTextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox10.BrowseDataSource = ""
        Me.MyTextBox10.BrowseField = ""
        Me.MyTextBox10.BrowseFilter = Nothing
        Me.MyTextBox10.BrowseLabel = "Code,Name"
        Me.MyTextBox10.BrowseLabelWidth = "100,200"
        Me.MyTextBox10.BrowseTextSource = ""
        Me.MyTextBox10.BrowseValueSource = ""
        Me.MyTextBox10.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox10.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox10.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox10.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox10.Enabled = False
        Me.MyTextBox10.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox10.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox10.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox10.ID = False
        Me.MyTextBox10.Location = New System.Drawing.Point(57, 61)
        Me.MyTextBox10.Name = "MyTextBox10"
        Me.MyTextBox10.NoClear = False
        Me.MyTextBox10.NoSave = False
        Me.MyTextBox10.NumberFormat = "@"
        Me.MyTextBox10.Required = False
        Me.MyTextBox10.RowData = Nothing
        Me.MyTextBox10.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox10.TabIndex = 22
        Me.MyTextBox10.TextBrowse = False
        Me.MyTextBox10.TextSource = "position5"
        Me.MyTextBox10.ToUpper = True
        Me.MyTextBox10.Unique = False
        Me.MyTextBox10.Value = ""
        Me.MyTextBox10.ValueSource = ""
        '
        'MyTextBox11
        '
        Me.MyTextBox11.AlwaysDisable = False
        Me.MyTextBox11.AlwaysEnable = False
        Me.MyTextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox11.BrowseDataSource = "sys_erp_user"
        Me.MyTextBox11.BrowseField = "username,user_fullname"
        Me.MyTextBox11.BrowseFilter = Nothing
        Me.MyTextBox11.BrowseLabel = "Code,Name"
        Me.MyTextBox11.BrowseLabelWidth = "100,200"
        Me.MyTextBox11.BrowseTextSource = "user_fullname"
        Me.MyTextBox11.BrowseValueSource = "user_id"
        Me.MyTextBox11.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox11.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox11.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox11.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox11.Enabled = False
        Me.MyTextBox11.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox11.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox11.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox11.ID = False
        Me.MyTextBox11.Location = New System.Drawing.Point(57, 41)
        Me.MyTextBox11.Name = "MyTextBox11"
        Me.MyTextBox11.NoClear = False
        Me.MyTextBox11.NoSave = False
        Me.MyTextBox11.NumberFormat = "@"
        Me.MyTextBox11.Required = False
        Me.MyTextBox11.RowData = Nothing
        Me.MyTextBox11.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox11.TabIndex = 21
        Me.MyTextBox11.TextBrowse = True
        Me.MyTextBox11.TextSource = "user_fullname5"
        Me.MyTextBox11.ToUpper = True
        Me.MyTextBox11.Unique = False
        Me.MyTextBox11.Value = ""
        Me.MyTextBox11.ValueSource = "user_id5"
        '
        'MyTextBox12
        '
        Me.MyTextBox12.AlwaysDisable = False
        Me.MyTextBox12.AlwaysEnable = False
        Me.MyTextBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox12.BrowseDataSource = ""
        Me.MyTextBox12.BrowseField = ""
        Me.MyTextBox12.BrowseFilter = Nothing
        Me.MyTextBox12.BrowseLabel = "Code,Name"
        Me.MyTextBox12.BrowseLabelWidth = "100,200"
        Me.MyTextBox12.BrowseTextSource = ""
        Me.MyTextBox12.BrowseValueSource = ""
        Me.MyTextBox12.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox12.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox12.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox12.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox12.Enabled = False
        Me.MyTextBox12.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox12.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox12.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox12.ID = False
        Me.MyTextBox12.Location = New System.Drawing.Point(57, 21)
        Me.MyTextBox12.Name = "MyTextBox12"
        Me.MyTextBox12.NoClear = False
        Me.MyTextBox12.NoSave = False
        Me.MyTextBox12.NumberFormat = "@"
        Me.MyTextBox12.Required = False
        Me.MyTextBox12.RowData = Nothing
        Me.MyTextBox12.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox12.TabIndex = 20
        Me.MyTextBox12.TextBrowse = False
        Me.MyTextBox12.TextSource = "label5"
        Me.MyTextBox12.ToUpper = True
        Me.MyTextBox12.Unique = False
        Me.MyTextBox12.Value = ""
        Me.MyTextBox12.ValueSource = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 12)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Position"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 12)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "User"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 12)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Label"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MyTextBox7)
        Me.GroupBox3.Controls.Add(Me.MyTextBox8)
        Me.GroupBox3.Controls.Add(Me.MyTextBox9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(419, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Signatory 3"
        '
        'MyTextBox7
        '
        Me.MyTextBox7.AlwaysDisable = False
        Me.MyTextBox7.AlwaysEnable = False
        Me.MyTextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox7.BrowseDataSource = ""
        Me.MyTextBox7.BrowseField = ""
        Me.MyTextBox7.BrowseFilter = Nothing
        Me.MyTextBox7.BrowseLabel = "Code,Name"
        Me.MyTextBox7.BrowseLabelWidth = "100,200"
        Me.MyTextBox7.BrowseTextSource = ""
        Me.MyTextBox7.BrowseValueSource = ""
        Me.MyTextBox7.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox7.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox7.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox7.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox7.Enabled = False
        Me.MyTextBox7.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox7.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox7.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox7.ID = False
        Me.MyTextBox7.Location = New System.Drawing.Point(57, 61)
        Me.MyTextBox7.Name = "MyTextBox7"
        Me.MyTextBox7.NoClear = False
        Me.MyTextBox7.NoSave = False
        Me.MyTextBox7.NumberFormat = "@"
        Me.MyTextBox7.Required = False
        Me.MyTextBox7.RowData = Nothing
        Me.MyTextBox7.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox7.TabIndex = 14
        Me.MyTextBox7.TextBrowse = False
        Me.MyTextBox7.TextSource = "position3"
        Me.MyTextBox7.ToUpper = True
        Me.MyTextBox7.Unique = False
        Me.MyTextBox7.Value = ""
        Me.MyTextBox7.ValueSource = ""
        '
        'MyTextBox8
        '
        Me.MyTextBox8.AlwaysDisable = False
        Me.MyTextBox8.AlwaysEnable = False
        Me.MyTextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox8.BrowseDataSource = "sys_erp_user"
        Me.MyTextBox8.BrowseField = "username,user_fullname"
        Me.MyTextBox8.BrowseFilter = Nothing
        Me.MyTextBox8.BrowseLabel = "Code,Name"
        Me.MyTextBox8.BrowseLabelWidth = "100,200"
        Me.MyTextBox8.BrowseTextSource = "user_fullname"
        Me.MyTextBox8.BrowseValueSource = "user_id"
        Me.MyTextBox8.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox8.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox8.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox8.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox8.Enabled = False
        Me.MyTextBox8.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox8.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox8.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox8.ID = False
        Me.MyTextBox8.Location = New System.Drawing.Point(57, 41)
        Me.MyTextBox8.Name = "MyTextBox8"
        Me.MyTextBox8.NoClear = False
        Me.MyTextBox8.NoSave = False
        Me.MyTextBox8.NumberFormat = "@"
        Me.MyTextBox8.Required = False
        Me.MyTextBox8.RowData = Nothing
        Me.MyTextBox8.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox8.TabIndex = 13
        Me.MyTextBox8.TextBrowse = True
        Me.MyTextBox8.TextSource = "user_fullname3"
        Me.MyTextBox8.ToUpper = True
        Me.MyTextBox8.Unique = False
        Me.MyTextBox8.Value = ""
        Me.MyTextBox8.ValueSource = "user_id3"
        '
        'MyTextBox9
        '
        Me.MyTextBox9.AlwaysDisable = False
        Me.MyTextBox9.AlwaysEnable = False
        Me.MyTextBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox9.BrowseDataSource = ""
        Me.MyTextBox9.BrowseField = ""
        Me.MyTextBox9.BrowseFilter = Nothing
        Me.MyTextBox9.BrowseLabel = "Code,Name"
        Me.MyTextBox9.BrowseLabelWidth = "100,200"
        Me.MyTextBox9.BrowseTextSource = ""
        Me.MyTextBox9.BrowseValueSource = ""
        Me.MyTextBox9.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox9.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox9.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox9.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox9.Enabled = False
        Me.MyTextBox9.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox9.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox9.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox9.ID = False
        Me.MyTextBox9.Location = New System.Drawing.Point(57, 21)
        Me.MyTextBox9.Name = "MyTextBox9"
        Me.MyTextBox9.NoClear = False
        Me.MyTextBox9.NoSave = False
        Me.MyTextBox9.NumberFormat = "@"
        Me.MyTextBox9.Required = False
        Me.MyTextBox9.RowData = Nothing
        Me.MyTextBox9.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox9.TabIndex = 12
        Me.MyTextBox9.TextBrowse = False
        Me.MyTextBox9.TextSource = "label3"
        Me.MyTextBox9.ToUpper = True
        Me.MyTextBox9.Unique = False
        Me.MyTextBox9.Value = ""
        Me.MyTextBox9.ValueSource = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Position"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 12)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "User"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 12)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Label"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MyTextBox13)
        Me.GroupBox5.Controls.Add(Me.MyTextBox14)
        Me.GroupBox5.Controls.Add(Me.MyTextBox15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Location = New System.Drawing.Point(110, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Signatory 4"
        '
        'MyTextBox13
        '
        Me.MyTextBox13.AlwaysDisable = False
        Me.MyTextBox13.AlwaysEnable = False
        Me.MyTextBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox13.BrowseDataSource = ""
        Me.MyTextBox13.BrowseField = ""
        Me.MyTextBox13.BrowseFilter = Nothing
        Me.MyTextBox13.BrowseLabel = "Code,Name"
        Me.MyTextBox13.BrowseLabelWidth = "100,200"
        Me.MyTextBox13.BrowseTextSource = ""
        Me.MyTextBox13.BrowseValueSource = ""
        Me.MyTextBox13.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox13.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox13.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox13.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox13.Enabled = False
        Me.MyTextBox13.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox13.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox13.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox13.ID = False
        Me.MyTextBox13.Location = New System.Drawing.Point(57, 61)
        Me.MyTextBox13.Name = "MyTextBox13"
        Me.MyTextBox13.NoClear = False
        Me.MyTextBox13.NoSave = False
        Me.MyTextBox13.NumberFormat = "@"
        Me.MyTextBox13.Required = False
        Me.MyTextBox13.RowData = Nothing
        Me.MyTextBox13.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox13.TabIndex = 18
        Me.MyTextBox13.TextBrowse = False
        Me.MyTextBox13.TextSource = "position4"
        Me.MyTextBox13.ToUpper = True
        Me.MyTextBox13.Unique = False
        Me.MyTextBox13.Value = ""
        Me.MyTextBox13.ValueSource = ""
        '
        'MyTextBox14
        '
        Me.MyTextBox14.AlwaysDisable = False
        Me.MyTextBox14.AlwaysEnable = False
        Me.MyTextBox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox14.BrowseDataSource = "sys_erp_user"
        Me.MyTextBox14.BrowseField = "username,user_fullname"
        Me.MyTextBox14.BrowseFilter = Nothing
        Me.MyTextBox14.BrowseLabel = "Code,Name"
        Me.MyTextBox14.BrowseLabelWidth = "100,200"
        Me.MyTextBox14.BrowseTextSource = "user_fullname"
        Me.MyTextBox14.BrowseValueSource = "user_id"
        Me.MyTextBox14.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox14.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox14.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox14.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox14.Enabled = False
        Me.MyTextBox14.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox14.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox14.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox14.ID = False
        Me.MyTextBox14.Location = New System.Drawing.Point(57, 41)
        Me.MyTextBox14.Name = "MyTextBox14"
        Me.MyTextBox14.NoClear = False
        Me.MyTextBox14.NoSave = False
        Me.MyTextBox14.NumberFormat = "@"
        Me.MyTextBox14.Required = False
        Me.MyTextBox14.RowData = Nothing
        Me.MyTextBox14.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox14.TabIndex = 17
        Me.MyTextBox14.TextBrowse = True
        Me.MyTextBox14.TextSource = "user_fullname4"
        Me.MyTextBox14.ToUpper = True
        Me.MyTextBox14.Unique = False
        Me.MyTextBox14.Value = ""
        Me.MyTextBox14.ValueSource = "user_id4"
        '
        'MyTextBox15
        '
        Me.MyTextBox15.AlwaysDisable = False
        Me.MyTextBox15.AlwaysEnable = False
        Me.MyTextBox15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox15.BrowseDataSource = ""
        Me.MyTextBox15.BrowseField = ""
        Me.MyTextBox15.BrowseFilter = Nothing
        Me.MyTextBox15.BrowseLabel = "Code,Name"
        Me.MyTextBox15.BrowseLabelWidth = "100,200"
        Me.MyTextBox15.BrowseTextSource = ""
        Me.MyTextBox15.BrowseValueSource = ""
        Me.MyTextBox15.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox15.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox15.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox15.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox15.Enabled = False
        Me.MyTextBox15.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox15.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox15.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox15.ID = False
        Me.MyTextBox15.Location = New System.Drawing.Point(57, 21)
        Me.MyTextBox15.Name = "MyTextBox15"
        Me.MyTextBox15.NoClear = False
        Me.MyTextBox15.NoSave = False
        Me.MyTextBox15.NumberFormat = "@"
        Me.MyTextBox15.Required = False
        Me.MyTextBox15.RowData = Nothing
        Me.MyTextBox15.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox15.TabIndex = 16
        Me.MyTextBox15.TextBrowse = False
        Me.MyTextBox15.TextSource = "label4"
        Me.MyTextBox15.ToUpper = True
        Me.MyTextBox15.Unique = False
        Me.MyTextBox15.Value = ""
        Me.MyTextBox15.ValueSource = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 12)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Position"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 12)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "User"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 12)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Label"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MyTextBox4)
        Me.GroupBox2.Controls.Add(Me.MyTextBox5)
        Me.GroupBox2.Controls.Add(Me.MyTextBox6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(213, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Signatory 2"
        '
        'MyTextBox4
        '
        Me.MyTextBox4.AlwaysDisable = False
        Me.MyTextBox4.AlwaysEnable = False
        Me.MyTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox4.BrowseDataSource = ""
        Me.MyTextBox4.BrowseField = ""
        Me.MyTextBox4.BrowseFilter = Nothing
        Me.MyTextBox4.BrowseLabel = "Code,Name"
        Me.MyTextBox4.BrowseLabelWidth = "100,200"
        Me.MyTextBox4.BrowseTextSource = ""
        Me.MyTextBox4.BrowseValueSource = ""
        Me.MyTextBox4.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox4.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox4.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox4.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox4.Enabled = False
        Me.MyTextBox4.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox4.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox4.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox4.ID = False
        Me.MyTextBox4.Location = New System.Drawing.Point(57, 61)
        Me.MyTextBox4.Name = "MyTextBox4"
        Me.MyTextBox4.NoClear = False
        Me.MyTextBox4.NoSave = False
        Me.MyTextBox4.NumberFormat = "@"
        Me.MyTextBox4.Required = False
        Me.MyTextBox4.RowData = Nothing
        Me.MyTextBox4.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox4.TabIndex = 10
        Me.MyTextBox4.TextBrowse = False
        Me.MyTextBox4.TextSource = "position2"
        Me.MyTextBox4.ToUpper = True
        Me.MyTextBox4.Unique = False
        Me.MyTextBox4.Value = ""
        Me.MyTextBox4.ValueSource = ""
        '
        'MyTextBox5
        '
        Me.MyTextBox5.AlwaysDisable = False
        Me.MyTextBox5.AlwaysEnable = False
        Me.MyTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox5.BrowseDataSource = "sys_erp_user"
        Me.MyTextBox5.BrowseField = "username,user_fullname"
        Me.MyTextBox5.BrowseFilter = Nothing
        Me.MyTextBox5.BrowseLabel = "Code,Name"
        Me.MyTextBox5.BrowseLabelWidth = "100,200"
        Me.MyTextBox5.BrowseTextSource = "user_fullname"
        Me.MyTextBox5.BrowseValueSource = "user_id"
        Me.MyTextBox5.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox5.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox5.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox5.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox5.Enabled = False
        Me.MyTextBox5.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox5.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox5.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox5.ID = False
        Me.MyTextBox5.Location = New System.Drawing.Point(57, 41)
        Me.MyTextBox5.Name = "MyTextBox5"
        Me.MyTextBox5.NoClear = False
        Me.MyTextBox5.NoSave = False
        Me.MyTextBox5.NumberFormat = "@"
        Me.MyTextBox5.Required = False
        Me.MyTextBox5.RowData = Nothing
        Me.MyTextBox5.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox5.TabIndex = 9
        Me.MyTextBox5.TextBrowse = True
        Me.MyTextBox5.TextSource = "user_fullname2"
        Me.MyTextBox5.ToUpper = True
        Me.MyTextBox5.Unique = False
        Me.MyTextBox5.Value = ""
        Me.MyTextBox5.ValueSource = "user_id2"
        '
        'MyTextBox6
        '
        Me.MyTextBox6.AlwaysDisable = False
        Me.MyTextBox6.AlwaysEnable = False
        Me.MyTextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox6.BrowseDataSource = ""
        Me.MyTextBox6.BrowseField = ""
        Me.MyTextBox6.BrowseFilter = Nothing
        Me.MyTextBox6.BrowseLabel = "Code,Name"
        Me.MyTextBox6.BrowseLabelWidth = "100,200"
        Me.MyTextBox6.BrowseTextSource = ""
        Me.MyTextBox6.BrowseValueSource = ""
        Me.MyTextBox6.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox6.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox6.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox6.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox6.Enabled = False
        Me.MyTextBox6.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox6.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox6.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox6.ID = False
        Me.MyTextBox6.Location = New System.Drawing.Point(57, 21)
        Me.MyTextBox6.Name = "MyTextBox6"
        Me.MyTextBox6.NoClear = False
        Me.MyTextBox6.NoSave = False
        Me.MyTextBox6.NumberFormat = "@"
        Me.MyTextBox6.Required = False
        Me.MyTextBox6.RowData = Nothing
        Me.MyTextBox6.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox6.TabIndex = 8
        Me.MyTextBox6.TextBrowse = False
        Me.MyTextBox6.TextSource = "label2"
        Me.MyTextBox6.ToUpper = True
        Me.MyTextBox6.Unique = False
        Me.MyTextBox6.Value = ""
        Me.MyTextBox6.ValueSource = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "User"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Label"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MyTextBox3)
        Me.GroupBox1.Controls.Add(Me.MyTextBox2)
        Me.GroupBox1.Controls.Add(Me.MyTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Signatory 1"
        '
        'MyTextBox3
        '
        Me.MyTextBox3.AlwaysDisable = False
        Me.MyTextBox3.AlwaysEnable = False
        Me.MyTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox3.BrowseDataSource = ""
        Me.MyTextBox3.BrowseField = ""
        Me.MyTextBox3.BrowseFilter = Nothing
        Me.MyTextBox3.BrowseLabel = "Code,Name"
        Me.MyTextBox3.BrowseLabelWidth = "100,200"
        Me.MyTextBox3.BrowseTextSource = ""
        Me.MyTextBox3.BrowseValueSource = ""
        Me.MyTextBox3.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox3.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox3.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox3.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox3.Enabled = False
        Me.MyTextBox3.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox3.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox3.ID = False
        Me.MyTextBox3.Location = New System.Drawing.Point(57, 61)
        Me.MyTextBox3.Name = "MyTextBox3"
        Me.MyTextBox3.NoClear = False
        Me.MyTextBox3.NoSave = False
        Me.MyTextBox3.NumberFormat = "@"
        Me.MyTextBox3.Required = False
        Me.MyTextBox3.RowData = Nothing
        Me.MyTextBox3.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox3.TabIndex = 7
        Me.MyTextBox3.TextBrowse = False
        Me.MyTextBox3.TextSource = "position1"
        Me.MyTextBox3.ToUpper = True
        Me.MyTextBox3.Unique = False
        Me.MyTextBox3.Value = ""
        Me.MyTextBox3.ValueSource = ""
        '
        'MyTextBox2
        '
        Me.MyTextBox2.AlwaysDisable = False
        Me.MyTextBox2.AlwaysEnable = False
        Me.MyTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox2.BrowseDataSource = "sys_erp_user"
        Me.MyTextBox2.BrowseField = "username,user_fullname"
        Me.MyTextBox2.BrowseFilter = Nothing
        Me.MyTextBox2.BrowseLabel = "Code,Name"
        Me.MyTextBox2.BrowseLabelWidth = "100,200"
        Me.MyTextBox2.BrowseTextSource = "user_fullname"
        Me.MyTextBox2.BrowseValueSource = "user_id"
        Me.MyTextBox2.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox2.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox2.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox2.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox2.Enabled = False
        Me.MyTextBox2.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox2.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox2.ID = False
        Me.MyTextBox2.Location = New System.Drawing.Point(57, 41)
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.NoClear = False
        Me.MyTextBox2.NoSave = False
        Me.MyTextBox2.NumberFormat = "@"
        Me.MyTextBox2.Required = False
        Me.MyTextBox2.RowData = Nothing
        Me.MyTextBox2.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox2.TabIndex = 6
        Me.MyTextBox2.TextBrowse = True
        Me.MyTextBox2.TextSource = "user_fullname1"
        Me.MyTextBox2.ToUpper = True
        Me.MyTextBox2.Unique = False
        Me.MyTextBox2.Value = ""
        Me.MyTextBox2.ValueSource = "user_id1"
        '
        'MyTextBox1
        '
        Me.MyTextBox1.AlwaysDisable = False
        Me.MyTextBox1.AlwaysEnable = False
        Me.MyTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox1.BrowseDataSource = ""
        Me.MyTextBox1.BrowseField = ""
        Me.MyTextBox1.BrowseFilter = Nothing
        Me.MyTextBox1.BrowseLabel = "Code,Name"
        Me.MyTextBox1.BrowseLabelWidth = "100,200"
        Me.MyTextBox1.BrowseTextSource = ""
        Me.MyTextBox1.BrowseValueSource = ""
        Me.MyTextBox1.Database = user_control.MyList.Database.FileSetup
        Me.MyTextBox1.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MyTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyTextBox1.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox1.Enabled = False
        Me.MyTextBox1.EnabledBackColor = System.Drawing.Color.White
        Me.MyTextBox1.EnabledForeColor = System.Drawing.Color.Black
        Me.MyTextBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.MyTextBox1.ID = False
        Me.MyTextBox1.Location = New System.Drawing.Point(57, 21)
        Me.MyTextBox1.Name = "MyTextBox1"
        Me.MyTextBox1.NoClear = False
        Me.MyTextBox1.NoSave = False
        Me.MyTextBox1.NumberFormat = "@"
        Me.MyTextBox1.Required = False
        Me.MyTextBox1.RowData = Nothing
        Me.MyTextBox1.Size = New System.Drawing.Size(130, 19)
        Me.MyTextBox1.TabIndex = 5
        Me.MyTextBox1.TextBrowse = False
        Me.MyTextBox1.TextSource = "label1"
        Me.MyTextBox1.ToUpper = True
        Me.MyTextBox1.Unique = False
        Me.MyTextBox1.Value = ""
        Me.MyTextBox1.ValueSource = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(18, 58)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(620, 2)
        Me.border1.TabIndex = 82
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usersignatories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 480)
        Me.Controls.Add(Me.hdr)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSaveAs)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "usersignatories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Signatories"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sys_erp_user_signatory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sys_erp_modules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hdr.ResumeLayout(False)
        Me.hdr.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents hdr As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox10 As user_control.MyTextBox
    Friend WithEvents MyTextBox11 As user_control.MyTextBox
    Friend WithEvents MyTextBox12 As user_control.MyTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox7 As user_control.MyTextBox
    Friend WithEvents MyTextBox8 As user_control.MyTextBox
    Friend WithEvents MyTextBox9 As user_control.MyTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox13 As user_control.MyTextBox
    Friend WithEvents MyTextBox14 As user_control.MyTextBox
    Friend WithEvents MyTextBox15 As user_control.MyTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox4 As user_control.MyTextBox
    Friend WithEvents MyTextBox5 As user_control.MyTextBox
    Friend WithEvents MyTextBox6 As user_control.MyTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTextBox3 As user_control.MyTextBox
    Friend WithEvents MyTextBox2 As user_control.MyTextBox
    Friend WithEvents MyTextBox1 As user_control.MyTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_user_signatory_id As user_control.MyTextBox
    Friend WithEvents txt_module_id As user_control.MyTextBox
    Friend WithEvents txt_user_id As user_control.MyTextBox
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents sys_erp_user_signatory As System.Data.DataTable
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
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents sys_erp_modules As System.Data.DataTable
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents module_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents module_name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
