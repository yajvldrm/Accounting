Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports MySql.Data.MySqlClient
Public Class ClosingNominalAccount

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ClosingNominalAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt = getNominalAccounts(txtDate.Value.ToString("yyyy-MM-dd"))
        Dim dt_currency_availability = CheckCurrencyAvailability(_serverDBMain, txtDate.Value.ToString("yyyy-MM-dd"))
        If dt_currency_availability.Rows.Count > 0 Then
            Dim currencyList As New List(Of String)
            For Each dr As DataRow In dt_currency_availability.Rows
                If dr.Item("wRate").ToString = "0" Then
                    currencyList.Add(dr.Item("currency_code"))
                End If
            Next
            If currencyList.Count > 0 Then
                Dim str As String = ""
                For Each c In currencyList
                    str &= vbNewLine & c
                Next
                Dim res = MsgBox("Unable to Create Transaction. Currency Rate Not Properly Setup." &
                       vbNewLine & "Currency Need to Setup : " &
                       str & "Want to Setup the Currency Rate?", MsgBoxStyle.YesNo, "Unable to Proceed")
                If res = MsgBoxResult.Yes Then
                    currency_rate.InitialiseMyForm(currency_rate)
                    currency_rate.MyLogID = main.log_id
                    showForm(currency_rate, main)
                End If
            Else
                If dt.Rows.Count > 0 Then
                    'Dim queryBook = (From dr In (From d In dt.AsEnumerable Select New With {.book_id = d("book_id")}) Select dr.book_id Distinct)
                    Dim lstBook = groupDataTableToList(dt, "book_id,currency_id")
                    For Each book In lstBook
                        Dim book_id As String = book.Item("book_id").ToString
                        Dim trans_no As String = ""
                        Dim tmp_sql As String = "call getnewtransno('5','" & book_id & "','" & txtDate.Value.ToString("MM") & "','" & txtDate.Value.ToString("yyyy") & "')"
                        Dim tmp_dt As DataTable = Query(tmp_sql)
                        If tmp_dt.Rows.Count > 0 Then
                            trans_no = tmp_dt.Rows(0).Item("trans_no_new").ToString
                            For Each currency In book.Item("grouped")
                                Dim currency_id As String = currency.Item("currency_id").ToString
                                Dim dicHeader As New Dictionary(Of String, String)
                                dicHeader.Add("trans_id", "")
                                dicHeader.Add("trans_no", trans_no)
                                dicHeader.Add("book_id", book_id)
                                dicHeader.Add("journal_id", 5)
                                dicHeader.Add("trans_date", txtDate.Value.ToString("yyyy-MM-dd"))
                                dicHeader.Add("currency_id", currency_id)
                                dicHeader.Add("exchange_rate", CDec(currency.Item("datas")(0).Item("exchange_rate").ToString))
                                dicHeader.Add("based_rate", CDec(currency.Item("datas")(0).Item("based_rate").ToString))

                                Dim amount_debit = dt.Compute("SUM(debit)", String.Format("book_id = {0} AND currency_id = {1}", book_id, currency_id))
                                Dim amount_credit = dt.Compute("SUM(credit)", String.Format("book_id = {0} AND currency_id = {1}", book_id, currency_id))

                                Dim amount_debit_based = dt.Compute("SUM(debit_based)", String.Format("book_id = {0} AND currency_id = {1}", book_id, currency_id))
                                Dim amount_credit_based = dt.Compute("SUM(credit_based)", String.Format("book_id = {0} AND currency_id = {1}", book_id, currency_id))

                                If amount_debit > amount_credit Then
                                    dicHeader.Add("amount", amount_debit)
                                    dicHeader.Add("amount_based", amount_debit_based)
                                Else
                                    dicHeader.Add("amount", amount_credit)
                                    dicHeader.Add("amount_based", amount_credit_based)
                                End If

                                Dim sql_header_save As String = ATGenerateQuery("Insert", "trans_header", dicHeader, Environment.MachineName, Environment.UserName, main.log_id)
                                Dim dt_header_save As DataTable = Query(sql_header_save)

                                If dt_header_save.Rows.Count > 0 Then
                                    Dim trans_id As String = dt_header_save.Rows(0).Item("return_id").ToString
                                    Dim drs = dt.Select(String.Format("book_id = {0} AND currency_id = {1}", book_id, currency_id))
                                    If drs.Length > 0 Then
                                        Dim newDt = dt.Clone
                                        newDt.Clear()
                                        For Each dr In drs
                                            newDt.ImportRow(dr)
                                        Next
                                        Dim lstAccount = groupDataTableToList(newDt, "project_id,department_id,allocation_id")
                                        Dim sql_jbooks_save As String = ""
                                        Dim debit As Decimal = 0
                                        Dim credit As Decimal = 0
                                        Dim debit_based As Decimal = 0
                                        Dim credit_based As Decimal = 0
                                        For Each project In lstAccount
                                            Dim project_id As String = project.Item("project_id").ToString
                                            For Each department In project.Item("grouped")
                                                Dim department_id As String = department.Item("department_id").ToString
                                                For Each allocation In department.Item("grouped")
                                                    Dim allocation_id As String = allocation.Item("allocation_id").ToString
                                                    For Each account In allocation.Item("datas")
                                                        Dim account_id As String = account.Item("account_id")
                                                        Dim dicJBooks As New Dictionary(Of String, String)
                                                        dicJBooks.Add("jbooks_id", "")
                                                        dicJBooks.Add("trans_id", trans_id)
                                                        dicJBooks.Add("project_id", project_id)
                                                        dicJBooks.Add("department_id", department_id)
                                                        dicJBooks.Add("allocation_id", allocation_id)
                                                        dicJBooks.Add("account_id", account_id)
                                                        dicJBooks.Add("currency_id", currency_id)
                                                        dicJBooks.Add("exchange_rate", dicHeader.Item("exchange_rate"))
                                                        dicJBooks.Add("based_rate", dicHeader.Item("based_rate"))
                                                        dicJBooks.Add("debit", CDec(account.Item("credit").ToString))
                                                        dicJBooks.Add("credit", CDec(account.Item("debit").ToString))
                                                        dicJBooks.Add("debit_based", CDec(account.Item("credit_based").ToString))
                                                        dicJBooks.Add("credit_based", CDec(account.Item("debit_based").ToString))
                                                        sql_jbooks_save &= ATGenerateQuery("Insert", "trans_jbooks", dicJBooks, Environment.MachineName, Environment.UserName, main.log_id)
                                                        debit += CDec(dicJBooks.Item("debit").ToString)
                                                        credit += CDec(dicJBooks.Item("credit").ToString)
                                                        debit_based += CDec(dicJBooks.Item("debit_based").ToString)
                                                        credit_based += CDec(dicJBooks.Item("credit_based").ToString)
                                                    Next
                                                Next
                                            Next
                                        Next
                                        Dim dicRetained As New Dictionary(Of String, String)
                                        dicRetained.Add("jbooks_id", "")
                                        dicRetained.Add("trans_id", trans_id)
                                        dicRetained.Add("currency_id", currency_id)
                                        dicRetained.Add("account_id", main.Sys_Default.Rows(0).Item("retained_account_id").ToString)
                                        dicRetained.Add("exchange_rate", dicHeader.Item("exchange_rate"))
                                        dicRetained.Add("based_rate", dicHeader.Item("based_rate"))
                                        dicRetained.Add("debit", 0)
                                        dicRetained.Add("credit", 0)
                                        dicRetained.Add("debit_based", 0)
                                        dicRetained.Add("credit_based", 0)
                                        If debit > credit Then
                                            debit -= credit
                                            credit = 0
                                        Else
                                            credit -= debit
                                            debit = 0
                                        End If
                                        If debit_based > credit_based Then
                                            debit_based -= credit_based
                                            credit_based = 0
                                        Else
                                            credit_based -= debit_based
                                            debit_based = 0
                                        End If
                                        dicRetained.Item("debit") = credit
                                        dicRetained.Item("credit") = debit
                                        dicRetained.Item("debit_based") = credit_based
                                        dicRetained.Item("credit_based") = debit_based
                                        sql_jbooks_save &= ATGenerateQuery("Insert", "trans_jbooks", dicRetained, Environment.MachineName, Environment.UserName, main.log_id)
                                        Dim dt_jbooks_save As DataTable = Query(sql_jbooks_save)
                                    End If
                                End If
                            Next
                        End If
                    Next

                Else
                    MsgBox("No Records Found")
                End If
            End If
        End If
    End Sub
    Private Function getNominalAccounts(ByVal asOfDate As String) As DataTable
        Dim dt As New DataTable
        Dim conn = generateConnection(_serverDBMain)
        conn.Open()
        Using cmd As New MySqlCommand With {.Connection = conn, .CommandType = CommandType.StoredProcedure, .CommandText = "getNominalAccounts"}
            cmd.Parameters.AddWithValue("@_asOfDate", asOfDate)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
        End Using
        conn.Close()
        Return dt
    End Function
    Private Function CheckCurrencyAvailability(ByVal db As String, ByVal asOfDate As String) As DataTable
        Dim dt As New DataTable
        Dim conn = generateConnection(_serverDBFS)
        conn.Open()
        Using cmd As New MySqlCommand With {.Connection = conn, .CommandType = CommandType.StoredProcedure, .CommandText = "CheckCurrencyAvailability"}
            cmd.Parameters.AddWithValue("@_dbMain", db)
            cmd.Parameters.AddWithValue("@_asOfDate", asOfDate)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
        End Using
        conn.Close()
        Return dt
    End Function
End Class