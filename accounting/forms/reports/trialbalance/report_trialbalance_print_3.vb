Imports DevExpress.XtraReports.UI

Public Class report_trialbalance_print_3
    Private Sub cellToNull(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell10.BeforePrint, XrTableCell7.BeforePrint, XrTableCell6.BeforePrint, XrTableCell45.BeforePrint, XrTableCell44.BeforePrint, XrTableCell43.BeforePrint, XrTableCell42.BeforePrint, XrTableCell41.BeforePrint, XrTableCell40.BeforePrint, XrTableCell4.BeforePrint, XrTableCell36.BeforePrint, XrTableCell35.BeforePrint, XrTableCell34.BeforePrint, XrTableCell33.BeforePrint, XrTableCell32.BeforePrint, XrTableCell31.BeforePrint, XrTableCell28.BeforePrint, XrTableCell27.BeforePrint, XrTableCell25.BeforePrint, XrTableCell24.BeforePrint, XrTableCell23.BeforePrint, XrTableCell22.BeforePrint, XrTableCell19.BeforePrint, XrTableCell18.BeforePrint
        Dim label = CType(sender, XRLabel)
        If label.Text <> "" Then
            Dim num = CType(label.Text, Decimal)
            If num = 0 Then
                label.Text = ""
            End If
        End If
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell22_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell22.SummaryCalculated, XrTableCell23.SummaryCalculated, XrTableCell24.SummaryCalculated, XrTableCell25.SummaryCalculated, XrTableCell28.SummaryCalculated, XrTableCell27.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell40_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell40.SummaryCalculated, XrTableCell41.SummaryCalculated, XrTableCell42.SummaryCalculated, XrTableCell43.SummaryCalculated, XrTableCell44.SummaryCalculated, XrTableCell45.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
End Class