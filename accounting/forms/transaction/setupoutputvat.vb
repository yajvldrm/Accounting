Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class setupoutputvat
    Private transmode As String = ""
    Private _jbooks_id As String = ""
    Private _currency_id As String = ""
    Private _exchange_rate As Decimal = 0.0
    Private _based_rate As Decimal = 0.0
    Private _asofdate As String = ""
    Public Property generalID As String = ""
    Public Property generalCode As String = ""
    Public Property generalName As String = ""
    Friend Sub initializeDecimalPlaces(ByVal strNumberFormat As String)
        txtvatrate.NumberFormat = strNumberFormat
        txtgrossamount.Properties.DisplayFormat.FormatString = "n" & 2
        txtgrossamount.Properties.EditFormat.FormatString = "n" & 2
        txtgrossamount.Properties.Mask.EditMask = "n" & 2
        txtvatamount.Properties.DisplayFormat.FormatString = "n" & 2
        txtvatamount.Properties.EditFormat.FormatString = "n" & 2
        txtvatamount.Properties.Mask.EditMask = "n" & 2
        txtnetamount.Properties.DisplayFormat.FormatString = "n" & 2
        txtnetamount.Properties.EditFormat.FormatString = "n" & 2
        txtnetamount.Properties.Mask.EditMask = "n" & 2
    End Sub
    Private Sub setupoutputvat_FormClosed(sender As Object, e As Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub setupoutputvat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControlDet(Me)
        TextEditEnterToTab(Me)
        Dim vatrate As DataTable = FsQuery("select a.vat_rate from lib_acc_output_vat a " &
                                    "inner join (select max(effectivity_date) as effectivity_date " &
                                           "from lib_acc_output_vat " &
                                           "where effectivity_date <= '" & asofdate & "') b on a.effectivity_date = b.effectivity_date")
        If vatrate.Rows.Count > 0 Then
            txtvatrate.DecimalValue = vatrate.Rows(0)("vat_rate")
        End If
        dgdet.AutoGenerateColumns = False
        dgdet.DataSource = ds.Tables("output_vat")

    End Sub
    Private Sub cmdNotSave_Click(sender As Object, e As EventArgs) Handles btnnotsave.Click
        DisableControlDet(Me)
        Me.Hide()
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.DialogResult = DialogResult.OK
        DisableControlDet(Me)
        Me.Hide()
    End Sub
#Region "General Information"
    Private _str_general_id As String
    Private _str_general_code As String
    Private _str_general_name As String
    Public Property str_general_id() As String
        Get
            Return _str_general_id
        End Get
        Set(value As String)
            _str_general_id = value
        End Set
    End Property
    Public Property str_general_code() As String
        Get
            Return _str_general_code
        End Get
        Set(value As String)
            _str_general_code = value
        End Set
    End Property
    Public Property str_general_name() As String
        Get
            Return _str_general_name
        End Get
        Set(value As String)
            _str_general_name = value
        End Set
    End Property
#End Region
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
    Public Property asofdate() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _asofdate
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _asofdate = value
        End Set
    End Property
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        transmode = "insert"
        EnableControlDet(Me)
        ClearControlDet(Me)
        setRdoValue(radvattype, 1)
        txtgrossamount.Enabled = True
        txtgeneral.Focus()
        txtgeneral.Value = generalID
        txtgeneral.Text = generalCode
        txtgeneralname.Text = generalName
        btnhdr2.Visible = False
        btndet2.Visible = True
    End Sub
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim dt As DataTable = ds.Tables("output_vat")
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0

        Dim selectedRows = dgdet.SelectedRows

        If transmode = "insert" Then
            dr = dt.NewRow
            dr("output_vat_id") = "tmp_" & Now.ToString("yyyyMMddHHmmss")
            If DataExist(dgdet, {"jbooks_id", jbooks_id}, {"general_id"}, {txtgeneral.Value}, True, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
        Else
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value = 1 Then
                If txtvatamount.EditValue < selectedRow.Cells("minimum").Value Then
                    MsgBox("Unable to Save. Vat Amount is lower than expected value.")
                    Exit Sub
                End If
            End If
            If DataExist(dgdet, {"jbooks_id", jbooks_id}, {"general_id"}, {txtgeneral.Value}, False, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
            sel = dgdet.SelectedRows(0).Index
            dr = ds.Tables("output_vat").Rows(sel)
        End If

        dr("sel") = False
        dr("jbooks_id") = jbooks_id
        dr("general_id") = txtgeneral.Value
        dr("general_code") = txtgeneral.Text
        dr("general_name") = txtgeneralname.Text
        dr("vat_type") = getRdoValue(radvattype)
        dr("tin") = txttin.Text
        dr("address") = txtaddress.Text
        dr("offset_type") = 0
        dr("vat_rate") = Math.Round(CDec(ifNull(txtvatrate.DecimalValue, 0)), 2)
        dr("gross_amount") = Math.Round(CDec(ifNull(txtgrossamount.EditValue, 0)), 2)
        dr("vat_amount") = Math.Round(CDec(ifNull(txtvatamount.EditValue, 0)), 2)
        dr("net_amount") = Math.Round(CDec(ifNull(txtnetamount.EditValue, 0)), 2)
        dr("debit") = 0.0
        dr("credit") = Math.Round(CDec(ifNull(txtvatamount.EditValue, 0)), 2)
        dr("currency_id") = currency_id
        dr("exchange_rate") = exchange_rate
        dr("based_rate") = based_rate
        dr("gross_amount_based") = Math.Round(CDec(ifNull(txtgrossamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("vat_amount_based") = Math.Round(CDec(ifNull(txtvatamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("net_amount_based") = Math.Round(CDec(ifNull(txtnetamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("debit_based") = 0.0
        dr("credit_based") = Math.Round(CDec(ifNull(txtvatamount.EditValue * (exchange_rate / based_rate), 0)), 2)

        If transmode = "insert" Then
            ds.Tables("output_vat").Rows.Add(dr)
        End If

        transmode = ""

        DisableControlDet(Me)
        btninsert.Focus()
        btnhdr2.Visible = True
        btndet2.Visible = False
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim selectedRows = dgdet.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value < 2 Then
                transmode = "update"
                EnableControlDet(Me)
                rdovattype_CheckedChanged(Nothing, Nothing)
                txtgeneral.Focus()
                btnhdr2.Visible = False
                btndet2.Visible = True
            Else
                MsgBox("Unable to Edit")
            End If
        Else
            MsgBox("No Record Selected")
        End If
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
    Private Sub dgdet_SelectionChanged(sender As Object, e As EventArgs) Handles dgdet.SelectionChanged
        If dgdet.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        BindControlDet(Me, ds.Tables("output_vat").Rows(dgdet.SelectedRows(0).Index))
    End Sub
    Private Sub txtgeneral_Leave(sender As Object, e As EventArgs) Handles txtgeneral.Leave
        Dim generaldt As DataTable = FsQuery("select * from lib_erp_general ORDER BY FIELD(category_id,1,2),general_code ASC")
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
                txtgeneral.Value = dr("general_id").ToString
                txtgeneral.Text = dr("general_code").ToString
                txtgeneralname.Text = dr("general_name").ToString
                txttin.Text = dr("tin").ToString
                txtaddress.Text = dr("address1").ToString
            End If
        End If

    End Sub
    Private Sub txtgrossamount_Leave(sender As Object, e As EventArgs) Handles txtgrossamount.Leave
        compute_vat()
    End Sub
    Private Sub compute_vat()
        If getRdoValue(radvattype) = "1" Then
            txtvatamount.EditValue = Math.Round((txtgrossamount.EditValue / (1 + (txtvatrate.DecimalValue / 100))) * (txtvatrate.DecimalValue / 100), main.DecimalPlaces)
            txtnetamount.EditValue = Math.Round(txtgrossamount.EditValue - txtvatamount.EditValue, main.DecimalPlaces)
        Else
            txtvatamount.EditValue = Math.Round(txtnetamount.EditValue * (txtvatrate.DecimalValue / 100), main.DecimalPlaces)
            txtgrossamount.EditValue = Math.Round(txtnetamount.EditValue + txtvatamount.EditValue, main.DecimalPlaces)
        End If
    End Sub
    Private Sub rdovattype_CheckedChanged(sender As Object, e As EventArgs) Handles rdovattype1.CheckedChanged, rdovattype2.CheckedChanged
        If transmode <> "" Then
            If rdovattype1.Checked Then
                txtgrossamount.Enabled = True
                txtnetamount.Enabled = False
            Else
                txtgrossamount.Enabled = False
                txtnetamount.Enabled = True
            End If
        End If
    End Sub
    Private Sub txtnetamount_Leave(sender As Object, e As EventArgs) Handles txtnetamount.Leave
        compute_vat()
    End Sub
    Private Sub setupoutputvat_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        btninsert.Focus()
        loadDTToDG(dgdet, ds.Tables("output_vat"))
    End Sub
    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim arr_id = getCheckedGrid("output_vat_id", "general_code", "sel", dgdet, "", False, , False)
        If arr_id.Length > 0 Then
            For Each row As DataRow In ds.Tables("output_vat").Rows
                If arr_id.Contains(row.Item("output_vat_id").ToString) Then
                    row.Item("deleted") = True
                End If
            Next
            loadDTToDG(dgdet, ds.Tables("output_vat"))
        End If
    End Sub
    Private Sub setupoutputvat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DisableControlDet(Me)
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