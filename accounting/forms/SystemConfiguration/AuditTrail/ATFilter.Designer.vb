<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ATFilter
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
        Me.dgMain = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.txt_module_type = New user_control.MyTextBox()
        Me.btnExit = New user_control.MyButton()
        Me.btnPrint = New user_control.MyButton()
        Me.btnView = New user_control.MyButton()
        Me.txtFilter = New user_control.MyTextBox()
        Me.txtSubModuleFilter = New user_control.MyTextBox()
        Me.txtSubModule = New user_control.MyTextBox()
        Me.txtModule = New user_control.MyTextBox()
        Me.txtType = New user_control.MyRadioGroup()
        Me.MyRadioButton4 = New user_control.MyRadioButton()
        Me.MyRadioButton3 = New user_control.MyRadioButton()
        Me.MyRadioButton2 = New user_control.MyRadioButton()
        Me.MyRadioButton1 = New user_control.MyRadioButton()
        Me.Myformheader1 = New user_control.myformheader()
        Me.txtFilterValue = New user_control.MyTextBox()
        Me.border1 = New accounting.borderedlabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBook = New user_control.MyTextBox()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txtType.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgMain
        '
        Me.dgMain.Location = New System.Drawing.Point(12, 145)
        Me.dgMain.MainView = Me.GridView1
        Me.dgMain.Name = "dgMain"
        Me.dgMain.Size = New System.Drawing.Size(676, 343)
        Me.dgMain.TabIndex = 106
        Me.dgMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgMain
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowSeparatorHeight = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Audit Trail"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(320, 69)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(44, 13)
        Me.lblFilter.TabIndex = 98
        Me.lblFilter.Text = "Filter By"
        '
        'txt_module_type
        '
        Me.txt_module_type.AlwaysDisable = False
        Me.txt_module_type.AlwaysEnable = False
        Me.txt_module_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_module_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_module_type.BrowseDataSource = ""
        Me.txt_module_type.BrowseField = ""
        Me.txt_module_type.BrowseFilter = Nothing
        Me.txt_module_type.BrowseLabel = "Code,Name"
        Me.txt_module_type.BrowseLabelWidth = "100,200"
        Me.txt_module_type.BrowseTextSource = ""
        Me.txt_module_type.BrowseValueSource = ""
        Me.txt_module_type.Database = user_control.MyList.Database.FileSetup
        Me.txt_module_type.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_module_type.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_module_type.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_module_type.Enabled = False
        Me.txt_module_type.EnabledBackColor = System.Drawing.Color.White
        Me.txt_module_type.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_module_type.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_module_type.ID = False
        Me.txt_module_type.Location = New System.Drawing.Point(538, 38)
        Me.txt_module_type.Name = "txt_module_type"
        Me.txt_module_type.NoClear = False
        Me.txt_module_type.NoSave = False
        Me.txt_module_type.NumberFormat = "@"
        Me.txt_module_type.Required = False
        Me.txt_module_type.RowData = Nothing
        Me.txt_module_type.Size = New System.Drawing.Size(150, 20)
        Me.txt_module_type.TabIndex = 103
        Me.txt_module_type.TextBrowse = False
        Me.txt_module_type.TextSource = "at_module_type_name"
        Me.txt_module_type.ToUpper = True
        Me.txt_module_type.Unique = False
        Me.txt_module_type.Value = ""
        Me.txt_module_type.ValueSource = "at_module_type_id"
        Me.txt_module_type.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnExit.ButtonType = user_control.MyList.ButtonType.ButtonAdd
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(608, 89)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 102
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPrint.ButtonType = user_control.MyList.ButtonType.ButtonAdd
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(522, 89)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 101
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnView.ButtonType = user_control.MyList.ButtonType.ButtonAdd
        Me.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(436, 89)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(80, 24)
        Me.btnView.TabIndex = 100
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'txtFilter
        '
        Me.txtFilter.AlwaysDisable = False
        Me.txtFilter.AlwaysEnable = False
        Me.txtFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.BrowseDataSource = "[at_filter]"
        Me.txtFilter.BrowseField = "at_filter_name"
        Me.txtFilter.BrowseFilter = Nothing
        Me.txtFilter.BrowseLabel = "Name"
        Me.txtFilter.BrowseLabelWidth = "300"
        Me.txtFilter.BrowseTextSource = "at_filter_name"
        Me.txtFilter.BrowseValueSource = "at_filter_id"
        Me.txtFilter.Database = user_control.MyList.Database.FileSetup
        Me.txtFilter.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFilter.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFilter.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtFilter.Enabled = False
        Me.txtFilter.EnabledBackColor = System.Drawing.Color.White
        Me.txtFilter.EnabledForeColor = System.Drawing.Color.Black
        Me.txtFilter.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtFilter.ID = False
        Me.txtFilter.Location = New System.Drawing.Point(366, 66)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.NoClear = False
        Me.txtFilter.NoSave = False
        Me.txtFilter.NumberFormat = "@"
        Me.txtFilter.Required = True
        Me.txtFilter.RowData = Nothing
        Me.txtFilter.Size = New System.Drawing.Size(150, 20)
        Me.txtFilter.TabIndex = 97
        Me.txtFilter.TextBrowse = True
        Me.txtFilter.TextSource = ""
        Me.txtFilter.ToUpper = False
        Me.txtFilter.Unique = False
        Me.txtFilter.Value = ""
        Me.txtFilter.ValueSource = ""
        '
        'txtSubModuleFilter
        '
        Me.txtSubModuleFilter.AlwaysDisable = False
        Me.txtSubModuleFilter.AlwaysEnable = False
        Me.txtSubModuleFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSubModuleFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubModuleFilter.BrowseDataSource = "GetATSubModuleFilter"
        Me.txtSubModuleFilter.BrowseField = "at_sub_module_filter_name"
        Me.txtSubModuleFilter.BrowseFilter = Me.txtSubModule
        Me.txtSubModuleFilter.BrowseLabel = "Name"
        Me.txtSubModuleFilter.BrowseLabelWidth = "300"
        Me.txtSubModuleFilter.BrowseTextSource = "at_sub_module_filter_name"
        Me.txtSubModuleFilter.BrowseValueSource = "at_sub_module_filter_id"
        Me.txtSubModuleFilter.Database = user_control.MyList.Database.FileSetup
        Me.txtSubModuleFilter.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubModuleFilter.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSubModuleFilter.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtSubModuleFilter.Enabled = False
        Me.txtSubModuleFilter.EnabledBackColor = System.Drawing.Color.White
        Me.txtSubModuleFilter.EnabledForeColor = System.Drawing.Color.Black
        Me.txtSubModuleFilter.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtSubModuleFilter.ID = False
        Me.txtSubModuleFilter.Location = New System.Drawing.Point(341, 119)
        Me.txtSubModuleFilter.Name = "txtSubModuleFilter"
        Me.txtSubModuleFilter.NoClear = False
        Me.txtSubModuleFilter.NoSave = False
        Me.txtSubModuleFilter.NumberFormat = "@"
        Me.txtSubModuleFilter.Required = False
        Me.txtSubModuleFilter.RowData = Nothing
        Me.txtSubModuleFilter.Size = New System.Drawing.Size(150, 20)
        Me.txtSubModuleFilter.TabIndex = 96
        Me.txtSubModuleFilter.TextBrowse = True
        Me.txtSubModuleFilter.TextSource = ""
        Me.txtSubModuleFilter.ToUpper = False
        Me.txtSubModuleFilter.Unique = False
        Me.txtSubModuleFilter.Value = ""
        Me.txtSubModuleFilter.ValueSource = "at_sub_module_filter_id"
        '
        'txtSubModule
        '
        Me.txtSubModule.AlwaysDisable = False
        Me.txtSubModule.AlwaysEnable = False
        Me.txtSubModule.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSubModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubModule.BrowseDataSource = "GetATSubModule"
        Me.txtSubModule.BrowseField = "at_sub_module_name"
        Me.txtSubModule.BrowseFilter = Me.txtModule
        Me.txtSubModule.BrowseLabel = "Name"
        Me.txtSubModule.BrowseLabelWidth = "300"
        Me.txtSubModule.BrowseTextSource = "at_sub_module_name"
        Me.txtSubModule.BrowseValueSource = "at_sub_module_id"
        Me.txtSubModule.Database = user_control.MyList.Database.FileSetup
        Me.txtSubModule.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubModule.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSubModule.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtSubModule.Enabled = False
        Me.txtSubModule.EnabledBackColor = System.Drawing.Color.White
        Me.txtSubModule.EnabledForeColor = System.Drawing.Color.Black
        Me.txtSubModule.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtSubModule.ID = False
        Me.txtSubModule.Location = New System.Drawing.Point(185, 119)
        Me.txtSubModule.Name = "txtSubModule"
        Me.txtSubModule.NoClear = False
        Me.txtSubModule.NoSave = False
        Me.txtSubModule.NumberFormat = "@"
        Me.txtSubModule.Required = True
        Me.txtSubModule.RowData = Nothing
        Me.txtSubModule.Size = New System.Drawing.Size(150, 20)
        Me.txtSubModule.TabIndex = 95
        Me.txtSubModule.TextBrowse = True
        Me.txtSubModule.TextSource = ""
        Me.txtSubModule.ToUpper = False
        Me.txtSubModule.Unique = False
        Me.txtSubModule.Value = ""
        Me.txtSubModule.ValueSource = "at_sub_module_id"
        '
        'txtModule
        '
        Me.txtModule.AlwaysDisable = False
        Me.txtModule.AlwaysEnable = False
        Me.txtModule.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModule.BrowseDataSource = "GetATModule"
        Me.txtModule.BrowseField = "at_module_name"
        Me.txtModule.BrowseFilter = Me.txt_module_type
        Me.txtModule.BrowseLabel = "Name"
        Me.txtModule.BrowseLabelWidth = "300"
        Me.txtModule.BrowseTextSource = "at_module_name"
        Me.txtModule.BrowseValueSource = "at_module_id"
        Me.txtModule.Database = user_control.MyList.Database.FileSetup
        Me.txtModule.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtModule.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtModule.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtModule.Enabled = False
        Me.txtModule.EnabledBackColor = System.Drawing.Color.White
        Me.txtModule.EnabledForeColor = System.Drawing.Color.Black
        Me.txtModule.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtModule.ID = False
        Me.txtModule.Location = New System.Drawing.Point(29, 119)
        Me.txtModule.Name = "txtModule"
        Me.txtModule.NoClear = False
        Me.txtModule.NoSave = False
        Me.txtModule.NumberFormat = "@"
        Me.txtModule.Required = True
        Me.txtModule.RowData = Nothing
        Me.txtModule.Size = New System.Drawing.Size(150, 20)
        Me.txtModule.TabIndex = 94
        Me.txtModule.TextBrowse = True
        Me.txtModule.TextSource = ""
        Me.txtModule.ToUpper = False
        Me.txtModule.Unique = False
        Me.txtModule.Value = ""
        Me.txtModule.ValueSource = "at_module_id"
        '
        'txtType
        '
        Me.txtType.AlwaysDisable = False
        Me.txtType.AlwaysEnable = False
        Me.txtType.Controls.Add(Me.MyRadioButton4)
        Me.txtType.Controls.Add(Me.MyRadioButton3)
        Me.txtType.Controls.Add(Me.MyRadioButton2)
        Me.txtType.Controls.Add(Me.MyRadioButton1)
        Me.txtType.Location = New System.Drawing.Point(12, 66)
        Me.txtType.Name = "txtType"
        Me.txtType.NoSave = False
        Me.txtType.Required = False
        Me.txtType.Size = New System.Drawing.Size(301, 47)
        Me.txtType.TabIndex = 93
        Me.txtType.TabStop = False
        Me.txtType.Value = "1"
        Me.txtType.ValueSource = ""
        '
        'MyRadioButton4
        '
        Me.MyRadioButton4.AlwaysDisable = False
        Me.MyRadioButton4.AlwaysEnable = False
        Me.MyRadioButton4.AutoSize = True
        Me.MyRadioButton4.Enabled = False
        Me.MyRadioButton4.Location = New System.Drawing.Point(234, 19)
        Me.MyRadioButton4.Name = "MyRadioButton4"
        Me.MyRadioButton4.Size = New System.Drawing.Size(56, 17)
        Me.MyRadioButton4.TabIndex = 3
        Me.MyRadioButton4.Text = "Others"
        Me.MyRadioButton4.Uncheckable = False
        Me.MyRadioButton4.UseVisualStyleBackColor = True
        Me.MyRadioButton4.Value = "4"
        '
        'MyRadioButton3
        '
        Me.MyRadioButton3.AlwaysDisable = False
        Me.MyRadioButton3.AlwaysEnable = False
        Me.MyRadioButton3.AutoSize = True
        Me.MyRadioButton3.Enabled = False
        Me.MyRadioButton3.Location = New System.Drawing.Point(171, 19)
        Me.MyRadioButton3.Name = "MyRadioButton3"
        Me.MyRadioButton3.Size = New System.Drawing.Size(57, 17)
        Me.MyRadioButton3.TabIndex = 2
        Me.MyRadioButton3.Text = "Report"
        Me.MyRadioButton3.Uncheckable = False
        Me.MyRadioButton3.UseVisualStyleBackColor = True
        Me.MyRadioButton3.Value = "3"
        '
        'MyRadioButton2
        '
        Me.MyRadioButton2.AlwaysDisable = False
        Me.MyRadioButton2.AlwaysEnable = False
        Me.MyRadioButton2.AutoSize = True
        Me.MyRadioButton2.Location = New System.Drawing.Point(84, 19)
        Me.MyRadioButton2.Name = "MyRadioButton2"
        Me.MyRadioButton2.Size = New System.Drawing.Size(81, 17)
        Me.MyRadioButton2.TabIndex = 1
        Me.MyRadioButton2.Text = "Transaction"
        Me.MyRadioButton2.Uncheckable = False
        Me.MyRadioButton2.UseVisualStyleBackColor = True
        Me.MyRadioButton2.Value = "2"
        '
        'MyRadioButton1
        '
        Me.MyRadioButton1.AlwaysDisable = False
        Me.MyRadioButton1.AlwaysEnable = False
        Me.MyRadioButton1.AutoSize = True
        Me.MyRadioButton1.Checked = True
        Me.MyRadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.MyRadioButton1.Name = "MyRadioButton1"
        Me.MyRadioButton1.Size = New System.Drawing.Size(72, 17)
        Me.MyRadioButton1.TabIndex = 0
        Me.MyRadioButton1.TabStop = True
        Me.MyRadioButton1.Text = "File Setup"
        Me.MyRadioButton1.Uncheckable = False
        Me.MyRadioButton1.UseVisualStyleBackColor = True
        Me.MyRadioButton1.Value = "1"
        '
        'Myformheader1
        '
        Me.Myformheader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Myformheader1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Myformheader1.Location = New System.Drawing.Point(0, 0)
        Me.Myformheader1.Name = "Myformheader1"
        Me.Myformheader1.Size = New System.Drawing.Size(700, 28)
        Me.Myformheader1.TabIndex = 0
        '
        'txtFilterValue
        '
        Me.txtFilterValue.AlwaysDisable = False
        Me.txtFilterValue.AlwaysEnable = False
        Me.txtFilterValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilterValue.BrowseDataSource = ""
        Me.txtFilterValue.BrowseField = ""
        Me.txtFilterValue.BrowseFilter = Nothing
        Me.txtFilterValue.BrowseLabel = "Code,Name"
        Me.txtFilterValue.BrowseLabelWidth = "100,200"
        Me.txtFilterValue.BrowseTextSource = ""
        Me.txtFilterValue.BrowseValueSource = ""
        Me.txtFilterValue.Database = user_control.MyList.Database.FileSetup
        Me.txtFilterValue.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFilterValue.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFilterValue.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtFilterValue.Enabled = False
        Me.txtFilterValue.EnabledBackColor = System.Drawing.Color.White
        Me.txtFilterValue.EnabledForeColor = System.Drawing.Color.Black
        Me.txtFilterValue.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtFilterValue.ID = False
        Me.txtFilterValue.Location = New System.Drawing.Point(522, 66)
        Me.txtFilterValue.Name = "txtFilterValue"
        Me.txtFilterValue.NoClear = False
        Me.txtFilterValue.NoSave = False
        Me.txtFilterValue.NumberFormat = "@"
        Me.txtFilterValue.Required = False
        Me.txtFilterValue.RowData = Nothing
        Me.txtFilterValue.Size = New System.Drawing.Size(166, 20)
        Me.txtFilterValue.TabIndex = 105
        Me.txtFilterValue.TextBrowse = False
        Me.txtFilterValue.TextSource = ""
        Me.txtFilterValue.ToUpper = True
        Me.txtFilterValue.Unique = False
        Me.txtFilterValue.Value = ""
        Me.txtFilterValue.ValueSource = ""
        '
        'border1
        '
        Me.border1.BorderColor = System.Drawing.Color.DarkGray
        Me.border1.Location = New System.Drawing.Point(13, 61)
        Me.border1.Name = "border1"
        Me.border1.Size = New System.Drawing.Size(675, 2)
        Me.border1.TabIndex = 92
        Me.border1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(500, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Book"
        '
        'txtBook
        '
        Me.txtBook.AlwaysDisable = False
        Me.txtBook.AlwaysEnable = False
        Me.txtBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBook.BrowseDataSource = "lib_erp_book"
        Me.txtBook.BrowseField = "book_code,book_name"
        Me.txtBook.BrowseFilter = Nothing
        Me.txtBook.BrowseLabel = "Code,Name"
        Me.txtBook.BrowseLabelWidth = "100,200"
        Me.txtBook.BrowseTextSource = "book_name"
        Me.txtBook.BrowseValueSource = "book_id"
        Me.txtBook.Database = user_control.MyList.Database.FileSetup
        Me.txtBook.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBook.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBook.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txtBook.Enabled = False
        Me.txtBook.EnabledBackColor = System.Drawing.Color.White
        Me.txtBook.EnabledForeColor = System.Drawing.Color.Black
        Me.txtBook.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtBook.ID = False
        Me.txtBook.Location = New System.Drawing.Point(538, 119)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.NoClear = False
        Me.txtBook.NoSave = False
        Me.txtBook.NumberFormat = "@"
        Me.txtBook.Required = True
        Me.txtBook.RowData = Nothing
        Me.txtBook.Size = New System.Drawing.Size(150, 20)
        Me.txtBook.TabIndex = 107
        Me.txtBook.TextBrowse = True
        Me.txtBook.TextSource = "book_name"
        Me.txtBook.ToUpper = False
        Me.txtBook.Unique = False
        Me.txtBook.Value = ""
        Me.txtBook.ValueSource = "book_id"
        '
        'ATFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBook)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.txtFilterValue)
        Me.Controls.Add(Me.txt_module_type)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.txtSubModuleFilter)
        Me.Controls.Add(Me.txtSubModule)
        Me.Controls.Add(Me.txtModule)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.border1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Myformheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ATFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audit Trail"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txtType.ResumeLayout(False)
        Me.txtType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Myformheader1 As user_control.myformheader
    Friend WithEvents border1 As accounting.borderedlabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtType As user_control.MyRadioGroup
    Friend WithEvents MyRadioButton4 As user_control.MyRadioButton
    Friend WithEvents MyRadioButton3 As user_control.MyRadioButton
    Friend WithEvents MyRadioButton2 As user_control.MyRadioButton
    Friend WithEvents MyRadioButton1 As user_control.MyRadioButton
    Friend WithEvents txtModule As user_control.MyTextBox
    Friend WithEvents txtSubModule As user_control.MyTextBox
    Friend WithEvents txtSubModuleFilter As user_control.MyTextBox
    Friend WithEvents txtFilter As user_control.MyTextBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents btnView As user_control.MyButton
    Friend WithEvents btnPrint As user_control.MyButton
    Friend WithEvents btnExit As user_control.MyButton
    Friend WithEvents txt_module_type As user_control.MyTextBox
    Friend WithEvents txtFilterValue As user_control.MyTextBox
    Friend WithEvents dgMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBook As user_control.MyTextBox
End Class
