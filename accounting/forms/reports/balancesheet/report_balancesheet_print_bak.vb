Imports DevExpress.XtraReports.UI

Public Class report_balancesheet_print_bak
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell9.BeforePrint, XrTableCell13.BeforePrint, XrTableCell11.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub isNegative1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell27.SummaryCalculated, XrTableCell31.SummaryCalculated, XrTableCell29.SummaryCalculated, XrTableCell25.SummaryCalculated, XrTableCell23.SummaryCalculated, XrTableCell21.SummaryCalculated, XrTableCell19.SummaryCalculated, XrTableCell17.SummaryCalculated, XrTableCell15.SummaryCalculated
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
End Class