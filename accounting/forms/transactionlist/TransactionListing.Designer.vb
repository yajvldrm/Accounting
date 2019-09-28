<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionListing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgList = New System.Windows.Forms.DataGridView()
        Me.bs_trans = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet()
        Me.dt_trans = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.txtsearch = New user_control.textbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.col_trans_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_general_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_general_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToDeleteRows = False
        Me.dgList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgList.AutoGenerateColumns = False
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_trans_id, Me.col_trans_no, Me.col_trans_date, Me.col_general_code, Me.col_general_name, Me.check_no, Me.col_amount})
        Me.dgList.DataSource = Me.bs_trans
        Me.dgList.Location = New System.Drawing.Point(12, 38)
        Me.dgList.MultiSelect = False
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.RowHeadersVisible = False
        Me.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgList.Size = New System.Drawing.Size(776, 250)
        Me.dgList.TabIndex = 0
        '
        'bs_trans
        '
        Me.bs_trans.DataMember = "dt_trans"
        Me.bs_trans.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "ds"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.dt_trans})
        '
        'dt_trans
        '
        Me.dt_trans.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.dt_trans.TableName = "dt_trans"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "trans_id"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "trans_no"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "trans_date"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "general_code"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "general_name"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "amount"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtsearch
        '
        Me.txtsearch._Text = ""
        Me.txtsearch.AllowNegative = False
        Me.txtsearch.AlwaysDisable = False
        Me.txtsearch.AlwaysEnable = False
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderColor = System.Drawing.Color.DarkGray
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.DataSource = ""
        Me.txtsearch.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtsearch.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtsearch.EnabledBackColor = System.Drawing.Color.White
        Me.txtsearch.ispk = False
        Me.txtsearch.Location = New System.Drawing.Point(638, 12)
        Me.txtsearch.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsearch.MultiLine = False
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.NoClear = False
        Me.txtsearch.NumberFormat = "@"
        Me.txtsearch.Required = False
        Me.txtsearch.RowData = Nothing
        Me.txtsearch.SelectionLength = 0
        Me.txtsearch.SelectionStart = 0
        Me.txtsearch.Size = New System.Drawing.Size(150, 20)
        Me.txtsearch.TabIndex = 108
        Me.txtsearch.TableData = Nothing
        Me.txtsearch.TextSource = "trans_no,general_name,check_no"
        Me.txtsearch.UseSystemPasswordChar = False
        Me.txtsearch.Value = ""
        Me.txtsearch.ValueSource = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(594, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Transaction List"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "check_no"
        Me.DataColumn7.DefaultValue = ""
        '
        'col_trans_id
        '
        Me.col_trans_id.DataPropertyName = "trans_id"
        Me.col_trans_id.HeaderText = "trans_id"
        Me.col_trans_id.Name = "col_trans_id"
        Me.col_trans_id.ReadOnly = True
        Me.col_trans_id.Visible = False
        '
        'col_trans_no
        '
        Me.col_trans_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_trans_no.DataPropertyName = "trans_no"
        Me.col_trans_no.HeaderText = "Reference No"
        Me.col_trans_no.Name = "col_trans_no"
        Me.col_trans_no.ReadOnly = True
        '
        'col_trans_date
        '
        Me.col_trans_date.DataPropertyName = "trans_date"
        Me.col_trans_date.HeaderText = "Date"
        Me.col_trans_date.Name = "col_trans_date"
        Me.col_trans_date.ReadOnly = True
        '
        'col_general_code
        '
        Me.col_general_code.DataPropertyName = "general_code"
        Me.col_general_code.HeaderText = "general_code"
        Me.col_general_code.Name = "col_general_code"
        Me.col_general_code.ReadOnly = True
        Me.col_general_code.Visible = False
        '
        'col_general_name
        '
        Me.col_general_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_general_name.DataPropertyName = "general_name"
        Me.col_general_name.HeaderText = "Gen.Ref"
        Me.col_general_name.Name = "col_general_name"
        Me.col_general_name.ReadOnly = True
        '
        'check_no
        '
        Me.check_no.DataPropertyName = "check_no"
        Me.check_no.HeaderText = "Check No"
        Me.check_no.Name = "check_no"
        Me.check_no.ReadOnly = True
        Me.check_no.Visible = False
        '
        'col_amount
        '
        Me.col_amount.DataPropertyName = "amount"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.col_amount.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_amount.HeaderText = "Amount"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.ReadOnly = True
        '
        'TransactionListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 300)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgList)
        Me.Name = "TransactionListing"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionListing"
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_trans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_trans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgList As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearch As user_control.textbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ds As DataSet
    Friend WithEvents bs_trans As Windows.Forms.BindingSource
    Friend WithEvents dt_trans As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents col_trans_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_trans_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_trans_date As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_general_code As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_general_name As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check_no As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_amount As Windows.Forms.DataGridViewTextBoxColumn
End Class
