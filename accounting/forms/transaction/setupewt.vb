Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class setupewt
    Private generaldt As New DataTable
    Private ewtdt As New DataTable
    'Public ewtdt As New DataTable
    Private transmode As String = ""
    Private _jbooks_id As String = ""
    Private _currency_id As String = ""
    Private _exchange_rate As Decimal = 0.0
    Private _based_rate As Decimal = 0.0

    Public Property generalID As String = ""
    Public Property generalCode As String = ""
    Public Property generalName As String = ""
    Public Property initialAmount As Decimal = 0
    Public Property TotalDebit As Decimal = 0
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
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txttaxrate.Properties.DisplayFormat.FormatString = "n" & 2
        txttaxrate.Properties.EditFormat.FormatString = "n" & 2
        txttaxrate.Properties.Mask.EditMask = "n" & 2
        txtamount.Properties.DisplayFormat.FormatString = "n" & 2
        txtamount.Properties.EditFormat.FormatString = "n" & 2
        txtamount.Properties.Mask.EditMask = "n" & 2
        txttaxamount.Properties.DisplayFormat.FormatString = "n" & 2
        txttaxamount.Properties.EditFormat.FormatString = "n" & 2
        txttaxamount.Properties.Mask.EditMask = "n" & 2
        txt_tmp_amount.Properties.DisplayFormat.FormatString = "n" & 2
        txt_tmp_amount.Properties.EditFormat.FormatString = "n" & 2
        txt_tmp_amount.Properties.Mask.EditMask = "n" & 2
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
        Dim sql As String = String.Format("SELECT a.general_id,a.ewt_id,b.ewt_code,b.ewt_name,b.tax_rate " &
            "FROM lib_erp_general_ewt a " &
            "LEFT JOIN lib_acc_ewt b ON b.ewt_id = a.ewt_id " &
            "WHERE a.general_id = '{0}' ", generalID)
        Dim dt As DataTable = FsQuery(sql)
        If dt.Rows.Count = 1 Then
            Dim dr As DataRow = dt.Rows(0)
            txtewtname.Text = dr("ewt_name")
            txtewt.Text = dr("ewt_code")
            txtewt.Value = dr("ewt_id")
            txttaxrate.EditValue = dr("tax_rate")
        End If
        txtamount.EditValue = initialAmount
    End Sub

    Private Sub clear_control()
        txtgeneral.Value = ""
        txtgeneral.Text = ""
        txtgeneralname.Text = ""
        txtewt.Value = ""
        txtewt.Text = ""
        txtewtname.Text = ""
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
        txtewt.Enabled = True
        txttaxrate.Enabled = True
        txtamount.Enabled = True

        txtgeneral.Focus()
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
        txtewt.Enabled = False
        txttaxrate.Enabled = False
        txtamount.Enabled = False
    End Sub

    Private Sub bind_control()
        If dgewt.RowCount = 0 Then
            clear_control()
            Exit Sub
        End If
        If dgewt.SelectedRows.Count = 0 Then
            clear_control()
            Exit Sub
        End If

        Dim sel As Integer = dgewt.SelectedRows(0).Index
        Dim dr As DataRow = ds.Tables("ewt").Rows(sel)

        txtgeneral.Value = dr("general_id")
        txtgeneral.Text = dr("general_code")
        txtgeneralname.Text = dr("general_name")
        txtTIN.Text = dr("tin")
        txtewt.Value = dr("fs_ewt_id")
        txtewt.Text = dr("fs_ewt_code")
        txtewtname.Text = dr("fs_ewt_name")
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

    Private Sub txtewt_Leave(sender As Object, e As EventArgs) Handles txtewt.Leave
        Dim sql_ewt As String = "SELECT * FROM lib_acc_ewt"
        If txtgeneral.Value <> "" Then
            sql_ewt = String.Format("SELECT a.general_id,a.ewt_id,b.ewt_code,b.ewt_name,b.tax_rate " & _
                "FROM lib_erp_general_ewt a " & _
                "LEFT JOIN lib_acc_ewt b ON b.ewt_id = a.ewt_id " & _
                "WHERE a.general_id = '{0}' ", txtgeneral.Value)
        End If
        ewtdt = FsQuery(sql_ewt)
        If ewtdt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If ewtdt.Rows.Count = 1 Then
                dr = ewtdt.Rows(0)
            Else
                Dim dra() As DataRow = ewtdt.Select("ewt_code like '" & txtewt.Text.ToString.Replace("'", "''") & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = ewtdt
                    browse.format("Code,NIP", "ewt_code,ewt_name", "100,360")
                    If browse.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtewt.RowData = dr
                txtewt.Value = dr("ewt_id")
                txtewt.Text = dr("ewt_code")
                txtewtname.Text = dr("ewt_name")
                txttaxrate.EditValue = dr("tax_rate")
                compute_tax()
            End If
        End If
    End Sub

    Private Sub compute_tax()
        If txttaxrate.EditValue <> 0 Then
            txttaxamount.EditValue = txtamount.EditValue * (txttaxrate.EditValue / 100)
        Else
            txttaxamount.EditValue = 0
        End If
    End Sub

    Private Sub txttaxrate_Leave(sender As Object, e As EventArgs) Handles txttaxrate.Leave
        compute_tax()
    End Sub

    Private Sub txtamount_Leave(sender As Object, e As EventArgs) Handles txtamount.EditValueChanged
        compute_tax()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedRows = dgewt.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value < 2 Then
                transmode = "update"
                enable_control()
                txttaxamount.Enabled = False
            Else
                MsgBox("Unable to Edit.")
            End If
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dt As DataTable = ds.Tables("ewt")
        Dim tmp_dt As DataTable = dgewt.DataSource
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0

        Dim selectedRows = dgewt.SelectedRows
        If ifNull(txtewt.Value, "").ToString() = "" Then
            MsgBox("No ATC Code")
            Exit Sub
        End If
        If transmode = "insert" Then
            dr = dt.NewRow
            dr("ewt_id") = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            If DataExist(dgewt, {"jbooks_id", jbooks_id}, {"general_id", "fs_ewt_id"}, {txtgeneral.Value, txtewt.Value}, True, False) Then
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
            sel = dgewt.SelectedRows(0).Index
            dr = ds.Tables("ewt").Rows(sel)
            If DataExist(dgewt, {"jbooks_id", jbooks_id}, {"general_id", "fs_ewt_id"}, {txtgeneral.Value, txtewt.Value}, False, False) Then
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
        dr("fs_ewt_id") = txtewt.Value
        dr("fs_ewt_code") = txtewt.Text
        dr("fs_ewt_name") = txtewtname.Text
        dr("offset_type") = 0
        dr("tax_rate") = Math.Round(CDec(ifNull(txttaxrate.EditValue, 0)), 2)
        dr("amount") = Math.Round(CDec(ifNull(txtamount.EditValue, 0)), 2)
        dr("tax_amount") = Math.Round(CDec(ifNull(txttaxamount.EditValue, 0)), 2)
        dr("debit") = 0.0
        dr("credit") = Math.Round(CDec(ifNull(txttaxamount.EditValue, 0)), 2)
        dr("currency_id") = currency_id
        dr("exchange_rate") = exchange_rate
        dr("based_rate") = based_rate
        dr("amount_based") = Math.Round(txtamount.EditValue * (exchange_rate / based_rate), 2)
        dr("tax_amount_based") = Math.Round(txttaxamount.EditValue * (exchange_rate / based_rate), 2)
        dr("debit_based") = 0.0
        dr("credit_based") = Math.Round(txttaxamount.EditValue * (exchange_rate / based_rate), 2)

        If transmode = "insert" Then
            ds.Tables("ewt").Rows.Add(dr)
        End If
        loadDTToDG(dgewt, ds.Tables("ewt"))
        transmode = ""
        disable_control()
        btnInsert.Focus()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        clear_control()
        disable_control()
        If dgewt.Rows.Count > 0 Then
            dgewt.ClearSelection()
            dgewt.Rows(0).Selected = True
        End If
        transmode = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.DialogResult = DialogResult.OK
        DisableControlDet(Me)
        Me.Hide()
    End Sub

    Private Sub setupewt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            If e.KeyCode = Keys.S Then
                If transmode = "" Then
                    btnOK_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub setupewt_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        btnInsert.Focus()
        loadDTToDG(dgewt, ds.Tables("ewt"))
    End Sub


    Private Sub dgewt_SelectionChanged(sender As Object, e As EventArgs) Handles dgewt.SelectionChanged
        bind_control()
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim arr_id = getCheckedGrid("ewt_id", "fs_ewt_code", "sel", dgewt, "", False, , False)
        If arr_id.Length > 0 Then
            For Each row As DataRow In ds.Tables("ewt").Rows
                If arr_id.Contains(row.Item("ewt_id").ToString) Then
                    row.Item("deleted") = True
                End If
            Next
            loadDTToDG(dgewt, ds.Tables("ewt"))
        End If
    End Sub

    Private Sub setupewt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DisableControlDet(Me)
    End Sub

    Private Sub setupewt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear_control()
        TextEditEnterToTab(Me)
        dgewt.AutoGenerateColumns = False
        dgewt.DataSource = ds.Tables("ewt")
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