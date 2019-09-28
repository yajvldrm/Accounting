Imports Microsoft.Office.Interop
Imports connectionlib.connectionlib
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports libacctng.myFunctions

Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class printingbooks

    Dim journal_ids As New List(Of String)
    Dim ds As New FileSetupSet
    Private MyDT As DataTable = Nothing
    Dim templates As String = Application.StartupPath & "\templates"

    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged, rdo2.CheckedChanged
        Dim range As String = getRdoValue(range_filter)
        If range = "2" Then
            txt_date_from.Enabled = False
            txt_date_to.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        Else
            txt_date_from.Enabled = True
            txt_date_to.MinDate = txt_date_from.Value
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub printingbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_date_from.Value = New Date(Today.Year, 1, 1)
        txt_date_from.MinDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg").ToString)
        txt_date_to.MinDate = txt_date_from.Value

        cbo_sort.Items.Add("Transaction No.")
        cbo_sort.Items.Add("Date")
        cbo_sort.Text = "Transaction No."
        dgJournal.AutoGenerateColumns = False
        Dim sql_journal As String = String.Format("SELECT False AS sel,journal_id,journal_code,journal_name FROM lib_erp_journal WHERE journal_id <> 8")
        Dim dt_journal As DataTable = FsQuery(sql_journal)
        ds.Tables("lib_erp_journal").Clear()
        For Each row As DataRow In dt_journal.Rows
            ds.Tables("lib_erp_journal").ImportRow(row)
        Next




        dgJournal.DataSource = ds.Tables("lib_erp_journal")
    End Sub
    Private Sub loadBooks(ByVal id() As String)
        dgBooks.AutoGenerateColumns = False
        Dim sql As String = String.Format("SELECT False AS sel,b.book_id,c.book_code,c.book_name " & vbNewLine &
            "FROM {0}.lib_erp_journal a " & vbNewLine &
            "LEFT JOIN {0}.sys_acc_journal_book b ON b.journal_id = a.journal_id " & vbNewLine &
            "LEFT JOIN {0}.lib_erp_book c ON c.book_id = b.book_id ", _serverDBFS)
        ds.Tables("lib_erp_book").Clear()
        If id.Length > 0 Then
            Dim str_id As String = ""
            For i As Integer = 0 To id.Length - 1
                str_id &= "," & id(i)
            Next
            sql &= String.Format("WHERE a.journal_id IN ({0}) AND c.book_code IS NOT NULL ", str_id.Substring(1))
            sql &= String.Format("AND c.company_id = '{0}' ", main.Sys_Default.Rows(0).Item("company_id").ToString)
            sql &= " GROUP BY c.book_id "
            Dim dt As DataTable = Query(sql)

            For Each row As DataRow In dt.Rows
                ds.Tables("lib_erp_book").ImportRow(row)
            Next
        End If
        dgBooks.DataSource = ds.Tables("lib_erp_book")
    End Sub
    Private Sub dgJournal_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgJournal.CellValueChanged
        journal_ids.Clear()
        For Each dr As DataGridViewRow In dgJournal.Rows
            If dr.Cells("sel1").Value Then
                journal_ids.Add(dr.Cells("journal_id").Value.ToString)
            End If
        Next
        loadBooks(journal_ids.ToArray)
    End Sub
    Private Sub checkAllJournal_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllJournal.CheckedChanged
        Dim dt As DataTable = dgJournal.DataSource
        For Each row As DataRow In dt.Rows
            row("sel") = checkAllJournal.Checked
        Next
        journal_ids.Clear()
        For Each dr As DataGridViewRow In dgJournal.Rows
            If dr.Cells("sel1").Value Then
                journal_ids.Add(dr.Cells("journal_id").Value.ToString)
            End If
        Next
        loadBooks(journal_ids.ToArray)
    End Sub
    Private Sub checkAllBook_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllBook.CheckedChanged
        For Each dr As DataGridViewRow In dgBooks.Rows
            dr.Cells("sel").Value = checkAllBook.Checked
        Next
    End Sub
    Private Sub dgJournal_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgJournal.CurrentCellDirtyStateChanged
        If dgJournal.CurrentCell.ColumnIndex = 0 Then
            If dgJournal.IsCurrentCellDirty Then
                dgJournal.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExcel.Click, btnTabSeparated.Click

        Dim isrange As String = getRdoValue(range_filter)
        Dim datefrom As String = CDate(txt_date_from.Value).ToString("yyyy-MM-dd")
        Dim dateto As String = CDate(txt_date_to.Value).ToString("yyyy-MM-dd")
        Dim sort As String = cbo_sort.SelectedText
        Dim journals() As String = getCheckedGridUnit("journal_id", "journal_name", "sel1", dgJournal, "", False, "", False)
        Dim book_name As New List(Of String)
        Dim books() As String = getCheckedGridV1("book_id", "book_name", "sel", dgBooks, book_name, "", False, "", False)
        Dim str_journalids As String = ""
        Dim str_book_ids As String = ""
        Dim bookName As String = ""

        Dim general_id As String = txt_general_id.Value

        For Each b In book_name
            bookName &= "," & b
        Next
        If isrange = "1" Then
            If txt_date_to.Value < txt_date_from.Value Then
                MsgBox("Invalid Date Range.")
                Exit Sub
            End If
        End If

        For Each id In journals
            str_journalids &= "," & id
        Next

        For Each id In books
            str_book_ids &= "," & id
        Next

        Dim sql = String.Format("SELECT a.book_id,a.trans_id,a.trans_date,a.trans_no
        ,e.general_code,e.general_name,a.description
        ,k.account_code,k.account_name
        ,SUM(IFNULL(b.debit,0)) AS debit,SUM(IFNULL(b.credit,0)) AS credit,SUM(IFNULL(b.debit_based,0)) AS debit_based,SUM(IFNULL(b.credit_based,0)) AS credit_based
        ,l.general_code AS ref_general_code,l.general_name AS ref_general_name
        ,CONCAT(h.project_code, ' ', i.department_code) AS proj_dept
        ,j.allocation_code
        ,IF(IFNULL(o.ref_no,'') = '',p.trans_no,o.ref_no) AS ref_trans_no
        ,m.book_code,m.book_name
        ,a.journal_id,g.journal_name
        ,g.trans_label,g.person_label
        ,check_ref.check_no
        ,b.line_remarks
        FROM trans_header a
        LEFT JOIN (
	        SELECT a.trans_id,a.trans_no,a.trans_date,GROUP_CONCAT(c.check_no) AS check_no
	        FROM trans_header a
	        LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id
	        LEFT JOIN trans_checks c ON c.jbooks_id = b.jbooks_id
	        LEFT JOIN {0}.lib_erp_chart d ON d.account_id = b.account_id
	        WHERE d.validation = 1 AND IFNULL(c.check_no,'') <> '' AND UPPER(IFNULL(a.status,'')) <> 'C'
	        GROUP BY a.trans_id
        ) check_ref ON check_ref.trans_id = a.trans_id
        LEFT JOIN trans_jbooks b ON b.trans_id = a.trans_id
        LEFT JOIN trans_jbooks n ON n.jbooks_id = b.ref_jbooks_id
        LEFT JOIN trans_jbooks_ref o ON o.jbooks_id = n.jbooks_id
        LEFT JOIN trans_header p ON p.trans_id = n.trans_id
        LEFT JOIN {0}.lib_erp_general e ON e.general_id = a.general_id
        LEFT JOIN {0}.lib_erp_currency f ON f.currency_id = a.currency_id
        LEFT JOIN {0}.lib_erp_journal g ON g.journal_id = a.journal_id
        LEFT JOIN {0}.lib_erp_project h ON h.project_id = b.project_id
        LEFT JOIN {0}.lib_erp_department i ON i.department_id = b.department_id
        LEFT JOIN {0}.lib_erp_allocation j ON j.allocation_id = b.allocation_id
        LEFT JOIN {0}.lib_erp_chart k ON k.account_id = b.account_id
        LEFT JOIN {0}.lib_erp_general l ON l.general_id = b.general_id
        LEFT JOIN {0}.lib_erp_book m ON m.book_id = a.book_id", _serverDBFS)

        Dim strange As String = ""
        If isrange = "1" Then
            sql &= String.Format(" WHERE a.trans_date BETWEEN '{0}' AND '{1}'", datefrom, dateto)
            If txt_date_from.Value.ToString("MMMM yyyy") = txt_date_to.Value.ToString("MMMM yyyy") Then
                strange = String.Format("For the month of {0}", txt_date_from.Value.ToString("MMMM yyyy"))
            Else
                strange = String.Format("For the month of {0} - {1}", txt_date_from.Value.ToString("MMMM yyyy"), txt_date_to.Value.ToString("MMMM yyyy"))
            End If
        Else
            sql &= String.Format(" WHERE a.trans_date  <= '{0}' ", dateto)
            strange = String.Format("As Of {0}", txt_date_to.Value.ToString("MMMM yyyy"))
        End If
        If general_id <> "" Then
            sql &= String.Format(" AND a.general_id = '{0}'", general_id)
        End If
        If str_journalids <> "" Then
            sql &= String.Format(" AND a.journal_id IN ({0})", str_journalids.Substring(1))
        Else
            MsgBox("No Journals selected.")
            Exit Sub
        End If

        If str_book_ids <> "" Then
            sql &= String.Format(" AND a.book_id IN ({0})", str_book_ids.Substring(1))
        Else
            MsgBox("No Book selected.")
            Exit Sub
        End If
        sql &= " GROUP BY b.jbooks_id "
        If cbo_sort.Text = "Transaction No." Then
            sql &= " ORDER BY a.trans_no ASC,b.debit DESC"
        ElseIf cbo_sort.Text = "Date" Then
            sql &= " ORDER BY a.trans_no ASC,a.trans_date ASC,b.debit DESC"
        Else
            sql &= " ORDER BY b.debit DESC"
        End If

        Dim dt As DataTable = Query(sql)
        'Dim sql_company As String = String.Format("SELECT a.* FROM lib_erp_company a")
        'Dim dt_company As DataTable = FsQuery(sql_company)
        Dim company As String = main.Sys_Default.Rows(0).Item("company_name").ToString
        Dim add_tin As String = String.Format("{0}VAT REG TIN : {1}", main.Sys_Default.Rows(0).Item("address1") & vbNewLine, main.Sys_Default.Rows(0).Item("tin"))

        'If dt_company.Rows.Count > 0 Then
        '    company = dt_company.Rows(0).Item("company_name")
        'End If

        Select Case sender.Name
            Case "btnPrint"
#Region "btnPrint"
                If dt.Rows.Count = 0 Then
                    MsgBox("No records to Print.")
                Else

                    Dim ds As New printbooks_set
                    ds.Clear()
                    For Each dr As DataRow In dt.Rows
                        ds.Tables("printbooks_report").ImportRow(dr)
                    Next
                    Dim rep As New journalbooks
                    rep.DataSource = ds
                    rep.company_name.Text = company
                    rep.Parameters("S001").Value = main.S001
                    rep.Parameters("S002").Value = main.S002
                    rep.add_tin.Text = add_tin
                    rep.runtime.Text = System.DateTime.Now.ToString("MM/dd/yyyy - HH:mm:ss")
                    rep.range.Text = strange
                    reportviewer.DocumentViewer1.DocumentSource = rep
                    reportviewer.ShowDialog()
                End If
#End Region
            Case "btnExcel"

                Dim ds As New printbooks_set
                ds.Clear()
                For Each dr As DataRow In dt.Rows
                    ds.Tables("printbooks_report").ImportRow(dr)
                Next
                Dim dicHeader As New Dictionary(Of String, String)
                dicHeader.Add("companyName", "")
                dicHeader.Add("book_name", If(bookName <> "", bookName.Substring(1), ""))
                dicHeader.Item("companyName") = company
                'If dt_company.Rows.Count > 0 Then
                '    dicHeader.Item("companyName") = dt_company.Rows(0).Item("company_name").ToString
                'End If
                Dim strGrouping As String = "journal_name,trans_no"
                Dim listAccount = groupDataTableToList(ds.Tables("printbooks_report"), strGrouping)
                Dim sqlJouranl As String = String.Format("SELECT a.journal_id,a.journal_code,a.journal_name FROM lib_erp_journal a WHERE a.journal_id IN ({0})", str_journalids.Substring(1))
                Dim dtJournal As DataTable = FsQuery(sqlJouranl)
                Try
                    lblLoad.Visible = True
                    reportbooks(listAccount, dicHeader, strGrouping, ds.Tables("printbooks_report"), dtJournal)
                    MsgBox("Report Done")
                    lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
                'MsgBox("Data Succesfully Load")
            Case Else
#Region "Tab Seperated"
                Dim col = New List(Of KeyValuePair(Of String, String))
                col.Add(New KeyValuePair(Of String, String)("@from_date", String.Format("{0:yyyy/MM/dd}", txt_date_from.Value)))
                col.Add(New KeyValuePair(Of String, String)("@to_date", String.Format("{0:yyyy/MM/dd}", txt_date_to.Value)))
                col.Add(New KeyValuePair(Of String, String)("@jID", String.Format("{0}", String.Join(",", journals))))
                col.Add(New KeyValuePair(Of String, String)("@bID", String.Format("{0}", books)))

                Dim dt2 As DataTable = ExecuteWithParameter("get_tab_separated", ConnectionStringMain, CommandType.StoredProcedure, col)

                dsBooks.Tables("trans_header").Clear()
                MyDT = dsBooks.Tables("trans_header").Clone
                MyDT.Clear()

                For Each row As DataRow In dt2.Rows
                    dsBooks.Tables("trans_header").ImportRow(row)
                    MyDT.ImportRow(row)

                Next

                parent_grid.DataSource = MyDT

                'messagebox.Show("Record Found");
                'cn.Close();

                Dim month_from = txt_date_from.Value.Date.ToString
                Dim month_to = txt_date_to.Value.Date.ToString
                If folderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim fileName As String = String.Format("{0}.TXT", Date.Now.ToString("yyyymmdd"))
                    Dim path As String = folderBrowser.SelectedPath & "\" & fileName
                    If File.Exists(path) Then
                        Dim delete = MsgBox("File Already Exist. Want To replace With the New one?", MsgBoxStyle.YesNo, "1601E")
                        If delete = MsgBoxResult.No Then
                            Exit Sub
                        End If
                        File.Delete(fileName)
                    End If
                    Dim numCols As Integer = parent_grid.ColumnCount
                    Dim numRows As Integer = parent_grid.RowCount - 1
                    Dim fs As FileStream = File.Create(path)
                    Dim tw As TextWriter = New StreamWriter(fs)

                    'writing the header
                    For count As Integer = 0 To numCols - 1

                        tw.Write(parent_grid.Columns(count).HeaderText)

                        If (count <> numCols - 1) Then

                            tw.Write("      ")
                        End If

                    Next

                    tw.WriteLine()

                    For count As Integer = 0 To numRows - 1

                        For count2 As Integer = 0 To numCols - 1

                            tw.Write(parent_grid.Rows(count).Cells(count2).Value)

                            If (count2 <> numCols) Then

                                tw.Write("        ")

                            End If

                        Next

                        tw.WriteLine()

                    Next

                    tw.Close()

                    MsgBox("Data successfully exported")


                End If

#End Region
        End Select
    End Sub
    Private Shared Sub AddText(ByVal fs As FileStream, ByVal value As String)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(value)
        fs.Write(info, 0, info.Length)
    End Sub
    Private Sub ExcelReport(ByVal dic As Dictionary(Of String, Object))

    End Sub
    Private Sub reportbooks(ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByVal dtJournal As DataTable)
        Dim sheetCtr As Integer = 0
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim lstTotal As New List(Of Integer)

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
        xlApp.UserControl = True
        If xlWorkBook.Worksheets.Count = 3 Then
            xlWorkBook.Worksheets(1).Delete()
            xlWorkBook.Worksheets(1).Delete()
        End If
        For Each dr As DataRow In dtJournal.Rows
            Dim journal_name As String = dr.Item("journal_name").ToString
            If sheetCtr > 0 Then
                xlWorkBook.Worksheets.Add()
            End If
            xlWorkSheet = xlWorkBook.Worksheets(1)
            xlWorkSheet.Name = journal_name.Replace("/", "").Replace("\", "")
            sheetCtr += 1
            For Each journal In listAccount
                If journal_name = journal.Item("journal_name").ToString Then
                    excelBooks(lstTotal, journal.Item("grouped"), dicHeader, strCol, ds.Tables("printbooks_report"), xlWorkSheet, journal.item("journal_name"))
                End If
            Next
        Next
        'For Each journal In listAccount
        '    If sheetCtr > 0 Then
        '        xlWorkBook.Worksheets.Add()
        '    End If
        '    xlWorkSheet = xlWorkBook.Worksheets(1)
        '    xlWorkSheet.Name = journal.item("journal_name").ToString.Replace("/", "_")
        '    sheetCtr += 1
        '    excelBooks(lstTotal, journal.item("grouped"), dicHeader, strCol, ds.Tables("printbooks_report"), xlWorkSheet, journal.item("journal_name"))
        'Next
    End Sub
    Private Sub excelBooks(ByRef lstTotal As List(Of Integer), ByVal listAccount As List(Of Object), ByVal dicHeader As Dictionary(Of String, String), ByVal strCol As String, ByVal dtAccount As DataTable, ByRef xlWorkSheet As Excel.Worksheet, ByVal journal As String)
        xlWorkSheet.Cells(1, 1) = dicHeader.Item("companyName")
        xlWorkSheet.Cells(2, 1) = journal
        xlWorkSheet.Cells(3, 1) = "Printing of Books"
        'xlWorkSheet.Cells(3, 1) = dicHeader.Item("book_name")
        If rdo1.Checked = True Then
            xlWorkSheet.Cells(4, 1) = "From " & txt_date_from.Value.ToString("MMMM dd, yyyy") & " To " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        Else
            xlWorkSheet.Cells(4, 1) = "As Of " & txt_date_to.Value.ToString("MMMM dd, yyyy")
        End If

        Dim current_row As Integer = 5
        xlWorkSheet.Cells(current_row, 1) = "Account Code"
        xlWorkSheet.Cells(current_row, 1).ColumnWidth = 8
        xlWorkSheet.Cells(current_row, 2) = ""
        xlWorkSheet.Cells(current_row, 2).ColumnWidth = 2
        xlWorkSheet.Cells(current_row, 3) = "Title"
        xlWorkSheet.Cells(current_row, 3).ColumnWidth = 30
        xlWorkSheet.Cells(current_row, 4) = "Debit"
        xlWorkSheet.Cells(current_row, 4).ColumnWidth = 15
        xlWorkSheet.Cells(current_row, 5) = "Credit"
        xlWorkSheet.Cells(current_row, 5).ColumnWidth = 15
        xlWorkSheet.Cells(current_row, 6) = "General Reference"
        xlWorkSheet.Cells(current_row, 6).ColumnWidth = 13
        xlWorkSheet.Cells(current_row, 7) = "Proj/Dept Code"
        xlWorkSheet.Cells(current_row, 7).ColumnWidth = 8
        xlWorkSheet.Cells(current_row, 8) = "Document Reference"
        xlWorkSheet.Cells(current_row, 8).ColumnWidth = 13
        xlWorkSheet.Cells(current_row, 9) = "Line Remarks"
        xlWorkSheet.Cells(current_row, 9).ColumnWidth = 20

        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 9)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 9)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 9)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 9)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 9)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 9)).Font.Size = 10
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 9)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 9)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 9)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 9)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 9)).Font.Bold = True
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 9)).Font.Size = 8

        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 9)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 9)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 9)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 9)).HorizontalAlignment = Excel.Constants.xlCenter

        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).WrapText = True
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).VerticalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).Interior.Color = System.Drawing.Color.FromArgb(215, 228, 242)
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        current_row += 1

        For Each transaction As Dictionary(Of String, Object) In listAccount
            Dim transaction_data As List(Of Object) = transaction.Item("datas")
            current_row += 1
            xlWorkSheet.Cells(current_row, 1) = "DATE"
            xlWorkSheet.Cells(current_row, 3) = ":    " & CDate(transaction_data(0).Item("trans_date").ToString).ToString("MM/dd/yyyy")
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            current_row += 1
            xlWorkSheet.Cells(current_row, 1) = "Transaction No."
            xlWorkSheet.Cells(current_row, 3) = ":  " & transaction_data(0).Item("trans_no")
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            current_row += 1
            xlWorkSheet.Cells(current_row, 1) = "BOOK"
            xlWorkSheet.Cells(current_row, 3) = ":  " & transaction_data(0).Item("book_name")
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            current_row += 1
            If "24".Contains(transaction_data(0).Item("journal_id").ToString) Then
                xlWorkSheet.Cells(current_row, 1) = "Check No."
                xlWorkSheet.Cells(current_row, 3) = ":  " & transaction_data(0).Item("check_no")
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
                current_row += 1
            End If
            xlWorkSheet.Cells(current_row, 1) = "Payee"
            xlWorkSheet.Cells(current_row, 3) = ":  " & transaction_data(0).Item("general_name")
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            current_row += 1
            xlWorkSheet.Cells(current_row, 1) = "Particulars"
            xlWorkSheet.Cells(current_row, 3) = ":  " & transaction_data(0).Item("description")
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = True
            current_row += 1

            Dim first_row As Integer = current_row
            For Each row In transaction_data
                xlWorkSheet.Cells(current_row, 1) = "'" & row.Item("account_code")
                xlWorkSheet.Cells(current_row, 1).Font.Size = 8
                xlWorkSheet.Cells(current_row, 3) = row.Item("account_name")
                xlWorkSheet.Cells(current_row, 3).Font.Size = 8
                xlWorkSheet.Cells(current_row, 4) = row.Item("debit_based")
                xlWorkSheet.Cells(current_row, 4).Font.Size = 8
                xlWorkSheet.Cells(current_row, 4).NumberFormat = "#,##0.00"
                xlWorkSheet.Cells(current_row, 5) = row.Item("credit_based")
                xlWorkSheet.Cells(current_row, 5).Font.Size = 8
                xlWorkSheet.Cells(current_row, 5).NumberFormat = "#,##0.00"
                xlWorkSheet.Cells(current_row, 6) = row.Item("ref_general_code")
                xlWorkSheet.Cells(current_row, 6).Font.Size = 8
                xlWorkSheet.Cells(current_row, 6).HorizontalAlignment = Excel.Constants.xlCenter
                xlWorkSheet.Cells(current_row, 7) = row.Item("proj_dept")
                xlWorkSheet.Cells(current_row, 7).Font.Size = 8
                xlWorkSheet.Cells(current_row, 7).HorizontalAlignment = Excel.Constants.xlCenter
                xlWorkSheet.Cells(current_row, 8) = row.Item("ref_trans_no")
                xlWorkSheet.Cells(current_row, 8).Font.Size = 8
                xlWorkSheet.Cells(current_row, 8).HorizontalAlignment = Excel.Constants.xlCenter
                xlWorkSheet.Cells(current_row, 9) = row.Item("line_remarks")
                xlWorkSheet.Cells(current_row, 9).Font.Size = 8
                xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 9), xlWorkSheet.Cells(current_row, 9)).WrapText = False
                current_row += 1
            Next

            xlWorkSheet.Cells(current_row, 1) = ("Total") & " : "
            xlWorkSheet.Cells(current_row, 1).Font.Size = 8
            xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
            xlWorkSheet.Cells(current_row, 1).Font.Italic = True
            xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", first_row, current_row - 1)
            xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", first_row, current_row - 1)
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Font.Bold = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 5)).Font.Size = 8
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 5)).NumberFormat = "#,##0.00"
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDouble
            lstTotal.Add(current_row)
            current_row += 1
        Next

        Dim strTotald As String = ""
        Dim strTotale As String = ""
        For Each t In lstTotal
            strTotald &= "+D" & t
            strTotale &= "+E" & t
        Next

        current_row += 1
        xlWorkSheet.Cells(current_row, 1).Value = "GRAND TOTAL : "
        xlWorkSheet.Cells(current_row, 1).Font.Italic = True
        xlWorkSheet.Cells(current_row, 1).IndentLevel = 5
        xlWorkSheet.Cells(current_row, 4) = String.Format("=SUBTOTAL(9,D{0}:D{1})", 6, current_row - 1)
        xlWorkSheet.Cells(current_row, 5) = String.Format("=SUBTOTAL(9,E{0}:E{1})", 6, current_row - 1)
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Font.Bold = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Font.Size = 8
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 4), xlWorkSheet.Cells(current_row, 9)).NumberFormat = "#,##0.00"
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range(xlWorkSheet.Cells(current_row, 1), xlWorkSheet.Cells(current_row, 9)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3
    End Sub
    Private Sub btnPrintOption_Click(sender As Object, e As EventArgs) Handles btnPrintOption.Click
        
        Dim _printoption As New reportoption
        _printoption.targetForm = Me
        _printoption.Label1.Hide()
        _printoption.cbo_sort.Hide()
        _printoption.TabSep.Visible = True

        _printoption.ShowDialog()


        If _printoption.DialogResult = Windows.Forms.DialogResult.OK Then
            Select Case _printoption.PrintOption
                Case "1"
                    btnPrint_Click(btnExcel, Nothing)
                Case "2"
                    btnPrint_Click(btnPrint, Nothing)
                Case Else
                    btnPrint_Click(btnTabSeparated, Nothing)

            End Select
        End If
    End Sub

    Private Sub txt_date_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_from.ValueChanged
        Dim newDate = New Date(txt_date_from.Value.Year, txt_date_from.Value.Month, 1)
        If newDate < txt_date_from.MinDate Then
            newDate = txt_date_from.MinDate
        End If
        txt_date_from.Value = newDate
        txt_date_to.MinDate = txt_date_from.Value
    End Sub

    Private Sub txt_date_to_ValueChanged(sender As Object, e As EventArgs) Handles txt_date_to.ValueChanged
        Dim newDate = New Date(txt_date_to.Value.Year, txt_date_to.Value.Month, 1)
        newDate = newDate.AddMonths(1)
        newDate = newDate.AddDays(-1)
        If newDate < txt_date_to.MinDate Then
            newDate = txt_date_to.MinDate
        End If
        txt_date_to.Value = newDate
    End Sub

    Private Sub Myformheader1_Load(sender As Object, e As EventArgs) Handles Myformheader1.Load

    End Sub

    Private Sub dgJournal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgJournal.CellContentClick

    End Sub

    Private Sub dgBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBooks.CellContentClick

    End Sub

    Private Sub txt_general_id_Leave(sender As Object, e As EventArgs) Handles txt_general_id.Leave
        Dim data As DataTable = FsQuery("SELECT * FROM lib_erp_general ")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("general_name like '" & txt_general_id.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Code,Name", "general_code,general_name", "200,400")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_general_id.RowData = dr
                txt_general_id.Value = dr("general_id")
                txt_general_id.Text = dr("general_name")
            Else
                txt_general_id.RowData = Nothing
                txt_general_id.Value = ""
                txt_general_id.Text = ""
            End If
        End If
    End Sub
End Class