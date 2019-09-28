<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputVat_importation_DatFile
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
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.company_input_vat_totals = New System.Data.DataTable()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMonths = New System.Windows.Forms.ComboBox()
        Me.txt_years = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.saveAs = New DevExpress.XtraEditors.SimpleButton()
        Me.Myformheader1 = New user_control.myformheader()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.company_info = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.ds_inputvats = New System.Data.DataSet()
        CType(Me.company_input_vat_totals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_years, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.company_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_inputvats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "email_add"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "beg_month"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "rdo_code"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "fiscal_month"
        '
        'company_input_vat_totals
        '
        Me.company_input_vat_totals.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33})
        Me.company_input_vat_totals.TableName = "company_input_vat_totals"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "general_id"
        Me.DataColumn13.DefaultValue = "0"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "general_code"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "general_name"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "tin"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "address1"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "address2"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "import_Entry_id"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "import_Entry_no"
        Me.DataColumn20.DefaultValue = ""
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Release_date"
        Me.DataColumn21.DataType = GetType(Date)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Total_Landed_Cost"
        Me.DataColumn22.DataType = GetType(Decimal)
        Me.DataColumn22.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Taxable_goods"
        Me.DataColumn23.DataType = GetType(Decimal)
        Me.DataColumn23.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Date_of_importation"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Dutiable_value"
        Me.DataColumn25.DataType = GetType(Decimal)
        Me.DataColumn25.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "date_of_vatpayment"
        Me.DataColumn27.DataType = GetType(Date)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "country_of_origin"
        Me.DataColumn28.DefaultValue = ""
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "OR_number"
        Me.DataColumn29.DefaultValue = ""
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "all_charges_before_release_from_customs"
        Me.DataColumn30.DataType = GetType(Decimal)
        Me.DataColumn30.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "Exempt"
        Me.DataColumn31.DataType = GetType(Decimal)
        Me.DataColumn31.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "vat_amount"
        Me.DataColumn32.DataType = GetType(Decimal)
        Me.DataColumn32.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "vat_amount_based"
        Me.DataColumn33.DataType = GetType(Decimal)
        Me.DataColumn33.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "tin"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fax_no"
        Me.DataColumn8.DefaultValue = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMonths)
        Me.GroupBox1.Controls.Add(Me.txt_years)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SimpleButton2)
        Me.GroupBox1.Controls.Add(Me.saveAs)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 108)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cmbMonths
        '
        Me.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonths.FormattingEnabled = True
        Me.cmbMonths.Location = New System.Drawing.Point(42, 14)
        Me.cmbMonths.Name = "cmbMonths"
        Me.cmbMonths.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonths.TabIndex = 10
        '
        'txt_years
        '
        Me.txt_years.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_years.Location = New System.Drawing.Point(46, 42)
        Me.txt_years.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_years.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_years.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_years.Name = "txt_years"
        Me.txt_years.Size = New System.Drawing.Size(99, 20)
        Me.txt_years.TabIndex = 9
        Me.txt_years.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_years.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Month"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(7, 69)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Cancel"
        '
        'saveAs
        '
        Me.saveAs.Location = New System.Drawing.Point(88, 69)
        Me.saveAs.Name = "saveAs"
        Me.saveAs.Size = New System.Drawing.Size(75, 23)
        Me.saveAs.TabIndex = 5
        Me.saveAs.Text = "Save as"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 6)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(207, 28)
        Me.Myformheader1.TabIndex = 5
        '
        'company_info
        '
        Me.company_info.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn26})
        Me.company_info.TableName = "company_info"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "general_id"
        Me.DataColumn1.ColumnName = "company_id"
        Me.DataColumn1.DataType = GetType(Integer)
        Me.DataColumn1.DefaultValue = 0
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "company_code"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "company_name"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "address1"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "address2"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "currency_id"
        Me.DataColumn6.DataType = GetType(Integer)
        Me.DataColumn6.DefaultValue = 0
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tel_no"
        Me.DataColumn7.DefaultValue = ""
        '
        'ds_inputvats
        '
        Me.ds_inputvats.DataSetName = "NewDataSet"
        Me.ds_inputvats.Tables.AddRange(New System.Data.DataTable() {Me.company_info, Me.company_input_vat_totals})
        '
        'inputVat_importation_DatFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 148)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inputVat_importation_DatFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input VAT Importation"
        CType(Me.company_input_vat_totals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_years, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.company_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_inputvats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn26 As DataColumn
    Friend WithEvents company_input_vat_totals As DataTable
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents cmbMonths As Windows.Forms.ComboBox
    Friend WithEvents txt_years As Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveAs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents folderBrowser As Windows.Forms.FolderBrowserDialog
    Friend WithEvents company_info As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents ds_inputvats As DataSet
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents DataColumn18 As DataColumn
    Friend WithEvents DataColumn19 As DataColumn
    Friend WithEvents DataColumn20 As DataColumn
    Friend WithEvents DataColumn21 As DataColumn
    Friend WithEvents DataColumn22 As DataColumn
    Friend WithEvents DataColumn23 As DataColumn
    Friend WithEvents DataColumn24 As DataColumn
    Friend WithEvents DataColumn25 As DataColumn
    Friend WithEvents DataColumn27 As DataColumn
    Friend WithEvents DataColumn28 As DataColumn
    Friend WithEvents DataColumn29 As DataColumn
    Friend WithEvents DataColumn30 As DataColumn
    Friend WithEvents DataColumn31 As DataColumn
    Friend WithEvents DataColumn32 As DataColumn
    Friend WithEvents DataColumn33 As DataColumn
End Class
