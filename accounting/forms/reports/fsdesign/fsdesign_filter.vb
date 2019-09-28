Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.Drawing
Imports libacctng.myFunctions
Imports Microsoft.Office.Interop
Imports DevExpress.XtraSplashScreen

Public Class fsdesign_filter
    Private strChar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private strCharacter As String = ""
    Public Property FS_Type As Integer = 0
    Private Sub generateString()
        strCharacter = ""
        For i As Integer = 0 To strChar.Length - 1
            strCharacter &= strChar.Substring(i, 1)
        Next
        For i As Integer = 0 To strChar.Length - 1
            For j As Integer = i To strChar.Length - 1
                strCharacter &= strChar.Substring(i, 1) & strChar.Substring(j, 1)
            Next
        Next
    End Sub
    Private Function getColumnCharacter(ByVal i As Integer) As String
        Dim returnStr As String = ""
        If i <= 25 Then
            returnStr = strCharacter.Substring(i, 1)
        Else
            returnStr = strCharacter.Substring(i, 2)
        End If
        Return returnStr
    End Function
    Public Property template_id As String = ""
    Private Sub w_book_a_CheckedChanged(sender As Object, e As EventArgs) Handles w_book_a.CheckedChanged
        txt_book_a.Enabled = w_book_a.Checked
    End Sub
    Private Sub w_book_b_CheckedChanged(sender As Object, e As EventArgs) Handles w_book_b.CheckedChanged
        txt_book_b.Enabled = w_book_b.Checked
    End Sub
    Private Sub w_book_c_CheckedChanged(sender As Object, e As EventArgs) Handles w_book_c.CheckedChanged
        txt_book_c.Enabled = w_book_c.Checked
    End Sub
    Private Sub w_book_d_CheckedChanged(sender As Object, e As EventArgs) Handles w_book_d.CheckedChanged
        txt_book_d.Enabled = w_book_d.Checked
    End Sub
    Private Sub w_book_e_CheckedChanged(sender As Object, e As EventArgs) Handles w_book_e.CheckedChanged
        txt_book_e.Enabled = w_book_e.Checked
    End Sub
    Private Sub fsdesign_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If template_id = "" Then
            Dim sql As String = String.Format("SELECT template_id,template_code,template_name FROM sys_fs_template WHERE fs_type = '{0}'", FS_Type)
            Dim dt As DataTable = FsQuery(sql)
            If dt.Rows.Count > 0 Then
                panel_template.Visible = True
                txt_template_id.Enabled = True
                txt_template_id.Value = ifNull(dt.Rows(0).Item("template_id"), "").ToString
                txt_template_id.Text = ifNull(dt.Rows(0).Item("template_code"), "").ToString
                txt_template_name.Text = ifNull(dt.Rows(0).Item("template_name"), "").ToString
                template_id = txt_template_id.Value
            End If
        End If
        txt_source_a.Value = "1"
        txt_source_a.Text = "Journal Books"
        txt_source_a.Enabled = False
        txt_source_b.Value = "1"
        txt_source_b.Text = "Journal Books"
        txt_source_b.Enabled = False
        txt_source_c.Value = "1"
        txt_source_c.Text = "Journal Books"
        txt_source_c.Enabled = False
        txt_source_d.Value = "1"
        txt_source_d.Text = "Journal Books"
        txt_source_d.Enabled = False
        txt_source_e.Value = "1"
        txt_source_e.Text = "Journal Books"
        txt_source_e.Enabled = False
        txt_month_from_a.Text = "January"
        txt_month_from_b.Text = "January"
        txt_month_from_c.Text = "January"
        txt_month_from_d.Text = "January"
        txt_month_from_e.Text = "January"
        txt_month_to_a.Text = "December"
        txt_month_to_b.Text = "December"
        txt_month_to_c.Text = "December"
        txt_month_to_d.Text = "December"
        txt_month_to_e.Text = "December"
        txt_year_from_a.Value = Today.Year
        txt_year_from_b.Value = Today.Year
        txt_year_from_c.Value = Today.Year
        txt_year_from_d.Value = Today.Year
        txt_year_from_e.Value = Today.Year
        txt_year_to_a.Value = Today.Year
        txt_year_to_b.Value = Today.Year
        txt_year_to_c.Value = Today.Year
        txt_year_to_d.Value = Today.Year
        txt_year_to_e.Value = Today.Year
        txt_range_a.Text = "FOR THE MONTH"
        txt_range_a.Value = "1"
        txt_range_b.Text = "FOR THE MONTH"
        txt_range_b.Value = "1"
        txt_range_c.Text = "FOR THE MONTH"
        txt_range_c.Value = "1"
        txt_range_d.Text = "FOR THE MONTH"
        txt_range_d.Value = "1"
        txt_range_e.Text = "FOR THE MONTH"
        txt_range_e.Value = "1"
        setLabel(txt_range_a)
        setLabel(txt_range_b)
        setLabel(txt_range_c)
        setLabel(txt_range_d)
        setLabel(txt_range_e)
    End Sub
    Private Sub CreateTextBrowse(ByVal sql As String, _
                                 ByVal q As String, _
                                 ByVal label As String, _
                                 ByVal field As String, _
                                 ByVal width As String, _
                                 ByRef returnDr As DataRow)

        q = q.Replace("'", "''")
        Dim fields = field.Split(",")
        Dim strQ As String = ""
        For Each f In fields
            strQ &= String.Format(" OR {0} = '{1}' ", f, q)
        Next
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(strQ.Substring(4))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format(label, field, width)
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                returnDr = dr
            End If
        End If
    End Sub
    Private Sub BrowseRange(sender As Object, e As EventArgs) Handles txt_range_a.Leave, txt_range_b.Leave, txt_range_c.Leave, txt_range_d.Leave, txt_range_e.Leave
        Dim sql As String = String.Format("SELECT 'FOR THE MONTH' AS range_name,'1' AS range_id " &
            "UNION SELECT 'AS OF','2' " &
            "UNION SELECT 'DATE RANGE','3' " &
            "")
        Dim str = sender.Text.Trim
        Dim label As String = "ID,Range"
        Dim field As String = "range_id,range_name"
        Dim width As String = "50,100"
        Dim drVar As DataRow = Nothing

        CreateTextBrowse(sql, str, label, field, width, drVar)
        If TypeOf sender Is user_control.textbox Then
            Dim txt = CType(sender, user_control.textbox)
            If drVar IsNot Nothing Then
                txt.Text = drVar.Item("range_name").ToString
                txt.Value = drVar.Item("range_id").ToString
                setLabel(sender)
            Else
                txt.Text = ""
                txt.Value = ""
            End If
        End If
    End Sub
    Private Sub setLabel(ByVal sender As Object)
        If TypeOf sender Is user_control.textbox Then
            Dim txt = CType(sender, user_control.textbox)
            Select Case txt.Name
                Case "txt_range_a"
                    txt_month_to_a.Enabled = False
                    txt_year_to_a.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            txt_label_from_a.Text = "FOR THE MONTH"
                            txt_label_to_a.Text = txt_month_from_a.Text.ToUpper & " " & txt_year_from_a.Value
                        Case "2"
                            txt_label_from_a.Text = "AS OF"
                            txt_label_to_a.Text = txt_month_from_a.Text.ToUpper & " " & txt_year_from_a.Value
                        Case "3"
                            txt_label_from_a.Text = "RANGED"
                            txt_label_to_a.Text = txt_month_from_a.Text.ToUpper & " " & txt_year_from_a.Value & " - " & txt_month_to_a.Text.ToUpper & " " & txt_year_to_a.Value
                    End Select
                    If txt.Value = "3" Then
                        txt_month_to_a.Enabled = True
                        txt_year_to_a.Enabled = True
                    End If
                Case "txt_range_b"
                    txt_month_to_b.Enabled = False
                    txt_year_to_b.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            txt_label_from_b.Text = "FOR THE MONTH"
                            txt_label_to_b.Text = txt_month_from_b.Text.ToUpper & " " & txt_year_from_b.Value
                        Case "2"
                            txt_label_from_b.Text = "AS OF"
                            txt_label_to_b.Text = txt_month_from_b.Text.ToUpper & " " & txt_year_from_b.Value
                        Case "3"
                            txt_label_from_b.Text = "RANGED"
                            txt_label_to_b.Text = txt_month_from_b.Text.ToUpper & " " & txt_year_from_b.Value & " - " & txt_month_to_b.Text.ToUpper & " " & txt_year_to_b.Value
                    End Select
                    If txt.Value = "3" Then
                        txt_month_to_b.Enabled = True
                        txt_year_to_b.Enabled = True
                    End If
                Case "txt_range_c"
                    txt_month_to_c.Enabled = False
                    txt_year_to_c.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            txt_label_from_c.Text = "FOR THE MONTH"
                            txt_label_to_c.Text = txt_month_from_c.Text.ToUpper & " " & txt_year_from_c.Value
                        Case "2"
                            txt_label_from_c.Text = "AS OF"
                            txt_label_to_c.Text = txt_month_from_c.Text.ToUpper & " " & txt_year_from_c.Value
                        Case "3"
                            txt_label_from_c.Text = "RANGED"
                            txt_label_to_c.Text = txt_month_from_c.Text.ToUpper & " " & txt_year_from_c.Value & " - " & txt_month_to_c.Text.ToUpper & " " & txt_year_to_c.Value
                    End Select
                    If txt.Value = "3" Then
                        txt_month_to_c.Enabled = True
                        txt_year_to_c.Enabled = True
                    End If
                Case "txt_range_d"
                    txt_month_to_d.Enabled = False
                    txt_year_to_d.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            txt_label_from_d.Text = "FOR THE MONTH"
                            txt_label_to_d.Text = txt_month_from_d.Text.ToUpper & " " & txt_year_from_d.Value
                        Case "2"
                            txt_label_from_d.Text = "AS OF"
                            txt_label_to_d.Text = txt_month_from_d.Text.ToUpper & " " & txt_year_from_d.Value
                        Case "3"
                            txt_label_from_d.Text = "RANGED"
                            txt_label_to_d.Text = txt_month_from_d.Text.ToUpper & " " & txt_year_from_d.Value & " - " & txt_month_to_d.Text.ToUpper & " " & txt_year_to_d.Value
                    End Select
                    If txt.Value = "3" Then
                        txt_month_to_d.Enabled = True
                        txt_year_to_d.Enabled = True
                    End If
                Case "txt_range_e"
                    txt_month_to_e.Enabled = False
                    txt_year_to_e.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            txt_label_from_e.Text = "FOR THE MONTH"
                            txt_label_to_e.Text = txt_month_from_e.Text.ToUpper & " " & txt_year_from_e.Value
                        Case "2"
                            txt_label_from_e.Text = "AS OF"
                            txt_label_to_e.Text = txt_month_from_e.Text.ToUpper & " " & txt_year_from_e.Value
                        Case "3"
                            txt_label_from_e.Text = "RANGED"
                            txt_label_to_e.Text = txt_month_from_e.Text.ToUpper & " " & txt_year_from_e.Value & " - " & txt_month_to_e.Text.ToUpper & " " & txt_year_to_e.Value
                    End Select
                    If txt.Value = "3" Then
                        txt_month_to_e.Enabled = True
                        txt_year_to_e.Enabled = True
                    End If
            End Select
        End If
    End Sub
    Private Sub YearChange(sender As Object, e As EventArgs) Handles txt_year_to_e.ValueChanged, txt_year_to_d.ValueChanged, txt_year_to_c.ValueChanged, txt_year_to_b.ValueChanged, txt_year_to_a.ValueChanged, txt_year_from_e.ValueChanged, txt_year_from_d.ValueChanged, txt_year_from_c.ValueChanged, txt_year_from_b.ValueChanged, txt_year_from_a.ValueChanged
        If sender.Name.ToString <> "" Then
            Dim postFix = sender.Name.ToString.Substring(sender.Name.ToString.Length - 1, 1)
            Select Case postFix
                Case "a"
                    setLabel(txt_range_a)
                Case "b"
                    setLabel(txt_range_b)
                Case "c"
                    setLabel(txt_range_c)
                Case "d"
                    setLabel(txt_range_d)
                Case "e"
                    setLabel(txt_range_e)
            End Select
        End If
    End Sub
    Private Sub MonthChange(sender As Object, e As EventArgs) Handles txt_month_to_e.SelectedValueChanged, txt_month_to_d.SelectedValueChanged, txt_month_to_c.SelectedValueChanged, txt_month_to_b.SelectedValueChanged, txt_month_to_a.SelectedValueChanged, txt_month_from_e.SelectedValueChanged, txt_month_from_d.SelectedValueChanged, txt_month_from_c.SelectedValueChanged, txt_month_from_b.SelectedValueChanged, txt_month_from_a.SelectedValueChanged
        If sender.Name.ToString <> "" Then
            Dim postFix = sender.Name.ToString.Substring(sender.Name.ToString.Length - 1, 1)
            Select Case postFix
                Case "a"
                    setLabel(txt_range_a)
                Case "b"
                    setLabel(txt_range_b)
                Case "c"
                    setLabel(txt_range_c)
                Case "d"
                    setLabel(txt_range_d)
                Case "e"
                    setLabel(txt_range_e)
            End Select
        End If
    End Sub
    Private Sub PrintReport(ByVal reportOption As String)
        Dim wZero As Boolean = w_zero.Checked
        Dim a_date_from As Date = New Date(txt_year_from_a.Value.ToString, txt_month_from_a.SelectedIndex + 1, 1)
        Dim a_date_to As Date = New Date(txt_year_to_a.Value.ToString, txt_month_to_a.SelectedIndex + 1, 1)
        If a_date_from.Month = 12 Then
            a_date_from = New Date(a_date_from.Year, 12, 31)
        Else
            a_date_from = New Date(a_date_from.Year, a_date_from.Month + 1, 1)
            a_date_from = a_date_from.AddDays(-1)
        End If
        If a_date_to.Month = 12 Then
            a_date_to = New Date(a_date_to.Year, 12, 31)
        Else
            a_date_to = New Date(a_date_to.Year, a_date_to.Month + 1, 1)
            a_date_to = a_date_to.AddDays(-1)
        End If

        Dim b_date_from As Date = New Date(txt_year_from_b.Value.ToString, txt_month_from_b.SelectedIndex + 1, 1)
        Dim b_date_to As Date = New Date(txt_year_to_b.Value.ToString, txt_month_to_b.SelectedIndex + 1, 1)
        If b_date_from.Month = 12 Then
            b_date_from = New Date(b_date_from.Year, 12, 31)
        Else
            b_date_from = New Date(b_date_from.Year, b_date_from.Month + 1, 1)
            b_date_from = b_date_from.AddDays(-1)
        End If
        If b_date_to.Month = 12 Then
            b_date_to = New Date(b_date_to.Year, 12, 31)
        Else
            b_date_to = New Date(b_date_to.Year, b_date_to.Month + 1, 1)
            b_date_to = b_date_to.AddDays(-1)
        End If

        Dim c_date_from As Date = New Date(txt_year_from_c.Value.ToString, txt_month_from_c.SelectedIndex + 1, 1)
        Dim c_date_to As Date = New Date(txt_year_to_c.Value.ToString, txt_month_to_c.SelectedIndex + 1, 1)
        If c_date_from.Month = 12 Then
            c_date_from = New Date(c_date_from.Year, 12, 31)
        Else
            c_date_from = New Date(c_date_from.Year, c_date_from.Month + 1, 1)
            c_date_from = c_date_from.AddDays(-1)
        End If
        If c_date_to.Month = 12 Then
            c_date_to = New Date(c_date_to.Year, 12, 31)
        Else
            c_date_to = New Date(c_date_to.Year, c_date_to.Month + 1, 1)
            c_date_to = c_date_to.AddDays(-1)
        End If

        Dim d_date_from As Date = New Date(txt_year_from_d.Value.ToString, txt_month_from_d.SelectedIndex + 1, 1)
        Dim d_date_to As Date = New Date(txt_year_to_d.Value.ToString, txt_month_to_d.SelectedIndex + 1, 1)
        If d_date_from.Month = 12 Then
            d_date_from = New Date(d_date_from.Year, 12, 31)
        Else
            d_date_from = New Date(d_date_from.Year, d_date_from.Month + 1, 1)
            d_date_from = d_date_from.AddDays(-1)
        End If
        If d_date_to.Month = 12 Then
            d_date_to = New Date(d_date_to.Year, 12, 31)
        Else
            d_date_to = New Date(d_date_to.Year, d_date_to.Month + 1, 1)
            d_date_to = d_date_to.AddDays(-1)
        End If

        Dim e_date_from As Date = New Date(txt_year_from_e.Value.ToString, txt_month_from_e.SelectedIndex + 1, 1)
        Dim e_date_to As Date = New Date(txt_year_to_e.Value.ToString, txt_month_to_e.SelectedIndex + 1, 1)
        If e_date_from.Month = 12 Then
            e_date_from = New Date(e_date_from.Year, 12, 31)
        Else
            e_date_from = New Date(e_date_from.Year, e_date_from.Month + 1, 1)
            e_date_from = e_date_from.AddDays(-1)
        End If
        If e_date_to.Month = 12 Then
            e_date_to = New Date(e_date_to.Year, 12, 31)
        Else
            e_date_to = New Date(e_date_to.Year, e_date_to.Month + 1, 1)
            e_date_to = e_date_to.AddDays(-1)
        End If
        Dim dic_a As New Dictionary(Of String, String)
        dic_a.Add("source", txt_source_a.Value.ToString)
        dic_a.Add("book", txt_book_a.Value.ToString)
        dic_a.Add("range", txt_range_a.Value.ToString)
        dic_a.Add("month_from", txt_month_from_a.SelectedIndex + 1)
        dic_a.Add("year_from", txt_year_from_a.Value.ToString)
        dic_a.Add("month_to", txt_month_to_a.SelectedIndex + 1)
        dic_a.Add("year_to", txt_year_to_a.Value.ToString)
        dic_a.Add("enable", enable_a.Checked)
        dic_a.Add("project_id", txt_project_id_a.Value.ToString)
        dic_a.Add("project_name", txt_project_id_a.Text.ToString)
        dic_a.Add("label_from", txt_label_from_a.Text.ToString)
        dic_a.Add("label_to", txt_label_to_a.Text.ToString)
        Dim dic_b As New Dictionary(Of String, String)
        dic_b.Add("source", txt_source_b.Value.ToString)
        dic_b.Add("book", txt_book_b.Value.ToString)
        dic_b.Add("range", txt_range_b.Value.ToString)
        dic_b.Add("month_from", txt_month_from_b.SelectedIndex + 1)
        dic_b.Add("year_from", txt_year_from_b.Value.ToString)
        dic_b.Add("month_to", txt_month_to_b.SelectedIndex + 1)
        dic_b.Add("year_to", txt_year_to_b.Value.ToString)
        dic_b.Add("enable", enable_b.Checked)
        dic_b.Add("project_id", txt_project_id_b.Value.ToString)
        dic_b.Add("project_name", txt_project_id_b.Text.ToString)
        dic_b.Add("label_from", txt_label_from_b.Text.ToString)
        dic_b.Add("label_to", txt_label_to_b.Text.ToString)
        Dim dic_c As New Dictionary(Of String, String)
        dic_c.Add("source", txt_source_c.Value.ToString)
        dic_c.Add("book", txt_book_c.Value.ToString)
        dic_c.Add("range", txt_range_c.Value.ToString)
        dic_c.Add("month_from", txt_month_from_c.SelectedIndex + 1)
        dic_c.Add("year_from", txt_year_from_c.Value.ToString)
        dic_c.Add("month_to", txt_month_to_c.SelectedIndex + 1)
        dic_c.Add("year_to", txt_year_to_c.Value.ToString)
        dic_c.Add("enable", enable_c.Checked)
        dic_c.Add("project_id", txt_project_id_c.Value.ToString)
        dic_c.Add("project_name", txt_project_id_c.Text.ToString)
        dic_c.Add("label_from", txt_label_from_c.Text.ToString)
        dic_c.Add("label_to", txt_label_to_c.Text.ToString)
        Dim dic_d As New Dictionary(Of String, String)
        dic_d.Add("source", txt_source_d.Value.ToString)
        dic_d.Add("book", txt_book_d.Value.ToString)
        dic_d.Add("range", txt_range_d.Value.ToString)
        dic_d.Add("month_from", txt_month_from_d.SelectedIndex + 1)
        dic_d.Add("year_from", txt_year_from_d.Value.ToString)
        dic_d.Add("month_to", txt_month_to_d.SelectedIndex + 1)
        dic_d.Add("year_to", txt_year_to_d.Value.ToString)
        dic_d.Add("enable", enable_d.Checked)
        dic_d.Add("project_id", txt_project_id_d.Value.ToString)
        dic_d.Add("project_name", txt_project_id_d.Text.ToString)
        dic_d.Add("label_from", txt_label_from_d.Text.ToString)
        dic_d.Add("label_to", txt_label_to_d.Text.ToString)
        Dim dic_e As New Dictionary(Of String, String)
        dic_e.Add("source", txt_source_e.Value.ToString)
        dic_e.Add("book", txt_book_e.Value.ToString)
        dic_e.Add("range", txt_range_e.Value.ToString)
        dic_e.Add("month_from", txt_month_from_e.SelectedIndex + 1)
        dic_e.Add("year_from", txt_year_from_e.Value.ToString)
        dic_e.Add("month_to", txt_month_to_e.SelectedIndex + 1)
        dic_e.Add("year_to", txt_year_to_e.Value.ToString)
        dic_e.Add("enable", enable_e.Checked)
        dic_e.Add("project_id", txt_project_id_e.Value.ToString)
        dic_e.Add("project_name", txt_project_id_e.Text.ToString)
        dic_e.Add("label_from", txt_label_from_e.Text.ToString)
        dic_e.Add("label_to", txt_label_to_e.Text.ToString)
        Dim dic_all As New Dictionary(Of String, Dictionary(Of String, String))
        dic_all.Add("a", dic_a)
        dic_all.Add("b", dic_b)
        dic_all.Add("c", dic_c)
        dic_all.Add("d", dic_d)
        dic_all.Add("e", dic_e)
        Dim sql As String = ""
        Dim sql_select_amount As String = ""
        Dim sql_select_amount_based As String = ""
        Dim sql_join As String = ""
        If dic_a.Item("enable") Then
            If dic_a.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(a.debit,0) - IFNULL(a.credit,0),IFNULL(a.credit,0) - IFNULL(a.debit,0)) AS a_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(a.debit_based,0) - IFNULL(a.credit_based,0),IFNULL(a.credit_based,0) - IFNULL(a.debit_based,0)) AS a_amount_based")
                sql_select_amount &= String.Format(",a.project_id AS a_project_id,a.project_code AS a_project_code,a.project_name AS a_project_name ")
                sql_join &= String.Format("LEFT JOIN (" &
                "   SELECT a.account_id " &
                "   ,SUM(IFNULL(a.debit,0)) AS debit " &
                "   ,SUM(IFNULL(a.credit,0)) AS credit " &
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " &
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
                "   ,a.project_id,a.project_code,a.project_name " &
                "   FROM {0}.SelectChartAmount a", _serverDBMain)
                Select Case dic_a.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE DATE_FORMAT(a.trans_date,'%m-%Y') = DATE_FORMAT('{0}','%m-%Y') ",
                            a_date_from.ToString("yyyy-MM-dd"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= '{0}' ",
                            a_date_from.ToString("yyyy-MM-dd"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{0}-{1}-1' AND '{2}' ",
                            a_date_from.Year(), a_date_from.Month(), a_date_to.ToString("yyyy-MM-dd"))
                End Select
                If ifNull(dic_a.Item("project_id"), "").ToString <> "" Then
                    sql_join &= String.Format(" AND a.project_id = '{0}'", dic_a.Item("project_id"))
                End If
                sql_join &= String.Format("   GROUP BY a.account_id " &
                ") a ON a.account_id = chart.account_id ", dic_a.Item("month_from"), dic_a.Item("year_from"))
            End If
        End If
        If dic_b.Item("enable") Then
            If dic_b.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(b.debit,0) - IFNULL(b.credit,0),IFNULL(b.credit,0) - IFNULL(b.debit,0)) AS b_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(b.debit_based,0) - IFNULL(b.credit_based,0),IFNULL(b.credit_based,0) - IFNULL(b.debit_based,0)) AS b_amount_based")
                sql_select_amount &= String.Format(",b.project_id AS b_project_id,b.project_code AS b_project_code,b.project_name AS b_project_name ")
                sql_join &= String.Format("LEFT JOIN (" &
                "   SELECT a.account_id " &
                "   ,SUM(IFNULL(a.debit,0)) AS debit " &
                "   ,SUM(IFNULL(a.credit,0)) AS credit " &
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " &
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
                "   ,a.project_id,a.project_code,a.project_name " &
                "   FROM {0}.SelectChartAmount a", _serverDBMain)
                Select Case dic_b.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE DATE_FORMAT(a.trans_date,'%m-%Y') = DATE_FORMAT('{0}','%m-%Y') ",
                            b_date_from.ToString("yyyy-MM-dd"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= '{0}' ",
                            b_date_from.ToString("yyyy-MM-dd"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{0}-{1}-1' AND '{2}' ",
                            b_date_from.Year(), b_date_from.Month(), b_date_to.ToString("yyyy-MM-dd"))
                End Select
                If ifNull(dic_b.Item("project_id"), "").ToString <> "" Then
                    sql_join &= String.Format(" AND a.project_id = '{0}'", dic_b.Item("project_id"))
                End If
                sql_join &= String.Format("   GROUP BY a.account_id " &
                ") b ON b.account_id = chart.account_id ", dic_b.Item("month_from"), dic_b.Item("year_from"))
            End If
        End If
        If dic_c.Item("enable") Then
            If dic_c.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(c.debit,0) - IFNULL(c.credit,0),IFNULL(c.credit,0) - IFNULL(c.debit,0)) AS c_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(c.debit_based,0) - IFNULL(c.credit_based,0),IFNULL(c.credit_based,0) - IFNULL(c.debit_based,0)) AS c_amount_based")
                sql_select_amount &= String.Format(",c.project_id AS c_project_id,c.project_code AS c_project_code,c.project_name AS c_project_name ")
                sql_join &= String.Format("LEFT JOIN (" &
                "   SELECT a.account_id " &
                "   ,SUM(IFNULL(a.debit,0)) AS debit " &
                "   ,SUM(IFNULL(a.credit,0)) AS credit " &
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " &
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
                "   ,a.project_id,a.project_code,a.project_name " &
                "   FROM {0}.SelectChartAmount a", _serverDBMain)
                Select Case dic_c.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE DATE_FORMAT(a.trans_date,'%m-%Y') = DATE_FORMAT('{0}','%m-%Y') ",
                            c_date_from.ToString("yyyy-MM-dd"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= '{0}' ",
                            c_date_from.ToString("yyyy-MM-dd"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{0}-{1}-1' AND '{2}' ",
                            c_date_from.Year(), c_date_from.Month(), c_date_to.ToString("yyyy-MM-dd"))
                End Select
                If ifNull(dic_c.Item("project_id"), "").ToString <> "" Then
                    sql_join &= String.Format(" AND a.project_id = '{0}'", dic_c.Item("project_id"))
                End If
                sql_join &= String.Format("   GROUP BY a.account_id " &
                ") c ON c.account_id = chart.account_id ", dic_c.Item("month_from"), dic_c.Item("year_from"))
            End If
        End If
        If dic_d.Item("enable") Then
            If dic_d.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(d.debit,0) - IFNULL(d.credit,0),IFNULL(d.credit,0) - IFNULL(d.debit,0)) AS d_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(d.debit_based,0) - IFNULL(d.credit_based,0),IFNULL(d.credit_based,0) - IFNULL(d.debit_based,0)) AS d_amount_based")
                sql_select_amount &= String.Format(",d.project_id AS d_project_id,d.project_code AS d_project_code,d.project_name AS d_project_name ")
                sql_join &= String.Format("LEFT JOIN (" &
                "   SELECT a.account_id " &
                "   ,SUM(IFNULL(a.debit,0)) AS debit " &
                "   ,SUM(IFNULL(a.credit,0)) AS credit " &
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " &
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
                "   ,a.project_id,a.project_code,a.project_name " &
                "   FROM {0}.SelectChartAmount a", _serverDBMain)
                Select Case dic_d.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE DATE_FORMAT(a.trans_date,'%m-%Y') = DATE_FORMAT('{0}','%m-%Y') ",
                            d_date_from.ToString("yyyy-MM-dd"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= '{0}' ",
                            d_date_from.ToString("yyyy-MM-dd"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{0}-{1}-1' AND '{2}' ",
                            d_date_from.Year(), d_date_from.Month(), d_date_to.ToString("yyyy-MM-dd"))
                End Select
                If ifNull(dic_d.Item("project_id"), "").ToString <> "" Then
                    sql_join &= String.Format(" AND a.project_id = '{0}'", dic_d.Item("project_id"))
                End If
                sql_join &= String.Format("   GROUP BY a.account_id " &
                ") d ON d.account_id = chart.account_id ", dic_d.Item("month_from"), dic_d.Item("year_from"))
            End If
        End If
        If dic_e.Item("enable") Then
            If dic_e.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(e.debit,0) - IFNULL(e.credit,0),IFNULL(e.credit,0) - IFNULL(e.debit,0)) AS e_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL(e.debit_based,0) - IFNULL(e.credit_based,0),IFNULL(e.credit_based,0) - IFNULL(e.debit_based,0)) AS e_amount_based")
                sql_select_amount &= String.Format(",e.project_id AS e_project_id,e.project_code AS e_project_code,e.project_name AS e_project_name ")
                sql_join &= String.Format("LEFT JOIN (" &
                "   SELECT a.account_id " &
                "   ,SUM(IFNULL(a.debit,0)) AS debit " &
                "   ,SUM(IFNULL(a.credit,0)) AS credit " &
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " &
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
                "   ,a.project_id,a.project_code,a.project_name " &
                "   FROM {0}.SelectChartAmount a", _serverDBMain)
                Select Case dic_e.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE DATE_FORMAT(a.trans_date,'%m-%Y') = DATE_FORMAT('{0}','%m-%Y') ",
                            e_date_from.ToString("yyyy-MM-dd"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= '{0}' ",
                            e_date_from.ToString("yyyy-MM-dd"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{0}-{1}-1' AND '{2}' ",
                            e_date_from.Year(), e_date_from.Month(), e_date_to.ToString("yyyy-MM-dd"))
                End Select
                If ifNull(dic_e.Item("project_id"), "").ToString <> "" Then
                    sql_join &= String.Format(" AND a.project_id = '{0}'", dic_e.Item("project_id"))
                End If
                sql_join &= String.Format("   GROUP BY a.account_id " &
                ") e ON e.account_id = chart.account_id ", dic_e.Item("month_from"), dic_e.Item("year_from"))
            End If
        End If
        Dim sql_select As String = String.Format("SELECT chart.* ")
        If sql_join <> "" Then
            sql_select &= vbNewLine & String.Format("{0} ", sql_select_amount)
            sql_select &= vbNewLine & String.Format("{0} ", sql_select_amount_based)
            If FS_Type = 2 Then
                sql = String.Format("{0} " &
                    "FROM {2}.SelectIncomeExpenseChart chart " &
                    "{1}" &
                    "", sql_select, sql_join, _serverDBMain)
            Else
                sql = String.Format("{0} " &
                    "FROM {2}.SelectAllChart chart " &
                    "{1}" &
                    "", sql_select, sql_join, _serverDBMain)
            End If

            Dim sql_company As String = String.Format("SELECT a.company_id,a.company_code,a.company_name " &
                ",a.address1 AS address,a.tin " &
                "FROM lib_erp_company a " &
                "WHERE a.company_id = '{0}' " &
                "", main.Sys_Default.Rows(0).Item("company_id"))

            Dim sql_template As String = String.Format("SELECT a.template_id,a.template_code,a.template_name,a.title1,a.title2,a.title3 " &
                "FROM sys_fs_template a " &
                "WHERE a.template_id = '{0}' " &
                "", template_id)

            Dim sql_template_det As String = String.Format("SELECT a.template_det_id,a.template_id " &
                ",a.command_code,IFNULL(a.row_type,1) AS row_type,a.account_id,a.chart_group_id,a.display_text,a.column_num " &
                ",a.group_var,a.add_sub,a.repeat_num,a.show_zero,a.indent_num,a.order_by,a.computation " &
                ",IF(a.row_type = '0',b.account_code,c.chart_group_code) AS chart_code " &
                ",IF(a.row_type = '0',b.account_name,c.chart_group_name) AS chart_name " &
                "FROM sys_fs_template_det a " &
                "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                "LEFT JOIN {1}.lib_acc_chart_group c ON c.chart_group_id = a.chart_group_id " &
                "WHERE a.template_id = '{0}' " &
                "ORDER BY a.order_by ASC " &
                "", template_id, _serverDBFS)

            Dim dt_company As DataTable = FsQuery(sql_company)
            Dim dt As DataTable = FsQuery(sql)
            Dim dt_template As DataTable = FsQuery(sql_template)
            Dim dt_template_det As DataTable = FsQuery(sql_template_det)

            Dim ds As New FSDesign_set

            For Each dr As DataRow In dt.Rows
                ds.Tables("Balance").ImportRow(dr)
            Next
            For Each dr As DataRow In dt_company.Rows
                ds.Tables("Company").ImportRow(dr)
            Next
            If reportOption = "1" Then
                'SplashScreenManager.ShowForm(GetType(SCLoad))
                Try
                    lblLoad.Visible = True
                    GenerateExcelFSDesign(dic_all, dt_template, dt_template_det, ds.Tables("Balance"))
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'SplashScreenManager.CloseForm()
                'MsgBox("Report Done")
            Else
                Dim rep As New fsdesign_print
                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                If dt_template.Rows.Count > 0 Then
                    Dim cols = "a,b,c,d,e".Split(",")
                    Dim col = ""
                    rep.lblTitle1.Text = dt_template.Rows(0).Item("title1").ToString
                    rep.lblTitle2.Text = dt_template.Rows(0).Item("title2").ToString
                    rep.lblTitle3.Text = dt_template.Rows(0).Item("title3").ToString
                    For Each c In cols
                        If dt.Columns.Contains(c & "_amount") Then
                            col &= "," & c
                        End If
                    Next
                    generateReport(dic_all, dt_template_det, ds.Tables("Balance"), rep.Detail, rep, col.Substring(1))
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                Else
                    MsgBox("No template.")
                End If
            End If
        Else
            MsgBox("Select at least one filter.")
        End If
    End Sub

    Private Sub generateReport(ByVal dic As Dictionary(Of String, Dictionary(Of String, String)), ByVal dt_template As DataTable, ByVal dt_balance As DataTable, ByRef rep As DetailBand, ByRef xrep As XtraReport, ByVal col As String)
        Dim cols = col.Split(",")
        If cols.Length >= 3 Then
            xrep.Landscape = True
        Else
            xrep.Landscape = False
        End If
        Dim body As New XRRichText
        body.Text = ""
        body.WidthF = xrep.PageWidth - (xrep.Margins.Left + xrep.Margins.Right)
        body.Html = String.Format("")
        rep.Controls.Add(body)

        Dim dicComputation As New Dictionary(Of String, Dictionary(Of String, Decimal))

        'Dim table As String = String.Format("<table style=""font:{1}pt '{0}';"">", xrep.Font.FontFamily.Name, xrep.Font.SizeInPoints)
        Dim table As String = String.Format("<table class=""table-border"" style=""font:{1}pt '{0}';"">", xrep.Font.FontFamily.Name, xrep.Font.SizeInPoints)
        Dim tmptr As String = String.Format("<tr>")
        'For i As Integer = 0 To cols.Length
        '    Dim td As String = String.Format("<th></th>")
        '    tmptr &= td
        'Next
        tmptr &= "<th></th>"
        For Each d In dic
            If d.Value.Item("enable") Then
                Dim td As String = String.Format("<th>" & d.Value.Item("label_from").ToString & "</th>")
                tmptr &= td
            End If
        Next
        tmptr &= String.Format("</tr>")
        table &= tmptr
        tmptr = "<tr>"
        tmptr &= "<th></th>"
        For Each d In dic
            If d.Value.Item("enable") Then
                Dim td As String = String.Format("<th>" & d.Value.Item("label_to").ToString & "</th>")
                tmptr &= td
            End If
        Next
        tmptr &= String.Format("</tr>")
        table &= tmptr
        Dim lstFormatter = "B,BU,BI,I,U".Split(",")
        Dim ctr = 0
        Dim lstLine = "D,G,L,S,T".Split(",")
        Dim lstText = "P,H,IN".Split(",")
        Dim isB As Boolean = False
        Dim isBU As Boolean = False
        Dim isBI As Boolean = False
        Dim isI As Boolean = False
        Dim isU As Boolean = False
        Dim currentY As Integer = 0
        For Each row As DataRow In dt_template.Rows
            Dim isD As Boolean = False
            Dim isG As Boolean = False
            Dim isL As Boolean = False
            Dim isS As Boolean = False
            Dim isT As Boolean = False
            If lstFormatter.Contains(row.Item("command_code").ToString) Then
                Select Case row.Item("command_code").ToString
                    Case "B"
                        isB = True
                    Case "BU"
                        isBU = True
                    Case "BI"
                        isBI = True
                    Case "I"
                        isI = True
                    Case "U"
                        isU = True
                End Select
            End If
            If lstLine.Contains(row.Item("command_code").ToString) Then
                Select Case row.Item("command_code").ToString
                    Case "D"
                        isD = True
                    Case "G"
                        isG = True
                    Case "L"
                        isL = True
                    Case "S"
                        isS = True
                        Dim tr = "<tr>"
                        For i = 0 To cols.Length
                            tr &= "<td></td>"
                        Next
                        tr &= "</tr>"
                        table &= tr
                    Case "T"
                        isT = True
                End Select
                If isL Or isD Or isG Or isT Then
                    Dim tr = "<tr>"
                    tr &= "<td></td>"
                    For i = 0 To cols.Length - 1
                        tr &= "<td style="""
                        tr &= "border-top:1px solid #000000;height:5px;"
                        If isD Then
                            tr &= "border-style:double;border-size:3px;"
                        End If
                        If isG Then
                            tr &= "border-style:double;font-weight:bold;border-size:3px;"
                        End If
                        If isT Then
                            tr &= "border-style:solid;font-weight:bold;border-size:3px;"
                        End If
                        tr &= """></td>"
                    Next
                    tr &= "</tr>"
                    table &= tr
                End If
            End If
            If row.Item("command_code").ToString = "N" Then
                isB = False
                isBU = False
                isBI = False
                isI = False
                isU = False
            End If
            If lstText.Contains(row.Item("command_code").ToString) Then
                Select Case row.Item("command_code").ToString
                    Case "P"
                        Dim strSpace As String = ""
                        If row.Item("indent_num").ToString <> "" Or row.Item("indent_num").ToString <> "0" Then
                            For i As Integer = 0 To CInt(row.Item("indent_num").ToString) - 1
                                strSpace &= "&nbsp;"
                            Next
                        End If
                        Dim tr As String = String.Format("<tr>")
                        Dim td As String = String.Format("<td ")
                        Dim style As String = String.Format("style=""")
                        If isB Or isBU Or isBI Then
                            style &= String.Format("font-weight:bold;")
                        End If
                        If isBU Or isU Then
                            style &= String.Format("text-decoration:underline;")
                        End If
                        td &= style & """>"
                        If isBI Or isI Then
                            td &= String.Format("<i>")
                        End If
                        If row.Item("display_text").ToString <> "" Then
                            td &= strSpace & row.Item("display_text").ToString
                        Else
                            td &= strSpace & row.Item("chart_name").ToString
                        End If
                        If isBI Or isI Then
                            td &= String.Format("</i>")
                        End If
                        td &= String.Format("</td>")
                        tr &= td
                        If row.Item("row_type").ToString = "True" Or row.Item("row_type").ToString = "" Then
                            If row.Item("display_text").ToString <> "" Then
                                If ifNull(row.Item("computation"), "").ToString <> "" Then
                                    Dim currentFormula As String = row.Item("computation").ToString.Trim
                                    Dim currentTotal As New Dictionary(Of String, Decimal)
                                    While currentFormula <> ""
                                        Dim currentSign As String = currentFormula.Substring(0, 1)
                                        'Dim currentChar = currentCharacter(currentFormula)
                                        'If dicComputation.ContainsKey(currentChar) Then
                                        '    Dim currentDic = dicComputation.Item(currentChar)
                                        '    For Each d In currentDic
                                        '        If currentTotal.ContainsKey(d.Key) Then
                                        '            Dim strSign() = "-,+,*,/".Split(",")
                                        '            If strSign.Contains(currentSign) Then
                                        '                Select Case currentSign
                                        '                    Case "-"
                                        '                        currentTotal.Item(d.Key) -= d.Value
                                        '                    Case "+"
                                        '                        currentTotal.Item(d.Key) += d.Value
                                        '                    Case "/"
                                        '                        currentTotal.Item(d.Key) /= d.Value
                                        '                    Case "*"
                                        '                        currentTotal.Item(d.Key) *= d.Value
                                        '                End Select
                                        '            End If
                                        '        Else
                                        '            currentTotal.Add(d.Key, d.Value)
                                        '        End If
                                        '    Next
                                        'End If
                                        'If currentChar = "" Then
                                        '    currentFormula = currentFormula.Substring(1)
                                        'End If
                                    End While
                                    For Each d In currentTotal
                                        Dim val As String = d.Value
                                        If IsNumeric(val) Then
                                            val = String.Format("{0:##,##0.00}", CType(val, Decimal))
                                        End If
                                        tr &= "<td " & style & "text-align:right;"
                                        tr &= """>"
                                        If isBI Or isI Then
                                            tr &= "<i>"
                                        End If
                                        tr &= val
                                        If isBI Or isI Then
                                            tr &= "</i>"
                                        End If
                                        tr &= "</td>"
                                    Next
                                    If row.Item("group_var").ToString <> "" Then
                                        If dicComputation.ContainsKey(row.Item("group_var").ToString) Then
                                        Else
                                            dicComputation.Add(row.Item("group_var").ToString, currentTotal)
                                        End If
                                    End If
                                Else
                                    For i = 0 To cols.Length - 1
                                        tr &= "<td></td>"
                                    Next
                                End If
                                tr &= String.Format("</tr>")
                                table &= tr
                            End If
                        End If
                        If row.Item("row_type").ToString = "True" Or row.Item("row_type").ToString = "" Then
                            Dim dicGroup As New Dictionary(Of String, Decimal)
                            Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", row.Item("chart_group_id").ToString))
                            If drs.Length > 0 Then
                                For Each dr In drs
                                    tr = String.Format("<tr>")
                                    td = String.Format("<td ")
                                    style = String.Format("style=""")
                                    If isB Or isBU Or isBI Then
                                        style &= String.Format("font-weight:bold;")
                                    End If
                                    If isBU Or isU Then
                                        style &= String.Format("text-decoration:underline;")
                                    End If
                                    td &= style & """>"
                                    If isBI Or isI Then
                                        td &= String.Format("<i>")
                                    End If
                                    td &= String.Format(strSpace & "{0}", dr.Item("account_name").ToString)
                                    If isBI Or isI Then
                                        td &= String.Format("</i>")
                                    End If
                                    td &= String.Format("</td>")
                                    For Each c In cols
                                        td &= String.Format("<td {0}>", style & "text-align:right;vertical-align:top;""")
                                        If isBI Or isI Then
                                            td &= String.Format("<i>")
                                        End If
                                        Dim tmp_val = dr.Item(c & "_amount").ToString
                                        If IsNumeric(tmp_val) Then
                                            If dicGroup.ContainsKey(c) Then
                                                If row.Item("add_sub").ToString = "False" Then
                                                    dicGroup.Item(c) += tmp_val
                                                Else
                                                    dicGroup.Item(c) -= tmp_val
                                                End If
                                            Else
                                                dicGroup.Add(c, tmp_val)
                                            End If
                                            tmp_val = String.Format("{0:##,##0.00}", CType(tmp_val, Decimal))
                                        End If
                                        If row.Item("show_zero").ToString = "False" Then
                                            If CType(tmp_val, Decimal) = 0 Then
                                                tmp_val = ""
                                            End If
                                        End If
                                        td &= String.Format("{0}", tmp_val)
                                        If isBI Or isI Then
                                            td &= String.Format("</i>")
                                        End If
                                        td &= "</td>"
                                    Next
                                    tr &= td
                                    tr &= String.Format("</tr>")
                                    table &= tr
                                    If row.Item("group_var").ToString <> "" Then
                                        If dicComputation.ContainsKey(row.Item("group_var").ToString) Then
                                        Else
                                            dicComputation.Add(row.Item("group_var").ToString, dicGroup)
                                        End If
                                    End If
                                Next
                            End If
                        Else
                            Dim dicGroup As New Dictionary(Of String, Decimal)
                            Dim drs = dt_balance.Select(String.Format("account_id = '{0}'", row.Item("account_id").ToString))
                            If drs.Length > 0 Then
                                For Each dr In drs
                                    tr = String.Format("<tr>")
                                    td = String.Format("<td ")
                                    style = String.Format("style=""")
                                    If isB Or isBU Or isBI Then
                                        style &= String.Format("font-weight:bold;")
                                    End If
                                    If isBU Or isU Then
                                        style &= String.Format("text-decoration:underline;")
                                    End If
                                    td &= style & """>"
                                    If isBI Or isI Then
                                        td &= String.Format("<i>")
                                    End If
                                    td &= String.Format("{0}", dr.Item("account_name").ToString)
                                    If isBI Or isI Then
                                        td &= String.Format("</i>")
                                    End If
                                    td &= String.Format("</td>")
                                    For Each c In cols
                                        td &= String.Format("<td {0}>", style & "text-align:right;vertical-align:top;""")
                                        If isBI Or isI Then
                                            td &= String.Format("<i>")
                                        End If
                                        Dim tmp_val = dr.Item(c & "_amount").ToString
                                        If IsNumeric(tmp_val) Then
                                            If dicGroup.ContainsKey(c) Then
                                                If row.Item("add_sub").ToString = "False" Then
                                                    dicGroup.Item(c) += tmp_val
                                                Else
                                                    dicGroup.Item(c) -= tmp_val
                                                End If
                                            Else
                                                dicGroup.Add(c, tmp_val)
                                            End If
                                            tmp_val = String.Format("{0:##,##0.00}", CType(tmp_val, Decimal))
                                        End If
                                        If row.Item("show_zero").ToString = "False" Then
                                            If CType(tmp_val, Decimal) = 0 Then
                                                tmp_val = ""
                                            End If
                                        End If
                                        td &= String.Format("{0}", tmp_val)
                                        If isBI Or isI Then
                                            td &= String.Format("</i>")
                                        End If
                                        td &= "</td>"
                                    Next
                                    tr &= td
                                    tr &= String.Format("</tr>")
                                    table &= tr
                                    If row.Item("group_var").ToString <> "" Then
                                        If dicComputation.ContainsKey(row.Item("group_var").ToString) Then
                                        Else
                                            dicComputation.Add(row.Item("group_var").ToString, dicGroup)
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    Case "H"
                        If row.Item("row_type").ToString = "True" Or row.Item("row_type").ToString = "" Then
                            If ifNull(row.Item("computation"), "").ToString <> "" Then
                                Dim currentFormula As String = row.Item("computation").ToString.Trim
                                Dim currentTotal As New Dictionary(Of String, Decimal)
                                While currentFormula <> ""
                                    Dim currentSign As String = currentFormula.Substring(0, 1)
                                    'Dim currentChar = currentCharacter(currentFormula)
                                    'If dicComputation.ContainsKey(currentChar) Then
                                    '    Dim currentDic = dicComputation.Item(currentChar)
                                    '    For Each d In currentDic
                                    '        If currentTotal.ContainsKey(d.Key) Then
                                    '            Dim strSign() = "-,+,*,/".Split(",")
                                    '            If strSign.Contains(currentSign) Then
                                    '                Select Case currentSign
                                    '                    Case "-"
                                    '                        currentTotal.Item(d.Key) -= d.Value
                                    '                    Case "+"
                                    '                        currentTotal.Item(d.Key) += d.Value
                                    '                    Case "/"
                                    '                        currentTotal.Item(d.Key) /= d.Value
                                    '                    Case "*"
                                    '                        currentTotal.Item(d.Key) *= d.Value
                                    '                End Select
                                    '            End If
                                    '        Else
                                    '            currentTotal.Add(d.Key, d.Value)
                                    '        End If
                                    '    Next
                                    'End If
                                    'If currentChar = "" Then
                                    '    currentFormula = currentFormula.Substring(1)
                                    'End If
                                End While
                                If row.Item("group_var").ToString <> "" Then
                                    If dicComputation.ContainsKey(row.Item("group_var").ToString) Then
                                    Else
                                        dicComputation.Add(row.Item("group_var").ToString, currentTotal)
                                    End If
                                End If
                            End If
                        End If
                        If row.Item("row_type").ToString = "True" Or row.Item("row_type").ToString = "" Then
                            Dim dicGroup As New Dictionary(Of String, Decimal)
                            Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", row.Item("chart_group_id").ToString))
                            If drs.Length > 0 Then
                                For Each dr In drs
                                    For Each c In cols
                                        Dim tmp_val = dr.Item(c & "_amount").ToString
                                        If IsNumeric(tmp_val) Then
                                            If dicGroup.ContainsKey(c) Then
                                                If row.Item("add_sub").ToString = "False" Then
                                                    dicGroup.Item(c) += tmp_val
                                                Else
                                                    dicGroup.Item(c) -= tmp_val
                                                End If
                                            Else
                                                dicGroup.Add(c, tmp_val)
                                            End If
                                        End If
                                    Next
                                    If row.Item("group_var").ToString <> "" Then
                                        If dicComputation.ContainsKey(row.Item("group_var").ToString) Then
                                        Else
                                            dicComputation.Add(row.Item("group_var").ToString, dicGroup)
                                        End If
                                    End If
                                Next
                            End If
                        Else
                            Dim dicGroup As New Dictionary(Of String, Decimal)
                            Dim drs = dt_balance.Select(String.Format("account_id = '{0}'", row.Item("account_id").ToString))
                            If drs.Length > 0 Then
                                For Each dr In drs
                                    For Each c In cols
                                        Dim tmp_val = dr.Item(c & "_amount").ToString
                                        If IsNumeric(tmp_val) Then
                                            If dicGroup.ContainsKey(c) Then
                                                If row.Item("add_sub").ToString = "False" Then
                                                    dicGroup.Item(c) += tmp_val
                                                Else
                                                    dicGroup.Item(c) -= tmp_val
                                                End If
                                            Else
                                                dicGroup.Add(c, tmp_val)
                                            End If
                                        End If
                                    Next
                                    If row.Item("group_var").ToString <> "" Then
                                        If dicComputation.ContainsKey(row.Item("group_var").ToString) Then
                                        Else
                                            dicComputation.Add(row.Item("group_var").ToString, dicGroup)
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    Case "IN"
                End Select
            End If
        Next
        table &= String.Format("</table>")
        'Dim html = "<div style=""background:#CCC;height:100px;"">"  & _
        '    "<style>"  & _
        '    "   .table-border {"  & _
        '    "       border-spacing:1px;"  & _
        '    "       border-collapse:collapse;"  & _
        '    "       width:100%;"  & _
        '    "   }"  & _
        '    "   .table-border td,th{"  & _
        '    "       border:1px solid #505050;"  & _
        '    "       border-spacing:1px;"  & _
        '    "   }"  & _
        '    "</style>"  & _
        '    "" & table.ToString & "</div>"
        Dim html = "<div style=""background:#CCC;height:100px;"">" &
            "<style>" &
            "   .table-border {" &
            "       border-spacing:1px;" &
            "       border-collapse:collapse;" &
            "       width:100%;" &
            "   }" &
            "   .table-border td,th{" &
            "   }" &
            "</style>" &
            "" & table.ToString & "</div>"
        body.Html = html
    End Sub
    'Private Function currentCharacter(ByRef str As String) As String
    '    Dim returnStr As String = ""
    '    Dim strRemove() = "(,),-,+,*,/".Split(",")
    '    If str.Length > 1 Then
    '        If strRemove.Contains(str.Substring(0, 1)) Then
    '            str = str.Substring(1)
    '            returnStr = currentCharacter(str)
    '        Else
    '            Dim currentIndex As Integer = 0
    '            getNextCharacter(str, currentIndex, returnStr)
    '        End If
    '    Else
    '        Dim currentIndex As Integer = 0
    '        getNextCharacter(str, currentIndex, returnStr)
    '    End If
    '    Return returnStr
    'End Function
    'Private Function getNextCharacter(ByRef str As String, ByRef index As Integer, ByRef returnStr As String) As String
    '    Dim strRemove() = "(,),-,+,*,/".Split(",")
    '    If str.Length >= 1 Then
    '        While Not strRemove.Contains(str.Substring(0, 1))
    '            returnStr &= str.Substring(0, 1)
    '            index += 1
    '            str = str.Substring(1)
    '            getNextCharacter(str, index, returnStr)
    '            If str = "" Then
    '                Exit While
    '            End If
    '        End While
    '    End If
    '    Return returnStr
    'End Function
    Private Sub generateExcelReport(ByVal dic As Dictionary(Of String, Dictionary(Of String, String)), _
                                    ByVal dt_template As DataTable, _
                                    ByVal dt_template_det As DataTable, _
                                    ByVal dt_balance As DataTable)

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True

        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1).ColumnWidth = 35
        Dim last_column As Integer = 1
        For Each a In dic
            If a.Value.Item("enable") Then
                last_column += 1
                xlWorkSheet.Cells(1, last_column).ColumnWidth = 15
                xlWorkSheet.Cells(6, last_column) = "'" & a.Value.Item("label_from").ToString
                xlWorkSheet.Cells(7, last_column) = "'" & a.Value.Item("label_to").ToString
            End If
        Next

        xlWorkSheet.Cells(1, 1) = main.Sys_Default.Rows(0).Item("company_name").ToString.ToUpper
        xlWorkSheet.Cells(2, 1) = ifNull(dt_template.Rows(0).Item("title1").ToString.ToUpper, "")
        xlWorkSheet.Cells(3, 1) = ifNull(dt_template.Rows(0).Item("title2").ToString.ToUpper, "")
        xlWorkSheet.Cells(4, 1) = ifNull(dt_template.Rows(0).Item("title3").ToString.ToUpper, "")
        'xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, last_column)).MergeCells = True
        'xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, last_column)).MergeCells = True
        'xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, last_column)).MergeCells = True
        'xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, last_column)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(7, last_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(7, 1), xlWorkSheet.Cells(7, last_column)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(7, 1), xlWorkSheet.Cells(7, last_column)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Dim current_row As Integer = 8
        Dim current_column As Integer = 1

        Dim lstVar As New List(Of String)
        Dim dicGroup As New Dictionary(Of String, Dictionary(Of String, Decimal))
        Dim dicTotal As New Dictionary(Of String, Dictionary(Of String, Decimal))

        Dim double_line As Boolean = False
        Dim single_line As Boolean = False
        Dim grand_total_format As Boolean = False
        Dim total_format As Boolean = False
        Dim insert_before As Boolean = False
        Dim normal As Boolean = False
        Dim skip As Boolean = False
        Dim bold As Boolean = False
        Dim italic As Boolean = False
        Dim underline As Boolean = False

        For Each drTemplate As DataRow In dt_template_det.Rows
            Dim hidden As Boolean = False
            Select Case drTemplate.Item("command_code").ToString
                Case "B"
                    normal = False
                    bold = True
                Case "BI"
                    normal = False
                    bold = True
                    italic = True
                Case "BU"
                    normal = False
                    bold = True
                    underline = True
                Case "D"
                    double_line = True
                Case "G"
                    grand_total_format = True
                Case "H"
                    '
                    Dim computation As String = ifNull(drTemplate.Item("computation").ToString, "")

                    If computation <> "" Then
                        For Each var In dicGroup
                            If Not lstVar.Contains(var.Key) Then
                                lstVar.Add(var.Key)
                            End If
                        Next

                        Dim sortedVar = From var In lstVar.ToArray Order By var.ToString.Length Descending Select var

                        For Each a In dic
                            If a.Value.Item("enable") Then
                                Dim strParsedFormulaWithValue As String = computation
                                Dim decValue As Decimal = 0.0
                                For Each var In sortedVar
                                    If dicGroup.ContainsKey(var) Then
                                        Dim dicCurrentVar = dicGroup.Item(var)
                                        strParsedFormulaWithValue = strParsedFormulaWithValue.Replace(var, CDec(ifNull(dicCurrentVar.Item(a.Key).ToString, 0)))
                                    End If
                                Next
                                decValue = New DataTable().Compute(strParsedFormulaWithValue, Nothing)
                                If Not dicTotal.ContainsKey(a.Key) Then
                                    dicTotal.Item(a.Key) = New Dictionary(Of String, Decimal)
                                End If

                                Dim group_name As String = ifNull(drTemplate.Item("group_var").ToString, "")
                                If group_name <> "" Then
                                    Dim newDic As New Dictionary(Of String, Decimal)

                                    If dicGroup.ContainsKey(group_name) Then
                                        newDic = dicGroup.Item(group_name)
                                        If newDic.ContainsKey(a.Key) Then
                                            newDic.Item(a.Key) = decValue
                                        Else
                                            newDic.Add(a.Key, decValue)
                                        End If
                                        dicGroup.Item(group_name) = newDic
                                    Else
                                        newDic.Add(a.Key, decValue)
                                        dicGroup.Add(group_name, newDic)
                                    End If
                                    dicTotal.Item(a.Key).Add(group_name, decValue)

                                    'If group_name <> "" Then
                                    '    If dicGroup.ContainsKey(group_name) Then
                                    '        dicGroup.Item(group_name) = newDic
                                    '    Else
                                    '        dicGroup.Add(group_name, newDic)
                                    '    End If
                                    'End If
                                Else
                                    If Not dicTotal.Item(a.Key).ContainsKey(computation) Then
                                        dicTotal.Item(a.Key).Add(computation, decValue)
                                    End If
                                End If

                                'xlWorkSheet.Cells(current_row, current_column) = decValue
                                'current_column += 1
                            End If
                        Next
                    Else
                        If drTemplate.Item("row_type") Then 'Chart Group
                            Dim chart_group_id = drTemplate.Item("chart_group_id").ToString
                            Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", chart_group_id))

                            Dim group_name As String = ifNull(drTemplate.Item("group_var").ToString, "")
                            Dim newDic As New Dictionary(Of String, Decimal)

                            If drs.Length > 0 Then
                                For Each dr As DataRow In drs
                                    current_column = 1
                                    'xlWorkSheet.Cells(current_row, current_column) = dr.Item("account_name").ToString
                                    current_column += 1
                                    For Each a In dic
                                        If a.Value.Item("enable") Then
                                            Dim newName As String = ifNull(a.Key, "")
                                            Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                            'xlWorkSheet.Cells(current_row, current_column) = amount
                                            If newDic.ContainsKey(newName) Then
                                                newDic.Item(newName) += amount
                                            Else
                                                newDic.Add(newName, amount)
                                            End If
                                            current_column += 1
                                        End If
                                    Next
                                    'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                    'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = bold
                                    'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = italic
                                    'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = underline
                                    'If double_line Then
                                    '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                    '        .LineStyle = Excel.XlLineStyle.xlDouble
                                    '        .Weight = Excel.XlBorderWeight.xlThin
                                    '    End With
                                    'End If
                                    'If grand_total_format Then
                                    '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                    '        .LineStyle = Excel.XlLineStyle.xlDouble
                                    '        .Weight = Excel.XlBorderWeight.xlThick
                                    '    End With
                                    'End If
                                    'If single_line Then
                                    '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                    '        .LineStyle = Excel.XlLineStyle.xlContinuous
                                    '        .Weight = Excel.XlBorderWeight.xlThin
                                    '    End With
                                    'End If
                                    'If total_format Then
                                    '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                    '        .LineStyle = Excel.XlLineStyle.xlContinuous
                                    '        .Weight = Excel.XlBorderWeight.xlThick
                                    '    End With
                                    'End If
                                    'current_row += 1
                                Next
                            End If
                            If group_name <> "" Then
                                If dicGroup.ContainsKey(group_name) Then
                                    dicGroup.Item(group_name) = newDic
                                Else
                                    dicGroup.Add(group_name, newDic)
                                End If
                            End If
                        Else
                            Dim group_name As String = ifNull(drTemplate.Item("group_var").ToString, "")
                            Dim newDic As New Dictionary(Of String, Decimal)

                            Dim account_id As String = drTemplate.Item("account_id").ToString
                            current_column = 1
                            'xlWorkSheet.Cells(current_row, current_column) = drTemplate.Item("chart_name").ToString
                            current_column += 1
                            Dim drs = dt_balance.Select(String.Format("account_id = '{0}'", account_id))
                            If drs.Length > 0 Then
                                Dim dr = drs(0)
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        Dim newName As String = ifNull(a.Key.ToString, "")
                                        Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                        'xlWorkSheet.Cells(current_row, current_column) = amount
                                        If newDic.ContainsKey(newName) Then
                                            newDic.Item(newName) += amount
                                        Else
                                            newDic.Add(newName, amount)
                                        End If
                                        current_column += 1
                                    End If
                                Next
                            End If
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = bold
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = italic
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = underline
                            'If double_line Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            '        .LineStyle = Excel.XlLineStyle.xlDouble
                            '        .Weight = Excel.XlBorderWeight.xlThin
                            '    End With
                            'End If
                            'If grand_total_format Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            '        .LineStyle = Excel.XlLineStyle.xlDouble
                            '        .Weight = Excel.XlBorderWeight.xlThick
                            '    End With
                            'End If
                            'If single_line Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            '        .LineStyle = Excel.XlLineStyle.xlContinuous
                            '        .Weight = Excel.XlBorderWeight.xlThin
                            '    End With
                            'End If
                            'If total_format Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            '        .LineStyle = Excel.XlLineStyle.xlContinuous
                            '        .Weight = Excel.XlBorderWeight.xlThick
                            '    End With
                            'End If
                            'If group_name <> "" Then
                            '    If dicGroup.ContainsKey(group_name) Then
                            '        dicGroup.Item(group_name) = newDic
                            '    Else
                            '        dicGroup.Add(group_name, newDic)
                            '    End If
                            'End If
                            'current_row += 1
                        End If
                    End If

                    double_line = False
                    grand_total_format = False
                    insert_before = False
                    single_line = False
                    total_format = False
                Case "I"
                    normal = False
                    italic = True
                Case "IN"
                    insert_before = True
                Case "L"
                    single_line = True
                Case "N"
                    normal = True
                    bold = False
                    italic = False
                    underline = False
                Case "P"
                    If drTemplate.Item("display_text").ToString <> "" Then
                        current_column = 1
                        xlWorkSheet.Cells(current_row, current_column) = drTemplate.Item("display_text").ToString
                        current_column += 1

                        Dim computation As String = ifNull(drTemplate.Item("computation").ToString, "")

                        If computation <> "" Then
                            For Each var In dicGroup
                                If Not lstVar.Contains(var.Key) Then
                                    lstVar.Add(var.Key)
                                End If
                            Next

                            Dim sortedVar = From var In lstVar.ToArray Order By var.ToString.Length Descending Select var

                            For Each a In dic
                                If a.Value.Item("enable") Then
                                    Dim strParsedFormulaWithValue As String = computation
                                    Dim decValue As Decimal = 0.0
                                    For Each var In sortedVar
                                        If dicGroup.ContainsKey(var) Then
                                            Dim dicCurrentVar = dicGroup.Item(var)
                                            strParsedFormulaWithValue = strParsedFormulaWithValue.Replace(var, CDec(ifNull(dicCurrentVar.Item(a.Key).ToString, 0)))
                                        End If
                                    Next
                                    Try
                                        decValue = New DataTable().Compute(strParsedFormulaWithValue, Nothing)
                                    Catch ex As Exception
                                        MyDebugging.AddText(ex.Message)
                                        decValue = 0
                                    End Try
                                    If Not dicTotal.ContainsKey(a.Key) Then
                                        dicTotal.Item(a.Key) = New Dictionary(Of String, Decimal)
                                    End If

                                    Dim group_name As String = ifNull(drTemplate.Item("group_var").ToString, "")
                                    If group_name <> "" Then
                                        Dim newDic As New Dictionary(Of String, Decimal)

                                        If dicGroup.ContainsKey(group_name) Then
                                            newDic = dicGroup.Item(group_name)
                                            If newDic.ContainsKey(a.Key) Then
                                                newDic.Item(a.Key) = decValue
                                            Else
                                                newDic.Add(a.Key, decValue)
                                            End If
                                            dicGroup.Item(group_name) = newDic
                                        Else
                                            newDic.Add(a.Key, decValue)
                                            dicGroup.Add(group_name, newDic)
                                        End If
                                        dicTotal.Item(a.Key).Add(group_name, decValue)
                                    Else
                                        If Not dicTotal.Item(a.Key).ContainsKey(computation) Then
                                            dicTotal.Item(a.Key).Add(computation, decValue)
                                        End If
                                    End If

                                    xlWorkSheet.Cells(current_row, current_column) = decValue
                                    current_column += 1
                                End If
                            Next
                        End If
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = bold
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = italic
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = underline
                        If double_line Then
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                .LineStyle = Excel.XlLineStyle.xlDouble
                                .Weight = Excel.XlBorderWeight.xlThin
                            End With
                        End If
                        If grand_total_format Then
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                .LineStyle = Excel.XlLineStyle.xlDouble
                                .Weight = Excel.XlBorderWeight.xlThick
                            End With
                        End If
                        If single_line Then
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlThin
                            End With
                        End If
                        If total_format Then
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlThick
                            End With
                        End If
                        current_row += 1
                    Else
                        If drTemplate.Item("row_type") Then 'Chart Group
                            Dim chart_group_id = drTemplate.Item("chart_group_id").ToString
                            Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", chart_group_id))

                            Dim group_name As String = ifNull(drTemplate.Item("group_var").ToString, "")
                            Dim newDic As New Dictionary(Of String, Decimal)

                            If drs.Length > 0 Then
                                For Each dr As DataRow In drs
                                    current_column = 1
                                    xlWorkSheet.Cells(current_row, current_column) = dr.Item("account_name").ToString
                                    current_column += 1
                                    For Each a In dic
                                        If a.Value.Item("enable") Then
                                            Dim newName As String = ifNull(a.Key, "")
                                            Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                            xlWorkSheet.Cells(current_row, current_column) = amount
                                            If newDic.ContainsKey(newName) Then
                                                newDic.Item(newName) += amount
                                            Else
                                                newDic.Add(newName, amount)
                                            End If
                                            current_column += 1
                                        End If
                                    Next
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = bold
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = italic
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = underline
                                    If double_line Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                    End If
                                    If grand_total_format Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If single_line Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                    End If
                                    If total_format Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    current_row += 1
                                Next
                            End If
                            If group_name <> "" Then
                                If dicGroup.ContainsKey(group_name) Then
                                    dicGroup.Item(group_name) = newDic
                                Else
                                    dicGroup.Add(group_name, newDic)
                                End If
                            End If
                        Else 'Chart of Account
                            Dim group_name As String = ifNull(drTemplate.Item("group_var").ToString, "")
                            Dim newDic As New Dictionary(Of String, Decimal)

                            Dim account_id As String = drTemplate.Item("account_id").ToString
                            current_column = 1
                            xlWorkSheet.Cells(current_row, current_column) = drTemplate.Item("chart_name").ToString
                            current_column += 1
                            Dim drs = dt_balance.Select(String.Format("account_id = '{0}'", account_id))
                            If drs.Length > 0 Then
                                Dim dr = drs(0)
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        Dim newName As String = ifNull(a.Key.ToString, "")
                                        Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                        xlWorkSheet.Cells(current_row, current_column) = amount
                                        If newDic.ContainsKey(newName) Then
                                            newDic.Item(newName) += amount
                                        Else
                                            newDic.Add(newName, amount)
                                        End If
                                        current_column += 1
                                    End If
                                Next
                            End If
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = bold
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = italic
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = underline
                            If double_line Then
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                    .LineStyle = Excel.XlLineStyle.xlDouble
                                    .Weight = Excel.XlBorderWeight.xlThin
                                End With
                            End If
                            If grand_total_format Then
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                    .LineStyle = Excel.XlLineStyle.xlDouble
                                    .Weight = Excel.XlBorderWeight.xlThick
                                End With
                            End If
                            If single_line Then
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                    .LineStyle = Excel.XlLineStyle.xlContinuous
                                    .Weight = Excel.XlBorderWeight.xlThin
                                End With
                            End If
                            If total_format Then
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                    .LineStyle = Excel.XlLineStyle.xlContinuous
                                    .Weight = Excel.XlBorderWeight.xlThick
                                End With
                            End If
                            If group_name <> "" Then
                                If dicGroup.ContainsKey(group_name) Then
                                    dicGroup.Item(group_name) = newDic
                                Else
                                    dicGroup.Add(group_name, newDic)
                                End If
                            End If
                            current_row += 1
                        End If
                    End If

                    double_line = False
                    grand_total_format = False
                    insert_before = False
                    single_line = False
                    total_format = False
                Case "S"
                    skip = True
                    current_row += 1
                Case "T"
                    total_format = True
                Case "U"
                    normal = False
                    underline = True
            End Select
        Next
    End Sub
    Private Sub btnDone_Click_1(sender As Object, e As EventArgs) Handles btnDone.Click
        PrintReport(1)
    End Sub
    Private Sub GenerateExcelFSDesign(ByVal dic As Dictionary(Of String, Dictionary(Of String, String)),
                                    ByVal dt_template As DataTable,
                                    ByVal dt_template_det As DataTable,
                                    ByVal dt_balance As DataTable)
        Dim ShowAccountCode As Boolean = CBool(ifNull(txtAccountCode.Checked, 0))

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.DisplayAlerts = False
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True

        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1).ColumnWidth = 35
        Dim last_column As Integer = 1
        If ShowAccountCode Then
            last_column = 2
            xlWorkSheet.Cells(1, 1).ColumnWidth = 15
            xlWorkSheet.Cells(1, 2).ColumnWidth = 35
        End If
        For Each a In dic
            If a.Value.Item("enable") Then
                last_column += 1
                xlWorkSheet.Cells(1, last_column).ColumnWidth = 15
                'xlWorkSheet.Cells(6, last_column) = "'" & a.Value.Item("project_name").ToString
                xlWorkSheet.Cells(6, last_column) = "'" & a.Value.Item("label_from").ToString
                xlWorkSheet.Cells(7, last_column) = "'" & a.Value.Item("label_to").ToString
            End If
        Next

        xlWorkSheet.Cells(1, 1) = main.Sys_Default.Rows(0).Item("company_name").ToString.ToUpper
        xlWorkSheet.Cells(2, 1) = ifNull(txt_project_name.Text.ToString.ToUpper, "")
        xlWorkSheet.Cells(3, 1) = ifNull(dt_template.Rows(0).Item("title1").ToString.ToUpper, "")
        xlWorkSheet.Cells(4, 1) = ifNull(dt_template.Rows(0).Item("title2").ToString.ToUpper, "")
        xlWorkSheet.Cells(5, 1) = ifNull(dt_template.Rows(0).Item("title3").ToString.ToUpper, "")
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, last_column)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, last_column)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, last_column)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, last_column)).MergeCells = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(7, last_column)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(7, last_column)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(7, last_column)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Dim dicFont As New Dictionary(Of String, Boolean)
        dicFont.Add("B", False) 'bold
        dicFont.Add("I", False) 'italic
        dicFont.Add("U", False) 'underline
        dicFont.Add("BI", False) 'bold italic
        dicFont.Add("BU", False) 'bold underline
        dicFont.Add("N", True) 'normal

        Dim dicLine As New Dictionary(Of String, Boolean)
        dicLine.Add("D", False) 'double line
        dicLine.Add("G", False) 'double line bold
        dicLine.Add("L", False) 'single line
        dicLine.Add("T", False) 'total single line bold

        Dim dicPrint As New Dictionary(Of String, Boolean)
        dicPrint.Add("H", False) 'hide
        dicPrint.Add("I", False) 'insert
        dicPrint.Add("P", False) 'print
        dicPrint.Add("S", False) 'new line

        Dim current_index As Integer = 0
        Dim lstVar As New List(Of String)
        '                                 group              var total
        Dim dicGroup As New Dictionary(Of String, Dictionary(Of String, Decimal))
        Dim dicTotal As New Dictionary(Of String, Dictionary(Of String, Decimal))

        Dim current_row As Integer = 8
        Dim current_column As Integer = 1

        For Each item As DataRow In dt_template_det.Rows
            Dim indent_num As Integer = CInt(ifNull(item.Item("indent_num"), 0))
            Select Case ifNull(item.Item("command_code"), "").ToString
                Case "B"
                    dicFont.Item("B") = True
                Case "I"
                    dicFont.Item("I") = True
                Case "U"
                    dicFont.Item("U") = True
                Case "BI"
                    dicFont.Item("B") = True
                    dicFont.Item("I") = True
                Case "BU"
                    dicFont.Item("B") = True
                    dicFont.Item("U") = True
                Case "N"
                    dicFont.Item("B") = False
                    dicFont.Item("I") = False
                    dicFont.Item("U") = False
                    dicLine.Item("D") = False
                    dicLine.Item("G") = False
                    dicLine.Item("L") = False
                    dicLine.Item("T") = False
            End Select
            Select Case ifNull(item.Item("command_code"), "").ToString
                Case "D"
                    dicLine.Item("D") = True
                    dicLine.Item("G") = False
                    dicLine.Item("L") = False
                    dicLine.Item("T") = False
                Case "G"
                    dicLine.Item("D") = False
                    dicLine.Item("G") = True
                    dicLine.Item("L") = False
                    dicLine.Item("T") = False
                Case "L"
                    dicLine.Item("D") = False
                    dicLine.Item("G") = False
                    dicLine.Item("L") = True
                    dicLine.Item("T") = False
                Case "T"
                    dicLine.Item("D") = False
                    dicLine.Item("G") = False
                    dicLine.Item("L") = False
                    dicLine.Item("T") = True
            End Select
            If ifNull(item.Item("command_code"), "").ToString = "H" Then
