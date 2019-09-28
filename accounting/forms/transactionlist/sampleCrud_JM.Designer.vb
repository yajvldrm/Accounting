<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sampleCrud_JMs
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
        Me.components = New System.ComponentModel.Container()
        Me.ds = New System.Data.DataSet()
        Me.tbl_crud = New System.Data.DataTable()
        Me.idss = New System.Data.DataColumn()
        Me.namess = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.pk_ids = New System.Data.DataColumn()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ids = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.names = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_crud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.tbl_crud})
        '
        'tbl_crud
        '
        Me.tbl_crud.Columns.AddRange(New System.Data.DataColumn() {Me.idss, Me.namess, Me.DataColumn3, Me.DataColumn4, Me.DataColumn2, Me.pk_ids})
        Me.tbl_crud.TableName = "tbl_crud"
        '
        'idss
        '
        Me.idss.Caption = "ids"
        Me.idss.ColumnName = "ids"
        Me.idss.DefaultValue = ""
        '
        'namess
        '
        Me.namess.ColumnName = "namess"
        Me.namess.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "course"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "year"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "deleted"
        Me.DataColumn2.DataType = GetType(Boolean)
        Me.DataColumn2.DefaultValue = False
        '
        'pk_ids
        '
        Me.pk_ids.ColumnName = "pk_id"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.AutoGenerateColumns = False
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.ids, Me.names, Me.course, Me.year, Me.deleted})
        Me.dgview.DataSource = Me.bs
        Me.dgview.Location = New System.Drawing.Point(12, 49)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(488, 238)
        Me.dgview.TabIndex = 1
        '
        'bs
        '
        Me.bs.DataMember = "tbl_crud"
        Me.bs.DataSource = Me.ds
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(170, 12)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(75, 23)
        Me.btn_remove.TabIndex = 2
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(91, 12)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 3
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = ""
        Me.sel.Name = "sel"
        Me.sel.ReadOnly = True
        Me.sel.Width = 33
        '
        'ids
        '
        Me.ids.DataPropertyName = "ids"
        Me.ids.HeaderText = "ids"
        Me.ids.Name = "ids"
        Me.ids.ReadOnly = True
        '
        'names
        '
        Me.names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.names.DataPropertyName = "namess"
        Me.names.HeaderText = "namess"
        Me.names.Name = "names"
        Me.names.ReadOnly = True
        '
        'course
        '
        Me.course.DataPropertyName = "course"
        Me.course.HeaderText = "course"
        Me.course.Name = "course"
        Me.course.ReadOnly = True
        '
        'year
        '
        Me.year.DataPropertyName = "year"
        Me.year.HeaderText = "year"
        Me.year.Name = "year"
        Me.year.ReadOnly = True
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.ReadOnly = True
        Me.deleted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deleted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.deleted.Visible = False
        '
        'sampleCrud_JMs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 316)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgview)
        Me.Name = "sampleCrud_JMs"
        Me.Text = "sampleCrud_JM"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_crud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ds As DataSet
    Friend WithEvents tbl_crud As DataTable
    Friend WithEvents idss As DataColumn
    Friend WithEvents namess As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents dgview As Windows.Forms.DataGridView
    Friend WithEvents bs As Windows.Forms.BindingSource
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents pk_ids As DataColumn
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents btn_remove As Windows.Forms.Button
    Friend WithEvents btn_edit As Windows.Forms.Button
    Friend WithEvents sel As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ids As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents names As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents course As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents year As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deleted As Windows.Forms.DataGridViewCheckBoxColumn
End Class
