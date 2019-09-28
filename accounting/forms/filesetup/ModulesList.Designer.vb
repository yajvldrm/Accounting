<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModulesList
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.module_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(300, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 62)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(275, 2)
        Me.border1.TabIndex = 91
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Select Module"
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.module_id, Me.module_name})
        Me.dgMain.Location = New System.Drawing.Point(12, 67)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.ReadOnly = True
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(276, 221)
        Me.dgMain.TabIndex = 92
        '
        'module_id
        '
        Me.module_id.DataPropertyName = "module_id"
        Me.module_id.HeaderText = "module_id"
        Me.module_id.Name = "module_id"
        Me.module_id.ReadOnly = True
        Me.module_id.Visible = False
        '
        'module_name
        '
        Me.module_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.module_name.DataPropertyName = "module_name"
        Me.module_name.HeaderText = "Module Name"
        Me.module_name.Name = "module_name"
        Me.module_name.ReadOnly = True
        '
        'ModulesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ModulesList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modules"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents module_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents module_name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
