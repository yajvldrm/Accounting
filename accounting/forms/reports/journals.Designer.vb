<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class journals
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
        Me.Myformheader1 = New user_control.myformheader()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ds = New System.Data.DataSet()
        Me.general = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.journal = New System.Data.DataTable()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.range = New System.Windows.Forms.Panel()
        Me.txt_date_from = New System.Windows.Forms.DateTimePicker()
        Me.txt_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filter = New System.Windows.Forms.Panel()
        Me.rdo4 = New user_control.rdo_button()
        Me.rdo3 = New user_control.rdo_button()
        Me.rdo2 = New user_control.rdo_button()
        Me.rdo1 = New user_control.rdo_button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintOption = New System.Windows.Forms.Button()
        Me.lblLoad = New System.Windows.Forms.Label()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.general, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.journal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.range.SuspendLayout()
        Me.filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(300, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(74, 219)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 25)
        Me.btnPrint.TabIndex = 220
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
        Me.btnCancel.Location = New System.Drawing.Point(152, 219)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 25)
        Me.btnCancel.TabIndex = 219
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.general, Me.journal})
        '
        'general
        '
        Me.general.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.general.TableName = "general"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "trans_date"
        Me.DataColumn1.DataType = GetType(Date)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_no"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "description"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "account_name"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "debit"
        Me.DataColumn5.DataType = GetType(Decimal)
        Me.DataColumn5.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "credit"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "trans_id"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "account_id"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "debit_based"
        Me.DataColumn15.DataType = GetType(Decimal)
        Me.DataColumn15.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "credit_based"
        Me.DataColumn16.DataType = GetType(Decimal)
        Me.DataColumn16.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "account_code"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "validation"
        '
        'journal
        '
        Me.journal.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.journal.TableName = "journal"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "trans_id"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "trans_no"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "trans_date"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "amount"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "amount_based"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "description"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "discount"
        Me.DataColumn19.DataType = GetType(Decimal)
        Me.DataColumn19.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "discount_based"
        Me.DataColumn20.DataType = GetType(Decimal)
        Me.DataColumn20.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "vat"
        Me.DataColumn21.DataType = GetType(Decimal)
        Me.DataColumn21.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "vat_based"
        Me.DataColumn22.DataType = GetType(Decimal)
        Me.DataColumn22.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "general_code"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "general_name"
        Me.DataColumn24.DefaultValue = ""
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "address1"
        Me.DataColumn25.DefaultValue = ""
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "tin"
        Me.DataColumn26.DefaultValue = ""
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "general_id"
        Me.DataColumn27.DefaultValue = ""
        '
        'range
        '
        Me.range.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.range.Controls.Add(Me.txt_date_from)
        Me.range.Controls.Add(Me.txt_date_to)
        Me.range.Controls.Add(Me.Label1)
        Me.range.Controls.Add(Me.Label2)
        Me.range.Location = New System.Drawing.Point(11, 156)
        Me.range.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.range.Name = "range"
        Me.range.Size = New System.Drawing.Size(278, 55)
        Me.range.TabIndex = 230
        '
        'txt_date_from
        '
        Me.txt_date_from.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txt_date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_from.Location = New System.Drawing.Point(74, 3)
        Me.txt_date_from.Name = "txt_date_from"
        Me.txt_date_from.Size = New System.Drawing.Size(130, 21)
        Me.txt_date_from.TabIndex = 10
        Me.txt_date_from.Value = New Date(2017, 1, 31, 0, 0, 0, 0)
        '
        'txt_date_to
        '
        Me.txt_date_to.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txt_date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date_to.Location = New System.Drawing.Point(74, 30)
        Me.txt_date_to.Name = "txt_date_to"
        Me.txt_date_to.Size = New System.Drawing.Size(130, 21)
        Me.txt_date_to.TabIndex = 11
        Me.txt_date_to.Value = New Date(2017, 7, 31, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(50, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "To"
        '
        'filter
        '
        Me.filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filter.Controls.Add(Me.rdo4)
        Me.filter.Controls.Add(Me.rdo3)
        Me.filter.Controls.Add(Me.rdo2)
        Me.filter.Controls.Add(Me.rdo1)
        Me.filter.Location = New System.Drawing.Point(85, 35)
        Me.filter.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(130, 115)
        Me.filter.TabIndex = 232
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.DataSource = ""
        Me.rdo4.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rdo4.Location = New System.Drawing.Point(5, 78)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(119, 19)
        Me.rdo4.TabIndex = 238
        Me.rdo4.Text = "Purchase Journal"
        Me.rdo4.TextSource = ""
        Me.rdo4.Uncheckable = False
        Me.rdo4.UseVisualStyleBackColor = True
        Me.rdo4.Value = "4"
        Me.rdo4.ValueSource = ""
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.DataSource = ""
        Me.rdo3.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rdo3.Location = New System.Drawing.Point(5, 57)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(96, 19)
        Me.rdo3.TabIndex = 237
        Me.rdo3.Text = "Sales Journal"
        Me.rdo3.TextSource = ""
        Me.rdo3.Uncheckable = False
        Me.rdo3.UseVisualStyleBackColor = True
        Me.rdo3.Value = "3"
        Me.rdo3.ValueSource = ""
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.DataSource = ""
        Me.rdo2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rdo2.Location = New System.Drawing.Point(5, 36)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(112, 19)
        Me.rdo2.TabIndex = 236
        Me.rdo2.Text = "General Journal"
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
        Me.rdo1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rdo1.Location = New System.Drawing.Point(5, 15)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(109, 19)
        Me.rdo1.TabIndex = 235
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "General Ledger"
        Me.rdo1.TextSource = ""
        Me.rdo1.Uncheckable = False
        Me.rdo1.UseVisualStyleBackColor = True
        Me.rdo1.Value = "1"
        Me.rdo1.ValueSource = ""
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(11, 219)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(74, 25)
        Me.btnExcel.TabIndex = 233
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
        Me.btnPrintOption.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintOption.ForeColor = System.Drawing.Color.White
        Me.btnPrintOption.Location = New System.Drawing.Point(73, 219)
        Me.btnPrintOption.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnPrintOption.Name = "btnPrintOption"
        Me.btnPrintOption.Size = New System.Drawing.Size(75, 25)
        Me.btnPrintOption.TabIndex = 240
        Me.btnPrintOption.Text = "Print"
        Me.btnPrintOption.UseVisualStyleBackColor = False
        '
        'lblLoad
        '
        Me.lblLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoad.Location = New System.Drawing.Point(40, 78)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(221, 100)
        Me.lblLoad.TabIndex = 241
        Me.lblLoad.Text = "Please Wait..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Loading Excel Report"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoad.Visible = False
        '
        'journals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 257)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.btnPrintOption)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.filter)
        Me.Controls.Add(Me.range)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "journals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing of Journals"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.general, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.journal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.range.ResumeLayout(False)
        Me.range.PerformLayout()
        Me.filter.ResumeLayout(False)
        Me.filter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents general As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents range As System.Windows.Forms.Panel
    Friend WithEvents txt_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents filter As System.Windows.Forms.Panel
    Friend WithEvents rdo4 As user_control.rdo_button
    Friend WithEvents rdo3 As user_control.rdo_button
    Friend WithEvents rdo2 As user_control.rdo_button
    Friend WithEvents rdo1 As user_control.rdo_button
    Friend WithEvents journal As System.Data.DataTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnPrintOption As System.Windows.Forms.Button
    Friend WithEvents lblLoad As Windows.Forms.Label
End Class
