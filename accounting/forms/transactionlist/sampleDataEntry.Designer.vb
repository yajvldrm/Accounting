<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sampleDataEntry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ids = New System.Windows.Forms.TextBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_course = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ids)
        Me.Panel1.Controls.Add(Me.btn_Add)
        Me.Panel1.Controls.Add(Me.btn_Cancel)
        Me.Panel1.Controls.Add(Me.txt_year)
        Me.Panel1.Controls.Add(Me.txt_course)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 320)
        Me.Panel1.TabIndex = 0
        '
        'ids
        '
        Me.ids.Location = New System.Drawing.Point(98, 96)
        Me.ids.Name = "ids"
        Me.ids.Size = New System.Drawing.Size(45, 20)
        Me.ids.TabIndex = 15
        Me.ids.Tag = "ids"
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(151, 192)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(75, 23)
        Me.btn_Add.TabIndex = 13
        Me.btn_Add.Text = "OK"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(19, 192)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 12
        Me.btn_Cancel.Text = "CANCEL"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(61, 70)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(153, 20)
        Me.txt_year.TabIndex = 9
        Me.txt_year.Tag = "year"
        '
        'txt_course
        '
        Me.txt_course.Location = New System.Drawing.Point(61, 42)
        Me.txt_course.Name = "txt_course"
        Me.txt_course.Size = New System.Drawing.Size(153, 20)
        Me.txt_course.TabIndex = 10
        Me.txt_course.Tag = "course"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(62, 14)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(153, 20)
        Me.txt_name.TabIndex = 11
        Me.txt_name.Tag = "namess"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Course"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(26, 131)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(26, 157)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 17
        '
        'sampleDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "sampleDataEntry"
        Me.Text = "sampleDataEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btn_Add As Windows.Forms.Button
    Friend WithEvents btn_Cancel As Windows.Forms.Button
    Friend WithEvents txt_year As Windows.Forms.TextBox
    Friend WithEvents txt_course As Windows.Forms.TextBox
    Friend WithEvents txt_name As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents ids As Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
End Class
