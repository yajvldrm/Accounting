<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class printingbooks
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
        Me.dgJournal = New System.Windows.Forms.DataGridView()
        Me.sel1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.journal_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgBooks = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.range_filter = New System.Windows.Forms.Panel()
        Me.rdo2 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_sort = New System.Windows.Forms.ComboBox()
        Me.checkAllJournal = New System.Windows.Forms.CheckBox()
        Me.checkAllBook = New System.Windows.Forms.CheckBox()
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.btnTabSeparated = New System.Windows.Forms.Button()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.parent_grid = New System.Windows.Forms.DataGridView()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.account = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsBooks = New System.Data.DataSet()
        Me.trans_header = New System.Data.DataTable()
        Me.trans_no = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.groupByBook = New System.Windows.Forms.CheckBox()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_general_id = New user_control.textbox()
        CType(Me.dgJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.range_filter.SuspendLayout()
        CType(Me.parent_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trans_header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgJournal
        '
        Me.dgJournal.AllowUserToAddRows = False
        Me.dgJournal.AllowUserToDeleteRows = False
        Me.dgJournal.AllowUserToResizeColumns = False
        Me.dgJournal.AllowUserToResizeRows = False
        Me.dgJournal.BackgroundColor = System.Drawing.Color.White
        Me.dgJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgJournal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel1, Me.journal_name, Me.journal_id})
        Me.dgJournal.EnableHeadersVisualStyles = False
        Me.dgJournal.Location = New System.Drawing.Point(13, 35)
        Me.dgJournal.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgJournal.MultiSelect = False
        Me.dgJournal.Name = "dgJournal"
        Me.dgJournal.RowHeadersVisible = False
        Me.dgJournal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgJournal.Size = New System.Drawing.Size(220, 220)
        Me.dgJournal.TabIndex = 208
        '
        'sel1
        '
        Me.sel1.DataPropertyName = "sel"
        Me.sel1.FalseValue = "False"
        Me.sel1.HeaderText = ""
        Me.sel1.Name = "sel1"
        Me.sel1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel1.TrueValue = "True"
        Me.sel1.Width = 32
        '
        'journal_name
        '
        Me.journal_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.journal_name.DataPropertyName = "journal_name"
        Me.journal_name.HeaderText = "Journal"
        Me.journal_name.Name = "journal_name"
        Me.journal_name.ReadOnly = True
        Me.journal_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'journal_id
        '
        Me.journal_id.DataPropertyName = "journal_id"
        Me.journal_id.HeaderText = "ID"
        Me.journal_id.Name = "journal_id"
        Me.journal_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.journal_id.Visible = False
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
        Me.dgBooks.Location = New System.Drawing.Point(237, 35)
        Me.dgBooks.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.dgBooks.MultiSelect = False
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersVisible = False
        Me.dgBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBooks.Size = New System.Drawing.Size(220, 220)
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
        'txt_date_to
        '
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(89, 324)
        Me.txt_date_to.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(120, 20)
        Me.txt_date_to.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 327)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 213
        Me.Label3.Text = "Date To"
        '
        'txt_date_from
        '
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(89, 296)
        Me.txt_date_from.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(120, 20)
        Me.txt_date_from.TabIndex = 209
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 299)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 212
        Me.Label2.Text = "Date From"
        '
        'range_filter
        '
        Me.range_filter.Controls.Add(Me.rdo2)
        Me.range_filter.Controls.Add(Me.rdo1)
        Me.range_filter.Location = New System.Drawing.Point(13, 263)
        Me.range_filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.range_filter.Name = "range_filter"
        Me.range_filter.Size = New System.Drawing.Size(220, 25)
        Me.range_filter.TabIndex = 211
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.DataSource = ""
        Me.rdo2.Location = New System.Drawing.Point(102, 4)
        Me.rdo2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(101, 17)
        Me.rdo2.TabIndex = 2
        Me.rdo2.Text = "To Date / As Of"
        Me.rdo2.TextSource = ""
        Me.rdo2.Uncheckable = False
        Me.rdo2.UseVisualStyleBackColor = True
        Me.rdo2.Value = "2"
        Me.rdo2.ValueSource = ""
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Checked = True
        Me.rdo1.DataSource = ""
        Me.rdo1.Location = New System.Drawing.Point(17, 4)
        Me.rdo1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(81, 17)
        Me.rdo1.TabIndex = 1
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "Range Only"
        Me.rdo1.TextSource = ""
        Me.rdo1.Uncheckable = False
        Me.rdo1.UseVisualStyleBackColor = True
        Me.rdo1.Value = "1"
        Me.rdo1.ValueSource = ""
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(330, 361)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(50, 16)
        Me.btnPrint.TabIndex = 218
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(355, 321)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 217
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Sort By"
        '
        'cbo_sort
        '
        Me.cbo_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sort.FormattingEnabled = True
        Me.cbo_sort.Location = New System.Drawing.Point(294, 292)
        Me.cbo_sort.Name = "cbo_sort"
        Me.cbo_sort.Size = New System.Drawing.Size(150, 21)
        Me.cbo_sort.TabIndex = 220
        '
        'checkAllJournal
        '
        Me.checkAllJournal.AutoSize = True
        Me.checkAllJournal.Location = New System.Drawing.Point(23, 41)
        Me.checkAllJournal.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllJournal.Name = "checkAllJournal"
        Me.checkAllJournal.Size = New System.Drawing.Size(15, 14)
        Me.checkAllJournal.TabIndex = 221
        Me.checkAllJournal.UseVisualStyleBackColor = True
        '
        'checkAllBook
        '
        Me.checkAllBook.AutoSize = True
        Me.checkAllBook.Location = New System.Drawing.Point(247, 41)
        Me.checkAllBook.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.checkAllBook.Name = "checkAllBook"
        Me.checkAllBook.Size = New System.Drawing.Size(15, 14)
        Me.checkAllBook.TabIndex = 222
        Me.checkAllBook.UseVisualStyleBackColor = True
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(470, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(330, 361)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(50, 16)
        Me.btnExcel.TabIndex = 275
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
        Me.btnPrintOption.Location = New System.Drawing.Point(274, 321)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 274
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'btnTabSeparated
        '
        Me.btnTabSeparated.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnTabSeparated.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnTabSeparated.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTabSeparated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTabSeparated.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnTabSeparated.ForeColor = System.Drawing.Color.White
        Me.btnTabSeparated.Location = New System.Drawing.Point(330, 362)
        Me.btnTabSeparated.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnTabSeparated.Name = "btnTabSeparated"
        Me.btnTabSeparated.Size = New System.Drawing.Size(19, 17)
        Me.btnTabSeparated.TabIndex = 276
        Me.btnTabSeparated.Text = "TabSeparated"
        Me.btnTabSeparated.UseVisualStyleBackColor = False
        Me.btnTabSeparated.Visible = False
        '
        'parent_grid
        '
        Me.parent_grid.AutoGenerateColumns = False
        Me.parent_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.parent_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransnoDataGridViewTextBoxColumn, Me.trans_id, Me.trans_date, Me.ref_trans_no, Me.general_name, Me.description, Me.account, Me.debit, Me.credit})
        Me.parent_grid.DataMember = "trans_header"
        Me.parent_grid.DataSource = Me.dsBooks
        Me.parent_grid.Location = New System.Drawing.Point(3, 368)
        Me.parent_grid.Name = "parent_grid"
        Me.parent_grid.Size = New System.Drawing.Size(462, 10)
        Me.parent_grid.TabIndex = 277
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "Trans #"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        '
        'trans_id
        '
        Me.trans_id.DataPropertyName = "journal_name"
        Me.trans_id.HeaderText = "Type"
        Me.trans_id.Name = "trans_id"
        '
        'trans_date
        '
        Me.trans_date.DataPropertyName = "trans_date"
        Me.trans_date.HeaderText = "Date"
        Me.trans_date.Name = "trans_date"
        '
        'ref_trans_no
        '
        Me.ref_trans_no.DataPropertyName = "ref_trans_no"
        Me.ref_trans_no.HeaderText = "Num"
        Me.ref_trans_no.Name = "ref_trans_no"
        '
        'general_name
        '
        Me.general_name.DataPropertyName = "general_name"
        Me.general_name.HeaderText = "Name"
        Me.general_name.Name = "general_name"
        '
        'description
        '
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "Memo"
        Me.description.Name = "description"
        '
        'account
        '
        Me.account.DataPropertyName = "account_code"
        Me.account.HeaderText = "Account"
        Me.account.Name = "account"
        '
        'debit
        '
        Me.debit.DataPropertyName = "debit"
        Me.debit.HeaderText = "Debit"
        Me.debit.Name = "debit"
        '
        'credit
        '
        Me.credit.DataPropertyName = "credit"
        Me.credit.HeaderText = "Credit"
        Me.credit.Name = "credit"
        '
        'dsBooks
        '
        Me.dsBooks.DataSetName = "dsBooks"
        Me.dsBooks.Tables.AddRange(New System.Data.DataTable() {Me.trans_header})
        '
        'trans_header
        '
        Me.trans_header.Columns.AddRange(New System.Data.DataColumn() {Me.trans_no, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn1})
        Me.trans_header.TableName = "trans_header"
        '
        'trans_no
        '
        Me.trans_no.ColumnName = "trans_no"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "journal_name"
        Me.DataColumn2.ColumnName = "journal_name"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "trans_date"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "general_name"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "description"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "account_code"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "debit"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "credit"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "ref_trans_no"
        '
        'groupByBook
        '
        Me.groupByBook.AutoSize = True
        Me.groupByBook.Location = New System.Drawing.Point(355, 40)
        Me.groupByBook.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.groupByBook.Name = "groupByBook"
        Me.groupByBook.Size = New System.Drawing.Size(98, 17)
        Me.groupByBook.TabIndex = 278
        Me.groupByBook.Text = "Group By Book"
        Me.groupByBook.UseVisualStyleBackColor = True
        Me.groupByBook.Visible = False
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(90, 135)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(291, 100)
        Me.lblLoad.TabIndex = 279
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 280
        Me.Label4.Text = "General"
        '
        'txt_general_id
        '
        Me.txt_general_id._Text = ""
        Me.txt_general_id.AllowNegative = False
        Me.txt_general_id.AlwaysDisable = False
        Me.txt_general_id.AlwaysEnable = True
        Me.txt_general_id.BackColor = System.Drawing.Color.White
        Me.txt_general_id.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_general_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_general_id.DataSource = ""
        Me.txt_general_id.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_general_id.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_general_id.EnabledBackColor = System.Drawing.Color.White
        Me.txt_general_id.ispk = False
        Me.txt_general_id.Location = New System.Drawing.Point(294, 266)
        Me.txt_general_id.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_general_id.MultiLine = False
        Me.txt_general_id.Name = "txt_general_id"
        Me.txt_general_id.NoClear = False
        Me.txt_general_id.NumberFormat = "@"
        Me.txt_general_id.Required = False
        Me.txt_general_id.RowData = Nothing
        Me.txt_general_id.SelectionLength = 0
        Me.txt_general_id.SelectionStart = 0
        Me.txt_general_id.Size = New System.Drawing.Size(150, 20)
        Me.txt_general_id.TabIndex = 281
        Me.txt_general_id.TableData = Nothing
        Me.txt_general_id.TextSource = ""
        Me.txt_general_id.UseSystemPasswordChar = False
        Me.txt_general_id.Value = ""
        Me.txt_general_id.ValueSource = ""
        '
        'printingbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 370)
        Me.Controls.Add(Me.txt_general_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.groupByBook)
        Me.Controls.Add(Me.parent_grid)
        Me.Controls.Add(Me.btnTabSeparated)
        Me.Controls.Add(Me.range_filter)
        Me.Controls.Add(Me.txt_date_from)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.checkAllJournal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.checkAllBook)
        Me.Controls.Add(Me.txt_date_to)
        Me.Controls.Add(Me.dgJournal)
        Me.Controls.Add(Me.dgBooks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_sort)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "printingbooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing of Vouchers"
        CType(Me.dgJournal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.range_filter.ResumeLayout(False)
        Me.range_filter.PerformLayout()
        CType(Me.parent_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trans_header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents dgJournal As System.Windows.Forms.DataGridView
    Friend WithEvents sel1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents journal_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBooks As System.Windows.Forms.DataGridView
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents book_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents book_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents range_filter As System.Windows.Forms.Panel
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_sort As System.Windows.Forms.ComboBox
    Friend WithEvents checkAllJournal As System.Windows.Forms.CheckBox
    Friend WithEvents checkAllBook As System.Windows.Forms.CheckBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents btnTabSeparated As Windows.Forms.Button
    Friend WithEvents folderBrowser As Windows.Forms.FolderBrowserDialog
    Friend WithEvents parent_grid As Windows.Forms.DataGridView
    Friend WithEvents dsBooks As DataSet
    Friend WithEvents trans_header As DataTable
    Friend WithEvents trans_no As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents groupByBook As Windows.Forms.CheckBox
    Friend WithEvents lblLoad As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txt_general_id As user_control.textbox
End Class
