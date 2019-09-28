Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Public Class inputVat_importation_DatFile
    Dim month As String
    Dim year As String
    'Dim ds As New ds_InputVats
    Private Dutiable_value As Decimal
    Private all_charges_before_release_from_customs As Decimal
    Private Exempt As Decimal
    Private Taxable_goods As Decimal
    Private vat_amount As Decimal
    Private Sub saveAs_Click(sender As Object, e As EventArgs) Handles saveAs.Click
        If cmbMonths.SelectedValue > 9 Then
        Else
            month = String.Format("0{0}", cmbMonths.SelectedValue)
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
                                             b.company_name,
                                             b.address1,
                                             b.address2,
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
        Dim newdt As DataTable = ds_inputvats.Tables("company_input_vat_totals")
        Dim sql As String = String.Format(" SELECT a.general_id,removeSpecialChar(a.general_code)general_code,removeSpecialChar(a.general_name)general_name   
                                        ,a.tin,removeSpecialChar(a.address1)address1,removeSpecialChar(a.address2)address2,  
                                        a.import_Entry_id,  
                                        a.Import_Entry_no,                  
                                         a.Release_Date,                   
                                         IFNULL(SUM(a.Total_Landed_Cost),0)Total_Landed_Cost,                   
                                         IFNULL(SUM(a.Taxable_goods),0)Taxable_goods,                   
                                         a.Date_of_importation,                   
                                         IFNULL(SUM(a.Dutiable_value),0)Dutiable_value,                   
                                         a.date_of_vatpayment,                   
                                         IFNULL(a.country_of_origin,'')country_of_origin,                   
                                         IFNULL(a.OR_number,'')OR_number,                   
                                         IFNULL(SUM(a.all_charges_before_release_from_customs),0)all_charges_before_release_from_customs,                   
                                         IFNULL(SUM(a.Exempt),0)Exempt,SUM(a.vat_amount) AS vat_amount,SUM(a.vat_amount_based) AS vat_amount_based                                            
                                         FROM(SELECT a.trans_id,a.trans_no,a.trans_date,b.jbooks_id,c.input_vat_id,  
                                             remitted.vat_amount,remitted.vat_amount_based,0.00 AS exempt_amount,0.00 AS                 zero_amount,c.general_id,  
                                            IF(IFNULL(d.tin,'') = '','000000000000',IF(REPLACE(d.tin,'-','') = '','000000000000',REPLACE(d.tin,'-',''))) AS tin,d.general_code,  
                                            IFNULL(d.general_name_bir,d.general_name) AS general_name,IFNULL(d.address1,'') AS address1,  
                                            IFNULL(d.address2,'') AS address2,                                              
                                            remitted.import_Entry_id,                                              
                                            remitted.Import_Entry_no,                                              
                                            remitted.Release_Date,                                              
                                            remitted.Total_Landed_Cost,                                              
                                            remitted.Taxable_goods,                                              
                                            remitted.Date_of_importation,                                              
                                            remitted.Dutiable_value,                                              
                                            remitted.date_of_vatpayment,                                              
                                            remitted.country_of_origin,remitted.OR_number,                                              
                                            remitted.all_charges_before_release_from_customs,                                              
                                            remitted.Exempt  
                                        FROM {0}.trans_header a  
                                            LEFT JOIN {0}.trans_jbooks b ON b.trans_id = a.trans_id  
                                            LEFT JOIN {0}.trans_input_vat c ON c.jbooks_id = b.jbooks_id  
                                            LEFT JOIN (  SELECT a.ref_input_vat_id AS input_vat_id  ,  
                                                SUM(a.vat_amount / 0.12) AS net_amount  ,  
                                                SUM(a.vat_amount_based / 0.12) AS net_amount_based  ,  
                                                SUM(a.vat_amount) AS vat_amount  ,  
                                                SUM(a.vat_amount_based) AS vat_amount_based    ,  
                                                b.import_Entry_id AS import_Entry_id  ,  
                                                b.import_Entry_no AS import_Entry_no  ,  
                                                b.release_date AS release_date  ,  
                                                SUM(b.total_landed_cost)Total_Landed_Cost  ,  
                                                SUM(b.taxable_goods)Taxable_goods  ,  
                                                b.date_of_importation AS date_of_importation  ,  
                                                SUM(b.dutiable_value)Dutiable_value  ,  
                                                b.date_of_vatpayment AS date_of_vatpayment  ,  
                                                b.country_of_origin  AS country_of_origin   ,  
                                                b.OR_number AS OR_number  ,  
                                                SUM(b.all_charges_before_release_from_customs)all_charges_before_release_from_customs  ,  
                                                SUM(b.exempt)Exempt   
                                         FROM {0}.trans_input_vat a    
                                         INNER join {0}.trans_input_vat_importation b ON a.ref_input_vat_id = b.input_vat_id    
                                              WHERE    IFNULL(a.for_importation,0) = 1 
                                                GROUP BY IFNULL(a.ref_input_vat_id,'')) remitted ON remitted.input_vat_id = c.input_vat_id  
                                        LEFT  JOIN {1}.lib_erp_general d ON d.general_id = c.general_id  
                                        WHERE IFNULL(remitted.net_amount,0) <> 0 AND DATE_FORMAT(a.trans_date,'%m-%Y') ='{2}-{3}') a   
                                        GROUP BY a.general_id", _serverDBMain, _serverDBFS, month, txt_years.Text)
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("No Record!", vbInformation + vbOKOnly)
            Exit Sub
        End If
        For Each draw As DataRow In dt.Rows
            ds_inputvats.Tables("company_input_vat_totals").ImportRow(draw)
        Next

        all_charges_before_release_from_customs = ds_inputvats.Tables("company_input_vat_totals").Compute("SUM(all_charges_before_release_from_customs)", Nothing)
        Exempt = ds_inputvats.Tables("company_input_vat_totals").Compute("SUM(Exempt)", Nothing)
        Taxable_goods = ds_inputvats.Tables("company_input_vat_totals").Compute("SUM(Taxable_goods)", Nothing)
        vat_amount = ds_inputvats.Tables("company_input_vat_totals").Compute("SUM(vat_amount)", Nothing)
        Dutiable_value = ds_inputvats.Tables("company_input_vat_totals").Compute("SUM(Dutiable_value)", Nothing)
        If newdt.Rows.Count = 0 Then
            MsgBox("No Record!", vbInformation + vbOKOnly)
            Exit Sub
        End If
        If folderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileName As String = String.Format("{0}I{1}{2}.dat", ds_inputvats.Tables("company_info").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9), month.PadLeft(2, "0"), txt_years.Text)
            Dim path As String = folderBrowser.SelectedPath & "\" & fileName
            If File.Exists(path) Then
                Dim delete = MsgBox("File Already Exist.Do you Want to replace with the new one?", MsgBoxStyle.YesNo, "1601E")
                If delete = MsgBoxResult.No Then
                    Exit Sub
                End If
                File.Delete(fileName)
            End If
            Dim lastDay = GetLastDayOfMonth(cmbMonths.SelectedValue, txt_years.Value)
            Dim strDate = lastDay.ToString("MM/dd/yyyy")
            Dim fs As FileStream = File.Create(path)
            Dim TIN As String = ds_inputvats.Tables("company_info").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9)
            Dim rdo_code_length As Integer = If(ds_inputvats.Tables("company_input_vat_totals").Rows(0).Item("tin").ToString.Replace("-", "").Substring(9).Length > 3, 4, 3)
            Dim HMAP = String.Format("H,I,""{0}"",""{1}"","""","""","""",""{1}"",""{2}"",""{3}"",{4},{5},{6},{7},{8},{9},{10},{11}",
                               ds_inputvats.Tables("company_info").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9),
                               ds_inputvats.Tables("company_info").Rows(0).Item("company_name").ToString.Replace(".", " ").Replace(",", " "),
                              ifNull(ds_inputvats.Tables("company_info").Rows(0).Item("address1").ToString.Replace(".", " ").Replace(",", " "), ""),
                                ifNull(ds_inputvats.Tables("company_info").Rows(0).Item("address2").ToString.Replace(".", " ").Replace(",", " "), ""),
                                Format(Dutiable_value, "##0.00"),
                                Format(all_charges_before_release_from_customs, "##0.00"),
                               Format(Exempt, "##0.00"),
                               Format(Taxable_goods, "##0.00"),
                               Format(vat_amount, "##0.00"),
                              ds_inputvats.Tables("company_info").Rows(0).Item("rdo_code"),
                              strDate,
                              ds_inputvats.Tables("company_info").Rows(0).Item("fiscal_month")
                              )
            Dim DMAP As String = ""
            Dim ctr As Integer = 1
            Dim total_tax_rate As Decimal = 0
            Dim total_amount_based As Decimal = 0
            AddText(fs, HMAP)
            For Each dr As DataRow In ds_inputvats.Tables("company_input_vat_totals").Rows
                DMAP = String.Format("D,I,""{0}"",{1},""{2}"",{3},""{4}"",{5},{6},{7},{8},{9},""{10}"",{11},""{12}"",{13}",
                                       Trim(dr.Item("import_Entry_no")),
                                       Convert.ToDateTime(dr.Item("release_date")).ToString("MM/dd/yyyy"),
                                        Trim(dr.Item("general_name").ToString.Replace(".", " ").Replace(",", " ")),
                                        Convert.ToDateTime(dr.Item("date_of_importation")).ToString("MM/dd/yyyy"),
                                         Format(dr.Item("country_of_origin"), ""),
                                         Format(dr.Item("dutiable_value"), "##0.00"),
                                         Format(dr.Item("all_charges_before_release_from_customs"), "##0.00"),
                                         Format(dr.Item("Exempt"), "##0.00"),
                                        Format(dr.Item("Taxable_goods"), "##0.00"),
                                        Format(dr.Item("vat_amount"), "##0.00"),
                                        dr.Item("or_number"),
                                        Convert.ToDateTime(dr.Item("date_of_vatpayment")).ToString("MM/dd/yyyy"),
                                        TIN,
                                        Trim(strDate))
                AddText(fs, Environment.NewLine & DMAP)
                ctr += 1
            Next
            MsgBox("Saved!", vbInformation + MsgBoxStyle.OkOnly)
            ds_inputvats.Tables("company_input_vat_totals").clear
            fs.Close()
        End If
    End Sub
    Private Shared Sub AddText(ByVal fs As FileStream, ByVal value As String)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(value)
        fs.Write(info, 0, info.Length)
    End Sub
    Private Sub inputVat_DatFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMonths.DataSource = main.listMonth
        cmbMonths.DisplayMember = "name"
        cmbMonths.ValueMember = "id"
    End Sub
End Class