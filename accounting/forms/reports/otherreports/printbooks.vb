Imports DevExpress.XtraReports.UI

Public Class printbooks
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell10.BeforePrint, XrTableCell11.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub isNegative1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell17.SummaryCalculated, XrTableCell21.SummaryCalculated, XrTableCell20.SummaryCalculated, XrTableCell18.SummaryCalculated
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
End Class