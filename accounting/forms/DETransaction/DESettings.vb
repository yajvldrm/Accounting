Imports DevExpress.XtraEditors
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class DESettings
    Private isLoadEnd As Boolean = False
    Public Property sys_beg As Date = Today
    Public Property minDate As Date = Today
    Public Property journal_id As String = ""
    Public Property journal_code As String = ""
    Public Property journal_name As String = ""
    Public Property frmTransaction As XtraForm = Nothing
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        Me.Hide()
    End Sub

    Private Sub DESettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isLoadEnd Then
            journal_book_ta.Fill(DEFileSetupSet.get_journal_book, journal_id)
            txtYear.Value = Today.Year
            txtYear.Minimum = minDate.Year
            txtMonth.EditValue = Today.Month
            If txtMonth.EditValue < minDate.Month Then
                If txtYear.Value = minDate.Year Then
                    txtMonth.EditValue = minDate.Month
                End If
            End If
            isLoadEnd = True
        End If
    End Sub

    Private Sub txtYear_ValueChanged(sender As Object, e As EventArgs) Handles txtYear.ValueChanged
        Dim month = txtMonth.EditValue
        Dim year = txtYear.Value
        If month < minDate.Month Then
            If year = minDate.Year Then
                txtMonth.EditValue = minDate.Month
            End If
        End If
    End Sub

    Private Sub txtMonth_EditValueChanged(sender As Object, e As EventArgs) Handles txtMonth.EditValueChanged
        Dim month = txtMonth.EditValue
        Dim year = txtYear.Value
        If year = minDate.Year Then
            If month < minDate.Month - 1 Then
                txtMonth.EditValue = minDate.Month
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim month_name As String = txtMonth.Text
        Dim month As Integer = txtMonth.EditValue
        Dim year As Integer = txtYear.Value
        Dim book_name As String = txtBookID.Text
        Dim book As String = txtBookID.EditValue
        If book = "" Then
            MsgBox("No Book Selected")
            Exit Sub
        End If
        If frmTransaction IsNot Nothing Then
            Try
                Dim propBookID As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("BookID")
                If Not propBookID Is Nothing Then
                    propBookID.SetValue(frmTransaction, book)
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
                Dim propJournalName As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("JournalName")
                If Not propJournalName Is Nothing Then
                    propJournalName.SetValue(frmTransaction, journal_name)
                End If
            Catch
            End Try
            Try
                Dim propMonth As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("TransactionMonth")
                If Not propMonth Is Nothing Then
                    propMonth.SetValue(frmTransaction, month)
                End If
            Catch
            End Try
            Try
                Dim propYear As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("TransactionYear")
                If Not propYear Is Nothing Then
                    propYear.SetValue(frmTransaction, year)
                End If
            Catch
            End Try
            Try
                Dim propSettings As System.Reflection.PropertyInfo = frmTransaction.GetType.GetProperty("MySettings")
                If Not propSettings Is Nothing Then
                    propSettings.SetValue(_frmTransaction, Me)
                End If
            Catch
            End Try
            showForm(frmTransaction, main)
            frmTransaction.Refresh()
            frmTransaction.TopMost = True
            Me.Hide()
        End If
    End Sub
End Class