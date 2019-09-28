Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports user_control
Imports System.Windows.Forms
Public Class trans_particular
#Region "Property Declaration"
    Private WithEvents txtBoxEnterToTab As New DataGridViewTextBoxEditingControl
    Private _TransactionName As String = ""
    Public Property TransactionName() As String
        Get
            Return _TransactionName
        End Get
        Set(value As String)
            _TransactionName = value
            lbl_trans.Text = value.Trim
        End Set
    End Property
    Public Property TransactionID As String = ""
    Private _Description As String = ""
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
            txt_description.Text = value
        End Set
    End Property
    Public Property MyDataTable As DataTable = Nothing
#End Region
#Region "Public SUB"
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        dgMain.Columns("trans_particular_amount").DefaultCellStyle.Format = strNumberFormat
    End Sub
    Friend Sub EnableParticular(Optional enable As Boolean = True)
        txt_description.Enabled = enable
        btnInsert.Visible = enable
        btnRemove.Visible = enable
        dgMain.ReadOnly = Not enable
    End Sub
#End Region
#Region "Event Handler"
    Private Sub trans_particular_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgMain.AutoGenerateColumns = False
        loadDTToDG(dgMain, dsParticular.Tables("trans_header_particular"))
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim newDR = dsParticular.Tables("trans_header_particular").NewRow
        newDR.Item("trans_id") = TransactionID
        newDR.Item("trans_particular_id") = "tmp_" & Now.ToString("yyyyMMddHHmmssfff")
        newDR.Item("trans_particular_amount") = "0.00"
        dsParticular.Tables("trans_header_particular").Rows.Add(newDR)
        loadDTToDG(dgMain, dsParticular.Tables("trans_header_particular"))
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim arrID = getCheckedGrid("trans_particular_id", "trans_particular_code", "sel", dgMain, "", False, , False)
        If arrID.Count > 0 Then
            For Each dr As DataRow In dsParticular.Tables("trans_header_particular").Rows
                If arrID.Contains(dr.Item("trans_particular_id").ToString) Then
                    dr.Item("deleted") = True
                    dsParticular.Tables("trans_header_particular").AcceptChanges()
                End If
            Next
            loadDTToDG(dgMain, dsParticular.Tables("trans_header_particular"))
        End If
    End Sub
    Private Sub dgMain_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgMain.CurrentCellDirtyStateChanged
        If dgMain.IsCurrentCellDirty Then
            dgMain.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
#End Region
    Private Sub trans_particular_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'Dim dicShortCut As New Dictionary(Of Integer, Button)
        'dicShortCut.Add(113, btnInsert)                'F2
        'dicShortCut.Add(115, btnRemove)             'F4
        'If dicShortCut.ContainsKey(e.KeyCode) Then
        '    Dim btn As Button = dicShortCut.Item(e.KeyCode)
        '    If btn.Enabled And btn.Visible Then
        '        btn.PerformClick()
        '        Return
        '    End If
        'End If
    End Sub

    Private Sub dgMain_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgMain.EditingControlShowing
        txtBoxEnterToTab = CType(dgMain.EditingControl, DataGridViewTextBoxEditingControl)
        txtBoxEnterToTab.Name = dgMain.Columns(dgMain.CurrentCell.ColumnIndex).DataPropertyName
        Dim ctrl = dgMain.Columns(dgMain.CurrentCell.ColumnIndex)
    End Sub
    Private Sub txtBoxEnterToTab_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBoxEnterToTab.KeyPress, dgMain.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    SendKeys.Send("{TAB}")
        'End If
    End Sub
    Private Function getRowsCount() As Integer
        Dim ctr As Integer = 0
        For Each row As DataGridViewRow In dgMain.Rows
            If Not row.Cells("deleted").Value Then
                ctr += 1
            End If
        Next
        Return ctr
    End Function
    Private Function getCurrentRowIndex() As Integer
        Dim index As Integer = -1
        Dim currentRow = dgMain.CurrentCell.OwningRow
        For Each row As DataGridViewRow In dgMain.Rows
            If Not row.Cells("deleted").Value Then
                If row.Equals(currentRow) Then
                    index = row.Index
                End If
            End If
        Next
        Return index
    End Function
    Private Sub txtBoxEnterToTab_Leave(sender As Object, e As EventArgs) Handles txtBoxEnterToTab.Leave
        Dim str = txtBoxEnterToTab.Text.ToString.Trim.Replace(",", "")
        If txtBoxEnterToTab.Name = "trans_particular_amount" Then
            If Not IsNumeric(str) Then
                txtBoxEnterToTab.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub dgMain_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgMain.DataError
        e.Cancel = True
    End Sub

    Private Sub dgMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellContentClick

    End Sub

    Private Sub trans_particular_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class