#Region "Hidden Command"
                If item.Item("display_text").ToString <> "" Then
#Region "With Display Text"
                    Dim computation As String = ifNull(item.Item("computation").ToString, "")
                    'Dim display_text = item.Item("display_text").ToString()
                    Dim group_name As String = ifNull(item.Item("group_var").ToString, "")

                    'current_column = 1
                    'xlWorkSheet.Cells(current_row, current_column) = display_text
                    'current_column += 1
                    If computation <> "" Then
                        lstVar.Clear()
                        For Each a In dicGroup
                            lstVar.Add(a.Key)
                        Next
                        Dim sortedVar = From var In lstVar.ToArray Order By var.ToString.Length Descending Select var

                        For Each a In dic
                            If a.Value.Item("enable") Then
                                Dim strParsedFormulaWithValue As String = computation
                                Dim decValue As Decimal = 0.0
                                For Each var In sortedVar
                                    If dicGroup.ContainsKey(var) Then
                                        Dim dicCurrentVar = dicGroup.Item(var)
                                        strParsedFormulaWithValue = strParsedFormulaWithValue.Replace(var, CDec(ifNull(dicCurrentVar.Item(a.Key).ToString, 0)))
                                    End If
                                Next
                                decValue = New DataTable().Compute(strParsedFormulaWithValue, Nothing)
                                If Not dicTotal.ContainsKey(a.Key) Then
                                    dicTotal.Item(a.Key) = New Dictionary(Of String, Decimal)
                                End If
                                If group_name <> "" Then
                                    Dim newDic As New Dictionary(Of String, Decimal)

                                    If dicGroup.ContainsKey(group_name) Then
                                        newDic = dicGroup.Item(group_name)
                                        If newDic.ContainsKey(a.Key) Then
                                            newDic.Item(a.Key) = decValue
                                        Else
                                            newDic.Add(a.Key, decValue)
                                        End If
                                        dicGroup.Item(group_name) = newDic
                                    Else
                                        newDic.Add(a.Key, decValue)
                                        dicGroup.Add(group_name, newDic)
                                    End If
                                    dicTotal.Item(a.Key).Add(group_name, decValue)
                                Else
                                    If Not dicTotal.Item(a.Key).ContainsKey(computation) Then
                                        dicTotal.Item(a.Key).Add(computation, decValue)
                                    End If
                                End If
                                'xlWorkSheet.Cells(current_row, current_column) = decValue
                                'current_column += 1
                            End If
                        Next
                    Else
                        If CBool(ifNull(item.Item("row_type"), 0)) Then 'Chart Group
                            Dim chart_group_id = item.Item("chart_group_id").ToString
                            Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", chart_group_id))
                            Dim newDic As New Dictionary(Of String, Decimal)

                            If drs.Length > 0 Then
                                For Each dr As DataRow In drs
                                    For Each a In dic
                                        If a.Value.Item("enable") Then
                                            Dim newName As String = ifNull(a.Key, "")
                                            Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                            If newDic.ContainsKey(newName) Then
                                                newDic.Item(newName) += amount
                                            Else
                                                newDic.Add(newName, amount)
                                            End If
                                        End If
                                    Next
                                Next
                                If group_name <> "" Then
                                    If dicGroup.ContainsKey(group_name) Then
                                        dicGroup.Item(group_name) = newDic
                                    Else
                                        dicGroup.Add(group_name, newDic)
                                    End If
                                End If
                            End If
                        Else 'Chart of Account
                            Dim account_id = item.Item("account_id").ToString
                            Dim drs = dt_balance.Select(String.Format("account_id = '{0}'", account_id))

                            Dim newDic As New Dictionary(Of String, Decimal)
                            If drs.Length > 0 Then
                                Dim dr As DataRow = drs(0)
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        Dim newName As String = ifNull(a.Key, "")
                                        Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                        If newDic.ContainsKey(newName) Then
                                            newDic.Item(newName) += amount
                                        Else
                                            newDic.Add(newName, amount)
                                        End If
                                    End If
                                Next
                                If group_name <> "" Then
                                    If dicGroup.ContainsKey(group_name) Then
                                        dicGroup.Item(group_name) = newDic
                                    Else
                                        dicGroup.Add(group_name, newDic)
                                    End If
                                End If
                            End If
                        End If
                    End If
