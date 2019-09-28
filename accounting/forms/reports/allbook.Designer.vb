<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allbook
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.originalCurrency = New System.Windows.Forms.CheckBox()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_month = New System.Windows.Forms.ComboBox()
        Me.txt_year = New System.Windows.Forms.NumericUpDown()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.date_type = New user_control.MyRadioGroup()
        Me.rdo_3 = New user_control.MyRadioButton()
        Me.rdo_2 = New user_control.MyRadioButton()
        Me.rdo_1 = New user_control.MyRadioButton()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.withProject = New System.Windows.Forms.CheckBox()
        CType(Me.txt_year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.date_type.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(11, 31)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(92, 24)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "All Book"
        '
        'originalCurrency
        '
        Me.originalCurrency.AutoSize = True
        Me.originalCurrency.Location = New System.Drawing.Point(30, 102)
        Me.originalCurrency.Name = "originalCurrency"
        Me.originalCurrency.Size = New System.Drawing.Size(106, 17)
        Me.originalCurrency.TabIndex = 20
        Me.originalCurrency.Text = "Original Currency"
        Me.originalCurrency.UseVisualStyleBackColor = True
        '
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(234, 143)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_to.TabIndex = 22
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(102, 143)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_date_from.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "To"
        '
        'txt_month
        '
        Me.txt_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_month.FormattingEnabled = True
        Me.txt_month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txt_month.Location = New System.Drawing.Point(112, 169)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(121, 21)
        Me.txt_month.TabIndex = 26
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(239, 170)
        Me.txt_year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(50, 20)
        Me.txt_year.TabIndex = 27
        Me.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_year.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(122, 215)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(203, 215)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'date_type
        '
        Me.date_type.AlwaysDisable = False
        Me.date_type.AlwaysEnable = False
        Me.date_type.Controls.Add(Me.rdo_3)
        Me.date_type.Controls.Add(Me.rdo_2)
        Me.date_type.Controls.Add(Me.rdo_1)
        Me.date_type.Location = New System.Drawing.Point(143, 84)
        Me.date_type.Name = "date_type"
        Me.date_type.NoSave = False
        Me.date_type.Required = False
        Me.date_type.Size = New System.Drawing.Size(227, 45)
        Me.date_type.TabIndex = 21
        Me.date_type.TabStop = False
        Me.date_type.Value = ""
        Me.date_type.ValueSource = ""
        '
        'rdo_3
        '
        Me.rdo_3.AlwaysDisable = False
        Me.rdo_3.AlwaysEnable = False
        Me.rdo_3.AutoSize = True
        Me.rdo_3.Location = New System.Drawing.Point(128, 17)
        Me.rdo_3.Name = "rdo_3"
        Me.rdo_3.Size = New System.Drawing.Size(91, 17)
        Me.rdo_3.TabIndex = 2
        Me.rdo_3.Text = "For the Month"
        Me.rdo_3.Uncheckable = False
        Me.rdo_3.UseVisualStyleBackColor = True
        Me.rdo_3.Value = "3"
        '
        'rdo_2
        '
        Me.rdo_2.AlwaysDisable = False
        Me.rdo_2.AlwaysEnable = False
        Me.rdo_2.AutoSize = True
        Me.rdo_2.Location = New System.Drawing.Point(71, 17)
        Me.rdo_2.Name = "rdo_2"
        Me.rdo_2.Size = New System.Drawing.Size(51, 17)
        Me.rdo_2.TabIndex = 1
        Me.rdo_2.Text = "As Of"
        Me.rdo_2.Uncheckable = False
        Me.rdo_2.UseVisualStyleBackColor = True
        Me.rdo_2.Value = "2"
        '
        'rdo_1
        '
        Me.rdo_1.AlwaysDisable = False
        Me.rdo_1.AlwaysEnable = False
        Me.rdo_1.AutoSize = True
        Me.rdo_1.Location = New System.Drawing.Point(8, 17)
        Me.rdo_1.Name = "rdo_1"
        Me.rdo_1.Size = New System.Drawing.Size(57, 17)
        Me.rdo_1.TabIndex = 0
        Me.rdo_1.Text = "Range"
        Me.rdo_1.Uncheckable = False
        Me.rdo_1.UseVisualStyleBackColor = True
        Me.rdo_1.Value = "1"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(400, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(11, 60)
        Me.border1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(378, 2)
        Me.border1.TabIndex = 19
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(55, 75)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 226
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'withProject
        '
        Me.withProject.AutoSize = True
        Me.withProject.Location = New System.Drawing.Point(282, 40)
        Me.withProject.Name = "withProject"
        Me.withProject.Size = New System.Drawing.Size(84, 17)
        Me.withProject.TabIndex = 227
        Me.withProject.Text = "With Project"
        Me.withProject.UseVisualStyleBackColor = True
        '
        'allbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 250)
        Me.Controls.Add(Me.withProject)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_month)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.date_type)
        Me.Controls.Add(Me.originalCurrency)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "allbook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Book"
        CType(Me.txt_year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.date_type.ResumeLayout(False)
        Me.date_type.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents originalCurrency As System.Windows.Forms.CheckBox
    Friend WithEvents date_type As user_control.MyRadioGroup
    Friend WithEvents rdo_3 As user_control.MyRadioButton
    Friend WithEvents rdo_2 As user_control.MyRadioButton
    Friend WithEvents rdo_1 As user_control.MyRadioButton
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_month As System.Windows.Forms.ComboBox
    Friend WithEvents txt_year As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblLoad As Windows.Forms.Label
    Friend WithEvents withProject As Windows.Forms.CheckBox
End Class
