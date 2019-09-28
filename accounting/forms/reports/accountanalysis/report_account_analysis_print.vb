Imports DevExpress.XtraReports.UI
Imports libacctng.myFunctions

Public Class report_account_analysis_print
    Private Sub cellToNull(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell66.BeforePrint, XrTableCell65.BeforePrint, XrTableCell64.BeforePrint, XrTableCell63.BeforePrint, XrTableCell50.BeforePrint, XrTableCell49.BeforePrint, XrTableCell48.BeforePrint, XrTableCell47.BeforePrint, XrTableCell45.BeforePrint, XrTableCell44.BeforePrint, XrTableCell43.BeforePrint, XrTableCell42.BeforePrint, XrTableCell35.BeforePrint, XrTableCell34.BeforePrint, XrTableCell33.BeforePrint, XrTableCell32.BeforePrint, XrTableCell30.BeforePrint, XrTableCell29.BeforePrint, XrTableCell28.BeforePrint, XrTableCell27.BeforePrint, XrTableCell25.BeforePrint, XrTableCell24.BeforePrint, XrTableCell23.BeforePrint, XrTableCell22.BeforePrint, XrTableCell20.BeforePrint, XrTableCell19.BeforePrint, XrTableCell18.BeforePrint, XrTableCell17.BeforePrint
        Dim label = CType(sender, XRLabel)
        If label.Text <> "" Then
            Dim num = CType(label.Text, Decimal)
            If num = 0 Then
                label.Text = ""
            End If
        End If

        If sender.Text <> "" Then
            Dim num = CType(IIf(ifNull(sender.Text.Replace(",", ""), "") = "", 0, ifNull(sender.Text.Replace(",", ""), "")), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub cellToNull1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell66.SummaryCalculated, XrTableCell65.SummaryCalculated, XrTableCell64.SummaryCalculated, XrTableCell63.SummaryCalculated, XrTableCell50.SummaryCalculated, XrTableCell49.SummaryCalculated, XrTableCell48.SummaryCalculated, XrTableCell47.SummaryCalculated, XrTableCell45.SummaryCalculated, XrTableCell44.SummaryCalculated, XrTableCell43.SummaryCalculated, XrTableCell42.SummaryCalculated, XrTableCell35.SummaryCalculated, XrTableCell34.SummaryCalculated, XrTableCell33.SummaryCalculated, XrTableCell32.SummaryCalculated, XrTableCell30.SummaryCalculated, XrTableCell29.SummaryCalculated, XrTableCell28.SummaryCalculated, XrTableCell27.SummaryCalculated, XrTableCell25.SummaryCalculated, XrTableCell24.SummaryCalculated, XrTableCell23.SummaryCalculated, XrTableCell22.SummaryCalculated
        Dim label = CType(sender, XRLabel)
        Dim num = CType(IIf(ifNull(e.Value, "") = "", 0, e.Value), Decimal)
        If num = 0 Then
            e.Text = ""
        End If
        If sender.Text <> "" Then
            Dim num2 = CType(IIf(ifNull(sender.Text.Replace(",", ""), ""), 0, sender.Text.Replace(",", "")), Decimal)
            If num2 < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell66_SummaryCalculated(sender As Object, e As TextFormatEventArgs)

    End Sub
    Private Sub XrTableCell64_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles lbl_net_debit_based.SummaryCalculated, lbl_net_credit_based.SummaryCalculated, lbl_net_based.SummaryCalculated
        If e.Value.ToString <> "" Then
            Dim num = CType(IIf(ifNull(e.Value.ToString.Replace(",", ""), "") = "", 0, e.Value.ToString.Replace(",", "")), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
End Class