Public Class currency_rate
    Friend Sub InitializeDecimalPlaces(Optional decimalPlaces As Integer = 2)
        Dim numberFormat As String = "#,##0"
        Dim decimalFormat As String = ""
        For i As Integer = 0 To decimalPlaces - 1
            decimalFormat &= "0"
        Next
        If decimalFormat <> "" Then
            numberFormat &= "." & decimalFormat
        End If
        MyTextBox6.NumberFormat = numberFormat
        MyTextBox5.NumberFormat = numberFormat
    End Sub
    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        MyTextBox5.AlwaysDisable = True
        txt_currency_id.AlwaysDisable = False
        txt_currency_id.NoClear = False
        txt_currency_name.NoClear = False
        txt_symbol.NoClear = False
        If dgMain.Rows.Count = 0 Then
            txt_currency_id.Enabled = True
            txt_currency_id.Value = main.Sys_Default.Rows(0).Item("currency_id").ToString
            txt_currency_id.Text = main.Sys_Default.Rows(0).Item("currency_code").ToString
            txt_currency_name.Text = main.Sys_Default.Rows(0).Item("currency_name").ToString
            txt_symbol.Text = main.Sys_Default.Rows(0).Item("symbol").ToString
            txt_currency_id.NoClear = True
            txt_currency_name.NoClear = True
            txt_symbol.NoClear = True
            txt_currency_id.Enabled = False
            MyTextBox5.AlwaysDisable = False
            txt_currency_id.AlwaysDisable = True
        End If
        If dgMain.Rows.Count > 0 Then
            Dim ds = dgMain.DataSource
            Dim _dt As New DataTable
            If TypeOf ds Is DataSet Then
                _dt = ds.Tables(0)
            Else
                _dt = ds
            End If
            Dim dv As New DataView(_dt)
            dv.Sort = "currency_rate_id ASC"
            Dim dt As DataTable = dv.ToTable()
            Dim rate As Decimal = CDec(dt.Rows(0).Item("based_rate").ToString)
            MyTextBox5.DecimalValue = rate
        End If
    End Sub

    Private Sub MyTextBox6_TextChanged(sender As Object, e As EventArgs) Handles MyTextBox6.TextChanged
        If dgMain.Rows.Count = 0 Then
            MyTextBox5.DecimalValue = MyTextBox6.DecimalValue
        End If
    End Sub
End Class