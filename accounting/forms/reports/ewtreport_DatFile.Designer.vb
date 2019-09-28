<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ewtreport_DatFile
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
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.company_info = New System.Data.DataTable()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.ds_Outputvats = New System.Data.DataSet()
        Me.company_output_vat_totals = New System.Data.DataTable()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.txt_year = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.saveAs = New DevExpress.XtraEditors.SimpleButton()
        Me.Myformheader1 = New user_control.myformheader()
        CType(Me.company_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_Outputvats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.company_output_vat_totals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "fiscal_month"
        Me.DataColumn26.DataType = GetType(Integer)
        Me.DataColumn26.DefaultValue = 0
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "currency_id"
        Me.DataColumn6.DataType = GetType(Integer)
        Me.DataColumn6.DefaultValue = 0
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "address2"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "address1"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "company_name"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "company_code"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "general_id"
        Me.DataColumn1.ColumnName = "company_id"
        Me.DataColumn1.DataType = GetType(Integer)
        Me.DataColumn1.DefaultValue = 0
        '
        'company_info
        '
        Me.company_info.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn26})
        Me.company_info.TableName = "company_info"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "tel_no"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "fax_no"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "email_add"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "tin"
        Me.DataColumn10.DefaultValue = ""
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
        'ds_Outputvats
        '
        Me.ds_Outputvats.DataSetName = "NewDataSet"
        Me.ds_Outputvats.Tables.AddRange(New System.Data.DataTable() {Me.company_info, Me.company_output_vat_totals})
        '
        'company_output_vat_totals
        '
        Me.company_output_vat_totals.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25})
        Me.company_output_vat_totals.TableName = "company_output_vat_totals"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "general_id"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "general_code"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "general_name"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "tin"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "address1"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "address2"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "net_amount"
        Me.DataColumn22.DataType = GetType(Decimal)
        Me.DataColumn22.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "net_amount_based"
        Me.DataColumn23.DataType = GetType(Decimal)
        Me.DataColumn23.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "vat_amount"
        Me.DataColumn24.DataType = GetType(Decimal)
        Me.DataColumn24.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "vat_amount_based"
        Me.DataColumn25.DataType = GetType(Decimal)
        Me.DataColumn25.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(42, 14)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonth.TabIndex = 10
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_year.Location = New System.Drawing.Point(42, 42)
        Me.txt_year.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_year.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(121, 20)
        Me.txt_year.TabIndex = 9
        Me.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_year.Value = New Decimal(New Integer() {2019, 0, 0, 0})
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMonth)
        Me.GroupBox1.Controls.Add(Me.txt_year)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SimpleButton2)
        Me.GroupBox1.Controls.Add(Me.saveAs)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 108)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
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
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(207, 28)
        Me.Myformheader1.TabIndex = 7
        '
        'ewtreport_DatFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 148)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ewtreport_DatFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ewt"
        CType(Me.company_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_Outputvats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.company_output_vat_totals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataColumn26 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents company_info As DataTable
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Public WithEvents ds_Outputvats As DataSet
    Friend WithEvents company_output_vat_totals As DataTable
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents DataColumn18 As DataColumn
    Friend WithEvents DataColumn22 As DataColumn
    Friend WithEvents DataColumn23 As DataColumn
    Friend WithEvents DataColumn24 As DataColumn
    Friend WithEvents DataColumn25 As DataColumn
    Friend WithEvents folderBrowser As Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmbMonth As Windows.Forms.ComboBox
    Friend WithEvents txt_year As Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents saveAs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Myformheader1 As user_control.myformheader
End Class
