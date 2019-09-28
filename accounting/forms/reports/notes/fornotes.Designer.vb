<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fornotes
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
        Me.txt_notes = New user_control.MyTextBox()
        Me.btn_cancel = New user_control.MyButton()
        Me.btn_save = New user_control.MyButton()
        Me.SuspendLayout()
        '
        'txt_notes
        '
        Me.txt_notes.AlwaysDisable = False
        Me.txt_notes.AlwaysEnable = False
        Me.txt_notes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_notes.BrowseDataSource = ""
        Me.txt_notes.BrowseField = ""
        Me.txt_notes.BrowseFilter = Nothing
        Me.txt_notes.BrowseLabel = "Code,Name"
        Me.txt_notes.BrowseLabelWidth = "100,200"
        Me.txt_notes.BrowseTextSource = ""
        Me.txt_notes.BrowseValueSource = ""
        Me.txt_notes.Database = user_control.MyList.Database.FileSetup
        Me.txt_notes.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_notes.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_notes.DisabledForeColor = System.Drawing.Color.DarkBlue
        Me.txt_notes.Enabled = False
        Me.txt_notes.EnabledBackColor = System.Drawing.Color.White
        Me.txt_notes.EnabledForeColor = System.Drawing.Color.Black
        Me.txt_notes.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_notes.ID = False
        Me.txt_notes.Location = New System.Drawing.Point(12, 12)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.NoClear = False
        Me.txt_notes.NoSave = False
        Me.txt_notes.NumberFormat = "@"
        Me.txt_notes.Required = False
        Me.txt_notes.RowData = Nothing
        Me.txt_notes.Size = New System.Drawing.Size(396, 266)
        Me.txt_notes.TabIndex = 1
        Me.txt_notes.TextBrowse = False
        Me.txt_notes.TextSource = ""
        Me.txt_notes.ToUpper = True
        Me.txt_notes.Unique = False
        Me.txt_notes.Value = ""
        Me.txt_notes.ValueSource = ""
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Maroon
        Me.btn_cancel.ButtonType = user_control.MyList.ButtonType.ButtonNotSave
        Me.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(213, 284)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(80, 24)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Green
        Me.btn_save.ButtonType = user_control.MyList.ButtonType.ButtonSave
        Me.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(127, 284)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 24)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'fornotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 320)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_notes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fornotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fornotes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_notes As user_control.MyTextBox
    Friend WithEvents btn_cancel As user_control.MyButton
    Friend WithEvents btn_save As user_control.MyButton
End Class
