﻿Imports DevExpress.XtraReports.UI

Public Class report_balancesheet_print

    Private Sub isNegative(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell9.BeforePrint, XrTableCell7.BeforePrint, XrTableCell23.BeforePrint, XrTableCell22.BeforePrint, XrTableCell21.BeforePrint, XrTableCell18.BeforePrint, XrTableCell17.BeforePrint, XrTableCell16.BeforePrint, XrTableCell13.BeforePrint, XrTableCell12.BeforePrint, XrTableCell11.BeforePrint, XrTableCell10.BeforePrint
        If sender.Text <> "" Then
            Dim num = CType(sender.Text.Replace(",", ""), Decimal)
            If num < 0 Then
                sender.Text = "(" & sender.Text.Replace("-", "") & ")"
            End If
        End If
    End Sub
    Private Sub labelTotal(sender As Object, e As Drawing.Printing.PrintEventArgs)
        If sender.Text <> "" Then
            sender.Text = "TOTAL " & sender.Text.Replace(" ", "")
        End If
    End Sub
    Private Sub isNegative1(sender As Object, e As TextFormatEventArgs) Handles XrTableCell7.SummaryCalculated, XrTableCell23.SummaryCalculated, XrTableCell22.SummaryCalculated, XrTableCell21.SummaryCalculated, XrTableCell18.SummaryCalculated, XrTableCell17.SummaryCalculated, XrTableCell16.SummaryCalculated, XrTableCell12.SummaryCalculated, XrTableCell10.SummaryCalculated
        If e.Text <> "" Then
            Dim num = CType(e.Value, Decimal)
            If num < 0 Then
                e.Text = "(" & String.Format("{0:#,##0.00}", (e.Value * -1)) & ")"
            End If
        End If
    End Sub
End Class