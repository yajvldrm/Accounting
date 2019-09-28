Imports user_control
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.Drawing
Imports libacctng.myFunctions
Imports Microsoft.Office.Interop

Public Class new_fs_filter
    Private strChar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private strCharacter As String = ""
    Public Property FS_Type As Integer = 0
    Public Property template_id As String = ""
    Private Sub CreateTextBrowse(ByVal sql As String,
                                 ByVal q As String,
                                 ByVal label As String,
                                 ByVal field As String,
                                 ByVal width As String,
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
    Private Sub setLabel(ByVal sender As Object)
        If TypeOf sender Is user_control.textbox Then
            Dim txt = CType(sender, user_control.textbox)
            Select Case txt.Name
                Case "scope_a"
                    month_to_a.Enabled = False
                    year_to_a.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_a.Text = "FOR THE MONTH"
                            label_to_a.Text = month_from_a.Text.ToUpper & " " & year_from_a.Value
                        Case "2"
                            label_from_a.Text = "AS OF"
                            label_to_a.Text = month_from_a.Text.ToUpper & " " & year_from_a.Value
                        Case "3"
                            label_from_a.Text = "RANGED"
                            label_to_a.Text = month_from_a.Text.ToUpper & " " & year_from_a.Value & " - " & month_to_a.Text.ToUpper & " " & year_to_a.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_a.Enabled = True
                        year_to_a.Enabled = True
                    End If
                Case "scope_b"
                    month_to_b.Enabled = False
                    year_to_b.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_b.Text = "FOR THE MONTH"
                            label_to_b.Text = month_from_b.Text.ToUpper & " " & year_from_b.Value
                        Case "2"
                            label_from_b.Text = "AS OF"
                            label_to_b.Text = month_from_b.Text.ToUpper & " " & year_from_b.Value
                        Case "3"
                            label_from_b.Text = "RANGED"
                            label_to_b.Text = month_from_b.Text.ToUpper & " " & year_from_b.Value & " - " & month_to_b.Text.ToUpper & " " & year_to_b.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_b.Enabled = True
                        year_to_b.Enabled = True
                    End If
                Case "scope_c"
                    month_to_c.Enabled = False
                    year_to_c.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_c.Text = "FOR THE MONTH"
                            label_to_c.Text = month_from_c.Text.ToUpper & " " & year_from_c.Value
                        Case "2"
                            label_from_c.Text = "AS OF"
                            label_to_c.Text = month_from_c.Text.ToUpper & " " & year_from_c.Value
                        Case "3"
                            label_from_c.Text = "RANGED"
                            label_to_c.Text = month_from_c.Text.ToUpper & " " & year_from_c.Value & " - " & month_to_c.Text.ToUpper & " " & year_to_c.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_c.Enabled = True
                        year_to_c.Enabled = True
                    End If
                Case "scope_d"
                    month_to_d.Enabled = False
                    year_to_d.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_d.Text = "FOR THE MONTH"
                            label_to_d.Text = month_from_d.Text.ToUpper & " " & year_from_d.Value
                        Case "2"
                            label_from_d.Text = "AS OF"
                            label_to_d.Text = month_from_d.Text.ToUpper & " " & year_from_d.Value
                        Case "3"
                            label_from_d.Text = "RANGED"
                            label_to_d.Text = month_from_d.Text.ToUpper & " " & year_from_d.Value & " - " & month_to_d.Text.ToUpper & " " & year_to_d.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_d.Enabled = True
                        year_to_d.Enabled = True
                    End If
                Case "scope_e"
                    month_to_e.Enabled = False
                    year_to_e.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_e.Text = "FOR THE MONTH"
                            label_to_e.Text = month_from_e.Text.ToUpper & " " & year_from_e.Value
                        Case "2"
                            label_from_e.Text = "AS OF"
                            label_to_e.Text = month_from_e.Text.ToUpper & " " & year_from_e.Value
                        Case "3"
                            label_from_e.Text = "RANGED"
                            label_to_e.Text = month_from_e.Text.ToUpper & " " & year_from_e.Value & " - " & month_to_e.Text.ToUpper & " " & year_to_e.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_e.Enabled = True
                        year_to_e.Enabled = True
                    End If
                Case "scope_f"
                    month_to_f.Enabled = False
                    year_to_f.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_f.Text = "FOR THE MONTH"
                            label_to_f.Text = month_from_f.Text.ToUpper & " " & year_from_f.Value
                        Case "2"
                            label_from_f.Text = "AS OF"
                            label_to_f.Text = month_from_f.Text.ToUpper & " " & year_from_f.Value
                        Case "3"
                            label_from_f.Text = "RANGED"
                            label_to_f.Text = month_from_f.Text.ToUpper & " " & year_from_f.Value & " - " & month_to_f.Text.ToUpper & " " & year_to_f.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_f.Enabled = True
                        year_to_f.Enabled = True
                    End If
                Case "scope_g"
                    month_to_g.Enabled = False
                    year_to_g.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_g.Text = "FOR THE MONTH"
                            label_to_g.Text = month_from_g.Text.ToUpper & " " & year_from_g.Value
                        Case "2"
                            label_from_g.Text = "AS OF"
                            label_to_g.Text = month_from_g.Text.ToUpper & " " & year_from_g.Value
                        Case "3"
                            label_from_g.Text = "RANGED"
                            label_to_g.Text = month_from_g.Text.ToUpper & " " & year_from_g.Value & " - " & month_to_g.Text.ToUpper & " " & year_to_g.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_g.Enabled = True
                        year_to_g.Enabled = True
                    End If
                Case "scope_h"
                    month_to_h.Enabled = False
                    year_to_h.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_h.Text = "FOR THE MONTH"
                            label_to_h.Text = month_from_h.Text.ToUpper & " " & year_from_h.Value
                        Case "2"
                            label_from_h.Text = "AS OF"
                            label_to_h.Text = month_from_h.Text.ToUpper & " " & year_from_h.Value
                        Case "3"
                            label_from_h.Text = "RANGED"
                            label_to_h.Text = month_from_h.Text.ToUpper & " " & year_from_h.Value & " - " & month_to_h.Text.ToUpper & " " & year_to_h.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_h.Enabled = True
                        year_to_h.Enabled = True
                    End If
                Case "scope_i"
                    month_to_i.Enabled = False
                    year_to_i.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_i.Text = "FOR THE MONTH"
                            label_to_i.Text = month_from_i.Text.ToUpper & " " & year_from_i.Value
                        Case "2"
                            label_from_i.Text = "AS OF"
                            label_to_i.Text = month_from_i.Text.ToUpper & " " & year_from_i.Value
                        Case "3"
                            label_from_i.Text = "RANGED"
                            label_to_i.Text = month_from_i.Text.ToUpper & " " & year_from_i.Value & " - " & month_to_i.Text.ToUpper & " " & year_to_i.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_i.Enabled = True
                        year_to_i.Enabled = True
                    End If
                Case "scope_j"
                    month_to_j.Enabled = False
                    year_to_j.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_j.Text = "FOR THE MONTH"
                            label_to_j.Text = month_from_j.Text.ToUpper & " " & year_from_j.Value
                        Case "2"
                            label_from_j.Text = "AS OF"
                            label_to_j.Text = month_from_j.Text.ToUpper & " " & year_from_j.Value
                        Case "3"
                            label_from_j.Text = "RANGED"
                            label_to_j.Text = month_from_j.Text.ToUpper & " " & year_from_j.Value & " - " & month_to_j.Text.ToUpper & " " & year_to_j.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_j.Enabled = True
                        year_to_j.Enabled = True
                    End If
                Case "scope_k"
                    month_to_k.Enabled = False
                    year_to_k.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_k.Text = "FOR THE MONTH"
                            label_to_k.Text = month_from_k.Text.ToUpper & " " & year_from_k.Value
                        Case "2"
                            label_from_k.Text = "AS OF"
                            label_to_k.Text = month_from_k.Text.ToUpper & " " & year_from_k.Value
                        Case "3"
                            label_from_k.Text = "RANGED"
                            label_to_k.Text = month_from_k.Text.ToUpper & " " & year_from_k.Value & " - " & month_to_k.Text.ToUpper & " " & year_to_k.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_k.Enabled = True
                        year_to_k.Enabled = True
                    End If
                Case "scope_l"
                    month_to_l.Enabled = False
                    year_to_l.Enabled = False
                    Select Case txt.Value
                        Case "1"
                            label_from_l.Text = "FOR THE MONTH"
                            label_to_l.Text = month_from_l.Text.ToUpper & " " & year_from_l.Value
                        Case "2"
                            label_from_l.Text = "AS OF"
                            label_to_l.Text = month_from_l.Text.ToUpper & " " & year_from_l.Value
                        Case "3"
                            label_from_l.Text = "RANGED"
                            label_to_l.Text = month_from_l.Text.ToUpper & " " & year_from_l.Value & " - " & month_to_l.Text.ToUpper & " " & year_to_l.Value
                    End Select
                    If txt.Value = "3" Then
                        month_to_l.Enabled = True
                        year_to_l.Enabled = True
                    End If
            End Select
        End If
    End Sub
    Private Sub MonthChange(sender As Object, e As EventArgs) Handles month_to_l.SelectedValueChanged, month_to_k.SelectedValueChanged, month_to_j.SelectedValueChanged, month_to_i.SelectedValueChanged, month_to_h.SelectedValueChanged, month_to_g.SelectedValueChanged, month_to_f.SelectedValueChanged, month_to_e.SelectedValueChanged, month_to_d.SelectedValueChanged, month_to_c.SelectedValueChanged, month_to_b.SelectedValueChanged, month_to_a.SelectedValueChanged, month_from_l.SelectedValueChanged, month_from_k.SelectedValueChanged, month_from_j.SelectedValueChanged, month_from_i.SelectedValueChanged, month_from_h.SelectedValueChanged, month_from_g.SelectedValueChanged, month_from_f.SelectedValueChanged, month_from_e.SelectedValueChanged, month_from_d.SelectedValueChanged, month_from_c.SelectedValueChanged, month_from_b.SelectedValueChanged, month_from_a.SelectedValueChanged
        If sender.Name.ToString <> "" Then
            Dim postFix = sender.Name.ToString.Substring(sender.Name.ToString.Length - 1, 1)
            Select Case postFix
                Case "a"
                    setLabel(scope_a)
                Case "b"
                    setLabel(scope_b)
                Case "c"
                    setLabel(scope_c)
                Case "d"
                    setLabel(scope_d)
                Case "e"
                    setLabel(scope_e)
                Case "f"
                    setLabel(scope_f)
                Case "g"
                    setLabel(scope_g)
                Case "h"
                    setLabel(scope_h)
                Case "i"
                    setLabel(scope_i)
                Case "j"
                    setLabel(scope_j)
                Case "k"
                    setLabel(scope_k)
                Case "l"
                    setLabel(scope_l)
            End Select
        End If
    End Sub
    Private Sub YearChange(sender As Object, e As EventArgs) Handles year_to_l.ValueChanged, year_to_k.ValueChanged, year_to_j.ValueChanged, year_to_i.ValueChanged, year_to_h.ValueChanged, year_to_g.ValueChanged, year_to_f.ValueChanged, year_to_e.ValueChanged, year_to_d.ValueChanged, year_to_c.ValueChanged, year_to_b.ValueChanged, year_to_a.ValueChanged, year_from_l.ValueChanged, year_from_k.ValueChanged, year_from_j.ValueChanged, year_from_i.ValueChanged, year_from_h.ValueChanged, year_from_g.ValueChanged, year_from_f.ValueChanged, year_from_e.ValueChanged, year_from_d.ValueChanged, year_from_c.ValueChanged, year_from_b.ValueChanged, year_from_a.ValueChanged
        If sender.Name.ToString <> "" Then
            Dim postFix = sender.Name.ToString.Substring(sender.Name.ToString.Length - 1, 1)
            Select Case postFix
                Case "a"
                    setLabel(scope_a)
                Case "b"
                    setLabel(scope_b)
                Case "c"
                    setLabel(scope_c)
                Case "d"
                    setLabel(scope_d)
                Case "e"
                    setLabel(scope_e)
                Case "f"
                    setLabel(scope_f)
                Case "g"
                    setLabel(scope_g)
                Case "h"
                    setLabel(scope_h)
                Case "i"
                    setLabel(scope_i)
                Case "j"
                    setLabel(scope_j)
                Case "k"
                    setLabel(scope_k)
                Case "l"
                    setLabel(scope_l)
            End Select
        End If
    End Sub
    Private Sub BookFIlter(sender As Object, e As EventArgs) Handles book_a.Leave, book_b.Leave, book_c.Leave, book_d.Leave, book_e.Leave, book_f.Leave, book_g.Leave, book_h.Leave, book_i.Leave, book_j.Leave, book_k.Leave, book_l.Leave
        Dim company_id As String = main.Sys_Default.Rows(0).Item("company_id").ToString
        Dim txt = CType(sender, user_control.textbox)
        Dim sql As String = String.Format("SELECT book_id,book_code,book_name 
            FROM lib_erp_book
            WHERE company_id = '{0}'
        ", company_id)
        Dim str = sender.Text.Trim
        Dim label As String = "Code,Name"
        Dim field As String = "book_code,book_name"
        Dim width As String = "100,200"
        Dim drVar As DataRow = Nothing

        CreateTextBrowse(sql, str, label, field, width, drVar)
        If TypeOf sender Is user_control.textbox Then
            If drVar IsNot Nothing Then
                txt.RowData = drVar
                txt.Text = drVar.Item("book_name").ToString
                txt.Value = drVar.Item("book_id").ToString
            Else
                txt.RowData = Nothing
                txt.Text = ""
                txt.Value = ""
            End If
        End If
    End Sub
    Private Sub ScopeFilter(sender As Object, e As EventArgs) Handles scope_a.Leave, scope_l.Leave, scope_k.Leave, scope_j.Leave, scope_i.Leave, scope_h.Leave, scope_g.Leave, scope_f.Leave, scope_e.Leave, scope_d.Leave, scope_c.Leave, scope_b.Leave
        Dim txt = CType(sender, user_control.textbox)
        Dim sql As String = String.Format("SELECT 'FOR THE MONTH' AS range_name,'1' AS range_id " &
            "UNION SELECT 'AS OF','2' " &
            "UNION SELECT 'DATE RANGE','3' " &
            "")
        Dim str = sender.Text.Trim
        Dim label As String = "ID,Range"
        Dim field As String = "range_id,range_name"
        Dim width As String = "10,100"
        Dim drVar As DataRow = Nothing

        CreateTextBrowse(sql, str, label, field, width, drVar)
        If TypeOf sender Is user_control.textbox Then
            If drVar IsNot Nothing Then
                txt.RowData = drVar
                txt.Text = drVar.Item("range_name").ToString
                txt.Value = drVar.Item("range_id").ToString
            Else
                txt.RowData = Nothing
                txt.Text = ""
                txt.Value = ""
            End If
        End If
    End Sub
    Private Sub TemplateChange(sender As Object, e As EventArgs) Handles txt_template_id.Leave
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
            Else
                txt.Text = ""
                txt.Value = ""
                template_id = ""
            End If
        End If
    End Sub
    Private Sub ProjectChange(sender As Object, e As EventArgs) Handles txt_project_id.Leave
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
            Else
                txt.Text = ""
                txt.Value = ""
                txt_project_name.Text = ""
            End If
        End If
    End Sub
    Private Sub GetDateFromTo(ByVal monthFrom As ComboBox, ByVal yearFrom As NumericUpDown, ByVal monthTo As ComboBox, ByVal yearTo As NumericUpDown, ByRef dFrom As Date, ByRef dTo As Date)
        Dim date_from As Date = New Date(yearFrom.Value.ToString, monthFrom.SelectedIndex + 1, 1)
        Dim date_to As Date = New Date(yearTo.Value.ToString, monthTo.SelectedIndex + 1, 1)
        If date_from.Month = 12 Then
            date_from = New Date(date_from.Year, 12, 31)
        Else
            date_from = New Date(date_from.Year, date_from.Month + 1, 1)
            date_from = date_from.AddDays(-1)
        End If
        If date_to.Month = 12 Then
            date_to = New Date(date_to.Year, 12, 31)
        Else
            date_to = New Date(date_to.Year, date_to.Month + 1, 1)
            date_to = date_to.AddDays(-1)
        End If
        dFrom = date_from
        dTo = date_to
    End Sub
    Private Sub GetStringQuery(ByVal dic As Dictionary(Of String, String), ByVal var As String, ByVal date_from As Date, ByVal date_to As Date, ByRef sql_select_amount As String, ByRef sql_join As String)
        If CBool(dic.Item("enable")) Then
            If dic.Item("source") = "1" Or dic.Item("source") = "" Then
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL({0}.debit,0) - IFNULL({0}.credit,0),IFNULL({0}.credit,0) - IFNULL({0}.debit,0)) AS {0}_amount ", var)
                sql_select_amount &= String.Format(",IF(chart.chart_type = 'A' OR chart.chart_type = 'E',IFNULL({0}.debit_based,0) - IFNULL({0}.credit_based,0),IFNULL({0}.credit_based,0) - IFNULL({0}.debit_based,0)) AS {0}_amount_based", var)
                sql_select_amount &= String.Format(",{0}.project_id AS {0}_project_id,{0}.project_code AS {0}_project_code,{0}.project_name AS {0}_project_name ", var)
                sql_select_amount &= String.Format(",{0}.general_id AS {0}_general_id,{0}.general_code AS {0}_general_code,{0}.general_name AS {0}_general_name ", var)
                'If txtGenLib.Checked Then
                '    sql_join &= String.Format("LEFT JOIN (" &
                '"   SELECT a.account_id " &
                '"   ,SUM(IFNULL(a.debit,0)) AS debit " &
                '"   ,SUM(IFNULL(a.credit,0)) AS credit " &
                '"   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " &
                '"   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
                '"   ,a.project_id,a.project_code,a.project_name " &
                '"   FROM {0}.select_account_general_amount a", _serverDBMain)
                'Else
                '    sql_join &= String.Format("LEFT JOIN (" &
                '"   SELECT a.account_id " &
                '"   ,SUM(IFNULL(a.debit,0)) AS debit " &
                '"   ,SUM(IFNULL(a.credit,0)) AS credit " &
                '"   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " &
                '"   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
                '"   ,a.project_id,a.project_code,a.project_name " &
                '"   FROM {0}.SelectChartAmount a", _serverDBMain)
                'End If

                sql_join &= String.Format("LEFT JOIN (" &
                "   SELECT a.account_id " &
                "   ,SUM(IFNULL(a.debit,0)) AS debit " &
                "   ,SUM(IFNULL(a.credit,0)) AS credit " &
                "   ,SUM(IFNULL(a.debit_based,0)) AS debit_based " &
                "   ,SUM(IFNULL(a.credit_based,0)) AS credit_based " &
                "   ,a.project_id,a.project_code,a.project_name " &
                "   ,a.general_id,a.general_code,a.general_name " &
                "   FROM {0}.SelectChartAmount a", _serverDBMain)
                Select Case dic.Item("range")
                    Case "1"
                        sql_join &= String.Format("  WHERE DATE_FORMAT(a.trans_date,'%m-%Y') = DATE_FORMAT('{0}','%m-%Y') ",
                            date_from.ToString("yyyy-MM-dd"))
                    Case "2"
                        sql_join &= String.Format("   WHERE a.trans_date <= '{0}' ",
                            date_from.ToString("yyyy-MM-dd"))
                    Case "3"
                        sql_join &= String.Format("   WHERE a.trans_date BETWEEN '{0}-{1}-1' AND '{2}' ",
                            date_from.Year(), date_from.Month(), date_to.ToString("yyyy-MM-dd"))
                End Select
                If ifNull(dic.Item("project_id"), "").ToString <> "" Then
                    sql_join &= String.Format(" AND a.project_id = '{0}'", dic.Item("project_id"))
                End If
                If ifNull(dic.Item("book"), "") <> "" Then
                    sql_join &= String.Format(" AND a.book_id = '{0}'", dic.Item("book"))
                End If
                If txtGenLib.Checked Then
                    sql_join &= String.Format("   GROUP BY a.account_id,a.general_id " &
                ") {2} ON {2}.account_id = chart.account_id AND {2}.general_id = chart.general_id ", dic.Item("month_from"), dic.Item("year_from"), var)
                Else
                    sql_join &= String.Format("   GROUP BY a.account_id " &
                ") {2} ON {2}.account_id = chart.account_id ", dic.Item("month_from"), dic.Item("year_from"), var)
                End If
            End If
        End If
    End Sub
    Private Sub InitializeFilter()
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
        month_from_a.Text = "January"
        month_to_a.Text = "December"
        year_from_a.Value = Today.Year
        year_to_a.Value = Today.Year
        scope_a.Text = "FOR THE MONTH"
        scope_a.Value = "1"
        setLabel(scope_a)

        month_from_b.Text = "January"
        month_to_b.Text = "December"
        year_from_b.Value = Today.Year
        year_to_b.Value = Today.Year
        scope_b.Text = "FOR THE MONTH"
        scope_b.Value = "1"
        setLabel(scope_b)

        month_from_c.Text = "January"
        month_to_c.Text = "December"
        year_from_c.Value = Today.Year
        year_to_c.Value = Today.Year
        scope_c.Text = "FOR THE MONTH"
        scope_c.Value = "1"
        setLabel(scope_c)

        month_from_d.Text = "January"
        month_to_d.Text = "December"
        year_from_d.Value = Today.Year
        year_to_d.Value = Today.Year
        scope_d.Text = "FOR THE MONTH"
        scope_d.Value = "1"
        setLabel(scope_d)

        month_from_e.Text = "January"
        month_to_e.Text = "December"
        year_from_e.Value = Today.Year
        year_to_e.Value = Today.Year
        scope_e.Text = "FOR THE MONTH"
        scope_e.Value = "1"
        setLabel(scope_e)

        month_from_f.Text = "January"
        month_to_f.Text = "December"
        year_from_f.Value = Today.Year
        year_to_f.Value = Today.Year
        scope_f.Text = "FOR THE MONTH"
        scope_f.Value = "1"
        setLabel(scope_f)

        month_from_g.Text = "January"
        month_to_g.Text = "December"
        year_from_g.Value = Today.Year
        year_to_g.Value = Today.Year
        scope_g.Text = "FOR THE MONTH"
        scope_g.Value = "1"
        setLabel(scope_g)

        month_from_h.Text = "January"
        month_to_h.Text = "December"
        year_from_h.Value = Today.Year
        year_to_h.Value = Today.Year
        scope_h.Text = "FOR THE MONTH"
        scope_h.Value = "1"
        setLabel(scope_h)

        month_from_i.Text = "January"
        month_to_i.Text = "December"
        year_from_i.Value = Today.Year
        year_to_i.Value = Today.Year
        scope_i.Text = "FOR THE MONTH"
        scope_i.Value = "1"
        setLabel(scope_i)

        month_from_j.Text = "January"
        month_to_j.Text = "December"
        year_from_j.Value = Today.Year
        year_to_j.Value = Today.Year
        scope_j.Text = "FOR THE MONTH"
        scope_j.Value = "1"
        setLabel(scope_j)

        month_from_k.Text = "January"
        month_to_k.Text = "December"
        year_from_k.Value = Today.Year
        year_to_k.Value = Today.Year
        scope_k.Text = "FOR THE MONTH"
        scope_k.Value = "1"
        setLabel(scope_k)

        month_from_l.Text = "January"
        month_to_l.Text = "December"
        year_from_l.Value = Today.Year
        year_to_l.Value = Today.Year
        scope_l.Text = "FOR THE MONTH"
        scope_l.Value = "1"
        setLabel(scope_l)
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim wZero As Boolean = w_zero.Checked
        Dim wAccountCode As Boolean = txtAccountCode.Checked
#Region "Date Init"

        Dim a_date_from As New Date
        Dim a_date_to As New Date
        GetDateFromTo(month_from_a, year_from_a, month_to_a, year_to_a, a_date_from, a_date_to)

        Dim b_date_from As New Date
        Dim b_date_to As New Date
        GetDateFromTo(month_from_b, year_from_b, month_to_b, year_to_b, b_date_from, b_date_to)

        Dim c_date_from As New Date
        Dim c_date_to As New Date
        GetDateFromTo(month_from_c, year_from_c, month_to_c, year_to_c, c_date_from, c_date_to)

        Dim d_date_from As New Date
        Dim d_date_to As New Date
        GetDateFromTo(month_from_d, year_from_d, month_to_d, year_to_d, d_date_from, d_date_to)

        Dim e_date_from As New Date
        Dim e_date_to As New Date
        GetDateFromTo(month_from_e, year_from_e, month_to_e, year_to_e, e_date_from, e_date_to)

        Dim f_date_from As New Date
        Dim f_date_to As New Date
        GetDateFromTo(month_from_f, year_from_f, month_to_f, year_to_f, f_date_from, f_date_to)

        Dim g_date_from As New Date
        Dim g_date_to As New Date
        GetDateFromTo(month_from_g, year_from_g, month_to_g, year_to_g, g_date_from, g_date_to)

        Dim h_date_from As New Date
        Dim h_date_to As New Date
        GetDateFromTo(month_from_h, year_from_h, month_to_h, year_to_h, h_date_from, h_date_to)

        Dim i_date_from As New Date
        Dim i_date_to As New Date
        GetDateFromTo(month_from_i, year_from_i, month_to_i, year_to_i, i_date_from, i_date_to)

        Dim j_date_from As New Date
        Dim j_date_to As New Date
        GetDateFromTo(month_from_j, year_from_j, month_to_j, year_to_j, j_date_from, j_date_to)

        Dim k_date_from As New Date
        Dim k_date_to As New Date
        GetDateFromTo(month_from_k, year_from_k, month_to_k, year_to_k, k_date_from, k_date_to)

        Dim l_date_from As New Date
        Dim l_date_to As New Date
        GetDateFromTo(month_from_l, year_from_l, month_to_l, year_to_l, l_date_from, l_date_to)
#End Region
#Region "Dictionary Init"

        Dim dic_a As New Dictionary(Of String, String)
        dic_a.Add("source", "")
        dic_a.Add("book", book_a.Value.ToString)
        dic_a.Add("range", scope_a.Value.ToString)
        dic_a.Add("month_from", month_from_a.SelectedIndex + 1)
        dic_a.Add("year_from", year_from_a.Value.ToString)
        dic_a.Add("month_to", month_to_a.SelectedIndex + 1)
        dic_a.Add("year_to", year_to_a.Value.ToString)
        dic_a.Add("enable", enable_a.Checked)
        dic_a.Add("project_id", txt_project_id.Value.ToString)
        dic_a.Add("project_name", txt_project_id.Text.ToString)
        dic_a.Add("label_from", label_from_a.Text.ToString)
        dic_a.Add("label_to", label_to_a.Text.ToString)
        Dim dic_b As New Dictionary(Of String, String)
        dic_b.Add("source", "")
        dic_b.Add("book", book_b.Value.ToString)
        dic_b.Add("range", scope_b.Value.ToString)
        dic_b.Add("month_from", month_from_b.SelectedIndex + 1)
        dic_b.Add("year_from", year_from_b.Value.ToString)
        dic_b.Add("month_to", month_to_b.SelectedIndex + 1)
        dic_b.Add("year_to", year_to_b.Value.ToString)
        dic_b.Add("enable", enable_b.Checked)
        dic_b.Add("project_id", txt_project_id.Value.ToString)
        dic_b.Add("project_name", txt_project_id.Text.ToString)
        dic_b.Add("label_from", label_from_b.Text.ToString)
        dic_b.Add("label_to", label_to_b.Text.ToString)
        Dim dic_c As New Dictionary(Of String, String)
        dic_c.Add("source", "")
        dic_c.Add("book", book_c.Value.ToString)
        dic_c.Add("range", scope_c.Value.ToString)
        dic_c.Add("month_from", month_from_c.SelectedIndex + 1)
        dic_c.Add("year_from", year_from_c.Value.ToString)
        dic_c.Add("month_to", month_to_c.SelectedIndex + 1)
        dic_c.Add("year_to", year_to_c.Value.ToString)
        dic_c.Add("enable", enable_c.Checked)
        dic_c.Add("project_id", txt_project_id.Value.ToString)
        dic_c.Add("project_name", txt_project_id.Text.ToString)
        dic_c.Add("label_from", label_from_c.Text.ToString)
        dic_c.Add("label_to", label_to_c.Text.ToString)
        Dim dic_d As New Dictionary(Of String, String)
        dic_d.Add("source", "")
        dic_d.Add("book", book_d.Value.ToString)
        dic_d.Add("range", scope_d.Value.ToString)
        dic_d.Add("month_from", month_from_d.SelectedIndex + 1)
        dic_d.Add("year_from", year_from_d.Value.ToString)
        dic_d.Add("month_to", month_to_d.SelectedIndex + 1)
        dic_d.Add("year_to", year_to_d.Value.ToString)
        dic_d.Add("enable", enable_d.Checked)
        dic_d.Add("project_id", txt_project_id.Value.ToString)
        dic_d.Add("project_name", txt_project_id.Text.ToString)
        dic_d.Add("label_from", label_from_d.Text.ToString)
        dic_d.Add("label_to", label_to_d.Text.ToString)
        Dim dic_e As New Dictionary(Of String, String)
        dic_e.Add("source", "")
        dic_e.Add("book", book_e.Value.ToString)
        dic_e.Add("range", scope_e.Value.ToString)
        dic_e.Add("month_from", month_from_e.SelectedIndex + 1)
        dic_e.Add("year_from", year_from_e.Value.ToString)
        dic_e.Add("month_to", month_to_e.SelectedIndex + 1)
        dic_e.Add("year_to", year_to_e.Value.ToString)
        dic_e.Add("enable", enable_e.Checked)
        dic_e.Add("project_id", txt_project_id.Value.ToString)
        dic_e.Add("project_name", txt_project_id.Text.ToString)
        dic_e.Add("label_from", label_from_e.Text.ToString)
        dic_e.Add("label_to", label_to_e.Text.ToString)
        Dim dic_f As New Dictionary(Of String, String)
        dic_f.Add("source", "")
        dic_f.Add("book", book_f.Value.ToString)
        dic_f.Add("range", scope_f.Value.ToString)
        dic_f.Add("month_from", month_from_f.SelectedIndex + 1)
        dic_f.Add("year_from", year_from_f.Value.ToString)
        dic_f.Add("month_to", month_to_f.SelectedIndex + 1)
        dic_f.Add("year_to", year_to_f.Value.ToString)
        dic_f.Add("enable", enable_f.Checked)
        dic_f.Add("project_id", txt_project_id.Value.ToString)
        dic_f.Add("project_name", txt_project_id.Text.ToString)
        dic_f.Add("label_from", label_from_f.Text.ToString)
        dic_f.Add("label_to", label_to_f.Text.ToString)
        Dim dic_g As New Dictionary(Of String, String)
        dic_g.Add("source", "")
        dic_g.Add("book", book_g.Value.ToString)
        dic_g.Add("range", scope_g.Value.ToString)
        dic_g.Add("month_from", month_from_g.SelectedIndex + 1)
        dic_g.Add("year_from", year_from_g.Value.ToString)
        dic_g.Add("month_to", month_to_g.SelectedIndex + 1)
        dic_g.Add("year_to", year_to_g.Value.ToString)
        dic_g.Add("enable", enable_g.Checked)
        dic_g.Add("project_id", txt_project_id.Value.ToString)
        dic_g.Add("project_name", txt_project_id.Text.ToString)
        dic_g.Add("label_from", label_from_g.Text.ToString)
        dic_g.Add("label_to", label_to_g.Text.ToString)
        Dim dic_h As New Dictionary(Of String, String)
        dic_h.Add("source", "")
        dic_h.Add("book", book_h.Value.ToString)
        dic_h.Add("range", scope_h.Value.ToString)
        dic_h.Add("month_from", month_from_h.SelectedIndex + 1)
        dic_h.Add("year_from", year_from_h.Value.ToString)
        dic_h.Add("month_to", month_to_h.SelectedIndex + 1)
        dic_h.Add("year_to", year_to_h.Value.ToString)
        dic_h.Add("enable", enable_h.Checked)
        dic_h.Add("project_id", txt_project_id.Value.ToString)
        dic_h.Add("project_name", txt_project_id.Text.ToString)
        dic_h.Add("label_from", label_from_h.Text.ToString)
        dic_h.Add("label_to", label_to_h.Text.ToString)
        Dim dic_i As New Dictionary(Of String, String)
        dic_i.Add("source", "")
        dic_i.Add("book", book_i.Value.ToString)
        dic_i.Add("range", scope_i.Value.ToString)
        dic_i.Add("month_from", month_from_i.SelectedIndex + 1)
        dic_i.Add("year_from", year_from_i.Value.ToString)
        dic_i.Add("month_to", month_to_i.SelectedIndex + 1)
        dic_i.Add("year_to", year_to_i.Value.ToString)
        dic_i.Add("enable", enable_i.Checked)
        dic_i.Add("project_id", txt_project_id.Value.ToString)
        dic_i.Add("project_name", txt_project_id.Text.ToString)
        dic_i.Add("label_from", label_from_i.Text.ToString)
        dic_i.Add("label_to", label_to_i.Text.ToString)
        Dim dic_j As New Dictionary(Of String, String)
        dic_j.Add("source", "")
        dic_j.Add("book", book_j.Value.ToString)
        dic_j.Add("range", scope_j.Value.ToString)
        dic_j.Add("month_from", month_from_j.SelectedIndex + 1)
        dic_j.Add("year_from", year_from_j.Value.ToString)
        dic_j.Add("month_to", month_to_j.SelectedIndex + 1)
        dic_j.Add("year_to", year_to_j.Value.ToString)
        dic_j.Add("enable", enable_j.Checked)
        dic_j.Add("project_id", txt_project_id.Value.ToString)
        dic_j.Add("project_name", txt_project_id.Text.ToString)
        dic_j.Add("label_from", label_from_j.Text.ToString)
        dic_j.Add("label_to", label_to_j.Text.ToString)
        Dim dic_k As New Dictionary(Of String, String)
        dic_k.Add("source", "")
        dic_k.Add("book", book_k.Value.ToString)
        dic_k.Add("range", scope_k.Value.ToString)
        dic_k.Add("month_from", month_from_k.SelectedIndex + 1)
        dic_k.Add("year_from", year_from_k.Value.ToString)
        dic_k.Add("month_to", month_to_k.SelectedIndex + 1)
        dic_k.Add("year_to", year_to_k.Value.ToString)
        dic_k.Add("enable", enable_k.Checked)
        dic_k.Add("project_id", txt_project_id.Value.ToString)
        dic_k.Add("project_name", txt_project_id.Text.ToString)
        dic_k.Add("label_from", label_from_k.Text.ToString)
        dic_k.Add("label_to", label_to_k.Text.ToString)
        Dim dic_l As New Dictionary(Of String, String)
        dic_l.Add("source", "")
        dic_l.Add("book", book_l.Value.ToString)
        dic_l.Add("range", scope_l.Value.ToString)
        dic_l.Add("month_from", month_from_l.SelectedIndex + 1)
        dic_l.Add("year_from", year_from_l.Value.ToString)
        dic_l.Add("month_to", month_to_l.SelectedIndex + 1)
        dic_l.Add("year_to", year_to_l.Value.ToString)
        dic_l.Add("enable", enable_l.Checked)
        dic_l.Add("project_id", txt_project_id.Value.ToString)
        dic_l.Add("project_name", txt_project_id.Text.ToString)
        dic_l.Add("label_from", label_from_l.Text.ToString)
        dic_l.Add("label_to", label_to_l.Text.ToString)
        Dim dic_all As New Dictionary(Of String, Dictionary(Of String, String))
        dic_all.Add("a", dic_a)
        dic_all.Add("b", dic_b)
        dic_all.Add("c", dic_c)
        dic_all.Add("d", dic_d)
        dic_all.Add("e", dic_e)
        dic_all.Add("f", dic_f)
        dic_all.Add("g", dic_g)
        dic_all.Add("h", dic_h)
        dic_all.Add("i", dic_i)
        dic_all.Add("j", dic_j)
        dic_all.Add("k", dic_k)
        dic_all.Add("l", dic_l)
#End Region
        Dim sql As String = ""
        Dim sql_select_amount As String = ""
        Dim sql_select_amount_based As String = ""
        Dim sql_join As String = ""
#Region "Query String Init"

        GetStringQuery(dic_a, "a", a_date_from, a_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_b, "b", b_date_from, b_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_c, "c", c_date_from, c_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_d, "d", d_date_from, d_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_e, "e", e_date_from, e_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_f, "f", f_date_from, f_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_g, "g", g_date_from, g_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_h, "h", h_date_from, h_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_i, "i", i_date_from, i_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_j, "j", j_date_from, j_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_k, "k", k_date_from, k_date_to, sql_select_amount, sql_join)
        GetStringQuery(dic_l, "l", l_date_from, l_date_to, sql_select_amount, sql_join)
#End Region
        Dim sql_select As String = String.Format("SELECT chart.* ")
        If sql_join <> "" Then
            sql_select &= vbNewLine & String.Format("{0} ", sql_select_amount)
            sql_select &= vbNewLine & String.Format("{0} ", sql_select_amount_based)
            'If FS_Type = 2 Then
            '    sql = String.Format("{0} " &
            '        "FROM {2}.SelectIncomeExpenseChart chart " &
            '        "{1}" &
            '        "", sql_select, sql_join, _serverDBMain)
            'Else
            '    sql = String.Format("{0} " &
            '        "FROM {2}.SelectAllChart chart " &
            '        "{1}" &
            '        "", sql_select, sql_join, _serverDBMain)
            'End If
            If txtGenLib.Checked Then
                sql = String.Format("{0} " &
                    "FROM (
                        SELECT a.account_id AS account_id,a.account_code AS account_code,a.account_name AS account_name,a.validation AS validation,a.chart_class_id AS chart_class_id
                        ,if((a.validation = '1'),'Bank/Cash',if((a.validation = '2'),'AR',if((a.validation = '3'),'AP',if((a.validation = '4'),'EWT',if((a.validation = '5'),'Final Tax',if((a.validation = '6'),'Input Vat'
	                        ,if((a.validation = '7'),'Output Vat',if((a.validation = '8'),'Prepayment',if((a.validation = '9'),'Fixed Asset',if((a.validation = '10'),'Gain or Loss',if((a.validation = '11'),'Sales Discount'
		                        ,if((a.validation = '12'),'Purchase Discount','No Validation')))))))))))) AS validation_name,b.chart_class_code AS chart_class_code,b.chart_class_name AS chart_class_name,b.chart_type AS chart_type
                        ,if((b.chart_type = 'A'),'ASSET',if((b.chart_type = 'L'),'LIABILITY',if((b.chart_type = 'C'),'CAPITAL',if((b.chart_type = 'I'),'INCOME',if((b.chart_type = 'E'),'EXPENSE',''))))) AS chart_type_name
                        ,d.chart_group_id AS chart_group_id,d.chart_group_code AS chart_group_code,d.chart_group_name AS chart_group_name 
                        ,general.general_id,general.general_code,general.general_name
                        FROM {2}.lib_erp_chart a
                        LEFT JOIN {2}.lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id
                        LEFT JOIN {2}.lib_erp_chart_group c ON c.account_id = a.account_id
                        LEFT JOIN {2}.lib_acc_chart_group d ON d.chart_group_id = c.group_id
                        LEFT JOIN (
	                        SELECT b.account_id,IFNULL(b.general_id,a.general_id) AS general_id
	                        ,IFNULL(c.general_code,d.general_code) AS general_code,IFNULL(c.general_name,d.general_name) AS general_name
	                        FROM {3}.trans_header a
	                        LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id
	                        LEFT JOIN {2}.lib_erp_general c ON c.general_id = b.general_id
	                        LEFT JOIN {2}.lib_erp_general d ON d.general_id = a.general_id
	                        GROUP BY b.account_id,IFNULL(b.general_id,a.general_id)
                        ) general ON general.account_id = a.account_id
                    ) chart " &
                    "{1}" &
                    "ORDER BY chart.account_code,chart.general_name", sql_select, sql_join, _serverDBFS, _serverDBMain)
            Else
                sql = String.Format("{0} " &
                    "FROM {2}.SelectAllChart chart " &
                    "{1}" &
                    "ORDER BY chart.account_code", sql_select, sql_join, _serverDBMain)
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
                ",a.command_code,IFNULL(a.row_type,1) AS row_type,a.account_id,a.chart_group_id,a.allocation_id,a.display_text,a.column_num " &
                ",a.group_var,a.add_sub,a.repeat_num,a.show_zero,a.indent_num,a.order_by,a.computation " &
                ",IF(a.row_type = '0',b.account_code,IF(IFNULL(a.row_type,1) = '1',c.chart_group_code,d.allocation_code)) AS chart_code " &
                ",IF(a.row_type = '0',b.account_name,IF(IFNULL(a.row_type,1) = '1',c.chart_group_name,d.allocation_name)) AS chart_name " &
                "FROM sys_fs_template_det a " &
                "LEFT JOIN {1}.lib_erp_chart b ON b.account_id = a.account_id " &
                "LEFT JOIN {1}.lib_acc_chart_group c ON c.chart_group_id = a.chart_group_id " &
                "LEFT JOIN {1}.lib_erp_allocation d ON d.allocation_id = a.allocation_id " &
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
            Try
                lblLoad.Visible = True
                If txtGenLib.Checked Then
                    GenerateExcelFSDesignGenLib(dic_all, dt_template, dt_template_det, ds.Tables("Balance"))
                Else
                    GenerateExcelFSDesign(dic_all, dt_template, dt_template_det, ds.Tables("Balance"))
                End If
                MsgBox("Report Done")
                lblLoad.Visible = False
            Catch ex As Exception
                lblLoad.Visible = False
                MsgBox(String.Format("Error Occured : {0}", ex.Message))
                MyDebugging.AddText(ex.Message)
            End Try
        Else
            MsgBox("Select at least one filter.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
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
        'end arjay
        xlWorkSheet.Cells(3, 1) = ifNull(dt_template.Rows(0).Item("title1").ToString.ToUpper, "")
        xlWorkSheet.Cells(4, 1) = ifNull(dt_template.Rows(0).Item("title2").ToString.ToUpper, "")
        xlWorkSheet.Cells(5, 1) = ifNull(dt_template.Rows(0).Item("title3").ToString.ToUpper, "")
        If txtMergeTitle.Checked Then
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, last_column)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, last_column)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, last_column)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, last_column)).MergeCells = True
        End If
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
#Region "For Computed Only(Hidden)"
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
#End Region
                    Else
                        If ifNull(item.Item("row_type"), "0").ToString = "1" Then 'Chart Group
