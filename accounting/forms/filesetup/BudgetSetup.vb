Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports DevExpress.XtraEditors
Imports libacctng.myFunctions
Public Class BudgetSetup
    Public dtMain As DataTable
    Public WorkMode As Boolean = False
    Public NewRec As Boolean = False
    Public dtAccounts As DataTable
    Sub EnableControls(Optional b As Boolean = True)
        pnlControls.Enabled = b
        btnSave.Visible = b
        btnUndo.Visible = b
        btnAdd.Enabled = Not b
        btnEdit.Enabled = Not b
        btnPrint.Enabled = Not b
        btnExit.Enabled = Not b
        btnSearch.Enabled = Not b
        WorkMode = b
        dgv.Enabled = Not b
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EnableControls()
        ClearFields()
        NewRec = True
    End Sub
    Sub ClearFields()
        pnlControls.Tag = ""
        For Each obj As Control In pnlControls.Controls
            If TypeOf obj Is TextBox Then
                obj.Text = ""
                obj.Tag = ""
                obj.AccessibleName = ""
            ElseIf TypeOf obj Is TextEdit Then
                Dim ob = CType(obj, TextEdit)
                ob.EditValue = ""
            End If
        Next
    End Sub
    Private Sub BudgetSetup_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case 113
                btnAdd.PerformClick()
            Case 114
                btnEdit.PerformClick()
            Case 115
                'btnCancel.PerformClick()
            Case 116
                btnPrint.PerformClick()
            Case 117
                btnSearch.PerformClick()
            Case 121
                btnExit.PerformClick()
        End Select
    End Sub

    Private Sub txtAccountCode_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtAccountCode.KeyDown
        Select Case e.KeyCode
            Case 13
                Dim b As New Browser
                b.SetDefaults()
                b.ShowDialog()
                If b.DialogResult = Windows.Forms.DialogResult.OK Then
                    txtAccountCode.Tag = b.Value
                    txtAccountCode.Text = b.Code
                    txtAccountName.Text = b.DisplayString
                    SendKeys.Send("{TAB}")
                    b.Dispose()
                End If
        End Select
    End Sub

    Private Sub txtAccountName_Enter(sender As Object, e As EventArgs) Handles txtAccountName.Enter
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtProject_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProject.KeyDown
        Select Case e.KeyCode
            Case 13
                Dim b As New Browser
                b.SetDataPropertyName("project_id", "project_code", "project_name")
                b.SetQuery("SELECT project_id, project_code, project_name from lib_erp_project", Browser.Database.FileSetup)
                b.ShowDialog()
                If b.DialogResult = Windows.Forms.DialogResult.OK Then
                    txtProject.Tag = b.Value
                    txtProject.Text = b.Code
                    b.Dispose()
                End If
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub txtDepartment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDepartment.KeyDown
        Select Case e.KeyCode
            Case 13
                Dim b As New Browser
                b.SetDataPropertyName("department_id", "department_code", "department_name")
                b.SetQuery("SELECT department_id, department_code, department_name from lib_erp_department", Browser.Database.FileSetup)
                b.ShowDialog()
                If b.DialogResult = Windows.Forms.DialogResult.OK Then
                    txtDepartment.Tag = b.Value
                    txtDepartment.Text = b.Code
                    b.Dispose()
                End If
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub txtMonth_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMonth.KeyDown
        Select Case e.KeyCode
            Case 13
                Dim b As New Browser
                b.SetDataPropertyName("month_id", "month_code", "month_name")
                b.SetQuery("SELECT 
                            1 as month_id, '01' as month_code, 'January' as month_name
                            union select 2 as month_id, '02' as month_code, 'Feburary' as month_name 
                            union select 3 as month_id, '03' as month_code, 'March' as month_name 
                            union select 4 as month_id, '04' as month_code, 'April' as month_name 
                            union select 5 as month_id, '05' as month_code, 'May' as month_name 
                            union select 6 as month_id, '06' as month_code, 'June' as month_name 
                            union select 7 as month_id, '07' as month_code, 'July' as month_name 
                            union select 8 as month_id, '08' as month_code, 'August' as month_name 
                            union select 9 as month_id, '09' as month_code, 'September' as month_name 
                             union select 10 as month_id, '10' as month_code, 'October' as month_name 
                            union select 11 as month_id, '11' as month_code, 'Novermber' as month_name 
                            union select 12 as month_id, '12' as month_code, 'December' as month_name 
                            ", Browser.Database.FileSetup)
                b.ShowDialog()
                If b.DialogResult = Windows.Forms.DialogResult.OK Then
                    txtMonth.Tag = b.Value
                    txtMonth.AccessibleName = b.Code
                    txtMonth.Text = b.DisplayString
                    b.Dispose()
                End If
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub txtBook_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBook.KeyDown
        Select Case e.KeyCode
            Case 13
                'If txtMonth.Tag.ToString = "" And txtYear.Text = "" Then
                '    MsgBox("Set Month and Year first")
                '    Exit Sub
                'End If
                Dim b As New Browser
                b.SetDataPropertyName("book_id", "book_code", "book_name")
                b.SetQuery("SELECT book_id, book_code, book_name from lib_erp_book", Browser.Database.FileSetup)
                b.ShowDialog()
                If b.DialogResult = Windows.Forms.DialogResult.OK Then
                    txtBook.Tag = b.Value
                    txtBook.Text = b.Code
                    b.Dispose()
                End If
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub txtCurrency_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCurrency.KeyDown

        Select Case e.KeyCode
            Case 13
                If Val(txtMonth.Tag) = 0 And txtYear.Text = "" Then
                    MsgBox("Set Month and Year first")
                    txtMonth.Focus()
                    Exit Sub
                End If
                Dim b As New Browser
                b.SetDataPropertyName("currency_rate_id", "currency_code", "currency_name")
                b.SetQuery(String.Format("SELECT currency_rate_id, b.currency_code, b.currency_name from lib_erp_currency_rate a
                            left join lib_erp_currency b ON a.currency_id = b.currency_id
                            where effectivitydate LIKE '{0}-{1}%'", txtYear.Text, txtMonth.AccessibleName), Browser.Database.FileSetup)
                b.ShowDialog()
                If b.DialogResult = Windows.Forms.DialogResult.OK Then
                    txtCurrency.Tag = b.Value
                    txtCurrency.Text = b.Code
                    Dim dt As DataTable = FsQuery(String.Format("SELECT * FROM lib_erp_currency_rate WHERE currency_rate_id = {0}", txtCurrency.Tag))
                    txtExchange.EditValue = dt.Rows(0)("exchange_rate")
                    txtBased.EditValue = dt.Rows(0)("based_rate")
                    txtCurrency.AccessibleName = dt.Rows(0)("currency_id")
                    b.Dispose()
                End If
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Sub loadDGV()
        dtMain = FsQuery("SELECT 
                         a.budget_id,a.effectivitydate, b.book_id,b.book_code,b.book_id, c.account_id, c.account_code, c.account_name, d.project_id, d.project_code, d.project_name 
                         , e.department_id, e.department_code, e.department_name, f.currency_rate_id, f.currency_id, f.based_rate, f.exchange_rate, f.currency_code, f.currency_name 
                         , a.debit, a.debit_based, a.credit,a.credit_based, a.exchange_rate, a.based_rate
                         FROM lib_erp_budget a 
                         LEFT JOIN lib_erp_book b ON a.book_id = b.book_id 
                         LEFT JOIN lib_erp_chart c on a.account_id = c.account_id 
                         LEFT JOIN lib_erp_project d on a.project_id = d.project_id 
                         LEFT JOIN lib_erp_department e ON a.department_id = e.department_id 
                         LEFT JOIN 
                         (SELECT a.currency_rate_id, a.based_rate, a.effectivitydate, a.exchange_rate, b.currency_code, b.currency_id, b.currency_name FROM lib_erp_currency_rate a 
                         LEFT JOIN lib_erp_currency b on a.currency_id = b.currency_id) f on a.currency_rate_id = f.currency_rate_id")
        ds.Tables("budget").Clear()
        For Each row As DataRow In dtMain.Rows
            ds.Tables("budget").ImportRow(row)
        Next
        dgv.DataSource = ds.Tables("budget")
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub BudgetSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDGV()
        dtAccounts = FsQuery("SELECT account_id, account_code, account_name, chart_type  FROM lib_erp_chart a LEFT JOIN lib_acc_chart_class b on a.chart_class_id = b.chart_class_id WHERE chart_type in ('I', 'E')")
    End Sub

    Private Sub txtAccountCode_TextChanged(sender As Object, e As EventArgs) Handles txtAccountCode.TextChanged, txtProject.TextChanged, txtMonth.TextChanged, txtDepartment.TextChanged, txtCurrency.TextChanged, txtBook.TextChanged
        If sender.Text = "" Then
            sender.Tag = ""
            sender.AccessibleName = ""
            sender.Text = ""
            If sender.Name = "txtAccountCode" Then
                txtAccountName.Text = ""
            ElseIf sender.Name = "txtCurrency" Then
                txtExchange.EditValue = 0
                txtBased.EditValue = 0
            End If
        End If
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs)
        EnableControls(False)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub BudgetSetup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If WorkMode Then
            If MsgBox("You have unsaved work. Are you sure you want to close?", vbQuestion + vbYesNo, "Closing Budget Setup") = vbYes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        NewRec = False
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtMonth.AccessibleName Is Nothing Or txtMonth.AccessibleName = "" Then
            MsgBox("Set Month First")
            txtMonth.Focus()
            Exit Sub
        ElseIf txtYear.Text = "" Then
            MsgBox("Set Year First")
            txtYear.Focus()
            Exit Sub
        ElseIf txtBook.Text = "" Then
            MsgBox("Set Book First")
            txtYear.Focus()
            Exit Sub
        ElseIf txtCurrency.Text = "" Then
            MsgBox("Set Currency First")
            txtYear.Focus()
            Exit Sub
        ElseIf txtAccountCode.Tag = "" Then
            MsgBox("Choose Account")
            txtAccountCode.Focus()
            Exit Sub
        End If

        Dim dict As New Dictionary(Of String, String)
        Dim budget_id As String = ""
        If Not pnlControls.Tag Is Nothing Then
            budget_id = pnlControls.Tag
        End If
        Dim company_id As String = main.Sys_Default(0)("company_id").ToString()
        dict.Add("budget_id", budget_id)
        dict.Add("account_id", txtAccountCode.Tag)
        dict.Add("project_id", txtProject.Tag)
        dict.Add("department_id", txtDepartment.Tag)
        dict.Add("currency_id", txtCurrency.AccessibleName)
        dict.Add("currency_rate_id", txtCurrency.Tag)
        dict.Add("exchange_rate", txtExchange.EditValue.ToString())
        dict.Add("based_rate", txtBased.EditValue.ToString())
        dict.Add("debit", txtDebit.EditValue.ToString())
        dict.Add("debit_based", txtDebitBased.EditValue.ToString())
        dict.Add("credit", txtCredit.EditValue.ToString())
        dict.Add("credit_based", txtCreditBsaed.EditValue.ToString())
        dict.Add("book_id", txtBook.Tag)
        dict.Add("effectivitydate", String.Format("{0}-{1}-01", txtYear.Text, txtMonth.AccessibleName))
        dict.Add("company_id", company_id)
        Dim qry As String = ""
        If NewRec Then
            qry = ATGenerateQuery("Insert", "lib_erp_budget", dict, Environment.MachineName, Environment.UserName, main.log_id, budget_id, "budget_id")
        Else
            qry = ATGenerateQuery("Update", "lib_erp_budget", dict, Environment.MachineName, Environment.UserName, main.log_id, budget_id, "budget_id")
        End If
        Dim dtQuery As DataTable = FsQuery(qry)
        If dtQuery.Rows.Count > 0 Then
            MsgBox("Save Successfully")
        End If
        loadDGV()
    End Sub

    Sub CheckChartType()
        If Not dtAccounts Is Nothing Then
            If dtAccounts.Rows.Count > 0 Then
                Dim row() As DataRow = dtAccounts.Select(String.Format("account_id = {0}", ifNull(txtAccountCode.Tag, "")))
                If row.Length = 1 Then
                    If row(0)("chart_type") = "I" Then
                        txtDebit.Enabled = False
                        txtCredit.Enabled = True
                    Else
                        txtDebit.Enabled = True
                        txtCredit.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        If dgv.Rows.Count > 0 Then
            Dim budget_id = Val(dgv.Item(0, dgv.CurrentRow.Index).Value)
            Dim rows() As DataRow = dtMain.Select(String.Format("budget_id = {0}", budget_id))
            txtAccountCode.Tag = ifNull(rows(0)("account_id"), "")
            txtAccountCode.Text = ifNull(rows(0)("account_code"), "")
            txtAccountName.Text = ifNull(rows(0)("account_name"), "")
            txtProject.Tag = ifNull(rows(0)("project_id"), "")
            txtProject.Text = ifNull(rows(0)("project_code"), "")
            txtDepartment.Tag = ifNull(rows(0)("department_id"), "")
            txtDepartment.Text = ifNull(rows(0)("department_code"), "")
            txtDebit.EditValue = ifNull(rows(0)("debit"), "")
            txtDebitBased.EditValue = ifNull(rows(0)("debit_based"), "")
            txtCredit.EditValue = ifNull(rows(0)("credit"), "")
            txtCreditBsaed.EditValue = ifNull(rows(0)("credit_based"), "")
            txtExchange.EditValue = ifNull(rows(0)("exchange_rate"), "")
            txtBased.EditValue = ifNull(rows(0)("based_rate"), "")
            txtMonth.Tag = ifNull(Val(CDate(rows(0)("effectivitydate")).Date.ToString("MM")), "")
            txtMonth.AccessibleName = CDate(rows(0)("effectivitydate")).Date.ToString("MM")
            Dim month As String = ""
            Select Case ifNull(Val(CDate(rows(0)("effectivitydate")).Date.ToString("MM")), "")
                Case 1
                    month = "January"
                Case 2
                    month = "February"
                Case 3
                    month = "March"
                Case 4
                    month = "April"
                Case 5
                    month = "May"
                Case 6
                    month = "June"
                Case 7
                    month = "July"
                Case 8
                    month = "August"
                Case 9
                    month = "September"
                Case 10
                    month = "October"
                Case 11
                    month = "November"
                Case 12
                    month = "December"
                Case Else
                    month = ""
            End Select
            txtMonth.Text = month
            txtYear.Text = CDate(rows(0)("effectivitydate")).Date.ToString("yyyy")
            txtBook.Tag = ifNull(rows(0)("book_id"), "")
            txtBook.Text = ifNull(rows(0)("book_code"), "")
            txtCurrency.Tag = ifNull(rows(0)("currency_rate_id"), "")
            txtCurrency.AccessibleName = ifNull(rows(0)("currency_id"), "")
            txtCurrency.Text = ifNull(rows(0)("currency_code"), "")
        End If
    End Sub

    Private Sub txtAccountCode_Leave(sender As Object, e As EventArgs) Handles txtAccountCode.Leave
        If txtAccountCode.Text <> "" Then
            CheckChartType()
        End If
    End Sub


End Class