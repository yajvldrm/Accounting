Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class setupprepaid
    'initialization
    Private transmode As String = ""
    Private _jbooks_id As String = ""
    Private _currency_id As String = ""
    Private _exchange_rate As Decimal = 0.0
    Private _based_rate As Decimal = 0.0
    Public Property trans_date As Date = Today
    'properties
    Public Property jbooks_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _jbooks_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _jbooks_id = value
        End Set
    End Property

    Public Property currency_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _currency_id
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _currency_id = value
        End Set
    End Property

    Public Property exchange_rate() As Decimal
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _exchange_rate
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Decimal)
            _exchange_rate = value
        End Set
    End Property

    Public Property based_rate() As Decimal
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _based_rate
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As Decimal)
            _based_rate = value
        End Set
    End Property
    'buttons
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txt_amount.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txt_amount.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txt_amount.Properties.Mask.EditMask = "n" & main.DecimalPlaces
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.DialogResult = DialogResult.OK
        DisableControlDet(Me)
        Me.Hide()
    End Sub

    Private Sub btnnotsave_Click(sender As Object, e As EventArgs) Handles btnnotsave.Click
        DisableControlDet(Me)
        Me.Hide()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        transmode = "insert"
        txt_amount.EditValue = 0
        EnableControlDet(Me)
        ClearControlDet(Me)
        txt_date_acquired.Value = trans_date
        txt_date_start.Value = trans_date
        txt_date_acquired.Focus()
        btnhdr2.Visible = False
        btndet2.Visible = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim selectedRows = dgdet.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value < 2 Then
                transmode = "update"
                EnableControlDet(Me)
                txt_date_acquired.Focus()
                btnhdr2.Visible = False
                btndet2.Visible = True
            Else
                MsgBox("Unable to Edit")
            End If
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim dt As DataTable = ds.Tables("prepaid")
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0

        Dim selectedRows = dgdet.SelectedRows

        If transmode = "insert" Then
            dr = dt.NewRow
            dr("prepaid_id") = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            If DataExist(dgdet, {"jbooks_id", jbooks_id}, {"description"}, {txt_description.Text}, True, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
        Else
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value = 1 Then
                If txt_amount.EditValue < selectedRow.Cells("minimum").Value Then
                    MsgBox("Unable to Save. Aquisition Cost is lower than the expected value.")
                    Exit Sub
                End If
            End If
            If DataExist(dgdet, {"jbooks_id", jbooks_id}, {"description"}, {txt_description.Text}, False, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
            sel = dgdet.SelectedRows(0).Index
            dr = ds.Tables("prepaid").Rows(sel)
        End If

        dr("sel") = False
        dr("jbooks_id") = jbooks_id
        dr("date_acquired") = txt_date_acquired.Value.ToString("yyyy-MM-dd")
        dr("date_start") = txt_date_start.Value.ToString("yyyy-MM-dd")
        dr("description") = txt_description.Text
        dr("useful_life") = txt_useful_life.EditValue
        dr("amount") = txt_amount.EditValue
        dr("amount_based") = txt_amount.EditValue * (exchange_rate / based_rate)
        dr("debit") = txt_amount.EditValue
        dr("credit") = 0.0
        dr("currency_id") = currency_id
        dr("exchange_rate") = exchange_rate
        dr("based_rate") = based_rate
        dr("debit_based") = txt_amount.EditValue * (exchange_rate / based_rate)
        dr("credit_based") = 0.0

        If transmode = "insert" Then
            ds.Tables("prepaid").Rows.Add(dr)
        End If

        transmode = ""

        DisableControlDet(Me)
        btninsert.Focus()
        btnhdr2.Visible = True
        btndet2.Visible = False
    End Sub

    Private Sub btnundo_Click(sender As Object, e As EventArgs) Handles btnundo.Click
        transmode = ""
        ClearControlDet(Me)
        DisableControlDet(Me)
        If dgdet.Rows.Count > 0 Then
            dgdet.ClearSelection()
            dgdet.Rows(0).Selected = True
        End If
        btnhdr2.Visible = True
        btndet2.Visible = False
    End Sub

    Private Sub setupprepaid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControlDet(Me)
        TextEditEnterToTab(Me)
        txt_date_acquired.Value = trans_date
        txt_date_start.Value = trans_date
        dgdet.AutoGenerateColumns = False
        dgdet.DataSource = ds.Tables("prepaid")
    End Sub

    Private Sub dgdet_SelectionChanged(sender As Object, e As EventArgs) Handles dgdet.SelectionChanged
        If dgdet.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        BindControlDet(Me, ds.Tables("prepaid").Rows(dgdet.SelectedRows(0).Index))
    End Sub

    Private Sub dgdet_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgdet.CellFormatting
        Dim dg = dgdet
        For Each dr As DataGridViewRow In dg.Rows
            For Each cell As DataGridViewCell In dr.Cells
                If dr.Cells("deleted").Value Then
                    cell.Style.BackColor = Drawing.Color.Red
                Else
                    cell.Style.BackColor = Drawing.Color.White
                End If
            Next
        Next
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim arr_id = getCheckedGrid("prepaid_id", "description", "sel", dgdet, "", False, , False)
        If arr_id.Length > 0 Then
            For Each row As DataRow In ds.Tables("prepaid").Rows
                If arr_id.Contains(row.Item("prepaid_id").ToString) Then
                    row.Item("deleted") = True
                End If
            Next
            loadDTToDG(dgdet, ds.Tables("prepaid"))
        End If
    End Sub

    Private Sub setupprepaid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DisableControlDet(Me)
    End Sub

    Private Sub setupprepaid_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadDTToDG(dgdet, ds.Tables("prepaid"))
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btninsert)
        dicShortCut.Add(114, btnupdate)
        dicShortCut.Add(115, btnremove)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub
End Class