#End Region
                Else
                    If item.Item("row_type") Then 'Chart Group
#Region "Chart Group(Hidden)"
                        Dim chart_group_id = item.Item("chart_group_id").ToString
                        Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", chart_group_id))

                        Dim group_name As String = ifNull(item.Item("group_var").ToString, "")
                        Dim newDic As New Dictionary(Of String, Decimal)

                        If drs.Length > 0 Then
                            For Each dr As DataRow In drs
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        Dim newName As String = ifNull(a.Key, "")
                                        Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                        If newDic.ContainsKey(newName) Then
                                            newDic.Item(newName) += amount
                                        Else
                                            newDic.Add(newName, amount)
                                        End If
                                    End If
                                Next
                            Next
                            If group_name <> "" Then
                                If dicGroup.ContainsKey(group_name) Then
                                    dicGroup.Item(group_name) = newDic
                                Else
                                    dicGroup.Add(group_name, newDic)
                                End If
                            End If
                        End If
#End Region
                    Else 'Chart of Account
#Region "Chart of Account(Hidden)"
                        Dim account_id = item.Item("account_id").ToString
                        Dim drs = dt_balance.Select(String.Format("account_id = '{0}'", account_id))

                        Dim group_name As String = ifNull(item.Item("group_var").ToString, "")
                        Dim newDic As New Dictionary(Of String, Decimal)
                        If drs.Length > 0 Then
                            Dim dr As DataRow = drs(0)
                            For Each a In dic
                                If a.Value.Item("enable") Then
                                    Dim newName As String = ifNull(a.Key, "")
                                    Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                    If newDic.ContainsKey(newName) Then
                                        newDic.Item(newName) += amount
                                    Else
                                        newDic.Add(newName, amount)
                                    End If
                                End If
                            Next
                            If group_name <> "" Then
                                If dicGroup.ContainsKey(group_name) Then
                                    dicGroup.Item(group_name) = newDic
                                Else
                                    dicGroup.Add(group_name, newDic)
                                End If
                            End If
                        End If
