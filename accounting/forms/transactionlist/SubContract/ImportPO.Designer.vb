<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportPO
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
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ds = New System.Data.DataSet()
        Me.EXPORTAPPROJDET = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.currency = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.EXPORTAPPROJHEAD = New System.Data.DataTable()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.EXPORTDEPT = New System.Data.DataTable()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.EXPORTGENERAL = New System.Data.DataTable()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.EXPORTPROJ = New System.Data.DataTable()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPORTAPPROJDET, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPORTAPPROJHEAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPORTDEPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPORTGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPORTPROJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path to System Data"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 58)
        Me.txtPath.MaxLength = 0
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(174, 28)
        Me.txtPath.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(192, 58)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(80, 28)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.White
        Me.btnImport.Location = New System.Drawing.Point(102, 92)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 28)
        Me.btnImport.TabIndex = 8
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(7, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 2)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Import Form"
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.EXPORTAPPROJDET, Me.EXPORTAPPROJHEAD, Me.EXPORTDEPT, Me.EXPORTGENERAL, Me.EXPORTPROJ})
        '
        'EXPORTAPPROJDET
        '
        Me.EXPORTAPPROJDET.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.currency, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.EXPORTAPPROJDET.TableName = "EXPORTAPPROJDET"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "yearref"
        Me.DataColumn1.ColumnName = "yearref"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "project"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "prj_desc"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "date"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "dept_cd"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "partdesc"
        Me.DataColumn6.DefaultValue = ""
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "amount"
        Me.DataColumn7.DataType = GetType(Decimal)
        Me.DataColumn7.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "oamount"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'currency
        '
        Me.currency.ColumnName = "currency"
        Me.currency.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "exrate"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "basedrate"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "supcd"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "po_no"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "cons1"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "cons2"
        Me.DataColumn15.DefaultValue = ""
        '
        'EXPORTAPPROJHEAD
        '
        Me.EXPORTAPPROJHEAD.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.EXPORTAPPROJHEAD.TableName = "EXPORTAPPROJHEAD"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "yearref"
        Me.DataColumn16.DefaultValue = ""
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "project"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "prj_desc"
        Me.DataColumn18.DefaultValue = ""
        '
        'EXPORTDEPT
        '
        Me.EXPORTDEPT.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20})
        Me.EXPORTDEPT.TableName = "EXPORTDEPT"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "dept_cd"
        Me.DataColumn19.DefaultValue = ""
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "dept_name"
        Me.DataColumn20.DefaultValue = ""
        '
        'EXPORTGENERAL
        '
        Me.EXPORTGENERAL.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63})
        Me.EXPORTGENERAL.TableName = "EXPORTGENERAL"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "code"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "name"
        Me.DataColumn24.DefaultValue = ""
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "address1"
        Me.DataColumn25.DefaultValue = ""
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "address2"
        Me.DataColumn26.DefaultValue = ""
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "address3"
        Me.DataColumn27.DefaultValue = ""
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "address4"
        Me.DataColumn28.DefaultValue = ""
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "attention"
        Me.DataColumn29.DefaultValue = ""
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "position"
        Me.DataColumn30.DefaultValue = ""
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "tel_no"
        Me.DataColumn31.DefaultValue = ""
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "fax_no"
        Me.DataColumn32.DefaultValue = ""
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "cellphone"
        Me.DataColumn33.DefaultValue = ""
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "category"
        Me.DataColumn34.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "tin"
        Me.DataColumn35.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "email"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "website"
        Me.DataColumn37.DefaultValue = ""
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "terms"
        Me.DataColumn38.DefaultValue = ""
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "credit_amt"
        Me.DataColumn39.DataType = GetType(Decimal)
        Me.DataColumn39.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "no_days"
        Me.DataColumn40.DataType = GetType(Integer)
        Me.DataColumn40.DefaultValue = 0
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "remarks"
        Me.DataColumn41.DefaultValue = ""
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "vat"
        Me.DataColumn42.DefaultValue = ""
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "status"
        Me.DataColumn43.DefaultValue = ""
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "curre_days"
        Me.DataColumn44.DataType = GetType(Integer)
        Me.DataColumn44.DefaultValue = 0
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "date"
        Me.DataColumn45.DataType = GetType(Date)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "cclient"
        Me.DataColumn46.DefaultValue = ""
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "cprospect"
        Me.DataColumn47.DefaultValue = ""
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "per_discnt"
        Me.DataColumn48.DataType = GetType(Decimal)
        Me.DataColumn48.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "indstry"
        Me.DataColumn49.DefaultValue = ""
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "restricted"
        Me.DataColumn50.DefaultValue = ""
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "branch"
        Me.DataColumn51.DefaultValue = ""
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "rdo"
        Me.DataColumn52.DefaultValue = ""
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "atc_cd"
        Me.DataColumn53.DefaultValue = ""
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "ewt_cd"
        Me.DataColumn54.DefaultValue = ""
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "prj_cd"
        Me.DataColumn55.DefaultValue = ""
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "billto"
        Me.DataColumn56.DefaultValue = ""
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "billadd1"
        Me.DataColumn57.DefaultValue = ""
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "billadd2"
        Me.DataColumn58.DefaultValue = ""
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "billadd3"
        Me.DataColumn59.DefaultValue = ""
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "billadd4"
        Me.DataColumn60.DefaultValue = ""
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "billatt"
        Me.DataColumn61.DefaultValue = ""
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "drawing"
        Me.DataColumn62.DefaultValue = ""
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "specs"
        Me.DataColumn63.DefaultValue = ""
        '
        'EXPORTPROJ
        '
        Me.EXPORTPROJ.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22})
        Me.EXPORTPROJ.TableName = "EXPORTPROJ"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "prj_cd"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "prj_name"
        Me.DataColumn22.DefaultValue = ""
        '
        'ImportPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 131)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportPO"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Form"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPORTAPPROJDET, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPORTAPPROJHEAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPORTDEPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPORTGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPORTPROJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtPath As Windows.Forms.TextBox
    Friend WithEvents btnBrowse As Windows.Forms.Button
    Friend WithEvents btnImport As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ds As DataSet
    Friend WithEvents EXPORTAPPROJDET As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents currency As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents EXPORTAPPROJHEAD As DataTable
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents DataColumn18 As DataColumn
    Friend WithEvents EXPORTDEPT As DataTable
    Friend WithEvents DataColumn19 As DataColumn
    Friend WithEvents DataColumn20 As DataColumn
    Friend WithEvents EXPORTGENERAL As DataTable
    Friend WithEvents DataColumn23 As DataColumn
    Friend WithEvents DataColumn24 As DataColumn
    Friend WithEvents DataColumn25 As DataColumn
    Friend WithEvents DataColumn26 As DataColumn
    Friend WithEvents DataColumn27 As DataColumn
    Friend WithEvents DataColumn28 As DataColumn
    Friend WithEvents DataColumn29 As DataColumn
    Friend WithEvents DataColumn30 As DataColumn
    Friend WithEvents DataColumn31 As DataColumn
    Friend WithEvents DataColumn32 As DataColumn
    Friend WithEvents DataColumn33 As DataColumn
    Friend WithEvents DataColumn34 As DataColumn
    Friend WithEvents DataColumn35 As DataColumn
    Friend WithEvents DataColumn36 As DataColumn
    Friend WithEvents DataColumn37 As DataColumn
    Friend WithEvents DataColumn38 As DataColumn
    Friend WithEvents DataColumn39 As DataColumn
    Friend WithEvents DataColumn40 As DataColumn
    Friend WithEvents DataColumn41 As DataColumn
    Friend WithEvents DataColumn42 As DataColumn
    Friend WithEvents DataColumn43 As DataColumn
    Friend WithEvents DataColumn44 As DataColumn
    Friend WithEvents DataColumn45 As DataColumn
    Friend WithEvents DataColumn46 As DataColumn
    Friend WithEvents DataColumn47 As DataColumn
    Friend WithEvents DataColumn48 As DataColumn
    Friend WithEvents DataColumn49 As DataColumn
    Friend WithEvents DataColumn50 As DataColumn
    Friend WithEvents DataColumn51 As DataColumn
    Friend WithEvents DataColumn52 As DataColumn
    Friend WithEvents DataColumn53 As DataColumn
    Friend WithEvents DataColumn54 As DataColumn
    Friend WithEvents DataColumn55 As DataColumn
    Friend WithEvents DataColumn56 As DataColumn
    Friend WithEvents DataColumn57 As DataColumn
    Friend WithEvents DataColumn58 As DataColumn
    Friend WithEvents DataColumn59 As DataColumn
    Friend WithEvents DataColumn60 As DataColumn
    Friend WithEvents DataColumn61 As DataColumn
    Friend WithEvents DataColumn62 As DataColumn
    Friend WithEvents DataColumn63 As DataColumn
    Friend WithEvents EXPORTPROJ As DataTable
    Friend WithEvents DataColumn21 As DataColumn
    Friend WithEvents DataColumn22 As DataColumn
End Class
