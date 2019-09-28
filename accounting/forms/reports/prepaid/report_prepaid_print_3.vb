Imports DevExpress.XtraReports.UI

Public Class report_prepaid_print_3
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell20.BeforePrint, XrTableCell25.BeforePrint, XrTableCell24.BeforePrint, XrTableCell23.BeforePrint, XrTableCell22.BeforePrint, XrTableCell21.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub isNegative1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell33.SummaryCalculated, XrTableCell61.SummaryCalculated, XrTableCell60.SummaryCalculated, XrTableCell59.SummaryCalculated, XrTableCell58.SummaryCalculated, XrTableCell57.SummaryCalculated, XrTableCell56.SummaryCalculated, XrTableCell55.SummaryCalculated, XrTableCell54.SummaryCalculated, XrTableCell53.SummaryCalculated, XrTableCell52.SummaryCalculated, XrTableCell50.SummaryCalculated, XrTableCell49.SummaryCalculated, XrTableCell48.SummaryCalculated, XrTableCell47.SummaryCalculated, XrTableCell46.SummaryCalculated, XrTableCell45.SummaryCalculated, XrTableCell44.SummaryCalculated, XrTableCell42.SummaryCalculated, XrTableCell41.SummaryCalculated, XrTableCell40.SummaryCalculated, XrTableCell39.SummaryCalculated, XrTableCell38.SummaryCalculated, XrTableCell37.SummaryCalculated, XrTableCell36.SummaryCalculated, XrTableCell35.SummaryCalculated, XrTableCell34.SummaryCalculated, XrTableCell32.SummaryCalculated, XrTableCell31.SummaryCalculated, XrTableCell30.SummaryCalculated
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
End Class