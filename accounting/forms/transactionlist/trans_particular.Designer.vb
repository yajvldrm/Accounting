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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Myformheader1 = New user_control.myformheader()
        Me.lbl_trans = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.trans_particular_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_particular_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_particular_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_particular_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dsParticular = New System.Data.DataSet()
        Me.trans_header_particular = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txt_description = New user_control.MyTextBox()
        Me.btnParticular = New System.Windows.Forms.PictureBox()
        Me.border1 = New accounting.borderedlabel()
        Me.border2 = New accounting.borderedlabel()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsParticular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_header_particular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnParticular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(450, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'lbl_trans
        '
        Me.lbl_trans.AutoSize = True
        Me.lbl_trans.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbl_trans.Location = New System.Drawing.Point(12, 31)
        Me.lbl_trans.Name = "lbl_trans"
        Me.lbl_trans.Size = New System.Drawing.Size(115, 25)
        Me.lbl_trans.TabIndex = 280
        Me.lbl_trans.Text = "Particular"
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.AutoGenerateColumns = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.trans_particular_id, Me.trans_id, Me.trans_particular_code, Me.trans_particular_name, Me.trans_particular_amount, Me.deleted})
        Me.dgMain.DataSource = Me.dsParticular
        Me.dgMain.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgMain.Location = New System.Drawing.Point(15, 173)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgMain.Size = New System.Drawing.Size(421, 205)
        Me.dgMain.TabIndex = 284
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'trans_particular_id
        '
        Me.trans_particular_id.DataPropertyName = "trans_particular_id"
        Me.trans_particular_id.HeaderText = "id"
        Me.trans_particular_id.Name = "trans_particular_id"
        Me.trans_particular_id.Visible = False
        '
        'trans_id
        '
        Me.trans_id.DataPropertyName = "trans_id"
        Me.trans_id.HeaderText = "trans_id"
        Me.trans_id.Name = "trans_id"
        Me.trans_id.Visible = False
        '
        'trans_particular_code
        '
        Me.trans_particular_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.trans_particular_code.DataPropertyName = "trans_particular_code"
        Me.trans_particular_code.HeaderText = "Particular"
        Me.trans_particular_code.Name = "trans_particular_code"
        Me.trans_particular_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'trans_particular_name
        '
        Me.trans_particular_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.trans_particular_name.DataPropertyName = "trans_particular_name"
        Me.trans_particular_name.HeaderText = "Description"
        Me.trans_particular_name.Name = "trans_particular_name"
        Me.trans_particular_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'trans_particular_amount
        '
        Me.trans_particular_amount.DataPropertyName = "trans_particular_amount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "##,##0.00"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.trans_particular_amount.DefaultCellStyle = DataGridViewCellStyle1
        Me.trans_particular_amount.HeaderText = "Amount"
        Me.trans_particular_amount.Name = "trans_particular_amount"
        Me.trans_particular_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'dsParticular
        '
        Me.dsParticular.DataSetName = "dsParticular"
        Me.dsParticular.Tables.AddRange(New System.Data.DataTable() {Me.trans_header_particular})
        '
        'trans_header_particular
        '
        Me.trans_header_particular.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.trans_header_particular.TableName = "trans_header_particular"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_particular_id"
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
        Me.DataColumn6.ColumnName = "trans_id"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "deleted"
        Me.DataColumn7.DataType = GetType(Boolean)
        Me.DataColumn7.DefaultValue = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 304
        Me.Label4.Text = "General Particular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 305
        Me.Label5.Text = "Detailed Particular"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Green
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(270, 144)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 306
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Maroon
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(356, 144)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 24)
        Me.btnRemove.TabIndex = 307
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'txt_description
        '
        Me.txt_description.AlwaysDisable = False
        Me.txt_description.AlwaysEnable = False
        Me.txt_description.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_description.BrowseDataSource = ""
        Me.txt_description.BrowseField = ""
        Me.txt_description.BrowseFilter = Nothing
        Me.txt_description.BrowseLabel = "Code,Name"
        Me.txt_description.BrowseLabelWidth = "100,200"
        Me.txt_description.BrowseTextSource = ""
        Me.txt_description.BrowseValueSource = ""
        Me.txt_description.Database = user_control.MyList.Database.FileSetup
        Me.txt_description.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_description.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_description.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_description.Enabled = False
        Me.txt_description.EnabledBackColor = System.Drawing.Color.White
        Me.txt_description.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_description.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.txt_description.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_description.ID = False
        Me.txt_description.Location = New System.Drawing.Point(15, 90)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.NoClear = False
        Me.txt_description.NoSave = False
        Me.txt_description.NumberFormat = "@"
        Me.txt_description.Required = False
        Me.txt_description.RowData = Nothing
        Me.txt_description.Size = New System.Drawing.Size(421, 48)
        Me.txt_description.TabIndex = 308
        Me.txt_description.TextBrowse = False
        Me.txt_description.TextSource = "description"
        Me.txt_description.ToUpper = False
        Me.txt_description.Unique = False
        Me.txt_description.Value = ""
        Me.txt_description.ValueSource = ""
        '
        'btnParticular
        '
        Me.btnParticular.Image = Global.accounting.My.Resources.Resources.Table_Icon
        Me.btnParticular.Location = New System.Drawing.Point(411, 67)
        Me.btnParticular.Name = "btnParticular"
        Me.btnParticular.Size = New System.Drawing.Size(25, 25)
        Me.btnParticular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnParticular.TabIndex = 318
        Me.btnParticular.TabStop = False
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
        Me.ClientSize = New System.Drawing.Size(450, 390)
        Me.Controls.Add(Me.btnParticular)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.lbl_trans)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "trans_particular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Particular"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsParticular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_header_particular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnParticular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents lbl_trans As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents dsParticular As System.Data.DataSet
    Friend WithEvents trans_header_particular As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents txt_description As user_control.MyTextBox
    Friend WithEvents btnParticular As System.Windows.Forms.PictureBox
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents trans_particular_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_particular_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_particular_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_particular_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As Windows.Forms.DataGridViewCheckBoxColumn
End Class
