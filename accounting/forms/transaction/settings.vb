Imports System.IO
Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports System.Reflection

Public Class settings
    Public Shared bookNamex As String = Nothing
    Public Property book_name As String = ""
#Region "Property"
    Public Property toClose As Boolean = False
    Private _frmTransaction As Form = Nothing
    Public Property sys_beg As Date = Today.Date
    Public Property minDate As Date = Today.Date
    Public Property journal_id As String = ""
    Public Property journal_code As String = ""
    Public Property journal_name As String = ""

    Public Property frmTransaction() As Form
        Get
            Return _frmTransaction
        End Get
        Set(value As Form)
            _frmTransaction = value
            Try
                Dim propSettings As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("mySettings")
                If Not propSettings Is Nothing Then
                    propSettings.SetValue(_frmTransaction, Me)
                End If
            Catch
            End Try
        End Set
    End Property
#End Region
#Region "Initialize"
    Friend Sub init()
        Dim sql_book As String = String.Format("SELECT b.book_id,b.book_code,b.book_name " &
            "FROM sys_acc_journal_book a " &
            "LEFT JOIN lib_erp_book b ON b.book_id = a.book_id " &
            "WHERE b.book_code IS NOT NULL AND a.journal_id = '{0}' AND b.company_id = '{1}' " &
            "ORDER BY b.book_code ", journal_id, main.Sys_Default.Rows(0).Item("company_id").ToString())
        Dim dt_book As DataTable = FsQuery(sql_book)
        If dt_book.Rows.Count > 0 Then
            cmbBook.DataSource = dt_book
            cmbBook.DisplayMember = "book_name"
            cmbBook.ValueMember = "book_id"
        Else
            MsgBox("No Book Setup.")
            Exit Sub
        End If
        If main.listMonth.Rows.Count > 0 Then
            cmbMonth.DataSource = main.listMonth
            cmbMonth.DisplayMember = "name"
            cmbMonth.ValueMember = "id"
        Else
            MsgBox("An Error Occured: Month Initialization Unable to Load.")
            Exit Sub
        End If
        numYear.Value = Today.Year
        numYear.Minimum = minDate.Year
        txt_sys_beg.Value = sys_beg
        cmbMonth.SelectedValue = Today.Month
        If cmbMonth.SelectedValue < minDate.Month Then
            If numYear.Value = minDate.Year Then
                cmbMonth.SelectedValue = minDate.Month
            End If
        End If
    End Sub
#End Region
#Region "Backup Code"
    Private Sub btnOK_Click_bak(sender As Object, e As EventArgs)
        Dim frm As String = "trans" + journal_code.ToLower

        Dim ProjAndForm = "accounting." & frm  '' String Of Your Project And Form Name
        Dim objType As Type = Type.[GetType](ProjAndForm) '' Get Type Of your string
        Dim objForm As Control = getShownForm(frm)
        If objForm Is Nothing Then
            objForm = DirectCast(CreateObjectInstance(objType.ToString), Control) '' Convert Type to Control and now you can use this Control
            'objForm = TryCast(Activator.CreateInstance(objType), Form)
        End If
        'Dim otype As Type = objForm.GetType
        Try
            Dim jid As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("journal_id")
            If Not jid Is Nothing Then
                jid.SetValue(objForm, journal_id)
            End If
        Catch
        End Try
        Try
            Dim bid As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("book_id")
            If Not bid Is Nothing Then
                bid.SetValue(objForm, cmbBook.SelectedValue.ToString)
            End If
        Catch
        End Try
        Try
            Dim bid As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("book_name")
            If Not bid Is Nothing Then
                bid.SetValue(objForm, cmbBook.Text)
            End If
        Catch
        End Try
        Try
            Dim jid As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("journal_code")
            If Not jid Is Nothing Then
                jid.SetValue(objForm, journal_code)
            End If
        Catch
        End Try
        'Try
        '    Dim bid As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("book_id")
        '    If Not bid Is Nothing Then
        '        bid.SetValue(objForm, cmbBook.SelectedValue.ToString)
        '    End If
        'Catch
        'End Try
        Try

            Dim mo As System.Reflection.PropertyInfo = objForm.Controls("hdr").Controls("txtmonth").GetType.GetProperty("Value")
            If Not mo Is Nothing Then
                mo.SetValue(objForm.Controls("hdr").Controls("txtmonth"), (cmbMonth.SelectedIndex + 1).ToString)
            End If
            Dim mn As System.Reflection.PropertyInfo = objForm.Controls("hdr").Controls("txtmonth").GetType.GetProperty("Text")
            If Not mn Is Nothing Then
                mn.SetValue(objForm.Controls("hdr").Controls("txtmonth"), cmbMonth.SelectedItem)
            End If
        Catch
        End Try
        Try
            Dim myr As System.Reflection.PropertyInfo = objForm.Controls("hdr").Controls("txtyear").GetType.GetProperty("Text")
            If Not myr Is Nothing Then
                myr.SetValue(objForm.Controls("hdr").Controls("txtyear"), numYear.Value.ToString)
            End If
        Catch
        End Try
        Try
            Dim par As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("MdiParent")
            If Not par Is Nothing Then
                par.SetValue(objForm, main)
            End If
        Catch
        End Try
        Try
            Dim stp As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("StartPosition")
            If Not stp Is Nothing Then
                stp.SetValue(objForm, FormStartPosition.CenterParent)
            End If
        Catch
        End Try

        'raymond - 2016-06-08
        cashcv.book_code = cmbBook.Text
        'raymond
        If objForm IsNot Nothing Then
            ShowOrOpenForm(objForm)
        Else
            MsgBox("Something went wrong")
        End If
        Me.Hide()
    End Sub
#End Region
#Region "Events"

    Private Sub settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not toClose Then
            e.Cancel = True
            Me.Hide()
        Else
            frmTransaction.Close()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Private Sub numYear_ValueChanged(sender As Object, e As EventArgs) Handles numYear.ValueChanged
        Dim month = cmbMonth.SelectedValue
        Dim year = numYear.Value
        If month < minDate.Month Then
            If year = minDate.Year Then
                cmbMonth.SelectedIndex = minDate.Month - 1
            End If
        End If
    End Sub
    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        Dim month = cmbMonth.SelectedIndex
        Dim year = numYear.Value
        If year = minDate.Year Then
            If month < minDate.Month - 1 Then
                cmbMonth.SelectedIndex = minDate.Month - 1
            End If
        End If
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        bookNamex = cmbBook.Text
        Dim month_name As String = cmbMonth.SelectedText
        Dim month As String = cmbMonth.SelectedValue
        Dim currentDate As DateTime = DateTime.Now
        Dim curr_date As Date = Today
        Dim sel_date As Date = New Date(numYear.Value, month, 1)
        If sel_date > currentDate Then
            MsgBox("Invalid Date. ")
            cmbMonth.Text = DateTime.Today.ToString("MMMM")
        Else
            Dim year As String = numYear.Value
            book_name = cmbBook.Text
            Dim book As String = cmbBook.SelectedValue
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
                    Dim propJournalID As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("JournalID")
                    If Not propJournalID Is Nothing Then
                        propJournalID.SetValue(frmTransaction, journal_id)
                    End If
                Catch
                End Try
                Try
                    Dim propJournalName As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("JournalCode")
                    If Not propJournalName Is Nothing Then
                        propJournalName.SetValue(frmTransaction, journal_name)
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
                frmTransaction.Refresh()
                frmTransaction.TopMost = True
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
    End Sub
#End Region
End Class