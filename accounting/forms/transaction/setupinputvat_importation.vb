Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Drawing
Imports Excel = Microsoft.Office.Interop.Excel
Public Class setupinputvat_importation
    'Declaration 
    Private transmode As String = ""
    Private _jbooks_id As String = ""
    Private _currency_id As String = ""
    Private _exchange_rate As Decimal = 0.0
    Private _based_rate As Decimal = 0.0
    Private _asofdate As String = ""

    Public Property generalID As String = ""
    Public Property generalCode As String = ""
    Public Property generalName As String = ""
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
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Try
            transmode = "insert"
            EnableControlDet(Me)
            ClearControlDet(Me)
            btnhdr2.Visible = False

            txtgeneral.Value = generalID
            txtgeneral.Text = generalCode
            txtgeneralname.Text = generalName
            txtgeneral.Focus()

            btndet2.Visible = True
            txt_Taxable_goods.Enabled = False
            txt_Vat_amount.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtgeneral_Leave(sender As Object, e As EventArgs) Handles txtgeneral.Leave
        Try
            Dim generaldt As DataTable = FsQuery("select * from lib_erp_general ORDER BY FIELD(category_id,2,1),general_code ASC")
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
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub setupinputvat_importation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btndet2.Visible = False
        txt_Taxable_goods.Enabled = False
        txt_Vat_amount.Enabled = False
        radvatclass.Visible = False
        ClearControlDet(Me)

        TextEditEnterToTab(Me)
        Dim vatrate As DataTable = FsQuery("select a.vat_rate from lib_acc_input_vat a " &
                                    "inner join (select max(effectivity_date) as effectivity_date " &
                                           "from lib_acc_input_vat " &
                                           "where effectivity_date <= '" & asofdate & "') b on a.effectivity_date = b.effectivity_date")
        If vatrate.Rows.Count > 0 Then
            txtvatrate.DecimalValue = vatrate.Rows(0)("vat_rate")
        End If
        dgdet.AutoGenerateColumns = False
        dgdet.DataSource = ds.Tables("input_vat_for_importation")

    End Sub
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

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txt_Vat_amount.EditValue <= 0 Then
            MsgBox("Invalid Vat Amount", vbCritical + vbOKOnly)
            Exit Sub
        End If
        Dim dt As DataTable = ds.Tables("input_vat_for_importation")
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0
        Dim selectedRows = dgdet.SelectedRows

        If txt_Import_Entry_no.EditValue = "" Then
            MsgBox("Import Entry number is required!", vbInformation)
            Exit Sub
        End If

        If transmode = "insert" Then
            dr = dt.NewRow
            dr("input_vat_id") = "tmp_" & Now.ToString("yyyyMMddHHmmss")

            If DataExist(dgdet, {"jbooks_id", jbooks_id}, {"general_id"}, {txtgeneral.Value}, True, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub

            End If
        Else
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value = 1 Then
                If txt_Vat_amount.EditValue < selectedRow.Cells("minimum").Value Then
                    MsgBox("Unable to Save. Vat Amount is lower than expected value.")
                    Exit Sub
                End If
            End If
            If DataExist(dgdet, {"jbooks_id", jbooks_id}, {"general_id"}, {txtgeneral.Value}, False, False) Then
                MsgBox("Existing transaction cannot be save.")
                Exit Sub
            End If
            sel = dgdet.SelectedRows(0).Index
            dr = ds.Tables("input_vat_for_importation").Rows(sel)
        End If
        'If getRdoValue(radvatclass) = "" Then
        '    MsgBox("Select Vat Input Type")
        '    Exit Sub
        'End If
        dr("sel") = False
        dr("jbooks_id") = jbooks_id
        dr("general_id") = txtgeneral.Value
        dr("general_code") = txtgeneral.Text
        dr("general_name") = txtgeneralname.Text
        ' dr("vat_class") = getRdoValue(radvatclass)
        'dr("vat_type") = getRdoValue(radvattype)
        dr("tin") = txttin.Text
        dr("address") = txtaddress.Text
        dr("offset_type") = 0
        dr("vat_rate") = Math.Round(CDec(ifNull(txtvatrate.DecimalValue, 0)), 2)
        'dr("gross_amount") = Math.Round(CDec(ifNull(txtgrossamount.EditValue, 0)), 2)
        dr("vat_amount") = Math.Round(CDec(ifNull(Trim(txt_Vat_amount.EditValue), 0)), 2)
        'dr("net_amount") = Math.Round(CDec(ifNull(txtnetamount.EditValue, 0)), 2)
        dr("debit") = Math.Round(CDec(ifNull(txt_Vat_amount.EditValue, 0)), 2)
        dr("credit") = 0.0
        dr("currency_id") = currency_id
        dr("exchange_rate") = exchange_rate
        dr("based_rate") = based_rate
        'dr("gross_amount_based") = Math.Round(CDec(ifNull(txtgrossamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("vat_amount_based") = Math.Round(CDec(ifNull(txt_Vat_amount.EditValue * (exchange_rate / based_rate), 0)), 2)
        'dr("net_amount_based") = Math.Round(CDec(ifNull(txtnetamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("debit_based") = Math.Round(CDec(ifNull(txt_Vat_amount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("credit_amount_based") = 0.0 
        dr("Import_Entry_no") = txt_Import_Entry_no.EditValue
        dr("OR_number") = txt_OR_number.EditValue
        dr("Release_Date") = txt_Release_Date.Value
        dr("Total_Landed_Cost") = txt_Total_Landed_Cost.EditValue
        dr("Taxable_goods") = txt_Taxable_goods.EditValue
        dr("Date_of_importation") = txt_Date_of_importation.Value
        dr("Dutiable_value") = txt_Dutiable_value.EditValue
        dr("date_of_vatpayment") = txt_date_of_vatpayment.Value
        dr("country_of_origin") = txt_country_of_origin.EditValue

        dr("all_charges_before_release_from_customs") = txt_all_charges_before_release_from_customs.EditValue
        dr("Exempt") = txt_exempt.EditValue

        'dr("Vat_amount") = txtVat_amount.EditValue 
        If transmode = "insert" Then
            ds.Tables("input_vat_for_importation").Rows.Add(dr)
            btndet2.Visible = False
        End If

        loadDTToDG(dgdet, ds.Tables("input_vat_for_importation"))
        transmode = ""
        DisableControlDet(Me)
        btninsert.Focus()
        btnhdr2.Visible = True
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim arr_id = getCheckedGrid("input_vat_id", "general_code", "sel", dgdet, "", False, , False)
        If arr_id.Length > 0 Then
            For Each row As DataRow In ds.Tables("input_vat_for_importation").Rows
                If arr_id.Contains(row.Item("input_vat_id").ToString) Then
                    row.Item("deleted") = True
                End If
            Next
            loadDTToDG(dgdet, ds.Tables("input_vat_for_importation"))
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim selectedRows = dgdet.SelectedRows
        If selectedRows.Count > 0 Then
            Dim selectedRow = selectedRows(0)
            If selectedRow.Cells("offset").Value < 2 Then
                transmode = "update"
                EnableControlDet(Me)
                'rdovattype_CheckedChanged(Nothing, Nothing)
                txtgeneral.Focus()
                btnhdr2.Visible = False
                txt_Taxable_goods.Enabled = False
                txt_Vat_amount.Enabled = False

                btndet2.Visible = True
            Else
                MsgBox("Unable to Edit")
            End If
        Else
            MsgBox("No Record Selected")
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Me.DialogResult = DialogResult.OK

            DisableControlDet(Me)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub computation()
        Try
            Dim total_landed_cost As Double = txt_Total_Landed_Cost.Text
            Dim dutiable_value As Double = txt_Dutiable_value.Text
            Dim all_charges_before_release_from_customs As Double = txt_all_charges_before_release_from_customs.Text
            Dim exempt As Double = txt_exempt.Text
            Dim taxable_goods As Double
            Dim vat_rate As Double = txtvatrate.Text
            Dim vat_amount As Double

            'Computation

            taxable_goods = (dutiable_value + all_charges_before_release_from_customs) - exempt
            vat_amount = taxable_goods * (vat_rate / 100)

            'format 

            txt_Taxable_goods.Text = Format(taxable_goods, "#,##0.0000")
            txt_Vat_amount.Text = Format(vat_amount, "#,##0.0000")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtall_charges_before_release_from_customs_Leave(sender As Object, e As EventArgs) Handles txt_all_charges_before_release_from_customs.Leave
        computation()
    End Sub

    Private Sub txtTaxable_goods_Leave(sender As Object, e As EventArgs) Handles txt_Taxable_goods.Leave
        computation()
    End Sub

    Private Sub txtTotal_Landed_Cost_Leave(sender As Object, e As EventArgs) Handles txt_Total_Landed_Cost.Leave

        Dim total_landed_cost As Double = txt_Total_Landed_Cost.EditValue
        Dim dutiable_value As Double = txt_Dutiable_value.EditValue
        txt_Dutiable_value.Text = Format(total_landed_cost, "#,##0.00")
        computation()
    End Sub

    Private Sub txtDutiable_value_Leave(sender As Object, e As EventArgs) Handles txt_Dutiable_value.Leave
        Dim total_landed_cost As Double = txt_Total_Landed_Cost.EditValue
        Dim dutiable_value As Double = txt_Dutiable_value.EditValue
        txt_Total_Landed_Cost.Text = Format(dutiable_value, "#,##0.00")
        computation()

    End Sub

    Private Sub txtexempt_Leave(sender As Object, e As EventArgs) Handles txt_exempt.Leave
        computation()
    End Sub
    Private Sub txtImport_Entry_no_Leave(sender As Object, e As EventArgs) Handles txt_Import_Entry_no.Leave
        If txt_Import_Entry_no.Enabled Then
            txt_Import_Entry_no.Text = txt_Import_Entry_no.Text.ToUpper()
            Dim sql As String = String.Format("Select * FROM {1}.trans_input_vat_importation a " +
                                            " LEFT JOIN {1}.select_input_vat b On a.input_vat_id = b.input_vat_id  " +
                                            "where a.Import_Entry_no = '{0}'", Trim(txt_Import_Entry_no.Text), _serverDBMain)
            Dim dt As DataTable = Query(sql)
            If dt.Rows.Count > 0 Then
                MsgBox("Transaction No Already Exist.")
                txt_Import_Entry_no.Text = ""
            End If
        End If
    End Sub

    Private Sub txtOR_number_Leave(sender As Object, e As EventArgs) Handles txt_OR_number.Leave
        Try
            If txt_OR_number.Enabled Then
                txt_OR_number.Text = txt_OR_number.Text.ToUpper()
                Dim sql As String = String.Format("Select * FROM {1}.trans_input_vat_importation a " +
                                                " LEFT JOIN {1}.select_input_vat b On a.input_vat_id = b.input_vat_id  " +
                                                "where a.OR_number = '{0}'", Trim(txt_OR_number.Text), _serverDBMain)
                Dim dt As DataTable = Query(sql)
                If dt.Rows.Count > 0 Then
                    MsgBox("Transaction No Already Exist.")
                    txt_OR_number.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub det_Paint(sender As Object, e As PaintEventArgs) Handles det.Paint
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
        BindControlDet(Me, ds.Tables("input_vat_for_importation").Rows(dgdet.SelectedRows(0).Index))
    End Sub

    Private Sub txtTaxable_goods_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Taxable_goods.EditValueChanged

    End Sub

    Private Sub btnnotsave_Click(sender As Object, e As EventArgs) Handles btnnotsave.Click
        Me.Close()
    End Sub


End Class