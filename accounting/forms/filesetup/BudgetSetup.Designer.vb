<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BudgetSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BudgetSetup))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.txtBased = New DevExpress.XtraEditors.TextEdit()
        Me.txtExchange = New DevExpress.XtraEditors.TextEdit()
        Me.txtCreditBsaed = New DevExpress.XtraEditors.TextEdit()
        Me.txtCredit = New DevExpress.XtraEditors.TextEdit()
        Me.txtDebitBased = New DevExpress.XtraEditors.TextEdit()
        Me.txtDebit = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtAccountCode = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
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
        Me.Panel1.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        CType(Me.txtBased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExchange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditBsaed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebitBased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 77)
        Me.Panel1.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(12, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 25)
        Me.Label13.TabIndex = 344
        Me.Label13.Text = "Budget Setup"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(351, 40)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 343
        Me.btnExit.Text = "F10 Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(265, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 24)
        Me.btnSearch.TabIndex = 342
        Me.btnSearch.Text = "F6 Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(179, 40)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 341
        Me.btnPrint.Text = "F5 Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(93, 40)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 24)
        Me.btnEdit.TabIndex = 340
        Me.btnEdit.Text = "F3 Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(10, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 24)
        Me.btnAdd.TabIndex = 339
        Me.btnAdd.Text = "F2 Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(377, 21)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(105, 20)
        Me.txtYear.TabIndex = 2
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(223, 21)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(116, 20)
        Me.txtMonth.TabIndex = 1
        '
        'txtCurrency
        '
        Me.txtCurrency.Location = New System.Drawing.Point(747, 21)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(186, 20)
        Me.txtCurrency.TabIndex = 4
        '
        'txtBook
        '
        Me.txtBook.Location = New System.Drawing.Point(526, 21)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Size = New System.Drawing.Size(125, 20)
        Me.txtBook.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(692, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 338
        Me.Label12.Text = "Currency"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(488, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 336
        Me.Label11.Text = "Book"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(345, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 334
        Me.Label10.Text = "Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(142, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 332
        Me.Label9.Text = "Month"
        '
        'pnlControls
        '
        Me.pnlControls.Controls.Add(Me.txtBased)
        Me.pnlControls.Controls.Add(Me.txtExchange)
        Me.pnlControls.Controls.Add(Me.txtCreditBsaed)
        Me.pnlControls.Controls.Add(Me.txtCredit)
        Me.pnlControls.Controls.Add(Me.txtDebitBased)
        Me.pnlControls.Controls.Add(Me.txtDebit)
        Me.pnlControls.Controls.Add(Me.Label7)
        Me.pnlControls.Controls.Add(Me.Label8)
        Me.pnlControls.Controls.Add(Me.Label6)
        Me.pnlControls.Controls.Add(Me.Label5)
        Me.pnlControls.Controls.Add(Me.Label4)
        Me.pnlControls.Controls.Add(Me.Label3)
        Me.pnlControls.Controls.Add(Me.txtDepartment)
        Me.pnlControls.Controls.Add(Me.Label2)
        Me.pnlControls.Controls.Add(Me.txtProject)
        Me.pnlControls.Controls.Add(Me.Label1)
        Me.pnlControls.Controls.Add(Me.txtAccountName)
        Me.pnlControls.Controls.Add(Me.PictureBox3)
        Me.pnlControls.Controls.Add(Me.txtAccountCode)
        Me.pnlControls.Controls.Add(Me.Label20)
        Me.pnlControls.Controls.Add(Me.btnUndo)
        Me.pnlControls.Controls.Add(Me.btnSave)
        Me.pnlControls.Controls.Add(Me.txtYear)
        Me.pnlControls.Controls.Add(Me.txtMonth)
        Me.pnlControls.Controls.Add(Me.txtCurrency)
        Me.pnlControls.Controls.Add(Me.txtBook)
        Me.pnlControls.Controls.Add(Me.Label12)
        Me.pnlControls.Controls.Add(Me.Label11)
        Me.pnlControls.Controls.Add(Me.Label10)
        Me.pnlControls.Controls.Add(Me.Label9)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlControls.Enabled = False
        Me.pnlControls.Location = New System.Drawing.Point(0, 403)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(1084, 170)
        Me.pnlControls.TabIndex = 1
        '
        'txtBased
        '
        Me.txtBased.EditValue = "0.00"
        Me.txtBased.Location = New System.Drawing.Point(747, 73)
        Me.txtBased.Name = "txtBased"
        Me.txtBased.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBased.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBased.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtBased.Properties.Mask.EditMask = "n2"
        Me.txtBased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBased.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBased.Properties.ReadOnly = True
        Me.txtBased.Size = New System.Drawing.Size(186, 20)
        Me.txtBased.TabIndex = 360
        '
        'txtExchange
        '
        Me.txtExchange.EditValue = "0.00"
        Me.txtExchange.Location = New System.Drawing.Point(747, 47)
        Me.txtExchange.Name = "txtExchange"
        Me.txtExchange.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExchange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExchange.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtExchange.Properties.Mask.EditMask = "n2"
        Me.txtExchange.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExchange.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExchange.Properties.ReadOnly = True
        Me.txtExchange.Size = New System.Drawing.Size(186, 20)
        Me.txtExchange.TabIndex = 359
        '
        'txtCreditBsaed
        '
        Me.txtCreditBsaed.EditValue = "0.00"
        Me.txtCreditBsaed.Enabled = False
        Me.txtCreditBsaed.Location = New System.Drawing.Point(476, 125)
        Me.txtCreditBsaed.Name = "txtCreditBsaed"
        Me.txtCreditBsaed.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCreditBsaed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCreditBsaed.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCreditBsaed.Properties.Mask.EditMask = "n2"
        Me.txtCreditBsaed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCreditBsaed.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCreditBsaed.Size = New System.Drawing.Size(175, 20)
        Me.txtCreditBsaed.TabIndex = 346
        '
        'txtCredit
        '
        Me.txtCredit.EditValue = "0.00"
        Me.txtCredit.Enabled = False
        Me.txtCredit.Location = New System.Drawing.Point(223, 125)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCredit.Properties.Mask.EditMask = "n2"
        Me.txtCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCredit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCredit.Size = New System.Drawing.Size(166, 20)
        Me.txtCredit.TabIndex = 345
        '
        'txtDebitBased
        '
        Me.txtDebitBased.EditValue = "0.00"
        Me.txtDebitBased.Enabled = False
        Me.txtDebitBased.Location = New System.Drawing.Point(476, 99)
        Me.txtDebitBased.Name = "txtDebitBased"
        Me.txtDebitBased.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebitBased.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebitBased.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDebitBased.Properties.Mask.EditMask = "n2"
        Me.txtDebitBased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebitBased.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebitBased.Size = New System.Drawing.Size(175, 20)
        Me.txtDebitBased.TabIndex = 344
        '
        'txtDebit
        '
        Me.txtDebit.EditValue = "0.00"
        Me.txtDebit.Enabled = False
        Me.txtDebit.Location = New System.Drawing.Point(223, 99)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDebit.Properties.Mask.EditMask = "n2"
        Me.txtDebit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebit.Size = New System.Drawing.Size(166, 20)
        Me.txtDebit.TabIndex = 343
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(405, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 358
        Me.Label7.Text = "Credit Based"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(405, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 357
        Me.Label8.Text = "Debit Based"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 356
        Me.Label6.Text = "Credit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 355
        Me.Label5.Text = "Debit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(678, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 354
        Me.Label4.Text = "Based Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(660, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 353
        Me.Label3.Text = "Exchange Rate"
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(476, 73)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(175, 20)
        Me.txtDepartment.TabIndex = 342
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(405, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 352
        Me.Label2.Text = "Department"
        '
        'txtProject
        '
        Me.txtProject.Location = New System.Drawing.Point(223, 73)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(166, 20)
        Me.txtProject.TabIndex = 341
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 351
        Me.Label1.Text = "Project"
        '
        'txtAccountName
        '
        Me.txtAccountName.BackColor = System.Drawing.Color.White
        Me.txtAccountName.Location = New System.Drawing.Point(395, 47)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.ReadOnly = True
        Me.txtAccountName.Size = New System.Drawing.Size(256, 20)
        Me.txtAccountName.TabIndex = 340
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(373, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 350
        Me.PictureBox3.TabStop = False
        '
        'txtAccountCode
        '
        Me.txtAccountCode.Location = New System.Drawing.Point(223, 47)
        Me.txtAccountCode.Name = "txtAccountCode"
        Me.txtAccountCode.Size = New System.Drawing.Size(144, 20)
        Me.txtAccountCode.TabIndex = 339
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(142, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 349
        Me.Label20.Text = "Account Code"
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.Maroon
        Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.ForeColor = System.Drawing.Color.White
        Me.btnUndo.Location = New System.Drawing.Point(813, 117)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(100, 24)
        Me.btnUndo.TabIndex = 348
        Me.btnUndo.Tag = "adjustToTop"
        Me.btnUndo.Text = "C&ancel"
        Me.btnUndo.UseVisualStyleBackColor = False
        Me.btnUndo.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(716, 117)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 347
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1063, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(21, 326)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 77)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(20, 326)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgv)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(20, 77)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1043, 326)
        Me.Panel5.TabIndex = 3
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column11, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1043, 326)
        Me.dgv.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "budget_id"
        Me.Column1.HeaderText = "account_id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "account_code"
        Me.Column2.HeaderText = "Account Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "account_name"
        Me.Column3.HeaderText = "Account Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "project_name"
        Me.Column4.HeaderText = "Project"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "department_name"
        Me.Column5.HeaderText = "Department"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "based_rate"
        Me.Column11.HeaderText = "Based Rate"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "exchange_rate"
        Me.Column6.HeaderText = "Exchange Rate"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "debit"
        Me.Column7.HeaderText = "Debit"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "debit_based"
        Me.Column8.HeaderText = "Debit Based"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "credit"
        Me.Column9.HeaderText = "Credit"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "credit_based"
        Me.Column10.HeaderText = "Credit Based"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'ds
        '
        Me.ds.DataSetName = "NewDataSet"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.DataTable1.TableName = "budget"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "budget_id"
        Me.DataColumn1.DataType = GetType(Integer)
        Me.DataColumn1.DefaultValue = 0
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "account_code"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "account_name"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "project_name"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "department_name"
        Me.DataColumn5.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "debit"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "debit_based"
        Me.DataColumn7.DataType = GetType(Decimal)
        Me.DataColumn7.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "credit"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "credit_based"
        Me.DataColumn9.DataType = GetType(Decimal)
        Me.DataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "exchange_rate"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "based_rate"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'BudgetSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 573)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BudgetSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.txtBased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExchange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditBsaed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebitBased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents pnlControls As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents Panel5 As Windows.Forms.Panel
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents dgv As Windows.Forms.DataGridView
    Friend WithEvents txtMonth As Windows.Forms.TextBox
    Friend WithEvents txtCurrency As Windows.Forms.TextBox
    Friend WithEvents txtBook As Windows.Forms.TextBox
    Friend WithEvents txtYear As Windows.Forms.TextBox
    Friend WithEvents ds As DataSet
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents btnExit As Windows.Forms.Button
    Friend WithEvents btnSearch As Windows.Forms.Button
    Friend WithEvents btnPrint As Windows.Forms.Button
    Friend WithEvents btnEdit As Windows.Forms.Button
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents Column1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txtBased As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExchange As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreditBsaed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebitBased As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtDepartment As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtProject As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtAccountName As Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As Windows.Forms.PictureBox
    Friend WithEvents txtAccountCode As Windows.Forms.TextBox
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents btnUndo As Windows.Forms.Button
    Friend WithEvents btnSave As Windows.Forms.Button
End Class
