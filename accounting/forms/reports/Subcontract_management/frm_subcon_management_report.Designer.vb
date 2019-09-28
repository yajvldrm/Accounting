<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_subcon_management_report
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateasOf = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.btn_Preview = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_subcon_management_subsidiary = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_subcon_management_analysis = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_project_code = New user_control.textbox()
        Me.txt_per_subcon = New user_control.textbox()
        Me.txt_per_subcon_name = New System.Windows.Forms.TextBox()
        Me.txt_project_name = New System.Windows.Forms.TextBox()
        Me.txt_year_ref = New System.Windows.Forms.NumericUpDown()
        Me.chk_per_subcon = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_per_project = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_per_year = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dateasOf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chk_subcon_management_subsidiary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_subcon_management_analysis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_year_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_per_subcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_per_project.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_per_year.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtp_to)
        Me.GroupBox3.Controls.Add(Me.dtp_from)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dateasOf)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 84)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'dtp_to
        '
        Me.dtp_to.Location = New System.Drawing.Point(81, 59)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(181, 20)
        Me.dtp_to.TabIndex = 16
        '
        'dtp_from
        '
        Me.dtp_from.Location = New System.Drawing.Point(81, 35)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(181, 20)
        Me.dtp_from.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Date to"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date From "
        '
        'dateasOf
        '
        Me.dateasOf.Location = New System.Drawing.Point(5, 11)
        Me.dateasOf.Name = "dateasOf"
        Me.dateasOf.Properties.Caption = "Date as Of"
        Me.dateasOf.Size = New System.Drawing.Size(84, 19)
        Me.dateasOf.TabIndex = 12
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(188, 256)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 18
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_excel
        '
        Me.btn_excel.Location = New System.Drawing.Point(107, 256)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(75, 23)
        Me.btn_excel.TabIndex = 19
        Me.btn_excel.Text = "Excel"
        Me.btn_excel.UseVisualStyleBackColor = True
        '
        'btn_Preview
        '
        Me.btn_Preview.Location = New System.Drawing.Point(26, 256)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.Size = New System.Drawing.Size(75, 23)
        Me.btn_Preview.TabIndex = 20
        Me.btn_Preview.Text = "Preview"
        Me.btn_Preview.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 33)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "SubCon Management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_subcon_management_subsidiary)
        Me.GroupBox1.Controls.Add(Me.chk_subcon_management_analysis)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 39)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'chk_subcon_management_subsidiary
        '
        Me.chk_subcon_management_subsidiary.Location = New System.Drawing.Point(145, 11)
        Me.chk_subcon_management_subsidiary.Name = "chk_subcon_management_subsidiary"
        Me.chk_subcon_management_subsidiary.Properties.Caption = "Subsidiary"
        Me.chk_subcon_management_subsidiary.Size = New System.Drawing.Size(117, 19)
        Me.chk_subcon_management_subsidiary.TabIndex = 13
        '
        'chk_subcon_management_analysis
        '
        Me.chk_subcon_management_analysis.EditValue = True
        Me.chk_subcon_management_analysis.Location = New System.Drawing.Point(12, 11)
        Me.chk_subcon_management_analysis.Name = "chk_subcon_management_analysis"
        Me.chk_subcon_management_analysis.Properties.Caption = "SubCon Analysis"
        Me.chk_subcon_management_analysis.Size = New System.Drawing.Size(127, 19)
        Me.chk_subcon_management_analysis.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_project_code)
        Me.GroupBox2.Controls.Add(Me.txt_per_subcon)
        Me.GroupBox2.Controls.Add(Me.txt_per_subcon_name)
        Me.GroupBox2.Controls.Add(Me.txt_project_name)
        Me.GroupBox2.Controls.Add(Me.txt_year_ref)
        Me.GroupBox2.Controls.Add(Me.chk_per_subcon)
        Me.GroupBox2.Controls.Add(Me.chk_per_project)
        Me.GroupBox2.Controls.Add(Me.chk_per_year)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 90)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'txt_project_code
        '
        Me.txt_project_code._Text = ""
        Me.txt_project_code.AllowNegative = False
        Me.txt_project_code.AlwaysDisable = False
        Me.txt_project_code.AlwaysEnable = False
        Me.txt_project_code.BackColor = System.Drawing.Color.White
        Me.txt_project_code.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_project_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_project_code.DataSource = ""
        Me.txt_project_code.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_code.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_project_code.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_project_code.EnabledBackColor = System.Drawing.Color.White
        Me.txt_project_code.ispk = False
        Me.txt_project_code.Location = New System.Drawing.Point(103, 40)
        Me.txt_project_code.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_project_code.MultiLine = False
        Me.txt_project_code.Name = "txt_project_code"
        Me.txt_project_code.NoClear = False
        Me.txt_project_code.NumberFormat = "@"
        Me.txt_project_code.Required = False
        Me.txt_project_code.RowData = Nothing
        Me.txt_project_code.SelectionLength = 0
        Me.txt_project_code.SelectionStart = 0
        Me.txt_project_code.Size = New System.Drawing.Size(49, 20)
        Me.txt_project_code.TabIndex = 31
        Me.txt_project_code.TableData = Nothing
        Me.txt_project_code.TextSource = ""
        Me.txt_project_code.UseSystemPasswordChar = False
        Me.txt_project_code.Value = ""
        Me.txt_project_code.ValueSource = ""
        Me.txt_project_code.Visible = False
        '
        'txt_per_subcon
        '
        Me.txt_per_subcon._Text = ""
        Me.txt_per_subcon.AllowNegative = False
        Me.txt_per_subcon.AlwaysDisable = False
        Me.txt_per_subcon.AlwaysEnable = False
        Me.txt_per_subcon.BackColor = System.Drawing.Color.White
        Me.txt_per_subcon.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_per_subcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_per_subcon.DataSource = ""
        Me.txt_per_subcon.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_per_subcon.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_per_subcon.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_per_subcon.EnabledBackColor = System.Drawing.Color.White
        Me.txt_per_subcon.ispk = False
        Me.txt_per_subcon.Location = New System.Drawing.Point(103, 66)
        Me.txt_per_subcon.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_per_subcon.MultiLine = False
        Me.txt_per_subcon.Name = "txt_per_subcon"
        Me.txt_per_subcon.NoClear = False
        Me.txt_per_subcon.NumberFormat = "@"
        Me.txt_per_subcon.Required = False
        Me.txt_per_subcon.RowData = Nothing
        Me.txt_per_subcon.SelectionLength = 0
        Me.txt_per_subcon.SelectionStart = 0
        Me.txt_per_subcon.Size = New System.Drawing.Size(49, 20)
        Me.txt_per_subcon.TabIndex = 30
        Me.txt_per_subcon.TableData = Nothing
        Me.txt_per_subcon.TextSource = ""
        Me.txt_per_subcon.UseSystemPasswordChar = False
        Me.txt_per_subcon.Value = ""
        Me.txt_per_subcon.ValueSource = ""
        Me.txt_per_subcon.Visible = False
        '
        'txt_per_subcon_name
        '
        Me.txt_per_subcon_name.Location = New System.Drawing.Point(156, 65)
        Me.txt_per_subcon_name.Name = "txt_per_subcon_name"
        Me.txt_per_subcon_name.ReadOnly = True
        Me.txt_per_subcon_name.Size = New System.Drawing.Size(79, 20)
        Me.txt_per_subcon_name.TabIndex = 29
        Me.txt_per_subcon_name.Visible = False
        '
        'txt_project_name
        '
        Me.txt_project_name.Location = New System.Drawing.Point(156, 40)
        Me.txt_project_name.Name = "txt_project_name"
        Me.txt_project_name.ReadOnly = True
        Me.txt_project_name.Size = New System.Drawing.Size(79, 20)
        Me.txt_project_name.TabIndex = 28
        Me.txt_project_name.Visible = False
        '
        'txt_year_ref
        '
        Me.txt_year_ref.Location = New System.Drawing.Point(103, 14)
        Me.txt_year_ref.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year_ref.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year_ref.Name = "txt_year_ref"
        Me.txt_year_ref.Size = New System.Drawing.Size(132, 20)
        Me.txt_year_ref.TabIndex = 21
        Me.txt_year_ref.Tag = "pm_year"
        Me.txt_year_ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_year_ref.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.txt_year_ref.Visible = False
        '
        'chk_per_subcon
        '
        Me.chk_per_subcon.Location = New System.Drawing.Point(7, 67)
        Me.chk_per_subcon.Name = "chk_per_subcon"
        Me.chk_per_subcon.Properties.Caption = "Per Subcon"
        Me.chk_per_subcon.Size = New System.Drawing.Size(84, 19)
        Me.chk_per_subcon.TabIndex = 12
        '
        'chk_per_project
        '
        Me.chk_per_project.Location = New System.Drawing.Point(7, 42)
        Me.chk_per_project.Name = "chk_per_project"
        Me.chk_per_project.Properties.Caption = "Per Project"
        Me.chk_per_project.Size = New System.Drawing.Size(84, 19)
        Me.chk_per_project.TabIndex = 12
        '
        'chk_per_year
        '
        Me.chk_per_year.Location = New System.Drawing.Point(5, 15)
        Me.chk_per_year.Name = "chk_per_year"
        Me.chk_per_year.Properties.Caption = "Per Year"
        Me.chk_per_year.Size = New System.Drawing.Size(84, 19)
        Me.chk_per_year.TabIndex = 12
        '
        'frm_subcon_management_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 284)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.btn_Preview)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_subcon_management_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dateasOf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.chk_subcon_management_subsidiary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_subcon_management_analysis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_year_ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_per_subcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_per_project.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_per_year.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents dtp_to As Windows.Forms.DateTimePicker
    Friend WithEvents dtp_from As Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents dateasOf As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_cancel As Windows.Forms.Button
    Friend WithEvents btn_excel As Windows.Forms.Button
    Friend WithEvents btn_Preview As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents chk_subcon_management_subsidiary As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_subcon_management_analysis As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents chk_per_subcon As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_per_project As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_per_year As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_year_ref As Windows.Forms.NumericUpDown
    Friend WithEvents txt_project_code As user_control.textbox
    Friend WithEvents txt_per_subcon As user_control.textbox
    Friend WithEvents txt_per_subcon_name As Windows.Forms.TextBox
    Friend WithEvents txt_project_name As Windows.Forms.TextBox
End Class
