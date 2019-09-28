Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class filter
    Dim err As New ErrorProvider
    Private Function testRequiredFields(ByVal obj As user_control.textbox) As Boolean

        Dim hasError As Boolean = False
        If obj.Value = "" Then
            err.SetError(obj, "This is required field and cannot be empty")
            hasError = True
        Else
            err.SetError(obj, "")
        End If
        Return hasError

    End Function
    
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim frm As String = "fs" & journal_code.ToLower
        Dim ProjAndForm = "accounting." & frm  '' String Of Your Project And Form Name
        Dim objType As Type = Type.[GetType](ProjAndForm) '' Get Type Of your string
        Dim objForm As Control = DirectCast(Activator.CreateInstance(objType), Control) '' Convert Type to Control and now you can use this Control

        Dim begbal_date = txt_sys_beg.Value
        Dim book = txt_book.Value
        Dim currency = txt_currency.Value

        Dim ctr_for_err As Integer = 0

        'If testRequiredFields(txt_begbal_date) Then
        '    ctr_for_err += 1
        'End If

        If testRequiredFields(txt_book) Then
            ctr_for_err += 1
        End If

        If testRequiredFields(txt_currency) Then
            ctr_for_err += 1
        End If


        If ctr_for_err > 0 Then
            MsgBox("There are required field that cannot be empty.")
        Else
            'query para ma select lahat ng gl_begbal

            Try
                Dim jid As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("journal_id")
                If Not jid Is Nothing Then
                    jid.SetValue(objForm, journal_id, Nothing)
                End If
            Catch
            End Try
            Try
                Dim bid As System.Reflection.PropertyInfo = objForm.GetType.GetProperty("book_id")
                If Not bid Is Nothing Then
                    bid.SetValue(objForm, book, Nothing)
                End If
            Catch
            End Try
            Try
                Dim mo As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_trans_date").GetType.GetProperty("Value")
                If Not mo Is Nothing Then
                    mo.SetValue(objForm.Controls("panel_hdr").Controls("txt_trans_date"), txt_sys_beg.Value, Nothing)
                End If
            Catch
            End Try
            Try
                Dim mo As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_book_id").GetType.GetProperty("Value")
                If Not mo Is Nothing Then
                    mo.SetValue(objForm.Controls("panel_hdr").Controls("txt_book_id"), txt_book.Value, Nothing)
                End If
                Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_book_id").GetType.GetProperty("Text")
                If Not mn Is Nothing Then
                    mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_book_id"), txt_book.Text, Nothing)
                End If
                Dim mp As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_book_id").GetType.GetProperty("RowData")
                If Not mp Is Nothing Then
                    mp.SetValue(objForm.Controls("panel_hdr").Controls("txt_book_id"), txt_book.RowData, Nothing)
                End If
            Catch
            End Try
            Try
                Dim mo As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_currency_id").GetType.GetProperty("Value")
                If Not mo Is Nothing Then
                    mo.SetValue(objForm.Controls("panel_hdr").Controls("txt_currency_id"), txt_currency.Value, Nothing)
                End If
                Dim mn As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_currency_id").GetType.GetProperty("Text")
                If Not mn Is Nothing Then
                    mn.SetValue(objForm.Controls("panel_hdr").Controls("txt_currency_id"), txt_currency.Text, Nothing)
                End If
                Dim mp As System.Reflection.PropertyInfo = objForm.Controls("panel_hdr").Controls("txt_currency_id").GetType.GetProperty("RowData")
                If Not mp Is Nothing Then
                    mp.SetValue(objForm.Controls("panel_hdr").Controls("txt_currency_id"), txt_currency.RowData, Nothing)
                End If
            Catch
            End Try
            showForm(objForm, main)
            Me.Hide()
        End If

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txt_book_Leave(sender As Object, e As EventArgs) Handles txt_book.Leave

        Dim dt As DataTable = FsQuery(String.Format("SELECT * FROM lib_erp_book WHERE company_id = '{0}'", main.Sys_Default.Rows(0).Item("company_id").ToString))
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("book_name like '{0}'", txt_book.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "book_code,book_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_book.RowData = dr
                txt_book.Value = dr("book_id")
                txt_book.Text = dr("book_name")
            End If
        End If

    End Sub

    Private Sub txt_currency_Leave(sender As Object, e As EventArgs) Handles txt_currency.Leave

        Dim dt As DataTable = FsQuery("SELECT * FROM lib_erp_currency")
        If dt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If dt.Rows.Count = 1 Then
                dr = dt.Rows(0)
            Else
                Dim dra() As DataRow = dt.Select(String.Format("currency_name like '{0}'", txt_currency.Text.ToString.Replace("'", "''")))
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = dt
                    browse.format("Code,Name", "currency_code,currency_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_currency.RowData = dr
                txt_currency.Value = dr("currency_id")
                txt_currency.Text = dr("currency_name")
            End If
        End If

    End Sub

    Private _journalid As String
    Private _journalcode As String
    Private _sys_beg As DateTime

    Public Property journal_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _journalid
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _journalid = value
        End Set
    End Property

    Public Property journal_code() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _journalcode
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _journalcode = value
        End Set
    End Property
    Public Property sys_beg() As DateTime
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _sys_beg
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As DateTime)
            _sys_beg = value
        End Set
    End Property

    Private Sub filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_sys_beg.Value = sys_beg.ToString
    End Sub

End Class