Imports System.Windows.Forms.DataVisualization.Charting
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class Dashboard
    Private Sub loadSales()
        dgMain.AutoGenerateColumns = False
        Dim sql = String.Format("select month(trans_date) as month, monthname(trans_date) as month_name, sum(a.credit_based) - sum(a.debit_based) as amount " & _
" from trans_jbooks a " & _
" left join {1}.lib_erp_chart b on b.account_id = a.account_id " & _
" left join {1}.lib_acc_chart_class c on c.chart_class_id = b.chart_class_id " & _
" LEFT join trans_header d on d.trans_id = a.trans_id " & _
" where c.chart_type = 'I' and year(d.trans_date)='{0}' " & _
" group by month(trans_date) " & _
" order by trans_date", txt_year.Value, _serverDBFS)
        Dim dt As DataTable = Query(sql)
        ds.Tables("sales_month").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("sales_month").ImportRow(row)
        Next
        ds.Tables("sales_day").Clear()
        dgMain.DataSource = ds.Tables("sales_month")
        If ds.Tables("sales_month").Rows.Count > 0 Then
            dgMain_SelectionChanged(Nothing, Nothing)
        End If
    End Sub
    Private Sub loadSales2(ByVal month As String, ByVal year As String)
        dgMain2.AutoGenerateColumns = False
        Dim sql = String.Format("select trans_date, sum(a.credit_based) - sum(a.debit_based) as amount " & _
" from trans_jbooks a " & _
" left join {2}.lib_erp_chart b on b.account_id = a.account_id " & _
" left join {2}.lib_acc_chart_class c on c.chart_class_id = b.chart_class_id " & _
" LEFT join trans_header d on d.trans_id = a.trans_id " & _
" where c.chart_type = 'I' and month(trans_date)='{0}' and year(d.trans_date)='{1}' " & _
" group by a.trans_id " & _
" order by year(trans_date) desc, month(trans_date) desc, day(trans_date) desc, amount desc", month, year, _serverDBFS)
        Dim dt As DataTable = Query(sql)
        ds.Tables("sales_day").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("sales_day").ImportRow(row)
        Next
        dgMain2.DataSource = ds.Tables("sales_day")
    End Sub
    Private Sub loadReceivable()
        dgMain3.AutoGenerateColumns = False
        Dim sql = String.Format("SELECT SUM(b.debit - IFNULL(d.credit,0)) AS amount " & _
" ,e.general_name " & _
" FROM trans_header a " & _
" LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
" LEFT JOIN {0}.lib_erp_chart c ON c.account_id = b.account_id " & _
" LEFT JOIN ( " & _
"   SELECT a.ref_jbooks_id " & _
"   ,SUM(credit) AS credit " & _
"   FROM trans_jbooks a " & _
"   GROUP BY a.ref_jbooks_id  ) d ON d.ref_jbooks_id = b.jbooks_id " & _
" LEFT JOIN {0}.lib_erp_general e ON e.general_id = b.general_id " & _
" LEFT JOIN ( " & _
"  SELECT SUM(b.debit - IFNULL(d.credit,0)) AS amount " & _
"  ,b.general_id,e.general_name " & _
" FROM trans_header a " & _
" LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
" LEFT JOIN {0}.lib_erp_chart c ON c.account_id = b.account_id " & _
" LEFT JOIN ( " & _
"   SELECT a.ref_jbooks_id " & _
"   ,SUM(credit) AS credit " & _
"   FROM trans_jbooks a " & _
"   GROUP BY a.ref_jbooks_id  ) d ON d.ref_jbooks_id = b.jbooks_id " & _
" LEFT JOIN {0}.lib_erp_general e ON e.general_id = b.general_id " & _
" WHERE c.validation = 2 AND b.general_id IS NOT NULL AND a.journal_id = 8 " & _
" GROUP BY b.general_id " & _
" ORDER BY amount DESC ) f on f.general_id = b.general_id " & _
" WHERE c.validation = 2 AND b.general_id IS NOT NULL AND year(trans_date)='{1}' " & _
" GROUP BY b.general_id " & _
" ORDER BY amount DESC", _serverDBFS, txt_year.Value)
        Dim dt As DataTable = Query(sql)
        ds.Tables("accounts_receivable").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("accounts_receivable").ImportRow(row)
        Next
        dgMain3.DataSource = ds.Tables("accounts_receivable")
    End Sub
    Private Sub loadAccounts()
        dgMain4.AutoGenerateColumns = False
        Dim sql = String.Format("select a.account_code, a.account_name " & _
" ,if(a.validation = 1, a.debit - a.credit " & _
" ,if(a.validation = 2, a.debit - a.credit " & _
" ,if(a.validation = 3, a.credit - a.debit " & _
" ,if(a.validation = 4, a.credit - a.debit " & _
" ,if(a.validation = 5, a.credit - a.debit " & _
" ,if(a.validation = 6, a.debit - a.credit " & _
" ,if(a.validation = 7, a.credit - a.debit " & _
" ,if(a.validation = 8, a.debit - a.credit " & _
" ,if(a.validation = 9, a.debit - a.credit " & _
" ,if(a.validation = 10, a.debit - a.credit, a.debit_based - a.credit_based)))))))))) AS amount " & _
" from ( " & _
"   select a.trans_id, a.trans_date, b.jbooks_id " & _
"   ,sum(b.debit) as debit " & _
"   ,sum(b.credit) as credit " & _
"   ,sum(b.debit_based) as debit_based " & _
"   ,sum(b.credit_based) as credit_based " & _
"   ,c.account_id, c.account_code, c.account_name, c.validation " & _
"   from trans_header a " & _
" left join {0}.trans_jbooks b on b.trans_id = a.trans_id " & _
" left join {1}.lib_erp_chart c on c.account_id = b.account_id " & _
" where year(a.trans_date)='{2}' and b.jbooks_id is not null " & _
" group by c.account_id  ) a " & _
" order by a.account_code", _serverDBMain, _serverDBFS, txt_year.Value)
        Dim dt As DataTable = Query(Sql)
        ds.Tables("chart_accounts").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("chart_accounts").ImportRow(row)
        Next
        dgMain4.DataSource = ds.Tables("chart_accounts")
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        dgMain.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen

        Dim selectedrows = dgMain.SelectedRows
        If selectedrows.Count > 0 Then
            Dim selectedrow = selectedrows(0)
            dgMain2.DataSource = Nothing
            Dim month = selectedrow.Cells("month").Value
            loadSales2(month, txt_year.Value)
        End If
    End Sub
    Private Sub dgMain2_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain2.SelectionChanged
        dgMain2.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen
    End Sub
    Private Sub dgMain3_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain3.SelectionChanged
        dgMain3.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen
    End Sub
    Private Sub dgMain4_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain4.SelectionChanged
        dgMain4.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen
    End Sub
    Private Sub Chart1_Customize(sender As Object, e As EventArgs) Handles Chart1.Customize
        Chart1.ChartAreas(0).AxisY.LabelStyle.Enabled = False
    End Sub
    Private Sub loadGrid()
        With Chart1
            .Series.Clear()
            .Series.Add("Sales")
            .Series("Sales").Points.Clear()
            Dim sql = String.Format("select month(trans_date) as month, sum(a.credit_based) - sum(a.debit_based) as amount " & _
" from trans_jbooks a " & _
" left join {1}.lib_erp_chart b on b.account_id = a.account_id " & _
" left join {1}.lib_acc_chart_class c on c.chart_class_id = b.chart_class_id " & _
" left join trans_header d on d.trans_id = a.trans_id " & _
" where c.chart_type = 'I' and year(d.trans_date)='{0}' " & _
" group by monthname(trans_date) order by month(trans_date)", txt_year.Value, _serverDBFS)
            Dim dt As DataTable = Query(sql)
            For x = 1 To 12
                Dim amount As Decimal = 0
                Dim amount_lbl As String = 0
                Dim rows = dt.Select("month = '" & x & "'")
                Dim isneg As Boolean = False
                If rows.Count > 0 Then
                    amount = rows(0).Item("amount")

                    If amount < 0 Then
                        isneg = True
                        amount *= -1
                    End If

                    If (amount <= 999) Then
                        amount_lbl = Trim(Str(amount))
                    ElseIf (amount >= 1000000000 And amount <= 999999999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}B", (amount / 1000000000))
                    ElseIf (amount >= 1000000 And amount <= 999999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}M", (amount / 1000000))
                    ElseIf (amount >= 1000 And amount <= 999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}K", (amount / 1000))
                    End If

                    If isneg Then
                        amount_lbl = "(" & amount_lbl & ")"
                    End If

                End If
                .Series("Sales").Points.AddXY(MonthName(x), amount)
                .Series("Sales").Points(x - 1).Label = amount_lbl
            Next
            Chart1.Series("Sales").Points(0).Color = System.Drawing.Color.FromArgb(131, 227, 32)
            Chart1.Series("Sales").Points(1).Color = System.Drawing.Color.FromArgb(31, 217, 90)
            Chart1.Series("Sales").Points(2).Color = System.Drawing.Color.FromArgb(31, 154, 217)
            Chart1.Series("Sales").Points(3).Color = System.Drawing.Color.FromArgb(31, 79, 217)
            Chart1.Series("Sales").Points(4).Color = System.Drawing.Color.FromArgb(87, 31, 217)
            Chart1.Series("Sales").Points(5).Color = System.Drawing.Color.FromArgb(197, 31, 217)
            Chart1.Series("Sales").Points(6).Color = System.Drawing.Color.FromArgb(234, 33, 105)
            Chart1.Series("Sales").Points(7).Color = System.Drawing.Color.FromArgb(255, 60, 36)
            Chart1.Series("Sales").Points(8).Color = System.Drawing.Color.FromArgb(255, 136, 36)
            Chart1.Series("Sales").Points(9).Color = System.Drawing.Color.FromArgb(255, 180, 36)
            Chart1.Series("Sales").Points(10).Color = System.Drawing.Color.FromArgb(255, 224, 36)
            Chart1.Series("Sales").Points(11).Color = System.Drawing.Color.FromArgb(236, 249, 35)
            Chart1.Series("Sales").IsVisibleInLegend = False
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series("Sales").IsValueShownAsLabel = True
            .Series("Sales").ChartType = SeriesChartType.Column
        End With
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSales()
        loadAccounts()
        loadReceivable()

        Dim maxyear As Integer = Today.Year
        txt_year.Maximum = maxyear
        txt_year.Value = maxyear

        loadGrid()
    End Sub
    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        loadSales()
        loadReceivable()
        loadAccounts()

        loadGrid()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim sql As String = String.Format("SELECT SUM(b.credit - IFNULL(d.debit,0)) AS amount " & _
    " ,e.general_name " & _
    " FROM trans_header a " & _
    " LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
    " LEFT JOIN {0}.lib_erp_chart c ON c.account_id = b.account_id " & _
    " LEFT JOIN ( " & _
      " SELECT a.ref_jbooks_id,SUM(debit) AS debit " & _
      " FROM trans_jbooks a " & _
      " GROUP BY a.ref_jbooks_id " & _
    " ) d ON d.ref_jbooks_id = b.jbooks_id " & _
    " LEFT JOIN {0}.lib_erp_general e ON e.general_id = b.general_id " & _
    " WHERE c.validation = 2 AND b.general_id IS NOT NULL and year(trans_date)='{1}' " & _
    " GROUP BY b.general_id " & _
    " ORDER BY amount DESC", _serverDBFS, txt_year.Value)

        Dim dt As DataTable = Query(sql)
        ds.Tables("accounts_receivable").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("accounts_receivable").ImportRow(row)
        Next
        Dim rep As New report_receivable_print
        rep.DataSource = ds.Tables("accounts_receivable")
        rep.company_name.Text = main.Sys_Default.Rows(0).Item("company_name")
        reportviewer.DocumentViewer1.DocumentSource = rep
        reportviewer.ShowDialog()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim sql As String = String.Format("SELECT a.account_code,a.account_name " & _
" ,IF(a.validation = 1, a.debit + a.credit, IF(a.validation = 2, a.debit - a.credit, IF(a.validation = 3, a.credit - a.debit, IF(a.validation = 4, a.credit - a.debit, IF(a.validation = 5, a.credit - a.debit, IF(a.validation = 6, a.debit - a.credit, IF(a.validation = 7, a.credit - a.debit, IF(a.validation = 8, a.debit - a.credit, IF(a.validation = 9, a.debit - a.credit, IF(a.validation = 10, a.debit_based + a.credit_based, a.debit + a.credit)))))))))) AS amount " & _
" FROM ( " & _
"	select a.trans_id, a.trans_date, b.jbooks_id, sum(b.debit) as debit, sum(b.credit) as credit, sum(b.debit_based) as debit_based, sum(b.credit_based) as credit_based, c.account_id, c.account_code, c.account_name, c.validation " & _
"	from trans_header a " & _
"	left join {0}.trans_jbooks b on b.trans_id = a.trans_id " & _
"	left join {1}.lib_erp_chart c on c.account_id = b.account_id " & _
"	where year(a.trans_date)='{2}' and b.jbooks_id is not null " & _
"	group by c.account_id " & _
" ) a " & _
" order by a.account_code", _serverDBMain, _serverDBFS, txt_year.Value)

        Dim dt As DataTable = Query(sql)
        ds.Tables("chart_accounts").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("chart_accounts").ImportRow(row)
        Next
        Dim rep As New report_accounts_print
        rep.DataSource = ds.Tables("chart_accounts")
        rep.company_name.Text = main.Sys_Default.Rows(0).Item("company_name")
        reportviewer.DocumentViewer1.DocumentSource = rep
        reportviewer.ShowDialog()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim sql As String = String.Format("select month(trans_date) as month, monthname(trans_date) as month_name, sum(a.credit_based) - sum(a.debit_based) as amount " & _
" from trans_jbooks a " & _
" left join {1}.lib_erp_chart b on b.account_id = a.account_id " & _
" left join {1}.lib_acc_chart_class c on c.chart_class_id = b.chart_class_id " & _
" LEFT join trans_header d on d.trans_id = a.trans_id " & _
" where c.chart_type = 'I' and year(d.trans_date)='{0}' " & _
" group by month(trans_date) " & _
" order by trans_date", txt_year.Value, _serverDBFS)

        Dim dt As DataTable = Query(sql)
        ds.Tables("sales_month").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("sales_month").ImportRow(row)
        Next
        Dim rep As New report_month_print
        rep.DataSource = ds.Tables("sales_month")
        rep.company_name.Text = main.Sys_Default.Rows(0).Item("company_name")
        reportviewer.DocumentViewer1.DocumentSource = rep
        reportviewer.ShowDialog()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim month As String = ""
        If dgMain.SelectedRows.Count > 0 Then
            Dim selectedrow = dgMain.SelectedRows(0)
            month = selectedrow.Cells("month").Value
        End If
        Dim sql As String = String.Format("select trans_date, sum(a.credit_based) - sum(a.debit_based) as amount " & _
" from trans_jbooks a " & _
" left join {1}.lib_erp_chart b on b.account_id = a.account_id " & _
" left join {1}.lib_acc_chart_class c on c.chart_class_id = b.chart_class_id " & _
" LEFT join trans_header d on d.trans_id = a.trans_id " & _
" where c.chart_type = 'I' and month(d.trans_date)='{2}' and year(d.trans_date)='{0}' " & _
" group by a.trans_id " & _
" order by year(trans_date) desc, month(trans_date) desc, day(trans_date) desc, amount desc", txt_year.Value, _serverDBFS, month)

        Dim dt As DataTable = Query(sql)
        ds.Tables("sales_day").Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables("sales_day").ImportRow(row)
        Next
        Dim rep As New report_day_print
        rep.DataSource = ds.Tables("sales_day")
        rep.company_name.Text = main.Sys_Default.Rows(0).Item("company_name")
        reportviewer.DocumentViewer1.DocumentSource = rep
        reportviewer.ShowDialog()
    End Sub
End Class