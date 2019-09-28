Imports Microsoft.Office.Interop

Public Class ClassFileSetupExcel
    Public Shared Function CreateExcelTemplate(ByVal TemplateName As String, ByVal ModuleID As String, ByVal DS As DataSet) As Excel.Worksheet
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
        If ModuleID = "allocation" Then
            xlWorkSheet.Cells(rowCurrent, 8) = "Allocation"
            xlWorkSheet.Cells(rowCurrent, 9) = "Allocation Name"
            xlWorkSheet.Range(xlWorkSheet.Cells(rowCurrent, 1), xlWorkSheet.Cells(rowCurrent, 9)).Font.Bold = True
            rowCurrent += 1
            For Each drHead As DataRow In DS.Tables("Head").Rows
                xlWorkSheet.Cells(rowCurrent, 1) = drHead.Item("at_id").ToString
                xlWorkSheet.Cells(rowCurrent, 2) = drHead.Item("transmode").ToString
                xlWorkSheet.Cells(rowCurrent, 3) = drHead.Item("at_date_date").ToString
                xlWorkSheet.Cells(rowCurrent, 4) = drHead.Item("at_date_time").ToString
                xlWorkSheet.Cells(rowCurrent, 5) = drHead.Item("username").ToString
                xlWorkSheet.Cells(rowCurrent, 6) = drHead.Item("machine_name").ToString
                xlWorkSheet.Cells(rowCurrent, 7) = drHead.Item("machine_user").ToString
                xlWorkSheet.Cells(rowCurrent, 8) = drHead.Item("allocation_code").ToString
                xlWorkSheet.Cells(rowCurrent, 9) = drHead.Item("allocation_name").ToString
                rowCurrent += 1
                xlWorkSheet.Cells(rowCurrent, 2) = "ID"
                xlWorkSheet.Cells(rowCurrent, 3) = "Process"
                xlWorkSheet.Cells(rowCurrent, 4) = "Username"
                xlWorkSheet.Cells(rowCurrent, 5) = "Computer"
                xlWorkSheet.Cells(rowCurrent, 6) = "User"
                xlWorkSheet.Cells(rowCurrent, 7) = "Account"
                xlWorkSheet.Cells(rowCurrent, 8) = "Account Name"
                xlWorkSheet.Range(xlWorkSheet.Cells(rowCurrent, 2), xlWorkSheet.Cells(rowCurrent, 8)).Font.Bold = True
                rowCurrent += 1
                Dim drDetails = DS.Tables("Detail").Select(String.Format("at_id = '{0}'", drHead.Item("at_id").ToString))
                If drDetails.Count > 0 Then
                    For Each drDetail As DataRow In drDetails
                        xlWorkSheet.Cells(rowCurrent, 2) = drDetail.Item("at_id").ToString
                        xlWorkSheet.Cells(rowCurrent, 3) = drDetail.Item("transmode").ToString
                        xlWorkSheet.Cells(rowCurrent, 4) = drDetail.Item("username").ToString
                        xlWorkSheet.Cells(rowCurrent, 5) = drDetail.Item("machine_name").ToString
                        xlWorkSheet.Cells(rowCurrent, 6) = drDetail.Item("machine_user").ToString
                        xlWorkSheet.Cells(rowCurrent, 7) = drDetail.Item("account_code").ToString
                        xlWorkSheet.Cells(rowCurrent, 8) = drDetail.Item("account_name").ToString
                        rowCurrent += 1
                    Next
                End If
            Next
        ElseIf ModuleID = "chart" Then
            xlWorkSheet.Cells(rowCurrent, 8) = "Account"
            xlWorkSheet.Cells(rowCurrent, 9) = "Account Name"
            xlWorkSheet.Cells(rowCurrent, 10) = "Chart Class"
            xlWorkSheet.Cells(rowCurrent, 11) = "Validation"
            xlWorkSheet.Cells(rowCurrent, 12) = "Description"
            xlWorkSheet.Range(xlWorkSheet.Cells(rowCurrent, 1), xlWorkSheet.Cells(rowCurrent, 12)).Font.Bold = True
            rowCurrent += 1
            For Each drHead As DataRow In DS.Tables("Head").Rows
                xlWorkSheet.Cells(rowCurrent, 1) = drHead.Item("at_id").ToString
                xlWorkSheet.Cells(rowCurrent, 2) = drHead.Item("transmode").ToString
                xlWorkSheet.Cells(rowCurrent, 3) = drHead.Item("at_date_date").ToString
                xlWorkSheet.Cells(rowCurrent, 4) = drHead.Item("at_date_time").ToString
                xlWorkSheet.Cells(rowCurrent, 5) = drHead.Item("username").ToString
                xlWorkSheet.Cells(rowCurrent, 6) = drHead.Item("machine_name").ToString
                xlWorkSheet.Cells(rowCurrent, 7) = drHead.Item("machine_user").ToString
                xlWorkSheet.Cells(rowCurrent, 8) = drHead.Item("account_code").ToString
                xlWorkSheet.Cells(rowCurrent, 9) = drHead.Item("account_name").ToString
                xlWorkSheet.Cells(rowCurrent, 10) = drHead.Item("chart_class_name").ToString
                xlWorkSheet.Cells(rowCurrent, 11) = drHead.Item("validation").ToString
                xlWorkSheet.Cells(rowCurrent, 12) = drHead.Item("description").ToString
                rowCurrent += 1
                xlWorkSheet.Cells(rowCurrent, 2) = "ID"
                xlWorkSheet.Cells(rowCurrent, 3) = "Process"
                xlWorkSheet.Cells(rowCurrent, 4) = "Username"
                xlWorkSheet.Cells(rowCurrent, 5) = "Computer"
                xlWorkSheet.Cells(rowCurrent, 6) = "User"
                xlWorkSheet.Cells(rowCurrent, 7) = "Chart Group"
                xlWorkSheet.Cells(rowCurrent, 8) = "Chart Group Name"
                xlWorkSheet.Range(xlWorkSheet.Cells(rowCurrent, 2), xlWorkSheet.Cells(rowCurrent, 8)).Font.Bold = True
                rowCurrent += 1
                Dim drDetails = DS.Tables("Detail").Select(String.Format("at_id = '{0}'", drHead.Item("at_id").ToString))
                If drDetails.Count > 0 Then
                    For Each drDetail As DataRow In drDetails
                        xlWorkSheet.Cells(rowCurrent, 2) = drDetail.Item("at_id").ToString
                        xlWorkSheet.Cells(rowCurrent, 3) = drDetail.Item("transmode").ToString
                        xlWorkSheet.Cells(rowCurrent, 4) = drDetail.Item("username").ToString
                        xlWorkSheet.Cells(rowCurrent, 5) = drDetail.Item("machine_name").ToString
                        xlWorkSheet.Cells(rowCurrent, 6) = drDetail.Item("machine_user").ToString
                        xlWorkSheet.Cells(rowCurrent, 7) = drDetail.Item("chart_group_code").ToString
                        xlWorkSheet.Cells(rowCurrent, 8) = drDetail.Item("chart_group_name").ToString
                        rowCurrent += 1
                    Next
                End If
            Next
        ElseIf ModuleID = "general" Then
            xlWorkSheet.Cells(rowCurrent, 8) = "General"
            xlWorkSheet.Cells(rowCurrent, 9) = "General Name"
            xlWorkSheet.Cells(rowCurrent, 10) = "Category"
            xlWorkSheet.Cells(rowCurrent, 11) = "Date"
            xlWorkSheet.Cells(rowCurrent, 12) = "Address 1"
            xlWorkSheet.Cells(rowCurrent, 13) = "Address 2"
            xlWorkSheet.Cells(rowCurrent, 14) = "Address 3"
            xlWorkSheet.Cells(rowCurrent, 15) = "Address 4"
            xlWorkSheet.Cells(rowCurrent, 16) = "Attention"
            xlWorkSheet.Cells(rowCurrent, 17) = "Contact Person"
            xlWorkSheet.Cells(rowCurrent, 18) = "Tel No"
            xlWorkSheet.Cells(rowCurrent, 19) = "Fax No"
            xlWorkSheet.Cells(rowCurrent, 20) = "Cell No"
            xlWorkSheet.Cells(rowCurrent, 21) = "TIN"
            xlWorkSheet.Cells(rowCurrent, 22) = "Email"
            xlWorkSheet.Cells(rowCurrent, 23) = "Website"
            xlWorkSheet.Cells(rowCurrent, 24) = "Terms"
            xlWorkSheet.Cells(rowCurrent, 25) = "Credit Amount"
            xlWorkSheet.Cells(rowCurrent, 26) = "No of Days"
            xlWorkSheet.Cells(rowCurrent, 27) = "Remarks"
            xlWorkSheet.Cells(rowCurrent, 28) = "Status"
            xlWorkSheet.Cells(rowCurrent, 29) = "Industry"
            xlWorkSheet.Cells(rowCurrent, 30) = "RDO"
            xlWorkSheet.Range(xlWorkSheet.Cells(rowCurrent, 1), xlWorkSheet.Cells(rowCurrent, 12)).Font.Bold = True
            rowCurrent += 1
            For Each drHead As DataRow In DS.Tables("Head").Rows
                xlWorkSheet.Cells(rowCurrent, 1) = drHead.Item("at_id").ToString
                xlWorkSheet.Cells(rowCurrent, 2) = drHead.Item("transmode").ToString
                xlWorkSheet.Cells(rowCurrent, 3) = drHead.Item("at_date_date").ToString
                xlWorkSheet.Cells(rowCurrent, 4) = drHead.Item("at_date_time").ToString
                xlWorkSheet.Cells(rowCurrent, 5) = drHead.Item("username").ToString
                xlWorkSheet.Cells(rowCurrent, 6) = drHead.Item("machine_name").ToString
                xlWorkSheet.Cells(rowCurrent, 7) = drHead.Item("machine_user").ToString
                xlWorkSheet.Cells(rowCurrent, 8) = drHead.Item("general_code").ToString
                xlWorkSheet.Cells(rowCurrent, 9) = drHead.Item("general_name").ToString
                xlWorkSheet.Cells(rowCurrent, 10) = drHead.Item("category_name").ToString
                xlWorkSheet.Cells(rowCurrent, 11) = drHead.Item("date").ToString
                xlWorkSheet.Cells(rowCurrent, 12) = drHead.Item("address1").ToString
                xlWorkSheet.Cells(rowCurrent, 13) = drHead.Item("address2").ToString
                xlWorkSheet.Cells(rowCurrent, 14) = drHead.Item("address3").ToString
                xlWorkSheet.Cells(rowCurrent, 15) = drHead.Item("address4").ToString
                xlWorkSheet.Cells(rowCurrent, 16) = drHead.Item("attention").ToString
                xlWorkSheet.Cells(rowCurrent, 17) = drHead.Item("contact_person").ToString
                xlWorkSheet.Cells(rowCurrent, 18) = drHead.Item("tel_no").ToString
                xlWorkSheet.Cells(rowCurrent, 19) = drHead.Item("fax_no").ToString
                xlWorkSheet.Cells(rowCurrent, 20) = drHead.Item("cell_no").ToString
                xlWorkSheet.Cells(rowCurrent, 21) = drHead.Item("tin").ToString
                xlWorkSheet.Cells(rowCurrent, 22) = drHead.Item("email_add").ToString
                xlWorkSheet.Cells(rowCurrent, 23) = drHead.Item("website").ToString
                xlWorkSheet.Cells(rowCurrent, 24) = drHead.Item("terms_name").ToString
                xlWorkSheet.Cells(rowCurrent, 25) = drHead.Item("credit_amt").ToString
                xlWorkSheet.Cells(rowCurrent, 26) = drHead.Item("nodays").ToString
                xlWorkSheet.Cells(rowCurrent, 27) = drHead.Item("remarks").ToString
                xlWorkSheet.Cells(rowCurrent, 28) = drHead.Item("status").ToString
                xlWorkSheet.Cells(rowCurrent, 29) = drHead.Item("industry_name").ToString
                xlWorkSheet.Cells(rowCurrent, 30) = drHead.Item("rdo_code").ToString
                rowCurrent += 1
            Next
        End If
        Return xlWorkSheet
    End Function
End Class
