Imports DevExpress.XtraReports.UI
Imports libacctng.myFunctions

Public Class report_account_analysis_print_1
    Private Sub cellToNull(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles cellNetDebit.BeforePrint, cellNetDebit.BeforePrint, XrTableCell17.BeforePrint, XrTableCell48.BeforePrint, XrTableCell47.BeforePrint, XrTableCell43.BeforePrint, XrTableCell42.BeforePrint, XrTableCell33.BeforePrint, XrTableCell32.BeforePrint, XrTableCell28.BeforePrint, XrTableCell27.BeforePrint, XrTableCell23.BeforePrint, XrTableCell22.BeforePrint, XrTableCell18.BeforePrint, cellNetDebit.BeforePrint, cellNetCredit.BeforePrint
        Dim label = CType(sender, XRLabel)
        label.Text = label.Text.Trim()
        If label.Text <> "" Then
            Dim num = CType(IIf(ifNull(label.Text.Replace(",", ""), "") = "", 0, label.Text.Replace(",", "")), Decimal)
            If num = 0 Then
                label.Text = ""
            End If
        End If
        If sender.Text <> "" Then
            Dim num = CType(IIf(ifNull(sender.Text.Replace(",", ""), ""), 0, sender.Text.Replace(",", "")), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub cellToNull1(sender As Object, e As TextFormatEventArgs) Handles cellNetDebit.SummaryCalculated, cellNetDebit.SummaryCalculated, XrTableCell22.SummaryCalculated, XrTableCell48.SummaryCalculated, XrTableCell47.SummaryCalculated, XrTableCell43.SummaryCalculated, XrTableCell42.SummaryCalculated, XrTableCell33.SummaryCalculated, XrTableCell32.SummaryCalculated, XrTableCell28.SummaryCalculated, XrTableCell27.SummaryCalculated, XrTableCell23.SummaryCalculated, cellNetDebit.SummaryCalculated, cellNetCredit.SummaryCalculated
        Dim label = CType(sender, XRLabel)
        Dim num = CType(IIf(ifNull(e.Value, "").ToString = "", 0, e.Value), Decimal)
        If num = 0 Then
            e.Text = ""
        End If
        If sender.Text <> "" Then
            Dim num2 = CType(IIf(ifNull(sender.Text.Replace(",", ""), "") = "", 0, sender.Text.Replace(",", "")), Decimal)
            If num2 < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell19_SummaryCalculated(sender As Object, e As TextFormatEventArgs)
        If ifNull(e.Value, "").ToString <> "" Then
            Dim num = CType(IIf(ifNull(e.Value.ToString.Replace(",", ""), "") = "", 0, e.Value.ToString.Replace(",", "")), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub

    Private Sub WhosGreater(sender As Object, e As TextFormatEventArgs)

    End Sub


End Class