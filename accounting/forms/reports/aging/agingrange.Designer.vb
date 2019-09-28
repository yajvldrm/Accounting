<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agingrange
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.border2 = New accounting.borderedlabel()
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_days_to = New user_control.textbox()
        Me.txt_days_from = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_aging_range_id = New user_control.textbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.aging_range_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.days_from = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.days_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.cboxAllHeader = New System.Windows.Forms.CheckBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.gboxContainer.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 25)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "Aging Range Configuration"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 62)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(475, 2)
        Me.border1.TabIndex = 253
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(21, 67)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(460, 2)
        Me.border2.TabIndex = 254
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.Label5)
        Me.gboxContainer.Controls.Add(Me.Label4)
        Me.gboxContainer.Controls.Add(Me.txt_days_to)
        Me.gboxContainer.Controls.Add(Me.txt_days_from)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Controls.Add(Me.txt_aging_range_id)
        Me.gboxContainer.Location = New System.Drawing.Point(12, 255)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(476, 50)
        Me.gboxContainer.TabIndex = 255
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(295, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "*"
        '
        'txt_days_to
        '
        Me.txt_days_to._Text = ""
        Me.txt_days_to.AlwaysDisable = False
        Me.txt_days_to.AlwaysEnable = False
        Me.txt_days_to.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_days_to.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_days_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_days_to.DataSource = ""
        Me.txt_days_to.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_days_to.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_days_to.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_days_to.Enabled = False
        Me.txt_days_to.EnabledBackColor = System.Drawing.Color.White
        Me.txt_days_to.ispk = False
        Me.txt_days_to.Location = New System.Drawing.Point(308, 17)
        Me.txt_days_to.MultiLine = False
        Me.txt_days_to.Name = "txt_days_to"
        Me.txt_days_to.NoClear = False
        Me.txt_days_to.NumberFormat = "##,##0"
        Me.txt_days_to.Required = True
        Me.txt_days_to.RowData = Nothing
        Me.txt_days_to.SelectionLength = 0
        Me.txt_days_to.SelectionStart = 0
        Me.txt_days_to.Size = New System.Drawing.Size(150, 20)
        Me.txt_days_to.TabIndex = 2
        Me.txt_days_to.TableData = Nothing
        Me.txt_days_to.TextSource = "days_to"
        Me.txt_days_to.UseSystemPasswordChar = False
        Me.txt_days_to.Value = ""
        Me.txt_days_to.ValueSource = "days_to"
        '
        'txt_days_from
        '
        Me.txt_days_from._Text = ""
        Me.txt_days_from.AlwaysDisable = False
        Me.txt_days_from.AlwaysEnable = False
        Me.txt_days_from.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_days_from.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_days_from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_days_from.DataSource = ""
        Me.txt_days_from.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_days_from.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_days_from.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_days_from.Enabled = False
        Me.txt_days_from.EnabledBackColor = System.Drawing.Color.White
        Me.txt_days_from.ispk = False
        Me.txt_days_from.Location = New System.Drawing.Point(85, 17)
        Me.txt_days_from.MultiLine = False
        Me.txt_days_from.Name = "txt_days_from"
        Me.txt_days_from.NoClear = False
        Me.txt_days_from.NumberFormat = "##,##0"
        Me.txt_days_from.Required = True
        Me.txt_days_from.RowData = Nothing
        Me.txt_days_from.SelectionLength = 0
        Me.txt_days_from.SelectionStart = 0
        Me.txt_days_from.Size = New System.Drawing.Size(150, 20)
        Me.txt_days_from.TabIndex = 1
        Me.txt_days_from.TableData = Nothing
        Me.txt_days_from.Tag = "focus"
        Me.txt_days_from.TextSource = "days_from"
        Me.txt_days_from.UseSystemPasswordChar = False
        Me.txt_days_from.Value = ""
        Me.txt_days_from.ValueSource = "days_from"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Days To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Days From"
        '
        'txt_aging_range_id
        '
        Me.txt_aging_range_id._Text = ""
        Me.txt_aging_range_id.AlwaysDisable = False
        Me.txt_aging_range_id.AlwaysEnable = False
        Me.txt_aging_range_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_aging_range_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_aging_range_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_aging_range_id.DataSource = ""
        Me.txt_aging_range_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_aging_range_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_aging_range_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_aging_range_id.Enabled = False
        Me.txt_aging_range_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_aging_range_id.ispk = False
        Me.txt_aging_range_id.Location = New System.Drawing.Point(6, 12)
        Me.txt_aging_range_id.MultiLine = False
        Me.txt_aging_range_id.Name = "txt_aging_range_id"
        Me.txt_aging_range_id.NoClear = False
        Me.txt_aging_range_id.NumberFormat = "@"
        Me.txt_aging_range_id.Required = False
        Me.txt_aging_range_id.RowData = Nothing
        Me.txt_aging_range_id.SelectionLength = 0
        Me.txt_aging_range_id.SelectionStart = 0
        Me.txt_aging_range_id.Size = New System.Drawing.Size(18, 20)
        Me.txt_aging_range_id.TabIndex = 3
        Me.txt_aging_range_id.TableData = Nothing
        Me.txt_aging_range_id.TextSource = "aging_range_id"
        Me.txt_aging_range_id.UseSystemPasswordChar = False
        Me.txt_aging_range_id.Value = ""
        Me.txt_aging_range_id.ValueSource = "aging_range_id"
        Me.txt_aging_range_id.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(72, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 264
        Me.Label5.Text = "*"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.aging_range_id, Me.days_from, Me.days_to})
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
        Me.dgMain.TabIndex = 261
        Me.dgMain.Tag = "maingrid"
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.Width = 30
        '
        'aging_range_id
        '
        Me.aging_range_id.DataPropertyName = "aging_range_id"
        Me.aging_range_id.HeaderText = "ID"
        Me.aging_range_id.Name = "aging_range_id"
        Me.aging_range_id.ReadOnly = True
        Me.aging_range_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.aging_range_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.aging_range_id.Visible = False
        '
        'days_from
        '
        Me.days_from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.days_from.DataPropertyName = "days_from"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "##,##0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.days_from.DefaultCellStyle = DataGridViewCellStyle1
        Me.days_from.HeaderText = "Days From"
        Me.days_from.Name = "days_from"
        Me.days_from.ReadOnly = True
        Me.days_from.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.days_from.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'days_to
        '
        Me.days_to.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.days_to.DataPropertyName = "days_to"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "##,##0"
        DataGridViewCellStyle2.NullValue = "0"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.days_to.DefaultCellStyle = DataGridViewCellStyle2
        Me.days_to.HeaderText = "Days To"
        Me.days_to.Name = "days_to"
        Me.days_to.ReadOnly = True
        Me.days_to.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.days_to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(125, 226)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(100, 23)
        Me.btnNotSave.TabIndex = 260
        Me.btnNotSave.Tag = "btnNotSave"
        Me.btnNotSave.Text = "Cancel"
        Me.btnNotSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(19, 226)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 259
        Me.btnSave.Tag = "btnSave"
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(157, 226)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(60, 23)
        Me.btnRemove.TabIndex = 258
        Me.btnRemove.Tag = "btnRemove"
        Me.btnRemove.Text = "Delete"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(91, 226)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(60, 23)
        Me.btnUpdate.TabIndex = 257
        Me.btnUpdate.Tag = "btnUpdate"
        Me.btnUpdate.Text = "Edit"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(25, 226)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(60, 23)
        Me.btnInsert.TabIndex = 256
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'cboxAllHeader
        '
        Me.cboxAllHeader.AutoSize = True
        Me.cboxAllHeader.Location = New System.Drawing.Point(21, 78)
        Me.cboxAllHeader.Name = "cboxAllHeader"
        Me.cboxAllHeader.Size = New System.Drawing.Size(15, 14)
        Me.cboxAllHeader.TabIndex = 262
        Me.cboxAllHeader.UseVisualStyleBackColor = True
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(516, 28)
        Me.Myformheader1.TabIndex = 263
        '
        'agingrange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 320)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.cboxAllHeader)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "agingrange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aging Range Configuration"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_aging_range_id As user_control.textbox
    Friend WithEvents txt_days_to As user_control.textbox
    Friend WithEvents txt_days_from As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents aging_range_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents days_from As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents days_to As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents cboxAllHeader As System.Windows.Forms.CheckBox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