#Region "Chart Group(Hidden)"
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
#End Region
                        ElseIf ifNull(item.Item("row_type"), "0").ToString = "2" Then 'Allocation
#Region "Allocation(Hidden)"
                            Dim allocation_id = item.Item("allocation_id").ToString
                            Dim drs_allocation = dt_balance.Select(String.Format("withAllocation = 'True'"))
                            Dim lst_allocation As New List(Of DataRow)
                            For Each dr As DataRow In drs_allocation
                                If dr("allocation_id").ToString.Split(",").Contains(allocation_id) Then
                                    lst_allocation.Add(dr)
                                End If
                            Next
                            Dim drs = lst_allocation.ToArray
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
                Else
                    If item.Item("row_type").ToString = "1" Then 'Chart Group
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
                    ElseIf item.Item("row_type").ToString = "2" Then 'Allocation
#Region "Allocation(Hidden)"
                        Dim allocation_id = item.Item("allocation_id").ToString
                        Dim drs_allocation = dt_balance.Select(String.Format("withAllocation = 'True'"))
                        Dim lst_allocation As New List(Of DataRow)
                        For Each dr As DataRow In drs_allocation
                            If dr("allocation_id").ToString.Split(",").Contains(allocation_id) Then
                                lst_allocation.Add(dr)
                            End If
                        Next
                        Dim drs = lst_allocation.ToArray

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
#Region "With Computation"
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
#End Region
                    Else
                        If ifNull(item.Item("row_type"), "0").ToString = "1" Then 'Chart Group
