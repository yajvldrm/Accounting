Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports user_control
Imports System.Windows.Forms

Public Class trans_detailed_particulars


    Private WithEvents txtBoxEnterToTab As New DataGridViewTextBoxEditingControl
    Public Property transmode = ""
    Private transmodedet As String = ""
    Public listDr As New List(Of DataRow)

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

    Public Property TransactionDetailedID As String = ""

#Region "Event Handler"
    Private Sub trans_detailed_particulars_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgMainDetailed.AutoGenerateColumns = False
        loadDTToDG(dgMainDetailed, dsDetailedParticular.Tables("trans_header_detailed_particular"))
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim newDR = dsDetailedParticular.Tables("trans_header_detailed_particular").NewRow
        newDR.Item("trans_id") = TransactionDetailedID
        newDR.Item("trans_detailed_particular_id") = "tmp_" & Now.ToString("yyyyMMddHHmmssfff")
        newDR.Item("po_no") = ""
        newDR.Item("rr_no") = ""
        newDR.Item("dr_no") = ""
        newDR.Item("si_no") = ""
        newDR.Item("due_date") = Date.Today
        newDR.Item("trans_header_detailed_amount") = "0.00"

        dsDetailedParticular.Tables("trans_header_detailed_particular").Rows.Add(newDR)

        loadDTToDG(dgMainDetailed, dsDetailedParticular.Tables("trans_header_detailed_particular"))
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim arrID = getCheckedGridRem("trans_detailed_particular_id", "sel", dgMainDetailed, "", False, , False)
        If arrID.Count > 0 Then
            For Each dr As DataRow In dsDetailedParticular.Tables("trans_header_detailed_particular").Rows
                If arrID.Contains(dr.Item("trans_detailed_particular_id").ToString) Then
                    dr.Item("deleted") = True
                    dsDetailedParticular.Tables("trans_header_detailed_particular").AcceptChanges()
                End If
            Next
            loadDTToDG(dgMainDetailed, dsDetailedParticular.Tables("trans_header_detailed_particular"))
        End If
    End Sub
#End Region


#Region "Public SUB"
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        dgMainDetailed.Columns("trans_particular_amount").DefaultCellStyle.Format = strNumberFormat
    End Sub
    Friend Sub EnableParticular(Optional enable As Boolean = True)
        btnInsert.Visible = enable
        btnRemove.Visible = enable
        dgMainDetailed.ReadOnly = Not enable
    End Sub
#End Region




    Private Sub dgMainDetailed_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgMainDetailed.CurrentCellDirtyStateChanged
        If dgMainDetailed.IsCurrentCellDirty Then
            dgMainDetailed.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub



    Private Function getRowsCount() As Integer
        Dim ctr As Integer = 0
        For Each row As DataGridViewRow In dgMainDetailed.Rows
            If Not row.Cells("deleted").Value Then
                ctr += 1
            End If
        Next
        Return ctr
    End Function
    Private Function getCurrentRowIndex() As Integer
        Dim index As Integer = -1
        Dim currentRow = dgMainDetailed.CurrentCell.OwningRow
        For Each row As DataGridViewRow In dgMainDetailed.Rows
            If Not row.Cells("deleted").Value Then
                If row.Equals(currentRow) Then
                    index = row.Index
                End If
            End If
        Next
        Return index
    End Function

    Private Sub dgMain_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgMainDetailed.EditingControlShowing
        txtBoxEnterToTab = CType(dgMainDetailed.EditingControl, DataGridViewTextBoxEditingControl)
        txtBoxEnterToTab.Name = dgMainDetailed.Columns(dgMainDetailed.CurrentCell.ColumnIndex).DataPropertyName
        Dim ctrl = dgMainDetailed.Columns(dgMainDetailed.CurrentCell.ColumnIndex)
    End Sub

    Private Sub dgMainDetailed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgMainDetailed.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub trans_detailed_particulars_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        'Detailed particular

        Dim fields = New Dictionary(Of String, String)
        Dim sql_detailed_particular As String = ""
        For Each dr As DataRow In dsDetailedParticular.Tables("trans_header_detailed_particular").Rows

            fields = New Dictionary(Of String, String)
            fields.Add("trans_detailed_particular_id", dr.Item("trans_detailed_particular_id").ToString)
            fields.Add("po_no", dr.Item("po_no").ToString)
            fields.Add("rr_no", dr.Item("rr_no").ToString)
            fields.Add("dr_no", dr.Item("dr_no").ToString)
            fields.Add("si_no", dr.Item("si_no").ToString)
            fields.Add("due_date", CDate(dr.Item("due_date").ToString).ToString("yyyy-MM-dd"))
            fields.Add("trans_header_detailed_amount", dr.Item("trans_header_detailed_amount").ToString)

            listDr.Add(dr)

        Next

        Me.DialogResult = DialogResult.OK

    End Sub
    Private Sub txtBoxEnterToTab_Leave(sender As Object, e As EventArgs) Handles txtBoxEnterToTab.Leave
        Dim str = txtBoxEnterToTab.Text.ToString.Trim.Replace(",", "")
        If txtBoxEnterToTab.Name = "trans_header_detailed_amount" Then
            If Not IsNumeric(str) Then
                txtBoxEnterToTab.Text = "0.00"
            End If
        End If
    End Sub
End Class