Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports System.Reflection
Imports user_control
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraEditors
Imports SecFuntions = OHelper.Classes.Security.SecFunctions
Imports PC = PasswordCryptor.PasswordCryptor

Public Class myFunctions
    Private Shared Cryptor As New PC()
    Public Shared Function EncryptPassword(ByVal str) As String
        Dim _returnPassword = ""
        Dim _sf As New SecFunctions
        _returnPassword = _sf.EncryptString(str, _sf.key, _sf.iv)
    End Function
    Public Shared Function DecryptPassword(ByVal str) As String
        Dim _returnPassword = ""
        Dim _sf As New SecFunctions
        _returnPassword = _sf.DecryptString(str, _sf.key, _sf.iv)
    End Function
    Public Shared Sub SetBackgroundGradient(ByRef Control As Object, ByVal Color1 As System.Drawing.Color, ByVal Color2 As System.Drawing.Color)
        Dim vLinearGradient As System.Drawing.Drawing2D.LinearGradientBrush =
        New System.Drawing.Drawing2D.LinearGradientBrush(New System.Drawing.Point(Control.Width, Control.Height), New System.Drawing.Point(Control.Width, 0), Color1, Color2)
        Dim vGraphic As System.Drawing.Graphics = Control.CreateGraphics
        Dim vTexture As New System.Drawing.TextureBrush(Control.BackgroundImage)
        vGraphic.FillRectangle(vLinearGradient, Control.DisplayRectangle)
        vGraphic.FillRectangle(vTexture, Control.DisplayRectangle)
        vGraphic.Dispose() : vGraphic = Nothing
    End Sub
    Public Shared Function generateRange(ByVal date_from As Date, ByVal date_to As Date) As String
        Dim return_str As String = ""
        If date_from.Year = date_to.Year Then
            If date_from.Month = date_to.Month Then
                return_str = "For the Month of " & MonthName(date_from.Month)
            Else
                return_str = "For the Month of " & MonthName(date_from.Month) & " - " & MonthName(date_to.Month)
            End If
        Else
            return_str = "For the Month of " & MonthName(date_from.Month) & " " & date_from.Year & " - " & MonthName(date_to.Month) & " - " & date_to.Year
        End If
        Return return_str
    End Function
    Private Sub generateDGVColumn(ByVal dg As DataGridView, ByVal colNumber As Integer, ByVal rowNumber As Integer, ByVal colName As String)
        dg.Columns.Clear()
        For i As Integer = 0 To colNumber - 1
            Dim col As New DataGridViewColumn
            col.Name = colName & (i + 1)
            col.DataPropertyName = colName & (i + 1)
            col.HeaderText = colName & (i + 1)
            dg.Columns.Add(col)
        Next
        For i As Integer = 0 To rowNumber - 1
            Dim row As String() = New String() {}
            For j As Integer = 0 To colNumber - 1
                row(i) = 0
            Next
            dg.Rows.Add(row)
        Next
    End Sub
    Public Shared Sub BackgroundGradient(ByRef Control As Object, ByVal Color1 As System.Drawing.Color, ByVal Color2 As System.Drawing.Color)

        Dim vLinearGradient As System.Drawing.Drawing2D.LinearGradientBrush =
            New System.Drawing.Drawing2D.LinearGradientBrush(New System.Drawing.Point(Control.Width, Control.Height),
                                                        New System.Drawing.Point(Control.Width, 0),
                                                        Color1,
                                                        Color2)

        Dim vGraphic As System.Drawing.Graphics = Control.CreateGraphics
        ' To tile the image background - Using the same image background of the image

        vGraphic.FillRectangle(vLinearGradient, Control.DisplayRectangle)

        vGraphic.Dispose() : vGraphic = Nothing
    End Sub
    Public Shared Function groupDataTableToList(ByVal dt As DataTable, ByVal colName As String) As List(Of Object)
        Dim newList As New List(Of Object)
        Dim newIndex As Integer = 0
        Dim isExist As Boolean = False
        Dim dataIndex As Integer = 0

        Dim fields = colName.Split(",")

        For Each dr As DataRow In dt.Rows
            isExist = False
            For i As Integer = 0 To newList.Count - 1
                If dr.Item(fields(0)).ToString = newList.Item(i).Item(fields(0)).ToString Then
                    isExist = True
                    Dim newDicData As New Dictionary(Of String, String)
                    For Each dc As DataColumn In dt.Columns
                        newDicData.Add(dc.ColumnName, dr.Item(dc.ColumnName).ToString)
                    Next
                    newList.Item(i).Item("datas").Add(newDicData)
                End If
            Next
            If Not isExist Then
                newIndex = newList.Count
                Dim newDic As New Dictionary(Of String, Object)
                Dim newListData As New List(Of Object)
                Dim newData As New Dictionary(Of String, String)
                newDic.Add(fields(0), dr.Item(fields(0)))
                For Each dc As DataColumn In dt.Columns
                    newData.Add(dc.ColumnName, dr.Item(dc.ColumnName).ToString)
                Next
                newListData.Add(newData)
                newDic.Add("datas", newListData)
                newList.Add(newDic)
            End If
        Next
        If fields.Count > 1 Then
            For i As Integer = 1 To fields.Count - 1
                groupBy(newList, fields(i))
            Next
        End If
        Return newList
    End Function
    Public Shared Sub groupBy(ByRef groupedList As List(Of Object), ByVal colName As String)
        For i As Integer = 0 To groupedList.Count - 1
            Dim a = groupedList(i)
            Dim b = CType(a, Dictionary(Of String, Object))
            If b.ContainsKey("datas") Then
                Dim c = copyList(b.Item("datas"))
                groupedList(i).Remove("datas")
                groupedList(i).Add("grouped", groupList(c, colName))
            ElseIf b.ContainsKey("grouped") Then
                groupBy(groupedList(i).Item("grouped"), colName)
            End If
        Next
    End Sub
    Public Shared Function groupList(ByVal lst As List(Of Object), ByVal colName As String) As List(Of Object)
        Dim returnValue As New List(Of Object)
        For Each a In lst
            Dim b = CType(a, Dictionary(Of String, Object))
            Dim exist As Boolean = False
            For i As Integer = 0 To returnValue.Count - 1
                Dim c = returnValue.Item(i)
                Dim d = CType(c, Dictionary(Of String, Object))
                If d.Item(colName) = b.Item(colName) Then
                    Dim newDic As New Dictionary(Of String, Object)
                    For Each e In b
                        newDic.Add(e.Key, e.Value)
                    Next
                    returnValue.Item(i).Item("datas").Add(newDic)
                    exist = True
                End If
            Next
            If Not exist Then
                Dim dic As New Dictionary(Of String, Object)
                Dim newDic As New Dictionary(Of String, Object)
                Dim newList As New List(Of Object)
                newDic.Add(colName, b.Item(colName))
                For Each c In b
                    dic.Add(c.Key, c.Value)
                Next
                newList.Add(dic)
                newDic.Add("datas", newList)
                returnValue.Add(newDic)
            End If
        Next
        Return returnValue
    End Function
    Public Shared Function copyList(ByVal lst As List(Of Object)) As List(Of Object)
        Dim returnValue As New List(Of Object)
        For Each obj In lst
            Dim dic = Nothing
            If TypeOf obj Is Dictionary(Of String, String) Then
                dic = CType(obj, Dictionary(Of String, String))
            ElseIf TypeOf obj Is Dictionary(Of String, Object) Then
                dic = CType(obj, Dictionary(Of String, Object))
            End If
            Dim newDic As New Dictionary(Of String, Object)
            For Each c In dic
                newDic.Add(c.Key, c.Value)
            Next
            returnValue.Add(newDic)
        Next
        Return returnValue
    End Function
    Public Shared Function stringDesign(ByVal str As String, Optional pipe As String = "|", Optional spaceLength As Integer = 31) As String
        Dim spaces As String = createSpace(spaceLength)
        Dim tmpStr As String = (str & spaces).Substring(0, spaces.Length)
        Dim newStr As String = pipe
        For i As Integer = 0 To tmpStr.Length - 1
            newStr &= tmpStr.Substring(i, 1) & pipe
        Next
        Return newStr
    End Function
    Public Shared Function createSpace(ByVal length As Integer) As String
        Dim str As String = ""
        For i As Integer = 0 To length - 1
            str += " "
        Next
        Return str
    End Function
    Public Shared Sub saveAddAnother(ByVal btnInsert As Button, Optional str As String = "")
        Dim confirm = MsgBox("Successfully Save." & Environment.NewLine & Environment.NewLine & If(str = "", "Add another Transaction?", str), MsgBoxStyle.YesNo, "Save")
        If confirm = MsgBoxResult.Yes Then
            btnInsert.PerformClick()
        End If
    End Sub
    Public Shared Sub searchGrid(ByVal columnName As String, ByVal dg As DataGridView, ByVal q As String)
        Dim colName As String = ""
        For Each col As DataGridViewColumn In dg.Columns
            If col.DataPropertyName = columnName Then
                colName = col.Name
                Exit For
            End If
        Next
        If colName <> "" Then
            For Each row As DataGridViewRow In dg.Rows
                Dim value As String = row.Cells(colName).Value.ToString
                If value.ToLower.Contains(q.ToLower) Then
                    Try
                        row.Cells(0).Selected = True
                    Catch ex As Exception
                        row.Cells(1).Selected = True
                    End Try
                    Exit Sub
                End If
            Next
        End If
    End Sub
    Public Shared Function CreateObjectInstance(ByVal objectName As String) As Object
        Dim obj As Object
        Try
            If objectName.LastIndexOf(".") = -1 Then
                objectName = [Assembly].GetEntryAssembly.GetName.Name & "." & objectName
            End If

            obj = [Assembly].GetEntryAssembly.CreateInstance(objectName)

        Catch ex As Exception
            obj = Nothing
        End Try
        Return obj

    End Function
    Public Shared Sub callFunctionByString(ByVal frm As Form, ByVal str As String)
        Dim method As MethodInfo = frm.GetType.GetMethod(str, BindingFlags.NonPublic Or BindingFlags.Instance)
        If method IsNot Nothing Then
            method.Invoke(frm, Nothing)
        End If
    End Sub
    Public Shared Sub ShowOrOpenFormNew(objform As Form)
        Dim skey As String = objform.Name
        If ShowFormForKey(skey) Then
        Else
            objform.Show()
        End If
    End Sub
    Public Shared Sub ShowOrOpenForm(objform As Form)
        Dim skey As String = objform.Name
        If ShowFormForKey(skey) Then
            callFunctionByString(objform, "refresh_record")
        Else
            objform.Show()
        End If
    End Sub
    Public Shared Function getShownForm(ByVal str As String) As Object
        For Each oForm As Form In Application.OpenForms().OfType(Of Form)()
            If oForm.Name = str Then
                Return oForm
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function ShowFormForKey(sKey As String) As Boolean

        For Each oForm As Form In Application.OpenForms().OfType(Of Form)()
            If oForm.Name = sKey Then
                oForm.Show()
                Return True
            End If
        Next

        Return False
    End Function
    Public Shared Function getData(qry As String) As DataTable
        Dim dt As New DataTable
        Dim conn As New MySqlConnection(String.Format("server={0};Port=3306; user id={1}; password={2}; database={3}", vtxtIP, _serverUser, _serverPass, _serverDBFS))
        conn.Open()
        Dim data As MySqlDataReader
        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand
        command.CommandText = qry
        command.Connection = conn
        adapter.SelectCommand = command
        data = command.ExecuteReader

        dt.Clear()
        dt.Load(data)

        data.Close()
        conn.Close()

        Return dt
    End Function
    Public Shared Function MySqlDate(d As String)
        Dim myd As String = ""
        Dim s1 = d.IndexOf("/")
        Dim s2 = d.IndexOf("/", s1 + 1)
        If s1 > 0 And s2 > 0 Then
            Dim mm = d.Substring(0, s1)
            Dim dd = d.Substring(s1 + 1, s2 - s1 - 1)
            Dim yy = d.Substring(s2 + 1)
            myd = yy & "-" & mm.PadLeft(2, "0") & "-" & dd.PadLeft(2, "0")
        End If
        Return myd
    End Function
    Public Shared Sub dtCopyPK(ByRef dtto As DataTable, dtfrom As DataTable, Optional filter As Dictionary(Of String, String) = Nothing)
        If dtfrom.Rows.Count > 0 Then
            Dim rows() As DataRow = Nothing
            If filter IsNot Nothing Then
                If filter.Count > 0 Then
                    Dim filt As String = ""
                    For Each key As String In filter.Keys
                        filt &= " " & key & " = '" & filter(key) & "'"
                    Next
                    rows = dtfrom.Select(filt)
                End If
            End If
            If rows Is Nothing Then
                rows = dtfrom.Select()
            End If

            If rows.Count > 0 Then
                For i = 0 To rows.Count - 1
                    Dim pks(dtto.PrimaryKey.Length - 1) As Object
                    Dim ix As Integer = -1
                    For Each pk As DataColumn In dtto.PrimaryKey
                        ix += 1
                        pks(ix) = rows(i)(pk.ColumnName)
                    Next
                    Dim exist As DataRow = dtto.Rows.Find(pks)
                    If Not exist Is Nothing Then
                        Dim ind As Integer = dtto.Rows.IndexOf(exist)
                        If ind >= 0 Then
                            For Each col As DataColumn In dtto.Columns
                                If rows(i).Table.Columns.Contains(col.ColumnName) Then
                                    'dtto.Rows(ind).Item(col.ColumnName) = dtfrom.Select(sel)(0).Item(col.ColumnName)
                                    dtto.Rows(ind)(col.ColumnName) = rows(i)(col.ColumnName)
                                End If
                            Next
                        End If
                    Else
                        dtto.ImportRow(rows(i))
                    End If
                Next
            End If
        End If
    End Sub
    Public Shared Sub dtCopy(ByRef dtto As DataTable, dtfrom As DataTable, Optional str() As String = Nothing, Optional required As String = "", Optional remain As String = "")
        If dtfrom.Rows.Count > 0 Then
            For i = 0 To dtfrom.Rows.Count - 1
                Dim sel As String = "jbooks_id = '" & dtfrom.Rows(i)("jbooks_id") & "'"
                If Not str Is Nothing Then
                    For j As Integer = 0 To str.Count - 1
                        sel &= " AND " & str(j) & " = '" & dtfrom.Rows(i)(str(j)) & "'"
                    Next
                End If
                Dim exist() As DataRow = dtto.Select(sel)
                MyDebugging.AddText(String.Format("SEL: {0} , FOUND: {1}", sel, exist.Length))
                If exist.Count > 0 Then
                    Dim ind As Integer = dtto.Rows.IndexOf(exist(0))
                    If ind >= 0 Then
                        If required <> "" Then
                            If dtfrom.Select(sel)(0).Item(required) Then
                                'dtto.Rows(ind).Item("deleted") = False
                                For Each col As DataColumn In dtto.Columns
                                    If dtfrom.Columns.Contains(col.ColumnName) Then
                                        If remain = col.ColumnName Then
                                            dtfrom.Select(sel)(0).Item(col.ColumnName) = dtto.Rows(ind).Item(col.ColumnName)
                                        End If
                                        dtto.Rows(ind).Item(col.ColumnName) = dtfrom.Select(sel)(0).Item(col.ColumnName)
                                        'dtto.Rows(ind).Item(col.ColumnName) = dtfrom.Rows(ind).Item(col.ColumnName)
                                    End If
                                Next
                            Else
                                If dtto.Select(sel).Length > 0 Then
                                    'dtto.Rows.Remove(dtto.Select(sel)(0))
                                    dtto.Rows(ind).Item("deleted") = True
                                End If
                            End If
                        Else
                            For Each col As DataColumn In dtto.Columns
                                If dtfrom.Columns.Contains(col.ColumnName) Then
                                    If remain = col.ColumnName Then
                                        dtfrom.Select(sel)(0).Item(col.ColumnName) = dtto.Rows(ind).Item(col.ColumnName)
                                    End If
                                    dtto.Rows(ind).Item(col.ColumnName) = dtfrom.Select(sel)(0).Item(col.ColumnName)
                                    'dtto.Rows(ind).Item(col.ColumnName) = dtfrom.Rows(ind).Item(col.ColumnName)
                                End If
                            Next
                        End If
                    End If
                Else
                    If required <> "" Then
                        If dtfrom.Rows(i).Item(required) Then
                            dtto.ImportRow(dtfrom.Rows(i))
                        End If
                    Else
                        dtto.ImportRow(dtfrom.Rows(i))
                    End If
                End If
            Next
        End If
    End Sub
    Public Shared Sub dtCopy2(ByRef dtto As DataTable, dtfrom As DataTable)
        'dtto.Rows.Clear()
        If dtfrom.Rows.Count > 0 Then
            For n = 0 To dtfrom.Rows.Count - 1
                Dim dr As DataRow = dtfrom.Rows(n)
                Dim drnew As DataRow = dtto.NewRow
                For i = 0 To dr.Table.Columns.Count - 1
                    Dim cn As String = dr.Table.Columns(i).ColumnName
                    If drnew.Table.Columns.IndexOf(cn) >= 0 Then
                        drnew(cn) = dr(cn)
                    End If
                Next
                dtto.Rows.Add(drnew)
            Next
        End If
    End Sub
    Public Shared Function ifNull(ByVal var As Object, ByVal val As Object) As Object
        If var Is Nothing Then
            Return val
        End If
        If var.ToString <> "" Then
            Return var
        End If
        Return val
    End Function
    Public Shared Sub dtReplace(ByRef dtto As DataTable, dtfrom As DataTable, ByVal ref_id As String)
        If dtfrom.Rows.Count > 0 Then
            For i = 0 To dtfrom.Rows.Count - 1
                Dim exist() As DataRow = dtto.Select(ref_id & " = '" & dtfrom.Rows(i)(ref_id) & "'")
                If exist.Count > 0 Then
                    Dim ind As Integer = dtto.Rows.IndexOf(exist(0))
                    If ind >= 0 Then
                        Dim calculated As Boolean = False
                        dtto.Rows(ind)("isInputted") = dtfrom.Rows(i)("isInputted")
                        If dtto.Columns.Contains("salvage_value") Then
                            dtto.Rows(ind)("salvage_value") = dtfrom.Rows(i)("salvage_value")
                            dtto.Rows(ind)("salvage_value_based") = dtfrom.Rows(i)("salvage_value_based")
                        End If
                        If dtto.Columns.Contains("amount") Then
                            dtto.Rows(ind)("amount") = dtfrom.Rows(i)("amount")
                            dtto.Rows(ind)("balance") = dtto.Rows(ind)("tmp_amount") - dtto.Rows(ind)("amount")
                            calculated = True
                        End If
                        If dtto.Columns.Contains("tax_amount") Then
                            dtto.Rows(ind)("tax_amount") = dtfrom.Rows(i)("tax_amount")
                            dtto.Rows(ind)("balance") = dtto.Rows(ind)("tmp_amount") - dtto.Rows(ind)("tax_amount")
                            calculated = True
                        End If
                        If dtto.Columns.Contains("vat_amount") Then
                            dtto.Rows(ind)("vat_amount") = dtfrom.Rows(i)("vat_amount")
                            dtto.Rows(ind)("balance") = dtto.Rows(ind)("tmp_amount") - dtto.Rows(ind)("vat_amount")
                            calculated = True
                        End If
                        If Not calculated Then
                            dtto.Rows(ind)("jbooks_id") = dtfrom.Rows(i)("jbooks_id")
                            If dtto.Rows(ind)("dc").ToString = "1" Then
                                dtto.Rows(ind)("credit") = dtfrom.Rows(i)("credit")
                                dtto.Rows(ind)("balance") = dtto.Rows(ind)("tmp_amount") - dtto.Rows(ind)("credit")
                            Else
                                dtto.Rows(ind)("debit") = dtfrom.Rows(i)("debit")
                                dtto.Rows(ind)("balance") = dtto.Rows(ind)("tmp_amount") - dtto.Rows(ind)("debit")
                            End If
                            dtto.Rows(ind)("isInputted") = True
                        End If
                        dtto.Rows(ind)("debit") = dtfrom.Rows(i)("debit")
                        dtto.Rows(ind)("credit") = dtfrom.Rows(i)("credit")
                        dtto.Rows(ind)("debit_based") = dtfrom.Rows(i)("debit_based")
                        If dtto.Columns.Contains("credit_amount_based") Then
                            dtto.Rows(ind)("credit_amount_based") = dtfrom.Rows(i)("credit_amount_based")
                        Else
                            dtto.Rows(ind)("credit_based") = dtfrom.Rows(i)("credit_based")
                        End If
                    End If
                End If
            Next
        End If
    End Sub
    Private Shared Sub dtReplace2(ByRef dtto As DataTable, dtfrom As DataTable, ByVal str() As String)
        If dtfrom.Rows.Count > 0 Then
            For i As Integer = 0 To dtto.Rows.Count - 1 'loop para sa datatable to
                Dim drto As DataRow = dtto.Rows(i) 'current row ng table to
                For j As Integer = 0 To dtfrom.Rows.Count - 1 'loop para sa table from
                    Dim drfrom As DataRow = dtfrom.Rows(i) 'current row ng table from
                    Dim ctr As Integer = 0
                    For k As Integer = 0 To str.Length
                        If drto.Item(str(k)) = drfrom.Item(str(k)) Then 'kung parehas ng unique identity
                            ctr += 1
                        End If
                    Next
                    If ctr = str.Length Then
                        For k As Integer = 0 To dtfrom.Columns.Count - 1 'loop ng column ng from
                            Dim cn As String = dtfrom.Columns(k).ColumnName 'column name
                            drto.Item(cn) = drfrom.Item(cn) 'palitan ng laman ang to
                        Next
                    End If
                Next
                If drto.Item("deleted") Then 'pag deleted
                    dtto.Rows.Remove(drto) 'i remove sa to
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' Check if the id is already exist in other table.
    ''' </summary>
    ''' <param name="db">Database name where the table will be check.</param>
    ''' <param name="table">Table where the id will be check.</param>
    ''' <param name="pk">Primary key of the given table. This will be count if the record is exist.</param>
    ''' <param name="fk">Foreign key of given table or the column of the given id on the table given.</param>
    ''' <param name="fkVal">The value of the foreign key.</param>
    ''' <returns>Boolean existing true otherwise False.</returns>
    ''' <remarks>~/raymond; 2016-06-24</remarks>
    Public Shared Function isExistInTransaction(ByVal db As String, ByVal table As String, ByVal pk As String, ByVal fk As String, ByVal fkVal As String) As Boolean
        Dim flag As Boolean = False
        Dim sql As String = String.Format("SELECT COUNT({0}) AS existing FROM {1}.{2} WHERE {3} = {4}", pk, db, table, fk, fkVal)
        Dim dt As DataTable = Query(sql)
        If dt.Rows(0).Item("existing") > 0 Then
            flag = True
        End If
        Return flag
    End Function
    ''' <summary>
    ''' Find the value of column from datagrid.
    ''' </summary>
    ''' <param name="dg">Grid where the column name will be check if exist.</param>
    ''' <param name="pk">Column name of the given value.</param>
    ''' <param name="val">ID to check what is the value of the column.</param>
    ''' <param name="colName">The return value.</param>
    ''' <returns>Value of the given column name.</returns>
    ''' <remarks>~/raymond; 2016-06-24</remarks>
    Public Shared Function getColumnValue(ByVal dg As DataGridView, ByVal pk As String, ByVal val As String, ByVal colName As String) As String

        Dim value As String = ""
        Dim flag As Boolean = False

        For Each row As DataGridViewRow In dg.Rows
            If row.Cells(pk).Value.ToString = val Then
                value = row.Cells(colName).Value.ToString
                flag = True
            End If
        Next

        If Not flag Then
            MsgBox("Record does not exist.")
        End If

        Return value
    End Function
    ''' <summary>
    ''' Use to get the records inside the DataGridView
    ''' </summary>
    ''' <param name="pk_name">PrimaryKey Name</param>
    ''' <param name="sel">CheckBox inside the grid which will be check if checked.</param>
    ''' <param name="dg">DataGridView where the cursor will check.</param>
    ''' <param name="msg">The message that you want to show.</param>
    ''' <param name="withMessage">If the message will be show.</param>
    ''' <param name="noRecordMessage">If there is no record selected.</param>
    ''' <param name="listRecords">Will the message list the records?</param>
    ''' <returns>Array of string. This are the Ids that will be process. Example to be delete.</returns>
    ''' <remarks>~/raymond; 2016-06-24</remarks>

    Public Shared Function getCheckedGridRem(ByVal pk_name As String, ByVal sel As String, ByVal dg As DataGridView, Optional msg As String = "This are the selected record(s).", Optional withMessage As Boolean = True, Optional noRecordMessage As String = "Select Record First", Optional listRecords As Boolean = True) As String()
        Dim arr_id() As String = {}
        Dim list_name As New List(Of String)
        Dim list_id As New List(Of String)

        'Dim tmp_dt As DataTable = dg.DataSource

        Dim str_name As String = ""
        For Each row As DataGridViewRow In dg.Rows
            If row.Cells(sel).Value IsNot Nothing Then
                If row.Cells(sel).Value.ToString = "True" Then

                    list_id.Add(row.Cells(pk_name).Value.ToString)
                End If
            End If
        Next
        If list_id.Count = 0 Then
            If noRecordMessage <> "*No Message*" Then
                MsgBox(noRecordMessage, MsgBoxStyle.Information, "No record selected.")
            End If
            Return arr_id
        End If
        For i As Integer = 0 To list_name.Count - 1
            str_name &= String.Format(Environment.NewLine & (i + 1) & ". {0}", list_name(i))
        Next
        If withMessage Then
            Dim flag = MsgBox(msg & If(listRecords, Environment.NewLine & str_name, ""), MsgBoxStyle.OkCancel, "Delete")
            If flag = MsgBoxResult.Ok Then
                arr_id = list_id.ToArray
            End If
        Else
            arr_id = list_id.ToArray
        End If
        Return arr_id

    End Function
    ''' <summary>
    ''' Use to get the records inside the DataGridView
    ''' </summary>
    ''' <param name="pk_name">PrimaryKey Name</param>
    ''' <param name="name">Name of field to be list.</param>
    ''' <param name="sel">CheckBox inside the grid which will be check if checked.</param>
    ''' <param name="dg">DataGridView where the cursor will check.</param>
    ''' <param name="msg">The message that you want to show.</param>
    ''' <param name="withMessage">If the message will be show.</param>
    ''' <param name="noRecordMessage">If there is no record selected.</param>
    ''' <param name="listRecords">Will the message list the records?</param>
    ''' <returns>Array of string. This are the Ids that will be process. Example to be delete.</returns>
    ''' <remarks>~/raymond; 2016-06-24</remarks>

    Public Shared Function getCheckedGrid(ByVal pk_name As String, ByVal name As String, ByVal sel As String, ByVal dg As DataGridView, Optional msg As String = "This are the selected record(s).", Optional withMessage As Boolean = True, Optional noRecordMessage As String = "Select Record First", Optional listRecords As Boolean = True) As String()
        Dim arr_id() As String = {}
        Dim list_name As New List(Of String)
        Dim list_id As New List(Of String)

        'Dim tmp_dt As DataTable = dg.DataSource

        Dim str_name As String = ""
        For Each row As DataGridViewRow In dg.Rows
            If row.Cells(sel).Value IsNot Nothing Then
                If row.Cells(sel).Value.ToString = "True" Then
                    list_name.Add(row.Cells(name).Value.ToString)
                    list_id.Add(row.Cells(pk_name).Value.ToString)
                End If
            End If
        Next
        If list_id.Count = 0 Then
            If noRecordMessage <> "*No Message*" Then
                MsgBox(noRecordMessage, MsgBoxStyle.Information, "No record selected.")
            End If
            Return arr_id
        End If
        For i As Integer = 0 To list_name.Count - 1
            str_name &= String.Format(Environment.NewLine & (i + 1) & ". {0}", list_name(i))
        Next
        If withMessage Then
            Dim flag = MsgBox(msg & If(listRecords, Environment.NewLine & str_name, ""), MsgBoxStyle.OkCancel, "Delete")
            If flag = MsgBoxResult.Ok Then
                arr_id = list_id.ToArray
            End If
        Else
            arr_id = list_id.ToArray
        End If
        Return arr_id

    End Function
    ''' <summary>
    ''' Use to get the records inside the DataGridView
    ''' </summary>
    ''' <param name="pk_name">PrimaryKey Name</param>
    ''' <param name="name">Name of field to be list.</param>
    ''' <param name="sel">CheckBox inside the grid which will be check if checked.</param>
    ''' <param name="dg">DataGridView where the cursor will check.</param>
    ''' <param name="msg">The message that you want to show.</param>
    ''' <param name="withMessage">If the message will be show.</param>
    ''' <param name="noRecordMessage">If there is no record selected.</param>
    ''' <param name="listRecords">Will the message list the records?</param>
    ''' <returns>Array of string. This are the Ids that will be process. Example to be delete.</returns>
    ''' <remarks>~/raymond; 2016-06-24</remarks>

    Public Shared Function getCheckedGridUnit(ByVal pk_name As String, ByVal name As String, ByVal sel As String, ByVal dg As DataGridView, Optional msg As String = "This are the selected record(s).", Optional withMessage As Boolean = True, Optional noRecordMessage As String = "Select Record First", Optional listRecords As Boolean = True) As String()
        Dim arr_id() As String = {}
        Dim list_name As New List(Of String)
        Dim list_id As New List(Of String)

        'Dim tmp_dt As DataTable = dg.DataSource

        Dim str_name As String = ""
        For Each row As DataGridViewRow In dg.Rows
            If row.Cells(sel).Value IsNot Nothing Then
                If row.Cells(sel).Value.ToString = "True" Then
                    list_name.Add(row.Cells(name).Value.ToString)
                    list_id.Add(row.Cells(pk_name).Value.ToString)
                End If
            End If
        Next
        If list_id.Count = 0 Then
            If noRecordMessage <> "*no message*" Then
                MsgBox(noRecordMessage, MsgBoxStyle.Information, "No record selected.")
            End If
            Return arr_id
        End If
        For i As Integer = 0 To list_name.Count - 1
            str_name &= String.Format(Environment.NewLine & (i + 1) & ". {0}", list_name(i))
        Next
        If withMessage Then
            Dim flag = MsgBox(msg & If(listRecords, Environment.NewLine & str_name, ""), MsgBoxStyle.OkCancel, "Delete")
            If flag = MsgBoxResult.Ok Then
                arr_id = list_id.ToArray
            End If
        Else
            arr_id = list_id.ToArray
        End If
        Return arr_id

    End Function
    ''' <summary>
    ''' Use to get the records inside the DataGridView
    ''' </summary>
    ''' <param name="pk_name">PrimaryKey Name</param>
    ''' <param name="name">Name of field to be list.</param>
    ''' <param name="sel">CheckBox inside the grid which will be check if checked.</param>
    ''' <param name="dg">DataGridView where the cursor will check.</param>
    ''' <param name="list_name">Return list of name.</param>
    ''' <param name="msg">The message that you want to show.</param>
    ''' <param name="withMessage">If the message will be show.</param>
    ''' <param name="noRecordMessage">If there is no record selected.</param>
    ''' <param name="listRecords">Will the message list the records?</param>
    ''' <returns>Array of string. This are the Ids that will be process. Example to be delete.</returns>
    ''' <remarks>~/raymond; 2017-10-17</remarks>
    Public Shared Function getCheckedGridV1(ByVal pk_name As String, ByVal name As String, ByVal sel As String, ByVal dg As DataGridView, ByRef list_name As List(Of String), Optional msg As String = "This are the selected record(s).", Optional withMessage As Boolean = True, Optional noRecordMessage As String = "Select Record First", Optional listRecords As Boolean = True) As String()
        Dim arr_id() As String = {}
        Dim list_id As New List(Of String)

        'Dim tmp_dt As DataTable = dg.DataSource

        Dim str_name As String = ""
        For Each row As DataGridViewRow In dg.Rows
            If row.Cells(sel).Value.ToString = "True" Then
                list_name.Add(row.Cells(name).Value.ToString)
                list_id.Add(row.Cells(pk_name).Value.ToString)
            End If
        Next
        If list_id.Count = 0 Then
            MsgBox(noRecordMessage, MsgBoxStyle.Information, "No record selected.")
            Return arr_id
        End If
        For i As Integer = 0 To list_name.Count - 1
            str_name &= String.Format(Environment.NewLine & (i + 1) & ". {0}", list_name(i))
        Next
        If withMessage Then
            Dim flag = MsgBox(msg & If(listRecords, Environment.NewLine & str_name, ""), MsgBoxStyle.OkCancel, "Delete")
            If flag = MsgBoxResult.Ok Then
                arr_id = list_id.ToArray
            End If
        Else
            arr_id = list_id.ToArray
        End If
        Return arr_id
    End Function

    ''' <summary>
    ''' Check if the data is exist inside the datagrid
    ''' </summary>
    ''' <param name="Grid">Datagrid where the data will be check.</param>
    ''' <param name="PrimaryKey">(1) The column name (2) The key or value of primary key</param>
    ''' <param name="Column">The column to be check</param>
    ''' <param name="Value">The value of columns. NOTE: The length must be equal to the length of the column</param>
    ''' <param name="IsInsert">To test if the module is in Insert or update mode</param>
    ''' <param name="Sensitive">If true the function will check if all columns are required</param>
    ''' <returns>Boolean : True if exist else False</returns>
    ''' <remarks>raymond - 2016-05-31</remarks>
    Public Shared Function DataExist(ByVal Grid As Object, ByVal PrimaryKey() As String, ByVal Column() As String, ByVal Value() As String, Optional IsInsert As Boolean = True, Optional Sensitive As Boolean = True) As Boolean
        Dim exist As Boolean = False
        Dim existing As Integer = 0

        Dim dt As DataTable = Grid.DataSource
        Dim availableRows = Nothing
        If dt.Columns.Contains("deleted") Then
            availableRows = dt.Select("deleted <> 'True'")
        Else
            availableRows = dt.Rows
        End If
        For Each row As DataRow In availableRows
            existing = 0
            For i As Integer = 0 To Column.Length - 1
                If Trim(row.Item(Column(i).ToString).ToString).ToLower = Trim(Value(i).ToString).ToLower Then
                    existing += 1
                End If
            Next
            If IsInsert Then
                If Sensitive Then
                    If existing > 0 Then
                        exist = True
                    End If
                Else
                    If existing = Column.Length Then
                        exist = True
                    End If
                End If
            Else
                If Trim(row.Item(PrimaryKey(0).ToString).ToString).ToLower <> Trim(PrimaryKey(1).ToString).ToLower Then
                    If Sensitive Then
                        If existing > 0 Then
                            exist = True
                        End If
                    Else
                        If existing = Column.Length Then
                            exist = True
                        End If
                    End If
                End If
            End If
        Next
        Return exist
    End Function
    Public Shared Function recordExist(ByVal dg As DataGridView, ByVal pk() As String, ByVal col() As String, ByVal val() As String, Optional both As Boolean = False) As Boolean
        Dim flag As Boolean = False
        Dim exist As Integer = 0
        Dim dt As DataTable = dg.DataSource
        For Each row As DataRow In dt.Rows
            If row.Item(pk(0)).ToString = pk(1) Then
                exist = 0
                For i As Integer = 0 To col.Length - 1
                    If Not both Then
                        If (CType(row.Item(col(i).ToString), Decimal) <> 0) And (CType(val(i), Decimal) <> 0) Then
                            flag = True
                        End If
                    Else
                        If row.Item(col(i)) = val(i) Then
                            exist += 1
                        End If
                    End If
                Next
                If exist >= col.Length Then
                    flag = True
                End If
            End If
        Next
        Return flag
    End Function
    'Public Shared Function amount_words(s As Decimal, Optional DecimalPlaces As Integer = 2) As String
    '    Dim words As String = ""
    '    Dim th(5) As String
    '    th(0) = ""
    '    th(1) = "THOUSAND"
    '    th(2) = "MILLION"
    '    th(3) = "BILLION"
    '    th(4) = "TRILLION"
    '    Dim dg(10) As String
    '    dg(0) = "ZERO"
    '    dg(1) = "ONE"
    '    dg(2) = "TWO"
    '    dg(3) = "THREE"
    '    dg(4) = "FOUR"
    '    dg(5) = "FIVE"
    '    dg(6) = "SIX"
    '    dg(7) = "SEVEN"
    '    dg(8) = "EIGHT"
    '    dg(9) = "NINE"
    '    Dim tn(10) As String
    '    tn(0) = "TEN"
    '    tn(1) = "ELEVEN"
    '    tn(2) = "TWELVE"
    '    tn(3) = "THIRTEEN"
    '    tn(4) = "FOURTEEN"
    '    tn(5) = "FIFTEEN"
    '    tn(6) = "SIXTEEN"
    '    tn(7) = "SEVENTEEN"
    '    tn(8) = "EIGHTEEN"
    '    tn(9) = "NINETEEN"
    '    Dim tw(8) As String
    '    tw(0) = "TWENTY"
    '    tw(1) = "THIRTY"
    '    tw(2) = "FORTY"
    '    tw(3) = "FIFTY"
    '    tw(4) = "SIXTY"
    '    tw(5) = "SEVENTY"
    '    tw(6) = "EIGHTY"
    '    tw(7) = "NINETY"

    '    Dim ss As String = s.ToString()
    '    Dim x As Integer = ss.IndexOf(".")
    '    If x = -1 Then x = ss.Length
    '    If x > 15 Then
    '        words = "Number too big."
    '        Return words
    '        Exit Function
    '    End If
    '    'Dim n() As String = ss.Split("")
    '    Dim str As String = ""
    '    Dim sk As Integer = 0
    '    For i = 0 To x - 1
    '        If (x - i) Mod 3 = 2 Then
    '            If ss(i) = "1" Then
    '                str = str & tn(Val(ss(i + 1))) & " "
    '                i = i + 1
    '                sk = 1
    '            ElseIf ss(i) <> "0" Then
    '                str = str & tw(Val(ss(i)) - 2) & " "
    '                sk = 1
    '            End If
    '        ElseIf ss(i) <> "0" Then
    '            str = str & dg(Val(ss(i))) & " "
    '            If (x - i) Mod 3 = 0 Then str = str & "HUNDRED "
    '            sk = 1
    '        End If
    '        If (x - i) Mod 3 = 1 Then
    '            If (sk) Then str = str & th((x - i - 1) / 3) & " "
    '            sk = 0
    '        End If
    '    Next
    '    If x < ss.Length Then
    '        Dim y As Integer = ss.Length
    '        Dim dec As Integer = y - x - 1
    '        If DecimalPlaces <= dec Then
    '            dec = DecimalPlaces
    '        End If
    '        Try
    '            str = str & "AND " & ss.Substring(x + 1, dec) & "/" & "1" & "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000".Substring(0, dec)
    '            'str = str & "AND " & ss.Substring(x + 1, dec) & "/" & "1" & "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000".Substring(0, dec)
    '        Catch ex As Exception
    '            MyDebugging.AddText(ss)
    '            MyDebugging.AddText(x)
    '            MyDebugging.AddText(y)
    '            MyDebugging.AddText(dec)
    '            MyDebugging.AddText(DecimalPlaces)
    '        End Try
    '    End If
    '    words = Regex.Replace(str, "\s+", " ") & " ONLY"

    '    Return words
    'End Function
    Public Shared Function amount_words(s As Decimal, Optional DecimalPlaces As Integer = 2) As String
        Return AmountInWords(s) & " Only"
    End Function
    Public Shared Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
                 As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
        tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                > (CLng(intAmount.ToString.Trim.Length / 3)),
              CLng(intAmount.ToString.Trim.Length / 3) + 1,
                  CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
              (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String =
            {"", "One", "Two", "Three",
              "Four", "Five",
              "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"",
            "Eleven", "Twelve", "Thirteen",
              "Fourteen", "Fifteen",
              "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten",
            "Twenty", "Thirty",
              "Forty", "Fifty", "Sixty",
              "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "",
            "Thousand", "Million",
              "Billion", "Trillion",
              "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount &
            Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, " ", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = AmountInWords(CStr(CLng(nAmount) -
              (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount &
            tempDecValue : tempDecValue = String.Empty
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount =
              Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100),
              wAmount.Trim & " Pesos And ", 1)) & " Centavos"
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered: " & ex.Message,
          "Convert Numbers To Words",
          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount =
      IIf(InStr(wAmount.Trim.ToLower, "pesos"),
      wAmount.Trim, wAmount.Trim & " Pesos")

        'Display the result
        Return wAmount
    End Function
    Public Shared Sub DisableControl(ByRef frm As Object)

        Dim form As Form = CType(frm, Form)
        If form.Controls.Find("btnhdr1", False).Count > 0 Then form.Controls("btnhdr1").Visible = True
        If form.Controls.Find("btnhdr2", False).Count > 0 Then form.Controls("btnhdr2").Visible = False

        Dim hdr As Panel = form.Controls("hdr")
        Dim ctrl As Control
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            Else
                If Not TypeOf ctrl Is Label Then
                    ctrl.Enabled = False
                End If
            End If
        Next
    End Sub
    Public Shared Sub EnableControl(ByRef frm As Object)

        Dim form As Form = CType(frm, Form)
        If form.Controls.Find("btnhdr1", False).Count > 0 Then form.Controls("btnhdr1").Visible = False
        If form.Controls.Find("btnhdr2", False).Count > 0 Then form.Controls("btnhdr2").Visible = True

        Dim hdr As Panel = form.Controls("hdr")
        Dim ctrl As Control
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.AlwaysDisable Then
                    ctr.Enabled = True
                End If
            Else
                If Not TypeOf ctrl Is Label Then
                    ctrl.Enabled = True
                End If
            End If
        Next
    End Sub
    Public Shared Sub ClearControl(ByRef frm As Object)

        Dim form As Form = CType(frm, Form)
        Dim hdr As Panel = form.Controls("hdr")
        Dim ctrl As Control
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.NoClear Then
                    If ctr.NumberFormat.Substring(0, 1) = "#" Then
                        ctr.DecimalValue = 0.0
                    Else
                        ctr.Text = ""
                        ctr.Value = ""
                    End If
                End If
            End If
            If TypeOf ctrl Is Panel Then
                For Each ctr As Control In ctrl.Controls
                    If TypeOf ctr Is user_control.rdo_button Then
                        Dim ctrx = CType(ctr, user_control.rdo_button)
                        ctrx.Checked = False
                    End If
                Next
            End If
            If TypeOf ctrl Is CheckBox Then
                Dim ctr = CType(ctrl, CheckBox)
                ctr.Checked = False
            End If
            If TypeOf ctrl Is DateTimePicker Then
                Dim ctr = CType(ctrl, DateTimePicker)
                ctr.Value = DateTime.Today
            End If
        Next
    End Sub
    Public Shared Sub BindControl(ByRef frm As Object, dr As DataRow)
        Dim form As Form = CType(frm, Form)
        Dim hdr As Panel = form.Controls("hdr")
        Dim ctrl As Control
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If ctr.ValueSource <> "" Then
                    If ctr.NumberFormat.Substring(0, 1) = "#" Then
                        ctr.DecimalValue = dr(ctr.ValueSource)
                    Else
                        ctr.Value = dr(ctr.ValueSource)
                    End If
                End If
                If ctr.TextSource <> "" Then
                    ctr.Text = dr(ctr.TextSource)
                End If
            End If
            If TypeOf ctrl Is Panel Then
                For Each ctr As Control In ctrl.Controls
                    If TypeOf ctr Is user_control.rdo_button Then
                        Dim ctrx = CType(ctr, user_control.rdo_button)
                        If ctrx.ValueSource <> "" Then
                            If ctrx.Value = dr(ctrx.ValueSource) Then
                                ctrx.Checked = True
                            Else
                                ctrx.Checked = False
                            End If
                        End If
                    End If
                Next
            End If
            If TypeOf ctrl Is DateTimePicker Then
                Dim ctr = CType(ctrl, DateTimePicker)
                ctr.Value = DateTime.Parse(dr(ctr.Name.ToString.Replace("txt_", ""))).ToString
            End If
            If TypeOf ctrl Is CheckBox Then
                Dim ctr = CType(ctrl, CheckBox)
                ctr.Checked = dr(ctr.Name.ToString)
            End If
            'If TypeOf ctrl Is CheckBox Then
            '    Dim ctr = CType(ctrl, CheckBox)
            '    If ctr.ValueSource <> "" Then

            '    End If


            '    ctr.Checked = False
            'End If
        Next
    End Sub
    Public Shared Sub EnableControlDet(ByRef frm As Object)

        Dim form As Form = CType(frm, Form)
        Dim det As Panel = form.Controls("det")
        If form.Controls.Find("btndet1", False).Count > 0 Then
            Dim btndet1 = CType(form.Controls.Find("btndet1", False)(0), Panel)
            For Each ctr As Control In btndet1.Controls
                ctr.Visible = False
            Next
        End If
        Dim btndet2 As New Panel
        If form.Controls.Find("btndet2", False).Count > 0 Then
            btndet2 = CType(form.Controls.Find("btndet2", False)(0), Panel)
        Else
            If det.Controls.Find("btndet2", False).Count > 0 Then
                btndet2 = CType(det.Controls.Find("btndet2", False)(0), Panel)
            End If
        End If
        If btndet2.Controls.Count > 0 Then
            For Each ctr As Control In btndet2.Controls
                ctr.Visible = True
            Next
        End If

        Dim ctrl As Control
        For Each ctrl In det.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.AlwaysDisable Then
                    ctr.Enabled = True
                End If
            End If
            If TypeOf ctrl Is Panel Then
                For Each ctr As Control In ctrl.Controls
                    If TypeOf ctr Is user_control.rdo_button Then
                        Dim ctrx = CType(ctr, user_control.rdo_button)
                        ctrx.Enabled = True
                    End If
                Next
            End If
            If TypeOf ctrl Is DateTimePicker Or TypeOf ctrl Is CheckBox Or TypeOf ctrl Is user_control.rdo_button Then
                ctrl.Enabled = True
            End If
            If TypeOf ctrl Is TextEdit Then
                Dim ctr = CType(ctrl, TextEdit)
                ctr.Enabled = True
                If ctr.Name = "txtvatamount" Then
                    If ctr.FindForm.Name = "setupinputvat" Or ctr.FindForm.Name = "setupoutputvat" Then
                        ctr.Enabled = False
                    End If
                End If
            End If
        Next
    End Sub
    Public Shared Sub DisableControlDet(ByRef frm As Object)

        Dim form As Form = CType(frm, Form)
        Dim det As Panel = form.Controls("det")
        If form.Controls.Find("btndet1", False).Count > 0 Then
            Dim btndet1 = CType(form.Controls.Find("btndet1", False)(0), Panel)
            For Each ctr As Control In btndet1.Controls
                ctr.Visible = True
            Next
        End If
        Dim btndet2 As New Panel
        If form.Controls.Find("btndet2", False).Count > 0 Then
            btndet2 = CType(form.Controls.Find("btndet2", False)(0), Panel)
        Else
            If det IsNot Nothing Then
                If det.Controls.Find("btndet2", False).Count > 0 Then
                    btndet2 = CType(det.Controls.Find("btndet2", False)(0), Panel)
                End If
            End If
        End If
        If btndet2.Controls.Count > 0 Then
            For Each ctr As Control In btndet2.Controls
                ctr.Visible = False
            Next
        End If

        Dim ctrl As Control
        For Each ctrl In det.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.AlwaysEnable Then
                    ctr.Enabled = False
                End If
            End If
            If TypeOf ctrl Is Panel Then
                For Each ctr As Control In ctrl.Controls
                    If TypeOf ctr Is user_control.rdo_button Then
                        Dim ctrx = CType(ctr, user_control.rdo_button)
                        ctrx.Enabled = False
                    End If
                Next
            End If
            If TypeOf ctrl Is DateTimePicker Or TypeOf ctrl Is CheckBox Or TypeOf ctrl Is user_control.rdo_button Then
                ctrl.Enabled = False
            End If
            If TypeOf ctrl Is TextEdit Then
                Dim ctr = CType(ctrl, TextEdit)
                ctr.Enabled = False
            End If
        Next
    End Sub
    Public Shared Sub ClearControlDet(ByRef frm As Object)

        Dim form As Form = CType(frm, Form)
        Dim hdr As Panel = form.Controls("det")
        Dim ctrl As Control
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If Not ctr.NoClear Then
                    If ctr.NumberFormat.Substring(0, 1) = "#" Then
                        ctr.DecimalValue = 0.0
                    Else
                        ctr.Text = ""
                        ctr.Value = ""
                    End If
                End If
            End If
            If TypeOf ctrl Is Panel Then
                For Each ctr As Control In ctrl.Controls
                    If TypeOf ctr Is user_control.rdo_button Then
                        Dim ctrx = CType(ctr, user_control.rdo_button)
                        ctrx.Checked = False
                    End If
                Next
            End If
            If TypeOf ctrl Is CheckBox Then
                Dim ctr = CType(ctrl, CheckBox)
                ctr.Checked = False
            End If
            If TypeOf ctrl Is DateTimePicker Then
                Dim ctr = CType(ctrl, DateTimePicker)
                ctr.Value = DateTime.Today
            End If
            If TypeOf ctrl Is TextEdit Then
                Dim ctr = CType(ctrl, TextEdit)
                ctr.EditValue = Nothing
                If ctr.Properties.DisplayFormat.ToString <> "" Then
                    ctr.EditValue = 0.0
                End If
            End If
        Next
    End Sub
    Public Shared Sub BindControlDet(ByRef frm As Object, dr As DataRow)
        Dim form As Form = CType(frm, Form)
        Dim hdr As Panel = form.Controls("det")
        Dim ctrl As Control
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If ctr.ValueSource <> "" Then
                    If ctr.NumberFormat.Substring(0, 1) = "#" Then
                        ctr.DecimalValue = dr(ctr.ValueSource).ToString
                    Else
                        ctr.Value = dr(ctr.ValueSource).ToString
                    End If
                End If
                If ctr.TextSource <> "" Then
                    ctr.Text = dr(ctr.TextSource).ToString
                End If
            End If
            If TypeOf ctrl Is Panel Then
                For Each ctr As Control In ctrl.Controls
                    If TypeOf ctr Is user_control.rdo_button Then
                        Dim ctrx = CType(ctr, user_control.rdo_button)
                        If ctrx.ValueSource <> "" Then
                            If ctrx.Value = dr(ctrx.ValueSource) Then
                                ctrx.Checked = True
                            Else
                                ctrx.Checked = False
                            End If
                        End If
                    End If
                Next
            End If
            If TypeOf ctrl Is DateTimePicker Then
                Dim ctr = CType(ctrl, DateTimePicker)
                If dr(ctr.Name.ToString.Replace("txt_", "")) Is DBNull.Value Then
                    ctr.Value = Today
                Else
                    If dr(ctr.Name.ToString.Replace("txt_", "")) Is Nothing Then
                        ctr.Value = Today
                    Else
                        If dr(ctr.Name.ToString.Replace("txt_", "")).ToString = "" Then
                            ctr.Value = Today
                        Else
                            ctr.Value = DateTime.Parse(dr(ctr.Name.ToString.Replace("txt_", ""))).ToString
                        End If
                    End If
                End If
            End If
            If TypeOf ctrl Is CheckBox Then
                Dim ctr = CType(ctrl, CheckBox)
                ctr.Checked = dr(ctr.Name.ToString)
            End If
            If TypeOf ctrl Is user_control.rdo_button Then
                Dim ctr = CType(ctrl, user_control.rdo_button)
                If ctr.Value = dr(ctr.ValueSource) Then
                    ctr.Checked = True
                Else
                    ctr.Checked = False
                End If
            End If
            If TypeOf ctrl Is TextEdit Then
                Dim ctr = CType(ctrl, TextEdit)
                If ctr.Tag.ToString <> "" Then
                    If dr.Table.Columns.Contains(ctr.Tag.ToString) Then
                        ctr.EditValue = dr.Item(ctr.Tag.ToString)
                    End If
                End If
            End If
            'If TypeOf ctrl Is CheckBox Then
            '    Dim ctr = CType(ctrl, CheckBox)
            '    If ctr.ValueSource <> "" Then

            '    End If


            '    ctr.Checked = False
            'End If
        Next
    End Sub

    Public Shared Function crypt(ByVal str As String) As String
        Return Cryptor.getHaval256(str)
    End Function

    'Public Shared Function crypt(ByVal mSTRING As String) As String
    '    Dim mSTRING2 As String
    '    Dim mLEN As Integer
    '    Dim mCHAR As String
    '    Dim mCHAR2 As String
    '    Dim mCTR As Integer
    '    Dim mCTR2 As Integer
    '    Dim mBIN As String
    '    Dim mBIN2 As String

    '    mSTRING2 = ""
    '    mLEN = Len(mSTRING)
    '    mCTR = 0
    '    Do While mCTR < mLEN
    '        mCHAR = mSTRING.Substring(mCTR, 1)
    '        mBIN = Binary(Asc(mCHAR))
    '        mCTR2 = 0
    '        mBIN2 = ""
    '        Do While mCTR2 < 8
    '            mCHAR2 = mBIN.Substring(mCTR2, 1)
    '            mBIN2 = mBIN2 & IIf(mCHAR2 = "1", "0", "1")
    '            mCTR2 = mCTR2 + 1
    '        Loop
    '        mBIN2 = Right(mBIN2, 4) & Left(mBIN2, 4)
    '        mSTRING2 = Chr(_Decimal(mBIN2)) & mSTRING2
    '        mCTR = mCTR + 1
    '    Loop
    '    Return mSTRING2
    'End Function

    Public Shared Function decrypt(ByVal mSTRING As String) As String
        Dim mSTRING2 As String
        Dim mLEN As Integer
        Dim mCHAR As String
        Dim mCHAR2 As String
        Dim mBIN As String
        Dim mCTR As Integer
        Dim mCTR2 As Integer
        Dim mBIN2 As String

        mSTRING2 = ""
        mLEN = Len(mSTRING)
        mCTR = mLEN - 1
        Do While mCTR >= 0
            mCHAR = mSTRING.Substring(mCTR, 1)
            mBIN = Binary(Asc(mCHAR))
            mCTR2 = 0
            mBIN2 = ""
            Do While mCTR2 < 8
                mCHAR2 = mBIN.Substring(mCTR2, 1)
                mBIN2 = mBIN2 & IIf(mCHAR2 = "0", "1", "0")
                mCTR2 = mCTR2 + 1
            Loop
            mBIN2 = Right(mBIN2, 4) & Left(mBIN2, 4)
            mSTRING2 = mSTRING2 & Chr(_Decimal(mBIN2))
            mCTR = mCTR - 1
        Loop
        Return mSTRING2
    End Function

    Public Shared Function Binary(ByVal mDECIM As Integer) As String
        Dim mBIN As String
        Dim mDIVI As Decimal

        mBIN = ""
        Do While mDECIM >= 1
            mDIVI = mDECIM / 2
            If mDIVI = Int(mDECIM / 2) Then
                mBIN = "0" & mBIN
            Else
                mBIN = "1" & mBIN
            End If
            mDECIM = Int(mDIVI)
        Loop
        mBIN = mBIN.PadLeft(8, "0")
        Return mBIN
    End Function
    Public Shared Function _Decimal(ByVal mBIN As String) As Integer
        Dim mDECI As Integer
        Dim mCTR As Integer
        Dim mLEN As Integer
        Dim mDCTR As Integer
        Dim mSW As Integer

        mSW = 1
        mLEN = Len(mBIN)
        mDECI = 0
        mDCTR = 1
        mCTR = mLEN - 1
        Do While mCTR >= 0
            If mBIN.Substring(mCTR, 1) = "1" Then
                mDECI = mDECI + mDCTR
            End If
            If mSW = 1 Then
                mDCTR = mDCTR + 1
                mSW = 0
            Else
                mDCTR = mDCTR * 2
            End If
            mCTR = mCTR - 1
        Loop
        Return mDECI
    End Function
    'raymond - 2016-05-12
    Public Shared Sub showForm(ByVal obj As Object, ByVal form As Form)
        Try
            Dim par As System.Reflection.PropertyInfo = obj.GetType.GetProperty("MdiParent")
            If Not par Is Nothing Then
                par.SetValue(obj, form)
            End If
        Catch
        End Try
        obj.Show()
    End Sub
    ''' <summary>
    ''' Change the color to red if deleted and white if not.
    ''' </summary>
    ''' <param name="dg">Target DataGridView</param>
    ''' <param name="pk">Primary Key name</param>
    ''' <param name="name">To show on the list on prompt</param>
    ''' <param name="sel">Checkbox</param>
    ''' <param name="ds">Dataset to compare</param>
    ''' <remarks>~/raymond; - 2016-06-29</remarks>
    Public Shared Sub toggleDelete(ByVal dg As DataGridView, ByVal pk As String, ByVal name As String, ByVal sel As String, ByVal ds As DataSet, Optional deleted As String = "deleted")

        Dim dtOfdg As DataTable = dg.DataSource
        Dim dt_name As String = dtOfdg.TableName

        Dim dt As New DataTable
        dt.TableName = dt_name
        dt = dtOfdg.Copy

        Dim arr_id = getCheckedGrid(pk, name, sel, dg, "", True)
        If arr_id.Length > 0 Then
            For i As Integer = 0 To arr_id.Length - 1
                Dim dr As DataRow = dt.Select(pk & " = '" & arr_id(i) & "'")(0)
                dr.Item("deleted") = True
                'dr.Item(deleted) = Not dr.Item(deleted)
            Next
        End If

        ds.Tables(dt_name).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dt_name).ImportRow(row)
        Next
        'dg.DataSource = ds.Tables(dt_name)
        loadDTToDG(dg, ds.Tables(dt_name))


        'For Each dr As DataGridViewRow In dg.Rows
        '    For Each cell As DataGridViewCell In dr.Cells
        '        If dr.Cells(deleted).Value Then
        '            cell.Style.BackColor = System.Drawing.Color.Red
        '        Else
        '            cell.Style.BackColor = System.Drawing.Color.White
        '        End If
        '    Next
        'Next

    End Sub
    ''' <summary>
    ''' Delete the header transaction
    ''' </summary>
    ''' <param name="grid">The main DataGridView</param>
    ''' <param name="db">Database ["FileSetup","Main"]</param>
    ''' <param name="tbl">Table</param>
    ''' <param name="pk">PrimaryKey in table</param>
    ''' <param name="checkboxname">Optional : Name of CheckBox</param>
    ''' <remarks>raymond - 2017-04-19</remarks>
    Public Shared Sub deleteHeader(ByVal grid As DataGridView, ByVal db As String, ByVal tbl As String, ByVal pk As String, Optional checkboxname As String = "sel", Optional log_id As String = "0")
        Dim ids As String = ""
        Dim cellPK As String = ""
        Dim cellCheckbox As String = ""
        For Each col As DataGridViewColumn In grid.Columns
            If col.DataPropertyName = pk Then
                cellPK = col.Name
            End If
            If col.DataPropertyName = checkboxname Then
                cellCheckbox = col.Name
            End If
        Next
        For Each row As DataGridViewRow In grid.Rows
            If row.Cells(cellCheckbox).Value Then
                'ids &= "," & row.Cells(cellPK).Value
                ids &= row.Cells(cellPK).Value.ToString & "|"
            End If
        Next
        If ids <> "" Then
            Dim sql As String = ""
            If log_id <> "0" Then
                sql = ATGenerateQuery("Remove", tbl, Nothing, Environment.MachineName, Environment.UserName, log_id, ids, pk)
            Else
                sql = String.Format("DELETE FROM {0}.{1} WHERE {2} IN ({3});", db, tbl, pk, ids.Substring(1))
            End If
            Dim dt = Nothing
            If db = _serverDBFS Then
                dt = FsQuery(sql)
            Else
                dt = Query(sql)
            End If
            If TypeOf dt Is MySql.Data.MySqlClient.MySqlException Then
                If dt.Number = 1451 Then
                    MsgBox("Transaction unable to Delete.")
                End If
            Else
                MsgBox("Transaction deleted.")
            End If
        Else
            MsgBox("No Transaction Selected.")
        End If
    End Sub
    'raymond - 2016-05-11
    Public Shared Function dgProcess(ByVal grid As DataGridView, ByVal tbl As String, ByVal pk As String, ByVal fk() As String, Optional arrStr() As String = Nothing, Optional dbTrans As String = "", Optional tblTrans As String = "", Optional pkTrans As String = "", Optional fkTrans As String = "", Optional log_id As String = "0") As String
        'grid = child grid
        'tbl = string,table name of database
        'pk = primary key
        'fk = first parameter is column name,2nd parameter is value
        'arrStr = optional,this will remove columns which are not needed

        Dim str As String = ""
        Dim dt As DataTable = grid.DataSource
        Dim ctrExist As Integer = 0

        For Each row As DataRow In dt.Rows
            Dim dic As New Dictionary(Of String, String)
            For Each col As DataColumn In dt.Columns
                If col.ColumnName = pk Then
                    If row.Item(pk).ToString = "0" Then
                        row.Item(pk) = ""
                    End If
                End If
                If col.ColumnName = fk(0) Then
                    row.Item(fk(0)) = fk(1)
                End If
                Dim indx As Integer = arrStr.ToList().IndexOf(col.ColumnName)
                If indx = -1 Then
                    If col.DataType = System.Type.GetType("System.Boolean") Then
                        dic.Add(col.ColumnName, If(row.Item(col.ColumnName).ToString = "True", 1, 0))
                    Else
                        dic.Add(col.ColumnName, row.Item(col.ColumnName).ToString)
                    End If
                End If
            Next

            If row.Item(pk).ToString.Contains("tmp_") Then
                row.Item(pk) = ""
            End If

            If row.Item(pk) = "" Then
                'insert
                dic.Remove("sel")
                dic.Remove("sel1")
                dic.Remove("sel2")
                'dic.Remove(pk)
                If Not row.Item("deleted") Then
                    dic.Remove("deleted")
                    If log_id <> "0" Then
                        str &= ATGenerateQuery("Insert", tbl, dic, Environment.MachineName, Environment.UserName, log_id, row.Item(pk).ToString, pk)
                    Else
                        str &= genInsert(tbl, dic) & ";"
                    End If
                End If
            Else
                'update
                dic.Remove("sel")
                dic.Remove("sel1")
                dic.Remove("sel2")
                If row.Item("deleted") Then
                    If dbTrans <> "" Then
                        If isExistInTransaction(dbTrans, tblTrans, pkTrans, fkTrans, dic.Item(pk)) Then
                            ctrExist += 1
                        Else
                            If log_id <> "0" Then
                                str &= ATGenerateQuery("Remove", tbl, Nothing, Environment.MachineName, Environment.UserName, log_id, row.Item(pk).ToString & "|", pk)
                            Else
                                str &= String.Format("DELETE FROM {0} WHERE {1} = {2};", tbl, pk, dic.Item(pk))
                            End If
                        End If
                    Else
                        If log_id <> "0" Then
                            str &= ATGenerateQuery("Remove", tbl, dic, Environment.MachineName, Environment.UserName, log_id, row.Item(pk).ToString, pk)
                        Else
                            str &= String.Format("DELETE FROM {0} WHERE {1} = {2};", tbl, pk, dic.Item(pk))
                        End If
                    End If
                Else
                    dic.Remove("deleted")
                    If log_id <> "0" Then
                        str &= ATGenerateQuery("Update", tbl, dic, Environment.MachineName, Environment.UserName, log_id, row.Item(pk).ToString, pk)
                    Else
                        str &= genUpdate(tbl, dic) & ";"
                    End If
                End If
            End If
        Next
        If dbTrans <> "" Then
            If ctrExist > 0 Then
                MsgBox("Not all selected records are delted. There are record(s) that are already used in other transaction and cannot be delete.", MsgBoxStyle.Critical, "Unable to Delete")
            End If
        End If
        Return str
    End Function
    'raymond - 2016-05-10
    Public Shared Sub bind_form(ByVal form As Object)
        For Each controls As Control In form.Controls
            Dim tag As String = controls.Tag
            If tag Is Nothing Then
                tag = ""
            End If
            If tag.Contains("subContainer") Then
                For Each ctrl As Control In controls.Controls
                    Dim _tag As String = ctrl.Tag
                    If _tag Is Nothing Then
                        _tag = ""
                    End If
                    Select Case True
                        Case _tag.Contains("btn-sub-insert")
                            AddHandler ctrl.Click, AddressOf btn_sub_insert
                        Case _tag.Contains("btn-sub-update")
                            AddHandler ctrl.Click, AddressOf btn_sub_update
                        Case _tag.Contains("btn-sub-ok")
                            AddHandler ctrl.Click, AddressOf btn_sub_ok
                        Case _tag.Contains("btn-sub-cancel")
                            AddHandler ctrl.Click, AddressOf btn_sub_cancel
                    End Select
                Next
            ElseIf controls.HasChildren Then
                bind_form(controls)
            End If
        Next
    End Sub
    Private Shared Sub btn_sub_insert(ByVal sender As Object, ByVal e As EventArgs)
        clear_subcontrol(sender)
        enable_subcontrol(sender, "insert")
    End Sub
    Private Shared Sub btn_sub_update(ByVal sender As Object, ByVal e As EventArgs)
        Dim form As Object
        If sender.Tag.ToString.Contains("subContainer") Then
            form = sender
        Else
            form = sender.Parent
        End If
        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is DataGridView Then
                Dim dg = CType(ctrl, DataGridView)
                If dg.SelectedRows.Count > 0 Then
                    enable_subcontrol(sender, "update")
                End If
            End If
        Next
    End Sub
    Private Shared Sub btn_sub_ok(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn = CType(sender, Button)
        Dim txt_pk As user_control.textbox = findTag(btn, "pk")
        Dim transmode = CType(findTag(btn, "transmode"), user_control.textbox)
        Dim dg As New DataGridView
        Dim err As Boolean = False

        Dim col As New List(Of String)
        Dim val As New List(Of String)
        If requiredChecker(btn.Parent) Then
            MsgBox("Required field cannot be empty.")
            Exit Sub
        End If
        For Each ctrl As Control In btn.Parent.Controls
            Dim tag As String = ctrl.Tag

            If tag Is Nothing Then
                tag = ""
            End If

            If TypeOf ctrl Is DataGridView Then
                dg = ctrl
            End If

            If tag.Contains("fk") Then
                If TypeOf ctrl Is user_control.textbox Then
                    Dim txtbox = CType(ctrl, user_control.textbox)
                    If txtbox.ValueSource <> Nothing Then
                        col.Add(txtbox.ValueSource)
                        val.Add(txtbox.Value)
                    End If
                    If txtbox.TextSource <> Nothing Then
                        col.Add(txtbox.TextSource)
                        val.Add(txtbox.Text)
                    End If
                    If txtbox.TextSource = Nothing And txtbox.ValueSource = Nothing Then
                        col.Add(txtbox.Name.ToString.Replace("txt_", ""))
                        val.Add(txtbox.Text)
                    End If
                ElseIf TypeOf ctrl Is Panel Or TypeOf ctrl Is GroupBox Then
                    col.Add(ctrl.Name.ToString.Replace("txt_", ""))
                    val.Add(getRdoValue(ctrl))
                ElseIf TypeOf ctrl Is CheckBox Then
                    Dim chkbox = CType(ctrl, CheckBox)
                    col.Add(ctrl.Name.ToString.Replace("txt_", ""))
                    val.Add(chkbox.Checked)
                Else
                    col.Add(ctrl.Name.ToString.Replace("txt_", ""))
                    val.Add(ctrl.Text)
                End If
            End If
        Next

        If transmode.Value = "insert" Then
            If DataExist(dg, {txt_pk.Name.ToString.Replace("txt_", ""), txt_pk.Value}, col.ToArray, val.ToArray) Then
                err = True
            End If
        Else
            If DataExist(dg, {txt_pk.Name.ToString.Replace("txt_", ""), txt_pk.Value}, col.ToArray, val.ToArray, False) Then
                err = True
            End If
        End If

        If err Then
            MsgBox("Record already exist")
        Else
            dgSave(sender)
            'clear_subcontrol(sender)
            disable_subcontrol(sender, "")
        End If
    End Sub
    Private Shared Sub btn_sub_cancel(ByVal sender As Object, ByVal e As EventArgs)
        clear_subcontrol(sender)
        disable_subcontrol(sender, "")
        If TypeOf sender Is Button Then
            Dim btn = CType(sender, Button)
            Dim parent = btn.Parent
            For Each ctrl As Control In parent.Controls
                If TypeOf ctrl Is System.Windows.Forms.DataGridView Then
                    Dim dg = CType(ctrl, DataGridView)
                    If dg.Rows.Count > 0 Then
                        If dg.SelectedRows.Count > 0 Then
                            Dim selectedRow = dg.SelectedRows
                            dg.ClearSelection()
                            selectedRow(0).Selected = False
                            selectedRow(0).Selected = True
                        End If
                    End If
                End If
            Next
        End If
    End Sub
    Private Shared Sub dgSave(ByVal obj As Object)
        'para makuha ang parent  ng button
        Dim form As Object = obj.parent

        'pangkuha ng datagrid sa loob ng parent
        Dim dgView As DataGridView = Nothing
        For Each c As Control In form.Controls
            If TypeOf c Is System.Windows.Forms.DataGridView Then
                Dim ctrl = CType(c, System.Windows.Forms.DataGridView)
                dgView = ctrl
            End If
        Next

        'pangkuha ng transmode
        Dim transmode = CType(findTag(obj, "transmode"), user_control.textbox)
        Dim pk_name = CType(findTag(obj, "pk"), user_control.textbox).Name.ToString.Replace("txt_", "")

        Dim dt As DataTable = dgView.DataSource
        Dim newdr As DataRow = dt.NewRow

        If transmode.Value = "insert" Then
            For Each col As DataColumn In dt.Columns
                If form.Controls.Find("txt_" & col.ColumnName, False).Length > 0 Then
                    Dim t = form.Controls.Find("txt_" & col.ColumnName, False)(0)
                    Dim t1 = CType(t, user_control.textbox)
                    If t1.ValueSource <> "" Then
                        newdr(t1.ValueSource) = t1.Value
                    End If
                    If t1.TextSource <> "" Then
                        newdr(t1.TextSource) = t1.Text
                    End If
                    If t1.TextSource = "" And t1.ValueSource = "" Then
                        newdr(col.ColumnName) = If(t1.Text = "", 0, t1.Text)
                    End If
                    If t1.NumberFormat.Substring(0, 1) = "#" Then
                        newdr(col.ColumnName) = t1.DecimalValue
                    End If
                    If t1.Name = "txt_" & pk_name Then
                        newdr(col.ColumnName) = "tmp_" & Now.ToString("yyyyMMddHHmmss")
                    End If
                Else
                    If col.ColumnName.ToString = "sel" Or col.ColumnName.ToString = "sel1" Or col.ColumnName.ToString = "sel2" Or col.ColumnName.ToString = "sel3" Then
                        newdr(col.ColumnName) = False
                    Else
                        newdr(col.ColumnName) = 0
                    End If
                End If
            Next

            dt.Rows.Add(newdr)
            loadDTToDG(dgView, dt)
        ElseIf transmode.Value = "update" Then
            Dim selectedRow = dgView.SelectedRows(0)
            For Each col As DataColumn In dt.Columns
                If form.Controls.Find("txt_" & col.ColumnName, False).Length > 0 Then
                    Dim t = form.Controls.Find("txt_" & col.ColumnName, False)(0)
                    Dim t1 = CType(t, user_control.textbox)
                    If t1.ValueSource <> "" Then
                        selectedRow.Cells(t1.ValueSource).Value = t1.Value
                    End If
                    If t1.TextSource <> "" Then
                        selectedRow.Cells(t1.TextSource).Value = t1.Text
                    End If
                    If t1.TextSource = "" And t1.ValueSource = "" Then
                        selectedRow.Cells(col.ColumnName).Value = t1.Text
                    End If
                    If t1.NumberFormat.Substring(0, 1) = "#" Then
                        selectedRow.Cells(col.ColumnName).Value = t1.DecimalValue
                    End If
                Else
                    If dgView.Columns.Contains(col.ColumnName) Then
                        If selectedRow.Cells(col.ColumnName).FormattedValueType.ToString = "System.Boolean" Then
                            selectedRow.Cells(col.ColumnName).Value = False
                        Else
                            selectedRow.Cells(col.ColumnName).Value = Nothing
                        End If
                    End If
                End If
            Next
        End If
        'For Each c As Control In form.Controls
        '    If TypeOf c Is System.Windows.Forms.DataGridView Then
        '        Dim ctrl = CType(c, System.Windows.Forms.DataGridView)
        '        For i As Integer = 0 To ctrl.Columns.Count - 1
        '            If form.Controls.Find(ctrl.Columns(i).Name.ToString, False).Length > 0 Then
        '                Dim t = form.Controls.Find(ctrl.Columns(i).Name.ToString, False)(0)
        '                Dim t1 = CType(t, user_control.textbox)
        '                dic.Add(ctrl.Columns(i).Name.ToString, t1.Value)
        '            Else
        '                dic.Add(ctrl.Columns(i).Name.ToString, "")
        '            End If
        '        Next
        '    End If
        'Next


    End Sub
    Private Shared Function findTag(ByVal obj As Object, ByVal str As String) As Control
        Dim form As Object = obj.Parent
        Dim txtbox As Object = Nothing
        For Each control As Control In form.Controls
            Dim tag As String = control.Tag
            If tag Is Nothing Then
                tag = ""
            End If
            If tag.Contains(str) Then
                txtbox = control
            End If
        Next
        Return txtbox
    End Function
    Public Shared Sub clear_subcontrol(ByVal button As Object)
        Dim form As Object
        If button.Tag.ToString.Contains("subContainer") Then
            form = button
        Else
            form = button.Parent
        End If
        If form.Tag.ToString.Contains("subContainer") Then
            For Each txtbox As Control In form.Controls
                If TypeOf txtbox Is user_control.textbox Then
                    Dim ctr = CType(txtbox, user_control.textbox)
                    If ctr.NumberFormat.Substring(0, 1) = "#" Then
                        ctr.DecimalValue = 0
                    Else
                        ctr.Text = ""
                    End If
                ElseIf TypeOf txtbox Is System.Windows.Forms.CheckBox Then
                    Dim c1 = CType(txtbox, System.Windows.Forms.CheckBox)
                    c1.Checked = False
                ElseIf TypeOf txtbox Is System.Windows.Forms.Panel Then
                    For Each c1 As Control In txtbox.Controls
                        Dim c2 = CType(c1, user_control.rdo_button)
                        c2.Checked = False
                    Next
                End If
            Next
        End If
    End Sub
    Public Shared Sub enable_subcontrol(ByVal button As Object, Optional transmode As String = "")
        Dim form As Object
        If button.tag.ToString.Contains("subContainer") Then
            form = button
        Else
            form = button.Parent
        End If
        For Each c As Control In form.Controls
            Dim tag As String = c.Tag
            If tag Is Nothing Then
                tag = ""
            End If
            Select Case True
                Case tag.Contains("btn-sub-insert")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btn-sub-update")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btn-sub-remove")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btn-sub-ok")
                    c.Enabled = True
                    c.Visible = True
                Case tag.Contains("btn-sub-cancel")
                    c.Enabled = True
                    c.Visible = True
                Case tag.Contains("sub-grid")
                    c.Enabled = False
            End Select
            If Not (TypeOf c Is System.Windows.Forms.Button) And Not (TypeOf c Is System.Windows.Forms.DataGridView) Then
                If TypeOf c Is user_control.textbox Then
                    Dim c1 = CType(c, user_control.textbox)
                    If Not c1.AlwaysDisable Then
                        c1.Enabled = True
                    End If
                Else
                    c.Enabled = True
                End If
                Dim _tag As String = c.Tag
                If _tag Is Nothing Then
                    _tag = ""
                End If
                If _tag.Contains("focus") Then
                    c.Focus()
                End If
                If _tag.Contains("transmode") Then
                    Dim txt = CType(c, user_control.textbox)
                    txt.Value = transmode
                    txt.Text = transmode
                End If
            End If
        Next
    End Sub
    Public Shared Sub disable_allsubcontrol(ByVal button As Object, Optional transmode As String = "")
        Dim form As Object
        If button.tag.ToString.Contains("subContainer") Then
            form = button
        Else
            form = button.Parent
        End If
        For Each c As Control In form.Controls
            Dim tag As String = c.Tag
            If tag Is Nothing Then
                tag = ""
            End If
            Select Case True
                Case tag.Contains("btn-sub-insert")
                    c.Enabled = False
                    c.Visible = True
                Case tag.Contains("btn-sub-update")
                    c.Enabled = False
                    c.Visible = True
                Case tag.Contains("btn-sub-remove")
                    c.Enabled = False
                    c.Visible = True
                Case tag.Contains("btn-sub-ok")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btn-sub-cancel")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("sub-grid")
                    c.Enabled = False
            End Select
            If Not (TypeOf c Is System.Windows.Forms.Button) And Not (TypeOf c Is System.Windows.Forms.DataGridView) Then
                If TypeOf c Is user_control.textbox Then
                    Dim c1 = CType(c, user_control.textbox)
                    If Not c1.AlwaysEnable Then
                        c1.Enabled = False
                    End If
                Else
                    c.Enabled = False
                End If
                Dim _tag As String = c.Tag
                If _tag Is Nothing Then
                    _tag = ""
                End If
                If _tag.Contains("transmode") Then
                    Dim txt = CType(c, user_control.textbox)
                    txt.Value = transmode
                    txt.Text = transmode
                End If
            End If
        Next
    End Sub
    Public Shared Sub disable_subcontrol(ByVal button As Object, Optional transmode As String = "")
        Dim form As Object
        If button.tag.ToString.Contains("subContainer") Then
            form = button
        Else
            form = button.Parent
        End If
        For Each c As Control In form.Controls
            Dim tag As String = c.Tag
            If tag Is Nothing Then
                tag = ""
            End If
            Select Case True
                Case tag.Contains("btn-sub-insert")
                    c.Enabled = True
                    c.Visible = True
                Case tag.Contains("btn-sub-update")
                    c.Enabled = True
                    c.Visible = True
                Case tag.Contains("btn-sub-remove")
                    c.Enabled = True
                    c.Visible = True
                Case tag.Contains("btn-sub-ok")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btn-sub-cancel")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("sub-grid")
                    c.Enabled = True
            End Select
            If Not (TypeOf c Is System.Windows.Forms.Button) And Not (TypeOf c Is System.Windows.Forms.DataGridView) Then
                If TypeOf c Is user_control.textbox Then
                    Dim c1 = CType(c, user_control.textbox)
                    If Not c1.AlwaysEnable Then
                        c1.Enabled = False
                    End If
                Else
                    c.Enabled = False
                End If
                Dim _tag As String = c.Tag
                If _tag Is Nothing Then
                    _tag = ""
                End If
                If _tag.Contains("transmode") Then
                    Dim txt = CType(c, user_control.textbox)
                    txt.Value = transmode
                    txt.Text = transmode
                End If
            End If
        Next
    End Sub
    ''' <summary>
    ''' Focus the row of DataGridView with the same key.
    ''' </summary>
    ''' <param name="dg">DataGridView the row will be focus.</param>
    ''' <param name="pk">An array of string : First parameter is the PrimaryKey and the second is the value.</param>
    ''' <remarks>~/raymond; - 2016-06-23</remarks>
    Public Shared Sub gridRowFocus(ByVal dg As DataGridView, ByVal pk() As String)
        If dg.Rows.Count > 0 Then
            dg.ClearSelection()
            dg.Rows(0).Selected = True
            For Each row As DataGridViewRow In dg.Rows
                If row.Cells(pk(0)).Value.ToString = pk(1) Then
                    row.Selected = True
                End If
            Next
        End If
    End Sub
    'raymond - 2016-05-06
    Public Shared Sub clear_control(ByVal form As Object)
        For Each c As Control In form.Controls
            Dim tag As String = c.Tag
            If tag Is Nothing Then
                tag = ""
            End If
            If tag.Contains("container") Then
                For Each txtbox As Control In c.Controls
                    If TypeOf txtbox Is user_control.textbox Then
                        Dim ctr = CType(txtbox, user_control.textbox)
                        If Not ctr.NoClear Then
                            If ctr.NumberFormat.Substring(0, 1) = "#" Then
                                ctr.DecimalValue = 0
                            Else
                                ctr.Text = ""
                            End If
                        End If
                    ElseIf TypeOf txtbox Is System.Windows.Forms.CheckBox Then
                        Dim c1 = CType(txtbox, System.Windows.Forms.CheckBox)
                        c1.Checked = False
                    ElseIf TypeOf txtbox Is System.Windows.Forms.Panel Then
                        For Each c1 As Control In txtbox.Controls
                            Dim c2 = CType(c1, user_control.rdo_button)
                            c2.Checked = False
                        Next
                    ElseIf TypeOf txtbox Is System.Windows.Forms.DateTimePicker Then
                        Dim c1 = CType(txtbox, System.Windows.Forms.DateTimePicker)
                        If c1.MaxDate >= DateTime.Now Then
                            c1.Value = DateTime.Now
                        Else
                            c1.Value = c1.MaxDate
                        End If
                    ElseIf TypeOf txtbox Is System.Windows.Forms.TextBox Then
                        Dim c1 = CType(txtbox, System.Windows.Forms.TextBox)
                        c1.Text = ""
                    ElseIf TypeOf txtbox Is user_control.myMaskedTextBox Then
                        Dim c1 = CType(txtbox, user_control.myMaskedTextBox)
                        c1.Text = ""
                    End If
                Next
            End If
            If c.HasChildren Then
                clear_control(c)
            End If
        Next
    End Sub
    Public Shared Sub enable_control(ByVal form As Object)
        For Each c As Control In form.Controls
            Dim tag As String = c.Tag
            If tag Is Nothing Then
                tag = ""
            End If
            Select Case True
                Case tag.Contains("btnView")
                    c.Enabled = True
                Case tag.Contains("btnInsert")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btnUpdate")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btnRemove")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btnSave")
                    c.Enabled = True
                    c.Visible = True
                Case tag.Contains("btnNotSave")
                    c.Enabled = True
                    c.Visible = True
                Case tag.Contains("maingrid")
                    c.Enabled = False
                Case tag.Contains("container")
                    For Each txtbox As Control In c.Controls
                        If TypeOf txtbox Is user_control.textbox Then
                            Dim ctrl = CType(txtbox, user_control.textbox)
                            If Not ctrl.AlwaysDisable Then
                                txtbox.Enabled = True
                            End If
                        ElseIf TypeOf txtbox Is user_control.myMaskedTextBox Then
                            Dim ctrl = CType(txtbox, user_control.myMaskedTextBox)
                            If Not ctrl.AlwaysDisable Then
                                ctrl.Enabled = True
                            End If
                        ElseIf TypeOf txtbox Is DateTimePicker Then
                            txtbox.Enabled = True
                        ElseIf TypeOf txtbox Is CheckBox Then
                            txtbox.Enabled = True
                        ElseIf TypeOf txtbox Is System.Windows.Forms.ComboBox Then
                            txtbox.Enabled = True
                        ElseIf TypeOf txtbox Is NumericUpDown Then
                            txtbox.Enabled = True
                        ElseIf TypeOf txtbox Is user_control.rdo_button Then
                            txtbox.Enabled = True
                        ElseIf TypeOf txtbox Is Label Then
                            txtbox.Enabled = True
                        Else
                            txtbox.Enabled = False
                        End If
                        Dim _tag As String = txtbox.Tag
                        If _tag Is Nothing Then
                            _tag = ""
                        End If
                        If _tag.Contains("focus") Then
                            txtbox.Focus()
                        End If
                    Next
                    c.Enabled = True
            End Select
            If c.HasChildren Or TypeOf c Is GroupBox Then
                enable_control(c)
            End If
        Next
    End Sub
    Public Shared Sub disable_control(ByVal form As Object, Optional dicAction As Dictionary(Of String, Boolean) = Nothing)
        For Each c As Control In form.Controls
            Dim tag As String = c.Tag
            If tag Is Nothing Then
                tag = ""
            End If
            Select Case True
                Case tag.Contains("btnInsert")
                    If dicAction IsNot Nothing Then
                        c.Enabled = dicAction("m_add")
                        c.Visible = dicAction("m_add")
                    Else
                        c.Enabled = True
                        c.Visible = True
                    End If
                Case tag.Contains("btnUpdate")
                    If dicAction IsNot Nothing Then
                        c.Enabled = dicAction("m_edit")
                        c.Visible = dicAction("m_edit")
                    Else
                        c.Enabled = True
                        c.Visible = True
                    End If
                Case tag.Contains("btnRemove")
                    If dicAction IsNot Nothing Then
                        c.Enabled = dicAction("m_delete")
                        c.Visible = dicAction("m_delete")
                    Else
                        c.Enabled = True
                        c.Visible = True
                    End If
                Case tag.Contains("btnPrint")
                    If dicAction IsNot Nothing Then
                        c.Enabled = dicAction("m_print")
                        c.Visible = dicAction("m_print")
                    Else
                        c.Enabled = True
                        c.Visible = True
                    End If
                Case tag.Contains("btnSave")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("btnNotSave")
                    c.Enabled = False
                    c.Visible = False
                Case tag.Contains("maingrid")
                    c.Enabled = True
                Case tag.Contains("container")
                    For Each txtbox As Control In c.Controls
                        If TypeOf txtbox Is user_control.myMaskedTextBox Then
                            Dim ctrl = CType(txtbox, user_control.myMaskedTextBox)
                            If Not ctrl.AlwaysEnable Then
                                ctrl.Enabled = False
                            End If
                        Else
                            txtbox.Enabled = False
                        End If
                        If TypeOf txtbox Is Button Then
                            If txtbox.Tag.ToString.Contains("btnView") Then
                                txtbox.Enabled = True
                            End If
                        ElseIf TypeOf txtbox Is Label Then
                            txtbox.Enabled = True
                        End If
                    Next
            End Select
            If c.HasChildren Then
                disable_control(c, dicAction)
            End If
        Next
    End Sub
    Public Shared Function generateDictionary(ByVal form As Form, ByVal dt As DataTable) As Dictionary(Of String, String)
        Dim dic As New Dictionary(Of String, String)

        For Each col As DataColumn In dt.Columns
            Dim flag = True
            Dim ctr() As Control = form.Controls.Find("txt_" & col.ColumnName, True)
            If ctr.Length > 0 Then
                If TypeOf ctr(0) Is user_control.textbox Then
                    Dim ctrl = CType(ctr(0), user_control.textbox)
                    If dic.ContainsKey(col.ColumnName) Then
                        If ctrl.NumberFormat.Substring(0, 1) = "#" Then
                            dic.Item(col.ColumnName) = ctrl.DecimalValue
                        Else
                            If ctrl.UseSystemPasswordChar Then
                                dic.Item(col.ColumnName) = If(ctrl.Text = "", Nothing, crypt(ctrl.Text))
                            Else
                                dic.Item(col.ColumnName) = If(ctrl.Text = "", Nothing, ctrl.Text)
                            End If
                        End If
                        flag = False
                    Else
                        dic.Add(col.ColumnName, If(ctrl.Text = "", Nothing, ctrl.Text))
                        flag = False
                    End If
                    If ctrl.ValueSource = col.ColumnName Then
                        If dic.ContainsKey(col.ColumnName) Then
                            If ctrl.UseSystemPasswordChar Then
                                dic.Item(col.ColumnName) = If(ctrl.Value = "", Nothing, crypt(ctrl.Value))
                            Else
                                dic.Item(col.ColumnName) = If(ctrl.Value = "", Nothing, ctrl.Value)
                            End If
                            flag = False
                        Else
                            If ctrl.UseSystemPasswordChar Then
                                dic.Add(col.ColumnName, If(ctrl.Value = "", Nothing, crypt(ctrl.Value)))
                            Else
                                dic.Add(col.ColumnName, If(ctrl.Value = "", Nothing, ctrl.Value))
                            End If
                            flag = False
                        End If
                    End If
                    If ctrl.TextSource = col.ColumnName Then
                        If dic.ContainsKey(col.ColumnName) Then
                            If ctrl.UseSystemPasswordChar Then
                                dic.Item(col.ColumnName) = If(ctrl.Text = "", Nothing, crypt(ctrl.Text))
                            Else
                                dic.Item(col.ColumnName) = If(ctrl.Text = "", Nothing, ctrl.Text)
                            End If
                            flag = False
                        Else
                            If ctrl.UseSystemPasswordChar Then
                                dic.Add(col.ColumnName, If(ctrl.Text = "", Nothing, crypt(ctrl.Text)))
                            Else
                                dic.Add(col.ColumnName, If(ctrl.Text = "", Nothing, ctrl.Text))
                            End If
                            flag = False
                        End If
                    End If
                ElseIf TypeOf ctr(0) Is user_control.myMaskedTextBox Then
                    Dim ctrl = CType(ctr(0), user_control.myMaskedTextBox)
                    If dic.ContainsKey(col.ColumnName) Then
                        If dic.ContainsKey(col.ColumnName) Then
                            dic.Item(col.ColumnName) = If(ctrl.Text = "", Nothing, ctrl.Text)
                            flag = False
                        Else
                            dic.Add(col.ColumnName, If(ctrl.Text = "", Nothing, ctrl.Text))
                            flag = False
                        End If
                        If ctrl.ValueSource = col.ColumnName Then
                            If dic.ContainsKey(col.ColumnName) Then
                                dic.Item(col.ColumnName) = If(ctrl.Value = "", Nothing, ctrl.Value)
                                flag = False
                            Else
                                dic.Add(col.ColumnName, If(ctrl.Value = "", Nothing, ctrl.Value))
                                flag = False
                            End If
                        End If
                        If ctrl.TextSource = col.ColumnName Then
                            If dic.ContainsKey(col.ColumnName) Then
                                dic.Item(col.ColumnName) = If(ctrl.Text = "", Nothing, ctrl.Text)
                                flag = False
                            Else
                                dic.Add(col.ColumnName, If(ctrl.Text = "", Nothing, ctrl.Text))
                                flag = False
                            End If
                        End If
                    Else
                        dic.Add(col.ColumnName, If(ctrl.Text = "", Nothing, ctrl.Text))
                        flag = False
                    End If
                ElseIf TypeOf ctr(0) Is System.Windows.Forms.Panel Then
                    Dim ctrl = CType(ctr(0), System.Windows.Forms.Panel)
                    For Each rdo As Control In ctrl.Controls
                        If TypeOf rdo Is user_control.rdo_button Then
                            Dim rdo_btn = CType(rdo, user_control.rdo_button)
                            If rdo_btn.Checked Then
                                If dic.ContainsKey(col.ColumnName) Then
                                    dic.Item(col.ColumnName) = If(rdo_btn.Value = "", Nothing, rdo_btn.Value)
                                    flag = False
                                Else
                                    dic.Add(col.ColumnName, If(rdo_btn.Value = "", Nothing, rdo_btn.Value))
                                    flag = False
                                End If
                            End If
                        End If
                    Next
                ElseIf TypeOf ctr(0) Is System.Windows.Forms.GroupBox Then
                    Dim ctrl = CType(ctr(0), System.Windows.Forms.GroupBox)
                    For Each rdo As Control In ctrl.Controls
                        If TypeOf rdo Is user_control.rdo_button Then
                            Dim rdo_btn = CType(rdo, user_control.rdo_button)
                            If rdo_btn.Checked Then
                                If dic.ContainsKey(col.ColumnName) Then
                                    dic.Item(col.ColumnName) = If(rdo_btn.Value = "", Nothing, rdo_btn.Value)
                                    flag = False
                                Else
                                    dic.Add(col.ColumnName, If(rdo_btn.Value = "", Nothing, rdo_btn.Value))
                                    flag = False
                                End If
                            End If
                        End If
                    Next
                ElseIf TypeOf ctr(0) Is System.Windows.Forms.CheckBox Then
                    Dim ctrl = CType(ctr(0), System.Windows.Forms.CheckBox)
                    Dim _checked = If(ctrl.Checked, 1, 0)
                    If dic.ContainsKey(col.ColumnName) Then
                        dic.Item(col.ColumnName) = _checked
                        flag = False
                    Else
                        dic.Add(col.ColumnName, _checked)
                        flag = False
                    End If
                ElseIf TypeOf ctr(0) Is System.Windows.Forms.DateTimePicker Then
                    Dim ctrl = CType(ctr(0), System.Windows.Forms.DateTimePicker)
                    Dim _date = ctrl.Value.ToString("s")
                    If dic.ContainsKey(col.ColumnName) Then
                        dic.Item(col.ColumnName) = _date
                        flag = False
                    Else
                        dic.Add(col.ColumnName, _date)
                        flag = False
                    End If
                ElseIf TypeOf ctr(0) Is System.Windows.Forms.TextBox Then
                    Dim ctrl = CType(ctr(0), System.Windows.Forms.TextBox)
                    If dic.ContainsKey(col.ColumnName) Then
                        If ctrl.UseSystemPasswordChar Then
                            dic.Item(col.ColumnName) = crypt(ctrl.Text)
                        Else
                            dic.Item(col.ColumnName) = ctrl.Text
                        End If
                        flag = False
                    Else
                        If ctrl.UseSystemPasswordChar Then
                            dic.Add(col.ColumnName, crypt(ctrl.Text))
                        Else
                            dic.Add(col.ColumnName, ctrl.Text)
                        End If
                        flag = False
                    End If
                End If
            End If
            If flag Then
                dic.Add(col.ColumnName, Nothing)
            End If
        Next
        Return dic
    End Function


    Public Shared Function requiredChecker(ByVal container As Object) As Boolean
        Dim flag As Boolean = False
        'Dim err As New ErrorProvider
        For Each control As Control In container.Controls
            If TypeOf control Is user_control.textbox Then
                Dim ctr = CType(control, user_control.textbox)
                If ctr.Required Then
                    If ctr.NumberFormat.Substring(0, 1) = "#" Then
                        If ctr.DecimalValue = 0 Then
                            ctr.Focus()
                            'err.SetError(control, "This is required field and cannot be null")
                            flag = True
                        Else
                            'err.SetError(control, "")
                        End If
                    Else
                        If ctr.Text = "" Then
                            ctr.Focus()
                            'err.SetError(control, "This is required field and cannot be null")
                            flag = True
                        Else
                            'err.SetError(control, "")
                        End If
                    End If
                End If
            End If
            If control.HasChildren Then
                If flag Then
                    Return flag
                Else
                    flag = requiredChecker(control)
                End If
            End If
        Next
        Return flag
    End Function
    Public Shared Sub bind_control(ByVal dgMain As DataGridView, ByVal id As String, ByVal dt As DataTable, ByVal form As Object, Optional panelReject As String = "")
        If dgMain.SelectedRows.Count = 1 Then
            If dgMain.SelectedRows(0).Cells(id).Value <> Nothing Then
                Dim dr() As DataRow = dt.Select(id & " = '" & dgMain.SelectedRows(0).Cells(id).Value.ToString & "'")
                If dr.Length > 0 Then
                    For Each col As DataColumn In dt.Columns
                        If form.Controls.Find("txt_" & col.ColumnName, True).Length > 0 Then
                            Dim ctrl As Control = form.Controls.Find("txt_" & col.ColumnName, True)(0)
                            If ctrl.Parent.Name <> panelReject Then
                                If TypeOf ctrl Is user_control.textbox Then
                                    Dim ctr = CType(ctrl, user_control.textbox)
                                    ctr.Text = dr(0).Item(col.ColumnName).ToString
                                    ctr.Value = dr(0).Item(col.ColumnName).ToString
                                    If ctr.TextSource <> "" Then
                                        ctr.Text = dr(0).Item(ctr.TextSource).ToString
                                    End If
                                    If ctr.ValueSource <> "" Then
                                        ctr.Value = dr(0).Item(ctr.ValueSource).ToString
                                    End If
                                    If ctr.NumberFormat.Substring(0, 1) = "#" Then
                                        ctr.DecimalValue = dr(0).Item(col.ColumnName)
                                    End If
                                ElseIf TypeOf ctrl Is user_control.myMaskedTextBox Then
                                    Dim ctr = CType(ctrl, user_control.myMaskedTextBox)
                                    ctr.Value = dr(0).Item(col.ColumnName).ToString
                                    ctr.Text = dr(0).Item(col.ColumnName).ToString
                                    If ctr.ValueSource <> "" Then
                                        If dt.Columns.Contains(ctr.ValueSource) Then
                                            ctr.Value = dr(0).Item(ctr.ValueSource).ToString
                                        End If
                                    End If
                                    If ctr.TextSource <> "" Then
                                        If dt.Columns.Contains(ctr.TextSource) Then
                                            ctr.Text = dr(0).Item(ctr.TextSource).ToString
                                        End If
                                    End If
                                ElseIf TypeOf ctrl Is System.Windows.Forms.Panel Or TypeOf ctrl Is System.Windows.Forms.GroupBox Then
                                    For Each c As Control In ctrl.Controls
                                        If TypeOf c Is user_control.rdo_button Then
                                            Dim c1 = CType(c, user_control.rdo_button)
                                            If c1.Value = dr(0).Item(col.ColumnName) Then
                                                c1.Checked = True
                                            Else
                                                c1.Checked = False
                                            End If
                                        End If
                                    Next
                                ElseIf TypeOf ctrl Is System.Windows.Forms.CheckBox Then
                                    Dim c1 = CType(ctrl, System.Windows.Forms.CheckBox)
                                    If dr(0).Item(col.ColumnName).ToString = "1" Or dr(0).Item(col.ColumnName).ToString = "True" Then
                                        c1.Checked = True
                                    Else
                                        c1.Checked = False
                                    End If
                                ElseIf TypeOf ctrl Is System.Windows.Forms.DateTimePicker Then
                                    Dim c1 = CType(ctrl, System.Windows.Forms.DateTimePicker)
                                    Dim d1 As String = dr(0).Item(col.ColumnName).ToString
                                    If d1 <> "" Then
                                        Dim tmp_date = CDate(d1)
                                        c1.Value = If(tmp_date < c1.MinDate, c1.MinDate, tmp_date)
                                    Else
                                        c1.Value = c1.MinDate
                                    End If
                                    'If d1 = "1/1/0001 12:00:00 AM" Or d1 = "1/1/0001 00:00:00" Or d1 = "01/01/0001 0:00:00" Then
                                    '    c1.Value = "1/1/1753 12:00:00 AM"
                                    'Else
                                    '    c1.Value = dr(0).Item(col.ColumnName)
                                    'End If
                                ElseIf TypeOf ctrl Is System.Windows.Forms.TextBox Then
                                    Dim c1 = CType(ctrl, System.Windows.Forms.TextBox)
                                    c1.Text = dr(0).Item(col.ColumnName)
                                End If
                            End If

                        End If
                    Next
                    If form.Controls.Find("primary_key", False).Length > 0 Then
                        Dim primary_key As user_control.textbox = form.Controls.Find("primary_key", False)(0)
                        primary_key.Text = dr(0).Item(primary_key.ValueSource)
                    End If
                End If
            End If
        End If
    End Sub
    Public Shared Function getRdoValue(ByVal panel As Object) As String
        Dim str As String = ""
        For Each control As Control In panel.Controls
            If TypeOf control Is user_control.rdo_button Then
                Dim rdo = CType(control, user_control.rdo_button)
                If rdo.Checked Then
                    str = rdo.Value
                End If
            End If
        Next
        Return str
    End Function
    Public Shared Sub setRdoValue(ByVal panel As Object, ByVal val As String)
        Dim str As String = ""
        For Each control As Control In panel.Controls
            If TypeOf control Is user_control.rdo_button Then
                Dim rdo = CType(control, user_control.rdo_button)
                If rdo.Value = val Then
                    rdo.Checked = True
                Else
                    rdo.Checked = False
                End If
            End If
        Next
    End Sub
    Public Shared Function getStageID(ByVal module_code As String, ByVal user_id As String) As String
        Dim id As String = "0"
        Dim sql As String = String.Format("" &
            "SELECT a.stage_id " &
            "FROM sys_erp_approval a " &
            "LEFT JOIN sys_erp_approval_user b on b.approval_id = a.approval_id " &
            "LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id " &
            "WHERE c.module_code = '{0}' AND b.user_id = {1} " &
            "", module_code, user_id)
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count > 0 Then
            id = dt.Rows(0).Item("stage_id")
        End If
        Return id
    End Function
    'emon - 2017-04-21
    'emon - 2017-04-25
    Public Shared Function MethodExist(frm As Form, MethodName As String) As Boolean
        On Error Resume Next
        CallByName(frm, MethodName, vbMethod)
        MethodExist = (Err.Number <> 438)
    End Function
#Region "Emon - 2017-07-17"
    Public Shared Sub loadDTToDG(ByRef dg As DataGridView, ByVal dt As DataTable)
        dg.AutoGenerateColumns = False
        dg.DataSource = dt
        Dim delCol As String = ""
        For Each col As DataGridViewColumn In dg.Columns
            If col.DataPropertyName = "deleted" Then
                delCol = col.Name
            End If
        Next
        For Each row As DataGridViewRow In dg.Rows
            If row.Cells(delCol).Value Then
                dg.CurrentCell = Nothing
                row.Visible = False
                dg.Rows(row.Index).Visible = False
            End If
        Next
    End Sub
    ''' <summary>
    ''' Copy DataTable From one to another based on PrimaryKey
    ''' </summary>
    ''' <param name="dtTo">New Datatable : Target DataTable</param>
    ''' <param name="dtFrom">Old Datatable : Source DataTable</param>
    ''' <param name="pkName">PrimaryKey Name</param>
    ''' <remarks> - emon - 2017-07-17</remarks>
    Public Shared Sub copyDataTable(ByRef dtTo As DataTable, ByRef dtFrom As DataTable, ByVal pkName As String)
        For Each drFrom As DataRow In dtFrom.Rows
            Dim drExist As Boolean = False
            For Each drTo As DataRow In dtTo.Rows
                If drFrom.Item(pkName).ToString = drTo.Item(pkName).ToString Then
                    For Each dcTo As DataColumn In dtTo.Columns
                        If dtFrom.Columns.Contains(dcTo.ColumnName) Then
                            drTo.Item(dcTo.ColumnName) = drFrom.Item(dcTo.ColumnName)
                        End If
                    Next
                    drExist = True
                End If
            Next
            If Not drExist Then
                Dim newDRTo As DataRow = dtTo.NewRow
                For Each dcTo As DataColumn In dtTo.Columns
                    If dtFrom.Columns.Contains(dcTo.ColumnName) Then
                        newDRTo.Item(dcTo.ColumnName) = drFrom.Item(dcTo.ColumnName)
                    End If
                Next
                dtTo.Rows.Add(newDRTo)
            End If
        Next
    End Sub

#End Region
#Region "Emon - 2017-08-25"
    Public Shared Function StringReplace(ByRef str As String, ByVal oldChar As String, ByVal newChar As String) As String
        For i As Integer = 0 To oldChar.Length - 1
            Dim curChar = oldChar(i)
            str = str.Replace(curChar, newChar)
        Next
        Return str
    End Function
#End Region
#Region "jESA - 042717"
    Public Shared Sub controlClear(ByVal frm As Form)
        Dim hdrPanel As Panel = frm.Controls.Find("hdr", True)(0)
        For Each ctrl As Control In hdrPanel.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim txtbox As user_control.textbox = CType(ctrl, user_control.textbox)
                txtbox.Value = ""
                txtbox.Text = ""
            End If
        Next
    End Sub
    Public Shared Sub controlEnable(ByVal frm As Form)
        Dim hdrPanel As Panel = frm.Controls.Find("hdr", True)(0)
        For Each ctrl As Control In hdrPanel.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim txtbx As user_control.textbox = CType(ctrl, user_control.textbox)
                If Not txtbx.AlwaysDisable Then
                    txtbx.Enabled = True
                End If
            ElseIf TypeOf ctrl Is Button Then
                Select Case ctrl.Name
                    Case "btnEdit"
                        ctrl.Visible = False
                    Case "btnSave"
                        ctrl.Visible = True
                    Case "btnNotSave"
                        ctrl.Visible = True
                End Select
            End If
        Next
    End Sub

    Public Shared Sub controlDisabled(ByVal frm As Form)
        Dim hdrPanel As Panel = frm.Controls.Find("hdr", True)(0)
        For Each ctrl As Control In hdrPanel.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim txtbx As user_control.textbox = CType(ctrl, user_control.textbox)
                If Not txtbx.AlwaysEnable Then
                    txtbx.Enabled = False
                End If
            ElseIf TypeOf ctrl Is Button Then
                Select Case ctrl.Name
                    Case "btnEdit"
                        ctrl.Visible = True
                    Case "btnSave"
                        ctrl.Visible = False
                    Case "btnCancel"
                        ctrl.Visible = False
                End Select
            End If

        Next
    End Sub

    Public Shared Sub reloadTrans(ByVal frm As Form)
        Dim pkName As String = ""
        Dim pkID As String = ""
        Dim dbName As String = ""
        Dim tblName As String = ""
        Try
            pkName = frm.GetType.GetProperty("pkName").GetValue(frm).ToString
            pkID = frm.GetType.GetProperty("pkID").GetValue(frm).ToString
            dbName = frm.GetType.GetProperty("dbName").GetValue(frm).ToString
            tblName = frm.GetType.GetProperty("tblName").GetValue(frm).ToString
        Catch ex As Exception

        End Try
        FormEventHandler(frm)
        If pkID <> "" Then
            Dim sql As String = String.Format("SELECT * FROM {0}.{1} WHERE {2} = '{3}'", dbName, tblName, pkName, pkID)
            Dim dt As DataTable = Query(sql)
            If dt.Rows.Count > 0 Then
                setControlValue(frm, dt.Rows(0))
            End If
        Else
            controlClear(frm)
            controlEnable(frm)
        End If

    End Sub

    Public Shared Sub setControlValue(ByVal frm As Form, ByVal dr As DataRow)
        Dim hdrPanel As Panel = frm.Controls.Find("hdr", True)(0)
        For Each ctrl As Control In hdrPanel.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim tb As user_control.textbox = CType(ctrl, user_control.textbox)
                If tb.ValueSource <> "" Then
                    tb.Value = dr.Item(tb.ValueSource)

                End If
                If tb.TextSource <> "" Then
                    tb.Text = dr.Item(tb.TextSource)
                End If
            End If
        Next
        controlDisabled(frm)
    End Sub

    Public Shared Sub FormEventHandler(ByVal frm As Form)
        Dim hdrPanel As Panel = frm.Controls.Find("hdr", True)(0)
        For Each ctrl As Control In hdrPanel.Controls
            If TypeOf ctrl Is Button Then
                Dim tb As Button = CType(ctrl, Button)
                Select Case tb.Name
                    Case "btnEdit"
                        'ctrl.Visible = True
                        RemoveHandler tb.Click, AddressOf btnEditHandler
                        AddHandler tb.Click, AddressOf btnEditHandler
                    Case "btnSave"
                        RemoveHandler tb.Click, AddressOf btnSaveHandler
                        AddHandler tb.Click, AddressOf btnSaveHandler
                    Case "btnCancel"
                        RemoveHandler tb.Click, AddressOf btnCancelHandler
                        AddHandler tb.Click, AddressOf btnCancelHandler
                End Select
            End If
        Next
    End Sub

    Public Shared Sub btnEditHandler(sender As Object, e As EventArgs)
        Dim frm As Form = sender.FindForm
        Dim transmode = frm.GetType.GetProperty("transmode")
        controlEnable(frm)
        transmode.SetValue(frm, "update", Nothing)
    End Sub
    Public Shared Sub btnSaveHandler(sender As Object, e As EventArgs)
        Dim frm As Form = sender.FindForm
        Dim transmode = frm.GetType.GetProperty("transmode")
        Dim dbName = frm.GetType.GetProperty("dbName")
        Dim tblName = frm.GetType.GetProperty("tblName")
        Dim pkName = frm.GetType.GetProperty("pkName")
        Dim dic As New Dictionary(Of String, String)
        Dim hdrPanel As Panel = frm.Controls.Find("hdr", True)(0)
        For Each ctrl As Control In hdrPanel.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim tb As user_control.textbox = CType(ctrl, user_control.textbox)
                If tb.ValueSource <> "" Then
                    dic.Add(tb.ValueSource, tb.Value)
                Else
                    dic.Add(tb.TextSource, tb.Text)
                End If
            End If
        Next
        Dim sql As String = ""

        If transmode.GetValue(frm).ToString = "insert" Then
            sql = genInsert(tblName.GetValue(frm).ToString, dic)
        Else
            sql = genUpdate(tblName.GetValue(frm).ToString, dic)
        End If
        If dbName.GetValue(frm).ToString = _serverDBFS Then
            FsQuery(sql)
        Else
            Query(sql)
        End If
        controlDisabled(frm)
        transmode.SetValue(frm, "", Nothing)
        frm.Close()
    End Sub
    Public Shared Sub btnCancelHandler(sender As Object, e As EventArgs)
        Dim frm As Form = sender.FindForm
        Dim transmode = frm.GetType.GetProperty("transmode")
        controlDisabled(frm)
        If transmode.GetValue(frm).ToString = "insert" Then
            transmode.SetValue(frm, "", Nothing)
            frm.Close()
        Else
            transmode.SetValue(frm, "", Nothing)
        End If
    End Sub

    Public Shared Sub initTransactionList(ByVal frm As Form)
        Dim myFormToView As Form = Nothing
        Dim mainform As Form = Nothing
        Try
            myFormToView = CType(frm.GetType.GetProperty("frm").GetValue(frm), Form)
            mainform = CType(frm.GetType.GetProperty("mainform").GetValue(frm), Form)
        Catch ex As Exception
        End Try

        Dim DGList As DataGridView = CType(frm.Controls.Find("DGList", True)(0), DataGridView)
        Dim btnAdd As Button = CType(frm.Controls.Find("btnAdd", True)(0), Button)
        Dim btnView As Button = CType(frm.Controls.Find("btnView", True)(0), Button)
        Dim btnDelete As Button = CType(frm.Controls.Find("btnDelete", True)(0), Button)

        If myFormToView IsNot Nothing Then
            Dim pkName As String = myFormToView.GetType.GetProperty("pkName").GetValue(myFormToView).ToString
            Dim colhdr As String = myFormToView.GetType.GetProperty("colhdr").GetValue(myFormToView).ToString
            Dim colfld As String = myFormToView.GetType.GetProperty("colfld").GetValue(myFormToView).ToString
            Dim dbName As String = myFormToView.GetType.GetProperty("dbName").GetValue(myFormToView).ToString
            Dim tblName As String = myFormToView.GetType.GetProperty("tblName").GetValue(myFormToView).ToString

            Dim pkID = myFormToView.GetType.GetProperty("pkID")
            Dim mainList = myFormToView.GetType.GetProperty("mainList")
            Dim transmode = myFormToView.GetType.GetProperty("transmode")

            loadTransactionList(frm, dbName, tblName, pkName, colhdr, colfld, DGList)
            RemoveHandler btnView.Click, AddressOf btnViewEventHandler
            AddHandler btnView.Click, AddressOf btnViewEventHandler
            RemoveHandler btnAdd.Click, AddressOf btnAddEventHandler
            AddHandler btnAdd.Click, AddressOf btnAddEventHandler
            RemoveHandler btnDelete.Click, AddressOf btnDeleteEventHandler
            AddHandler btnDelete.Click, AddressOf btnDeleteEventHandler
        End If
    End Sub
    Public Shared Sub btnViewEventHandler(sender As Object, e As EventArgs)
        Dim frm As Form = sender.FindForm
        Dim DGList As DataGridView = CType(frm.Controls.Find("DGList", True)(0), DataGridView)
        Dim myFormToView = CType(frm.GetType.GetProperty("frm").GetValue(frm), Form)
        Dim mainform = CType(frm.GetType.GetProperty("mainform").GetValue(frm), Form)
        Dim pkID = myFormToView.GetType.GetProperty("pkID")
        If DGList.Rows.Count > 0 Then
            If DGList.SelectedRows.Count > 0 Then
                pkID.SetValue(myFormToView, DGList.SelectedRows(0).Cells(1).Value.ToString, Nothing)
                reloadTrans(myFormToView)
                showForm(myFormToView, mainform)
                frm.Hide()
            End If
        End If
    End Sub
    Public Shared Sub btnAddEventHandler(sender As Object, e As EventArgs)
        Dim frm As Form = sender.FindForm
        Dim DGList As DataGridView = CType(frm.Controls.Find("DGList", True)(0), DataGridView)
        Dim myFormToView = CType(frm.GetType.GetProperty("frm").GetValue(frm), Form)
        Dim mainform = CType(frm.GetType.GetProperty("mainform").GetValue(frm), Form)
        Dim transmode = myFormToView.GetType.GetProperty("transmode")
        Dim pkID = myFormToView.GetType.GetProperty("pkID")
        transmode.SetValue(myFormToView, "insert", Nothing)
        pkID.SetValue(myFormToView, "", Nothing)
        reloadTrans(myFormToView)
        showForm(myFormToView, mainform)
        frm.Hide()
    End Sub
    Public Shared Sub btnDeleteEventHandler(sender As Object, e As EventArgs)
        Dim frm As Form = sender.FindForm
        Dim DGList As DataGridView = CType(frm.Controls.Find("DGList", True)(0), DataGridView)
        Dim myFormToView = CType(frm.GetType.GetProperty("frm").GetValue(frm), Form)
        Dim db As String = myFormToView.GetType.GetProperty("dbName").GetValue(myFormToView).ToString
        Dim tbl As String = myFormToView.GetType.GetProperty("tblName").GetValue(myFormToView).ToString
        Dim pk As String = myFormToView.GetType.GetProperty("pkName").GetValue(myFormToView).ToString
        Dim colhdr As String = myFormToView.GetType.GetProperty("colhdr").GetValue(myFormToView).ToString
        Dim colfld As String = myFormToView.GetType.GetProperty("colfld").GetValue(myFormToView).ToString
        deleteHeader(DGList, db, tbl, pk)
        loadTransactionList(frm, db, tbl, pk, colhdr, colfld, DGList)
    End Sub
    Public Shared Sub loadTransactionList(ByVal frm As Form, ByVal dbName As String, ByVal tblName As String, ByVal pkName As String, ByVal colhdr As String, ByVal colfld As String, ByRef DGList As DataGridView)
        Dim hdrs As New List(Of String)
        Dim flds As New List(Of String)
        For Each hdr As String In colhdr.Split(",")
            hdrs.Add(hdr)
        Next
        For Each fld As String In colfld.Split(",")
            flds.Add(fld)
        Next
        DGList.Columns(0).Name = "sel"
        DGList.Columns(0).DataPropertyName = "sel"
        DGList.Columns(1).Name = pkName
        DGList.Columns(1).DataPropertyName = pkName
        While DGList.Columns.Count > 2
            DGList.Columns.RemoveAt(2)
        End While
        For i As Integer = 0 To hdrs.Count - 1
            DGList.Columns.Add(flds(i), hdrs(i))
            DGList.Columns(flds(i)).DataPropertyName = flds(i)
        Next
        DGList.AutoGenerateColumns = False
        DGList.DataSource = Nothing
        Dim newDt As New DataTable("dt")
        Dim sql As String = String.Format("SELECT * FROM {0}.{1}", dbName, tblName)
        Dim dt As DataTable = Query(sql)
        For Each col As DataColumn In dt.Columns
            newDt.Columns.Add(col.ColumnName)
        Next
        For Each dr As DataRow In dt.Rows
            newDt.ImportRow(dr)
        Next
        DGList.DataSource = newDt
    End Sub
#End Region
#Region "Emon - 2017-09-25"
    Public Shared Function DGNewColumn(ByVal colPropertyName As String, ByVal colName As String, ByVal colHeader As String, Optional colVisible As Boolean = True, Optional colFormat As String = "", Optional colNullValue As String = "", Optional colAlignment As DataGridViewContentAlignment = DataGridViewContentAlignment.NotSet) As DataGridViewColumn
        Dim newCol As New DataGridViewColumn
        newCol.CellTemplate = New DataGridViewTextBoxCell()
        newCol.Name = colName
        newCol.DataPropertyName = colPropertyName
        newCol.HeaderText = colHeader
        newCol.Visible = colVisible
        newCol.ReadOnly = True
        newCol.DefaultCellStyle.Format = colFormat
        newCol.DefaultCellStyle.NullValue = colNullValue
        newCol.DefaultCellStyle.Alignment = colAlignment
        Return newCol
    End Function
    Public Shared Function GCNewColumn(ByVal colPropertyName As String,
                ByVal colName As String,
                ByVal colHeader As String,
                Optional colVisible As Boolean = True,
                Optional colFormat As String = "",
                Optional colFormatType As FormatType = FormatType.None,
                Optional colNullValue As String = ""
            ) As GridColumn
        Dim newCol As New GridColumn
        newCol.Name = colName
        newCol.FieldName = colPropertyName
        newCol.Caption = colHeader
        newCol.DisplayFormat.FormatType = colFormatType
        newCol.DisplayFormat.FormatString = colFormat
        newCol.Visible = colVisible
        'newCol.Width = 100
        newCol.Resize(100)
        Return newCol
    End Function
    Public Shared Function BGCNewColumn(ByVal colPropertyName As String,
                ByVal colName As String,
                ByVal colHeader As String,
                Optional colVisible As Boolean = True,
                Optional colFormat As String = "",
                Optional colFormatType As FormatType = FormatType.None,
                Optional colNullValue As String = "",
                Optional colSummaryType As SummaryItemType = SummaryItemType.None
            ) As BandedGridColumn
        Dim newCol As New BandedGridColumn
        newCol.Name = colName
        newCol.FieldName = colPropertyName
        newCol.Caption = colHeader
        newCol.DisplayFormat.FormatType = colFormatType
        newCol.DisplayFormat.FormatString = colFormat
        newCol.Visible = colVisible
        newCol.SummaryItem.SummaryType = colSummaryType
        'newCol.Width = 100
        newCol.Resize(100)
        Return newCol
    End Function
#End Region
#Region "emon - 2017-10-05"
    Public Shared Function CreateDataColumn(ByVal colName As String, ByVal colDataType As String, Optional colCaption As String = "") As DataColumn
        Dim col As New DataColumn
        col.ColumnName = colName
        col.Caption = colCaption
        col.DataType = System.Type.GetType(colDataType)
        Return col
    End Function
#End Region
#Region "emon - 2017-10-24"
    Public Shared Function GetLastDayOfMonth(intMonth, intYear) As Date
        Return DateSerial(intYear, intMonth + 1, 0)
    End Function
#End Region
#Region "emon - 2017-11-27"
    Public Shared Sub loadJBooksToDG(ByRef dg As DataGridView, ByVal dt As DataTable)

    End Sub
    Public Shared Function computeTime(ByVal tFrom As String, ByVal tTo As String)
        Dim returnStr As String = "00:00:00"
        Dim wSec As Boolean = False
        Dim lstFrom = tFrom.Split(":")
        Dim lstTo = tTo.Split(":")
        If lstFrom.Length - 1 > 1 Then
            wSec = True
        End If
        Dim hFrom As Integer = 0
        Dim mFrom As Integer = 0
        Dim sFrom As Integer = 0
        Dim hTo As Integer = 0
        Dim mTo As Integer = 0
        Dim sTo As Integer = 0
        hFrom = CInt(lstFrom(0))
        mFrom = CInt(lstFrom(1))
        hTo = CInt(lstTo(0))
        mTo = CInt(lstTo(1))
        If wSec Then
            sFrom = CInt(lstFrom(2))
            sTo = CInt(lstTo(2))
        End If
        mFrom += hFrom * 60
        mTo += hTo * 60
        sFrom += mFrom * 60
        sTo += mTo * 60
        Dim totalSec As Integer = 0
        Dim totalMin As Integer = 0
        Dim totalHrs As Integer = 0
        If sFrom > sTo Then
            totalSec = sFrom - sTo
        Else
            totalSec = sTo - sFrom
        End If
        totalMin = Math.Floor(totalSec / 60)
        totalSec = totalSec Mod 60
        totalHrs = Math.Floor(totalMin / 60)
        totalMin = totalMin Mod 60
        If wSec Then
            returnStr = totalHrs.ToString("D2") & ":" & totalMin.ToString("D2") & ":" & totalSec.ToString("D2")
        Else
            returnStr = totalHrs.ToString("D2") & ":" & totalMin.ToString("D2")
        End If
        Return returnStr
    End Function
#End Region
#Region "emon - 2017-12-05"
    Public Shared Function ConvertToLetter(iCol As Integer) As String
        Dim returnStr As String = ""
        Dim iAlpha As Integer
        Dim iRemainder As Integer
        iAlpha = Int(iCol / 27)
        iRemainder = iCol - (iAlpha * 26)
        If iAlpha > 0 Then
            returnStr = Chr(iAlpha + 64)
        End If
        If iRemainder > 0 Then
            returnStr &= Chr(iRemainder + 64)
        End If
        If returnStr = "A[" Then
            returnStr = "BA"
        End If
        Return returnStr
    End Function
#End Region
#Region "emon - 2018-02-05"
    Public Shared Sub TextEditEnterToTab(ByVal frm As Control)
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is Panel Or TypeOf ctrl Is GroupBox Then
                TextEditEnterToTab(ctrl)
            End If
            If TypeOf ctrl Is TextEdit Then
                Dim ctr = CType(ctrl, TextEdit)
                AddHandler ctr.KeyDown, AddressOf EnterToTabEvent
            End If
        Next
    End Sub
    Public Shared Sub EnterToTabEvent(sender As Object, e As Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If TypeOf sender Is TextEdit Then
                e.SuppressKeyPress = True
                SendKeys.Send("{TAB}")
            End If
        End If
    End Sub
#End Region
#Region "emon - 2018-07-19"
    Public Shared Function GenerateRandomString() As String
        Dim rnd As New Random()
        Dim str As String = String.Format("tmp_{0}{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), rnd.Next(100, 999))
        Return str
    End Function
#End Region
End Class
