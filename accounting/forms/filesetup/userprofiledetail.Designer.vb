<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userprofiledetail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.module_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.profile_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.profile_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_view = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.m_add = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.m_edit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.m_delete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.m_cancel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.m_print = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.allAccess = New System.Windows.Forms.CheckBox()
        Me.allAdd = New System.Windows.Forms.CheckBox()
        Me.allEdit = New System.Windows.Forms.CheckBox()
        Me.allDelete = New System.Windows.Forms.CheckBox()
        Me.allCancel = New System.Windows.Forms.CheckBox()
        Me.allPrint = New System.Windows.Forms.CheckBox()
        Me.withFileSetup = New System.Windows.Forms.CheckBox()
        Me.withTransaction = New System.Windows.Forms.CheckBox()
        Me.withReport = New System.Windows.Forms.CheckBox()
        Me.withSystemConfiguration = New System.Windows.Forms.CheckBox()
        Me.allModules = New System.Windows.Forms.CheckBox()
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
        Me.border1 = New accounting.borderedlabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Myformheader1 = New user_control.myformheader()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMain.ColumnHeadersHeight = 40
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.module_code, Me.profile_det_id, Me.profile_id, Me.module_id, Me.module_name, Me.m_view, Me.m_add, Me.m_edit, Me.m_delete, Me.m_cancel, Me.m_print, Me.deleted})
        Me.dgMain.EnableHeadersVisualStyles = False
        Me.dgMain.Location = New System.Drawing.Point(18, 126)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgMain.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(800, 239)
        Me.dgMain.TabIndex = 78
        Me.dgMain.Tag = "maingrid"
        '
        'module_code
        '
        Me.module_code.DataPropertyName = "module_code"
        Me.module_code.HeaderText = "Code"
        Me.module_code.Name = "module_code"
        Me.module_code.ReadOnly = True
        Me.module_code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.module_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'profile_det_id
        '
        Me.profile_det_id.DataPropertyName = "profile_det_id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.profile_det_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.profile_det_id.HeaderText = "Profile Det ID"
        Me.profile_det_id.Name = "profile_det_id"
        Me.profile_det_id.Visible = False
        '
        'profile_id
        '
        Me.profile_id.DataPropertyName = "profile_id"
        Me.profile_id.HeaderText = "Profile ID"
        Me.profile_id.Name = "profile_id"
        Me.profile_id.Visible = False
        '
        'module_id
        '
        Me.module_id.DataPropertyName = "module_id"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.module_id.DefaultCellStyle = DataGridViewCellStyle3
        Me.module_id.HeaderText = "Module ID"
        Me.module_id.Name = "module_id"
        Me.module_id.Visible = False
        '
        'module_name
        '
        Me.module_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.module_name.DataPropertyName = "module_name"
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.module_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.module_name.HeaderText = "Module Name"
        Me.module_name.Name = "module_name"
        Me.module_name.ReadOnly = True
        Me.module_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.module_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'm_view
        '
        Me.m_view.DataPropertyName = "m_view"
        Me.m_view.HeaderText = ""
        Me.m_view.Name = "m_view"
        Me.m_view.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.m_view.Width = 65
        '
        'm_add
        '
        Me.m_add.DataPropertyName = "m_add"
        Me.m_add.HeaderText = ""
        Me.m_add.Name = "m_add"
        Me.m_add.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.m_add.Width = 65
        '
        'm_edit
        '
        Me.m_edit.DataPropertyName = "m_edit"
        Me.m_edit.HeaderText = ""
        Me.m_edit.Name = "m_edit"
        Me.m_edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.m_edit.Width = 65
        '
        'm_delete
        '
        Me.m_delete.DataPropertyName = "m_delete"
        Me.m_delete.HeaderText = ""
        Me.m_delete.Name = "m_delete"
        Me.m_delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.m_delete.Width = 65
        '
        'm_cancel
        '
        Me.m_cancel.DataPropertyName = "m_cancel"
        Me.m_cancel.HeaderText = ""
        Me.m_cancel.Name = "m_cancel"
        Me.m_cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.m_cancel.Width = 65
        '
        'm_print
        '
        Me.m_print.DataPropertyName = "m_print"
        Me.m_print.HeaderText = ""
        Me.m_print.Name = "m_print"
        Me.m_print.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.m_print.Width = 65
        '
        'deleted
        '
        Me.deleted.DataPropertyName = "deleted"
        Me.deleted.HeaderText = "Deleted"
        Me.deleted.Name = "deleted"
        Me.deleted.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(368, 373)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 23)
        Me.btnBack.TabIndex = 77
        Me.btnBack.Tag = "btnBack"
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "List of Modules"
        '
        'allAccess
        '
        Me.allAccess.AutoSize = True
        Me.allAccess.BackColor = System.Drawing.Color.Transparent
        Me.allAccess.Location = New System.Drawing.Point(451, 131)
        Me.allAccess.Name = "allAccess"
        Me.allAccess.Size = New System.Drawing.Size(15, 14)
        Me.allAccess.TabIndex = 79
        Me.allAccess.UseVisualStyleBackColor = False
        '
        'allAdd
        '
        Me.allAdd.AutoSize = True
        Me.allAdd.BackColor = System.Drawing.Color.Transparent
        Me.allAdd.Location = New System.Drawing.Point(517, 131)
        Me.allAdd.Name = "allAdd"
        Me.allAdd.Size = New System.Drawing.Size(15, 14)
        Me.allAdd.TabIndex = 80
        Me.allAdd.UseVisualStyleBackColor = False
        '
        'allEdit
        '
        Me.allEdit.AutoSize = True
        Me.allEdit.BackColor = System.Drawing.Color.Transparent
        Me.allEdit.Location = New System.Drawing.Point(582, 131)
        Me.allEdit.Name = "allEdit"
        Me.allEdit.Size = New System.Drawing.Size(15, 14)
        Me.allEdit.TabIndex = 81
        Me.allEdit.UseVisualStyleBackColor = False
        '
        'allDelete
        '
        Me.allDelete.AutoSize = True
        Me.allDelete.BackColor = System.Drawing.Color.Transparent
        Me.allDelete.Location = New System.Drawing.Point(647, 131)
        Me.allDelete.Name = "allDelete"
        Me.allDelete.Size = New System.Drawing.Size(15, 14)
        Me.allDelete.TabIndex = 82
        Me.allDelete.UseVisualStyleBackColor = False
        '
        'allCancel
        '
        Me.allCancel.AutoSize = True
        Me.allCancel.BackColor = System.Drawing.Color.Transparent
        Me.allCancel.Location = New System.Drawing.Point(712, 131)
        Me.allCancel.Name = "allCancel"
        Me.allCancel.Size = New System.Drawing.Size(15, 14)
        Me.allCancel.TabIndex = 83
        Me.allCancel.UseVisualStyleBackColor = False
        '
        'allPrint
        '
        Me.allPrint.AutoSize = True
        Me.allPrint.BackColor = System.Drawing.Color.Transparent
        Me.allPrint.Location = New System.Drawing.Point(779, 131)
        Me.allPrint.Name = "allPrint"
        Me.allPrint.Size = New System.Drawing.Size(15, 14)
        Me.allPrint.TabIndex = 84
        Me.allPrint.UseVisualStyleBackColor = False
        '
        'withFileSetup
        '
        Me.withFileSetup.AutoSize = True
        Me.withFileSetup.Location = New System.Drawing.Point(230, 80)
        Me.withFileSetup.Name = "withFileSetup"
        Me.withFileSetup.Size = New System.Drawing.Size(116, 17)
        Me.withFileSetup.TabIndex = 85
        Me.withFileSetup.Text = "File Setup Modules"
        Me.withFileSetup.UseVisualStyleBackColor = True
        '
        'withTransaction
        '
        Me.withTransaction.AutoSize = True
        Me.withTransaction.Location = New System.Drawing.Point(352, 80)
        Me.withTransaction.Name = "withTransaction"
        Me.withTransaction.Size = New System.Drawing.Size(125, 17)
        Me.withTransaction.TabIndex = 86
        Me.withTransaction.Text = "Transaction Modules"
        Me.withTransaction.UseVisualStyleBackColor = True
        '
        'withReport
        '
        Me.withReport.AutoSize = True
        Me.withReport.Location = New System.Drawing.Point(230, 103)
        Me.withReport.Name = "withReport"
        Me.withReport.Size = New System.Drawing.Size(101, 17)
        Me.withReport.TabIndex = 87
        Me.withReport.Text = "Report Modules"
        Me.withReport.UseVisualStyleBackColor = True
        '
        'withSystemConfiguration
        '
        Me.withSystemConfiguration.AutoSize = True
        Me.withSystemConfiguration.Location = New System.Drawing.Point(352, 103)
        Me.withSystemConfiguration.Name = "withSystemConfiguration"
        Me.withSystemConfiguration.Size = New System.Drawing.Size(168, 17)
        Me.withSystemConfiguration.TabIndex = 88
        Me.withSystemConfiguration.Text = "System Configuration Modules"
        Me.withSystemConfiguration.UseVisualStyleBackColor = True
        '
        'allModules
        '
        Me.allModules.AutoSize = True
        Me.allModules.Location = New System.Drawing.Point(526, 80)
        Me.allModules.Name = "allModules"
        Me.allModules.Size = New System.Drawing.Size(80, 17)
        Me.allModules.TabIndex = 89
        Me.allModules.Text = "All Modules"
        Me.allModules.UseVisualStyleBackColor = True
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.dt})
        '
        'dt
        '
        Me.dt.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.dt.TableName = "dt"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "profile_det_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "profile_id"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "module_id"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "module_code"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "module_name"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "m_view"
        Me.DataColumn6.DataType = GetType(Boolean)
        Me.DataColumn6.DefaultValue = False
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "m_add"
        Me.DataColumn7.DataType = GetType(Boolean)
        Me.DataColumn7.DefaultValue = False
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "m_edit"
        Me.DataColumn8.DataType = GetType(Boolean)
        Me.DataColumn8.DefaultValue = False
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "m_delete"
        Me.DataColumn9.DataType = GetType(Boolean)
        Me.DataColumn9.DefaultValue = False
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "m_cancel"
        Me.DataColumn10.DataType = GetType(Boolean)
        Me.DataColumn10.DefaultValue = False
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "m_print"
        Me.DataColumn11.DataType = GetType(Boolean)
        Me.DataColumn11.DefaultValue = False
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "deleted"
        Me.DataColumn12.DataType = GetType(Boolean)
        Me.DataColumn12.DefaultValue = False
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "module_type"
        Me.DataColumn13.DataType = GetType(Integer)
        Me.DataColumn13.DefaultValue = 0
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(18, 64)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(800, 2)
        Me.border1.TabIndex = 72
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Add"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(577, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Edit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(701, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Cancel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(637, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Delete"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(772, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Print"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(438, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Access"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(836, 28)
        Me.Myformheader1.TabIndex = 96
        '
        'userprofiledetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.Myformheader1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.allModules)
        Me.Controls.Add(Me.withSystemConfiguration)
        Me.Controls.Add(Me.withReport)
        Me.Controls.Add(Me.withTransaction)
        Me.Controls.Add(Me.withFileSetup)
        Me.Controls.Add(Me.allPrint)
        Me.Controls.Add(Me.allCancel)
        Me.Controls.Add(Me.allDelete)
        Me.Controls.Add(Me.allEdit)
        Me.Controls.Add(Me.allAdd)
        Me.Controls.Add(Me.allAccess)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "userprofiledetail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Modules"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents allAccess As System.Windows.Forms.CheckBox
    Friend WithEvents allAdd As System.Windows.Forms.CheckBox
    Friend WithEvents allEdit As System.Windows.Forms.CheckBox
    Friend WithEvents allDelete As System.Windows.Forms.CheckBox
    Friend WithEvents allCancel As System.Windows.Forms.CheckBox
    Friend WithEvents allPrint As System.Windows.Forms.CheckBox
    Friend WithEvents dgMain As System.Windows.Forms.DataGridView
    Friend WithEvents withFileSetup As System.Windows.Forms.CheckBox
    Friend WithEvents withTransaction As System.Windows.Forms.CheckBox
    Friend WithEvents withReport As System.Windows.Forms.CheckBox
    Friend WithEvents withSystemConfiguration As System.Windows.Forms.CheckBox
    Friend WithEvents allModules As System.Windows.Forms.CheckBox
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents module_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents profile_det_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents profile_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents module_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents module_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents m_view As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents m_add As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents m_edit As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents m_delete As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents m_cancel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents m_print As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents Myformheader1 As user_control.myformheader
End Class
