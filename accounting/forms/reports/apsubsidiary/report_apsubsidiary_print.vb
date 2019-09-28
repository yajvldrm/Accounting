Imports DevExpress.XtraReports.UI

Public Class report_apsubsidiary_print
    Dim bal As Decimal = 0
    Dim bal_based As Decimal = 0
    Dim flag As Boolean = False

    Private Sub XrLabel8_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrLabel8.BeforePrint
        bal = 0
        bal_based = 0
        flag = False
    End Sub
    Private Sub bal_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell19.BeforePrint
        Dim lbl = CType(sender, XRLabel)
        If lbl.Text <> "" Then
            If Not flag Then
                bal = CType(lbl.Text, Decimal)
            Else
                bal += CType(lbl.Text, Decimal)
            End If
        End If
        flag = True
        If bal < 0 Then
            lbl.Text = String.Format("({0:##,##0.00})", (bal * -1))
        Else
            lbl.Text = String.Format("{0:##,##0.00}", bal)
        End If
        If bal = 0 Then
            lbl.Text = ""
        End If
    End Sub
    Private Sub bal_based_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell22.BeforePrint
        Dim lbl = CType(sender, XRLabel)
        If lbl.Text <> "" Then
            If Not flag Then
                bal_based = CType(lbl.Text, Decimal)
            Else
                bal_based += CType(lbl.Text, Decimal)
            End If
        End If
        flag = True
        If bal_based < 0 Then
            lbl.Text = String.Format("({0:##,##0.00})", (bal_based * -1))
        Else
            lbl.Text = String.Format("{0:##,##0.00}", bal_based)
        End If
        If bal_based = 0 Then
            lbl.Text = ""
        End If
    End Sub
    Private Sub noNegative(sender As Object, e As TextFormatEventArgs) Handles XrTableCell32.SummaryCalculated, XrTableCell31.SummaryCalculated, XrTableCell29.SummaryCalculated, XrTableCell28.SummaryCalculated
        Dim lbl = CType(sender, XRLabel)
        Dim tmp As Decimal = CType(e.Value, Decimal)
        If tmp < 0 Then
            e.Text = String.Format("({0:##,##0.00})", (tmp * -1))
        End If
        If tmp = 0 And lbl.Name <> "cellBalance" And lbl.Name <> "cellBalanceBased" Then
            e.Text = ""
        End If
    End Sub
    Private Sub noNegative1(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrTableCell17.BeforePrint, XrTableCell21.BeforePrint, XrTableCell20.BeforePrint, XrTableCell18.BeforePrint
        Dim lbl = CType(sender, XRLabel)
        If lbl.Text <> "" Then
            Dim tmp As Decimal = CType(lbl.Text.Replace(",", "").Replace("(", "").Replace(")", ""), Decimal)
            If tmp = 0 Then
                lbl.Text = ""
            End If
        End If
    End Sub
End Class