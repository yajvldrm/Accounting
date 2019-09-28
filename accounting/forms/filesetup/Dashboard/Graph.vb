Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Data.OleDb

Public Class Graph
    Dim ds As New begbal
    Dim dbTable As String = "trans_header"

    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim maxyear As Integer = Today.Year
        txt_year.Maximum = maxyear
        txt_year.Value = maxyear

        With Chart1
            .Series.Clear()
            .Series.Add("Sales")
            .Series("Sales").Points.Clear()
            Dim sql = String.Format("SELECT MONTHNAME(trans_date) as trans_month, SUM(amount) as amount FROM trans_header WHERE YEAR(trans_date)='{0}' GROUP BY MONTH(trans_date)", txt_year.Value)
            Dim dt As DataTable = Query(sql)
            For x = 1 To 12
                Dim amount As Decimal = 0
                Dim amount_lbl As String = 0
                If dt.Rows.Count > x - 1 Then
                    amount = dt.Rows(x - 1).Item("amount")

                    If (amount <= 999) Then
                        amount_lbl = Trim(Str(amount))
                    ElseIf (amount >= 1000000000 And amount <= 999999999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}B", (amount / 1000000000))
                    ElseIf (amount >= 1000000 And amount <= 999999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}M", (amount / 1000000))
                    ElseIf (amount >= 1000 And amount <= 999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}K", (amount / 1000))
                    End If

                End If
                .Series("Sales").Points.AddXY(MonthName(x), amount)
                .Series("Sales").Points(x - 1).Label = amount_lbl
            Next
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisY.LabelStyle.Format = "#,##0"
            .Series("Sales").IsValueShownAsLabel = True
            .Series("Sales").ChartType = SeriesChartType.Column
        End With

        Me.Location = New Drawing.Point(20, 20)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        With Chart1
            .Series.Clear()
            .Series.Add("Sales")
            .Series("Sales").Points.Clear()
            Dim sql = String.Format("SELECT MONTHNAME(trans_date) as trans_month, SUM(amount) as amount FROM trans_header WHERE YEAR(trans_date)='{0}' GROUP BY MONTH(trans_date)", txt_year.Value)
            Dim dt As DataTable = Query(sql)
            For x = 1 To 12
                Dim amount As Decimal = 0
                Dim amount_lbl As String = 0
                If dt.Rows.Count > x - 1 Then
                    amount = dt.Rows(x - 1).Item("amount")

                    If (amount <= 999) Then
                        amount_lbl = Trim(Str(amount))
                    ElseIf (amount >= 1000000000 And amount <= 999999999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}B", (amount / 1000000000))
                    ElseIf (amount >= 1000000 And amount <= 999999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}M", (amount / 1000000))
                    ElseIf (amount >= 1000 And amount <= 999999) Then
                        amount_lbl = String.Format("{0:##,##0.00}K", (amount / 1000))
                    End If

                End If
                .Series("Sales").Points.AddXY(MonthName(x), amount)
                .Series("Sales").Points(x - 1).Label = amount_lbl
            Next
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisY.LabelStyle.Format = "#,##0"
            .Series("Sales").IsValueShownAsLabel = True
            .Series("Sales").ChartType = SeriesChartType.Column
        End With
    End Sub
End Class