Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports Microsoft.Office.Interop

Public Class begbal_det_new
    Public Property trans_no As String = ""
    Public Property trans_date As Date = Nothing
    Public Property general_name As String = ""
    Public Property line_remarks As String = ""
    Public Property amount As Decimal = 0.00
    Public Property si_no As String = ""
    Public Property rr_no As String = ""
    Public Property po_no As String = ""
    Public Property jbooks_id As String = ""

    Private Sub begbal_det_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_trans_no.Text = trans_no
        txt_trans_date.EditValue = trans_date
        txt_general_name.Text = general_name
        txt_line_remarks.EditValue = line_remarks
        txt_amount.Text = String.Format("{0:n2}", amount)
        txt_si_no.Text = si_no
        txt_rr_no.Text = rr_no
        txt_po_no.Text = po_no
        Dim col As New List(Of KeyValuePair(Of String, String))
        col.Add(New KeyValuePair(Of String, String)("@dbMain", _serverDBMain))
        col.Add(New KeyValuePair(Of String, String)("@dbFS", _serverDBFS))
        col.Add(New KeyValuePair(Of String, String)("@jbooks_id", jbooks_id))
        Dim dt As DataTable = ExecuteWithParameter("get_offsetting_schedule", ConnectionStringFS, CommandType.StoredProcedure, col)
        ds.Tables("get_offsetting_schedule").Clear()
        For Each dr As DataRow In dt.Rows
            ds.Tables("get_offsetting_schedule").ImportRow(dr)
        Next
        bs.DataSource = dt
    End Sub
    Private Sub PrintReport(ByVal printOption As Integer)
        Select Case printOption
            Case 1
                Try
                    lblLoad.Visible = True
                    ExcelReport()
                    MsgBox("Report Done")
                Catch ex As Exception
                    MsgBox(String.Format("Error Encountered: {0}", ex.Message))
                End Try
                lblLoad.Visible = False
            Case 2
                Dim rep As New print_offsetting_schedule()
                rep.trans_no.Value = trans_no
                rep.trans_date.Value = trans_date
                rep.general_name.Value = general_name
                rep.line_remarks.Value = line_remarks
                rep.amount.Value = amount
                rep.si_no.Value = si_no
                rep.rr_no.Value = rr_no
                rep.po_no.Value = po_no
                rep.ds.Tables("get_offsetting_schedule").Clear()
                For Each dr As DataRow In ds.Tables("get_offsetting_schedule").Rows
                    rep.ds.Tables("get_offsetting_schedule").ImportRow(dr)
                Next
                reportviewer.DocumentViewer1.DocumentSource = rep
                reportviewer.ShowDialog()
        End Select
    End Sub
    Private Sub ExcelReport()
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        xlApp.DisplayAlerts = False
        xlApp.Calculation = Excel.XlCalculation.xlCalculationManual
        xlWorkSheet = xlWorkBook.Worksheets(1)

        xlWorkSheet.Cells(1, 1) = "BILL HISTORY"
        ExcelRange(xlWorkSheet, 1, 1,, 6).Merge()
        ExcelRange(xlWorkSheet, 1, 1,, 6).Font.Bold = True
        ExcelRange(xlWorkSheet, 1, 1,, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Cells(3, 1) = "Vendor"
        xlWorkSheet.Cells(4, 1) = "Bill No"
        xlWorkSheet.Cells(5, 1) = "Memo"
        xlWorkSheet.Cells(6, 1) = "SI No"
        ExcelRange(xlWorkSheet, 3, 1, 6, 1).Font.Bold = True

        xlWorkSheet.Cells(3, 2) = general_name
        xlWorkSheet.Cells(4, 2) = trans_no
        xlWorkSheet.Cells(5, 2) = line_remarks
        xlWorkSheet.Cells(6, 2) = si_no
        ExcelRange(xlWorkSheet, 3, 2, 3, 4).Merge()
        ExcelRange(xlWorkSheet, 4, 2, 4, 4).Merge()

        xlWorkSheet.Cells(3, 5) = "Bill Amount"
        xlWorkSheet.Cells(4, 5) = "Date Received"
        ExcelRange(xlWorkSheet, 3, 5, 4, 5).Font.Bold = True

        xlWorkSheet.Cells(3, 6) = amount
        xlWorkSheet.Cells(4, 6) = trans_date
        ExcelRange(xlWorkSheet, 3, 6).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"

        xlWorkSheet.Cells(6, 3) = "D.R./R.R. No"
        xlWorkSheet.Cells(6, 5) = "PO No"
        ExcelRange(xlWorkSheet, 6, 3, 6, 5).Font.Bold = True

        xlWorkSheet.Cells(6, 4) = rr_no
        xlWorkSheet.Cells(6, 6) = po_no

        xlWorkSheet.Cells(8, 1) = "Date"
        xlWorkSheet.Cells(8, 2) = "Ref No"
        xlWorkSheet.Cells(8, 3) = "Debit"
        xlWorkSheet.Cells(8, 4) = "Credit"
        xlWorkSheet.Cells(8, 5) = "Balance"
        ExcelRange(xlWorkSheet, 8, 1, 8, 5).Font.Bold = True

        Dim current_row As Integer = 9
        For Each dr As DataRow In ds.Tables("get_offsetting_schedule").Rows
            xlWorkSheet.Cells(current_row, 1) = CDate(dr("trans_date")).ToString("MM/dd/yyyy")
            xlWorkSheet.Cells(current_row, 2) = dr("trans_no").ToString()
            xlWorkSheet.Cells(current_row, 3) = dr("debit").ToString()
            xlWorkSheet.Cells(current_row, 4) = dr("credit").ToString()
            xlWorkSheet.Cells(current_row, 5) = dr("running_balance").ToString()
            current_row += 1
        Next
        ExcelRange(xlWorkSheet, 9, 3, current_row - 1, 5).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
        ExcelRange(xlWorkSheet, 1, 1, 1, 6).ColumnWidth = 15
    End Sub
    Private Function ExcelRange(ByRef xlWorkSheet As Excel.Worksheet, ByRef fr As Integer, ByRef fc As Integer, Optional lr As Integer = -1, Optional lc As Integer = -1) As Excel.Range
        lr = If(lr < 0, fr, lr)
        lc = If(lc < 0, fc, lc)
        Return xlWorkSheet.Range(xlWorkSheet.Cells(fr, fc), xlWorkSheet.Cells(lr, lc))
    End Function
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim _printoption As New reportoption
        _printoption.targetForm = Me
        _printoption.Label1.Hide()
        _printoption.cbo_sort.Hide()
        _printoption.ShowDialog()
        If _printoption.DialogResult = Windows.Forms.DialogResult.OK Then
            If _printoption.PrintOption = "1" Then
                'excel
                PrintReport(1)
            Else
                'preview
                PrintReport(2)
            End If
        End If
    End Sub

    Private Sub dgMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellDoubleClick
        Dim drv As DataRowView = bs.Current
        If drv IsNot Nothing Then
            Dim dr As DataRow = drv.Row
            Dim journalID As String = ifNull(dr.Item("journal_id"), "").ToString
            Dim bookName As String = ifNull(dr.Item("book_name"), "").ToString
            Dim bookID As String = ifNull(dr.Item("book_id"), "").ToString
            Dim strNumberFormat As String = main.strNumberFormat
            Dim setDate As Date = CDate(dr.Item("trans_date").ToString)
            Dim trans_id As String = ifNull(dr.Item("trans_id"), "").ToString

            Dim frmSettings As New settings
            frmSettings.journal_id = dr.Item("journal_id")
            frmSettings.journal_code = dr.Item("journal_code")
            frmSettings.journal_name = dr.Item("journal_name")
            frmSettings.journal_id = dr.Item("journal_id")
            If main.Sys_Default.Rows.Count > 0 Then
                frmSettings.sys_beg = main.Sys_Default.Rows(0).Item("sys_beg")
                frmSettings.minDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
            End If
            frmSettings.init()
            frmSettings.cmbMonth.SelectedValue = setDate.Month
            frmSettings.numYear.Value = setDate.Year
            frmSettings.cmbBook.SelectedValue = bookID
            settings.bookNamex = bookName
            frmSettings.book_name = bookName
            Select Case journalID
                Case "1" 'IV
                    Dim frmTransaction As New transactionib
                    frmTransaction.initializeDecimalPlaces(strNumberFormat)
                    frmSettings.frmTransaction = frmTransaction
                    frmTransaction.mySettings = frmSettings
                    frmTransaction.BookID = bookID
                    frmTransaction.JournalID = journalID
                    frmTransaction.Year = setDate.Year
                    frmTransaction.Month = setDate.Month
                    frmTransaction.Refresh()
                    For Each dra As DataRow In frmTransaction.ds.Tables("trans").Rows
                        If dra.Item("trans_id") = trans_id Then
                            frmTransaction.clear_control()
                            NewControls.bindControl(frmTransaction.hdr, dra, True)
                            frmTransaction.currentDr = dra
                            'frmTransaction.disable_control(dra.Item("user_id").ToString = main.user_id, dra)
                            NewControls.refreshRecordDet(frmTransaction.dgjbooks, frmTransaction.ds, frmTransaction.txt_trans_id)
                            If CDec(frmTransaction.txtAmountBased.EditValue) < 0 Then
                                frmTransaction.txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(frmTransaction.txtAmountBased.EditValue), main.DecimalPlaces)
                            ElseIf CDec(frmTransaction.txtAmountBased.EditValue) > 0 Then
                                frmTransaction.txt_amount_in_word.Text = amount_words(frmTransaction.txtAmountBased.EditValue, main.DecimalPlaces)
                            Else
                                frmTransaction.txt_amount_in_word.Text = ""
                            End If
                            frmTransaction.computeTotal()
                            frmTransaction.pkID = dra.Item("trans_id")
                        End If
                    Next
                    frmTransaction.btnAdd.Visible = False
                    frmTransaction.btnPrint.Visible = False
                    frmTransaction.btnSearch.Visible = False
                    frmTransaction.btnPrevious.Visible = False
                    frmTransaction.btnNext.Visible = False
                    frmTransaction.btnSettings.Visible = False
                    frmTransaction.ShowDialog()
                    'showForm(frmTransaction, main)
                Case "2" 'CR
                    Dim frmTransaction As New transactioncr
                    frmTransaction.initializeDecimalPlaces(strNumberFormat)
                    frmSettings.frmTransaction = frmTransaction
                    frmTransaction.mySettings = frmSettings
                    frmTransaction.BookID = bookID
                    frmTransaction.JournalID = journalID
                    frmTransaction.Year = setDate.Year
                    frmTransaction.Month = setDate.Month
                    frmTransaction.Refresh()
                    For Each dra As DataRow In frmTransaction.ds.Tables("trans").Rows
                        If dra.Item("trans_id") = trans_id Then
                            frmTransaction.clear_control()
                            NewControls.bindControl(frmTransaction.hdr, dra, True)
                            frmTransaction.currentDr = dra
                            'frmTransaction.disable_control(dra.Item("user_id").ToString = main.user_id, dra)
                            NewControls.refreshRecordDet(frmTransaction.dgjbooks, frmTransaction.ds, frmTransaction.txt_trans_id)
                            If CDec(frmTransaction.txtAmountBased.EditValue) < 0 Then
                                frmTransaction.txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(frmTransaction.txtAmountBased.EditValue), main.DecimalPlaces)
                            ElseIf CDec(frmTransaction.txtAmountBased.EditValue) > 0 Then
                                frmTransaction.txt_amount_in_word.Text = amount_words(frmTransaction.txtAmountBased.EditValue, main.DecimalPlaces)
                            Else
                                frmTransaction.txt_amount_in_word.Text = ""
                            End If
                            frmTransaction.computeTotal()
                            frmTransaction.pkID = dra.Item("trans_id")
                        End If
                    Next
                    frmTransaction.btnAdd.Visible = False
                    frmTransaction.btnPrint.Visible = False
                    frmTransaction.btnSearch.Visible = False
                    frmTransaction.btnPrevious.Visible = False
                    frmTransaction.btnNext.Visible = False
                    frmTransaction.btnSettings.Visible = False
                    frmTransaction.ShowDialog()
                    'showForm(frmTransaction, main)
                Case "3" 'AP
                    Dim frmTransaction As New transactionap
                    frmTransaction.initializeDecimalPlaces(strNumberFormat)
                    frmSettings.frmTransaction = frmTransaction
                    frmTransaction.mySettings = frmSettings
                    frmTransaction.BookID = bookID
                    frmTransaction.JournalID = journalID
                    frmTransaction.Year = setDate.Year
                    frmTransaction.Month = setDate.Month
                    frmTransaction.Refresh()
                    For Each dra As DataRow In frmTransaction.ds.Tables("trans").Rows
                        If dra.Item("trans_id") = trans_id Then
                            frmTransaction.clear_control()
                            NewControls.bindControl(frmTransaction.hdr, dra, True)
                            frmTransaction.currentDr = dra
                            'frmTransaction.disable_control(dra.Item("user_id").ToString = main.user_id, dra)
                            NewControls.refreshRecordDet(frmTransaction.dgjbooks, frmTransaction.ds, frmTransaction.txt_trans_id)
                            If CDec(frmTransaction.txtAmountBased.EditValue) < 0 Then
                                frmTransaction.txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(frmTransaction.txtAmountBased.EditValue), main.DecimalPlaces)
                            ElseIf CDec(frmTransaction.txtAmountBased.EditValue) > 0 Then
                                frmTransaction.txt_amount_in_word.Text = amount_words(frmTransaction.txtAmountBased.EditValue, main.DecimalPlaces)
                            Else
                                frmTransaction.txt_amount_in_word.Text = ""
                            End If
                            frmTransaction.computeTotal()
                            frmTransaction.pkID = dra.Item("trans_id")
                        End If
                    Next
                    frmTransaction.btnAdd.Visible = False
                    frmTransaction.btnPrint.Visible = False
                    frmTransaction.btnSearch.Visible = False
                    frmTransaction.btnPrevious.Visible = False
                    frmTransaction.btnNext.Visible = False
                    frmTransaction.btnSettings.Visible = False
                    frmTransaction.ShowDialog()
                    'showForm(frmTransaction, main)
                Case "4" 'CV
                    Dim frmTransaction As New transactioncv
                    frmTransaction.initializeDecimalPlaces(strNumberFormat)
                    frmSettings.frmTransaction = frmTransaction
                    frmTransaction.mySettings = frmSettings
                    frmTransaction.BookID = bookID
                    frmTransaction.JournalID = journalID
                    frmTransaction.Year = setDate.Year
                    frmTransaction.Month = setDate.Month
                    frmTransaction.Refresh()
                    For Each dra As DataRow In frmTransaction.ds.Tables("trans").Rows
                        If dra.Item("trans_id") = trans_id Then
                            frmTransaction.clear_control()
                            NewControls.bindControl(frmTransaction.hdr, dra, True)
                            frmTransaction.currentDr = dra
                            'frmTransaction.disable_control(dra.Item("user_id").ToString = main.user_id, dra)
                            NewControls.refreshRecordDet(frmTransaction.dgjbooks, frmTransaction.ds, frmTransaction.txt_trans_id)
                            If CDec(frmTransaction.txtAmountBased.EditValue) < 0 Then
                                frmTransaction.txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(frmTransaction.txtAmountBased.EditValue), main.DecimalPlaces)
                            ElseIf CDec(frmTransaction.txtAmountBased.EditValue) > 0 Then
                                frmTransaction.txt_amount_in_word.Text = amount_words(frmTransaction.txtAmountBased.EditValue, main.DecimalPlaces)
                            Else
                                frmTransaction.txt_amount_in_word.Text = ""
                            End If
                            frmTransaction.computeTotal()
                            frmTransaction.pkID = dra.Item("trans_id")
                        End If
                    Next
                    frmTransaction.btnAdd.Visible = False
                    frmTransaction.btnPrint.Visible = False
                    frmTransaction.btnSearch.Visible = False
                    frmTransaction.btnPrevious.Visible = False
                    frmTransaction.btnNext.Visible = False
                    frmTransaction.btnSettings.Visible = False
                    frmTransaction.ShowDialog()
                    'showForm(frmTransaction, main)
                Case "5" 'JB
                    Dim frmTransaction As New transactionjb
                    frmTransaction.initializeDecimalPlaces(strNumberFormat)
                    frmSettings.frmTransaction = frmTransaction
                    frmTransaction.mySettings = frmSettings
                    frmTransaction.BookID = bookID
                    frmTransaction.JournalID = journalID
                    frmTransaction.Year = setDate.Year
                    frmTransaction.Month = setDate.Month
                    frmTransaction.Refresh()
                    For Each dra As DataRow In frmTransaction.ds.Tables("trans").Rows
                        If dra.Item("trans_id") = trans_id Then
                            frmTransaction.clear_control()
                            NewControls.bindControl(frmTransaction.hdr, dra, True)
                            frmTransaction.currentDr = dra
                            'frmTransaction.disable_control(dra.Item("user_id").ToString = main.user_id, dra)
                            NewControls.refreshRecordDet(frmTransaction.dgjbooks, frmTransaction.ds, frmTransaction.txt_trans_id)
                            If CDec(frmTransaction.txtAmountBased.EditValue) < 0 Then
                                frmTransaction.txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(frmTransaction.txtAmountBased.EditValue), main.DecimalPlaces)
                            ElseIf CDec(frmTransaction.txtAmountBased.EditValue) > 0 Then
                                frmTransaction.txt_amount_in_word.Text = amount_words(frmTransaction.txtAmountBased.EditValue, main.DecimalPlaces)
                            Else
                                frmTransaction.txt_amount_in_word.Text = ""
                            End If
                            frmTransaction.computeTotal()
                            frmTransaction.pkID = dra.Item("trans_id")
                        End If
                    Next
                    frmTransaction.btnAdd.Visible = False
                    frmTransaction.btnPrint.Visible = False
                    frmTransaction.btnSearch.Visible = False
                    frmTransaction.btnPrevious.Visible = False
                    frmTransaction.btnNext.Visible = False
                    frmTransaction.btnSettings.Visible = False
                    frmTransaction.ShowDialog()
                    'showForm(frmTransaction, main)
                Case "6" 'PC
                    Dim frmTransaction As New transactionpc
                    frmTransaction.initializeDecimalPlaces(strNumberFormat)
                    frmSettings.frmTransaction = frmTransaction
                    frmTransaction.mySettings = frmSettings
                    frmTransaction.BookID = bookID
                    frmTransaction.JournalID = journalID
                    frmTransaction.Year = setDate.Year
                    frmTransaction.Month = setDate.Month
                    frmTransaction.Refresh()
                    For Each dra As DataRow In frmTransaction.ds.Tables("trans").Rows
                        If dra.Item("trans_id") = trans_id Then
                            frmTransaction.clear_control()
                            NewControls.bindControl(frmTransaction.hdr, dra, True)
                            frmTransaction.currentDr = dra
                            'frmTransaction.disable_control(dra.Item("user_id").ToString = main.user_id, dra)
                            NewControls.refreshRecordDet(frmTransaction.dgjbooks, frmTransaction.ds, frmTransaction.txt_trans_id)
                            If CDec(frmTransaction.txtAmountBased.EditValue) < 0 Then
                                frmTransaction.txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(frmTransaction.txtAmountBased.EditValue), main.DecimalPlaces)
                            ElseIf CDec(frmTransaction.txtAmountBased.EditValue) > 0 Then
                                frmTransaction.txt_amount_in_word.Text = amount_words(frmTransaction.txtAmountBased.EditValue, main.DecimalPlaces)
                            Else
                                frmTransaction.txt_amount_in_word.Text = ""
                            End If
                            frmTransaction.computeTotal()
                            frmTransaction.pkID = dra.Item("trans_id")
                        End If
                    Next
                    frmTransaction.btnAdd.Visible = False
                    frmTransaction.btnPrint.Visible = False
                    frmTransaction.btnSearch.Visible = False
                    frmTransaction.btnPrevious.Visible = False
                    frmTransaction.btnNext.Visible = False
                    frmTransaction.btnSettings.Visible = False
                    frmTransaction.ShowDialog()
                    'showForm(frmTransaction, main)
                Case "7" 'DC
                    Dim frmTransaction As New transactiondc
                    frmTransaction.initializeDecimalPlaces(strNumberFormat)
                    frmSettings.frmTransaction = frmTransaction
                    frmTransaction.mySettings = frmSettings
                    frmTransaction.BookID = bookID
                    frmTransaction.JournalID = journalID
                    frmTransaction.Year = setDate.Year
                    frmTransaction.Month = setDate.Month
                    frmTransaction.Refresh()
                    For Each dra As DataRow In frmTransaction.ds.Tables("trans").Rows
                        If dra.Item("trans_id") = trans_id Then
                            frmTransaction.clear_control()
                            NewControls.bindControl(frmTransaction.hdr, dra, True)
                            frmTransaction.currentDr = dra
                            'frmTransaction.disable_control(dra.Item("user_id").ToString = main.user_id, dra)
                            NewControls.refreshRecordDet(frmTransaction.dgjbooks, frmTransaction.ds, frmTransaction.txt_trans_id)
                            If CDec(frmTransaction.txtAmountBased.EditValue) < 0 Then
                                frmTransaction.txt_amount_in_word.Text = "NEGATIVE " & amount_words(-1 * CDec(frmTransaction.txtAmountBased.EditValue), main.DecimalPlaces)
                            ElseIf CDec(frmTransaction.txtAmountBased.EditValue) > 0 Then
                                frmTransaction.txt_amount_in_word.Text = amount_words(frmTransaction.txtAmountBased.EditValue, main.DecimalPlaces)
                            Else
                                frmTransaction.txt_amount_in_word.Text = ""
                            End If
                            frmTransaction.computeTotal()
                            frmTransaction.pkID = dra.Item("trans_id")
                        End If
                    Next
                    frmTransaction.btnAdd.Visible = False
                    frmTransaction.btnPrint.Visible = False
                    frmTransaction.btnSearch.Visible = False
                    frmTransaction.btnPrevious.Visible = False
                    frmTransaction.btnNext.Visible = False
                    frmTransaction.btnSettings.Visible = False
                    frmTransaction.ShowDialog()
                    'showForm(frmTransaction, main)
                Case Else

            End Select


            'frmSettings.init()
            'frmSettings.ShowDialog()
        End If
    End Sub
End Class