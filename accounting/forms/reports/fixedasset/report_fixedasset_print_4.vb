Imports DevExpress.XtraReports.UI

Public Class report_fixedasset_print_4
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell20.BeforePrint, XrTableCell24.BeforePrint, XrTableCell22.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub isNegative1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell33.SummaryCalculated, XrTableCell60.SummaryCalculated, XrTableCell58.SummaryCalculated, XrTableCell56.SummaryCalculated, XrTableCell54.SummaryCalculated, XrTableCell52.SummaryCalculated, XrTableCell48.SummaryCalculated, XrTableCell46.SummaryCalculated, XrTableCell44.SummaryCalculated, XrTableCell42.SummaryCalculated, XrTableCell40.SummaryCalculated, XrTableCell37.SummaryCalculated, XrTableCell35.SummaryCalculated, XrTableCell32.SummaryCalculated, XrTableCell30.SummaryCalculated
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
End Class