#Region "Chart Group"
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
#End Region
                        ElseIf ifNull(item.Item("row_type"), "0").ToString = "2" Then 'Allocation
#Region "Allocation"
                            Dim allocation_id = item.Item("allocation_id").ToString
                            Dim drs_allocation = dt_balance.Select(String.Format("withAllocation = 'True'"))
                            Dim lst_allocation As New List(Of DataRow)
                            For Each dr As DataRow In drs_allocation
                                If dr("allocation_id").ToString.Split(",").Contains(allocation_id) Then
                                    lst_allocation.Add(dr)
                                End If
                            Next
                            Dim drs = lst_allocation.ToArray

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
#End Region
                        Else 'Chart of Account
#Region "Chart of Account"
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
#End Region
                        End If
                    End If
#End Region
                Else
                    If item.Item("row_type").ToString = "1" Then 'Chart Group
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
                    ElseIf item.Item("row_type").ToString = "2" Then 'Allocation
#Region "Allocation"
                        Dim allocation_id = item.Item("allocation_id").ToString
                        Dim drs_allocation = dt_balance.Select(String.Format("withAllocation = 'True'"))
                        Dim lst_allocation As New List(Of DataRow)
                        For Each dr As DataRow In drs_allocation
                            If dr.Item("allocation_id").ToString.Split(",").Contains(allocation_id) Then
                                lst_allocation.Add(dr)
                            End If
                        Next
                        Dim drs = lst_allocation.ToArray

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
                                xlWorkSheet.Cells(current_row, 2) = account_name
                                'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num
                            Else
                                xlWorkSheet.Cells(current_row, current_column) = account_name
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num
                            End If
                            current_column += 1
                            For Each a In dic
                                If a.Value.Item("enable") Then
                                    Dim newName As String = ifNull(a.Key, "")
                                    Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
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
    Private Sub GenerateExcelFSDesignGenLib(ByVal dic As Dictionary(Of String, Dictionary(Of String, String)),
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
        If txtMergeTitle.Checked Then
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, last_column)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, last_column)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, last_column)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, last_column)).MergeCells = True
        End If
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
#Region "For Computed Only(Hidden)"
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
#End Region
                    Else
                        If ifNull(item.Item("row_type"), "0").ToString = "1" Then 'Chart Group
