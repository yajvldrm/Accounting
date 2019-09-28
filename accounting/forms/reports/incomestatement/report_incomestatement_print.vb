Imports DevExpress.XtraReports.UI

Public Class report_incomestatement_print
    Dim ctr_af As Integer = 0
    Dim diff_af As New Dictionary(Of Integer, Decimal)
    Dim sum_af As Decimal = 0
    Dim ctr_cm As Integer = 0
    Dim diff_cm As New Dictionary(Of Integer, Decimal)
    Dim sum_cm As Decimal = 0
    Dim ctr_total As Integer = 0
    Dim diff_total As New Dictionary(Of Integer, Decimal)
    Dim sum_total As Decimal = 0

    Private Sub labelTotal(sender As Object, e As Drawing.Printing.PrintEventArgs)
        If sender.Text <> "" Then
            sender.Text = "TOTAL " & sender.Text.ToString.ToUpper
        End If
    End Sub
    Private Sub isNegativeSum(sender As Object, e As TextFormatEventArgs)
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell9.BeforePrint, XrTableCell13.BeforePrint, XrTableCell11.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub af_SummaryReset(sender As Object, e As EventArgs)
        sum_af = 0
    End Sub
    Private Sub af_SummaryRowChanged(sender As Object, e As EventArgs)
        sum_af += Convert.ToDecimal(GetCurrentColumnValue("af"))
    End Sub
    Private Sub af_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs)
        diff_af.Add(ctr_af, sum_af)
        ctr_af += 1
    End Sub
    Private Sub cm_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs)
        diff_cm.Add(ctr_cm, sum_cm)
        ctr_cm += 1
    End Sub
    Private Sub cm_SummaryReset(sender As Object, e As EventArgs)
        sum_cm = 0
    End Sub
    Private Sub cm_SummaryRowChanged(sender As Object, e As EventArgs)
        sum_cm += Convert.ToDecimal(GetCurrentColumnValue("cm"))
    End Sub
    Private Sub total_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs)
        diff_total.Add(ctr_total, sum_total)
        ctr_total += 1
    End Sub
    Private Sub total_SummaryReset(sender As Object, e As EventArgs)
        sum_total = 0
    End Sub
    Private Sub total_SummaryRowChanged(sender As Object, e As EventArgs)
        sum_total += Convert.ToDecimal(GetCurrentColumnValue("total"))
    End Sub
    Private Sub diffOfAF_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles diffOfAF.SummaryCalculated
        Dim total_af As Decimal = 0
        If diff_af.Count > 0 Then
            total_af = diff_af.Item(0)
            For i As Integer = 1 To diff_af.Count - 1
                total_af -= diff_af.Item(i)
            Next
        End If
        If total_af < 0 Then
            e.Text = "(" & String.Format("{0:#,##0.00}", (total_af * -1)) & ")"
        Else
            e.Text = String.Format("{0:#,##0.00}", (total_af))
        End If
    End Sub
    Private Sub diffOfCM_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles diffOfCM.SummaryCalculated
        Dim total_cm As Decimal = 0
        If diff_cm.Count > 0 Then
            total_cm = diff_cm.Item(0)
            For i As Integer = 1 To diff_cm.Count - 1
                total_cm -= diff_cm.Item(i)
            Next
        End If
        If total_cm < 0 Then
            e.Text = "(" & String.Format("{0:#,##0.00}", (total_cm * -1)) & ")"
        Else
            e.Text = String.Format("{0:#,##0.00}", (total_cm))
        End If
    End Sub
    Private Sub diffOfTOTAL_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles diffOfTOTAL.SummaryCalculated
        Dim total_total As Decimal = 0
        If diff_total.Count > 0 Then
            total_total = diff_total.Item(0)
            For i As Integer = 1 To diff_total.Count - 1
                total_total -= diff_total.Item(i)
            Next
        End If
        If total_total < 0 Then
            e.Text = "(" & String.Format("{0:#,##0.00}", (total_total * -1)) & ")"
        Else
            e.Text = String.Format("{0:#,##0.00}", (total_total))
        End If
    End Sub
    Private Sub ChartGroupTotal_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles ChartGroupTotal.SummaryCalculated
        Dim tmp As Decimal = CType(e.Text.ToString.Replace(",", ""), Decimal)
        diff_total.Add(ctr_total, tmp)
        ctr_total += 1
    End Sub
    Private Sub ChartGroupAF_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles ChartGroupAF.SummaryCalculated
        Dim tmp As Decimal = CType(e.Text.ToString.Replace(",", ""), Decimal)
        diff_af.Add(ctr_af, tmp)
        ctr_af += 1
    End Sub
    Private Sub ChartGroupCM_SummaryCalculated(sender As Object, e As TextFormatEventArgs) Handles ChartGroupCM.SummaryCalculated
        Dim tmp As Decimal = CType(e.Text.ToString.Replace(",", ""), Decimal)
        diff_cm.Add(ctr_cm, tmp)
        ctr_cm += 1
    End Sub
End Class