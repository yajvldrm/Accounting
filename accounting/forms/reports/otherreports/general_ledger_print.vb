Public Class general_ledger_print
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell9.BeforePrint, XrTableCell10.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
End Class