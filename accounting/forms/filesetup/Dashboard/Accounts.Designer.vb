<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMain4 = New System.Windows.Forms.DataGridView()
        Me.account_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primary_key = New user_control.textbox()
        CType(Me.dgMain4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(175, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Key Accounts"
        '
        'dgMain4
        '
        Me.dgMain4.AllowUserToAddRows = False
        Me.dgMain4.AllowUserToDeleteRows = False
        Me.dgMain4.AllowUserToResizeColumns = False
        Me.dgMain4.AllowUserToResizeRows = False
        Me.dgMain4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.account_id, Me.account_name})
        Me.dgMain4.Location = New System.Drawing.Point(12, 43)
        Me.dgMain4.MultiSelect = False
        Me.dgMain4.Name = "dgMain4"
        Me.dgMain4.RowHeadersVisible = False
        Me.dgMain4.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain4.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain4.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain4.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain4.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain4.Size = New System.Drawing.Size(400, 200)
        Me.dgMain4.TabIndex = 97
        Me.dgMain4.Tag = "maingrid"
        '
        'account_id
        '
        Me.account_id.DataPropertyName = "account_id"
        Me.account_id.HeaderText = "ID"
        Me.account_id.Name = "account_id"
        Me.account_id.ReadOnly = True
        Me.account_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.account_id.Width = 30
        '
        'account_name
        '
        Me.account_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.account_name.DataPropertyName = "account_name"
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.account_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.account_name.HeaderText = "Name"
        Me.account_name.Name = "account_name"
        Me.account_name.ReadOnly = True
        Me.account_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        Me.primary_key.Location = New System.Drawing.Point(174, 162)
        Me.primary_key.MultiLine = False
        Me.primary_key.Name = "primary_key"
        Me.primary_key.NoClear = False
        Me.primary_key.NumberFormat = "@"
        Me.primary_key.Required = False
        Me.primary_key.RowData = Nothing
        Me.primary_key.SelectionLength = 0
        Me.primary_key.SelectionStart = 0
        Me.primary_key.Size = New System.Drawing.Size(105, 20)
        Me.primary_key.TabIndex = 96
        Me.primary_key.TableData = Nothing
        Me.primary_key.TextSource = ""
        Me.primary_key.UseSystemPasswordChar = False
        Me.primary_key.Value = ""
        Me.primary_key.ValueSource = "account_id"
        Me.primary_key.Visible = False
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(425, 280)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.primary_key)
        Me.Controls.Add(Me.dgMain4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Accounts"
        Me.Text = "Accounts"
        CType(Me.dgMain4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMain4 As System.Windows.Forms.DataGridView
    Friend WithEvents account_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents primary_key As user_control.textbox
End Class
