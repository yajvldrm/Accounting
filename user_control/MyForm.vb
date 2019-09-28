Imports System.Windows.Forms
Imports connectionlib.connectionlib

Public Class MyForm
#Region "Property"
    Private strSelect As String = ""
    Private strLeftJoin As String = ""
    Private currentSearchIndex As Integer = 0
    Private DGVSelName As String = ""
    Private PKName As String = ""
    Private DGVColumnName As String = ""
    Private IsInit As Boolean = False
    Private IsLoadEnd As Boolean = False
    Private ButtonInsert As Button = Nothing
    Private FormFilter As Object = Nothing
    Private MyDT As DataTable = Nothing
    Public Property okSave As Boolean = True
    Public Property MyDataBase As MyList.Database = MyList.Database.FileSetup
    Public Property MyTable As String = ""
    Public Property MyDGView As DataGridView = Nothing
    Public Property CustomQuery As String = ""
    Public Property ModuleCode As String = ""
    Public MyControls As New List(Of Control)
    Public MyChildren As New List(Of MyPanel)
    Public MyButtons As New List(Of MyButton)
    Public MyPK As MyTextBox = Nothing
    Public MySearch As MyTextBox = Nothing
    Public Property MyFilter As String = ""
    Public Property MyLogID As String = ""
#End Region
#Region "Sub / Function / Event"
    Public Sub InitialiseMyForm(Optional ControlContainer As Control = Nothing)
        If Not IsInit Then
            Dim CurrentContainer As Control = Nothing
            If ControlContainer Is Nothing Then
                CurrentContainer = Me
            Else
                CurrentContainer = ControlContainer
            End If
            Dim allControls = From txt In CurrentContainer.Controls()
                       Order By txt.TabIndex
            For Each ctrl As Control In allControls
                If TypeOf ctrl Is MyCheckBox Then
                    Dim ctr = CType(ctrl, MyCheckBox)
                    MyControls.Add(ctr)
                ElseIf TypeOf ctrl Is MyTextBox Then
                    Dim ctr = CType(ctrl, MyTextBox)
                    If MyFilter <> "" Then
                        If MyFilter = ctr.Name Then
                            ctr.Enabled = True
                            AddHandler ctr.ValueChange, AddressOf MyFilterValueChange
                            FormFilter = ctr
                        End If
                    End If
                    If ctr.ID Then
                        MyPK = ctr
                    End If
                    If ctr.Name = "txtsearch" Then
                        AddHandler ctr.TextChanged, AddressOf MySearchTextChange
                        AddHandler ctr.KeyDown, AddressOf MySearchKeyDown
                        ctr.AlwaysEnable = True
                        ctr.Enabled = True
                        MySearch = ctr
                    Else
                        If ctr.TextBrowse Then
                            Dim _db As String = ""
                            If ctr.Database = MyList.Database.FileSetup Then
                                _db = _serverDBFS
                            Else
                                _db = _serverDBMain
                            End If
                            If strSelect = "" Then
                                strSelect = String.Format("SELECT a.*,{0}.{1}.*" _
                                    , _db, ctr.BrowseDataSource)
                            Else
                                strSelect &= String.Format(",{0}.{1}.*" _
                                    , _db, ctr.BrowseDataSource)
                            End If
                            strLeftJoin &= vbNewLine & _
                                String.Format(" LEFT JOIN {0}.{1} ON {0}.{1}.{2} = a.{2}" _
                                    , _db, ctr.BrowseDataSource, ctr.BrowseValueSource)
                        End If
                        MyControls.Add(ctr)
                    End If
                ElseIf TypeOf ctrl Is MyRadioGroup Then
                    Dim ctr = CType(ctrl, MyRadioGroup)
                    MyControls.Add(ctr)
                ElseIf TypeOf ctrl Is myMaskedTextBox Then
                    Dim ctr = CType(ctrl, myMaskedTextBox)
                    MyControls.Add(ctr)
                ElseIf TypeOf ctrl Is myDatePicker Then
                    Dim ctr = CType(ctrl, myDatePicker)
                    MyControls.Add(ctr)
                ElseIf TypeOf ctrl Is DataGridView Then
                    Dim ctr = CType(ctrl, DataGridView)
                    AddHandler MyDGView.SelectionChanged, AddressOf DGVSelectionChange
                    MyDGView = ctr
                ElseIf TypeOf ctrl Is MyPanel Then
                    Dim ctr = CType(ctrl, MyPanel)
                    ctr.InitialiseMyForm(ctr)
                    ctr.DisableMyControl()
                    MyChildren.Add(ctr)
                ElseIf TypeOf ctrl Is Panel Then
                    Dim ctr = CType(ctrl, Panel)
                    InitialiseMyForm(ctr)
                ElseIf TypeOf ctrl Is GroupBox Then
                    Dim ctr = CType(ctrl, GroupBox)
                    InitialiseMyForm(ctr)
                ElseIf TypeOf ctrl Is MyButton Then
                    Dim ctr = CType(ctrl, MyButton)
                    Select Case ctr.ButtonType
                        Case MyList.ButtonType.ButtonAdd
                            AddHandler ctr.Click, AddressOf ButtonAddEvent
                            ButtonInsert = ctr
                        Case MyList.ButtonType.ButtonEdit
                            AddHandler ctr.Click, AddressOf ButtonEditEvent
                        Case MyList.ButtonType.ButtonDelete
                            AddHandler ctr.Click, AddressOf ButtonDeleteEvent
                        Case MyList.ButtonType.ButtonSave
                            AddHandler ctr.Click, AddressOf ButtonSaveEvent
                        Case MyList.ButtonType.ButtonNotSave
                            AddHandler ctr.Click, AddressOf ButtonNotSaveEvent
                    End Select
                    MyButtons.Add(ctr)
                End If
            Next
        End If
        IsInit = True
    End Sub
    Private Sub MyFilterValueChange(sender As Object, e As EventArgs)
        Dim MyFilterValue As String = ""
        If TypeOf sender Is MyTextBox Then
            Dim ctr = CType(sender, MyTextBox)
            MyFilterValue = ctr.Value
            Dim dicFilter As New Dictionary(Of String, String)
            dicFilter.Add(ctr.ValueSource, ctr.Value)
            LoadMyRecord(dicFilter)
            If MyDGView.Rows.Count = 0 Then
                ClearMyControl()
                For Each child In MyChildren
                    child.ClearMyData()
                    child.ClearMyControl()
                Next
            End If
        End If
    End Sub
    Private Sub ButtonAddEvent(sender As Object, e As EventArgs)
        EnableMyControl()
        ClearMyControl()
        MyPK.Text = "tmp_" & Now.ToString("yyyyMMddHHmmssfff")
        Dim nextControl = MyPK.FindForm.GetNextControl(MyPK, True)
        If nextControl IsNot Nothing Then
            nextControl.Focus()
        End If
    End Sub
    Private Sub ButtonEditEvent(sender As Object, e As EventArgs)
        If MyDGView.SelectedRows.Count > 0 Then
            EnableMyControl()
            Dim nextControl = Me.GetNextControl(MyPK, True)
            If nextControl IsNot Nothing Then
                nextControl.Focus()
            End If
        Else
            MsgBox("No Record Selected")
        End If
    End Sub
    Private Sub ButtonDeleteEvent(sender As Object, e As EventArgs)
        Dim selectedIDS = GetDGVSelectedRows()
        If selectedIDS.Count > 0 Then
            Dim res = MsgBox("Delete Record?", MsgBoxStyle.YesNo, "Delete")
            If res = MsgBoxResult.Yes Then
                Dim ids As String = ""
                For Each id In selectedIDS
                    ids &= id & "|"
                    'ids &= "," & id
                Next
                'Dim sql_delete = String.Format("DELETE FROM {0} WHERE {1} IN ({2})", MyTable, PKName, ids.Substring(1))
                Dim sql_delete = ATGenerateQuery("Remove", MyTable, Nothing, Environment.MachineName, Environment.UserName, MyLogID, ids, PKName)
                If MyDataBase = MyList.Database.FileSetup Then
                    Try
                        Dim dt As DataTable = FsQuery(sql_delete)
                    Catch ex As Exception
                        MsgBox("Record unable to delete. Already used in transaction.", MsgBoxStyle.Critical, "Record unable to Delete")
                    End Try
                Else
                    Try
                        Dim dt As DataTable = Query(sql_delete)
                    Catch ex As Exception
                        MsgBox("Record unable to delete. Already used in transaction.", MsgBoxStyle.Critical, "Record unable to Delete")
                    End Try
                End If
                If MyFilter IsNot Nothing And MyFilter.ToString <> "" Then
                    Dim _f = Me.Controls.Find(MyFilter, True)
                    If _f.Length > 0 Then
                        If TypeOf _f(0) Is MyTextBox Then
                            Dim _filter = CType(_f(0), MyTextBox)
                            MyFilterValueChange(_filter, Nothing)
                        End If
                    End If
                Else
                    LoadMyRecord()
                End If
                If MyDGView.Rows.Count > 0 Then
                    MyDGView.ClearSelection()
                    MyDGView.Rows(0).Selected = True
                Else
                    ClearMyControl()
                    If MyChildren.Count > 0 Then
                        For Each child In MyChildren
                            child.LoadMyRecord()
                        Next
                    End If
                End If
            End If
        Else
            MsgBox("No Record Selected.")
        End If
    End Sub
    Private Sub ButtonSaveEvent(sender As Object, e As EventArgs)
        If okSave Then
            Dim dicParent As New Dictionary(Of String, String)
            Dim dt As DataTable = MyDGView.DataSource
            Dim isExist As Boolean = False
            Dim isInsert As Boolean = False
            If MyPK.Text.ToLower.Contains("tmp_") Then
                isInsert = True
            End If
            dicParent.Add(PKName, MyPK.Text)
            For Each ctrl In MyControls
                If TypeOf ctrl Is MyTextBox Then
                    Dim ctr = CType(ctrl, MyTextBox)
                    If ctr.Required Then
                        If ctr.Text = "" And ctr.Value = "" Then
                            MsgBox("Required fields cannot be empty.")
                            Exit Sub
                        End If
                    End If
                    If Not ctr.NoSave Then
                        If ctr.ValueSource <> "" Then
                            If dicParent.ContainsKey(ctr.ValueSource) Then
                                dicParent.Item(ctr.ValueSource) = ctr.Value
                                If ctr.NumberFormat.Contains("#") Then
                                    dicParent.Item(ctr.ValueSource) = ctr.DecimalValue
                                End If
                            Else
                                dicParent.Add(ctr.ValueSource, ctr.Value)
                                If ctr.NumberFormat.Contains("#") Then
                                    dicParent.Item(ctr.ValueSource) = ctr.DecimalValue
                                End If
                            End If
                            If ctr.Unique Then
                                Dim existingRecord = dt.Select(String.Format("{0} = '{1}' AND {2} <> '{3}'", ctr.ValueSource, ctr.Value, MyPK.TextSource, MyPK.Text))
                                If isInsert Then
                                    existingRecord = dt.Select(String.Format("{0} = '{1}'", ctr.ValueSource, ctr.Value))
                                End If
                                If ctr.NumberFormat.Contains("#") Then
                                    existingRecord = dt.Select(String.Format("{0} = '{1}' AND {2} <> '{3}'", ctr.ValueSource, ctr.DecimalValue, MyPK.TextSource, MyPK.Text))
                                    If isInsert Then
                                        existingRecord = dt.Select(String.Format("{0} = '{1}'", ctr.ValueSource, ctr.DecimalValue))
                                    End If
                                End If
                                If existingRecord.Length > 0 Then
                                    isExist = True
                                End If
                            End If
                        ElseIf ctr.TextSource <> "" Then
                            If dicParent.ContainsKey(ctr.TextSource) Then
                                dicParent.Item(ctr.TextSource) = ctr.Text
                                If ctr.NumberFormat.Contains("#") Then
                                    dicParent.Item(ctr.TextSource) = ctr.DecimalValue
                                End If
                            Else
                                dicParent.Add(ctr.TextSource, ctr.Text)
                                If ctr.NumberFormat.Contains("#") Then
                                    dicParent.Item(ctr.TextSource) = ctr.DecimalValue
                                End If
                            End If
                            If ctr.Unique Then
                                Dim existingRecord = dt.Select(String.Format("{0} = '{1}' AND {2} <> '{3}'", ctr.TextSource, ctr.Text, MyPK.TextSource, MyPK.Text))
                                If isInsert Then
                                    existingRecord = dt.Select(String.Format("{0} = '{1}'", ctr.TextSource, ctr.Text))
                                End If
                                If ctr.NumberFormat.Contains("#") Then
                                    existingRecord = dt.Select(String.Format("{0} = '{1}' AND {2} <> '{3}'", ctr.TextSource, ctr.DecimalValue, MyPK.TextSource, MyPK.Text))
                                    If isInsert Then
                                        existingRecord = dt.Select(String.Format("{0} = '{1}'", ctr.TextSource, ctr.DecimalValue))
                                    End If
                                End If
                                If existingRecord.Length > 0 Then
                                    isExist = True
                                End If
                            End If
                        End If
                    End If
                ElseIf TypeOf ctrl Is MyCheckBox Then
                    Dim ctr = CType(ctrl, MyCheckBox)
                    If dicParent.ContainsKey(ctr.ValueSource) Then
                        dicParent.Item(ctr.ValueSource) = If(ctr.Checked, "1", "0")
                    Else
                        dicParent.Add(ctr.ValueSource, If(ctr.Checked, "1", "0"))
                    End If
                ElseIf TypeOf ctrl Is MyRadioGroup Then
                    Dim ctr = CType(ctrl, MyRadioGroup)
                    If ctr.Required Then
                        If ctr.Value = "" Then
                            MsgBox("Required field cannot be empty.")
                            Exit Sub
                        End If
                    End If
                    If dicParent.ContainsKey(ctr.ValueSource) Then
                        dicParent.Item(ctr.ValueSource) = ctr.Value
                    Else
                        dicParent.Add(ctr.ValueSource, ctr.Value)
                    End If
                ElseIf TypeOf ctrl Is myDatePicker Then
                    Dim ctr = CType(ctrl, myDatePicker)
                    If ctr.Required Then
                        'If ctr.Value = "" Then
                        '    MsgBox("Required field cannot be empty.")
                        '    Exit Sub
                        'End If
                    End If
                    If Not ctr.NoSave Then
                        If ctr.TextSource <> "" Then
                            If dicParent.ContainsKey(ctr.TextSource) Then
                                dicParent.Item(ctr.TextSource) = ctr.Value.ToString("yyyy-MM-dd")
                            Else
                                dicParent.Add(ctr.TextSource, ctr.Value.ToString("yyyy-MM-dd"))
                            End If
                        End If
                    End If
                ElseIf TypeOf ctrl Is myMaskedTextBox Then
                    Dim ctr = CType(ctrl, myMaskedTextBox)
                    If ctr.Required Then
                        If ctr.Text = "" And ctr.Value = "" Then
                            MsgBox("Required field cannot be empty.")
                            Exit Sub
                        End If
                    End If
                    If Not ctr.NoSave Then
                        If ctr.ValueSource <> "" Then
                            If dicParent.ContainsKey(ctr.ValueSource) Then
                                dicParent.Item(ctr.ValueSource) = ctr.Value
                            Else
                                dicParent.Add(ctr.ValueSource, ctr.Value)
                            End If
                            If ctr.Unique Then
                                Dim existingRecord = dt.Select(String.Format("{0} = '{1}' AND {2} <> '{3}'", ctr.ValueSource, ctr.Value, MyPK.TextSource, MyPK.Text))
                                If isInsert Then
                                    existingRecord = dt.Select(String.Format("{0} = '{1}'", ctr.ValueSource, ctr.Value))
                                End If
                                If existingRecord.Length > 0 Then
                                    isExist = True
                                End If
                            End If
                        ElseIf ctr.TextSource <> "" Then
                            If dicParent.ContainsKey(ctr.TextSource) Then
                                dicParent.Item(ctr.TextSource) = ctr.Text
                            Else
                                dicParent.Add(ctr.TextSource, ctr.Text)
                            End If
                            If ctr.Unique Then
                                Dim existingRecord = dt.Select(String.Format("{0} = '{1}' AND {2} <> '{3}'", ctr.TextSource, ctr.Text, MyPK.TextSource, MyPK.Text))
                                If isInsert Then
                                    existingRecord = dt.Select(String.Format("{0} = '{1}'", ctr.TextSource, ctr.Text))
                                End If
                                If existingRecord.Length > 0 Then
                                    isExist = True
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            If isExist Then
                MsgBox("Record Already Exist.")
                Exit Sub
            End If
            Dim sql As String = ""
            If isInsert Then
                'sql = genInsert(MyTable, dicParent) & ";SELECT LAST_INSERT_ID() AS id;"
                sql = ATGenerateQuery("Insert", MyTable, dicParent, Environment.MachineName, Environment.UserName, MyLogID)
            Else
                'sql = genUpdate(MyTable, dicParent)
                sql = ATGenerateQuery("Update", MyTable, dicParent, Environment.MachineName, Environment.UserName, MyLogID)
            End If
            Dim rundt As New DataTable
            Dim selectedID As String = MyPK.Text
            If sql <> "" Then
                If MyDataBase = MyList.Database.FileSetup Then
                    rundt = FsQuery(sql)
                Else
                    rundt = Query(sql)
                End If
                If isInsert Then
                    If rundt.Rows.Count > 0 Then
                        selectedID = rundt.Rows(0).Item("return_id").ToString
                    End If
                End If
                If MyChildren.Count > 0 Then
                    For Each child In MyChildren
                        child.SaveMe(PKName, selectedID)
                    Next
                End If
                If MyFilter IsNot Nothing And MyFilter.ToString <> "" Then
                    Dim _f = Me.Controls.Find(MyFilter, True)
                    If _f.Length > 0 Then
                        If TypeOf _f(0) Is MyTextBox Then
                            Dim _filter = CType(_f(0), MyTextBox)
                            MyFilterValueChange(_filter, Nothing)
                        End If
                    End If
                Else
                    LoadMyRecord()
                End If
                If MyDGView.Rows.Count > 0 Then
                    Dim currentDT As DataTable = MyDGView.DataSource
                    Dim selectedRows = currentDT.Select(String.Format("{0} = '{1}'", PKName, selectedID))
                    If selectedRows.Length > 0 Then
                        Dim selectedRow = selectedRows(0)
                        Dim rowIndex = currentDT.Rows.IndexOf(selectedRow)
                        MyDGView.ClearSelection()
                        MyDGView.Rows(rowIndex).Selected = True
                    End If
                End If
                EnableMyControl(False)
                If isInsert Then
                    Dim toInsert = MsgBox("Successfully Saved." & "Add Another Record?", MsgBoxStyle.YesNo, "Confirmation")
                    If toInsert = MsgBoxResult.Yes Then
                        ButtonInsert.PerformClick()
                    End If
                Else
                    MsgBox("Successfully Saved.")
                End If
            End If
        End If
    End Sub
    Private Sub ButtonNotSaveEvent(sender As Object, e As EventArgs)
        EnableMyControl(False)
        If MyDGView.SelectedRows.Count > 0 Then
            Dim selectedRow = MyDGView.SelectedRows(0)
            MyDGView.ClearSelection()
            MyDGView.Rows(selectedRow.Index).Selected = True
        Else
            ClearMyControl()
        End If
    End Sub
    Private Sub MySearchTextChange(sender As Control, e As EventArgs)
        Dim q As String = MySearch.Text
        If MySearch.TextSource <> "" Then
            Dim cols = MySearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" OR {0} LIKE '%{1}%'", col, q)
            Next
            Dim selectedRows = MyDT.Select(selectQuery.Substring(4))
            If selectedRows.Length > 0 Then
                Dim newDt = MyDT.Clone
                newDt.Clear()
                For Each row As DataRow In selectedRows
                    newDt.ImportRow(row)
                Next
                MyDGView.DataSource = newDt
                'If currentSearchIndex >= selectedRows.Length Then
                '    currentSearchIndex = 0
                'End If
                'Dim selectedID As String = selectedRows(currentSearchIndex).Item(PKName).ToString
                'MyDGView.ClearSelection()
                'For Each row As DataGridViewRow In MyDGView.Rows
                '    If row.Cells(DGVColumnName).Value.ToString = selectedID Then
                '        row.Selected = True
                '        Dim tmp_index = dt.Rows.IndexOf(selectedRows(currentSearchIndex))
                '        MyDGView.FirstDisplayedScrollingRowIndex = tmp_index
                '    End If
                'Next
            Else
                MyDGView.DataSource = MyDT
            End If
        Else
            MyDGView.DataSource = MyDT
        End If
    End Sub
    Private Sub MySearchKeyDown(sender As Object, e As Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter And e.Control Then
        '    currentSearchIndex += 1
        '    MySearchTextChange(Nothing, Nothing)
        '    e.SuppressKeyPress = True
        'End If
    End Sub
    Private Sub DGVSelectionChange(sender As Control, e As EventArgs)
        If IsLoadEnd Then
            If MyDGView.Rows.Count > 0 Then
                If MyDGView.SelectedRows.Count > 0 Then
                    If MyDGView.DataSource IsNot Nothing Then
                        If TypeOf MyDGView.DataSource Is DataTable Then
                            Dim DGVDataTable As DataTable = MyDGView.DataSource
                            If DGVDataTable.Rows.Count > 0 Then
                                Dim CurrentPKValue As String = MyDGView.SelectedRows(0).Cells(DGVColumnName).Value.ToString
                                Dim SelectedRowRecords = DGVDataTable.Select(String.Format("{0} = '{1}'", PKName, CurrentPKValue))
                                If SelectedRowRecords.Length > 0 Then
                                    BindMyControl(SelectedRowRecords(0))
                                    If MyChildren.Count > 0 Then
                                        For Each child In MyChildren
                                            child.LoadMyRecord()
                                            child.DisableMyControl()
                                        Next
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub BindMyControl(ByVal dr As DataRow)
        Try
            For Each ctrl In MyControls
                If TypeOf ctrl Is MyTextBox Then
                    Dim ctr = CType(ctrl, MyTextBox)
                    If ctr.ValueSource <> "" Then
                        If dr.Table.Columns.Contains(ctr.ValueSource) Then
                            ctr.Value = dr.Item(ctr.ValueSource).ToString
                        End If
                        If ctr.NumberFormat.Contains("#") Then
                            ctr.DecimalValue = dr.Item(ctr.ValueSource).ToString
                        End If
                    End If
                    If ctr.TextSource <> "" Then
                        If dr.Table.Columns.Contains(ctr.TextSource) Then
                            ctr.Text = dr.Item(ctr.TextSource).ToString
                        End If
                        If ctr.NumberFormat.Contains("#") Then
                            ctr.DecimalValue = dr.Item(ctr.TextSource).ToString
                        End If
                    End If
                ElseIf TypeOf ctrl Is MyCheckBox Then
                    Dim ctr = CType(ctrl, MyCheckBox)
                    If dr.Table.Columns.Contains(ctr.ValueSource) Then
                        ctr.Checked = dr.Item(ctr.ValueSource).ToString
                    End If
                ElseIf TypeOf ctrl Is MyRadioGroup Then
                    Dim ctr = CType(ctrl, MyRadioGroup)
                    If dr.Table.Columns.Contains(ctr.ValueSource) Then
                        ctr.Value = dr.Item(ctr.ValueSource).ToString
                    End If
                ElseIf TypeOf ctrl Is myDatePicker Then
                    Dim ctr = CType(ctrl, myDatePicker)
                    If dr.Table.Columns.Contains(ctr.TextSource) Then
                        Dim val = CType(dr.Item(ctr.TextSource), DateTime)
                        ctr.Value = val
                    End If
                ElseIf TypeOf ctrl Is myMaskedTextBox Then
                    Dim ctr = CType(ctrl, myMaskedTextBox)
                    If ctr.ValueSource <> "" Then
                        If dr.Table.Columns.Contains(ctr.ValueSource) Then
                            ctr.Value = dr.Item(ctr.ValueSource).ToString
                        End If
                    End If
                    If ctr.TextSource <> "" Then
                        If dr.Table.Columns.Contains(ctr.TextSource) Then
                            ctr.Text = dr.Item(ctr.TextSource).ToString
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetDGVColumnName()
        For Each col As DataGridViewColumn In MyDGView.Columns
            If col.DataPropertyName = MyPK.TextSource Then
                PKName = MyPK.TextSource
                DGVColumnName = col.Name
            End If
            If col.DataPropertyName = "sel" Then
                DGVSelName = col.Name
            End If
        Next
    End Sub
    Friend Sub EnableMyControl(Optional ToEnable As Boolean = True)
        For Each ctrl In MyControls
            If TypeOf ctrl Is MyCheckBox Then
                Dim ctr = CType(ctrl, MyCheckBox)
                If ToEnable Then
                    If Not ctr.AlwaysDisable Then
                        ctr.Enabled = ToEnable
                    End If
                Else
                    If Not ctr.AlwaysEnable Then
                        ctr.Enabled = ToEnable
                    End If
                End If
            ElseIf TypeOf ctrl Is MyTextBox Then
                Dim ctr = CType(ctrl, MyTextBox)
                If ToEnable Then
                    If Not ctr.AlwaysDisable Then
                        ctr.Enabled = ToEnable
                    End If
                Else
                    If Not ctr.AlwaysEnable Then
                        ctr.Enabled = ToEnable
                    End If
                End If
            ElseIf TypeOf ctrl Is MyRadioGroup Then
                Dim ctr = CType(ctrl, MyRadioGroup)
                If ToEnable Then
                    If Not ctr.AlwaysDisable Then
                        ctrl.Enabled = ToEnable
                    End If
                Else
                    If Not ctr.AlwaysEnable Then
                        ctrl.Enabled = ToEnable
                    End If
                End If
            ElseIf TypeOf ctrl Is myMaskedTextBox Then
                Dim ctr = CType(ctrl, myMaskedTextBox)
                If ToEnable Then
                    If Not ctr.AlwaysDisable Then
                        ctr.Enabled = ToEnable
                    End If
                Else
                    If Not ctr.AlwaysEnable Then
                        ctr.Enabled = ToEnable
                    End If
                End If
            ElseIf TypeOf ctrl Is myDatePicker Then
                Dim ctr = CType(ctrl, myDatePicker)
                If ToEnable Then
                    If Not ctr.AlwaysDisable Then
                        ctr.Enabled = ToEnable
                    End If
                Else
                    If Not ctr.AlwaysEnable Then
                        ctr.Enabled = ToEnable
                    End If
                End If
            End If
        Next
        For Each btn As MyButton In MyButtons
            If btn.ButtonType = MyList.ButtonType.ButtonAdd _
                Or btn.ButtonType = MyList.ButtonType.ButtonEdit _
                Or btn.ButtonType = MyList.ButtonType.ButtonDelete _
                Or btn.ButtonType = MyList.ButtonType.ButtonInsert _
                Or btn.ButtonType = MyList.ButtonType.ButtonUpdate _
                Or btn.ButtonType = MyList.ButtonType.ButtonRemove Then
                btn.Visible = Not ToEnable
            Else
                btn.Visible = ToEnable
            End If
        Next
        For Each child In MyChildren
            child.MyLogID = MyLogID
            If ToEnable Then
                child.EnableMyControl(False)
            Else
                child.DisableMyControl()
            End If
        Next
        MyDGView.Enabled = Not ToEnable
    End Sub
    Friend Sub ClearMyControl()
        For Each ctrl In MyControls
            If TypeOf ctrl Is MyTextBox Then
                Dim ctr = CType(ctrl, MyTextBox)
                If Not ctr.NoClear Then
                    ctr.Text = ""
                    If ctr.ValueSource <> "" Then
                        ctr.Value = ""
                    End If
                    If ctr.NumberFormat.Contains("#") Then
                        ctr.DecimalValue = 0
                    End If
                End If
            ElseIf TypeOf ctrl Is MyCheckBox Then
                Dim ctr = CType(ctrl, MyCheckBox)
                If ctr.isChecked Then
                    ctr.Checked = True
                Else
                    ctr.Checked = False
                End If
            ElseIf TypeOf ctrl Is MyRadioGroup Then
                Dim ctr = CType(ctrl, MyRadioGroup)
                For Each rdo_btn In ctr.Controls
                    If TypeOf rdo_btn Is MyRadioButton Then
                        Dim MyRdoBtn = CType(rdo_btn, MyRadioButton)
                        If MyRdoBtn.Uncheckable Then
                            MyRdoBtn.Checked = True
                            MyRdoBtn.Checked = False
                            Exit For
                        End If
                        MyRdoBtn.Checked = False
                    End If
                Next
            ElseIf TypeOf ctrl Is myMaskedTextBox Then
                Dim ctr = CType(ctrl, myMaskedTextBox)
                If Not ctr.NoClear Then
                    ctr.Text = ""
                    If ctr.ValueSource <> "" Then
                        ctr.Value = ""
                    End If
                End If
            ElseIf TypeOf ctrl Is myDatePicker Then
                Dim ctr = CType(ctrl, myDatePicker)
                If Not ctr.NoClear Then
                    ctr.Value = Today.Date
                End If
            End If
        Next
        For Each child In MyChildren
            child.ClearMyData()
        Next
    End Sub
    Friend Sub LoadMyRecord(Optional MyDicFilter As Dictionary(Of String, String) = Nothing)
        MyDGView.Enabled = False
        Dim sql As String = String.Format("SELECT a.* FROM {0} a", MyTable)
        If strSelect <> "" Then
            sql = strSelect & " FROM " & MyTable & " a " & strLeftJoin
        End If
        If CustomQuery <> "" Then
            sql = Functions.getCustomQuery(CustomQuery, Me)
        End If
        If MyDicFilter IsNot Nothing Then
            If FormFilter IsNot Nothing Then
                If TypeOf FormFilter Is MyTextBox Then
                    Dim ctr = CType(FormFilter, MyTextBox)
                    sql &= String.Format(" WHERE a.{0} = '{1}'", ctr.ValueSource, MyDicFilter.Item(ctr.ValueSource))
                End If
            End If
        End If
        Dim dt As DataTable = Nothing
        If MyDataBase = MyList.Database.FileSetup Then
            dt = FsQuery(sql)
        Else
            dt = Query(sql)
        End If
        MyDT = dt.Clone
        MyDT.Clear()
        For Each dr As DataRow In dt.Rows
            MyDT.ImportRow(dr)
        Next
        MyDGView.AutoGenerateColumns = False
        Dim ds = MyDGView.DataSource
        If TypeOf ds Is DataSet Then
            If ds.Tables.Contains(MyTable) Then
                ds.Tables(MyTable).Rows.Clear()
                For Each row As DataRow In dt.Rows
                    ds.Tables(MyTable).ImportRow(row)
                Next
                MyDGView.DataSource = ds.Tables(MyTable)
                MyDGView.DataSource.AcceptChanges()
            End If
        Else
            ds.Clear()
            For Each row As DataRow In dt.Rows
                'If ds.Select(String.Format("{0} = '{1}'", PKName, row.Item(PKName))).Length = 0 Then
                ds.ImportRow(row)
                'End If
            Next
            MyDGView.DataSource = ds
            MyDGView.DataSource.AcceptChanges()
        End If
        MyDGView.Enabled = True
        IsLoadEnd = True
    End Sub
    Private Function GetDGVSelectedRows() As List(Of String)
        Dim listIDS As New List(Of String)
        For Each row As DataGridViewRow In MyDGView.Rows
            If row.Cells(DGVSelName).Value Then
                listIDS.Add(row.Cells(DGVColumnName).Value.ToString)
            End If
        Next
        Return listIDS
    End Function
    Friend Sub DisableMyControl()
        For Each ctrl In MyControls
            If TypeOf ctrl Is MyCheckBox Then
                Dim ctr = CType(ctrl, MyCheckBox)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            ElseIf TypeOf ctrl Is MyTextBox Then
                Dim ctr = CType(ctrl, MyTextBox)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            ElseIf TypeOf ctrl Is MyRadioGroup Then
                Dim ctr = CType(ctrl, MyRadioGroup)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            ElseIf TypeOf ctrl Is myMaskedTextBox Then
                Dim ctr = CType(ctrl, myMaskedTextBox)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            ElseIf TypeOf ctrl Is myDatePicker Then
                Dim ctr = CType(ctrl, myDatePicker)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            End If
        Next
        For Each btn As MyButton In MyButtons
            If btn.ButtonType = MyList.ButtonType.ButtonAdd _
                Or btn.ButtonType = MyList.ButtonType.ButtonEdit _
                Or btn.ButtonType = MyList.ButtonType.ButtonDelete _
                Or btn.ButtonType = MyList.ButtonType.ButtonInsert _
                Or btn.ButtonType = MyList.ButtonType.ButtonUpdate _
                Or btn.ButtonType = MyList.ButtonType.ButtonRemove Then
                btn.Visible = False
            Else
                btn.Visible = False
            End If
        Next
        MyDGView.Enabled = True
    End Sub
    Friend Sub HideMyButtons(Optional ToHide As Boolean = True)
        For Each btn As MyButton In MyButtons
            If ToHide Then
                btn.Visible = False
            Else
                If btn.ButtonType = MyList.ButtonType.ButtonSave _
                    Or btn.ButtonType = MyList.ButtonType.ButtonNotSave _
                    Or btn.ButtonType = MyList.ButtonType.ButtonOK _
                    Or btn.ButtonType = MyList.ButtonType.ButtonCancel Then
                    btn.Visible = True
                Else
                    btn.Visible = False
                End If
            End If
        Next
    End Sub
#End Region
#Region "Own Event"
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Application.EnableVisualStyles()
        If sender.Name <> "MyForm" Then
            If IsInit Then
                LoadMyRecord()
                EnableMyControl(False)
                GetDGVColumnName()
                'IsLoadEnd = True
                If MyDGView.Rows.Count > 0 Then
                    MyDGView.ClearSelection()
                    MyDGView.Rows(0).Selected = True
                Else
                    ClearMyControl()
                End If
            End If
        End If
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, MyButton)
        For Each btn As MyButton In MyButtons
            Dim KeyCode As Integer = 0
            Select Case btn.ButtonType
                Case MyList.ButtonType.ButtonAdd
                    KeyCode = 113
                Case MyList.ButtonType.ButtonEdit
                    KeyCode = 114
                Case MyList.ButtonType.ButtonDelete
                    KeyCode = 115
            End Select
            If KeyCode > 0 Then
                If dicShortCut.ContainsKey(KeyCode) Then
                    dicShortCut.Item(KeyCode) = btn
                Else
                    dicShortCut.Add(KeyCode, btn)
                End If
            End If
        Next
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub
    Private Sub MeClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each btn As MyButton In MyButtons
            If btn.ButtonType = MyList.ButtonType.ButtonEdit Then
                If Not btn.Visible Then
                    Dim res = MsgBox("Are you sure to close the form without saving?", MsgBoxStyle.YesNo, "Close Form")
                    If res = MsgBoxResult.No Then
                        e.Cancel = True
                    End If
                End If
            End If
        Next
    End Sub
#End Region
End Class