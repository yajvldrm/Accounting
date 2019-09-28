Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class setupfixedasset
    'initialization
    Private transmode As String = ""
    Private _jbooks_id As String = ""
    Private _currency_id As String = ""
    Private _exchange_rate As Decimal = 0.0
    Private _based_rate As Decimal = 0.0
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
        txt_historical_rate.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txt_historical_rate.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txt_historical_rate.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txt_salvage_value.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txt_salvage_value.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txt_salvage_value.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txt_amount.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txt_amount.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txt_amount.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        'txt_useful_life.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        'txt_useful_life.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        'txt_useful_life.Properties.Mask.EditMask = "n" & main.DecimalPlaces
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
        EnableControlDet(Me)
        ClearControlDet(Me)
        txt_date_acquired.Value = DateTime.Today
        txt_date_start.Value = DateTime.Today
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
        Dim dt As DataTable = ds.Tables("fixed_asset")
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0

        Dim selectedRows = dgdet.SelectedRows

        If transmode = "insert" Then
            dr = dt.NewRow
            dr("fixed_asset_id") = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            If DataExist(dgdet, {"jbooks_id", jbooks_id}, {"description", "asset_code"}, {txt_description.Text, txt_asset_code.Text}, True, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
        Else
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value = 1 Then
                If txt_amount.EditValue < selectedRow.Cells("minimum").Value Then
                    MsgBox("Unable to Save. Acquisition Cost is lower than the expected value.")
                    Exit Sub
                End If
            End If
            If DataExist(dgdet, {"jbooks_id", jbooks_id}, {"description", "asset_code"}, {txt_description.Text, txt_asset_code.Text}, False, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
            sel = dgdet.SelectedRows(0).Index
            dr = ds.Tables("fixed_asset").Rows(sel)
        End If

        dr("sel") = False
        dr("jbooks_id") = jbooks_id
        dr("date_acquired") = txt_date_acquired.Value.ToString("yyyy-MM-dd")
        dr("date_start") = txt_date_start.Value.ToString("yyyy-MM-dd")
        dr("historical_rate") = txt_historical_rate.EditValue
        dr("description") = txt_description.Text
        dr("asset_code") = txt_asset_code.Text
        dr("quantity") = txt_quantity.EditValue
        dr("useful_life") = txt_useful_life.EditValue
        dr("amount") = txt_amount.EditValue
        dr("salvage_value") = txt_salvage_value.EditValue
        dr("salvage_value_based") = txt_salvage_value.EditValue * (exchange_rate / based_rate)
        dr("amount_based") = txt_amount.EditValue * (exchange_rate / based_rate)
        dr("debit") = txt_amount.EditValue
        dr("credit") = 0.0
        dr("currency_id") = currency_id
        dr("exchange_rate") = exchange_rate
        dr("based_rate") = based_rate
        dr("debit_based") = txt_amount.EditValue * (exchange_rate / based_rate)
        dr("credit_based") = 0.0

        If transmode = "insert" Then
            ds.Tables("fixed_asset").Rows.Add(dr)
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
        btnhdr2.Visible = True
        btndet2.Visible = False
        If dgdet.Rows.Count > 0 Then
            dgdet.ClearSelection()
            dgdet.Rows(0).Selected = True
        End If
    End Sub

    Private Sub setupfixedasset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControlDet(Me)
        TextEditEnterToTab(Me)
        dgdet.AutoGenerateColumns = False
        dgdet.DataSource = ds.Tables("fixed_asset")
    End Sub

    Private Sub dgdet_SelectionChanged(sender As Object, e As EventArgs) Handles dgdet.SelectionChanged
        If dgdet.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        BindControlDet(Me, ds.Tables("fixed_asset").Rows(dgdet.SelectedRows(0).Index))
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim arr_id = getCheckedGrid("fixd_asset_id", "asset_code", "sel", dgdet, "", False, , False)
        If arr_id.Length > 0 Then
            For Each row As DataRow In ds.Tables("fixed_asset").Rows
                If arr_id.Contains(row.Item("fixed_asset_id").ToString) Then
                    row.Item("deleted") = True
                End If
            Next
            loadDTToDG(dgdet, ds.Tables("fixed_asset"))
        End If
    End Sub

    Private Sub setupfixedasset_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DisableControlDet(Me)
    End Sub

    Private Sub setupfixedasset_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadDTToDG(dgdet, ds.Tables("fixed_asset"))
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