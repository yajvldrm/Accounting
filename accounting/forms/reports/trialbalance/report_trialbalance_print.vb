Imports DevExpress.XtraReports.UI
Imports libacctng.myFunctions

Public Class report_trialbalance_print
    Private Sub cellToNull(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell8.BeforePrint, XrTableCell9.BeforePrint, XrTableCell14.BeforePrint, XrTableCell13.BeforePrint
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
    Private Sub XrTableCell13_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell13.SummaryCalculated
        If e.Value IsNot Nothing Then
            If e.Value.ToString <> "" Then
                Dim num = CType(e.Value.ToString.Replace(",", ""), Decimal)
                If num < 0 Then
                    e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
                End If
            End If
        End If
    End Sub
    Private Sub XrTableCell14_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles XrTableCell14.SummaryCalculated
        'If e.Value.ToString <> "" Then
        '    Dim num = CType(IIf(ifNull(e.Value.ToString.Replace(",", ""), "") = "", 0, e.Value.ToString.Replace(",", "")), Decimal)
        '    If num < 0 Then
        '        e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
        '    End If
        'End If
    End Sub
End Class