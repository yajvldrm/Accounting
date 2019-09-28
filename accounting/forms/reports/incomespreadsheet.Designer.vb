<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incomespreadsheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(incomespreadsheet))
        Me.Myformheader1 = New user_control.myformheader()
        Me.includeZero = New System.Windows.Forms.CheckBox()
        Me.txt_year_to = New System.Windows.Forms.NumericUpDown()
        Me.txt_year_from = New System.Windows.Forms.NumericUpDown()
        Me.txt_month_to = New user_control.monthselector()
        Me.txt_month_from = New user_control.monthselector()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.byGroup = New System.Windows.Forms.CheckBox()
        Me.border1 = New accounting.borderedlabel()
        Me.lblLoad = New System.Windows.Forms.Label()
        CType(Me.txt_year_to, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_year_from, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'includeZero
        '
        Me.includeZero.AutoSize = True
        Me.includeZero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.includeZero.ForeColor = System.Drawing.Color.Red
        Me.includeZero.Location = New System.Drawing.Point(133, 122)
        Me.includeZero.Name = "includeZero"
        Me.includeZero.Size = New System.Drawing.Size(118, 20)
        Me.includeZero.TabIndex = 53
        Me.includeZero.Text = "INCLUDE ZEROES"
        Me.includeZero.UseVisualStyleBackColor = True
        '
        'txt_year_to
        '
        Me.txt_year_to.Enabled = False
        Me.txt_year_to.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_year_to.Location = New System.Drawing.Point(274, 96)
        Me.txt_year_to.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year_to.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year_to.Name = "txt_year_to"
        Me.txt_year_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_year_to.TabIndex = 52
        Me.txt_year_to.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'txt_year_from
        '
        Me.txt_year_from.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_year_from.Location = New System.Drawing.Point(274, 70)
        Me.txt_year_from.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year_from.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year_from.Name = "txt_year_from"
        Me.txt_year_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_year_from.TabIndex = 51
        Me.txt_year_from.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'txt_month_to
        '
        Me.txt_month_to.DicItems = CType(resources.GetObject("txt_month_to.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.txt_month_to.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_month_to.Location = New System.Drawing.Point(168, 96)
        Me.txt_month_to.Maximum = 12
        Me.txt_month_to.Minimum = 1
        Me.txt_month_to.Name = "txt_month_to"
        Me.txt_month_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_month_to.TabIndex = 50
        Me.txt_month_to.Value = "12"
        '
        'txt_month_from
        '
        Me.txt_month_from.DicItems = CType(resources.GetObject("txt_month_from.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.txt_month_from.Enabled = False
        Me.txt_month_from.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_month_from.Location = New System.Drawing.Point(168, 70)
        Me.txt_month_from.Maximum = 12
        Me.txt_month_from.Minimum = 1
        Me.txt_month_from.Name = "txt_month_from"
        Me.txt_month_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_month_from.TabIndex = 49
        Me.txt_month_from.Value = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(141, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "TO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(127, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "FROM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 24)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Comparative Annual Income Statement"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(253, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 56
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(172, 148)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 55
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'byGroup
        '
        Me.byGroup.AutoSize = True
        Me.byGroup.Checked = True
        Me.byGroup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.byGroup.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byGroup.Location = New System.Drawing.Point(257, 122)
        Me.byGroup.Name = "byGroup"
        Me.byGroup.Size = New System.Drawing.Size(111, 20)
        Me.byGroup.TabIndex = 57
        Me.byGroup.Text = "Total Per Group"
        Me.byGroup.UseVisualStyleBackColor = True
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.border1.Location = New System.Drawing.Point(15, 58)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(470, 2)
        Me.border1.TabIndex = 46
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(105, 50)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 227
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'incomespreadsheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 200)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.byGroup)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.includeZero)
        Me.Controls.Add(Me.txt_year_to)
        Me.Controls.Add(Me.txt_year_from)
        Me.Controls.Add(Me.txt_month_to)
        Me.Controls.Add(Me.txt_month_from)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "incomespreadsheet"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparative Annual Income Statement Spreadsheet"
        CType(Me.txt_year_to, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_year_from, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents includeZero As System.Windows.Forms.CheckBox
    Friend WithEvents txt_year_to As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_year_from As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_month_to As user_control.monthselector
    Friend WithEvents txt_month_from As user_control.monthselector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents byGroup As System.Windows.Forms.CheckBox
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