#Region "Chart Group(Hidden)"
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
#End Region
                        ElseIf ifNull(item.Item("row_type"), "0").ToString = "2" Then 'Allocation
#Region "Allocation(Hidden)"
                            Dim allocation_id = item.Item("allocation_id").ToString
                            Dim drs_allocation = dt_balance.Select(String.Format("withAllocation = 'True'"))
                            Dim lst_allocation As New List(Of DataRow)
                            For Each dr As DataRow In drs_allocation
                                If dr("allocation_id").ToString.Split(",").Contains(allocation_id) Then
                                    lst_allocation.Add(dr)
                                End If
                            Next
                            Dim drs = lst_allocation.ToArray
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
                Else
                    If item.Item("row_type").ToString = "1" Then 'Chart Group
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
                    ElseIf item.Item("row_type").ToString = "2" Then 'Allocation
#Region "Allocation(Hidden)"
                        Dim allocation_id = item.Item("allocation_id").ToString
                        Dim drs_allocation = dt_balance.Select(String.Format("withAllocation = 'True'"))
                        Dim lst_allocation As New List(Of DataRow)
                        For Each dr As DataRow In drs_allocation
                            If dr("allocation_id").ToString.Split(",").Contains(allocation_id) Then
                                lst_allocation.Add(dr)
                            End If
                        Next
                        Dim drs = lst_allocation.ToArray

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
#Region "With Computation"
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
#End Region
                    Else
                        If ifNull(item.Item("row_type"), "0").ToString = "1" Then 'Chart Group
