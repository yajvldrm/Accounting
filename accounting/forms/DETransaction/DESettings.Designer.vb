<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DESettings
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBookID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colbook_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbook_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbook_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonth = New DevExpress.XtraScheduler.UI.MonthEdit()
        Me.txtYear = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNotSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.journal_book_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEFileSetupSet = New accounting.DEFileSetupSet()
        Me.journal_book_ta = New accounting.DEFileSetupSetTableAdapters.get_journal_bookTableAdapter()
        CType(Me.txtBookID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.journal_book_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFileSetupSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 1)
        Me.Panel1.TabIndex = 365
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 364
        Me.Label1.Text = "Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 366
        Me.Label2.Text = "Book"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(76, 45)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBookID.Properties.DataSource = Me.journal_book_bs
        Me.txtBookID.Properties.DisplayMember = "book_name"
        Me.txtBookID.Properties.NullText = ""
        Me.txtBookID.Properties.ValueMember = "book_id"
        Me.txtBookID.Properties.View = Me.GridLookUpEdit1View
        Me.txtBookID.Size = New System.Drawing.Size(175, 20)
        Me.txtBookID.TabIndex = 367
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbook_id, Me.colbook_code, Me.colbook_name})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colbook_id
        '
        Me.colbook_id.FieldName = "book_id"
        Me.colbook_id.Name = "colbook_id"
        '
        'colbook_code
        '
        Me.colbook_code.Caption = "Code"
        Me.colbook_code.FieldName = "book_code"
        Me.colbook_code.Name = "colbook_code"
        Me.colbook_code.Visible = True
        Me.colbook_code.VisibleIndex = 0
        Me.colbook_code.Width = 100
        '
        'colbook_name
        '
        Me.colbook_name.Caption = "Name"
        Me.colbook_name.FieldName = "book_name"
        Me.colbook_name.Name = "colbook_name"
        Me.colbook_name.Visible = True
        Me.colbook_name.VisibleIndex = 1
        Me.colbook_name.Width = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 368
        Me.Label3.Text = "Month"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(76, 71)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMonth.Size = New System.Drawing.Size(175, 20)
        Me.txtMonth.TabIndex = 370
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(76, 97)
        Me.txtYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(50, 21)
        Me.txtYear.TabIndex = 371
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtYear.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 372
        Me.Label4.Text = "Year"
        '
        'btnNotSave
        '
        Me.btnNotSave.Location = New System.Drawing.Point(145, 124)
        Me.btnNotSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.Maroon
        Me.btnNotSave.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnNotSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnNotSave.Name = "btnNotSave"
        Me.btnNotSave.Size = New System.Drawing.Size(75, 23)
        Me.btnNotSave.TabIndex = 374
        Me.btnNotSave.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(64, 124)
        Me.btnSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.Green
        Me.btnSave.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 373
        Me.btnSave.Text = "Save"
        '
        'journal_book_bs
        '
        Me.journal_book_bs.DataMember = "get_journal_book"
        Me.journal_book_bs.DataSource = Me.DEFileSetupSet
        '
        'DEFileSetupSet
        '
        Me.DEFileSetupSet.DataSetName = "DEFileSetupSet"
        Me.DEFileSetupSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'journal_book_ta
        '
        Me.journal_book_ta.ClearBeforeFill = True
        '
        'DESettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.btnNotSave)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBookID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DESettings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.txtBookID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.journal_book_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFileSetupSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtBookID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtMonth As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents txtYear As Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents btnNotSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents journal_book_bs As Windows.Forms.BindingSource
    Friend WithEvents DEFileSetupSet As DEFileSetupSet
    Friend WithEvents colbook_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbook_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbook_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents journal_book_ta As DEFileSetupSetTableAdapters.get_journal_bookTableAdapter
End Class
