Imports DevExpress.XtraReports.UI
Imports libacctng.myFunctions

Public Class accountanalysisReport1
    Private Sub cellToNull(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles cellNetDebit.BeforePrint, cellNetCredit.BeforePrint, XrTableCell17.BeforePrint, XrTableCell18.BeforePrint, XrTableCell47.BeforePrint, XrTableCell48.BeforePrint
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
    Private Sub cellToNull1(sender As Object, e As TextFormatEventArgs) Handles cellNetDebit.SummaryCalculated, cellNetCredit.SummaryCalculated, XrTableCell17.SummaryCalculated, XrTableCell18.SummaryCalculated, XrTableCell47.SummaryCalculated, XrTableCell48.SummaryCalculated
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
End Class