#End Region
                    End If
                End If
#End Region
            ElseIf ifNull(item.Item("command_code"), "").ToString = "I" Then
                current_row += 1
            ElseIf ifNull(item.Item("command_code"), "").ToString = "P" Then
#Region "Print Command"
                If item.Item("display_text").ToString <> "" Then
#Region "With Display Text"
                    Dim computation As String = ifNull(item.Item("computation").ToString, "")
                    Dim display_text = item.Item("display_text").ToString()
                    Dim group_name As String = ifNull(item.Item("group_var").ToString, "")

                    current_column = 1
                    If ShowAccountCode Then
                        current_column = 2
                    End If
                    Dim strSpace = ""
                    If indent_num > 0 Then
                        For i = 0 To indent_num - 1
                            strSpace &= " "
                        Next
                    End If
                    xlWorkSheet.Cells(current_row, current_column) = display_text
                    'xlWorkSheet.Cells(current_row, current_column) = strSpace & display_text
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, current_column), xlWorkSheet.Cells(current_row, current_column)).IndentLevel = indent_num
                    current_column += 1
                    If computation <> "" Then
                        'xlWorkSheet.Cells(current_row, current_column) = strSpace & display_text
                        lstVar.Clear()
                        For Each a In dicGroup
                            lstVar.Add(a.Key)
                        Next
                        Dim sortedVar = From var In lstVar.ToArray Order By var.ToString.Length Descending Select var

                        For Each a In dic
                            If a.Value.Item("enable") Then
                                Dim strParsedFormulaWithValue As String = computation
                                Dim decValue As Decimal = 0.0
                                For Each var In sortedVar
                                    If dicGroup.ContainsKey(var) Then
                                        Dim dicCurrentVar = dicGroup.Item(var)
                                        strParsedFormulaWithValue = strParsedFormulaWithValue.Replace(var, CDec(ifNull(dicCurrentVar.Item(a.Key).ToString, 0)))
                                    End If
                                Next
                                Try
                                    decValue = New DataTable().Compute(strParsedFormulaWithValue, Nothing)
                                Catch ex As Exception
                                    MyDebugging.AddText(strParsedFormulaWithValue)
                                    MyDebugging.AddText(ex.Message)
                                    decValue = 0
                                End Try
                                If Not dicTotal.ContainsKey(a.Key) Then
                                    dicTotal.Item(a.Key) = New Dictionary(Of String, Decimal)
                                End If
                                If group_name <> "" Then
                                    Dim newDic As New Dictionary(Of String, Decimal)

                                    If dicGroup.ContainsKey(group_name) Then
                                        newDic = dicGroup.Item(group_name)
                                        If newDic.ContainsKey(a.Key) Then
                                            newDic.Item(a.Key) = decValue
                                        Else
                                            newDic.Add(a.Key, decValue)
                                        End If
                                        dicGroup.Item(group_name) = newDic
                                    Else
                                        newDic.Add(a.Key, decValue)
                                        dicGroup.Add(group_name, newDic)
                                    End If
                                    dicTotal.Item(a.Key).Add(group_name, decValue)
                                Else
                                    If Not dicTotal.Item(a.Key).ContainsKey(computation) Then
                                        dicTotal.Item(a.Key).Add(computation, decValue)
                                    End If
                                End If
                                xlWorkSheet.Cells(current_row, current_column) = decValue
                                current_column += 1
                            End If
                        Next
                        Dim firstColumn As Integer = 2
                        If ShowAccountCode Then
                            firstColumn = 3
                        End If
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                        If dicLine.Item("D") Then
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlThin
                            End With
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                .LineStyle = Excel.XlLineStyle.xlDouble
                                .Weight = Excel.XlBorderWeight.xlThick
                            End With
                        End If
                        If dicLine.Item("G") Then
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                .LineStyle = Excel.XlLineStyle.xlDouble
                                .Weight = Excel.XlBorderWeight.xlThick
                            End With
                        End If
                        If dicLine.Item("L") Then
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlThin
                            End With
                        End If
                        If dicLine.Item("T") Then
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlThin
                            End With
                            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlThin
                            End With
                        End If
                        current_row += 1
                    Else
                        If CBool(ifNull(item.Item("row_type"), 0)) Then 'Chart Group
                            Dim chart_group_id = item.Item("chart_group_id").ToString
                            Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", chart_group_id))
                            Dim newDic As New Dictionary(Of String, Decimal)
                            'xlWorkSheet.Cells(current_row, current_column) = strSpace & display_text
                            If drs.Length > 0 Then
                                Dim withValue As Boolean = False
                                For Each dr As DataRow In drs
                                    'current_column = 1
                                    'xlWorkSheet.Cells(current_row, current_column) = dr.Item("account_name").ToString
                                    'current_column += 1
                                    For Each a In dic
                                        If a.Value.Item("enable") Then
                                            Dim newName As String = ifNull(a.Key, "")
                                            Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                            'xlWorkSheet.Cells(current_row, current_column) = amount
                                            If newDic.ContainsKey(newName) Then
                                                newDic.Item(newName) += amount
                                            Else
                                                newDic.Add(newName, amount)
                                            End If
                                            current_column += 1
                                        End If
                                    Next
                                Next
                                current_column = 2
                                If ShowAccountCode Then
                                    current_column = 3
                                End If
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        If newDic.ContainsKey(a.Key) Then
                                            Dim val As Decimal = CDec(ifNull(newDic.Item(a.Key), 0))
                                            If w_zero.Checked Then
                                                withValue = True
                                            Else
                                                If val <> 0 Then
                                                    withValue = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        If newDic.ContainsKey(a.Key) Then
                                            If w_zero.Checked Then
                                                xlWorkSheet.Cells(current_row, current_column) = newDic.Item(a.Key)
                                                current_column += 1
                                            Else
                                                If withValue Then
                                                    xlWorkSheet.Cells(current_row, current_column) = newDic.Item(a.Key)
                                                    current_column += 1
                                                End If
                                            End If
                                        End If
                                    End If
                                Next
                                If withValue Then
                                    Dim firstColumn As Integer = 2
                                    If ShowAccountCode Then
                                        xlWorkSheet.Cells(current_row, 2) = display_text
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num
                                        'xlWorkSheet.Cells(current_row, 2) = strSpace & display_text
                                        firstColumn = 3
                                    Else
                                        xlWorkSheet.Cells(current_row, 1) = display_text
                                        'xlWorkSheet.Cells(current_row, 1) = strSpace & display_text
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num
                                    End If
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                                    If dicLine.Item("D") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If dicLine.Item("G") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If dicLine.Item("L") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                    End If
                                    If dicLine.Item("T") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    current_row += 1
                                End If
                                If group_name <> "" Then
                                    If dicGroup.ContainsKey(group_name) Then
                                        dicGroup.Item(group_name) = newDic
                                    Else
                                        dicGroup.Add(group_name, newDic)
                                    End If
                                End If
                            Else
                                current_row += 1
                            End If
                        Else 'Chart of Account
                            Dim withValue As Boolean = False
                            Dim account_id = item.Item("account_id").ToString
                            Dim drs = dt_balance.Select(String.Format("account_id = '{0}'", account_id))

                            Dim newDic As New Dictionary(Of String, Decimal)
                            If drs.Length > 0 Then
                                Dim dr As DataRow = drs(0)
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        Dim newName As String = ifNull(a.Key, "")
                                        Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                        If newDic.ContainsKey(newName) Then
                                            newDic.Item(newName) += amount
                                        Else
                                            newDic.Add(newName, amount)
                                        End If
                                        current_column += 1
                                    End If
                                Next
                                current_column = 2
                                If ShowAccountCode Then
                                    current_column = 3
                                End If
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        If newDic.ContainsKey(a.Key) Then
                                            Dim val As Decimal = CDec(ifNull(newDic.Item(a.Key), 0))
                                            If w_zero.Checked Then
                                                withValue = True
                                            Else
                                                If val <> 0 Then
                                                    withValue = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        If newDic.ContainsKey(a.Key) Then
                                            If w_zero.Checked Then
                                                xlWorkSheet.Cells(current_row, current_column) = newDic.Item(a.Key)
                                                current_column += 1
                                            Else
                                                If withValue Then
                                                    xlWorkSheet.Cells(current_row, current_column) = newDic.Item(a.Key)
                                                    current_column += 1
                                                End If
                                            End If
                                        End If
                                    End If
                                Next
                                If withValue Then
                                    Dim firstColumn As Integer = 2
                                    If ShowAccountCode Then
                                        xlWorkSheet.Cells(current_row, 2) = display_text
                                        'xlWorkSheet.Cells(current_row, 2) = strSpace & display_text
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num
                                        firstColumn = 3
                                    Else
                                        xlWorkSheet.Cells(current_row, 1) = display_text
                                        'xlWorkSheet.Cells(current_row, 1) = strSpace & display_text
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num
                                    End If
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                                    If dicLine.Item("D") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If dicLine.Item("G") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If dicLine.Item("L") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                    End If
                                    If dicLine.Item("T") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    current_row += 1
                                End If
                                If group_name <> "" Then
                                    If dicGroup.ContainsKey(group_name) Then
                                        dicGroup.Item(group_name) = newDic
                                    Else
                                        dicGroup.Add(group_name, newDic)
                                    End If
                                End If
                            Else
                                Dim firstColumn As Integer = 2
                                If ShowAccountCode Then
                                    xlWorkSheet.Cells(current_row, 2) = display_text
                                    'xlWorkSheet.Cells(current_row, 2) = strSpace & display_text
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num
                                    firstColumn = 3
                                Else
                                    xlWorkSheet.Cells(current_row, 1) = display_text
                                    'xlWorkSheet.Cells(current_row, 1) = strSpace & display_text
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num
                                End If
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                                If dicLine.Item("D") Then
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                        .LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Weight = Excel.XlBorderWeight.xlThin
                                    End With
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                        .LineStyle = Excel.XlLineStyle.xlDouble
                                        .Weight = Excel.XlBorderWeight.xlThick
                                    End With
                                End If
                                If dicLine.Item("G") Then
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                        .LineStyle = Excel.XlLineStyle.xlDouble
                                        .Weight = Excel.XlBorderWeight.xlThick
                                    End With
                                End If
                                If dicLine.Item("L") Then
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                        .LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Weight = Excel.XlBorderWeight.xlThin
                                    End With
                                End If
                                If dicLine.Item("T") Then
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                        .LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Weight = Excel.XlBorderWeight.xlThick
                                    End With
                                End If
                                current_row += 1
                            End If
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                            'If dicLine.Item("D") Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            '        .LineStyle = Excel.XlLineStyle.xlContinuous
                            '        .Weight = Excel.XlBorderWeight.xlThin
                            '    End With
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            '        .LineStyle = Excel.XlLineStyle.xlDouble
                            '        .Weight = Excel.XlBorderWeight.xlThick
                            '    End With
                            'End If
                            'If dicLine.Item("G") Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            '        .LineStyle = Excel.XlLineStyle.xlDouble
                            '        .Weight = Excel.XlBorderWeight.xlThick
                            '    End With
                            'End If
                            'If dicLine.Item("L") Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            '        .LineStyle = Excel.XlLineStyle.xlContinuous
                            '        .Weight = Excel.XlBorderWeight.xlThin
                            '    End With
                            'End If
                            'If dicLine.Item("T") Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            '        .LineStyle = Excel.XlLineStyle.xlContinuous
                            '        .Weight = Excel.XlBorderWeight.xlThick
                            '    End With
                            'End If
                            'current_row += 1
                        End If
                    End If
