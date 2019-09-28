Imports user_control
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.Drawing
Imports libacctng.myFunctions
Imports Microsoft.Office.Interop

Public Class DisbursementSummary
    Private strChar As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private strCharacter As String = ""
    Private journal_id As String = "4"
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
    Private Sub GetStringQuery(ByVal dic As Dictionary(Of String, String), ByVal var As String, ByVal date_from As Date, ByVal date_to As Date, ByRef sql_select_amount As String, ByRef sql_join As String, ByRef sql_condition As String)
        If CBool(dic.Item("enable")) Then
            If dic.Item("source") = "1" Or dic.Item("source") = "" Then
                sql_select_amount &= String.Format(",{0}.amount AS {0}_amount,{0}.amount_based AS {0}_amount_based", var)
                Dim sql_where As String = ""
                Select Case dic.Item("range")
                    Case "1"
                        sql_where &= String.Format("  AND DATE_FORMAT(a.trans_date,'%m-%Y') = DATE_FORMAT('{0}','%m-%Y') ",
                            date_from.ToString("yyyy-MM-dd"))
                    Case "2"
                        sql_where &= String.Format("   AND a.trans_date <= '{0}' ",
                            date_from.ToString("yyyy-MM-dd"))
                    Case "3"
                        sql_where &= String.Format("   AND a.trans_date BETWEEN '{0}-{1}-1' AND '{2}' ",
                            date_from.Year(), date_from.Month(), date_to.ToString("yyyy-MM-dd"))
                End Select
                If ifNull(dic.Item("book"), "") <> "" Then
                    sql_where &= String.Format(" AND a.book_id = '{0}'", dic.Item("book"))
                End If

                sql_join &= String.Format("LEFT JOIN(
                SELECT a.account_id,a.account_code,a.account_name,0 AS chart_class_id,'CASH' AS chart_class_code,'CASH' AS chart_class_name,a.validation
                ,a.credit - a.debit AS amount,a.credit_based - a.debit_based AS amount_based
                FROM (
	                SELECT a.trans_id,a.trans_no,a.trans_date
	                ,a.book_id,d.book_code,d.book_name
	                ,a.journal_id,f.journal_code,f.journal_name
	                ,b.jbooks_id,b.account_id,c.account_code,c.account_name,c.validation
	                ,c.chart_class_id,e.chart_class_code,e.chart_class_name
	                ,SUM(IFNULL(b.debit,0)) AS debit,SUM(IFNULL(b.credit,0)) AS credit
	                ,SUM(IFNULL(b.debit_based,0)) AS debit_based,SUM(IFNULL(b.credit_based,0)) AS credit_based
	                FROM trans_header a
	                LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id
	                LEFT JOIN {0}.lib_erp_chart c ON c.account_id = b.account_id
	                LEFT JOIN {0}.lib_erp_book d ON d.book_id = a.book_id
	                LEFT JOIN {0}.lib_acc_chart_class e ON e.chart_class_id = c.chart_class_id
	                LEFT JOIN {0}.lib_erp_journal f ON f.journal_id = a.journal_id
	                WHERE a.journal_id = 4 AND IFNULL(c.validation,0) = 1 AND UPPER(IFNULL(a.status,'')) <> 'C' AND IFNULL(b.jbooks_id,'') <> ''
	                {1}
                    GROUP BY c.account_id
	                ORDER BY c.validation
                ) a
                UNION
                SELECT a.account_id,a.account_code,a.account_name,a.chart_class_id,a.chart_class_code,a.chart_class_name,a.validation
                ,a.debit - a.credit AS amount,a.debit_based - a.credit_based AS amount_based
                FROM (
	                SELECT a.trans_id,a.trans_no,a.trans_date
	                ,a.book_id,d.book_code,d.book_name
	                ,a.journal_id,f.journal_code,f.journal_name
	                ,b.jbooks_id,b.account_id,c.account_code,c.account_name,c.validation
	                ,c.chart_class_id,e.chart_class_code,e.chart_class_name
	                ,SUM(IFNULL(b.debit,0)) AS debit,SUM(IFNULL(b.credit,0)) AS credit
	                ,SUM(IFNULL(b.debit_based,0)) AS debit_based,SUM(IFNULL(b.credit_based,0)) AS credit_based
	                FROM trans_header a
	                LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id
	                LEFT JOIN {0}.lib_erp_chart c ON c.account_id = b.account_id
	                LEFT JOIN {0}.lib_erp_book d ON d.book_id = a.book_id
	                LEFT JOIN {0}.lib_acc_chart_class e ON e.chart_class_id = c.chart_class_id
	                LEFT JOIN {0}.lib_erp_journal f ON f.journal_id = a.journal_id
	                WHERE a.journal_id = 4 AND IFNULL(c.validation,0) <> 1 AND UPPER(IFNULL(a.status,'')) <> 'C' AND IFNULL(b.jbooks_id,'') <> ''
                    {1}
	                GROUP BY c.account_id
	                ORDER BY c.validation
                ) a", _serverDBFS, sql_where)

                sql_join &= String.Format(" ) {0} ON {0}.account_id = chart.account_id ", var)
                sql_condition &= String.Format(" OR ({0}.amount <> 0 AND {0}.amount_based <> 0)", var)
            End If
        End If
    End Sub
    Private Sub InitializeFilter()
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
        Dim sql_condition As String = ""
#Region "Query String Init"

        GetStringQuery(dic_a, "a", a_date_from, a_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_b, "b", b_date_from, b_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_c, "c", c_date_from, c_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_d, "d", d_date_from, d_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_e, "e", e_date_from, e_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_f, "f", f_date_from, f_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_g, "g", g_date_from, g_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_h, "h", h_date_from, h_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_i, "i", i_date_from, i_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_j, "j", j_date_from, j_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_k, "k", k_date_from, k_date_to, sql_select_amount, sql_join, sql_condition)
        GetStringQuery(dic_l, "l", l_date_from, l_date_to, sql_select_amount, sql_join, sql_condition)
#End Region
        Dim sql_select As String = String.Format("SELECT chart.* ")
        If sql_join <> "" Then
            sql_select &= vbNewLine & String.Format("{0} ", sql_select_amount)
            sql_select &= vbNewLine & String.Format("{0} ", sql_select_amount_based)

            sql = String.Format("{0} " &
                    "FROM {2}.SelectAllChart chart " &
                    "{1}
                    WHERE {3}" &
                    "", sql_select, sql_join, _serverDBMain, sql_condition.Substring(4))

            sql &= " ORDER BY chart_class_id"

            Dim sql_company As String = String.Format("SELECT a.company_id,a.company_code,a.company_name " &
                ",a.address1 AS address,a.tin " &
                "FROM lib_erp_company a " &
                "WHERE a.company_id = '{0}' " &
                "", main.Sys_Default.Rows(0).Item("company_id"))


            Dim dt_company As DataTable = FsQuery(sql_company) ' Dito mo kunin ung company bro
            Dim dt As DataTable = Query(sql)

            ds.Tables("Balance").Clear()
            ds.Tables("Company").Clear()

            For Each dr As DataRow In dt.Rows
                ds.Tables("Balance").ImportRow(dr)
            Next
            For Each dr As DataRow In dt_company.Rows
                ds.Tables("Company").ImportRow(dr)
            Next
            lblLoad.Visible = True
#Region "Excel File"
            Dim class_code As String = ""
            Dim validation As Integer = 1
            Dim final_cash_row As Integer = 0
            Dim final_cash As Boolean = False
            Dim breakdown_side As Boolean = False
            Dim last_column As Integer = 2

            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet


            xlApp = New Excel.Application
            xlApp.DisplayAlerts = False
            xlWorkBook = xlApp.Workbooks.Add


            xlWorkSheet = xlWorkBook.Worksheets(1)
            xlWorkSheet.Cells(1, 1).ColumnWidth = 25
            xlWorkSheet.Cells(1, 2).ColumnWidth = 50

            xlWorkSheet.Cells(1, 1) = ds.Tables("Company").Rows(0)("company_name").ToString().ToUpper()
            xlWorkSheet.Cells(2, 1) = "SUMMARY OF DISBURSEMENTS"

            Dim current_row As Integer = 5
            If enable_a.Checked = True Then ' column 3
                xlWorkSheet.Cells(4, 3) = label_from_a.Text
                xlWorkSheet.Cells(5, 3) = "'" & label_to_a.Text
                xlWorkSheet.Cells(1, 3).ColumnWidth = 25
                last_column += 1
            End If
            If enable_b.Checked = True Then ' column 4
                xlWorkSheet.Cells(4, 4) = label_from_b.Text
                xlWorkSheet.Cells(5, 4) = "'" & label_to_b.Text
                xlWorkSheet.Cells(1, 4).ColumnWidth = 25
                last_column += 1
            End If
            If enable_c.Checked = True Then ' column 5
                xlWorkSheet.Cells(4, 5) = label_from_c.Text
                xlWorkSheet.Cells(5, 5) = "'" & label_to_c.Text
                xlWorkSheet.Cells(1, 5).ColumnWidth = 25
                last_column += 1
            End If
            If enable_d.Checked = True Then ' column 6
                xlWorkSheet.Cells(4, 6) = label_from_d.Text
                xlWorkSheet.Cells(5, 6) = "'" & label_to_d.Text
                xlWorkSheet.Cells(1, 6).ColumnWidth = 25
                last_column += 1
            End If
            If enable_e.Checked = True Then ' column 7
                xlWorkSheet.Cells(4, 7) = label_from_e.Text
                xlWorkSheet.Cells(5, 7) = "'" & label_to_e.Text
                xlWorkSheet.Cells(1, 7).ColumnWidth = 25
                last_column += 1
            End If
            If enable_f.Checked = True Then ' column 8
                xlWorkSheet.Cells(4, 8) = label_from_f.Text
                xlWorkSheet.Cells(5, 8) = "'" & label_to_f.Text
                xlWorkSheet.Cells(1, 8).ColumnWidth = 25
                last_column += 1
            End If
            If enable_g.Checked = True Then ' column 9
                xlWorkSheet.Cells(4, 9) = label_from_g.Text
                xlWorkSheet.Cells(5, 9) = "'" & label_to_g.Text
                xlWorkSheet.Cells(1, 9).ColumnWidth = 25
                last_column += 1
            End If
            If enable_h.Checked = True Then ' column 10
                xlWorkSheet.Cells(4, 10) = label_from_h.Text
                xlWorkSheet.Cells(5, 10) = "'" & label_to_h.Text
                xlWorkSheet.Cells(1, 10).ColumnWidth = 25
                last_column += 1
            End If
            If enable_i.Checked = True Then ' column 11
                xlWorkSheet.Cells(4, 11) = label_from_i.Text
                xlWorkSheet.Cells(5, 11) = "'" & label_to_i.Text
                xlWorkSheet.Cells(1, 11).ColumnWidth = 25
                last_column += 1
            End If
            If enable_j.Checked = True Then ' column 12
                xlWorkSheet.Cells(4, 12) = label_from_j.Text
                xlWorkSheet.Cells(5, 12) = "'" & label_to_j.Text
                xlWorkSheet.Cells(1, 12).ColumnWidth = 25
                last_column += 1
            End If
            If enable_k.Checked = True Then ' column 13
                xlWorkSheet.Cells(4, 13) = label_from_k.Text
                xlWorkSheet.Cells(5, 13) = "'" & label_to_k.Text
                xlWorkSheet.Cells(1, 13).ColumnWidth = 25
                last_column += 1
            End If
            If enable_l.Checked = True Then ' column 14
                xlWorkSheet.Cells(4, 14) = label_from_l.Text
                xlWorkSheet.Cells(5, 14) = "'" & label_to_l.Text
                xlWorkSheet.Cells(1, 14).ColumnWidth = 25
                last_column += 1
            End If
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, last_column)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, last_column)).MergeCells = True
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(2, last_column)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(2, last_column)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(2, last_column)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 3), xlWorkSheet.Cells(5, last_column)).Font.Bold = True

            Dim title As String = "Disbursement per Bank".ToUpper()
            Dim a_cash_total As Decimal = 0
            Dim b_cash_total As Decimal = 0
            Dim c_cash_total As Decimal = 0
            Dim d_cash_total As Decimal = 0
            Dim e_cash_total As Decimal = 0
            Dim f_cash_total As Decimal = 0
            Dim g_cash_total As Decimal = 0
            Dim h_cash_total As Decimal = 0
            Dim i_cash_total As Decimal = 0
            Dim j_cash_total As Decimal = 0
            Dim k_cash_total As Decimal = 0
            Dim l_cash_total As Decimal = 0
            Dim a_breakdown_total As Decimal = 0
            Dim b_breakdown_total As Decimal = 0
            Dim c_breakdown_total As Decimal = 0
            Dim d_breakdown_total As Decimal = 0
            Dim e_breakdown_total As Decimal = 0
            Dim f_breakdown_total As Decimal = 0
            Dim g_breakdown_total As Decimal = 0
            Dim h_breakdown_total As Decimal = 0
            Dim i_breakdown_total As Decimal = 0
            Dim j_breakdown_total As Decimal = 0
            Dim k_breakdown_total As Decimal = 0
            Dim l_breakdown_total As Decimal = 0
            Dim a_total As Decimal = 0
            Dim b_total As Decimal = 0
            Dim c_total As Decimal = 0
            Dim d_total As Decimal = 0
            Dim e_total As Decimal = 0
            Dim f_total As Decimal = 0
            Dim g_total As Decimal = 0
            Dim h_total As Decimal = 0
            Dim i_total As Decimal = 0
            Dim j_total As Decimal = 0
            Dim k_total As Decimal = 0
            Dim l_total As Decimal = 0
            Dim chart_class_name As String = ""
            xlWorkSheet.Cells(current_row, 1) = title
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).Font.Bold = True
            current_row += 1

            For Each row As DataRow In ds.Tables("Balance").Rows
                Dim current_validation As Integer = Val(row("validation"))
                Dim current_class_code As String = row("chart_class_code")
                chart_class_name = row("chart_class_name")
                Dim account_code As String = row("account_code")
                Dim account_name As String = row("account_name")
                Dim a_amount As Decimal = ifNull(row("a_amount"), 0)
                Dim a_amount_based As Decimal = ifNull(row("a_amount_based"), 0)
                Dim b_amount As Decimal = ifNull(row("b_amount"), 0)
                Dim b_amount_based As Decimal = ifNull(row("b_amount_based"), 0)
                Dim c_amount As Decimal = ifNull(row("c_amount"), 0)
                Dim c_amount_based As Decimal = ifNull(row("c_amount_based"), 0)
                Dim d_amount As Decimal = ifNull(row("d_amount"), 0)
                Dim d_amount_based As Decimal = ifNull(row("d_amount_based"), 0)
                Dim e_amount As Decimal = ifNull(row("e_amount"), 0)
                Dim e_amount_based As Decimal = ifNull(row("e_amount_based"), 0)
                Dim f_amount As Decimal = ifNull(row("f_amount"), 0)
                Dim f_amount_based As Decimal = ifNull(row("f_amount_based"), 0)
                Dim g_amount As Decimal = ifNull(row("g_amount"), 0)
                Dim g_amount_based As Decimal = ifNull(row("g_amount_based"), 0)
                Dim h_amount As Decimal = ifNull(row("h_amount"), 0)
                Dim h_amount_based As Decimal = ifNull(row("h_amount_based"), 0)
                Dim i_amount As Decimal = ifNull(row("i_amount"), 0)
                Dim i_amount_based As Decimal = ifNull(row("i_amount_based"), 0)
                Dim j_amount As Decimal = ifNull(row("j_amount"), 0)
                Dim j_amount_based As Decimal = ifNull(row("j_amount_based"), 0)
                Dim k_amount As Decimal = ifNull(row("k_amount"), 0)
                Dim k_amount_based As Decimal = ifNull(row("k_amount_based"), 0)
                Dim l_amount As Decimal = ifNull(row("l_amount"), 0)
                Dim l_amount_based As Decimal = ifNull(row("l_amount_based"), 0)

                If current_validation = validation Then
                    xlWorkSheet.Cells(current_row, 1) = "'" & account_code
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Cells(current_row, 2) = account_name
                    If enable_a.Checked = True Then ' column 3
                        xlWorkSheet.Cells(current_row, 3) = a_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 3)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_b.Checked = True Then ' column 4
                        xlWorkSheet.Cells(current_row, 4) = b_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_c.Checked = True Then ' column 5
                        xlWorkSheet.Cells(current_row, 5) = c_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 5)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_d.Checked = True Then ' column 6
                        xlWorkSheet.Cells(current_row, 6) = d_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 6), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_e.Checked = True Then ' column 7
                        xlWorkSheet.Cells(current_row, 7) = e_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 7), xlWorkSheet.Cells(current_row, 7)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_f.Checked = True Then ' column 8
                        xlWorkSheet.Cells(current_row, 8) = f_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, 8)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_g.Checked = True Then ' column 9
                        xlWorkSheet.Cells(current_row, 9) = g_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 9), xlWorkSheet.Cells(current_row, 9)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_h.Checked = True Then ' column 10
                        xlWorkSheet.Cells(current_row, 10) = h_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 10), xlWorkSheet.Cells(current_row, 10)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_i.Checked = True Then ' column 11
                        xlWorkSheet.Cells(current_row, 3) = i_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 11), xlWorkSheet.Cells(current_row, 11)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_j.Checked = True Then ' column 12
                        xlWorkSheet.Cells(current_row, 3) = j_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 12), xlWorkSheet.Cells(current_row, 12)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_k.Checked = True Then ' column 13
                        xlWorkSheet.Cells(current_row, 3) = k_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 13), xlWorkSheet.Cells(current_row, 13)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_l.Checked = True Then ' column 14
                        xlWorkSheet.Cells(current_row, 3) = l_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 14), xlWorkSheet.Cells(current_row, 14)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    current_row += 1
                    a_cash_total += a_amount_based
                    b_cash_total += b_amount_based
                    c_cash_total += c_amount_based
                    d_cash_total += d_amount_based
                    e_cash_total += e_amount_based
                    f_cash_total += f_amount_based
                    g_cash_total += g_amount_based
                    h_cash_total += h_amount_based
                    i_cash_total += i_amount_based
                    j_cash_total += j_amount_based
                    k_cash_total += k_amount_based
                    l_cash_total += l_amount_based
                    final_cash_row = current_row
                End If
            Next

            xlWorkSheet.Cells(current_row, 1) = "BREAKDOWN"
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).Font.Bold = True

            'Breakdown Part
            For Each row As DataRow In ds.Tables("Balance").Rows
                Dim current_validation As Integer = Val(row("validation"))
                Dim current_class_code As String = row("chart_class_code")

                Dim account_code As String = row("account_code")
                Dim account_name As String = row("account_name")
                Dim a_amount As Decimal = ifNull(row("a_amount"), 0)
                Dim a_amount_based As Decimal = ifNull(row("a_amount_based"), 0)
                Dim b_amount As Decimal = ifNull(row("b_amount"), 0)
                Dim b_amount_based As Decimal = ifNull(row("b_amount_based"), 0)
                Dim c_amount As Decimal = ifNull(row("c_amount"), 0)
                Dim c_amount_based As Decimal = ifNull(row("c_amount_based"), 0)
                Dim d_amount As Decimal = ifNull(row("d_amount"), 0)
                Dim d_amount_based As Decimal = ifNull(row("d_amount_based"), 0)
                Dim e_amount As Decimal = ifNull(row("e_amount"), 0)
                Dim e_amount_based As Decimal = ifNull(row("e_amount_based"), 0)
                Dim f_amount As Decimal = ifNull(row("f_amount"), 0)
                Dim f_amount_based As Decimal = ifNull(row("f_amount_based"), 0)
                Dim g_amount As Decimal = ifNull(row("g_amount"), 0)
                Dim g_amount_based As Decimal = ifNull(row("g_amount_based"), 0)
                Dim h_amount As Decimal = ifNull(row("h_amount"), 0)
                Dim h_amount_based As Decimal = ifNull(row("h_amount_based"), 0)
                Dim i_amount As Decimal = ifNull(row("i_amount"), 0)
                Dim i_amount_based As Decimal = ifNull(row("i_amount_based"), 0)
                Dim j_amount As Decimal = ifNull(row("j_amount"), 0)
                Dim j_amount_based As Decimal = ifNull(row("j_amount_based"), 0)
                Dim k_amount As Decimal = ifNull(row("k_amount"), 0)
                Dim k_amount_based As Decimal = ifNull(row("k_amount_based"), 0)
                Dim l_amount As Decimal = ifNull(row("l_amount"), 0)
                Dim l_amount_based As Decimal = ifNull(row("l_amount_based"), 0)
                title = chart_class_name

                If current_validation <> 1 Then
                    If class_code <> current_class_code Then
                        If breakdown_side Then
                            'chart_class_name = row("chart_class_name")
                            xlWorkSheet.Cells(current_row, 1) = "TOTAL " & title & ":"
                            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).Font.Bold = True
                            If enable_a.Checked = True Then ' column 3
                                xlWorkSheet.Cells(current_row, 3) = a_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 3)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                a_total += a_breakdown_total
                                a_breakdown_total = 0
                            End If
                            If enable_b.Checked = True Then ' column 4
                                xlWorkSheet.Cells(current_row, 4) = b_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                b_total += b_breakdown_total
                                b_breakdown_total = 0
                            End If
                            If enable_c.Checked = True Then ' column 5
                                xlWorkSheet.Cells(current_row, 5) = c_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 5)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                c_total += c_breakdown_total
                                c_breakdown_total = 0
                            End If
                            If enable_d.Checked = True Then ' column 6
                                xlWorkSheet.Cells(current_row, 6) = d_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 6), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                d_total += d_breakdown_total
                                d_breakdown_total = 0
                            End If
                            If enable_e.Checked = True Then ' column 7
                                xlWorkSheet.Cells(current_row, 7) = e_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 7), xlWorkSheet.Cells(current_row, 7)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                e_total += e_breakdown_total
                                e_breakdown_total = 0
                                e_breakdown_total = 0
                            End If
                            If enable_f.Checked = True Then ' column 8
                                xlWorkSheet.Cells(current_row, 8) = f_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, 8)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                f_total += f_breakdown_total
                                f_breakdown_total = 0
                            End If
                            If enable_g.Checked = True Then ' column 9
                                xlWorkSheet.Cells(current_row, 9) = g_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 9), xlWorkSheet.Cells(current_row, 9)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                g_total += g_breakdown_total
                                g_breakdown_total = 0
                            End If
                            If enable_h.Checked = True Then ' column 10
                                xlWorkSheet.Cells(current_row, 10) = h_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 10), xlWorkSheet.Cells(current_row, 10)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                h_total += h_breakdown_total
                                h_breakdown_total = 0
                            End If
                            If enable_i.Checked = True Then ' column 11
                                xlWorkSheet.Cells(current_row, 11) = i_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 11), xlWorkSheet.Cells(current_row, 11)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                i_total += i_breakdown_total
                                i_breakdown_total = 0
                            End If
                            If enable_j.Checked = True Then ' column 12
                                xlWorkSheet.Cells(current_row, 12) = j_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 12), xlWorkSheet.Cells(current_row, 12)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                j_total += j_breakdown_total
                                j_breakdown_total = 0
                            End If
                            If enable_k.Checked = True Then ' column 13
                                xlWorkSheet.Cells(current_row, 13) = k_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 13), xlWorkSheet.Cells(current_row, 13)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                k_total += k_breakdown_total
                                k_breakdown_total = 0
                            End If
                            If enable_l.Checked = True Then ' column 14
                                xlWorkSheet.Cells(current_row, 14) = l_breakdown_total
                                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 14), xlWorkSheet.Cells(current_row, 14)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                                l_total += l_breakdown_total
                                l_breakdown_total = 0
                            End If
                        End If
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                        End With
                        With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                        End With
                        class_code = current_class_code
                        current_row += 2
                        chart_class_name = row("chart_class_name")
                        xlWorkSheet.Cells(current_row, 1) = chart_class_name
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).Font.Bold = True
                        current_row += 1

                    End If
                    xlWorkSheet.Cells(current_row, 1) = "'" & account_code
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 1)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    xlWorkSheet.Cells(current_row, 2) = account_name
                    If enable_a.Checked = True Then ' column 3
                        xlWorkSheet.Cells(current_row, 3) = a_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 3)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_b.Checked = True Then ' column 4
                        xlWorkSheet.Cells(current_row, 4) = b_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_c.Checked = True Then ' column 5
                        xlWorkSheet.Cells(current_row, 5) = c_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 5)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_d.Checked = True Then ' column 6
                        xlWorkSheet.Cells(current_row, 6) = d_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 6), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_e.Checked = True Then ' column 7
                        xlWorkSheet.Cells(current_row, 7) = e_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 7), xlWorkSheet.Cells(current_row, 7)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_f.Checked = True Then ' column 8
                        xlWorkSheet.Cells(current_row, 8) = f_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, 8)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_g.Checked = True Then ' column 9
                        xlWorkSheet.Cells(current_row, 9) = g_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 9), xlWorkSheet.Cells(current_row, 9)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_h.Checked = True Then ' column 10
                        xlWorkSheet.Cells(current_row, 10) = h_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 10), xlWorkSheet.Cells(current_row, 10)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_i.Checked = True Then ' column 11
                        xlWorkSheet.Cells(current_row, 11) = i_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 11), xlWorkSheet.Cells(current_row, 11)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_j.Checked = True Then ' column 12
                        xlWorkSheet.Cells(current_row, 12) = j_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 12), xlWorkSheet.Cells(current_row, 12)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_k.Checked = True Then ' column 13
                        xlWorkSheet.Cells(current_row, 13) = k_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 13), xlWorkSheet.Cells(current_row, 13)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If
                    If enable_l.Checked = True Then ' column 14
                        xlWorkSheet.Cells(current_row, 14) = l_amount_based
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 14), xlWorkSheet.Cells(current_row, 14)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    End If

                    current_row += 1
                    a_breakdown_total += a_amount_based
                    b_breakdown_total += b_amount_based
                    c_breakdown_total += c_amount_based
                    d_breakdown_total += d_amount_based
                    e_breakdown_total += e_amount_based
                    f_breakdown_total += f_amount_based
                    g_breakdown_total += g_amount_based
                    h_breakdown_total += h_amount_based
                    i_breakdown_total += i_amount_based
                    j_breakdown_total += j_amount_based
                    k_breakdown_total += k_amount_based
                    l_breakdown_total += l_amount_based
                    breakdown_side = True
                End If
            Next

            If breakdown_side Then
                xlWorkSheet.Cells(current_row, 1) = "Total " & chart_class_name & ":"
                If enable_a.Checked = True Then ' column 3
                    xlWorkSheet.Cells(current_row, 3) = a_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 3)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    a_total += a_breakdown_total
                    a_breakdown_total = 0
                End If
                If enable_b.Checked = True Then ' column 4
                    xlWorkSheet.Cells(current_row, 4) = b_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    b_total += b_breakdown_total
                    b_breakdown_total = 0
                End If
                If enable_c.Checked = True Then ' column 5
                    xlWorkSheet.Cells(current_row, 5) = c_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 5)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    c_total += c_breakdown_total
                    c_breakdown_total = 0
                End If
                If enable_d.Checked = True Then ' column 6
                    xlWorkSheet.Cells(current_row, 6) = d_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 6), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    d_total += d_breakdown_total
                    d_breakdown_total = 0
                End If
                If enable_e.Checked = True Then ' column 7
                    xlWorkSheet.Cells(current_row, 7) = e_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 7), xlWorkSheet.Cells(current_row, 7)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    e_total += e_breakdown_total
                    e_breakdown_total = 0
                    e_breakdown_total = 0
                End If
                If enable_f.Checked = True Then ' column 8
                    xlWorkSheet.Cells(current_row, 8) = f_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, 8)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    f_total += f_breakdown_total
                    f_breakdown_total = 0
                End If
                If enable_g.Checked = True Then ' column 9
                    xlWorkSheet.Cells(current_row, 9) = g_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 9), xlWorkSheet.Cells(current_row, 9)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    g_total += g_breakdown_total
                    g_breakdown_total = 0
                End If
                If enable_h.Checked = True Then ' column 10
                    xlWorkSheet.Cells(current_row, 10) = h_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 10), xlWorkSheet.Cells(current_row, 10)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    h_total += h_breakdown_total
                    h_breakdown_total = 0
                End If
                If enable_i.Checked = True Then ' column 11
                    xlWorkSheet.Cells(current_row, 11) = i_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 11), xlWorkSheet.Cells(current_row, 11)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    i_total += i_breakdown_total
                    i_breakdown_total = 0
                End If
                If enable_j.Checked = True Then ' column 12
                    xlWorkSheet.Cells(current_row, 12) = j_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 12), xlWorkSheet.Cells(current_row, 12)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    j_total += j_breakdown_total
                    j_breakdown_total = 0
                End If
                If enable_k.Checked = True Then ' column 13
                    xlWorkSheet.Cells(current_row, 13) = k_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 13), xlWorkSheet.Cells(current_row, 13)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    k_total += k_breakdown_total
                    k_breakdown_total = 0
                End If
                If enable_l.Checked = True Then ' column 14
                    xlWorkSheet.Cells(current_row, 14) = l_breakdown_total
                    xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 14), xlWorkSheet.Cells(current_row, 14)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                    l_total += l_breakdown_total
                    l_breakdown_total = 0
                End If
            End If
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
            End With
            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
            End With
            current_row += 2
            xlWorkSheet.Cells(final_cash_row, 1) = "Total Disbursement:".ToUpper()
            xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 1), xlWorkSheet.Cells(final_cash_row, last_column)).Font.Bold = True
            With xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 3), xlWorkSheet.Cells(final_cash_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
            End With
            With xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 3), xlWorkSheet.Cells(final_cash_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeTop)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
            End With
            xlWorkSheet.Cells(current_row, 1) = "Total Breakdown:".ToUpper()
            If enable_a.Checked = True Then ' column 3
                xlWorkSheet.Cells(final_cash_row, 3) = a_cash_total
                xlWorkSheet.Cells(current_row, 3) = a_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 3), xlWorkSheet.Cells(final_cash_row, 3)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 3)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_b.Checked = True Then ' column 4
                xlWorkSheet.Cells(final_cash_row, 4) = b_cash_total
                xlWorkSheet.Cells(current_row, 4) = b_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 4), xlWorkSheet.Cells(final_cash_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 4)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_c.Checked = True Then ' column 5
                xlWorkSheet.Cells(final_cash_row, 5) = c_cash_total
                xlWorkSheet.Cells(current_row, 5) = c_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 5), xlWorkSheet.Cells(final_cash_row, 5)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 5), xlWorkSheet.Cells(current_row, 5)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_d.Checked = True Then ' column 6
                xlWorkSheet.Cells(final_cash_row, 6) = d_cash_total
                xlWorkSheet.Cells(current_row, 6) = d_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 6), xlWorkSheet.Cells(final_cash_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 6), xlWorkSheet.Cells(current_row, 6)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_e.Checked = True Then ' column 7
                xlWorkSheet.Cells(final_cash_row, 7) = e_cash_total
                xlWorkSheet.Cells(current_row, 7) = e_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 7), xlWorkSheet.Cells(final_cash_row, 7)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 7), xlWorkSheet.Cells(current_row, 7)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_f.Checked = True Then ' column 8
                xlWorkSheet.Cells(final_cash_row, 8) = f_cash_total
                xlWorkSheet.Cells(current_row, 8) = f_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 8), xlWorkSheet.Cells(final_cash_row, 8)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 8), xlWorkSheet.Cells(current_row, 8)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_g.Checked = True Then ' column 9
                xlWorkSheet.Cells(final_cash_row, 9) = g_cash_total
                xlWorkSheet.Cells(current_row, 9) = h_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 9), xlWorkSheet.Cells(final_cash_row, 9)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 9), xlWorkSheet.Cells(current_row, 9)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_h.Checked = True Then ' column 10
                xlWorkSheet.Cells(final_cash_row, 10) = h_cash_total
                xlWorkSheet.Cells(current_row, 10) = i_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 10), xlWorkSheet.Cells(final_cash_row, 10)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 10), xlWorkSheet.Cells(current_row, 10)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_i.Checked = True Then ' column 11
                xlWorkSheet.Cells(final_cash_row, 11) = i_cash_total
                xlWorkSheet.Cells(current_row, 11) = i_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 11), xlWorkSheet.Cells(final_cash_row, 11)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 11), xlWorkSheet.Cells(current_row, 11)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_j.Checked = True Then ' column 12
                xlWorkSheet.Cells(final_cash_row, 12) = j_cash_total
                xlWorkSheet.Cells(current_row, 12) = h_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 12), xlWorkSheet.Cells(final_cash_row, 12)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 12), xlWorkSheet.Cells(current_row, 12)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_k.Checked = True Then ' column 13
                xlWorkSheet.Cells(final_cash_row, 13) = k_cash_total
                xlWorkSheet.Cells(current_row, 14) = k_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 13), xlWorkSheet.Cells(final_cash_row, 13)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 13), xlWorkSheet.Cells(current_row, 13)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            If enable_l.Checked = True Then ' column 14
                xlWorkSheet.Cells(final_cash_row, 14) = l_cash_total
                xlWorkSheet.Cells(current_row, 15) = l_total
                xlWorkSheet.Range(xlWorkSheet.Cells(final_cash_row, 14), xlWorkSheet.Cells(final_cash_row, 14)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 14), xlWorkSheet.Cells(current_row, 14)).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
            End If
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, last_column)).Font.Bold = True
            With xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, last_column)).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlDouble
                .Weight = Excel.XlBorderWeight.xlThick
            End With
            xlApp.Visible = True
#End Region
            Try

                'GenerateExcelFSDesign(dic_all, dt_template, dt_template_det, ds.Tables("Balance"))
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


    Private Sub DisbursementSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFilter()
    End Sub
End Class