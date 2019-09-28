<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class headerSpreadSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(headerSpreadSheet))
        Me.excel_viewer = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.SuspendLayout()
        '
        'excel_viewer
        '
        Me.excel_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.excel_viewer.Location = New System.Drawing.Point(0, 0)
        Me.excel_viewer.Name = "excel_viewer"
        Me.excel_viewer.Options.Import.Csv.Encoding = CType(resources.GetObject("SpreadsheetControl1.Options.Import.Csv.Encoding"), System.Text.Encoding)
        Me.excel_viewer.Options.Import.Txt.Encoding = CType(resources.GetObject("SpreadsheetControl1.Options.Import.Txt.Encoding"), System.Text.Encoding)
        Me.excel_viewer.Size = New System.Drawing.Size(800, 450)
        Me.excel_viewer.TabIndex = 0
        Me.excel_viewer.Text = "SpreadsheetControl1"
        '
        'headerSpreadSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.excel_viewer)
        Me.MinimizeBox = False
        Me.Name = "headerSpreadSheet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Particulars"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents excel_viewer As DevExpress.XtraSpreadsheet.SpreadsheetControl
End Class
