<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMain2 = New System.Windows.Forms.DataGridView()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMain2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(95, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Sales Per Day"
        '
        'dgMain2
        '
        Me.dgMain2.AllowUserToAddRows = False
        Me.dgMain2.AllowUserToDeleteRows = False
        Me.dgMain2.AllowUserToResizeColumns = False
        Me.dgMain2.AllowUserToResizeRows = False
        Me.dgMain2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.general_name, Me.debit})
        Me.dgMain2.Location = New System.Drawing.Point(10, 40)
        Me.dgMain2.MultiSelect = False
        Me.dgMain2.Name = "dgMain2"
        Me.dgMain2.RowHeadersVisible = False
        Me.dgMain2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain2.Size = New System.Drawing.Size(245, 290)
        Me.dgMain2.TabIndex = 204
        '
        'general_name
        '
        Me.general_name.DataPropertyName = "trans_date"
        Me.general_name.HeaderText = "Month"
        Me.general_name.Name = "general_name"
        Me.general_name.ReadOnly = True
        '
        'debit
        '
        Me.debit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.debit.DataPropertyName = "amount"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "##,##0.00"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle1
        Me.debit.HeaderText = "Amount"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(265, 370)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMain2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sales"
        Me.Text = "Sales"
        CType(Me.dgMain2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMain2 As System.Windows.Forms.DataGridView
    Friend WithEvents general_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
