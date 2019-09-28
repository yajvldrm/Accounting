Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Imports System.Windows.Forms
Imports System.IO

Public Class transap
    Private genlibdt As New DataTable
    Private currencydt As New DataTable
    Private chartdt As New DataTable

    Private _journalid As String
    Private _bookid As String

    Private transmode As String = ""
    Private transmodedet As String = ""


    Public Property journal_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _journalid
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _journalid = value
        End Set
    End Property

    Public Property book_id() As String
        ' Retrieves the value of the private variable colBColor.
        Get
            Return _bookid
        End Get
        ' Stores the selected value in the private variable colBColor, and 
        ' updates the background color of the label control lblDisplay.
        Set(ByVal value As String)
            _bookid = value
        End Set
    End Property

    Private Sub transap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgTrans.AutoGenerateColumns = False
        dgjbooks.AutoGenerateColumns = False

        dgTrans.DataSource = ds.Tables("trans")
        dgjbooks.DataSource = ds.Tables("jbooks")
        ds.Tables("jbooks").DefaultView.Sort = "dc,account_code"

        disable_control()
    End Sub

    Private Sub clear_control()
        txttransno.Text = ""
        txtday.Text = ""
        txtsino.Text = ""
        txtrrno.Text = ""
        txtpono.Text = ""
        txtgeneral.Value = ""
        txtgeneral.Text = ""
        txtgeneralname.Text = ""
        txtcurrency.Value = ""
        txtcurrency.Text = ""
        txtexchangerate.Text = Format(0, txtexchangerate.NumberFormat)
        txtbasedrate.Text = Format(0, txtbasedrate.NumberFormat)
        txtamount.Text = Format(0, txtamount.NumberFormat)
        txtamountbased.Text = Format(0, txtamountbased.NumberFormat)
        txtamountwords.Text = ""
        txtdesc.Text = ""

        ds.Tables("jbooks").Rows.Clear()
        ds.Tables("ewt").Rows.Clear()
        ds.Tables("input_vat").Rows.Clear()
        ds.Tables("output_vat").Rows.Clear()
        ds.Tables("prepaid").Rows.Clear()
        ds.Tables("fixed_asset").Rows.Clear()
        ds.Tables("checks").Rows.Clear()

        lbldebittotal.Text = Format(0, txtdebit.NumberFormat)
        lblcredittotal.Text = Format(0, txtcredit.NumberFormat)
        lbldifftotal.Text = Format(0, txtdebit.NumberFormat)
        lbldebitbasedtotal.Text = Format(0, txtdebitbased.NumberFormat)
        lblcreditbasedtotal.Text = Format(0, txtcreditbased.NumberFormat)
        lbldiffbasedtotal.Text = Format(0, txtdebit.NumberFormat)

        clear_control_det()
    End Sub

    Private Sub enable_control()
        btnAdd.Visible = False
        btnEdit.Visible = False
        btnCancel.Visible = False
        btnPrint.Visible = False
        btnSettings.Visible = False
        btnSave.Visible = True
        btnNotSave.Visible = True

        btnInsert.Enabled = True
        btnUpdate.Enabled = True
        btnRemove.Enabled = True
        btnOK.Enabled = False
        btnUndo.Enabled = False

        Dim dr As DataRow = main.Sys_Default_Det.Select("module_code = 'ACC00301'")(0)
        If dr("auto_number") = 1 Then
            txttransno.Enabled = False
        Else
            txttransno.Enabled = True
        End If
        txtday.Enabled = True
        txtsino.Enabled = True
        txtrrno.Enabled = True
        txtpono.Enabled = True
        txtgeneral.Enabled = True
        txtcurrency.Enabled = True
        txtexchangerate.Enabled = True
        txtbasedrate.Enabled = True

        Dim dr2 As DataRow = main.Sys_Default.Rows(0)
        If dr2("line_remarks") = 1 Then
            txtdesc.Enabled = False
        Else
            txtdesc.Enabled = True
        End If

        If dr("auto_number") = 1 Then
            txtday.Focus()
        Else
            txttransno.Enabled = True
        End If
    End Sub

    Private Sub disable_control()
        btnAdd.Visible = True
        btnEdit.Visible = True
        btnCancel.Visible = True
        btnPrint.Visible = True
        btnSettings.Visible = True
        btnSave.Visible = False
        btnNotSave.Visible = False

        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnOK.Enabled = False
        btnUndo.Enabled = False

        txttransno.Enabled = False
        txtday.Enabled = False
        txtsino.Enabled = False
        txtrrno.Enabled = False
        txtpono.Enabled = False
        txtgeneral.Enabled = False
        txtcurrency.Enabled = False
        txtexchangerate.Enabled = False
        txtbasedrate.Enabled = False
        txtdesc.Enabled = False
    End Sub

    Private Sub clear_control_det()
        txtlineremarks.Text = ""
        txtproject.Text = ""
        txtdepartment.Text = ""
        txtallocation.Text = ""
        txtaccount.Value = ""
        txtaccount.Text = ""
        txtaccountname.Text = ""
        txtdebit.Text = Format(0, txtdebit.NumberFormat)
        txtcredit.Text = Format(0, txtcredit.NumberFormat)
        txtdebitbased.Text = Format(0, txtdebitbased.NumberFormat)
        txtcreditbased.Text = Format(0, txtcreditbased.NumberFormat)
        txtgeneraldet.Value = ""
        txtgeneraldet.Text = ""
        txtgeneraldetname.Text = ""
        txtdnref.Text = ""
        txtdnrefbookcode.Text = ""
        txtdnrefjournalcode.Text = ""
    End Sub

    Private Sub enable_control_det()
        If txtbasedrate.DecimalValue = 0 Then
            MsgBox("Unable to modify entries because the Based Rate amount is equal to zero.")
            Exit Sub
        End If

        btnSave.Enabled = False
        btnNotSave.Enabled = False

        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnOK.Enabled = True
        btnUndo.Enabled = True

        Dim dr As DataRow = main.Sys_Default.Rows(0)
        If dr("line_remarks") = 1 Then
            txtlineremarks.Enabled = True
        Else
            txtlineremarks.Enabled = False
        End If
        If dr("w_proj") = 1 Then
            txtproject.Enabled = True
        Else
            txtproject.Enabled = False
        End If
        If dr("w_dept") = 1 Then
            txtdepartment.Enabled = True
        Else
            txtdepartment.Enabled = False
        End If
        If dr("w_alloc") = 1 Then
            txtallocation.Enabled = True
        Else
            txtallocation.Enabled = False
        End If
        txtaccount.Enabled = True
        txtdebit.Enabled = True
        txtcredit.Enabled = True
        txtgeneraldet.Enabled = True
        txtdnref.Enabled = True

        If dr("line_remarks") = 1 Then
            txtlineremarks.Focus()
        Else
            If dr("w_proj") = 1 Then
                txtproject.Focus()
            Else
                If dr("w_dept") = 1 Then
                    txtdepartment.Focus()
                Else
                    If dr("w_alloc") = 1 Then
                        txtallocation.Focus()
                    Else
                        txtaccount.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub disable_control_det()
        btnSave.Enabled = True
        btnNotSave.Enabled = True

        btnInsert.Enabled = True
        btnUpdate.Enabled = True
        btnRemove.Enabled = True
        btnOK.Enabled = False
        btnUndo.Enabled = False

        txtlineremarks.Enabled = False
        txtproject.Enabled = False
        txtdepartment.Enabled = False
        txtallocation.Enabled = False
        txtaccount.Enabled = False
        txtdebit.Enabled = False
        txtcredit.Enabled = False
        txtgeneraldet.Enabled = False
        txtdnref.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        transmode = "add"
        enable_control()
        clear_control()
        Dim dr As DataRow = main.Sys_Default_Det.Select("module_code = 'ACC00301'")(0)
        If dr("auto_number") = 1 Then
            Dim newno = Query("call getnewtransno(" & journal_id & ",'ACC00301'," & txtmonth.Value & "," & txtyear.Text & ")").Rows(0)("trans_no_new")
            txttransno.Text = newno
        End If
        txtday.Text = Now().Day
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        disable_control()
        transmode = ""
        transmodedet = ""
    End Sub

    Private Sub txtgenlib_Leave(sender As Object, e As EventArgs) Handles txtgeneral.Leave
        genlibdt = FsQuery("select * from lib_erp_general")
        If genlibdt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If genlibdt.Rows.Count = 1 Then
                dr = genlibdt.Rows(0)
            Else
                Dim dra() As DataRow = genlibdt.Select("general_code like '" & txtgeneral.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = genlibdt
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

    Private Sub txtcurrency_Leave(sender As Object, e As EventArgs) Handles txtcurrency.Leave
        currencydt = FsQuery("select a.currency_id,a.currency_code,a.currency_name " & _
            ",b.exchange_rate,b.based_rate " & _
            "from lib_erp_currency a " & _
            "inner join (select a.currency_id,a.exchange_rate,a.based_rate " & _
                    "from lib_erp_currency_rate a " & _
                    "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " & _
                            "FROM lib_erp_currency_rate " & _
                            "where left(effectivitydate,7) <= '" & txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "' " & _
                    "group by currency_id) b on a.currency_id = b.currency_id " & _
                "and a.effectivitydate = b.effectivitydate) b on a.currency_id = b.currency_id")
        If currencydt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If currencydt.Rows.Count = 1 Then
                dr = currencydt.Rows(0)
            Else
                Dim dra() As DataRow = currencydt.Select("currency_name like '" & txtcurrency.Text & "'")
                If dra.Count > 0 Then
                    dr = dr(0)
                Else
                    browse.dt = currencydt
                    browse.format("Code,Name", "currency_code,currency_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txtcurrency.RowData = dr
                txtcurrency.Value = dr("currency_id")
                txtcurrency.Text = dr("currency_name")
                txtexchangerate.Text = dr("exchange_rate")
                txtbasedrate.Text = dr("based_rate")
            End If
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        transmodedet = "insert"
        enable_control_det()
        clear_control_det()
        txtjbooksidtmp.Text = Now.ToString("yyyyMMddHHmmss")
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        disable_control_det()
        transmodedet = ""
    End Sub

    Private Sub txtchart_Leave(sender As Object, e As EventArgs) Handles txtaccount.Leave
        chartdt = FsQuery("select * from lib_erp_chart")
        If chartdt.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If chartdt.Rows.Count = 1 Then
                dr = chartdt.Rows(0)
            Else
                Dim dra() As DataRow = chartdt.Select("account_code like '" & txtaccount.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = chartdt
                    browse.format("Code,Name", "account_code,account_name", "100,200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                Dim validate As Integer = dr("validation")
                txtaccount.RowData = dr
                txtaccount.Value = dr("account_id")
                txtaccount.Text = dr("account_code")
                txtaccountname.Text = dr("account_name")
                If validate = 9 Then
                    txtdebit.Enabled = False
                    txtcredit.Enabled = False
                    txtdebitbased.Enabled = True
                    txtcreditbased.Enabled = True
                Else
                    txtdebit.Enabled = True
                    txtcredit.Enabled = True
                    txtdebitbased.Enabled = False
                    txtcreditbased.Enabled = False
                    If Not validate = 0 Then
                        txtgeneraldet.Value = txtgeneral.Value
                        txtgeneraldet.Text = txtgeneral.Text
                        txtgeneraldetname.Text = txtgeneralname.Text
                    Else
                        txtgeneraldet.Value = ""
                        txtgeneraldet.Text = ""
                        txtgeneraldetname.Text = ""
                    End If
                End If
                If "019".IndexOf(validate.ToString) >= 0 Then
                    txtgeneraldet.Enabled = False
                Else
                    txtgeneraldet.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtgenlibdet_Leave(sender As Object, e As EventArgs) Handles txtgeneraldet.Leave
        Dim v As Integer = txtaccount.RowData("validation")
        If "019".IndexOf(v.ToString) < 0 Then
            genlibdt = FsQuery("select * from lib_erp_general")
            If genlibdt.Rows.Count = 0 Then
                MsgBox("No record found.")
            Else
                Dim dr As DataRow = Nothing
                If genlibdt.Rows.Count = 1 Then
                    dr = genlibdt.Rows(0)
                Else
                    Dim dra() As DataRow = genlibdt.Select("general_code like '" & txtgeneraldet.Text & "'")
                    If dra.Count > 0 Then
                        dr = dra(0)
                    Else
                        browse.dt = genlibdt
                        browse.format("Code,Name", "general_code,general_name", "140,240")
                        If browse.ShowDialog() = DialogResult.OK Then
                            If browse.dgview.SelectedRows.Count > 0 Then
                                dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                            End If
                        End If
                    End If
                End If
                If Not dr Is Nothing Then
                    txtgeneraldet.RowData = dr
                    txtgeneraldet.Value = dr("general_id")
                    txtgeneraldet.Text = dr("general_code")
                    txtgeneraldetname.Text = dr("general_name")
                End If
            End If
        End If

    End Sub

    Private Sub txtdebit_Leave(sender As Object, e As EventArgs) Handles txtdebit.Leave
        Dim v As Integer = 0
        If txtdebit.DecimalValue <> 0 Then
            If Not txtaccount.RowData Is Nothing Then
                v = txtaccount.RowData("validation")
                If "01239".IndexOf(Validate.ToString) < 0 Then
                    ValidateEntry()
                End If
            End If
        End If
        If v <> 3 Then
            txtdebitbased.DecimalValue = txtdebit.DecimalValue * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
            txtdnref.Enabled = False
        Else
            txtdnref.Enabled = True
        End If

        If "45678".IndexOf(v.ToString) >= 0 Then
            btnOK_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtcredit_Leave(sender As Object, e As EventArgs) Handles txtcredit.Leave
        Dim v As Integer = 0
        If txtcredit.DecimalValue <> 0 Then
            If Not txtaccount.RowData Is Nothing Then
                v = txtaccount.RowData("validation")
                If "01239".IndexOf(v.ToString) < 0 Then
                    ValidateEntry()
                End If
            End If
        End If
        If v <> 2 Then
            txtcreditbased.DecimalValue = txtcredit.DecimalValue * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
            txtdnref.Enabled = False
        Else
            txtdnref.Enabled = True
        End If
        If "45678".IndexOf(v.ToString) >= 0 Then
            btnOK_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ValidateEntry(Optional dnref As Boolean = False)
        '1 - Bank / Cash
        '2 - AR (debit)
        '3 - AP (credit)
        '4 - EWT (credit)
        '5 - Input VAT (debit)
        '6 - Output VAT (credit)
        '7 - Prepayment (debit)
        '8 - Fixed Asset (debit)
        '9 - Gain or Loss

        If Not txtaccount.RowData Is Nothing Then
            Dim v As Integer = txtaccount.RowData("validation")
            Dim debit As Decimal = 0.0
            Dim credit As Decimal = 0.0

            If "2345678".IndexOf(v.ToString) >= 0 Then
                Me.Visible = False
            End If
            If Val(txtdebit.Text.Replace(",", "")) <> 0 Then
                Select Case v
                    Case 3
                        'If dnref Then
                        '    dtCopy(offsetap.ds.Tables("ap"), ds.Tables("ap"))
                        '    If offsetap.ShowDialog() = DialogResult.OK Then
                        '        dtCopy(ds.Tables("ap"), offsetap.ds.Tables("ap"))
                        '    End If
                        '        debit = ds.Tables("ap").Compute("Sum(debit)", "")
                        'End If
                    Case 4
                        'dtCopy(offsetewt.ds.Tables("ewt"), ds.Tables("ewt"))
                        'If offsetewt.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("ewt"), offsetewt.ds.Tables("ewt"))
                        'End If
                        '    debit = ds.Tables("ewt").Compute("Sum(tax_amount)", "")
                    Case 5
                        'dtCopy(setupinputvat.ds.Tables("input_vat"), ds.Tables("input_vat"))
                        'If setupinputvat.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("input_vat"), setupinputvat.ds.Tables("input_vat"))
                        'End If
                        '    debit = ds.Tables("input_vat").Compute("Sum(vat_amount)", "")
                    Case 6
                        'dtCopy(offsetoutputvat.ds.Tables("output_vat"), ds.Tables("output_vat"))
                        'If offsetoutputvat.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("output_vat"), offsetoutputvat.ds.Tables("output_vat"))
                        'End If
                        '    debit = ds.Tables("output_vat").Compute("Sum(vat_amount)", "")
                    Case 7
                        'dtCopy(setupprepaid.ds.Tables("prepaid"), ds.Tables("prepaid"))
                        'If setupprepaid.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("prepaid"), setupprepaid.ds.Tables("prepaid"))
                        'End If
                        '    debit = ds.Tables("prepaid").Compute("Sum(amount)", "")
                    Case 8
                        'dtCopy(setupfixedasset.ds.Tables("fixed_asset"), ds.Tables("fixed_asset"))
                        'If setupfixedasset.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("fixed_asset"), setupfixedasset.ds.Tables("fixed_asset"))
                        'End If
                        '    debit = ds.Tables("fixed_asset").Compute("Sum(amount)", "")
                End Select
            End If
            If Val(txtcredit.Text.Replace(",", "")) <> 0 Then
                Select Case v
                    Case 2
                        'If dnref Then
                        '    dtCopy(offsetar.ds.Tables("ar"), ds.Tables("ar"))
                        '    If offsetar.ShowDialog() = DialogResult.OK Then
                        '        dtCopy(ds.Tables("ar"), offsetar.ds.Tables("ar"))
                        '    End If
                        '        credit = ds.Tables("ar").Compute("Sum(credit)", "")
                        'End If
                    Case 4
                        dtCopy(setupewt.ds.Tables("ewt"), ds.Tables("ewt"))
                        setupewt.txtjbooksid.Text = txtjbooksidtmp.Text
                        If setupewt.ShowDialog() = DialogResult.OK Then
                            dtCopy(ds.Tables("ewt"), setupewt.ds.Tables("ewt"))
                            credit = ds.Tables("ewt").Compute("Sum(tax_amount)", "")
                        End If
                    Case 5
                        'dtCopy(offsetinputvat.ds.Tables("input_vat"), ds.Tables("input_vat"))
                        'If offsetinputvat.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("input_vat"), offsetinputvat.ds.Tables("input_vat"))
                        'End If
                        '    credit = ds.Tables("input_vat").Compute("Sum(vat_amount)", "")
                    Case 6
                        'dtCopy(setupoutputvat.ds.Tables("output_vat"), ds.Tables("output_vat"))
                        'If setupoutputvat.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("output_vat"), setupoutputvat.ds.Tables("output_vat"))
                        'End If
                        '    credit = ds.Tables("output_vat").Compute("Sum(vat_amount)", "")
                    Case 7
                        'dtCopy(offsetprepaid.ds.Tables("prepaid"), ds.Tables("prepaid"))
                        'If offsetprepaid.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("prepaid"), offsetprepaid.ds.Tables("prepaid"))
                        'End If
                        '    credit = ds.Tables("prepaid").Compute("Sum(amount)", "")
                    Case 8
                        'dtCopy(offsetfixedasset.ds.Tables("fixed_asset"), ds.Tables("fixed_asset"))
                        'If offsetfixedasset.ShowDialog() = DialogResult.OK Then
                        '    dtCopy(ds.Tables("fixed_asset"), offsetfixedasset.ds.Tables("fixed_asset"))
                        'End If
                        '    credit = ds.Tables("fixed_asset").Compute("Sum(amount)", "")
                End Select
            End If
            If "2345678".IndexOf(v.ToString) >= 0 Then
                txtdebit.Text = debit
                txtcredit.Text = credit
                Me.Visible = True
            End If
        End If

    End Sub

    'Private Sub ValidateEntry()
    '    '1 - Bank / Cash
    '    '2 - AR (debit)
    '    '3 - AP (credit)
    '    '4 - EWT (credit)
    '    '5 - Input VAT (debit)
    '    '6 - Output VAT (credit)
    '    '7 - Prepayment (debit)
    '    '8 - Fixed Asset (debit)
    '    '9 - Gain or Loss

    '    If Not txtaccount.RowData Is Nothing Then
    '        Dim v As Integer = txtaccount.RowData("validation")
    '        If "2345678".IndexOf(v.ToString) >= 0 Then
    '            Me.Visible = False
    '        End If
    '        Dim s As String = ""
    '        If Val(txtdebit.Text.Replace(",", "")) <> 0 Then s = "debit"
    '        If Val(txtcredit.Text.Replace(",", "")) <> 0 Then s = "credit"
    '        Dim frm As String = GetValidation(v, s)
    '        Dim vdt As String = frm.Replace("offset", "").Replace("setup", "")

    '        Dim objType As Type = Type.[GetType]("accounting." & frm)
    '        Dim objForm As Form = DirectCast(Activator.CreateInstance(objType), Form)

    '        'dtCopy(vds.Tables("ewtsave"), ds.Tables("ewt"))
    '        'Dim debit As Decimal = 0.0
    '        'If setupewt.ShowDialog() = DialogResult.OK Then
    '        '    dtCopy(ds.Tables("ewt"), setupewt.ds.Tables("ewtsave"))
    '        '    debit = ds.Tables("ewt").Compute("Sum(tax_amount)", "")
    '        'End If

    '        If "2345678".IndexOf(validate.ToString) >= 0 Then
    '            Me.Visible = True
    '        End If
    '    End If
    'End Sub

    Private Sub transap_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Top = (Me.Parent.Height - Me.Height) / 2
        Me.Left = (Me.Parent.Width - Me.Width) / 2
        refresh_record()
    End Sub

    Private Sub transap_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.Top = (Me.Parent.Height - Me.Height) / 2
        Me.Left = (Me.Parent.Width - Me.Width) / 2
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        transmode = "edit"
        enable_control()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0
        If transmodedet = "insert" Then
            dr = ds.Tables("jbooks").NewRow
            dr("jbooks_id") = ""
            dr("jbooks_id_tmp") = txtjbooksidtmp.Text
        Else
            sel = dgjbooks.SelectedRows(0).Index
            dr = ds.Tables("jbooks").Rows(sel)
        End If
        dr("line_remarks") = txtlineremarks.Text
        dr("project_id") = txtproject.Value
        Dim proj_code As String = ""
        If Not txtproject.RowData Is Nothing Then proj_code = txtproject.RowData("project_code")
        dr("project_code") = proj_code
        dr("project_name") = txtproject.Text
        dr("department_id") = txtdepartment.Value
        Dim dept_code As String = ""
        If Not txtdepartment.RowData Is Nothing Then dept_code = txtdepartment.RowData("department_code")
        dr("department_code") = dept_code
        dr("department_name") = txtdepartment.Text
        dr("account_id") = txtaccount.Value
        dr("account_code") = txtaccount.Text
        dr("account_name") = txtaccountname.Text
        dr("debit") = txtdebit.DecimalValue
        dr("credit") = txtcredit.DecimalValue
        dr("debit_based") = txtdebitbased.DecimalValue
        dr("credit_based") = txtcreditbased.DecimalValue
        dr("general_id") = txtgeneraldet.Value
        dr("general_code") = txtgeneraldet.Text
        dr("general_name") = txtgeneraldetname.Text
        dr("ref_jbooks_id") = txtdnref.Value
        dr("ref_trans_no") = txtdnref.Text
        dr("ref_book_id") = txtdnrefbookcode.Value
        dr("ref_book_code") = txtdnrefbookcode.Text
        dr("ref_journal_id") = txtdnrefjournalcode.Value
        dr("ref_journal_code") = txtdnrefjournalcode.Text
        Dim v As Integer = txtaccount.RowData("validation")
        dr("validation") = v
        dr("dc") = IIf(txtdebit.DecimalValue <> 0, 1, 2)

        If transmodedet = "insert" Then
            ds.Tables("jbooks").Rows.Add(dr)
        End If

        Dim dtot As Decimal = ds.Tables("jbooks").Compute("sum(debit)", "")
        Dim ctot As Decimal = ds.Tables("jbooks").Compute("sum(credit)", "")
        Dim diff As Decimal = dtot - ctot
        lbldebittotal.Text = Format(dtot, txtdebit.NumberFormat)
        lblcredittotal.Text = Format(ctot, txtcredit.NumberFormat)
        lbldifftotal.Text = Format(diff, txtdebit.NumberFormat)

        Dim dbtot As Decimal = ds.Tables("jbooks").Compute("sum(debit_based)", "")
        Dim cbtot As Decimal = ds.Tables("jbooks").Compute("sum(credit_based)", "")
        Dim diffb As Decimal = dbtot - cbtot
        lbldebitbasedtotal.Text = Format(dbtot, txtdebitbased.NumberFormat)
        lblcreditbasedtotal.Text = Format(cbtot, txtcreditbased.NumberFormat)
        lbldiffbasedtotal.Text = Format(diffb, txtdebitbased.NumberFormat)

        If v = 3 Then
            txtamount.DecimalValue = ds.Tables("jbooks").Compute("sum(credit)", "validation = 3")
            txtamountbased.DecimalValue = txtamount.DecimalValue * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
            txtamountwords.Text = amount_words(txtamount.DecimalValue)
        End If

        disable_control_det()
        btnInsert.Focus()
        transmodedet = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txttransno.Text = "" Then
            MsgBox("Cannot save transaction. Transaction No. is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If txtgeneral.Text = "" Then
            MsgBox("Cannot save transaction. Supplier is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If txtcurrency.Text = "" Then
            MsgBox("Cannot save transaction. Currency is required.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If txtexchangerate.DecimalValue = 0 Then
            MsgBox("Cannot save transaction. Exchange Rate must not be zero.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If txtbasedrate.DecimalValue = 0 Then
            MsgBox("Cannot save transaction. Based Rate must not be zero.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If ds.Tables("jbooks").Rows.Count = 0 Then
            MsgBox("Cannot save transaction. No details in transaction.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If
        If Val(lbldifftotal.Text.Replace(",", "")) <> 0 Then
            MsgBox("Cannot save transaction. Debit and Credit is not balance.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Record")
            Exit Sub
        End If

        'header
        Dim qry As String = ""
        Dim fields As New Dictionary(Of String, String)
        fields.Add("trans_id", txttransid.Text)
        fields.Add("trans_no", txttransno.Text)
        fields.Add("trans_date", txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "-" & txtday.Text.PadLeft(2, "0"))
        fields.Add("book_id", book_id)
        fields.Add("journal_id", journal_id)
        fields.Add("general_id", txtgeneral.Value)
        fields.Add("currency_id", txtcurrency.Value)
        fields.Add("exchange_rate", txtexchangerate.Value)
        fields.Add("based_rate", txtbasedrate.Value)
        fields.Add("amount", txtamount.Value)
        fields.Add("amount_based", txtamountbased.Value)
        fields.Add("description", txtdesc.Text)
        If transmode = "add" Then
            qry = genInsert("trans_header", fields)
        Else
            qry = genUpdate("trans_header", fields)
        End If

        Dim dt As DataTable = Query(qry)

        Dim trans_id As String = ""
        If transmode = "add" Then
            qry = "select trans_id from trans_header where trans_no = '" & txttransno.Text & "' and book_id = " & book_id & " and journal_id = " & journal_id
            dt = Query(qry)
            trans_id = dt.Rows(0)("trans_id")
        Else
            trans_id = txttransid.Text
        End If

        'ap
        If Not txtsino.Text = "" Or Not txtrrno.Text = "" Or Not txtpono.Text = "" Then
            qry = ""
            fields = New Dictionary(Of String, String)
            fields.Add("trans_ap_id", txttransapid.Text)
            fields.Add("trans_id", trans_id)
            fields.Add("si_no", txtsino.Text)
            fields.Add("rr_no", txtrrno.Text)
            fields.Add("po_no", txtpono.Text)
            If transmode = "add" Then
                qry = genInsert("trans_header_ap", fields)
            Else
                qry = genUpdate("trans_header_ap", fields)
            End If
            dt = Query(qry)
        End If

        'jbooks
        qry = ""
        Dim jbooks_ids As New Dictionary(Of String, String)
        For i = 0 To ds.Tables("jbooks").Rows.Count - 1
            Dim dr As DataRow = ds.Tables("jbooks").Rows(i)

            fields = New Dictionary(Of String, String)
            fields.Add("jbooks_id", dr("jbooks_id"))
            Dim jbookstransid As String = IIf(dr("trans_id") = "", trans_id, dr("trans_id"))
            'If dr("trans_id") = "" Then
            '    jbookstransid = trans_id
            'Else
            '    jbookstransid = dr("trans_id")
            'End If
            fields.Add("trans_id", jbookstransid)
            Dim projectid As String = IIf(dr("project_id") = "", Nothing, dr("project_id"))
            fields.Add("project_id", projectid)
            Dim departmentid As String = IIf(dr("department_id") = "", Nothing, dr("department_id"))
            fields.Add("department_id", departmentid)
            Dim allocationid As String = IIf(dr("allocation_id") = "", Nothing, dr("allocation_id"))
            fields.Add("allocation_id", allocationid)
            fields.Add("account_id", dr("account_id"))
            fields.Add("line_remarks", dr("line_remarks"))
            fields.Add("debit", dr("debit"))
            fields.Add("credit", dr("credit"))
            Dim debit_based As Decimal = 0
            Dim credit_based As Decimal = 0
            If dr("ref_jbooks_id") = "" Then
                debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
            Else
                debit_based = dr("debit_based")
                credit_based = dr("credit_based")
            End If
            fields.Add("debit_based", debit_based)
            fields.Add("credit_based", credit_based)
            Dim generalid As String = IIf(dr("general_id") = "", Nothing, dr("general_id"))
            fields.Add("general_id", generalid)
            Dim refjbooksid As String = IIf(dr("ref_jbooks_id") = "", Nothing, dr("ref_jbooks_id"))
            fields.Add("ref_jbooks_id", refjbooksid)
            If dr("jbooks_id") = "" Then
                qry = genInsert("trans_jbooks", fields)
            Else
                qry = genUpdate("trans_jbooks", fields)
            End If

            dt = Query(qry)
            Dim jbooks_id As String = ""
            If dr("jbooks_id") = "" Then
                qry = "select jbooks_id from trans_jbooks where trans_id = " & trans_id & _
                    " and project_id " & IIf(dr("project_id") = "", "is null", "= " & dr("project_id")) & _
                    " and department_id " & IIf(dr("department_id") = "", "is null", "= " & dr("department_id")) & _
                    " and account_id = " & dr("account_id") & _
                    " and ref_jbooks_id " & IIf(dr("ref_jbooks_id") = "", "is null", "= " & dr("ref_jbooks_id"))
                dt = Query(qry)
                jbooks_id = dt.Rows(0)("jbooks_id")
            Else
                jbooks_id = dr("jbooks_id")
            End If
            jbooks_ids.Add(dr("jbooks_id_tmp"), jbooks_id)
        Next

        'ewt
        If ds.Tables("ewt").Rows.Count > 0 Then
            qry = ""
            For i = 0 To ds.Tables("ewt").Rows.Count - 1
                Dim dr As DataRow = ds.Tables("ewt").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("ewt_id", dr("ewt_id"))
                'Dim jbooksid As String = IIf(dr("jbooks_id") = "", jbooks_ids(dr("jbooks_id")), dr("jbooks_id"))
                'If dr("jbooks_id") = "" Then
                '    jbooksid = jbooks_ids(dr("jbooks_id_tmp"))
                'Else
                '    jbooksid = dr("jbooks_id")
                'End If
                'fields.Add("jbooks_id", jbooksid)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("fs_ewt_id", dr("fs_ewt_id"))
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("tax_rate", dr("tax_rate").ToString)
                fields.Add("amount", dr("amount").ToString)
                fields.Add("tax_amount", dr("tax_amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                Dim amount_based As Decimal = 0
                Dim tax_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_ewt_id") = "" Then
                    amount_based = dr("amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    tax_amount_based = dr("tax_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    amount_based = dr("amount_based")
                    tax_amount_based = dr("tax_amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("tax_amount_based", tax_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                Dim refewtid As String = IIf(dr("ref_ewt_id") = "", Nothing, dr("ref_ewt_id"))
                fields.Add("ref_ewt_id", refewtid)
                If dr("ewt_id") = "" Then
                    qry = genInsert("trans_ewt", fields)
                Else
                    qry = genUpdate("trans_ewt", fields)
                End If
                dt = Query(qry)
            Next
        End If

        'checks
        If ds.Tables("checks").Rows.Count > 0 Then
            qry = ""
            For i = 0 To ds.Tables("checks").Rows.Count - 1
                Dim dr As DataRow = ds.Tables("checks").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("check_id", dr("check_id"))
                'Dim jbooksid As String = ""
                'If dr("jbooks_id") = "" Then
                '    jbooksid = jbooks_ids(dr("jbooks_id_tmp"))
                'Else
                '    jbooksid = dr("jbooks_id")
                'End If
                'fields.Add("jbooks_id", jbooksid)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("check_no", dr("check_no"))
                fields.Add("check_date", Format(dr("check_date"), "yyyy-mm-dd"))
                fields.Add("check_amount", dr("check_amount").ToString)
                Dim check_amount_based As Decimal = 0
                If dr("ref_check_id") = "" Then
                    check_amount_based = dr("check_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    check_amount_based = dr("check_amount_based")
                End If
                fields.Add("check_amount_based", check_amount_based.ToString)
                fields.Add("bank_id", dr("bank_id"))
                fields.Add("cleared", IIf(dr("cleared"), "1", "0"))
                fields.Add("released", IIf(dr("released"), "1", "0"))
                fields.Add("cancelled", IIf(dr("cancelled"), "1", "0"))
                fields.Add("crossed", IIf(dr("crossed"), "1", "0"))
                fields.Add("replacement_check_no", dr("replacement_check_no"))
                fields.Add("cleared_date", Format(dr("cleared_date"), "yyyy-mm-dd"))
                fields.Add("deposit_date", Format(dr("deposit_date"), "yyyy-mm-dd"))
                fields.Add("cancel_date", Format(dr("cancel_date"), "yyyy-mm-dd"))
                fields.Add("replaced", IIf(dr("replaced"), "1", "0"))

                If dr("check_id") = "" Then
                    qry = genInsert("trans_checks", fields)
                Else
                    qry = genUpdate("trans_checks", fields)
                End If
                dt = Query(qry)
            Next
        End If

        'fixed asset
        If ds.Tables("fixed_asset").Rows.Count > 0 Then
            qry = ""
            For i = 0 To ds.Tables("fixed_asset").Rows.Count - 1
                Dim dr As DataRow = ds.Tables("fixed_asset").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("fixed_asset_id", dr("fixed_asset_id"))
                'Dim jbooksid As String = ""
                'If dr("jbooks_id") = "" Then
                '    jbooksid = jbooks_ids(dr("jbooks_id_tmp"))
                'Else
                '    jbooksid = dr("jbooks_id")
                'End If
                'fields.Add("jbooks_id", jbooksid)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("description", dr("description"))
                fields.Add("asset_code", dr("asset_code"))
                fields.Add("historical_rate", dr("historical_rate").ToString)
                fields.Add("quantity", dr("quantity").ToString)
                fields.Add("date_acquired", Format(dr("date_acquired"), "yyyy-mm-dd"))
                fields.Add("amount", dr("amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                Dim amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_fixed_asset_id") = "" Then
                    amount_based = dr("amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    amount_based = dr("amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("useful_life", dr("useful_life").ToString)
                fields.Add("date_start", Format(dr("date_start"), "yyyy-mm-dd"))
                fields.Add("ref_fixed_asset_id", dr("ref_fixed_asset_id"))
                If dr("fixed_asset_id") = "" Then
                    qry = genInsert("trans_fixed_asset", fields)
                Else
                    qry = genUpdate("trans_fixed_asset", fields)
                End If
                dt = Query(qry)
            Next
        End If

        'input vat
        If ds.Tables("input_vat").Rows.Count > 0 Then
            qry = ""
            For i = 0 To ds.Tables("input_vat").Rows.Count - 1
                Dim dr As DataRow = ds.Tables("input_vat").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("input_vat_id", dr("input_vat_id"))
                'Dim jbooksid As String = ""
                'If dr("jbooks_id") = "" Then
                '    jbooksid = jbooks_ids(dr("jbooks_id_tmp"))
                'Else
                '    jbooksid = dr("jbooks_id")
                'End If
                'fields.Add("jbooks_id", jbooksid)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("vat_class", dr("vat_class").ToString)
                fields.Add("vat_type", dr("vat_type").ToString)
                fields.Add("vat_rate", dr("vat_rate").ToString)
                fields.Add("gross_amount", dr("gross_amount").ToString)
                fields.Add("vat_amount", dr("vat_amount").ToString)
                fields.Add("net_amount", dr("net_amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                Dim gross_amount_based As Decimal = 0
                Dim vat_amount_based As Decimal = 0
                Dim net_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_input_vat_id") = "" Then
                    gross_amount_based = dr("gross_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    vat_amount_based = dr("vat_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    net_amount_based = dr("net_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    gross_amount_based = dr("gross_amount_based")
                    vat_amount_based = dr("vat_amount_based")
                    net_amount_based = dr("net_amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("gross_amount_based", gross_amount_based.ToString)
                fields.Add("vat_amount_based", vat_amount_based.ToString)
                fields.Add("net_amount_based", net_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("ref_input_vat_id", dr("ref_input_vat_id"))
                If dr("input_vat_id") = "" Then
                    qry = genInsert("trans_input_vat", fields)
                Else
                    qry = genUpdate("trans_input_vat", fields)
                End If
                dt = Query(qry)
            Next
        End If

        'output vat
        If ds.Tables("output_vat").Rows.Count > 0 Then
            qry = ""
            For i = 0 To ds.Tables("output_vat").Rows.Count - 1
                Dim dr As DataRow = ds.Tables("output_vat").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("output_vat_id", dr("output_vat_id"))
                'Dim jbooksid As String = ""
                'If dr("jbooks_id") = "" Then
                '    jbooksid = jbooks_ids(dr("jbooks_id_tmp"))
                'Else
                '    jbooksid = dr("jbooks_id")
                'End If
                'fields.Add("jbooks_id", jbooksid)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("general_id", dr("general_id"))
                fields.Add("offset_type", dr("offset_type").ToString)
                fields.Add("vat_class", dr("vat_class").ToString)
                fields.Add("vat_type", dr("vat_type").ToString)
                fields.Add("vat_rate", dr("vat_rate").ToString)
                fields.Add("gross_amount", dr("gross_amount").ToString)
                fields.Add("vat_amount", dr("vat_amount").ToString)
                fields.Add("net_amount", dr("net_amount").ToString)
                fields.Add("debit", dr("debit"))
                fields.Add("credit", dr("credit"))
                Dim gross_amount_based As Decimal = 0
                Dim vat_amount_based As Decimal = 0
                Dim net_amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_output_vat_id") = "" Then
                    gross_amount_based = dr("gross_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    vat_amount_based = dr("vat_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    net_amount_based = dr("net_amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    gross_amount_based = dr("gross_amount_based")
                    vat_amount_based = dr("vat_amount_based")
                    net_amount_based = dr("net_amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("gross_amount_based", gross_amount_based.ToString)
                fields.Add("vat_amount_based", vat_amount_based.ToString)
                fields.Add("net_amount_based", net_amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("ref_output_vat_id", dr("ref_output_vat_id"))
                If dr("output_vat_id") = "" Then
                    qry = genInsert("trans_output_vat", fields)
                Else
                    qry = genUpdate("trans_output_vat", fields)
                End If
                dt = Query(qry)
            Next
        End If

        'prepaid
        If ds.Tables("prepaid").Rows.Count > 0 Then
            qry = ""
            For i = 0 To ds.Tables("prepaid").Rows.Count - 1
                Dim dr As DataRow = ds.Tables("prepaid").Rows(i)
                fields = New Dictionary(Of String, String)
                fields.Add("prepaid_id", dr("prepaid_id"))
                'Dim jbooksid As String = ""
                'If dr("jbooks_id") = "" Then
                '    jbooksid = jbooks_ids(dr("jbooks_id_tmp"))
                'Else
                '    jbooksid = dr("jbooks_id")
                'End If
                'fields.Add("jbooks_id", jbooksid)
                fields.Add("jbooks_id", jbooks_ids(dr("jbooks_id")))
                fields.Add("description", dr("description"))
                fields.Add("date_acquired", Format(dr("date_acquired"), "yyyy-mm-dd"))
                fields.Add("amount", dr("amount").ToString)
                fields.Add("debit", dr("debit").ToString)
                fields.Add("credit", dr("credit").ToString)
                Dim amount_based As Decimal = 0
                Dim debit_based As Decimal = 0
                Dim credit_based As Decimal = 0
                If dr("ref_prepaid_id") = "" Then
                    amount_based = dr("amount") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    debit_based = dr("debit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                    credit_based = dr("credit") * (txtexchangerate.DecimalValue / txtbasedrate.DecimalValue)
                Else
                    amount_based = dr("amount_based")
                    debit_based = dr("debit_based")
                    credit_based = dr("credit_based")
                End If
                fields.Add("amount_based", amount_based.ToString)
                fields.Add("debit_based", debit_based.ToString)
                fields.Add("credit_based", credit_based.ToString)
                fields.Add("useful_life", dr("useful_life").ToString)
                fields.Add("date_start", Format(dr("date_start"), "yyyy-mm-dd"))
                fields.Add("ref_prepaid_id", dr("ref_prepaid_id"))
                If dr("prepaid_id") = "" Then
                    qry = genInsert("trans_prepaid", fields)
                Else
                    qry = genUpdate("trans_prepaid", fields)
                End If
                dt = Query(qry)
            Next
        End If

        disable_control()
        refresh_record()
        transmode = ""
        transmodedet = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        transmodedet = "update"
        enable_control_det()
    End Sub

    Private Sub refresh_record()
        Dim dt As DataTable = Query("select a.* " & _
            ",ifnull(b.trans_ap_id,'') as trans_ap_id,ifnull(b.si_no,'') as si_no,ifnull(b.rr_no,'') as rr_no,ifnull(b.po_no,'') as po_no " & _
            ",c.general_code,c.general_name " & _
            ",d.currency_code,d.currency_name " & _
            "from trans_header a " & _
            "left join trans_header_ap b on a.trans_id = b.trans_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_general c on a.general_id = c.general_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_currency d on a.currency_id = d.currency_id " & _
            "where month(a.trans_date) = " & txtmonth.Value & " " & _
            "and year(a.trans_date) = " & txtyear.Value)

        ds.Tables("trans").Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("trans").NewRow
            For j = 0 To dt.Columns.Count - 1
                dr(dt.Columns(j).ColumnName) = dt.Rows(i)(dt.Columns(j).ColumnName)
            Next
            ds.Tables("trans").Rows.Add(dr)
        Next
    End Sub

    Private Sub refresh_record_det()
        Dim dt As DataTable = Query("select a.*,if(a.debit!=0,1,2) as dc " & _
            ",b.project_code,b.project_name " & _
            ",c.department_code,c.department_name " & _
            ",d.allocation_code,d.allocation_name " & _
            ",e.account_code,e.account_name,e.validation " & _
            ",f.general_code,f.general_name " & _
            ",z2.trans_no as ref_trans_no,z2.book_id as ref_book_id,z2.journal_id as ref_journal_id " & _
            ",x2.book_code as ref_book_code,x2.book_name as ref_book_name " & _
            ",y2.journal_code as ref_journal_code,y2.journal_name as ref_journal_name " & _
            "from trans_jbooks a " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_project b on a.project_id = b.project_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_department c on a.department_id = c.department_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_allocation d on a.allocation_id = d.allocation_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_chart e on a.account_id = e.account_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_general f on a.general_id = f.general_id " & _
            "left join trans_jbooks a2 on a.ref_jbooks_id = a2.jbooks_id " & _
            "left join trans_header z2 on a2.trans_id = z2.trans_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_book x2 on z2.book_id = x2.book_id " & _
            "left join " & connectionlib.connectionlib._serverDBFS & ".lib_erp_journal y2 on z2.journal_id = y2.journal_id " & _
            "where a.trans_id = " & txttransid.Text & " " & _
            "order by dc,e.account_code")

        ds.Tables("jbooks").Clear()
        ds.Tables("checks").Clear()
        ds.Tables("ewt").Clear()
        ds.Tables("input_vat").Clear()
        ds.Tables("output_vat").Clear()
        ds.Tables("fixed_asset").Clear()
        ds.Tables("prepaid").Clear()

        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("jbooks").NewRow
            For j = 0 To dt.Columns.Count - 1
                dr(dt.Columns(j).ColumnName) = IIf(IsDBNull(dt.Rows(i)(dt.Columns(j).ColumnName)), "", dt.Rows(i)(dt.Columns(j).ColumnName))
            Next
            ds.Tables("jbooks").Rows.Add(dr)
        Next
    End Sub

    Private Sub bind_control()
        If dgTrans.RowCount = 0 Then
            Exit Sub
        End If
        If dgTrans.SelectedRows.Count = 0 Then
            clear_control()
            Exit Sub
        End If
        Dim sel As Integer = dgTrans.SelectedRows(0).Index
        Dim dr As DataRow = ds.Tables("trans").Rows(sel)

        txttransid.Text = dr("trans_id")
        txttransapid.Text = dr("trans_ap_id")
        txttransno.Text = dr("trans_no")
        txtday.Text = Format(dr("trans_date"), "dd")
        txtsino.Text = dr("si_no")
        txtrrno.Text = dr("rr_no")
        txtpono.Text = dr("po_no")
        txtgeneral.Value = dr("general_id")
        txtgeneral.Text = dr("general_code")
        txtgeneralname.Text = dr("general_name")
        txtcurrency.Value = dr("currency_id")
        txtcurrency.Text = dr("currency_name")
        txtexchangerate.DecimalValue = dr("exchange_rate")
        txtbasedrate.DecimalValue = dr("based_rate")
        txtamount.DecimalValue = dr("amount")
        txtamountbased.DecimalValue = dr("amount_based")
        txtamountwords.Text = amount_words(dr("amount"))
        txtdesc.Text = dr("description")

        refresh_record_det()
    End Sub

    Private Sub bind_control_det()
        If dgjbooks.RowCount = 0 Then
            Exit Sub
        End If
        If dgjbooks.SelectedRows.Count = 0 Then
            clear_control_det()
            Exit Sub
        End If
        Dim sel As Integer = dgjbooks.SelectedRows(0).Index
        Dim dr As DataRow = ds.Tables("jbooks").Rows(sel)

        txtlineremarks.Text = dr("line_remarks")
        txtproject.Value = dr("project_id")
        txtproject.Text = dr("project_name")
        txtdepartment.Value = dr("department_id")
        txtdepartment.Text = dr("department_name")
        txtallocation.Value = dr("allocation_id")
        txtallocation.Text = dr("allocation_name")
        txtaccount.Value = dr("account_id")
        txtaccount.Text = dr("account_code")
        txtaccountname.Text = dr("account_name")
        txtdebit.DecimalValue = dr("debit")
        txtcredit.DecimalValue = dr("credit")
        txtdebitbased.DecimalValue = dr("debit_based")
        txtcreditbased.DecimalValue = dr("credit_based")
        txtgeneraldet.Value = dr("general_id")
        txtgeneraldet.Text = dr("general_code")
        txtgeneraldetname.Text = dr("general_name")
        txtdnref.Value = dr("ref_jbooks_id")
        txtdnref.Text = dr("ref_trans_no")
        txtdnrefbookcode.Text = dr("ref_book_code")
        txtdnrefjournalcode.Text = dr("ref_journal_code")
    End Sub

    Private Sub dgTrans_SelectionChanged(sender As Object, e As EventArgs) Handles dgTrans.SelectionChanged
        bind_control()
    End Sub

    Private Sub dgjbooks_SelectionChanged(sender As Object, e As EventArgs) Handles dgjbooks.SelectionChanged
        bind_control_det()
    End Sub
End Class