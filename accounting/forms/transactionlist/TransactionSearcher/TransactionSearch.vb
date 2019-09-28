Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms

Public Class TransactionSearch

    Private Sub LoadJournal()
        Dim sql As String = String.Format("SELECT journal_id,journal_code FROM lib_erp_journal WHERE journal_id <> 8")
        Dim dt As DataTable = FsQuery(sql)
        filter_journal_id.DataSource = dt
        filter_journal_id.ValueMember = "journal_id"
        filter_journal_id.DisplayMember = "journal_code"
    End Sub
    Private Sub LoadAllTransaction()
        Dim sql As String = String.Format("SELECT a.trans_id,a.trans_no,a.trans_date
            ,CAST(a.amount AS DECIMAL(27,2)) AS amount,a.description
            ,a.book_id,b.book_code,b.book_name
            ,a.general_id,c.general_code,c.general_name
            ,a.journal_id,e.journal_code,e.journal_name
            ,d.check_no
            FROM trans_header a
            LEFT JOIN {0}.lib_erp_book b ON b.book_id = a.book_id
            LEFT JOIN {0}.lib_erp_general c ON c.general_id = a.general_id
            LEFT JOIN (
                SELECT a.trans_id,GROUP_CONCAT(IFNULL(b.check_no,'')) AS check_no
                FROM trans_jbooks a
                LEFT JOIN trans_checks b ON b.jbooks_id = a.jbooks_id
                WHERE IFNULL(b.check_id,'') <> ''
                GROUP BY a.trans_id
            ) d ON d.trans_id = a.trans_id
            LEFT JOIN {0}.lib_erp_journal e ON e.journal_id = a.journal_id
            ORDER BY a.journal_id,a.trans_no
        ", _serverDBFS)
        Dim dt As DataTable = Query(sql)
        bs.DataSource = dt
    End Sub

    Private Sub TransactionSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextEdit1.Properties.ReadOnly = True
        Dim y = Today.Year
        filter_date_from.Value = New Date(y, 1, 1)
        filter_date_to.Value = New Date(y, 12, 31)
        LoadJournal()
        NeedToHide.Visible = False
        LoadAllTransaction()
    End Sub

    Private Sub DateChange(sender As Object, e As EventArgs) Handles filter_date_to.ValueChanged, filter_date_from.ValueChanged
        Filter()
    End Sub
    Private Sub Filter()
        bs.Filter = ""
        Dim dFrom As Date = filter_date_from.Value
        Dim dTo As Date = filter_date_to.Value
        Dim journal_id As String = ifNull(filter_journal_id.SelectedValue, "").ToString
        Dim trans_no As String = ifNull(filter_trans_no.Text, "").ToString
        Dim check_no As String = ifNull(filter_check_no.Text, "").ToString
        Dim general As String = ifNull(filter_general.Text, "").ToString
        Dim q As String = String.Format("trans_date >= '{0:yyyy-MM-dd}' AND trans_date <= '{1:yyyy-MM-dd}'", dFrom, dTo)
        If journal_id <> "" Then
            q &= String.Format(" AND journal_id = '{0}'", journal_id)
        End If
        If trans_no <> "" Then
            q &= String.Format(" AND trans_no = '{0}'", trans_no)
        End If
        If check_no <> "" Then
            q &= String.Format(" AND check_no = '{0}'", check_no)
        End If
        If general <> "" Then
            q &= String.Format(" AND (general_code LIKE '%{0}%' OR general_name LIKE '%{0}%')", general)
        End If
        bs.Filter = q
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Filter()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Select Case filter_journal_id.SelectedValue
            Case "1"
                Dim frm As New transactionib
                frm.initializeDecimalPlaces(main.strNumberFormat)
                ShowTransaction(frm, "IB")
            Case "2"

                Dim frm As New transactioncr
                frm.initializeDecimalPlaces(main.strNumberFormat)
                ShowTransaction(frm, "CR")
            Case "3"
                Dim frm As New transactionap
                frm.initializeDecimalPlaces(main.strNumberFormat)
                ShowTransaction(frm, "AP")
            Case "4"
                Dim frm As New transactioncv
                frm.initializeDecimalPlaces(main.strNumberFormat)
                ShowTransaction(frm, "CV")
            Case "5"
                Dim frm As New transactionjb
                frm.initializeDecimalPlaces(main.strNumberFormat)
                ShowTransaction(frm, "JB")
            Case "6"
                Dim frm As New transactionpc
                frm.initializeDecimalPlaces(main.strNumberFormat)
                ShowTransaction(frm, "PC")
            Case "7"
                Dim frm As New transactiondc
                frm.initializeDecimalPlaces(main.strNumberFormat)
                ShowTransaction(frm, "DC")
        End Select
    End Sub
    Private Sub ShowTransaction(ByVal frmTransaction As Object, ByVal journalCode As String)
        Dim id As String = txt_trans_id.Text

        Dim dr As DataRow
        dr = main.Journal.Select(String.Format("journal_code = '{0}'", journalCode))(0)
        Dim frmSettings As New settings

        frmSettings.frmTransaction = frmTransaction
        frmSettings.journal_id = dr.Item("journal_id")
        frmSettings.journal_code = dr.Item("journal_code")
        frmSettings.journal_name = dr.Item("journal_name")
        frmSettings.journal_id = dr.Item("journal_id")
        If main.Sys_Default.Rows.Count > 0 Then
            frmSettings.sys_beg = main.Sys_Default.Rows(0).Item("sys_beg")
            frmSettings.minDate = CDate(main.Sys_Default.Rows(0).Item("sys_beg")).AddDays(1)
        End If
        frmSettings.init()
        frmSettings.numYear.Value = txt_trans_date.Value.Year
        frmSettings.cmbMonth.SelectedValue = txt_trans_date.Value.Month
        frmSettings.book_name = txt_book_name.Text
        Dim trans_date As Date = txt_trans_date.Value
        Dim month_name As String = MonthName(trans_date.Month)
        Dim month As String = trans_date.Month
        Dim currentDate As DateTime = DateTime.Now
        Dim curr_date As Date = Today
        Dim sel_date As Date = New Date(trans_date.Year, month, 1)

        Dim year As String = trans_date.Year
        Dim book_name = txt_book_name.Text
        Dim book As String = txt_book_id.Text
        Dim journal_id As String = dr("journal_id")
        If frmTransaction IsNot Nothing Then
            Try
                Dim propCreateCVFromAP As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("CreateCVFromAP")
                If Not propCreateCVFromAP Is Nothing Then
                    propCreateCVFromAP.SetValue(frmTransaction, False)
                End If
            Catch
            End Try
            Try
                Dim propBookID As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("BookID")
                If Not propBookID Is Nothing Then
                    propBookID.SetValue(frmTransaction, book)
                End If
            Catch
            End Try
            Try
                Dim propBookCode As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("BookCode")
                If Not propBookCode Is Nothing Then
                    propBookCode.SetValue(frmTransaction, book_name)
                End If
            Catch
            End Try
            Try
                Dim propBookCode As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("BookName")
                If Not propBookCode Is Nothing Then
                    propBookCode.SetValue(frmTransaction, book_name)
                End If
            Catch
            End Try
            Try
                Dim propJournalID As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("JournalID")
                If Not propJournalID Is Nothing Then
                    propJournalID.SetValue(frmTransaction, journal_id)
                End If
            Catch
            End Try
            Try
                Dim propJournalName As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("JournalCode")
                If Not propJournalName Is Nothing Then
                    propJournalName.SetValue(frmTransaction, dr.Item("journal_name"))
                End If
            Catch
            End Try
            Try
                Dim propMonth As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("Month")
                If Not propMonth Is Nothing Then
                    propMonth.SetValue(frmTransaction, month)
                End If
            Catch
            End Try
            Try
                Dim propYear As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("Year")
                If Not propYear Is Nothing Then
                    propYear.SetValue(frmTransaction, year)
                End If
            Catch
            End Try
            showForm(frmTransaction, main)
            frmTransaction.TopMost = True
        End If
        Try
            Dim propTransID As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("pkID")
            If Not propTransID Is Nothing Then
                propTransID.SetValue(frmTransaction, id.ToString)
                frmTransaction.Refresh()
            End If
        Catch
        End Try
    End Sub
End Class