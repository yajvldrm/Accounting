Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class Receivable
    Dim ds As New begbal
    Dim dbTable As String = "trans_jbooks"
    Dim isloaded As Boolean = False

    Private Sub loadReceivable()
        isloaded = True
        dgMain3.AutoGenerateColumns = False
        Dim sql = String.Format("SELECT a.trans_no,a.trans_date,b.jbooks_id,b.general_id " & _
    " ,SUM(b.credit - IFNULL(d.debit,0)) AS amount " & _
    " ,e.general_code,e.general_name " & _
    " FROM trans_header a " & _
    " LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id " & _
    " LEFT JOIN {0}.lib_erp_chart c ON c.account_id = b.account_id " & _
    " LEFT JOIN ( " & _
      " SELECT a.ref_jbooks_id,SUM(debit) AS debit " & _
      " FROM trans_jbooks a " & _
      " GROUP BY a.ref_jbooks_id " & _
    " ) d ON d.ref_jbooks_id = b.jbooks_id " & _
    " LEFT JOIN {0}.lib_erp_general e ON e.general_id = b.general_id " & _
    " WHERE c.validation = 2 AND b.general_id IS NOT NULL " & _
    " GROUP BY b.general_id " & _
    " ORDER BY a.trans_date", _serverDBFS)
        Dim dt As DataTable = Query(sql)
        ds.Tables(dbTable).Clear()
        For Each row As DataRow In dt.Rows
            ds.Tables(dbTable).ImportRow(row)
        Next
        dgMain3.DataSource = ds.Tables(dbTable)
    End Sub

    Private Sub Receivable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isloaded Then
            loadReceivable()
        End If
        Me.Location = New Drawing.Point(175, 400)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs)
        Dim dt As DataTable = ds.Tables(dbTable)
        bind_control(dgMain3, "jbooks_id", dt, Me)
        Dim dtReceive As DataTable = FsQuery("SELECT b.general_id AS gen_id,b.general_name,a.general_id FROM lib_erp_general a LEFT JOIN lib_erp_general b ON b.general_id = a.gen_id")
        ds.Tables("lib_erp_general").Clear()
        For Each row As DataRow In dtReceive.Rows
            ds.Tables("lib_erp_general").ImportRow(row)
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim sql As String = String.Format(" SELECT a.sys_beg, b.company_name " & _
                                          "FROM sys_default a " & _
                                          "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " & _
                                          "", _serverDBFS)
        Dim dt As DataTable = Query(sql)
        Dim sql_account As String = String.Format("SELECT a.jbooks_id,a.trans_id,a.project_id,a.department_id,a.allocation_id,a.account_id,a.currency_id,a.exchange_rate,a.based_rate " & _
        ",a.debit,a.credit,a.debit_based,a.credit_based,a.general_id,a.ref_jbooks_id,a.line_remarks " & _
        ",d.ref_no,d.ref_date,b.account_code,e.general_code,e.general_name " & _
        ",f.project_code,f.project_name,g.department_code,g.department_name,h.currency_code,h.currency_name " & _
        " FROM trans_jbooks a " & _
        "LEFT JOIN {0}.lib_erp_chart b ON b.account_id = a.account_id " & _
        " LEFT JOIN trans_header c ON c.trans_id = a.trans_id " & _
        "LEFT JOIN trans_jbooks_ref d ON d.jbooks_id = a.jbooks_id " & _
        " LEFT JOIN {0}.lib_erp_general e ON e.general_id = a.general_id" & _
        " LEFT JOIN {0}.lib_erp_project f ON f.project_id = a.project_id" & _
        " LEFT JOIN {0}.lib_erp_department g ON g.department_id = a.department_id " & _
        " LEFT JOIN {0}.lib_erp_currency h ON h.currency_id = a.currency_id " & _
        " WHERE b.validation = 2 AND d.ref_date <= '{1}' ORDER BY (debit + debit_based) DESC  ", _serverDBFS, CDate(dt.Rows(0).Item("sys_beg")).ToString("yyyy-MM-dd"))
        Dim dt_account As DataTable = Query(sql_account)
        Dim ds As New beg_bal_apar
        For Each row As DataRow In dt_account.Rows
            ds.Tables("dt_apar").ImportRow(row)
        Next
        Dim rep As New report_begbal_apar_print
        rep.DataSource = ds
        rep.company_name.Text = dt.Rows(0).Item("company_name")
        rep.report_name.Text = "Beginning Balance for Accounts Receivable"
        rep.as_of_date.Text = String.Format("As of {0}", CDate(dt.Rows(0).Item("sys_beg")).ToString("MMM, yyyy"))
        rep.run_date.Text = Now.ToString("MM/dd/yyyy")
        rep.run_time.Text = Now.ToString("HH:mm:ss")
        rep.trans_no.Text = "BILL NO."
        reportviewer.DocumentViewer1.DocumentSource = rep
        reportviewer.ShowDialog()
    End Sub
End Class