<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_List
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBook = New user_control.textbox()
        Me.txtMonth = New user_control.textbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.NumericUpDown()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.DGList = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Textbox1 = New user_control.textbox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Transaction List"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBook
        '
        Me.txtBook._Text = ""
        Me.txtBook.AlwaysDisable = False
        Me.txtBook.AlwaysEnable = False
        Me.txtBook.BackColor = System.Drawing.Color.White
        Me.txtBook.BorderColor = System.Drawing.Color.DarkGray
        Me.txtBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBook.DataSource = ""
        Me.txtBook.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBook.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBook.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtBook.EnabledBackColor = System.Drawing.Color.White
        Me.txtBook.ispk = False
        Me.txtBook.Location = New System.Drawing.Point(418, 37)
        Me.txtBook.MultiLine = False
        Me.txtBook.Name = "txtBook"
        Me.txtBook.NoClear = False
        Me.txtBook.NumberFormat = "@"
        Me.txtBook.Required = False
        Me.txtBook.RowData = Nothing
        Me.txtBook.SelectionLength = 0
        Me.txtBook.SelectionStart = 0
        Me.txtBook.Size = New System.Drawing.Size(80, 20)
        Me.txtBook.TabIndex = 8
        Me.txtBook.TableData = Nothing
        Me.txtBook.TextSource = ""
        Me.txtBook.UseSystemPasswordChar = False
        Me.txtBook.Value = ""
        Me.txtBook.ValueSource = ""
        '
        'txtMonth
        '
        Me.txtMonth._Text = ""
        Me.txtMonth.AlwaysDisable = False
        Me.txtMonth.AlwaysEnable = False
        Me.txtMonth.BackColor = System.Drawing.Color.White
        Me.txtMonth.BorderColor = System.Drawing.Color.DarkGray
        Me.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonth.DataSource = ""
        Me.txtMonth.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMonth.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMonth.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtMonth.EnabledBackColor = System.Drawing.Color.White
        Me.txtMonth.ispk = False
        Me.txtMonth.Location = New System.Drawing.Point(544, 37)
        Me.txtMonth.MultiLine = False
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.NoClear = False
        Me.txtMonth.NumberFormat = "@"
        Me.txtMonth.Required = False
        Me.txtMonth.RowData = Nothing
        Me.txtMonth.SelectionLength = 0
        Me.txtMonth.SelectionStart = 0
        Me.txtMonth.Size = New System.Drawing.Size(90, 20)
        Me.txtMonth.TabIndex = 10
        Me.txtMonth.TableData = Nothing
        Me.txtMonth.TextSource = ""
        Me.txtMonth.UseSystemPasswordChar = False
        Me.txtMonth.Value = ""
        Me.txtMonth.ValueSource = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(640, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Year"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(673, 37)
        Me.txtYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(54, 20)
        Me.txtYear.TabIndex = 12
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtYear.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(733, 36)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(55, 23)
        Me.btnFilter.TabIndex = 13
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'DGList
        '
        Me.DGList.AllowUserToAddRows = False
        Me.DGList.AllowUserToDeleteRows = False
        Me.DGList.BackgroundColor = System.Drawing.Color.White
        Me.DGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.id})
        Me.DGList.Location = New System.Drawing.Point(15, 68)
        Me.DGList.MultiSelect = False
        Me.DGList.Name = "DGList"
        Me.DGList.RowHeadersVisible = False
        Me.DGList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGList.Size = New System.Drawing.Size(773, 280)
        Me.DGList.TabIndex = 14
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sel.Width = 32
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(713, 365)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 15
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        Me.btnView.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(403, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(322, 360)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(808, 28)
        Me.Myformheader1.TabIndex = 18
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(403, 360)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 19
        Me.btnHide.Text = "Cancel"
        Me.btnHide.UseVisualStyleBackColor = False
        Me.btnHide.Visible = False
        '
        'Textbox1
        '
        Me.Textbox1._Text = ""
        Me.Textbox1.AlwaysDisable = False
        Me.Textbox1.AlwaysEnable = False
        Me.Textbox1.BackColor = System.Drawing.Color.White
        Me.Textbox1.BorderColor = System.Drawing.Color.DarkGray
        Me.Textbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox1.DataSource = ""
        Me.Textbox1.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Textbox1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Textbox1.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.Textbox1.EnabledBackColor = System.Drawing.Color.White
        Me.Textbox1.ispk = False
        Me.Textbox1.Location = New System.Drawing.Point(257, 37)
        Me.Textbox1.MultiLine = False
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.NoClear = False
        Me.Textbox1.NumberFormat = "@"
        Me.Textbox1.Required = False
        Me.Textbox1.RowData = Nothing
        Me.Textbox1.SelectionLength = 0
        Me.Textbox1.SelectionStart = 0
        Me.Textbox1.Size = New System.Drawing.Size(120, 20)
        Me.Textbox1.TabIndex = 21
        Me.Textbox1.TableData = Nothing
        Me.Textbox1.TextSource = ""
        Me.Textbox1.UseSystemPasswordChar = False
        Me.Textbox1.Value = ""
        Me.Textbox1.ValueSource = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Search"
        '
        'Transaction_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.Textbox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.DGList)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBook)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaction_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction List"
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBook As user_control.textbox
    Friend WithEvents txtMonth As user_control.textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents DGList As System.Windows.Forms.DataGridView
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents Textbox1 As user_control.textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