#End Region
                Else
                    If ifNull(item.Item("row_type"), "0") = "1" Then 'Chart Group
#Region "Chart Group"
                        Dim chart_group_id = item.Item("chart_group_id").ToString
                        Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", chart_group_id))

                        Dim group_name As String = ifNull(item.Item("group_var").ToString, "")
                        Dim newDic As New Dictionary(Of String, Decimal)

                        If drs.Length > 0 Then
                            For Each dr As DataRow In drs
                                Dim withValue As Boolean = False
                                Dim dicAmount As New Dictionary(Of String, Decimal)
                                'current_column = 1
                                Dim strSpace As String = ""
                                If indent_num > 0 Then
                                    For i = 0 To indent_num
                                        strSpace &= " "
                                    Next
                                End If
                                Dim account_name = dr.Item("account_name").ToString
                                Dim account_code = dr.Item("account_code").ToString
                                'xlWorkSheet.Cells(current_row, current_column) = strSpace & account_name
                                'current_column += 1
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        Dim newName As String = ifNull(a.Key, "")
                                        Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                        'xlWorkSheet.Cells(current_row, current_column) = amount
                                        If newDic.ContainsKey(newName) Then
                                            newDic.Item(newName) += amount
                                        Else
                                            newDic.Add(newName, amount)
                                        End If
                                        dicAmount.Add(a.Key, amount)
                                        current_column += 1
                                    End If
                                Next
                                current_column = 2
                                If ShowAccountCode Then
                                    current_column = 3
                                End If
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        If dicAmount.ContainsKey(a.Key) Then
                                            Dim val As Decimal = CDec(ifNull(dicAmount.Item(a.Key), 0))
                                            If w_zero.Checked Then
                                                withValue = True
                                            Else
                                                If val <> 0 Then
                                                    withValue = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        If dicAmount.ContainsKey(a.Key) Then
                                            If w_zero.Checked Then
                                                xlWorkSheet.Cells(current_row, current_column) = dicAmount.Item(a.Key)
                                                current_column += 1
                                            Else
                                                If withValue Then
                                                    xlWorkSheet.Cells(current_row, current_column) = dicAmount.Item(a.Key)
                                                    current_column += 1
                                                End If
                                            End If
                                        End If
                                    End If
                                Next
                                'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                                'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                                'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                                'If dicLine.Item("D") Then
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                '        .LineStyle = Excel.XlLineStyle.xlContinuous
                                '        .Weight = Excel.XlBorderWeight.xlThin
                                '    End With
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                '        .LineStyle = Excel.XlLineStyle.xlDouble
                                '        .Weight = Excel.XlBorderWeight.xlThick
                                '    End With
                                'End If
                                'If dicLine.Item("G") Then
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                '        .LineStyle = Excel.XlLineStyle.xlDouble
                                '        .Weight = Excel.XlBorderWeight.xlThick
                                '    End With
                                'End If
                                'If dicLine.Item("L") Then
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                '        .LineStyle = Excel.XlLineStyle.xlContinuous
                                '        .Weight = Excel.XlBorderWeight.xlThin
                                '    End With
                                'End If
                                'If dicLine.Item("T") Then
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                '        .LineStyle = Excel.XlLineStyle.xlContinuous
                                '        .Weight = Excel.XlBorderWeight.xlThick
                                '    End With
                                'End If
                                'current_row += 1
                                If withValue Then
                                    Dim firstColumn As Integer = 2
                                    If ShowAccountCode Then
                                        xlWorkSheet.Cells(current_row, 1) = "'" & account_code
                                        xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                        'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num
                                        firstColumn = 3
                                    Else
                                        xlWorkSheet.Cells(current_row, 1) = account_name
                                        'xlWorkSheet.Cells(current_row, 1) = strSpace & account_name
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num
                                    End If
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                                    If dicLine.Item("D") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If dicLine.Item("G") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If dicLine.Item("L") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                    End If
                                    If dicLine.Item("T") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    current_row += 1
                                End If
                            Next
                            If group_name <> "" Then
                                If dicGroup.ContainsKey(group_name) Then
                                    dicGroup.Item(group_name) = newDic
                                Else
                                    dicGroup.Add(group_name, newDic)
                                End If
                            End If
                        End If
