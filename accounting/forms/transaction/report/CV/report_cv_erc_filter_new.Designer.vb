<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report_cv_erc_filter_new
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.border1 = New accounting.borderedlabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MyRadioGroup1 = New user_control.MyRadioGroup()
        Me.rdo_mds_check = New user_control.MyRadioButton()
        Me.rdo_ada = New user_control.MyRadioButton()
        Me.rdo_comm_check = New user_control.MyRadioButton()
        Me.rdo_others = New user_control.MyRadioButton()
        Me.cbo_fund_cluster = New System.Windows.Forms.ComboBox()
        Me.txt_ors_burs = New System.Windows.Forms.TextBox()
        Me.cbo_mfo_pap = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ds = New System.Data.DataSet()
        Me.lib_erp_fund = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.lib_erp_mfo = New System.Data.DataTable()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.MyRadioGroup1.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_fund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lib_erp_mfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(1, 1)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(824, 28)
        Me.Myformheader1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 25)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Check Voucher Report"
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(12, 66)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(672, 2)
        Me.border1.TabIndex = 74
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Fund Cluster"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "ORS / BURS No. "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "MFO/PAP"
        '
        'MyRadioGroup1
        '
        Me.MyRadioGroup1.AlwaysDisable = False
        Me.MyRadioGroup1.AlwaysEnable = False
        Me.MyRadioGroup1.Controls.Add(Me.rdo_others)
        Me.MyRadioGroup1.Controls.Add(Me.rdo_comm_check)
        Me.MyRadioGroup1.Controls.Add(Me.rdo_ada)
        Me.MyRadioGroup1.Controls.Add(Me.rdo_mds_check)
        Me.MyRadioGroup1.Location = New System.Drawing.Point(37, 275)
        Me.MyRadioGroup1.Name = "MyRadioGroup1"
        Me.MyRadioGroup1.NoSave = False
        Me.MyRadioGroup1.Required = False
        Me.MyRadioGroup1.Size = New System.Drawing.Size(293, 90)
        Me.MyRadioGroup1.TabIndex = 79
        Me.MyRadioGroup1.TabStop = False
        Me.MyRadioGroup1.Text = "Mode of Payment"
        Me.MyRadioGroup1.Value = ""
        Me.MyRadioGroup1.ValueSource = ""
        '
        'rdo_mds_check
        '
        Me.rdo_mds_check.AlwaysDisable = False
        Me.rdo_mds_check.AlwaysEnable = False
        Me.rdo_mds_check.AutoSize = True
        Me.rdo_mds_check.Location = New System.Drawing.Point(35, 30)
        Me.rdo_mds_check.Name = "rdo_mds_check"
        Me.rdo_mds_check.Size = New System.Drawing.Size(83, 17)
        Me.rdo_mds_check.TabIndex = 0
        Me.rdo_mds_check.TabStop = True
        Me.rdo_mds_check.Text = "MDS Check"
        Me.rdo_mds_check.Uncheckable = False
        Me.rdo_mds_check.UseVisualStyleBackColor = True
        Me.rdo_mds_check.Value = ""
        '
        'rdo_ada
        '
        Me.rdo_ada.AlwaysDisable = False
        Me.rdo_ada.AlwaysEnable = False
        Me.rdo_ada.AutoSize = True
        Me.rdo_ada.Location = New System.Drawing.Point(35, 53)
        Me.rdo_ada.Name = "rdo_ada"
        Me.rdo_ada.Size = New System.Drawing.Size(47, 17)
        Me.rdo_ada.TabIndex = 1
        Me.rdo_ada.TabStop = True
        Me.rdo_ada.Text = "ADA"
        Me.rdo_ada.Uncheckable = False
        Me.rdo_ada.UseVisualStyleBackColor = True
        Me.rdo_ada.Value = ""
        '
        'rdo_comm_check
        '
        Me.rdo_comm_check.AlwaysDisable = False
        Me.rdo_comm_check.AlwaysEnable = False
        Me.rdo_comm_check.AutoSize = True
        Me.rdo_comm_check.Location = New System.Drawing.Point(154, 30)
        Me.rdo_comm_check.Name = "rdo_comm_check"
        Me.rdo_comm_check.Size = New System.Drawing.Size(113, 17)
        Me.rdo_comm_check.TabIndex = 2
        Me.rdo_comm_check.TabStop = True
        Me.rdo_comm_check.Text = "Commercial Check"
        Me.rdo_comm_check.Uncheckable = False
        Me.rdo_comm_check.UseVisualStyleBackColor = True
        Me.rdo_comm_check.Value = ""
        '
        'rdo_others
        '
        Me.rdo_others.AlwaysDisable = False
        Me.rdo_others.AlwaysEnable = False
        Me.rdo_others.AutoSize = True
        Me.rdo_others.Location = New System.Drawing.Point(154, 53)
        Me.rdo_others.Name = "rdo_others"
        Me.rdo_others.Size = New System.Drawing.Size(56, 17)
        Me.rdo_others.TabIndex = 3
        Me.rdo_others.TabStop = True
        Me.rdo_others.Text = "Others"
        Me.rdo_others.Uncheckable = False
        Me.rdo_others.UseVisualStyleBackColor = True
        Me.rdo_others.Value = ""
        '
        'cbo_fund_cluster
        '
        Me.cbo_fund_cluster.FormattingEnabled = True
        Me.cbo_fund_cluster.Location = New System.Drawing.Point(125, 102)
        Me.cbo_fund_cluster.Name = "cbo_fund_cluster"
        Me.cbo_fund_cluster.Size = New System.Drawing.Size(546, 21)
        Me.cbo_fund_cluster.TabIndex = 80
        '
        'txt_ors_burs
        '
        Me.txt_ors_burs.Location = New System.Drawing.Point(125, 76)
        Me.txt_ors_burs.Name = "txt_ors_burs"
        Me.txt_ors_burs.Size = New System.Drawing.Size(546, 20)
        Me.txt_ors_burs.TabIndex = 81
        '
        'cbo_mfo_pap
        '
        Me.cbo_mfo_pap.FormattingEnabled = True
        Me.cbo_mfo_pap.Location = New System.Drawing.Point(125, 129)
        Me.cbo_mfo_pap.Name = "cbo_mfo_pap"
        Me.cbo_mfo_pap.Size = New System.Drawing.Size(371, 21)
        Me.cbo_mfo_pap.TabIndex = 82
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(541, 129)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox3.TabIndex = 84
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(191, 156)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(139, 20)
        Me.TextBox2.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Responsibility Center/Service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(509, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = " > "
        '
        'ds
        '
        Me.ds.DataSetName = "NewDataSet"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.lib_erp_fund, Me.lib_erp_mfo})
        '
        'lib_erp_fund
        '
        Me.lib_erp_fund.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.lib_erp_fund.TableName = "lib_erp_fund"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "fund_id"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "fund_code"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "fund_name"
        '
        'lib_erp_mfo
        '
        Me.lib_erp_mfo.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.lib_erp_mfo.TableName = "lib_erp_mfo"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "mfo_id"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "mfo_code"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "mfo_name"
        '
        'report_cv_erc_filter_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 449)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.cbo_mfo_pap)
        Me.Controls.Add(Me.txt_ors_burs)
        Me.Controls.Add(Me.cbo_fund_cluster)
        Me.Controls.Add(Me.MyRadioGroup1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "report_cv_erc_filter_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing Option"
        Me.MyRadioGroup1.ResumeLayout(False)
        Me.MyRadioGroup1.PerformLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_fund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lib_erp_mfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents border1 As borderedlabel
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents MyRadioGroup1 As user_control.MyRadioGroup
    Friend WithEvents rdo_others As user_control.MyRadioButton
    Friend WithEvents rdo_comm_check As user_control.MyRadioButton
    Friend WithEvents rdo_ada As user_control.MyRadioButton
    Friend WithEvents rdo_mds_check As user_control.MyRadioButton
    Friend WithEvents cbo_fund_cluster As Windows.Forms.ComboBox
    Friend WithEvents txt_ors_burs As Windows.Forms.TextBox
    Friend WithEvents cbo_mfo_pap As Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ds As DataSet
    Friend WithEvents lib_erp_fund As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents lib_erp_mfo As DataTable
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
End Class
