<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class general_library_report_filter
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_filtered_id = New user_control.textbox()
        Me.txt_sort_by = New user_control.textbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFiltered = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(153, 121)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(72, 121)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Sort By"
        '
        'txt_filtered_id
        '
        Me.txt_filtered_id._Text = ""
        Me.txt_filtered_id.AlwaysDisable = False
        Me.txt_filtered_id.AlwaysEnable = False
        Me.txt_filtered_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filtered_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_filtered_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtered_id.DataSource = ""
        Me.txt_filtered_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filtered_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_filtered_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_filtered_id.Enabled = False
        Me.txt_filtered_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_filtered_id.ispk = False
        Me.txt_filtered_id.Location = New System.Drawing.Point(83, 95)
        Me.txt_filtered_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_filtered_id.MultiLine = False
        Me.txt_filtered_id.Name = "txt_filtered_id"
        Me.txt_filtered_id.NoClear = False
        Me.txt_filtered_id.NumberFormat = "@"
        Me.txt_filtered_id.Required = False
        Me.txt_filtered_id.RowData = Nothing
        Me.txt_filtered_id.SelectionLength = 0
        Me.txt_filtered_id.SelectionStart = 0
        Me.txt_filtered_id.Size = New System.Drawing.Size(180, 20)
        Me.txt_filtered_id.TabIndex = 24
        Me.txt_filtered_id.TableData = Nothing
        Me.txt_filtered_id.TextSource = "filtered_name"
        Me.txt_filtered_id.UseSystemPasswordChar = False
        Me.txt_filtered_id.Value = ""
        Me.txt_filtered_id.ValueSource = "filtered_id"
        '
        'txt_sort_by
        '
        Me.txt_sort_by._Text = ""
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
        Me.txt_sort_by.Location = New System.Drawing.Point(83, 69)
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
        Me.txt_sort_by.TabIndex = 22
        Me.txt_sort_by.TableData = Nothing
        Me.txt_sort_by.TextSource = ""
        Me.txt_sort_by.UseSystemPasswordChar = False
        Me.txt_sort_by.Value = ""
        Me.txt_sort_by.ValueSource = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Print General Library"
        '
        'lblFiltered
        '
        Me.lblFiltered.AutoSize = True
        Me.lblFiltered.Location = New System.Drawing.Point(28, 99)
        Me.lblFiltered.Name = "lblFiltered"
        Me.lblFiltered.Size = New System.Drawing.Size(0, 13)
        Me.lblFiltered.TabIndex = 29
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(300, 28)
        Me.Myformheader1.TabIndex = 30
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(10, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(280, 2)
        Me.border1.TabIndex = 19
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(12, 121)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnExcel.TabIndex = 40
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
        Me.btnPrintOption.Location = New System.Drawing.Point(72, 121)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintOption.TabIndex = 1
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'general_library_report_filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.lblFiltered)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_filtered_id)
        Me.Controls.Add(Me.txt_sort_by)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExcel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "general_library_report_filter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print General Library"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filtered_id As user_control.textbox
    Friend WithEvents txt_sort_by As user_control.textbox
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFiltered As System.Windows.Forms.Label
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
End Class
