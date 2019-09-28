Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Public Class inputVat_DatFile
    Dim month As String
    Dim year As String
    Dim ds As New ds_InputVat
    Private _total_services As Decimal
    Private _capital_goods As Decimal
    Private _other_capital As Decimal
    Private _total_vat_amount As Decimal
    Private Sub saveAs_Click(sender As Object, e As EventArgs) Handles saveAs.Click
        If cmbMonth.SelectedValue > 9 Then
        Else
            month = String.Format("0{0}", cmbMonth.SelectedValue)
        End If
        Dim sql_header As String = String.Format("SELECT
	                                            a.isFiscal,
                                            IF (
	                                            a.isFiscal = 0,
	                                            12,
	                                            a.fiscal_month
                                            ) AS fiscal_month,
                                             a.fiscal_year,
                                             a.sys_beg,
                                             b.company_id,
                                             b.company_code,
                                             removeSpecialChar(b.company_name)company_name,
                                             removeSpecialChar(b.address1)address1,
                                             removeSpecialChar(b.address2)address2,
                                             b.currency_id,
                                             b.tel_no,
                                             b.fax_no,
                                             b.email_add,
                                             b.tin,
                                             b.beg_month,
                                             b.rdo_code,
                                             b.rdo_code,

                                            IF (
	                                            IFNULL(a.isFiscal, 0) = 1,
	                                            MONTHNAME(
		                                            STR_TO_DATE(
			                                            CONCAT(
				                                            a.fiscal_year,
				                                            '-',
				                                            a.fiscal_month,
				                                            '-01'
			                                            ),
			                                            '%Y-%m-%d'
		                                            )
	                                            ),
	                                            MONTHNAME(a.sys_beg)
                                            ) AS month_name,

                                            IF (
	                                            IFNULL(a.isFiscal, 0) = 1,
	                                            a.fiscal_year,
	                                            YEAR (a.sys_beg)
                                            ) AS year_name
                                            FROM
	                                            {0}.sys_default a
                                            LEFT JOIN {1}.lib_erp_company b ON b.company_id = a.company_id", _serverDBMain, _serverDBFS)
        Dim dt_header As DataTable = Query(sql_header)
        For Each draws As DataRow In dt_header.Rows
            ds_inputvats.Tables("company_info").ImportRow(draws)
        Next
        Dim newdt As DataTable = ds.Tables("inputvat_dat")
        Dim sql_BODY As String = String.Format("SELECT a.general_id,removeSpecialChar(a.general_code)general_code,removeSpecialChar(a.general_name)general_name,a.tin,removeSpecialChar(a.address1)address1,removeSpecialChar(a.address2)address2  " +
"                                        ,SUM(a.service_amount) AS service_amount,SUM(a.service_amount_based) AS service_amount_based  " +
"                                        ,SUM(a.capital_amount) AS capital_amount,SUM(a.capital_amount_based) AS capital_amount_based  " +
"                                        ,SUM(a.other_amount) AS other_amount,SUM(a.other_amount_based) AS other_amount_based  " +
"                                        ,SUM(a.vat_amount) AS vat_amount,SUM(a.vat_amount_based) AS vat_amount_based  " +
"                                        FROM(  " +
"                                                SELECT a.trans_id,a.trans_no,a.trans_date,b.jbooks_id,c.input_vat_id  " +
"                                                ,IF(c.vat_class = '1',remitted.net_amount,0) AS service_amount  " +
"                                                ,IF(c.vat_class = '2',remitted.net_amount,0) AS capital_amount  " +
"                                                ,IF(c.vat_class = '3',remitted.net_amount,0) AS other_amount  " +
"                                                ,IF(c.vat_class = '1',remitted.net_amount_based,0) AS service_amount_based  " +
"                                                ,IF(c.vat_class = '2',remitted.net_amount_based,0) AS capital_amount_based  " +
"                                                ,IF(c.vat_class = '3',remitted.net_amount_based,0) AS other_amount_based  " +
"                                                ,remitted.vat_amount,remitted.vat_amount_based  " +
"                                                ,0.00 AS excempt_amount,0.00 AS zero_amount  " +
"                                                ,c.general_id  " +
"                                                ,IF(IFNULL(d.tin,'') = '','000000000000',IF(REPLACE(d.tin,'-','') = '','000000000000',REPLACE(d.tin,'-',''))) AS tin  " +
"                                                ,d.general_code  " +
"                                                ,IFNULL(d.general_name_bir,d.general_name) AS general_name  " +
"                                                ,IFNULL(d.address1,'') AS address1  " +
"                                                ,IFNULL(d.address2,'') AS address2  " +
"                                                FROM {0}.trans_header a  " +
"                                                LEFT JOIN {0}.trans_jbooks b ON b.trans_id = a.trans_id  " +
"                                                LEFT JOIN {0}.trans_input_vat c ON c.jbooks_id = b.jbooks_id  " +
"                                                LEFT JOIN (  " +
"                                                        SELECT a.input_vat_id AS input_vat_id  " +
"                                                        ,SUM(a.vat_amount / 0.12) AS net_amount  " +
"                                                        ,SUM(a.vat_amount_based / 0.12) AS net_amount_based  " +
"                                                        ,SUM(a.vat_amount) AS vat_amount  " +
"                                                        ,SUM(a.vat_amount_based) AS vat_amount_based  " +
"                                                        FROM {0}.trans_input_vat a  " +
"                                                        WHERE IFNULL(a.for_importation,0) = 0 OR IFNULL(a.for_importation,'') = '' AND IFNULL(a.offset_type,0) = 0  " +
"                                                        GROUP BY IFNULL(a.input_vat_id,'')  " +
"                                                ) remitted ON remitted.input_vat_id = c.input_vat_id  " +
"                                                LEFT JOIN {1}.lib_erp_general d ON d.general_id = c.general_id  " +
"                                                WHERE IFNULL(remitted.net_amount,0) <> 0 AND IFNULL(c.vat_class,'') <> '' AND DATE_FORMAT(a.trans_date,'%m-%Y') = '{2}-{3}'  " +
"                                             ) a INNER JOIN {0}.trans_input_vat b ON a.input_vat_id = b.ref_input_vat_id WHERE   IFNULL(a.general_id,'') <> ''   " +
"                                                 GROUP BY a.general_id ", _serverDBMain, _serverDBFS, month, txt_year.Text)
        Dim dT As DataTable = Query(sql_BODY)
        If dt.Rows.Count = 0 Then
            MsgBox("No Record!", vbInformation + vbOKOnly)
            Exit Sub
        End If
        For Each draw As DataRow In dt.Rows
            ds.Tables("InputVat_dat").ImportRow(draw)
        Next
        'For x As Decimal = 0 To dt.Rows.Count - 1
        '    _total_services += ds.Tables("inputVat_dat").Rows(x).Item("service_amount")
        '    _capital_goods += ds.Tables("inputVat_dat").Rows(x).Item("capital_amount")
        '    _other_capital += ds.Tables("inputVat_dat").Rows(x).Item("other_amount")
        '    _total_vat_amount += ds.Tables("inputVat_dat").Rows(x).Item("vat_amount")
        '    x += 1
        'Next
        _total_services = ds.Tables("inputVat_dat").Compute("SUM(service_amount)", Nothing)
        _capital_goods = ds.Tables("inputVat_dat").Compute("SUM(capital_amount)", Nothing)
        _other_capital = ds.Tables("inputVat_dat").Compute("SUM(other_amount)", Nothing)
        _total_vat_amount = ds.Tables("inputVat_dat").Compute("SUM(vat_amount)", Nothing)
        If newdt.Rows.Count = 0 Then
            MsgBox("No Record!", vbInformation + vbOKOnly)
            Exit Sub
        End If
        If folderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileName As String = String.Format("{0}P{1}{2}.dat", ds_inputvats.Tables("company_info").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9), month.PadLeft(2, "0"), txt_year.Text)
            Dim path As String = folderBrowser.SelectedPath & "\" & fileName
            If File.Exists(path) Then
                Dim delete = MsgBox("File Already Exist.Do you Want to replace with the new one?", MsgBoxStyle.YesNo, "1601E")
                If delete = MsgBoxResult.No Then
                    Exit Sub
                End If
                File.Delete(fileName)
            End If
            Dim lastDay = GetLastDayOfMonth(cmbMonth.SelectedValue, txt_year.Value)
            Dim strDate = lastDay.ToString("MM/dd/yyyy")
            Dim fs As FileStream = File.Create(path)
            Dim rdo_code_length As Integer = If(ds.Tables("inputvat_dat").Rows(0).Item("tin").ToString.Replace("-", "").Substring(9).Length > 3, 4, 3)
            Dim HMAP = String.Format("H,P,""{0}"",""{1}"","""","""","""",""{1}"",""{2}"",""{3}"",0.00,0.00,{4},{5},{6},{7},{7},0.00,{8},{9},{10}",
                               ds_inputvats.Tables("company_info").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9),
                               ds_inputvats.Tables("company_info").Rows(0).Item("company_name").ToString.Replace(".", " ").Replace(",", " "),
                              ifNull(ds_inputvats.Tables("company_info").Rows(0).Item("address1").ToString.Replace(".", " ").Replace(",", " "), ""),
                                ifNull(ds_inputvats.Tables("company_info").Rows(0).Item("address2").ToString.Replace(".", " ").Replace(",", " "), ""),
                               Format(_total_services, "##0.00"),
                               Format(_capital_goods, "##0.00"),
                               Format(_other_capital, "##0.00"),
                               Format(_total_vat_amount, "##0.00"),
                              ds_inputvats.Tables("company_info").Rows(0).Item("rdo_code"),
                              strDate, ds_inputvats.Tables("company_info").Rows(0).Item("fiscal_month"))
            Dim DMAP As String = ""
            Dim ctr As Integer = 1
            Dim total_tax_rate As Decimal = 0
            Dim total_amount_based As Decimal = 0
            AddText(fs, HMAP)
            For Each dr As DataRow In ds.Tables("inputvat_dat").Rows
                DMAP = String.Format("D,P,""{0}"",""{1}"",,,,""{2}"",{3},0,0,{4},{5},{6},{7},{8},{9}",
                                       Trim(dr.Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9)),
                                        Trim(dr.Item("general_name").Replace(".", " ").Replace(",", " ")),
                                        Trim(dr.Item("address1").ToString.Replace(".", " ").Replace(",", " ")),
                                        Trim(dr.Item("address2").ToString.Replace(".", " ").Replace(",", " ")),
                                         Format(dr.Item("service_amount"), "##0.00"),
                                         Format(dr.Item("capital_amount"), "##0.00"),
                                         Format(dr.Item("other_amount"), "##0.00"),
                                         Format(dr.Item("vat_amount"), "##0.00"),
                                        Trim(ds_inputvats.Tables("company_info").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9)),
                                        Trim(strDate))
                AddText(fs, Environment.NewLine & DMAP)
                ctr += 1
            Next
            MsgBox("Saved!", vbInformation + MsgBoxStyle.OkOnly)
            ds.Tables("inputvat_dat").Clear()
            fs.Close()
        End If
    End Sub
    Private Shared Sub AddText(ByVal fs As FileStream, ByVal value As String)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(value)
        fs.Write(info, 0, info.Length)
    End Sub
    Private Sub inputVat_DatFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMonth.DataSource = main.listMonth
        cmbMonth.DisplayMember = "name"
        cmbMonth.ValueMember = "id"
    End Sub
End Class