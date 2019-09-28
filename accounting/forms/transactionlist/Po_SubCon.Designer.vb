<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Po_SubCon
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
        Me.components = New System.ComponentModel.Container()
        Me.Myformheader1 = New user_control.myformheader()
        Me.txtFileName = New user_control.textbox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ds = New System.Data.DataSet()
        Me.table = New System.Data.DataTable()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(800, 30)
        Me.Myformheader1.TabIndex = 0
        '
        'txtFileName
        '
        Me.txtFileName._Text = ""
        Me.txtFileName.AllowNegative = False
        Me.txtFileName.AlwaysDisable = False
        Me.txtFileName.AlwaysEnable = False
        Me.txtFileName.BackColor = System.Drawing.Color.White
        Me.txtFileName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileName.DataSource = ""
        Me.txtFileName.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFileName.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFileName.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtFileName.EnabledBackColor = System.Drawing.Color.White
        Me.txtFileName.ispk = False
        Me.txtFileName.Location = New System.Drawing.Point(172, 56)
        Me.txtFileName.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFileName.MultiLine = False
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.NoClear = False
        Me.txtFileName.NumberFormat = "@"
        Me.txtFileName.Required = False
        Me.txtFileName.RowData = Nothing
        Me.txtFileName.SelectionLength = 0
        Me.txtFileName.SelectionStart = 0
        Me.txtFileName.Size = New System.Drawing.Size(105, 20)
        Me.txtFileName.TabIndex = 3
        Me.txtFileName.TableData = Nothing
        Me.txtFileName.TextSource = ""
        Me.txtFileName.UseSystemPasswordChar = False
        Me.txtFileName.Value = ""
        Me.txtFileName.ValueSource = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.table})
        '
        'table
        '
        Me.table.TableName = "table"
        '
        'bs
        '
        Me.bs.DataMember = "table"
        Me.bs.DataSource = Me.ds
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bs
        Me.GridControl1.Location = New System.Drawing.Point(24, 103)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(748, 449)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Po_SubCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Po_SubCon"
        Me.Text = "Po_SubCon"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents txtFileName As user_control.textbox
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents ds As DataSet
    Friend WithEvents table As DataTable
    Friend WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
