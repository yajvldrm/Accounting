<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setupprepaid
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
        Me.dgdet = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.prepaid_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_acquired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useful_life = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.offset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.det = New System.Windows.Forms.Panel()
        Me.txt_useful_life = New DevExpress.XtraEditors.TextEdit()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.btndet2 = New System.Windows.Forms.Panel()
        Me.btnundo = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txt_description = New user_control.textbox()
        Me.txt_date_start = New System.Windows.Forms.DateTimePicker()
        Me.txt_date_acquired = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnhdr2 = New System.Windows.Forms.Panel()
        Me.btnnotsave = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndet1 = New System.Windows.Forms.Panel()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.ds = New System.Data.DataSet()
        Me.prepaid = New System.Data.DataTable()
        Me.DataColumn138 = New System.Data.DataColumn()
        Me.DataColumn139 = New System.Data.DataColumn()
        Me.DataColumn140 = New System.Data.DataColumn()
        Me.DataColumn141 = New System.Data.DataColumn()
        Me.DataColumn142 = New System.Data.DataColumn()
        Me.DataColumn143 = New System.Data.DataColumn()
        Me.DataColumn144 = New System.Data.DataColumn()
        Me.DataColumn145 = New System.Data.DataColumn()
        Me.DataColumn146 = New System.Data.DataColumn()
        Me.DataColumn147 = New System.Data.DataColumn()
        Me.DataColumn148 = New System.Data.DataColumn()
        Me.DataColumn149 = New System.Data.DataColumn()
        Me.DataColumn150 = New System.Data.DataColumn()
        Me.DataColumn159 = New System.Data.DataColumn()
        Me.DataColumn237 = New System.Data.DataColumn()
        Me.DataColumn238 = New System.Data.DataColumn()
        Me.DataColumn239 = New System.Data.DataColumn()
        Me.DataColumn240 = New System.Data.DataColumn()
        Me.DataColumn241 = New System.Data.DataColumn()
        Me.DataColumn242 = New System.Data.DataColumn()
        Me.DataColumn243 = New System.Data.DataColumn()
        Me.DataColumn244 = New System.Data.DataColumn()
        Me.DataColumn245 = New System.Data.DataColumn()
        Me.DataColumn246 = New System.Data.DataColumn()
        Me.DataColumn247 = New System.Data.DataColumn()
        Me.DataColumn248 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.Myformheader1 = New user_control.myformheader()
        CType(Me.dgdet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.det.SuspendLayout()
        CType(Me.txt_useful_life.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btndet2.SuspendLayout()
        Me.btnhdr2.SuspendLayout()
        Me.btndet1.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prepaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgdet
        '
        Me.dgdet.AllowUserToAddRows = False
        Me.dgdet.AllowUserToDeleteRows = False
        Me.dgdet.AllowUserToResizeColumns = False
        Me.dgdet.AllowUserToResizeRows = False
        Me.dgdet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgdet.BackgroundColor = System.Drawing.Color.White
        Me.dgdet.ColumnHeadersHeight = 28
        Me.dgdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgdet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.deleted, Me.prepaid_id, Me.description, Me.date_acquired, Me.date_start, Me.amount, Me.useful_life, Me.offset, Me.minimum})
        Me.dgdet.Location = New System.Drawing.Point(21, 78)
        Me.dgdet.MultiSelect = False
        Me.dgdet.Name = "dgdet"
        Me.dgdet.RowHeadersVisible = False
        Me.dgdet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgdet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdet.Size = New System.Drawing.Size(643, 147)
        Me.dgdet.TabIndex = 0
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.Width = 30
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Visible = False
        '
        'prepaid_id
        '
        Me.prepaid_id.DataPropertyName = "prepaid_id"
        Me.prepaid_id.HeaderText = "prepaid_id"
        Me.prepaid_id.Name = "prepaid_id"
        Me.prepaid_id.Visible = False
        '
        'description
        '
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.description.Width = 200
        '
        'date_acquired
        '
        Me.date_acquired.DataPropertyName = "date_acquired"
        Me.date_acquired.HeaderText = "Date Acquired"
        Me.date_acquired.Name = "date_acquired"
        Me.date_acquired.ReadOnly = True
        Me.date_acquired.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.date_acquired.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_start
        '
        Me.date_start.DataPropertyName = "date_start"
        Me.date_start.HeaderText = "Date Start"
        Me.date_start.Name = "date_start"
        Me.date_start.ReadOnly = True
        Me.date_start.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.date_start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        Me.amount.HeaderText = "Acquisition Cost"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.amount.Width = 120
        '
        'useful_life
        '
        Me.useful_life.DataPropertyName = "useful_life"
        Me.useful_life.HeaderText = "Useful Life"
        Me.useful_life.Name = "useful_life"
        Me.useful_life.ReadOnly = True
        Me.useful_life.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.useful_life.Width = 90
        '
        'offset
        '
        Me.offset.DataPropertyName = "offset"
        Me.offset.HeaderText = "offset"
        Me.offset.Name = "offset"
        Me.offset.Visible = False
        '
        'minimum
        '
        Me.minimum.DataPropertyName = "minimum"
        Me.minimum.HeaderText = "minimum"
        Me.minimum.Name = "minimum"
        Me.minimum.Visible = False
        '
        'border2
        '
        Me.border2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(21, 65)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(643, 2)
        Me.border2.TabIndex = 5
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(21, 63)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(643, 2)
        Me.border1.TabIndex = 4
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Prepayment Details"
        '
        'det
        '
        Me.det.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.det.Controls.Add(Me.txt_useful_life)
        Me.det.Controls.Add(Me.txt_amount)
        Me.det.Controls.Add(Me.btndet2)
        Me.det.Controls.Add(Me.txt_description)
        Me.det.Controls.Add(Me.txt_date_start)
        Me.det.Controls.Add(Me.txt_date_acquired)
        Me.det.Controls.Add(Me.Label9)
        Me.det.Controls.Add(Me.Label4)
        Me.det.Controls.Add(Me.Label5)
        Me.det.Controls.Add(Me.Label3)
        Me.det.Controls.Add(Me.Label22)
        Me.det.Location = New System.Drawing.Point(21, 260)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(643, 97)
        Me.det.TabIndex = 103
        '
        'txt_useful_life
        '
        Me.txt_useful_life.EditValue = "0.00"
        Me.txt_useful_life.Enabled = False
        Me.txt_useful_life.Location = New System.Drawing.Point(337, 63)
        Me.txt_useful_life.Name = "txt_useful_life"
        Me.txt_useful_life.Properties.DisplayFormat.FormatString = "n"
        Me.txt_useful_life.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_useful_life.Properties.EditFormat.FormatString = "n"
        Me.txt_useful_life.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_useful_life.Properties.Mask.EditMask = "n"
        Me.txt_useful_life.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_useful_life.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_useful_life.Size = New System.Drawing.Size(100, 20)
        Me.txt_useful_life.TabIndex = 6
        Me.txt_useful_life.Tag = "useful_life"
        '
        'txt_amount
        '
        Me.txt_amount.EditValue = "0.00"
        Me.txt_amount.Enabled = False
        Me.txt_amount.Location = New System.Drawing.Point(94, 63)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.DisplayFormat.FormatString = "n4"
        Me.txt_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount.Properties.EditFormat.FormatString = "n4"
        Me.txt_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount.Properties.Mask.EditMask = "n4"
        Me.txt_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_amount.Size = New System.Drawing.Size(174, 20)
        Me.txt_amount.TabIndex = 5
        Me.txt_amount.Tag = "amount"
        '
        'btndet2
        '
        Me.btndet2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndet2.Controls.Add(Me.btnundo)
        Me.btndet2.Controls.Add(Me.btnok)
        Me.btndet2.Location = New System.Drawing.Point(458, 62)
        Me.btndet2.Name = "btndet2"
        Me.btndet2.Size = New System.Drawing.Size(169, 26)
        Me.btndet2.TabIndex = 124
        '
        'btnundo
        '
        Me.btnundo.BackColor = System.Drawing.Color.Maroon
        Me.btnundo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnundo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnundo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnundo.ForeColor = System.Drawing.Color.White
        Me.btnundo.Location = New System.Drawing.Point(87, 1)
        Me.btnundo.Name = "btnundo"
        Me.btnundo.Size = New System.Drawing.Size(80, 24)
        Me.btnundo.TabIndex = 10
        Me.btnundo.Text = "Cancel"
        Me.btnundo.UseVisualStyleBackColor = False
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.Green
        Me.btnok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(1, 1)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(80, 24)
        Me.btnok.TabIndex = 9
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'txt_description
        '
        Me.txt_description._Text = ""
        Me.txt_description.AllowNegative = False
        Me.txt_description.AlwaysDisable = False
        Me.txt_description.AlwaysEnable = False
        Me.txt_description.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_description.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_description.DataSource = ""
        Me.txt_description.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_description.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_description.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_description.Enabled = False
        Me.txt_description.EnabledBackColor = System.Drawing.Color.White
        Me.txt_description.ispk = False
        Me.txt_description.Location = New System.Drawing.Point(94, 36)
        Me.txt_description.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_description.MultiLine = False
        Me.txt_description.Name = "txt_description"
        Me.txt_description.NoClear = False
        Me.txt_description.NumberFormat = "@"
        Me.txt_description.Required = False
        Me.txt_description.RowData = Nothing
        Me.txt_description.SelectionLength = 0
        Me.txt_description.SelectionStart = 0
        Me.txt_description.Size = New System.Drawing.Size(538, 20)
        Me.txt_description.TabIndex = 4
        Me.txt_description.TableData = Nothing
        Me.txt_description.TextSource = "description"
        Me.txt_description.UseSystemPasswordChar = False
        Me.txt_description.Value = ""
        Me.txt_description.ValueSource = ""
        '
        'txt_date_start
        '
        Me.txt_date_start.Enabled = False
        Me.txt_date_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_start.Location = New System.Drawing.Point(337, 8)
        Me.txt_date_start.Name = "txt_date_start"
        Me.txt_date_start.Size = New System.Drawing.Size(100, 21)
        Me.txt_date_start.TabIndex = 3
        '
        'txt_date_acquired
        '
        Me.txt_date_acquired.Enabled = False
        Me.txt_date_acquired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_acquired.Location = New System.Drawing.Point(94, 8)
        Me.txt_date_acquired.Name = "txt_date_acquired"
        Me.txt_date_acquired.Size = New System.Drawing.Size(97, 21)
        Me.txt_date_acquired.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "Description"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Amortization Start Date"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Useful Life"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Acquisition Cost"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 113
        Me.Label22.Text = "Date Acquired"
        '
        'btnhdr2
        '
        Me.btnhdr2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnhdr2.Controls.Add(Me.btnnotsave)
        Me.btnhdr2.Controls.Add(Me.btnsave)
        Me.btnhdr2.Location = New System.Drawing.Point(256, 369)
        Me.btnhdr2.Name = "btnhdr2"
        Me.btnhdr2.Size = New System.Drawing.Size(169, 26)
        Me.btnhdr2.TabIndex = 126
        '
        'btnnotsave
        '
        Me.btnnotsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnnotsave.BackColor = System.Drawing.Color.Maroon
        Me.btnnotsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnnotsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnnotsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnotsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnotsave.ForeColor = System.Drawing.Color.White
        Me.btnnotsave.Location = New System.Drawing.Point(87, 1)
        Me.btnnotsave.Name = "btnnotsave"
        Me.btnnotsave.Size = New System.Drawing.Size(80, 24)
        Me.btnnotsave.TabIndex = 12
        Me.btnnotsave.Text = "&Cancel"
        Me.btnnotsave.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsave.BackColor = System.Drawing.Color.Green
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(1, 1)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 24)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btndet1
        '
        Me.btndet1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndet1.Controls.Add(Me.btnremove)
        Me.btndet1.Controls.Add(Me.btninsert)
        Me.btndet1.Controls.Add(Me.btnupdate)
        Me.btndet1.Location = New System.Drawing.Point(21, 229)
        Me.btndet1.Name = "btndet1"
        Me.btndet1.Size = New System.Drawing.Size(255, 26)
        Me.btndet1.TabIndex = 125
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ForeColor = System.Drawing.Color.White
        Me.btnremove.Location = New System.Drawing.Point(173, 1)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(80, 24)
        Me.btnremove.TabIndex = 3
        Me.btnremove.Text = "F4 Remove"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.Color.White
        Me.btninsert.Location = New System.Drawing.Point(1, 1)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(80, 24)
        Me.btninsert.TabIndex = 1
        Me.btninsert.Text = "F2 Insert"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(87, 1)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(80, 24)
        Me.btnupdate.TabIndex = 2
        Me.btnupdate.Text = "F3 Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.prepaid})
        '
        'prepaid
        '
        Me.prepaid.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn138, Me.DataColumn139, Me.DataColumn140, Me.DataColumn141, Me.DataColumn142, Me.DataColumn143, Me.DataColumn144, Me.DataColumn145, Me.DataColumn146, Me.DataColumn147, Me.DataColumn148, Me.DataColumn149, Me.DataColumn150, Me.DataColumn159, Me.DataColumn237, Me.DataColumn238, Me.DataColumn239, Me.DataColumn240, Me.DataColumn241, Me.DataColumn242, Me.DataColumn243, Me.DataColumn244, Me.DataColumn245, Me.DataColumn246, Me.DataColumn247, Me.DataColumn248, Me.DataColumn1, Me.DataColumn2})
        Me.prepaid.TableName = "prepaid"
        '
        'DataColumn138
        '
        Me.DataColumn138.ColumnName = "sel"
        Me.DataColumn138.DataType = GetType(Boolean)
        Me.DataColumn138.DefaultValue = False
        '
        'DataColumn139
        '
        Me.DataColumn139.ColumnName = "prepaid_id"
        Me.DataColumn139.DefaultValue = ""
        '
        'DataColumn140
        '
        Me.DataColumn140.ColumnName = "jbooks_id"
        Me.DataColumn140.DefaultValue = ""
        '
        'DataColumn141
        '
        Me.DataColumn141.ColumnName = "currency_id"
        Me.DataColumn141.DefaultValue = ""
        '
        'DataColumn142
        '
        Me.DataColumn142.ColumnName = "exchange_rate"
        Me.DataColumn142.DataType = GetType(Decimal)
        Me.DataColumn142.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn143
        '
        Me.DataColumn143.ColumnName = "based_rate"
        Me.DataColumn143.DataType = GetType(Decimal)
        Me.DataColumn143.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn144
        '
        Me.DataColumn144.ColumnName = "description"
        Me.DataColumn144.DefaultValue = ""
        '
        'DataColumn145
        '
        Me.DataColumn145.ColumnName = "date_acquired"
        Me.DataColumn145.DataType = GetType(Date)
        '
        'DataColumn146
        '
        Me.DataColumn146.ColumnName = "amount"
        Me.DataColumn146.DataType = GetType(Decimal)
        Me.DataColumn146.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn147
        '
        Me.DataColumn147.ColumnName = "amount_based"
        Me.DataColumn147.DataType = GetType(Decimal)
        Me.DataColumn147.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn148
        '
        Me.DataColumn148.ColumnName = "useful_life"
        Me.DataColumn148.DataType = GetType(Integer)
        Me.DataColumn148.DefaultValue = 0
        '
        'DataColumn149
        '
        Me.DataColumn149.ColumnName = "date_start"
        Me.DataColumn149.DataType = GetType(Date)
        '
        'DataColumn150
        '
        Me.DataColumn150.ColumnName = "debit"
        Me.DataColumn150.DataType = GetType(Decimal)
        Me.DataColumn150.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn159
        '
        Me.DataColumn159.ColumnName = "credit"
        Me.DataColumn159.DataType = GetType(Decimal)
        Me.DataColumn159.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn237
        '
        Me.DataColumn237.ColumnName = "debit_based"
        Me.DataColumn237.DataType = GetType(Decimal)
        Me.DataColumn237.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn238
        '
        Me.DataColumn238.ColumnName = "credit_based"
        Me.DataColumn238.DataType = GetType(Decimal)
        Me.DataColumn238.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn239
        '
        Me.DataColumn239.ColumnName = "ref_prepaid_id"
        Me.DataColumn239.DefaultValue = ""
        '
        'DataColumn240
        '
        Me.DataColumn240.ColumnName = "ref_no"
        Me.DataColumn240.DefaultValue = ""
        '
        'DataColumn241
        '
        Me.DataColumn241.ColumnName = "currency_code"
        Me.DataColumn241.DefaultValue = ""
        '
        'DataColumn242
        '
        Me.DataColumn242.ColumnName = "currency_name"
        Me.DataColumn242.DefaultValue = ""
        '
        'DataColumn243
        '
        Me.DataColumn243.ColumnName = "tmp_amount"
        Me.DataColumn243.DataType = GetType(Decimal)
        Me.DataColumn243.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn244
        '
        Me.DataColumn244.ColumnName = "isInputted"
        Me.DataColumn244.DataType = GetType(Boolean)
        Me.DataColumn244.DefaultValue = False
        '
        'DataColumn245
        '
        Me.DataColumn245.ColumnName = "deleted"
        Me.DataColumn245.DataType = GetType(Boolean)
        Me.DataColumn245.DefaultValue = False
        '
        'DataColumn246
        '
        Me.DataColumn246.ColumnName = "balance"
        Me.DataColumn246.DataType = GetType(Decimal)
        Me.DataColumn246.DefaultValue = New Decimal(New Integer() {0, 0, 0, 65536})
        '
        'DataColumn247
        '
        Me.DataColumn247.ColumnName = "trans_no"
        Me.DataColumn247.DefaultValue = ""
        '
        'DataColumn248
        '
        Me.DataColumn248.ColumnName = "trans_date"
        Me.DataColumn248.DefaultValue = ""
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "offset"
        Me.DataColumn1.DataType = GetType(Integer)
        Me.DataColumn1.DefaultValue = 0
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "minimum"
        Me.DataColumn2.DataType = GetType(Decimal)
        Me.DataColumn2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(680, 28)
        Me.Myformheader1.TabIndex = 127
        '
        'setupprepaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 412)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnhdr2)
        Me.Controls.Add(Me.btndet1)
        Me.Controls.Add(Me.det)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdet)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setupprepaid"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prepayment Details"
        CType(Me.dgdet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.det.ResumeLayout(False)
        Me.det.PerformLayout()
        CType(Me.txt_useful_life.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btndet2.ResumeLayout(False)
        Me.btnhdr2.ResumeLayout(False)
        Me.btndet1.ResumeLayout(False)
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prepaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgdet As System.Windows.Forms.DataGridView
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents det As System.Windows.Forms.Panel
    Friend WithEvents txt_date_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_date_acquired As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_description As user_control.textbox
    Friend WithEvents btndet2 As System.Windows.Forms.Panel
    Friend WithEvents btnundo As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnhdr2 As System.Windows.Forms.Panel
    Friend WithEvents btnnotsave As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndet1 As System.Windows.Forms.Panel
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents prepaid As System.Data.DataTable
    Friend WithEvents DataColumn138 As System.Data.DataColumn
    Friend WithEvents DataColumn139 As System.Data.DataColumn
    Friend WithEvents DataColumn140 As System.Data.DataColumn
    Friend WithEvents DataColumn141 As System.Data.DataColumn
    Friend WithEvents DataColumn142 As System.Data.DataColumn
    Friend WithEvents DataColumn143 As System.Data.DataColumn
    Friend WithEvents DataColumn144 As System.Data.DataColumn
    Friend WithEvents DataColumn145 As System.Data.DataColumn
    Friend WithEvents DataColumn146 As System.Data.DataColumn
    Friend WithEvents DataColumn147 As System.Data.DataColumn
    Friend WithEvents DataColumn148 As System.Data.DataColumn
    Friend WithEvents DataColumn149 As System.Data.DataColumn
    Friend WithEvents DataColumn150 As System.Data.DataColumn
    Friend WithEvents DataColumn159 As System.Data.DataColumn
    Friend WithEvents DataColumn237 As System.Data.DataColumn
    Friend WithEvents DataColumn238 As System.Data.DataColumn
    Friend WithEvents DataColumn239 As System.Data.DataColumn
    Friend WithEvents DataColumn240 As System.Data.DataColumn
    Friend WithEvents DataColumn241 As System.Data.DataColumn
    Friend WithEvents DataColumn242 As System.Data.DataColumn
    Friend WithEvents DataColumn243 As System.Data.DataColumn
    Friend WithEvents DataColumn244 As System.Data.DataColumn
    Friend WithEvents DataColumn245 As System.Data.DataColumn
    Friend WithEvents DataColumn246 As System.Data.DataColumn
    Friend WithEvents DataColumn247 As System.Data.DataColumn
    Friend WithEvents DataColumn248 As System.Data.DataColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents prepaid_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_acquired As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_start As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents useful_life As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents offset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minimum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents txt_useful_life As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
End Class
