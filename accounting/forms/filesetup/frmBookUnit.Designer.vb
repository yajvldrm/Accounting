<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookUnit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_book_unit_no = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.Searchtxt = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.BookunitnoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookunitnocodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookunitnonameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_book_unit_no_name = New user_control.textbox()
        Me.txt_book_unit_no_code = New user_control.textbox()
        Me.txt_book_id = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_book_unit_no_id = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.dgBookUnits = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_unit_no_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_unit_no_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_unit_no_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookunitnoidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookunitnocodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookunitnonameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_book_unit_no, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgBookUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Book Unit Setup"
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_book_unit_no})
        '
        'lib_erp_book_unit_no
        '
        Me.lib_erp_book_unit_no.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.lib_erp_book_unit_no.TableName = "lib_erp_book_unit_no"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "book_unit_no_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "book_unit_no_code"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "book_unit_no_name"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "book_id"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "book_code"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "book_name"
        Me.DataColumn6.DefaultValue = ""
        '
        'Searchtxt
        '
        Me.Searchtxt._Text = ""
        Me.Searchtxt.AllowNegative = False
        Me.Searchtxt.AlwaysDisable = False
        Me.Searchtxt.AlwaysEnable = False
        Me.Searchtxt.BackColor = System.Drawing.Color.White
        Me.Searchtxt.BorderColor = System.Drawing.Color.DarkGray
        Me.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Searchtxt.DataSource = ""
        Me.Searchtxt.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Searchtxt.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Searchtxt.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.Searchtxt.EnabledBackColor = System.Drawing.Color.White
        Me.Searchtxt.ispk = False
        Me.Searchtxt.Location = New System.Drawing.Point(366, 42)
        Me.Searchtxt.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Searchtxt.MultiLine = False
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.NoClear = False
        Me.Searchtxt.NumberFormat = "@"
        Me.Searchtxt.Required = False
        Me.Searchtxt.RowData = Nothing
        Me.Searchtxt.SelectionLength = 0
        Me.Searchtxt.SelectionStart = 0
        Me.Searchtxt.Size = New System.Drawing.Size(150, 20)
        Me.Searchtxt.TabIndex = 3
        Me.Searchtxt.TableData = Nothing
        Me.Searchtxt.TextSource = "book_unit_no_code,book_unit_no_name"
        Me.Searchtxt.UseSystemPasswordChar = False
        Me.Searchtxt.Value = ""
        Me.Searchtxt.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Search"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(531, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'BookunitnoidDataGridViewTextBoxColumn
        '
        Me.BookunitnoidDataGridViewTextBoxColumn.DataPropertyName = "book_unit_no__id"
        Me.BookunitnoidDataGridViewTextBoxColumn.HeaderText = "book_unit_no__id"
        Me.BookunitnoidDataGridViewTextBoxColumn.Name = "BookunitnoidDataGridViewTextBoxColumn"
        '
        'BookunitnocodeDataGridViewTextBoxColumn
        '
        Me.BookunitnocodeDataGridViewTextBoxColumn.DataPropertyName = "book_unit_no__code"
        Me.BookunitnocodeDataGridViewTextBoxColumn.HeaderText = "book_unit_no__code"
        Me.BookunitnocodeDataGridViewTextBoxColumn.Name = "BookunitnocodeDataGridViewTextBoxColumn"
        '
        'BookunitnonameDataGridViewTextBoxColumn
        '
        Me.BookunitnonameDataGridViewTextBoxColumn.DataPropertyName = "book_unit_no__name"
        Me.BookunitnonameDataGridViewTextBoxColumn.HeaderText = "book_unit_no__name"
        Me.BookunitnonameDataGridViewTextBoxColumn.Name = "BookunitnonameDataGridViewTextBoxColumn"
        '
        'BookidDataGridViewTextBoxColumn
        '
        Me.BookidDataGridViewTextBoxColumn.DataPropertyName = "book_id"
        Me.BookidDataGridViewTextBoxColumn.HeaderText = "book_id"
        Me.BookidDataGridViewTextBoxColumn.Name = "BookidDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_book_unit_no_name)
        Me.Panel1.Controls.Add(Me.txt_book_unit_no_code)
        Me.Panel1.Controls.Add(Me.txt_book_id)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_book_unit_no_id)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(17, 257)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 101)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Tag = "container"
        '
        'txt_book_unit_no_name
        '
        Me.txt_book_unit_no_name._Text = ""
        Me.txt_book_unit_no_name.AllowNegative = False
        Me.txt_book_unit_no_name.AlwaysDisable = False
        Me.txt_book_unit_no_name.AlwaysEnable = False
        Me.txt_book_unit_no_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_unit_no_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book_unit_no_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_unit_no_name.DataSource = ""
        Me.txt_book_unit_no_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_unit_no_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_unit_no_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_unit_no_name.Enabled = False
        Me.txt_book_unit_no_name.EnabledBackColor = System.Drawing.Color.Empty
        Me.txt_book_unit_no_name.ispk = False
        Me.txt_book_unit_no_name.Location = New System.Drawing.Point(69, 38)
        Me.txt_book_unit_no_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_unit_no_name.MultiLine = False
        Me.txt_book_unit_no_name.Name = "txt_book_unit_no_name"
        Me.txt_book_unit_no_name.NoClear = False
        Me.txt_book_unit_no_name.NumberFormat = "@"
        Me.txt_book_unit_no_name.Required = True
        Me.txt_book_unit_no_name.RowData = Nothing
        Me.txt_book_unit_no_name.SelectionLength = 0
        Me.txt_book_unit_no_name.SelectionStart = 0
        Me.txt_book_unit_no_name.Size = New System.Drawing.Size(400, 20)
        Me.txt_book_unit_no_name.TabIndex = 2
        Me.txt_book_unit_no_name.TableData = Nothing
        Me.txt_book_unit_no_name.Tag = "focus"
        Me.txt_book_unit_no_name.TextSource = ""
        Me.txt_book_unit_no_name.UseSystemPasswordChar = False
        Me.txt_book_unit_no_name.Value = ""
        Me.txt_book_unit_no_name.ValueSource = ""
        '
        'txt_book_unit_no_code
        '
        Me.txt_book_unit_no_code._Text = ""
        Me.txt_book_unit_no_code.AllowNegative = False
        Me.txt_book_unit_no_code.AlwaysDisable = False
        Me.txt_book_unit_no_code.AlwaysEnable = False
        Me.txt_book_unit_no_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_unit_no_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book_unit_no_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_unit_no_code.DataSource = ""
        Me.txt_book_unit_no_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_unit_no_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_unit_no_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_unit_no_code.Enabled = False
        Me.txt_book_unit_no_code.EnabledBackColor = System.Drawing.Color.Empty
        Me.txt_book_unit_no_code.ispk = False
        Me.txt_book_unit_no_code.Location = New System.Drawing.Point(69, 12)
        Me.txt_book_unit_no_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_unit_no_code.MultiLine = False
        Me.txt_book_unit_no_code.Name = "txt_book_unit_no_code"
        Me.txt_book_unit_no_code.NoClear = False
        Me.txt_book_unit_no_code.NumberFormat = "@"
        Me.txt_book_unit_no_code.Required = True
        Me.txt_book_unit_no_code.RowData = Nothing
        Me.txt_book_unit_no_code.SelectionLength = 0
        Me.txt_book_unit_no_code.SelectionStart = 0
        Me.txt_book_unit_no_code.Size = New System.Drawing.Size(400, 20)
        Me.txt_book_unit_no_code.TabIndex = 1
        Me.txt_book_unit_no_code.TableData = Nothing
        Me.txt_book_unit_no_code.Tag = ""
        Me.txt_book_unit_no_code.TextSource = ""
        Me.txt_book_unit_no_code.UseSystemPasswordChar = False
        Me.txt_book_unit_no_code.Value = ""
        Me.txt_book_unit_no_code.ValueSource = ""
        '
        'txt_book_id
        '
        Me.txt_book_id._Text = ""
        Me.txt_book_id.AllowNegative = False
        Me.txt_book_id.AlwaysDisable = False
        Me.txt_book_id.AlwaysEnable = False
        Me.txt_book_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_id.DataSource = ""
        Me.txt_book_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_id.Enabled = False
        Me.txt_book_id.EnabledBackColor = System.Drawing.Color.Empty
        Me.txt_book_id.ispk = False
        Me.txt_book_id.Location = New System.Drawing.Point(69, 64)
        Me.txt_book_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_id.MultiLine = False
        Me.txt_book_id.Name = "txt_book_id"
        Me.txt_book_id.NoClear = False
        Me.txt_book_id.NumberFormat = "@"
        Me.txt_book_id.Required = True
        Me.txt_book_id.RowData = Nothing
        Me.txt_book_id.SelectionLength = 0
        Me.txt_book_id.SelectionStart = 0
        Me.txt_book_id.Size = New System.Drawing.Size(400, 20)
        Me.txt_book_id.TabIndex = 3
        Me.txt_book_id.TableData = Nothing
        Me.txt_book_id.Tag = ""
        Me.txt_book_id.TextSource = "book_name"
        Me.txt_book_id.UseSystemPasswordChar = False
        Me.txt_book_id.Value = ""
        Me.txt_book_id.ValueSource = "book_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(31, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(31, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Book"
        '
        'txt_book_unit_no_id
        '
        Me.txt_book_unit_no_id._Text = ""
        Me.txt_book_unit_no_id.AllowNegative = False
        Me.txt_book_unit_no_id.AlwaysDisable = False
        Me.txt_book_unit_no_id.AlwaysEnable = False
        Me.txt_book_unit_no_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_unit_no_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book_unit_no_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_unit_no_id.DataSource = ""
        Me.txt_book_unit_no_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_unit_no_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_unit_no_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_unit_no_id.Enabled = False
        Me.txt_book_unit_no_id.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_book_unit_no_id.ispk = False
        Me.txt_book_unit_no_id.Location = New System.Drawing.Point(3, 3)
        Me.txt_book_unit_no_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_unit_no_id.MultiLine = False
        Me.txt_book_unit_no_id.Name = "txt_book_unit_no_id"
        Me.txt_book_unit_no_id.NoClear = False
        Me.txt_book_unit_no_id.NumberFormat = "@"
        Me.txt_book_unit_no_id.Required = False
        Me.txt_book_unit_no_id.RowData = Nothing
        Me.txt_book_unit_no_id.SelectionLength = 0
        Me.txt_book_unit_no_id.SelectionStart = 0
        Me.txt_book_unit_no_id.Size = New System.Drawing.Size(27, 10)
        Me.txt_book_unit_no_id.TabIndex = 0
        Me.txt_book_unit_no_id.TableData = Nothing
        Me.txt_book_unit_no_id.Tag = "focus"
        Me.txt_book_unit_no_id.TextSource = ""
        Me.txt_book_unit_no_id.UseSystemPasswordChar = False
        Me.txt_book_unit_no_id.Value = ""
        Me.txt_book_unit_no_id.ValueSource = ""
        Me.txt_book_unit_no_id.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(28, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Name"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(189, 227)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Delete"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(19, 227)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(105, 227)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(18, 227)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 9
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
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(104, 227)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 10
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'dgBookUnits
        '
        Me.dgBookUnits.AllowUserToAddRows = False
        Me.dgBookUnits.AllowUserToDeleteRows = False
        Me.dgBookUnits.AllowUserToResizeColumns = False
        Me.dgBookUnits.AllowUserToResizeRows = False
        Me.dgBookUnits.AutoGenerateColumns = False
        Me.dgBookUnits.BackgroundColor = System.Drawing.Color.White
        Me.dgBookUnits.ColumnHeadersHeight = 28
        Me.dgBookUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBookUnits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.book_unit_no_id, Me.book_unit_no_code, Me.book_unit_no_name, Me.book_name, Me.BookunitnoidDataGridViewTextBoxColumn1, Me.BookunitnocodeDataGridViewTextBoxColumn1, Me.BookunitnonameDataGridViewTextBoxColumn1, Me.BookidDataGridViewTextBoxColumn1, Me.BookcodeDataGridViewTextBoxColumn, Me.BooknameDataGridViewTextBoxColumn})
        Me.dgBookUnits.DataMember = "lib_erp_book_unit_no"
        Me.dgBookUnits.DataSource = Me.ds
        Me.dgBookUnits.Location = New System.Drawing.Point(18, 71)
        Me.dgBookUnits.MultiSelect = False
        Me.dgBookUnits.Name = "dgBookUnits"
        Me.dgBookUnits.RowHeadersVisible = False
        Me.dgBookUnits.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgBookUnits.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBookUnits.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgBookUnits.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgBookUnits.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgBookUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBookUnits.Size = New System.Drawing.Size(498, 150)
        Me.dgBookUnits.TabIndex = 4
        Me.dgBookUnits.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'book_unit_no_id
        '
        Me.book_unit_no_id.DataPropertyName = "book_unit_no_id"
        Me.book_unit_no_id.HeaderText = "book_unit_no_id"
        Me.book_unit_no_id.Name = "book_unit_no_id"
        Me.book_unit_no_id.Visible = False
        '
        'book_unit_no_code
        '
        Me.book_unit_no_code.DataPropertyName = "book_unit_no_code"
        Me.book_unit_no_code.HeaderText = "Code"
        Me.book_unit_no_code.Name = "book_unit_no_code"
        Me.book_unit_no_code.ReadOnly = True
        '
        'book_unit_no_name
        '
        Me.book_unit_no_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_unit_no_name.DataPropertyName = "book_unit_no_name"
        Me.book_unit_no_name.HeaderText = "Name"
        Me.book_unit_no_name.Name = "book_unit_no_name"
        Me.book_unit_no_name.ReadOnly = True
        '
        'book_name
        '
        Me.book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_name.DataPropertyName = "book_name"
        Me.book_name.HeaderText = "Book"
        Me.book_name.Name = "book_name"
        Me.book_name.ReadOnly = True
        '
        'BookunitnoidDataGridViewTextBoxColumn1
        '
        Me.BookunitnoidDataGridViewTextBoxColumn1.DataPropertyName = "book_unit_no_id"
        Me.BookunitnoidDataGridViewTextBoxColumn1.HeaderText = "book_unit_no_id"
        Me.BookunitnoidDataGridViewTextBoxColumn1.Name = "BookunitnoidDataGridViewTextBoxColumn1"
        Me.BookunitnoidDataGridViewTextBoxColumn1.Visible = False
        '
        'BookunitnocodeDataGridViewTextBoxColumn1
        '
        Me.BookunitnocodeDataGridViewTextBoxColumn1.DataPropertyName = "book_unit_no_code"
        Me.BookunitnocodeDataGridViewTextBoxColumn1.HeaderText = "book_unit_no_code"
        Me.BookunitnocodeDataGridViewTextBoxColumn1.Name = "BookunitnocodeDataGridViewTextBoxColumn1"
        Me.BookunitnocodeDataGridViewTextBoxColumn1.Visible = False
        '
        'BookunitnonameDataGridViewTextBoxColumn1
        '
        Me.BookunitnonameDataGridViewTextBoxColumn1.DataPropertyName = "book_unit_no_name"
        Me.BookunitnonameDataGridViewTextBoxColumn1.HeaderText = "book_unit_no_name"
        Me.BookunitnonameDataGridViewTextBoxColumn1.Name = "BookunitnonameDataGridViewTextBoxColumn1"
        Me.BookunitnonameDataGridViewTextBoxColumn1.Visible = False
        '
        'BookidDataGridViewTextBoxColumn1
        '
        Me.BookidDataGridViewTextBoxColumn1.DataPropertyName = "book_id"
        Me.BookidDataGridViewTextBoxColumn1.HeaderText = "book_id"
        Me.BookidDataGridViewTextBoxColumn1.Name = "BookidDataGridViewTextBoxColumn1"
        Me.BookidDataGridViewTextBoxColumn1.Visible = False
        '
        'BookcodeDataGridViewTextBoxColumn
        '
        Me.BookcodeDataGridViewTextBoxColumn.DataPropertyName = "book_code"
        Me.BookcodeDataGridViewTextBoxColumn.HeaderText = "book_code"
        Me.BookcodeDataGridViewTextBoxColumn.Name = "BookcodeDataGridViewTextBoxColumn"
        Me.BookcodeDataGridViewTextBoxColumn.Visible = False
        '
        'BooknameDataGridViewTextBoxColumn
        '
        Me.BooknameDataGridViewTextBoxColumn.DataPropertyName = "book_name"
        Me.BooknameDataGridViewTextBoxColumn.HeaderText = "book_name"
        Me.BooknameDataGridViewTextBoxColumn.Name = "BooknameDataGridViewTextBoxColumn"
        Me.BooknameDataGridViewTextBoxColumn.Visible = False
        '
        'frmBookUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 380)
        Me.Controls.Add(Me.dgBookUnits)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.Searchtxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBookUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Unit Setup"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_book_unit_no, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgBookUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Searchtxt As user_control.textbox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents ds As DataSet
    Friend WithEvents lib_erp_book_unit_no As DataTable
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents BookunitnoidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookunitnocodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookunitnonameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookidDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents btnInsert As Windows.Forms.Button
    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents txt_book_unit_no_id As user_control.textbox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents btnNotSave As Windows.Forms.Button
    Friend WithEvents txt_book_unit_no_name As user_control.textbox
    Friend WithEvents txt_book_unit_no_code As user_control.textbox
    Friend WithEvents txt_book_id As user_control.textbox
    Friend WithEvents dgBookUnits As Windows.Forms.DataGridView
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_unit_no_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_unit_no_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_unit_no_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookunitnoidDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookunitnocodeDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookunitnonameDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookidDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookcodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BooknameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
End Class
