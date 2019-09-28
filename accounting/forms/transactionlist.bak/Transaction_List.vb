Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Windows.Forms

Public Class Transaction_List
    Private _journal_id As String = ""
    Private _journal_code As String = ""
    Private _FormToView As Form
    Private _trans_id As String = ""
    Private _pkName As String = ""
    Public Property journal_id() As String
        Get
            Return _journal_id
        End Get
        Set(value As String)
            _journal_id = value
        End Set
    End Property
    Public Property journal_code() As String
        Get
            Return _journal_code
        End Get
        Set(value As String)
            _journal_code = value
        End Set
    End Property
    Public Property FormToView() As Form
        Get
            Return _FormToView
        End Get
        Set(value As Form)
            _FormToView = value
        End Set
    End Property
    Public Property trans_id() As String
        Get
            Return _trans_id
        End Get
        Set(value As String)
            _trans_id = value
        End Set
    End Property
    Public Property pk_Name() As String
        Get
            Return _pkName
        End Get
        Set(value As String)
            _pkName = value
        End Set
    End Property
    Private Sub initList()
        If FormToView IsNot Nothing Then
            DGList.AutoGenerateColumns = False
            Dim pkName = FormToView.GetType.GetProperty("pkName")
            Dim pkID = FormToView.GetType.GetProperty("pkID")
            Dim mainlist = FormToView.GetType.GetProperty("mainlist")
            Dim transmode = FormToView.GetType.GetProperty("transmode")
            Dim colhdr = FormToView.GetType.GetProperty("colhdr")
            Dim colfld = FormToView.GetType.GetProperty("colfld")
            Dim dbName = FormToView.GetType.GetProperty("dbName")
            Dim tblName = FormToView.GetType.GetProperty("tblName")
            Dim journal_id = FormToView.GetType.GetProperty("journal_id")
            reloadList(dbName.GetValue(FormToView).ToString, tblName.GetValue(FormToView).ToString, pkName.GetValue(FormToView).ToString, colhdr.GetValue(FormToView).ToString, colfld.GetValue(FormToView).ToString)
            If pk_Name <> "" And trans_id <> "" Then
                gridRowFocus(DGList, {pk_Name, trans_id})
            End If
        End If
    End Sub
    Friend Sub reloadList(ByVal dbName As String, ByVal tblName As String, ByVal pkName As String, ByVal colhdr As String, ByVal colfld As String)
        Dim book_id As String = txtBook.Value
        Dim month As String = txtMonth.Value
        Dim year As String = txtYear.Value
        If book_id = "" Or month = "" Or year = "" Then
            MsgBox("No Records to View.")
        Else
            Dim hdrs As New List(Of String)
            Dim flds As New List(Of String)
            For Each hdr In colhdr.Split(",")
                hdrs.Add(hdr)
            Next
            For Each fld In colfld.Split(",")
                flds.Add(fld)
            Next
            While DGList.Columns.Count > 2
                DGList.Columns.RemoveAt(2)
            End While
            DGList.Columns(1).Name = pkName
            DGList.Columns(1).DataPropertyName = pkName
            For i As Integer = 0 To hdrs.Count - 1
                DGList.Columns.Add(flds(i), hdrs(i))
                DGList.Columns(flds(i)).DataPropertyName = flds(i)
                DGList.Columns(flds(i)).ReadOnly = True
                DGList.Columns(flds(i)).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
            Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date,a.general_id,a.currency_id " & _
                                              ",b.general_name,c.currency_name " & _
                                              "FROM trans_header a " & _
                                              "LEFT JOIN {0}.lib_erp_general b ON b.general_id = a.general_id " & _
                                              "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id " & _
                                              "WHERE a.book_id = '{1}' AND MONTH(a.trans_date) = '{2}' AND YEAR(a.trans_date) = '{3}' AND a.journal_id = '{4}' " & _
                                              "", _serverDBFS, book_id, month, year, journal_id)
            Dim dt As DataTable = Query(sql)
            Dim newDt As New DataTable("dt")
            newDt = dt.Clone
            newDt.Clear()
            For Each dr As DataRow In dt.Rows
                newDt.ImportRow(dr)
            Next
            DGList.DataSource = newDt
        End If
    End Sub

    Private Sub txtBook_Leave(sender As Object, e As EventArgs) Handles txtBook.Leave
        Dim q As String = txtBook.Text.ToString.Replace("'", "''").Trim
        Dim sql As String = String.Format("SELECT * FROM lib_erp_book")
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("book_name LIKE '{0}'", q))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "book_code,book_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtBook.RowData = dr
                txtBook.Value = dr("book_id")
                txtBook.Text = dr("book_name")
            End If
        End If
    End Sub

    Private Sub txtMonth_Leave(sender As Object, e As EventArgs) Handles txtMonth.Leave
        Dim q As String = txtMonth.Text.ToString.Replace("'", "''").Trim
        Dim sql As String = String.Format("SELECT 1 AS id,'January' AS name " & _
                                          "UNION SELECT 2,'Februrary' " & _
                                          "UNION SELECT 3,'March' " & _
                                          "UNION SELECT 4,'April' " & _
                                          "UNION SELECT 5,'May' " & _
                                          "UNION SELECT 6,'June' " & _
                                          "UNION SELECT 7,'July' " & _
                                          "UNION SELECT 8,'August' " & _
                                          "UNION SELECT 9,'September' " & _
                                          "UNION SELECT 10,'October' " & _
                                          "UNION SELECT 11,'November' " & _
                                          "UNION SELECT 12,'December' ")
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("name LIKE '{0}'", q))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "id,name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtMonth.RowData = dr
                txtMonth.Value = dr("id")
                txtMonth.Text = dr("name")
            End If
        End If
    End Sub

    Private Sub Transaction_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = String.Format("SELECT book_id,book_code,book_name FROM lib_erp_book")
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count > 0 Then
            txtBook.Value = dt.Rows(0).Item("book_id")
            txtBook.Text = dt.Rows(0).Item("book_name")
        End If
        Dim today As Date = Date.Today
        txtMonth.Text = MonthName(today.Month)
        txtMonth.Value = today.Month
        txtYear.Value = today.Year
        initList()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        initList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim where As String = ""
        If main.Sys_Default.Rows(0)("monthly_currency") Then
            where = "WHERE DATE_FORMAT(effectivitydate,'%Y-%m') = '" & txtYear.Text & "-" & txtMonth.Value.PadLeft(2, "0") & "' "
        Else
            where = "WHERE effectivitydate = '" & txtYear.Text & "-" & txtMonth.Value.PadLeft(2, "0") & "-" & Date.Today.Day & "'"
        End If
        Dim sql As String = "SELECT a.currency_id,a.currency_code,a.currency_name " & _
            ",b.exchange_rate,b.based_rate " & _
            "FROM lib_erp_currency a " & _
            "INNER JOIN (" & _
                "SELECT a.currency_id,a.exchange_rate,a.based_rate " & _
                "FROM lib_erp_currency_rate a " & _
                "INNER JOIN (" & _
                    "SELECT currency_id,max(effectivitydate) as effectivitydate " & _
                    "FROM lib_erp_currency_rate " & where & _
                    "GROUP BY currency_id" & _
                ") b on a.currency_id = b.currency_id AND a.effectivitydate = b.effectivitydate" & _
            ") b on a.currency_id = b.currency_id"
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count = 0 Then
            MsgBox(String.Format("No Currency Rate Setup for the {0}.", If(main.Sys_Default.Rows(0)("monthly_currency"), "Month", "Day")))
            Exit Sub
        End If
        Dim _btnAdd As Button = CType(FormToView.Controls.Find("btnAdd", True)(0), Button)
        showFormToView()
        _btnAdd.PerformClick()
    End Sub
    Private Sub showFormToView()
        Try
            Dim jid As System.Reflection.PropertyInfo = FormToView.GetType.GetProperty("journal_id")
            If Not jid Is Nothing Then
                jid.SetValue(FormToView, journal_id)
            End If
        Catch
        End Try
        Try
            Dim bid As System.Reflection.PropertyInfo = FormToView.GetType.GetProperty("book_id")
            If Not bid Is Nothing Then
                bid.SetValue(FormToView, txtBook.Value.ToString)
            End If
        Catch
        End Try
        Try
            Dim bid As System.Reflection.PropertyInfo = FormToView.GetType.GetProperty("book_name")
            If Not bid Is Nothing Then
                bid.SetValue(FormToView, txtBook.Text)
            End If
        Catch
        End Try
        Try
            Dim jid As System.Reflection.PropertyInfo = FormToView.GetType.GetProperty("journal_code")
            If Not jid Is Nothing Then
                jid.SetValue(FormToView, journal_code)
            End If
        Catch
        End Try
        Try
            Dim mo As System.Reflection.PropertyInfo = FormToView.Controls("hdr").Controls("txtmonth").GetType.GetProperty("Value")
            If Not mo Is Nothing Then
                mo.SetValue(FormToView.Controls("hdr").Controls("txtmonth"), (txtMonth.Value).ToString)
            End If
            Dim mn As System.Reflection.PropertyInfo = FormToView.Controls("hdr").Controls("txtmonth").GetType.GetProperty("Text")
            If Not mn Is Nothing Then
                mn.SetValue(FormToView.Controls("hdr").Controls("txtmonth"), txtMonth.Text)
            End If
        Catch
        End Try
        Try
            FormToView.Controls.Find("txtyear", True)(0).Text = txtYear.Value
        Catch
        End Try
        Try
            Dim par As System.Reflection.PropertyInfo = FormToView.GetType.GetProperty("MdiParent")
            If Not par Is Nothing Then
                par.SetValue(FormToView, main)
            End If
        Catch
        End Try
        Try
            Dim stp As System.Reflection.PropertyInfo = FormToView.GetType.GetProperty("StartPosition")
            If Not stp Is Nothing Then
                stp.SetValue(FormToView, FormStartPosition.CenterParent)
            End If
        Catch
        End Try
        showForm(FormToView, main)
        FormToView.Refresh()
        Me.Hide()
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        viewSelected()
    End Sub
    Private Sub viewSelected()
        Dim pkID = FormToView.GetType.GetProperty("pkID")
        Dim transmode = FormToView.GetType.GetProperty("transmode")
        Dim pkName As String = FormToView.GetType.GetProperty("pkName").GetValue(FormToView).ToString
        If DGList.Rows.Count > 0 Then
            If DGList.SelectedRows.Count = 1 Then
                Dim id As String = DGList.SelectedRows(0).Cells(pkName).Value.ToString
                pkID.SetValue(FormToView, id, Nothing)
                transmode.SetValue(FormToView, "", Nothing)
                showFormToView()
            End If
        Else
            MsgBox("No record selected.")
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
    End Sub

    Private Sub Transaction_List_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If btnHide.Visible Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub DGList_DoubleClick(sender As Object, e As EventArgs) Handles DGList.DoubleClick
        viewSelected()
    End Sub

    Private Sub DGList_KeyUp(sender As Object, e As KeyEventArgs) Handles DGList.KeyUp
        If e.KeyCode = 13 Then
            viewSelected()
        End If
    End Sub

    Private Sub txtYear_KeyUp(sender As Object, e As KeyEventArgs) Handles txtYear.KeyUp
        If e.KeyCode = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class