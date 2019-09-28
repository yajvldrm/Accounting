Imports System.Windows.Forms
Imports connectionlib.connectionlib

Public Class MyPanel
#Region "Property"
    Private strSelect As String = ""
    Private strLeftJoin As String = ""
    Private currentSearchIndex As Integer = 0
    Private DGVSelName As String = ""
    Private DGVDelName As String = ""
    Private PKName As String = ""
    Private DGVColumnName As String = ""
    Private IsInit As Boolean = False
    Private IsLoadEnd As Boolean = False
    Private ButtonInsert As Button = Nothing
    Private TransMode As String = ""
    Private MyParent As Control = Nothing
    Public Property MYFK As String = ""
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
    Private MyForeignKey As MyTextBox = Nothing
    Public Property MyLogID As String = ""
#End Region
#Region "Sub / Function / Event"
    Public Sub InitialiseMyForm(Optional ControlContainer As Control = Nothing)
        Dim CurrentContainer As Control = Nothing
        If ControlContainer Is Nothing Then
            CurrentContainer = Me
        Else
            CurrentContainer = ControlContainer
        End If
        For Each ctrl As Control In CurrentContainer.Controls
            If TypeOf ctrl Is MyCheckBox Then
                Dim ctr = CType(ctrl, MyCheckBox)
                MyControls.Add(ctr)
            ElseIf TypeOf ctrl Is MyTextBox Then
                Dim ctr = CType(ctrl, MyTextBox)
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
                            strSelect = String.Format("SELECT a.*,{0}.{1}.{2},{0}.{1}.{3}" _
                                , _db, ctr.BrowseDataSource, ctr.BrowseValueSource, ctr.BrowseTextSource)
                        Else
                            strSelect &= String.Format(",{0}.{1}.{2},{0}.{1}.{3}" _
                                , _db, ctr.BrowseDataSource, ctr.BrowseValueSource, ctr.BrowseTextSource)
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
            ElseIf TypeOf ctrl Is DataGridView Then
                Dim ctr = CType(ctrl, DataGridView)
                AddHandler MyDGView.SelectionChanged, AddressOf DGVSelectionChange
                MyDGView = ctr
                GetDGVColumnName()
            ElseIf TypeOf ctrl Is MyPanel Then
                Dim ctr = CType(ctrl, MyPanel)
                ctr.InitialiseMyForm(ctr)
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
                    Case MyList.ButtonType.ButtonInsert
                        AddHandler ctr.Click, AddressOf ButtonAddEvent
                        ButtonInsert = ctr
                    Case MyList.ButtonType.ButtonUpdate
                        AddHandler ctr.Click, AddressOf ButtonEditEvent
                    Case MyList.ButtonType.ButtonRemove
                        AddHandler ctr.Click, AddressOf ButtonDeleteEvent
                    Case MyList.ButtonType.ButtonOK
                        AddHandler ctr.Click, AddressOf ButtonSaveEvent
                    Case MyList.ButtonType.ButtonCancel
                        AddHandler ctr.Click, AddressOf ButtonNotSaveEvent
                End Select
                MyButtons.Add(ctr)
            End If
        Next
        GetMyParent(Me)
        Dim tmp = MyParent.Controls.Find(MYFK, True)
        If tmp.Length > 0 Then
            MyForeignKey = CType(tmp(0), MyTextBox)
        End If
        IsInit = True
    End Sub
    Private Sub ButtonAddEvent(sender As Object, e As EventArgs)
        EnableMyControl()
        ClearMyControl()
        MyPK.Text = "tmp_" & Now.ToString("yyyyMMddHHmmssfff")
        TransMode = "insert"
        Dim nextControl = Me.GetNextControl(MyPK, True)
        If nextControl IsNot Nothing Then
            nextControl.Focus()
        End If
    End Sub
    Private Sub ButtonEditEvent(sender As Object, e As EventArgs)
        If MyDGView.SelectedRows.Count > 0 Then
            TransMode = "update"
            EnableMyControl()
            Dim nextControl = Me.GetNextControl(MyPK, True)
            If nextControl IsNot Nothing Then
                nextControl.Focus()
            End If
        Else
            MsgBox("No Record Selected.")
        End If
    End Sub
    Private Sub ButtonDeleteEvent(sender As Object, e As EventArgs)
        Dim selectedIDS = GetDGVSelectedRows()
        If selectedIDS.Count > 0 Then
            Dim ids As String = ""
            For Each id In selectedIDS
                ids &= String.Format(",'{0}'", id)
            Next
            Dim atQuery = ATGenerateQuery("Remove", MyTable, Nothing, Environment.MachineName, Environment.UserName, MyLogID, ids.Substring(1), MyPK.TextSource)
            Console.WriteLine(atQuery)
            Dim dt As DataTable = MyDGView.DataSource
            Dim selectedRows = dt.Select(String.Format("{0} IN ({1})", PKName, ids.Substring(1)))
            For Each row As DataRow In selectedRows
                row.Item("deleted") = True
                dt.AcceptChanges()
            Next
            InitDataOfMyDGV()
            If MyDGView.Rows.Count > 0 Then
                MyDGView.ClearSelection()
                MyDGView.Rows(0).Selected = True
            Else
                ClearMyControl()
            End If
        Else
            MsgBox("No Record Selected.")
        End If
    End Sub
    Private Sub ButtonSaveEvent(sender As Object, e As EventArgs)
        Dim dt = MyDGView.DataSource
        If TypeOf dt Is DataSet Then
            dt = dt.Tables(MyTable)
        End If
        Dim isExist As Boolean = False
        Dim isInsert As Boolean = TransMode = "insert"
        Dim dr As DataRow = Nothing
        If isInsert Then
            dr = dt.NewRow
        Else
            Dim drs = dt.Select(String.Format("{0} = '{1}'", MyPK.TextSource, MyPK.Text))
            If drs.Length > 0 Then
                dr = drs(0)
            End If
        End If
        dr.Item(PKName) = MyPK.Text
        dr.Item(MyForeignKey.TextSource) = MyForeignKey.Text
        For Each ctrl In MyControls
            If TypeOf ctrl Is MyTextBox Then
                Dim ctr = CType(ctrl, MyTextBox)
                If ctr.Required Then
                    If ctr.Text = "" And ctr.Value = "" Then
                        MsgBox("Required field cannot be empty.")
                        Exit Sub
                    End If
                End If
                If ctr.TextSource <> "" Then
                    dr.Item(ctr.TextSource) = ctr.Text
                    If ctr.NumberFormat.Contains("#") Then
                        dr.Item(ctr.TextSource) = ctr.DecimalValue
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
                If ctr.ValueSource <> "" Then
                    dr.Item(ctr.ValueSource) = ctr.Value
                    If ctr.NumberFormat.Contains("#") Then
                        dr.Item(ctr.ValueSource) = ctr.DecimalValue
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
                End If
            ElseIf TypeOf ctrl Is MyCheckBox Then
                Dim ctr = CType(ctrl, MyCheckBox)
                If dr.Table.Columns.Contains(ctr.ValueSource) Then
                    dr.Item(ctr.ValueSource) = ctr.Checked
                End If
            ElseIf TypeOf ctrl Is MyRadioGroup Then
                Dim ctr = CType(ctrl, MyRadioGroup)
                If ctr.Required Then
                    If ctr.Value = "" Then
                        MsgBox("Required field cannot be empty.")
                        Exit Sub
                    End If
                End If
                If dr.Table.Columns.Contains(ctr.ValueSource) Then
                    dr.Item(ctr.ValueSource) = ctr.Value
                End If
            ElseIf TypeOf ctrl Is myMaskedTextBox Then
                Dim ctr = CType(ctrl, myMaskedTextBox)
                If ctr.Required Then
                    If ctr.Text = "" And ctr.Value = "" Then
                        MsgBox("Required field cannot be empty.")
                        Exit Sub
                    End If
                End If
                If ctr.TextSource <> "" Then
                    dr.Item(ctr.TextSource) = ctr.Text
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
                If ctr.ValueSource <> "" Then
                    dr.Item(ctr.ValueSource) = ctr.Value
                    If ctr.Unique Then
                        Dim existingRecord = dt.Select(String.Format("{0} = '{1}' AND {2} <> '{3}'", ctr.ValueSource, ctr.Value, MyPK.TextSource, MyPK.Text))
                        If isInsert Then
                            existingRecord = dt.Select(String.Format("{0} = '{1}'", ctr.ValueSource, ctr.Value))
                        End If
                        If existingRecord.Length > 0 Then
                            isExist = True
                        End If
                    End If
                End If
            End If
        Next
        If isExist Then
            MsgBox("Record Already Exist.")
            Exit Sub
        End If
        Dim selectedID As String = MyPK.Text
        If isInsert Then
            dt.Rows.Add(dr)
        Else
            dt.AcceptChanges()
        End If
        MyDGView.DataSource = dt
        EnableMyControl(False)
        InitDataOfMyDGV()
        If isInsert Then
            Dim toInsert = MsgBox("Successfully Saved." & "Add Another Record?", MsgBoxStyle.YesNo, "Confirmation")
            If toInsert = MsgBoxResult.Yes Then
                ButtonInsert.PerformClick()
            End If
        Else
            'MsgBox("Successfully Saved.")
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
        TransMode = ""
    End Sub
    Private Sub MySearchTextChange(sender As Control, e As EventArgs)
        Dim q As String = MySearch.Text
        If MySearch.TextSource <> "" Then
            Dim cols = MySearch.TextSource.Split(",")
            Dim selectQuery As String = ""
            For Each col In cols
                selectQuery &= String.Format(" AND {0} LIKE '%{1}%'", col, q)
            Next
            Dim dt As DataTable = MyDGView.DataSource
            Dim selectedRows = dt.Select(selectQuery.Substring(5))
            If selectedRows.Length > 0 Then
                If currentSearchIndex >= selectedRows.Length Then
                    currentSearchIndex = 0
                End If
                Dim selectedID As String = selectedRows(currentSearchIndex).Item(PKName).ToString
                MyDGView.ClearSelection()
                For Each row As DataGridViewRow In MyDGView.Rows
                    If row.Cells(DGVColumnName).Value.ToString = selectedID Then
                        row.Selected = True
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub MySearchKeyDown(sender As Object, e As Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter And e.Control Then
            currentSearchIndex += 1
            MySearchTextChange(Nothing, Nothing)
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub DGVSelectionChange(sender As Control, e As EventArgs)
        If IsLoadEnd Then
            If MyDGView.Rows.Count > 0 Then
                If MyDGView.SelectedRows.Count > 0 Then
                    Dim CurrentPKValue As String = MyDGView.SelectedRows(0).Cells(DGVColumnName).Value.ToString
                    Dim DGVDataTable As DataTable = MyDGView.DataSource
                    Dim SelectedRowRecords = DGVDataTable.Select(String.Format("{0} = '{1}'", PKName, CurrentPKValue))
                    If SelectedRowRecords.Length > 0 Then
                        BindMyControl(SelectedRowRecords(0))
                        If MyChildren.Count > 0 Then
                            For Each child In MyChildren
                                child.LoadMyRecord()
                            Next
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub BindMyControl(ByVal dr As DataRow)
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
            If col.DataPropertyName = "deleted" Then
                DGVDelName = col.Name
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
                        ctr.Enabled = ToEnable
                    End If
                Else
                    If Not ctr.AlwaysEnable Then
                        ctr.Enabled = ToEnable
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
            If ToEnable Then
                child.EnableMyControl(False)
            Else
                child.DisableMyControl()
            End If
        Next
        HideMyParentButtons(ToEnable)
        MyDGView.Enabled = Not ToEnable
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
    Friend Sub HideMyParentButtons(Optional ToHide As Boolean = True)
        If MyParent IsNot Nothing Then
            If TypeOf MyParent Is MyPanel Then
                Dim currentParent = CType(MyParent, MyPanel)
                currentParent.HideMyButtons(ToHide)
            ElseIf TypeOf MyParent Is MyForm Then
                Dim currentParent = CType(MyParent, MyForm)
                currentParent.HideMyButtons(ToHide)
            End If
        End If
    End Sub
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
                ctr.Checked = False
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
            End If
        Next
        For Each child As MyPanel In MyChildren
            child.ClearMyData()
        Next
    End Sub
    Friend Sub ClearMyData()
        Dim tmp = MyDGView.DataSource
        If TypeOf tmp Is DataSet Then
            Dim ds As DataSet = CType(tmp, DataSet)
            Dim dt As DataTable = ds.Tables(MyTable)
            dt.Clear()
            MyDGView.DataSource = dt
        ElseIf TypeOf tmp Is DataTable Then
            Dim dt As DataTable = CType(tmp, DataTable)
            dt.Clear()
            MyDGView.DataSource = dt
        End If
    End Sub
    Friend Sub LoadMyRecord()
        If MyForeignKey IsNot Nothing Then
            Dim sql As String = String.Format("SELECT a.* FROM {0} a WHERE a.{1} = '{2}'", MyTable, MyForeignKey.TextSource, MyForeignKey.Text)
            If strSelect <> "" Then
                sql = strSelect & " FROM " & MyTable & " a " & strLeftJoin & String.Format(" WHERE a.{0} = '{1}'", MyForeignKey.TextSource, MyForeignKey.Text)
            End If
            If CustomQuery <> "" Then
                sql = Functions.getCustomQuery(CustomQuery) & String.Format(" WHERE a.{0} = '{1}'", MyForeignKey.TextSource, MyForeignKey.Text)
            End If
            Dim dt As DataTable = Nothing
            If MyDataBase = MyList.Database.FileSetup Then
                dt = FsQuery(sql)
            Else
                dt = Query(sql)
            End If
            MyDGView.AutoGenerateColumns = False
            Dim ds = MyDGView.DataSource
            If TypeOf ds Is DataSet Then
                If ds.Tables.Contains(MyTable) Then
                    ds.Tables(MyTable).Rows.Clear()
                    For Each row As DataRow In dt.Rows
                        ds.Tables(MyTable).ImportRow(row)
                    Next
                    MyDGView.DataSource = ds.Tables(MyTable)
                End If
            Else
                ds.Rows.Clear()
                For Each row As DataRow In dt.Rows
                    ds.ImportRow(row)
                Next
                MyDGView.DataSource = ds
                InitDataOfMyDGV()
            End If
            IsLoadEnd = True
            If MyDGView.Rows.Count > 0 Then
                MyDGView.ClearSelection()
                MyDGView.Rows(0).Selected = True
            Else
                ClearMyControl()
            End If
        End If
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
    Private Sub InitDataOfMyDGV()
        For Each row As DataGridViewRow In MyDGView.Rows
            If row.Cells(DGVDelName).Value Then
                MyDGView.CurrentCell = Nothing
                row.Visible = False
            End If
        Next
    End Sub
    Friend Sub SaveMe(ByVal FKName As String, ByVal FKValue As String)
        Dim sql_insert As String = ""
        Dim sql_update As String = ""
        Dim sql_delete As String = ""
        Dim strIDSDelete As String = ""
        Dim strColumnInsert As String = ""
        Dim columns = GetColumnToSave()
        For Each col In columns
            If col <> PKName Then
                strColumnInsert &= "," & col
            End If
        Next
        Dim dt As DataTable = MyDGView.DataSource
        For Each row As DataRow In dt.Rows
            If row.Item(PKName).ToString.ToLower.Contains("tmp_") Then
                If Not row.Item("deleted") Then
                    Dim tmp_str As String = ""
                    Dim tmpDic As New Dictionary(Of String, String)
                    tmpDic.Add(PKName, "")
                    For Each col In columns
                        If dt.Columns.Contains(col) Then
                            Dim tmpVal = row.Item(col).ToString
                            If col = PKName Then
                                tmpVal = ""
                            End If
                            If tmpDic.ContainsKey(col) Then
                                tmpDic.Item(col) = tmpVal
                            Else
                                tmpDic.Add(col, tmpVal)
                            End If
                        End If
                        'If col <> PKName Then
                        '    If dt.Columns.Contains(col) Then
                        '        Dim tmp_val As String = row.Item(col).ToString
                        '        If tmp_val = "" Then
                        '            tmp_val = "default"
                        '        Else
                        '            tmp_val = "'" & tmp_val & "'"
                        '        End If
                        '        tmp_str &= String.Format(",{0}", tmp_val)
                        '    End If
                        'End If
                    Next
                    If tmpDic.ContainsKey(FKName) Then
                        tmpDic.Item(FKName) = FKValue
                    Else
                        tmpDic.Add(FKName, FKValue)
                    End If
                    sql_insert &= ATGenerateQuery("Insert", MyTable, tmpDic, Environment.MachineName, Environment.UserName, MyLogID)
                    'If tmp_str <> "" Then
                    '    tmp_str &= String.Format(",{0}", FKValue)
                    '    sql_insert &= String.Format(",({0})", tmp_str.Substring(1))
                    'End If
                End If
            Else
                If Not row.Item("deleted") Then
                    Dim tmp_str As String = ""
                    Dim tmpDic As New Dictionary(Of String, String)
                    If dt.Columns.Contains(PKName) Then
                        tmpDic.Add(PKName, row.Item(PKName).ToString)
                    End If
                    If dt.Columns.Contains(FKName) Then
                        tmpDic.Add(FKName, row.Item(FKName).ToString)
                    End If
                    For Each col In columns
                        If dt.Columns.Contains(col) Then
                            If tmpDic.ContainsKey(col) Then
                                tmpDic.Item(col) = row.Item(col).ToString
                            Else
                                tmpDic.Add(col, row.Item(col).ToString)
                            End If
                        End If
                        'If dt.Columns.Contains(col) Then
                        '    Dim tmp_val As String = row.Item(col).ToString
                        '    If tmp_val = "" Then
                        '        tmp_val = "default"
                        '    Else
                        '        tmp_val = "'" & tmp_val & "'"
                        '    End If
                        '    tmp_str &= String.Format(" AND {0} = {1}", col, tmp_val)
                        'End If
                    Next
                    'If tmp_str <> "" Then
                    '    Dim tmp_val As String = FKValue
                    '    If tmp_val = "" Then
                    '        tmp_val = "default"
                    '    Else
                    '        tmp_val = "'" & tmp_val & "'"
                    '    End If
                    '    tmp_str &= String.Format(" AND {0} = {1}", FKName, tmp_val)
                    '    sql_update &= String.Format("UPDATE {0} SET {1} WHERE {2} = '{3}';" _
                    '        , MyTable, tmp_str.Substring(5), PKName, row.Item(PKName))
                    'End If
                    sql_update &= ATGenerateQuery("Update", MyTable, tmpDic, Environment.MachineName, Environment.UserName, MyLogID)
                Else
                    strIDSDelete &= String.Format("{0}|", row.Item(PKName).ToString())
                    'strIDSDelete &= String.Format(",{0}", row.Item(PKName).ToString())
                End If
            End If
        Next
        If sql_insert <> "" Then
            'sql_insert = String.Format("INSERT INTO {0}({1},{3}) VALUES{2}", MyTable, strColumnInsert.Substring(1), sql_insert.Substring(1), FKName)
            If MyDataBase = MyList.Database.FileSetup Then
                FsQuery(sql_insert)
            Else
                Query(sql_insert)
            End If
        End If
        If sql_update <> "" Then
            If MyDataBase = MyList.Database.FileSetup Then
                FsQuery(sql_update)
            Else
                Query(sql_update)
            End If
        End If
        If strIDSDelete <> "" Then
            sql_delete = ATGenerateQuery("Remove", MyTable, Nothing, Environment.MachineName, Environment.UserName, MyLogID, strIDSDelete, PKName)
            'sql_delete = String.Format("DELETE FROM {0} WHERE {1} IN ({2});", MyTable, PKName, strIDSDelete.Substring(1))
            If MyDataBase = MyList.Database.FileSetup Then
                FsQuery(sql_delete)
            Else
                Query(sql_delete)
            End If
        End If
    End Sub
    Private Function GetColumnToSave() As List(Of String)
        Dim returnList As New List(Of String)
        For Each ctrl In MyControls
            If TypeOf ctrl Is MyTextBox Then
                Dim ctr = CType(ctrl, MyTextBox)
                If Not ctr.NoSave Then
                    If ctr.ValueSource <> "" Then
                        returnList.Add(ctr.ValueSource)
                    Else
                        returnList.Add(ctr.TextSource)
                    End If
                End If
            ElseIf TypeOf ctrl Is MyCheckBox Then
                Dim ctr = CType(ctrl, MyCheckBox)
                If Not ctr.NoSave Then
                    returnList.Add(ctr.ValueSource)
                End If
            ElseIf TypeOf ctrl Is MyRadioGroup Then
                Dim ctr = CType(ctrl, MyRadioGroup)
                If Not ctr.NoSave Then
                    returnList.Add(ctr.ValueSource)
                End If
            ElseIf TypeOf ctrl Is myMaskedTextBox Then
                Dim ctr = CType(ctrl, myMaskedTextBox)
                If Not ctr.NoSave Then
                    If ctr.ValueSource <> "" Then
                        returnList.Add(ctr.ValueSource)
                    Else
                        returnList.Add(ctr.TextSource)
                    End If
                End If
            End If
        Next
        Return returnList
    End Function
    Private Sub GetMyParent(ByRef CurrentContainer As Control)
        If TypeOf CurrentContainer.Parent Is MyPanel Then
            MyParent = CType(CurrentContainer.Parent, MyPanel)
        ElseIf TypeOf CurrentContainer.Parent Is MyForm Then
            MyParent = CType(CurrentContainer.Parent, MyForm)
        Else
            GetMyParent(CurrentContainer.Parent)
        End If
    End Sub
#End Region
#Region "Own Event"
    Private Sub MeLoad(sender As Object, e As EventArgs)
        'Application.EnableVisualStyles()
        If sender.Name <> "MyPanel" Then
            If IsInit Then
                LoadMyRecord()
                EnableMyControl(False)
                GetDGVColumnName()
                IsLoadEnd = True
                If MyDGView.Rows.Count > 0 Then
                    MyDGView.ClearSelection()
                    MyDGView.Rows(0).Selected = True
                Else
                    ClearMyControl()
                End If
            End If
        End If
    End Sub
#End Region
End Class