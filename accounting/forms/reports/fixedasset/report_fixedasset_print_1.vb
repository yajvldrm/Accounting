Imports DevExpress.XtraReports.UI

Public Class report_fixedasset_print_1
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell17.BeforePrint, XrTableCell45.BeforePrint, det6.BeforePrint, det5.BeforePrint, det4.BeforePrint, det3.BeforePrint, det2.BeforePrint, det1.BeforePrint, XrTableCell19.BeforePrint, XrTableCell18.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub isNegative1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell28.SummaryCalculated, cur6.SummaryCalculated, tot6.SummaryCalculated, tot5.SummaryCalculated, tot4.SummaryCalculated, tot3.SummaryCalculated, tot2.SummaryCalculated, tot1.SummaryCalculated, XrTableCell81.SummaryCalculated, XrTableCell80.SummaryCalculated, XrTableCell79.SummaryCalculated, cur5.SummaryCalculated, XrTableCell77.SummaryCalculated, cur4.SummaryCalculated, cur3.SummaryCalculated, cur2.SummaryCalculated, cur1.SummaryCalculated, XrTableCell71.SummaryCalculated, XrTableCell70.SummaryCalculated, XrTableCell69.SummaryCalculated, XrTableCell68.SummaryCalculated, XrTableCell66.SummaryCalculated, proj6.SummaryCalculated, proj5.SummaryCalculated, proj4.SummaryCalculated, proj3.SummaryCalculated, proj2.SummaryCalculated, proj1.SummaryCalculated, XrTableCell59.SummaryCalculated, XrTableCell58.SummaryCalculated, XrTableCell57.SummaryCalculated, XrTableCell56.SummaryCalculated, XrTableCell55.SummaryCalculated, dept6.SummaryCalculated, dept5.SummaryCalculated, dept4.SummaryCalculated, dept3.SummaryCalculated, dept2.SummaryCalculated, dept1.SummaryCalculated, XrTableCell48.SummaryCalculated, XrTableCell47.SummaryCalculated, XrTableCell46.SummaryCalculated, acc6.SummaryCalculated, acc5.SummaryCalculated, acc4.SummaryCalculated, acc3.SummaryCalculated, acc2.SummaryCalculated, acc1.SummaryCalculated, XrTableCell30.SummaryCalculated, XrTableCell29.SummaryCalculated
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
End Class