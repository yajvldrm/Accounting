<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checks
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
        Me.range_filter = New System.Windows.Forms.Panel()
        Me.rdo2 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.grp_bank = New System.Windows.Forms.GroupBox()
        Me.txt_bank = New user_control.MyTextBox()
        Me.rdo_per_bank = New user_control.rdo_button()
        Me.rdo_all_bank = New user_control.rdo_button()
        Me.grp_payee = New System.Windows.Forms.GroupBox()
        Me.txt_payee = New user_control.MyTextBox()
        Me.rdo_per_payee = New user_control.rdo_button()
        Me.rdo_all_payee = New user_control.rdo_button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.range_filter.SuspendLayout()
        Me.grp_bank.SuspendLayout()
        Me.grp_payee.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(250, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'range_filter
        '
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Location = New System.Drawing.Point(15, 35)
        Me.range_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(220, 25)
        Me.range_filter.TabIndex = 216
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.DataSource = ""
        Me.rdo2.Location = New System.Drawing.Point(102, 4)
        Me.rdo2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(101, 17)
        Me.rdo2.TabIndex = 2
        Me.rdo2.Text = "To Date / As Of"
        Me.rdo2.TextSource = ""
        Me.rdo2.Uncheckable = False
        Me.rdo2.UseVisualStyleBackColor = True
        Me.rdo2.Value = "2"
        Me.rdo2.ValueSource = ""
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Checked = True
        Me.rdo1.DataSource = ""
        Me.rdo1.Location = New System.Drawing.Point(17, 4)
        Me.rdo1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(81, 17)
        Me.rdo1.TabIndex = 1
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Range Only"
        Me.rdo1.TextSource = ""
        Me.rdo1.Uncheckable = False
        Me.rdo1.UseVisualStyleBackColor = True
        Me.rdo1.Value = "1"
        Me.rdo1.ValueSource = ""
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(91, 68)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(120, 20)
        Me.txt_date_from.TabIndex = 214
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "Date From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 218
        Me.Label3.Text = "Date To"
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(91, 96)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(120, 20)
        Me.txt_date_to.TabIndex = 215
        '
        'grp_bank
        '
        Me.grp_bank.Controls.Add(Me.lblLoad)
        Me.grp_bank.Controls.Add(Me.txt_bank)
        Me.grp_bank.Controls.Add(Me.rdo_per_bank)
        Me.grp_bank.Controls.Add(Me.rdo_all_bank)
        Me.grp_bank.Location = New System.Drawing.Point(16, 123)
        Me.grp_bank.Name = "grp_bank"
        Me.grp_bank.Size = New System.Drawing.Size(219, 70)
        Me.grp_bank.TabIndex = 222
        Me.grp_bank.TabStop = False
        Me.grp_bank.Text = "Bank"
        '
        'txt_bank
        '
        Me.txt_bank.AlwaysDisable = False
        Me.txt_bank.AlwaysEnable = False
        Me.txt_bank.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bank.BrowseDataSource = "lib_erp_bank"
        Me.txt_bank.BrowseField = "bank_code,bank_name"
        Me.txt_bank.BrowseFilter = Nothing
        Me.txt_bank.BrowseLabel = "Code,Name"
        Me.txt_bank.BrowseLabelWidth = "200,400"
        Me.txt_bank.BrowseTextSource = "bank_name"
        Me.txt_bank.BrowseValueSource = "bank_id"
        Me.txt_bank.Database = user_control.MyList.Database.FileSetup
        Me.txt_bank.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_bank.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bank.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank.Enabled = False
        Me.txt_bank.EnabledBackColor = System.Drawing.Color.White
        Me.txt_bank.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_bank.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_bank.ID = False
        Me.txt_bank.Location = New System.Drawing.Point(96, 40)
        Me.txt_bank.Name = "txt_bank"
        Me.txt_bank.NoClear = False
        Me.txt_bank.NoSave = False
        Me.txt_bank.NumberFormat = "@"
        Me.txt_bank.Required = False
        Me.txt_bank.RowData = Nothing
        Me.txt_bank.Size = New System.Drawing.Size(110, 20)
        Me.txt_bank.TabIndex = 225
        Me.txt_bank.TextBrowse = True
        Me.txt_bank.TextSource = ""
        Me.txt_bank.ToUpper = True
        Me.txt_bank.Unique = False
        Me.txt_bank.Value = ""
        Me.txt_bank.ValueSource = ""
        '
        'rdo_per_bank
        '
        Me.rdo_per_bank.AutoSize = True
        Me.rdo_per_bank.DataSource = ""
        Me.rdo_per_bank.Location = New System.Drawing.Point(16, 40)
        Me.rdo_per_bank.Name = "rdo_per_bank"
        Me.rdo_per_bank.Size = New System.Drawing.Size(69, 17)
        Me.rdo_per_bank.TabIndex = 224
        Me.rdo_per_bank.Text = "Per Bank"
        Me.rdo_per_bank.TextSource = ""
        Me.rdo_per_bank.Uncheckable = False
        Me.rdo_per_bank.UseVisualStyleBackColor = True
        Me.rdo_per_bank.Value = ""
        Me.rdo_per_bank.ValueSource = ""
        '
        'rdo_all_bank
        '
        Me.rdo_all_bank.AutoSize = True
        Me.rdo_all_bank.Checked = True
        Me.rdo_all_bank.DataSource = ""
        Me.rdo_all_bank.Location = New System.Drawing.Point(16, 19)
        Me.rdo_all_bank.Name = "rdo_all_bank"
        Me.rdo_all_bank.Size = New System.Drawing.Size(36, 17)
        Me.rdo_all_bank.TabIndex = 222
        Me.rdo_all_bank.TabStop = True
        Me.rdo_all_bank.Text = "All"
        Me.rdo_all_bank.TextSource = ""
        Me.rdo_all_bank.Uncheckable = False
        Me.rdo_all_bank.UseVisualStyleBackColor = True
        Me.rdo_all_bank.Value = ""
        Me.rdo_all_bank.ValueSource = ""
        '
        'grp_payee
        '
        Me.grp_payee.Controls.Add(Me.txt_payee)
        Me.grp_payee.Controls.Add(Me.rdo_per_payee)
        Me.grp_payee.Controls.Add(Me.rdo_all_payee)
        Me.grp_payee.Location = New System.Drawing.Point(16, 199)
        Me.grp_payee.Name = "grp_payee"
        Me.grp_payee.Size = New System.Drawing.Size(219, 70)
        Me.grp_payee.TabIndex = 225
        Me.grp_payee.TabStop = False
        Me.grp_payee.Text = "Payee"
        '
        'txt_payee
        '
        Me.txt_payee.AlwaysDisable = False
        Me.txt_payee.AlwaysEnable = False
        Me.txt_payee.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_payee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_payee.BrowseDataSource = "lib_erp_general"
        Me.txt_payee.BrowseField = "general_code,general_name"
        Me.txt_payee.BrowseFilter = Nothing
        Me.txt_payee.BrowseLabel = "Code,Name"
        Me.txt_payee.BrowseLabelWidth = "200,400"
        Me.txt_payee.BrowseTextSource = "general_name"
        Me.txt_payee.BrowseValueSource = "general_id"
        Me.txt_payee.Database = user_control.MyList.Database.FileSetup
        Me.txt_payee.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_payee.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_payee.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_payee.Enabled = False
        Me.txt_payee.EnabledBackColor = System.Drawing.Color.White
        Me.txt_payee.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_payee.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_payee.ID = False
        Me.txt_payee.Location = New System.Drawing.Point(96, 40)
        Me.txt_payee.Name = "txt_payee"
        Me.txt_payee.NoClear = False
        Me.txt_payee.NoSave = False
        Me.txt_payee.NumberFormat = "@"
        Me.txt_payee.Required = False
        Me.txt_payee.RowData = Nothing
        Me.txt_payee.Size = New System.Drawing.Size(110, 20)
        Me.txt_payee.TabIndex = 226
        Me.txt_payee.TextBrowse = True
        Me.txt_payee.TextSource = ""
        Me.txt_payee.ToUpper = True
        Me.txt_payee.Unique = False
        Me.txt_payee.Value = ""
        Me.txt_payee.ValueSource = ""
        '
        'rdo_per_payee
        '
        Me.rdo_per_payee.AutoSize = True
        Me.rdo_per_payee.DataSource = ""
        Me.rdo_per_payee.Location = New System.Drawing.Point(16, 40)
        Me.rdo_per_payee.Name = "rdo_per_payee"
        Me.rdo_per_payee.Size = New System.Drawing.Size(74, 17)
        Me.rdo_per_payee.TabIndex = 224
        Me.rdo_per_payee.Text = "Per Payee"
        Me.rdo_per_payee.TextSource = ""
        Me.rdo_per_payee.Uncheckable = False
        Me.rdo_per_payee.UseVisualStyleBackColor = True
        Me.rdo_per_payee.Value = ""
        Me.rdo_per_payee.ValueSource = ""
        '
        'rdo_all_payee
        '
        Me.rdo_all_payee.AutoSize = True
        Me.rdo_all_payee.Checked = True
        Me.rdo_all_payee.DataSource = ""
        Me.rdo_all_payee.Location = New System.Drawing.Point(16, 19)
        Me.rdo_all_payee.Name = "rdo_all_payee"
        Me.rdo_all_payee.Size = New System.Drawing.Size(36, 17)
        Me.rdo_all_payee.TabIndex = 222
        Me.rdo_all_payee.TabStop = True
        Me.rdo_all_payee.Text = "All"
        Me.rdo_all_payee.TextSource = ""
        Me.rdo_all_payee.Uncheckable = False
        Me.rdo_all_payee.UseVisualStyleBackColor = True
        Me.rdo_all_payee.Value = ""
        Me.rdo_all_payee.ValueSource = ""
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(127, 276)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 25)
        Me.btnCancel.TabIndex = 276
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(49, 276)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 25)
        Me.btnPrint.TabIndex = 277
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btnPrintOption
        '
        Me.btnPrintOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrintOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrintOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintOption.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(49, 276)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 278
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(127, 277)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 279
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        Me.btnExcel.Visible = False
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(-4, -16)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(226, 103)
        Me.lblLoad.TabIndex = 280
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'checks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 317)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.grp_payee)
        Me.Controls.Add(Me.grp_bank)
        Me.Controls.Add(Me.range_filter)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "checks"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checks Report"
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        Me.grp_bank.ResumeLayout(False)
        Me.grp_bank.PerformLayout()
        Me.grp_payee.ResumeLayout(False)
        Me.grp_payee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents range_filter As System.Windows.Forms.Panel
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_bank As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_per_bank As user_control.rdo_button
    Friend WithEvents rdo_all_bank As user_control.rdo_button
    Friend WithEvents grp_payee As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_per_payee As user_control.rdo_button
    Friend WithEvents rdo_all_payee As user_control.rdo_button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents txt_bank As user_control.MyTextBox
    Friend WithEvents txt_payee As user_control.MyTextBox
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
