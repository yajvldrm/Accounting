<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class offsetinputvat
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
        Me.border2 = New accounting.borderedlabel()
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdNotSave = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Borderedlabel1 = New accounting.borderedlabel()
        Me.Borderedlabel2 = New accounting.borderedlabel()
        Me.dgOffset = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'border2
        '
        Me.border2.BorderColor = System.Drawing.Color.White
        Me.border2.Location = New System.Drawing.Point(12, 42)
        Me.border2.Name = "border2"
        Me.border2.Size = New System.Drawing.Size(813, 2)
        Me.border2.TabIndex = 5
        Me.border2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 40)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(813, 2)
        Me.border1.TabIndex = 4
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input VAT Offsetting"
        '
        'cmdNotSave
        '
        Me.cmdNotSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdNotSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdNotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.cmdNotSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.cmdNotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNotSave.Location = New System.Drawing.Point(421, 466)
        Me.cmdNotSave.Name = "cmdNotSave"
        Me.cmdNotSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdNotSave.TabIndex = 50
        Me.cmdNotSave.Text = "Cancel"
        Me.cmdNotSave.UseVisualStyleBackColor = False
        Me.cmdNotSave.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(315, 466)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdSave.TabIndex = 49
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        Me.cmdSave.Visible = False
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamount.Enabled = False
        Me.txtamount.Location = New System.Drawing.Point(566, 426)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(140, 21)
        Me.txtamount.TabIndex = 52
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(521, 430)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "TOTAL"
        '
        'Borderedlabel1
        '
        Me.Borderedlabel1.BorderColor = System.Drawing.Color.White
        Me.Borderedlabel1.Location = New System.Drawing.Point(12, 455)
        Me.Borderedlabel1.Name = "Borderedlabel1"
        Me.Borderedlabel1.Size = New System.Drawing.Size(813, 2)
        Me.Borderedlabel1.TabIndex = 54
        Me.Borderedlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Borderedlabel2
        '
        Me.Borderedlabel2.BorderColor = System.Drawing.Color.DarkGray
        Me.Borderedlabel2.Location = New System.Drawing.Point(12, 453)
        Me.Borderedlabel2.Name = "Borderedlabel2"
        Me.Borderedlabel2.Size = New System.Drawing.Size(813, 2)
        Me.Borderedlabel2.TabIndex = 53
        Me.Borderedlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgOffset
        '
        Me.dgOffset.AllowUserToAddRows = False
        Me.dgOffset.AllowUserToDeleteRows = False
        Me.dgOffset.AllowUserToResizeColumns = False
        Me.dgOffset.AllowUserToResizeRows = False
        Me.dgOffset.ColumnHeadersHeight = 28
        Me.dgOffset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgOffset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgOffset.Location = New System.Drawing.Point(12, 52)
        Me.dgOffset.Name = "dgOffset"
        Me.dgOffset.RowHeadersVisible = False
        Me.dgOffset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOffset.Size = New System.Drawing.Size(813, 371)
        Me.dgOffset.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Reference No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Reference Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Journal Code"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Gen. Ref."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 160
        '
        'Column5
        '
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 30
        '
        'Column7
        '
        Me.Column7.HeaderText = "Amount Remitted"
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column7.Width = 120
        '
        'Column8
        '
        Me.Column8.HeaderText = "Balance"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'offsetinputvat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 501)
        Me.Controls.Add(Me.Borderedlabel1)
        Me.Controls.Add(Me.Borderedlabel2)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdNotSave)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.border2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgOffset)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "offsetinputvat"
        Me.Text = "Input VAT Offsetting"
        CType(Me.dgOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border2 As accounting.borderedlabel
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdNotSave As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Borderedlabel1 As accounting.borderedlabel
    Friend WithEvents Borderedlabel2 As accounting.borderedlabel
    Friend WithEvents dgOffset As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