#End Region
                    ElseIf ifNull(item.Item("row_type"), "0") = "2" Then 'Allocation
#Region "Allocation"
                        Dim allocation_id = item.Item("allocation_id").ToString
                        Dim drs_withAllocation = dt_balance.Select(String.Format("withAllocation = '1'"))
                        Dim lst_drs As New List(Of DataRow)
                        If drs_withAllocation.Length > 0 Then
                            For Each dr_withAllocation As DataRow In drs_withAllocation
                                Dim allocation_ids = dr_withAllocation("allocation_id").ToString.Split(",")
                                If allocation_ids.Contains(allocation_id) Then
                                    lst_drs.Add(dr_withAllocation)
                                End If
                            Next
                        End If
                        Dim drs = lst_drs.ToArray

                        Dim group_name As String = ifNull(item.Item("group_var").ToString, "")
                        Dim newDic As New Dictionary(Of String, Decimal)

                        If drs.Length > 0 Then
                            For Each dr As DataRow In drs
                                Dim withValue As Boolean = False
                                Dim dicAmount As New Dictionary(Of String, Decimal)
                                'current_column = 1
                                Dim strSpace As String = ""
                                If indent_num > 0 Then
                                    For i = 0 To indent_num
                                        strSpace &= " "
                                    Next
                                End If
                                Dim account_name = dr.Item("account_name").ToString
                                Dim account_code = dr.Item("account_code").ToString
                                'xlWorkSheet.Cells(current_row, current_column) = strSpace & account_name
                                'current_column += 1
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        Dim newName As String = ifNull(a.Key, "")
                                        Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                        'xlWorkSheet.Cells(current_row, current_column) = amount
                                        If newDic.ContainsKey(newName) Then
                                            newDic.Item(newName) += amount
                                        Else
                                            newDic.Add(newName, amount)
                                        End If
                                        dicAmount.Add(a.Key, amount)
                                        current_column += 1
                                    End If
                                Next
                                current_column = 2
                                If ShowAccountCode Then
                                    current_column = 3
                                End If
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        If dicAmount.ContainsKey(a.Key) Then
                                            Dim val As Decimal = CDec(ifNull(dicAmount.Item(a.Key), 0))
                                            If w_zero.Checked Then
                                                withValue = True
                                            Else
                                                If val <> 0 Then
                                                    withValue = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next
                                For Each a In dic
                                    If a.Value.Item("enable") Then
                                        If dicAmount.ContainsKey(a.Key) Then
                                            If w_zero.Checked Then
                                                xlWorkSheet.Cells(current_row, current_column) = dicAmount.Item(a.Key)
                                                current_column += 1
                                            Else
                                                If withValue Then
                                                    xlWorkSheet.Cells(current_row, current_column) = dicAmount.Item(a.Key)
                                                    current_column += 1
                                                End If
                                            End If
                                        End If
                                    End If
                                Next
                                'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                                'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                                'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                                'If dicLine.Item("D") Then
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                '        .LineStyle = Excel.XlLineStyle.xlContinuous
                                '        .Weight = Excel.XlBorderWeight.xlThin
                                '    End With
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                '        .LineStyle = Excel.XlLineStyle.xlDouble
                                '        .Weight = Excel.XlBorderWeight.xlThick
                                '    End With
                                'End If
                                'If dicLine.Item("G") Then
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                '        .LineStyle = Excel.XlLineStyle.xlDouble
                                '        .Weight = Excel.XlBorderWeight.xlThick
                                '    End With
                                'End If
                                'If dicLine.Item("L") Then
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                '        .LineStyle = Excel.XlLineStyle.xlContinuous
                                '        .Weight = Excel.XlBorderWeight.xlThin
                                '    End With
                                'End If
                                'If dicLine.Item("T") Then
                                '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                '        .LineStyle = Excel.XlLineStyle.xlContinuous
                                '        .Weight = Excel.XlBorderWeight.xlThick
                                '    End With
                                'End If
                                'current_row += 1
                                If withValue Then
                                    Dim firstColumn As Integer = 2
                                    If ShowAccountCode Then
                                        xlWorkSheet.Cells(current_row, 1) = "'" & account_code
                                        xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                        'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num
                                        firstColumn = 3
                                    Else
                                        xlWorkSheet.Cells(current_row, 1) = account_name
                                        'xlWorkSheet.Cells(current_row, 1) = strSpace & account_name
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num
                                    End If
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                                    If dicLine.Item("D") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If dicLine.Item("G") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlDouble
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    If dicLine.Item("L") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                    End If
                                    If dicLine.Item("T") Then
                                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                            .LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Weight = Excel.XlBorderWeight.xlThick
                                        End With
                                    End If
                                    current_row += 1
                                End If
                            Next
                            If group_name <> "" Then
                                If dicGroup.ContainsKey(group_name) Then
                                    dicGroup.Item(group_name) = newDic
                                Else
                                    dicGroup.Add(group_name, newDic)
                                End If
                            End If
                        End If
