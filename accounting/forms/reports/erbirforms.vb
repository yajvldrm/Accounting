Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Imports Microsoft.Office.Interop
Imports DevExpress.Pdf

Public Class erbirforms
    Private module_code As String = "ACC01014"
    Dim templates As String = Application.StartupPath & "\templates"
    Dim withSignatory As Boolean = False
    Dim general_id As String
    Private Sub generalLeave(sender As Object, e As EventArgs) Handles txt_general_id_1.Leave, txt_general_id_9.Leave, txt_general_id_8.Leave, txt_general_id_7.Leave, txt_general_id_6.Leave, txt_general_id_5.Leave, txt_general_id_4.Leave, txt_general_id_3.Leave, txt_general_id_2.Leave, txt_general_id_10.Leave
        'Dim ctrl = CType(sender, user_control.textbox)
        'Dim targetName As String = ctrl.Name.ToString.Replace("general_id", "general_name")
        'Dim targetControl = CType(Me.Controls.Find(targetName, True)(0), user_control.textbox)
        'If ctrl.Text.ToString.Trim() = "" Then
        '    Exit Sub
        'End If
        'Dim data As DataTable = Query(String.Format("SELECT a.general_id, b.general_code, b.general_name FROM trans_ewt a left join {0}.lib_erp_general b on b.general_id = a.general_id  WHERE IFNULL(a.general_id,'') <> '' group by a.general_id", _serverDBFS))
        'If data.Rows.Count = 0 Then
        '    MsgBox("No record found.")
        '    ctrl.Text = ""
        '    ctrl.Value = ""
        'Else
        '    Dim dr As DataRow = Nothing
        '    If data.Rows.Count = 1 Then
        '        dr = data.Rows(0)
        '    Else
        '        Dim dra() As DataRow = data.Select("general_code like '" & ctrl.Text.ToString.Replace("'", "''") & "'")
        '        If dra.Count > 0 Then
        '            dr = dra(0)
        '        Else
        '            browse.dt = data
        '            browse.format("Code,Name", "general_code,general_name", "200,400")
        '            If browse.ShowDialog() = DialogResult.OK Then
        '                If browse.dgview.SelectedRows.Count > 0 Then
        '                    dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
        '                End If
        '            End If
        '        End If
        '    End If
        '    If Not dr Is Nothing Then
        '        ctrl.RowData = dr
        '        ctrl.Value = dr("general_id")
        '        ctrl.Text = dr("general_code")
        '        targetControl.Text = dr("general_name")
        '    End If
        'End If
        If rdo_per_supplier.Checked = True Then

            'Per Supplier Validation
            Dim dFrom As New Date(txt_year_from.Value, txt_month_from.Value, txt_day_from.Value)
            Dim dTo As New Date(txt_year_to.Value, txt_month_to.Value, txt_day_to.Value)
            Dim ctrl = CType(sender, user_control.textbox)
            Dim targetName As String = ctrl.Name.ToString.Replace("general_id", "general_name")
            Dim targetControl = CType(Me.Controls.Find(targetName, True)(0), user_control.textbox)
            If ctrl.Text.ToString.Trim() = "" Then
                Exit Sub
            End If
            Dim data As DataTable = Query(String.Format("SELECT a.general_id,a.general_code,a.general_name FROM {0}.lib_erp_general a inner join {0}.lib_erp_general_ewt b on a.general_id = b.general_id GROUP by a.general_id", _serverDBFS))
            If data.Rows.Count = 0 Then
                MsgBox("No record found.")
                ctrl.Text = ""
                ctrl.Value = ""
            Else
                Dim dr As DataRow = Nothing
                If data.Rows.Count = 1 Then
                    dr = data.Rows(0)
                Else
                    Dim dra() As DataRow = data.Select(" general_code like '" & ctrl.Text.ToString.Replace("'", "''") & "'")
                    If dra.Count > 0 Then
                        dr = dra(0)
                    Else
                        browse.dt = data
                        browse.format("Code,Name", "general_code,general_name", "200,400")
                        If browse.ShowDialog() = DialogResult.OK Then
                            If browse.dgview.SelectedRows.Count > 0 Then
                                dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                            End If
                        End If
                    End If
                End If
                If Not dr Is Nothing Then
                    ctrl.RowData = dr
                    ctrl.Value = dr("general_id")
                    general_id = dr("general_id")
                    ctrl.Text = dr("general_code")
                    targetControl.Text = dr("general_name")
                End If
            End If
        Else
            ''Per Transaction Validation
            Dim dFrom As New Date(txt_year_from.Value, txt_month_from.Value, txt_day_from.Value)
            Dim dTo As New Date(txt_year_to.Value, txt_month_to.Value, txt_day_to.Value)
            Dim ctrl = CType(sender, user_control.textbox)
            Dim targetName As String = ctrl.Name.ToString.Replace("general_id", "general_name")
            Dim targetControl = CType(Me.Controls.Find(targetName, True)(0), user_control.textbox)
            If ctrl.Text.ToString.Trim() = "" Then
                Exit Sub
            End If
            Dim data As DataTable = Query(String.Format("SELECT a.trans_id,a.trans_no,a.general_id,b.general_name
            FROM trans_header a
            LEFT JOIN {0}.lib_erp_general b ON b.general_id = a.general_id
            WHERE a.trans_date BETWEEN '{1}' AND '{2}' ", _serverDBFS, dFrom.ToString("yyyy-MM-dd"), dTo.ToString("yyyy-MM-dd")))
            If data.Rows.Count = 0 Then
                MsgBox("No record found.")
                ctrl.Text = ""
                ctrl.Value = ""
            Else
                Dim dr As DataRow = Nothing
                If data.Rows.Count = 1 Then
                    dr = data.Rows(0)
                Else
                    Dim dra() As DataRow = data.Select("trans_no like '" & ctrl.Text.ToString.Replace("'", "''") & "'")
                    If dra.Count > 0 Then
                        dr = dra(0)
                    Else
                        browse.dt = data
                        browse.format("Code,Name", "trans_no,general_name", "200,400")
                        If browse.ShowDialog() = DialogResult.OK Then
                            If browse.dgview.SelectedRows.Count > 0 Then
                                dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                            End If
                        End If
                    End If
                End If
                If Not dr Is Nothing Then
                    ctrl.RowData = dr
                    ctrl.Value = dr("trans_id")
                    ctrl.Text = dr("trans_no")
                    targetControl.Text = dr("general_name")
                End If
            End If
        End If
    End Sub
    Private Sub printChange(sender As Object, e As EventArgs) Handles rdo_print_1.CheckedChanged, rdo_print_5.CheckedChanged, rdo_print_4.CheckedChanged, rdo_print_3.CheckedChanged, rdo_print_2.CheckedChanged
        Dim print As String = getRdoValue(print_filter)

        panel_1601E.Visible = False
        panel_2307PT.Visible = False
        panel_date.Visible = False
        Select Case print
            Case "1"
                panel_1601E.Visible = True
                panel_date.Visible = True
            Case "2"
            Case "3"
            Case "4"
                panel_2307PT.Visible = True
            Case "5"
        End Select
    End Sub
    Private Sub searchLeave(sender As Object, e As EventArgs) Handles txt_search_by.Leave
        Dim data As DataTable = FsQuery("SELECT 'EWT' AS name,'1' AS id " & _
                                        "UNION SELECT 'NAME','2' " & _
                                        "UNION SELECT 'CODE','3' " & _
                                        "")
        If data.Rows.Count = 0 Then
            MsgBox("No record found.")
        Else
            Dim dr As DataRow = Nothing
            If data.Rows.Count = 1 Then
                dr = data.Rows(0)
            Else
                Dim dra() As DataRow = data.Select("name like '" & txt_search_by.Text & "'")
                If dra.Count > 0 Then
                    dr = dra(0)
                Else
                    browse.dt = data
                    browse.format("Name", "name", "200")
                    If browse.ShowDialog() = DialogResult.OK Then
                        If browse.dgview.SelectedRows.Count > 0 Then
                            dr = browse.dt.Rows(browse.dgview.SelectedRows(0).Index)
                        End If
                    End If
                End If
            End If
            If Not dr Is Nothing Then
                txt_search_by.RowData = dr
                txt_search_by.Value = dr("id")
                txt_search_by.Text = dr("name")
            End If
        End If
    End Sub
    Private Sub erbirforms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        printChange(Nothing, Nothing)
        Dim month As String = Today.ToString("MM")
        Dim year As String = Today.ToString("yyyy")
        txt_month.Value = month
        txt_year.Value = year
        Dim dic As New Dictionary(Of Integer, String)
        dic.Add(1, "Enero")
        dic.Add(2, "Pebrero")
        dic.Add(3, "Marso")
        dic.Add(4, "Abril")
        dic.Add(5, "Mayo")
        dic.Add(6, "Hunyo")
        dic.Add(7, "Hulyo")
        dic.Add(8, "Agusto")
        dic.Add(9, "Setyembre")
        dic.Add(10, "Oktobre")
        dic.Add(11, "Nobyembre")
        dic.Add(12, "Disyembre")
        'txt_month_from.DicItems = dic
        'txt_month_to.DicItems = dic
        For quarter As Integer = 1 To 4
            Dim max = (12 * CType(quarter, Integer)) / 4
            Dim min = max - 2
            If month >= min And month <= max Then
                setRdoValue(quarter_filter, quarter)
            End If
        Next
        txt_month_from.Value = month
        txt_month_to.Value = month
        txt_year_from.Value = year
        txt_year_to.Value = year
        QuarterChange(Nothing, Nothing)

        Dim dt = FsQuery("CALL get_lib_acc_signatory_2307")
        If TypeOf dt Is DataTable Then
            If dt.Rows.Count > 0 Then
                withSignatory = True
                Dim dr As DataRow = dt.Rows(0)
                txt_signatory_id.Text = dr.Item("signatory_2307_id").ToString()
                txt_signatory_name.Text = dr.Item("signatory_2307_name").ToString()
                txt_signatory_position.Text = dr.Item("signatory_2307_position").ToString()
                txt_signatory_tin.Text = dr.Item("signatory_2307_tin").ToString()
            Else
                txt_signatory_id.Text = ""
                txt_signatory_name.Text = ""
                txt_signatory_position.Text = ""
                txt_signatory_tin.Text = ""
            End If
        Else
            txt_signatory_id.Text = ""
            txt_signatory_name.Text = ""
            txt_signatory_position.Text = ""
            txt_signatory_tin.Text = ""
        End If
    End Sub
    Private Sub monthChange(month, year)
        If month <> "" Then
            If CType(month, Decimal) < 10 Then
                month = "0" & month
            End If
        Else
            month = "01"
        End If
        Dim dt As DataTable = get1601E(month, year)
        dg_1601E.AutoGenerateColumns = False
        dg_1601E.DataSource = dt
    End Sub
    Private Sub txt_month_ValueChange(sender As Object) Handles txt_month.ValueChange
        monthChange(txt_month.Value, txt_year.Value)
    End Sub
    Private Sub txt_year_ValueChanged(sender As Object, e As EventArgs) Handles txt_year.ValueChanged
        monthChange(txt_month.Value, txt_year.Value)
    End Sub
    Private Sub QuarterChange(sender As Object, e As EventArgs) Handles rdo_quarter_1.CheckedChanged, rdo_quarter_4.CheckedChanged, rdo_quarter_3.CheckedChanged, rdo_quarter_2.CheckedChanged
        Dim quarter As String = getRdoValue(quarter_filter)
        If quarter <> "" Then
            Dim min As Decimal = 0
            Dim max As Decimal = 0
            max = (12 * CType(quarter, Integer)) / 4
            min = max - 2
            txt_month_from.Minimum = min
            txt_month_from.Maximum = max
            txt_month_to.Minimum = min
            txt_month_to.Maximum = max
            txt_month_from.Value = min
            txt_month_to.Value = max
            txt_day_from.Value = txt_day_from.Minimum
            txt_day_to.Value = txt_day_to.Maximum
        End If
    End Sub
    Private Sub setMaxDay(ByVal ctrl As Object, ByVal month As Integer, ByVal year As Integer)
        If year > 0 And month > 0 Then
            Dim currenctDate As New Date(year, month, 1)
            Dim lastDate = currenctDate.AddMonths(1).AddDays(-1)
            ctrl.Maximum = lastDate.ToString("dd")
            txt_day_from.Value = txt_day_from.Minimum
            txt_day_to.Value = txt_day_to.Maximum
        End If
    End Sub
    Private Sub txt_month_from_ValueChange(sender As Object) Handles txt_month_from.ValueChange
        setMaxDay(txt_day_from, txt_month_from.Value, txt_year_from.Value)
    End Sub
    Private Sub txt_month_to_ValueChange(sender As Object) Handles txt_month_to.ValueChange
        setMaxDay(txt_day_to, txt_month_to.Value, txt_year_to.Value)
    End Sub
    Private Sub txt_year_from_ValueChanged(sender As Object, e As EventArgs) Handles txt_year_from.ValueChanged
        setMaxDay(txt_day_from, txt_month_from.Value, txt_year_from.Value)
    End Sub
    Private Sub txt_year_to_ValueChanged(sender As Object, e As EventArgs) Handles txt_year_to.ValueChanged
        setMaxDay(txt_day_to, txt_month_to.Value, txt_year_to.Value)
    End Sub
    Private Sub dg_1601E_SelectionChanged(sender As Object, e As EventArgs) Handles dg_1601E.SelectionChanged
        Dim dt As DataTable = dg_1601E.DataSource
        bind_control(dg_1601E, "ewt_id", dt, Me)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If txt_signatory_name.Text = "" Or txt_signatory_position.Text = "" Or txt_signatory_tin.Text = "" Then
            MsgBox("Incomplete Signatory Data!", vbInformation + vbOKOnly)
            Exit Sub
        End If

        Dim print As String = getRdoValue(print_filter)
        Dim quarter As String = getRdoValue(quarter_filter)

        Dim month As String = txt_month.Value
        Dim month_from As Integer = txt_month_from.Value
        Dim month_to As Integer = txt_month_to.Value
        Dim year As Integer = txt_year.Value
        Dim year_from As Integer = txt_year_from.Value
        Dim year_to As Integer = txt_year_to.Value
        Dim day_from As Integer = txt_day_from.Value
        Dim day_to As Integer = txt_day_to.Value

        Dim date_from As String = year_from & "-" & If(month_from > 9, month_from.ToString, "0" + month_from.ToString) & "-" & If(day_from > 9, day_from.ToString, "0" + day_from.ToString)
        Dim date_to As String = year_to & "-" & If(month_to > 9, month_to.ToString, "0" + month_to.ToString) & "-" & If(day_to > 9, day_to.ToString, "0" + day_to.ToString)

        Dim general_exist As Boolean = False

        Dim signatory_name As String = txt_signatory_name.Text
        Dim signatory_position As String = txt_signatory_position.Text
        Dim signatory_tin As String = txt_signatory_tin.Text
        Dim arr_general_id As New List(Of String)
        Dim arr_general As New List(Of String)

        If month <> "" Then
            If CType(month, Decimal) < 10 Then
                month = "0" & month
            End If
        Else
            month = "01"
        End If

        For i As Integer = 1 To 10
            Dim ctrl = CType(Me.Controls.Find("txt_general_id_" & i, True)(0), user_control.textbox)
            If ctrl.Value.ToString <> "" Then
                Dim row As DataRow = ctrl.RowData
                If row IsNot Nothing Then
                    Dim gid As String = row.Item("general_id").ToString
                    If Not arr_general.Contains(gid) Then
                        arr_general.Add(gid)
                    End If
                End If
                If arr_general_id.Contains(ctrl.Value) Then
                    general_exist = True
                End If
                arr_general_id.Add(ctrl.Value)
            End If
        Next

        'validation
        Select Case print
            Case "1"
            Case "2"
            Case "3"
            Case "4"
                If arr_general_id.Count = 0 Then
                    MsgBox("Select General First")
                    txt_general_id_1.Focus()
                    Exit Sub
                End If
                If general_exist Then
                    MsgBox("Duplicate Selection of General")
                    txt_general_id_1.Focus()
                    Exit Sub
                End If
            Case "5"
        End Select
        'end of validation
        'Query
        Dim sql_company As String = String.Format("SELECT b.company_name,b.address1 AS address,b.tin,b.tel_no,rdo_code AS rdo_code ,email_add AS email_address" &
                " FROM {1}.sys_default a " &
                "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id" &
                "", _serverDBFS, _serverDBMain)
        Dim dt_company As DataTable = Query(sql_company)
        dt_company.TableName = "Company"
        Select Case print
            Case "1"
                Dim dt_ewt As DataTable = get1601E(month, year, True)
                dt_ewt.TableName = "EWT"

                Dim ds As New DataSet("1601Eset")
                ds.Tables.Add(dt_company)
                ds.Tables.Add(dt_ewt)
                Try
                    Dim filter As New erpbirformsFilter
                    filter.ShowDialog()
                    If filter.DialogResult = DialogResult.OK Then
                        Create0619ePDF(ds, filter.chkAmendedYes.Checked, filter.chkTaxesWithheldYes.Checked, filter.chkPrivate.Checked)
                    End If
                    'lblLoad.Visible = True
                    'create1601Eexcel(ds, signatory_name, signatory_position, month, year)
                    'MsgBox("Report Done")
                    'lblLoad.Visible = False
                Catch ex As Exception
                    lblLoad.Visible = False
                    MsgBox(String.Format("Error Occured : {0}", ex.Message))
                    MyDebugging.AddText(ex.Message)
                End Try
            Case "2"
            Case "3"
            Case "4"
                Dim general_ids As String = ""
                For i As Integer = 0 To arr_general_id.Count - 1
                    general_ids &= "," & arr_general_id.Item(i)
                Next
                Dim sql_general
                If rdo_per_supplier.Checked = True Then
                    sql_general = String.Format("SELECT a.trans_id,a.general_id,IF(IFNULL(b.general_name_bir,'') = '',b.general_name,b.general_name_bir) AS general_name,b.address1 AS address,b.tin
                        FROM trans_header a " &
                     "LEFT JOIN {1}.lib_erp_general b ON b.general_id = a.general_id " &
                     "WHERE a.general_id = {0} GROUP BY a.general_id" &
                     "", general_id, _serverDBFS)
                Else
                    sql_general = String.Format("SELECT a.trans_id,a.general_id,IF(IFNULL(b.general_name_bir,'') = '',b.general_name,b.general_name_bir) AS general_name,b.address1 AS address,b.tin
                        FROM trans_header a " &
                      "LEFT JOIN {1}.lib_erp_general b ON b.general_id = a.general_id " &
                      "WHERE a.trans_id IN ({0}) " &
                      "", String.Join(",", arr_general_id), _serverDBFS)
                End If

                Dim dt_general As DataTable = Query(sql_general)


                dt_general.TableName = "General"

                Dim dt_ewt As DataTable = get2307(date_from, date_to, arr_general_id)
                If dt_ewt.Rows.Count = 0 Then
                    MsgBox("No Record !", vbCritical + vbOKOnly)
                    Exit Sub
                Else
                    dt_ewt.TableName = "EWT"
                    Dim ds As New DataSet("2307set")
                    ds.Tables.Add(dt_company)
                    ds.Tables.Add(dt_general)
                    ds.Tables.Add(dt_ewt)
                    Try
                        lblLoad.Visible = True
                        create2307excel(ds, signatory_name, signatory_position, date_from, date_to, signatory_tin)
                        Dim dicSignatory As New Dictionary(Of String, String)
                        dicSignatory.Add("signatory_2307_id", txt_signatory_id.Text)
                        dicSignatory.Add("signatory_2307_name", txt_signatory_name.Text)
                        dicSignatory.Add("signatory_2307_position", txt_signatory_position.Text)
                        dicSignatory.Add("signatory_2307_tin", txt_signatory_tin.Text)
                        Dim sql_signatory = ATGenerateQuery("Update", "lib_acc_signatory_2307", dicSignatory, Environment.MachineName, Environment.UserName, main.log_id, txt_signatory_id.Text, "signatory_2307_id")
                        FsQuery(sql_signatory)
                        dt_ewt.Clear()
                        MsgBox("Report Done")
                        lblLoad.Visible = False
                    Catch ex As Exception
                        lblLoad.Visible = False
                        MsgBox(String.Format("Error Occured : {0}", ex.Message))
                        MyDebugging.AddText(ex.Message)
                    End Try
                    'MsgBox("Generating of Report Done : 2307.xlt")
                End If

            Case "5"
        End Select
        'End of Query
        'Report
        'End of Report
    End Sub
    Private Sub SetStringLength(ByRef str As String, ByVal length As Integer, ByVal Character As Char, Optional Left As Boolean = True)
        While str.Length < length
            If Left Then
                str = Character & str
            Else
                str = str & Character
            End If
        End While
    End Sub
    Private Sub Create0619ePDF(ByRef ds As DataSet, ByVal amended As Boolean, ByVal withheld As Boolean, ByVal isPrivate As Boolean)
        Dim amountWithheld As Decimal = ds.Tables("EWT").Compute("SUM(tax_amount_based)", Nothing)
        Dim arrAmountWithheld = amountWithheld.ToString().Split(".")
        SetStringLength(arrAmountWithheld(0), 11, " ")
        SetStringLength(arrAmountWithheld(1), 2, "0", False)
        Dim pdfPath As String = Application.StartupPath & "/templates/tmp/"
        Dim pdfFile As String = Application.StartupPath & "/templates/0619e.pdf"
        Dim documentProcessor As New PdfDocumentProcessor()
        documentProcessor.LoadDocument(pdfFile)
        Dim formData As PdfFormData = documentProcessor.GetFormData()
        Dim month As String = txt_month.Value
        Dim year As String = txt_year.Value
        Dim tin As String = ds.Tables("Company").Rows(0).Item("tin").ToString
        Dim rdoCode As String = ds.Tables("Company").Rows(0).Item("rdo_code").ToString
        Dim company_name As String = ds.Tables("Company").Rows(0).Item("company_name").ToString
        Dim company_address As String = ds.Tables("Company").Rows(0).Item("address").ToString
        Dim tel_no As String = ds.Tables("Company").Rows(0).Item("tel_no").ToString
        Dim email_address As String = ds.Tables("Company").Rows(0).Item("email_address").ToString
        tin = tin.Replace("-", "")
        tel_no = tel_no.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "")
        SetStringLength(tin, 14, "0", False)
        SetStringLength(rdoCode, 3, "0", False)
        SetStringLength(company_name, 40, " ", False)
        SetStringLength(company_address, 71, " ", False)
        SetStringLength(tel_no, 12, " ", False)
        SetStringLength(email_address, 40, " ", False)
        month = If(CDec(month) < 10, "0" & month, month)
        formData("txtMonth1").Value = month.Substring(0, 1)
        formData("txtMonth2").Value = month.Substring(1, 1)
        formData("txtYear1").Value = year.Substring(0, 1)
        formData("txtYear2").Value = year.Substring(1, 1)
        formData("txtYear3").Value = year.Substring(2, 1)
        formData("txtYear4").Value = year.Substring(3, 1)
        formData("txtYear4").Value = year.Substring(3, 1)
        For i As Integer = 1 To 14
            formData("txtTIN" & i).Value = tin.Substring(i - 1, 1)
        Next
        For i As Integer = 1 To 3
            formData("txtRDO" & i).Value = rdoCode.Substring(i - 1, 1)
        Next
        formData("txtAgentName1").Value = company_name
        'For i As Integer = 1 To 40
        '    formData("txtAgentName" & i).Value = company_name.Substring(i - 1, 1)
        'Next
        For i As Integer = 1 To 71
            formData("txtAddress" & i).Value = company_address.Substring(i - 1, 1)
        Next
        For i As Integer = 1 To 12
            formData("txtContact" & i).Value = tel_no.Substring(i - 1, 1)
        Next
        For i As Integer = 1 To 40
            formData("txtEmail" & i).Value = email_address.Substring(i - 1, 1)
        Next
        For i As Integer = 1 To 11
            formData("txtAmountOfRemittance" & i).Value = arrAmountWithheld(0).Substring(i - 1, 1)
        Next
        For i As Integer = 1 To 11
            formData("txtNETRemitted" & i).Value = arrAmountWithheld(0).Substring(i - 1, 1)
        Next
        For i As Integer = 1 To 11
            formData("txtTotalRemitted" & i).Value = arrAmountWithheld(0).Substring(i - 1, 1)
        Next
        formData("txtAmountOfRemittance12").Value = arrAmountWithheld(1).Substring(0, 1)
        formData("txtAmountOfRemittance13").Value = arrAmountWithheld(1).Substring(1, 1)
        formData("txtNETRemitted12").Value = arrAmountWithheld(1).Substring(0, 1)
        formData("txtNETRemitted13").Value = arrAmountWithheld(1).Substring(1, 1)
        formData("txtTotalRemitted12").Value = arrAmountWithheld(1).Substring(0, 1)
        formData("txtTotalRemitted13").Value = arrAmountWithheld(1).Substring(1, 1)
        formData("chkPrivate").Value = If(isPrivate, "Yes", "No")
        formData("chkGovernment").Value = If(Not isPrivate, "Yes", "No")
        formData("chkAmendedYes").Value = If(amended, "Yes", "No")
        formData("chkAmendedNo").Value = If(Not amended, "Yes", "No")
        formData("chkTaxesWithheldYes").Value = If(withheld, "Yes", "No")
        formData("chkTaxesWithheldNo").Value = If(Not withheld, "Yes", "No")
        Dim tmpFile As String = pdfPath & GenerateRandomString() & ".pdf"
        documentProcessor.SaveDocument(tmpFile)
        Dim frm As New bir0619e
        frm.mypdf.LoadDocument(tmpFile)
        frm.ShowDialog()
        frm.mypdf.CloseDocument()
        documentProcessor.CloseDocument()
        My.Computer.FileSystem.DeleteFile(tmpFile)
    End Sub
    'Private Sub create1601Eexcel(ByVal ds As DataSet, ByVal signatory_name As String, ByVal signatory_position As String, ByVal month As String, ByVal year As String)
    '    Dim company As DataRow = ds.Tables("Company").Rows(0)
    '    Dim ewt As DataTable = ds.Tables("EWT")

    '    Dim tin() As String = company.Item("tin").ToString.Split({"-"}, StringSplitOptions.RemoveEmptyEntries)

    '    Dim xlApp As Excel.Application
    '    Dim xlWorkBook As Excel.Workbook
    '    Dim xlWorkSheet As Excel.Worksheet
    '    Dim xlShape As Excel.Shape = Nothing

    '    xlApp = New Excel.Application
    '    xlWorkBook = xlApp.Workbooks.Open(templates & "\1601e.xlt")
    '    xlApp.Visible = True
    '    xlWorkSheet = xlWorkBook.Worksheets(2)

    '    'Month
    '    xlShape = xlWorkSheet.Shapes.Item("Rectangle 285")
    '    xlShape.TextFrame.Characters.Text = month
    '    xlShape.TextEffect.FontBold = True
    '    xlShape.TextFrame.MarginTop = "0"
    '    xlShape.TextFrame.MarginRight = "0"
    '    xlShape.TextFrame.MarginBottom = "0"
    '    xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    '    'Year
    '    xlShape = xlWorkSheet.Shapes.Item("Rectangle 23")
    '    xlShape.TextFrame.Characters.Text = year
    '    xlShape.TextEffect.FontBold = True
    '    xlShape.TextFrame.MarginTop = "0"
    '    xlShape.TextFrame.MarginRight = "0"
    '    xlShape.TextFrame.MarginBottom = "0"
    '    xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '    xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '    'TIN
    '    If company.Item("tin").ToString.Trim() <> "" And tin.Length = 4 Then

    '        'Tin no 1
    '        xlShape = xlWorkSheet.Shapes.Item("Rectangle 42")
    '        xlShape.TextFrame.Characters.Text = tin(0)
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        'Tin no 2
    '        xlShape = xlWorkSheet.Shapes.Item("Rectangle 40")
    '        xlShape.TextFrame.Characters.Text = tin(1)
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        'Tin no 3
    '        xlShape = xlWorkSheet.Shapes.Item("Rectangle 39")
    '        xlShape.TextFrame.Characters.Text = tin(2)
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '        'Tin no 4
    '        xlShape = xlWorkSheet.Shapes.Item("Rectangle 37")
    '        xlShape.TextFrame.Characters.Text = tin(3)
    '        xlShape.TextEffect.FontBold = True
    '        xlShape.TextFrame.MarginTop = "0"
    '        xlShape.TextFrame.MarginRight = "0"
    '        xlShape.TextFrame.MarginBottom = "0"
    '        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '    End If

    '    'RDO Code
    '    xlShape = xlWorkSheet.Shapes.Item("Rectangle 46")
    '    xlShape.TextFrame.Characters.Text = company.Item("rdo_code")
    '    xlShape.TextEffect.FontBold = True
    '    xlShape.TextFrame.MarginTop = "0"
    '    xlShape.TextFrame.MarginRight = "0"
    '    xlShape.TextFrame.MarginBottom = "0"
    '    xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '    xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '    'Company Name
    '    xlShape = xlWorkSheet.Shapes.Item("Rectangle 47")
    '    xlShape.TextFrame.Characters.Text = company.Item("company_name")
    '    xlShape.TextEffect.FontBold = True
    '    xlShape.TextFrame.MarginTop = "0"
    '    xlShape.TextFrame.MarginRight = "0"
    '    xlShape.TextFrame.MarginBottom = "0"
    '    xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    '    'Telephone Number
    '    xlShape = xlWorkSheet.Shapes.Item("Rectangle 21")
    '    xlShape.TextFrame.Characters.Text = company.Item("tel_no")
    '    xlShape.TextEffect.FontBold = True
    '    xlShape.TextFrame.MarginTop = "0"
    '    xlShape.TextFrame.MarginRight = "0"
    '    xlShape.TextFrame.MarginBottom = "0"
    '    xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '    xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '    'Address
    '    xlShape = xlWorkSheet.Shapes.Item("Rectangle 165")
    '    xlShape.TextFrame.Characters.Text = company.Item("address")
    '    xlShape.TextEffect.FontBold = True
    '    xlShape.TextFrame.MarginTop = "0"
    '    xlShape.TextFrame.MarginRight = "0"
    '    xlShape.TextFrame.MarginBottom = "0"
    '    xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    '    'Signatory Name
    '    xlShape = xlWorkSheet.Shapes.Item("Text Box 488")
    '    xlShape.TextFrame.Characters.Text = signatory_name
    '    xlShape.TextEffect.FontBold = True
    '    xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '    xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '    'Signatory Position
    '    xlShape = xlWorkSheet.Shapes.Item("Text Box 489")
    '    xlShape.TextFrame.Characters.Text = signatory_position
    '    xlShape.TextEffect.FontBold = True
    '    xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '    xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    '    Dim r As Integer = 29
    '    For Each row As DataRow In ewt.Rows
    '        xlWorkSheet.Cells(r, 1) = row.Item("ewt_name").ToString
    '        xlWorkSheet.Cells(r, 18) = row.Item("ewt_code").ToString
    '        xlWorkSheet.Cells(r, 21) = String.Format("{0:##,##0.00}", row.Item("amount_based"))
    '        xlWorkSheet.Cells(r, 25) = String.Format("{0:#}%", row.Item("tax_rate"))
    '        xlWorkSheet.Cells(r, 27) = String.Format("{0:##,##0.00}", row.Item("tax_amount_based"))
    '        xlWorkSheet.Rows.WrapText = False
    '        r += 1
    '    Next

    'End Sub
    Private Sub create1601Eexcel(ByVal ds As DataSet, ByVal signatory_name As String, ByVal signatory_position As String, ByVal month As String, ByVal year As String)

        Dim company As DataRow = ds.Tables("Company").Rows(0)
        Dim ewt As DataTable = ds.Tables("EWT")

        Dim tin() As String = company.Item("tin").ToString.Split({"-"}, StringSplitOptions.RemoveEmptyEntries)

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet


        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(templates & "\1601e.xlt")
        xlApp.Visible = True
        xlWorkSheet = xlWorkBook.Worksheets(1)


        'Month
        Dim var_month As String = Nothing
        If month > 9 Then
        Else
            var_month = String.Format("{0}", month)
        End If
        'Month
        xlWorkSheet.Cells(6, 3) = String.Format("{0}", var_month)

        'Year
        xlWorkSheet.Cells(6, 5) = String.Format("{0}", year)



        ''''Due Date
        Dim due_date As New DateTime(year, month, 1)
        Dim due_month = due_date.Month
        Dim due_year = due_date.Year
        due_date = due_date.AddMonths(1)

        'Month
        xlWorkSheet.Cells(6, 10) = If(due_month > 9, String.Format("{0}", due_date.Month), String.Format("0{0}", due_date.Month))

        'day
        xlWorkSheet.Cells(6, 12) = String.Format("0{0}", 1)

        'day
        xlWorkSheet.Cells(6, 14) = String.Format("{0}", due_year)




        'TIN
        If company.Item("tin").ToString.Trim() <> "" And tin.Length = 4 Then
            'Tin no 1
            xlWorkSheet.Cells(9, 15) = tin(0)

            'Tin no 2
            xlWorkSheet.Cells(9, 19) = tin(1)

            'Tin no 3
            xlWorkSheet.Cells(9, 23) = tin(2)

            'Tin no 4
            xlWorkSheet.Cells(9, 27) = tin(3)

        End If

        'RDO Code
        xlWorkSheet.Cells(9, 3) = ifNull(company.Item("rdo_code"), "000")

        'Company Name
        xlWorkSheet.Cells(12, 1) = company.Item("company_name")

        'Telephone Number
        xlWorkSheet.Cells(19, 7) = company.Item("tel_no")

        'Address
        xlWorkSheet.Cells(15, 1) = company.Item("address").ToString

        'email address
        xlWorkSheet.Cells(22, 1) = company.Item("email_address").ToString

        'zip code
        xlWorkSheet.Cells(17, 37) = "0000"

        'withholding tax
        Dim withholding_tax_var As Double = ds.Tables("EWT").Compute("Sum(tax_amount_based)", "")
        Dim withholding_tax_var_ As Integer = ds.Tables("EWT").Compute("Sum(tax_amount_based)", "")
        Dim getDeci As Double = withholding_tax_var - withholding_tax_var_
        xlWorkSheet.Cells(25, 27) = String.Join(" ", Format(withholding_tax_var, "##0"))
        xlWorkSheet.Cells(25, 39) = Replace(Format(getDeci, ".00"), ".", "")

        xlWorkSheet.Cells(27, 27) = "0"


        xlWorkSheet.Cells(29, 27) = String.Join(" ", Format(withholding_tax_var, "##0"))
        xlWorkSheet.Cells(29, 39) = Replace(Format(getDeci, ".00"), ".", "")

        xlWorkSheet.Cells(40, 27) = String.Join(" ", Format(withholding_tax_var, "##0"))
        xlWorkSheet.Cells(40, 39) = Replace(Format(getDeci, ".00"), ".", "")
        'xlWorkSheet.Cells(25, 39) = Replace(Format(ds.Tables("EWT").Compute(String.Format("Sum({0})", ""), "tax_amount_based"), ".00"), ".", "")
    End Sub
    Private Function get1601E(ByVal month As String, ByVal year As String, Optional isExcel As Boolean = False) As DataTable
        Dim str1 As String = ",c.amount_based,c.tax_amount_based "
        Dim str2 As String = ""

        If isExcel Then
            str1 = ",SUM(c.amount_based) As amount_based,SUM(c.tax_amount_based) As tax_amount_based "
            str2 = "GROUP BY c.fs_ewt_id "
        End If

        Dim sql = String.Format("Select a.trans_no,a.trans_date " &
            ",c.tax_rate " &
            str1 &
            ",d.general_name,d.tin,d.address1 As address,d.Date,'' AS rdo_code " &
            ",g.ewt_code,g.ewt_name " &
            ",e.project_name " &
            ",f.department_name,c.ewt_id " &
            "FROM {3}.trans_header a " &
            "LEFT JOIN {3}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "LEFT JOIN {3}.trans_ewt c ON c.jbooks_id = b.jbooks_id " &
            "LEFT JOIN {2}.lib_erp_general d ON d.general_id = c.general_id " &
            "LEFT JOIN {2}.lib_erp_project e ON e.project_id = b.project_id " &
            "LEFT JOIN {2}.lib_erp_department f ON f.department_id = b.department_id " &
            "LEFT JOIN {2}.lib_acc_ewt g ON g.ewt_id = c.fs_ewt_id " &
            "LEFT JOIN {2}.lib_erp_chart h ON h.account_id = b.account_id " &
            "WHERE h.validation = 4 AND DATE_FORMAT(a.trans_date,'%m-%Y') = '{0}-{1}' AND IFNULL(c.ref_ewt_id,'') = '' AND IFNULL(c.ewt_id,'') <> '' " &
            str2 &
            "", month, year, _serverDBFS, _serverDBMain)

        Dim dt As DataTable = Query(sql)
        Return dt
    End Function
    Private Function shapeDesign(ByVal xlShape As Excel.Shape) As Excel.Shape
        xlShape.TextEffect.FontBold = True
        xlShape.TextFrame.MarginTop = "0"
        xlShape.TextFrame.MarginRight = "0"
        xlShape.TextFrame.MarginBottom = "0"
        xlShape.TextFrame.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Return xlShape
    End Function
    Private Sub create2307excel(ByVal ds As DataSet, ByVal signatory_name As String, ByVal signatory_position As String, ByVal date_from As String, ByVal date_to As String, ByVal signatory_tin As String)

        Dim company As DataRow = ds.Tables("Company").Rows(0)
        Dim general As DataTable = ds.Tables("General")
        Dim ewt As DataTable = ds.Tables("EWT")

        Dim from_date() As String = date_from.Split("-")
        Dim to_date() As String = date_to.Split("-")
        Dim tin_company() As String = company.Item("tin").ToString.Split({"-"}, StringSplitOptions.RemoveEmptyEntries)


        For Each row As DataRow In general.Rows
            Dim tin() As String = row.Item("tin").ToString.Split({"-"}, StringSplitOptions.RemoveEmptyEntries)

            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim xlShape As Excel.Shape = Nothing

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(templates & "\2307_v3_.xlt")
            xlApp.Visible = True
            xlWorkSheet = xlWorkBook.Worksheets(1)

            ''From Month
            'xlShape = xlWorkSheet.Shapes.Item("Rectangle 138")
            'xlShape.TextFrame.Characters.Text = If(CType(from_date(1), Decimal) <= 9, "0" & from_date(1), from_date(1))
            'xlShape = shapeDesign(xlShape)
            'From Day  'From Month
            xlShape = xlWorkSheet.Shapes.Item("Text Box 2")
            xlShape.TextFrame.Characters.Text = from_date(1) + "   " + from_date(2)
            xlShape = shapeDesign(xlShape)
            'From Year
            xlShape = xlWorkSheet.Shapes.Item("Text Box 3")
            xlShape.TextFrame.Characters.Text = from_date(0).ToString.Substring(0)
            xlShape = shapeDesign(xlShape)

            ''To Month
            'xlShape = xlWorkSheet.Shapes.Item("Rectangle 292")
            'xlShape.TextFrame.Characters.Text = If(CType(to_date(1), Decimal) <= 9, "0" & to_date(1), to_date(1))
            'xlShape = shapeDesign(xlShape)
            'To Day
            xlShape = xlWorkSheet.Shapes.Item("Text Box 4")
            xlShape.TextFrame.Characters.Text = to_date(1) + "   " + to_date(2)
            xlShape = shapeDesign(xlShape)
            'To Year
            xlShape = xlWorkSheet.Shapes.Item("Text Box 5")
            xlShape.TextFrame.Characters.Text = to_date(0).ToString.Substring(0)
            xlShape = shapeDesign(xlShape)



            'General Name
            xlShape = xlWorkSheet.Shapes.Item("Text Box 10")
            xlShape.TextFrame.Characters.Text = row.Item("general_name")
            xlShape = shapeDesign(xlShape)
            xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'General Address
            xlShape = xlWorkSheet.Shapes.Item("Text Box 11")
            xlShape.TextFrame.Characters.Text = row.Item("address")
            xlShape = shapeDesign(xlShape)
            xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'General Tin
            If row.Item("tin").ToString.Trim() <> "" And tin.Length = 4 Then
                'Tin1
                xlShape = xlWorkSheet.Shapes.Item("Text Box 6")
                xlShape.TextFrame.Characters.Text = tin(0)
                xlShape = shapeDesign(xlShape)
                'Tin2
                xlShape = xlWorkSheet.Shapes.Item("Text Box 7")
                xlShape.TextFrame.Characters.Text = tin(1)
                xlShape = shapeDesign(xlShape)
                'Tin3
                xlShape = xlWorkSheet.Shapes.Item("Text Box 8")
                xlShape.TextFrame.Characters.Text = tin(2)
                xlShape = shapeDesign(xlShape)
                'Tin4
                xlShape = xlWorkSheet.Shapes.Item("Text Box 9")
                xlShape.TextFrame.Characters.Text = tin(3)
                xlShape = shapeDesign(xlShape)
            End If

            'Company Name
            xlShape = xlWorkSheet.Shapes.Item("Text Box 18")
            xlShape.TextFrame.Characters.Text = company.Item("company_name")
            xlShape = shapeDesign(xlShape)
            xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'Company Address
            xlShape = xlWorkSheet.Shapes.Item("Text Box 19")
            xlShape.TextFrame.Characters.Text = company.Item("address")
            xlShape = shapeDesign(xlShape)
            xlShape.TextFrame.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'Company Tin
            If company.Item("tin").ToString.Trim() <> "" And tin_company.Length = 4 Then
                'Tin1
                xlShape = xlWorkSheet.Shapes.Item("Text Box 14")
                xlShape.TextFrame.Characters.Text = tin_company(0)
                xlShape = shapeDesign(xlShape)
                'Tin2
                xlShape = xlWorkSheet.Shapes.Item("Text Box 15")
                xlShape.TextFrame.Characters.Text = tin_company(1)
                xlShape = shapeDesign(xlShape)
                'Tin3
                xlShape = xlWorkSheet.Shapes.Item("Text Box 16")
                xlShape.TextFrame.Characters.Text = tin_company(2)
                xlShape = shapeDesign(xlShape)
                'Tin4
                xlShape = xlWorkSheet.Shapes.Item("Text Box 17")
                xlShape.TextFrame.Characters.Text = tin_company(3)
                xlShape = shapeDesign(xlShape)
            End If

            'xlWorkSheet.Cells(68, 2) = signatory_name
            'xlWorkSheet.Cells(68, 2).Font.Bold = True
            'xlWorkSheet.Cells(68, 21) = signatory_tin
            'xlWorkSheet.Cells(68, 21).Font.Bold = True
            'xlWorkSheet.Cells(68, 33) = signatory_position
            'xlWorkSheet.Cells(68, 33).Font.Bold = True 
            'signatory_name
            xlWorkSheet.Cells(63, 1) = signatory_name + "               " + signatory_position + "              " + signatory_tin
            xlWorkSheet.Cells(63, 1).Font.Bold = True

            Dim r As Integer = 38
            For Each dr As DataRow In ewt.Rows
                'And row.Item("trans_id").ToString = dr.Item("trans_id").ToString
                If rdo_per_supplier.Checked = True Then
                    If row.Item("general_id").ToString = dr.Item("general_id").ToString Then
                        xlWorkSheet.Cells(r, 1) = dr.Item("ewt_name").ToString
                        xlWorkSheet.Cells(r, 12) = dr.Item("ewt_code").ToString
                        xlWorkSheet.Cells(r, 15) = String.Format("{0:##,##0.00}", dr.Item("first_month"))
                        xlWorkSheet.Cells(r, 20) = String.Format("{0:##,##0.00}", dr.Item("second_month"))
                        xlWorkSheet.Cells(r, 25) = String.Format("{0:##,##0.00}", dr.Item("third_month"))
                        xlWorkSheet.Cells(r, 30) = String.Format("{0:##,##0.00}", dr.Item("total"))
                        xlWorkSheet.Cells(r, 35) = dr.Item("total_ewt")
                        xlWorkSheet.Cells(r, 35).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        'xlWorkSheet.Rows.WrapText = False
                        r += 1
                    End If
                Else
                    If row.Item("trans_id").ToString = dr.Item("trans_id").ToString Then
                        xlWorkSheet.Cells(r, 1) = dr.Item("ewt_name").ToString
                        xlWorkSheet.Cells(r, 12) = dr.Item("ewt_code").ToString
                        xlWorkSheet.Cells(r, 15) = String.Format("{0:##,##0.00}", dr.Item("first_month"))
                        xlWorkSheet.Cells(r, 20) = String.Format("{0:##,##0.00}", dr.Item("second_month"))
                        xlWorkSheet.Cells(r, 25) = String.Format("{0:##,##0.00}", dr.Item("third_month"))
                        xlWorkSheet.Cells(r, 30) = String.Format("{0:##,##0.00}", dr.Item("total"))
                        xlWorkSheet.Cells(r, 35) = dr.Item("total_ewt")
                        xlWorkSheet.Cells(r, 35).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        'xlWorkSheet.Rows.WrapText = False
                        r += 1
                    End If
                End If

            Next
        Next
        ds.Tables("General").Clear()
        ds.Tables("EWT").Clear()
    End Sub
    Private Function get2307(ByVal date_from As String, ByVal date_to As String, ByVal arr_general_id As List(Of String)) As DataTable
        Dim sql As String

        Dim general_ids As String = ""
        For i As Integer = 0 To arr_general_id.Count - 1
            general_ids &= "," & arr_general_id.Item(i)
        Next
        If rdo_per_supplier.Checked = False Then
            sql = String.Format("SELECT a.trans_id,a.general_id,a.fs_ewt_id,a.ewt_code,a.ewt_name,a.general_id " &
            ",IFNULL(SUM(a.first_month),0) AS first_month,IFNULL(SUM(a.second_month),0) AS second_month,IFNULL(SUM(a.third_month),0) AS third_month " &
            ",IFNULL(SUM(a.amount_based),0) AS total,IFNULL(SUM(a.tax_amount_based),0) AS total_ewt " &
            "FROM ( " &
            "  SELECT a.trans_id,a.trans_no,a.trans_date,DATE_FORMAT(a.trans_date,'%m') AS month " &
            "  ,IF(DATE_FORMAT(a.trans_date,'%m') IN ('01','04','07','10'),SUM(d.amount_based),NULL) AS first_month " &
            "  ,IF(DATE_FORMAT(a.trans_date,'%m') IN ('02','05','08','11'),SUM(d.amount_based),NULL) AS second_month " &
            "  ,IF(DATE_FORMAT(a.trans_date,'%m') IN ('03','06','09','12'),SUM(d.amount_based),NULL) AS third_month " &
            "  ,d.fs_ewt_id,e.ewt_code,e.ewt_name " &
            "  ,d.general_id,IF(IFNULL(f.general_name_bir,'') = '',f.general_name,f.general_name_bir) AS general_name,f.address1 AS address,f.tin " &
            "  ,SUM(d.amount_based) AS amount_based,SUM(d.tax_amount_based) AS tax_amount_based " &
            "  FROM {4}.trans_header a " &
            "  LEFT JOIN {4}.trans_jbooks b ON b.trans_id = a.trans_id " &
            "  LEFT JOIN {3}.lib_erp_chart c ON c.account_id = b.account_id " &
            "  LEFT JOIN {4}.trans_ewt d ON d.jbooks_id = b.jbooks_id " &
            "  LEFT JOIN {3}.lib_acc_ewt e ON e.ewt_id = d.fs_ewt_id " &
            "  LEFT JOIN {3}.lib_erp_general f ON f.general_id = d.general_id " &
            "  WHERE c.validation = 4 AND a.trans_id IN (0{2}) " &
            "  GROUP BY a.trans_id,d.fs_ewt_id,DATE_FORMAT(a.trans_date,'%m-%Y') " &
            "  ORDER BY e.ewt_code) a " &
            "  GROUP BY a.trans_id,a.fs_ewt_id " &
            "", date_from, date_to, general_ids, _serverDBFS, _serverDBMain)
        Else
            sql = String.Format(" SELECT a.trans_id,a.general_id,a.fs_ewt_id,a.ewt_code,a.ewt_name,a.general_id ,IFNULL(SUM(a.first_month),0) AS first_month,IFNULL(SUM(a.second_month),0) AS second_month,IFNULL(SUM(a.third_month),0) AS third_month ,IFNULL(SUM(a.amount_based),0) AS total,IFNULL(SUM(a.tax_amount_based),0) AS total_ewt FROM ( " +
                "  SELECT a.trans_id,a.trans_no,a.trans_date,DATE_FORMAT(a.trans_date,'%m') AS month" +
                "   ,IF(DATE_FORMAT(a.trans_date,'%m') IN ('01','04','07','10'),SUM(d.amount_based),NULL) AS first_month" +
                "   ,IF(DATE_FORMAT(a.trans_date,'%m') IN ('02','05','08','11'),SUM(d.amount_based),NULL) AS second_month" +
                "   ,IF(DATE_FORMAT(a.trans_date,'%m') IN ('03','06','09','12'),SUM(d.amount_based),NULL) AS third_month" +
                "   ,d.fs_ewt_id,e.ewt_code,e.ewt_name   ,d.general_id,IF(IFNULL(f.general_name_bir,'') = '',f.general_name,f.general_name_bir)" +
                " AS general_name,f.address1 AS address,f.tin   ,SUM(d.amount_based) AS amount_based,SUM(d.tax_amount_based) AS tax_amount_based " +
                "  FROM {4}.trans_header a   " +
                "  LEFT JOIN {4}.trans_jbooks b ON b.trans_id = a.trans_id " +
                "  LEFT JOIN {3}.lib_erp_chart c ON c.account_id = b.account_id  " +
                " LEFT JOIN {4}.trans_ewt d ON d.jbooks_id = b.jbooks_id " +
                "  LEFT JOIN {3}.lib_acc_ewt e ON e.ewt_id = d.fs_ewt_id " +
                "  LEFT JOIN {3}.lib_erp_general f ON f.general_id = d.general_id  " +
                " WHERE c.validation = 4 AND a.general_id = {2} and DATE_FORMAT(a.trans_date,'%Y-%m-%d') BETWEEN '{0}' AND '{1}'" +
                " GROUP BY  d.fs_ewt_id,DATE_FORMAT(a.trans_date,'%m-%Y') " +
                "  ORDER BY e.ewt_code) a  " +
                " GROUP BY a.fs_ewt_id ", date_from, date_to, general_id, _serverDBFS, _serverDBMain)
        End If
        Dim dt As DataTable = Query(sql)
        Return dt
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub erbirforms_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim signatory_id As String = txt_signatory_id.Text
        Dim signatory_name As String = txt_signatory_name.Text
        Dim signatory_position As String = txt_signatory_position.Text
        Dim signatory_tin As String = txt_signatory_tin.Text

        If signatory_id = "" Then
            Dim lst As New List(Of String)
            lst.Add("")
            lst.Add(signatory_name)
            lst.Add(signatory_position)
            lst.Add(signatory_tin)
            Dim col As New List(Of KeyValuePair(Of String, String))
            col.Add(New KeyValuePair(Of String, String)("@val", ConcatinateValues(lst)))
            ExecuteWithParameter("insert_lib_acc_signatory_2307", ConnectionStringFS, CommandType.StoredProcedure, col)
        Else
            Dim dic As New Dictionary(Of String, String)
            dic.Add("signatory_2307_name", signatory_name)
            dic.Add("signatory_2307_position", signatory_position)
            dic.Add("signatory_2307_tin", signatory_tin)
            Dim strUpdate As String = String.Format("UPDATE lib_acc_signatory_2307 SET {0} WHERE signatory_2307_id = '{1}'", ConcatinateValues(dic), signatory_id)
            FsQuery(strUpdate)
        End If
    End Sub

    Private Sub validation()
        Try
            If rdo_per_supplier.Checked = True Then
                txt_general_id_2.Enabled = False
                txt_general_id_3.Enabled = False
                txt_general_id_4.Enabled = False
                txt_general_id_5.Enabled = False
                txt_general_id_6.Enabled = False
                txt_general_id_7.Enabled = False
                txt_general_id_8.Enabled = False
                txt_general_id_9.Enabled = False
                txt_general_id_10.Enabled = False

                txt_general_id_1.Text = ""
                txt_general_id_2.Text = ""
                txt_general_id_3.Text = ""
                txt_general_id_4.Text = ""
                txt_general_id_5.Text = ""
                txt_general_id_6.Text = ""
                txt_general_id_7.Text = ""
                txt_general_id_8.Text = ""
                txt_general_id_9.Text = ""
                txt_general_id_10.Text = ""


                txt_general_name_1.Text = ""
                txt_general_name_2.Text = ""
                txt_general_name_3.Text = ""
                txt_general_name_4.Text = ""
                txt_general_name_5.Text = ""
                txt_general_name_6.Text = ""
                txt_general_name_7.Text = ""
                txt_general_name_8.Text = ""
                txt_general_name_9.Text = ""
                txt_general_name_10.Text = ""
                Label4.Text = "Choose Client"

            Else
                txt_general_name_1.Text = ""

                txt_general_id_2.Enabled = True
                txt_general_id_3.Enabled = True
                txt_general_id_4.Enabled = True
                txt_general_id_5.Enabled = True
                txt_general_id_6.Enabled = True
                txt_general_id_7.Enabled = True
                txt_general_id_8.Enabled = True
                txt_general_id_9.Enabled = True
                txt_general_id_10.Enabled = True

                txt_general_id_1.Text = ""
                txt_general_id_2.Text = ""
                txt_general_id_3.Text = ""
                txt_general_id_4.Text = ""
                txt_general_id_5.Text = ""
                txt_general_id_6.Text = ""
                txt_general_id_7.Text = ""
                txt_general_id_8.Text = ""
                txt_general_id_9.Text = ""
                txt_general_id_10.Text = ""

                txt_general_name_1.Text = ""
                txt_general_name_2.Text = ""
                txt_general_name_3.Text = ""
                txt_general_name_4.Text = ""
                txt_general_name_5.Text = ""
                txt_general_name_6.Text = ""
                txt_general_name_7.Text = ""
                txt_general_name_8.Text = ""
                txt_general_name_9.Text = ""
                txt_general_name_10.Text = ""

                Label4.Text = "Choose Transaction Reference"
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub rdo_per_supplier_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_per_supplier.CheckedChanged
        validation()
    End Sub

    Private Sub rdo_per_transaction_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_per_transaction.CheckedChanged
        validation()
    End Sub
End Class