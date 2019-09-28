Imports DevExpress.XtraReports.UI

Public Class report_prepaid_print_1
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell17.BeforePrint, XrTableCell45.BeforePrint, XrTableCell37.BeforePrint, XrTableCell36.BeforePrint, XrTableCell35.BeforePrint, XrTableCell34.BeforePrint, XrTableCell33.BeforePrint, XrTableCell20.BeforePrint, XrTableCell19.BeforePrint, XrTableCell18.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub isNegative1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell28.SummaryCalculated, XrTableCell88.SummaryCalculated, XrTableCell87.SummaryCalculated, XrTableCell86.SummaryCalculated, XrTableCell85.SummaryCalculated, XrTableCell84.SummaryCalculated, XrTableCell83.SummaryCalculated, XrTableCell82.SummaryCalculated, XrTableCell81.SummaryCalculated, XrTableCell80.SummaryCalculated, XrTableCell79.SummaryCalculated, XrTableCell78.SummaryCalculated, XrTableCell77.SummaryCalculated, XrTableCell75.SummaryCalculated, XrTableCell74.SummaryCalculated, XrTableCell73.SummaryCalculated, XrTableCell72.SummaryCalculated, XrTableCell71.SummaryCalculated, XrTableCell70.SummaryCalculated, XrTableCell69.SummaryCalculated, XrTableCell68.SummaryCalculated, XrTableCell66.SummaryCalculated, XrTableCell65.SummaryCalculated, XrTableCell64.SummaryCalculated, XrTableCell63.SummaryCalculated, XrTableCell62.SummaryCalculated, XrTableCell61.SummaryCalculated, XrTableCell60.SummaryCalculated, XrTableCell59.SummaryCalculated, XrTableCell58.SummaryCalculated, XrTableCell57.SummaryCalculated, XrTableCell56.SummaryCalculated, XrTableCell55.SummaryCalculated, XrTableCell54.SummaryCalculated, XrTableCell53.SummaryCalculated, XrTableCell52.SummaryCalculated, XrTableCell51.SummaryCalculated, XrTableCell50.SummaryCalculated, XrTableCell49.SummaryCalculated, XrTableCell48.SummaryCalculated, XrTableCell47.SummaryCalculated, XrTableCell46.SummaryCalculated, XrTableCell42.SummaryCalculated, XrTableCell41.SummaryCalculated, XrTableCell40.SummaryCalculated, XrTableCell39.SummaryCalculated, XrTableCell38.SummaryCalculated, XrTableCell31.SummaryCalculated, XrTableCell30.SummaryCalculated, XrTableCell29.SummaryCalculated
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
End Class