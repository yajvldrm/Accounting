<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chart_report_filter
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
        Me.chk_description = New System.Windows.Forms.CheckBox()
        Me.chk_group_code = New System.Windows.Forms.CheckBox()
        Me.txt_sort_by = New user_control.textbox()
        Me.txt_group_id = New user_control.textbox()
        Me.txt_group_by = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.border1 = New accounting.borderedlabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Print Accounts"
        '
        'chk_description
        '
        Me.chk_description.AutoSize = True
        Me.chk_description.Location = New System.Drawing.Point(36, 70)
        Me.chk_description.Name = "chk_description"
        Me.chk_description.Size = New System.Drawing.Size(104, 17)
        Me.chk_description.TabIndex = 9
        Me.chk_description.Text = "With Description"
        Me.chk_description.UseVisualStyleBackColor = True
        Me.chk_description.Visible = False
        '
        'chk_group_code
        '
        Me.chk_group_code.AutoSize = True
        Me.chk_group_code.Checked = True
        Me.chk_group_code.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_group_code.Location = New System.Drawing.Point(146, 70)
        Me.chk_group_code.Name = "chk_group_code"
        Me.chk_group_code.Size = New System.Drawing.Size(108, 17)
        Me.chk_group_code.TabIndex = 10
        Me.chk_group_code.Text = "With Group Code"
        Me.chk_group_code.UseVisualStyleBackColor = True
        '
        'txt_sort_by
        '
        Me.txt_sort_by._Text = ""
        Me.txt_sort_by.AllowNegative = False
        Me.txt_sort_by.AlwaysDisable = False
        Me.txt_sort_by.AlwaysEnable = False
        Me.txt_sort_by.BackColor = System.Drawing.Color.White
        Me.txt_sort_by.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_sort_by.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sort_by.DataSource = ""
        Me.txt_sort_by.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sort_by.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_sort_by.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_sort_by.EnabledBackColor = System.Drawing.Color.White
        Me.txt_sort_by.ispk = False
        Me.txt_sort_by.Location = New System.Drawing.Point(82, 93)
        Me.txt_sort_by.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sort_by.MultiLine = False
        Me.txt_sort_by.Name = "txt_sort_by"
        Me.txt_sort_by.NoClear = False
        Me.txt_sort_by.NumberFormat = "@"
        Me.txt_sort_by.Required = False
        Me.txt_sort_by.RowData = Nothing
        Me.txt_sort_by.SelectionLength = 0
        Me.txt_sort_by.SelectionStart = 0
        Me.txt_sort_by.Size = New System.Drawing.Size(180, 20)
        Me.txt_sort_by.TabIndex = 11
        Me.txt_sort_by.TableData = Nothing
        Me.txt_sort_by.TextSource = ""
        Me.txt_sort_by.UseSystemPasswordChar = False
        Me.txt_sort_by.Value = ""
        Me.txt_sort_by.ValueSource = ""
        '
        'txt_group_id
        '
        Me.txt_group_id._Text = ""
        Me.txt_group_id.AllowNegative = False
        Me.txt_group_id.AlwaysDisable = False
        Me.txt_group_id.AlwaysEnable = False
        Me.txt_group_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_group_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_group_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_group_id.DataSource = ""
        Me.txt_group_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_group_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_group_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_group_id.Enabled = False
        Me.txt_group_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_group_id.ispk = False
        Me.txt_group_id.Location = New System.Drawing.Point(82, 119)
        Me.txt_group_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_group_id.MultiLine = False
        Me.txt_group_id.Name = "txt_group_id"
        Me.txt_group_id.NoClear = False
        Me.txt_group_id.NumberFormat = "@"
        Me.txt_group_id.Required = False
        Me.txt_group_id.RowData = Nothing
        Me.txt_group_id.SelectionLength = 0
        Me.txt_group_id.SelectionStart = 0
        Me.txt_group_id.Size = New System.Drawing.Size(180, 20)
        Me.txt_group_id.TabIndex = 12
        Me.txt_group_id.TableData = Nothing
        Me.txt_group_id.TextSource = ""
        Me.txt_group_id.UseSystemPasswordChar = False
        Me.txt_group_id.Value = ""
        Me.txt_group_id.ValueSource = ""
        '
        'txt_group_by
        '
        Me.txt_group_by._Text = ""
        Me.txt_group_by.AllowNegative = False
        Me.txt_group_by.AlwaysDisable = False
        Me.txt_group_by.AlwaysEnable = False
        Me.txt_group_by.BackColor = System.Drawing.Color.White
        Me.txt_group_by.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_group_by.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_group_by.DataSource = ""
        Me.txt_group_by.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_group_by.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_group_by.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_group_by.EnabledBackColor = System.Drawing.Color.White
        Me.txt_group_by.ispk = False
        Me.txt_group_by.Location = New System.Drawing.Point(82, 145)
        Me.txt_group_by.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_group_by.MultiLine = False
        Me.txt_group_by.Name = "txt_group_by"
        Me.txt_group_by.NoClear = False
        Me.txt_group_by.NumberFormat = "@"
        Me.txt_group_by.Required = False
        Me.txt_group_by.RowData = Nothing
        Me.txt_group_by.SelectionLength = 0
        Me.txt_group_by.SelectionStart = 0
        Me.txt_group_by.Size = New System.Drawing.Size(180, 20)
        Me.txt_group_by.TabIndex = 13
        Me.txt_group_by.TableData = Nothing
        Me.txt_group_by.TextSource = ""
        Me.txt_group_by.UseSystemPasswordChar = False
        Me.txt_group_by.Value = ""
        Me.txt_group_by.ValueSource = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Filter By"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Order By"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(67, 171)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(149, 171)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(290, 28)
        Me.Myformheader1.TabIndex = 18
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(12, 171)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnExcel.TabIndex = 19
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        Me.btnExcel.Visible = False
        '
        'btnPrintOption
        '
        Me.btnPrintOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrintOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrintOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(68, 171)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintOption.TabIndex = 1
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 60)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(265, 2)
        Me.border1.TabIndex = 8
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chart_report_filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_group_by)
        Me.Controls.Add(Me.txt_group_id)
        Me.Controls.Add(Me.txt_sort_by)
        Me.Controls.Add(Me.chk_group_code)
        Me.Controls.Add(Me.chk_description)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExcel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "chart_report_filter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_description As System.Windows.Forms.CheckBox
    Friend WithEvents chk_group_code As System.Windows.Forms.CheckBox
    Friend WithEvents txt_sort_by As user_control.textbox
    Friend WithEvents txt_group_id As user_control.textbox
    Friend WithEvents txt_group_by As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
End Class
