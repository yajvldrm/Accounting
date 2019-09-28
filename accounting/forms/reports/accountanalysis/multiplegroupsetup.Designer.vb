<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class multiplegroupsetup
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
        Me.gboxContainer = New System.Windows.Forms.GroupBox()
        Me.txt_chart_group_multiple_id = New user_control.textbox()
        Me.txt_chart_group_name = New user_control.textbox()
        Me.txt_chart_group_id = New user_control.textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.cboxAllHeader = New System.Windows.Forms.CheckBox()
        Me.btnNotSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.Myformheader1 = New user_control.myformheader()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chart_group_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_group_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_group_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chart_group_multiple_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxContainer.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mutiple Group Setup"
        '
        'gboxContainer
        '
        Me.gboxContainer.Controls.Add(Me.txt_chart_group_multiple_id)
        Me.gboxContainer.Controls.Add(Me.txt_chart_group_name)
        Me.gboxContainer.Controls.Add(Me.txt_chart_group_id)
        Me.gboxContainer.Controls.Add(Me.Label3)
        Me.gboxContainer.Controls.Add(Me.Label2)
        Me.gboxContainer.Location = New System.Drawing.Point(20, 262)
        Me.gboxContainer.Name = "gboxContainer"
        Me.gboxContainer.Size = New System.Drawing.Size(460, 100)
        Me.gboxContainer.TabIndex = 69
        Me.gboxContainer.TabStop = False
        Me.gboxContainer.Tag = "container"
        '
        'txt_chart_group_multiple_id
        '
        Me.txt_chart_group_multiple_id._Text = ""
        Me.txt_chart_group_multiple_id.AlwaysDisable = False
        Me.txt_chart_group_multiple_id.AlwaysEnable = False
        Me.txt_chart_group_multiple_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_multiple_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_chart_group_multiple_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chart_group_multiple_id.DataSource = ""
        Me.txt_chart_group_multiple_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_multiple_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_multiple_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_chart_group_multiple_id.Enabled = False
        Me.txt_chart_group_multiple_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_chart_group_multiple_id.ispk = False
        Me.txt_chart_group_multiple_id.Location = New System.Drawing.Point(6, 11)
        Me.txt_chart_group_multiple_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_multiple_id.MultiLine = False
        Me.txt_chart_group_multiple_id.Name = "txt_chart_group_multiple_id"
        Me.txt_chart_group_multiple_id.NoClear = False
        Me.txt_chart_group_multiple_id.NumberFormat = "@"
        Me.txt_chart_group_multiple_id.Required = False
        Me.txt_chart_group_multiple_id.RowData = Nothing
        Me.txt_chart_group_multiple_id.SelectionLength = 0
        Me.txt_chart_group_multiple_id.SelectionStart = 0
        Me.txt_chart_group_multiple_id.Size = New System.Drawing.Size(59, 20)
        Me.txt_chart_group_multiple_id.TabIndex = 3
        Me.txt_chart_group_multiple_id.TableData = Nothing
        Me.txt_chart_group_multiple_id.TextSource = "chart_group_multiple_id"
        Me.txt_chart_group_multiple_id.UseSystemPasswordChar = False
        Me.txt_chart_group_multiple_id.Value = ""
        Me.txt_chart_group_multiple_id.ValueSource = "chart_group_multiple_id"
        Me.txt_chart_group_multiple_id.Visible = False
        '
        'txt_chart_group_name
        '
        Me.txt_chart_group_name._Text = ""
        Me.txt_chart_group_name.AlwaysDisable = True
        Me.txt_chart_group_name.AlwaysEnable = False
        Me.txt_chart_group_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_name.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_chart_group_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chart_group_name.DataSource = ""
        Me.txt_chart_group_name.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_name.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_name.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_chart_group_name.Enabled = False
        Me.txt_chart_group_name.EnabledBackColor = System.Drawing.Color.White
        Me.txt_chart_group_name.ispk = False
        Me.txt_chart_group_name.Location = New System.Drawing.Point(59, 60)
        Me.txt_chart_group_name.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_name.MultiLine = False
        Me.txt_chart_group_name.Name = "txt_chart_group_name"
        Me.txt_chart_group_name.NoClear = False
        Me.txt_chart_group_name.NumberFormat = "@"
        Me.txt_chart_group_name.Required = True
        Me.txt_chart_group_name.RowData = Nothing
        Me.txt_chart_group_name.SelectionLength = 0
        Me.txt_chart_group_name.SelectionStart = 0
        Me.txt_chart_group_name.Size = New System.Drawing.Size(395, 20)
        Me.txt_chart_group_name.TabIndex = 2
        Me.txt_chart_group_name.TableData = Nothing
        Me.txt_chart_group_name.TextSource = "chart_group_name"
        Me.txt_chart_group_name.UseSystemPasswordChar = False
        Me.txt_chart_group_name.Value = ""
        Me.txt_chart_group_name.ValueSource = "chart_group_name"
        '
        'txt_chart_group_id
        '
        Me.txt_chart_group_id._Text = ""
        Me.txt_chart_group_id.AlwaysDisable = False
        Me.txt_chart_group_id.AlwaysEnable = False
        Me.txt_chart_group_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_chart_group_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chart_group_id.DataSource = ""
        Me.txt_chart_group_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_chart_group_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_chart_group_id.Enabled = False
        Me.txt_chart_group_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_chart_group_id.ispk = False
        Me.txt_chart_group_id.Location = New System.Drawing.Point(59, 34)
        Me.txt_chart_group_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_chart_group_id.MultiLine = False
        Me.txt_chart_group_id.Name = "txt_chart_group_id"
        Me.txt_chart_group_id.NoClear = False
        Me.txt_chart_group_id.NumberFormat = "@"
        Me.txt_chart_group_id.Required = True
        Me.txt_chart_group_id.RowData = Nothing
        Me.txt_chart_group_id.SelectionLength = 0
        Me.txt_chart_group_id.SelectionStart = 0
        Me.txt_chart_group_id.Size = New System.Drawing.Size(178, 20)
        Me.txt_chart_group_id.TabIndex = 1
        Me.txt_chart_group_id.TableData = Nothing
        Me.txt_chart_group_id.Tag = "focus"
        Me.txt_chart_group_id.TextSource = "chart_group_code"
        Me.txt_chart_group_id.UseSystemPasswordChar = False
        Me.txt_chart_group_id.Value = ""
        Me.txt_chart_group_id.ValueSource = "chart_group_id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Tag = "label"
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "label"
        Me.Label2.Text = "Code"
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
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.chart_group_id, Me.chart_group_code, Me.chart_group_name, Me.chart_group_multiple_id})
        Me.dgMain.Location = New System.Drawing.Point(20, 70)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(460, 156)
        Me.dgMain.TabIndex = 74
        Me.dgMain.Tag = "maingrid"
        '
        'cboxAllHeader
        '
        Me.cboxAllHeader.AutoSize = True
        Me.cboxAllHeader.Location = New System.Drawing.Point(27, 78)
        Me.cboxAllHeader.Name = "cboxAllHeader"
        Me.cboxAllHeader.Size = New System.Drawing.Size(15, 14)
        Me.cboxAllHeader.TabIndex = 75
        Me.cboxAllHeader.UseVisualStyleBackColor = True
        '
        'btnNotSave
        '
        Me.btnNotSave.BackColor = System.Drawing.Color.Maroon
        Me.btnNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotSave.ForeColor = System.Drawing.Color.White
        Me.btnNotSave.Location = New System.Drawing.Point(126, 233)
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(100, 23)
        Me.btnNotSave.TabIndex = 80
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
        Me.btnSave.Location = New System.Drawing.Point(20, 233)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 79
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
        Me.btnRemove.Location = New System.Drawing.Point(157, 233)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(60, 23)
        Me.btnRemove.TabIndex = 78
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
        Me.btnUpdate.Location = New System.Drawing.Point(91, 233)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(60, 23)
        Me.btnUpdate.TabIndex = 77
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
        Me.btnInsert.Location = New System.Drawing.Point(25, 233)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(60, 23)
        Me.btnInsert.TabIndex = 76
        Me.btnInsert.Tag = "btnInsert"
        Me.btnInsert.Text = "Add"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(20, 65)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(460, 2)
        Me.border1.TabIndex = 19
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 81
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
        'chart_group_id
        '
        Me.chart_group_id.DataPropertyName = "chart_group_id"
        Me.chart_group_id.HeaderText = "ID"
        Me.chart_group_id.Name = "chart_group_id"
        Me.chart_group_id.ReadOnly = True
        Me.chart_group_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.chart_group_id.Visible = False
        '
        'chart_group_code
        '
        Me.chart_group_code.DataPropertyName = "chart_group_code"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chart_group_code.DefaultCellStyle = DataGridViewCellStyle1
        Me.chart_group_code.HeaderText = "Code"
        Me.chart_group_code.Name = "chart_group_code"
        Me.chart_group_code.ReadOnly = True
        Me.chart_group_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'chart_group_name
        '
        Me.chart_group_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.chart_group_name.DataPropertyName = "chart_group_name"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.chart_group_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.chart_group_name.HeaderText = "Group Name"
        Me.chart_group_name.Name = "chart_group_name"
        Me.chart_group_name.ReadOnly = True
        Me.chart_group_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'chart_group_multiple_id
        '
        Me.chart_group_multiple_id.DataPropertyName = "chart_group_multiple_id"
        Me.chart_group_multiple_id.HeaderText = "ID"
        Me.chart_group_multiple_id.Name = "chart_group_multiple_id"
        Me.chart_group_multiple_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chart_group_multiple_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.chart_group_multiple_id.Visible = False
        '
        'multiplegroupsetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 374)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.cboxAllHeader)
        Me.Controls.Add(Me.gboxContainer)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "multiplegroupsetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mutiple Group Setup"
        Me.gboxContainer.ResumeLayout(False)
        Me.gboxContainer.PerformLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gboxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_chart_group_multiple_id As user_control.textbox
    Friend WithEvents txt_chart_group_name As user_control.textbox
    Friend WithEvents txt_chart_group_id As user_control.textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents cboxAllHeader As System.Windows.Forms.CheckBox
    Friend WithEvents btnNotSave As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chart_group_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_group_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_group_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chart_group_multiple_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
