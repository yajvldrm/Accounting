<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class input_vat
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
        Me.border1 = New accounting.borderedlabel()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_effectivity_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_vat_rate = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_input_vat_id = New user_control.textbox()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.input_vat_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.effectivity_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vat_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxContainer.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(475, 2)
        Me.border1.TabIndex = 80
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label13)
        Me.gboxContainer.Controls.Add(Me.txt_effectivity_date)
        Me.gboxContainer.Controls.Add(Me.txt_vat_rate)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Controls.Add(Me.txt_input_vat_id)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 255)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(476, 52)
        Me.gboxContainer.TabIndex = 78
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(275, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 16)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "*"
        '
        'txt_effectivity_date
        '
        Me.txt_effectivity_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_effectivity_date.Location = New System.Drawing.Point(103, 19)
        Me.txt_effectivity_date.Name = "txt_effectivity_date"
        Me.txt_effectivity_date.Size = New System.Drawing.Size(120, 20)
        Me.txt_effectivity_date.TabIndex = 2
        Me.txt_effectivity_date.Tag = "focus"
        '
        'txt_vat_rate
        '
        Me.txt_vat_rate._Text = ""
        Me.txt_vat_rate.AlwaysDisable = False
        Me.txt_vat_rate.AlwaysEnable = False
        Me.txt_vat_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_vat_rate.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_vat_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vat_rate.DataSource = ""
        Me.txt_vat_rate.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_vat_rate.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_vat_rate.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_vat_rate.Enabled = False
        Me.txt_vat_rate.EnabledBackColor = System.Drawing.Color.White
        Me.txt_vat_rate.ispk = False
        Me.txt_vat_rate.Location = New System.Drawing.Point(288, 19)
        Me.txt_vat_rate.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_vat_rate.MultiLine = False
        Me.txt_vat_rate.Name = "txt_vat_rate"
        Me.txt_vat_rate.NoClear = False
        Me.txt_vat_rate.NumberFormat = "##,##0.00"
        Me.txt_vat_rate.Required = True
        Me.txt_vat_rate.RowData = Nothing
        Me.txt_vat_rate.SelectionLength = 0
        Me.txt_vat_rate.SelectionStart = 0
        Me.txt_vat_rate.Size = New System.Drawing.Size(170, 20)
        Me.txt_vat_rate.TabIndex = 3
        Me.txt_vat_rate.TableData = Nothing
        Me.txt_vat_rate.TextSource = ""
        Me.txt_vat_rate.UseSystemPasswordChar = False
        Me.txt_vat_rate.Value = ""
        Me.txt_vat_rate.ValueSource = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Vat Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Effectivity Date"
        '
        'txt_input_vat_id
        '
        Me.txt_input_vat_id._Text = ""
        Me.txt_input_vat_id.AlwaysDisable = False
        Me.txt_input_vat_id.AlwaysEnable = False
        Me.txt_input_vat_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_input_vat_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_input_vat_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_input_vat_id.DataSource = ""
        Me.txt_input_vat_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_input_vat_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_input_vat_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_input_vat_id.Enabled = False
        Me.txt_input_vat_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_input_vat_id.ispk = False
        Me.txt_input_vat_id.Location = New System.Drawing.Point(6, 11)
        Me.txt_input_vat_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_input_vat_id.MultiLine = False
        Me.txt_input_vat_id.Name = "txt_input_vat_id"
        Me.txt_input_vat_id.NoClear = False
        Me.txt_input_vat_id.NumberFormat = "@"
        Me.txt_input_vat_id.Required = False
        Me.txt_input_vat_id.RowData = Nothing
        Me.txt_input_vat_id.SelectionLength = 0
        Me.txt_input_vat_id.SelectionStart = 0
        Me.txt_input_vat_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_input_vat_id.TabIndex = 1
        Me.txt_input_vat_id.TableData = Nothing
        Me.txt_input_vat_id.TextSource = ""
        Me.txt_input_vat_id.UseSystemPasswordChar = False
        Me.txt_input_vat_id.Value = ""
        Me.txt_input_vat_id.ValueSource = ""
        Me.txt_input_vat_id.Visible = False
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.input_vat_id, Me.effectivity_date, Me.vat_rate})
        Me.dgMain.Location = New System.Drawing.Point(12, 70)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(476, 150)
        Me.dgMain.TabIndex = 86
        Me.dgMain.Tag = "maingrid"
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(98, 226)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(80, 24)
        Me.btnNotSave.TabIndex = 85
        Me.btnNotSave.Tag = "btnNotSave"
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
        Me.btnSave.Location = New System.Drawing.Point(12, 226)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 84
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(184, 226)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 83
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "F5 Delete"
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
        Me.btnUpdate.Location = New System.Drawing.Point(98, 226)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 82
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "F4 Edit"
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
        Me.btnInsert.Location = New System.Drawing.Point(12, 226)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 81
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "F2 Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 25)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Input Vat Setup"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 87
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
        'input_vat_id
        '
        Me.input_vat_id.DataPropertyName = "input_vat_id"
        Me.input_vat_id.HeaderText = "ID"
        Me.input_vat_id.Name = "input_vat_id"
        Me.input_vat_id.ReadOnly = True
        Me.input_vat_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.input_vat_id.Visible = False
        '
        'effectivity_date
        '
        Me.effectivity_date.DataPropertyName = "effectivity_date"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.effectivity_date.DefaultCellStyle = DataGridViewCellStyle1
        Me.effectivity_date.HeaderText = "Effectivity Date"
        Me.effectivity_date.Name = "effectivity_date"
        Me.effectivity_date.ReadOnly = True
        Me.effectivity_date.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.effectivity_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'vat_rate
        '
        Me.vat_rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vat_rate.DataPropertyName = "vat_rate"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "##,##0.00"
        DataGridViewCellStyle2.NullValue = "0.00"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.vat_rate.DefaultCellStyle = DataGridViewCellStyle2
        Me.vat_rate.HeaderText = "Vat Rate"
        Me.vat_rate.Name = "vat_rate"
        Me.vat_rate.ReadOnly = True
        Me.vat_rate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vat_rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'input_vat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 320)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "input_vat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Vat Setup"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_input_vat_id As user_control.textbox
    Friend WithEvents txt_vat_rate As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_effectivity_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents input_vat_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents effectivity_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vat_rate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
