Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.Drawing

Public Class fsdesign_filter_bak
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
        Dim sql As String = String.Format("SELECT 'FOR THE MONTH' AS range_name,'1' AS range_id " & vbNewLine & _
            "UNION SELECT 'AS OF','2' " & vbNewLine & _
            "UNION SELECT 'DATE RANGE','3' " & vbNewLine & _
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
                            txt_label_to_a.Text = txt_month_from_a.Text.ToUpper & txt_year_from_a.Value
                        Case "2"
                            txt_label_from_a.Text = "AS OF"
                            txt_label_to_a.Text = txt_month_from_a.Text.ToUpper & txt_year_from_a.Value
                        Case "3"
                            txt_label_from_a.Text = "RANGED"
                            txt_label_to_a.Text = txt_month_from_a.Text.ToUpper & txt_year_from_a.Value & " - " & txt_month_to_a.Text.ToUpper & txt_year_to_a.Value
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
                            txt_label_to_b.Text = txt_month_from_b.Text.ToUpper & txt_year_from_b.Value
                        Case "2"
                            txt_label_from_b.Text = "AS OF"
                            txt_label_to_b.Text = txt_month_from_b.Text.ToUpper & txt_year_from_b.Value
                        Case "3"
                            txt_label_from_b.Text = "RANGED"
                            txt_label_to_b.Text = txt_month_from_b.Text.ToUpper & txt_year_from_b.Value & " - " & txt_month_to_b.Text.ToUpper & txt_year_to_b.Value
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
                            txt_label_to_c.Text = txt_month_from_c.Text.ToUpper & txt_year_from_c.Value
                        Case "2"
                            txt_label_from_c.Text = "AS OF"
                            txt_label_to_c.Text = txt_month_from_c.Text.ToUpper & txt_year_from_c.Value
                        Case "3"
                            txt_label_from_c.Text = "RANGED"
                            txt_label_to_c.Text = txt_month_from_c.Text.ToUpper & txt_year_from_c.Value & " - " & txt_month_to_c.Text.ToUpper & txt_year_to_c.Value
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
                            txt_label_to_d.Text = txt_month_from_d.Text.ToUpper & txt_year_from_d.Value
                        Case "2"
                            txt_label_from_d.Text = "AS OF"
                            txt_label_to_d.Text = txt_month_from_d.Text.ToUpper & txt_year_from_d.Value
                        Case "3"
                            txt_label_from_d.Text = "RANGED"
                            txt_label_to_d.Text = txt_month_from_d.Text.ToUpper & txt_year_from_d.Value & " - " & txt_month_to_d.Text.ToUpper & txt_year_to_d.Value
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
                            txt_label_to_e.Text = txt_month_from_e.Text.ToUpper & txt_year_from_e.Value
                        Case "2"
                            txt_label_from_e.Text = "AS OF"
                            txt_label_to_e.Text = txt_month_from_e.Text.ToUpper & txt_year_from_e.Value
                        Case "3"
                            txt_label_from_e.Text = "RANGED"
                            txt_label_to_e.Text = txt_month_from_e.Text.ToUpper & txt_year_from_e.Value & " - " & txt_month_to_e.Text.ToUpper & txt_year_to_e.Value
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
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim dic_a As New Dictionary(Of String, String)
        dic_a.Add("source", txt_source_a.Value.ToString)
        dic_a.Add("book", txt_book_a.Value.ToString)
        dic_a.Add("range", txt_range_a.Value.ToString)
        dic_a.Add("month_from", txt_month_from_a.SelectedIndex + 1)
        dic_a.Add("year_from", txt_year_from_a.Value.ToString)
        dic_a.Add("month_to", txt_month_to_a.SelectedIndex + 1)
        dic_a.Add("year_to", txt_year_to_a.Value.ToString)
        dic_a.Add("enable", enable_a.Checked)
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
        dic_e.Add("label_from", txt_label_from_e.Text.ToString)
        dic_e.Add("label_to", txt_label_to_e.Text.ToString)

        Dim sql As String = ""
        Dim sql_select_amount As String = ""
        Dim sql_select_amount_based As String = ""
        Dim sql_join As String = ""
        If dic_a.Item("enable") Then
            If dic_a.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(a.debit,0) - IFNULL(a.credit,0),IFNULL(a.credit,0) - IFNULL(a.debit,0)) AS a_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(a.debit_based,0) - IFNULL(a.credit_based,0),IFNULL(a.credit_based,0) - IFNULL(a.debit_based,0)) AS a_amount_based")
                sql_join &= String.Format("LEFT JOIN (" & vbNewLine & _
                "   SELECT a.account_id " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit,0)) AS debit " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit,0)) AS credit " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " & vbNewLine & _
                "   FROM SelectChartAmount a")
                Select Case dic_a.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE MONTH(a.trans_date) = '{0}' AND YEAR(a.trans_date) = '{1}' ", _
                            dic_a.Item("month_from"), dic_a.Item("year_from"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= LAST_DAY(STR_TO_DATE('{1}-{0}-01','%Y-%m-%d')) ", _
                            dic_a.Item("month_from"), dic_a.Item("year_from"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{1}-{0}-01' AND LAST_DAY(STR_TO_DATE('{3}-{2}-01','%Y-%m-%d')) ", _
                            dic_a.Item("month_from"), dic_a.Item("year_from"), dic_a.Item("month_to"), dic_a.Item("year_to"))
                End Select
                sql_join &= String.Format("   GROUP BY a.account_id " & vbNewLine & _
                ") a ON a.account_id = chart.account_id ", dic_a.Item("month_from"), dic_a.Item("year_from"))
            End If
        End If
        If dic_b.Item("enable") Then
            If dic_b.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(b.debit,0) - IFNULL(b.credit,0),IFNULL(b.credit,0) - IFNULL(b.debit,0)) AS b_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(b.debit_based,0) - IFNULL(b.credit_based,0),IFNULL(b.credit_based,0) - IFNULL(b.debit_based,0)) AS b_amount_based")
                sql_join &= String.Format("LEFT JOIN (" & vbNewLine & _
                "   SELECT a.account_id " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit,0)) AS debit " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit,0)) AS credit " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " & vbNewLine & _
                "   FROM SelectChartAmount a")
                Select Case dic_b.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE MONTH(a.trans_date) = '{0}' AND YEAR(a.trans_date) = '{1}' ", _
                            dic_b.Item("month_from"), dic_b.Item("year_from"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= LAST_DAY(STR_TO_DATE('{1}-{0}-01','%Y-%m-%d')) ", _
                            dic_b.Item("month_from"), dic_b.Item("year_from"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{1}-{0}-01' AND LAST_DAY(STR_TO_DATE('{3}-{2}-01','%Y-%m-%d')) ", _
                            dic_b.Item("month_from"), dic_b.Item("year_from"), dic_b.Item("month_to"), dic_b.Item("year_to"))
                End Select
                sql_join &= String.Format("   GROUP BY a.account_id " & vbNewLine & _
                ") b ON b.account_id = chart.account_id ", dic_b.Item("month_from"), dic_b.Item("year_from"))
            End If
        End If
        If dic_c.Item("enable") Then
            If dic_c.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(c.debit,0) - IFNULL(c.credit,0),IFNULL(c.credit,0) - IFNULL(c.debit,0)) AS c_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(c.debit_based,0) - IFNULL(c.credit_based,0),IFNULL(c.credit_based,0) - IFNULL(c.debit_based,0)) AS c_amount_based")
                sql_join &= String.Format("LEFT JOIN (" & vbNewLine & _
                "   SELECT a.account_id " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit,0)) AS debit " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit,0)) AS credit " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " & vbNewLine & _
                "   FROM SelectChartAmount a")
                Select Case dic_c.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE MONTH(a.trans_date) = '{0}' AND YEAR(a.trans_date) = '{1}' ", _
                            dic_c.Item("month_from"), dic_c.Item("year_from"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= LAST_DAY(STR_TO_DATE('{1}-{0}-01','%Y-%m-%d')) ", _
                            dic_c.Item("month_from"), dic_c.Item("year_from"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{1}-{0}-01' AND LAST_DAY(STR_TO_DATE('{3}-{2}-01','%Y-%m-%d')) ", _
                            dic_c.Item("month_from"), dic_c.Item("year_from"), dic_c.Item("month_to"), dic_c.Item("year_to"))
                End Select
                sql_join &= String.Format("   GROUP BY a.account_id " & vbNewLine & _
                ") c ON c.account_id = chart.account_id ", dic_c.Item("month_from"), dic_c.Item("year_from"))
            End If
        End If
        If dic_d.Item("enable") Then
            If dic_d.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(d.debit,0) - IFNULL(d.credit,0),IFNULL(d.credit,0) - IFNULL(d.debit,0)) AS d_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(d.debit_based,0) - IFNULL(d.credit_based,0),IFNULL(d.credit_based,0) - IFNULL(d.debit_based,0)) AS d_amount_based")
                sql_join &= String.Format("LEFT JOIN (" & vbNewLine & _
                "   SELECT a.account_id " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit,0)) AS debit " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit,0)) AS credit " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " & vbNewLine & _
                "   FROM SelectChartAmount a")
                Select Case dic_d.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE MONTH(a.trans_date) = '{0}' AND YEAR(a.trans_date) = '{1}' ", _
                            dic_d.Item("month_from"), dic_d.Item("year_from"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= LAST_DAY(STR_TO_DATE('{1}-{0}-01','%Y-%m-%d')) ", _
                            dic_d.Item("month_from"), dic_d.Item("year_from"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{1}-{0}-01' AND LAST_DAY(STR_TO_DATE('{3}-{2}-01','%Y-%m-%d')) ", _
                            dic_d.Item("month_from"), dic_d.Item("year_from"), dic_d.Item("month_to"), dic_d.Item("year_to"))
                End Select
                sql_join &= String.Format("   GROUP BY a.account_id " & vbNewLine & _
                ") d ON d.account_id = chart.account_id ", dic_d.Item("month_from"), dic_d.Item("year_from"))
            End If
        End If
        If dic_e.Item("enable") Then
            If dic_e.Item("source") = "1" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(e.debit,0) - IFNULL(e.credit,0),IFNULL(e.credit,0) - IFNULL(e.debit,0)) AS e_amount ")
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'E',IFNULL(e.debit_based,0) - IFNULL(e.credit_based,0),IFNULL(e.credit_based,0) - IFNULL(e.debit_based,0)) AS e_amount_based")
                sql_join &= String.Format("LEFT JOIN (" & vbNewLine & _
                "   SELECT a.account_id " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit,0)) AS debit " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit,0)) AS credit " & vbNewLine & _
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " & vbNewLine & _
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " & vbNewLine & _
                "   FROM SelectChartAmount a")
                Select Case dic_e.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE MONTH(a.trans_date) = '{0}' AND YEAR(a.trans_date) = '{1}' ", _
                            dic_e.Item("month_from"), dic_e.Item("year_from"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= LAST_DAY(STR_TO_DATE('{1}-{0}-01','%Y-%m-%d')) ", _
                            dic_e.Item("month_from"), dic_e.Item("year_from"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{1}-{0}-01' AND LAST_DAY(STR_TO_DATE('{3}-{2}-01','%Y-%m-%d')) ", _
                            dic_e.Item("month_from"), dic_e.Item("year_from"), dic_e.Item("month_to"), dic_e.Item("year_to"))
                End Select
                sql_join &= String.Format("   GROUP BY a.account_id " & vbNewLine & _
                ") e ON e.account_id = chart.account_id ", dic_e.Item("month_from"), dic_e.Item("year_from"))
            End If
        End If
        Dim sql_select As String = String.Format("SELECT chart.* ")
        If sql_join <> "" Then
            sql_select &= vbNewLine & String.Format("{0} ", sql_select_amount)
            sql_select &= vbNewLine & String.Format("{0} ", sql_select_amount_based)
            sql = String.Format("{0} " & vbNewLine & _
                "FROM SelectIncomeExpenseChart chart " & vbNewLine & _
                "{1}" & vbNewLine & _
                "", sql_select, sql_join)

            Dim sql_company As String = String.Format("SELECT a.company_id,a.company_code,a.company_name " & vbNewLine & _
                ",a.address1 AS address,a.tin " & vbNewLine & _
                "FROM lib_erp_company a " & vbNewLine & _
                "WHERE a.company_id = '{0}' " & vbNewLine & _
                "", main.Sys_Default.Rows(0).Item("company_id"))

            Dim sql_template As String = String.Format("SELECT a.template_id,a.template_code,a.template_name,a.title1,a.title2,a.title3 " & vbNewLine & _
                "FROM sys_template a " & vbNewLine & _
                "WHERE a.template_id = '{0}' " & vbNewLine & _
                "", template_id)

            Dim sql_template_det As String = String.Format("SELECT a.template_det_id,a.template_id " & vbNewLine & _
                ",a.command_code,a.row_type,a.account_id,a.chart_group_id,a.display_text,a.column_num " & vbNewLine & _
                ",a.group_var,a.add_sub,a.repeat_num,a.show_zero,a.indent_num,a.order_by,a.computation " & vbNewLine & _
                ",IF(a.row_type = '0',b.account_code,c.chart_group_code) AS chart_code " & vbNewLine & _
                ",IF(a.row_type = '0',b.account_name,c.chart_group_name) AS chart_name " & vbNewLine & _
                "FROM sys_template_det a " & vbNewLine & _
                "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " & vbNewLine & _
                "LEFT JOIN {1}.lib_acc_chart_group c ON c.chart_group_id = a.chart_group_id " & vbNewLine & _
                "WHERE a.template_id = '{0}' " & vbNewLine & _
                "ORDER BY a.order_by ASC " & vbNewLine & _
                "", template_id, _serverDBFS)

            Dim dt_company As DataTable = FsQuery(sql_company)
            Dim dt As DataTable = Query(sql)
            Dim dt_template As DataTable = Query(sql_template)
            Dim dt_template_det As DataTable = Query(sql_template_det)

            Dim ds As New FSDesign_set

            For Each dr As DataRow In dt.Rows
                ds.Tables("Balance").ImportRow(dr)
            Next
            For Each dr As DataRow In dt_company.Rows
                ds.Tables("Company").ImportRow(dr)
            Next

            Dim rep As New fsdesign_print
            rep.DataSource = ds
            rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
            rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
            If dt_template.Rows.Count > 0 Then
                rep.lblTitle1.Text = dt_template.Rows(0).Item("title1").ToString
                rep.lblTitle2.Text = dt_template.Rows(0).Item("title2").ToString
                rep.lblTitle3.Text = dt_template.Rows(0).Item("title3").ToString
                generateReport(dt_template_det, ds.Tables("Balance"), rep.Detail, rep)
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                MsgBox("No template.")
            End If
        Else
            MsgBox("Select at least one filter.")
        End If
    End Sub
    Private Sub generateReport(ByVal dt_template As DataTable, ByVal dt_balance As DataTable, ByRef rep As DetailBand, ByRef xrep As XtraReport)
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
                        Dim newLbl As New XRLabel
                        newLbl.WidthF = xrep.PageWidth - (xrep.Margins.Left + xrep.Margins.Right)
                        newLbl.HeightF = 10
                        newLbl.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                        newLbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double
                        newLbl.BorderWidth = 5
                        rep.Controls.Add(newLbl)
                        currentY += newLbl.HeightF
                        newLbl.LocationF = New Drawing.PointF(0, currentY)
                    Case "G"
                        isG = True
                        Dim newLbl As New XRLabel
                        newLbl.WidthF = xrep.PageWidth - (xrep.Margins.Left + xrep.Margins.Right)
                        newLbl.HeightF = 10
                        newLbl.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                        newLbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double
                        newLbl.BorderWidth = 1
                        rep.Controls.Add(newLbl)
                        currentY += newLbl.HeightF
                        newLbl.LocationF = New Drawing.PointF(0, currentY)
                    Case "L"
                        isL = True
                        Dim newLbl As New XRLabel
                        newLbl.WidthF = xrep.PageWidth - (xrep.Margins.Left + xrep.Margins.Right)
                        newLbl.HeightF = 10
                        newLbl.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                        newLbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
                        newLbl.BorderWidth = 1
                        rep.Controls.Add(newLbl)
                        currentY += newLbl.HeightF
                        newLbl.LocationF = New Drawing.PointF(0, currentY)
                    Case "S"
                        isS = True
                        currentY += 18
                    Case "T"
                        isT = True
                        Dim newLbl As New XRLabel
                        newLbl.WidthF = xrep.PageWidth - (xrep.Margins.Left + xrep.Margins.Right)
                        newLbl.HeightF = 10
                        newLbl.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                        newLbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
                        newLbl.BorderWidth = 1
                        rep.Controls.Add(newLbl)
                        currentY += newLbl.HeightF
                        newLbl.LocationF = New Drawing.PointF(0, currentY)
                End Select
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

                        If row.Item("row_type").ToString = "0" Then
                            'chart of account
                            If row.Item("display_text").ToString <> "" Then
                            Else
                            End If
                        Else
                            'chart group
                            Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", row.Item("chart_group_id").ToString))
                            Dim lbl As New XRRichText
                            lbl.Name = "lbl" & ctr
                            ctr += 1
                            lbl.CanGrow = True
                            lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
                            'lbl.HeightF = 18
                            If row.Item("display_text").ToString <> "" Then
                                lbl.Text = row.Item("display_text").ToString
                                'Else
                                'lbl.Text = row.Item("chart_name").ToString
                                If isB Then
                                    lbl.Html = String.Format("<b>{0}</b>", lbl.Text)
                                End If
                                If isBU Then
                                    lbl.Html = String.Format("<b><u>{0}</u></b>", lbl.Text)
                                End If
                                If isBI Then
                                    lbl.Html = String.Format("<b><i>{0}</i></b>", lbl.Text)
                                End If
                                If isU Then
                                    lbl.Html = String.Format("<u>{0}</u>", lbl.Text)
                                End If
                                If isI Then
                                    lbl.Html = String.Format("<i>{0}</i>", lbl.Text)
                                End If
                                If isD Then
                                    lbl.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                                    lbl.BorderWidth = 1
                                    lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double
                                End If
                                If isG Then
                                    lbl.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                                    lbl.BorderWidth = 1
                                    lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double
                                    lbl.Html = String.Format("<b>{0}</b>", lbl.Text)
                                End If
                                If isL Then
                                    lbl.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                                    lbl.BorderWidth = 1
                                    lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
                                End If
                                If isT Then
                                    lbl.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                                    lbl.BorderWidth = 1
                                    lbl.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
                                End If
                                rep.Controls.Add(lbl)
                                'lbl.WidthF = lbl.Text.Length * 20
                                Dim size As SizeF = CType(xrep, XtraReport).PrintingSystem.Graph.MeasureString(lbl.Text)
                                lbl.SizeF = size
                                currentY += lbl.HeightF
                                'rep.HeightF = currentY
                                lbl.LocationF = New Drawing.PointF(0, currentY)
                            End If
                            If drs.Length > 0 Then
                                For Each dr In drs
                                    Dim lblAccount As New XRRichText
                                    lblAccount.CanGrow = True
                                    lblAccount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
                                    'lblAccount.HeightF = 18
                                    lblAccount.Text = dr.Item("account_name").ToString
                                    If isB Then
                                        lblAccount.Html = String.Format("<b>{0}</b>", lblAccount.Text)
                                    End If
                                    If isBU Then
                                        lblAccount.Html = String.Format("<b><u>{0}</u></b>", lblAccount.Text)
                                    End If
                                    If isBI Then
                                        lblAccount.Html = String.Format("<b><i>{0}</i></b>", lblAccount.Text)
                                    End If
                                    If isU Then
                                        lblAccount.Html = String.Format("<u>{0}</u>", lblAccount.Text)
                                    End If
                                    If isI Then
                                        lblAccount.Html = String.Format("<i>{0}</i>", lblAccount.Text)
                                    End If
                                    If isD Then
                                        lblAccount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                                        lblAccount.BorderWidth = 1
                                        lblAccount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double
                                    End If
                                    If isG Then
                                        lblAccount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                                        lblAccount.BorderWidth = 1
                                        lblAccount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double
                                        lblAccount.Html = String.Format("<b>{0}</b>", lblAccount.Text)
                                    End If
                                    If isL Then
                                        lblAccount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                                        lblAccount.BorderWidth = 1
                                        lblAccount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
                                    End If
                                    If isT Then
                                        lblAccount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
                                        lblAccount.BorderWidth = 1
                                        lblAccount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
                                    End If
                                    lblAccount.Name = "lblAccount" & ctr
                                    ctr += 1
                                    'rep.HeightF = currentY
                                    'lblAccount.WidthF = lblAccount.Text.Length * 10
                                    Dim size As SizeF = CType(xrep, XtraReport).PrintingSystem.Graph.MeasureString(lblAccount.Text)
                                    lblAccount.SizeF = size
                                    currentY += lblAccount.HeightF
                                    lblAccount.LocationF = New Drawing.PointF(0, currentY)
                                    rep.Controls.Add(lblAccount)
                                Next
                            End If
                        End If
                    Case "H"
                    Case "IN"
                End Select
            End If
        Next
    End Sub
End Class