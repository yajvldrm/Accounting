Imports DevExpress.XtraReports.UI
Imports libacctng.myFunctions
Public Class accountanalysisReport


    Private Sub cellToNull(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell2.BeforePrint, XrTableCell4.BeforePrint, XrTableCell7.BeforePrint, XrTableCell8.BeforePrint, XrTableCell22.BeforePrint, XrTableCell23.BeforePrint, XrTableCell29.BeforePrint, XrTableCell30.BeforePrint, XrTableCell10.BeforePrint, XrTableCell19.BeforePrint, XrTableCell34.BeforePrint, XrTableCell35.BeforePrint, XrTableCell32.BeforePrint, XrTableCell33.BeforePrint, XrTableCell36.BeforePrint, XrTableCell37.BeforePrint, XrTableCell47.BeforePrint, XrTableCell48.BeforePrint, XrTableCell27.BeforePrint, XrTableCell28.BeforePrint, XrTableCell41.BeforePrint, XrTableCell42.BeforePrint
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
    Private Sub cellToNull1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell2.SummaryCalculated, XrTableCell4.SummaryCalculated, XrTableCell7.SummaryCalculated, XrTableCell8.SummaryCalculated, XrTableCell22.SummaryCalculated, XrTableCell23.SummaryCalculated, XrTableCell29.SummaryCalculated, XrTableCell30.SummaryCalculated, XrTableCell10.SummaryCalculated, XrTableCell19.SummaryCalculated, XrTableCell34.SummaryCalculated, XrTableCell35.SummaryCalculated, XrTableCell32.SummaryCalculated, XrTableCell33.SummaryCalculated, XrTableCell36.SummaryCalculated, XrTableCell37.SummaryCalculated, XrTableCell47.SummaryCalculated, XrTableCell48.SummaryCalculated, XrTableCell27.SummaryCalculated, XrTableCell28.SummaryCalculated, XrTableCell41.SummaryCalculated, XrTableCell42.SummaryCalculated
        Dim label = CType(sender, XRLabel)
        Dim num = CType(IIf(ifNull(e.Value, 0) = Nothing, 0, e.Value), Decimal)
        If num = 0 Then
            e.Text = 0.00
        End If
        If sender.Text <> "" Then
            Dim num2 = CType(IIf(ifNull(sender.Text.Replace(",", ""), ""), 0, sender.Text.Replace(",", "")), Decimal)
            If num2 < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub XrTableCell42_SummaryCalculated(sender As Object, e As TextFormatEventArgs)
        If e.Value.ToString <> "" Then
            Dim num = CType(IIf(ifNull(e.Value.ToString.Replace(",", ""), "") = "", 0, e.Value.ToString.Replace(",", "")), Decimal)
            If num < 0 Then
                e.Text = "(" & e.Text.ToString.Replace("-", "") & ")"
            End If
        End If
    End Sub
End Class