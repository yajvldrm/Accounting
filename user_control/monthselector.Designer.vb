<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monthselector
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(monthselector))
        Me.btn_up = New System.Windows.Forms.Button()
        Me.btn_down = New System.Windows.Forms.Button()
        Me.txtmonth = New user_control.textbox()
        Me.SuspendLayout()
        '
        'btn_up
        '
        Me.btn_up.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_up.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_up.BackgroundImage = CType(resources.GetObject("btn_up.BackgroundImage"), System.Drawing.Image)
        Me.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up.Location = New System.Drawing.Point(80, 0)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(20, 9)
        Me.btn_up.TabIndex = 1
        Me.btn_up.TabStop = False
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'btn_down
        '
        Me.btn_down.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_down.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_down.BackgroundImage = CType(resources.GetObject("btn_down.BackgroundImage"), System.Drawing.Image)
        Me.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_down.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_down.Location = New System.Drawing.Point(80, 9)
        Me.btn_down.Name = "btn_down"
        Me.btn_down.Size = New System.Drawing.Size(20, 9)
        Me.btn_down.TabIndex = 2
        Me.btn_down.TabStop = False
        Me.btn_down.UseVisualStyleBackColor = False
        '
        'txtmonth
        '
        Me.txtmonth._Text = ""
        Me.txtmonth.AlwaysDisable = False
        Me.txtmonth.AlwaysEnable = False
        Me.txtmonth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmonth.BackColor = System.Drawing.Color.White
        Me.txtmonth.BorderColor = System.Drawing.Color.Transparent
        Me.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonth.DataSource = ""
        Me.txtmonth.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmonth.DisabledBackColor = System.Drawing.Color.White
        Me.txtmonth.DisabledForeColor = System.Drawing.Color.Black
        Me.txtmonth.Enabled = False
        Me.txtmonth.Location = New System.Drawing.Point(0, 0)
        Me.txtmonth.MultiLine = False
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.NoClear = False
        Me.txtmonth.NumberFormat = "@"
        Me.txtmonth.Required = False
        Me.txtmonth.RowData = Nothing
        Me.txtmonth.SelectionLength = 0
        Me.txtmonth.SelectionStart = 0
        Me.txtmonth.Size = New System.Drawing.Size(80, 18)
        Me.txtmonth.TabIndex = 0
        Me.txtmonth.TableData = Nothing
        Me.txtmonth.Tag = "1"
        Me.txtmonth.TextSource = ""
        Me.txtmonth.UseSystemPasswordChar = False
        Me.txtmonth.Value = "1"
        Me.txtmonth.ValueSource = ""
        '
        'monthselector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_down)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.txtmonth)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "monthselector"
        Me.Size = New System.Drawing.Size(100, 18)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtmonth As user_control.textbox
    Friend WithEvents btn_up As System.Windows.Forms.Button
    Friend WithEvents btn_down As System.Windows.Forms.Button

End Class
