Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports user_control

Public Class usersignatories
#Region "Variable Declaration"
    Private strTableName As String = "sys_erp_user_signatory"
    Private boolLoadEnd As Boolean = False
    Private dicMyControl As New Dictionary(Of String, Control)
    Private dicButton As New Dictionary(Of String, Button)
    Private txtPK As MyTextBox = Nothing
    Public Property UserID As String = ""
#End Region
#Region "Functions and Sub"
    Private Sub CollectMyControl(ByVal myPanel As Control, ByRef dicOfControls As Dictionary(Of String, Control), ByRef dicOfButton As Dictionary(Of String, Button))
        For Each ctrl As Control In myPanel.Controls
            If TypeOf ctrl Is GroupBox Or TypeOf ctrl Is Panel Then
                CollectMyControl(ctrl, dicOfControls, dicOfButton)
            ElseIf TypeOf ctrl Is MyTextBox Then
                Dim ctr = CType(ctrl, MyTextBox)
                If dicOfControls.ContainsKey(ctr.Name) Then
                    dicOfControls.Item(ctr.Name) = ctr
                Else
                    dicOfControls.Add(ctr.Name, ctr)
                End If
                If ctr.ID Then
                    txtPK = ctr
                End If
            ElseIf TypeOf ctrl Is Button Then
                Dim ctr = CType(ctrl, Button)
                If dicOfButton.ContainsKey(ctr.Name) Then
                    dicOfButton.Item(ctr.Name) = ctr
                Else
                    dicOfButton.Add(ctr.Name, ctr)
                End If
            End If
        Next
    End Sub
    Private Sub EnableMyControl(ByVal dicOfControl As Dictionary(Of String, Control), ByVal dicOfButton As Dictionary(Of String, Button), Optional isEnable As Boolean = True)
        For Each ctrl In dicOfControl
            If TypeOf ctrl.Value Is MyTextBox Then
                Dim ctr = CType(ctrl.Value, MyTextBox)
                If isEnable Then
                    If Not ctr.AlwaysDisable Then
                        ctr.Enabled = isEnable
                    End If
                Else
                    If Not ctr.AlwaysEnable Then
                        ctr.Enabled = isEnable
                    End If
                End If
            End If
        Next
        For Each btn In dicOfButton
            Dim myButton = btn.Value
            Select Case btn.Key
                Case "btnSave", "btnNotSave"
                    myButton.Visible = isEnable
                Case "btnSaveAs", "btnUpdate"
                    myButton.Visible = Not isEnable
            End Select
        Next
        dgMain.Enabled = Not isEnable
    End Sub
    Private Sub ClearMyControl(ByVal dicOfControl As Dictionary(Of String, Control))
        For Each ctrl In dicOfControl
            If TypeOf ctrl.Value Is MyTextBox Then
                Dim ctr = CType(ctrl.Value, MyTextBox)
                If Not ctr.NoClear Then
                    ctr.Value = ""
                    ctr.Text = ""
                    If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                        ctr.DecimalValue = 0
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub BindMyControl(ByVal dr As DataRow, ByVal dicOfControl As Dictionary(Of String, Control))
        For Each ctrl In dicOfControl
            If TypeOf ctrl.Value Is MyTextBox Then
                Dim ctr = CType(ctrl.Value, MyTextBox)
                If ctr.ValueSource <> "" Then
                    If dr.Table.Columns.Contains(ctr.ValueSource) Then
                        ctr.Value = dr.Item(ctr.ValueSource).ToString
                        If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                            Dim tmp_value = dr.Item(ctr.ValueSource).ToString
                            ctr.DecimalValue = If(tmp_value = "", 0, tmp_value)
                        End If
                    End If
                End If
                If ctr.TextSource <> "" Then
                    If dr.Table.Columns.Contains(ctr.TextSource) Then
                        ctr.Text = dr.Item(ctr.TextSource).ToString
                        If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                            Dim tmp_value = dr.Item(ctr.TextSource).ToString
                            ctr.DecimalValue = If(tmp_value = "", 0, tmp_value)
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub InitLoad()
        If Not boolLoadEnd Then
            dgMain.AutoGenerateColumns = False
            Dim sql_module As String = String.Format("SELECT * FROM sys_erp_modules " & _
                "WHERE module_code IN ('ACC00101','ACC00201','ACC00301','ACC00401','ACC00501','ACC00601','ACC00701') ")
            Dim dt_module As DataTable = FsQuery(sql_module)
            ds.Tables("sys_erp_modules").Clear()
            For Each row As DataRow In dt_module.Rows
                ds.Tables("sys_erp_modules").ImportRow(row)
            Next
            Dim sql As String = String.Format("SELECT a.user_signatory_id,a.user_id,a.module_id " & _
                ",a.label1,a.user_id1,a.position1,a.label2,a.user_id2,a.position2 " & _
                ",a.label3,a.user_id3,a.position3,a.label4,a.user_id4,a.position4 " & _
                ",a.label5,a.user_id5,a.position5 " & _
                ",b.username,b.user_fullname " & _
                ",c.username AS username1,c.user_fullname AS user_fullname1 " & _
                ",d.username AS username2,d.user_fullname AS user_fullname2 " & _
                ",e.username AS username3,e.user_fullname AS user_fullname3 " & _
                ",f.username AS username4,f.user_fullname AS user_fullname4 " & _
                ",g.username AS username5,g.user_fullname AS user_fullname5 " & _
                ",h.module_code,h.module_name " & _
                "FROM sys_erp_user_signatory a " & _
                "LEFT JOIN sys_erp_user b ON b.user_id = a.user_id " & _
                "LEFT JOIN sys_erp_user c ON c.user_id = a.user_id1 " & _
                "LEFT JOIN sys_erp_user d ON d.user_id = a.user_id2 " & _
                "LEFT JOIN sys_erp_user e ON e.user_id = a.user_id3 " & _
                "LEFT JOIN sys_erp_user f ON f.user_id = a.user_id4 " & _
                "LEFT JOIN sys_erp_user g ON g.user_id = a.user_id5 " & _
                "LEFT JOIN sys_erp_modules h ON h.module_id = a.module_id " & _
                "")
            If UserID <> "" Then
                sql &= String.Format("WHERE a.user_id = '{0}' ", UserID)
            End If
            Dim dt As DataTable = FsQuery(sql)
            ds.Tables("sys_erp_user_signatory").Clear()
            For Each row As DataRow In dt.Rows
                ds.Tables("sys_erp_user_signatory").ImportRow(row)
            Next
            dgMain.DataSource = ds.Tables("sys_erp_modules")
            boolLoadEnd = True
        End If
    End Sub
    Private Function GenerateMyDictionary(ByVal ctrPK As MyTextBox, ByVal dicOfControl As Dictionary(Of String, Control)) As Dictionary(Of String, String)
        Dim dicReturn As New Dictionary(Of String, String)
        If ctrPK.ValueSource <> "" Then
            dicReturn.Add(ctrPK.ValueSource, ctrPK.Value)
        ElseIf ctrPK.TextSource <> "" Then
            dicReturn.Add(ctrPK.TextSource, ctrPK.Text)
        End If
        For Each ctrl In dicOfControl
            If TypeOf ctrl.Value Is MyTextBox Then
                Dim ctr = CType(ctrl.Value, MyTextBox)
                If ctr.ValueSource <> "" Then
                    If dicReturn.ContainsKey(ctr.ValueSource) Then
                        dicReturn.Item(ctr.ValueSource) = ctr.Value
                    Else
                        dicReturn.Add(ctr.ValueSource, ctr.Value)
                    End If
                    If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                        dicReturn.Item(ctr.ValueSource) = ctr.DecimalValue
                    End If
                ElseIf ctr.TextSource <> "" Then
                    If dicReturn.ContainsKey(ctr.TextSource) Then
                        dicReturn.Item(ctr.TextSource) = ctr.Text
                    Else
                        dicReturn.Add(ctr.TextSource, ctr.Text)
                    End If
                    If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                        dicReturn.Item(ctr.TextSource) = ctr.DecimalValue
                    End If
                End If
            End If
        Next
        Return dicReturn
    End Function
