<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jbookssetup
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.primary_key = New user_control.textbox()
        Me.Textbox6 = New user_control.textbox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.panelSub = New System.Windows.Forms.Panel()
        Me.txt_format = New user_control.textbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_start_trans_no = New user_control.textbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_journal_book_det_id = New user_control.textbox()
        Me.txt_book_name = New user_control.textbox()
        Me.txt_book_code = New user_control.textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgSub = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.journal_book_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.start_trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.format = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.journal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_auto_number = New System.Windows.Forms.CheckBox()
        Me.shooting = New System.Windows.Forms.CheckBox()
        Me.txt_person_label = New user_control.textbox()
        Me.txt_trans_label = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_journal_name = New user_control.textbox()
        Me.txt_journal_code = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_bir_control_no = New user_control.textbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_journal_id = New user_control.textbox()
        Me.txtsearch = New user_control.textbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.panelSub.SuspendLayout()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxContainer.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnSave.TabIndex = 104
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
        Me.btnNotSave.TabIndex = 105
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
        Me.primary_key.Location = New System.Drawing.Point(254, 31)
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
        Me.primary_key.TabIndex = 107
        Me.primary_key.TableData = Nothing
        Me.primary_key.TextSource = ""
        Me.primary_key.UseSystemPasswordChar = False
        Me.primary_key.Value = ""
        Me.primary_key.ValueSource = "journal_id"
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
        Me.Textbox6.Location = New System.Drawing.Point(544, 159)
        Me.Textbox6.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Textbox6.MultiLine = False
        Me.Textbox6.Name = "Textbox6"
        Me.Textbox6.NoClear = False
        Me.Textbox6.NumberFormat = "@"
        Me.Textbox6.Required = False
        Me.Textbox6.RowData = Nothing
        Me.Textbox6.SelectionLength = 0
        Me.Textbox6.SelectionStart = 0
        Me.Textbox6.Size = New System.Drawing.Size(20, 20)
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
        Me.panelSub.Controls.Add(Me.txt_format)
        Me.panelSub.Controls.Add(Me.Label11)
        Me.panelSub.Controls.Add(Me.txt_start_trans_no)
        Me.panelSub.Controls.Add(Me.Label9)
        Me.panelSub.Controls.Add(Me.Textbox6)
        Me.panelSub.Controls.Add(Me.txt_journal_book_det_id)
        Me.panelSub.Controls.Add(Me.txt_book_name)
        Me.panelSub.Controls.Add(Me.txt_book_code)
        Me.panelSub.Controls.Add(Me.Label4)
        Me.panelSub.Controls.Add(Me.Label5)
        Me.panelSub.Controls.Add(Me.dgSub)
        Me.panelSub.Controls.Add(Me.Button8)
        Me.panelSub.Controls.Add(Me.Button9)
        Me.panelSub.Controls.Add(Me.Button10)
        Me.panelSub.Controls.Add(Me.Button6)
        Me.panelSub.Controls.Add(Me.Button7)
        Me.panelSub.Location = New System.Drawing.Point(12, 363)
        Me.panelSub.Name = "panelSub"
        Me.panelSub.Size = New System.Drawing.Size(676, 235)
        Me.panelSub.TabIndex = 108
        Me.panelSub.Tag = "subContainer"
        '
        'txt_format
        '
        Me.txt_format._Text = ""
        Me.txt_format.AlwaysDisable = False
        Me.txt_format.AlwaysEnable = False
        Me.txt_format.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_format.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_format.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_format.DataSource = ""
        Me.txt_format.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_format.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_format.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_format.Enabled = False
        Me.txt_format.EnabledBackColor = System.Drawing.Color.White
        Me.txt_format.ispk = False
        Me.txt_format.Location = New System.Drawing.Point(273, 212)
        Me.txt_format.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_format.MultiLine = False
        Me.txt_format.Name = "txt_format"
        Me.txt_format.NoClear = False
        Me.txt_format.NumberFormat = "@"
        Me.txt_format.Required = False
        Me.txt_format.RowData = Nothing
        Me.txt_format.SelectionLength = 0
        Me.txt_format.SelectionStart = 0
        Me.txt_format.Size = New System.Drawing.Size(400, 20)
        Me.txt_format.TabIndex = 6
        Me.txt_format.TableData = Nothing
        Me.txt_format.TextSource = ""
        Me.txt_format.UseSystemPasswordChar = False
        Me.txt_format.Value = ""
        Me.txt_format.ValueSource = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(228, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 100
        Me.Label11.Tag = "label"
        Me.Label11.Text = "Format"
        '
        'txt_start_trans_no
        '
        Me.txt_start_trans_no._Text = ""
        Me.txt_start_trans_no.AlwaysDisable = False
        Me.txt_start_trans_no.AlwaysEnable = False
        Me.txt_start_trans_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_start_trans_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_start_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_start_trans_no.DataSource = ""
        Me.txt_start_trans_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_start_trans_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_start_trans_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_start_trans_no.Enabled = False
        Me.txt_start_trans_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_start_trans_no.ispk = False
        Me.txt_start_trans_no.Location = New System.Drawing.Point(89, 213)
        Me.txt_start_trans_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_start_trans_no.MultiLine = False
        Me.txt_start_trans_no.Name = "txt_start_trans_no"
        Me.txt_start_trans_no.NoClear = False
        Me.txt_start_trans_no.NumberFormat = "@"
        Me.txt_start_trans_no.Required = False
        Me.txt_start_trans_no.RowData = Nothing
        Me.txt_start_trans_no.SelectionLength = 0
        Me.txt_start_trans_no.SelectionStart = 0
        Me.txt_start_trans_no.Size = New System.Drawing.Size(130, 20)
        Me.txt_start_trans_no.TabIndex = 5
        Me.txt_start_trans_no.TableData = Nothing
        Me.txt_start_trans_no.TextSource = ""
        Me.txt_start_trans_no.UseSystemPasswordChar = False
        Me.txt_start_trans_no.Value = ""
        Me.txt_start_trans_no.ValueSource = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 98
        Me.Label9.Tag = "label"
        Me.Label9.Text = "Transaction No."
        '
        'txt_journal_book_det_id
        '
        Me.txt_journal_book_det_id._Text = ""
        Me.txt_journal_book_det_id.AlwaysDisable = True
        Me.txt_journal_book_det_id.AlwaysEnable = False
        Me.txt_journal_book_det_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_book_det_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_journal_book_det_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_journal_book_det_id.DataSource = ""
        Me.txt_journal_book_det_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_book_det_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_book_det_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_journal_book_det_id.Enabled = False
        Me.txt_journal_book_det_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_journal_book_det_id.ispk = False
        Me.txt_journal_book_det_id.Location = New System.Drawing.Point(570, 159)
        Me.txt_journal_book_det_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_book_det_id.MultiLine = False
        Me.txt_journal_book_det_id.Name = "txt_journal_book_det_id"
        Me.txt_journal_book_det_id.NoClear = False
        Me.txt_journal_book_det_id.NumberFormat = "@"
        Me.txt_journal_book_det_id.Required = False
        Me.txt_journal_book_det_id.RowData = Nothing
        Me.txt_journal_book_det_id.SelectionLength = 0
        Me.txt_journal_book_det_id.SelectionStart = 0
        Me.txt_journal_book_det_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_journal_book_det_id.TabIndex = 1
        Me.txt_journal_book_det_id.TableData = Nothing
        Me.txt_journal_book_det_id.Tag = "pk"
        Me.txt_journal_book_det_id.TextSource = ""
        Me.txt_journal_book_det_id.UseSystemPasswordChar = False
        Me.txt_journal_book_det_id.Value = ""
        Me.txt_journal_book_det_id.ValueSource = ""
        Me.txt_journal_book_det_id.Visible = False
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
        Me.txt_book_name.Location = New System.Drawing.Point(273, 188)
        Me.txt_book_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_name.MultiLine = False
        Me.txt_book_name.Name = "txt_book_name"
        Me.txt_book_name.NoClear = False
        Me.txt_book_name.NumberFormat = "@"
        Me.txt_book_name.Required = False
        Me.txt_book_name.RowData = Nothing
        Me.txt_book_name.SelectionLength = 0
        Me.txt_book_name.SelectionStart = 0
        Me.txt_book_name.Size = New System.Drawing.Size(400, 20)
        Me.txt_book_name.TabIndex = 4
        Me.txt_book_name.TableData = Nothing
        Me.txt_book_name.Tag = ""
        Me.txt_book_name.TextSource = ""
        Me.txt_book_name.UseSystemPasswordChar = False
        Me.txt_book_name.Value = ""
        Me.txt_book_name.ValueSource = ""
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
        Me.txt_book_code.EnabledBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_book_code.ispk = False
        Me.txt_book_code.Location = New System.Drawing.Point(89, 188)
        Me.txt_book_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book_code.MultiLine = False
        Me.txt_book_code.Name = "txt_book_code"
        Me.txt_book_code.NoClear = False
        Me.txt_book_code.NumberFormat = "@"
        Me.txt_book_code.Required = False
        Me.txt_book_code.RowData = Nothing
        Me.txt_book_code.SelectionLength = 0
        Me.txt_book_code.SelectionStart = 0
        Me.txt_book_code.Size = New System.Drawing.Size(130, 20)
        Me.txt_book_code.TabIndex = 3
        Me.txt_book_code.TableData = Nothing
        Me.txt_book_code.Tag = "focus fk"
        Me.txt_book_code.TextSource = "book_code"
        Me.txt_book_code.UseSystemPasswordChar = False
        Me.txt_book_code.Value = ""
        Me.txt_book_code.ValueSource = "book_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Tag = "label"
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Tag = "label"
        Me.Label5.Text = "Code"
        '
        'dgSub
        '
        Me.dgSub.AllowUserToAddRows = False
        Me.dgSub.AllowUserToDeleteRows = False
        Me.dgSub.AllowUserToResizeColumns = False
        Me.dgSub.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSub.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.deleted, Me.journal_book_det_id, Me.book_id, Me.book_code, Me.book_name, Me.start_trans_no, Me.format})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSub.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgSub.Location = New System.Drawing.Point(3, 3)
        Me.dgSub.MultiSelect = False
        Me.dgSub.Name = "dgSub"
        Me.dgSub.RowHeadersVisible = False
        Me.dgSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSub.Size = New System.Drawing.Size(670, 150)
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
        'journal_book_det_id
        '
        Me.journal_book_det_id.DataPropertyName = "journal_book_det_id"
        Me.journal_book_det_id.HeaderText = "ID"
        Me.journal_book_det_id.Name = "journal_book_det_id"
        Me.journal_book_det_id.ReadOnly = True
        Me.journal_book_det_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_book_det_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.journal_book_det_id.Visible = False
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.HeaderText = "ID"
        Me.book_id.Name = "book_id"
        Me.book_id.ReadOnly = True
        Me.book_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.book_id.Visible = False
        '
        'book_code
        '
        Me.book_code.DataPropertyName = "book_code"
        Me.book_code.FillWeight = 179.6407!
        Me.book_code.HeaderText = "Code"
        Me.book_code.Name = "book_code"
        Me.book_code.ReadOnly = True
        Me.book_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.book_code.Width = 150
        '
        'book_name
        '
        Me.book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_name.DataPropertyName = "book_name"
        Me.book_name.FillWeight = 20.35928!
        Me.book_name.HeaderText = "Book Name"
        Me.book_name.Name = "book_name"
        Me.book_name.ReadOnly = True
        Me.book_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'start_trans_no
        '
        Me.start_trans_no.DataPropertyName = "start_trans_no"
        Me.start_trans_no.HeaderText = "start_trans_no"
        Me.start_trans_no.Name = "start_trans_no"
        Me.start_trans_no.Visible = False
        '
        'format
        '
        Me.format.DataPropertyName = "format"
        Me.format.HeaderText = "format"
        Me.format.Name = "format"
        Me.format.Visible = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 25)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Journal Book Codes"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.journal_id, Me.journal_code, Me.journal_name})
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
        Me.dgMain.Size = New System.Drawing.Size(676, 150)
        Me.dgMain.TabIndex = 106
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
        'journal_code
        '
        Me.journal_code.DataPropertyName = "journal_code"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.journal_code.DefaultCellStyle = DataGridViewCellStyle3
        Me.journal_code.HeaderText = "Code"
        Me.journal_code.Name = "journal_code"
        Me.journal_code.ReadOnly = True
        Me.journal_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'journal_name
        '
        Me.journal_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.journal_name.DataPropertyName = "journal_name"
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.journal_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.journal_name.HeaderText = "Journal Name"
        Me.journal_name.Name = "journal_name"
        Me.journal_name.ReadOnly = True
        Me.journal_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(12, 228)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 102
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F3 Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label13)
        Me.gboxContainer.Controls.Add(Me.Label12)
        Me.gboxContainer.Controls.Add(Me.txt_auto_number)
        Me.gboxContainer.Controls.Add(Me.shooting)
        Me.gboxContainer.Controls.Add(Me.txt_person_label)
        Me.gboxContainer.Controls.Add(Me.txt_trans_label)
        Me.gboxContainer.Controls.Add(Me.Label6)
        Me.gboxContainer.Controls.Add(Me.Label7)
        Me.gboxContainer.Controls.Add(Me.txt_journal_name)
        Me.gboxContainer.Controls.Add(Me.txt_journal_code)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Controls.Add(Me.txt_bir_control_no)
        Me.gboxContainer.Controls.Add(Me.Label8)
        Me.gboxContainer.Controls.Add(Me.txt_journal_id)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 257)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(676, 100)
        Me.gboxContainer.TabIndex = 98
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(71, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 16)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(71, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "*"
        '
        'txt_auto_number
        '
        Me.txt_auto_number.AutoSize = True
        Me.txt_auto_number.Location = New System.Drawing.Point(525, 43)
        Me.txt_auto_number.Name = "txt_auto_number"
        Me.txt_auto_number.Size = New System.Drawing.Size(127, 17)
        Me.txt_auto_number.TabIndex = 7
        Me.txt_auto_number.Text = "Automatic Numbering"
        Me.txt_auto_number.UseVisualStyleBackColor = True
        '
        'shooting
        '
        Me.shooting.AutoSize = True
        Me.shooting.Location = New System.Drawing.Point(525, 19)
        Me.shooting.Name = "shooting"
        Me.shooting.Size = New System.Drawing.Size(139, 17)
        Me.shooting.TabIndex = 6
        Me.shooting.Text = "Report is Shooting Form"
        Me.shooting.UseVisualStyleBackColor = True
        '
        'txt_person_label
        '
        Me.txt_person_label._Text = ""
        Me.txt_person_label.AlwaysDisable = False
        Me.txt_person_label.AlwaysEnable = False
        Me.txt_person_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_person_label.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_person_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_person_label.DataSource = ""
        Me.txt_person_label.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_person_label.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_person_label.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_person_label.Enabled = False
        Me.txt_person_label.EnabledBackColor = System.Drawing.Color.White
        Me.txt_person_label.ispk = False
        Me.txt_person_label.Location = New System.Drawing.Point(334, 67)
        Me.txt_person_label.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_person_label.MultiLine = False
        Me.txt_person_label.Name = "txt_person_label"
        Me.txt_person_label.NoClear = False
        Me.txt_person_label.NumberFormat = "@"
        Me.txt_person_label.Required = False
        Me.txt_person_label.RowData = Nothing
        Me.txt_person_label.SelectionLength = 0
        Me.txt_person_label.SelectionStart = 0
        Me.txt_person_label.Size = New System.Drawing.Size(170, 20)
        Me.txt_person_label.TabIndex = 5
        Me.txt_person_label.TableData = Nothing
        Me.txt_person_label.TextSource = ""
        Me.txt_person_label.UseSystemPasswordChar = False
        Me.txt_person_label.Value = ""
        Me.txt_person_label.ValueSource = ""
        '
        'txt_trans_label
        '
        Me.txt_trans_label._Text = ""
        Me.txt_trans_label.AlwaysDisable = False
        Me.txt_trans_label.AlwaysEnable = False
        Me.txt_trans_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_label.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_trans_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_trans_label.DataSource = ""
        Me.txt_trans_label.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_label.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_trans_label.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_trans_label.Enabled = False
        Me.txt_trans_label.EnabledBackColor = System.Drawing.Color.White
        Me.txt_trans_label.ispk = False
        Me.txt_trans_label.Location = New System.Drawing.Point(84, 67)
        Me.txt_trans_label.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_trans_label.MultiLine = False
        Me.txt_trans_label.Name = "txt_trans_label"
        Me.txt_trans_label.NoClear = False
        Me.txt_trans_label.NumberFormat = "@"
        Me.txt_trans_label.Required = False
        Me.txt_trans_label.RowData = Nothing
        Me.txt_trans_label.SelectionLength = 0
        Me.txt_trans_label.SelectionStart = 0
        Me.txt_trans_label.Size = New System.Drawing.Size(170, 20)
        Me.txt_trans_label.TabIndex = 4
        Me.txt_trans_label.TableData = Nothing
        Me.txt_trans_label.Tag = "focus"
        Me.txt_trans_label.TextSource = ""
        Me.txt_trans_label.UseSystemPasswordChar = False
        Me.txt_trans_label.Value = ""
        Me.txt_trans_label.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Tag = "label"
        Me.Label6.Text = "Gen. Label"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Tag = "label"
        Me.Label7.Text = "Voucher Label"
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
        Me.txt_journal_name.Location = New System.Drawing.Point(84, 43)
        Me.txt_journal_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_name.MultiLine = False
        Me.txt_journal_name.Name = "txt_journal_name"
        Me.txt_journal_name.NoClear = True
        Me.txt_journal_name.NumberFormat = "@"
        Me.txt_journal_name.Required = True
        Me.txt_journal_name.RowData = Nothing
        Me.txt_journal_name.SelectionLength = 0
        Me.txt_journal_name.SelectionStart = 0
        Me.txt_journal_name.Size = New System.Drawing.Size(420, 20)
        Me.txt_journal_name.TabIndex = 3
        Me.txt_journal_name.TableData = Nothing
        Me.txt_journal_name.TextSource = ""
        Me.txt_journal_name.UseSystemPasswordChar = False
        Me.txt_journal_name.Value = ""
        Me.txt_journal_name.ValueSource = ""
        '
        'txt_journal_code
        '
        Me.txt_journal_code._Text = ""
        Me.txt_journal_code.AlwaysDisable = True
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
        Me.txt_journal_code.Location = New System.Drawing.Point(84, 19)
        Me.txt_journal_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_code.MultiLine = False
        Me.txt_journal_code.Name = "txt_journal_code"
        Me.txt_journal_code.NoClear = True
        Me.txt_journal_code.NumberFormat = "@"
        Me.txt_journal_code.Required = True
        Me.txt_journal_code.RowData = Nothing
        Me.txt_journal_code.SelectionLength = 0
        Me.txt_journal_code.SelectionStart = 0
        Me.txt_journal_code.Size = New System.Drawing.Size(420, 20)
        Me.txt_journal_code.TabIndex = 2
        Me.txt_journal_code.TableData = Nothing
        Me.txt_journal_code.Tag = "focus"
        Me.txt_journal_code.TextSource = ""
        Me.txt_journal_code.UseSystemPasswordChar = False
        Me.txt_journal_code.Value = ""
        Me.txt_journal_code.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Code"
        '
        'txt_bir_control_no
        '
        Me.txt_bir_control_no._Text = ""
        Me.txt_bir_control_no.AlwaysDisable = False
        Me.txt_bir_control_no.AlwaysEnable = False
        Me.txt_bir_control_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bir_control_no.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_bir_control_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bir_control_no.DataSource = ""
        Me.txt_bir_control_no.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bir_control_no.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bir_control_no.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bir_control_no.Enabled = False
        Me.txt_bir_control_no.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bir_control_no.ispk = False
        Me.txt_bir_control_no.Location = New System.Drawing.Point(303, 19)
        Me.txt_bir_control_no.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bir_control_no.MultiLine = False
        Me.txt_bir_control_no.Name = "txt_bir_control_no"
        Me.txt_bir_control_no.NoClear = False
        Me.txt_bir_control_no.NumberFormat = "@"
        Me.txt_bir_control_no.Required = False
        Me.txt_bir_control_no.RowData = Nothing
        Me.txt_bir_control_no.SelectionLength = 0
        Me.txt_bir_control_no.SelectionStart = 0
        Me.txt_bir_control_no.Size = New System.Drawing.Size(138, 20)
        Me.txt_bir_control_no.TabIndex = 4
        Me.txt_bir_control_no.TableData = Nothing
        Me.txt_bir_control_no.TextSource = ""
        Me.txt_bir_control_no.UseSystemPasswordChar = False
        Me.txt_bir_control_no.Value = ""
        Me.txt_bir_control_no.ValueSource = ""
        Me.txt_bir_control_no.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(237, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Tag = "label"
        Me.Label8.Text = "Control No."
        Me.Label8.Visible = False
        '
        'txt_journal_id
        '
        Me.txt_journal_id._Text = ""
        Me.txt_journal_id.AlwaysDisable = False
        Me.txt_journal_id.AlwaysEnable = False
        Me.txt_journal_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_journal_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_journal_id.DataSource = ""
        Me.txt_journal_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_journal_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_journal_id.Enabled = False
        Me.txt_journal_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_journal_id.ispk = False
        Me.txt_journal_id.Location = New System.Drawing.Point(1, 1)
        Me.txt_journal_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_journal_id.MultiLine = False
        Me.txt_journal_id.Name = "txt_journal_id"
        Me.txt_journal_id.NoClear = False
        Me.txt_journal_id.NumberFormat = "@"
        Me.txt_journal_id.Required = False
        Me.txt_journal_id.RowData = Nothing
        Me.txt_journal_id.SelectionLength = 0
        Me.txt_journal_id.SelectionStart = 0
        Me.txt_journal_id.Size = New System.Drawing.Size(33, 20)
        Me.txt_journal_id.TabIndex = 1
        Me.txt_journal_id.TableData = Nothing
        Me.txt_journal_id.TextSource = ""
        Me.txt_journal_id.UseSystemPasswordChar = False
        Me.txt_journal_id.Value = ""
        Me.txt_journal_id.ValueSource = ""
        Me.txt_journal_id.Visible = False
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
        Me.txtsearch.Location = New System.Drawing.Point(538, 34)
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
        Me.txtsearch.TabIndex = 110
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = "journal_code,journal_name"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(494, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Search"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(700, 28)
        Me.Myformheader1.TabIndex = 111
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 62)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(675, 2)
        Me.border1.TabIndex = 100
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'jbookssetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 610)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.primary_key)
        Me.Controls.Add(Me.panelSub)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNotSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "jbookssetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Book Codes"
        Me.panelSub.ResumeLayout(False)
        Me.panelSub.PerformLayout()
        CType(Me.dgSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
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
    Friend WithEvents txt_journal_book_det_id As user_control.textbox
    Friend WithEvents txt_book_name As user_control.textbox
    Friend WithEvents txt_book_code As user_control.textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgSub As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents journal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_auto_number As System.Windows.Forms.CheckBox
    Friend WithEvents shooting As System.Windows.Forms.CheckBox
    Friend WithEvents txt_person_label As user_control.textbox
    Friend WithEvents txt_trans_label As user_control.textbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_journal_id As user_control.textbox
    Friend WithEvents txt_journal_name As user_control.textbox
    Friend WithEvents txt_journal_code As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_bir_control_no As user_control.textbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_start_trans_no As user_control.textbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_format As user_control.textbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents journal_book_det_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents start_trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents format As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
