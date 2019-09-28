<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class trans_detailed_particulars
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.trans_header_detailed_particular = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.dsDetailedParticular = New System.Data.DataSet()
        Me.Myformheader1 = New user_control.myformheader()
        Me.lbl_trans = New System.Windows.Forms.Label()
        Me.dgMainDetailed = New System.Windows.Forms.DataGridView()
        Me.border1 = New accounting.borderedlabel()
        Me.border2 = New accounting.borderedlabel()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.trans_detailed_particular_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.po_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rr_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dr_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.si_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_header_detailed_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.trans_header_detailed_particular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDetailedParticular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMainDetailed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Maroon
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(661, 84)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 23)
        Me.btnRemove.TabIndex = 327
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Green
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(575, 84)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 23)
        Me.btnInsert.TabIndex = 326
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "deleted"
        Me.DataColumn7.DataType = GetType(Boolean)
        Me.DataColumn7.DefaultValue = False
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "trans_id"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "dr_no"
        Me.DataColumn5.ColumnName = "dr_no"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "rr_no"
        Me.DataColumn4.ColumnName = "rr_no"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "po_no"
        Me.DataColumn3.ColumnName = "po_no"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_detailed_particular_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'trans_header_detailed_particular
        '
        Me.trans_header_detailed_particular.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.trans_header_detailed_particular.TableName = "trans_header_detailed_particular"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sel"
        Me.DataColumn1.DataType = GetType(Boolean)
        Me.DataColumn1.DefaultValue = False
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "si_no"
        Me.DataColumn8.ColumnName = "si_no"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "due_date"
        Me.DataColumn9.ColumnName = "due_date"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "trans_header_detailed_amount"
        Me.DataColumn10.ColumnName = "trans_header_detailed_amount"
        Me.DataColumn10.DefaultValue = "0.00"
        '
        'dsDetailedParticular
        '
        Me.dsDetailedParticular.DataSetName = "dsDetailedParticular"
        Me.dsDetailedParticular.Tables.AddRange(New System.Data.DataTable() {Me.trans_header_detailed_particular})
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(3, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(762, 27)
        Me.Myformheader1.TabIndex = 319
        '
        'lbl_trans
        '
        Me.lbl_trans.AutoSize = True
        Me.lbl_trans.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbl_trans.Location = New System.Drawing.Point(15, 30)
        Me.lbl_trans.Name = "lbl_trans"
        Me.lbl_trans.Size = New System.Drawing.Size(219, 25)
        Me.lbl_trans.TabIndex = 320
        Me.lbl_trans.Text = "Detailed Particulars"
        '
        'dgMainDetailed
        '
        Me.dgMainDetailed.AllowUserToAddRows = False
        Me.dgMainDetailed.AllowUserToDeleteRows = False
        Me.dgMainDetailed.AllowUserToResizeRows = False
        Me.dgMainDetailed.AutoGenerateColumns = False
        Me.dgMainDetailed.BackgroundColor = System.Drawing.Color.White
        Me.dgMainDetailed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgMainDetailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMainDetailed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.trans_detailed_particular_id, Me.trans_id, Me.po_no, Me.rr_no, Me.dr_no, Me.si_no, Me.due_date, Me.trans_header_detailed_amount, Me.deleted})
        Me.dgMainDetailed.DataSource = Me.dsDetailedParticular
        Me.dgMainDetailed.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgMainDetailed.Location = New System.Drawing.Point(20, 113)
        Me.dgMainDetailed.MultiSelect = False
        Me.dgMainDetailed.Name = "dgMainDetailed"
        Me.dgMainDetailed.RowHeadersVisible = False
        Me.dgMainDetailed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgMainDetailed.Size = New System.Drawing.Size(725, 369)
        Me.dgMainDetailed.TabIndex = 323
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 76)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(733, 2)
        Me.border1.TabIndex = 321
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(12, 78)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(733, 2)
        Me.border2.TabIndex = 322
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Width = 32
        '
        'trans_detailed_particular_id
        '
        Me.trans_detailed_particular_id.DataPropertyName = "trans_detailed_particular_id"
        Me.trans_detailed_particular_id.HeaderText = "id"
        Me.trans_detailed_particular_id.Name = "trans_detailed_particular_id"
        Me.trans_detailed_particular_id.Visible = False
        '
        'trans_id
        '
        Me.trans_id.DataPropertyName = "trans_id"
        Me.trans_id.HeaderText = "trans_id"
        Me.trans_id.Name = "trans_id"
        Me.trans_id.Visible = False
        '
        'po_no
        '
        Me.po_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.po_no.DataPropertyName = "po_no"
        Me.po_no.HeaderText = "PO #"
        Me.po_no.Name = "po_no"
        '
        'rr_no
        '
        Me.rr_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.rr_no.DataPropertyName = "rr_no"
        Me.rr_no.HeaderText = "RR #"
        Me.rr_no.Name = "rr_no"
        '
        'dr_no
        '
        Me.dr_no.DataPropertyName = "dr_no"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dr_no.DefaultCellStyle = DataGridViewCellStyle1
        Me.dr_no.HeaderText = "DR #"
        Me.dr_no.Name = "dr_no"
        Me.dr_no.Width = 105
        '
        'si_no
        '
        Me.si_no.DataPropertyName = "si_no"
        Me.si_no.HeaderText = "SI #"
        Me.si_no.Name = "si_no"
        Me.si_no.Width = 105
        '
        'due_date
        '
        Me.due_date.DataPropertyName = "due_date"
        Me.due_date.HeaderText = "DR Date"
        Me.due_date.Name = "due_date"
        Me.due_date.Width = 130
        '
        'trans_header_detailed_amount
        '
        Me.trans_header_detailed_amount.DataPropertyName = "trans_header_detailed_amount"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.trans_header_detailed_amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.trans_header_detailed_amount.HeaderText = "Amount"
        Me.trans_header_detailed_amount.Name = "trans_header_detailed_amount"
        Me.trans_header_detailed_amount.Width = 150
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
        'trans_detailed_particulars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 494)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.dgMainDetailed)
        Me.Controls.Add(Me.lbl_trans)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "trans_detailed_particulars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detailed Particulars"
        CType(Me.trans_header_detailed_particular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDetailedParticular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMainDetailed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents btnInsert As Windows.Forms.Button
    Friend WithEvents border1 As borderedlabel
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents border2 As borderedlabel
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents trans_header_detailed_particular As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents dsDetailedParticular As DataSet
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents lbl_trans As Windows.Forms.Label
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents dgMainDetailed As Windows.Forms.DataGridView
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents trans_detailed_particular_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents po_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rr_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents si_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_header_detailed_amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As Windows.Forms.DataGridViewCheckBoxColumn
End Class