#End Region
                    Else 'Chart of Account
#Region "Chart of Account"
                        Dim withValue As Boolean = False
                        Dim account_id = item.Item("account_id").ToString
                        Dim drs = dt_balance.Select(String.Format("account_id = '{0}'", account_id))

                        Dim group_name As String = ifNull(item.Item("group_var").ToString, "")
                        Dim newDic As New Dictionary(Of String, Decimal)
                        If drs.Length > 0 Then
                            Dim dicAmount As New Dictionary(Of String, Decimal)
                            Dim dr As DataRow = drs(0)
                            current_column = 1
                            If ShowAccountCode Then
                                current_column = 2
                            End If
                            Dim strSpace As String = ""
                            If indent_num > 0 Then
                                For i = 0 To indent_num
                                    strSpace &= " "
                                Next
                            End If
                            Dim account_name = dr.Item("account_name").ToString
                            Dim account_code = dr.Item("account_code").ToString
                            If ShowAccountCode Then
                                xlWorkSheet.Cells(current_row, 1) = "'" & account_code
                                xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num
                            Else
                                xlWorkSheet.Cells(current_row, current_column) = account_name
                                'xlWorkSheet.Cells(current_row, current_column) = strSpace & account_name
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num
                            End If
                            current_column += 1
                            For Each a In dic
                                If a.Value.Item("enable") Then
                                    Dim newName As String = ifNull(a.Key, "")
                                    Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
                                    'xlWorkSheet.Cells(current_row, current_column) = amount
                                    If newDic.ContainsKey(newName) Then
                                        newDic.Item(newName) += amount
                                    Else
                                        newDic.Add(newName, amount)
                                    End If
                                    dicAmount.Add(a.Key, amount)
                                    current_column += 1
                                End If
                            Next
                            current_column = 2
                            If ShowAccountCode Then
                                current_column = 3
                            End If
                            For Each a In dic
                                If a.Value.Item("enable") Then
                                    If dicAmount.ContainsKey(a.Key) Then
                                        Dim val As Decimal = CDec(ifNull(dicAmount.Item(a.Key), 0))
                                        If w_zero.Checked Then
                                            withValue = True
                                        Else
                                            If val <> 0 Then
                                                withValue = True
                                            End If
                                        End If
                                    End If
                                End If
                            Next
                            For Each a In dic
                                If a.Value.Item("enable") Then
                                    If dicAmount.ContainsKey(a.Key) Then
                                        If w_zero.Checked Then
                                            xlWorkSheet.Cells(current_row, current_column) = dicAmount.Item(a.Key)
                                            current_column += 1
                                        Else
                                            If withValue Then
                                                xlWorkSheet.Cells(current_row, current_column) = dicAmount.Item(a.Key)
                                                current_column += 1
                                            End If
                                        End If
                                    End If
                                End If
                            Next
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                            'xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                            'If dicLine.Item("D") Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            '        .LineStyle = Excel.XlLineStyle.xlContinuous
                            '        .Weight = Excel.XlBorderWeight.xlThin
                            '    End With
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            '        .LineStyle = Excel.XlLineStyle.xlDouble
                            '        .Weight = Excel.XlBorderWeight.xlThick
                            '    End With
                            'End If
                            'If dicLine.Item("G") Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            '        .LineStyle = Excel.XlLineStyle.xlDouble
                            '        .Weight = Excel.XlBorderWeight.xlThick
                            '    End With
                            'End If
                            'If dicLine.Item("L") Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            '        .LineStyle = Excel.XlLineStyle.xlContinuous
                            '        .Weight = Excel.XlBorderWeight.xlThin
                            '    End With
                            'End If
                            'If dicLine.Item("T") Then
                            '    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            '        .LineStyle = Excel.XlLineStyle.xlContinuous
                            '        .Weight = Excel.XlBorderWeight.xlThick
                            '    End With
                            'End If
                            If withValue Then
                                Dim firstColumn As Integer = 2
                                If ShowAccountCode Then
                                    xlWorkSheet.Cells(current_row, 1) = "'" & account_code
                                    xlWorkSheet.Cells(current_row, 2) = account_name
                                    'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num
                                    firstColumn = 3
                                Else
                                    xlWorkSheet.Cells(current_row, 1) = account_name
                                    'xlWorkSheet.Cells(current_row, 1) = strSpace & account_name
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num
                                End If
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                                If dicLine.Item("D") Then
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                        .LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Weight = Excel.XlBorderWeight.xlThin
                                    End With
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                        .LineStyle = Excel.XlLineStyle.xlDouble
                                        .Weight = Excel.XlBorderWeight.xlThick
                                    End With
                                End If
                                If dicLine.Item("G") Then
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                        .LineStyle = Excel.XlLineStyle.xlDouble
                                        .Weight = Excel.XlBorderWeight.xlThick
                                    End With
                                End If
                                If dicLine.Item("L") Then
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                        .LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Weight = Excel.XlBorderWeight.xlThin
                                    End With
                                End If
                                If dicLine.Item("T") Then
                                    With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                        .LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Weight = Excel.XlBorderWeight.xlThick
                                    End With
                                End If
                                current_row += 1
                            End If
                            'current_row += 1
                            If group_name <> "" Then
                                If dicGroup.ContainsKey(group_name) Then
                                    dicGroup.Item(group_name) = newDic
                                Else
                                    dicGroup.Add(group_name, newDic)
                                End If
                            End If
                        Else
                            Dim firstColumn As Integer = 2
                            If ShowAccountCode Then
                                firstColumn = 3
                            End If
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = dicFont.Item("B")
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Italic = dicFont.Item("I")
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Underline = dicFont.Item("U")
                            If dicLine.Item("D") Then
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                    .LineStyle = Excel.XlLineStyle.xlContinuous
                                    .Weight = Excel.XlBorderWeight.xlThin
                                End With
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                                    .LineStyle = Excel.XlLineStyle.xlDouble
                                    .Weight = Excel.XlBorderWeight.xlThick
                                End With
                            End If
                            If dicLine.Item("G") Then
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                    .LineStyle = Excel.XlLineStyle.xlDouble
                                    .Weight = Excel.XlBorderWeight.xlThick
                                End With
                            End If
                            If dicLine.Item("L") Then
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                    .LineStyle = Excel.XlLineStyle.xlContinuous
                                    .Weight = Excel.XlBorderWeight.xlThin
                                End With
                            End If
                            If dicLine.Item("T") Then
                                With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, firstColumn), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                                    .LineStyle = Excel.XlLineStyle.xlContinuous
                                    .Weight = Excel.XlBorderWeight.xlThick
                                End With
                            End If
                            current_row += 1
                        End If
