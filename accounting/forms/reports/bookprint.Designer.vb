<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookprint))
        Me.Myformheader1 = New user_control.myformheader()
        Me.dg_journal = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.dtjournal = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.dtbook = New System.Data.DataTable()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.dg_books = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_journal_all = New System.Windows.Forms.CheckBox()
        Me.chk_books_all = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.year_to = New System.Windows.Forms.NumericUpDown()
        Me.month_to = New user_control.monthselector()
        Me.year_from = New System.Windows.Forms.NumericUpDown()
        Me.month_from = New user_control.monthselector()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_currency = New System.Windows.Forms.GroupBox()
        Me.Rdo_button2 = New user_control.rdo_button()
        Me.Rdo_button1 = New user_control.rdo_button()
        Me.grp_order_by = New System.Windows.Forms.GroupBox()
        Me.Rdo_button3 = New user_control.rdo_button()
        Me.Rdo_button4 = New user_control.rdo_button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.dg_journal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtjournal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtbook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_books, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.year_to, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.year_from, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_currency.SuspendLayout()
        Me.grp_order_by.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(600, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'dg_journal
        '
        Me.dg_journal.AllowUserToAddRows = False
        Me.dg_journal.AllowUserToDeleteRows = False
        Me.dg_journal.AutoGenerateColumns = False
        Me.dg_journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_journal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dg_journal.DataSource = Me.ds
        Me.dg_journal.Location = New System.Drawing.Point(12, 34)
        Me.dg_journal.Name = "dg_journal"
        Me.dg_journal.RowHeadersVisible = False
        Me.dg_journal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_journal.Size = New System.Drawing.Size(280, 200)
        Me.dg_journal.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "sel"
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 32
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "journal_id"
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "journal_name"
        Me.Column3.HeaderText = "Journal"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.dtjournal, Me.dtbook})
        '
        'dtjournal
        '
        Me.dtjournal.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.dtjournal.TableName = "dtjournal"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "journal_id"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "journal_code"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "journal_name"
        '
        'dtbook
        '
        Me.dtbook.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.dtbook.TableName = "dtbook"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "book_id"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "book_code"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "book_name"
        '
        'dg_books
        '
        Me.dg_books.AllowUserToAddRows = False
        Me.dg_books.AllowUserToDeleteRows = False
        Me.dg_books.AutoGenerateColumns = False
        Me.dg_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_books.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3})
        Me.dg_books.DataSource = Me.ds
        Me.dg_books.Location = New System.Drawing.Point(308, 34)
        Me.dg_books.Name = "dg_books"
        Me.dg_books.RowHeadersVisible = False
        Me.dg_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_books.Size = New System.Drawing.Size(280, 200)
        Me.dg_books.TabIndex = 2
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "sel"
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 32
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "book_id"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "ID"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "book_name"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Book"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'chk_journal_all
        '
        Me.chk_journal_all.AutoSize = True
        Me.chk_journal_all.Location = New System.Drawing.Point(22, 38)
        Me.chk_journal_all.Name = "chk_journal_all"
        Me.chk_journal_all.Size = New System.Drawing.Size(15, 14)
        Me.chk_journal_all.TabIndex = 3
        Me.chk_journal_all.UseVisualStyleBackColor = True
        '
        'chk_books_all
        '
        Me.chk_books_all.AutoSize = True
        Me.chk_books_all.Location = New System.Drawing.Point(318, 38)
        Me.chk_books_all.Name = "chk_books_all"
        Me.chk_books_all.Size = New System.Drawing.Size(15, 14)
        Me.chk_books_all.TabIndex = 4
        Me.chk_books_all.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.year_to)
        Me.GroupBox1.Controls.Add(Me.month_to)
        Me.GroupBox1.Controls.Add(Me.year_from)
        Me.GroupBox1.Controls.Add(Me.month_from)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 96)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Range"
        '
        'year_to
        '
        Me.year_to.Location = New System.Drawing.Point(182, 50)
        Me.year_to.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.year_to.Minimum = New Decimal(New Integer() {1990, 0, 0, 0})
        Me.year_to.Name = "year_to"
        Me.year_to.Size = New System.Drawing.Size(60, 21)
        Me.year_to.TabIndex = 7
        Me.year_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.year_to.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'month_to
        '
        Me.month_to.DicItems = CType(resources.GetObject("month_to.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.month_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.month_to.Location = New System.Drawing.Point(76, 51)
        Me.month_to.Maximum = 12
        Me.month_to.Minimum = 1
        Me.month_to.Name = "month_to"
        Me.month_to.Size = New System.Drawing.Size(100, 18)
        Me.month_to.TabIndex = 9
        Me.month_to.Value = "1"
        '
        'year_from
        '
        Me.year_from.Location = New System.Drawing.Point(182, 26)
        Me.year_from.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.year_from.Minimum = New Decimal(New Integer() {1990, 0, 0, 0})
        Me.year_from.Name = "year_from"
        Me.year_from.Size = New System.Drawing.Size(60, 21)
        Me.year_from.TabIndex = 6
        Me.year_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.year_from.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'month_from
        '
        Me.month_from.DicItems = CType(resources.GetObject("month_from.DicItems"), System.Collections.Generic.Dictionary(Of Integer, String))
        Me.month_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.month_from.Location = New System.Drawing.Point(76, 27)
        Me.month_from.Maximum = 12
        Me.month_from.Minimum = 1
        Me.month_from.Name = "month_from"
        Me.month_from.Size = New System.Drawing.Size(100, 18)
        Me.month_from.TabIndex = 6
        Me.month_from.Value = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From"
        '
        'grp_currency
        '
        Me.grp_currency.Controls.Add(Me.Rdo_button2)
        Me.grp_currency.Controls.Add(Me.Rdo_button1)
        Me.grp_currency.Location = New System.Drawing.Point(308, 240)
        Me.grp_currency.Name = "grp_currency"
        Me.grp_currency.Size = New System.Drawing.Size(280, 45)
        Me.grp_currency.TabIndex = 6
        Me.grp_currency.TabStop = False
        Me.grp_currency.Text = "Currency"
        '
        'Rdo_button2
        '
        Me.Rdo_button2.AutoSize = True
        Me.Rdo_button2.DataSource = ""
        Me.Rdo_button2.Location = New System.Drawing.Point(147, 14)
        Me.Rdo_button2.Name = "Rdo_button2"
        Me.Rdo_button2.Size = New System.Drawing.Size(101, 17)
        Me.Rdo_button2.TabIndex = 8
        Me.Rdo_button2.Text = "Based Currency"
        Me.Rdo_button2.TextSource = ""
        Me.Rdo_button2.Uncheckable = False
        Me.Rdo_button2.UseVisualStyleBackColor = True
        Me.Rdo_button2.Value = "2"
        Me.Rdo_button2.ValueSource = ""
        '
        'Rdo_button1
        '
        Me.Rdo_button1.AutoSize = True
        Me.Rdo_button1.Checked = True
        Me.Rdo_button1.DataSource = ""
        Me.Rdo_button1.Location = New System.Drawing.Point(33, 14)
        Me.Rdo_button1.Name = "Rdo_button1"
        Me.Rdo_button1.Size = New System.Drawing.Size(108, 17)
        Me.Rdo_button1.TabIndex = 7
        Me.Rdo_button1.TabStop = True
        Me.Rdo_button1.Text = "Original Currency"
        Me.Rdo_button1.TextSource = ""
        Me.Rdo_button1.Uncheckable = False
        Me.Rdo_button1.UseVisualStyleBackColor = True
        Me.Rdo_button1.Value = "1"
        Me.Rdo_button1.ValueSource = ""
        '
        'grp_order_by
        '
        Me.grp_order_by.Controls.Add(Me.Rdo_button3)
        Me.grp_order_by.Controls.Add(Me.Rdo_button4)
        Me.grp_order_by.Location = New System.Drawing.Point(308, 291)
        Me.grp_order_by.Name = "grp_order_by"
        Me.grp_order_by.Size = New System.Drawing.Size(280, 45)
        Me.grp_order_by.TabIndex = 9
        Me.grp_order_by.TabStop = False
        Me.grp_order_by.Text = "Order By"
        '
        'Rdo_button3
        '
        Me.Rdo_button3.AutoSize = True
        Me.Rdo_button3.DataSource = ""
        Me.Rdo_button3.Location = New System.Drawing.Point(147, 14)
        Me.Rdo_button3.Name = "Rdo_button3"
        Me.Rdo_button3.Size = New System.Drawing.Size(48, 17)
        Me.Rdo_button3.TabIndex = 8
        Me.Rdo_button3.Text = "Date"
        Me.Rdo_button3.TextSource = ""
        Me.Rdo_button3.Uncheckable = False
        Me.Rdo_button3.UseVisualStyleBackColor = True
        Me.Rdo_button3.Value = "2"
        Me.Rdo_button3.ValueSource = ""
        '
        'Rdo_button4
        '
        Me.Rdo_button4.AutoSize = True
        Me.Rdo_button4.Checked = True
        Me.Rdo_button4.DataSource = ""
        Me.Rdo_button4.Location = New System.Drawing.Point(33, 14)
        Me.Rdo_button4.Name = "Rdo_button4"
        Me.Rdo_button4.Size = New System.Drawing.Size(97, 17)
        Me.Rdo_button4.TabIndex = 7
        Me.Rdo_button4.TabStop = True
        Me.Rdo_button4.Text = "Transaction No"
        Me.Rdo_button4.TextSource = ""
        Me.Rdo_button4.Uncheckable = False
        Me.Rdo_button4.UseVisualStyleBackColor = True
        Me.Rdo_button4.Value = "1"
        Me.Rdo_button4.ValueSource = ""
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(260, 342)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(179, 342)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnExcel.TabIndex = 11
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(341, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'bookprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 375)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grp_order_by)
        Me.Controls.Add(Me.grp_currency)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_books_all)
        Me.Controls.Add(Me.chk_journal_all)
        Me.Controls.Add(Me.dg_books)
        Me.Controls.Add(Me.dg_journal)
        Me.Controls.Add(Me.Myformheader1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bookprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing of Books"
        CType(Me.dg_journal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtjournal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtbook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_books, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.year_to, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.year_from, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_currency.ResumeLayout(False)
        Me.grp_currency.PerformLayout()
        Me.grp_order_by.ResumeLayout(False)
        Me.grp_order_by.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents dg_journal As System.Windows.Forms.DataGridView
    Friend WithEvents dg_books As System.Windows.Forms.DataGridView
    Friend WithEvents chk_journal_all As System.Windows.Forms.CheckBox
    Friend WithEvents chk_books_all As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents year_to As System.Windows.Forms.NumericUpDown
    Friend WithEvents month_to As user_control.monthselector
    Friend WithEvents year_from As System.Windows.Forms.NumericUpDown
    Friend WithEvents month_from As user_control.monthselector
    Friend WithEvents grp_currency As System.Windows.Forms.GroupBox
    Friend WithEvents Rdo_button2 As user_control.rdo_button
    Friend WithEvents Rdo_button1 As user_control.rdo_button
    Friend WithEvents grp_order_by As System.Windows.Forms.GroupBox
    Friend WithEvents Rdo_button3 As user_control.rdo_button
    Friend WithEvents Rdo_button4 As user_control.rdo_button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents dtjournal As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents dtbook As System.Data.DataTable
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
