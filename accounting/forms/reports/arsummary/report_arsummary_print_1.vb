Imports DevExpress.XtraReports.UI

Public Class report_arsummary_print_1
    Private Sub noNegative1(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell21.BeforePrint
        Dim lbl = CType(sender, XRLabel)
        If lbl.Text <> "" Then
            Dim tmp As Decimal = CType(lbl.Text.Replace(",", "").Replace("(", "").Replace(")", ""), Decimal)
            If tmp < 0 Then
                lbl.Text = String.Format("({0:##,##0.00})", (tmp * -1))
            Else
                lbl.Text = String.Format("{0:##,##0.00}", tmp)
            End If
            If tmp = 0 Then
                lbl.Text = ""
            End If
        End If
    End Sub
    Private Sub noNegative(sender As Object, e As TextFormatEventArgs) Handles XrTableCell6.SummaryCalculated, XrTableCell5.SummaryCalculated
        Dim lbl = CType(sender, XRLabel)
        Dim tmp As Decimal = CType(e.Value, Decimal)
        If tmp < 0 Then
            e.Text = String.Format("({0:##,##0.00})", (tmp * -1))
        End If
        If tmp = 0 And lbl.Name <> "cellBalance" And lbl.Name <> "cellBalanceBased" Then
            e.Text = ""
        End If
    End Sub
End Class