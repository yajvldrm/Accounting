<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.txtBrowse = New user_control.MyTextBox()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.AllowUserToResizeColumns = False
        Me.dgview.AllowUserToResizeRows = False
        Me.dgview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Location = New System.Drawing.Point(12, 12)
        Me.dgview.MultiSelect = False
        Me.dgview.Name = "dgview"
        Me.dgview.RowHeadersVisible = False
        Me.dgview.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgview.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.dgview.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(260, 284)
        Me.dgview.TabIndex = 5
        '
        'txtBrowse
        '
        Me.txtBrowse.AlwaysDisable = False
        Me.txtBrowse.AlwaysEnable = False
        Me.txtBrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrowse.BrowseDataSource = ""
        Me.txtBrowse.BrowseField = ""
        Me.txtBrowse.BrowseFilter = Nothing
        Me.txtBrowse.BrowseLabel = "Code,Name"
        Me.txtBrowse.BrowseLabelWidth = "100,200"
        Me.txtBrowse.BrowseTextSource = ""
        Me.txtBrowse.BrowseValueSource = ""
        Me.txtBrowse.Database = user_control.MyList.Database.FileSetup
        Me.txtBrowse.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBrowse.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBrowse.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtBrowse.Enabled = False
        Me.txtBrowse.EnabledBackColor = System.Drawing.Color.White
        Me.txtBrowse.EnabledForeColor = System.Drawing.Color.Black
        Me.txtBrowse.ForeColor = System.Drawing.Color.Black
        Me.txtBrowse.ID = False
        Me.txtBrowse.Location = New System.Drawing.Point(59, 302)
        Me.txtBrowse.Name = "txtBrowse"
        Me.txtBrowse.NoClear = False
        Me.txtBrowse.NoSave = False
        Me.txtBrowse.NumberFormat = "@"
        Me.txtBrowse.Required = False
        Me.txtBrowse.RowData = Nothing
        Me.txtBrowse.Size = New System.Drawing.Size(219, 20)
        Me.txtBrowse.TabIndex = 3
        Me.txtBrowse.TextBrowse = False
        Me.txtBrowse.TextSource = ""
        Me.txtBrowse.ToUpper = True
        Me.txtBrowse.Unique = False
        Me.txtBrowse.Value = ""
        Me.txtBrowse.ValueSource = ""
        '
        'browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.txtBrowse)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(300, 350)
        Me.Name = "browser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBrowse As user_control.MyTextBox
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
End Class
