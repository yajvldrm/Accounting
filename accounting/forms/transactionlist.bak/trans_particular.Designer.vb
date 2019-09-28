<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trans_particular
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.lbl_trans = New System.Windows.Forms.Label()
        Me.txtdesc = New user_control.textbox()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.trans_particular_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_particular_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_particular_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_particular_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.particular = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.hdr = New System.Windows.Forms.Panel()
        Me.txt_trans_particular_id = New user_control.textbox()
        Me.txt_trans_particular_name = New user_control.textbox()
        Me.txt_trans_particular_amount = New user_control.textbox()
        Me.txt_trans_particular_code = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.border2 = New accounting.borderedlabel()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.particular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hdr.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(458, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'lbl_trans
        '
        Me.lbl_trans.AutoSize = True
        Me.lbl_trans.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbl_trans.Location = New System.Drawing.Point(12, 31)
        Me.lbl_trans.Name = "lbl_trans"
        Me.lbl_trans.Size = New System.Drawing.Size(158, 25)
        Me.lbl_trans.TabIndex = 280
        Me.lbl_trans.Text = "Sales Voucher"
        '
        'txtdesc
        '
        Me.txtdesc._Text = ""
        Me.txtdesc.AlwaysDisable = False
        Me.txtdesc.AlwaysEnable = False
        Me.txtdesc.BackColor = System.Drawing.Color.White
        Me.txtdesc.BorderColor = System.Drawing.Color.DarkGray
        Me.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesc.DataSource = ""
        Me.txtdesc.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdesc.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdesc.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtdesc.EnabledBackColor = System.Drawing.Color.White
        Me.txtdesc.ispk = False
        Me.txtdesc.Location = New System.Drawing.Point(17, 69)
        Me.txtdesc.MultiLine = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.NoClear = False
        Me.txtdesc.NumberFormat = "@"
        Me.txtdesc.Required = False
        Me.txtdesc.RowData = Nothing
        Me.txtdesc.SelectionLength = 0
        Me.txtdesc.SelectionStart = 0
        Me.txtdesc.Size = New System.Drawing.Size(421, 48)
        Me.txtdesc.TabIndex = 283
        Me.txtdesc.TableData = Nothing
        Me.txtdesc.TextSource = "remarks"
        Me.txtdesc.UseSystemPasswordChar = False
        Me.txtdesc.Value = ""
        Me.txtdesc.ValueSource = ""
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.trans_particular_id, Me.trans_particular_code, Me.trans_particular_amount, Me.trans_particular_name, Me.deleted})
        Me.dgMain.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgMain.Location = New System.Drawing.Point(17, 123)
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(421, 100)
        Me.dgMain.TabIndex = 284
        '
        'sel
        '
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'trans_particular_id
        '
        Me.trans_particular_id.DataPropertyName = "trans_particular_id"
        Me.trans_particular_id.HeaderText = "id"
        Me.trans_particular_id.Name = "trans_particular_id"
        Me.trans_particular_id.ReadOnly = True
        Me.trans_particular_id.Visible = False
        '
        'trans_particular_code
        '
        Me.trans_particular_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.trans_particular_code.DataPropertyName = "trans_particular_code"
        Me.trans_particular_code.HeaderText = "Particular"
        Me.trans_particular_code.Name = "trans_particular_code"
        Me.trans_particular_code.ReadOnly = True
        '
        'trans_particular_amount
        '
        Me.trans_particular_amount.DataPropertyName = "trans_particular_amount"
        Me.trans_particular_amount.HeaderText = "Amount"
        Me.trans_particular_amount.Name = "trans_particular_amount"
        Me.trans_particular_amount.ReadOnly = True
        '
        'trans_particular_name
        '
        Me.trans_particular_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.trans_particular_name.DataPropertyName = "trans_particular_name"
        Me.trans_particular_name.HeaderText = "Description"
        Me.trans_particular_name.Name = "trans_particular_name"
        Me.trans_particular_name.ReadOnly = True
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.deleted.Visible = False
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.particular})
        '
        'particular
        '
        Me.particular.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.particular.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"trans_particular_id"}, True)})
        Me.particular.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.particular.TableName = "particular"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "trans_particular_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "trans_particular_code"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "trans_particular_name"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "trans_particular_amount"
        Me.DataColumn5.DataType = GetType(Decimal)
        Me.DataColumn5.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "deleted"
        Me.DataColumn6.DataType = GetType(Boolean)
        Me.DataColumn6.DefaultValue = False
        '
        'hdr
        '
        Me.hdr.Controls.Add(Me.txt_trans_particular_id)
        Me.hdr.Controls.Add(Me.txt_trans_particular_name)
        Me.hdr.Controls.Add(Me.txt_trans_particular_amount)
        Me.hdr.Controls.Add(Me.txt_trans_particular_code)
        Me.hdr.Controls.Add(Me.Label3)
        Me.hdr.Controls.Add(Me.Label2)
        Me.hdr.Controls.Add(Me.Label1)
        Me.hdr.Location = New System.Drawing.Point(17, 258)
        Me.hdr.Name = "hdr"
        Me.hdr.Size = New System.Drawing.Size(421, 80)
        Me.hdr.TabIndex = 285
        Me.hdr.Tag = "container"
        '
        'txt_trans_particular_id
        '
        Me.txt_trans_particular_id._Text = ""
        Me.txt_trans_particular_id.AlwaysDisable = True
        Me.txt_trans_particular_id.AlwaysEnable = False
        Me.txt_trans_particular_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_particular_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_particular_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_particular_id.DataSource = ""
        Me.txt_trans_particular_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_particular_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_particular_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_particular_id.Enabled = False
        Me.txt_trans_particular_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_particular_id.ispk = True
        Me.txt_trans_particular_id.Location = New System.Drawing.Point(3, 3)
        Me.txt_trans_particular_id.MultiLine = False
        Me.txt_trans_particular_id.Name = "txt_trans_particular_id"
        Me.txt_trans_particular_id.NoClear = False
        Me.txt_trans_particular_id.NumberFormat = "@"
        Me.txt_trans_particular_id.Required = False
        Me.txt_trans_particular_id.RowData = Nothing
        Me.txt_trans_particular_id.SelectionLength = 0
        Me.txt_trans_particular_id.SelectionStart = 0
        Me.txt_trans_particular_id.Size = New System.Drawing.Size(35, 20)
        Me.txt_trans_particular_id.TabIndex = 309
        Me.txt_trans_particular_id.TableData = Nothing
        Me.txt_trans_particular_id.TextSource = "trans_particular_id"
        Me.txt_trans_particular_id.UseSystemPasswordChar = False
        Me.txt_trans_particular_id.Value = ""
        Me.txt_trans_particular_id.ValueSource = ""
        '
        'txt_trans_particular_name
        '
        Me.txt_trans_particular_name._Text = ""
        Me.txt_trans_particular_name.AlwaysDisable = False
        Me.txt_trans_particular_name.AlwaysEnable = False
        Me.txt_trans_particular_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_particular_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_particular_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_particular_name.DataSource = ""
        Me.txt_trans_particular_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_particular_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_particular_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_particular_name.Enabled = False
        Me.txt_trans_particular_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_particular_name.ispk = False
        Me.txt_trans_particular_name.Location = New System.Drawing.Point(76, 43)
        Me.txt_trans_particular_name.MultiLine = False
        Me.txt_trans_particular_name.Name = "txt_trans_particular_name"
        Me.txt_trans_particular_name.NoClear = False
        Me.txt_trans_particular_name.NumberFormat = "@"
        Me.txt_trans_particular_name.Required = False
        Me.txt_trans_particular_name.RowData = Nothing
        Me.txt_trans_particular_name.SelectionLength = 0
        Me.txt_trans_particular_name.SelectionStart = 0
        Me.txt_trans_particular_name.Size = New System.Drawing.Size(335, 20)
        Me.txt_trans_particular_name.TabIndex = 296
        Me.txt_trans_particular_name.TableData = Nothing
        Me.txt_trans_particular_name.TextSource = "trans_particular_name"
        Me.txt_trans_particular_name.UseSystemPasswordChar = False
        Me.txt_trans_particular_name.Value = ""
        Me.txt_trans_particular_name.ValueSource = ""
        '
        'txt_trans_particular_amount
        '
        Me.txt_trans_particular_amount._Text = "0.00"
        Me.txt_trans_particular_amount.AlwaysDisable = False
        Me.txt_trans_particular_amount.AlwaysEnable = False
        Me.txt_trans_particular_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_particular_amount.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_particular_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_particular_amount.DataSource = ""
        Me.txt_trans_particular_amount.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_particular_amount.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_particular_amount.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_particular_amount.Enabled = False
        Me.txt_trans_particular_amount.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_particular_amount.ispk = False
        Me.txt_trans_particular_amount.Location = New System.Drawing.Point(271, 17)
        Me.txt_trans_particular_amount.MultiLine = False
        Me.txt_trans_particular_amount.Name = "txt_trans_particular_amount"
        Me.txt_trans_particular_amount.NoClear = False
        Me.txt_trans_particular_amount.NumberFormat = "##,##0.00"
        Me.txt_trans_particular_amount.Required = False
        Me.txt_trans_particular_amount.RowData = Nothing
        Me.txt_trans_particular_amount.SelectionLength = 0
        Me.txt_trans_particular_amount.SelectionStart = 0
        Me.txt_trans_particular_amount.Size = New System.Drawing.Size(140, 20)
        Me.txt_trans_particular_amount.TabIndex = 295
        Me.txt_trans_particular_amount.TableData = Nothing
        Me.txt_trans_particular_amount.TextSource = "trans_particular_amount"
        Me.txt_trans_particular_amount.UseSystemPasswordChar = False
        Me.txt_trans_particular_amount.Value = "0.00"
        Me.txt_trans_particular_amount.ValueSource = ""
        '
        'txt_trans_particular_code
        '
        Me.txt_trans_particular_code._Text = ""
        Me.txt_trans_particular_code.AlwaysDisable = False
        Me.txt_trans_particular_code.AlwaysEnable = False
        Me.txt_trans_particular_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_particular_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_particular_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_particular_code.DataSource = ""
        Me.txt_trans_particular_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_particular_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_particular_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_particular_code.Enabled = False
        Me.txt_trans_particular_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_particular_code.ispk = False
        Me.txt_trans_particular_code.Location = New System.Drawing.Point(76, 17)
        Me.txt_trans_particular_code.MultiLine = False
        Me.txt_trans_particular_code.Name = "txt_trans_particular_code"
        Me.txt_trans_particular_code.NoClear = False
        Me.txt_trans_particular_code.NumberFormat = "@"
        Me.txt_trans_particular_code.Required = False
        Me.txt_trans_particular_code.RowData = Nothing
        Me.txt_trans_particular_code.SelectionLength = 0
        Me.txt_trans_particular_code.SelectionStart = 0
        Me.txt_trans_particular_code.Size = New System.Drawing.Size(140, 20)
        Me.txt_trans_particular_code.TabIndex = 294
        Me.txt_trans_particular_code.TableData = Nothing
        Me.txt_trans_particular_code.TextSource = "trans_particular_code"
        Me.txt_trans_particular_code.UseSystemPasswordChar = False
        Me.txt_trans_particular_code.Value = ""
        Me.txt_trans_particular_code.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 293
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 292
        Me.Label2.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 291
        Me.Label1.Text = "Particular"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(17, 229)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 23)
        Me.btnAdd.TabIndex = 299
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(103, 229)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 23)
        Me.btnEdit.TabIndex = 300
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(103, 229)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 23)
        Me.btnNotSave.TabIndex = 302
        Me.btnNotSave.Text = "Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        Me.btnNotSave.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(17, 229)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 23)
        Me.btnSave.TabIndex = 301
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(189, 229)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 23)
        Me.btnDelete.TabIndex = 303
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(14, 62)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(424, 2)
        Me.border1.TabIndex = 281
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(14, 64)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(424, 2)
        Me.border2.TabIndex = 282
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trans_particular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 350)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.hdr)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.lbl_trans)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnNotSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "trans_particular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Particular"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.particular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hdr.ResumeLayout(False)
        Me.hdr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents lbl_trans As System.Windows.Forms.Label
    Friend WithEvents txtdesc As user_control.textbox
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents hdr As System.Windows.Forms.Panel
    Friend WithEvents txt_trans_particular_name As user_control.textbox
    Friend WithEvents txt_trans_particular_amount As user_control.textbox
    Friend WithEvents txt_trans_particular_code As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txt_trans_particular_id As user_control.textbox
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents particular As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents trans_particular_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_particular_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_particular_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_particular_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
