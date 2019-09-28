<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportoption
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Myformheader1 = New user_control.myformheader()
        Me.report_option = New System.Windows.Forms.GroupBox()
        Me.TabSep = New user_control.rdo_button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_sort = New System.Windows.Forms.ComboBox()
        Me.Rdo_button2 = New user_control.rdo_button()
        Me.Rdo_button1 = New user_control.rdo_button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.report_option.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(258, 28)
        Me.Myformheader1.TabIndex = 5
        '
        'report_option
        '
        Me.report_option.Controls.Add(Me.TabSep)
        Me.report_option.Controls.Add(Me.Label1)
        Me.report_option.Controls.Add(Me.cbo_sort)
        Me.report_option.Controls.Add(Me.Rdo_button2)
        Me.report_option.Controls.Add(Me.Rdo_button1)
        Me.report_option.Location = New System.Drawing.Point(12, 34)
        Me.report_option.Name = "report_option"
        Me.report_option.Size = New System.Drawing.Size(234, 75)
        Me.report_option.TabIndex = 1
        Me.report_option.TabStop = False
        Me.report_option.Text = "Show Report In"
        '
        'TabSep
        '
        Me.TabSep.AutoSize = True
        Me.TabSep.DataSource = ""
        Me.TabSep.Location = New System.Drawing.Point(131, 20)
        Me.TabSep.Name = "TabSep"
        Me.TabSep.Size = New System.Drawing.Size(96, 17)
        Me.TabSep.TabIndex = 5
        Me.TabSep.Text = "Tab Separated"
        Me.TabSep.TextSource = ""
        Me.TabSep.Uncheckable = False
        Me.TabSep.UseVisualStyleBackColor = True
        Me.TabSep.Value = "3"
        Me.TabSep.ValueSource = ""
        Me.TabSep.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sort By"
        '
        'cbo_sort
        '
        Me.cbo_sort.FormattingEnabled = True
        Me.cbo_sort.Location = New System.Drawing.Point(71, 43)
        Me.cbo_sort.Name = "cbo_sort"
        Me.cbo_sort.Size = New System.Drawing.Size(121, 21)
        Me.cbo_sort.TabIndex = 4
        '
        'Rdo_button2
        '
        Me.Rdo_button2.AutoSize = True
        Me.Rdo_button2.Checked = True
        Me.Rdo_button2.DataSource = ""
        Me.Rdo_button2.Location = New System.Drawing.Point(69, 20)
        Me.Rdo_button2.Name = "Rdo_button2"
        Me.Rdo_button2.Size = New System.Drawing.Size(63, 17)
        Me.Rdo_button2.TabIndex = 3
        Me.Rdo_button2.TabStop = True
        Me.Rdo_button2.Text = "Preview"
        Me.Rdo_button2.TextSource = ""
        Me.Rdo_button2.Uncheckable = False
        Me.Rdo_button2.UseVisualStyleBackColor = True
        Me.Rdo_button2.Value = "2"
        Me.Rdo_button2.ValueSource = ""
        '
        'Rdo_button1
        '
        Me.Rdo_button1.AutoSize = True
        Me.Rdo_button1.DataSource = ""
        Me.Rdo_button1.Location = New System.Drawing.Point(13, 20)
        Me.Rdo_button1.Name = "Rdo_button1"
        Me.Rdo_button1.Size = New System.Drawing.Size(50, 17)
        Me.Rdo_button1.TabIndex = 2
        Me.Rdo_button1.Text = "Excel"
        Me.Rdo_button1.TextSource = ""
        Me.Rdo_button1.Uncheckable = False
        Me.Rdo_button1.UseVisualStyleBackColor = True
        Me.Rdo_button1.Value = "1"
        Me.Rdo_button1.ValueSource = ""
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Green
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(82, 115)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 25)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'reportoption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 150)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.report_option)
        Me.Controls.Add(Me.Myformheader1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reportoption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Option"
        Me.report_option.ResumeLayout(False)
        Me.report_option.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents report_option As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cbo_sort As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TabSep As user_control.rdo_button
    Public WithEvents Rdo_button2 As user_control.rdo_button
    Public WithEvents Rdo_button1 As user_control.rdo_button
End Class
