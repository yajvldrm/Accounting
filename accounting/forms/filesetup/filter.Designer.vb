<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filter
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
        Me.border1 = New accounting.borderedlabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_book = New user_control.textbox()
        Me.txt_currency = New user_control.textbox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txt_sys_beg = New System.Windows.Forms.DateTimePicker()
        Me.Myformheader1 = New user_control.myformheader()
        Me.SuspendLayout()
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(275, 2)
        Me.border1.TabIndex = 10
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "GL Beginning Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Beginning Balance Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Book"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Currency"
        '
        'txt_book
        '
        Me.txt_book._Text = ""
        Me.txt_book.AlwaysDisable = False
        Me.txt_book.AlwaysEnable = False
        Me.txt_book.BackColor = System.Drawing.Color.White
        Me.txt_book.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_book.DataSource = ""
        Me.txt_book.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_book.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_book.EnabledBackColor = System.Drawing.Color.White
        Me.txt_book.ispk = False
        Me.txt_book.Location = New System.Drawing.Point(137, 96)
        Me.txt_book.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_book.MultiLine = False
        Me.txt_book.Name = "txt_book"
        Me.txt_book.NoClear = False
        Me.txt_book.NumberFormat = "@"
        Me.txt_book.Required = False
        Me.txt_book.RowData = Nothing
        Me.txt_book.SelectionLength = 0
        Me.txt_book.SelectionStart = 0
        Me.txt_book.Size = New System.Drawing.Size(150, 20)
        Me.txt_book.TabIndex = 15
        Me.txt_book.TableData = Nothing
        Me.txt_book.TextSource = "book_name"
        Me.txt_book.UseSystemPasswordChar = False
        Me.txt_book.Value = ""
        Me.txt_book.ValueSource = "book_id"
        '
        'txt_currency
        '
        Me.txt_currency._Text = ""
        Me.txt_currency.AlwaysDisable = False
        Me.txt_currency.AlwaysEnable = False
        Me.txt_currency.BackColor = System.Drawing.Color.White
        Me.txt_currency.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_currency.DataSource = ""
        Me.txt_currency.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_currency.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currency.EnabledBackColor = System.Drawing.Color.White
        Me.txt_currency.ispk = False
        Me.txt_currency.Location = New System.Drawing.Point(137, 122)
        Me.txt_currency.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_currency.MultiLine = False
        Me.txt_currency.Name = "txt_currency"
        Me.txt_currency.NoClear = False
        Me.txt_currency.NumberFormat = "@"
        Me.txt_currency.Required = False
        Me.txt_currency.RowData = Nothing
        Me.txt_currency.SelectionLength = 0
        Me.txt_currency.SelectionStart = 0
        Me.txt_currency.Size = New System.Drawing.Size(150, 20)
        Me.txt_currency.TabIndex = 16
        Me.txt_currency.TableData = Nothing
        Me.txt_currency.TextSource = "currency_name"
        Me.txt_currency.UseSystemPasswordChar = False
        Me.txt_currency.Value = ""
        Me.txt_currency.ValueSource = "currency_id"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(153, 148)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 104
        Me.btnExit.Tag = "btnExit"
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(47, 148)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(100, 23)
        Me.btnLoad.TabIndex = 103
        Me.btnLoad.Tag = "btnLoad"
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'txt_sys_beg
        '
        Me.txt_sys_beg.Enabled = False
        Me.txt_sys_beg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_sys_beg.Location = New System.Drawing.Point(137, 70)
        Me.txt_sys_beg.Name = "txt_sys_beg"
        Me.txt_sys_beg.Size = New System.Drawing.Size(150, 20)
        Me.txt_sys_beg.TabIndex = 105
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(300, 29)
        Me.Myformheader1.TabIndex = 106
        '
        'filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.txt_sys_beg)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txt_currency)
        Me.Controls.Add(Me.txt_book)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "filter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Beginning Balance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_book As user_control.textbox
    Friend WithEvents txt_currency As user_control.textbox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents txt_sys_beg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Myformheader1 As user_control.myformheader
End Class
