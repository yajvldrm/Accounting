Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Imports System.Text.RegularExpressions

Public Class balancesheet
    Private module_code As String = "ACC01010"
    Dim ds As New balancesheet_set
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub balancesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m As Integer = CType(DateTime.Today.ToString("MM"), Integer)
        Dim y As Integer = CType(DateTime.Today.ToString("yyyy"), Integer)
        If m = 1 Then
            txt_month_to.Value = 12
            txt_year_to.Value = y - 1
        Else
            txt_month_to.Value = m - 1
            txt_year_to.Value = y
        End If
        txt_month_from.Value = m
        txt_year_from.Value = y

        Dim sql As String = String.Format("SELECT False AS sel,a.book_id,a.book_code,a.book_name " & vbNewLine &
            "FROM lib_erp_book a " & vbNewLine &
            "WHERE a.company_id = '{0}' ", main.Sys_Default.Rows(0).Item("company_id").ToString)
        Dim dt As DataTable = FsQuery(sql)
        ds.Tables("lib_erp_book").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("lib_erp_book").ImportRow(dr)
        Next
        dgBooks.AutoGenerateColumns = False
        dgBooks.DataSource = ds.Tables("lib_erp_book")
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs, str_sort As String)
        Dim month_from = txt_month_from.Value
        Dim month_to = txt_month_to.Value
        Dim year_from = txt_year_from.Value
        Dim year_to = txt_year_to.Value
        Dim withZero = includeZero.Checked
        Dim perGroup = byGroup.Checked

        Dim date_from As New Date(year_from, month_from, DateSerial(year_from, month_from + 1, 0).ToString("dd"))
        Dim date_to As New Date(year_to, month_to, DateSerial(year_to, month_to + 1, 0).ToString("dd"))

        Dim lst_book = getCheckedGrid("book_id", "book_name", "sel", dgBooks, , False, "No Book Selected", False)
        If lst_book Is Nothing Or lst_book.Length = 0 Then
            Exit Sub
        End If
        Dim bookIds As String = ""
        For Each id In lst_book
            bookIds &= "," & id
        Next
        If date_from < date_to Then
            MsgBox("Invalid Month Range.")
            Exit Sub
        End If
        If date_from < main.Sys_Default.Rows(0).Item("sys_beg") Then
            MsgBox("Should Not be earlier than the beginning balance date")
            Exit Sub
        End If

        '***
        'a = lib_acc_chart_class
        'b = lib_erp_chart
        'c = lib_erp_chart_group
        'd = lib_acc_chart_group
        'e = ass of
        'f = comparative month
        '***

        Dim sql_tmp As String = String.Format("SELECT a.chart_class_id FROM {0}.lib_acc_chart_class a WHERE a.chart_type = 'C'", _serverDBFS)
        Dim dt_tmp As DataTable = FsQuery(sql_tmp)
        Dim sql_balance As String = ""
        If groupByBook.Checked Then
            sql_balance = String.Format("SELECT a.account_id,a.account_code,a.account_name,a.book_name,a.chart_type,a.chart_type_name AS chart_type_code,a.chart_type_name,a.chart_class,a.chart_class_name AS chart_class_code,a.chart_class_name,a.chart_group_id,a.chart_group_code,a.chart_group_name " &
            ",a.af_debit,a.af_credit,a.af_debit_based,a.af_credit_based,a.cm_debit,a.cm_credit,a.cm_debit_based,a.cm_credit_based " &
            "" &
            "FROM (" &
            "SELECT a.account_id,a.account_code,a.account_name " &
            "   ,IF(b.chart_type = 'A','A','C') AS chart_type " &
            "   ,IF(b.chart_type = 'A','ASSET','LIABILITIES & STOCKHOLDER\'S EQUITY') AS chart_type_name " &
            "   ,IF(b.chart_type = 'A',b.chart_class_id,IF(b.chart_type = 'L','L','C')) AS chart_class " &
            "   ,IF(b.chart_type = 'A',b.chart_class_name,IF(b.chart_type = 'L','LIABILITIES','STOCKHOLDER\'S EQUITY')) AS chart_class_name " &
            "   ,IF(b.chart_type = 'A',c.chart_group_id,IF(b.chart_type = 'L',c.chart_group_id,'C')) AS chart_group_id " &
            "   ,IF(b.chart_type = 'A',d.chart_group_name,IF(b.chart_type = 'L',d.chart_group_name,'')) AS chart_group_name " &
            "   ,IF(b.chart_type = 'A',d.chart_group_code,IF(b.chart_type = 'L',d.chart_group_name,'')) AS chart_group_code " &
            "   ,IFNULL(e.debit,0) AS af_debit,IFNULL(e.credit,0) AS af_credit,IFNULL(e.debit_based,0) AS af_debit_based,IFNULL(e.credit_based,0) AS af_credit_based " &
            "   ,IFNULL(f.debit,0) AS cm_debit,IFNULL(f.credit,0) AS cm_credit,IFNULL(f.debit_based,0) AS cm_debit_based,IFNULL(f.credit_based,0) AS cm_credit_based " &
            "   ,_book.book_name " &
            "   FROM lib_erp_chart a  " &
            "   LEFT JOIN lib_erp_book _book ON 1 = 1 " &
            "   LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " &
            "   LEFT JOIN (
                    SELECT a.chart_group_id,a.account_id,a.group_id
                    FROM lib_erp_chart_group a
                    GROUP BY a.account_id
                ) c ON c.account_id = a.account_id " &
            "   LEFT JOIN lib_acc_chart_group d ON d.chart_group_id = c.group_id " &
            "   LEFT JOIN ( " &
            "       Select a.book_id,b.account_id " &
            "       ,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS debit " &
            "       ,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS credit " &
            "       ,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS debit_based " &
            "       ,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS credit_based " &
            "       FROM {3}.trans_header a " &
            "       LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "       WHERE a.trans_date <= '{0}' AND a.book_id IN ({4}) " &
            "       GROUP BY a.book_id,b.account_id " &
            "   ) e ON e.account_id = a.account_id AND e.book_id = _book.book_id " &
            "   LEFT JOIN ( " &
            "       SELECT a.book_id,b.account_id " &
            "       ,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS debit " &
            "       ,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS credit " &
            "       ,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS debit_based " &
            "       ,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS credit_based " &
            "       FROM {3}.trans_header a " &
            "       LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "       WHERE a.trans_date <= '{1}' AND a.book_id IN ({4}) " &
            "       GROUP BY a.book_id,b.account_id " &
            "   ) f ON f.account_id = a.account_id AND f.book_id = _book.book_id " &
            "   WHERE b.chart_type IN ('A','L','C') AND _book.book_id IN ({4}) ", date_from.ToString("yyyy-MM-dd"), date_to.ToString("yyyy-MM-dd"), _serverDBFS, _serverDBMain, bookIds.Substring(1))

            If Not withZero Then
                sql_balance &= String.Format("AND IF(b.chart_type = 'A' OR b.chart_type = 'L',((e.debit <> 0 OR e.credit <> 0) OR (f.debit <> 0 OR f.credit <> 0)),True) ")
            End If

            sql_balance &= String.Format("ORDER BY FIELD(b.chart_type,'A','L','C'),b.chart_class_code,d.chart_group_name,a.account_name " &
                ") a ")
            sql_balance &= String.Format("UNION " &
            "SELECT a.account_id,a.account_code,a.account_name,a.book_name,a.chart_type,a.chart_type_name AS chart_type_code,a.chart_type_name,a.chart_class,a.chart_class_name AS chart_class_code,a.chart_class_name,a.chart_group_id,a.chart_group_name AS chart_group_code,a.chart_group_name " &
            ",IF(a.af_debit > a.af_credit,a.af_debit - a.af_credit,-1 * a.af_debit) AS af_debit " &
            ",IF(a.af_credit > a.af_debit,a.af_credit - a.af_debit,-1 * a.af_credit) AS af_credit " &
            ",IF(a.af_debit_based > a.af_credit_based,a.af_debit_based - a.af_credit_based,-1 * a.af_debit_based) AS af_debit_based " &
            ",IF(a.af_credit_based > a.af_debit_based,a.af_credit_based - a.af_debit_based,-1 * a.af_credit_based) AS af_credit_based " &
            ",IF(a.cm_debit > a.cm_credit,a.cm_debit - a.cm_credit,-1 * a.cm_debit) AS cm_debit " &
            ",IF(a.cm_credit > a.cm_debit,a.cm_credit - a.cm_debit,-1 * a.cm_credit) AS cm_credit " &
            ",IF(a.cm_debit_based > a.cm_credit_based,a.cm_debit_based - a.cm_credit_based,-1 * a.cm_debit_based) AS cm_debit_based " &
            ",IF(a.cm_credit_based > a.cm_debit_based,a.cm_credit_based - a.cm_debit_based,-1 * a.cm_credit_based) AS cm_credit_based " &
            "FROM (" &
            "   SELECT a.account_id,a.account_code,a.account_name,a.chart_type,a.chart_type_name,a.chart_class,a.chart_class_name,a.chart_group_id,a.chart_group_name " &
            "   ,(SUM(IFNULL(b.debit,0)) - SUM(IFNULL(c.debit,0))) AS af_debit " &
            "   ,(SUM(IFNULL(b.credit,0)) - SUM(IFNULL(c.credit,0))) AS af_credit " &
            "   ,(SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(c.debit_based,0))) AS af_debit_based " &
            "   ,(SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(c.credit_based,0))) AS af_credit_based " &
            "   ,(SUM(IFNULL(d.debit,0)) - SUM(IFNULL(e.debit,0))) AS cm_debit " &
            "   ,(SUM(IFNULL(d.credit,0)) - SUM(IFNULL(e.credit,0))) AS cm_credit " &
            "   ,(SUM(IFNULL(d.debit_based,0)) - SUM(IFNULL(e.debit_based,0))) AS cm_debit_based " &
            "   ,(SUM(IFNULL(d.credit_based,0)) - SUM(IFNULL(e.credit_based,0))) AS cm_credit_based " &
            "   ,_book.book_name " &
            "   FROM ( " &
            "       SELECT 'C' AS account_id,'C' AS account_code,'NET INCOME (LOSS) FOR THE PERIOD' AS account_name " &
            "       ,'C' AS chart_type,'LIABILITIES & STOCKHOLDER\'S EQUITY' AS chart_type_name,'C' AS chart_class " &
            "       ,'STOCKHOLDER\'S EQUITY' AS chart_class_name,'C' AS chart_group_id,'' AS chart_group_name " &
            "   ) a " &
            "   LEFT JOIN lib_erp_book _book ON 1 = 1 " &
            "   LEFT JOIN ( " &
            "       SELECT a.book_id,'C' AS account_id " &
            "       ,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS debit " &
            "       ,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS credit " &
            "       ,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS debit_based " &
            "       ,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS credit_based " &
            "       FROM {3}.trans_header a " &
            "       LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "       LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
            "       LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
            "       WHERE d.chart_type = 'I' AND a.trans_date <= '{0}' AND a.book_id IN ({4}) " &
            "       GROUP BY a.book_id,d.chart_type " &
            "   ) b ON b.account_id = a.account_id AND b.book_id = _book.book_id " &
            "   LEFT JOIN ( " &
            "       SELECT a.book_id,'C' AS account_id " &
            "       ,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS credit " &
            "       ,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS debit " &
            "       ,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS credit_based " &
            "       ,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS debit_based " &
            "       FROM {3}.trans_header a " &
            "       LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "       LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
            "       LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
            "       WHERE d.chart_type = 'E' AND a.trans_date <= '{0}' AND a.book_id IN ({4}) " &
            "       GROUP BY a.book_id,d.chart_type " &
            "   ) c ON c.account_id = a.account_id AND c.book_id = _book.book_id " &
            "   LEFT JOIN ( " &
            "       SELECT a.book_id,'C' AS account_id " &
            "       ,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS debit " &
            "       ,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS credit " &
            "       ,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS debit_based " &
            "       ,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS credit_based " &
            "       FROM {3}.trans_header a " &
            "       LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "       LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
            "       LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
            "       WHERE d.chart_type = 'I' AND a.trans_date <= '{1}' AND a.book_id IN ({4}) " &
            "       GROUP BY a.book_id,d.chart_type " &
            "   ) d ON d.account_id = a.account_id AND d.book_id = _book.book_id " &
            "   LEFT JOIN ( " &
            "       SELECT a.book_id,'C' AS account_id " &
            "       ,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS credit " &
            "       ,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS debit " &
            "       ,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS credit_based " &
            "       ,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS debit_based " &
            "       FROM {3}.trans_header a " &
            "       LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "       LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
            "       LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
            "       WHERE d.chart_type = 'E' AND a.trans_date <= '{1}' AND a.book_id IN ({4}) " &
            "       GROUP BY a.book_id,d.chart_type " &
            "   ) e ON e.account_id = a.account_id AND e.book_id = _book.book_id " &
            "   WHERE _book.book_id IN ({4}) " &
            "   GROUP BY _book.book_id " &
            ") a ", date_from.ToString("yyyy-MM-dd"), date_to.ToString("yyyy-MM-dd"), _serverDBFS, _serverDBMain, bookIds.Substring(1))
        Else
            sql_balance = String.Format("SELECT a.account_id,a.account_code,a.account_name,a.book_name,a.chart_type,a.chart_type_name AS chart_type_code,a.chart_type_name " &
                ",a.chart_class,a.chart_class_name AS chart_class_code,a.chart_class_name,a.chart_group_id,a.chart_group_code,a.chart_group_name " &
                ",a.af_debit,a.af_credit,a.af_debit_based,a.af_credit_based,a.cm_debit,a.cm_credit,a.cm_debit_based,a.cm_credit_based " &
                "FROM ( " &
                "	SELECT a.account_id,a.account_code,a.account_name " &
                "	,IF(b.chart_type = 'A','A','C') AS chart_type " &
                "	,IF(b.chart_type = 'A','ASSET','LIABILITIES & STOCKHOLDER\'S EQUITY') AS chart_type_name " &
                "	,IF(b.chart_type = 'A',b.chart_class_id,IF(b.chart_type = 'L','L','C')) AS chart_class " &
                "	,IF(b.chart_type = 'A',b.chart_class_name,IF(b.chart_type = 'L','LIABILITIES','STOCKHOLDER\'S EQUITY')) AS chart_class_name " &
                "	,IF(b.chart_type = 'A',c.chart_group_id,IF(b.chart_type = 'L',c.chart_group_id,'C')) AS chart_group_id " &
                "	,IF(b.chart_type = 'A',d.chart_group_name,IF(b.chart_type = 'L',d.chart_group_name,'')) AS chart_group_name " &
                "	,IF(b.chart_type = 'A',d.chart_group_code,IF(b.chart_type = 'L',d.chart_group_name,'')) AS chart_group_code " &
                "	,IFNULL(e.debit,0) AS af_debit,IFNULL(e.credit,0) AS af_credit,IFNULL(e.debit_based,0) AS af_debit_based,IFNULL(e.credit_based,0) AS af_credit_based " &
                "	,IFNULL(f.debit,0) AS cm_debit,IFNULL(f.credit,0) AS cm_credit,IFNULL(f.debit_based,0) AS cm_debit_based,IFNULL(f.credit_based,0) AS cm_credit_based " &
                "	,_book.book_name " &
                "	FROM lib_erp_chart a  " &
                "	LEFT JOIN lib_erp_book _book ON 1 = 1 " &
                "	LEFT JOIN lib_acc_chart_class b ON b.chart_class_id = a.chart_class_id " &
                "	LEFT JOIN (
                    SELECT a.chart_group_id,a.account_id,a.group_id
                    FROM lib_erp_chart_group a
                    GROUP BY a.account_id
                ) c ON c.account_id = a.account_id " &
                "	LEFT JOIN lib_acc_chart_group d ON d.chart_group_id = c.group_id " &
                "	LEFT JOIN ( " &
                "		Select a.book_id,b.account_id " &
                "		,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS debit " &
                "		,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS credit " &
                "		,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS debit_based " &
                "		,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS credit_based " &
                "		FROM {3}.trans_header a " &
                "		LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
                "		WHERE a.trans_date <= '{0}' AND a.book_id IN ({4}) " &
                "		GROUP BY b.account_id " &
                "	) e ON e.account_id = a.account_id " &
                "	LEFT JOIN ( " &
                "		SELECT a.book_id,b.account_id " &
                "		,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS debit " &
                "		,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS credit " &
                "		,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS debit_based " &
                "		,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS credit_based " &
                "		FROM {3}.trans_header a " &
                "		LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
                "		WHERE a.trans_date <= '{1}' AND a.book_id IN ({4}) " &
                "		GROUP BY b.account_id " &
                "	) f ON f.account_id = a.account_id " &
                "	WHERE b.chart_type IN ('A','L','C') AND _book.book_id IN ({4}) ", date_from.ToString("yyyy-MM-dd"), date_to.ToString("yyyy-MM-dd"), _serverDBFS, _serverDBMain, bookIds.Substring(1))

            If Not withZero Then
                sql_balance &= String.Format("AND IF(b.chart_type = 'A' OR b.chart_type = 'L',((e.debit <> 0 OR e.credit <> 0) OR (f.debit <> 0 OR f.credit <> 0)),True) ")
            End If
            sql_balance &= String.Format("GROUP BY a.account_id ")
            sql_balance &= String.Format("ORDER BY (a.account_id),b.chart_type,b.chart_class_code,d.chart_group_name,a.account_name " &
                ") a ")
            sql_balance &= String.Format("UNION " &
                "SELECT a.account_id,a.account_code,a.account_name,a.book_name,a.chart_type,a.chart_type_name AS chart_type_code,a.chart_type_name " &
                ",a.chart_class,a.chart_class_name AS chart_class_code,a.chart_class_name,a.chart_group_id,a.chart_group_name AS chart_group_code,a.chart_group_name " &
                ",IF(a.af_debit > a.af_credit,a.af_debit - a.af_credit,-1 * a.af_debit) AS af_debit " &
                ",IF(a.af_credit > a.af_debit,a.af_credit - a.af_debit,-1 * a.af_credit) AS af_credit " &
                ",IF(a.af_debit_based > a.af_credit_based,a.af_debit_based - a.af_credit_based,-1 * a.af_debit_based) AS af_debit_based " &
                ",IF(a.af_credit_based > a.af_debit_based,a.af_credit_based - a.af_debit_based,-1 * a.af_credit_based) AS af_credit_based " &
                ",IF(a.cm_debit > a.cm_credit,a.cm_debit - a.cm_credit,-1 * a.cm_debit) AS cm_debit " &
                ",IF(a.cm_credit > a.cm_debit,a.cm_credit - a.cm_debit,-1 * a.cm_credit) AS cm_credit " &
                ",IF(a.cm_debit_based > a.cm_credit_based,a.cm_debit_based - a.cm_credit_based,-1 * a.cm_debit_based) AS cm_debit_based " &
                ",IF(a.cm_credit_based > a.cm_debit_based,a.cm_credit_based - a.cm_debit_based,-1 * a.cm_credit_based) AS cm_credit_based " &
                "FROM ( " &
                "	SELECT a.account_id,a.account_code,a.account_name,a.chart_type,a.chart_type_name,a.chart_class,a.chart_class_name,a.chart_group_id,a.chart_group_name " &
                "	,(SUM(IFNULL(b.debit,0)) - SUM(IFNULL(c.debit,0))) AS af_debit " &
                "	,(SUM(IFNULL(b.credit,0)) - SUM(IFNULL(c.credit,0))) AS af_credit " &
                "	,(SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(c.debit_based,0))) AS af_debit_based " &
                "	,(SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(c.credit_based,0))) AS af_credit_based " &
                "	,(SUM(IFNULL(d.debit,0)) - SUM(IFNULL(e.debit,0))) AS cm_debit " &
                "	,(SUM(IFNULL(d.credit,0)) - SUM(IFNULL(e.credit,0))) AS cm_credit " &
                "	,(SUM(IFNULL(d.debit_based,0)) - SUM(IFNULL(e.debit_based,0))) AS cm_debit_based " &
                "	,(SUM(IFNULL(d.credit_based,0)) - SUM(IFNULL(e.credit_based,0))) AS cm_credit_based " &
                "   ,'' AS book_name " &
                "	FROM ( " &
                "		SELECT 'C' AS account_id,'C' AS account_code,'NET INCOME (LOSS) FOR THE PERIOD' AS account_name ,'C' AS chart_type " &
                "		,'LIABILITIES & STOCKHOLDER\'S EQUITY' AS chart_type_name,'C' AS chart_class ,'STOCKHOLDER\'S EQUITY' AS chart_class_name " &
                "		,'C' AS chart_group_id,'' AS chart_group_name " &
                "	) a " &
                "	LEFT JOIN ( " &
                "		SELECT a.book_id,'C' AS account_id " &
                "		,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS debit " &
                "		,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS credit " &
                "		,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS debit_based " &
                "		,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS credit_based " &
                "		FROM {3}.trans_header a " &
                "		LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
                "		LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
                "		LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
                "		WHERE d.chart_type = 'I' AND a.trans_date <= '{0}' AND a.book_id IN ({4}) " &
                "		GROUP BY d.chart_type " &
                "	) b ON b.account_id = a.account_id " &
                "	LEFT JOIN ( " &
                "		SELECT a.book_id,'C' AS account_id " &
                "		,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS credit " &
                "		,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS debit " &
                "		,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS credit_based " &
                "		,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS debit_based " &
                "		FROM {3}.trans_header a " &
                "		LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
                "		LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
                "		LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
                "		WHERE d.chart_type = 'E' AND a.trans_date <= '{0}' AND a.book_id IN ({4}) " &
                "		GROUP BY d.chart_type " &
                "	) c ON c.account_id = a.account_id " &
                "	LEFT JOIN ( " &
                "		SELECT a.book_id,'C' AS account_id " &
                "		,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS debit " &
                "		,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS credit " &
                "		,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS debit_based " &
                "		,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS credit_based " &
                "		FROM {3}.trans_header a " &
                "		LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
                "		LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
                "		LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
                "		WHERE d.chart_type = 'I' AND a.trans_date <= '{1}' AND a.book_id IN ({4}) " &
                "		GROUP BY d.chart_type " &
                "	) d ON d.account_id = a.account_id " &
                "	LEFT JOIN ( " &
                "		SELECT a.book_id,'C' AS account_id " &
                "		,IF(SUM(IFNULL(b.debit,0)) > SUM(IFNULL(b.credit,0)),SUM(IFNULL(b.debit,0)) - SUM(IFNULL(b.credit,0)),0) AS credit " &
                "		,IF(SUM(IFNULL(b.credit,0)) > SUM(IFNULL(b.debit,0)),SUM(IFNULL(b.credit,0)) - SUM(IFNULL(b.debit,0)),0) AS debit " &
                "		,IF(SUM(IFNULL(b.debit_based,0)) > SUM(IFNULL(b.credit_based,0)),SUM(IFNULL(b.debit_based,0)) - SUM(IFNULL(b.credit_based,0)),0) AS credit_based " &
                "		,IF(SUM(IFNULL(b.credit_based,0)) > SUM(IFNULL(b.debit_based,0)),SUM(IFNULL(b.credit_based,0)) - SUM(IFNULL(b.debit_based,0)),0) AS debit_based " &
                "		FROM {3}.trans_header a " &
                "		LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
                "		LEFT JOIN lib_erp_chart c ON c.account_id = b.account_id " &
                "		LEFT JOIN lib_acc_chart_class d ON d.chart_class_id = c.chart_class_id " &
                "		WHERE d.chart_type = 'E' AND a.trans_date <= '{1}' AND a.book_id IN ({4}) " &
                "		GROUP BY d.chart_type " &
                "	) e ON e.account_id = a.account_id " &
            ") a ", date_from.ToString("yyyy-MM-dd"), date_to.ToString("yyyy-MM-dd"), _serverDBFS, _serverDBMain, bookIds.Substring(1))
        End If

        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin " &
                                                  "FROM sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id", _serverDBFS)

        Dim dt_balance As DataTable = FsQuery(sql_balance)
        Dim dt_company As DataTable = Query(sql_company)

        dt_balance.DefaultView.Sort = "chart_class_name ASC"
        ds.Tables("Balance").Clear()
        ds.Tables("Company").Clear()

        For Each row As DataRow In dt_balance.Rows
            ds.Tables("Balance").ImportRow(row)
        Next

        For Each row As DataRow In dt_company.Rows
            ds.Tables("Company").ImportRow(row)
        Next

        If sender.name = "btnPrint" Then
            If groupByBook.Checked Then
                Dim rep As New report_balancesheet_print_20171120

                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.Parameters("daterange").Value = MonthName(month_from) & ", " & year_from & ""
                rep.Parameters("comparativemonth").Value = "With comparative figures as of " & MonthName(month_to) & ", " & year_to
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                rep.GHType.SortingSummary.SortOrder = Nothing
                rep.GHClass.SortingSummary.SortOrder = Nothing
                rep.lbl1.Text = MonthName(month_from) & ", " & year_from
                rep.lbl2.Text = MonthName(month_to) & ", " & year_to
                rep.lbl3.Text = MonthName(month_from) & ", " & year_from
                rep.GFGroup.Visible = False
                If perGroup Then
                    rep.GFGroup.Visible = True
                End If
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            Else
                Dim rep As New report_balancesheet_print_bak

                rep.DataSource = ds
                rep.Parameters("runtime").Value = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                rep.Parameters("daterange").Value = MonthName(month_from) & ", " & year_from & " and " & MonthName(month_to) & ", " & year_to
                rep.Parameters("comparativemonth").Value = "With comparative figures as of " & MonthName(month_to) & ", " & year_to
                rep.company_logo.ImageUrl = Application.StartupPath & "/img/logo.png"
                rep.GroupHeader1.SortingSummary.SortOrder = Nothing
                rep.GroupHeader2.SortingSummary.SortOrder = Nothing
                rep.lbl1.Text = MonthName(month_from) & ", " & year_from
                rep.lbl2.Text = MonthName(month_to) & ", " & year_to
                rep.lbl3.Text = MonthName(month_from) & ", " & year_from
                rep.GroupFooter3.Visible = False
                If perGroup Then
                    rep.GroupFooter3.Visible = True
                End If
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
            End If
        Else
            Try
                lblLoad.Visible = True
                Dim dicHead As New Dictionary(Of String, String)
                dicHead.Add("companyName", "")
                dicHead.Add("dateRange", String.Format("{0}, {1} and {2}, {3}", MonthName(month_from), year_from, MonthName(month_to), year_to))
                'dicHead.Add("daterange", MonthName(month_from) & ", " & year_from & "")
                dicHead.Add("comparative", String.Format("With comparative figures as of {0}, {1}", MonthName(month_to), year_to))
                dicHead.Add("templateName", "BalanceSheet.xlt")
                dicHead.Add("lbl1", String.Format("As of {0}, {1}", MonthName(month_from), year_to))
                dicHead.Add("lbl2", String.Format("As of {0}, {1}", MonthName(month_to), year_to))
                dicHead.Add("lbl3", String.Format("Difference of {0}, {1}", MonthName(month_from), year_to))
                If dt_company.Rows.Count > 0 Then
                    dicHead.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
                End If
                Dim strGrouping As String = ""
                If groupByBook.Checked Then
                    strGrouping &= "book_name,"
                End If
                strGrouping &= "chart_type_code,chart_class_name"
                If perGroup Then
                    strGrouping &= ",chart_group_name"
                End If
                Dim listAccount = groupDataTableToList(ds.Tables("Balance"), strGrouping)
                If groupByBook.Checked Then
                    'MsgBox("Data Succesfully Load")
                    generateReportExcel(listAccount, strGrouping, dicHead)
                Else
                    generateExcelReport(listAccount, strGrouping, dicHead)
                    'MsgBox("Data Succesfully Load")
                End If
                MsgBox("Report Done")
                lblLoad.Visible = False
            Catch ex As Exception
                lblLoad.Visible = False
                MsgBox(String.Format("Error Occured : {0}", ex.Message))
                MyDebugging.AddText(ex.Message)
            End Try
        End If
    End Sub
    Private Sub generateReportExcel(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHead As Dictionary(Of String, String))
        Dim ctr As Integer = 0

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        xlApp.DisplayAlerts = False

        If xlWorkBook.Worksheets.Count = 3 Then
            xlWorkBook.Worksheets(1).Delete()
            xlWorkBook.Worksheets(1).Delete()
        End If
        For Each g In listAccount
            If ctr > 0 Then
                xlWorkBook.Worksheets().Add()
            End If

            ctr += 1

            xlWorkSheet = xlWorkBook.Worksheets(1)
            xlWorkSheet.Visible = True
            Dim sheetName As String = Regex.Replace(g.Item("book_name").ToString.Trim, "[^A-Za-z0-9]", "")
            If sheetName.Length >= 30 Then
                sheetName = sheetName.Substring(0, 30)
            End If
            xlWorkSheet.Name = sheetName
            xlWorkSheet.Cells(1, 1).ColumnWidth = 2
            xlWorkSheet.Cells(1, 2).ColumnWidth = 48
            xlWorkSheet.Cells(1, 3).ColumnWidth = 15
            xlWorkSheet.Cells(1, 4).ColumnWidth = 15
            xlWorkSheet.Cells(1, 5).ColumnWidth = 15

            xlWorkSheet.Cells(1, 1) = dicHead.Item("companyName").ToString
            xlWorkSheet.Cells(2, 1) = "BALANCE SHEET"
            xlWorkSheet.Cells(3, 1) = dicHead.Item("dateRange").ToString & " - " & g.Item("book_name").ToString
            xlWorkSheet.Cells(4, 1) = dicHead.Item("comparative").ToString

            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 5)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 5)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 5)).HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 5)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 5)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 5)).HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 5)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 5)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 5)).HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 5)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 5)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 5)).HorizontalAlignment = Excel.Constants.xlCenter

            xlWorkSheet.Cells(5, 3) = dicHead.Item("lbl1")
            xlWorkSheet.Cells(5, 4) = dicHead.Item("lbl2")
            xlWorkSheet.Cells(5, 5) = dicHead.Item("lbl3")

            Dim current_index As Integer = 1
            Dim current_row As Integer = 6
            generateGroupExcel(xlWorkSheet, g.Item("grouped"), strCol, dicHead, current_index, current_row)
        Next
    End Sub
    Private Sub generateGroupExcel(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHead As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        current_index += 1
        For Each item In listAccount
            If item.ContainsKey("grouped") Then
                Select Case field
                    Case "chart_type_code"
                        xlWorkSheet.Cells(current_row, 1).Value = item(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim firstrow = current_row
                        generateExcelGroup(xlWorkSheet, item.Item("grouped"), strCol, dicHead, current_index, current_row)
                        current_index -= 1
                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & item.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstrow, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        current_row += 1
                        current_row += 1
                    Case "chart_class_name"
                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = item(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim firstrow = current_row
                        generateExcelGroup(xlWorkSheet, item.Item("grouped"), strCol, dicHead, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & item.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstrow, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                        current_row += 1
                    Case "chart_group_name"
                        xlWorkSheet.Cells(current_row, 1).Value = item(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim firstrow = current_row
                        generateExcelGroup(xlWorkSheet, item.Item("grouped"), strCol, dicHead, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & item.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstrow, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        current_row += 1
                        current_row += 1

                End Select
            Else
                xlWorkSheet.Cells(current_row, 1).Value = item(field)
                xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                current_row += 1
                Dim firstrow As Integer = current_row
                Dim listData = CType(item.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("account_name")
                    Dim isDebit As Boolean = If(dic.Item("chart_type").ToString = "A" Or dic.Item("chart_type").ToString = "E", True, False)
                    Dim af = If(isDebit, If(dic.Item("af_debit_based") > dic.Item("af_credit_based"), dic.Item("af_debit_based"), dic.Item("af_credit_based") * -1), If(dic.Item("af_credit_based") > dic.Item("af_debit_based"), dic.Item("af_credit_based"), dic.Item("af_debit_based") * -1))
                    Dim cm = If(isDebit, If(dic.Item("cm_debit_based") > dic.Item("cm_credit_based"), dic.Item("cm_debit_based"), dic.Item("cm_credit_based") * -1), If(dic.Item("cm_credit_based") > dic.Item("cm_debit_based"), dic.Item("cm_credit_based"), dic.Item("cm_debit_based") * -1))
                    xlWorkSheet.Cells(current_row, 3) = af
                    xlWorkSheet.Cells(current_row, 4) = cm
                    xlWorkSheet.Cells(current_row, 5) = af - cm
                    current_row += 1
                Next
                xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & item.Item(field) & " : "
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstrow, current_row - 1)
                xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstrow, current_row - 1)
                xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstrow, current_row - 1)
                current_row += 1
                current_row += 1
            End If
        Next

    End Sub
    Private Sub generateExcelReport(ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHead As Dictionary(Of String, String))
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        xlWorkBook = xlApp.Workbooks.Open(templates & "\" & dicHead.Item("templateName"))
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = dicHead.Item("companyName")
        xlWorkSheet.Cells(3, 1) = dicHead.Item("dateRange")
        xlWorkSheet.Cells(4, 1) = dicHead.Item("comparative")
        xlWorkSheet.Cells(5, 3) = dicHead.Item("lbl1")
        xlWorkSheet.Cells(5, 4) = dicHead.Item("lbl2")
        xlWorkSheet.Cells(5, 5) = dicHead.Item("lbl3")


        Dim current_index As Integer = 0
        Dim current_row As Integer = 6
        generateExcelGroup(xlWorkSheet, listAccount, strCol, dicHead, current_index, current_row)

    End Sub
    Private Sub generateExcelGroup(ByVal xlWorkSheet As Excel.Worksheet, ByVal listAccount As List(Of Object), ByVal strCol As String, ByVal dicHead As Dictionary(Of String, String), ByRef current_index As Integer, ByRef current_row As Integer)
        Dim fields = strCol.Split(",")
        Dim field As String = fields(current_index)
        current_index += 1
        For Each item In listAccount
            Dim dicItem = Nothing
            If TypeOf item Is Dictionary(Of String, String) Then
                dicItem = CType(item, Dictionary(Of String, String))
            Else
                dicItem = CType(item, Dictionary(Of String, Object))
            End If
            If dicItem.ContainsKey("grouped") Then
                Select Case field

                    Case "chart_type_code"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim firstrow = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHead, current_index, current_row)
                        current_index -= 1
                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & dicItem.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstrow, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
                        current_row += 1
                        current_row += 1
                    Case "chart_class_name"
                        current_row += 1
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).Font.Underline = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim firstrow = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHead, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & dicItem.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstrow, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
                        current_row += 1
                    Case "chart_group_name"
                        xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                        xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        current_row += 1
                        Dim firstrow = current_row
                        generateExcelGroup(xlWorkSheet, dicItem.Item("grouped"), strCol, dicHead, current_index, current_row)
                        current_index -= 1
                        xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & dicItem.Item(field) & " : "
                        xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                        xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstrow, current_row - 1)
                        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstrow, current_row - 1)
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        current_row += 1
                        current_row += 1
                End Select
            Else
                xlWorkSheet.Cells(current_row, 1).Value = dicItem(field)
                xlWorkSheet.Cells(current_row, 1).Font.Bold = True
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                current_row += 1
                Dim firstrow As Integer = current_row
                Dim listData = CType(dicItem.Item("datas"), List(Of Object))
                For Each d In listData
                    Dim dic = Nothing
                    If TypeOf d Is Dictionary(Of String, String) Then
                        dic = CType(d, Dictionary(Of String, String))
                    Else
                        dic = CType(d, Dictionary(Of String, Object))
                    End If
                    xlWorkSheet.Cells(current_row, 2) = dic.Item("account_name")
                    Dim isDebit As Boolean = If(dic.Item("chart_type").ToString = "A" Or dic.Item("chart_type").ToString = "E", True, False)
                    Dim af = If(isDebit, If(dic.Item("af_debit_based") > dic.Item("af_credit_based"), dic.Item("af_debit_based"), dic.Item("af_credit_based") * -1), If(dic.Item("af_credit_based") > dic.Item("af_debit_based"), dic.Item("af_credit_based"), dic.Item("af_debit_based") * -1))
                    Dim cm = If(isDebit, If(dic.Item("cm_debit_based") > dic.Item("cm_credit_based"), dic.Item("cm_debit_based"), dic.Item("cm_credit_based") * -1), If(dic.Item("cm_credit_based") > dic.Item("cm_debit_based"), dic.Item("cm_credit_based"), dic.Item("cm_debit_based") * -1))
                    xlWorkSheet.Cells(current_row, 3) = af
                    xlWorkSheet.Cells(current_row, 4) = cm
                    xlWorkSheet.Cells(current_row, 5) = af - cm
                    current_row += 1
                Next
                xlWorkSheet.Cells(current_row, 1).Value = "TOTAL " & dicItem.Item(field) & " : "
                xlWorkSheet.Cells(current_row, 1).IndentLevel = 2
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 5)).Font.Bold = True
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 3), xlWorkSheet.Cells(current_row, 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Cells(current_row, 3) = String.Format("=SUBTOTAL(9,C{0}:C{1})", firstrow, current_row - 1)
                xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", firstrow, current_row - 1)
                xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", firstrow, current_row - 1)
                current_row += 1
                current_row += 1

            End If
        Next

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        Dim _printoption As New reportoption
        _printoption.targetForm = Me
        _printoption.Label1.Hide()
        _printoption.cbo_sort.Hide()
        _printoption.ShowDialog()
        If _printoption.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim str_sortby As String = _printoption.cbo_sort.SelectedText
            If _printoption.PrintOption = "1" Then
                btnPrint_Click(btnExcel, Nothing, str_sortby)
            Else
                btnPrint_Click(btnPrint, Nothing, str_sortby)
            End If
        End If
    End Sub

    Private Sub txt_month_from_ValueChange(sender As Object) Handles txt_month_from.ValueChange
        changeDate()
    End Sub

    Private Sub txt_year_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_year_from.ValueChanged
        changeDate()
    End Sub
    Private Sub changeDate()
        Dim month_from = txt_month_from.Value
        Dim month_to = month_from
        Dim year_from = txt_year_from.Value
        Dim year_to = year_from
        Dim date_from As New Date(year_from, month_from, DateSerial(year_from, month_from + 1, 0).ToString("dd"))
        If month_from = 1 Then
            month_to = 12
            year_to = year_from - 1
        Else
            month_to = month_from - 1
            year_to = year_from
        End If
        txt_month_to.Value = month_to
        txt_year_to.Value = year_to
    End Sub

    Private Sub checkAllBook_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBook.CheckedChanged
        If dgBooks.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgBooks.Rows
                row.Cells("sel").Value = checkAllBook.Checked
            Next
        End If
    End Sub
End Class