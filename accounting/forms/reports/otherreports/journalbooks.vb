Public Class journalbooks
    Private Sub ZeroToDashBF(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell25.BeforePrint, XrTableCell24.BeforePrint, XrTableCell21.BeforePrint, XrTableCell20.BeforePrint, XrTableCell18.BeforePrint, XrTableCell17.BeforePrint, XrTableCell11.BeforePrint, XrTableCell10.BeforePrint
        If sender.Text.ToString.Trim = "" Or sender.Text.ToString.Trim = "-" Then
            sender.Text = "-"
        ElseIf CDec(sender.Text.ToString.Trim) = 0 Then
            sender.Text = "-"
        End If
    End Sub

    Private Sub ZeroToDashSC(sender As Object, e As DevExpress.XtraReports.UI.TextFormatEventArgs) Handles XrTableCell17.SummaryCalculated, XrTableCell17.SummaryCalculated, XrTableCell25.SummaryCalculated, XrTableCell24.SummaryCalculated, XrTableCell20.SummaryCalculated, XrTableCell21.SummaryCalculated, XrTableCell18.SummaryCalculated
        If CDec(e.Value) = 0 Then
            e.Text = "-"
        End If
    End Sub
End Class