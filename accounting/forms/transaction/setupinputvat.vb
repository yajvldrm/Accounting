Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports System.Drawing
Imports Excel = Microsoft.Office.Interop.Excel

Public Class setupinputvat
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Dim directory As String = Application.StartupPath & "\templates\"
    Dim templateFile As String = "ImportInputVAT.xltx"

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
    Private Sub setupinputvat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dgdet.DataSource = ds.Tables("input_vat")

    End Sub

    Private Sub cmdNotSave_Click(sender As Object, e As EventArgs) Handles btnnotsave.Click
        DisableControlDet(Me)
        Me.Hide()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.DialogResult = DialogResult.OK
        DisableControlDet(Me)
        Me.Close()
    End Sub
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
        btnhdr2.Visible = False
        setRdoValue(radvattype, 1)
        txtgrossamount.Enabled = True
        txtgeneral.Value = generalID
        txtgeneral.Text = generalCode
        txtgeneralname.Text = generalName
        txtgeneral.Focus()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim dt As DataTable = ds.Tables("input_vat")
        Dim dr As DataRow = Nothing
        Dim sel As Integer = 0

        Dim selectedRows = dgdet.SelectedRows

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
            dr = ds.Tables("input_vat").Rows(sel)
        End If

        If getRdoValue(radvatclass) = "" Then
            MsgBox("Select Vat Input Type")
            Exit Sub
        End If
        dr("sel") = False
        dr("jbooks_id") = jbooks_id
        dr("general_id") = txtgeneral.Value
        dr("general_code") = txtgeneral.Text
        dr("general_name") = txtgeneralname.Text
        dr("vat_class") = getRdoValue(radvatclass)
        dr("vat_type") = getRdoValue(radvattype)
        dr("tin") = txttin.Text
        dr("address") = txtaddress.Text
        dr("offset_type") = 0
        dr("vat_rate") = Math.Round(CDec(ifNull(txtvatrate.DecimalValue, 0)), 2)
        dr("gross_amount") = Math.Round(CDec(ifNull(txtgrossamount.EditValue, 0)), 2)
        dr("vat_amount") = Math.Round(CDec(ifNull(txtvatamount.EditValue, 0)), 2)
        dr("net_amount") = Math.Round(CDec(ifNull(txtnetamount.EditValue, 0)), 2)
        dr("debit") = Math.Round(CDec(ifNull(txtvatamount.EditValue, 0)), 2)
        dr("credit") = 0.0
        dr("currency_id") = currency_id
        dr("exchange_rate") = exchange_rate
        dr("based_rate") = based_rate
        dr("gross_amount_based") = Math.Round(CDec(ifNull(txtgrossamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("vat_amount_based") = Math.Round(CDec(ifNull(txtvatamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("net_amount_based") = Math.Round(CDec(ifNull(txtnetamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("debit_based") = Math.Round(CDec(ifNull(txtvatamount.EditValue * (exchange_rate / based_rate), 0)), 2)
        dr("credit_amount_based") = 0.0

        If transmode = "insert" Then
            ds.Tables("input_vat").Rows.Add(dr)
        End If

        transmode = ""

        DisableControlDet(Me)
        btninsert.Focus()
        btnhdr2.Visible = True
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
        If dgdet.Rows.Count > 0 Then
            dgdet.ClearSelection()
            dgdet.Rows(0).Selected = True
        End If
    End Sub

    Private Sub dgdet_SelectionChanged(sender As Object, e As EventArgs) Handles dgdet.SelectionChanged
        If dgdet.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        BindControlDet(Me, ds.Tables("input_vat").Rows(dgdet.SelectedRows(0).Index))
    End Sub

    Private Sub txtgeneral_Leave(sender As Object, e As EventArgs) Handles txtgeneral.Leave
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

    End Sub

    Private Sub txtgrossamount_Leave(sender As Object, e As EventArgs) Handles txtgrossamount.Leave
        compute_vat()
    End Sub

    Private Sub compute_vat()
        If getRdoValue(radvattype) = "1" Then
            txtvatamount.EditValue = Math.Round((txtgrossamount.EditValue / (1 + (txtvatrate.DecimalValue / 100))) * (txtvatrate.DecimalValue / 100), 2)
            txtnetamount.EditValue = Math.Round(txtgrossamount.EditValue - txtvatamount.EditValue, 2)
        Else
            txtvatamount.EditValue = Math.Round(txtnetamount.EditValue * (txtvatrate.DecimalValue / 100), 2)
            txtgrossamount.EditValue = Math.Round(txtnetamount.EditValue + txtvatamount.EditValue, 2)
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

    Private Sub setupinputvat_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        btninsert.Focus()
        loadDTToDG(dgdet, ds.Tables("input_vat"))
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim arr_id = getCheckedGrid("input_vat_id", "general_code", "sel", dgdet, "", False, , False)
        If arr_id.Length > 0 Then
            For Each row As DataRow In ds.Tables("input_vat").Rows
                If arr_id.Contains(row.Item("input_vat_id").ToString) Then
                    row.Item("deleted") = True
                End If
            Next
            loadDTToDG(dgdet, ds.Tables("input_vat"))
        End If
    End Sub

    Private Sub setupinputvat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
    Private Sub Import()
        Try
            Dim openfile As New OpenFileDialog
            openfile.Filter = "Excel Files|*.xlsx"
            Dim path As String = openfile.FileName()
            If openfile.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Try
            Else
                path = openfile.FileName()
                If path <> "" Then
                    Try
                        'showForm(ImportChartOfAccountStatus, main)
                        'ImportChartOfAccountStatus.btnClose.Visible = False
                        'ImportChartOfAccountStatus.btnClose.Enabled = False
                        'setStatus("Initializing Importation ...")
                        xlApp = New Excel.Application
                        xlWorkBook = xlApp.Workbooks.Open(path)
                        xlWorkSheet = xlWorkBook.Worksheets(1)
                        'setStatus("Get List of Chart Class")
                        Dim sql_general As String = "SELECT general_id,general_code,general_name,tin,address1 AS address
                            FROM lib_erp_general"
                        Dim dt_general As DataTable = FsQuery(sql_general)
                        'setStatus("Get List of Chart Group")
                        Dim listError As New List(Of String)
                        Dim listWarning As New List(Of String)
                        Dim hasError As Boolean = False

                        For i As Integer = 3 To xlWorkSheet.Rows.Count - 1
                            Dim sel As Boolean = False
                            Dim general_id As String = ""
                            Dim general_code As String = ""
                            Dim general_name As String = ""
                            Dim vat_class As String = ""
                            Dim vat_type As String = ""
                            Dim tin As String = ""
                            Dim address As String = ""
                            Dim offset_type As String = "0"
                            Dim vat_rate As Decimal = txtvatrate.DecimalValue
                            Dim gross_amount As Decimal = 0
                            Dim vat_amount As Decimal = 0
                            Dim net_amount As Decimal = 0
                            Dim debit As Decimal = 0
                            Dim credit As Decimal = 0
                            Dim gross_amount_based As Decimal = 0
                            Dim vat_amount_based As Decimal = 0
                            Dim net_amount_based As Decimal = 0
                            Dim debit_based As Decimal = 0
                            Dim credit_amount_based As Decimal = 0

                            Dim str_general_code As String = getCellValue(xlWorkSheet, i, 1)
                            Dim str_gross_purchase As String = getCellValue(xlWorkSheet, i, 4)
                            Dim str_net_purchase As String = getCellValue(xlWorkSheet, i, 5)
                            Dim str_vat_class As String = getCellValue(xlWorkSheet, i, 6)
                            Dim str_vat_type As String = getCellValue(xlWorkSheet, i, 7)

                            If str_general_code <> "" And (str_gross_purchase <> "" Or str_net_purchase <> "") And str_vat_class <> "" And str_vat_type <> "" Then
                                Dim drs_general() As DataRow = dt_general.Select(String.Format("general_code = '{0}'", str_general_code))
                                If drs_general.Length > 0 Then
                                    general_id = drs_general(0).Item("general_id").ToString
                                    general_code = drs_general(0).Item("general_code").ToString
                                    general_name = drs_general(0).Item("general_name").ToString
                                    tin = drs_general(0).Item("tin").ToString
                                    address = drs_general(0).Item("address").ToString
                                    vat_class = str_vat_class
                                    vat_type = str_vat_type
                                    gross_amount = CDec(str_gross_purchase.Replace(",", ""))
                                    net_amount = CDec(str_net_purchase.Replace(",", ""))
                                    If vat_type = "1" Then
                                        vat_amount = Math.Round((gross_amount / (1 + (vat_rate / 100))) * (vat_rate / 100), 2)
                                        net_amount = Math.Round(gross_amount - vat_amount, 2)
                                    Else
                                        vat_amount = Math.Round(net_amount * (vat_rate / 100), 2)
                                        gross_amount = Math.Round(net_amount + vat_amount, 2)
                                    End If
                                    debit = vat_amount
                                    debit_based = Math.Round(debit * (exchange_rate / based_rate), 2)
                                    gross_amount_based = Math.Round(gross_amount * (exchange_rate / based_rate), 2)
                                    vat_amount_based = Math.Round(vat_amount * (exchange_rate / based_rate), 2)
                                    net_amount_based = Math.Round(net_amount * (exchange_rate / based_rate), 2)

                                    Dim newDR As DataRow = ds.Tables("input_vat").NewRow
                                    newDR.Item("sel") = sel
                                    newDR.Item("input_vat_id") = GenerateRandomString() & (ds.Tables("input_vat").Rows.Count + 1)
                                    newDR.Item("jbooks_id") = jbooks_id
                                    newDR.Item("general_id") = general_id
                                    newDR.Item("general_code") = general_code
                                    newDR.Item("general_name") = general_name
                                    newDR.Item("vat_class") = vat_class
                                    newDR.Item("vat_type") = vat_type
                                    newDR.Item("tin") = tin
                                    newDR.Item("address") = address
                                    newDR.Item("offset_type") = offset_type
                                    newDR.Item("vat_rate") = vat_rate
                                    newDR.Item("gross_amount") = Math.Round(gross_amount, 2)
                                    newDR.Item("vat_amount") = Math.Round(vat_amount, 2)
                                    newDR.Item("net_amount") = Math.Round(net_amount, 2)
                                    newDR.Item("debit") = Math.Round(debit, 2)
                                    newDR.Item("credit") = Math.Round(credit, 2)
                                    newDR.Item("currency_id") = currency_id
                                    newDR.Item("exchange_rate") = exchange_rate
                                    newDR.Item("based_rate") = based_rate
                                    newDR.Item("debit_based") = Math.Round(debit_based, 2)
                                    newDR.Item("credit_amount_based") = Math.Round(credit_amount_based, 2)
                                    newDR.Item("gross_amount_based") = Math.Round(gross_amount_based, 2)
                                    newDR.Item("vat_amount_based") = Math.Round(vat_amount_based, 2)
                                    newDR.Item("net_amount_based") = Math.Round(net_amount_based, 2)
                                    ds.Tables("input_vat").Rows.Add(newDR)
                                Else
                                    MyDebugging.AddText("No General Found. Continue to next line")
                                    Continue For
                                End If
                            Else
                                MyDebugging.AddText("Some of fields are empty. Consider as end of file.")
                                Exit For
                            End If
                        Next
                        'setStatus("------------------------------------------------------------------------------------------------------------------------------------------------------" &
                        'vbNewLine & "Run The Query")
                    Catch ex As Exception
                        MyDebugging.AddText(ex.Message)
                    End Try
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub
    Private Function getCellValue(ByVal xlWorkSheet As Excel.Worksheet, ByVal r As Integer, ByVal c As Integer) As String
        Return CType(xlWorkSheet.Cells(r, c), Excel.Range).Text.ToString.Trim.Replace("'", "''")
    End Function
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub ExportTemplate()
        Try
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(directory & "/" & templateFile)
            xlApp.Visible = True
            xlWorkSheet = xlWorkBook.Worksheets(1)
        Catch ex As Exception
            MyDebugging.AddText(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportTemplate()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Import()
    End Sub
End Class