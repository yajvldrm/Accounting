<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtercodessetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(filtercodessetup))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_filter_id = New user_control.textbox()
        Me.txt_filter_name = New user_control.textbox()
        Me.txt_filter_code = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.primary_key = New user_control.textbox()
        Me.Textbox6 = New user_control.textbox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.panelSub = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_book_name = New user_control.textbox()
        Me.txt_journal_name = New user_control.textbox()
        Me.txt_filter_det_id = New user_control.textbox()
        Me.txt_book_code = New user_control.textbox()
        Me.txt_journal_code = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgSub = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.filter_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.filter_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.filter_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.filter_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtsearch = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.panelSub.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_filter_id
        '
        Me.txt_filter_id._Text = ""
        Me.txt_filter_id.AlwaysDisable = False
        Me.txt_filter_id.AlwaysEnable = False
        Me.txt_filter_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filter_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filter_id.DataSource = ""
        Me.txt_filter_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filter_id.Enabled = False
        Me.txt_filter_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_filter_id.ispk = False
        Me.txt_filter_id.Location = New System.Drawing.Point(1, 1)
        Me.txt_filter_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_id.MultiLine = False
        Me.txt_filter_id.Name = "txt_filter_id"
        Me.txt_filter_id.NoClear = False
        Me.txt_filter_id.NumberFormat = "@"
        Me.txt_filter_id.Required = False
        Me.txt_filter_id.RowData = Nothing
        Me.txt_filter_id.SelectionLength = 0
        Me.txt_filter_id.SelectionStart = 0
        Me.txt_filter_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_filter_id.TabIndex = 1
        Me.txt_filter_id.TableData = Nothing
        Me.txt_filter_id.TextSource = ""
        Me.txt_filter_id.UseSystemPasswordChar = False
        Me.txt_filter_id.Value = ""
        Me.txt_filter_id.ValueSource = ""
        Me.txt_filter_id.Visible = False
        '
        'txt_filter_name
        '
        Me.txt_filter_name._Text = ""
        Me.txt_filter_name.AlwaysDisable = False
        Me.txt_filter_name.AlwaysEnable = False
        Me.txt_filter_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filter_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filter_name.DataSource = ""
        Me.txt_filter_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filter_name.Enabled = False
        Me.txt_filter_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_filter_name.ispk = False
        Me.txt_filter_name.Location = New System.Drawing.Point(250, 19)
        Me.txt_filter_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_name.MultiLine = False
        Me.txt_filter_name.Name = "txt_filter_name"
        Me.txt_filter_name.NoClear = False
        Me.txt_filter_name.NumberFormat = "@"
        Me.txt_filter_name.Required = True
        Me.txt_filter_name.RowData = Nothing
        Me.txt_filter_name.SelectionLength = 0
        Me.txt_filter_name.SelectionStart = 0
        Me.txt_filter_name.Size = New System.Drawing.Size(320, 20)
        Me.txt_filter_name.TabIndex = 3
        Me.txt_filter_name.TableData = Nothing
        Me.txt_filter_name.TextSource = ""
        Me.txt_filter_name.UseSystemPasswordChar = False
        Me.txt_filter_name.Value = ""
        Me.txt_filter_name.ValueSource = ""
        '
        'txt_filter_code
        '
        Me.txt_filter_code._Text = ""
        Me.txt_filter_code.AlwaysDisable = False
        Me.txt_filter_code.AlwaysEnable = False
        Me.txt_filter_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filter_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filter_code.DataSource = ""
        Me.txt_filter_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filter_code.Enabled = False
        Me.txt_filter_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_filter_code.ispk = False
        Me.txt_filter_code.Location = New System.Drawing.Point(49, 19)
        Me.txt_filter_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_code.MultiLine = False
        Me.txt_filter_code.Name = "txt_filter_code"
        Me.txt_filter_code.NoClear = False
        Me.txt_filter_code.NumberFormat = "@"
        Me.txt_filter_code.Required = True
        Me.txt_filter_code.RowData = Nothing
        Me.txt_filter_code.SelectionLength = 0
        Me.txt_filter_code.SelectionStart = 0
        Me.txt_filter_code.Size = New System.Drawing.Size(150, 20)
        Me.txt_filter_code.TabIndex = 2
        Me.txt_filter_code.TableData = Nothing
        Me.txt_filter_code.Tag = "focus"
        Me.txt_filter_code.TextSource = ""
        Me.txt_filter_code.UseSystemPasswordChar = False
        Me.txt_filter_code.Value = ""
        Me.txt_filter_code.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Name"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(15, 62)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(570, 2)
        Me.border1.TabIndex = 111
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Code"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(12, 228)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 115
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
        Me.btnNotSave.Location = New System.Drawing.Point(98, 228)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 116
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "&Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
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
        Me.primary_key.Location = New System.Drawing.Point(187, 31)
        Me.primary_key.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.primary_key.MultiLine = False
        Me.primary_key.Name = "primary_key"
        Me.primary_key.NoClear = False
        Me.primary_key.NumberFormat = "@"
        Me.primary_key.Required = False
        Me.primary_key.RowData = Nothing
        Me.primary_key.SelectionLength = 0
        Me.primary_key.SelectionStart = 0
        Me.primary_key.Size = New System.Drawing.Size(105, 20)
        Me.primary_key.TabIndex = 118
        Me.primary_key.TableData = Nothing
        Me.primary_key.TextSource = ""
        Me.primary_key.UseSystemPasswordChar = False
        Me.primary_key.Value = ""
        Me.primary_key.ValueSource = "filter_id"
        Me.primary_key.Visible = False
        '
        'Textbox6
        '
        Me.Textbox6._Text = ""
        Me.Textbox6.AlwaysDisable = True
        Me.Textbox6.AlwaysEnable = False
        Me.Textbox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Textbox6.BorderColor = System.Drawing.Color.DarkGray
        Me.Textbox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox6.DataSource = ""
        Me.Textbox6.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Textbox6.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Textbox6.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.Textbox6.Enabled = False
        Me.Textbox6.EnabledBackColor = System.Drawing.Color.White
        Me.Textbox6.ispk = False
        Me.Textbox6.Location = New System.Drawing.Point(306, 159)
        Me.Textbox6.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Textbox6.MultiLine = False
        Me.Textbox6.Name = "Textbox6"
        Me.Textbox6.NoClear = False
        Me.Textbox6.NumberFormat = "@"
        Me.Textbox6.Required = False
        Me.Textbox6.RowData = Nothing
        Me.Textbox6.SelectionLength = 0
        Me.Textbox6.SelectionStart = 0
        Me.Textbox6.Size = New System.Drawing.Size(76, 20)
        Me.Textbox6.TabIndex = 2
        Me.Textbox6.TableData = Nothing
        Me.Textbox6.Tag = "transmode"
        Me.Textbox6.TextSource = ""
        Me.Textbox6.UseSystemPasswordChar = False
        Me.Textbox6.Value = ""
        Me.Textbox6.ValueSource = ""
        Me.Textbox6.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(89, 159)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 24)
        Me.Button6.TabIndex = 95
        Me.Button6.Tag = "btn-sub-cancel"
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'panelSub
        '
        Me.panelSub.Controls.Add(Me.Button8)
        Me.panelSub.Controls.Add(Me.Button9)
        Me.panelSub.Controls.Add(Me.Button10)
        Me.panelSub.Controls.Add(Me.Button7)
        Me.panelSub.Controls.Add(Me.Button6)
        Me.panelSub.Controls.Add(Me.PictureBox2)
        Me.panelSub.Controls.Add(Me.PictureBox1)
        Me.panelSub.Controls.Add(Me.txt_book_name)
        Me.panelSub.Controls.Add(Me.txt_journal_name)
        Me.panelSub.Controls.Add(Me.Textbox6)
        Me.panelSub.Controls.Add(Me.txt_filter_det_id)
        Me.panelSub.Controls.Add(Me.txt_book_code)
        Me.panelSub.Controls.Add(Me.txt_journal_code)
        Me.panelSub.Controls.Add(Me.Label4)
        Me.panelSub.Controls.Add(Me.Label5)
        Me.panelSub.Controls.Add(Me.dgSub)
        Me.panelSub.Location = New System.Drawing.Point(12, 313)
        Me.panelSub.Name = "panelSub"
        Me.panelSub.Size = New System.Drawing.Size(576, 238)
        Me.panelSub.TabIndex = 119
        Me.panelSub.Tag = "subContainer"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(175, 159)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 24)
        Me.Button8.TabIndex = 93
        Me.Button8.Tag = "btn-sub-remove"
        Me.Button8.Text = "Remove"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(89, 159)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 24)
        Me.Button9.TabIndex = 92
        Me.Button9.Tag = "btn-sub-update"
        Me.Button9.Text = "Update"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(3, 159)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 24)
        Me.Button10.TabIndex = 91
        Me.Button10.Tag = "btn-sub-insert"
        Me.Button10.Text = "Insert"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Green
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(3, 159)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 24)
        Me.Button7.TabIndex = 94
        Me.Button7.Tag = "btn-sub-ok"
        Me.Button7.Text = "OK"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(229, 216)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 151
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(229, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 150
        Me.PictureBox1.TabStop = False
        '
        'txt_book_name
        '
        Me.txt_book_name._Text = ""
        Me.txt_book_name.AlwaysDisable = True
        Me.txt_book_name.AlwaysEnable = False
        Me.txt_book_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_name.DataSource = ""
        Me.txt_book_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_name.Enabled = False
        Me.txt_book_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_book_name.ispk = False
        Me.txt_book_name.Location = New System.Drawing.Point(251, 214)
        Me.txt_book_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_name.MultiLine = False
        Me.txt_book_name.Name = "txt_book_name"
        Me.txt_book_name.NoClear = False
        Me.txt_book_name.NumberFormat = "@"
        Me.txt_book_name.Required = False
        Me.txt_book_name.RowData = Nothing
        Me.txt_book_name.SelectionLength = 0
        Me.txt_book_name.SelectionStart = 0
        Me.txt_book_name.Size = New System.Drawing.Size(300, 20)
        Me.txt_book_name.TabIndex = 6
        Me.txt_book_name.TableData = Nothing
        Me.txt_book_name.Tag = "focus fk"
        Me.txt_book_name.TextSource = "book_name"
        Me.txt_book_name.UseSystemPasswordChar = False
        Me.txt_book_name.Value = ""
        Me.txt_book_name.ValueSource = ""
        '
        'txt_journal_name
        '
        Me.txt_journal_name._Text = ""
        Me.txt_journal_name.AlwaysDisable = True
        Me.txt_journal_name.AlwaysEnable = False
        Me.txt_journal_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_journal_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_journal_name.DataSource = ""
        Me.txt_journal_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_journal_name.Enabled = False
        Me.txt_journal_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_journal_name.ispk = False
        Me.txt_journal_name.Location = New System.Drawing.Point(251, 188)
        Me.txt_journal_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_name.MultiLine = False
        Me.txt_journal_name.Name = "txt_journal_name"
        Me.txt_journal_name.NoClear = False
        Me.txt_journal_name.NumberFormat = "@"
        Me.txt_journal_name.Required = False
        Me.txt_journal_name.RowData = Nothing
        Me.txt_journal_name.SelectionLength = 0
        Me.txt_journal_name.SelectionStart = 0
        Me.txt_journal_name.Size = New System.Drawing.Size(300, 20)
        Me.txt_journal_name.TabIndex = 4
        Me.txt_journal_name.TableData = Nothing
        Me.txt_journal_name.Tag = "focus fk"
        Me.txt_journal_name.TextSource = "journal_name"
        Me.txt_journal_name.UseSystemPasswordChar = False
        Me.txt_journal_name.Value = ""
        Me.txt_journal_name.ValueSource = ""
        '
        'txt_filter_det_id
        '
        Me.txt_filter_det_id._Text = ""
        Me.txt_filter_det_id.AlwaysDisable = True
        Me.txt_filter_det_id.AlwaysEnable = False
        Me.txt_filter_det_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_det_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filter_det_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filter_det_id.DataSource = ""
        Me.txt_filter_det_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_det_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filter_det_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filter_det_id.Enabled = False
        Me.txt_filter_det_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_filter_det_id.ispk = False
        Me.txt_filter_det_id.Location = New System.Drawing.Point(388, 159)
        Me.txt_filter_det_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filter_det_id.MultiLine = False
        Me.txt_filter_det_id.Name = "txt_filter_det_id"
        Me.txt_filter_det_id.NoClear = False
        Me.txt_filter_det_id.NumberFormat = "@"
        Me.txt_filter_det_id.Required = False
        Me.txt_filter_det_id.RowData = Nothing
        Me.txt_filter_det_id.SelectionLength = 0
        Me.txt_filter_det_id.SelectionStart = 0
        Me.txt_filter_det_id.Size = New System.Drawing.Size(185, 20)
        Me.txt_filter_det_id.TabIndex = 1
        Me.txt_filter_det_id.TableData = Nothing
        Me.txt_filter_det_id.Tag = "pk"
        Me.txt_filter_det_id.TextSource = ""
        Me.txt_filter_det_id.UseSystemPasswordChar = False
        Me.txt_filter_det_id.Value = ""
        Me.txt_filter_det_id.ValueSource = ""
        Me.txt_filter_det_id.Visible = False
        '
        'txt_book_code
        '
        Me.txt_book_code._Text = ""
        Me.txt_book_code.AlwaysDisable = False
        Me.txt_book_code.AlwaysEnable = False
        Me.txt_book_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book_code.DataSource = ""
        Me.txt_book_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book_code.Enabled = False
        Me.txt_book_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_book_code.ispk = False
        Me.txt_book_code.Location = New System.Drawing.Point(73, 214)
        Me.txt_book_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_code.MultiLine = False
        Me.txt_book_code.Name = "txt_book_code"
        Me.txt_book_code.NoClear = False
        Me.txt_book_code.NumberFormat = "@"
        Me.txt_book_code.Required = False
        Me.txt_book_code.RowData = Nothing
        Me.txt_book_code.SelectionLength = 0
        Me.txt_book_code.SelectionStart = 0
        Me.txt_book_code.Size = New System.Drawing.Size(150, 20)
        Me.txt_book_code.TabIndex = 5
        Me.txt_book_code.TableData = Nothing
        Me.txt_book_code.Tag = "fk"
        Me.txt_book_code.TextSource = "book_code"
        Me.txt_book_code.UseSystemPasswordChar = False
        Me.txt_book_code.Value = ""
        Me.txt_book_code.ValueSource = "book_id"
        '
        'txt_journal_code
        '
        Me.txt_journal_code._Text = ""
        Me.txt_journal_code.AlwaysDisable = False
        Me.txt_journal_code.AlwaysEnable = False
        Me.txt_journal_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_journal_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_journal_code.DataSource = ""
        Me.txt_journal_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_journal_code.Enabled = False
        Me.txt_journal_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_journal_code.ispk = False
        Me.txt_journal_code.Location = New System.Drawing.Point(73, 188)
        Me.txt_journal_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_code.MultiLine = False
        Me.txt_journal_code.Name = "txt_journal_code"
        Me.txt_journal_code.NoClear = False
        Me.txt_journal_code.NumberFormat = "@"
        Me.txt_journal_code.Required = False
        Me.txt_journal_code.RowData = Nothing
        Me.txt_journal_code.SelectionLength = 0
        Me.txt_journal_code.SelectionStart = 0
        Me.txt_journal_code.Size = New System.Drawing.Size(150, 20)
        Me.txt_journal_code.TabIndex = 3
        Me.txt_journal_code.TableData = Nothing
        Me.txt_journal_code.Tag = "focus fk"
        Me.txt_journal_code.TextSource = "journal_code"
        Me.txt_journal_code.UseSystemPasswordChar = False
        Me.txt_journal_code.Value = ""
        Me.txt_journal_code.ValueSource = "journal_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Book"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Tag = "label"
        Me.Label5.Text = "Journal"
        '
        'dgSub
        '
        Me.dgSub.AllowUserToAddRows = False
        Me.dgSub.AllowUserToDeleteRows = False
        Me.dgSub.AllowUserToResizeColumns = False
        Me.dgSub.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSub.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.deleted, Me.filter_det_id, Me.journal_id, Me.book_id, Me.journal_code, Me.journal_name, Me.book_code, Me.book_name})
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
        Me.dgSub.Size = New System.Drawing.Size(570, 150)
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
        Me.deleted.FalseValue = "False"
        Me.deleted.HeaderText = "Deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleted.TrueValue = "True"
        Me.deleted.Visible = False
        '
        'filter_det_id
        '
        Me.filter_det_id.DataPropertyName = "filter_det_id"
        Me.filter_det_id.HeaderText = "ID"
        Me.filter_det_id.Name = "filter_det_id"
        Me.filter_det_id.ReadOnly = True
        Me.filter_det_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.filter_det_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.filter_det_id.Visible = False
        '
        'journal_id
        '
        Me.journal_id.DataPropertyName = "journal_id"
        Me.journal_id.HeaderText = "ID"
        Me.journal_id.Name = "journal_id"
        Me.journal_id.ReadOnly = True
        Me.journal_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.journal_id.Visible = False
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.FillWeight = 179.6407!
        Me.book_id.HeaderText = "ID"
        Me.book_id.Name = "book_id"
        Me.book_id.ReadOnly = True
        Me.book_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.book_id.Visible = False
        Me.book_id.Width = 150
        '
        'journal_code
        '
        Me.journal_code.DataPropertyName = "journal_code"
        Me.journal_code.HeaderText = "Journal"
        Me.journal_code.Name = "journal_code"
        Me.journal_code.ReadOnly = True
        Me.journal_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'journal_name
        '
        Me.journal_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.journal_name.DataPropertyName = "journal_name"
        Me.journal_name.HeaderText = "Name"
        Me.journal_name.Name = "journal_name"
        Me.journal_name.ReadOnly = True
        Me.journal_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'book_code
        '
        Me.book_code.DataPropertyName = "book_code"
        Me.book_code.HeaderText = "Book"
        Me.book_code.Name = "book_code"
        Me.book_code.ReadOnly = True
        Me.book_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'book_name
        '
        Me.book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_name.DataPropertyName = "book_name"
        Me.book_name.HeaderText = "Name"
        Me.book_name.Name = "book_name"
        Me.book_name.ReadOnly = True
        Me.book_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Filter Codes"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.filter_id, Me.filter_code, Me.filter_name})
        Me.dgMain.Location = New System.Drawing.Point(12, 72)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(576, 150)
        Me.dgMain.TabIndex = 117
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
        'filter_id
        '
        Me.filter_id.DataPropertyName = "filter_id"
        Me.filter_id.HeaderText = "ID"
        Me.filter_id.Name = "filter_id"
        Me.filter_id.ReadOnly = True
        Me.filter_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.filter_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.filter_id.Visible = False
        '
        'filter_code
        '
        Me.filter_code.DataPropertyName = "filter_code"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filter_code.DefaultCellStyle = DataGridViewCellStyle7
        Me.filter_code.HeaderText = "Code"
        Me.filter_code.Name = "filter_code"
        Me.filter_code.ReadOnly = True
        Me.filter_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.filter_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'filter_name
        '
        Me.filter_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.filter_name.DataPropertyName = "filter_name"
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.filter_name.DefaultCellStyle = DataGridViewCellStyle8
        Me.filter_name.HeaderText = "Filter Name"
        Me.filter_name.Name = "filter_name"
        Me.filter_name.ReadOnly = True
        Me.filter_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.filter_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(184, 228)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 114
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F4 Delete"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(98, 228)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 113
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.txt_filter_name)
        Me.gboxContainer.Controls.Add(Me.txt_filter_code)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Controls.Add(Me.txt_filter_id)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 257)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(576, 50)
        Me.gboxContainer.TabIndex = 109
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(237, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(36, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "*"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(12, 228)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 112
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch._Text = ""
        Me.txtsearch.AlwaysDisable = False
        Me.txtsearch.AlwaysEnable = False
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderColor = System.Drawing.Color.DarkGray
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.DataSource = ""
        Me.txtsearch.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtsearch.EnabledBackColor = System.Drawing.Color.White
        Me.txtsearch.ispk = False
        Me.txtsearch.Location = New System.Drawing.Point(438, 34)
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
        Me.txtsearch.TabIndex = 121
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = "filter_code,filter_name"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(394, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Search"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(600, 28)
        Me.Myformheader1.TabIndex = 122
        '
        'filtercodessetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 565)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.primary_key)
        Me.Controls.Add(Me.panelSub)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "filtercodessetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Codes"
        Me.panelSub.ResumeLayout(False)
        Me.panelSub.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_filter_id As user_control.textbox
    Friend WithEvents txt_filter_name As user_control.textbox
    Friend WithEvents txt_filter_code As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents primary_key As user_control.textbox
    Friend WithEvents Textbox6 As user_control.textbox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents panelSub As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txt_filter_det_id As user_control.textbox
    Friend WithEvents txt_book_code As user_control.textbox
    Friend WithEvents txt_journal_code As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgSub As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents filter_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents filter_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents filter_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_book_name As user_control.textbox
    Friend WithEvents txt_journal_name As user_control.textbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents filter_det_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
