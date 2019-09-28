Imports DevExpress.XtraReports.UI

Public Class report_trialbalance_print_1
    Private Sub cellToNull(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell10.BeforePrint, XrTableCell21.BeforePrint, XrTableCell20.BeforePrint, XrTableCell18.BeforePrint, XrTableCell17.BeforePrint, XrTableCell14.BeforePrint, XrTableCell13.BeforePrint, XrTableCell11.BeforePrint
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
    Private Sub XrTableCell17_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell17.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell18_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell18.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell20_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell20.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell21_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell21.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
End Class