#Region "Chart Group"
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
#End Region
                        ElseIf ifNull(item.Item("row_type"), "0").ToString = "2" Then 'Allocation
#Region "Allocation"
                            Dim allocation_id = item.Item("allocation_id").ToString
                            Dim drs_allocation = dt_balance.Select(String.Format("withAllocation = 'True'"))
                            Dim lst_allocation As New List(Of DataRow)
                            For Each dr As DataRow In drs_allocation
                                If dr("allocation_id").ToString.Split(",").Contains(allocation_id) Then
                                    lst_allocation.Add(dr)
                                End If
                            Next
                            Dim drs = lst_allocation.ToArray

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
#End Region
                        Else 'Chart of Account
#Region "Chart of Account"
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
#End Region
                        End If
                    End If
#End Region
                Else
                    If item.Item("row_type").ToString = "1" Then 'Chart Group
#Region "Chart Group"
                        Dim chart_group_id = item.Item("chart_group_id").ToString
                        Dim drs = dt_balance.Select(String.Format("chart_group_id = '{0}'", chart_group_id))

                        Dim group_name As String = ifNull(item.Item("group_var").ToString, "")
                        Dim newDic As New Dictionary(Of String, Decimal)
                        Dim current_account_code As String = ""
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
                                Dim general_name = dr.Item("general_name").ToString
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

                                If current_account_code <> account_code Then
                                    If withValue Then
                                        current_row += 1
                                    End If
                                End If

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
                                If withValue Then
                                    Dim firstColumn As Integer = 2
                                    If ShowAccountCode Then
                                        If current_account_code <> account_code Then
                                            xlWorkSheet.Cells(current_row - 1, 1) = "'" & account_code
                                            xlWorkSheet.Cells(current_row - 1, 2) = account_name
                                            'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row - 1, 2), xlWorkSheet.Cells(current_row - 1, 2)).IndentLevel = indent_num
                                            current_account_code = account_code
                                        End If
                                        xlWorkSheet.Cells(current_row, 2) = general_name
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num + 2
                                        firstColumn = 3
                                    Else
                                        If current_account_code <> account_code Then
                                            xlWorkSheet.Cells(current_row - 1, 1) = account_name
                                            'xlWorkSheet.Cells(current_row, 1) = strSpace & account_name
                                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row - 1, 1), xlWorkSheet.Cells(current_row - 1, 1)).IndentLevel = indent_num
                                            current_account_code = account_code
                                        End If
                                        xlWorkSheet.Cells(current_row, 1) = general_name
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num + 2
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
                    ElseIf item.Item("row_type").ToString = "2" Then 'Allocation
