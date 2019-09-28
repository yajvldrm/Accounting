Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports user_control
Imports System.Windows.Forms
Public Class trans_particular
    Private transmode = ""

    Private _trans_id As String = ""
    Private _transaction_name As String = ""
    Private _strParticular As String = ""

    Public Property trans_id() As String
        Get
            Return _trans_id
        End Get
        Set(value As String)
            _trans_id = value
        End Set
    End Property
    Public Property transaction_name() As String
        Get
            Return _transaction_name
        End Get
        Set(value As String)
            _transaction_name = value
            lbl_trans.Text = value
        End Set
    End Property
    Public Property strparticular() As String
        Get
            Return _strParticular
        End Get
        Set(value As String)
            _strParticular = value
            txtdesc.Text = value
        End Set
    End Property
    Public Sub clearData()
        ds.Tables("particular").Clear()
        dgMain.DataSource = ds.Tables("particular")
        disable_control(Me)
    End Sub
    Private Sub trans_particular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgMain.AutoGenerateColumns = False
        If trans_id <> "" And trans_id <> "0" Then
            Dim sql As String = String.Format("SELECT a.trans_particular_id,a.trans_id,a.trans_particular_code" & _
                                              " ,a.trans_particular_name,a.trans_particular_amount" & _
                                              " FROM trans_header_particular a" & _
                                              " WHERE a.trans_id = '{0}'", trans_id)
            Dim dt As DataTable = FsQuery(sql)
            If dt.Rows.Count > 0 Then
                ds.Tables("particular").Clear()
                For Each dr As DataRow In dt.Rows
                    ds.Tables("particular").ImportRow(dr)
                Next
            End If
        End If
        dgMain.DataSource = ds.Tables("particular")
    End Sub
    Private Sub bindData(ByVal dg As DataGridView, ByVal pnl As Panel, ByVal pk As String)
        If dg.SelectedRows.Count = 1 Then
            Dim selectedRow = dg.SelectedRows.Item(0)
            Dim dt = dg.DataSource
            If dt.Rows.count > 0 Then
                Dim colName As String = ""
                Dim id As String = ""
                For Each col As DataGridViewColumn In dg.Columns
                    If col.DataPropertyName = pk Then
                        colName = col.Name
                    End If
                Next
                If selectedRow.Cells(colName).Value.ToString <> "" Then
                    id = selectedRow.Cells(colName).Value.ToString
                End If
                Dim selectedRecords = dt.Select(String.Format("{0} = '{1}'", pk, id))
                If selectedRecords.Length > 0 Then
                    Dim dr As DataRow = selectedRecords(0)
                    For Each ctrl As Control In pnl.Controls
                        If TypeOf ctrl Is user_control.textbox Then
                            Dim ctr = CType(ctrl, user_control.textbox)
                            If ctr.ValueSource <> "" Then
                                ctr.Value = dr.Item(ctr.ValueSource)
                            End If
                            If ctr.TextSource <> "" Then
                                ctr.Text = dr.Item(ctr.TextSource)
                            End If
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        clear_control(Me)
        enable_control(Me)
        btnAdd.Visible = False
        btnEdit.Visible = False
        btnDelete.Visible = False
        btnSave.Visible = True
        btnNotSave.Visible = True
        transmode = "add"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgMain.SelectedRows.Count = 1 Then
            enable_control(Me)
            transmode = "edit"
        Else
            MsgBox("Select record first.")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dr = Nothing
        If transmode = "add" Then
            dr = ds.Tables("particular").NewRow
        ElseIf transmode = "edit" Then
            Dim drs = ds.Tables("particular").Select(String.Format("trans_particular_id = '{1}'", txt_trans_particular_id.Text))
            dr = drs(0)
        End If
        For Each ctrl In hdr.Controls
            If TypeOf ctrl Is user_control.textbox Then
                Dim ctr = CType(ctrl, user_control.textbox)
                If ctr.ValueSource <> "" Then
                    If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                        dr.Item(ctr.ValueSource) = ctr.DecimalValue
                    Else
                        dr.Item(ctr.ValueSource) = ctr.Value.ToString
                    End If
                    Console.WriteLine(ctr.Name & ":" & ctr.ValueSource & ":" & ctr.Value)
                End If
                If ctr.TextSource <> "" Then
                    If ctr.NumberFormat <> "" And ctr.NumberFormat <> "@" Then
                        dr.Item(ctr.TextSource) = ctr.DecimalValue
                    Else
                        dr.Item(ctr.TextSource) = ctr.Text.ToString
                    End If
                    Console.WriteLine(ctr.Name & ":" & ctr.TextSource & ":" & ctr.Text)
                End If
            End If
        Next
        If transmode = "add" Then
            ds.Tables("particular").Rows.Add(dr)
        End If
        dgMain.DataSource = ds.Tables("particular")
        disable_control(Me)
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control(Me)
    End Sub

    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        If dgMain.Rows.Count > 0 Then
            bindData(dgMain, hdr, "trans_particular_id")
        End If
    End Sub
End Class