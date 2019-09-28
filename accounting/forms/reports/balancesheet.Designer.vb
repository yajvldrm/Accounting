<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class balancesheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(balancesheet))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_year_from = New System.Windows.Forms.NumericUpDown()
        Me.txt_year_to = New System.Windows.Forms.NumericUpDown()
        Me.includeZero = New System.Windows.Forms.CheckBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.byGroup = New System.Windows.Forms.CheckBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.txt_month_to = New user_control.monthselector()
        Me.txt_month_from = New user_control.monthselector()
        Me.dgBooks = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkAllBook = New System.Windows.Forms.CheckBox()
        Me.border1 = New accounting.borderedlabel()
        Me.groupByBook = New System.Windows.Forms.CheckBox()
        Me.lblLoad = New System.Windows.Forms.Label()
        CType(Me.txt_year_from, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_year_to, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Balance Sheet"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(303, 183)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(512, 183)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 22
        Me.btnPrint.Text = "Preview"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(105, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "AS OF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "COMPARATIVE MONTH"
        '
        'txt_year_from
        '
        Me.txt_year_from.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_year_from.Location = New System.Drawing.Point(252, 89)
        Me.txt_year_from.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year_from.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year_from.Name = "txt_year_from"
        Me.txt_year_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_year_from.TabIndex = 28
        Me.txt_year_from.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'txt_year_to
        '
        Me.txt_year_to.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_year_to.Location = New System.Drawing.Point(252, 115)
        Me.txt_year_to.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year_to.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year_to.Name = "txt_year_to"
        Me.txt_year_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_year_to.TabIndex = 29
        Me.txt_year_to.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'includeZero
        '
        Me.includeZero.AutoSize = True
        Me.includeZero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.includeZero.ForeColor = System.Drawing.Color.Red
        Me.includeZero.Location = New System.Drawing.Point(117, 141)
        Me.includeZero.Name = "includeZero"
        Me.includeZero.Size = New System.Drawing.Size(118, 20)
        Me.includeZero.TabIndex = 30
        Me.includeZero.Text = "INCLUDE ZEROES"
        Me.includeZero.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(431, 183)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 25)
        Me.btnExcel.TabIndex = 32
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
        Me.btnPrintOption.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(222, 183)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 1
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'byGroup
        '
        Me.byGroup.AutoSize = True
        Me.byGroup.Checked = True
        Me.byGroup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.byGroup.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byGroup.Location = New System.Drawing.Point(241, 141)
        Me.byGroup.Name = "byGroup"
        Me.byGroup.Size = New System.Drawing.Size(111, 20)
        Me.byGroup.TabIndex = 45
        Me.byGroup.Text = "Total Per Group"
        Me.byGroup.UseVisualStyleBackColor = True
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(600, 28)
        Me.Myformheader1.TabIndex = 31
        '
        'txt_month_to
        '
        Me.txt_month_to.DicItems = CType(resources.GetObject("txt_month_to.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.txt_month_to.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_month_to.Location = New System.Drawing.Point(146, 115)
        Me.txt_month_to.Maximum = 12
        Me.txt_month_to.Minimum = 1
        Me.txt_month_to.Name = "txt_month_to"
        Me.txt_month_to.Size = New System.Drawing.Size(100, 20)
        Me.txt_month_to.TabIndex = 27
        Me.txt_month_to.Value = "1"
        '
        'txt_month_from
        '
        Me.txt_month_from.DicItems = CType(resources.GetObject("txt_month_from.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.txt_month_from.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_month_from.Location = New System.Drawing.Point(146, 89)
        Me.txt_month_from.Maximum = 12
        Me.txt_month_from.Minimum = 1
        Me.txt_month_from.Name = "txt_month_from"
        Me.txt_month_from.Size = New System.Drawing.Size(100, 20)
        Me.txt_month_from.TabIndex = 26
        Me.txt_month_from.Value = "1"
        '
        'dgBooks
        '
        Me.dgBooks.AllowUserToAddRows = False
        Me.dgBooks.AllowUserToDeleteRows = False
        Me.dgBooks.AllowUserToResizeColumns = False
        Me.dgBooks.AllowUserToResizeRows = False
        Me.dgBooks.BackgroundColor = System.Drawing.Color.White
        Me.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.book_name, Me.book_id})
        Me.dgBooks.EnableHeadersVisualStyles = False
        Me.dgBooks.Location = New System.Drawing.Point(369, 66)
        Me.dgBooks.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgBooks.MultiSelect = False
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersVisible = False
        Me.dgBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBooks.Size = New System.Drawing.Size(218, 110)
        Me.dgBooks.TabIndex = 207
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.FalseValue = "False"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.TrueValue = "True"
        Me.sel.Width = 32
        '
        'book_name
        '
        Me.book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_name.DataPropertyName = "book_name"
        Me.book_name.HeaderText = "Book"
        Me.book_name.Name = "book_name"
        Me.book_name.ReadOnly = True
        Me.book_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.HeaderText = "ID"
        Me.book_id.Name = "book_id"
        Me.book_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.book_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.book_id.Visible = False
        '
        'checkAllBook
        '
        Me.checkAllBook.AutoSize = True
        Me.checkAllBook.Location = New System.Drawing.Point(380, 71)
        Me.checkAllBook.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllBook.Name = "checkAllBook"
        Me.checkAllBook.Size = New System.Drawing.Size(15, 14)
        Me.checkAllBook.TabIndex = 208
        Me.checkAllBook.UseVisualStyleBackColor = True
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.border1.Location = New System.Drawing.Point(15, 60)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(572, 2)
        Me.border1.TabIndex = 12
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupByBook
        '
        Me.groupByBook.AutoSize = True
        Me.groupByBook.Location = New System.Drawing.Point(369, 34)
        Me.groupByBook.Name = "groupByBook"
        Me.groupByBook.Size = New System.Drawing.Size(97, 17)
        Me.groupByBook.TabIndex = 209
        Me.groupByBook.Text = "Group by Book"
        Me.groupByBook.UseVisualStyleBackColor = True
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(155, 60)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 227
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'balancesheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 220)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.groupByBook)
        Me.Controls.Add(Me.checkAllBook)
        Me.Controls.Add(Me.byGroup)
        Me.Controls.Add(Me.dgBooks)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.includeZero)
        Me.Controls.Add(Me.txt_year_to)
        Me.Controls.Add(Me.txt_year_from)
        Me.Controls.Add(Me.txt_month_to)
        Me.Controls.Add(Me.txt_month_from)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "balancesheet"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Sheet"
        CType(Me.txt_year_from, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_year_to, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_month_from As user_control.monthselector
    Friend WithEvents txt_month_to As user_control.monthselector
    Friend WithEvents txt_year_from As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_year_to As System.Windows.Forms.NumericUpDown
    Friend WithEvents includeZero As System.Windows.Forms.CheckBox
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents byGroup As System.Windows.Forms.CheckBox
    Friend WithEvents dgBooks As System.Windows.Forms.DataGridView
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkAllBook As System.Windows.Forms.CheckBox
    Friend WithEvents groupByBook As System.Windows.Forms.CheckBox
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