#Region "Allocation"
                        Dim allocation_id = item.Item("allocation_id").ToString
                        Dim drs_allocation = dt_balance.Select(String.Format("withAllocation = 'True'"))
                        Dim lst_allocation As New List(Of DataRow)
                        For Each dr As DataRow In drs_allocation
                            If dr.Item("allocation_id").ToString.Split(",").Contains(allocation_id) Then
                                lst_allocation.Add(dr)
                            End If
                        Next
                        Dim drs = lst_allocation.ToArray

                        Dim group_name As String = ifNull(item.Item("group_var").ToString, "")
                        Dim newDic As New Dictionary(Of String, Decimal)
                        Dim current_account_code As String = ""
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
                                Dim general_name = dr.Item("general_name").ToString
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

                                If current_account_code <> account_code Then
                                    If withValue Then
                                        current_row += 1
                                    End If
                                End If

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
                                If withValue Then
                                    Dim firstColumn As Integer = 2
                                    If ShowAccountCode Then
                                        If current_account_code <> account_code Then
                                            xlWorkSheet.Cells(current_row - 1, 1) = "'" & account_code
                                            xlWorkSheet.Cells(current_row - 1, 2) = account_name
                                            'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row - 1, 2), xlWorkSheet.Cells(current_row - 1, 2)).IndentLevel = indent_num
                                            current_account_code = account_code
                                        End If
                                        xlWorkSheet.Cells(current_row, 2) = general_name
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num + 2
                                        firstColumn = 3
                                    Else
                                        If current_account_code <> account_code Then
                                            xlWorkSheet.Cells(current_row - 1, 1) = account_name
                                            'xlWorkSheet.Cells(current_row, 1) = strSpace & account_name
                                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row - 1, 1), xlWorkSheet.Cells(current_row - 1, 1)).IndentLevel = indent_num
                                            current_account_code = account_code
                                        End If
                                        xlWorkSheet.Cells(current_row, 1) = general_name
                                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num + 2
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
                            Dim general_name = dr.Item("general_name").ToString
                            current_row += 1
                            If ShowAccountCode Then
                                xlWorkSheet.Cells(current_row - 1, 1) = "'" & account_code
                                xlWorkSheet.Cells(current_row - 1, 2) = account_name
                                xlWorkSheet.Cells(current_row, 2) = general_name
                                'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row - 1, 2), xlWorkSheet.Cells(current_row - 1, 2)).IndentLevel = indent_num
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num + 2
                            Else
                                xlWorkSheet.Cells(current_row - 1, current_column) = account_name
                                xlWorkSheet.Cells(current_row, current_column) = general_name
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row - 1, 1), xlWorkSheet.Cells(current_row - 1, 1)).IndentLevel = indent_num
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num + 2
                            End If
                            current_column += 1
                            For Each a In dic
                                If a.Value.Item("enable") Then
                                    Dim newName As String = ifNull(a.Key, "")
                                    Dim amount As Decimal = ifNull(dr.Item(a.Key & "_amount_based").ToString, 0)
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
                            If withValue Then
                                Dim firstColumn As Integer = 2
                                If ShowAccountCode Then
                                    xlWorkSheet.Cells(current_row - 1, 1) = "'" & account_code
                                    xlWorkSheet.Cells(current_row - 1, 2) = account_name
                                    xlWorkSheet.Cells(current_row, 2) = general_name
                                    'xlWorkSheet.Cells(current_row, 2) = strSpace & account_name
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row - 1, 2), xlWorkSheet.Cells(current_row - 1, 2)).IndentLevel = indent_num
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 2), xlWorkSheet.Cells(current_row, 2)).IndentLevel = indent_num + 2
                                    firstColumn = 3
                                Else
                                    xlWorkSheet.Cells(current_row - 1, 1) = account_name
                                    xlWorkSheet.Cells(current_row, 1) = general_name
                                    'xlWorkSheet.Cells(current_row, 1) = strSpace & account_name
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row - 1, 1), xlWorkSheet.Cells(current_row - 1, 1)).IndentLevel = indent_num
                                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).IndentLevel = indent_num + 2
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

    Private Sub new_fs_filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFilter()
    End Sub
End Class