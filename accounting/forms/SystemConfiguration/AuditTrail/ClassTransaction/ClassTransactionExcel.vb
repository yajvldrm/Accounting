
Imports Microsoft.Office.Interop
Public Class ClassTransactionExcel
    Public Shared Function CreateExcelTemplate(ByVal TemplateName As String, ByVal JournalID As String, ByVal JBooks As List(Of Object)) As Excel.Worksheet
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        If xlWorkBook.Worksheets.Count = 0 Then
            xlWorkBook.Worksheets.Add()
        End If
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 2) = Trim(main.Sys_Default.Rows(0).Item("company_name").ToString.ToUpper)
        xlWorkSheet.Cells(2, 2) = "AUDIT TRAIL"
        xlWorkSheet.Cells(3, 2) = Trim(TemplateName)
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 2), xlWorkSheet.Cells(4, 2)).Font.Bold = True
        Dim rowCurrent As Integer = 5

        xlWorkSheet.Cells(rowCurrent, 1) = "ID"
        xlWorkSheet.Cells(rowCurrent, 2) = "Process"
        xlWorkSheet.Cells(rowCurrent, 3) = "Date"
        xlWorkSheet.Cells(rowCurrent, 4) = "Time"
        xlWorkSheet.Cells(rowCurrent, 5) = "Username"
        xlWorkSheet.Cells(rowCurrent, 6) = "Computer"
        xlWorkSheet.Cells(rowCurrent, 7) = "User"
        Select Case JournalID
            Case "1"
                xlWorkSheet.Cells(rowCurrent, 8) = "Invoicing No"
            Case "2"
                xlWorkSheet.Cells(rowCurrent, 8) = "OR No"
            Case "3"
                xlWorkSheet.Cells(rowCurrent, 8) = "Purchase No"
            Case "4"
                xlWorkSheet.Cells(rowCurrent, 8) = "Disbursement No"
            Case "5"
                xlWorkSheet.Cells(rowCurrent, 8) = "Journal No"
            Case "6"
                xlWorkSheet.Cells(rowCurrent, 8) = "Petty Cash No"
            Case "7"
                xlWorkSheet.Cells(rowCurrent, 8) = "Debit / Credit No"
        End Select
        xlWorkSheet.Cells(rowCurrent, 9) = "Date"
        xlWorkSheet.Cells(rowCurrent, 10) = "Book"
        xlWorkSheet.Cells(rowCurrent, 11) = "Journal"
        xlWorkSheet.Cells(rowCurrent, 12) = "Exchange Rate"
        xlWorkSheet.Cells(rowCurrent, 13) = "Based Rate"
        xlWorkSheet.Cells(rowCurrent, 14) = "Amount"
        xlWorkSheet.Cells(rowCurrent, 15) = "Amount Based"
        xlWorkSheet.Cells(rowCurrent, 16) = "Particulars"
        Select Case JournalID
            Case "1"
                xlWorkSheet.Cells(rowCurrent, 17) = "Client"
                xlWorkSheet.Cells(rowCurrent, 18) = "Client Name"
                xlWorkSheet.Cells(rowCurrent, 19) = "SI No"
                xlWorkSheet.Cells(rowCurrent, 20) = "DR No"
                xlWorkSheet.Cells(rowCurrent, 21) = "PO No"
                xlWorkSheet.Cells(rowCurrent, 22) = "Terms"
                xlWorkSheet.Cells(rowCurrent, 23) = "No of Days"
                xlWorkSheet.Cells(rowCurrent, 24) = "Due Date"
            Case "2"
                xlWorkSheet.Cells(rowCurrent, 17) = "Customer"
                xlWorkSheet.Cells(rowCurrent, 18) = "Customer Name"
                xlWorkSheet.Cells(rowCurrent, 19) = "SI No"
            Case "3"
                xlWorkSheet.Cells(rowCurrent, 17) = "Supplier"
                xlWorkSheet.Cells(rowCurrent, 18) = "Supplier Name"
                xlWorkSheet.Cells(rowCurrent, 19) = "SI No"
                xlWorkSheet.Cells(rowCurrent, 20) = "RR No"
                xlWorkSheet.Cells(rowCurrent, 21) = "PO No"
                xlWorkSheet.Cells(rowCurrent, 22) = "Terms"
                xlWorkSheet.Cells(rowCurrent, 23) = "No of Days"
                xlWorkSheet.Cells(rowCurrent, 24) = "Due Date"
            Case "4"
                xlWorkSheet.Cells(rowCurrent, 17) = "Payee"
                xlWorkSheet.Cells(rowCurrent, 18) = "Payee Name"
                xlWorkSheet.Cells(rowCurrent, 19) = "SI No"
                xlWorkSheet.Cells(rowCurrent, 20) = "RR No"
            Case "5"
                xlWorkSheet.Cells(rowCurrent, 17) = "Client"
                xlWorkSheet.Cells(rowCurrent, 18) = "Client Name"
            Case "6"
                xlWorkSheet.Cells(rowCurrent, 17) = "Customer"
                xlWorkSheet.Cells(rowCurrent, 18) = "Customer Name"
                xlWorkSheet.Cells(rowCurrent, 19) = "Reflenish Date"
                xlWorkSheet.Cells(rowCurrent, 20) = "PO No"
                xlWorkSheet.Cells(rowCurrent, 21) = "DR No"
                xlWorkSheet.Cells(rowCurrent, 22) = "SI No"
                xlWorkSheet.Cells(rowCurrent, 23) = "Terms"
                xlWorkSheet.Cells(rowCurrent, 24) = "No of Days"
                xlWorkSheet.Cells(rowCurrent, 25) = "Due Date"
            Case "7"
                xlWorkSheet.Cells(rowCurrent, 17) = "Client"
                xlWorkSheet.Cells(rowCurrent, 18) = "Client Name"
        End Select
        xlWorkSheet.Range(xlWorkSheet.Cells(rowCurrent, 1), xlWorkSheet.Cells(rowCurrent, 24)).Font.Bold = True
        rowCurrent += 1
        For Each dicItem As Dictionary(Of String, Object) In JBooks
            Dim listData As List(Of Object) = dicItem.Item("datas")
            If listData.Count > 0 Then
                xlWorkSheet.Cells(rowCurrent, 1) = listData.Item(0).Item("a_at_id").ToString
                xlWorkSheet.Cells(rowCurrent, 2) = listData.Item(0).Item("a_transmode").ToString
                xlWorkSheet.Cells(rowCurrent, 3) = listData.Item(0).Item("a_at_date_date").ToString
                xlWorkSheet.Cells(rowCurrent, 4) = listData.Item(0).Item("a_at_date_time").ToString
                xlWorkSheet.Cells(rowCurrent, 5) = listData.Item(0).Item("a_username").ToString
                xlWorkSheet.Cells(rowCurrent, 6) = listData.Item(0).Item("a_machine_name").ToString
                xlWorkSheet.Cells(rowCurrent, 7) = listData.Item(0).Item("a_machine_user").ToString
                xlWorkSheet.Cells(rowCurrent, 8) = listData.Item(0).Item("a_trans_no").ToString
                xlWorkSheet.Cells(rowCurrent, 9) = listData.Item(0).Item("a_trans_date").ToString
                xlWorkSheet.Cells(rowCurrent, 10) = listData.Item(0).Item("a_book_code").ToString
                xlWorkSheet.Cells(rowCurrent, 11) = listData.Item(0).Item("a_journal_name").ToString
                xlWorkSheet.Cells(rowCurrent, 12) = listData.Item(0).Item("a_exchange_rate").ToString
                xlWorkSheet.Cells(rowCurrent, 13) = listData.Item(0).Item("a_based_rate").ToString
                xlWorkSheet.Cells(rowCurrent, 14) = listData.Item(0).Item("a_amount").ToString
                xlWorkSheet.Cells(rowCurrent, 15) = listData.Item(0).Item("a_amount_based").ToString
                xlWorkSheet.Cells(rowCurrent, 16) = listData.Item(0).Item("a_description").ToString
                xlWorkSheet.Cells(rowCurrent, 17) = listData.Item(0).Item("a_general_code").ToString
                xlWorkSheet.Cells(rowCurrent, 18) = listData.Item(0).Item("a_general_name").ToString
                Select Case JournalID
                    Case "1"
                        xlWorkSheet.Cells(rowCurrent, 19) = listData.Item(0).Item("b_si_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 20) = listData.Item(0).Item("b_dr_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 21) = listData.Item(0).Item("b_po_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 22) = listData.Item(0).Item("b_terms_name").ToString
                        xlWorkSheet.Cells(rowCurrent, 23) = listData.Item(0).Item("b_nodays").ToString
                        xlWorkSheet.Cells(rowCurrent, 24) = listData.Item(0).Item("b_due_date").ToString
                    Case "2"
                        xlWorkSheet.Cells(rowCurrent, 19) = listData.Item(0).Item("b_si_no").ToString
                    Case "3"
                        xlWorkSheet.Cells(rowCurrent, 19) = listData.Item(0).Item("b_si_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 20) = listData.Item(0).Item("b_rr_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 21) = listData.Item(0).Item("b_po_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 22) = listData.Item(0).Item("b_terms_name").ToString
                        xlWorkSheet.Cells(rowCurrent, 23) = listData.Item(0).Item("b_nodays").ToString
                        xlWorkSheet.Cells(rowCurrent, 24) = listData.Item(0).Item("b_due_date").ToString
                    Case "4"
                        xlWorkSheet.Cells(rowCurrent, 19) = listData.Item(0).Item("b_si_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 20) = listData.Item(0).Item("b_rr_no").ToString
                    Case "6"
                        xlWorkSheet.Cells(rowCurrent, 19) = listData.Item(0).Item("b_reflenish_date").ToString
                        xlWorkSheet.Cells(rowCurrent, 20) = listData.Item(0).Item("b_po_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 21) = listData.Item(0).Item("b_dr_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 22) = listData.Item(0).Item("b_si_no").ToString
                        xlWorkSheet.Cells(rowCurrent, 23) = listData.Item(0).Item("b_terms_name").ToString
                        xlWorkSheet.Cells(rowCurrent, 24) = listData.Item(0).Item("b_nodays").ToString
                        xlWorkSheet.Cells(rowCurrent, 25) = listData.Item(0).Item("b_due_date").ToString
                End Select
                rowCurrent += 1
                xlWorkSheet.Cells(rowCurrent, 2) = "ID"
                xlWorkSheet.Cells(rowCurrent, 3) = "Process"
                xlWorkSheet.Cells(rowCurrent, 4) = "Username"
                xlWorkSheet.Cells(rowCurrent, 5) = "Computer"
                xlWorkSheet.Cells(rowCurrent, 6) = "User"
                xlWorkSheet.Cells(rowCurrent, 7) = "Account Name"
                xlWorkSheet.Cells(rowCurrent, 8) = "Project"
                xlWorkSheet.Cells(rowCurrent, 9) = "Department"
                xlWorkSheet.Cells(rowCurrent, 10) = "Allocation"
                xlWorkSheet.Cells(rowCurrent, 11) = "Currency"
                xlWorkSheet.Cells(rowCurrent, 12) = "Exchange Rate"
                xlWorkSheet.Cells(rowCurrent, 13) = "Based Rate"
                xlWorkSheet.Cells(rowCurrent, 14) = "Debit"
                xlWorkSheet.Cells(rowCurrent, 15) = "Credit"
                xlWorkSheet.Cells(rowCurrent, 16) = "Debit Based"
                xlWorkSheet.Cells(rowCurrent, 17) = "Credit Based"
                xlWorkSheet.Cells(rowCurrent, 18) = "General"
                xlWorkSheet.Cells(rowCurrent, 19) = "General Name"
                xlWorkSheet.Cells(rowCurrent, 20) = "DN Ref"
                xlWorkSheet.Cells(rowCurrent, 21) = "Line Remarks"
                xlWorkSheet.Range(xlWorkSheet.Cells(rowCurrent, 2), xlWorkSheet.Cells(rowCurrent, 22)).Font.Bold = True
                rowCurrent += 1
                For Each dic As Dictionary(Of String, String) In listData
                    xlWorkSheet.Cells(rowCurrent, 2) = dic.Item("a_at_id").ToString
                    xlWorkSheet.Cells(rowCurrent, 3) = dic.Item("transmode").ToString
                    xlWorkSheet.Cells(rowCurrent, 4) = dic.Item("username").ToString
                    xlWorkSheet.Cells(rowCurrent, 5) = dic.Item("machine_name").ToString
                    xlWorkSheet.Cells(rowCurrent, 6) = dic.Item("machine_user").ToString
                    xlWorkSheet.Cells(rowCurrent, 7) = dic.Item("account_name").ToString
                    xlWorkSheet.Cells(rowCurrent, 8) = dic.Item("project_code").ToString
                    xlWorkSheet.Cells(rowCurrent, 9) = dic.Item("department_code").ToString
                    xlWorkSheet.Cells(rowCurrent, 10) = dic.Item("allocation_code").ToString
                    xlWorkSheet.Cells(rowCurrent, 11) = dic.Item("currency_name").ToString
                    xlWorkSheet.Cells(rowCurrent, 12) = dic.Item("exchange_rate").ToString
                    xlWorkSheet.Cells(rowCurrent, 13) = dic.Item("based_rate").ToString
                    xlWorkSheet.Cells(rowCurrent, 14) = dic.Item("debit").ToString
                    xlWorkSheet.Cells(rowCurrent, 15) = dic.Item("credit").ToString
                    xlWorkSheet.Cells(rowCurrent, 16) = dic.Item("debit_based").ToString
                    xlWorkSheet.Cells(rowCurrent, 17) = dic.Item("credit_based").ToString
                    xlWorkSheet.Cells(rowCurrent, 18) = dic.Item("general_code").ToString
                    xlWorkSheet.Cells(rowCurrent, 19) = dic.Item("general_name").ToString
                    xlWorkSheet.Cells(rowCurrent, 20) = dic.Item("ref_trans_no").ToString
                    xlWorkSheet.Cells(rowCurrent, 21) = dic.Item("line_remarks").ToString
                    rowCurrent += 1
                Next
            End If
        Next

        Return xlWorkSheet
    End Function
End Class