#End Region
                    End If
                End If
#End Region
            ElseIf ifNull(item.Item("command_code"), "").ToString = "S" Then
                current_row += 1
            End If
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txt_template_id_ValueChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_template_id_Leave(sender As Object, e As EventArgs) Handles txt_template_id.Leave
        Dim q As String = txt_template_id.Text.ToString.Trim().Replace("'", "''")
        Dim sql As String = String.Format("SELECT template_id,template_code,template_name FROM sys_fs_template " &
            "WHERE fs_type = '{0}'", FS_Type)
        Dim str = sender.Text.Trim
        Dim label As String = "Code,Name"
        Dim field As String = "template_code,template_name"
        Dim width As String = "200,400"
        Dim drVar As DataRow = Nothing

        CreateTextBrowse(sql, q, label, field, width, drVar)
        If TypeOf sender Is user_control.textbox Then
            Dim txt = CType(sender, user_control.textbox)
            If drVar IsNot Nothing Then
                txt.Text = drVar.Item("template_code").ToString
                txt_template_name.Text = drVar.Item("template_name").ToString
                txt.Value = drVar.Item("template_id").ToString
                template_id = drVar.Item("template_id").ToString
                'setLabel(sender)
            Else
                txt.Text = ""
                txt.Value = ""
                template_id = ""
            End If
        End If
    End Sub

    Private Sub BrowseProject(sender As Object, e As EventArgs) Handles txt_project_id_a.Leave, txt_project_id_b.Leave, txt_project_id_c.Leave, txt_project_id_d.Leave, txt_project_id_e.Leave
        Dim q As String = sender.Text.ToString.Trim().Replace("'", "''")
        Dim sql As String = String.Format("SELECT project_id,project_code,project_name FROM lib_erp_project ")
        Dim str = sender.Text.Trim
        Dim label As String = "Code,Name"
        Dim field As String = "project_code,project_name"
        Dim width As String = "200,400"
        Dim drVar As DataRow = Nothing

        CreateTextBrowse(sql, q, label, field, width, drVar)
        If TypeOf sender Is user_control.textbox Then
            Dim txt = CType(sender, user_control.textbox)
            If drVar IsNot Nothing Then
                txt.Text = drVar.Item("project_name").ToString
                txt.Value = drVar.Item("project_id").ToString
                'setLabel(sender)
            Else
                txt.Text = ""
                txt.Value = ""
            End If
        End If
    End Sub

    Private Sub txt_project_id_Leave(sender As Object, e As EventArgs) Handles txt_project_id.Leave
        Dim q As String = sender.Text.ToString.Trim().Replace("'", "''")
        Dim sql As String = String.Format("SELECT project_id,project_code,project_name FROM lib_erp_project ")
        Dim str = sender.Text.Trim
        Dim label As String = "Code,Name"
        Dim field As String = "project_code,project_name"
        Dim width As String = "200,400"
        Dim drVar As DataRow = Nothing

        CreateTextBrowse(sql, q, label, field, width, drVar)
        If TypeOf sender Is user_control.textbox Then
            Dim txt = CType(sender, user_control.textbox)
            If drVar IsNot Nothing Then
                txt.Text = drVar.Item("project_code").ToString
                txt_project_name.Text = drVar.Item("project_name").ToString
                txt.Value = drVar.Item("project_id").ToString
                'setLabel(sender)
            Else
                txt.Text = ""
                txt.Value = ""
                txt_project_name.Text = ""
            End If
        End If
        txt_project_id_a.Text = txt_project_name.Text
        txt_project_id_a.Value = txt_project_id.Value
        txt_project_id_b.Text = txt_project_name.Text
        txt_project_id_b.Value = txt_project_id.Value
        txt_project_id_c.Text = txt_project_name.Text
        txt_project_id_c.Value = txt_project_id.Value
        txt_project_id_d.Text = txt_project_name.Text
        txt_project_id_d.Value = txt_project_id.Value
        txt_project_id_e.Text = txt_project_name.Text
        txt_project_id_e.Value = txt_project_id.Value
    End Sub
End Class