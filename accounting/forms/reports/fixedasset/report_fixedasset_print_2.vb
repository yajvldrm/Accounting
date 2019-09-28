Imports DevExpress.XtraReports.UI

Public Class report_fixedasset_print_2
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell17.BeforePrint, XrTableCell89.BeforePrint, det12.BeforePrint, det11.BeforePrint, det10.BeforePrint, det9.BeforePrint, det8.BeforePrint, det7.BeforePrint, XrTableCell19.BeforePrint, XrTableCell18.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub isNegative1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell28.SummaryCalculated, XrTableCell93.SummaryCalculated, XrTableCell92.SummaryCalculated, XrTableCell91.SummaryCalculated, XrTableCell90.SummaryCalculated, XrTableCell87.SummaryCalculated, XrTableCell86.SummaryCalculated, XrTableCell85.SummaryCalculated, tot12.SummaryCalculated, tot11.SummaryCalculated, tot10.SummaryCalculated, tot9.SummaryCalculated, tot8.SummaryCalculated, tot7.SummaryCalculated, XrTableCell78.SummaryCalculated, XrTableCell75.SummaryCalculated, XrTableCell74.SummaryCalculated, cur12.SummaryCalculated, cur11.SummaryCalculated, cur10.SummaryCalculated, cur9.SummaryCalculated, cur8.SummaryCalculated, cur7.SummaryCalculated, XrTableCell67.SummaryCalculated, XrTableCell64.SummaryCalculated, XrTableCell63.SummaryCalculated, proj12.SummaryCalculated, proj11.SummaryCalculated, proj10.SummaryCalculated, proj9.SummaryCalculated, proj8.SummaryCalculated, proj7.SummaryCalculated, XrTableCell56.SummaryCalculated, XrTableCell54.SummaryCalculated, XrTableCell53.SummaryCalculated, dept12.SummaryCalculated, dept11.SummaryCalculated, dept10.SummaryCalculated, dept9.SummaryCalculated, dept8.SummaryCalculated, dept7.SummaryCalculated, XrTableCell46.SummaryCalculated, acc12.SummaryCalculated, acc11.SummaryCalculated, acc10.SummaryCalculated, acc9.SummaryCalculated, acc8.SummaryCalculated, acc7.SummaryCalculated, XrTableCell30.SummaryCalculated, XrTableCell29.SummaryCalculated
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
End Class