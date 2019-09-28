<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportGeneral
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
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerateTemplate = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ds = New System.Data.DataSet()
        Me.dt = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
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
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.dt_terms = New System.Data.DataTable()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.dt_catefory = New System.Data.DataTable()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.dt_industry = New System.Data.DataTable()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.Myformheader1 = New user_control.myformheader()
        Me.border1 = New accounting.borderedlabel()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_terms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_catefory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_industry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath.Location = New System.Drawing.Point(12, 67)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(390, 61)
        Me.txtPath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 25)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Import General Library"
        '
        'btnGenerateTemplate
        '
        Me.btnGenerateTemplate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGenerateTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnGenerateTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnGenerateTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateTemplate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateTemplate.ForeColor = System.Drawing.Color.White
        Me.btnGenerateTemplate.Location = New System.Drawing.Point(408, 67)
        Me.btnGenerateTemplate.Name = "btnGenerateTemplate"
        Me.btnGenerateTemplate.Size = New System.Drawing.Size(80, 24)
        Me.btnGenerateTemplate.TabIndex = 85
        Me.btnGenerateTemplate.Text = "Template"
        Me.btnGenerateTemplate.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(408, 97)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(80, 24)
        Me.btnBrowse.TabIndex = 86
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.Green
        Me.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.White
        Me.btnImport.Location = New System.Drawing.Point(167, 134)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 24)
        Me.btnImport.TabIndex = 87
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(253, 134)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 88
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.dt, Me.dt_terms, Me.dt_catefory, Me.dt_industry})
        '
        'dt
        '
        Me.dt.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.dt.TableName = "dt"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "general_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "general_code"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "general_name"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "date"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "address1"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "address2"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "address3"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "address4"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "attention"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "cell_no"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "tel_no"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "fax_no"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "category_id"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "category_code"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "category_name"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "tin"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "email_add"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "website"
        Me.DataColumn18.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "terms_id"
        Me.DataColumn19.DefaultValue = ""
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "terms_code"
        Me.DataColumn20.DefaultValue = ""
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "terms_name"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nodays"
        Me.DataColumn22.DataType = GetType(Integer)
        Me.DataColumn22.DefaultValue = 0
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "industry_id"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "industry_code"
        Me.DataColumn24.DefaultValue = ""
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "industry_name"
        Me.DataColumn25.DefaultValue = ""
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "status"
        Me.DataColumn26.DataType = GetType(Integer)
        Me.DataColumn26.DefaultValue = 0
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "status_name"
        Me.DataColumn27.DefaultValue = ""
        '
        'dt_terms
        '
        Me.dt_terms.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn28, Me.DataColumn29, Me.DataColumn30})
        Me.dt_terms.TableName = "dt_terms"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "terms_id"
        Me.DataColumn28.DefaultValue = ""
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "terms_code"
        Me.DataColumn29.DefaultValue = ""
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "terms_name"
        Me.DataColumn30.DefaultValue = ""
        '
        'dt_catefory
        '
        Me.dt_catefory.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn31, Me.DataColumn32, Me.DataColumn33})
        Me.dt_catefory.TableName = "dt_category"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "category_id"
        Me.DataColumn31.DefaultValue = ""
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "category_code"
        Me.DataColumn32.DefaultValue = ""
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "category_name"
        Me.DataColumn33.DefaultValue = ""
        '
        'dt_industry
        '
        Me.dt_industry.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn34, Me.DataColumn35, Me.DataColumn36})
        Me.dt_industry.TableName = "dt_industry"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "industry_id"
        Me.DataColumn34.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "industry_code"
        Me.DataColumn35.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "industry_name"
        Me.DataColumn36.DefaultValue = ""
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(500, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 62)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(476, 2)
        Me.border1.TabIndex = 84
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImportGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 170)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnGenerateTemplate)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImportGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import General Library"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_terms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_catefory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_industry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerateTemplate As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents dt As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents dt_terms As System.Data.DataTable
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents dt_catefory As System.Data.DataTable
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents dt_industry As System.Data.DataTable
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
End Class
