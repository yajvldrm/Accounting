Imports DevExpress.XtraReports.UI

Public Class report_trialbalance_print_2
    Private Sub cellToNull(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell10.BeforePrint, XrTableCell7.BeforePrint, XrTableCell6.BeforePrint, XrTableCell4.BeforePrint, XrTableCell28.BeforePrint, XrTableCell27.BeforePrint, XrTableCell25.BeforePrint, XrTableCell24.BeforePrint, XrTableCell23.BeforePrint, XrTableCell22.BeforePrint, XrTableCell19.BeforePrint, XrTableCell18.BeforePrint
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
    Private Sub XrTableCell22_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell22.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell23_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell23.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell24_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell24.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell25_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell25.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell27_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell27.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell28_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell28.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
End Class