Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class setupfinaltax
    Private generaldt As New DataTable
    Private finaltaxdt As New DataTable
    Private transmode As String = ""
    Private _jbooks_id As String = ""
    Private _currency_id As String = ""
    Private _exchange_rate As Decimal = 0.0
    Private _based_rate As Decimal = 0.0

    Public Property generalID As String = ""
    Public Property generalCode As String = ""
    Public Property generalName As String = ""

    Public Property currency_id() As String
        Get
            Return _currency_id
        End Get
        Set(ByVal value As String)
            _currency_id = value
        End Set
    End Property

    Public Property exchange_rate() As Decimal
        Get
            Return _exchange_rate
        End Get
        Set(ByVal value As Decimal)
            _exchange_rate = value
        End Set
    End Property

    Public Property based_rate() As Decimal
        Get
            Return _based_rate
        End Get
        Set(ByVal value As Decimal)
            _based_rate = value
        End Set
    End Property

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
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txttaxrate.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txttaxrate.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txttaxrate.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txtamount.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txtamount.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txtamount.Properties.Mask.EditMask = "n" & main.DecimalPlaces
        txttaxamount.Properties.DisplayFormat.FormatString = "n" & main.DecimalPlaces
        txttaxamount.Properties.EditFormat.FormatString = "n" & main.DecimalPlaces
        txttaxamount.Properties.Mask.EditMask = "n" & main.DecimalPlaces
    End Sub
    Private Sub cmdNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        DisableControlDet(Me)
        Me.Hide()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmode = "insert"
        clear_control()
        enable_control()
        txtgeneral.Value = generalID
        txtgeneral.Text = generalCode
        txtgeneralname.Text = generalName
        txttaxamount.Enabled = False
    End Sub

    Private Sub clear_control()
        txtgeneral.Value = ""
        txtgeneral.Text = ""
        txtgeneralname.Text = ""
        txtfinaltax.Value = ""
        txtfinaltax.Text = ""
        txtfinaltaxname.Text = ""
        txttaxrate.EditValue = 0.0
        txtamount.EditValue = 0.0
        txttaxamount.EditValue = 0.0
    End Sub

    Private Sub enable_control()
        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnOK.Enabled = True
        btnUndo.Enabled = True

        btnSave.Enabled = False
        btnNotSave.Enabled = False

        txtgeneral.Enabled = True
        txtfinaltax.Enabled = True
        txttaxrate.Enabled = True
        txtamount.Enabled = True
    End Sub

    Private Sub disable_control()
        btnInsert.Enabled = True
        btnUpdate.Enabled = True
        btnRemove.Enabled = True
        btnOK.Enabled = False
        btnUndo.Enabled = False

        btnSave.Enabled = True
        btnNotSave.Enabled = True

        txtgeneral.Enabled = False
        txtfinaltax.Enabled = False
        txttaxrate.Enabled = False
        txtamount.Enabled = False
    End Sub

    Private Sub bind_control()
        If dgfinaltax.RowCount = 0 Then
            clear_control()
            Exit Sub
        End If
        If dgfinaltax.SelectedRows.Count = 0 Then
            clear_control()
            Exit Sub
        End If

        Dim sel As Integer = dgfinaltax.SelectedRows(0).Index
        Dim dr As DataRow = ds.Tables("final_tax").Rows(sel)

        txtgeneral.Value = dr("general_id")
        txtgeneral.Text = dr("general_code")
        txtgeneralname.Text = dr("general_name")
        txtTIN.Text = dr("tin")
        txtfinaltax.Value = dr("fs_final_tax_id")
        txtfinaltax.Text = dr("fs_final_tax_code")
        txtfinaltaxname.Text = dr("fs_final_tax_name")
        txttaxrate.EditValue = dr("tax_rate")
        txtamount.EditValue = dr("amount")
        txttaxamount.EditValue = dr("tax_amount")
    End Sub

    Private Sub txtgeneral_Leave(sender As Object, e As EventArgs) Handles txtgeneral.Leave
        generaldt = FsQuery("select * from lib_erp_general ORDER BY FIELD(category_id,2,1),general_code ASC")
        If generaldt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If generaldt.Rows.Count = 1 Then
                dr = generaldt.Rows(0)
            Else
                Dim dra() As DataRow = generaldt.Select("general_code like '" & txtgeneral.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = generaldt
                    browse.format("Code,Name", "general_code,general_name", "140,240")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtgeneral.RowData = dr
                txtgeneral.Value = dr("general_id")
                txtgeneral.Text = dr("general_code")
                txtgeneralname.Text = dr("general_name")
            End If
        End If
    End Sub

    Private Sub txtfinaltax_Leave(sender As Object, e As EventArgs) Handles txtfinaltax.Leave
        Dim sql_final_tax As String = String.Format("SELECT * FROM lib_acc_final_tax ")
        If txtgeneral.Value <> "" Then
            sql_final_tax = String.Format("SELECT a.general_id,a.final_tax_id,b.final_tax_code,b.final_tax_name,b.final_tax_rate " & _
            "FROM lib_erp_general_final_tax a " & _
            "LEFT JOIN lib_acc_final_tax b ON b.final_tax_id = a.final_tax_id " & _
            "WHERE a.general_id = '{0}' ", txtgeneral.Value)
        End If
        finaltaxdt = FsQuery(sql_final_tax)
        If finaltaxdt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If finaltaxdt.Rows.Count = 1 Then
                dr = finaltaxdt.Rows(0)
            Else
                Dim dra() As DataRow = finaltaxdt.Select("final_tax_code like '" & txtfinaltax.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = finaltaxdt
                    browse.format("Code,NIP", "final_tax_code,final_tax_name", "100,360")
                    If browse.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtfinaltax.RowData = dr
                txtfinaltax.Value = dr("final_tax_id")
                txtfinaltax.Text = dr("final_tax_code")
                txtfinaltaxname.Text = dr("final_tax_name")
                txttaxrate.Text = dr("final_tax_rate")
                compute_tax()
            End If
        End If
    End Sub

    Private Sub compute_tax()
        txttaxamount.EditValue = txtamount.EditValue * (txttaxrate.EditValue / 100)
    End Sub

    Private Sub txttaxrate_Leave(sender As Object, e As EventArgs) Handles txttaxrate.Leave
        compute_tax()
    End Sub

    Private Sub txtamount_Leave(sender As Object, e As EventArgs) Handles txtamount.Leave
        compute_tax()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedRows = dgfinaltax.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value < 2 Then
                transmode = "update"
                enable_control()
                txttaxamount.Enabled = False
            Else
                MsgBox("Unable to Edit")
            End If
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dt As DataTable = ds.Tables("final_tax")
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0

        Dim selectedRows = dgfinaltax.SelectedRows

        If transmode = "insert" Then
            dr = dt.NewRow
            dr("final_tax_id") = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            If DataExist(dgfinaltax, {"jbooks_id", jbooks_id}, {"general_id", "fs_final_tax_id"}, {txtgeneral.Value, txtfinaltax.Value}, True, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
        Else
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value = 1 Then
                If txttaxamount.EditValue < selectedRow.Cells("minimum").Value Then
                    MsgBox("Unable to Save. Tax Withheld is lower than the expected value.")
                    Exit Sub
                End If
            End If
            sel = dgfinaltax.SelectedRows(0).Index
            dr = ds.Tables("final_tax").Rows(sel)
            If DataExist(dgfinaltax, {"jbooks_id", jbooks_id}, {"general_id", "fs_final_tax_id"}, {txtgeneral.Value, txtfinaltax.Value}, False, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
        End If

        dr("sel") = False
        dr("jbooks_id") = jbooks_id
        dr("general_id") = txtgeneral.Value
        dr("general_code") = txtgeneral.Text
        dr("general_name") = txtgeneralname.Text
        dr("tin") = txtTIN.Text
        dr("fs_final_tax_id") = txtfinaltax.Value
        dr("fs_final_tax_code") = txtfinaltax.Text
        dr("fs_final_tax_name") = txtfinaltaxname.Text
        dr("offset_type") = 0
        dr("tax_rate") = txttaxrate.EditValue
        dr("amount") = txtamount.EditValue
        dr("tax_amount") = txttaxamount.EditValue
        dr("debit") = 0.0
        dr("credit") = txttaxamount.EditValue
        dr("currency_id") = currency_id
        dr("exchange_rate") = exchange_rate
        dr("based_rate") = based_rate
        dr("amount_based") = txtamount.EditValue * (exchange_rate / based_rate)
        dr("tax_amount_based") = txttaxamount.EditValue * (exchange_rate / based_rate)
        dr("debit_based") = 0.0
        dr("credit_based") = txttaxamount.EditValue * (exchange_rate / based_rate)

        If transmode = "insert" Then
            ds.Tables("final_tax").Rows.Add(dr)
        End If

        transmode = ""
        disable_control()
        btnInsert.Focus()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        clear_control()
        disable_control()
        If dgfinaltax.Rows.Count > 0 Then
            dgfinaltax.ClearSelection()
            dgfinaltax.Rows(0).Selected = True
        End If
        transmode = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.DialogResult = DialogResult.OK
        DisableControlDet(Me)
        Me.Hide()
    End Sub

    Private Sub setupfinaltax_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            If e.KeyCode = Keys.S Then
                If transmode = "" Then
                    btnOK_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub setupfinaltax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear_control()
        TextEditEnterToTab(Me)
        dgfinaltax.AutoGenerateColumns = False
        dgfinaltax.DataSource = ds.Tables("final_tax")
    End Sub

    Private Sub setupfinaltax_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        btnInsert.Focus()
        loadDTToDG(dgfinaltax, ds.Tables("final_tax"))
    End Sub

    Private Sub dgfinaltax_SelectionChanged(sender As Object, e As EventArgs) Handles dgfinaltax.SelectionChanged
        bind_control()
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim arr_id = getCheckedGrid("final_tax_id", "fs_final_tax_code", "sel", dgfinaltax, "", False, , False)
        If arr_id.Length > 0 Then
            For Each row As DataRow In ds.Tables("final_tax").Rows
                If arr_id.Contains(row.Item("final_tax_id").ToString) Then
                    row.Item("deleted") = True
                End If
            Next
            loadDTToDG(dgfinaltax, ds.Tables("final_tax"))
        End If
    End Sub

    Private Sub setupfinaltax_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DisableControlDet(Me)
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim dicShortCut As New Dictionary(Of Integer, Button)
        dicShortCut.Add(113, btnInsert)
        dicShortCut.Add(114, btnUpdate)
        dicShortCut.Add(115, btnRemove)
        If dicShortCut.ContainsKey(e.KeyCode) Then
            Dim btn = dicShortCut.Item(e.KeyCode)
            If btn.Visible And btn.Enabled Then
                btn.PerformClick()
            End If
        End If
    End Sub
End Class