#End Region
#Region "Event Handler"
    Private Sub EventUpdate(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            Dim moduleID As String = selectedRow.Cells("module_id").Value.ToString
            EnableMyControl(dicMyControl, dicButton, True)
        End If
    End Sub
    Private Sub EventSaveAs(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            ModulesList.ShowDialog()
            If ModulesList.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim moduleID As String = ""
                EnableMyControl(dicMyControl, dicButton, True)
                txt_module_id.Text = ModulesList.ModuleID
                Dim drs = ds.Tables("sys_erp_user_signatory").Select(String.Format("module_id = '{0}'", ModulesList.ModuleID))
                If drs.Count > 0 Then
                    txtPK.Text = drs(0).Item("user_signatory_id").ToString
                Else
                    txtPK.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub EventSave(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dicSave = GenerateMyDictionary(txtPK, dicMyControl)
        Dim moduleID As String = ""
        If dicSave IsNot Nothing Then
            If dicSave.ContainsKey("module_id") Then
                moduleID = dicSave.Item("module_id")
            End If
        End If
        Dim sql As String = ""
        If txtPK.Text = "" Then
            'sql = genInsert(strTableName, dicSave)
            sql = ATGenerateQuery("Insert", strTableName, dicSave, Environment.MachineName, Environment.UserName, main.log_id, txt_user_signatory_id.Value, "user_signatory_id")
        Else
            sql = ATGenerateQuery("Update", strTableName, dicSave, Environment.MachineName, Environment.UserName, main.log_id, txt_user_signatory_id.Value, "user_signatory_id")
        End If
        If sql <> "" Then
            FsQuery(sql)
            MsgBox("Successfully Save")
            boolLoadEnd = False
            InitLoad()
            dgMain.ClearSelection()
            For Each row As DataGridViewRow In dgMain.Rows
                If row.Cells("module_id").Value.ToString = moduleID Then
                    row.Selected = True
                End If
            Next
            EnableMyControl(dicMyControl, dicButton, False)
        End If
    End Sub
    Private Sub EventNotSave(sender As Object, e As EventArgs) Handles btnNotSave.Click
        Dim selectedRows = dgMain.SelectedRows
        If selectedRows.Count > 0 Then
            ClearMyControl(dicMyControl)
            EnableMyControl(dicMyControl, dicButton, False)
            Dim selectedRow = selectedRows(0)
            dgMain.ClearSelection()
            dgMain.Rows(selectedRow.Index).Selected = True
        End If
    End Sub
    Private Sub SelectionBindMyControl(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        If boolLoadEnd Then
            Dim selectedRows = dgMain.SelectedRows
            If selectedRows.Count > 0 Then
                Dim selectedRow = selectedRows(0)
                Dim moduleId As String = selectedRow.Cells("module_id").Value.ToString
                If moduleId <> "" Then
                    Dim strCondition As String = String.Format("module_id = '{0}' ", moduleId)
                    If UserID <> "" Then
                        strCondition &= String.Format("AND user_id = '{0}' ", UserID)
                    End If
                    Dim drs = ds.Tables("sys_erp_user_signatory").Select(strCondition)
                    If drs.Count > 0 Then
                        BindMyControl(drs(0), dicMyControl)
                    Else
                        ClearMyControl(dicMyControl)
                        txt_user_id.Text = UserID
                        txt_module_id.Text = moduleId
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        InitLoad()
        CollectMyControl(Me, dicMyControl, dicButton)
        EnableMyControl(dicMyControl, dicButton, False)
    End Sub
#End Region

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnSaveAs)
        dicShortCut.Add(114, btnUpdate)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub
End Class